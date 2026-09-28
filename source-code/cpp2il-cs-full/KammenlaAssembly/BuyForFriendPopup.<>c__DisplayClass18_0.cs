using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Features.GameReplay;
using GoogleMobileAds.Api.AdManager;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server;
using Sfs2X.Entities;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class BuyForFriendPopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass15_0
	{
		public int activeTab;

		internal void <Show>b__0(BuyForFriendPopup instance)
		{
			instance.ShowHelper(activeTab);
		}
	}

	private sealed class <>c__DisplayClass18_0
	{
		public string dbId;

		internal void <ShowFor>b__0(BuyForFriendPopup instance)
		{
			instance.popup.SlideIn();
			instance.ShowStore(dbId);
			instance.tabs.Activate(0);
		}
	}

	private static readonly AddressReference<BuyForFriendPopup> Address;

	private SlideAnimationHelper popup;

	private MiniStore store;

	private CurrencyTransferUi currencyTransferUi;

	private GameObject noMessageAllowed;

	private GameObject messageInput;

	private FriendSelector friendSelector;

	private TabsUI tabs;

	private AvatarInitializer friendProfile;

	private string lastSelectedUser;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0416: Expected I, but got O
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_0462: Expected I, but got O
		//IL_0136: Expected I, but got O
		//IL_0152: Expected O, but got I4
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Expected O, but got Unknown
		//IL_0491: Expected O, but got I
		//IL_049d: Expected O, but got I
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_00be: Expected O, but got I4
		//IL_023d: Expected I, but got O
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_0270: Expected O, but got I4
		//IL_02c5: Expected O, but got I4
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected O, but got Unknown
		//IL_03d7: Expected O, but got I
		//IL_03e5: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 3152;
		object obj2 = (nint)0 + (nint)1728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint method = (nint)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X22_v3 (System.IntPtr)+8]");
		Delegate obj3 = default(Delegate);
		obj3.method_ptr = (IntPtr)0;
		obj3.method = method;
		object obj4 = obj3 + 32;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj3.method_code = (IntPtr)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18CC");
		object obj5 = default(object);
		if (obj5 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X22_v3 (System.IntPtr)+52]");
			if ((nint)0 != 1)
			{
				goto IL_00f6;
			}
			nint invoke_impl = 35882888;
			obj3.invoke_impl = invoke_impl;
			nint extra_arg = 35882772;
			obj3.extra_arg = extra_arg;
			bool flag = (object)friendSelector == null;
			object obj6 = !flag;
			if (obj6 == null)
			{
				goto IL_03fd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X22_v3 (System.IntPtr)+52]");
			if ((nint)0 != 0)
			{
				goto IL_00f6;
			}
			nint invoke_impl2 = 35882856;
			obj3.invoke_impl = invoke_impl2;
			nint extra_arg2 = 35882772;
			obj3.extra_arg = extra_arg2;
		}
		goto IL_0471;
		IL_0471:
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)1736;
		object obj9 = (nint)0 + (nint)1824;
		object obj10 = friendSelector + 56;
		Delegate obj11 = (Delegate)obj10;
		Delegate obj13 = default(Delegate);
		Action action = default(Action);
		BuyForFriendPopup buyForFriendPopup = default(BuyForFriendPopup);
		while (true)
		{
			Delegate obj12 = Delegate.Combine(obj11, obj3);
			if ((object)obj12 == null || obj12 == obj)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag2 = (object)obj13 == obj11;
				obj11 = obj13;
				if (!flag2)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				action..ctor(this, (IntPtr)obj8);
				object obj14 = friendSelector + 64;
				Delegate obj15 = (Delegate)obj14;
				while (true)
				{
					Delegate obj16 = Delegate.Combine(obj15, action);
					object obj17;
					if ((object)obj16 != null)
					{
						bool flag3 = obj16 == obj7;
						obj17 = 0;
						if (!flag3)
						{
							break;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					bool flag4 = (object)buyForFriendPopup == obj15;
					obj15 = (Delegate)(object)buyForFriendPopup;
					obj17 = 0;
					if (flag4)
					{
						goto end_IL_01d5;
					}
				}
			}
			InvalidCastException ex = new InvalidCastException();
			buyForFriendPopup = (BuyForFriendPopup)(object)ex;
			break;
			continue;
			end_IL_01d5:
			break;
		}
		AvatarInitializer avatarInitializer = friendProfile;
		avatarInitializer.<TrackingPlacement>k__BackingField = TrackingPlacement.Shop;
		GameObject gameObject;
		bool active;
		if (buyForFriendPopup.GiftMessagingIsNotAllowed())
		{
			messageInput.SetActive(value: false);
			gameObject = noMessageAllowed;
			active = true;
		}
		else
		{
			messageInput.SetActive(value: true);
			gameObject = noMessageAllowed;
			active = false;
		}
		gameObject.SetActive(active);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
		object obj18 = default(object);
		if (obj18 != null)
		{
			object obj19 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj20 = (nint)0 + (nint)1528;
			InputField.OnValidateInput onValidateInput = default(InputField.OnValidateInput);
			onValidateInput..ctor(null, (IntPtr)obj20);
			InputFieldTMProUGUI inputFieldTMProUGUI = default(InputFieldTMProUGUI);
			inputFieldTMProUGUI.OnValidateInput += onValidateInput;
		}
		return;
		IL_03fd:
		throw new NullReferenceException();
		IL_00f6:
		obj3.invoke_impl = obj3.method_ptr;
		nint extra_arg3 = 35882772;
		obj3.extra_arg = extra_arg3;
		obj3.method_code = (IntPtr)obj3.m_target;
		bool flag5 = (object)friendSelector == null;
		object obj21 = !flag5;
		if (obj21 == null)
		{
			goto IL_03fd;
		}
		goto IL_0471;
	}

	private bool GiftMessagingIsNotAllowed()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_017c: Expected I4, but got O
		//IL_01b4: Expected O, but got I4
		//IL_0407: Expected I4, but got O
		//IL_026c: Expected O, but got I4
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_02f6: Expected I, but got O
		//IL_0306: Expected O, but got I
		//IL_03a4: Expected O, but got I
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_03ef: Expected O, but got I
		//IL_0341: Expected O, but got I
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6919]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v22+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj4 = obj6;
		if (!flag3)
		{
			goto IL_0158;
		}
		goto IL_03f9;
		IL_0382:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj9 = default(object);
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v17+8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v112 @ X2_v2 (should have been resolved before IL gen)");
		goto IL_03ae;
		IL_03f9:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0407:
		bool result;
		return result;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)sessionModel == null;
		object obj11 = !flag4;
		if (obj11 != null)
		{
			goto IL_0158;
		}
		goto IL_03f9;
		IL_0158:
		Room currentRoom = sessionModel.CurrentRoom;
		bool flag5 = currentRoom == null;
		result = (byte)(int)currentRoom != 0;
		nint num;
		object obj18 = default(object);
		if (!flag5)
		{
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v6+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			if ((object)sessionModel2 != null)
			{
				Room currentRoom2 = sessionModel2.CurrentRoom;
				if (SFSKammelnaRoomExtensions.IsTournamentHub(currentRoom2))
				{
					result = true;
					goto IL_0407;
				}
				object obj14 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v12+E4]");
				bool flag7 = (nint)0 == 0;
				object obj15 = !flag7;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel3 = default(SessionModel);
				if ((object)sessionModel3 != null)
				{
					Room currentRoom3 = sessionModel3.CurrentRoom;
					if (currentRoom3 != null)
					{
						object obj16 = typeof(RegisteredWaitHandle) + 1376;
						num = (nint)currentRoom3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
						object obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0382;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
						obj18 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X10_v4-8]");
							if (0 == (nint)obj16)
							{
								break;
							}
							obj18 += 16;
							obj17--;
							if ((nint)obj17 != 1)
							{
								continue;
							}
							goto IL_0382;
						}
						goto IL_03ae;
					}
				}
			}
			goto IL_03f9;
		}
		goto IL_0407;
		IL_03ae:
		object obj19 = obj18 + 6;
		object obj20 = num + obj19;
		object obj21 = obj20 + 312;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v12+8]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v113 @ X2_v3 (should have been resolved before IL gen)");
		goto IL_03f9;
	}

	private void AllowGiftMessaging(bool isAllowed)
	{
		messageInput.SetActive(isAllowed);
		bool active = (byte)((isAllowed ? 1u : 0u) ^ 1u) != 0;
		noMessageAllowed.SetActive(active);
	}

	private void FriendOnSelectionDone(string selectedDbId)
	{
		ShowStore(selectedDbId);
	}

	private void OnSelectionCancelled()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0056: Expected I, but got O
		//IL_0085: Expected O, but got I4
		object obj = popup;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)888;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(popup, (IntPtr)obj3);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X20_v2 (System.Object)+24]");
		float seconds = 0f * 0.5f;
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(seconds, action);
	}

	public static void Show(int activeTab = 0)
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
		//IL_0090: Expected O, but got I4
		//IL_00f3: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_011e: Expected I, but got O
		//IL_0148: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3760;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1336;
		object obj5 = (nint)0 + (nint)2128;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		object obj9 = (nint)0 + (nint)1848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v6+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj11 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj12 = !flag2;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	public void ShowChangingFriend()
	{
		ShowFriendSelector();
	}

	public void CloseFriendPanel()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017e: Expected O, but got I4
		//IL_00b6: Expected O, but got I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e4: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_01d5: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E691C]");
		object obj3 = (nint)0 & (nint)1;
		string value;
		string value2;
		if (obj3 != null)
		{
			value = lastSelectedUser;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			value2 = lastSelectedUser;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			value = lastSelectedUser;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			value2 = lastSelectedUser;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = StringsExtensions.IsNullOrEmpty(value2);
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		if (obj6 != null)
		{
			goto IL_00c4;
		}
		goto IL_01e3;
		IL_00c4:
		object obj8 = typeof(Queue<string>) + 840;
		object obj9 = (nint)0 + (nint)2184;
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		ScreenManager screenManager = default(ScreenManager);
		screenManager.Back();
		return;
		IL_01e3:
		FriendSelector friendSelector = this.friendSelector;
		friendSelector.popup.ShrinkToParent();
		return;
		IL_0091:
		bool flag6 = StringsExtensions.IsNullOrEmpty(value);
		bool flag7 = !flag6;
		obj7 = 0;
		if (!flag7)
		{
			goto IL_00c4;
		}
		goto IL_01e3;
	}

	public static void ShowFor(string dbId)
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
		//IL_00ab: Expected O, but got I4
		//IL_010e: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_0139: Expected I, but got O
		//IL_0163: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3760;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1336;
		object obj5 = (nint)0 + (nint)2136;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = dbId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj3;
		}
		object obj10 = (nint)0 + (nint)1848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	private void ShowHelper(int activeTab)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0033: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1744;
		Transform transform = base.transform;
		UIExtensions.AttachToCanvas(transform, CanvasLayer.MainCanvas);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		popup.SlideIn(action);
		tabs.Activate(activeTab);
	}

	private void ShowForHelper(string dbId)
	{
		popup.SlideIn();
		ShowStore(dbId);
		tabs.Activate(0);
	}

	private void ActivateTab(int activeTab)
	{
		tabs.Activate(activeTab);
	}

	private void ShowFriendSelector()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0123: Expected O, but got I4
		//IL_0171: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E691F]");
		object obj3 = (nint)0 & (nint)1;
		string value;
		string value2;
		if (obj3 != null)
		{
			value = lastSelectedUser;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			value2 = lastSelectedUser;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			value = lastSelectedUser;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			value2 = lastSelectedUser;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = StringsExtensions.IsNullOrEmpty(value2);
		bool flag4 = !flag3;
		object obj6 = !flag4;
		if (obj6 != null)
		{
			goto IL_00bb;
		}
		goto IL_017f;
		IL_01cb:
		CurrencyTransferUi currencyTransferUi;
		int targetUser;
		currencyTransferUi.SetTargetUser(targetUser);
		friendSelector.Show();
		return;
		IL_00bb:
		store.SetTargetUser(0);
		currencyTransferUi = this.currencyTransferUi;
		targetUser = 0;
		goto IL_01cb;
		IL_017f:
		int num = int.Parse(lastSelectedUser);
		store.SetTargetUser(num);
		currencyTransferUi = this.currencyTransferUi;
		targetUser = num;
		goto IL_01cb;
		IL_0091:
		if (StringsExtensions.IsNullOrEmpty(value))
		{
			goto IL_00bb;
		}
		goto IL_017f;
	}

	private void ShowStore(string dbId)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0044: Expected O, but got I
		object obj = this + 96;
		obj = dbId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int targetUser = int.Parse(dbId);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X22_v2-38]");
		((MiniStore)0).SetTargetUser(targetUser);
		friendProfile.InitializeFriendWithDbId(dbId);
		currencyTransferUi.SetTargetUser(targetUser);
	}

	static BuyForFriendPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "AvailableVoices" + 3112;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3008;
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
