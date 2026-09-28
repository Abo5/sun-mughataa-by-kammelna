using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using ListView;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class GiftsListView : UiGridView<GiftsHolder, ListViewItem<GiftsHolder, int>>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<StoreItem, bool> <>9__4_2;

		public static Func<StoreItem, int> <>9__4_3;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <SetupData>b__4_2(StoreItem i)
		{
			//IL_003d: Expected I4, but got O
			if (i != null)
			{
				return i.IsActiveAndNotAd;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <SetupData>b__4_3(StoreItem i)
		{
			//IL_0035: Expected I4, but got O
			if (i != null)
			{
				return i.<Order>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public GiftsListView <>4__this;

		public int index;

		internal IEnumerable<GiftsHolder> <SetupData>g__GetCategoryGifts|0(ItemCategory category)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_0227: Expected O, but got Unknown
			//IL_0251: Expected O, but got I4
			//IL_005f: Expected O, but got I4
			//IL_026b: Expected O, but got I
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Expected O, but got Unknown
			//IL_028b: Expected O, but got I
			//IL_029b: Expected O, but got I
			//IL_02ab: Expected O, but got I
			//IL_02cd: Expected O, but got I4
			//IL_010e: Expected I, but got O
			//IL_00a6: Expected O, but got I4
			//IL_014e: Expected O, but got I4
			//IL_02f1: Expected O, but got I
			//IL_0302: Expected I, but got O
			//IL_0320: Expected O, but got I
			//IL_034b: Expected O, but got I
			//IL_035a: Unknown result type (might be due to invalid IL or missing references)
			//IL_035f: Expected O, but got Unknown
			//IL_036b: Expected O, but got I
			//IL_037c: Expected O, but got I
			//IL_038c: Expected O, but got I
			//IL_03ae: Expected O, but got I4
			//IL_03b7: Expected O, but got I4
			//IL_00d6: Expected O, but got I
			//IL_01f8: Expected I, but got O
			//IL_0195: Expected O, but got I4
			//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d9: Expected O, but got Unknown
			//IL_03ef: Expected O, but got I
			//IL_0400: Expected I, but got O
			//IL_041e: Expected O, but got I
			//IL_0439: Expected O, but got I4
			//IL_01c5: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
			object obj2 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 368;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IEnumerable<StoreItem> categoryItems = Store.GetCategoryItems(category);
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj2;
			}
			object obj7 = (nint)0 + (nint)3768;
			object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3432;
			object obj9 = (nint)0 + (nint)3376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v7+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v18+8]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v18+8]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v7+E4]");
				bool flag4 = (nint)0 == 0;
				object obj12 = !flag4;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj13 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v22+B8]");
					obj10 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj14 = (nint)0 + (nint)2280;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj10, (IntPtr)obj14);
				object obj15 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v21+B8]");
				object obj16 = (nint)0 + (nint)8;
				obj16 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				predicate = func;
			}
			IEnumerable<object> source = Enumerable.Where(categoryItems, predicate);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor((object)<>4__this, (IntPtr)obj9);
			IEnumerable<object> source2 = Enumerable.Where(source, func2);
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v16+E4]");
			bool flag5 = (nint)0 == 0;
			object obj18 = !flag5;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj2;
			}
			object obj19 = (nint)0 + (nint)2232;
			object obj20 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3440;
			object obj21 = (nint)0 + (nint)2296;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v16+B8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v10+10]");
			Func<object, int> keySelector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v10+10]");
			bool flag6 = (nint)0 == 0;
			object obj23 = !flag6;
			object obj24 = 0;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v16+E4]");
				bool flag7 = (nint)0 == 0;
				object obj25 = !flag7;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj26 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v16+B8]");
					obj22 = 0;
				}
				object obj27 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3448;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj28 = (nint)0 + (nint)2288;
				Func<object, int> func3 = default(Func<object, int>);
				func3..ctor(obj22, (IntPtr)obj28);
				object obj29 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v15+B8]");
				object obj30 = (nint)0 + (nint)16;
				obj30 = func3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj24 = 0;
				keySelector = func3;
			}
			IOrderedEnumerable<object> source3 = Enumerable.OrderBy(source2, keySelector);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, object> func4 = default(Func<object, object>);
			func4..ctor((object)this, (IntPtr)obj21);
			return (IEnumerable<GiftsHolder>)Enumerable.Select(source3, func4);
		}

		internal GiftsHolder <SetupData>b__4(StoreItem gift)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2912;
			int num = index + 1;
			index = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			GiftsHolder giftsHolder = default(GiftsHolder);
			giftsHolder..ctor(gift, index);
			return giftsHolder;
		}

		internal GiftsHolder <SetupData>g__Separator|1()
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			int num = index + 1;
			index = num;
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2912;
			object obj2 = "Unsupported map type" + 2608;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = default(object);
			obj3..ctor();
			_ = index;
			object obj4 = obj3 + 24;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 4294967295L;
			return (GiftsHolder)obj3;
		}
	}

	private KGame _game;

	public void Initialize(KGame game)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0077: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj2 = (nint)0 + (nint)3384;
		KGame game2 = default(KGame);
		_game = game2;
		object obj3 = this + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)obj2);
		_game.OnPlayerSwitchSeat += playerSwitchSeatDelegate;
		SetupData();
	}

	private void OnDestroy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		if ((object)_game != null)
		{
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
			object obj2 = (nint)0 + (nint)3384;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
			playerSwitchSeatDelegate..ctor(this, (IntPtr)obj2);
			_game.OnPlayerSwitchSeat -= playerSwitchSeatDelegate;
		}
	}

	private void OnPlayerSwitchSeat(int userID, string error)
	{
		SetupData();
	}

	public void SetupData()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_008c: Expected O, but got I
		//IL_0098: Expected O, but got I
		//IL_025b: Expected I, but got O
		//IL_026b: Expected O, but got I
		//IL_027b: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_0127: Expected O, but got I
		//IL_018b: Expected O, but got I4
		//IL_0200: Expected O, but got I
		//IL_0210: Expected O, but got I
		//IL_0220: Expected O, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 376;
		object obj2 = default(object);
		List<object> list = default(List<object>);
		object obj11 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			object obj3 = typeof(List<AdaptivePerformanceScaler>) + 1224;
			object obj4 = obj2 + 16;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			list..ctor();
			IEnumerable<GiftsHolder> collection = ((<>c__DisplayClass4_0)obj2).<SetupData>g__GetCategoryGifts|0(ItemCategory.AnimatedGifts);
			object obj5 = (nint)0 + (nint)2816;
			object obj6 = (nint)0 + (nint)2176;
			object obj7 = obj5;
			list.AddRange(collection);
			if (Enumerable.Any(list))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Object)+18]");
				object obj8 = (nint)0 + (nint)1;
				object obj9 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2912;
				object obj10 = "Unsupported map type" + 2608;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj11..ctor();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Object)+18]");
				_ = 0;
				object obj12 = obj11 + 24;
				obj12 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj13 = (nint)0 + (nint)2808;
				_ = 4294967295L;
				object obj14 = obj13;
				int version = list._version + 1;
				list._version = version;
				object[] items = list._items;
				bool flag = list._size < items.Length;
				object obj15 = !flag;
				if (obj15 == null)
				{
					int num = list._size + 1;
					list._size = num;
					object obj16 = items + list._size;
					object obj17 = obj16 + 32;
					obj17 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v10+20]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v11+C0]");
					object obj19 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v12+70]");
					obj7 = 0;
					list.AddWithResize(obj11);
				}
			}
			IEnumerable<GiftsHolder> collection2 = ((<>c__DisplayClass4_0)obj2).<SetupData>g__GetCategoryGifts|0(ItemCategory.Gifts);
			list.AddRange(collection2);
			nint num2 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v5 (Il2CppClass<GiftsListView>)+2A8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v5 (Il2CppClass<GiftsListView>)+2B0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v115 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private bool EmotesFilter(StoreItem i)
	{
		//IL_009f: Expected I4, but got O
		if (i != null)
		{
			ItemCategory category = i.GetCategory();
			if (category != ItemCategory.AnimatedGifts)
			{
				return true;
			}
			if ((object)_game != null)
			{
				bool isSpectator = _game.IsSpectator;
				return (byte)((isSpectator ? 1u : 0u) ^ 1u) != 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public GiftsListView()
	{
		((UiGridView<object, object>)(object)this)..ctor();
	}
}
