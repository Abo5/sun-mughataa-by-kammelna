using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public abstract class KammelnaSettingsBase<T> : ScriptableObject where T : KammelnaSettingsBase<T>
{
	private const string RESOURCES_FOLDER = "Settings";

	private static T _instance;

	public static T Instance
	{
		get
		{
			//IL_06ae: Expected O, but got I
			//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bc: Expected O, but got Unknown
			//IL_06d6: Expected O, but got I4
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_003e: Expected O, but got I
			//IL_0054: Expected O, but got I
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Expected O, but got Unknown
			//IL_007c: Expected O, but got I4
			//IL_00a9: Expected O, but got I
			//IL_00d3: Expected O, but got I4
			//IL_010a: Expected O, but got I
			//IL_0229: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Expected O, but got Unknown
			//IL_0248: Expected O, but got I4
			//IL_027a: Expected O, but got I4
			//IL_028a: Expected O, but got I
			//IL_02ac: Expected O, but got I4
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Expected O, but got Unknown
			//IL_014b: Expected O, but got I4
			//IL_0154: Expected O, but got I4
			//IL_0168: Expected O, but got I4
			//IL_02da: Expected O, but got I
			//IL_01b0: Expected O, but got I
			//IL_01c6: Expected O, but got I
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Expected O, but got Unknown
			//IL_01ee: Expected O, but got I4
			//IL_021b: Expected O, but got I
			//IL_0312: Unknown result type (might be due to invalid IL or missing references)
			//IL_0317: Expected O, but got Unknown
			//IL_0334: Expected O, but got I
			//IL_033d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0342: Expected O, but got Unknown
			//IL_035c: Expected O, but got I4
			//IL_0700: Expected O, but got I
			//IL_0709: Unknown result type (might be due to invalid IL or missing references)
			//IL_070e: Expected O, but got Unknown
			//IL_053e: Expected O, but got I
			//IL_054e: Expected O, but got I
			//IL_0564: Expected O, but got I
			//IL_056d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0572: Expected O, but got Unknown
			//IL_058c: Expected O, but got I4
			//IL_059c: Expected O, but got I
			//IL_03f0: Expected O, but got I
			//IL_0404: Expected O, but got I
			//IL_040d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0412: Expected O, but got Unknown
			//IL_038f: Expected O, but got I
			//IL_03a5: Expected O, but got I
			//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b3: Expected O, but got Unknown
			//IL_03d2: Expected O, but got I
			//IL_062e: Expected O, but got I
			//IL_063e: Expected O, but got I
			//IL_0654: Expected O, but got I
			//IL_065d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0662: Expected O, but got Unknown
			//IL_05c4: Expected O, but got I
			//IL_05d8: Expected O, but got I
			//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e6: Expected O, but got Unknown
			//IL_0600: Expected O, but got I4
			//IL_044b: Expected O, but got I
			//IL_0461: Expected O, but got I
			//IL_046a: Unknown result type (might be due to invalid IL or missing references)
			//IL_046f: Expected O, but got Unknown
			//IL_0489: Expected O, but got I4
			//IL_0499: Expected O, but got I
			//IL_04cc: Expected O, but got I
			//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04da: Expected O, but got Unknown
			//IL_04f2: Expected O, but got I4
			//IL_068f: Expected O, but got I
			//IL_0517: Expected O, but got I4
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			bool flag = obj2 == null;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5 (Il2CppRgctx<KammelnaSettingsBase`1>)+10]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v5 (Il2CppRgctx<KammelnaSettingsBase`1>)+10]");
			object obj6 = (nint)0 + (nint)309;
			object obj7 = obj6 & 1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v5+B8]");
			object obj9 = 0;
			object obj10 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag4 = (UnityEngine.Object)obj9 != null;
			object obj12 = (nint)0 + (nint)309;
			object obj15;
			UnityEngine.Object obj16;
			nint num2;
			object obj17;
			UnityEngine.Object obj18;
			if (flag4)
			{
				object obj13 = obj12 & 1;
				bool flag5 = obj13 == null;
				object obj14 = !flag5;
				obj15 = 0;
				obj16 = null;
				num2 = 0;
				obj17 = 0;
				obj18 = null;
				if (obj14 == null)
				{
					goto IL_017b;
				}
				goto IL_019a;
			}
			object obj19 = obj12 & 1;
			bool flag6 = obj19 == null;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			nint num3 = 0;
			object obj21 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v13+E0]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v12+E4]");
			bool flag7 = (nint)0 == 0;
			object obj23 = !flag7;
			if (obj23 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v11 (Il2CppRgctx<KammelnaSettingsBase`1>)+18]");
			Type typeFromHandle = Type.GetTypeFromHandle((RuntimeTypeHandle)0);
			UnityEngine.Object obj39 = default(UnityEngine.Object);
			nint num6;
			if ((object)typeFromHandle != null)
			{
				string text = typeFromHandle.Name;
				object obj24 = "SetRoomVariables request error" + 184;
				string text2 = (string)obj24 + text;
				object obj25 = (nint)0 + (nint)309;
				object obj26 = obj25 & 1;
				bool flag8 = obj26 == null;
				object obj27 = !flag8;
				if (obj27 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FF8ABC");
				object obj28 = (nint)0 + (nint)309;
				object obj29 = obj28 & 1;
				if (obj29 != null)
				{
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v46 (Il2CppRgctx<KammelnaSettingsBase`1>)+10]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v46 (Il2CppRgctx<KammelnaSettingsBase`1>)+10]");
					object obj31 = (nint)0 + (nint)309;
					object obj32 = obj31 & 1;
					bool flag9 = obj32 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X8_v46 (Il2CppRgctx<KammelnaSettingsBase`1>)+10]");
					object obj33 = 0;
					if (!flag9)
					{
						goto IL_03e0;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v29+C0]");
					object obj34 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v31+10]");
					object obj30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v31+10]");
					object obj35 = (nint)0 + (nint)309;
					object obj36 = obj35 & 1;
					bool flag10 = obj36 == null;
					object obj37 = !flag10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X8_v31+10]");
					object obj33 = 0;
					if (obj37 != null)
					{
						goto IL_03e0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v27+B8]");
				object obj38 = 0;
				obj38 = obj39;
				object obj40 = (nint)0 + (nint)309;
				object obj41 = obj40 & 1;
				bool flag11 = obj41 == null;
				object obj42 = !flag11;
				num6 = 0;
				if (obj42 != null)
				{
					goto IL_0435;
				}
				goto IL_0614;
			}
			return (T)(object)new NullReferenceException();
			IL_04a7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			goto IL_04b6;
			IL_019a:
			nint num7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v51 (Il2CppRgctx<KammelnaSettingsBase`1>)+10]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v51 (Il2CppRgctx<KammelnaSettingsBase`1>)+10]");
			object obj44 = (nint)0 + (nint)309;
			object obj45 = obj44 & 1;
			bool flag12 = obj45 == null;
			object obj46 = !flag12;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v49+B8]");
			return (T)0;
			IL_04b6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj47 = (nint)0 + (nint)309;
			object obj48 = obj47 & 1;
			bool flag13 = obj48 == null;
			obj15 = 0;
			obj16 = obj39;
			num2 = 0;
			if (flag13)
			{
				goto IL_017b;
			}
			obj17 = 0;
			obj18 = obj39;
			goto IL_019a;
			IL_03e0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v39+B8]");
			object obj49 = 0;
			obj49 = obj39;
			object obj50 = (nint)0 + (nint)309;
			object obj51 = obj50 & 1;
			bool flag14 = obj51 == null;
			num6 = 0;
			if (!flag14)
			{
				goto IL_0435;
			}
			goto IL_0614;
			IL_0614:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v24+C0]");
			object obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v24+10]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v24+10]");
			object obj54 = (nint)0 + (nint)309;
			object obj55 = obj54 & 1;
			if (obj55 == null)
			{
				goto IL_04a7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v24+10]");
			object obj56 = 0;
			goto IL_04b6;
			IL_017b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			obj17 = obj15;
			obj18 = obj16;
			goto IL_019a;
			IL_0435:
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v39 (Il2CppRgctx<KammelnaSettingsBase`1>)+10]");
			obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v39 (Il2CppRgctx<KammelnaSettingsBase`1>)+10]");
			object obj57 = (nint)0 + (nint)309;
			object obj58 = obj57 & 1;
			bool flag15 = obj58 == null;
			object obj59 = !flag15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v39 (Il2CppRgctx<KammelnaSettingsBase`1>)+10]");
			obj56 = 0;
			if (obj59 == null)
			{
				goto IL_04a7;
			}
			goto IL_04b6;
		}
	}
}
