using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Server.Models;
using Sfs2X.Entities;
using Spine;
using UnityEngine;

public class TournamentEndGameEndWidget : GameEndWidget
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<GameObject> <>9__11_1;

		public static Action<GameObject> <>9__11_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3544;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Populate>b__11_1(GameObject tt)
		{
			tt.SetActive(value: true);
		}

		internal void <Populate>b__11_0(GameObject tt)
		{
			tt.SetActive(value: false);
		}
	}

	private AvatarInitializer myAvatar;

	private AvatarInitializer teammateAvatar;

	private AvatarInitializer T2Avatar1;

	private AvatarInitializer T2Avatar2;

	private GameObject Team2Section;

	private TournamentPrizeInitializer prize;

	private TournamentPrizeInitializer t2Prize;

	private GameObject[] TeamTitles;

	private TournamentMatchInfo matchInfo
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00b2: Expected O, but got I
			//IL_00dc: Expected O, but got I4
			//IL_005c: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 872;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6841]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2248;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
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
				object obj4 = (nint)0 + (nint)2248;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
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
			TournamentMatchInfo result = default(TournamentMatchInfo);
			return result;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			TournamentMatchInfo result2 = default(TournamentMatchInfo);
			return result2;
		}
	}

	public override void PrepareAnimation(CardGameEndScores rankReport)
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<TournamentEndGameEndWidget>)+188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<TournamentEndGameEndWidget>)+190]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override void Populate(CardGameEndScores rankReport)
	{
		//IL_0327: Expected O, but got I4
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_0351: Expected O, but got I
		//IL_03f8: Expected O, but got I
		//IL_0422: Expected O, but got I4
		//IL_03d3: Expected O, but got I4
		//IL_037a: Expected O, but got I
		//IL_0496: Expected O, but got I4
		//IL_04b0: Expected O, but got I4
		//IL_0505: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected O, but got Unknown
		//IL_0601: Expected O, but got I
		//IL_0611: Expected O, but got I
		//IL_0633: Expected O, but got I4
		//IL_01db: Expected O, but got I4
		//IL_01f1: Expected O, but got I
		//IL_0547: Expected O, but got I
		//IL_0557: Expected O, but got I
		//IL_0579: Expected O, but got I4
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected O, but got Unknown
		//IL_06e6: Expected O, but got I4
		//IL_066d: Expected O, but got I4
		//IL_0263: Expected O, but got I
		//IL_0287: Expected O, but got I4
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0a87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Expected O, but got Unknown
		//IL_0aa2: Expected O, but got I
		//IL_0aaa: Expected I, but got O
		//IL_0abb: Expected I, but got O
		//IL_0ad9: Expected O, but got I
		//IL_0aea: Expected O, but got I4
		//IL_0af3: Expected O, but got I4
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4b: Expected O, but got Unknown
		//IL_0712: Expected O, but got I
		//IL_069d: Expected O, but got I
		//IL_092a: Expected O, but got I
		//IL_093a: Expected O, but got I
		//IL_095c: Expected O, but got I4
		//IL_08c3: Expected O, but got I
		//IL_08d3: Expected O, but got I
		//IL_08f5: Expected O, but got I4
		//IL_098c: Expected O, but got I4
		//IL_0795: Expected O, but got I
		//IL_0b30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b35: Expected O, but got Unknown
		//IL_0b4b: Expected O, but got I
		//IL_0b53: Expected I, but got O
		//IL_0b64: Expected I, but got O
		//IL_0b82: Expected O, but got I
		//IL_0b93: Expected O, but got I4
		//IL_0846: Expected O, but got I4
		//IL_09bc: Expected O, but got I
		//IL_0803: Expected O, but got I4
		//IL_08a6: Expected O, but got I4
		CardGame cardGame = base.game;
		GameObject gameObject;
		if (!cardGame.IsSpectator)
		{
			Team2Section.SetActive(value: false);
			CardGame cardGame2 = base.game;
			CardGamePlayer myPlayer = cardGame2.MyPlayer;
			myAvatar.Initialize(myPlayer);
			CardGame cardGame3 = base.game;
			CardGamePlayer myTeammate = cardGame3.MyTeammate;
			teammateAvatar.Initialize(myTeammate);
			gameObject = prize.gameObject;
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 872;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6841]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2248;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v42+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				if (!flag)
				{
					goto IL_03af;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2248;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X0_v42+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_03af;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			goto IL_0451;
		}
		int num = ((rankReport.<WinnerTeamIndex>k__BackingField != 1) ? 1 : (1 + 1));
		Team2Section.SetActive(value: true);
		CardGame cardGame4 = base.game;
		KPlayer playerByIndex = cardGame4.GetPlayerByIndex(rankReport.<WinnerTeamIndex>k__BackingField);
		myAvatar.Initialize(playerByIndex);
		CardGame cardGame5 = base.game;
		int index = rankReport.<WinnerTeamIndex>k__BackingField + 2;
		KPlayer playerByIndex2 = cardGame5.GetPlayerByIndex(index);
		teammateAvatar.Initialize(playerByIndex2);
		CardGame cardGame6 = base.game;
		KPlayer playerByIndex3 = cardGame6.GetPlayerByIndex(num);
		T2Avatar1.Initialize(playerByIndex3);
		CardGame cardGame7 = base.game;
		int index2 = num + 2;
		KPlayer playerByIndex4 = cardGame7.GetPlayerByIndex(index2);
		T2Avatar2.Initialize(playerByIndex4);
		CardGame cardGame8 = base.game;
		Room room = cardGame8.Room;
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(room);
		GameObject gameObject2;
		object obj10;
		object obj14;
		if (tournamentInfo != null)
		{
			gameObject2 = prize.gameObject;
			object obj8 = 152985600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6841]");
			object obj9 = (nint)0 & (nint)1;
			object obj12;
			if (obj9 != null)
			{
				obj10 = typeof(Queue<string>) + 872;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v121+E4]");
				bool flag3 = (nint)0 == 0;
				obj12 = obj10;
				if (!flag3)
				{
					goto IL_0257;
				}
			}
			else
			{
				_ = 1;
				obj10 = typeof(Queue<string>) + 872;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X0_v121+E4]");
				bool flag4 = (nint)0 == 0;
				object obj13 = !flag4;
				obj12 = obj10;
				if (obj13 != null)
				{
					goto IL_0257;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = (nint)0 + (nint)2248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			obj10 = obj12;
			goto IL_072e;
		}
		GameObject gameObject3 = prize.gameObject;
		gameObject3.SetActive(value: false);
		GameObject gameObject4 = t2Prize.gameObject;
		bool active = false;
		goto IL_0a20;
		IL_09c1:
		IEnumerable<object> teamTitles;
		Action<object> action;
		ArraysExtensions.ForEach(teamTitles, action);
		GameObject gameObject5 = base.gameObject;
		gameObject5.SetActive(value: true);
		return;
		IL_0257:
		obj14 = (nint)0 + (nint)2248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
		bool flag5 = (object)tournamentMatchInfo == null;
		object obj15 = !flag5;
		if (obj15 != null)
		{
			goto IL_072e;
		}
		goto IL_09ed;
		IL_0a20:
		gameObject4.SetActive(active);
		teamTitles = TeamTitles;
		object obj16 = typeof(SkeletonBinary.SkeletonInput) + 3544;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X0_v81+E4]");
		object obj18;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X0_v81+B8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v33+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v33+8]");
			bool flag6 = (nint)0 == 0;
			object obj19 = !flag6;
			if (obj19 == null)
			{
				goto IL_096a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X0_v81+B8]");
			obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v33+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X8_v33+8]");
			bool flag7 = (nint)0 == 0;
			object obj20 = !flag7;
			if (obj20 == null)
			{
				goto IL_096a;
			}
		}
		goto IL_09c1;
		IL_086d:
		TournamentMatchInfo tournamentMatchInfo2 = default(TournamentMatchInfo);
		TournamentData tournament = tournamentMatchInfo2.Tournament;
		bool flag8 = t2Prize.Initialize(tournament, PrizeLevel.Second);
		object obj21 = 0;
		active = flag8;
		goto IL_0a20;
		IL_03af:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		TournamentMatchInfo tournamentMatchInfo3 = default(TournamentMatchInfo);
		bool flag9 = (object)tournamentMatchInfo3 == null;
		object obj22 = !flag9;
		if (obj22 != null)
		{
			goto IL_0451;
		}
		goto IL_09ed;
		IL_0451:
		TournamentData tournament2 = tournamentMatchInfo3.Tournament;
		CardGame cardGame9 = base.game;
		int myTeamIndex = cardGame9.MyTeamIndex;
		object obj23 = rankReport.<WinnerTeamIndex>k__BackingField - myTeamIndex;
		bool flag10 = obj23 == null;
		object obj24 = !flag10;
		object obj25 = ~obj24;
		PrizeLevel level = ((obj25 != null) ? PrizeLevel.First : PrizeLevel.Second);
		bool active2 = prize.Initialize(tournament2, level);
		gameObject.SetActive(active2);
		object obj26 = typeof(SkeletonBinary.SkeletonInput) + 3544;
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v33+E4]");
		object obj28;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v33+B8]");
			obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v13+10]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v13+10]");
			bool flag11 = (nint)0 == 0;
			object obj29 = !flag11;
			teamTitles = TeamTitles;
			if (obj29 == null)
			{
				goto IL_064b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj27 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v33+B8]");
			obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v13+10]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v13+10]");
			bool flag12 = (nint)0 == 0;
			object obj30 = !flag12;
			teamTitles = TeamTitles;
			if (obj30 == null)
			{
				goto IL_064b;
			}
		}
		goto IL_09c1;
		IL_07df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag13 = (object)tournamentMatchInfo2 == null;
		object obj31 = !flag13;
		if (obj31 != null)
		{
			goto IL_086d;
		}
		goto IL_09ed;
		IL_096a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X0_v81+E4]");
		bool flag14 = (nint)0 == 0;
		object obj32 = !flag14;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj33 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v39+B8]");
			obj18 = 0;
		}
		object obj34 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj35 = (nint)0 + (nint)3856;
		nint num2 = (nint)obj35;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj18, (IntPtr)obj35);
		object obj36 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v38+B8]");
		object obj37 = (nint)0 + (nint)8;
		obj37 = action2;
		object obj38 = 0;
		Action<object> action3 = action2;
		goto IL_0b0a;
		IL_072e:
		TournamentData tournament3 = tournamentMatchInfo.Tournament;
		bool active3 = prize.Initialize(tournament3, PrizeLevel.First);
		gameObject2.SetActive(active3);
		gameObject4 = t2Prize.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X22_v11+841]");
		object obj39 = (nint)0 & (nint)1;
		if (obj39 != null)
		{
			object obj40 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v106+E4]");
			if ((nint)0 != 0)
			{
				goto IL_07df;
			}
		}
		else
		{
			_ = 1;
			object obj40 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X0_v106+E4]");
			bool flag15 = (nint)0 == 0;
			object obj41 = !flag15;
			if (obj41 != null)
			{
				goto IL_07df;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_086d;
		IL_0b0a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action3;
		goto IL_09c1;
		IL_09ed:
		throw new NullReferenceException();
		IL_064b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v33+E4]");
		bool flag16 = (nint)0 == 0;
		object obj42 = !flag16;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj43 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X8_v19+B8]");
			obj28 = 0;
		}
		object obj44 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj45 = (nint)0 + (nint)3848;
		num2 = (nint)obj45;
		Action<object> action4 = default(Action<object>);
		action4..ctor(obj28, (IntPtr)obj45);
		object obj46 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v531 @ X8_v18+B8]");
		obj37 = (nint)0 + (nint)16;
		obj37 = action4;
		obj21 = 0;
		obj38 = 0;
		action3 = action4;
		teamTitles = TeamTitles;
		goto IL_0b0a;
	}

	public override DG.Tweening.Sequence AnimatedPopulate(CardGameEndScores rankReport)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67C1]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return DOTween.Sequence();
		IL_0074:
		return DOTween.Sequence();
	}

	public override bool ShouldShow(CardGameEndScores rankReport)
	{
		//IL_031c: Expected I4, but got O
		//IL_00a5: Expected O, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00cf: Expected O, but got I
		//IL_0184: Expected O, but got I
		//IL_01ae: Expected O, but got I4
		//IL_0151: Expected O, but got I4
		//IL_00f8: Expected O, but got I
		//IL_0243: Expected O, but got I4
		//IL_0256: Expected O, but got I4
		//IL_0278: Expected O, but got I4
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		if (rankReport == null)
		{
			goto IL_030e;
		}
		TournamentEndGameReport <tournamentReport>k__BackingField = rankReport.<tournamentReport>k__BackingField;
		bool flag;
		TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
		if (rankReport.<tournamentReport>k__BackingField != null && <tournamentReport>k__BackingField.isFinalMatch)
		{
			flag = rankReport.<tournamentReport>k__BackingField.IsMatchOver;
			if (flag)
			{
				object obj = 152985600;
				object obj2 = typeof(Queue<string>) + 872;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6841]");
				object obj3 = (nint)0 & (nint)1;
				if (obj3 != null)
				{
					object obj4 = (nint)0 + (nint)2248;
					object obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v13+E4]");
					bool flag2 = (nint)0 == 0;
					object obj6 = obj4;
					if (!flag2)
					{
						goto IL_012d;
					}
				}
				else
				{
					_ = 1;
					object obj4 = (nint)0 + (nint)2248;
					object obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v13+E4]");
					bool flag3 = (nint)0 == 0;
					object obj7 = !flag3;
					object obj6 = obj4;
					if (obj7 != null)
					{
						goto IL_012d;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				if ((object)tournamentMatchInfo != null)
				{
					goto IL_01fa;
				}
				goto IL_030e;
			}
		}
		else
		{
			flag = false;
		}
		goto IL_031c;
		IL_012d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)tournamentMatchInfo == null;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_01fa;
		}
		goto IL_030e;
		IL_031c:
		return flag;
		IL_030e:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_01fa:
		TournamentData tournament = tournamentMatchInfo.Tournament;
		if (tournament != null)
		{
			bool flag5 = tournament.<PrizeType>k__BackingField < TournamentPrizeType.TournamentPoints;
			object obj9 = !flag5;
			object obj10 = tournament.<PrizeType>k__BackingField - 9;
			bool flag6 = obj10 == null;
			object obj11 = 1 << (int)tournament.<PrizeType>k__BackingField;
			object obj12 = obj11 & 0x20C;
			object obj13 = ~obj9;
			object obj14 = obj13 | flag6;
			object obj15 = ~obj14;
			bool flag7 = obj15 != null || obj12 == null;
			flag = true;
			if (flag7)
			{
				goto IL_031c;
			}
			CardGame cardGame = base.game;
			if ((object)cardGame != null)
			{
				return cardGame.IsSpectator;
			}
		}
		goto IL_030e;
	}
}
