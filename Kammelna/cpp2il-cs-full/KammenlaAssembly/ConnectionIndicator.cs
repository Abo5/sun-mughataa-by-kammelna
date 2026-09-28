using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.UI;

public class ConnectionIndicator : MonoBehaviour
{
	private RectTransform animationParent;

	private Image bar1;

	private Image bar2;

	private Image bar3;

	private Image noConnection;

	private Sequence _sequence;

	private void Awake()
	{
		GameObject gameObject = noConnection.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = bar1.gameObject;
		gameObject2.SetActive(value: true);
		GameObject gameObject3 = bar2.gameObject;
		gameObject3.SetActive(value: true);
		GameObject gameObject4 = bar3.gameObject;
		gameObject4.SetActive(value: true);
	}

	public void StartLoading()
	{
		Tween sequence = _sequence;
		if (_sequence != null)
		{
			if (TweenExtensions.IsActive(_sequence))
			{
				return;
			}
			sequence = _sequence;
		}
		TweenExtensions.Kill(sequence);
		int num = ShortcutExtensions.DOKill(bar1);
		int num2 = ShortcutExtensions.DOKill(bar2);
		int num3 = ShortcutExtensions.DOKill(bar3);
		int num4 = ShortcutExtensions.DOKill(noConnection);
		UIExtensions.SetAlpha(noConnection, 0f);
		UIExtensions.SetAlpha(bar1, 0f);
		UIExtensions.SetAlpha(bar2, 0f);
		UIExtensions.SetAlpha(bar3, 0f);
		AnimateBars();
	}

	private void AnimateBars()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01fa: Expected O, but got I
		//IL_0224: Expected O, but got I4
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = (nint)0 + (nint)3008;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		TweenerCore<Color, Color, ColorOptions> t = DOTweenModuleUI.DOFade(bar1, 1f, 0.5f);
		Sequence s2 = TweenSettingsExtensions.Append(s, t);
		Sequence s3 = TweenSettingsExtensions.AppendInterval(s2, 0.2f);
		TweenerCore<Color, Color, ColorOptions> t2 = DOTweenModuleUI.DOFade(bar2, 1f, 0.5f);
		Sequence s4 = TweenSettingsExtensions.Append(s3, t2);
		Sequence s5 = TweenSettingsExtensions.AppendInterval(s4, 0.2f);
		TweenerCore<Color, Color, ColorOptions> t3 = DOTweenModuleUI.DOFade(bar3, 1f, 0.5f);
		Sequence s6 = TweenSettingsExtensions.Append(s5, t3);
		Sequence s7 = TweenSettingsExtensions.AppendInterval(s6, 0.2f);
		TweenerCore<Color, Color, ColorOptions> t4 = DOTweenModuleUI.DOFade(bar1, 0f, 0.5f);
		Sequence s8 = TweenSettingsExtensions.Append(s7, t4);
		TweenerCore<Color, Color, ColorOptions> t5 = DOTweenModuleUI.DOFade(bar2, 0f, 0.5f);
		Sequence s9 = TweenSettingsExtensions.Join(s8, t5);
		TweenerCore<Color, Color, ColorOptions> t6 = DOTweenModuleUI.DOFade(bar3, 0f, 0.5f);
		Sequence s10 = TweenSettingsExtensions.Join(s9, t6);
		Sequence sequence = TweenSettingsExtensions.AppendInterval(s10, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059384");
		object obj5 = this + 72;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void KillActiveAnimation()
	{
		TweenExtensions.Kill(_sequence);
		int num = ShortcutExtensions.DOKill(bar1);
		int num2 = ShortcutExtensions.DOKill(bar2);
		int num3 = ShortcutExtensions.DOKill(bar3);
		int num4 = ShortcutExtensions.DOKill(noConnection);
	}

	public void ConnectionSuccess()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 3912;
		TweenExtensions.Kill(_sequence);
		int num = ShortcutExtensions.DOKill(bar1);
		int num2 = ShortcutExtensions.DOKill(bar2);
		int num3 = ShortcutExtensions.DOKill(bar3);
		int num4 = ShortcutExtensions.DOKill(noConnection);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(bar1, 1f, 0.5f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOFade(bar2, 1f, 0.5f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore3 = DOTweenModuleUI.DOFade(bar3, 1f, 0.5f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore4 = DOTweenModuleUI.DOFade(noConnection, 0f, 0.5f);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v19+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AnimationExtensions.AnimEmphasise2(animationParent);
	}

	public void ConnectionFail()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 3912;
		TweenExtensions.Kill(_sequence);
		int num = ShortcutExtensions.DOKill(bar1);
		int num2 = ShortcutExtensions.DOKill(bar2);
		int num3 = ShortcutExtensions.DOKill(bar3);
		int num4 = ShortcutExtensions.DOKill(noConnection);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(bar1, 0f, 0.5f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOFade(bar2, 0f, 0.5f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore3 = DOTweenModuleUI.DOFade(bar3, 0f, 0.5f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore4 = DOTweenModuleUI.DOFade(noConnection, 1f, 0.5f);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v19+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AnimationExtensions.AnimEmphasise2(animationParent);
	}
}
