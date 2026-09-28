using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class ProjectsUtility<T> where T : Enum
{
	public struct Project
	{
		public T Type;

		public List<Card> Cards;

		public unsafe Project(T type, List<Card> cards)
		{
			//IL_0013: Expected O, but got Ref
			object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 8));
			obj = cards;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Project, T> <>9__0_0;

		public static Func<Project, T> <>9__1_0;

		public static Func<Project, IEnumerable<Card>> <>9__2_0;

		public static Func<Card, Suit> <>9__4_1;

		public static Func<List<Card>, Rank> <>9__4_3;

		public static Func<Card, Rank> <>9__5_1;

		public static Func<List<Card>, Rank> <>9__5_4;

		static <>c()
		{
			//IL_000c: Expected O, but got I
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0287: Expected O, but got I
			//IL_028f: Expected I, but got O
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Expected O, but got Unknown
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Expected O, but got Unknown
			//IL_02c5: Expected O, but got I4
			//IL_02cd: Expected I, but got O
			//IL_009c: Expected O, but got I
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Expected O, but got Unknown
			//IL_00c4: Expected O, but got I4
			//IL_0053: Expected O, but got I
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_0114: Expected O, but got I
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_0360: Expected O, but got I
			//IL_0370: Expected O, but got I
			//IL_0386: Expected O, but got I
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected O, but got Unknown
			//IL_03ae: Expected O, but got I4
			//IL_03be: Expected O, but got I
			//IL_0300: Expected O, but got I
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Expected O, but got Unknown
			//IL_01b6: Expected O, but got I
			//IL_01ca: Expected O, but got I
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Expected O, but got Unknown
			//IL_0155: Expected O, but got I
			//IL_016b: Expected O, but got I
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			//IL_0198: Expected O, but got I
			//IL_0450: Expected O, but got I
			//IL_0460: Expected O, but got I
			//IL_0476: Expected O, but got I
			//IL_047f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Expected O, but got Unknown
			//IL_049e: Expected O, but got I4
			//IL_04ae: Expected O, but got I
			//IL_03e6: Expected O, but got I
			//IL_03fa: Expected O, but got I
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Expected O, but got Unknown
			//IL_0422: Expected O, but got I4
			//IL_0211: Expected O, but got I
			//IL_0227: Expected O, but got I
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Expected O, but got Unknown
			//IL_0254: Expected O, but got I
			object obj = (nint)0 + (nint)309;
			object obj2 = obj & 1;
			if (obj2 != null)
			{
				nint num = 0;
				nint num2 = num;
				object obj3 = num + 309;
				object obj4 = obj3 & 1;
				bool flag = obj4 == null;
				nint num3 = num;
				if (!flag)
				{
					goto IL_0086;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v6+C0]");
				object obj5 = 0;
				nint num2 = (nint)obj5;
				object obj6 = obj5 + 309;
				object obj7 = obj6 & 1;
				bool flag2 = obj7 == null;
				object obj8 = !flag2;
				nint num3 = (nint)obj5;
				if (obj8 != null)
				{
					goto IL_0086;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)309;
			object obj10 = obj9 & 1;
			bool flag3 = obj10 == null;
			object obj12 = default(object);
			object obj11 = obj12;
			nint num4 = 0;
			if (flag3)
			{
				goto IL_00e8;
			}
			object obj13 = obj12;
			goto IL_00ff;
			IL_01a6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v28+B8]");
			object obj14 = 0;
			obj14 = obj13;
			object obj15 = (nint)0 + (nint)309;
			object obj16 = obj15 & 1;
			bool flag4 = obj16 == null;
			nint num5 = 0;
			if (!flag4)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_01fb:
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ProjectsUtility`1+<>c>)+10]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ProjectsUtility`1+<>c>)+10]");
			object obj18 = (nint)0 + (nint)309;
			object obj19 = obj18 & 1;
			bool flag5 = obj19 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v26 (Il2CppRgctx<ProjectsUtility`1+<>c>)+10]");
			object obj20 = 0;
			if (!flag5)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_04bc:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return;
			IL_0436:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v16+C0]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			object obj22 = (nint)0 + (nint)309;
			object obj23 = obj22 & 1;
			bool flag6 = obj23 == null;
			object obj24 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v14+10]");
			obj20 = 0;
			if (obj24 != null)
			{
				goto IL_0262;
			}
			goto IL_04bc;
			IL_0086:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)309;
			object obj26 = obj25 & 1;
			bool flag7 = obj26 == null;
			object obj27 = !flag7;
			object obj28 = default(object);
			obj11 = obj28;
			num4 = 0;
			obj13 = obj28;
			if (obj27 == null)
			{
				goto IL_00e8;
			}
			goto IL_00ff;
			IL_00e8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			obj13 = obj11;
			goto IL_00ff;
			IL_00ff:
			obj13..ctor();
			object obj29 = (nint)0 + (nint)309;
			object obj30 = obj29 & 1;
			if (obj30 != null)
			{
				nint num7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ProjectsUtility`1+<>c>)+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ProjectsUtility`1+<>c>)+10]");
				object obj32 = (nint)0 + (nint)309;
				object obj33 = obj32 & 1;
				bool flag8 = obj33 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v33 (Il2CppRgctx<ProjectsUtility`1+<>c>)+10]");
				object obj34 = 0;
				if (!flag8)
				{
					goto IL_01a6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v21+C0]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj36 = (nint)0 + (nint)309;
				object obj37 = obj36 & 1;
				bool flag9 = obj37 == null;
				object obj38 = !flag9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v21+10]");
				object obj34 = 0;
				if (obj38 != null)
				{
					goto IL_01a6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v19+B8]");
			object obj39 = 0;
			obj39 = obj13;
			object obj40 = (nint)0 + (nint)309;
			object obj41 = obj40 & 1;
			bool flag10 = obj41 == null;
			object obj42 = !flag10;
			num5 = 0;
			if (obj42 != null)
			{
				goto IL_01fb;
			}
			goto IL_0436;
			IL_0262:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal T <GetBestProjectCards>b__0_0(Project project)
		{
			return (T)project;
		}

		internal T <ProjectsValue>b__1_0(Project project)
		{
			return (T)project;
		}

		internal IEnumerable<Card> <MutuallyExclusive>b__2_0(Project pair)
		{
			//IL_0005: Expected O, but got I
			IntPtr intPtr = default(IntPtr);
			return (IEnumerable<Card>)(nint)intPtr;
		}

		internal Suit <CheckRankSequence>b__4_1(Card card)
		{
			//IL_0035: Expected I4, but got O
			if (card != null)
			{
				return card.<Suit>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Suit)ex;
		}

		internal Rank <CheckRankSequence>b__4_3(List<Card> grouping)
		{
			//IL_0021: Expected I4, but got O
			object obj = Enumerable.First((IEnumerable<object>)grouping);
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Object)+10]");
				return Rank.TWO;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Rank)ex;
		}

		internal Rank <CheckSuitsGroup>b__5_1(Card card)
		{
			//IL_0035: Expected I4, but got O
			if (card != null)
			{
				return card.<Rank>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Rank)ex;
		}

		internal Rank <CheckSuitsGroup>b__5_4(List<Card> grouping)
		{
			//IL_0021: Expected I4, but got O
			object obj = Enumerable.First((IEnumerable<object>)grouping);
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Object)+10]");
				return Rank.TWO;
			}
			NullReferenceException ex = new NullReferenceException();
			return (Rank)ex;
		}
	}

	private sealed class <>c__DisplayClass0_0
	{
		public List<Project> foundProjects;

		public Func<T, int> valueFunction;

		internal unsafe IComparable <GetBestProjectCards>g__ProjectOrderingValue|1(IEnumerable<Project> projectsPairs)
		{
			//IL_0008: Expected O, but got Ref
			//IL_002c: Expected O, but got I4
			//IL_003a: Expected O, but got Ref
			object obj2 = default(object);
			object obj = (object)(&obj2);
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39D9118");
			object obj3 = 153100288 + 1024;
			object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 4));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			IComparable result = default(IComparable);
			return result;
		}
	}

	private sealed class <>c__DisplayClass0_1
	{
		public KeyValuePair<T, ProjectConditions> projectDefinition;

		public <>c__DisplayClass0_0 CS$<>8__locals1;

		internal void <GetBestProjectCards>b__2(List<Card> list)
		{
			//IL_0010: Expected O, but got I
			//IL_0025: Expected O, but got I
			//IL_0050: Expected O, but got I
			//IL_0065: Expected O, but got I
			//IL_0093: Expected O, but got I4
			//IL_00b7: Expected O, but got I
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Expected O, but got Unknown
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected O, but got Unknown
			//IL_00e8: Expected O, but got I4
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProjectsUtility`1<T>+<>c__DisplayClass0_1<T>)+28]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v10 @ X8_v1+10]");
			List<ProjectsUtility<System.Int32Enum>.Project> list2 = (List<ProjectsUtility<System.Int32Enum>.Project>)0;
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39D85CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X19_v2 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+1C]");
			object obj2 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X19_v2 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+10]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X19_v2 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X9_v4+18]");
			bool flag = num2 < 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X19_v2 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
				object obj5 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v17 @ X19_v2 (System.Collections.Generic.List`1<ProjectsUtility`1<System.Int32Enum>+Project<System.Int32Enum>>)+18]");
				object obj6 = obj3 + 0;
				object obj7 = obj6 + 40;
				obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				ProjectsUtility<System.Int32Enum>.Project item = default(ProjectsUtility<System.Int32Enum>.Project);
				list2.AddWithResize(item);
			}
		}
	}

	private sealed class <>c__DisplayClass4_0
	{
		public ProjectConditions conditions;

		internal bool <CheckRankSequence>b__0(Card card)
		{
			//IL_00e1: Expected I4, but got O
			//IL_0069: Expected O, but got I
			//IL_0092: Expected O, but got I
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Expected O, but got Unknown
			if (card != null)
			{
				Rank <Rank>k__BackingField = card.<Rank>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProjectsUtility`1<T>+<>c__DisplayClass4_0<T>)+14]");
				if ((nint)<Rank>k__BackingField > (nint)0)
				{
					return false;
				}
				Rank <Rank>k__BackingField2 = card.<Rank>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProjectsUtility`1<T>+<>c__DisplayClass4_0<T>)+18]");
				object obj = (nint)<Rank>k__BackingField2 - (nint)0;
				bool flag = (nint)obj < 0;
				Rank <Rank>k__BackingField3 = card.<Rank>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProjectsUtility`1<T>+<>c__DisplayClass4_0<T>)+18]");
				object obj2 = (nint)<Rank>k__BackingField3 ^ (nint)0;
				object obj3 = card.<Rank>k__BackingField ^ obj;
				object obj4 = obj2 & obj3;
				bool flag2 = (nint)obj4 < 0;
				return flag == flag2;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <CheckRankSequence>b__2(IGrouping<Suit, Card> cardsGrouping)
		{
			//IL_0028: Expected O, but got I
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected I4, but got Unknown
			int num = Enumerable.Count((IEnumerable<object>)cardsGrouping);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProjectsUtility`1<T>+<>c__DisplayClass4_0<T>)+1C]");
			object obj = (nint)num - (nint)0;
			bool flag = (nint)obj < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProjectsUtility`1<T>+<>c__DisplayClass4_0<T>)+1C]");
			int num2 = (int)((nint)num ^ (nint)0);
			int num3 = num ^ obj;
			int num4 = num2 & num3;
			bool flag2 = num4 < 0;
			return flag == flag2;
		}
	}

	private sealed class <>c__DisplayClass5_0
	{
		public ProjectConditions conditions;

		internal bool <CheckSuitsGroup>b__0(Card card)
		{
			//IL_00e1: Expected I4, but got O
			//IL_0069: Expected O, but got I
			//IL_0092: Expected O, but got I
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Expected O, but got Unknown
			if (card != null)
			{
				Rank <Rank>k__BackingField = card.<Rank>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProjectsUtility`1<T>+<>c__DisplayClass5_0<T>)+14]");
				if ((nint)<Rank>k__BackingField > (nint)0)
				{
					return false;
				}
				Rank <Rank>k__BackingField2 = card.<Rank>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProjectsUtility`1<T>+<>c__DisplayClass5_0<T>)+18]");
				object obj = (nint)<Rank>k__BackingField2 - (nint)0;
				bool flag = (nint)obj < 0;
				Rank <Rank>k__BackingField3 = card.<Rank>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProjectsUtility`1<T>+<>c__DisplayClass5_0<T>)+18]");
				object obj2 = (nint)<Rank>k__BackingField3 ^ (nint)0;
				object obj3 = card.<Rank>k__BackingField ^ obj;
				object obj4 = obj2 & obj3;
				bool flag2 = (nint)obj4 < 0;
				return flag == flag2;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <CheckSuitsGroup>b__2(IGrouping<Rank, Card> cardsGrouping)
		{
			//IL_0028: Expected O, but got I
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected I4, but got Unknown
			int num = Enumerable.Count((IEnumerable<object>)cardsGrouping);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProjectsUtility`1<T>+<>c__DisplayClass5_0<T>)+1C]");
			object obj = (nint)num - (nint)0;
			bool flag = (nint)obj < 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProjectsUtility`1<T>+<>c__DisplayClass5_0<T>)+1C]");
			int num2 = (int)((nint)num ^ (nint)0);
			int num3 = num ^ obj;
			int num4 = num2 & num3;
			bool flag2 = num4 < 0;
			return flag == flag2;
		}

		internal List<Card> <CheckSuitsGroup>b__3(IGrouping<Rank, Card> grouping)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ProjectsUtility`1<T>+<>c__DisplayClass5_0<T>)+1C]");
			IEnumerable<object> source = Enumerable.Take((IEnumerable<object>)grouping, 0);
			return (List<Card>)(object)Enumerable.ToList(source);
		}
	}

	protected unsafe static List<Project> GetBestProjectCards(List<KeyValuePair<T, ProjectConditions>> projectDefinitions, List<Card> cards, Func<T, int> valueFunction)
	{
		//IL_1d8f: Expected O, but got I
		//IL_1d98: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d9d: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		//IL_014b: Expected I, but got O
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0181: Expected O, but got I4
		//IL_0189: Expected I, but got O
		//IL_006a: Expected O, but got I
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0021: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0222: Expected O, but got I
		//IL_0232: Expected O, but got I
		//IL_025d: Expected I, but got O
		//IL_0268: Expected O, but got I4
		//IL_0271: Expected O, but got I4
		//IL_00c1: Expected O, but got I
		//IL_00e5: Expected O, but got I4
		//IL_01bc: Expected O, but got I
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01e4: Expected O, but got I4
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02b8: Expected O, but got I
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02d8: Expected O, but got I
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_00f8: Expected I, but got O
		//IL_0103: Expected O, but got I4
		//IL_010c: Expected O, but got I4
		//IL_0331: Expected I, but got O
		//IL_0345: Expected I, but got O
		//IL_0350: Expected O, but got I4
		//IL_0359: Expected O, but got I4
		//IL_035e: Expected I, but got O
		//IL_039e: Expected O, but got I
		//IL_03aa: Expected O, but got I
		//IL_03d9: Expected O, but got I
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_0c31: Expected O, but got I
		//IL_0c41: Expected O, but got I
		//IL_0c57: Expected O, but got I
		//IL_0c60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c65: Expected O, but got Unknown
		//IL_0c7f: Expected O, but got I4
		//IL_0c8f: Expected O, but got I
		//IL_0481: Expected O, but got I
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048f: Expected O, but got Unknown
		//IL_04a9: Expected O, but got I4
		//IL_041a: Expected O, but got I
		//IL_0430: Expected O, but got I
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Expected O, but got Unknown
		//IL_045d: Expected O, but got I
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_0527: Expected I, but got O
		//IL_0532: Expected O, but got I4
		//IL_053b: Expected O, but got I4
		//IL_0540: Expected I, but got O
		//IL_0cc2: Expected O, but got I
		//IL_0ccb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd0: Expected O, but got Unknown
		//IL_0573: Expected O, but got I
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		//IL_059b: Expected O, but got I4
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_05d8: Expected O, but got I
		//IL_05ee: Expected O, but got I
		//IL_0603: Expected O, but got Ref
		//IL_0608: Expected I, but got O
		//IL_0615: Expected I, but got O
		//IL_1e4b: Expected O, but got I
		//IL_1e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e59: Expected O, but got Unknown
		//IL_1e73: Expected O, but got I4
		//IL_0647: Expected O, but got I
		//IL_09b0: Expected O, but got I4
		//IL_09b8: Expected O, but got Ref
		//IL_09c9: Expected O, but got I4
		//IL_1ea0: Expected O, but got I
		//IL_1ea9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eae: Expected O, but got Unknown
		//IL_1ec8: Expected O, but got I4
		//IL_067d: Expected O, but got I
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected O, but got Unknown
		//IL_06a5: Expected O, but got I4
		//IL_09f3: Expected O, but got I
		//IL_0a16: Expected O, but got I4
		//IL_06d8: Expected O, but got I
		//IL_06ee: Expected O, but got I
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fc: Expected O, but got Unknown
		//IL_0716: Expected O, but got I4
		//IL_0749: Expected O, but got I
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected O, but got Unknown
		//IL_0771: Expected O, but got I4
		//IL_0a38: Expected O, but got I
		//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a46: Expected O, but got Unknown
		//IL_0a60: Expected O, but got I4
		//IL_07a4: Expected O, but got I
		//IL_0a99: Expected O, but got I
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa7: Expected O, but got Unknown
		//IL_0ac1: Expected O, but got I4
		//IL_0af4: Expected O, but got I
		//IL_0b0a: Expected O, but got I
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected O, but got Unknown
		//IL_0b32: Expected O, but got I4
		//IL_1ce2: Expected O, but got I4
		//IL_1cea: Expected O, but got Ref
		//IL_07d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d9: Expected O, but got Unknown
		//IL_07f7: Expected O, but got I
		//IL_0800: Unknown result type (might be due to invalid IL or missing references)
		//IL_0805: Expected O, but got Unknown
		//IL_081f: Expected O, but got I4
		//IL_0b65: Expected O, but got I
		//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Expected O, but got Unknown
		//IL_0b8d: Expected O, but got I4
		//IL_1dd5: Expected O, but got I
		//IL_1dfb: Expected O, but got I
		//IL_1e0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e11: Expected O, but got Unknown
		//IL_1e2b: Expected O, but got I4
		//IL_0d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2c: Expected O, but got Unknown
		//IL_0d46: Expected O, but got I4
		//IL_1ef6: Expected O, but got I
		//IL_1eff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f04: Expected O, but got Unknown
		//IL_1f1e: Expected O, but got I4
		//IL_0da1: Expected O, but got I
		//IL_0daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daf: Expected O, but got Unknown
		//IL_0dc9: Expected O, but got I4
		//IL_0bb1: Expected O, but got I
		//IL_0bc1: Expected O, but got I
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Expected O, but got Unknown
		//IL_088d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0892: Expected O, but got Unknown
		//IL_08b9: Expected O, but got I
		//IL_0852: Expected O, but got I
		//IL_0e09: Expected O, but got I
		//IL_0e12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e17: Expected O, but got Unknown
		//IL_0e31: Expected O, but got I4
		//IL_0e64: Expected O, but got I
		//IL_0e7a: Expected O, but got I
		//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e88: Expected O, but got Unknown
		//IL_0ea2: Expected O, but got I4
		//IL_08dd: Expected O, but got I
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Expected O, but got Unknown
		//IL_0905: Expected O, but got I4
		//IL_0ed5: Expected O, but got I
		//IL_0ede: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee3: Expected O, but got Unknown
		//IL_0efd: Expected O, but got I4
		//IL_0fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fab: Expected O, but got Unknown
		//IL_0fc5: Expected O, but got I4
		//IL_1ca9: Expected I, but got O
		//IL_1cb9: Expected O, but got I
		//IL_1016: Expected O, but got I
		//IL_1033: Expected O, but got I
		//IL_103c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1041: Expected O, but got Unknown
		//IL_105b: Expected O, but got I4
		//IL_0f21: Expected O, but got I
		//IL_0f31: Expected O, but got I
		//IL_0f4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f4f: Expected O, but got Unknown
		//IL_0973: Expected O, but got I
		//IL_0978: Expected I, but got O
		//IL_10ab: Expected O, but got I
		//IL_10b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b9: Expected O, but got Unknown
		//IL_1345: Expected O, but got I
		//IL_1355: Expected O, but got I
		//IL_136b: Expected O, but got I
		//IL_1374: Unknown result type (might be due to invalid IL or missing references)
		//IL_1379: Expected O, but got Unknown
		//IL_1393: Expected O, but got I4
		//IL_13a3: Expected O, but got I
		//IL_10ec: Expected O, but got I
		//IL_1102: Expected O, but got I
		//IL_110b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1110: Expected O, but got Unknown
		//IL_112f: Expected O, but got I
		//IL_1401: Expected O, but got I
		//IL_140a: Unknown result type (might be due to invalid IL or missing references)
		//IL_140f: Expected O, but got Unknown
		//IL_1429: Expected O, but got I4
		//IL_13dd: Expected O, but got I4
		//IL_11b5: Expected O, but got I
		//IL_11cb: Expected O, but got I
		//IL_11d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d9: Expected O, but got Unknown
		//IL_11f8: Expected O, but got I
		//IL_116e: Expected O, but got I
		//IL_1177: Unknown result type (might be due to invalid IL or missing references)
		//IL_117c: Expected O, but got Unknown
		//IL_14dd: Expected O, but got I
		//IL_14ed: Expected O, but got I
		//IL_150f: Expected O, but got I4
		//IL_1457: Expected O, but got I
		//IL_1467: Expected O, but got I
		//IL_147d: Expected O, but got I
		//IL_1486: Unknown result type (might be due to invalid IL or missing references)
		//IL_148b: Expected O, but got Unknown
		//IL_14a5: Expected O, but got I4
		//IL_14b5: Expected O, but got I
		//IL_1257: Expected O, but got I
		//IL_1260: Unknown result type (might be due to invalid IL or missing references)
		//IL_1265: Expected O, but got Unknown
		//IL_127f: Expected O, but got I4
		//IL_1216: Expected O, but got I
		//IL_1226: Expected O, but got I
		//IL_12e6: Expected O, but got I
		//IL_12ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f4: Expected O, but got Unknown
		//IL_130e: Expected O, but got I4
		//IL_1529: Expected O, but got I
		//IL_1532: Unknown result type (might be due to invalid IL or missing references)
		//IL_1537: Expected O, but got Unknown
		//IL_1852: Expected O, but got I
		//IL_1862: Expected O, but got I
		//IL_1878: Expected O, but got I
		//IL_1881: Unknown result type (might be due to invalid IL or missing references)
		//IL_1886: Expected O, but got Unknown
		//IL_18a0: Expected O, but got I4
		//IL_18b0: Expected O, but got I
		//IL_156a: Expected O, but got I
		//IL_1580: Expected O, but got I
		//IL_1589: Unknown result type (might be due to invalid IL or missing references)
		//IL_158e: Expected O, but got Unknown
		//IL_15ad: Expected O, but got I
		//IL_190e: Expected O, but got I
		//IL_1917: Unknown result type (might be due to invalid IL or missing references)
		//IL_191c: Expected O, but got Unknown
		//IL_1936: Expected O, but got I4
		//IL_18ea: Expected O, but got I4
		//IL_1633: Expected O, but got I
		//IL_1649: Expected O, but got I
		//IL_1652: Unknown result type (might be due to invalid IL or missing references)
		//IL_1657: Expected O, but got Unknown
		//IL_1671: Expected O, but got I4
		//IL_1681: Expected O, but got I
		//IL_15ec: Expected O, but got I
		//IL_15f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_15fa: Expected O, but got Unknown
		//IL_16ae: Expected O, but got I
		//IL_16ba: Expected O, but got I
		//IL_16c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c8: Expected O, but got Unknown
		//IL_16e2: Expected O, but got I4
		//IL_1964: Expected O, but got I
		//IL_1974: Expected O, but got I
		//IL_198a: Expected O, but got I
		//IL_1993: Unknown result type (might be due to invalid IL or missing references)
		//IL_1998: Expected O, but got Unknown
		//IL_1715: Expected O, but got I
		//IL_172b: Expected O, but got I
		//IL_1734: Unknown result type (might be due to invalid IL or missing references)
		//IL_1739: Expected O, but got Unknown
		//IL_1753: Expected O, but got I4
		//IL_1786: Expected O, but got I
		//IL_178f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1794: Expected O, but got Unknown
		//IL_17ae: Expected O, but got I4
		//IL_19c5: Expected O, but got I
		//IL_19e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ee: Expected O, but got Unknown
		//IL_1a08: Expected O, but got I4
		//IL_1a59: Expected O, but got I
		//IL_1a76: Expected O, but got I
		//IL_1a7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a84: Expected O, but got Unknown
		//IL_1a9e: Expected O, but got I4
		//IL_17d2: Expected O, but got I
		//IL_17e2: Expected O, but got I
		//IL_17fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1800: Expected O, but got Unknown
		//IL_1ad1: Expected O, but got I
		//IL_1ae7: Expected O, but got I
		//IL_1af0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af5: Expected O, but got Unknown
		//IL_1b0f: Expected O, but got I4
		//IL_1b3c: Expected O, but got I
		//IL_1b4d: Expected O, but got I
		//IL_1b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5b: Expected O, but got Unknown
		//IL_1b75: Expected O, but got I4
		//IL_1ba8: Expected O, but got I
		//IL_1bbe: Expected O, but got I
		//IL_1bc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bcc: Expected O, but got Unknown
		//IL_1be6: Expected O, but got I4
		//IL_1c19: Expected O, but got I
		//IL_1c2f: Expected O, but got I
		//IL_1c38: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c3d: Expected O, but got Unknown
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		if (obj2 != null)
		{
			nint num = 0;
			nint num2 = num;
			object obj3 = num + 309;
			object obj4 = obj3 & 1;
			bool flag = obj4 == null;
			nint num3 = num;
			if (!flag)
			{
				goto IL_0054;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v225+C0]");
			object obj5 = 0;
			nint num2 = (nint)obj5;
			object obj6 = obj5 + 309;
			object obj7 = obj6 & 1;
			bool flag2 = obj7 == null;
			object obj8 = !flag2;
			nint num3 = (nint)obj5;
			if (obj8 != null)
			{
				goto IL_0054;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		object obj13 = default(object);
		object obj12 = obj13;
		nint num4 = 0;
		object obj14 = obj13;
		if (obj11 != null)
		{
			goto IL_00ab;
		}
		goto IL_0208;
		IL_04cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		List<ProjectsUtility<System.Int32Enum>.Project> list2;
		List<ProjectsUtility<System.Int32Enum>.Project> list = list2;
		goto IL_04e4;
		IL_04e4:
		list..ctor();
		List<Card> list3 = (List<Card>)(obj12 + 16);
		list3 = (List<Card>)(object)list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag4 = projectDefinitions == null;
		nint num5 = unchecked((nint)null);
		List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator enumerator = (List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator)0;
		List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator enumerator2 = (List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator)0;
		nint num6 = unchecked((nint)null);
		object obj15 = list;
		obj14 = obj12;
		IntPtr intPtr = default(IntPtr);
		nint num7 = intPtr;
		object obj19;
		object obj20;
		object obj51;
		Func<T, int> func = default(Func<T, int>);
		if (!flag4)
		{
			object obj16 = (nint)0 + (nint)309;
			object obj17 = obj16 & 1;
			bool flag5 = obj17 == null;
			object obj18 = !flag5;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 720;
			obj20 = (nint)0 + (nint)2832;
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v176 (Il2CppRgctx<ProjectsUtility`1>)+30]");
			Action<object> action = (Action<object>)0;
			List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator enumerator3 = ((List<KeyValuePair<System.Int32Enum, ProjectConditions>>)(object)projectDefinitions).GetEnumerator();
			object obj21 = (object)(&enumerator);
			num5 = unchecked((nint)null);
			List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator enumerator4 = default(List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator);
			enumerator2 = enumerator4;
			num6 = unchecked((nint)null);
			num7 = intPtr;
			List<KeyValuePair<T, ProjectConditions>> list4 = default(List<KeyValuePair<T, ProjectConditions>>);
			object obj47 = default(object);
			List<ProjectsUtility<System.Int32Enum>.Project> list5 = default(List<ProjectsUtility<System.Int32Enum>.Project>);
			List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator enumerator7 = default(List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator);
			object obj75 = default(object);
			List<Project> result = default(List<Project>);
			Func<object, object> func2 = default(Func<object, object>);
			Func<object, bool> func5 = default(Func<object, bool>);
			IEnumerable<object> source2 = default(IEnumerable<object>);
			Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum> func6 = default(Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum>);
			IEnumerable<ProjectsUtility<System.Int32Enum>.Project> source3 = default(IEnumerable<ProjectsUtility<System.Int32Enum>.Project>);
			List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator enumerator6;
			while (true)
			{
				object obj22 = (nint)0 + (nint)309;
				object obj23 = obj22 & 1;
				bool flag6 = obj23 == null;
				object obj24 = !flag6;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v360 @ X8_v184 (Il2CppRgctx<ProjectsUtility`1>)+90]");
				obj15 = 0;
				if (enumerator.MoveNext())
				{
					object obj25 = (nint)0 + (nint)309;
					object obj26 = obj25 & 1;
					bool flag7 = obj26 == null;
					object obj27 = !flag7;
					if (obj27 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v188 (Il2CppRgctx<ProjectsUtility`1>)+40]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v188 (Il2CppRgctx<ProjectsUtility`1>)+40]");
					object obj29 = (nint)0 + (nint)309;
					object obj30 = obj29 & 1;
					bool flag8 = obj30 == null;
					object obj31 = !flag8;
					if (obj31 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj32 = (nint)0 + (nint)309;
					object obj33 = obj32 & 1;
					bool flag9 = obj33 == null;
					object obj34 = !flag9;
					if (obj34 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v194 (Il2CppRgctx<ProjectsUtility`1>)+48]");
					obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31D2868");
					if (list4 != null)
					{
						object obj35 = list4 + 40;
						obj35 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj36 = (nint)0 + (nint)309;
						object obj37 = obj36 & 1;
						bool flag10 = obj37 == null;
						object obj38 = !flag10;
						if (obj38 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X27_v7+10]");
						enumerator2 = (List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X27_v7+20]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X27_v7+10]");
						_ = 0;
						object obj39 = (nint)0 + (nint)309;
						object obj40 = obj39;
						object obj41 = obj39 & 1;
						bool flag11 = obj41 == null;
						object obj42 = !flag11;
						nint num12 = 0;
						if (obj42 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							object obj43 = (nint)0 + (nint)309;
							obj40 = obj43;
							num12 = 0;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v179 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<T, ProjectConditions>>)+14]");
						num7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v179 (System.Collections.Generic.List`1<System.Collections.Generic.KeyValuePair`2<T, ProjectConditions>>)+1C]");
						list = (List<ProjectsUtility<System.Int32Enum>.Project>)0;
						object obj44 = obj40 & 1;
						bool flag12 = obj44 == null;
						object obj45 = !flag12;
						if (obj45 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						}
						nint num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39D98A4");
						object obj46 = obj47 & 1;
						bool flag13 = obj46 == null;
						num6 = (nint)(&num5);
						func = (Func<T, int>)(object)list;
						action = (Action<object>)num7;
						if (!flag13)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj48 = (nint)0 + (nint)309;
							object obj49 = obj48 & 1;
							bool flag14 = obj49 == null;
							object obj50 = !flag14;
							if (obj50 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							}
							nint num14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v205 (Il2CppRgctx<ProjectsUtility`1>)+88]");
							((Action<object>)(object)list5)..ctor((object)list4, (IntPtr)0);
							if (num5 == 0)
							{
								NullReferenceException ex = new NullReferenceException();
								num6 = unchecked((nint)null);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X8_v205 (Il2CppRgctx<ProjectsUtility`1>)+88]");
								func = (Func<T, int>)0;
								obj15 = list4;
								break;
							}
							func = (Func<T, int>)obj20;
							((List<object>)num5).ForEach((Action<object>)(object)list5);
							num6 = unchecked((nint)null);
							list = list5;
							action = (Action<object>)(object)list5;
							num7 = num5;
						}
						continue;
					}
					NullReferenceException ex2 = new NullReferenceException();
					break;
				}
				List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator enumerator5 = enumerator4;
				enumerator6 = enumerator7;
				enumerator4 = (List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator)0;
				obj51 = (object)(&enumerator);
				obj14 = obj12;
				object obj52 = 0;
				while (true)
				{
					object obj53 = (nint)0 + (nint)309;
					object obj54 = obj53 & 1;
					bool flag15 = obj54 == null;
					object obj55 = !flag15;
					if (obj55 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					nint num15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v9 (Il2CppRgctx<ProjectsUtility`1>)+98]");
					obj15 = 0;
					enumerator5.Dispose();
					bool flag16 = obj52 == null;
					object obj56 = !flag16;
					enumerator = enumerator5;
					nint num18;
					nint method;
					if (obj56 == null)
					{
						object obj57 = (nint)0 + (nint)309;
						object obj58 = obj57 & 1;
						bool flag17 = obj58 == null;
						object obj59 = !flag17;
						if (obj59 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						}
						nint num16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C97010");
						object obj60 = (nint)0 + (nint)309;
						object obj61 = obj60 & 1;
						bool flag18 = obj61 == null;
						object obj62 = !flag18;
						if (obj62 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						}
						nint num17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v17 (Il2CppRgctx<ProjectsUtility`1>)+B8]");
						object obj63 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v17 (Il2CppRgctx<ProjectsUtility`1>)+B8]");
						object obj64 = (nint)0 + (nint)309;
						object obj65 = obj64 & 1;
						bool flag19 = obj65 == null;
						object obj66 = !flag19;
						if (obj66 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj67 = (nint)0 + (nint)309;
						object obj68 = obj67 & 1;
						bool flag20 = obj68 == null;
						object obj69 = !flag20;
						if (obj69 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
							object obj70 = (nint)0 + (nint)309;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X0_v127+C0]");
							object obj71 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v158+B0]");
							num18 = 0;
							object obj72 = obj70 & 1;
							bool flag21 = obj72 == null;
							nint num19 = 0;
							if (flag21)
							{
								goto IL_0d6a;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v158+B0]");
							method = 0;
						}
						else
						{
							nint num20 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v156 (Il2CppRgctx<ProjectsUtility`1>)+B0]");
							num18 = 0;
							object obj73 = obj67 & 1;
							bool flag22 = obj73 == null;
							object obj74 = !flag22;
							nint num19 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X8_v156 (Il2CppRgctx<ProjectsUtility`1>)+B0]");
							method = 0;
							if (obj74 == null)
							{
								goto IL_0d6a;
							}
						}
						goto IL_0d81;
					}
					OutOfMemoryException ex3 = new OutOfMemoryException();
					if ((nint)obj15 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
						obj52 = obj75;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
						enumerator5 = enumerator;
						enumerator4 = (List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator)obj75;
						continue;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1D60BDC");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
					return result;
					IL_168f:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					goto IL_169e;
					IL_1000:
					nint num21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v37 (Il2CppRgctx<ProjectsUtility`1>)+E0]");
					object obj76 = 0;
					nint method2;
					func2..ctor(obj14, (IntPtr)method2);
					object obj77 = (nint)0 + (nint)309;
					object obj78 = obj77 & 1;
					bool flag23 = obj78 == null;
					object obj79 = !flag23;
					if (obj79 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					nint num22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v41 (Il2CppRgctx<ProjectsUtility`1>)+E8]");
					nint num23 = 0;
					IEnumerable<object> source;
					object obj80 = ArraysExtensions.MaxBy(source, (Func<object, IComparable>)func2);
					object obj81 = (nint)0 + (nint)309;
					object obj82 = obj81 & 1;
					if (obj82 != null)
					{
						nint num24 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v148 (Il2CppRgctx<ProjectsUtility`1>)+108]");
						object obj83 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v148 (Il2CppRgctx<ProjectsUtility`1>)+108]");
						object obj84 = (nint)0 + (nint)309;
						object obj85 = obj84 & 1;
						bool flag24 = obj85 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v148 (Il2CppRgctx<ProjectsUtility`1>)+108]");
						object obj86 = 0;
						if (!flag24)
						{
							goto IL_113d;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v770 @ X0_v96+C0]");
						object obj87 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v121+108]");
						object obj83 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v121+108]");
						object obj88 = (nint)0 + (nint)309;
						object obj89 = obj88 & 1;
						bool flag25 = obj89 == null;
						object obj90 = !flag25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X8_v121+108]");
						object obj86 = 0;
						if (obj90 != null)
						{
							goto IL_113d;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X0_v91+E4]");
					bool flag26 = (nint)0 == 0;
					object obj91 = !flag26;
					if (obj91 != null)
					{
						goto IL_1162;
					}
					goto IL_13eb;
					IL_161d:
					nint num25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X8_v96 (Il2CppRgctx<ProjectsUtility`1>)+108]");
					object obj92 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X8_v96 (Il2CppRgctx<ProjectsUtility`1>)+108]");
					object obj93 = (nint)0 + (nint)309;
					object obj94 = obj93 & 1;
					bool flag27 = obj94 == null;
					object obj95 = !flag27;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v983 @ X8_v96 (Il2CppRgctx<ProjectsUtility`1>)+108]");
					object obj96 = 0;
					if (obj95 == null)
					{
						goto IL_168f;
					}
					goto IL_169e;
					IL_169e:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1005 @ X0_v48+B8]");
					object obj97 = 0;
					object obj98 = (nint)0 + (nint)309;
					object obj99 = obj98 & 1;
					bool flag28 = obj99 == null;
					object obj100 = !flag28;
					if (obj100 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					nint num26 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X8_v66 (Il2CppRgctx<ProjectsUtility`1>)+100]");
					object obj101 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1021 @ X8_v66 (Il2CppRgctx<ProjectsUtility`1>)+100]");
					object obj102 = (nint)0 + (nint)309;
					object obj103 = obj102 & 1;
					bool flag29 = obj103 == null;
					object obj104 = !flag29;
					if (obj104 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj105 = (nint)0 + (nint)309;
					object obj106 = obj105 & 1;
					bool flag30 = obj106 == null;
					object obj107 = !flag30;
					nint num27;
					nint num29;
					if (obj107 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						object obj108 = (nint)0 + (nint)309;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1038 @ X0_v74+C0]");
						object obj109 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X8_v93+110]");
						num27 = 0;
						object obj110 = obj108 & 1;
						bool flag31 = obj110 == null;
						nint num28 = 0;
						if (flag31)
						{
							goto IL_1a2c;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X8_v93+110]");
						num29 = 0;
					}
					else
					{
						nint num30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ X8_v91 (Il2CppRgctx<ProjectsUtility`1>)+110]");
						num27 = 0;
						object obj111 = obj105 & 1;
						bool flag32 = obj111 == null;
						object obj112 = !flag32;
						nint num28 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1039 @ X8_v91 (Il2CppRgctx<ProjectsUtility`1>)+110]");
						num29 = 0;
						if (obj112 == null)
						{
							goto IL_1a2c;
						}
					}
					goto IL_1a43;
					IL_12ab:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					object obj113 = obj76;
					Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum> func4;
					Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum> func3 = func4;
					goto IL_12ca;
					IL_1162:
					object obj114 = (nint)0 + (nint)309;
					object obj115 = obj114 & 1;
					bool flag33 = obj115 == null;
					nint num31 = 0;
					if (!flag33)
					{
						goto IL_119f;
					}
					goto IL_143d;
					IL_113d:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v811 @ X0_v91+E4]");
					if ((nint)0 != 0)
					{
						goto IL_1162;
					}
					goto IL_13eb;
					IL_143d:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v832 @ X0_v89+C0]");
					object obj116 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v112+108]");
					object obj117 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v112+108]");
					object obj118 = (nint)0 + (nint)309;
					object obj119 = obj118 & 1;
					bool flag34 = obj119 == null;
					object obj120 = !flag34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v112+108]");
					object obj121 = 0;
					if (obj120 != null)
					{
						goto IL_1206;
					}
					goto IL_14c3;
					IL_13eb:
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj122 = (nint)0 + (nint)309;
					object obj123 = obj122 & 1;
					bool flag35 = obj123 == null;
					object obj124 = !flag35;
					num31 = 0;
					if (obj124 != null)
					{
						goto IL_119f;
					}
					goto IL_143d;
					IL_119f:
					nint num32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v139 (Il2CppRgctx<ProjectsUtility`1>)+108]");
					obj117 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v139 (Il2CppRgctx<ProjectsUtility`1>)+108]");
					object obj125 = (nint)0 + (nint)309;
					object obj126 = obj125 & 1;
					bool flag36 = obj126 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v823 @ X8_v139 (Il2CppRgctx<ProjectsUtility`1>)+108]");
					obj121 = 0;
					if (!flag36)
					{
						goto IL_1206;
					}
					goto IL_14c3;
					IL_14c3:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X0_v87+B8]");
					object obj127 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v109+8]");
					func4 = (Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v109+8]");
					bool flag37 = (nint)0 == 0;
					object obj128 = !flag37;
					if (obj128 != null)
					{
						goto IL_124b;
					}
					goto IL_151d;
					IL_1206:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X0_v110+B8]");
					object obj129 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v136+8]");
					func4 = (Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X8_v136+8]");
					if ((nint)0 != 0)
					{
						goto IL_124b;
					}
					goto IL_151d;
					IL_0d6a:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					method = num18;
					goto IL_0d81;
					IL_0d81:
					nint num33 = 0;
					func5..ctor((object)null, (IntPtr)method);
					object obj130 = (nint)0 + (nint)309;
					object obj131 = obj130 & 1;
					bool flag38 = obj131 == null;
					object obj132 = !flag38;
					if (obj132 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					nint num34 = 0;
					source = Enumerable.Where(source2, func5);
					object obj133 = (nint)0 + (nint)309;
					object obj134 = obj133 & 1;
					bool flag39 = obj134 == null;
					object obj135 = !flag39;
					if (obj135 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					nint num35 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v31 (Il2CppRgctx<ProjectsUtility`1>)+D8]");
					object obj136 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v31 (Il2CppRgctx<ProjectsUtility`1>)+D8]");
					object obj137 = (nint)0 + (nint)309;
					object obj138 = obj137 & 1;
					bool flag40 = obj138 == null;
					object obj139 = !flag40;
					if (obj139 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj140 = (nint)0 + (nint)309;
					object obj141 = obj140 & 1;
					bool flag41 = obj141 == null;
					object obj142 = !flag41;
					nint num36;
					if (obj142 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						object obj143 = (nint)0 + (nint)309;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v120+C0]");
						object obj144 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v154+D0]");
						num36 = 0;
						object obj145 = obj143 & 1;
						bool flag42 = obj145 == null;
						nint num37 = 0;
						if (flag42)
						{
							goto IL_0fe9;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v697 @ X8_v154+D0]");
						method2 = 0;
					}
					else
					{
						nint num38 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v152 (Il2CppRgctx<ProjectsUtility`1>)+D0]");
						num36 = 0;
						object obj146 = obj140 & 1;
						bool flag43 = obj146 == null;
						object obj147 = !flag43;
						nint num37 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v682 @ X8_v152 (Il2CppRgctx<ProjectsUtility`1>)+D0]");
						method2 = 0;
						if (obj147 == null)
						{
							goto IL_0fe9;
						}
					}
					goto IL_1000;
					IL_1a43:
					nint num39 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1062 @ X8_v72 (Il2CppRgctx<ProjectsUtility`1>)+118]");
					obj76 = 0;
					func6..ctor(obj97, (IntPtr)num29);
					object obj148 = (nint)0 + (nint)309;
					object obj149 = obj148 & 1;
					bool flag44 = obj149 == null;
					object obj150 = !flag44;
					if (obj150 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					nint num40 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ X8_v76 (Il2CppRgctx<ProjectsUtility`1>)+108]");
					object obj151 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1074 @ X8_v76 (Il2CppRgctx<ProjectsUtility`1>)+108]");
					object obj152 = (nint)0 + (nint)309;
					object obj153 = obj152 & 1;
					bool flag45 = obj153 == null;
					object obj154 = !flag45;
					if (obj154 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1082 @ X0_v60+B8]");
					object obj155 = 0;
					object obj156 = (nint)0 + (nint)309;
					object obj157 = obj156 & 1;
					bool flag46 = obj157 == null;
					object obj158 = !flag46;
					if (obj158 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					nint num41 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1093 @ X8_v83 (Il2CppRgctx<ProjectsUtility`1>)+108]");
					object obj159 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1093 @ X8_v83 (Il2CppRgctx<ProjectsUtility`1>)+108]");
					object obj160 = (nint)0 + (nint)309;
					object obj161 = obj160 & 1;
					bool flag47 = obj161 == null;
					object obj162 = !flag47;
					if (obj162 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1101 @ X0_v64+B8]");
					object obj163 = (nint)0 + (nint)8;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj164 = (nint)0 + (nint)309;
					object obj165 = obj164 & 1;
					bool flag48 = obj165 == null;
					num23 = num29;
					Func<object, IComparable> func7 = (Func<object, IComparable>)(object)func6;
					nint num42 = 0;
					func4 = func6;
					if (flag48)
					{
						goto IL_12ab;
					}
					obj113 = obj76;
					func3 = func6;
					goto IL_12ca;
					IL_151d:
					object obj166 = (nint)0 + (nint)309;
					object obj167 = obj166 & 1;
					if (obj167 != null)
					{
						nint num43 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v105 (Il2CppRgctx<ProjectsUtility`1>)+108]");
						object obj168 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v105 (Il2CppRgctx<ProjectsUtility`1>)+108]");
						object obj169 = (nint)0 + (nint)309;
						object obj170 = obj169 & 1;
						bool flag49 = obj170 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v925 @ X8_v105 (Il2CppRgctx<ProjectsUtility`1>)+108]");
						object obj171 = 0;
						if (!flag49)
						{
							goto IL_15bb;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v931 @ X0_v46+C0]");
						object obj172 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v58+108]");
						object obj168 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v58+108]");
						object obj173 = (nint)0 + (nint)309;
						object obj174 = obj173 & 1;
						bool flag50 = obj174 == null;
						object obj175 = !flag50;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v949 @ X8_v58+108]");
						object obj171 = 0;
						if (obj175 != null)
						{
							goto IL_15bb;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X0_v41+E4]");
					bool flag51 = (nint)0 == 0;
					object obj176 = !flag51;
					if (obj176 != null)
					{
						goto IL_15e0;
					}
					goto IL_18f8;
					IL_1a2c:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					num29 = num27;
					goto IL_1a43;
					IL_124b:
					object obj177 = (nint)0 + (nint)309;
					object obj178 = obj177 & 1;
					bool flag52 = obj178 == null;
					object obj179 = !flag52;
					func7 = (Func<object, IComparable>)func2;
					num42 = 0;
					obj113 = obj76;
					func3 = func4;
					if (obj179 == null)
					{
						goto IL_12ab;
					}
					goto IL_12ca;
					IL_15e0:
					object obj180 = (nint)0 + (nint)309;
					object obj181 = obj180 & 1;
					bool flag53 = obj181 == null;
					nint num44 = 0;
					if (!flag53)
					{
						goto IL_161d;
					}
					goto IL_194a;
					IL_15bb:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v972 @ X0_v41+E4]");
					if ((nint)0 != 0)
					{
						goto IL_15e0;
					}
					goto IL_18f8;
					IL_18f8:
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj182 = (nint)0 + (nint)309;
					object obj183 = obj182 & 1;
					bool flag54 = obj183 == null;
					object obj184 = !flag54;
					num44 = 0;
					if (obj184 != null)
					{
						goto IL_161d;
					}
					goto IL_194a;
					IL_12ca:
					nint num45 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DCC894");
					object obj185 = (nint)0 + (nint)309;
					object obj186 = obj185 & 1;
					bool flag55 = obj186 == null;
					object obj187 = !flag55;
					if (obj187 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					}
					break;
					IL_194a:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v993 @ X0_v39+C0]");
					object obj188 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X8_v49+108]");
					obj92 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X8_v49+108]");
					object obj189 = (nint)0 + (nint)309;
					object obj190 = obj189 & 1;
					if (obj190 == null)
					{
						goto IL_168f;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X8_v49+108]");
					obj96 = 0;
					goto IL_169e;
					IL_0fe9:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					method2 = num36;
					goto IL_1000;
				}
				return (List<Project>)(object)Enumerable.ToList(source3);
			}
			enumerator = enumerator4;
			enumerator6 = enumerator7;
			enumerator4 = (List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator)0;
			obj51 = (object)(&enumerator);
			obj14 = obj12;
		}
		goto IL_1dba;
		IL_1dba:
		throw new NullReferenceException();
		IL_0054:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj191 = (nint)0 + (nint)309;
		object obj192 = obj191 & 1;
		bool flag56 = obj192 == null;
		object obj193 = default(object);
		obj12 = obj193;
		num4 = 0;
		obj14 = obj193;
		if (!flag56)
		{
			goto IL_00ab;
		}
		goto IL_0208;
		IL_0208:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v219+C0]");
		object obj194 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v218+8]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31D1F00");
		bool flag57 = obj14 == null;
		obj12 = obj14;
		num5 = unchecked((nint)null);
		enumerator = (List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator)0;
		enumerator2 = (List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator)0;
		num6 = intPtr;
		list3 = cards;
		num7 = intPtr;
		if (!flag57)
		{
			goto IL_0298;
		}
		goto IL_1dba;
		IL_00ab:
		nint num46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v226 (Il2CppRgctx<ProjectsUtility`1>)+8]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31D1F00");
		bool flag58 = obj12 == null;
		object obj195 = !flag58;
		if (obj195 != null)
		{
			goto IL_0298;
		}
		num5 = unchecked((nint)null);
		enumerator = (List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator)0;
		enumerator2 = (List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator)0;
		num6 = intPtr;
		obj14 = obj12;
		list3 = cards;
		goto IL_1dba;
		IL_0298:
		list = (List<ProjectsUtility<System.Int32Enum>.Project>)(typeof(List<AdaptivePerformanceScaler>) + 416);
		obj19 = (nint)0 + (nint)2640;
		obj20 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3280;
		obj51 = (nint)0 + (nint)3368;
		object obj196 = obj12 + 24;
		obj196 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list6 = default(List<object>);
		list6..ctor((IEnumerable<object>)cards);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Comparison<object> comparison = default(Comparison<object>);
		comparison..ctor((object)null, (IntPtr)obj51);
		bool flag59 = list6 == null;
		num5 = unchecked((nint)null);
		enumerator = (List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator)0;
		enumerator2 = (List<KeyValuePair<System.Int32Enum, ProjectConditions>>.Enumerator)0;
		num6 = unchecked((nint)null);
		func = (Func<T, int>)obj51;
		obj15 = null;
		obj14 = obj12;
		list3 = (List<Card>)(object)comparison;
		num7 = intPtr;
		nint num48;
		if (!flag59)
		{
			object obj197 = (nint)0 + (nint)2736;
			object obj198 = (nint)0 + (nint)2728;
			func = (Func<T, int>)obj197;
			list6.Sort(comparison);
			list6.Reverse();
			object obj199 = (nint)0 + (nint)309;
			object obj200 = obj199 & 1;
			if (obj200 != null)
			{
				nint num47 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v214 (Il2CppRgctx<ProjectsUtility`1>)+18]");
				object obj201 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v214 (Il2CppRgctx<ProjectsUtility`1>)+18]");
				object obj202 = (nint)0 + (nint)309;
				object obj203 = obj202 & 1;
				bool flag60 = obj203 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v214 (Il2CppRgctx<ProjectsUtility`1>)+18]");
				object obj204 = 0;
				if (!flag60)
				{
					goto IL_046b;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v160+C0]");
				object obj205 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v169+18]");
				object obj201 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v169+18]");
				object obj206 = (nint)0 + (nint)309;
				object obj207 = obj206 & 1;
				bool flag61 = obj207 == null;
				object obj208 = !flag61;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v169+18]");
				object obj204 = 0;
				if (obj208 != null)
				{
					goto IL_046b;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj209 = (nint)0 + (nint)309;
			object obj210 = obj209 & 1;
			bool flag62 = obj210 == null;
			List<ProjectsUtility<System.Int32Enum>.Project> list7 = default(List<ProjectsUtility<System.Int32Enum>.Project>);
			list2 = list7;
			num48 = 0;
			if (flag62)
			{
				goto IL_04cd;
			}
			list = list7;
			goto IL_04e4;
		}
		goto IL_1dba;
		IL_046b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj211 = (nint)0 + (nint)309;
		object obj212 = obj211 & 1;
		bool flag63 = obj212 == null;
		object obj213 = !flag63;
		List<ProjectsUtility<System.Int32Enum>.Project> list8 = default(List<ProjectsUtility<System.Int32Enum>.Project>);
		list2 = list8;
		num48 = 0;
		list = list8;
		if (obj213 == null)
		{
			goto IL_04cd;
		}
		goto IL_04e4;
	}

	protected static int ProjectsValue(IEnumerable<Project> projects, Func<T, int> valueFunction)
	{
		//IL_000c: Expected O, but got I
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_02cd: Expected O, but got I
		//IL_02dd: Expected O, but got I
		//IL_02f3: Expected O, but got I
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_031b: Expected O, but got I4
		//IL_032b: Expected O, but got I
		//IL_004d: Expected O, but got I
		//IL_0063: Expected O, but got I
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0090: Expected O, but got I
		//IL_0389: Expected O, but got I
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Expected O, but got Unknown
		//IL_03b1: Expected O, but got I4
		//IL_0365: Expected O, but got I4
		//IL_0116: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0159: Expected O, but got I
		//IL_00cf: Expected O, but got I
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_0465: Expected O, but got I
		//IL_0475: Expected O, but got I
		//IL_0497: Expected O, but got I4
		//IL_03df: Expected O, but got I
		//IL_03ef: Expected O, but got I
		//IL_0405: Expected O, but got I
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_042d: Expected O, but got I4
		//IL_043d: Expected O, but got I
		//IL_01c6: Expected O, but got I
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I4
		//IL_0177: Expected O, but got I
		//IL_0187: Expected O, but got I
		//IL_025e: Expected O, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0286: Expected O, but got I4
		//IL_04bf: Expected O, but got I
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Expected O, but got Unknown
		//IL_022e: Expected O, but got I
		//IL_0804: Expected O, but got I
		//IL_0814: Expected O, but got I
		//IL_082a: Expected O, but got I
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Expected O, but got Unknown
		//IL_0852: Expected O, but got I4
		//IL_0862: Expected O, but got I
		//IL_0500: Expected O, but got I
		//IL_0516: Expected O, but got I
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		//IL_0543: Expected O, but got I
		//IL_08c0: Expected O, but got I
		//IL_08c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ce: Expected O, but got Unknown
		//IL_08e8: Expected O, but got I4
		//IL_089c: Expected O, but got I4
		//IL_05c9: Expected O, but got I
		//IL_05df: Expected O, but got I
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ed: Expected O, but got Unknown
		//IL_060c: Expected O, but got I
		//IL_0582: Expected O, but got I
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		//IL_099c: Expected O, but got I
		//IL_09b0: Expected O, but got I
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09be: Expected O, but got Unknown
		//IL_09d8: Expected O, but got I4
		//IL_0916: Expected O, but got I
		//IL_0926: Expected O, but got I
		//IL_093c: Expected O, but got I
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Expected O, but got Unknown
		//IL_0964: Expected O, but got I4
		//IL_0974: Expected O, but got I
		//IL_068d: Expected O, but got I
		//IL_06a3: Expected O, but got I
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b1: Expected O, but got Unknown
		//IL_06d8: Expected O, but got I
		//IL_062a: Expected O, but got I
		//IL_063e: Expected O, but got I
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected O, but got Unknown
		//IL_0a0e: Expected O, but got I
		//IL_0a1e: Expected O, but got I
		//IL_0a34: Expected O, but got I
		//IL_0a3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a42: Expected O, but got Unknown
		//IL_0a5c: Expected O, but got I4
		//IL_0a74: Expected O, but got I
		//IL_0aa7: Expected O, but got I
		//IL_0ab8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abd: Expected O, but got Unknown
		//IL_06fc: Expected O, but got I
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0712: Expected O, but got Unknown
		//IL_072c: Expected O, but got I4
		//IL_0774: Expected O, but got I
		//IL_0784: Expected O, but got I
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a2: Expected O, but got Unknown
		//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Expected O, but got Unknown
		//IL_0b3c: Expected O, but got I4
		//IL_0bb4: Expected O, but got I
		//IL_0bbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc2: Expected O, but got Unknown
		//IL_0db5: Expected O, but got I
		//IL_0dc5: Expected O, but got I
		//IL_0ddb: Expected O, but got I
		//IL_0de4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de9: Expected O, but got Unknown
		//IL_0e03: Expected O, but got I4
		//IL_0e13: Expected O, but got I
		//IL_0c56: Expected O, but got I
		//IL_0c67: Expected O, but got I
		//IL_0c70: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c75: Expected O, but got Unknown
		//IL_0bf5: Expected O, but got I
		//IL_0c0b: Expected O, but got I
		//IL_0c14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c19: Expected O, but got Unknown
		//IL_0c38: Expected O, but got I
		//IL_0ea2: Expected O, but got I
		//IL_0eb2: Expected O, but got I
		//IL_0ec8: Expected O, but got I
		//IL_0ed1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed6: Expected O, but got Unknown
		//IL_0e3b: Expected O, but got I
		//IL_0e4c: Expected O, but got I
		//IL_0e55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5a: Expected O, but got Unknown
		//IL_0e74: Expected O, but got I4
		//IL_0cae: Expected O, but got I
		//IL_0cc4: Expected O, but got I
		//IL_0ccd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd2: Expected O, but got Unknown
		//IL_0cec: Expected O, but got I4
		//IL_0cfc: Expected O, but got I
		//IL_0d2f: Expected O, but got I
		//IL_0d45: Expected O, but got I
		//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d53: Expected O, but got Unknown
		//IL_0f03: Expected O, but got I
		//IL_0d8e: Expected O, but got I
		object obj = (nint)0 + (nint)309;
		object obj2 = obj & 1;
		if (obj2 != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v122 (Il2CppRgctx<ProjectsUtility`1>)+108]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v122 (Il2CppRgctx<ProjectsUtility`1>)+108]");
			object obj4 = (nint)0 + (nint)309;
			object obj5 = obj4 & 1;
			bool flag = obj5 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v122 (Il2CppRgctx<ProjectsUtility`1>)+108]");
			object obj6 = 0;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X0_v75+C0]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v98+108]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v98+108]");
			object obj8 = (nint)0 + (nint)309;
			object obj9 = obj8 & 1;
			bool flag2 = obj9 == null;
			object obj10 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v98+108]");
			object obj6 = 0;
			if (obj10 != null)
			{
				goto IL_009e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v70+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 != null)
		{
			goto IL_00c3;
		}
		goto IL_0373;
		IL_0c46:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X0_v22+B8]");
		object obj12 = 0;
		object obj13 = (nint)0 + (nint)309;
		object obj14 = obj13 & 1;
		bool flag4 = obj14 == null;
		nint num2 = 0;
		if (!flag4)
		{
			goto IL_0c98;
		}
		goto IL_0e88;
		IL_0d19:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v14+B8]");
		object obj15 = (nint)0 + (nint)16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj16 = (nint)0 + (nint)309;
		object obj17 = obj16 & 1;
		bool flag5 = obj17 == null;
		Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum> func2;
		Func<T, int> func = (Func<T, int>)(object)func2;
		nint num3 = 0;
		if (flag5)
		{
			goto IL_0214;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v7 (Il2CppRgctx<ProjectsUtility`1>)+118]");
		object obj18 = 0;
		Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum> selector = func2;
		goto IL_023b;
		IL_023b:
		nint num4 = 0;
		IEnumerable<System.Int32Enum> enumerable = Enumerable.Select((IEnumerable<ProjectsUtility<System.Int32Enum>.Project>)projects, selector);
		object obj19 = (nint)0 + (nint)309;
		object obj20 = obj19 & 1;
		bool flag6 = obj20 == null;
		object obj21 = !flag6;
		IEnumerable<System.Int32Enum> source = enumerable;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			source = enumerable;
		}
		return Enumerable.Sum(source, (Func<System.Int32Enum, int>)(object)valueFunction);
		IL_009e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v70+E4]");
		if ((nint)0 != 0)
		{
			goto IL_00c3;
		}
		goto IL_0373;
		IL_0373:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj22 = (nint)0 + (nint)309;
		object obj23 = obj22 & 1;
		bool flag7 = obj23 == null;
		object obj24 = !flag7;
		nint num5 = 0;
		if (obj24 != null)
		{
			goto IL_0100;
		}
		goto IL_03c5;
		IL_00c3:
		object obj25 = (nint)0 + (nint)309;
		object obj26 = obj25 & 1;
		bool flag8 = obj26 == null;
		num5 = 0;
		if (!flag8)
		{
			goto IL_0100;
		}
		goto IL_03c5;
		IL_03c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v68+C0]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v90+108]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v90+108]");
		object obj29 = (nint)0 + (nint)309;
		object obj30 = obj29 & 1;
		bool flag9 = obj30 == null;
		object obj31 = !flag9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v90+108]");
		object obj32 = 0;
		if (obj31 != null)
		{
			goto IL_0167;
		}
		goto IL_044b;
		IL_0100:
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v114 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v114 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		object obj33 = (nint)0 + (nint)309;
		object obj34 = obj33 & 1;
		bool flag10 = obj34 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v114 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		obj32 = 0;
		if (!flag10)
		{
			goto IL_0167;
		}
		goto IL_044b;
		IL_044b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v65+B8]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v88+10]");
		func2 = (Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v88+10]");
		bool flag11 = (nint)0 == 0;
		object obj36 = !flag11;
		num3 = 0;
		nint num7 = 0;
		if (obj36 != null)
		{
			goto IL_01b8;
		}
		goto IL_04b1;
		IL_0167:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v88+B8]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v112+10]");
		func2 = (Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v112+10]");
		bool flag12 = (nint)0 == 0;
		num3 = 0;
		num7 = 0;
		if (!flag12)
		{
			goto IL_01b8;
		}
		goto IL_04b1;
		IL_04b1:
		object obj38 = num7 + 309;
		object obj39 = obj38 & 1;
		if (obj39 != null)
		{
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v84 (Il2CppRgctx<ProjectsUtility`1>)+108]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v84 (Il2CppRgctx<ProjectsUtility`1>)+108]");
			object obj41 = (nint)0 + (nint)309;
			object obj42 = obj41 & 1;
			bool flag13 = obj42 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v84 (Il2CppRgctx<ProjectsUtility`1>)+108]");
			object obj43 = 0;
			if (!flag13)
			{
				goto IL_0551;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v46+C0]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v59+108]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v59+108]");
			object obj45 = (nint)0 + (nint)309;
			object obj46 = obj45 & 1;
			bool flag14 = obj46 == null;
			object obj47 = !flag14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v59+108]");
			object obj43 = 0;
			if (obj47 != null)
			{
				goto IL_0551;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v41+E4]");
		bool flag15 = (nint)0 == 0;
		object obj48 = !flag15;
		if (obj48 != null)
		{
			goto IL_0576;
		}
		goto IL_08aa;
		IL_0c98:
		nint num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v27 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v27 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		object obj50 = (nint)0 + (nint)309;
		object obj51 = obj50 & 1;
		bool flag16 = obj51 == null;
		object obj52 = !flag16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v27 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		object obj53 = 0;
		if (obj52 == null)
		{
			goto IL_0d0a;
		}
		goto IL_0d19;
		IL_0214:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v7 (Il2CppRgctx<ProjectsUtility`1>)+118]");
		obj18 = 0;
		selector = func2;
		goto IL_023b;
		IL_0e88:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v7+C0]");
		object obj54 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v11+108]");
		obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v11+108]");
		object obj55 = (nint)0 + (nint)309;
		object obj56 = obj55 & 1;
		if (obj56 == null)
		{
			goto IL_0d0a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v11+108]");
		obj53 = 0;
		goto IL_0d19;
		IL_0551:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v41+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0576;
		}
		goto IL_08aa;
		IL_08aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj57 = (nint)0 + (nint)309;
		object obj58 = obj57 & 1;
		bool flag17 = obj58 == null;
		object obj59 = !flag17;
		nint num10 = 0;
		if (obj59 != null)
		{
			goto IL_05b3;
		}
		goto IL_08fc;
		IL_0576:
		object obj60 = (nint)0 + (nint)309;
		object obj61 = obj60 & 1;
		bool flag18 = obj61 == null;
		num10 = 0;
		if (!flag18)
		{
			goto IL_05b3;
		}
		goto IL_08fc;
		IL_08fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v39+C0]");
		object obj62 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v51+108]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v51+108]");
		object obj64 = (nint)0 + (nint)309;
		object obj65 = obj64 & 1;
		bool flag19 = obj65 == null;
		object obj66 = !flag19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v51+108]");
		object obj67 = 0;
		if (obj66 != null)
		{
			goto IL_061a;
		}
		goto IL_0982;
		IL_05b3:
		nint num11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v76 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v76 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		object obj68 = (nint)0 + (nint)309;
		object obj69 = obj68 & 1;
		bool flag20 = obj69 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v76 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		obj67 = 0;
		if (!flag20)
		{
			goto IL_061a;
		}
		goto IL_0982;
		IL_0982:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v36+B8]");
		object obj70 = 0;
		object obj71 = obj70;
		object obj72 = (nint)0 + (nint)309;
		object obj73 = obj72 & 1;
		bool flag21 = obj73 == null;
		object obj74 = !flag21;
		object obj75 = obj70;
		nint num12 = 0;
		if (obj74 != null)
		{
			goto IL_0677;
		}
		goto IL_09f4;
		IL_061a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v56+B8]");
		object obj76 = 0;
		obj71 = obj76;
		object obj77 = (nint)0 + (nint)309;
		object obj78 = obj77 & 1;
		bool flag22 = obj78 == null;
		obj75 = obj76;
		num12 = 0;
		if (!flag22)
		{
			goto IL_0677;
		}
		goto IL_09f4;
		IL_09f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v33+C0]");
		object obj79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v43+100]");
		object obj80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v43+100]");
		object obj81 = (nint)0 + (nint)309;
		object obj82 = obj81 & 1;
		bool flag23 = obj82 == null;
		object obj83 = !flag23;
		obj71 = obj75;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v43+100]");
		object obj84 = 0;
		if (obj83 != null)
		{
			goto IL_06e6;
		}
		goto IL_0a82;
		IL_0677:
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v68 (Il2CppRgctx<ProjectsUtility`1>)+100]");
		obj80 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v68 (Il2CppRgctx<ProjectsUtility`1>)+100]");
		object obj85 = (nint)0 + (nint)309;
		object obj86 = obj85 & 1;
		bool flag24 = obj86 == null;
		obj75 = obj71;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v68 (Il2CppRgctx<ProjectsUtility`1>)+100]");
		obj84 = 0;
		if (!flag24)
		{
			goto IL_06e6;
		}
		goto IL_0a82;
		IL_0a82:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj87 = (nint)0 + (nint)309;
		object obj88 = obj87;
		object obj89 = obj87 & 1;
		bool flag25 = obj89 == null;
		obj71 = obj75;
		Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum> func4 = default(Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum>);
		Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum> func3 = func4;
		nint num14 = 0;
		func2 = func4;
		nint num15 = 0;
		if (flag25)
		{
			goto IL_075e;
		}
		goto IL_0afe;
		IL_06e6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj90 = (nint)0 + (nint)309;
		obj88 = obj90;
		object obj91 = obj90 & 1;
		bool flag26 = obj91 == null;
		object obj92 = !flag26;
		Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum> func5 = default(Func<ProjectsUtility<System.Int32Enum>.Project, System.Int32Enum>);
		func3 = func5;
		num14 = 0;
		obj75 = obj71;
		func2 = func5;
		num15 = 0;
		if (obj92 == null)
		{
			goto IL_075e;
		}
		goto IL_0afe;
		IL_0afe:
		nint num16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v39 (Il2CppRgctx<ProjectsUtility`1>)+138]");
		nint num17 = 0;
		object obj93 = obj88 & 1;
		bool flag27 = obj93 == null;
		object obj94 = !flag27;
		obj71 = obj75;
		func3 = func2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v39 (Il2CppRgctx<ProjectsUtility`1>)+138]");
		nint method = 0;
		if (obj94 == null)
		{
			goto IL_0b6a;
		}
		goto IL_0b91;
		IL_075e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		object obj95 = (nint)0 + (nint)309;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X0_v49+C0]");
		object obj96 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v64+138]");
		num17 = 0;
		object obj97 = obj95 & 1;
		bool flag28 = obj97 == null;
		num15 = 0;
		if (flag28)
		{
			goto IL_0b6a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v64+138]");
		method = 0;
		obj75 = obj71;
		func2 = func3;
		goto IL_0b91;
		IL_0b6a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		method = num17;
		obj75 = obj71;
		func2 = func3;
		goto IL_0b91;
		IL_0d0a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0d19;
		IL_0b91:
		nint num18 = 0;
		func2..ctor(obj75, (IntPtr)method);
		object obj98 = (nint)0 + (nint)309;
		object obj99 = obj98 & 1;
		if (obj99 != null)
		{
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v34 (Il2CppRgctx<ProjectsUtility`1>)+108]");
			object obj100 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v34 (Il2CppRgctx<ProjectsUtility`1>)+108]");
			object obj101 = (nint)0 + (nint)309;
			object obj102 = obj101 & 1;
			bool flag29 = obj102 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v34 (Il2CppRgctx<ProjectsUtility`1>)+108]");
			object obj103 = 0;
			if (!flag29)
			{
				goto IL_0c46;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X0_v12+C0]");
			object obj104 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v18+108]");
			object obj100 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v18+108]");
			object obj105 = (nint)0 + (nint)309;
			object obj106 = obj105 & 1;
			bool flag30 = obj106 == null;
			object obj107 = !flag30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v18+108]");
			object obj103 = 0;
			if (obj107 != null)
			{
				goto IL_0c46;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v10+B8]");
		object obj108 = 0;
		object obj109 = (nint)0 + (nint)309;
		object obj110 = obj109 & 1;
		bool flag31 = obj110 == null;
		object obj111 = !flag31;
		num2 = 0;
		if (obj111 != null)
		{
			goto IL_0c98;
		}
		goto IL_0e88;
		IL_01b8:
		object obj112 = num3 + 309;
		object obj113 = obj112 & 1;
		bool flag32 = obj113 == null;
		object obj114 = !flag32;
		func = valueFunction;
		object obj115 = default(object);
		obj18 = obj115;
		selector = func2;
		if (obj114 == null)
		{
			goto IL_0214;
		}
		goto IL_023b;
	}

	private static bool MutuallyExclusive(IEnumerable<Project> projects)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_02fa: Expected O, but got I
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0322: Expected O, but got I4
		//IL_008f: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00d2: Expected O, but got I
		//IL_0048: Expected O, but got I
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_03e8: Expected O, but got I4
		//IL_0350: Expected O, but got I
		//IL_0360: Expected O, but got I
		//IL_0376: Expected O, but got I
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_039e: Expected O, but got I4
		//IL_03ae: Expected O, but got I
		//IL_0111: Expected O, but got I
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0462: Expected O, but got I
		//IL_0472: Expected O, but got I
		//IL_0488: Expected O, but got I
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected O, but got Unknown
		//IL_04b0: Expected O, but got I4
		//IL_04c0: Expected O, but got I
		//IL_040c: Expected O, but got I
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_0434: Expected O, but got I4
		//IL_01b9: Expected O, but got I
		//IL_01c9: Expected O, but got I
		//IL_0158: Expected O, but got I
		//IL_016e: Expected O, but got I
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_019b: Expected O, but got I
		//IL_0542: Expected O, but got I
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		//IL_04e8: Expected O, but got I
		//IL_04f8: Expected O, but got I
		//IL_051a: Expected O, but got I4
		//IL_0887: Expected O, but got I
		//IL_0897: Expected O, but got I
		//IL_08ad: Expected O, but got I
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected O, but got Unknown
		//IL_08d5: Expected O, but got I4
		//IL_08e5: Expected O, but got I
		//IL_0209: Expected O, but got I
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0231: Expected O, but got I4
		//IL_0583: Expected O, but got I
		//IL_0599: Expected O, but got I
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a7: Expected O, but got Unknown
		//IL_05c6: Expected O, but got I
		//IL_0943: Expected O, but got I
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0951: Expected O, but got Unknown
		//IL_096b: Expected O, but got I4
		//IL_091f: Expected O, but got I4
		//IL_064c: Expected O, but got I
		//IL_0662: Expected O, but got I
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0670: Expected O, but got Unknown
		//IL_068f: Expected O, but got I
		//IL_0605: Expected O, but got I
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0613: Expected O, but got Unknown
		//IL_0f83: Expected I4, but got O
		//IL_0a1f: Expected O, but got I
		//IL_0a33: Expected O, but got I
		//IL_0a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a41: Expected O, but got Unknown
		//IL_0a5b: Expected O, but got I4
		//IL_0999: Expected O, but got I
		//IL_09a9: Expected O, but got I
		//IL_09bf: Expected O, but got I
		//IL_09c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected O, but got Unknown
		//IL_09e7: Expected O, but got I4
		//IL_09f7: Expected O, but got I
		//IL_0710: Expected O, but got I
		//IL_0726: Expected O, but got I
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		//IL_075b: Expected O, but got I
		//IL_06ad: Expected O, but got I
		//IL_06c1: Expected O, but got I
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected O, but got Unknown
		//IL_02d4: Expected O, but got I4
		//IL_0a91: Expected O, but got I
		//IL_0aa1: Expected O, but got I
		//IL_0ab7: Expected O, but got I
		//IL_0ac0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac5: Expected O, but got Unknown
		//IL_0adf: Expected O, but got I4
		//IL_0af7: Expected O, but got I
		//IL_0b2a: Expected O, but got I
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b40: Expected O, but got Unknown
		//IL_077f: Expected O, but got I
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Expected O, but got Unknown
		//IL_07af: Expected O, but got I4
		//IL_07f7: Expected O, but got I
		//IL_0807: Expected O, but got I
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Expected O, but got Unknown
		//IL_0ba0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba5: Expected O, but got Unknown
		//IL_0bbf: Expected O, but got I4
		//IL_0c37: Expected O, but got I
		//IL_0c40: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c45: Expected O, but got Unknown
		//IL_0e22: Expected O, but got I
		//IL_0e32: Expected O, but got I
		//IL_0e48: Expected O, but got I
		//IL_0e51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e56: Expected O, but got Unknown
		//IL_0e70: Expected O, but got I4
		//IL_0e80: Expected O, but got I
		//IL_0cd9: Expected O, but got I
		//IL_0cea: Expected O, but got I
		//IL_0cf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Expected O, but got Unknown
		//IL_0c78: Expected O, but got I
		//IL_0c8e: Expected O, but got I
		//IL_0c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9c: Expected O, but got Unknown
		//IL_0cbb: Expected O, but got I
		//IL_0f0f: Expected O, but got I
		//IL_0f1f: Expected O, but got I
		//IL_0f35: Expected O, but got I
		//IL_0f3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f43: Expected O, but got Unknown
		//IL_0ea8: Expected O, but got I
		//IL_0eb9: Expected O, but got I
		//IL_0ec2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec7: Expected O, but got Unknown
		//IL_0ee1: Expected O, but got I4
		//IL_0d31: Expected O, but got I
		//IL_0d47: Expected O, but got I
		//IL_0d50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d55: Expected O, but got Unknown
		//IL_0d6f: Expected O, but got I4
		//IL_0d7f: Expected O, but got I
		//IL_0db2: Expected O, but got I
		//IL_0dc9: Expected O, but got I
		//IL_0dd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd7: Expected O, but got Unknown
		//IL_0f70: Expected O, but got I
		object obj = 152965120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E15D8]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = (nint)0 + (nint)309;
			object obj4 = obj3 & 1;
			bool flag = obj4 == null;
			nint num = 0;
			if (!flag)
			{
				goto IL_0079;
			}
		}
		else
		{
			_ = 1;
			object obj5 = (nint)0 + (nint)309;
			object obj6 = obj5 & 1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			nint num = 0;
			if (obj7 != null)
			{
				goto IL_0079;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v75+C0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v98+108]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v98+108]");
		object obj10 = (nint)0 + (nint)309;
		object obj11 = obj10 & 1;
		bool flag3 = obj11 == null;
		object obj12 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v98+108]");
		object obj13 = 0;
		if (obj12 != null)
		{
			goto IL_00e0;
		}
		goto IL_03bc;
		IL_0cc9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v451 @ X0_v21+B8]");
		object obj14 = 0;
		object obj15 = (nint)0 + (nint)309;
		object obj16 = obj15 & 1;
		bool flag4 = obj16 == null;
		nint num2 = 0;
		if (!flag4)
		{
			goto IL_0d1b;
		}
		goto IL_0ef5;
		IL_0d9c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X0_v13+B8]");
		object obj17 = (nint)0 + (nint)24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj18 = (nint)0 + (nint)309;
		object obj19 = obj18 & 1;
		bool flag5 = obj19 == null;
		nint num3 = 0;
		if (flag5)
		{
			goto IL_0248;
		}
		Func<ProjectsUtility<System.Int32Enum>.Project, object> func;
		Func<ProjectsUtility<System.Int32Enum>.Project, IEnumerable<object>> selector = (Func<ProjectsUtility<System.Int32Enum>.Project, IEnumerable<object>>)func;
		goto IL_0260;
		IL_0260:
		IEnumerable<object> source = Enumerable.SelectMany((IEnumerable<ProjectsUtility<System.Int32Enum>.Project>)projects, selector);
		List<object> list = Enumerable.ToList(source);
		if (list != null)
		{
			IEnumerable<object> source2 = Enumerable.Distinct(list);
			int num4 = Enumerable.Count(source2);
			object obj20 = list._size - num4;
			return obj20 == null;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0079:
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v125 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v125 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		object obj21 = (nint)0 + (nint)309;
		object obj22 = obj21 & 1;
		bool flag6 = obj22 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v125 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		obj13 = 0;
		if (!flag6)
		{
			goto IL_00e0;
		}
		goto IL_03bc;
		IL_03bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v69+E4]");
		bool flag7 = (nint)0 == 0;
		object obj23 = !flag7;
		if (obj23 != null)
		{
			goto IL_0105;
		}
		goto IL_03f6;
		IL_00e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v69+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0105;
		}
		goto IL_03f6;
		IL_03f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj24 = (nint)0 + (nint)309;
		object obj25 = obj24 & 1;
		bool flag8 = obj25 == null;
		object obj26 = !flag8;
		nint num6 = 0;
		if (obj26 != null)
		{
			goto IL_0142;
		}
		goto IL_0448;
		IL_0105:
		object obj27 = (nint)0 + (nint)309;
		object obj28 = obj27 & 1;
		bool flag9 = obj28 == null;
		num6 = 0;
		if (!flag9)
		{
			goto IL_0142;
		}
		goto IL_0448;
		IL_0448:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v67+C0]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v89+108]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v89+108]");
		object obj31 = (nint)0 + (nint)309;
		object obj32 = obj31 & 1;
		bool flag10 = obj32 == null;
		object obj33 = !flag10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v89+108]");
		object obj34 = 0;
		if (obj33 != null)
		{
			goto IL_01a9;
		}
		goto IL_04ce;
		IL_0142:
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v116 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v116 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		object obj35 = (nint)0 + (nint)309;
		object obj36 = obj35 & 1;
		bool flag11 = obj36 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v116 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		obj34 = 0;
		if (!flag11)
		{
			goto IL_01a9;
		}
		goto IL_04ce;
		IL_04ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v64+B8]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v87+18]");
		func = (Func<ProjectsUtility<System.Int32Enum>.Project, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v87+18]");
		bool flag12 = (nint)0 == 0;
		object obj38 = !flag12;
		num3 = 0;
		nint num8 = 0;
		if (obj38 != null)
		{
			goto IL_01fa;
		}
		goto IL_0534;
		IL_01a9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v102+B8]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v114+18]");
		func = (Func<ProjectsUtility<System.Int32Enum>.Project, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X8_v114+18]");
		bool flag13 = (nint)0 == 0;
		num3 = 0;
		num8 = 0;
		if (!flag13)
		{
			goto IL_01fa;
		}
		goto IL_0534;
		IL_0534:
		object obj40 = num8 + 309;
		object obj41 = obj40 & 1;
		if (obj41 != null)
		{
			nint num9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v83 (Il2CppRgctx<ProjectsUtility`1>)+108]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v83 (Il2CppRgctx<ProjectsUtility`1>)+108]");
			object obj43 = (nint)0 + (nint)309;
			object obj44 = obj43 & 1;
			bool flag14 = obj44 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v83 (Il2CppRgctx<ProjectsUtility`1>)+108]");
			object obj45 = 0;
			if (!flag14)
			{
				goto IL_05d4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v45+C0]");
			object obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v58+108]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v58+108]");
			object obj47 = (nint)0 + (nint)309;
			object obj48 = obj47 & 1;
			bool flag15 = obj48 == null;
			object obj49 = !flag15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v58+108]");
			object obj45 = 0;
			if (obj49 != null)
			{
				goto IL_05d4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v40+E4]");
		bool flag16 = (nint)0 == 0;
		object obj50 = !flag16;
		if (obj50 != null)
		{
			goto IL_05f9;
		}
		goto IL_092d;
		IL_0d1b:
		nint num10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v26 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v26 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		object obj52 = (nint)0 + (nint)309;
		object obj53 = obj52 & 1;
		bool flag17 = obj53 == null;
		object obj54 = !flag17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v26 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		object obj55 = 0;
		if (obj54 == null)
		{
			goto IL_0d8d;
		}
		goto IL_0d9c;
		IL_0248:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		selector = (Func<ProjectsUtility<System.Int32Enum>.Project, IEnumerable<object>>)func;
		goto IL_0260;
		IL_0ef5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X0_v6+C0]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v10+108]");
		obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v10+108]");
		object obj57 = (nint)0 + (nint)309;
		object obj58 = obj57 & 1;
		if (obj58 == null)
		{
			goto IL_0d8d;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v10+108]");
		obj55 = 0;
		goto IL_0d9c;
		IL_05d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v40+E4]");
		if ((nint)0 != 0)
		{
			goto IL_05f9;
		}
		goto IL_092d;
		IL_092d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj59 = (nint)0 + (nint)309;
		object obj60 = obj59 & 1;
		bool flag18 = obj60 == null;
		object obj61 = !flag18;
		nint num11 = 0;
		if (obj61 != null)
		{
			goto IL_0636;
		}
		goto IL_097f;
		IL_05f9:
		object obj62 = (nint)0 + (nint)309;
		object obj63 = obj62 & 1;
		bool flag19 = obj63 == null;
		num11 = 0;
		if (!flag19)
		{
			goto IL_0636;
		}
		goto IL_097f;
		IL_097f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v38+C0]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v50+108]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v50+108]");
		object obj66 = (nint)0 + (nint)309;
		object obj67 = obj66 & 1;
		bool flag20 = obj67 == null;
		object obj68 = !flag20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v50+108]");
		object obj69 = 0;
		if (obj68 != null)
		{
			goto IL_069d;
		}
		goto IL_0a05;
		IL_0636:
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v75 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v75 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		object obj70 = (nint)0 + (nint)309;
		object obj71 = obj70 & 1;
		bool flag21 = obj71 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v75 (Il2CppRgctx<ProjectsUtility`1>)+108]");
		obj69 = 0;
		if (!flag21)
		{
			goto IL_069d;
		}
		goto IL_0a05;
		IL_0a05:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v35+B8]");
		object obj72 = 0;
		object obj73 = obj72;
		object obj74 = (nint)0 + (nint)309;
		object obj75 = obj74 & 1;
		bool flag22 = obj75 == null;
		object obj76 = !flag22;
		object obj77 = obj72;
		nint num13 = 0;
		if (obj76 != null)
		{
			goto IL_06fa;
		}
		goto IL_0a77;
		IL_069d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v55+B8]");
		object obj78 = 0;
		obj73 = obj78;
		object obj79 = (nint)0 + (nint)309;
		object obj80 = obj79 & 1;
		bool flag23 = obj80 == null;
		obj77 = obj78;
		num13 = 0;
		if (!flag23)
		{
			goto IL_06fa;
		}
		goto IL_0a77;
		IL_0a77:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v32+C0]");
		object obj81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v42+158]");
		object obj82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v42+158]");
		object obj83 = (nint)0 + (nint)309;
		object obj84 = obj83 & 1;
		bool flag24 = obj84 == null;
		object obj85 = !flag24;
		obj73 = obj77;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v42+158]");
		object obj86 = 0;
		if (obj85 != null)
		{
			goto IL_0769;
		}
		goto IL_0b05;
		IL_06fa:
		nint num14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v67 (Il2CppRgctx<ProjectsUtility`1>)+158]");
		obj82 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v67 (Il2CppRgctx<ProjectsUtility`1>)+158]");
		object obj87 = (nint)0 + (nint)309;
		object obj88 = obj87 & 1;
		bool flag25 = obj88 == null;
		obj77 = obj73;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v67 (Il2CppRgctx<ProjectsUtility`1>)+158]");
		obj86 = 0;
		if (!flag25)
		{
			goto IL_0769;
		}
		goto IL_0b05;
		IL_0b05:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj89 = (nint)0 + (nint)309;
		object obj90 = obj89;
		object obj91 = obj89 & 1;
		bool flag26 = obj91 == null;
		obj73 = obj77;
		nint num15 = 0;
		Func<ProjectsUtility<System.Int32Enum>.Project, object> func3 = default(Func<ProjectsUtility<System.Int32Enum>.Project, object>);
		Func<ProjectsUtility<System.Int32Enum>.Project, object> func2 = func3;
		nint num16 = 0;
		func = func3;
		if (flag26)
		{
			goto IL_07e1;
		}
		goto IL_0b81;
		IL_0769:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj92 = (nint)0 + (nint)309;
		obj90 = obj92;
		object obj93 = obj92 & 1;
		bool flag27 = obj93 == null;
		object obj94 = !flag27;
		num15 = 0;
		Func<ProjectsUtility<System.Int32Enum>.Project, object> func4 = default(Func<ProjectsUtility<System.Int32Enum>.Project, object>);
		func2 = func4;
		obj77 = obj73;
		num16 = 0;
		func = func4;
		if (obj94 == null)
		{
			goto IL_07e1;
		}
		goto IL_0b81;
		IL_0b81:
		nint num17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v38 (Il2CppRgctx<ProjectsUtility`1>)+160]");
		nint num18 = 0;
		object obj95 = obj90 & 1;
		bool flag28 = obj95 == null;
		object obj96 = !flag28;
		obj73 = obj77;
		func2 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v38 (Il2CppRgctx<ProjectsUtility`1>)+160]");
		nint method = 0;
		if (obj96 == null)
		{
			goto IL_0bed;
		}
		goto IL_0c14;
		IL_07e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		object obj97 = (nint)0 + (nint)309;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X0_v48+C0]");
		object obj98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v63+160]");
		num18 = 0;
		object obj99 = obj97 & 1;
		bool flag29 = obj99 == null;
		num16 = 0;
		if (flag29)
		{
			goto IL_0bed;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v63+160]");
		method = 0;
		obj77 = obj73;
		func = func2;
		goto IL_0c14;
		IL_0bed:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		method = num18;
		obj77 = obj73;
		func = func2;
		goto IL_0c14;
		IL_0d8d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0d9c;
		IL_0c14:
		nint num19 = 0;
		func..ctor(obj77, (IntPtr)method);
		object obj100 = (nint)0 + (nint)309;
		object obj101 = obj100 & 1;
		if (obj101 != null)
		{
			nint num20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v33 (Il2CppRgctx<ProjectsUtility`1>)+108]");
			object obj102 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v33 (Il2CppRgctx<ProjectsUtility`1>)+108]");
			object obj103 = (nint)0 + (nint)309;
			object obj104 = obj103 & 1;
			bool flag30 = obj104 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v33 (Il2CppRgctx<ProjectsUtility`1>)+108]");
			object obj105 = 0;
			if (!flag30)
			{
				goto IL_0cc9;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v450 @ X0_v11+C0]");
			object obj106 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v17+108]");
			object obj102 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v17+108]");
			object obj107 = (nint)0 + (nint)309;
			object obj108 = obj107 & 1;
			bool flag31 = obj108 == null;
			object obj109 = !flag31;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v17+108]");
			object obj105 = 0;
			if (obj109 != null)
			{
				goto IL_0cc9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v9+B8]");
		object obj110 = 0;
		object obj111 = (nint)0 + (nint)309;
		object obj112 = obj111 & 1;
		bool flag32 = obj112 == null;
		object obj113 = !flag32;
		num2 = 0;
		if (obj113 != null)
		{
			goto IL_0d1b;
		}
		goto IL_0ef5;
		IL_01fa:
		object obj114 = num3 + 309;
		object obj115 = obj114 & 1;
		bool flag33 = obj115 == null;
		object obj116 = !flag33;
		selector = (Func<ProjectsUtility<System.Int32Enum>.Project, IEnumerable<object>>)func;
		if (obj116 == null)
		{
			goto IL_0248;
		}
		goto IL_0260;
	}

	private static bool CheckProject(List<Card> cards, ProjectConditions conditions, out List<List<Card>> projectCards)
	{
		//IL_00b6: Expected O, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00de: Expected O, but got I4
		//IL_0037: Expected O, but got I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_005b: Expected O, but got I
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0193: Expected I4, but got O
		ProjectConditions projectConditions = default(ProjectConditions);
		if ((nint)projectConditions != 1)
		{
			bool flag = (object)projectConditions == null;
			object obj = !flag;
			if (obj == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
				object obj2 = (nint)0 + (nint)309;
				object obj3 = obj2 & 1;
				bool flag2 = obj3 == null;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39D99D8");
				bool result = default(bool);
				return result;
			}
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 2256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = "ThisIsFakeReceiptData" + 2840;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			string paramName = default(string);
			object actualValue = default(object);
			ex..ctor(paramName, actualValue, null);
			OutOfMemoryException ex2 = new OutOfMemoryException();
			return (byte)(int)ex2 != 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj8 = (nint)0 + (nint)309;
		object obj9 = obj8 & 1;
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39DAA40");
		bool result2 = default(bool);
		return result2;
	}

	private unsafe static bool CheckRankSequence(List<Card> cards, ProjectConditions conditions, out List<List<Card>> projectCards)
	{
		//IL_0016: Expected O, but got I
		//IL_0242: Expected O, but got I
		//IL_0258: Expected O, but got I
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0280: Expected O, but got I4
		//IL_0289: Expected O, but got I4
		//IL_0292: Expected O, but got I4
		//IL_02a2: Expected O, but got I
		//IL_02ab: Expected O, but got I4
		//IL_02b4: Expected O, but got I4
		//IL_00c8: Expected O, but got I
		//IL_00d8: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_011b: Expected O, but got I
		//IL_0043: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_007f: Expected O, but got I4
		//IL_0088: Expected O, but got I4
		//IL_0098: Expected O, but got I
		//IL_00a1: Expected O, but got I4
		//IL_00aa: Expected O, but got I4
		//IL_02dc: Expected O, but got I
		//IL_02ec: Expected O, but got I
		//IL_0302: Expected O, but got I
		//IL_030b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_032a: Expected O, but got I4
		//IL_033a: Expected O, but got I
		//IL_0371: Expected O, but got I
		//IL_0387: Expected O, but got I
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected O, but got Unknown
		//IL_03af: Expected O, but got I4
		//IL_03cf: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_0159: Expected O, but got I
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0196: Expected O, but got I
		//IL_01b4: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_01e8: Expected O, but got I4
		//IL_03f7: Expected O, but got I
		//IL_0407: Expected O, but got I
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_048c: Expected O, but got I
		//IL_04b0: Expected O, but got I
		//IL_04c6: Expected O, but got I
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_04ee: Expected O, but got I4
		//IL_043d: Expected O, but got I
		//IL_0446: Expected O, but got I4
		//IL_051b: Expected O, but got I
		//IL_0206: Expected O, but got I
		//IL_020f: Expected O, but got I4
		//IL_055a: Expected O, but got I
		//IL_0570: Expected O, but got I
		//IL_0579: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		//IL_0e72: Expected O, but got I
		//IL_0e82: Expected O, but got I
		//IL_0e98: Expected O, but got I
		//IL_0ea1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea6: Expected O, but got Unknown
		//IL_0ec0: Expected O, but got I4
		//IL_0ed0: Expected O, but got I
		//IL_05ab: Expected O, but got I
		//IL_05bb: Expected O, but got I
		//IL_05d1: Expected O, but got I
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05df: Expected O, but got Unknown
		//IL_05fe: Expected O, but got I
		//IL_0f32: Expected O, but got I
		//IL_0f48: Expected O, but got I
		//IL_0f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f56: Expected O, but got Unknown
		//IL_0f70: Expected O, but got I4
		//IL_0f80: Expected O, but got I
		//IL_0f0a: Expected O, but got I4
		//IL_06a2: Expected O, but got I
		//IL_06b2: Expected O, but got I
		//IL_06c8: Expected O, but got I
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d6: Expected O, but got Unknown
		//IL_06f0: Expected O, but got I4
		//IL_0710: Expected O, but got I
		//IL_0641: Expected O, but got I
		//IL_0657: Expected O, but got I
		//IL_0660: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_0684: Expected O, but got I
		//IL_0750: Unknown result type (might be due to invalid IL or missing references)
		//IL_0755: Expected O, but got Unknown
		//IL_0765: Expected O, but got I
		//IL_0775: Expected O, but got I
		//IL_0797: Expected O, but got I4
		//IL_07a0: Expected O, but got I4
		//IL_0fa8: Expected O, but got I
		//IL_0fb8: Expected O, but got I
		//IL_0fce: Expected O, but got I
		//IL_0fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdc: Expected O, but got Unknown
		//IL_0c48: Expected O, but got I
		//IL_0c57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5c: Expected O, but got Unknown
		//IL_0c68: Expected O, but got I
		//IL_0c98: Expected O, but got I
		//IL_0cae: Expected O, but got I
		//IL_0cb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Expected O, but got Unknown
		//IL_0cd6: Expected O, but got I4
		//IL_07be: Expected O, but got I
		//IL_07d4: Expected O, but got I
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e2: Expected O, but got Unknown
		//IL_1019: Expected O, but got I
		//IL_0d03: Expected O, but got I
		//IL_2d71: Expected O, but got I
		//IL_2d81: Expected O, but got I
		//IL_2d97: Expected O, but got I
		//IL_2da0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2da5: Expected O, but got Unknown
		//IL_2dbf: Expected O, but got I4
		//IL_2dcf: Expected O, but got I
		//IL_080f: Expected O, but got I
		//IL_081f: Expected O, but got I
		//IL_0835: Expected O, but got I
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0843: Expected O, but got Unknown
		//IL_0862: Expected O, but got I
		//IL_0d6e: Expected I, but got O
		//IL_2e31: Expected O, but got I
		//IL_2e47: Expected O, but got I
		//IL_2e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e55: Expected O, but got Unknown
		//IL_2e6f: Expected O, but got I4
		//IL_2e7f: Expected O, but got I
		//IL_2e09: Expected O, but got I4
		//IL_0906: Expected O, but got I
		//IL_0916: Expected O, but got I
		//IL_092c: Expected O, but got I
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093a: Expected O, but got Unknown
		//IL_0954: Expected O, but got I4
		//IL_0964: Expected O, but got I
		//IL_08a5: Expected O, but got I
		//IL_08bb: Expected O, but got I
		//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c9: Expected O, but got Unknown
		//IL_08e8: Expected O, but got I
		//IL_0d9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da0: Expected O, but got Unknown
		//IL_0da8: Expected I, but got O
		//IL_0db8: Expected O, but got I
		//IL_0991: Expected O, but got I
		//IL_09a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a5: Expected O, but got Unknown
		//IL_09bf: Expected O, but got I
		//IL_09d5: Expected O, but got I
		//IL_09de: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e3: Expected O, but got Unknown
		//IL_09fd: Expected O, but got I4
		//IL_2ea7: Expected O, but got I
		//IL_2eb7: Expected O, but got I
		//IL_2ecd: Expected O, but got I
		//IL_2ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2edb: Expected O, but got Unknown
		//IL_0a2a: Expected O, but got I
		//IL_0a53: Expected O, but got I
		//IL_0a69: Expected O, but got I
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a77: Expected O, but got Unknown
		//IL_36d4: Expected O, but got I
		//IL_36f2: Expected I, but got O
		//IL_2f27: Expected O, but got I
		//IL_2f37: Expected O, but got I
		//IL_2f4d: Expected O, but got I
		//IL_2f56: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f5b: Expected O, but got Unknown
		//IL_2f75: Expected O, but got I4
		//IL_2f85: Expected O, but got I
		//IL_2f08: Expected O, but got I
		//IL_36a0: Expected O, but got I
		//IL_0b15: Expected O, but got I
		//IL_0b2a: Expected O, but got I
		//IL_0b40: Expected O, but got I
		//IL_0b49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4e: Expected O, but got Unknown
		//IL_0b6d: Expected O, but got I
		//IL_0aa4: Expected O, but got I
		//IL_0ab4: Expected O, but got I
		//IL_0aca: Expected O, but got I
		//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad8: Expected O, but got Unknown
		//IL_0af7: Expected O, but got I
		//IL_354c: Expected O, but got Ref
		//IL_3555: Expected O, but got I4
		//IL_1067: Unknown result type (might be due to invalid IL or missing references)
		//IL_106c: Expected O, but got Unknown
		//IL_1087: Unknown result type (might be due to invalid IL or missing references)
		//IL_108c: Expected O, but got Unknown
		//IL_1098: Expected O, but got I
		//IL_10c5: Expected I, but got O
		//IL_102b: Expected O, but got I4
		//IL_103d: Expected O, but got I
		//IL_1046: Unknown result type (might be due to invalid IL or missing references)
		//IL_104b: Expected O, but got Unknown
		//IL_3038: Expected O, but got I
		//IL_3048: Expected O, but got I
		//IL_305e: Expected O, but got I
		//IL_3067: Unknown result type (might be due to invalid IL or missing references)
		//IL_306c: Expected O, but got Unknown
		//IL_2fad: Expected O, but got I
		//IL_2fc2: Expected O, but got I
		//IL_2fd8: Expected O, but got I
		//IL_2fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fe6: Expected O, but got Unknown
		//IL_3000: Expected O, but got I4
		//IL_3010: Expected O, but got I
		//IL_11c4: Expected O, but got I
		//IL_0e1c: Expected O, but got I
		//IL_0b8b: Expected O, but got I
		//IL_0b9b: Expected O, but got I
		//IL_0bb1: Expected O, but got I
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbf: Expected O, but got Unknown
		//IL_0bd9: Expected O, but got I4
		//IL_0be9: Expected O, but got I
		//IL_0c1c: Expected O, but got I
		//IL_0c2f: Expected O, but got I4
		//IL_3099: Expected O, but got I
		//IL_374c: Expected O, but got I
		//IL_2109: Expected O, but got Ref
		//IL_212b: Expected O, but got I4
		//IL_213b: Expected O, but got Ref
		//IL_2144: Expected O, but got I4
		//IL_218d: Expected O, but got I4
		//IL_2196: Expected O, but got I4
		//IL_21a7: Expected O, but got I4
		//IL_3718: Expected O, but got I
		//IL_2356: Unknown result type (might be due to invalid IL or missing references)
		//IL_235b: Expected O, but got Unknown
		//IL_2373: Expected O, but got I
		//IL_1271: Expected O, but got I4
		//IL_127e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1283: Expected O, but got Unknown
		//IL_128c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1291: Expected O, but got Unknown
		//IL_21c5: Expected O, but got Ref
		//IL_21ce: Expected O, but got I4
		//IL_21f7: Expected O, but got I4
		//IL_2200: Expected O, but got I4
		//IL_2211: Expected O, but got I4
		//IL_343d: Expected O, but got I4
		//IL_1228: Expected O, but got I
		//IL_3b54: Expected O, but got I
		//IL_3a8a: Expected O, but got I4
		//IL_12ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cf: Expected O, but got Unknown
		//IL_12e7: Expected O, but got I
		//IL_3b20: Expected O, but got I
		//IL_2420: Expected O, but got I4
		//IL_242d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2432: Expected O, but got Unknown
		//IL_243b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2440: Expected O, but got Unknown
		//IL_37bd: Expected O, but got I
		//IL_37de: Unknown result type (might be due to invalid IL or missing references)
		//IL_37e3: Expected O, but got Unknown
		//IL_37f9: Expected O, but got I
		//IL_23d7: Expected O, but got I
		//IL_24aa: Expected O, but got I
		//IL_24c0: Expected O, but got I
		//IL_24c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_24ce: Expected O, but got Unknown
		//IL_3783: Expected O, but got I
		//IL_2bbb: Expected O, but got I
		//IL_2bcb: Expected O, but got I
		//IL_2be1: Expected O, but got I
		//IL_2bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bef: Expected O, but got Unknown
		//IL_2c09: Expected O, but got I4
		//IL_2c19: Expected O, but got I
		//IL_248c: Expected O, but got I4
		//IL_3494: Expected O, but got I4
		//IL_1394: Expected O, but got I4
		//IL_13a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a6: Expected O, but got Unknown
		//IL_13af: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b4: Expected O, but got Unknown
		//IL_24fb: Expected O, but got I
		//IL_250b: Expected O, but got I
		//IL_2521: Expected O, but got I
		//IL_252a: Unknown result type (might be due to invalid IL or missing references)
		//IL_252f: Expected O, but got Unknown
		//IL_254e: Expected O, but got I
		//IL_13ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f2: Expected O, but got Unknown
		//IL_13fa: Expected I, but got O
		//IL_140a: Expected O, but got I
		//IL_134b: Expected O, but got I
		//IL_35bb: Expected O, but got I4
		//IL_35d4: Expected O, but got I4
		//IL_2c7b: Expected O, but got I
		//IL_2c91: Expected O, but got I
		//IL_2c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c9f: Expected O, but got Unknown
		//IL_2cb9: Expected O, but got I4
		//IL_2cc9: Expected O, but got I
		//IL_2c53: Expected O, but got I4
		//IL_25f2: Expected O, but got I
		//IL_2602: Expected O, but got I
		//IL_2618: Expected O, but got I
		//IL_2621: Unknown result type (might be due to invalid IL or missing references)
		//IL_2626: Expected O, but got Unknown
		//IL_2640: Expected O, but got I4
		//IL_2650: Expected O, but got I
		//IL_2591: Expected O, but got I
		//IL_25a7: Expected O, but got I
		//IL_25b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_25b5: Expected O, but got Unknown
		//IL_25d4: Expected O, but got I
		//IL_3857: Expected O, but got I
		//IL_387b: Expected O, but got I4
		//IL_366b: Expected O, but got I4
		//IL_2679: Expected O, but got I
		//IL_268b: Expected O, but got I
		//IL_269b: Expected O, but got I
		//IL_26bd: Expected O, but got I4
		//IL_2cf1: Expected O, but got I
		//IL_2d01: Expected O, but got I
		//IL_2d17: Expected O, but got I
		//IL_2d20: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d25: Expected O, but got Unknown
		//IL_163d: Expected O, but got I
		//IL_3823: Expected O, but got I
		//IL_14f5: Expected O, but got Ref
		//IL_14fe: Expected O, but got I4
		//IL_152f: Expected O, but got I4
		//IL_14b7: Expected O, but got I4
		//IL_14c9: Expected O, but got I
		//IL_14d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d7: Expected O, but got Unknown
		//IL_2b80: Expected I, but got O
		//IL_2b93: Expected O, but got I
		//IL_26db: Expected O, but got I
		//IL_26f1: Expected O, but got I
		//IL_26fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ff: Expected O, but got Unknown
		//IL_2d52: Expected O, but got I
		//IL_3905: Expected O, but got I
		//IL_146e: Expected O, but got I
		//IL_30b8: Expected O, but got I
		//IL_30c8: Expected O, but got I
		//IL_30de: Expected O, but got I
		//IL_30e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_30ec: Expected O, but got Unknown
		//IL_3106: Expected O, but got I4
		//IL_3116: Expected O, but got I
		//IL_38d1: Expected O, but got I
		//IL_272c: Expected O, but got I
		//IL_273c: Expected O, but got I
		//IL_2752: Expected O, but got I
		//IL_275b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2760: Expected O, but got Unknown
		//IL_277f: Expected O, but got I
		//IL_16ea: Expected O, but got I4
		//IL_16f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fc: Expected O, but got Unknown
		//IL_1705: Unknown result type (might be due to invalid IL or missing references)
		//IL_170a: Expected O, but got Unknown
		//IL_3178: Expected O, but got I
		//IL_318e: Expected O, but got I
		//IL_3197: Unknown result type (might be due to invalid IL or missing references)
		//IL_319c: Expected O, but got Unknown
		//IL_31b6: Expected O, but got I4
		//IL_31c6: Expected O, but got I
		//IL_3150: Expected O, but got I4
		//IL_34b2: Expected O, but got Ref
		//IL_34bb: Expected O, but got I4
		//IL_34cc: Expected O, but got I4
		//IL_34d1: Expected I, but got O
		//IL_1d05: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d0a: Expected O, but got Unknown
		//IL_1d22: Expected O, but got I
		//IL_20da: Expected O, but got Ref
		//IL_20e3: Expected O, but got I4
		//IL_20f4: Expected O, but got I4
		//IL_16a1: Expected O, but got I
		//IL_2823: Expected O, but got I
		//IL_2833: Expected O, but got I
		//IL_2849: Expected O, but got I
		//IL_2852: Unknown result type (might be due to invalid IL or missing references)
		//IL_2857: Expected O, but got Unknown
		//IL_2871: Expected O, but got I4
		//IL_2881: Expected O, but got I
		//IL_27c2: Expected O, but got I
		//IL_27d8: Expected O, but got I
		//IL_27e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e6: Expected O, but got Unknown
		//IL_2805: Expected O, but got I
		//IL_1743: Unknown result type (might be due to invalid IL or missing references)
		//IL_1748: Expected O, but got Unknown
		//IL_1760: Expected O, but got I
		//IL_28ae: Expected O, but got I
		//IL_28bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_28c2: Expected O, but got Unknown
		//IL_28dc: Expected O, but got I
		//IL_28f2: Expected O, but got I
		//IL_28fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2900: Expected O, but got Unknown
		//IL_291a: Expected O, but got I4
		//IL_31ee: Expected O, but got I
		//IL_31fe: Expected O, but got I
		//IL_3214: Expected O, but got I
		//IL_321d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3222: Expected O, but got Unknown
		//IL_3a52: Expected O, but got I
		//IL_2947: Expected O, but got I
		//IL_2970: Expected O, but got I
		//IL_2986: Expected O, but got I
		//IL_298f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2994: Expected O, but got Unknown
		//IL_3a1e: Expected O, but got I
		//IL_3970: Expected O, but got I
		//IL_326e: Expected O, but got I
		//IL_327e: Expected O, but got I
		//IL_3294: Expected O, but got I
		//IL_329d: Unknown result type (might be due to invalid IL or missing references)
		//IL_32a2: Expected O, but got Unknown
		//IL_32bc: Expected O, but got I4
		//IL_32cc: Expected O, but got I
		//IL_324f: Expected O, but got I
		//IL_1dcf: Expected O, but got I4
		//IL_1ddc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de1: Expected O, but got Unknown
		//IL_1dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1def: Expected O, but got Unknown
		//IL_2062: Expected O, but got Ref
		//IL_206b: Expected O, but got I4
		//IL_2084: Expected O, but got I4
		//IL_393c: Expected O, but got I
		//IL_2a32: Expected O, but got I
		//IL_2a47: Expected O, but got I
		//IL_2a5d: Expected O, but got I
		//IL_2a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a6b: Expected O, but got Unknown
		//IL_2a8a: Expected O, but got I
		//IL_29c1: Expected O, but got I
		//IL_29d1: Expected O, but got I
		//IL_29e7: Expected O, but got I
		//IL_29f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_29f5: Expected O, but got Unknown
		//IL_2a14: Expected O, but got I
		//IL_1d86: Expected O, but got I
		//IL_186d: Expected O, but got I
		//IL_180d: Expected O, but got I4
		//IL_181a: Unknown result type (might be due to invalid IL or missing references)
		//IL_181f: Expected O, but got Unknown
		//IL_1828: Unknown result type (might be due to invalid IL or missing references)
		//IL_182d: Expected O, but got Unknown
		//IL_337f: Expected O, but got I
		//IL_338f: Expected O, but got I
		//IL_33a5: Expected O, but got I
		//IL_33ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_33b3: Expected O, but got Unknown
		//IL_32f4: Expected O, but got I
		//IL_3309: Expected O, but got I
		//IL_331f: Expected O, but got I
		//IL_3328: Unknown result type (might be due to invalid IL or missing references)
		//IL_332d: Expected O, but got Unknown
		//IL_3347: Expected O, but got I4
		//IL_3357: Expected O, but got I
		//IL_17c4: Expected O, but got I
		//IL_2aa8: Expected O, but got I
		//IL_2ab8: Expected O, but got I
		//IL_2ace: Expected O, but got I
		//IL_2ad7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2adc: Expected O, but got Unknown
		//IL_2af6: Expected O, but got I4
		//IL_2b06: Expected O, but got I
		//IL_20a2: Expected O, but got Ref
		//IL_20ab: Expected O, but got I4
		//IL_20bc: Expected O, but got I4
		//IL_1887: Expected O, but got I
		//IL_2b39: Expected O, but got I
		//IL_2b48: Expected I, but got O
		//IL_33e0: Expected O, but got I
		//IL_1a37: Expected O, but got I
		//IL_202a: Expected O, but got Ref
		//IL_2033: Expected O, but got I4
		//IL_2044: Expected O, but got I4
		//IL_1fea: Expected O, but got Ref
		//IL_1ff3: Expected O, but got I4
		//IL_200c: Expected O, but got I4
		//IL_1a77: Expected O, but got I
		//IL_1a8e: Expected O, but got Ref
		//IL_1acb: Expected O, but got I4
		//IL_1ad3: Expected I4, but got O
		//IL_399f: Expected I4, but got O
		//IL_39fb: Expected O, but got I4
		//IL_1940: Expected O, but got I4
		//IL_1960: Expected O, but got I4
		//IL_1c99: Expected O, but got Ref
		//IL_1ca2: Expected O, but got I4
		//IL_1cb2: Expected O, but got I
		//IL_1cbb: Expected O, but got I4
		//IL_1ccc: Expected O, but got I4
		//IL_1b9a: Expected O, but got I4
		//IL_1c0d: Expected I4, but got O
		//IL_1c47: Expected O, but got I4
		//IL_19ea: Expected O, but got I
		//IL_19a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a5: Expected O, but got Unknown
		//IL_19ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b3: Expected O, but got Unknown
		//IL_154c: Expected O, but got I
		//IL_155c: Expected O, but got I
		//IL_1b67: Expected I, but got O
		//IL_15a5: Expected O, but got I
		//IL_15ae: Expected O, but got I4
		//IL_15ce: Expected O, but got I4
		//IL_15e6: Expected O, but got I
		//IL_15ef: Expected O, but got I4
		//IL_1bcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd0: Expected O, but got Unknown
		//IL_1bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bde: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E15D9]");
		object obj = (nint)0 & (nint)1;
		object obj5;
		object obj6;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
			object obj3 = (nint)0 + (nint)309;
			object obj4 = obj3 & 1;
			bool flag = obj4 == null;
			obj5 = 0;
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
			object obj7 = 0;
			obj5 = 0;
			obj6 = 0;
			if (!flag)
			{
				goto IL_00b8;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
			object obj8 = (nint)0 + (nint)309;
			object obj9 = obj8 & 1;
			bool flag2 = obj9 == null;
			object obj10 = !flag2;
			obj5 = 0;
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
			object obj7 = 0;
			obj5 = 0;
			obj6 = 0;
			if (obj10 != null)
			{
				goto IL_00b8;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v292+C0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v310+188]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v310+188]");
		object obj13 = (nint)0 + (nint)309;
		object obj14 = obj13 & 1;
		bool flag3 = obj14 == null;
		object obj15 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v310+188]");
		object obj16 = 0;
		if (obj15 != null)
		{
			goto IL_0129;
		}
		goto IL_0348;
		IL_1c88:
		NullReferenceException ex = new NullReferenceException();
		object obj17 = (object)(&obj6);
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2103 @ X0_v178 (System.Object)+10]");
		object obj19 = 0;
		object obj20 = -1;
		IntPtr intPtr;
		nint num = intPtr;
		object obj21 = -1;
		nint num3;
		nint num2 = num3;
		goto IL_3543;
		IL_1fd9:
		NullReferenceException ex2 = new NullReferenceException();
		obj17 = (object)(&obj6);
		obj18 = 0;
		Card[] array2;
		Card[] array = array2;
		List<object> list;
		object obj22 = list;
		obj21 = -1;
		num2 = num3;
		goto IL_3543;
		IL_3b44:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X0_v93+8]");
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v856 @ X0_v93] (should have been resolved before IL gen)");
		object obj23 = obj17;
		object obj25;
		object obj24 = obj25;
		object obj26 = obj19;
		object obj27 = obj20;
		object obj29 = default(object);
		object obj28 = obj29;
		object obj31;
		object obj30 = obj31;
		int num5 = default(int);
		int num4 = num5;
		object obj33;
		object obj32 = obj33;
		object obj35;
		object obj34 = obj35;
		IntPtr intPtr2;
		nint num6 = intPtr2;
		nint num7 = num;
		object obj37;
		object obj36 = obj37;
		object obj38 = obj21;
		List<Card> list3;
		List<Card> list2 = list3;
		object obj40;
		object obj39 = obj40;
		num3 = num2;
		object obj42;
		object obj41 = obj42;
		goto IL_3a70;
		IL_00b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v387+C0]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v322+188]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v322+188]");
		object obj44 = (nint)0 + (nint)309;
		object obj45 = obj44 & 1;
		bool flag4 = obj45 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v322+188]");
		obj16 = 0;
		if (!flag4)
		{
			goto IL_0129;
		}
		goto IL_0348;
		IL_0348:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj47 = (nint)0 + (nint)309;
		object obj48 = obj47 & 1;
		bool flag5 = obj48 == null;
		object obj49 = !flag5;
		object obj51 = default(object);
		object obj50 = obj51;
		object obj52 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj53 = 0;
		if (obj49 != null)
		{
			goto IL_01a4;
		}
		goto IL_03dd;
		IL_0129:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj54 = (nint)0 + (nint)309;
		object obj55 = obj54 & 1;
		bool flag6 = obj55 == null;
		object obj56 = default(object);
		obj50 = obj56;
		obj52 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj53 = 0;
		if (!flag6)
		{
			goto IL_01a4;
		}
		goto IL_03dd;
		IL_03dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v285+C0]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v305+190]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31E8E00");
		bool flag7 = obj52 == null;
		obj50 = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v305+190]");
		obj22 = 0;
		obj21 = 152965120;
		list3 = cards;
		num2 = num;
		object obj59 = default(object);
		obj42 = obj59;
		if (!flag7)
		{
			goto IL_046c;
		}
		goto IL_3685;
		IL_01a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X0_v382+C0]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v317+190]");
		obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31E8E00");
		bool flag8 = obj50 == null;
		object obj61 = !flag8;
		if (obj61 != null)
		{
			goto IL_046c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v317+190]");
		obj22 = 0;
		obj21 = 152965120;
		list3 = cards;
		num2 = num;
		obj42 = obj59;
		goto IL_3685;
		IL_046c:
		object obj62 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
		object obj63 = (nint)0 + (nint)3280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj65 = (nint)0 + (nint)309;
		object obj66 = obj65 & 1;
		bool flag9 = obj66 == null;
		object obj67 = !flag9;
		if (obj67 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v103+C0]");
		object obj68 = 0;
		object obj69 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X8_v110+198]");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj69, (IntPtr)0);
		IEnumerable<object> source = Enumerable.Where(cards, func);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj70 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj71 = (nint)0 + (nint)309;
		object obj72 = obj71 & 1;
		if (obj72 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X0_v107+C0]");
			object obj73 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v301+108]");
			object obj74 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v301+108]");
			object obj75 = (nint)0 + (nint)309;
			object obj76 = obj75 & 1;
			bool flag10 = obj76 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v301+108]");
			object obj77 = 0;
			if (!flag10)
			{
				goto IL_060c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X0_v116+C0]");
			object obj78 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v122+108]");
			object obj74 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v122+108]");
			object obj79 = (nint)0 + (nint)309;
			object obj80 = obj79 & 1;
			bool flag11 = obj80 == null;
			object obj81 = !flag11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v122+108]");
			object obj77 = 0;
			if (obj81 != null)
			{
				goto IL_060c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v111+E4]");
		bool flag12 = (nint)0 == 0;
		object obj82 = !flag12;
		if (obj82 != null)
		{
			goto IL_0631;
		}
		goto IL_0f18;
		IL_0e44:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		ref List<List<Card>> reference = ref *(List<List<Card>>*)null;
		goto IL_36c4;
		IL_36c4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ X0_v131+8]");
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1225 @ X0_v131] (should have been resolved before IL gen)");
		object obj83 = default(object);
		bool flag13 = obj83 == null;
		num = unchecked((nint)null);
		obj42 = obj59;
		object obj84;
		ref List<List<Card>> reference2;
		if (!flag13)
		{
			obj42 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			num3 = (nint)0 + (nint)1624;
			obj84 = typeof(System.Buffers.Text.ParserHelpers) + 3136;
			obj31 = (nint)0 + (nint)2648;
			obj23 = obj17;
			obj26 = obj19;
			obj27 = obj20;
			obj28 = obj29;
			num4 = num5;
			num7 = unchecked((nint)null);
			reference2 = ref reference;
			object obj85 = obj83;
			object obj86 = obj85;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1369 @ X8_v140+12E]");
			array = (Card[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1369 @ X8_v140+12E]");
			if ((nint)0 == 0)
			{
				goto IL_1250;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1369 @ X8_v140+B0]");
			int num8 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1606 @ X10_v57 (System.Int32)-8]");
				obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1606 @ X10_v57 (System.Int32)-8]");
				if (0 == (nint)obj42)
				{
					break;
				}
				num4 = num8 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1369 @ X8_v140+12E]");
				array = (Card[])(-1);
				bool flag14 = (nint)array != 1;
				num8 = num4;
				if (flag14)
				{
					continue;
				}
				goto IL_1250;
			}
			array = (Card[])((int*)num8)->m_value;
			object obj87 = obj86 + ((int*)num8)->m_value;
			object obj88 = obj87 + 312;
			num4 = num8;
			goto IL_373c;
		}
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_3543;
		IL_3847:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1848 @ X0_v149+8]");
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1848 @ X0_v149] (should have been resolved before IL gen)");
		object obj89 = default(object);
		bool flag15 = obj89 == null;
		object obj90 = !flag15;
		obj19 = obj26;
		obj20 = obj27;
		obj29 = obj28;
		num5 = num4;
		num = num7;
		reference2 = ref reference;
		object obj91 = obj89;
		List<object> list4 = default(List<object>);
		List<object> list5 = default(List<object>);
		bool flag23 = default(bool);
		if (obj90 != null)
		{
			object obj100 = default(object);
			object obj103 = default(object);
			object obj104 = default(object);
			while (true)
			{
				object obj92 = obj91;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1897 @ X8_v162+12E]");
				array = (Card[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1897 @ X8_v162+12E]");
				if ((nint)0 == 0)
				{
					goto IL_16c9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1897 @ X8_v162+B0]");
				int num9 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1939 @ X10_v41 (System.Int32)-8]");
					obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1939 @ X10_v41 (System.Int32)-8]");
					if (0 == (nint)obj42)
					{
						break;
					}
					num5 = num9 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1897 @ X8_v162+12E]");
					array = (Card[])(-1);
					bool flag16 = (nint)array != 1;
					num9 = num5;
					if (flag16)
					{
						continue;
					}
					goto IL_16c9;
				}
				array = (Card[])((int*)num9)->m_value;
				object obj93 = obj92 + ((int*)num9)->m_value;
				object obj94 = obj93 + 312;
				num5 = num9;
				goto IL_38f5;
				IL_17ec:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				reference2 = ref *(List<List<Card>>*)null;
				goto IL_3960;
				IL_3960:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2100 @ X0_v176+8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2100 @ X0_v176] (should have been resolved before IL gen)");
				if (list4 != null)
				{
					int size = list4._size;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X22_v11 (System.Object)+1C]");
					bool flag17 = (nint)size < (nint)0;
					array = array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X22_v11 (System.Object)+1C]");
					obj22 = 0;
					if (flag17)
					{
						goto IL_1a12;
					}
					object obj95 = (nint)0 + (nint)800;
					reference = ref *(List<List<Card>>*)obj95;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X22_v11 (System.Object)+1C]");
					IEnumerable<object> source2 = Enumerable.Take(list4, 0);
					list = Enumerable.ToList(source2);
					if (list5 != null)
					{
						int version = ((List<Card>)(object)list5)._version + 1;
						((List<Card>)(object)list5)._version = version;
						array2 = ((List<Card>)(object)list5)._items;
						if (((List<Card>)(object)list5)._items != null)
						{
							num5 = ((List<Card>)(object)list5)._size;
							obj29 = array2.Length;
							bool flag18 = ((List<Card>)(object)list5)._size < array2.Length;
							object obj96 = !flag18;
							if (obj96 == null)
							{
								int size2 = ((List<Card>)(object)list5)._size + 1;
								((List<Card>)(object)list5)._size = size2;
								object obj97 = ((List<Card>)(object)list5)._items + ((List<Card>)(object)list5)._size;
								object obj98 = obj97 + 32;
								obj98 = list;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							}
							else
							{
								list5.AddWithResize((object)list);
							}
							object obj99 = (nint)0 + (nint)2712;
							reference2 = ref *(List<List<Card>>*)obj99;
							list4.RemoveAt(0);
							array = array2;
							obj22 = null;
							goto IL_1a12;
						}
					}
					goto IL_1fd9;
				}
				goto IL_2051;
				IL_1a12:
				object obj102;
				int num10;
				int num13;
				object[] items;
				if (obj100 != null)
				{
					obj22 = num3;
					object obj101 = Enumerable.Last(list4);
					if (obj101 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2173 @ X0_v183 (System.Object)+10]");
						obj102 = -1;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						bool flag19 = ((Enum)(&obj103)).Equals(obj104);
						num10 = list4._size;
						int version2 = list4._version;
						bool flag20 = !flag19;
						object obj105 = !flag20;
						int num11 = (int)obj104;
						if (obj105 == null)
						{
							int num12 = list4._version + 1;
							list4._size = 0;
							list4._version = num12;
							if (list4._size < 1)
							{
								num13 = (int)obj31;
								int version3 = num12 + 1;
								list4._version = version3;
								bool flag21 = list4._items == null;
								object obj106 = !flag21;
								num10 = 0;
								items = list4._items;
								array = (Card[])obj31;
								intPtr = num;
								reference = ref *(List<List<Card>>*)null;
								obj22 = obj104;
								if (obj106 != null)
								{
									goto IL_1b75;
								}
								goto IL_1c88;
							}
							Array.Clear(list4._items, 0, num10);
							num10 = list4._size;
							version2 = list4._version;
							num = unchecked((nint)null);
							num11 = 0;
						}
						num13 = (int)obj31;
						int version4 = version2 + 1;
						list4._version = version4;
						items = list4._items;
						bool flag22 = list4._items == null;
						array = (Card[])obj31;
						intPtr = num;
						reference = ref *(List<List<Card>>*)num10;
						obj22 = num11;
						if (!flag22)
						{
							goto IL_1b75;
						}
						goto IL_1c88;
					}
					goto IL_2019;
				}
				goto IL_2091;
				IL_16c9:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				reference2 = ref *(List<List<Card>>*)null;
				goto IL_38f5;
				IL_38f5:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1954 @ X0_v153+8]");
				obj22 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1954 @ X0_v153] (should have been resolved before IL gen)");
				if (!flag23)
				{
					break;
				}
				if (obj6 == null)
				{
					goto IL_20c9;
				}
				object obj107 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 352;
				object obj108 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ X8_v188+12E]");
				array2 = (Card[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ X8_v188+12E]");
				if ((nint)0 == 0)
				{
					goto IL_17ec;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ X8_v188+B0]");
				int num14 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2061 @ X10_v36 (System.Int32)-8]");
					obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2061 @ X10_v36 (System.Int32)-8]");
					if (0 == (nint)obj107)
					{
						break;
					}
					num5 = num14 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1964 @ X8_v188+12E]");
					array2 = (Card[])(-1);
					bool flag24 = (nint)array2 != 1;
					num14 = num5;
					if (flag24)
					{
						continue;
					}
					goto IL_17ec;
				}
				array2 = (Card[])((int*)num14)->m_value;
				object obj109 = obj108 + ((int*)num14)->m_value;
				object obj110 = obj109 + 312;
				num5 = num14;
				goto IL_3960;
				IL_1b75:
				num4 = items.Length;
				bool flag25 = num10 < items.Length;
				object obj111 = !flag25;
				if (obj111 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1869 @ X9_v44 (System.Int32)+20]");
					object obj112 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2280 @ X8_v203+C0]");
					object obj113 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2281 @ X8_v204+70]");
					reference = ref *(List<List<Card>>*)null;
					list4.AddWithResize(obj100);
					obj22 = obj100;
				}
				else
				{
					num13 = (list4._size = num10 + 1);
					object obj114 = items + num10;
					object obj115 = obj114 + 32;
					obj115 = obj100;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					reference = ref *(List<List<Card>>*)num10;
					obj22 = obj100;
				}
				bool flag26 = obj6 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2103 @ X0_v178 (System.Object)+10]");
				obj26 = 0;
				obj27 = -1;
				obj103 = obj84;
				object obj116 = obj102;
				obj28 = obj29;
				array = (Card[])num13;
				num7 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2103 @ X0_v178 (System.Object)+10]");
				obj19 = 0;
				obj20 = -1;
				obj103 = obj84;
				obj116 = obj102;
				num5 = num4;
				reference2 = ref reference;
				obj91 = obj6;
				if (!flag26)
				{
					continue;
				}
				goto IL_14e4;
			}
			if (obj6 != null)
			{
				object obj117 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj118 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1970 @ X8_v182+12E]");
				array = (Card[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1970 @ X8_v182+12E]");
				if ((nint)0 == 0)
				{
					goto IL_1dae;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1970 @ X8_v182+B0]");
				int num15 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2082 @ X10_v27 (System.Int32)-8]");
					obj29 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2082 @ X10_v27 (System.Int32)-8]");
					if (0 == (nint)obj117)
					{
						break;
					}
					num5 = num15 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1970 @ X8_v182+12E]");
					array = (Card[])(-1);
					bool flag27 = (nint)array != 1;
					num15 = num5;
					if (flag27)
					{
						continue;
					}
					goto IL_1dae;
				}
				array = (Card[])((int*)num15)->m_value;
				object obj119 = obj118 + ((int*)num15)->m_value;
				object obj120 = obj119 + 312;
				num5 = num15;
				goto IL_3a42;
			}
			goto IL_34a1;
		}
		goto IL_14e4;
		IL_14e4:
		NullReferenceException ex4 = new NullReferenceException();
		obj17 = (object)(&obj6);
		obj18 = 0;
		obj19 = obj26;
		obj20 = obj27;
		obj29 = obj28;
		num5 = num4;
		num = num7;
		obj21 = -1;
		num2 = num3;
		goto IL_3543;
		IL_3685:
		throw new NullReferenceException();
		IL_060c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v111+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0631;
		}
		goto IL_0f18;
		IL_0f18:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj121 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj122 = (nint)0 + (nint)309;
		object obj123 = obj122 & 1;
		bool flag28 = obj123 == null;
		object obj124 = !flag28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj125 = 0;
		if (obj124 != null)
		{
			goto IL_0692;
		}
		goto IL_0f8e;
		IL_0631:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj121 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj126 = (nint)0 + (nint)309;
		object obj127 = obj126 & 1;
		bool flag29 = obj127 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj125 = 0;
		if (!flag29)
		{
			goto IL_0692;
		}
		goto IL_0f8e;
		IL_0f8e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v109+C0]");
		object obj128 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v114+108]");
		object obj129 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v114+108]");
		object obj130 = (nint)0 + (nint)309;
		object obj131 = obj130 & 1;
		bool flag30 = obj131 == null;
		IntPtr intPtr3 = num;
		if (flag30)
		{
			goto IL_071e;
		}
		intPtr2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v114+108]");
		object obj132 = 0;
		goto IL_0735;
		IL_2091:
		NullReferenceException ex5 = new NullReferenceException();
		obj17 = (object)(&obj6);
		obj18 = 0;
		reference = ref reference2;
		obj21 = -1;
		num2 = num3;
		goto IL_3543;
		IL_0692:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v277+C0]");
		object obj133 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v293+108]");
		obj129 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v293+108]");
		object obj134 = (nint)0 + (nint)309;
		object obj135 = obj134 & 1;
		bool flag31 = obj135 == null;
		object obj136 = !flag31;
		intPtr3 = num;
		intPtr2 = num;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X8_v293+108]");
		obj132 = 0;
		if (obj136 == null)
		{
			goto IL_071e;
		}
		goto IL_0735;
		IL_071e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		intPtr2 = intPtr3;
		goto IL_0735;
		IL_0735:
		num2 = (nint)0 + (nint)2944;
		obj21 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3384;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v118+B8]");
		object obj137 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v126+20]");
		Func<object, System.Int32Enum> keySelector = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X8_v126+20]");
		bool flag32 = (nint)0 == 0;
		object obj138 = !flag32;
		object obj139 = 0;
		if (obj138 != null)
		{
			goto IL_0c3c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj140 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj141 = (nint)0 + (nint)309;
		object obj142 = obj141 & 1;
		if (obj142 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v230+C0]");
			object obj143 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v288+108]");
			object obj144 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v288+108]");
			object obj145 = (nint)0 + (nint)309;
			object obj146 = obj145 & 1;
			bool flag33 = obj146 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v288+108]");
			object obj147 = 0;
			if (!flag33)
			{
				goto IL_0870;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X0_v239+C0]");
			object obj148 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X8_v241+108]");
			object obj144 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X8_v241+108]");
			object obj149 = (nint)0 + (nint)309;
			object obj150 = obj149 & 1;
			bool flag34 = obj150 == null;
			object obj151 = !flag34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v830 @ X8_v241+108]");
			object obj147 = 0;
			if (obj151 != null)
			{
				goto IL_0870;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X0_v234+E4]");
		bool flag35 = (nint)0 == 0;
		object obj152 = !flag35;
		if (obj152 != null)
		{
			goto IL_0895;
		}
		goto IL_2e17;
		IL_34a1:
		OutOfMemoryException ex6 = new OutOfMemoryException();
		obj17 = (object)(&obj6);
		obj18 = 0;
		reference = ref reference2;
		obj21 = -1;
		num2 = unchecked((nint)null);
		goto IL_3543;
		IL_1496:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		reference = ref *(List<List<Card>>*)null;
		goto IL_3847;
		IL_373c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1626 @ X0_v138+8]");
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1626 @ X0_v138] (should have been resolved before IL gen)");
		if (flag23)
		{
			if (obj5 != null)
			{
				object obj153 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 4072;
				object obj154 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ X8_v146+12E]");
				array = (Card[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ X8_v146+12E]");
				if ((nint)0 == 0)
				{
					goto IL_1373;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ X8_v146+B0]");
				int num16 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1730 @ X10_v52 (System.Int32)-8]");
					obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1730 @ X10_v52 (System.Int32)-8]");
					if (0 == (nint)obj153)
					{
						break;
					}
					num4 = num16 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1647 @ X8_v146+12E]");
					array = (Card[])(-1);
					bool flag36 = (nint)array != 1;
					num16 = num4;
					if (flag36)
					{
						continue;
					}
					goto IL_1373;
				}
				array = (Card[])((int*)num16)->m_value;
				object obj155 = obj154 + ((int*)num16)->m_value;
				object obj156 = obj155 + 312;
				num4 = num16;
				goto IL_37a7;
			}
			NullReferenceException ex7 = new NullReferenceException();
			obj17 = obj23;
			obj19 = obj26;
			obj20 = obj27;
			obj29 = obj28;
			num5 = num4;
			num = num7;
			reference = ref reference2;
			obj21 = -1;
			num2 = num3;
			goto IL_3543;
		}
		object obj157 = (object)(&obj5);
		object obj158 = obj157;
		bool flag37 = obj157 == null;
		object obj159 = !flag37;
		obj17 = obj23;
		obj25 = (object)(&obj5);
		object obj160 = 0;
		obj19 = obj26;
		obj20 = obj27;
		obj29 = obj28;
		num5 = num4;
		obj33 = obj59;
		obj35 = obj59;
		num = num7;
		reference = ref reference2;
		obj37 = 0;
		obj21 = -1;
		list3 = (List<Card>)(object)list5;
		obj40 = 10;
		num2 = num3;
		if (obj159 != null)
		{
			goto IL_2347;
		}
		obj24 = (object)(&obj5);
		obj160 = 0;
		obj30 = obj31;
		obj32 = obj59;
		obj34 = obj59;
		num6 = intPtr2;
		obj36 = 0;
		obj38 = -1;
		list2 = (List<Card>)(object)list5;
		obj39 = 10;
		obj41 = obj42;
		goto IL_3a70;
		IL_1250:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		reference2 = ref *(List<List<Card>>*)null;
		goto IL_373c;
		IL_0870:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X0_v234+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0895;
		}
		goto IL_2e17;
		IL_2e17:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj161 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj162 = (nint)0 + (nint)309;
		object obj163 = obj162 & 1;
		bool flag38 = obj163 == null;
		object obj164 = !flag38;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj165 = 0;
		if (obj164 != null)
		{
			goto IL_08f6;
		}
		goto IL_2e8d;
		IL_0895:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj161 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj166 = (nint)0 + (nint)309;
		object obj167 = obj166 & 1;
		bool flag39 = obj167 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj165 = 0;
		if (!flag39)
		{
			goto IL_08f6;
		}
		goto IL_2e8d;
		IL_2e8d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X0_v232+C0]");
		object obj168 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X8_v233+108]");
		object obj169 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X8_v233+108]");
		object obj170 = (nint)0 + (nint)309;
		object obj171 = obj170 & 1;
		if (obj171 == null)
		{
			goto IL_0972;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v963 @ X8_v233+108]");
		object obj172 = 0;
		goto IL_0981;
		IL_37a7:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1759 @ X0_v142] (should have been resolved before IL gen)");
		object obj173 = (nint)0 + (nint)800;
		IEnumerable<object> enumerable2 = default(IEnumerable<object>);
		IEnumerable<object> enumerable = Enumerable.Take(enumerable2, 1);
		object obj174 = typeof(List<AdaptivePerformanceScaler>) + 416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj175 = (nint)0 + (nint)2640;
		reference = ref *(List<List<Card>>*)obj175;
		list4..ctor(enumerable);
		if (enumerable2 != null)
		{
			object obj176 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2992;
			nint num17 = (nint)enumerable2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1778 @ X8_v157 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			array = (Card[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1778 @ X8_v157 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_1496;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1778 @ X8_v157 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
			int num18 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1820 @ X10_v47 (System.Int32)-8]");
				obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1820 @ X10_v47 (System.Int32)-8]");
				if (0 == (nint)obj176)
				{
					break;
				}
				num4 = num18 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1778 @ X8_v157 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
				array = (Card[])(-1);
				bool flag40 = (nint)array != 1;
				num18 = num4;
				if (flag40)
				{
					continue;
				}
				goto IL_1496;
			}
			array = (Card[])((int*)num18)->m_value;
			object obj177 = num17 + ((int*)num18)->m_value;
			object obj178 = obj177 + 312;
			num4 = num18;
			goto IL_3847;
		}
		NullReferenceException ex8 = new NullReferenceException();
		obj17 = obj23;
		obj19 = obj26;
		obj20 = obj27;
		obj29 = obj28;
		num5 = num4;
		num = num7;
		obj22 = enumerable;
		obj21 = -1;
		num2 = num3;
		goto IL_3543;
		IL_08f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X0_v269+C0]");
		object obj179 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X8_v280+108]");
		obj169 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X8_v280+108]");
		object obj180 = (nint)0 + (nint)309;
		object obj181 = obj180 & 1;
		bool flag41 = obj181 == null;
		object obj182 = !flag41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X8_v280+108]");
		obj172 = 0;
		if (obj182 == null)
		{
			goto IL_0972;
		}
		goto IL_0981;
		IL_0972:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0981;
		IL_0981:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v955 @ X0_v241+B8]");
		object obj183 = 0;
		object obj184 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj185 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj186 = (nint)0 + (nint)309;
		object obj187 = obj186 & 1;
		bool flag42 = obj187 == null;
		object obj188 = !flag42;
		if (obj188 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X0_v245+C0]");
		object obj189 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1016 @ X8_v250+1A0]");
		Func<object, System.Int32Enum> func2 = default(Func<object, System.Int32Enum>);
		func2..ctor(obj183, (IntPtr)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj190 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj191 = (nint)0 + (nint)309;
		object obj192 = obj191 & 1;
		if (obj192 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1043 @ X0_v247+C0]");
			object obj193 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ X8_v275+108]");
			object obj194 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ X8_v275+108]");
			object obj195 = (nint)0 + (nint)309;
			object obj196 = obj195 & 1;
			bool flag43 = obj196 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1076 @ X8_v275+108]");
			object obj197 = 0;
			if (!flag43)
			{
				goto IL_0b05;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1082 @ X0_v254+C0]");
			object obj198 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X8_v261+108]");
			object obj194 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X8_v261+108]");
			object obj199 = (nint)0 + (nint)309;
			object obj200 = obj199 & 1;
			bool flag44 = obj200 == null;
			object obj201 = !flag44;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1140 @ X8_v261+108]");
			object obj197 = 0;
			if (obj201 != null)
			{
				goto IL_0b05;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1139 @ X0_v252+B8]");
		object obj202 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj203 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj204 = (nint)0 + (nint)309;
		object obj205 = obj204 & 1;
		bool flag45 = obj205 == null;
		object obj206 = !flag45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj207 = 0;
		if (obj206 != null)
		{
			goto IL_0b7b;
		}
		goto IL_301e;
		IL_3543:
		obj25 = (object)(&obj5);
		obj160 = 0;
		obj33 = obj59;
		list3 = (List<Card>)(object)list5;
		goto IL_3685;
		IL_3a70:
		object obj223 = default(object);
		bool result = default(bool);
		Func<object, System.Int32Enum> func3 = default(Func<object, System.Int32Enum>);
		while (true)
		{
			bool flag46 = obj36 == null;
			object obj208 = !flag46;
			obj17 = obj23;
			obj25 = obj24;
			obj19 = obj26;
			obj20 = obj27;
			obj29 = obj28;
			obj31 = obj30;
			num5 = num4;
			obj33 = obj32;
			intPtr2 = num6;
			num = num7;
			reference = ref reference2;
			obj21 = obj38;
			list3 = list2;
			num2 = num3;
			obj42 = obj41;
			if (obj208 == null)
			{
				if ((nint)obj39 != 10)
				{
					bool flag47 = obj39 == null;
					object obj209 = !flag47;
					if (obj209 != null)
					{
						return flag23;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
				object obj210 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
				object obj211 = (nint)0 + (nint)309;
				object obj212 = obj211 & 1;
				if (obj212 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X0_v4+C0]");
					object obj213 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X8_v92+108]");
					object obj214 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X8_v92+108]");
					object obj215 = (nint)0 + (nint)309;
					object obj216 = obj215 & 1;
					bool flag48 = obj216 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v899 @ X8_v92+108]");
					object obj217 = 0;
					if (!flag48)
					{
						goto IL_255c;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X0_v13+C0]");
					object obj218 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X8_v15+108]");
					object obj214 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X8_v15+108]");
					object obj219 = (nint)0 + (nint)309;
					object obj220 = obj219 & 1;
					bool flag49 = obj220 == null;
					object obj221 = !flag49;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v944 @ X8_v15+108]");
					object obj217 = 0;
					if (obj221 != null)
					{
						goto IL_255c;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v8+E4]");
				bool flag50 = (nint)0 == 0;
				object obj222 = !flag50;
				if (obj222 != null)
				{
					goto IL_2581;
				}
				goto IL_2c61;
			}
			OutOfMemoryException ex9 = new OutOfMemoryException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			if ((nint)obj22 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj37 = obj223;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj158 = obj25;
				bool flag51 = obj25 == null;
				object obj224 = !flag51;
				obj160 = obj223;
				obj35 = obj33;
				obj40 = 0;
				if (obj224 != null)
				{
					break;
				}
				obj23 = obj17;
				obj24 = obj25;
				obj160 = obj223;
				obj26 = obj19;
				obj27 = obj20;
				obj28 = obj29;
				obj30 = obj31;
				num4 = num5;
				obj32 = obj33;
				obj34 = obj33;
				num6 = intPtr2;
				num7 = num;
				reference2 = ref reference;
				obj36 = obj223;
				obj38 = obj21;
				list2 = list3;
				obj39 = 0;
				num3 = num2;
				obj41 = obj42;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return result;
			IL_27b2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj225 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj226 = (nint)0 + (nint)309;
			object obj227 = obj226 & 1;
			bool flag52 = obj227 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj228 = 0;
			if (!flag52)
			{
				goto IL_2813;
			}
			goto IL_31d4;
			IL_2a98:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1699 @ X0_v55+C0]");
			object obj229 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1705 @ X8_v59+108]");
			object obj230 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1705 @ X8_v59+108]");
			object obj231 = (nint)0 + (nint)309;
			object obj232 = obj231 & 1;
			bool flag53 = obj232 == null;
			object obj233 = !flag53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1705 @ X8_v59+108]");
			object obj234 = 0;
			if (obj233 == null)
			{
				goto IL_2b14;
			}
			goto IL_2b23;
			IL_2813:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1329 @ X0_v63+C0]");
			object obj235 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ X8_v71+108]");
			object obj236 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ X8_v71+108]");
			object obj237 = (nint)0 + (nint)309;
			object obj238 = obj237 & 1;
			bool flag54 = obj238 == null;
			object obj239 = !flag54;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1335 @ X8_v71+108]");
			object obj240 = 0;
			if (obj239 == null)
			{
				goto IL_288f;
			}
			goto IL_289e;
			IL_31d4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1345 @ X0_v26+C0]");
			object obj241 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X8_v24+108]");
			obj236 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X8_v24+108]");
			object obj242 = (nint)0 + (nint)309;
			object obj243 = obj242 & 1;
			if (obj243 == null)
			{
				goto IL_288f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1391 @ X8_v24+108]");
			obj240 = 0;
			goto IL_289e;
			IL_289e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1383 @ X0_v35+B8]");
			object obj244 = 0;
			object obj245 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3752;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj246 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj247 = (nint)0 + (nint)309;
			object obj248 = obj247 & 1;
			bool flag55 = obj248 == null;
			object obj249 = !flag55;
			if (obj249 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1618 @ X0_v39+C0]");
			object obj250 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1619 @ X8_v41+1B0]");
			func3..ctor(obj244, (IntPtr)0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj251 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj252 = (nint)0 + (nint)309;
			object obj253 = obj252 & 1;
			if (obj253 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1631 @ X0_v41+C0]");
				object obj254 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1637 @ X8_v66+108]");
				object obj255 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1637 @ X8_v66+108]");
				object obj256 = (nint)0 + (nint)309;
				object obj257 = obj256 & 1;
				bool flag56 = obj257 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1637 @ X8_v66+108]");
				object obj258 = 0;
				if (!flag56)
				{
					goto IL_2a22;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1643 @ X0_v48+C0]");
				object obj259 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ X8_v52+108]");
				object obj255 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ X8_v52+108]");
				object obj260 = (nint)0 + (nint)309;
				object obj261 = obj260 & 1;
				bool flag57 = obj261 == null;
				object obj262 = !flag57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ X8_v52+108]");
				object obj258 = 0;
				if (obj262 != null)
				{
					goto IL_2a22;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X0_v46+B8]");
			object obj263 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj264 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj265 = (nint)0 + (nint)309;
			object obj266 = obj265 & 1;
			bool flag58 = obj266 == null;
			object obj267 = !flag58;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj268 = 0;
			if (obj267 != null)
			{
				goto IL_2a98;
			}
			goto IL_3365;
			IL_315e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			obj225 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj269 = (nint)0 + (nint)309;
			object obj270 = obj269 & 1;
			bool flag59 = obj270 == null;
			object obj271 = !flag59;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			obj228 = 0;
			if (obj271 != null)
			{
				goto IL_2813;
			}
			goto IL_31d4;
			IL_288f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			goto IL_289e;
			IL_255c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v980 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				goto IL_2581;
			}
			goto IL_2c61;
			IL_2581:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj272 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj273 = (nint)0 + (nint)309;
			object obj274 = obj273 & 1;
			bool flag60 = obj274 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj275 = 0;
			if (!flag60)
			{
				goto IL_25e2;
			}
			goto IL_2cd7;
			IL_2c61:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			obj272 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj276 = (nint)0 + (nint)309;
			object obj277 = obj276 & 1;
			bool flag61 = obj277 == null;
			object obj278 = !flag61;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			obj275 = 0;
			if (obj278 != null)
			{
				goto IL_25e2;
			}
			goto IL_2cd7;
			IL_2cd7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1010 @ X0_v6+C0]");
			object obj279 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v7+108]");
			object obj280 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v7+108]");
			object obj281 = (nint)0 + (nint)309;
			object obj282 = obj281 & 1;
			if (obj282 == null)
			{
				goto IL_265e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1040 @ X8_v7+108]");
			object obj283 = 0;
			goto IL_266d;
			IL_3365:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1715 @ X0_v43+C0]");
			object obj284 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1751 @ X8_v45+108]");
			obj230 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1751 @ X8_v45+108]");
			object obj285 = (nint)0 + (nint)309;
			object obj286 = obj285 & 1;
			if (obj286 == null)
			{
				goto IL_2b14;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1751 @ X8_v45+108]");
			obj234 = 0;
			goto IL_2b23;
			IL_25e2:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X0_v71+C0]");
			object obj287 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X8_v84+108]");
			obj280 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X8_v84+108]");
			object obj288 = (nint)0 + (nint)309;
			object obj289 = obj288 & 1;
			bool flag62 = obj289 == null;
			object obj290 = !flag62;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X8_v84+108]");
			obj283 = 0;
			if (obj290 == null)
			{
				goto IL_265e;
			}
			goto IL_266d;
			IL_265e:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			goto IL_266d;
			IL_266d:
			object obj291 = (nint)0 + (nint)2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1029 @ X0_v15+B8]");
			object obj292 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X8_v19+28]");
			Func<object, System.Int32Enum> keySelector2 = (Func<object, System.Int32Enum>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X8_v19+28]");
			bool flag63 = (nint)0 == 0;
			object obj293 = !flag63;
			if (obj293 != null)
			{
				goto IL_2b55;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj294 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj295 = (nint)0 + (nint)309;
			object obj296 = obj295 & 1;
			if (obj296 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1057 @ X0_v24+C0]");
				object obj297 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1115 @ X8_v79+108]");
				object obj298 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1115 @ X8_v79+108]");
				object obj299 = (nint)0 + (nint)309;
				object obj300 = obj299 & 1;
				bool flag64 = obj300 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1115 @ X8_v79+108]");
				object obj301 = 0;
				if (!flag64)
				{
					goto IL_278d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1121 @ X0_v33+C0]");
				object obj302 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ X8_v32+108]");
				object obj298 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ X8_v32+108]");
				object obj303 = (nint)0 + (nint)309;
				object obj304 = obj303 & 1;
				bool flag65 = obj304 == null;
				object obj305 = !flag65;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ X8_v32+108]");
				object obj301 = 0;
				if (obj305 != null)
				{
					goto IL_278d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1247 @ X0_v28+E4]");
			bool flag66 = (nint)0 == 0;
			object obj306 = !flag66;
			if (obj306 != null)
			{
				goto IL_27b2;
			}
			goto IL_315e;
			IL_2b23:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1748 @ X0_v50+B8]");
			object obj307 = (nint)0 + (nint)40;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num7 = unchecked((nint)null);
			keySelector2 = func3;
			goto IL_2b55;
			IL_2b14:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			goto IL_2b23;
			IL_2a22:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1650 @ X0_v57+B8]");
			object obj308 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			obj264 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			object obj309 = (nint)0 + (nint)309;
			object obj310 = obj309 & 1;
			bool flag67 = obj310 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X26_v1+20]");
			obj268 = 0;
			if (!flag67)
			{
				goto IL_2a98;
			}
			goto IL_3365;
			IL_2b55:
			IOrderedEnumerable<object> source3 = Enumerable.OrderByDescending(list2, keySelector2);
			List<object> list6 = Enumerable.ToList(source3);
			num6 = (nint)list6;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return Enumerable.Any((IEnumerable<object>)num6);
			IL_278d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1247 @ X0_v28+E4]");
			if ((nint)0 != 0)
			{
				goto IL_27b2;
			}
			goto IL_315e;
		}
		goto IL_2347;
		IL_2347:
		object obj311 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj312 = obj158;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v101+12E]");
		array = (Card[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v101+12E]");
		if ((nint)0 == 0)
		{
			goto IL_23ff;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v101+B0]");
		int num19 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X10_v9 (System.Int32)-8]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v807 @ X10_v9 (System.Int32)-8]");
			if (0 == (nint)obj311)
			{
				break;
			}
			num5 = num19 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X8_v101+12E]");
			array = (Card[])(-1);
			bool flag68 = (nint)array != 1;
			num19 = num5;
			if (flag68)
			{
				continue;
			}
			goto IL_23ff;
		}
		array = (Card[])((int*)num19)->m_value;
		object obj313 = obj312 + ((int*)num19)->m_value;
		object obj314 = obj313 + 312;
		num5 = num19;
		reference2 = ref reference;
		goto IL_3b44;
		IL_1373:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		reference2 = ref *(List<List<Card>>*)null;
		goto IL_37a7;
		IL_3a42:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2108 @ X0_v169+8]");
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2108 @ X0_v169] (should have been resolved before IL gen)");
		goto IL_34a1;
		IL_0b05:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1124 @ X0_v263+B8]");
		object obj315 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj203 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj316 = (nint)0 + (nint)309;
		object obj317 = obj316 & 1;
		bool flag69 = obj317 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj207 = 0;
		if (!flag69)
		{
			goto IL_0b7b;
		}
		goto IL_301e;
		IL_301e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ X0_v249+C0]");
		object obj318 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1263 @ X8_v254+108]");
		object obj319 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1263 @ X8_v254+108]");
		object obj320 = (nint)0 + (nint)309;
		object obj321 = obj320 & 1;
		if (obj321 == null)
		{
			goto IL_0bf7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1263 @ X8_v254+108]");
		object obj322 = 0;
		goto IL_0c06;
		IL_2019:
		NullReferenceException ex10 = new NullReferenceException();
		obj17 = (object)(&obj6);
		obj18 = 0;
		reference = ref reference2;
		obj21 = -1;
		num2 = num3;
		goto IL_3543;
		IL_0b7b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1187 @ X0_v261+C0]");
		object obj323 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1193 @ X8_v268+108]");
		obj319 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1193 @ X8_v268+108]");
		object obj324 = (nint)0 + (nint)309;
		object obj325 = obj324 & 1;
		bool flag70 = obj325 == null;
		object obj326 = !flag70;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1193 @ X8_v268+108]");
		obj322 = 0;
		if (obj326 == null)
		{
			goto IL_0bf7;
		}
		goto IL_0c06;
		IL_0bf7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0c06;
		IL_0c06:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1260 @ X0_v256+B8]");
		object obj327 = (nint)0 + (nint)32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj139 = 0;
		keySelector = func2;
		goto IL_0c3c;
		IL_0c3c:
		object obj328 = (nint)0 + (nint)3128;
		object obj329 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3712;
		object obj330 = (nint)0 + (nint)2808;
		ILookup<System.Int32Enum, object> source4 = Enumerable.ToLookup(source, keySelector);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj331 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj332 = (nint)0 + (nint)309;
		object obj333 = obj332 & 1;
		bool flag71 = obj333 == null;
		object obj334 = !flag71;
		if (obj334 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v875 @ X0_v125+C0]");
		object obj335 = 0;
		object obj336 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v130+1A8]");
		Func<object, bool> func4 = default(Func<object, bool>);
		func4..ctor(obj336, (IntPtr)0);
		reference = ref *(List<List<Card>>*)obj328;
		IEnumerable<object> enumerable3 = Enumerable.Where(source4, func4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		obj22 = obj330;
		list5..ctor();
		bool flag72 = enumerable3 == null;
		num = unchecked((nint)null);
		list3 = (List<Card>)(object)list5;
		obj42 = obj59;
		if (flag72)
		{
			goto IL_3685;
		}
		object obj337 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2704;
		nint num20 = (nint)enumerable3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X8_v133 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		array = (Card[])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X8_v133 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0e44;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X8_v133 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
		int num21 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ X10_v62 (System.Int32)-8]");
			obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1154 @ X10_v62 (System.Int32)-8]");
			if (0 == (nint)obj337)
			{
				break;
			}
			num5 = num21 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1051 @ X8_v133 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
			array = (Card[])(-1);
			bool flag73 = (nint)array != 1;
			num21 = num5;
			if (flag73)
			{
				continue;
			}
			goto IL_0e44;
		}
		array = (Card[])((int*)num21)->m_value;
		object obj338 = num20 + ((int*)num21)->m_value;
		object obj339 = obj338 + 312;
		num5 = num21;
		goto IL_36c4;
		IL_20c9:
		NullReferenceException ex11 = new NullReferenceException();
		obj17 = (object)(&obj6);
		obj18 = 0;
		reference = ref reference2;
		obj21 = -1;
		num2 = num3;
		goto IL_3543;
		IL_2051:
		NullReferenceException ex12 = new NullReferenceException();
		obj17 = (object)(&obj6);
		obj18 = 0;
		array = array2;
		reference = ref reference2;
		obj21 = -1;
		num2 = num3;
		goto IL_3543;
		IL_1dae:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		reference2 = ref *(List<List<Card>>*)null;
		goto IL_3a42;
		IL_23ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		reference2 = ref *(List<List<Card>>*)null;
		goto IL_3b44;
	}

	private unsafe static bool CheckSuitsGroup(List<Card> cards, ProjectConditions conditions, out List<List<Card>> projectCards)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_1366: Expected O, but got I
		//IL_137c: Expected O, but got I
		//IL_1385: Unknown result type (might be due to invalid IL or missing references)
		//IL_138a: Expected O, but got Unknown
		//IL_13a4: Expected O, but got I4
		//IL_13b4: Expected O, but got I
		//IL_00ad: Expected O, but got I
		//IL_00bd: Expected O, but got I
		//IL_00d3: Expected O, but got I
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_0100: Expected O, but got I
		//IL_004c: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_008f: Expected O, but got I
		//IL_13dc: Expected O, but got I
		//IL_13ec: Expected O, but got I
		//IL_1402: Expected O, but got I
		//IL_140b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1410: Expected O, but got Unknown
		//IL_142a: Expected O, but got I4
		//IL_143a: Expected O, but got I
		//IL_1471: Expected O, but got I
		//IL_1487: Expected O, but got I
		//IL_1490: Unknown result type (might be due to invalid IL or missing references)
		//IL_1495: Expected O, but got Unknown
		//IL_14af: Expected O, but got I4
		//IL_14c7: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_013e: Expected O, but got I
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0173: Expected O, but got I
		//IL_0199: Expected O, but got I
		//IL_01a9: Expected O, but got I
		//IL_01d2: Expected O, but got I
		//IL_14f7: Expected O, but got I
		//IL_1507: Expected O, but got I
		//IL_1530: Expected O, but got I4
		//IL_1548: Expected O, but got I
		//IL_158e: Expected O, but got I
		//IL_159e: Expected O, but got I
		//IL_15b4: Expected O, but got I
		//IL_15bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_15c2: Expected O, but got Unknown
		//IL_15dc: Expected O, but got I4
		//IL_1604: Expected O, but got I
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0208: Expected O, but got I
		//IL_022c: Expected O, but got I
		//IL_0242: Expected O, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_026a: Expected O, but got I4
		//IL_0297: Expected O, but got I
		//IL_169e: Expected O, but got I
		//IL_16b4: Expected O, but got I
		//IL_16bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_16c2: Expected O, but got Unknown
		//IL_16dc: Expected O, but got I4
		//IL_1704: Expected O, but got I
		//IL_164e: Expected O, but got I4
		//IL_02de: Expected O, but got I
		//IL_02f4: Expected O, but got I
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0316: Expected I, but got O
		//IL_04cd: Expected O, but got I
		//IL_04dd: Expected O, but got I
		//IL_04f3: Expected O, but got I
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0501: Expected O, but got Unknown
		//IL_051b: Expected O, but got I4
		//IL_0553: Expected O, but got I
		//IL_0444: Expected O, but got I
		//IL_045a: Expected O, but got I
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_04af: Expected O, but got I
		//IL_05a4: Expected O, but got I
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_05c8: Expected O, but got I
		//IL_05d8: Expected O, but got I
		//IL_05fa: Expected O, but got I4
		//IL_173c: Expected O, but got I
		//IL_174c: Expected O, but got I
		//IL_1762: Expected O, but got I
		//IL_176b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1770: Expected O, but got Unknown
		//IL_034c: Expected O, but got I
		//IL_035c: Expected O, but got I
		//IL_0372: Expected O, but got I
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0394: Expected I, but got O
		//IL_03b1: Expected I, but got O
		//IL_03d1: Expected O, but got I
		//IL_0a9e: Expected O, but got I
		//IL_0aad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab2: Expected O, but got Unknown
		//IL_0ae2: Expected O, but got I
		//IL_0af8: Expected O, but got I
		//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b06: Expected O, but got Unknown
		//IL_0b20: Expected O, but got I4
		//IL_0618: Expected O, but got I
		//IL_062e: Expected O, but got I
		//IL_0637: Unknown result type (might be due to invalid IL or missing references)
		//IL_063c: Expected O, but got Unknown
		//IL_17b5: Expected O, but got I
		//IL_0b49: Expected O, but got I
		//IL_0b59: Expected O, but got I
		//IL_199a: Expected O, but got I
		//IL_19aa: Expected O, but got I
		//IL_19c0: Expected O, but got I
		//IL_19c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ce: Expected O, but got Unknown
		//IL_19e8: Expected O, but got I4
		//IL_19f8: Expected O, but got I
		//IL_0ba2: Expected O, but got I
		//IL_0bb8: Expected O, but got I
		//IL_0bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc6: Expected O, but got Unknown
		//IL_0be0: Expected O, but got I4
		//IL_0669: Expected O, but got I
		//IL_0679: Expected O, but got I
		//IL_068f: Expected O, but got I
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_069d: Expected O, but got Unknown
		//IL_06bc: Expected O, but got I
		//IL_0c0d: Expected O, but got I
		//IL_1a5a: Expected O, but got I
		//IL_1a70: Expected O, but got I
		//IL_1a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a7e: Expected O, but got Unknown
		//IL_1a98: Expected O, but got I4
		//IL_1aa8: Expected O, but got I
		//IL_1a32: Expected O, but got I4
		//IL_0c4c: Expected O, but got I
		//IL_0c62: Expected O, but got I
		//IL_0c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c70: Expected O, but got Unknown
		//IL_0760: Expected O, but got I
		//IL_0770: Expected O, but got I
		//IL_0786: Expected O, but got I
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected O, but got Unknown
		//IL_07ae: Expected O, but got I4
		//IL_07be: Expected O, but got I
		//IL_06ff: Expected O, but got I
		//IL_0715: Expected O, but got I
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0723: Expected O, but got Unknown
		//IL_0742: Expected O, but got I
		//IL_17e4: Expected O, but got I
		//IL_17f4: Expected O, but got I
		//IL_180a: Expected O, but got I
		//IL_1813: Unknown result type (might be due to invalid IL or missing references)
		//IL_1818: Expected O, but got Unknown
		//IL_1832: Expected O, but got I4
		//IL_1842: Expected O, but got I
		//IL_07eb: Expected O, but got I
		//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ff: Expected O, but got Unknown
		//IL_0819: Expected O, but got I
		//IL_082f: Expected O, but got I
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected O, but got Unknown
		//IL_0857: Expected O, but got I4
		//IL_1ad0: Expected O, but got I
		//IL_1ae0: Expected O, but got I
		//IL_1af6: Expected O, but got I
		//IL_1aff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b04: Expected O, but got Unknown
		//IL_0c9d: Expected O, but got I
		//IL_0cad: Expected O, but got I
		//IL_0cc3: Expected O, but got I
		//IL_0ccc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd1: Expected O, but got Unknown
		//IL_0cf0: Expected O, but got I
		//IL_0884: Expected O, but got I
		//IL_08ad: Expected O, but got I
		//IL_08c3: Expected O, but got I
		//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d1: Expected O, but got Unknown
		//IL_18a4: Expected O, but got I
		//IL_18ba: Expected O, but got I
		//IL_18c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c8: Expected O, but got Unknown
		//IL_18e2: Expected O, but got I4
		//IL_18f2: Expected O, but got I
		//IL_187c: Expected O, but got I4
		//IL_1b50: Expected O, but got I
		//IL_1b60: Expected O, but got I
		//IL_1b76: Expected O, but got I
		//IL_1b7f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b84: Expected O, but got Unknown
		//IL_1b9e: Expected O, but got I4
		//IL_1bae: Expected O, but got I
		//IL_1b31: Expected O, but got I
		//IL_0d94: Expected O, but got I
		//IL_0da4: Expected O, but got I
		//IL_0dba: Expected O, but got I
		//IL_0dc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc8: Expected O, but got Unknown
		//IL_0de2: Expected O, but got I4
		//IL_0df2: Expected O, but got I
		//IL_0d33: Expected O, but got I
		//IL_0d49: Expected O, but got I
		//IL_0d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d57: Expected O, but got Unknown
		//IL_0d76: Expected O, but got I
		//IL_096f: Expected O, but got I
		//IL_0984: Expected O, but got I
		//IL_099a: Expected O, but got I
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected O, but got Unknown
		//IL_09c7: Expected O, but got I
		//IL_08fe: Expected O, but got I
		//IL_090e: Expected O, but got I
		//IL_0924: Expected O, but got I
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected O, but got Unknown
		//IL_0951: Expected O, but got I
		//IL_0e1b: Expected O, but got I
		//IL_0e2d: Expected O, but got I
		//IL_0e3d: Expected O, but got I
		//IL_0e5f: Expected O, but got I4
		//IL_0e68: Expected O, but got I4
		//IL_191a: Expected O, but got I
		//IL_192a: Expected O, but got I
		//IL_1940: Expected O, but got I
		//IL_1949: Unknown result type (might be due to invalid IL or missing references)
		//IL_194e: Expected O, but got Unknown
		//IL_1c61: Expected O, but got I
		//IL_1c71: Expected O, but got I
		//IL_1c87: Expected O, but got I
		//IL_1c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c95: Expected O, but got Unknown
		//IL_1bd6: Expected O, but got I
		//IL_1beb: Expected O, but got I
		//IL_1c01: Expected O, but got I
		//IL_1c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0f: Expected O, but got Unknown
		//IL_1c29: Expected O, but got I4
		//IL_1c39: Expected O, but got I
		//IL_09e5: Expected O, but got I
		//IL_09f5: Expected O, but got I
		//IL_0a0b: Expected O, but got I
		//IL_0a14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Expected O, but got Unknown
		//IL_0a33: Expected O, but got I4
		//IL_0a43: Expected O, but got I
		//IL_132f: Expected I, but got O
		//IL_1342: Expected O, but got I
		//IL_0e86: Expected O, but got I
		//IL_0e9c: Expected O, but got I
		//IL_0ea5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eaa: Expected O, but got Unknown
		//IL_197b: Expected O, but got I
		//IL_0a76: Expected O, but got I
		//IL_0a85: Expected I, but got O
		//IL_1cc2: Expected O, but got I
		//IL_1ce1: Expected O, but got I
		//IL_1cf1: Expected O, but got I
		//IL_1d07: Expected O, but got I
		//IL_1d10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d15: Expected O, but got Unknown
		//IL_1d2f: Expected O, but got I4
		//IL_1d3f: Expected O, but got I
		//IL_0ed7: Expected O, but got I
		//IL_0ee7: Expected O, but got I
		//IL_0efd: Expected O, but got I
		//IL_0f06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Expected O, but got Unknown
		//IL_0f2a: Expected O, but got I
		//IL_1da1: Expected O, but got I
		//IL_1db7: Expected O, but got I
		//IL_1dc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dc5: Expected O, but got Unknown
		//IL_1ddf: Expected O, but got I4
		//IL_1def: Expected O, but got I
		//IL_1d79: Expected O, but got I4
		//IL_0fce: Expected O, but got I
		//IL_0fde: Expected O, but got I
		//IL_0ff4: Expected O, but got I
		//IL_0ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1002: Expected O, but got Unknown
		//IL_101c: Expected O, but got I4
		//IL_102c: Expected O, but got I
		//IL_0f6d: Expected O, but got I
		//IL_0f83: Expected O, but got I
		//IL_0f8c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f91: Expected O, but got Unknown
		//IL_0fb0: Expected O, but got I
		//IL_1059: Expected O, but got I
		//IL_1068: Unknown result type (might be due to invalid IL or missing references)
		//IL_106d: Expected O, but got Unknown
		//IL_1087: Expected O, but got I
		//IL_109d: Expected O, but got I
		//IL_10a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ab: Expected O, but got Unknown
		//IL_10c5: Expected O, but got I4
		//IL_1e17: Expected O, but got I
		//IL_1e27: Expected O, but got I
		//IL_1e3d: Expected O, but got I
		//IL_1e46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e4b: Expected O, but got Unknown
		//IL_10f2: Expected O, but got I
		//IL_111b: Expected O, but got I
		//IL_1131: Expected O, but got I
		//IL_113a: Unknown result type (might be due to invalid IL or missing references)
		//IL_113f: Expected O, but got Unknown
		//IL_1e97: Expected O, but got I
		//IL_1ea7: Expected O, but got I
		//IL_1ebd: Expected O, but got I
		//IL_1ec6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ecb: Expected O, but got Unknown
		//IL_1ee5: Expected O, but got I4
		//IL_1ef5: Expected O, but got I
		//IL_1e78: Expected O, but got I
		//IL_11dd: Expected O, but got I
		//IL_11f2: Expected O, but got I
		//IL_1208: Expected O, but got I
		//IL_1211: Unknown result type (might be due to invalid IL or missing references)
		//IL_1216: Expected O, but got Unknown
		//IL_1235: Expected O, but got I
		//IL_116c: Expected O, but got I
		//IL_117c: Expected O, but got I
		//IL_1192: Expected O, but got I
		//IL_119b: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a0: Expected O, but got Unknown
		//IL_11bf: Expected O, but got I
		//IL_1fa8: Expected O, but got I
		//IL_1fb8: Expected O, but got I
		//IL_1fce: Expected O, but got I
		//IL_1fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fdc: Expected O, but got Unknown
		//IL_1f1d: Expected O, but got I
		//IL_1f32: Expected O, but got I
		//IL_1f48: Expected O, but got I
		//IL_1f51: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f56: Expected O, but got Unknown
		//IL_1f70: Expected O, but got I4
		//IL_1f80: Expected O, but got I
		//IL_1253: Expected O, but got I
		//IL_1263: Expected O, but got I
		//IL_1279: Expected O, but got I
		//IL_1282: Unknown result type (might be due to invalid IL or missing references)
		//IL_1287: Expected O, but got Unknown
		//IL_12a1: Expected O, but got I4
		//IL_12b1: Expected O, but got I
		//IL_12e4: Expected O, but got I
		//IL_12f7: Expected O, but got I4
		//IL_2009: Expected O, but got I
		object obj = 152965120;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E15DA]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
			object obj4 = (nint)0 + (nint)309;
			object obj5 = obj4 & 1;
			bool flag = obj5 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
			object obj6 = 0;
			if (!flag)
			{
				goto IL_009d;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
			object obj7 = (nint)0 + (nint)309;
			object obj8 = obj7 & 1;
			bool flag2 = obj8 == null;
			object obj9 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
			object obj6 = 0;
			if (obj9 != null)
			{
				goto IL_009d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v22+C0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v22+1B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v22+1B8]");
		object obj12 = (nint)0 + (nint)309;
		object obj13 = obj12 & 1;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v22+1B8]");
		object obj15 = 0;
		if (obj14 != null)
		{
			goto IL_010e;
		}
		goto IL_1448;
		IL_1049:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v768 @ X0_v110+B8]");
		object obj16 = 0;
		object obj17 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj19 = (nint)0 + (nint)309;
		object obj20 = obj19 & 1;
		bool flag4 = obj20 == null;
		object obj21 = !flag4;
		if (obj21 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X0_v114+C0]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v787 @ X8_v74+1E8]");
		Func<object, System.Int32Enum> func = default(Func<object, System.Int32Enum>);
		func..ctor(obj16, (IntPtr)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj24 = (nint)0 + (nint)309;
		object obj25 = obj24 & 1;
		if (obj25 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v790 @ X0_v116+C0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v99+108]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v99+108]");
			object obj28 = (nint)0 + (nint)309;
			object obj29 = obj28 & 1;
			bool flag5 = obj29 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X8_v99+108]");
			object obj30 = 0;
			if (!flag5)
			{
				goto IL_11cd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X0_v123+C0]");
			object obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X8_v85+108]");
			object obj27 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X8_v85+108]");
			object obj32 = (nint)0 + (nint)309;
			object obj33 = obj32 & 1;
			bool flag6 = obj33 == null;
			object obj34 = !flag6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X8_v85+108]");
			object obj30 = 0;
			if (obj34 != null)
			{
				goto IL_11cd;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X0_v121+B8]");
		object obj35 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj37 = (nint)0 + (nint)309;
		object obj38 = obj37 & 1;
		bool flag7 = obj38 == null;
		object obj39 = !flag7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj40 = 0;
		if (obj39 != null)
		{
			goto IL_1243;
		}
		goto IL_1f8e;
		IL_1dfd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X0_v101+C0]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v57+108]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v57+108]");
		object obj43 = (nint)0 + (nint)309;
		object obj44 = obj43 & 1;
		if (obj44 == null)
		{
			goto IL_103a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v57+108]");
		object obj45 = 0;
		goto IL_1049;
		IL_11cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X0_v132+B8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj47 = (nint)0 + (nint)309;
		object obj48 = obj47 & 1;
		bool flag8 = obj48 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj40 = 0;
		if (!flag8)
		{
			goto IL_1243;
		}
		goto IL_1f8e;
		IL_009d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v222+C0]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v216+1B8]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v216+1B8]");
		object obj50 = (nint)0 + (nint)309;
		object obj51 = obj50 & 1;
		bool flag9 = obj51 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v216+1B8]");
		obj15 = 0;
		if (!flag9)
		{
			goto IL_010e;
		}
		goto IL_1448;
		IL_1448:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj53 = (nint)0 + (nint)309;
		object obj54 = obj53 & 1;
		bool flag10 = obj54 == null;
		object obj55 = !flag10;
		object obj57 = default(object);
		object obj56 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj58 = 0;
		object obj59 = obj57;
		if (obj55 != null)
		{
			goto IL_0189;
		}
		goto IL_14dd;
		IL_010e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj52 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj60 = (nint)0 + (nint)309;
		object obj61 = obj60 & 1;
		bool flag11 = obj61 == null;
		object obj62 = default(object);
		obj56 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj58 = 0;
		obj59 = obj62;
		if (!flag11)
		{
			goto IL_0189;
		}
		goto IL_14dd;
		IL_14dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v15+C0]");
		object obj63 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v17+1C0]");
		Func<object, bool> func2 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31EA7AC");
		bool flag12 = obj59 == null;
		object obj64 = !flag12;
		obj56 = obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v17+1C0]");
		Func<object, bool> func3 = (Func<object, bool>)0;
		if (obj64 != null)
		{
			goto IL_01e8;
		}
		goto IL_1556;
		IL_0189:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v217+C0]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v211+1C0]");
		func2 = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @31EA7AC");
		bool flag13 = obj56 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X8_v211+1C0]");
		func3 = (Func<object, bool>)0;
		obj59 = obj56;
		if (!flag13)
		{
			goto IL_01e8;
		}
		goto IL_1556;
		IL_1556:
		NullReferenceException ex = new NullReferenceException();
		nint num2 = default(nint);
		nint num = num2;
		List<Card> list = cards;
		goto IL_1574;
		IL_01e8:
		object obj66 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 448;
		object obj67 = (nint)0 + (nint)3280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj68 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj69 = (nint)0 + (nint)309;
		object obj70 = obj69 & 1;
		bool flag14 = obj70 == null;
		object obj71 = !flag14;
		if (obj71 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v210+C0]");
		object obj72 = 0;
		object obj73 = obj56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v204+1C8]");
		Func<object, bool> func4 = default(Func<object, bool>);
		func4..ctor(obj73, (IntPtr)0);
		ref List<List<Card>> reference = ref *(List<List<Card>>*)obj67;
		IEnumerable<object> enumerable = Enumerable.Where(cards, func4);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		ex = (NullReferenceException)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj74 = (nint)0 + (nint)309;
		object obj75 = obj74 & 1;
		bool flag15 = obj75 == null;
		num = unchecked((nint)null);
		func3 = func4;
		obj59 = obj56;
		list = (List<Card>)enumerable;
		if (flag15)
		{
			goto IL_1574;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v9 (System.NullReferenceException)+C0]");
		object obj76 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v207+108]");
		object obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v207+108]");
		object obj78 = (nint)0 + (nint)309;
		object obj79 = obj78 & 1;
		bool flag16 = obj79 == null;
		num = unchecked((nint)null);
		func3 = func4;
		obj59 = obj56;
		list = (List<Card>)enumerable;
		nint num3 = unchecked((nint)null);
		ref List<List<Card>> reference2 = ref *(List<List<Card>>*)obj67;
		Func<object, bool> func5 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v207+108]");
		object obj80 = 0;
		List<Card> list2 = (List<Card>)enumerable;
		if (!flag16)
		{
			goto IL_03e7;
		}
		goto IL_1622;
		IL_0fbe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X0_v138+C0]");
		object obj81 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v104+108]");
		obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v104+108]");
		object obj82 = (nint)0 + (nint)309;
		object obj83 = obj82 & 1;
		bool flag17 = obj83 == null;
		object obj84 = !flag17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v747 @ X8_v104+108]");
		obj45 = 0;
		if (obj84 == null)
		{
			goto IL_103a;
		}
		goto IL_1049;
		IL_103a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_1049;
		IL_1574:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v10+C0]");
		object obj85 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v12+108]");
		obj77 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v12+108]");
		object obj86 = (nint)0 + (nint)309;
		object obj87 = obj86 & 1;
		bool flag18 = obj87 == null;
		object obj88 = !flag18;
		num3 = num;
		reference2 = ref reference;
		func5 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v12+108]");
		obj80 = 0;
		obj56 = obj59;
		list2 = list;
		if (obj88 != null)
		{
			goto IL_03e7;
		}
		goto IL_1622;
		IL_0cfe:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X0_v83+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0d23;
		}
		goto IL_188a;
		IL_1622:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v4+E4]");
		bool flag19 = (nint)0 == 0;
		object obj89 = !flag19;
		num = num3;
		reference = ref reference2;
		func3 = func5;
		obj59 = obj56;
		list = list2;
		if (obj89 != null)
		{
			goto IL_0434;
		}
		goto IL_1684;
		IL_03e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X0_v4+E4]");
		bool flag20 = (nint)0 == 0;
		num3 = num;
		reference2 = ref reference;
		func5 = func3;
		obj56 = obj59;
		list2 = list;
		if (!flag20)
		{
			goto IL_0434;
		}
		goto IL_1684;
		IL_1684:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj91 = (nint)0 + (nint)309;
		object obj92 = obj91 & 1;
		bool flag21 = obj92 == null;
		object obj93 = !flag21;
		num3 = num;
		reference2 = ref reference;
		func5 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj94 = 0;
		obj56 = obj59;
		list2 = list;
		if (obj93 != null)
		{
			goto IL_04bd;
		}
		goto IL_1722;
		IL_0434:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj95 = (nint)0 + (nint)309;
		object obj96 = obj95 & 1;
		bool flag22 = obj96 == null;
		num = num3;
		reference = ref reference2;
		func3 = func5;
		obj59 = obj56;
		list = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj94 = 0;
		if (!flag22)
		{
			goto IL_04bd;
		}
		goto IL_1722;
		IL_1722:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v2+C0]");
		object obj97 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v3+108]");
		object obj98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v3+108]");
		object obj99 = (nint)0 + (nint)309;
		object obj100 = obj99 & 1;
		if (obj100 == null)
		{
			goto IL_0561;
		}
		num = num3;
		reference = ref reference2;
		func3 = func5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X8_v3+108]");
		object obj101 = 0;
		obj59 = obj56;
		list = list2;
		goto IL_0598;
		IL_188a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj103 = (nint)0 + (nint)309;
		object obj104 = obj103 & 1;
		bool flag23 = obj104 == null;
		object obj105 = !flag23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj106 = 0;
		if (obj105 != null)
		{
			goto IL_0d84;
		}
		goto IL_1900;
		IL_04bd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X0_v201+C0]");
		object obj107 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v191+108]");
		obj98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v191+108]");
		object obj108 = (nint)0 + (nint)309;
		object obj109 = obj108 & 1;
		bool flag24 = obj109 == null;
		object obj110 = !flag24;
		num3 = num;
		reference2 = ref reference;
		func5 = func3;
		obj56 = obj59;
		list2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v191+108]");
		obj101 = 0;
		if (obj110 == null)
		{
			goto IL_0561;
		}
		goto IL_0598;
		IL_0561:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		num = num3;
		reference = ref reference2;
		func3 = func5;
		obj59 = obj56;
		list = list2;
		goto IL_0598;
		IL_0598:
		object obj111 = (nint)0 + (nint)2936;
		object obj112 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3328;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v61+B8]");
		object obj113 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v29+30]");
		Func<object, System.Int32Enum> keySelector = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v29+30]");
		bool flag25 = (nint)0 == 0;
		object obj114 = !flag25;
		if (obj114 != null)
		{
			goto IL_0a92;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj115 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj116 = (nint)0 + (nint)309;
		object obj117 = obj116 & 1;
		if (obj117 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v154+C0]");
			object obj118 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v186+108]");
			object obj119 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v186+108]");
			object obj120 = (nint)0 + (nint)309;
			object obj121 = obj120 & 1;
			bool flag26 = obj121 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v186+108]");
			object obj122 = 0;
			if (!flag26)
			{
				goto IL_06ca;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X0_v163+C0]");
			object obj123 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v139+108]");
			object obj119 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v139+108]");
			object obj124 = (nint)0 + (nint)309;
			object obj125 = obj124 & 1;
			bool flag27 = obj125 == null;
			object obj126 = !flag27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v139+108]");
			object obj122 = 0;
			if (obj126 != null)
			{
				goto IL_06ca;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v158+E4]");
		bool flag28 = (nint)0 == 0;
		object obj127 = !flag28;
		if (obj127 != null)
		{
			goto IL_06ef;
		}
		goto IL_1a40;
		IL_0d23:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj102 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj128 = (nint)0 + (nint)309;
		object obj129 = obj128 & 1;
		bool flag29 = obj129 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj106 = 0;
		if (!flag29)
		{
			goto IL_0d84;
		}
		goto IL_1900;
		IL_0d84:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v146+C0]");
		object obj130 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v117+108]");
		object obj131 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v117+108]");
		object obj132 = (nint)0 + (nint)309;
		object obj133 = obj132 & 1;
		bool flag30 = obj133 == null;
		object obj134 = !flag30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v117+108]");
		object obj135 = 0;
		if (obj134 == null)
		{
			goto IL_0e00;
		}
		goto IL_0e0f;
		IL_1304:
		IEnumerable<object> source2;
		Func<object, System.Int32Enum> keySelector2;
		IOrderedEnumerable<object> source = Enumerable.OrderByDescending(source2, keySelector2);
		List<object> list3 = Enumerable.ToList(source);
		num2 = (nint)list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return Enumerable.Any((IEnumerable<object>)num2);
		IL_1900:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v631 @ X0_v81+C0]");
		object obj136 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v40+108]");
		obj131 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v40+108]");
		object obj137 = (nint)0 + (nint)309;
		object obj138 = obj137 & 1;
		if (obj138 == null)
		{
			goto IL_0e00;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v40+108]");
		obj135 = 0;
		goto IL_0e0f;
		IL_06ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X0_v158+E4]");
		if ((nint)0 != 0)
		{
			goto IL_06ef;
		}
		goto IL_1a40;
		IL_1a40:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj139 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj140 = (nint)0 + (nint)309;
		object obj141 = obj140 & 1;
		bool flag31 = obj141 == null;
		object obj142 = !flag31;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj143 = 0;
		if (obj142 != null)
		{
			goto IL_0750;
		}
		goto IL_1ab6;
		IL_06ef:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj139 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj144 = (nint)0 + (nint)309;
		object obj145 = obj144 & 1;
		bool flag32 = obj145 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj143 = 0;
		if (!flag32)
		{
			goto IL_0750;
		}
		goto IL_1ab6;
		IL_1ab6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X0_v156+C0]");
		object obj146 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v131+108]");
		object obj147 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v131+108]");
		object obj148 = (nint)0 + (nint)309;
		object obj149 = obj148 & 1;
		if (obj149 == null)
		{
			goto IL_07cc;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v131+108]");
		object obj150 = 0;
		goto IL_07db;
		IL_0e00:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0e0f;
		IL_0750:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v193+C0]");
		object obj151 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v178+108]");
		obj147 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v178+108]");
		object obj152 = (nint)0 + (nint)309;
		object obj153 = obj152 & 1;
		bool flag33 = obj153 == null;
		object obj154 = !flag33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v178+108]");
		obj150 = 0;
		if (obj154 == null)
		{
			goto IL_07cc;
		}
		goto IL_07db;
		IL_07cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_07db;
		IL_07db:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v165+B8]");
		object obj155 = 0;
		object obj156 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj157 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj158 = (nint)0 + (nint)309;
		object obj159 = obj158 & 1;
		bool flag34 = obj159 == null;
		object obj160 = !flag34;
		if (obj160 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X0_v169+C0]");
		object obj161 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X8_v148+1D0]");
		Func<object, System.Int32Enum> func6 = default(Func<object, System.Int32Enum>);
		func6..ctor(obj155, (IntPtr)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj162 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj163 = (nint)0 + (nint)309;
		object obj164 = obj163 & 1;
		if (obj164 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v171+C0]");
			object obj165 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v173+108]");
			object obj166 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v173+108]");
			object obj167 = (nint)0 + (nint)309;
			object obj168 = obj167 & 1;
			bool flag35 = obj168 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v173+108]");
			object obj169 = 0;
			if (!flag35)
			{
				goto IL_095f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X0_v178+C0]");
			object obj170 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v159+108]");
			object obj166 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v159+108]");
			object obj171 = (nint)0 + (nint)309;
			object obj172 = obj171 & 1;
			bool flag36 = obj172 == null;
			object obj173 = !flag36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v539 @ X8_v159+108]");
			object obj169 = 0;
			if (obj173 != null)
			{
				goto IL_095f;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v176+B8]");
		object obj174 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj175 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj176 = (nint)0 + (nint)309;
		object obj177 = obj176 & 1;
		bool flag37 = obj177 == null;
		object obj178 = !flag37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj179 = 0;
		if (obj178 != null)
		{
			goto IL_09d5;
		}
		goto IL_1c47;
		IL_1f8e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X0_v118+C0]");
		object obj180 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v78+108]");
		object obj181 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v78+108]");
		object obj182 = (nint)0 + (nint)309;
		object obj183 = obj182 & 1;
		if (obj183 == null)
		{
			goto IL_12bf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v853 @ X8_v78+108]");
		object obj184 = 0;
		goto IL_12ce;
		IL_0e0f:
		object obj185 = (nint)0 + (nint)2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X0_v90+B8]");
		object obj186 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v52+38]");
		keySelector2 = (Func<object, System.Int32Enum>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v52+38]");
		bool flag38 = (nint)0 == 0;
		object obj187 = !flag38;
		object obj188 = 0;
		if (obj187 != null)
		{
			goto IL_1304;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj189 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj190 = (nint)0 + (nint)309;
		object obj191 = obj190 & 1;
		if (obj191 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X0_v99+C0]");
			object obj192 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v112+108]");
			object obj193 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v112+108]");
			object obj194 = (nint)0 + (nint)309;
			object obj195 = obj194 & 1;
			bool flag39 = obj195 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v112+108]");
			object obj196 = 0;
			if (!flag39)
			{
				goto IL_0f38;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X0_v108+C0]");
			object obj197 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v65+108]");
			object obj193 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v65+108]");
			object obj198 = (nint)0 + (nint)309;
			object obj199 = obj198 & 1;
			bool flag40 = obj199 == null;
			object obj200 = !flag40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v65+108]");
			object obj196 = 0;
			if (obj200 != null)
			{
				goto IL_0f38;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v103+E4]");
		bool flag41 = (nint)0 == 0;
		object obj201 = !flag41;
		if (obj201 != null)
		{
			goto IL_0f5d;
		}
		goto IL_1d87;
		IL_12ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v850 @ X0_v125+B8]");
		object obj202 = (nint)0 + (nint)56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj188 = 0;
		keySelector2 = func;
		goto IL_1304;
		IL_12bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_12ce;
		IL_1243:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X0_v130+C0]");
		object obj203 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X8_v92+108]");
		obj181 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X8_v92+108]");
		object obj204 = (nint)0 + (nint)309;
		object obj205 = obj204 & 1;
		bool flag42 = obj205 == null;
		object obj206 = !flag42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v828 @ X8_v92+108]");
		obj184 = 0;
		if (obj206 == null)
		{
			goto IL_12bf;
		}
		goto IL_12ce;
		IL_095f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X0_v187+B8]");
		object obj207 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj175 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj208 = (nint)0 + (nint)309;
		object obj209 = obj208 & 1;
		bool flag43 = obj209 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj179 = 0;
		if (!flag43)
		{
			goto IL_09d5;
		}
		goto IL_1c47;
		IL_1c47:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X0_v173+C0]");
		object obj210 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v152+108]");
		object obj211 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v152+108]");
		object obj212 = (nint)0 + (nint)309;
		object obj213 = obj212 & 1;
		if (obj213 == null)
		{
			goto IL_0a51;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v597 @ X8_v152+108]");
		object obj214 = 0;
		goto IL_0a60;
		IL_0f38:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X0_v103+E4]");
		if ((nint)0 != 0)
		{
			goto IL_0f5d;
		}
		goto IL_1d87;
		IL_09d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v185+C0]");
		object obj215 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v166+108]");
		obj211 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v166+108]");
		object obj216 = (nint)0 + (nint)309;
		object obj217 = obj216 & 1;
		bool flag44 = obj217 == null;
		object obj218 = !flag44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v166+108]");
		obj214 = 0;
		if (obj218 == null)
		{
			goto IL_0a51;
		}
		goto IL_0a60;
		IL_0a51:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		goto IL_0a60;
		IL_0a60:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X0_v180+B8]");
		object obj219 = (nint)0 + (nint)48;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		num = unchecked((nint)null);
		keySelector = func6;
		goto IL_0a92;
		IL_0a92:
		object obj220 = (nint)0 + (nint)3112;
		object obj221 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3320;
		ILookup<System.Int32Enum, object> source3 = Enumerable.ToLookup(list, keySelector);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj222 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj223 = (nint)0 + (nint)309;
		object obj224 = obj223 & 1;
		bool flag45 = obj224 == null;
		object obj225 = !flag45;
		if (obj225 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		object obj226 = (nint)0 + (nint)2712;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v68+C0]");
		object obj227 = 0;
		object obj228 = obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v33+1D8]");
		Func<object, bool> func7 = default(Func<object, bool>);
		func7..ctor(obj228, (IntPtr)0);
		IEnumerable<object> source4 = Enumerable.Where(source3, func7);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj229 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj230 = (nint)0 + (nint)309;
		object obj231 = obj230 & 1;
		bool flag46 = obj231 == null;
		object obj232 = !flag46;
		if (obj232 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v75+C0]");
		object obj233 = 0;
		object obj234 = obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X8_v36+1E0]");
		Func<object, object> func8 = default(Func<object, object>);
		func8..ctor(obj234, (IntPtr)0);
		source2 = Enumerable.Select(source4, func8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj235 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj236 = (nint)0 + (nint)309;
		object obj237 = obj236 & 1;
		if (obj237 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v79+C0]");
			object obj238 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v125+108]");
			object obj239 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v125+108]");
			object obj240 = (nint)0 + (nint)309;
			object obj241 = obj240 & 1;
			bool flag47 = obj241 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v125+108]");
			object obj242 = 0;
			if (!flag47)
			{
				goto IL_0cfe;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v88+C0]");
			object obj243 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v48+108]");
			object obj239 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v48+108]");
			object obj244 = (nint)0 + (nint)309;
			object obj245 = obj244 & 1;
			bool flag48 = obj245 == null;
			object obj246 = !flag48;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v583 @ X8_v48+108]");
			object obj242 = 0;
			if (obj246 != null)
			{
				goto IL_0cfe;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X0_v83+E4]");
		bool flag49 = (nint)0 == 0;
		object obj247 = !flag49;
		if (obj247 != null)
		{
			goto IL_0d23;
		}
		goto IL_188a;
		IL_0f5d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj248 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj249 = (nint)0 + (nint)309;
		object obj250 = obj249 & 1;
		bool flag50 = obj250 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj251 = 0;
		if (!flag50)
		{
			goto IL_0fbe;
		}
		goto IL_1dfd;
		IL_1d87:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj248 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		object obj252 = (nint)0 + (nint)309;
		object obj253 = obj252 & 1;
		bool flag51 = obj253 == null;
		object obj254 = !flag51;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v27 @ X4+20]");
		obj251 = 0;
		if (obj254 != null)
		{
			goto IL_0fbe;
		}
		goto IL_1dfd;
	}
}
