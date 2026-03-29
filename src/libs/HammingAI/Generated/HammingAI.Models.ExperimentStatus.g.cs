
#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExperimentStatus
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
        Finished,
        /// <summary>
        /// 
        /// </summary>
        Running,
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
    public static class ExperimentStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExperimentStatus value)
        {
            return value switch
            {
                ExperimentStatus.Created => "CREATED",
                ExperimentStatus.Failed => "FAILED",
                ExperimentStatus.Finished => "FINISHED",
                ExperimentStatus.Running => "RUNNING",
                ExperimentStatus.Scoring => "SCORING",
                ExperimentStatus.ScoringFailed => "SCORING_FAILED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExperimentStatus? ToEnum(string value)
        {
            return value switch
            {
                "CREATED" => ExperimentStatus.Created,
                "FAILED" => ExperimentStatus.Failed,
                "FINISHED" => ExperimentStatus.Finished,
                "RUNNING" => ExperimentStatus.Running,
                "SCORING" => ExperimentStatus.Scoring,
                "SCORING_FAILED" => ExperimentStatus.ScoringFailed,
                _ => null,
            };
        }
    }
}