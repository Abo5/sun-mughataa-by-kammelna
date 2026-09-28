using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities.Data;

public class JackarooEndScores : CardGameEndScores
{
	public const string TEAM1_PLAYER1_SCORE = "ts1p1";

	public const string TEAM1_PLAYER2_SCORE = "ts1p2";

	public const string TEAM2_PLAYER1_SCORE = "ts2p1";

	public const string TEAM2_PLAYER2_SCORE = "ts2p2";

	private int <Team1Player1MarbleCount>k__BackingField;

	private int <Team1Player2MarbleCount>k__BackingField;

	private int <Team2Player1MarbleCount>k__BackingField;

	private int <Team2Player2MarbleCount>k__BackingField;

	public int Team1Player1MarbleCount
	{
		get
		{
			return <Team1Player1MarbleCount>k__BackingField;
		}
		private set
		{
			<Team1Player1MarbleCount>k__BackingField = value;
		}
	}

	public int Team1Player2MarbleCount
	{
		get
		{
			return <Team1Player2MarbleCount>k__BackingField;
		}
		private set
		{
			<Team1Player2MarbleCount>k__BackingField = value;
		}
	}

	public int Team2Player1MarbleCount
	{
		get
		{
			return <Team2Player1MarbleCount>k__BackingField;
		}
		private set
		{
			<Team2Player1MarbleCount>k__BackingField = value;
		}
	}

	public int Team2Player2MarbleCount
	{
		get
		{
			return <Team2Player2MarbleCount>k__BackingField;
		}
		private set
		{
			<Team2Player2MarbleCount>k__BackingField = value;
		}
	}

	public JackarooEndScores(ISFSObject data, GameType gameType)
	{
		//IL_000b: Expected I, but got O
		//IL_001b: Expected O, but got I
		//IL_002b: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X8_v1 (Il2CppClass<JackarooEndScores>)+178]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v21 @ X8_v1 (Il2CppClass<JackarooEndScores>)+180]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v22 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected override void SetCardGameEndScores(ISFSObject data, GameType gameType)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0152: Expected I, but got O
		//IL_0162: Expected O, but got I
		//IL_020c: Expected O, but got I4
		//IL_027f: Expected I, but got O
		//IL_028f: Expected O, but got I
		//IL_019d: Expected O, but got I
		//IL_0339: Expected O, but got I4
		//IL_02ca: Expected O, but got I
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected O, but got Unknown
		//IL_064c: Expected I, but got O
		//IL_065c: Expected O, but got I
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0367: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_03b1: Expected O, but got I
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_0433: Expected I, but got O
		//IL_0443: Expected O, but got I
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_0520: Unknown result type (might be due to invalid IL or missing references)
		//IL_0525: Expected O, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_0557: Expected O, but got I4
		//IL_04f0: Expected O, but got I
		//IL_0500: Expected O, but got I
		//IL_047e: Expected O, but got I
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected O, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_058f: Expected O, but got Unknown
		//IL_05b3: Expected O, but got I4
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_049f: Expected O, but got Unknown
		object varName = "tournament_participate_warning_body_with_tickets_warning_daily" + 744;
		object varName2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 752;
		object varName3 = "tournament_participate_warning_body_with_tickets_warning_daily" + 768;
		object varName4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 776;
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 328;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 224;
		GameType gameType2 = default(GameType);
		base.SetCardGameEndScores(data, gameType2);
		int num = SFSExtensions.Get(data, (string)varName, 0);
		<Team1Player1MarbleCount>k__BackingField = num;
		int num2 = SFSExtensions.Get(data, (string)varName2, 0);
		<Team1Player2MarbleCount>k__BackingField = num2;
		int num3 = SFSExtensions.Get(data, (string)varName3, 0);
		<Team2Player1MarbleCount>k__BackingField = num3;
		int num4 = SFSExtensions.Get(data, (string)varName4, 0);
		<Team2Player2MarbleCount>k__BackingField = num4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CardGameStatistics cardGameStatistics = default(CardGameStatistics);
		cardGameStatistics..ctor();
		object obj3 = this + 72;
		obj3 = cardGameStatistics;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CardGameHighlights cardGameHighlights = default(CardGameHighlights);
		cardGameHighlights..ctor();
		object obj4 = this + 80;
		obj4 = cardGameHighlights;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = typeof(System.IOAsyncCallback) + 976;
		object obj6 = "getSecondRescanTask" + 2080;
		nint num5 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01de;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X10_v26-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj8 += 16;
			obj7--;
			if ((nint)obj7 != 1)
			{
				continue;
			}
			goto IL_01de;
		}
		object obj9 = obj8 + 1;
		object obj10 = num5 + obj9;
		object obj11 = obj10 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v403 @ X0_v55] (should have been resolved before IL gen)");
		object obj12 = default(object);
		if (obj12 != null)
		{
			goto IL_026f;
		}
		goto IL_0635;
		IL_0384:
		object obj14;
		object obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v466 @ X8_v21+178] (should have been resolved before IL gen)");
		goto IL_0635;
		IL_0635:
		object obj15 = "getSecondRescanTask" + 1568;
		nint num6 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03f2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj17 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X10_v14-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj17 += 16;
			obj16--;
			if ((nint)obj16 != 1)
			{
				continue;
			}
			goto IL_03f2;
		}
		goto IL_050a;
		IL_0423:
		object obj18 = obj4;
		nint num7 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04bf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X10_v9-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj20 += 16;
			obj19--;
			if ((nint)obj19 != 1)
			{
				continue;
			}
			goto IL_04bf;
		}
		object obj21 = obj20 + 29;
		object obj22 = num7 + obj21;
		object obj23 = obj22 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v633 @ X0_v30] (should have been resolved before IL gen)");
		bool flag = obj18 == null;
		object obj24 = !flag;
		if (obj24 != null)
		{
			goto IL_04d8;
		}
		goto IL_05c1;
		IL_050a:
		object obj25 = obj17 + 1;
		object obj26 = num6 + obj25;
		object obj27 = obj26 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v573 @ X0_v37] (should have been resolved before IL gen)");
		object obj28 = default(object);
		bool flag2 = obj28 == null;
		object obj29 = !flag2;
		if (obj29 == null)
		{
			return;
		}
		goto IL_0423;
		IL_01de:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v281 @ X0_v52] (should have been resolved before IL gen)");
		object obj30 = default(object);
		bool flag3 = obj30 == null;
		object obj31 = !flag3;
		if (obj31 != null)
		{
			goto IL_026f;
		}
		goto IL_0635;
		IL_026f:
		obj14 = obj3;
		nint num8 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_030b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj33 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X10_v21-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj33 += 16;
			obj32--;
			if ((nint)obj32 != 1)
			{
				continue;
			}
			goto IL_030b;
		}
		object obj34 = obj33 + 29;
		object obj35 = num8 + obj34;
		object obj36 = obj35 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v561 @ X0_v48] (should have been resolved before IL gen)");
		goto IL_0384;
		IL_05c1:
		throw new NullReferenceException();
		IL_04d8:
		object obj37 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v11+178]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v11+180]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v350 @ X3_v6 (should have been resolved before IL gen)");
		goto IL_050a;
		IL_03f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v517 @ X0_v34] (should have been resolved before IL gen)");
		object obj40 = default(object);
		if (obj40 != null)
		{
			goto IL_0423;
		}
		return;
		IL_04bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v617 @ X0_v27] (should have been resolved before IL gen)");
		goto IL_04d8;
		IL_030b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v488 @ X0_v45] (should have been resolved before IL gen)");
		bool flag4 = obj3 == null;
		object obj41 = !flag4;
		if (obj41 != null)
		{
			goto IL_0384;
		}
		goto IL_05c1;
	}
}
