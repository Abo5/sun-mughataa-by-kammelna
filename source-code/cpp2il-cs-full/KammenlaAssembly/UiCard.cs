using Cpp2ILInjected;
using UnityEngine;

public abstract class UiCard : MonoBehaviour
{
	protected CardsSprites cardsSprites;

	private Card card;

	private float _cardPositionY;

	public Card Card
	{
		get
		{
			return card;
		}
		set
		{
			//IL_0018: Expected I, but got O
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			Sprite sprite = cardsSprites.GetFor(value);
			nint num = (nint)this;
			SetSprite(sprite);
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public float CardPositionY
	{
		get
		{
			return _cardPositionY;
		}
		set
		{
			//IL_000f: Expected I, but got O
			//IL_001f: Expected O, but got I
			//IL_002f: Expected O, but got I
			_cardPositionY = value;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<UiCard>)+188]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<UiCard>)+190]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public int Index
	{
		set
		{
			//IL_0005: Expected I, but got O
			//IL_0015: Expected O, but got I
			//IL_0025: Expected O, but got I
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<UiCard>)+198]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<UiCard>)+1A0]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	protected abstract void SetSprite(Sprite card);

	public abstract void RefreshCardStatus();

	protected abstract void SetSortingOrder(int index);
}
