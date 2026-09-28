namespace Server.Models;

public static class TicketTypeExtensions
{
	public static TicketType GetTicketType(TournamentType tournamentType)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		object obj = tournamentType - 3;
		bool flag = obj == null;
		object obj2 = !flag;
		object obj3 = ~obj2;
		TicketType result = ((obj3 != null) ? TicketType.OfficialTournament : ((TicketType)(-1)));
		if (tournamentType == TournamentType.Public)
		{
			return TicketType.PublicTournament;
		}
		return result;
	}
}
