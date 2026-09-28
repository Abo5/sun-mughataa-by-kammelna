using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MaintenanceNoticeListener : MonoBehaviour
{
	private AssetReferenceGameObject maintenanceNoticeUiRef;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		RegisterEvents();
		GameObject target = base.gameObject;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			UnityEngine.Object.DontDestroyOnLoad(target);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.DontDestroyOnLoad(target);
	}

	private void OnDestroy()
	{
		UnRegisterEvents();
	}

	private void RegisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_0071: Expected I, but got O
		//IL_00a0: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2600;
		object obj2 = (nint)0 + (nint)2488;
		object obj3 = typeof(TypeConverter<ushort, char>) + 528;
		object obj4 = (nint)0 + (nint)2496;
		object obj5 = typeof(RegisteredWaitHandle) + 2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnMaintenanceNotice += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
		unityAction..ctor((object)this, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
	}

	private void UnRegisterEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00df: Expected I, but got O
		//IL_0071: Expected I, but got O
		//IL_00a0: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2600;
		object obj2 = (nint)0 + (nint)2488;
		object obj3 = typeof(TypeConverter<ushort, char>) + 528;
		object obj4 = (nint)0 + (nint)2496;
		object obj5 = typeof(RegisteredWaitHandle) + 2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnMaintenanceNotice -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
		unityAction..ctor((object)this, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
	}

	private void OnSceneLoaded(Scene _, LoadSceneMode __)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_025f: Expected O, but got I
		//IL_0279: Expected O, but got I4
		//IL_0168: Expected O, but got I
		//IL_02ef: Expected O, but got I
		//IL_02ff: Expected O, but got I
		//IL_0321: Expected O, but got I4
		//IL_02b7: Expected O, but got I4
		//IL_01ca: Expected O, but got I
		//IL_01da: Expected O, but got I
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0360: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E720D]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v37+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			int num = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v37+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (Config.IsUnderMaintenance)
		{
			goto IL_0125;
		}
		return;
		IL_0185:
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v26+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = obj6;
		if (!flag3)
		{
			goto IL_01ba;
		}
		goto IL_02cd;
		IL_02cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v8+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v7+10]");
		MaintenanceInfo maintenanceInfo = (MaintenanceInfo)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v7+10]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01df;
		IL_01df:
		if (maintenanceInfo.IsUnderMaintenance())
		{
			object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v19+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PrefabInitializer.InitializePrefab(maintenanceNoticeUiRef);
		}
		return;
		IL_007c:
		bool isUnderMaintenance = Config.IsUnderMaintenance;
		bool flag6 = !isUnderMaintenance;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			return;
		}
		goto IL_0125;
		IL_0125:
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C4]");
			object obj16 = (nint)0 & (nint)1;
			if (obj16 != null)
			{
				goto IL_0185;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C4]");
			object obj17 = (nint)0 & (nint)1;
			bool flag7 = obj17 == null;
			object obj18 = !flag7;
			if (obj18 != null)
			{
				goto IL_0185;
			}
		}
		int num2 = 1;
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v26+E4]");
		bool flag8 = (nint)0 == 0;
		object obj19 = !flag8;
		obj7 = obj6;
		if (obj19 != null)
		{
			goto IL_01ba;
		}
		goto IL_02cd;
		IL_01ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v26+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v18+10]");
		maintenanceInfo = (MaintenanceInfo)0;
		goto IL_01df;
	}

	private void OnMaintenanceNotice(MaintenanceInfo maintenanceInfo)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_008a: Expected O, but got I4
		if (maintenanceInfo.IsUnderMaintenance())
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PrefabInitializer.InitializePrefab(maintenanceNoticeUiRef);
		}
	}

	private void InitializeNotice()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PrefabInitializer.InitializePrefab(maintenanceNoticeUiRef);
	}
}
