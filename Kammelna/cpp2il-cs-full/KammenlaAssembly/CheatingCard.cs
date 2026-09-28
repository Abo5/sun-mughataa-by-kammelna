using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.UI;

public class CheatingCard : MonoBehaviour
{
	private Image filter;

	private Sprite shaded;

	private Sprite red;

	private Sprite green;

	private Sprite none;

	private CardsSprites cardsSprites;

	private Image image;

	private Button button;

	private Card card;

	public bool interactable
	{
		get
		{
			//IL_0041: Expected I4, but got O
			Button button = this.button;
			if ((object)this.button != null)
			{
				return ((Selectable)button).m_Interactable;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		set
		{
			button.interactable = value;
		}
	}

	public Card Card
	{
		get
		{
			return card;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 96;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			SetSprite();
		}
	}

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_0018: Expected O, but got I
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_00e1: Expected O, but got I
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0078: Expected O, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I
		object obj = (nint)0 + (nint)3872;
		object obj2 = (nint)0 + (nint)3640;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = (nint)0 + (nint)32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj5 = this + 80;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj7 = this + 88;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj11 = this + 72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v15+90]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		SetSprite();
	}

	private void SetSprite()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6686]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			obj5 = cardsSprites;
			obj6 = cardsSprites;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v8+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = cardsSprites;
			obj6 = cardsSprites;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (obj6 != null)
		{
			goto IL_0150;
		}
		return;
		IL_0150:
		if (card != null)
		{
			Sprite sprite = cardsSprites.GetFor(card);
			image.sprite = sprite;
		}
		return;
		IL_0091:
		bool flag3 = obj5 != null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_0150;
	}

	public void SetDisabled()
	{
		filter.sprite = shaded;
		button.interactable = false;
	}

	public void Clear()
	{
		filter.sprite = none;
		button.interactable = true;
	}

	public void SetGreen()
	{
		filter.sprite = green;
	}

	public void SetRed()
	{
		filter.sprite = red;
	}

	public void ResetColor()
	{
		filter.sprite = none;
	}
}
