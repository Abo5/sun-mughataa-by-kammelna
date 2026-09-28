using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class SettingReplaysSection : MonoBehaviour
{
	private Button _replaysButton;

	private PrefabInitializer _warningPrefabInitializer;

	private PrefabInitializer _replaysListPrefabInitializer;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button replaysButton = _replaysButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		replaysButton.m_OnClick.AddListener(unityAction);
	}

	private void ReplayButtonWarningOnClick()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00aa: Expected O, but got I4
		object obj = typeof(UsageHint) + 72;
		_replaysListPrefabInitializer.Initialize();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (UserInfo.DoNotShowGameReplaysWarning)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool doNotShowGameReplaysWarning = UserInfo.DoNotShowGameReplaysWarning;
			bool flag = !doNotShowGameReplaysWarning;
			object obj3 = !flag;
			if (obj3 != null)
			{
				return;
			}
		}
		_warningPrefabInitializer.Initialize();
	}
}
