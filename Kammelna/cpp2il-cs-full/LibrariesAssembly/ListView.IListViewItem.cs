using System;

namespace ListView;

public interface IListViewItem<TData, TIndex> : IListViewItem where TData : IListViewItemData<TIndex>
{
	TData data { get; set; }

	Func<TIndex, IListViewItem<TData, TIndex>> getListItem { set; }

	Action<TData> RemoveSelf { set; }

	Action<TData> PinSelf { set; }

	void Setup(TData datum, bool firstTime);
}
