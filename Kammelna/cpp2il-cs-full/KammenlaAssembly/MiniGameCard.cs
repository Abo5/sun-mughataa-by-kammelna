using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MiniGameCard : UiCard, IPointerDownHandler, IEventSystemHandler, IPointerEnterHandler, IPointerUpHandler
{
	private static readonly Color ColorRed;

	private Action<MiniGameCard> m_OnSelected;

	private static bool IsDraggingFromCard;

	public Image cardFace;

	public Image cardGold;

	public Image cardBack;

	private bool <intractable>k__BackingField;

	private bool _isPartOfProject;

	private MiniGameCardStatus <CardStatus>k__BackingField;

	public bool intractable
	{
		get
		{
			return <intractable>k__BackingField;
		}
		set
		{
			<intractable>k__BackingField = value;
		}
	}

	public bool isPartOfProject
	{
		get
		{
			return _isPartOfProject;
		}
		set
		{
			//IL_0023: Expected O, but got I4
			//IL_0041: Expected O, but got I4
			//IL_0073: Expected F4, but got I4
			//IL_008c: Expected O, but got I4
			_isPartOfProject = value;
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor(cardFace, (Color)0, 1f);
			bool flag = !value;
			object obj = !flag;
			object obj2 = ~obj;
			float duration = ((obj2 != null) ? 0f : 1f);
			TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOColor(cardGold, (Color)0, duration);
		}
	}

	public MiniGameCardStatus CardStatus
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

	public event Action<MiniGameCard> OnSelected
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2744;
			object obj2 = this + 56;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
		remove
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2744;
			object obj2 = this + 56;
			Delegate obj3 = (Delegate)obj2;
			object obj6 = default(object);
			bool flag2;
			Delegate obj8 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null)
				{
					object obj5 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj6 == null;
					object obj7 = !flag;
					object obj5 = obj6;
					if (obj7 == null)
					{
						throw new InvalidCastException();
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj8 == obj3;
				obj3 = obj8;
			}
			while (!flag2);
		}
	}

	public void SetStatus(MiniGameCardStatus status)
	{
		if (<CardStatus>k__BackingField != status)
		{
			<CardStatus>k__BackingField = status;
			OnStatusChange();
		}
	}

	private void OnStatusChange()
	{
		//IL_003b: Expected O, but got I4
		//IL_0062: Expected O, but got I4
		//IL_0082: Expected O, but got I4
		//IL_00b4: Expected F4, but got I4
		//IL_0122: Expected O, but got I4
		if (<CardStatus>k__BackingField != MiniGameCardStatus.PreparedForDiscard)
		{
			bool flag = <CardStatus>k__BackingField == MiniGameCardStatus.InHand;
			object obj = !flag;
			if (obj == null)
			{
				TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor(cardFace, (Color)0, 1f);
				bool flag2 = !_isPartOfProject;
				object obj2 = !flag2;
				object obj3 = ~obj2;
				float duration = ((obj3 != null) ? 0f : 1f);
				TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOColor(cardGold, (Color)0, duration);
				Transform target = base.transform;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOLocalMoveY(target, base._cardPositionY, 0.1f, snapping: true);
				Transform target2 = base.transform;
				TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = ShortcutExtensions.DOScale(target2, 1f, 0.1f);
			}
		}
		else if (<intractable>k__BackingField)
		{
			CardPreparedForDiscard();
		}
	}

	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fe: Expected O, but got I
		//IL_0132: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0185: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63A8]");
		object obj3 = (nint)0 & (nint)1;
		Image img;
		Image image;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			img = cardBack;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			image = cardBack;
			if (!flag)
			{
				goto IL_00a5;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			img = cardBack;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			image = cardBack;
			if (obj7 != null)
			{
				goto IL_00a5;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		img = image;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00b4;
		IL_00a5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00b4;
		IL_00b4:
		User localUser = sessionModel.LocalUser;
		int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(localUser);
		UIExtensions.LoadItemImage(img, activeCardbackID, ImageCacher.ItemImageType.InGame);
	}

	public void OnPointerDown(PointerEventData data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0102: Expected O, but got I
		//IL_012e: Expected O, but got I4
		//IL_00b6: Expected O, but got I
		//IL_00c6: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_0077: Expected O, but got I
		if (!<intractable>k__BackingField)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 776;
		bool flag = <CardStatus>k__BackingField == MiniGameCardStatus.InHand;
		<CardStatus>k__BackingField = (flag ? MiniGameCardStatus.PreparedForDiscard : MiniGameCardStatus.InHand);
		OnStatusChange();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v4+E4]");
		Action<MiniGameCard> onSelected;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v4+B8]");
			object obj3 = 0;
			_ = 1;
			onSelected = this.OnSelected;
			if (this.OnSelected != null)
			{
				goto IL_00a6;
			}
			return;
		}
		goto IL_00e0;
		IL_00a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10 (System.Action`1<MiniGameCard>)+18]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10 (System.Action`1<MiniGameCard>)+40]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v10 (System.Action`1<MiniGameCard>)+28]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v98 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_00e0;
		IL_00e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v6+B8]");
		object obj8 = 0;
		_ = 1;
		onSelected = this.OnSelected;
		bool flag2 = this.OnSelected == null;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			return;
		}
		goto IL_00a6;
	}

	public void OnPointerEnter(PointerEventData data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_0124: Expected O, but got I
		//IL_0134: Expected O, but got I
		//IL_0144: Expected O, but got I
		if (!<intractable>k__BackingField)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 776;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+B8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v12+10]");
			if ((nint)0 != 1)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v8+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v10+10]");
			if ((nint)0 != 1)
			{
				return;
			}
		}
		bool flag = <CardStatus>k__BackingField == MiniGameCardStatus.InHand;
		<CardStatus>k__BackingField = (flag ? MiniGameCardStatus.PreparedForDiscard : MiniGameCardStatus.InHand);
		OnStatusChange();
		Action<MiniGameCard> onSelected = this.OnSelected;
		if (this.OnSelected != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v9 (System.Action`1<MiniGameCard>)+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v9 (System.Action`1<MiniGameCard>)+40]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v9 (System.Action`1<MiniGameCard>)+28]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v113 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	public void OnPointerUp(PointerEventData data)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00cc: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_0104: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 776;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E63AB]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v3+B8]");
		object obj8 = 0;
		_ = 0;
		return;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v8+B8]");
		object obj9 = 0;
		_ = 0;
	}

	protected override void SetSprite(Sprite sprite)
	{
		cardFace.sprite = sprite;
	}

	public override void RefreshCardStatus()
	{
	}

	protected override void SetSortingOrder(int index)
	{
	}

	public void ToggleCardFace(bool show)
	{
		//IL_0035: Expected O, but got I4
		Component component;
		if (show)
		{
			bool flag = (object)cardFace == null;
			object obj = !flag;
			component = cardFace;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			component = cardBack;
		}
		GameObject gameObject = component.gameObject;
		Transform transform = gameObject.transform;
		transform.SetAsLastSibling();
	}

	public void LoadCardBack(int cardItemID)
	{
		UIExtensions.LoadItemImage(cardBack, cardItemID, ImageCacher.ItemImageType.InGame);
	}

	private void CardInHand()
	{
		//IL_0019: Expected O, but got I4
		//IL_0039: Expected O, but got I4
		//IL_006b: Expected F4, but got I4
		//IL_00af: Expected O, but got I4
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor(cardFace, (Color)0, 1f);
		bool flag = !_isPartOfProject;
		object obj = !flag;
		object obj2 = ~obj;
		float duration = ((obj2 != null) ? 0f : 1f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore2 = DOTweenModuleUI.DOColor(cardGold, (Color)0, duration);
		Transform target = base.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOLocalMoveY(target, base._cardPositionY, 0.1f, snapping: true);
		Transform target2 = base.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = ShortcutExtensions.DOScale(target2, 1f, 0.1f);
	}

	private void CardPreparedForDiscard()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_005a: Expected O, but got I4
		//IL_00d9: Expected O, but got I
		//IL_00ed: Expected F4, but got O
		//IL_00ed: Expected O, but got I4
		//IL_0106: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 776;
		Transform target = base.transform;
		float endValue = base._cardPositionY + 30f;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveY(target, endValue, 0.1f, snapping: true);
		Transform target2 = base.transform;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(target2, 1.1f, 0.1f);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v9+B8]");
		object obj4 = 0;
		TweenerCore<Color, Color, ColorOptions> tweenerCore3 = DOTweenModuleUI.DOColor(cardFace, (Color)0, (float)obj4);
		TweenerCore<Color, Color, ColorOptions> tweenerCore4 = DOTweenModuleUI.DOColor(cardGold, (Color)0, 0f);
	}

	static MiniGameCard()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 776;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252B40]");
		obj3 = 0;
	}
}
