using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class RoomItemPopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass5_0
	{
		public StoreItem roomItem;

		public bool isPurchasable;

		public int? tempId;

		internal void <ShowRoomItemPopup>b__0(RoomItemPopup popup)
		{
			popup.Popup(roomItem, isPurchasable, tempId);
		}
	}

	private static readonly AddressReference<RoomItemPopup> Address;

	private static readonly AddressReference<RoomItemPopup> TabletAddress;

	private PopupUI popup;

	private StoreRoomItem RoomItem;

	private bool _isPurchasable;

	public static void ShowRoomItemPopup(StoreItem roomItem, bool isPurchasable, int? tempId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_01a9: Expected O, but got I
		//IL_00e0: Expected O, but got I4
		//IL_01ba: Expected O, but got I
		//IL_01d5: Expected I, but got O
		//IL_01ff: Expected O, but got I4
		//IL_0194: Expected O, but got I
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(RegisteredWaitHandle) + 1408;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3352;
		object obj5 = (nint)0 + (nint)904;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = roomItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool isTablet = ScreenUtility.IsTablet;
		object obj8 = obj3;
		if (isTablet)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v17+B8]");
			object obj10 = (nint)0 + (nint)8;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v17+B8]");
			object obj10 = 0;
		}
		object obj12 = (nint)0 + (nint)2336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	private void Popup(StoreItem roomItem, bool isPurchasable, int? tempId)
	{
		_isPurchasable = isPurchasable;
		popup.PopFromCenter();
		GameObject gameObject = RoomItem.gameObject;
		gameObject.SetActive(value: true);
		RoomItem.PopulateStoreItem(roomItem, isPopup: true, isPurchasable, tempId);
		RoomItem.RefreshStatus();
	}

	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_014a: Expected O, but got I4
		//IL_01a8: Expected O, but got I4
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_0247: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6954]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object roomItem;
		UnityEngine.Object roomItem2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			roomItem = RoomItem;
			roomItem2 = RoomItem;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			roomItem = RoomItem;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			roomItem2 = RoomItem;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = roomItem2 == null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			goto IL_0158;
		}
		return;
		IL_0158:
		if (!_isPurchasable)
		{
			return;
		}
		StoreRoomItem roomItem3 = RoomItem;
		bool flag5 = !roomItem3.<Owned>k__BackingField;
		object obj7 = !flag5;
		if (obj7 != null)
		{
			return;
		}
		StoreItem currentItem = roomItem3.currentItem;
		if (StoreItemExtensions.IsAnimatedRoomTheme(roomItem3.currentItem))
		{
			ITrackEvent trackEvent = TrackerLibrary.StoreAnimatedRoomThemePreviewedNoBuy(currentItem.<id>k__BackingField, currentItem.<name>k__BackingField);
			object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v8+E4]");
			bool flag6 = (nint)0 == 0;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
		}
		return;
		IL_0091:
		if (roomItem == null)
		{
			return;
		}
		goto IL_0158;
	}

	static RoomItemPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0069: Expected O, but got I
		object obj = "Read object reference Id '{0}' for {1}." + 3376;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3168;
		object obj3 = typeof(RegisteredWaitHandle) + 1408;
		object obj4 = "Read object reference Id '{0}' for {1}." + 3384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj5 = obj3;
		object obj7 = default(object);
		object obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v4+B8]");
		object obj9 = (nint)0 + (nint)8;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
