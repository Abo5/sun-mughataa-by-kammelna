using System;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

public class FTNavigator : MonoBehaviour
{
	private sealed class <>c__DisplayClass3_0
	{
		public RoutingCommand command;

		public string commandParam;

		internal void <OnRoute>b__0(AsyncOperationHandle<SceneInstance> loadedScene)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0064: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 1552;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RoutingManager.TriggerRoute(command, commandParam);
		}
	}

	private RoutingEventsChannel _routingEventsChannel;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 656;
		object obj2 = (nint)0 + (nint)2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum, object> action = default(Action<System.Int32Enum, object>);
		action..ctor((object)this, (IntPtr)obj2);
		_routingEventsChannel.OnRoute += (Action<RoutingCommand, string>)(object)action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(Action<CriteriaSection.PerformanceCriteria>) + 656;
		object obj2 = (nint)0 + (nint)2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<System.Int32Enum, object> action = default(Action<System.Int32Enum, object>);
		action..ctor((object)this, (IntPtr)obj2);
		_routingEventsChannel.OnRoute -= (Action<RoutingCommand, string>)(object)action;
	}

	private void OnRoute(RoutingCommand command, string commandParam)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0058: Expected O, but got I8
		//IL_0072: Expected O, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_009a: Expected O, but got I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I4
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0173: Expected O, but got I
		//IL_0184: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 2152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = commandParam;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X22_v3-8]");
		object obj4 = 0 + 4294960296L;
		bool flag = (nint)obj4 < 5;
		object obj5 = !flag;
		object obj6 = obj4 - 5;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		object obj8 = obj5 & obj7;
		if (obj8 == null)
		{
			object serverID = ", stale={0}" + 3424;
			SFS.SwitchServer((string)serverID);
			bool isTablet = ScreenUtility.IsTablet;
			bool flag3 = !isTablet;
			object obj9 = !flag3;
			object obj10 = ~obj9;
			Scenes scene = ((obj10 != null) ? Scenes.Menu : Scenes.Store);
			object obj11 = typeof(RegisteredWaitHandle) + 3136;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v11+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(scene);
			object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 216;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)3488;
			Action<AsyncOperationHandle<SceneInstance>> action = default(Action<AsyncOperationHandle<SceneInstance>>);
			action..ctor(obj2, (IntPtr)obj15);
			AsyncOperationHandle<SceneInstance> asyncOperationHandle2 = default(AsyncOperationHandle<SceneInstance>);
			asyncOperationHandle2.Completed += action;
		}
	}
}
