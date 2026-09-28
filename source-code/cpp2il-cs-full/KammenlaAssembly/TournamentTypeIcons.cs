using Cpp2ILInjected;
using UnityEngine;

public class TournamentTypeIcons : ScriptableObject
{
	public Sprite Public;

	public Sprite Private;

	public Sprite Official;

	public Sprite Monthly;

	public Sprite Mass;

	public Sprite GetSprite(TournamentType tType)
	{
		//IL_001a: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0042: Expected O, but got I4
		//IL_006c: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_0089: Expected O, but got I
		bool flag = tType < TournamentType.OfficialMonthly;
		object obj = !flag;
		object obj2 = tType - 4;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 == null)
		{
			object obj5 = 119873536 + 3504;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v2+tType @ X1 (TournamentType)*8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentTypeIcons)+v14 @ X8_v3]");
			return (Sprite)0;
		}
		return null;
	}
}
