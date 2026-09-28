using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class SwitchGameButton : MonoBehaviour
{
	private sealed class <>c__DisplayClass12_0
	{
		public float speed;

		public SwitchGameButton <>4__this;

		public TweenCallback <>9__5;

		public TweenCallback <>9__4;

		internal void <AnimateGameIcon>b__3()
		{
			//IL_002b: Expected O, but got I
			//IL_0055: Expected O, but got I4
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00bb: Expected O, but got I
			//IL_00c9: Expected I, but got O
			<>4__this.<AnimateGameIcon>g__FlipJackarooOrBalootIcon|12_2();
			SwitchGameButton switchGameButton = <>4__this;
			object obj = (nint)0 + (nint)2472;
			Transform transform = switchGameButton.iconsParent.transform;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(transform, (Vector3)0, 0f);
			object obj2 = this + 40;
			if (obj2 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
				return;
			}
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = (nint)0 + (nint)2352;
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(this, (IntPtr)obj4);
			<>9__4 = tweenCallback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		}

		internal void <AnimateGameIcon>b__4()
		{
			//IL_0011: Expected O, but got I
			//IL_003b: Expected O, but got I4
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0071: Expected O, but got I4
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			//IL_00a9: Expected O, but got I
			//IL_00b7: Expected I, but got O
			SwitchGameButton switchGameButton = <>4__this;
			object obj = (nint)0 + (nint)2472;
			Transform transform = switchGameButton.iconsParent.transform;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(transform, (Vector3)0, 0f);
			object obj2 = this + 32;
			TweenCallback tweenCallback = (TweenCallback)obj2;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj5 = (nint)0 + (nint)2360;
				TweenCallback tweenCallback2 = default(TweenCallback);
				tweenCallback2..ctor(this, (IntPtr)obj5);
				<>9__5 = tweenCallback2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				tweenCallback = tweenCallback2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		}

		internal void <AnimateGameIcon>b__5()
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_003f: Expected O, but got I
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_007d: Expected O, but got I4
			//IL_00a3: Expected I, but got O
			//IL_00d2: Expected O, but got I4
			<>4__this.SetGameUI();
			SwitchGameButton switchGameButton = <>4__this;
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)3072;
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Transform transform = switchGameButton.iconsParent.transform;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(transform, (Vector3)0, 0f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(<>4__this, (IntPtr)obj2);
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(2f, action);
		}
	}

	private Button swithGameButton;

	private GameObject iconsParent;

	private GameObject notificationIcon;

	private Image balootIcon;

	private Image tarneebIcon;

	private Image jackarooIcon;

	private TextMeshProUGUI balootText;

	private TextMeshProUGUI tarneebText;

	private TextMeshProUGUI jackarooText;

	private PrefabInitializer gameHub;

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_00f4: Expected O, but got I4
		Button button = swithGameButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(UsageHint) + 72;
		button.m_OnClick.AddListener(unityAction);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			if (UserInfo.SawGameSwitchHubAfterNewGame)
			{
				goto IL_00bb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool sawGameSwitchHubAfterNewGame = UserInfo.SawGameSwitchHubAfterNewGame;
			bool flag = !sawGameSwitchHubAfterNewGame;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_00bb;
			}
		}
		AnimateGameIcon();
		SetGameUI();
		return;
		IL_00bb:
		SetGameUI();
	}

	private void SetGameUI()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_0271: Expected O, but got I4
		//IL_0188: Expected O, but got I4
		//IL_01de: Expected O, but got I4
		GameObject gameObject = balootIcon.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = balootText.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = tarneebIcon.gameObject;
		gameObject3.SetActive(value: false);
		GameObject gameObject4 = tarneebText.gameObject;
		gameObject4.SetActive(value: false);
		GameObject gameObject5 = jackarooIcon.gameObject;
		gameObject5.SetActive(value: false);
		GameObject gameObject6 = jackarooText.gameObject;
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		gameObject6.SetActive(value: false);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v16+E4]");
		Games currentGame;
		if ((nint)0 != 0)
		{
			currentGame = Preferences.CurrentGame;
			if (currentGame != Games.Jackaroo)
			{
				goto IL_0151;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			currentGame = Preferences.CurrentGame;
			if (currentGame != Games.Jackaroo)
			{
				goto IL_0151;
			}
		}
		GameObject gameObject7 = jackarooIcon.gameObject;
		gameObject7.SetActive(value: true);
		Component component = jackarooText;
		bool flag = (object)jackarooText == null;
		object obj3 = !flag;
		if (obj3 != null)
		{
			goto IL_02b5;
		}
		goto IL_02d7;
		IL_02d7:
		throw new NullReferenceException();
		IL_02b5:
		GameObject gameObject8 = component.gameObject;
		gameObject8.SetActive(value: true);
		return;
		IL_0151:
		if (currentGame != Games.Tarneeb)
		{
			bool flag2 = currentGame == Games.Baloot;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				return;
			}
			GameObject gameObject9 = balootIcon.gameObject;
			gameObject9.SetActive(value: true);
			component = balootText;
			bool flag3 = (object)balootText == null;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				goto IL_02d7;
			}
		}
		else
		{
			GameObject gameObject10 = tarneebIcon.gameObject;
			gameObject10.SetActive(value: true);
			component = tarneebText;
		}
		goto IL_02b5;
	}

	private void AnimateGameIcon()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3064;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.5f, action);
	}

	private void OnSwitchGameButtonClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0114: Expected O, but got I
		//IL_0136: Expected O, but got I4
		//IL_0146: Expected O, but got I
		//IL_005f: Expected O, but got I
		//IL_0086: Expected O, but got I
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01da: Expected O, but got I4
		//IL_00de: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		//IL_0233: Expected I, but got O
		//IL_02d7: Expected O, but got I4
		//IL_0278: Expected O, but got I4
		//IL_027d: Expected I, but got O
		//IL_02ea: Expected I, but got O
		object obj = typeof(UsageHint) + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6384]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj4;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v16+E4]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v16+E4]");
			obj5 = 0;
			if (!flag)
			{
				goto IL_0094;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v16+E4]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v16+E4]");
			obj5 = 0;
			if (obj6 != null)
			{
				goto IL_0094;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool sawGameSwitchHubAfterNewGame = UserInfo.SawGameSwitchHubAfterNewGame;
		bool flag3 = !sawGameSwitchHubAfterNewGame;
		object obj7 = !flag3;
		obj4 = obj5;
		if (obj7 != null)
		{
			goto IL_00ba;
		}
		goto IL_019c;
		IL_00ba:
		PrefabInitializer prefabInitializer = gameHub;
		bool flag4 = (object)gameHub == null;
		object obj8 = 152985600;
		if (!flag4)
		{
			goto IL_00ec;
		}
		goto IL_028b;
		IL_00ec:
		prefabInitializer.Initialize();
		return;
		IL_028b:
		NullReferenceException trackEvent = new NullReferenceException();
		goto IL_0299;
		IL_0094:
		if (UserInfo.SawGameSwitchHubAfterNewGame)
		{
			goto IL_00ba;
		}
		goto IL_019c;
		IL_019c:
		obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v9+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UserInfo.SawGameSwitchHubAfterNewGame = true;
		ITrackEvent trackEvent2 = TrackerLibrary.MenuSwitchGameClickedAfterNewGame();
		obj4 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v2+E4]");
		bool flag6 = (nint)0 == 0;
		nint num = unchecked((nint)null);
		trackEvent = (NullReferenceException)trackEvent2;
		if (!flag6)
		{
			Tracker.DesignEvent(trackEvent2);
			prefabInitializer = gameHub;
			bool flag7 = (object)gameHub == null;
			object obj11 = !flag7;
			num = unchecked((nint)null);
			if (obj11 != null)
			{
				goto IL_00ec;
			}
			goto IL_028b;
		}
		goto IL_0299;
		IL_0299:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent((ITrackEvent)trackEvent);
		prefabInitializer = gameHub;
		bool flag8 = (object)gameHub == null;
		object obj12 = !flag8;
		if (obj12 != null)
		{
			goto IL_00ec;
		}
		num = unchecked((nint)null);
		goto IL_028b;
	}

	private void <AnimateGameIcon>b__12_0()
	{
		//IL_0011: Expected O, but got I
		//IL_001d: Expected O, but got I
		object obj = (nint)0 + (nint)2904;
		object obj2 = (nint)0 + (nint)2776;
		Transform target = notificationIcon.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 1f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		<AnimateGameIcon>g__FlipIcon|12_1();
	}

	private void <AnimateGameIcon>g__FlipIcon|12_1()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_006d: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_00b8: Expected I, but got O
		object obj = typeof(SkeletonBinary.SkeletonInput) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 1050253722;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj5 = (nint)0 + (nint)2344;
		object obj6 = (nint)0 + (nint)2472;
		Transform target = iconsParent.transform;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(target, (Vector3)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void <AnimateGameIcon>g__FlipJackarooOrBalootIcon|12_2()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0105: Expected O, but got I4
		GameObject gameObject = balootIcon.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = tarneebIcon.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = jackarooIcon.gameObject;
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		gameObject3.SetActive(value: false);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			Games currentGame = Preferences.CurrentGame;
			if (currentGame == Games.Jackaroo)
			{
				goto IL_00df;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Games currentGame2 = Preferences.CurrentGame;
			if (currentGame2 == Games.Jackaroo)
			{
				goto IL_00df;
			}
		}
		Component component = jackarooIcon;
		goto IL_015c;
		IL_015c:
		GameObject gameObject4 = component.gameObject;
		gameObject4.SetActive(value: true);
		return;
		IL_00df:
		component = balootIcon;
		bool flag = (object)balootIcon == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_015c;
	}
}
