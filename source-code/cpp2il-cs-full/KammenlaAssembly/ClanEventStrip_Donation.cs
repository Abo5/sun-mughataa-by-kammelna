using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using TMPro;
using Unity.Properties;
using UnityEngine;

public class ClanEventStrip_Donation : ClanEventStrip
{
	private const string DONATED_KEY = "clan_member_donated";

	private const string COINS_KEY = "COINS";

	private TextMeshProUGUI amountText;

	private GameObject[] tierObjects;

	public override void Initialize(ClanFeedModel model)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_0140: Expected O, but got I4
		//IL_015b: Expected O, but got I4
		//IL_0189: Expected O, but got I4
		//IL_021b: Expected O, but got I4
		//IL_019f: Expected I, but got O
		//IL_01af: Expected O, but got I
		//IL_01d1: Expected O, but got I4
		//IL_01f3: Expected O, but got I
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_0261: Expected O, but got I
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		ClanFeedModel clanFeedModel = default(ClanFeedModel);
		bool flag = clanFeedModel == null;
		IntPtr intPtr = default(IntPtr);
		bool flag2 = (byte)(nint)intPtr != 0;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			ClanFeedData clanFeedData = clanFeedModel.Data;
			if (clanFeedModel.Data == null)
			{
				return;
			}
			object obj = typeof(MemberAchievementClanFeedData) + 136;
			object obj2 = obj;
			nint num = (nint)clanFeedData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X9_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v9+130]");
			bool flag3 = num2 < 0;
			object obj3 = !flag3;
			object obj4 = ~obj3;
			if (obj4 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X9_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v9+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X9_v7-8]");
			if (0 != (nint)obj2)
			{
				return;
			}
			InitializeAvatar(clanFeedModel);
			TextMeshProUGUI textMeshProUGUI = amountText;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X23_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+38]");
			TextMeshProExtensions.SetPriceText(textMeshProUGUI, 0);
			object obj6 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag4 = array == null;
			object obj7 = 0;
			bool flag5 = false;
			flag2 = false;
			clanFeedModel = (ClanFeedModel)1;
			if (!flag4)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X23_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+30]");
				bool flag6 = (nint)0 == 0;
				ClanFeedModel clanFeedModel2 = (ClanFeedModel)1;
				if (!flag6)
				{
					nint num4 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
					clanFeedModel2 = (ClanFeedModel)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag7 = ex == null;
					obj7 = 0;
					flag5 = false;
					flag2 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
					clanFeedModel = (ClanFeedModel)0;
					if (flag7)
					{
						goto IL_02c1;
					}
				}
				bool flag8 = array.Length == 0;
				obj7 = 0;
				flag5 = false;
				flag2 = false;
				clanFeedModel = clanFeedModel2;
				if (!flag8)
				{
					object obj8 = array + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X23_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+30]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj9 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3856;
					TextMeshProExtensions.Localize(text, (string)obj9, array);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X23_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+3C]");
					ShowTierObject(VaultSupportTier.Tier1);
					return;
				}
				goto IL_02b3;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_02b3;
		IL_02c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_02b3:
		ex = new IndexOutOfRangeException();
		goto IL_02c1;
	}

	private void ShowTierObject(VaultSupportTier tier)
	{
		//IL_0010: Expected O, but got I
		//IL_05cf: Expected O, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00b4: Expected O, but got I4
		//IL_0357: Expected O, but got I4
		//IL_0373: Expected O, but got I4
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_03b5: Expected O, but got I4
		//IL_0181: Expected O, but got I
		//IL_0199: Expected O, but got I
		//IL_0601: Expected O, but got I4
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected O, but got Unknown
		//IL_0641: Expected O, but got I4
		//IL_022a: Expected O, but got I
		//IL_066a: Expected O, but got I4
		//IL_0243: Expected I, but got O
		//IL_0251: Expected I, but got O
		//IL_01d0: Expected O, but got I
		//IL_01e4: Expected I, but got O
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I4
		//IL_010d: Expected O, but got I4
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_0282: Expected O, but got I4
		//IL_0200: Expected I, but got O
		//IL_0560: Expected O, but got I
		//IL_00cc: Expected I, but got O
		//IL_057f: Expected O, but got I4
		//IL_0584: Expected I, but got O
		//IL_0443: Expected O, but got I
		//IL_0457: Expected I, but got O
		//IL_04ca: Expected O, but got I4
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85C0]");
		GameObject[] array = (GameObject[])0;
		GameObject[] array2 = tierObjects;
		bool flag = tierObjects == null;
		VaultSupportTier vaultSupportTier2 = default(VaultSupportTier);
		VaultSupportTier vaultSupportTier = vaultSupportTier2;
		UnityEngine.Object obj = (UnityEngine.Object)152993792;
		VaultSupportTier vaultSupportTier3 = vaultSupportTier2;
		object obj2;
		nint num = default(nint);
		object obj4;
		object obj5 = default(object);
		object obj6;
		object obj7 = default(object);
		VaultSupportTier vaultSupportTier4;
		object obj12 = default(object);
		bool flag9;
		object obj11;
		IntPtr intPtr;
		if (!flag)
		{
			obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			bool flag2 = array2.Length < 1;
			object obj3 = !flag2;
			bool flag3 = array2.Length < 1;
			intPtr = num;
			obj4 = obj5;
			obj6 = obj7;
			vaultSupportTier4 = vaultSupportTier2;
			if (flag3)
			{
				goto IL_031b;
			}
			obj5 = tierObjects + 32;
			nint num2 = num;
			VaultSupportTier vaultSupportTier5 = vaultSupportTier2;
			object obj8 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X25_v5+v92 @ X24_v8*8]");
				obj = (UnityEngine.Object)0;
				object obj9 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v19+E4]");
				array = (GameObject[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X25_v5+v92 @ X24_v8*8]");
					bool flag4 = (UnityEngine.Object)0 != null;
					bool flag5 = !flag4;
					num2 = unchecked((nint)null);
					vaultSupportTier5 = VaultSupportTier.Tier1;
					if (flag5)
					{
						goto IL_00da;
					}
					num = unchecked((nint)null);
					vaultSupportTier = VaultSupportTier.Tier1;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X25_v5+v92 @ X24_v8*8]");
					bool flag6 = (UnityEngine.Object)0 != null;
					bool flag7 = !flag6;
					num2 = unchecked((nint)null);
					vaultSupportTier5 = VaultSupportTier.Tier1;
					num = unchecked((nint)null);
					vaultSupportTier = VaultSupportTier.Tier1;
					if (flag7)
					{
						goto IL_00da;
					}
				}
				bool flag8 = (object)obj == null;
				object obj10 = !flag8;
				obj7 = obj8;
				flag9 = flag3;
				obj11 = obj3;
				obj12 = obj2;
				vaultSupportTier3 = vaultSupportTier2;
				if (obj10 != null)
				{
					((GameObject)obj).SetActive(value: false);
					num2 = unchecked((nint)null);
					vaultSupportTier5 = VaultSupportTier.Tier1;
					goto IL_00da;
				}
				break;
				IL_00da:
				obj8++;
				array = (GameObject[])array2.Length;
				bool flag10 = (nint)obj8 < array2.Length;
				obj3 = !flag10;
				flag3 = (nint)obj8 >= array2.Length;
				num = num2;
				vaultSupportTier = vaultSupportTier5;
				obj7 = obj8;
				flag9 = flag3;
				obj11 = obj3;
				obj12 = obj2;
				vaultSupportTier3 = vaultSupportTier2;
				if (!flag3)
				{
					continue;
				}
				goto IL_02ca;
			}
		}
		goto IL_02bc;
		IL_031b:
		if (array2.Length == 0)
		{
			return;
		}
		VaultSupportTier vaultSupportTier6 = (VaultSupportTier)(array2.Length - 1);
		object obj13 = vaultSupportTier4 - vaultSupportTier6;
		bool flag11 = (nint)obj13 < 0;
		object obj14 = vaultSupportTier4 ^ vaultSupportTier6;
		object obj15 = vaultSupportTier4 ^ obj13;
		object obj16 = obj14 & obj15;
		bool flag12 = (nint)obj16 < 0;
		bool flag13 = flag11 == flag12;
		object obj17 = !flag13;
		object obj18 = ~obj17;
		if (obj18 == null)
		{
			vaultSupportTier6 = vaultSupportTier4;
		}
		bool flag14 = vaultSupportTier4 < VaultSupportTier.Tier1;
		object obj19 = vaultSupportTier4 ^ vaultSupportTier4;
		object obj20 = vaultSupportTier4 & obj19;
		bool flag15 = (nint)obj20 < 0;
		bool flag16 = flag14 == flag15;
		flag9 = !flag16;
		object obj21 = !flag9;
		if (obj21 == null)
		{
			vaultSupportTier6 = VaultSupportTier.Tier1;
		}
		bool flag17 = (int)vaultSupportTier6 < array2.Length;
		obj11 = !flag17;
		if (obj11 == null)
		{
			object obj22 = array2 + vaultSupportTier6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v7+20]");
			vaultSupportTier3 = VaultSupportTier.Tier1;
			object obj23 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v7+20]");
				bool flag18 = (UnityEngine.Object)0 != null;
				bool flag19 = !flag18;
				num = unchecked((nint)null);
				vaultSupportTier = VaultSupportTier.Tier1;
				if (flag19)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v7+20]");
				bool flag20 = (UnityEngine.Object)0 != null;
				bool flag21 = !flag20;
				object obj24 = !flag21;
				num = unchecked((nint)null);
				vaultSupportTier = VaultSupportTier.Tier1;
				if (obj24 == null)
				{
					return;
				}
			}
			array = tierObjects;
			bool flag22 = tierObjects == null;
			obj5 = obj4;
			obj7 = obj6;
			obj12 = obj2;
			if (!flag22)
			{
				bool flag23 = (int)vaultSupportTier6 < array.Length;
				obj11 = !flag23;
				if (obj11 != null)
				{
					goto IL_059c;
				}
				array = (GameObject[])(array + vaultSupportTier6);
				bool flag24 = (object)array[0] == null;
				obj5 = obj4;
				obj7 = obj6;
				obj12 = obj2;
				if (!flag24)
				{
					array[0].SetActive(value: true);
					return;
				}
			}
			goto IL_02bc;
		}
		goto IL_059c;
		IL_02bc:
		NullReferenceException ex = new NullReferenceException();
		goto IL_02ca;
		IL_02ca:
		array2 = tierObjects;
		bool flag25 = tierObjects == null;
		intPtr = num;
		obj4 = obj5;
		obj6 = obj7;
		obj2 = obj12;
		vaultSupportTier4 = vaultSupportTier3;
		if (flag25)
		{
			goto IL_02bc;
		}
		goto IL_031b;
		IL_059c:
		throw new IndexOutOfRangeException();
	}

	public ClanEventStrip_Donation()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
