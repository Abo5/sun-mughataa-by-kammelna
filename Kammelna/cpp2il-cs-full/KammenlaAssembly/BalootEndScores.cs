using System;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;
using Unity.Services.Authentication.Shared;

public class BalootEndScores : CardGameEndScores
{
	public BalootEndScores(ISFSObject data, GameType gameType)
	{
		//IL_0028: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069DA8]");
		base.<PlayStylePerformance>k__BackingField = PlayerPerformance.Weak;
		base.<OverallPerformance>k__BackingField = PlayerPerformance.Good;
		((object)this)..ctor();
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v24 @ X8_v3 (Il2CppClass<BalootEndScores>)+178] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected override void SetCardGameEndScores(ISFSObject data, GameType gameType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00af: Expected I, but got O
		//IL_00bf: Expected O, but got I
		//IL_0169: Expected O, but got I4
		//IL_01dc: Expected I, but got O
		//IL_01ec: Expected O, but got I
		//IL_00fa: Expected O, but got I
		//IL_0296: Expected O, but got I4
		//IL_0227: Expected O, but got I
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		//IL_0586: Expected I, but got O
		//IL_0596: Expected O, but got I
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_030e: Expected O, but got I
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0390: Expected I, but got O
		//IL_03a0: Expected O, but got I
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected O, but got Unknown
		//IL_04b4: Expected O, but got I4
		//IL_044d: Expected O, but got I
		//IL_045d: Expected O, but got I
		//IL_03db: Expected O, but got I
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0321: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected O, but got Unknown
		//IL_0510: Expected O, but got I4
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2080;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2000;
		GameType gameType2 = default(GameType);
		base.SetCardGameEndScores(data, gameType2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = this + 72;
		obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = default(object);
		obj5..ctor();
		object obj6 = this + 80;
		obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = typeof(System.IOAsyncCallback) + 976;
		object obj8 = "getSecondRescanTask" + 2080;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_013b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X10_v26-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_013b;
		}
		object obj11 = obj10 + 1;
		object obj12 = num + obj11;
		object obj13 = obj12 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v342 @ X0_v47] (should have been resolved before IL gen)");
		object obj14 = default(object);
		if (obj14 != null)
		{
			goto IL_01cc;
		}
		goto IL_056f;
		IL_02e1:
		object obj16;
		object obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v404 @ X8_v21+178] (should have been resolved before IL gen)");
		goto IL_056f;
		IL_056f:
		object obj17 = "getSecondRescanTask" + 1568;
		nint num2 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_034f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj19 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X10_v14-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj19 += 16;
			obj18--;
			if ((nint)obj18 != 1)
			{
				continue;
			}
			goto IL_034f;
		}
		goto IL_0467;
		IL_0380:
		object obj20 = obj6;
		nint num3 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_041c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj22 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X10_v9-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj22 += 16;
			obj21--;
			if ((nint)obj21 != 1)
			{
				continue;
			}
			goto IL_041c;
		}
		object obj23 = obj22 + 29;
		object obj24 = num3 + obj23;
		object obj25 = obj24 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v572 @ X0_v22] (should have been resolved before IL gen)");
		bool flag = obj20 == null;
		object obj26 = !flag;
		if (obj26 != null)
		{
			goto IL_0435;
		}
		goto IL_051e;
		IL_0467:
		object obj27 = obj19 + 1;
		object obj28 = num2 + obj27;
		object obj29 = obj28 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v512 @ X0_v29] (should have been resolved before IL gen)");
		object obj30 = default(object);
		bool flag2 = obj30 == null;
		object obj31 = !flag2;
		if (obj31 == null)
		{
			return;
		}
		goto IL_0380;
		IL_013b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v232 @ X0_v44] (should have been resolved before IL gen)");
		object obj32 = default(object);
		bool flag3 = obj32 == null;
		object obj33 = !flag3;
		if (obj33 != null)
		{
			goto IL_01cc;
		}
		goto IL_056f;
		IL_01cc:
		obj16 = obj4;
		nint num4 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0268;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj35 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X10_v21-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj35 += 16;
			obj34--;
			if ((nint)obj34 != 1)
			{
				continue;
			}
			goto IL_0268;
		}
		object obj36 = obj35 + 29;
		object obj37 = num4 + obj36;
		object obj38 = obj37 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v500 @ X0_v40] (should have been resolved before IL gen)");
		goto IL_02e1;
		IL_051e:
		throw new NullReferenceException();
		IL_0435:
		object obj39 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v11+178]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X8_v11+180]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v268 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_0467;
		IL_034f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v456 @ X0_v26] (should have been resolved before IL gen)");
		object obj42 = default(object);
		if (obj42 != null)
		{
			goto IL_0380;
		}
		return;
		IL_041c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v556 @ X0_v19] (should have been resolved before IL gen)");
		goto IL_0435;
		IL_0268:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v427 @ X0_v37] (should have been resolved before IL gen)");
		bool flag4 = obj4 == null;
		object obj43 = !flag4;
		if (obj43 != null)
		{
			goto IL_02e1;
		}
		goto IL_051e;
	}
}
