using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Brutal.Localization.ResX
{
    // The ResX reading and writing code is taken from a github project. It should be thought of as
    // a temporary solution to reading and writing ResX files that support strings only.
    // https://github.com/winscripter/resx-net
    // The source code is under the MIT License. See the file ResX.Net.LICENSE under the Resources.ResX.NET folder.

    /// <summary>
    /// Parses and builds a ResX file. This class cannot be inherited.
    /// </summary>
    /// <remarks>
    /// The code for ResX reading and writing is provided by github project https://github.com/winscripter/resx-net under
    /// the following license.
    ///
    /// MIT License
    ///
    /// Copyright (c) 2024 winscripter
    ///
    /// Permission is hereby granted, free of charge, to any person obtaining a copy
    /// of this software and associated documentation files (the "Software"), to deal
    /// in the Software without restriction, including without limitation the rights
    /// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    /// copies of the Software, and to permit persons to whom the Software is
    /// furnished to do so, subject to the following conditions:
    ///
    /// The above copyright notice and this permission notice shall be included in all
    /// copies or substantial portions of the Software.
    ///
    /// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    /// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    /// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    /// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    /// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    /// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    /// SOFTWARE.
    /// </remarks>
    public sealed partial class ResXFile
    {
        /// <summary>
        /// A list of descendant ResX data tags.
        /// </summary>
        /// inside an IResourceWriter etc.
        public Dictionary<string, ResXData> DataDictionary { get; private set; }

        /// <summary>
        /// Create a ResXFile instance and populate it with data from an IEnumerable.
        /// </summary>
        /// <param name="dataList">IEnumerable&lt;<see cref="ResXData"/>&gt; to populate with.</param>
        public ResXFile(IEnumerable<ResXData> dataList)
        {
            DataDictionary = dataList.ToDictionary<ResXData, string>(item => item.Name);
        }

        /// <summary>
        /// Create a ResXFile instance and populate it with data from Dictionary.
        /// </summary>
        /// <param name="dataList">Dictionary&lt;string, <see cref="ResXData"/>&gt; to populate with.</param>
        public ResXFile(Dictionary<string, ResXData> dataList)
        {
            DataDictionary = dataList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResXFile"/> class.
        /// </summary>
        public ResXFile()
            : this(new List<ResXData>()) { }

        /// <summary>
        /// Builds a ResX formatted string from the contents of the <see cref="ResXFile"/>.
        /// </summary>
        /// <returns>string content of ResX.</returns>
        public string Build()
        {
            var builder = new StringBuilder();
            builder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            builder.AppendLine("<root>");

            builder.AppendLine(
                string.Join(
                    "\r\n",
                    RootHeader
                        .Split(["\r\n"], StringSplitOptions.None)
                        .Select(line =>
                        {
                            var nestedBuilder = new StringBuilder();
                            nestedBuilder.Append("  ");
                            nestedBuilder.Append(line);
                            return nestedBuilder.ToString();
                        })
                )
            );

            foreach (var data in DataDictionary.Values)
            {
                var dataElement = new XElement(
                    "data",
                    new XAttribute("name", data.Name),
                    new XAttribute(XNamespace.Xml + "space", "preserve"),
                    new XElement("value", data.Value)
                );
                if (data.Comment is not null)
                {
                    dataElement.Add(new XElement("comment", data.Comment));
                }

                builder.AppendLine(dataElement.ToString());
            }

            builder.AppendLine("</root>");
            return builder.ToString();
        }

        /// <summary>
        /// Parses the raw plain text of the ResX file into an enumerable of
        /// <see cref="ResXData"/>.
        /// </summary>
        /// <param name="rawText">Input plain text of the ResX file.</param>
        /// <returns>An enumerable of <see cref="ResXData"/>.</returns>
        /// <exception cref="XmlException">In this method, thrown when the root tag is missing.</exception>
        /// <exception cref="ResXBadRootTagException">In this method, thrown when the root tag name is not "root".</exception>
        /// <exception cref="ResXNoAttributeException">In this method, thrown when the data tag does not have the required attribute.</exception>
        /// <exception cref="ResXNoValueException">In this method, thrown when the data tag does not have a child &lt;value&gt; tag.</exception>
        public static Dictionary<string, ResXData> Parse(string rawText)
        {
            var rootTag =
                XDocument.Parse(rawText).Root ?? throw new XmlException("Root tag is missing");
            if (!rootTag.Name.LocalName.Equals("root", StringComparison.CurrentCultureIgnoreCase))
            {
                throw new ResXBadRootTagException(
                    $"Root tag of the ResX file is \"{rootTag.Name.LocalName}\", but expected \"root\""
                );
            }

            var resxData = new Dictionary<string, ResXData>();
            foreach (var descendant in rootTag.Elements())
            {
                if (
                    !descendant.Name.LocalName.Equals(
                        "data",
                        StringComparison.CurrentCultureIgnoreCase
                    )
                )
                {
                    continue;
                }

                var nameAttribute =
                    descendant.Attribute("name")?.Value
                    ?? throw new ResXNoAttributeException("No attribute named \"name\"");
                var value =
                    descendant
                        .Descendants()
                        .FirstOrDefault(tag =>
                            tag.Name.LocalName.Equals(
                                "value",
                                StringComparison.CurrentCultureIgnoreCase
                            )
                        )
                        ?.Value
                    ?? throw new ResXNoValueException(
                        "Data does not have descendant element of type \"value\""
                    );
                var comment = descendant
                    .Descendants()
                    .FirstOrDefault(tag =>
                        tag.Name.LocalName.Equals(
                            "comment",
                            StringComparison.CurrentCultureIgnoreCase
                        )
                    )
                    ?.Value;

                resxData.Add(nameAttribute, new ResXData(nameAttribute, value, comment));
            }

            return resxData;
        }
    }
}
