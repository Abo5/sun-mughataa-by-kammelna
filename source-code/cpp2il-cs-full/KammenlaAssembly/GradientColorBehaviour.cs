using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class GradientColorBehaviour : ProgressBehaviour
{
	private Graphic target;

	private Gradient gradient;

	private float shownNormalized;

	public override string EditorLabel
	{
		get
		{
			//IL_0016: Expected O, but got I
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Expected O, but got Unknown
			//IL_016e: Expected O, but got I
			//IL_0188: Expected O, but got I4
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_0067: Expected O, but got I
			//IL_01d8: Expected O, but got I4
			//IL_022c: Expected O, but got I4
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Expected O, but got Unknown
			//IL_0276: Unknown result type (might be due to invalid IL or missing references)
			//IL_027b: Expected O, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B83]");
			object obj = (nint)0 & (nint)1;
			Graphic graphic;
			object obj2;
			object obj4;
			Graphic graphic2;
			if (obj != null)
			{
				graphic = target;
				obj2 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B8B]");
				object obj3 = (nint)0 & (nint)1;
				bool flag = obj3 == null;
				obj4 = obj2;
				graphic2 = target;
				if (!flag)
				{
					goto IL_0096;
				}
			}
			else
			{
				_ = 1;
				graphic = target;
				obj2 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B8B]");
				object obj5 = (nint)0 & (nint)1;
				bool flag2 = obj5 == null;
				object obj6 = !flag2;
				obj4 = obj2;
				graphic2 = target;
				if (obj6 != null)
				{
					goto IL_0096;
				}
			}
			_ = 1;
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			UnityEngine.Object obj9 = graphic2;
			UnityEngine.Object obj10 = graphic2;
			if (obj8 != null)
			{
				goto IL_00d3;
			}
			goto IL_01f6;
			IL_026c:
			object obj11 = "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 3384;
			string text;
			return (string)obj11 + text;
			IL_00fd:
			if ((object)obj9 != null)
			{
				string name = obj9.name;
				text = name;
				goto IL_026c;
			}
			return (string)(object)new NullReferenceException();
			IL_0242:
			object obj12 = "Network Authentication Required" + 1600;
			text = (string)obj12;
			goto IL_026c;
			IL_0096:
			obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v5+E4]");
			bool flag4 = (nint)0 == 0;
			obj9 = graphic;
			obj10 = graphic;
			if (!flag4)
			{
				goto IL_00d3;
			}
			goto IL_01f6;
			IL_01f6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = obj10;
			bool flag6 = !flag5;
			object obj13 = !flag6;
			obj9 = obj10;
			if (obj13 != null)
			{
				goto IL_00fd;
			}
			goto IL_0242;
			IL_00d3:
			if ((bool)obj9)
			{
				goto IL_00fd;
			}
			goto IL_0242;
		}
	}

	public override void SetImmediate([In] ref ProgressState state)
	{
		//IL_000f: Expected F4, but got O
		Set((float)state);
	}

	public override void AnimateFromZero([In] ref ProgressState state, float duration, Ease ease)
	{
		//IL_0022: Expected F4, but got O
		Set(0f);
		AnimateTo((float)state, duration, ease);
	}

	public override void AnimateFromCurrent([In] ref ProgressState state, float duration, Ease ease)
	{
		//IL_0017: Expected F4, but got O
		AnimateTo((float)state, duration, ease);
	}

	public override void Kill()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fc: Expected O, but got I4
		//IL_0150: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B0F]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = target;
			obj6 = target;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = target;
			obj6 = target;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		int num = ShortcutExtensions.DOKill(target);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private void AnimateTo(float targetNormalized, float duration, Ease ease)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_021a: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0100: Expected O, but got I
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0120: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_0144: Expected I, but got O
		//IL_0264: Expected O, but got I4
		//IL_026d: Expected O, but got I4
		//IL_0161: Expected I, but got O
		//IL_0190: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B10]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = target;
			obj6 = target;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = target;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = target;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00c0;
		IL_00c0:
		object obj10 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 56;
		object obj11 = (nint)0 + (nint)3800;
		object obj12 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 136;
		object obj13 = (nint)0 + (nint)3808;
		object obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj15 = (nint)0 + (nint)3200;
		object obj16 = (nint)0 + (nint)2864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOGetter<float> dOGetter = default(DOGetter<float>);
		dOGetter..ctor((object)this, (IntPtr)obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		DOSetter<float> dOSetter = default(DOSetter<float>);
		dOSetter..ctor((object)this, (IntPtr)obj13);
		object obj17 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v36+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, targetNormalized, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		return;
		IL_0091:
		bool flag6 = obj5;
		bool flag7 = !flag6;
		obj9 = 0;
		if (!flag7)
		{
			goto IL_00c0;
		}
	}

	private void Set(float normalized)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_01a3: Expected O, but got I4
		//IL_00eb: Expected I, but got O
		//IL_00fb: Expected O, but got I
		//IL_010b: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B11]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0115;
		}
		shownNormalized = normalized;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		UnityEngine.Object obj5 = target;
		UnityEngine.Object obj6 = target;
		if (!flag)
		{
			goto IL_009b;
		}
		goto IL_0171;
		IL_0171:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = obj6;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			return;
		}
		goto IL_00c1;
		IL_009b:
		if ((bool)obj5)
		{
			goto IL_00c1;
		}
		return;
		IL_00c1:
		Graphic graphic = target;
		Color color = gradient.Evaluate(normalized);
		nint num = (nint)graphic;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v7 (Il2CppClass<UnityEngine.UI.Graphic>)+2A8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v7 (Il2CppClass<UnityEngine.UI.Graphic>)+2B0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v111 @ X2_v1 (should have been resolved before IL gen)");
		goto IL_0115;
		IL_0115:
		_ = 1;
		shownNormalized = normalized;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		obj5 = target;
		obj6 = target;
		if (obj10 != null)
		{
			goto IL_009b;
		}
		goto IL_0171;
	}

	public GradientColorBehaviour()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 3216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Gradient gradient = default(Gradient);
		gradient..ctor();
		object obj2 = this + 32;
		obj2 = gradient;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((object)this)..ctor();
	}

	private float <AnimateTo>b__9_0()
	{
		return shownNormalized;
	}
}
