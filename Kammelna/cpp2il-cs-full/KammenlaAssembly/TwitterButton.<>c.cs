using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.UI;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TwitterButton : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<KammelnaResponseModel<bool>> <>9__4_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 352;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Unlink>b__4_0(KammelnaResponseModel<bool> response)
		{
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected O, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Expected O, but got Unknown
			//IL_0114: Expected O, but got I4
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0082: Expected O, but got I4
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Expected O, but got Unknown
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Expected O, but got Unknown
			if (response.Succeeded)
			{
				SFS.SendRefreshStatus();
				ITrackEvent trackEvent = TrackerLibrary.AccountSocialUnLinked(SocialPlatform.Twitter);
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v18+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v23+E4]");
				if ((nint)0 != 0)
				{
					PopupWindow.DismissMessage();
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				PopupWindow.DismissMessage();
				return;
			}
			object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowError(friendlyName);
			string errorMessage = response.ErrorMessage;
			ITrackEvent trackEvent2 = TrackerLibrary.AccountSocialUnlinkedError(SocialPlatform.Twitter, errorMessage);
			object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v15+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent2);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent2);
		}
	}

	private sealed class <>c__DisplayClass6_0
	{
		public SocialUser user;

		internal void <OnLink>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_00bf: Expected O, but got I
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Expected O, but got Unknown
			//IL_010a: Expected O, but got I4
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			//IL_0090: Expected O, but got I4
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected O, but got Unknown
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected O, but got Unknown
			if (response.Succeeded)
			{
				SFS.SendRefreshStatus();
				SocialUser socialUser = user;
				ITrackEvent trackEvent = TrackerLibrary.AccountSocialLinked(socialUser.<Platform>k__BackingField);
				object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v16+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Tracker.DesignEvent(trackEvent);
				object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v23+E4]");
				if ((nint)0 != 0)
				{
					PopupWindow.DismissMessage();
					return;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				PopupWindow.DismissMessage();
				return;
			}
			object obj6 = (nint)0 + (nint)1024;
			string errorMessage = response.ErrorMessage;
			object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PopupWindow.ShowError(errorMessage);
			SocialUser socialUser2 = user;
			string errorMessage2 = response.ErrorMessage;
			ITrackEvent trackEvent2 = TrackerLibrary.AccountSocialLinkedError(socialUser2.<Platform>k__BackingField, errorMessage2);
			object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj11 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v12+E4]");
			if ((nint)0 != 0)
			{
				Tracker.DesignEvent(trackEvent2);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Tracker.DesignEvent(trackEvent2);
		}
	}

	private Button button;

	private ObjectToggler linkedIndicator;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0062: Expected O, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00b9: Expected I, but got O
		//IL_00e3: Expected O, but got I4
		//IL_010c: Expected O, but got I
		//IL_014e: Expected O, but got I4
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_019a: Expected O, but got I
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01d3: Expected I, but got O
		Button button = this.button;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3456;
		object obj4 = (nint)0 + (nint)3432;
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
		object obj6 = typeof(Queue<string>) + 848;
		button.m_OnClick.AddListener(unityAction);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		object obj7 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj9 = (nint)0 + (nint)2200;
		SocialUtilities.OnRetrievedSocialToken += action;
		GameObject go = base.gameObject;
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v14+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj12 = typeof(SqlSingle[]) + 2376;
		object obj13 = (nint)0 + (nint)3416;
		object varName = "rightCtrl" + 912;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj13);
		VariableBinderExtensions.Bind(go, localUser, (string)varName, action2);
	}

	private void LinkTwitter()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01c8: Expected O, but got I
		//IL_01e0: Expected O, but got I
		//IL_0202: Expected O, but got I4
		//IL_0212: Expected O, but got I
		//IL_005c: Expected O, but got I
		//IL_0074: Expected O, but got I
		//IL_009b: Expected O, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_025b: Expected O, but got I4
		//IL_02b1: Expected O, but got I4
		//IL_02ba: Expected O, but got I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_0161: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6510]");
		object obj3 = (nint)0 & (nint)1;
		object obj7;
		object obj6;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v9+E4]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v9+E4]");
			obj7 = 0;
			object obj8 = obj4;
			if (!flag)
			{
				goto IL_00b1;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v9+E4]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v9+E4]");
			obj7 = 0;
			object obj8 = obj4;
			if (obj9 != null)
			{
				goto IL_00b1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj10 = !flag3;
		obj6 = obj7;
		if (obj10 != null)
		{
			goto IL_00d8;
		}
		goto IL_0271;
		IL_02c8:
		Unlink();
		return;
		IL_016f:
		object obj11 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v27+E4]");
		if ((nint)0 != 0)
		{
			SocialUtilities.TwitterLogin();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SocialUtilities.TwitterLogin();
		return;
		IL_027f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		NullReferenceException value;
		bool flag4 = StringsExtensions.IsNullOrEmpty((string)(object)value);
		bool flag5 = !flag4;
		object obj13 = !flag5;
		object obj14 = 0;
		if (obj13 != null)
		{
			goto IL_016f;
		}
		goto IL_02c8;
		IL_00b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00d8;
		}
		goto IL_0271;
		IL_0271:
		value = new NullReferenceException();
		goto IL_027f;
		IL_00d8:
		object obj15 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		User localUser = sessionModel.LocalUser;
		string userTwitterID = SFSKammelnaUserExtensions.GetUserTwitterID(localUser);
		obj6 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v3+E4]");
		bool flag6 = (nint)0 == 0;
		value = (NullReferenceException)(object)userTwitterID;
		if (flag6)
		{
			goto IL_027f;
		}
		flag4 = StringsExtensions.IsNullOrEmpty(userTwitterID);
		bool flag7 = !flag4;
		obj14 = 0;
		if (!flag7)
		{
			goto IL_016f;
		}
		goto IL_02c8;
	}

	private static void Unlink()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_00c7: Expected O, but got I4
		//IL_0142: Expected O, but got I
		//IL_0152: Expected O, but got I
		//IL_0174: Expected O, but got I4
		//IL_01a4: Expected O, but got I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0212: Expected O, but got I
		//IL_0223: Expected I, but got O
		//IL_0241: Expected O, but got I
		//IL_01d4: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(TrackedDeviceRaycaster.<>c) + 352;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6511]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v3+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v4+8]");
		Action<KammelnaResponseModel<bool>> callback = (Action<KammelnaResponseModel<bool>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			goto IL_0182;
		}
		goto IL_01d9;
		IL_01d9:
		KammelnaRequests.UnlinkSocialPlatform(SocialPlatform.Twitter, callback);
		return;
		IL_0182:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v10+B8]");
			obj7 = 0;
		}
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)1008;
		Action<object> action = default(Action<object>);
		action..ctor(obj7, (IntPtr)obj12);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v9+B8]");
		object obj14 = (nint)0 + (nint)8;
		obj14 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		callback = action;
		goto IL_01d9;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v3+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v4+8]");
		callback = (Action<KammelnaResponseModel<bool>>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v4+8]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			goto IL_0182;
		}
		goto IL_01d9;
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
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3456;
		object obj2 = (nint)0 + (nint)3432;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 848;
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
		SocialUtilities.OnRetrievedSocialToken -= action;
	}

	private void OnLink(SocialUser user)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0066: Expected O, but got I
		//IL_0081: Expected I, but got O
		//IL_00b3: Expected O, but got I
		//IL_00b3: Expected O, but got I
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = user;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj3;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj6 = (nint)0 + (nint)1016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj6);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+38]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+10]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v4+18]");
		KammelnaRequests.LinkSocialPlatform((SocialPlatform)num, (string)num2, (string)0, action);
	}

	private void <Awake>b__2_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f6: Expected O, but got I
		//IL_012a: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_01cd: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6514]");
		object obj3 = (nint)0 & (nint)1;
		ObjectToggler objectToggler;
		ObjectToggler objectToggler2;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			objectToggler = linkedIndicator;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			objectToggler2 = linkedIndicator;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			objectToggler = linkedIndicator;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			objectToggler2 = linkedIndicator;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		BaseToggler baseToggler = objectToggler2;
		goto IL_0170;
		IL_0170:
		object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string userTwitterID = SFSKammelnaUserExtensions.GetUserTwitterID(localUser);
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v4+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag4 = StringsExtensions.IsNullOrEmpty(userTwitterID);
		bool isON = (byte)((flag4 ? 1u : 0u) ^ 1u) != 0;
		baseToggler.ToggleManual(isON);
		return;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj11 = !flag5;
		baseToggler = objectToggler;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0170;
	}
}
