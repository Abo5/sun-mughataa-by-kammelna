using System;
using System.Buffers.Text;
using Cpp2ILInjected;

public class PopupButton
{
	public enum ButtonType
	{
		Positive,
		Negative,
		Neutral,
		Purchase
	}

	public ButtonType Type;

	public LocalizableText Label;

	public Action Action;

	public bool Dismiss;

	public int Price;

	public static PopupButton Positive(string label = "OK", Action action = null, bool dismiss = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		LocalizableText localizableText = TextMeshProExtensions.Localize(label);
		object obj3 = obj2 + 24;
		obj3 = localizableText;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		return (PopupButton)obj2;
	}

	public static PopupButton Neutral(string label = "OK", Action action = null, bool dismiss = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 2;
		LocalizableText localizableText = TextMeshProExtensions.Localize(label);
		object obj3 = obj2 + 24;
		obj3 = localizableText;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		return (PopupButton)obj2;
	}

	public static PopupButton Negative(string label = "Cancel", Action action = null, bool dismiss = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 1;
		LocalizableText localizableText = TextMeshProExtensions.Localize(label);
		object obj3 = obj2 + 24;
		obj3 = localizableText;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		return (PopupButton)obj2;
	}

	public static PopupButton Purchase(string label = "Buy", Action action = null, bool dismiss = false, int price = 0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 3;
		LocalizableText localizableText = TextMeshProExtensions.Localize(label);
		object obj3 = obj2 + 24;
		obj3 = localizableText;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (PopupButton)obj2;
	}

	public static PopupButton Positive(LocalizableText label, Action action = null, bool dismiss = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 24;
		obj3 = label;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		return (PopupButton)obj2;
	}

	public static PopupButton Neutral(LocalizableText label, Action action = null, bool dismiss = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 2;
		object obj3 = obj2 + 24;
		obj3 = label;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		return (PopupButton)obj2;
	}

	public static PopupButton Negative(LocalizableText label, Action action = null, bool dismiss = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 1;
		object obj3 = obj2 + 24;
		obj3 = label;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		return (PopupButton)obj2;
	}

	public static PopupButton Purchase(LocalizableText label, Action action = null, bool dismiss = false, int price = 0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 3;
		object obj3 = obj2 + 24;
		obj3 = label;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (PopupButton)obj2;
	}

	private PopupButton(ButtonType type, string label, Action action = null, bool dismiss = false, int price = 0)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		Type = type;
		LocalizableText localizableText = TextMeshProExtensions.Localize(label);
		object obj = this + 24;
		obj = localizableText;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 32;
		obj2 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private PopupButton(ButtonType type, LocalizableText label, Action action = null, bool dismiss = false, int price = 0)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		Type = type;
		object obj = this + 24;
		obj = label;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 32;
		obj2 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
