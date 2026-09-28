using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ProgressBar : ProgressMeterBase
{
	private enum AnimationType
	{
		AlwaysStartFromZero,
		Static,
		TransitionBetweenValues
	}

	private enum FillMode
	{
		AnchorPosition,
		SizeDelta,
		SpriteFill
	}

	public enum ColorStyle
	{
		Green,
		Yellow,
		Red,
		White,
		Rainbow,
		None
	}

	public enum IconType
	{
		None,
		Seats
	}

	public enum CurrentValueStyle
	{
		Static,
		FollowBarTip
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<TextMeshProUGUI> <>9__36_0;

		public static Action<TextMeshProUGUI> <>9__36_4;

		public static Action<TextMeshProUGUI> <>9__45_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3584;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <AnimateAnchorPosition>b__36_0(TextMeshProUGUI text)
		{
			text.alignment = TextAlignmentOptions.BaselineLeft;
		}

		internal void <AnimateAnchorPosition>b__36_4(TextMeshProUGUI text)
		{
			text.alignment = TextAlignmentOptions.BaselineRight;
		}

		internal void <KillAnimation>b__45_0(TextMeshProUGUI t)
		{
			int num = ShortcutExtensions.DOKill(t);
		}
	}

	private sealed class <>c__DisplayClass36_0
	{
		public float value;

		internal void <AnimateAnchorPosition>b__5(TextMeshProUGUI t)
		{
			//IL_000b: Invalid comparison between F4 and I4
			//IL_003e: Expected I4, but got F4
			//IL_002f: Expected I4, but got I8
			int number = (int)((value != 2.139095E+09f) ? ((int)value) : 2147483648L);
			TextMeshProExtensions.SetNumber(t, number);
		}
	}

	private sealed class <>c__DisplayClass36_1
	{
		public float value;

		public float delay;

		public ProgressBar <>4__this;

		internal void <AnimateAnchorPosition>b__6()
		{
			//IL_002e: Invalid comparison between F4 and I4
			//IL_0048: Expected O, but got F4
			//IL_0057: Expected O, but got F4
			ProgressBar progressBar = <>4__this;
			float num = value - progressBar.maxValue;
			bool flag = num < 0f;
			object obj = value ^ progressBar.maxValue;
			object obj2 = value ^ num;
			object obj3 = obj & obj2;
			bool flag2 = (nint)obj3 < 0;
			bool isON = flag == flag2;
			progressBar.maxReachedToggler.ToggleManual(isON);
		}

		internal void <AnimateAnchorPosition>b__7(TextMeshProUGUI t)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_004f: Expected O, but got I4
			//IL_007a: Invalid comparison between F4 and I4
			//IL_00b0: Expected I4, but got F4
			//IL_009e: Expected I4, but got I8
			ProgressBar progressBar = <>4__this;
			object obj = typeof(SqlSingle[]) + 3912;
			object obj2 = (nint)0 + (nint)2800;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int endValue = (int)((progressBar.currentValue != 2.139095E+09f) ? ((int)progressBar.currentValue) : 2147483648L);
			Tweener tweener = AnimationExtensions.DONumber(t, endValue, progressBar.animDuration);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		}
	}

	private sealed class <>c__DisplayClass40_0
	{
		public ProgressBar <>4__this;

		public bool isComplete;

		public int targetValue;

		public float delay;

		internal void <AnimateFillToWidth>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00cc: Expected O, but got I4
			ProgressBar progressBar = <>4__this;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				if (!progressBar.maxReachedToggler)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = progressBar.maxReachedToggler;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					return;
				}
			}
			ProgressBar progressBar2 = <>4__this;
			progressBar2.maxReachedToggler.ToggleManual(isComplete);
		}

		internal void <AnimateFillToWidth>b__1(TextMeshProUGUI t)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0025: Expected O, but got I
			//IL_004f: Expected O, but got I4
			ProgressBar progressBar = <>4__this;
			object obj = typeof(SqlSingle[]) + 3912;
			object obj2 = (nint)0 + (nint)2800;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tweener tweener = AnimationExtensions.DONumber(t, targetValue, progressBar.animDuration);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		}
	}

	private sealed class <>c__DisplayClass43_0
	{
		public ProgressBar <>4__this;

		public bool isComplete;

		internal void <AnimateSpriteFillToValue>b__0()
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00cc: Expected O, but got I4
			ProgressBar progressBar = <>4__this;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				if (!progressBar.maxReachedToggler)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = progressBar.maxReachedToggler;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					return;
				}
			}
			ProgressBar progressBar2 = <>4__this;
			progressBar2.maxReachedToggler.ToggleManual(isComplete);
		}
	}

	private sealed class <>c__DisplayClass49_0
	{
		public int maxValue;

		internal void <Initialize>b__0(TextMeshProUGUI t)
		{
			TextMeshProExtensions.SetNumber(t, maxValue);
		}
	}

	private List<TextMeshProUGUI> maxValueTexts;

	private List<TextMeshProUGUI> currentValueTexts;

	private Image progressBar;

	private Image progressBarMask;

	private ProgressBarSprites spriteStore;

	private Image icon;

	private BaseToggler maxReachedToggler;

	private AnimationType animationType;

	private FillMode fillMode;

	private ColorStyle colorStyle;

	private IconType iconType;

	private CurrentValueStyle currentValueStyle;

	private TextMeshProUGUI barText;

	private TextMeshProUGUI barTextFill;

	private RectTransform counterBadge;

	private TextMeshProUGUI counterBadgeText;

	private NumberFormatter counterBadgeNumberFormatter;

	private float maxValue;

	private float currentValue;

	private float? progressBarOriginalXPos;

	private float containerWidth;

	private bool isInitialized;

	private bool barTextFillInitialized;

	private float animDelay;

	private float animDuration;

	private bool isComplete
	{
		get
		{
			//IL_001c: Invalid comparison between F4 and I4
			//IL_0033: Expected O, but got F4
			//IL_0042: Expected O, but got F4
			float num = currentValue - maxValue;
			bool flag = num < 0f;
			object obj = currentValue ^ maxValue;
			object obj2 = currentValue ^ num;
			object obj3 = obj & obj2;
			bool flag2 = (nint)obj3 < 0;
			return flag == flag2;
		}
	}

	private int intValue
	{
		get
		{
			//IL_000b: Invalid comparison between F4 and I4
			//IL_003e: Expected I4, but got F4
			//IL_002f: Expected I4, but got I8
			if (currentValue == 2.139095E+09f)
			{
				return -2147483648;
			}
			return (int)currentValue;
		}
	}

	private void OnEnable()
	{
		if (!isInitialized)
		{
			return;
		}
		KillAnimation();
		if (colorStyle != ColorStyle.None)
		{
			SetColorStyle();
		}
		if (fillMode != FillMode.AnchorPosition)
		{
			if (fillMode != FillMode.SpriteFill)
			{
				if (fillMode == FillMode.SizeDelta)
				{
					AnimateSizeDelta();
				}
			}
			else
			{
				AnimateSpriteFill();
			}
		}
		else
		{
			AnimateAnchorPosition();
		}
	}

	private void AnimateMeter()
	{
		KillAnimation();
		if (colorStyle != ColorStyle.None)
		{
			SetColorStyle();
		}
		if (fillMode != FillMode.AnchorPosition)
		{
			if (fillMode != FillMode.SpriteFill)
			{
				if (fillMode == FillMode.SizeDelta)
				{
					AnimateSizeDelta();
				}
			}
			else
			{
				AnimateSpriteFill();
			}
		}
		else
		{
			AnimateAnchorPosition();
		}
	}

	private void AnimateAnchorPosition()
	{
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_03aa: Expected O, but got I4
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_003a: Expected I, but got O
		//IL_02b0: Expected O, but got I
		//IL_02c0: Expected O, but got I
		//IL_02e2: Expected O, but got I4
		//IL_00ed: Expected O, but got I
		//IL_012a: Expected I, but got O
		//IL_00ac: Expected O, but got I
		//IL_00bc: Expected O, but got I
		//IL_0247: Expected O, but got I4
		//IL_0312: Expected O, but got I4
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0162: Expected O, but got I
		//IL_0170: Expected I, but got O
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03e2: Expected O, but got I
		//IL_03f3: Expected I, but got O
		//IL_0411: Expected O, but got I
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I4
		//IL_0363: Expected O, but got I4
		//IL_0342: Expected O, but got I
		//IL_01e8: Expected I, but got O
		object obj = (??)progressBarOriginalXPos & 1;
		bool flag = obj == null;
		object obj2 = !flag;
		nint num;
		if (obj2 == null)
		{
			RectTransform rectTransform = progressBar.rectTransform;
			Vector2 anchoredPosition = rectTransform.anchoredPosition;
			object obj3 = (nint)0 + (nint)88;
			num = (nint)obj3;
			float value = default(float);
			float? num2 = value;
			progressBarOriginalXPos = num2;
		}
		Action<object> action;
		if (currentValueStyle == CurrentValueStyle.FollowBarTip)
		{
			object obj4 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3584;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v10+E4]");
			object obj6;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v10+B8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v10+8]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v10+8]");
				if ((nint)0 != 0)
				{
					goto IL_00e1;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v10+B8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v10+8]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v10+8]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				if (obj7 != null)
				{
					goto IL_00e1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v16+B8]");
				obj6 = 0;
			}
			object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3680;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)2616;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj6, (IntPtr)obj11);
			object obj12 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v15+B8]");
			object obj13 = (nint)0 + (nint)8;
			obj13 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag4 = currentValueTexts == null;
			object obj14 = !flag4;
			action = action2;
			if (obj14 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00e1;
		}
		goto IL_01ed;
		IL_01ed:
		if (animationType != AnimationType.TransitionBetweenValues)
		{
			if (animationType == AnimationType.Static)
			{
				<AnimateAnchorPosition>g__SetAnchorValue|36_2(currentValue);
				return;
			}
			bool flag5 = animationType == AnimationType.AlwaysStartFromZero;
			object obj15 = !flag5;
			if (obj15 != null)
			{
				return;
			}
			<AnimateAnchorPosition>g__SetAnchorValue|36_2(0f);
		}
		<AnimateAnchorPosition>g__AnimateAnchorToValue|36_3(currentValue, animDelay);
		return;
		IL_00e1:
		object obj16 = (nint)0 + (nint)680;
		((List<object>)(object)currentValueTexts).ForEach(action);
		double num3 = (double)maxValue * 0.5;
		bool flag6 = (double)currentValue < num3;
		num = (nint)action;
		if (!flag6)
		{
			object obj17 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)3592;
			Action action3 = default(Action);
			action3..ctor(this, (IntPtr)obj18);
			object obj19 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X0_v24+E4]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(animDelay, action3);
			num = unchecked((nint)null);
		}
		goto IL_01ed;
	}

	private void InitBarTextFill()
	{
		//IL_031f: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I4
		//IL_00a0: Expected O, but got I4
		//IL_00ae: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_0345: Expected O, but got I
		//IL_0353: Expected O, but got I4
		//IL_0202: Expected O, but got I4
		//IL_00ff: Expected O, but got I4
		//IL_0108: Expected O, but got I4
		//IL_0265: Expected O, but got I4
		//IL_026e: Expected O, but got I4
		//IL_017a: Expected O, but got I4
		//IL_02ef: Expected O, but got I4
		//IL_02fd: Expected O, but got I4
		bool flag = !barTextFillInitialized;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (!barTextFill)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = barTextFill;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			if (obj4 == null)
			{
				return;
			}
		}
		barTextFillInitialized = true;
		RectTransform rectTransform = barTextFill.rectTransform;
		rectTransform.anchorMin = (Vector2)0;
		rectTransform.anchorMax = (Vector2)0;
		rectTransform.pivot = (Vector2)0;
		object obj5 = typeof(UsageHint) + 744;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v10+B8]");
		object obj7 = 0;
		rectTransform.anchoredPosition = (Vector2)0;
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X0_v16+E4]");
		object obj10;
		if ((nint)0 != 0)
		{
			bool flag4 = barText;
			bool flag5 = !flag4;
			object obj9 = !flag5;
			obj10 = 0;
			if (obj9 == null)
			{
				goto IL_0116;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag6 = barText;
			bool flag7 = !flag6;
			obj10 = 0;
			if (flag7)
			{
				goto IL_0116;
			}
		}
		RectTransform rectTransform2 = barText.rectTransform;
		Vector2 sizeDelta = rectTransform2.sizeDelta;
		UnityEngine.Object obj11 = barText;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v15+E4]");
		bool flag8 = (nint)0 == 0;
		object obj13 = !flag8;
		obj10 = 0;
		UnityEngine.Object obj14 = barText;
		if (obj13 != null)
		{
			goto IL_0157;
		}
		goto IL_0286;
		IL_02bb:
		RectTransform rectTransform3 = barText.rectTransform;
		Vector2 sizeDelta2 = rectTransform3.sizeDelta;
		goto IL_02e1;
		IL_0286:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj14)
		{
			goto IL_02bb;
		}
		goto IL_02e1;
		IL_0116:
		obj11 = barText;
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v15+E4]");
		bool flag9 = (nint)0 == 0;
		obj14 = barText;
		if (!flag9)
		{
			goto IL_0157;
		}
		goto IL_0286;
		IL_0157:
		bool flag10 = obj11;
		bool flag11 = !flag10;
		object obj15 = !flag11;
		if (obj15 != null)
		{
			goto IL_02bb;
		}
		goto IL_02e1;
		IL_02e1:
		rectTransform.sizeDelta = (Vector2)0;
		rectTransform.anchoredPosition = (Vector2)0;
	}

	private void AnimateSizeDelta()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0102: Expected O, but got I4
		//IL_00c4: Expected O, but got I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_01a3: Expected O, but got I4
		//IL_03b4: Invalid comparison between F8 and I4
		//IL_03c3: Invalid comparison between F8 and I4
		//IL_03db: Expected O, but got F8
		//IL_03e8: Expected O, but got F8
		//IL_041d: Expected O, but got I4
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_045a: Invalid comparison between F4 and I4
		//IL_01e8: Expected F8, but got I4
		//IL_0308: Invalid comparison between F4 and I4
		//IL_033b: Expected I4, but got F4
		//IL_054d: Invalid comparison between F4 and I4
		//IL_0564: Expected O, but got F4
		//IL_0573: Expected O, but got F4
		//IL_032c: Expected I4, but got I8
		//IL_02c5: Invalid comparison between F4 and I4
		//IL_0235: Expected O, but got I4
		//IL_02f8: Expected I4, but got F4
		//IL_02e9: Expected I4, but got I8
		//IL_0269: Invalid comparison between F4 and I4
		//IL_029c: Expected I4, but got F4
		//IL_04bd: Invalid comparison between F4 and I4
		//IL_04d4: Expected O, but got F4
		//IL_04e3: Expected O, but got F4
		//IL_028d: Expected I4, but got I8
		RectTransform rectTransform = progressBar.rectTransform;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Transform parent = rectTransform.parent;
		UnityEngine.Object obj4;
		UnityEngine.Object obj5;
		if ((object)parent != null)
		{
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			Transform transform = ((parent != obj2) ? null : parent);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v23+E4]");
			bool flag = (nint)0 == 0;
			obj4 = transform;
			obj5 = transform;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v23+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj4 = null;
			obj5 = null;
			if (obj6 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj5;
		bool flag4 = !flag3;
		obj4 = obj5;
		if (!flag4)
		{
			goto IL_0158;
		}
		goto IL_037e;
		IL_0158:
		Rect rect = ((RectTransform)obj4).rect;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		float num = default(float);
		containerWidth = num;
		goto IL_037e;
		IL_00a1:
		bool flag6 = obj4;
		bool flag7 = !flag6;
		object obj10 = !flag7;
		if (obj10 != null)
		{
			goto IL_0158;
		}
		goto IL_037e;
		IL_037e:
		InitBarTextFill();
		float num2 = currentValue / maxValue;
		double num3 = (double)num2 - 1.0;
		bool flag8 = num3 < 0.0;
		bool flag9 = num3 == 0.0;
		object obj11 = (double)num2 ^ 1.0;
		object obj12 = (double)num2 ^ num3;
		object obj13 = obj11 & obj12;
		bool flag10 = (nint)obj13 < 0;
		bool flag11 = flag8 == flag10;
		object obj14 = !flag9;
		object obj15 = flag11 & obj14;
		object obj16 = ~obj15;
		double num4 = ((obj16 != null) ? ((double)num2) : 1.0);
		double num5 = ((!(num2 < 0f)) ? num4 : 0.0);
		float num6 = containerWidth * (float)num5;
		if (animationType != AnimationType.TransitionBetweenValues)
		{
			if (animationType != AnimationType.Static)
			{
				bool flag12 = animationType == AnimationType.AlwaysStartFromZero;
				object obj17 = !flag12;
				if (obj17 == null)
				{
					SetFillWidth(0f);
					UpdateCounterBadge(0);
					int targetValue = (int)((currentValue != 2.139095E+09f) ? ((int)currentValue) : 2147483648L);
					float num7 = currentValue - maxValue;
					bool flag13 = num7 < 0f;
					object obj18 = currentValue ^ maxValue;
					object obj19 = currentValue ^ num7;
					object obj20 = obj18 & obj19;
					bool flag14 = (nint)obj20 < 0;
					bool flag15 = flag13 == flag14;
					AnimateFillToWidth(num6, targetValue, flag15, animDelay);
				}
			}
			else
			{
				SetFillWidth(num6);
				Tween tween = AnimateCounterBadgePosition();
				int value = (int)((currentValue != 2.139095E+09f) ? ((int)currentValue) : 2147483648L);
				UpdateCounterBadge(value);
			}
		}
		else
		{
			int targetValue2 = (int)((currentValue != 2.139095E+09f) ? ((int)currentValue) : 2147483648L);
			float num8 = currentValue - maxValue;
			bool flag16 = num8 < 0f;
			object obj21 = currentValue ^ maxValue;
			object obj22 = currentValue ^ num8;
			object obj23 = obj21 & obj22;
			bool flag17 = (nint)obj23 < 0;
			bool flag18 = flag16 == flag17;
			AnimateFillToWidth(num6, targetValue2, flag18, animDelay);
		}
	}

	private void SetFillWidth(float width)
	{
		//IL_0048: Expected O, but got I4
		RectTransform rectTransform = progressBar.rectTransform;
		Vector2 sizeDelta = rectTransform.sizeDelta;
		RectTransform rectTransform2 = progressBar.rectTransform;
		rectTransform2.sizeDelta = (Vector2)0;
	}

	private void AnimateFillToWidth(float targetWidth, int targetValue, bool isComplete, float delay)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_011d: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0149: Expected O, but got I
		//IL_016d: Expected O, but got I4
		//IL_01d1: Expected O, but got I4
		//IL_0213: Expected I, but got O
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_023d: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		Sequence sequence = TweenSettingsExtensions.AppendInterval(s, animDelay);
		RectTransform rectTransform = progressBar.rectTransform;
		RectTransform rectTransform2 = progressBar.rectTransform;
		object obj7 = typeof(SqlSingle[]) + 3912;
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj9 = (nint)0 + (nint)2664;
		object obj10 = (nint)0 + (nint)2512;
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3680;
		object obj12 = (nint)0 + (nint)2672;
		Vector2 sizeDelta = rectTransform2.sizeDelta;
		TweenerCore<Vector2, Vector2, VectorOptions> t = DOTweenModuleUI.DOSizeDelta(rectTransform, (Vector2)0, targetWidth);
		Sequence sequence2 = TweenSettingsExtensions.Append(s, t);
		Tween t2 = AnimateCounterBadgePosition();
		Sequence sequence3 = TweenSettingsExtensions.Join(s, t2);
		object obj13 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		}
		TextMeshProUGUI target = counterBadgeText;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Object)+1C]");
		Tweener t3 = AnimationExtensions.DONumber(target, 0, animDuration, counterBadgeNumberFormatter);
		Sequence sequence4 = TweenSettingsExtensions.Join(s, t3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj9);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj12);
		((List<object>)(object)currentValueTexts).ForEach(action);
	}

	private void UpdateCounterBadge(int value)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_0154: Expected O, but got I4
		//IL_015d: Expected O, but got I4
		//IL_0246: Expected O, but got I4
		//IL_01e7: Expected I, but got O
		//IL_01f7: Expected O, but got I
		//IL_0207: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E784A]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			obj5 = counterBadgeText;
			obj6 = counterBadgeText;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = counterBadgeText;
			obj6 = counterBadgeText;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 != null)
		{
			return;
		}
		goto IL_0170;
		IL_0211:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag5 = counterBadgeNumberFormatter != null;
		bool flag6 = !flag5;
		object obj11 = !flag6;
		if (obj11 != null)
		{
			goto IL_01c6;
		}
		goto IL_0254;
		IL_01c6:
		NumberFormatter numberFormatter = counterBadgeNumberFormatter;
		TextMeshProUGUI textMeshProUGUI = counterBadgeText;
		nint num = (nint)numberFormatter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4 (Il2CppClass<NumberFormatter>)+178]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v4 (Il2CppClass<NumberFormatter>)+180]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v101 @ X4_v2 (should have been resolved before IL gen)");
		goto IL_0211;
		IL_0254:
		TextMeshProExtensions.SetNumber(counterBadgeText, value);
		return;
		IL_0091:
		bool flag7 = obj5 == null;
		bool flag8 = !flag7;
		obj9 = 0;
		obj10 = null;
		if (!flag8)
		{
			return;
		}
		goto IL_0170;
		IL_0170:
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v2+E4]");
		if ((nint)0 == 0)
		{
			goto IL_0211;
		}
		if (counterBadgeNumberFormatter != null)
		{
			goto IL_01c6;
		}
		goto IL_0254;
	}

	private void AnimateSpriteFill()
	{
		//IL_006a: Invalid comparison between F8 and I4
		//IL_0079: Invalid comparison between F8 and I4
		//IL_0091: Expected O, but got F8
		//IL_009e: Expected O, but got F8
		//IL_00d3: Expected O, but got I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_028b: Invalid comparison between F4 and I4
		//IL_011f: Expected F4, but got I4
		//IL_0249: Invalid comparison between F4 and I4
		//IL_027c: Expected I4, but got F4
		//IL_026d: Expected I4, but got I8
		//IL_0206: Invalid comparison between F4 and I4
		//IL_016c: Expected O, but got I4
		//IL_0239: Expected I4, but got F4
		//IL_022a: Expected I4, but got I8
		//IL_01a5: Invalid comparison between F4 and I4
		//IL_01d8: Expected I4, but got F4
		//IL_01c9: Expected I4, but got I8
		progressBarMask.type = Image.Type.Filled;
		progressBarMask.fillMethod = Image.FillMethod.Horizontal;
		progressBarMask.fillOrigin = 1;
		float num = currentValue / maxValue;
		double num2 = (double)num - 1.0;
		bool flag = num2 < 0.0;
		bool flag2 = num2 == 0.0;
		object obj = (double)num ^ 1.0;
		object obj2 = (double)num ^ num2;
		object obj3 = obj & obj2;
		bool flag3 = (nint)obj3 < 0;
		bool flag4 = flag == flag3;
		object obj4 = !flag2;
		object obj5 = flag4 & obj4;
		object obj6 = ~obj5;
		double num3 = ((obj6 != null) ? ((double)num) : 1.0);
		float num4 = ((!(num < 0f)) ? ((float)num3) : 0f);
		if (animationType != AnimationType.TransitionBetweenValues)
		{
			if (animationType != AnimationType.Static)
			{
				bool flag5 = animationType == AnimationType.AlwaysStartFromZero;
				object obj7 = !flag5;
				if (obj7 == null)
				{
					progressBarMask.fillAmount = 0f;
					UpdateCounterBadge(0);
					int targetValue = (int)((currentValue != 2.139095E+09f) ? ((int)currentValue) : 2147483648L);
					AnimateSpriteFillToValue(num4, targetValue);
				}
			}
			else
			{
				progressBarMask.fillAmount = num4;
				Tween tween = AnimateCounterBadgePosition();
				int value = (int)((currentValue != 2.139095E+09f) ? ((int)currentValue) : 2147483648L);
				UpdateCounterBadge(value);
			}
		}
		else
		{
			int targetValue2 = (int)((currentValue != 2.139095E+09f) ? ((int)currentValue) : 2147483648L);
			AnimateSpriteFillToValue(num4, targetValue2);
		}
	}

	private void AnimateSpriteFillToValue(float targetProgress, int targetValue)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_007b: Invalid comparison between F4 and I4
		//IL_0093: Expected O, but got F8
		//IL_00a0: Expected O, but got F4
		//IL_00f9: Expected O, but got I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0136: Expected O, but got I
		//IL_0142: Expected O, but got I
		//IL_01dc: Expected O, but got I4
		//IL_0249: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj4 = typeof(SqlSingle[]) + 3912;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		float num = targetProgress - 1f;
		bool flag = num < 0f;
		object obj6 = (double)targetProgress ^ 1.0;
		object obj7 = targetProgress ^ num;
		object obj8 = obj6 & obj7;
		bool flag2 = (nint)obj8 < 0;
		bool flag3 = flag == flag2;
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj12 = (nint)0 + (nint)2680;
		object obj13 = (nint)0 + (nint)2512;
		Sequence s = DOTween.Sequence();
		Sequence sequence = TweenSettingsExtensions.AppendInterval(s, animDelay);
		TweenerCore<float, float, FloatOptions> t = DOTweenModuleUI.DOFillAmount(progressBarMask, targetProgress, animDuration);
		Sequence sequence2 = TweenSettingsExtensions.Append(s, t);
		Tween t2 = AnimateCounterBadgePosition();
		Sequence sequence3 = TweenSettingsExtensions.Join(s, t2);
		object obj14 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tweener t3 = AnimationExtensions.DONumber(counterBadgeText, targetValue, animDuration, counterBadgeNumberFormatter);
		Sequence sequence4 = TweenSettingsExtensions.Join(s, t3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private Tween AnimateCounterBadgePosition()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fe: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01e1: Expected O, but got I4
		//IL_022e: Invalid comparison between F8 and I4
		//IL_023d: Invalid comparison between F8 and I4
		//IL_0255: Expected O, but got F8
		//IL_0262: Expected O, but got F8
		//IL_0297: Expected O, but got I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_0507: Invalid comparison between F4 and I4
		//IL_02e3: Expected F8, but got I4
		//IL_030f: Invalid comparison between F4 and I4
		//IL_0342: Invalid comparison between F4 and I4
		//IL_0359: Expected O, but got F4
		//IL_0368: Expected O, but got F4
		//IL_0437: Expected O, but got I4
		//IL_04e9: Expected O, but got I4
		//IL_0483: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E784C]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v22+E4]");
			bool flag = (nint)0 == 0;
			obj5 = counterBadge;
			obj6 = counterBadge;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = counterBadge;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v22+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = counterBadge;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!obj6)
		{
			goto IL_00c2;
		}
		goto IL_014b;
		IL_00c2:
		return null;
		IL_0488:
		float endValue;
		return DOTweenModuleUI.DOAnchorPosX(counterBadge, endValue, animDuration);
		IL_014b:
		if ((object)progressBarMask != null)
		{
			RectTransform rectTransform = progressBarMask.rectTransform;
			if ((object)rectTransform != null)
			{
				Rect rect = rectTransform.rect;
				object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X0_v7+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				float num = currentValue / maxValue;
				double num2 = (double)num - 1.0;
				bool flag4 = num2 < 0.0;
				bool flag5 = num2 == 0.0;
				object obj11 = (double)num ^ 1.0;
				object obj12 = (double)num ^ num2;
				object obj13 = obj11 & obj12;
				bool flag6 = (nint)obj13 < 0;
				bool flag7 = flag4 == flag6;
				object obj14 = !flag5;
				object obj15 = flag7 & obj14;
				object obj16 = ~obj15;
				double num3 = ((obj16 != null) ? ((double)num) : 1.0);
				double num4 = ((!(num < 0f)) ? num3 : 0.0);
				if ((object)counterBadge != null)
				{
					GameObject gameObject = counterBadge.gameObject;
					bool active;
					if (currentValue > 0f)
					{
						float num5 = currentValue - maxValue;
						bool flag8 = num5 < 0f;
						object obj17 = currentValue ^ maxValue;
						object obj18 = currentValue ^ num5;
						object obj19 = obj17 & obj18;
						bool flag9 = (nint)obj19 < 0;
						bool flag10 = flag8 == flag9;
						bool flag11 = !flag10;
						active = flag11;
					}
					else
					{
						active = false;
					}
					if ((object)gameObject != null)
					{
						object obj20 = default(object);
						double num6 = (double)obj20 * num4;
						endValue = (float)(0.0 - num6);
						gameObject.SetActive(active);
						if (animationType == AnimationType.TransitionBetweenValues)
						{
							goto IL_0488;
						}
						if (animationType != AnimationType.Static)
						{
							bool flag12 = animationType == AnimationType.AlwaysStartFromZero;
							object obj21 = !flag12;
							if (obj21 != null)
							{
								goto IL_00c2;
							}
							if ((object)counterBadge != null)
							{
								Vector2 anchoredPosition = counterBadge.anchoredPosition;
								counterBadge.anchoredPosition = (Vector2)0;
								goto IL_0488;
							}
						}
						else if ((object)counterBadge != null)
						{
							Vector2 anchoredPosition2 = counterBadge.anchoredPosition;
							counterBadge.anchoredPosition = (Vector2)0;
							return null;
						}
					}
				}
			}
		}
		return (Tween)(object)new NullReferenceException();
		IL_0091:
		bool flag13 = obj5;
		bool flag14 = !flag13;
		object obj22 = !flag14;
		if (obj22 == null)
		{
			goto IL_00c2;
		}
		goto IL_014b;
	}

	private void KillAnimation()
	{
		//IL_0482: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_01c2: Expected I, but got O
		//IL_0268: Expected O, but got I
		//IL_0278: Expected O, but got I
		//IL_029a: Expected O, but got I4
		//IL_03c9: Expected I, but got O
		//IL_03eb: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_0096: Expected O, but got I
		//IL_0451: Expected O, but got I4
		//IL_02ca: Expected O, but got I4
		//IL_00fe: Expected O, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_011a: Expected I, but got O
		//IL_0160: Expected I4, but got O
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_04c2: Expected O, but got I
		//IL_04ca: Expected I, but got O
		//IL_04db: Expected I, but got O
		//IL_04f9: Expected O, but got I
		//IL_0319: Expected O, but got I4
		//IL_0322: Expected O, but got I4
		//IL_0333: Expected O, but got I4
		//IL_033b: Expected I4, but got O
		//IL_02fa: Expected O, but got I
		//IL_0193: Expected O, but got I4
		bool flag = (object)progressBar == null;
		IntPtr intPtr = default(IntPtr);
		bool flag2 = (byte)(nint)intPtr != 0;
		List<object> list = (List<object>)152989696;
		Action<object> action;
		object obj7 = default(object);
		object obj14 = default(object);
		object obj13;
		nint num2;
		if (!flag)
		{
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3584;
			RectTransform rectTransform = progressBar.rectTransform;
			int num = ShortcutExtensions.DOKill(rectTransform, complete: true);
			list = (List<object>)(object)currentValueTexts;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v29+E4]");
			object obj3;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v29+B8]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v15+18]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v15+18]");
				if ((nint)0 != 0)
				{
					goto IL_00bb;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v29+B8]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v15+18]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v15+18]");
				bool flag3 = (nint)0 == 0;
				object obj4 = !flag3;
				if (obj4 != null)
				{
					goto IL_00bb;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v29+E4]");
			bool flag4 = (nint)0 == 0;
			object obj5 = !flag4;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj6 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X8_v21+B8]");
				obj3 = 0;
			}
			obj7 = obj3;
			object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3680;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)2632;
			num2 = (nint)obj9;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj3, (IntPtr)obj9);
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v20+B8]");
			object obj11 = (nint)0 + (nint)24;
			obj11 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag5 = list == null;
			object obj12 = !flag5;
			obj13 = 0;
			action = action2;
			obj14 = 0;
			flag2 = (byte)(int)action2 != 0;
			if (obj12 != null)
			{
				goto IL_00f2;
			}
		}
		goto IL_0349;
		IL_035f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj15;
		bool flag6 = obj15;
		bool flag7 = !flag6;
		bool flag8 = false;
		obj13 = obj14;
		object obj16 = obj7;
		if (flag7)
		{
			goto IL_01ba;
		}
		goto IL_03ad;
		IL_01ba:
		nint num3 = (nint)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v25 (Il2CppClass<System.Object>)+E4]");
		bool flag9 = (nint)0 == 0;
		UnityEngine.Object obj17 = counterBadgeText;
		obj13 = obj14;
		nint num4 = num3;
		UnityEngine.Object obj18 = counterBadgeText;
		if (!flag9)
		{
			goto IL_020b;
		}
		goto IL_041f;
		IL_03ad:
		int num5 = ShortcutExtensions.DOKill(counterBadge);
		num4 = (nint)obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v4 (Il2CppClass<System.Object>)+E4]");
		bool flag10 = (nint)0 == 0;
		object obj19 = !flag10;
		obj17 = counterBadgeText;
		num2 = 0;
		flag8 = false;
		obj18 = counterBadgeText;
		if (obj19 != null)
		{
			goto IL_020b;
		}
		goto IL_041f;
		IL_0231:
		int num6 = ShortcutExtensions.DOKill(counterBadgeText);
		return;
		IL_020b:
		if ((bool)obj17)
		{
			goto IL_0231;
		}
		return;
		IL_041f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag11 = obj18;
		bool flag12 = !flag11;
		object obj20 = !flag12;
		if (obj20 == null)
		{
			return;
		}
		goto IL_0231;
		IL_00bb:
		bool flag13 = list == null;
		obj13 = obj14;
		num2 = 0;
		flag2 = true;
		if (!flag13)
		{
			goto IL_00f2;
		}
		goto IL_0349;
		IL_0349:
		NullReferenceException ex = new NullReferenceException();
		obj15 = (UnityEngine.Object)(object)list;
		goto IL_035f;
		IL_00f2:
		object obj21 = (nint)0 + (nint)680;
		obj7 = typeof(MemberAchievementClanFeedData) + 2976;
		num2 = (nint)obj21;
		list.ForEach(action);
		obj15 = counterBadge;
		ex = (NullReferenceException)obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v12 (System.NullReferenceException)+E4]");
		bool flag14 = (nint)0 == 0;
		obj14 = obj13;
		flag2 = (byte)(int)action != 0;
		if (flag14)
		{
			goto IL_035f;
		}
		bool flag15 = counterBadge;
		bool flag16 = !flag15;
		object obj22 = !flag16;
		obj14 = obj13;
		flag8 = false;
		obj16 = obj7;
		if (obj22 == null)
		{
			goto IL_01ba;
		}
		goto IL_03ad;
	}

	private void SetColorStyle()
	{
		//IL_0048: Invalid comparison between F4 and I4
		ColorStyle style = colorStyle;
		Image image;
		ProgressBarSprites progressBarSprites;
		if (colorStyle == ColorStyle.Rainbow)
		{
			float num = currentValue / maxValue;
			if (num < 1.04522054E+09f)
			{
				image = progressBar;
				progressBarSprites = spriteStore;
				style = ColorStyle.Red;
			}
			else
			{
				image = progressBar;
				progressBarSprites = spriteStore;
				style = (((double)num < 0.5) ? ColorStyle.Yellow : ColorStyle.Green);
			}
		}
		else
		{
			image = progressBar;
			progressBarSprites = spriteStore;
		}
		Sprite fill = progressBarSprites.GetFill(style);
		image.sprite = fill;
	}

	public void SetBarText(string text)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_016e: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0203: Expected O, but got I4
		//IL_025f: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E784E]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			obj5 = barText;
			obj6 = barText;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = barText;
			obj6 = barText;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		string text2 = null;
		if (flag4)
		{
			goto IL_00c7;
		}
		goto IL_01ca;
		IL_012e:
		TextMeshProExtensions.FixArabic(barTextFill, text);
		return;
		IL_0108:
		UnityEngine.Object obj8;
		if ((bool)obj8)
		{
			goto IL_012e;
		}
		return;
		IL_022d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj9;
		bool flag5 = obj9;
		bool flag6 = !flag5;
		object obj10 = !flag6;
		if (obj10 == null)
		{
			return;
		}
		goto IL_012e;
		IL_0091:
		bool flag7 = obj5;
		bool flag8 = !flag7;
		object obj11 = !flag8;
		text2 = null;
		if (obj11 == null)
		{
			goto IL_00c7;
		}
		goto IL_01ca;
		IL_01ca:
		TextMeshProExtensions.FixArabic(barText, text);
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v2+E4]");
		bool flag9 = (nint)0 == 0;
		object obj13 = !flag9;
		obj8 = barTextFill;
		text2 = text;
		obj9 = barTextFill;
		if (obj13 != null)
		{
			goto IL_0108;
		}
		goto IL_022d;
		IL_00c7:
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v2+E4]");
		bool flag10 = (nint)0 == 0;
		obj8 = barTextFill;
		obj9 = barTextFill;
		if (!flag10)
		{
			goto IL_0108;
		}
		goto IL_022d;
	}

	private void SetIconType()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0157: Expected O, but got I4
		//IL_01ab: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E784F]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = icon;
			obj6 = icon;
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
			obj5 = icon;
			obj6 = icon;
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
		if (iconType != IconType.None)
		{
			GameObject gameObject = icon.gameObject;
			gameObject.SetActive(value: true);
			Sprite sprite = spriteStore.GetIcon(iconType);
			icon.sprite = sprite;
		}
		else
		{
			GameObject gameObject2 = icon.gameObject;
			gameObject2.SetActive(value: false);
		}
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	public void Initialize(int maxValue, int currentValue)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Expected F4, but got I4
		//IL_0052: Expected F4, but got I4
		//IL_006d: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3624;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3680;
		object obj4 = (nint)0 + (nint)2688;
		this.maxValue = maxValue;
		this.currentValue = currentValue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		((List<object>)(object)maxValueTexts).ForEach(action);
		SetIconType();
		isInitialized = true;
		KillAnimation();
		if (colorStyle != ColorStyle.None)
		{
			SetColorStyle();
		}
		if (fillMode != FillMode.AnchorPosition)
		{
			if (fillMode != FillMode.SpriteFill)
			{
				if (fillMode == FillMode.SizeDelta)
				{
					AnimateSizeDelta();
				}
			}
			else
			{
				AnimateSpriteFill();
			}
		}
		else
		{
			AnimateAnchorPosition();
		}
	}

	public void StaticInitialize(int maxValue, int currentValue)
	{
		animationType = AnimationType.Static;
		Initialize(maxValue, currentValue);
		animationType = animationType;
	}

	public override void SetProgress(int current, int max)
	{
		Initialize(max, current);
	}

	public override void SetProgressInstant(int current, int max)
	{
		animationType = AnimationType.Static;
		Initialize(max, current);
		animationType = animationType;
	}

	public override void SetText(string text)
	{
		SetBarText(text);
	}

	public ProgressBar()
	{
		//IL_0012: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252F70]");
		animDelay = 0f;
		base..ctor();
	}

	private void <AnimateAnchorPosition>b__36_1()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_013c: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_01e8: Expected O, but got I4
		//IL_017e: Expected O, but got I
		//IL_018e: Expected O, but got I
		//IL_01b0: Expected O, but got I4
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0286: Expected O, but got I
		//IL_0297: Expected I, but got O
		//IL_02b5: Expected O, but got I
		//IL_0237: Expected O, but got I4
		//IL_0218: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3584;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7851]");
		object obj3 = (nint)0 & (nint)1;
		List<TextMeshProUGUI> list;
		List<TextMeshProUGUI> list2;
		object obj4;
		if (obj3 != null)
		{
			list = currentValueTexts;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			list2 = currentValueTexts;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			list = currentValueTexts;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			list2 = currentValueTexts;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v4+10]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v4+10]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		list = list2;
		if (obj8 != null)
		{
			goto IL_00e6;
		}
		goto IL_01c6;
		IL_00f3:
		List<object> list3;
		list3.ForEach(action);
		return;
		IL_00e6:
		list3 = (List<object>)(object)list;
		goto IL_00f3;
		IL_01c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v10+B8]");
			obj7 = 0;
		}
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)2624;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj7, (IntPtr)obj12);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v9+B8]");
		object obj14 = (nint)0 + (nint)16;
		obj14 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag5 = list2 == null;
		object obj15 = !flag5;
		action = action2;
		list3 = (List<object>)(object)list2;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00f3;
		IL_0099:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v4+10]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v4+10]");
		bool flag6 = (nint)0 == 0;
		list2 = list;
		if (!flag6)
		{
			goto IL_00e6;
		}
		goto IL_01c6;
	}

	private unsafe void <AnimateAnchorPosition>g__SetAnchorValue|36_2(float value)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_00d1: Expected O, but got I4
		//IL_00f1: Expected I, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3680;
		object obj4 = (nint)0 + (nint)2640;
		RectTransform rectTransform = progressBar.rectTransform;
		float? num = (float?)(object)(this + 160);
		float value2 = ((float?*)num)->Value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Object)+10]");
		float num2 = 0f / maxValue;
		double num3 = 1.0 - (double)num2;
		float value3 = (float)num3 * value2;
		float? x = value3;
		UIExtensions.MoveTo(rectTransform, isWorldPositions: false, x, (float?)(object)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		((List<object>)(object)currentValueTexts).ForEach(action);
	}

	private unsafe void <AnimateAnchorPosition>g__AnimateAnchorToValue|36_3(float value, float delay)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0052: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0123: Expected O, but got I4
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0160: Expected O, but got I
		//IL_0183: Expected O, but got I4
		//IL_021c: Expected I, but got O
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01c0: Expected O, but got I
		//IL_01d1: Expected I, but got O
		//IL_01e2: Expected O, but got I
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = (nint)0 + (nint)2760;
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		RectTransform rectTransform = progressBar.rectTransform;
		float? num = (float?)(object)(this + 160);
		float value2 = ((float?*)num)->Value;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
		float num2 = 0f / maxValue;
		double num3 = 1.0 - (double)num2;
		float endValue = (float)num3 * value2;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosX(rectTransform, endValue, animDuration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v14+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3680;
		object obj9 = (nint)0 + (nint)2656;
		bool flag2 = maxReachedToggler;
		bool flag3 = !flag2;
		object obj10 = 0;
		TweenCallback tweenCallback = null;
		if (!flag3)
		{
			object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)2648;
			TweenCallback tweenCallback2 = default(TweenCallback);
			tweenCallback2..ctor(obj2, (IntPtr)obj12);
			object obj13 = (nint)0 + (nint)2488;
			obj10 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			tweenCallback = tweenCallback2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj9);
		((List<object>)(object)currentValueTexts).ForEach(action);
	}
}
