using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public abstract class RectTweenAnim : TweenAnim
{
	public RectTransform _rectTransform;

	public override GameObject target
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_011b: Expected O, but got I4
			//IL_0170: Expected O, but got I4
			object obj = 152981504;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5F7E]");
			object obj3 = (nint)0 & (nint)1;
			UnityEngine.Object rectTransform;
			UnityEngine.Object rectTransform2;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				rectTransform = _rectTransform;
				rectTransform2 = _rectTransform;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				rectTransform = _rectTransform;
				rectTransform2 = _rectTransform;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = rectTransform2 != null;
			bool flag4 = !flag3;
			object obj6 = !flag4;
			if (obj6 != null)
			{
				goto IL_00b8;
			}
			goto IL_017e;
			IL_00b8:
			if ((object)_rectTransform != null)
			{
				return _rectTransform.gameObject;
			}
			return (GameObject)(object)new NullReferenceException();
			IL_017e:
			return null;
			IL_0091:
			if (rectTransform != null)
			{
				goto IL_00b8;
			}
			goto IL_017e;
		}
	}
}
