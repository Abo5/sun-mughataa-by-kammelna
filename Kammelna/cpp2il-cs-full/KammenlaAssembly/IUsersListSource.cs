using System;

public interface IUsersListSource
{
	void GetUsersList(Action<UsersListModel> callback);
}
