using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class StatisticsAndHighlightsGameEndWidget : GameEndWidget
{
	private LayoutElement _layoutElement;

	private float widgetHeight;

	public Button StatisticsButton;

	public RectTransform StatisticsButtonSection;

	public StatisticsPopup StatisticsPopup;

	public HighlightsView highlights;

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		Button statisticsButton = StatisticsButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		statisticsButton.m_OnClick.AddListener(unityAction);
	}

	public override void PrepareAnimation(CardGameEndScores gameEnd)
	{
		//IL_009d: Expected O, but got I4
		//IL_0206: Expected O, but got I4
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_0220: Expected I4, but got O
		//IL_023c: Expected O, but got I4
		_layoutElement.preferredHeight = 0f;
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = StatisticsPopup.gameObject;
		gameObject2.SetActive(value: false);
		CardGameStatistics <CGStatistics>k__BackingField = gameEnd.<CGStatistics>k__BackingField;
		bool flag = ArraysExtensions.IsNullOrEmpty(<CGStatistics>k__BackingField.<StatisticsList>k__BackingField);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			StatisticsPopup.ResetStatPopup();
			CardGame cardGame = base.game;
			StatisticsPopup.SetUp(cardGame, gameEnd);
		}
		CardGameStatistics <CGStatistics>k__BackingField2 = gameEnd.<CGStatistics>k__BackingField;
		bool interactable;
		if (gameEnd.<CGStatistics>k__BackingField != null)
		{
			int? num = (int?)<CGStatistics>k__BackingField2.<StatisticsList>k__BackingField;
			if (<CGStatistics>k__BackingField2.<StatisticsList>k__BackingField != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v9 (System.Nullable`1<System.Int32>)+18]");
				int? num2 = 0;
				num = num2;
			}
			object obj2 = (object?)num >> 32;
			bool flag3 = (nint)obj2 < 0;
			bool flag4 = obj2 == null;
			object obj3 = obj2 ^ obj2;
			object obj4 = obj2 & obj3;
			bool flag5 = (nint)obj4 < 0;
			bool flag6 = flag3 == flag5;
			object obj5 = !flag4;
			object obj6 = flag6 & obj5;
			interactable = (byte)(obj6 & (object?)num) != 0;
			bool flag7 = (object)StatisticsButton == null;
			object obj7 = !flag7;
			if (obj7 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			interactable = false;
		}
		StatisticsButton.interactable = interactable;
		highlights.ResetHighlights();
	}

	public override void Populate(CardGameEndScores rankReport)
	{
		//IL_0085: Expected O, but got I4
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = StatisticsButtonSection.gameObject;
		gameObject2.SetActive(value: true);
		GameObject gameObject3 = StatisticsPopup.gameObject;
		gameObject3.SetActive(value: false);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOPreferredSize(_layoutElement, (Vector2)0, 0f);
		CardGame cardGame = base.game;
		highlights.InitializeHighlights(cardGame, rankReport);
		Sequence sequence = highlights.AnimateHighlights();
	}

	private void ShowStatisticsPopup()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		StatisticsPopup.ShowStatisticsPopup();
		CardGame cardGame = base.game;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		bool isSpectator = cardGame.IsSpectator;
		bool isPlayer = (byte)((isSpectator ? 1u : 0u) ^ 1u) != 0;
		ITrackEvent trackEvent = TrackerLibrary.EndGameStatsClicked(isPlayer);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	public override Sequence AnimatedPopulate(CardGameEndScores rankReport)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0135: Expected O, but got I4
		//IL_004b: Expected O, but got I4
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		TweenerCore<Vector2, Vector2, VectorOptions> t = DOTweenModuleUI.DOPreferredSize(_layoutElement, (Vector2)0, 0f);
		Sequence sequence2 = TweenSettingsExtensions.Append(sequence, t);
		Sequence sequence3 = TweenSettingsExtensions.AppendInterval(sequence, 0.1f);
		CardGame cardGame = base.game;
		if ((object)highlights != null)
		{
			highlights.InitializeHighlights(cardGame, rankReport);
			Sequence t2 = highlights.AnimateHighlights();
			Sequence sequence4 = TweenSettingsExtensions.Append(sequence, t2);
			Sequence sequence5 = TweenSettingsExtensions.AppendInterval(sequence, 0.75f);
			return sequence;
		}
		return (Sequence)(object)new NullReferenceException();
	}

	public override bool ShouldShow(CardGameEndScores rankReport)
	{
		//IL_016d: Expected I4, but got O
		//IL_015a: Expected O, but got I4
		//IL_01f8: Expected O, but got I4
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0212: Expected I4, but got O
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		if (rankReport != null)
		{
			CardGameStatistics <CGStatistics>k__BackingField = rankReport.<CGStatistics>k__BackingField;
			if (rankReport.<CGStatistics>k__BackingField != null)
			{
				List<Statistic> <StatisticsList>k__BackingField = <CGStatistics>k__BackingField.<StatisticsList>k__BackingField;
				if (<CGStatistics>k__BackingField.<StatisticsList>k__BackingField != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v13 (System.Collections.Generic.List`1<Statistic>)+18]");
					int? num = 0;
					object obj = default(object);
					if ((nint)obj >= 1)
					{
						object obj2 = (??)num & 1;
						if (obj2 != null)
						{
							return true;
						}
					}
				}
			}
			CardGameHighlights <CGHighlights>k__BackingField = rankReport.<CGHighlights>k__BackingField;
			if (rankReport.<CGHighlights>k__BackingField != null)
			{
				int? num2;
				if (<CGHighlights>k__BackingField.<Highlights>k__BackingField != null)
				{
					int count = ((Dictionary<object, int>)(object)<CGHighlights>k__BackingField.<Highlights>k__BackingField).Count;
					int? num = count;
					num2 = num;
				}
				else
				{
					num2 = (int?)(object)0;
				}
				object obj3 = (object?)num2 >> 32;
				bool flag = (nint)obj3 < 0;
				bool flag2 = obj3 == null;
				object obj4 = obj3 ^ obj3;
				object obj5 = obj3 & obj4;
				bool flag3 = (nint)obj5 < 0;
				bool flag4 = flag == flag3;
				object obj6 = !flag2;
				object obj7 = flag4 & obj6;
				return (byte)(obj7 & (object?)num2) != 0;
			}
			return false;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
