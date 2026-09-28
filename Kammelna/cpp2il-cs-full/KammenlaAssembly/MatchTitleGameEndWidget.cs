using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server.Models.Clans;
using Server.Models;
using TMPro;
using Unity.Properties;
using UnityEngine;

public class MatchTitleGameEndWidget : GameEndWidget
{
	private TextMeshProUGUI text;

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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A8]");
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
		Populate(rankReport);
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
	}

	public override void Populate(CardGameEndScores rankReport)
	{
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		//IL_04b5: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_04e5: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_00f6: Expected O, but got I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0152: Expected O, but got I4
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01fc: Expected O, but got I
		//IL_017b: Expected O, but got I
		//IL_02a3: Expected O, but got I
		//IL_02cd: Expected O, but got I4
		//IL_027e: Expected O, but got I4
		//IL_0225: Expected O, but got I
		//IL_0331: Expected O, but got I
		//IL_03e2: Expected O, but got I4
		//IL_039f: Expected O, but got I4
		//IL_042d: Expected O, but got I4
		object obj = this + 32;
		KGame kGame = (KGame)obj;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v67+E4]");
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
		}
		if (kGame.IsSpectator)
		{
			bool isMatchOver = rankReport.<tournamentReport>k__BackingField.IsMatchOver;
			TournamentEndGameReport <tournamentReport>k__BackingField = rankReport.<tournamentReport>k__BackingField;
			LocalizableText spectatorText = ((MatchTitleGameEndWidget)isMatchOver).GetSpectatorText(rankReport.<WinnerTeamIndex>k__BackingField, isMatchOver, <tournamentReport>k__BackingField.isFinalMatch);
			TextMeshProExtensions.Localize(this.text, spectatorText);
			return;
		}
		CardGame cardGame = (CardGame)obj;
		bool flag3 = obj == null;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v49+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj11 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = cardGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		int myTeamIndex = cardGame.MyTeamIndex;
		bool isMatchOver2 = rankReport.<tournamentReport>k__BackingField.IsMatchOver;
		TournamentEndGameReport <tournamentReport>k__BackingField2 = rankReport.<tournamentReport>k__BackingField;
		object obj12 = typeof(Queue<string>) + 872;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A8]");
		object obj13 = (nint)0 & (nint)1;
		object obj16;
		object obj14;
		if (obj13 != null)
		{
			obj14 = (nint)0 + (nint)2248;
			object obj15 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v34+E4]");
			bool flag5 = (nint)0 == 0;
			obj16 = obj14;
			if (!flag5)
			{
				goto IL_025a;
			}
		}
		else
		{
			_ = 1;
			obj14 = (nint)0 + (nint)2248;
			object obj15 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v34+E4]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			obj16 = obj14;
			if (obj17 != null)
			{
				goto IL_025a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj14 = obj16;
		goto IL_0309;
		IL_037b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
		bool flag7 = (object)tournamentMatchInfo == null;
		object obj18 = !flag7;
		if (obj18 != null)
		{
			goto IL_0409;
		}
		goto IL_0481;
		IL_0481:
		throw new NullReferenceException();
		IL_0309:
		TournamentMatchInfo tournamentMatchInfo2 = default(TournamentMatchInfo);
		TournamentData tournament = tournamentMatchInfo2.Tournament;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67A8]");
		object obj19 = (nint)0 & (nint)1;
		if (obj19 != null)
		{
			object obj20 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v19+E4]");
			if ((nint)0 != 0)
			{
				goto IL_037b;
			}
		}
		else
		{
			_ = 1;
			object obj20 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v19+E4]");
			bool flag8 = (nint)0 == 0;
			object obj21 = !flag8;
			if (obj21 != null)
			{
				goto IL_037b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0409;
		IL_025a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag9 = (object)tournamentMatchInfo2 == null;
		object obj22 = !flag9;
		if (obj22 != null)
		{
			goto IL_0309;
		}
		goto IL_0481;
		IL_0409:
		TournamentData tournament2 = tournamentMatchInfo.Tournament;
		object obj23 = rankReport.<WinnerTeamIndex>k__BackingField - myTeamIndex;
		bool isWin = obj23 == null;
		string text = ((MatchTitleGameEndWidget)(object)tournament2).GetText(isWin, isMatchOver2, <tournamentReport>k__BackingField2.isFinalMatch, tournament.<Type>k__BackingField, tournament2.<SubType>k__BackingField);
		TextMeshProExtensions.Localize(this.text, text);
	}

	public override Sequence AnimatedPopulate(CardGameEndScores rankReport)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E677D]");
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
		return true;
	}

	private unsafe string GetText(bool isWin, bool isOver, bool isFinal, TournamentType tType, TournamentSubType? stType = null)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_01f4: Expected O, but got I4
		//IL_0225: Expected O, but got I4
		//IL_0256: Expected O, but got I4
		//IL_0277: Expected O, but got Ref
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_011b: Expected O, but got Ref
		object obj = "Unsupported map type" + 3432;
		object obj2 = "LAK" + 336;
		object obj3 = "_InputUv1BufferOffset" + 896;
		object obj4 = "_InputUv1BufferOffset" + 816;
		object obj5 = "[{0}]:{1}" + 3136;
		object obj6 = "_InputUv1BufferOffset" + 808;
		bool flag = !isWin;
		object obj7 = !flag;
		object obj8 = ~obj7;
		object obj9 = ((obj8 != null) ? obj2 : obj);
		bool flag2 = !isOver;
		object obj10 = !flag2;
		object obj11 = ~obj10;
		object obj12 = ((obj11 != null) ? obj4 : obj3);
		bool flag3 = !isFinal;
		object obj13 = !flag3;
		object obj14 = ~obj13;
		object obj15 = ((obj14 != null) ? obj6 : obj5);
		object obj16 = default(object);
		string text = ((Enum)(&obj16)).ToString();
		if (text != null)
		{
			object obj17 = "[{0}]:{1}" + 912;
			string text2 = text.ToUpper();
			string text3 = (string)obj17 + text2;
			object obj18 = (??)stType & 1;
			bool flag4 = obj18 == null;
			string text4 = null;
			if (!flag4)
			{
				string text5 = ((Enum)(&obj16)).ToString();
				if (text5 == null)
				{
					goto IL_01cc;
				}
				string text6 = text5.ToUpper();
				text4 = text6;
			}
			object obj19 = "SubscribeGroup request Error" + 2328;
			string text7 = (string)obj17 + text4;
			string text8 = (string)obj19 + (string)obj9 + (string)obj12;
			if (isOver)
			{
				text8 += (string)obj15;
				if (isFinal)
				{
					text8 += text3;
					if (tType == TournamentType.OfficialMonthly)
					{
						text8 += text7;
					}
				}
			}
			return text8;
		}
		goto IL_01cc;
		IL_01cc:
		return (string)(object)new NullReferenceException();
	}

	private LocalizableText GetSpectatorText(int winner, bool isOver, bool isFinal)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_02c3: Expected O, but got I4
		//IL_02f4: Expected O, but got I4
		//IL_00d1: Expected O, but got I4
		//IL_00e7: Expected I, but got O
		//IL_00f7: Expected O, but got I
		//IL_0120: Expected O, but got I
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_01f5: Expected O, but got I8
		//IL_019a: Expected I, but got O
		//IL_01aa: Expected O, but got I
		//IL_01d3: Expected O, but got I
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		object obj = "SubscribeGroup request Error" + 2336;
		object obj2 = "SubscribeGroup request Error" + 3280;
		object obj3 = "SubscribeGroup request Error" + 3288;
		object obj4 = "ThisIsFakeReceiptData" + 1224;
		object obj5 = "m_StencilDeferredPS" + 616;
		object obj6 = "rightCtrl" + 536;
		object obj7 = typeof(TypeConverter<ushort, char>) + 3400;
		object obj8 = ((winner != 1) ? obj3 : obj2);
		bool flag = !isFinal;
		object obj9 = !flag;
		object obj10 = ~obj9;
		object obj11 = ((obj10 != null) ? obj5 : obj4);
		bool flag2 = !isOver;
		object obj12 = !flag2;
		object obj13 = ~obj12;
		if (obj13 != null)
		{
			obj11 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		if (array != null)
		{
			bool flag3 = obj8 == null;
			object obj14 = 2;
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			object obj15;
			if (!flag3)
			{
				nint num = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag4 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v14 (Il2CppClass<System.Object[]>)+40]");
				obj15 = 0;
				if (flag4)
				{
					goto IL_0263;
				}
			}
			if (array.Length != 0)
			{
				object obj16 = array + 32;
				obj16 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag5 = obj11 == null;
				obj14 = obj8;
				if (!flag5)
				{
					nint num2 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
					obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag6 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v13 (Il2CppClass<System.Object[]>)+40]");
					obj15 = 0;
					if (flag6)
					{
						goto IL_0263;
					}
				}
				object obj17 = array.Length & 0xFFFFFFFEL;
				if (obj17 != null)
				{
					object obj18 = array + 40;
					obj18 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return TextMeshProExtensions.LocalizeArguments((string)obj, array);
				}
			}
			ex = new IndexOutOfRangeException();
			obj15 = obj14;
			goto IL_0263;
		}
		goto IL_027b;
		IL_027b:
		return (LocalizableText)(object)new NullReferenceException();
		IL_0263:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_027b;
	}
}
