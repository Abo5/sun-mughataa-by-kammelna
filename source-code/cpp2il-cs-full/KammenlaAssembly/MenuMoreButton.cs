using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UI.Popups;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class MenuMoreButton : MonoBehaviour
{
	private RectTransform parent;

	private CanvasGroup blocker;

	private RectTransform content;

	private CanvasGroup activeButton;

	private bool _isShown;

	private Transform _originalParent;

	private void Awake()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		Transform transform = parent.parent;
		object obj = this + 72;
		obj = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void ToggleMenu()
	{
		if (_isShown)
		{
			Hide();
		}
		else
		{
			Show();
		}
	}

	private void Show()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_0159: Expected O, but got I
		//IL_0165: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_004f: Expected I, but got O
		//IL_007d: Expected I, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj3 = (nint)0 + (nint)1200;
		object obj4 = (nint)0 + (nint)1208;
		int num = ShortcutExtensions.DOKill(this, complete: true);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence(this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj3);
		Sequence s2 = TweenSettingsExtensions.AppendCallback(s, tweenCallback);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(this, (IntPtr)obj4);
		Sequence s3 = TweenSettingsExtensions.AppendCallback(s2, tweenCallback2);
		TweenerCore<float, float, FloatOptions> t = DOTweenModuleUI.DOFade(blocker, 1f, 0.3f);
		Sequence s4 = TweenSettingsExtensions.Append(s3, t);
		TweenerCore<float, float, FloatOptions> t2 = DOTweenModuleUI.DOFade(activeButton, 1f, 0.3f);
		Sequence s5 = TweenSettingsExtensions.Join(s4, t2);
		TweenerCore<Vector2, Vector2, VectorOptions> t3 = DOTweenModuleUI.DOAnchorPosY(content, 0f, 0.3f);
		Sequence sequence = TweenSettingsExtensions.Join(s5, t3);
		_isShown = true;
	}

	public void Hide()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_01f9: Expected O, but got I
		//IL_0205: Expected O, but got I
		//IL_023e: Expected O, but got I4
		//IL_004f: Expected I, but got O
		//IL_007d: Expected I, but got O
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0116: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_01b7: Expected I, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj3 = (nint)0 + (nint)1152;
		object obj4 = (nint)0 + (nint)1160;
		int num = ShortcutExtensions.DOKill(this, complete: true);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence(this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj3);
		Sequence s2 = TweenSettingsExtensions.AppendCallback(s, tweenCallback);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(this, (IntPtr)obj4);
		Sequence s3 = TweenSettingsExtensions.AppendCallback(s2, tweenCallback2);
		TweenerCore<float, float, FloatOptions> t = DOTweenModuleUI.DOFade(blocker, 0f, 0.3f);
		Sequence s4 = TweenSettingsExtensions.Append(s3, t);
		TweenerCore<float, float, FloatOptions> t2 = DOTweenModuleUI.DOFade(activeButton, 0f, 0.3f);
		Sequence s5 = TweenSettingsExtensions.Join(s4, t2);
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj8 = (nint)0 + (nint)1168;
		Rect rect = content.rect;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v27+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float endValue = default(float);
		TweenerCore<Vector2, Vector2, VectorOptions> t3 = DOTweenModuleUI.DOAnchorPosY(content, endValue, 0.3f);
		Sequence s6 = TweenSettingsExtensions.Join(s5, t3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback3 = default(TweenCallback);
		tweenCallback3..ctor(this, (IntPtr)obj8);
		Sequence sequence = TweenSettingsExtensions.AppendCallback(s6, tweenCallback3);
		_isShown = false;
	}

	public void HideImmediate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_01f9: Expected O, but got I
		//IL_0205: Expected O, but got I
		//IL_023e: Expected O, but got I4
		//IL_004f: Expected I, but got O
		//IL_007d: Expected I, but got O
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0116: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_01b7: Expected I, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj3 = (nint)0 + (nint)1176;
		object obj4 = (nint)0 + (nint)1184;
		int num = ShortcutExtensions.DOKill(this, complete: true);
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence(this);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj3);
		Sequence s2 = TweenSettingsExtensions.AppendCallback(s, tweenCallback);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(this, (IntPtr)obj4);
		Sequence s3 = TweenSettingsExtensions.AppendCallback(s2, tweenCallback2);
		TweenerCore<float, float, FloatOptions> t = DOTweenModuleUI.DOFade(blocker, 0f, 0.2f);
		Sequence s4 = TweenSettingsExtensions.Append(s3, t);
		TweenerCore<float, float, FloatOptions> t2 = DOTweenModuleUI.DOFade(activeButton, 0f, 0.2f);
		Sequence s5 = TweenSettingsExtensions.Join(s4, t2);
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj8 = (nint)0 + (nint)1192;
		Rect rect = content.rect;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v27+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float endValue = default(float);
		TweenerCore<Vector2, Vector2, VectorOptions> t3 = DOTweenModuleUI.DOAnchorPosY(content, endValue, 0.2f);
		Sequence s6 = TweenSettingsExtensions.Join(s5, t3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback3 = default(TweenCallback);
		tweenCallback3..ctor(this, (IntPtr)obj8);
		Sequence sequence = TweenSettingsExtensions.AppendCallback(s6, tweenCallback3);
		_isShown = false;
	}

	private void <Show>b__8_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00cc: Expected O, but got I
		//IL_00f6: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_013f: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62F7]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)1944;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
			object obj4 = (nint)0 + (nint)1944;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		BlurLayersManager blurLayersManager = default(BlurLayersManager);
		bool flag3 = (object)blurLayersManager == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		blurLayersManager.AddBlurLayer(parent, 0.4f, worldPositionStays: true);
	}

	private void <Show>b__8_1()
	{
		GameObject gameObject = blocker.gameObject;
		gameObject.SetActive(value: true);
	}

	private void <Hide>b__9_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_013a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62F8]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)1944;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
			object obj4 = (nint)0 + (nint)1944;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		BlurLayersManager blurLayersManager = default(BlurLayersManager);
		bool flag3 = (object)blurLayersManager == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		blurLayersManager.RemoveBlurLayer(parent);
	}

	private void <Hide>b__9_1()
	{
		GameObject gameObject = blocker.gameObject;
		gameObject.SetActive(value: false);
	}

	private void <Hide>b__9_2()
	{
		parent.SetParent(_originalParent, worldPositionStays: true);
	}

	private void <HideImmediate>b__10_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_013a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E62F9]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)1944;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
			object obj4 = (nint)0 + (nint)1944;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		BlurLayersManager blurLayersManager = default(BlurLayersManager);
		bool flag3 = (object)blurLayersManager == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		blurLayersManager.RemoveBlurLayer(parent, 0.2f);
	}

	private void <HideImmediate>b__10_1()
	{
		parent.SetParent(_originalParent, worldPositionStays: true);
	}

	private void <HideImmediate>b__10_2()
	{
		GameObject gameObject = blocker.gameObject;
		gameObject.SetActive(value: false);
	}
}
