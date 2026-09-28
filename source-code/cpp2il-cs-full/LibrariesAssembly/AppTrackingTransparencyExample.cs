using System;
using System.Data;
using System.Diagnostics;
using Balaso;
using Cpp2ILInjected;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class AppTrackingTransparencyExample : MonoBehaviour
{
	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00c1: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D00]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v8+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		AppTrackingTransparency.RegisterAppForAdNetworkAttribution();
		AppTrackingTransparency.UpdateConversionValue(3);
		return;
		IL_007c:
		AppTrackingTransparency.RegisterAppForAdNetworkAttribution();
		AppTrackingTransparency.UpdateConversionValue(3);
	}

	private unsafe void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_0360: Expected O, but got I
		//IL_038a: Expected O, but got I4
		//IL_0404: Expected O, but got I
		//IL_041c: Expected I, but got O
		//IL_0431: Expected O, but got I
		//IL_01e7: Expected O, but got I
		//IL_01f0: Expected O, but got I4
		//IL_0210: Expected O, but got I
		//IL_0228: Expected O, but got I4
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_03e6: Expected O, but got I4
		//IL_023f: Expected O, but got I4
		//IL_014f: Expected O, but got Ref
		//IL_0092: Expected O, but got I
		//IL_00e1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_0274: Expected O, but got I4
		//IL_01ba: Expected O, but got I4
		//IL_02ac: Expected O, but got I4
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_030b: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 4080;
		object obj3 = (nint)0 + (nint)2624;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum> action = default(Action<System.Int32Enum>);
		action..ctor((object)this, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+8]");
		Delegate obj7 = Delegate.Combine((Delegate)0, action);
		object obj14;
		object obj15;
		if ((object)obj7 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			object obj8 = default(object);
			if (obj8 == null)
			{
				throw new InvalidCastException();
			}
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v18+B8]");
			object obj10 = (nint)0 + (nint)8;
			obj10 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			object obj11 = default(object);
			if (obj11 == null)
			{
				throw new InvalidCastException();
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D4A]");
			object obj12 = (nint)0 & (nint)1;
			bool flag2 = obj12 == null;
			object obj13 = !flag2;
			obj14 = obj11;
			obj15 = obj11;
			if (obj13 == null)
			{
				goto IL_0119;
			}
		}
		else
		{
			object obj16 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v13+B8]");
			object obj17 = (nint)0 + (nint)8;
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8D4A]");
			object obj18 = (nint)0 & (nint)1;
			bool flag3 = obj18 == null;
			obj14 = 0;
			if (flag3)
			{
				goto IL_0119;
			}
			obj15 = 0;
		}
		goto IL_0398;
		IL_0398:
		object format = "Complete" + 3440;
		object obj19 = typeof(DataRelation) + 856;
		object obj20 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj21 = !flag4;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6A60");
		object obj22 = default(object);
		string arg = ((Enum)(&obj22)).ToString();
		string message = string.Format((string)format, arg);
		object obj23 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v8+E4]");
		object obj24 = default(object);
		if ((nint)0 != 0)
		{
			Debug.Log(message);
			bool flag5 = (nint)obj24 != 3;
			object obj25 = 0;
			if (!flag5)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Debug.Log(message);
			bool flag6 = (nint)obj24 == 3;
			object obj25 = 0;
			if (flag6)
			{
				return;
			}
		}
		object obj26 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X0_v17+E4]");
		bool flag7 = (nint)0 == 0;
		object obj27 = !flag7;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message2 = "Read object reference Id '{0}' for {1}." + 2608;
		Debug.Log(message2);
		object obj28 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v21+E4]");
		bool flag8 = (nint)0 == 0;
		object obj29 = !flag8;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AppTrackingTransparency.RequestTrackingAuthorization();
		return;
		IL_0119:
		_ = 1;
		obj15 = obj14;
		goto IL_0398;
	}

	private void OnAuthorizationRequestDone(AppTrackingTransparency.AuthorizationStatus status)
	{
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dc: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_0299: Expected O, but got I4
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0245: Expected O, but got I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01d8: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_007b: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 248;
		object obj2 = typeof(DataRelation) + 856;
		AppTrackingTransparency.AuthorizationStatus authorizationStatus = default(AppTrackingTransparency.AuthorizationStatus);
		object obj4;
		object obj6;
		if (authorizationStatus <= AppTrackingTransparency.AuthorizationStatus.RESTRICTED)
		{
			if (authorizationStatus != AppTrackingTransparency.AuthorizationStatus.NOT_DETERMINED)
			{
				if (authorizationStatus != AppTrackingTransparency.AuthorizationStatus.RESTRICTED)
				{
					goto IL_00b6;
				}
				object obj3 = obj2;
				obj4 = "Added Tournament Prizes And Features" + 3904;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v17+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				obj6 = obj4;
				if (obj5 == null)
				{
					goto IL_0091;
				}
			}
			else
			{
				object obj3 = obj2;
				obj6 = "Added Tournament Prizes And Features" + 3896;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v17+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 == null)
				{
					obj4 = obj6;
					goto IL_0091;
				}
			}
		}
		else if (authorizationStatus != AppTrackingTransparency.AuthorizationStatus.DENIED)
		{
			if (authorizationStatus != AppTrackingTransparency.AuthorizationStatus.AUTHORIZED)
			{
				goto IL_00b6;
			}
			object obj3 = obj2;
			obj6 = "Added Tournament Prizes And Features" + 3880;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v17+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				obj4 = obj6;
				goto IL_0091;
			}
		}
		else
		{
			object obj3 = obj2;
			obj6 = "Added Tournament Prizes And Features" + 3888;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v17+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				obj4 = obj6;
				goto IL_0091;
			}
		}
		goto IL_00a8;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj4;
		goto IL_00a8;
		IL_00a8:
		Debug.Log(obj6);
		goto IL_00b6;
		IL_00b6:
		object format = "HH:mm:ss.ffZ" + 2432;
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v6+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string arg = AppTrackingTransparency.IdentifierForAdvertising();
		string message = string.Format((string)format, arg);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			Debug.Log(message);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Debug.Log(message);
	}
}
