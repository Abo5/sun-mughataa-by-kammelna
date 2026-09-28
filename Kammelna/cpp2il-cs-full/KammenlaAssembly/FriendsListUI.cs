using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using ListView;
using TMPro;
using UI.UI_Themeing;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;

public class FriendsListUI : MonoBehaviour
{
	private enum FriendType
	{
		All,
		Friend,
		Online,
		SentRequest,
		ReceivedRequest,
		Blocked,
		Offline,
		OnlineAvailability
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<IListViewItemData<int>, bool> <>9__16_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 3248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <UpdateUI>b__16_1(IListViewItemData<int> d)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			if (d != null)
			{
				object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1424;
				object obj2 = (object)d - obj;
				return obj2 == null;
			}
			return false;
		}
	}

	private Action<FriendProfile> m_OnItemSelected;

	private FriendType type;

	private FriendsListView list;

	private GameObject placeholder;

	private UiToggler emptyStateToggler;

	private TextMeshProUGUI counter;

	private InputFieldTMProUGUI filterInput;

	private FriendsListSorter listSorter;

	private bool showHeaders;

	public event Action<FriendProfile> OnItemSelected
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2024;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2024;
			object obj2 = this + 32;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0166: Expected O, but got I
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01a6: Expected I, but got O
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0117: Expected O, but got I
		//IL_0125: Expected I, but got O
		//IL_01d5: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		this.list.SetData((IEnumerable<FriendProfile>)list);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v7+E4]");
		Action<string> action2;
		if ((nint)0 != 0)
		{
			bool flag = filterInput;
			bool flag2 = !flag;
			object obj4 = !flag2;
			Action<string> action = null;
			if (obj4 != null)
			{
				goto IL_00ed;
			}
			action2 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = filterInput;
			bool flag4 = !flag3;
			Action<string> action = null;
			action2 = null;
			if (!flag4)
			{
				goto IL_00ed;
			}
		}
		goto IL_0146;
		IL_0146:
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)2784;
		object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj6);
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.OnFriendListUpdated += action3;
		UpdateUI();
		ITrackEvent trackEvent = TrackerLibrary.FriendsCenterViewed();
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v9+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_00ed:
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)2768;
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj13);
		filterInput.OnValueChanged += action4;
		action2 = action4;
		goto IL_0146;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2784;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			FriendsManager.OnFriendListUpdated -= action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FriendsManager.OnFriendListUpdated -= action;
	}

	private void OnFriendListUpdated()
	{
		UpdateUI();
	}

	private void FilterUpdated(string newVal)
	{
		UpdateUI();
	}

	private void UpdateUI()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0053: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0224: Expected I, but got O
		//IL_057b: Expected O, but got I4
		//IL_0185: Expected O, but got I4
		//IL_018e: Expected O, but got I4
		//IL_02ae: Expected O, but got I
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01ce: Expected O, but got I
		//IL_01dc: Expected I, but got O
		//IL_02e9: Expected O, but got I
		//IL_0256: Expected O, but got I
		//IL_01ed: Expected O, but got I
		//IL_020f: Expected O, but got I4
		//IL_0406: Expected O, but got I4
		//IL_0387: Expected O, but got I4
		//IL_0390: Expected O, but got I4
		//IL_039e: Expected O, but got I4
		//IL_048c: Expected I, but got O
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_044f: Expected O, but got I4
		//IL_045d: Expected O, but got I4
		//IL_05b8: Expected O, but got I
		//IL_05c8: Expected O, but got I
		//IL_05ea: Expected O, but got I4
		//IL_0602: Expected O, but got I
		//IL_06f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fb: Expected O, but got Unknown
		//IL_0725: Expected O, but got I4
		//IL_04ea: Expected O, but got I
		//IL_04fa: Expected O, but got I
		//IL_051c: Expected O, but got I4
		//IL_0632: Expected O, but got I4
		//IL_06a0: Expected I, but got O
		//IL_06b0: Expected O, but got I
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Expected O, but got Unknown
		//IL_07e7: Expected O, but got I
		//IL_07f8: Expected I, but got O
		//IL_0816: Expected O, but got I
		//IL_053a: Expected O, but got I
		//IL_0670: Expected O, but got I4
		//IL_0662: Expected O, but got I
		HidePlaceholder();
		Transform transform = base.transform;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(UsageHint) + 816;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v8+B8]");
		object obj4 = 0;
		transform.localScale = (Vector3)0;
		IEnumerable<FriendProfile> friendsList = GetFriendsList();
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v10+E4]");
		IEnumerable<FriendProfile> enumerable;
		if ((nint)0 != 0)
		{
			bool flag = filterInput;
			bool flag2 = !flag;
			object obj6 = !flag2;
			if (obj6 != null)
			{
				goto IL_010e;
			}
			enumerable = friendsList;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = filterInput;
			bool flag4 = !flag3;
			enumerable = friendsList;
			if (!flag4)
			{
				goto IL_010e;
			}
		}
		goto IL_075d;
		IL_03ac:
		if (type != FriendType.ReceivedRequest)
		{
			return;
		}
		goto IL_06e7;
		IL_06e7:
		object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.MarkRequestSeen();
		return;
		IL_010e:
		string text = filterInput.Text;
		object obj10 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v49+E4]");
		if ((nint)0 != 0)
		{
			bool flag6 = StringsExtensions.IsNullOrEmpty(text);
			bool flag7 = !flag6;
			object obj12 = !flag7;
			object obj13 = 0;
			enumerable = friendsList;
			if (obj12 == null)
			{
				goto IL_01a4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag8 = StringsExtensions.IsNullOrEmpty(text);
			bool flag9 = !flag8;
			object obj13 = 0;
			if (flag9)
			{
				goto IL_01a4;
			}
			enumerable = friendsList;
		}
		goto IL_075d;
		IL_02dd:
		object obj14 = (nint)0 + (nint)2048;
		IEnumerable<object> data = this.list.data;
		UnityEngine.Object obj15;
		UnityEngine.Object obj17;
		if (Enumerable.Any(data))
		{
			obj15 = counter;
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v39+E4]");
			bool flag10 = (nint)0 == 0;
			obj17 = counter;
			if (!flag10)
			{
				goto IL_0363;
			}
		}
		else
		{
			ShowPlaceHolder();
			obj15 = counter;
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v39+E4]");
			bool flag11 = (nint)0 == 0;
			object obj18 = !flag11;
			obj17 = counter;
			if (obj18 != null)
			{
				goto IL_0363;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag12 = obj17 != null;
		bool flag13 = !flag12;
		object obj19 = 0;
		UnityEngine.Object obj20 = null;
		object obj21 = 0;
		if (flag13)
		{
			goto IL_03ac;
		}
		goto IL_046b;
		IL_0610:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v30+E4]");
		bool flag14 = (nint)0 == 0;
		object obj22 = !flag14;
		object obj24;
		object obj25;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj23 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v37+B8]");
			obj25 = 0;
		}
		object obj26 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)848;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj25, (IntPtr)obj27);
		object obj28 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v36+B8]");
		object obj29 = (nint)0 + (nint)8;
		obj29 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj30 = 0;
		Func<object, bool> predicate = func;
		IEnumerable<object> enumerable3;
		IEnumerable<object> enumerable2 = enumerable3;
		goto IL_0798;
		IL_046b:
		FriendsListView friendsListView = this.list;
		TextMeshProUGUI textMeshProUGUI = counter;
		nint num = (nint)friendsListView;
		enumerable2 = friendsListView.data;
		obj24 = typeof(DebugUI.BitField) + 3248;
		object obj31 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v30+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v30+B8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X9_v13+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X9_v13+8]");
			bool flag15 = (nint)0 == 0;
			object obj32 = !flag15;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X9_v13+8]");
				Func<object, bool> func2 = (Func<object, bool>)0;
				enumerable3 = enumerable2;
				goto IL_0610;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj31 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v30+B8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X9_v13+8]");
			Func<object, bool> func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X9_v13+8]");
			bool flag16 = (nint)0 == 0;
			object obj33 = !flag16;
			enumerable3 = enumerable2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X9_v13+8]");
			predicate = (Func<object, bool>)0;
			if (obj33 == null)
			{
				goto IL_0610;
			}
		}
		goto IL_0798;
		IL_01a4:
		object obj34 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj35 = (nint)0 + (nint)2760;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor((object)this, (IntPtr)obj35);
		object obj36 = (nint)0 + (nint)3432;
		object obj37 = obj36;
		IEnumerable<object> enumerable4 = Enumerable.Where(friendsList, func3);
		obj30 = 0;
		enumerable = (IEnumerable<FriendProfile>)enumerable4;
		goto IL_075d;
		IL_0798:
		IEnumerable<object> source = Enumerable.Where(enumerable2, predicate);
		List<object> list = Enumerable.ToList(source);
		int num2 = default(int);
		string text2 = num2.ToString();
		nint num3 = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v28 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		obj19 = 0;
		textMeshProUGUI.text = text2;
		bool flag17 = type != FriendType.ReceivedRequest;
		obj20 = (UnityEngine.Object)(object)text2;
		if (flag17)
		{
			return;
		}
		goto IL_06e7;
		IL_075d:
		FriendsListSorter friendsListSorter = listSorter;
		IEnumerable<FriendProfile> data2;
		FriendsListView friendsListView2;
		if (listSorter != null)
		{
			nint num4 = (nint)friendsListSorter;
			if (showHeaders)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v46 (Il2CppClass<FriendsListSorter>)+190]");
				obj37 = 0;
				IEnumerable<FriendListSection> sortedListWithHeaders = listSorter.GetSortedListWithHeaders(enumerable);
				this.list.SetData(sortedListWithHeaders);
				goto IL_02dd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v46 (Il2CppClass<FriendsListSorter>)+180]");
			obj37 = 0;
			IEnumerable<FriendProfile> sortedList = listSorter.GetSortedList(enumerable);
			data2 = sortedList;
			friendsListView2 = this.list;
		}
		else
		{
			friendsListView2 = this.list;
			data2 = enumerable;
		}
		friendsListView2.SetData(data2);
		goto IL_02dd;
		IL_0363:
		bool flag18 = obj15 != null;
		bool flag19 = !flag18;
		object obj38 = !flag19;
		obj19 = 0;
		obj20 = null;
		obj21 = 0;
		if (obj38 == null)
		{
			goto IL_03ac;
		}
		goto IL_046b;
	}

	private void ShowPlaceHolder()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0173: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0217: Expected O, but got I4
		//IL_026a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6194]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = placeholder;
			obj6 = placeholder;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = placeholder;
			obj6 = placeholder;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		bool flag5 = false;
		if (flag4)
		{
			goto IL_00cb;
		}
		goto IL_01d3;
		IL_0132:
		emptyStateToggler.ToggleManual(isON: true);
		return;
		IL_010c:
		UnityEngine.Object obj8;
		if ((bool)obj8)
		{
			goto IL_0132;
		}
		return;
		IL_0238:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj9;
		bool flag6 = obj9;
		bool flag7 = !flag6;
		object obj10 = !flag7;
		if (obj10 == null)
		{
			return;
		}
		goto IL_0132;
		IL_0091:
		bool flag8 = obj5;
		bool flag9 = !flag8;
		object obj11 = !flag9;
		flag5 = false;
		if (obj11 == null)
		{
			goto IL_00cb;
		}
		goto IL_01d3;
		IL_01d3:
		placeholder.SetActive(value: true);
		obj8 = emptyStateToggler;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v4+E4]");
		bool flag10 = (nint)0 == 0;
		object obj13 = !flag10;
		flag5 = true;
		obj9 = emptyStateToggler;
		if (obj13 != null)
		{
			goto IL_010c;
		}
		goto IL_0238;
		IL_00cb:
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v4+E4]");
		bool flag11 = (nint)0 == 0;
		obj8 = emptyStateToggler;
		obj9 = emptyStateToggler;
		if (!flag11)
		{
			goto IL_010c;
		}
		goto IL_0238;
	}

	private void HidePlaceholder()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0173: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0217: Expected O, but got I4
		//IL_026a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6195]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = placeholder;
			obj6 = placeholder;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = placeholder;
			obj6 = placeholder;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		bool flag5 = false;
		if (flag4)
		{
			goto IL_00cb;
		}
		goto IL_01d3;
		IL_0132:
		emptyStateToggler.ToggleManual(isON: false);
		return;
		IL_010c:
		UnityEngine.Object obj8;
		if ((bool)obj8)
		{
			goto IL_0132;
		}
		return;
		IL_0238:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj9;
		bool flag6 = obj9;
		bool flag7 = !flag6;
		object obj10 = !flag7;
		if (obj10 == null)
		{
			return;
		}
		goto IL_0132;
		IL_0091:
		bool flag8 = obj5;
		bool flag9 = !flag8;
		object obj11 = !flag9;
		flag5 = false;
		if (obj11 == null)
		{
			goto IL_00cb;
		}
		goto IL_01d3;
		IL_01d3:
		placeholder.SetActive(value: false);
		obj8 = emptyStateToggler;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v4+E4]");
		bool flag10 = (nint)0 == 0;
		object obj13 = !flag10;
		flag5 = false;
		obj9 = emptyStateToggler;
		if (obj13 != null)
		{
			goto IL_010c;
		}
		goto IL_0238;
		IL_00cb:
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v4+E4]");
		bool flag11 = (nint)0 == 0;
		obj8 = emptyStateToggler;
		obj9 = emptyStateToggler;
		if (!flag11)
		{
			goto IL_010c;
		}
		goto IL_0238;
	}

	private IEnumerable<FriendProfile> GetFriendsList()
	{
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0280: Expected O, but got I4
		//IL_0522: Expected O, but got I
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_04d3: Expected O, but got I
		if (type > FriendType.Online)
		{
			if (type <= FriendType.ReceivedRequest)
			{
				if (type == FriendType.SentRequest)
				{
					object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v46+E4]");
					if ((nint)0 != 0)
					{
						return FriendsManager.SentRequests;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					return FriendsManager.SentRequests;
				}
				if (type == FriendType.ReceivedRequest)
				{
					object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v50+E4]");
					if ((nint)0 != 0)
					{
						return FriendsManager.ReceivedRequests;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					return FriendsManager.ReceivedRequests;
				}
			}
			else
			{
				if (type == FriendType.Blocked)
				{
					object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v38+E4]");
					if ((nint)0 != 0)
					{
						return FriendsManager.BlockedList;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					return FriendsManager.BlockedList;
				}
				if (type == FriendType.Offline)
				{
					object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v42+E4]");
					if ((nint)0 != 0)
					{
						return FriendsManager.OfflineFriendsList;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					return FriendsManager.OfflineFriendsList;
				}
			}
		}
		else
		{
			if (type == FriendType.All)
			{
				object obj9 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v26+E4]");
				bool flag = (nint)0 == 0;
				object obj11 = !flag;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v26+B8]");
				return (IEnumerable<FriendProfile>)0;
			}
			if (type == FriendType.Friend)
			{
				object obj12 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v30+E4]");
				if ((nint)0 != 0)
				{
					return FriendsManager.FriendsList;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return FriendsManager.FriendsList;
			}
			if (type == FriendType.Online)
			{
				object obj14 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v34+E4]");
				if ((nint)0 != 0)
				{
					return FriendsManager.OnlineFriendsList;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return FriendsManager.OnlineFriendsList;
			}
		}
		object obj16 = typeof(DebugUI.BitField) + 3256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj17 = "{0} color encoding is currently unsupported for outputting to HDR." + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		string format = default(string);
		object arg = default(object);
		string message = string.Format(format, arg);
		object obj18 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = "tournament_participate_warning_body_with_tickets_warning_daily" + 968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, message);
		object obj20 = (nint)0 + (nint)2776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (IEnumerable<FriendProfile>)new OutOfMemoryException();
	}

	public void SelectItem(FriendProfile friendProfile)
	{
		//IL_0039: Expected O, but got I
		//IL_0049: Expected O, but got I
		//IL_0059: Expected O, but got I
		Action<FriendProfile> onItemSelected = this.OnItemSelected;
		if (this.OnItemSelected != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<FriendProfile>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<FriendProfile>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (System.Action`1<FriendProfile>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	private bool <UpdateUI>b__16_0(FriendProfile friend)
	{
		//IL_00b7: Expected I4, but got O
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0071: Expected O, but got I4
		if (friend != null && (object)filterInput != null)
		{
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			string text = filterInput.Text;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return StringsExtensions.ContainsIgnoreCase(friend.UserName, text);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
