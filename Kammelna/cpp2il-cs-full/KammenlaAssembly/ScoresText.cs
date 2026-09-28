using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;

public class ScoresText : MonoBehaviour
{
	private TextMeshProUGUI scoreUs;

	private TextMeshProUGUI scoreThem;

	private ObjectToggler isPlayerToggle;

	private CardGame _game;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0161: Expected O, but got I
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0181: Expected O, but got I
		//IL_01ab: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		//IL_00bb: Expected I, but got O
		//IL_00cc: Expected O, but got I
		//IL_00f8: Expected I, but got O
		//IL_0109: Expected O, but got I
		//IL_0135: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj4 = (nint)0 + (nint)992;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 56;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)obj4);
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)984;
		((KGame)obj7).OnPlayerSwitchSeat += playerSwitchSeatDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj10);
		object obj11 = (nint)0 + (nint)1000;
		_game.OnGameInitialized += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj11);
		object obj12 = (nint)0 + (nint)1008;
		_game.OnBecomingPlayer += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj12);
		_game.OnBecomingWatcher += action3;
		Init();
	}

	private void Init()
	{
		//IL_0103: Expected O, but got I4
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_012d: Expected O, but got I
		//IL_029d: Expected O, but got I4
		//IL_003c: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_01ae: Expected O, but got I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_0205: Expected O, but got I4
		//IL_00e7: Expected O, but got I4
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		BindScores();
		UnityEngine.Object obj5;
		if (_game.IsSpectator)
		{
			object obj = 152985600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6850]");
			object obj2 = (nint)0 & (nint)1;
			UnityEngine.Object obj6;
			if (obj2 != null)
			{
				object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v22+E4]");
				bool flag = (nint)0 == 0;
				obj5 = isPlayerToggle;
				obj6 = isPlayerToggle;
				if (!flag)
				{
					goto IL_00c4;
				}
			}
			else
			{
				_ = 1;
				object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj4 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v22+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				obj5 = isPlayerToggle;
				obj6 = isPlayerToggle;
				if (obj8 != null)
				{
					goto IL_00c4;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)obj6)
			{
				goto IL_025c;
			}
			return;
		}
		object obj9 = 152985600;
		object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E684F]");
		object obj11 = (nint)0 & (nint)1;
		UnityEngine.Object obj13;
		UnityEngine.Object obj14;
		if (obj11 != null)
		{
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			obj13 = isPlayerToggle;
			obj14 = isPlayerToggle;
			if (!flag3)
			{
				goto IL_018b;
			}
		}
		else
		{
			_ = 1;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v8+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			obj13 = isPlayerToggle;
			obj14 = isPlayerToggle;
			if (obj15 != null)
			{
				goto IL_018b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj14)
		{
			goto IL_02f4;
		}
		return;
		IL_02f4:
		isPlayerToggle.ToggleManual(isON: true);
		return;
		IL_025c:
		isPlayerToggle.ToggleManual(isON: false);
		return;
		IL_00c4:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			return;
		}
		goto IL_025c;
		IL_018b:
		bool flag7 = obj13;
		bool flag8 = !flag7;
		object obj17 = !flag8;
		if (obj17 == null)
		{
			return;
		}
		goto IL_02f4;
	}

	private void HandleSeatSwitch(int i, string s)
	{
		BindScores();
	}

	private void OnBecomingAPlayer()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_014c: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E684F]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = isPlayerToggle;
			obj6 = isPlayerToggle;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = isPlayerToggle;
			obj6 = isPlayerToggle;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		isPlayerToggle.ToggleManual(isON: true);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private void OnBecomingWatcher()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_014c: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6850]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = isPlayerToggle;
			obj6 = isPlayerToggle;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = isPlayerToggle;
			obj6 = isPlayerToggle;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		isPlayerToggle.ToggleManual(isON: false);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private void BindScores()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		GameObject go = scoreUs.gameObject;
		VariableBinderExtensions.Unbind(go);
		GameObject go2 = scoreThem.gameObject;
		VariableBinderExtensions.Unbind(go2);
		object defaultValue = "Material with texture name \"" + 3392;
		int myTeamIndex = _game.MyTeamIndex;
		KGame game;
		object varName2;
		if (myTeamIndex == 1 || _game.IsSpectator)
		{
			object varName = "startPosition" + 2144;
			Room room = _game.Room;
			VariableBinderExtensions.Bind(scoreUs, room, (string)varName, (string)defaultValue);
			game = _game;
			varName2 = "startPosition" + 2160;
		}
		else
		{
			Room room2 = _game.Room;
			object varName3 = "startPosition" + 2160;
			VariableBinderExtensions.Bind(scoreUs, room2, (string)varName3, (string)defaultValue);
			game = _game;
			varName2 = "startPosition" + 2144;
		}
		Room room3 = game.Room;
		VariableBinderExtensions.Bind(scoreThem, room3, (string)varName2, (string)defaultValue);
	}
}
