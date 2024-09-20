// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Chat
{
    public partial class ChatTokenLogProbabilityDetails
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal ChatTokenLogProbabilityDetails(string token, float logProbability, ReadOnlyMemory<byte>? utf8Bytes, IEnumerable<ChatTokenTopLogProbabilityDetails> topLogProbabilities)
        {
            Argument.AssertNotNull(token, nameof(token));
            Argument.AssertNotNull(topLogProbabilities, nameof(topLogProbabilities));

            Token = token;
            LogProbability = logProbability;
            Utf8Bytes = utf8Bytes;
            TopLogProbabilities = topLogProbabilities.ToList();
        }

        internal ChatTokenLogProbabilityDetails(string token, float logProbability, ReadOnlyMemory<byte>? utf8Bytes, IReadOnlyList<ChatTokenTopLogProbabilityDetails> topLogProbabilities, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Token = token;
            LogProbability = logProbability;
            Utf8Bytes = utf8Bytes;
            TopLogProbabilities = topLogProbabilities;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal ChatTokenLogProbabilityDetails()
        {
        }

        public string Token { get; }
    }
}