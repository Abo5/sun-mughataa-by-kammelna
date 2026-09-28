using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class CircularProgress : MonoBehaviour
{
	private Image fill;

	private Image head;

	private Image perfectStar;

	private TextMeshProUGUI lastWeekPoints;

	private TextMeshProUGUI thisWeekPoints;

	private Image negativeHead;

	private bool usePercentage;

	private bool startFromZero = true;

	private RotateMode rotateMode = RotateMode.FastBeyond360;

	private float MaxProgress;

	private float CurrentProgress;

	public float phase1Time;

	public Color Positive;

	public Color Negative;

	private void OnEnable()
	{
		StartAnimating();
	}

	public void Initialize(float maxProgress, float currentProgress)
	{
		MaxProgress = maxProgress;
		CurrentProgress = currentProgress;
		StartAnimating();
	}

	private void StartAnimating()
	{
		//IL_0016: Expected O, but got I
		//IL_008c: Expected O, but got I4
		//IL_00e6: Invalid comparison between F8 and I4
		//IL_00f5: Invalid comparison between F8 and I4
		//IL_010f: Expected O, but got F8
		//IL_011e: Expected O, but got F8
		//IL_0153: Expected O, but got I4
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_02a8: Invalid comparison between F4 and I4
		//IL_02db: Expected I4, but got F4
		//IL_09e4: Invalid comparison between F4 and I4
		//IL_09f5: Expected O, but got I4
		//IL_0a00: Invalid comparison between F4 and I4
		//IL_0a11: Expected O, but got I4
		//IL_02cc: Expected I4, but got I8
		//IL_02fb: Invalid comparison between F4 and I4
		//IL_030c: Expected O, but got I4
		//IL_0327: Invalid comparison between F4 and I4
		//IL_0336: Invalid comparison between F4 and I4
		//IL_0356: Expected O, but got I4
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_038a: Expected O, but got I4
		//IL_0a40: Expected O, but got I4
		//IL_0b09: Expected O, but got I4
		//IL_0278: Expected O, but got I4
		//IL_0b2b: Expected O, but got I4
		//IL_0b4d: Expected O, but got I4
		//IL_0b71: Expected O, but got I
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_03e4: Invalid comparison between F4 and I4
		//IL_03f5: Expected O, but got I4
		//IL_0410: Invalid comparison between F4 and I4
		//IL_041f: Invalid comparison between F4 and I4
		//IL_043f: Expected O, but got I4
		//IL_0447: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_0473: Expected O, but got I4
		//IL_04a1: Expected O, but got I4
		//IL_0b8b: Expected O, but got I4
		//IL_0493: Expected O, but got I4
		//IL_04bd: Expected O, but got I4
		//IL_0bad: Expected O, but got I4
		//IL_04af: Expected O, but got I4
		//IL_04d9: Expected O, but got I4
		//IL_0bd4: Expected O, but got I
		//IL_0be4: Expected F4, but got I
		//IL_0bef: Expected O, but got I4
		//IL_04cb: Expected O, but got I4
		//IL_04f5: Expected O, but got I4
		//IL_0c0e: Expected I, but got O
		//IL_0c19: Expected O, but got I
		//IL_04e7: Expected O, but got I4
		//IL_051f: Expected O, but got I4
		//IL_065e: Expected O, but got I4
		//IL_05ac: Expected O, but got I4
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_079e: Expected O, but got Unknown
		//IL_07a9: Invalid comparison between F4 and I4
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bf: Expected O, but got Unknown
		//IL_0706: Invalid comparison between F4 and I4
		//IL_0717: Expected O, but got I4
		//IL_0ceb: Expected O, but got I
		//IL_0cfb: Expected F4, but got I
		//IL_0d03: Expected F4, but got O
		//IL_0d0c: Expected F8, but got I4
		//IL_0d15: Expected F4, but got I4
		//IL_07c8: Invalid comparison between F4 and I4
		//IL_0edb: Expected O, but got I
		//IL_0ee7: Expected O, but got I
		//IL_0f11: Expected O, but got I4
		//IL_0739: Invalid comparison between F4 and I4
		//IL_0750: Expected O, but got F4
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_075f: Expected O, but got Unknown
		//IL_0f2a: Invalid comparison between F4 and I4
		//IL_07ea: Invalid comparison between F4 and I4
		//IL_07fb: Expected O, but got I4
		//IL_0806: Invalid comparison between F4 and I4
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0822: Expected O, but got Unknown
		//IL_08f9: Expected I4, but got F4
		//IL_08ea: Expected I4, but got I8
		//IL_0d29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2e: Expected O, but got Unknown
		//IL_0d46: Expected O, but got I
		//IL_0d56: Expected F4, but got I
		//IL_084d: Expected O, but got I4
		//IL_0869: Invalid comparison between F4 and I4
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Expected O, but got Unknown
		//IL_0919: Expected O, but got I
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Expected O, but got Unknown
		//IL_0939: Expected O, but got I
		//IL_0945: Expected O, but got I
		//IL_096c: Expected O, but got I4
		//IL_0db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dbd: Expected O, but got Unknown
		//IL_0dd5: Expected O, but got I
		//IL_0dfe: Expected O, but got I
		//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e13: Expected O, but got Unknown
		//IL_0e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e32: Expected O, but got Unknown
		//IL_0c91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c96: Expected O, but got Unknown
		//IL_0cae: Expected O, but got I
		//IL_0cbe: Expected O, but got I
		//IL_0cce: Expected F4, but got I
		//IL_099c: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E77F2]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			if (!usePercentage)
			{
				goto IL_0052;
			}
		}
		else
		{
			_ = 1;
			if (!usePercentage)
			{
				goto IL_0052;
			}
		}
		double num = (double)CurrentProgress - 1.0;
		bool flag = num < 0.0;
		bool flag2 = num == 0.0;
		object obj2 = (double)CurrentProgress ^ 1.0;
		object obj3 = (double)CurrentProgress ^ num;
		object obj4 = obj2 & obj3;
		bool flag3 = (nint)obj4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		object obj6 = flag4 & obj5;
		object obj7 = ~obj6;
		double num2 = ((obj7 != null) ? ((double)CurrentProgress) : 1.0);
		if ((double)CurrentProgress < -1.0)
		{
			num2 = -1.0;
		}
		bool flag5 = MaxProgress < 0f;
		object obj8 = !flag5;
		bool flag6 = MaxProgress == 0f;
		object obj9 = !flag6;
		object obj10 = obj8 & obj9;
		object obj11 = ~obj10;
		double num3 = ((obj11 != null) ? 1.0 : ((double)MaxProgress));
		object obj12 = !flag6;
		object obj13 = obj8 & obj12;
		object obj14 = ~obj13;
		double num4 = ((obj14 != null) ? num2 : ((double)CurrentProgress));
		MaxProgress = 100f;
		double num5 = num4 * 1120403456.0;
		double num6 = num5 / num3;
		CurrentProgress = (float)num6;
		int num7 = ShortcutExtensions.DOKill(fill);
		Component component = head;
		goto IL_01e7;
		IL_0691:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj15;
		bool flag7 = obj15;
		bool flag8 = !flag7;
		bool flag10;
		bool flag9 = flag10;
		bool flag11 = false;
		if (!flag8)
		{
			goto IL_06d7;
		}
		goto IL_078a;
		IL_0536:
		UnityEngine.Object obj16 = negativeHead;
		object obj18;
		object obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v58+E4]");
		bool flag12 = (nint)0 == 0;
		flag9 = false;
		flag10 = false;
		obj15 = negativeHead;
		if (!flag12)
		{
			goto IL_0589;
		}
		goto IL_0691;
		IL_06d7:
		GameObject gameObject = negativeHead.gameObject;
		float num8 = CurrentProgress - 2.139095E+09f;
		bool flag13 = num8 == 0f;
		object obj19 = !flag13;
		object obj20 = ~obj19;
		bool flag14;
		bool flag15;
		if (obj20 == null)
		{
			flag14 = CurrentProgress < 0f;
			object obj21 = CurrentProgress ^ CurrentProgress;
			object obj22 = CurrentProgress & obj21;
			flag15 = (nint)obj22 < 0;
		}
		else
		{
			flag15 = false;
			flag14 = true;
		}
		bool flag16 = flag14 == flag15;
		bool flag17 = !flag16;
		gameObject.SetActive(flag17);
		flag9 = false;
		flag11 = flag17;
		goto IL_078a;
		IL_078a:
		object obj23 = typeof(SqlSingle[]) + 3912;
		double num10;
		float num12;
		float duration;
		object obj37;
		if (CurrentProgress != 2.139095E+09f && CurrentProgress > 0f)
		{
			bool flag18 = MaxProgress < 0f;
			object obj24 = !flag18;
			bool flag19 = MaxProgress == 0f;
			object obj25 = ~obj24;
			object obj26 = obj25 | flag19;
			if (obj26 == null)
			{
				bool flag20 = CurrentProgress < MaxProgress;
				object obj27 = !flag20;
				float num9 = CurrentProgress - MaxProgress;
				bool flag21 = num9 == 0f;
				num10 = (double)CurrentProgress / (double)MaxProgress;
				object obj28 = ~obj27;
				object obj29 = obj28 | flag21;
				object obj33;
				float num11;
				if (obj29 == null)
				{
					object obj30 = typeof(UsageHint) + 816;
					object obj31 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v52+B8]");
					object obj32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X8_v53+54]");
					obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v894 @ X8_v53+5C]");
					num11 = 0f;
				}
				else
				{
					object obj34 = typeof(UsageHint) + 816;
					object obj35 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ X8_v46+B8]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X8_v47+5C]");
					num12 = 0f * CurrentProgress;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X8_v47+54]");
					obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X8_v47+54]");
					object obj39 = default(object);
					object obj38 = 0 * obj39;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v910 @ X8_v47+54]");
					obj33 = obj38 / 0;
					num11 = num12 / MaxProgress;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				float num13 = (float)obj33 * num12;
				float num14 = num11 * 1.13587E+09f;
				duration = num13;
			}
			else
			{
				object obj40 = typeof(UsageHint) + 816;
				object obj41 = obj40;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v867 @ X8_v36+B8]");
				object obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X8_v37+5C]");
				float num11 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X8_v37+54]");
				float num15 = 0f * num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X8_v37+5C]");
				float num14 = 0f * 1.13587E+09f;
				duration = num15;
				num10 = 1.0;
			}
		}
		else
		{
			object obj43 = typeof(UsageHint) + 816;
			object obj44 = obj43;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X8_v28+B8]");
			object obj45 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X8_v29+8]");
			float num14 = 0f;
			duration = (float)obj45;
			num10 = 0.0;
			float num11 = 2.139095E+09f;
		}
		object obj46 = (nint)0 + (nint)2944;
		object obj47 = (nint)0 + (nint)2864;
		object obj48 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X8_v23+E4]");
		bool flag22 = (nint)0 == 0;
		object obj49 = !flag22;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tweener tweener = AnimationExtensions.DONumber(endValue: (int)((CurrentProgress != 2.139095E+09f) ? ((int)CurrentProgress) : 2147483648L), target: thisWeekPoints, duration: phase1Time, useCommas: false, includeSign: false, percentage: usePercentage);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFillAmount(fill, (float)num10, phase1Time);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj50 = (nint)0 + (nint)2848;
		object obj51 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj52 = (nint)0 + (nint)576;
		object obj53 = (nint)0 + (nint)2472;
		Transform target = head.transform;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore2 = ShortcutExtensions.DOLocalRotate(target, (Vector3)rotateMode, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj52);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_0589:
		bool flag23 = obj16;
		bool flag24 = !flag23;
		object obj54 = !flag24;
		if (obj54 != null)
		{
			goto IL_06d7;
		}
		flag11 = false;
		goto IL_078a;
		IL_01e7:
		Transform target2 = component.transform;
		int num16 = ShortcutExtensions.DOKill(target2, complete: true);
		int num17 = ShortcutExtensions.DOKill(thisWeekPoints);
		if (startFromZero)
		{
			fill.fillAmount = 0f;
			Transform transform = head.transform;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Vector3 euler = default(Vector3);
			Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
			transform.localRotation = (Quaternion)0;
			TextMeshProExtensions.SetNumber(thisWeekPoints, 0, useCommas: false, includeSign: false, usePercentage);
		}
		TextMeshProExtensions.SetNumber(number: (int)((MaxProgress != 2.139095E+09f) ? ((int)MaxProgress) : 2147483648L), textMesh: lastWeekPoints);
		float num18 = MaxProgress - 2.139095E+09f;
		bool flag25 = num18 == 0f;
		object obj55 = !flag25;
		float num19 = MaxProgress + 1f;
		bool flag26 = num19 < 0f;
		bool flag27 = num19 == 0f;
		bool flag28 = !flag26;
		object obj56 = !flag27;
		object obj57 = flag28 & obj56;
		object obj58 = obj55 & obj57;
		bool flag29 = obj58 == null;
		object obj59 = !flag29;
		object obj60 = ~obj59;
		if (obj60 == null)
		{
		}
		object obj61 = !flag29;
		object obj62 = ~obj61;
		if (obj62 == null)
		{
		}
		object obj63 = !flag29;
		object obj64 = ~obj63;
		if (obj64 == null)
		{
		}
		object obj65 = !flag29;
		object obj66 = ~obj65;
		if (obj66 == null)
		{
		}
		lastWeekPoints.color = (Color)0;
		TextMeshProUGUI textMeshProUGUI = thisWeekPoints;
		obj18 = typeof(MemberAchievementClanFeedData) + 2976;
		float num20 = CurrentProgress - 2.139095E+09f;
		bool flag30 = num20 == 0f;
		object obj67 = !flag30;
		float num21 = CurrentProgress + 1f;
		bool flag31 = num21 < 0f;
		bool flag32 = num21 == 0f;
		bool flag33 = !flag31;
		object obj68 = !flag32;
		object obj69 = flag33 & obj68;
		object obj70 = obj67 & obj69;
		bool flag34 = obj70 == null;
		object obj71 = !flag34;
		object obj72 = ~obj71;
		if (obj72 == null)
		{
			object obj73 = 112;
		}
		else
		{
			object obj73 = 128;
		}
		object obj74 = !flag34;
		object obj75 = ~obj74;
		if (obj75 == null)
		{
			object obj76 = 108;
		}
		else
		{
			object obj76 = 124;
		}
		object obj77 = !flag34;
		object obj78 = ~obj77;
		if (obj78 == null)
		{
			object obj79 = 104;
		}
		else
		{
			object obj79 = 120;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CircularProgress)+v591 @ X8_v16]");
		obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CircularProgress)+v598 @ X9_v15]");
		num12 = 0f;
		object obj80 = !flag34;
		object obj81 = ~obj80;
		if (obj81 == null)
		{
			object obj82 = 100;
		}
		else
		{
			object obj82 = 116;
		}
		nint num22 = (nint)textMeshProUGUI;
		textMeshProUGUI.color = (Color)0;
		object obj83 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v19+E4]");
		bool flag37;
		if ((nint)0 != 0)
		{
			bool flag35 = perfectStar;
			bool flag36 = !flag35;
			object obj84 = !flag36;
			flag37 = false;
			if (obj84 == null)
			{
				goto IL_0536;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag38 = perfectStar;
			bool flag39 = !flag38;
			flag37 = false;
			if (flag39)
			{
				goto IL_0536;
			}
		}
		GameObject gameObject2 = perfectStar.gameObject;
		gameObject2.SetActive(value: false);
		obj16 = negativeHead;
		obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v656 @ X8_v58+E4]");
		bool flag40 = (nint)0 == 0;
		object obj85 = !flag40;
		flag9 = false;
		flag10 = false;
		flag37 = false;
		obj15 = negativeHead;
		if (obj85 != null)
		{
			goto IL_0589;
		}
		goto IL_0691;
		IL_0052:
		int num23 = ShortcutExtensions.DOKill(fill);
		component = head;
		bool flag41 = (object)head == null;
		object obj86 = !flag41;
		if (obj86 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01e7;
	}

	public CircularProgress()
	{
		//IL_001a: Expected I4, but got I8
		//IL_002c: Expected F4, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252F50]");
		phase1Time = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252F60]");
		_ = 0;
		_ = 1065353216;
		base..ctor();
	}

	private void <StartAnimating>b__16_0()
	{
		//IL_018a: Invalid comparison between F4 and I4
		//IL_01aa: Invalid comparison between F4 and I4
		//IL_0012: Expected F4, but got I8
		//IL_0041: Invalid comparison between F4 and I4
		//IL_0052: Expected O, but got I4
		//IL_01d7: Expected O, but got I4
		//IL_0083: Invalid comparison between F4 and I4
		//IL_0098: Expected O, but got F4
		//IL_00a5: Expected O, but got F4
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0151: Expected O, but got I4
		float num = ((CurrentProgress != 2.139095E+09f) ? CurrentProgress : 2.1474836E+09f);
		if (num < 1f)
		{
			return;
		}
		float num2 = MaxProgress - 2.139095E+09f;
		bool flag = num2 == 0f;
		object obj = !flag;
		object obj2 = ~obj;
		bool flag2;
		bool flag3;
		if (obj2 == null)
		{
			float num3 = num - MaxProgress;
			flag2 = num3 < 0f;
			object obj3 = num ^ MaxProgress;
			object obj4 = num ^ num3;
			object obj5 = obj3 & obj4;
			flag3 = (nint)obj5 < 0;
		}
		else
		{
			flag3 = false;
			flag2 = false;
		}
		bool flag4 = flag2 == flag3;
		object obj6 = !flag4;
		if (obj6 == null)
		{
			GameObject gameObject = perfectStar.gameObject;
			gameObject.SetActive(value: true);
			RectTransform rectTransform = UIExtensions.rectTransform(perfectStar);
			object obj7 = typeof(SqlSingle[]) + 3912;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v7+E4]");
			bool flag5 = (nint)0 == 0;
			object obj9 = !flag5;
			Transform rect = rectTransform;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				rect = rectTransform;
			}
			AnimationExtensions.AnimHeartGain(rect, 0, 0.25f, 0.6f, 6f);
		}
	}
}
