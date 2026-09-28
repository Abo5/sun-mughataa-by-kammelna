using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using TMPro;
using UnityEngine;

public class TournamentInfoGameEndWidget : GameEndWidget
{
	private TextMeshProUGUI tournamentName;

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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6847]");
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
		//IL_0016: Expected O, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0144: Expected O, but got I
		//IL_015e: Expected O, but got I4
		//IL_0167: Expected O, but got I4
		//IL_0178: Expected O, but got I4
		//IL_00a0: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0075: Expected O, but got I4
		//IL_0086: Expected O, but got I4
		//IL_0198: Expected O, but got I
		//IL_01c2: Expected O, but got I4
		//IL_0101: Expected O, but got I4
		//IL_0266: Expected O, but got I
		//IL_0317: Expected O, but got I4
		//IL_02d4: Expected O, but got I4
		//IL_0391: Expected O, but got I
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a5: Expected O, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03c0: Expected O, but got I
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_0420: Expected O, but got I4
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_0544: Expected O, but got I4
		//IL_055a: Expected O, but got I
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected O, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c6: Expected O, but got Unknown
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected O, but got Unknown
		//IL_0610: Expected O, but got I4
		//IL_0656: Expected O, but got I4
		//IL_0666: Expected O, but got I4
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected O, but got Unknown
		//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a7: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6848]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(Queue<string>) + 872;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6847]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			DateTime? dateTime = (DateTime?)(object)0;
			obj4 = obj2;
			dateTime = (DateTime?)(object)0;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(Queue<string>) + 872;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6847]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			DateTime? dateTime = (DateTime?)(object)0;
			obj4 = obj2;
			dateTime = (DateTime?)(object)0;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		_ = 1;
		object obj7 = (nint)0 + (nint)2248;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v59+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj2 = obj4;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00dd;
		}
		goto IL_01e0;
		IL_035b:
		TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
		TournamentData tournament = tournamentMatchInfo.Tournament;
		TournamentData tournament2;
		if (tournament != null)
		{
			object obj11 = (nint)0 + (nint)2264;
			object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object input = "ThisIsFakeReceiptData" + 1320;
			object obj13 = (nint)0 + (nint)3072;
			object input2 = "ThisIsFakeReceiptData" + 1256;
			object obj14 = typeof(SqlSingle[]) + 32;
			DateTime? dateTime = tournament.<StartingTime>k__BackingField;
			object obj15 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X0_v10+E4]");
			bool flag4 = (nint)0 == 0;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = LocalizationUtil.Localize((string)input);
			string input3 = text + (string)obj13 + tournament2.<Name>k__BackingField;
			string text2 = LocalizationUtil.FixArabic(input3);
			string text3 = LocalizationUtil.LocalizeAndFix((string)input2);
			string input4 = dateTime.ToString();
			string value = LocalizationUtil.FixArabic(input4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			string[] array = default(string[]);
			if (array != null)
			{
				object obj17 = array + 32;
				obj17 = text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj18 = "1.2.840.113549.1.12.1.5" + 3472;
				object obj19 = array + 40;
				obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X23_v8-10]");
				bool flag5 = (nint)0 < (nint)2;
				object obj20 = !flag5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X23_v8-10]");
				object obj21 = -2;
				bool flag6 = obj21 == null;
				object obj22 = ~obj20;
				object obj23 = obj22 | flag6;
				if (obj23 == null)
				{
					object obj24 = array + 48;
					obj24 = text3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj25 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
					object obj26 = array + 56;
					obj26 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj27 = obj25;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v32+E4]");
					bool flag7 = (nint)0 == 0;
					object obj28 = !flag7;
					if (obj28 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					string text4 = StringsExtensions.Reverse(value);
					bool flag8 = array.Length < 4;
					object obj29 = !flag8;
					object obj30 = array.Length - 4;
					bool flag9 = obj30 == null;
					object obj31 = ~obj29;
					object obj32 = obj31 | flag9;
					if (obj32 == null)
					{
						object obj33 = array + 64;
						obj33 = text4;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						string text5 = string.Concat(array);
						TextMeshProExtensions.FixArabic(tournamentName, text5);
						return;
					}
				}
				goto IL_06e9;
			}
		}
		goto IL_06db;
		IL_06db:
		NullReferenceException ex = new NullReferenceException();
		goto IL_06e9;
		IL_06e9:
		throw new IndexOutOfRangeException();
		IL_0094:
		obj7 = (nint)0 + (nint)2248;
		obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v59+E4]");
		bool flag10 = (nint)0 == 0;
		obj10 = obj7;
		obj4 = obj2;
		if (!flag10)
		{
			goto IL_00dd;
		}
		goto IL_01e0;
		IL_01e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		TournamentMatchInfo tournamentMatchInfo2 = default(TournamentMatchInfo);
		bool flag11 = (object)tournamentMatchInfo2 == null;
		obj7 = obj10;
		obj2 = obj4;
		if (!flag11)
		{
			goto IL_0226;
		}
		goto IL_06db;
		IL_00dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag12 = (object)tournamentMatchInfo2 == null;
		object obj34 = !flag12;
		if (obj34 != null)
		{
			goto IL_0226;
		}
		goto IL_06db;
		IL_0226:
		tournament2 = tournamentMatchInfo2.Tournament;
		if (tournament2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6847]");
			object obj35 = (nint)0 & (nint)1;
			if (obj35 != null)
			{
				object obj36 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v44+E4]");
				if ((nint)0 != 0)
				{
					goto IL_02b0;
				}
			}
			else
			{
				_ = 1;
				object obj36 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X0_v44+E4]");
				bool flag13 = (nint)0 == 0;
				object obj37 = !flag13;
				if (obj37 != null)
				{
					goto IL_02b0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)tournamentMatchInfo != null)
			{
				goto IL_035b;
			}
		}
		goto IL_06db;
		IL_02b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag14 = (object)tournamentMatchInfo == null;
		object obj38 = !flag14;
		if (obj38 != null)
		{
			goto IL_035b;
		}
		goto IL_06db;
	}

	public override Sequence AnimatedPopulate(CardGameEndScores rankReport)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67C8]");
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
		//IL_0171: Expected I4, but got O
		//IL_00b8: Expected O, but got I4
		if (rankReport != null)
		{
			if (rankReport.<tournamentReport>k__BackingField != null && !rankReport.<tournamentReport>k__BackingField.IsMatchOver)
			{
				return false;
			}
			CardGame cardGame = base.game;
			if ((object)cardGame != null)
			{
				bool isSpectator = cardGame.IsSpectator;
				bool flag = !isSpectator;
				object obj = !flag;
				if (obj == null)
				{
					CardGame cardGame2 = base.game;
					if ((object)cardGame2 == null)
					{
						goto IL_0163;
					}
					int myTeamIndex = cardGame2.MyTeamIndex;
					if (rankReport.<WinnerTeamIndex>k__BackingField != myTeamIndex)
					{
						return true;
					}
				}
				TournamentEndGameReport <tournamentReport>k__BackingField = rankReport.<tournamentReport>k__BackingField;
				if (rankReport.<tournamentReport>k__BackingField != null)
				{
					return <tournamentReport>k__BackingField.isFinalMatch;
				}
			}
		}
		goto IL_0163;
		IL_0163:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
