using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

namespace Util;

public class KammelnaResponseModelParseOperation<T> : CustomYieldInstruction
{
	private bool _keepWaiting;

	private readonly KammelnaResponseModel<T> <Model>k__BackingField;

	public override bool keepWaiting => _keepWaiting;

	public KammelnaResponseModel<T> Model => <Model>k__BackingField;

	public KammelnaResponseModelParseOperation(KammelnaResponseModel<T> model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00a1: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		_keepWaiting = true;
		base..ctor();
		object obj3 = this + 24;
		obj3 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = 0;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v5 (Il2CppRgctx<Util.KammelnaResponseModelParseOperation`1>)+18]");
		Action action = default(Action);
		action..ctor(obj4, (IntPtr)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v7 (Il2CppRgctx<Util.KammelnaResponseModelParseOperation`1>)+20]");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)0);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v9+E4]");
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
