using System;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;

[Serializable]
public class NumberTextBehaviour : ProgressBehaviour
{
	private enum Source
	{
		Current,
		Max,
		Percent,
		Ratio
	}

	private sealed class <>c__DisplayClass14_0
	{
		public NumberTextBehaviour <>4__this;

		public int max;

		internal int <AnimateTo>b__0()
		{
			//IL_0041: Expected I4, but got O
			NumberTextBehaviour numberTextBehaviour = <>4__this;
			if (<>4__this != null)
			{
				return numberTextBehaviour.shownValue;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void <AnimateTo>b__1(int x)
		{
			<>4__this.Set(x, max);
		}
	}

	private TextMeshProUGUI label;

	private Source source;

	private NumberFormatter formatter;

	private string ratioSeparator;

	private int shownValue;

	public override string EditorLabel
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Expected O, but got Unknown
			//IL_0177: Expected O, but got I
			//IL_0191: Expected O, but got I4
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			//IL_0070: Expected O, but got I
			//IL_01e1: Expected O, but got I4
			//IL_0235: Expected O, but got I4
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Expected O, but got Unknown
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Expected O, but got Unknown
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_0298: Expected O, but got Unknown
			object obj = 152989696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B86]");
			object obj2 = (nint)0 & (nint)1;
			TextMeshProUGUI textMeshProUGUI;
			object obj3;
			object obj5;
			TextMeshProUGUI textMeshProUGUI2;
			if (obj2 != null)
			{
				textMeshProUGUI = label;
				obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B8B]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				obj5 = obj3;
				textMeshProUGUI2 = label;
				if (!flag)
				{
					goto IL_009f;
				}
			}
			else
			{
				_ = 1;
				textMeshProUGUI = label;
				obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B8B]");
				object obj6 = (nint)0 & (nint)1;
				bool flag2 = obj6 == null;
				object obj7 = !flag2;
				obj5 = obj3;
				textMeshProUGUI2 = label;
				if (obj7 != null)
				{
					goto IL_009f;
				}
			}
			_ = 1;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			UnityEngine.Object obj10 = textMeshProUGUI2;
			UnityEngine.Object obj11 = textMeshProUGUI2;
			if (obj9 != null)
			{
				goto IL_00dc;
			}
			goto IL_01ff;
			IL_0275:
			object obj12 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1296;
			object format = "Network Authentication Required" + 2536;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			string arg;
			object arg2 = default(object);
			return string.Format((string)format, arg, arg2);
			IL_0106:
			if ((object)obj10 != null)
			{
				string name = obj10.name;
				arg = name;
				goto IL_0275;
			}
			return (string)(object)new NullReferenceException();
			IL_024b:
			object obj13 = "Network Authentication Required" + 1600;
			arg = (string)obj13;
			goto IL_0275;
			IL_009f:
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v7+E4]");
			bool flag4 = (nint)0 == 0;
			obj10 = textMeshProUGUI;
			obj11 = textMeshProUGUI;
			if (!flag4)
			{
				goto IL_00dc;
			}
			goto IL_01ff;
			IL_01ff:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = obj11;
			bool flag6 = !flag5;
			object obj14 = !flag6;
			obj10 = obj11;
			if (obj14 != null)
			{
				goto IL_0106;
			}
			goto IL_024b;
			IL_00dc:
			if ((bool)obj10)
			{
				goto IL_0106;
			}
			goto IL_024b;
		}
	}

	public override void SetImmediate([In] ref ProgressState state)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0146: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_019a: Expected O, but got I4
		//IL_01a3: Expected O, but got I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_033c: Expected O, but got I4
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_023e: Expected O, but got I4
		//IL_0367: Invalid comparison between F8 and I4
		//IL_0378: Expected O, but got I4
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_03e9: Expected O, but got I4
		//IL_0414: Invalid comparison between F8 and I4
		//IL_0425: Expected O, but got I4
		//IL_048d: Expected O, but got I4
		//IL_04b1: Invalid comparison between F8 and I8
		//IL_02ce: Expected I4, but got F8
		//IL_02c1: Expected I4, but got I8
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B19]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = label;
			obj6 = label;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = label;
			obj6 = label;
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
		int num;
		if (source != Source.Percent)
		{
			if (source == Source.Max)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ X1 (ProgressState&)+8]");
				num = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ X1 (ProgressState&)+4]");
				num = 0;
			}
		}
		else
		{
			object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj11 = state * 1120403456;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
			double num2 = (double)obj11 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			double num4 = default(double);
			double num3 = num4 + -1.0;
			object obj14 = num4 & 1;
			bool flag6 = obj14 == null;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				num3 = num4;
			}
			double num5 = (double)obj11 - -0.5;
			bool flag7 = num5 == 0.0;
			object obj16 = !flag7;
			object obj17 = ~obj16;
			double num6 = ((obj17 != null) ? num3 : num2);
			double num7 = (double)obj11 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			double num8 = num4 + 1.0;
			object obj18 = num4 & 1;
			bool flag8 = obj18 == null;
			object obj19 = !flag8;
			double num9 = ((obj19 != null) ? num8 : num4);
			double num10 = (double)obj11 - 0.5;
			bool flag9 = num10 == 0.0;
			object obj20 = !flag9;
			object obj21 = ~obj20;
			double num11 = ((obj21 != null) ? num9 : num7);
			bool flag10 = (nint)obj11 < 0;
			object obj22 = obj11 ^ obj11;
			object obj23 = obj11 & obj22;
			bool flag11 = (nint)obj23 < 0;
			bool flag12 = flag10 == flag11;
			object obj24 = !flag12;
			object obj25 = ~obj24;
			if (obj25 == null)
			{
				num11 = num6;
			}
			num = (int)((num11 != 9.218868437227405E+18) ? ((int)num11) : 2147483648L);
		}
		int value = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ X1 (ProgressState&)+8]");
		Set(value, 0);
		return;
		IL_0091:
		bool flag13 = obj5;
		bool flag14 = !flag13;
		obj9 = 0;
		if (!flag14)
		{
			goto IL_00c0;
		}
	}

	public override void AnimateFromZero([In] ref ProgressState state, float duration, Ease ease)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0154: Expected O, but got I4
		//IL_01a8: Expected O, but got I4
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_0349: Expected O, but got I4
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0243: Expected O, but got I4
		//IL_0374: Invalid comparison between F8 and I4
		//IL_0385: Expected O, but got I4
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dc: Expected O, but got Unknown
		//IL_03f6: Expected O, but got I4
		//IL_0421: Invalid comparison between F8 and I4
		//IL_0432: Expected O, but got I4
		//IL_049a: Expected O, but got I4
		//IL_04be: Invalid comparison between F8 and I8
		//IL_02d3: Expected I4, but got F8
		//IL_02c6: Expected I4, but got I8
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B1A]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = label;
			obj6 = label;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = label;
			obj6 = label;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ X1 (ProgressState&)+8]");
		Set(0, 0);
		int num;
		if (source != Source.Percent)
		{
			if (source == Source.Max)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ X1 (ProgressState&)+8]");
				num = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ X1 (ProgressState&)+4]");
				num = 0;
			}
		}
		else
		{
			object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj10 = state * 1120403456;
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
			double num2 = (double)obj10 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			double num4 = default(double);
			double num3 = num4 + -1.0;
			object obj13 = num4 & 1;
			bool flag6 = obj13 == null;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				num3 = num4;
			}
			double num5 = (double)obj10 - -0.5;
			bool flag7 = num5 == 0.0;
			object obj15 = !flag7;
			object obj16 = ~obj15;
			double num6 = ((obj16 != null) ? num3 : num2);
			double num7 = (double)obj10 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			double num8 = num4 + 1.0;
			object obj17 = num4 & 1;
			bool flag8 = obj17 == null;
			object obj18 = !flag8;
			double num9 = ((obj18 != null) ? num8 : num4);
			double num10 = (double)obj10 - 0.5;
			bool flag9 = num10 == 0.0;
			object obj19 = !flag9;
			object obj20 = ~obj19;
			double num11 = ((obj20 != null) ? num9 : num7);
			bool flag10 = (nint)obj10 < 0;
			object obj21 = obj10 ^ obj10;
			object obj22 = obj10 & obj21;
			bool flag11 = (nint)obj22 < 0;
			bool flag12 = flag10 == flag11;
			object obj23 = !flag12;
			object obj24 = ~obj23;
			if (obj24 == null)
			{
				num11 = num6;
			}
			num = (int)((num11 != 9.218868437227405E+18) ? ((int)num11) : 2147483648L);
		}
		int target = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ X1 (ProgressState&)+8]");
		AnimateTo(target, 0, duration, ease);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	public override void AnimateFromCurrent([In] ref ProgressState state, float duration, Ease ease)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0146: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_019a: Expected O, but got I4
		//IL_01a3: Expected O, but got I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_0344: Expected O, but got I4
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_023e: Expected O, but got I4
		//IL_036f: Invalid comparison between F8 and I4
		//IL_0380: Expected O, but got I4
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_03f1: Expected O, but got I4
		//IL_041c: Invalid comparison between F8 and I4
		//IL_042d: Expected O, but got I4
		//IL_0495: Expected O, but got I4
		//IL_04b9: Invalid comparison between F8 and I8
		//IL_02ce: Expected I4, but got F8
		//IL_02c1: Expected I4, but got I8
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B1B]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = label;
			obj6 = label;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = label;
			obj6 = label;
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
		int num;
		if (source != Source.Percent)
		{
			if (source == Source.Max)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ X1 (ProgressState&)+8]");
				num = 0;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ X1 (ProgressState&)+4]");
				num = 0;
			}
		}
		else
		{
			object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
			object obj11 = state * 1120403456;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v14+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
			double num2 = (double)obj11 + -0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
			double num4 = default(double);
			double num3 = num4 + -1.0;
			object obj14 = num4 & 1;
			bool flag6 = obj14 == null;
			object obj15 = !flag6;
			if (obj15 == null)
			{
				num3 = num4;
			}
			double num5 = (double)obj11 - -0.5;
			bool flag7 = num5 == 0.0;
			object obj16 = !flag7;
			object obj17 = ~obj16;
			double num6 = ((obj17 != null) ? num3 : num2);
			double num7 = (double)obj11 + 0.5;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
			double num8 = num4 + 1.0;
			object obj18 = num4 & 1;
			bool flag8 = obj18 == null;
			object obj19 = !flag8;
			double num9 = ((obj19 != null) ? num8 : num4);
			double num10 = (double)obj11 - 0.5;
			bool flag9 = num10 == 0.0;
			object obj20 = !flag9;
			object obj21 = ~obj20;
			double num11 = ((obj21 != null) ? num9 : num7);
			bool flag10 = (nint)obj11 < 0;
			object obj22 = obj11 ^ obj11;
			object obj23 = obj11 & obj22;
			bool flag11 = (nint)obj23 < 0;
			bool flag12 = flag10 == flag11;
			object obj24 = !flag12;
			object obj25 = ~obj24;
			if (obj25 == null)
			{
				num11 = num6;
			}
			num = (int)((num11 != 9.218868437227405E+18) ? ((int)num11) : 2147483648L);
		}
		int target = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ X1 (ProgressState&)+8]");
		AnimateTo(target, 0, duration, ease);
		return;
		IL_0091:
		bool flag13 = obj5;
		bool flag14 = !flag13;
		obj9 = 0;
		if (!flag14)
		{
			goto IL_00c0;
		}
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B1C]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = label;
			obj6 = label;
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
			obj5 = label;
			obj6 = label;
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
		int num = ShortcutExtensions.DOKill(label);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private int ValueOf([In] ref ProgressState state)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00da: Expected O, but got I4
		//IL_01e4: Invalid comparison between F8 and I4
		//IL_01f5: Expected O, but got I4
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0266: Expected O, but got I4
		//IL_0291: Invalid comparison between F8 and I4
		//IL_02a2: Expected O, but got I4
		//IL_030a: Expected O, but got I4
		//IL_032e: Invalid comparison between F8 and I8
		//IL_016a: Expected I4, but got F8
		//IL_015d: Expected I4, but got I8
		if (source != Source.Percent)
		{
			if (source == Source.Max)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ X1 (ProgressState&)+8]");
				return 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [state @ X1 (ProgressState&)+4]");
			return 0;
		}
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj2 = state * 1120403456;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
		double num = (double)obj2 + -0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		double num3 = default(double);
		double num2 = num3 + -1.0;
		object obj5 = num3 & 1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			num2 = num3;
		}
		double num4 = (double)obj2 - -0.5;
		bool flag3 = num4 == 0.0;
		object obj7 = !flag3;
		object obj8 = ~obj7;
		double num5 = ((obj8 != null) ? num2 : num);
		double num6 = (double)obj2 + 0.5;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
		double num7 = num3 + 1.0;
		object obj9 = num3 & 1;
		bool flag4 = obj9 == null;
		object obj10 = !flag4;
		double num8 = ((obj10 != null) ? num7 : num3);
		double num9 = (double)obj2 - 0.5;
		bool flag5 = num9 == 0.0;
		object obj11 = !flag5;
		object obj12 = ~obj11;
		double num10 = ((obj12 != null) ? num8 : num6);
		bool flag6 = (nint)obj2 < 0;
		object obj13 = obj2 ^ obj2;
		object obj14 = obj2 & obj13;
		bool flag7 = (nint)obj14 < 0;
		bool flag8 = flag6 == flag7;
		object obj15 = !flag8;
		object obj16 = ~obj15;
		if (obj16 == null)
		{
			num10 = num5;
		}
		if (num10 == 9.218868437227405E+18)
		{
			return -2147483648;
		}
		return (int)num10;
	}

	private void Set(int value, int max)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Expected O, but got I4
		//IL_0156: Expected O, but got I4
		//IL_00f7: Expected I, but got O
		//IL_0107: Expected O, but got I
		//IL_0117: Expected O, but got I
		shownValue = value;
		if (source == Source.Ratio)
		{
			object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1440;
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg = default(object);
			object arg2 = default(object);
			string text = string.Format((string)format, arg, ratioSeparator, arg2);
			TextMeshProExtensions.FixArabic(label, text);
			return;
		}
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v2+E4]");
		if ((nint)0 == 0)
		{
			goto IL_0121;
		}
		if (formatter != null)
		{
			goto IL_00d6;
		}
		goto IL_0164;
		IL_0164:
		TextMeshProExtensions.SetNumber(label, value);
		return;
		IL_0121:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag = formatter != null;
		bool flag2 = !flag;
		object obj4 = !flag2;
		if (obj4 != null)
		{
			goto IL_00d6;
		}
		goto IL_0164;
		IL_00d6:
		NumberFormatter numberFormatter = formatter;
		TextMeshProUGUI textMeshProUGUI = label;
		nint num = (nint)numberFormatter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v7 (Il2CppClass<NumberFormatter>)+178]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v7 (Il2CppClass<NumberFormatter>)+180]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v138 @ X4_v2 (should have been resolved before IL gen)");
		goto IL_0121;
	}

	private void AnimateTo(int target, int max, float duration, Ease ease)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01bb: Expected O, but got I4
		//IL_0201: Expected O, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0087: Expected O, but got I
		//IL_0098: Expected I, but got O
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I
		//IL_00d8: Expected I, but got O
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_011b: Expected O, but got I4
		//IL_015d: Expected O, but got I
		//IL_0178: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 1288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (source == Source.Ratio)
		{
			object obj4 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj5 = (nint)0 + (nint)2776;
			DOGetter<int> dOGetter = default(DOGetter<int>);
			dOGetter..ctor(obj2, (IntPtr)obj5);
			object obj6 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = (nint)0 + (nint)2784;
			DOSetter<int> dOSetter = default(DOSetter<int>);
			dOSetter..ctor(obj2, (IntPtr)obj7);
			object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			object obj10 = !flag;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TweenerCore<int, int, NoOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, target, duration);
			object obj11 = (nint)0 + (nint)3168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
			object obj12 = (nint)0 + (nint)2824;
		}
		else
		{
			object obj13 = typeof(SqlSingle[]) + 3912;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj15 = !flag2;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tweener tweener = AnimationExtensions.DONumber(label, target, duration, formatter);
			object obj12 = (nint)0 + (nint)2944;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	public NumberTextBehaviour()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		object obj = ", stale={0}" + 2920;
		object obj2 = this + 48;
		obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((object)this)..ctor();
	}
}
