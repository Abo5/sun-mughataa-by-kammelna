using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Server.Models;
using UnityEngine;

public class MassDynamicPlayPeriodsInfoUI : MassWidget
{
	private Transform playPeriodsLayout;

	private Transform singlePlayPeriods;

	private PlayPeriodElement playPeriodElement;

	private PlayPeriodElement singlePlayPeriodElement;

	protected override void Initialize()
	{
		int activeStageId = ((MassTournamentServerConnector)(object)this).GetActiveStageId();
		PopulatePlayWindows(activeStageId);
	}

	private void Reload()
	{
		int activeStageId = ((MassTournamentServerConnector)(object)this).GetActiveStageId();
		PopulatePlayWindows(activeStageId);
	}

	public void PopulatePlayWindows(int stage)
	{
		//IL_0037: Expected O, but got I
		//IL_0043: Expected O, but got I
		//IL_0071: Expected O, but got I
		//IL_0360: Expected O, but got I
		//IL_0370: Expected O, but got I
		//IL_0386: Expected O, but got I
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_03ae: Expected O, but got I4
		//IL_03be: Expected O, but got I
		//IL_00a6: Expected O, but got I
		//IL_00bc: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I
		//IL_0420: Expected O, but got I
		//IL_0430: Expected O, but got I
		//IL_0446: Expected O, but got I
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected O, but got Unknown
		//IL_03f8: Expected O, but got I4
		//IL_012c: Expected O, but got I
		//IL_013c: Expected O, but got I
		//IL_0152: Expected O, but got I
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_017a: Expected O, but got I4
		//IL_018a: Expected O, but got I
		//IL_01b7: Expected O, but got I
		//IL_01de: Expected O, but got I
		//IL_0481: Expected O, but got I
		//IL_04a0: Expected O, but got I
		//IL_04b0: Expected O, but got I
		//IL_04c6: Expected O, but got I
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_04ee: Expected O, but got I4
		//IL_04fe: Expected O, but got I
		//IL_0213: Expected O, but got I
		//IL_0229: Expected O, but got I
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0256: Expected O, but got I
		//IL_0560: Expected O, but got I
		//IL_0570: Expected O, but got I
		//IL_0586: Expected O, but got I
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_05ae: Expected O, but got I4
		//IL_05be: Expected O, but got I
		//IL_0538: Expected O, but got I4
		//IL_030a: Expected O, but got I
		//IL_0333: Expected O, but got I4
		//IL_0299: Expected O, but got I
		//IL_02a9: Expected O, but got I
		//IL_02bf: Expected O, but got I
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02ec: Expected O, but got I
		//IL_060a: Expected O, but got I
		//IL_05e6: Expected O, but got I
		//IL_077a: Expected O, but got I
		//IL_078b: Expected O, but got I
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		//IL_07ab: Expected O, but got I
		//IL_07f4: Expected O, but got I4
		//IL_0691: Expected O, but got I
		//IL_06a7: Expected O, but got I
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		//IL_06e9: Expected O, but got I4
		//IL_0712: Expected O, but got I
		//IL_0853: Expected O, but got I
		//IL_0853: Expected O, but got I
		//IL_0863: Expected O, but got I
		//IL_0885: Expected O, but got I4
		//IL_0747: Expected O, but got I
		//IL_0747: Expected O, but got I
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)(object)this).GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		object obj = (nint)0 + (nint)3784;
		object obj2 = (nint)0 + (nint)3120;
		object obj3 = ((List<object>)(object)cachedMassEvent.<Stages>k__BackingField).get_Item(stage);
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X22_v4+38]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X22_v4+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v8+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v8+10]");
			object obj7 = (nint)0 + (nint)309;
			object obj8 = obj7 & 1;
			bool flag = obj8 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v8+10]");
			object obj9 = 0;
			if (!flag)
			{
				goto IL_00f7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X22_v4+38]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v15+10]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v15+10]");
			object obj11 = (nint)0 + (nint)309;
			object obj12 = obj11 & 1;
			bool flag2 = obj12 == null;
			object obj13 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v15+10]");
			object obj9 = 0;
			if (obj13 != null)
			{
				goto IL_00f7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 != null)
		{
			goto IL_011c;
		}
		goto IL_0406;
		IL_0289:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X22_v5+38]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v48+10]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v48+10]");
		object obj17 = (nint)0 + (nint)309;
		object obj18 = obj17 & 1;
		bool flag4 = obj18 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X8_v48+10]");
		object obj19 = 0;
		if (!flag4)
		{
			goto IL_02fa;
		}
		goto IL_05cc;
		IL_0546:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X22_v5+38]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v37+10]");
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v37+10]");
		object obj21 = (nint)0 + (nint)309;
		object obj22 = obj21 & 1;
		bool flag5 = obj22 == null;
		object obj23 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v37+10]");
		obj19 = 0;
		if (obj23 != null)
		{
			goto IL_02fa;
		}
		goto IL_05cc;
		IL_0264:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X0_v45+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0289;
		}
		goto IL_0546;
		IL_00f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v10+E4]");
		if ((nint)0 != 0)
		{
			goto IL_011c;
		}
		goto IL_0406;
		IL_0406:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X22_v4+38]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v10+10]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v10+10]");
		object obj26 = (nint)0 + (nint)309;
		object obj27 = obj26 & 1;
		if (obj27 == null)
		{
			goto IL_0198;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v10+10]");
		object obj28 = 0;
		goto IL_01a7;
		IL_05cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X0_v43+B8]");
		object except = 0;
		UIExtensions.DestroyAllChildren(singlePlayPeriods, (GameObject[])except);
		goto IL_05fa;
		IL_011c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X22_v4+38]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v57+10]");
		obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v57+10]");
		object obj30 = (nint)0 + (nint)309;
		object obj31 = obj30 & 1;
		bool flag6 = obj31 == null;
		object obj32 = !flag6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v57+10]");
		obj28 = 0;
		if (obj32 == null)
		{
			goto IL_0198;
		}
		goto IL_01a7;
		IL_0198:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_01a7;
		IL_01a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v18+B8]");
		object except2 = 0;
		UIExtensions.DestroyAllChildren(playPeriodsLayout, (GameObject[])except2);
		object obj33 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X22_v5+38]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X22_v5+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v20+10]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v20+10]");
			object obj36 = (nint)0 + (nint)309;
			object obj37 = obj36 & 1;
			bool flag7 = obj37 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X8_v20+10]");
			object obj38 = 0;
			if (!flag7)
			{
				goto IL_0264;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X22_v5+38]");
			object obj39 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v42+10]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v42+10]");
			object obj40 = (nint)0 + (nint)309;
			object obj41 = obj40 & 1;
			bool flag8 = obj41 == null;
			object obj42 = !flag8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v42+10]");
			object obj38 = 0;
			if (obj42 != null)
			{
				goto IL_0264;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X0_v45+E4]");
		bool flag9 = (nint)0 == 0;
		object obj43 = !flag9;
		if (obj43 != null)
		{
			goto IL_0289;
		}
		goto IL_0546;
		IL_0893:
		throw new NullReferenceException();
		IL_05fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v9 (System.Object)+50]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v22+18]");
		if ((nint)0 < (nint)2)
		{
			GameObject gameObject = playPeriodsLayout.gameObject;
			gameObject.SetActive(value: false);
			GameObject gameObject2 = singlePlayPeriods.gameObject;
			gameObject2.SetActive(value: true);
			object obj45 = (nint)0 + (nint)3736;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v9 (System.Object)+50]");
			object obj46 = ((List<object>)0).get_Item(0);
			object obj47 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj48 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X0_v37+E4]");
			bool flag10 = (nint)0 == 0;
			object obj49 = !flag10;
			if (obj49 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj50 = (nint)0 + (nint)576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v36 (System.Object)+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v36 (System.Object)+18]");
			PlayPeriodElement playPeriodElement = default(PlayPeriodElement);
			playPeriodElement.Populate(1, (DateTime)num, (DateTime)0);
			return;
		}
		GameObject gameObject3 = playPeriodsLayout.gameObject;
		gameObject3.SetActive(value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v9 (System.Object)+50]");
		List<object> list = (List<object>)0;
		object obj51 = (nint)0 + (nint)3736;
		object obj52 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj53 = (nint)0 + (nint)576;
		int num2 = 0;
		PlayPeriodElement playPeriodElement2 = default(PlayPeriodElement);
		object obj57;
		do
		{
			if (num2 < list._size)
			{
				object obj54 = list.get_Item(num2);
				object obj55 = obj52;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v26+E4]");
				bool flag11 = (nint)0 == 0;
				object obj56 = !flag11;
				if (obj56 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
				num2++;
				int index = num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v25 (System.Object)+10]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X0_v25 (System.Object)+18]");
				playPeriodElement2.Populate(index, (DateTime)num3, (DateTime)0);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v9 (System.Object)+50]");
				list = (List<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v9 (System.Object)+50]");
				bool flag12 = (nint)0 == 0;
				obj57 = !flag12;
				continue;
			}
			return;
		}
		while (obj57 != null);
		goto IL_0893;
		IL_02fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X0_v53+B8]");
		object except3 = 0;
		UIExtensions.DestroyAllChildren(singlePlayPeriods, (GameObject[])except3);
		bool flag13 = obj3 == null;
		object obj58 = !flag13;
		if (obj58 != null)
		{
			goto IL_05fa;
		}
		goto IL_0893;
	}
}
