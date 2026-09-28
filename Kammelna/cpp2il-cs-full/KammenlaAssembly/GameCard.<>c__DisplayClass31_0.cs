using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Rendering;

public class GameCard : UiCard
{
	private sealed class <>c__DisplayClass31_0
	{
		public int index;

		internal void <SetSortingOrder>b__0(SpriteRenderer s)
		{
			int sortingOrder = 13 - index;
			s.sortingOrder = sortingOrder;
		}
	}

	private static readonly Color ColorGray;

	private static readonly Color ColorRed;

	public SpriteRenderer sprite;

	private BaseToggler fireModeToggler;

	private TextMeshPro specialPlayPriceTagText;

	private GameObject specialPlayPriceTag;

	private bool _isFireActive;

	private Tween _activeStateAnimation;

	private bool _isDimmed;

	private bool _isHighlightedForDiscard;

	private CardStatus <CardStatus>k__BackingField;

	private Games _currentGame;

	private const float BalootPickedCardYOffSet = 100f;

	private const float JackarooPickedCardYOffSet = 20f;

	public bool IsAnimating
	{
		get
		{
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected I4, but got Unknown
			//IL_0036: Expected O, but got I4
			Tween tween = _activeStateAnimation;
			if (_activeStateAnimation != null)
			{
				tween = (Tween)tween.<active>k__BackingField;
			}
			return (byte)(tween & 1) != 0;
		}
	}

	public bool IsFireActive
	{
		get
		{
			return _isFireActive;
		}
		set
		{
			_isFireActive = value;
			fireModeToggler.ToggleManual(value);
		}
	}

	public bool IsDimmed
	{
		get
		{
			return _isDimmed;
		}
		set
		{
			_isDimmed = value;
			OnStatusChange();
		}
	}

	public bool IsHighlightedForDiscard
	{
		get
		{
			return _isHighlightedForDiscard;
		}
		set
		{
			HighlightForDiscard(value);
		}
	}

	public CardStatus CardStatus
	{
		get
		{
			return <CardStatus>k__BackingField;
		}
		private set
		{
			<CardStatus>k__BackingField = value;
		}
	}

	private float GetYOffSet
	{
		get
		{
			//IL_001c: Expected O, but got I4
			//IL_0065: Expected F4, but got I4
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected O, but got Unknown
			//IL_00fb: Expected O, but got I
			bool flag = _currentGame < Games.Jackaroo;
			object obj = !flag;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				if (_currentGame == Games.Jackaroo)
				{
					return 20f;
				}
				object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2232;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object obj4 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj5 = "___# Content push apply failed [{0}]: {1}" + 2144;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
				string paramName = default(string);
				object actualValue = default(object);
				ex..ctor(paramName, actualValue, null);
				object obj6 = (nint)0 + (nint)120;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				throw new OutOfMemoryException();
			}
			return 1.1204035E+09f;
		}
	}

	private void HighlightForDiscard(bool value)
	{
		//IL_00e5: Expected I, but got O
		//IL_00f5: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0047: Expected O, but got I4
		//IL_0091: Expected O, but got I
		//IL_00bb: Expected O, but got I4
		//IL_0142: Expected O, but got I
		//IL_015e: Expected F4, but got I
		//IL_015e: Expected O, but got I4
		//IL_0077: Expected O, but got I4
		while (true)
		{
			_isHighlightedForDiscard = value;
			if (!value)
			{
				nint num = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3 (Il2CppClass<GameCard>)+188]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v3 (Il2CppClass<GameCard>)+190]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v54 @ X2_v1 (should have been resolved before IL gen)");
				continue;
			}
			break;
		}
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2064;
		int num2 = ShortcutExtensions.DOKill(sprite);
		bool flag = _activeStateAnimation == null;
		object obj4 = 0;
		bool flag2 = false;
		if (!flag)
		{
			TweenExtensions.Kill(_activeStateAnimation);
			obj4 = 0;
			flag2 = false;
		}
		object obj5 = (nint)0 + (nint)2816;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v7+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v7+B8]");
		object obj8 = 0;
		SpriteRenderer target = sprite;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v5+10]");
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleSprite.DOColor(target, (Color)0, 0f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	public void SetStatus(CardStatus status)
	{
		<CardStatus>k__BackingField = status;
		OnStatusChange();
	}

	private void OnStatusChange()
	{
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0172: Expected O, but got I
		//IL_011c: Expected O, but got I
		if (_isDimmed)
		{
			CardDimmed();
			return;
		}
		if (<CardStatus>k__BackingField <= CardStatus.Prepared)
		{
			if (<CardStatus>k__BackingField == CardStatus.InHand)
			{
				CardInHand();
				return;
			}
			if (<CardStatus>k__BackingField == CardStatus.Prepared)
			{
				CardPrepared();
				return;
			}
		}
		else
		{
			if (<CardStatus>k__BackingField == CardStatus.PreparedForClick)
			{
				CardPreparedForClick();
				return;
			}
			if (<CardStatus>k__BackingField == CardStatus.Preplay)
			{
				float getYOffSet = GetYOffSet;
				float scaleDuration = base._cardPositionY + getYOffSet;
				IntPtr intPtr = default(IntPtr);
				AnimateCardState((Color)(nint)intPtr, 1f, 1f, 0.8f, 1f, scaleDuration, 1.2f);
				return;
			}
		}
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)112;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		GameObject gameObject = base.gameObject;
		object tag = "Cannot populate JSON object onto type '{0}'." + 1648;
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		gameObject.tag = (string)tag;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			Games currentGame = Preferences.CurrentGame;
			_currentGame = currentGame;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Games currentGame2 = Preferences.CurrentGame;
			_currentGame = currentGame2;
		}
	}

	protected override void SetSprite(Sprite card)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_0158: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66C0]");
		object obj3 = (nint)0 & (nint)1;
		SpriteRenderer spriteRenderer;
		SpriteRenderer spriteRenderer2;
		if (obj3 != null)
		{
			spriteRenderer = this.sprite;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			spriteRenderer2 = this.sprite;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			spriteRenderer = this.sprite;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			spriteRenderer2 = this.sprite;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = card;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		spriteRenderer = spriteRenderer2;
		Sprite sprite = card;
		if (obj6 == null)
		{
			goto IL_0176;
		}
		goto IL_019a;
		IL_019a:
		spriteRenderer2.sprite = sprite;
		return;
		IL_0176:
		Sprite sprite2 = this.sprite.sprite;
		spriteRenderer2 = spriteRenderer;
		sprite = sprite2;
		goto IL_019a;
		IL_0091:
		if (!card)
		{
			goto IL_0176;
		}
		spriteRenderer2 = spriteRenderer;
		sprite = card;
		goto IL_019a;
	}

	public override void RefreshCardStatus()
	{
		OnStatusChange();
	}

	protected override void SetSortingOrder(int index)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0051: Expected O, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0071: Expected O, but got I
		//IL_009c: Expected I, but got O
		//IL_00e0: Expected F4, but got I
		//IL_0101: Expected O, but got I4
		//IL_0101: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 3928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		int sortingOrder = 13 - index;
		sprite.sortingOrder = sortingOrder;
		object obj3 = (nint)0 + (nint)832;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3496;
		object obj5 = (nint)0 + (nint)1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31D00");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		IEnumerable<object> enumeration = default(IEnumerable<object>);
		ArraysExtensions.ForEach(enumeration, action);
		Transform transform = base.transform;
		Transform parent = transform.parent;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
		float? z = 0f;
		UIExtensions.MoveTo(parent, isWorldPositions: false, (float?)(object)0, (float?)(object)0, z);
	}

	public void SetSpecialPlayPrice(int price)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0168: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E66C2]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			obj5 = specialPlayPriceTagText;
			obj6 = specialPlayPriceTagText;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = specialPlayPriceTagText;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = specialPlayPriceTagText;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!obj6)
		{
			return;
		}
		goto IL_014a;
		IL_014a:
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1128;
		object obj8 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		specialPlayPriceTagText.text = text;
		return;
		IL_0091:
		bool flag3 = obj5;
		bool flag4 = !flag3;
		object obj9 = !flag4;
		if (obj9 == null)
		{
			return;
		}
		goto IL_014a;
	}

	private void CardDimmed()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0053: Expected O, but got I4
		//IL_0088: Expected O, but got I
		//IL_00ca: Expected F4, but got I
		//IL_00ca: Expected F4, but got I
		//IL_00ca: Expected F4, but got I
		//IL_00ca: Expected F4, but got O
		//IL_00ca: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2064;
		specialPlayPriceTag.SetActive(value: false);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v5+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+8]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+C]");
		AnimateCardState((Color)0, (float)obj4, num, num2, 0f, base._cardPositionY, 1f);
	}

	private void CardInHand()
	{
		//IL_00a2: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_010e: Expected O, but got I
		//IL_011e: Expected F8, but got I
		//IL_012e: Expected F8, but got I
		//IL_013e: Expected F8, but got I
		//IL_014e: Expected F8, but got I
		bool flag = !_isHighlightedForDiscard;
		double num = 1.0;
		double num2 = 1.0;
		double num3 = 1.0;
		double num4 = 1.0;
		if (!flag)
		{
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2064;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v8+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v9+10]");
			num2 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v9+14]");
			num = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v9+18]");
			num4 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v9+1C]");
			num3 = 0.0;
		}
		specialPlayPriceTag.SetActive(value: false);
		AnimateCardState((Color)0, (float)num2, (float)num, (float)num4, (float)num3, base._cardPositionY, 1f);
	}

	private void CardPrepared()
	{
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_002f: Expected O, but got I4
		//IL_00d4: Expected O, but got I4
		//IL_01ac: Expected O, but got I
		//IL_01b4: Expected F8, but got O
		//IL_01c4: Expected F8, but got I
		//IL_01d4: Expected F8, but got I
		//IL_01e4: Expected F8, but got I
		//IL_0207: Expected O, but got I
		//IL_0217: Expected F8, but got I
		//IL_0227: Expected F8, but got I
		//IL_0237: Expected F8, but got I
		//IL_0247: Expected F8, but got I
		//IL_0165: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2064;
		double num;
		double num2;
		double num3;
		double num4;
		if (_isDimmed)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v16+B8]");
			object obj4 = 0;
			num = (double)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v12+4]");
			num2 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v12+8]");
			num3 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v12+C]");
			num4 = 0.0;
		}
		else
		{
			bool flag2 = !_isHighlightedForDiscard;
			num = 1.0;
			num2 = 1.0;
			num3 = 1.0;
			num4 = 1.0;
			if (!flag2)
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v12+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj5 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v12+B8]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v10+10]");
				num = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v10+14]");
				num2 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v10+18]");
				num3 = 0.0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v10+1C]");
				num4 = 0.0;
			}
		}
		GameSoundManager instance = GameSoundManager.Instance;
		instance.PlaySound(GameSoundEffect.CARD_PREPARE, withDelay: false);
		specialPlayPriceTag.SetActive(value: true);
		float getYOffSet = GetYOffSet;
		float scaleDuration = base._cardPositionY + getYOffSet;
		AnimateCardState((Color)1, (float)num, (float)num2, (float)num3, (float)num4, scaleDuration, 1.2f);
	}

	private void CardPreparedForClick()
	{
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_01c5: Expected O, but got I4
		//IL_002f: Expected O, but got I4
		//IL_03a3: Expected O, but got I
		//IL_03b3: Expected F8, but got I
		//IL_03c3: Expected F8, but got I
		//IL_03d3: Expected F8, but got I
		//IL_03e3: Expected F8, but got I
		//IL_040d: Expected O, but got I4
		//IL_041d: Expected F8, but got I
		//IL_042d: Expected F8, but got I
		//IL_043d: Expected F8, but got I
		//IL_044d: Expected F8, but got I
		//IL_0323: Expected O, but got I
		//IL_032b: Expected F8, but got O
		//IL_033b: Expected F8, but got I
		//IL_034b: Expected F8, but got I
		//IL_035b: Expected F8, but got I
		//IL_0385: Expected O, but got I4
		//IL_0260: Expected O, but got I4
		//IL_0239: Expected O, but got I
		//IL_005c: Expected F8, but got O
		//IL_006c: Expected F8, but got I
		//IL_007c: Expected F8, but got I
		//IL_008c: Expected F8, but got I
		//IL_0176: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2064;
		double num;
		double num2;
		double num3;
		double num4;
		double num5;
		double num6;
		double num7;
		double num8;
		if (_isDimmed)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v22+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v22+B8]");
			object obj5 = 0;
			num = (double)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v16+4]");
			num2 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v16+8]");
			num3 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v16+C]");
			num4 = 0.0;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_0145;
			}
			num5 = (double)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v16+4]");
			num6 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v16+8]");
			num7 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v16+C]");
			num8 = 0.0;
		}
		else if (!_isHighlightedForDiscard)
		{
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v8+E4]");
			bool flag3 = (nint)0 == 0;
			num = 1.0;
			num2 = 1.0;
			num3 = 1.0;
			num4 = 1.0;
			num5 = 1.0;
			num6 = 1.0;
			num7 = 1.0;
			num8 = 1.0;
			if (!flag3)
			{
				goto IL_0145;
			}
		}
		else
		{
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v16+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v16+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+10]");
			num = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+14]");
			num2 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+18]");
			num3 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+1C]");
			num4 = 0.0;
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v8+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+10]");
			num5 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+14]");
			num6 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+18]");
			num7 = 0.0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12+1C]");
			num8 = 0.0;
			if (obj11 != null)
			{
				goto IL_0145;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Games currentGame = Preferences.CurrentGame;
		bool flag6 = currentGame == Games.Jackaroo;
		num = num5;
		num2 = num6;
		num3 = num7;
		num4 = num8;
		IntPtr intPtr = default(IntPtr);
		Color targetColor = (Color)(nint)intPtr;
		if (!flag6)
		{
			goto IL_0247;
		}
		goto IL_0285;
		IL_0285:
		float getYOffSet = GetYOffSet;
		float scaleDuration = base._cardPositionY + getYOffSet;
		AnimateCardState(targetColor, (float)num5, (float)num6, (float)num7, (float)num8, scaleDuration, 1.2f);
		return;
		IL_0145:
		Games currentGame2 = Preferences.CurrentGame;
		if (currentGame2 != Games.Jackaroo)
		{
			goto IL_0247;
		}
		targetColor = (Color)(nint)intPtr;
		num5 = num;
		num6 = num2;
		num7 = num3;
		num8 = num4;
		goto IL_0285;
		IL_0247:
		specialPlayPriceTag.SetActive(value: true);
		targetColor = (Color)1;
		num5 = num;
		num6 = num2;
		num7 = num3;
		num8 = num4;
		goto IL_0285;
	}

	private void CardPreplay()
	{
		//IL_004e: Expected O, but got I
		float getYOffSet = GetYOffSet;
		float scaleDuration = base._cardPositionY + getYOffSet;
		IntPtr intPtr = default(IntPtr);
		AnimateCardState((Color)(nint)intPtr, 1f, 1f, 0.8f, 1f, scaleDuration, 1.2f);
	}

	private unsafe void AnimateCardState(Color targetColor, float targetY, float targetScale, float colorDuration = 0.25f, float moveDuration = 0.1f, float scaleDuration = 0.1f, float moveDelay = 0f)
	{
		//IL_0008: Expected O, but got Ref
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I4
		//IL_003e: Expected O, but got I
		//IL_0068: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_0024: Expected O, but got I4
		//IL_012d: Expected F4, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		int num = ShortcutExtensions.DOKill(sprite);
		object obj4 = this + 96;
		bool flag = obj4 == null;
		object obj5 = 0;
		bool flag2 = false;
		if (!flag)
		{
			TweenExtensions.Kill((Tween)obj4);
			obj5 = 0;
			flag2 = false;
		}
		object obj6 = (nint)0 + (nint)2776;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence s = DOTween.Sequence();
		TweenerCore<Color, Color, ColorOptions> t = DOTweenModuleSprite.DOColor(sprite, (Color)0, targetY);
		Sequence s2 = TweenSettingsExtensions.Append(s, t);
		Transform target = base.transform;
		float duration = default(float);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(target, scaleDuration, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		Tween t2 = default(Tween);
		Sequence s3 = TweenSettingsExtensions.Join(s2, t2);
		Transform target2 = base.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X29_v1+10]");
		TweenerCore<Vector3, Vector3, VectorOptions> t3 = ShortcutExtensions.DOScale(target2, moveDelay, 0f);
		Sequence activeStateAnimation = TweenSettingsExtensions.Join(s3, t3);
		_activeStateAnimation = activeStateAnimation;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void DimCard(bool isDimmed)
	{
		_isDimmed = isDimmed;
		OnStatusChange();
	}

	public void ShowPriceTag(int price)
	{
		SetSpecialPlayPrice(price);
		specialPlayPriceTag.SetActive(value: true);
	}

	public void HidePriceTag()
	{
		specialPlayPriceTag.SetActive(value: false);
	}

	static GameCard()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2064;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252CA0]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252B40]");
		_ = 0;
	}
}
