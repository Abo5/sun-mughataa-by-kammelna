using System;
using ListView;

public class ChallengeHistoryListDataTitle : IListViewItemData<int>
{
	private readonly DateTime <Date>k__BackingField;

	private readonly int <index>k__BackingField;

	public DateTime Date => <Date>k__BackingField;

	public int index => <index>k__BackingField;

	public string template => "FilterFunction '{0}' expects {1} parameters but only {2} were provided. Missing parameters will be set to their default values." + 1440;

	public ChallengeHistoryListDataTitle(DateTime date, int index)
	{
		<Date>k__BackingField = date;
		<index>k__BackingField = index;
	}
}
