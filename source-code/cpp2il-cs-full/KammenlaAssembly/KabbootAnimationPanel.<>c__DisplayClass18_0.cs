using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class KabbootAnimationPanel : MonoBehaviour
{
	private class CardOriginals
	{
		private RectTransform <Card>k__BackingField;

		private Vector2 <Position>k__BackingField;

		private Vector2 <Scale>k__BackingField;

		private Quaternion <Rotation>k__BackingField;

		private RectTransform Card
		{
			get
			{
				return <Card>k__BackingField;
			}
			set
			{
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				//IL_000b: Expected O, but got Unknown
				object obj = this + 16;
				obj = value;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
		}

		private Vector2 Position
		{
			get
			{
				return (Vector2)this;
			}
			set
			{
				Vector2 vector = default(Vector2);
				<Position>k__BackingField = vector;
			}
		}

		private Vector2 Scale
		{
			get
			{
				return (Vector2)this;
			}
			set
			{
				Vector2 vector = default(Vector2);
				<Scale>k__BackingField = vector;
			}
		}

		private Quaternion Rotation
		{
			get
			{
				return (Quaternion)this;
			}
			set
			{
				Quaternion quaternion = default(Quaternion);
				<Rotation>k__BackingField = quaternion;
			}
		}

		public CardOriginals(RectTransform card)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			object obj = this + 16;
			obj = card;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Vector2 anchoredPosition = card.anchoredPosition;
			Vector2 vector = default(Vector2);
			<Position>k__BackingField = vector;
			Vector2 sizeDelta = card.sizeDelta;
			<Scale>k__BackingField = vector;
			Quaternion rotation = card.rotation;
			<Rotation>k__BackingField = (Quaternion)vector;
		}

		public void BackToOriginals()
		{
			//IL_0010: Expected O, but got I4
			//IL_0025: Expected O, but got I4
			//IL_003a: Expected O, but got I4
			<Card>k__BackingField.anchoredPosition = (Vector2)0;
			<Card>k__BackingField.sizeDelta = (Vector2)0;
			<Card>k__BackingField.localRotation = (Quaternion)0;
		}
	}

	[Serializable]
	private class KabbootAnimationProperties
	{
		public float TitleMaxSize;

		public float Duration;

		public float TimeDifferenceBetweenCards;
	}

	private sealed class <>c__DisplayClass18_0
	{
		public Vector2 onYouOriginalPosition;

		public KabbootAnimationPanel <>4__this;

		internal void <ExitLoseAnimation>b__1()
		{
			//IL_0022: Expected O, but got I4
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0040: Expected O, but got I4
			KabbootAnimationPanel kabbootAnimationPanel = <>4__this;
			kabbootAnimationPanel.onYou.anchoredPosition = (Vector2)0;
			object obj = <>4__this + 112;
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			GameObject gameObject = <>4__this.gameObject;
			gameObject.SetActive(value: false);
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public KabbootAnimationPanel <>4__this;

		public List<CardOriginals> originals;

		public TweenCallback <>9__0;

		internal void <PlayCardSequenceBackwards>b__0()
		{
			ReturnCardsToOriginalState(originals);
			<>4__this.HideCards();
		}
	}

	private Transform titleImage;

	private Transform effect;

	private List<RectTransform> cards;

	private RectTransform onYou;

	private Sprite title_Win;

	private Sprite title_Lose;

	private Sprite halo_Win;

	private Sprite halo_Lose;

	private RectTransform cardPosIndx;

	private KabbootAnimationProperties _properties;

	private Sequence mainSequence;

	private bool animationIsPlaying;

	private Sequence MainSequence
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected O, but got Unknown
			//IL_00a4: Expected O, but got I4
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00f0: Expected O, but got I4
			object obj = 152993792;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CE2]");
			object obj2 = (nint)0 & (nint)1;
			Sequence result;
			object obj3;
			if (obj2 != null)
			{
				obj3 = this + 112;
				result = (Sequence)obj3;
				if (obj3 != null)
				{
					goto IL_006c;
				}
			}
			else
			{
				_ = 1;
				obj3 = this + 112;
				result = (Sequence)obj3;
				bool flag = obj3 == null;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_006c;
				}
			}
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence = DOTween.Sequence();
			obj3 = sequence;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (Sequence)obj3;
			IL_006c:
			return result;
		}
	}

	private void Awake()
	{
		ShowWinAnimation();
	}

	public void ShowWinAnimation()
	{
		//IL_00c5: Expected O, but got I4
		//IL_0116: Expected O, but got I4
		//IL_0131: Expected O, but got I
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01f2: Expected O, but got I4
		//IL_01ac: Expected O, but got I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02c2: Expected O, but got I
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0246: Expected O, but got I4
		//IL_0321: Expected I, but got O
		//IL_034f: Expected O, but got I
		//IL_03f2: Expected O, but got I4
		//IL_03b7: Expected O, but got I4
		//IL_040f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_043e: Expected O, but got I4
		//IL_04eb: Expected O, but got I
		//IL_058e: Expected O, but got I4
		//IL_0553: Expected O, but got I4
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected O, but got Unknown
		//IL_05da: Expected O, but got I4
		//IL_081e: Expected O, but got I4
		//IL_070e: Expected O, but got I
		//IL_073d: Expected O, but got I4
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_068e: Expected O, but got Unknown
		//IL_06b8: Expected O, but got I4
		//IL_0838: Expected O, but got I
		//IL_0844: Expected O, but got I
		//IL_0866: Expected O, but got I4
		//IL_086f: Expected O, but got I4
		//IL_08d2: Expected I, but got O
		//IL_0764: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Expected O, but got Unknown
		//IL_0793: Expected O, but got I4
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		SetImagesToWin();
		HideCards();
		GameObject gameObject2 = onYou.gameObject;
		gameObject2.SetActive(value: false);
		animationIsPlaying = true;
		Vector3 localScale = titleImage.localScale;
		KabbootAnimationProperties properties = _properties;
		object obj = default(object);
		float num = (float)obj * properties.TitleMaxSize;
		object obj2 = default(object);
		float num2 = (float)obj2 * properties.TitleMaxSize;
		object obj3 = default(object);
		float num3 = (float)obj3 * properties.TitleMaxSize;
		titleImage.localScale = (Vector3)0;
		Vector3 localScale2 = effect.localScale;
		float num4 = num + num;
		float num5 = num2 + num2;
		float num6 = num3 + num3;
		effect.localScale = (Vector3)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CE2]");
		object obj4 = (nint)0 & (nint)1;
		Sequence s;
		object obj6;
		object obj5;
		if (obj4 != null)
		{
			obj5 = this + 112;
			s = (Sequence)obj5;
			bool flag = obj5 == null;
			obj6 = obj5;
			if (!flag)
			{
				goto IL_0186;
			}
		}
		else
		{
			_ = 1;
			obj5 = this + 112;
			s = (Sequence)obj5;
			bool flag2 = obj5 == null;
			object obj7 = !flag2;
			obj6 = obj5;
			if (obj7 != null)
			{
				goto IL_0186;
			}
		}
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v95+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		obj6 = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		s = (Sequence)obj6;
		KabbootAnimationProperties properties2 = _properties;
		obj5 = obj6;
		goto IL_02a2;
		IL_0391:
		KabbootAnimationProperties properties3 = _properties;
		bool flag4 = _properties == null;
		object obj11 = !flag4;
		if (obj11 != null)
		{
			goto IL_0492;
		}
		goto IL_07e6;
		IL_0492:
		float duration = properties3.Duration * 1.0502537E+09f;
		TweenerCore<Vector3, Vector3, VectorOptions> t = ShortcutExtensions.DOScale(titleImage, 1.3f, duration);
		Sequence s2;
		Sequence sequence2 = TweenSettingsExtensions.Append(s2, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CE2]");
		object obj12 = (nint)0 & (nint)1;
		Sequence s3;
		if (obj12 != null)
		{
			s3 = (Sequence)obj5;
			if (obj5 != null)
			{
				goto IL_052d;
			}
		}
		else
		{
			_ = 1;
			s3 = (Sequence)obj5;
			bool flag5 = obj5 == null;
			object obj13 = !flag5;
			if (obj13 != null)
			{
				goto IL_052d;
			}
		}
		object obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v71+E4]");
		bool flag6 = (nint)0 == 0;
		object obj16 = !flag6;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence3 = DOTween.Sequence();
		obj5 = sequence3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		s3 = (Sequence)obj5;
		KabbootAnimationProperties properties4 = _properties;
		goto IL_062e;
		IL_052d:
		properties4 = _properties;
		bool flag7 = _properties == null;
		object obj17 = !flag7;
		if (obj17 != null)
		{
			goto IL_062e;
		}
		goto IL_07e6;
		IL_062e:
		float duration2 = properties4.Duration * 1.05360915E+09f;
		TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOScale(titleImage, 1f, duration2);
		Sequence sequence4 = TweenSettingsExtensions.Append(s3, t2);
		Tween t3 = (Tween)obj5;
		bool flag8 = obj5 == null;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			object obj19 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v59+E4]");
			bool flag9 = (nint)0 == 0;
			object obj21 = !flag9;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence5 = DOTween.Sequence();
			obj5 = sequence5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			t3 = (Tween)obj5;
		}
		float duration3 = TweenExtensions.Duration(t3);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(effect, 1f, duration3);
		KabbootAnimationProperties properties5 = _properties;
		object obj22 = (nint)0 + (nint)3000;
		float num7 = properties5.Duration * 1.0502537E+09f;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = ShortcutExtensions.DORotate(effect, (Vector3)1, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059384");
		object obj23 = (nint)0 + (nint)3448;
		object obj24 = (nint)0 + (nint)2512;
		object obj25 = obj5;
		bool flag10 = obj5 == null;
		object obj26 = !flag10;
		Sequence sequence6 = (Sequence)3;
		if (obj26 == null)
		{
			object obj27 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X0_v49+E4]");
			bool flag11 = (nint)0 == 0;
			object obj29 = !flag11;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence7 = DOTween.Sequence();
			obj5 = sequence7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj25 = obj5;
			sequence6 = sequence7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj23);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_07e6:
		throw new NullReferenceException();
		IL_0186:
		properties2 = _properties;
		bool flag12 = _properties == null;
		object obj30 = !flag12;
		if (obj30 != null)
		{
			goto IL_02a2;
		}
		goto IL_07e6;
		IL_02a2:
		object obj31 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj32 = (nint)0 + (nint)3464;
		float duration4 = properties2.Duration * 1.0502537E+09f;
		TweenerCore<Vector3, Vector3, VectorOptions> t4 = ShortcutExtensions.DOScale(titleImage, 1f, duration4);
		Sequence sequence8 = TweenSettingsExtensions.Append(s, t4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback2 = default(TweenCallback);
		tweenCallback2..ctor(this, (IntPtr)obj32);
		Sequence sequence9 = TweenSettingsExtensions.AppendCallback(mainSequence, tweenCallback2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CE2]");
		object obj33 = (nint)0 & (nint)1;
		if (obj33 != null)
		{
			s2 = (Sequence)obj5;
			if (obj5 != null)
			{
				goto IL_0391;
			}
		}
		else
		{
			_ = 1;
			s2 = (Sequence)obj5;
			bool flag13 = obj5 == null;
			object obj34 = !flag13;
			if (obj34 != null)
			{
				goto IL_0391;
			}
		}
		object obj35 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj36 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v83+E4]");
		bool flag14 = (nint)0 == 0;
		object obj37 = !flag14;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence10 = DOTween.Sequence();
		obj5 = sequence10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		s2 = (Sequence)obj5;
		properties3 = _properties;
		goto IL_0492;
	}

	public void ExitWinAnimation()
	{
		//IL_0702: Expected O, but got I4
		//IL_00b0: Expected O, but got I
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0171: Expected O, but got I4
		//IL_012b: Expected O, but got I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_072f: Expected O, but got Unknown
		//IL_0751: Expected O, but got I4
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01c5: Expected O, but got I4
		//IL_07e2: Expected O, but got I
		//IL_027a: Expected O, but got I
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected O, but got Unknown
		//IL_077f: Expected O, but got I
		//IL_0797: Expected I, but got O
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		//IL_031d: Expected O, but got I4
		//IL_02e2: Expected O, but got I4
		//IL_0095: Expected I, but got O
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0369: Expected O, but got I4
		//IL_041a: Expected O, but got I
		//IL_04bd: Expected O, but got I4
		//IL_0482: Expected O, but got I4
		//IL_04da: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected O, but got Unknown
		//IL_0509: Expected O, but got I4
		//IL_05ba: Expected O, but got I
		//IL_05d4: Expected O, but got I4
		//IL_07c8: Expected O, but got I4
		//IL_06a8: Expected O, but got I4
		//IL_06b8: Expected O, but got I
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got Unknown
		//IL_062b: Expected O, but got I4
		//IL_06e3: Expected O, but got I
		object obj = 152993792;
		Sequence s;
		KabbootAnimationProperties properties;
		object obj3;
		if (!animationIsPlaying)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CE2]");
			object obj2 = (nint)0 & (nint)1;
			object obj4;
			if (obj2 != null)
			{
				obj3 = this + 112;
				s = (Sequence)obj3;
				bool flag = obj3 == null;
				obj4 = obj3;
				if (!flag)
				{
					goto IL_0105;
				}
			}
			else
			{
				_ = 1;
				obj3 = this + 112;
				s = (Sequence)obj3;
				bool flag2 = obj3 == null;
				object obj5 = !flag2;
				obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_0105;
				}
			}
			object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v69+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence = DOTween.Sequence();
			obj4 = sequence;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			s = (Sequence)obj4;
			properties = _properties;
			obj3 = obj4;
			goto IL_0221;
		}
		object obj9 = this + 112;
		Sequence sequence2 = (Sequence)obj9;
		bool flag4 = obj9 == null;
		object obj10 = !flag4;
		nint num;
		if (obj10 == null)
		{
			object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v82+E4]");
			bool flag5 = (nint)0 == 0;
			object obj13 = !flag5;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence3 = DOTween.Sequence();
			obj9 = sequence3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			sequence2 = (Sequence)obj9;
			num = (nint)sequence3;
		}
		object obj14 = (nint)0 + (nint)3432;
		goto IL_075f;
		IL_045c:
		KabbootAnimationProperties properties2 = _properties;
		bool flag6 = _properties == null;
		object obj15 = !flag6;
		if (obj15 != null)
		{
			goto IL_055d;
		}
		goto IL_06f2;
		IL_075f:
		object obj16 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj17 = (nint)0 + (nint)2512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_02bc:
		KabbootAnimationProperties properties3 = _properties;
		bool flag7 = _properties == null;
		object obj18 = !flag7;
		if (obj18 != null)
		{
			goto IL_03bd;
		}
		goto IL_06f2;
		IL_03bd:
		float duration = properties3.Duration * 1.0502537E+09f;
		TweenerCore<Vector3, Vector3, VectorOptions> t = ShortcutExtensions.DOScale(titleImage, 1f, duration);
		Sequence s2;
		Sequence sequence4 = TweenSettingsExtensions.Append(s2, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X22_v1+CE2]");
		object obj19 = (nint)0 & (nint)1;
		Sequence s3;
		if (obj19 != null)
		{
			s3 = (Sequence)obj3;
			if (obj3 != null)
			{
				goto IL_045c;
			}
		}
		else
		{
			_ = 1;
			s3 = (Sequence)obj3;
			bool flag8 = obj3 == null;
			object obj20 = !flag8;
			if (obj20 != null)
			{
				goto IL_045c;
			}
		}
		object obj21 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X0_v45+E4]");
		bool flag9 = (nint)0 == 0;
		object obj23 = !flag9;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence5 = DOTween.Sequence();
		obj3 = sequence5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		s3 = (Sequence)obj3;
		properties2 = _properties;
		goto IL_055d;
		IL_06f2:
		throw new NullReferenceException();
		IL_055d:
		float duration2 = properties2.Duration * 1.04522054E+09f;
		TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOScale(titleImage, 10f, duration2);
		Sequence sequence6 = TweenSettingsExtensions.Append(s3, t2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X22_v1+CE2]");
		object obj24 = (nint)0 & (nint)1;
		bool flag10 = obj24 == null;
		object obj25 = !flag10;
		if (obj25 == null)
		{
			_ = 1;
		}
		Tween t3 = (Tween)obj3;
		bool flag11 = obj3 == null;
		object obj26 = !flag11;
		if (obj26 == null)
		{
			object obj27 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v33+E4]");
			bool flag12 = (nint)0 == 0;
			object obj29 = !flag12;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence7 = DOTween.Sequence();
			obj3 = sequence7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			t3 = (Tween)obj3;
		}
		float duration3 = TweenExtensions.Duration(t3);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(effect, 2f, duration3);
		KabbootAnimationProperties properties4 = _properties;
		double num2 = (double)properties4.Duration * 0.25;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = ShortcutExtensions.DORotate(effect, (Vector3)1, 0f);
		object obj30 = (nint)0 + (nint)3000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059384");
		PlayCardSequenceBackwards();
		sequence2 = mainSequence;
		obj14 = (nint)0 + (nint)3456;
		num = 3;
		goto IL_075f;
		IL_0105:
		properties = _properties;
		bool flag13 = _properties == null;
		object obj31 = !flag13;
		if (obj31 != null)
		{
			goto IL_0221;
		}
		goto IL_06f2;
		IL_0221:
		float duration4 = properties.Duration * 1.0502537E+09f;
		TweenerCore<Vector3, Vector3, VectorOptions> t4 = ShortcutExtensions.DOScale(titleImage, 1.3f, duration4);
		Sequence sequence8 = TweenSettingsExtensions.Append(s, t4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X22_v1+CE2]");
		object obj32 = (nint)0 & (nint)1;
		if (obj32 != null)
		{
			s2 = (Sequence)obj3;
			if (obj3 != null)
			{
				goto IL_02bc;
			}
		}
		else
		{
			_ = 1;
			s2 = (Sequence)obj3;
			bool flag14 = obj3 == null;
			object obj33 = !flag14;
			if (obj33 != null)
			{
				goto IL_02bc;
			}
		}
		object obj34 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj35 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v57+E4]");
		bool flag15 = (nint)0 == 0;
		object obj36 = !flag15;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence9 = DOTween.Sequence();
		obj3 = sequence9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		s2 = (Sequence)obj3;
		properties3 = _properties;
		goto IL_03bd;
	}

	public void ShowLoseAnimation()
	{
		//IL_00b6: Expected O, but got I4
		//IL_010a: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		//IL_0176: Expected O, but got I
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0237: Expected O, but got I4
		//IL_01f1: Expected O, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_028b: Expected O, but got I4
		//IL_092e: Expected O, but got I4
		//IL_09e4: Expected O, but got I
		//IL_0441: Expected O, but got I4
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0371: Expected O, but got I4
		//IL_0406: Expected O, but got I4
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_048d: Expected O, but got I4
		//IL_053a: Expected O, but got I
		//IL_05dd: Expected O, but got I4
		//IL_05a2: Expected O, but got I4
		//IL_06ab: Expected O, but got I4
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected O, but got Unknown
		//IL_0629: Expected O, but got I4
		//IL_06db: Expected O, but got I
		//IL_0831: Expected O, but got I4
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Expected O, but got Unknown
		//IL_087d: Expected O, but got I4
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Expected O, but got Unknown
		//IL_095c: Expected O, but got I
		//IL_0968: Expected O, but got I
		//IL_098a: Expected O, but got I4
		//IL_08e8: Expected O, but got I4
		//IL_0a19: Expected I, but got O
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_078c: Expected O, but got Unknown
		//IL_07b6: Expected O, but got I4
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		SetImagesToLose();
		HideCards();
		GameObject gameObject2 = onYou.gameObject;
		gameObject2.SetActive(value: true);
		animationIsPlaying = true;
		Vector3 localScale = titleImage.localScale;
		object obj = default(object);
		double num = (double)obj * 10.0;
		object obj2 = default(object);
		double num2 = (double)obj2 * 10.0;
		object obj3 = default(object);
		double num3 = (double)obj3 * 10.0;
		titleImage.localScale = (Vector3)0;
		Vector3 localScale2 = effect.localScale;
		double num4 = num * 1028443341.0;
		double num5 = num2 * 1028443341.0;
		double num6 = num3 * 1028443341.0;
		effect.localScale = (Vector3)0;
		Vector2 anchoredPosition = onYou.anchoredPosition;
		Vector2 anchoredPosition2 = onYou.anchoredPosition;
		double num7 = num4 + 1148846080.0;
		onYou.anchoredPosition = (Vector2)0;
		object obj4 = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CE2]");
		object obj5 = (nint)0 & (nint)1;
		Sequence s;
		object obj7;
		object obj6;
		if (obj5 != null)
		{
			obj6 = this + 112;
			s = (Sequence)obj6;
			bool flag = obj6 == null;
			obj7 = obj6;
			if (!flag)
			{
				goto IL_01cb;
			}
		}
		else
		{
			_ = 1;
			obj6 = this + 112;
			s = (Sequence)obj6;
			bool flag2 = obj6 == null;
			object obj8 = !flag2;
			obj7 = obj6;
			if (obj8 != null)
			{
				goto IL_01cb;
			}
		}
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v110+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		obj7 = sequence;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		s = (Sequence)obj7;
		KabbootAnimationProperties properties = _properties;
		obj6 = obj7;
		goto IL_02e7;
		IL_057c:
		KabbootAnimationProperties properties2 = _properties;
		bool flag4 = _properties == null;
		object obj12 = !flag4;
		if (obj12 != null)
		{
			goto IL_067d;
		}
		goto IL_08f6;
		IL_072c:
		KabbootAnimationProperties properties3;
		float duration = properties3.Duration * 1.05360915E+09f;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(titleImage, 1f, duration);
		Sequence s2;
		Sequence sequence2 = TweenSettingsExtensions.Append(s2, tweenerCore);
		object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj14 = (nint)0 + (nint)3440;
		object obj15 = (nint)0 + (nint)2512;
		object obj16 = obj6;
		bool flag5 = obj6 == null;
		object obj17 = !flag5;
		Tween tween = tweenerCore;
		if (obj17 == null)
		{
			object obj18 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v64+E4]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence3 = DOTween.Sequence();
			obj6 = sequence3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj16 = obj6;
			tween = sequence3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_03e0:
		KabbootAnimationProperties properties4 = _properties;
		bool flag7 = _properties == null;
		object obj21 = !flag7;
		if (obj21 != null)
		{
			goto IL_04e1;
		}
		goto IL_08f6;
		IL_071d:
		properties3 = _properties;
		goto IL_072c;
		IL_067d:
		float num8 = properties2.Duration * 1.0502537E+09f;
		TweenerCore<Vector2, Vector2, VectorOptions> t = DOTweenModuleUI.DOAnchorPos(onYou, (Vector2)0, (float)num4);
		Sequence s3;
		Sequence sequence4 = TweenSettingsExtensions.Join(s3, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CE2]");
		object obj22 = (nint)0 & (nint)1;
		if (obj22 != null)
		{
			s2 = (Sequence)obj6;
			if (obj6 != null)
			{
				goto IL_071d;
			}
		}
		else
		{
			_ = 1;
			s2 = (Sequence)obj6;
			bool flag8 = obj6 == null;
			object obj23 = !flag8;
			if (obj23 != null)
			{
				goto IL_071d;
			}
		}
		object obj24 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v43+E4]");
		bool flag9 = (nint)0 == 0;
		object obj26 = !flag9;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence5 = DOTween.Sequence();
		obj6 = sequence5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		s2 = (Sequence)obj6;
		properties3 = _properties;
		bool flag10 = _properties == null;
		object obj27 = !flag10;
		if (obj27 != null)
		{
			goto IL_072c;
		}
		goto IL_08f6;
		IL_01cb:
		properties = _properties;
		bool flag11 = _properties == null;
		object obj28 = !flag11;
		if (obj28 != null)
		{
			goto IL_02e7;
		}
		goto IL_08f6;
		IL_02e7:
		float duration2 = properties.Duration * 1.0502537E+09f;
		TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOScale(titleImage, 1f, duration2);
		Sequence sequence6 = TweenSettingsExtensions.Append(s, t2);
		Sequence s4 = (Sequence)obj6;
		bool flag12 = obj6 == null;
		object obj29 = !flag12;
		if (obj29 == null)
		{
			object obj30 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj31 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X0_v99+E4]");
			bool flag13 = (nint)0 == 0;
			object obj32 = !flag13;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence7 = DOTween.Sequence();
			obj6 = sequence7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			s4 = (Sequence)obj6;
		}
		TweenerCore<Vector3, Vector3, VectorOptions> t3 = ShortcutExtensions.DOScale(effect, 1f, 0.05f);
		Sequence sequence8 = TweenSettingsExtensions.Append(s4, t3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CE2]");
		object obj33 = (nint)0 & (nint)1;
		Sequence s5;
		if (obj33 != null)
		{
			s5 = (Sequence)obj6;
			if (obj6 != null)
			{
				goto IL_03e0;
			}
		}
		else
		{
			_ = 1;
			s5 = (Sequence)obj6;
			bool flag14 = obj6 == null;
			object obj34 = !flag14;
			if (obj34 != null)
			{
				goto IL_03e0;
			}
		}
		object obj35 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj36 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v88+E4]");
		bool flag15 = (nint)0 == 0;
		object obj37 = !flag15;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence9 = DOTween.Sequence();
		obj6 = sequence9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		s5 = (Sequence)obj6;
		properties4 = _properties;
		goto IL_04e1;
		IL_08f6:
		throw new NullReferenceException();
		IL_04e1:
		float duration3 = properties4.Duration * 1.0502537E+09f;
		TweenerCore<Vector3, Vector3, VectorOptions> t4 = ShortcutExtensions.DOScale(titleImage, 1.3f, duration3);
		Sequence sequence10 = TweenSettingsExtensions.Append(s5, t4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CE2]");
		object obj38 = (nint)0 & (nint)1;
		if (obj38 != null)
		{
			s3 = (Sequence)obj6;
			if (obj6 != null)
			{
				goto IL_057c;
			}
		}
		else
		{
			_ = 1;
			s3 = (Sequence)obj6;
			bool flag16 = obj6 == null;
			object obj39 = !flag16;
			if (obj39 != null)
			{
				goto IL_057c;
			}
		}
		object obj40 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj41 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X0_v76+E4]");
		bool flag17 = (nint)0 == 0;
		object obj42 = !flag17;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence11 = DOTween.Sequence();
		obj6 = sequence11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		s3 = (Sequence)obj6;
		properties2 = _properties;
		goto IL_067d;
	}

	public void ExitLoseAnimation()
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected O, but got Unknown
		//IL_08d4: Expected O, but got I4
		//IL_0970: Expected O, but got I
		//IL_0132: Expected O, but got I4
		//IL_0148: Expected O, but got I
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f6: Expected O, but got Unknown
		//IL_0902: Expected O, but got I
		//IL_091d: Expected I, but got O
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0048: Expected O, but got I4
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_0209: Expected O, but got I4
		//IL_01c3: Expected O, but got I4
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0095: Expected I, but got O
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_025d: Expected O, but got I4
		//IL_0312: Expected O, but got I
		//IL_03b5: Expected O, but got I4
		//IL_037a: Expected O, but got I4
		//IL_0493: Expected O, but got I4
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_0401: Expected O, but got I4
		//IL_04c3: Expected O, but got I
		//IL_0566: Expected O, but got I4
		//IL_052b: Expected O, but got I4
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		//IL_05b2: Expected O, but got I4
		//IL_0663: Expected O, but got I
		//IL_07b9: Expected O, but got I4
		//IL_07d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Expected O, but got Unknown
		//IL_0805: Expected O, but got I4
		//IL_094e: Expected O, but got I4
		//IL_0956: Expected I, but got O
		//IL_0870: Expected O, but got I4
		//IL_0986: Expected O, but got I
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0714: Expected O, but got Unknown
		//IL_073e: Expected O, but got I4
		//IL_078b: Expected I, but got O
		object obj2 = default(object);
		Sequence s;
		KabbootAnimationProperties properties;
		object obj6;
		if (!animationIsPlaying)
		{
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1320;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			object obj3 = obj2 + 24;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Vector2 anchoredPosition = onYou.anchoredPosition;
			Vector2 anchoredPosition2 = onYou.anchoredPosition;
			Vector2 anchoredPosition3 = onYou.anchoredPosition;
			object obj4 = 152993792;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CE2]");
			object obj5 = (nint)0 & (nint)1;
			object obj7;
			if (obj5 != null)
			{
				obj6 = this + 112;
				s = (Sequence)obj6;
				bool flag = obj6 == null;
				obj7 = obj6;
				if (!flag)
				{
					goto IL_019d;
				}
			}
			else
			{
				_ = 1;
				obj6 = this + 112;
				s = (Sequence)obj6;
				bool flag2 = obj6 == null;
				object obj8 = !flag2;
				obj7 = obj6;
				if (obj8 != null)
				{
					goto IL_019d;
				}
			}
			object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v89+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence = DOTween.Sequence();
			obj7 = sequence;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			s = (Sequence)obj7;
			properties = _properties;
			obj6 = obj7;
			goto IL_02b9;
		}
		object obj12 = this + 112;
		object obj13 = obj12;
		bool flag4 = obj12 == null;
		object obj14 = !flag4;
		nint num;
		if (obj14 == null)
		{
			object obj15 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v102+E4]");
			bool flag5 = (nint)0 == 0;
			object obj17 = !flag5;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence2 = DOTween.Sequence();
			obj12 = sequence2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj13 = obj12;
			num = (nint)sequence2;
		}
		object obj18 = (nint)0 + (nint)3424;
		KabbootAnimationPanel kabbootAnimationPanel = this;
		goto IL_08e2;
		IL_0354:
		KabbootAnimationProperties properties2 = _properties;
		bool flag6 = _properties == null;
		object obj19 = !flag6;
		if (obj19 != null)
		{
			goto IL_0455;
		}
		goto IL_087e;
		IL_08e2:
		object obj20 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj21 = (nint)0 + (nint)2512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(kabbootAnimationPanel, (IntPtr)obj18);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_0606:
		KabbootAnimationProperties properties3;
		float duration = properties3.Duration * 1.0502537E+09f;
		TweenerCore<Vector3, Vector3, VectorOptions> t = ShortcutExtensions.DOScale(titleImage, 1f, duration);
		Sequence s2;
		Sequence sequence3 = TweenSettingsExtensions.Append(s2, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CE2]");
		object obj22 = (nint)0 & (nint)1;
		Sequence s3;
		if (obj22 != null)
		{
			s3 = (Sequence)obj6;
			if (obj6 != null)
			{
				goto IL_06a5;
			}
		}
		else
		{
			_ = 1;
			s3 = (Sequence)obj6;
			bool flag7 = obj6 == null;
			object obj23 = !flag7;
			if (obj23 != null)
			{
				goto IL_06a5;
			}
		}
		object obj24 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v36+E4]");
		bool flag8 = (nint)0 == 0;
		object obj26 = !flag8;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence4 = DOTween.Sequence();
		obj6 = sequence4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		s3 = (Sequence)obj6;
		KabbootAnimationProperties properties4 = _properties;
		bool flag9 = _properties == null;
		object obj27 = !flag9;
		if (obj27 != null)
		{
			goto IL_06b4;
		}
		goto IL_087e;
		IL_06a5:
		properties4 = _properties;
		goto IL_06b4;
		IL_0505:
		properties3 = _properties;
		bool flag10 = _properties == null;
		object obj28 = !flag10;
		if (obj28 != null)
		{
			goto IL_0606;
		}
		goto IL_087e;
		IL_0455:
		double num2 = default(double);
		float duration2 = (float)num2 + 1.1488461E+09f;
		float num3 = properties2.Duration * 1.0502537E+09f;
		TweenerCore<Vector2, Vector2, VectorOptions> t2 = DOTweenModuleUI.DOAnchorPos(onYou, (Vector2)0, duration2);
		Sequence s4;
		Sequence sequence5 = TweenSettingsExtensions.Join(s4, t2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CE2]");
		object obj29 = (nint)0 & (nint)1;
		if (obj29 != null)
		{
			s2 = (Sequence)obj6;
			if (obj6 != null)
			{
				goto IL_0505;
			}
		}
		else
		{
			_ = 1;
			s2 = (Sequence)obj6;
			bool flag11 = obj6 == null;
			object obj30 = !flag11;
			if (obj30 != null)
			{
				goto IL_0505;
			}
		}
		object obj31 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj32 = obj31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v65+E4]");
		bool flag12 = (nint)0 == 0;
		object obj33 = !flag12;
		if (obj33 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence6 = DOTween.Sequence();
		obj6 = sequence6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		s2 = (Sequence)obj6;
		properties3 = _properties;
		goto IL_0606;
		IL_019d:
		properties = _properties;
		bool flag13 = _properties == null;
		object obj34 = !flag13;
		if (obj34 != null)
		{
			goto IL_02b9;
		}
		goto IL_087e;
		IL_02b9:
		float duration3 = properties.Duration * 1.0502537E+09f;
		TweenerCore<Vector3, Vector3, VectorOptions> t3 = ShortcutExtensions.DOScale(titleImage, 1.3f, duration3);
		Sequence sequence7 = TweenSettingsExtensions.Append(s, t3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CE2]");
		object obj35 = (nint)0 & (nint)1;
		if (obj35 != null)
		{
			s4 = (Sequence)obj6;
			if (obj6 != null)
			{
				goto IL_0354;
			}
		}
		else
		{
			_ = 1;
			s4 = (Sequence)obj6;
			bool flag14 = obj6 == null;
			object obj36 = !flag14;
			if (obj36 != null)
			{
				goto IL_0354;
			}
		}
		object obj37 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj38 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v77+E4]");
		bool flag15 = (nint)0 == 0;
		object obj39 = !flag15;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence8 = DOTween.Sequence();
		obj6 = sequence8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		s4 = (Sequence)obj6;
		properties2 = _properties;
		goto IL_0455;
		IL_06b4:
		float duration4 = properties4.Duration * 1.04522054E+09f;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(titleImage, 10f, duration4);
		Sequence sequence9 = TweenSettingsExtensions.Append(s3, tweenerCore);
		obj13 = obj6;
		bool flag16 = obj6 == null;
		object obj40 = !flag16;
		num = (nint)tweenerCore;
		if (obj40 == null)
		{
			object obj41 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj42 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X0_v53+E4]");
			bool flag17 = (nint)0 == 0;
			object obj43 = !flag17;
			if (obj43 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence10 = DOTween.Sequence();
			obj6 = sequence10;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj13 = obj6;
			num = (nint)sequence10;
		}
		obj18 = (nint)0 + (nint)3224;
		kabbootAnimationPanel = (KabbootAnimationPanel)obj2;
		goto IL_08e2;
		IL_087e:
		throw new NullReferenceException();
	}

	private void PlayCardSequence()
	{
		//IL_043b: Expected O, but got I4
		//IL_001f: Expected O, but got I4
		//IL_003a: Expected O, but got I
		//IL_0046: Expected O, but got I
		//IL_03b1: Expected I, but got O
		//IL_045f: Expected I, but got O
		//IL_030c: Expected F4, but got O
		//IL_0363: Expected O, but got I4
		//IL_011d: Expected O, but got I4
		//IL_0323: Expected F8, but got I4
		//IL_0328: Expected I, but got O
		//IL_015d: Expected O, but got I4
		//IL_02d5: Expected F8, but got I4
		//IL_02da: Expected I, but got O
		//IL_019e: Expected O, but got I4
		//IL_02f1: Expected F8, but got I4
		//IL_02f6: Expected I, but got O
		//IL_01df: Expected O, but got I4
		//IL_01fb: Expected F4, but got O
		//IL_01fb: Expected O, but got I4
		//IL_0216: Expected F4, but got O
		//IL_0216: Expected O, but got I4
		//IL_0236: Expected O, but got I4
		//IL_034c: Expected I, but got O
		//IL_0287: Expected O, but got F4
		ShowCards();
		KabbootAnimationProperties properties = _properties;
		bool flag = _properties == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		object obj2 = default(object);
		nint num3 = default(nint);
		if (!flag)
		{
			bool flag2 = cards == null;
			enumerator = (List<object>.Enumerator)0;
			if (!flag2)
			{
				object obj = (nint)0 + (nint)552;
				obj2 = (nint)0 + (nint)544;
				double num = (double)properties.Duration * 0.5;
				List<object>.Enumerator enumerator2 = ((List<object>)(object)cards).GetEnumerator();
				double num2 = 0.5;
				List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
				List<object>.Enumerator enumerator3 = enumerator4;
				List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
				RectTransform rectTransform = default(RectTransform);
				Quaternion rotation2 = default(Quaternion);
				double num4 = default(double);
				while (true)
				{
					num3 = (nint)obj;
					if (enumerator5.MoveNext())
					{
						float duration;
						if ((object)rectTransform != null)
						{
							Vector2 anchoredPosition = rectTransform.anchoredPosition;
							Vector2 sizeDelta = rectTransform.sizeDelta;
							Quaternion rotation = rectTransform.rotation;
							Vector3 vector = Quaternion.Internal_ToEulerRad(ref rotation2);
							duration = (float)enumerator3 * 1.1139274E+09f;
							num2 *= 1113927393.0;
							num4 *= 1113927393.0;
							Vector3 vector2 = Quaternion.Internal_MakePositive((Vector3)0);
							double num6;
							if ((object)cardPosIndx != null)
							{
								Vector2 anchoredPosition2 = cardPosIndx.anchoredPosition;
								rectTransform.anchoredPosition = (Vector2)0;
								if ((object)cardPosIndx != null)
								{
									Vector2 sizeDelta2 = cardPosIndx.sizeDelta;
									rectTransform.sizeDelta = (Vector2)0;
									if ((object)cardPosIndx != null)
									{
										Quaternion localRotation = cardPosIndx.localRotation;
										rectTransform.localRotation = (Quaternion)0;
										TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos(rectTransform, (Vector2)0, (float)enumerator3);
										TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOSizeDelta(rectTransform, (Vector2)0, (float)enumerator3);
										TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore3 = ShortcutExtensions.DORotate(rectTransform, (Vector3)0, duration);
										KabbootAnimationProperties properties2 = _properties;
										RotateMode rotateMode;
										if (_properties != null)
										{
											num2 = properties2.Duration;
											enumerator3 = (List<object>.Enumerator)(properties2.TimeDifferenceBetweenCards * properties2.Duration);
											double num5 = num + (double)enumerator3;
											rotateMode = RotateMode.Fast;
											num6 = num;
											num = num5;
											continue;
										}
										NullReferenceException ex = new NullReferenceException();
										rotateMode = RotateMode.Fast;
										num6 = num;
										num3 = unchecked((nint)null);
										break;
									}
									NullReferenceException ex2 = new NullReferenceException();
									num6 = 1113927393.0;
									num3 = unchecked((nint)null);
									break;
								}
								NullReferenceException ex3 = new NullReferenceException();
								num6 = 1113927393.0;
								num3 = unchecked((nint)null);
								break;
							}
							NullReferenceException ex4 = new NullReferenceException();
							num6 = 1113927393.0;
							num3 = unchecked((nint)null);
							break;
						}
						NullReferenceException ex5 = new NullReferenceException();
						duration = (float)enumerator3;
						break;
					}
					enumerator5.Dispose();
					return;
				}
				enumerator = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
			}
		}
		NullReferenceException ex6 = new NullReferenceException();
		bool flag3 = num3 != 1;
		OutOfMemoryException ex7 = (OutOfMemoryException)(object)ex6;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num3 = (nint)obj2;
			enumerator.Dispose();
			object obj3 = default(object);
			if (obj3 == null)
			{
				return;
			}
			ex7 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237EAC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void PlayCardSequenceBackwards()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_08c6: Expected O, but got I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00ac: Expected O, but got I4
		//IL_0833: Expected O, but got I
		//IL_00dc: Expected O, but got I4
		//IL_00ff: Expected O, but got I
		//IL_010b: Expected O, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_014c: Expected F4, but got I4
		//IL_0154: Expected F4, but got O
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_07e1: Expected O, but got I4
		//IL_0254: Expected O, but got I
		//IL_02d0: Expected O, but got I4
		//IL_0352: Expected O, but got I
		//IL_0362: Expected O, but got I
		//IL_0372: Expected O, but got I
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_03ca: Expected O, but got I4
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0435: Expected O, but got I4
		//IL_0777: Expected O, but got I4
		//IL_0494: Expected O, but got I4
		//IL_07ac: Expected O, but got I4
		//IL_0528: Expected O, but got I4
		//IL_0543: Expected O, but got I4
		//IL_059b: Expected O, but got I4
		//IL_05e1: Expected O, but got I4
		//IL_0607: Expected O, but got I
		//IL_0629: Expected O, but got I4
		//IL_06ad: Expected O, but got I
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_0661: Expected O, but got I
		//IL_0672: Expected I, but got O
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		Tween tween = null;
		if (!flag)
		{
			object obj3 = typeof(List<Tween>) + 992;
			object obj4 = obj2 + 16;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			object obj5 = obj2 + 24;
			obj5 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			KabbootAnimationProperties properties = _properties;
			bool flag2 = _properties == null;
			enumerator = (List<object>.Enumerator)0;
			tween = (Tween)(object)list;
			if (!flag2)
			{
				bool flag3 = cards == null;
				enumerator = (List<object>.Enumerator)0;
				tween = (Tween)(object)list;
				if (!flag3)
				{
					object obj6 = (nint)0 + (nint)552;
					object obj7 = (nint)0 + (nint)4080;
					object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
					float num = properties.Duration * 1.06451437E+09f;
					List<object>.Enumerator enumerator2 = ((List<object>)(object)cards).GetEnumerator();
					float num2 = 1.06451437E+09f;
					List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
					float num3 = (float)enumerator3;
					List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
					object obj10 = default(object);
					RectTransform rectTransform = default(RectTransform);
					Quaternion rotation3 = default(Quaternion);
					TweenCallback tweenCallback2 = default(TweenCallback);
					while (true)
					{
						if (enumerator4.MoveNext())
						{
							List<object> list2 = (List<object>)obj5;
							object obj9 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1336;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							obj10..ctor();
							object obj11 = obj10 + 16;
							obj11 = rectTransform;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							bool flag4 = (object)rectTransform == null;
							tween = (Tween)(object)rectTransform;
							if (!flag4)
							{
								Vector2 anchoredPosition = rectTransform.anchoredPosition;
								Vector2 sizeDelta = rectTransform.sizeDelta;
								Quaternion rotation = rectTransform.rotation;
								bool flag5 = obj5 == null;
								tween = null;
								if (!flag5)
								{
									object obj12 = (nint)0 + (nint)3008;
									object obj13 = obj12;
									int version = list2._version + 1;
									list2._version = version;
									object[] items = list2._items;
									bool flag6 = list2._items == null;
									tween = null;
									if (!flag6)
									{
										bool flag7 = list2._size < items.Length;
										object obj14 = !flag7;
										if (obj14 == null)
										{
											int size = list2._size + 1;
											list2._size = size;
											object obj15 = list2._items + list2._size;
											object obj16 = obj15 + 32;
											obj16 = obj10;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											tween = (Tween)obj10;
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v23+20]");
											object obj17 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v38+C0]");
											object obj18 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v39+70]");
											object obj19 = 0;
											((List<object>)obj5).AddWithResize(obj10);
											tween = (Tween)obj10;
										}
										object obj20 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
										object obj21 = obj20;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v46+E4]");
										bool flag8 = (nint)0 == 0;
										object obj22 = !flag8;
										if (obj22 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										Sequence s = DOTween.Sequence();
										if ((object)cardPosIndx != null)
										{
											Vector2 anchoredPosition2 = cardPosIndx.anchoredPosition;
											TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos(rectTransform, (Vector2)0, num3);
											Sequence sequence = TweenSettingsExtensions.Append(s, tweenerCore);
											float num4;
											object obj19;
											if ((object)cardPosIndx != null)
											{
												Vector2 sizeDelta2 = cardPosIndx.sizeDelta;
												TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOSizeDelta(rectTransform, (Vector2)0, num3);
												Sequence sequence2 = TweenSettingsExtensions.Join(s, tweenerCore2);
												if ((object)cardPosIndx != null)
												{
													Quaternion rotation2 = cardPosIndx.rotation;
													Vector3 vector = Quaternion.Internal_ToEulerRad(ref rotation3);
													num3 *= 1.1139274E+09f;
													num2 *= 1.1139274E+09f;
													num4 = num * 1.1139274E+09f;
													Vector3 vector2 = Quaternion.Internal_MakePositive((Vector3)0);
													TweenerCore<Quaternion, Vector3, QuaternionOptions> t = ShortcutExtensions.DORotate(rectTransform, (Vector3)0, num3);
													Sequence sequence3 = TweenSettingsExtensions.Join(s, t);
													object obj23 = Enumerable.First((IEnumerable<object>)cards);
													object obj24 = obj8;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v77+E4]");
													bool flag9 = (nint)0 == 0;
													object obj25 = !flag9;
													if (obj25 == null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
													}
													bool flag10 = rectTransform == (UnityEngine.Object)obj23;
													bool flag11 = !flag10;
													obj19 = 0;
													tween = (Tween)obj23;
													if (!flag11)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3 (System.Object)+20]");
														TweenCallback tweenCallback = (TweenCallback)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3 (System.Object)+20]");
														bool flag12 = (nint)0 == 0;
														object obj26 = !flag12;
														if (obj26 == null)
														{
															object obj27 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
															object obj28 = (nint)0 + (nint)3232;
															tweenCallback2..ctor(obj2, (IntPtr)obj28);
															object obj29 = obj2 + 32;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															tweenCallback = tweenCallback2;
														}
														object obj30 = (nint)0 + (nint)2512;
														obj19 = obj30;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
														tween = (Tween)(object)tweenCallback;
													}
													KabbootAnimationProperties properties2 = _properties;
													float num6;
													if (_properties != null)
													{
														num2 = properties2.Duration;
														num3 = properties2.TimeDifferenceBetweenCards * properties2.Duration;
														float num5 = num - num3;
														num6 = num;
														num = num5;
														continue;
													}
													NullReferenceException ex = new NullReferenceException();
													num6 = num;
													break;
												}
												NullReferenceException ex2 = new NullReferenceException();
												num4 = num;
												obj19 = 0;
												tween = tweenerCore2;
												break;
											}
											NullReferenceException ex3 = new NullReferenceException();
											num4 = num;
											obj19 = 0;
											tween = tweenerCore;
											break;
										}
										NullReferenceException ex4 = new NullReferenceException();
										break;
									}
								}
							}
							NullReferenceException ex5 = new NullReferenceException();
							break;
						}
						enumerator4.Dispose();
						return;
					}
					enumerator = enumerator3;
					enumerator3 = (List<object>.Enumerator)0;
				}
			}
		}
		NullReferenceException ex6 = new NullReferenceException();
		bool flag13 = (nint)tween != 1;
		OutOfMemoryException ex7 = (OutOfMemoryException)(object)ex6;
		if (!flag13)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj31 = (nint)0 + (nint)544;
			tween = (Tween)obj31;
			enumerator.Dispose();
			object obj32 = default(object);
			if (obj32 == null)
			{
				return;
			}
			ex7 = new OutOfMemoryException();
			List<object>.Enumerator enumerator3 = (List<object>.Enumerator)obj32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237EAC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void ExitAnimationDone()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		object obj = this + 112;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	private void SetImagesToWin()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Image image = default(Image);
		image.sprite = title_Win;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Image image2 = default(Image);
		image2.sprite = halo_Win;
	}

	private void SetImagesToLose()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)3872;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Image image = default(Image);
		image.sprite = title_Lose;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Image image2 = default(Image);
		image2.sprite = halo_Lose;
	}

	private void HideLoseImages()
	{
		GameObject gameObject = onYou.gameObject;
		gameObject.SetActive(value: false);
	}

	private void HideCards()
	{
		//IL_0012: Expected O, but got I
		//IL_0181: Expected I, but got O
		//IL_00f2: Expected O, but got I
		//IL_00fa: Expected I, but got O
		//IL_00a0: Expected O, but got I4
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (cards != null)
		{
			object obj = (nint)0 + (nint)552;
			List<object>.Enumerator enumerator = ((List<object>)(object)cards).GetEnumerator();
			num = (nint)obj;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj2 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag = num != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj3 = (nint)0 + (nint)544;
			num = (nint)obj3;
			enumerator2.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			ex3 = new OutOfMemoryException();
			object obj2 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237EAC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void ShowCards()
	{
		//IL_0012: Expected O, but got I
		//IL_0181: Expected I, but got O
		//IL_00f2: Expected O, but got I
		//IL_00fa: Expected I, but got O
		//IL_00a0: Expected O, but got I4
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (cards != null)
		{
			object obj = (nint)0 + (nint)552;
			List<object>.Enumerator enumerator = ((List<object>)(object)cards).GetEnumerator();
			num = (nint)obj;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj2 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag = num != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj3 = (nint)0 + (nint)544;
			num = (nint)obj3;
			enumerator2.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			ex3 = new OutOfMemoryException();
			object obj2 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237EAC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void ReturnCardsToOriginalState(List<CardOriginals> origins)
	{
		//IL_010d: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_0062: Expected O, but got I4
		List<CardOriginals> list = default(List<CardOriginals>);
		bool flag = list == null;
		object obj = 152993792;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag)
		{
			object obj2 = (nint)0 + (nint)32;
			obj = (nint)0 + (nint)24;
			List<object>.Enumerator enumerator = ((List<object>)(object)list).GetEnumerator();
			list = (List<CardOriginals>)obj2;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj3 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = (nint)list != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			list = (List<CardOriginals>)obj;
			enumerator2.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj3 = obj4;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223EDF8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void ShowLoseItems()
	{
		HideCards();
		GameObject gameObject = onYou.gameObject;
		gameObject.SetActive(value: true);
	}

	private void ShowPanel()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
	}

	private void HidePanel()
	{
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: false);
	}

	private float GetSegmentDuration(float percentage)
	{
		KabbootAnimationProperties properties = _properties;
		return percentage * properties.Duration;
	}

	private void <ShowWinAnimation>b__15_0()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		object obj = this + 112;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
	}

	private void <ExitWinAnimation>b__16_0()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		object obj = this + 112;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		animationIsPlaying = false;
		ExitWinAnimation();
	}

	private void <ShowLoseAnimation>b__17_0()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		object obj = this + 112;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
	}

	private void <ExitLoseAnimation>b__18_0()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		object obj = this + 112;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		animationIsPlaying = false;
		ExitWinAnimation();
	}
}
