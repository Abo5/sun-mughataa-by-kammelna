using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class SlideShowTournamentPerks : SlideShowCommonsPage
{
	private Transform cupPublic;

	private Transform cupOfficial;

	protected override Tween AnimateShowElements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007f: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I
		//IL_00be: Expected F4, but got O
		//IL_00be: Expected O, but got I4
		//IL_00f0: Expected O, but got I
		//IL_0109: Expected F4, but got O
		//IL_0109: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		HideElements();
		object obj4 = typeof(UsageHint) + 816;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v6+B8]");
		object obj6 = 0;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t = ShortcutExtensions.DOLocalRotate(cupPublic, (Vector3)0, (float)obj6);
		Sequence sequence2 = TweenSettingsExtensions.Append(sequence, t);
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v12+B8]");
		object obj8 = 0;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t2 = ShortcutExtensions.DOLocalRotate(cupOfficial, (Vector3)0, (float)obj8);
		Sequence sequence3 = TweenSettingsExtensions.Append(sequence, t2);
		return sequence;
	}

	protected override Tween AnimateHideElements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0074: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_009a: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0106: Expected O, but got I
		//IL_0137: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		object obj4 = typeof(UsageHint) + 816;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v6+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v7+48]");
		object obj7 = default(object);
		float duration = 0f * (float)obj7;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t = ShortcutExtensions.DOLocalRotate(cupPublic, (Vector3)0, duration);
		Sequence sequence2 = TweenSettingsExtensions.Join(sequence, t);
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v13+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v14+48]");
		float duration2 = 0f * 0f;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t2 = ShortcutExtensions.DOLocalRotate(cupOfficial, (Vector3)0, duration2);
		Sequence sequence3 = TweenSettingsExtensions.Join(sequence, t2);
		return sequence;
	}

	public override void SetHidden()
	{
		base.SetHidden();
		HideElements();
	}

	private void HideElements()
	{
		//IL_001f: Expected O, but got I4
		//IL_0034: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		cupPublic.localEulerAngles = (Vector3)0;
		cupOfficial.localEulerAngles = (Vector3)0;
	}
}
