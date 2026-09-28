using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class CheatingInfo
{
	public const string C_CatchCheatMode = "ccm";

	public const string C_Eatings = "es";

	public const string C_CardsInHands = "ch";

	public const string C_CurrentCatcher = "cc";

	public const string C_CheatingResult = "cr";

	public const string C_TimerSeconds = "ts";

	private const string C_NoCheatings = "nc";

	public const string CatchMode = "mode";

	public const string ModeWrongSawa = "wrong_sawa";

	public const string ModeWrongEkka = "wrong_ekka";

	public const string ModeCut = "cut";

	public const string ModeHokomCut = "hkmcut";

	public const string ModeDouble = "double";

	public const string ModeUp = "up";

	public const string ModePlay = "play";

	public const string ModeProject = "project";

	public const string C_WrongCard = "wc";

	public const string C_AllowedCard = "ac";

	public const string SendWrongCard = "wrong_card";

	public const string SendAllowedCard = "allowed_card";

	private readonly List<List<Card>> <Eatings>k__BackingField;

	private readonly List<List<Card>> <CardsInHands>k__BackingField;

	private readonly string <CatchCheatMode>k__BackingField;

	private readonly KPlayer <CurrentCatcher>k__BackingField;

	private readonly Card <WrongCard>k__BackingField;

	private readonly Card <AllowedCard>k__BackingField;

	private readonly bool <Correct>k__BackingField;

	private readonly int <TimerSeconds>k__BackingField;

	private readonly bool <NoCheatings>k__BackingField;

	public List<List<Card>> Eatings => <Eatings>k__BackingField;

	public List<List<Card>> CardsInHands => <CardsInHands>k__BackingField;

	public string CatchCheatMode => <CatchCheatMode>k__BackingField;

	public KPlayer CurrentCatcher => <CurrentCatcher>k__BackingField;

	public Card WrongCard => <WrongCard>k__BackingField;

	public Card AllowedCard => <AllowedCard>k__BackingField;

	public bool Correct => <Correct>k__BackingField;

	public int TimerSeconds => <TimerSeconds>k__BackingField;

	public bool NoCheatings => <NoCheatings>k__BackingField;

	public bool IsWrongSawa
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object obj = "utf-32" + 1704;
			return <CatchCheatMode>k__BackingField == (string)obj;
		}
	}

	public bool IsWrongEkka
	{
		get
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			object obj = "utf-32" + 1696;
			return <CatchCheatMode>k__BackingField == (string)obj;
		}
	}

	public bool IsFirstPhase
	{
		get
		{
			bool flag = <CurrentCatcher>k__BackingField == null;
			return !flag;
		}
	}

	public CheatingInfo(ISFSObject response, KGame game)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0aee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af3: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00db: Expected I, but got O
		//IL_00eb: Expected O, but got I
		//IL_0b3e: Expected O, but got I
		//IL_0b61: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b66: Expected O, but got Unknown
		//IL_0126: Expected O, but got I
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01d8: Expected O, but got I
		//IL_0b85: Expected I, but got O
		//IL_0b95: Expected O, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_02ac: Expected O, but got I
		//IL_02cd: Expected O, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0374: Expected O, but got I4
		//IL_0251: Expected O, but got I
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_0319: Expected O, but got I
		//IL_0401: Expected O, but got I4
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_01f6: Expected O, but got I
		//IL_0206: Expected O, but got I
		//IL_0216: Expected O, but got I
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected O, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected O, but got Unknown
		//IL_058b: Expected I, but got O
		//IL_059b: Expected O, but got I
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected O, but got Unknown
		//IL_0c40: Expected O, but got I
		//IL_0c59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5e: Expected O, but got Unknown
		//IL_0c78: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c7d: Expected O, but got Unknown
		//IL_05d6: Expected O, but got I
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_0d0d: Expected I, but got O
		//IL_0d1d: Expected O, but got I
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Expected O, but got Unknown
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected O, but got Unknown
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0836: Expected O, but got Unknown
		//IL_065c: Expected O, but got I4
		//IL_090f: Expected O, but got I
		//IL_0930: Expected O, but got I4
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected O, but got Unknown
		//IL_054d: Expected O, but got I4
		//IL_069e: Expected O, but got I4
		//IL_09d7: Expected O, but got I4
		//IL_08b4: Expected O, but got I
		//IL_06db: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected O, but got Unknown
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected O, but got Unknown
		//IL_0967: Unknown result type (might be due to invalid IL or missing references)
		//IL_096c: Expected O, but got Unknown
		//IL_097c: Expected O, but got I
		//IL_078e: Expected O, but got I4
		//IL_0a64: Expected O, but got I4
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Expected O, but got Unknown
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Expected O, but got Unknown
		//IL_0c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9f: Expected O, but got Unknown
		//IL_0cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Expected O, but got Unknown
		//IL_0ce5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cea: Expected O, but got Unknown
		//IL_07d0: Expected O, but got I4
		//IL_0859: Expected O, but got I
		//IL_0869: Expected O, but got I
		//IL_0879: Expected O, but got I
		//IL_0a9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa4: Expected O, but got Unknown
		//IL_0aad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab2: Expected O, but got Unknown
		object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2536;
		object varName2 = "com.unity.services.authentication.profile" + 1792;
		object varName3 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2512;
		base..ctor();
		string text = SFSExtensions.Get(response, (string)varName, (string)null);
		object obj = this + 32;
		obj = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = SFSExtensions.Get(response, (string)varName2, defaultValue: false);
		KPlayer playerByIndex = game.GetPlayerByIndex(SFSExtensions.Get(response, (string)varName3, 0));
		object obj2 = this + 40;
		obj2 = playerByIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = typeof(System.IOAsyncCallback) + 976;
		object obj4 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2728;
		object obj5 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3712;
		nint num = (nint)response;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0167;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj7 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X10_v30-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj7 += 16;
			obj6--;
			if ((nint)obj6 != 1)
			{
				continue;
			}
			goto IL_0167;
		}
		object obj8 = (object)(num + (object)(obj7 + 28)) + 312;
		goto IL_0b2e;
		IL_047a:
		string text2 = SFSExtensions.Get(response, "utf-32" + 1192, (string)null);
		string text3 = SFSExtensions.Get(response, "___# Content push apply failed [{0}]: {1}" + 2808, (string)null);
		object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X0_v64+E4]");
		Card card;
		if ((nint)0 != 0)
		{
			bool flag2 = !StringsExtensions.IsNullOrEmpty(text2);
			card = null;
			Card card2 = null;
			if (!flag2)
			{
				goto IL_0536;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj11 = StringsExtensions.IsNullOrEmpty(text2);
			card = null;
			Card card2 = null;
			if (obj11 != null)
			{
				goto IL_0536;
			}
		}
		object obj13;
		object obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v89+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		card = CardUtils.FromString(text2);
		goto IL_06d5;
		IL_0536:
		if ((object)(this != null) == null)
		{
			throw new NullReferenceException();
		}
		goto IL_06d5;
		IL_0c94:
		object obj14 = this + 56;
		Card card3;
		obj14 = card3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object varName4 = "m_StencilDeferredPS" + 3128;
		bool flag3 = SFSExtensions.Get(response, (string)varName4, defaultValue: false);
		object varName5 = "tournament_participate_warning_body_with_tickets_warning_daily" + 728;
		int num2 = SFSExtensions.Get(response, (string)varName5, 0);
		return;
		IL_0617:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0c30;
		IL_0167:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0b2e;
		IL_0b2e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v400 @ X0_v18+8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v400 @ X0_v18] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj16 = this + 24;
		obj16 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj17 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1616;
		obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 376;
		object obj18 = (nint)0 + (nint)2816;
		int num3 = 0;
		ISFSArray iSFSArray = default(ISFSArray);
		object obj25 = default(object);
		object obj34 = default(object);
		while (true)
		{
			nint num4 = (nint)iSFSArray;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0292;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
			object obj20 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X10_v25-8]");
				if (0 == (nint)obj17)
				{
					break;
				}
				obj20 += 16;
				obj19--;
				if ((nint)obj19 != 1)
				{
					continue;
				}
				goto IL_0292;
			}
			object obj21 = obj20 + 1;
			object obj22 = num4 + obj21;
			object obj23 = obj22 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X0_v118+8]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v527 @ X0_v118] (should have been resolved before IL gen)");
			if (num3 >= (nint)obj25)
			{
				break;
			}
			goto IL_0342;
			IL_0342:
			List<object> list2 = (List<object>)obj16;
			object obj26 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X0_v104+E4]");
			bool flag4 = (nint)0 == 0;
			object obj27 = !flag4;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			List<Card> list3 = CardUtils.DecodeCards(iSFSArray, num3);
			object obj28 = obj18;
			int version = list2._version + 1;
			list2._version = version;
			object[] items = list2._items;
			bool flag5 = list2._size < items.Length;
			object obj29 = !flag5;
			if (obj29 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v56+20]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v685 @ X8_v59+C0]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X8_v60+70]");
				obj15 = 0;
				list2.AddWithResize((object)list3);
			}
			else
			{
				int size = list2._size + 1;
				list2._size = size;
				object obj32 = items + list2._size;
				object obj33 = obj32 + 32;
				obj33 = list3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			num3++;
			continue;
			IL_0292:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v115+8]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v486 @ X0_v115] (should have been resolved before IL gen)");
			bool flag6 = num3 < (nint)obj34;
			obj15 = 1;
			if (!flag6)
			{
				break;
			}
			goto IL_0342;
		}
		if (!((string)obj == "utf-32" + 1704))
		{
			object obj35 = typeof(System.IOAsyncCallback) + 976;
			object obj36 = "destinationTimeZone" + 2752;
			nint num5 = (nint)response;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v18 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v18 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0617;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v18 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj38 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v702 @ X10_v17-8]");
				if (0 == (nint)obj35)
				{
					break;
				}
				obj38 += 16;
				obj37--;
				if ((nint)obj37 != 1)
				{
					continue;
				}
				goto IL_0617;
			}
			object obj39 = (object)(num5 + (object)(obj38 + 28)) + 312;
			goto IL_0c30;
		}
		goto IL_047a;
		IL_06d5:
		object obj40 = this + 48;
		obj40 = card;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj41 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X0_v69+E4]");
		if ((nint)0 != 0)
		{
			bool flag7 = !StringsExtensions.IsNullOrEmpty(text3);
			Card card4 = null;
			if (flag7)
			{
				goto IL_07a6;
			}
			card3 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj42 = StringsExtensions.IsNullOrEmpty(text3);
			Card card4 = null;
			card3 = null;
			if (obj42 == null)
			{
				goto IL_07a6;
			}
		}
		goto IL_0c94;
		IL_07a6:
		object obj43 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X0_v78+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		card3 = CardUtils.FromString(text3);
		goto IL_0c94;
		IL_0c30:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X0_v30+8]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v723 @ X0_v30] (should have been resolved before IL gen)");
		object obj45 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list4 = default(List<object>);
		list4..ctor();
		object obj46 = this + 16;
		obj46 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num6 = 0;
		ISFSArray iSFSArray2 = default(ISFSArray);
		object obj53 = default(object);
		object obj62 = default(object);
		while (true)
		{
			nint num7 = (nint)iSFSArray2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			object obj47 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_08f5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
			object obj48 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X10_v12-8]");
				if (0 == (nint)obj17)
				{
					break;
				}
				obj48 += 16;
				obj47--;
				if ((nint)obj47 != 1)
				{
					continue;
				}
				goto IL_08f5;
			}
			object obj49 = obj48 + 1;
			object obj50 = num7 + obj49;
			object obj51 = obj50 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v885 @ X0_v53+8]");
			object obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v885 @ X0_v53] (should have been resolved before IL gen)");
			if (num6 >= (nint)obj53)
			{
				break;
			}
			goto IL_09a5;
			IL_09a5:
			List<object> list5 = (List<object>)obj46;
			object obj54 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X0_v39+E4]");
			bool flag8 = (nint)0 == 0;
			object obj55 = !flag8;
			if (obj55 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			List<Card> list6 = CardUtils.DecodeCards(iSFSArray2, num6);
			object obj56 = obj18;
			int version2 = list5._version + 1;
			list5._version = version2;
			object[] items2 = list5._items;
			bool flag9 = list5._size < items2.Length;
			object obj57 = !flag9;
			if (obj57 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v29+20]");
				object obj58 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X8_v32+C0]");
				object obj59 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v914 @ X8_v33+70]");
				obj44 = 0;
				list5.AddWithResize((object)list6);
			}
			else
			{
				int size2 = list5._size + 1;
				list5._size = size2;
				object obj60 = items2 + list5._size;
				object obj61 = obj60 + 32;
				obj61 = list6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			num6++;
			continue;
			IL_08f5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X0_v50+8]");
			obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v836 @ X0_v50] (should have been resolved before IL gen)");
			bool flag10 = num6 < (nint)obj62;
			obj44 = 1;
			if (!flag10)
			{
				break;
			}
			goto IL_09a5;
		}
		goto IL_047a;
	}

	public static ISFSObject CreateCheatingData(Card wrongCard, Card allowedCard, string mode)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005a: Expected I, but got O
		//IL_006a: Expected O, but got I
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0164: Expected I, but got O
		//IL_0174: Expected O, but got I
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0261: Expected I, but got O
		//IL_0271: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_01af: Expected O, but got I
		//IL_02ac: Expected O, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		if (wrongCard == null)
		{
			goto IL_037c;
		}
		string text = wrongCard.ToString();
		if (sFSObject == null)
		{
			goto IL_032a;
		}
		object obj3 = "utf-32" + 1680;
		nint num = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v294 @ X10_v21-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj5 += 16;
			obj4--;
			if ((nint)obj4 != 1)
			{
				continue;
			}
			goto IL_00e6;
		}
		object obj6 = obj5 + 39;
		object obj7 = num + obj6;
		object obj8 = obj7 + 312;
		goto IL_03bd;
		IL_0400:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v16+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v430 @ X0_v16] (should have been resolved before IL gen)");
		goto IL_0452;
		IL_0452:
		if (mode != null)
		{
			if (sFSObject == null)
			{
				goto IL_032a;
			}
			object obj9 = "m_StencilDeferredPS" + 2232;
			nint num3 = (nint)sFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02ed;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
			object obj11 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X10_v8-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj11 += 16;
				obj10--;
				if ((nint)obj10 != 1)
				{
					continue;
				}
				goto IL_02ed;
			}
			object obj12 = obj11 + 39;
			object obj13 = num3 + obj12;
			object obj14 = obj13 + 312;
			goto IL_0443;
		}
		goto IL_046f;
		IL_046f:
		return sFSObject;
		IL_032a:
		return (ISFSObject)new NullReferenceException();
		IL_0443:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v460 @ X0_v8] (should have been resolved before IL gen)");
		goto IL_046f;
		IL_02ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0443;
		IL_00e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_03bd;
		IL_03bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v26+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v371 @ X0_v26] (should have been resolved before IL gen)");
		goto IL_037c;
		IL_037c:
		if (allowedCard != null)
		{
			string text2 = allowedCard.ToString();
			if (sFSObject == null)
			{
				goto IL_032a;
			}
			object obj15 = "alignContent" + 136;
			nint num4 = (nint)sFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01f0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v15 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
			object obj17 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X10_v14-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj17 += 16;
				obj16--;
				if ((nint)obj16 != 1)
				{
					continue;
				}
				goto IL_01f0;
			}
			object obj18 = obj17 + 39;
			object obj19 = num4 + obj18;
			object obj20 = obj19 + 312;
			goto IL_0400;
		}
		goto IL_0452;
		IL_01f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0400;
	}

	public static ISFSObject CreateCheatingData(int catcherIndex, Card wrongCard, Card allowedCard, string mode, bool isCorrect)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0044: Expected I, but got O
		//IL_0054: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_011e: Expected O, but got I
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_02ac: Expected I, but got O
		//IL_02bc: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_0146: Expected O, but got I4
		//IL_068c: Expected O, but got I
		//IL_06b5: Expected O, but got I
		//IL_02f7: Expected O, but got I
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_0399: Expected I, but got O
		//IL_03a9: Expected O, but got I
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0251: Expected O, but got I
		//IL_027a: Expected O, but got I
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0185: Expected O, but got I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Expected O, but got Unknown
		//IL_0479: Expected I, but got O
		//IL_0489: Expected O, but got I
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_06f7: Expected O, but got I
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Expected O, but got Unknown
		//IL_072f: Expected O, but got I
		//IL_03e4: Expected O, but got I
		//IL_01bb: Expected I, but got O
		//IL_01cb: Expected O, but got I
		//IL_01ed: Expected O, but got I4
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0779: Expected O, but got I
		//IL_079b: Expected I, but got O
		//IL_07ab: Expected O, but got I
		//IL_07d2: Expected O, but got I
		//IL_04c4: Expected O, but got I
		//IL_0558: Expected O, but got I
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected O, but got Unknown
		//IL_052a: Unknown result type (might be due to invalid IL or missing references)
		//IL_052f: Expected O, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected O, but got Unknown
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		//IL_05d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05db: Expected O, but got Unknown
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected O, but got Unknown
		//IL_0574: Unknown result type (might be due to invalid IL or missing references)
		//IL_0579: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj2;
		object obj9;
		object obj10;
		if (sFSObject != null)
		{
			obj2 = typeof(System.IOAsyncCallback) + 976;
			object obj3 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2512;
			nint num = (nint)sFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X10_v35-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00d0;
			}
			object obj6 = obj5 + 35;
			object obj7 = num + obj6;
			object obj8 = obj7 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v46+8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v219 @ X0_v46] (should have been resolved before IL gen)");
			bool flag = wrongCard == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v46+8]");
			obj10 = 0;
			if (flag)
			{
				goto IL_012c;
			}
			goto IL_0288;
		}
		return (ISFSObject)new NullReferenceException();
		IL_0769:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v15+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v709 @ X0_v15] (should have been resolved before IL gen)");
		object obj11 = obj2;
		object obj13;
		object obj12 = obj13;
		nint num2 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		bool flag2 = (nint)0 == 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v15+8]");
		object obj15 = 0;
		object obj16 = obj2;
		object obj17 = obj13;
		if (!flag2)
		{
			goto IL_0542;
		}
		goto IL_05b1;
		IL_0505:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0769;
		IL_01a3:
		obj11 = obj2;
		object obj18;
		obj12 = obj18;
		num2 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		bool flag3 = (nint)0 == 0;
		object obj19 = !flag3;
		if (obj19 != null)
		{
			goto IL_0542;
		}
		obj15 = obj9;
		obj16 = obj2;
		obj17 = obj18;
		goto IL_05b1;
		IL_05b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0814;
		IL_0425:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_06e7;
		IL_0542:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj20 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X10_v6-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj20 += 16;
			obj14--;
			bool flag4 = (nint)obj14 != 1;
			obj15 = obj9;
			obj16 = obj11;
			obj17 = obj12;
			if (flag4)
			{
				continue;
			}
			goto IL_05b1;
		}
		object obj21 = obj20 + 32;
		object obj22 = num2 + obj21;
		object obj23 = obj22 + 312;
		obj17 = obj12;
		goto IL_0814;
		IL_00d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v43+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v123 @ X0_v43] (should have been resolved before IL gen)");
		bool flag5 = wrongCard == null;
		object obj24 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v43+8]");
		obj10 = 0;
		if (obj24 == null)
		{
			goto IL_012c;
		}
		goto IL_0288;
		IL_0288:
		object obj25 = "utf-32" + 1680;
		string text = wrongCard.ToString();
		nint num3 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0338;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v27 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj27 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X10_v27-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj27 += 16;
			obj26--;
			if ((nint)obj26 != 1)
			{
				continue;
			}
			goto IL_0338;
		}
		object obj28 = obj27 + 39;
		object obj29 = num3 + obj28;
		object obj30 = obj29 + 312;
		goto IL_067c;
		IL_06e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X0_v24+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v693 @ X0_v24] (should have been resolved before IL gen)");
		obj18 = "com.unity.services.authentication.profile" + 1792;
		bool flag6 = mode == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X0_v24+8]");
		object obj31 = 0;
		obj13 = obj18;
		if (flag6)
		{
			goto IL_01a3;
		}
		goto IL_0462;
		IL_015c:
		obj18 = "com.unity.services.authentication.profile" + 1792;
		bool flag7 = mode == null;
		object obj32 = !flag7;
		obj31 = obj9;
		obj13 = obj18;
		if (obj32 == null)
		{
			goto IL_01a3;
		}
		goto IL_0462;
		IL_0462:
		object obj33 = "m_StencilDeferredPS" + 2232;
		nint num4 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0505;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj35 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X10_v13-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj35 += 16;
			obj34--;
			if ((nint)obj34 != 1)
			{
				continue;
			}
			goto IL_0505;
		}
		object obj36 = obj35 + 39;
		object obj37 = num4 + obj36;
		object obj38 = obj37 + 312;
		goto IL_0769;
		IL_0814:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v717 @ X0_v5] (should have been resolved before IL gen)");
		return sFSObject;
		IL_0338:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_067c;
		IL_067c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v33+8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v605 @ X0_v33] (should have been resolved before IL gen)");
		bool flag8 = allowedCard == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v33+8]");
		object obj39 = 0;
		if (flag8)
		{
			goto IL_015c;
		}
		goto IL_0375;
		IL_012c:
		bool flag9 = allowedCard == null;
		object obj40 = !flag9;
		obj39 = obj9;
		if (obj40 == null)
		{
			goto IL_015c;
		}
		goto IL_0375;
		IL_0375:
		object obj41 = "alignContent" + 136;
		string text2 = allowedCard.ToString();
		nint num5 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0425;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v21 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj43 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X10_v20-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj43 += 16;
			obj42--;
			if ((nint)obj42 != 1)
			{
				continue;
			}
			goto IL_0425;
		}
		object obj44 = obj43 + 39;
		object obj45 = num5 + obj44;
		object obj46 = obj45 + 312;
		goto IL_06e7;
	}
}
