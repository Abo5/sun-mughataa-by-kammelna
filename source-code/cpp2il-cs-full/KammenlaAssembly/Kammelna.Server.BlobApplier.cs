using System;
using Cpp2ILInjected;

namespace Kammelna.Server;

public class BlobApplier : ContentApplier
{
	private readonly Action<string> _apply;

	public BlobApplier(string wireKey, Action<string> apply)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		object obj = this + 16;
		obj = wireKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = apply;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override void ApplyBlob(string modelJson)
	{
		//IL_001f: Expected O, but got I
		//IL_002f: Expected O, but got I
		//IL_003f: Expected O, but got I
		Action<string> apply = _apply;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.String>)+18]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.String>)+40]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<System.String>)+28]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
