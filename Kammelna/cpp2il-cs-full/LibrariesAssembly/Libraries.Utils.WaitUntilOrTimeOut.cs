using System;
using System.Diagnostics;
using System.Formats.Asn1;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

namespace Libraries.Utils;

public class WaitUntilOrTimeOut : CustomYieldInstruction
{
	private readonly Func<bool> _predicate;

	private readonly Stopwatch _stopwatch;

	private readonly TimeSpan _timeout;

	public override bool keepWaiting
	{
		get
		{
			//IL_00fc: Expected I4, but got O
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected O, but got Unknown
			Func<bool> predicate = _predicate;
			if (_predicate != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v38 @ X8_v3 (System.Func`1<System.Boolean>)+18] (should have been resolved before IL gen)");
				object obj2 = default(object);
				object obj = obj2 & 1;
				if (obj != null)
				{
					return false;
				}
				if (_stopwatch != null)
				{
					TimeSpan elapsed = _stopwatch.Elapsed;
					object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+E4]");
					if ((nint)0 != 0)
					{
						return elapsed < _timeout;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					return elapsed < _timeout;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public WaitUntilOrTimeOut(Func<bool> predicate, TimeSpan timeout)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_00a6: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1952;
		base..ctor();
		object obj2 = this + 16;
		obj2 = predicate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Stopwatch stopwatch = Stopwatch.StartNew();
		object obj5 = this + 24;
		obj5 = stopwatch;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
