using System;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using ListView;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class StoreBannerItem : ListViewItem<StoreDataHolder, int>
{
	private Image image;

	private Button activateButton;

	private ElegantLoadingIndicator loading;

	private StoreBannerViewModel _banner;

	public override void Setup(StoreDataHolder datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2016;
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		object obj2 = this + 152;
		obj2 = datum.BannerItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj2 != null)
		{
			LoadImage(datum.Type);
			StoreBannerViewModel banner = _banner;
			bool flag = banner.<routingCommand>k__BackingField == RoutingCommand.NO_MESSAGE;
			bool flag2 = !flag;
			activateButton.enabled = flag2;
		}
	}

	public void PopulateBanner(StoreBannerViewModel banner, ImageCacher.BannerSize type)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 152;
		obj = banner;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj != null)
		{
			LoadImage(type);
			StoreBannerViewModel banner2 = _banner;
			bool flag = banner2.<routingCommand>k__BackingField == RoutingCommand.NO_MESSAGE;
			bool flag2 = !flag;
			activateButton.enabled = flag2;
		}
	}

	private void LoadImage(ImageCacher.BannerSize type)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0174: Expected O, but got I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0199: Expected O, but got I
		//IL_01b1: Expected I, but got O
		//IL_00cb: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E69F2]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			obj5 = loading;
			obj6 = loading;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = loading;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = loading;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = 0;
		if (!flag4)
		{
			goto IL_0160;
		}
		goto IL_0179;
		IL_0179:
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj10 = (nint)0 + (nint)3984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj10);
		UIExtensions.LoadStoreBannerImage(image, _banner, type, setNative: false, action);
		return;
		IL_0160:
		loading.StartLoading();
		obj8 = 0;
		goto IL_0179;
		IL_0091:
		bool flag5 = obj5;
		bool flag6 = !flag5;
		object obj11 = !flag6;
		if (obj11 != null)
		{
			goto IL_0160;
		}
		obj8 = 0;
		goto IL_0179;
	}

	public void PerformAction()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		StoreBannerViewModel banner = _banner;
		object obj = typeof(RegisteredWaitHandle) + 1552;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoutingManager.Route(banner.<routingCommand>k__BackingField, banner.<routingParam>k__BackingField, banner.<routingGame>k__BackingField);
		StoreBannerViewModel banner2 = _banner;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		ITrackEvent trackEvent = TrackerLibrary.ShopBannerClicked(banner2.<id>k__BackingField);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void UpdateActivateButton()
	{
		StoreBannerViewModel banner = _banner;
		bool flag = banner.<routingCommand>k__BackingField == RoutingCommand.NO_MESSAGE;
		bool flag2 = !flag;
		activateButton.enabled = flag2;
	}

	public StoreBannerItem()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	private void <LoadImage>b__6_0(bool success)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		image.enabled = true;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (!loading)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = loading;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				return;
			}
		}
		GameObject gameObject = loading.gameObject;
		gameObject.SetActive(value: false);
	}
}
