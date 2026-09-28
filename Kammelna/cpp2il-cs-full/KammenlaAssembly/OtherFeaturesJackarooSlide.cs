using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class OtherFeaturesJackarooSlide : CommonJackarooSlide
{
	private RectTransform featuresColored;

	private Image featuresBorder;

	private RectTransform subscription;

	private Sequence sequence;

	public override Sequence OnShow()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I4
		//IL_0075: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object t = this + 104;
		TweenExtensions.Kill((Tween)t);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		this.sequence = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if ((object)featuresBorder != null)
		{
			object obj4 = (nint)0 + (nint)2816;
			Transform target = featuresBorder.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOScale(target, 1f, 0.4f);
			Sequence s = TweenSettingsExtensions.Append(this.sequence, t2);
			TweenerCore<Vector3, Vector3, VectorOptions> t3 = ShortcutExtensions.DOScale(subscription, 1f, 0.4f);
			Sequence s2 = TweenSettingsExtensions.Append(s, t3);
			TweenerCore<Vector3, Vector3, VectorOptions> t4 = ShortcutExtensions.DOScale(featuresColored, 1f, 0.4f);
			Sequence s3 = TweenSettingsExtensions.Append(s2, t4);
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(featuresBorder, 0f, 0.55f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween t5 = default(Tween);
			Sequence sequence2 = TweenSettingsExtensions.Join(s3, t5);
			return this.sequence;
		}
		return (Sequence)(object)new NullReferenceException();
	}

	public override void Hide()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0101: Expected O, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_014a: Expected O, but got I4
		//IL_00ca: Expected I, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj3 = (nint)0 + (nint)2424;
		base.Hide();
		object t = this + 104;
		TweenExtensions.Kill((Tween)t);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		this.sequence = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOScale(featuresColored, 0f, 0.25f);
		Sequence s = TweenSettingsExtensions.Append(this.sequence, t2);
		TweenerCore<Vector3, Vector3, VectorOptions> t3 = ShortcutExtensions.DOScale(subscription, 0f, 0.25f);
		Sequence s2 = TweenSettingsExtensions.Append(s, t3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj3);
		Sequence sequence2 = TweenSettingsExtensions.AppendCallback(s2, tweenCallback);
	}

	public override void SetHidden()
	{
		//IL_001b: Expected O, but got I4
		//IL_0042: Expected O, but got I4
		//IL_0057: Expected O, but got I4
		base.SetHidden();
		subscription.localScale = (Vector3)0;
		Transform transform = featuresBorder.transform;
		transform.localScale = (Vector3)0;
		featuresColored.localScale = (Vector3)0;
		UIExtensions.SetAlpha(featuresBorder, 1f);
	}

	private void <Hide>b__5_0()
	{
		//IL_0022: Expected O, but got I4
		//IL_0049: Expected O, but got I4
		Transform transform = featuresBorder.transform;
		transform.rotation = (Quaternion)0;
		Transform transform2 = featuresBorder.transform;
		transform2.localScale = (Vector3)0;
		UIExtensions.SetAlpha(featuresBorder, 1f);
	}
}
