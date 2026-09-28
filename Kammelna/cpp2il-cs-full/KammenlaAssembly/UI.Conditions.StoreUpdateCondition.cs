using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;

namespace UI.Conditions;

[Serializable]
public class StoreUpdateCondition : BoolCondition
{
	protected override bool ActualValue
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_014b: Expected O, but got I
			//IL_0175: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01dd: Expected I4, but got O
			//IL_00dc: Expected I4, but got O
			//IL_01be: Expected O, but got I4
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected O, but got Unknown
			object obj = 152989696;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E22]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
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
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_01cc;
			IL_01e2:
			bool result;
			return result;
			IL_00b8:
			User localUser = sessionModel.LocalUser;
			bool flag4 = localUser == null;
			result = (byte)(int)localUser != 0;
			if (!flag4)
			{
				object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v20+E4]");
				if ((nint)0 != 0)
				{
					return Store.HasNewStoreSinceLastVisit;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return Store.HasNewStoreSinceLastVisit;
			}
			goto IL_01e2;
			IL_01cc:
			NullReferenceException ex = new NullReferenceException();
			result = (byte)(int)ex != 0;
			goto IL_01e2;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_01cc;
		}
	}

	public override void Setup(GameObject gm)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00eb: Expected I, but got O
		//IL_0115: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0098: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)560;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.OnLastStoreDateUpdated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj2);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Config.OnLastUpdatesChanged += action2;
	}

	public override void Teardown()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00eb: Expected I, but got O
		//IL_0115: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0098: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)560;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.OnLastStoreDateUpdated -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj2);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Config.OnLastUpdatesChanged -= action2;
	}

	public StoreUpdateCondition()
	{
		isActive = true;
		((object)this)..ctor();
	}
}
