using System;

namespace ListView;

public interface INestedListViewItem<TData, TIndex> : INestedListViewItem, IListViewItem, IListViewItem<TData, TIndex> where TData : IListViewItemData<TIndex>
{
	event Action<TData> toggleExpanded;
}
