using System.Collections.Generic;

public abstract class FriendsListSorter
{
	public abstract IEnumerable<FriendProfile> GetSortedList(IEnumerable<FriendProfile> friendList);

	public abstract IEnumerable<FriendListSection> GetSortedListWithHeaders(IEnumerable<FriendProfile> friendList);
}
