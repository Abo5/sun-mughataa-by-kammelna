using Cpp2ILInjected;
using TMPro;

public class BestOfNumberFormatter : NumberFormatter
{
	public override void AssignValue(TextMeshProUGUI label, int value)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_005c: Expected O, but got I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		object text;
		switch (value)
		{
		case 1:
			text = "October" + 712;
			break;
		case 3:
			text = "AvailableVoices" + 1504;
			break;
		default:
		{
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object value2 = default(object);
			NumberFormatter.SetText(label, null, value2);
			return;
		}
		}
		TextMeshProExtensions.Localize(label, (string)text);
	}
}
