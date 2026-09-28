using System;
using Cpp2ILInjected;
using UnityEngine;

public class SwappingTournamentPrizeUi : TournamentPrizeUi
{
	private TournamentPrizeUi singlePrizeUi;

	private TournamentPrizeUi multiplePrizesUi;

	public override void Initialize(TournamentData tournament)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0032: Expected O, but got I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_00df: Expected O, but got I4
		//IL_0152: Expected I, but got O
		//IL_0162: Expected O, but got I
		//IL_0172: Expected O, but got I
		object obj = (??)tournament.<SecondPrize>k__BackingField & 1;
		bool flag = obj == null;
		object obj2 = !flag;
		TournamentPrizeUi tournamentPrizeUi;
		if (obj2 == null)
		{
			object obj3 = (??)tournament.<ThirdPrize>k__BackingField & 1;
			if (obj3 == null)
			{
				GameObject gameObject = multiplePrizesUi.gameObject;
				gameObject.SetActive(value: false);
				GameObject gameObject2 = singlePrizeUi.gameObject;
				gameObject2.SetActive(value: true);
				tournamentPrizeUi = singlePrizeUi;
				goto IL_014a;
			}
		}
		GameObject gameObject3 = singlePrizeUi.gameObject;
		gameObject3.SetActive(value: false);
		GameObject gameObject4 = multiplePrizesUi.gameObject;
		gameObject4.SetActive(value: true);
		tournamentPrizeUi = multiplePrizesUi;
		bool flag2 = (object)multiplePrizesUi == null;
		object obj4 = !flag2;
		if (obj4 != null)
		{
			goto IL_014a;
		}
		goto IL_017c;
		IL_014a:
		nint num = (nint)tournamentPrizeUi;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6 (Il2CppClass<TournamentPrizeUi>)+178]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6 (Il2CppClass<TournamentPrizeUi>)+180]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v96 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_017c;
		IL_017c:
		throw new NullReferenceException();
	}
}
