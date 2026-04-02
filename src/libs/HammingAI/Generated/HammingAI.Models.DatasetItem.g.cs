#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DatasetItem : global::System.IEquatable<DatasetItem>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HammingAI.DatasetItemValue? Value { get; init; }
#else
        public global::HammingAI.DatasetItemValue? Value { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value))]
#endif
        public bool IsValue => Value != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HammingAI.DatasetItemVariant2? DatasetItemVariant2 { get; init; }
#else
        public global::HammingAI.DatasetItemVariant2? DatasetItemVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DatasetItemVariant2))]
#endif
        public bool IsDatasetItemVariant2 => DatasetItemVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DatasetItem(global::HammingAI.DatasetItemValue value) => new DatasetItem((global::HammingAI.DatasetItemValue?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HammingAI.DatasetItemValue?(DatasetItem @this) => @this.Value;

        /// <summary>
        /// 
        /// </summary>
        public DatasetItem(global::HammingAI.DatasetItemValue? value)
        {
            Value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DatasetItem(global::HammingAI.DatasetItemVariant2 value) => new DatasetItem((global::HammingAI.DatasetItemVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HammingAI.DatasetItemVariant2?(DatasetItem @this) => @this.DatasetItemVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DatasetItem(global::HammingAI.DatasetItemVariant2? value)
        {
            DatasetItemVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DatasetItem(
            global::HammingAI.DatasetItemValue? value,
            global::HammingAI.DatasetItemVariant2? datasetItemVariant2
            )
        {
            Value = value;
            DatasetItemVariant2 = datasetItemVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DatasetItemVariant2 as object ??
            Value as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value?.ToString() ??
            DatasetItemVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue && IsDatasetItemVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HammingAI.DatasetItemValue?, TResult>? value = null,
            global::System.Func<global::HammingAI.DatasetItemVariant2?, TResult>? datasetItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue && value != null)
            {
                return value(Value!);
            }
            else if (IsDatasetItemVariant2 && datasetItemVariant2 != null)
            {
                return datasetItemVariant2(DatasetItemVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HammingAI.DatasetItemValue?>? value = null,
            global::System.Action<global::HammingAI.DatasetItemVariant2?>? datasetItemVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue)
            {
                value?.Invoke(Value!);
            }
            else if (IsDatasetItemVariant2)
            {
                datasetItemVariant2?.Invoke(DatasetItemVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value,
                typeof(global::HammingAI.DatasetItemValue),
                DatasetItemVariant2,
                typeof(global::HammingAI.DatasetItemVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(DatasetItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HammingAI.DatasetItemValue?>.Default.Equals(Value, other.Value) &&
                global::System.Collections.Generic.EqualityComparer<global::HammingAI.DatasetItemVariant2?>.Default.Equals(DatasetItemVariant2, other.DatasetItemVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DatasetItem obj1, DatasetItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DatasetItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DatasetItem obj1, DatasetItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DatasetItem o && Equals(o);
        }
    }
}
