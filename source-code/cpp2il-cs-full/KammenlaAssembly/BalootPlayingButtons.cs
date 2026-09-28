using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.Baloot.Tutorial;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class BalootPlayingButtons : MonoBehaviour
{
	private Button catchButton;

	private Button projectsButton;

	private Button sawaButton;

	private Toggle EkkaToggle;

	private GameObject ManualEkkaBlocker;

	private GameEventsChannel gameEventsChannel;

	private TextMeshProUGUI fireSawaPriceLabel;

	private StoreItem fireSawa;

	private BalootGame _game;

	private BaseToggler fireSawaToggler;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_046f: Expected O, but got I
		//IL_0499: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0074: Expected O, but got I
		//IL_00bd: Expected I, but got O
		//IL_00ee: Expected I, but got O
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0113: Expected O, but got I
		//IL_013f: Expected I, but got O
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0182: Expected O, but got I
		//IL_019a: Expected I, but got O
		//IL_01ab: Expected O, but got I
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01ec: Expected O, but got I
		//IL_0204: Expected I, but got O
		//IL_0236: Expected O, but got I
		//IL_024e: Expected I, but got O
		//IL_0280: Expected O, but got I
		//IL_0298: Expected I, but got O
		//IL_02c0: Expected O, but got I
		//IL_02cc: Expected O, but got I
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_0310: Expected I, but got O
		//IL_0321: Expected O, but got I
		//IL_034d: Expected I, but got O
		//IL_035e: Expected O, but got I
		//IL_038a: Expected I, but got O
		//IL_039b: Expected O, but got I
		//IL_03a7: Expected O, but got I
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03e7: Expected I, but got O
		//IL_040d: Expected I, but got O
		//IL_043c: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)8;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 96;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)2280;
		if (((KGame)obj5).IsReplay)
		{
			HideContainer();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj8);
		_game.OnRoundStart += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj8);
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj10 = (nint)0 + (nint)2272;
		_game.OnGameStateUpdated += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action3 = default(Action<bool>);
		action3..ctor((object)this, (IntPtr)obj10);
		_game.OnEkkaDeclarationChanged += action3;
		Toggle ekkaToggle = EkkaToggle;
		object obj11 = typeof(TypeConverter<ushort, char>) + 360;
		object obj12 = (nint)0 + (nint)2328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor((object)this, (IntPtr)obj12);
		object obj13 = (nint)0 + (nint)832;
		ekkaToggle.onValueChanged.AddListener(unityAction);
		Button button = catchButton;
		object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj15 = (nint)0 + (nint)2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj15);
		button.m_OnClick.AddListener(unityAction2);
		Button button2 = projectsButton;
		object obj16 = (nint)0 + (nint)2312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj16);
		button2.m_OnClick.AddListener(unityAction3);
		Button button3 = sawaButton;
		object obj17 = (nint)0 + (nint)2320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(this, (IntPtr)obj17);
		button3.m_OnClick.AddListener(unityAction4);
		object obj18 = (nint)0 + (nint)3624;
		object obj19 = (nint)0 + (nint)2296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj20 = this + 104;
		object obj21 = default(object);
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj19);
		object obj22 = (nint)0 + (nint)2256;
		gameEventsChannel.ShakeProjectsButton += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj22);
		object obj23 = (nint)0 + (nint)2264;
		gameEventsChannel.OnActivateFireMode += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action6 = default(Action);
		action6..ctor(this, (IntPtr)obj23);
		object obj24 = (nint)0 + (nint)2288;
		object obj25 = (nint)0 + (nint)2248;
		object obj26 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		gameEventsChannel.OnDeactivateFireMode += action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action7 = default(Action);
		action7..ctor(this, (IntPtr)obj24);
		StorePricing.OnPricingChanged += action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action8 = default(Action);
		action8..ctor(this, (IntPtr)obj25);
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X0_v53+E4]");
		bool flag2 = (nint)0 == 0;
		object obj28 = !flag2;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Store.CallWhenLoaded(action8);
	}

	private void RefreshFireSawaPrice()
	{
		if (fireSawa != null)
		{
			int num = StorePricing.EffectivePrice(fireSawa);
			int num2 = default(int);
			string text = num2.ToString();
			fireSawaPriceLabel.text = text;
		}
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_010b: Expected I, but got O
		//IL_0049: Expected I, but got O
		//IL_0088: Expected O, but got I
		//IL_00a0: Expected I, but got O
		//IL_00b1: Expected O, but got I
		//IL_00dd: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2288;
		object obj3 = (nint)0 + (nint)2296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		StorePricing.OnPricingChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		gameEventsChannel.ShakeProjectsButton -= action2;
		if (fireSawa != null)
		{
			object obj4 = (nint)0 + (nint)2256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action3 = default(Action);
			action3..ctor(this, (IntPtr)obj4);
			object obj5 = (nint)0 + (nint)2264;
			gameEventsChannel.OnActivateFireMode -= action3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action4 = default(Action);
			action4..ctor(this, (IntPtr)obj5);
			gameEventsChannel.OnDeactivateFireMode -= action4;
		}
	}

	private void OnGameStateUpdated()
	{
		if (_game.IsTutorial)
		{
			HandleTutorialState();
		}
		else
		{
			UpdateButtons();
		}
	}

	private void UpdateButtons()
	{
		//IL_002e: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_01b8: Expected O, but got I
		//IL_01ec: Expected O, but got I
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0236: Expected O, but got I4
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_019d: Expected O, but got I4
		//IL_026a: Expected O, but got I4
		//IL_0297: Expected O, but got I4
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0844: Expected I4, but got Unknown
		//IL_0115: Expected O, but got I4
		//IL_0693: Expected O, but got I4
		//IL_0705: Expected O, but got I4
		//IL_070e: Expected O, but got I4
		//IL_0717: Expected O, but got I4
		//IL_02d5: Expected O, but got I4
		//IL_042a: Expected O, but got I4
		//IL_036c: Expected O, but got I4
		//IL_03d2: Expected O, but got I4
		//IL_0763: Expected O, but got I4
		//IL_0792: Unknown result type (might be due to invalid IL or missing references)
		//IL_0797: Expected I4, but got Unknown
		//IL_07cc: Expected O, but got I4
		//IL_07f2: Expected O, but got I4
		//IL_0803: Expected O, but got I4
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected I4, but got Unknown
		//IL_0483: Expected O, but got I4
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected I4, but got Unknown
		//IL_04fb: Expected O, but got I4
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected I4, but got Unknown
		//IL_0584: Expected O, but got I4
		//IL_058f: Expected O, but got I4
		//IL_059c: Expected I4, but got O
		//IL_05e5: Expected O, but got I4
		//IL_060e: Expected O, but got I4
		bool isSpectator = _game.IsSpectator;
		bool flag = !isSpectator;
		object obj = !flag;
		bool flag3;
		BalootGame game;
		if (obj == null)
		{
			BalootPlayer myPlayer = _game.MyPlayer;
			if (myPlayer.IsHumanSeated)
			{
				BalootPlayer myPlayer2 = _game.MyPlayer;
				if (myPlayer2.CanPlayCard)
				{
					List<Card> cardsOnFloor = _game.CardsOnFloor;
					if (!Enumerable.Any((IEnumerable<object>)cardsOnFloor))
					{
						Room room = _game.Room;
						bool flag2 = SFSKammelnaRoomExtensions.IsOffline(room);
						flag3 = (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
						game = _game;
						goto IL_0667;
					}
				}
				game = _game;
				bool flag4 = (object)_game == null;
				object obj2 = !flag4;
				flag3 = false;
				if (obj2 != null)
				{
					goto IL_0667;
				}
				goto IL_0811;
			}
		}
		BalootGame game2 = _game;
		object obj3 = 0;
		object obj4 = 0;
		flag3 = false;
		goto IL_015b;
		IL_03fc:
		GameObject gameObject;
		bool active;
		gameObject.SetActive(active);
		sawaButton.interactable = flag3;
		bool flag5;
		object obj5 = flag3 && flag5;
		bool interactable;
		if ((nint)obj5 == 1)
		{
			BalootPlayer myPlayer3 = _game.MyPlayer;
			List<Card> <Cards>k__BackingField = ((CardGamePlayer)myPlayer3).<Cards>k__BackingField;
			object obj6 = <Cards>k__BackingField._size - 1;
			bool flag6 = (nint)obj6 < 0;
			bool flag7 = obj6 == null;
			int num = <Cards>k__BackingField._size ^ 1;
			int num2 = <Cards>k__BackingField._size ^ obj6;
			int num3 = num & num2;
			bool flag8 = num3 < 0;
			bool flag9 = flag6 == flag8;
			object obj7 = !flag7;
			bool flag10 = (byte)((flag9 & obj7) ? 1 : 0) != 0;
			interactable = flag10;
		}
		else
		{
			interactable = false;
		}
		EkkaToggle.interactable = interactable;
		GameObject gameObject2 = EkkaToggle.gameObject;
		bool active2 = (byte)((obj3 & flag5) ? 1 : 0) != 0;
		gameObject2.SetActive(active2);
		bool flag11 = obj3 == null;
		object obj8 = !flag11;
		object obj9 = !flag5;
		bool active3 = (byte)(obj8 & obj9) != 0;
		ManualEkkaBlocker.SetActive(active3);
		return;
		IL_015b:
		bool isBidding = ((CardGame)game2).<Stage>k__BackingField.IsBidding;
		KGame game3 = _game;
		object obj10;
		if (isBidding)
		{
			obj10 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v9 (KGame)+154]");
			object obj11 = -1;
			bool flag12 = (nint)obj11 < 0;
			bool flag13 = obj11 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v9 (KGame)+154]");
			object obj12 = (nint)0 ^ (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v9 (KGame)+154]");
			object obj13 = 0 ^ obj11;
			object obj14 = obj12 & obj13;
			bool flag14 = (nint)obj14 < 0;
			bool flag15 = flag12 == flag14;
			object obj15 = !flag13;
			object obj16 = flag15 & obj15;
			obj10 = obj16;
		}
		Room room2 = game3.Room;
		flag5 = SFSKammelnaRoomExtensions.IsCheatingAllowed(room2);
		bool flag16 = obj4 == null;
		object obj17 = !flag16;
		object obj18 = ~obj17;
		object obj19 = ((obj18 != null) ? ((object)0) : obj10);
		bool interactable2 = (byte)((obj19 & flag5) ? 1 : 0) != 0;
		catchButton.interactable = interactable2;
		bool flag17 = obj4 == null;
		bool interactable3 = false;
		if (!flag17)
		{
			BalootPlayer myPlayer4 = _game.MyPlayer;
			List<Card> <Cards>k__BackingField2 = ((CardGamePlayer)myPlayer4).<Cards>k__BackingField;
			object obj20 = <Cards>k__BackingField2._size - 8;
			bool flag18 = obj20 == null;
			interactable3 = flag18;
		}
		projectsButton.interactable = interactable3;
		gameObject = projectsButton.gameObject;
		if (obj4 != null)
		{
			BalootGame game4 = _game;
			bool flag19 = BalootGameModeExtensions.IsSunOrAshkal(game4.<GameMode>k__BackingField);
			bool flag20 = !flag19;
			object obj21 = !flag20;
			if (obj21 == null)
			{
				BalootGame game5 = _game;
				if (!((CardGame)game5).<Stage>k__BackingField.IsBidding)
				{
					BalootPlayer myPlayer5 = _game.MyPlayer;
					List<Card> <Cards>k__BackingField3 = ((CardGamePlayer)myPlayer5).<Cards>k__BackingField;
					object obj22 = <Cards>k__BackingField3._size - 8;
					bool flag21 = obj22 == null;
					bool flag22 = (object)gameObject == null;
					object obj23 = !flag22;
					active = flag21;
					if (obj23 != null)
					{
						goto IL_03fc;
					}
					goto IL_0811;
				}
			}
			bool flag23 = (object)gameObject == null;
			object obj24 = !flag23;
			active = true;
			if (obj24 == null)
			{
				goto IL_0811;
			}
		}
		else
		{
			active = false;
		}
		goto IL_03fc;
		IL_0667:
		bool isBidding2 = ((CardGame)game).<Stage>k__BackingField.IsBidding;
		bool flag24 = !isBidding2;
		object obj25 = !flag24;
		if (obj25 == null)
		{
			BalootGame game6 = _game;
			if (!BalootGameModeExtensions.IsSunOrAshkal(game6.<GameMode>k__BackingField))
			{
				BalootPlayer myPlayer6 = _game.MyPlayer;
				List<Card> <Cards>k__BackingField4 = ((CardGamePlayer)myPlayer6).<Cards>k__BackingField;
				object obj26 = <Cards>k__BackingField4._size - 8;
				bool flag25 = (nint)obj26 < 0;
				int num4 = <Cards>k__BackingField4._size ^ 8;
				int num5 = <Cards>k__BackingField4._size ^ obj26;
				int num6 = num4 & num5;
				bool flag26 = num6 < 0;
				bool flag27 = flag25 == flag26;
				object obj27 = !flag27;
				game2 = _game;
				bool flag28 = (object)_game == null;
				object obj28 = !flag28;
				obj3 = obj27;
				obj4 = 1;
				if (obj28 != null)
				{
					goto IL_015b;
				}
				goto IL_0811;
			}
		}
		game2 = _game;
		bool flag29 = (object)_game == null;
		object obj29 = !flag29;
		obj3 = 0;
		obj4 = 1;
		if (obj29 != null)
		{
			goto IL_015b;
		}
		goto IL_0811;
		IL_0811:
		throw new NullReferenceException();
	}

	private void HandleTutorialState()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_01a8: Expected O, but got I
		//IL_0147: Expected O, but got I4
		//IL_008e: Expected O, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected I4, but got Unknown
		Room room = _game.Room;
		TutorialType tutorialType = SFSKammelnaRoomExtensions.GetTutorialType(room);
		bool interactable;
		if (TutorialTypeExtensions.IsCatchTutorial(tutorialType))
		{
			BalootGame game = _game;
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2296;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v11+B8]");
			object obj3 = 0;
			object obj4 = obj3;
			int <MoveNumber>k__BackingField = ((CardGame)game).<MoveNumber>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13+38]");
			object obj5 = (nint)<MoveNumber>k__BackingField - (nint)0;
			bool flag = (nint)obj5 < 0;
			int <MoveNumber>k__BackingField2 = ((CardGame)game).<MoveNumber>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v13+38]");
			int num = (int)((nint)<MoveNumber>k__BackingField2 ^ (nint)0);
			int num2 = ((CardGame)game).<MoveNumber>k__BackingField ^ obj5;
			int num3 = num & num2;
			bool flag2 = num3 < 0;
			bool flag3 = flag == flag2;
			interactable = flag3;
		}
		else
		{
			interactable = false;
		}
		catchButton.interactable = interactable;
		BalootPlayer myPlayer = _game.MyPlayer;
		List<Card> <Cards>k__BackingField = ((CardGamePlayer)myPlayer).<Cards>k__BackingField;
		object obj6 = <Cards>k__BackingField._size - 8;
		bool interactable2 = obj6 == null;
		projectsButton.interactable = interactable2;
		sawaButton.interactable = false;
		EkkaToggle.interactable = false;
	}

	public void ShakeProjectsButton()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0061: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 3912;
		RectTransform rect = UIExtensions.rectTransform(projectsButton);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AnimationExtensions.ErrorFeedback(rect);
	}

	public void ToggleIkkaDeclaration(bool isIkkaToBeDeclared)
	{
		_game.ToggleEkkaDeclaration(isIkkaToBeDeclared);
	}

	public void ShowCatchPanel()
	{
		gameEventsChannel.TriggerToggleCatchPanel();
	}

	public void ShowProjectsPanel()
	{
		gameEventsChannel.TriggerToggleProjectsPanel();
	}

	public void ShowSawaPanel()
	{
		gameEventsChannel.TriggerToggleSawaPanel();
	}

	private void EkkaDeclarationChanged(bool ikkaDeclared)
	{
		EkkaToggle.isOn = ikkaDeclared;
	}

	protected void HideContainer()
	{
		//IL_0044: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		Transform transform = base.transform;
		if ((object)transform != null)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 3600;
			if (transform != obj)
			{
				throw new InvalidCastException();
			}
		}
		object obj2 = (nint)0 + (nint)2872;
		int num = ShortcutExtensions.DOKill(transform);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY((RectTransform)transform, -600f, 0.5f, snapping: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	private void ActivateSawaFiremode()
	{
		fireSawaToggler.ToggleManual(isON: true);
	}

	private void DeactivateSawaFiremode()
	{
		fireSawaToggler.ToggleManual(isON: false);
	}

	private void <Start>b__10_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00d2: Expected O, but got I4
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1968;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		StoreItem storeItem = Store.GetStoreItem(GameAction.Farsh);
		object obj4 = this + 88;
		obj4 = storeItem;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj4 != null)
		{
			int num = StorePricing.EffectivePrice((StoreItem)obj4);
			int num2 = default(int);
			string text = num2.ToString();
			fireSawaPriceLabel.text = text;
		}
	}
}
