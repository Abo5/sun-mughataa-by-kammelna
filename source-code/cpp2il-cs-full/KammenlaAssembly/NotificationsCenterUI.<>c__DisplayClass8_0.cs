using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class NotificationsCenterUI : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Notification, DateTime> <>9__8_0;

		public static Func<Notification, int> <>9__8_1;

		public static Action<NotificationItem> <>9__10_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal DateTime <OnNotificationsReceived>b__8_0(Notification n)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_00cc: Expected O, but got I
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			//IL_009f: Expected O, but got I
			if (n != null)
			{
				object obj = (??)n.<startDate>k__BackingField & 1;
				if (obj != null)
				{
					return (DateTime)(n + 72);
				}
				object obj2 = typeof(DataRelation) + 712;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+B8]");
					return (DateTime)((nint)0 + (nint)32);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v5+B8]");
				return (DateTime)((nint)0 + (nint)32);
			}
			return (DateTime)new NullReferenceException();
		}

		internal int <OnNotificationsReceived>b__8_1(Notification n)
		{
			//IL_0035: Expected I4, but got O
			if (n != null)
			{
				return n.<id>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void <ShowAll>b__10_0(NotificationItem n)
		{
			GameObject gameObject = n.gameObject;
			gameObject.SetActive(value: true);
		}
	}

	private sealed class <>c__DisplayClass8_0
	{
		public NotificationsCenterUI <>4__this;

		public int i;

		public Func<Notification, bool> <>9__3;

		internal bool <OnNotificationsReceived>b__3(Notification n)
		{
			//IL_00c2: Expected I4, but got O
			//IL_00a0: Expected O, but got I
			if (n != null)
			{
				NotificationsCenterUI notificationsCenterUI = <>4__this;
				if ((object)<>4__this != null && notificationsCenterUI.shownNotifications != null)
				{
					object obj = ((List<object>)(object)notificationsCenterUI.shownNotifications).get_Item(i);
					if (obj != null)
					{
						int <id>k__BackingField = n.<id>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5 (System.Object)+10]");
						object obj2 = (nint)<id>k__BackingField - (nint)0;
						return obj2 == null;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass8_1
	{
		public Notification notification;

		internal bool <OnNotificationsReceived>b__2(Notification shown)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (shown != null)
			{
				Notification notification = this.notification;
				if (this.notification != null)
				{
					object obj = shown.<id>k__BackingField - notification.<id>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public NotificationItem item;

		public NotificationsCenterUI <>4__this;

		internal void <HideAllBut>b__0()
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_0069: Expected O, but got I
			//IL_0077: Expected O, but got I4
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			//IL_00a6: Expected O, but got I
			//IL_00be: Expected I, but got O
			Transform transform = item.transform;
			Transform parent = transform.parent;
			RectTransform rectTransform = UIExtensions.rectTransform(parent);
			object obj = typeof(UsageHint) + 744;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v8+B8]");
			object obj3 = 0;
			rectTransform.anchoredPosition = (Vector2)0;
			NotificationsCenterUI notificationsCenterUI = <>4__this;
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2840;
			object obj5 = (nint)0 + (nint)1952;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action = default(Action<object>);
			action..ctor((object)null, (IntPtr)obj5);
			((List<object>)(object)notificationsCenterUI.items).ForEach(action);
			GameObject gameObject = item.gameObject;
			gameObject.SetActive(value: true);
		}
	}

	private RectTransform itemsList;

	private GameObject notificationItemPrefab;

	private GameObject placeholder;

	private readonly List<Notification> shownNotifications;

	private readonly List<NotificationItem> items;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_00fc: Expected I, but got O
		//IL_0126: Expected O, but got I4
		//IL_0054: Expected O, but got I
		//IL_0087: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 848;
		object obj2 = (nint)0 + (nint)3568;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2704;
		object obj4 = typeof(Queue<string>) + 792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = (nint)0 + (nint)2104;
		NotificationsManager.OnNotificationsReceived += action;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		NotificationsManager notificationsManager = default(NotificationsManager);
		List<Notification> activeNotifications = notificationsManager.ActiveNotifications;
		OnNotificationsReceived(activeNotifications);
	}

	private void OnEnable()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00d6: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E633C]");
		object obj3 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj3 != null)
		{
			trackEvent = TrackerLibrary.NotificationCenterViewed();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			trackEvent2 = trackEvent;
			if (!flag)
			{
				goto IL_008e;
			}
		}
		else
		{
			_ = 1;
			trackEvent = TrackerLibrary.NotificationCenterViewed();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			trackEvent2 = trackEvent;
			if (obj5 != null)
			{
				goto IL_008e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_008e:
		Tracker.DesignEvent(trackEvent);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 848;
		object obj2 = (nint)0 + (nint)3568;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NotificationsManager.OnNotificationsReceived -= action;
	}

	private void OnNotificationsReceived(List<Notification> notifications)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_1101: Expected O, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_0140: Expected O, but got I4
		//IL_0fd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd8: Expected O, but got Unknown
		//IL_0fe4: Expected O, but got I
		//IL_0ff0: Expected O, but got I
		//IL_0ffc: Expected O, but got I
		//IL_1008: Expected O, but got I
		//IL_01f8: Expected O, but got I4
		//IL_0083: Expected O, but got I
		//IL_0093: Expected O, but got I
		//IL_00a3: Expected O, but got I
		//IL_00c5: Expected O, but got I4
		//IL_11b5: Expected O, but got I
		//IL_11c1: Expected O, but got I
		//IL_11d1: Expected O, but got I
		//IL_11e1: Expected O, but got I
		//IL_1203: Expected O, but got I4
		//IL_0166: Expected O, but got I
		//IL_0188: Expected O, but got I4
		//IL_028c: Expected I, but got O
		//IL_02a5: Expected I4, but got O
		//IL_112f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1134: Expected O, but got Unknown
		//IL_114a: Expected O, but got I
		//IL_115b: Expected I, but got O
		//IL_1179: Expected O, but got I
		//IL_1194: Expected O, but got I4
		//IL_1055: Expected O, but got I
		//IL_105d: Expected I4, but got O
		//IL_02d0: Expected O, but got I4
		//IL_022d: Expected O, but got I
		//IL_024f: Expected O, but got I4
		//IL_01b8: Expected O, but got I
		//IL_1220: Unknown result type (might be due to invalid IL or missing references)
		//IL_1225: Expected O, but got Unknown
		//IL_123b: Expected O, but got I
		//IL_124c: Expected I, but got O
		//IL_126a: Expected O, but got I
		//IL_1285: Expected O, but got I4
		//IL_02f3: Expected O, but got I
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0313: Expected O, but got I
		//IL_031f: Expected O, but got I
		//IL_027f: Expected O, but got I
		//IL_12ca: Expected O, but got I4
		//IL_09a8: Expected O, but got I
		//IL_09b0: Expected I4, but got O
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected O, but got Unknown
		//IL_09d9: Expected O, but got I
		//IL_09e5: Expected O, but got I
		//IL_09f1: Expected O, but got I
		//IL_09fd: Expected O, but got I
		//IL_0a27: Expected O, but got I4
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_038e: Expected O, but got I4
		//IL_0b11: Expected I, but got O
		//IL_0b24: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b29: Expected O, but got Unknown
		//IL_0b3b: Expected I, but got O
		//IL_0a80: Expected I, but got O
		//IL_0a95: Expected O, but got I
		//IL_0ab3: Expected O, but got I4
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_0b6b: Expected O, but got I4
		//IL_0b74: Expected O, but got I4
		//IL_0b7c: Expected I4, but got O
		//IL_0b85: Expected O, but got I4
		//IL_0b8d: Expected I, but got O
		//IL_0b95: Expected I4, but got O
		//IL_03e5: Expected I, but got O
		//IL_0ae1: Expected I, but got O
		//IL_0d9e: Expected O, but got I4
		//IL_0da7: Expected O, but got I4
		//IL_0daf: Expected I, but got O
		//IL_0db7: Expected I4, but got O
		//IL_040c: Expected I, but got O
		//IL_0431: Expected I4, but got I8
		//IL_044b: Expected O, but got I4
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Expected O, but got Unknown
		//IL_0558: Expected O, but got I4
		//IL_0bf6: Expected O, but got I
		//IL_0bfe: Expected I, but got O
		//IL_0581: Expected O, but got I
		//IL_0589: Expected I, but got O
		//IL_0fa6: Expected O, but got I4
		//IL_0faf: Expected O, but got I4
		//IL_0fb9: Expected I4, but got O
		//IL_0e66: Expected O, but got I4
		//IL_0e6f: Expected O, but got I4
		//IL_0e77: Expected I4, but got O
		//IL_0c5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5f: Expected O, but got Unknown
		//IL_0c89: Expected O, but got I4
		//IL_05bc: Expected O, but got I
		//IL_05c4: Expected I4, but got O
		//IL_0484: Expected O, but got I
		//IL_0f6d: Expected O, but got I4
		//IL_0f76: Expected O, but got I4
		//IL_0ea7: Expected O, but got I4
		//IL_0eaf: Expected I, but got O
		//IL_04ca: Expected O, but got I
		//IL_04d2: Expected I, but got O
		//IL_0cce: Expected I, but got O
		//IL_0e20: Expected O, but got I4
		//IL_0e29: Expected O, but got I4
		//IL_0e2e: Expected I, but got O
		//IL_0e36: Expected I4, but got O
		//IL_0ee7: Expected O, but got I4
		//IL_062e: Expected O, but got I
		//IL_0515: Expected I, but got O
		//IL_0d24: Expected I, but got O
		//IL_06a7: Expected O, but got I4
		//IL_072e: Expected O, but got I
		//IL_073e: Expected O, but got I
		//IL_078d: Expected I4, but got O
		//IL_06e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected O, but got Unknown
		//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected O, but got Unknown
		//IL_0711: Expected I, but got O
		//IL_0de7: Expected O, but got I4
		//IL_0df0: Expected O, but got I4
		//IL_07a7: Expected O, but got I
		//IL_0805: Expected I4, but got O
		//IL_0833: Expected O, but got I4
		//IL_08ad: Expected O, but got I
		//IL_08bd: Expected O, but got I
		//IL_08f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f5: Expected O, but got Unknown
		//IL_091f: Expected O, but got I4
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected O, but got Unknown
		//IL_0881: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Expected O, but got Unknown
		//IL_0948: Expected O, but got I
		//IL_0f1f: Expected O, but got I4
		//IL_0f28: Expected O, but got I4
		//IL_0f3d: Expected I4, but got O
		//IL_0985: Expected O, but got I4
		//IL_098a: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		int num = 0;
		List<Notification> list = notifications;
		object obj3;
		object obj7;
		Func<object, DateTime> keySelector;
		object obj9;
		object obj6;
		if (!flag)
		{
			obj3 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1144;
			object obj4 = obj2 + 16;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v111+E4]");
			if ((nint)0 != 0)
			{
				obj6 = (nint)0 + (nint)2440;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v111+B8]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v77+8]");
				keySelector = (Func<object, DateTime>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v77+8]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					obj9 = obj6;
					goto IL_0156;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj3;
				obj9 = (nint)0 + (nint)2440;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v111+B8]");
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v77+8]");
				keySelector = (Func<object, DateTime>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v77+8]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				obj6 = obj9;
				if (obj10 == null)
				{
					goto IL_0156;
				}
			}
			goto IL_01bd;
		}
		goto IL_0d4f;
		IL_0e7c:
		NullReferenceException ex = new NullReferenceException();
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator2 = enumerator3;
		List<object>.Enumerator enumerator4 = enumerator3;
		List<object> list3;
		List<object> list2 = list3;
		enumerator3 = (List<object>.Enumerator)0;
		object obj11;
		nint num2 = (nint)obj11;
		int num3;
		num = num3;
		goto IL_0fc4;
		IL_0e3b:
		ex = new NullReferenceException();
		enumerator2 = enumerator3;
		enumerator4 = enumerator3;
		list2 = list3;
		enumerator3 = (List<object>.Enumerator)0;
		object obj12 = 0;
		Predicate<object> predicate = default(Predicate<object>);
		num = (int)predicate;
		goto IL_0fc4;
		IL_0df5:
		ex = new NullReferenceException();
		enumerator2 = enumerator3;
		enumerator4 = enumerator3;
		list2 = list3;
		enumerator3 = (List<object>.Enumerator)0;
		obj12 = 0;
		num2 = (nint)this;
		num = (int)obj11;
		goto IL_0fc4;
		IL_0d4f:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0d5d;
		IL_0156:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v111+E4]");
		object[] array = (object[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v111+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj14 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v83+B8]");
			obj7 = 0;
		}
		object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)2680;
		Func<object, DateTime> func = default(Func<object, DateTime>);
		func..ctor(obj7, (IntPtr)obj16);
		object obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v82+B8]");
		object obj18 = (nint)0 + (nint)8;
		obj18 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj12 = 0;
		obj6 = obj9;
		keySelector = func;
		goto IL_01bd;
		IL_0d5d:
		ex = new NullReferenceException();
		enumerator2 = enumerator;
		goto IL_0fc4;
		IL_0d73:
		ex = new NullReferenceException();
		enumerator2 = enumerator3;
		enumerator4 = enumerator3;
		list2 = list3;
		enumerator3 = (List<object>.Enumerator)0;
		obj12 = 0;
		num2 = (nint)list;
		object obj19 = default(object);
		num = (int)obj19;
		goto IL_0fc4;
		IL_01bd:
		IOrderedEnumerable<object> orderedEnumerable = Enumerable.OrderByDescending(notifications, keySelector);
		object obj20 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v50+E4]");
		bool flag5 = (nint)0 == 0;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj20 = obj3;
		}
		object obj22 = (nint)0 + (nint)1056;
		object obj23 = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v50+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v68+10]");
		Func<object, int> keySelector2 = (Func<object, int>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v68+10]");
		bool flag6 = (nint)0 == 0;
		object obj25 = !flag6;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v50+E4]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v50+E4]");
			bool flag7 = (nint)0 == 0;
			object obj26 = !flag7;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj27 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v74+B8]");
				obj24 = 0;
			}
			object obj28 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj29 = (nint)0 + (nint)2688;
			Func<object, int> func2 = default(Func<object, int>);
			func2..ctor(obj24, (IntPtr)obj29);
			object obj30 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v73+B8]");
			object obj31 = (nint)0 + (nint)16;
			obj31 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj12 = 0;
			keySelector2 = func2;
		}
		num2 = (nint)obj22;
		IOrderedEnumerable<object> source = Enumerable.ThenByDescending(orderedEnumerable, keySelector2);
		num = (int)obj23;
		list3 = Enumerable.ToList(source);
		bool flag8 = list3 == null;
		enumerator = (List<object>.Enumerator)0;
		list = (List<Notification>)orderedEnumerable;
		if (flag8)
		{
			goto IL_0d4f;
		}
		object obj32 = (nint)0 + (nint)3664;
		object obj33 = typeof(List<Tween>) + 3368;
		list = (List<Notification>)((nint)0 + (nint)2712);
		object obj34 = (nint)0 + (nint)760;
		List<object>.Enumerator enumerator5 = list3.GetEnumerator();
		object obj36 = default(object);
		object obj45 = default(object);
		NotificationItem notificationItem = default(NotificationItem);
		List<object> list5;
		NotificationsManager notificationsManager = default(NotificationsManager);
		while (enumerator.MoveNext())
		{
			object obj35 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1160;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj19..ctor();
			bool flag9 = obj19 == null;
			enumerator = enumerator3;
			enumerator4 = enumerator3;
			list2 = list3;
			enumerator3 = (List<object>.Enumerator)0;
			num = 0;
			if (flag9)
			{
				goto IL_0d5d;
			}
			obj11 = obj19 + 16;
			obj11 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			predicate..ctor(obj19, (IntPtr)list);
			if (shownNotifications == null)
			{
				goto IL_0d73;
			}
			num2 = (nint)obj34;
			num3 = ((List<object>)(object)shownNotifications).FindIndex(predicate);
			int num4 = (int)(num3 & 0x80000000L);
			bool flag10 = num4 == 0;
			object obj37 = !flag10;
			if (obj37 == null)
			{
				if (shownNotifications == null)
				{
					goto IL_0e3b;
				}
				object obj38 = (nint)0 + (nint)816;
				obj12 = obj38;
				((List<object>)(object)shownNotifications).set_Item(num3, obj11);
				if (items == null)
				{
					goto IL_0e7c;
				}
				object obj39 = (nint)0 + (nint)872;
				num2 = (nint)obj39;
				object obj40 = ((List<object>)(object)items).get_Item(num3);
				if (obj40 != null)
				{
					((NotificationItem)obj40).Populate((Notification)obj11, this);
					num2 = (nint)this;
					continue;
				}
				goto IL_0ebc;
			}
			object obj41 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj42 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X0_v69+E4]");
			bool flag11 = (nint)0 == 0;
			object obj43 = !flag11;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj44 = (nint)0 + (nint)544;
			num2 = (nint)obj44;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			if (obj45 != null)
			{
				object obj46 = (nint)0 + (nint)1336;
				num = (int)obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				if ((object)notificationItem != null)
				{
					notificationItem.Populate((Notification)obj11, this);
					List<object> list4 = (List<object>)(object)items;
					if (items != null)
					{
						object obj47 = (nint)0 + (nint)848;
						object obj48 = obj47;
						int version = list4._version + 1;
						list4._version = version;
						array = list4._items;
						if (list4._items != null)
						{
							bool flag12 = list4._size < array.Length;
							object obj49 = !flag12;
							object obj52;
							if (obj49 == null)
							{
								int size = list4._size + 1;
								list4._size = size;
								object obj50 = list4._items + list4._size;
								object obj51 = obj50 + 32;
								obj51 = notificationItem;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								num2 = (nint)this;
								obj52 = notificationItem;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v46+20]");
								object obj53 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ X8_v61+C0]");
								object obj54 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v816 @ X8_v62+70]");
								num2 = 0;
								((List<object>)(object)items).AddWithResize((object)notificationItem);
								obj52 = notificationItem;
							}
							list5 = (List<object>)(object)shownNotifications;
							bool flag13 = shownNotifications == null;
							num = (int)obj52;
							if (!flag13)
							{
								object obj55 = (nint)0 + (nint)752;
								object obj56 = obj55;
								int version2 = list5._version + 1;
								list5._version = version2;
								object[] array2 = list5._items;
								bool flag14 = list5._items == null;
								array = list5._items;
								num = (int)obj11;
								if (!flag14)
								{
									bool flag15 = list5._size < array2.Length;
									object obj57 = !flag15;
									if (obj57 == null)
									{
										int size2 = list5._size + 1;
										list5._size = size2;
										object obj58 = list5._items + list5._size;
										object obj59 = obj58 + 32;
										obj59 = obj11;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X8_v51+20]");
										object obj60 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X8_v58+C0]");
										object obj61 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X8_v59+70]");
										num2 = 0;
										((List<object>)(object)shownNotifications).AddWithResize(obj11);
									}
									object obj62 = typeof(Queue<string>) + 792;
									object obj63 = obj62;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v842 @ X0_v83+E4]");
									bool flag16 = (nint)0 == 0;
									object obj64 = !flag16;
									if (obj64 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									object obj65 = (nint)0 + (nint)2104;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
									if ((object)notificationsManager != null)
									{
										notificationsManager.MarkNotificationSeen((Notification)obj11);
										obj12 = 0;
										num2 = unchecked((nint)null);
										array = list5._items;
										continue;
									}
									goto IL_0ef4;
								}
							}
							goto IL_0dbc;
						}
					}
					goto IL_0df5;
				}
				goto IL_0f42;
			}
			goto IL_0f7b;
		}
		object obj66 = (nint)0 + (nint)3656;
		num = (int)obj66;
		enumerator.Dispose();
		object obj67 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2552;
		object obj68 = (nint)0 + (nint)2704;
		object obj69 = (nint)0 + (nint)2712;
		object obj70 = (nint)0 + (nint)864;
		object obj71 = (nint)0 + (nint)792;
		IEnumerable<object> enumerable = list3;
		enumerator = enumerator3;
		enumerator4 = enumerator3;
		list2 = list3;
		enumerator3 = (List<object>.Enumerator)0;
		goto IL_1325;
		IL_0dbc:
		ex = new NullReferenceException();
		enumerator2 = enumerator3;
		enumerator4 = enumerator3;
		list2 = list3;
		enumerator3 = (List<object>.Enumerator)0;
		obj12 = 0;
		goto IL_0fc4;
		IL_1325:
		List<Notification> list6 = shownNotifications;
		if (shownNotifications != null)
		{
			int num5 = list6._size;
			Func<object, bool> func3 = default(Func<object, bool>);
			while (true)
			{
				object obj72 = num5 - 1;
				if ((nint)obj72 >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+20]");
					object obj74;
					nint num6;
					int num7;
					if ((nint)0 != 0)
					{
						num2 = (nint)obj69;
						IEnumerable<object> source2 = enumerable;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+20]");
						bool flag17 = Enumerable.Any(source2, (Func<object, bool>)0);
						bool flag18 = !flag17;
						object obj73 = !flag18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+20]");
						num = 0;
						if (obj73 != null)
						{
							goto IL_0a3e;
						}
						obj74 = obj12;
						num6 = (nint)obj69;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+20]");
						num7 = 0;
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						func3..ctor(obj2, (IntPtr)obj68);
						object obj75 = obj2 + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						num2 = (nint)obj69;
						bool flag19 = Enumerable.Any(enumerable, func3);
						bool flag20 = !flag19;
						object obj76 = !flag20;
						obj12 = 0;
						num = (int)func3;
						obj74 = 0;
						num6 = (nint)obj69;
						num7 = (int)func3;
						if (obj76 != null)
						{
							goto IL_0a3e;
						}
					}
					bool flag21 = items == null;
					obj12 = obj74;
					num2 = num6;
					num = num7;
					if (flag21)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+18]");
					num = 0;
					object obj77 = (nint)0 + (nint)872;
					num2 = (nint)obj77;
					List<NotificationItem> list7 = items;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+18]");
					object obj78 = ((List<object>)(object)list7).get_Item(0);
					bool flag22 = obj78 == null;
					obj12 = obj74;
					if (flag22)
					{
						break;
					}
					GameObject gameObject = ((Component)obj78).gameObject;
					object obj79 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj80 = obj79;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v12+E4]");
					bool flag23 = (nint)0 == 0;
					object obj81 = !flag23;
					UnityEngine.Object obj82 = gameObject;
					if (obj81 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj82 = gameObject;
					}
					UnityEngine.Object.Destroy(obj82);
					bool flag24 = items == null;
					obj12 = obj74;
					num = 0;
					if (flag24)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+18]");
					num = 0;
					num2 = (nint)obj70;
					List<NotificationItem> list8 = items;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+18]");
					((List<object>)(object)list8).RemoveAt(0);
					bool flag25 = shownNotifications == null;
					obj12 = obj74;
					if (flag25)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+18]");
					num = 0;
					num2 = (nint)obj71;
					List<Notification> list9 = shownNotifications;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+18]");
					((List<object>)(object)list9).RemoveAt(0);
					obj12 = obj74;
					goto IL_0a3e;
				}
				UpdatePlaceholder();
				return;
				IL_0a3e:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3 (System.Object)+18]");
				num5 = 0;
			}
		}
		goto IL_0d4f;
		IL_0f7b:
		ex = new NullReferenceException();
		enumerator2 = enumerator3;
		enumerator4 = enumerator3;
		list2 = list3;
		enumerator3 = (List<object>.Enumerator)0;
		obj12 = 0;
		num = (int)itemsList;
		goto IL_0fc4;
		IL_0f42:
		ex = new NullReferenceException();
		enumerator2 = enumerator3;
		enumerator4 = enumerator3;
		list2 = list3;
		enumerator3 = (List<object>.Enumerator)0;
		obj12 = 0;
		goto IL_0fc4;
		IL_0ebc:
		ex = new NullReferenceException();
		enumerator2 = enumerator3;
		enumerator4 = enumerator3;
		list2 = list3;
		enumerator3 = (List<object>.Enumerator)0;
		num = num3;
		goto IL_0fc4;
		IL_0fc4:
		obj67 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2552;
		obj68 = (nint)0 + (nint)2704;
		obj69 = (nint)0 + (nint)2712;
		obj70 = (nint)0 + (nint)864;
		obj71 = (nint)0 + (nint)792;
		bool flag26 = num != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex;
		if (!flag26)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj83 = (nint)0 + (nint)3656;
			num = (int)obj83;
			enumerator2.Dispose();
			object obj84 = default(object);
			bool flag27 = obj84 == null;
			enumerable = list2;
			enumerator = enumerator2;
			enumerator3 = (List<object>.Enumerator)obj84;
			if (flag27)
			{
				goto IL_1325;
			}
			ex3 = new OutOfMemoryException();
			enumerator3 = (List<object>.Enumerator)obj84;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237AB8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0ef4:
		ex = new NullReferenceException();
		enumerator2 = enumerator3;
		enumerator4 = enumerator3;
		list2 = list3;
		enumerator3 = (List<object>.Enumerator)0;
		obj12 = 0;
		array = list5._items;
		num = (int)obj11;
		goto IL_0fc4;
	}

	public void HideAllBut(NotificationItem item)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00bc: Expected I, but got O
		//IL_00e6: Expected O, but got I4
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_025a: Expected O, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0172: Expected O, but got I
		//IL_017e: Expected O, but got I
		//IL_01f6: Expected O, but got I4
		//IL_021a: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = item;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)3512;
		object obj7 = typeof(RegisteredWaitHandle) + 3136;
		GameObject popup = ((Component)obj3).gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj3, (IntPtr)obj6);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v15+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(popup, action);
		object obj10 = typeof(UsageHint) + 744;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v7+B8]");
		object obj12 = 0;
		RectTransform rectTransform = UIExtensions.rectTransform((Component)obj3);
		Vector2 anchoredPosition = rectTransform.anchoredPosition;
		Transform transform = ((Component)obj3).transform;
		object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj14 = (nint)0 + (nint)2720;
		object obj15 = (nint)0 + (nint)2488;
		object obj16 = default(object);
		double num = (double)obj16 + 30.0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v8+1C]");
		double num2 = 0.0 * num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v8+18]");
		double num3 = 0.0 * num;
		Transform parent = transform.parent;
		RectTransform target = UIExtensions.rectTransform(parent);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos(target, (Vector2)0, (float)num3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	public void ShowAll(NotificationItem item)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0199: Expected O, but got I4
		//IL_01a2: Expected O, but got I4
		//IL_01ab: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_00db: Expected O, but got I
		//IL_00eb: Expected O, but got I
		//IL_01ed: Expected O, but got I
		//IL_01fd: Expected O, but got I
		//IL_021f: Expected O, but got I4
		//IL_025f: Expected O, but got I4
		//IL_0132: Expected O, but got I4
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_039c: Expected O, but got I
		//IL_03ad: Expected I, but got O
		//IL_03cb: Expected O, but got I
		//IL_02b5: Expected O, but got I
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_028f: Expected O, but got I
		//IL_031f: Expected O, but got I4
		//IL_036a: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 3136;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1144;
		GameObject go = item.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v4+E4]");
		List<NotificationItem> list;
		object obj6;
		List<NotificationItem> list2;
		object obj4;
		object obj5;
		if ((nint)0 != 0)
		{
			ScreenManager.RemovePopup(go);
			list = items;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v23+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = 0;
			object obj7 = obj4;
			list2 = items;
			if (!flag)
			{
				goto IL_00cb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ScreenManager.RemovePopup(go);
			list = items;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v23+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj5 = 0;
			obj6 = 0;
			object obj7 = obj4;
			list2 = items;
			if (obj8 != null)
			{
				goto IL_00cb;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v23+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v15+18]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v15+18]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		list = list2;
		obj5 = obj6;
		if (obj10 != null)
		{
			goto IL_0118;
		}
		goto IL_023d;
		IL_02a9:
		object obj11 = (nint)0 + (nint)856;
		object obj12 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1648;
		List<object> list3;
		list3.ForEach(action);
		Transform transform = item.transform;
		RectTransform rectTransform = UIExtensions.parentRt(transform);
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(rectTransform);
		RectTransform rectTransform2 = UIExtensions.rectTransform(item);
		Vector2 anchoredPosition = rectTransform2.anchoredPosition;
		rectTransform.anchoredPosition = (Vector2)0;
		return;
		IL_0118:
		bool flag5 = list == null;
		object obj15 = !flag5;
		list3 = (List<object>)(object)list;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_02a9;
		IL_023d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v23+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v21+B8]");
			obj9 = 0;
		}
		object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)2696;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj9, (IntPtr)obj19);
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v20+B8]");
		object obj21 = (nint)0 + (nint)24;
		obj21 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action2;
		list3 = (List<object>)(object)list2;
		goto IL_02a9;
		IL_00cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v23+B8]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v15+18]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v15+18]");
		bool flag7 = (nint)0 == 0;
		list2 = list;
		if (!flag7)
		{
			goto IL_0118;
		}
		goto IL_023d;
	}

	public void DismissNotification(Notification notification)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_006e: Expected O, but got I4
		object obj = (nint)0 + (nint)784;
		object obj2 = typeof(Queue<string>) + 792;
		object obj3 = (nint)0 + (nint)2104;
		bool flag = ((List<object>)(object)shownNotifications).Remove((object)notification);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		NotificationsManager notificationsManager = default(NotificationsManager);
		notificationsManager.DismissNotification(notification);
		UpdatePlaceholder();
	}

	private void UpdatePlaceholder()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0073: Expected I, but got O
		//IL_009d: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3560;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.3f, action);
	}

	public NotificationsCenterUI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 2464;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = this + 56;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj4 = this + 64;
		obj4 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <UpdatePlaceholder>b__12_0()
	{
		//IL_0018: Expected O, but got I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected I4, but got Unknown
		List<Notification> list = shownNotifications;
		object obj = list._size - 1;
		bool flag = (nint)obj < 0;
		int num = list._size ^ 1;
		int num2 = list._size ^ obj;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		bool active = !flag3;
		placeholder.SetActive(active);
	}
}
