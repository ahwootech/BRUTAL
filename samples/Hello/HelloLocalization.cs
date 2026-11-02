/*
 * HelloLocalization
 *
 * Formats localised strings with named variables, then swaps in a French translation.
 */

#:package Ahwoo.Brutal.Localization@2026.10.3

using System.Diagnostics.CodeAnalysis;
using Brutal.Localization;

var greeting = LStrings.Create("Greeting", "Hello {NAME}, you have {COUNT} new messages");

Console.WriteLine(greeting.Format("Alice", 3));

// A string provider supplies the localized text; replacement variables may be reordered.
var french = new Dictionary<string, string> { ["Greeting"] = "{COUNT} nouveaux messages pour vous, {NAME}" };

bool FrenchProvider(LString lString, [NotNullWhen(true)] out string? text) =>
    french.TryGetValue(lString.Id.ToString(), out text);

LStrings.SetLocalizedStringProvider(FrenchProvider);

Console.WriteLine(greeting.Format("Alice", 3));
