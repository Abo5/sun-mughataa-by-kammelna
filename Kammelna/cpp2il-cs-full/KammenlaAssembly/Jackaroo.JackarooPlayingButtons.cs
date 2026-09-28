using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

namespace Jackaroo;

public class JackarooPlayingButtons : MonoBehaviour
{
	private Button sawaButton;

	private GameEventsChannel gameEventsChannel;

	private JackarooGame _game;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_011a: Expected O, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_013a: Expected O, but got I
		//IL_0164: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_009b: Expected I, but got O
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00de: Expected O, but got I
		//IL_00f6: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)128;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)832;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 48;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		((KGame)obj7).OnRoundStart += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj4);
		_game.OnGameStateUpdated += action2;
		Button button = sawaButton;
		object obj9 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj10 = (nint)0 + (nint)840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj10);
		button.m_OnClick.AddListener(unityAction);
	}

	private void OnGameStateUpdated()
	{
		UpdateButtons();
	}

	private void UpdateButtons()
	{
		//IL_002e: Expected O, but got I4
		//IL_0123: Expected O, but got I4
		//IL_016c: Expected O, but got I4
		bool isSpectator = _game.IsSpectator;
		bool flag = !isSpectator;
		object obj = !flag;
		if (obj == null)
		{
			CardGamePlayer myPlayer = _game.MyPlayer;
			if (myPlayer.IsHumanSeated)
			{
				CardGamePlayer myPlayer2 = _game.MyPlayer;
				if (myPlayer2.CanPlayCard)
				{
					CardGame game = _game;
					if (game.<SawaAllowed>k__BackingField)
					{
						List<Card> cardsOnFloor = game.CardsOnFloor;
						bool flag2 = Enumerable.Any((IEnumerable<object>)cardsOnFloor);
						bool flag3 = !flag2;
						object obj2 = !flag3;
						if (obj2 == null)
						{
							Room room = _game.Room;
							bool flag4 = SFSKammelnaRoomExtensions.IsOffline(room);
							bool flag5 = !flag4;
							object obj3 = !flag5;
							if (obj3 == null && !_game.IsTutorial)
							{
								ShowSawaButton();
								return;
							}
						}
					}
				}
			}
		}
		HideSawaButton();
	}

	private void ShowSawaButton()
	{
		//IL_0051: Expected O, but got I
		sawaButton.interactable = true;
		RectTransform target = UIExtensions.rectTransform(this);
		int num = ShortcutExtensions.DOKill(target);
		RectTransform rectTransform = UIExtensions.rectTransform(this);
		object obj = (nint)0 + (nint)2872;
		rectTransform.SetAsLastSibling();
		RectTransform target2 = UIExtensions.rectTransform(this);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target2, -328f, 0.5f, snapping: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	private void HideSawaButton()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)2872;
		sawaButton.interactable = false;
		RectTransform target = UIExtensions.rectTransform(this);
		int num = ShortcutExtensions.DOKill(target);
		RectTransform target2 = UIExtensions.rectTransform(this);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(target2, -732f, 0.5f, snapping: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	private void ShowSawaPanel()
	{
		gameEventsChannel.TriggerToggleSawaPanel();
	}
}
