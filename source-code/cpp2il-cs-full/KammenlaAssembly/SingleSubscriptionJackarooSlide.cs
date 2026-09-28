using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

public class SingleSubscriptionJackarooSlide : CommonJackarooSlide
{
	private RectTransform carpet;

	private RectTransform carpetBorder;

	private RectTransform board;

	private RectTransform cardsHolder;

	private RectTransform spadeCard;

	private RectTransform heartCard;

	private RectTransform greenMarble;

	private RectTransform blackMarble;

	private Sequence mainSequence;

	public override Sequence OnShow()
	{
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_0016: Expected O, but got I
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00dc: Expected O, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0306: Expected O, but got I
		//IL_0337: Expected O, but got I4
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_037d: Expected O, but got I
		//IL_0391: Expected F4, but got O
		//IL_0391: Expected O, but got I4
		//IL_03b7: Expected O, but got I
		//IL_03cf: Expected O, but got I
		//IL_03e3: Expected F4, but got O
		//IL_03e3: Expected O, but got I4
		//IL_0409: Expected O, but got I
		//IL_0415: Expected O, but got I
		//IL_042d: Expected O, but got I
		//IL_045e: Expected O, but got I4
		//IL_049a: Expected O, but got I
		//IL_04cb: Expected O, but got I4
		//IL_01ba: Expected O, but got I4
		//IL_0235: Expected O, but got I4
		object t = this + 144;
		TweenExtensions.Kill((Tween)t);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v3-30]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v3-30]");
			GameObject gameObject = ((Component)0).gameObject;
			if ((object)gameObject != null)
			{
				gameObject.SetActive(value: true);
				if ((object)cardsHolder != null)
				{
					GameObject gameObject2 = cardsHolder.gameObject;
					if ((object)gameObject2 != null)
					{
						object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
						gameObject2.SetActive(value: true);
						object obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v9+E4]");
						bool flag = (nint)0 == 0;
						object obj3 = !flag;
						if (obj3 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Sequence sequence = DOTween.Sequence();
						mainSequence = sequence;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOScale(carpetBorder, 1f, 0.3f);
						Sequence s = TweenSettingsExtensions.Append(mainSequence, t2);
						TweenerCore<Vector3, Vector3, VectorOptions> t3 = ShortcutExtensions.DOScale(carpet, 1f, 0.3f);
						Sequence s2 = TweenSettingsExtensions.Append(s, t3);
						object obj4 = typeof(UsageHint) + 816;
						object obj5 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v8+B8]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v9+48]");
						float duration = 0f * 0f;
						TweenerCore<Quaternion, Vector3, QuaternionOptions> t4 = ShortcutExtensions.DOLocalRotate(carpetBorder, (Vector3)0, duration);
						Sequence s3 = TweenSettingsExtensions.Append(s2, t4);
						object obj7 = typeof(UsageHint) + 744;
						object obj8 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v14+B8]");
						object obj9 = 0;
						TweenerCore<Vector2, Vector2, VectorOptions> t5 = DOTweenModuleUI.DOPivot(cardsHolder, (Vector2)0, (float)obj9);
						Sequence s4 = TweenSettingsExtensions.Join(s3, t5);
						object obj10 = (nint)0 + (nint)2848;
						object obj11 = obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v20+B8]");
						object obj12 = 0;
						TweenerCore<Vector2, Vector2, VectorOptions> t6 = DOTweenModuleUI.DOPivot(board, (Vector2)0, (float)obj12);
						Sequence s5 = TweenSettingsExtensions.Join(s4, t6);
						object obj13 = (nint)0 + (nint)2872;
						object obj14 = (nint)0 + (nint)2904;
						object obj15 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v26+B8]");
						object obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v27+48]");
						float duration2 = 0f * 0f;
						TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(heartCard, (Vector3)0, duration2);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
						Tween t7 = default(Tween);
						Sequence s6 = TweenSettingsExtensions.Append(s5, t7);
						object obj17 = obj4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X8_v32+B8]");
						object obj18 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v33+48]");
						float duration3 = 0f * 193f;
						TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = ShortcutExtensions.DOLocalRotate(spadeCard, (Vector3)0, duration3);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
						Tween t8 = default(Tween);
						Sequence s7 = TweenSettingsExtensions.Join(s6, t8);
						TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = DOTweenModuleUI.DOPivot(blackMarble, (Vector2)0, -0.25f);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
						Tween t9 = default(Tween);
						Sequence s8 = TweenSettingsExtensions.Join(s7, t9);
						TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = ShortcutExtensions.DOScale(blackMarble, 5f, 0.35f);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
						Tween t10 = default(Tween);
						Sequence s9 = TweenSettingsExtensions.Join(s8, t10);
						TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore5 = DOTweenModuleUI.DOPivot(greenMarble, (Vector2)0, 0.7f);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
						Tween t11 = default(Tween);
						Sequence s10 = TweenSettingsExtensions.Join(s9, t11);
						TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore6 = ShortcutExtensions.DOScale(greenMarble, 5f, 0.35f);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
						Tween t12 = default(Tween);
						Sequence sequence2 = TweenSettingsExtensions.Join(s10, t12);
						return mainSequence;
					}
				}
			}
		}
		return (Sequence)(object)new NullReferenceException();
	}

	public override void Hide()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_0235: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_025b: Expected O, but got I
		//IL_0274: Expected F4, but got O
		//IL_0274: Expected O, but got I4
		//IL_02a6: Expected O, but got I
		//IL_02b2: Expected O, but got I
		//IL_02ca: Expected O, but got I
		//IL_02e3: Expected F4, but got O
		//IL_02e3: Expected O, but got I4
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_031f: Expected O, but got I
		//IL_0333: Expected F4, but got O
		//IL_0333: Expected O, but got I4
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_0377: Expected O, but got I
		//IL_038f: Expected O, but got I
		//IL_03a3: Expected F4, but got O
		//IL_03a3: Expected O, but got I4
		//IL_03df: Expected O, but got I
		//IL_03f8: Expected F4, but got O
		//IL_03f8: Expected O, but got I4
		//IL_0426: Expected O, but got I4
		//IL_013b: Expected O, but got I4
		//IL_01d0: Expected I, but got O
		//IL_01dc: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object t = this + 144;
		TweenExtensions.Kill((Tween)t);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = (nint)0 + (nint)2848;
		Sequence sequence = DOTween.Sequence();
		mainSequence = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = typeof(UsageHint) + 816;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v6+B8]");
		object obj7 = 0;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(heartCard, (Vector3)0, (float)obj7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t2 = default(Tween);
		Sequence s = TweenSettingsExtensions.Append(mainSequence, t2);
		object obj8 = (nint)0 + (nint)2872;
		object obj9 = (nint)0 + (nint)2904;
		object obj10 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v12+B8]");
		object obj11 = 0;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = ShortcutExtensions.DOLocalRotate(spadeCard, (Vector3)0, (float)obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t3 = default(Tween);
		Sequence s2 = TweenSettingsExtensions.Join(s, t3);
		object obj12 = typeof(UsageHint) + 744;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v18+B8]");
		object obj14 = 0;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = DOTweenModuleUI.DOPivot(blackMarble, (Vector2)0, (float)obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t4 = default(Tween);
		Sequence s3 = TweenSettingsExtensions.Join(s2, t4);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = ShortcutExtensions.DOScale(blackMarble, 1f, 0.13f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t5 = default(Tween);
		Sequence s4 = TweenSettingsExtensions.Join(s3, t5);
		object obj15 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj16 = (nint)0 + (nint)448;
		object obj17 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v24+B8]");
		object obj18 = 0;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore5 = DOTweenModuleUI.DOPivot(greenMarble, (Vector2)0, (float)obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t6 = default(Tween);
		Sequence s5 = TweenSettingsExtensions.Join(s4, t6);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore6 = ShortcutExtensions.DOScale(greenMarble, 1f, 0.13f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t7 = default(Tween);
		Sequence s6 = TweenSettingsExtensions.Join(s5, t7);
		object obj19 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v30+B8]");
		object obj20 = 0;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t8 = ShortcutExtensions.DOLocalRotate(carpetBorder, (Vector3)0, (float)obj20);
		Sequence s7 = TweenSettingsExtensions.Append(s6, t8);
		TweenerCore<Vector2, Vector2, VectorOptions> t9 = DOTweenModuleUI.DOPivot(cardsHolder, (Vector2)0, -6f);
		Sequence s8 = TweenSettingsExtensions.Join(s7, t9);
		TweenerCore<Vector2, Vector2, VectorOptions> t10 = DOTweenModuleUI.DOPivot(board, (Vector2)0, 3.5f);
		Sequence s9 = TweenSettingsExtensions.Join(s8, t10);
		TweenerCore<Vector3, Vector3, VectorOptions> t11 = ShortcutExtensions.DOScale(carpetBorder, 0f, 0.13f);
		Sequence s10 = TweenSettingsExtensions.Append(s9, t11);
		TweenerCore<Vector3, Vector3, VectorOptions> t12 = ShortcutExtensions.DOScale(carpet, 0f, 0.13f);
		Sequence sequence2 = TweenSettingsExtensions.Append(s10, t12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj16);
		object obj21 = (nint)0 + (nint)2512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		base.Hide();
	}

	public override void SetHidden()
	{
		//IL_001b: Expected O, but got I4
		//IL_0030: Expected O, but got I4
		//IL_0045: Expected O, but got I4
		//IL_005a: Expected O, but got I4
		base.SetHidden();
		carpet.localScale = (Vector3)0;
		carpetBorder.localScale = (Vector3)0;
		cardsHolder.pivot = (Vector2)0;
		board.pivot = (Vector2)0;
	}

	private void <Hide>b__10_0()
	{
		GameObject gameObject = board.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = cardsHolder.gameObject;
		gameObject2.SetActive(value: false);
	}
}
