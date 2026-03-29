
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::HammingAI.JsonConverters.ExperimentStatusJsonConverter),

            typeof(global::HammingAI.JsonConverters.ExperimentStatusNullableJsonConverter),

            typeof(global::HammingAI.JsonConverters.ExperimentItemStatusJsonConverter),

            typeof(global::HammingAI.JsonConverters.ExperimentItemStatusNullableJsonConverter),

            typeof(global::HammingAI.JsonConverters.ScoreTypeJsonConverter),

            typeof(global::HammingAI.JsonConverters.ScoreTypeNullableJsonConverter),

            typeof(global::HammingAI.JsonConverters.DatasetItemJsonConverter),

            typeof(global::HammingAI.JsonConverters.DatasetWithItemsJsonConverter),

            typeof(global::HammingAI.JsonConverters.PromptWithContentJsonConverter),

            typeof(global::HammingAI.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.DatasetItemValue))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.DatasetItem), TypeInfoPropertyName = "DatasetItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.DatasetItemVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.Dataset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.DatasetWithItems), TypeInfoPropertyName = "DatasetWithItems2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.DatasetWithItemsVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HammingAI.DatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.CreateDatasetRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HammingAI.DatasetItemValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.ListDatasetsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HammingAI.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.GetDatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.CreateDatasetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.ExperimentStatus), TypeInfoPropertyName = "ExperimentStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.ExperimentItemStatus), TypeInfoPropertyName = "ExperimentItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.ScoreType), TypeInfoPropertyName = "ScoreType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.Experiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.ExperimentItemMetrics))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.Score))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.ExperimentItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.CreateExperimentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.CreateExperimentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.UpdateExperimentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.CreateExperimentItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.CreateExperimentItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.UpdateExperimentItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::HammingAI.Score>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.CustomScoringConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.RegisterScoringFunctionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HammingAI.RegisterScoringFunctionsRequestScoringItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.RegisterScoringFunctionsRequestScoringItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.RegisterScoringFunctionsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HammingAI.CustomScoringConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.TraceEvent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.ExperimentTrace))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.CreateTracesRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HammingAI.ExperimentTrace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.CreateSessionRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.CreateSessionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.PromptSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.ChatMessage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.PromptContent))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HammingAI.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.Prompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.PromptWithContent), TypeInfoPropertyName = "PromptWithContent2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.PromptWithContentVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.ListPromptsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HammingAI.Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.GetPromptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.RunVoiceAgentRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.RunVoiceAgentResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.VoiceExperiment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.VoiceExperimentCall))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.VoiceExperimentCallsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HammingAI.VoiceExperimentCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.CreateLiveKitRoomsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.LiveKitRoom))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.CreateLiveKitRoomsResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::HammingAI.LiveKitRoom>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.CallLogEntry))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::HammingAI.CreateCallLogRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HammingAI.DatasetItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HammingAI.DatasetItemValue>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HammingAI.Dataset>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HammingAI.RegisterScoringFunctionsRequestScoringItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HammingAI.CustomScoringConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HammingAI.ExperimentTrace>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HammingAI.ChatMessage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HammingAI.Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HammingAI.VoiceExperimentCall>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::HammingAI.LiveKitRoom>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}