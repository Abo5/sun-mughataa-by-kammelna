using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Managers.Achievemenets;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;
using UnityEngine.UI;

public class AchievementLevelsStrip : MonoBehaviour
{
	private sealed class <>c__DisplayClass4_0
	{
		public AchievementLevelsStrip <>4__this;

		public int unlockedLevel;

		public Action<int> onTabChanged;

		public UnityAction<int> <>9__0;

		internal void <BuildTabs>b__0(int selectedLvl)
		{
			//IL_0011: Expected O, but got I
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_002e: Expected O, but got I4
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Expected I4, but got Unknown
			//IL_0230: Expected O, but got I
			//IL_0240: Expected O, but got I
			//IL_0250: Expected O, but got I
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected O, but got Unknown
			//IL_0069: Expected O, but got I4
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Expected O, but got Unknown
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Expected O, but got Unknown
			AchievementLevelsStrip achievementLevelsStrip = <>4__this;
			object obj = (nint)0 + (nint)3584;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = 1;
			UnityEngine.Object obj5 = default(UnityEngine.Object);
			object obj10;
			do
			{
				IL_01bb:
				int num = obj3 - 1;
				int childCount = achievementLevelsStrip.tabsRoot.childCount;
				if (num < childCount)
				{
					AchievementLevelsStrip achievementLevelsStrip2 = <>4__this;
					Transform child = achievementLevelsStrip2.tabsRoot.GetChild(num);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
					object obj4 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v11+E4]");
					if ((nint)0 != 0)
					{
						if (!obj5)
						{
							goto IL_0034;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						if (!obj5)
						{
							goto IL_0034;
						}
					}
					int num2 = ~unlockedLevel;
					int num3 = unlockedLevel & num2;
					((AchievementLevelsTab)obj5).ApplyVisual();
					object obj6 = selectedLvl - obj3;
					bool current = obj6 == null;
					((AchievementLevelsTab)obj5).SetCurrent(current);
					achievementLevelsStrip = <>4__this;
					obj3++;
					goto IL_01bb;
				}
				Action<int> action = onTabChanged;
				if (onTabChanged != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v6 (System.Action`1<System.Int32>)+18]");
					object obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v6 (System.Action`1<System.Int32>)+40]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v6 (System.Action`1<System.Int32>)+28]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v162 @ X3_v1 (should have been resolved before IL gen)");
				}
				return;
				IL_0034:
				achievementLevelsStrip = <>4__this;
				obj3++;
				bool flag = (object)<>4__this == null;
				obj10 = !flag;
			}
			while (obj10 != null);
			throw new NullReferenceException();
		}
	}

	private Transform tabsRoot;

	private ToggleGroup group;

	private AchievementLevelsTab tabPrefab;

	public unsafe void Clear()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0148: Expected O, but got I4
		//IL_0151: Expected O, but got I4
		//IL_015a: Expected O, but got I4
		//IL_00e6: Expected O, but got I4
		//IL_00ef: Expected O, but got I4
		//IL_0088: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_01b2: Expected O, but got I4
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_0227: Expected O, but got I4
		//IL_077d: Expected O, but got I4
		//IL_0280: Expected O, but got I
		//IL_031f: Expected O, but got I4
		//IL_0843: Expected I, but got O
		//IL_0853: Expected O, but got I
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Expected O, but got Unknown
		//IL_02bb: Expected O, but got I
		//IL_0596: Expected O, but got I4
		//IL_059f: Expected O, but got I4
		//IL_05a8: Expected O, but got I4
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0906: Expected O, but got I4
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Expected O, but got Unknown
		//IL_02e4: Expected O, but got I
		//IL_05c5: Expected O, but got I
		//IL_0389: Expected O, but got I
		//IL_065c: Expected O, but got I4
		//IL_0428: Expected O, but got I4
		//IL_0948: Expected O, but got I
		//IL_0600: Expected O, but got I
		//IL_08b5: Expected I, but got O
		//IL_08c5: Expected O, but got I
		//IL_03c4: Expected O, but got I
		//IL_06c8: Expected O, but got I4
		//IL_07e2: Expected O, but got I4
		//IL_071c: Expected O, but got I4
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0684: Expected I, but got Unknown
		//IL_0473: Expected I, but got O
		//IL_0483: Expected O, but got I
		//IL_0493: Expected O, but got I
		//IL_04bc: Expected O, but got I4
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_043b: Expected O, but got Unknown
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected O, but got Unknown
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected O, but got Unknown
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Expected O, but got Unknown
		//IL_03ed: Expected O, but got I
		//IL_04f0: Expected O, but got I
		//IL_056e: Expected O, but got I4
		//IL_0246: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B21]");
		object obj3 = (nint)0 & (nint)1;
		object obj5;
		UnityEngine.Object obj6;
		nint num2;
		UnityEngine.Object obj7;
		nint num;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v49+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v49+E4]");
			bool flag = (nint)0 == 0;
			obj5 = 0;
			obj6 = tabsRoot;
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v49+E4]");
			num2 = 0;
			obj7 = tabsRoot;
			if (!flag)
			{
				goto IL_00c3;
			}
		}
		else
		{
			_ = 1;
			obj6 = tabsRoot;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v49+E4]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v49+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			obj5 = 0;
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v49+E4]");
			num2 = 0;
			obj7 = tabsRoot;
			if (obj8 != null)
			{
				goto IL_00c3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj7;
		bool flag4 = !flag3;
		object obj9 = 0;
		num = num2;
		if (flag4)
		{
			return;
		}
		goto IL_01c8;
		IL_01c8:
		if ((object)tabsRoot != null)
		{
			IEnumerator enumerator = tabsRoot.GetEnumerator();
			object obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1952;
			obj9 = 0;
			num = (nint)(&obj5);
			object obj12 = default(object);
			object obj18 = default(object);
			object obj20 = default(object);
			object obj24 = default(object);
			object obj29 = default(object);
			object obj35 = default(object);
			IntPtr intPtr = default(IntPtr);
			Component component = default(Component);
			while (true)
			{
				if (obj12 != null)
				{
					object obj13 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v16+12E]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v16+12E]");
					if ((nint)0 == 0)
					{
						goto IL_030c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v16+B0]");
					object obj15 = (nint)0 + (nint)8;
					object obj16;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X10_v24-8]");
						if (0 == (nint)obj10)
						{
							break;
						}
						obj16 = obj15 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X8_v16+12E]");
						obj14 = -1;
						bool flag5 = (nint)obj14 != 1;
						obj15 = obj16;
						if (flag5)
						{
							continue;
						}
						goto IL_030c;
					}
					obj14 = obj15;
					object obj17 = obj13 + obj15;
					obj18 = obj17 + 312;
					obj16 = obj15;
					goto IL_083b;
				}
				NullReferenceException ex = new NullReferenceException();
				goto IL_0771;
				IL_083b:
				num = (nint)obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v29+8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v471 @ X0_v29] (should have been resolved before IL gen)");
				object obj19 = obj20 & 1;
				if (obj19 != null)
				{
					if (obj12 != null)
					{
						object obj21 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v19+12E]");
						object obj14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v19+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0415;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v19+B0]");
						object obj22 = (nint)0 + (nint)8;
						object obj16;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X10_v19-8]");
							if (0 == (nint)obj10)
							{
								break;
							}
							obj16 = obj22 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v19+12E]");
							obj14 = -1;
							bool flag6 = (nint)obj14 != 1;
							obj22 = obj16;
							if (flag6)
							{
								continue;
							}
							goto IL_0415;
						}
						obj14 = obj22 + 1;
						object obj23 = obj21 + obj14;
						obj24 = obj23 + 312;
						obj16 = obj22;
						goto IL_08ad;
					}
					NullReferenceException ex2 = new NullReferenceException();
					goto IL_0771;
				}
				object obj25 = 0;
				object obj26 = 5;
				object obj27 = 0;
				object obj36;
				while (true)
				{
					object obj28 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
					obj9 = obj28;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj29 == null)
					{
						goto IL_08ec;
					}
					object obj30 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v5+12E]");
					object obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v5+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0649;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v5+B0]");
					object obj32 = (nint)0 + (nint)8;
					object obj16;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X10_v7-8]");
						if (0 == (nint)obj28)
						{
							break;
						}
						obj16 = obj32 + 16;
						obj31--;
						bool flag7 = (nint)obj31 != 1;
						obj32 = obj16;
						if (flag7)
						{
							continue;
						}
						goto IL_0649;
					}
					object obj33 = obj30 + obj32;
					num = (nint)(obj33 + 312);
					obj16 = obj32;
					goto IL_0938;
					IL_08ec:
					bool flag8 = obj27 == null;
					object obj34 = !flag8;
					if (obj34 != null)
					{
						OutOfMemoryException ex3 = new OutOfMemoryException();
						if ((nint)obj9 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
							obj27 = obj35;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
							obj25 = obj35;
							obj26 = 0;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
						return;
					}
					break;
					IL_0649:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					obj36 = 0;
					num = intPtr;
					goto IL_0938;
					IL_0938:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4 (Il2CppClass<UnityEngine.Component>)+8]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v145 @ X8_v4 (Il2CppClass<UnityEngine.Component>)] (should have been resolved before IL gen)");
					goto IL_08ec;
				}
				if ((nint)obj26 != 5)
				{
					bool flag9 = obj26 == null;
					object obj37 = !flag9;
					if (obj37 != null)
					{
						return;
					}
				}
				if ((object)tabsRoot == null)
				{
					break;
				}
				GameObject gameObject = tabsRoot.gameObject;
				bool flag10 = (object)gameObject == null;
				obj9 = 0;
				if (flag10)
				{
					break;
				}
				gameObject.SetActive(value: false);
				return;
				IL_08ad:
				num = (nint)obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X0_v33+8]");
				obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v617 @ X0_v33] (should have been resolved before IL gen)");
				if ((object)component != null)
				{
					obj9 = obj11;
					num = (nint)component;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4 (Il2CppClass<UnityEngine.Component>)+130]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X1_v10+130]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4 (Il2CppClass<UnityEngine.Component>)+130]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X1_v10+130]");
					bool flag11 = num3 < 0;
					object obj38 = !flag11;
					object obj39 = ~obj38;
					if (obj39 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4 (Il2CppClass<UnityEngine.Component>)+C8]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X1_v10+130]");
						object obj40 = num4 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v25-8]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X8_v25-8]");
						if (0 == (nint)obj9)
						{
							GameObject obj41 = component.gameObject;
							object obj42 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X0_v39+E4]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X0_v39+E4]");
							bool flag12 = (nint)0 == 0;
							object obj43 = !flag12;
							if (obj43 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							UnityEngine.Object.Destroy(obj41);
							obj9 = 0;
							continue;
						}
					}
					InvalidCastException ex4 = new InvalidCastException();
				}
				else
				{
					NullReferenceException ex5 = new NullReferenceException();
				}
				goto IL_0771;
				IL_0771:
				obj25 = 0;
				break;
				IL_0415:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj36 = 1;
				goto IL_08ad;
				IL_030c:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				obj36 = 0;
				goto IL_083b;
			}
		}
		throw new NullReferenceException();
		IL_00c3:
		bool flag13 = obj6;
		bool flag14 = !flag13;
		object obj44 = !flag14;
		obj9 = 0;
		if (obj44 == null)
		{
			return;
		}
		goto IL_01c8;
	}

	public unsafe void BuildTabs(GameAchievementViewModel model, int currentLevel, int unlockedLevel, Action<int> onTabChanged)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0114: Expected O, but got I4
		//IL_00c6: Expected O, but got I4
		//IL_00cf: Expected O, but got I4
		//IL_0178: Expected O, but got I4
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0227: Expected O, but got I4
		//IL_0288: Expected O, but got I
		//IL_0dd7: Expected I, but got O
		//IL_0dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0def: Expected O, but got Unknown
		//IL_02cc: Expected O, but got I
		//IL_05ad: Expected O, but got I4
		//IL_05b6: Expected O, but got I4
		//IL_05bf: Expected O, but got I4
		//IL_0eed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef2: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_0e5a: Expected O, but got I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_02f5: Expected O, but got I
		//IL_05dc: Expected O, but got I
		//IL_03a2: Expected O, but got I
		//IL_0e9c: Expected O, but got I
		//IL_0eac: Expected O, but got I
		//IL_0617: Expected O, but got I
		//IL_03dd: Expected O, but got I
		//IL_06df: Expected O, but got I4
		//IL_048c: Expected I, but got O
		//IL_049c: Expected O, but got I
		//IL_04ac: Expected O, but got I
		//IL_04d5: Expected O, but got I4
		//IL_0d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d73: Expected O, but got Unknown
		//IL_0d8c: Expected O, but got I4
		//IL_074f: Expected O, but got I4
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected I, but got Unknown
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected O, but got Unknown
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected O, but got Unknown
		//IL_079a: Expected O, but got I4
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected I4, but got Unknown
		//IL_0808: Expected O, but got I4
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected I4, but got Unknown
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected O, but got Unknown
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		//IL_0509: Expected O, but got I
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_0406: Expected O, but got I
		//IL_084d: Expected O, but got I4
		//IL_0587: Expected O, but got I4
		//IL_0919: Expected O, but got I4
		//IL_024e: Expected O, but got I4
		//IL_0942: Expected O, but got I
		//IL_0965: Expected O, but got I
		//IL_0a7d: Expected O, but got I
		//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a92: Expected I4, but got Unknown
		//IL_0ab8: Expected O, but got I
		//IL_0ada: Expected O, but got I4
		//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6d: Expected O, but got Unknown
		//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbb: Expected O, but got Unknown
		//IL_0af7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afc: Expected O, but got Unknown
		//IL_0b12: Expected O, but got I
		//IL_0b23: Expected I, but got O
		//IL_0b36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3b: Expected O, but got Unknown
		//IL_09f1: Expected O, but got I4
		//IL_0a67: Expected O, but got I4
		//IL_0c84: Expected O, but got I4
		//IL_0884: Unknown result type (might be due to invalid IL or missing references)
		//IL_0889: Expected O, but got Unknown
		object obj = typeof(XmlSchemaInclude) + 3712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 32;
		obj5 = onTabChanged;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			bool flag = tabsRoot;
			bool flag2 = !flag;
			object obj7 = !flag2;
			object obj8 = 0;
			if (obj7 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = tabsRoot;
			bool flag4 = !flag3;
			object obj8 = 0;
			if (flag4)
			{
				return;
			}
		}
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X0_v15+E4]");
		bool flag5;
		if ((nint)0 != 0)
		{
			flag5 = tabPrefab;
			bool flag6 = model == null;
			object obj10 = !flag6;
			if (obj10 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			flag5 = tabPrefab;
			if (model == null)
			{
				return;
			}
		}
		if (!flag5)
		{
			return;
		}
		IEnumerator enumerator = tabsRoot.GetEnumerator();
		object obj11 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj12 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1952;
		int num = currentLevel;
		object obj13 = 0;
		object obj14 = default(object);
		nint num2 = (nint)(&obj14);
		object obj15 = default(object);
		object obj22 = default(object);
		Component component = default(Component);
		object obj31 = default(object);
		object obj18;
		object obj38;
		object obj39;
		object obj19 = default(object);
		while (true)
		{
			int num3;
			object obj17;
			if (obj15 != null)
			{
				object obj16 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v36+12E]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v36+12E]");
				bool flag7 = (nint)0 == 0;
				obj18 = obj19;
				if (flag7)
				{
					goto IL_031d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v36+B0]");
				object obj20 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X10_v25-8]");
					if (0 == (nint)obj11)
					{
						break;
					}
					obj18 = obj20 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v36+12E]");
					obj17 = -1;
					bool flag8 = (nint)obj17 != 1;
					obj20 = obj18;
					if (flag8)
					{
						continue;
					}
					goto IL_031d;
				}
				obj17 = obj20;
				object obj21 = obj16 + obj20;
				obj22 = obj21 + 312;
				num3 = num;
				obj18 = obj20;
				goto IL_0dcf;
			}
			throw new NullReferenceException();
			IL_031d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num3 = 0;
			goto IL_0dcf;
			IL_0e31:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v727 @ X0_v83] (should have been resolved before IL gen)");
			object obj23 = obj12;
			nint num4 = (nint)component;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v10 (Il2CppClass<UnityEngine.Component>)+130]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X1_v10+130]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v10 (Il2CppClass<UnityEngine.Component>)+130]");
			nint num5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X1_v10+130]");
			bool flag9 = num5 < 0;
			object obj24 = !flag9;
			object obj25 = ~obj24;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v10 (Il2CppClass<UnityEngine.Component>)+C8]");
				nint num6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X1_v10+130]");
				object obj26 = num6 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X8_v45-8]");
				num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X8_v45-8]");
				if (0 == (nint)obj23)
				{
					GameObject obj27 = component.gameObject;
					object obj28 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v89+E4]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v89+E4]");
					bool flag10 = (nint)0 == 0;
					object obj29 = !flag10;
					if (obj29 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					UnityEngine.Object.Destroy(obj27);
					num = num3;
					obj13 = 0;
					continue;
				}
			}
			throw new InvalidCastException();
			IL_042e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num3 = 1;
			goto IL_0e31;
			IL_0dcf:
			num4 = (nint)obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v578 @ X0_v79] (should have been resolved before IL gen)");
			object obj30 = obj31 & 1;
			if (obj30 != null)
			{
				if (obj15 != null)
				{
					object obj32 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v39+12E]");
					object obj33 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v39+12E]");
					if ((nint)0 == 0)
					{
						goto IL_042e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v39+B0]");
					object obj34 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X10_v20-8]");
						if (0 == (nint)obj11)
						{
							break;
						}
						obj18 = obj34 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v609 @ X8_v39+12E]");
						obj33 = -1;
						bool flag11 = (nint)obj33 != 1;
						obj34 = obj18;
						if (flag11)
						{
							continue;
						}
						goto IL_042e;
					}
					obj33 = obj34 + 1;
					object obj35 = obj32 + obj33;
					object obj36 = obj35 + 312;
					obj18 = obj34;
					goto IL_0e31;
				}
				throw new NullReferenceException();
			}
			object obj37 = 0;
			obj38 = 6;
			obj39 = 0;
			break;
		}
		object obj41 = default(object);
		IntPtr intPtr = default(IntPtr);
		UnityEngine.Object obj57 = default(UnityEngine.Object);
		AchievementLevelsTab achievementLevelsTab = default(AchievementLevelsTab);
		UnityAction<int> unityAction3 = default(UnityAction<int>);
		object obj69 = default(object);
		while (true)
		{
			object obj40 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj23 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			if (obj41 == null)
			{
				goto IL_0e40;
			}
			object obj42 = obj41;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v30+12E]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v30+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0660;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v698 @ X8_v30+B0]");
			object obj44 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X10_v11-8]");
				if (0 == (nint)obj40)
				{
					break;
				}
				obj18 = obj44 + 16;
				obj43--;
				bool flag12 = (nint)obj43 != 1;
				obj44 = obj18;
				if (flag12)
				{
					continue;
				}
				goto IL_0660;
			}
			object obj45 = obj42 + obj44;
			nint num4 = (nint)(obj45 + 312);
			obj18 = obj44;
			goto IL_0e94;
			IL_0660:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			int num3 = 0;
			num4 = intPtr;
			goto IL_0e94;
			IL_0e94:
			object obj17 = num4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v10 (Il2CppClass<UnityEngine.Component>)+8]");
			obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v372 @ X8_v10 (Il2CppClass<UnityEngine.Component>)] (should have been resolved before IL gen)");
			goto IL_0e40;
			IL_0e40:
			bool flag13 = obj39 == null;
			object obj46 = !flag13;
			obj19 = obj18;
			if (obj46 == null)
			{
				if ((nint)obj38 != 6)
				{
					bool flag14 = obj38 == null;
					object obj47 = !flag14;
					if (obj47 != null)
					{
						return;
					}
				}
				List<AchievementLevelModel> <achievementLevels>k__BackingField = model.<achievementLevels>k__BackingField;
				int num7;
				Component component2;
				if (model.<achievementLevels>k__BackingField != null)
				{
					num7 = <achievementLevels>k__BackingField._size;
					component2 = tabsRoot;
					bool flag15 = (object)tabsRoot == null;
					object obj48 = !flag15;
					if (obj48 == null)
					{
						goto IL_0c92;
					}
				}
				else
				{
					component2 = tabsRoot;
					num7 = 0;
				}
				GameObject gameObject = component2.gameObject;
				object obj49 = num7 - 1;
				bool flag16 = (nint)obj49 < 0;
				bool flag17 = obj49 == null;
				int num8 = num7 ^ 1;
				int num9 = num7 ^ obj49;
				int num10 = num8 & num9;
				bool flag18 = num10 < 0;
				bool flag19 = flag16 == flag18;
				object obj50 = !flag17;
				bool flag20 = (byte)((flag19 & obj50) ? 1 : 0) != 0;
				gameObject.SetActive(flag20);
				if (num7 < 2)
				{
					return;
				}
				object obj51 = currentLevel - 1;
				UnityAction<int> unityAction = (UnityAction<int>)(object)onTabChanged;
				bool flag21 = (byte)unlockedLevel != 0;
				int num11 = 0;
				int num12 = 0;
				bool flag22 = flag20;
				while (true)
				{
					object obj52 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X0_v38+E4]");
					bool flag23 = (nint)0 == 0;
					object obj53 = !flag23;
					if (obj53 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj54 = (nint)0 + (nint)456;
					object obj55 = obj54;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
					object obj56 = (nint)0 + (nint)160;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
					bool flag24 = obj57;
					bool flag25 = !flag24;
					ToggleGroup toggleGroup = null;
					if (!flag25)
					{
						object obj58 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v29+E4]");
						if ((nint)0 != 0)
						{
							bool flag26 = group;
							bool flag27 = !flag26;
							object obj59 = !flag27;
							if (obj59 != null)
							{
								goto IL_0a45;
							}
							toggleGroup = null;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							bool flag28 = group;
							bool flag29 = !flag28;
							toggleGroup = null;
							if (!flag29)
							{
								goto IL_0a45;
							}
						}
					}
					goto IL_0a6c;
					IL_08bb:
					int num13;
					bool flag30 = num7 == num13;
					UnityAction<int> unityAction2;
					unityAction = unityAction2;
					bool flag31;
					flag21 = flag31;
					num11 = num13;
					if (!flag30)
					{
						continue;
					}
					return;
					IL_0a45:
					toggleGroup = group;
					((Toggle)obj57).group = group;
					obj55 = 0;
					goto IL_0a6c;
					IL_0a6c:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Object)+18]");
					object obj60 = ~(nint)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Object)+18]");
					int unlockedLevel2 = 0 & obj60;
					achievementLevelsTab._unlockedLevel = unlockedLevel2;
					achievementLevelsTab.ApplyVisual();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Object)+28]");
					unityAction2 = (UnityAction<int>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3 (System.Object)+28]");
					bool flag32 = (nint)0 == 0;
					object obj61 = !flag32;
					if (obj61 == null)
					{
						object obj62 = typeof(TypeConverter<ushort, char>) + 408;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj63 = (nint)0 + (nint)2024;
						unityAction3..ctor(obj2, (IntPtr)obj63);
						object obj64 = obj2 + 40;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						unityAction2 = unityAction3;
					}
					num13 = num11 + 1;
					object obj65 = obj51 - num11;
					flag31 = obj65 == null;
					achievementLevelsTab.Configure(num13, num7, flag31, unityAction2);
					achievementLevelsTab.SetCurrent(flag31);
					obj3 = typeof(MemberAchievementClanFeedData) + 2976;
					object obj66 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ X0_v49+E4]");
					if ((nint)0 != 0)
					{
						bool flag33 = obj57;
						bool flag34 = !flag33;
						num12 = num7;
						flag22 = false;
						if (flag34)
						{
							goto IL_08bb;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool flag35 = obj57;
						bool flag36 = !flag35;
						num12 = num7;
						flag22 = false;
						if (flag36)
						{
							goto IL_08bb;
						}
					}
					bool flag37 = (object)obj57 == null;
					object obj67 = !flag37;
					if (obj67 != null)
					{
						object obj68 = obj51 - num11;
						bool flag38 = obj68 == null;
						((Toggle)obj57).SetIsOnWithoutNotify(flag38);
						num12 = 0;
						flag22 = flag38;
						goto IL_08bb;
					}
					break;
				}
				goto IL_0c92;
			}
			OutOfMemoryException ex = new OutOfMemoryException();
			if ((nint)obj23 != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			obj39 = obj69;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			obj18 = obj19;
			object obj37 = obj69;
			obj38 = 0;
			continue;
			IL_0c92:
			throw new NullReferenceException();
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}
}
