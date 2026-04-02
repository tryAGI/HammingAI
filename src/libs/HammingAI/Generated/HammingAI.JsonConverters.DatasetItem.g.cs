#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace HammingAI.JsonConverters
{
    /// <inheritdoc />
    public class DatasetItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::HammingAI.DatasetItem>
    {
        /// <inheritdoc />
        public override global::HammingAI.DatasetItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("input")) __score0++;
            if (__jsonProps.Contains("metadata")) __score0++;
            if (__jsonProps.Contains("output")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("id")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::HammingAI.DatasetItemValue? value = default;
            global::HammingAI.DatasetItemVariant2? datasetItemVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HammingAI.DatasetItemValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HammingAI.DatasetItemValue> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HammingAI.DatasetItemValue).Name}");
                        value = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HammingAI.DatasetItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HammingAI.DatasetItemVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HammingAI.DatasetItemVariant2).Name}");
                        datasetItemVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (value == null && datasetItemVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HammingAI.DatasetItemValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HammingAI.DatasetItemValue> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HammingAI.DatasetItemValue).Name}");
                    value = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HammingAI.DatasetItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HammingAI.DatasetItemVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HammingAI.DatasetItemVariant2).Name}");
                    datasetItemVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::HammingAI.DatasetItem(
                value,

                datasetItemVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::HammingAI.DatasetItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsValue)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HammingAI.DatasetItemValue), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HammingAI.DatasetItemValue?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HammingAI.DatasetItemValue).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Value!, typeInfo);
            }
            else if (value.IsDatasetItemVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::HammingAI.DatasetItemVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::HammingAI.DatasetItemVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::HammingAI.DatasetItemVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DatasetItemVariant2!, typeInfo);
            }
        }
    }
}