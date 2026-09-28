using Cpp2ILInjected;
using TMPro;

public class BasicNumberFormatter : NumberFormatter
{
	private string normalTemplate;

	public override void AssignValue(TextMeshProUGUI label, int value)
	{
		//IL_000f: Expected O, but got I4
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object value2 = default(object);
		NumberFormatter.SetText(label, normalTemplate, value2);
	}
}
