using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TrianglarProgress : MonoBehaviour
{
	private Image fill;

	private Image rankingValueIndicator;

	private Image border;

	private TextMeshProUGUI rankingPercentage;

	private TextMeshProUGUI rankingText;

	private Sprite GreenFill;

	private Sprite YellowFill;

	private Sprite BlackFill;

	private Sprite WhiteCircle;

	private Sprite GoldCircle;

	public float FillPercentage = 0.5f;

	private int PercentageFromTop;

	public float Time = 1.3f;

	public Ease Ease;

	private float? fullYPos;

	private float? indicatorPos;

	private bool isInitialized;

	private void OnEnable()
	{
		if (isInitialized)
		{
			StartAnimating();
		}
	}

	public void Initialize(int percentageFromTop, int rankingValue)
	{
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I4
		//IL_01ba: Expected F4, but got I4
		//IL_0133: Expected O, but got I4
		//IL_0017: Expected I4, but got I8
		//IL_0048: Invalid comparison between F8 and I4
		//IL_0057: Invalid comparison between F8 and I4
		//IL_006f: Expected O, but got F8
		//IL_007c: Expected O, but got F8
		//IL_00b1: Expected O, but got I4
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_03c8: Invalid comparison between F8 and I4
		//IL_0314: Expected O, but got I4
		//IL_00fd: Expected F8, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		PercentageFromTop = percentageFromTop;
		UnityEngine.Object obj8;
		UnityEngine.Object obj10;
		if (rankingValue != 0)
		{
			int num = (int)(percentageFromTop / 3267887104L);
			double num2 = (double)num + 1.0;
			double num3 = num2 - 1.0;
			bool flag = num3 < 0.0;
			bool flag2 = num3 == 0.0;
			object obj2 = num2 ^ 1.0;
			object obj3 = num2 ^ num3;
			object obj4 = obj2 & obj3;
			bool flag3 = (nint)obj4 < 0;
			bool flag4 = flag == flag3;
			object obj5 = !flag2;
			object obj6 = flag4 & obj5;
			object obj7 = ~obj6;
			double num4 = ((obj7 != null) ? num2 : 1.0);
			double num5 = ((!(num2 < 0.0)) ? num4 : 0.0);
			FillPercentage = (float)num5;
			obj8 = rankingText;
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v23+E4]");
			bool flag5 = (nint)0 == 0;
			float num6 = (float)num5;
			obj10 = rankingText;
			if (!flag5)
			{
				goto IL_010f;
			}
		}
		else
		{
			FillPercentage = 0f;
			object obj9 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v23+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			obj8 = rankingText;
			float num6 = 0f;
			obj10 = rankingText;
			if (obj11 != null)
			{
				goto IL_010f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!(obj10 != null))
		{
			goto IL_0141;
		}
		goto IL_0208;
		IL_010f:
		bool flag7 = obj8 != null;
		bool flag8 = !flag7;
		object obj12 = !flag8;
		if (obj12 == null)
		{
			goto IL_0141;
		}
		goto IL_0208;
		IL_02dd:
		fill.sprite = YellowFill;
		Image image = rankingValueIndicator;
		bool flag9 = (object)rankingValueIndicator == null;
		object obj13 = !flag9;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0347;
		IL_0252:
		int percentageFromTop2;
		if (percentageFromTop2 == 0)
		{
			goto IL_02dd;
		}
		GameObject gameObject;
		bool active;
		if (percentageFromTop2 < 11)
		{
			fill.sprite = BlackFill;
			rankingValueIndicator.sprite = GoldCircle;
			gameObject = border.gameObject;
			active = true;
			goto IL_0432;
		}
		fill.sprite = GreenFill;
		image = rankingValueIndicator;
		goto IL_0347;
		IL_0141:
		percentageFromTop2 = PercentageFromTop;
		if (PercentageFromTop <= 50)
		{
			goto IL_0252;
		}
		goto IL_02dd;
		IL_0208:
		int num7 = default(int);
		string text = num7.ToString();
		rankingText.text = text;
		percentageFromTop2 = PercentageFromTop;
		if (PercentageFromTop <= 50)
		{
			goto IL_0252;
		}
		goto IL_02dd;
		IL_0347:
		image.sprite = WhiteCircle;
		gameObject = border.gameObject;
		active = false;
		goto IL_0432;
		IL_0432:
		gameObject.SetActive(active);
		isInitialized = true;
		StartAnimating();
	}

	private void TestAnimation()
	{
		//IL_000b: Invalid comparison between F4 and I4
		//IL_003e: Expected I4, but got F4
		//IL_002f: Expected I4, but got I8
		int percentageFromTop = (int)((FillPercentage != 2.139095E+09f) ? ((int)FillPercentage) : 2147483648L);
		Initialize(percentageFromTop, 0);
		StartAnimating();
	}

	private unsafe void StartAnimating()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_0342: Expected O, but got I4
		//IL_01ee: Expected O, but got I
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_026b: Expected O, but got I
		//IL_02f2: Expected O, but got I4
		RectTransform rectTransform = fill.rectTransform;
		int num = ShortcutExtensions.DOKill(rectTransform);
		RectTransform rectTransform2 = rankingValueIndicator.rectTransform;
		int num2 = ShortcutExtensions.DOKill(rectTransform2);
		int num3 = ShortcutExtensions.DOKill(rankingPercentage);
		float? num4 = (float?)(object)(this + 128);
		object obj = (??)num4 & 1;
		bool flag = obj == null;
		object obj2 = !flag;
		float value = default(float);
		float? num5;
		if (obj2 == null)
		{
			RectTransform rectTransform3 = fill.rectTransform;
			Vector2 anchoredPosition = rectTransform3.anchoredPosition;
			num5 = value;
			num4 = num5;
		}
		float? num6 = (float?)(object)(this + 136);
		object obj3 = (??)num6 & 1;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			RectTransform rectTransform4 = rankingValueIndicator.rectTransform;
			Vector2 anchoredPosition2 = rectTransform4.anchoredPosition;
			num5 = value;
			num6 = num5;
		}
		RectTransform rectTransform5 = fill.rectTransform;
		num5 = 0f;
		float? y = 0f;
		UIExtensions.MoveTo(rectTransform5, isWorldPositions: false, num5, y);
		RectTransform rectTransform6 = rankingValueIndicator.rectTransform;
		float? x = 0f;
		float? y2 = 0f;
		UIExtensions.MoveTo(rectTransform6, isWorldPositions: false, x, y2);
		TextMeshProExtensions.SetNumber(rankingPercentage, 100);
		object obj5 = (nint)0 + (nint)2872;
		RectTransform rectTransform7 = fill.rectTransform;
		float value2 = ((float?*)num4)->Value;
		float endValue = value2 * FillPercentage;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(rectTransform7, endValue, Time);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj6 = typeof(SqlSingle[]) + 3912;
		object obj7 = (nint)0 + (nint)2944;
		RectTransform rectTransform8 = rankingValueIndicator.rectTransform;
		float value3 = ((float?*)num6)->Value;
		float endValue2 = value3 * FillPercentage;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPosY(rectTransform8, endValue2, Time);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tweener tweener = AnimationExtensions.DONumber(rankingPercentage, PercentageFromTop, Time);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}
}
