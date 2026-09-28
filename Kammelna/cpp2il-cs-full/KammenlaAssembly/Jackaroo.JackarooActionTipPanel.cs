using Cpp2ILInjected;
using DG.Tweening;
using TMPro;
using UnityEngine;

namespace Jackaroo;

public class JackarooActionTipPanel : MonoBehaviour
{
	private DOTweenAnimation _fadeAnimation;

	private TextMeshProUGUI _tipText;

	public void ShowActionTip(string tip)
	{
		//IL_0026: Expected I, but got O
		//IL_0036: Expected O, but got I
		//IL_0046: Expected O, but got I
		TextMeshProExtensions.Localize(_tipText, tip);
		DOTweenAnimation fadeAnimation = _fadeAnimation;
		nint num = (nint)fadeAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X8_v1 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v18 @ X2_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void HideActionTip()
	{
		//IL_0017: Expected I, but got O
		//IL_0027: Expected O, but got I
		//IL_0037: Expected O, but got I
		DOTweenAnimation fadeAnimation = _fadeAnimation;
		nint num = (nint)fadeAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v3 @ X8_v1 (Il2CppClass<DG.Tweening.DOTweenAnimation>)+190]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
