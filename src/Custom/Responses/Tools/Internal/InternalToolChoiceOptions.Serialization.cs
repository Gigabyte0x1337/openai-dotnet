namespace OpenAI.Responses;

public static partial class InternalToolChoiceOptionsExtensions
{
    internal static ResponseToolChoiceKind ToResponseToolChoiceKind(this InternalToolChoiceOptions options)
    {
        return options.ToString() switch
        {
            "none" => ResponseToolChoiceKind.None,
            "auto" => ResponseToolChoiceKind.Auto,
            "required" => ResponseToolChoiceKind.Required,
            _ => ResponseToolChoiceKind.Unknown,
        };
    }
}
