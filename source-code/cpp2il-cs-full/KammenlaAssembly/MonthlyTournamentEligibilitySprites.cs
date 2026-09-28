using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;

public class MonthlyTournamentEligibilitySprites : ScriptableObject
{
	private Sprite platinum;

	private Sprite gold;

	private Sprite silver;

	private Sprite bronze;

	public unsafe Sprite GetIcon(MonthlyTournamentEligibilityType type)
	{
		//IL_00c3: Expected O, but got Ref
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_012a: Expected O, but got I4
		switch (type)
		{
		case MonthlyTournamentEligibilityType.Bronze:
			return bronze;
		case MonthlyTournamentEligibilityType.Platinum:
			return platinum;
		case MonthlyTournamentEligibilityType.Gold:
			return gold;
		case MonthlyTournamentEligibilityType.Silver:
			return silver;
		default:
		{
			object obj = default(object);
			string text = ((Enum)(&obj)).ToString();
			object obj2 = "UInt16" + 2576;
			string text2 = (string)obj2 + text;
			object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1144;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X8_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			object obj6 = text2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = text2;
			}
			KLogger.LogError(obj6);
			break;
		}
		case MonthlyTournamentEligibilityType.NotEligible:
			break;
		}
		return null;
	}
}
