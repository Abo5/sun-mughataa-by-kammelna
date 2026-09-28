using System.Collections.Generic;

public interface ITournamentFilter
{
	IEnumerable<TournamentModel> ApplyFilter(IEnumerable<TournamentModel> tournaments);

	List<TournamentListGroup> CreateGrouping(List<TournamentModel> tournaments);
}
