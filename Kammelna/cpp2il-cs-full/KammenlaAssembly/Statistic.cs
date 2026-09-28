using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine.AdaptivePerformance;

public struct Statistic
{
	public int Index;

	public List<double> TeamsStatistic;

	public List<double> PlayersStatistic;

	public unsafe Statistic(int statIndex, List<double> teamsStat, List<double> playerStat)
	{
		//IL_0015: Expected O, but got Ref
		//IL_0032: Expected O, but got Ref
		Index = statIndex;
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
		obj = teamsStat;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		obj2 = playerStat;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public unsafe static Statistic BalootMock(int statIndex)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0031: Expected O, but got I
		//IL_004f: Expected O, but got I
		//IL_0064: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		//IL_012a: Expected O, but got I
		//IL_013a: Expected O, but got I
		//IL_014a: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_0184: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_01c3: Expected F8, but got I8
		//IL_00d6: Expected O, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_010b: Expected O, but got I
		//IL_01f2: Expected O, but got I4
		//IL_023f: Expected O, but got I
		//IL_024f: Expected O, but got I
		//IL_025f: Expected O, but got I
		//IL_027e: Expected F8, but got I8
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_02cf: Expected O, but got I
		//IL_02e4: Expected O, but got I
		//IL_0332: Expected O, but got I4
		//IL_03bf: Expected O, but got I
		//IL_03cf: Expected O, but got I
		//IL_03e5: Expected O, but got I
		//IL_040e: Expected F8, but got I8
		//IL_0356: Expected O, but got I
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_038b: Expected O, but got I
		//IL_043d: Expected O, but got I4
		//IL_04b2: Expected O, but got I
		//IL_04c2: Expected O, but got I
		//IL_04d8: Expected O, but got I
		//IL_0501: Expected F8, but got I8
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_0530: Expected O, but got I4
		//IL_05a5: Expected O, but got I
		//IL_05b5: Expected O, but got I
		//IL_05cb: Expected O, but got I
		//IL_05f4: Expected F8, but got I8
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected O, but got Unknown
		//IL_0623: Expected O, but got I4
		//IL_0681: Expected F8, but got I8
		//IL_068f: Expected native int or pointer, but got O
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected O, but got Unknown
		//IL_06ab: Expected O, but got I4
		//IL_06b3: Expected native int or pointer, but got O
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c6: Expected O, but got Unknown
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 872;
		object obj2 = (nint)0 + (nint)1096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = obj2;
		List<double> list = default(List<double>);
		list..ctor();
		if (list != null)
		{
			object obj4 = (nint)0 + (nint)1104;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Double>)+1C]");
			object obj6 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Double>)+10]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Double>)+10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Double>)+18]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v4+18]");
				bool flag = num < 0;
				object obj8 = !flag;
				object obj9;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Double>)+18]");
					obj9 = (nint)0 + (nint)1;
					object obj10 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Double>)+18]");
					object obj11 = obj10 + 0;
					_ = 4632233691727265792L;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Double>)+1C]");
					object obj12 = (nint)0 + (nint)2;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v5+20]");
					object obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v37+C0]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v38+70]");
					obj3 = 0;
					list.AddWithResize(50.0);
					obj5 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Double>)+10]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Double>)+18]");
					obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Double>)+1C]");
					object obj15 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3 (System.Collections.Generic.List`1<System.Double>)+10]");
					bool flag2 = (nint)0 == 0;
					double num2 = 4.632233691727266E+18;
					if (flag2)
					{
						goto IL_06f4;
					}
				}
				object obj16 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X9_v4+18]");
				bool flag3 = (nint)obj16 < 0;
				object obj17 = !flag3;
				if (obj17 == null)
				{
					object obj18 = obj9 + 1;
					object obj19 = obj7 + obj9;
					_ = 4632374429215621120L;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v5+20]");
					object obj20 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v31+C0]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v32+70]");
					obj3 = 0;
					list.AddWithResize(51.0);
					double num2 = 4.632374429215621E+18;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				List<double> list2 = default(List<double>);
				list2..ctor();
				if (list2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+1C]");
					object obj22 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+10]");
					object obj23 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+18]");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X9_v10+18]");
						bool flag4 = num3 < 0;
						object obj24 = !flag4;
						object obj25;
						object obj28;
						if (obj24 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+18]");
							obj25 = (nint)0 + (nint)1;
							object obj26 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+18]");
							object obj27 = obj26 + 0;
							_ = 4633641066610819072L;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+1C]");
							obj28 = (nint)0 + (nint)2;
						}
						else
						{
							list2.AddWithResize(60.0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+10]");
							obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+18]");
							obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+1C]");
							obj28 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+10]");
							bool flag5 = (nint)0 == 0;
							double num2 = 4.633641066610819E+18;
							if (flag5)
							{
								goto IL_06f4;
							}
						}
						object obj29 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X9_v10+18]");
						bool flag6 = (nint)obj29 < 0;
						object obj30 = !flag6;
						object obj31;
						object obj33;
						if (obj30 == null)
						{
							obj31 = obj25 + 1;
							object obj32 = obj23 + obj25;
							_ = 4633781804099174400L;
							obj33 = obj28 + 1;
						}
						else
						{
							list2.AddWithResize(61.0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+10]");
							obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+18]");
							obj31 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+1C]");
							obj33 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+10]");
							bool flag7 = (nint)0 == 0;
							double num2 = 4.633781804099174E+18;
							if (flag7)
							{
								goto IL_06f4;
							}
						}
						object obj34 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X9_v10+18]");
						bool flag8 = (nint)obj34 < 0;
						object obj35 = !flag8;
						object obj36;
						if (obj35 == null)
						{
							obj36 = obj31 + 1;
							object obj37 = obj23 + obj31;
							_ = 4633922541587529728L;
							object obj38 = obj33 + 1;
						}
						else
						{
							list2.AddWithResize(62.0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+10]");
							obj23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+18]");
							obj36 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+1C]");
							object obj39 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v9 (System.Collections.Generic.List`1<System.Double>)+10]");
							bool flag9 = (nint)0 == 0;
							double num2 = 4.63392254158753E+18;
							if (flag9)
							{
								goto IL_06f4;
							}
						}
						object obj40 = obj36;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X9_v10+18]");
						bool flag10 = (nint)obj40 < 0;
						object obj41 = !flag10;
						if (obj41 == null)
						{
							object obj42 = obj36 + 1;
							object obj43 = obj23 + obj36;
							_ = 4634063279075885056L;
						}
						else
						{
							list2.AddWithResize(63.0);
							double num2 = 4.634063279075885E+18;
						}
						Statistic statistic = default(Statistic);
						((Statistic*)(nint)statistic)->Index = 0;
						object obj44 = statistic + 16;
						obj44 = 0;
						((Statistic*)(nint)statistic)->Index = statIndex;
						object obj45 = statistic + 8;
						obj45 = list;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj44 = list2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Statistic result = default(Statistic);
						return result;
					}
				}
			}
		}
		goto IL_06f4;
		IL_06f4:
		return (Statistic)new NullReferenceException();
	}
}
