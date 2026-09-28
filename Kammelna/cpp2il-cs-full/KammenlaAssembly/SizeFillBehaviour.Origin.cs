using System;
using System.Buffers.Text;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using UnityEngine;

[Serializable]
public class SizeFillBehaviour : FillBehaviour
{
	private enum Axis
	{
		Horizontal,
		Vertical
	}

	private enum Origin
	{
		Left,
		Center,
		Right
	}

	private RectTransform fill;

	private RectTransform container;

	private Axis axis;

	private bool configureAnchors;

	private Origin origin;

	private bool configured;

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
			//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f3: Expected O, but got Unknown
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0302: Expected O, but got Unknown
			//IL_02c4: Expected O, but got I
			//IL_0277: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Expected O, but got Unknown
			//IL_0290: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Expected O, but got Unknown
			object obj = 152989696;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B87]");
			object obj2 = (nint)0 & (nint)1;
			RectTransform rectTransform;
			object obj3;
			object obj5;
			RectTransform rectTransform2;
			if (obj2 != null)
			{
				rectTransform = fill;
				obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B8B]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				obj5 = obj3;
				rectTransform2 = fill;
				if (!flag)
				{
					goto IL_009f;
				}
			}
			else
			{
				_ = 1;
				rectTransform = fill;
				obj3 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B8B]");
				object obj6 = (nint)0 & (nint)1;
				bool flag2 = obj6 == null;
				object obj7 = !flag2;
				obj5 = obj3;
				rectTransform2 = fill;
				if (obj7 != null)
				{
					goto IL_009f;
				}
			}
			_ = 1;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v12+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			UnityEngine.Object obj10 = rectTransform2;
			UnityEngine.Object obj11 = rectTransform2;
			if (obj9 != null)
			{
				goto IL_00dc;
			}
			goto IL_01ff;
			IL_02df:
			object obj12 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 4064;
			object format = "SetRoomVariables request error" + 960;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object arg2;
			if (configureAnchors)
			{
				object obj13 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 4072;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format2 = ", stale={0}" + 72;
				object arg = default(object);
				string text = string.Format((string)format2, arg);
				arg2 = text;
			}
			else
			{
				object obj14 = (nint)0 + (nint)2000;
				arg2 = obj14;
			}
			string arg3;
			object arg4 = default(object);
			return string.Format((string)format, arg3, arg4, arg2);
			IL_0106:
			if ((object)obj10 != null)
			{
				string name = obj10.name;
				arg3 = name;
				goto IL_02df;
			}
			return (string)(object)new NullReferenceException();
			IL_024b:
			object obj15 = "Network Authentication Required" + 1600;
			arg3 = (string)obj15;
			goto IL_02df;
			IL_009f:
			obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			obj10 = rectTransform;
			obj11 = rectTransform;
			if (!flag4)
			{
				goto IL_00dc;
			}
			goto IL_01ff;
			IL_01ff:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = obj11;
			bool flag6 = !flag5;
			object obj16 = !flag6;
			obj10 = obj11;
			if (obj16 != null)
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
		//IL_0141: Expected O, but got I4
		//IL_0195: Expected O, but got I4
		//IL_01d7: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B20]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = fill;
			obj6 = fill;
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
			obj5 = fill;
			obj6 = fill;
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
		goto IL_00b8;
		IL_00b8:
		ConfigureAnchors();
		float num = TargetLength(ref state);
		Vector2 sizeDelta = fill.sizeDelta;
		if (axis == Axis.Horizontal)
		{
		}
		if (axis == Axis.Horizontal)
		{
		}
		fill.sizeDelta = (Vector2)0;
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b8;
		}
	}

	public override void AnimateFromZero([In] ref ProgressState state, float duration, Ease ease)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_017a: Expected O, but got I4
		//IL_01ce: Expected O, but got I4
		//IL_0210: Expected O, but got I4
		//IL_010f: Expected O, but got I
		//IL_025e: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B88]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = fill;
			obj6 = fill;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = fill;
			obj6 = fill;
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
		goto IL_00b8;
		IL_00b8:
		ConfigureAnchors();
		Vector2 sizeDelta = fill.sizeDelta;
		if (axis == Axis.Horizontal)
		{
		}
		if (axis == Axis.Horizontal)
		{
		}
		fill.sizeDelta = (Vector2)0;
		float duration2 = TargetLength(ref state);
		object obj9 = (nint)0 + (nint)2872;
		Vector2 sizeDelta2 = fill.sizeDelta;
		if (axis == Axis.Horizontal)
		{
		}
		if (axis == Axis.Horizontal)
		{
		}
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(fill, (Vector2)0, duration2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b8;
		}
	}

	public override void AnimateFromCurrent([In] ref ProgressState state, float duration, Ease ease)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014d: Expected O, but got I4
		//IL_01a1: Expected O, but got I4
		//IL_00e2: Expected O, but got I
		//IL_01ec: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B89]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = fill;
			obj6 = fill;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = fill;
			obj6 = fill;
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
		goto IL_00b8;
		IL_00b8:
		ConfigureAnchors();
		float duration2 = TargetLength(ref state);
		object obj9 = (nint)0 + (nint)2872;
		Vector2 sizeDelta = fill.sizeDelta;
		if (axis == Axis.Horizontal)
		{
		}
		if (axis == Axis.Horizontal)
		{
		}
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(fill, (Vector2)0, duration2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b8;
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
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B21]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = fill;
			obj6 = fill;
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
			obj5 = fill;
			obj6 = fill;
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
		int num = ShortcutExtensions.DOKill(fill);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private void ConfigureAnchors()
	{
		//IL_001c: Expected O, but got I4
		//IL_0129: Expected O, but got I4
		//IL_013e: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_0168: Expected O, but got I4
		bool flag = !configured;
		object obj = !flag;
		if (obj == null && configureAnchors)
		{
			configured = configureAnchors;
			if (origin == Origin.Right)
			{
			}
			if (origin == Origin.Left)
			{
			}
			Vector2 pivot = fill.pivot;
			Vector2 anchorMin = fill.anchorMin;
			Vector2 anchorMax = fill.anchorMax;
			Vector2 anchoredPosition = fill.anchoredPosition;
			if (axis == Axis.Horizontal)
			{
			}
			if (axis == Axis.Horizontal)
			{
			}
			if (axis == Axis.Horizontal)
			{
			}
			if (axis == Axis.Horizontal)
			{
			}
			if (axis == Axis.Horizontal)
			{
			}
			if (axis == Axis.Horizontal)
			{
			}
			if (axis == Axis.Horizontal)
			{
			}
			if (axis == Axis.Horizontal)
			{
			}
			fill.pivot = (Vector2)0;
			fill.anchorMin = (Vector2)0;
			fill.anchorMax = (Vector2)0;
			fill.anchoredPosition = (Vector2)0;
		}
	}

	private float TargetLength([In] ref ProgressState state)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_00b6: Expected O, but got I4
		//IL_0403: Expected O, but got I4
		//IL_0411: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_019d: Expected O, but got I4
		//IL_01a6: Expected O, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_045a: Expected O, but got I4
		//IL_052f: Expected O, but got I4
		//IL_04ce: Expected F8, but got O
		//IL_0312: Invalid comparison between F8 and I4
		//IL_0321: Invalid comparison between F8 and I4
		//IL_0339: Expected O, but got F8
		//IL_0346: Expected O, but got F8
		//IL_037b: Expected O, but got I4
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_02c6: Expected F8, but got O
		//IL_02e7: Expected F8, but got O
		//IL_04fa: Expected F8, but got O
		//IL_0587: Invalid comparison between F8 and I4
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected O, but got Unknown
		//IL_03c7: Expected F8, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7B22]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			obj5 = container;
			obj6 = container;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = container;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v26+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = container;
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
		if (obj8 != null)
		{
			goto IL_00c4;
		}
		goto IL_01b4;
		IL_022a:
		UnityEngine.Object obj10;
		if ((bool)obj10)
		{
			goto IL_0254;
		}
		goto IL_0470;
		IL_00c4:
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v7+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		obj10 = container;
		if (obj12 != null)
		{
			goto IL_022a;
		}
		UnityEngine.Object obj13 = container;
		goto IL_0424;
		IL_02f5:
		double num2;
		double num = num2 - 1.0;
		bool flag6 = num < 0.0;
		bool flag7 = num == 0.0;
		object obj14 = num2 ^ 1.0;
		object obj15 = num2 ^ num;
		object obj16 = obj14 & obj15;
		bool flag8 = (nint)obj16 < 0;
		bool flag9 = flag6 == flag8;
		object obj17 = !flag7;
		object obj18 = flag9 & obj17;
		object obj19 = ~obj18;
		double num3 = ((obj19 != null) ? num2 : 1.0);
		double num4 = ((!(num2 < 0.0)) ? num3 : 0.0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SizeFillBehaviour)+18]");
		object obj20 = 0 - base.remapRange;
		double num5 = num4 * (double)obj20;
		double num6 = (double)base.remapRange + num5;
		goto IL_056a;
		IL_0091:
		bool flag10 = obj5;
		bool flag11 = !flag10;
		obj9 = 0;
		if (!flag11)
		{
			goto IL_00c4;
		}
		goto IL_01b4;
		IL_01b4:
		Transform parent = fill.parent;
		if ((object)parent != null)
		{
			object obj21 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			Transform transform = ((parent != obj21) ? null : parent);
			obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v7+E4]");
			bool flag12 = (nint)0 == 0;
			obj10 = transform;
			obj9 = 0;
			obj13 = transform;
			if (!flag12)
			{
				goto IL_022a;
			}
		}
		else
		{
			obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v7+E4]");
			bool flag13 = (nint)0 == 0;
			object obj22 = !flag13;
			obj10 = null;
			obj9 = 0;
			obj13 = null;
			if (obj22 != null)
			{
				goto IL_022a;
			}
		}
		goto IL_0424;
		IL_0254:
		Rect rect = ((RectTransform)obj10).rect;
		object obj23 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj24 = obj23;
		object obj26 = default(object);
		object obj27 = default(object);
		object obj25 = ((axis != Axis.Horizontal) ? obj26 : obj27);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			num2 = (double)state;
			bool flag14 = !base.remap;
			num6 = (double)state;
			if (!flag14)
			{
				goto IL_02f5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			num2 = (double)state;
			if (base.remap)
			{
				goto IL_02f5;
			}
			num6 = (double)state;
		}
		goto IL_056a;
		IL_0424:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag15 = obj13;
		bool flag16 = !flag15;
		object obj28 = !flag16;
		obj10 = obj13;
		if (obj28 != null)
		{
			goto IL_0254;
		}
		goto IL_0470;
		IL_056a:
		return (float)obj25 * (float)num6;
		IL_0470:
		if (axis != Axis.Horizontal)
		{
			Vector2 sizeDelta = fill.sizeDelta;
			float result = default(float);
			return result;
		}
		Vector2 sizeDelta2 = fill.sizeDelta;
		float result2 = default(float);
		return result2;
	}

	private float CurrentLength()
	{
		if (axis != Axis.Horizontal)
		{
			Vector2 sizeDelta = fill.sizeDelta;
			float result = default(float);
			return result;
		}
		Vector2 sizeDelta2 = fill.sizeDelta;
		float result2 = default(float);
		return result2;
	}

	private void SetLength(float length)
	{
		//IL_0072: Expected O, but got I4
		Vector2 sizeDelta = fill.sizeDelta;
		if (axis == Axis.Horizontal)
		{
		}
		if (axis == Axis.Horizontal)
		{
		}
		fill.sizeDelta = (Vector2)0;
	}

	private void AnimateTo(float length, float duration, Ease ease)
	{
		//IL_0011: Expected O, but got I
		//IL_0087: Expected O, but got I4
		object obj = (nint)0 + (nint)2872;
		Vector2 sizeDelta = fill.sizeDelta;
		if (axis == Axis.Horizontal)
		{
		}
		if (axis == Axis.Horizontal)
		{
		}
		float duration2 = default(float);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOSizeDelta(fill, (Vector2)0, duration2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	public SizeFillBehaviour()
	{
		//IL_0012: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DDA10]");
		base.remapRange = (Vector2)0;
		((object)this)..ctor();
	}
}
