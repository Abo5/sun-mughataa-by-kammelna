using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;

public class ClanInfoPanel : MonoBehaviour
{
	private ClanCard clanCard;

	private int _clanId = -1;

	public void Initialize(ClanModel clan)
	{
		//IL_0049: Expected I4, but got I8
		//IL_0029: Expected O, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_007d: Expected O, but got I
		//IL_00a9: Expected I, but got O
		//IL_00f7: Expected I, but got O
		ClanModel clanModel = default(ClanModel);
		int clanId;
		if (clanModel != null)
		{
			clanId = clanModel.ClanId;
			bool flag = (object)this == null;
			object obj = !flag;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			clanId = -1;
		}
		_clanId = clanId;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)1112;
		clanCard.Initialize(clanModel);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		ClanServerConnector.OnEmblemTierActivated -= action;
		if (IsMyClan(_clanId))
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action2 = default(Action);
			action2..ctor(this, (IntPtr)obj3);
			ClanServerConnector.OnEmblemTierActivated += action2;
		}
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		ClanServerConnector.OnEmblemTierActivated -= action;
	}

	private void OnEmblemTierActivated()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_006f: Expected O, but got I4
		//IL_00b3: Expected I, but got O
		if (IsMyClan(_clanId))
		{
			object obj = typeof(Queue<string>) + 728;
			object obj2 = (nint)0 + (nint)1976;
			object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1552;
			object obj4 = (nint)0 + (nint)1104;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj4);
			ClanServerConnector clanServerConnector = default(ClanServerConnector);
			clanServerConnector.GetMyClan(action);
		}
	}

	private static bool IsMyClan(int clanId)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_018f: Expected I4, but got O
		//IL_00b7: Expected I4, but got O
		//IL_00ef: Expected O, but got I4
		//IL_015f: Expected O, but got I4
		if (clanId >= 1)
		{
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				bool flag2 = localUser == null;
				bool result = (byte)(int)localUser != 0;
				if (!flag2)
				{
					object obj5 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v11+E4]");
					bool flag3 = (nint)0 == 0;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel2 = default(SessionModel);
					if ((object)sessionModel2 == null)
					{
						goto IL_0181;
					}
					User localUser2 = sessionModel2.LocalUser;
					int clanId2 = SFSKammelnaUserExtensions.GetClanId(localUser2);
					object obj7 = clanId - clanId2;
					bool flag4 = obj7 == null;
					result = flag4;
				}
				return result;
			}
			goto IL_0181;
		}
		return false;
		IL_0181:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void <OnEmblemTierActivated>b__4_0(ClanModel clan)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_0099: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8620]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = this != null;
		if (clan != null)
		{
			goto IL_0123;
		}
		return;
		IL_0123:
		if (flag2)
		{
			Initialize(clan);
		}
		return;
		IL_0074:
		flag2 = this != null;
		bool flag3 = clan == null;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			return;
		}
		goto IL_0123;
	}
}
