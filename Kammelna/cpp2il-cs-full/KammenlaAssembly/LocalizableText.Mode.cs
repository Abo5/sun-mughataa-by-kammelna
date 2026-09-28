using Cpp2ILInjected;

public class LocalizableText
{
	public enum Mode
	{
		FixOnly,
		Localize,
		LocalizeArguments
	}

	public string Text;

	public object[] Arguments;

	public Mode LocalizeMode;

	public LocalizableText(string text, object[] arguments)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = this + 16;
		obj = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = arguments;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 1;
	}

	public LocalizableText(string text, Mode localizeMode, object[] arguments)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = this + 16;
		obj = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = arguments;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
