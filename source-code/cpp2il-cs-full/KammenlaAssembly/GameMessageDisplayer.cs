using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;

public class GameMessageDisplayer : MonoBehaviour
{
	private sealed class <>c__DisplayClass6_0
	{
		public GameMessageDisplayer <>4__this;

		public string message;

		internal void <DisplayMessage>b__0()
		{
			<>4__this.ShowMessage(message);
		}
	}

	private TextMeshProUGUI messageText;

	private RectTransform content;

	private GameEventsChannel gameEventsChannel;

	private bool messageShown;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0062: Expected I, but got O
		//IL_0049: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		gameEventsChannel.DisplayMessage += action;
		content.anchoredPosition = (Vector2)0;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj2 = (nint)0 + (nint)496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		gameEventsChannel.DisplayMessage -= action;
	}

	private void DisplayMessage(string message)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I
		//IL_00cc: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 4000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = message;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num = ShortcutExtensions.DOKill(content);
		if (messageShown)
		{
			object obj5 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)1512;
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj6);
			HideMessage(action);
		}
		else
		{
			ShowMessage((string)obj4);
		}
	}

	private void ShowMessage(string message, float duration = 4f)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_020b: Expected O, but got I4
		//IL_0214: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_0087: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00ea: Expected O, but got I
		//IL_0121: Expected O, but got I4
		//IL_0142: Unsupported input type for neg.
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected F4, but got Unknown
		//IL_0269: Expected O, but got I4
		//IL_01aa: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66CC]");
		object obj3 = (nint)0 & (nint)1;
		string text = default(string);
		object obj6;
		object obj5;
		if (obj3 != null)
		{
			TextMeshProExtensions.Localize(messageText, text);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = 0;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			TextMeshProExtensions.Localize(messageText, text);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = 0;
			obj6 = 0;
			if (obj7 != null)
			{
				goto IL_009e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Sequence s = DOTween.Sequence();
		RectTransform rectTransform = content;
		bool flag3 = (object)content == null;
		object obj8 = !flag3;
		obj5 = obj6;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00b6;
		IL_009e:
		s = DOTween.Sequence();
		rectTransform = content;
		goto IL_00b6;
		IL_00b6:
		object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj11 = (nint)0 + (nint)504;
		Rect rect = rectTransform.rect;
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v24+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = default(object);
		float endValue = 0 - obj14;
		TweenerCore<Vector3, Vector3, VectorOptions> t = ShortcutExtensions.DOLocalMoveY(rectTransform, endValue, 0.5f);
		Sequence sequence = TweenSettingsExtensions.Append(s, t);
		Sequence sequence2 = TweenSettingsExtensions.AppendInterval(s, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj11);
		Sequence sequence3 = TweenSettingsExtensions.AppendCallback(s, tweenCallback);
		messageShown = true;
	}

	private void HideMessage()
	{
		HideMessage(null);
	}

	private void HideMessage(Action callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0084: Expected I, but got O
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj2 = (nint)0 + (nint)2488;
		object obj3 = (nint)0 + (nint)2504;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(content, 0f, 0.5f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(callback, (IntPtr)obj2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		messageShown = false;
	}
}
