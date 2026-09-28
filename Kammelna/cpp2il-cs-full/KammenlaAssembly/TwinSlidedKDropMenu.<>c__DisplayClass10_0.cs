using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class TwinSlidedKDropMenu : SlidedKDropMenu
{
	private sealed class <>c__DisplayClass10_0
	{
		public int index;

		public TwinSlidedKDropMenu <>4__this;

		internal void <SetupItems2>b__0()
		{
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_0041: Expected O, but got I
			TwinSlidedKDropMenu twinSlidedKDropMenu = <>4__this;
			int num = index;
			nint num2 = (nint)twinSlidedKDropMenu;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v2 (Il2CppClass<TwinSlidedKDropMenu>)+218]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v2 (Il2CppClass<TwinSlidedKDropMenu>)+220]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v6 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass30_0
	{
		public TwinSlidedKDropMenu <>4__this;

		public Action moveBlocker;

		internal void <OnHideMenu>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0096: Expected O, but got I
			//IL_00b9: Expected O, but got I4
			//IL_0058: Expected O, but got I
			//IL_00e7: Expected O, but got I
			//IL_011e: Expected O, but got I
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected O, but got Unknown
			//IL_0153: Expected O, but got I
			//IL_0163: Expected O, but got I
			//IL_0173: Expected O, but got I
			//IL_0183: Expected O, but got I
			//IL_0191: Expected O, but got I4
			while (true)
			{
				TwinSlidedKDropMenu twinSlidedKDropMenu = <>4__this;
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v4+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v3 (TwinSlidedKDropMenu)+48]");
					if ((UnityEngine.Object)0 == null)
					{
						break;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v3 (TwinSlidedKDropMenu)+48]");
					bool flag = (UnityEngine.Object)0 == null;
					bool flag2 = !flag;
					object obj3 = !flag2;
					if (obj3 != null)
					{
						break;
					}
				}
				TwinSlidedKDropMenu twinSlidedKDropMenu2 = <>4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6 (TwinSlidedKDropMenu)+48]");
				GameObject gameObject = ((Component)0).gameObject;
				gameObject.SetActive(value: false);
				TwinSlidedKDropMenu twinSlidedKDropMenu3 = <>4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v7 (TwinSlidedKDropMenu)+48]");
				Transform transform = ((Component)0).transform;
				object obj4 = typeof(UsageHint) + 816;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v12+B8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v13+10]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v13+14]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v13+C]");
				object obj9 = 0;
				transform.localScale = (Vector3)0;
				Action action = moveBlocker;
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v116 @ X2_v4 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}

		internal void <OnHideMenu>b__1()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00b3: Expected O, but got I4
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Expected O, but got Unknown
			//IL_0147: Expected O, but got I
			//IL_0155: Expected O, but got I4
			//IL_018e: Expected O, but got I
			TwinSlidedKDropMenu twinSlidedKDropMenu = <>4__this;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				if (twinSlidedKDropMenu._layoutGroup2 == null)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = twinSlidedKDropMenu._layoutGroup2 == null;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					return;
				}
			}
			TwinSlidedKDropMenu twinSlidedKDropMenu2 = <>4__this;
			GameObject gameObject = twinSlidedKDropMenu2._itemParent2.gameObject;
			gameObject.SetActive(value: false);
			TwinSlidedKDropMenu twinSlidedKDropMenu3 = <>4__this;
			Transform transform = twinSlidedKDropMenu3._layoutGroup2.transform;
			object obj4 = typeof(UsageHint) + 816;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v12+B8]");
			object obj6 = 0;
			transform.localScale = (Vector3)0;
			Action action = moveBlocker;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v95.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			TwinSlidedKDropMenu twinSlidedKDropMenu4 = <>4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v15 (TwinSlidedKDropMenu)+40]");
			GameObject gameObject2 = ((Component)0).gameObject;
			gameObject2.SetActive(value: false);
		}

		internal void <OnHideMenu>b__2()
		{
			//IL_0020: Expected O, but got I
			TwinSlidedKDropMenu twinSlidedKDropMenu = <>4__this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1 (TwinSlidedKDropMenu)+40]");
			GameObject gameObject = ((Component)0).gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private LayoutElement _layoutElement2;

	private LayoutGroup _layoutGroup2;

	private LayoutGroup _itemParent2;

	private GameObject _listItemPrefab2;

	private GameObject _selectedListItemPrefab2;

	private GameObject _selectedListItem2;

	private TextMeshProUGUI _selectedText2;

	private string _placeholder2;

	private readonly List<GameObject> _itemsGameObjects2;

	private List<string> _items2;

	private int <SelectedIndex2>k__BackingField;

	private readonly Vector3 _zeroYVector;

	private bool _item1Clicked;

	private bool _item2Clicked;

	public int SelectedIndex2
	{
		get
		{
			return <SelectedIndex2>k__BackingField;
		}
		set
		{
			<SelectedIndex2>k__BackingField = value;
		}
	}

	private bool AreItemsClicked
	{
		get
		{
			if (_item1Clicked)
			{
				return _item2Clicked;
			}
			return false;
		}
	}

	public string SelectedItem2
	{
		get
		{
			//IL_0063: Expected I4, but got I8
			//IL_007d: Expected O, but got I4
			int num = (int)(<SelectedIndex2>k__BackingField & 0x80000000L);
			bool flag = num == 0;
			object obj = !flag;
			if (obj == null)
			{
				if (_items2 != null)
				{
					return (string)((List<object>)(object)_items2).get_Item(<SelectedIndex2>k__BackingField);
				}
				return (string)(object)new NullReferenceException();
			}
			return null;
		}
	}

	public void SetupItems2(List<string> newItems1, List<string> newItems2, Action onShow = null, Action onHide = null)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002c: Expected O, but got I
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected O, but got Unknown
		//IL_003f: Expected I, but got O
		//IL_00ae: Expected O, but got I4
		//IL_00b6: Expected I4, but got O
		//IL_0112: Expected O, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_012d: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_0146: Expected O, but got I4
		//IL_00e9: Expected O, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_027b: Expected O, but got I4
		//IL_02a4: Expected O, but got I
		//IL_02d2: Expected O, but got I
		//IL_0504: Expected O, but got I
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_0310: Expected I, but got O
		//IL_052a: Expected I4, but got I8
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_032a: Expected O, but got I
		//IL_05e8: Expected O, but got I
		//IL_060b: Expected O, but got I4
		//IL_057c: Expected O, but got I
		//IL_0629: Expected O, but got I
		//IL_038f: Expected O, but got I
		//IL_0a67: Expected O, but got I
		//IL_0ab1: Expected O, but got I4
		//IL_0acb: Expected O, but got I
		//IL_0ae4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae9: Expected O, but got Unknown
		//IL_06a6: Expected O, but got I
		//IL_0413: Expected O, but got I4
		//IL_06c3: Expected O, but got I4
		//IL_0654: Expected O, but got I
		//IL_066e: Expected O, but got I4
		//IL_0164: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_0184: Expected O, but got I
		//IL_01c5: Expected O, but got I4
		//IL_01cd: Expected I4, but got O
		//IL_06e7: Expected O, but got I
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_049b: Expected I4, but got O
		//IL_0685: Expected O, but got I4
		//IL_098c: Expected O, but got I
		//IL_08d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected O, but got Unknown
		//IL_0904: Expected O, but got I4
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_073a: Expected O, but got Unknown
		//IL_0750: Expected O, but got I
		//IL_075e: Expected I, but got O
		//IL_092d: Expected O, but got I
		//IL_0947: Unknown result type (might be due to invalid IL or missing references)
		//IL_094c: Expected O, but got Unknown
		//IL_076f: Expected O, but got I
		//IL_079a: Expected O, but got I
		//IL_07c7: Expected O, but got I
		//IL_0821: Expected O, but got I4
		//IL_09b4: Expected O, but got I
		//IL_09c4: Expected O, but got I
		//IL_09d4: Expected O, but got I
		//IL_0a01: Expected O, but got I4
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected O, but got Unknown
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected O, but got Unknown
		//IL_088a: Expected O, but got I4
		object obj = (nint)0 + (nint)2528;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj3 = (nint)0 + (nint)1120;
		((BaseDropMenu<object>)(object)this).SetupItems((List<object>)(object)newItems1, onShow, onHide);
		_items2 = newItems2;
		object obj4 = this + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj3);
		((List<object>)(object)_itemsGameObjects2).ForEach(action);
		List<GameObject> itemsGameObjects = _itemsGameObjects2;
		int version = itemsGameObjects._version + 1;
		itemsGameObjects._size = 0;
		itemsGameObjects._version = version;
		bool flag = itemsGameObjects._size < 1;
		object obj5 = 0;
		int num = (int)action;
		if (!flag)
		{
			Array.Clear(itemsGameObjects._items, 0, itemsGameObjects._size);
			obj5 = 0;
			num = 0;
		}
		List<string> items = _items2;
		object obj6 = (nint)0 + (nint)976;
		object n = "SubscribeGroup request Error" + 3464;
		object obj7 = (nint)0 + (nint)152;
		object obj8 = (nint)0 + (nint)2544;
		string text = (string)itemsGameObjects._size;
		int num2 = 0;
		object obj10 = default(object);
		GameObject gameObject = default(GameObject);
		UnityAction unityAction = default(UnityAction);
		TextMeshProUGUI label = default(TextMeshProUGUI);
		string text3;
		while (true)
		{
			if (num2 < items._size)
			{
				object obj9 = typeof(TrackedDeviceRaycaster.<>c) + 336;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj10..ctor();
				object obj11 = obj10 + 24;
				obj11 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Transform transform = _itemParent2.transform;
				object obj12 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v72+E4]");
				bool flag2 = (nint)0 == 0;
				object obj14 = !flag2;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj15 = (nint)0 + (nint)920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
				gameObject.SetActive(value: true);
				object obj16 = (nint)0 + (nint)1128;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				object obj17 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				unityAction..ctor(obj10, (IntPtr)obj6);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v77+100]");
				((UnityEvent)0).AddListener(unityAction);
				Transform transform2 = gameObject.transform;
				Transform transform3 = transform2.Find((string)n);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				object item = ((List<object>)(object)_items2).get_Item(num2);
				string text2 = base.ItemName((string)item);
				object obj18 = (nint)0 + (nint)2520;
				obj5 = obj18;
				SetText(label, text2);
				List<object> itemsGameObjects2 = (List<object>)(object)_itemsGameObjects2;
				object obj19 = obj8;
				int version2 = itemsGameObjects2._version + 1;
				itemsGameObjects2._version = version2;
				object[] array = itemsGameObjects2._items;
				bool flag3 = itemsGameObjects2._size < array.Length;
				object obj20 = !flag3;
				if (obj20 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v69+20]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X8_v72+C0]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v73+70]");
					text = (string)0;
					itemsGameObjects2.AddWithResize((object)gameObject);
					num2++;
					items = _items2;
					bool flag4 = _items2 == null;
					object obj23 = !flag4;
					num = (int)gameObject;
					if (obj23 == null)
					{
						throw new NullReferenceException();
					}
				}
				else
				{
					int size = itemsGameObjects2._size + 1;
					itemsGameObjects2._size = size;
					object obj24 = array + itemsGameObjects2._size;
					object obj25 = obj24 + 32;
					obj25 = gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num2++;
					items = _items2;
					text = text2;
					num = (int)gameObject;
				}
				continue;
			}
			_ = 0;
			GameObject gameObject2 = _itemParent2.gameObject;
			gameObject2.SetActive(value: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+40]");
			GameObject gameObject3 = ((Component)0).gameObject;
			gameObject3.SetActive(value: false);
			<SelectedIndex2>k__BackingField = -1;
			object obj26 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj27 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v16+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+90]");
				if (StringsExtensions.IsNullOrEmpty((string)0))
				{
					goto IL_059d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+90]");
				bool flag5 = StringsExtensions.IsNullOrEmpty((string)0);
				bool flag6 = !flag5;
				object obj28 = !flag6;
				if (obj28 != null)
				{
					goto IL_059d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+90]");
			text3 = (string)0;
			break;
			IL_059d:
			object item2 = ((List<object>)(object)_items2).get_Item(0);
			string text4 = base.ItemName((string)item2);
			text3 = text4;
			break;
		}
		object obj29 = (nint)0 + (nint)2520;
		object obj30 = obj29;
		SetText(_selectedText2, text3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+A8]");
		int startIndex = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+A8]");
		bool flag7 = (nint)0 == 0;
		object obj31 = !flag7;
		if (obj31 == null)
		{
			_ = 2147483647;
			startIndex = 2147483647;
		}
		object obj32 = (nint)0 + (nint)2504;
		((BaseDropMenu<object>)(object)this).DisableItems(startIndex);
		object obj33 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X0_v20+E4]");
		object obj36;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+80]");
			bool flag8 = (UnityEngine.Object)0 != null;
			bool flag9 = !flag8;
			object obj35 = !flag9;
			if (obj35 != null)
			{
				goto IL_06d1;
			}
			obj36 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+80]");
			bool flag10 = (UnityEngine.Object)0 != null;
			bool flag11 = !flag10;
			obj36 = 0;
			if (!flag11)
			{
				goto IL_06d1;
			}
		}
		goto IL_088f;
		IL_0970:
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+40]");
		GameObject gameObject4 = ((Component)0).gameObject;
		gameObject4.SetActive(value: false);
		return;
		IL_088f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+60]");
		if ((nint)0 == 1)
		{
			goto IL_08b7;
		}
		goto IL_0970;
		IL_06d1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+80]");
		((GameObject)0).SetActive(value: false);
		object obj37 = typeof(DebugUI.BitField) + 1760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventTrigger.Entry entry = default(EventTrigger.Entry);
		entry..ctor();
		entry.eventID = EventTriggerType.PointerDown;
		object obj38 = typeof(TypeConverter<ushort, char>) + 352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj39 = (nint)0 + (nint)3392;
		UnityAction<object> unityAction2 = default(UnityAction<object>);
		unityAction2..ctor((object)this, (IntPtr)obj39);
		object obj40 = (nint)0 + (nint)808;
		obj36 = obj40;
		((UnityEvent<object>)(object)entry.callback).AddListener(unityAction2);
		object obj41 = (nint)0 + (nint)1264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		EventTrigger eventTrigger = default(EventTrigger);
		List<EventTrigger.Entry> triggers = eventTrigger.triggers;
		object obj42 = (nint)0 + (nint)2152;
		object obj43 = obj42;
		int version3 = triggers._version + 1;
		triggers._version = version3;
		EventTrigger.Entry[] array2 = triggers._items;
		bool flag12 = triggers._size < array2.Length;
		object obj44 = !flag12;
		if (obj44 == null)
		{
			int size2 = triggers._size + 1;
			triggers._size = size2;
			object obj45 = array2 + triggers._size;
			object obj46 = obj45 + 32;
			obj46 = entry;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj30 = 0;
			goto IL_088f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v45+20]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v707 @ X8_v46+C0]");
		object obj48 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v47+70]");
		obj36 = 0;
		((List<object>)(object)triggers).AddWithResize((object)entry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+60]");
		bool flag13 = (nint)0 == 1;
		obj30 = 0;
		if (flag13)
		{
			goto IL_08b7;
		}
		goto IL_0970;
		IL_08b7:
		Transform transform4 = _itemParent2.transform;
		object obj49 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj50 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X0_v27+E4]");
		bool flag14 = (nint)0 == 0;
		object obj51 = !flag14;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj52 = (nint)0 + (nint)920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		GameObject selectedListItem = default(GameObject);
		_selectedListItem2 = selectedListItem;
		object obj53 = this + 288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_selectedListItem2.SetActive(value: false);
		goto IL_0970;
	}

	public override void OnShowMenu()
	{
		//IL_0016: Expected O, but got I
		//IL_0043: Expected O, but got I
		//IL_005a: Expected O, but got I4
		//IL_006b: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_00ed: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_0152: Expected O, but got I4
		//IL_0195: Expected I, but got O
		//IL_01a5: Expected O, but got I
		//IL_01b5: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+40]");
		GameObject gameObject = ((Component)0).gameObject;
		gameObject.SetActive(value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+40]");
		Transform transform = ((Component)0).transform;
		transform.localScale = (Vector3)0;
		object obj = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+40]");
		Transform target = ((Component)0).transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScaleY(target, 1f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+48]");
		Transform transform2 = ((Component)0).transform;
		transform2.localScale = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+48]");
		Transform target2 = ((Component)0).transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScaleY(target2, 1f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Transform transform3 = _layoutGroup2.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+154]");
		object obj2 = 0;
		transform3.localScale = (Vector3)0;
		Transform target3 = _layoutGroup2.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScaleY(target3, 1f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10 (Il2CppClass<TwinSlidedKDropMenu>)+1B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10 (Il2CppClass<TwinSlidedKDropMenu>)+1C0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v107 @ X2_v6 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected override void ShowSelected()
	{
		//IL_0015: Expected O, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_00b4: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		//IL_0068: Expected O, but got I
		//IL_00ff: Expected O, but got I
		//IL_0138: Expected O, but got I
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0153: Expected O, but got I
		//IL_0160: Expected O, but got I
		//IL_0180: Expected I4, but got O
		//IL_028a: Expected O, but got I4
		//IL_02b5: Expected I4, but got O
		//IL_0665: Expected O, but got I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I
		//IL_023e: Expected O, but got I4
		//IL_0383: Expected O, but got I
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected I4, but got Unknown
		//IL_0415: Expected O, but got I4
		//IL_07ff: Expected I4, but got O
		//IL_043c: Expected O, but got I
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected O, but got Unknown
		//IL_07b0: Expected O, but got I4
		//IL_053b: Expected I4, but got O
		//IL_053b: Expected O, but got I
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Expected I4, but got Unknown
		//IL_0947: Expected O, but got I4
		//IL_057a: Expected O, but got I
		//IL_059c: Expected O, but got I4
		//IL_0a5b: Expected I4, but got O
		//IL_0ab0: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+60]");
		if ((nint)0 != 1)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+68]");
		UnityEngine.Object obj = (UnityEngine.Object)0;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3+E4]");
		UnityEngine.Object obj4;
		string text;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+68]");
			bool flag = (UnityEngine.Object)0 == null;
			bool flag2 = !flag;
			text = null;
			obj4 = null;
			if (!flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+68]");
			bool flag3 = (UnityEngine.Object)0 == null;
			bool flag4 = !flag3;
			object obj5 = !flag4;
			text = null;
			obj4 = null;
			if (obj5 != null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+A0]");
		List<object> list = (List<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+A0]");
		bool flag5 = (nint)0 == 0;
		TextMeshProUGUI textMeshProUGUI = (TextMeshProUGUI)obj4;
		if (!flag5)
		{
			object obj6 = (nint)0 + (nint)2592;
			object obj7 = "SubscribeGroup request Error" + 3464;
			object obj8 = (nint)0 + (nint)152;
			object obj9 = (nint)0 + (nint)2520;
			object obj11 = default(object);
			object obj10 = obj11;
			TextMeshProUGUI textMeshProUGUI3 = default(TextMeshProUGUI);
			TextMeshProUGUI textMeshProUGUI2 = textMeshProUGUI3;
			string text2 = text;
			bool flag6 = (byte)(int)obj4 != 0;
			UnityEngine.Object obj12 = null;
			TextMeshProUGUI textMeshProUGUI4 = default(TextMeshProUGUI);
			bool flag17;
			TextMeshProUGUI textMeshProUGUI6 = default(TextMeshProUGUI);
			do
			{
				bool flag7 = (nint)obj12 >= list._size;
				obj11 = obj10;
				textMeshProUGUI3 = textMeshProUGUI2;
				text = text2;
				textMeshProUGUI = (TextMeshProUGUI)flag6;
				obj = obj12;
				if (!flag7)
				{
					text = (string)obj6;
					object obj13 = list.get_Item((int)obj12);
					UnityEngine.Object obj14 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+34]");
					GameObject gameObject;
					if ((object)obj14 != null)
					{
						bool flag8 = obj13 == null;
						gameObject = (GameObject)obj13;
						obj11 = obj10;
						textMeshProUGUI3 = textMeshProUGUI2;
						textMeshProUGUI = (TextMeshProUGUI)obj12;
						obj = obj12;
						if (flag8)
						{
							break;
						}
					}
					else
					{
						bool flag9 = obj13 == null;
						obj11 = obj10;
						textMeshProUGUI3 = textMeshProUGUI2;
						textMeshProUGUI = (TextMeshProUGUI)obj12;
						obj = obj12;
						if (flag9)
						{
							break;
						}
						((GameObject)obj13).SetActive(value: false);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+70]");
						bool flag10 = (nint)0 == 0;
						obj11 = obj10;
						textMeshProUGUI3 = textMeshProUGUI2;
						text = null;
						textMeshProUGUI = null;
						obj = obj12;
						if (flag10)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+70]");
						Transform transform = ((GameObject)0).transform;
						bool flag11 = (object)transform == null;
						obj11 = obj10;
						textMeshProUGUI3 = textMeshProUGUI2;
						text = null;
						textMeshProUGUI = null;
						obj = obj12;
						if (flag11)
						{
							break;
						}
						int num = obj12 + 2;
						transform.SetSiblingIndex(num);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+70]");
						bool flag12 = (nint)0 == 0;
						obj11 = obj10;
						textMeshProUGUI3 = textMeshProUGUI2;
						text = null;
						textMeshProUGUI = (TextMeshProUGUI)num;
						obj = obj12;
						if (flag12)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+70]");
						Transform transform2 = ((GameObject)0).transform;
						bool flag13 = (object)transform2 == null;
						obj11 = obj10;
						textMeshProUGUI3 = textMeshProUGUI2;
						text = null;
						textMeshProUGUI = null;
						obj = obj12;
						if (flag13)
						{
							break;
						}
						Transform transform3 = transform2.Find((string)obj7);
						bool flag14 = (object)transform3 == null;
						obj11 = obj10;
						textMeshProUGUI3 = textMeshProUGUI2;
						text = null;
						textMeshProUGUI = (TextMeshProUGUI)obj7;
						obj = obj12;
						if (flag14)
						{
							break;
						}
						textMeshProUGUI = (TextMeshProUGUI)obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+98]");
						bool flag15 = (nint)0 == 0;
						obj11 = obj10;
						textMeshProUGUI3 = textMeshProUGUI4;
						text = null;
						obj = obj12;
						if (flag15)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+98]");
						object item = ((List<object>)0).get_Item((int)obj12);
						string text3 = base.ItemName((string)item);
						obj10 = obj9;
						SetText(textMeshProUGUI4, text3);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+70]");
						gameObject = (GameObject)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+70]");
						bool flag16 = (nint)0 == 0;
						object obj15 = !flag16;
						textMeshProUGUI2 = textMeshProUGUI4;
						obj11 = obj9;
						textMeshProUGUI3 = textMeshProUGUI4;
						text = text3;
						textMeshProUGUI = textMeshProUGUI4;
						obj = obj12;
						if (obj15 == null)
						{
							break;
						}
					}
					gameObject.SetActive(value: true);
					obj12 = (UnityEngine.Object)(obj12 + 1);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+A0]");
					list = (List<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+A0]");
					flag17 = (nint)0 == 0;
					text2 = null;
					flag6 = true;
					obj11 = obj10;
					textMeshProUGUI3 = textMeshProUGUI2;
					text = null;
					textMeshProUGUI = (TextMeshProUGUI)1;
					obj = obj12;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+60]");
				if ((nint)0 != 1)
				{
					return;
				}
				object obj16 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v8+E4]");
				if ((nint)0 != 0)
				{
					bool flag18 = _selectedListItemPrefab2 == null;
					bool flag19 = !flag18;
					object obj17 = !flag19;
					if (obj17 != null)
					{
						return;
					}
					text = null;
					textMeshProUGUI = null;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag20 = _selectedListItemPrefab2 == null;
					bool flag21 = !flag20;
					text = null;
					textMeshProUGUI = null;
					obj = _selectedListItemPrefab2;
					if (!flag21)
					{
						return;
					}
				}
				List<object> itemsGameObjects = (List<object>)(object)_itemsGameObjects2;
				if (_itemsGameObjects2 == null)
				{
					break;
				}
				object obj18 = obj11;
				TextMeshProUGUI textMeshProUGUI5 = textMeshProUGUI3;
				UnityEngine.Object obj19 = null;
				bool flag31;
				do
				{
					if ((nint)obj19 >= itemsGameObjects._size)
					{
						return;
					}
					text = (string)obj6;
					object obj20 = itemsGameObjects.get_Item((int)obj19);
					GameObject gameObject2;
					if ((nint)obj19 != <SelectedIndex2>k__BackingField)
					{
						bool flag22 = obj20 == null;
						obj11 = obj18;
						textMeshProUGUI3 = textMeshProUGUI5;
						textMeshProUGUI = (TextMeshProUGUI)obj19;
						obj = obj19;
						gameObject2 = (GameObject)obj20;
						if (flag22)
						{
							break;
						}
					}
					else
					{
						bool flag23 = obj20 == null;
						obj11 = obj18;
						textMeshProUGUI3 = textMeshProUGUI5;
						textMeshProUGUI = (TextMeshProUGUI)obj19;
						obj = obj19;
						if (flag23)
						{
							break;
						}
						((GameObject)obj20).SetActive(value: false);
						bool flag24 = (object)_selectedListItem2 == null;
						obj11 = obj18;
						textMeshProUGUI3 = textMeshProUGUI5;
						text = null;
						textMeshProUGUI = null;
						obj = obj19;
						if (flag24)
						{
							break;
						}
						Transform transform4 = _selectedListItem2.transform;
						bool flag25 = (object)transform4 == null;
						obj11 = obj18;
						textMeshProUGUI3 = textMeshProUGUI5;
						text = null;
						textMeshProUGUI = null;
						obj = obj19;
						if (flag25)
						{
							break;
						}
						int num2 = obj19 + 2;
						transform4.SetSiblingIndex(num2);
						bool flag26 = (object)_selectedListItem2 == null;
						obj11 = obj18;
						textMeshProUGUI3 = textMeshProUGUI5;
						text = null;
						textMeshProUGUI = (TextMeshProUGUI)num2;
						obj = obj19;
						if (flag26)
						{
							break;
						}
						Transform transform5 = _selectedListItem2.transform;
						bool flag27 = (object)transform5 == null;
						obj11 = obj18;
						textMeshProUGUI3 = textMeshProUGUI5;
						text = null;
						textMeshProUGUI = null;
						obj = obj19;
						if (flag27)
						{
							break;
						}
						Transform transform6 = transform5.Find((string)obj7);
						bool flag28 = (object)transform6 == null;
						obj11 = obj18;
						textMeshProUGUI3 = textMeshProUGUI5;
						text = null;
						textMeshProUGUI = (TextMeshProUGUI)obj7;
						obj = obj19;
						if (flag28)
						{
							break;
						}
						textMeshProUGUI = (TextMeshProUGUI)obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
						bool flag29 = _items2 == null;
						obj11 = obj18;
						textMeshProUGUI3 = textMeshProUGUI6;
						text = null;
						obj = obj19;
						if (flag29)
						{
							break;
						}
						object item2 = ((List<object>)(object)_items2).get_Item((int)obj19);
						string text4 = base.ItemName((string)item2);
						obj18 = obj9;
						SetText(textMeshProUGUI6, text4);
						gameObject2 = _selectedListItem2;
						bool flag30 = (object)_selectedListItem2 == null;
						object obj21 = !flag30;
						textMeshProUGUI5 = textMeshProUGUI6;
						if (obj21 == null)
						{
							obj11 = obj9;
							textMeshProUGUI3 = textMeshProUGUI6;
							text = text4;
							textMeshProUGUI = textMeshProUGUI6;
							obj = obj19;
							break;
						}
					}
					gameObject2.SetActive(value: true);
					obj = (UnityEngine.Object)(obj19 + 1);
					itemsGameObjects = (List<object>)(object)_itemsGameObjects2;
					flag31 = _itemsGameObjects2 == null;
					obj11 = obj18;
					textMeshProUGUI3 = textMeshProUGUI5;
					text = null;
					textMeshProUGUI = (TextMeshProUGUI)1;
					obj19 = obj;
				}
				while (!flag31);
				break;
			}
			while (!flag17);
		}
		throw new NullReferenceException();
	}

	public void ResetClicks()
	{
		_item1Clicked = false;
	}

	protected override void ItemClicked(int index)
	{
		//IL_006a: Expected O, but got I
		//IL_007f: Expected I, but got O
		//IL_008f: Expected O, but got I
		//IL_009f: Expected O, but got I
		SetSelectedIndex(index);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+30]");
			if ((nint)0 != 1 || (_item1Clicked && _item2Clicked))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+30]");
				object obj = (nint)0 ^ (nint)1;
				UpdateUI();
			}
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v6 (Il2CppClass<TwinSlidedKDropMenu>)+1B8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v6 (Il2CppClass<TwinSlidedKDropMenu>)+1C0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v103 @ X2_v2 (should have been resolved before IL gen)");
		}
	}

	public override void SetSelectedIndex(int index)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0136: Expected O, but got I
		//IL_0150: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_0104: Expected O, but got I
		//IL_017e: Expected O, but got I
		//IL_01a0: Expected O, but got I4
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7646]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			_item1Clicked = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7628]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			bool flag2 = true;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			_item1Clicked = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7628]");
			object obj4 = (nint)0 & (nint)1;
			bool flag3 = obj4 == null;
			object obj5 = !flag3;
			bool flag2 = true;
			if (obj5 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+28]");
		UnityEvent<int> unityEvent = (UnityEvent<int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+28]");
		bool flag4 = (nint)0 == 0;
		object obj6 = !flag4;
		if (obj6 != null)
		{
			goto IL_00c1;
		}
		goto IL_00d6;
		IL_00d6:
		object item = ((BaseDropMenu<object>)(object)this).SelectedItem;
		string text = base.ItemName((string)item);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+58]");
		SetText((TextMeshProUGUI)0, text);
		return;
		IL_00c1:
		unityEvent.Invoke(index);
		goto IL_00d6;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+28]");
		unityEvent = (UnityEvent<int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+28]");
		if ((nint)0 != 0)
		{
			goto IL_00c1;
		}
		goto IL_00d6;
	}

	protected virtual void ItemClicked2(int index)
	{
		//IL_006a: Expected O, but got I
		//IL_007f: Expected I, but got O
		//IL_008f: Expected O, but got I
		//IL_009f: Expected O, but got I
		SetSelectedIndex2(index);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+30]");
			if ((nint)0 != 1 || (_item1Clicked && _item2Clicked))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+30]");
				object obj = (nint)0 ^ (nint)1;
				UpdateUI();
			}
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v5 (Il2CppClass<TwinSlidedKDropMenu>)+1B8]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v5 (Il2CppClass<TwinSlidedKDropMenu>)+1C0]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v101 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	public void SetSelectedIndex2(int index)
	{
		//IL_0016: Expected O, but got I
		//IL_0125: Expected O, but got I
		//IL_013f: Expected O, but got I4
		//IL_0094: Expected O, but got I
		//IL_005e: Expected O, but got I
		//IL_016b: Expected O, but got I
		//IL_018d: Expected O, but got I4
		//IL_01be: Expected I4, but got I8
		//IL_01d8: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7648]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			<SelectedIndex2>k__BackingField = index;
			_item2Clicked = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7628]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			bool flag2 = true;
			if (!flag)
			{
				goto IL_0084;
			}
		}
		else
		{
			_ = 1;
			<SelectedIndex2>k__BackingField = index;
			_item2Clicked = true;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7628]");
			object obj3 = (nint)0 & (nint)1;
			bool flag3 = obj3 == null;
			object obj4 = !flag3;
			bool flag2 = true;
			if (obj4 != null)
			{
				goto IL_0084;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+28]");
		UnityEvent<int> unityEvent = (UnityEvent<int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+28]");
		bool flag4 = (nint)0 == 0;
		object obj5 = !flag4;
		if (obj5 != null)
		{
			goto IL_00b9;
		}
		goto IL_01aa;
		IL_01aa:
		int num = (int)(<SelectedIndex2>k__BackingField & 0x80000000L);
		bool flag5 = num == 0;
		object obj6 = !flag5;
		object item;
		if (obj6 == null)
		{
			object obj7 = ((List<object>)(object)_items2).get_Item(<SelectedIndex2>k__BackingField);
			item = obj7;
		}
		else
		{
			item = null;
		}
		string text = base.ItemName((string)item);
		SetText(_selectedText2, text);
		return;
		IL_00b9:
		unityEvent.Invoke(index);
		goto IL_01aa;
		IL_0084:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+28]");
		unityEvent = (UnityEvent<int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+28]");
		if ((nint)0 != 0)
		{
			goto IL_00b9;
		}
		goto IL_01aa;
	}

	private void ToggleWithCheck()
	{
		//IL_006c: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+30]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+158]");
			if ((nint)0 != 1)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+159]");
			if ((nint)0 != 1)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+30]");
		object obj = (nint)0 ^ (nint)1;
		UpdateUI();
	}

	public override void OnHideMenu(Action moveBlocker)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_00a4: Expected O, but got I4
		//IL_00db: Expected O, but got I
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I
		//IL_0107: Expected O, but got I
		//IL_0118: Expected O, but got I
		//IL_0162: Expected I, but got O
		//IL_017d: Expected O, but got I
		//IL_01d2: Expected I, but got O
		//IL_01ed: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0248: Expected I, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = moveBlocker;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_item1Clicked = false;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		object obj8 = (nint)0 + (nint)2904;
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj10 = (nint)0 + (nint)984;
		object obj11 = (nint)0 + (nint)2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+48]");
		Transform target = ((Component)0).transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScaleY(target, 0f, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj10);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		object obj12 = (nint)0 + (nint)992;
		Transform target2 = _layoutGroup2.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScaleY(target2, 0f, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(obj2, (IntPtr)obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		object obj13 = (nint)0 + (nint)1000;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TwinSlidedKDropMenu)+40]");
		Transform target3 = ((Component)0).transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScaleY(target3, 0f, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback3 = default(TweenCallback);
		tweenCallback3..ctor(obj2, (IntPtr)obj13);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		Tween t = default(Tween);
		Sequence sequence = TweenSettingsExtensions.Insert(s, 0f, t);
		Tween t2 = default(Tween);
		Sequence sequence2 = TweenSettingsExtensions.Insert(s, 0f, t2);
		Tween t3 = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Insert(s, 0f, t3);
	}

	protected override void SlideListPanel(float height, float duration = 0.5f, Ease ease = Ease.Linear, TweenCallback onComplete = null)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_0039: Expected I, but got O
		//IL_0070: Expected O, but got I4
		//IL_00af: Expected O, but got I4
		//IL_00f6: Expected O, but got I4
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		LayoutElement layoutElement = parentLayoutElement;
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = (nint)0 + (nint)2872;
		object obj3 = (nint)0 + (nint)2408;
		nint num = (nint)layoutElement;
		float preferredWidth = layoutElement.preferredWidth;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOPreferredSize(parentLayoutElement, (Vector2)0, height);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t = default(Tween);
		Sequence sequence = TweenSettingsExtensions.Insert(s, 0f, t);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOPreferredSize(_layoutElement2, (Vector2)0, height);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t2 = default(Tween);
		Sequence sequence2 = TweenSettingsExtensions.Insert(s, 0f, t2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		object obj7 = default(object);
		object obj6 = obj7 + 128;
		obj6 = onComplete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected override void Show()
	{
		GameObject gameObject = _layoutElement2.gameObject;
		gameObject.SetActive(value: true);
		((BaseDropMenu<object>)(object)this).Show();
	}

	public TwinSlidedKDropMenu()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0025: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		_itemsGameObjects2 = (List<GameObject>)(object)list;
		object obj2 = this + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_zeroYVector = (Vector3)1065353216;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DDA10]");
		_ = 0;
		float num = default(float);
		base.slideListDuration = num;
		((BaseDropMenu<object>)(object)this)..ctor();
	}

	private void <SetupItems2>b__10_1(BaseEventData e)
	{
		((BaseDropMenu<object>)(object)this).Disable();
	}
}
