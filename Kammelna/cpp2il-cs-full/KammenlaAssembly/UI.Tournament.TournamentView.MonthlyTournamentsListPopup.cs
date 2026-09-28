using UnityEngine;

namespace UI.Tournament.TournamentView;

public class MonthlyTournamentsListPopup : MonoBehaviour, IInitializable
{
	private SlideAnimationHelper slider;

	private void ShowMonthlyTournamentsList()
	{
		slider.SlideIn();
	}

	public void Initialize()
	{
		slider.SlideIn();
	}
}
