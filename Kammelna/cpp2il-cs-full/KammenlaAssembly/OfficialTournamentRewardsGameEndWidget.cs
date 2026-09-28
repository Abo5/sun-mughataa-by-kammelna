using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;

public class OfficialTournamentRewardsGameEndWidget : GameEndWidget
{
	private AvatarInitializer myAvatar;

	private AvatarInitializer teammateAvatar;

	private TextMeshProUGUI myPoints;

	private TextMeshProUGUI myGainedPoints;

	private TextMeshProUGUI teammateGainedPoints;

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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A9]");
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
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected O, but got Unknown
		//IL_074a: Expected O, but got I4
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		//IL_0356: Expected O, but got I4
		//IL_00f9: Expected O, but got I
		//IL_0071: Expected O, but got I
		//IL_01fe: Expected O, but got I4
		//IL_0241: Expected O, but got I4
		//IL_0167: Expected O, but got I4
		//IL_03bc: Expected O, but got I
		//IL_03d6: Expected O, but got I4
		//IL_077a: Expected O, but got I4
		//IL_0293: Expected O, but got I
		//IL_02c5: Expected O, but got I
		//IL_0445: Expected I, but got O
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_04a0: Expected O, but got I4
		//IL_0302: Expected I, but got O
		//IL_07aa: Expected O, but got I4
		//IL_04c9: Expected O, but got I
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_05c8: Expected O, but got I
		//IL_0601: Expected O, but got I4
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected O, but got Unknown
		//IL_054c: Expected O, but got I4
		//IL_0575: Expected O, but got I
		//IL_0656: Unknown result type (might be due to invalid IL or missing references)
		//IL_065b: Expected O, but got Unknown
		//IL_068f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected I4, but got Unknown
		object obj = this + 32;
		CardGame cardGame = (CardGame)obj;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v105+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = cardGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		int myTeamIndex = cardGame.MyTeamIndex;
		object obj7 = typeof(Queue<string>) + 872;
		object obj8 = (nint)0 + (nint)2248;
		if (rankReport.<WinnerTeamIndex>k__BackingField == myTeamIndex)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A9]");
			object obj9 = (nint)0 & (nint)1;
			if (obj9 != null)
			{
				object obj10 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v90+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0143;
				}
			}
			else
			{
				_ = 1;
				object obj10 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v90+E4]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				if (obj11 != null)
				{
					goto IL_0143;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			goto IL_0268;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A9]");
		object obj12 = (nint)0 & (nint)1;
		if (obj12 != null)
		{
			object obj13 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v72+E4]");
			if ((nint)0 != 0)
			{
				goto IL_01da;
			}
		}
		else
		{
			_ = 1;
			object obj13 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v72+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 != null)
			{
				goto IL_01da;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_037d;
		IL_01da:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
		bool flag5 = (object)tournamentMatchInfo == null;
		object obj15 = !flag5;
		if (obj15 != null)
		{
			goto IL_037d;
		}
		goto IL_0716;
		IL_0268:
		TournamentMatchInfo tournamentMatchInfo2 = default(TournamentMatchInfo);
		TournamentData tournament = tournamentMatchInfo2.Tournament;
		int num = tournament.<FirstPrize>k__BackingField;
		object obj16 = (nint)0 + (nint)3136;
		int? num2 = tournament.<FirstPrize>k__BackingField;
		AvatarInitializer avatarInitializer = myAvatar;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E679E]");
		object obj17 = (nint)0 & (nint)1;
		bool flag6 = obj17 == null;
		int? num3 = num2;
		int? num4 = num2;
		if (flag6)
		{
			goto IL_042f;
		}
		int? num5 = num2;
		nint num6 = (nint)obj16;
		int? num7 = num2;
		int <FirstPrize>k__BackingField = tournament.<FirstPrize>k__BackingField;
		AvatarInitializer avatarInitializer2 = myAvatar;
		goto IL_0758;
		IL_037d:
		TournamentData tournament2 = tournamentMatchInfo.Tournament;
		num4 = tournament2.<SecondPrize>k__BackingField;
		avatarInitializer = myAvatar;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E679E]");
		object obj18 = (nint)0 & (nint)1;
		bool flag7 = obj18 == null;
		object obj19 = !flag7;
		num3 = tournament2.<SecondPrize>k__BackingField;
		num = 0;
		num5 = tournament2.<SecondPrize>k__BackingField;
		IntPtr intPtr = default(IntPtr);
		num6 = intPtr;
		num7 = tournament2.<SecondPrize>k__BackingField;
		<FirstPrize>k__BackingField = 0;
		avatarInitializer2 = myAvatar;
		if (obj19 == null)
		{
			goto IL_042f;
		}
		goto IL_0758;
		IL_042f:
		_ = 1;
		num5 = num3;
		num6 = (nint)obj16;
		num7 = num4;
		<FirstPrize>k__BackingField = num;
		avatarInitializer2 = avatarInitializer;
		goto IL_0758;
		IL_0143:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag8 = (object)tournamentMatchInfo2 == null;
		object obj20 = !flag8;
		if (obj20 != null)
		{
			goto IL_0268;
		}
		goto IL_0716;
		IL_0716:
		throw new NullReferenceException();
		IL_0758:
		CardGame cardGame2 = (CardGame)obj;
		bool flag9 = obj == null;
		object obj21 = !flag9;
		if (obj21 == null)
		{
			object obj22 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj23 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X0_v55+E4]");
			bool flag10 = (nint)0 == 0;
			object obj24 = !flag10;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj25 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = cardGame2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		CardGamePlayer myPlayer = cardGame2.MyPlayer;
		avatarInitializer2.Initialize(myPlayer);
		CardGame cardGame3 = (CardGame)obj;
		bool flag11 = obj == null;
		object obj26 = !flag11;
		if (obj26 == null)
		{
			object obj27 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X0_v41+E4]");
			bool flag12 = (nint)0 == 0;
			object obj29 = !flag12;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj30 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = cardGame3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		CardGamePlayer myTeammate = cardGame3.MyTeammate;
		object obj31 = typeof(Queue<string>) + 848;
		object obj32 = (nint)0 + (nint)2200;
		teammateAvatar.Initialize(myTeammate);
		object obj33 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v18+E4]");
		bool flag13 = (nint)0 == 0;
		object obj34 = !flag13;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int tournamentPoints = SFSKammelnaUserExtensions.GetTournamentPoints(localUser);
		object obj35 = (??)num7 & 1;
		if (obj35 != null)
		{
			object obj36 = (object?)num7 >> 32;
			int value = tournamentPoints - obj36;
			num2 = value;
		}
		int? num8 = default(int?);
		string text = num8.ToString();
		myPoints.text = text;
		string text2 = num5.ToString();
		myGainedPoints.text = text2;
		string text3 = num5.ToString();
		teammateGainedPoints.text = text3;
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
	}

	public override void Populate(CardGameEndScores rankReport)
	{
	}

	public override Sequence AnimatedPopulate(CardGameEndScores rankReport)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_0067: Expected O, but got I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_0108: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2200;
		Sequence sequence = DOTween.Sequence();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		if ((object)sessionModel != null)
		{
			object obj8 = typeof(SqlSingle[]) + 3912;
			User localUser = sessionModel.LocalUser;
			int tournamentPoints = SFSKammelnaUserExtensions.GetTournamentPoints(localUser);
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tweener t = AnimationExtensions.DONumber(myPoints, tournamentPoints, 0.3f);
			Sequence sequence2 = TweenSettingsExtensions.Append(sequence, t);
			return sequence;
		}
		return (Sequence)(object)new NullReferenceException();
	}

	public override bool ShouldShow(CardGameEndScores rankReport)
	{
		//IL_0224: Expected I4, but got O
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0251: Expected O, but got I4
		//IL_00fb: Expected O, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_006d: Expected O, but got I4
		//IL_0096: Expected O, but got I
		//IL_0196: Expected O, but got I4
		//IL_01f4: Expected O, but got I4
		if (rankReport == null)
		{
			goto IL_0216;
		}
		TournamentEndGameReport <tournamentReport>k__BackingField = rankReport.<tournamentReport>k__BackingField;
		object obj = this + 32;
		KGame kGame = (KGame)obj;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = kGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if ((object)kGame == null)
			{
				goto IL_0216;
			}
		}
		bool isSpectator = kGame.IsSpectator;
		bool flag3 = !isSpectator;
		object obj7 = !flag3;
		bool flag4 = false;
		if (obj7 == null)
		{
			bool flag5 = rankReport.<tournamentReport>k__BackingField == null;
			flag4 = false;
			if (!flag5)
			{
				if (!<tournamentReport>k__BackingField.isFinalMatch)
				{
					return false;
				}
				flag4 = rankReport.<tournamentReport>k__BackingField.IsMatchOver;
				if (flag4)
				{
					TournamentMatchInfo tournamentMatchInfo = ((OfficialTournamentRewardsGameEndWidget)flag4).matchInfo;
					if ((object)tournamentMatchInfo != null)
					{
						TournamentData tournament = tournamentMatchInfo.Tournament;
						if (tournament != null)
						{
							object obj8 = tournament.<PrizeType>k__BackingField - 9;
							bool flag6 = obj8 == null;
							flag4 = flag6;
							goto IL_025f;
						}
					}
					goto IL_0216;
				}
			}
		}
		goto IL_025f;
		IL_0216:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_025f:
		return flag4;
	}
}
