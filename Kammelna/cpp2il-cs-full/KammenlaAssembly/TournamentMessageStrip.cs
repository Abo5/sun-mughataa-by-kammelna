using TMPro;

public class TournamentMessageStrip : TournamentMessage
{
	private TextMeshProUGUI messageText;

	public override void Initialize(TournamentData tournament)
	{
		MessageTournamentAddon tournamentAddonsMessage = tournament.TournamentAddonsMessage;
		TextMeshProExtensions.FixArabic(messageText, tournamentAddonsMessage.<message>k__BackingField);
	}
}
