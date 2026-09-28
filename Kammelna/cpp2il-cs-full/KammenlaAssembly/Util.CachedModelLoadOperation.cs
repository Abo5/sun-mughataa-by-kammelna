using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using UnityEngine;
using UnityEngine.TextCore;

namespace Util;

public class CachedModelLoadOperation : CustomYieldInstruction
{
	private bool _keepWaiting;

	private readonly ICachedModel <Model>k__BackingField;

	public override bool keepWaiting => _keepWaiting;

	public ICachedModel Model => <Model>k__BackingField;

	public CachedModelLoadOperation(ICachedModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0055: Expected I, but got O
		//IL_0065: Expected O, but got I
		//IL_020d: Expected I, but got O
		//IL_00a0: Expected O, but got I
		//IL_0148: Expected O, but got I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		object obj = typeof(SqlSingle[]) + 2376;
		_keepWaiting = true;
		base..ctor();
		object obj2 = this + 24;
		obj2 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1344;
		object obj5 = (nint)0 + (nint)2016;
		object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		nint num = (nint)obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6 (Il2CppClass<System.Object>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6 (Il2CppClass<System.Object>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v6 (Il2CppClass<System.Object>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X10_v5-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj8 += 16;
			obj7--;
			if ((nint)obj7 != 1)
			{
				continue;
			}
			goto IL_00e1;
		}
		object obj9 = (object)(num + (object)(obj8 + 8)) + 312;
		goto IL_01dc;
		IL_00e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_01dc;
		IL_01dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v8+8]");
		Action action = default(Action);
		action..ctor(obj3, (IntPtr)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj5);
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v12+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		KUtil.SwitchToBackground(action, action2);
	}

	private void <.ctor>b__6_0()
	{
		_keepWaiting = false;
	}
}
