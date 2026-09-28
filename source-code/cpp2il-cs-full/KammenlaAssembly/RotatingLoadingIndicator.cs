using System;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UI.Loading;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class RotatingLoadingIndicator : MonoBehaviour, ILoadingIndicator
{
	private Tweener loopTween;

	public float scaleDuration = 0.5f;

	public bool autoStart;

	private Vector3? originalScale;

	private void Start()
	{
		if (autoStart)
		{
			StartLoading();
		}
	}

	private void Init()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_007f: Expected O, but got I4
		//IL_002d: Expected O, but got I
		object obj = this + 48;
		object obj2 = obj & 1;
		bool flag = obj2 == null;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Transform transform = base.transform;
			Vector3 localScale = transform.localScale;
			object value = (nint)0 + (nint)768;
			Vector3? vector = (Vector3)value;
			obj = vector;
		}
		Transform target = base.transform;
		int num = ShortcutExtensions.DOKill(target);
	}

	public unsafe void StartLoading()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_003f: Expected O, but got I4
		//IL_005b: Expected O, but got I
		//IL_0067: Expected O, but got I
		//IL_0073: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00c6: Expected F4, but got O
		//IL_00c6: Expected O, but got I4
		//IL_010a: Expected O, but got I4
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		Init();
		Transform transform = base.transform;
		object obj = typeof(UsageHint) + 816;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v8+B8]");
		object obj3 = 0;
		transform.localScale = (Vector3)0;
		GameObject gameObject = base.gameObject;
		object obj4 = (nint)0 + (nint)2904;
		object obj5 = (nint)0 + (nint)2776;
		object obj6 = (nint)0 + (nint)3032;
		object obj7 = (nint)0 + (nint)2848;
		gameObject.SetActive(value: true);
		Transform target = base.transform;
		Vector3? vector = (Vector3?)(object)(this + 48);
		Vector3 value = ((Vector3?*)vector)->Value;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, (Vector3)0, (float)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Transform target2 = base.transform;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = ShortcutExtensions.DOLocalRotate(target2, (Vector3)3, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30593E4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj8 = this + 32;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void FinishLoading()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002c: Expected O, but got I
		//IL_0038: Expected O, but got I
		//IL_0064: Expected I, but got O
		object obj = (nint)0 + (nint)2904;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj3 = (nint)0 + (nint)3120;
		object obj4 = (nint)0 + (nint)2504;
		Init();
		Transform target = base.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 0f, scaleDuration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void <FinishLoading>b__7_0()
	{
		TweenExtensions.Kill(loopTween);
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}
}
