using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UI;

public class ClanEventStrip_ClanUpgraded : ClanEventStrip
{
	private const string CLAN_UPGRADED_KEY = "clan_feed_your_clan_upgraded";

	private const string LEVEL_ORDINAL_KEY = "ORDINAL_LEVELS";

	private ClanTierSprites sprites;

	private Image clanTierImage;

	private ClanTierText clanTierText;

	public override void Initialize(ClanFeedModel model)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		ClanFeedData clanFeedData = model.Data;
		if (model.Data == null)
		{
			return;
		}
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1384;
		object obj2 = obj;
		nint num = (nint)clanFeedData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X10_v2 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v4+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X10_v2 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v4+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X10_v4-8]");
			if (0 == (nint)obj2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
				Populate(0);
			}
		}
	}

	private static string Level(int tier)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object input = "Network Authentication Required" + 3280;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return LocalizationUtil.LocalizeOrdinal((string)input, tier);
	}

	private void Populate(int level)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		//IL_064e: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I4
		//IL_0088: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		//IL_0142: Expected O, but got I4
		//IL_014b: Expected O, but got I4
		//IL_018e: Expected I, but got O
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0399: Expected O, but got I4
		//IL_03a7: Expected O, but got I4
		//IL_02aa: Expected O, but got I4
		//IL_02b3: Expected O, but got I4
		//IL_02c1: Expected O, but got I4
		//IL_0309: Expected I4, but got O
		//IL_03d8: Expected O, but got I4
		//IL_0483: Expected O, but got I4
		//IL_0345: Expected O, but got I4
		//IL_034e: Expected O, but got I4
		//IL_0429: Expected O, but got I4
		//IL_0432: Expected O, but got I4
		//IL_05b7: Expected O, but got I4
		//IL_05c0: Expected O, but got I4
		//IL_04e7: Expected O, but got I4
		//IL_0518: Expected O, but got I4
		//IL_0553: Expected O, but got I4
		//IL_055c: Expected O, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86D8]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object input;
		if (obj3 != null)
		{
			obj4 = "Network Authentication Required" + 3280;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v49+E4]");
			bool flag = (nint)0 == 0;
			input = obj4;
			if (!flag)
			{
				goto IL_005d;
			}
		}
		else
		{
			_ = 1;
			obj4 = "Network Authentication Required" + 3280;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v49+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			input = obj4;
			if (obj6 != null)
			{
				goto IL_005d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int num = default(int);
		string text = LocalizationUtil.LocalizeOrdinal((string)input, num);
		object[] array = default(object[]);
		bool flag3 = array == null;
		object obj7 = 0;
		object obj8 = 0;
		int num2 = num;
		if (!flag3)
		{
			goto IL_0161;
		}
		goto IL_05d8;
		IL_05e6:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		obj7 = obj8;
		int num3 = num2;
		goto IL_0604;
		IL_05d8:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_05e6;
		IL_02d8:
		UnityEngine.Object obj9 = clanTierImage;
		object obj11;
		object obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v14+E4]");
		bool flag4 = (nint)0 == 0;
		UnityEngine.Object obj12;
		int num4 = (int)obj12;
		UnityEngine.Object obj13 = clanTierImage;
		if (!flag4)
		{
			goto IL_0321;
		}
		goto IL_0452;
		IL_005d:
		text = LocalizationUtil.LocalizeOrdinal((string)obj4, num);
		bool flag5 = array == null;
		object obj14 = !flag5;
		obj7 = 0;
		if (obj14 != null)
		{
			goto IL_0161;
		}
		obj8 = 0;
		num2 = num;
		goto IL_05d8;
		IL_0161:
		bool flag6 = text == null;
		num2 = num;
		if (!flag6)
		{
			nint num5 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag7 = ex == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v18 (Il2CppClass<System.Object[]>)+40]");
			num3 = 0;
			if (flag7)
			{
				goto IL_0604;
			}
		}
		bool flag8 = array.Length == 0;
		obj8 = obj7;
		object obj20;
		if (!flag8)
		{
			object obj15 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3624;
			obj11 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj16 = array + 32;
			obj16 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			TextMeshProExtensions.Localize(base.text, (string)obj15, array);
			object obj17 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v10+E4]");
			if ((nint)0 != 0)
			{
				bool flag9 = clanTierText != null;
				bool flag10 = !flag9;
				object obj18 = !flag10;
				object obj19 = 0;
				obj12 = null;
				obj8 = 0;
				num2 = 0;
				if (obj18 == null)
				{
					goto IL_02d8;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag11 = clanTierText != null;
				bool flag12 = !flag11;
				object obj19 = 0;
				obj12 = null;
				obj8 = 0;
				num2 = 0;
				if (flag12)
				{
					goto IL_02d8;
				}
			}
			bool flag13 = (object)clanTierText == null;
			obj20 = 0;
			if (!flag13)
			{
				clanTierText.SetTier(num);
				obj9 = clanTierImage;
				obj10 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v14+E4]");
				bool flag14 = (nint)0 == 0;
				object obj21 = !flag14;
				object obj19 = 0;
				num4 = num;
				obj13 = clanTierImage;
				if (obj21 != null)
				{
					goto IL_0321;
				}
				goto IL_0452;
			}
			goto IL_05d8;
		}
		goto IL_05e6;
		IL_0321:
		bool flag15 = obj9 != null;
		bool flag16 = !flag15;
		object obj22 = !flag16;
		object obj23 = 0;
		UnityEngine.Object obj24 = null;
		if (obj22 == null)
		{
			return;
		}
		goto IL_0496;
		IL_0452:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag17 = obj13 != null;
		bool flag18 = !flag17;
		obj23 = 0;
		obj24 = null;
		if (!flag18)
		{
			goto IL_0496;
		}
		return;
		IL_0496:
		object obj25 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v13+E4]");
		if ((nint)0 != 0)
		{
			bool flag19 = sprites != null;
			bool flag20 = !flag19;
			obj8 = 0;
			num2 = 0;
			if (flag20)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag21 = sprites != null;
			bool flag22 = !flag21;
			object obj26 = !flag22;
			obj8 = 0;
			num2 = 0;
			if (obj26 == null)
			{
				return;
			}
		}
		bool flag23 = (object)sprites == null;
		obj20 = 0;
		if (!flag23)
		{
			Sprite sprite = sprites.GetSprite(num);
			bool flag24 = (object)clanTierImage == null;
			obj20 = 0;
			obj8 = 0;
			num2 = num;
			if (!flag24)
			{
				clanTierImage.sprite = sprite;
				return;
			}
		}
		goto IL_05d8;
		IL_0604:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	public ClanEventStrip_ClanUpgraded()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
