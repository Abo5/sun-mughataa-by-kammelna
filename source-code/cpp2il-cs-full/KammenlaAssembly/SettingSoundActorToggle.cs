using System;
using System.Buffers.Text;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class SettingSoundActorToggle : MonoBehaviour
{
	private AudioSource audioSource;

	private RectTransform groupsParent;

	private GameObject groupTemplate;

	private Toggle toggleTemplateFirst;

	private Toggle toggleTemplateMid;

	private Toggle toggleTemplateLast;

	private SoundActors actors;

	private ToggleGroup toggleGroup;

	private List<Toggle> _toggles;

	private void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_0018: Expected O, but got I
		//IL_0024: Expected O, but got I
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_006d: Expected O, but got I
		//IL_03a0: Expected O, but got I
		//IL_03b0: Expected O, but got I
		//IL_03c6: Expected O, but got I
		//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03ee: Expected O, but got I4
		//IL_03fe: Expected O, but got I
		//IL_00a2: Expected O, but got I
		//IL_00b8: Expected O, but got I
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00e5: Expected O, but got I
		//IL_0438: Expected O, but got I4
		//IL_0124: Expected O, but got I
		//IL_0134: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_015a: Expected O, but got I
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0182: Expected O, but got I4
		//IL_01af: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01f8: Expected I4, but got O
		//IL_021f: Expected O, but got I4
		//IL_0239: Expected O, but got I
		//IL_0241: Expected I4, but got O
		//IL_0266: Expected O, but got I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_02ac: Expected O, but got I4
		//IL_02b4: Expected I4, but got O
		//IL_04be: Expected I4, but got O
		//IL_02cf: Expected O, but got I
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_02ef: Expected O, but got I
		//IL_0305: Expected O, but got I4
		//IL_0334: Expected O, but got I4
		//IL_0468: Expected O, but got I4
		object obj = (nint)0 + (nint)2040;
		object obj2 = (nint)0 + (nint)168;
		object obj3 = (nint)0 + (nint)3120;
		string resourcesPath = SoundActors.ResourcesPath;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2FF8ABC");
		object obj4 = this + 80;
		object obj5 = default(object);
		obj4 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj6 = this + 88;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X21_v3+38]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X21_v3+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v3+10]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v3+10]");
			object obj11 = (nint)0 + (nint)309;
			object obj12 = obj11 & 1;
			bool flag = obj12 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v3+10]");
			object obj13 = 0;
			if (!flag)
			{
				goto IL_00f3;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X21_v3+38]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v7+10]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v7+10]");
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag2 = obj16 == null;
			object obj17 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v7+10]");
			object obj13 = 0;
			if (obj17 != null)
			{
				goto IL_00f3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj18 = !flag3;
		if (obj18 != null)
		{
			goto IL_0118;
		}
		goto IL_0446;
		IL_0118:
		object obj19 = (nint)0 + (nint)176;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X21_v3+38]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v11+10]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v11+10]");
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		bool flag4 = obj23 == null;
		object obj24 = !flag4;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v21+B8]");
		object except = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X20_v4-30]");
		UIExtensions.DestroyAllChildren((Transform)0, (GameObject[])except);
		List<Toggle> list = PopulateSoundActors();
		object obj25 = this + 96;
		obj25 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag5 = (byte)(int)obj19 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		bool flag6 = obj25 == null;
		object obj26 = 0;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag6)
		{
			object obj27 = (nint)0 + (nint)1208;
			flag5 = (byte)(int)obj27 != 0;
			object[] array = ((List<object>)obj25).ToArray();
			object obj28 = default(object);
			bool flag7 = obj28 == null;
			obj26 = 0;
			if (!flag7)
			{
				object obj29 = obj28 + 32;
				obj29 = array;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag8 = obj25 == null;
				obj26 = 0;
				flag5 = (byte)(int)array != 0;
				if (!flag8)
				{
					object obj30 = (nint)0 + (nint)2448;
					object obj31 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
					obj25 = (nint)0 + (nint)2440;
					List<object>.Enumerator enumerator = ((List<object>)obj25).GetEnumerator();
					obj26 = 0;
					if (!enumerator2.MoveNext())
					{
						enumerator2.Dispose();
						return;
					}
					object obj32 = obj31;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v53+E4]");
					bool flag9 = (nint)0 == 0;
					object obj33 = !flag9;
					if (obj33 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool gameSound = Preferences.GameSound;
					NullReferenceException ex = new NullReferenceException();
					object obj34 = 0;
					flag5 = gameSound;
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag10 = !flag5;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag10)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			flag5 = (byte)(int)obj25 != 0;
			enumerator2.Dispose();
			object obj35 = default(object);
			if (obj35 == null)
			{
				return;
			}
			ex3 = new OutOfMemoryException();
			object obj34 = obj35;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2238614");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0446:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0118;
		IL_00f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v12+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0118;
		}
		goto IL_0446;
	}

	private unsafe List<Toggle> PopulateSoundActors()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_1155: Expected I4, but got O
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0070: Expected I, but got O
		//IL_0080: Expected O, but got I
		//IL_0117: Expected O, but got I4
		//IL_133a: Expected O, but got I4
		//IL_1037: Unknown result type (might be due to invalid IL or missing references)
		//IL_103c: Expected O, but got Unknown
		//IL_1054: Expected O, but got I
		//IL_10e3: Expected O, but got I4
		//IL_0fac: Expected O, but got Ref
		//IL_0fb5: Expected O, but got I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0169: Expected O, but got I
		//IL_012e: Expected O, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_108f: Expected O, but got I
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01e7: Expected O, but got I
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_027e: Expected O, but got I4
		//IL_10fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1103: Expected O, but got Unknown
		//IL_1239: Unknown result type (might be due to invalid IL or missing references)
		//IL_123e: Expected O, but got Unknown
		//IL_1255: Expected O, but got Ref
		//IL_125e: Expected O, but got I4
		//IL_109d: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a2: Expected O, but got Unknown
		//IL_10ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b0: Expected O, but got Unknown
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_0301: Expected O, but got I
		//IL_0398: Expected O, but got I4
		//IL_12cd: Expected O, but got I4
		//IL_03e5: Expected O, but got I
		//IL_0f4f: Expected O, but got I4
		//IL_0f59: Expected I4, but got O
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_0424: Expected O, but got I
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_08c2: Expected O, but got I4
		//IL_08cc: Expected I4, but got O
		//IL_0461: Expected O, but got I4
		//IL_046b: Expected I4, but got O
		//IL_08f7: Expected O, but got I4
		//IL_0901: Expected I4, but got O
		//IL_0496: Expected O, but got I4
		//IL_04a0: Expected I4, but got O
		//IL_0f6a: Expected O, but got I
		//IL_0f88: Expected O, but got I
		//IL_04ba: Expected O, but got I
		//IL_04d0: Expected O, but got I
		//IL_0510: Expected O, but got I4
		//IL_0539: Expected O, but got I
		//IL_0563: Expected O, but got I4
		//IL_056b: Expected I4, but got O
		//IL_059e: Expected O, but got I4
		//IL_05db: Expected O, but got I4
		//IL_0607: Expected O, but got I
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected O, but got Unknown
		//IL_0645: Expected O, but got I4
		//IL_0680: Expected O, but got I
		//IL_06a2: Expected O, but got I
		//IL_06c6: Expected O, but got I
		//IL_06e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ee: Expected O, but got Unknown
		//IL_0704: Expected O, but got I
		//IL_073b: Expected O, but got I4
		//IL_0740: Expected I4, but got O
		//IL_075a: Expected O, but got I
		//IL_0784: Expected O, but got I4
		//IL_07ec: Expected O, but got I4
		//IL_0830: Expected O, but got I4
		//IL_0924: Expected O, but got I
		//IL_0934: Expected O, but got I
		//IL_0944: Expected O, but got I
		//IL_0959: Expected I4, but got O
		//IL_096e: Expected O, but got I
		//IL_098e: Expected O, but got I4
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected O, but got Unknown
		//IL_089d: Expected I4, but got O
		//IL_09ae: Expected O, but got I4
		//IL_0ab2: Expected O, but got I
		//IL_0adb: Expected O, but got I
		//IL_0b16: Expected O, but got I
		//IL_0b4c: Expected O, but got I4
		//IL_1312: Expected O, but got I4
		//IL_0b3e: Expected O, but got I4
		//IL_0b6c: Expected O, but got I
		//IL_0b96: Expected O, but got I4
		//IL_0b9e: Expected I4, but got O
		//IL_0bd1: Expected O, but got I4
		//IL_0c0e: Expected O, but got I4
		//IL_0c3a: Expected O, but got I
		//IL_0c49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4e: Expected O, but got Unknown
		//IL_0c78: Expected O, but got I4
		//IL_0cb3: Expected O, but got I
		//IL_0cd5: Expected O, but got I
		//IL_0cf9: Expected O, but got I
		//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d21: Expected O, but got Unknown
		//IL_0d37: Expected O, but got I
		//IL_0d6e: Expected O, but got I4
		//IL_0d73: Expected I4, but got O
		//IL_0d8d: Expected O, but got I
		//IL_0df1: Expected O, but got I4
		//IL_0e35: Expected O, but got I4
		//IL_09d3: Expected O, but got I
		//IL_09e3: Expected O, but got I
		//IL_09f3: Expected O, but got I
		//IL_0a08: Expected I4, but got O
		//IL_0a2b: Expected O, but got I
		//IL_0a4b: Expected O, but got I4
		//IL_0a5c: Expected O, but got I4
		//IL_0e75: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e7a: Expected O, but got Unknown
		//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e88: Expected O, but got Unknown
		//IL_0ea2: Expected I4, but got O
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3960;
		object obj2 = (nint)0 + (nint)1144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		int num = (int)obj2;
		List<object> list = default(List<object>);
		list..ctor();
		SoundActors soundActors = actors;
		if ((object)actors != null)
		{
			List<SoundActors.ActorsGroup> actorsGroups = soundActors.actorsGroups;
			if (soundActors.actorsGroups != null)
			{
				object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3992;
				nint num2 = (nint)actorsGroups;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v18 (Il2CppClass<System.Collections.Generic.List`1<SoundActors+ActorsGroup>>)+12E]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v18 (Il2CppClass<System.Collections.Generic.List`1<SoundActors+ActorsGroup>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0104;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v18 (Il2CppClass<System.Collections.Generic.List`1<SoundActors+ActorsGroup>>)+B0]");
				int num3 = (int)((nint)0 + (nint)8);
				int num4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X10_v40 (System.Int32)-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					num4 = num3 + 16;
					obj4--;
					bool flag = (nint)obj4 != 1;
					num3 = num4;
					if (flag)
					{
						continue;
					}
					goto IL_0104;
				}
				object obj5 = num2 + ((int*)num3)->m_value;
				object obj6 = obj5 + 312;
				num4 = num3;
				goto IL_11ba;
			}
		}
		goto IL_1187;
		IL_0edf:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0fa3;
		IL_0f19:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0fa3;
		IL_0ea7:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0fa3;
		IL_0ec3:
		NullReferenceException ex4 = new NullReferenceException();
		goto IL_0fa3;
		IL_0f5e:
		object obj7 = (nint)0 + (nint)1856;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X0_v38+18]");
		object obj9 = ((List<object>)0).get_Item(0);
		NullReferenceException ex5 = new NullReferenceException();
		num = 0;
		goto IL_0fa3;
		IL_0efb:
		NullReferenceException ex6 = new NullReferenceException();
		object obj11;
		object obj10 = obj11;
		int num5;
		num = num5;
		goto IL_0fa3;
		IL_0104:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 0;
		goto IL_11ba;
		IL_11ba:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v25+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v314 @ X0_v25] (should have been resolved before IL gen)");
		object obj12 = default(object);
		if (obj12 == null)
		{
			goto IL_0f19;
		}
		object obj13 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj14 = (nint)0 + (nint)1152;
		object obj15 = obj10;
		object obj16 = obj8;
		object obj17 = obj12;
		object obj26 = default(object);
		GameObject gameObject = default(GameObject);
		Component component = default(Component);
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		int num7 = default(int);
		Component component2 = default(Component);
		TextMeshProUGUI textMesh2 = default(TextMeshProUGUI);
		int num9 = default(int);
		object obj67 = default(object);
		object obj68 = default(object);
		object obj69 = default(object);
		object obj70;
		while (true)
		{
			object obj18 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			object obj19 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v27+12E]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v27+12E]");
			if ((nint)0 == 0)
			{
				goto IL_026b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v27+B0]");
			int num6 = (int)((nint)0 + (nint)8);
			int num4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ X10_v35 (System.Int32)-8]");
				if (0 == (nint)obj18)
				{
					break;
				}
				num4 = num6 + 16;
				obj20--;
				bool flag2 = (nint)obj20 != 1;
				num6 = num4;
				if (flag2)
				{
					continue;
				}
				goto IL_026b;
			}
			object obj21 = obj19 + ((int*)num6)->m_value;
			object obj22 = obj21 + 312;
			obj8 = obj16;
			num4 = num6;
			goto IL_1216;
			IL_1299:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v927 @ X0_v36] (should have been resolved before IL gen)");
			object obj23 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X0_v39+E4]");
			bool flag3 = (nint)0 == 0;
			object obj24 = !flag3;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj25 = (nint)0 + (nint)920;
			obj10 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
			if (obj26 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X0_v38+18]");
				List<object> list2 = (List<object>)0;
				if ((object)gameObject != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X0_v38+18]");
					bool flag4 = (nint)0 == 0;
					obj8 = 0;
					num = (int)groupsParent;
					if (!flag4)
					{
						bool flag5 = list2._size < 1;
						obj16 = 0;
						num = (int)groupsParent;
						if (flag5)
						{
							goto IL_0186;
						}
						object obj27 = (nint)0 + (nint)1856;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X0_v38+18]");
						object obj28 = ((List<object>)0).get_Item(0);
						Transform transform = gameObject.transform;
						object obj29 = obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1022 @ X0_v52+E4]");
						bool flag6 = (nint)0 == 0;
						object obj30 = !flag6;
						if (obj30 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						object obj31 = (nint)0 + (nint)1056;
						obj10 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
						bool flag7 = (object)component == null;
						obj8 = 0;
						num = (int)transform;
						if (flag7)
						{
							goto IL_0ec3;
						}
						Transform transform2 = component.transform;
						bool flag8 = (object)transform2 == null;
						obj8 = 0;
						num = 0;
						if (flag8)
						{
							goto IL_0edf;
						}
						transform2.SetSiblingIndex(1);
						bool flag9 = obj28 == null;
						obj8 = 0;
						num = 1;
						if (flag9)
						{
							goto IL_0ed1;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v49 (System.Object)+20]");
						component.name = (string)0;
						object obj32 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
						object obj33 = obj32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1075 @ X0_v65+E4]");
						bool flag10 = (nint)0 == 0;
						object obj34 = !flag10;
						if (obj34 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string soundActor = Preferences.SoundActor;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v49 (System.Object)+20]");
						bool isOnWithoutNotify = (string)0 == soundActor;
						((Toggle)component).SetIsOnWithoutNotify(isOnWithoutNotify);
						object obj35 = (nint)0 + (nint)288;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1007 @ X0_v49 (System.Object)+20]");
						TextMeshProExtensions.Localize(textMesh, (string)0);
						((Toggle)component).group = toggleGroup;
						object obj36 = typeof(TypeConverter<ushort, char>) + 360;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj37 = (nint)0 + (nint)3232;
						obj8 = obj37;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4027FE0");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X0_v55 (UnityEngine.Component)+118]");
						bool flag11 = (nint)0 == 0;
						obj10 = 0;
						num = (int)this;
						if (!flag11)
						{
							object obj38 = (nint)0 + (nint)832;
							obj8 = obj38;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4029444");
							bool flag12 = list == null;
							obj10 = 0;
							num = num7;
							if (!flag12)
							{
								object obj39 = obj14;
								int version = list._version + 1;
								list._version = version;
								object[] items = list._items;
								bool flag13 = list._items == null;
								obj10 = 0;
								num = num7;
								if (!flag13)
								{
									num4 = list._size;
									bool flag14 = list._size < items.Length;
									object obj40 = !flag14;
									if (obj40 == null)
									{
										int size = list._size + 1;
										list._size = size;
										object obj41 = list._items + list._size;
										object obj42 = obj41 + 32;
										obj42 = component;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										num = (int)component;
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ X8_v64+20]");
										object obj43 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1137 @ X8_v96+C0]");
										object obj44 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ X8_v97+70]");
										obj8 = 0;
										list.AddWithResize((object)component);
										num = (int)component;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X0_v38+18]");
									List<object> list3 = (List<object>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X0_v38+18]");
									bool flag15 = (nint)0 == 0;
									obj10 = 0;
									if (!flag15)
									{
										num5 = 1;
										obj11 = 0;
										obj16 = obj8;
										int num8 = num;
										while (true)
										{
											bool flag16 = num5 >= list3._size;
											obj10 = obj11;
											num = num8;
											if (flag16)
											{
												break;
											}
											object obj45 = (nint)0 + (nint)1856;
											obj8 = obj45;
											object obj46 = list3.get_Item(num5);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X0_v38+18]");
											object obj47 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X0_v38+18]");
											if ((nint)0 != 0)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X8_v70+18]");
												object obj48 = -1;
												if (num5 == (nint)obj48)
												{
													object obj49 = 72;
												}
												else
												{
													object obj49 = 64;
												}
												Transform transform3 = gameObject.transform;
												object obj50 = obj13;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ X0_v89+E4]");
												bool flag17 = (nint)0 == 0;
												object obj51 = !flag17;
												if (obj51 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												object obj52 = (nint)0 + (nint)1056;
												obj10 = obj52;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
												bool flag18 = (object)component2 == null;
												obj8 = 0;
												num = (int)transform3;
												if (flag18)
												{
													goto IL_0ec3;
												}
												Transform transform4 = component2.transform;
												bool flag19 = (object)transform4 == null;
												obj8 = 0;
												num = 0;
												if (flag19)
												{
													goto IL_0edf;
												}
												transform4.SetSiblingIndex(1);
												bool flag20 = obj46 == null;
												obj8 = 0;
												num = 1;
												if (flag20)
												{
													goto IL_0ed1;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v85 (System.Object)+20]");
												component2.name = (string)0;
												object obj53 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
												object obj54 = obj53;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ X0_v96+E4]");
												bool flag21 = (nint)0 == 0;
												object obj55 = !flag21;
												if (obj55 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												string soundActor2 = Preferences.SoundActor;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v85 (System.Object)+20]");
												bool isOnWithoutNotify2 = (string)0 == soundActor2;
												((Toggle)component2).SetIsOnWithoutNotify(isOnWithoutNotify2);
												object obj56 = (nint)0 + (nint)288;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1157 @ X0_v85 (System.Object)+20]");
												TextMeshProExtensions.Localize(textMesh2, (string)0);
												((Toggle)component2).group = toggleGroup;
												object obj57 = typeof(TypeConverter<ushort, char>) + 360;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												object obj58 = (nint)0 + (nint)3232;
												obj8 = obj58;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4027FE0");
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1054 @ X0_v92 (UnityEngine.Component)+118]");
												bool flag22 = (nint)0 == 0;
												obj10 = 0;
												num = (int)this;
												if (!flag22)
												{
													object obj59 = (nint)0 + (nint)832;
													obj8 = obj59;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4029444");
													object obj60 = obj14;
													int version2 = list._version + 1;
													list._version = version2;
													object[] items2 = list._items;
													bool flag23 = list._items == null;
													obj10 = 0;
													num = num9;
													if (!flag23)
													{
														num4 = list._size;
														bool flag24 = list._size < items2.Length;
														object obj61 = !flag24;
														if (obj61 != null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1130 @ X8_v89+20]");
															object obj62 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1223 @ X8_v92+C0]");
															object obj63 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1224 @ X8_v93+70]");
															obj8 = 0;
															list.AddWithResize((object)component2);
															num8 = (int)component2;
														}
														else
														{
															int size2 = list._size + 1;
															list._size = size2;
															object obj64 = list._items + list._size;
															object obj65 = obj64 + 32;
															obj65 = component2;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															num8 = (int)component2;
														}
														num5++;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X0_v38+18]");
														list3 = (List<object>)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X0_v38+18]");
														bool flag25 = (nint)0 == 0;
														obj11 = 0;
														obj16 = obj8;
														obj10 = 0;
														num = num8;
														if (!flag25)
														{
															continue;
														}
														goto IL_0ea7;
													}
													goto IL_0eb5;
												}
												goto IL_0eed;
											}
											goto IL_0efb;
										}
										goto IL_0186;
									}
									goto IL_0ea7;
								}
							}
							goto IL_0eb5;
						}
						goto IL_0eed;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v932 @ X0_v38+18]");
					bool flag26 = (nint)0 == 0;
					obj8 = 0;
					num = (int)groupsParent;
					if (!flag26)
					{
						bool flag27 = list2._size < 1;
						obj16 = 0;
						num = (int)groupsParent;
						if (flag27)
						{
							goto IL_0186;
						}
						goto IL_0f5e;
					}
				}
				goto IL_0ea7;
			}
			goto IL_0f3d;
			IL_0186:
			bool flag28 = obj12 == null;
			obj15 = obj10;
			obj17 = obj12;
			obj8 = obj16;
			if (!flag28)
			{
				continue;
			}
			goto IL_0f19;
			IL_0385:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj8 = 0;
			goto IL_1299;
			IL_026b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj8 = 0;
			goto IL_1216;
			IL_1216:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X0_v32+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v844 @ X0_v32] (should have been resolved before IL gen)");
			object obj66 = obj67 & 1;
			bool flag29 = obj66 == null;
			obj68 = (object)(&obj69);
			obj70 = 0;
			obj10 = obj15;
			if (flag29)
			{
				break;
			}
			if (obj12 == null)
			{
				goto IL_0f27;
			}
			object obj71 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1488;
			object obj72 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v32+12E]");
			object obj73 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v32+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0385;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v32+B0]");
			int num10 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v911 @ X10_v30 (System.Int32)-8]");
				if (0 == (nint)obj71)
				{
					break;
				}
				num4 = num10 + 16;
				obj73--;
				bool flag30 = (nint)obj73 != 1;
				num10 = num4;
				if (flag30)
				{
					continue;
				}
				goto IL_0385;
			}
			object obj74 = obj72 + ((int*)num10)->m_value;
			object obj75 = obj74 + 312;
			num4 = num10;
			goto IL_1299;
		}
		goto IL_1003;
		IL_136c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X0_v19+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v852 @ X0_v19] (should have been resolved before IL gen)");
		goto IL_1320;
		IL_10d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj8 = 0;
		goto IL_136c;
		IL_0eb5:
		NullReferenceException ex7 = new NullReferenceException();
		goto IL_0fa3;
		IL_1187:
		NullReferenceException ex8 = new NullReferenceException();
		bool flag31 = num != 1;
		OutOfMemoryException ex9 = (OutOfMemoryException)(object)ex8;
		if (!flag31)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj76 = default(object);
			obj70 = obj76;
			goto IL_1003;
		}
		goto IL_111b;
		IL_0eed:
		NullReferenceException ex10 = new NullReferenceException();
		goto IL_0fa3;
		IL_0fa3:
		obj68 = (object)(&obj69);
		obj70 = 0;
		goto IL_1187;
		IL_0f3d:
		NullReferenceException ex11 = new NullReferenceException();
		obj8 = 0;
		num = (int)groupsParent;
		goto IL_0fa3;
		IL_1003:
		object obj77 = obj68;
		if (obj68 == null)
		{
			goto IL_1320;
		}
		object obj78 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj79 = obj77;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v12+12E]");
		object obj80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v12+12E]");
		if ((nint)0 == 0)
		{
			goto IL_10d0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v12+B0]");
		object obj81 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v826 @ X10_v9-8]");
			if (0 == (nint)obj78)
			{
				break;
			}
			obj81 += 16;
			obj80--;
			if ((nint)obj80 != 1)
			{
				continue;
			}
			goto IL_10d0;
		}
		object obj82 = obj79 + obj81;
		object obj83 = obj82 + 312;
		goto IL_136c;
		IL_1320:
		bool flag32 = obj70 == null;
		object obj84 = !flag32;
		if (obj84 == null)
		{
			return (List<Toggle>)(object)list;
		}
		ex9 = new OutOfMemoryException();
		goto IL_111b;
		IL_0f27:
		NullReferenceException ex12 = new NullReferenceException();
		obj10 = obj15;
		goto IL_0fa3;
		IL_0ed1:
		NullReferenceException ex13 = new NullReferenceException();
		goto IL_0fa3;
		IL_111b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		List<Toggle> result = default(List<Toggle>);
		return result;
	}

	private void ToggleChanged(bool isOn)
	{
		//IL_0025: Expected O, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0088: Expected O, but got I4
		if (isOn)
		{
			int selectedIndex = ToggleGroupExtensions.GetSelectedIndex(toggleGroup);
			object obj = (nint)0 + (nint)1224;
			object obj2 = ((List<object>)(object)_toggles).get_Item(selectedIndex);
			string text = ((UnityEngine.Object)obj2).name;
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Preferences.SoundActor = text;
			SoundActor actor = actors.GetActor(text);
			AudioClip soundSample = actor.GetSoundSample();
			audioSource.PlayOneShot(soundSample);
		}
	}
}
