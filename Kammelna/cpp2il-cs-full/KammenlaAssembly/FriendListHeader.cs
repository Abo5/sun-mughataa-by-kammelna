using ListView;

public class FriendListHeader : ListViewItem<IListViewItemData<int>, int>
{
	public FriendListHeader()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
