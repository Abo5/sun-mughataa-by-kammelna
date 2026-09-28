using Cpp2ILInjected;
using UnityEngine;

public class EligibilityIndicatorSprites : ScriptableObject
{
	private Sprite eligible;

	private Sprite notEligible;

	private Sprite eligibleToReserve;

	public Sprite GetIcon(TournamentEligibilityStatus status)
	{
		//IL_001a: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0042: Expected O, but got I4
		//IL_006b: Expected O, but got I4
		//IL_0082: Expected O, but got I
		bool flag = status < TournamentEligibilityStatus.EligibleToReserve;
		object obj = !flag;
		object obj2 = status - 2;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 == null)
		{
			object obj5 = (int)status << 3;
			object obj6 = (object)this + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v2+18]");
			return (Sprite)0;
		}
		return null;
	}
}
