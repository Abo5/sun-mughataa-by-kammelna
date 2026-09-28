using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;

public class SettingsSubscriptionSection : MonoBehaviour
{
	public TextMeshProUGUI freeDays;

	public TextMeshProUGUI paidDays;

	private GameObject freeDaysObject;

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0122: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6974]");
		object obj3 = (nint)0 & (nint)1;
		TextMeshProUGUI tm;
		object obj6;
		TextMeshProUGUI textMeshProUGUI;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			tm = paidDays;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			textMeshProUGUI = paidDays;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			tm = paidDays;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			textMeshProUGUI = paidDays;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		tm = textMeshProUGUI;
		goto IL_0170;
		IL_0170:
		object varName = "rightCtrl" + 1384;
		object obj8 = ", stale={0}" + 3424;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		VariableBinderExtensions.Bind(tm, localUser, (string)varName, (string)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName2 = "fetch_products" + 1552;
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		VariableBinderExtensions.Bind(freeDays, localUser2, (string)varName2, (string)obj8);
		string text = freeDays.text;
		bool active = text != (string)obj8;
		freeDaysObject.SetActive(active);
		return;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag3 = (object)sessionModel == null;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0170;
	}

	private void SetFreeDaysVisibility()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = ", stale={0}" + 3424;
		string text = freeDays.text;
		bool active = text != (string)obj;
		freeDaysObject.SetActive(active);
	}
}
