using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using UnityEngine;

namespace UI.Mutations;

[Serializable]
public class RectTransformMutation : IMutation
{
	private RectTransform _rectTransform;

	private bool togglePosition;

	private Vector3 newPosition;

	private bool toggleOffset;

	private Vector3 positionOffset;

	private bool toggleRightEdge;

	private float rightEdgeX;

	private bool toggleLeftEdge;

	private float leftEdgeX;

	private bool toggleTopEdge;

	private float topEdgeY;

	private bool toggleBottomEdge;

	private float bottomEdgeY;

	private bool toggleSize;

	private Vector2 newSize;

	private bool togglePivot;

	private Vector2 newPivot;

	private bool toggleRotation;

	private Vector3 newRotation;

	private bool toggleScale;

	private Vector3 newScale;

	private float tweenDuration;

	private Vector3 originalPosition;

	private Vector2 originalSize;

	private Vector2 originalPivot;

	private Vector3 originalRotation;

	private Vector3 originalScale;

	private bool offsetApplied;

	private bool rightEdgeApplied;

	private float rightEdgeDeltaX;

	private bool leftEdgeApplied;

	private float leftEdgeDeltaX;

	private bool topEdgeApplied;

	private float topEdgeDeltaY;

	private bool bottomEdgeApplied;

	private float bottomEdgeDeltaY;

	public void Setup(GameObject gm)
	{
		Vector2 anchoredPosition = _rectTransform.anchoredPosition;
		Vector3 vector = default(Vector3);
		originalPosition = vector;
		_ = 0;
		Vector3 localEulerAngles = _rectTransform.localEulerAngles;
		originalRotation = vector;
		Vector2 sizeDelta = _rectTransform.sizeDelta;
		originalSize = vector;
		Vector3 localScale = _rectTransform.localScale;
		originalScale = vector;
		Vector2 pivot = _rectTransform.pivot;
		originalPivot = vector;
		offsetApplied = false;
		leftEdgeApplied = false;
		topEdgeApplied = false;
		bottomEdgeApplied = false;
	}

	public void Teardown()
	{
	}

	public void PerformMutation()
	{
		//IL_0016: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_0170: Expected F4, but got I
		//IL_017a: Expected F4, but got O
		//IL_00db: Expected F4, but got O
		//IL_00db: Expected O, but got I4
		//IL_0118: Expected F4, but got I
		//IL_0122: Expected F4, but got O
		//IL_01ec: Expected O, but got I4
		//IL_0266: Expected O, but got I4
		//IL_0415: Expected O, but got I4
		//IL_0522: Expected O, but got I4
		//IL_0757: Expected O, but got I4
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_0595: Expected O, but got I4
		//IL_02d7: Expected F4, but got O
		//IL_0302: Expected O, but got I4
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a5: Expected O, but got Unknown
		//IL_0ae7: Expected O, but got I4
		//IL_082f: Expected O, but got I4
		//IL_083f: Expected F4, but got I
		//IL_086f: Expected F4, but got I
		//IL_0602: Expected F4, but got I
		//IL_062f: Expected O, but got I4
		//IL_0bd3: Expected O, but got I4
		//IL_08cb: Expected O, but got I4
		//IL_06ed: Expected F4, but got I
		//IL_071d: Expected F4, but got I
		//IL_0e25: Expected F4, but got O
		//IL_0e40: Expected F4, but got O
		//IL_0e40: Expected O, but got I4
		//IL_0cbb: Expected O, but got I4
		//IL_09b3: Expected O, but got I4
		//IL_067d: Expected F4, but got I
		//IL_0da7: Expected O, but got I4
		//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Expected O, but got Unknown
		//IL_0dd0: Expected O, but got I4
		//IL_0e82: Expected F4, but got O
		//IL_0e98: Expected F4, but got O
		//IL_0e98: Expected O, but got I4
		//IL_0eb3: Expected O, but got I4
		//IL_0ebd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec2: Expected O, but got Unknown
		//IL_0f50: Expected O, but got I4
		//IL_0f0e: Expected F4, but got O
		//IL_106a: Expected O, but got I4
		//IL_0e16: Expected F4, but got O
		//IL_0e16: Expected O, but got I4
		//IL_109a: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7DD7]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			if (!togglePosition)
			{
				goto IL_0052;
			}
		}
		else
		{
			_ = 1;
			if (!togglePosition)
			{
				goto IL_0052;
			}
		}
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos(_rectTransform, (Vector2)0, (float)newPosition);
		bool flag = !toggleOffset;
		bool flag2 = false;
		float num = tweenDuration;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UI.Mutations.RectTransformMutation)+20]");
		float num2 = 0f;
		float num3 = (float)newPosition;
		if (!flag)
		{
			goto IL_0130;
		}
		goto IL_0f7a;
		IL_0f9c:
		bool flag3;
		float num5;
		if (flag3)
		{
			bool flag4 = !topEdgeApplied;
			object obj2 = !flag4;
			if (obj2 == null)
			{
				Vector2 pivot = _rectTransform.pivot;
				float num4 = num5 * num2;
				float num6 = bottomEdgeY + num4;
				Vector2 anchoredPosition = _rectTransform.anchoredPosition;
				float num7 = num6 - num2;
				topEdgeDeltaY = num7;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPosY(_rectTransform, num6, tweenDuration);
				topEdgeApplied = true;
				flag2 = false;
				num3 = num6;
			}
		}
		else
		{
			if (toggleTopEdge)
			{
				bool flag5 = !topEdgeApplied;
				object obj3 = !flag5;
				if (obj3 == null)
				{
					Vector2 pivot2 = _rectTransform.pivot;
					double num8 = 1.0 - (double)num2;
					float num9 = num5 * (float)num8;
					float num10 = topEdgeY - num9;
					Vector2 anchoredPosition2 = _rectTransform.anchoredPosition;
					float num11 = num10 - num2;
					topEdgeDeltaY = num11;
					num2 = tweenDuration;
					TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = DOTweenModuleUI.DOAnchorPosY(_rectTransform, num10, tweenDuration);
					topEdgeApplied = true;
					flag2 = false;
					num3 = num10;
				}
			}
			if (toggleBottomEdge)
			{
				bool flag6 = !bottomEdgeApplied;
				object obj4 = !flag6;
				if (obj4 == null)
				{
					Vector2 pivot3 = _rectTransform.pivot;
					float num12 = num5 * num2;
					float num13 = bottomEdgeY + num12;
					Vector2 anchoredPosition3 = _rectTransform.anchoredPosition;
					float num14 = num13 - num2;
					bottomEdgeDeltaY = num14;
					TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore4 = DOTweenModuleUI.DOAnchorPosY(_rectTransform, num13, tweenDuration);
					bottomEdgeApplied = true;
					flag2 = false;
					num3 = num13;
				}
			}
		}
		RotateMode rotateMode;
		if (!toggleRotation)
		{
			bool flag7 = toggleScale;
			rotateMode = (flag2 ? RotateMode.FastBeyond360 : RotateMode.Fast);
			if (!flag7)
			{
				goto IL_0d90;
			}
		}
		else
		{
			num3 = (float)newRotation;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore5 = ShortcutExtensions.DORotate(_rectTransform, (Vector3)0, (float)newRotation);
			bool flag8 = !toggleScale;
			flag2 = false;
			rotateMode = RotateMode.Fast;
			if (flag8)
			{
				goto IL_0d90;
			}
		}
		num3 = (float)newScale;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore6 = ShortcutExtensions.DOScale(_rectTransform, (Vector3)0, (float)newScale);
		bool flag9 = toggleSize;
		bool flag10;
		object obj5 = flag10 || flag3;
		object obj6 = toggleSize | obj5;
		bool flag11 = obj6 == null;
		flag2 = (byte)rotateMode != 0;
		if (flag11)
		{
			goto IL_0dde;
		}
		goto IL_0ee7;
		IL_073b:
		bool flag12 = !rightEdgeApplied;
		object obj7 = !flag12;
		float num16;
		if (obj7 == null)
		{
			Vector2 pivot4 = _rectTransform.pivot;
			float num15 = num16 * num3;
			float num17 = leftEdgeX + num15;
			Vector2 anchoredPosition4 = _rectTransform.anchoredPosition;
			float num18 = num17 - num15;
			rightEdgeDeltaX = num18;
			num2 = tweenDuration;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore7 = DOTweenModuleUI.DOAnchorPosX(_rectTransform, num17, tweenDuration);
			rightEdgeApplied = true;
			flag2 = false;
			num3 = num17;
		}
		goto IL_0f9c;
		IL_0e00:
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore8 = DOTweenModuleUI.DOPivot(_rectTransform, (Vector2)0, (float)newPivot);
		return;
		IL_0052:
		if (toggleOffset)
		{
			goto IL_0130;
		}
		bool flag13 = default(bool);
		flag2 = flag13;
		float num19 = default(float);
		num = num19;
		float num20 = default(float);
		num2 = num20;
		float num21 = default(float);
		num3 = num21;
		goto IL_0f7a;
		IL_0130:
		bool flag14 = !offsetApplied;
		object obj8 = !flag14;
		flag2 = false;
		num = tweenDuration;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UI.Mutations.RectTransformMutation)+20]");
		num2 = 0f;
		num3 = (float)newPosition;
		if (obj8 == null)
		{
			Vector2 anchoredPosition5 = _rectTransform.anchoredPosition;
			num3 = (float)newPosition + (float)positionOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UI.Mutations.RectTransformMutation)+20]");
			float num22 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UI.Mutations.RectTransformMutation)+30]");
			num2 = num22 + 0f;
			num = tweenDuration;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore9 = DOTweenModuleUI.DOAnchorPos(_rectTransform, (Vector2)0, num3);
			offsetApplied = true;
			flag2 = false;
		}
		goto IL_0f7a;
		IL_04e5:
		num3 = topEdgeY;
		num2 = bottomEdgeY;
		num5 = topEdgeY - bottomEdgeY;
		bool flag15 = !flag10;
		object obj9 = !flag15;
		if (obj9 != null)
		{
			goto IL_073b;
		}
		float num23 = num5;
		float num24 = num16;
		float num26;
		float num25 = num26;
		bool flag16 = flag3;
		float num27 = bottomEdgeY;
		float num28 = topEdgeY;
		bool flag17 = flag10;
		goto IL_088d;
		IL_088d:
		if (toggleRightEdge)
		{
			bool flag18 = !rightEdgeApplied;
			object obj10 = !flag18;
			if (obj10 == null)
			{
				Vector2 pivot5 = _rectTransform.pivot;
				double num29 = 1.0 - (double)num28;
				float num30 = num24 * (float)num29;
				float num31 = rightEdgeX - num30;
				Vector2 anchoredPosition6 = _rectTransform.anchoredPosition;
				float num32 = num31 - num30;
				rightEdgeDeltaX = num32;
				num27 = tweenDuration;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore10 = DOTweenModuleUI.DOAnchorPosX(_rectTransform, num31, tweenDuration);
				rightEdgeApplied = true;
				flag2 = false;
				num28 = num31;
			}
		}
		bool flag19 = !toggleLeftEdge;
		num5 = num23;
		num16 = num24;
		num26 = num25;
		flag3 = flag16;
		num2 = num27;
		num3 = num28;
		flag10 = flag17;
		if (!flag19)
		{
			bool flag20 = !leftEdgeApplied;
			object obj11 = !flag20;
			num5 = num23;
			num16 = num24;
			num26 = num25;
			flag3 = flag16;
			num2 = num27;
			num3 = num28;
			flag10 = flag17;
			if (obj11 == null)
			{
				Vector2 pivot6 = _rectTransform.pivot;
				float num33 = num24 * num28;
				float num34 = leftEdgeX + num33;
				Vector2 anchoredPosition7 = _rectTransform.anchoredPosition;
				float num35 = num34 - num33;
				leftEdgeDeltaX = num35;
				num2 = tweenDuration;
				TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore11 = DOTweenModuleUI.DOAnchorPosX(_rectTransform, num34, tweenDuration);
				leftEdgeApplied = true;
				num5 = num23;
				num16 = num24;
				num26 = num25;
				flag3 = flag16;
				flag2 = false;
				num3 = num34;
				flag10 = flag17;
			}
		}
		goto IL_0f9c;
		IL_0f7a:
		if (toggleLeftEdge)
		{
			flag17 = toggleRightEdge;
			bool flag21 = toggleTopEdge;
			flag10 = toggleRightEdge;
			if (!flag21)
			{
				goto IL_0242;
			}
		}
		else
		{
			bool flag22 = !toggleTopEdge;
			flag17 = false;
			flag10 = false;
			if (flag22)
			{
				goto IL_0242;
			}
		}
		flag16 = toggleBottomEdge;
		Vector2 vector = AnchorSpan();
		bool flag23 = !flag10;
		float num36 = num2;
		num25 = num3;
		flag17 = flag10;
		float num37 = num2;
		num26 = num3;
		flag3 = toggleBottomEdge;
		if (flag23)
		{
			goto IL_02ae;
		}
		goto IL_03d4;
		IL_05d3:
		if (toggleSize)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UI.Mutations.RectTransformMutation)+60]");
			num3 = 0f;
			float num38 = num37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UI.Mutations.RectTransformMutation)+60]");
			num5 = num38 + 0f;
			bool flag24 = !flag17;
			object obj12 = !flag24;
			num16 = num24;
			num26 = num25;
			flag3 = flag16;
			flag10 = flag17;
			if (obj12 != null)
			{
				goto IL_073b;
			}
			num23 = num5;
			num27 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UI.Mutations.RectTransformMutation)+60]");
			num28 = 0f;
		}
		else
		{
			Rect rect = _rectTransform.rect;
			object obj13 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X0_v64+E4]");
			if ((nint)0 != 0)
			{
				bool flag25 = !flag17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UI.Mutations.RectTransformMutation)+30]");
				num5 = 0f;
				num16 = num24;
				num26 = num25;
				flag3 = flag16;
				flag10 = flag17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UI.Mutations.RectTransformMutation)+30]");
				num23 = 0f;
				num27 = num2;
				num28 = num3;
				if (!flag25)
				{
					goto IL_073b;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag26 = !flag17;
				object obj15 = !flag26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UI.Mutations.RectTransformMutation)+30]");
				num5 = 0f;
				num16 = num24;
				num26 = num25;
				flag3 = flag16;
				flag10 = flag17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UI.Mutations.RectTransformMutation)+30]");
				num23 = 0f;
				num27 = num2;
				num28 = num3;
				if (obj15 != null)
				{
					goto IL_073b;
				}
			}
		}
		goto IL_088d;
		IL_0d90:
		flag9 = toggleSize;
		object obj16 = flag10 || flag3;
		object obj17 = toggleSize | obj16;
		bool flag27 = obj17 == null;
		object obj18 = !flag27;
		if (obj18 == null)
		{
			goto IL_0dde;
		}
		goto IL_0ee7;
		IL_0dde:
		if (togglePivot)
		{
			goto IL_0e00;
		}
		return;
		IL_0242:
		Vector2 vector2 = AnchorSpan();
		bool flag28 = !flag17;
		object obj19 = !flag28;
		num36 = num2;
		num25 = num3;
		flag16 = false;
		num37 = num2;
		num26 = num3;
		flag3 = false;
		flag10 = flag17;
		if (obj19 == null)
		{
			goto IL_02ae;
		}
		goto IL_03d4;
		IL_03d4:
		num3 = rightEdgeX;
		num2 = leftEdgeX;
		num16 = rightEdgeX - leftEdgeX;
		bool flag29 = !flag3;
		object obj20 = !flag29;
		if (obj20 != null)
		{
			goto IL_04e5;
		}
		num24 = num16;
		num25 = num26;
		flag16 = flag3;
		flag17 = flag10;
		goto IL_05d3;
		IL_0ee7:
		if (flag9)
		{
			num3 = (float)newSize;
		}
		else
		{
			Vector2 sizeDelta = _rectTransform.sizeDelta;
		}
		float num39 = num16 - num26;
		bool flag30 = !flag10;
		object obj21 = !flag30;
		object obj22 = ~obj21;
		if (obj22 == null)
		{
			num3 = num39;
		}
		bool flag31 = !flag3;
		object obj23 = !flag31;
		object obj24 = ~obj23;
		if (obj24 == null)
		{
		}
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore12 = DOTweenModuleUI.DOSizeDelta(_rectTransform, (Vector2)0, num3);
		bool flag32 = togglePivot;
		flag2 = false;
		if (!flag32)
		{
			return;
		}
		goto IL_0e00;
		IL_02ae:
		if (toggleSize)
		{
			num3 = (float)newSize;
			num16 = num25 + (float)newSize;
			bool flag33 = !flag16;
			object obj25 = !flag33;
			num26 = num25;
			flag3 = flag16;
			flag10 = flag17;
			if (obj25 != null)
			{
				goto IL_04e5;
			}
			num24 = num16;
			num37 = num36;
		}
		else
		{
			Rect rect2 = _rectTransform.rect;
			object obj26 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			object obj27 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X0_v73+E4]");
			if ((nint)0 != 0)
			{
				bool flag34 = !flag16;
				num16 = num;
				num26 = num25;
				flag3 = flag16;
				flag10 = flag17;
				num24 = num;
				num37 = num36;
				if (!flag34)
				{
					goto IL_04e5;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag35 = !flag16;
				object obj28 = !flag35;
				num16 = num;
				num26 = num25;
				flag3 = flag16;
				flag10 = flag17;
				num24 = num;
				num37 = num36;
				if (obj28 != null)
				{
					goto IL_04e5;
				}
			}
		}
		goto IL_05d3;
	}

	public void UndoMutation()
	{
		//IL_002c: Expected F4, but got O
		//IL_003c: Expected F4, but got I
		//IL_0057: Expected F4, but got O
		//IL_0057: Expected O, but got I4
		//IL_00fd: Expected O, but got I4
		//IL_0462: Expected F4, but got O
		//IL_047d: Expected F4, but got O
		//IL_047d: Expected O, but got I4
		//IL_04bf: Expected F4, but got O
		//IL_04d5: Expected F4, but got O
		//IL_04d5: Expected O, but got I4
		//IL_04fc: Expected F4, but got O
		//IL_03ea: Expected O, but got I4
		//IL_0404: Expected O, but got I4
		//IL_0571: Expected O, but got I4
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got Unknown
		//IL_062a: Expected O, but got I4
		//IL_05ff: Expected F4, but got O
		//IL_05dc: Expected F4, but got O
		//IL_0453: Expected F4, but got O
		//IL_0453: Expected O, but got I4
		//IL_0711: Expected O, but got I4
		float num = default(float);
		float num2 = default(float);
		bool flag = default(bool);
		if (togglePosition)
		{
			num = (float)originalPosition;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UI.Mutations.RectTransformMutation)+98]");
			num2 = 0f;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos(_rectTransform, (Vector2)0, (float)originalPosition);
			flag = false;
		}
		if (toggleOffset && offsetApplied)
		{
			Vector2 anchoredPosition = _rectTransform.anchoredPosition;
			num -= (float)positionOffset;
			float num3 = num2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UI.Mutations.RectTransformMutation)+30]");
			num2 = num3 - 0f;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPos(_rectTransform, (Vector2)0, num);
			offsetApplied = false;
			flag = false;
		}
		if (toggleRightEdge && rightEdgeApplied)
		{
			Vector2 anchoredPosition2 = _rectTransform.anchoredPosition;
			num2 = tweenDuration;
			num -= rightEdgeDeltaX;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore3 = DOTweenModuleUI.DOAnchorPosX(_rectTransform, num, tweenDuration);
			rightEdgeApplied = false;
			flag = false;
		}
		if (toggleLeftEdge && leftEdgeApplied)
		{
			Vector2 anchoredPosition3 = _rectTransform.anchoredPosition;
			num2 = tweenDuration;
			num -= leftEdgeDeltaX;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore4 = DOTweenModuleUI.DOAnchorPosX(_rectTransform, num, tweenDuration);
			leftEdgeApplied = false;
			flag = false;
		}
		if (toggleTopEdge && topEdgeApplied)
		{
			Vector2 anchoredPosition4 = _rectTransform.anchoredPosition;
			num = num2 - topEdgeDeltaY;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore5 = DOTweenModuleUI.DOAnchorPosY(_rectTransform, num, tweenDuration);
			topEdgeApplied = false;
			flag = false;
			num2 = tweenDuration;
		}
		if (toggleBottomEdge && bottomEdgeApplied)
		{
			Vector2 anchoredPosition5 = _rectTransform.anchoredPosition;
			num = num2 - bottomEdgeDeltaY;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore6 = DOTweenModuleUI.DOAnchorPosY(_rectTransform, num, tweenDuration);
			bottomEdgeApplied = false;
			flag = false;
		}
		RotateMode rotateMode;
		if (!toggleRotation)
		{
			bool flag2 = toggleScale;
			rotateMode = (flag ? RotateMode.FastBeyond360 : RotateMode.Fast);
			if (!flag2)
			{
				goto IL_035c;
			}
		}
		else
		{
			num = (float)originalRotation;
			TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore7 = ShortcutExtensions.DORotate(_rectTransform, (Vector3)0, (float)originalRotation);
			bool flag3 = !toggleScale;
			flag = false;
			rotateMode = RotateMode.Fast;
			if (flag3)
			{
				goto IL_035c;
			}
		}
		num = (float)originalScale;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore8 = ShortcutExtensions.DOScale(_rectTransform, (Vector3)0, (float)originalScale);
		bool flag4 = toggleLeftEdge;
		flag = (byte)rotateMode != 0;
		float num4 = (float)originalScale;
		if (flag4)
		{
			goto IL_038e;
		}
		goto IL_050a;
		IL_038e:
		bool flag5 = toggleRightEdge;
		bool flag6 = toggleTopEdge;
		bool flag7 = toggleRightEdge;
		rotateMode = (flag ? RotateMode.FastBeyond360 : RotateMode.Fast);
		num4 = num;
		if (!flag6)
		{
			goto IL_03d1;
		}
		goto IL_054e;
		IL_05f5:
		num = (float)originalSize;
		goto IL_06e4;
		IL_050a:
		bool flag8 = !toggleTopEdge;
		flag5 = false;
		flag = (byte)rotateMode != 0;
		num = num4;
		flag7 = false;
		if (flag8)
		{
			goto IL_03d1;
		}
		goto IL_054e;
		IL_05b5:
		bool flag9;
		if (flag9)
		{
			num = (float)originalSize;
			if (flag5)
			{
				goto IL_05f5;
			}
		}
		else
		{
			Vector2 sizeDelta = _rectTransform.sizeDelta;
			bool flag10 = !flag5;
			object obj = !flag10;
			if (obj != null)
			{
				goto IL_05f5;
			}
		}
		goto IL_06e4;
		IL_054e:
		bool flag11 = toggleBottomEdge;
		flag9 = toggleSize;
		object obj2 = flag7 | toggleBottomEdge;
		object obj3 = toggleSize | obj2;
		bool flag12 = obj3 == null;
		flag = (byte)rotateMode != 0;
		flag5 = flag7;
		num = num4;
		if (flag12)
		{
			goto IL_041b;
		}
		goto IL_05b5;
		IL_03d1:
		flag9 = toggleSize;
		object obj4 = toggleSize || flag5;
		bool flag13 = obj4 == null;
		object obj5 = !flag13;
		flag11 = false;
		if (obj5 == null)
		{
			goto IL_041b;
		}
		goto IL_05b5;
		IL_06e4:
		if (flag11)
		{
		}
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore9 = DOTweenModuleUI.DOSizeDelta(_rectTransform, (Vector2)0, num);
		bool flag14 = togglePivot;
		flag = false;
		if (!flag14)
		{
			return;
		}
		goto IL_043d;
		IL_041b:
		if (togglePivot)
		{
			goto IL_043d;
		}
		return;
		IL_043d:
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore10 = DOTweenModuleUI.DOPivot(_rectTransform, (Vector2)0, (float)originalPivot);
		return;
		IL_035c:
		bool flag15 = !toggleLeftEdge;
		rotateMode = (flag ? RotateMode.FastBeyond360 : RotateMode.Fast);
		num4 = num;
		if (!flag15)
		{
			goto IL_038e;
		}
		goto IL_050a;
	}

	private Vector2 AnchorSpan()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0141: Expected O, but got I4
		//IL_014a: Expected O, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01c8: Expected O, but got I4
		//IL_02cd: Expected O, but got I4
		//IL_021b: Expected O, but got I
		//IL_0255: Expected O, but got I
		if ((object)_rectTransform == null)
		{
			goto IL_025e;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Transform parent = _rectTransform.parent;
		UnityEngine.Object obj4;
		UnityEngine.Object obj5;
		if ((object)parent != null)
		{
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			Transform transform = ((parent != obj2) ? null : parent);
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			obj4 = transform;
			obj5 = transform;
			if (!flag)
			{
				goto IL_008f;
			}
		}
		else
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj4 = null;
			obj5 = null;
			if (obj6 != null)
			{
				goto IL_008f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj5 == null;
		bool flag4 = !flag3;
		object obj7 = !flag4;
		object obj8 = 0;
		obj4 = obj5;
		if (obj7 != null)
		{
			goto IL_02c8;
		}
		goto IL_0160;
		IL_02c8:
		return (Vector2)flag3;
		IL_008f:
		flag3 = obj4 == null;
		bool flag5 = !flag3;
		obj8 = 0;
		if (flag5)
		{
			goto IL_0160;
		}
		goto IL_02c8;
		IL_0160:
		if ((object)obj4 != null)
		{
			Rect rect = ((RectTransform)obj4).rect;
			object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X0_v9+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF010]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF010]");
				Vector2 anchorMax = ((RectTransform)0).anchorMax;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF010]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF010]");
					return ((RectTransform)0).anchorMin;
				}
			}
		}
		goto IL_025e;
		IL_025e:
		return (Vector2)new NullReferenceException();
	}
}
