using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Server.Models;
using UnityEngine;

public class MassTournamentPrizesPanel : MonoBehaviour
{
	private ThemeProvider themeProvider;

	private MassTournamentPrizeStrip prefab;

	private Transform layout;

	private PopupUI popup;

	private void Show()
	{
		popup.PopFromCenter();
	}

	public void Hide()
	{
		popup.ShrinkToParent();
	}

	public void Populate(MassEventModel massTournament)
	{
		//IL_0009: Expected O, but got I4
		//IL_0015: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_02d2: Expected O, but got I
		//IL_02f4: Expected O, but got I4
		//IL_0302: Expected O, but got I4
		//IL_030b: Expected O, but got I4
		//IL_0319: Expected O, but got I4
		//IL_0322: Expected O, but got I4
		//IL_00df: Expected O, but got I
		//IL_00f5: Expected O, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0122: Expected O, but got I
		//IL_006a: Expected O, but got I
		//IL_008f: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_00a6: Expected O, but got I4
		//IL_00af: Expected O, but got I4
		//IL_0414: Expected O, but got I4
		//IL_035c: Expected O, but got I
		//IL_036c: Expected O, but got I
		//IL_0382: Expected O, but got I
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_03aa: Expected O, but got I4
		//IL_03da: Expected O, but got I
		//IL_01a5: Expected O, but got I
		//IL_01b5: Expected O, but got I
		//IL_01cb: Expected O, but got I
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01f8: Expected O, but got I
		//IL_0502: Expected O, but got I
		//IL_045c: Expected O, but got I
		//IL_046c: Expected O, but got I
		//IL_0482: Expected O, but got I
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected O, but got Unknown
		//IL_04aa: Expected O, but got I4
		//IL_04da: Expected O, but got I
		//IL_0236: Expected O, but got I
		//IL_0265: Expected O, but got I4
		//IL_05ca: Expected O, but got I
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_05ea: Expected O, but got I
		//IL_05f6: Expected O, but got I
		//IL_06b7: Expected O, but got I4
		//IL_0642: Expected O, but got I4
		//IL_0788: Expected O, but got I4
		object obj = 152985600;
		object obj2 = (nint)0 + (nint)3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6084]");
		object obj3 = (nint)0 & (nint)1;
		Transform transform;
		MassTournamentPrizeStrip massTournamentPrizeStrip;
		MassEventPrizeViewModel massEventPrizeViewModel;
		object obj5;
		MassEventPrizeViewModel massEventPrizeViewModel2;
		object obj6;
		MassTournamentPrizeStrip massTournamentPrizeStrip2;
		Transform transform2;
		List<object>.Enumerator enumerator;
		if (obj3 != null)
		{
			transform = layout;
			massTournamentPrizeStrip = (MassTournamentPrizeStrip)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X22_v4 (MassTournamentPrizeStrip)+38]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X22_v4 (MassTournamentPrizeStrip)+38]");
			bool flag = (nint)0 == 0;
			massEventPrizeViewModel = null;
			obj5 = 0;
			enumerator = (List<object>.Enumerator)0;
			massEventPrizeViewModel2 = null;
			obj6 = 0;
			enumerator = (List<object>.Enumerator)0;
			massTournamentPrizeStrip2 = massTournamentPrizeStrip;
			transform2 = layout;
			if (!flag)
			{
				goto IL_00cf;
			}
		}
		else
		{
			_ = 1;
			transform = layout;
			massTournamentPrizeStrip = (MassTournamentPrizeStrip)obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X22_v4 (MassTournamentPrizeStrip)+38]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X22_v4 (MassTournamentPrizeStrip)+38]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			massEventPrizeViewModel = null;
			obj5 = 0;
			enumerator = (List<object>.Enumerator)0;
			massEventPrizeViewModel2 = null;
			obj6 = 0;
			enumerator = (List<object>.Enumerator)0;
			massTournamentPrizeStrip2 = massTournamentPrizeStrip;
			transform2 = layout;
			if (obj7 != null)
			{
				goto IL_00cf;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X22_v3 (MassTournamentPrizeStrip)+38]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v19+10]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v19+10]");
		object obj10 = (nint)0 + (nint)309;
		object obj11 = obj10 & 1;
		bool flag3 = obj11 == null;
		object obj12 = !flag3;
		massEventPrizeViewModel = massEventPrizeViewModel2;
		obj5 = obj6;
		massTournamentPrizeStrip = massTournamentPrizeStrip2;
		transform = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v19+10]");
		object obj13 = 0;
		if (obj12 != null)
		{
			goto IL_0150;
		}
		goto IL_03e8;
		IL_0774:
		NullReferenceException ex = new NullReferenceException();
		object obj14 = 0;
		MassEventModel massEventModel = null;
		GameObject[] array = (GameObject[])(object)layout;
		massEventPrizeViewModel2 = massEventPrizeViewModel;
		obj6 = obj5;
		List<object>.Enumerator enumerator2 = enumerator;
		massTournamentPrizeStrip2 = massTournamentPrizeStrip;
		goto IL_088d;
		IL_06c4:
		IThemeColorProfile themeColorProfile = massTournament.GenerateTheme();
		bool flag4 = (object)themeProvider == null;
		MassEventModel massEventModel2;
		massEventModel = massEventModel2;
		array = null;
		massEventPrizeViewModel2 = massEventPrizeViewModel;
		obj6 = obj5;
		massTournamentPrizeStrip2 = massTournamentPrizeStrip;
		if (!flag4)
		{
			themeProvider.UpdateTheme(themeColorProfile);
			bool flag5 = (object)popup == null;
			massEventModel = null;
			array = (GameObject[])(object)themeColorProfile;
			massEventPrizeViewModel2 = massEventPrizeViewModel;
			obj6 = obj5;
			massTournamentPrizeStrip2 = massTournamentPrizeStrip;
			if (!flag5)
			{
				popup.PopFromCenter();
				return;
			}
		}
		goto IL_088d;
		IL_088d:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag6 = (nint)array != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		object obj15 = default(object);
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			array = (GameObject[])obj15;
			enumerator2.Dispose();
			object obj16 = default(object);
			bool flag7 = obj16 == null;
			obj14 = obj16;
			massEventModel2 = massEventModel;
			massEventPrizeViewModel = massEventPrizeViewModel2;
			obj5 = obj6;
			massTournamentPrizeStrip = massTournamentPrizeStrip2;
			if (flag7)
			{
				goto IL_06c4;
			}
			ex3 = new OutOfMemoryException();
			obj14 = obj16;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237254");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_00cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v32+10]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v32+10]");
		object obj17 = (nint)0 + (nint)309;
		object obj18 = obj17 & 1;
		bool flag8 = obj18 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v32+10]");
		obj13 = 0;
		massEventPrizeViewModel2 = massEventPrizeViewModel;
		obj6 = obj5;
		massTournamentPrizeStrip2 = massTournamentPrizeStrip;
		transform2 = transform;
		if (!flag8)
		{
			goto IL_0150;
		}
		goto IL_03e8;
		IL_03e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v35+E4]");
		bool flag9 = (nint)0 == 0;
		object obj19 = !flag9;
		massEventPrizeViewModel = massEventPrizeViewModel2;
		obj5 = obj6;
		massTournamentPrizeStrip = massTournamentPrizeStrip2;
		transform = transform2;
		if (obj19 != null)
		{
			goto IL_0195;
		}
		goto IL_0442;
		IL_0150:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X0_v35+E4]");
		bool flag10 = (nint)0 == 0;
		massEventPrizeViewModel2 = massEventPrizeViewModel;
		obj6 = obj5;
		massTournamentPrizeStrip2 = massTournamentPrizeStrip;
		transform2 = transform;
		if (!flag10)
		{
			goto IL_0195;
		}
		goto IL_0442;
		IL_0442:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X22_v3 (MassTournamentPrizeStrip)+38]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v13+10]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v13+10]");
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		bool flag11 = obj23 == null;
		object obj24 = !flag11;
		massEventPrizeViewModel = massEventPrizeViewModel2;
		obj5 = obj6;
		massTournamentPrizeStrip = massTournamentPrizeStrip2;
		transform = transform2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v13+10]");
		object obj25 = 0;
		if (obj24 != null)
		{
			goto IL_0226;
		}
		goto IL_04e8;
		IL_0195:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X22_v4 (MassTournamentPrizeStrip)+38]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v27+10]");
		obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v27+10]");
		object obj27 = (nint)0 + (nint)309;
		object obj28 = obj27 & 1;
		bool flag12 = obj28 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v27+10]");
		obj25 = 0;
		massEventPrizeViewModel2 = massEventPrizeViewModel;
		obj6 = obj5;
		massTournamentPrizeStrip2 = massTournamentPrizeStrip;
		transform2 = transform;
		if (!flag12)
		{
			goto IL_0226;
		}
		goto IL_04e8;
		IL_04e8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v33+B8]");
		object obj29 = 0;
		GameObject[] array2 = (GameObject[])obj29;
		UIExtensions.DestroyAllChildren(transform2, (GameObject[])obj29);
		bool flag13 = massTournament == null;
		massEventModel2 = null;
		massEventPrizeViewModel = massEventPrizeViewModel2;
		obj5 = obj6;
		massTournamentPrizeStrip = massTournamentPrizeStrip2;
		massEventModel = null;
		array = (GameObject[])obj29;
		enumerator2 = enumerator;
		if (!flag13)
		{
			goto IL_056b;
		}
		goto IL_088d;
		IL_0226:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v65+B8]");
		obj29 = 0;
		array = (GameObject[])obj29;
		UIExtensions.DestroyAllChildren(transform, (GameObject[])obj29);
		bool flag14 = massTournament == null;
		object obj30 = !flag14;
		massEventModel2 = null;
		array2 = (GameObject[])obj29;
		if (obj30 != null)
		{
			goto IL_056b;
		}
		massEventModel = null;
		massEventPrizeViewModel2 = massEventPrizeViewModel;
		obj6 = obj5;
		enumerator2 = enumerator;
		massTournamentPrizeStrip2 = massTournamentPrizeStrip;
		goto IL_088d;
		IL_056b:
		bool flag15 = massTournament.<Prizes>k__BackingField == null;
		massEventModel = massEventModel2;
		array = array2;
		massEventPrizeViewModel2 = massEventPrizeViewModel;
		obj6 = obj5;
		enumerator2 = enumerator;
		massTournamentPrizeStrip2 = massTournamentPrizeStrip;
		if (!flag15)
		{
			object obj31 = (nint)0 + (nint)3256;
			object obj32 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj33 = (nint)0 + (nint)968;
			obj15 = (nint)0 + (nint)3248;
			List<object>.Enumerator enumerator3 = ((List<object>)(object)massTournament.<Prizes>k__BackingField).GetEnumerator();
			MassTournamentPrizeStrip massTournamentPrizeStrip3 = default(MassTournamentPrizeStrip);
			while (enumerator.MoveNext())
			{
				massTournamentPrizeStrip = prefab;
				object obj34 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v26+E4]");
				bool flag16 = (nint)0 == 0;
				object obj35 = !flag16;
				if (obj35 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
				if ((object)massTournamentPrizeStrip3 != null)
				{
					massTournamentPrizeStrip3.Populate(massEventPrizeViewModel, massTournament);
					massEventModel2 = massTournament;
					continue;
				}
				goto IL_0774;
			}
			enumerator.Dispose();
			obj14 = 0;
			enumerator2 = enumerator;
			goto IL_06c4;
		}
		goto IL_088d;
	}
}
