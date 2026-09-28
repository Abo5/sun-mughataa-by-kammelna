using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem.XR;

[Serializable]
public class EmoteItemData : ScriptableObject
{
	public float delayAudio;

	public float duration = 5f;

	public Vector2Int gridSize;

	public float shiftMask;

	public EmoteItemData()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_003c: Expected O, but got I
		//IL_004c: Expected O, but got I
		//IL_0069: Expected O, but got I
		//IL_0086: Expected O, but got I
		object obj = typeof(UsageHint) + 768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+8]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v5+8]");
		object obj4 = num + 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v6+C]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v6+C]");
		object obj5 = obj4 | (object)(num2 + 0);
		_ = 1036831949;
		base..ctor();
	}
}
