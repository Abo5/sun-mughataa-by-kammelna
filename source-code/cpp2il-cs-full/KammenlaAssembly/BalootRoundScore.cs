using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using GoogleMobileAds.Api.AdManager;
using Sfs2X.Entities.Data;
using UnityEngine.TextCore;

public class BalootRoundScore : CardGameRoundScore
{
	public class TeamProject
	{
		private string <Name>k__BackingField;

		private string <Value>k__BackingField;

		public string Name
		{
			get
			{
				return <Name>k__BackingField;
			}
			private set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 16;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}

		public string Value
		{
			get
			{
				return <Value>k__BackingField;
			}
			private set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 24;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}

		public TeamProject(string name, string value)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			object obj = this + 16;
			obj = name;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj2 = this + 24;
			obj2 = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public const string C_Team1Abnat = "p1";

	public const string C_Team2Abnat = "p2";

	public const string C_LastMoveWinner = "lmw";

	public const string C_GameMode = "m";

	public const string C_ExtraGameMode = "em";

	public const string C_Team1Projects = "r1";

	public const string C_Team2Projects = "r2";

	public const string C_ProjectName = "n";

	public const string C_ProjectValue = "v";

	public const string C_IsKabboot = "kbt";

	private int <Team1Abnat>k__BackingField;

	private int <Team2Abnat>k__BackingField;

	private int <LastMoveWinner>k__BackingField;

	private BalootGame.BalootGameMode <GameMode>k__BackingField;

	private BalootGame.BalootExtraGameMode <ExtraGameMode>k__BackingField;

	private List<TeamProject> <Team1Projects>k__BackingField;

	private List<TeamProject> <Team2Projects>k__BackingField;

	private bool <IsKabboot>k__BackingField;

	public int Team1Abnat
	{
		get
		{
			return <Team1Abnat>k__BackingField;
		}
		private set
		{
			<Team1Abnat>k__BackingField = value;
		}
	}

	public int Team2Abnat
	{
		get
		{
			return <Team2Abnat>k__BackingField;
		}
		private set
		{
			<Team2Abnat>k__BackingField = value;
		}
	}

	public int LastMoveWinner
	{
		get
		{
			return <LastMoveWinner>k__BackingField;
		}
		private set
		{
			<LastMoveWinner>k__BackingField = value;
		}
	}

	public BalootGame.BalootGameMode GameMode
	{
		get
		{
			return <GameMode>k__BackingField;
		}
		private set
		{
			<GameMode>k__BackingField = value;
		}
	}

	public BalootGame.BalootExtraGameMode ExtraGameMode
	{
		get
		{
			return <ExtraGameMode>k__BackingField;
		}
		private set
		{
			<ExtraGameMode>k__BackingField = value;
		}
	}

	public List<TeamProject> Team1Projects
	{
		get
		{
			return <Team1Projects>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<TeamProject> Team2Projects
	{
		get
		{
			return <Team2Projects>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool BidderWon
	{
		get
		{
			//IL_0011: Expected O, but got I4
			object obj = base.<WinnerTeamIndex>k__BackingField - base.<Bidder>k__BackingField;
			return obj == null;
		}
	}

	public bool IsKabboot
	{
		get
		{
			return <IsKabboot>k__BackingField;
		}
		private set
		{
			<IsKabboot>k__BackingField = value;
		}
	}

	public override void Record(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Expected O, but got Unknown
		//IL_0bfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c01: Expected O, but got Unknown
		//IL_0c0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c11: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0138: Expected O, but got I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_021b: Expected I, but got O
		//IL_022b: Expected O, but got I
		//IL_02e5: Expected O, but got I4
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_0381: Expected O, but got I4
		//IL_038a: Expected O, but got I4
		//IL_0266: Expected O, but got I
		//IL_0cc0: Expected O, but got I
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_04e3: Expected O, but got I
		//IL_0403: Expected O, but got I
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_0d49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4e: Expected O, but got Unknown
		//IL_0d6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d72: Expected O, but got Unknown
		//IL_051e: Expected O, but got I
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f5: Expected O, but got Unknown
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_070c: Expected I, but got O
		//IL_071c: Expected O, but got I
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected O, but got Unknown
		//IL_07d6: Expected O, but got I4
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected O, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d6: Expected O, but got Unknown
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected O, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Expected O, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		//IL_083a: Expected O, but got I4
		//IL_0757: Expected O, but got I
		//IL_0619: Expected O, but got I
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected O, but got Unknown
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected O, but got Unknown
		//IL_0dd6: Expected O, but got I
		//IL_0673: Expected O, but got I4
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected O, but got Unknown
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Expected O, but got Unknown
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected O, but got Unknown
		//IL_039f: Expected O, but got I
		//IL_03af: Expected O, but got I
		//IL_0993: Expected O, but got I
		//IL_08b3: Expected O, but got I
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected O, but got Unknown
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_03e8: Expected O, but got I4
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected O, but got Unknown
		//IL_0e5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e64: Expected O, but got Unknown
		//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e88: Expected O, but got Unknown
		//IL_09ce: Expected O, but got I
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_0937: Expected O, but got Unknown
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected O, but got Unknown
		//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected O, but got Unknown
		//IL_08c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c6: Expected O, but got Unknown
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Expected O, but got Unknown
		//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected O, but got Unknown
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Expected O, but got Unknown
		//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2c: Expected O, but got Unknown
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a47: Expected O, but got Unknown
		//IL_0ac9: Expected O, but got I
		//IL_09dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e1: Expected O, but got Unknown
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Expected O, but got Unknown
		//IL_0b23: Expected O, but got I4
		//IL_084f: Expected O, but got I
		//IL_085f: Expected O, but got I
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected O, but got Unknown
		//IL_0898: Expected O, but got I4
		//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b63: Expected O, but got Unknown
		//IL_0b6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b71: Expected O, but got Unknown
		object varName = "not" + 2928;
		object varName2 = "not" + 2936;
		object varName3 = "java.io.FileOutputStream" + 2880;
		object varName4 = "java.io.FileOutputStream" + 3672;
		object defaultValue = (nint)0 + (nint)2000;
		base.Record(data);
		int num = SFSExtensions.Get(data, (string)varName, 0);
		<Team1Abnat>k__BackingField = num;
		int num2 = SFSExtensions.Get(data, (string)varName2, 0);
		<Team2Abnat>k__BackingField = num2;
		int num3 = SFSExtensions.Get(data, (string)varName3, 0);
		<LastMoveWinner>k__BackingField = num3;
		string text = SFSExtensions.Get(data, (string)varName4, (string)defaultValue);
		object obj = "startPosition" + 1360;
		object varName5 = "destinationTimeZone" + 1888;
		object obj2 = typeof(List<Tween>) + 608;
		object varName6 = "java.io.FileOutputStream" + 560;
		BalootGame.BalootGameMode balootGameMode;
		if (text == (string)obj)
		{
			balootGameMode = BalootGame.BalootGameMode.Sun;
		}
		else
		{
			object obj3 = "getSecondRescanTask" + 3048;
			if (text == (string)obj3)
			{
				balootGameMode = BalootGame.BalootGameMode.Hokom;
			}
			else
			{
				object obj4 = "alignContent" + 2784;
				bool flag = text == (string)obj4;
				bool flag2 = !flag;
				object obj5 = !flag2;
				object obj6 = ~obj5;
				balootGameMode = ((obj6 == null) ? BalootGame.BalootGameMode.Ashkal : BalootGame.BalootGameMode.NotDetermined);
			}
		}
		<GameMode>k__BackingField = balootGameMode;
		string serverString = SFSExtensions.Get(data, (string)varName5, (string)defaultValue);
		BalootGame.BalootExtraGameMode balootExtraGameMode = BalootGame.ExtraGameModeFromString(serverString);
		<ExtraGameMode>k__BackingField = balootExtraGameMode;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj7 = this + 72;
		obj7 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj8 = this + 80;
		obj8 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag3 = SFSExtensions.Get(data, (string)varName6, defaultValue: false);
		object obj9 = typeof(System.IOAsyncCallback) + 976;
		object obj10 = "placementId" + 2072;
		nint num4 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02a7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X10_v42-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_02a7;
		}
		object obj13 = obj12 + 28;
		object obj14 = num4 + obj13;
		object obj15 = obj14 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v111+8]");
		int num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v536 @ X0_v111] (should have been resolved before IL gen)");
		ISFSObject iSFSObject = data;
		goto IL_0350;
		IL_0350:
		object obj16 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1616;
		object obj17 = typeof(System.IOAsyncCallback) + 960;
		object obj18 = 0;
		object obj19 = 0;
		object obj21 = default(object);
		object obj27 = default(object);
		ISFSObject obj34 = default(ISFSObject);
		int num7 = default(int);
		object obj36 = default(object);
		object obj46 = default(object);
		while (true)
		{
			object obj20 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v12+12E]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v12+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0444;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v12+B0]");
			object obj23 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X10_v37-8]");
				if (0 == (nint)obj16)
				{
					break;
				}
				obj23 += 16;
				obj22--;
				if ((nint)obj22 != 1)
				{
					continue;
				}
				goto IL_0444;
			}
			object obj24 = obj23 + 1;
			object obj25 = obj20 + obj24;
			object obj26 = obj25 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v667 @ X0_v104] (should have been resolved before IL gen)");
			if (obj19 >= obj27)
			{
				break;
			}
			goto IL_04cb;
			IL_04cb:
			object obj28 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v50+12E]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v50+12E]");
			if ((nint)0 == 0)
			{
				goto IL_055f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X8_v50+B0]");
			object obj30 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X10_v32-8]");
				if (0 == (nint)obj17)
				{
					break;
				}
				obj30 += 16;
				obj29--;
				if ((nint)obj29 != 1)
				{
					continue;
				}
				goto IL_055f;
			}
			object obj31 = obj30 + 51;
			object obj32 = obj28 + obj31;
			object obj33 = obj32 + 312;
			goto IL_0d2d;
			IL_0d2d:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v812 @ X0_v76] (should have been resolved before IL gen)");
			List<object> list3 = (List<object>)obj7;
			object varName7 = "m_StencilDeferredPS" + 2848;
			string text2 = SFSExtensions.Get(obj34, (string)varName7, (string)defaultValue);
			object varName8 = "utf-32" + 168;
			int num6 = SFSExtensions.Get(obj34, (string)varName8, 0);
			string text3 = num7.ToString();
			object obj35 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2664;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj36..ctor();
			object obj37 = obj36 + 16;
			obj37 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj38 = obj36 + 24;
			obj38 = text3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj39 = (nint)0 + (nint)960;
			object obj40 = obj39;
			int version = list3._version + 1;
			list3._version = version;
			object[] items = list3._items;
			bool flag4 = list3._size < items.Length;
			object obj41 = !flag4;
			if (obj41 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X8_v61+20]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1100 @ X8_v64+C0]");
				object obj43 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1101 @ X8_v65+70]");
				num5 = 0;
				list3.AddWithResize(obj36);
			}
			else
			{
				int size = list3._size + 1;
				list3._size = size;
				object obj44 = items + list3._size;
				object obj45 = obj44 + 32;
				obj45 = obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				num5 = 0;
			}
			obj19++;
			obj18 = 0;
			continue;
			IL_055f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0d2d;
			IL_0444:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v626 @ X0_v101] (should have been resolved before IL gen)");
			if (obj19 >= obj46)
			{
				break;
			}
			goto IL_04cb;
		}
		object obj47 = typeof(System.IOAsyncCallback) + 976;
		object obj48 = "placementId" + 2080;
		nint num8 = (nint)iSFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0798;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v19 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj50 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X10_v24-8]");
			if (0 == (nint)obj47)
			{
				break;
			}
			obj50 += 16;
			obj49--;
			if ((nint)obj49 != 1)
			{
				continue;
			}
			goto IL_0798;
		}
		object obj51 = obj50 + 28;
		object obj52 = num8 + obj51;
		object obj53 = obj52 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X0_v72+8]");
		int num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v829 @ X0_v72] (should have been resolved before IL gen)");
		goto IL_0831;
		IL_0798:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X0_v69+8]");
		num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v771 @ X0_v69] (should have been resolved before IL gen)");
		object obj54 = default(object);
		bool flag5 = obj54 == null;
		object obj55 = !flag5;
		if (obj55 != null)
		{
			goto IL_0831;
		}
		goto IL_0b92;
		IL_02a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v108+8]");
		num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v456 @ X0_v108] (should have been resolved before IL gen)");
		bool flag6 = obj21 == null;
		object obj56 = !flag6;
		iSFSObject = data;
		if (obj56 != null)
		{
			goto IL_0350;
		}
		goto IL_0b92;
		IL_0b92:
		throw new NullReferenceException();
		IL_0831:
		object obj57 = 0;
		object obj64 = default(object);
		ISFSObject obj71 = default(ISFSObject);
		object obj73 = default(object);
		object obj83 = default(object);
		while (true)
		{
			object obj58 = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v22+12E]");
			object obj59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v22+12E]");
			if ((nint)0 == 0)
			{
				goto IL_08f4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X8_v22+B0]");
			object obj60 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X10_v19-8]");
				if (0 == (nint)obj16)
				{
					break;
				}
				obj60 += 16;
				obj59--;
				if ((nint)obj59 != 1)
				{
					continue;
				}
				goto IL_08f4;
			}
			object obj61 = obj60 + 1;
			object obj62 = obj58 + obj61;
			object obj63 = obj62 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v970 @ X0_v65] (should have been resolved before IL gen)");
			if (obj57 < obj64)
			{
				goto IL_097b;
			}
			break;
			IL_097b:
			object obj65 = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X8_v25+12E]");
			object obj66 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X8_v25+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0a0f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X8_v25+B0]");
			object obj67 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1041 @ X10_v14-8]");
				if (0 == (nint)obj17)
				{
					break;
				}
				obj67 += 16;
				obj66--;
				if ((nint)obj66 != 1)
				{
					continue;
				}
				goto IL_0a0f;
			}
			object obj68 = obj67 + 51;
			object obj69 = obj65 + obj68;
			object obj70 = obj69 + 312;
			goto IL_0e43;
			IL_0e43:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1067 @ X0_v37] (should have been resolved before IL gen)");
			List<object> list4 = (List<object>)obj8;
			object varName9 = "m_StencilDeferredPS" + 2848;
			string text4 = SFSExtensions.Get(obj71, (string)varName9, (string)defaultValue);
			object varName10 = "utf-32" + 168;
			int num10 = SFSExtensions.Get(obj71, (string)varName10, 0);
			string text5 = num7.ToString();
			object obj72 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2664;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj73..ctor();
			object obj74 = obj73 + 16;
			obj74 = text4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj75 = obj73 + 24;
			obj75 = text5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj76 = (nint)0 + (nint)960;
			object obj77 = obj76;
			int version2 = list4._version + 1;
			list4._version = version2;
			object[] items2 = list4._items;
			bool flag7 = list4._size < items2.Length;
			object obj78 = !flag7;
			if (obj78 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v37+20]");
				object obj79 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ X8_v40+C0]");
				object obj80 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1126 @ X8_v41+70]");
				num9 = 0;
				list4.AddWithResize(obj73);
			}
			else
			{
				int size2 = list4._size + 1;
				list4._size = size2;
				object obj81 = items2 + list4._size;
				object obj82 = obj81 + 32;
				obj82 = obj73;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				num9 = 0;
			}
			obj57++;
			obj18 = 0;
			continue;
			IL_0a0f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0e43;
			IL_08f4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v925 @ X0_v62] (should have been resolved before IL gen)");
			if (obj57 >= obj83)
			{
				break;
			}
			goto IL_097b;
		}
	}

	public int GetTeamAbnat(int teamIndex)
	{
		//IL_0037: Expected O, but got I4
		//IL_0029: Expected O, but got I4
		if (teamIndex == 1)
		{
			object obj = 48;
		}
		else
		{
			object obj = 52;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BalootRoundScore)+v15 @ X8_v2]");
		return 0;
	}

	public List<TeamProject> GetTeamProjects(int teamIndex)
	{
		//IL_0037: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0029: Expected O, but got I4
		if (teamIndex == 1)
		{
			object obj = 72;
		}
		else
		{
			object obj = 80;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BalootRoundScore)+v15 @ X8_v2]");
		return (List<TeamProject>)0;
	}
}
