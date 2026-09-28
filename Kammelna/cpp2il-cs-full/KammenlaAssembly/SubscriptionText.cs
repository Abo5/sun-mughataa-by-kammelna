using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;

public class SubscriptionText : MonoBehaviour
{
	private TextMeshProUGUI _textMesh;

	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_00fc: Expected O, but got I
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_004f: Expected O, but got I4
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_009b: Expected O, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00d4: Expected I, but got O
		object obj = (nint)0 + (nint)152;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj4 = this + 32;
		object obj5 = default(object);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go = base.gameObject;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)2936;
		object varName = "setMimeType" + 3808;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj9);
		VariableBinderExtensions.Bind(go, localUser, (string)varName, action);
	}

	private void <Start>b__1_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0153: Expected O, but got I
		//IL_0187: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_0110: Expected O, but got I4
		//IL_01da: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A27]");
		object obj3 = (nint)0 & (nint)1;
		TextMeshProUGUI textMesh;
		TextMeshProUGUI textMesh2;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			textMesh = _textMesh;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			textMesh2 = _textMesh;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			textMesh = _textMesh;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			textMesh2 = _textMesh;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		textMesh = textMesh2;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00b4;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00b4;
		IL_00b4:
		object obj9 = "SubscribeGroup request Error" + 16;
		object obj10 = "Network Authentication Required" + 1456;
		User localUser = sessionModel.LocalUser;
		bool flag4 = SFSKammelnaUserExtensions.IsSubscribed(localUser);
		bool flag5 = !flag4;
		object obj11 = !flag5;
		object obj12 = ~obj11;
		object text = ((obj12 != null) ? obj10 : obj9);
		TextMeshProExtensions.Localize(textMesh, (string)text);
	}
}
