public static class ClanUserTypeExtensions
{
	public const string MemberTitle = "عضو";

	public const string ModeratorTitle = "مشرف";

	public static string ToRoleTitle(ClanUserType type)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		object result = "{0} color encoding is currently unsupported for outputting to HDR." + 2416;
		object result2 = "{0} color encoding is currently unsupported for outputting to HDR." + 2312;
		if (type == ClanUserType.Moderator)
		{
			return (string)result;
		}
		return (string)result2;
	}

	public static ClanUserType ToUserType(string roleTitle)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object obj = "{0} color encoding is currently unsupported for outputting to HDR." + 2416;
		string text = default(string);
		return (text == (string)obj) ? ClanUserType.Moderator : ClanUserType.Member;
	}
}
