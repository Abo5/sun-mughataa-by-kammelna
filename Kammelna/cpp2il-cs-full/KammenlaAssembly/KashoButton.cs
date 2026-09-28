using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class KashoButton : MonoBehaviour
{
	private Button submitButton;

	private CardGame game;

	private bool isShown;

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0062: Expected O, but got I
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_00be: Expected O, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_011f: Expected I, but got O
		Button button = submitButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3984;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = (nint)0 + (nint)24;
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)3976;
		button.m_OnClick.AddListener(unityAction);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj9 = this + 40;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		((KGame)obj9).OnGameStateUpdated += action;
	}

	private void Submit()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		game.SendKasho();
		HideButton();
		CardGame cardGame = game;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		int num = ~cardGame.<RoundBidder>k__BackingField;
		bool isAfterBid = (byte)(num >> 31) != 0;
		ITrackEvent trackEvent = TrackerLibrary.GameKashoButtonClicked(isAfterBid);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}

	private void OnGameStateUpdated()
	{
		//IL_0029: Expected O, but got I4
		bool isSpectator = game.IsSpectator;
		bool flag = !isSpectator;
		object obj = !flag;
		if (obj == null)
		{
			CardGamePlayer myPlayer = game.MyPlayer;
			if (myPlayer.IsHumanSeated)
			{
				CardGamePlayer myPlayer2 = game.MyPlayer;
				if (myPlayer2.<HasKasho>k__BackingField)
				{
					ShowButton();
					return;
				}
			}
		}
		HideButton();
	}

	private void HideButton()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2872;
		submitButton.interactable = false;
		RectTransform target = UIExtensions.rectTransform(this);
		int num = ShortcutExtensions.DOKill(target);
		RectTransform target2 = UIExtensions.rectTransform(this);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target2, -732f, 0.5f, snapping: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		isShown = false;
	}

	private void ShowButton()
	{
		//IL_0049: Expected O, but got I4
		//IL_00cb: Expected O, but got I
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0121: Expected O, but got I4
		CardGamePlayer myPlayer = game.MyPlayer;
		submitButton.interactable = myPlayer.<CanKasho>k__BackingField;
		bool flag = !isShown;
		object obj = !flag;
		if (obj == null)
		{
			RectTransform target = UIExtensions.rectTransform(this);
			int num = ShortcutExtensions.DOKill(target);
			RectTransform rectTransform = UIExtensions.rectTransform(this);
			rectTransform.SetAsLastSibling();
			RectTransform target2 = UIExtensions.rectTransform(this);
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target2, -328f, 0.5f, snapping: true);
			object obj2 = (nint)0 + (nint)2872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			ITrackEvent trackEvent = TrackerLibrary.GameKashoButtonViewed();
			object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Tracker.DesignEvent(trackEvent);
			isShown = true;
		}
	}
}
