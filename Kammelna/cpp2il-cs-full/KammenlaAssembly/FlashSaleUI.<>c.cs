using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Server.Models;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class FlashSaleUI : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<AppAnnouncementTimingViewModel, DateTime> <>9__14_0;

		public static Func<AppAnnouncementTimingViewModel, bool> <>9__14_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 2880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal DateTime <Repopulate>b__14_0(AppAnnouncementTimingViewModel t)
		{
			return (DateTime)(((object?)t?.<DateTime>k__BackingField) ?? ((object)new NullReferenceException()));
		}

		internal bool <Repopulate>b__14_1(AppAnnouncementTimingViewModel t)
		{
			//IL_0097: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			if (t != null)
			{
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				return t.<DateTime>k__BackingField > now;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private Image image;

	private TextMeshProUGUI title;

	private TextMeshProUGUI subTitle;

	private DateTimeText timer;

	private PopupUI PopupUi;

	private MainMenuEventsChannel mainMenuEventsChannel;

	private bool _isSeen;

	private bool _wasVisibleBeforeGameHubShown;

	private AppAnnouncementModel _announcementModel;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_00c7: Expected I, but got O
		//IL_005d: Expected I, but got O
		//IL_006e: Expected O, but got I
		//IL_009a: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 712;
		object obj2 = (nint)0 + (nint)1744;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		InAppAnnouncementsManager.OnAnnouncementsReceived += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)1728;
		mainMenuEventsChannel.OnGameHubShown += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj5);
		mainMenuEventsChannel.OnGameHubHidden += action3;
	}

	private void OnEnable()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00cc: Expected O, but got I
		//IL_00f6: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_013f: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7923]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2056;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
			object obj4 = (nint)0 + (nint)2056;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
		InAppAnnouncementsManager inAppAnnouncementsManager = default(InAppAnnouncementsManager);
		bool flag3 = (object)inAppAnnouncementsManager == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		IEnumerable<AppAnnouncementModel> activeFlashSales = inAppAnnouncementsManager.ActiveFlashSales;
		Repopulate(null);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_00c7: Expected I, but got O
		//IL_005d: Expected I, but got O
		//IL_006e: Expected O, but got I
		//IL_009a: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 712;
		object obj2 = (nint)0 + (nint)1744;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		InAppAnnouncementsManager.OnAnnouncementsReceived -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)1728;
		mainMenuEventsChannel.OnGameHubShown -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj5);
		mainMenuEventsChannel.OnGameHubHidden -= action3;
	}

	private void HandleGameHubShown()
	{
		PopupUI popupUi = PopupUi;
		_wasVisibleBeforeGameHubShown = popupUi.<IsCurrentlyShown>k__BackingField;
		if (popupUi.<IsCurrentlyShown>k__BackingField)
		{
			popupUi.SlideToLeft();
		}
	}

	private void HandleGameHubHidden()
	{
		if (_wasVisibleBeforeGameHubShown)
		{
			AnimateIn();
		}
	}

	private void Repopulate(IEnumerable<AppAnnouncementModel> appAnnouncements)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_01ac: Expected O, but got I
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_0284: Expected O, but got I
		//IL_0294: Expected O, but got I
		//IL_02a4: Expected O, but got I
		//IL_02c6: Expected O, but got I4
		//IL_0208: Expected O, but got I
		//IL_0218: Expected O, but got I
		//IL_0228: Expected O, but got I
		//IL_024a: Expected O, but got I4
		//IL_0443: Expected O, but got I
		//IL_0453: Expected O, but got I
		//IL_0463: Expected O, but got I
		//IL_0485: Expected O, but got I4
		//IL_02fe: Expected O, but got I4
		//IL_0402: Expected O, but got I4
		//IL_0382: Expected O, but got I
		//IL_0392: Expected O, but got I
		//IL_03a2: Expected O, but got I
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected O, but got Unknown
		//IL_0624: Expected O, but got I
		//IL_0635: Expected I, but got O
		//IL_0653: Expected O, but got I
		//IL_066e: Expected O, but got I4
		//IL_0559: Expected O, but got I
		//IL_04bd: Expected O, but got I4
		//IL_032e: Expected O, but got I
		//IL_056e: Expected O, but got I
		//IL_0585: Expected O, but got I
		//IL_0596: Expected O, but got I4
		//IL_0692: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected O, but got Unknown
		//IL_06ad: Expected O, but got I
		//IL_06be: Expected I, but got O
		//IL_06dc: Expected O, but got I
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected O, but got Unknown
		//IL_05bb: Expected O, but got I
		//IL_05d3: Expected I, but got O
		//IL_0523: Expected O, but got I4
		//IL_052c: Expected O, but got I4
		//IL_04ed: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7925]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2056;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v46+E4]");
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
			object obj4 = (nint)0 + (nint)2056;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v46+E4]");
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
		IL_02dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v36+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		object obj10;
		object obj11;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v32+B8]");
			obj11 = 0;
		}
		object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)432;
		Func<object, DateTime> func = default(Func<object, DateTime>);
		func..ctor(obj11, (IntPtr)obj13);
		object obj14 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v31+B8]");
		object obj15 = (nint)0 + (nint)8;
		obj15 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj16 = 0;
		object obj18;
		object obj17 = obj18;
		Func<object, DateTime> keySelector = func;
		goto IL_0333;
		IL_03cf:
		object obj20;
		object obj19 = obj20;
		IOrderedEnumerable<object> source;
		Func<object, bool> func2;
		object obj21 = Enumerable.FirstOrDefault(source, func2);
		bool flag4 = obj21 == null;
		object obj22 = !flag4;
		if (obj22 != null)
		{
			goto IL_0542;
		}
		object obj23 = obj16;
		DateTime dateTime = (DateTime)func2;
		goto IL_059b;
		IL_0333:
		AppAnnouncementModel announcementModel;
		source = Enumerable.OrderBy(announcementModel.<AnnouncementTimings>k__BackingField, keySelector);
		object obj24 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v21+E4]");
		object obj25;
		object obj26;
		if ((nint)0 != 0)
		{
			obj20 = (nint)0 + (nint)616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v21+B8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v14+10]");
			func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v14+10]");
			bool flag5 = (nint)0 == 0;
			obj26 = obj20;
			if (!flag5)
			{
				goto IL_03cf;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj10;
			obj20 = (nint)0 + (nint)616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v21+B8]");
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v14+10]");
			func2 = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v14+10]");
			bool flag6 = (nint)0 == 0;
			object obj27 = !flag6;
			obj26 = obj20;
			if (obj27 != null)
			{
				goto IL_03cf;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X0_v21+E4]");
		bool flag7 = (nint)0 == 0;
		object obj28 = !flag7;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj29 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v20+B8]");
			obj25 = 0;
		}
		object obj30 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj31 = (nint)0 + (nint)440;
		Func<object, bool> func3 = default(Func<object, bool>);
		func3..ctor(obj25, (IntPtr)obj31);
		object obj32 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v19+B8]");
		object obj33 = (nint)0 + (nint)16;
		obj33 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj19 = obj26;
		obj21 = Enumerable.FirstOrDefault(source, func3);
		bool flag8 = obj21 == null;
		obj16 = 0;
		obj23 = 0;
		dateTime = (DateTime)func3;
		if (!flag8)
		{
			goto IL_0542;
		}
		goto IL_059b;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		InAppAnnouncementsManager inAppAnnouncementsManager = default(InAppAnnouncementsManager);
		bool flag9 = (object)inAppAnnouncementsManager == null;
		object obj34 = !flag9;
		if (obj34 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
		IL_0133:
		IEnumerable<AppAnnouncementModel> activeFlashSales = inAppAnnouncementsManager.ActiveFlashSales;
		object obj35 = Enumerable.FirstOrDefault((IEnumerable<object>)activeFlashSales);
		object obj36 = this + 88;
		obj36 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj37 = obj36;
		if (obj36 == null)
		{
			return;
		}
		TextMeshProUGUI textMesh = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v4+18]");
		TextMeshProExtensions.FixArabic(textMesh, (string)0);
		announcementModel = _announcementModel;
		obj10 = typeof(DebugUI.BitField) + 2880;
		object obj38 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v36+E4]");
		if ((nint)0 != 0)
		{
			obj17 = (nint)0 + (nint)2032;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v36+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v26+8]");
			keySelector = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v26+8]");
			bool flag10 = (nint)0 == 0;
			object obj39 = !flag10;
			if (obj39 == null)
			{
				obj18 = obj17;
				goto IL_02dc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj38 = obj10;
			obj18 = (nint)0 + (nint)2032;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v36+B8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v26+8]");
			keySelector = (Func<object, DateTime>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v26+8]");
			bool flag11 = (nint)0 == 0;
			object obj40 = !flag11;
			obj17 = obj18;
			if (obj40 == null)
			{
				goto IL_02dc;
			}
		}
		goto IL_0333;
		IL_059b:
		object obj41 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj42 = (nint)0 + (nint)1720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj42);
		UIExtensions.LoadAppAnnouncementImage(image, _announcementModel, setNative: false, action);
		return;
		IL_0542:
		TextMeshProUGUI textMesh2 = subTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v18 (System.Object)+10]");
		TextMeshProExtensions.FixArabic(textMesh2, (string)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v18 (System.Object)+18]");
		dateTime = (DateTime)0;
		DateTimeText dateTimeText = timer;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v18 (System.Object)+18]");
		dateTimeText.SetDate((DateTime)0);
		obj23 = obj16;
		obj19 = 0;
		goto IL_059b;
	}

	public void Route()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_007c: Expected O, but got I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		AppAnnouncementModel announcementModel = _announcementModel;
		if (_announcementModel != null)
		{
			object obj = typeof(RegisteredWaitHandle) + 1552;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RoutingManager.Route(announcementModel.<RoutingCommand>k__BackingField, announcementModel.<RoutingParam>k__BackingField, (Games?)(object)0);
			AppAnnouncementModel announcementModel2 = _announcementModel;
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			ITrackEvent trackEvent = TrackerLibrary.MenuFlashSaleClicked(announcementModel2.<Id>k__BackingField);
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v6+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent);
		}
	}

	private void AnimateIn()
	{
		//IL_002c: Expected O, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		PopupUi.SlideFromLeft();
		bool flag = !_isSeen;
		object obj = !flag;
		if (obj == null)
		{
			AppAnnouncementModel announcementModel = _announcementModel;
			ITrackEvent trackEvent = TrackerLibrary.MenuFlashSaleShown(announcementModel.<Id>k__BackingField);
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
		}
		_isSeen = true;
	}

	private void AnimateOut()
	{
		PopupUi.SlideToLeft();
	}

	private void <Repopulate>b__14_2(bool success)
	{
		if (success)
		{
			AnimateIn();
		}
	}
}
