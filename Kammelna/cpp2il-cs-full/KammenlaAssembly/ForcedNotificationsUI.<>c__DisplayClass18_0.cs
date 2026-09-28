using System;
using System.Buffers.Text;
using System.Collections.Generic;
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
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ForcedNotificationsUI : MonoBehaviour
{
	private sealed class <>c__DisplayClass18_0
	{
		public Notification notification;

		public ForcedNotificationsUI <>4__this;

		internal void <LoadNotifications>b__0()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0093: Expected O, but got I4
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			ForcedNotificationsUI forcedNotificationsUI = <>4__this;
			if (!forcedNotificationsUI.ignoreClicks)
			{
				Notification notification = this.notification;
				string payload = this.notification.ComputeRoutingParam();
				Notification notification2 = this.notification;
				object obj = typeof(RegisteredWaitHandle) + 1552;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				RoutingManager.Route(notification.<routingCommand>k__BackingField, payload, notification2.<routingGame>k__BackingField);
				<>4__this.Close();
				Notification notification3 = this.notification;
				ITrackEvent trackEvent = TrackerLibrary.ForcedNotificationActionClicked(notification3.<id>k__BackingField);
				object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v13+E4]");
				if ((nint)0 != 0)
				{
					Tracker.DesignEvent(trackEvent);
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Tracker.DesignEvent(trackEvent);
			}
		}
	}

	private sealed class <>c__DisplayClass19_0
	{
		public ForcedNotificationsUI <>4__this;

		public Notification notification;

		internal void <OnImageLoaded>b__0(bool success)
		{
			ForcedNotificationsUI forcedNotificationsUI = <>4__this;
			if (success)
			{
				int num = forcedNotificationsUI.ImagesToLoad - 1;
				bool flag = num == 1;
				forcedNotificationsUI.ImagesToLoad = num;
				if (flag)
				{
					forcedNotificationsUI.Show();
				}
			}
			else
			{
				bool flag2 = ((List<object>)(object)forcedNotificationsUI._forcedNotifications).Remove((object)notification);
				<>4__this.LoadNotifications();
			}
		}
	}

	private PopupUI popupUi;

	private RectTransform itemsList;

	private Image notificationItemPrefab;

	private DiscreteProgressIndicator pagination;

	private Button nextButton;

	private Button previousButton;

	private Button closeButton;

	private MainMenuEventsChannel _mainMenuEventsChannel;

	private int currentPage;

	private int numPages;

	private int ImagesToLoad;

	private bool ignoreClicks;

	private List<Notification> _forcedNotifications;

	private float ItemsSpacing
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0052: Expected O, but got I4
			//IL_0088: Invalid comparison between F4 and I4
			//IL_0097: Invalid comparison between F4 and I4
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Expected O, but got Unknown
			//IL_00b8: Expected O, but got F4
			//IL_00ed: Expected O, but got I4
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			//IL_0143: Invalid comparison between F4 and I4
			//IL_011a: Expected F4, but got I4
			//IL_0135: Expected F4, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			Rect rect = itemsList.rect;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num2 = default(float);
			float num = num2 - 1.1762565E+09f;
			bool flag2 = num < 0f;
			bool flag3 = num == 0f;
			object obj4 = num2 ^ 0x461C4000;
			object obj5 = num2 ^ num;
			object obj6 = obj4 & obj5;
			bool flag4 = (nint)obj6 < 0;
			bool flag5 = flag2 == flag4;
			object obj7 = !flag3;
			object obj8 = flag5 & obj7;
			object obj9 = ~obj8;
			float result = ((obj9 != null) ? num2 : 1.1762565E+09f);
			if (num2 < 1.1523195E+09f)
			{
				result = 1.1523195E+09f;
			}
			return result;
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0286: Expected I, but got O
		//IL_02b0: Expected O, but got I4
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0080: Expected O, but got I
		//IL_0098: Expected I, but got O
		//IL_00ca: Expected O, but got I
		//IL_00e2: Expected I, but got O
		//IL_0114: Expected O, but got I
		//IL_012c: Expected I, but got O
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0151: Expected O, but got I
		//IL_018d: Expected O, but got I4
		//IL_01c5: Expected O, but got I
		//IL_0227: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 848;
		object obj2 = (nint)0 + (nint)2088;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		NotificationsManager.OnNotificationsReceived += action;
		Button button = nextButton;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj7 = (nint)0 + (nint)2080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj7);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = previousButton;
		object obj8 = (nint)0 + (nint)2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj8);
		button2.m_OnClick.AddListener(unityAction2);
		Button button3 = closeButton;
		object obj9 = (nint)0 + (nint)2072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj9);
		object obj10 = typeof(Queue<string>) + 792;
		object obj11 = (nint)0 + (nint)2104;
		button3.m_OnClick.AddListener(unityAction3);
		object obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v18+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj14 = (nint)0 + (nint)2288;
		NotificationsManager notificationsManager = default(NotificationsManager);
		List<Notification> activeNotifications = notificationsManager.ActiveNotifications;
		if (Enumerable.Any((IEnumerable<object>)activeNotifications))
		{
			object obj15 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v24+E4]");
			bool flag3 = (nint)0 == 0;
			object obj16 = !flag3;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			NotificationsManager notificationsManager2 = default(NotificationsManager);
			List<Notification> activeNotifications2 = notificationsManager2.ActiveNotifications;
			OnNotificationsReceived(null);
		}
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
		object obj2 = (nint)0 + (nint)2088;
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
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0172: Expected O, but got I
		//IL_018d: Expected O, but got I
		//IL_01a7: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6318]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2104;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
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
			object obj4 = (nint)0 + (nint)2104;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0133;
		IL_0133:
		NotificationsManager notificationsManager = default(NotificationsManager);
		List<Notification> activeForcedNotifications = notificationsManager.ActiveForcedNotifications;
		object obj8 = this + 112;
		obj8 = activeForcedNotifications;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X20_v5-50]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v4+58]");
		object obj10 = (nint)0 & (nint)1;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		if (obj11 == null && Enumerable.Any((IEnumerable<object>)obj8))
		{
			LoadNotifications();
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)notificationsManager == null;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	private unsafe void LoadNotifications()
	{
		//IL_0016: Expected O, but got I
		//IL_00e0: Expected O, but got I
		//IL_00f6: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_005f: Expected O, but got I
		//IL_00ac: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected I4, but got Unknown
		//IL_01b1: Expected O, but got I4
		//IL_01d2: Unsupported input type for neg.
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0253: Expected O, but got I4
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected I4, but got Unknown
		//IL_026b: Expected O, but got I4
		//IL_0286: Expected O, but got I8
		//IL_0a30: Expected O, but got I8
		//IL_0298: Expected O, but got I8
		//IL_02d7: Expected O, but got I8
		//IL_02e5: Expected O, but got I4
		//IL_031e: Expected O, but got I8
		//IL_032c: Expected O, but got I4
		//IL_0379: Expected O, but got I8
		//IL_0394: Expected O, but got I
		//IL_03a0: Expected O, but got I
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03c0: Expected O, but got I
		//IL_040a: Expected O, but got I4
		//IL_0a4c: Expected O, but got I4
		//IL_0a98: Expected O, but got I8
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_048a: Expected O, but got I8
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Expected O, but got Unknown
		//IL_0504: Expected O, but got I8
		//IL_052f: Expected O, but got I
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_0585: Expected O, but got Unknown
		//IL_05af: Expected O, but got I4
		//IL_05d8: Expected O, but got I
		//IL_0608: Expected O, but got I8
		//IL_0660: Expected O, but got I8
		//IL_068e: Expected O, but got I
		//IL_06a6: Expected O, but got I
		//IL_06d7: Expected O, but got I
		//IL_0701: Expected O, but got I4
		//IL_0732: Expected O, but got I8
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Expected O, but got Unknown
		//IL_0779: Expected O, but got I4
		//IL_07a1: Expected O, but got I4
		//IL_07d2: Expected O, but got I8
		//IL_07f8: Expected O, but got I
		//IL_0813: Expected I, but got O
		//IL_0838: Expected O, but got I4
		//IL_0851: Expected I4, but got O
		//IL_0860: Expected O, but got I8
		//IL_088c: Expected O, but got I
		//IL_08c0: Expected O, but got I4
		//IL_08c9: Expected O, but got I4
		//IL_08f2: Expected O, but got I8
		//IL_08fc: Expected O, but got I4
		//IL_091d: Expected O, but got I
		//IL_092d: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63BA]");
		object obj = (nint)0 & (nint)1;
		int num;
		List<Notification> list;
		if (obj != null)
		{
			ResetUI();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63B9]");
			list = (List<Notification>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63B9]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			num = 152985600;
			if (!flag)
			{
				goto IL_0086;
			}
		}
		else
		{
			_ = 1;
			ResetUI();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63B9]");
			list = (List<Notification>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63B9]");
			object obj3 = (nint)0 & (nint)1;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			num = 152985600;
			if (obj4 != null)
			{
				goto IL_0086;
			}
		}
		_ = 1;
		RectTransform rectTransform = itemsList;
		bool flag3 = (object)itemsList == null;
		list = (List<Notification>)1;
		if (!flag3)
		{
			goto IL_0161;
		}
		goto IL_096e;
		IL_096e:
		throw new NullReferenceException();
		IL_0161:
		num = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = rectTransform.rect;
		int value = ((int*)num)->m_value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v9 (System.Int32)+E4]");
		bool flag4 = (nint)0 == 0;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = default(object);
		object obj6 = 0 - obj7;
		object obj8 = obj7 - 1176256512;
		bool flag5 = (nint)obj8 < 0;
		bool flag6 = obj8 == null;
		object obj9 = obj7 ^ 0x461C4000;
		object obj10 = obj7 ^ obj8;
		object obj11 = obj9 & obj10;
		bool flag7 = (nint)obj11 < 0;
		bool flag8 = flag5 == flag7;
		object obj12 = !flag6;
		bool flag9 = (byte)((flag8 & obj12) ? 1 : 0) != 0;
		object obj13 = !flag9;
		if (obj13 == null)
		{
			obj6 = 3323740160L;
		}
		object obj14 = (((nint)obj7 >= 1152319488) ? obj6 : ((object)3299803136L));
		list = _forcedNotifications;
		bool flag10 = _forcedNotifications == null;
		object obj15 = 3299803136L;
		if (!flag10)
		{
			ImagesToLoad = list._size;
			bool flag11 = (object)notificationItemPrefab == null;
			obj15 = 3299803136L;
			list = (List<Notification>)list._size;
			if (!flag11)
			{
				GameObject gameObject = notificationItemPrefab.gameObject;
				bool flag12 = (object)gameObject == null;
				obj15 = 3299803136L;
				list = (List<Notification>)list._size;
				if (!flag12)
				{
					gameObject.SetActive(value: true);
					list = _forcedNotifications;
					bool flag13 = _forcedNotifications == null;
					ImageCacher.NotificationImageType notificationImageType = ImageCacher.NotificationImageType.Small;
					obj15 = 3299803136L;
					if (!flag13)
					{
						object obj16 = (nint)0 + (nint)696;
						object obj17 = (nint)0 + (nint)3640;
						object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
						object obj19 = (nint)0 + (nint)568;
						object obj21 = default(object);
						object obj20 = obj21;
						bool flag15 = default(bool);
						bool flag14 = flag15;
						Action<bool> action2 = default(Action<bool>);
						Action<bool> action = action2;
						UnityEvent unityEvent2 = default(UnityEvent);
						UnityEvent unityEvent = unityEvent2;
						Image image2 = default(Image);
						Image image = image2;
						UnityAction unityAction2 = default(UnityAction);
						UnityAction unityAction = unityAction2;
						ImageCacher.NotificationImageType notificationImageType2 = ImageCacher.NotificationImageType.Small;
						object obj22 = obj6;
						UnityAction unityAction3 = (UnityAction)1;
						List<Notification> forcedNotifications = _forcedNotifications;
						int num2 = 0;
						object obj23 = default(object);
						Graphic graphic = default(Graphic);
						object obj30 = default(object);
						object obj31 = default(object);
						UnityAction unityAction4 = default(UnityAction);
						object obj32;
						do
						{
							list = (List<Notification>)forcedNotifications._size;
							flag9 = num2 >= forcedNotifications._size;
							unityEvent2 = unityEvent;
							image2 = image;
							unityAction2 = unityAction;
							notificationImageType = notificationImageType2;
							obj15 = 3299803136L;
							obj6 = obj22;
							num = num2;
							if (!flag9)
							{
								list = (List<Notification>)(typeof(DebugUI.BitField) + 3032);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								obj23..ctor();
								bool flag16 = obj23 == null;
								unityEvent2 = unityEvent;
								image2 = image;
								unityAction2 = unityAction;
								notificationImageType = notificationImageType2;
								obj15 = 3299803136L;
								obj6 = obj22;
								num = num2;
								if (flag16)
								{
									break;
								}
								object obj24 = obj23 + 24;
								obj24 = this;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								bool flag17 = _forcedNotifications == null;
								unityEvent2 = unityEvent;
								image2 = image;
								unityAction2 = unityAction;
								notificationImageType = notificationImageType2;
								obj15 = 3299803136L;
								obj6 = obj22;
								num = num2;
								if (flag17)
								{
									break;
								}
								object obj25 = (nint)0 + (nint)808;
								object obj26 = ((List<object>)(object)_forcedNotifications).get_Item(num2);
								unityAction2 = (UnityAction)(obj23 + 16);
								unityAction2 = (UnityAction)obj26;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								unityEvent2 = (UnityEvent)(object)notificationItemPrefab;
								object obj27 = typeof(MemberAchievementClanFeedData) + 2976;
								object obj28 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v23+E4]");
								bool flag18 = (nint)0 == 0;
								object obj29 = !flag18;
								if (obj29 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								list = (List<Notification>)((nint)0 + (nint)552);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
								bool flag19 = (object)graphic == null;
								image2 = (Image)(object)itemsList;
								obj15 = 3299803136L;
								obj6 = obj22;
								num = num2;
								if (flag19)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
								bool flag20 = obj30 == null;
								unityEvent2 = (UnityEvent)(object)graphic;
								image2 = (Image)(object)itemsList;
								obj15 = 3299803136L;
								obj6 = obj22;
								num = num2;
								if (flag20)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v27+18]");
								list = (List<Notification>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v27+28]");
								image2 = (Image)0;
								Action<bool> action3 = OnImageLoaded((Notification)(object)unityAction2);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v27+28]");
								UIExtensions.LoadNotificationImage((Image)0, (Notification)(object)unityAction2, ImageCacher.NotificationImageType.Large, setNative: false, action3);
								RectTransform rectTransform2 = graphic.rectTransform;
								bool flag21 = (object)rectTransform2 == null;
								obj21 = 0;
								flag15 = false;
								unityEvent2 = (UnityEvent)(object)graphic;
								unityAction2 = unityAction2;
								notificationImageType = ImageCacher.NotificationImageType.Large;
								obj15 = 3299803136L;
								obj6 = obj22;
								num = num2;
								if (flag21)
								{
									break;
								}
								Vector2 anchoredPosition = rectTransform2.anchoredPosition;
								obj6 = obj14 * num2;
								rectTransform2.anchoredPosition = (Vector2)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
								bool flag22 = obj31 == null;
								obj21 = 0;
								flag15 = false;
								unityEvent2 = (UnityEvent)(object)graphic;
								unityAction2 = (UnityAction)(object)rectTransform2;
								notificationImageType = ImageCacher.NotificationImageType.Large;
								obj15 = 3299803136L;
								num = num2;
								if (flag22)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v37+100]");
								unityEvent2 = (UnityEvent)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								unityAction4..ctor(obj23, (IntPtr)obj19);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v37+100]");
								bool flag23 = (nint)0 == 0;
								obj21 = 0;
								flag15 = false;
								unityAction2 = unityAction4;
								notificationImageType = (ImageCacher.NotificationImageType)obj19;
								obj15 = 3299803136L;
								num = num2;
								if (flag23)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v37+100]");
								((UnityEvent)0).AddListener(unityAction4);
								num = num2 + 1;
								list = _forcedNotifications;
								bool flag24 = _forcedNotifications == null;
								obj32 = !flag24;
								obj21 = 0;
								flag15 = false;
								unityAction2 = unityAction4;
								notificationImageType = ImageCacher.NotificationImageType.Small;
								obj15 = 3299803136L;
								obj20 = 0;
								flag14 = false;
								action = action3;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v37+100]");
								unityEvent = (UnityEvent)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v27+28]");
								image = (Image)0;
								unityAction = unityAction4;
								notificationImageType2 = ImageCacher.NotificationImageType.Small;
								obj22 = obj6;
								unityAction3 = unityAction4;
								forcedNotifications = _forcedNotifications;
								num2 = num;
								continue;
							}
							if ((object)notificationItemPrefab == null)
							{
								break;
							}
							GameObject gameObject2 = notificationItemPrefab.gameObject;
							if ((object)gameObject2 == null)
							{
								break;
							}
							gameObject2.SetActive(value: false);
							UpdateNavigation();
							return;
						}
						while (obj32 != null);
					}
				}
			}
		}
		goto IL_096e;
		IL_0086:
		rectTransform = itemsList;
		bool flag25 = (object)itemsList == null;
		object obj33 = !flag25;
		if (obj33 != null)
		{
			goto IL_0161;
		}
		goto IL_096e;
	}

	private Action<bool> OnImageLoaded(Notification notification)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0096: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 3040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj4 = (nint)0 + (nint)576;
			object obj5 = obj2 + 16;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj2 + 24;
			obj6 = notification;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<bool> action = default(Action<bool>);
			action..ctor(obj2, (IntPtr)obj4);
			return action;
		}
		return (Action<bool>)(object)new NullReferenceException();
	}

	public void OnSwiping(SwipeGesture swipeGesture)
	{
		ignoreClicks = true;
	}

	public void OnSwipe(SwipeGesture swipeGesture)
	{
		ignoreClicks = true;
		if (swipeGesture.CardinalDirection != GestureDirection.Left)
		{
			if (swipeGesture.CardinalDirection == GestureDirection.Right)
			{
				NextPage();
			}
			else
			{
				ignoreClicks = false;
			}
		}
		else
		{
			PreviousPage();
		}
	}

	private void ResetUI()
	{
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		if ((object)nextButton != null)
		{
			GameObject gameObject = nextButton.gameObject;
			if ((object)gameObject != null)
			{
				gameObject.SetActive(value: false);
				if ((object)previousButton != null)
				{
					GameObject gameObject2 = previousButton.gameObject;
					if ((object)gameObject2 != null)
					{
						gameObject2.SetActive(value: false);
						if ((object)closeButton != null)
						{
							GameObject gameObject3 = closeButton.gameObject;
							if ((object)gameObject3 != null)
							{
								gameObject3.SetActive(value: false);
								currentPage = 0;
								List<Notification> forcedNotifications = _forcedNotifications;
								if (_forcedNotifications != null)
								{
									numPages = forcedNotifications._size;
									if ((object)pagination != null)
									{
										object obj = typeof(TypeConverter<ushort, char>) + 2568;
										pagination.MaxProgress = forcedNotifications._size;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
										if ((object)notificationItemPrefab != null)
										{
											GameObject gameObject4 = notificationItemPrefab.gameObject;
											GameObject[] array = default(GameObject[]);
											if (array != null)
											{
												object obj2 = array + 32;
												obj2 = gameObject4;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												UIExtensions.DestroyAllChildren(itemsList, array);
												return;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private void UpdateNavigation()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0075: Expected I, but got O
		//IL_009f: Expected O, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_0120: Expected O, but got I4
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01e6: Expected O, but got I4
		//IL_0201: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2064;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		int currentProgress = currentPage + 1;
		pagination.CurrentProgress = currentProgress;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.3f, action);
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = itemsList.rect;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v14+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = default(object);
		object obj9 = obj10 - 1176256512;
		bool flag3 = (nint)obj9 < 0;
		bool flag4 = obj9 == null;
		object obj11 = obj10 ^ 0x461C4000;
		object obj12 = obj10 ^ obj9;
		object obj13 = obj11 & obj12;
		bool flag5 = (nint)obj13 < 0;
		bool flag6 = flag3 == flag5;
		object obj14 = !flag4;
		object obj15 = flag6 & obj14;
		object obj16 = ~obj15;
		object obj17 = ((obj16 != null) ? obj10 : ((object)1176256512));
		if ((nint)obj10 < 1152319488)
		{
			obj17 = 1152319488;
		}
		float endValue = (float)obj17 * (float)currentPage;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosX(itemsList, endValue, 0.3f);
	}

	private void NextPage()
	{
		//IL_0026: Expected O, but got I
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		int num = currentPage + 1;
		if (num < numPages)
		{
			currentPage = num;
			UpdateNavigation();
			object obj = (nint)0 + (nint)808;
			object obj2 = ((List<object>)(object)_forcedNotifications).get_Item(currentPage);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v6 (System.Object)+10]");
			ITrackEvent trackEvent = TrackerLibrary.ForcedNotificationViewed(0);
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v10+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
		}
		else
		{
			ignoreClicks = false;
		}
	}

	private void PreviousPage()
	{
		//IL_0026: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		int num = currentPage - 1;
		if (num >= 1)
		{
			currentPage = num;
			UpdateNavigation();
			object obj = (nint)0 + (nint)808;
			object obj2 = ((List<object>)(object)_forcedNotifications).get_Item(currentPage);
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v6 (System.Object)+10]");
			ITrackEvent trackEvent = TrackerLibrary.ForcedNotificationViewed(0);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v8+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
		}
		else
		{
			ignoreClicks = false;
		}
	}

	private void Show()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0148: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01ce: Expected O, but got I4
		//IL_0176: Expected O, but got I
		//IL_0190: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_027a: Expected O, but got I4
		//IL_0206: Expected O, but got I
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_022e: Expected O, but got I4
		//IL_02bd: Expected O, but got I
		//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		object obj = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E631D]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v24+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v24+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459A]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_019e;
		IL_023c:
		object obj7 = typeof(RegisteredWaitHandle) + 3136;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v2+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PreventBackAction();
		popupUi.SlideFromBottom();
		object obj10 = (nint)0 + (nint)808;
		object obj11 = ((List<object>)(object)_forcedNotifications).get_Item(currentPage);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v9 (System.Object)+10]");
		ITrackEvent trackEvent = TrackerLibrary.ForcedNotificationViewed(0);
		object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X8_v11+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v40+B8]");
		object obj14 = 0;
		object obj15 = obj14 & 1;
		if (obj15 != null)
		{
			return;
		}
		goto IL_023c;
		IL_01e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj16 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v18+B8]");
		object obj17 = 0;
		object obj18 = obj17 & 1;
		bool flag4 = obj18 == null;
		object obj19 = !flag4;
		if (obj19 != null)
		{
			return;
		}
		goto IL_023c;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE459A]");
		object obj20 = (nint)0 & (nint)1;
		if (obj20 != null)
		{
			goto IL_00a7;
		}
		goto IL_019e;
		IL_019e:
		_ = 1;
		object obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v40+E4]");
		bool flag5 = (nint)0 == 0;
		object obj22 = !flag5;
		object obj23 = obj21;
		if (obj22 != null)
		{
			goto IL_00dc;
		}
		goto IL_01e4;
		IL_00a7:
		obj21 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v40+E4]");
		bool flag6 = (nint)0 == 0;
		obj23 = obj21;
		if (!flag6)
		{
			goto IL_00dc;
		}
		goto IL_01e4;
	}

	private void Close()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0163: Expected O, but got I
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0183: Expected O, but got I
		//IL_01ad: Expected O, but got I4
		//IL_0052: Expected I, but got O
		//IL_0063: Expected O, but got I
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_012e: Expected O, but got I4
		object obj = typeof(Queue<string>) + 792;
		object obj2 = (nint)0 + (nint)2104;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2832;
		object obj4 = (nint)0 + (nint)3592;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		object obj7 = default(object);
		action..ctor(obj7, (IntPtr)obj4);
		object obj8 = (nint)0 + (nint)768;
		object obj9 = typeof(RegisteredWaitHandle) + 3136;
		((List<object>)(object)_forcedNotifications).ForEach(action);
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v11+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.AllowBackAction();
		object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		popupUi.SlideToBottom();
		ITrackEvent trackEvent = TrackerLibrary.ForcedNotificationDismissed();
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		_mainMenuEventsChannel.TriggerForcedNotificationsClosed();
	}

	private void <UpdateNavigation>b__23_0()
	{
		//IL_007e: Expected O, but got I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected I4, but got Unknown
		//IL_00c1: Expected O, but got I4
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected I4, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected I4, but got Unknown
		//IL_0166: Expected O, but got I4
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		GameObject gameObject = previousButton.gameObject;
		bool flag = currentPage < 0;
		bool flag2 = currentPage == 0;
		int num = currentPage ^ currentPage;
		int num2 = currentPage & num;
		bool flag3 = num2 < 0;
		bool flag4 = flag == flag3;
		object obj = !flag2;
		bool active = (byte)((flag4 & obj) ? 1 : 0) != 0;
		gameObject.SetActive(active);
		GameObject gameObject2 = nextButton.gameObject;
		object obj2 = currentPage + 1;
		object obj3 = obj2 - numPages;
		bool flag5 = (nint)obj3 < 0;
		int num3 = obj2 ^ numPages;
		object obj4 = obj2 ^ obj3;
		int num4 = num3 & obj4;
		bool flag6 = num4 < 0;
		bool flag7 = flag5 == flag6;
		bool active2 = !flag7;
		gameObject2.SetActive(active2);
		GameObject gameObject3 = closeButton.gameObject;
		object obj5 = currentPage + 1;
		object obj6 = obj5 - numPages;
		bool active3 = obj6 == null;
		gameObject3.SetActive(active3);
		ignoreClicks = false;
	}
}
