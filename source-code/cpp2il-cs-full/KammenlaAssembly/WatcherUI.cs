using System;
using Cpp2ILInjected;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;

public class WatcherUI : AvatarInitializer
{
	private WatchersListManager manager;

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_003b: Expected O, but got I
		//IL_0049: Expected I, but got O
		//IL_0063: Expected O, but got I
		object obj = (nint)0 + (nint)944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj2 = default(object);
		if (obj2 != null)
		{
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = (nint)0 + (nint)3824;
			UnityAction unityAction = default(UnityAction);
			unityAction..ctor(this, (IntPtr)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ stack_-38_v2+100]");
			((UnityEvent)0).AddListener(unityAction);
		}
	}

	public void SetManager(WatchersListManager manager)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 176;
		obj = manager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnClicked()
	{
		WatchersListManager watchersListManager = manager;
		int num = default(int);
		string dbId = num.ToString();
		watchersListManager.gameEventsChannel.TriggerWatcherClicked(dbId);
	}
}
