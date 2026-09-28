public static class ClanPermissionsExtensions
{
	public static bool Can(ClanPermissions permissions, ClanPermissions permissionToCheck)
	{
		//IL_0009: Expected O, but got I4
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		object obj = ~permissions;
		object obj2 = permissionToCheck & obj;
		return obj2 == null;
	}

	public static bool HasAny(ClanPermissions permissions, ClanPermissions mask)
	{
		//IL_000d: Expected O, but got I4
		object obj = mask & permissions;
		bool flag = obj == null;
		return !flag;
	}
}
