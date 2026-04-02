#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace HammingAI
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PromptWithContent : global::System.IEquatable<PromptWithContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HammingAI.Prompt? Prompt { get; init; }
#else
        public global::HammingAI.Prompt? Prompt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Prompt))]
#endif
        public bool IsPrompt => Prompt != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::HammingAI.PromptWithContentVariant2? PromptWithContentVariant2 { get; init; }
#else
        public global::HammingAI.PromptWithContentVariant2? PromptWithContentVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PromptWithContentVariant2))]
#endif
        public bool IsPromptWithContentVariant2 => PromptWithContentVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptWithContent(global::HammingAI.Prompt value) => new PromptWithContent((global::HammingAI.Prompt?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HammingAI.Prompt?(PromptWithContent @this) => @this.Prompt;

        /// <summary>
        /// 
        /// </summary>
        public PromptWithContent(global::HammingAI.Prompt? value)
        {
            Prompt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptWithContent(global::HammingAI.PromptWithContentVariant2 value) => new PromptWithContent((global::HammingAI.PromptWithContentVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::HammingAI.PromptWithContentVariant2?(PromptWithContent @this) => @this.PromptWithContentVariant2;

        /// <summary>
        /// 
        /// </summary>
        public PromptWithContent(global::HammingAI.PromptWithContentVariant2? value)
        {
            PromptWithContentVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PromptWithContent(
            global::HammingAI.Prompt? prompt,
            global::HammingAI.PromptWithContentVariant2? promptWithContentVariant2
            )
        {
            Prompt = prompt;
            PromptWithContentVariant2 = promptWithContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            PromptWithContentVariant2 as object ??
            Prompt as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Prompt?.ToString() ??
            PromptWithContentVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPrompt && IsPromptWithContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::HammingAI.Prompt?, TResult>? prompt = null,
            global::System.Func<global::HammingAI.PromptWithContentVariant2?, TResult>? promptWithContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrompt && prompt != null)
            {
                return prompt(Prompt!);
            }
            else if (IsPromptWithContentVariant2 && promptWithContentVariant2 != null)
            {
                return promptWithContentVariant2(PromptWithContentVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::HammingAI.Prompt?>? prompt = null,
            global::System.Action<global::HammingAI.PromptWithContentVariant2?>? promptWithContentVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPrompt)
            {
                prompt?.Invoke(Prompt!);
            }
            else if (IsPromptWithContentVariant2)
            {
                promptWithContentVariant2?.Invoke(PromptWithContentVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Prompt,
                typeof(global::HammingAI.Prompt),
                PromptWithContentVariant2,
                typeof(global::HammingAI.PromptWithContentVariant2),
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
        public bool Equals(PromptWithContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::HammingAI.Prompt?>.Default.Equals(Prompt, other.Prompt) &&
                global::System.Collections.Generic.EqualityComparer<global::HammingAI.PromptWithContentVariant2?>.Default.Equals(PromptWithContentVariant2, other.PromptWithContentVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PromptWithContent obj1, PromptWithContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptWithContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PromptWithContent obj1, PromptWithContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptWithContent o && Equals(o);
        }
    }
}
