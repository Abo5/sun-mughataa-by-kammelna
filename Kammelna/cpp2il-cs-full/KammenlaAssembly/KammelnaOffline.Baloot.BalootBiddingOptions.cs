using System;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;
using Unity.Properties;

namespace KammelnaOffline.Baloot;

public class BalootBiddingOptions
{
	public static BalootBiddingOption[] GetBiddingOptionsFromState(int biddingState)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0060: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_003e: Expected O, but got I
		object obj = typeof(TypeConverter<ushort, char>) + 1760;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj2 = biddingState - 1;
			bool flag = (nint)obj2 < 53;
			object obj3 = !flag;
			object obj4 = obj2 - 53;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			object obj6 = obj3 & obj5;
			if (obj6 != null)
			{
				break;
			}
			object obj7 = 119877632 + 928;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X9_v2+v51 @ X8_v3*2]");
			object obj8 = (nint)85968328 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v70 @ X10_v2 (should have been resolved before IL gen)");
		}
		BalootBiddingOption[] result = default(BalootBiddingOption[]);
		return result;
	}

	public static BalootBiddingOption BiddingOptionFromSfsObject(ISFSObject param)
	{
		//IL_0a5d: Expected I4, but got O
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I4
		//IL_007b: Expected O, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0186: Expected I, but got O
		//IL_0196: Expected O, but got I
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02d7: Expected I, but got O
		//IL_02e7: Expected O, but got I
		//IL_01d1: Expected O, but got I
		//IL_0380: Unknown result type (might be due to invalid IL or missing references)
		//IL_0385: Expected O, but got Unknown
		//IL_041b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0428: Expected I, but got O
		//IL_0438: Expected O, but got I
		//IL_0322: Expected O, but got I
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0298: Expected O, but got Unknown
		//IL_02b2: Expected O, but got I4
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected O, but got Unknown
		//IL_0579: Expected I, but got O
		//IL_0589: Expected O, but got I
		//IL_0473: Expected O, but got I
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_0403: Expected O, but got I4
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected O, but got Unknown
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_033e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected O, but got Unknown
		//IL_06ca: Expected I, but got O
		//IL_06da: Expected O, but got I
		//IL_05c4: Expected O, but got I
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected O, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Expected O, but got Unknown
		//IL_0554: Expected O, but got I4
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected O, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected O, but got Unknown
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_082b: Expected O, but got Unknown
		//IL_0715: Expected O, but got I
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected O, but got Unknown
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_066e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0673: Expected O, but got Unknown
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected O, but got Unknown
		//IL_06a5: Expected O, but got I4
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected O, but got Unknown
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected O, but got Unknown
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected O, but got Unknown
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected O, but got Unknown
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected O, but got Unknown
		//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b6: Expected O, but got Unknown
		//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		//IL_07d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected O, but got Unknown
		//IL_07f6: Expected O, but got I4
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected O, but got Unknown
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected O, but got Unknown
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected O, but got Unknown
		//IL_08e9: Expected O, but got I
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected O, but got Unknown
		//IL_098a: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected O, but got Unknown
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d8: Expected O, but got Unknown
		//IL_0a16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Expected O, but got Unknown
		object obj;
		if (param != null)
		{
			obj = typeof(System.IOAsyncCallback) + 976;
			object obj2 = "not" + 3528;
			nint num = (nint)param;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00bc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v41-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00bc;
			}
			object obj5 = obj4 + 11;
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v395 @ X0_v83] (should have been resolved before IL gen)");
			object obj9 = default(object);
			object obj8 = obj9 & 1;
			if (obj8 != null)
			{
				goto IL_0169;
			}
			goto IL_016f;
		}
		NullReferenceException ex = new NullReferenceException();
		return (BalootBiddingOption)ex;
		IL_0411:
		object obj10 = "destinationTimeZone" + 632;
		nint num2 = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04b4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X10_v23-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_04b4;
		}
		object obj13 = obj12 + 11;
		object obj14 = num2 + obj13;
		object obj15 = obj14 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v720 @ X0_v56] (should have been resolved before IL gen)");
		object obj17 = default(object);
		object obj16 = obj17 & 1;
		bool flag = obj16 == null;
		object obj18 = !flag;
		if (obj18 != null)
		{
			goto IL_04f3;
		}
		goto IL_0562;
		IL_0363:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v577 @ X0_v62] (should have been resolved before IL gen)");
		object obj20 = default(object);
		object obj19 = obj20 & 1;
		if (obj19 != null)
		{
			goto IL_03a2;
		}
		goto IL_0411;
		IL_03a2:
		return BalootBiddingOption.Ashkal;
		IL_0605:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v784 @ X0_v44] (should have been resolved before IL gen)");
		object obj22 = default(object);
		object obj21 = obj22 & 1;
		if (obj21 != null)
		{
			goto IL_0644;
		}
		goto IL_06b3;
		IL_06b3:
		object obj23 = "placementId" + 1864;
		nint num3 = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0756;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v25 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X10_v11-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj25 += 16;
			obj24--;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_0756;
		}
		object obj26 = obj25 + 11;
		object obj27 = num3 + obj26;
		object obj28 = obj27 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v911 @ X0_v38] (should have been resolved before IL gen)");
		object obj30 = default(object);
		object obj29 = obj30 & 1;
		bool flag2 = obj29 == null;
		object obj31 = !flag2;
		if (obj31 != null)
		{
			goto IL_0795;
		}
		goto IL_0804;
		IL_0169:
		return BalootBiddingOption.Pass;
		IL_00bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ X0_v80] (should have been resolved before IL gen)");
		object obj33 = default(object);
		object obj32 = obj33 & 1;
		bool flag3 = obj32 == null;
		object obj34 = !flag3;
		if (obj34 != null)
		{
			goto IL_0169;
		}
		goto IL_016f;
		IL_016f:
		object obj35 = "startPosition" + 1360;
		nint num4 = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0212;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v439 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj37 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X10_v35-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj37 += 16;
			obj36--;
			if ((nint)obj36 != 1)
			{
				continue;
			}
			goto IL_0212;
		}
		object obj38 = obj37 + 11;
		object obj39 = num4 + obj38;
		object obj40 = obj39 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v512 @ X0_v74] (should have been resolved before IL gen)");
		object obj42 = default(object);
		object obj41 = obj42 & 1;
		bool flag4 = obj41 == null;
		object obj43 = !flag4;
		if (obj43 != null)
		{
			goto IL_0251;
		}
		goto IL_02c0;
		IL_04f3:
		return BalootBiddingOption.Double;
		IL_04b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v681 @ X0_v53] (should have been resolved before IL gen)");
		object obj45 = default(object);
		object obj44 = obj45 & 1;
		if (obj44 != null)
		{
			goto IL_04f3;
		}
		goto IL_0562;
		IL_0562:
		object obj46 = "tournament_participate_warning_body_with_tickets_warning_daily" + 624;
		nint num5 = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0605;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj48 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X10_v17-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj48 += 16;
			obj47--;
			if ((nint)obj47 != 1)
			{
				continue;
			}
			goto IL_0605;
		}
		object obj49 = obj48 + 11;
		object obj50 = num5 + obj49;
		object obj51 = obj50 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v817 @ X0_v47] (should have been resolved before IL gen)");
		object obj53 = default(object);
		object obj52 = obj53 & 1;
		bool flag5 = obj52 == null;
		object obj54 = !flag5;
		if (obj54 != null)
		{
			goto IL_0644;
		}
		goto IL_06b3;
		IL_0795:
		return BalootBiddingOption.Qahwa;
		IL_0212:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v473 @ X0_v71] (should have been resolved before IL gen)");
		object obj56 = default(object);
		object obj55 = obj56 & 1;
		if (obj55 != null)
		{
			goto IL_0251;
		}
		goto IL_02c0;
		IL_02c0:
		object obj57 = "alignContent" + 2784;
		nint num6 = (nint)param;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0363;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v13 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj59 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X10_v29-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj59 += 16;
			obj58--;
			if ((nint)obj58 != 1)
			{
				continue;
			}
			goto IL_0363;
		}
		object obj60 = obj59 + 11;
		object obj61 = num6 + obj60;
		object obj62 = obj61 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v616 @ X0_v65] (should have been resolved before IL gen)");
		object obj64 = default(object);
		object obj63 = obj64 & 1;
		bool flag6 = obj63 == null;
		object obj65 = !flag6;
		if (obj65 != null)
		{
			goto IL_03a2;
		}
		goto IL_0411;
		IL_0251:
		return BalootBiddingOption.Sun;
		IL_0756:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v878 @ X0_v35] (should have been resolved before IL gen)");
		object obj67 = default(object);
		object obj66 = obj67 & 1;
		if (obj66 != null)
		{
			goto IL_0795;
		}
		goto IL_0804;
		IL_0804:
		object obj68 = "getSecondRescanTask" + 2184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CA86B8");
		object obj70 = default(object);
		object obj69 = obj70 & 1;
		if (obj69 != null)
		{
			return BalootBiddingOption.HokomOpen;
		}
		object obj71 = "getSecondRescanTask" + 2176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CA86B8");
		object obj73 = default(object);
		object obj72 = obj73 & 1;
		if (obj72 != null)
		{
			return BalootBiddingOption.HokomClose;
		}
		object obj74 = "getSecondRescanTask" + 3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1CA86B8");
		object obj75 = default(object);
		if (obj75 != null)
		{
			object varName = "startPosition" + 1344;
			object defaultValue = (nint)0 + (nint)2000;
			string text = SFSExtensions.Get(param, (string)varName, (string)defaultValue);
			if (text != null && text._stringLength == 0)
			{
				return BalootBiddingOption.Hokom;
			}
			object obj76 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1976;
			if (text == (string)obj76)
			{
				return BalootBiddingOption.HokomClubs;
			}
			object obj77 = "com.unity.services.authentication.profile" + 2776;
			if (text == (string)obj77)
			{
				return BalootBiddingOption.HokomDiamonds;
			}
			object obj78 = "rightCtrl" + 768;
			if (text == (string)obj78)
			{
				return BalootBiddingOption.HokomSpades;
			}
			object obj79 = "getSecondRescanTask" + 2152;
			if (text == (string)obj79)
			{
				return BalootBiddingOption.HokomHearts;
			}
		}
		goto IL_0169;
		IL_0644:
		return BalootBiddingOption.Triple;
	}
}
