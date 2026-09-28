using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;

public class InviteFriendButton : MonoBehaviour
{
	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0049: Expected I, but got O
		//IL_0063: Expected O, but got I
		object obj = (nint)0 + (nint)3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj3 = (nint)0 + (nint)3184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v3+100]");
		((UnityEvent)0).AddListener(unityAction);
	}

	private void ShareMyLink()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_003e: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 648;
		object obj2 = (nint)0 + (nint)3192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		KammelnaRequests.GetFriendInviteToken(action);
	}

	private void ShareTokenizedLink(KammelnaResponseModel<string> response)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61DF]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v13+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v13+E4]");
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
		string userCode = SFSKammelnaUserExtensions.GetUserCode(localUser);
		object obj8 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1376;
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FriendInviteData friendInviteData = default(FriendInviteData);
		friendInviteData..ctor(userCode, response.<Model>k__BackingField);
		string message = DeepLinkingManager.GenerateInviteLink(friendInviteData);
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			KUtil.Share(message);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		KUtil.Share(message);
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}
}
