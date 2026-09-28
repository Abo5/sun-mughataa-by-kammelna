using System;
using System.Buffers.Text;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointsProgressBar : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<GameObject> <>9__15_0;

		public static Action<GameObject> <>9__15_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Reset>b__15_0(GameObject z)
		{
			z.SetActive(value: false);
		}

		internal void <Reset>b__15_1(GameObject z)
		{
			z.SetActive(value: false);
		}
	}

	public RectTransform PointsIndicator;

	public RectTransform PointsParent;

	public Image BlueProgressBar;

	public TextMeshProUGUI pointsToNextRankGray;

	public TextMeshProUGUI pointsToNextRankBlue;

	public TextMeshProUGUI pointsCurrent;

	public RankUI nextRank;

	public GameObject[] ZatsGrey;

	public GameObject[] ZatsBlue;

	private bool maxed;

	public void Initialize(PlayerRank prev, int maxSubRank, int minSubRank, int prePoints, int newPoints)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0117: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_017f: Invalid comparison between F8 and I4
		//IL_018e: Invalid comparison between F8 and I4
		//IL_01a6: Expected O, but got F8
		//IL_01b3: Expected O, but got F8
		//IL_01e8: Expected O, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_02c6: Invalid comparison between F8 and I4
		//IL_02d5: Invalid comparison between F8 and I4
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_02f6: Expected O, but got F8
		//IL_032b: Expected O, but got I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0358: Invalid comparison between F8 and I4
		//IL_0234: Expected F8, but got I4
		//IL_0378: Invalid comparison between F8 and I4
		//IL_024f: Expected F4, but got I4
		//IL_026a: Expected F4, but got I4
		Reset();
		if (prev.<Rank>k__BackingField == PlayerRank.Ranks.Master)
		{
			maxed = true;
		}
		else
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PlayerRank.Ranks rank = prev.<Rank>k__BackingField + 1;
			PlayerRank playerRank = default(PlayerRank);
			playerRank..ctor(rank);
			nextRank.SetRank(playerRank);
		}
		string text = IntegerExtensions.ToCommaSeparatedNumber(prePoints);
		pointsCurrent.text = text;
		string text2 = IntegerExtensions.ToCommaSeparatedNumber(maxSubRank);
		pointsToNextRankBlue.text = text2;
		TextMeshProUGUI textMeshProUGUI = pointsToNextRankGray;
		string text3 = IntegerExtensions.ToCommaSeparatedNumber(maxSubRank);
		textMeshProUGUI.text = text3;
		bool flag = !maxed;
		object obj2 = !flag;
		if (obj2 == null)
		{
			InitializeZatsIcon(prev.<SubRanksCount>k__BackingField);
		}
		object obj3 = prePoints - minSubRank;
		object obj4 = maxSubRank - minSubRank;
		double num = (double)obj3 / (double)obj4;
		double num2 = num - 1.0;
		bool flag2 = num2 < 0.0;
		bool flag3 = num2 == 0.0;
		object obj5 = num ^ 1.0;
		object obj6 = num ^ num2;
		object obj7 = obj5 & obj6;
		bool flag4 = (nint)obj7 < 0;
		bool flag5 = flag2 == flag4;
		object obj8 = !flag3;
		object obj9 = flag5 & obj8;
		object obj10 = ~obj9;
		double num3 = ((obj10 != null) ? num : 1.0);
		double num4 = num - 1065101558.0;
		bool flag6 = num4 < 0.0;
		bool flag7 = num4 == 0.0;
		object obj11 = num ^ 0x3F7C28F6;
		object obj12 = num ^ num4;
		object obj13 = obj11 & obj12;
		bool flag8 = (nint)obj13 < 0;
		bool flag9 = flag6 == flag8;
		object obj14 = !flag7;
		object obj15 = flag9 & obj14;
		object obj16 = ~obj15;
		double num5 = ((obj16 != null) ? num : 1065101558.0);
		float fillAmount = ((!(num < 1014350479.0)) ? ((float)num3) : 1.01435046E+09f);
		float num6 = ((!(num < 1014350479.0)) ? ((float)num5) : 1.01435046E+09f);
		BlueProgressBar.fillAmount = fillAmount;
		UIExtensions.SetAnchorX(PointsIndicator, num6);
		Vector2 anchorMax = PointsIndicator.anchorMax;
		FixPosition(num6);
	}

	public Sequence StartAnimation()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_031a: Expected O, but got I4
		//IL_01e6: Expected O, but got I
		//IL_022e: Expected O, but got I
		//IL_02a9: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67D3]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v25+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v25+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Sequence sequence = DOTween.Sequence();
		Transform pointsIndicator = PointsIndicator;
		bool flag2 = (object)PointsIndicator == null;
		Sequence sequence2 = sequence;
		if (!flag2)
		{
			goto IL_014e;
		}
		goto IL_02ce;
		IL_02ce:
		return (Sequence)(object)new NullReferenceException();
		IL_014e:
		Vector3 localScale = pointsIndicator.localScale;
		object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4024;
		object obj8 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = default(object);
		object obj10 = obj11 * obj11;
		object obj13 = default(object);
		object obj12 = obj13 * obj13;
		object obj14 = obj10 + obj12;
		object obj16 = default(object);
		object obj15 = obj16 * obj16;
		object obj17 = obj15 + obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
		object obj18 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v7+B8]");
		object obj19 = 0;
		if (obj17 < obj19)
		{
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(PointsIndicator, 1f, 0.3f);
			object obj20 = (nint)0 + (nint)2904;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween t = default(Tween);
			Sequence sequence3 = TweenSettingsExtensions.Join(sequence2, t);
			if ((object)pointsCurrent == null)
			{
				goto IL_02ce;
			}
			RectTransform rectTransform = pointsCurrent.rectTransform;
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPosX(rectTransform, 0f, 0.3f);
			object obj21 = (nint)0 + (nint)2872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween t2 = default(Tween);
			Sequence sequence4 = TweenSettingsExtensions.Join(sequence2, t2);
		}
		return sequence2;
		IL_007d:
		Sequence sequence5 = DOTween.Sequence();
		pointsIndicator = PointsIndicator;
		bool flag4 = (object)PointsIndicator == null;
		object obj22 = !flag4;
		sequence2 = sequence5;
		if (obj22 != null)
		{
			goto IL_014e;
		}
		goto IL_02ce;
	}

	public void FixCurrentValuePosition()
	{
		Vector2 anchorMax = PointsIndicator.anchorMax;
		float anchor = default(float);
		FixPosition(anchor);
	}

	private void FixPosition(float anchor)
	{
		//IL_0010: Invalid comparison between F4 and I
		//IL_0085: Invalid comparison between F4 and I
		//IL_00d5: Expected O, but got I4
		//IL_00aa: Expected O, but got I4
		//IL_0049: Expected O, but got I4
		//IL_0100: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6FBE038]");
		TMP_Text tMP_Text;
		TextAlignmentOptions alignment;
		if (anchor < 0f)
		{
			RectTransform rectTransform = UIExtensions.rectTransform(PointsParent);
			rectTransform.pivot = (Vector2)0;
			tMP_Text = pointsCurrent;
			alignment = TextAlignmentOptions.Right;
		}
		else
		{
			RectTransform rectTransform2 = UIExtensions.rectTransform(PointsParent);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [6FC2E08]");
			if (anchor > 0f)
			{
				rectTransform2.pivot = (Vector2)0;
				tMP_Text = pointsCurrent;
				alignment = TextAlignmentOptions.Left;
			}
			else
			{
				rectTransform2.pivot = (Vector2)0;
				tMP_Text = pointsCurrent;
				alignment = TextAlignmentOptions.Center;
			}
		}
		tMP_Text.alignment = alignment;
		RectTransform rectTransform3 = UIExtensions.rectTransform(pointsCurrent);
		rectTransform3.anchoredPosition = (Vector2)0;
	}

	public void InitializedNextRank(PlayerRank rank)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0095: Expected I, but got O
		//IL_00a5: Expected O, but got I
		//IL_00b5: Expected O, but got I
		if (rank.<Rank>k__BackingField == PlayerRank.Ranks.Master)
		{
			maxed = true;
			return;
		}
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank.Ranks rank2 = rank.<Rank>k__BackingField + 1;
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(rank2);
		RankUI rankUI = nextRank;
		nint num = (nint)rankUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6 (Il2CppClass<RankUI>)+1A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v6 (Il2CppClass<RankUI>)+1B0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v100 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void Reset()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I
		//IL_00ff: Expected O, but got I
		//IL_010f: Expected O, but got I
		//IL_0131: Expected O, but got I4
		//IL_0074: Expected O, but got I
		//IL_0084: Expected O, but got I
		//IL_0094: Expected O, but got I
		//IL_00b6: Expected O, but got I4
		//IL_026e: Expected O, but got I
		//IL_027e: Expected O, but got I
		//IL_02a0: Expected O, but got I4
		//IL_0169: Expected O, but got I4
		//IL_01ea: Expected O, but got I
		//IL_01fa: Expected O, but got I
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_0389: Expected O, but got I
		//IL_039a: Expected I, but got O
		//IL_03b8: Expected O, but got I
		//IL_02d0: Expected O, but got I4
		//IL_0199: Expected O, but got I
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		//IL_0409: Expected O, but got I
		//IL_041a: Expected I, but got O
		//IL_0438: Expected O, but got I
		//IL_033a: Expected O, but got I4
		//IL_0300: Expected O, but got I
		maxed = false;
		GameObject gameObject = nextRank.gameObject;
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2880;
		gameObject.SetActive(value: false);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v26+E4]");
		object obj4;
		Action<object> action;
		object obj6;
		object obj3;
		if ((nint)0 != 0)
		{
			obj3 = (nint)0 + (nint)2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v26+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v21+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v21+8]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				obj6 = obj3;
				goto IL_0147;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
			obj6 = (nint)0 + (nint)2160;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v26+B8]");
			obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v21+8]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v21+8]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj3 = obj6;
			if (obj7 == null)
			{
				goto IL_0147;
			}
		}
		goto IL_019e;
		IL_023d:
		TMP_Text tMP_Text;
		tMP_Text.isRightToLeftText = false;
		return;
		IL_021f:
		Action<object> action2;
		ArraysExtensions.ForEach(ZatsGrey, action2);
		tMP_Text = pointsCurrent;
		goto IL_023d;
		IL_019e:
		ArraysExtensions.ForEach(ZatsBlue, action);
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v10+E4]");
		object obj9;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v10+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v8+10]");
			action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v8+10]");
			if ((nint)0 != 0)
			{
				goto IL_021f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v10+B8]");
			obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v8+10]");
			action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v8+10]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 != null)
			{
				goto IL_021f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v10+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v14+B8]");
			obj9 = 0;
		}
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1280;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj9, (IntPtr)obj14);
		object obj15 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v13+B8]");
		object obj16 = (nint)0 + (nint)16;
		obj16 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ArraysExtensions.ForEach(ZatsGrey, action3);
		tMP_Text = pointsCurrent;
		bool flag5 = (object)pointsCurrent == null;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_023d;
		IL_0147:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X0_v26+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj19 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v27+B8]");
			obj4 = 0;
		}
		object obj20 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = (nint)0 + (nint)1272;
		Action<object> action4 = default(Action<object>);
		action4..ctor(obj4, (IntPtr)obj21);
		object obj22 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v26+B8]");
		object obj23 = (nint)0 + (nint)8;
		obj23 = action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action4;
		obj3 = obj6;
		goto IL_019e;
	}

	private void SetNumberTexts(int prePoints, int maxSubRank)
	{
		//IL_0045: Expected I, but got O
		//IL_0055: Expected O, but got I
		//IL_0065: Expected O, but got I
		string text = IntegerExtensions.ToCommaSeparatedNumber(maxSubRank);
		pointsToNextRankBlue.text = text;
		TextMeshProUGUI textMeshProUGUI = pointsToNextRankGray;
		string text2 = IntegerExtensions.ToCommaSeparatedNumber(maxSubRank);
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v59 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void InitializeZatsIcon(int index)
	{
		//IL_0065: Expected O, but got I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_012e: Expected O, but got I
		//IL_0150: Expected O, but got I4
		GameObject[] zatsBlue = ZatsBlue;
		GameObject gameObject;
		if (ZatsBlue != null)
		{
			if (index < zatsBlue.Length)
			{
				bool flag = index < zatsBlue.Length;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_01cb;
				}
				object obj2 = ZatsBlue + index;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v5+20]");
					((GameObject)0).SetActive(value: true);
					GameObject[] zatsGrey = ZatsGrey;
					if (ZatsGrey != null)
					{
						bool flag2 = index < zatsGrey.Length;
						object obj3 = !flag2;
						if (obj3 != null)
						{
							goto IL_01cb;
						}
						object obj4 = ZatsGrey + index;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v7+20]");
						gameObject = (GameObject)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v7+20]");
						bool flag3 = (nint)0 == 0;
						object obj5 = !flag3;
						if (obj5 != null)
						{
							goto IL_01ae;
						}
					}
				}
			}
			else if ((object)nextRank != null)
			{
				gameObject = nextRank.gameObject;
				if ((object)gameObject != null)
				{
					goto IL_01ae;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01cb;
		IL_01ae:
		gameObject.SetActive(value: true);
		return;
		IL_01cb:
		throw new IndexOutOfRangeException();
	}
}
