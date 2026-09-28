using UnityEngine;

public class MassPlayPeriodsInfoPopup : MonoBehaviour
{
	private PopupUI popup;

	private MassPlayPeriodsInfoUI info;

	public void ShowPlayPeriodsInfoBubble()
	{
		popup.PopFromCenter();
	}

	public void HidePlayPeriodsInfoBubble()
	{
		popup.ShrinkToParent();
	}
}
