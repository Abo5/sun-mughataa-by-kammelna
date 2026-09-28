using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class SlideShowSavingsPage : SlideShowCommonsPage
{
	private Transform cup;

	private Transform ticket1;

	private Transform ticket2;

	private Sequence loop;

	protected override Tween AnimateShowElements()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I
		//IL_00ef: Expected F4, but got O
		//IL_00ef: Expected O, but got I4
		//IL_0115: Expected O, but got I
		//IL_012d: Expected O, but got I
		//IL_0146: Expected F4, but got O
		//IL_0146: Expected O, but got I4
		//IL_0178: Expected O, but got I
		//IL_01b7: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01ff: Expected O, but got I
		//IL_0217: Expected O, but got I
		//IL_0252: Expected O, but got I8
		//IL_026b: Expected O, but got I4
		//IL_029d: Expected O, but got I
		//IL_02d4: Expected O, but got I
		//IL_02ed: Expected O, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v6+B8]");
		object obj6 = 0;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t = ShortcutExtensions.DOLocalRotate(cup, (Vector3)0, (float)obj6);
		Sequence sequence2 = TweenSettingsExtensions.Append(sequence, t);
		object obj7 = (nint)0 + (nint)2784;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v12+B8]");
		object obj9 = 0;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t2 = ShortcutExtensions.DOLocalRotate(ticket1, (Vector3)0, (float)obj9);
		Sequence sequence3 = TweenSettingsExtensions.Append(sequence, t2);
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v18+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v19+48]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v13+8]");
		float duration = num * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v19+50]");
		object obj12 = (nint)0 * (nint)1110704128;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t3 = ShortcutExtensions.DOLocalRotate(ticket2, (Vector3)0, duration);
		Sequence sequence4 = TweenSettingsExtensions.Append(sequence, t3);
		Sequence sequence5 = DOTween.Sequence();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj13 = (nint)0 + (nint)3008;
		object obj14 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v25+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v26+48]");
		float duration2 = 0f * (float)obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v26+50]");
		object obj16 = 0 * 3258187776L;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t4 = ShortcutExtensions.DOLocalRotate(ticket2, (Vector3)3, duration2);
		Sequence s2 = default(Sequence);
		Sequence s = TweenSettingsExtensions.Append(s2, t4);
		object obj17 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v32+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v33+48]");
		float duration3 = 0f * (float)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v33+50]");
		object obj19 = (nint)0 * (nint)1110704128;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t5 = ShortcutExtensions.DOLocalRotate(ticket2, (Vector3)0, duration3);
		Sequence sequence6 = TweenSettingsExtensions.Append(s, t5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059384");
		object obj20 = this + 104;
		object obj21 = default(object);
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return sequence;
	}

	protected override Tween AnimateHideElements()
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_004d: Expected O, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_014b: Expected O, but got I
		//IL_017c: Expected O, but got I4
		//IL_01ae: Expected O, but got I
		//IL_01c7: Expected F4, but got O
		//IL_01c7: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		bool flag = loop == null;
		IntPtr intPtr = default(IntPtr);
		bool flag2 = (byte)(nint)intPtr != 0;
		if (!flag)
		{
			TweenExtensions.Kill(loop);
			flag2 = false;
		}
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj3 = !flag3;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		object obj4 = typeof(UsageHint) + 816;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v7+48]");
		object obj7 = default(object);
		float duration = 0f * (float)obj7;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t = ShortcutExtensions.DOLocalRotate(cup, (Vector3)0, duration);
		Sequence sequence2 = TweenSettingsExtensions.Join(sequence, t);
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v11+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v12+48]");
		float duration2 = 0f * 0f;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t2 = ShortcutExtensions.DOLocalRotate(ticket1, (Vector3)0, duration2);
		Sequence sequence3 = TweenSettingsExtensions.Join(sequence, t2);
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X8_v17+B8]");
		object obj11 = 0;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> t3 = ShortcutExtensions.DOLocalRotate(ticket2, (Vector3)0, (float)obj11);
		Sequence sequence4 = TweenSettingsExtensions.Join(sequence, t3);
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
		//IL_0049: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		cup.localEulerAngles = (Vector3)0;
		ticket1.localEulerAngles = (Vector3)0;
		ticket2.localEulerAngles = (Vector3)0;
	}
}
