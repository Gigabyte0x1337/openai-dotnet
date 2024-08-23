// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Chat
{
    internal readonly partial struct InternalChatCompletionRequestMessageContentPartRefusalType : IEquatable<InternalChatCompletionRequestMessageContentPartRefusalType>
    {
        private readonly string _value;

        public InternalChatCompletionRequestMessageContentPartRefusalType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RefusalValue = "refusal";

        public static InternalChatCompletionRequestMessageContentPartRefusalType Refusal { get; } = new InternalChatCompletionRequestMessageContentPartRefusalType(RefusalValue);
        public static bool operator ==(InternalChatCompletionRequestMessageContentPartRefusalType left, InternalChatCompletionRequestMessageContentPartRefusalType right) => left.Equals(right);
        public static bool operator !=(InternalChatCompletionRequestMessageContentPartRefusalType left, InternalChatCompletionRequestMessageContentPartRefusalType right) => !left.Equals(right);
        public static implicit operator InternalChatCompletionRequestMessageContentPartRefusalType(string value) => new InternalChatCompletionRequestMessageContentPartRefusalType(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalChatCompletionRequestMessageContentPartRefusalType other && Equals(other);
        public bool Equals(InternalChatCompletionRequestMessageContentPartRefusalType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}
