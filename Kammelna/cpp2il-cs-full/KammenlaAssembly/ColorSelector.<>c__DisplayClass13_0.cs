using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.Rendering;

public class ColorSelector : MonoBehaviour
{
	private sealed class <>c__DisplayClass10_0
	{
		public Color previous;

		internal bool <RefreshPalette>b__0(ColorSelectorItem i)
		{
			//IL_00d5: Expected I4, but got O
			//IL_0074: Expected O, but got I
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			if ((object)i != null)
			{
				object obj = i.<Color>k__BackingField - previous;
				object obj2 = obj * obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				object obj3 = obj2 + (object)previous;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [i @ X1 (ColorSelectorItem)+40]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ColorSelector+<>c__DisplayClass10_0)+18]");
				object obj4 = num - 0;
				object obj5 = obj4 * obj4;
				object obj6 = obj5 + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				object obj7 = obj5 + obj6;
				object obj8 = obj7 - 786163454;
				return (nint)obj8 < 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass11_0
	{
		public ColorSelector <>4__this;

		public ColorSelectorItem prevItem;

		internal void <SetSelectedItem>g__UndoAction|0()
		{
			<>4__this.SetSelectedItem(prevItem, addUndo: false);
		}
	}

	private sealed class <>c__DisplayClass13_0
	{
		public Color color;

		internal bool <SetSelectedItemByColor>b__0(ColorSelectorItem i)
		{
			//IL_00d5: Expected I4, but got O
			//IL_0074: Expected O, but got I
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Expected O, but got Unknown
			if ((object)i != null)
			{
				object obj = i.<Color>k__BackingField - color;
				object obj2 = obj * obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				object obj3 = obj2 + (object)color;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [i @ X1 (ColorSelectorItem)+40]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ColorSelector+<>c__DisplayClass13_0)+18]");
				object obj4 = num - 0;
				object obj5 = obj4 * obj4;
				object obj6 = obj5 + obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				object obj7 = obj5 + obj6;
				object obj8 = obj7 - 786163454;
				return (nint)obj8 < 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private ColorSelectorItem itemPrefab;

	private Color[] availableColors;

	private Transform layout;

	private CanvasGroup canvasGroup;

	public UnityEvent<Color, Action> OnItemSelected;

	private readonly ItemPicker<ColorSelectorItem> itemPicker;

	private bool _initialized;

	public void SetEnabled(bool enabled)
	{
		//IL_002e: Expected O, but got I4
		canvasGroup.interactable = enabled;
		bool flag = !enabled;
		object obj = !flag;
		object obj2 = ~obj;
		float alpha = ((obj2 != null) ? 0.5f : 1f);
		canvasGroup.alpha = alpha;
	}

	public void SetAvailableColors(IReadOnlyList<Color> colors)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		if (!ArraysExtensions.IsNullOrEmpty(colors))
		{
			Color[] array = Enumerable.ToArray(colors);
			object obj = this + 40;
			obj = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public void Init(IReadOnlyList<Color> colors)
	{
		//IL_0734: Expected O, but got I4
		//IL_001c: Expected O, but got I
		//IL_0751: Unknown result type (might be due to invalid IL or missing references)
		//IL_0756: Expected O, but got Unknown
		//IL_0762: Expected O, but got I
		//IL_0791: Expected O, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_06e6: Expected O, but got I
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Expected O, but got Unknown
		//IL_0660: Expected O, but got I4
		//IL_0689: Expected O, but got I
		//IL_0691: Expected I, but got O
		//IL_06b5: Expected O, but got I4
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0113: Expected O, but got I
		//IL_011f: Expected O, but got I
		//IL_0147: Expected O, but got I
		//IL_0150: Expected O, but got I4
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Expected O, but got Unknown
		//IL_0293: Expected O, but got I4
		//IL_02d9: Expected I, but got O
		//IL_034b: Expected I, but got O
		//IL_0551: Expected O, but got I
		//IL_0559: Expected I, but got O
		//IL_037e: Expected O, but got I4
		//IL_059b: Expected O, but got I
		//IL_05b7: Expected I, but got O
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I
		//IL_0203: Expected O, but got I
		//IL_0213: Expected O, but got I
		//IL_0233: Expected O, but got I
		//IL_0243: Expected O, but got I
		//IL_0253: Expected O, but got I
		//IL_025b: Expected I, but got O
		//IL_03a5: Expected O, but got I
		//IL_03b5: Expected O, but got I
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_0416: Expected O, but got I
		//IL_0426: Expected O, but got I
		//IL_0436: Expected O, but got I
		//IL_0446: Expected O, but got I
		//IL_0474: Expected O, but got I
		//IL_0484: Expected O, but got I
		//IL_0494: Expected O, but got I
		//IL_0616: Expected O, but got I
		bool flag = !_initialized;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		_initialized = true;
		object obj2 = (nint)0 + (nint)2536;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 616;
		object obj4 = (nint)0 + (nint)3712;
		Color[] array = (Color[])obj2;
		bool flag2 = ArraysExtensions.IsNullOrEmpty(colors);
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			Color[] array2 = Enumerable.ToArray(colors);
			object obj6 = this + 40;
			obj6 = array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			array = array2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = obj4;
		List<object> list = default(List<object>);
		list..ctor();
		Color[] array3 = availableColors;
		bool flag4 = availableColors == null;
		ColorSelector colorSelector = this;
		nint num = default(nint);
		ColorSelectorItem colorSelectorItem2 = default(ColorSelectorItem);
		ColorSelector manager;
		ColorSelector color;
		if (!flag4)
		{
			if (list != null)
			{
				if (array3.Length < 1)
				{
					goto IL_04bb;
				}
				object obj8 = availableColors + 44;
				object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj10 = (nint)0 + (nint)512;
				object obj11 = (nint)0 + (nint)3720;
				object obj13 = default(object);
				object obj12 = obj13;
				object obj15 = default(object);
				object obj14 = obj15;
				object obj17 = default(object);
				object obj16 = obj17;
				object obj19 = default(object);
				object obj18 = obj19;
				ColorSelector colorSelector2 = (ColorSelector)num;
				object obj20 = 0;
				ColorSelectorItem colorSelectorItem = default(ColorSelectorItem);
				while (true)
				{
					object obj21 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X0_v29+E4]");
					bool flag5 = (nint)0 == 0;
					object obj22 = !flag5;
					if (obj22 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					colorSelector2 = (ColorSelector)obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
					bool flag6 = (object)colorSelectorItem == null;
					num = (nint)obj10;
					colorSelector = this;
					if (flag6)
					{
						break;
					}
					colorSelectorItem.Init((Color)this, (ColorSelector)obj10);
					object obj23 = obj11;
					int version = list._version + 1;
					list._version = version;
					object[] items = list._items;
					bool flag7 = list._items == null;
					num = (nint)obj10;
					colorSelector = this;
					if (flag7)
					{
						break;
					}
					bool flag8 = list._size < items.Length;
					object obj24 = !flag8;
					object obj25 = ~obj24;
					if (obj25 != null)
					{
						int size = list._size + 1;
						list._size = size;
						object obj26 = list._items + list._size;
						object obj27 = obj26 + 32;
						obj27 = colorSelectorItem;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj8 += 16;
						obj20++;
						bool flag9 = (nint)obj20 >= array3.Length;
						obj12 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X25_v8-4]");
						obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X25_v8-8]");
						obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X25_v8-C]");
						obj18 = 0;
						obj7 = colorSelectorItem;
						obj13 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X25_v8-4]");
						obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X25_v8-8]");
						obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X25_v8-C]");
						obj19 = 0;
						num = (nint)obj10;
						if (!flag9)
						{
							continue;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v23+20]");
						object obj28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X8_v24+C0]");
						object obj29 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v25+70]");
						num = 0;
						list.AddWithResize((object)colorSelectorItem);
						obj8 += 16;
						obj20++;
						bool flag10 = (nint)obj20 < array3.Length;
						obj12 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X25_v8-4]");
						obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X25_v8-8]");
						obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X25_v8-C]");
						obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v25+70]");
						colorSelector2 = (ColorSelector)0;
						obj7 = colorSelectorItem;
						if (flag10)
						{
							continue;
						}
						obj13 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X25_v8-4]");
						obj15 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X25_v8-8]");
						obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X25_v8-C]");
						obj19 = 0;
					}
					goto IL_04bb;
				}
			}
			else
			{
				if (array3.Length < 1)
				{
					goto IL_04bb;
				}
				object obj30 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj31 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X0_v23+E4]");
				bool flag11 = (nint)0 == 0;
				object obj32 = !flag11;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj33 = (nint)0 + (nint)512;
				num = (nint)obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
				bool flag12 = (object)colorSelectorItem2 == null;
				object obj34 = !flag12;
				colorSelector = this;
				manager = (ColorSelector)obj33;
				color = this;
				if (obj34 != null)
				{
					goto IL_06fb;
				}
			}
		}
		goto IL_06d5;
		IL_06d5:
		NullReferenceException ex = new NullReferenceException();
		manager = (ColorSelector)num;
		colorSelectorItem2 = (ColorSelectorItem)(object)ex;
		color = colorSelector;
		goto IL_06fb;
		IL_04bb:
		bool flag13 = itemPicker == null;
		colorSelector = this;
		if (!flag13)
		{
			object obj35 = itemPicker + 24;
			obj35 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag14 = list == null;
			colorSelector = this;
			if (!flag14)
			{
				if (list._size == 0)
				{
					return;
				}
				object obj36 = (nint)0 + (nint)3744;
				num = (nint)obj36;
				object obj37 = list.get_Item(0);
				bool flag15 = itemPicker == null;
				colorSelector = this;
				if (!flag15)
				{
					object obj38 = (nint)0 + (nint)3888;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4CC615C");
					colorSelector = (ColorSelector)(object)OnItemSelected;
					num = (nint)obj36;
					object obj39 = list.get_Item(0);
					if (obj39 != null && OnItemSelected != null)
					{
						object obj40 = (nint)0 + (nint)1352;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @402EB30");
						return;
					}
				}
			}
		}
		goto IL_06d5;
		IL_06fb:
		colorSelectorItem2.Init((Color)color, manager);
		throw new NullReferenceException();
	}

	public void RefreshPalette(IReadOnlyList<Color> colors)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003f: Expected O, but got I4
		//IL_0dde: Expected O, but got I4
		//IL_0c8d: Expected O, but got I
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_0192: Expected I, but got O
		//IL_019b: Expected O, but got I4
		//IL_01a0: Expected I, but got O
		//IL_0104: Expected O, but got I4
		//IL_0109: Expected I, but got O
		//IL_0120: Expected O, but got I4
		//IL_0125: Expected I, but got O
		//IL_0d1b: Expected O, but got I
		//IL_0e1b: Expected O, but got I4
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02cc: Expected O, but got I
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_06e2: Expected O, but got I4
		//IL_06eb: Expected O, but got I4
		//IL_0e39: Expected O, but got I
		//IL_0e49: Expected O, but got I
		//IL_0e59: Expected O, but got I
		//IL_0e69: Expected O, but got I
		//IL_0e93: Expected O, but got I4
		//IL_0be2: Expected O, but got I
		//IL_0bea: Expected I, but got O
		//IL_0c0e: Expected O, but got I4
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_0368: Expected O, but got I
		//IL_0374: Expected O, but got I
		//IL_0395: Expected O, but got I4
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Expected O, but got Unknown
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0760: Expected O, but got Unknown
		//IL_0494: Expected O, but got I
		//IL_04a4: Expected O, but got I
		//IL_04b4: Expected O, but got I
		//IL_04e6: Expected O, but got I4
		//IL_077b: Expected O, but got I
		//IL_078c: Expected I, but got O
		//IL_0798: Expected O, but got I
		//IL_07a0: Expected I, but got O
		//IL_0524: Expected I, but got O
		//IL_07d0: Expected O, but got I4
		//IL_0ebb: Expected O, but got I4
		//IL_0596: Expected I, but got O
		//IL_07fe: Expected O, but got I4
		//IL_0850: Expected O, but got I
		//IL_05c9: Expected O, but got I4
		//IL_081d: Expected O, but got I
		//IL_0825: Expected I, but got O
		//IL_03c2: Expected O, but got I
		//IL_03d2: Expected O, but got I
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_040b: Expected O, but got Unknown
		//IL_091a: Expected I, but got O
		//IL_093f: Expected I, but got O
		//IL_08ab: Expected O, but got I4
		//IL_08b0: Expected I, but got O
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected O, but got Unknown
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected O, but got Unknown
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_0645: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected O, but got Unknown
		//IL_0682: Expected I, but got O
		//IL_0a7b: Expected O, but got I4
		//IL_096a: Expected O, but got I4
		//IL_08e3: Expected I, but got O
		//IL_06c0: Expected I, but got O
		//IL_0ab0: Expected O, but got I
		//IL_0993: Expected O, but got I
		//IL_099b: Expected I, but got O
		//IL_09c5: Expected O, but got I4
		//IL_09ed: Expected O, but got I4
		//IL_0b1c: Expected O, but got I4
		//IL_0b58: Expected I, but got O
		//IL_0a0b: Expected O, but got I
		//IL_0a1b: Expected O, but got I
		//IL_0a2b: Expected O, but got I
		//IL_0a3b: Expected O, but got I
		//IL_0a47: Expected O, but got I
		//IL_0a4f: Expected I, but got O
		//IL_0b9a: Expected O, but got I4
		//IL_0ac3: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1896;
		object obj2 = (nint)0 + (nint)2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		bool flag = ArraysExtensions.IsNullOrEmpty(colors);
		bool flag2 = !flag;
		object obj4 = !flag2;
		if (obj4 != null)
		{
			return;
		}
		ColorSelector colorSelector;
		object obj5;
		nint num = default(nint);
		Color color;
		nint num2;
		if (_initialized)
		{
			ItemPicker<ColorSelectorItem> itemPicker = this.itemPicker;
			bool flag3 = this.itemPicker == null;
			colorSelector = this;
			if (flag3)
			{
				goto IL_0c54;
			}
			obj5 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v16+E4]");
			if ((nint)0 != 0)
			{
				bool flag4 = itemPicker._selectedItem != null;
				bool flag5 = !flag4;
				object obj7 = !flag5;
				num = unchecked((nint)null);
				if (obj7 != null)
				{
					goto IL_01ae;
				}
				color = (Color)0;
				num2 = unchecked((nint)null);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = itemPicker._selectedItem != null;
				bool flag7 = !flag6;
				num = unchecked((nint)null);
				color = (Color)0;
				num2 = unchecked((nint)null);
				if (!flag7)
				{
					goto IL_01ae;
				}
			}
			goto IL_0d8d;
		}
		bool flag8 = ArraysExtensions.IsNullOrEmpty(colors);
		bool flag9 = !flag8;
		object obj8 = !flag9;
		if (obj8 == null)
		{
			Color[] array = Enumerable.ToArray(colors);
			object obj9 = this + 40;
			obj9 = array;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		return;
		IL_01ae:
		ItemPicker<ColorSelectorItem> itemPicker2 = this.itemPicker;
		bool flag10 = this.itemPicker == null;
		colorSelector = this;
		if (!flag10)
		{
			ColorSelectorItem selectedItem = itemPicker2._selectedItem;
			bool flag11 = (object)itemPicker2._selectedItem == null;
			colorSelector = this;
			if (!flag11)
			{
				color = selectedItem.<Color>k__BackingField;
				num2 = num;
				goto IL_0d8d;
			}
		}
		goto IL_0c54;
		IL_0ca2:
		ColorSelectorItem colorSelectorItem = default(ColorSelectorItem);
		ColorSelector colorSelector2;
		ColorSelector manager;
		colorSelectorItem.Init((Color)colorSelector2, manager);
		NullReferenceException ex = new NullReferenceException();
		bool flag12 = (nint)colorSelector2 != 1;
		Color color2 = (Color)colorSelector2;
		NullReferenceException ex2 = ex;
		List<object>.Enumerator enumerator = default(List<object>.Enumerator);
		if (!flag12)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj10 = (nint)0 + (nint)80;
			color2 = (Color)obj10;
			enumerator.Dispose();
			object obj11 = default(object);
			if (obj11 == null)
			{
				return;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			object obj12 = obj11;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223E400");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0c54:
		NullReferenceException ex4 = new NullReferenceException();
		object obj14 = default(object);
		object obj13 = obj14;
		Color color4 = default(Color);
		Color color3 = color4;
		Color color6 = default(Color);
		Color color5 = color6;
		Color color8 = default(Color);
		Color color7 = color8;
		Color color10 = default(Color);
		Color color9 = color10;
		manager = (ColorSelector)num;
		colorSelectorItem = (ColorSelectorItem)(object)ex4;
		colorSelector2 = colorSelector;
		goto IL_0ca2;
		IL_0a5e:
		ItemPicker<ColorSelectorItem> itemPicker3;
		bool flag13 = itemPicker3.<Items>k__BackingField == null;
		obj14 = 0;
		nint num3;
		num = num3;
		if (!flag13)
		{
			List<object>.Enumerator enumerator2 = ((List<object>)(object)itemPicker3.<Items>k__BackingField).GetEnumerator();
			object obj15 = (nint)0 + (nint)88;
			while (enumerator.MoveNext())
			{
				object obj16 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X0_v68+E4]");
				bool flag14 = (nint)0 == 0;
				object obj17 = !flag14;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag15 = (UnityEngine.Object)null != (UnityEngine.Object)null;
				bool flag16 = !flag15;
				num3 = unchecked((nint)null);
				if (!flag16)
				{
					GameObject obj18 = ((Component)null).gameObject;
					object obj19 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X0_v75+E4]");
					bool flag17 = (nint)0 == 0;
					object obj20 = !flag17;
					if (obj20 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(obj18);
					num3 = unchecked((nint)null);
				}
			}
			enumerator.Dispose();
			return;
		}
		goto IL_0c54;
		IL_06fe:
		bool flag18 = this.itemPicker == null;
		num = num2;
		colorSelector = this;
		List<object> list = default(List<object>);
		Color color12 = default(Color);
		Color color14 = default(Color);
		Color color16 = default(Color);
		if (!flag18)
		{
			object obj21 = this.itemPicker + 24;
			obj21 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj22 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj23 = (nint)0 + (nint)1192;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj3, (IntPtr)obj23);
			object obj24 = (nint)0 + (nint)728;
			num = (nint)obj24;
			object obj25 = Enumerable.FirstOrDefault(list, func);
			bool flag19 = obj25 == null;
			object obj26 = !flag19;
			object obj27 = obj25;
			if (obj26 == null)
			{
				bool flag20 = list == null;
				obj14 = 0;
				colorSelector = this;
				if (flag20)
				{
					goto IL_0c54;
				}
				object obj28 = (nint)0 + (nint)3744;
				num = (nint)obj28;
				object obj29 = list.get_Item(0);
				obj27 = obj29;
			}
			bool flag21 = this.itemPicker == null;
			obj14 = 0;
			colorSelector = this;
			if (!flag21)
			{
				object obj30 = (nint)0 + (nint)3888;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4CC615C");
				object obj31 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X0_v60+E4]");
				if ((nint)0 != 0)
				{
					bool flag22 = (UnityEngine.Object)obj25 == null;
					bool flag23 = !flag22;
					object obj32 = !flag23;
					num = unchecked((nint)null);
					if (obj32 != null)
					{
						goto IL_0952;
					}
					Color color11 = color12;
					Color color13 = color14;
					Color color15 = color16;
					Color color17 = color;
					num3 = unchecked((nint)null);
					colorSelector = this;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag24 = (UnityEngine.Object)obj25 == null;
					bool flag25 = !flag24;
					num = unchecked((nint)null);
					Color color11 = color12;
					Color color13 = color14;
					Color color15 = color16;
					Color color17 = color;
					num3 = unchecked((nint)null);
					colorSelector = this;
					if (!flag25)
					{
						goto IL_0952;
					}
				}
				goto IL_0a5e;
			}
		}
		goto IL_0c54;
		IL_0952:
		bool flag26 = list == null;
		obj14 = 0;
		colorSelector = this;
		if (!flag26)
		{
			colorSelector = (ColorSelector)(object)OnItemSelected;
			object obj33 = (nint)0 + (nint)3744;
			num = (nint)obj33;
			object obj34 = list.get_Item(0);
			bool flag27 = obj34 == null;
			obj14 = 0;
			if (!flag27)
			{
				bool flag28 = OnItemSelected == null;
				obj14 = 0;
				if (!flag28)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v82 (System.Object)+40]");
					Color color13 = (Color)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v82 (System.Object)+44]");
					Color color11 = (Color)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v82 (System.Object)+38]");
					Color color17 = (Color)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X0_v82 (System.Object)+3C]");
					Color color15 = (Color)0;
					object obj35 = (nint)0 + (nint)1352;
					num3 = (nint)obj35;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @402EB30");
					goto IL_0a5e;
				}
			}
		}
		goto IL_0c54;
		IL_0d8d:
		bool flag29 = obj3 == null;
		num = num2;
		colorSelector = this;
		if (!flag29)
		{
			itemPicker3 = this.itemPicker;
			bool flag30 = this.itemPicker == null;
			num = num2;
			colorSelector = this;
			if (!flag30)
			{
				Color[] array2 = (Color[])obj2;
				bool flag31 = ArraysExtensions.IsNullOrEmpty(colors);
				bool flag32 = !flag31;
				object obj36 = !flag32;
				if (obj36 == null)
				{
					Color[] array3 = Enumerable.ToArray(colors);
					object obj37 = this + 40;
					obj37 = array3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					array2 = array3;
				}
				object obj38 = typeof(List<AdaptivePerformanceScaler>) + 616;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj39 = (nint)0 + (nint)3712;
				list..ctor();
				Color[] array4 = availableColors;
				bool flag33 = availableColors == null;
				num = num2;
				colorSelector = this;
				if (!flag33)
				{
					if (list != null)
					{
						if (array4.Length < 1)
						{
							goto IL_06fe;
						}
						object obj40 = availableColors + 44;
						object obj41 = (nint)0 + (nint)512;
						object obj42 = (nint)0 + (nint)3720;
						Color color18 = color12;
						Color color19 = color14;
						Color color20 = color16;
						object obj43 = 0;
						Color color21 = color;
						nint num4 = num2;
						object obj44 = obj39;
						ColorSelectorItem colorSelectorItem2 = default(ColorSelectorItem);
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X28_v9-C]");
							color8 = (Color)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X28_v9-8]");
							color10 = (Color)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X28_v9-4]");
							color4 = (Color)0;
							color6 = (Color)obj40;
							object obj45 = obj5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X0_v92+E4]");
							bool flag34 = (nint)0 == 0;
							object obj46 = !flag34;
							if (obj46 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
							bool flag35 = (object)colorSelectorItem2 == null;
							num = (nint)obj41;
							colorSelector = this;
							if (flag35)
							{
								break;
							}
							colorSelectorItem2.Init((Color)this, (ColorSelector)obj41);
							object obj47 = obj42;
							int version = list._version + 1;
							list._version = version;
							object[] items = list._items;
							bool flag36 = list._items == null;
							num = (nint)obj41;
							colorSelector = this;
							if (flag36)
							{
								break;
							}
							bool flag37 = list._size < items.Length;
							object obj48 = !flag37;
							if (obj48 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v60+20]");
								object obj49 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X8_v63+C0]");
								object obj50 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v64+70]");
								num4 = 0;
								list.AddWithResize((object)colorSelectorItem2);
								obj40 += 16;
								obj43++;
								bool flag38 = (nint)obj43 >= array4.Length;
								color18 = color6;
								color19 = color4;
								color20 = color10;
								color21 = color8;
								obj44 = colorSelectorItem2;
								color12 = color6;
								color14 = color4;
								color16 = color10;
								color = color8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v64+70]");
								num2 = 0;
								if (!flag38)
								{
									continue;
								}
							}
							else
							{
								int size = list._size + 1;
								list._size = size;
								object obj51 = list._items + list._size;
								object obj52 = obj51 + 32;
								obj52 = colorSelectorItem2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								obj40 += 16;
								obj43++;
								bool flag39 = (nint)obj43 < array4.Length;
								color18 = color6;
								color19 = color4;
								color20 = color10;
								color21 = color8;
								num4 = (nint)obj41;
								obj44 = colorSelectorItem2;
								if (flag39)
								{
									continue;
								}
								color12 = color6;
								color14 = color4;
								color16 = color10;
								color = color8;
								num2 = (nint)obj41;
							}
							goto IL_06fe;
						}
					}
					else
					{
						bool flag40 = array4.Length >= 1;
						object obj12 = 0;
						obj13 = 0;
						colorSelector = null;
						if (!flag40)
						{
							goto IL_06fe;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X26_v6 (UnityEngine.Color[])+20]");
						color8 = (Color)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X26_v6 (UnityEngine.Color[])+24]");
						color10 = (Color)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X26_v6 (UnityEngine.Color[])+28]");
						color4 = (Color)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X26_v6 (UnityEngine.Color[])+2C]");
						color6 = (Color)0;
						object obj53 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v728 @ X0_v45+E4]");
						bool flag41 = (nint)0 == 0;
						object obj54 = !flag41;
						if (obj54 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj55 = (nint)0 + (nint)512;
						num = (nint)obj55;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
						bool flag42 = (object)colorSelectorItem == null;
						object obj56 = !flag42;
						obj14 = obj13;
						color3 = color4;
						color5 = color6;
						color7 = color8;
						color9 = color10;
						manager = (ColorSelector)obj55;
						colorSelector2 = colorSelector;
						if (obj56 != null)
						{
							goto IL_0ca2;
						}
					}
				}
			}
		}
		goto IL_0c54;
	}

	public void SetSelectedItem(ColorSelectorItem item, bool addUndo)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0114: Expected O, but got I4
		//IL_012e: Expected O, but got I
		//IL_01b4: Expected O, but got I
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_017b: Expected O, but got I
		//IL_018c: Expected I, but got O
		object obj = typeof(CardUtils.<>c) + 1904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ItemPicker<ColorSelectorItem> itemPicker = this.itemPicker;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj5 = obj2 + 24;
		obj5 = itemPicker._selectedItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			if ((UnityEngine.Object)obj5 == item)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = (UnityEngine.Object)obj5 == item;
			bool flag2 = !flag;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				return;
			}
		}
		object obj8 = (nint)0 + (nint)3888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4CC615C");
		if (addUndo)
		{
			object obj9 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)1200;
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj10);
			Action action2 = action;
		}
		else
		{
			Action action2 = null;
		}
		object obj11 = (nint)0 + (nint)1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @402EB30");
	}

	public void ResetToDefault()
	{
		//IL_007a: Expected O, but got I
		//IL_00c0: Expected O, but got I
		ItemPicker<ColorSelectorItem> itemPicker = this.itemPicker;
		List<object> <Items>k__BackingField = (List<object>)(object)itemPicker.<Items>k__BackingField;
		if (itemPicker.<Items>k__BackingField != null && <Items>k__BackingField._size != 0)
		{
			object obj = ((List<object>)(object)itemPicker.<Items>k__BackingField).get_Item(0);
			object obj2 = (nint)0 + (nint)3888;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4CC615C");
			ItemPicker<ColorSelectorItem> itemPicker2 = this.itemPicker;
			object obj3 = ((List<object>)(object)itemPicker2.<Items>k__BackingField).get_Item(0);
			object obj4 = (nint)0 + (nint)1352;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @402EB30");
		}
	}

	public void SetSelectedItemByColor(Color color)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_007e: Expected O, but got I
		//IL_008a: Expected O, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00b9: Expected I, but got O
		//IL_0172: Expected O, but got I4
		//IL_0134: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 1912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		ItemPicker<ColorSelectorItem> itemPicker = this.itemPicker;
		if (itemPicker.<Items>k__BackingField == null)
		{
			return;
		}
		object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 816;
		object obj4 = (nint)0 + (nint)1208;
		object obj5 = (nint)0 + (nint)728;
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj4);
		object obj7 = Enumerable.FirstOrDefault(itemPicker.<Items>k__BackingField, func);
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			if (!((UnityEngine.Object)obj7 != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = (UnityEngine.Object)obj7 != null;
			bool flag2 = !flag;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				return;
			}
		}
		object obj10 = (nint)0 + (nint)3888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4CC615C");
	}

	public ColorSelector()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2864;
		object obj2 = (nint)0 + (nint)3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4CC6128");
		object obj3 = this + 72;
		object obj4 = default(object);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
