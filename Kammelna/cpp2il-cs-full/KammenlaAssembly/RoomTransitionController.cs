using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class RoomTransitionController : Singleton<RoomTransitionController>
{
	protected override void OnAwake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00dc: Expected I, but got O
		//IL_0106: Expected O, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 528;
		object obj2 = (nint)0 + (nint)3040;
		object obj3 = typeof(RegisteredWaitHandle) + 2944;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
		unityAction..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		GameObject target = base.gameObject;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			UnityEngine.Object.DontDestroyOnLoad(target);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.DontDestroyOnLoad(target);
	}

	protected void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 528;
		object obj2 = (nint)0 + (nint)3040;
		object obj3 = typeof(RegisteredWaitHandle) + 2944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
		unityAction..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	public RoomTransitionController()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 808;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E65FF]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2120;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2120;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}
}
