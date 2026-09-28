using TMPro;
using UnityEngine;

public class TournamentMessagePanel : TournamentMessage
{
	private GameObject messageSection;

	private TextMeshProUGUI messageText;

	public override void Initialize(TournamentData tournament)
	{
		GameObject gameObject = messageSection.gameObject;
		MessageTournamentAddon tournamentAddonsMessage = tournament.TournamentAddonsMessage;
		bool flag = tournamentAddonsMessage == null;
		bool active = !flag;
		gameObject.SetActive(active);
		MessageTournamentAddon tournamentAddonsMessage2 = tournament.TournamentAddonsMessage;
		TextMeshProExtensions.FixArabic(messageText, tournamentAddonsMessage2.<message>k__BackingField);
	}
}
