using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mono.Btls;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class OnBoardingBackgroundsAnimation : MonoBehaviour
{
	private sealed class <>c__DisplayClass6_0
	{
		public RectTransform background;

		internal void <Exit>b__1()
		{
			GameObject gameObject = background.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private RectTransform[] phoneBackgrounds;

	private RectTransform[] tabletBackgrounds;

	private bool isFullScreen;

	private Canvas rootCanvas;

	public void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
		object obj2 = this + 56;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Play()
	{
		<Play>g__Animate|5_0(phoneBackgrounds);
		if (!ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)tabletBackgrounds))
		{
			<Play>g__Animate|5_0(tabletBackgrounds);
		}
	}

	public void Exit()
	{
		<Exit>g__Animate|6_0(phoneBackgrounds);
		if (!ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)tabletBackgrounds))
		{
			<Exit>g__Animate|6_0(tabletBackgrounds);
		}
	}

	private void <Play>g__Animate|5_0(RectTransform[] backgrounds)
	{
		//IL_0031: Expected O, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_004b: Expected O, but got I
		//IL_0054: Expected O, but got I4
		//IL_0078: Expected O, but got I
		//IL_00a0: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_00d5: Expected O, but got I
		//IL_00eb: Expected O, but got I
		//IL_0122: Expected O, but got I
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		if (backgrounds.Length < 1)
		{
			return;
		}
		object obj = (nint)0 + (nint)2904;
		object obj2 = backgrounds + 32;
		object obj3 = (nint)0 + (nint)2776;
		object obj4 = 0;
		float value = default(float);
		do
		{
			Component go;
			if (isFullScreen)
			{
				go = rootCanvas;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X25_v4+v114 @ X22_v5*8]");
				go = (Component)0;
			}
			RectTransform rectTransform = UIExtensions.rectTransform(go);
			Vector2 sizeDelta = rectTransform.sizeDelta;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X25_v4+v114 @ X22_v5*8]");
			int num = ShortcutExtensions.DOKill((Component)0);
			float? x = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X25_v4+v114 @ X22_v5*8]");
			UIExtensions.MoveTo((RectTransform)0, isWorldPositions: false, x, (float?)(object)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X25_v4+v114 @ X22_v5*8]");
			GameObject gameObject = ((Component)0).gameObject;
			gameObject.SetActive(value: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X25_v4+v114 @ X22_v5*8]");
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveX((Transform)0, 0f, 0.8f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj5 = obj4 * 1072064102;
			value = (float)obj5 + 1.06199776E+09f;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
			obj4++;
		}
		while ((nint)obj4 < backgrounds.Length);
	}

	private void <Exit>g__Animate|6_0(RectTransform[] backgrounds)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0044: Expected O, but got I
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005e: Expected O, but got I
		//IL_006f: Expected O, but got I4
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_0252: Expected O, but got I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00af: Expected O, but got I
		//IL_0120: Expected O, but got I
		//IL_014c: Expected O, but got I
		//IL_0170: Expected I, but got O
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		if (backgrounds == null)
		{
			goto IL_01b4;
		}
		if (backgrounds.Length < 1)
		{
			return;
		}
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj2 = (nint)0 + (nint)16;
		object obj3 = backgrounds + 32;
		object obj4 = (nint)0 + (nint)2504;
		RectTransform[] array = backgrounds;
		object obj5 = 0;
		object obj7 = default(object);
		float num = default(float);
		TweenCallback tweenCallback = default(TweenCallback);
		while (true)
		{
			object obj6 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1584;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj7..ctor();
			bool flag = (nint)obj5 < backgrounds.Length;
			object obj8 = !flag;
			if (obj8 != null)
			{
				break;
			}
			if (obj7 != null)
			{
				object obj9 = obj7 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X28_v5+v103 @ X24_v6*8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Component go = (Component)((!isFullScreen) ? obj9 : rootCanvas);
				RectTransform rectTransform = UIExtensions.rectTransform(go);
				if ((object)rectTransform != null)
				{
					Vector2 sizeDelta = rectTransform.sizeDelta;
					num = 0f - num;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v9 (System.Object)+10]");
					int num2 = ShortcutExtensions.DOKill((Component)0);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v9 (System.Object)+10]");
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveX((Transform)0, num, 0.5f);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					tweenCallback..ctor(obj7, (IntPtr)obj2);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
					obj5++;
					bool flag2 = (nint)obj5 < backgrounds.Length;
					array = (RectTransform[])(object)tweenCallback;
					if (!flag2)
					{
						return;
					}
					continue;
				}
			}
			goto IL_01b4;
		}
		goto IL_01c2;
		IL_01c2:
		throw new IndexOutOfRangeException();
		IL_01b4:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01c2;
	}
}
