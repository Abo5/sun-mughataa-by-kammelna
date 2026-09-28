using System;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using UnityEngine;

[Serializable]
public abstract class TweenAnimBase
{
	public enum InsertionType
	{
		Append,
		Join
	}

	public InsertionType Insertion;

	public abstract GameObject target { get; }

	public abstract Tween tween { get; }

	public virtual Tween GetTween
	{
		get
		{
			//IL_0005: Expected I, but got O
			//IL_0015: Expected O, but got I
			//IL_0025: Expected O, but got I
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<TweenAnimBase>)+188]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<TweenAnimBase>)+190]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public string Name()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c2: Expected I, but got O
		//IL_00f6: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		nint num = (nint)this;
		UnityEngine.Object obj2 = target;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag2 = obj2 != null;
		Type type = GetType();
		if (flag2)
		{
			UnityEngine.Object obj5 = target;
			if ((object)obj5 != null)
			{
				string name = obj5.name;
				object format = "{0} color encoding is currently unsupported for outputting to HDR." + 512;
				return string.Format((string)format, type, name);
			}
			return (string)(object)new NullReferenceException();
		}
		object format2 = "utf-32" + 3632;
		return string.Format((string)format2, type);
	}
}
