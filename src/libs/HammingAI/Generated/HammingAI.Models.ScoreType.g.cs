
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScoreType
    {
        /// <summary>
        /// 
        /// </summary>
        AccuracyAi,
        /// <summary>
        /// 
        /// </summary>
        ContextPrecision,
        /// <summary>
        /// 
        /// </summary>
        ContextRecall,
        /// <summary>
        /// 
        /// </summary>
        FactsCompare,
        /// <summary>
        /// 
        /// </summary>
        Hallucination,
        /// <summary>
        /// 
        /// </summary>
        Refusal,
        /// <summary>
        /// 
        /// </summary>
        SqlAst,
        /// <summary>
        /// 
        /// </summary>
        StringDiff,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScoreTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScoreType value)
        {
            return value switch
            {
                ScoreType.AccuracyAi => "accuracy_ai",
                ScoreType.ContextPrecision => "context_precision",
                ScoreType.ContextRecall => "context_recall",
                ScoreType.FactsCompare => "facts_compare",
                ScoreType.Hallucination => "hallucination",
                ScoreType.Refusal => "refusal",
                ScoreType.SqlAst => "sql_ast",
                ScoreType.StringDiff => "string_diff",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScoreType? ToEnum(string value)
        {
            return value switch
            {
                "accuracy_ai" => ScoreType.AccuracyAi,
                "context_precision" => ScoreType.ContextPrecision,
                "context_recall" => ScoreType.ContextRecall,
                "facts_compare" => ScoreType.FactsCompare,
                "hallucination" => ScoreType.Hallucination,
                "refusal" => ScoreType.Refusal,
                "sql_ast" => ScoreType.SqlAst,
                "string_diff" => ScoreType.StringDiff,
                _ => null,
            };
        }
    }
}