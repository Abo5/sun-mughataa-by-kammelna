using System;
using Cpp2ILInjected;

namespace Server.Models;

[Serializable]
public class CustomMessageFeedData : UserFeedData
{
	private string <Title>k__BackingField;

	private string <Message>k__BackingField;

	public string Title
	{
		get
		{
			return <Title>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string Message
	{
		get
		{
			return <Message>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public override bool HasPreview => false;

	public override bool ForcedPreview => false;

	public override LocalizableText GetTitle()
	{
		return TextMeshProExtensions.FixOnly(<Title>k__BackingField);
	}

	public override LocalizableText GetDetails()
	{
		return TextMeshProExtensions.FixOnly(<Message>k__BackingField);
	}

	public override void ShowPreview(Action markSeen)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(System.IOAsyncCallback) + 3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InvalidOperationException ex = default(InvalidOperationException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)1576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}
}
