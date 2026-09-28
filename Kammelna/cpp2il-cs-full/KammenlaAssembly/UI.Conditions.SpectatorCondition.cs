using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

namespace UI.Conditions;

[Serializable]
public class SpectatorCondition : BoolCondition
{
	private KGame game;

	protected override bool ActualValue
	{
		get
		{
			//IL_0041: Expected I4, but got O
			if ((object)game != null)
			{
				return game.IsSpectator;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public override void Setup(GameObject gm)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_010a: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_00a0: Expected O, but got I
		//IL_00b8: Expected I, but got O
		//IL_00e9: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 32;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (!((UnityEngine.Object)obj5 == null))
		{
			object obj7 = typeof(SqlSingle[]) + 2376;
			object obj8 = (nint)0 + (nint)560;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj8);
			game.OnBecomingPlayer += action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action2 = default(Action);
			action2..ctor(this, (IntPtr)obj8);
			game.OnBecomingWatcher += action2;
		}
	}

	public override void Teardown()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0190: Expected O, but got I
		//IL_01a8: Expected I, but got O
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_01d9: Expected I, but got O
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E21]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			obj5 = game;
			obj6 = game;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = game;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = game;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0170;
		IL_0170:
		object obj11 = typeof(SqlSingle[]) + 2376;
		object obj12 = (nint)0 + (nint)560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj12);
		game.OnBecomingPlayer -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj12);
		game.OnBecomingWatcher -= action2;
		return;
		IL_0091:
		bool flag5 = obj5 == null;
		bool flag6 = !flag5;
		obj9 = 0;
		obj10 = null;
		if (!flag6)
		{
			return;
		}
		goto IL_0170;
	}

	public SpectatorCondition()
	{
		isActive = true;
		((object)this)..ctor();
	}
}
