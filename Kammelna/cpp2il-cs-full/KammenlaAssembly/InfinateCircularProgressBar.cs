using System;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class InfinateCircularProgressBar : MonoBehaviour
{
	private Image progressBar;

	private float duration = 3f;

	private Ease ease;

	private void Start()
	{
		//IL_0026: Expected O, but got I
		//IL_0032: Expected O, but got I
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0052: Expected O, but got I
		//IL_00b6: Expected I, but got O
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		progressBar.fillAmount = 0f;
		object obj = (nint)0 + (nint)2864;
		object obj2 = (nint)0 + (nint)3040;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj4 = (nint)0 + (nint)2488;
		progressBar.fillClockwise = true;
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFillAmount(progressBar, 1f, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30593E4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj4);
		object obj6 = default(object);
		object obj5 = obj6 + 120;
		obj5 = tweenCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <Start>b__3_0()
	{
		//IL_001d: Expected O, but got I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected I4, but got Unknown
		Image image = progressBar;
		object obj = ~(image.m_FillClockwise ? 1 : 0);
		bool fillClockwise = (byte)(1 & obj) != 0;
		image.fillClockwise = fillClockwise;
	}
}
