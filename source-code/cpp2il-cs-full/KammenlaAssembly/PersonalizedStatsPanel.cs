using System;
using System.Collections.Generic;
using System.Data;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UI;
using Util;

public class PersonalizedStatsPanel : MonoBehaviour
{
	private const string StatsPanelTitle = "stats_panel_title";

	private RectTransform stripsContainer;

	private List<PersonalizedStatsStrip> strips;

	private PopupUI popup;

	private TextMeshProUGUI titleLabel;

	private PersonalizedStatReport testReport;

	public void OnStatReportReceived(PersonalizedStatReport report, Dictionary<PerformanceReportType, PersonalReportTypeConfig> configs = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0227: Expected O, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_00d2: Expected I, but got O
		//IL_00e2: Expected O, but got I
		//IL_010b: Expected O, but got I
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag = report == null;
		PersonalizedStatReport personalizedStatReport = (PersonalizedStatReport)1;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			object obj2 = typeof(DataRelation) + 824;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string monthName = DateTimeUtil.GetMonthName(report.<Date>k__BackingField);
			object[] array = default(object[]);
			bool flag3 = array == null;
			personalizedStatReport = null;
			if (!flag3)
			{
				bool flag4 = monthName == null;
				PersonalizedStatReport personalizedStatReport2 = null;
				if (!flag4)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
					personalizedStatReport2 = (PersonalizedStatReport)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag5 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v11 (Il2CppClass<System.Object[]>)+40]");
					personalizedStatReport = (PersonalizedStatReport)0;
					if (flag5)
					{
						goto IL_01ef;
					}
				}
				bool flag6 = array.Length == 0;
				personalizedStatReport = personalizedStatReport2;
				if (flag6)
				{
					goto IL_01e1;
				}
				object text = "startPosition" + 176;
				object obj5 = array + 32;
				obj5 = monthName;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				TextMeshProExtensions.LocalizeArguments(titleLabel, (string)text, array);
				Dictionary<PerformanceReportType, PersonalReportTypeConfig> configs2 = default(Dictionary<PerformanceReportType, PersonalReportTypeConfig>);
				InitializeStrips(report, configs2);
				bool flag7 = (object)popup == null;
				personalizedStatReport = report;
				if (!flag7)
				{
					popup.PopFromCenter();
					RebuildLayout();
					return;
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_01e1;
		IL_01ef:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_01e1:
		ex = new IndexOutOfRangeException();
		goto IL_01ef;
	}

	private void InitializeStrips(PersonalizedStatReport report, Dictionary<PerformanceReportType, PersonalReportTypeConfig> configs)
	{
		//IL_0208: Expected O, but got I4
		//IL_0132: Expected O, but got I4
		List<object> stats = (List<object>)(object)report.Stats;
		if (configs != null)
		{
			int num = 0;
			object obj3;
			do
			{
				if (num < stats._size)
				{
					List<PersonalizedStatsStrip> list = strips;
					if (num < list._size)
					{
						object obj = stats.get_Item(num);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v14 (System.Object)+10]");
						object value;
						bool flag = ((Dictionary<System.Int32Enum, object>)(object)configs).TryGetValue((System.Int32Enum)0, out value);
						object obj2 = ((List<object>)(object)strips).get_Item(num);
						object stat = ((List<object>)(object)report.Stats).get_Item(num);
						((PersonalizedStatsStrip)obj2).Initialize((PersonalizedStat)stat, report.<ReportType>k__BackingField, (PersonalReportTypeConfig)value);
						num++;
						stats = (List<object>)(object)report.Stats;
						bool flag2 = report.Stats == null;
						obj3 = !flag2;
						continue;
					}
					return;
				}
				return;
			}
			while (obj3 != null);
		}
		else
		{
			int num2 = 0;
			object obj5;
			do
			{
				if (num2 < stats._size)
				{
					List<object> list2 = (List<object>)(object)strips;
					if (num2 < list2._size)
					{
						object obj4 = list2.get_Item(num2);
						object stat2 = ((List<object>)(object)report.Stats).get_Item(num2);
						((PersonalizedStatsStrip)obj4).Initialize((PersonalizedStat)stat2, report.<ReportType>k__BackingField, (PersonalReportTypeConfig)null);
						num2++;
						stats = (List<object>)(object)report.Stats;
						bool flag3 = report.Stats == null;
						obj5 = !flag3;
						continue;
					}
					return;
				}
				return;
			}
			while (obj5 != null);
		}
		throw new NullReferenceException();
	}

	private void RebuildLayout()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_022b: Expected O, but got I4
		//IL_0234: Expected O, but got I4
		//IL_023d: Expected O, but got I4
		//IL_0246: Expected O, but got I4
		//IL_024f: Expected O, but got I4
		//IL_00de: Expected I, but got O
		//IL_0082: Expected O, but got I4
		//IL_008b: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_00f9: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_0111: Expected O, but got I
		//IL_02a5: Expected O, but got I4
		//IL_02b2: Expected I, but got O
		//IL_0139: Expected I, but got O
		//IL_017b: Expected O, but got I4
		//IL_0336: Expected I, but got O
		//IL_01c5: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1648;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6440]");
		object obj3 = (nint)0 & (nint)1;
		RectTransform rectTransform;
		object obj5;
		object obj6;
		RectTransform rectTransform2;
		List<object>.Enumerator enumerator;
		if (obj3 != null)
		{
			rectTransform = stripsContainer;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			enumerator = (List<object>.Enumerator)0;
			obj6 = 0;
			enumerator = (List<object>.Enumerator)0;
			rectTransform2 = stripsContainer;
			if (!flag)
			{
				goto IL_00b5;
			}
		}
		else
		{
			_ = 1;
			rectTransform = stripsContainer;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = 0;
			enumerator = (List<object>.Enumerator)0;
			obj6 = 0;
			enumerator = (List<object>.Enumerator)0;
			rectTransform2 = stripsContainer;
			if (obj7 != null)
			{
				goto IL_00b5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		LayoutRebuilder.ForceRebuildLayoutImmediate(rectTransform2);
		List<object> list = (List<object>)(object)strips;
		bool flag3 = strips == null;
		object obj8 = !flag3;
		obj5 = obj6;
		nint num = unchecked((nint)null);
		rectTransform = rectTransform2;
		if (obj8 != null)
		{
			goto IL_00ec;
		}
		goto IL_02c8;
		IL_02de:
		NullReferenceException ex = new NullReferenceException();
		bool flag4 = num != 1;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		List<object>.Enumerator enumerator2;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)rectTransform;
			enumerator2.Dispose();
			object obj9 = default(object);
			if (obj9 == null)
			{
				return;
			}
			ex2 = new OutOfMemoryException();
			object obj10 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237F6C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00ec:
		object obj11 = (nint)0 + (nint)4048;
		object obj12 = (nint)0 + (nint)4040;
		rectTransform = (RectTransform)((nint)0 + (nint)4040);
		List<object>.Enumerator enumerator3 = list.GetEnumerator();
		RectTransform layoutRoot = default(RectTransform);
		while (true)
		{
			num = (nint)obj11;
			if (enumerator.MoveNext())
			{
				bool flag5 = obj5 == null;
				object obj10 = 0;
				enumerator2 = enumerator;
				if (flag5)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				object obj13 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v48+E4]");
				bool flag6 = (nint)0 == 0;
				object obj14 = !flag6;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				LayoutRebuilder.ForceRebuildLayoutImmediate(layoutRoot);
				continue;
			}
			enumerator.Dispose();
			return;
		}
		goto IL_02de;
		IL_02c8:
		NullReferenceException ex3 = new NullReferenceException();
		enumerator2 = enumerator;
		goto IL_02de;
		IL_00b5:
		LayoutRebuilder.ForceRebuildLayoutImmediate(rectTransform);
		list = (List<object>)(object)strips;
		bool flag7 = strips == null;
		num = unchecked((nint)null);
		if (!flag7)
		{
			goto IL_00ec;
		}
		goto IL_02c8;
	}
}
