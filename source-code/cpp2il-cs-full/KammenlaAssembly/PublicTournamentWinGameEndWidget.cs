using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;

public class PublicTournamentWinGameEndWidget : GameEndWidget
{
	private const string wonFirstPlace = "won_tournament_1st_place";

	private const string wonSecondPlace = "won_tournament_2nd_place";

	private AvatarInitializer myAvatar;

	private AvatarInitializer teammateAvatar;

	private TextMeshProUGUI myCoins;

	private TextMeshProUGUI myGainedCoins;

	private TextMeshProUGUI teammateGainedPoints;

	private TextMeshProUGUI prizeLabel;

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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E683F]");
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
		//IL_002a: Expected O, but got I4
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_027b: Expected O, but got I
		//IL_02a5: Expected O, but got I4
		//IL_0064: Expected O, but got I
		//IL_01b1: Expected O, but got I4
		//IL_0158: Expected O, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_0208: Expected O, but got I4
		//IL_00ce: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_022c: Expected O, but got I
		//IL_0370: Expected O, but got I4
		//IL_0379: Expected O, but got I4
		//IL_0264: Expected O, but got I4
		//IL_056d: Expected I4, but got O
		//IL_05a9: Expected O, but got I4
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_03de: Expected O, but got I
		//IL_0417: Expected O, but got I4
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected O, but got Unknown
		//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c8: Expected I4, but got Unknown
		CardGame cardGame = base.game;
		int myTeamIndex = cardGame.MyTeamIndex;
		object obj = 152985600;
		if (rankReport.<WinnerTeamIndex>k__BackingField == myTeamIndex)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E683F]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = typeof(Queue<string>) + 872;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v60+E4]");
				if ((nint)0 != 0)
				{
					goto IL_00c2;
				}
			}
			else
			{
				_ = 1;
				object obj5 = typeof(Queue<string>) + 872;
				object obj4 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v60+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = !flag;
				if (obj6 != null)
				{
					goto IL_00c2;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = (nint)0 + (nint)2248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			goto IL_023b;
		}
		object obj8 = typeof(Queue<string>) + 872;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E683F]");
		object obj9 = (nint)0 & (nint)1;
		if (obj9 != null)
		{
			object obj10 = (nint)0 + (nint)2248;
			object obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v43+E4]");
			bool flag2 = (nint)0 == 0;
			object obj12 = obj10;
			if (!flag2)
			{
				goto IL_018d;
			}
		}
		else
		{
			_ = 1;
			object obj10 = (nint)0 + (nint)2248;
			object obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v43+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			object obj12 = obj10;
			if (obj13 != null)
			{
				goto IL_018d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_02d4;
		IL_037e:
		CardGame cardGame2;
		CardGamePlayer myPlayer = cardGame2.MyPlayer;
		AvatarInitializer avatarInitializer;
		avatarInitializer.Initialize(myPlayer);
		CardGame cardGame3 = base.game;
		CardGamePlayer myTeammate = cardGame3.MyTeammate;
		object obj14 = typeof(Queue<string>) + 848;
		object obj15 = (nint)0 + (nint)2200;
		teammateAvatar.Initialize(myTeammate);
		object obj16 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		object obj17 = !flag4;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj18 = "utf-32" + 1576;
		object obj19 = "utf-32" + 1584;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		int? num;
		object obj20 = (??)num & 1;
		if (obj20 != null)
		{
			object obj21 = (object?)num >> 32;
			int value = aces - obj21;
			int? num2 = value;
		}
		int? num3 = default(int?);
		string text = num3.ToString();
		TextMeshProExtensions.FixArabic(myCoins, text);
		int? num4;
		string text2 = num4.ToString();
		TextMeshProExtensions.FixArabic(myGainedCoins, text2);
		string text3 = num4.ToString();
		TextMeshProExtensions.FixArabic(teammateGainedPoints, text3);
		TextMeshProExtensions.Localize(text: (string)((rankReport.<WinnerTeamIndex>k__BackingField != myTeamIndex) ? obj19 : obj18), textMesh: prizeLabel);
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		return;
		IL_055f:
		object obj22;
		int value2 = obj22 >> 1;
		int? num5 = value2;
		avatarInitializer = myAvatar;
		cardGame2 = base.game;
		bool flag5 = (object)cardGame2 == null;
		object obj23 = !flag5;
		num4 = num5;
		num = num5;
		if (obj23 != null)
		{
			goto IL_037e;
		}
		goto IL_0558;
		IL_023b:
		TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
		TournamentData tournament = tournamentMatchInfo.Tournament;
		obj22 = tournament.<FirstPrize>k__BackingField + tournament.<FirstPrize>k__BackingField;
		goto IL_055f;
		IL_00c2:
		object obj24 = (nint)0 + (nint)2248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag6 = (object)tournamentMatchInfo == null;
		object obj25 = !flag6;
		if (obj25 != null)
		{
			goto IL_023b;
		}
		goto IL_0558;
		IL_018d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		TournamentMatchInfo tournamentMatchInfo2 = default(TournamentMatchInfo);
		bool flag7 = (object)tournamentMatchInfo2 == null;
		object obj26 = !flag7;
		if (obj26 != null)
		{
			goto IL_02d4;
		}
		goto IL_0558;
		IL_02d4:
		TournamentData tournament2 = tournamentMatchInfo2.Tournament;
		object obj27 = (??)tournament2.<SecondPrize>k__BackingField & 1;
		if (obj27 != null)
		{
			object obj28 = (object?)tournament2.<SecondPrize>k__BackingField >> 32;
			object obj29 = (object?)tournament2.<SecondPrize>k__BackingField >> 63;
			obj22 = obj28 + obj29;
			goto IL_055f;
		}
		avatarInitializer = myAvatar;
		cardGame2 = base.game;
		num4 = (int?)(object)0;
		num = (int?)(object)0;
		goto IL_037e;
		IL_0558:
		throw new NullReferenceException();
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
			int aces = SFSKammelnaUserExtensions.GetAces(localUser);
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tweener t = AnimationExtensions.DONumber(myCoins, aces, 0.3f);
			Sequence sequence2 = TweenSettingsExtensions.Append(sequence, t);
			return sequence;
		}
		return (Sequence)(object)new NullReferenceException();
	}

	public override bool ShouldShow(CardGameEndScores rankReport)
	{
		//IL_01a1: Expected I4, but got O
		//IL_0078: Expected O, but got I4
		//IL_0113: Expected O, but got I4
		//IL_0171: Expected O, but got I4
		bool flag2;
		if (rankReport != null)
		{
			TournamentEndGameReport <tournamentReport>k__BackingField = rankReport.<tournamentReport>k__BackingField;
			CardGame cardGame = base.game;
			if ((object)cardGame != null)
			{
				bool isSpectator = cardGame.IsSpectator;
				bool flag = !isSpectator;
				object obj = !flag;
				flag2 = false;
				if (obj == null)
				{
					bool flag3 = rankReport.<tournamentReport>k__BackingField == null;
					flag2 = false;
					if (!flag3)
					{
						if (!<tournamentReport>k__BackingField.isFinalMatch)
						{
							return false;
						}
						flag2 = rankReport.<tournamentReport>k__BackingField.IsMatchOver;
						if (flag2)
						{
							TournamentMatchInfo tournamentMatchInfo = ((PublicTournamentWinGameEndWidget)flag2).matchInfo;
							if ((object)tournamentMatchInfo != null)
							{
								TournamentData tournament = tournamentMatchInfo.Tournament;
								if (tournament != null)
								{
									object obj2 = tournament.<PrizeType>k__BackingField - 2;
									bool flag4 = obj2 == null;
									flag2 = flag4;
									goto IL_01a1;
								}
							}
							goto IL_0193;
						}
					}
				}
				goto IL_01a1;
			}
		}
		goto IL_0193;
		IL_01a1:
		return flag2;
		IL_0193:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
