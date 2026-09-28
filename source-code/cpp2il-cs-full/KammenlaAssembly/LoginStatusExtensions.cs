public static class LoginStatusExtensions
{
	public static bool IsFailingStatus(LoginStatus status)
	{
		//IL_001a: Expected O, but got I4
		//IL_0031: Expected O, but got I4
		//IL_003e: Expected I4, but got O
		bool flag = status < LoginStatus.OfflineGame;
		object obj = !flag;
		object obj2 = ~obj;
		object obj3 = 1840 >> (int)status;
		return (byte)(obj2 & obj3) != 0;
	}
}
