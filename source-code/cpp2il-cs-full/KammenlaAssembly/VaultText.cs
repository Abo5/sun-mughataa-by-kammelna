using System;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using TMPro;
using UnityEngine;

public class VaultText : MonoBehaviour
{
	private bool useCommas;

	private TextMeshProUGUI textMesh;

	private void OnEnable()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002c: Expected O, but got I
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0093: Expected I, but got O
		object obj = (nint)0 + (nint)384;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)2184;
		object scope = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3440;
		object variableName = "utf-32" + 336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31418");
		object obj4 = this + 40;
		object obj5 = default(object);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int vaultBalance = GetVaultBalance();
		TextMeshProExtensions.SetNumber((TextMeshProUGUI)obj4, vaultBalance, useCommas);
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		CoordinatorVariableBinderExtensions.Bind(go, (string)scope, (string)variableName, action);
	}

	private void OnDisable()
	{
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
	}

	private static int GetVaultBalance()
	{
		//IL_0016: Expected O, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0184: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0210: Expected I4, but got O
		//IL_01d2: Expected O, but got I
		//IL_01f4: Expected O, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0122: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A31]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B5]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B5]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v5+B8]");
		object obj8 = 0;
		CoordinatorVariableBinder coordinatorVariableBinder = (CoordinatorVariableBinder)obj8;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_00bf;
		}
		goto IL_0202;
		IL_00bf:
		object scope = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3440;
		object variableName = "utf-32" + 336;
		string current = coordinatorVariableBinder.GetCurrent((string)scope, (string)variableName);
		int result;
		bool flag4 = int.TryParse(current, out result);
		bool flag5 = !flag4;
		object obj10 = !flag5;
		object obj11 = ~obj10;
		if (obj11 == null)
		{
			return result;
		}
		return 0;
		IL_0202:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0082:
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v14+B8]");
		object obj13 = 0;
		coordinatorVariableBinder = (CoordinatorVariableBinder)obj13;
		if (obj13 != null)
		{
			goto IL_00bf;
		}
		goto IL_0202;
	}

	private void <OnEnable>b__2_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0084: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 3912;
		int vaultBalance = GetVaultBalance();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tweener tweener = AnimationExtensions.DONumber(textMesh, vaultBalance, 0.3f, useCommas);
	}
}
