using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

namespace Server.Models;

[Serializable]
public class TournamentEndGameReport
{
	public const string GameWinnerIndex = "winner";

	public const string MatchWinnerIndex = "mw";

	public const string FinalMatch = "fm";

	public const string Prize = "prz";

	public const string Teammate = "tmm";

	public const string MassPoints = "mep";

	public const string MassTrials = "met";

	public int gameWinner;

	public int matchWinner;

	public bool isFinalMatch;

	public bool hasPrize;

	public int prize;

	public PlayerInfo teammate;

	public int massPoints;

	public int massTrials;

	public bool IsMatchOver
	{
		get
		{
			bool flag = matchWinner == 0;
			return !flag;
		}
	}

	public TournamentEndGameReport(ISFSObject data)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00b4: Expected I, but got O
		//IL_00c4: Expected O, but got I
		//IL_0176: Expected O, but got I4
		//IL_01f1: Expected I, but got O
		//IL_0201: Expected O, but got I
		//IL_00ff: Expected O, but got I
		//IL_0297: Expected I, but got O
		//IL_023c: Expected O, but got I
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02dd: Expected I, but got O
		//IL_02ed: Expected O, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03b1: Expected I, but got O
		//IL_03d5: Expected O, but got I4
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected O, but got Unknown
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected O, but got Unknown
		//IL_0328: Expected O, but got I
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0440: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_044d: Expected I, but got O
		//IL_045d: Expected O, but got I
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_0498: Expected O, but got I
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_0512: Expected I, but got O
		//IL_0522: Expected O, but got I
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bb: Expected O, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected O, but got Unknown
		//IL_05fa: Expected O, but got I4
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e0: Expected O, but got Unknown
		//IL_07fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0802: Expected O, but got Unknown
		//IL_055d: Expected O, but got I
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Expected O, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected O, but got Unknown
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected O, but got Unknown
		//IL_062d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Expected O, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0570: Expected O, but got Unknown
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7BD1]");
		nint num = 0;
		object varName = "utf-32" + 1520;
		object varName2 = "fetch_products" + 840;
		object varName3 = "m_StencilDeferredPS" + 2816;
		base..ctor();
		int num2 = SFSExtensions.Get(data, (string)varName, 0);
		gameWinner = num2;
		bool flag = SFSExtensions.Get(data, (string)varName2, defaultValue: false);
		isFinalMatch = flag;
		matchWinner = SFSExtensions.Get(data, (string)varName3, 0);
		object obj3;
		if (data != null)
		{
			varName2 = typeof(System.IOAsyncCallback) + 976;
			varName = "placementId" + 2224;
			nint num3 = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0148;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v24 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj2 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v32-8]");
				if (0 == (nint)varName2)
				{
					break;
				}
				obj3 = obj2 + 16;
				obj--;
				bool flag2 = (nint)obj != 1;
				obj2 = obj3;
				if (flag2)
				{
					continue;
				}
				goto IL_0148;
			}
			object obj4 = (object)(num3 + (object)(obj2 + 1)) + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v324 @ X0_v56] (should have been resolved before IL gen)");
			object obj5 = default(object);
			bool flag3 = obj5 == null;
			obj3 = obj2;
			if (!flag3)
			{
				goto IL_01e1;
			}
			return;
		}
		goto IL_03eb;
		IL_0285:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj6 = default(object);
		num = (nint)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v443 @ X0_v46] (should have been resolved before IL gen)");
		ISFSObject iSFSObject = default(ISFSObject);
		if (iSFSObject != null)
		{
			goto IL_02be;
		}
		goto IL_03eb;
		IL_03eb:
		ISFSObject iSFSObject2 = data;
		throw new NullReferenceException();
		IL_02be:
		varName = "placementId" + 1464;
		varName3 = varName;
		num = (nint)iSFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0369;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X10_v24-8]");
			bool flag4 = 0 == (nint)varName2;
			iSFSObject2 = iSFSObject;
			if (flag4)
			{
				break;
			}
			obj3 += 16;
			obj7--;
			if ((nint)obj7 != 1)
			{
				continue;
			}
			goto IL_0369;
		}
		object obj8 = (object)(num + (object)(obj3 + 1)) + 312;
		goto IL_06ed;
		IL_0369:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		iSFSObject2 = iSFSObject;
		goto IL_06ed;
		IL_050a:
		nint num4 = (nint)iSFSObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_059e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X10_v7-8]");
			if (0 == (nint)varName2)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_059e;
		}
		object obj11 = (object)(num4 + (object)(obj10 + 29)) + 312;
		goto IL_07c2;
		IL_0148:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v195 @ X0_v53] (should have been resolved before IL gen)");
		object obj12 = default(object);
		if ((object)(obj12 != null) == null)
		{
			return;
		}
		goto IL_01e1;
		IL_01e1:
		varName3 = varName;
		nint num5 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0285;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X10_v27-8]");
			if (0 == (nint)varName2)
			{
				break;
			}
			obj3 = obj14 + 16;
			obj13--;
			bool flag5 = (nint)obj13 != 1;
			obj14 = obj3;
			if (flag5)
			{
				continue;
			}
			goto IL_0285;
		}
		num = (nint)(object)((object)(num5 + (object)(obj14 + 29)) + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v521 @ X0_v49] (should have been resolved before IL gen)");
		object obj15 = iSFSObject != null;
		obj3 = obj14;
		if (obj15 != null)
		{
			goto IL_02be;
		}
		goto IL_03eb;
		IL_06ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v299 @ X0_v9] (should have been resolved before IL gen)");
		bool flag6 = default(bool);
		hasPrize = flag6;
		int num6 = SFSExtensions.Get(iSFSObject2, (string)varName, 0);
		prize = num6;
		object varName4 = "m_StencilDeferredPS" + 1248;
		int num7 = SFSExtensions.Get(iSFSObject2, (string)varName4, 0);
		massPoints = num7;
		object varName5 = "m_StencilDeferredPS" + 1344;
		int num8 = SFSExtensions.Get(iSFSObject2, (string)varName5, 0);
		massTrials = num8;
		object obj16 = "startPosition" + 3408;
		nint num9 = (nint)iSFSObject2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04d9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj18 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v12-8]");
			if (0 == (nint)varName2)
			{
				break;
			}
			obj18 += 16;
			obj17--;
			if ((nint)obj17 != 1)
			{
				continue;
			}
			goto IL_04d9;
		}
		object obj19 = (object)(num9 + (object)(obj18 + 1)) + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v596 @ X0_v33] (should have been resolved before IL gen)");
		object obj20 = default(object);
		if ((object)(obj20 != null) == null)
		{
			return;
		}
		goto IL_050a;
		IL_059e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_07c2;
		IL_07c2:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v677 @ X0_v19] (should have been resolved before IL gen)");
		object obj21 = typeof(System.Buffers.Text.ParserHelpers) + 936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo = default(PlayerInfo);
		ISFSObject data2 = default(ISFSObject);
		playerInfo..ctor(data2);
		object obj22 = this + 32;
		obj22 = playerInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_04d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v556 @ X0_v30] (should have been resolved before IL gen)");
		object obj23 = default(object);
		if (obj23 != null)
		{
			goto IL_050a;
		}
	}
}
