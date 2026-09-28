public static class SalesChannelsExtension
{
	public static bool IsUnityPurchasable(SalesChannel s)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		//IL_00d2: Expected O, but got I4
		//IL_00db: Expected I4, but got O
		//IL_0079: Expected O, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		object obj = s - 9;
		bool flag = (nint)obj < 12;
		object obj2 = !flag;
		object obj3 = obj - 12;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = 7449 >> (int)obj;
			object obj7 = obj6 & 1;
			if (obj7 != null)
			{
				return true;
			}
		}
		object obj8 = s - 27;
		bool flag3 = (nint)obj8 < 2;
		object obj9 = !flag3;
		return (byte)(int)(~obj9) != 0;
	}

	public static bool IsWebPurchasable(SalesChannel s)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_004d: Expected O, but got I4
		object obj = s - 29;
		bool flag = obj == null;
		object obj2 = !flag;
		object obj3 = ~obj2;
		bool result;
		if (obj3 == null)
		{
			object obj4 = s - 35;
			result = obj4 == null;
		}
		else
		{
			result = true;
		}
		if (s == SalesChannel.TwoCo)
		{
			return true;
		}
		return result;
	}

	public static bool IsGooglePlay(SalesChannel s)
	{
		//IL_001a: Expected O, but got I4
		//IL_0031: Expected O, but got I4
		//IL_003e: Expected I4, but got O
		bool flag = s < SalesChannel.Adsense;
		object obj = !flag;
		object obj2 = ~obj;
		object obj3 = 2109440 >> (int)s;
		return (byte)(obj2 & obj3) != 0;
	}

	public static bool IsIOS(SalesChannel s)
	{
		//IL_001a: Expected O, but got I4
		//IL_0031: Expected O, but got I4
		//IL_003e: Expected I4, but got O
		bool flag = s < SalesChannel.GooglePlayGameStore;
		object obj = !flag;
		object obj2 = ~obj;
		object obj3 = 1704448 >> (int)s;
		return (byte)(obj2 & obj3) != 0;
	}

	public static bool IsHuawei(SalesChannel s)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Expected I4, but got O
		object obj = s - 27;
		bool flag = (nint)obj < 2;
		object obj2 = !flag;
		return (byte)(int)(~obj2) != 0;
	}

	public static bool IsTwoCo(SalesChannel s)
	{
		//IL_000e: Expected O, but got I4
		object obj = s - 6;
		return obj == null;
	}

	public static bool IsUrway(SalesChannel s)
	{
		//IL_000e: Expected O, but got I4
		object obj = s - 29;
		return obj == null;
	}

	public static bool IsStcPay(SalesChannel s)
	{
		//IL_000e: Expected O, but got I4
		object obj = s - 26;
		return obj == null;
	}
}
