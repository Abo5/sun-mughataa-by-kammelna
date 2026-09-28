using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using KammelnaOffline;
using Mono.Btls;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.Purchasing.Telemetry;

public class OfflineBottomBar : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<GameObject> <>9__5_0;

		public static Action<GameObject> <>9__5_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Start>b__5_0(GameObject o)
		{
			bool canResume = OfflineUserInfo.CanResume;
			bool active = (byte)((canResume ? 1u : 0u) ^ 1u) != 0;
			o.SetActive(active);
		}

		internal void <Start>b__5_1(GameObject o)
		{
			bool canResume = OfflineUserInfo.CanResume;
			o.SetActive(canResume);
		}
	}

	private SlideAnimationHelper slider;

	private GameObject[] normalState;

	private GameObject[] resumeState;

	private GameEventsChannel gameEventsChannel;

	private KGame _game;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0450: Expected O, but got I
		//IL_047a: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_0166: Expected O, but got I
		//IL_0176: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_0209: Expected O, but got I
		//IL_00e1: Expected O, but got I
		//IL_00f1: Expected O, but got I
		//IL_0113: Expected O, but got I4
		//IL_02fc: Expected O, but got I
		//IL_030c: Expected O, but got I
		//IL_032e: Expected O, but got I4
		//IL_01c8: Expected O, but got I4
		//IL_02c7: Expected O, but got I4
		//IL_0255: Expected O, but got I
		//IL_0265: Expected O, but got I
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_04b2: Expected O, but got I
		//IL_04c3: Expected I, but got O
		//IL_04e1: Expected O, but got I
		//IL_04fc: Expected O, but got I4
		//IL_035e: Expected O, but got I4
		//IL_01f8: Expected O, but got I
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_0533: Expected O, but got I
		//IL_0544: Expected I, but got O
		//IL_0562: Expected O, but got I
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_03bd: Expected O, but got I4
		//IL_038e: Expected O, but got I
		//IL_041a: Expected O, but got I
		//IL_0428: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 64;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Room room = ((KGame)obj5).Room;
		object obj7;
		object obj9;
		Action<object> action;
		if (SFSKammelnaRoomExtensions.IsOffline(room))
		{
			obj7 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1488;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v40+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v40+B8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v26+8]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v26+8]");
				bool flag2 = (nint)0 == 0;
				object obj10 = !flag2;
				if (obj10 == null)
				{
					goto IL_01a6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v40+B8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v26+8]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v26+8]");
				bool flag3 = (nint)0 == 0;
				object obj11 = !flag3;
				if (obj11 == null)
				{
					goto IL_01a6;
				}
			}
			goto IL_01fd;
		}
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
		return;
		IL_028a:
		object obj13;
		object obj12 = obj13;
		Action<object> action2;
		ArraysExtensions.ForEach(resumeState, action2);
		SlideAnimationHelper slideAnimationHelper = slider;
		bool flag4 = (object)slider == null;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_03c2;
		IL_01fd:
		obj13 = (nint)0 + (nint)2160;
		ArraysExtensions.ForEach(normalState, action);
		object obj15 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v25+E4]");
		object obj16;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v25+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v14+10]");
			action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v14+10]");
			if ((nint)0 != 0)
			{
				goto IL_028a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v25+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v14+10]");
			action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v14+10]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			if (obj17 != null)
			{
				goto IL_028a;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v25+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj19 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v20+B8]");
			obj16 = 0;
		}
		object obj20 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = (nint)0 + (nint)3936;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj16, (IntPtr)obj21);
		object obj22 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v19+B8]");
		object obj23 = (nint)0 + (nint)16;
		obj23 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj12 = obj13;
		ArraysExtensions.ForEach(resumeState, action3);
		slideAnimationHelper = slider;
		object obj24 = 0;
		goto IL_03c2;
		IL_03c2:
		slideAnimationHelper.HideImmediate();
		slider.SlideIn();
		gameEventsChannel.TriggerShowOfflineUi();
		object obj25 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj26 = (nint)0 + (nint)1728;
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj26);
		gameEventsChannel.HideUi += action4;
		return;
		IL_01a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v40+E4]");
		bool flag7 = (nint)0 == 0;
		object obj27 = !flag7;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj28 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v32+B8]");
			obj9 = 0;
		}
		object obj29 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj30 = (nint)0 + (nint)3928;
		Action<object> action5 = default(Action<object>);
		action5..ctor(obj9, (IntPtr)obj30);
		object obj31 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v31+B8]");
		object obj32 = (nint)0 + (nint)8;
		obj32 = action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj24 = 0;
		action = action5;
		goto IL_01fd;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		gameEventsChannel.HideUi -= action;
	}

	public void Hide()
	{
		slider.SlideOut();
	}

	public void StartGame()
	{
		slider.SlideOut();
		_game.SendGameLoaded();
		((OfflineBottomBar)(object)_game).TrackPlayOffline();
	}

	public void ResumeGame()
	{
		slider.SlideOut();
		_game.SendResumeLastGame();
		((OfflineBottomBar)(object)_game).TrackPlayOffline();
	}

	private void TrackPlayOffline()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_007c: Expected O, but got I
		//IL_00dc: Expected O, but got I4
		object obj = "not" + 1032;
		object obj2 = "not" + 1568;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj4 = "placementId" + 88;
		object type = (nint)0 + (nint)2000;
		object obj5 = ((UnityEngine.Device.Application.internetReachability != NetworkReachability.NotReachable) ? obj2 : obj);
		ITrackEvent trackEvent = TrackerLibrary.MenuOfflinePlayClicked((string)obj5);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		string action = (string)obj4 + (string)obj5;
		FirebaseTrack.Event(action, (string)type);
	}
}
