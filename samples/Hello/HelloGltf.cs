/*
 * HelloGltf
 *
 * Parses a tiny inline glTF (one triangle), reads its vertex positions and saves it back out.
 */

// Brutal.Gltf uses reflection-based System.Text.Json, which Native AOT (the default for
// file-based apps) disables.
#:property PublishAot=false
#:package Ahwoo.Brutal.Gltf@2026.10.3

using System.Runtime.InteropServices;
using Brutal.GltfApi;

// A single triangle, with its vertex positions embedded as a base64 buffer.
float[] positions = [0, 0, 0, 1, 0, 0, 0, 1, 0];
var buffer = Convert.ToBase64String(MemoryMarshal.AsBytes(positions.AsSpan()));

var json = $$"""
{
  "asset": { "version": "2.0" },
  "scene": 0,
  "scenes": [{ "nodes": [0] }],
  "nodes": [{ "name": "Triangle", "mesh": 0 }],
  "meshes": [{ "primitives": [{ "attributes": { "POSITION": 0 } }] }],
  "buffers": [{ "uri": "data:application/octet-stream;base64,{{buffer}}", "byteLength": 36 }],
  "bufferViews": [{ "buffer": 0, "byteLength": 36 }],
  "accessors": [{ "bufferView": 0, "componentType": 5126, "count": 3, "type": "VEC3", "min": [0, 0, 0], "max": [1, 1, 0] }]
}
""";

var model = GltfUtility.DeserializeModelJson(json);
Console.WriteLine(
    $"glTF {model.Asset.Version}: {model.Scenes.Length} scene, {model.Nodes.Length} node, {model.Meshes.Length} mesh"
);

var node = model.Nodes[0];
var accessor = model.Accessors[model.Meshes[node.Mesh!.Value].Primitives[0].Attributes["POSITION"]];

// Reading from byte 0 works because this buffer holds only tightly packed positions; real files need the
// accessor and buffer view offsets and stride (see ReadFloat3s in Demo/DemoGltfViewer.cs). The second
// argument is the folder that relative buffer URIs are resolved against.
var vertices = MemoryMarshal.Cast<byte, float>(model.LoadBinaryBuffer(0, Path.GetTempPath()));
Console.WriteLine($"Node '{node.Name}' has {accessor.Count} vertices:");
for (var i = 0; i < accessor.Count; i++)
    Console.WriteLine($"  ({vertices[i * 3]}, {vertices[i * 3 + 1]}, {vertices[i * 3 + 2]})");

var path = Path.Combine(Path.GetTempPath(), "HelloGltf.gltf");
model.SaveModel(path);
Console.WriteLine($"Wrote {path}");
