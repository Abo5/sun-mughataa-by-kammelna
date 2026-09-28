using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class TextTournamentMatchScores : BaseTournamentMatchScores
{
	private TextMeshProUGUI ourScoreText;

	private TextMeshProUGUI theirScoreText;

	private Color defaultColor;

	private Color winingColor;

	private Color losingColor;

	protected override void Init()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_006f: Expected O, but got I
		//IL_0089: Expected O, but got I
		//IL_0096: Expected O, but got I
		//IL_00a3: Expected I, but got O
		//IL_00b3: Expected O, but got I
		//IL_00c3: Expected O, but got I
		object text = ", stale={0}" + 3424;
		TextMeshProUGUI textMeshProUGUI = ourScoreText;
		theirScoreText.text = (string)text;
		textMeshProUGUI.text = (string)text;
		TextMeshProUGUI textMeshProUGUI2 = ourScoreText;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TextTournamentMatchScores)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TextTournamentMatchScores)+44]");
		object obj2 = 0;
		Color color = defaultColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TextTournamentMatchScores)+3C]");
		object obj3 = 0;
		theirScoreText.color = (Color)0;
		nint num = (nint)textMeshProUGUI2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v9 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v9 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v125 @ X2_v4 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected override void InitNotTournament()
	{
		GameObject gameObject = ourScoreText.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = theirScoreText.gameObject;
		gameObject2.SetActive(value: false);
	}

	protected override void OnScoresUpdated()
	{
		//IL_0059: Expected I, but got O
		//IL_0078: Expected O, but got I
		//IL_008a: Expected O, but got I
		//IL_00b8: Expected O, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00f0: Expected O, but got I
		//IL_0197: Expected O, but got I
		//IL_01c1: Expected O, but got I4
		//IL_0172: Expected O, but got I4
		//IL_0119: Expected O, but got I
		//IL_02ce: Expected O, but got I
		//IL_02de: Expected O, but got I
		//IL_02ee: Expected O, but got I
		//IL_0301: Expected O, but got I4
		//IL_04f7: Expected O, but got I
		//IL_0414: Expected O, but got I4
		//IL_03d1: Expected O, but got I4
		//IL_032e: Expected O, but got I
		//IL_033e: Expected O, but got I
		//IL_0358: Expected O, but got I
		//IL_0360: Expected I, but got O
		//IL_0370: Expected O, but got I
		//IL_037b: Expected O, but got I
		//IL_025e: Expected O, but got I
		//IL_026e: Expected O, but got I
		//IL_027e: Expected O, but got I
		//IL_0291: Expected O, but got I4
		//IL_04d4: Expected O, but got I
		int ourScore = base.OurScore;
		int num = default(int);
		string text = num.ToString();
		ourScoreText.text = text;
		TextMeshProUGUI textMeshProUGUI = theirScoreText;
		int theirScore = base.TheirScore;
		string text2 = num.ToString();
		nint num2 = (nint)textMeshProUGUI;
		textMeshProUGUI.text = text2;
		theirScoreText.color = (Color)0;
		ourScoreText.color = (Color)0;
		bool isSpectator = game.IsSpectator;
		bool flag = !isSpectator;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(Queue<string>) + 872;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CF8]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2248;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v55+E4]");
			bool flag2 = (nint)0 == 0;
			obj6 = obj4;
			if (!flag2)
			{
				goto IL_014e;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2248;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X0_v55+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_014e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_01fd;
		IL_04d9:
		throw new NullReferenceException();
		IL_04e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CF8]");
		object obj8 = (nint)0 & (nint)1;
		if (obj8 != null)
		{
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v34+E4]");
			if ((nint)0 != 0)
			{
				goto IL_03ad;
			}
		}
		else
		{
			_ = 1;
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v34+E4]");
			bool flag4 = (nint)0 == 0;
			object obj10 = !flag4;
			if (obj10 != null)
			{
				goto IL_03ad;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_043b;
		IL_03ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj11 = default(object);
		bool flag5 = obj11 == null;
		object obj12 = !flag5;
		if (obj12 != null)
		{
			goto IL_043b;
		}
		goto IL_04d9;
		IL_030f:
		TextMeshProUGUI textMeshProUGUI2 = ourScoreText;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TextTournamentMatchScores)+50]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TextTournamentMatchScores)+54]");
		object obj14 = 0;
		Color color = winingColor;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TextTournamentMatchScores)+4C]");
		object obj15 = 0;
		nint num3 = (nint)textMeshProUGUI2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v20 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
		object obj16 = 0;
		textMeshProUGUI2.color = (Color)0;
		goto IL_04e1;
		IL_014e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj17 = default(object);
		bool flag6 = obj17 == null;
		object obj18 = !flag6;
		if (obj18 != null)
		{
			goto IL_01fd;
		}
		goto IL_04d9;
		IL_01fd:
		if (game.IsSpectator)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v21+40]");
			if ((nint)0 == 1)
			{
				goto IL_030f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TextTournamentMatchScores)+44]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TextTournamentMatchScores)+40]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TextTournamentMatchScores)+3C]");
			obj15 = 0;
			color = defaultColor;
			obj16 = 0;
		}
		else
		{
			int myTeamIndex = game.MyTeamIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v21+40]");
			bool flag7 = (nint)0 != myTeamIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TextTournamentMatchScores)+44]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TextTournamentMatchScores)+40]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TextTournamentMatchScores)+3C]");
			obj15 = 0;
			color = defaultColor;
			obj16 = 0;
			if (!flag7)
			{
				goto IL_030f;
			}
		}
		goto IL_04e1;
		IL_043b:
		if (game.IsSpectator)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v25+40]");
			if ((nint)0 == 1)
			{
				return;
			}
		}
		else
		{
			int myTeamIndex2 = game.MyTeamIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v25+40]");
			if ((nint)0 == myTeamIndex2)
			{
				return;
			}
		}
		theirScoreText.color = (Color)0;
	}

	public TextTournamentMatchScores()
	{
		//IL_0012: Expected O, but got I
		//IL_0024: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252DE0]");
		winingColor = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252DF0]");
		losingColor = (Color)0;
		((MonoBehaviour)this)..ctor();
	}
}
