using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;

public class CallbackTweenAnim : TweenAnimBase
{
	private UnityEvent callback;

	public override GameObject target => null;

	public override Tween tween
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Expected O, but got Unknown
			//IL_0089: Expected O, but got I
			//IL_00b3: Expected O, but got I4
			//IL_004e: Expected I, but got O
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj3 = (nint)0 + (nint)2832;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence s = DOTween.Sequence();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(this, (IntPtr)obj3);
			return TweenSettingsExtensions.AppendCallback(s, tweenCallback);
		}
	}

	private void <get_tween>b__4_0()
	{
		callback.Invoke();
	}
}
