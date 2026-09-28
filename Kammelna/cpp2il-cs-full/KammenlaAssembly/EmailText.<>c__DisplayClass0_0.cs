using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;

public class EmailText : MonoBehaviour
{
	private sealed class <>c__DisplayClass0_0
	{
		public InputFieldTMProUGUI inputField;

		internal void <Start>b__0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ee: Expected O, but got I
			//IL_0122: Expected O, but got I4
			//IL_00c9: Expected O, but got I4
			//IL_005c: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A17]");
			object obj3 = (nint)0 & (nint)1;
			InputFieldTMProUGUI inputFieldTMProUGUI;
			InputFieldTMProUGUI inputFieldTMProUGUI2;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				inputFieldTMProUGUI = inputField;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				inputFieldTMProUGUI2 = inputField;
				if (!flag)
				{
					goto IL_00a5;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2200;
				inputFieldTMProUGUI = inputField;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				inputFieldTMProUGUI2 = inputField;
				if (obj7 != null)
				{
					goto IL_00a5;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			inputFieldTMProUGUI = inputFieldTMProUGUI2;
			goto IL_0168;
			IL_0168:
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			string email = SFSKammelnaUserExtensions.GetEmail(localUser);
			inputFieldTMProUGUI.Text = email;
			return;
			IL_00a5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0168;
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_015e: Expected O, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I4
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Unknown
		//IL_01c3: Expected O, but got I4
		//IL_00cb: Expected O, but got I
		//IL_01ec: Expected O, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0116: Expected O, but got I
		//IL_0127: Expected I, but got O
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		object obj = typeof(DebugUI.BitField) + 1352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = (nint)0 + (nint)1016;
		object obj4 = obj2 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj5 = default(object);
		if (obj5 != null)
		{
			GameObject go = base.gameObject;
			object obj6 = typeof(Queue<string>) + 848;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v20+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj9 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			object obj10 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)2896;
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj11);
			object varName = "destinationTimeZone" + 1040;
			VariableBinderExtensions.Bind(go, localUser, (string)varName, action);
			return;
		}
		object obj12 = (nint)0 + (nint)1184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj13 = default(object);
		if (obj13 != null)
		{
			object obj14 = typeof(Queue<string>) + 848;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj16 = !flag2;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj17 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			object varName2 = "destinationTimeZone" + 1040;
			object defaultValue = "Material with texture name \"" + 3392;
			TextMeshProUGUI tm = default(TextMeshProUGUI);
			VariableBinderExtensions.Bind(tm, localUser2, (string)varName2, (string)defaultValue);
		}
	}
}
