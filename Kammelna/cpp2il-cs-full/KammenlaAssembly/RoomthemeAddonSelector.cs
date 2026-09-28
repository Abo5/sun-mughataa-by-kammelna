using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class RoomthemeAddonSelector : TournamentAddonSelector
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<TournamentRoomThemeItem> <>9__20_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Refresh>b__20_0(TournamentRoomThemeItem p)
		{
			p.Refresh();
		}
	}

	private sealed class <>c__DisplayClass18_0
	{
		public StoreItem item;

		internal bool <Populate>b__0(TournamentRoomThemeItem rt)
		{
			//IL_008a: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if ((object)rt != null)
			{
				StoreItem storeItem = item;
				if (item != null)
				{
					object obj = rt.<roomThemeId>k__BackingField - storeItem.<id>k__BackingField;
					bool flag = obj == null;
					return !flag;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass22_0
	{
		public RoomThemeTournamentAddon addon;

		internal bool <ShowConfirmedSelection>b__0(TournamentRoomThemeItem roomThemeItem)
		{
			//IL_005f: Expected I4, but got O
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Expected O, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected I4, but got Unknown
			if ((object)roomThemeItem != null)
			{
				int? num = (int?)addon;
				if (addon != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4 (System.Nullable`1<System.Int32>)+10]");
					int? num2 = 0;
					num = num2;
				}
				object obj = (object?)num >> 32;
				object obj2 = roomThemeItem.<roomThemeId>k__BackingField - obj;
				bool flag = obj2 == null;
				return (byte)((flag & (??)num) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private new Action m_OnValidStateChange;

	private TournamentRoomThemeItem itemPrefab;

	private Transform parent;

	private List<TournamentRoomThemeItem> populatedItems;

	private TournamentRoomThemeItem <selectedItem>k__BackingField;

	public override string Title => "Read object reference Id '{0}' for {1}." + 3496;

	public override string Subtitle => "rightCtrl" + 2160;

	public override TournamentAddonType addonType => TournamentAddonType.RoomTheme;

	public override bool IsValid
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0067: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return <selectedItem>k__BackingField != null;
		}
	}

	public TournamentRoomThemeItem selectedItem
	{
		get
		{
			return <selectedItem>k__BackingField;
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

	public override event Action OnValidStateChange
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public unsafe void Populate(IEnumerable<StoreItem> themes)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_0128: Expected I, but got O
		//IL_0b44: Expected O, but got I
		//IL_0af6: Expected O, but got I4
		//IL_0b06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0b: Expected O, but got Unknown
		//IL_0a29: Expected O, but got I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01b7: Expected O, but got I
		//IL_01c3: Expected O, but got I
		//IL_01ed: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_014c: Expected O, but got I
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_02bd: Expected O, but got I
		//IL_00ad: Expected O, but got I
		//IL_00c7: Expected O, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_03a4: Expected I, but got O
		//IL_0bdc: Expected I4, but got O
		//IL_0bec: Expected O, but got I
		//IL_0bff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c04: Expected O, but got Unknown
		//IL_082f: Expected O, but got I4
		//IL_0850: Expected O, but got I4
		//IL_0b96: Expected O, but got I4
		//IL_0ba6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bab: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected I4, but got Unknown
		//IL_03b6: Expected O, but got I4
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got Unknown
		//IL_0cca: Expected O, but got I4
		//IL_0329: Expected O, but got I
		//IL_0343: Expected O, but got I4
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_0869: Expected O, but got Unknown
		//IL_0881: Expected O, but got I
		//IL_091c: Expected I, but got O
		//IL_044c: Expected O, but got I
		//IL_0d0c: Expected O, but got I
		//IL_0533: Expected I, but got O
		//IL_0c89: Expected I4, but got O
		//IL_092e: Expected O, but got I4
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected O, but got Unknown
		//IL_0949: Unknown result type (might be due to invalid IL or missing references)
		//IL_094e: Expected O, but got Unknown
		//IL_0c43: Expected O, but got I4
		//IL_0c53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c58: Expected O, but got Unknown
		//IL_08e5: Expected O, but got I
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		//IL_0545: Expected O, but got I4
		//IL_0552: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_0565: Expected O, but got Unknown
		//IL_05c4: Expected I, but got O
		//IL_05cc: Expected I, but got O
		//IL_04b8: Expected O, but got I
		//IL_04d2: Expected O, but got I4
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_0266: Expected O, but got I4
		//IL_0277: Expected O, but got I4
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_0627: Expected O, but got Unknown
		//IL_0651: Expected O, but got I4
		//IL_0a01: Expected O, but got I4
		//IL_09d5: Expected O, but got I4
		//IL_09da: Expected I, but got O
		//IL_06f1: Expected O, but got I
		//IL_06f9: Expected I4, but got O
		//IL_0776: Expected O, but got I4
		//IL_078a: Expected O, but got I4
		//IL_020a: Expected O, but got I
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected O, but got Unknown
		//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected O, but got Unknown
		//IL_0810: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C6C]");
		int num = 0;
		bool flag2 = default(bool);
		IEnumerable<StoreItem> enumerable = default(IEnumerable<StoreItem>);
		int num4 = default(int);
		if (enumerable != null)
		{
			object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3752;
			nint num2 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<StoreItem>>)+12E]");
			object[] array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<StoreItem>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0119;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<StoreItem>>)+B0]");
			int num3 = (int)((nint)0 + (nint)8);
			bool flag = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X10_v32 (System.Int32)-8]");
				bool flag3 = 0 < (nint)obj;
				object obj2 = !flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X10_v32 (System.Int32)-8]");
				object obj3 = 0 - obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X10_v32 (System.Int32)-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				num4 = num3 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<StoreItem>>)+12E]");
				array = (object[])(-1);
				bool flag4 = (nint)array < 1;
				obj2 = !flag4;
				obj3 = array - 1;
				bool flag5 = obj3 == null;
				flag2 = (nint)array != 1;
				flag = flag2;
				num3 = num4;
				if (flag2)
				{
					continue;
				}
				goto IL_0119;
			}
			array = (object[])((int*)num3)->m_value;
			object obj4 = num2 + ((int*)num3)->m_value;
			object obj5 = obj4 + 312;
			flag2 = flag;
			num4 = num3;
			goto IL_0b34;
		}
		goto IL_0d38;
		IL_096a:
		NullReferenceException ex = new NullReferenceException();
		object obj7;
		object obj6 = obj7;
		nint num6;
		nint num5 = num6;
		int num7;
		num4 = num7;
		IEnumerable<StoreItem> enumerable3 = default(IEnumerable<StoreItem>);
		IEnumerable<StoreItem> enumerable2 = enumerable3;
		goto IL_0a16;
		IL_0a16:
		object obj9 = default(object);
		object obj8 = obj9;
		object obj10 = 0;
		enumerable = enumerable2;
		goto IL_0d38;
		IL_09c3:
		NullReferenceException ex2 = new NullReferenceException();
		obj6 = 0;
		num5 = (nint)this;
		num4 = num7;
		object obj11;
		enumerable2 = (IEnumerable<StoreItem>)obj11;
		goto IL_0a16;
		IL_09ef:
		NullReferenceException ex3 = new NullReferenceException();
		obj6 = 0;
		num4 = num7;
		IEnumerable<object> enumerable4 = default(IEnumerable<object>);
		enumerable2 = (IEnumerable<StoreItem>)enumerable4;
		goto IL_0a16;
		IL_095c:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0a16;
		IL_0119:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num5 = unchecked((nint)null);
		goto IL_0b34;
		IL_0b34:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v22+8]");
		enumerable2 = (IEnumerable<StoreItem>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v282 @ X0_v22] (should have been resolved before IL gen)");
		bool flag6 = obj9 == null;
		num = (int)(&obj8);
		if (flag6)
		{
			goto IL_095c;
		}
		object obj12 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj13 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1184;
		object obj14 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3968;
		object obj15 = (nint)0 + (nint)944;
		object obj16 = (nint)0 + (nint)1992;
		obj7 = obj6;
		IEnumerable<object> enumerable5 = enumerable4;
		num6 = num5;
		num7 = num4;
		obj11 = 152985600;
		object obj17 = obj9;
		object obj20 = default(object);
		object obj22 = default(object);
		object obj23 = default(object);
		Func<object, bool> func = default(Func<object, bool>);
		TournamentRoomThemeItem tournamentRoomThemeItem = default(TournamentRoomThemeItem);
		object obj32 = default(object);
		object obj41 = default(object);
		while (true)
		{
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v22+12E]");
			object[] array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v22+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0395;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v22+B0]");
			int num8 = (int)((nint)0 + (nint)8);
			bool flag7 = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X10_v27 (System.Int32)-8]");
				bool flag8 = 0 < (nint)obj12;
				object obj2 = !flag8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X10_v27 (System.Int32)-8]");
				object obj3 = 0 - obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X10_v27 (System.Int32)-8]");
				if (0 == (nint)obj12)
				{
					break;
				}
				num7 = num8 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v22+12E]");
				array = (object[])(-1);
				bool flag9 = (nint)array < 1;
				obj2 = !flag9;
				obj3 = array - 1;
				bool flag5 = obj3 == null;
				flag2 = (nint)array != 1;
				flag7 = flag2;
				num8 = num7;
				if (flag2)
				{
					continue;
				}
				goto IL_0395;
			}
			array = (object[])((int*)num8)->m_value;
			object obj19 = obj18 + ((int*)num8)->m_value;
			obj20 = obj19 + 312;
			flag2 = flag7;
			num7 = num8;
			goto IL_0bd4;
			IL_024e:
			bool flag10 = obj9 == null;
			obj7 = 0;
			obj17 = obj9;
			obj6 = 0;
			enumerable4 = enumerable5;
			num5 = num6;
			num4 = num7;
			object obj21;
			enumerable2 = (IEnumerable<StoreItem>)obj21;
			if (!flag10)
			{
				continue;
			}
			goto IL_095c;
			IL_0524:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num6 = unchecked((nint)null);
			goto IL_0c81;
			IL_0c81:
			num = (int)obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v731 @ X0_v35] (should have been resolved before IL gen)");
			if (obj23 == null)
			{
				goto IL_096a;
			}
			obj11 = obj23 + 16;
			obj11 = enumerable3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			enumerable5 = populatedItems;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor(obj23, (IntPtr)obj15);
			num6 = (nint)obj16;
			bool flag11 = Enumerable.All(populatedItems, func);
			bool flag12 = !flag11;
			obj21 = func;
			if (flag12)
			{
				goto IL_024e;
			}
			enumerable4 = (IEnumerable<object>)parent;
			object obj24 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X0_v45+E4]");
			bool flag13 = (nint)0 == 0;
			object obj26 = !flag13;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			num = (int)((nint)0 + (nint)832);
			num5 = ((int*)num)->m_value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			if ((object)tournamentRoomThemeItem != null)
			{
				tournamentRoomThemeItem.PopulateInfo((StoreItem)obj11, this);
				List<object> list = (List<object>)(object)populatedItems;
				if (populatedItems != null)
				{
					object obj27 = (nint)0 + (nint)1504;
					num = (int)obj27;
					int version = list._version + 1;
					list._version = version;
					array = list._items;
					if (list._items != null)
					{
						num7 = list._size;
						bool flag14 = list._size < array.Length;
						object obj2 = !flag14;
						object obj3 = list._size - array.Length;
						bool flag5 = obj3 == null;
						if (obj2 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v42 (System.Int32)+20]");
							object obj28 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v40+C0]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v42 (System.Int32)+70]");
							num6 = 0;
							((List<object>)(object)populatedItems).AddWithResize((object)tournamentRoomThemeItem);
							enumerable5 = enumerable4;
							obj21 = tournamentRoomThemeItem;
						}
						else
						{
							num = list._size + 1;
							list._size = num;
							object obj29 = list._items + list._size;
							object obj30 = obj29 + 32;
							obj30 = tournamentRoomThemeItem;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							enumerable5 = enumerable4;
							num6 = (nint)this;
							obj21 = tournamentRoomThemeItem;
						}
						goto IL_024e;
					}
				}
				goto IL_09c3;
			}
			goto IL_09ef;
			IL_0395:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num6 = unchecked((nint)null);
			goto IL_0bd4;
			IL_0bd4:
			num = (int)obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v29+8]");
			enumerable = (IEnumerable<StoreItem>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v538 @ X0_v29] (should have been resolved before IL gen)");
			object obj31 = obj32 & 1;
			if (obj31 != null)
			{
				num = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2168;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj23..ctor();
				if (obj9 == null)
				{
					break;
				}
				object obj33 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v27+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v27+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0524;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v27+B0]");
				int num9 = (int)((nint)0 + (nint)8);
				bool flag15 = flag2;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X10_v22 (System.Int32)-8]");
					bool flag16 = 0 < (nint)obj13;
					object obj2 = !flag16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X10_v22 (System.Int32)-8]");
					object obj3 = 0 - obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v716 @ X10_v22 (System.Int32)-8]");
					if (0 == (nint)obj13)
					{
						break;
					}
					num7 = num9 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v27+12E]");
					array = (object[])(-1);
					bool flag17 = (nint)array < 1;
					obj2 = !flag17;
					obj3 = array - 1;
					bool flag5 = obj3 == null;
					flag2 = (nint)array != 1;
					flag15 = flag2;
					num9 = num7;
					if (flag2)
					{
						continue;
					}
					goto IL_0524;
				}
				array = (object[])((int*)num9)->m_value;
				object obj34 = obj33 + ((int*)num9)->m_value;
				obj22 = obj34 + 312;
				flag2 = flag15;
				num7 = num9;
				goto IL_0c81;
			}
			obj8 = obj9;
			obj10 = 0;
			obj6 = obj7;
			num5 = num6;
			num4 = num7;
			object obj35 = 0;
			while (true)
			{
				if (obj8 == null)
				{
					goto IL_0cb0;
				}
				object obj36 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj37 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v8+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v8+12E]");
				if ((nint)0 == 0)
				{
					goto IL_090d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v8+B0]");
				int num10 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X10_v8 (System.Int32)-8]");
					if (0 == (nint)obj36)
					{
						break;
					}
					num4 = num10 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v8+12E]");
					array = (object[])(-1);
					bool flag18 = (nint)array != 1;
					num10 = num4;
					if (flag18)
					{
						continue;
					}
					goto IL_090d;
				}
				array = (object[])((int*)num10)->m_value;
				object obj38 = obj37 + ((int*)num10)->m_value;
				object obj39 = obj38 + 312;
				num4 = num10;
				goto IL_0cfc;
				IL_0cb0:
				bool flag19 = obj35 == null;
				object obj40 = !flag19;
				if (obj40 == null)
				{
					return;
				}
				OutOfMemoryException ex5 = new OutOfMemoryException();
				if ((nint)enumerable != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj35 = obj41;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj10 = obj41;
				continue;
				IL_090d:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num5 = unchecked((nint)null);
				goto IL_0cfc;
				IL_0cfc:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X0_v6+8]");
				enumerable = (IEnumerable<StoreItem>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v670 @ X0_v6] (should have been resolved before IL gen)");
				goto IL_0cb0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
		}
		NullReferenceException ex6 = new NullReferenceException();
		obj6 = obj7;
		num5 = num6;
		num4 = num7;
		enumerable2 = null;
		goto IL_0a16;
		IL_0d38:
		throw new NullReferenceException();
	}

	public override void Clear()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0023: Expected I, but got O
		//IL_0033: Expected O, but got I
		//IL_0043: Expected O, but got I
		object obj = this + 72;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<RoomthemeAddonSelector>)+1E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<RoomthemeAddonSelector>)+1F0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v30 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override void Refresh()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_0241: Expected O, but got I4
		//IL_01d7: Expected O, but got I
		//IL_01e7: Expected O, but got I
		//IL_0209: Expected O, but got I4
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_02ed: Expected O, but got I
		//IL_02fe: Expected I, but got O
		//IL_031c: Expected O, but got I
		//IL_0290: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_0271: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6C6D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_015b;
		}
		List<TournamentRoomThemeItem> list = populatedItems;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = obj4;
		List<TournamentRoomThemeItem> list2 = populatedItems;
		if (!flag)
		{
			goto IL_0099;
		}
		goto IL_01b5;
		IL_01b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v5+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v5+8]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		list = list2;
		if (obj7 != null)
		{
			goto IL_00e6;
		}
		goto IL_021f;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+B8]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v5+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v5+8]");
		bool flag3 = (nint)0 == 0;
		list2 = list;
		if (!flag3)
		{
			goto IL_00e6;
		}
		goto IL_021f;
		IL_00e6:
		List<object> list3 = (List<object>)(object)list;
		goto IL_00f3;
		IL_00f3:
		list3.ForEach(action);
		Action onValidStateChange = OnValidStateChange;
		if (OnValidStateChange != null)
		{
			IntPtr invoke_impl = ((Delegate)onValidStateChange).invoke_impl;
			IntPtr method_code = ((Delegate)onValidStateChange).method_code;
			IntPtr method = ((Delegate)onValidStateChange).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v161 @ X2_v6 (System.IntPtr) (should have been resolved before IL gen)");
			goto IL_015b;
		}
		return;
		IL_021f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+B8]");
			obj6 = 0;
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3808;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)936;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj6, (IntPtr)obj11);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v10+B8]");
		object obj13 = (nint)0 + (nint)8;
		obj13 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag5 = list2 == null;
		object obj14 = !flag5;
		object obj15 = 0;
		action = action2;
		list3 = (List<object>)(object)list2;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00f3;
		IL_015b:
		_ = 1;
		list = populatedItems;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v4+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		obj5 = obj4;
		list2 = populatedItems;
		if (obj16 != null)
		{
			goto IL_0099;
		}
		goto IL_01b5;
	}

	public override void OnConfirm()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 1432;
		int num = default(int);
		string s = num.ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		int num2 = int.Parse(s);
		eventsChannel.TriggerAddAddon((TournamentAddonModel)obj2);
	}

	public override void ShowConfirmedSelection(TournamentAddonModel tournamentAddonModel)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_019f: Expected O, but got I4
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_0240: Expected O, but got I
		//IL_024c: Expected O, but got I
		//IL_0271: Expected I, but got O
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_005a: Expected I, but got O
		//IL_0083: Expected O, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01de: Expected I, but got O
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_00b7: Expected O, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00fc: Expected I, but got O
		//IL_0125: Expected O, but got I4
		//IL_0159: Expected O, but got I
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2176;
		object obj2 = default(object);
		Func<object, bool> func = default(Func<object, bool>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			if (tournamentAddonModel != null)
			{
				object obj3 = typeof(RegisteredWaitHandle) + 1432;
				object obj4 = obj3;
				nint num = (nint)tournamentAddonModel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X9_v3 (Il2CppClass<TournamentAddonModel>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X1_v9+130]");
				bool flag = num2 < 0;
				object obj5 = !flag;
				object obj6 = ~obj5;
				if (obj6 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X9_v3 (Il2CppClass<TournamentAddonModel>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X1_v9+130]");
				object obj7 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X9_v6-8]");
				if (0 != (nint)obj4)
				{
					break;
				}
				object obj8 = obj2 + 16;
				obj8 = tournamentAddonModel;
				nint num4 = (nint)tournamentAddonModel;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v8 (Il2CppClass<TournamentAddonModel>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X1_v9+130]");
				bool flag2 = num5 < 0;
				object obj9 = !flag2;
				object obj10 = ~obj9;
				if (obj10 != null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X9_v8 (Il2CppClass<TournamentAddonModel>)+C8]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X1_v9+130]");
				object obj11 = num6 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v10-8]");
				if (0 != (nint)obj4)
				{
					break;
				}
			}
			else
			{
				object obj8 = obj2 + 16;
				obj8 = 0;
			}
			object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3968;
			object obj13 = (nint)0 + (nint)952;
			object obj14 = (nint)0 + (nint)1344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor(obj2, (IntPtr)obj13);
			object obj15 = Enumerable.FirstOrDefault(populatedItems, func);
			object obj16 = this + 72;
			obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			nint num7 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v4 (Il2CppClass<RoomthemeAddonSelector>)+1E8]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v4 (Il2CppClass<RoomthemeAddonSelector>)+1F0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v192 @ X2_v3 (should have been resolved before IL gen)");
		}
		throw new InvalidCastException();
	}

	public void SelectItem(TournamentRoomThemeItem itemToSelect)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0022: Expected I, but got O
		//IL_0032: Expected O, but got I
		//IL_0042: Expected O, but got I
		object obj = this + 72;
		obj = itemToSelect;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<RoomthemeAddonSelector>)+1E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v1 (Il2CppClass<RoomthemeAddonSelector>)+1F0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v30 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public RoomthemeAddonSelector()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 4024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 64;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((MonoBehaviour)this)..ctor();
	}
}
