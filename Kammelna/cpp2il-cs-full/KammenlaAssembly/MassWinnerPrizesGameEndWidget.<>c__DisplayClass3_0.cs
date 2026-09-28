using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using Server.Models;
using UnityEngine;

public class MassWinnerPrizesGameEndWidget : GameEndWidget
{
	private sealed class <>c__DisplayClass3_0
	{
		public MassWinnerPrizesGameEndWidget <>4__this;

		public bool won;

		internal void <PrepareAnimation>b__0(MassEventModel m)
		{
			GameObject gameObject = <>4__this.gameObject;
			gameObject.SetActive(value: true);
			MassWinnerPrizesGameEndWidget massWinnerPrizesGameEndWidget = <>4__this;
			int place = (won ? 1 : (1 + 1));
			massWinnerPrizesGameEndWidget.prizeInitializer.Populate(place, m);
		}
	}

	private MassTournamentPrizeStrip prizeInitializer;

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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A2]");
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
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02f8: Expected O, but got I4
		//IL_00e7: Expected O, but got I4
		//IL_0104: Expected O, but got I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_012e: Expected O, but got I
		//IL_01d5: Expected O, but got I
		//IL_01ff: Expected O, but got I4
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_007e: Expected O, but got I4
		//IL_01b0: Expected O, but got I4
		//IL_0157: Expected O, but got I
		//IL_00a7: Expected O, but got I
		//IL_024c: Expected O, but got I
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_026c: Expected O, but got I
		//IL_0299: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = this + 32;
		CardGame cardGame = (CardGame)obj4;
		bool flag = obj4 == null;
		object obj5 = !flag;
		if (obj5 == null)
		{
			object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X0_v35+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj9 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj4 = cardGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		int myTeamIndex = cardGame.MyTeamIndex;
		object obj10 = rankReport.<WinnerTeamIndex>k__BackingField - myTeamIndex;
		bool flag3 = obj10 == null;
		object obj11 = 152985600;
		object obj12 = typeof(Queue<string>) + 872;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A2]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			object obj14 = (nint)0 + (nint)2248;
			object obj15 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v20+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = obj14;
			if (!flag4)
			{
				goto IL_018c;
			}
		}
		else
		{
			_ = 1;
			object obj14 = (nint)0 + (nint)2248;
			object obj15 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v20+E4]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			object obj16 = obj14;
			if (obj17 != null)
			{
				goto IL_018c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_022e;
		IL_022e:
		TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
		TournamentData tournament = tournamentMatchInfo.Tournament;
		object obj18 = (nint)0 + (nint)3232;
		object obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2616;
		object obj20 = (nint)0 + (nint)1056;
		long? num = default(long?);
		long value = num.Value;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj20);
		MassTournamentManager.GetMassEvent(value, action);
		return;
		IL_018c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag6 = (object)tournamentMatchInfo == null;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_022e;
	}

	public override void Populate(CardGameEndScores rankReport)
	{
	}

	public override Sequence AnimatedPopulate(CardGameEndScores rankReport)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E677C]");
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
		//IL_0261: Expected I4, but got O
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_02ab: Expected O, but got I4
		//IL_00e3: Expected O, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0055: Expected O, but got I4
		//IL_007e: Expected O, but got I
		//IL_016c: Expected O, but got I4
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		if (rankReport != null)
		{
			TournamentEndGameReport <tournamentReport>k__BackingField = rankReport.<tournamentReport>k__BackingField;
			object obj = this + 32;
			KGame kGame = (KGame)obj;
			bool flag = obj == null;
			object obj2 = !flag;
			if (obj2 == null)
			{
				object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v17+E4]");
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
					goto IL_0253;
				}
			}
			bool isSpectator = kGame.IsSpectator;
			bool flag3 = !isSpectator;
			object obj7 = !flag3;
			if (obj7 == null && rankReport.<tournamentReport>k__BackingField != null && <tournamentReport>k__BackingField.isFinalMatch)
			{
				bool isMatchOver = rankReport.<tournamentReport>k__BackingField.IsMatchOver;
				if (isMatchOver)
				{
					TournamentMatchInfo tournamentMatchInfo = ((MassWinnerPrizesGameEndWidget)isMatchOver).matchInfo;
					if ((object)tournamentMatchInfo != null)
					{
						TournamentData tournament = tournamentMatchInfo.Tournament;
						if (tournament != null)
						{
							object obj8 = (??)tournament.<ParentMassEventId>k__BackingField & 1;
							if (obj8 == null)
							{
								goto IL_024d;
							}
							TournamentMatchInfo tournamentMatchInfo2 = ((MassWinnerPrizesGameEndWidget)(object)tournament).matchInfo;
							if ((object)tournamentMatchInfo2 != null)
							{
								TournamentData tournament2 = tournamentMatchInfo2.Tournament;
								if (tournament2 != null)
								{
									return tournament2.IsMassFinal;
								}
							}
						}
					}
					goto IL_0253;
				}
			}
			goto IL_024d;
		}
		goto IL_0253;
		IL_0253:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_024d:
		return false;
	}
}
