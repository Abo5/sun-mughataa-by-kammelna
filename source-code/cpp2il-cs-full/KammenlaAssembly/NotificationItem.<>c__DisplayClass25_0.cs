using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util;
using Util.Extensions;

public class NotificationItem : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Button, TextMeshProUGUI> <>9__22_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal TextMeshProUGUI <Awake>b__22_0(Button b)
		{
			//IL_0011: Expected O, but got I
			if ((object)b != null)
			{
				object obj = (nint)0 + (nint)288;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
				TextMeshProUGUI result = default(TextMeshProUGUI);
				return result;
			}
			return (TextMeshProUGUI)(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass25_0
	{
		public Sprite sprite;

		public NotificationItem <>4__this;

		internal void <AssignImage>b__1()
		{
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			//IL_0067: Expected O, but got I4
			//IL_009f: Expected O, but got I
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Expected O, but got Unknown
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected I4, but got Unknown
			NotificationItem notificationItem = <>4__this;
			RectTransform rectTransform = notificationItem.imageMask.rectTransform;
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			Rect rect = rectTransform.rect;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			NotificationItem notificationItem2 = <>4__this;
			object obj4 = (nint)0 + (nint)3912;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			Texture2D texture = sprite.texture;
			int width = texture.width;
			object obj5 = default(object);
			if ((nint)obj5 < width)
			{
				Texture2D texture2 = sprite.texture;
				int height = texture2.height;
				Texture2D texture3 = sprite.texture;
				int width2 = texture3.width;
				object obj6 = obj5 * height;
				int num = obj6 / width2;
			}
			else
			{
				Texture2D texture4 = sprite.texture;
				int height2 = texture4.height;
				int num = height2;
			}
			object obj8 = default(object);
			object obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ X8_v11+398] (should have been resolved before IL gen)");
			NotificationItem notificationItem3 = <>4__this;
			GameObject gameObject = notificationItem3.imageLoading.gameObject;
			gameObject.SetActive(value: false);
			NotificationItem notificationItem4 = <>4__this;
			notificationItem4.image.enabled = true;
			NotificationItem notificationItem5 = <>4__this;
			notificationItem5.imageMask.sprite = notificationItem5.maskSprite;
			NotificationItem notificationItem6 = <>4__this;
			notificationItem6.image.sprite = sprite;
		}
	}

	private TextMeshProUGUI titleText;

	private TextMeshProUGUI subtitleText;

	private TextMeshProUGUI detailText;

	private TextMeshProUGUI sinceText;

	private Image deepArea;

	private Image imageMask;

	private Image image;

	private ElegantLoadingIndicator imageLoading;

	private Button[] primaryButtons;

	private Button showMoreButton;

	private CanvasGroup alphaGroup;

	private RectTransform container;

	private LayoutElement spacer;

	private TextMeshProUGUI[] actionTexts;

	private Notification _notification;

	private NotificationsCenterUI _manager;

	private LayoutElement detailsLayout;

	private bool isFullView;

	private Sprite maskSprite;

	private ScrollRect _parentScroller;

	private LayoutElement _containerLayout;

	private bool ignoreSwipe;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0281: Expected O, but got I4
		//IL_0313: Expected O, but got I
		//IL_0324: Expected O, but got I
		//IL_0334: Expected O, but got I
		//IL_0356: Expected O, but got I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_00df: Expected O, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02b9: Expected O, but got I
		//IL_02ca: Expected I, but got O
		//IL_02e8: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_0106: Expected O, but got I
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_015f: Expected O, but got I
		//IL_0189: Expected I, but got O
		//IL_01b8: Expected O, but got I
		//IL_01d0: Expected I, but got O
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0255: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1096;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj4 = (nint)0 + (nint)2968;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v13+8]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v13+8]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v19+B8]");
				obj5 = 0;
			}
			object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 352;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)2616;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj5, (IntPtr)obj10);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v18+B8]");
			object obj12 = (nint)0 + (nint)8;
			obj12 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<object> source = Enumerable.Select(primaryButtons, selector);
		object[] array = Enumerable.ToArray(source);
		object obj13 = this + 136;
		obj13 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X20_v4-58]");
		Transform transform = ((TMP_Text)0).transform;
		Transform parent = transform.parent;
		object obj14 = (nint)0 + (nint)3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj15 = this + 160;
		object obj16 = default(object);
		obj15 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj17 = obj15;
		object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj19 = (nint)0 + (nint)3504;
		object obj20 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v239 @ X8_v9+398] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj19);
		ComponentListsExtensions.AddClickListeners(primaryButtons, unityAction);
		Button button = showMoreButton;
		object obj21 = (nint)0 + (nint)3512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj21);
		button.m_OnClick.AddListener(unityAction2);
		Image image = imageMask;
		object obj22 = this + 176;
		obj22 = image.m_Sprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X20_v11-20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X20_v11-20]");
			Populate((Notification)0, _manager);
		}
	}

	public void Populate(Notification notification, NotificationsCenterUI manager)
	{
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_0037: Expected O, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_006f: Expected O, but got I
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_0491: Expected O, but got I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0150: Expected O, but got I
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_0249: Expected O, but got I4
		//IL_04ca: Expected O, but got I
		//IL_02a4: Expected O, but got I
		//IL_02d7: Expected O, but got I
		//IL_02f1: Expected O, but got I4
		//IL_036a: Expected O, but got I
		object obj = this + 152;
		obj = manager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 144;
		obj2 = notification;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = base.gameObject;
		if (!gameObject.activeInHierarchy)
		{
			return;
		}
		object obj3 = (nint)0 + (nint)504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
		object obj4 = this + 184;
		object obj5 = default(object);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = (nint)0 + (nint)3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj7 = this + 192;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = (nint)0 + (nint)2000;
		TextMeshProExtensions.FixArabic(text: (string)((notification.<title>k__BackingField != null) ? notification.<title>k__BackingField : obj9), textMesh: titleText);
		TextMeshProExtensions.FixArabic(text: (string)((notification.<subtitle>k__BackingField != null) ? notification.<subtitle>k__BackingField : obj9), textMesh: subtitleText);
		TextMeshProExtensions.FixArabic(detailText, notification.<details>k__BackingField);
		object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v25+E4]");
		bool flag = (nint)0 == 0;
		object obj12 = !flag;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object input = "SetRoomVariables request error" + 880;
		string text = LocalizationUtil.Localize((string)input);
		string text2 = GetSinceText();
		object obj13 = (nint)0 + (nint)3072;
		string text3 = text + (string)obj13 + text2;
		TextMeshProExtensions.FixArabic(sinceText, text3);
		Notification notification2 = _notification;
		ComponentListsExtensions.FixArabic(text: (string)((notification2.<buttonText>k__BackingField != null) ? notification2.<buttonText>k__BackingField : obj9), textMeshes: actionTexts);
		AssignImage();
		bool active = _notification.HasRouting();
		ComponentListsExtensions.SetActive(primaryButtons, active);
		GameObject gameObject2 = showMoreButton.gameObject;
		object obj14 = obj2;
		object obj15 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v23+E4]");
		bool flag2 = (nint)0 == 0;
		object obj17 = !flag2;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v20+28]");
		bool flag3 = StringsExtensions.IsNullOrEmpty((string)0);
		bool active2 = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
		gameObject2.SetActive(active2);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v24+40]");
		object obj19 = (nint)0 & (nint)1;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v24+50]");
			object obj20 = (nint)0 & (nint)1;
			bool flag4 = obj20 == null;
			object obj21 = !flag4;
			if (obj21 != null)
			{
				return;
			}
		}
		Transform transform = sinceText.transform;
		GameObject gameObject3 = transform.gameObject;
		gameObject3.SetActive(value: false);
		Transform transform2 = sinceText.transform;
		Transform parent = transform2.parent;
		object obj22 = (nint)0 + (nint)264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		Component component = default(Component);
		if ((object)component != null)
		{
			GameObject gameObject4 = component.gameObject;
			gameObject4.SetActive(value: false);
		}
	}

	private string GetSinceText()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_015a: Expected O, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0073: Expected O, but got I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0131: Expected O, but got I4
		Notification notification = _notification;
		if (_notification != null)
		{
			object obj = (??)notification.<startDate>k__BackingField & 1;
			if (obj == null)
			{
				return (string)((nint)0 + (nint)2000);
			}
			object obj2 = typeof(DataRelation) + 712;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime utcNow = DateTime.UtcNow;
			Notification notification2 = _notification;
			if (_notification != null)
			{
				DateTime? dateTime = default(DateTime?);
				DateTime value = dateTime.Value;
				DateTime dateTime3 = default(DateTime);
				DateTime dateTime2 = dateTime3.ToUniversalTime();
				TimeSpan timeSpan = utcNow - dateTime2;
				object obj5 = typeof(DataRelation) + 824;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v16+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				return DateTimeUtil.GetDurationText(timeSpan, 1, DateTimeUnit.Seconds);
			}
		}
		return (string)(object)new NullReferenceException();
	}

	private void AssignImage()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I
		//IL_0107: Expected O, but got I4
		//IL_0069: Expected O, but got I
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0154: Expected O, but got I
		//IL_0162: Expected I, but got O
		Notification notification = _notification;
		ImageInfoModel<ImageCacher.NotificationImageType> <smallImage>k__BackingField = notification.<smallImage>k__BackingField;
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (ImageInfoModel`1<ImageCacher+NotificationImageType>)+10]");
			if (StringsExtensions.IsNullOrEmpty((string)0))
			{
				goto IL_0086;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v5 (ImageInfoModel`1<ImageCacher+NotificationImageType>)+10]");
			bool flag = StringsExtensions.IsNullOrEmpty((string)0);
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_0086;
			}
		}
		image.enabled = false;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj5 = (nint)0 + (nint)3464;
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj5);
		UIExtensions.LoadNotificationImage(image, _notification, ImageCacher.NotificationImageType.Small, setNative: false, action);
		return;
		IL_0086:
		Transform transform = imageMask.transform;
		Transform parent = transform.parent;
		GameObject gameObject = parent.gameObject;
		gameObject.SetActive(value: false);
	}

	private void UpdatePrimaryButton()
	{
		bool active = _notification.HasRouting();
		ComponentListsExtensions.SetActive(primaryButtons, active);
	}

	private void OnPrimaryButtonClick()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0061: Expected O, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		Notification notification = _notification;
		string payload = _notification.ComputeRoutingParam();
		Notification notification2 = _notification;
		object obj = typeof(RegisteredWaitHandle) + 1552;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoutingManager.Route(notification.<routingCommand>k__BackingField, payload, notification2.<routingGame>k__BackingField);
		Notification notification3 = _notification;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ITrackEvent trackEvent = TrackerLibrary.NotificationActionClicked(notification3.<id>k__BackingField);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public void ToggleShowMore()
	{
		//IL_019a: Expected O, but got I4
		//IL_01c8: Expected O, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_0109: Expected O, but got I4
		//IL_01ba: Expected O, but got I4
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_024d: Expected O, but got I4
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04e8: Expected O, but got I
		//IL_0501: Expected F4, but got O
		//IL_0501: Expected O, but got I4
		//IL_050e: Expected F8, but got I4
		//IL_051f: Expected F8, but got I4
		//IL_0528: Expected F8, but got I4
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_0539: Expected O, but got I
		//IL_0563: Expected O, but got I4
		//IL_058e: Expected O, but got I
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Expected O, but got Unknown
		//IL_05d3: Expected O, but got I4
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected O, but got Unknown
		//IL_0601: Expected O, but got I
		//IL_060f: Expected I, but got O
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_0351: Expected O, but got I
		//IL_038a: Expected O, but got I4
		//IL_02ab: Expected O, but got I
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_0314: Expected O, but got I4
		//IL_0635: Expected F8, but got I4
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03d1: Expected O, but got I
		//IL_03df: Expected I, but got O
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_0422: Expected O, but got I4
		float preferredHeight = sinceText.preferredHeight;
		float preferredHeight2 = detailText.preferredHeight;
		object obj2 = default(object);
		object obj = obj2 + obj2;
		double num = (double)obj + 30.0;
		float preferredHeight3 = sinceText.preferredHeight;
		double num2 = (double)obj / num;
		double num3 = num2 * 1053273621.0;
		object obj6 = default(object);
		if (isFullView)
		{
			_manager.ShowAll(this);
			ScrollRect parentScroller = _parentScroller;
			Rect rect = parentScroller.m_Viewport.rect;
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v67+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Rect rect2 = container.rect;
			float preferredHeight4 = (float)obj6 - (float)obj6;
			spacer.preferredHeight = preferredHeight4;
			object obj7 = typeof(UsageHint) + 744;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v62+B8]");
			object obj9 = 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOPreferredSize(spacer, (Vector2)0, (float)obj9);
			double num4 = 0.0;
			double num5 = num3;
			num = 0.0;
			num3 = 0.0;
		}
		else
		{
			float preferredHeight5 = detailText.preferredHeight;
			bool flag2 = _notification.HasRouting();
			bool flag3 = !flag2;
			object obj10 = !flag3;
			object obj11 = ~obj10;
			object obj12 = ((obj11 != null) ? ((object)0) : ((object)1121714176));
			spacer.preferredHeight = 0f;
			_manager.HideAllBut(this);
			ScrollRect parentScroller2 = _parentScroller;
			Rect rect3 = parentScroller2.m_Viewport.rect;
			object obj13 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v43+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Rect rect4 = container.rect;
			object obj16 = obj6 - obj6;
			object obj17 = typeof(UsageHint) + 744;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X8_v38+B8]");
			object obj19 = 0;
			float num6 = (float)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v39+10]");
			float duration = num6 * 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X8_v39+14]");
			object obj20 = obj16 * 0;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOPreferredSize(spacer, (Vector2)0, duration);
			object obj21 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj22 = (nint)0 + (nint)3496;
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(this, (IntPtr)obj22);
			object obj23 = (nint)0 + (nint)2488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			Notification notification = _notification;
			ITrackEvent trackEvent = TrackerLibrary.NotificationReadMoreClicked(notification.<id>k__BackingField);
			object obj24 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj25 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v51+E4]");
			bool flag5 = (nint)0 == 0;
			object obj26 = !flag5;
			if (obj26 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			double num4 = num2 + (double)obj12;
			Tracker.DesignEvent(trackEvent);
			double num5 = 0.0;
		}
		object obj27 = (nint)0 + (nint)2760;
		double num7 = 1050253722.0 - num3;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = DOTweenModuleUI.DOPreferredSize(detailsLayout, (Vector2)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj28 = typeof(SqlSingle[]) + 3912;
		object obj29 = (nint)0 + (nint)2792;
		RectTransform rectTransform = deepArea.rectTransform;
		object obj30 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj31 = !flag6;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float endValue = (float)(0.0 - num);
		Tween tween = AnimationExtensions.DOOffsetMinY(rectTransform, endValue, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		if (isFullView)
		{
			object obj32 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj33 = (nint)0 + (nint)3488;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj33);
			object obj34 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v26+E4]");
			bool flag7 = (nint)0 == 0;
			object obj36 = !flag7;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.3f, action);
		}
		else
		{
			Transform transform = showMoreButton.transform;
			Transform parent = transform.parent;
			GameObject gameObject = parent.gameObject;
			gameObject.SetActive(value: false);
		}
		bool flag8 = (byte)((isFullView ? 1u : 0u) ^ 1u) != 0;
		isFullView = flag8;
	}

	public void OnSwiping(SwipeGesture swipe)
	{
		//IL_0428: Expected O, but got I4
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_003e: Invalid comparison between F4 and I4
		//IL_010d: Expected O, but got I4
		//IL_0143: Expected I, but got O
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_01a3: Expected O, but got I4
		//IL_023f: Expected O, but got I4
		//IL_033d: Invalid comparison between F4 and I4
		//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_027d: Invalid comparison between F4 and I4
		//IL_0595: Expected O, but got I
		//IL_05d1: Invalid comparison between F4 and I4
		//IL_05e0: Invalid comparison between F4 and I4
		//IL_05f3: Expected O, but got F8
		//IL_0600: Expected O, but got F4
		//IL_0635: Expected O, but got I4
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0642: Expected O, but got Unknown
		//IL_02a2: Invalid comparison between F4 and I4
		//IL_037b: Invalid comparison between F4 and I4
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_0477: Expected O, but got I
		//IL_04b3: Invalid comparison between F4 and I4
		//IL_04c2: Invalid comparison between F4 and I4
		//IL_04d5: Expected O, but got F8
		//IL_04e2: Expected O, but got F4
		//IL_0517: Expected O, but got I4
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		bool flag = !ignoreSwipe;
		object obj = !flag;
		if (obj == null && (!DirectionExtensions.IsVertical(swipe.CardinalDirection) || !(swipe.TravelDistance < 1.128792E+09f)))
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				if (DOTween.IsTweening(container))
				{
					goto IL_00c2;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag2 = DOTween.IsTweening(container);
				bool flag3 = !flag2;
				object obj4 = !flag3;
				if (obj4 != null)
				{
					goto IL_00c2;
				}
			}
			_containerLayout.enabled = true;
			LayoutElement containerLayout = _containerLayout;
			nint num = (nint)containerLayout;
			containerLayout.ignoreLayout = true;
			Rect rect = container.rect;
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v15+E4]");
			bool flag4 = (nint)0 == 0;
			object obj7 = !flag4;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float preferredHeight = default(float);
			spacer.preferredHeight = preferredHeight;
			_parentScroller.enabled = false;
			object obj8 = swipe.EndPosition - swipe.StartPosition;
			float scaleFactor = ScreenUtility.ScaleFactor;
			float value = (float)obj8 * scaleFactor;
			UIExtensions.MoveTo(x: value, gObject: container, isWorldPositions: false, y: (float?)(object)0);
			if (DirectionExtensions.IsHorizontal(swipe.CardinalDirection) && swipe.SwipeSameness > 1.06032006E+09f && swipe.TravelDistance > 1.128792E+09f)
			{
				float alpha = alphaGroup.alpha;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4024;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X8_v40+B8]");
				object obj11 = 0;
				float num2 = alpha * 897988540f;
				double num3 = (double)obj11 * 8.0;
				float num4 = num2 - (float)num3;
				bool flag5 = num4 < 0f;
				bool flag6 = num4 == 0f;
				object obj12 = (double)num2 ^ num3;
				object obj13 = num2 ^ num4;
				object obj14 = obj12 & obj13;
				bool flag7 = (nint)obj14 < 0;
				bool flag8 = flag5 == flag7;
				object obj15 = !flag6;
				object obj16 = flag8 & obj15;
				object obj17 = ~obj16;
				double num5 = ((obj17 != null) ? num3 : ((double)num2));
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
				if (1.0 < num5)
				{
					int num6 = ShortcutExtensions.DOKill(alphaGroup);
					TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(alphaGroup, 0.5f, 0.2f);
				}
			}
			bool flag9 = DirectionExtensions.IsHorizontal(swipe.CardinalDirection);
			if (!(swipe.TravelDistance > 1.128792E+09f) || !flag9 || !(swipe.SwipeSameness > 1.06032006E+09f))
			{
				float alpha2 = alphaGroup.alpha;
				object obj18 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4024;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
				object obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v23+B8]");
				object obj20 = 0;
				float num7 = alpha2 * 897988540f;
				double num8 = (double)obj20 * 8.0;
				float num9 = num7 - (float)num8;
				bool flag10 = num9 < 0f;
				bool flag11 = num9 == 0f;
				object obj21 = (double)num7 ^ num8;
				object obj22 = num7 ^ num9;
				object obj23 = obj21 & obj22;
				bool flag12 = (nint)obj23 < 0;
				bool flag13 = flag10 == flag12;
				object obj24 = !flag11;
				object obj25 = flag13 & obj24;
				object obj26 = ~obj25;
				double num10 = ((obj26 != null) ? num8 : ((double)num7));
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
				if (!(1.0 < num10))
				{
					int num11 = ShortcutExtensions.DOKill(alphaGroup);
					TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTweenModuleUI.DOFade(alphaGroup, 1f, 0.2f);
				}
			}
			return;
		}
		goto IL_00c2;
		IL_00c2:
		ignoreSwipe = true;
		CancelSwipe();
	}

	public void OnSwiped(SwipeGesture swipe)
	{
		//IL_0051: Expected O, but got I4
		//IL_022e: Expected O, but got I4
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0086: Invalid comparison between F4 and I4
		//IL_0095: Invalid comparison between F4 and I4
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00c0: Expected O, but got F4
		//IL_026b: Expected O, but got I4
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_011f: Invalid comparison between F4 and I4
		//IL_012e: Invalid comparison between F4 and I4
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0159: Expected O, but got F4
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_02b3: Expected O, but got I
		//IL_02ef: Invalid comparison between F4 and I4
		//IL_02fe: Invalid comparison between F4 and I4
		//IL_0311: Expected O, but got F8
		//IL_031e: Expected O, but got F4
		//IL_0353: Expected O, but got I4
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_01f6: Expected O, but got I4
		ignoreSwipe = false;
		_parentScroller.enabled = true;
		bool flag = DirectionExtensions.IsHorizontal(swipe.CardinalDirection);
		bool flag2 = !flag;
		object obj = !flag2;
		object obj2 = ~obj;
		bool flag3;
		bool flag4;
		bool flag5;
		if (obj2 == null)
		{
			float num = swipe.SwipeSameness - 1.06032006E+09f;
			flag3 = num < 0f;
			flag4 = num == 0f;
			object obj3 = swipe.SwipeSameness ^ 0x3F333333;
			object obj4 = swipe.SwipeSameness ^ num;
			object obj5 = obj3 & obj4;
			flag5 = (nint)obj5 < 0;
		}
		else
		{
			flag5 = false;
			flag4 = true;
			flag3 = false;
		}
		bool flag6 = flag3 == flag5;
		object obj6 = !flag4;
		object obj7 = flag6 & obj6;
		object obj8 = ~obj7;
		bool flag7;
		bool flag8;
		bool flag9;
		if (obj8 == null)
		{
			float num2 = swipe.TravelDistance - 1.128792E+09f;
			flag7 = num2 < 0f;
			flag8 = num2 == 0f;
			object obj9 = swipe.TravelDistance ^ 0x43480000;
			object obj10 = swipe.TravelDistance ^ num2;
			object obj11 = obj9 & obj10;
			flag9 = (nint)obj11 < 0;
		}
		else
		{
			flag9 = false;
			flag8 = true;
			flag7 = false;
		}
		bool flag10 = flag7 == flag9;
		object obj12 = !flag10;
		object obj13 = obj12 | flag8;
		if (obj13 == null)
		{
			float alpha = alphaGroup.alpha;
			object obj14 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4024;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FMAXNM not yet implemented.\"");
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v8+B8]");
			object obj16 = 0;
			float num3 = alpha * 897988540f;
			double num4 = (double)obj16 * 8.0;
			float num5 = num3 - (float)num4;
			bool flag11 = num5 < 0f;
			bool flag12 = num5 == 0f;
			object obj17 = (double)num3 ^ num4;
			object obj18 = num3 ^ num5;
			object obj19 = obj17 & obj18;
			bool flag13 = (nint)obj19 < 0;
			bool flag14 = flag11 == flag13;
			object obj20 = !flag12;
			object obj21 = flag14 & obj20;
			object obj22 = ~obj21;
			double num6 = ((obj22 != null) ? num4 : ((double)num3));
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
			if (!(1.0 < num6))
			{
				object obj23 = swipe.CardinalDirection - 1;
				bool toRight = obj23 == null;
				DismissNotification(toRight, Ease.OutQuad);
				return;
			}
		}
		CancelSwipe();
	}

	private static bool WillDismiss(SwipeGesture swipe)
	{
		//IL_0039: Invalid comparison between F4 and I4
		//IL_006e: Invalid comparison between F4 and I4
		//IL_007d: Invalid comparison between F4 and I4
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00a8: Expected O, but got F4
		//IL_00dd: Expected O, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected I4, but got Unknown
		bool flag = DirectionExtensions.IsHorizontal(swipe.CardinalDirection);
		if (flag)
		{
			if (!(swipe.SwipeSameness > 1.06032006E+09f))
			{
				return false;
			}
			float num = swipe.TravelDistance - 1.128792E+09f;
			bool flag2 = num < 0f;
			bool flag3 = num == 0f;
			object obj = swipe.TravelDistance ^ 0x43480000;
			object obj2 = swipe.TravelDistance ^ num;
			object obj3 = obj & obj2;
			bool flag4 = (nint)obj3 < 0;
			bool flag5 = flag2 == flag4;
			object obj4 = !flag3;
			bool flag6 = (byte)((flag5 & obj4) ? 1 : 0) != 0;
			flag = flag6;
		}
		return flag;
	}

	private void CancelSwipe()
	{
		//IL_005b: Expected O, but got I
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0094: Expected O, but got I
		//IL_00a2: Expected I, but got O
		//IL_00b3: Expected O, but got I
		//IL_00e9: Expected I, but got O
		//IL_00f9: Expected O, but got I
		//IL_0109: Expected O, but got I
		if (_containerLayout.enabled)
		{
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosX(container, 0f, 0.5f);
			object obj = (nint)0 + (nint)2872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = (nint)0 + (nint)3472;
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(this, (IntPtr)obj3);
			object obj4 = (nint)0 + (nint)2488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			_containerLayout.enabled = false;
			LayoutElement containerLayout = _containerLayout;
			nint num = (nint)containerLayout;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v12 (Il2CppClass<UnityEngine.UI.LayoutElement>)+2F8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v12 (Il2CppClass<UnityEngine.UI.LayoutElement>)+300]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v96 @ X3_v3 (should have been resolved before IL gen)");
		}
	}

	public void ShowDismissHint()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010d: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01cd: Expected O, but got I4
		//IL_01fd: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		//IL_0169: Expected O, but got I4
		//IL_022d: Expected I, but got O
		//IL_0265: Expected O, but got I4
		//IL_02be: Expected O, but got I
		//IL_032c: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6335]");
		object obj3 = (nint)0 & (nint)1;
		object targetOrId;
		object targetOrId2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			targetOrId = container;
			targetOrId2 = container;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			targetOrId = container;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v27+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			targetOrId2 = container;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = DOTween.IsTweening(targetOrId2);
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		bool flag5 = false;
		if (obj6 != null)
		{
			return;
		}
		goto IL_0180;
		IL_0180:
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
		object message = "SubscribeGroup request Error" + 328;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v2+E4]");
		bool flag6 = (nint)0 == 0;
		object obj10 = !flag6;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Toast.Show((string)message, (Vector2)0, 0f);
		int num = ShortcutExtensions.DOKill(container);
		LayoutElement layoutElement = spacer;
		nint num2 = (nint)layoutElement;
		layoutElement.preferredHeight = 0f;
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v10+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosX(container, 300f, 0.5f);
		object obj13 = (nint)0 + (nint)2872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t = default(Tween);
		Sequence s2 = TweenSettingsExtensions.Append(s, t);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPosX(container, 0f, 0.5f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t2 = default(Tween);
		Sequence sequence = TweenSettingsExtensions.Append(s2, t2);
		object obj14 = (nint)0 + (nint)3256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
		return;
		IL_0091:
		bool flag8 = DOTween.IsTweening(targetOrId);
		bool flag9 = !flag8;
		obj7 = 0;
		flag5 = false;
		if (!flag9)
		{
			return;
		}
		goto IL_0180;
	}

	private void DismissNotification(bool toRight, Ease easing = Ease.InQuart)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0096: Expected O, but got I4
		//IL_00ee: Expected I, but got O
		//IL_010d: Expected O, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_012d: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_0172: Expected O, but got I4
		//IL_01de: Expected O, but got I
		//IL_0201: Expected O, but got I4
		//IL_01aa: Expected I, but got O
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_0266: Expected O, but got I
		//IL_027f: Expected F4, but got O
		//IL_027f: Expected O, but got I4
		_manager.DismissNotification(_notification);
		if (isFullView)
		{
			_manager.ShowAll(this);
		}
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = container.rect;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float preferredHeight = default(float);
		spacer.preferredHeight = preferredHeight;
		_containerLayout.enabled = true;
		LayoutElement containerLayout = _containerLayout;
		nint num = (nint)containerLayout;
		containerLayout.ignoreLayout = true;
		object obj4 = (nint)0 + (nint)2872;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj6 = (nint)0 + (nint)3480;
		object obj7 = (nint)0 + (nint)2488;
		Rect rect2 = container.rect;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X0_v17+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = (nint)0 + (nint)2760;
		float num2 = default(float);
		float endValue = 0f - num2;
		bool flag3 = !toRight;
		object obj11 = !flag3;
		object obj12 = ~obj11;
		if (obj12 == null)
		{
			endValue = num2;
		}
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosX(container, endValue, 0.3f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		object obj13 = typeof(UsageHint) + 744;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v13+B8]");
		object obj15 = 0;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOPreferredSize(spacer, (Vector2)0, (float)obj15);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
	}

	private void <AssignImage>b__25_0(bool success)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_009e: Expected O, but got I
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_00de: Expected I, but got O
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		if (success)
		{
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 24;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Image image = this.image;
			object obj4 = obj2 + 16;
			obj4 = image.m_Sprite;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Image obj5 = imageMask;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v9 (System.Object)+10]");
			obj5.sprite = (Sprite)0;
			object obj6 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = (nint)0 + (nint)2624;
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj7);
			object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v19+E4]");
			if ((nint)0 != 0)
			{
				CoroutineDummy.WaitForEndOfFrame(action);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			CoroutineDummy.WaitForEndOfFrame(action);
		}
		else
		{
			Transform transform = imageMask.transform;
			Transform parent = transform.parent;
			GameObject gameObject = parent.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private void <ToggleShowMore>b__28_1()
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		LayoutElement layoutElement = spacer;
		nint num = (nint)layoutElement;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.LayoutElement>)+398]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.LayoutElement>)+3A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void <ToggleShowMore>b__28_0()
	{
		Transform transform = showMoreButton.transform;
		Transform parent = transform.parent;
		GameObject gameObject = parent.gameObject;
		gameObject.SetActive(value: true);
	}

	private void <CancelSwipe>b__32_0()
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		LayoutElement layoutElement = spacer;
		nint num = (nint)layoutElement;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.LayoutElement>)+398]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<UnityEngine.UI.LayoutElement>)+3A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void <DismissNotification>b__34_0()
	{
		//IL_0015: Expected O, but got I4
		container.localScale = (Vector3)0;
	}
}
