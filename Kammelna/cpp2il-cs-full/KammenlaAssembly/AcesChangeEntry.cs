using System;
using System.Data;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class AcesChangeEntry : MonoBehaviour
{
	private TextMeshProUGUI timeField;

	private TextMeshProUGUI typeField;

	private TextMeshProUGUI amountField;

	public void Populate(AcesChange acesChange)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0058: Expected O, but got I4
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
		object obj2 = typeof(DataRelation) + 712;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = "utf-32" + 3024;
		CultureInfo invariantCulture = CultureInfo.InvariantCulture;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime = default(DateTime);
		string text = dateTime.ToString((string)obj5, invariantCulture);
		timeField.text = text;
		typeField.text = acesChange.<type>k__BackingField;
		long num = default(long);
		string text2 = num.ToString();
		amountField.text = text2;
	}
}
