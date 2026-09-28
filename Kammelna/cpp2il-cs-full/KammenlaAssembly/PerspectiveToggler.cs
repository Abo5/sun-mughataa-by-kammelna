using System;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.UI;

public class PerspectiveToggler : MonoBehaviour
{
	private Button togglePerspectiveButton;

	private SpriteToggler currentPerspectiveIconToggler;

	private GameEventsChannel gameEventsChannel;

	private bool isButtonHeldDown;

	private int gameReloadCountDown;

	private const int frameToHoldForReload = 300;

	private KGameVisualControls visualControls;

	private bool isCurrentPerspectiveTopDown
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected O, but got Unknown
			//IL_0162: Expected O, but got I4
			//IL_00c4: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_01d8: Expected O, but got I
			//IL_0202: Expected O, but got I4
			//IL_01b9: Expected O, but got I4
			//IL_0262: Expected O, but got I4
			//IL_027e: Expected I4, but got O
			object obj = 152985600;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E672A]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			UnityEngine.Object obj5;
			UnityEngine.Object obj7;
			object obj8;
			if (obj3 != null)
			{
				obj4 = this + 64;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v12+E4]");
				bool flag = (nint)0 == 0;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (!flag)
				{
					goto IL_00a0;
				}
			}
			else
			{
				_ = 1;
				obj4 = this + 64;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v12+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (obj9 != null)
				{
					goto IL_00a0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj7 == null;
			bool flag4 = !flag3;
			obj4 = obj8;
			object obj10 = 0;
			UnityEngine.Object obj11 = null;
			if (flag4)
			{
				goto IL_00e8;
			}
			goto IL_01cc;
			IL_00e8:
			KGameVisualControls kGameVisualControls = (KGameVisualControls)obj4;
			if (obj4 != null)
			{
				goto IL_010d;
			}
			goto IL_0270;
			IL_0270:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_010d:
			return kGameVisualControls.IsCurrentPerspectiveTopDown;
			IL_00a0:
			bool flag5 = obj5 == null;
			bool flag6 = !flag5;
			object obj12 = !flag6;
			obj10 = 0;
			obj11 = null;
			obj8 = obj4;
			if (obj12 == null)
			{
				goto IL_00e8;
			}
			goto IL_01cc;
			IL_01cc:
			object obj13 = (nint)0 + (nint)144;
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v4+E4]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			object obj16 = default(object);
			obj8 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			kGameVisualControls = (KGameVisualControls)obj8;
			bool flag8 = obj8 == null;
			object obj17 = !flag8;
			if (obj17 != null)
			{
				goto IL_010d;
			}
			goto IL_0270;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_010b: Expected O, but got I
		//IL_0135: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00af: Expected O, but got I
		//IL_00c7: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)144;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj4 = (nint)0 + (nint)3192;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 64;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj4);
		gameEventsChannel.OnGamePerspectiveChanged += action;
		Button button = togglePerspectiveButton;
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj10 = (nint)0 + (nint)3184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj10);
		button.m_OnClick.AddListener(unityAction);
	}

	private void Start()
	{
		bool isON = visualControls.IsCurrentPerspectiveTopDown;
		currentPerspectiveIconToggler.ToggleManual(isON);
	}

	private void Update()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		if (isButtonHeldDown)
		{
			if (++gameReloadCountDown >= 301)
			{
				object obj = typeof(RegisteredWaitHandle) + 3136;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
			}
		}
		else
		{
			gameReloadCountDown = 0;
		}
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)3192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		gameEventsChannel.OnGamePerspectiveChanged -= action;
	}

	public void OnPointerDown()
	{
		isButtonHeldDown = true;
	}

	public void OnPointerUp()
	{
		isButtonHeldDown = false;
	}

	private void OnGamePerspectiveChanged(bool isPerspectiveTopDown)
	{
		currentPerspectiveIconToggler.ToggleManual(isPerspectiveTopDown);
	}

	private void <Awake>b__9_0()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		bool flag = isCurrentPerspectiveTopDown;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		bool isPerspectiveTopDown = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		gameEventsChannel.TriggerGamePerspectiveChanged(isPerspectiveTopDown);
		bool state = isCurrentPerspectiveTopDown;
		ITrackEvent trackEvent = TrackerLibrary.GamePerspectiveChangeClicked(state);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}
}
