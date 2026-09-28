using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

public class JoinRoomUI : MonoBehaviour
{
	private const string OnlySubsCheatingRoomError = "only_subscribed_users_can_play_in_cheating_rooms";

	private const string OnlySubsJackarooRunningRoomError = "only_subscribed_users_can_play_in_running_rooms";

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00fd: Expected I, but got O
		//IL_0071: Expected I, but got O
		//IL_00b8: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)3848;
		object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 648;
		object obj4 = (nint)0 + (nint)3856;
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoom += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action2 = default(Action<object, object>);
		action2..ctor((object)this, (IntPtr)obj4);
		SFS.OnJoinRoomFailed += action2;
		GameObject gameObject = base.gameObject;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		UnityEngine.Object target = gameObject;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		UnityEngine.Object.DontDestroyOnLoad(target);
	}

	private void ShowError(string message)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object title = "SetRoomVariables request error" + 1584;
		object buttonText = "Network Authentication Required" + 3128;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowError((string)title, message, (string)buttonText);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_0084: Expected I, but got O
		//IL_005d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)3848;
		object obj3 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 648;
		object obj4 = (nint)0 + (nint)3856;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinRoom -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action2 = default(Action<object, object>);
		action2..ctor((object)this, (IntPtr)obj4);
		SFS.OnJoinRoomFailed -= action2;
	}

	private void OnJoinRoom(Room room)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00eb: Expected O, but got I4
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_022e: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_012e: Expected O, but got I4
		//IL_013f: Expected O, but got I4
		//IL_0287: Expected O, but got I4
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02d3: Expected O, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I
		//IL_0170: Expected O, but got I4
		//IL_0179: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_0378: Expected O, but got I4
		//IL_032c: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X10_v10-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj4 = obj3 + 6;
		object obj5 = num + obj4;
		object obj6 = obj5 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v36+8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v184 @ X0_v36] (should have been resolved before IL gen)");
		object obj8 = default(object);
		bool flag = obj8 == null;
		nint num3 = default(nint);
		nint num2 = num3;
		if (flag)
		{
			goto IL_010b;
		}
		goto IL_01f0;
		IL_014d:
		bool flag2 = SFSKammelnaRoomExtensions.IsMassTournament(room);
		bool flag3 = !flag2;
		object obj9 = !flag3;
		object obj10 = 0;
		if (obj9 == null)
		{
			return;
		}
		goto IL_033a;
		IL_0295:
		object obj11 = typeof(RegisteredWaitHandle) + 3136;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.LoadScene(Scenes.TournamentView);
		bool flag5 = SFSKammelnaRoomExtensions.IsMassTournament(room);
		bool flag6 = !flag5;
		num3 = num2;
		obj10 = 0;
		if (flag6)
		{
			return;
		}
		goto IL_033a;
		IL_010b:
		bool flag7 = SFSKammelnaRoomExtensions.IsTournamentHub(room);
		bool flag8 = !flag7;
		object obj14 = !flag8;
		num2 = num3;
		object obj15 = 0;
		if (obj14 == null)
		{
			goto IL_014d;
		}
		goto IL_0295;
		IL_033a:
		object obj16 = typeof(RegisteredWaitHandle) + 3136;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v4+E4]");
		bool flag9 = (nint)0 == 0;
		object obj18 = !flag9;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncOperationHandle<SceneInstance> asyncOperationHandle2 = ScreenManager.LoadScene(Scenes.MassTournament);
		return;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v33+8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v88 @ X0_v33] (should have been resolved before IL gen)");
		object obj19 = default(object);
		bool flag10 = obj19 == null;
		object obj20 = !flag10;
		num3 = 6;
		num2 = 6;
		if (obj20 == null)
		{
			goto IL_010b;
		}
		goto IL_01f0;
		IL_01f0:
		object obj21 = typeof(RegisteredWaitHandle) + 3136;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v18+E4]");
		bool flag11 = (nint)0 == 0;
		object obj23 = !flag11;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncOperationHandle<SceneInstance> asyncOperationHandle3 = ScreenManager.LoadScene(Scenes.Game);
		bool flag12 = SFSKammelnaRoomExtensions.IsTournamentHub(room);
		bool flag13 = !flag12;
		num3 = num2;
		obj15 = 0;
		if (flag13)
		{
			goto IL_014d;
		}
		goto IL_0295;
	}

	private void OnJoinRoomFailed(Room room, string error)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_018b: Expected O, but got I4
		//IL_0194: Expected O, but got I4
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_009c: Expected O, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01ea: Expected O, but got I4
		object obj = "not" + 1584;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		string text = (string)obj;
		bool flag = error == (string)obj;
		bool flag2 = !flag;
		object obj3 = !flag2;
		object obj4 = 0;
		if (obj3 == null)
		{
			object obj5 = "not" + 1592;
			text = (string)obj5;
			bool flag3 = error == (string)obj5;
			bool flag4 = !flag3;
			obj4 = 0;
			if (flag4)
			{
				object title = "SetRoomVariables request error" + 1584;
				object buttonText = "Network Authentication Required" + 3128;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v16+E4]");
				bool flag5 = (nint)0 == 0;
				object obj7 = !flag5;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				PopupWindow.ShowError((string)title, error, (string)buttonText);
				SplashAnimation.AnimateTransition();
				return;
			}
		}
		object obj8 = typeof(MemberAchievementClanFeedData) + 3448;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v5+E4]");
		bool flag6 = (nint)0 == 0;
		object obj10 = !flag6;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		OnlyForSubscribersPopup.Show(TrackingFeature.Rooms, null, error);
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			PopupWindow.DismissMessage();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.DismissMessage();
	}
}
