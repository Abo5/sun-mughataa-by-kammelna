namespace KammelnaOffline.Baloot.Tutorial;

internal static class TutorialTypeExtensions
{
	public static bool IsCatchTutorial(TutorialType tutorialType)
	{
		//IL_000e: Expected O, but got I4
		//IL_001c: Expected O, but got I4
		//IL_0036: Expected O, but got I4
		//IL_0075: Expected O, but got I4
		//IL_0083: Expected I4, but got O
		//IL_0067: Expected O, but got I4
		object obj = tutorialType - 6;
		object obj2 = tutorialType - 3;
		bool flag = obj2 == null;
		object obj3 = !flag;
		object obj4 = ~obj3;
		object obj5;
		if (obj4 == null)
		{
			bool flag2 = (nint)obj < 7;
			obj5 = !flag2;
		}
		else
		{
			obj5 = 0;
		}
		return (byte)(int)(~obj5) != 0;
	}
}
