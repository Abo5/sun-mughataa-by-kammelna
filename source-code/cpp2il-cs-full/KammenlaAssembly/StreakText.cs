using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;

public class StreakText : MonoBehaviour
{
	private TextMeshProUGUI _text;

	private GameObject _holder;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b8: Expected O, but got I
		//IL_00ec: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0090: Expected I, but got O
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		GameObject go = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)224;
		object varName = "startPosition" + 688;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go, localUser, (string)varName, action);
	}

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		object obj = (nint)0 + (nint)152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 32;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Transform transform = base.transform;
		Transform parent = transform.parent;
		GameObject gameObject = parent.gameObject;
		object obj4 = this + 40;
		obj4 = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <Start>b__2_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_0198: Expected O, but got I
		//IL_01f8: Expected O, but got I4
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected I4, but got Unknown
		//IL_0265: Expected O, but got I4
		//IL_02d1: Expected O, but got I4
		//IL_0325: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A25]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v26+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0133;
		IL_0133:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int winningStreak = SFSKammelnaUserExtensions.GetWinningStreak(localUser);
		int num = default(int);
		string text = num.ToString();
		_text.text = text;
		object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj9 = (nint)0 + (nint)136;
		bool flag3 = num < 0;
		bool flag4 = num == 0;
		int num2 = num ^ num;
		int num3 = num & num2;
		bool flag5 = num3 < 0;
		bool flag6 = flag3 == flag5;
		object obj10 = !flag4;
		bool active = (byte)((flag6 & obj10) ? 1 : 0) != 0;
		_holder.SetActive(active);
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v11+E4]");
		KGame kGame = default(KGame);
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			bool flag7 = (object)kGame == null;
			object obj12 = !flag7;
			if (obj12 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			if ((object)kGame == null)
			{
				return;
			}
		}
		bool isSpectator = kGame.IsSpectator;
		bool flag8 = !isSpectator;
		object obj13 = !flag8;
		if (obj13 == null)
		{
			Room room = kGame.Room;
			GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
			bool flag9 = GameTypeExtensions.IsRanked(gameType);
			bool flag10 = !flag9;
			object obj14 = !flag10;
			if (obj14 != null)
			{
				return;
			}
		}
		_holder.SetActive(value: false);
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag11 = (object)sessionModel == null;
		object obj15 = !flag11;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}
}
