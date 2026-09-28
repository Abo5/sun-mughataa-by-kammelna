using Cpp2ILInjected;
using UnityEngine;

public class Comment : MonoBehaviour
{
	public string CommentMessage;

	public Comment()
	{
		//IL_000c: Expected O, but got I
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2000;
		object obj2 = this + 32;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
