using System;
using System.Buffers.Text;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.UI;

public class SettingsTabletToggle : MonoBehaviour
{
	private ToggleGroup toggleGroup;

	private GameObject[] toBeHidden;

	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_0178: Expected O, but got I4
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02f8: Expected O, but got I4
		//IL_01bc: Expected O, but got I
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_0321: Expected O, but got I
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0226: Expected O, but got I
		//IL_0232: Expected O, but got I
		//IL_023b: Expected O, but got I4
		//IL_0244: Expected O, but got I4
		//IL_03a4: Expected O, but got I
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		object obj = (nint)0 + (nint)168;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj3 = this + 32;
		object obj4 = default(object);
		obj3 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Platform platform = KUtil.GetPlatform();
			if (platform != Platform.Android)
			{
				goto IL_0088;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Platform platform2 = KUtil.GetPlatform();
			if (platform2 != Platform.Android)
			{
				goto IL_0088;
			}
		}
		goto IL_0118;
		IL_0118:
		if (ScreenUtility.IsTabletSize)
		{
			object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool forceTablet = Preferences.ForceTablet;
			ToggleGroupExtensions.SetSelectedIndex((ToggleGroup)obj3, forceTablet ? 1 : 0);
			object obj9 = (nint)0 + (nint)760;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v22+18]");
			if ((nint)0 >= (nint)1)
			{
				object obj12 = default(object);
				object obj11 = obj12 + 32;
				object obj13 = typeof(TypeConverter<ushort, char>) + 360;
				object obj14 = (nint)0 + (nint)3368;
				object obj15 = (nint)0 + (nint)832;
				object obj16 = 0;
				object obj17 = 0;
				bool flag2;
				object obj20 = default(object);
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X24_v4+v213 @ X23_v5*8]");
					object obj18 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4027FE0");
					obj16++;
					obj17 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4029444");
					object obj19 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v22+18]");
					flag2 = (nint)obj19 < 0;
					obj10 = obj20;
				}
				while (flag2);
			}
			return;
		}
		goto IL_02b3;
		IL_02b3:
		GameObject[] array = toBeHidden;
		if (array.Length >= 1)
		{
			object obj21 = array + 32;
			object obj22 = 0;
			do
			{
				obj22++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X21_v6+v277 @ X20_v8*8]");
				((GameObject)0).SetActive(value: false);
			}
			while ((nint)obj22 < array.Length);
		}
		return;
		IL_0088:
		object obj23 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v29+E4]");
		if ((nint)0 != 0)
		{
			Platform platform3 = KUtil.GetPlatform();
			if (platform3 == Platform.Huawei)
			{
				goto IL_0118;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Platform platform4 = KUtil.GetPlatform();
			if (platform4 == Platform.Huawei)
			{
				goto IL_0118;
			}
		}
		goto IL_02b3;
	}

	private void ToggleChanged(bool isOn)
	{
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Expected O, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected O, but got Unknown
		//IL_062f: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006b: Expected I, but got O
		//IL_007b: Expected O, but got I
		//IL_012d: Expected O, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01d6: Expected O, but got I
		//IL_00b6: Expected O, but got I
		//IL_06b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Expected O, but got Unknown
		//IL_06ce: Expected O, but got I
		//IL_06dc: Expected I, but got O
		//IL_06e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected I, but got Unknown
		//IL_06fd: Expected O, but got I
		//IL_0211: Expected O, but got I
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected I, but got Unknown
		//IL_02b1: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02f3: Expected O, but got I
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_074a: Expected O, but got I
		//IL_0758: Expected I, but got O
		//IL_0762: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected I, but got Unknown
		//IL_0779: Expected O, but got I
		//IL_032e: Expected O, but got I
		//IL_03c6: Expected O, but got I4
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_03f4: Expected O, but got I
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_048a: Expected I, but got O
		//IL_04ac: Expected O, but got I4
		//IL_042f: Expected O, but got I
		//IL_04ca: Expected I, but got O
		//IL_04da: Expected O, but got I
		//IL_0578: Expected O, but got I
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Expected O, but got Unknown
		//IL_05a5: Expected I, but got O
		//IL_05c9: Expected O, but got I4
		//IL_05d2: Expected O, but got I4
		//IL_0515: Expected O, but got I
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		//IL_044b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Expected O, but got Unknown
		//IL_07c5: Expected O, but got I4
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E68C2]");
		object obj5 = default(object);
		object obj7 = default(object);
		Action action = default(Action);
		object obj10 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj22 = default(object);
		IntPtr intPtr = default(IntPtr);
		Action action2 = default(Action);
		object obj33 = default(object);
		object obj36 = default(object);
		object obj38 = default(object);
		object obj39;
		object obj40;
		object obj41;
		object obj42;
		object obj43;
		for (nint num = 0; isOn; obj39 = obj5 + 9, obj40 = num + obj39, obj41 = obj40 + 312, obj42 = obj41, Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v5+8]"), obj43 = 0, Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v88 @ X2_v2 (should have been resolved before IL gen)"))
		{
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
			object obj4;
			if (popupWindowBuilderNeedsTitle != null)
			{
				object obj = typeof(System.IOAsyncCallback) + 392;
				object obj2 = "Complete" + 256;
				nint num2 = (nint)popupWindowBuilderNeedsTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00ff;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v11 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
				obj4 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X10_v12-8]");
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
					goto IL_00ff;
				}
				object obj6 = num2 + obj4;
				num = (nint)(obj6 + 312);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v343 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
				bool flag2 = obj7 == null;
				obj5 = obj4;
				if (!flag2)
				{
					goto IL_019b;
				}
			}
			goto IL_05e0;
			IL_069a:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v466 @ X8_v18] (should have been resolved before IL gen)");
			object obj8 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)3352;
			action..ctor(this, (IntPtr)obj9);
			num = (nint)("Network Authentication Required" + 3128);
			PopupButton popupButton = PopupButton.Neutral((string)num, action);
			bool flag3 = obj10 == null;
			object obj11 = 0;
			obj5 = obj4;
			if (flag3)
			{
				goto IL_05e0;
			}
			object obj12 = typeof(System.IOAsyncCallback) + 368;
			object obj13 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v23+12E]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v23+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0377;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v23+B0]");
			object obj15 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X10_v20-8]");
				if (0 == (nint)obj12)
				{
					break;
				}
				obj4 = obj15 + 16;
				obj14--;
				bool flag4 = (nint)obj14 != 1;
				obj15 = obj4;
				if (flag4)
				{
					continue;
				}
				goto IL_0377;
			}
			object obj16 = obj13 + obj15;
			object obj17 = obj16 + 312;
			obj4 = obj15;
			goto IL_072a;
			IL_0582:
			object obj19;
			object obj18 = obj19 + obj5;
			object obj20 = obj18 + 312;
			num = (nint)obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v592 @ X0_v28] (should have been resolved before IL gen)");
			bool flag5 = ex == null;
			object obj21 = !flag5;
			obj11 = 0;
			if (obj21 != null)
			{
				goto IL_04c2;
			}
			goto IL_05e0;
			IL_0478:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v577 @ X0_v25] (should have been resolved before IL gen)");
			bool flag6 = ex == null;
			obj11 = 0;
			obj5 = obj4;
			if (!flag6)
			{
				goto IL_04c2;
			}
			goto IL_05e0;
			IL_04c2:
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X10_v1-8]");
					bool flag7 = 0 == (nint)obj12;
					obj11 = 0;
					if (flag7)
					{
						break;
					}
					obj5 += 16;
					obj23--;
					if ((nint)obj23 != 1)
					{
						continue;
					}
					goto IL_0556;
				}
				continue;
			}
			goto IL_0556;
			IL_05e0:
			ex = new NullReferenceException();
			continue;
			IL_00ff:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v322 @ X0_v36 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag8 = obj7 == null;
			object obj24 = !flag8;
			obj4 = obj5;
			if (obj24 != null)
			{
				goto IL_019b;
			}
			num = intPtr;
			goto IL_05e0;
			IL_0377:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_072a;
			IL_019b:
			object obj25 = typeof(System.IOAsyncCallback) + 384;
			object obj26 = "Added Tournament Prizes And Features" + 2208;
			object obj27 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v17+12E]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v17+12E]");
			if ((nint)0 == 0)
			{
				goto IL_025a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v17+B0]");
			object obj29 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X10_v25-8]");
				if (0 == (nint)obj25)
				{
					break;
				}
				obj4 = obj29 + 16;
				obj28--;
				bool flag9 = (nint)obj28 != 1;
				obj29 = obj4;
				if (flag9)
				{
					continue;
				}
				goto IL_025a;
			}
			object obj30 = obj27 + obj29;
			object obj31 = obj30 + 312;
			obj4 = obj29;
			goto IL_069a;
			IL_072a:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v542 @ X0_v14] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj32 = (nint)0 + (nint)3360;
			action2..ctor(this, (IntPtr)obj32);
			num = (nint)("COORDINATE_TYPE_GCJ_02" + 1864);
			PopupButton popupButton2 = PopupButton.Neutral((string)num, action2, dismiss: true);
			bool flag10 = obj33 == null;
			obj11 = 0;
			obj5 = obj4;
			if (!flag10)
			{
				obj19 = obj33;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v30+12E]");
				object obj34 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v30+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0478;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v30+B0]");
				obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X10_v1-8]");
					if (0 == (nint)obj12)
					{
						break;
					}
					obj4 = obj5 + 16;
					obj34--;
					bool flag11 = (nint)obj34 != 1;
					obj5 = obj4;
					if (flag11)
					{
						continue;
					}
					goto IL_0478;
				}
				goto IL_0582;
			}
			goto IL_05e0;
			IL_0556:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj35 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X0_v22+8]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v87 @ X2_v15 (should have been resolved before IL gen)");
			goto IL_0582;
			IL_025a:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj31 = obj38;
			goto IL_069a;
		}
	}

	private void <ToggleChanged>g__Switch|3_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I4
		//IL_0036: Expected O, but got I4
		//IL_0078: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj2 = typeof(RegisteredWaitHandle) + 3136;
		int selectedIndex = ToggleGroupExtensions.GetSelectedIndex(toggleGroup);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = selectedIndex - 1;
		bool forceTablet = obj5 == null;
		Preferences.ForceTablet = forceTablet;
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
	}

	private void <ToggleChanged>g__Undo|3_1()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		toggleGroup.SetAllTogglesOff();
		GameObject gameObject = toggleGroup.gameObject;
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		gameObject.SetActive(value: false);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool forceTablet = Preferences.ForceTablet;
		ToggleGroupExtensions.SetSelectedIndex(toggleGroup, forceTablet ? 1 : 0);
		GameObject gameObject2 = toggleGroup.gameObject;
		gameObject2.SetActive(value: true);
	}
}
