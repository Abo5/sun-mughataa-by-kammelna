using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Server.Models;
using Spine;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentGameScoreGameEndWidget : GameEndWidget
{
	[StructLayout((LayoutKind)3)]
	private struct <>c__DisplayClass16_0
	{
		public CardGameEndScores gameEnd;
	}

	private sealed class <>c__DisplayClass17_0
	{
		public TournamentGameScoreGameEndWidget <>4__this;

		public CardGameEndScores rankReport;

		internal void <AnimatedPopulate>g__pop|0()
		{
			//IL_0021: Expected I, but got O
			//IL_0031: Expected O, but got I
			//IL_0041: Expected O, but got I
			TournamentGameScoreGameEndWidget tournamentGameScoreGameEndWidget = <>4__this;
			CardGameEndScores cardGameEndScores = rankReport;
			nint num = (nint)tournamentGameScoreGameEndWidget;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v2 (Il2CppClass<TournamentGameScoreGameEndWidget>)+188]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v5 @ X8_v2 (Il2CppClass<TournamentGameScoreGameEndWidget>)+190]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v6 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private LayoutElement _layoutElement;

	private float widgetHeight;

	private EndGameScore WonScore;

	private EndGameScore LostScore;

	private Image CongratsDisplay;

	private Sprite firstPlaceSprite;

	private Sprite secondPlaceSprite;

	private TournamentPrizeInitializer prize;

	private TournamentTypeIcons _tournamentTypeIcons;

	private Image tournamentTypeIcon;

	private Image haloImage;

	private Image lightBeamsImage;

	private ParticleSystem ps;

	private TournamentMatchInfo matchInfo
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00b2: Expected O, but got I
			//IL_00dc: Expected O, but got I4
			//IL_005c: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 872;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6845]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2248;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2248;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			TournamentMatchInfo result = default(TournamentMatchInfo);
			return result;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			TournamentMatchInfo result2 = default(TournamentMatchInfo);
			return result2;
		}
	}

	public override void PrepareAnimation(CardGameEndScores gameEnd)
	{
		//IL_00a2: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_0130: Expected O, but got I4
		_layoutElement.preferredHeight = 0f;
		GameObject gameObject = WonScore.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = LostScore.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = base.gameObject;
		gameObject3.SetActive(value: true);
		Transform transform = haloImage.transform;
		transform.localScale = (Vector3)0;
		Transform transform2 = lightBeamsImage.transform;
		transform2.localScale = (Vector3)0;
		RectTransform rectTransform = UIExtensions.rectTransform(prize);
		Vector2 anchoredPosition = rectTransform.anchoredPosition;
		rectTransform.anchoredPosition = (Vector2)0;
		GameObject gameObject4 = tournamentTypeIcon.gameObject;
		gameObject4.SetActive(value: false);
		ps.Stop();
	}

	public override void Populate(CardGameEndScores gameEnd)
	{
		//IL_0037: Expected O, but got I4
		//IL_0065: Expected O, but got I4
		//IL_007b: Expected O, but got I
		//IL_0057: Expected O, but got I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0106: Expected O, but got I4
		//IL_016f: Expected O, but got I4
		//IL_0178: Expected O, but got I4
		//IL_05f0: Expected I4, but got O
		//IL_05f0: Expected O, but got I
		//IL_0158: Expected O, but got I4
		//IL_0161: Expected O, but got I4
		//IL_0269: Expected O, but got I4
		//IL_0283: Expected O, but got I4
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_0308: Expected O, but got I
		//IL_03af: Expected O, but got I
		//IL_03d9: Expected O, but got I4
		//IL_038a: Expected O, but got I4
		//IL_0331: Expected O, but got I
		//IL_0459: Expected O, but got I4
		//IL_047e: Expected O, but got I
		//IL_052f: Expected O, but got I4
		//IL_04ec: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		CardGameEndScores cardGameEndScores = default(CardGameEndScores);
		bool flag = ShowCongrats(cardGameEndScores);
		bool flag2 = !flag;
		object obj = !flag2;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			object obj3 = 56;
		}
		else
		{
			object obj3 = 64;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentGameScoreGameEndWidget)+v57 @ X8_v2]");
		GameObject gameObject = ((Component)0).gameObject;
		gameObject.SetActive(value: true);
		if (flag)
		{
			SetCongratsImage(cardGameEndScores);
		}
		CardGame cardGame = base.game;
		object obj4;
		if (cardGame.IsSpectator)
		{
			obj4 = cardGameEndScores + 20;
			object obj5 = 24;
			CardGameEndScores cardGameEndScores2 = cardGameEndScores;
		}
		else
		{
			CardGame cardGame2 = base.game;
			int myTeamIndex = cardGame2.MyTeamIndex;
			object obj6;
			if (myTeamIndex == 1)
			{
				obj6 = 20;
				object obj5 = 24;
			}
			else
			{
				obj6 = 24;
				object obj5 = 20;
			}
			obj4 = (object)cardGameEndScores + obj6;
			CardGameEndScores cardGameEndScores2 = cardGameEndScores;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentGameScoreGameEndWidget)+v57 @ X8_v2]");
		nint num = 0;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v4 (CardGameEndScores)+v127 @ X9_v3]");
		((EndGameScore)num).SetupScore((int)obj7, 0);
		TournamentEndGameReport <tournamentReport>k__BackingField = cardGameEndScores.<tournamentReport>k__BackingField;
		PrizeLevel level;
		object obj11;
		if (<tournamentReport>k__BackingField.isFinalMatch && <tournamentReport>k__BackingField.IsMatchOver)
		{
			CardGame cardGame3 = base.game;
			if (!cardGame3.IsSpectator)
			{
				CardGame cardGame4 = base.game;
				int myTeamIndex2 = cardGame4.MyTeamIndex;
				object obj8 = myTeamIndex2 - cardGameEndScores.<WinnerTeamIndex>k__BackingField;
				bool flag3 = obj8 == null;
				object obj9 = !flag3;
				object obj10 = ~obj9;
				level = ((obj10 != null) ? PrizeLevel.First : PrizeLevel.Second);
				GameObject gameObject2 = prize.gameObject;
				gameObject2.SetActive(value: true);
				obj11 = typeof(Queue<string>) + 872;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6845]");
				object obj12 = (nint)0 & (nint)1;
				object obj15;
				object obj13;
				if (obj12 != null)
				{
					obj13 = (nint)0 + (nint)2248;
					object obj14 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v56+E4]");
					bool flag4 = (nint)0 == 0;
					obj15 = obj13;
					if (!flag4)
					{
						goto IL_0366;
					}
				}
				else
				{
					_ = 1;
					obj13 = (nint)0 + (nint)2248;
					object obj14 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v56+E4]");
					bool flag5 = (nint)0 == 0;
					object obj16 = !flag5;
					obj15 = obj13;
					if (obj16 != null)
					{
						goto IL_0366;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				obj13 = obj15;
				goto IL_0415;
			}
		}
		GameObject gameObject3 = prize.gameObject;
		gameObject3.SetActive(value: false);
		return;
		IL_04c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
		bool flag6 = (object)tournamentMatchInfo == null;
		object obj17 = !flag6;
		if (obj17 != null)
		{
			goto IL_0556;
		}
		goto IL_05c8;
		IL_0556:
		TournamentData tournament = tournamentMatchInfo.Tournament;
		Sprite sprite = _tournamentTypeIcons.GetSprite(tournament.<Type>k__BackingField);
		tournamentTypeIcon.sprite = sprite;
		GameObject gameObject4 = tournamentTypeIcon.gameObject;
		gameObject4.SetActive(value: true);
		goto IL_05c1;
		IL_0415:
		TournamentMatchInfo tournamentMatchInfo2 = default(TournamentMatchInfo);
		TournamentData tournament2 = tournamentMatchInfo2.Tournament;
		bool flag7 = prize.Initialize(tournament2, level);
		bool flag8 = !flag7;
		object obj18 = !flag8;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6845]");
			object obj19 = (nint)0 & (nint)1;
			if (obj19 != null)
			{
				object obj20 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v41+E4]");
				if ((nint)0 != 0)
				{
					goto IL_04c8;
				}
			}
			else
			{
				_ = 1;
				object obj20 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X0_v41+E4]");
				bool flag9 = (nint)0 == 0;
				object obj21 = !flag9;
				if (obj21 != null)
				{
					goto IL_04c8;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			goto IL_0556;
		}
		goto IL_05c1;
		IL_05c1:
		AnimateEffect();
		return;
		IL_05c8:
		throw new NullReferenceException();
		IL_0366:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag10 = (object)tournamentMatchInfo2 == null;
		object obj22 = !flag10;
		if (obj22 != null)
		{
			goto IL_0415;
		}
		goto IL_05c8;
	}

	public override DG.Tweening.Sequence AnimatedPopulate(CardGameEndScores rankReport)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I4
		//IL_00ff: Expected I, but got O
		//IL_012f: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			object obj5 = (nint)0 + (nint)3888;
			object obj6 = obj2 + 16;
			obj6 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj2 + 24;
			obj7 = rankReport;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DG.Tweening.Sequence sequence = DOTween.Sequence();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(obj2, (IntPtr)obj5);
			DG.Tweening.Sequence sequence2 = TweenSettingsExtensions.AppendCallback(sequence, tweenCallback);
			TweenerCore<Vector2, Vector2, VectorOptions> t = DOTweenModuleUI.DOPreferredSize(_layoutElement, (Vector2)0, 0f);
			DG.Tweening.Sequence sequence3 = TweenSettingsExtensions.Append(sequence, t);
			return sequence;
		}
		return (DG.Tweening.Sequence)(object)new NullReferenceException();
	}

	public override bool ShouldShow(CardGameEndScores rankReport)
	{
		return true;
	}

	private bool ShowCongrats(CardGameEndScores rankReport)
	{
		//IL_03b3: Expected I4, but got O
		//IL_02d0: Expected O, but got I4
		//IL_00da: Expected O, but got I4
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_0104: Expected O, but got I
		//IL_01ab: Expected O, but got I
		//IL_01d5: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		//IL_012d: Expected O, but got I
		//IL_025e: Expected O, but got I4
		//IL_0278: Expected O, but got I4
		//IL_0342: Expected O, but got I4
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected I4, but got Unknown
		CardGame cardGame = base.game;
		TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
		if ((object)cardGame != null)
		{
			if (cardGame.IsSpectator)
			{
				goto IL_002f;
			}
			if (rankReport != null)
			{
				TournamentEndGameReport <tournamentReport>k__BackingField = rankReport.<tournamentReport>k__BackingField;
				if (rankReport.<tournamentReport>k__BackingField != null)
				{
					if (!<tournamentReport>k__BackingField.isFinalMatch || !rankReport.<tournamentReport>k__BackingField.IsMatchOver)
					{
						goto IL_03da;
					}
					object obj = 152985600;
					object obj2 = typeof(Queue<string>) + 872;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6845]");
					object obj3 = (nint)0 & (nint)1;
					if (obj3 != null)
					{
						object obj4 = (nint)0 + (nint)2248;
						object obj5 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v22+E4]");
						bool flag = (nint)0 == 0;
						object obj6 = obj4;
						if (!flag)
						{
							goto IL_0162;
						}
					}
					else
					{
						_ = 1;
						object obj4 = (nint)0 + (nint)2248;
						object obj5 = obj2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v22+E4]");
						bool flag2 = (nint)0 == 0;
						object obj7 = !flag2;
						object obj6 = obj4;
						if (obj7 != null)
						{
							goto IL_0162;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					if ((object)tournamentMatchInfo != null)
					{
						goto IL_0221;
					}
				}
			}
		}
		goto IL_03a5;
		IL_0221:
		TournamentData tournament = tournamentMatchInfo.Tournament;
		if (tournament != null)
		{
			object obj8 = tournament.<Type>k__BackingField - 3;
			bool flag3 = (nint)obj8 < 2;
			object obj9 = !flag3;
			object obj10 = ~obj9;
			if (obj10 != null)
			{
				goto IL_002f;
			}
			if (tournament.<Type>k__BackingField != TournamentType.Public)
			{
				goto IL_03da;
			}
			CardGame cardGame2 = base.game;
			if ((object)cardGame2 != null)
			{
				int myTeamIndex = cardGame2.MyTeamIndex;
				if (rankReport.<WinnerTeamIndex>k__BackingField == myTeamIndex)
				{
					goto IL_002f;
				}
				TournamentMatchInfo tournamentMatchInfo2 = ((TournamentGameScoreGameEndWidget)myTeamIndex).matchInfo;
				if ((object)tournamentMatchInfo2 != null)
				{
					TournamentData tournament2 = tournamentMatchInfo2.Tournament;
					if (tournament2 != null)
					{
						return (byte)((??)tournament2.<SecondPrize>k__BackingField & 1) != 0;
					}
				}
			}
		}
		goto IL_03a5;
		IL_002f:
		return true;
		IL_03da:
		CardGame cardGame3 = base.game;
		if ((object)cardGame3 != null)
		{
			int myTeamIndex2 = cardGame3.MyTeamIndex;
			object obj11 = rankReport.<WinnerTeamIndex>k__BackingField - myTeamIndex2;
			return obj11 == null;
		}
		goto IL_03a5;
		IL_03a5:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0162:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag4 = (object)tournamentMatchInfo == null;
		object obj12 = !flag4;
		if (obj12 != null)
		{
			goto IL_0221;
		}
		goto IL_03a5;
	}

	private void SetCongratsImage(CardGameEndScores rankReport)
	{
		//IL_0101: Expected O, but got I4
		//IL_0118: Expected O, but got I
		//IL_00e0: Expected O, but got I4
		//IL_00f7: Expected O, but got I
		TournamentEndGameReport <tournamentReport>k__BackingField = rankReport.<tournamentReport>k__BackingField;
		if (!<tournamentReport>k__BackingField.isFinalMatch || !<tournamentReport>k__BackingField.IsMatchOver)
		{
			return;
		}
		CardGame cardGame = base.game;
		if (!cardGame.IsSpectator)
		{
			CardGame cardGame2 = base.game;
			int myTeamIndex = cardGame2.MyTeamIndex;
			if (rankReport.<WinnerTeamIndex>k__BackingField == myTeamIndex)
			{
				object obj = 80;
				Image congratsDisplay = CongratsDisplay;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentGameScoreGameEndWidget)+v121 @ X8_v5]");
				congratsDisplay.sprite = (Sprite)0;
			}
			else
			{
				object obj2 = 88;
				Image congratsDisplay2 = CongratsDisplay;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentGameScoreGameEndWidget)+v122 @ X8_v4]");
				congratsDisplay2.sprite = (Sprite)0;
			}
		}
	}

	private void AnimateEffect()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01a2: Expected O, but got I4
		//IL_0058: Expected O, but got I
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_01c8: Expected O, but got I
		//IL_01e2: Expected F4, but got I
		//IL_01e2: Expected O, but got I4
		//IL_0214: Expected O, but got I
		//IL_022e: Expected F4, but got I
		//IL_022e: Expected O, but got I4
		//IL_00fd: Expected O, but got I
		//IL_0260: Expected O, but got I
		//IL_029f: Expected O, but got I
		//IL_02ba: Expected O, but got I4
		//IL_011d: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_02f6: Expected O, but got I
		//IL_032e: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		RectTransform rectTransform = UIExtensions.rectTransform(prize);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DG.Tweening.Sequence s = DOTween.Sequence();
		DG.Tweening.Sequence sequence = TweenSettingsExtensions.AppendInterval(s, 1.5f);
		object obj4 = (nint)0 + (nint)2872;
		Vector2 anchoredPosition = rectTransform.anchoredPosition;
		object obj5 = default(object);
		float endValue = (float)obj5 + 1.1339039E+09f;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(rectTransform, endValue, 0.8f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t = default(Tween);
		DG.Tweening.Sequence sequence2 = TweenSettingsExtensions.Append(s, t);
		Transform target = haloImage.transform;
		object obj6 = typeof(UsageHint) + 816;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v10+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v11+C]");
		TweenerCore<Vector3, Vector3, VectorOptions> t2 = ShortcutExtensions.DOScale(target, (Vector3)0, 0f);
		DG.Tweening.Sequence sequence3 = TweenSettingsExtensions.Append(s, t2);
		Transform target2 = lightBeamsImage.transform;
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v14+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v15+C]");
		TweenerCore<Vector3, Vector3, VectorOptions> t3 = ShortcutExtensions.DOScale(target2, (Vector3)0, 0f);
		DG.Tweening.Sequence sequence4 = TweenSettingsExtensions.Join(s, t3);
		object obj11 = (nint)0 + (nint)3016;
		Transform target3 = haloImage.transform;
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v18+B8]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v19+C]");
		float num = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v15+14]");
		float duration = num * 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v19+14]");
		object obj14 = (nint)0 * (nint)1036831949;
		float elasticity = default(float);
		Tweener tweener = ShortcutExtensions.DOPunchScale(target3, (Vector3)0, duration, 0, elasticity);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059384");
		Tween t4 = default(Tween);
		DG.Tweening.Sequence sequence5 = TweenSettingsExtensions.Append(s, t4);
		object obj15 = (nint)0 + (nint)2944;
		object obj16 = (nint)0 + (nint)2408;
		Transform target4 = lightBeamsImage.transform;
		object obj17 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v24+B8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v25+48]");
		float duration2 = 0f * (float)obj14;
		Tweener tweener2 = ShortcutExtensions.DOBlendableRotateBy(target4, (Vector3)0, duration2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059384");
		Tween t5 = default(Tween);
		DG.Tweening.Sequence sequence6 = TweenSettingsExtensions.Join(s, t5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		ps.Play();
	}

	internal static int <Populate>g__GetTeamScore|16_0(int team, ref <>c__DisplayClass16_0 P_1)
	{
		//IL_00ab: Expected I4, but got O
		//IL_0090: Expected O, but got I4
		//IL_0058: Expected O, but got I4
		object obj = P_1;
		if (team == 1)
		{
			if ((object)P_1 != null)
			{
				object obj2 = 20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1+v21 @ X9_v2]");
				return 0;
			}
		}
		else if ((object)P_1 != null)
		{
			object obj3 = 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1+v41 @ X9_v1]");
			return 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}
}
