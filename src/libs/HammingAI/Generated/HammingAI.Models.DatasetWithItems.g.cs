#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DatasetWithItems : global::System.IEquatable<DatasetWithItems>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HammingAI.Dataset? Dataset { get; init; }
#else
        public global::HammingAI.Dataset? Dataset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dataset))]
#endif
        public bool IsDataset => Dataset != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HammingAI.DatasetWithItemsVariant2? DatasetWithItemsVariant2 { get; init; }
#else
        public global::HammingAI.DatasetWithItemsVariant2? DatasetWithItemsVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DatasetWithItemsVariant2))]
#endif
        public bool IsDatasetWithItemsVariant2 => DatasetWithItemsVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DatasetWithItems(global::HammingAI.Dataset value) => new DatasetWithItems((global::HammingAI.Dataset?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HammingAI.Dataset?(DatasetWithItems @this) => @this.Dataset;

        /// <summary>
        /// 
        /// </summary>
        public DatasetWithItems(global::HammingAI.Dataset? value)
        {
            Dataset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DatasetWithItems(global::HammingAI.DatasetWithItemsVariant2 value) => new DatasetWithItems((global::HammingAI.DatasetWithItemsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HammingAI.DatasetWithItemsVariant2?(DatasetWithItems @this) => @this.DatasetWithItemsVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DatasetWithItems(global::HammingAI.DatasetWithItemsVariant2? value)
        {
            DatasetWithItemsVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DatasetWithItems(
            global::HammingAI.Dataset? dataset,
            global::HammingAI.DatasetWithItemsVariant2? datasetWithItemsVariant2
            )
        {
            Dataset = dataset;
            DatasetWithItemsVariant2 = datasetWithItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DatasetWithItemsVariant2 as object ??
            Dataset as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Dataset?.ToString() ??
            DatasetWithItemsVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDataset && IsDatasetWithItemsVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HammingAI.Dataset?, TResult>? dataset = null,
            global::System.Func<global::HammingAI.DatasetWithItemsVariant2?, TResult>? datasetWithItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDataset && dataset != null)
            {
                return dataset(Dataset!);
            }
            else if (IsDatasetWithItemsVariant2 && datasetWithItemsVariant2 != null)
            {
                return datasetWithItemsVariant2(DatasetWithItemsVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HammingAI.Dataset?>? dataset = null,
            global::System.Action<global::HammingAI.DatasetWithItemsVariant2?>? datasetWithItemsVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDataset)
            {
                dataset?.Invoke(Dataset!);
            }
            else if (IsDatasetWithItemsVariant2)
            {
                datasetWithItemsVariant2?.Invoke(DatasetWithItemsVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Dataset,
                typeof(global::HammingAI.Dataset),
                DatasetWithItemsVariant2,
                typeof(global::HammingAI.DatasetWithItemsVariant2),
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
        public bool Equals(DatasetWithItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HammingAI.Dataset?>.Default.Equals(Dataset, other.Dataset) &&
                global::System.Collections.Generic.EqualityComparer<global::HammingAI.DatasetWithItemsVariant2?>.Default.Equals(DatasetWithItemsVariant2, other.DatasetWithItemsVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DatasetWithItems obj1, DatasetWithItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DatasetWithItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DatasetWithItems obj1, DatasetWithItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DatasetWithItems o && Equals(o);
        }
    }
}
