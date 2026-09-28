using System.Collections.Generic;

namespace Kammelna.Server.WebRequests;

public interface IClientContext
{
	Games Game { get; }

	string Version { get; }

	Platform Platform { get; }

	GameType? GameType { get; }

	long? TournamentId { get; set; }

	TournamentType? TournamentType { get; set; }

	IEnumerable<(string, string)> GetRequestHeaders();
}
