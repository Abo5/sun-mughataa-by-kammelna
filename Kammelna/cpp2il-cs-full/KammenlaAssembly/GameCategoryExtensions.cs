public static class GameCategoryExtensions
{
	public static GameCategory ToGameCategory(Games games)
	{
		//IL_001a: Expected O, but got I4
		bool flag = games < (Games)3;
		object obj = !flag;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			return GameCategory.Common;
		}
		return (GameCategory)(games + 1);
	}
}
