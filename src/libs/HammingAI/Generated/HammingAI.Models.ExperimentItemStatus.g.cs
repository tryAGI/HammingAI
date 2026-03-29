
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExperimentItemStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Created,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Scored,
        /// <summary>
        /// 
        /// </summary>
        Scoring,
        /// <summary>
        /// 
        /// </summary>
        ScoringFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExperimentItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentItemStatus value)
        {
            return value switch
            {
                ExperimentItemStatus.Created => "CREATED",
                ExperimentItemStatus.Failed => "FAILED",
                ExperimentItemStatus.Scored => "SCORED",
                ExperimentItemStatus.Scoring => "SCORING",
                ExperimentItemStatus.ScoringFailed => "SCORING_FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => ExperimentItemStatus.Created,
                "FAILED" => ExperimentItemStatus.Failed,
                "SCORED" => ExperimentItemStatus.Scored,
                "SCORING" => ExperimentItemStatus.Scoring,
                "SCORING_FAILED" => ExperimentItemStatus.ScoringFailed,
                _ => null,
            };
        }
    }
}