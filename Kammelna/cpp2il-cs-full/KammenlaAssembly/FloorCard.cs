using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class FloorCard : MonoBehaviour
{
	public SpriteRenderer floorCard;

	private CardsSprites cardsSprites;

	private BalootGame _game;

	private bool _isActive;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0065: Expected O, but got I
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00a1: Expected O, but got I
		//IL_00b1: Expected O, but got I4
		//IL_00ce: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)8;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 48;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X20_v4-10]");
		GameObject gameObject = ((Component)0).gameObject;
		gameObject.SetActive(value: false);
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)1760;
		floorCard.color = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj8);
		_game.OnGameStateUpdated += action;
	}

	private void OnGameStateUpdate()
	{
		//IL_0084: Expected O, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0184: Expected O, but got I
		//IL_0192: Expected I, but got O
		//IL_01a3: Expected O, but got I
		BalootGame game = _game;
		CardGameStage <Stage>k__BackingField = ((CardGame)game).<Stage>k__BackingField;
		if (<Stage>k__BackingField.<CurrentStage>k__BackingField == CardGameStage.CardGameStages.Bidding)
		{
			Sprite sprite = cardsSprites.GetFor(game.<FloorCard>k__BackingField);
			floorCard.sprite = sprite;
			bool flag = !_isActive;
			object obj = !flag;
			if (obj == null)
			{
				_isActive = true;
				int num = ShortcutExtensions.DOKill(floorCard);
				GameObject gameObject = floorCard.gameObject;
				gameObject.SetActive(value: true);
				TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleSprite.DOFade(floorCard, 1f, 0.4f);
			}
		}
		else if (_isActive)
		{
			_isActive = false;
			int num2 = ShortcutExtensions.DOKill(floorCard);
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleSprite.DOFade(floorCard, 0f, 0.4f);
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = (nint)0 + (nint)1752;
			TweenCallback tweenCallback = default(TweenCallback);
			tweenCallback..ctor(this, (IntPtr)obj3);
			object obj4 = (nint)0 + (nint)2456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		}
	}

	private void <OnGameStateUpdate>b__5_0()
	{
		GameObject gameObject = floorCard.gameObject;
		gameObject.SetActive(value: false);
	}
}
