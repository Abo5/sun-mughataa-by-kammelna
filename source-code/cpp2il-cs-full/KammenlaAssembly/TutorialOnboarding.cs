using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.UI;

public class TutorialOnboarding : MonoBehaviour, IInitializable
{
	private CanvasGroup background;

	private GameObject content;

	private GameObject logo;

	private GameObject phone;

	private GameObject bottomPanel;

	private GameObject skipButton;

	private List<OnBoardingScreen> screens;

	private DiscreteProgressIndicator pagination;

	private int screenDisplayedNum;

	private Button doneButton;

	private Button NextScreenButton;

	private GameObject defaultBackground;

	private GameObject tabletBackground;

	private ServerFetcherEventsChannel serverFetcherEventsChannel;

	private readonly List<int> loggedScreens;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0115: Expected O, but got I4
		//IL_0151: Expected O, but got I4
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_0397: Expected O, but got I
		//IL_03a5: Expected I, but got O
		//IL_0199: Expected O, but got I
		//IL_02db: Expected O, but got I
		//IL_02f5: Expected O, but got I4
		//IL_01eb: Expected O, but got I
		//IL_0333: Expected O, but got I4
		//IL_024d: Expected O, but got I
		//IL_0256: Expected O, but got I4
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_029d: Expected O, but got I4
		object obj = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E602B]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool isNewPlayer = UserInfo.IsNewPlayer;
		bool flag2 = !isNewPlayer;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			return;
		}
		goto IL_0096;
		IL_023d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v40+B8]");
		object obj6 = 0;
		obj6 = 1;
		ITrackEvent trackEvent = TrackerLibrary.OnboardingTutorialStarted();
		object obj7 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v24+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tracker.DesignEvent(trackEvent);
		LogScreenToAnalytics(0);
		AnimationAwake();
		return;
		IL_0349:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj10 = obj;
		goto IL_023d;
		IL_0208:
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v40+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = obj10;
		if (!flag4)
		{
			goto IL_023d;
		}
		goto IL_0349;
		IL_0074:
		if (UserInfo.IsNewPlayer)
		{
			goto IL_0096;
		}
		return;
		IL_0096:
		GameObject gameObject;
		bool active;
		if (ScreenUtility.IsTablet)
		{
			tabletBackground.SetActive(value: true);
			gameObject = defaultBackground;
			active = false;
		}
		else
		{
			tabletBackground.SetActive(value: false);
			gameObject = defaultBackground;
			active = true;
		}
		gameObject.SetActive(active);
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)1968;
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj13);
		object obj14 = (nint)0 + (nint)1224;
		((List<object>)(object)screens).ForEach(action);
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v30+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4594]");
			object obj16 = (nint)0 & (nint)1;
			if (obj16 != null)
			{
				goto IL_0208;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4594]");
			object obj17 = (nint)0 & (nint)1;
			bool flag5 = obj17 == null;
			object obj18 = !flag5;
			if (obj18 != null)
			{
				goto IL_0208;
			}
		}
		_ = 1;
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v40+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		obj11 = obj10;
		if (obj19 != null)
		{
			goto IL_023d;
		}
		goto IL_0349;
	}

	public void Initialize()
	{
		AnimationStart();
	}

	public void OnSwipe(SwipeGesture swipeGesture)
	{
		if (swipeGesture.CardinalDirection != GestureDirection.Left)
		{
			if (swipeGesture.CardinalDirection == GestureDirection.Right)
			{
				List<OnBoardingScreen> list = screens;
				int num = screenDisplayedNum + 1;
				if (num < list._size)
				{
					ReplaceScreen(num, isNextScreen: true);
				}
			}
		}
		else
		{
			int newScreenNum = screenDisplayedNum - 1;
			if (screenDisplayedNum >= 1)
			{
				ReplaceScreen(newScreenNum, isNextScreen: false);
			}
		}
	}

	public void OnSkipClick()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E602C]");
		object obj3 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj3 != null)
		{
			CompleteOnboarding();
			trackEvent = TrackerLibrary.OnboardingTutorialSkipped();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			trackEvent2 = trackEvent;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			CompleteOnboarding();
			trackEvent = TrackerLibrary.OnboardingTutorialSkipped();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			trackEvent2 = trackEvent;
			if (obj5 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_0099:
		Tracker.DesignEvent(trackEvent);
	}

	public void OnDoneClick()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E602D]");
		object obj3 = (nint)0 & (nint)1;
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		if (obj3 != null)
		{
			CompleteOnboarding();
			trackEvent = TrackerLibrary.OnboardingTutorialCompleted();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			trackEvent2 = trackEvent;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			CompleteOnboarding();
			trackEvent = TrackerLibrary.OnboardingTutorialCompleted();
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			trackEvent2 = trackEvent;
			if (obj5 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_0099:
		Tracker.DesignEvent(trackEvent);
	}

	private void CompleteOnboarding()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0094: Expected O, but got I
		//IL_00be: Expected O, but got I4
		//IL_004f: Expected I, but got O
		object obj = typeof(UsageHint) + 72;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)2312;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UserInfo.SawOnboarding = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		AnimationExit(action);
		TabletSwitchPopup();
		serverFetcherEventsChannel.TriggerBoardingFinish();
	}

	public void ShowNext()
	{
		List<OnBoardingScreen> list = screens;
		int num = screenDisplayedNum + 1;
		if (num < list._size)
		{
			ReplaceScreen(num, isNextScreen: true);
		}
	}

	public void ShowPrev()
	{
		int newScreenNum = screenDisplayedNum - 1;
		if (screenDisplayedNum >= 1)
		{
			ReplaceScreen(newScreenNum, isNextScreen: false);
		}
	}

	private void ReplaceScreen(int newScreenNum, bool isNextScreen)
	{
		//IL_00fa: Expected O, but got I4
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected I4, but got Unknown
		//IL_015d: Expected O, but got I4
		//IL_018f: Expected F4, but got I4
		//IL_01c4: Expected O, but got I4
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected I4, but got Unknown
		//IL_0227: Expected O, but got I4
		//IL_0247: Expected F4, but got I4
		object obj = ((List<object>)(object)screens).get_Item(screenDisplayedNum);
		((OnBoardingScreen)obj).Hide(isNextScreen);
		object obj2 = ((List<object>)(object)screens).get_Item(newScreenNum);
		((OnBoardingScreen)obj2).Show(isNextScreen);
		int num = newScreenNum + 1;
		pagination.CurrentProgress = num;
		Transform target = NextScreenButton.transform;
		int num2 = ShortcutExtensions.DOKill(target, complete: true);
		Transform target2 = doneButton.transform;
		int num3 = ShortcutExtensions.DOKill(target2, complete: true);
		Transform target3 = NextScreenButton.transform;
		List<OnBoardingScreen> list = screens;
		object obj3 = num - list._size;
		bool flag = (nint)obj3 < 0;
		int num4 = num ^ list._size;
		int num5 = num ^ obj3;
		int num6 = num4 & num5;
		bool flag2 = num6 < 0;
		bool flag3 = flag == flag2;
		object obj4 = !flag3;
		object obj5 = ~obj4;
		float endValue = ((obj5 != null) ? 0f : 1f);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target3, endValue, 0.2f);
		Transform target4 = doneButton.transform;
		List<OnBoardingScreen> list2 = screens;
		object obj6 = num - list2._size;
		bool flag4 = (nint)obj6 < 0;
		int num7 = num ^ list2._size;
		int num8 = num ^ obj6;
		int num9 = num7 & num8;
		bool flag5 = num9 < 0;
		bool flag6 = flag4 == flag5;
		object obj7 = !flag6;
		object obj8 = ~obj7;
		float endValue2 = ((obj8 != null) ? 1f : 0f);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target4, endValue2, 0.2f);
		screenDisplayedNum = newScreenNum;
		LogScreenToAnalytics(newScreenNum);
	}

	private void LogScreenToAnalytics(int screenNum)
	{
		//IL_0011: Expected O, but got I
		//IL_003e: Expected O, but got I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0097: Expected O, but got I4
		//IL_00cc: Expected O, but got I
		//IL_00e1: Expected O, but got I
		//IL_010f: Expected O, but got I4
		//IL_0133: Expected O, but got I
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1368;
		bool flag = loggedScreens.Contains(screenNum);
		bool flag2 = !flag;
		object obj2 = !flag2;
		if (obj2 == null)
		{
			ITrackEvent trackEvent = TrackerLibrary.OnboardingTutorialScreenViewed(screenNum);
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			List<int> list = loggedScreens;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v10 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj6 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v10 (System.Collections.Generic.List`1<System.Int32>)+10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v10 (System.Collections.Generic.List`1<System.Int32>)+18]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X9_v6+18]");
			bool flag4 = num < 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v10 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj9 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v10 (System.Collections.Generic.List`1<System.Int32>)+18]");
				object obj10 = obj7 + 0;
			}
			else
			{
				list.AddWithResize(screenNum);
			}
		}
	}

	private static void TabletSwitchPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d2: Expected O, but got I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_0271: Expected O, but got I4
		//IL_0860: Unknown result type (might be due to invalid IL or missing references)
		//IL_0865: Expected O, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0872: Expected O, but got Unknown
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Expected O, but got Unknown
		//IL_0898: Expected O, but got I
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02d5: Expected I, but got O
		//IL_02e5: Expected O, but got I
		//IL_0397: Expected O, but got I4
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected I, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_043f: Expected O, but got I
		//IL_0320: Expected O, but got I
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Expected O, but got Unknown
		//IL_091e: Expected O, but got I
		//IL_092c: Expected I, but got O
		//IL_0936: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Expected I, but got Unknown
		//IL_094d: Expected O, but got I
		//IL_047a: Expected O, but got I
		//IL_051a: Expected O, but got I4
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f5: Expected O, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_055c: Expected O, but got I
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_099a: Expected O, but got I
		//IL_09a8: Expected I, but got O
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Expected I, but got Unknown
		//IL_09c9: Expected O, but got I
		//IL_0597: Expected O, but got I
		//IL_062f: Expected O, but got I4
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060a: Expected O, but got Unknown
		//IL_065d: Expected O, but got I
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected O, but got Unknown
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_06f3: Expected I, but got O
		//IL_0715: Expected O, but got I4
		//IL_0698: Expected O, but got I
		//IL_0733: Expected I, but got O
		//IL_0743: Expected O, but got I
		//IL_07e1: Expected O, but got I
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_0806: Expected O, but got Unknown
		//IL_080e: Expected I, but got O
		//IL_0832: Expected O, but got I4
		//IL_083b: Expected O, but got I4
		//IL_077e: Expected O, but got I
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected O, but got Unknown
		//IL_06b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b9: Expected O, but got Unknown
		//IL_0a15: Expected O, but got I4
		//IL_078c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected O, but got Unknown
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6032]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v57+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v57+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Platform platform = KUtil.GetPlatform();
		if (platform != Platform.Android)
		{
			goto IL_0115;
		}
		goto IL_01a5;
		IL_0404:
		object obj5 = typeof(System.IOAsyncCallback) + 384;
		object obj6 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3616;
		object obj8 = default(object);
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v21+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v21+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04c3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v21+B0]");
		object obj10 = (nint)0 + (nint)8;
		object obj11 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X10_v25-8]");
			if (0 == (nint)obj5)
			{
				break;
			}
			obj11 = obj10 + 16;
			obj9--;
			bool flag2 = (nint)obj9 != 1;
			obj10 = obj11;
			if (flag2)
			{
				continue;
			}
			goto IL_04c3;
		}
		object obj12 = obj7 + obj10;
		object obj13 = obj12 + 312;
		obj11 = obj10;
		goto IL_08ea;
		IL_0369:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v434 @ X0_v41 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag3 = obj8 == null;
		object obj14 = !flag3;
		object obj15 = default(object);
		obj11 = obj15;
		if (obj14 != null)
		{
			goto IL_0404;
		}
		IntPtr intPtr = default(IntPtr);
		nint num = intPtr;
		goto IL_0849;
		IL_07bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj17 = default(object);
		object obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X0_v27+8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v184 @ X2_v15 (should have been resolved before IL gen)");
		goto IL_07eb;
		IL_0074:
		Platform platform2 = KUtil.GetPlatform();
		if (platform2 != Platform.Android)
		{
			goto IL_0115;
		}
		goto IL_01a5;
		IL_0115:
		object obj19 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v51+E4]");
		if ((nint)0 != 0)
		{
			Platform platform3 = KUtil.GetPlatform();
			if (platform3 != Platform.Huawei)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Platform platform4 = KUtil.GetPlatform();
			if (platform4 != Platform.Huawei)
			{
				return;
			}
		}
		goto IL_01a5;
		IL_05e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_097a;
		IL_0849:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0857;
		IL_01a5:
		if (!ScreenUtility.IsTabletSize)
		{
			return;
		}
		object obj20 = typeof(UsageHint) + 72;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v5+E4]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (UserInfo.ChoseTabletMode)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool choseTabletMode = UserInfo.ChoseTabletMode;
			bool flag4 = !choseTabletMode;
			object obj22 = !flag4;
			if (obj22 != null)
			{
				return;
			}
		}
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
		if (popupWindowBuilderNeedsTitle == null)
		{
			goto IL_0849;
		}
		object obj23 = typeof(System.IOAsyncCallback) + 392;
		object obj24 = "Unsupported map type" + 3592;
		nint num2 = (nint)popupWindowBuilderNeedsTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v15 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v15 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0369;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v15 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		obj11 = (nint)0 + (nint)8;
		goto IL_08a2;
		IL_097a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v641 @ X0_v19] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj26 = (nint)0 + (nint)2320;
		Action action = default(Action);
		action..ctor(null, (IntPtr)obj26);
		num = (nint)("SetRoomVariables request error" + 3048);
		PopupButton popupButton = PopupButton.Neutral((string)num, action, dismiss: true);
		object obj27 = default(object);
		bool flag5 = obj27 == null;
		object obj28 = 0;
		obj15 = obj11;
		object obj29;
		object obj31;
		if (!flag5)
		{
			obj29 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v34+12E]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v34+12E]");
			if ((nint)0 == 0)
			{
				goto IL_06e1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v34+B0]");
			obj15 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X10_v1-8]");
				if (0 == (nint)obj31)
				{
					break;
				}
				obj11 = obj15 + 16;
				obj30--;
				bool flag6 = (nint)obj30 != 1;
				obj15 = obj11;
				if (flag6)
				{
					continue;
				}
				goto IL_06e1;
			}
			goto IL_07eb;
		}
		goto IL_0849;
		IL_08ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v565 @ X8_v22] (should have been resolved before IL gen)");
		object obj32 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj33 = (nint)0 + (nint)2328;
		Action action2 = default(Action);
		action2..ctor(null, (IntPtr)obj33);
		num = (nint)("SubscribeGroup request Error" + 336);
		PopupButton popupButton2 = PopupButton.Neutral((string)num, action2);
		object obj34 = default(object);
		bool flag7 = obj34 == null;
		obj28 = 0;
		obj15 = obj11;
		if (flag7)
		{
			goto IL_0849;
		}
		obj31 = typeof(System.IOAsyncCallback) + 368;
		object obj35 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v27+12E]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v27+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05e0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v27+B0]");
		object obj37 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X10_v20-8]");
			if (0 == (nint)obj31)
			{
				break;
			}
			obj11 = obj37 + 16;
			obj36--;
			bool flag8 = (nint)obj36 != 1;
			obj37 = obj11;
			if (flag8)
			{
				continue;
			}
			goto IL_05e0;
		}
		object obj38 = obj35 + obj37;
		object obj39 = obj38 + 312;
		obj11 = obj37;
		goto IL_097a;
		IL_04c3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj40 = default(object);
		obj13 = obj40;
		goto IL_08ea;
		IL_07eb:
		object obj41 = obj29 + obj15;
		object obj42 = obj41 + 312;
		num = (nint)obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v691 @ X0_v33] (should have been resolved before IL gen)");
		bool flag9 = ex == null;
		object obj43 = !flag9;
		obj28 = 0;
		if (obj43 != null)
		{
			goto IL_072b;
		}
		goto IL_0849;
		IL_06e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj44 = default(object);
		num = (nint)obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v676 @ X0_v30] (should have been resolved before IL gen)");
		bool flag10 = ex == null;
		obj28 = 0;
		obj15 = obj11;
		if (!flag10)
		{
			goto IL_072b;
		}
		goto IL_0849;
		IL_072b:
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v7 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v7 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_07bf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v7 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj15 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X10_v1-8]");
			bool flag11 = 0 == (nint)obj31;
			obj28 = 0;
			if (flag11)
			{
				break;
			}
			obj15 += 16;
			obj45--;
			if ((nint)obj45 != 1)
			{
				continue;
			}
			goto IL_07bf;
		}
		goto IL_0857;
		IL_08a2:
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X10_v12-8]");
			if (0 == (nint)obj23)
			{
				break;
			}
			obj15 = obj11 + 16;
			obj25--;
			bool flag12 = (nint)obj25 != 1;
			obj11 = obj15;
			if (flag12)
			{
				continue;
			}
			goto IL_0369;
		}
		object obj46 = num2 + obj11;
		num = (nint)(obj46 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v456 @ X8_v7 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag13 = obj8 == null;
		obj15 = obj11;
		if (!flag13)
		{
			goto IL_0404;
		}
		goto IL_0849;
		IL_0857:
		object obj47 = obj15 + 9;
		object obj48 = num + obj47;
		object obj49 = obj48 + 312;
		object obj50 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v9+8]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v185 @ X2_v2 (should have been resolved before IL gen)");
		goto IL_08a2;
	}

	private void AnimationAwake()
	{
		//IL_003c: Expected O, but got I4
		//IL_0063: Expected O, but got I4
		//IL_009f: Expected O, but got I4
		//IL_00c6: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_011f: Expected O, but got I4
		//IL_0177: Expected O, but got I4
		//IL_0177: Expected O, but got I4
		background.alpha = 0f;
		Transform transform = NextScreenButton.transform;
		transform.localScale = (Vector3)0;
		Transform transform2 = doneButton.transform;
		transform2.localScale = (Vector3)0;
		logo.SetActive(value: false);
		Transform transform3 = logo.transform;
		transform3.localPosition = (Vector3)0;
		Transform transform4 = logo.transform;
		transform4.localScale = (Vector3)0;
		phone.SetActive(value: false);
		Transform gObject = phone.transform;
		float? y = 1500f;
		UIExtensions.MoveTo(gObject, isWorldPositions: false, (float?)(object)0, y, (float?)(object)0);
		bottomPanel.SetActive(value: false);
		Transform gObject2 = bottomPanel.transform;
		y = -1000f;
		UIExtensions.MoveTo(gObject2, isWorldPositions: false, (float?)(object)0, y, (float?)(object)0);
		skipButton.SetActive(value: false);
	}

	private void AnimationStart()
	{
		//IL_0055: Expected O, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_013b: Expected O, but got I
		//IL_0192: Expected I, but got O
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(background, 1f, 0f);
		Transform target = NextScreenButton.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target, 1f, 0.2f);
		logo.SetActive(value: true);
		object obj = (nint)0 + (nint)2904;
		Transform target2 = logo.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale(target2, 1f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Transform target3 = logo.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = ShortcutExtensions.DOLocalMoveY(target3, 860f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		phone.SetActive(value: true);
		object obj2 = ((List<object>)(object)screens).get_Item(0);
		((OnBoardingScreen)obj2).PrepareToShow();
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj4 = (nint)0 + (nint)2304;
		object obj5 = (nint)0 + (nint)2504;
		Transform target4 = phone.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore5 = ShortcutExtensions.DOLocalMoveY(target4, 0f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		bottomPanel.SetActive(value: true);
		Transform target5 = bottomPanel.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore6 = ShortcutExtensions.DOLocalMoveY(target5, 0f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		skipButton.SetActive(value: true);
	}

	private void AnimationExit(Action onComplete)
	{
		//IL_0011: Expected O, but got I
		//IL_0091: Expected O, but got I
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_013b: Expected O, but got I
		//IL_0195: Expected I, but got O
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(background, 0f, 0.2f);
		object obj = (nint)0 + (nint)2776;
		Transform target = NextScreenButton.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target, 0f, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Transform target2 = doneButton.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale(target2, 0f, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj2 = (nint)0 + (nint)2904;
		Transform target3 = logo.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = ShortcutExtensions.DOLocalMoveY(target3, 2000f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Transform target4 = phone.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore5 = ShortcutExtensions.DOLocalMoveY(target4, 2000f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj4 = (nint)0 + (nint)2488;
		object obj5 = (nint)0 + (nint)2504;
		Transform target5 = bottomPanel.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore6 = ShortcutExtensions.DOLocalMoveY(target5, -2000f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(onComplete, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		skipButton.SetActive(value: false);
	}

	public TutorialOnboarding()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<int> list = default(List<int>);
		list..ctor();
		object obj2 = this + 144;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private void <CompleteOnboarding>b__20_0()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	internal static void <TabletSwitchPopup>g__SwitchToPhone|25_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0127: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0180: Expected O, but got I4
		//IL_0189: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6037]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj6;
		if (obj3 != null)
		{
			obj4 = typeof(RegisteredWaitHandle) + 3136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(RegisteredWaitHandle) + 3136;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.ForceTablet = false;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v1+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = 0;
		if (obj9 != null)
		{
			goto IL_00d9;
		}
		goto IL_0197;
		IL_00d9:
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
		return;
		IL_0197:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_00d9;
		IL_0099:
		Preferences.ForceTablet = false;
		obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		obj10 = 0;
		if (!flag4)
		{
			goto IL_00d9;
		}
		goto IL_0197;
	}

	internal static void <TabletSwitchPopup>g__StayOnTablet|25_1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00af: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6038]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.ForceTablet = true;
		return;
		IL_0074:
		Preferences.ForceTablet = true;
	}

	private void <AnimationStart>b__27_0()
	{
		object obj = ((List<object>)(object)screens).get_Item(0);
		((OnBoardingScreen)obj).Show(isNextSlide: true);
	}
}
