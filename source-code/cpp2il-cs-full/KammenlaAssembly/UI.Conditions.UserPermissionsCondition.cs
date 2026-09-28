using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server;
using Server.Models;
using Sfs2X.Core;
using Sfs2X.Entities;
using UnityEngine;

namespace UI.Conditions;

[Serializable]
public class UserPermissionsCondition : FlagsCondition<UserPermission>
{
	protected override UserPermission ActualValue
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0165: Expected I4, but got O
			//IL_01ac: Expected O, but got I4
			//IL_0227: Expected I4, but got O
			object obj = 152989696;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E37]");
			object obj3 = (nint)0 & (nint)1;
			object obj6;
			object obj4;
			if (obj3 != null)
			{
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v12+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v12+E4]");
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
			goto IL_0219;
			IL_0219:
			NullReferenceException ex = new NullReferenceException();
			return (UserPermission)ex;
			IL_0158:
			UserPermission userPermission = (UserPermission)sessionModel.LocalUser;
			if (userPermission != 0)
			{
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v5+E4]");
				bool flag4 = (nint)0 == 0;
				object obj9 = !flag4;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				if ((object)sessionModel2 != null)
				{
					User localUser = sessionModel2.LocalUser;
					return SFSKammelnaUserExtensions.GetUserPermissions(localUser);
				}
				goto IL_0219;
			}
			return userPermission;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag5 = (object)sessionModel == null;
			object obj10 = !flag5;
			if (obj10 != null)
			{
				goto IL_0158;
			}
			goto IL_0219;
		}
	}

	public override void Setup(GameObject gm)
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002c: Expected O, but got I
		//IL_005d: Expected I, but got O
		object obj = (nint)0 + (nint)3352;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
		object obj3 = (nint)0 + (nint)344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4AD859C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		SFS.OnLogin += action;
	}

	public override void Teardown()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002c: Expected O, but got I
		//IL_005d: Expected I, but got O
		object obj = (nint)0 + (nint)3360;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
		object obj3 = (nint)0 + (nint)344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4AD85A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		SFS.OnLogin -= action;
	}

	private void OnLogin(BaseEvent evt)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)3368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4AD85A4");
	}

	public UserPermissionsCondition()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)3344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4AD85B0");
	}
}
