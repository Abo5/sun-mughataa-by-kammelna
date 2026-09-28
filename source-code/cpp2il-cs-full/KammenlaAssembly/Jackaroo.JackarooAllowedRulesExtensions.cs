using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;

namespace Jackaroo;

public static class JackarooAllowedRulesExtensions
{
	public static List<string> GetActiveRulesStrings(JackarooAllowedRules @this)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Expected O, but got I4
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_016c: Expected O, but got I4
		//IL_03aa: Expected O, but got I4
		//IL_05b7: Expected O, but got I4
		//IL_24f0: Expected O, but got I4
		//IL_07c4: Expected O, but got I4
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_007d: Expected O, but got I
		//IL_09d1: Expected O, but got I4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01c9: Expected O, but got I
		//IL_2530: Unknown result type (might be due to invalid IL or missing references)
		//IL_2535: Expected O, but got Unknown
		//IL_253e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2543: Expected O, but got Unknown
		//IL_0bde: Expected O, but got I4
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_0407: Expected O, but got I
		//IL_00f4: Expected O, but got I4
		//IL_0deb: Expected O, but got I4
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected O, but got Unknown
		//IL_0614: Expected O, but got I
		//IL_0240: Expected O, but got I4
		//IL_0329: Expected O, but got I
		//IL_0339: Expected O, but got I
		//IL_0349: Expected O, but got I
		//IL_0364: Expected O, but got I4
		//IL_037e: Expected O, but got I4
		//IL_038e: Expected O, but got I
		//IL_0ff8: Expected O, but got I4
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected O, but got Unknown
		//IL_0821: Expected O, but got I
		//IL_047e: Expected O, but got I4
		//IL_0536: Expected O, but got I
		//IL_0546: Expected O, but got I
		//IL_0556: Expected O, but got I
		//IL_0571: Expected O, but got I4
		//IL_058b: Expected O, but got I4
		//IL_059b: Expected O, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_1205: Expected O, but got I4
		//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a22: Expected O, but got Unknown
		//IL_0a2e: Expected O, but got I
		//IL_068b: Expected O, but got I4
		//IL_0743: Expected O, but got I
		//IL_0753: Expected O, but got I
		//IL_0763: Expected O, but got I
		//IL_077e: Expected O, but got I4
		//IL_0798: Expected O, but got I4
		//IL_07a8: Expected O, but got I
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_02b3: Expected O, but got I4
		//IL_02cd: Expected O, but got I4
		//IL_1412: Expected O, but got I4
		//IL_0c2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2f: Expected O, but got Unknown
		//IL_0c3b: Expected O, but got I
		//IL_0898: Expected O, but got I4
		//IL_0950: Expected O, but got I
		//IL_0960: Expected O, but got I
		//IL_0970: Expected O, but got I
		//IL_098b: Expected O, but got I4
		//IL_09a5: Expected O, but got I4
		//IL_09b5: Expected O, but got I
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected O, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_04f1: Expected O, but got I4
		//IL_050b: Expected O, but got I4
		//IL_161f: Expected O, but got I4
		//IL_0e37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3c: Expected O, but got Unknown
		//IL_0e48: Expected O, but got I
		//IL_0aa5: Expected O, but got I4
		//IL_0b5d: Expected O, but got I
		//IL_0b6d: Expected O, but got I
		//IL_0b7d: Expected O, but got I
		//IL_0b98: Expected O, but got I4
		//IL_0bb2: Expected O, but got I4
		//IL_0bc2: Expected O, but got I
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Expected O, but got Unknown
		//IL_06d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected O, but got Unknown
		//IL_06fe: Expected O, but got I4
		//IL_0718: Expected O, but got I4
		//IL_182c: Expected O, but got I4
		//IL_1044: Unknown result type (might be due to invalid IL or missing references)
		//IL_1049: Expected O, but got Unknown
		//IL_1055: Expected O, but got I
		//IL_0cb2: Expected O, but got I4
		//IL_0d6a: Expected O, but got I
		//IL_0d7a: Expected O, but got I
		//IL_0d8a: Expected O, but got I
		//IL_0da5: Expected O, but got I4
		//IL_0dbf: Expected O, but got I4
		//IL_0dcf: Expected O, but got I
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected O, but got Unknown
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Expected O, but got Unknown
		//IL_090b: Expected O, but got I4
		//IL_0925: Expected O, but got I4
		//IL_1a39: Expected O, but got I4
		//IL_1251: Unknown result type (might be due to invalid IL or missing references)
		//IL_1256: Expected O, but got Unknown
		//IL_1262: Expected O, but got I
		//IL_0ebf: Expected O, but got I4
		//IL_0f77: Expected O, but got I
		//IL_0f87: Expected O, but got I
		//IL_0f97: Expected O, but got I
		//IL_0fb2: Expected O, but got I4
		//IL_0fcc: Expected O, but got I4
		//IL_0fdc: Expected O, but got I
		//IL_0ae5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aea: Expected O, but got Unknown
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af8: Expected O, but got Unknown
		//IL_0b18: Expected O, but got I4
		//IL_0b32: Expected O, but got I4
		//IL_1c46: Expected O, but got I4
		//IL_145e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1463: Expected O, but got Unknown
		//IL_146f: Expected O, but got I
		//IL_10cc: Expected O, but got I4
		//IL_1184: Expected O, but got I
		//IL_1194: Expected O, but got I
		//IL_11a4: Expected O, but got I
		//IL_11bf: Expected O, but got I4
		//IL_11d9: Expected O, but got I4
		//IL_11e9: Expected O, but got I
		//IL_0cf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf7: Expected O, but got Unknown
		//IL_0d00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d05: Expected O, but got Unknown
		//IL_0d25: Expected O, but got I4
		//IL_0d3f: Expected O, but got I4
		//IL_1e53: Expected O, but got I4
		//IL_166b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1670: Expected O, but got Unknown
		//IL_167c: Expected O, but got I
		//IL_12d9: Expected O, but got I4
		//IL_1391: Expected O, but got I
		//IL_13a1: Expected O, but got I
		//IL_13b1: Expected O, but got I
		//IL_13cc: Expected O, but got I4
		//IL_13e6: Expected O, but got I4
		//IL_13f6: Expected O, but got I
		//IL_0eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f04: Expected O, but got Unknown
		//IL_0f0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f12: Expected O, but got Unknown
		//IL_0f32: Expected O, but got I4
		//IL_0f4c: Expected O, but got I4
		//IL_2060: Expected O, but got I4
		//IL_1878: Unknown result type (might be due to invalid IL or missing references)
		//IL_187d: Expected O, but got Unknown
		//IL_1889: Expected O, but got I
		//IL_14e6: Expected O, but got I4
		//IL_159e: Expected O, but got I
		//IL_15ae: Expected O, but got I
		//IL_15be: Expected O, but got I
		//IL_15d9: Expected O, but got I4
		//IL_15f3: Expected O, but got I4
		//IL_1603: Expected O, but got I
		//IL_110c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1111: Expected O, but got Unknown
		//IL_111a: Unknown result type (might be due to invalid IL or missing references)
		//IL_111f: Expected O, but got Unknown
		//IL_113f: Expected O, but got I4
		//IL_1159: Expected O, but got I4
		//IL_226d: Expected O, but got I4
		//IL_1a85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8a: Expected O, but got Unknown
		//IL_1a96: Expected O, but got I
		//IL_16f3: Expected O, but got I4
		//IL_17ab: Expected O, but got I
		//IL_17bb: Expected O, but got I
		//IL_17cb: Expected O, but got I
		//IL_17e6: Expected O, but got I4
		//IL_1800: Expected O, but got I4
		//IL_1810: Expected O, but got I
		//IL_1319: Unknown result type (might be due to invalid IL or missing references)
		//IL_131e: Expected O, but got Unknown
		//IL_1327: Unknown result type (might be due to invalid IL or missing references)
		//IL_132c: Expected O, but got Unknown
		//IL_134c: Expected O, but got I4
		//IL_1366: Expected O, but got I4
		//IL_247a: Expected O, but got I4
		//IL_1c92: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c97: Expected O, but got Unknown
		//IL_1ca3: Expected O, but got I
		//IL_1900: Expected O, but got I4
		//IL_19b8: Expected O, but got I
		//IL_19c8: Expected O, but got I
		//IL_19d8: Expected O, but got I
		//IL_19f3: Expected O, but got I4
		//IL_1a0d: Expected O, but got I4
		//IL_1a1d: Expected O, but got I
		//IL_1526: Unknown result type (might be due to invalid IL or missing references)
		//IL_152b: Expected O, but got Unknown
		//IL_1534: Unknown result type (might be due to invalid IL or missing references)
		//IL_1539: Expected O, but got Unknown
		//IL_1559: Expected O, but got I4
		//IL_1573: Expected O, but got I4
		//IL_1e9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ea4: Expected O, but got Unknown
		//IL_1eb0: Expected O, but got I
		//IL_1b0d: Expected O, but got I4
		//IL_1bc5: Expected O, but got I
		//IL_1bd5: Expected O, but got I
		//IL_1be5: Expected O, but got I
		//IL_1c00: Expected O, but got I4
		//IL_1c1a: Expected O, but got I4
		//IL_1c2a: Expected O, but got I
		//IL_1733: Unknown result type (might be due to invalid IL or missing references)
		//IL_1738: Expected O, but got Unknown
		//IL_1741: Unknown result type (might be due to invalid IL or missing references)
		//IL_1746: Expected O, but got Unknown
		//IL_1766: Expected O, but got I4
		//IL_1780: Expected O, but got I4
		//IL_20ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b1: Expected O, but got Unknown
		//IL_20bd: Expected O, but got I
		//IL_1d1a: Expected O, but got I4
		//IL_1dd2: Expected O, but got I
		//IL_1de2: Expected O, but got I
		//IL_1df2: Expected O, but got I
		//IL_1e0d: Expected O, but got I4
		//IL_1e27: Expected O, but got I4
		//IL_1e37: Expected O, but got I
		//IL_1940: Unknown result type (might be due to invalid IL or missing references)
		//IL_1945: Expected O, but got Unknown
		//IL_194e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1953: Expected O, but got Unknown
		//IL_1973: Expected O, but got I4
		//IL_198d: Expected O, but got I4
		//IL_22b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_22be: Expected O, but got Unknown
		//IL_22ca: Expected O, but got I
		//IL_1f27: Expected O, but got I4
		//IL_1fdf: Expected O, but got I
		//IL_1fef: Expected O, but got I
		//IL_1fff: Expected O, but got I
		//IL_201a: Expected O, but got I4
		//IL_2034: Expected O, but got I4
		//IL_2044: Expected O, but got I
		//IL_1b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b52: Expected O, but got Unknown
		//IL_1b5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b60: Expected O, but got Unknown
		//IL_1b80: Expected O, but got I4
		//IL_1b9a: Expected O, but got I4
		//IL_24be: Unknown result type (might be due to invalid IL or missing references)
		//IL_24c3: Expected O, but got Unknown
		//IL_2134: Expected O, but got I4
		//IL_21ec: Expected O, but got I
		//IL_21fc: Expected O, but got I
		//IL_220c: Expected O, but got I
		//IL_2227: Expected O, but got I4
		//IL_2241: Expected O, but got I4
		//IL_2251: Expected O, but got I
		//IL_1d5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5f: Expected O, but got Unknown
		//IL_1d68: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d6d: Expected O, but got Unknown
		//IL_1d8d: Expected O, but got I4
		//IL_1da7: Expected O, but got I4
		//IL_2341: Expected O, but got I4
		//IL_23f9: Expected O, but got I
		//IL_2409: Expected O, but got I
		//IL_2419: Expected O, but got I
		//IL_2434: Expected O, but got I4
		//IL_244e: Expected O, but got I4
		//IL_245e: Expected O, but got I
		//IL_1f67: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f6c: Expected O, but got Unknown
		//IL_1f75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f7a: Expected O, but got Unknown
		//IL_1f9a: Expected O, but got I4
		//IL_1fb4: Expected O, but got I4
		//IL_2583: Expected O, but got I
		//IL_2593: Expected O, but got I
		//IL_25a3: Expected O, but got I
		//IL_25be: Expected O, but got I4
		//IL_25d8: Expected O, but got I4
		//IL_2174: Unknown result type (might be due to invalid IL or missing references)
		//IL_2179: Expected O, but got Unknown
		//IL_2182: Unknown result type (might be due to invalid IL or missing references)
		//IL_2187: Expected O, but got Unknown
		//IL_21a7: Expected O, but got I4
		//IL_21c1: Expected O, but got I4
		//IL_2381: Unknown result type (might be due to invalid IL or missing references)
		//IL_2386: Expected O, but got Unknown
		//IL_238f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2394: Expected O, but got Unknown
		//IL_23b4: Expected O, but got I4
		//IL_23ce: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj14;
		object obj15;
		object obj11 = default(object);
		if (@this != JackarooAllowedRules.DEFAULT)
		{
			object obj2 = @this & JackarooAllowedRules.ACE_MOVE_1_PLANT;
			if (obj2 == null)
			{
				goto IL_015e;
			}
			if (list != null)
			{
				object obj3 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2232;
				object obj4 = (nint)0 + (nint)3072;
				object obj5 = obj4;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				if (list._items != null)
				{
					bool flag = list._size < items.Length;
					object obj6 = !flag;
					if (obj6 == null)
					{
						int size = list._size + 1;
						list._size = size;
						object obj7 = list._items + list._size;
						object obj8 = obj7 + 32;
						obj8 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						goto IL_015e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v154+20]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v155+C0]");
					object obj10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v156+70]");
					obj11 = 0;
					list.AddWithResize(obj3);
					object obj12 = @this & JackarooAllowedRules.KING_BLACK_PLANT_MOVE_NO_KILL;
					bool flag2 = obj12 == null;
					object obj13 = !flag2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v156+70]");
					obj14 = 0;
					if (obj13 != null)
					{
						goto IL_0191;
					}
					goto IL_039c;
				}
			}
		}
		else if (list != null)
		{
			obj15 = "Complete" + 3832;
			goto IL_2629;
		}
		goto IL_25eb;
		IL_246c:
		object obj16 = @this & JackarooAllowedRules.DISABLE_SAME_COLOR_MARBLE_BLOCK;
		if (obj16 != null)
		{
			goto IL_2497;
		}
		goto IL_255a;
		IL_255a:
		return (List<string>)(object)list;
		IL_0c03:
		if (list != null)
		{
			object obj17 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3496;
			object obj18 = (nint)0 + (nint)3072;
			object obj19 = obj18;
			int version2 = list._version + 1;
			list._version = version2;
			object[] items2 = list._items;
			if (list._items != null)
			{
				bool flag3 = list._size < items2.Length;
				object obj20 = !flag3;
				if (obj20 == null)
				{
					int size2 = list._size + 1;
					list._size = size2;
					object obj21 = list._items + list._size;
					object obj22 = obj21 + 32;
					obj22 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj23 = @this & JackarooAllowedRules.QUEEN_BLACK_BURN;
					bool flag4 = obj23 == null;
					object obj24 = !flag4;
					obj11 = obj14;
					if (obj24 != null)
					{
						goto IL_0e10;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v107+20]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X8_v108+C0]");
					object obj26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X8_v109+70]");
					obj11 = 0;
					list.AddWithResize(obj17);
					object obj27 = @this & JackarooAllowedRules.QUEEN_BLACK_BURN;
					bool flag5 = obj27 == null;
					object obj28 = !flag5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v934 @ X8_v109+70]");
					obj14 = 0;
					if (obj28 != null)
					{
						goto IL_0e10;
					}
				}
				goto IL_0fea;
			}
		}
		goto IL_25eb;
		IL_2629:
		int version3 = list._version + 1;
		list._version = version3;
		object[] items3 = list._items;
		if (list._items != null)
		{
			bool flag6 = list._size < items3.Length;
			object obj29 = !flag6;
			if (obj29 == null)
			{
				int size3 = list._size + 1;
				list._size = size3;
				object obj30 = list._items + list._size;
				object obj31 = obj30 + 32;
				obj31 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				goto IL_255a;
			}
			list.AddWithResize(obj15);
			return (List<string>)(object)list;
		}
		goto IL_25eb;
		IL_181e:
		object obj32 = @this & JackarooAllowedRules.JACK_RED_SWAP;
		bool flag7 = obj32 == null;
		obj11 = obj14;
		if (!flag7)
		{
			goto IL_1851;
		}
		goto IL_1a2b;
		IL_1611:
		object obj33 = @this & JackarooAllowedRules.JACK_BLACK_MOVE;
		bool flag8 = obj33 == null;
		obj14 = obj11;
		if (!flag8)
		{
			goto IL_1644;
		}
		goto IL_181e;
		IL_0fea:
		object obj34 = @this & JackarooAllowedRules.QUEEN_BLACK_STEAL;
		bool flag9 = obj34 == null;
		obj11 = obj14;
		if (!flag9)
		{
			goto IL_101d;
		}
		goto IL_11f7;
		IL_0ddd:
		object obj35 = @this & JackarooAllowedRules.QUEEN_BLACK_BURN;
		bool flag10 = obj35 == null;
		obj14 = obj11;
		if (!flag10)
		{
			goto IL_0e10;
		}
		goto IL_0fea;
		IL_015e:
		object obj36 = @this & JackarooAllowedRules.KING_BLACK_PLANT_MOVE_NO_KILL;
		bool flag11 = obj36 == null;
		obj14 = obj11;
		if (!flag11)
		{
			goto IL_0191;
		}
		goto IL_039c;
		IL_039c:
		object obj37 = @this & JackarooAllowedRules.KING_BLACK_MOVE_EAT_PATH;
		bool flag12 = obj37 == null;
		obj11 = obj14;
		if (!flag12)
		{
			goto IL_03cf;
		}
		goto IL_05a9;
		IL_0191:
		if (list != null)
		{
			object obj38 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3480;
			object obj39 = (nint)0 + (nint)3072;
			object obj40 = obj39;
			int version4 = list._version + 1;
			list._version = version4;
			object[] items4 = list._items;
			if (list._items != null)
			{
				bool flag13 = list._size < items4.Length;
				object obj41 = !flag13;
				if (obj41 == null)
				{
					int size4 = list._size + 1;
					list._size = size4;
					object obj42 = list._items + list._size;
					object obj43 = obj42 + 32;
					obj43 = obj38;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj44 = @this & JackarooAllowedRules.KING_BLACK_MOVE_EAT_PATH;
					bool flag14 = obj44 == null;
					object obj45 = !flag14;
					obj14 = obj11;
					if (obj45 != null)
					{
						goto IL_03cf;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v147+20]");
					object obj46 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X8_v148+C0]");
					object obj47 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v149+70]");
					obj14 = 0;
					list.AddWithResize(obj38);
					object obj48 = @this & JackarooAllowedRules.KING_BLACK_MOVE_EAT_PATH;
					bool flag15 = obj48 == null;
					object obj49 = !flag15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X8_v149+70]");
					obj11 = 0;
					if (obj49 != null)
					{
						goto IL_03cf;
					}
				}
				goto IL_05a9;
			}
		}
		goto IL_25eb;
		IL_0e10:
		if (list != null)
		{
			object obj50 = "Picking audio files is not supported on iOS" + 2960;
			object obj51 = (nint)0 + (nint)3072;
			object obj52 = obj51;
			int version5 = list._version + 1;
			list._version = version5;
			object[] items5 = list._items;
			if (list._items != null)
			{
				bool flag16 = list._size < items5.Length;
				object obj53 = !flag16;
				if (obj53 == null)
				{
					int size5 = list._size + 1;
					list._size = size5;
					object obj54 = list._items + list._size;
					object obj55 = obj54 + 32;
					obj55 = obj50;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj56 = @this & JackarooAllowedRules.QUEEN_BLACK_STEAL;
					bool flag17 = obj56 == null;
					object obj57 = !flag17;
					obj14 = obj11;
					if (obj57 != null)
					{
						goto IL_101d;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v99+20]");
					object obj58 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1068 @ X8_v100+C0]");
					object obj59 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X8_v101+70]");
					obj14 = 0;
					list.AddWithResize(obj50);
					object obj60 = @this & JackarooAllowedRules.QUEEN_BLACK_STEAL;
					bool flag18 = obj60 == null;
					object obj61 = !flag18;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v987 @ X8_v101+70]");
					obj11 = 0;
					if (obj61 != null)
					{
						goto IL_101d;
					}
				}
				goto IL_11f7;
			}
		}
		goto IL_25eb;
		IL_1644:
		if (list != null)
		{
			object obj62 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2728;
			object obj63 = (nint)0 + (nint)3072;
			object obj64 = obj63;
			int version6 = list._version + 1;
			list._version = version6;
			object[] items6 = list._items;
			if (list._items != null)
			{
				bool flag19 = list._size < items6.Length;
				object obj65 = !flag19;
				if (obj65 == null)
				{
					int size6 = list._size + 1;
					list._size = size6;
					object obj66 = list._items + list._size;
					object obj67 = obj66 + 32;
					obj67 = obj62;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj68 = @this & JackarooAllowedRules.JACK_RED_SWAP;
					bool flag20 = obj68 == null;
					object obj69 = !flag20;
					obj14 = obj11;
					if (obj69 != null)
					{
						goto IL_1851;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v67+20]");
					object obj70 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1280 @ X8_v68+C0]");
					object obj71 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1199 @ X8_v69+70]");
					obj14 = 0;
					list.AddWithResize(obj62);
					object obj72 = @this & JackarooAllowedRules.JACK_RED_SWAP;
					bool flag21 = obj72 == null;
					object obj73 = !flag21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1199 @ X8_v69+70]");
					obj11 = 0;
					if (obj73 != null)
					{
						goto IL_1851;
					}
				}
				goto IL_1a2b;
			}
		}
		goto IL_25eb;
		IL_2085:
		if (list != null)
		{
			object obj74 = "AvailableVoices" + 560;
			object obj75 = (nint)0 + (nint)3072;
			object obj76 = obj75;
			int version7 = list._version + 1;
			list._version = version7;
			object[] items7 = list._items;
			if (list._items != null)
			{
				bool flag22 = list._size < items7.Length;
				object obj77 = !flag22;
				if (obj77 == null)
				{
					int size7 = list._size + 1;
					list._size = size7;
					object obj78 = list._items + list._size;
					object obj79 = obj78 + 32;
					obj79 = obj74;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj80 = @this & JackarooAllowedRules.DISABLE_BLOCKED_BY_TWO_CONSECUTIVE_MARBLES;
					bool flag23 = obj80 == null;
					object obj81 = !flag23;
					obj11 = obj14;
					if (obj81 != null)
					{
						goto IL_2292;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v27+20]");
					object obj82 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1490 @ X8_v28+C0]");
					object obj83 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1464 @ X8_v29+70]");
					obj11 = 0;
					list.AddWithResize(obj74);
					object obj84 = @this & JackarooAllowedRules.DISABLE_BLOCKED_BY_TWO_CONSECUTIVE_MARBLES;
					bool flag24 = obj84 == null;
					object obj85 = !flag24;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1464 @ X8_v29+70]");
					obj14 = 0;
					if (obj85 != null)
					{
						goto IL_2292;
					}
				}
				goto IL_246c;
			}
		}
		goto IL_25eb;
		IL_2497:
		if (list == null)
		{
			goto IL_25eb;
		}
		obj15 = "Complete" + 4024;
		obj11 = obj14;
		goto IL_2629;
		IL_03cf:
		if (list != null)
		{
			object obj86 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3456;
			object obj87 = (nint)0 + (nint)3072;
			object obj88 = obj87;
			int version8 = list._version + 1;
			list._version = version8;
			object[] items8 = list._items;
			if (list._items != null)
			{
				bool flag25 = list._size < items8.Length;
				object obj89 = !flag25;
				if (obj89 == null)
				{
					int size8 = list._size + 1;
					list._size = size8;
					object obj90 = list._items + list._size;
					object obj91 = obj90 + 32;
					obj91 = obj86;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj92 = @this & JackarooAllowedRules.KING_BLACK_PLANT;
					bool flag26 = obj92 == null;
					object obj93 = !flag26;
					obj11 = obj14;
					if (obj93 != null)
					{
						goto IL_05dc;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v139+20]");
					object obj94 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X8_v140+C0]");
					object obj95 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v141+70]");
					obj11 = 0;
					list.AddWithResize(obj86);
					object obj96 = @this & JackarooAllowedRules.KING_BLACK_PLANT;
					bool flag27 = obj96 == null;
					object obj97 = !flag27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v141+70]");
					obj14 = 0;
					if (obj97 != null)
					{
						goto IL_05dc;
					}
				}
				goto IL_07b6;
			}
		}
		goto IL_25eb;
		IL_1c6b:
		if (list != null)
		{
			object obj98 = "Complete" + 4016;
			object obj99 = (nint)0 + (nint)3072;
			object obj100 = obj99;
			int version9 = list._version + 1;
			list._version = version9;
			object[] items9 = list._items;
			if (list._items != null)
			{
				bool flag28 = list._size < items9.Length;
				object obj101 = !flag28;
				if (obj101 == null)
				{
					int size9 = list._size + 1;
					list._size = size9;
					object obj102 = list._items + list._size;
					object obj103 = obj102 + 32;
					obj103 = obj98;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj104 = @this & JackarooAllowedRules.DISABLE_BASE_ENTRY_BLOCKING;
					bool flag29 = obj104 == null;
					object obj105 = !flag29;
					obj11 = obj14;
					if (obj105 != null)
					{
						goto IL_1e78;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v43+20]");
					object obj106 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1439 @ X8_v44+C0]");
					object obj107 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1358 @ X8_v45+70]");
					obj11 = 0;
					list.AddWithResize(obj98);
					object obj108 = @this & JackarooAllowedRules.DISABLE_BASE_ENTRY_BLOCKING;
					bool flag30 = obj108 == null;
					object obj109 = !flag30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1358 @ X8_v45+70]");
					obj14 = 0;
					if (obj109 != null)
					{
						goto IL_1e78;
					}
				}
				goto IL_2052;
			}
		}
		goto IL_25eb;
		IL_101d:
		if (list != null)
		{
			object obj110 = "Picking audio files is not supported on iOS" + 2976;
			object obj111 = (nint)0 + (nint)3072;
			object obj112 = obj111;
			int version10 = list._version + 1;
			list._version = version10;
			object[] items10 = list._items;
			if (list._items != null)
			{
				bool flag31 = list._size < items10.Length;
				object obj113 = !flag31;
				if (obj113 == null)
				{
					int size10 = list._size + 1;
					list._size = size10;
					object obj114 = list._items + list._size;
					object obj115 = obj114 + 32;
					obj115 = obj110;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj116 = @this & JackarooAllowedRules.QUEEN_RED_MOVE;
					bool flag32 = obj116 == null;
					object obj117 = !flag32;
					obj11 = obj14;
					if (obj117 != null)
					{
						goto IL_122a;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v91+20]");
					object obj118 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ X8_v92+C0]");
					object obj119 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v93+70]");
					obj11 = 0;
					list.AddWithResize(obj110);
					object obj120 = @this & JackarooAllowedRules.QUEEN_RED_MOVE;
					bool flag33 = obj120 == null;
					object obj121 = !flag33;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v93+70]");
					obj14 = 0;
					if (obj121 != null)
					{
						goto IL_122a;
					}
				}
				goto IL_1404;
			}
		}
		goto IL_25eb;
		IL_1851:
		if (list != null)
		{
			object obj122 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2752;
			object obj123 = (nint)0 + (nint)3072;
			object obj124 = obj123;
			int version11 = list._version + 1;
			list._version = version11;
			object[] items11 = list._items;
			if (list._items != null)
			{
				bool flag34 = list._size < items11.Length;
				object obj125 = !flag34;
				if (obj125 == null)
				{
					int size11 = list._size + 1;
					list._size = size11;
					object obj126 = list._items + list._size;
					object obj127 = obj126 + 32;
					obj127 = obj122;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj128 = @this & JackarooAllowedRules.TEN_MOVE;
					bool flag35 = obj128 == null;
					object obj129 = !flag35;
					obj11 = obj14;
					if (obj129 != null)
					{
						goto IL_1a5e;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X8_v59+20]");
					object obj130 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1333 @ X8_v60+C0]");
					object obj131 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v61+70]");
					obj11 = 0;
					list.AddWithResize(obj122);
					object obj132 = @this & JackarooAllowedRules.TEN_MOVE;
					bool flag36 = obj132 == null;
					object obj133 = !flag36;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v61+70]");
					obj14 = 0;
					if (obj133 != null)
					{
						goto IL_1a5e;
					}
				}
				goto IL_1c38;
			}
		}
		goto IL_25eb;
		IL_225f:
		object obj134 = @this & JackarooAllowedRules.DISABLE_BLOCKED_BY_TWO_CONSECUTIVE_MARBLES;
		bool flag37 = obj134 == null;
		obj14 = obj11;
		if (!flag37)
		{
			goto IL_2292;
		}
		goto IL_246c;
		IL_05a9:
		object obj135 = @this & JackarooAllowedRules.KING_BLACK_PLANT;
		bool flag38 = obj135 == null;
		obj14 = obj11;
		if (!flag38)
		{
			goto IL_05dc;
		}
		goto IL_07b6;
		IL_07b6:
		object obj136 = @this & JackarooAllowedRules.KING_RED_PLANT_MOVE_NO_KILL;
		bool flag39 = obj136 == null;
		obj11 = obj14;
		if (!flag39)
		{
			goto IL_07e9;
		}
		goto IL_09c3;
		IL_05dc:
		if (list != null)
		{
			object obj137 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3464;
			object obj138 = (nint)0 + (nint)3072;
			object obj139 = obj138;
			int version12 = list._version + 1;
			list._version = version12;
			object[] items12 = list._items;
			if (list._items != null)
			{
				bool flag40 = list._size < items12.Length;
				object obj140 = !flag40;
				if (obj140 == null)
				{
					int size12 = list._size + 1;
					list._size = size12;
					object obj141 = list._items + list._size;
					object obj142 = obj141 + 32;
					obj142 = obj137;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj143 = @this & JackarooAllowedRules.KING_RED_PLANT_MOVE_NO_KILL;
					bool flag41 = obj143 == null;
					object obj144 = !flag41;
					obj14 = obj11;
					if (obj144 != null)
					{
						goto IL_07e9;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v131+20]");
					object obj145 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X8_v132+C0]");
					object obj146 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v133+70]");
					obj14 = 0;
					list.AddWithResize(obj137);
					object obj147 = @this & JackarooAllowedRules.KING_RED_PLANT_MOVE_NO_KILL;
					bool flag42 = obj147 == null;
					object obj148 = !flag42;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v133+70]");
					obj11 = 0;
					if (obj148 != null)
					{
						goto IL_07e9;
					}
				}
				goto IL_09c3;
			}
		}
		goto IL_25eb;
		IL_2292:
		if (list != null)
		{
			object obj149 = "Complete" + 4008;
			object obj150 = (nint)0 + (nint)3072;
			object obj151 = obj150;
			int version13 = list._version + 1;
			list._version = version13;
			object[] items13 = list._items;
			if (list._items != null)
			{
				bool flag43 = list._size < items13.Length;
				object obj152 = !flag43;
				if (obj152 == null)
				{
					int size13 = list._size + 1;
					list._size = size13;
					object obj153 = list._items + list._size;
					object obj154 = obj153 + 32;
					obj154 = obj149;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj155 = @this & JackarooAllowedRules.DISABLE_SAME_COLOR_MARBLE_BLOCK;
					bool flag44 = obj155 == null;
					object obj156 = !flag44;
					obj14 = obj11;
					if (obj156 != null)
					{
						goto IL_2497;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v19+20]");
					object obj157 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1499 @ X8_v20+C0]");
					object obj158 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v21+70]");
					obj14 = 0;
					list.AddWithResize(obj149);
					object obj159 = @this & JackarooAllowedRules.DISABLE_SAME_COLOR_MARBLE_BLOCK;
					bool flag45 = obj159 == null;
					object obj160 = !flag45;
					if (obj160 != null)
					{
						goto IL_2497;
					}
				}
				goto IL_255a;
			}
		}
		goto IL_25eb;
		IL_25eb:
		return (List<string>)(object)new NullReferenceException();
		IL_1404:
		object obj161 = @this & JackarooAllowedRules.QUEEN_RED_STEAL;
		bool flag46 = obj161 == null;
		obj11 = obj14;
		if (!flag46)
		{
			goto IL_1437;
		}
		goto IL_1611;
		IL_11f7:
		object obj162 = @this & JackarooAllowedRules.QUEEN_RED_MOVE;
		bool flag47 = obj162 == null;
		obj14 = obj11;
		if (!flag47)
		{
			goto IL_122a;
		}
		goto IL_1404;
		IL_07e9:
		if (list != null)
		{
			object obj163 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3512;
			object obj164 = (nint)0 + (nint)3072;
			object obj165 = obj164;
			int version14 = list._version + 1;
			list._version = version14;
			object[] items14 = list._items;
			if (list._items != null)
			{
				bool flag48 = list._size < items14.Length;
				object obj166 = !flag48;
				if (obj166 == null)
				{
					int size14 = list._size + 1;
					list._size = size14;
					object obj167 = list._items + list._size;
					object obj168 = obj167 + 32;
					obj168 = obj163;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj169 = @this & JackarooAllowedRules.KING_RED_MOVE_EAT_PATH;
					bool flag49 = obj169 == null;
					object obj170 = !flag49;
					obj11 = obj14;
					if (obj170 != null)
					{
						goto IL_09f6;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v123+20]");
					object obj171 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ X8_v124+C0]");
					object obj172 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X8_v125+70]");
					obj11 = 0;
					list.AddWithResize(obj163);
					object obj173 = @this & JackarooAllowedRules.KING_RED_MOVE_EAT_PATH;
					bool flag50 = obj173 == null;
					object obj174 = !flag50;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X8_v125+70]");
					obj14 = 0;
					if (obj174 != null)
					{
						goto IL_09f6;
					}
				}
				goto IL_0bd0;
			}
		}
		goto IL_25eb;
		IL_122a:
		if (list != null)
		{
			object obj175 = "Picking audio files is not supported on iOS" + 2992;
			object obj176 = (nint)0 + (nint)3072;
			object obj177 = obj176;
			int version15 = list._version + 1;
			list._version = version15;
			object[] items15 = list._items;
			if (list._items != null)
			{
				bool flag51 = list._size < items15.Length;
				object obj178 = !flag51;
				if (obj178 == null)
				{
					int size15 = list._size + 1;
					list._size = size15;
					object obj179 = list._items + list._size;
					object obj180 = obj179 + 32;
					obj180 = obj175;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj181 = @this & JackarooAllowedRules.QUEEN_RED_STEAL;
					bool flag52 = obj181 == null;
					object obj182 = !flag52;
					obj14 = obj11;
					if (obj182 != null)
					{
						goto IL_1437;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v83+20]");
					object obj183 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1174 @ X8_v84+C0]");
					object obj184 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1093 @ X8_v85+70]");
					obj14 = 0;
					list.AddWithResize(obj175);
					object obj185 = @this & JackarooAllowedRules.QUEEN_RED_STEAL;
					bool flag53 = obj185 == null;
					object obj186 = !flag53;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1093 @ X8_v85+70]");
					obj11 = 0;
					if (obj186 != null)
					{
						goto IL_1437;
					}
				}
				goto IL_1611;
			}
		}
		goto IL_25eb;
		IL_2052:
		object obj187 = @this & JackarooAllowedRules.BLOCKED_BY_TWO_CONSECUTIVE_MARBLES_SAME_COLOR;
		bool flag54 = obj187 == null;
		obj11 = obj14;
		if (!flag54)
		{
			goto IL_2085;
		}
		goto IL_225f;
		IL_1c38:
		object obj188 = @this & JackarooAllowedRules.DISABLE_LAST_7_SHARED;
		bool flag55 = obj188 == null;
		obj11 = obj14;
		if (!flag55)
		{
			goto IL_1c6b;
		}
		goto IL_1e45;
		IL_1e45:
		object obj189 = @this & JackarooAllowedRules.DISABLE_BASE_ENTRY_BLOCKING;
		bool flag56 = obj189 == null;
		obj14 = obj11;
		if (!flag56)
		{
			goto IL_1e78;
		}
		goto IL_2052;
		IL_09c3:
		object obj190 = @this & JackarooAllowedRules.KING_RED_MOVE_EAT_PATH;
		bool flag57 = obj190 == null;
		obj14 = obj11;
		if (!flag57)
		{
			goto IL_09f6;
		}
		goto IL_0bd0;
		IL_0bd0:
		object obj191 = @this & JackarooAllowedRules.KING_RED_PLANT;
		bool flag58 = obj191 == null;
		obj11 = obj14;
		if (!flag58)
		{
			goto IL_0c03;
		}
		goto IL_0ddd;
		IL_09f6:
		if (list != null)
		{
			object obj192 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3488;
			object obj193 = (nint)0 + (nint)3072;
			object obj194 = obj193;
			int version16 = list._version + 1;
			list._version = version16;
			object[] items16 = list._items;
			if (list._items != null)
			{
				bool flag59 = list._size < items16.Length;
				object obj195 = !flag59;
				if (obj195 == null)
				{
					int size16 = list._size + 1;
					list._size = size16;
					object obj196 = list._items + list._size;
					object obj197 = obj196 + 32;
					obj197 = obj192;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj198 = @this & JackarooAllowedRules.KING_RED_PLANT;
					bool flag60 = obj198 == null;
					object obj199 = !flag60;
					obj14 = obj11;
					if (obj199 != null)
					{
						goto IL_0c03;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X8_v115+20]");
					object obj200 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v962 @ X8_v116+C0]");
					object obj201 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ X8_v117+70]");
					obj14 = 0;
					list.AddWithResize(obj192);
					object obj202 = @this & JackarooAllowedRules.KING_RED_PLANT;
					bool flag61 = obj202 == null;
					object obj203 = !flag61;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ X8_v117+70]");
					obj11 = 0;
					if (obj203 != null)
					{
						goto IL_0c03;
					}
				}
				goto IL_0ddd;
			}
		}
		goto IL_25eb;
		IL_1a2b:
		object obj204 = @this & JackarooAllowedRules.TEN_MOVE;
		bool flag62 = obj204 == null;
		obj14 = obj11;
		if (!flag62)
		{
			goto IL_1a5e;
		}
		goto IL_1c38;
		IL_1437:
		if (list != null)
		{
			object obj205 = "Picking audio files is not supported on iOS" + 3000;
			object obj206 = (nint)0 + (nint)3072;
			object obj207 = obj206;
			int version17 = list._version + 1;
			list._version = version17;
			object[] items17 = list._items;
			if (list._items != null)
			{
				bool flag63 = list._size < items17.Length;
				object obj208 = !flag63;
				if (obj208 == null)
				{
					int size17 = list._size + 1;
					list._size = size17;
					object obj209 = list._items + list._size;
					object obj210 = obj209 + 32;
					obj210 = obj205;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj211 = @this & JackarooAllowedRules.JACK_BLACK_MOVE;
					bool flag64 = obj211 == null;
					object obj212 = !flag64;
					obj11 = obj14;
					if (obj212 != null)
					{
						goto IL_1644;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v75+20]");
					object obj213 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1227 @ X8_v76+C0]");
					object obj214 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1146 @ X8_v77+70]");
					obj11 = 0;
					list.AddWithResize(obj205);
					object obj215 = @this & JackarooAllowedRules.JACK_BLACK_MOVE;
					bool flag65 = obj215 == null;
					object obj216 = !flag65;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1146 @ X8_v77+70]");
					obj14 = 0;
					if (obj216 != null)
					{
						goto IL_1644;
					}
				}
				goto IL_181e;
			}
		}
		goto IL_25eb;
		IL_1e78:
		if (list != null)
		{
			object obj217 = "Complete" + 4000;
			object obj218 = (nint)0 + (nint)3072;
			object obj219 = obj218;
			int version18 = list._version + 1;
			list._version = version18;
			object[] items18 = list._items;
			if (list._items != null)
			{
				bool flag66 = list._size < items18.Length;
				object obj220 = !flag66;
				if (obj220 == null)
				{
					int size18 = list._size + 1;
					list._size = size18;
					object obj221 = list._items + list._size;
					object obj222 = obj221 + 32;
					obj222 = obj217;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj223 = @this & JackarooAllowedRules.BLOCKED_BY_TWO_CONSECUTIVE_MARBLES_SAME_COLOR;
					bool flag67 = obj223 == null;
					object obj224 = !flag67;
					obj14 = obj11;
					if (obj224 != null)
					{
						goto IL_2085;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v35+20]");
					object obj225 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1475 @ X8_v36+C0]");
					object obj226 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1411 @ X8_v37+70]");
					obj14 = 0;
					list.AddWithResize(obj217);
					object obj227 = @this & JackarooAllowedRules.BLOCKED_BY_TWO_CONSECUTIVE_MARBLES_SAME_COLOR;
					bool flag68 = obj227 == null;
					object obj228 = !flag68;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1411 @ X8_v37+70]");
					obj11 = 0;
					if (obj228 != null)
					{
						goto IL_2085;
					}
				}
				goto IL_225f;
			}
		}
		goto IL_25eb;
		IL_1a5e:
		if (list != null)
		{
			object obj229 = "SubscribeGroup request Error" + 1664;
			object obj230 = (nint)0 + (nint)3072;
			object obj231 = obj230;
			int version19 = list._version + 1;
			list._version = version19;
			object[] items19 = list._items;
			if (list._items != null)
			{
				bool flag69 = list._size < items19.Length;
				object obj232 = !flag69;
				if (obj232 == null)
				{
					int size19 = list._size + 1;
					list._size = size19;
					object obj233 = list._items + list._size;
					object obj234 = obj233 + 32;
					obj234 = obj229;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj235 = @this & JackarooAllowedRules.DISABLE_LAST_7_SHARED;
					bool flag70 = obj235 == null;
					object obj236 = !flag70;
					obj14 = obj11;
					if (obj236 != null)
					{
						goto IL_1c6b;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v51+20]");
					object obj237 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1386 @ X8_v52+C0]");
					object obj238 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ X8_v53+70]");
					obj14 = 0;
					list.AddWithResize(obj229);
					object obj239 = @this & JackarooAllowedRules.DISABLE_LAST_7_SHARED;
					bool flag71 = obj239 == null;
					object obj240 = !flag71;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1305 @ X8_v53+70]");
					obj11 = 0;
					if (obj240 != null)
					{
						goto IL_1c6b;
					}
				}
				goto IL_1e45;
			}
		}
		goto IL_25eb;
	}

	public static string GetActiveRuleString(JackarooAllowedRules @this, JackarooAllowedRulesCategory ruleCategory)
	{
		//IL_0062: Expected O, but got I4
		//IL_0070: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_002a: Expected O, but got I
		bool flag = ruleCategory < JackarooAllowedRulesCategory.PassSameColor;
		object obj = !flag;
		object obj2 = ruleCategory - 11;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 == null)
		{
			object obj5 = 119877632 + 720;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X9_v2+ruleCategory @ X1 (Jackaroo.JackarooAllowedRulesCategory)]");
			object obj6 = (nint)85747388 + (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v63 @ X10_v2 (should have been resolved before IL gen)");
		}
		return "Read object reference Id '{0}' for {1}." + 3640;
	}

	public static List<int> GetActiveRulesIndices(JackarooAllowedRules @this)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_22a1: Expected O, but got I4
		//IL_22bb: Expected O, but got I4
		//IL_016c: Expected O, but got I
		//IL_0181: Expected O, but got I
		//IL_004e: Expected O, but got I
		//IL_0063: Expected O, but got I
		//IL_01cf: Expected O, but got I4
		//IL_03b0: Expected O, but got I4
		//IL_03ca: Expected O, but got I4
		//IL_00b1: Expected O, but got I4
		//IL_025d: Expected O, but got I
		//IL_0272: Expected O, but got I
		//IL_01f3: Expected O, but got I
		//IL_0215: Expected O, but got I
		//IL_0229: Expected O, but got I4
		//IL_0365: Expected O, but got I4
		//IL_037f: Expected O, but got I4
		//IL_03e6: Expected O, but got I4
		//IL_0400: Expected O, but got I4
		//IL_00d5: Expected O, but got I
		//IL_00f7: Expected O, but got I
		//IL_010b: Expected O, but got I4
		//IL_0125: Expected O, but got I4
		//IL_02c0: Expected O, but got I4
		//IL_055c: Expected O, but got I
		//IL_0571: Expected O, but got I
		//IL_0664: Expected O, but got I4
		//IL_067e: Expected O, but got I4
		//IL_0425: Expected O, but got I
		//IL_043a: Expected O, but got I
		//IL_0448: Expected O, but got I4
		//IL_0462: Expected O, but got I4
		//IL_076d: Expected O, but got I
		//IL_0782: Expected O, but got I
		//IL_02e4: Expected O, but got I
		//IL_0306: Expected O, but got I
		//IL_031a: Expected O, but got I4
		//IL_0334: Expected O, but got I4
		//IL_05bf: Expected O, but got I4
		//IL_08c0: Expected O, but got I4
		//IL_08da: Expected O, but got I4
		//IL_07d0: Expected O, but got I4
		//IL_098c: Expected O, but got I4
		//IL_09a6: Expected O, but got I4
		//IL_05e3: Expected O, but got I
		//IL_0605: Expected O, but got I
		//IL_0619: Expected O, but got I4
		//IL_0633: Expected O, but got I4
		//IL_06df: Expected O, but got I4
		//IL_0875: Expected O, but got I4
		//IL_088f: Expected O, but got I4
		//IL_0b02: Expected O, but got I
		//IL_0b17: Expected O, but got I
		//IL_0956: Expected O, but got I4
		//IL_0970: Expected O, but got I4
		//IL_04be: Expected O, but got I4
		//IL_0cc8: Expected O, but got I
		//IL_0cdd: Expected O, but got I
		//IL_07f4: Expected O, but got I
		//IL_0816: Expected O, but got I
		//IL_082a: Expected O, but got I4
		//IL_0844: Expected O, but got I4
		//IL_09cb: Expected O, but got I
		//IL_09e0: Expected O, but got I
		//IL_09ee: Expected O, but got I4
		//IL_0a08: Expected O, but got I4
		//IL_0703: Expected O, but got I
		//IL_0725: Expected O, but got I
		//IL_0739: Expected O, but got I4
		//IL_090b: Expected O, but got I4
		//IL_0925: Expected O, but got I4
		//IL_0b65: Expected O, but got I4
		//IL_04e2: Expected O, but got I
		//IL_0504: Expected O, but got I
		//IL_0518: Expected O, but got I4
		//IL_0532: Expected O, but got I4
		//IL_0d2b: Expected O, but got I4
		//IL_0ef0: Expected O, but got I
		//IL_0f05: Expected O, but got I
		//IL_0f13: Expected O, but got I4
		//IL_0f2d: Expected O, but got I4
		//IL_0e1b: Expected O, but got I4
		//IL_0e35: Expected O, but got I4
		//IL_0dd0: Expected O, but got I4
		//IL_0dea: Expected O, but got I4
		//IL_0b89: Expected O, but got I
		//IL_0bab: Expected O, but got I
		//IL_0bbf: Expected O, but got I4
		//IL_0bd9: Expected O, but got I4
		//IL_0c3a: Expected O, but got I4
		//IL_10ec: Expected O, but got I
		//IL_1101: Expected O, but got I
		//IL_0d4f: Expected O, but got I
		//IL_0d71: Expected O, but got I
		//IL_0d85: Expected O, but got I4
		//IL_0d9f: Expected O, but got I4
		//IL_0eb1: Expected O, but got I4
		//IL_0ecb: Expected O, but got I4
		//IL_0a64: Expected O, but got I4
		//IL_105e: Expected O, but got I4
		//IL_0c5e: Expected O, but got I
		//IL_0c80: Expected O, but got I
		//IL_0c94: Expected O, but got I4
		//IL_0e66: Expected O, but got I4
		//IL_0e80: Expected O, but got I4
		//IL_114f: Expected O, but got I4
		//IL_1261: Expected O, but got I
		//IL_1276: Expected O, but got I
		//IL_1284: Expected O, but got I4
		//IL_129e: Expected O, but got I4
		//IL_1222: Expected O, but got I4
		//IL_123c: Expected O, but got I4
		//IL_0f89: Expected O, but got I4
		//IL_0a88: Expected O, but got I
		//IL_0aaa: Expected O, but got I
		//IL_0abe: Expected O, but got I4
		//IL_0ad8: Expected O, but got I4
		//IL_1082: Expected O, but got I
		//IL_10a4: Expected O, but got I
		//IL_10b8: Expected O, but got I4
		//IL_11d7: Expected O, but got I4
		//IL_11f1: Expected O, but got I4
		//IL_1173: Expected O, but got I
		//IL_1195: Expected O, but got I
		//IL_0fad: Expected O, but got I
		//IL_0fcf: Expected O, but got I
		//IL_0fe3: Expected O, but got I4
		//IL_0ffd: Expected O, but got I4
		//IL_1433: Expected O, but got I
		//IL_1448: Expected O, but got I
		//IL_1456: Expected O, but got I4
		//IL_1470: Expected O, but got I4
		//IL_1399: Expected O, but got I4
		//IL_12fa: Expected O, but got I4
		//IL_13bd: Expected O, but got I
		//IL_13df: Expected O, but got I
		//IL_156b: Expected O, but got I4
		//IL_131e: Expected O, but got I
		//IL_1340: Expected O, but got I
		//IL_14cc: Expected O, but got I4
		//IL_158f: Expected O, but got I
		//IL_15b1: Expected O, but got I
		//IL_1605: Expected O, but got I
		//IL_161a: Expected O, but got I
		//IL_1628: Expected O, but got I4
		//IL_1642: Expected O, but got I4
		//IL_14f0: Expected O, but got I
		//IL_1512: Expected O, but got I
		//IL_173d: Expected O, but got I4
		//IL_169e: Expected O, but got I4
		//IL_1761: Expected O, but got I
		//IL_1783: Expected O, but got I
		//IL_17d7: Expected O, but got I
		//IL_17ec: Expected O, but got I
		//IL_17fa: Expected O, but got I4
		//IL_1814: Expected O, but got I4
		//IL_16c2: Expected O, but got I
		//IL_16e4: Expected O, but got I
		//IL_190f: Expected O, but got I4
		//IL_1870: Expected O, but got I4
		//IL_1933: Expected O, but got I
		//IL_1955: Expected O, but got I
		//IL_19a9: Expected O, but got I
		//IL_19be: Expected O, but got I
		//IL_19cc: Expected O, but got I4
		//IL_19e6: Expected O, but got I4
		//IL_1894: Expected O, but got I
		//IL_18b6: Expected O, but got I
		//IL_1ae1: Expected O, but got I4
		//IL_1a42: Expected O, but got I4
		//IL_1b05: Expected O, but got I
		//IL_1b27: Expected O, but got I
		//IL_1b7b: Expected O, but got I
		//IL_1b90: Expected O, but got I
		//IL_1b9e: Expected O, but got I4
		//IL_1bb8: Expected O, but got I4
		//IL_1a66: Expected O, but got I
		//IL_1a88: Expected O, but got I
		//IL_1ce9: Expected O, but got I4
		//IL_1e94: Expected O, but got I4
		//IL_1eae: Expected O, but got I4
		//IL_1c14: Expected O, but got I4
		//IL_1d77: Expected O, but got I
		//IL_1d8c: Expected O, but got I
		//IL_1d0d: Expected O, but got I
		//IL_1d2f: Expected O, but got I
		//IL_1d43: Expected O, but got I4
		//IL_1e49: Expected O, but got I4
		//IL_1e63: Expected O, but got I4
		//IL_1ed3: Expected O, but got I
		//IL_1ee8: Expected O, but got I
		//IL_1ef6: Expected O, but got I4
		//IL_1f10: Expected O, but got I4
		//IL_1c38: Expected O, but got I
		//IL_1c5a: Expected O, but got I
		//IL_1c6e: Expected O, but got I4
		//IL_1c88: Expected O, but got I4
		//IL_1dda: Expected O, but got I4
		//IL_1dfe: Expected O, but got I
		//IL_1e20: Expected O, but got I
		//IL_200b: Expected O, but got I4
		//IL_20be: Expected O, but got I
		//IL_20d3: Expected O, but got I
		//IL_20e1: Expected O, but got I4
		//IL_20fb: Expected O, but got I4
		//IL_1f6c: Expected O, but got I4
		//IL_202f: Expected O, but got I
		//IL_2051: Expected O, but got I
		//IL_1f90: Expected O, but got I
		//IL_1fb2: Expected O, but got I
		//IL_21f6: Expected O, but got I4
		//IL_2157: Expected O, but got I4
		//IL_221a: Expected O, but got I
		//IL_223c: Expected O, but got I
		//IL_217b: Expected O, but got I
		//IL_219d: Expected O, but got I
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<int> list = default(List<int>);
		list..ctor();
		object obj2 = @this & JackarooAllowedRules.ACE_MOVE_1_PLANT;
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			if (list != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj4 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X9_v87+18]");
					bool flag2 = num < 0;
					object obj6 = !flag2;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj7 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj8 = num2 + 0;
						_ = 0;
						object obj9 = @this & JackarooAllowedRules.KING_BLACK_PLANT_MOVE_NO_KILL;
						bool flag3 = obj9 == null;
						object obj10 = !flag3;
						if (obj10 != null)
						{
							goto IL_0246;
						}
					}
					else
					{
						list.AddWithResize(0);
						object obj11 = @this & JackarooAllowedRules.KING_BLACK_PLANT_MOVE_NO_KILL;
						bool flag4 = obj11 == null;
						object obj12 = !flag4;
						if (obj12 != null)
						{
							goto IL_0246;
						}
					}
					goto IL_03d8;
				}
			}
		}
		else if (list != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj13 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X9_v83+18]");
				bool flag5 = num3 < 0;
				object obj15 = !flag5;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj16 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj17 = num4 + 0;
					_ = 1;
					object obj18 = @this & JackarooAllowedRules.KING_BLACK_PLANT_MOVE_NO_KILL;
					if (obj18 != null)
					{
						goto IL_0246;
					}
				}
				else
				{
					list.AddWithResize(1);
					object obj19 = @this & JackarooAllowedRules.KING_BLACK_PLANT_MOVE_NO_KILL;
					bool flag6 = obj19 == null;
					object obj20 = !flag6;
					if (obj20 != null)
					{
						goto IL_0246;
					}
				}
				goto IL_03d8;
			}
		}
		goto IL_2271;
		IL_097e:
		object obj21 = @this & JackarooAllowedRules.KING_RED_MOVE_EAT_PATH;
		bool flag7 = obj21 == null;
		object obj22 = !flag7;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj23 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			object obj24 = 0;
			object obj25 = @this & JackarooAllowedRules.KING_RED_PLANT;
			bool flag8 = obj25 == null;
			object obj26 = !flag8;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X10_v44+18]");
					bool flag9 = num5 < 0;
					object obj27 = !flag9;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj28 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj29 = num6 + 0;
						_ = 0;
						object obj30 = @this & JackarooAllowedRules.QUEEN_BLACK_BURN;
						bool flag10 = obj30 == null;
						object obj31 = !flag10;
						if (obj31 != null)
						{
							goto IL_0cb1;
						}
					}
					else
					{
						list.AddWithResize(0);
						object obj32 = @this & JackarooAllowedRules.QUEEN_BLACK_BURN;
						bool flag11 = obj32 == null;
						object obj33 = !flag11;
						if (obj33 != null)
						{
							goto IL_0cb1;
						}
					}
					goto IL_0ed9;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X10_v44+18]");
					bool flag12 = num7 < 0;
					object obj34 = !flag12;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj35 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj36 = num8 + 0;
						_ = 3;
						object obj37 = @this & JackarooAllowedRules.QUEEN_BLACK_BURN;
						if (obj37 != null)
						{
							goto IL_0cb1;
						}
					}
					else
					{
						list.AddWithResize(3);
						object obj38 = @this & JackarooAllowedRules.QUEEN_BLACK_BURN;
						bool flag13 = obj38 == null;
						object obj39 = !flag13;
						if (obj39 != null)
						{
							goto IL_0cb1;
						}
					}
					goto IL_0ed9;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj40 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X9_v58+18]");
				bool flag14 = num9 < 0;
				object obj42 = !flag14;
				if (obj42 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj43 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj44 = num10 + 0;
					_ = 2;
					object obj45 = @this & JackarooAllowedRules.QUEEN_BLACK_BURN;
					bool flag15 = obj45 == null;
					object obj46 = !flag15;
					if (obj46 != null)
					{
						goto IL_0cb1;
					}
				}
				else
				{
					list.AddWithResize(2);
					object obj47 = @this & JackarooAllowedRules.QUEEN_BLACK_BURN;
					bool flag16 = obj47 == null;
					object obj48 = !flag16;
					if (obj48 != null)
					{
						goto IL_0cb1;
					}
				}
				goto IL_0ed9;
			}
		}
		goto IL_2271;
		IL_0cb1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj49 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X9_v53+18]");
			bool flag17 = num11 < 0;
			object obj51 = !flag17;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj52 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj53 = num12 + 0;
				_ = 1;
				object obj54 = @this & JackarooAllowedRules.QUEEN_RED_MOVE;
				bool flag18 = obj54 == null;
				object obj55 = !flag18;
				if (obj55 != null)
				{
					goto IL_10d5;
				}
			}
			else
			{
				list.AddWithResize(1);
				object obj56 = @this & JackarooAllowedRules.QUEEN_RED_MOVE;
				bool flag19 = obj56 == null;
				object obj57 = !flag19;
				if (obj57 != null)
				{
					goto IL_10d5;
				}
			}
			goto IL_124a;
		}
		goto IL_2271;
		IL_2271:
		return (List<int>)(object)new NullReferenceException();
		IL_0756:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj58 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X9_v66+18]");
			bool flag20 = num13 < 0;
			object obj60 = !flag20;
			if (obj60 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj61 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj62 = num14 + 0;
				_ = 1;
				object obj63 = @this & JackarooAllowedRules.QUEEN_BLACK_BURN;
				bool flag21 = obj63 == null;
				object obj64 = !flag21;
				if (obj64 != null)
				{
					goto IL_0cb1;
				}
			}
			else
			{
				list.AddWithResize(1);
				object obj65 = @this & JackarooAllowedRules.QUEEN_BLACK_BURN;
				bool flag22 = obj65 == null;
				object obj66 = !flag22;
				if (obj66 != null)
				{
					goto IL_0cb1;
				}
			}
			goto IL_0ed9;
		}
		goto IL_2271;
		IL_2323:
		List<int> list2;
		int item;
		list2.AddWithResize(item);
		goto IL_20a7;
		IL_141c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj67 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj68 = 0;
		object obj69 = @this & JackarooAllowedRules.JACK_BLACK_MOVE;
		bool flag23 = obj69 == null;
		object obj70 = !flag23;
		int item2;
		List<int> list3;
		if (obj70 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 == 0)
			{
				goto IL_2271;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X10_v6+18]");
			bool flag24 = num15 < 0;
			object obj71 = !flag24;
			if (obj71 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj72 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj73 = num16 + 0;
				_ = 0;
				goto IL_15ee;
			}
			item2 = 0;
			list3 = list;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 == 0)
			{
				goto IL_2271;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X10_v6+18]");
			bool flag25 = num17 < 0;
			object obj74 = !flag25;
			if (obj74 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj75 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj76 = num18 + 0;
				_ = 1;
				goto IL_15ee;
			}
			item2 = 1;
			list3 = list;
		}
		list3.AddWithResize(item2);
		goto IL_15ee;
		IL_124a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj77 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj78 = 0;
		object obj79 = @this & JackarooAllowedRules.QUEEN_RED_STEAL;
		bool flag26 = obj79 == null;
		object obj80 = !flag26;
		int item3;
		List<int> list4;
		if (obj80 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 == 0)
			{
				goto IL_2271;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X10_v31+18]");
			bool flag27 = num19 < 0;
			object obj81 = !flag27;
			if (obj81 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj82 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj83 = num20 + 0;
				_ = 0;
				goto IL_141c;
			}
			item3 = 0;
			list4 = list;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 == 0)
			{
				goto IL_2271;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X10_v31+18]");
			bool flag28 = num21 < 0;
			object obj84 = !flag28;
			if (obj84 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj85 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj86 = num22 + 0;
				_ = 2;
				goto IL_141c;
			}
			item3 = 2;
			list4 = list;
		}
		goto IL_22c9;
		IL_22c9:
		list4.AddWithResize(item3);
		goto IL_141c;
		IL_10d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj87 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		if ((nint)0 == 0)
		{
			goto IL_2271;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X9_v44+18]");
		bool flag29 = num23 < 0;
		object obj89 = !flag29;
		if (obj89 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj90 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			nint num24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj91 = num24 + 0;
			_ = 1;
			goto IL_141c;
		}
		item3 = 1;
		list4 = list;
		goto IL_22c9;
		IL_0ed9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj92 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj93 = 0;
		object obj94 = @this & JackarooAllowedRules.QUEEN_BLACK_STEAL;
		bool flag30 = obj94 == null;
		object obj95 = !flag30;
		if (obj95 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X10_v37+18]");
				bool flag31 = num25 < 0;
				object obj96 = !flag31;
				if (obj96 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj97 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					nint num26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj98 = num26 + 0;
					_ = 0;
					object obj99 = @this & JackarooAllowedRules.QUEEN_RED_MOVE;
					bool flag32 = obj99 == null;
					object obj100 = !flag32;
					if (obj100 != null)
					{
						goto IL_10d5;
					}
				}
				else
				{
					list.AddWithResize(0);
					object obj101 = @this & JackarooAllowedRules.QUEEN_RED_MOVE;
					bool flag33 = obj101 == null;
					object obj102 = !flag33;
					if (obj102 != null)
					{
						goto IL_10d5;
					}
				}
				goto IL_124a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X10_v37+18]");
				bool flag34 = num27 < 0;
				object obj103 = !flag34;
				if (obj103 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj104 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					nint num28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj105 = num28 + 0;
					_ = 2;
					object obj106 = @this & JackarooAllowedRules.QUEEN_RED_MOVE;
					if (obj106 != null)
					{
						goto IL_10d5;
					}
				}
				else
				{
					list.AddWithResize(2);
					object obj107 = @this & JackarooAllowedRules.QUEEN_RED_MOVE;
					bool flag35 = obj107 == null;
					object obj108 = !flag35;
					if (obj108 != null)
					{
						goto IL_10d5;
					}
				}
				goto IL_124a;
			}
		}
		goto IL_2271;
		IL_0246:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj109 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj110 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X9_v79+18]");
			bool flag36 = num29 < 0;
			object obj111 = !flag36;
			if (obj111 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj112 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj113 = num30 + 0;
				_ = 1;
				object obj114 = @this & JackarooAllowedRules.KING_RED_PLANT_MOVE_NO_KILL;
				bool flag37 = obj114 == null;
				object obj115 = !flag37;
				if (obj115 != null)
				{
					goto IL_0756;
				}
			}
			else
			{
				list.AddWithResize(1);
				object obj116 = @this & JackarooAllowedRules.KING_RED_PLANT_MOVE_NO_KILL;
				bool flag38 = obj116 == null;
				object obj117 = !flag38;
				if (obj117 != null)
				{
					goto IL_0756;
				}
			}
			goto IL_097e;
		}
		goto IL_2271;
		IL_1ebc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj118 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj119 = 0;
		object obj120 = @this & JackarooAllowedRules.DISABLE_BLOCKED_BY_TWO_CONSECUTIVE_MARBLES;
		bool flag39 = obj120 == null;
		object obj121 = !flag39;
		if (obj121 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 == 0)
			{
				goto IL_2271;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X10_v26+18]");
			bool flag40 = num31 < 0;
			object obj122 = !flag40;
			if (obj122 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj123 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj124 = num32 + 0;
				_ = 0;
				goto IL_20a7;
			}
			item = 0;
			list2 = list;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 == 0)
			{
				goto IL_2271;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X10_v26+18]");
			bool flag41 = num33 < 0;
			object obj125 = !flag41;
			if (obj125 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj126 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj127 = num34 + 0;
				_ = 2;
				goto IL_20a7;
			}
			item = 2;
			list2 = list;
		}
		goto IL_2323;
		IL_15ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj128 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj129 = 0;
		object obj130 = @this & JackarooAllowedRules.JACK_RED_SWAP;
		bool flag42 = obj130 == null;
		object obj131 = !flag42;
		int item4;
		List<int> list5;
		if (obj131 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 == 0)
			{
				goto IL_2271;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X10_v9+18]");
			bool flag43 = num35 < 0;
			object obj132 = !flag43;
			if (obj132 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj133 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj134 = num36 + 0;
				_ = 0;
				goto IL_17c0;
			}
			item4 = 0;
			list5 = list;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 == 0)
			{
				goto IL_2271;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X10_v9+18]");
			bool flag44 = num37 < 0;
			object obj135 = !flag44;
			if (obj135 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj136 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num38 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj137 = num38 + 0;
				_ = 1;
				goto IL_17c0;
			}
			item4 = 1;
			list5 = list;
		}
		list5.AddWithResize(item4);
		goto IL_17c0;
		IL_1b64:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj138 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj139 = 0;
		object obj140 = @this & JackarooAllowedRules.DISABLE_BASE_ENTRY_BLOCKING;
		bool flag45 = obj140 == null;
		object obj141 = !flag45;
		if (obj141 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X10_v18+18]");
				bool flag46 = num39 < 0;
				object obj142 = !flag46;
				if (obj142 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj143 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					nint num40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj144 = num40 + 0;
					_ = 0;
					object obj145 = @this & JackarooAllowedRules.BLOCKED_BY_TWO_CONSECUTIVE_MARBLES_SAME_COLOR;
					bool flag47 = obj145 == null;
					object obj146 = !flag47;
					if (obj146 != null)
					{
						goto IL_1d60;
					}
				}
				else
				{
					list.AddWithResize(0);
					object obj147 = @this & JackarooAllowedRules.BLOCKED_BY_TWO_CONSECUTIVE_MARBLES_SAME_COLOR;
					bool flag48 = obj147 == null;
					object obj148 = !flag48;
					if (obj148 != null)
					{
						goto IL_1d60;
					}
				}
				goto IL_1ebc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num41 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X10_v18+18]");
				bool flag49 = num41 < 0;
				object obj149 = !flag49;
				if (obj149 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj150 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					nint num42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj151 = num42 + 0;
					_ = 1;
					object obj152 = @this & JackarooAllowedRules.BLOCKED_BY_TWO_CONSECUTIVE_MARBLES_SAME_COLOR;
					if (obj152 != null)
					{
						goto IL_1d60;
					}
				}
				else
				{
					list.AddWithResize(1);
					object obj153 = @this & JackarooAllowedRules.BLOCKED_BY_TWO_CONSECUTIVE_MARBLES_SAME_COLOR;
					bool flag50 = obj153 == null;
					object obj154 = !flag50;
					if (obj154 != null)
					{
						goto IL_1d60;
					}
				}
				goto IL_1ebc;
			}
		}
		goto IL_2271;
		IL_03d8:
		object obj155 = @this & JackarooAllowedRules.KING_BLACK_MOVE_EAT_PATH;
		bool flag51 = obj155 == null;
		object obj156 = !flag51;
		if (obj156 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj157 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			object obj158 = 0;
			object obj159 = @this & JackarooAllowedRules.KING_BLACK_PLANT;
			bool flag52 = obj159 == null;
			object obj160 = !flag52;
			if (obj160 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X10_v51+18]");
					bool flag53 = num43 < 0;
					object obj161 = !flag53;
					if (obj161 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj162 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						nint num44 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj163 = num44 + 0;
						_ = 0;
						object obj164 = @this & JackarooAllowedRules.KING_RED_PLANT_MOVE_NO_KILL;
						bool flag54 = obj164 == null;
						object obj165 = !flag54;
						if (obj165 != null)
						{
							goto IL_0756;
						}
					}
					else
					{
						list.AddWithResize(0);
						object obj166 = @this & JackarooAllowedRules.KING_RED_PLANT_MOVE_NO_KILL;
						bool flag55 = obj166 == null;
						object obj167 = !flag55;
						if (obj167 != null)
						{
							goto IL_0756;
						}
					}
					goto IL_097e;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X10_v51+18]");
					bool flag56 = num45 < 0;
					object obj168 = !flag56;
					if (obj168 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj169 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
						nint num46 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj170 = num46 + 0;
						_ = 3;
						object obj171 = @this & JackarooAllowedRules.KING_RED_PLANT_MOVE_NO_KILL;
						if (obj171 != null)
						{
							goto IL_0756;
						}
					}
					else
					{
						list.AddWithResize(3);
						object obj172 = @this & JackarooAllowedRules.KING_RED_PLANT_MOVE_NO_KILL;
						bool flag57 = obj172 == null;
						object obj173 = !flag57;
						if (obj173 != null)
						{
							goto IL_0756;
						}
					}
					goto IL_097e;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj174 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			object obj175 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X9_v71+18]");
				bool flag58 = num47 < 0;
				object obj176 = !flag58;
				if (obj176 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj177 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					nint num48 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj178 = num48 + 0;
					_ = 2;
					object obj179 = @this & JackarooAllowedRules.KING_RED_PLANT_MOVE_NO_KILL;
					bool flag59 = obj179 == null;
					object obj180 = !flag59;
					if (obj180 != null)
					{
						goto IL_0756;
					}
				}
				else
				{
					list.AddWithResize(2);
					object obj181 = @this & JackarooAllowedRules.KING_RED_PLANT_MOVE_NO_KILL;
					bool flag60 = obj181 == null;
					object obj182 = !flag60;
					if (obj182 != null)
					{
						goto IL_0756;
					}
				}
				goto IL_097e;
			}
		}
		goto IL_2271;
		IL_17c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj183 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj184 = 0;
		object obj185 = @this & JackarooAllowedRules.TEN_MOVE;
		bool flag61 = obj185 == null;
		object obj186 = !flag61;
		int item5;
		List<int> list6;
		if (obj186 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 == 0)
			{
				goto IL_2271;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X10_v12+18]");
			bool flag62 = num49 < 0;
			object obj187 = !flag62;
			if (obj187 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj188 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num50 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj189 = num50 + 0;
				_ = 0;
				goto IL_1992;
			}
			item5 = 0;
			list6 = list;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 == 0)
			{
				goto IL_2271;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X10_v12+18]");
			bool flag63 = num51 < 0;
			object obj190 = !flag63;
			if (obj190 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj191 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num52 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj192 = num52 + 0;
				_ = 1;
				goto IL_1992;
			}
			item5 = 1;
			list6 = list;
		}
		list6.AddWithResize(item5);
		goto IL_1992;
		IL_1d60:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj193 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj194 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		if ((nint)0 == 0)
		{
			goto IL_2271;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
		nint num53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X9_v30+18]");
		bool flag64 = num53 < 0;
		object obj195 = !flag64;
		if (obj195 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj196 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			nint num54 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			object obj197 = num54 + 0;
			_ = 1;
			goto IL_20a7;
		}
		item = 1;
		list2 = list;
		goto IL_2323;
		IL_20a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj198 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj199 = 0;
		object obj200 = @this & JackarooAllowedRules.DISABLE_SAME_COLOR_MARBLE_BLOCK;
		bool flag65 = obj200 == null;
		object obj201 = !flag65;
		if (obj201 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X10_v23+18]");
				bool flag66 = num55 < 0;
				object obj202 = !flag66;
				if (obj202 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj203 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					nint num56 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj204 = num56 + 0;
					_ = 0;
					return list;
				}
				list.AddWithResize(0);
				return list;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				nint num57 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X10_v23+18]");
				bool flag67 = num57 < 0;
				object obj205 = !flag67;
				if (obj205 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj206 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
					nint num58 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
					object obj207 = num58 + 0;
					_ = 1;
					return list;
				}
				list.AddWithResize(1);
				return list;
			}
		}
		goto IL_2271;
		IL_1992:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
		object obj208 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
		object obj209 = 0;
		object obj210 = @this & JackarooAllowedRules.DISABLE_LAST_7_SHARED;
		bool flag68 = obj210 == null;
		object obj211 = !flag68;
		int item6;
		List<int> list7;
		if (obj211 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 == 0)
			{
				goto IL_2271;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num59 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X10_v15+18]");
			bool flag69 = num59 < 0;
			object obj212 = !flag69;
			if (obj212 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj213 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj214 = num60 + 0;
				_ = 0;
				goto IL_1b64;
			}
			item6 = 0;
			list7 = list;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
			if ((nint)0 == 0)
			{
				goto IL_2271;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num61 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X10_v15+18]");
			bool flag70 = num61 < 0;
			object obj215 = !flag70;
			if (obj215 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj216 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+10]");
				nint num62 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v3 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj217 = num62 + 0;
				_ = 1;
				goto IL_1b64;
			}
			item6 = 1;
			list7 = list;
		}
		list7.AddWithResize(item6);
		goto IL_1b64;
	}

	public unsafe static IEnumerable<(string, int)> GetJackarooAllowedRulesString(RuleType @this, Card card)
	{
		//IL_0401: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		//IL_10f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fc: Expected O, but got Unknown
		//IL_15dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e2: Expected O, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Expected O, but got Unknown
		//IL_0442: Expected O, but got I
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1124: Expected O, but got Unknown
		//IL_1138: Expected O, but got I
		//IL_0e66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6b: Expected O, but got Unknown
		//IL_160a: Unknown result type (might be due to invalid IL or missing references)
		//IL_160f: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0591: Expected O, but got Unknown
		//IL_1632: Unknown result type (might be due to invalid IL or missing references)
		//IL_1637: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02b7: Expected O, but got I
		//IL_0498: Expected O, but got I
		//IL_04ad: Expected O, but got I
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected O, but got Unknown
		//IL_05cd: Expected O, but got I
		//IL_118e: Expected O, but got I
		//IL_11a3: Expected O, but got I
		//IL_0d5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d64: Expected O, but got Unknown
		//IL_127d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1282: Expected O, but got Unknown
		//IL_1296: Expected O, but got I
		//IL_0f9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa2: Expected O, but got Unknown
		//IL_1664: Expected O, but got I
		//IL_0eab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb0: Expected O, but got Unknown
		//IL_0ec4: Expected O, but got I
		//IL_030d: Expected O, but got I
		//IL_0322: Expected O, but got I
		//IL_050c: Expected O, but got I4
		//IL_0623: Expected O, but got I
		//IL_0638: Expected O, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_1202: Expected O, but got I4
		//IL_146d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1472: Expected O, but got Unknown
		//IL_1486: Expected O, but got I
		//IL_12e2: Expected O, but got I
		//IL_12f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12fb: Expected O, but got Unknown
		//IL_135d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1362: Expected O, but got Unknown
		//IL_1376: Expected O, but got I
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_0da4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da9: Expected O, but got Unknown
		//IL_0dbd: Expected O, but got I
		//IL_1326: Unknown result type (might be due to invalid IL or missing references)
		//IL_132b: Expected O, but got Unknown
		//IL_133d: Expected O, but got I4
		//IL_134e: Expected O, but got Ref
		//IL_0f10: Expected O, but got I
		//IL_0f24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f29: Expected O, but got Unknown
		//IL_0fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe7: Expected O, but got Unknown
		//IL_0ffb: Expected O, but got I
		//IL_07b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ba: Expected O, but got Unknown
		//IL_0381: Expected O, but got I4
		//IL_094d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0952: Expected O, but got Unknown
		//IL_0982: Expected O, but got I
		//IL_0997: Expected O, but got I
		//IL_0530: Expected O, but got I
		//IL_0552: Expected O, but got I
		//IL_055b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected O, but got Unknown
		//IL_0697: Expected O, but got I4
		//IL_152f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1534: Expected O, but got Unknown
		//IL_155e: Expected O, but got Ref
		//IL_1566: Expected I4, but got O
		//IL_1226: Expected O, but got I
		//IL_1248: Expected O, but got I
		//IL_1251: Unknown result type (might be due to invalid IL or missing references)
		//IL_1256: Expected O, but got Unknown
		//IL_14d2: Expected O, but got I
		//IL_14e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14eb: Expected O, but got Unknown
		//IL_14fd: Expected O, but got I4
		//IL_150e: Expected O, but got Ref
		//IL_1764: Expected native int or pointer, but got O
		//IL_1781: Expected I4, but got O
		//IL_0f54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f59: Expected O, but got Unknown
		//IL_0f6b: Expected O, but got I4
		//IL_0f7c: Expected O, but got Ref
		//IL_13c2: Expected O, but got I
		//IL_13d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13db: Expected O, but got Unknown
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected O, but got Unknown
		//IL_07f6: Expected O, but got I
		//IL_0135: Expected O, but got I
		//IL_014a: Expected O, but got I
		//IL_16ba: Expected native int or pointer, but got O
		//IL_16d5: Expected O, but got I
		//IL_16ea: Expected O, but got I
		//IL_170c: Expected O, but got I4
		//IL_1736: Expected native int or pointer, but got O
		//IL_1753: Expected I4, but got O
		//IL_0e09: Expected O, but got I
		//IL_0e1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e22: Expected O, but got Unknown
		//IL_0e34: Expected O, but got I4
		//IL_0e45: Expected O, but got Ref
		//IL_17c3: Expected O, but got I4
		//IL_1406: Unknown result type (might be due to invalid IL or missing references)
		//IL_140b: Expected O, but got Unknown
		//IL_1047: Expected O, but got I
		//IL_105b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1060: Expected O, but got Unknown
		//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b38: Expected O, but got Unknown
		//IL_0b62: Expected O, but got Ref
		//IL_0b6a: Expected I4, but got O
		//IL_03a5: Expected O, but got I
		//IL_03c7: Expected O, but got I
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_09f6: Expected O, but got I4
		//IL_0a83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a88: Expected O, but got Unknown
		//IL_0ab2: Expected O, but got Ref
		//IL_0aba: Expected I4, but got O
		//IL_06bb: Expected O, but got I
		//IL_06dd: Expected O, but got I
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected O, but got Unknown
		//IL_0c72: Expected O, but got I4
		//IL_1436: Unknown result type (might be due to invalid IL or missing references)
		//IL_143b: Expected O, but got Unknown
		//IL_144d: Expected O, but got I4
		//IL_145e: Expected O, but got Ref
		//IL_108b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1090: Expected O, but got Unknown
		//IL_084c: Expected O, but got I
		//IL_0861: Expected O, but got I
		//IL_01a9: Expected O, but got I4
		//IL_0ce7: Expected O, but got I4
		//IL_0cec: Expected O, but got I4
		//IL_1792: Expected native int or pointer, but got O
		//IL_17af: Expected I4, but got O
		//IL_10bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c0: Expected O, but got Unknown
		//IL_10d2: Expected O, but got I4
		//IL_10e3: Expected O, but got Ref
		//IL_0ba8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bad: Expected O, but got Unknown
		//IL_0bdd: Expected O, but got I
		//IL_0bf2: Expected O, but got I
		//IL_0c22: Expected I4, but got O
		//IL_0a1a: Expected O, but got I
		//IL_0a3c: Expected O, but got I
		//IL_0a45: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4a: Expected O, but got Unknown
		//IL_0c96: Expected O, but got I
		//IL_0cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb0: Expected O, but got Unknown
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Expected O, but got Unknown
		//IL_0cda: Expected O, but got I4
		//IL_08c0: Expected O, but got I4
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae0: Expected O, but got Unknown
		//IL_0b0a: Expected O, but got Ref
		//IL_0b12: Expected I4, but got O
		//IL_01cd: Expected O, but got I
		//IL_01ef: Expected O, but got I
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_1587: Unknown result type (might be due to invalid IL or missing references)
		//IL_158c: Expected O, but got Unknown
		//IL_15b6: Expected O, but got Ref
		//IL_15be: Expected I4, but got O
		//IL_08e4: Expected O, but got I
		//IL_0906: Expected O, but got I
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected O, but got Unknown
		bool flag = card == null;
		IntPtr intPtr = default(IntPtr);
		int num = (int)(nint)intPtr;
		object obj = card;
		object item;
		int num4;
		int item2;
		(object, int) tuple2;
		object obj14 = default(object);
		RuleType ruleType;
		object obj13;
		object obj41;
		(object, int) tuple7;
		int num11;
		object obj5;
		if (!flag)
		{
			(object, int) tuple5 = default((object, int));
			(object, int) tuple6 = default((object, int));
			if (@this > RuleType.BaseEntryRule)
			{
				if (@this != RuleType.TwoConsecutiveMarblesRule)
				{
					if (@this != RuleType.Last7SharedRule)
					{
						bool flag2 = @this != RuleType.SameColorBlockRule;
						num = (int)(nint)intPtr;
						obj = card;
						if (flag2)
						{
							goto IL_15ce;
						}
						object obj2 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3896;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						List<(object, int)> list = default(List<(object, int)>);
						list..ctor();
						object obj3 = "Read object reference Id '{0}' for {1}." + 3792;
						obj = obj3;
						object obj4 = (nint)0 + (nint)3928;
						obj5 = obj4;
						(object, int) tuple = (obj3, 0);
						bool flag3 = list == null;
						num = 0;
						if (!flag3)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v143 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+1C]");
							object obj6 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v143 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
							object obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v143 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
							bool flag4 = (nint)0 == 0;
							num = 0;
							obj = tuple;
							if (!flag4)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v143 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
								nint num2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X9_v31+18]");
								bool flag5 = num2 < 0;
								object obj8 = !flag5;
								if (obj8 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v143 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
									object obj9 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v143 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
									nint num3 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v143 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
									object obj10 = num3 + 0;
									object obj11 = obj10 + 32;
									obj11 = tuple;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								}
								else
								{
									list.AddWithResize(tuple);
								}
								object obj12 = "Complete" + 4024;
								item = obj12;
								obj13 = obj4;
								num4 = 0;
								item2 = 262144;
								tuple2 = ((object, int))(&obj14);
								ruleType = (RuleType)list;
								goto IL_16ae;
							}
						}
					}
					else
					{
						object obj15 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3896;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						List<(object, int)> list2 = default(List<(object, int)>);
						list2..ctor();
						object obj16 = "LAK" + 32;
						obj = obj16;
						object obj17 = (nint)0 + (nint)3928;
						obj5 = obj17;
						(object, int) tuple3 = (obj16, 0);
						bool flag6 = list2 == null;
						num = 0;
						if (!flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v134 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+1C]");
							object obj18 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v134 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
							object obj19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v134 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
							bool flag7 = (nint)0 == 0;
							num = 0;
							obj = tuple3;
							if (!flag7)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v134 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
								nint num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X9_v28+18]");
								bool flag8 = num5 < 0;
								object obj20 = !flag8;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v134 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
									object obj21 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v134 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
									nint num6 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v134 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
									object obj22 = num6 + 0;
									object obj23 = obj22 + 32;
									obj23 = tuple3;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								}
								else
								{
									list2.AddWithResize(tuple3);
								}
								object obj24 = "Complete" + 4016;
								item = obj24;
								obj13 = obj17;
								num4 = 0;
								item2 = 16384;
								tuple2 = ((object, int))(&obj14);
								ruleType = (RuleType)list2;
								goto IL_16ae;
							}
						}
					}
				}
				else
				{
					object obj25 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3896;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					List<(object, int)> list3 = default(List<(object, int)>);
					list3..ctor();
					object obj26 = "AvailableVoices" + 552;
					obj = obj26;
					object obj27 = (nint)0 + (nint)3928;
					obj5 = obj27;
					(object, int) tuple4 = (obj26, 0);
					bool flag9 = list3 == null;
					num = 0;
					if (!flag9)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+1C]");
						object obj28 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
						object obj29 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
						bool flag10 = (nint)0 == 0;
						num = 0;
						obj = tuple4;
						if (!flag10)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X9_v19+18]");
							bool flag11 = num7 < 0;
							object obj30 = !flag11;
							if (obj30 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
								object obj31 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
								nint num8 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
								object obj32 = num8 + 0;
								object obj33 = obj32 + 32;
								obj33 = tuple4;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
							else
							{
								list3.AddWithResize(tuple4);
							}
							object item3 = "AvailableVoices" + 560;
							obj5 = obj27;
							tuple5 = (item3, 65536);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+1C]");
							object obj34 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
							object obj35 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
							bool flag12 = (nint)0 == 0;
							num = 0;
							obj = tuple5;
							if (!flag12)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
								nint num9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v22+18]");
								bool flag13 = num9 < 0;
								object obj36 = !flag13;
								if (obj36 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
									object obj37 = (nint)0 + (nint)1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
									nint num10 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
									object obj38 = num10 + 0;
									object obj39 = obj38 + 32;
									obj39 = tuple5;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								}
								else
								{
									list3.AddWithResize(tuple5);
								}
								object item4 = "Complete" + 4008;
								obj13 = obj27;
								tuple6 = (item4, 131072);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+1C]");
								object obj40 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
								obj41 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X0_v119 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
								bool flag14 = (nint)0 == 0;
								num11 = 0;
								tuple7 = tuple6;
								ruleType = (RuleType)list3;
								num = 0;
								obj5 = obj27;
								obj = tuple6;
								if (!flag14)
								{
									goto IL_0c49;
								}
							}
						}
					}
				}
			}
			else
			{
				if (@this == RuleType.CardRule)
				{
					RuleType ruleType2;
					if (card.<Rank>k__BackingField > Rank.JACK)
					{
						if (card.<Rank>k__BackingField != Rank.QUEEN)
						{
							if (card.<Rank>k__BackingField != Rank.KING)
							{
								bool flag15 = card.<Rank>k__BackingField != Rank.ACE;
								num = (int)(nint)intPtr;
								obj = card;
								if (!flag15)
								{
									object obj42 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3896;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									List<(object, int)> list4 = default(List<(object, int)>);
									list4..ctor();
									object obj43 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2224;
									obj = obj43;
									object obj44 = (nint)0 + (nint)3928;
									obj5 = obj44;
									(object, int) tuple8 = (obj43, 0);
									bool flag16 = list4 == null;
									num = 0;
									if (!flag16)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v101 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+1C]");
										object obj45 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v101 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
										object obj46 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v101 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
										bool flag17 = (nint)0 == 0;
										num = 0;
										obj = tuple8;
										if (!flag17)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v101 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
											nint num12 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X9_v13+18]");
											bool flag18 = num12 < 0;
											object obj47 = !flag18;
											if (obj47 == null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v101 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
												object obj48 = (nint)0 + (nint)1;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v101 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
												nint num13 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X0_v101 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
												object obj49 = num13 + 0;
												object obj50 = obj49 + 32;
												obj50 = tuple8;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											}
											else
											{
												list4.AddWithResize(tuple8);
											}
											object obj51 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 2232;
											item = obj51;
											obj13 = obj44;
											num4 = 0;
											item2 = 1;
											tuple2 = ((object, int))(&obj14);
											ruleType = (RuleType)list4;
											goto IL_16ae;
										}
									}
									goto IL_15c3;
								}
								goto IL_15ce;
							}
							bool flag19 = CardUtilExtensions.IsBlack(card);
							object obj52 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3896;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							List<(object, int)> list5 = default(List<(object, int)>);
							list5..ctor();
							object item7;
							object obj57;
							int item8;
							(object, int) tuple10;
							object obj58 = default(object);
							if (flag19)
							{
								object obj53 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3472;
								obj = obj53;
								object obj54 = (nint)0 + (nint)3928;
								obj5 = obj54;
								(object, int) tuple9 = (obj53, 0);
								bool flag20 = list5 == null;
								num = 0;
								if (flag20)
								{
									goto IL_15c3;
								}
								object obj55 = (nint)0 + (nint)3528;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B9B0");
								object item5 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3480;
								tuple5 = (item5, 2);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B9B0");
								object item6 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3456;
								tuple6 = (item6, 4);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B9B0");
								object obj56 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3464;
								item7 = obj56;
								obj57 = 0;
								item8 = 8;
								tuple10 = ((object, int))(&obj58);
							}
							else
							{
								object obj59 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3504;
								obj = obj59;
								object obj60 = (nint)0 + (nint)3928;
								obj5 = obj60;
								(object, int) tuple11 = (obj59, 0);
								bool flag21 = list5 == null;
								num = 0;
								if (flag21)
								{
									goto IL_15c3;
								}
								object obj55 = (nint)0 + (nint)3528;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B9B0");
								object item9 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3512;
								tuple5 = (item9, 16);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B9B0");
								object item10 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3488;
								tuple6 = (item10, 32);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B9B0");
								object obj61 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3496;
								item7 = obj61;
								obj57 = 0;
								item8 = 64;
								tuple10 = ((object, int))(&obj58);
							}
							System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple10, (item7, item8));
							object obj62 = obj57;
							object obj63 = obj58;
							ruleType2 = (RuleType)list5;
						}
						else
						{
							bool flag22 = CardUtilExtensions.IsBlack(card);
							object obj64 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3896;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							List<(object, int)> list6 = default(List<(object, int)>);
							list6..ctor();
							object item12;
							object obj68;
							int item13;
							(object, int) tuple13;
							if (flag22)
							{
								object obj65 = "Picking audio files is not supported on iOS" + 2968;
								obj = obj65;
								object obj66 = (nint)0 + (nint)3928;
								obj5 = obj66;
								(object, int) tuple12 = (obj65, 0);
								bool flag23 = list6 == null;
								num = 0;
								if (flag23)
								{
									goto IL_15c3;
								}
								object obj55 = (nint)0 + (nint)3528;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B9B0");
								object item11 = "Picking audio files is not supported on iOS" + 2960;
								tuple5 = (item11, 128);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B9B0");
								object obj67 = "Picking audio files is not supported on iOS" + 2976;
								item12 = obj67;
								obj68 = 0;
								item13 = 256;
								tuple13 = ((object, int))(&tuple6);
							}
							else
							{
								object obj69 = "Picking audio files is not supported on iOS" + 2984;
								obj = obj69;
								object obj70 = (nint)0 + (nint)3928;
								obj5 = obj70;
								(object, int) tuple14 = (obj69, 0);
								bool flag24 = list6 == null;
								num = 0;
								if (flag24)
								{
									goto IL_15c3;
								}
								object obj55 = (nint)0 + (nint)3528;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B9B0");
								object item14 = "Picking audio files is not supported on iOS" + 2992;
								tuple5 = (item14, 512);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B9B0");
								object obj71 = "Picking audio files is not supported on iOS" + 3000;
								item12 = obj71;
								obj68 = 0;
								item13 = 1024;
								tuple13 = ((object, int))(&tuple6);
							}
							System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple13, (item12, item13));
							object obj62 = obj68;
							object obj63 = tuple6;
							ruleType2 = (RuleType)list6;
						}
					}
					else
					{
						if (card.<Rank>k__BackingField == Rank.TEN)
						{
							object obj72 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3896;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							List<(object, int)> list7 = default(List<(object, int)>);
							list7..ctor();
							object obj73 = "SubscribeGroup request Error" + 1656;
							obj = obj73;
							object obj74 = (nint)0 + (nint)3928;
							obj5 = obj74;
							(object, int) tuple15 = (obj73, 0);
							bool flag25 = list7 == null;
							num = 0;
							if (!flag25)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v35 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+1C]");
								object obj75 = (nint)0 + (nint)1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v35 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
								object obj76 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v35 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
								bool flag26 = (nint)0 == 0;
								num = 0;
								obj = tuple15;
								if (!flag26)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v35 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
									nint num14 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X9_v10+18]");
									bool flag27 = num14 < 0;
									object obj77 = !flag27;
									if (obj77 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v35 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
										object obj78 = (nint)0 + (nint)1;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v35 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
										nint num15 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X0_v35 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
										object obj79 = num15 + 0;
										object obj80 = obj79 + 32;
										obj80 = tuple15;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									}
									else
									{
										list7.AddWithResize(tuple15);
									}
									object obj81 = "SubscribeGroup request Error" + 1664;
									item = obj81;
									obj13 = obj74;
									num4 = 0;
									item2 = 8192;
									tuple2 = ((object, int))(&obj14);
									ruleType = (RuleType)list7;
									goto IL_16ae;
								}
							}
							goto IL_15c3;
						}
						bool flag28 = card.<Rank>k__BackingField != Rank.JACK;
						num = (int)(nint)intPtr;
						obj = card;
						if (flag28)
						{
							goto IL_15ce;
						}
						bool flag29 = CardUtilExtensions.IsBlack(card);
						object obj82 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3896;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						List<(object, int)> list8 = default(List<(object, int)>);
						list8..ctor();
						object item15;
						object obj86;
						int item16;
						(object, int) tuple17;
						if (flag29)
						{
							object obj83 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2736;
							obj = obj83;
							object obj84 = (nint)0 + (nint)3928;
							obj5 = obj84;
							(object, int) tuple16 = (obj83, 0);
							bool flag30 = list8 == null;
							num = 0;
							if (flag30)
							{
								goto IL_15c3;
							}
							object obj55 = (nint)0 + (nint)3528;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B9B0");
							object obj85 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2728;
							item15 = obj85;
							obj86 = 0;
							item16 = 2048;
							tuple17 = ((object, int))(&tuple5);
						}
						else
						{
							object obj87 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2744;
							obj = obj87;
							object obj88 = (nint)0 + (nint)3928;
							obj5 = obj88;
							(object, int) tuple18 = (obj87, 0);
							bool flag31 = list8 == null;
							num = 0;
							if (flag31)
							{
								goto IL_15c3;
							}
							object obj55 = (nint)0 + (nint)3528;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B9B0");
							object obj89 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2752;
							item15 = obj89;
							obj86 = 0;
							item16 = 4096;
							tuple17 = ((object, int))(&tuple5);
						}
						System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple17, (item15, item16));
						object obj62 = obj86;
						object obj63 = tuple5;
						ruleType2 = (RuleType)list8;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223B9B0");
					return (IEnumerable<(string, int)>)ruleType2;
				}
				bool flag32 = @this != RuleType.BaseEntryRule;
				num = (int)(nint)intPtr;
				obj = card;
				if (flag32)
				{
					goto IL_15ce;
				}
				object obj90 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3896;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				List<(object, int)> list9 = default(List<(object, int)>);
				list9..ctor();
				object obj91 = "AvailableVoices" + 368;
				obj = obj91;
				object obj92 = (nint)0 + (nint)3928;
				obj5 = obj92;
				(object, int) tuple19 = (obj91, 0);
				bool flag33 = list9 == null;
				num = 0;
				if (!flag33)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v110 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+1C]");
					object obj93 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v110 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
					object obj94 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v110 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
					bool flag34 = (nint)0 == 0;
					num = 0;
					obj = tuple19;
					if (!flag34)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v110 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
						nint num16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v16+18]");
						bool flag35 = num16 < 0;
						object obj95 = !flag35;
						if (obj95 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v110 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
							object obj96 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v110 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+10]");
							nint num17 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v110 (System.Collections.Generic.List`1<System.ValueTuple`2<System.Object, System.Int32>>)+18]");
							object obj97 = num17 + 0;
							object obj98 = obj97 + 32;
							obj98 = tuple19;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
						else
						{
							list9.AddWithResize(tuple19);
						}
						object obj99 = "Complete" + 4000;
						item = obj99;
						obj13 = obj92;
						num4 = 0;
						item2 = 32768;
						tuple2 = ((object, int))(&obj14);
						ruleType = (RuleType)list9;
						goto IL_16ae;
					}
				}
			}
		}
		goto IL_15c3;
		IL_15ce:
		object obj100 = typeof(RegisteredWaitHandle) + 1608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj101 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj102 = "startPosition" + 3040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj103 = (nint)0 + (nint)336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (IEnumerable<(string, int)>)new OutOfMemoryException();
		IL_16ae:
		System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple2, (item, item2));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X19_v6 (Jackaroo.RuleType)+1C]");
		object obj104 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X19_v6 (Jackaroo.RuleType)+10]");
		obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X19_v6 (Jackaroo.RuleType)+10]");
		bool flag36 = (nint)0 == 0;
		object obj105 = !flag36;
		num11 = num4;
		tuple7 = ((object, int))obj14;
		if (obj105 != null)
		{
			goto IL_0c49;
		}
		num = num4;
		obj5 = obj13;
		obj = obj14;
		goto IL_15c3;
		IL_15c3:
		throw new NullReferenceException();
		IL_0c49:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X19_v6 (Jackaroo.RuleType)+18]");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ X9_v7+18]");
		bool flag37 = num18 < 0;
		object obj106 = !flag37;
		if (obj106 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X19_v6 (Jackaroo.RuleType)+18]");
			object obj107 = (nint)0 + (nint)1;
			object obj108 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X19_v6 (Jackaroo.RuleType)+18]");
			object obj109 = obj108 + 0;
			object obj110 = obj109 + 32;
			obj110 = tuple7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (IEnumerable<(string, int)>)ruleType;
		}
		((List<(object, int)>)ruleType).AddWithResize(tuple7);
		return (IEnumerable<(string, int)>)ruleType;
	}

	public static bool HasRuleFlag(JackarooAllowedRules @this, JackarooAllowedRules flag)
	{
		//IL_0018: Expected O, but got I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		bool result = @this == JackarooAllowedRules.DEFAULT;
		object obj = ~@this;
		object obj2 = flag & obj;
		bool result2 = obj2 == null;
		if (flag == JackarooAllowedRules.DEFAULT)
		{
			return result;
		}
		return result2;
	}
}
