using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Threading;
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
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class BaseDropMenu<T> : DummyBaseDropMenu
{
	private sealed class <>c__DisplayClass24_0
	{
		public int index;

		public BaseDropMenu<T> <>4__this;

		internal void <SetupItems>b__0()
		{
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_0041: Expected O, but got I
			BaseDropMenu<T> baseDropMenu = <>4__this;
			int num = index;
			nint num2 = (nint)baseDropMenu;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v2 (Il2CppClass<BaseDropMenu`1<T>>)+1D8]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v2 (Il2CppClass<BaseDropMenu`1<T>>)+1E0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v6 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass32_0
	{
		public BaseDropMenu<T> <>4__this;

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
			//IL_0155: Expected O, but got I
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected O, but got Unknown
			//IL_018a: Expected O, but got I
			//IL_019a: Expected O, but got I
			//IL_01aa: Expected O, but got I
			//IL_01ba: Expected O, but got I
			//IL_01c8: Expected O, but got I4
			while (true)
			{
				BaseDropMenu<T> baseDropMenu = <>4__this;
				object obj = typeof(MemberAchievementClanFeedData) + 2976;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v4+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v3 (BaseDropMenu`1<T>)+48]");
					if ((UnityEngine.Object)0 == null)
					{
						break;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v3 (BaseDropMenu`1<T>)+48]");
					bool flag = (UnityEngine.Object)0 == null;
					bool flag2 = !flag;
					object obj3 = !flag2;
					if (obj3 != null)
					{
						break;
					}
				}
				BaseDropMenu<T> baseDropMenu2 = <>4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6 (BaseDropMenu`1<T>)+48]");
				GameObject gameObject = ((Component)0).gameObject;
				gameObject.SetActive(value: false);
				BaseDropMenu<T> baseDropMenu3 = <>4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v7 (BaseDropMenu`1<T>)+40]");
				GameObject gameObject2 = ((Component)0).gameObject;
				gameObject2.SetActive(value: false);
				BaseDropMenu<T> baseDropMenu4 = <>4__this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v8 (BaseDropMenu`1<T>)+48]");
				Transform transform = ((Component)0).transform;
				object obj4 = typeof(UsageHint) + 816;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v13+B8]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v14+10]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v14+14]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v14+C]");
				object obj9 = 0;
				transform.localScale = (Vector3)0;
				Action action = moveBlocker;
				IntPtr invoke_impl = ((Delegate)action).invoke_impl;
				IntPtr method_code = ((Delegate)action).method_code;
				IntPtr method = ((Delegate)action).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v125 @ X2_v5 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public LayoutGroup ItemGrandParent;

	public LayoutGroup ItemParent;

	public GameObject listItemPrefab;

	public TextMeshProUGUI selectedText;

	protected bool _showSelectedItem;

	protected bool _showFirstEntrySelected;

	protected GameObject _selectedListItemPrefab;

	protected GameObject _selectedListItem;

	private bool _setupOnAwake;

	public GameObject blocker;

	public bool localize;

	public bool partOfNavigation;

	public string placeholder;

	public List<T> items;

	protected List<GameObject> itemsGameObjects;

	protected int disabledIndex;

	protected bool initialized;

	private Action _onShow;

	private Action _onHide;

	public T SelectedItem
	{
		get
		{
			//IL_0034: Expected I4, but got I8
			//IL_004e: Expected O, but got I4
			//IL_009f: Expected O, but got I
			//IL_00a3: Expected O, but got I4
			if ((object)this != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+34]");
				int num = 0;
				bool flag = num == 0;
				object obj = !flag;
				if (obj != null)
				{
					return (T)null;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+98]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+98]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+34]");
					return (T)((List<System.Int32Enum>)num2).get_Item(0);
				}
			}
			return (T)new NullReferenceException();
		}
	}

	public override object selectedItem
	{
		get
		{
			//IL_003a: Expected I4, but got I8
			//IL_0054: Expected O, but got I4
			//IL_0097: Expected O, but got I
			//IL_00a7: Expected O, but got I
			//IL_00b7: Expected O, but got I
			//IL_00d4: Expected O, but got I
			if ((object)this != null)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+34]");
				int num2 = 0;
				bool flag = num2 == 0;
				object obj = !flag;
				if (obj == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+98]");
					if ((nint)0 == 0)
					{
						goto IL_00ef;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v3 (Il2CppRgctx<BaseDropMenu`1>)+20]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v5+20]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v6+C0]");
					object obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+98]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+34]");
					System.Int32Enum int32Enum = ((List<System.Int32Enum>)num3).get_Item(0);
					nint num4 = 0;
				}
				else
				{
					nint num4 = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object result = default(object);
				return result;
			}
			goto IL_00ef;
			IL_00ef:
			return new NullReferenceException();
		}
	}

	public void Awake()
	{
		//IL_0016: Expected O, but got I
		//IL_0030: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+AC]");
		object obj = (nint)0 & (nint)1;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+78]");
			if ((nint)0 == 1)
			{
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3E222C4");
			}
		}
	}

	public void SetupItems(List<T> newItems, Action onShow = null, Action onHide = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0c6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c73: Expected O, but got Unknown
		//IL_0c9d: Expected I, but got O
		//IL_003b: Expected O, but got I
		//IL_004b: Expected O, but got I
		//IL_0076: Expected O, but got I
		//IL_00a1: Expected O, but got I4
		//IL_00a9: Expected I4, but got O
		//IL_0109: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_00d9: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_01ca: Expected O, but got I
		//IL_01e0: Expected O, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_0208: Expected O, but got I4
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0575: Expected O, but got I
		//IL_0277: Expected O, but got I
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_02b9: Expected O, but got I4
		//IL_02e2: Expected O, but got I
		//IL_05a2: Expected O, but got I
		//IL_0310: Expected O, but got I
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_072b: Expected O, but got I
		//IL_0376: Expected O, but got I
		//IL_074e: Expected O, but got I4
		//IL_0615: Expected O, but got I
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_0653: Expected O, but got I4
		//IL_0686: Expected O, but got I
		//IL_069e: Expected O, but got I
		//IL_076c: Expected O, but got I
		//IL_0796: Expected O, but got I
		//IL_07a6: Expected O, but got I
		//IL_07b6: Expected O, but got I
		//IL_07e1: Expected O, but got I
		//IL_0803: Expected O, but got I4
		//IL_080c: Expected O, but got I4
		//IL_0815: Expected O, but got I4
		//IL_06c9: Expected O, but got I
		//IL_06eb: Expected O, but got I4
		//IL_06f4: Expected O, but got I4
		//IL_03d8: Expected O, but got I4
		//IL_0cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Expected O, but got Unknown
		//IL_08a3: Expected O, but got I
		//IL_083a: Expected O, but got I4
		//IL_070b: Expected O, but got I4
		//IL_044a: Expected O, but got I
		//IL_08c0: Expected O, but got I4
		//IL_0851: Expected O, but got I
		//IL_086b: Expected O, but got I4
		//IL_08e4: Expected O, but got I
		//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f8: Expected O, but got Unknown
		//IL_04a9: Expected O, but got I4
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Expected O, but got Unknown
		//IL_0bb5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bba: Expected O, but got Unknown
		//IL_0882: Expected O, but got I4
		//IL_0133: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_0190: Expected O, but got I4
		//IL_0199: Expected O, but got I4
		//IL_01a1: Expected I4, but got O
		//IL_0ad7: Expected O, but got I
		//IL_0aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aef: Expected O, but got Unknown
		//IL_0b19: Expected O, but got I4
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_0937: Expected O, but got Unknown
		//IL_04e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e9: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_0528: Expected O, but got I4
		//IL_0530: Expected I4, but got O
		//IL_0b42: Expected O, but got I
		//IL_0b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5f: Expected O, but got Unknown
		//IL_096e: Expected O, but got I
		//IL_0b8d: Expected O, but got I4
		//IL_0999: Expected O, but got I
		//IL_09c6: Expected O, but got I
		//IL_0a20: Expected O, but got I4
		//IL_0be8: Expected O, but got I
		//IL_0bf8: Expected O, but got I
		//IL_0c08: Expected O, but got I
		//IL_0c35: Expected O, but got I4
		//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected O, but got Unknown
		//IL_0a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Expected O, but got Unknown
		//IL_0a89: Expected O, but got I4
		//IL_0c4c: Expected O, but got I4
		//IL_0c5c: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		object obj2 = (nint)0 + (nint)1120;
		object obj3 = this + 152;
		List<T> list = default(List<T>);
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X23_v3+8]");
		((List<object>)0).ForEach(action);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v6+18]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v6+1C]");
		object obj5 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v6+18]");
		bool flag = (nint)0 < (nint)1;
		object obj6 = 0;
		int num2 = (int)action;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v6+10]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v6+18]");
			Array.Clear((Array)num3, 0, 0);
			obj6 = 0;
			num2 = 0;
		}
		object obj7 = obj3;
		object obj8 = (nint)0 + (nint)152;
		object obj9 = (nint)0 + (nint)2544;
		int num4 = 0;
		object obj15 = default(object);
		GameObject gameObject = default(GameObject);
		UnityAction unityAction = default(UnityAction);
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		while (true)
		{
			int num5 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X8_v8+18]");
			if ((nint)num5 < (nint)0)
			{
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v55 (Il2CppRgctx<BaseDropMenu`1>)+30]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X8_v55 (Il2CppRgctx<BaseDropMenu`1>)+30]");
				object obj11 = (nint)0 + (nint)309;
				object obj12 = obj11 & 1;
				bool flag2 = obj12 == null;
				object obj13 = !flag2;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31DD9DC");
				object obj14 = obj15 + 24;
				obj14 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+48]");
				Transform transform = ((Component)0).transform;
				object obj16 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj17 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v79+E4]");
				bool flag3 = (nint)0 == 0;
				object obj18 = !flag3;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj19 = (nint)0 + (nint)920;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
				gameObject.SetActive(value: true);
				object obj20 = (nint)0 + (nint)1128;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				object obj21 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v70 (Il2CppRgctx<BaseDropMenu`1>)+40]");
				unityAction..ctor(obj15, (IntPtr)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v84+100]");
				((UnityEvent)0).AddListener(unityAction);
				Transform transform2 = gameObject.transform;
				object n = "SubscribeGroup request Error" + 3464;
				Transform transform3 = transform2.Find((string)n);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				System.Int32Enum int32Enum = ((List<System.Int32Enum>)obj3).get_Item(num4);
				string text = ItemName((T)int32Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+88]");
				if ((nint)0 == 1)
				{
					TextMeshProExtensions.Localize(textMesh, text);
					num = 0;
				}
				else
				{
					TextMeshProExtensions.FixArabic(textMesh, text);
					num = 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+A0]");
				List<object> list2 = (List<object>)0;
				object obj22 = obj9;
				int version = list2._version + 1;
				list2._version = version;
				object[] array = list2._items;
				bool flag4 = list2._size < array.Length;
				object obj23 = !flag4;
				if (obj23 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v77+20]");
					object obj24 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v80+C0]");
					object obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v765 @ X8_v81+70]");
					num = 0;
					list2.AddWithResize((object)gameObject);
					num4++;
					obj7 = obj3;
					bool flag5 = obj3 == null;
					object obj26 = !flag5;
					obj6 = 0;
					num2 = (int)gameObject;
					if (obj26 == null)
					{
						throw new NullReferenceException();
					}
				}
				else
				{
					int size = list2._size + 1;
					list2._size = size;
					object obj27 = array + list2._size;
					object obj28 = obj27 + 32;
					obj28 = gameObject;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num4++;
					obj7 = obj3;
					obj6 = 0;
					num2 = (int)gameObject;
				}
				continue;
			}
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+48]");
			GameObject gameObject2 = ((Component)0).gameObject;
			gameObject2.SetActive(value: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+40]");
			GameObject gameObject3 = ((Component)0).gameObject;
			gameObject3.SetActive(value: false);
			_ = 4294967295L;
			object obj29 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj30 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+90]");
				if (StringsExtensions.IsNullOrEmpty((string)0))
				{
					goto IL_0636;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+90]");
				bool flag6 = StringsExtensions.IsNullOrEmpty((string)0);
				bool flag7 = !flag6;
				object obj31 = !flag7;
				if (obj31 != null)
				{
					goto IL_0636;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+90]");
			string text2 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+88]");
			bool flag8 = (nint)0 != 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+58]");
			TextMeshProUGUI textMesh2 = (TextMeshProUGUI)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+90]");
			string text3 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+58]");
			TextMeshProUGUI textMesh3 = (TextMeshProUGUI)0;
			if (flag8)
			{
				goto IL_06ac;
			}
			goto IL_07c4;
			IL_0636:
			System.Int32Enum int32Enum2 = ((List<System.Int32Enum>)obj3).get_Item(0);
			string text4 = ItemName((T)int32Enum2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+88]");
			bool flag9 = (nint)0 == 1;
			text2 = text4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+58]");
			textMesh2 = (TextMeshProUGUI)0;
			text3 = text4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+58]");
			textMesh3 = (TextMeshProUGUI)0;
			if (!flag9)
			{
				goto IL_06ac;
			}
			goto IL_07c4;
			IL_07c4:
			TextMeshProExtensions.Localize(textMesh3, text3);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+A8]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+A8]");
			bool flag10 = (nint)0 == 0;
			object obj33 = !flag10;
			object obj34 = 0;
			object obj35 = 0;
			if (obj33 != null)
			{
				break;
			}
			goto IL_0823;
			IL_0823:
			_ = 2147483647;
			obj35 = obj34;
			obj32 = 2147483647;
			break;
			IL_06ac:
			TextMeshProExtensions.FixArabic(textMesh2, text2);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+A8]");
			obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+A8]");
			bool flag11 = (nint)0 == 0;
			object obj36 = !flag11;
			obj35 = 0;
			if (obj36 != null)
			{
				break;
			}
			obj34 = 0;
			goto IL_0823;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3E23488");
		object obj37 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X0_v18+E4]");
		object obj40;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+80]");
			bool flag12 = (UnityEngine.Object)0 != null;
			bool flag13 = !flag12;
			object obj39 = !flag13;
			if (obj39 != null)
			{
				goto IL_08ce;
			}
			obj40 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+80]");
			bool flag14 = (UnityEngine.Object)0 != null;
			bool flag15 = !flag14;
			obj40 = 0;
			if (!flag15)
			{
				goto IL_08ce;
			}
		}
		goto IL_0a8e;
		IL_0ac6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+48]");
		Transform transform4 = ((Component)0).transform;
		object obj41 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj42 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X0_v28+E4]");
		bool flag16 = (nint)0 == 0;
		object obj43 = !flag16;
		if (obj43 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj44 = (nint)0 + (nint)920;
		object obj45 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
		object obj46 = this + 112;
		object obj47 = default(object);
		obj46 = obj47;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((GameObject)obj46).SetActive(value: false);
		object obj48 = 0;
		goto IL_0b92;
		IL_0a8e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+60]");
		bool flag17 = (nint)0 != 1;
		obj45 = obj6;
		obj48 = obj40;
		if (!flag17)
		{
			goto IL_0ac6;
		}
		goto IL_0b92;
		IL_0b92:
		object obj49 = this + 176;
		obj49 = onShow;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj50 = this + 184;
		obj50 = onHide;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 1;
		return;
		IL_08ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+80]");
		((GameObject)0).SetActive(value: false);
		object obj51 = typeof(DebugUI.BitField) + 1760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		EventTrigger.Entry entry = default(EventTrigger.Entry);
		entry..ctor();
		entry.eventID = EventTriggerType.PointerDown;
		object obj52 = typeof(TypeConverter<ushort, char>) + 352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v34 (Il2CppRgctx<BaseDropMenu`1>)+68]");
		UnityAction<object> unityAction2 = default(UnityAction<object>);
		unityAction2..ctor((object)this, (IntPtr)0);
		object obj53 = (nint)0 + (nint)808;
		obj40 = obj53;
		((UnityEvent<object>)(object)entry.callback).AddListener(unityAction2);
		object obj54 = (nint)0 + (nint)1264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		EventTrigger eventTrigger = default(EventTrigger);
		List<EventTrigger.Entry> triggers = eventTrigger.triggers;
		object obj55 = (nint)0 + (nint)2152;
		object obj56 = obj55;
		int version2 = triggers._version + 1;
		triggers._version = version2;
		EventTrigger.Entry[] array2 = triggers._items;
		bool flag18 = triggers._size < array2.Length;
		object obj57 = !flag18;
		if (obj57 == null)
		{
			int size2 = triggers._size + 1;
			triggers._size = size2;
			object obj58 = array2 + triggers._size;
			object obj59 = obj58 + 32;
			obj59 = entry;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj6 = 0;
			goto IL_0a8e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v41+20]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v774 @ X8_v42+C0]");
		object obj61 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v43+70]");
		obj40 = 0;
		((List<object>)(object)triggers).AddWithResize((object)entry);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+60]");
		bool flag19 = (nint)0 == 1;
		obj6 = 0;
		if (flag19)
		{
			goto IL_0ac6;
		}
		obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X8_v43+70]");
		obj48 = 0;
		goto IL_0b92;
	}

	public void Toggle()
	{
		//IL_0016: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_0113: Expected O, but got I
		//IL_0135: Expected O, but got I4
		//IL_00d3: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_00f3: Expected O, but got I
		//IL_0064: Expected O, but got I
		//IL_0074: Expected O, but got I
		//IL_0084: Expected O, but got I
		//IL_009e: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+30]");
		object obj = (nint)0 ^ (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+30]");
		object obj2 = (nint)0 & (nint)1;
		object obj6;
		if (obj2 != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v7 (Il2CppRgctx<BaseDropMenu`1>)+70]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v8+20]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v36 @ X8_v9+C0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3E22C78");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B8]");
			if ((nint)0 != 0)
			{
				goto IL_00c3;
			}
			return;
		}
		goto IL_00fd;
		IL_00fd:
		Show();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B0]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B0]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			return;
		}
		goto IL_00c3;
		IL_00c3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+18]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+40]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+28]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v64 @ X2_v1 (should have been resolved before IL gen)");
		goto IL_00fd;
	}

	public void Disable()
	{
		//IL_001c: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_003c: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_008b: Expected O, but got I
		//IL_009b: Expected O, but got I
		//IL_00ab: Expected O, but got I
		_ = 0;
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2 (Il2CppRgctx<BaseDropMenu`1>)+70]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v3+20]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v4+C0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3E22C78");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v6+18]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v6+40]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X8_v6+28]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v37 @ X2_v1 (should have been resolved before IL gen)");
		}
	}

	protected void UpdateUI()
	{
		//IL_00bd: Expected O, but got I
		//IL_00df: Expected O, but got I4
		//IL_0073: Expected O, but got I
		//IL_0083: Expected O, but got I
		//IL_0093: Expected O, but got I
		//IL_003e: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+30]");
		object obj;
		if ((nint)0 == 1)
		{
			Show();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B0]");
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B0]");
			if ((nint)0 != 0)
			{
				goto IL_0063;
			}
			return;
		}
		goto IL_009d;
		IL_009d:
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3E22C78");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B8]");
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B8]");
		bool flag = (nint)0 == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			return;
		}
		goto IL_0063;
		IL_0063:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v6+18]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v6+40]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v6+28]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v59 @ X2_v1 (should have been resolved before IL gen)");
		goto IL_009d;
	}

	protected virtual void Show()
	{
		//IL_0016: Expected O, but got I
		//IL_0043: Expected O, but got I
		//IL_005f: Expected I, but got O
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0123: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+48]");
		GameObject gameObject = ((Component)0).gameObject;
		gameObject.SetActive(value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+40]");
		GameObject gameObject2 = ((Component)0).gameObject;
		gameObject2.SetActive(value: true);
		nint num = (nint)this;
		((BaseDropMenu<>)(object)this).OnShowMenu();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3E231D0");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+89]");
		if ((nint)0 == 1)
		{
			GameObject popup = base.gameObject;
			object obj = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v9 (Il2CppRgctx<BaseDropMenu`1>)+98]");
			Action action = default(Action);
			action..ctor(this, (IntPtr)0);
			object obj2 = typeof(RegisteredWaitHandle) + 3136;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			ScreenManager.PushPopup(popup, action);
		}
		InvokeOnOpen();
	}

	public void Hide()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0061: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 3136;
		object obj2 = typeof(SqlSingle[]) + 2376;
		GameObject go = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.RemovePopup(go);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v5 (Il2CppRgctx<BaseDropMenu`1>)+90]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		((BaseDropMenu<>)(object)this).OnHideMenu(action);
		InvokeOnClose();
	}

	public virtual void OnShowMenu()
	{
		//IL_0016: Expected O, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_004b: Expected O, but got I
		//IL_005b: Expected O, but got I
		//IL_0069: Expected O, but got I4
		//IL_007a: Expected O, but got I
		//IL_008b: Expected O, but got I
		//IL_00cf: Expected O, but got I
		//IL_0102: Expected I, but got O
		//IL_0112: Expected O, but got I
		//IL_0122: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+48]");
		Transform transform = ((Component)0).transform;
		object obj = typeof(UsageHint) + 816;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v8+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v9+8]");
		object obj4 = 0;
		transform.localScale = (Vector3)0;
		object obj5 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+48]");
		Transform target = ((Component)0).transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 1f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+40]");
		Transform target2 = ((Component)0).transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, 1f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v14 (Il2CppClass<BaseDropMenu`1<T>>)+1B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v14 (Il2CppClass<BaseDropMenu`1<T>>)+1C0]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v93 @ X2_v4 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void ShowSelected()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I
		//IL_0058: Expected O, but got I
		//IL_0076: Expected O, but got I4
		//IL_00dc: Expected O, but got I
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_00fd: Expected O, but got I
		//IL_0136: Expected O, but got I
		//IL_01c9: Expected O, but got I
		//IL_0203: Expected O, but got I
		//IL_0247: Expected O, but got I
		//IL_0257: Expected O, but got I4
		//IL_02f2: Expected O, but got I
		//IL_0314: Expected O, but got I4
		//IL_02a0: Expected O, but got I
		//IL_02c2: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+60]");
		if ((nint)0 != 1)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+68]");
			bool flag = (UnityEngine.Object)0 == null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+68]");
			if ((UnityEngine.Object)0 == null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+A0]");
		List<object> list = (List<object>)0;
		object n = "SubscribeGroup request Error" + 3464;
		object obj4 = (nint)0 + (nint)152;
		int num = 0;
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		while (true)
		{
			if (num >= list._size)
			{
				return;
			}
			object obj5 = list.get_Item(num);
			int num2 = num;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+34]");
			GameObject gameObject;
			if ((nint)num2 != 0)
			{
				gameObject = (GameObject)obj5;
			}
			else
			{
				((GameObject)obj5).SetActive(value: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+70]");
				Transform transform = ((GameObject)0).transform;
				int siblingIndex = num + 1;
				transform.SetSiblingIndex(siblingIndex);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+70]");
				Transform transform2 = ((GameObject)0).transform;
				Transform transform3 = transform2.Find((string)n);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+98]");
				System.Int32Enum int32Enum = ((List<System.Int32Enum>)0).get_Item(num);
				string text = ItemName((T)int32Enum);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+88]");
				if ((nint)0 == 1)
				{
					TextMeshProExtensions.Localize(textMesh, text);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+70]");
					gameObject = (GameObject)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+70]");
					bool flag3 = (nint)0 == 0;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						break;
					}
				}
				else
				{
					TextMeshProExtensions.FixArabic(textMesh, text);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+70]");
					gameObject = (GameObject)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+70]");
					bool flag4 = (nint)0 == 0;
					object obj7 = !flag4;
					if (obj7 == null)
					{
						break;
					}
				}
			}
			gameObject.SetActive(value: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+A0]");
			list = (List<object>)0;
			num++;
		}
		throw new NullReferenceException();
	}

	public virtual void OnHideMenu(Action moveBlocker)
	{
		//IL_0130: Expected O, but got I
		//IL_0146: Expected O, but got I
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_016e: Expected O, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0081: Expected O, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00a1: Expected O, but got I
		//IL_00b2: Expected O, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4 (Il2CppRgctx<BaseDropMenu`1>)+B0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4 (Il2CppRgctx<BaseDropMenu`1>)+B0]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31E0AE4");
		object obj6 = default(object);
		object obj5 = obj6 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj6 + 24;
		obj7 = moveBlocker;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = (nint)0 + (nint)2904;
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj10 = (nint)0 + (nint)2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+48]");
		Transform target = ((Component)0).transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 0f, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v12 (Il2CppRgctx<BaseDropMenu`1>)+C0]");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj6, (IntPtr)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void MoveBlocker()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00df: Expected O, but got I
		//IL_0109: Expected O, but got I4
		//IL_0119: Expected O, but got I
		//IL_0060: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_0189: Expected O, but got I
		//IL_019f: Expected O, but got I
		//IL_01b9: Expected O, but got I
		//IL_015e: Expected O, but got I4
		//IL_01e7: Expected O, but got I
		object obj = 152969216;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E216A]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj4;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+80]");
			obj4 = (UnityEngine.Object)0;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+80]");
			obj6 = (UnityEngine.Object)0;
			if (!flag)
			{
				goto IL_009d;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+80]");
			obj4 = (UnityEngine.Object)0;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+80]");
			obj6 = (UnityEngine.Object)0;
			if (obj7 != null)
			{
				goto IL_009d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			return;
		}
		goto IL_016c;
		IL_016c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+80]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+30]");
		((GameObject)num).SetActive(value: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+40]");
		Transform transform = ((Component)0).transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+30]");
		object obj9 = (nint)0 & (nint)1;
		Transform parent;
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+80]");
			parent = ((GameObject)0).transform;
		}
		else
		{
			parent = base.transform;
		}
		transform.SetParent(parent);
		return;
		IL_009d:
		if (obj4 == null)
		{
			return;
		}
		goto IL_016c;
	}

	protected virtual void ItemClicked(int index)
	{
		//IL_0020: Expected O, but got I
		//IL_0036: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_016f: Expected O, but got I4
		//IL_010d: Expected O, but got I
		//IL_011d: Expected O, but got I
		//IL_012d: Expected O, but got I
		//IL_007e: Expected O, but got I
		//IL_008e: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00d8: Expected O, but got I
		((BaseDropMenu<>)(object)this).SetSelectedIndex(index);
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v33 @ X8_v3 (Il2CppRgctx<BaseDropMenu`1>)+D0]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+30]");
		object obj2 = (nint)0 ^ (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+30]");
		object obj3 = (nint)0 & (nint)1;
		object obj9;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X8_v4+20]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v9+C0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v10+70]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X8_v11+20]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v12+C0]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3E22C78");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B8]");
			if ((nint)0 != 0)
			{
				goto IL_00fd;
			}
			return;
		}
		goto IL_0137;
		IL_0137:
		Show();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B0]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B0]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			return;
		}
		goto IL_00fd;
		IL_00fd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8+18]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8+40]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v8+28]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v70 @ X2_v2 (should have been resolved before IL gen)");
		goto IL_0137;
	}

	public virtual void SetSelectedIndex(int index)
	{
		//IL_0029: Expected I4, but got I8
		//IL_0043: Expected O, but got I4
		//IL_00c7: Expected O, but got I4
		//IL_0072: Expected O, but got I
		//IL_00bc: Expected O, but got I
		//IL_00a6: Expected O, but got I
		InvokeOnValueChanged(index);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+34]");
		int num = 0;
		bool flag = num == 0;
		object obj = !flag;
		System.Int32Enum int32Enum2;
		if (obj == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+98]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+34]");
			System.Int32Enum int32Enum = ((List<System.Int32Enum>)num2).get_Item(0);
			int32Enum2 = int32Enum;
		}
		else
		{
			int32Enum2 = (System.Int32Enum)0;
		}
		string text = ItemName((T)int32Enum2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+88]");
		if ((nint)0 == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+58]");
			TextMeshProExtensions.Localize((TextMeshProUGUI)0, text);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+58]");
			TextMeshProExtensions.FixArabic((TextMeshProUGUI)0, text);
		}
	}

	protected unsafe virtual string ItemName(T item)
	{
		//IL_0015: Expected O, but got I
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_003d: Expected O, but got I4
		//IL_0063: Expected O, but got Ref
		nint num = 0;
		object obj = num + 309;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		IntPtr intPtr = default(IntPtr);
		return ((Enum)(&intPtr)).ToString();
	}

	public void DisableItems(int startIndex)
	{
		//IL_010d: Expected O, but got I
		//IL_0012: Expected O, but got I
		//IL_00b0: Expected O, but got I
		//IL_00d2: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+A0]");
		List<object> list = (List<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+A0]");
		bool flag = (nint)0 == 0;
		int num = startIndex;
		if (flag)
		{
			return;
		}
		object obj = (nint)0 + (nint)1128;
		int num2 = startIndex;
		Selectable selectable = default(Selectable);
		while (num2 < list._size)
		{
			object obj2 = list.get_Item(num2);
			bool flag2 = obj2 == null;
			num = num2;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				bool flag3 = (object)selectable == null;
				num = num2;
				if (!flag3)
				{
					selectable.interactable = false;
					num = num2 + 1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+A0]");
					list = (List<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+A0]");
					bool flag4 = (nint)0 == 0;
					object obj3 = !flag4;
					num2 = num;
					if (obj3 != null)
					{
						continue;
					}
				}
			}
			throw new NullReferenceException();
		}
	}

	protected void SetText(TextMeshProUGUI label, string text)
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+88]");
		if ((nint)0 == 1)
		{
			TextMeshProExtensions.Localize(label, text);
		}
		else
		{
			TextMeshProExtensions.FixArabic(label, text);
		}
	}

	public BaseDropMenu()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1168;
		_ = 1;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 160;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <SetupItems>b__24_1(BaseEventData e)
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_003c: Expected O, but got I
		//IL_004c: Expected O, but got I
		//IL_005c: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_0086: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00cb: Expected O, but got I
		//IL_00db: Expected O, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v15 @ X8_v2 (Il2CppRgctx<BaseDropMenu`1>)+98]");
		object obj = 0;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v3+20]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v4+C0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v5+70]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v6+20]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X8_v7+C0]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3E22C78");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BaseDropMenu`1<T>)+B8]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v9+18]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v9+40]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v9+28]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v40 @ X2_v1 (should have been resolved before IL gen)");
		}
	}
}
