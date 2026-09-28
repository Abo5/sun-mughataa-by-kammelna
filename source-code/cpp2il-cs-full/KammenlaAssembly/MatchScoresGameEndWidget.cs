using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using Server.Models;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class MatchScoresGameEndWidget : GameEndWidget
{
	private sealed class <>c__DisplayClass25_0
	{
		public MatchScoresGameEndWidget <>4__this;

		public CardGameEndScores rankReport;

		internal void <AnimatedPopulate>b__0()
		{
			MatchScoresGameEndWidget matchScoresGameEndWidget = <>4__this;
			CardGameEndScores cardGameEndScores = rankReport;
			int num = teamScore(cardGameEndScores.<WinnerTeamIndex>k__BackingField);
			int num2 = default(int);
			string text = num2.ToString();
			matchScoresGameEndWidget.ourScore.text = text;
		}

		internal void <AnimatedPopulate>b__1()
		{
			MatchScoresGameEndWidget matchScoresGameEndWidget = <>4__this;
			int myTeamScore = <>4__this.myTeamScore;
			int num = default(int);
			string text = num.ToString();
			matchScoresGameEndWidget.ourScore.text = text;
		}

		internal void <AnimatedPopulate>b__2()
		{
			MatchScoresGameEndWidget matchScoresGameEndWidget = <>4__this;
			int opponentTeamScore = <>4__this.opponentTeamScore;
			int num = default(int);
			string text = num.ToString();
			matchScoresGameEndWidget.theirScore.text = text;
		}
	}

	private AvatarInitializer myAvatar;

	private AvatarInitializer teammateAvatar;

	private AvatarInitializer opponentAvatar1;

	private AvatarInitializer opponentAvatar2;

	private Graphic myTeamArea;

	private Color winningColor;

	private Color losingColor;

	private Color winningTextColor;

	private Color losingTextColor;

	private TextMeshProUGUI ourScore;

	private TextMeshProUGUI theirScore;

	private TextMeshProUGUI ourScoreTitle;

	private TextMeshProUGUI theirScoreTitle;

	private float preAnimDelay = 0f;

	private float postAnimDelay;

	private float scoreAnimTime = 0.35f;

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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A5]");
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

	private int myTeamScore
	{
		get
		{
			//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03af: Expected O, but got Unknown
			//IL_03d1: Expected O, but got I4
			//IL_00c0: Expected O, but got I4
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Expected O, but got Unknown
			//IL_01c1: Expected O, but got I
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_030e: Expected O, but got I
			//IL_0338: Expected O, but got I4
			//IL_00f6: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_0243: Expected O, but got I4
			//IL_01ea: Expected O, but got I
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected O, but got Unknown
			//IL_029a: Expected O, but got I4
			//IL_0160: Expected O, but got I
			//IL_0184: Expected O, but got I4
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected O, but got Unknown
			//IL_03a4: Expected I4, but got O
			//IL_02be: Expected O, but got I
			object obj = this + 32;
			CardGame cardGame = (CardGame)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v41+E4]");
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
				if ((object)cardGame == null)
				{
					goto IL_0396;
				}
			}
			int myTeamIndex = cardGame.MyTeamIndex;
			object obj7 = 152985600;
			TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
			TournamentMatchInfo tournamentMatchInfo2 = default(TournamentMatchInfo);
			if (myTeamIndex == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A5]");
				object obj8 = (nint)0 & (nint)1;
				if (obj8 != null)
				{
					object obj9 = typeof(Queue<string>) + 872;
					object obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v26+E4]");
					if ((nint)0 != 0)
					{
						goto IL_0154;
					}
				}
				else
				{
					_ = 1;
					object obj11 = typeof(Queue<string>) + 872;
					object obj10 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v26+E4]");
					bool flag3 = (nint)0 == 0;
					object obj12 = !flag3;
					if (obj12 != null)
					{
						goto IL_0154;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = (nint)0 + (nint)2248;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				if ((object)tournamentMatchInfo != null)
				{
					goto IL_02ea;
				}
			}
			else
			{
				object obj14 = typeof(Queue<string>) + 872;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A5]");
				object obj15 = (nint)0 & (nint)1;
				if (obj15 != null)
				{
					object obj16 = (nint)0 + (nint)2248;
					object obj17 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v9+E4]");
					bool flag4 = (nint)0 == 0;
					object obj18 = obj16;
					if (!flag4)
					{
						goto IL_021f;
					}
				}
				else
				{
					_ = 1;
					object obj16 = (nint)0 + (nint)2248;
					object obj17 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v9+E4]");
					bool flag5 = (nint)0 == 0;
					object obj19 = !flag5;
					object obj18 = obj16;
					if (obj19 != null)
					{
						goto IL_021f;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				if ((object)tournamentMatchInfo2 != null)
				{
					goto IL_0384;
				}
			}
			goto IL_0396;
			IL_02ea:
			return tournamentMatchInfo.TeamScore1;
			IL_021f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag6 = (object)tournamentMatchInfo2 == null;
			object obj20 = !flag6;
			if (obj20 != null)
			{
				goto IL_0384;
			}
			goto IL_0396;
			IL_0154:
			object obj21 = (nint)0 + (nint)2248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag7 = (object)tournamentMatchInfo == null;
			object obj22 = !flag7;
			if (obj22 != null)
			{
				goto IL_02ea;
			}
			goto IL_0396;
			IL_0396:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_0384:
			return tournamentMatchInfo2.TeamScore2;
		}
	}

	private int opponentTeamScore
	{
		get
		{
			//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03af: Expected O, but got Unknown
			//IL_03d1: Expected O, but got I4
			//IL_00c0: Expected O, but got I4
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Expected O, but got Unknown
			//IL_01c1: Expected O, but got I
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			//IL_030e: Expected O, but got I
			//IL_0338: Expected O, but got I4
			//IL_00f6: Expected O, but got I
			//IL_006c: Expected O, but got I
			//IL_0243: Expected O, but got I4
			//IL_01ea: Expected O, but got I
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Expected O, but got Unknown
			//IL_029a: Expected O, but got I4
			//IL_0160: Expected O, but got I
			//IL_0184: Expected O, but got I4
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected O, but got Unknown
			//IL_03a4: Expected I4, but got O
			//IL_02be: Expected O, but got I
			object obj = this + 32;
			CardGame cardGame = (CardGame)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v41+E4]");
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
				if ((object)cardGame == null)
				{
					goto IL_0396;
				}
			}
			int myTeamIndex = cardGame.MyTeamIndex;
			object obj7 = 152985600;
			TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
			TournamentMatchInfo tournamentMatchInfo2 = default(TournamentMatchInfo);
			if (myTeamIndex == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A5]");
				object obj8 = (nint)0 & (nint)1;
				if (obj8 != null)
				{
					object obj9 = typeof(Queue<string>) + 872;
					object obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v26+E4]");
					if ((nint)0 != 0)
					{
						goto IL_0154;
					}
				}
				else
				{
					_ = 1;
					object obj11 = typeof(Queue<string>) + 872;
					object obj10 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v26+E4]");
					bool flag3 = (nint)0 == 0;
					object obj12 = !flag3;
					if (obj12 != null)
					{
						goto IL_0154;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = (nint)0 + (nint)2248;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				if ((object)tournamentMatchInfo != null)
				{
					goto IL_02ea;
				}
			}
			else
			{
				object obj14 = typeof(Queue<string>) + 872;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A5]");
				object obj15 = (nint)0 & (nint)1;
				if (obj15 != null)
				{
					object obj16 = (nint)0 + (nint)2248;
					object obj17 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v9+E4]");
					bool flag4 = (nint)0 == 0;
					object obj18 = obj16;
					if (!flag4)
					{
						goto IL_021f;
					}
				}
				else
				{
					_ = 1;
					object obj16 = (nint)0 + (nint)2248;
					object obj17 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v9+E4]");
					bool flag5 = (nint)0 == 0;
					object obj19 = !flag5;
					object obj18 = obj16;
					if (obj19 != null)
					{
						goto IL_021f;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				if ((object)tournamentMatchInfo2 != null)
				{
					goto IL_0384;
				}
			}
			goto IL_0396;
			IL_02ea:
			return tournamentMatchInfo.TeamScore2;
			IL_021f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag6 = (object)tournamentMatchInfo2 == null;
			object obj20 = !flag6;
			if (obj20 != null)
			{
				goto IL_0384;
			}
			goto IL_0396;
			IL_0154:
			object obj21 = (nint)0 + (nint)2248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag7 = (object)tournamentMatchInfo == null;
			object obj22 = !flag7;
			if (obj22 != null)
			{
				goto IL_02ea;
			}
			goto IL_0396;
			IL_0396:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_0384:
			return tournamentMatchInfo2.TeamScore1;
		}
	}

	private int teamScore(int team)
	{
		//IL_0009: Expected O, but got I4
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_010a: Expected O, but got I
		//IL_0257: Expected O, but got I
		//IL_0281: Expected O, but got I4
		//IL_003f: Expected O, but got I
		//IL_018c: Expected O, but got I4
		//IL_0133: Expected O, but got I
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01e3: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00cd: Expected O, but got I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0207: Expected O, but got I
		//IL_02ed: Expected I4, but got O
		object obj = 152985600;
		TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
		TournamentMatchInfo tournamentMatchInfo2 = default(TournamentMatchInfo);
		if (team == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A5]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = typeof(Queue<string>) + 872;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v22+E4]");
				if ((nint)0 != 0)
				{
					goto IL_009d;
				}
			}
			else
			{
				_ = 1;
				object obj5 = typeof(Queue<string>) + 872;
				object obj4 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v22+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = !flag;
				if (obj6 != null)
				{
					goto IL_009d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = (nint)0 + (nint)2248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)tournamentMatchInfo != null)
			{
				goto IL_0233;
			}
		}
		else
		{
			object obj8 = typeof(Queue<string>) + 872;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A5]");
			object obj9 = (nint)0 & (nint)1;
			if (obj9 != null)
			{
				object obj10 = (nint)0 + (nint)2248;
				object obj11 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v5+E4]");
				bool flag2 = (nint)0 == 0;
				object obj12 = obj10;
				if (!flag2)
				{
					goto IL_0168;
				}
			}
			else
			{
				_ = 1;
				object obj10 = (nint)0 + (nint)2248;
				object obj11 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v5+E4]");
				bool flag3 = (nint)0 == 0;
				object obj13 = !flag3;
				object obj12 = obj10;
				if (obj13 != null)
				{
					goto IL_0168;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)tournamentMatchInfo2 != null)
			{
				goto IL_02cd;
			}
		}
		goto IL_02df;
		IL_02cd:
		return tournamentMatchInfo2.TeamScore2;
		IL_02df:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0233:
		return tournamentMatchInfo.TeamScore1;
		IL_009d:
		object obj14 = (nint)0 + (nint)2248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)tournamentMatchInfo == null;
		object obj15 = !flag4;
		if (obj15 != null)
		{
			goto IL_0233;
		}
		goto IL_02df;
		IL_0168:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)tournamentMatchInfo2 == null;
		object obj16 = !flag5;
		if (obj16 != null)
		{
			goto IL_02cd;
		}
		goto IL_02df;
	}

	public override void PrepareAnimation(CardGameEndScores rankReport)
	{
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected O, but got Unknown
		//IL_0980: Expected O, but got I4
		//IL_09b0: Expected O, but got I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		//IL_0071: Expected O, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I4
		//IL_0b6e: Expected O, but got I4
		//IL_010b: Expected O, but got I
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06db: Expected O, but got Unknown
		//IL_0705: Expected O, but got I4
		//IL_09d4: Expected O, but got I
		//IL_09ee: Expected O, but got I4
		//IL_0a00: Expected O, but got I4
		//IL_0a19: Expected O, but got I4
		//IL_0b92: Expected O, but got I
		//IL_0bbb: Expected O, but got I4
		//IL_072e: Expected O, but got I
		//IL_0beb: Expected O, but got I4
		//IL_07c5: Expected O, but got I4
		//IL_0a51: Expected O, but got I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0225: Expected O, but got I4
		//IL_024e: Expected O, but got I
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_02bf: Expected O, but got I4
		//IL_0a81: Expected O, but got I4
		//IL_02e8: Expected O, but got I
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0371: Expected O, but got I4
		//IL_0ab1: Expected O, but got I4
		//IL_039a: Expected O, but got I
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_0431: Expected O, but got I4
		//IL_0ae1: Expected O, but got I4
		//IL_045a: Expected O, but got I
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_04e3: Expected O, but got I4
		//IL_0b11: Expected O, but got I4
		//IL_050c: Expected O, but got I
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected O, but got Unknown
		//IL_05a3: Expected O, but got I4
		//IL_0c1b: Expected O, but got I4
		//IL_0620: Expected O, but got I
		//IL_05cc: Expected O, but got I
		//IL_0632: Expected O, but got I
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07eb: Expected O, but got Unknown
		//IL_0815: Expected O, but got I4
		//IL_083e: Expected O, but got I
		//IL_06a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected O, but got Unknown
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected O, but got Unknown
		//IL_0ca2: Expected O, but got I
		//IL_0d29: Expected O, but got I
		//IL_092b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0930: Expected O, but got Unknown
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Expected O, but got Unknown
		object obj = this + 32;
		CardGame cardGame = (CardGame)obj;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v210+E4]");
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
		KGame kGame = (KGame)obj;
		bool flag3 = obj == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X0_v196+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = kGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		int num;
		int num2;
		int num3;
		object obj14;
		int num5;
		int num6;
		int team;
		object obj15;
		if (kGame.IsSpectator)
		{
			num = rankReport.<WinnerTeamIndex>k__BackingField;
			num2 = rankReport.<WinnerTeamIndex>k__BackingField - 1;
			num3 = ((rankReport.<WinnerTeamIndex>k__BackingField != 1) ? 1 : (1 + 1));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E679E]");
			object obj12 = (nint)0 & (nint)1;
			bool flag5 = obj12 == null;
			object obj13 = !flag5;
			int num4 = 1;
			obj14 = 0;
			num5 = num;
			num6 = num3;
			obj15 = 0;
			team = num2;
			if (obj13 == null)
			{
				goto IL_01bd;
			}
		}
		else
		{
			CardGame cardGame2 = (CardGame)obj;
			bool flag6 = obj == null;
			object obj16 = !flag6;
			if (obj16 == null)
			{
				object obj17 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X0_v175+E4]");
				bool flag7 = (nint)0 == 0;
				object obj19 = !flag7;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj20 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
				obj = cardGame2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			int myTeamIndex2 = cardGame2.MyTeamIndex;
			num2 = myTeamIndex2 - 1;
			num3 = ((myTeamIndex2 != 1) ? 1 : (1 + 1));
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E679E]");
			object obj21 = (nint)0 & (nint)1;
			bool flag8 = obj21 == null;
			int num4 = 1;
			num = myTeamIndex2;
			obj14 = 0;
			if (flag8)
			{
				goto IL_01bd;
			}
			num5 = myTeamIndex2;
			num6 = num3;
			obj15 = 0;
			team = num2;
		}
		goto IL_0bc9;
		IL_01bd:
		num5 = num;
		num6 = num3;
		obj15 = obj14;
		team = num2;
		goto IL_0bc9;
		IL_0bc9:
		KGame kGame2 = (KGame)obj;
		bool flag9 = obj == null;
		object obj22 = !flag9;
		if (obj22 == null)
		{
			object obj23 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v163+E4]");
			bool flag10 = (nint)0 == 0;
			object obj25 = !flag10;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj26 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = kGame2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		bool isSpectator = kGame2.IsSpectator;
		KGame kGame3 = (KGame)obj;
		bool flag11 = obj == null;
		object obj27 = !flag11;
		if (obj27 == null)
		{
			object obj28 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj29 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X0_v149+E4]");
			bool flag12 = (nint)0 == 0;
			object obj30 = !flag12;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj31 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = kGame3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		KPlayer playerByIndex = kGame3.GetPlayerByIndex(num5);
		myAvatar.Initialize(playerByIndex);
		KGame kGame4 = (KGame)obj;
		bool flag13 = obj == null;
		object obj32 = !flag13;
		if (obj32 == null)
		{
			object obj33 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj34 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X0_v135+E4]");
			bool flag14 = (nint)0 == 0;
			object obj35 = !flag14;
			if (obj35 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj36 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = kGame4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		int index = num5 + 2;
		KPlayer playerByIndex2 = kGame4.GetPlayerByIndex(index);
		teammateAvatar.Initialize(playerByIndex2);
		KGame kGame5 = (KGame)obj;
		bool flag15 = obj == null;
		object obj37 = !flag15;
		if (obj37 == null)
		{
			object obj38 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj39 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X0_v121+E4]");
			bool flag16 = (nint)0 == 0;
			object obj40 = !flag16;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj41 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = kGame5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		KPlayer playerByIndex3 = kGame5.GetPlayerByIndex(num6);
		opponentAvatar1.Initialize(playerByIndex3);
		KGame kGame6 = (KGame)obj;
		bool flag17 = obj == null;
		object obj42 = !flag17;
		if (obj42 == null)
		{
			object obj43 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj44 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X0_v107+E4]");
			bool flag18 = (nint)0 == 0;
			object obj45 = !flag18;
			if (obj45 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj46 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = kGame6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		int index2 = num6 + 2;
		KPlayer playerByIndex4 = kGame6.GetPlayerByIndex(index2);
		opponentAvatar2.Initialize(playerByIndex4);
		KGame kGame7 = (KGame)obj;
		bool flag19 = obj == null;
		object obj47 = !flag19;
		if (obj47 == null)
		{
			object obj48 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj49 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X0_v93+E4]");
			bool flag20 = (nint)0 == 0;
			object obj50 = !flag20;
			if (obj50 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj51 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = kGame7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		int num8 = default(int);
		object text3;
		object text4;
		if (kGame7.IsSpectator)
		{
			myTeamArea.color = (Color)0;
			ourScore.color = (Color)0;
			TextMeshProUGUI textMeshProUGUI = ourScore;
			MatchScoresGameEndWidget matchScoresGameEndWidget = default(MatchScoresGameEndWidget);
			int num7 = matchScoresGameEndWidget.teamScore(team);
			string text = num8.ToString();
			textMeshProUGUI.text = text;
			MatchScoresGameEndWidget matchScoresGameEndWidget2 = default(MatchScoresGameEndWidget);
			int num9 = matchScoresGameEndWidget2.teamScore(num6);
			string text2 = num8.ToString();
			theirScore.text = text2;
			text3 = "SubscribeGroup request Error" + 3288;
			text4 = "SubscribeGroup request Error" + 3280;
		}
		else
		{
			CardGame cardGame3 = (CardGame)obj;
			bool flag21 = obj == null;
			object obj52 = !flag21;
			if (obj52 == null)
			{
				object obj53 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj54 = obj53;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X0_v65+E4]");
				bool flag22 = (nint)0 == 0;
				object obj55 = !flag22;
				if (obj55 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj56 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
				obj = cardGame3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			int myTeamIndex3 = cardGame3.MyTeamIndex;
			if (rankReport.<WinnerTeamIndex>k__BackingField == myTeamIndex3)
			{
			}
			if (rankReport.<WinnerTeamIndex>k__BackingField == myTeamIndex3)
			{
			}
			if (rankReport.<WinnerTeamIndex>k__BackingField == myTeamIndex3)
			{
			}
			if (rankReport.<WinnerTeamIndex>k__BackingField == myTeamIndex3)
			{
			}
			myTeamArea.color = (Color)0;
			TextMeshProUGUI textMeshProUGUI2 = ourScore;
			if (rankReport.<WinnerTeamIndex>k__BackingField == myTeamIndex)
			{
			}
			if (rankReport.<WinnerTeamIndex>k__BackingField == myTeamIndex)
			{
			}
			if (rankReport.<WinnerTeamIndex>k__BackingField == myTeamIndex)
			{
			}
			if (rankReport.<WinnerTeamIndex>k__BackingField == myTeamIndex)
			{
			}
			textMeshProUGUI2.color = (Color)0;
			int num10 = myTeamScore;
			string text5 = num8.ToString();
			ourScore.text = text5;
			int num11 = opponentTeamScore;
			string text6 = num8.ToString();
			theirScore.text = text6;
			text3 = "The operation is not allowed on non-connected sockets." + 2808;
			text4 = "Unsupported map type" + 416;
		}
		TextMeshProExtensions.Localize(ourScoreTitle, (string)text4);
		TextMeshProExtensions.Localize(theirScoreTitle, (string)text3);
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
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03d9: Expected O, but got I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0175: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_0409: Expected O, but got I4
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01f6: Expected O, but got I4
		//IL_021f: Expected O, but got I
		//IL_0312: Expected O, but got I
		//IL_0323: Expected I, but got O
		//IL_02b2: Expected O, but got I
		//IL_035f: Expected O, but got I4
		//IL_02ea: Expected O, but got I
		//IL_0428: Expected I, but got O
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_048f: Expected O, but got I
		//IL_04c2: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		Sequence sequence;
		TMP_Text tMP_Text;
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = rankReport;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj4;
			if (obj4 != null)
			{
				object obj6 = this + 32;
				CardGame cardGame = (CardGame)obj6;
				bool flag = obj6 == null;
				object obj7 = !flag;
				if (obj7 == null)
				{
					object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v61+E4]");
					bool flag2 = (nint)0 == 0;
					object obj10 = !flag2;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj11 = (nint)0 + (nint)24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
					obj6 = cardGame;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if ((object)cardGame == null)
					{
						goto IL_036e;
					}
				}
				object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
				int myTeamIndex = cardGame.MyTeamIndex;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v15+E4]");
				bool flag3 = (nint)0 == 0;
				object obj14 = !flag3;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				sequence = DOTween.Sequence();
				Sequence sequence2 = TweenSettingsExtensions.AppendInterval(sequence, preAnimDelay);
				KGame kGame = (KGame)obj6;
				bool flag4 = obj6 == null;
				object obj15 = !flag4;
				if (obj15 == null)
				{
					object obj16 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v46+E4]");
					bool flag5 = (nint)0 == 0;
					object obj18 = !flag5;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj19 = (nint)0 + (nint)24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
					obj6 = kGame;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if ((object)kGame == null)
					{
						goto IL_036e;
					}
				}
				object obj20 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				bool isSpectator = kGame.IsSpectator;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj21;
				TweenCallback tweenCallback = default(TweenCallback);
				if (isSpectator)
				{
					obj21 = (nint)0 + (nint)1176;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v4+34]");
					if ((nint)0 != myTeamIndex)
					{
						object obj22 = (nint)0 + (nint)1192;
						tweenCallback..ctor(obj2, (IntPtr)obj22);
						Sequence sequence3 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback);
						tMP_Text = theirScore;
						bool flag6 = (object)theirScore == null;
						object obj23 = !flag6;
						if (obj23 != null)
						{
							goto IL_02ef;
						}
						goto IL_036e;
					}
					obj21 = (nint)0 + (nint)1184;
				}
				tweenCallback..ctor(obj2, (IntPtr)obj21);
				Sequence sequence4 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback);
				tMP_Text = ourScore;
				if ((object)ourScore != null)
				{
					goto IL_02ef;
				}
			}
		}
		goto IL_036e;
		IL_02ef:
		Transform target = tMP_Text.transform;
		object obj24 = typeof(UsageHint) + 816;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v19+B8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v20+C]");
		float duration = 0f * 0f;
		float elasticity = default(float);
		Tweener t = ShortcutExtensions.DOPunchScale(target, (Vector3)10, duration, 0, elasticity);
		Sequence sequence5 = TweenSettingsExtensions.Append(sequence, t);
		Sequence sequence6 = TweenSettingsExtensions.AppendInterval(sequence, postAnimDelay);
		return sequence;
		IL_036e:
		return (Sequence)(object)new NullReferenceException();
	}

	public override bool ShouldShow(CardGameEndScores rankReport)
	{
		//IL_00b7: Expected I4, but got O
		//IL_004b: Expected I4, but got O
		if (rankReport != null)
		{
			TournamentEndGameReport <tournamentReport>k__BackingField = rankReport.<tournamentReport>k__BackingField;
			bool flag = rankReport.<tournamentReport>k__BackingField == null;
			bool result = (byte)(int)rankReport.<tournamentReport>k__BackingField != 0;
			if (!flag)
			{
				if (!<tournamentReport>k__BackingField.isFinalMatch)
				{
					return true;
				}
				bool isMatchOver = rankReport.<tournamentReport>k__BackingField.IsMatchOver;
				result = (byte)((isMatchOver ? 1u : 0u) ^ 1u) != 0;
			}
			return result;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
