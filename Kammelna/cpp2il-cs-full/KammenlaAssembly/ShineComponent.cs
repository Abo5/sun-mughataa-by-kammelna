using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class ShineComponent : MonoBehaviour
{
	private RectTransform shineTransform;

	private ShineComponentData _data;

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1128;
		object obj2 = this + 40;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
	}

	private void OnEnable()
	{
		AnimateShine();
	}

	private void AnimateShine()
	{
		//IL_0037: Expected O, but got I
		//IL_0043: Expected O, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_006f: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		ResetState();
		ShineComponentData data = _data;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(shineTransform, 1f, data.<ScaleDuration>k__BackingField);
		object obj = (nint)0 + (nint)2848;
		object obj2 = (nint)0 + (nint)3000;
		object obj3 = typeof(UsageHint) + 816;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v3+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X9_v4+48]");
		float duration = 0f * data.<ScaleDuration>k__BackingField;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = ShortcutExtensions.DOLocalRotate(shineTransform, (Vector3)1, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059384");
	}

	private void OnDisable()
	{
		int num = ShortcutExtensions.DOKill(shineTransform, complete: true);
	}

	private void ResetState()
	{
		//IL_0015: Expected O, but got I4
		//IL_002a: Expected O, but got I4
		shineTransform.localScale = (Vector3)0;
		shineTransform.localEulerAngles = (Vector3)0;
	}
}
