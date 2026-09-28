using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using SFSLitJson;
using Server.Models;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.AddressableAssets;
using UnityEngine.Purchasing.Telemetry;

public class NotificationsManager : Singleton<NotificationsManager>
{
	private class NotificationView
	{
		private int <Id>k__BackingField;

		private int <DismissCount>k__BackingField;

		private DateTime <LastDismissTime>k__BackingField;

		private DateTime <LastSeenTime>k__BackingField;

		private bool <IsSeen>k__BackingField;

		public int Id
		{
			get
			{
				return <Id>k__BackingField;
			}
			set
			{
				<Id>k__BackingField = value;
			}
		}

		public int DismissCount
		{
			get
			{
				return <DismissCount>k__BackingField;
			}
			set
			{
				<DismissCount>k__BackingField = value;
			}
		}

		public DateTime LastDismissTime
		{
			get
			{
				return <LastDismissTime>k__BackingField;
			}
			set
			{
				<LastDismissTime>k__BackingField = value;
			}
		}

		public DateTime LastSeenTime
		{
			get
			{
				return <LastSeenTime>k__BackingField;
			}
			set
			{
				<LastSeenTime>k__BackingField = value;
			}
		}

		public bool IsSeen
		{
			get
			{
				return <IsSeen>k__BackingField;
			}
			set
			{
				<IsSeen>k__BackingField = value;
			}
		}

		public bool IsDismissed(Notification n)
		{
			//IL_00d5: Expected I4, but got O
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			//IL_006a: Expected O, but got I4
			if (n != null)
			{
				if (n.<timesToAppear>k__BackingField > <DismissCount>k__BackingField)
				{
					object obj = typeof(DataRelation) + 712;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
					bool flag = (nint)0 == 0;
					object obj3 = !flag;
					if (obj3 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					DateTime dateTime2 = default(DateTime);
					DateTime dateTime = dateTime2.AddTicks(n.<gapTicks>k__BackingField);
					DateTime now = DateTime.Now;
					return dateTime > now;
				}
				return true;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		public NotificationView()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005a: Expected O, but got I4
			//IL_0078: Expected O, but got I
			//IL_008a: Expected O, but got I
			//IL_009c: Expected O, but got I
			object obj = typeof(DataRelation) + 712;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+10]");
			<LastDismissTime>k__BackingField = (DateTime)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v4+10]");
			<LastSeenTime>k__BackingField = (DateTime)0;
			base..ctor();
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Notification, DateTime> <>9__23_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal DateTime <ApplyNotifications>b__23_0(Notification n)
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
	}

	private sealed class <>c__DisplayClass27_0
	{
		public Notification notification;

		internal bool <DismissNotification>b__0(NotificationView n)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (n != null)
			{
				Notification notification = this.notification;
				if (this.notification != null)
				{
					object obj = n.<Id>k__BackingField - notification.<id>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass28_0
	{
		public Notification notification;

		internal bool <MarkNotificationSeen>b__0(NotificationView n)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (n != null)
			{
				Notification notification = this.notification;
				if (this.notification != null)
				{
					object obj = n.<Id>k__BackingField - notification.<id>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass29_0
	{
		public Notification notification;

		internal bool <IsUnread>b__0(NotificationView v)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (v != null)
			{
				Notification notification = this.notification;
				if (this.notification != null)
				{
					object obj = v.<Id>k__BackingField - notification.<id>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass30_0
	{
		public Notification notification;

		internal bool <PassesFiltersCheck>b__0(NotificationView v)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (v != null)
			{
				Notification notification = this.notification;
				if (this.notification != null)
				{
					object obj = v.<Id>k__BackingField - notification.<id>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private const string NotificationsPrefKey = "NotificationViews";

	private AssetReferenceGameObject forceNotificationUiRef;

	private List<Notification> <Notifications>k__BackingField;

	private List<NotificationView> <NotificationViews>k__BackingField;

	private static readonly OneShotEvent readyStatus;

	private List<Notification> Notifications
	{
		get
		{
			return <Notifications>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<Notification> ActiveNotifications
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_0051: Expected I, but got O
			object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2552;
			object obj2 = (nint)0 + (nint)3624;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)this, (IntPtr)obj2);
			IEnumerable<object> source = Enumerable.Where(<Notifications>k__BackingField, func);
			return (List<Notification>)(object)Enumerable.ToList(source);
		}
	}

	public List<Notification> ActiveForcedNotifications
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_0051: Expected I, but got O
			object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2552;
			object obj2 = (nint)0 + (nint)3632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)this, (IntPtr)obj2);
			IEnumerable<object> source = Enumerable.Where(<Notifications>k__BackingField, func);
			return (List<Notification>)(object)Enumerable.ToList(source);
		}
	}

	public int UnreadCount
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_005e: Expected I, but got O
			object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2552;
			object obj2 = (nint)0 + (nint)3600;
			List<Notification> activeNotifications = ActiveNotifications;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)this, (IntPtr)obj2);
			return Enumerable.Count(activeNotifications, func);
		}
	}

	private List<NotificationView> NotificationViews
	{
		get
		{
			return <NotificationViews>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static event Action<List<Notification>> OnNotificationsReceived
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_01fb: Expected O, but got I4
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Expected O, but got Unknown
			//IL_022d: Expected O, but got I
			//IL_015a: Expected O, but got I4
			//IL_0163: Expected O, but got I4
			//IL_016c: Expected O, but got I4
			//IL_00e5: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2704;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Delegate obj6 = (Delegate)obj5;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj20 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj20 == obj6;
				obj6 = obj20;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_01fb: Expected O, but got I4
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Expected O, but got Unknown
			//IL_022d: Expected O, but got I
			//IL_015a: Expected O, but got I4
			//IL_0163: Expected O, but got I4
			//IL_016c: Expected O, but got I4
			//IL_00e5: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2704;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Delegate obj6 = (Delegate)obj5;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj20 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj20 == obj6;
				obj6 = obj20;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0168: Expected O, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_01b0: Expected O, but got I4
		//IL_01d2: Expected O, but got I
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0070: Expected I, but got O
		//IL_009f: Expected O, but got I4
		//IL_00e2: Expected I, but got O
		//IL_010c: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 2464;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)3608;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		GameObject gameObject = base.gameObject;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		UnityEngine.Object target = gameObject;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		object obj8 = (nint)0 + (nint)3616;
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		UnityEngine.Object.DontDestroyOnLoad(target);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj10 = this + 40;
		obj10 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		LoadViews();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		object obj11 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Config.OnLoggedIn += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj8);
		object obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v18+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ContentPushService.OnNotificationsApplied += action2;
	}

	private void OnLoggedIn()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_007d: Expected I, but got O
		//IL_00a7: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)3576;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
		object wireKey = "not" + 184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ContentSyncService.EnsureFresh((string)wireKey, action);
	}

	private void OnNotificationsApplied()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f9: Expected O, but got I4
		//IL_0139: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70AC]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CachedModel<List<Notification>> notifications = CachedModels.Notifications;
		bool flag2 = notifications == null;
		object obj6 = !flag2;
		CachedModel<object> cachedModel = (CachedModel<object>)(object)notifications;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0093;
		IL_007d:
		CachedModel<List<Notification>> notifications2 = CachedModels.Notifications;
		cachedModel = (CachedModel<object>)(object)notifications2;
		goto IL_0093;
		IL_0093:
		object model = cachedModel.Model;
		if (model != null)
		{
			ApplyNotifications((List<Notification>)model);
		}
	}

	private void ApplyNotifications(List<Notification> notifications)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02ce: Expected O, but got I4
		//IL_03a6: Expected O, but got I
		//IL_03b7: Expected O, but got I
		//IL_03c7: Expected O, but got I
		//IL_03e9: Expected O, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0105: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_0364: Expected O, but got I
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_0306: Expected O, but got I
		//IL_0317: Expected I, but got O
		//IL_0335: Expected O, but got I
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0163: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_019c: Expected O, but got I4
		//IL_01e3: Expected O, but got I
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0229: Expected O, but got I
		//IL_0253: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1176;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj4 = (nint)0 + (nint)2440;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v18+8]");
		Func<object, DateTime> keySelector = (Func<object, DateTime>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v18+8]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v24+B8]");
				obj5 = 0;
			}
			object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2560;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)2728;
			Func<object, DateTime> func = default(Func<object, DateTime>);
			func..ctor(obj5, (IntPtr)obj10);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v23+B8]");
			object obj12 = (nint)0 + (nint)8;
			obj12 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			keySelector = func;
		}
		IOrderedEnumerable<object> source = Enumerable.OrderByDescending(notifications, keySelector);
		List<object> list = Enumerable.ToList(source);
		object obj13 = typeof(MemberAchievementClanFeedData) + 2704;
		object obj14 = this + 40;
		obj14 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj15 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v14+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj13;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v14+B8]");
		object obj17 = 0;
		object obj18 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object extra = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v8+8]");
		((OneShotEvent)0).IsReady = true;
		int unreadCount = UnreadCount;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v18+E4]");
		bool flag5 = (nint)0 == 0;
		object obj20 = !flag5;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.Notifications, unreadCount, (string)extra);
		object obj21 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v10+B8]");
		object obj22 = 0;
		object obj23 = obj22;
		if (obj22 != null)
		{
			object obj24 = typeof(Queue<string>) + 792;
			object obj25 = (nint)0 + (nint)2104;
			object obj26 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v26+E4]");
			bool flag6 = (nint)0 == 0;
			object obj27 = !flag6;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			NotificationsManager notificationsManager = default(NotificationsManager);
			List<Notification> activeNotifications = notificationsManager.ActiveNotifications;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ X20_v4+18] (should have been resolved before IL gen)");
		}
		List<Notification> activeForcedNotifications = ActiveForcedNotifications;
		if (Enumerable.Any((IEnumerable<object>)activeForcedNotifications))
		{
			ShowForcedNotifications();
		}
	}

	private void ShowForcedNotifications()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006f: Expected I, but got O
		//IL_0099: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3584;
		object obj3 = typeof(RegisteredWaitHandle) + 3136;
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
		ScreenManager.WaitForScene(Scenes.Menu, action);
	}

	public static void ResetModels()
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_0117: Expected O, but got I4
		//IL_00b6: Expected O, but got I
		//IL_00c6: Expected O, but got I
		//IL_0090: Expected O, but got I4
		//IL_014f: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_0181: Expected O, but got I4
		object obj = 152989696;
		object key = "Network Authentication Required" + 2304;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2704;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70AF]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			Prefs.DeleteKey((string)key);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_00a6;
			}
		}
		else
		{
			_ = 1;
			Prefs.DeleteKey((string)key);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj5 = 0;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_00a6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v5+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+8]");
		OneShotEvent oneShotEvent = (OneShotEvent)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00cb;
		IL_00a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v16+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v9+8]");
		oneShotEvent = (OneShotEvent)0;
		goto IL_00cb;
		IL_00cb:
		oneShotEvent.Clear();
	}

	public static void CallWhenLoaded(Action action)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00df: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_0117: Expected O, but got I
		//IL_0127: Expected O, but got I
		//IL_0149: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2704;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70B0]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v5+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+8]");
		OneShotEvent oneShotEvent = (OneShotEvent)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a1;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v12+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v9+8]");
		oneShotEvent = (OneShotEvent)0;
		goto IL_00a1;
		IL_00a1:
		oneShotEvent.CallWhenReady(action);
	}

	public void DismissNotification(Notification notification)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0099: Expected I, but got O
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_03e3: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_011b: Expected O, but got I4
		//IL_046a: Expected O, but got I
		//IL_01c8: Expected O, but got I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0336: Expected O, but got Unknown
		//IL_0375: Expected O, but got I4
		//IL_0214: Expected O, but got I
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		//IL_026e: Expected O, but got I4
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected O, but got Unknown
		//IL_044c: Expected O, but got I4
		//IL_02e3: Expected O, but got I
		//IL_02f3: Expected O, but got I
		//IL_0303: Expected O, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 488;
		object obj4 = (nint)0 + (nint)2736;
		object obj5 = (nint)0 + (nint)1480;
		object obj6 = typeof(DataRelation) + 712;
		object obj7 = obj2 + 16;
		obj7 = notification;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		object obj9 = Enumerable.FirstOrDefault(<NotificationViews>k__BackingField, func);
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v11 (System.Object)+14]");
			object obj10 = (nint)0 + (nint)1;
			object obj11 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v53+E4]");
			bool flag = (nint)0 == 0;
			object obj12 = !flag;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
			_ = 0;
		}
		else
		{
			object obj13 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v37+E4]");
			bool flag2 = (nint)0 == 0;
			object obj15 = !flag2;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v37+B8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v16+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v16+10]");
			_ = 0;
			object obj17 = default(object);
			obj17..ctor();
			object obj18 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X8_v18+10]");
			_ = 0;
			_ = 1;
			object obj19 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v39+E4]");
			bool flag3 = (nint)0 == 0;
			object obj20 = !flag3;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now2 = DateTime.Now;
			_ = 0;
			List<object> list = (List<object>)(object)<NotificationViews>k__BackingField;
			object obj21 = (nint)0 + (nint)3416;
			object obj22 = obj21;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag4 = list._size < items.Length;
			object obj23 = !flag4;
			if (obj23 == null)
			{
				int size = list._size + 1;
				list._size = size;
				object obj24 = items + list._size;
				object obj25 = obj24 + 32;
				obj25 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v23+20]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v24+C0]");
				object obj27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v25+70]");
				obj8 = 0;
				list.AddWithResize(obj17);
			}
		}
		object obj28 = obj7;
		object obj29 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v5+10]");
		ITrackEvent trackEvent = TrackerLibrary.NotificationDismissed(0);
		object obj30 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj31 = !flag5;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		object obj32 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
		object key = "Network Authentication Required" + 2304;
		object obj33 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v9+E4]");
		bool flag6 = (nint)0 == 0;
		object obj34 = !flag6;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string value = JsonMapper.ToJson(<NotificationViews>k__BackingField);
		Prefs.SetString((string)key, value);
	}

	public void MarkNotificationSeen(Notification notification)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0085: Expected I, but got O
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		//IL_04e7: Expected O, but got I4
		//IL_00f5: Expected O, but got I4
		//IL_0573: Expected O, but got I
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Expected O, but got Unknown
		//IL_024f: Expected O, but got I4
		//IL_0517: Unknown result type (might be due to invalid IL or missing references)
		//IL_051c: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_0555: Expected O, but got I4
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_01a4: Expected O, but got I4
		//IL_0291: Expected O, but got I
		//IL_0461: Expected O, but got I4
		//IL_02eb: Expected O, but got I4
		//IL_0360: Expected O, but got I
		//IL_0370: Expected O, but got I
		//IL_0380: Expected O, but got I
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03f2: Expected O, but got I4
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 488;
		object obj4 = (nint)0 + (nint)2744;
		object obj5 = (nint)0 + (nint)1480;
		object obj6 = obj2 + 16;
		obj6 = notification;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj4);
		object obj7 = obj5;
		object obj8 = Enumerable.FirstOrDefault(<NotificationViews>k__BackingField, func);
		Notification notification2;
		if (obj8 != null)
		{
			notification2 = (Notification)obj6;
			bool flag = ((NotificationView)obj8).IsDismissed((Notification)obj6);
			bool flag2 = !flag;
			object obj9 = !flag2;
			if (obj9 != null)
			{
				goto IL_040f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v11 (System.Object)+28]");
			if ((nint)0 == 1)
			{
				object obj10 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v39+32]");
				if ((nint)0 != 1)
				{
					goto IL_040f;
				}
			}
			_ = 1;
			object obj11 = typeof(DataRelation) + 712;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X0_v61+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now = DateTime.Now;
		}
		else
		{
			List<object> list = (List<object>)(object)<NotificationViews>k__BackingField;
			object obj14 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = typeof(DataRelation) + 712;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v44+E4]");
			bool flag4 = (nint)0 == 0;
			object obj17 = !flag4;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj15;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v44+B8]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v20+10]");
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v20+10]");
			_ = 0;
			object obj19 = default(object);
			obj19..ctor();
			object obj20 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v22+10]");
			_ = 0;
			object obj21 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X0_v46+E4]");
			bool flag5 = (nint)0 == 0;
			object obj22 = !flag5;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime now2 = DateTime.Now;
			_ = 1;
			object obj23 = (nint)0 + (nint)3416;
			object obj24 = obj23;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag6 = list._size < items.Length;
			object obj25 = !flag6;
			if (obj25 == null)
			{
				int size = list._size + 1;
				list._size = size;
				object obj26 = items + list._size;
				object obj27 = obj26 + 32;
				obj27 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v28+20]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v29+C0]");
				object obj29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X8_v30+70]");
				obj7 = 0;
				list.AddWithResize(obj19);
			}
		}
		object obj30 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v11+10]");
		ITrackEvent trackEvent = TrackerLibrary.NotificationViewed(0);
		object obj31 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj32 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v14+E4]");
		bool flag7 = (nint)0 == 0;
		object obj33 = !flag7;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		notification2 = null;
		goto IL_040f;
		IL_040f:
		object obj34 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
		object obj35 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object key = "Network Authentication Required" + 2304;
		object obj36 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v7+E4]");
		bool flag8 = (nint)0 == 0;
		object obj37 = !flag8;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object extra = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 2376;
		string value = JsonMapper.ToJson(<NotificationViews>k__BackingField);
		Prefs.SetString((string)key, value);
		int unreadCount = UnreadCount;
		object obj38 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v20+E4]");
		bool flag9 = (nint)0 == 0;
		object obj39 = !flag9;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.Notifications, unreadCount, (string)extra);
	}

	private bool IsUnread(Notification notification)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0145: Expected I4, but got O
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0074: Expected O, but got I
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00c1: Expected O, but got I
		//IL_00d2: Expected I, but got O
		//IL_011e: Expected O, but got I
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected I4, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = notification;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj3;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+32]");
				object obj5 = (nint)0 & (nint)1;
				if (obj5 != null)
				{
					return false;
				}
				object obj6 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 488;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj7 = (nint)0 + (nint)2752;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj2, (IntPtr)obj7);
				object obj8 = Enumerable.FirstOrDefault(<NotificationViews>k__BackingField, func);
				if (obj8 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v11 (System.Object)+28]");
					object obj9 = (nint)0 ^ (nint)1;
					return (byte)(obj9 & 1) != 0;
				}
				return true;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private bool PassesFiltersCheck(Notification notification)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_04b4: Expected I4, but got O
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0074: Expected O, but got I
		//IL_0259: Expected O, but got I
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_042b: Expected O, but got I
		//IL_0447: Expected I, but got O
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_01a3: Expected O, but got I4
		//IL_0390: Expected O, but got I4
		//IL_012d: Expected O, but got I
		//IL_0145: Expected I, but got O
		//IL_01e0: Expected O, but got I
		//IL_031a: Expected O, but got I
		//IL_0332: Expected I, but got O
		//IL_03cd: Expected O, but got I
		//IL_0203: Expected O, but got I4
		//IL_0208: Expected I, but got O
		//IL_03f0: Expected O, but got I4
		//IL_03f5: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3;
		Notification notification2 = default(Notification);
		DateTime dateTime;
		nint num;
		object obj4;
		if (obj2 != null)
		{
			obj3 = obj2 + 16;
			obj3 = notification2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj4 = obj3;
			if (obj3 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v5+40]");
				object obj5 = (nint)0 & (nint)1;
				if (obj5 != null)
				{
					object obj6 = typeof(DataRelation) + 712;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v34+E4]");
					DateTime dateTime2;
					if ((nint)0 != 0)
					{
						DateTime now = DateTime.Now;
						object obj8 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v36+E4]");
						bool flag = (nint)0 == 0;
						dateTime = now;
						dateTime2 = now;
						if (!flag)
						{
							goto IL_0118;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						DateTime now2 = DateTime.Now;
						object obj8 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v36+E4]");
						bool flag2 = (nint)0 == 0;
						object obj9 = !flag2;
						dateTime = now2;
						dateTime2 = now2;
						if (obj9 != null)
						{
							goto IL_0118;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v5+48]");
					bool flag3 = (DateTime)0 >= dateTime2;
					bool flag4 = !flag3;
					object obj10 = !flag4;
					num = unchecked((nint)null);
					notification2 = (Notification)dateTime2;
					if (obj10 != null)
					{
						goto IL_015b;
					}
					goto IL_021e;
				}
				goto IL_0243;
			}
		}
		goto IL_04a6;
		IL_04a6:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0243:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v5+50]");
		object obj11 = (nint)0 & (nint)1;
		bool flag5 = obj11 == null;
		DateTime dateTime3 = (DateTime)notification2;
		DateTime dateTime4;
		if (!flag5)
		{
			object obj12 = typeof(DataRelation) + 712;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X0_v17+E4]");
			DateTime dateTime5;
			if ((nint)0 != 0)
			{
				DateTime now3 = DateTime.Now;
				object obj14 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v18+E4]");
				bool flag6 = (nint)0 == 0;
				dateTime4 = now3;
				dateTime5 = now3;
				if (!flag6)
				{
					goto IL_0305;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				DateTime now4 = DateTime.Now;
				object obj14 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v18+E4]");
				bool flag7 = (nint)0 == 0;
				object obj15 = !flag7;
				dateTime4 = now4;
				dateTime5 = now4;
				if (obj15 != null)
				{
					goto IL_0305;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v5+58]");
			bool flag8 = (DateTime)0 <= dateTime5;
			bool flag9 = !flag8;
			object obj16 = !flag9;
			num = unchecked((nint)null);
			dateTime3 = dateTime5;
			if (obj16 != null)
			{
				goto IL_0348;
			}
		}
		goto IL_040b;
		IL_0305:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v5+58]");
		bool flag10 = (DateTime)0 <= dateTime4;
		bool flag11 = !flag10;
		num = unchecked((nint)null);
		dateTime3 = dateTime4;
		if (!flag11)
		{
			goto IL_0348;
		}
		goto IL_040b;
		IL_040b:
		object obj17 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 488;
		object obj18 = (nint)0 + (nint)2760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj18);
		object obj19 = Enumerable.FirstOrDefault(<NotificationViews>k__BackingField, func);
		if (obj19 != null)
		{
			bool flag12 = ((NotificationView)obj19).IsDismissed((Notification)obj3);
			return (byte)((flag12 ? 1u : 0u) ^ 1u) != 0;
		}
		return true;
		IL_015b:
		return false;
		IL_0348:
		return false;
		IL_0118:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v5+48]");
		bool flag13 = (DateTime)0 >= dateTime;
		bool flag14 = !flag13;
		num = unchecked((nint)null);
		notification2 = (Notification)dateTime;
		if (!flag14)
		{
			goto IL_015b;
		}
		goto IL_021e;
		IL_021e:
		obj4 = obj3;
		if (obj3 != null)
		{
			goto IL_0243;
		}
		goto IL_04a6;
	}

	private bool PassesForcedFiltersCheck(Notification notification)
	{
		//IL_0069: Expected I4, but got O
		if (notification != null)
		{
			if (notification.<forceDisplay>k__BackingField)
			{
				return PassesFiltersCheck(notification);
			}
			return false;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void PersistViews()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
		object key = "Network Authentication Required" + 2304;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string value = JsonMapper.ToJson(<NotificationViews>k__BackingField);
		Prefs.SetString((string)key, value);
	}

	private void LoadViews()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_007b: Expected O, but got I4
		object key = "Network Authentication Required" + 2304;
		List<object> list;
		if (Prefs.HasKey((string)key))
		{
			object defaultValue = (nint)0 + (nint)2000;
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 728;
			object obj2 = (nint)0 + (nint)1088;
			string text = Prefs.GetString((string)key, (string)defaultValue);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E949E4");
			List<object> list2 = default(List<object>);
			list = list2;
		}
		else
		{
			object obj5 = typeof(List<Tween>) + 1088;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list3 = default(List<object>);
			list3..ctor();
			list = list3;
		}
		object obj6 = this + 48;
		obj6 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public NotificationsManager()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E70B4]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2096;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2096;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}

	static NotificationsManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 3440;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OneShotEvent oneShotEvent = default(OneShotEvent);
		oneShotEvent..ctor();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v3+B8]");
		object obj4 = (nint)0 + (nint)8;
		obj4 = oneShotEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <OnLoggedIn>b__21_0(bool _)
	{
		OnNotificationsApplied();
	}

	private void <ShowForcedNotifications>b__24_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PrefabInitializer.InitializePrefab(forceNotificationUiRef, CanvasLayer.SecondaryCanvas);
	}
}
