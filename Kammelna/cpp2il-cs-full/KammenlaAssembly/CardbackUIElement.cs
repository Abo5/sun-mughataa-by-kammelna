using UnityEngine;
using UnityEngine.Events;

public class CardbackUIElement : MonoBehaviour, ISelectable
{
	private CardBackSetter _cardBackSetter;

	private ObjectToggler selectionMarker;

	public UnityEvent<int> callback;

	private int cardbackId;

	public void Populate(int cardId)
	{
		cardbackId = cardId;
		_cardBackSetter.AssignCardBack(cardId);
	}

	public void InvokeCallback()
	{
		callback.Invoke(cardbackId);
	}

	public void Select()
	{
		selectionMarker.ToggleManual(isON: true);
	}

	public void Deselect()
	{
		selectionMarker.ToggleManual(isON: false);
	}
}
