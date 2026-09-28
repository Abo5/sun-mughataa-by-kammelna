using ListView;

public class Matchup : IGridViewItemData<int>, IListViewItemData<int>
{
	public QueueTeam[] teams;

	private int <index>k__BackingField;

	public int index
	{
		get
		{
			return <index>k__BackingField;
		}
		set
		{
			<index>k__BackingField = value;
		}
	}

	public string template => "LAK" + 3976;

	public int columns => 1;
}
