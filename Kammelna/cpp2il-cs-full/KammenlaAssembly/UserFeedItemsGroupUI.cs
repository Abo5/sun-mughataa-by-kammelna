using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DataTracking;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Server.Models;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.UI;
using UnityEngine.Purchasing.Telemetry;

public class UserFeedItemsGroupUI : BaseUserFeedItemUI
{
	private sealed class <>c__DisplayClass9_0
	{
		public UserFeedItem feedItem;

		internal bool <OnDismissFeed>b__0(UserFeedItem f)
		{
			object obj = (object)f - (object)feedItem;
			bool flag = obj == null;
			return !flag;
		}
	}

	private TextMeshProUGUI countText;

	private GameObject[] layers;

	private ComponentReference<GroupUserFeedsPopup> groupPopup;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3952;
		object obj2 = (nint)0 + (nint)3992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		eventsChannel.OnDismissFeed += action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3952;
		object obj2 = (nint)0 + (nint)3992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		eventsChannel.OnDismissFeed -= action;
	}

	protected override void OnPopulated()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected I4, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected I4, but got Unknown
		//IL_011a: Expected O, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_014e: Expected O, but got I4
		object obj = "&action=sign-up" + 3352;
		button.interactable = true;
		int num = Enumerable.Count((IEnumerable<object>)_feedItems);
		int num2 = default(int);
		string text = num2.ToString();
		string text2 = (string)obj + text;
		countText.text = text2;
		GameObject[] array = layers;
		object obj2 = 0;
		while ((nint)obj2 < array.Length)
		{
			object obj3 = (object)array + obj2;
			object obj4 = obj2 - num2;
			bool flag = (nint)obj4 < 0;
			int num3 = obj2 ^ num2;
			object obj5 = obj2 ^ obj4;
			int num4 = num3 & obj5;
			bool flag2 = num4 < 0;
			bool flag3 = flag == flag2;
			bool active = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v9+20]");
			((GameObject)0).SetActive(active);
			array = layers;
			obj2++;
			bool flag4 = layers == null;
			object obj6 = !flag4;
			if (obj6 == null)
			{
				throw new NullReferenceException();
			}
		}
	}

	protected override void ShowPreview()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I
		//IL_00fb: Expected I, but got O
		//IL_0125: Expected O, but got I4
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2192;
		object obj2 = (nint)0 + (nint)3976;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		object obj7 = Enumerable.First((IEnumerable<object>)_feedItems);
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v8 (System.Object)+18]");
		ITrackEvent trackEvent = TrackerLibrary.UserFeedGroupClicked(UserFeedType.CustomMessage);
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
	}

	protected override void UpdateSeenStatus()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003f: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3952;
		object obj2 = (nint)0 + (nint)3984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		ArraysExtensions.ForEach(_feedItems, action);
	}

	protected override void OnDismissFeed()
	{
		//IL_0009: Expected O, but got I4
		//IL_0015: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0287: Expected O, but got I
		//IL_02a9: Expected O, but got I4
		//IL_00c0: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0103: Expected O, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0073: Expected O, but got I
		//IL_0399: Expected O, but got I4
		//IL_02e9: Expected O, but got I
		//IL_02f9: Expected O, but got I
		//IL_030f: Expected O, but got I
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_0337: Expected O, but got I4
		//IL_035f: Expected O, but got I
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0186: Expected O, but got I
		//IL_0197: Expected O, but got I
		//IL_01a7: Expected O, but got I
		//IL_01bd: Expected O, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01e5: Expected O, but got I4
		//IL_0212: Expected O, but got I
		//IL_0243: Expected I, but got O
		object obj = 152985600;
		object obj2 = (nint)0 + (nint)3864;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6350]");
		object obj3 = (nint)0 & (nint)1;
		IEnumerable<object> enumerable;
		object obj7;
		object obj8;
		IEnumerable<object> enumerable2;
		object obj4;
		object obj5;
		if (obj3 != null)
		{
			obj4 = this + 128;
			enumerable = (IEnumerable<object>)obj4;
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X22_v7+38]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X22_v7+38]");
			bool flag = (nint)0 == 0;
			obj7 = obj4;
			obj8 = obj5;
			enumerable2 = (IEnumerable<object>)obj4;
			if (!flag)
			{
				goto IL_00b0;
			}
		}
		else
		{
			_ = 1;
			obj4 = this + 128;
			enumerable = (IEnumerable<object>)obj4;
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X22_v7+38]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X22_v7+38]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			obj7 = obj4;
			obj8 = obj5;
			enumerable2 = (IEnumerable<object>)obj4;
			if (obj9 != null)
			{
				goto IL_00b0;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X22_v3+38]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+10]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+10]");
		object obj12 = (nint)0 + (nint)309;
		object obj13 = obj12 & 1;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		obj4 = obj7;
		obj5 = obj8;
		enumerable = enumerable2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+10]");
		object obj15 = 0;
		if (obj14 != null)
		{
			goto IL_0129;
		}
		goto IL_036d;
		IL_0166:
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3952;
		object obj17 = (nint)0 + (nint)3968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X22_v7+38]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v12+10]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v12+10]");
		object obj20 = (nint)0 + (nint)309;
		object obj21 = obj20 & 1;
		bool flag4 = obj21 == null;
		object obj22 = !flag4;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v23+B8]");
		object feedItems = 0;
		_feedItems = (IEnumerable<UserFeedItem>)feedItems;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj17);
		ArraysExtensions.ForEach(enumerable, action);
		return;
		IL_03bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj7;
		obj5 = obj8;
		enumerable = enumerable2;
		goto IL_0166;
		IL_0129:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v1+E4]");
		bool flag5 = (nint)0 == 0;
		obj7 = obj4;
		obj8 = obj5;
		enumerable2 = enumerable;
		if (!flag5)
		{
			goto IL_0166;
		}
		goto IL_03bf;
		IL_00b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v18+10]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v18+10]");
		object obj23 = (nint)0 + (nint)309;
		object obj24 = obj23 & 1;
		bool flag6 = obj24 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v18+10]");
		obj15 = 0;
		obj7 = obj4;
		obj8 = obj5;
		enumerable2 = enumerable;
		if (!flag6)
		{
			goto IL_0129;
		}
		goto IL_036d;
		IL_036d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj25 = !flag7;
		obj4 = obj7;
		obj5 = obj8;
		enumerable = enumerable2;
		if (obj25 != null)
		{
			goto IL_0166;
		}
		goto IL_03bf;
	}

	private void OnDismissFeed(UserFeedItem feedItem)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00a0: Expected I, but got O
		//IL_00ea: Expected O, but got I
		//IL_0137: Expected O, but got I4
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected I4, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected I4, but got Unknown
		//IL_01ce: Expected O, but got I
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_0202: Expected O, but got I4
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 1488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 96;
		object obj4 = (nint)0 + (nint)2208;
		object obj5 = (nint)0 + (nint)3856;
		object obj6 = "&action=sign-up" + 3352;
		object obj7 = obj2 + 16;
		obj7 = feedItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object source = this + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj4);
		IEnumerable<object> enumerable = Enumerable.Where((IEnumerable<object>)source, func);
		source = enumerable;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = Enumerable.Count((IEnumerable<object>)source);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X20_v6+10]");
		object obj8 = 0;
		int num2 = default(int);
		string text = num2.ToString();
		string text2 = (string)obj6 + text;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v233 @ X8_v6+558] (should have been resolved before IL gen)");
		GameObject[] array = layers;
		object obj10 = 0;
		while ((nint)obj10 < array.Length)
		{
			object obj11 = (object)array + obj10;
			object obj12 = obj10 - num2;
			bool flag = (nint)obj12 < 0;
			int num3 = obj10 ^ num2;
			object obj13 = obj10 ^ obj12;
			int num4 = num3 & obj13;
			bool flag2 = num4 < 0;
			bool flag3 = flag == flag2;
			bool active = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+20]");
			((GameObject)0).SetActive(active);
			array = layers;
			obj10++;
			bool flag4 = layers == null;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				throw new NullReferenceException();
			}
		}
	}

	private void <ShowPreview>b__6_0(GroupUserFeedsPopup popup)
	{
		popup.Show(_feedItems);
	}

	private void <UpdateSeenStatus>b__7_0(UserFeedItem feed)
	{
		eventsChannel.TriggerMarkFeedSeen(feed);
	}

	private void <OnDismissFeed>b__8_0(UserFeedItem feed)
	{
		eventsChannel.TriggerDismissFeed(feed);
	}
}
