using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;

public class AcesText : MonoBehaviour
{
	private bool useCommas;

	private TextMeshProUGUI textMesh;

	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_011e: Expected O, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_016f: Expected O, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00f6: Expected I, but got O
		object obj = (nint)0 + (nint)384;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31418");
		object obj4 = this + 40;
		object obj5 = default(object);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		TextMeshProExtensions.SetNumber((TextMeshProUGUI)obj4, aces, useCommas);
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)1584;
		object varName = "___# Content push apply failed [{0}]: {1}" + 2920;
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj9);
		VariableBinderExtensions.Bind(go, localUser2, (string)varName, action);
	}

	private void <Start>b__2_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0167: Expected O, but got I
		//IL_019b: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_0111: Expected O, but got I4
		//IL_01ee: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E79F5]");
		object obj3 = (nint)0 & (nint)1;
		TextMeshProUGUI target;
		TextMeshProUGUI textMeshProUGUI;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			target = textMesh;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			textMeshProUGUI = textMesh;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			target = textMesh;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			textMeshProUGUI = textMesh;
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
		target = textMeshProUGUI;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00b4;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00b4;
		IL_00b4:
		object obj9 = typeof(SqlSingle[]) + 3912;
		User localUser = sessionModel.LocalUser;
		int aces = SFSKammelnaUserExtensions.GetAces(localUser);
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v20+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tweener tweener = AnimationExtensions.DONumber(target, aces, 0.3f, useCommas);
	}
}
