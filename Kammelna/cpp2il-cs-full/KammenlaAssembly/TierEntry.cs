using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.InputSystem.XR;

[Serializable]
public class TierEntry
{
	public string Name;

	public Sprite TestImage;

	public bool OverridePosition;

	public Vector2 AnchoredPosition;

	public bool OverrideSize;

	public Vector2 SizeDelta;

	public bool OverridePivot;

	public Vector2 Pivot;

	public bool OverrideScale;

	public Vector3 LocalScale;

	public TierEntry()
	{
		//IL_0012: Expected O, but got I
		//IL_0024: Expected O, but got I
		//IL_002f: Expected O, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0060: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252D60]");
		AnchoredPosition = (Vector2)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252D68]");
		SizeDelta = (Vector2)0;
		Pivot = (Vector2)63;
		object obj = typeof(UsageHint) + 816;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v5+B8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6+C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v6+14]");
		_ = 0;
		base..ctor();
	}
}
