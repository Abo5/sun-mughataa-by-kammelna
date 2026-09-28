using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Api.AdManager;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public static class AnimationExtensions
{
	private sealed class <>c__DisplayClass13_0
	{
		public TextMeshProUGUI target;

		public string format;

		public int endValue;

		internal void <DONumber>b__0(int x)
		{
			int num = default(int);
			string text = num.ToString(format);
			TextMeshProExtensions.FixArabic(target, text);
		}

		internal unsafe void <DONumber>b__1()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected I4, but got Unknown
			int num = this + 32;
			string text = ((int*)num)->ToString(format);
			TextMeshProExtensions.FixArabic(target, text);
		}
	}

	private sealed class <>c__DisplayClass14_0
	{
		public NumberFormatter formatter;

		public TextMeshProUGUI target;

		public int endValue;

		internal void <DONumber>b__0(int x)
		{
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_0041: Expected O, but got I
			NumberFormatter numberFormatter = formatter;
			TextMeshProUGUI textMeshProUGUI = target;
			nint num = (nint)numberFormatter;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v2 (Il2CppClass<NumberFormatter>)+178]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v7 @ X8_v2 (Il2CppClass<NumberFormatter>)+180]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v8 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void <DONumber>b__1()
		{
			//IL_002b: Expected I, but got O
			//IL_003b: Expected O, but got I
			//IL_004b: Expected O, but got I
			NumberFormatter numberFormatter = formatter;
			int num = endValue;
			TextMeshProUGUI textMeshProUGUI = target;
			nint num2 = (nint)numberFormatter;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v2 (Il2CppClass<NumberFormatter>)+178]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v2 (Il2CppClass<NumberFormatter>)+180]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v7 @ X4_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private sealed class <>c__DisplayClass16_0
	{
		public Transform transform;

		public RectTransform target;

		public Graphic component;

		public Vector3 powerVector;

		public float duration;

		public Vector3 randomRotation;

		public Vector3 originalScale;

		public Vector3 vibrationVector;

		public Action callBack;

		internal void <DOStamp>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Expected O, but got Unknown
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected O, but got Unknown
			//IL_00d5: Expected O, but got I4
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Expected O, but got Unknown
			//IL_0192: Expected O, but got I4
			//IL_01bc: Expected O, but got I4
			//IL_01fb: Expected O, but got I4
			//IL_020c: Expected O, but got I
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Expected O, but got Unknown
			//IL_022c: Expected O, but got I
			//IL_0238: Expected O, but got I
			//IL_025b: Expected F4, but got O
			//IL_025b: Expected O, but got I4
			//IL_028e: Expected I, but got O
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1240;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 24;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			Transform parent = transform.parent;
			object obj5 = obj2 + 16;
			obj5 = parent;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				bool flag = target;
				bool flag2 = !flag;
				object obj7 = !flag2;
				if (obj7 != null)
				{
					goto IL_011f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if ((bool)target)
				{
					goto IL_011f;
				}
			}
			goto IL_0135;
			IL_0135:
			GameObject gameObject = component.gameObject;
			gameObject.SetActive(value: true);
			RectTransform rectTransform = component.rectTransform;
			object obj8 = typeof(SqlSingle[]) + 3912;
			rectTransform.localScale = (Vector3)0;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tween tween = DOFadeChildren(component, 1f, duration);
			RectTransform rectTransform2 = component.rectTransform;
			rectTransform2.localEulerAngles = (Vector3)0;
			object obj11 = (nint)0 + (nint)2904;
			object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj13 = (nint)0 + (nint)3608;
			object obj14 = (nint)0 + (nint)2504;
			RectTransform rectTransform3 = component.rectTransform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(rectTransform3, (Vector3)0, (float)originalScale);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(obj2, (IntPtr)obj13);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			return;
			IL_011f:
			transform.SetParent(target);
			goto IL_0135;
		}
	}

	private sealed class <>c__DisplayClass16_1
	{
		public Transform realParent;

		public <>c__DisplayClass16_0 CS$<>8__locals1;

		internal void <DOStamp>b__1()
		{
			//IL_006c: Expected F4, but got I
			//IL_006c: Expected F4, but got O
			//IL_006c: Expected O, but got I4
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Expected O, but got Unknown
			//IL_00e8: Expected O, but got I4
			<>c__DisplayClass16_0 cS$<>8__locals = CS$<>8__locals1;
			RectTransform rectTransform = cS$<>8__locals.component.rectTransform;
			<>c__DisplayClass16_0 cS$<>8__locals2 = CS$<>8__locals1;
			double num = (double)cS$<>8__locals2.duration * 0.5;
			Vector3 vibrationVector = cS$<>8__locals2.vibrationVector;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v5 (AnimationExtensions+<>c__DisplayClass16_0)+54]");
			Tweener tweener = ShortcutExtensions.DOPunchPosition(rectTransform, (Vector3)10, (float)vibrationVector, 0, 0f);
			<>c__DisplayClass16_0 cS$<>8__locals3 = CS$<>8__locals1;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v7+E4]");
			if ((nint)0 != 0)
			{
				bool flag = cS$<>8__locals3.target;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 != null)
				{
					goto IL_0135;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if ((bool)cS$<>8__locals3.target)
				{
					goto IL_0135;
				}
			}
			goto IL_015d;
			IL_015d:
			<>c__DisplayClass16_0 cS$<>8__locals4 = CS$<>8__locals1;
			Action callBack = cS$<>8__locals4.callBack;
			if (cS$<>8__locals4.callBack != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v105.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			return;
			IL_0135:
			<>c__DisplayClass16_0 cS$<>8__locals5 = CS$<>8__locals1;
			cS$<>8__locals5.transform.SetParent(realParent);
			goto IL_015d;
		}
	}

	private sealed class <>c__DisplayClass17_0
	{
		public Image target;

		internal float <DOPixelsPerUnitMultiplier>b__0()
		{
			Image image = target;
			return image.m_PixelsPerUnitMultiplier;
		}

		internal void <DOPixelsPerUnitMultiplier>b__1(float value)
		{
			target.pixelsPerUnitMultiplier = value;
		}
	}

	private sealed class <>c__DisplayClass18_0
	{
		public RectTransform target;

		internal Vector2 <DOOffsetMin>b__0()
		{
			if ((object)target != null)
			{
				return target.offsetMin;
			}
			return (Vector2)new NullReferenceException();
		}

		internal void <DOOffsetMin>b__1(Vector2 value)
		{
			//IL_0010: Expected O, but got I4
			target.offsetMin = (Vector2)0;
		}
	}

	private sealed class <>c__DisplayClass19_0
	{
		public RectTransform target;

		internal Vector2 <DOOffsetMax>b__0()
		{
			if ((object)target != null)
			{
				return target.offsetMax;
			}
			return (Vector2)new NullReferenceException();
		}

		internal void <DOOffsetMax>b__1(Vector2 value)
		{
			//IL_0010: Expected O, but got I4
			target.offsetMax = (Vector2)0;
		}
	}

	private sealed class <>c__DisplayClass1_0
	{
		public Sequence seq;

		internal void <AnimPulsing>b__0()
		{
			//IL_0011: Expected O, but got I
			if (TweenExtensions.IsActive(seq))
			{
				object obj = (nint)0 + (nint)2408;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
			}
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public RectTransform target;

		internal Vector2 <DOOffsetMinX>b__0()
		{
			if ((object)target != null)
			{
				return target.offsetMin;
			}
			return (Vector2)new NullReferenceException();
		}

		internal void <DOOffsetMinX>b__1(Vector2 value)
		{
			//IL_0010: Expected O, but got I4
			target.offsetMin = (Vector2)0;
		}
	}

	private sealed class <>c__DisplayClass21_0
	{
		public RectTransform target;

		internal Vector2 <DOOffsetMaxX>b__0()
		{
			if ((object)target != null)
			{
				return target.offsetMax;
			}
			return (Vector2)new NullReferenceException();
		}

		internal void <DOOffsetMaxX>b__1(Vector2 value)
		{
			//IL_0010: Expected O, but got I4
			target.offsetMax = (Vector2)0;
		}
	}

	private sealed class <>c__DisplayClass22_0
	{
		public RectTransform target;

		internal Vector2 <DOOffsetMinY>b__0()
		{
			if ((object)target != null)
			{
				return target.offsetMin;
			}
			return (Vector2)new NullReferenceException();
		}

		internal void <DOOffsetMinY>b__1(Vector2 value)
		{
			//IL_0010: Expected O, but got I4
			target.offsetMin = (Vector2)0;
		}
	}

	private sealed class <>c__DisplayClass23_0
	{
		public RectTransform target;

		internal Vector2 <DOOffsetMaxY>b__0()
		{
			if ((object)target != null)
			{
				return target.offsetMax;
			}
			return (Vector2)new NullReferenceException();
		}

		internal void <DOOffsetMaxY>b__1(Vector2 value)
		{
			//IL_0010: Expected O, but got I4
			target.offsetMax = (Vector2)0;
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public RectTransform rect;

		internal void <AnimLoseHeart>b__0()
		{
			//IL_0037: Expected O, but got I4
			GameObject gameObject = rect.gameObject;
			gameObject.SetActive(value: false);
			rect.localScale = (Vector3)0;
		}
	}

	private sealed class <>c__DisplayClass3_1
	{
		public Image img;

		public <>c__DisplayClass3_0 CS$<>8__locals1;

		internal void <AnimLoseHeart>b__1()
		{
			//IL_0049: Expected O, but got I4
			GameObject gameObject = img.gameObject;
			gameObject.SetActive(value: false);
			<>c__DisplayClass3_0 cS$<>8__locals = CS$<>8__locals1;
			cS$<>8__locals.rect.localScale = (Vector3)0;
			UIExtensions.SetAlpha(img, 1f);
		}
	}

	private sealed class <>c__DisplayClass3_2
	{
		public Image img;

		internal void <AnimLoseHeart>b__2()
		{
			GameObject gameObject = img.gameObject;
			gameObject.SetActive(value: false);
			UIExtensions.SetAlpha(img, 1f);
		}
	}

	private sealed class <>c__DisplayClass3_3
	{
		public Vector2 originalSizeDelta;

		public <>c__DisplayClass3_0 CS$<>8__locals2;

		internal void <AnimLoseHeart>b__3()
		{
			//IL_0056: Expected O, but got I4
			<>c__DisplayClass3_0 cS$<>8__locals = CS$<>8__locals2;
			GameObject gameObject = cS$<>8__locals.rect.gameObject;
			gameObject.SetActive(value: false);
			<>c__DisplayClass3_0 cS$<>8__locals2 = CS$<>8__locals2;
			cS$<>8__locals2.rect.sizeDelta = (Vector2)0;
		}
	}

	private static readonly Dictionary<Transform, Tween> rectStartedSequences;

	public static void AnimPulsing(Transform rect, float pulseDuration = 1f, float pulseSize = 0.8f, float delay = 0f, float period = 0f)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_004c: Expected O, but got I
		//IL_0083: Expected O, but got I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0137: Expected O, but got I
		//IL_0145: Expected O, but got I4
		//IL_016f: Expected O, but got I4
		//IL_01a6: Expected O, but got I
		//IL_01b2: Expected O, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_0244: Expected O, but got I
		//IL_0255: Expected O, but got I
		//IL_0261: Expected O, but got I
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0281: Expected O, but got I
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_02ae: Expected O, but got I
		//IL_02d8: Expected I, but got O
		//IL_0307: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1272;
		object obj2 = typeof(SqlSingle[]) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			AnimEndAnimation(rect);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BB]");
			object obj5 = (nint)0 & (nint)1;
			if (obj5 != null)
			{
				goto IL_0069;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			AnimEndAnimation(rect);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0BB]");
			object obj6 = (nint)0 & (nint)1;
			bool flag = obj6 == null;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_0069;
			}
		}
		_ = 1;
		goto IL_00f7;
		IL_00f7:
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj9 = typeof(UsageHint) + 816;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v8+B8]");
		object obj11 = 0;
		rect.localScale = (Vector3)0;
		object obj12 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		object obj14 = (nint)0 + (nint)2904;
		object obj15 = (nint)0 + (nint)3064;
		object obj16 = obj3 + 16;
		obj16 = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Sequence sequence2 = TweenSettingsExtensions.AppendInterval((Sequence)obj16, period);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(rect, pulseSize, pulseDuration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Append((Sequence)obj16, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30593E4");
		object obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v11+B8]");
		object obj18 = 0;
		object obj19 = (nint)0 + (nint)2440;
		object obj20 = (nint)0 + (nint)2384;
		object obj21 = typeof(SqlSingle[]) + 2376;
		object obj22 = (nint)0 + (nint)3664;
		object obj23 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3 (System.Object)+10]");
		((Dictionary<object, object>)obj18).Add((object)rect, (object)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30506C0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj3, (IntPtr)obj22);
		object obj24 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v29+E4]");
		bool flag3 = (nint)0 == 0;
		object obj25 = !flag3;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(delay, action);
		return;
		IL_0069:
		bool flag4 = (object)rect == null;
		object obj26 = !flag4;
		if (obj26 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00f7;
	}

	public static void AnimGuruGoMawaru(Transform rect, float roundDuration = 1.5f)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0152: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_0040: Expected O, but got I
		//IL_0073: Expected O, but got I4
		//IL_00b1: Expected O, but got I4
		//IL_00fc: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 3912;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2848;
		object obj6 = (nint)0 + (nint)3064;
		AnimEndAnimation(rect);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DOLocalRotate(rect, (Vector3)3, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t = default(Tween);
		Sequence sequence2 = TweenSettingsExtensions.Append(sequence, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30593E4");
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v6+B8]");
		object obj10 = 0;
		((Dictionary<object, object>)obj10).Add((object)rect, (object)sequence);
	}

	public static void AnimLoseHeart(RectTransform rect, int style = 0, bool skipIntro = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_039c: Expected O, but got I4
		//IL_041d: Expected O, but got I
		//IL_03dc: Expected O, but got I4
		//IL_057b: Expected O, but got I4
		//IL_057b: Expected O, but got I
		//IL_058b: Expected O, but got I
		//IL_05c6: Expected O, but got I
		//IL_05db: Expected O, but got I
		//IL_0726: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Expected O, but got Unknown
		//IL_061b: Expected O, but got I4
		//IL_061b: Expected O, but got I
		//IL_0782: Expected O, but got I
		//IL_015e: Expected O, but got I4
		//IL_064e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0653: Expected O, but got Unknown
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_0997: Expected O, but got Unknown
		//IL_066e: Expected O, but got I
		//IL_067f: Expected I, but got O
		//IL_068b: Expected O, but got I
		//IL_07b3: Expected O, but got I
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_06cc: Expected O, but got I4
		//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected O, but got Unknown
		//IL_07fa: Expected O, but got I4
		//IL_0803: Expected F4, but got I4
		//IL_0815: Expected O, but got I4
		//IL_09ed: Expected O, but got I
		//IL_0a11: Expected O, but got I
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_0c40: Expected O, but got I
		//IL_0933: Expected O, but got I4
		//IL_0a35: Expected O, but got I
		//IL_0a45: Expected O, but got I
		//IL_01e8: Expected O, but got I
		//IL_01f8: Expected O, but got I
		//IL_06e3: Expected F4, but got I4
		//IL_06e8: Expected I, but got O
		//IL_06f1: Expected F8, but got I4
		//IL_06fa: Expected F8, but got I4
		//IL_086c: Expected O, but got I
		//IL_088a: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected O, but got Unknown
		//IL_08a5: Expected O, but got I
		//IL_08b6: Expected I, but got O
		//IL_0a8d: Expected O, but got I
		//IL_0231: Expected O, but got I
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_08c7: Expected O, but got I
		//IL_08d8: Expected O, but got I4
		//IL_08e1: Expected F4, but got I4
		//IL_08e6: Expected I, but got O
		//IL_08fc: Expected F8, but got I4
		//IL_0278: Expected O, but got I4
		//IL_0c23: Expected O, but got I4
		//IL_0ade: Expected O, but got I4
		//IL_0ade: Expected O, but got I
		//IL_0aee: Expected O, but got I
		//IL_0b0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b11: Expected O, but got Unknown
		//IL_0b27: Expected O, but got I
		//IL_0b38: Expected I, but got O
		//IL_02cf: Expected O, but got I
		//IL_0b49: Expected O, but got I
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_0308: Expected O, but got I
		//IL_0319: Expected I, but got O
		//IL_0b93: Expected O, but got I4
		//IL_032a: Expected O, but got I
		//IL_0337: Expected I, but got O
		//IL_034d: Expected F8, but got I4
		//IL_0bb2: Expected F4, but got I4
		//IL_0bb7: Expected I, but got O
		//IL_0bc0: Expected O, but got I4
		//IL_0bc9: Expected F8, but got I4
		//IL_0bd2: Expected F8, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 3912;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj5 = obj2 + 16;
		obj5 = rect;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			AnimEndAnimation((Transform)obj5);
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v61+E4]");
			if ((nint)0 != 0)
			{
				goto IL_00c4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			AnimEndAnimation((Transform)obj5);
			object obj7 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v61+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 != null)
			{
				goto IL_00c4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Sequence sequence = DOTween.Sequence();
		bool flag3 = default(bool);
		bool flag2 = !flag3;
		object obj9 = !flag2;
		Sequence sequence2 = sequence;
		Sequence sequence3 = sequence;
		if (obj9 != null)
		{
			goto IL_00fa;
		}
		goto IL_03fa;
		IL_0c30:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v9+B8]");
		object obj10 = 0;
		((Dictionary<object, object>)obj10).Add(obj5, (object)sequence3);
		return;
		IL_0909:
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v694 @ X0_v11+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		object obj13 = obj11;
		sequence3 = sequence2;
		if (obj12 == null)
		{
			goto IL_0951;
		}
		goto IL_0c30;
		IL_0127:
		object obj28;
		Tween tween2;
		if (style != 1)
		{
			bool flag5 = style == 0;
			object obj14 = !flag5;
			nint num2;
			double num3;
			double num4;
			if (obj14 != null)
			{
				object obj15 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1336;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj16 = default(object);
				obj16..ctor();
				object obj17 = obj16 + 24;
				obj17 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v57+10]");
				Vector2 sizeDelta = ((RectTransform)0).sizeDelta;
				_ = 1.0;
				_ = 1045220557;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v93 (System.Object)+18]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v58+10]");
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale((Transform)0, 2f, 0.4f);
				object obj20 = (nint)0 + (nint)2904;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				Tween t = default(Tween);
				Sequence sequence4 = TweenSettingsExtensions.Append(sequence2, t);
				object obj21 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v61+10]");
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale((Transform)0, 0.2f, 0.2f);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				Tween t2 = default(Tween);
				Sequence sequence5 = TweenSettingsExtensions.Append(sequence2, t2);
				object obj22 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v64+10]");
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = DOTweenModuleUI.DOSizeDelta((RectTransform)0, (Vector2)0, 5000f);
				object obj23 = (nint)0 + (nint)2872;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
				object obj24 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj25 = (nint)0 + (nint)3760;
				TweenCallback tweenCallback = default(TweenCallback);
				tweenCallback..ctor(obj16, (IntPtr)obj25);
				object obj26 = (nint)0 + (nint)2488;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
				Tween tween = default(Tween);
				Sequence sequence6 = TweenSettingsExtensions.Append(sequence2, tween);
				obj13 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v9+E4]");
				bool flag6 = (nint)0 == 0;
				object obj27 = !flag6;
				sequence3 = sequence2;
				if (obj27 == null)
				{
					float num = 1.06032006E+09f;
					num2 = unchecked((nint)null);
					obj28 = 0;
					num3 = 0.0;
					num4 = 1167867904.0;
					tween2 = tween;
					obj11 = obj13;
					goto IL_0951;
				}
				goto IL_0c30;
			}
			object obj29 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj30 = default(object);
			obj30..ctor();
			object obj31 = obj30 + 24;
			obj31 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj32 = obj31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v80+10]");
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = ShortcutExtensions.DOScale((Transform)0, 3f, 1.5f);
			object obj33 = (nint)0 + (nint)2904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween t3 = default(Tween);
			Sequence sequence7 = TweenSettingsExtensions.Append(sequence2, t3);
			object obj34 = obj31;
			object obj35 = (nint)0 + (nint)3872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			object obj36 = obj30 + 16;
			Tween tween3 = default(Tween);
			obj36 = tween3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag7 = obj36 == null;
			obj28 = 0;
			num3 = 1.5;
			num4 = 3.0;
			tween2 = tween3;
			if (flag7)
			{
				goto IL_0909;
			}
			TweenerCore<Color, Color, ColorOptions> tweenerCore5 = DOTweenModuleUI.DOFade((Image)obj36, 0f, 1.5f);
			object obj37 = (nint)0 + (nint)2816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj38 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj39 = (nint)0 + (nint)3744;
			TweenCallback tweenCallback2 = default(TweenCallback);
			tweenCallback2..ctor(obj30, (IntPtr)obj39);
			object obj40 = (nint)0 + (nint)2456;
			object obj41 = obj40;
			num2 = unchecked((nint)null);
			num3 = 1.5;
			num4 = 0.0;
			TweenCallback tweenCallback3 = tweenCallback2;
		}
		else
		{
			object obj42 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1328;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj43 = default(object);
			obj43..ctor();
			Tweener tweener = ShortcutExtensions.DOShakePosition((Transform)obj5, 1f, 20f);
			object obj44 = (nint)0 + (nint)2944;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween t4 = default(Tween);
			Sequence sequence8 = TweenSettingsExtensions.Append(sequence2, t4);
			object obj45 = (nint)0 + (nint)3872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			object obj46 = obj43 + 16;
			Tween tween4 = default(Tween);
			obj46 = tween4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag8 = obj46 == null;
			object obj47 = 0;
			float num = 1.1190927E+09f;
			nint num2 = 1;
			obj28 = 0;
			double num3 = 20.0;
			double num4 = 1.0;
			tween2 = tween4;
			if (flag8)
			{
				goto IL_0909;
			}
			TweenerCore<Color, Color, ColorOptions> tweenerCore6 = DOTweenModuleUI.DOFade((Image)obj46, 0f, 1f);
			object obj48 = (nint)0 + (nint)2816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj49 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj50 = (nint)0 + (nint)3752;
			TweenCallback tweenCallback4 = default(TweenCallback);
			tweenCallback4..ctor(obj43, (IntPtr)obj50);
			object obj51 = (nint)0 + (nint)2456;
			object obj41 = obj51;
			obj47 = 0;
			num = 1.1190927E+09f;
			num2 = unchecked((nint)null);
			num3 = 1.0;
			num4 = 0.0;
			TweenCallback tweenCallback3 = tweenCallback4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		Tween tween5 = default(Tween);
		Sequence sequence9 = TweenSettingsExtensions.Join(sequence2, tween5);
		obj28 = 0;
		tween2 = tween5;
		goto IL_0909;
		IL_00c4:
		Sequence sequence10 = DOTween.Sequence();
		bool flag9 = !flag3;
		sequence2 = sequence10;
		sequence3 = sequence10;
		if (!flag9)
		{
			goto IL_00fa;
		}
		goto IL_03fa;
		IL_03fa:
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore7 = ShortcutExtensions.DOScale((Transform)obj5, 0.7f, 0.7f);
		object obj52 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t5 = default(Tween);
		Sequence sequence11 = TweenSettingsExtensions.Append(sequence3, t5);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore8 = ShortcutExtensions.DOScale((Transform)obj5, 1.35f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t6 = default(Tween);
		Sequence sequence12 = TweenSettingsExtensions.Append(sequence3, t6);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore9 = ShortcutExtensions.DOScale((Transform)obj5, 1f, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t7 = default(Tween);
		Sequence sequence13 = TweenSettingsExtensions.Append(sequence3, t7);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore10 = ShortcutExtensions.DOScale((Transform)obj5, 1.35f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t8 = default(Tween);
		Sequence sequence14 = TweenSettingsExtensions.Append(sequence3, t8);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore11 = ShortcutExtensions.DOScale((Transform)obj5, 1f, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween tween6 = default(Tween);
		Sequence sequence15 = TweenSettingsExtensions.Append(sequence3, tween6);
		bool flag10 = style != 2;
		RectTransform rectTransform = (RectTransform)(object)tween6;
		sequence2 = sequence3;
		if (flag10)
		{
			goto IL_0127;
		}
		goto IL_055b;
		IL_00fa:
		bool flag11 = style == 2;
		rectTransform = rect;
		sequence3 = sequence2;
		if (!flag11)
		{
			goto IL_0127;
		}
		goto IL_055b;
		IL_055b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (System.Object)+10]");
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore12 = ShortcutExtensions.DOLocalRotate((Transform)0, (Vector3)3, 0f);
		object obj53 = (nint)0 + (nint)2848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t9 = default(Tween);
		Sequence sequence16 = TweenSettingsExtensions.Append(sequence3, t9);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (System.Object)+10]");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore13 = ShortcutExtensions.DOScale((Transform)0, 0f, 1.4f);
		object obj54 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t10 = default(Tween);
		Sequence sequence17 = TweenSettingsExtensions.Join(sequence3, t10);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (System.Object)+10]");
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore14 = ShortcutExtensions.DOLocalRotate((Transform)0, (Vector3)3, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t11 = default(Tween);
		Sequence sequence18 = TweenSettingsExtensions.Append(sequence3, t11);
		object obj55 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj56 = (nint)0 + (nint)3736;
		TweenCallback tweenCallback5 = default(TweenCallback);
		tweenCallback5..ctor(obj2, (IntPtr)obj56);
		object obj57 = (nint)0 + (nint)2512;
		obj28 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v710 @ X0_v9+E4]");
		bool flag12 = (nint)0 == 0;
		object obj58 = !flag12;
		if (obj58 == null)
		{
			float num = 0f;
			nint num2 = unchecked((nint)null);
			double num3 = 1135869952.0;
			double num4 = 0.0;
			tween2 = (Tween)(object)tweenCallback5;
			obj11 = obj13;
			sequence2 = sequence3;
			goto IL_0951;
		}
		goto IL_0c30;
		IL_0951:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj13 = obj3;
		sequence3 = sequence2;
		goto IL_0c30;
	}

	public static void AnimHeartGain(Transform rect, int orderDelay = 0, float initialDelay = 0.7f, float duration = 1f, float overshoot = 1.70158f)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_010d: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_0188: Expected O, but got I
		//IL_0194: Expected O, but got I
		//IL_01a2: Expected O, but got I4
		//IL_01b0: Expected O, but got I4
		//IL_00ca: Expected O, but got I4
		//IL_0149: Expected O, but got I
		//IL_0163: Expected O, but got I4
		//IL_020f: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D7B]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		AnimEndAnimation(rect);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B9]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00b0;
		}
		goto IL_0171;
		IL_017c:
		object obj7 = (nint)0 + (nint)2952;
		object obj8 = (nint)0 + (nint)2776;
		object obj9 = orderDelay * 1053609165;
		rect.localScale = (Vector3)0;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(rect, 1f, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058FB0");
		float num = initialDelay + (float)obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v10+B8]");
		object obj11 = 0;
		object value = default(object);
		((Dictionary<object, object>)obj11).Add((object)rect, value);
		return;
		IL_00b0:
		bool flag3 = (object)rect == null;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_017c;
		IL_0171:
		_ = 1;
		goto IL_017c;
		IL_0074:
		AnimEndAnimation(rect);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B9]");
		object obj13 = (nint)0 & (nint)1;
		if (obj13 != null)
		{
			goto IL_00b0;
		}
		goto IL_0171;
	}

	public static void AnimRankGain(Transform rect, int orderDelay = 0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_010d: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_0188: Expected O, but got I
		//IL_0194: Expected O, but got I
		//IL_01a2: Expected O, but got I4
		//IL_01b0: Expected O, but got I4
		//IL_00ca: Expected O, but got I4
		//IL_0149: Expected O, but got I
		//IL_0163: Expected O, but got I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_0213: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D7C]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v14+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		AnimEndAnimation(rect);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B9]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00b0;
		}
		goto IL_0171;
		IL_017c:
		object obj7 = (nint)0 + (nint)2952;
		object obj8 = (nint)0 + (nint)2776;
		object obj9 = orderDelay * 1053609165;
		rect.localScale = (Vector3)0;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(rect, 1f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058FB0");
		object obj10 = obj9 + 1060320051;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v12+B8]");
		object obj12 = 0;
		object value = default(object);
		((Dictionary<object, object>)obj12).Add((object)rect, value);
		return;
		IL_00b0:
		bool flag3 = (object)rect == null;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_017c;
		IL_0171:
		_ = 1;
		goto IL_017c;
		IL_0074:
		AnimEndAnimation(rect);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B9]");
		object obj14 = (nint)0 & (nint)1;
		if (obj14 != null)
		{
			goto IL_00b0;
		}
		goto IL_0171;
	}

	public static void AnimEmphasise(Transform rect, int orderDelay = 0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_01a5: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_0040: Expected O, but got I
		//IL_0057: Expected O, but got I4
		//IL_0081: Expected O, but got I4
		//IL_014f: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 3912;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2904;
		object obj6 = (nint)0 + (nint)2776;
		AnimEndAnimation(rect);
		object obj7 = orderDelay * 1053609165;
		object obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(rect, 0.7f, 0.4f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Tween t = default(Tween);
		Sequence sequence2 = TweenSettingsExtensions.Append(sequence, t);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(rect, 1f, 0.6f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t2 = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Append(sequence, t2);
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v13+B8]");
		object obj11 = 0;
		((Dictionary<object, object>)obj11).Add((object)rect, (object)sequence);
	}

	public static void AnimEmphasise2(Transform rect, float delay = 0f, float scale = 1.1f)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_018c: Expected O, but got I4
		//IL_0034: Expected O, but got I
		//IL_0040: Expected O, but got I
		//IL_0073: Expected O, but got I4
		//IL_0136: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 3912;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = (nint)0 + (nint)2904;
		object obj6 = (nint)0 + (nint)2776;
		AnimEndAnimation(rect);
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v5+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(rect, scale, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Tween t = default(Tween);
		Sequence sequence2 = TweenSettingsExtensions.Append(sequence, t);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(rect, 1f, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t2 = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Append(sequence, t2);
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v7+B8]");
		object obj10 = 0;
		((Dictionary<object, object>)obj10).Add((object)rect, (object)sequence);
	}

	public static void AnimFlashing(Graphic img, Color color = default(Color), float duration = 1f, float breathing = 0.1f)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0064: Expected O, but got I4
		//IL_014d: Expected O, but got I
		//IL_0159: Expected O, but got I
		//IL_016a: Expected I, but got O
		//IL_0175: Expected O, but got I
		//IL_019f: Expected O, but got I4
		//IL_00d1: Expected O, but got I4
		//IL_011c: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 3912;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		RectTransform rectTransform = img.rectTransform;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		Transform rect = rectTransform;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			rect = rectTransform;
		}
		object obj5 = (nint)0 + (nint)2816;
		object obj6 = (nint)0 + (nint)3064;
		AnimEndAnimation(rect);
		nint num = (nint)img;
		img.color = (Color)0;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		float interval = default(float);
		Sequence sequence2 = TweenSettingsExtensions.AppendInterval(sequence, interval);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor(img, (Color)0, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Append(sequence, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30593E4");
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v7+B8]");
		object obj10 = 0;
		RectTransform rectTransform2 = img.rectTransform;
		((Dictionary<object, object>)obj10).Add((object)rectTransform2, (object)sequence);
	}

	public static void AnimFadeIn(Graphic rect, float orderDelay = 0f)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_0068: Expected O, but got I4
		//IL_00d6: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 3912;
		object obj2 = (nint)0 + (nint)2816;
		object obj3 = (nint)0 + (nint)2736;
		RectTransform rectTransform = rect.rectTransform;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		Transform rect2 = rectTransform;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			rect2 = rectTransform;
		}
		AnimEndAnimation(rect2);
		float num = orderDelay * 1.05360915E+09f;
		UIExtensions.SetAlpha(rect, 0f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(rect, 1f, 1f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		float num2 = num + 1.06032006E+09f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v9+B8]");
		object obj7 = 0;
		RectTransform rectTransform2 = rect.rectTransform;
		object value = default(object);
		((Dictionary<object, object>)obj7).Add((object)rectTransform2, value);
	}

	public static void ErrorFeedback(RectTransform rect, float intensity = 15f, float duration = 0.5f)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0087: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_0117: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 3912;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AnimEndAnimation(rect);
		object obj4 = typeof(UsageHint) + 744;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6+B8]");
		object obj6 = 0;
		float num = intensity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+28]");
		float duration2 = num * 0f;
		float num2 = intensity;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v7+2C]");
		float elasticity = num2 * 0f;
		Tweener value = DOTweenModuleUI.DOPunchAnchorPos(rect, (Vector2)10, duration2, 0, elasticity);
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v8+B8]");
		object obj8 = 0;
		((Dictionary<object, object>)obj8).Add((object)rect, (object)value);
	}

	public static void AnimEndAnimation(Transform rect)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		//IL_0142: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_0196: Expected O, but got I4
		//IL_0228: Expected O, but got I
		//IL_01f8: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D82]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v30+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v30+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v15+B8]");
		object obj7 = 0;
		Dictionary<object, object> dictionary = (Dictionary<object, object>)obj7;
		goto IL_0136;
		IL_0136:
		object obj8 = (nint)0 + (nint)2448;
		if (dictionary.ContainsKey(rect))
		{
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v6+B8]");
			object obj11 = 0;
			object t = ((Dictionary<object, object>)obj11).get_Item((object)rect);
			TweenExtensions.Kill((Tween)t, complete: true);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v10+B8]");
			object obj13 = 0;
			bool flag4 = ((Dictionary<object, object>)obj13).Remove((object)rect);
		}
		return;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v30+B8]");
		object obj14 = 0;
		dictionary = (Dictionary<object, object>)obj14;
		bool flag5 = obj14 == null;
		object obj15 = !flag5;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0136;
	}

	public static Tweener DONumber(TextMeshProUGUI target, int endValue, float duration, bool useCommas = false, bool includeSign = false, bool percentage = false)
	{
		//IL_0009: Expected O, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003d: Expected O, but got I
		//IL_0168: Expected O, but got I4
		//IL_0074: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
		//IL_0537: Expected O, but got I4
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01d5: Expected I4, but got O
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_029f: Expected O, but got I8
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02fe: Expected O, but got I4
		//IL_0314: Expected O, but got I
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_0390: Expected O, but got I8
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03ef: Expected O, but got I4
		//IL_0405: Expected O, but got I
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_04b7: Expected O, but got I4
		object obj = 152981504;
		object obj2 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 3192;
		object obj3 = ", stale={0}" + 3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E5D83]");
		object obj4 = (nint)0 & (nint)1;
		string text;
		string text2;
		bool flag2 = default(bool);
		if (obj4 != null)
		{
			bool flag = !flag2;
			object obj5 = !flag;
			object obj6 = ~obj5;
			object obj7 = ((obj6 != null) ? obj3 : obj2);
			text = (string)obj7;
			bool flag3 = !percentage;
			object obj8 = !flag3;
			text2 = (string)obj7;
			if (obj8 == null)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			bool flag4 = !flag2;
			object obj9 = !flag4;
			object obj10 = ~obj9;
			object obj11 = ((obj10 != null) ? obj3 : obj2);
			text = (string)obj11;
			bool flag5 = !percentage;
			text2 = (string)obj11;
			if (flag5)
			{
				goto IL_00a5;
			}
		}
		object obj12 = "[{0}]:{1}" + 64;
		string text3 = text2 + (string)obj12;
		bool flag6 = !includeSign;
		flag2 = false;
		int num = (int)obj12;
		text = text3;
		bool flag7 = false;
		string text4 = text3;
		if (flag6)
		{
			goto IL_00e1;
		}
		goto IL_01fc;
		IL_01fc:
		object obj13 = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		string text6;
		object obj33;
		if (array != null)
		{
			if (array.Length != 0)
			{
				object obj14 = "&action=sign-up" + 3352;
				object obj15 = array + 32;
				obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X23_v6-8]");
				object obj16 = 0 & 0xFFFFFFFEL;
				if (obj16 != null)
				{
					object obj17 = array + 40;
					obj17 = text4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X23_v8-10]");
					bool flag8 = (nint)0 < (nint)2;
					object obj18 = !flag8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X23_v8-10]");
					object obj19 = -2;
					bool flag9 = obj19 == null;
					object obj20 = ~obj18;
					object obj21 = obj20 | flag9;
					if (obj21 == null)
					{
						object obj22 = "1.2.840.113549.1.12.1.5" + 2080;
						object obj23 = array + 48;
						obj23 = obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X23_v10-18]");
						object obj24 = 0 & 0xFFFFFFFCL;
						if (obj24 != null)
						{
							object obj25 = array + 56;
							obj25 = text4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X23_v12-20]");
							bool flag10 = (nint)0 < (nint)4;
							object obj26 = !flag10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X23_v12-20]");
							object obj27 = -4;
							bool flag11 = obj27 == null;
							object obj28 = ~obj26;
							object obj29 = obj28 | flag11;
							if (obj29 == null)
							{
								object obj30 = "1.2.840.113549.1.12.1.5" + 2096;
								object obj31 = array + 64;
								obj31 = obj30;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								string text5 = string.Concat(array);
								object obj32 = typeof(SqlSingle[]) + 3912;
								obj33 = obj32;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v1+E4]");
								bool flag12 = (nint)0 == 0;
								object obj34 = !flag12;
								text = text5;
								flag2 = flag7;
								num = 0;
								text6 = text5;
								if (obj34 != null)
								{
									goto IL_012a;
								}
								goto IL_04e6;
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		return (Tweener)(object)new NullReferenceException();
		IL_012a:
		return DONumber(target, endValue, duration, text);
		IL_00e1:
		object obj35 = typeof(SqlSingle[]) + 3912;
		obj33 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v1+E4]");
		bool flag13 = (nint)0 == 0;
		text6 = text;
		if (!flag13)
		{
			goto IL_012a;
		}
		goto IL_04e6;
		IL_04e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		text = text6;
		goto IL_012a;
		IL_00a5:
		bool flag14 = !includeSign;
		object obj36 = !flag14;
		num = endValue;
		flag7 = flag2;
		text4 = text;
		if (obj36 == null)
		{
			goto IL_00e1;
		}
		goto IL_01fc;
	}

	public static Tweener DONumber(TextMeshProUGUI target, int endValue, float duration, string format)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00d2: Expected I, but got O
		//IL_00f2: Expected I, but got O
		//IL_0121: Expected O, but got I4
		//IL_016b: Expected O, but got I
		//IL_0186: Expected O, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01bf: Expected O, but got I
		//IL_01d0: Expected I, but got O
		//IL_01dc: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 32;
			object obj4 = (nint)0 + (nint)2000;
			object obj5 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 112;
			object obj6 = (nint)0 + (nint)3568;
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj8 = obj2 + 16;
			obj8 = target;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj2 + 24;
			obj9 = format;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOGetter<int> dOGetter = default(DOGetter<int>);
			dOGetter..ctor(obj8, (IntPtr)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOSetter<int> dOSetter = default(DOSetter<int>);
			dOSetter..ctor(obj2, (IntPtr)obj6);
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj11 = !flag;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+20]");
			TweenerCore<int, int, NoOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, 0, duration);
			object obj12 = (nint)0 + (nint)3168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
			object obj13 = (nint)0 + (nint)2824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)3576;
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(obj2, (IntPtr)obj15);
			object obj16 = (nint)0 + (nint)2464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			Tweener result = default(Tweener);
			return result;
		}
		return (Tweener)(object)new NullReferenceException();
	}

	public static Tweener DONumber(TextMeshProUGUI target, int endValue, float duration, NumberFormatter formatter)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_01be: Expected O, but got I4
		//IL_01c7: Expected O, but got I4
		//IL_01d5: Expected O, but got I4
		//IL_00ce: Expected O, but got I4
		//IL_00dc: Expected O, but got I4
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0135: Expected O, but got I4
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_021a: Expected O, but got I
		//IL_022b: Expected I, but got O
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_025a: Expected O, but got I
		//IL_026b: Expected I, but got O
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_02ae: Expected O, but got I4
		//IL_02f8: Expected O, but got I
		//IL_0313: Expected O, but got I
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_034c: Expected O, but got I
		//IL_035d: Expected I, but got O
		//IL_0369: Expected O, but got I
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		TextMeshProUGUI textMeshProUGUI;
		if (obj2 != null)
		{
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = obj2 + 16;
			obj4 = formatter;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 24;
			obj5 = target;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v9+E4]");
			object obj11;
			if ((nint)0 != 0)
			{
				bool flag = (UnityEngine.Object)obj4 == null;
				textMeshProUGUI = (TextMeshProUGUI)obj5;
				bool flag2 = !flag;
				object obj7 = 0;
				UnityEngine.Object obj8 = null;
				object obj9 = 0;
				UnityEngine.Object obj10 = null;
				obj11 = obj5;
				if (!flag2)
				{
					goto IL_00f7;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = (UnityEngine.Object)obj4 == null;
				textMeshProUGUI = (TextMeshProUGUI)obj5;
				bool flag4 = !flag3;
				object obj12 = !flag4;
				object obj7 = 0;
				UnityEngine.Object obj8 = null;
				object obj9 = 0;
				UnityEngine.Object obj10 = null;
				obj11 = obj5;
				if (obj12 != null)
				{
					goto IL_00f7;
				}
			}
			object obj13 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj14 = (nint)0 + (nint)2000;
			DOGetter<int> dOGetter = default(DOGetter<int>);
			dOGetter..ctor(obj11, (IntPtr)obj14);
			object obj15 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)3584;
			DOSetter<int> dOSetter = default(DOSetter<int>);
			dOSetter..ctor(obj2, (IntPtr)obj16);
			object obj17 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v15+E4]");
			bool flag5 = (nint)0 == 0;
			object obj19 = !flag5;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Object)+20]");
			TweenerCore<int, int, NoOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, 0, duration);
			object obj20 = (nint)0 + (nint)3168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
			object obj21 = (nint)0 + (nint)2824;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			object obj22 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj23 = (nint)0 + (nint)3592;
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(obj2, (IntPtr)obj23);
			object obj24 = (nint)0 + (nint)2464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			Tweener result = default(Tweener);
			return result;
		}
		return (Tweener)(object)new NullReferenceException();
		IL_00f7:
		object obj25 = typeof(SqlSingle[]) + 3912;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v30+E4]");
		bool flag6 = (nint)0 == 0;
		object obj27 = !flag6;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TextMeshProUGUI target2 = textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3 (System.Object)+20]");
		return DONumber(target2, 0, duration);
	}

	public static Tween DOFadeChildren(Graphic component, float endValue, float duration, bool includeParent = true, bool includeInactiveChildren = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_030d: Expected O, but got I4
		//IL_0070: Expected O, but got I
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0148: Expected O, but got I4
		//IL_00f4: Expected O, but got I4
		//IL_0235: Expected O, but got I
		//IL_0334: Expected O, but got I
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_0258: Expected O, but got I4
		//IL_0261: Expected O, but got I4
		//IL_0269: Expected I4, but got O
		//IL_01d4: Expected O, but got I
		//IL_01f2: Expected O, but got I4
		//IL_01fb: Expected O, but got I4
		//IL_0203: Expected I4, but got O
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0290: Expected O, but got I
		//IL_02bb: Expected O, but got I4
		//IL_02c3: Expected I4, but got O
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		Sequence sequence2 = TweenSettingsExtensions.AppendInterval(sequence, duration);
		if ((object)component != null)
		{
			object obj4 = (nint)0 + (nint)808;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31D00");
			object obj6 = default(object);
			if (obj6 != null)
			{
				object obj7 = obj6 + 32;
				if (includeParent)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v10+18]");
					if ((nint)0 >= (nint)1)
					{
						object obj8 = 0;
						object obj9;
						do
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X23_v3+v232 @ X19_v5*8]");
							TweenerCore<Color, Color, ColorOptions> t = DOTweenModuleUI.DOFade((Graphic)0, endValue, duration);
							Sequence sequence3 = TweenSettingsExtensions.Join(sequence, t);
							obj8++;
							obj9 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v10+18]");
						}
						while ((nint)obj9 < 0);
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v10+18]");
					if ((nint)0 >= (nint)1)
					{
						object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
						float num = duration;
						object obj11 = 0;
						bool flag2 = includeInactiveChildren;
						float num2 = duration;
						object obj15;
						do
						{
							object obj12 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v14+E4]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X23_v3+v237 @ X24_v4*8]");
								bool flag3 = (UnityEngine.Object)0 == component;
								bool flag4 = !flag3;
								object obj13 = !flag4;
								obj5 = 0;
								flag2 = (byte)(int)component != 0;
								if (obj13 != null)
								{
									goto IL_015d;
								}
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X23_v3+v237 @ X24_v4*8]");
								bool flag5 = (UnityEngine.Object)0 == component;
								bool flag6 = !flag5;
								object obj14 = !flag6;
								obj5 = 0;
								flag2 = (byte)(int)component != 0;
								if (obj14 != null)
								{
									goto IL_015d;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X23_v3+v237 @ X24_v4*8]");
							TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade((Graphic)0, endValue, duration);
							Sequence sequence4 = TweenSettingsExtensions.Join(sequence, tweenerCore);
							num = duration;
							obj5 = 0;
							flag2 = (byte)(int)tweenerCore != 0;
							num2 = endValue;
							goto IL_015d;
							IL_015d:
							obj11++;
							obj15 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v10+18]");
						}
						while ((nint)obj15 < 0);
					}
				}
				return sequence;
			}
		}
		return (Tween)(object)new NullReferenceException();
	}

	public static void DOStamp(Graphic component, float duration = 0.3f, float power = 40f, float rotation = 0f, float vibration = 3f, float delay = 0f, RectTransform target = null, Action callBack = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_00cc: Expected O, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0115: Expected O, but got I
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0165: Expected I, but got O
		//IL_018f: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = target;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = component;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 96;
		obj5 = callBack;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		float minInclusive = 0f - rotation;
		float num = UnityEngine.Random.Range(minInclusive, rotation);
		object obj6 = typeof(UsageHint) + 816;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X8_v6+B8]");
		object obj8 = 0;
		float num2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v8+50]");
		float num3 = num2 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v8+48]");
		object obj10 = default(object);
		object obj9 = 0 * obj10;
		float num4 = power;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v8+14]");
		float num5 = num4 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v8+C]");
		object obj12 = default(object);
		object obj11 = 0 * obj12;
		float num6 = vibration;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v8+14]");
		float num7 = num6 * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v8+C]");
		object obj14 = default(object);
		object obj13 = 0 * obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+20]");
		Transform transform = ((Component)0).transform;
		object obj15 = obj2 + 16;
		obj15 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj16 = typeof(SqlSingle[]) + 2376;
		object obj17 = (nint)0 + (nint)3600;
		object obj18 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Vector3 localScale = ((Transform)obj15).localScale;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj17);
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v26+E4]");
		bool flag = (nint)0 == 0;
		object obj20 = !flag;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(delay, action);
	}

	public static Tween DOPixelsPerUnitMultiplier(Image target, float endValue, float duration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0079: Expected O, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00b9: Expected I, but got O
		//IL_00d9: Expected I, but got O
		//IL_0103: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 56;
			object obj4 = (nint)0 + (nint)3616;
			object obj5 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 136;
			object obj6 = (nint)0 + (nint)3624;
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj8 = (nint)0 + (nint)3200;
			object obj9 = obj2 + 16;
			obj9 = target;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOGetter<float> dOGetter = default(DOGetter<float>);
			dOGetter..ctor(obj2, (IntPtr)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOSetter<float> dOSetter = default(DOSetter<float>);
			dOSetter..ctor(obj2, (IntPtr)obj6);
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj11 = !flag;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TweenerCore<float, float, FloatOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, endValue, duration);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
			Tween result = default(Tween);
			return result;
		}
		return (Tween)(object)new NullReferenceException();
	}

	public static Tween DOOffsetMin(RectTransform target, Vector2 endValue, float duration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0079: Expected O, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00b9: Expected I, but got O
		//IL_00d9: Expected I, but got O
		//IL_0103: Expected O, but got I4
		//IL_0136: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 72;
			object obj4 = (nint)0 + (nint)3632;
			object obj5 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 152;
			object obj6 = (nint)0 + (nint)3640;
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj8 = (nint)0 + (nint)3208;
			object obj9 = obj2 + 16;
			obj9 = target;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOGetter<Vector2> dOGetter = default(DOGetter<Vector2>);
			dOGetter..ctor(obj2, (IntPtr)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOSetter<Vector2> dOSetter = default(DOSetter<Vector2>);
			dOSetter..ctor(obj2, (IntPtr)obj6);
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj11 = !flag;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, (Vector2)0, duration);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
			Tween result = default(Tween);
			return result;
		}
		return (Tween)(object)new NullReferenceException();
	}

	public static Tween DOOffsetMax(RectTransform target, Vector2 endValue, float duration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0079: Expected O, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_00b9: Expected I, but got O
		//IL_00d9: Expected I, but got O
		//IL_0103: Expected O, but got I4
		//IL_0136: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 72;
			object obj4 = (nint)0 + (nint)3648;
			object obj5 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 152;
			object obj6 = (nint)0 + (nint)3656;
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj8 = (nint)0 + (nint)3208;
			object obj9 = obj2 + 16;
			obj9 = target;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOGetter<Vector2> dOGetter = default(DOGetter<Vector2>);
			dOGetter..ctor(obj2, (IntPtr)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOSetter<Vector2> dOSetter = default(DOSetter<Vector2>);
			dOSetter..ctor(obj2, (IntPtr)obj6);
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj11 = !flag;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTween.To(dOGetter, dOSetter, (Vector2)0, duration);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
			Tween result = default(Tween);
			return result;
		}
		return (Tween)(object)new NullReferenceException();
	}

	public static Tween DOOffsetMinX(RectTransform target, float endValue, float duration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_00cd: Expected I, but got O
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_019b: Expected O, but got I
		//IL_01b3: Expected O, but got I
		//IL_01dd: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 72;
			object obj4 = (nint)0 + (nint)3672;
			object obj5 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 152;
			object obj6 = (nint)0 + (nint)3680;
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj8 = obj2 + 16;
			obj8 = target;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOGetter<Vector2> dOGetter = default(DOGetter<Vector2>);
			dOGetter..ctor(obj2, (IntPtr)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOSetter<Vector2> dOSetter = default(DOSetter<Vector2>);
			dOSetter..ctor(obj2, (IntPtr)obj6);
			object obj9 = typeof(UsageHint) + 744;
			object obj10 = (nint)0 + (nint)3272;
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v5+B8]");
			object obj12 = 0;
			object obj13 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj14 = !flag;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num = endValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v6+28]");
			float duration2 = num * 0f;
			TweenerCore<Vector2, Vector2, VectorOptions> t = DOTween.To(dOGetter, dOSetter, (Vector2)0, duration2);
			Tweener tweener = TweenSettingsExtensions.SetOptions(t, AxisConstraint.X);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
			Tween result = default(Tween);
			return result;
		}
		return (Tween)(object)new NullReferenceException();
	}

	public static Tween DOOffsetMaxX(RectTransform target, float endValue, float duration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_00cd: Expected I, but got O
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_019b: Expected O, but got I
		//IL_01b3: Expected O, but got I
		//IL_01dd: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 72;
			object obj4 = (nint)0 + (nint)3688;
			object obj5 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 152;
			object obj6 = (nint)0 + (nint)3696;
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj8 = obj2 + 16;
			obj8 = target;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOGetter<Vector2> dOGetter = default(DOGetter<Vector2>);
			dOGetter..ctor(obj2, (IntPtr)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOSetter<Vector2> dOSetter = default(DOSetter<Vector2>);
			dOSetter..ctor(obj2, (IntPtr)obj6);
			object obj9 = typeof(UsageHint) + 744;
			object obj10 = (nint)0 + (nint)3272;
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v5+B8]");
			object obj12 = 0;
			object obj13 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj14 = !flag;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num = endValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v6+28]");
			float duration2 = num * 0f;
			TweenerCore<Vector2, Vector2, VectorOptions> t = DOTween.To(dOGetter, dOSetter, (Vector2)0, duration2);
			Tweener tweener = TweenSettingsExtensions.SetOptions(t, AxisConstraint.X);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
			Tween result = default(Tween);
			return result;
		}
		return (Tween)(object)new NullReferenceException();
	}

	public static Tween DOOffsetMinY(RectTransform target, float endValue, float duration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_00cd: Expected I, but got O
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_019b: Expected O, but got I
		//IL_01b3: Expected O, but got I
		//IL_01dd: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 72;
			object obj4 = (nint)0 + (nint)3704;
			object obj5 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 152;
			object obj6 = (nint)0 + (nint)3712;
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj8 = obj2 + 16;
			obj8 = target;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOGetter<Vector2> dOGetter = default(DOGetter<Vector2>);
			dOGetter..ctor(obj2, (IntPtr)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOSetter<Vector2> dOSetter = default(DOSetter<Vector2>);
			dOSetter..ctor(obj2, (IntPtr)obj6);
			object obj9 = typeof(UsageHint) + 744;
			object obj10 = (nint)0 + (nint)3272;
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v5+B8]");
			object obj12 = 0;
			object obj13 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj14 = !flag;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num = endValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v6+10]");
			float duration2 = num * 0f;
			TweenerCore<Vector2, Vector2, VectorOptions> t = DOTween.To(dOGetter, dOSetter, (Vector2)0, duration2);
			Tweener tweener = TweenSettingsExtensions.SetOptions(t, AxisConstraint.Y);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
			Tween result = default(Tween);
			return result;
		}
		return (Tween)(object)new NullReferenceException();
	}

	public static Tween DOOffsetMaxY(RectTransform target, float endValue, float duration)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00ad: Expected I, but got O
		//IL_00cd: Expected I, but got O
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_019b: Expected O, but got I
		//IL_01b3: Expected O, but got I
		//IL_01dd: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 72;
			object obj4 = (nint)0 + (nint)3720;
			object obj5 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 152;
			object obj6 = (nint)0 + (nint)3728;
			object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj8 = obj2 + 16;
			obj8 = target;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOGetter<Vector2> dOGetter = default(DOGetter<Vector2>);
			dOGetter..ctor(obj2, (IntPtr)obj4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			DOSetter<Vector2> dOSetter = default(DOSetter<Vector2>);
			dOSetter..ctor(obj2, (IntPtr)obj6);
			object obj9 = typeof(UsageHint) + 744;
			object obj10 = (nint)0 + (nint)3272;
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v5+B8]");
			object obj12 = 0;
			object obj13 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj14 = !flag;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			float num = endValue;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v6+10]");
			float duration2 = num * 0f;
			TweenerCore<Vector2, Vector2, VectorOptions> t = DOTween.To(dOGetter, dOSetter, (Vector2)0, duration2);
			Tweener tweener = TweenSettingsExtensions.SetOptions(t, AxisConstraint.Y);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305951C");
			Tween result = default(Tween);
			return result;
		}
		return (Tween)(object)new NullReferenceException();
	}

	static AnimationExtensions()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 3136;
		object obj2 = typeof(SqlSingle[]) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj3 = obj2;
		object obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
