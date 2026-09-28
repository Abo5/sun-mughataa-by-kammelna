using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public struct ResolvedDisplay
{
	public Vector2 AnchoredPosition;

	public Vector2 SizeDelta;

	public Vector2 Pivot;

	public Vector3 LocalScale;

	public Sprite TestImage;

	public void ApplyTo(RectTransform rect)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I4
		//IL_0133: Expected O, but got I4
		//IL_0141: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_0162: Expected O, but got I4
		//IL_0116: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B45]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = rect == null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		goto IL_0125;
		IL_0125:
		rect.anchoredPosition = (Vector2)0;
		rect.sizeDelta = (Vector2)0;
		rect.pivot = (Vector2)0;
		rect.localScale = (Vector3)0;
		return;
		IL_0074:
		if (rect == null)
		{
			return;
		}
		goto IL_0125;
	}
}
