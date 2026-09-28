using ListView;

public interface IGridViewItemData<TIndex> : IListViewItemData<TIndex>
{
	int columns { get; }
}
