using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;

public class TabsButton : MonoBehaviour
{
	private List<GameObject> tabs;

	private UnityEvent<int> onTabChange;

	private List<string> localizationTerms;

	private TextMeshProUGUI tabTitle;

	private int _currentTabIndex;

	private void Start()
	{
		//IL_0016: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_00db: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_019a: Expected O, but got I
		//IL_01b2: Expected I, but got O
		//IL_01cc: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74F2]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74F4]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74F4]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		HideTabs();
		List<object> list = (List<object>)(object)tabs;
		goto IL_0109;
		IL_0109:
		object obj5 = list.get_Item(_currentTabIndex);
		((GameObject)obj5).SetActive(value: true);
		object obj6 = (nint)0 + (nint)3640;
		object text = ((List<object>)(object)localizationTerms).get_Item(_currentTabIndex);
		TextMeshProExtensions.Localize(tabTitle, (string)text);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj8 = (nint)0 + (nint)192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v10+100]");
		((UnityEvent)0).AddListener(unityAction);
		return;
		IL_0066:
		HideTabs();
		list = (List<object>)(object)tabs;
		bool flag2 = tabs == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0109;
	}

	private void OnClick()
	{
		//IL_00b9: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_0085: Expected O, but got I4
		//IL_003c: Expected O, but got I
		int num = ++_currentTabIndex;
		List<GameObject> list = tabs;
		if (num != list._size)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74F4]");
			object obj = (nint)0 & (nint)1;
			if (obj != null)
			{
				goto IL_0059;
			}
		}
		else
		{
			_currentTabIndex = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E74F4]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 != null)
			{
				goto IL_0059;
			}
		}
		_ = 1;
		HideTabs();
		List<object> list2 = (List<object>)(object)tabs;
		goto IL_0101;
		IL_0101:
		object obj4 = list2.get_Item(_currentTabIndex);
		((GameObject)obj4).SetActive(value: true);
		object text = ((List<object>)(object)localizationTerms).get_Item(_currentTabIndex);
		TextMeshProExtensions.Localize(tabTitle, (string)text);
		if (onTabChange != null)
		{
			onTabChange.Invoke(_currentTabIndex);
		}
		return;
		IL_0059:
		HideTabs();
		list2 = (List<object>)(object)tabs;
		bool flag2 = tabs == null;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0101;
	}

	private void IncreaseIndex()
	{
		int num = ++_currentTabIndex;
		List<GameObject> list = tabs;
		if (num == list._size)
		{
			_currentTabIndex = 0;
		}
	}

	private void RefreshTabsGraphics()
	{
		HideTabs();
		object obj = ((List<object>)(object)tabs).get_Item(_currentTabIndex);
		((GameObject)obj).SetActive(value: true);
	}

	private void HideTabs()
	{
		//IL_0116: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_012c: Expected I, but got O
		//IL_00b7: Expected I, but got O
		//IL_0069: Expected O, but got I4
		bool flag = tabs == null;
		object obj = 152989696;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)1048;
			obj = (nint)0 + (nint)1040;
			List<object>.Enumerator enumerator = ((List<object>)(object)tabs).GetEnumerator();
			num = (nint)obj2;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj3 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj;
			enumerator2.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj3 = obj4;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22389E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void ChangeTitle()
	{
		object text = ((List<object>)(object)localizationTerms).get_Item(_currentTabIndex);
		TextMeshProExtensions.Localize(tabTitle, (string)text);
	}

	private void DoTabFunction()
	{
		if (onTabChange != null)
		{
			onTabChange.Invoke(_currentTabIndex);
		}
	}
}
