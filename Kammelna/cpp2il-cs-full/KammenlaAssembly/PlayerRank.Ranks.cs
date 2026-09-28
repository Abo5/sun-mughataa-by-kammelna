using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Mono.Btls;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class PlayerRank
{
	public enum Ranks
	{
		AI,
		Beginner,
		Intermediate,
		Advanced,
		Professional,
		Expert,
		Master,
		Elite,
		King
	}

	private static readonly Dictionary<Ranks, int> balootRanksLimits;

	private static readonly Dictionary<Ranks, int> tarneebRanksLimits;

	private static readonly Dictionary<Ranks, int> jackarooRanksLimits;

	public static readonly PlayerRank AI;

	private int <SubRanksCount>k__BackingField;

	private Ranks <Rank>k__BackingField;

	private readonly int <Points>k__BackingField;

	private int <MinSubRankLimit>k__BackingField;

	private int <MaxSubRankLimit>k__BackingField;

	private bool <IsNew>k__BackingField;

	public int SubRanksCount
	{
		get
		{
			return <SubRanksCount>k__BackingField;
		}
		private set
		{
			<SubRanksCount>k__BackingField = value;
		}
	}

	public Ranks Rank
	{
		get
		{
			return <Rank>k__BackingField;
		}
		private set
		{
			<Rank>k__BackingField = value;
		}
	}

	public string RankName
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2624;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			return EnumExtensions.GetFriendlyName(enumeration);
		}
	}

	public int Points => <Points>k__BackingField;

	public int MinSubRankLimit
	{
		get
		{
			return <MinSubRankLimit>k__BackingField;
		}
		private set
		{
			<MinSubRankLimit>k__BackingField = value;
		}
	}

	public int MaxSubRankLimit
	{
		get
		{
			return <MaxSubRankLimit>k__BackingField;
		}
		private set
		{
			<MaxSubRankLimit>k__BackingField = value;
		}
	}

	public bool IsNew
	{
		get
		{
			return <IsNew>k__BackingField;
		}
		set
		{
			<IsNew>k__BackingField = value;
		}
	}

	public static int GetRequiredPoints(Games game, Ranks rank, int subRank)
	{
		//IL_0278: Expected O, but got I4
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01d9: Expected O, but got I4
		//IL_0223: Expected O, but got I4
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02c4: Expected O, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0086: Expected O, but got I4
		//IL_025e: Expected I4, but got O
		//IL_015f: Expected O, but got I4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected I4, but got Unknown
		//IL_00d9: Expected O, but got I
		//IL_00e1: Expected I4, but got O
		bool flag = subRank < 6;
		object obj = !flag;
		if (obj == null)
		{
			System.Int32Enum int32Enum = (System.Int32Enum)(rank - 1);
			bool flag2 = rank == Ranks.Beginner;
			System.Int32Enum int32Enum2 = (System.Int32Enum)rank;
			int num = subRank;
			int num2 = (int)int32Enum;
			if (!flag2)
			{
				object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
				object obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v21+E4]");
				bool flag3 = (nint)0 == 0;
				object obj4 = !flag3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Dictionary<Ranks, int> ranksLimit = GetRanksLimit(game);
				if (ranksLimit == null)
				{
					goto IL_0250;
				}
				object obj5 = (nint)0 + (nint)904;
				num = (int)obj5;
				int num3 = ((Dictionary<System.Int32Enum, int>)(object)ranksLimit).get_Item(int32Enum);
				int32Enum2 = int32Enum;
				num2 = num3;
			}
			object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v12+E4]");
			bool flag4 = (nint)0 == 0;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Dictionary<Ranks, int> ranksLimit2 = GetRanksLimit(game);
			if (ranksLimit2 != null)
			{
				int num4 = ((Dictionary<System.Int32Enum, int>)(object)ranksLimit2).get_Item((System.Int32Enum)rank);
				object obj9 = num4 - num2;
				object obj10 = obj9 * 1717986919;
				object obj11 = obj10 >> 33;
				object obj12 = obj11 + obj11;
				object obj13 = obj12 * subRank;
				return num2 + obj13;
			}
			goto IL_0250;
		}
		object format = "___# Content push apply failed [{0}]: {1}" + 952;
		object obj14 = typeof(DataRelation) + 856;
		object obj15 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string text = string.Format((string)format, arg);
		object obj16 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v5+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		object message = text;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
		}
		Debug.LogError(message);
		return 0;
		IL_0250:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static Dictionary<Ranks, int> GetRanksLimit(Games game)
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_01ba: Expected O, but got I
		//IL_0160: Expected O, but got I
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_018d: Expected O, but got I
		//IL_003c: Expected O, but got I4
		//IL_0104: Expected O, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_0201: Expected O, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0088: Expected O, but got I4
		//IL_024b: Expected O, but got I
		switch (game)
		{
		default:
		{
			bool flag = game == Games.Baloot;
			object obj7 = !flag;
			if (obj7 == null)
			{
				object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v22+E4]");
				bool flag2 = (nint)0 == 0;
				object obj10 = !flag2;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v22+B8]");
				return (Dictionary<Ranks, int>)0;
			}
			object obj11 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
			ex..ctor();
			object obj12 = (nint)0 + (nint)1296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			return (Dictionary<Ranks, int>)(object)new OutOfMemoryException();
		}
		case Games.Tarneeb:
		{
			object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v7+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v7+B8]");
				return (Dictionary<Ranks, int>)((nint)0 + (nint)8);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v9+B8]");
			return (Dictionary<Ranks, int>)((nint)0 + (nint)8);
		}
		case Games.Jackaroo:
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v2+B8]");
				return (Dictionary<Ranks, int>)((nint)0 + (nint)16);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v4+B8]");
			return (Dictionary<Ranks, int>)((nint)0 + (nint)16);
		}
		}
	}

	public PlayerRank()
	{
	}

	public PlayerRank(Ranks rank, bool isNew = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0120: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_0157: Expected O, but got I4
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0094: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj2 = "Complete" + 3480;
		object obj3 = (nint)0 + (nint)2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F812BC");
		int points;
		if ((object)(rank >= Ranks.Intermediate) == null)
		{
			points = 0;
		}
		else
		{
			object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v10+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games game = default(Games);
			points = ((Dictionary<System.Int32Enum, int>)(object)GetRanksLimit(game)).get_Item((System.Int32Enum)(rank - 1)) + 1;
		}
		this..ctor(points, isNew);
	}

	public PlayerRank(int points, bool isNew = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_009e: Expected O, but got I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0113: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj2 = "Complete" + 3480;
		object obj3 = (nint)0 + (nint)2480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F812BC");
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		base..ctor();
		<Points>k__BackingField = points;
		<IsNew>k__BackingField = isNew;
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games game = default(Games);
		CalculateRank(GetRanksLimit(game));
	}

	public PlayerRank(Games game, int points, bool isNew = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0089: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		base..ctor();
		<Points>k__BackingField = points;
		<IsNew>k__BackingField = isNew;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CalculateRank(GetRanksLimit(game));
	}

	public int GetTotalSubRank()
	{
		//IL_0011: Expected O, but got I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected I4, but got Unknown
		object obj = <SubRanksCount>k__BackingField + <Rank>k__BackingField;
		return obj - 4;
	}

	private void CalculateRank(IDictionary<Ranks, int> limits)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01ae: Expected I, but got O
		//IL_01be: Expected O, but got I
		//IL_01e0: Expected O, but got I4
		//IL_01f2: Expected O, but got I4
		//IL_0796: Expected O, but got I
		//IL_00e4: Expected I, but got O
		//IL_00f4: Expected O, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_0222: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected O, but got Unknown
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Expected O, but got Unknown
		//IL_012f: Expected O, but got I
		//IL_0aeb: Expected O, but got I4
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a9: Expected O, but got Unknown
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Expected O, but got Unknown
		//IL_0305: Expected I, but got O
		//IL_0315: Expected O, but got I
		//IL_0337: Expected O, but got I4
		//IL_0340: Expected O, but got I4
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b14: Expected O, but got Unknown
		//IL_0b47: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4c: Expected O, but got Unknown
		//IL_0b59: Expected I4, but got O
		//IL_0b7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b82: Expected O, but got Unknown
		//IL_0b8f: Expected I4, but got O
		//IL_0b97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Expected I4, but got Unknown
		//IL_06f8: Expected O, but got I
		//IL_024f: Expected I, but got O
		//IL_025f: Expected O, but got I
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_035f: Expected O, but got I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected O, but got Unknown
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected O, but got Unknown
		//IL_029a: Expected O, but got I
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Expected O, but got Unknown
		//IL_0a34: Expected I, but got O
		//IL_0a44: Expected O, but got I
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected O, but got Unknown
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected O, but got Unknown
		//IL_0442: Expected I, but got O
		//IL_0452: Expected O, but got I
		//IL_0474: Expected O, but got I4
		//IL_047d: Expected O, but got I4
		//IL_038c: Expected I, but got O
		//IL_039c: Expected O, but got I
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0371: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_049c: Expected O, but got I4
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_03d7: Expected O, but got I
		//IL_057f: Expected I, but got O
		//IL_058f: Expected O, but got I
		//IL_05b1: Expected O, but got I4
		//IL_05ba: Expected O, but got I4
		//IL_04c9: Expected I, but got O
		//IL_04d9: Expected O, but got I
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Expected O, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		//IL_05d9: Expected O, but got I4
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_0514: Expected O, but got I
		//IL_0693: Expected I, but got O
		//IL_06a3: Expected O, but got I
		//IL_06c3: Expected O, but got I4
		//IL_06d4: Expected O, but got I4
		//IL_0619: Expected I, but got O
		//IL_0629: Expected O, but got I
		//IL_064b: Expected O, but got I4
		//IL_0654: Expected O, but got I4
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected O, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected O, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected O, but got Unknown
		//IL_0530: Unknown result type (might be due to invalid IL or missing references)
		//IL_0535: Expected O, but got Unknown
		//IL_0673: Expected O, but got I4
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2616;
		nint num = (nint)limits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v3 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X10_v43-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj3 += 16;
			obj2--;
			if ((nint)obj2 != 1)
			{
				continue;
			}
			goto IL_00ad;
		}
		object obj4 = num + obj3;
		object obj5 = obj4 + 312;
		goto IL_0871;
		IL_06e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v25 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		object obj7;
		object obj8;
		object obj11;
		object obj9;
		object obj10;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X10_v15-8]");
			if (0 == (nint)obj7)
			{
				break;
			}
			obj6 += 16;
			obj8--;
			bool flag = (nint)obj8 != 1;
			obj9 = obj7;
			obj10 = obj11;
			if (flag)
			{
				continue;
			}
			goto IL_0749;
		}
		nint num2;
		object obj12 = num2 + obj6;
		object obj13 = obj12 + 312;
		obj10 = obj11;
		goto IL_09fc;
		IL_07f7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0ab7;
		IL_0555:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_09ad;
		IL_09ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v832 @ X0_v37] (should have been resolved before IL gen)");
		object obj14 = default(object);
		if (<Points>k__BackingField > (nint)obj14)
		{
			<Rank>k__BackingField = Ranks.Master;
			obj7 = obj;
			num2 = (nint)limits;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v25 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v25 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
			bool flag2 = (nint)0 == 0;
			object obj15 = !flag2;
			obj11 = 5;
			if (obj15 != null)
			{
				goto IL_06e2;
			}
			obj9 = obj;
			obj10 = 5;
		}
		else
		{
			<Rank>k__BackingField = Ranks.Expert;
			obj7 = obj;
			num2 = (nint)limits;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v25 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v25 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
			bool flag3 = (nint)0 == 0;
			obj11 = 4;
			obj9 = obj;
			obj10 = 4;
			if (!flag3)
			{
				goto IL_06e2;
			}
		}
		goto IL_0749;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0871;
		IL_0871:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v188 @ X0_v3] (should have been resolved before IL gen)");
		object obj16 = default(object);
		if (<Points>k__BackingField > (nint)obj16)
		{
			nint num3 = (nint)limits;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v18 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v18 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0170;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v18 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+B0]");
			object obj18 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X10_v38-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj18 += 16;
				obj17--;
				if ((nint)obj17 != 1)
				{
					continue;
				}
				goto IL_0170;
			}
			object obj19 = num3 + obj18;
			object obj20 = obj19 + 312;
			goto IL_08c0;
		}
		<Rank>k__BackingField = Ranks.Beginner;
		object obj21 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj22 = obj;
		nint num4 = (nint)limits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v15 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v15 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
		bool flag4 = (nint)0 == 0;
		object obj24 = !flag4;
		Ranks ranks = Ranks.Beginner;
		object obj25 = 0;
		if (obj24 != null)
		{
			goto IL_0780;
		}
		Ranks ranks2 = Ranks.Beginner;
		object obj26 = obj21;
		object obj27 = obj;
		object obj28 = 0;
		goto IL_07f7;
		IL_095e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v753 @ X0_v34] (should have been resolved before IL gen)");
		object obj29 = default(object);
		if (<Points>k__BackingField > (nint)obj29)
		{
			nint num5 = (nint)limits;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v36 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v36 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0555;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v763 @ X8_v36 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+B0]");
			object obj31 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v806 @ X10_v23-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj31 += 16;
				obj30--;
				if ((nint)obj30 != 1)
				{
					continue;
				}
				goto IL_0555;
			}
			object obj32 = num5 + obj31;
			object obj33 = obj32 + 312;
			goto IL_09ad;
		}
		<Rank>k__BackingField = Ranks.Professional;
		obj7 = obj;
		num2 = (nint)limits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v25 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v25 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
		bool flag5 = (nint)0 == 0;
		object obj34 = !flag5;
		obj11 = 3;
		if (obj34 != null)
		{
			goto IL_06e2;
		}
		obj9 = obj;
		obj10 = 3;
		goto IL_0749;
		IL_0780:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v15 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+B0]");
		object obj35 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X10_v7-8]");
			if (0 == (nint)obj22)
			{
				break;
			}
			obj35 += 16;
			obj23--;
			bool flag6 = (nint)obj23 != 1;
			ranks2 = ranks;
			obj26 = obj21;
			obj27 = obj22;
			obj28 = obj25;
			if (flag6)
			{
				continue;
			}
			goto IL_07f7;
		}
		object obj36 = num4 + obj35;
		object obj37 = obj36 + 312;
		ranks2 = ranks;
		obj26 = obj21;
		obj28 = obj25;
		goto IL_0ab7;
		IL_0418:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_095e;
		IL_09fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v680 @ X0_v23] (should have been resolved before IL gen)");
		ranks = <Rank>k__BackingField;
		obj21 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		obj22 = obj;
		num4 = (nint)limits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v15 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
		obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v15 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
		bool flag7 = (nint)0 == 0;
		object obj38 = default(object);
		obj25 = obj38;
		ranks2 = <Rank>k__BackingField;
		obj26 = obj21;
		obj27 = obj;
		obj28 = obj38;
		if (!flag7)
		{
			goto IL_0780;
		}
		goto IL_07f7;
		IL_02db:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_090f;
		IL_090f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v658 @ X0_v31] (should have been resolved before IL gen)");
		object obj39 = default(object);
		if (<Points>k__BackingField > (nint)obj39)
		{
			nint num6 = (nint)limits;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X8_v32 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X8_v32 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0418;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X8_v32 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+B0]");
			object obj41 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X10_v28-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj41 += 16;
				obj40--;
				if ((nint)obj40 != 1)
				{
					continue;
				}
				goto IL_0418;
			}
			object obj42 = num6 + obj41;
			object obj43 = obj42 + 312;
			goto IL_095e;
		}
		<Rank>k__BackingField = Ranks.Advanced;
		obj7 = obj;
		num2 = (nint)limits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v25 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v25 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
		bool flag8 = (nint)0 == 0;
		object obj44 = !flag8;
		obj11 = 2;
		if (obj44 != null)
		{
			goto IL_06e2;
		}
		obj9 = obj;
		obj10 = 2;
		goto IL_0749;
		IL_0749:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_09fc;
		IL_0170:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_08c0;
		IL_08c0:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v386 @ X0_v20] (should have been resolved before IL gen)");
		object obj45 = default(object);
		if (<Points>k__BackingField > (nint)obj45)
		{
			nint num7 = (nint)limits;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v28 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
			object obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v28 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02db;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v28 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+B0]");
			object obj47 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X10_v33-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj47 += 16;
				obj46--;
				if ((nint)obj46 != 1)
				{
					continue;
				}
				goto IL_02db;
			}
			object obj48 = num7 + obj47;
			object obj49 = obj48 + 312;
			goto IL_090f;
		}
		<Rank>k__BackingField = Ranks.Intermediate;
		obj7 = obj;
		num2 = (nint)limits;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v25 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v540 @ X8_v25 (Il2CppClass<System.Collections.Generic.IDictionary`2<PlayerRank+Ranks, System.Int32>>)+12E]");
		bool flag9 = (nint)0 == 0;
		object obj50 = !flag9;
		obj11 = 1;
		if (obj50 != null)
		{
			goto IL_06e2;
		}
		obj9 = obj;
		obj10 = 1;
		goto IL_0749;
		IL_0ab7:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v426 @ X0_v6] (should have been resolved before IL gen)");
		object obj51 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v8+E4]");
		bool flag10 = (nint)0 == 0;
		object obj52 = !flag10;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj54 = default(object);
		object obj53 = obj54 - obj28;
		object obj55 = obj53 * 1717986919;
		object obj56 = obj55 >> 32;
		object obj57 = obj55 >> 63;
		object obj58 = obj57 + obj56;
		object obj59 = <Points>k__BackingField - obj28;
		int val = obj59 / obj58;
		object obj60 = (<SubRanksCount>k__BackingField = Math.Min(4, val)) * obj58;
		int num8 = (int)(obj28 + obj60);
		int num9 = num8 + obj58;
		<MinSubRankLimit>k__BackingField = num8;
		<MaxSubRankLimit>k__BackingField = num9;
	}

	public static PlayerRank FastTrackAward()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		User mySelf = SFS.MySelf;
		int fTLevel = SFSKammelnaUserExtensions.GetFTLevel(mySelf);
		User mySelf2 = SFS.MySelf;
		int fTStage = SFSKammelnaUserExtensions.GetFTStage(mySelf2);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			return FastTrackAward(fTLevel, fTStage);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return FastTrackAward(fTLevel, fTStage);
	}

	public static PlayerRank FastTrackAward(int level, int stage)
	{
		//IL_02a8: Expected I4, but got I8
		//IL_02c2: Expected O, but got I4
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_00e3: Expected O, but got I
		//IL_00eb: Expected I, but got O
		//IL_0150: Expected O, but got I4
		//IL_0223: Expected O, but got I
		//IL_022b: Expected I, but got O
		int num = level - 1;
		int num3 = default(int);
		int num2 = num3 - 1;
		int num4 = num2 | num;
		int num5 = (int)(num4 & 0x80000000L);
		bool flag = num5 == 0;
		object obj = !flag;
		int points;
		if (obj == null)
		{
			object obj2 = typeof(RegisteredWaitHandle) + 56;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RemoteConfigModel current = RemoteConfig.Current;
			if (current != null)
			{
				FastTrackConfig <FastTrack>k__BackingField = current.<FastTrack>k__BackingField;
				if (current.<FastTrack>k__BackingField != null && <FastTrack>k__BackingField.<LevelStages>k__BackingField != null)
				{
					object obj5 = (nint)0 + (nint)2944;
					nint num6 = (nint)obj5;
					object obj6 = ((List<object>)(object)<FastTrack>k__BackingField.<LevelStages>k__BackingField).get_Item(num);
					bool flag3 = obj6 == null;
					num3 = num;
					if (flag3)
					{
						goto IL_0251;
					}
					object obj7 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v15+E4]");
					bool flag4 = (nint)0 == 0;
					object obj8 = !flag4;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					RemoteConfigModel current2 = RemoteConfig.Current;
					if (current2 != null)
					{
						FastTrackConfig <FastTrack>k__BackingField2 = current2.<FastTrack>k__BackingField;
						if (current2.<FastTrack>k__BackingField != null && <FastTrack>k__BackingField2.<LevelStages>k__BackingField != null)
						{
							object obj9 = ((List<object>)(object)<FastTrack>k__BackingField2.<LevelStages>k__BackingField).get_Item(num);
							if (obj9 != null)
							{
								object obj10 = (nint)0 + (nint)1488;
								num6 = (nint)obj10;
								int num7 = ((List<int>)obj9).get_Item(num2);
								num3 = num2;
								points = num7;
								goto IL_02d0;
							}
						}
					}
				}
			}
			return (PlayerRank)(object)new NullReferenceException();
		}
		goto IL_0251;
		IL_0251:
		points = 0;
		goto IL_02d0;
		IL_02d0:
		object obj11 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(points);
		return playerRank;
	}

	public static PlayerRank FastTrackClaimAward()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		User mySelf = SFS.MySelf;
		int fTLevel = SFSKammelnaUserExtensions.GetFTLevel(mySelf);
		User mySelf2 = SFS.MySelf;
		int fTStage = SFSKammelnaUserExtensions.GetFTStage(mySelf2);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			return FastTrackClaimAward(fTLevel, fTStage);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		return FastTrackClaimAward(fTLevel, fTStage);
	}

	public static PlayerRank FastTrackClaimAward(int level, int stage)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		User mySelf = SFS.MySelf;
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(mySelf);
		if (rank != null)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerRank playerRank = FastTrackAward(level, stage);
			if (playerRank != null)
			{
				if (rank.<Points>k__BackingField <= playerRank.<Points>k__BackingField)
				{
					object obj4 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v11+E4]");
					if ((nint)0 != 0)
					{
						return FastTrackAward(level, stage);
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					return FastTrackAward(level, stage);
				}
				User mySelf2 = SFS.MySelf;
				PlayerRank rank2 = SFSKammelnaUserExtensions.GetRank(mySelf2);
				if (rank2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					PlayerRank playerRank2 = default(PlayerRank);
					playerRank2..ctor(rank2.<Points>k__BackingField);
					return playerRank2;
				}
			}
		}
		return (PlayerRank)(object)new NullReferenceException();
	}

	public static int[] GetNearestFTAwardStage(int points = -1)
	{
		//IL_05a1: Expected O, but got I4
		//IL_05bb: Expected O, but got I4
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected O, but got Unknown
		//IL_05f1: Expected O, but got I
		//IL_05fd: Expected O, but got I
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected O, but got Unknown
		//IL_063b: Expected O, but got I4
		//IL_004f: Expected I, but got O
		//IL_014d: Expected O, but got I4
		//IL_0156: Expected O, but got I4
		//IL_015f: Expected O, but got I4
		//IL_0548: Expected I4, but got I8
		//IL_0569: Expected O, but got I8
		//IL_04e6: Expected I4, but got O
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected I4, but got Unknown
		//IL_0424: Expected O, but got I4
		//IL_0295: Expected O, but got I4
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03c9: Expected O, but got I4
		//IL_04a3: Expected O, but got I4
		//IL_04b5: Expected I4, but got O
		object obj = points + 1;
		bool flag = obj == null;
		object obj2 = !flag;
		int num = points;
		nint num2 = default(nint);
		if (obj2 == null)
		{
			User mySelf = SFS.MySelf;
			PlayerRank rank = SFSKammelnaUserExtensions.GetRank(mySelf);
			if (rank == null)
			{
				goto IL_0585;
			}
			num = rank.<Points>k__BackingField;
			num2 = unchecked((nint)null);
		}
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		object obj4 = (nint)0 + (nint)2944;
		object obj5 = (nint)0 + (nint)1488;
		object obj6 = typeof(TypeConverter<ushort, char>) + 3048;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v32+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		int num3 = 0;
		object obj10 = default(object);
		object obj9 = obj10;
		nint num4 = num2;
		int num5 = 0;
		if (obj8 == null)
		{
			goto IL_0054;
		}
		goto IL_007b;
		IL_0585:
		return (int[])(object)new NullReferenceException();
		IL_0442:
		num2 = num3;
		goto IL_0054;
		IL_007b:
		int[] array = default(int[]);
		while (true)
		{
			RemoteConfigModel current = RemoteConfig.Current;
			if (current == null)
			{
				break;
			}
			FastTrackConfig <FastTrack>k__BackingField = current.<FastTrack>k__BackingField;
			if (current.<FastTrack>k__BackingField == null)
			{
				break;
			}
			List<List<int>> <LevelStages>k__BackingField = <FastTrack>k__BackingField.<LevelStages>k__BackingField;
			if (<FastTrack>k__BackingField.<LevelStages>k__BackingField == null)
			{
				break;
			}
			object obj13;
			object obj14;
			if (num5 < <LevelStages>k__BackingField._size)
			{
				object obj11 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v30+E4]");
				bool flag3 = (nint)0 == 0;
				object obj12 = !flag3;
				obj13 = 1;
				obj14 = 1;
				if (obj12 == null)
				{
					goto IL_016d;
				}
				goto IL_0184;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			if (array == null)
			{
				break;
			}
			if (array.Length != 0)
			{
				array[0] = -1;
				bool flag4 = array.Length != 1;
				obj14 = 4294967295L;
				if (flag4)
				{
					goto IL_04d4;
				}
			}
			goto IL_0577;
			IL_044f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			if (array == null)
			{
				break;
			}
			if (array.Length != 0)
			{
				object obj15 = num5 + 1;
				array[0] = (int)obj15;
				if (array.Length != 1)
				{
					goto IL_04d4;
				}
			}
			goto IL_0577;
			IL_04d4:
			array[1] = (int)obj14;
			return array;
			IL_0577:
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			break;
			IL_03ec:
			num3 = num5 + 1;
			obj7 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v32+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			num4 = num5;
			num5 = num3;
			if (obj16 != null)
			{
				continue;
			}
			goto IL_0442;
			IL_0184:
			int num6;
			while (true)
			{
				RemoteConfigModel current2 = RemoteConfig.Current;
				if (current2 == null)
				{
					break;
				}
				FastTrackConfig <FastTrack>k__BackingField2 = current2.<FastTrack>k__BackingField;
				if (current2.<FastTrack>k__BackingField == null || <FastTrack>k__BackingField2.<LevelStages>k__BackingField == null)
				{
					break;
				}
				obj9 = obj4;
				object obj17 = ((List<object>)(object)<FastTrack>k__BackingField2.<LevelStages>k__BackingField).get_Item(num5);
				if (obj17 == null)
				{
					break;
				}
				num6 = obj14 - 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v17 (System.Object)+18]");
				if ((nint)num6 >= (nint)0)
				{
					goto IL_03ec;
				}
				object obj18 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X0_v19+E4]");
				bool flag6 = (nint)0 == 0;
				object obj19 = !flag6;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				RemoteConfigModel current3 = RemoteConfig.Current;
				if (current3 == null)
				{
					break;
				}
				FastTrackConfig <FastTrack>k__BackingField3 = current3.<FastTrack>k__BackingField;
				if (current3.<FastTrack>k__BackingField == null || <FastTrack>k__BackingField3.<LevelStages>k__BackingField == null)
				{
					break;
				}
				object obj20 = ((List<object>)(object)<FastTrack>k__BackingField3.<LevelStages>k__BackingField).get_Item(num5);
				if (obj20 == null)
				{
					break;
				}
				obj9 = obj5;
				int num7 = ((List<int>)obj20).get_Item(num6);
				if (num >= num7)
				{
					obj14++;
					object obj11 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X0_v30+E4]");
					bool flag7 = (nint)0 == 0;
					object obj21 = !flag7;
					if (obj21 != null)
					{
						continue;
					}
					goto IL_03d7;
				}
				goto IL_044f;
			}
			break;
			IL_03d7:
			obj13 = obj14;
			num4 = num6;
			goto IL_016d;
			IL_016d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj14 = obj13;
			goto IL_0184;
		}
		goto IL_0585;
		IL_0054:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj9 = obj9;
		num4 = num2;
		num5 = num3;
		goto IL_007b;
	}

	static PlayerRank()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0026: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0191: Expected O, but got I
		//IL_025f: Expected O, but got I
		//IL_02d2: Expected O, but got I
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 3736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, int> dictionary = default(Dictionary<System.Int32Enum, int>);
		dictionary..ctor();
		object obj2 = (nint)0 + (nint)896;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		dictionary.Add((System.Int32Enum)1, 1000);
		dictionary.Add((System.Int32Enum)2, 4000);
		dictionary.Add((System.Int32Enum)3, 10000);
		dictionary.Add((System.Int32Enum)4, 20000);
		dictionary.Add((System.Int32Enum)5, 40000);
		dictionary.Add((System.Int32Enum)6, 59995);
		object obj4 = obj3;
		object obj5 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, int> dictionary2 = default(Dictionary<System.Int32Enum, int>);
		dictionary2..ctor();
		dictionary2.Add((System.Int32Enum)1, 500);
		dictionary2.Add((System.Int32Enum)2, 1500);
		dictionary2.Add((System.Int32Enum)3, 3500);
		dictionary2.Add((System.Int32Enum)4, 6000);
		dictionary2.Add((System.Int32Enum)5, 10000);
		dictionary2.Add((System.Int32Enum)6, 15000);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v5+B8]");
		object obj7 = (nint)0 + (nint)8;
		obj7 = dictionary2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, int> dictionary3 = default(Dictionary<System.Int32Enum, int>);
		dictionary3..ctor();
		dictionary3.Add((System.Int32Enum)1, 500);
		dictionary3.Add((System.Int32Enum)2, 1500);
		dictionary3.Add((System.Int32Enum)3, 3500);
		dictionary3.Add((System.Int32Enum)4, 6000);
		dictionary3.Add((System.Int32Enum)5, 10000);
		dictionary3.Add((System.Int32Enum)6, 15000);
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v6+B8]");
		object obj9 = (nint)0 + (nint)16;
		obj9 = dictionary3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(0);
		playerRank.<Rank>k__BackingField = Ranks.AI;
		playerRank.<IsNew>k__BackingField = false;
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v7+B8]");
		object obj11 = (nint)0 + (nint)24;
		obj11 = playerRank;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
