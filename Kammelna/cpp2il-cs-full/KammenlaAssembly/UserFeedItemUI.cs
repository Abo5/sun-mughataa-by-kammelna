using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using DataTracking;
using Server.Models;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class UserFeedItemUI : BaseUserFeedItemUI
{
	private UserFeedItem FeedItem => (UserFeedItem)Enumerable.First((IEnumerable<object>)_feedItems);

	protected override void ShowPreview()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_003f: Expected O, but got I
		//IL_006b: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3960;
		object obj3 = (nint)0 + (nint)40;
		object obj4 = Enumerable.First((IEnumerable<object>)_feedItems);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		((UserFeedItem)obj4).ShowPreview(action);
	}

	protected override void UpdateSeenStatus()
	{
		//IL_003e: Expected O, but got I4
		//IL_005a: Expected O, but got I
		//IL_008e: Expected O, but got I
		//IL_00a8: Expected O, but got I4
		GameObject gameObject = base.gameObject;
		if (!gameObject.activeInHierarchy)
		{
			return;
		}
		object obj = 152985600;
		object obj2 = Enumerable.First((IEnumerable<object>)_feedItems);
		if (obj2 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v8 (System.Object)+38]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X22_v4+3BD]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 == null)
			{
				_ = 1;
			}
			object userFeed = Enumerable.First((IEnumerable<object>)_feedItems);
			eventsChannel.TriggerMarkFeedSeen((UserFeedItem)userFeed);
		}
	}

	protected override void OnDismissFeed()
	{
		//IL_029b: Expected O, but got I
		//IL_02a7: Expected O, but got I
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02dc: Expected O, but got I
		//IL_0169: Expected O, but got I
		//IL_0179: Expected O, but got I
		//IL_018f: Expected O, but got I
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01b7: Expected O, but got I4
		//IL_01c7: Expected O, but got I
		//IL_0015: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0058: Expected O, but got I
		//IL_0229: Expected O, but got I
		//IL_0239: Expected O, but got I
		//IL_024f: Expected O, but got I
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_0201: Expected O, but got I4
		//IL_009b: Expected O, but got I
		//IL_00ab: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I4
		//IL_00f9: Expected O, but got I
		//IL_0126: Expected O, but got I
		//IL_028a: Expected O, but got I
		object obj = (nint)0 + (nint)3864;
		object obj2 = (nint)0 + (nint)40;
		object source = this + 128;
		object userFeed = Enumerable.First((IEnumerable<object>)source);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X22_v3+38]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X22_v3+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+10]");
			object obj6 = (nint)0 + (nint)309;
			object obj7 = obj6 & 1;
			bool flag = obj7 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v5+10]");
			object obj8 = 0;
			if (!flag)
			{
				goto IL_0066;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X22_v3+38]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v12+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v12+10]");
			object obj10 = (nint)0 + (nint)309;
			object obj11 = obj10 & 1;
			bool flag2 = obj11 == null;
			object obj12 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v12+10]");
			object obj8 = 0;
			if (obj12 != null)
			{
				goto IL_0066;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 != null)
		{
			goto IL_008b;
		}
		goto IL_020f;
		IL_0107:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0116;
		IL_008b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X22_v3+38]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v19+10]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v19+10]");
		object obj16 = (nint)0 + (nint)309;
		object obj17 = obj16 & 1;
		bool flag4 = obj17 == null;
		object obj18 = !flag4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v19+10]");
		object obj19 = 0;
		if (obj18 == null)
		{
			goto IL_0107;
		}
		goto IL_0116;
		IL_0116:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v13+B8]");
		object feedItems = 0;
		_feedItems = (IEnumerable<UserFeedItem>)feedItems;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		eventsChannel.TriggerDismissFeed((UserFeedItem)userFeed);
		return;
		IL_0066:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			goto IL_008b;
		}
		goto IL_020f;
		IL_020f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X22_v3+38]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v7+10]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v7+10]");
		object obj21 = (nint)0 + (nint)309;
		object obj22 = obj21 & 1;
		if (obj22 == null)
		{
			goto IL_0107;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v7+10]");
		obj19 = 0;
		goto IL_0116;
	}

	private void <ShowPreview>b__2_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00ef: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_011f: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_0068: Expected O, but got I
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		object obj = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63C0]");
		object obj2 = (nint)0 & (nint)1;
		UserFeedEventsChannel userFeedEventsChannel;
		object obj5;
		UserFeedEventsChannel userFeedEventsChannel2;
		object obj3;
		if (obj2 != null)
		{
			userFeedEventsChannel = eventsChannel;
			obj3 = (nint)0 + (nint)40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63BD]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			userFeedEventsChannel2 = eventsChannel;
			if (!flag)
			{
				goto IL_0097;
			}
		}
		else
		{
			_ = 1;
			userFeedEventsChannel = eventsChannel;
			obj3 = (nint)0 + (nint)40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63BD]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			userFeedEventsChannel2 = eventsChannel;
			if (obj7 != null)
			{
				goto IL_0097;
			}
		}
		_ = 1;
		object userFeed = Enumerable.First((IEnumerable<object>)_feedItems);
		obj3 = obj5;
		userFeedEventsChannel = userFeedEventsChannel2;
		goto IL_016e;
		IL_016e:
		userFeedEventsChannel.TriggerMarkFeedSeen((UserFeedItem)userFeed);
		object obj8 = Enumerable.First((IEnumerable<object>)_feedItems);
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v7 (System.Object)+18]");
		ITrackEvent trackEvent = TrackerLibrary.UserFeedClicked(UserFeedType.CustomMessage);
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_0097:
		userFeed = Enumerable.First((IEnumerable<object>)_feedItems);
		bool flag3 = (object)userFeedEventsChannel == null;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_016e;
	}
}
