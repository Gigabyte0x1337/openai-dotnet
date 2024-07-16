// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Images
{
    internal readonly partial struct InternalCreateImageEditRequestResponseFormat : IEquatable<InternalCreateImageEditRequestResponseFormat>
    {
        private readonly string _value;

        public InternalCreateImageEditRequestResponseFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UrlValue = "url";
        private const string B64JsonValue = "b64_json";

        public static InternalCreateImageEditRequestResponseFormat Url { get; } = new InternalCreateImageEditRequestResponseFormat(UrlValue);
        public static InternalCreateImageEditRequestResponseFormat B64Json { get; } = new InternalCreateImageEditRequestResponseFormat(B64JsonValue);
        public static bool operator ==(InternalCreateImageEditRequestResponseFormat left, InternalCreateImageEditRequestResponseFormat right) => left.Equals(right);
        public static bool operator !=(InternalCreateImageEditRequestResponseFormat left, InternalCreateImageEditRequestResponseFormat right) => !left.Equals(right);
        public static implicit operator InternalCreateImageEditRequestResponseFormat(string value) => new InternalCreateImageEditRequestResponseFormat(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateImageEditRequestResponseFormat other && Equals(other);
        public bool Equals(InternalCreateImageEditRequestResponseFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}