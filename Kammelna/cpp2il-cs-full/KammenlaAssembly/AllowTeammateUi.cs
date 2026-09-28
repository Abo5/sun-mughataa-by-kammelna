using System;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class AllowTeammateUi : MonoBehaviour
{
	private RectTransform container;

	private TextMeshProUGUI playerName;

	private RankUI playerRank;

	private Timer timer;

	private CardGame game;

	private void Awake()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0091: Expected O, but got I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00f2: Expected I, but got O
		//IL_0103: Expected O, but got I
		//IL_012d: Expected I, but got O
		GameObject gameObject = container.gameObject;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3872;
		gameObject.SetActive(value: false);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 64;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		object obj9 = (nint)0 + (nint)3864;
		((KGame)obj7).OnGameStateUpdated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj9);
		timer.onTimeIsUp += action2;
	}

	private void OnGameStatusUpdated()
	{
		//IL_002e: Expected O, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00d5: Expected I, but got O
		//IL_00e5: Expected O, but got I
		//IL_018f: Expected O, but got I4
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01ef: Expected I, but got O
		//IL_01ff: Expected O, but got I
		//IL_0120: Expected O, but got I
		//IL_02a9: Expected O, but got I4
		//IL_023a: Expected O, but got I
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		bool isSpectator = game.IsSpectator;
		bool flag = !isSpectator;
		object obj = !flag;
		Room room;
		if (obj == null)
		{
			CardGamePlayer myTeammate = game.MyTeammate;
			SeatStatus seatStatus = myTeammate.SeatStatus;
			if (seatStatus == SeatStatus.WaitingForApproval)
			{
				room = game.Room;
				CardGamePlayer myTeammate2 = game.MyTeammate;
				User <User>k__BackingField = ((KPlayer)myTeammate2).<User>k__BackingField;
				object obj2 = typeof(UsageHint) + 8;
				nint num = (nint)<User>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0161;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v6 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
				object obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X10_v13-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj4 += 16;
					obj3--;
					if ((nint)obj3 != 1)
					{
						continue;
					}
					goto IL_0161;
				}
				object obj5 = num + obj4;
				object obj6 = obj5 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v318 @ X0_v45] (should have been resolved before IL gen)");
				goto IL_01d3;
			}
		}
		Hide();
		return;
		IL_027b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v371 @ X0_v35] (should have been resolved before IL gen)");
		User user = default(User);
		bool flag2 = user == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			return;
		}
		goto IL_030c;
		IL_01d3:
		object obj8 = typeof(RegisteredWaitHandle) + 1376;
		nint num2 = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_027b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X10_v8-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_027b;
		}
		object obj11 = obj10 + 27;
		object obj12 = num2 + obj11;
		object obj13 = obj12 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v404 @ X0_v38] (should have been resolved before IL gen)");
		if (user != null)
		{
			goto IL_030c;
		}
		return;
		IL_030c:
		GameObject gameObject = container.gameObject;
		if (!gameObject.activeSelf)
		{
			string userName = SFSKammelnaUserExtensions.GetUserName(user);
			bool isSubscribed = SFSKammelnaUserExtensions.IsSubscribed(user);
			bool isVerified = SFSKammelnaUserExtensions.IsVerified(user);
			TextMeshProExtensions.SetUsername(playerName, userName, isSubscribed, isVerified);
			timer.StartTimer(30f);
			PlayerRank rank = SFSKammelnaUserExtensions.GetRank(user);
			playerRank.SetRank(rank);
			Show();
		}
		return;
		IL_0161:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v302 @ X0_v42] (should have been resolved before IL gen)");
		bool flag3 = room == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01d3;
	}

	private void Show()
	{
		//IL_0025: Expected O, but got I
		GameObject gameObject = container.gameObject;
		object obj = (nint)0 + (nint)2872;
		gameObject.SetActive(value: true);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosX(container, -660f, 0.5f, snapping: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	private void Hide()
	{
		//IL_000c: Expected O, but got I
		//IL_0018: Expected O, but got I
		object obj = (nint)0 + (nint)2488;
		object obj2 = (nint)0 + (nint)2872;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosX(container, 40f, 0.5f, snapping: true);
		TweenCallback tweenCallback = TweenHelpers.Disable(container);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		timer.Hide();
	}

	public void Accept()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0047: Expected I, but got O
		//IL_0057: Expected O, but got I
		//IL_0092: Expected O, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		Hide();
		CardGamePlayer myTeammate = game.MyTeammate;
		User <User>k__BackingField = ((KPlayer)myTeammate).<User>k__BackingField;
		object obj = typeof(UsageHint) + 8;
		nint num = (nint)<User>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00d3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X10_v5-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00d3;
		}
		object obj4 = num + obj3;
		object obj5 = obj4 + 312;
		goto IL_0131;
		IL_00d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0131;
		IL_0131:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ X0_v7] (should have been resolved before IL gen)");
		int teammateSFSId = default(int);
		KGame.SendApproveTeammate(approve: true, teammateSFSId);
	}

	public void Refuse()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0047: Expected I, but got O
		//IL_0057: Expected O, but got I
		//IL_0092: Expected O, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		Hide();
		CardGamePlayer myTeammate = game.MyTeammate;
		User <User>k__BackingField = ((KPlayer)myTeammate).<User>k__BackingField;
		object obj = typeof(UsageHint) + 8;
		nint num = (nint)<User>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00d3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X10_v5-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00d3;
		}
		object obj4 = num + obj3;
		object obj5 = obj4 + 312;
		goto IL_0131;
		IL_00d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0131;
		IL_0131:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v165 @ X0_v7] (should have been resolved before IL gen)");
		int teammateSFSId = default(int);
		KGame.SendApproveTeammate(approve: false, teammateSFSId);
	}
}
