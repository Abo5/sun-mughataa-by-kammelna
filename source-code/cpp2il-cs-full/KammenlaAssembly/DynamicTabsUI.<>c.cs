using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class DynamicTabsUI : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<Transform> <>9__8_0;

		public static Action<Transform> <>9__9_0;

		public static Action<Toggle> <>9__9_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <OnTabToggle>b__8_0(Transform e)
		{
			GameObject gameObject = e.gameObject;
			gameObject.SetActive(value: false);
		}

		internal void <Clear>b__9_0(Transform g)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			GameObject gameObject = g.gameObject;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+E4]");
			if ((nint)0 != 0)
			{
				UnityEngine.Object.Destroy(gameObject);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.Destroy(gameObject);
		}

		internal void <Clear>b__9_1(Toggle t)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			GameObject gameObject = t.gameObject;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+E4]");
			if ((nint)0 != 0)
			{
				UnityEngine.Object.Destroy(gameObject);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	private sealed class <>c__DisplayClass7_0
	{
		public DynamicTabsUI <>4__this;

		public Transform p;

		internal void <CreateGrouping>b__0(bool c)
		{
			<>4__this.OnTabToggle(p, c);
		}
	}

	private Transform parent;

	private Toggle toggle;

	private Transform togglesParent;

	private TabsUI tabsUI;

	private Dictionary<string, Transform> groupings;

	private List<Toggle> toggles;

	public T AddItem<T>(T prefab, string group) where T : UnityEngine.Object
	{
		//IL_0066: Expected O, but got I4
		//IL_008f: Expected O, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00e1: Expected O, but got I4
		if (groupings != null)
		{
			bool flag = ((Dictionary<object, object>)(object)groupings).ContainsKey((object)group);
			bool flag2 = !flag;
			object obj = !flag2;
			if (obj == null)
			{
				CreateGrouping(group);
			}
			object obj2 = (nint)0 + (nint)3288;
			object obj3 = DictionaryExtensions.Get((IDictionary<object, object>)groupings, group);
			object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return UnityEngine.Object.Instantiate(prefab, (Transform)obj3);
		}
		return (T)(object)new NullReferenceException();
	}

	private void CreateGrouping(string group)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_005b: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0111: Expected O, but got I
		//IL_0149: Expected O, but got I
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0186: Expected O, but got I
		//IL_01ab: Expected O, but got I
		//IL_01b7: Expected O, but got I
		//IL_0282: Expected O, but got I4
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		object obj = typeof(DebugUI.BitField) + 1176;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj5 = (nint)0 + (nint)856;
		Transform transform = parent.parent;
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object obj8 = obj2 + 24;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = ((Component)obj8).gameObject;
		gameObject.SetActive(value: true);
		object obj10 = (nint)0 + (nint)960;
		((Dictionary<object, object>)(object)groupings).Add((object)group, obj8);
		GameObject gameObject2 = parent.gameObject;
		object obj11 = (nint)0 + (nint)776;
		gameObject2.SetActive(value: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
		object obj12 = typeof(TypeConverter<ushort, char>) + 360;
		object obj13 = (nint)0 + (nint)2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4027FE0");
		object obj14 = (nint)0 + (nint)832;
		object obj15 = (nint)0 + (nint)288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4029444");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		TextMeshProUGUI textMeshProUGUI = default(TextMeshProUGUI);
		if ((object)textMeshProUGUI != null)
		{
			TextMeshProExtensions.FixArabic(textMeshProUGUI, group);
		}
		Component component = default(Component);
		GameObject gameObject3 = component.gameObject;
		gameObject3.SetActive(value: true);
		List<object> list = (List<object>)(object)toggles;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag2 = list._size < items.Length;
		object obj16 = !flag2;
		if (obj16 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj17 = items + list._size;
			object obj18 = obj17 + 32;
			obj18 = component;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)component);
		}
		GameObject gameObject4 = toggle.gameObject;
		gameObject4.SetActive(value: false);
		((Toggle)component).isOn = true;
		OnTabToggle((Transform)obj8, isOn: true);
	}

	private void OnTabToggle(Transform tab, bool isOn)
	{
		//IL_0011: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00d9: Expected O, but got I
		//IL_00e9: Expected O, but got I
		//IL_010b: Expected O, but got I4
		//IL_0071: Expected O, but got I
		//IL_0081: Expected O, but got I
		//IL_00a3: Expected O, but got I4
		//IL_013b: Expected O, but got I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01e7: Expected O, but got I
		//IL_01f8: Expected I, but got O
		//IL_0216: Expected O, but got I
		//IL_016b: Expected O, but got I
		if (!isOn)
		{
			return;
		}
		object obj = (nint)0 + (nint)1008;
		Dictionary<object, object>.ValueCollection values = ((Dictionary<object, object>)(object)groupings).Values;
		object obj2 = typeof(DebugUI.BitField) + 1168;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v11+E4]");
		object obj4;
		Action<object> action;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v11+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v11+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v11+8]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				goto IL_0119;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v11+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v11+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v11+8]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				goto IL_0119;
			}
		}
		goto IL_0170;
		IL_0119:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v17+B8]");
			obj4 = 0;
		}
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)2408;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj4, (IntPtr)obj10);
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v16+B8]");
		object obj12 = (nint)0 + (nint)8;
		obj12 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action2;
		goto IL_0170;
		IL_0170:
		ArraysExtensions.ForEach(values, action);
		GameObject gameObject = tab.gameObject;
		gameObject.SetActive(value: true);
	}

	public void Clear()
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0065: Expected O, but got I
		//IL_0166: Expected O, but got I
		//IL_0176: Expected O, but got I
		//IL_0186: Expected O, but got I
		//IL_01a8: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		//IL_00ad: Expected O, but got I
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_03bd: Expected O, but got I
		//IL_03cd: Expected O, but got I
		//IL_03ef: Expected O, but got I4
		//IL_0400: Expected O, but got I
		//IL_0245: Expected O, but got I
		//IL_01e0: Expected O, but got I4
		//IL_02ca: Expected O, but got I
		//IL_02da: Expected O, but got I
		//IL_0302: Expected O, but got I
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_04d7: Expected O, but got I
		//IL_04e8: Expected I, but got O
		//IL_0506: Expected O, but got I
		//IL_0430: Expected O, but got I4
		//IL_0210: Expected O, but got I
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected O, but got Unknown
		//IL_0547: Expected O, but got I
		//IL_0558: Expected I, but got O
		//IL_0576: Expected O, but got I
		//IL_0498: Expected O, but got I4
		//IL_0460: Expected O, but got I
		object obj = (nint)0 + (nint)992;
		object obj2 = typeof(DebugUI.BitField) + 1168;
		object obj3 = obj;
		int count = ((Dictionary<object, object>)(object)groupings).Count;
		Dictionary<object, object>.ValueCollection values;
		object obj6;
		Action<object> action;
		Dictionary<object, object> dictionary;
		object obj16;
		if (count >= 1)
		{
			object obj4 = (nint)0 + (nint)1008;
			values = ((Dictionary<object, object>)(object)groupings).Values;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v28+E4]");
			object obj7;
			object obj8;
			if ((nint)0 != 0)
			{
				obj6 = (nint)0 + (nint)2400;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v28+B8]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v32+10]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v32+10]");
				bool flag = (nint)0 == 0;
				obj8 = obj6;
				if (!flag)
				{
					goto IL_00fa;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj2;
				obj6 = (nint)0 + (nint)2400;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v28+B8]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v32+10]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v32+10]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				obj8 = obj6;
				if (obj9 != null)
				{
					goto IL_00fa;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v28+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v38+B8]");
				obj7 = 0;
			}
			object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3856;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)2392;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj7, (IntPtr)obj13);
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v37+B8]");
			object obj15 = (nint)0 + (nint)16;
			obj15 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj16 = obj8;
			ArraysExtensions.ForEach(values, action2);
			dictionary = (Dictionary<object, object>)(object)groupings;
			goto IL_0239;
		}
		goto IL_025b;
		IL_00fa:
		obj16 = obj6;
		ArraysExtensions.ForEach(values, action);
		dictionary = (Dictionary<object, object>)(object)groupings;
		bool flag4 = groupings == null;
		object obj17 = !flag4;
		if (obj17 != null)
		{
			goto IL_0239;
		}
		goto IL_04a6;
		IL_04a6:
		throw new NullReferenceException();
		IL_025b:
		List<object> list = (List<object>)(object)toggles;
		if (list._size < 1)
		{
			return;
		}
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v9+E4]");
		object obj19;
		Action<object> action3;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v9+B8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v11+18]");
			action3 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v11+18]");
			bool flag5 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v11+18]");
			Action<object> action4 = (Action<object>)0;
			if (!flag5)
			{
				goto IL_0310;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v9+B8]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v11+18]");
			action3 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v11+18]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v11+18]");
			Action<object> action4 = (Action<object>)0;
			if (obj20 != null)
			{
				goto IL_0310;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X0_v9+E4]");
		bool flag7 = (nint)0 == 0;
		object obj21 = !flag7;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj22 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v18+B8]");
			obj19 = 0;
		}
		object obj23 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)2400;
		Action<object> action5 = default(Action<object>);
		action5..ctor(obj19, (IntPtr)obj24);
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v16+B8]");
		object obj26 = (nint)0 + (nint)24;
		obj26 = action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		list.ForEach(action5);
		List<Toggle> list2 = toggles;
		bool flag8 = toggles == null;
		object obj27 = !flag8;
		if (obj27 != null)
		{
			goto IL_032c;
		}
		goto IL_04a6;
		IL_0239:
		object obj28 = (nint)0 + (nint)968;
		obj3 = obj28;
		dictionary.Clear();
		goto IL_025b;
		IL_032c:
		int version = list2._version + 1;
		list2._size = 0;
		list2._version = version;
		if (list2._size >= 1)
		{
			Array.Clear(list2._items, 0, list2._size);
		}
		return;
		IL_0310:
		list.ForEach(action3);
		list2 = toggles;
		goto IL_032c;
	}

	public DynamicTabsUI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2848;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 3960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj3 = this + 64;
		obj3 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = this + 72;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
