using Server.Models;
using TMPro;
using UnityEngine;

public class MassEligibilityInfoPopup : MonoBehaviour
{
	private TextMeshProUGUI eligibilityInfoText;

	private PopupUI popup;

	public void PopulateEligibilityInfoBubble(MassTournamentServerConnector connector)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		MassEventStageViewModel activeStage = connector.GetActiveStage();
		object text;
		if (activeStage.<Type>k__BackingField == MassEventStageType.ConstantPointsFilter)
		{
			text = "m_StencilDeferredPS" + 600;
		}
		else
		{
			MassEventStageViewModel activeStage2 = connector.GetActiveStage();
			if (activeStage2.<Type>k__BackingField != MassEventStageType.TournamentWinnersFilter)
			{
				return;
			}
			text = "m_StencilDeferredPS" + 608;
		}
		TextMeshProExtensions.Localize(eligibilityInfoText, (string)text);
	}

	public void ShowEligibilityInfoBubble()
	{
		popup.PopFromCenter();
	}

	public void HideEligibilityInfoBubble()
	{
		popup.ShrinkToParent();
	}
}
