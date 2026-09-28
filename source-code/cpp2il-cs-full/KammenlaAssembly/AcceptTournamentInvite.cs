using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class AcceptTournamentInvite
{
	public static void Accept(int roomId, string tournamentPassword, GameObject gameObject, TournamentsEventsChannel eventsChannel)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentData tournamentData = default(TournamentData);
		tournamentData..ctor(roomId);
		TournamentParticipationUtil.Participate(gameObject, eventsChannel, tournamentData, tournamentPassword, null);
	}
}
