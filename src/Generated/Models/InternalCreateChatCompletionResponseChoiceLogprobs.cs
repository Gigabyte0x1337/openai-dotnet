// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Chat
{
    internal partial class InternalCreateChatCompletionResponseChoiceLogprobs
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalCreateChatCompletionResponseChoiceLogprobs(IEnumerable<ChatTokenLogProbabilityInfo> content, IEnumerable<ChatTokenLogProbabilityInfo> refusal)
        {
            Content = content?.ToList();
            Refusal = refusal?.ToList();
        }

        internal InternalCreateChatCompletionResponseChoiceLogprobs(IReadOnlyList<ChatTokenLogProbabilityInfo> content, IReadOnlyList<ChatTokenLogProbabilityInfo> refusal, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            Refusal = refusal;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalCreateChatCompletionResponseChoiceLogprobs()
        {
        }

        public IReadOnlyList<ChatTokenLogProbabilityInfo> Content { get; }
        public IReadOnlyList<ChatTokenLogProbabilityInfo> Refusal { get; }
    }
}
