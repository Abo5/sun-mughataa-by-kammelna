using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DataTracking;
using Features.GameReplay;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Server.Models.Products;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using Util.SystemHelpers;

public class MiniStore : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<StoreProductUi> <>9__12_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3800;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <RepopulateProducts>b__12_0(StoreProductUi product)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			GameObject gameObject = product.gameObject;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+E4]");
			if ((nint)0 != 0)
			{
				UnityEngine.Object.Destroy(gameObject);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			UnityEngine.Object.Destroy(gameObject);
		}
	}

	private RectTransform subscriptionsList;

	private RectTransform coinsList;

	private StoreProductUi productPrefab;

	private InputFieldTMProUGUI customMessage;

	private readonly List<StoreProductUi> _instantiatedProducts;

	private GiftInfo _giftInfo;

	private const string CanNotSendGiftMessageWhileMuted = "Can not send gift message while muted";

	private const string GiftMessage = "Bomb Message";

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0369: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0065: Expected O, but got I
		//IL_009e: Expected O, but got I4
		//IL_00e2: Expected I, but got O
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0107: Expected O, but got I
		//IL_013b: Expected I, but got O
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0160: Expected O, but got I
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_019e: Expected I, but got O
		//IL_01c8: Expected O, but got I4
		//IL_020b: Expected I, but got O
		//IL_0234: Expected O, but got I
		//IL_024c: Expected I, but got O
		//IL_0266: Expected O, but got I
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_028b: Expected O, but got I
		//IL_02c4: Expected O, but got I4
		//IL_02fc: Expected O, but got I
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_0335: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)3024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(Queue<string>) + 752;
		object obj4 = (nint)0 + (nint)2024;
		object obj5 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1840;
		object obj6 = (nint)0 + (nint)3000;
		customMessage.OnValueChanged += action;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IAPController.IAPAction iAPAction = default(IAPController.IAPAction);
		iAPAction..ctor(this, (IntPtr)obj6);
		object obj9 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1848;
		object obj10 = (nint)0 + (nint)3008;
		IAPController iAPController = default(IAPController);
		iAPController.OnIAPPurchaseComplete += iAPAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IAPController.IAPFailure iAPFailure = default(IAPController.IAPFailure);
		iAPFailure..ctor(this, (IntPtr)obj10);
		object obj11 = typeof(SqlSingle[]) + 2376;
		object obj12 = (nint)0 + (nint)3032;
		object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		IAPController iAPController2 = default(IAPController);
		iAPController2.OnIAPPurchaseFailed += iAPFailure;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj12);
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v21+E4]");
		bool flag2 = (nint)0 == 0;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ContentPushService.OnStoreApplied -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj12);
		ContentPushService.OnStoreApplied += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj16 = (nint)0 + (nint)2992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj16);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v28+20]");
		((OneShotEvent)0).CallWhenReady(action4);
		object obj17 = typeof(Queue<string>) + 848;
		object obj18 = (nint)0 + (nint)2200;
		GameObject go = customMessage.gameObject;
		object obj19 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v34+E4]");
		bool flag3 = (nint)0 == 0;
		object obj20 = !flag3;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj21 = (nint)0 + (nint)3016;
		object varName = "m_StencilDeferredPS" + 2520;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj21);
		VariableBinderExtensions.Bind(go, localUser, (string)varName, action5);
	}

	private void OnMuteStatusUpdated()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61EE]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v9+E4]");
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
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v9+E4]");
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
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		MuteStatus muteStatus = SFSKammelnaUserExtensions.GetMuteStatus(localUser);
		if (muteStatus == MuteStatus.MutedByAdmin)
		{
			object placeholder = "COORDINATE_TYPE_GCJ_02" + 1264;
			customMessage.SetPlaceholder((string)placeholder);
			customMessage.Interactable = false;
		}
		else
		{
			object placeholder2 = "AvailableVoices" + 2400;
			customMessage.SetPlaceholder((string)placeholder2);
			customMessage.Interactable = true;
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	private void OnDisable()
	{
		//IL_0011: Expected O, but got I
		object text = (nint)0 + (nint)2000;
		customMessage.Text = (string)text;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0168: Expected O, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0188: Expected O, but got I
		//IL_01b2: Expected O, but got I4
		//IL_004f: Expected I, but got O
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0074: Expected O, but got I
		//IL_00a8: Expected I, but got O
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00cd: Expected O, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_010b: Expected I, but got O
		//IL_0135: Expected O, but got I4
		object obj = typeof(Queue<string>) + 752;
		object obj2 = (nint)0 + (nint)2024;
		object obj3 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1840;
		object obj4 = (nint)0 + (nint)3000;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IAPController.IAPAction iAPAction = default(IAPController.IAPAction);
		iAPAction..ctor(this, (IntPtr)obj4);
		object obj7 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1848;
		object obj8 = (nint)0 + (nint)3008;
		IAPController iAPController = default(IAPController);
		iAPController.OnIAPPurchaseComplete -= iAPAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IAPController.IAPFailure iAPFailure = default(IAPController.IAPFailure);
		iAPFailure..ctor(this, (IntPtr)obj8);
		object obj9 = typeof(SqlSingle[]) + 2376;
		object obj10 = (nint)0 + (nint)3032;
		object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		IAPController iAPController2 = default(IAPController);
		iAPController2.OnIAPPurchaseFailed -= iAPFailure;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj10);
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v18+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ContentPushService.OnStoreApplied -= action;
	}

	private void RepopulateProducts()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0248: Expected O, but got I
		//IL_0258: Expected O, but got I
		//IL_027a: Expected O, but got I4
		//IL_0212: Expected O, but got I4
		//IL_01c1: Expected O, but got I
		//IL_01d1: Expected O, but got I
		//IL_02aa: Expected O, but got I4
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03c1: Expected O, but got I
		//IL_03d2: Expected I, but got O
		//IL_03f0: Expected O, but got I
		//IL_02da: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 752;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61F1]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2024;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v22+E4]");
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
			object obj4 = (nint)0 + (nint)2024;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v22+E4]");
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
		IL_02ec:
		Action<object> action;
		((List<object>)(object)_instantiatedProducts).ForEach(action);
		List<StoreProductUi> instantiatedProducts = _instantiatedProducts;
		int version = instantiatedProducts._version + 1;
		instantiatedProducts._size = 0;
		instantiatedProducts._version = version;
		if (instantiatedProducts._size >= 1)
		{
			Array.Clear(instantiatedProducts._items, 0, instantiatedProducts._size);
		}
		InitializeSubscriptions();
		InitializeCoins();
		return;
		IL_01f6:
		bool flag3 = _instantiatedProducts == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_02ec;
		}
		goto IL_0390;
		IL_0390:
		throw new NullReferenceException();
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj9 = default(object);
		bool flag4 = obj9 == null;
		object obj10 = !flag4;
		if (obj10 != null)
		{
			goto IL_0133;
		}
		goto IL_0390;
		IL_0133:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3+20]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v4+18]");
		if ((nint)0 != 1)
		{
			return;
		}
		object obj12 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3800;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v11+E4]");
		object obj14;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v11+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v12+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v12+8]");
			if ((nint)0 != 0)
			{
				goto IL_01f6;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v11+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v12+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v12+8]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 != null)
			{
				goto IL_01f6;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v11+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj17 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v18+B8]");
			obj14 = 0;
		}
		object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)1960;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj14, (IntPtr)obj19);
		object obj20 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v17+B8]");
		object obj21 = (nint)0 + (nint)8;
		obj21 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action2;
		goto IL_02ec;
	}

	private void OnValueChanged(string message)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		if (_giftInfo != null)
		{
			object obj = typeof(System.IOAsyncCallback) + 3096;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = InputSanitizer.SanitizeHtmlTags(message);
			object obj4 = _giftInfo + 24;
			obj4 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public void SetTargetUser(int userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0051: Expected I, but got O
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2880;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3568;
		object obj3 = (nint)0 + (nint)2984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftInfo giftInfo = default(GiftInfo);
		giftInfo..ctor(userId);
		object obj4 = this + 72;
		obj4 = giftInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		((List<object>)(object)_instantiatedProducts).ForEach(action);
	}

	private void InitializeLists()
	{
		InitializeSubscriptions();
		InitializeCoins();
	}

	private unsafe void InitializeSubscriptions()
	{
		//IL_0958: Expected O, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_011b: Expected O, but got I4
		//IL_012d: Expected O, but got I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0259: Expected O, but got I
		//IL_0265: Expected O, but got I
		//IL_0347: Expected O, but got I
		//IL_0153: Expected O, but got I4
		//IL_017f: Expected O, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_01d0: Expected O, but got I4
		//IL_01f3: Expected O, but got I4
		//IL_09c3: Expected I4, but got O
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09eb: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_06f9: Expected O, but got I4
		//IL_0404: Expected O, but got I4
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected O, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_0a99: Expected O, but got I4
		//IL_03b3: Expected O, but got I
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		//IL_072a: Expected O, but got I
		//IL_046e: Expected O, but got I
		//IL_0a71: Expected O, but got I4
		//IL_07d7: Expected O, but got I4
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected O, but got Unknown
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected O, but got Unknown
		//IL_086e: Expected I, but got O
		//IL_052b: Expected O, but got I4
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected O, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected O, but got Unknown
		//IL_078e: Expected O, but got I
		//IL_04da: Expected O, but got I
		//IL_0817: Expected O, but got I4
		//IL_0830: Expected I, but got O
		//IL_05f1: Expected I4, but got O
		//IL_066e: Expected O, but got I4
		//IL_0292: Expected O, but got I
		//IL_02b2: Expected O, but got I
		//IL_02e6: Expected O, but got I4
		//IL_0308: Expected O, but got I4
		//IL_0321: Expected I, but got O
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61F4]");
		int num = 0;
		IEnumerable<ProductViewModel> consumableSubscriptions = IAPController.ConsumableSubscriptions;
		bool flag = consumableSubscriptions == null;
		object obj = 0;
		int num3;
		bool flag3 = default(bool);
		object obj6 = default(object);
		GiftInfo giftInfo;
		int num4 = default(int);
		object obj7;
		GiftInfo giftInfo2 = default(GiftInfo);
		object[] array;
		nint num5;
		if (!flag)
		{
			object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3640;
			nint num2 = (nint)consumableSubscriptions;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.Products.ProductViewModel>>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.Products.ProductViewModel>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.Products.ProductViewModel>>)+B0]");
			num3 = (int)((nint)0 + (nint)8);
			bool flag2 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X10_v11 (System.Int32)-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				num4 = num3 + 16;
				obj3--;
				flag3 = (nint)obj3 != 1;
				flag2 = flag3;
				num3 = num4;
				if (flag3)
				{
					continue;
				}
				goto IL_00d5;
			}
			object obj4 = num2 + ((int*)num3)->m_value;
			object obj5 = obj4 + 312;
			array = (object[])obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v38+8]");
			num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v283 @ X8_v38] (should have been resolved before IL gen)");
			bool flag4 = obj6 == null;
			obj = obj6;
			obj7 = 0;
			flag3 = flag2;
			num4 = num3;
			obj = obj6;
			obj7 = 0;
			giftInfo = giftInfo2;
			num = (int)(&obj);
			if (!flag4)
			{
				goto IL_0211;
			}
			goto IL_0835;
		}
		goto IL_0966;
		IL_0966:
		throw new NullReferenceException();
		IL_0805:
		NullReferenceException ex = new NullReferenceException();
		object obj8 = 0;
		bool flag5 = false;
		num3 = num4;
		ProductViewModel productViewModel = default(ProductViewModel);
		num5 = (nint)productViewModel;
		goto IL_08a1;
		IL_08a1:
		giftInfo2 = giftInfo;
		num4 = num3;
		goto IL_0966;
		IL_0843:
		NullReferenceException ex2 = new NullReferenceException();
		object obj9;
		obj8 = obj9;
		bool flag6;
		flag5 = flag6;
		num3 = num4;
		num5 = (nint)subscriptionsList;
		goto IL_08a1;
		IL_0835:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_08a1;
		IL_00d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj10 = default(object);
		array = (object[])obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v55+8]");
		num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v177 @ X0_v55] (should have been resolved before IL gen)");
		bool flag7 = obj6 == null;
		object obj11 = !flag7;
		obj = obj6;
		obj7 = 0;
		giftInfo2 = null;
		if (obj11 != null)
		{
			goto IL_0211;
		}
		obj = obj6;
		obj7 = 0;
		giftInfo = null;
		num3 = num4;
		num = (int)(&obj);
		goto IL_0835;
		IL_0211:
		object obj12 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj13 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1072;
		object obj14 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj15 = (nint)0 + (nint)728;
		object obj16 = (nint)0 + (nint)3024;
		obj9 = obj8;
		flag6 = flag5;
		object obj17 = obj6;
		object obj20 = default(object);
		object obj22 = default(object);
		object obj32 = default(object);
		StoreProductUi storeProductUi = default(StoreProductUi);
		while (true)
		{
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v20+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v20+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03e3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v20+B0]");
			int num6 = (int)((nint)0 + (nint)8);
			bool flag8 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X10_v26 (System.Int32)-8]");
				if (0 == (nint)obj12)
				{
					break;
				}
				num4 = num6 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v20+12E]");
				array = (object[])(-1);
				flag3 = (nint)array != 1;
				flag8 = flag3;
				num6 = num4;
				if (flag3)
				{
					continue;
				}
				goto IL_03e3;
			}
			array = (object[])((int*)num6)->m_value;
			object obj19 = obj18 + ((int*)num6)->m_value;
			obj20 = obj19 + 312;
			flag3 = flag8;
			num4 = num6;
			goto IL_09bb;
			IL_09bb:
			num = (int)obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X0_v29+8]");
			num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v520 @ X0_v29] (should have been resolved before IL gen)");
			object obj21 = obj22 & 1;
			if (obj21 != null)
			{
				if (obj == null)
				{
					break;
				}
				object obj23 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v23+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v23+12E]");
				if ((nint)0 == 0)
				{
					goto IL_050a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v23+B0]");
				int num7 = (int)((nint)0 + (nint)8);
				bool flag9 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X10_v21 (System.Int32)-8]");
					if (0 == (nint)obj13)
					{
						break;
					}
					num4 = num7 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v23+12E]");
					array = (object[])(-1);
					flag3 = (nint)array != 1;
					flag9 = flag3;
					num7 = num4;
					if (flag3)
					{
						continue;
					}
					goto IL_050a;
				}
				array = (object[])((int*)num7)->m_value;
				object obj24 = obj23 + ((int*)num7)->m_value;
				object obj25 = obj24 + 312;
				flag3 = flag9;
				num4 = num7;
				goto IL_0a2d;
			}
			obj8 = obj9;
			flag5 = flag6;
			object obj26 = 0;
			while (true)
			{
				if (obj == null)
				{
					goto IL_0a7f;
				}
				object obj27 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj28 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v7+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v7+12E]");
				if ((nint)0 == 0)
				{
					goto IL_07b6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v7+B0]");
				int num8 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X10_v7 (System.Int32)-8]");
					if (0 == (nint)obj27)
					{
						break;
					}
					num4 = num8 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v7+12E]");
					array = (object[])(-1);
					bool flag10 = (nint)array != 1;
					num8 = num4;
					if (flag10)
					{
						continue;
					}
					goto IL_07b6;
				}
				array = (object[])((int*)num8)->m_value;
				object obj29 = obj28 + ((int*)num8)->m_value;
				object obj30 = obj29 + 312;
				num4 = num8;
				goto IL_0acb;
				IL_0a7f:
				bool flag11 = obj26 == null;
				object obj31 = !flag11;
				if (obj31 == null)
				{
					return;
				}
				OutOfMemoryException ex4 = new OutOfMemoryException();
				if (num5 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj26 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj7 = obj32;
				continue;
				IL_07b6:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				giftInfo2 = null;
				goto IL_0acb;
				IL_0acb:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X0_v6+8]");
				num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v724 @ X0_v6] (should have been resolved before IL gen)");
				goto IL_0a7f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_050a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			giftInfo2 = null;
			goto IL_0a2d;
			IL_0a2d:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v732 @ X0_v33] (should have been resolved before IL gen)");
			object obj33 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X0_v36+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X0_v36+E4]");
			bool flag12 = (nint)0 == 0;
			object obj34 = !flag12;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			giftInfo = (GiftInfo)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			if ((object)storeProductUi != null)
			{
				giftInfo = _giftInfo;
				storeProductUi.PopulateProduct(productViewModel, _giftInfo);
				List<object> instantiatedProducts = (List<object>)(object)_instantiatedProducts;
				if (_instantiatedProducts != null)
				{
					num = (int)obj16;
					int version = instantiatedProducts._version + 1;
					instantiatedProducts._version = version;
					array = instantiatedProducts._items;
					if (instantiatedProducts._items != null)
					{
						num4 = instantiatedProducts._size;
						bool flag13 = instantiatedProducts._size < array.Length;
						object obj35 = !flag13;
						object obj37;
						if (obj35 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v4 (System.Int32)+20]");
							object obj36 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v31+C0]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v4 (System.Int32)+70]");
							giftInfo = (GiftInfo)0;
							((List<object>)(object)_instantiatedProducts).AddWithResize((object)storeProductUi);
							obj37 = storeProductUi;
						}
						else
						{
							num = instantiatedProducts._size + 1;
							instantiatedProducts._size = num;
							object obj38 = instantiatedProducts._items + instantiatedProducts._size;
							object obj39 = obj38 + 32;
							obj39 = storeProductUi;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj37 = storeProductUi;
						}
						bool flag14 = obj == null;
						obj9 = 0;
						flag6 = false;
						giftInfo2 = giftInfo;
						obj17 = obj;
						obj8 = 0;
						flag5 = false;
						num3 = num4;
						num5 = (nint)obj37;
						if (!flag14)
						{
							continue;
						}
						goto IL_0835;
					}
				}
				goto IL_0805;
			}
			goto IL_0843;
			IL_03e3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			giftInfo2 = null;
			goto IL_09bb;
		}
		NullReferenceException ex5 = new NullReferenceException();
		obj8 = obj9;
		flag5 = flag6;
		giftInfo = giftInfo2;
		num3 = num4;
		goto IL_08a1;
	}

	private unsafe void InitializeCoins()
	{
		//IL_0958: Expected O, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_011b: Expected O, but got I4
		//IL_012d: Expected O, but got I4
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_0259: Expected O, but got I
		//IL_0265: Expected O, but got I
		//IL_0347: Expected O, but got I
		//IL_0153: Expected O, but got I4
		//IL_017f: Expected O, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_01d0: Expected O, but got I4
		//IL_01f3: Expected O, but got I4
		//IL_09c3: Expected I4, but got O
		//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09eb: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_06f9: Expected O, but got I4
		//IL_0404: Expected O, but got I4
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected O, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_0a99: Expected O, but got I4
		//IL_03b3: Expected O, but got I
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		//IL_072a: Expected O, but got I
		//IL_046e: Expected O, but got I
		//IL_0a71: Expected O, but got I4
		//IL_07d7: Expected O, but got I4
		//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e9: Expected O, but got Unknown
		//IL_07f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f7: Expected O, but got Unknown
		//IL_086e: Expected I, but got O
		//IL_052b: Expected O, but got I4
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected O, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected O, but got Unknown
		//IL_078e: Expected O, but got I
		//IL_04da: Expected O, but got I
		//IL_0817: Expected O, but got I4
		//IL_0830: Expected I, but got O
		//IL_05f1: Expected I4, but got O
		//IL_066e: Expected O, but got I4
		//IL_0292: Expected O, but got I
		//IL_02b2: Expected O, but got I
		//IL_02e6: Expected O, but got I4
		//IL_0308: Expected O, but got I4
		//IL_0321: Expected I, but got O
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c1: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61F5]");
		int num = 0;
		IEnumerable<ProductViewModel> goldenCards = IAPController.GoldenCards;
		bool flag = goldenCards == null;
		object obj = 0;
		int num3;
		bool flag3 = default(bool);
		object obj6 = default(object);
		GiftInfo giftInfo;
		int num4 = default(int);
		object obj7;
		GiftInfo giftInfo2 = default(GiftInfo);
		object[] array;
		nint num5;
		if (!flag)
		{
			object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3640;
			nint num2 = (nint)goldenCards;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.Products.ProductViewModel>>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.Products.ProductViewModel>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<Server.Models.Products.ProductViewModel>>)+B0]");
			num3 = (int)((nint)0 + (nint)8);
			bool flag2 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X10_v11 (System.Int32)-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				num4 = num3 + 16;
				obj3--;
				flag3 = (nint)obj3 != 1;
				flag2 = flag3;
				num3 = num4;
				if (flag3)
				{
					continue;
				}
				goto IL_00d5;
			}
			object obj4 = num2 + ((int*)num3)->m_value;
			object obj5 = obj4 + 312;
			array = (object[])obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v38+8]");
			num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v283 @ X8_v38] (should have been resolved before IL gen)");
			bool flag4 = obj6 == null;
			obj = obj6;
			obj7 = 0;
			flag3 = flag2;
			num4 = num3;
			obj = obj6;
			obj7 = 0;
			giftInfo = giftInfo2;
			num = (int)(&obj);
			if (!flag4)
			{
				goto IL_0211;
			}
			goto IL_0835;
		}
		goto IL_0966;
		IL_0966:
		throw new NullReferenceException();
		IL_0805:
		NullReferenceException ex = new NullReferenceException();
		object obj8 = 0;
		bool flag5 = false;
		num3 = num4;
		ProductViewModel productViewModel = default(ProductViewModel);
		num5 = (nint)productViewModel;
		goto IL_08a1;
		IL_08a1:
		giftInfo2 = giftInfo;
		num4 = num3;
		goto IL_0966;
		IL_0843:
		NullReferenceException ex2 = new NullReferenceException();
		object obj9;
		obj8 = obj9;
		bool flag6;
		flag5 = flag6;
		num3 = num4;
		num5 = (nint)coinsList;
		goto IL_08a1;
		IL_0835:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_08a1;
		IL_00d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj10 = default(object);
		array = (object[])obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v55+8]");
		num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v177 @ X0_v55] (should have been resolved before IL gen)");
		bool flag7 = obj6 == null;
		object obj11 = !flag7;
		obj = obj6;
		obj7 = 0;
		giftInfo2 = null;
		if (obj11 != null)
		{
			goto IL_0211;
		}
		obj = obj6;
		obj7 = 0;
		giftInfo = null;
		num3 = num4;
		num = (int)(&obj);
		goto IL_0835;
		IL_0211:
		object obj12 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj13 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1072;
		object obj14 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj15 = (nint)0 + (nint)728;
		object obj16 = (nint)0 + (nint)3024;
		obj9 = obj8;
		flag6 = flag5;
		object obj17 = obj6;
		object obj20 = default(object);
		object obj22 = default(object);
		object obj32 = default(object);
		StoreProductUi storeProductUi = default(StoreProductUi);
		while (true)
		{
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v20+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v20+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03e3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v20+B0]");
			int num6 = (int)((nint)0 + (nint)8);
			bool flag8 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X10_v26 (System.Int32)-8]");
				if (0 == (nint)obj12)
				{
					break;
				}
				num4 = num6 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v20+12E]");
				array = (object[])(-1);
				flag3 = (nint)array != 1;
				flag8 = flag3;
				num6 = num4;
				if (flag3)
				{
					continue;
				}
				goto IL_03e3;
			}
			array = (object[])((int*)num6)->m_value;
			object obj19 = obj18 + ((int*)num6)->m_value;
			obj20 = obj19 + 312;
			flag3 = flag8;
			num4 = num6;
			goto IL_09bb;
			IL_09bb:
			num = (int)obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X0_v29+8]");
			num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v520 @ X0_v29] (should have been resolved before IL gen)");
			object obj21 = obj22 & 1;
			if (obj21 != null)
			{
				if (obj == null)
				{
					break;
				}
				object obj23 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v23+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v23+12E]");
				if ((nint)0 == 0)
				{
					goto IL_050a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v23+B0]");
				int num7 = (int)((nint)0 + (nint)8);
				bool flag9 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X10_v21 (System.Int32)-8]");
					if (0 == (nint)obj13)
					{
						break;
					}
					num4 = num7 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v23+12E]");
					array = (object[])(-1);
					flag3 = (nint)array != 1;
					flag9 = flag3;
					num7 = num4;
					if (flag3)
					{
						continue;
					}
					goto IL_050a;
				}
				array = (object[])((int*)num7)->m_value;
				object obj24 = obj23 + ((int*)num7)->m_value;
				object obj25 = obj24 + 312;
				flag3 = flag9;
				num4 = num7;
				goto IL_0a2d;
			}
			obj8 = obj9;
			flag5 = flag6;
			object obj26 = 0;
			while (true)
			{
				if (obj == null)
				{
					goto IL_0a7f;
				}
				object obj27 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj28 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v7+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v7+12E]");
				if ((nint)0 == 0)
				{
					goto IL_07b6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v7+B0]");
				int num8 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X10_v7 (System.Int32)-8]");
					if (0 == (nint)obj27)
					{
						break;
					}
					num4 = num8 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X8_v7+12E]");
					array = (object[])(-1);
					bool flag10 = (nint)array != 1;
					num8 = num4;
					if (flag10)
					{
						continue;
					}
					goto IL_07b6;
				}
				array = (object[])((int*)num8)->m_value;
				object obj29 = obj28 + ((int*)num8)->m_value;
				object obj30 = obj29 + 312;
				num4 = num8;
				goto IL_0acb;
				IL_0a7f:
				bool flag11 = obj26 == null;
				object obj31 = !flag11;
				if (obj31 == null)
				{
					return;
				}
				OutOfMemoryException ex4 = new OutOfMemoryException();
				if (num5 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj26 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj7 = obj32;
				continue;
				IL_07b6:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				giftInfo2 = null;
				goto IL_0acb;
				IL_0acb:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X0_v6+8]");
				num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v724 @ X0_v6] (should have been resolved before IL gen)");
				goto IL_0a7f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_050a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			giftInfo2 = null;
			goto IL_0a2d;
			IL_0a2d:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v732 @ X0_v33] (should have been resolved before IL gen)");
			object obj33 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X0_v36+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v739 @ X0_v36+E4]");
			bool flag12 = (nint)0 == 0;
			object obj34 = !flag12;
			if (obj34 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			giftInfo = (GiftInfo)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			if ((object)storeProductUi != null)
			{
				giftInfo = _giftInfo;
				storeProductUi.PopulateProduct(productViewModel, _giftInfo);
				List<object> instantiatedProducts = (List<object>)(object)_instantiatedProducts;
				if (_instantiatedProducts != null)
				{
					num = (int)obj16;
					int version = instantiatedProducts._version + 1;
					instantiatedProducts._version = version;
					array = instantiatedProducts._items;
					if (instantiatedProducts._items != null)
					{
						num4 = instantiatedProducts._size;
						bool flag13 = instantiatedProducts._size < array.Length;
						object obj35 = !flag13;
						object obj37;
						if (obj35 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v4 (System.Int32)+20]");
							object obj36 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v31+C0]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v4 (System.Int32)+70]");
							giftInfo = (GiftInfo)0;
							((List<object>)(object)_instantiatedProducts).AddWithResize((object)storeProductUi);
							obj37 = storeProductUi;
						}
						else
						{
							num = instantiatedProducts._size + 1;
							instantiatedProducts._size = num;
							object obj38 = instantiatedProducts._items + instantiatedProducts._size;
							object obj39 = obj38 + 32;
							obj39 = storeProductUi;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							obj37 = storeProductUi;
						}
						bool flag14 = obj == null;
						obj9 = 0;
						flag6 = false;
						giftInfo2 = giftInfo;
						obj17 = obj;
						obj8 = 0;
						flag5 = false;
						num3 = num4;
						num5 = (nint)obj37;
						if (!flag14)
						{
							continue;
						}
						goto IL_0835;
					}
				}
				goto IL_0805;
			}
			goto IL_0843;
			IL_03e3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			giftInfo2 = null;
			goto IL_09bb;
		}
		NullReferenceException ex5 = new NullReferenceException();
		obj8 = obj9;
		flag5 = flag6;
		giftInfo = giftInfo2;
		num3 = num4;
		goto IL_08a1;
	}

	private void OnIAPPurchaseComplete(ProductListingModel listing, GiftInfo giftInfo)
	{
		//IL_00bf: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0071: Expected O, but got I4
		if (giftInfo != null)
		{
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object currencyCode = "Read object reference Id '{0}' for {1}." + 3808;
			ProductViewModel product = listing.getProduct();
			GiftsHandler.ShowGiftSentPopup(giftInfo, product);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.PurchaseEvent(TrackerPurchase.BuyForFriend, listing.<listingId>k__BackingField, listing.<price>k__BackingField, (string)currencyCode);
		}
		object text = (nint)0 + (nint)2000;
		customMessage.Text = (string)text;
	}

	private void OnIAPPurchaseFailed(ProductListingModel listing, string error)
	{
		//IL_0011: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_005e: Expected O, but got I4
		object text = (nint)0 + (nint)2000;
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		customMessage.Text = (string)text;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError(error);
	}

	public MiniStore()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 64;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <SetTargetUser>b__14_0(StoreProductUi p)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		object obj = p + 240;
		obj = _giftInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
