using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities.Data;
using UnityEngine.AdaptivePerformance;

public abstract class CardGameStatistics
{
	private const string Statistics = "sts";

	private const string PlayerKey = "p";

	private const string TeamKey = "t";

	private List<Statistic> <StatisticsList>k__BackingField;

	public List<Statistic> StatisticsList
	{
		get
		{
			return <StatisticsList>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public unsafe virtual void SetStatistics(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0e2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e33: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0045: Expected I, but got O
		//IL_0055: Expected O, but got I
		//IL_00f3: Expected O, but got I
		//IL_0117: Expected O, but got I4
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01be: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_0270: Expected O, but got I4
		//IL_01f9: Expected O, but got I
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0163: Expected O, but got I
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_0322: Expected O, but got I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_0398: Expected O, but got I
		//IL_03b6: Expected O, but got I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0ea3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea8: Expected O, but got Unknown
		//IL_0ec0: Expected O, but got I
		//IL_0f1a: Expected O, but got I
		//IL_0f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f38: Expected O, but got Unknown
		//IL_0f4e: Expected O, but got I
		//IL_03e8: Expected O, but got I
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_04b0: Expected O, but got I
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected O, but got Unknown
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_056a: Expected O, but got I4
		//IL_0573: Expected O, but got I4
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_04eb: Expected O, but got I
		//IL_0cca: Expected O, but got Ref
		//IL_0ce2: Expected O, but got Ref
		//IL_0d09: Expected O, but got I
		//IL_0d1e: Expected O, but got I
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected O, but got Unknown
		//IL_0602: Expected O, but got I4
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Expected O, but got Unknown
		//IL_0d33: Expected O, but got I
		//IL_0d5d: Expected O, but got I4
		//IL_0671: Expected O, but got I
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected O, but got Unknown
		//IL_0514: Expected O, but got I
		//IL_033e: Expected O, but got Ref
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0754: Expected O, but got Unknown
		//IL_0769: Expected O, but got I
		//IL_0781: Expected O, but got I4
		//IL_0d81: Expected O, but got I
		//IL_0d9c: Expected O, but got I
		//IL_0dbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc1: Expected O, but got Unknown
		//IL_0dd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd9: Expected O, but got Unknown
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected O, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected O, but got Unknown
		//IL_06ba: Expected O, but got I
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected O, but got Unknown
		//IL_07bb: Expected O, but got I
		//IL_06f5: Expected O, but got I
		//IL_07f6: Expected O, but got I
		//IL_0941: Expected O, but got I
		//IL_095b: Expected O, but got I4
		//IL_0b70: Expected O, but got I
		//IL_0b8a: Expected O, but got I4
		//IL_088a: Expected O, but got I
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected O, but got Unknown
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected O, but got Unknown
		//IL_0ab9: Expected O, but got I
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a83: Expected O, but got Unknown
		//IL_0a99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9e: Expected O, but got Unknown
		//IL_0999: Expected O, but got I4
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_0708: Expected O, but got Unknown
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Expected O, but got Unknown
		//IL_0bc8: Expected O, but got I4
		//IL_0804: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected O, but got Unknown
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected O, but got Unknown
		//IL_09d6: Expected O, but got I4
		//IL_0905: Expected O, but got I4
		//IL_090e: Expected O, but got I4
		//IL_0c05: Expected O, but got I4
		//IL_0b34: Expected O, but got I4
		//IL_0b3d: Expected O, but got I4
		//IL_09f3: Expected O, but got I
		//IL_0a08: Expected O, but got I
		//IL_0c22: Expected O, but got I
		//IL_0c37: Expected O, but got I
		//IL_0a1d: Expected O, but got I
		//IL_0a47: Expected O, but got I4
		//IL_0c4c: Expected O, but got I
		//IL_0c76: Expected O, but got I4
		//IL_0a6b: Expected O, but got I
		//IL_0c9a: Expected O, but got I
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<Statistic> list = default(List<Statistic>);
		list..ctor();
		object obj2 = this + 16;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = typeof(System.IOAsyncCallback) + 976;
		object obj4 = "startPosition" + 968;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00d9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		object obj7;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X10_v46-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj7 = obj6 + 16;
			obj5--;
			bool flag = (nint)obj5 != 1;
			obj6 = obj7;
			if (flag)
			{
				continue;
			}
			goto IL_00d9;
		}
		object obj8 = obj6 + 29;
		object obj9 = num + obj8;
		object obj10 = obj9 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X0_v101+8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v562 @ X0_v101] (should have been resolved before IL gen)");
		object obj12 = default(object);
		bool flag2 = obj12 == null;
		obj7 = obj6;
		if (!flag2)
		{
			goto IL_0192;
		}
		return;
		IL_0192:
		object obj13 = typeof(System.IOAsyncCallback) + 976;
		object obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v11+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v11+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0242;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v588 @ X8_v11+B0]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X10_v41-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			obj7 = obj16 + 16;
			obj15--;
			bool flag3 = (nint)obj15 != 1;
			obj16 = obj7;
			if (flag3)
			{
				continue;
			}
			goto IL_0242;
		}
		object obj17 = obj16 + 3;
		object obj18 = obj14 + obj17;
		object obj19 = obj18 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v694 @ X0_v94] (should have been resolved before IL gen)");
		obj7 = obj16;
		goto IL_02c3;
		IL_0242:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v672 @ X0_v91] (should have been resolved before IL gen)");
		object obj20 = default(object);
		bool flag4 = obj20 == null;
		object obj21 = !flag4;
		if (obj21 != null)
		{
			goto IL_02c3;
		}
		goto IL_0e0e;
		IL_0e0e:
		throw new NullReferenceException();
		IL_02c3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X0_v10+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		object obj22 = obj20 + 32;
		object value = "not" + 2920;
		object obj23 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj24 = 0;
		object obj25 = obj12;
		List<double> list2 = default(List<double>);
		List<double> list3 = default(List<double>);
		object obj40 = default(object);
		object obj45 = default(object);
		double num3 = default(double);
		double num7 = default(double);
		double num9 = default(double);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X8_v14+v186 @ X26_v5*8]");
			int result;
			bool flag5 = int.TryParse((string)0, out result);
			bool flag6 = !flag5;
			object obj26 = !flag6;
			object obj27 = ~obj26;
			if (obj27 == null)
			{
			}
			object obj28 = typeof(System.IOAsyncCallback) + 976;
			object obj29 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v20+12E]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v20+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0431;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X8_v20+B0]");
			object obj31 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X10_v36-8]");
				if (0 == (nint)obj28)
				{
					break;
				}
				obj7 = obj31 + 16;
				obj30--;
				bool flag7 = (nint)obj30 != 1;
				obj31 = obj7;
				if (flag7)
				{
					continue;
				}
				goto IL_0431;
			}
			object obj32 = obj31 + 29;
			object obj33 = obj29 + obj32;
			object obj34 = obj33 + 312;
			obj7 = obj31;
			goto IL_0f0a;
			IL_0f0a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v14+8]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v818 @ X0_v14] (should have been resolved before IL gen)");
			object obj36 = typeof(List<AdaptivePerformanceScaler>) + 872;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj37 = (nint)0 + (nint)1096;
			list2..ctor();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			list3..ctor();
			object obj38 = typeof(System.IOAsyncCallback) + 976;
			object obj39 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v25+12E]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v25+12E]");
			if ((nint)0 == 0)
			{
				goto IL_053c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v25+B0]");
			object obj42 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X10_v31-8]");
				if (0 == (nint)obj38)
				{
					break;
				}
				obj7 = obj42 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X8_v25+12E]");
				obj41 = -1;
				bool flag8 = (nint)obj41 != 1;
				obj42 = obj7;
				if (flag8)
				{
					continue;
				}
				goto IL_053c;
			}
			obj41 = obj42 + 3;
			object obj43 = obj39 + obj41;
			object obj44 = obj43 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v866 @ X0_v84] (should have been resolved before IL gen)");
			obj7 = obj42;
			goto IL_05c6;
			IL_053c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v849 @ X0_v81] (should have been resolved before IL gen)");
			bool flag9 = obj45 == null;
			object obj46 = !flag9;
			obj35 = 3;
			if (obj46 == null)
			{
				break;
			}
			goto IL_05c6;
			IL_05c6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ X0_v21+18]");
			if ((nint)0 >= (nint)1)
			{
				object obj47 = obj45 + 32;
				object obj48 = 0;
				double num2 = num3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X19_v13+v152 @ X28_v8*8]");
					if (((string)0).Contains((string)value))
					{
						object obj49 = typeof(System.IOAsyncCallback) + 976;
						object obj50 = obj40;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X8_v73+12E]");
						object obj51 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X8_v73+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0736;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X8_v73+B0]");
						object obj52 = (nint)0 + (nint)8;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X10_v25-8]");
							if (0 == (nint)obj49)
							{
								break;
							}
							obj52 += 16;
							obj51--;
							if ((nint)obj51 != 1)
							{
								continue;
							}
							goto IL_0736;
						}
						object obj53 = obj52 + 17;
						object obj54 = obj50 + obj53;
						object obj55 = obj54 + 312;
						goto IL_0faf;
					}
					object value2 = "startPosition" + 2136;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X19_v13+v152 @ X28_v8*8]");
					bool flag10 = ((string)0).Contains((string)value2);
					bool flag11 = !flag10;
					obj35 = 0;
					if (flag11)
					{
						goto IL_061f;
					}
					object obj56 = typeof(System.IOAsyncCallback) + 976;
					object obj57 = obj40;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X8_v50+12E]");
					object obj58 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X8_v50+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0837;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X8_v50+B0]");
					object obj59 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1138 @ X10_v18-8]");
						if (0 == (nint)obj56)
						{
							break;
						}
						obj59 += 16;
						obj58--;
						if ((nint)obj58 != 1)
						{
							continue;
						}
						goto IL_0837;
					}
					object obj60 = obj59 + 17;
					object obj61 = obj57 + obj60;
					object obj62 = obj61 + 312;
					goto IL_100a;
					IL_0ad6:
					object obj63 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1224 @ X0_v43+E4]");
					if ((nint)0 != 0)
					{
						goto IL_0b03;
					}
					goto IL_0bd6;
					IL_0b03:
					double num4 = Math.Round(num2, 2, MidpointRounding.ToEven);
					bool flag12 = list3 == null;
					object obj64 = !flag12;
					obj35 = 0;
					if (obj64 == null)
					{
						break;
					}
					goto IL_0c0a;
					IL_0bd6:
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num4 = Math.Round(num2, 2, MidpointRounding.ToEven);
					obj35 = 0;
					goto IL_0c0a;
					IL_0c0a:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v20 (System.Collections.Generic.List`1<System.Double>)+1C]");
					object obj65 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v20 (System.Collections.Generic.List`1<System.Double>)+10]");
					obj41 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v20 (System.Collections.Generic.List`1<System.Double>)+18]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v20 (System.Collections.Generic.List`1<System.Double>)+18]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X9_v43+18]");
					bool flag13 = num5 < 0;
					object obj66 = !flag13;
					if (obj66 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v20 (System.Collections.Generic.List`1<System.Double>)+18]");
						object obj67 = (nint)0 + (nint)1;
						goto IL_1041;
					}
					List<double> list4 = list3;
					goto IL_1060;
					IL_0736:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					goto IL_0faf;
					IL_0faf:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1085 @ X0_v58] (should have been resolved before IL gen)");
					object obj68 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1092 @ X0_v61+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4601]");
						object obj69 = (nint)0 & (nint)1;
						if (obj69 != null)
						{
							goto IL_08a7;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4601]");
						object obj70 = (nint)0 & (nint)1;
						bool flag14 = obj70 == null;
						object obj71 = !flag14;
						if (obj71 != null)
						{
							goto IL_08a7;
						}
					}
					_ = 1;
					object obj72 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ X0_v64+E4]");
					bool flag15 = (nint)0 == 0;
					object obj73 = !flag15;
					if (obj73 != null)
					{
						goto IL_08d4;
					}
					goto IL_09a7;
					IL_100a:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1170 @ X0_v37] (should have been resolved before IL gen)");
					object obj74 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X0_v40+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4601]");
						object obj75 = (nint)0 & (nint)1;
						if (obj75 != null)
						{
							goto IL_0ad6;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4601]");
						object obj76 = (nint)0 & (nint)1;
						bool flag16 = obj76 == null;
						object obj77 = !flag16;
						if (obj77 != null)
						{
							goto IL_0ad6;
						}
					}
					_ = 1;
					obj63 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1224 @ X0_v43+E4]");
					bool flag17 = (nint)0 == 0;
					object obj78 = !flag17;
					if (obj78 != null)
					{
						goto IL_0b03;
					}
					goto IL_0bd6;
					IL_1041:
					object obj79 = obj41 + obj7;
					num2 = num4;
					goto IL_061f;
					IL_0837:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					goto IL_100a;
					IL_08a7:
					obj72 = obj23;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ X0_v64+E4]");
					if ((nint)0 != 0)
					{
						goto IL_08d4;
					}
					goto IL_09a7;
					IL_08d4:
					num4 = Math.Round(num2, 2, MidpointRounding.ToEven);
					bool flag18 = list2 == null;
					object obj80 = !flag18;
					obj35 = 0;
					if (obj80 == null)
					{
						break;
					}
					goto IL_09db;
					IL_09a7:
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					num4 = Math.Round(num2, 2, MidpointRounding.ToEven);
					obj35 = 0;
					goto IL_09db;
					IL_09db:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v18 (System.Collections.Generic.List`1<System.Double>)+1C]");
					object obj81 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v18 (System.Collections.Generic.List`1<System.Double>)+10]");
					obj41 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v18 (System.Collections.Generic.List`1<System.Double>)+18]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v18 (System.Collections.Generic.List`1<System.Double>)+18]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X9_v43+18]");
					bool flag19 = num6 < 0;
					object obj82 = !flag19;
					if (obj82 != null)
					{
						list4 = list2;
						goto IL_1060;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v18 (System.Collections.Generic.List`1<System.Double>)+18]");
					object obj83 = (nint)0 + (nint)1;
					goto IL_1041;
					IL_061f:
					obj48++;
					object obj84 = obj48;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ X0_v21+18]");
					bool flag20 = (nint)obj84 >= 0;
					num3 = num2;
					if (!flag20)
					{
						continue;
					}
					goto IL_0cb4;
					IL_1060:
					list4.AddWithResize(num4);
					num2 = num4;
					goto IL_061f;
				}
				break;
			}
			goto IL_0cb4;
			IL_0cb4:
			List<Statistic> list5 = (List<Statistic>)obj2;
			object obj85 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num7, 1));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj86 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num7, 2));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X24_v6 (System.Collections.Generic.List`1<Statistic>)+1C]");
			object obj87 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X24_v6 (System.Collections.Generic.List`1<Statistic>)+10]");
			object obj88 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X24_v6 (System.Collections.Generic.List`1<Statistic>)+18]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X24_v6 (System.Collections.Generic.List`1<Statistic>)+18]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X9_v17+18]");
			bool flag21 = num8 < 0;
			object obj89 = !flag21;
			if (obj89 != null)
			{
				list5.AddWithResize((Statistic)(&num9));
				obj24++;
				object obj90 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X0_v10+18]");
				bool flag22 = (nint)obj90 >= 0;
				num3 = num7;
				obj25 = obj12;
				if (flag22)
				{
					return;
				}
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X24_v6 (System.Collections.Generic.List`1<Statistic>)+18]");
			object obj91 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X24_v6 (System.Collections.Generic.List`1<Statistic>)+18]");
			object obj92 = (nint)0 * (nint)24;
			object obj93 = obj88 + obj92;
			object obj94 = obj93 + 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj24++;
			object obj95 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X0_v10+18]");
			bool flag23 = (nint)obj95 < 0;
			num3 = num7;
			obj25 = obj12;
			if (!flag23)
			{
				return;
			}
			continue;
			IL_0431:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_0f0a;
		}
		goto IL_0e0e;
		IL_00d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v98+8]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v431 @ X0_v98] (should have been resolved before IL gen)");
		bool flag24 = obj12 == null;
		object obj96 = !flag24;
		if (obj96 == null)
		{
			return;
		}
		goto IL_0192;
	}

	public abstract string GetStatisticName(Statistic stat);

	public abstract string GetStatisticInfo(Statistic stat);

	public abstract StatType GetStatisticType(Statistic stat);
}
