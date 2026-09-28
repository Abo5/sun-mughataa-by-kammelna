using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public static class ExitPopup
{
	public static void Show()
	{
		//IL_0998: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Expected O, but got Unknown
		//IL_09a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09aa: Expected O, but got Unknown
		//IL_09b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Expected O, but got Unknown
		//IL_09d0: Expected O, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0040: Expected I, but got O
		//IL_0050: Expected O, but got I
		//IL_0102: Expected O, but got I4
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		//IL_018f: Expected O, but got I
		//IL_01a7: Expected O, but got I
		//IL_008b: Expected O, but got I
		//IL_0245: Expected O, but got I
		//IL_0269: Expected O, but got I4
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_031a: Expected O, but got I
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_0341: Expected O, but got I
		//IL_01e2: Expected O, but got I
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected I, but got Unknown
		//IL_03d8: Expected O, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_0a93: Expected I, but got O
		//IL_037c: Expected O, but got I
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected I, but got Unknown
		//IL_02b7: Expected O, but got I
		//IL_0433: Expected O, but got I4
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected I, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Expected O, but got Unknown
		//IL_0475: Expected O, but got I
		//IL_038a: Unknown result type (might be due to invalid IL or missing references)
		//IL_038f: Expected O, but got Unknown
		//IL_0398: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_04b0: Expected O, but got I
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_0563: Unknown result type (might be due to invalid IL or missing references)
		//IL_0568: Expected I, but got Unknown
		//IL_0577: Expected O, but got I
		//IL_0593: Expected O, but got I4
		//IL_0673: Expected O, but got I
		//IL_0681: Expected I, but got O
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c3: Expected O, but got Unknown
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected I, but got Unknown
		//IL_06a7: Expected O, but got I
		//IL_06c3: Expected O, but got I4
		//IL_05c9: Expected O, but got I
		//IL_05eb: Expected O, but got I4
		//IL_05f4: Expected O, but got I4
		//IL_07c2: Expected O, but got I
		//IL_06f1: Expected O, but got I
		//IL_0613: Expected O, but got I4
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Expected O, but got Unknown
		//IL_0947: Expected I, but got O
		//IL_096b: Expected O, but got I4
		//IL_0835: Expected I, but got O
		//IL_0b41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b46: Expected O, but got Unknown
		//IL_0b79: Expected O, but got I
		//IL_0b99: Expected O, but got I4
		//IL_0baa: Expected O, but got I4
		//IL_072c: Expected O, but got I
		//IL_086c: Expected I, but got O
		//IL_087c: Expected O, but got I
		//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d5: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected O, but got Unknown
		//IL_091a: Expected O, but got I
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		//IL_08b7: Expected O, but got I
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected O, but got Unknown
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected O, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected O, but got Unknown
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d8: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E770A]");
		nint num = 0;
		object obj5 = default(object);
		object obj7 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj12 = default(object);
		IntPtr intPtr = default(IntPtr);
		object obj25 = default(object);
		Action action = default(Action);
		IntPtr intPtr2 = default(IntPtr);
		object obj48 = default(object);
		object obj50 = default(object);
		IntPtr intPtr3 = default(IntPtr);
		Action action2 = default(Action);
		object obj54 = default(object);
		while (true)
		{
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
			object obj4;
			if (popupWindowBuilderNeedsTitle != null)
			{
				object obj = typeof(System.IOAsyncCallback) + 392;
				object obj2 = "WhiteSmoke" + 2168;
				nint num2 = (nint)popupWindowBuilderNeedsTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00d4;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
				obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X10_v19-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj5 = obj4 + 16;
					obj3--;
					bool flag = (nint)obj3 != 1;
					obj4 = obj5;
					if (flag)
					{
						continue;
					}
					goto IL_00d4;
				}
				object obj6 = num2 + obj4;
				num = (nint)(obj6 + 312);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v332 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
				bool flag2 = obj7 == null;
				obj5 = obj4;
				if (!flag2)
				{
					goto IL_016f;
				}
			}
			goto IL_0981;
			IL_0864:
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj9;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X10_v1-8]");
					if (0 == (nint)obj9)
					{
						break;
					}
					obj5 += 16;
					obj8--;
					if ((nint)obj8 != 1)
					{
						continue;
					}
					goto IL_08f8;
				}
				goto IL_098f;
			}
			goto IL_08f8;
			IL_0775:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0b2d;
			IL_0b2d:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v879 @ X0_v36] (should have been resolved before IL gen)");
			object label = "COORDINATE_TYPE_GCJ_02" + 1864;
			PopupButton popupButton = PopupButton.Neutral((string)label, null, dismiss: true);
			object obj10 = obj9;
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v26+12E]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v26+12E]");
			bool flag3 = (nint)0 == 0;
			object obj14 = 0;
			PopupButton popupButton2 = popupButton;
			object obj15 = 0;
			PopupButton popupButton3 = popupButton;
			object obj16 = obj9;
			if (!flag3)
			{
				goto IL_07ac;
			}
			goto IL_0823;
			IL_0559:
			num = (nint)("COORDINATE_TYPE_GCJ_02" + 1864);
			PopupButton popupButton4 = PopupButton.Neutral((string)num, null, dismiss: true);
			bool flag4 = obj12 == null;
			obj14 = 0;
			obj5 = obj4;
			if (!flag4)
			{
				obj10 = obj9;
				obj11 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v26+12E]");
				obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v26+12E]");
				bool flag5 = (nint)0 == 0;
				object obj17 = !flag5;
				obj14 = 0;
				popupButton2 = popupButton4;
				if (obj17 != null)
				{
					goto IL_07ac;
				}
				obj15 = 0;
				popupButton3 = popupButton4;
				obj16 = obj9;
				goto IL_0823;
			}
			goto IL_0981;
			IL_00d4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v291 @ X0_v61 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag6 = obj7 == null;
			object obj18 = !flag6;
			obj4 = obj5;
			if (obj18 != null)
			{
				goto IL_016f;
			}
			num = intPtr;
			goto IL_0981;
			IL_04f9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0ad2;
			IL_016f:
			object obj19 = typeof(System.IOAsyncCallback) + 384;
			object obj20 = (nint)0 + (nint)2000;
			object obj21 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v13+12E]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v13+12E]");
			if ((nint)0 == 0)
			{
				goto IL_022b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v13+B0]");
			obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X10_v1-8]");
				if (0 == (nint)obj19)
				{
					break;
				}
				obj4 = obj5 + 16;
				obj22--;
				bool flag7 = (nint)obj22 != 1;
				obj5 = obj4;
				if (flag7)
				{
					continue;
				}
				goto IL_022b;
			}
			object obj23 = obj21 + obj5;
			num = (nint)(obj23 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+8]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v332 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag8 = obj25 == null;
			obj4 = obj5;
			if (!flag8)
			{
				goto IL_02e6;
			}
			goto IL_0981;
			IL_0ad2:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v659 @ X0_v15] (should have been resolved before IL gen)");
			object obj27;
			object obj26 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X0_v18+E4]");
			if ((nint)0 != 0)
			{
				Platform platform = KUtil.GetPlatform();
				if (platform == Platform.Web)
				{
					goto IL_0559;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Platform platform2 = KUtil.GetPlatform();
				if (platform2 == Platform.Web)
				{
					goto IL_0559;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj28 = (nint)0 + (nint)840;
			action..ctor(null, (IntPtr)obj28);
			num = (nint)("Cannot populate JSON object onto type '{0}'." + 3272);
			PopupButton popupButton5 = PopupButton.Neutral((string)num, action);
			bool flag9 = obj12 == null;
			obj14 = 0;
			obj5 = obj4;
			if (flag9)
			{
				goto IL_0981;
			}
			object obj29 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v33+12E]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v33+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0775;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v33+B0]");
			object obj31 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X10_v23-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				obj4 = obj31 + 16;
				obj30--;
				bool flag10 = (nint)obj30 != 1;
				obj31 = obj4;
				if (flag10)
				{
					continue;
				}
				goto IL_0775;
			}
			object obj32 = obj29 + obj31;
			object obj33 = obj32 + 312;
			obj4 = obj31;
			goto IL_0b2d;
			IL_098f:
			object obj34 = obj5 + 9;
			object obj35 = num + obj34;
			object obj36 = obj35 + 312;
			object obj37 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v5+8]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v339 @ X2_v2 (should have been resolved before IL gen)");
			continue;
			IL_07ac:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v26+B0]");
			obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X10_v1-8]");
				if (0 == (nint)obj10)
				{
					break;
				}
				obj4 = obj5 + 16;
				obj13--;
				bool flag11 = (nint)obj13 != 1;
				obj15 = obj14;
				popupButton3 = popupButton2;
				obj16 = obj10;
				obj5 = obj4;
				if (flag11)
				{
					continue;
				}
				goto IL_0823;
			}
			goto IL_0924;
			IL_022b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X0_v57 (Il2CppClass<System.NullReferenceException>)+8]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v464 @ X0_v57 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag12 = obj25 == null;
			object obj39 = !flag12;
			if (obj39 != null)
			{
				goto IL_02e6;
			}
			obj5 = obj4;
			num = intPtr2;
			goto IL_0981;
			IL_0981:
			ex = new NullReferenceException();
			goto IL_098f;
			IL_02e6:
			obj9 = typeof(System.IOAsyncCallback) + 368;
			object obj40 = typeof(SqlSingle[]) + 2376;
			object obj41 = (nint)0 + (nint)3848;
			object label2 = "LAK" + 2416;
			object obj42 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v15+12E]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v15+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03c5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v15+B0]");
			object obj44 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X10_v33-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				obj4 = obj44 + 16;
				obj43--;
				bool flag13 = (nint)obj43 != 1;
				obj44 = obj4;
				if (flag13)
				{
					continue;
				}
				goto IL_03c5;
			}
			object obj45 = obj44 + 4;
			object obj46 = obj42 + obj45;
			num = (nint)(obj46 + 312);
			obj4 = obj44;
			goto IL_0a71;
			IL_08f8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj47 = obj48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X0_v20+8]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v379 @ X2_v13 (should have been resolved before IL gen)");
			goto IL_0924;
			IL_0823:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj50;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v768 @ X0_v24] (should have been resolved before IL gen)");
			bool flag14 = ex == null;
			obj5 = obj4;
			if (!flag14)
			{
				goto IL_0864;
			}
			goto IL_0981;
			IL_0924:
			object obj51 = obj11 + obj5;
			object obj52 = obj51 + 312;
			num = (nint)obj52;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v788 @ X0_v28] (should have been resolved before IL gen)");
			bool flag15 = ex == null;
			object obj53 = !flag15;
			obj15 = obj14;
			if (obj53 != null)
			{
				goto IL_0864;
			}
			goto IL_0981;
			IL_03c5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj24 = 4;
			num = intPtr3;
			goto IL_0a71;
			IL_0a71:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v332 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action2..ctor(null, (IntPtr)obj41);
			PopupButton popupButton6 = PopupButton.Negative((string)label2, action2, dismiss: true);
			bool flag16 = obj54 == null;
			obj14 = 0;
			obj5 = obj4;
			if (flag16)
			{
				goto IL_0981;
			}
			obj27 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			object obj55 = obj54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v17+12E]");
			object obj56 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v17+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04f9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v17+B0]");
			object obj57 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X10_v28-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				obj4 = obj57 + 16;
				obj56--;
				bool flag17 = (nint)obj56 != 1;
				obj57 = obj4;
				if (flag17)
				{
					continue;
				}
				goto IL_04f9;
			}
			object obj58 = obj55 + obj57;
			object obj59 = obj58 + 312;
			obj4 = obj57;
			goto IL_0ad2;
		}
	}

	private static void CloseApp()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00aa: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E770B]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Application.Quit();
		return;
		IL_0074:
		Application.Quit();
	}
}
