using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using Server.Models;
using TMPro;
using UnityEngine;

public class MassTournamentRewardsGameEndWidget : GameEndWidget
{
	private sealed class <>c__DisplayClass9_0
	{
		public MassTournamentRewardsGameEndWidget <>4__this;

		public TournamentEndGameReport t;

		internal void <PrepareAnimation>b__0(MassEventModel m)
		{
			MassTournamentRewardsGameEndWidget massTournamentRewardsGameEndWidget = <>4__this;
			IThemeColorProfile newProfile = m.GenerateTheme();
			massTournamentRewardsGameEndWidget.themeSetter.UpdateTheme(newProfile);
			MassTournamentRewardsGameEndWidget massTournamentRewardsGameEndWidget2 = <>4__this;
			MassEventStageViewModel activeStage = m.ActiveStage;
			DiscreteProgressIndicator remainingTrials = massTournamentRewardsGameEndWidget2.remainingTrials;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v8 (Server.Models.MassEventStageViewModel)+24]");
			remainingTrials.MaxProgress = 0;
			MassTournamentRewardsGameEndWidget massTournamentRewardsGameEndWidget3 = <>4__this;
			TournamentEndGameReport tournamentEndGameReport = t;
			massTournamentRewardsGameEndWidget3.remainingTrials.CurrentProgress = tournamentEndGameReport.massTrials;
		}
	}

	private AvatarInitializer myAvatar;

	private AvatarInitializer teammateAvatar;

	private ThemeProvider themeSetter;

	private TextMeshProUGUI gainedPointsText;

	private TextMeshProUGUI teammateGainedPointsText;

	private TextMeshProUGUI newTotalPointsText;

	private DiscreteProgressIndicator remainingTrials;

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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A0]");
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
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected O, but got Unknown
		//IL_074a: Expected O, but got I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_011a: Expected O, but got I
		//IL_01eb: Expected O, but got I
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		//IL_031d: Expected O, but got I4
		//IL_0154: Expected O, but got I
		//IL_00cc: Expected O, but got I
		//IL_0259: Expected O, but got I4
		//IL_029c: Expected O, but got I4
		//IL_01c2: Expected O, but got I4
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected I4, but got Unknown
		//IL_040c: Expected I, but got O
		//IL_079f: Expected O, but got I4
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0432: Expected O, but got Unknown
		//IL_045c: Expected O, but got I4
		//IL_07cf: Expected O, but got I4
		//IL_0485: Expected O, but got I
		//IL_058b: Expected O, but got I
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_050a: Expected O, but got I4
		//IL_063c: Expected O, but got I4
		//IL_0533: Expected O, but got I
		//IL_05f9: Expected O, but got I4
		//IL_0681: Expected O, but got I
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected O, but got Unknown
		//IL_06a1: Expected O, but got I
		//IL_06ce: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = rankReport.<tournamentReport>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = this + 32;
		CardGame cardGame = (CardGame)obj5;
		bool flag = obj5 == null;
		object obj6 = !flag;
		if (obj6 == null)
		{
			object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X0_v127+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj10 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj5 = cardGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		int myTeamIndex = cardGame.MyTeamIndex;
		object obj11 = typeof(Queue<string>) + 872;
		object obj12 = (nint)0 + (nint)2248;
		if (rankReport.<WinnerTeamIndex>k__BackingField == myTeamIndex)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A0]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 != null)
			{
				object obj14 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v112+E4]");
				if ((nint)0 != 0)
				{
					goto IL_019e;
				}
			}
			else
			{
				_ = 1;
				object obj14 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v112+E4]");
				bool flag3 = (nint)0 == 0;
				object obj15 = !flag3;
				if (obj15 != null)
				{
					goto IL_019e;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			goto IL_02c3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A0]");
		object obj16 = (nint)0 & (nint)1;
		if (obj16 != null)
		{
			object obj17 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v94+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0235;
			}
		}
		else
		{
			_ = 1;
			object obj17 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v94+E4]");
			bool flag4 = (nint)0 == 0;
			object obj18 = !flag4;
			if (obj18 != null)
			{
				goto IL_0235;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0344;
		IL_0344:
		TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
		TournamentData tournament = tournamentMatchInfo.Tournament;
		goto IL_0758;
		IL_0758:
		int? num = default(int?);
		string text = num.ToString();
		gainedPointsText.text = text;
		string text2 = num.ToString();
		teammateGainedPointsText.text = text2;
		object obj19 = obj4;
		TextMeshProUGUI textMeshProUGUI = newTotalPointsText;
		object obj20 = (??)num & 1;
		int? num2;
		if (obj20 != null)
		{
			object obj21 = (object?)num >> 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v11+28]");
			int value = 0 - obj21;
			num2 = value;
		}
		int? num3 = default(int?);
		string text3 = num3.ToString();
		nint num4 = (nint)textMeshProUGUI;
		textMeshProUGUI.text = text3;
		CardGame cardGame2 = (CardGame)obj5;
		bool flag5 = obj5 == null;
		object obj22 = !flag5;
		if (obj22 == null)
		{
			object obj23 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v77+E4]");
			bool flag6 = (nint)0 == 0;
			object obj25 = !flag6;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj26 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj5 = cardGame2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		CardGamePlayer myPlayer = cardGame2.MyPlayer;
		myAvatar.Initialize(myPlayer);
		CardGame cardGame3 = (CardGame)obj5;
		bool flag7 = obj5 == null;
		object obj27 = !flag7;
		if (obj27 == null)
		{
			object obj28 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v492 @ X0_v63+E4]");
			bool flag8 = (nint)0 == 0;
			object obj30 = !flag8;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj31 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj5 = cardGame3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		CardGamePlayer myTeammate = cardGame3.MyTeammate;
		teammateAvatar.Initialize(myTeammate);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A0]");
		object obj32 = (nint)0 & (nint)1;
		if (obj32 != null)
		{
			object obj33 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v48+E4]");
			if ((nint)0 != 0)
			{
				goto IL_05d5;
			}
		}
		else
		{
			_ = 1;
			object obj33 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v48+E4]");
			bool flag9 = (nint)0 == 0;
			object obj34 = !flag9;
			if (obj34 != null)
			{
				goto IL_05d5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0663;
		IL_02c3:
		TournamentMatchInfo tournamentMatchInfo2 = default(TournamentMatchInfo);
		TournamentData tournament2 = tournamentMatchInfo2.Tournament;
		num2 = tournament2.<FirstPrize>k__BackingField;
		goto IL_0758;
		IL_0235:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag10 = (object)tournamentMatchInfo == null;
		object obj35 = !flag10;
		if (obj35 != null)
		{
			goto IL_0344;
		}
		goto IL_06fe;
		IL_019e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag11 = (object)tournamentMatchInfo2 == null;
		object obj36 = !flag11;
		if (obj36 != null)
		{
			goto IL_02c3;
		}
		goto IL_06fe;
		IL_06fe:
		throw new NullReferenceException();
		IL_0663:
		TournamentMatchInfo tournamentMatchInfo3 = default(TournamentMatchInfo);
		TournamentData tournament3 = tournamentMatchInfo3.Tournament;
		object obj37 = (nint)0 + (nint)3232;
		object obj38 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2616;
		object obj39 = (nint)0 + (nint)968;
		long? num5 = default(long?);
		long value2 = num5.Value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj39);
		MassTournamentManager.GetMassEvent(value2, action);
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		return;
		IL_05d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag12 = (object)tournamentMatchInfo3 == null;
		object obj40 = !flag12;
		if (obj40 != null)
		{
			goto IL_0663;
		}
		goto IL_06fe;
	}

	public override void Populate(CardGameEndScores rankReport)
	{
	}

	public override Sequence AnimatedPopulate(CardGameEndScores rankReport)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_018a: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E677A]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v12+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Sequence sequence = DOTween.Sequence();
		if (rankReport != null)
		{
			goto IL_011d;
		}
		goto IL_01ee;
		IL_01ee:
		return (Sequence)(object)new NullReferenceException();
		IL_011d:
		TournamentEndGameReport <tournamentReport>k__BackingField = rankReport.<tournamentReport>k__BackingField;
		if (rankReport.<tournamentReport>k__BackingField != null)
		{
			object obj5 = typeof(SqlSingle[]) + 3912;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tweener t = AnimationExtensions.DONumber(newTotalPointsText, <tournamentReport>k__BackingField.massPoints, 0.3f);
			Sequence sequence2 = TweenSettingsExtensions.Append(sequence, t);
			return sequence;
		}
		goto IL_01ee;
		IL_0074:
		sequence = DOTween.Sequence();
		bool flag3 = rankReport == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_011d;
		}
		goto IL_01ee;
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
					TournamentMatchInfo tournamentMatchInfo = ((MassTournamentRewardsGameEndWidget)flag4).matchInfo;
					if ((object)tournamentMatchInfo != null)
					{
						TournamentData tournament = tournamentMatchInfo.Tournament;
						if (tournament != null)
						{
							object obj8 = tournament.<PrizeType>k__BackingField - 3;
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
