using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.UI;

public class VoteCreator : MonoBehaviour
{
	private Transform layout;

	private TMP_InputField questionField;

	private TMP_InputField optionPrefab;

	private TMP_InputField newOptionField;

	private Button confirmButton;

	private int minimumOptions;

	private int maximumOptions;

	private readonly List<TMP_InputField> inactiveOptions;

	private readonly List<TMP_InputField> activeOptions;

	private void Start()
	{
		//IL_0011: Expected O, but got I
		//IL_0075: Expected O, but got I4
		//IL_0116: Expected O, but got I
		//IL_0126: Expected O, but got I
		//IL_0136: Expected O, but got I
		//IL_0166: Expected O, but got I
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0194: Expected O, but got I
		//IL_019d: Expected O, but got I4
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03d0: Expected O, but got I
		//IL_03e8: Expected I, but got O
		//IL_0250: Expected O, but got I4
		//IL_02e8: Expected O, but got I4
		//IL_01b2: Expected O, but got I
		//IL_01c2: Expected O, but got I
		//IL_01d2: Expected O, but got I
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0218: Expected O, but got I
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		List<object> list = (List<object>)(object)inactiveOptions;
		object obj = (nint)0 + (nint)40;
		object obj2 = optionPrefab;
		object obj3 = obj;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag = list._size < items.Length;
		object obj4 = !flag;
		if (obj4 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj5 = items + list._size;
			object obj6 = obj5 + 32;
			obj6 = optionPrefab;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (maximumOptions >= 2)
			{
				goto IL_0174;
			}
			object obj8 = default(object);
			object obj7 = obj8;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v4+20]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v18+C0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v19+70]");
			object obj8 = 0;
			list.AddWithResize((object)optionPrefab);
			bool flag2 = maximumOptions < 2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v19+70]");
			object obj7 = 0;
			if (!flag2)
			{
				goto IL_0174;
			}
		}
		goto IL_0384;
		IL_0384:
		Transform transform = newOptionField.transform;
		transform.SetAsLastSibling();
		TMP_InputField tMP_InputField = questionField;
		object obj11 = typeof(TypeConverter<ushort, char>) + 464;
		object obj12 = (nint)0 + (nint)3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<object> unityAction = default(UnityAction<object>);
		unityAction..ctor((object)this, (IntPtr)obj12);
		((UnityEvent<object>)(object)tMP_InputField.m_OnEndEdit).AddListener(unityAction);
		bool interactable = IsValid();
		confirmButton.interactable = interactable;
		return;
		IL_0174:
		object obj13 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj14 = (nint)0 + (nint)744;
		object obj15 = 1;
		object obj22 = default(object);
		while (true)
		{
			object obj16 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj8 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			List<object> list2 = (List<object>)(object)inactiveOptions;
			object obj18 = obj;
			int version2 = list2._version + 1;
			list2._version = version2;
			object[] items2 = list2._items;
			bool flag4 = list2._size < items2.Length;
			object obj19 = !flag4;
			if (obj19 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v12+20]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v15+C0]");
				object obj21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v16+70]");
				obj8 = 0;
				list2.AddWithResize(obj22);
				obj15++;
				bool flag5 = (nint)obj15 >= maximumOptions;
				obj2 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v16+70]");
				object obj7 = 0;
				if (flag5)
				{
					break;
				}
			}
			else
			{
				int size2 = list2._size + 1;
				list2._size = size2;
				object obj23 = items2 + list2._size;
				object obj24 = obj23 + 32;
				obj24 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj15++;
				bool flag6 = (nint)obj15 < maximumOptions;
				obj2 = obj22;
				object obj7 = obj8;
				if (!flag6)
				{
					break;
				}
			}
		}
		goto IL_0384;
	}

	public void AddNewOption(string option)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_0113: Expected O, but got I4
		//IL_01e4: Expected O, but got I4
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_029f: Expected O, but got I4
		//IL_02af: Expected O, but got I
		//IL_02bf: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8829]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v25+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = StringsExtensions.IsNullOrEmpty(option);
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			return;
		}
		goto IL_0121;
		IL_0121:
		object obj6 = ((List<object>)(object)inactiveOptions).get_Item(0);
		bool flag4 = ((List<object>)(object)inactiveOptions).Remove(obj6);
		((TMP_InputField)obj6).text = option;
		GameObject gameObject = ((Component)obj6).gameObject;
		gameObject.SetActive(value: true);
		List<object> list = (List<object>)(object)activeOptions;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag5 = list._size < items.Length;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj8 = items + list._size;
			object obj9 = obj8 + 32;
			obj9 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize(obj6);
		}
		Transform transform = ((Component)obj6).transform;
		List<TMP_InputField> list2 = activeOptions;
		transform.SetSiblingIndex(list2._size);
		object obj10 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v14+90]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v15+B8]");
		object text = 0;
		newOptionField.text = (string)text;
		List<TMP_InputField> list3 = activeOptions;
		if (list3._size >= maximumOptions)
		{
			GameObject gameObject2 = newOptionField.gameObject;
			gameObject2.SetActive(value: false);
		}
		bool interactable = IsValid();
		confirmButton.interactable = interactable;
		return;
		IL_0074:
		if (StringsExtensions.IsNullOrEmpty(option))
		{
			return;
		}
		goto IL_0121;
	}

	public void RemoveOption(TMP_InputField optionField)
	{
		RemoveOption(optionField, delayedRemove: false);
	}

	public void RemoveOption(TMP_InputField optionField, bool delayedRemove)
	{
		//IL_01a7: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_008c: Expected O, but got I4
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		bool flag2 = default(bool);
		bool flag = !flag2;
		object obj = !flag;
		if (obj == null)
		{
			object obj2 = (nint)0 + (nint)64;
			bool flag3 = ((List<object>)(object)activeOptions).Remove((object)optionField);
		}
		List<object> list = (List<object>)(object)inactiveOptions;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag4 = list._size < items.Length;
		object obj3 = !flag4;
		if (obj3 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj4 = items + list._size;
			object obj5 = obj4 + 32;
			obj5 = optionField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)optionField);
		}
		GameObject gameObject = optionField.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = newOptionField.gameObject;
		gameObject2.SetActive(value: true);
		Transform transform = newOptionField.transform;
		transform.SetAsLastSibling();
		bool interactable = IsValid();
		confirmButton.interactable = interactable;
	}

	public void Clear()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Expected O, but got I4
		//IL_0044: Expected O, but got I
		//IL_0054: Expected O, but got I
		//IL_0080: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3616;
		object obj2 = (nint)0 + (nint)3568;
		object obj3 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+90]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v6+B8]");
		object text = 0;
		questionField.text = (string)text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		((List<object>)(object)activeOptions).ForEach(action);
		List<TMP_InputField> list = activeOptions;
		int version = list._version + 1;
		list._size = 0;
		list._version = version;
		if (list._size >= 1)
		{
			Array.Clear(list._items, 0, list._size);
		}
	}

	private void OnOptionsUpdated()
	{
		bool interactable = IsValid();
		confirmButton.interactable = interactable;
	}

	private bool IsValid()
	{
		//IL_00e8: Expected I4, but got O
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0098: Expected O, but got I4
		List<TMP_InputField> list = activeOptions;
		if (activeOptions != null)
		{
			if (list._size < minimumOptions)
			{
				return false;
			}
			TMP_InputField tMP_InputField = questionField;
			if ((object)questionField != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = StringsExtensions.IsNullOrEmpty(tMP_InputField.m_Text);
				return (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public VoteCreator()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3784;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70E3238]");
		minimumOptions = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 80;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj3 = this + 88;
		obj3 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <Start>b__9_0(string s)
	{
		bool interactable = IsValid();
		confirmButton.interactable = interactable;
	}

	private void <Clear>b__13_0(TMP_InputField o)
	{
		RemoveOption(o, delayedRemove: true);
	}
}
