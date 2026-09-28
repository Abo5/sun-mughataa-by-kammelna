using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class BaseCheatingBox : MonoBehaviour
{
	private Action<CheatingCard> m_OnCardClicked;

	protected TextMeshProUGUI title;

	protected CheatingCard[] cheatingCards;

	protected CardGame game;

	protected CardGameVisualControls gameVisual;

	public event Action<CheatingCard> OnCardClicked
	{
		add
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got Unknown
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Expected O, but got Unknown
			//IL_000e: Expected O, but got I4
			//IL_0065: Expected O, but got I4
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1400;
			object obj2 = this + 32;
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
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1400;
			object obj2 = this + 32;
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

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_0099: Expected O, but got I
		//IL_00c3: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = (nint)0 + (nint)32;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj6 = this + 56;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj8 = this + 64;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected abstract void SetupBox(int index);

	public virtual void Populate(int player, List<Card> chCards, KPlayer cc, bool dimCatcherTeam = false)
	{
		//IL_002e: Expected O, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I
		//IL_01ef: Expected O, but got I
		//IL_0102: Expected O, but got I
		//IL_0125: Expected O, but got I
		//IL_0082: Expected O, but got I4
		//IL_01ad: Expected O, but got I4
		int index = default(int);
		SetupBox(index);
		CheatingCard[] array = cheatingCards;
		if (chCards != null)
		{
			object obj = (nint)0 + (nint)2760;
			int num = 0;
			while (true)
			{
				if (num >= array.Length)
				{
					return;
				}
				object obj2 = array + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v9+20]");
				CheatingCard cheatingCard = (CheatingCard)0;
				if (num < chCards._size)
				{
					object obj3 = ((List<object>)(object)chCards).get_Item(num);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v9+20]");
					object obj4 = (nint)0 + (nint)96;
					obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v9+20]");
					((CheatingCard)0).SetSprite();
					cheatingCard.filter.sprite = cheatingCard.none;
					cheatingCard.button.interactable = true;
					bool isSpectator = game.IsSpectator;
					bool flag = cc == null;
					bool interactable = false;
					if (!flag)
					{
						bool flag2 = !isSpectator;
						object obj5 = !flag2;
						interactable = false;
						if (obj5 == null)
						{
							bool isMe = cc.IsMe;
							interactable = isMe;
						}
					}
					cheatingCard.button.interactable = interactable;
					num++;
					array = cheatingCards;
					bool flag3 = cheatingCards == null;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						break;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X8_v9+20]");
					GameObject gameObject = ((Component)0).gameObject;
					gameObject.SetActive(value: false);
					num++;
					array = cheatingCards;
				}
			}
		}
		else if (array.Length < 1)
		{
			return;
		}
		throw new NullReferenceException();
	}

	public void CardClicked(int index)
	{
		//IL_006d: Expected O, but got I4
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_009a: Expected O, but got I
		//IL_00aa: Expected O, but got I
		//IL_00ba: Expected O, but got I
		//IL_00ca: Expected O, but got I
		Action<CheatingCard> onCardClicked = this.OnCardClicked;
		if (this.OnCardClicked == null)
		{
			return;
		}
		CheatingCard[] array = cheatingCards;
		if (cheatingCards != null)
		{
			bool flag = index < array.Length;
			object obj = !flag;
			if (obj == null)
			{
				object obj2 = cheatingCards + index;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v2+20]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1 (System.Action`1<CheatingCard>)+18]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1 (System.Action`1<CheatingCard>)+40]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X8_v1 (System.Action`1<CheatingCard>)+28]");
				object obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v47 @ X3_v1 (should have been resolved before IL gen)");
				return;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		throw new IndexOutOfRangeException();
	}

	public void Highlight(Card wrongCard, Card allowedCard)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_009e: Expected O, but got I
		//IL_00b8: Expected O, but got I
		//IL_010d: Expected O, but got I
		//IL_0121: Expected O, but got I
		//IL_0151: Expected O, but got I4
		//IL_00e5: Expected O, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_006d: Expected O, but got I
		//IL_0143: Expected O, but got I4
		//IL_00f3: Expected O, but got I4
		CheatingCard[] array = cheatingCards;
		if (array.Length < 1)
		{
			return;
		}
		object obj = array + 32;
		object obj2 = 0;
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X23_v4+v52 @ X22_v5*8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X24_v5+60]");
			Image image;
			if (object.Equals(0, wrongCard))
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X24_v5+20]");
				image = (Image)0;
				object obj4 = 48;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X24_v5+60]");
				bool flag = object.Equals(0, allowedCard);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X24_v5+20]");
				image = (Image)0;
				if (flag)
				{
					object obj4 = 56;
				}
				else
				{
					object obj4 = 64;
				}
			}
			obj2++;
			Image image2 = image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X24_v5+v183 @ X8_v9]");
			image2.sprite = (Sprite)0;
		}
		while ((nint)obj2 < array.Length);
	}

	public void DisableCards()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_010c: Expected O, but got I4
		//IL_0060: Expected O, but got I
		CheatingCard[] array = cheatingCards;
		if (array.Length < 1)
		{
			return;
		}
		object obj = array + 32;
		object obj2 = 0;
		do
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X22_v4+v46 @ X21_v5*8]");
			Component component = (Component)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X22_v4+v46 @ X21_v5*8]");
			GameObject gameObject = ((Component)0).gameObject;
			if (gameObject.activeSelf)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X19_v5 (UnityEngine.Component)+58]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					throw new NullReferenceException();
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X19_v5 (UnityEngine.Component)+58]");
				((Selectable)0).interactable = false;
			}
			obj2++;
		}
		while ((nint)obj2 < array.Length);
	}

	public void HighlightTutorialCheatingCards(IEnumerable<Card> cards)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_005c: Expected O, but got I4
		//IL_00ad: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_0145: Expected O, but got I
		//IL_0145: Expected O, but got I
		//IL_0155: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_0105: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		List<object> list = Enumerable.ToList((IEnumerable<object>)cards);
		CheatingCard[] array = cheatingCards;
		object obj = cheatingCards + 32;
		if (list != null)
		{
			if (array.Length < 1)
			{
				return;
			}
			object obj2 = 0;
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X21_v3+v124 @ X22_v7*8]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X24_v5+60]");
				Selectable selectable;
				bool interactable;
				if (list.Contains(0))
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X24_v5+20]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X24_v5+40]");
					((Image)num).sprite = (Sprite)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X24_v5+58]");
					selectable = (Selectable)0;
					interactable = true;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X24_v5+20]");
					nint num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X24_v5+28]");
					((Image)num2).sprite = (Sprite)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X24_v5+58]");
					selectable = (Selectable)0;
					interactable = false;
				}
				selectable.interactable = interactable;
				obj2++;
			}
			while ((nint)obj2 < array.Length);
		}
		else if (array.Length >= 1)
		{
			throw new NullReferenceException();
		}
	}
}
