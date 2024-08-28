// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.FineTuning
{
    internal readonly partial struct InternalCreateFineTuningJobRequestHyperparametersNEpochsChoiceEnum : IEquatable<InternalCreateFineTuningJobRequestHyperparametersNEpochsChoiceEnum>
    {
        private readonly string _value;

        public InternalCreateFineTuningJobRequestHyperparametersNEpochsChoiceEnum(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "auto";

        public static InternalCreateFineTuningJobRequestHyperparametersNEpochsChoiceEnum Auto { get; } = new InternalCreateFineTuningJobRequestHyperparametersNEpochsChoiceEnum(AutoValue);
        public static bool operator ==(InternalCreateFineTuningJobRequestHyperparametersNEpochsChoiceEnum left, InternalCreateFineTuningJobRequestHyperparametersNEpochsChoiceEnum right) => left.Equals(right);
        public static bool operator !=(InternalCreateFineTuningJobRequestHyperparametersNEpochsChoiceEnum left, InternalCreateFineTuningJobRequestHyperparametersNEpochsChoiceEnum right) => !left.Equals(right);
        public static implicit operator InternalCreateFineTuningJobRequestHyperparametersNEpochsChoiceEnum(string value) => new InternalCreateFineTuningJobRequestHyperparametersNEpochsChoiceEnum(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalCreateFineTuningJobRequestHyperparametersNEpochsChoiceEnum other && Equals(other);
        public bool Equals(InternalCreateFineTuningJobRequestHyperparametersNEpochsChoiceEnum other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}