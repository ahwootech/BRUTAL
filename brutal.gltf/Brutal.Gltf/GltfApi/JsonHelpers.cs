using System.Text.Json;
using System.Text.Json.Serialization;

namespace Brutal.GltfApi;

/// <summary>
/// Helpers for JSON serialization and deserialization of common types used in GLTF.
/// This includes converters for float3, float4, floatQuat, and float4x4
/// </summary>
public static class JsonHelpers
{
    /// <summary>
    /// Converter for <see cref="float3"/> to/from JSON.
    /// </summary>
    public class Float3JsonConverter : JsonConverter<float3>
    {
        /// <inheritdoc />
        public override float3 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException("Expected start of array for Vec3.");
            }

            // Read X
            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException("Expected number for X component of Vec3.");
            }
            var x = reader.GetSingle();

            // Read Y
            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException("Expected number for Y component of Vec3.");
            }
            var y = reader.GetSingle();

            // Read Z
            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException("Expected number for Z component of Vec3.");
            }
            var z = reader.GetSingle();

            // Ensure end of array
            reader.Read();
            if (reader.TokenType != JsonTokenType.EndArray)
            {
                throw new JsonException("Expected end of array for Vec3.");
            }

            return new float3(x, y, z);
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, float3 value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteNumberValue(value.X);
            writer.WriteNumberValue(value.Y);
            writer.WriteNumberValue(value.Z);
            writer.WriteEndArray();
        }
    }

    /// <summary>
    /// Converter for <see cref="float4"/> to/from JSON.
    /// </summary>
    public class Float4JsonConverter : JsonConverter<float4>
    {
        /// <inheritdoc />
        public override float4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException("Expected start of array for Vec4.");
            }

            // Read X
            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException("Expected number for X component of Vec4.");
            }
            var x = reader.GetSingle();

            // Read Y
            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException("Expected number for Y component of Vec4.");
            }
            var y = reader.GetSingle();

            // Read Z
            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException("Expected number for Z component of Vec4.");
            }
            var z = reader.GetSingle();

            // Read W
            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException("Expected number for W component of Vec4.");
            }
            var w = reader.GetSingle();

            // Ensure end of array
            reader.Read();
            if (reader.TokenType != JsonTokenType.EndArray)
            {
                throw new JsonException("Expected end of array for Vec4.");
            }

            return new float4(x, y, z, w);
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, float4 value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteNumberValue(value.X);
            writer.WriteNumberValue(value.Y);
            writer.WriteNumberValue(value.Z);
            writer.WriteNumberValue(value.W);
            writer.WriteEndArray();
        }
    }

    /// <summary>
    /// Converter for <see cref="float4"/> to/from JSON.
    /// </summary>
    public class FloatQuatJsonConverter : JsonConverter<floatQuat>
    {
        /// <inheritdoc />
        public override floatQuat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException("Expected start of array for Quaternion.");
            }

            // Read X
            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException("Expected number for X component of Quaternion.");
            }
            var x = reader.GetSingle();

            // Read Y
            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException("Expected number for Y component of Quaternion.");
            }
            var y = reader.GetSingle();

            // Read Z
            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException("Expected number for Z component of Quaternion.");
            }
            var z = reader.GetSingle();

            // Read W
            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException("Expected number for W component of Quaternion.");
            }
            var w = reader.GetSingle();

            // Ensure end of array
            reader.Read();
            if (reader.TokenType != JsonTokenType.EndArray)
            {
                throw new JsonException("Expected end of array for Quaternion.");
            }

            return new floatQuat(x, y, z, w);
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, floatQuat value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            writer.WriteNumberValue(value.X);
            writer.WriteNumberValue(value.Y);
            writer.WriteNumberValue(value.Z);
            writer.WriteNumberValue(value.W);
            writer.WriteEndArray();
        }
    }

    /// <summary>
    /// Converter for <see cref="float4"/> to/from JSON.
    /// </summary>
    public class Float4X4JsonConverter : JsonConverter<float4x4>
    {
        /// <inheritdoc />
        public override float4x4 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException("Expected start of array for Float4x4.");
            }

            Span<float> components = stackalloc float[16];
            for (var i = 0; i < 16; i++)
            {
                // Read each component
                reader.Read();
                if (reader.TokenType != JsonTokenType.Number)
                {
                    throw new JsonException($"Expected number for component {i} of Float4x4.");
                }
                components[i] = reader.GetSingle();
            }
            // Ensure end of array
            reader.Read();
            if (reader.TokenType != JsonTokenType.EndArray)
            {
                throw new JsonException("Expected end of array for Float4x4.");
            }
            return new float4x4(components);
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, float4x4 value, JsonSerializerOptions options)
        {
            writer.WriteStartArray();
            var span = value.AsSpan();
            for (var i = 0; i < 16; i++)
            {
                writer.WriteNumberValue(span[i]);
            }
            writer.WriteEndArray();
        }
    }
}
