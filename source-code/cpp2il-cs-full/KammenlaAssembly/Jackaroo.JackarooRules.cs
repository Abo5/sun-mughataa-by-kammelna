using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

namespace Jackaroo;

public class JackarooRules
{
	private readonly JackarooBoard _board;

	private static JackarooAllowedRules <AllowedRules>k__BackingField;

	private List<JackarooMove> _allowedMoves;

	private List<JackarooNode> _nodes1;

	private List<JackarooNode> _nodes2;

	private readonly List<JackarooActions> _splitActions;

	public static JackarooAllowedRules AllowedRules
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			//IL_0036: Expected I4, but got O
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			object obj3 = 0;
			return (JackarooAllowedRules)obj3;
		}
		private set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			//IL_0039: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			obj3 = value;
		}
	}

	public JackarooRules(JackarooBoard board, JackarooAllowedRules allowedRules)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0752: Unknown result type (might be due to invalid IL or missing references)
		//IL_0757: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I
		//IL_00f5: Expected O, but got I
		//IL_010a: Expected O, but got I
		//IL_0138: Expected O, but got I4
		//IL_01b4: Expected O, but got I
		//IL_01c4: Expected O, but got I
		//IL_01fa: Expected O, but got I
		//IL_0210: Expected O, but got I
		//IL_0243: Expected O, but got I4
		//IL_015c: Expected O, but got I
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0192: Expected O, but got I
		//IL_02b7: Expected O, but got I
		//IL_02c7: Expected O, but got I
		//IL_02fd: Expected O, but got I
		//IL_0313: Expected O, but got I
		//IL_0346: Expected O, but got I4
		//IL_0267: Expected O, but got I
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_029d: Expected O, but got I
		//IL_03ba: Expected O, but got I
		//IL_03ca: Expected O, but got I
		//IL_0400: Expected O, but got I
		//IL_0416: Expected O, but got I
		//IL_0449: Expected O, but got I4
		//IL_036a: Expected O, but got I
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_03a0: Expected O, but got I
		//IL_04bd: Expected O, but got I
		//IL_04cd: Expected O, but got I
		//IL_0503: Expected O, but got I
		//IL_0519: Expected O, but got I
		//IL_054c: Expected O, but got I4
		//IL_046d: Expected O, but got I
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Expected O, but got Unknown
		//IL_04a3: Expected O, but got I
		//IL_05c0: Expected O, but got I
		//IL_05d0: Expected O, but got I
		//IL_0606: Expected O, but got I
		//IL_061c: Expected O, but got I
		//IL_064f: Expected O, but got I4
		//IL_0570: Expected O, but got I
		//IL_0585: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_05a6: Expected O, but got I
		//IL_06a8: Expected O, but got I
		//IL_06b8: Expected O, but got I
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e6: Expected O, but got Unknown
		//IL_0673: Expected O, but got I
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_068d: Expected O, but got Unknown
		//IL_0709: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Expected O, but got Unknown
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		//IL_0786: Expected O, but got I
		//IL_078e: Expected O, but got I4
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1960;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 1976;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 1904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = this + 24;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj5 = this + 32;
		obj5 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list3 = default(List<object>);
		list3..ctor();
		object obj6 = this + 40;
		obj6 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<System.Int32Enum> list4 = default(List<System.Int32Enum>);
		list4..ctor();
		object obj7 = (nint)0 + (nint)1960;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
		object obj9 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X9_v9+18]");
		if ((object)(num >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj11 = (nint)0 + (nint)1;
			object obj12 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj13 = obj12 + 0;
			_ = 64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj14 = (nint)0 + (nint)1;
			JackarooAllowedRules jackarooAllowedRules = allowedRules;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v9+20]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v32+C0]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v33+70]");
			JackarooAllowedRules jackarooAllowedRules = JackarooAllowedRules.DEFAULT;
			list4.AddWithResize((System.Int32Enum)64);
			obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj17 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X9_v9+18]");
		if ((object)(num2 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj18 = (nint)0 + (nint)1;
			object obj19 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj20 = obj19 + 0;
			_ = 128;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj21 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v9+20]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X8_v29+C0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v30+70]");
			JackarooAllowedRules jackarooAllowedRules = JackarooAllowedRules.DEFAULT;
			list4.AddWithResize((System.Int32Enum)128);
			obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj24 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X9_v9+18]");
		if ((object)(num3 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj25 = (nint)0 + (nint)1;
			object obj26 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj27 = obj26 + 0;
			_ = 256;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj28 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v9+20]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v26+C0]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v27+70]");
			JackarooAllowedRules jackarooAllowedRules = JackarooAllowedRules.DEFAULT;
			list4.AddWithResize((System.Int32Enum)256);
			obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj31 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X9_v9+18]");
		if ((object)(num4 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj32 = (nint)0 + (nint)1;
			object obj33 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj34 = obj33 + 0;
			_ = 512;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj35 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v9+20]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v23+C0]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v24+70]");
			JackarooAllowedRules jackarooAllowedRules = JackarooAllowedRules.DEFAULT;
			list4.AddWithResize((System.Int32Enum)512);
			obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj38 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X9_v9+18]");
		if ((object)(num5 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj39 = (nint)0 + (nint)1;
			object obj40 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj41 = obj40 + 0;
			_ = 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj42 = (nint)0 + (nint)1;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v9+20]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v20+C0]");
			object obj44 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X8_v21+70]");
			JackarooAllowedRules jackarooAllowedRules = JackarooAllowedRules.DEFAULT;
			list4.AddWithResize((System.Int32Enum)1024);
			obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+10]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+1C]");
			object obj45 = (nint)0 + (nint)1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
		nint num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X9_v9+18]");
		if ((object)(num6 >= 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj46 = (nint)0 + (nint)1;
			object obj47 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v18 (System.Collections.Generic.List`1<System.Int32Enum>)+18]");
			object obj48 = obj47 + 0;
			_ = 2048;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v9+20]");
			object obj49 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v16+C0]");
			object obj50 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v17+70]");
			JackarooAllowedRules jackarooAllowedRules = JackarooAllowedRules.DEFAULT;
			list4.AddWithResize((System.Int32Enum)2048);
		}
		object obj51 = this + 48;
		obj51 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		object obj52 = this + 16;
		obj52 = board;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj53 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X8_v13+B8]");
		object obj54 = 0;
		obj54 = allowedRules;
	}

	private static int GetNextPlayerIndex(int rotatedPlayerIndex)
	{
		if (rotatedPlayerIndex == 1)
		{
			return 2;
		}
		return 4;
	}

	public static int GetJackarooMoveFromCard(Card card, JackarooActions jackarooAction = JackarooActions.NONE)
	{
		//IL_00cb: Expected I4, but got O
		//IL_00ab: Expected I4, but got I8
		switch (jackarooAction)
		{
		case JackarooActions.MOVE_CHOICE_11:
			return 11;
		case JackarooActions.MOVE_CHOICE_1:
			return 1;
		default:
		{
			if (card != null)
			{
				int result = (int)(card.<Rank>k__BackingField + 2);
				if (card.<Rank>k__BackingField == Rank.FOUR)
				{
					return -4;
				}
				return result;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
		}
	}

	public unsafe List<JackarooMove> GetAllowedJackarooMoves(int rotatedPlayerIndex, IReadOnlyCollection<Card> cards, IReadOnlyCollection<Card> nextPlayerCards, Action<Card, JackarooMarbleMono> onGuardedMarbleAdded = null)
	{
		//IL_179a: Unknown result type (might be due to invalid IL or missing references)
		//IL_179f: Expected O, but got Unknown
		//IL_17a7: Expected I4, but got O
		//IL_17be: Expected O, but got I4
		//IL_17d6: Expected I4, but got O
		//IL_002b: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		//IL_008d: Expected O, but got I
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e1: Expected I, but got O
		//IL_00f1: Expected O, but got I
		//IL_16fb: Expected O, but got I4
		//IL_01a2: Expected O, but got I4
		//IL_01b4: Expected O, but got I
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_029a: Expected I, but got O
		//IL_02aa: Expected O, but got I
		//IL_0155: Expected O, but got I
		//IL_1888: Expected I4, but got O
		//IL_18ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b0: Expected O, but got Unknown
		//IL_140b: Expected O, but got I4
		//IL_1414: Expected O, but got I4
		//IL_035b: Expected O, but got I4
		//IL_036d: Expected O, but got I
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_1ca7: Expected O, but got I4
		//IL_030e: Expected O, but got I
		//IL_1459: Unknown result type (might be due to invalid IL or missing references)
		//IL_145e: Expected O, but got Unknown
		//IL_1466: Expected I, but got O
		//IL_1476: Expected O, but got I
		//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_03c1: Expected I, but got O
		//IL_03d1: Expected O, but got I
		//IL_1d29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d2e: Expected O, but got Unknown
		//IL_1527: Expected O, but got I4
		//IL_1539: Expected O, but got I
		//IL_1542: Unknown result type (might be due to invalid IL or missing references)
		//IL_1547: Expected O, but got Unknown
		//IL_053c: Expected O, but got I4
		//IL_0556: Expected O, but got I4
		//IL_0482: Expected O, but got I4
		//IL_0494: Expected O, but got I
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_14da: Expected O, but got I
		//IL_04bd: Expected O, but got I4
		//IL_04d7: Expected O, but got I4
		//IL_0435: Expected O, but got I
		//IL_1983: Expected O, but got I4
		//IL_19af: Expected O, but got I4
		//IL_194d: Expected O, but got I4
		//IL_1967: Expected O, but got I4
		//IL_190f: Expected O, but got I4
		//IL_1929: Expected O, but got I4
		//IL_1a94: Expected O, but got I4
		//IL_0851: Expected I4, but got O
		//IL_19f1: Expected O, but got I4
		//IL_050c: Expected O, but got I4
		//IL_1b5b: Expected O, but got I4
		//IL_1b75: Expected O, but got I4
		//IL_0b2b: Expected O, but got I4
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected O, but got Unknown
		//IL_05a7: Expected I, but got O
		//IL_05b7: Expected O, but got I
		//IL_1b91: Expected O, but got I4
		//IL_1c58: Expected O, but got I4
		//IL_1c7f: Expected O, but got I4
		//IL_1a3c: Expected I4, but got O
		//IL_1a4c: Expected O, but got I
		//IL_0e60: Expected O, but got I4
		//IL_0887: Unknown result type (might be due to invalid IL or missing references)
		//IL_088c: Expected O, but got Unknown
		//IL_0894: Expected I, but got O
		//IL_08a4: Expected O, but got I
		//IL_0ef1: Expected O, but got I4
		//IL_06ce: Expected I4, but got O
		//IL_0668: Expected O, but got I4
		//IL_067a: Expected O, but got I
		//IL_0683: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		//IL_0f7a: Expected O, but got I4
		//IL_0f91: Expected O, but got I
		//IL_0fa1: Expected I4, but got O
		//IL_1b0b: Expected I4, but got O
		//IL_1b1b: Expected O, but got I
		//IL_165d: Expected I4, but got O
		//IL_061b: Expected O, but got I
		//IL_1029: Expected O, but got I4
		//IL_0b54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b59: Expected O, but got Unknown
		//IL_0b61: Expected I, but got O
		//IL_0b71: Expected O, but got I
		//IL_06e8: Expected O, but got I
		//IL_06f0: Expected I4, but got O
		//IL_10c0: Expected O, but got I4
		//IL_09b3: Expected I4, but got O
		//IL_0955: Expected O, but got I4
		//IL_0967: Expected O, but got I
		//IL_0970: Unknown result type (might be due to invalid IL or missing references)
		//IL_0975: Expected O, but got Unknown
		//IL_1157: Expected O, but got I4
		//IL_1c00: Expected I4, but got O
		//IL_1c10: Expected O, but got I
		//IL_1c34: Expected I4, but got O
		//IL_16db: Expected I4, but got O
		//IL_0908: Expected O, but got I
		//IL_076d: Expected O, but got I4
		//IL_11ee: Expected O, but got I4
		//IL_09cd: Expected O, but got I
		//IL_09d5: Expected I4, but got O
		//IL_07ff: Expected O, but got I
		//IL_1285: Expected O, but got I4
		//IL_129c: Expected I, but got O
		//IL_12ac: Expected O, but got I4
		//IL_12b4: Expected I4, but got O
		//IL_12bc: Expected I4, but got O
		//IL_0c22: Expected O, but got I4
		//IL_0c34: Expected O, but got I
		//IL_0c3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c42: Expected O, but got Unknown
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b2: Expected O, but got Unknown
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected O, but got Unknown
		//IL_169c: Expected I4, but got O
		//IL_0bd5: Expected O, but got I
		//IL_0a52: Expected O, but got I4
		//IL_130c: Expected I, but got O
		//IL_131f: Expected O, but got I4
		//IL_1329: Expected I4, but got O
		//IL_1331: Expected I4, but got O
		//IL_0c8d: Expected O, but got I
		//IL_0c95: Expected I4, but got O
		//IL_0adc: Expected O, but got I
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Expected O, but got Unknown
		//IL_0aa0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa5: Expected O, but got Unknown
		//IL_0247: Expected O, but got I4
		//IL_0d12: Expected O, but got I4
		//IL_0db1: Expected O, but got I
		//IL_0de6: Expected I4, but got O
		//IL_13c8: Expected I, but got O
		//IL_13e4: Expected I4, but got O
		//IL_0d52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d57: Expected O, but got Unknown
		//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d65: Expected O, but got Unknown
		//IL_0d7f: Expected I4, but got O
		object obj = this + 24;
		Rank rank = (Rank)obj;
		bool flag = obj == null;
		JackarooActions jackarooActions = default(JackarooActions);
		List<object> list = (List<object>)jackarooActions;
		IReadOnlyCollection<Card> readOnlyCollection = nextPlayerCards;
		int num = rotatedPlayerIndex;
		int num2 = (int)cards;
		object[] array;
		int num6 = default(int);
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v5 (Rank)+18]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v5 (Rank)+1C]");
			array = (object[])((nint)0 + (nint)1);
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v5 (Rank)+18]");
			bool flag2 = (nint)0 < (nint)1;
			readOnlyCollection = nextPlayerCards;
			num = rotatedPlayerIndex;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v5 (Rank)+10]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v5 (Rank)+18]");
				Array.Clear((Array)num3, 0, 0);
				readOnlyCollection = null;
				num = 0;
			}
			bool flag3 = cards == null;
			list = (List<object>)jackarooActions;
			if (!flag3)
			{
				object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 2992;
				nint num4 = (nint)cards;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v17 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+12E]");
				array = (object[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v17 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_017d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v17 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+B0]");
				int num5 = (int)((nint)0 + (nint)8);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X10_v54 (System.Int32)-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					num6 = num5 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v17 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+12E]");
					array = (object[])(-1);
					bool flag4 = (nint)array != 1;
					num5 = num6;
					if (flag4)
					{
						continue;
					}
					goto IL_017d;
				}
				array = (object[])((int*)num5)->m_value;
				object obj3 = num4 + ((int*)num5)->m_value;
				object obj4 = obj3 + 312;
				num6 = num5;
				goto IL_1814;
			}
		}
		goto IL_17e4;
		IL_162b:
		NullReferenceException ex = new NullReferenceException();
		nint num8;
		nint num7 = num8;
		Action<Card, JackarooMarbleMono> action2;
		Action<Card, JackarooMarbleMono> action = action2;
		int num9;
		num6 = num9;
		IReadOnlyCollection<Card> readOnlyCollection2;
		readOnlyCollection = readOnlyCollection2;
		JackarooMove burnCardMove;
		num = (int)burnCardMove;
		object[] array2;
		array = array2;
		goto IL_16e0;
		IL_1614:
		NullReferenceException ex2 = new NullReferenceException();
		num6 = num9;
		goto IL_16e0;
		IL_16e0:
		Card card2 = default(Card);
		Card card = card2;
		IReadOnlyCollection<Card> readOnlyCollection3 = cards;
		object obj5 = 0;
		Action<Card, JackarooMarbleMono> action3 = action;
		goto IL_17e4;
		IL_17e4:
		throw new NullReferenceException();
		IL_166a:
		NullReferenceException ex3 = new NullReferenceException();
		num7 = num8;
		action = action2;
		num6 = num9;
		readOnlyCollection = readOnlyCollection2;
		JackarooMove stealMove;
		num = (int)stealMove;
		object[] array3;
		array = array3;
		goto IL_16e0;
		IL_16a9:
		NullReferenceException ex4 = new NullReferenceException();
		num7 = num8;
		action = action2;
		num6 = num9;
		readOnlyCollection = readOnlyCollection2;
		JackarooMove burnCardMove2;
		num = (int)burnCardMove2;
		goto IL_16e0;
		IL_15dd:
		NullReferenceException ex5 = new NullReferenceException();
		num7 = num8;
		action = action2;
		num6 = num9;
		readOnlyCollection = readOnlyCollection2;
		int num10;
		num2 = num10;
		goto IL_16e0;
		IL_15cf:
		NullReferenceException ex6 = new NullReferenceException();
		goto IL_16e0;
		IL_017d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 0;
		goto IL_1814;
		IL_1814:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v30+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v348 @ X0_v30] (should have been resolved before IL gen)");
		bool flag5 = card2 == null;
		action = action3;
		rank = (Rank)(int)(&card);
		if (flag5)
		{
			goto IL_15cf;
		}
		num8 = num7;
		action2 = action3;
		JackarooActions jackarooActions2 = jackarooActions;
		IReadOnlyCollection<Card> readOnlyCollection4 = null;
		Card card3 = card2;
		num9 = num6;
		readOnlyCollection2 = readOnlyCollection;
		num10 = num2;
		JackarooActions jackarooActions3 = JackarooActions.NONE;
		IReadOnlyCollection<Card> readOnlyCollection5 = null;
		object obj8 = default(object);
		Card card5 = default(Card);
		object obj20 = default(object);
		object obj24 = default(object);
		object obj25 = default(object);
		object obj33 = default(object);
		object obj34 = default(object);
		object obj35 = default(object);
		object obj57 = default(object);
		while (true)
		{
			object obj6 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			nint num11 = (nint)card3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v26 (Il2CppClass<Card>)+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v26 (Il2CppClass<Card>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0336;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v26 (Il2CppClass<Card>)+B0]");
			int num12 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v701 @ X10_v49 (System.Int32)-8]");
				if (0 == (nint)obj6)
				{
					break;
				}
				num9 = num12 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X8_v26 (Il2CppClass<Card>)+12E]");
				array = (object[])(-1);
				bool flag6 = (nint)array != 1;
				num12 = num9;
				if (flag6)
				{
					continue;
				}
				goto IL_0336;
			}
			array = (object[])((int*)num12)->m_value;
			object obj7 = num11 + ((int*)num12)->m_value;
			obj8 = obj7 + 312;
			num9 = num12;
			goto IL_1880;
			IL_0643:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num2 = 0;
			goto IL_1a34;
			IL_0930:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num2 = 0;
			goto IL_1b03;
			IL_1c4a:
			object obj9 = jackarooActions2 & JackarooActions.PLANT;
			bool flag7 = obj9 == null;
			List<JackarooMove> list2 = (List<JackarooMove>)readOnlyCollection2;
			object obj10;
			List<JackarooMove> list3 = (List<JackarooMove>)obj10;
			Card card4 = (Card)num2;
			if (!flag7)
			{
				List<JackarooMove> allowedPlantAction = GetAllowedPlantAction(_board, rotatedPlayerIndex, card5, _allowedMoves);
				obj = _allowedMoves;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				list2 = _allowedMoves;
				list3 = _allowedMoves;
				card4 = card5;
			}
			object obj11 = jackarooActions2 & JackarooActions.SWAP;
			bool flag8 = obj11 == null;
			Action<Card, JackarooMarbleMono> action4 = action2;
			if (!flag8)
			{
				List<JackarooMove> allowedSwapAction = GetAllowedSwapAction(_board, rotatedPlayerIndex, card5, _allowedMoves, action3);
				obj = _allowedMoves;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				action4 = action3;
				list2 = _allowedMoves;
				list3 = _allowedMoves;
				card4 = card5;
			}
			object obj12 = jackarooActions2 & JackarooActions.MOVE_ANY;
			if (obj12 != null)
			{
				List<JackarooMove> allowedMoveAnyAction = GetAllowedMoveAnyAction(_board, rotatedPlayerIndex, card5, _allowedMoves, action3);
				obj = _allowedMoves;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				action4 = action3;
				list2 = _allowedMoves;
				list3 = _allowedMoves;
				card4 = card5;
			}
			object obj13 = jackarooActions2 & JackarooActions.MOVE;
			bool flag9 = obj13 == null;
			Action<Card, JackarooMarbleMono> action5 = (Action<Card, JackarooMarbleMono>)num8;
			List<JackarooMove> list4 = (List<JackarooMove>)(object)action4;
			JackarooActions jackarooActions4 = (JackarooActions)list2;
			if (!flag9)
			{
				List<JackarooMove> allowedMoveAction = GetAllowedMoveAction(_board, rotatedPlayerIndex, card5, JackarooActions.MOVE, _allowedMoves, action3);
				obj = _allowedMoves;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				action5 = action3;
				list4 = _allowedMoves;
				jackarooActions4 = JackarooActions.MOVE;
				list3 = _allowedMoves;
				card4 = card5;
			}
			object obj14 = jackarooActions2 & JackarooActions.MOVE_CHOICE_1;
			if (obj14 != null)
			{
				List<JackarooMove> allowedMoveAction2 = GetAllowedMoveAction(_board, rotatedPlayerIndex, card5, JackarooActions.MOVE_CHOICE_1, _allowedMoves, action3);
				obj = _allowedMoves;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				action5 = action3;
				list4 = _allowedMoves;
				jackarooActions4 = JackarooActions.MOVE_CHOICE_1;
				list3 = _allowedMoves;
				card4 = card5;
			}
			object obj15 = jackarooActions2 & JackarooActions.MOVE_CHOICE_11;
			if (obj15 != null)
			{
				List<JackarooMove> allowedMoveAction3 = GetAllowedMoveAction(_board, rotatedPlayerIndex, card5, JackarooActions.MOVE_CHOICE_11, _allowedMoves, action3);
				obj = _allowedMoves;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				action5 = action3;
				list4 = _allowedMoves;
				jackarooActions4 = JackarooActions.MOVE_CHOICE_11;
				list3 = _allowedMoves;
				card4 = card5;
			}
			object obj16 = jackarooActions2 & JackarooActions.MOVE_REVERSE;
			if (obj16 != null)
			{
				List<JackarooMove> allowedMoveReverseAction = GetAllowedMoveReverseAction(_board, rotatedPlayerIndex, card5, JackarooActions.MOVE_REVERSE, _allowedMoves, action3);
				obj = _allowedMoves;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				action5 = action3;
				list4 = _allowedMoves;
				jackarooActions4 = JackarooActions.MOVE_REVERSE;
				list3 = _allowedMoves;
				card4 = card5;
			}
			object obj17 = jackarooActions2 & JackarooActions.MOVE_EAT_PATH;
			if (obj17 != null)
			{
				List<JackarooMove> allowedMoveAction4 = GetAllowedMoveAction(_board, rotatedPlayerIndex, card5, JackarooActions.MOVE_EAT_PATH, _allowedMoves, action3);
				obj = _allowedMoves;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				action5 = action3;
				list4 = _allowedMoves;
				jackarooActions4 = JackarooActions.MOVE_EAT_PATH;
				list3 = _allowedMoves;
				card4 = card5;
			}
			object obj18 = jackarooActions2 & JackarooActions.MOVE_SPLIT_7_0;
			bool flag10 = obj18 == null;
			num7 = (nint)action5;
			action = (Action<Card, JackarooMarbleMono>)(object)list4;
			readOnlyCollection = (IReadOnlyCollection<Card>)jackarooActions4;
			num = (int)list3;
			num2 = (int)card4;
			if (!flag10)
			{
				List<JackarooMove> allowedMoveAction5 = GetAllowedMoveAction(_board, rotatedPlayerIndex, card5, JackarooActions.MOVE_SPLIT_7_0, _allowedMoves, action3);
				obj = _allowedMoves;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				num7 = (nint)action3;
				action = (Action<Card, JackarooMarbleMono>)(object)_allowedMoves;
				readOnlyCollection = (IReadOnlyCollection<Card>)4096;
				num = (int)_allowedMoves;
				num2 = (int)card5;
			}
			JackarooActions jackarooActions5;
			JackarooActions jackarooActions6;
			if (card5 != null)
			{
				rank = card5.<Rank>k__BackingField;
				if (card5.<Rank>k__BackingField == Rank.SEVEN)
				{
					List<JackarooMove> allowedSplitMoveAction = GetAllowedSplitMoveAction(_board, rotatedPlayerIndex, card5, _allowedMoves, action3);
					obj = _allowedMoves;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num7 = (nint)action3;
					action = (Action<Card, JackarooMarbleMono>)(object)_allowedMoves;
					readOnlyCollection = (IReadOnlyCollection<Card>)card5;
					num = (int)_allowedMoves;
					num2 = rotatedPlayerIndex;
				}
				bool flag11 = card2 == null;
				num8 = num7;
				action2 = action;
				readOnlyCollection4 = (IReadOnlyCollection<Card>)jackarooActions5;
				card3 = card2;
				readOnlyCollection2 = readOnlyCollection;
				num10 = num2;
				jackarooActions3 = jackarooActions6;
				num6 = num9;
				if (!flag11)
				{
					continue;
				}
				goto IL_15cf;
			}
			goto IL_1614;
			IL_0336:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num10 = 0;
			goto IL_1880;
			IL_1880:
			rank = (Rank)obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X0_v37+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v754 @ X0_v37] (should have been resolved before IL gen)");
			object obj19 = obj20 & 1;
			if (obj19 == null)
			{
				break;
			}
			if (card2 == null)
			{
				goto IL_15dd;
			}
			object obj21 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 352;
			nint num13 = (nint)card2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v31 (Il2CppClass<Card>)+12E]");
			array2 = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v31 (Il2CppClass<Card>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_045d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v31 (Il2CppClass<Card>)+B0]");
			int num14 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v829 @ X10_v44 (System.Int32)-8]");
				if (0 == (nint)obj21)
				{
					break;
				}
				num9 = num14 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v31 (Il2CppClass<Card>)+12E]");
				array2 = (object[])(-1);
				bool flag12 = (nint)array2 != 1;
				num14 = num9;
				if (flag12)
				{
					continue;
				}
				goto IL_045d;
			}
			array2 = (object[])((int*)num14)->m_value;
			object obj22 = num13 + ((int*)num14)->m_value;
			object obj23 = obj22 + 312;
			num9 = num14;
			goto IL_18f2;
			IL_1b03:
			int num15 = (int)obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1264 @ X0_v119+8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1264 @ X0_v119] (should have been resolved before IL gen)");
			bool flag13 = (nint)obj25 <= 0;
			jackarooActions2 = jackarooActions5;
			if (!flag13)
			{
				list = (List<object>)obj;
				burnCardMove2 = JackarooMove.GetBurnCardMove(card5, JackarooActions.BURN_OTHER_CARD_RANDOM);
				bool flag14 = obj == null;
				rank = (Rank)obj24;
				if (!flag14)
				{
					object obj26 = (nint)0 + (nint)2312;
					rank = (Rank)obj26;
					int version = list._version + 1;
					list._version = version;
					array = list._items;
					if (list._items != null)
					{
						num9 = list._size;
						bool flag15 = list._size < array.Length;
						object obj27 = !flag15;
						if (obj27 == null)
						{
							num15 = ++list._size;
							object obj28 = list._items + list._size;
							object obj29 = obj28 + 32;
							obj29 = burnCardMove2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							jackarooActions2 = jackarooActions5;
							obj10 = burnCardMove2;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v5 (Rank)+20]");
							object obj30 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1458 @ X8_v72+C0]");
							num15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1072 @ X8_v42 (System.Int32)+70]");
							num2 = 0;
							((List<object>)obj).AddWithResize((object)burnCardMove2);
							jackarooActions2 = jackarooActions5;
							obj10 = burnCardMove2;
						}
						goto IL_1b4d;
					}
				}
				goto IL_16a9;
			}
			goto IL_1b4d;
			IL_0bfd:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num2 = 0;
			goto IL_1bf8;
			IL_0576:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8067]");
			num15 = 0;
			bool flag16 = nextPlayerCards == null;
			JackarooActions jackarooActions7;
			jackarooActions2 = jackarooActions7;
			obj10 = ((int*)num15)->m_value;
			JackarooActions jackarooActions8;
			num2 = (int)(&jackarooActions8);
			jackarooActions6 = jackarooActions3;
			if (flag16)
			{
				goto IL_193f;
			}
			object obj31 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2168;
			nint num16 = (nint)nextPlayerCards;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X8_v81 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+12E]");
			array2 = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X8_v81 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0643;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X8_v81 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+B0]");
			int num17 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1083 @ X10_v39 (System.Int32)-8]");
				if (0 == (nint)obj31)
				{
					break;
				}
				num9 = num17 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v994 @ X8_v81 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+12E]");
				array2 = (object[])(-1);
				bool flag17 = (nint)array2 != 1;
				num17 = num9;
				if (flag17)
				{
					continue;
				}
				goto IL_0643;
			}
			array2 = (object[])((int*)num17)->m_value;
			object obj32 = num16 + ((int*)num17)->m_value;
			obj33 = obj32 + 312;
			num9 = num17;
			num2 = (int)(&jackarooActions8);
			goto IL_1a34;
			IL_1bf8:
			rank = (Rank)obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1407 @ X0_v102+8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1407 @ X0_v102] (should have been resolved before IL gen)");
			bool flag18 = (nint)obj35 <= 0;
			jackarooActions2 = (JackarooActions)readOnlyCollection5;
			array = array3;
			if (!flag18)
			{
				list = (List<object>)obj;
				stealMove = JackarooMove.GetStealMove(card5);
				if (obj != null)
				{
					object obj36 = (nint)0 + (nint)2312;
					rank = (Rank)obj36;
					int version2 = list._version + 1;
					list._version = version2;
					array3 = list._items;
					if (list._items != null)
					{
						num9 = list._size;
						bool flag19 = list._size < array3.Length;
						object obj37 = !flag19;
						if (obj37 == null)
						{
							int num18 = ++list._size;
							object obj38 = list._items + list._size;
							object obj39 = obj38 + 32;
							obj39 = stealMove;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							jackarooActions2 = (JackarooActions)readOnlyCollection5;
							obj10 = stealMove;
							array = list._items;
							rank = (Rank)num18;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v5 (Rank)+20]");
							object obj40 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1520 @ X8_v56+C0]");
							rank = Rank.TWO;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v5 (Rank)+70]");
							num2 = 0;
							((List<object>)obj).AddWithResize((object)stealMove);
							jackarooActions2 = (JackarooActions)readOnlyCollection5;
							obj10 = stealMove;
							array = list._items;
						}
						goto IL_1c4a;
					}
				}
				goto IL_166a;
			}
			goto IL_1c4a;
			IL_1b4d:
			object obj41 = jackarooActions2 & JackarooActions.STEAL;
			bool flag20 = obj41 == null;
			object obj42 = !flag20;
			if (obj42 != null)
			{
				readOnlyCollection5 = (IReadOnlyCollection<Card>)jackarooActions2;
			}
			object obj43 = jackarooActions2 & JackarooActions.STEAL;
			bool flag21 = obj43 == null;
			rank = (Rank)num15;
			if (!flag21)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8067]");
				rank = Rank.TWO;
				if (nextPlayerCards != null)
				{
					object obj44 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2168;
					nint num19 = (nint)nextPlayerCards;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v49 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+12E]");
					array3 = (object[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v49 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0bfd;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v49 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+B0]");
					int num20 = (int)((nint)0 + (nint)8);
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1349 @ X10_v25 (System.Int32)-8]");
						if (0 == (nint)obj44)
						{
							break;
						}
						num9 = num20 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1273 @ X8_v49 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+12E]");
						array3 = (object[])(-1);
						bool flag22 = (nint)array3 != 1;
						num20 = num9;
						if (flag22)
						{
							continue;
						}
						goto IL_0bfd;
					}
					array3 = (object[])((int*)num20)->m_value;
					object obj45 = num19 + ((int*)num20)->m_value;
					obj34 = obj45 + 312;
					num9 = num20;
					goto IL_1bf8;
				}
			}
			goto IL_1c4a;
			IL_045d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num10 = 0;
			goto IL_18f2;
			IL_18f2:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v866 @ X0_v41] (should have been resolved before IL gen)");
			object obj46 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
			object obj47 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v39+B8]");
			num15 = 0;
			if (JackarooCardsMapper.IsCustomRule(card5, (JackarooAllowedRules)((int*)num15)->m_value, out jackarooActions8))
			{
				object obj48 = jackarooActions8 & JackarooActions.BURN_OTHER_CARD;
				bool flag23 = obj48 == null;
				obj42 = !flag23;
				if (obj42 != null)
				{
					jackarooActions3 = jackarooActions8;
				}
				object obj49 = jackarooActions8 & JackarooActions.BURN_OTHER_CARD;
				bool flag24 = obj49 == null;
				object obj50 = !flag24;
				jackarooActions7 = jackarooActions8;
				if (obj50 != null)
				{
					goto IL_0576;
				}
				jackarooActions2 = jackarooActions8;
				obj10 = ((int*)num15)->m_value;
				num2 = (int)(&jackarooActions8);
				jackarooActions6 = jackarooActions3;
			}
			else
			{
				JackarooActions defaultJackarooActions = JackarooCardsMapper.GetDefaultJackarooActions(card5);
				object obj51 = defaultJackarooActions & JackarooActions.BURN_OTHER_CARD;
				bool flag25 = obj51 == null;
				obj42 = !flag25;
				if (obj42 != null)
				{
					jackarooActions3 = defaultJackarooActions;
				}
				object obj52 = defaultJackarooActions & JackarooActions.BURN_OTHER_CARD;
				bool flag26 = obj52 == null;
				jackarooActions7 = defaultJackarooActions;
				jackarooActions2 = defaultJackarooActions;
				obj10 = ((int*)num15)->m_value;
				num2 = (int)(&jackarooActions8);
				jackarooActions6 = jackarooActions3;
				if (!flag26)
				{
					goto IL_0576;
				}
			}
			goto IL_193f;
			IL_193f:
			object obj53 = jackarooActions2 & JackarooActions.BURN_OTHER_CARD_RANDOM;
			bool flag27 = obj53 == null;
			obj42 = !flag27;
			jackarooActions5 = ((obj42 != null) ? jackarooActions2 : ((JackarooActions)readOnlyCollection4));
			object obj54 = jackarooActions2 & JackarooActions.BURN_OTHER_CARD_RANDOM;
			bool flag28 = obj54 == null;
			array = array2;
			if (!flag28)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8067]");
				num15 = 0;
				bool flag29 = nextPlayerCards == null;
				array = array2;
				if (!flag29)
				{
					object obj55 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2168;
					nint num21 = (nint)nextPlayerCards;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ X8_v65 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+12E]");
					array = (object[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ X8_v65 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0930;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ X8_v65 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+B0]");
					int num22 = (int)((nint)0 + (nint)8);
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1207 @ X10_v32 (System.Int32)-8]");
						if (0 == (nint)obj55)
						{
							break;
						}
						num9 = num22 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ X8_v65 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+12E]");
						array = (object[])(-1);
						bool flag30 = (nint)array != 1;
						num22 = num9;
						if (flag30)
						{
							continue;
						}
						goto IL_0930;
					}
					array = (object[])((int*)num22)->m_value;
					object obj56 = num21 + ((int*)num22)->m_value;
					obj24 = obj56 + 312;
					num9 = num22;
					goto IL_1b03;
				}
			}
			goto IL_1b4d;
			IL_1a34:
			num15 = (int)obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1122 @ X0_v137+8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1122 @ X0_v137] (should have been resolved before IL gen)");
			bool flag31 = (nint)obj57 <= 0;
			jackarooActions2 = jackarooActions3;
			jackarooActions6 = jackarooActions3;
			if (!flag31)
			{
				list = (List<object>)obj;
				burnCardMove = JackarooMove.GetBurnCardMove(card5, JackarooActions.BURN_OTHER_CARD);
				bool flag32 = obj == null;
				rank = (Rank)obj33;
				if (!flag32)
				{
					object obj58 = (nint)0 + (nint)2312;
					rank = (Rank)obj58;
					int version3 = list._version + 1;
					list._version = version3;
					array2 = list._items;
					if (list._items != null)
					{
						num9 = list._size;
						bool flag33 = list._size < array2.Length;
						object obj59 = !flag33;
						if (obj59 == null)
						{
							num15 = ++list._size;
							object obj60 = list._items + list._size;
							object obj61 = obj60 + 32;
							obj61 = burnCardMove;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							jackarooActions2 = jackarooActions3;
							obj10 = burnCardMove;
							jackarooActions6 = jackarooActions3;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v5 (Rank)+20]");
							object obj62 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1346 @ X8_v88+C0]");
							num15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1072 @ X8_v42 (System.Int32)+70]");
							num2 = 0;
							((List<object>)obj).AddWithResize((object)burnCardMove);
							jackarooActions2 = jackarooActions3;
							obj10 = burnCardMove;
							jackarooActions6 = jackarooActions3;
						}
						goto IL_193f;
					}
				}
				goto IL_162b;
			}
			goto IL_193f;
		}
		card = card2;
		readOnlyCollection3 = cards;
		obj5 = 0;
		object obj63 = 0;
		num7 = num8;
		action3 = action2;
		num6 = num9;
		readOnlyCollection = readOnlyCollection2;
		num2 = num10;
		IReadOnlyCollection<Card> cards2 = cards;
		object obj68 = default(object);
		List<JackarooMove> result = default(List<JackarooMove>);
		while (true)
		{
			if (card == null)
			{
				goto IL_1c8d;
			}
			object obj64 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			nint num23 = (nint)card;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v9 (Il2CppClass<Card>)+12E]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v9 (Il2CppClass<Card>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_1502;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v9 (Il2CppClass<Card>)+B0]");
			int num24 = (int)((nint)0 + (nint)8);
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X10_v7 (System.Int32)-8]");
				if (0 == (nint)obj64)
				{
					break;
				}
				num6 = num24 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v9 (Il2CppClass<Card>)+12E]");
				array = (object[])(-1);
				bool flag34 = (nint)array != 1;
				num24 = num6;
				if (flag34)
				{
					continue;
				}
				goto IL_1502;
			}
			array = (object[])((int*)num24)->m_value;
			object obj65 = num23 + ((int*)num24)->m_value;
			object obj66 = obj65 + 312;
			num6 = num24;
			goto IL_1cd9;
			IL_1c8d:
			bool flag35 = obj63 == null;
			object obj67 = !flag35;
			if (obj67 != null)
			{
				OutOfMemoryException ex7 = new OutOfMemoryException();
				if (num == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj63 = obj68;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					obj5 = obj68;
					cards2 = readOnlyCollection3;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return result;
			}
			break;
			IL_1502:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num2 = 0;
			goto IL_1cd9;
			IL_1cd9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X0_v11+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v784 @ X0_v11] (should have been resolved before IL gen)");
			goto IL_1c8d;
		}
		List<JackarooMove> list5 = (List<JackarooMove>)obj;
		if (obj != null)
		{
			if (list5._size < 1)
			{
				List<JackarooMove> burnCardsMoves = JackarooMove.GetBurnCardsMoves(cards2);
				obj = burnCardsMoves;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				list5 = (List<JackarooMove>)obj;
			}
			return list5;
		}
		goto IL_17e4;
	}

	private static bool DoNextPlayerHasCards(IReadOnlyCollection<Card> nextPlayerCards)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_018d: Expected O, but got I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected I4, but got Unknown
		//IL_006c: Expected O, but got I
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if (nextPlayerCards != null)
		{
			object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2168;
			nint num = (nint)nextPlayerCards;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X8_v5 (Il2CppClass<System.Collections.Generic.IReadOnlyCollection`1<Card>>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X10_v5-8]");
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
			goto IL_0123;
		}
		return false;
		IL_0123:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v169 @ X0_v3] (should have been resolved before IL gen)");
		object obj6 = default(object);
		bool flag = (nint)obj6 < 0;
		bool flag2 = obj6 == null;
		object obj7 = obj6 ^ obj6;
		object obj8 = obj6 & obj7;
		bool flag3 = (nint)obj8 < 0;
		bool flag4 = flag == flag3;
		object obj9 = !flag2;
		return (byte)((flag4 & obj9) ? 1 : 0) != 0;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0123;
	}

	private static List<JackarooMove> GetAllowedPlantAction(JackarooBoard board, int rotatedPlayerIndex, Card card, List<JackarooMove> allowedMoves)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004f: Expected I, but got O
		//IL_005f: Expected O, but got I
		//IL_009a: Expected O, but got I
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_01e2: Expected O, but got I4
		//IL_02c1: Expected O, but got I4
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_03e2: Expected O, but got I4
		//IL_0422: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		if (board != null)
		{
			IReadOnlyList<JackarooMarble> plantedMarbles = board.GetPlantedMarbles(rotatedPlayerIndex);
			if (plantedMarbles != null)
			{
				object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2248;
				nint num = (nint)plantedMarbles;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v6 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v6 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00db;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v6 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X10_v9-8]");
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
					goto IL_00db;
				}
				object obj4 = num + obj3;
				object obj5 = obj4 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v307 @ X8_v28] (should have been resolved before IL gen)");
				object obj6 = default(object);
				if ((nint)obj6 == 4)
				{
					goto IL_010f;
				}
				goto IL_0156;
			}
		}
		goto IL_0460;
		IL_0460:
		return (List<JackarooMove>)(object)new NullReferenceException();
		IL_010f:
		return allowedMoves;
		IL_00db:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v267 @ X0_v31] (should have been resolved before IL gen)");
		object obj7 = default(object);
		if ((nint)obj7 == 4)
		{
			goto IL_010f;
		}
		goto IL_0156;
		IL_0156:
		JackarooNode playerHomeNode = board.GetPlayerHomeNode(rotatedPlayerIndex);
		if (playerHomeNode != null)
		{
			bool flag = playerHomeNode.<Marble>k__BackingField == null;
			List<JackarooMove> list = allowedMoves;
			if (!flag)
			{
				bool flag2 = board.IsMyMarble(playerHomeNode.<Marble>k__BackingField, rotatedPlayerIndex);
				bool flag3 = !flag2;
				object obj8 = !flag3;
				list = null;
				if (obj8 != null)
				{
					goto IL_010f;
				}
			}
			JackarooMarble graveyardMarble = board.GetGraveyardMarble(rotatedPlayerIndex);
			object obj9 = typeof(List<AdaptivePerformanceScaler>) + 1976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list2 = default(List<object>);
			list2..ctor();
			if (list2 != null)
			{
				int version = list2._version + 1;
				list2._version = version;
				object[] items = list2._items;
				if (list2._items != null)
				{
					bool flag4 = list2._size < items.Length;
					object obj10 = !flag4;
					if (obj10 == null)
					{
						int size = list2._size + 1;
						list2._size = size;
						object obj11 = list2._items + list2._size;
						object obj12 = obj11 + 32;
						obj12 = playerHomeNode;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						list2.AddWithResize((object)playerHomeNode);
					}
					JackarooMove plantMove = JackarooMove.GetPlantMove(card, graveyardMarble, (IReadOnlyList<JackarooNode>)list2);
					if (allowedMoves != null)
					{
						int version2 = allowedMoves._version + 1;
						allowedMoves._version = version2;
						JackarooMove[] items2 = allowedMoves._items;
						if (allowedMoves._items != null)
						{
							bool flag5 = allowedMoves._size < items2.Length;
							object obj13 = !flag5;
							if (obj13 == null)
							{
								int size2 = allowedMoves._size + 1;
								allowedMoves._size = size2;
								object obj14 = allowedMoves._items + allowedMoves._size;
								object obj15 = obj14 + 32;
								obj15 = plantMove;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								return allowedMoves;
							}
							((List<object>)(object)allowedMoves).AddWithResize((object)plantMove);
							return allowedMoves;
						}
					}
				}
			}
		}
		goto IL_0460;
	}

	private unsafe static List<JackarooMove> GetAllowedSwapAction(JackarooBoard board, int rotatedPlayerIndex, Card card, List<JackarooMove> allowedMoves, Action<Card, JackarooMarbleMono> onGuardedMarbleAdded)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0054: Expected I, but got O
		//IL_0064: Expected O, but got I
		//IL_0162: Expected O, but got I4
		//IL_0d76: Expected O, but got I4
		//IL_0d86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8b: Expected O, but got Unknown
		//IL_0187: Expected O, but got I
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0263: Expected O, but got I
		//IL_02f9: Expected O, but got I4
		//IL_0bea: Expected O, but got Ref
		//IL_0bfb: Expected O, but got I4
		//IL_0c1e: Expected O, but got Ref
		//IL_0c2f: Expected O, but got I4
		//IL_0c90: Expected O, but got Ref
		//IL_0ca1: Expected O, but got I4
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_048b: Expected I, but got O
		//IL_049b: Expected O, but got I
		//IL_037f: Expected O, but got I
		//IL_0cde: Expected O, but got I
		//IL_0e24: Expected O, but got I
		//IL_0e48: Expected O, but got I4
		//IL_0678: Expected O, but got I
		//IL_0dd6: Expected O, but got I4
		//IL_0de6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0deb: Expected O, but got Unknown
		//IL_05cb: Expected O, but got I4
		//IL_05d3: Expected O, but got Ref
		//IL_05e4: Expected O, but got I4
		//IL_0591: Expected O, but got I
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected O, but got Unknown
		//IL_0ed6: Expected O, but got I
		//IL_0ee9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eee: Expected O, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Expected O, but got Unknown
		//IL_0519: Expected O, but got I4
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected O, but got Unknown
		//IL_0460: Expected O, but got I
		//IL_0e88: Expected O, but got I4
		//IL_0e98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9d: Expected O, but got Unknown
		//IL_0fc0: Expected O, but got I4
		//IL_0fc9: Expected O, but got I4
		//IL_0fd1: Expected O, but got Ref
		//IL_0fe2: Expected O, but got I4
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected O, but got Unknown
		//IL_0777: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected O, but got Unknown
		//IL_0c72: Expected O, but got I4
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4b: Expected O, but got Unknown
		//IL_0a63: Expected O, but got I
		//IL_0b9f: Expected O, but got I4
		//IL_0ba7: Expected O, but got Ref
		//IL_0bb8: Expected O, but got I4
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected O, but got Unknown
		//IL_06f6: Expected O, but got I4
		//IL_06ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_07c6: Expected O, but got I
		//IL_1009: Expected O, but got I4
		//IL_1019: Unknown result type (might be due to invalid IL or missing references)
		//IL_101e: Expected O, but got Unknown
		//IL_0f9c: Expected O, but got I4
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b32: Expected O, but got Unknown
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b40: Expected O, but got Unknown
		//IL_0f2d: Expected O, but got I4
		//IL_0f3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f42: Expected O, but got Unknown
		//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abf: Expected O, but got Unknown
		//IL_0ad9: Expected O, but got I4
		//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae7: Expected O, but got Unknown
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected O, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ca: Expected O, but got Unknown
		//IL_0b5f: Expected O, but got I4
		//IL_0b67: Expected O, but got Ref
		//IL_0b78: Expected O, but got I4
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected O, but got Unknown
		//IL_0844: Expected O, but got I4
		//IL_084d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0852: Expected O, but got Unknown
		//IL_0995: Expected O, but got I4
		//IL_09a9: Expected O, but got I4
		//IL_05f9: Expected O, but got I
		//IL_0609: Expected O, but got I
		//IL_0619: Expected O, but got I
		//IL_09fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected O, but got Unknown
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a10: Expected O, but got Unknown
		bool flag = board == null;
		Card card2 = card;
		IReadOnlyList<JackarooMarble> plantedMarbles;
		bool flag4 = default(bool);
		int rotatedPlayerIndex2 = default(int);
		if (!flag)
		{
			plantedMarbles = board.GetPlantedMarbles(rotatedPlayerIndex2);
			bool flag2 = plantedMarbles == null;
			card2 = null;
			if (!flag2)
			{
				object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2248;
				nint num = (nint)plantedMarbles;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v12 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v12 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0134;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X8_v12 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
				int num2 = (int)((nint)0 + (nint)8);
				bool flag3 = flag4;
				int num3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X10_v39 (System.Int32)-8]");
					bool flag5 = 0 < (nint)obj;
					object obj3 = !flag5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X10_v39 (System.Int32)-8]");
					object obj4 = 0 - obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X10_v39 (System.Int32)-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					num3 = num2 + 16;
					obj2--;
					bool flag6 = (nint)obj2 < 1;
					obj3 = !flag6;
					obj4 = obj2 - 1;
					bool flag7 = obj4 == null;
					flag4 = (nint)obj2 != 1;
					flag3 = flag4;
					num2 = num3;
					if (flag4)
					{
						continue;
					}
					goto IL_0134;
				}
				object obj5 = num + ((int*)num2)->m_value;
				object obj6 = obj5 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v388 @ X0_v93] (should have been resolved before IL gen)");
				object obj7 = default(object);
				bool flag8 = obj7 == null;
				flag4 = flag3;
				num3 = num2;
				if (!flag8)
				{
					goto IL_01cc;
				}
				goto IL_0bd4;
			}
		}
		goto IL_0c46;
		IL_0c46:
		List<JackarooMove> list = allowedMoves;
		throw new NullReferenceException();
		IL_0bd4:
		return allowedMoves;
		IL_0134:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v233 @ X0_v90] (should have been resolved before IL gen)");
		object obj8 = default(object);
		bool flag9 = obj8 == null;
		object obj9 = !flag9;
		if (obj9 != null)
		{
			goto IL_01cc;
		}
		goto IL_0bd4;
		IL_01cc:
		List<JackarooMarble> allPlantedMarblesExcept = board.GetAllPlantedMarblesExcept(rotatedPlayerIndex2);
		bool flag10 = allPlantedMarblesExcept == null;
		card2 = null;
		if (!flag10)
		{
			if (allPlantedMarblesExcept._size != 0)
			{
				List<object>.Enumerator enumerator = ((List<object>)(object)allPlantedMarblesExcept).GetEnumerator();
				object obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				object obj11 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 824;
				object obj12 = (nint)0 + (nint)2312;
				list = allowedMoves;
				List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
				JackarooMarble jackarooMarble = default(JackarooMarble);
				object obj20 = default(object);
				List<JackarooMove> result = default(List<JackarooMove>);
				object obj21 = default(object);
				JackarooMarble jackarooMarble5 = default(JackarooMarble);
				object obj34 = default(object);
				object obj36 = default(object);
				List<object>.Enumerator enumerator5 = default(List<object>.Enumerator);
				while (true)
				{
					NullReferenceException ex;
					List<object>.Enumerator enumerator3;
					JackarooMarble jackarooMarble3;
					List<object>.Enumerator enumerator4;
					JackarooMarble jackarooMarble2;
					if (enumerator2.MoveNext())
					{
						bool flag11 = board.IsMarbleAtBase(jackarooMarble);
						bool flag12 = !flag11;
						object obj13 = !flag12;
						if (obj13 != null)
						{
							continue;
						}
						if (board.IsMarbleAtHome(jackarooMarble))
						{
							if (onGuardedMarbleAdded == null)
							{
								continue;
							}
							if (jackarooMarble != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [onGuardedMarbleAdded @ X4 (System.Action`2<Card, Jackaroo.JackarooMarbleMono>)+28]");
								list = (List<JackarooMove>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [onGuardedMarbleAdded @ X4 (System.Action`2<Card, Jackaroo.JackarooMarbleMono>)+18] (should have been resolved before IL gen)");
								continue;
							}
							ex = new NullReferenceException();
							enumerator3 = (List<object>.Enumerator)(&enumerator2);
							enumerator4 = enumerator5;
							enumerator5 = (List<object>.Enumerator)0;
							jackarooMarble2 = null;
							jackarooMarble3 = jackarooMarble;
						}
						else if (jackarooMarble != null)
						{
							JackarooNode jackarooNode = board.PreviousLocalNode(jackarooMarble.<Node>k__BackingField);
							if (jackarooNode != null)
							{
								if (jackarooNode.<Marble>k__BackingField != null && IsBlockedByTwoMarbles(jackarooMarble, jackarooNode.<Marble>k__BackingField))
								{
									if (onGuardedMarbleAdded != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [onGuardedMarbleAdded @ X4 (System.Action`2<Card, Jackaroo.JackarooMarbleMono>)+28]");
										list = (List<JackarooMove>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [onGuardedMarbleAdded @ X4 (System.Action`2<Card, Jackaroo.JackarooMarbleMono>)+18] (should have been resolved before IL gen)");
									}
									continue;
								}
								object obj14 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3416;
								nint num4 = (nint)plantedMarbles;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v27 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
								object obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v27 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_056b;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v27 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
								int num5 = (int)((nint)0 + (nint)8);
								bool flag13 = flag4;
								int num3;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X10_v34 (System.Int32)-8]");
									bool flag14 = 0 < (nint)obj14;
									object obj3 = !flag14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X10_v34 (System.Int32)-8]");
									object obj4 = 0 - obj14;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X10_v34 (System.Int32)-8]");
									if (0 == (nint)obj14)
									{
										break;
									}
									num3 = num5 + 16;
									obj15--;
									bool flag15 = (nint)obj15 < 1;
									obj3 = !flag15;
									obj4 = obj15 - 1;
									bool flag7 = obj4 == null;
									flag4 = (nint)obj15 != 1;
									flag13 = flag4;
									num5 = num3;
									if (flag4)
									{
										continue;
									}
									goto IL_056b;
								}
								object obj16 = num4 + ((int*)num5)->m_value;
								object obj17 = obj16 + 312;
								flag4 = flag13;
								num3 = num5;
								jackarooMarble2 = null;
								goto IL_0e14;
							}
							ex = new NullReferenceException();
							enumerator3 = (List<object>.Enumerator)(&enumerator2);
							enumerator4 = enumerator5;
							enumerator5 = (List<object>.Enumerator)0;
							jackarooMarble2 = null;
							jackarooMarble3 = (JackarooMarble)(object)jackarooMarble.<Node>k__BackingField;
						}
						else
						{
							ex = new NullReferenceException();
							enumerator3 = (List<object>.Enumerator)(&enumerator2);
							enumerator4 = enumerator5;
							enumerator5 = (List<object>.Enumerator)0;
							jackarooMarble2 = null;
							jackarooMarble3 = jackarooMarble;
						}
						goto IL_1047;
					}
					enumerator2.Dispose();
					break;
					IL_0fb7:
					object obj18 = 0;
					obj18 = 0;
					enumerator3 = (List<object>.Enumerator)(&enumerator2);
					enumerator4 = enumerator5;
					enumerator5 = (List<object>.Enumerator)0;
					OutOfMemoryException ex2 = new OutOfMemoryException();
					jackarooMarble2 = (JackarooMarble)(object)card2;
					jackarooMarble3 = (JackarooMarble)rotatedPlayerIndex2;
					ex = (NullReferenceException)(object)ex2;
					goto IL_1047;
					IL_0284:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v924 @ X0_v52+8]");
					rotatedPlayerIndex2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v924 @ X0_v52] (should have been resolved before IL gen)");
					goto IL_0fb7;
					IL_0b8d:
					ex = new NullReferenceException();
					obj18 = 0;
					enumerator3 = (List<object>.Enumerator)(&enumerator2);
					enumerator4 = enumerator5;
					enumerator5 = (List<object>.Enumerator)0;
					JackarooMarble jackarooMarble4;
					jackarooMarble2 = jackarooMarble4;
					goto IL_1047;
					IL_05b9:
					ex = new NullReferenceException();
					obj18 = 0;
					enumerator3 = (List<object>.Enumerator)(&enumerator2);
					enumerator4 = enumerator5;
					enumerator5 = (List<object>.Enumerator)0;
					goto IL_1047;
					IL_0270:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					card2 = null;
					goto IL_0284;
					IL_056b:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					jackarooMarble2 = null;
					goto IL_0e14;
					IL_1047:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
					bool flag16 = (nint)jackarooMarble3 != 1;
					NullReferenceException ex3 = ex;
					if (!flag16)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
						object obj19 = (nint)0 + (nint)2744;
						jackarooMarble3 = (JackarooMarble)obj19;
						((List<object>.Enumerator*)enumerator3)->Dispose();
						if (obj20 == null)
						{
							break;
						}
						OutOfMemoryException ex4 = new OutOfMemoryException();
						enumerator5 = (List<object>.Enumerator)obj20;
						ex3 = (NullReferenceException)(object)ex4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BBC8");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
					return result;
					IL_0e14:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v667 @ X0_v43+8]");
					jackarooMarble3 = (JackarooMarble)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v667 @ X0_v43] (should have been resolved before IL gen)");
					bool flag17 = obj21 == null;
					object obj22 = !flag17;
					object obj23 = obj21;
					jackarooMarble4 = jackarooMarble2;
					JackarooMove newSwapJackarooMove;
					if (obj22 != null)
					{
						while (true)
						{
							object obj24 = obj23;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v32+12E]");
							object obj25 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v32+12E]");
							if ((nint)0 == 0)
							{
								goto IL_0748;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v715 @ X8_v32+B0]");
							int num6 = (int)((nint)0 + (nint)8);
							bool flag18 = flag4;
							int num3;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X10_v28 (System.Int32)-8]");
								bool flag19 = 0 < (nint)obj10;
								object obj3 = !flag19;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X10_v28 (System.Int32)-8]");
								object obj4 = 0 - obj10;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X10_v28 (System.Int32)-8]");
								if (0 == (nint)obj10)
								{
									break;
								}
								num3 = num6 + 16;
								obj25--;
								bool flag20 = (nint)obj25 < 1;
								obj3 = !flag20;
								obj4 = obj25 - 1;
								bool flag7 = obj4 == null;
								flag4 = (nint)obj25 != 1;
								flag18 = flag4;
								num6 = num3;
								if (flag4)
								{
									continue;
								}
								goto IL_0748;
							}
							object obj26 = obj24 + ((int*)num6)->m_value;
							object obj27 = obj26 + 312;
							flag4 = flag18;
							num3 = num6;
							goto IL_0ec6;
							IL_0f6b:
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v892 @ X0_v58] (should have been resolved before IL gen)");
							bool flag21 = board.IsMarbleAtBase(jackarooMarble5);
							bool flag22 = !flag21;
							object obj28 = !flag22;
							jackarooMarble2 = null;
							jackarooMarble3 = jackarooMarble5;
							if (obj28 != null)
							{
								goto IL_0633;
							}
							newSwapJackarooMove = JackarooMove.GetNewSwapJackarooMove(card, jackarooMarble5, jackarooMarble);
							if (allowedMoves != null)
							{
								object obj29 = obj12;
								int version = allowedMoves._version + 1;
								allowedMoves._version = version;
								JackarooMove[] items = allowedMoves._items;
								if (allowedMoves._items != null)
								{
									num3 = allowedMoves._size;
									bool flag23 = allowedMoves._size < items.Length;
									object obj3 = !flag23;
									object obj4 = allowedMoves._size - items.Length;
									bool flag7 = obj4 == null;
									if (obj3 != null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X8_v46+20]");
										object obj30 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v960 @ X8_v48+C0]");
										object obj31 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v49+70]");
										jackarooMarble2 = (JackarooMarble)0;
										((List<object>)(object)allowedMoves).AddWithResize((object)newSwapJackarooMove);
										jackarooMarble3 = (JackarooMarble)(object)newSwapJackarooMove;
									}
									else
									{
										int size = allowedMoves._size + 1;
										allowedMoves._size = size;
										object obj32 = allowedMoves._items + allowedMoves._size;
										object obj33 = obj32 + 32;
										obj33 = newSwapJackarooMove;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										jackarooMarble2 = jackarooMarble;
										jackarooMarble3 = (JackarooMarble)(object)newSwapJackarooMove;
									}
									goto IL_0633;
								}
							}
							goto IL_0b4d;
							IL_0633:
							bool flag24 = obj34 == null;
							obj23 = obj34;
							jackarooMarble4 = jackarooMarble2;
							if (!flag24)
							{
								continue;
							}
							goto IL_05b9;
							IL_0896:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
							jackarooMarble4 = null;
							goto IL_0f6b;
							IL_0748:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
							jackarooMarble4 = null;
							goto IL_0ec6;
							IL_0ec6:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X0_v47+8]");
							jackarooMarble3 = (JackarooMarble)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v772 @ X0_v47] (should have been resolved before IL gen)");
							object obj35 = obj36 & 1;
							if (obj35 == null)
							{
								break;
							}
							if (obj34 == null)
							{
								goto IL_0b8d;
							}
							object obj37 = obj34;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v42+12E]");
							object obj38 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v42+12E]");
							if ((nint)0 == 0)
							{
								goto IL_0896;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v42+B0]");
							int num7 = (int)((nint)0 + (nint)8);
							bool flag25 = flag4;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X10_v23 (System.Int32)-8]");
								bool flag26 = 0 < (nint)obj11;
								object obj3 = !flag26;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X10_v23 (System.Int32)-8]");
								object obj4 = 0 - obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v846 @ X10_v23 (System.Int32)-8]");
								if (0 == (nint)obj11)
								{
									break;
								}
								num3 = num7 + 16;
								obj38--;
								bool flag27 = (nint)obj38 < 1;
								obj3 = !flag27;
								obj4 = obj38 - 1;
								bool flag7 = obj4 == null;
								flag4 = (nint)obj38 != 1;
								flag25 = flag4;
								num7 = num3;
								if (flag4)
								{
									continue;
								}
								goto IL_0896;
							}
							object obj39 = obj37 + ((int*)num7)->m_value;
							object obj40 = obj39 + 312;
							flag4 = flag25;
							num3 = num7;
							goto IL_0f6b;
						}
						bool flag28 = obj34 == null;
						card2 = (Card)(object)jackarooMarble4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X0_v47+8]");
						rotatedPlayerIndex2 = 0;
						if (!flag28)
						{
							object obj41 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
							object obj42 = obj34;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ X8_v38+12E]");
							object obj43 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ X8_v38+12E]");
							if ((nint)0 == 0)
							{
								goto IL_0270;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ X8_v38+B0]");
							int num3 = (int)((nint)0 + (nint)8);
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X10_v19 (System.Int32)-8]");
								bool flag29 = 0 < (nint)obj41;
								object obj3 = !flag29;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X10_v19 (System.Int32)-8]");
								object obj4 = 0 - obj41;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X10_v19 (System.Int32)-8]");
								if (0 == (nint)obj41)
								{
									break;
								}
								num3 += 16;
								obj43--;
								bool flag30 = (nint)obj43 < 1;
								obj3 = !flag30;
								obj4 = obj43 - 1;
								bool flag7 = obj4 == null;
								if ((nint)obj43 != 1)
								{
									continue;
								}
								goto IL_0270;
							}
							object obj44 = obj42 + ((int*)num3)->m_value;
							object obj45 = obj44 + 312;
							card2 = (Card)(object)jackarooMarble4;
							goto IL_0284;
						}
						goto IL_0fb7;
					}
					goto IL_05b9;
					IL_0b4d:
					ex = new NullReferenceException();
					obj18 = 0;
					enumerator3 = (List<object>.Enumerator)(&enumerator2);
					enumerator4 = enumerator5;
					enumerator5 = (List<object>.Enumerator)0;
					jackarooMarble2 = jackarooMarble;
					jackarooMarble3 = (JackarooMarble)(object)newSwapJackarooMove;
					goto IL_1047;
				}
			}
			goto IL_0bd4;
		}
		goto IL_0c46;
	}

	private static List<JackarooMove> GetAllowedMoveAnyAction(JackarooBoard board, int rotatedPlayerIndex, Card card, List<JackarooMove> allowedMoves, Action<Card, JackarooMarbleMono> onGuardedMarbleAdded)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0063: Expected I, but got O
		//IL_0073: Expected O, but got I
		//IL_0171: Expected O, but got I4
		//IL_0183: Expected O, but got I4
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I
		//IL_038b: Expected I, but got O
		//IL_039b: Expected O, but got I
		//IL_01b9: Expected O, but got I4
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_022a: Expected O, but got I4
		//IL_0265: Expected O, but got I4
		//IL_0bbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc0: Expected O, but got Unknown
		//IL_03d6: Expected O, but got I
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_081b: Expected O, but got I4
		//IL_0b69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6e: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_0c89: Expected O, but got I4
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f1: Expected O, but got Unknown
		//IL_0407: Expected O, but got I
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_082f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected O, but got Unknown
		//IL_083c: Expected I, but got O
		//IL_084c: Expected O, but got I
		//IL_04cc: Expected I, but got O
		//IL_04dc: Expected O, but got I
		//IL_0887: Expected O, but got I
		//IL_0c54: Expected O, but got I4
		//IL_0c61: Expected I4, but got O
		//IL_0517: Expected O, but got I
		//IL_0bf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf5: Expected O, but got Unknown
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Expected O, but got Unknown
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_090f: Expected O, but got Unknown
		//IL_0617: Expected O, but got I4
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c5: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected O, but got Unknown
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected O, but got Unknown
		//IL_08b0: Expected O, but got I
		//IL_0308: Expected I, but got O
		//IL_0311: Expected O, but got I4
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_0548: Expected O, but got I
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		//IL_09f0: Expected I4, but got O
		//IL_0674: Expected I4, but got O
		//IL_0709: Expected O, but got I
		//IL_0a30: Expected I4, but got O
		//IL_06af: Expected O, but got I
		//IL_06c0: Expected O, but got I
		//IL_06d2: Expected I4, but got O
		//IL_07a5: Expected I4, but got O
		//IL_07c3: Expected O, but got I
		//IL_07d3: Expected O, but got I
		//IL_07e5: Expected I4, but got O
		bool flag = board == null;
		List<JackarooMove> list = allowedMoves;
		IReadOnlyList<JackarooMarble> readOnlyList = null;
		int num = rotatedPlayerIndex;
		object obj3;
		bool flag4 = default(bool);
		IReadOnlyList<JackarooMarble> readOnlyList2 = default(IReadOnlyList<JackarooMarble>);
		Action<Card, JackarooMarbleMono> action;
		Card card4;
		Card card2;
		object obj8;
		object obj9;
		Action<Card, JackarooMarbleMono> action2 = default(Action<Card, JackarooMarbleMono>);
		Card card3 = default(Card);
		object obj5 = default(object);
		if (!flag)
		{
			IReadOnlyList<JackarooMarble> allPlantedMarbles = board.GetAllPlantedMarbles();
			bool flag2 = allPlantedMarbles == null;
			list = allowedMoves;
			readOnlyList = null;
			num = 0;
			if (!flag2)
			{
				object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3416;
				nint num2 = (nint)allPlantedMarbles;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v15 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v15 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_012b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v15 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
				obj3 = (nint)0 + (nint)8;
				bool flag3 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X10_v11-8]");
					object obj4 = 0 - obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X10_v11-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj5 = obj3 + 16;
					obj2--;
					obj4 = obj2 - 1;
					bool flag5 = obj4 == null;
					flag4 = (nint)obj2 != 1;
					flag3 = flag4;
					obj3 = obj5;
					if (flag4)
					{
						continue;
					}
					goto IL_012b;
				}
				object obj6 = num2 + obj3;
				object obj7 = obj6 + 312;
				obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v34+8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v282 @ X8_v34] (should have been resolved before IL gen)");
				bool flag6 = readOnlyList2 == null;
				readOnlyList = readOnlyList2;
				obj9 = 0;
				card2 = card3;
				flag4 = flag3;
				obj5 = obj3;
				action = action2;
				list = allowedMoves;
				readOnlyList = readOnlyList2;
				obj9 = 0;
				card4 = card3;
				if (!flag6)
				{
					goto IL_027d;
				}
				goto IL_0921;
			}
		}
		goto IL_0b0a;
		IL_092f:
		NullReferenceException ex = new NullReferenceException();
		Action<Card, JackarooMarbleMono> action4;
		Action<Card, JackarooMarbleMono> action3 = action4;
		nint num3;
		IntPtr intPtr = num3;
		Action<Card, JackarooMarbleMono> action5;
		action = action5;
		List<JackarooMove> list2;
		list = list2;
		card4 = card2;
		obj3 = obj5;
		goto IL_0a35;
		IL_096d:
		NullReferenceException ex2 = new NullReferenceException();
		action3 = action4;
		intPtr = num3;
		action = action5;
		list = null;
		card4 = null;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v36 (System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>)+20]");
		num = 0;
		goto IL_0a35;
		IL_0921:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0a35;
		IL_0b0a:
		throw new NullReferenceException();
		IL_09b5:
		NullReferenceException ex4 = new NullReferenceException();
		action3 = action4;
		intPtr = num3;
		action = action5;
		list = null;
		card4 = null;
		obj3 = obj5;
		IReadOnlyList<JackarooMarble> readOnlyList3 = default(IReadOnlyList<JackarooMarble>);
		num = (int)readOnlyList3;
		goto IL_0a35;
		IL_09f5:
		NullReferenceException ex5 = new NullReferenceException();
		action3 = action4;
		intPtr = num3;
		action = action5;
		list = null;
		card4 = null;
		obj3 = obj5;
		num = (int)readOnlyList3;
		goto IL_0a35;
		IL_012b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj10 = default(object);
		obj8 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X0_v64+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v232 @ X0_v64] (should have been resolved before IL gen)");
		bool flag7 = readOnlyList2 == null;
		object obj11 = !flag7;
		readOnlyList = readOnlyList2;
		obj9 = 0;
		card2 = null;
		if (obj11 != null)
		{
			goto IL_027d;
		}
		action = action2;
		list = allowedMoves;
		readOnlyList = readOnlyList2;
		obj9 = 0;
		card4 = null;
		obj3 = obj5;
		goto IL_0921;
		IL_027d:
		object obj12 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj13 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 824;
		action4 = action3;
		num3 = intPtr;
		action5 = action2;
		list2 = allowedMoves;
		IReadOnlyList<JackarooMarble> readOnlyList4 = readOnlyList2;
		object obj20 = default(object);
		while (true)
		{
			nint num4 = (nint)readOnlyList4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v20 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v20 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_045b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v20 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
			object obj14 = (nint)0 + (nint)8;
			bool flag8 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X10_v25-8]");
				object obj4 = 0 - obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v491 @ X10_v25-8]");
				if (0 == (nint)obj12)
				{
					break;
				}
				obj5 = obj14 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v20 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				obj8 = -1;
				obj4 = obj8 - 1;
				bool flag5 = obj4 == null;
				flag4 = (nint)obj8 != 1;
				flag8 = flag4;
				obj14 = obj5;
				if (flag4)
				{
					continue;
				}
				goto IL_045b;
			}
			obj8 = obj14;
			object obj15 = num4 + obj14;
			object obj16 = obj15 + 312;
			flag4 = flag8;
			obj5 = obj14;
			goto IL_0b97;
			IL_059c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			card2 = null;
			goto IL_0c1e;
			IL_0c1e:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v695 @ X0_v34] (should have been resolved before IL gen)");
			bool flag9 = board.IsMarbleAtBase((JackarooMarble)readOnlyList3);
			bool flag10 = !flag9;
			object obj17 = !flag10;
			card2 = null;
			num = (int)readOnlyList3;
			if (obj17 == null)
			{
				bool flag11 = board.IsMyMarble((JackarooMarble)readOnlyList3, rotatedPlayerIndex);
				bool flag12 = !flag11;
				object obj18 = !flag12;
				if (obj18 != null)
				{
					goto IL_02d2;
				}
				if (board.IsMarbleAtHome((JackarooMarble)readOnlyList3))
				{
					bool flag13 = action2 == null;
					list2 = null;
					card2 = null;
					num = (int)readOnlyList3;
					if (!flag13)
					{
						if (readOnlyList3 == null)
						{
							goto IL_09f5;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v36 (System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>)+18]");
						card2 = (Card)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X4_v1 (System.Action`2<Card, Jackaroo.JackarooMarbleMono>)+28]");
						list2 = (List<JackarooMove>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v143 @ X4_v1 (System.Action`2<Card, Jackaroo.JackarooMarbleMono>)+18] (should have been resolved before IL gen)");
						num = (int)card3;
					}
				}
				else
				{
					if (readOnlyList3 == null)
					{
						goto IL_09b5;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v36 (System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>)+20]");
					JackarooNode jackarooNode = board.PreviousLocalNode((JackarooNode)0);
					if (jackarooNode == null)
					{
						goto IL_096d;
					}
					if (jackarooNode.<Marble>k__BackingField == null || !IsBlockedByTwoMarbles((JackarooMarble)readOnlyList3, jackarooNode.<Marble>k__BackingField))
					{
						goto IL_02d2;
					}
					bool flag14 = action2 == null;
					list2 = null;
					card2 = null;
					num = (int)jackarooNode.<Marble>k__BackingField;
					if (!flag14)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X0_v36 (System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>)+18]");
						card2 = (Card)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X4_v1 (System.Action`2<Card, Jackaroo.JackarooMarbleMono>)+28]");
						list2 = (List<JackarooMove>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v143 @ X4_v1 (System.Action`2<Card, Jackaroo.JackarooMarbleMono>)+18] (should have been resolved before IL gen)");
						num = (int)card3;
					}
				}
			}
			goto IL_032e;
			IL_02d2:
			List<JackarooMove> allowedMoveAction = GetAllowedMoveAction((JackarooMarble)readOnlyList3, rotatedPlayerIndex, board, card3, JackarooActions.MOVE_ANY, allowedMoves, action2);
			action4 = action2;
			num3 = (nint)allowedMoves;
			action5 = (Action<Card, JackarooMarbleMono>)4;
			list2 = (List<JackarooMove>)(object)card3;
			card2 = (Card)(object)board;
			num = rotatedPlayerIndex;
			goto IL_032e;
			IL_045b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			card2 = null;
			goto IL_0b97;
			IL_0b97:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X0_v30+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v575 @ X0_v30] (should have been resolved before IL gen)");
			object obj19 = obj20 & 1;
			if (obj19 == null)
			{
				break;
			}
			if (readOnlyList == null)
			{
				goto IL_092f;
			}
			nint num5 = (nint)readOnlyList;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v23 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v23 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_059c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v23 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
			object obj21 = (nint)0 + (nint)8;
			bool flag15 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X10_v20-8]");
				object obj4 = 0 - obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X10_v20-8]");
				if (0 == (nint)obj13)
				{
					break;
				}
				obj5 = obj21 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v23 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				obj8 = -1;
				obj4 = obj8 - 1;
				bool flag5 = obj4 == null;
				flag4 = (nint)obj8 != 1;
				flag15 = flag4;
				obj21 = obj5;
				if (flag4)
				{
					continue;
				}
				goto IL_059c;
			}
			obj8 = obj21;
			object obj22 = num5 + obj21;
			object obj23 = obj22 + 312;
			flag4 = flag15;
			obj5 = obj21;
			goto IL_0c1e;
			IL_032e:
			bool flag16 = readOnlyList == null;
			readOnlyList4 = readOnlyList;
			action3 = action4;
			intPtr = num3;
			action = action5;
			list = list2;
			card4 = card2;
			obj3 = obj5;
			if (!flag16)
			{
				continue;
			}
			goto IL_0921;
		}
		action3 = action4;
		intPtr = num3;
		action2 = action5;
		list = list2;
		card3 = card2;
		object obj24 = 0;
		object obj30 = default(object);
		while (true)
		{
			if (readOnlyList == null)
			{
				goto IL_0c6f;
			}
			object obj25 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			nint num6 = (nint)readOnlyList;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_08d8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
			object obj26 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X10_v7-8]");
				if (0 == (nint)obj25)
				{
					break;
				}
				obj5 = obj26 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				obj8 = -1;
				bool flag17 = (nint)obj8 != 1;
				obj26 = obj5;
				if (flag17)
				{
					continue;
				}
				goto IL_08d8;
			}
			obj8 = obj26;
			object obj27 = num6 + obj26;
			object obj28 = obj27 + 312;
			obj5 = obj26;
			goto IL_0cbb;
			IL_0c6f:
			bool flag18 = obj24 == null;
			object obj29 = !flag18;
			if (obj29 == null)
			{
				return allowedMoves;
			}
			OutOfMemoryException ex6 = new OutOfMemoryException();
			if (num != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			obj24 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj9 = obj30;
			continue;
			IL_08d8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			card3 = null;
			goto IL_0cbb;
			IL_0cbb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v5+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v637 @ X0_v5] (should have been resolved before IL gen)");
			goto IL_0c6f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		List<JackarooMove> result = default(List<JackarooMove>);
		return result;
		IL_0a35:
		action2 = action;
		card3 = card4;
		obj5 = obj3;
		goto IL_0b0a;
	}

	private unsafe List<JackarooMove> GetAllowedSplitMoveAction(JackarooBoard board, int rotatedPlayerIndex, Card card, List<JackarooMove> allowedMoves, Action<Card, JackarooMarbleMono> onGuardedMarbleAdded)
	{
		//IL_0008: Expected O, but got Ref
		//IL_1bea: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bef: Expected O, but got Unknown
		//IL_1bf7: Expected I, but got O
		//IL_1c0f: Expected O, but got I4
		//IL_1c2c: Expected I4, but got O
		//IL_0033: Expected O, but got I
		//IL_0065: Expected I4, but got O
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_0114: Expected O, but got I
		//IL_0137: Expected O, but got I
		//IL_01bd: Expected O, but got I4
		//IL_0192: Expected O, but got I
		//IL_0201: Expected O, but got I4
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_0249: Expected I, but got O
		//IL_0259: Expected O, but got I
		//IL_0357: Expected O, but got I4
		//IL_040c: Expected O, but got I4
		//IL_1c65: Expected O, but got I
		//IL_1c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c7c: Expected O, but got Unknown
		//IL_044f: Expected O, but got Ref
		//IL_0458: Expected O, but got I4
		//IL_0381: Expected O, but got I4
		//IL_0393: Expected O, but got I
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_2459: Expected O, but got Ref
		//IL_02c5: Expected O, but got I
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_1b2d: Expected O, but got I4
		//IL_1b3e: Expected O, but got I4
		//IL_24af: Expected O, but got I
		//IL_24b7: Expected I4, but got O
		//IL_24da: Expected O, but got I4
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_04ab: Expected I, but got O
		//IL_04bb: Expected O, but got I
		//IL_1cb5: Expected O, but got I
		//IL_1cc7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ccc: Expected O, but got Unknown
		//IL_1b61: Expected O, but got I4
		//IL_1b7a: Expected O, but got I4
		//IL_05eb: Expected I4, but got O
		//IL_05a8: Expected O, but got I4
		//IL_05ba: Expected O, but got I
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c8: Expected O, but got Unknown
		//IL_0714: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected O, but got Unknown
		//IL_0731: Expected O, but got I
		//IL_0527: Expected O, but got I
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected O, but got Unknown
		//IL_1d9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1da4: Expected O, but got Unknown
		//IL_1640: Expected O, but got Ref
		//IL_1660: Expected O, but got I4
		//IL_1669: Expected O, but got I4
		//IL_1682: Expected O, but got I4
		//IL_16f4: Expected O, but got I4
		//IL_1d3c: Expected O, but got I
		//IL_1d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d53: Expected O, but got Unknown
		//IL_2368: Expected O, but got I4
		//IL_0816: Expected O, but got I4
		//IL_0823: Unknown result type (might be due to invalid IL or missing references)
		//IL_0828: Expected O, but got Unknown
		//IL_0831: Unknown result type (might be due to invalid IL or missing references)
		//IL_0836: Expected O, but got Unknown
		//IL_1711: Unknown result type (might be due to invalid IL or missing references)
		//IL_1716: Expected O, but got Unknown
		//IL_171e: Expected I, but got O
		//IL_172e: Expected O, but got I
		//IL_079d: Expected O, but got I
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Expected O, but got Unknown
		//IL_1837: Unknown result type (might be due to invalid IL or missing references)
		//IL_183c: Expected O, but got Unknown
		//IL_185a: Expected O, but got I4
		//IL_0877: Unknown result type (might be due to invalid IL or missing references)
		//IL_087c: Expected O, but got Unknown
		//IL_0894: Expected O, but got I
		//IL_1899: Expected O, but got I4
		//IL_2386: Expected O, but got I
		//IL_1e46: Expected O, but got I4
		//IL_17ef: Expected O, but got I4
		//IL_1801: Expected O, but got I
		//IL_180a: Unknown result type (might be due to invalid IL or missing references)
		//IL_180f: Expected O, but got Unknown
		//IL_06ef: Expected I4, but got O
		//IL_1dd1: Expected O, but got I
		//IL_1de3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1de8: Expected O, but got Unknown
		//IL_18c9: Expected O, but got I4
		//IL_179a: Expected O, but got I
		//IL_0979: Expected O, but got I4
		//IL_0986: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Expected O, but got Unknown
		//IL_0994: Unknown result type (might be due to invalid IL or missing references)
		//IL_0999: Expected O, but got Unknown
		//IL_1e7a: Expected I4, but got O
		//IL_0900: Expected O, but got I
		//IL_090b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0910: Expected O, but got Unknown
		//IL_1a34: Expected O, but got I4
		//IL_1a3c: Expected I4, but got O
		//IL_1a44: Expected I4, but got O
		//IL_1eb3: Expected O, but got I
		//IL_1ec9: Expected O, but got Ref
		//IL_1ed5: Expected native int or pointer, but got O
		//IL_1efb: Expected O, but got I
		//IL_1f1b: Expected O, but got I
		//IL_1f3a: Expected O, but got I
		//IL_1f42: Expected I4, but got O
		//IL_0a0a: Expected I, but got O
		//IL_0a22: Expected O, but got I
		//IL_1a7a: Expected I4, but got O
		//IL_0a6b: Expected O, but got I
		//IL_0a73: Expected I4, but got O
		//IL_1ae0: Expected I4, but got O
		//IL_0aad: Expected O, but got I
		//IL_1f5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f64: Expected O, but got Unknown
		//IL_1f7c: Expected O, but got I
		//IL_1f8a: Expected I4, but got O
		//IL_1fa8: Expected O, but got I4
		//IL_0b63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Expected O, but got Unknown
		//IL_0b70: Expected I, but got O
		//IL_0b80: Expected O, but got I
		//IL_2060: Expected O, but got I4
		//IL_0d8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d90: Expected O, but got Unknown
		//IL_0d98: Expected I, but got O
		//IL_0da8: Expected O, but got I
		//IL_1ffd: Expected O, but got I
		//IL_0c41: Expected O, but got I4
		//IL_0c53: Expected O, but got I
		//IL_0c5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c61: Expected O, but got Unknown
		//IL_2139: Unknown result type (might be due to invalid IL or missing references)
		//IL_213e: Expected O, but got Unknown
		//IL_0bec: Expected O, but got I
		//IL_20f2: Expected O, but got I
		//IL_0e69: Expected O, but got I4
		//IL_0e7b: Expected O, but got I
		//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e89: Expected O, but got Unknown
		//IL_1af7: Expected O, but got I4
		//IL_131a: Unknown result type (might be due to invalid IL or missing references)
		//IL_131f: Expected O, but got Unknown
		//IL_1327: Expected I, but got O
		//IL_1337: Expected O, but got I
		//IL_0e14: Expected O, but got I
		//IL_0eca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecf: Expected O, but got Unknown
		//IL_0ed7: Expected I, but got O
		//IL_0ee7: Expected O, but got I
		//IL_230b: Expected O, but got I
		//IL_21db: Expected O, but got I4
		//IL_13f8: Expected O, but got I4
		//IL_140a: Expected O, but got I
		//IL_1413: Unknown result type (might be due to invalid IL or missing references)
		//IL_1418: Expected O, but got Unknown
		//IL_216b: Expected O, but got I
		//IL_13a3: Expected O, but got I
		//IL_0f98: Expected O, but got I4
		//IL_0faa: Expected O, but got I
		//IL_0fb3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb8: Expected O, but got Unknown
		//IL_0f4b: Expected O, but got I
		//IL_15f4: Expected O, but got I4
		//IL_15fc: Expected I4, but got O
		//IL_2239: Expected O, but got I
		//IL_225b: Expected O, but got I4
		//IL_226e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2273: Expected O, but got Unknown
		//IL_229c: Expected I4, but got O
		//IL_1050: Expected I, but got O
		//IL_1068: Expected O, but got I
		//IL_1097: Unknown result type (might be due to invalid IL or missing references)
		//IL_109c: Expected O, but got Unknown
		//IL_10b2: Expected O, but got I
		//IL_10d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d8: Expected O, but got Unknown
		//IL_10ee: Expected O, but got I
		//IL_10f6: Expected I4, but got O
		//IL_22b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_22be: Expected O, but got Unknown
		//IL_22da: Unknown result type (might be due to invalid IL or missing references)
		//IL_22df: Expected O, but got Unknown
		//IL_1116: Unknown result type (might be due to invalid IL or missing references)
		//IL_111b: Expected O, but got Unknown
		//IL_1143: Unknown result type (might be due to invalid IL or missing references)
		//IL_1148: Expected O, but got Unknown
		//IL_1168: Unknown result type (might be due to invalid IL or missing references)
		//IL_116d: Expected O, but got Unknown
		//IL_1188: Unknown result type (might be due to invalid IL or missing references)
		//IL_118d: Expected O, but got Unknown
		//IL_1633: Expected I4, but got O
		//IL_11cd: Expected O, but got I
		//IL_123b: Expected O, but got I4
		//IL_125b: Expected O, but got I4
		//IL_0ca4: Expected O, but got I
		//IL_0cb4: Expected O, but got I
		//IL_0cf2: Expected I4, but got O
		//IL_129b: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a0: Expected O, but got Unknown
		//IL_12a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ae: Expected O, but got Unknown
		//IL_12e1: Expected I4, but got O
		//IL_12e9: Expected I4, but got O
		object obj2 = default(object);
		object obj = (object)(&obj2);
		_ = 0;
		_ = 0;
		_ = 0;
		JackarooMove[] array = (JackarooMove[])(this + 32);
		nint num = (nint)array;
		bool flag = array == null;
		object obj3 = 0;
		List<object> list = null;
		List<JackarooMove> list2 = allowedMoves;
		Card card2 = card;
		int num2 = (int)board;
		JackarooMove[] array2 = array;
		int num3 = rotatedPlayerIndex;
		IReadOnlyList<JackarooMarble> plantedMarbles;
		object obj8 = default(object);
		int num8 = default(int);
		bool flag5;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v3 (Il2CppClass<Jackaroo.JackarooMove[]>)+18]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v3 (Il2CppClass<Jackaroo.JackarooMove[]>)+1C]");
			array2 = (JackarooMove[])((nint)0 + (nint)1);
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v3 (Il2CppClass<Jackaroo.JackarooMove[]>)+18]");
			bool flag2 = (nint)0 < (nint)1;
			card2 = card;
			num2 = (int)board;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v3 (Il2CppClass<Jackaroo.JackarooMove[]>)+10]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v3 (Il2CppClass<Jackaroo.JackarooMove[]>)+18]");
				Array.Clear((Array)num4, 0, 0);
				card2 = null;
				num2 = 0;
			}
			object obj4 = this + 40;
			object obj5 = obj4;
			bool flag3 = obj4 == null;
			obj3 = 0;
			list = null;
			list2 = allowedMoves;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+18]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+1C]");
				array2 = (JackarooMove[])((nint)0 + (nint)1);
				_ = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+18]");
				object obj6 = -1;
				bool flag4 = obj6 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+18]");
				flag5 = (nint)0 < (nint)1;
				if (!flag5)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+10]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v10+18]");
					Array.Clear((Array)num5, 0, 0);
					card2 = null;
					num2 = 0;
				}
				bool flag6 = board == null;
				obj3 = 0;
				list = null;
				list2 = allowedMoves;
				if (!flag6)
				{
					plantedMarbles = board.GetPlantedMarbles(rotatedPlayerIndex);
					bool flag7 = plantedMarbles == null;
					obj3 = 0;
					list = null;
					list2 = allowedMoves;
					num2 = rotatedPlayerIndex;
					num3 = 0;
					if (!flag7)
					{
						object obj7 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2248;
						nint num6 = (nint)plantedMarbles;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v13 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
						array2 = (JackarooMove[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v13 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0319;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v13 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
						int num7 = (int)((nint)0 + (nint)8);
						bool flag8 = flag5;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X10_v70 (System.Int32)-8]");
							obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X10_v70 (System.Int32)-8]");
							obj6 = 0 - obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X10_v70 (System.Int32)-8]");
							if (0 == (nint)obj7)
							{
								break;
							}
							num8 = num7 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v365 @ X8_v13 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
							array2 = (JackarooMove[])(-1);
							obj6 = array2 - 1;
							flag4 = obj6 == null;
							flag5 = (nint)array2 != 1;
							num7 = num8;
							flag8 = flag5;
							if (flag5)
							{
								continue;
							}
							goto IL_0319;
						}
						array2 = (JackarooMove[])((int*)num7)->m_value;
						object obj9 = num6 + ((int*)num7)->m_value;
						object obj10 = obj9 + 312;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X0_v190+8]");
						num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v456 @ X0_v190] (should have been resolved before IL gen)");
						object obj11 = default(object);
						bool flag9 = obj11 == null;
						num8 = num7;
						flag5 = flag8;
						num3 = 0;
						if (!flag9)
						{
							goto IL_03f2;
						}
						goto IL_1b43;
					}
				}
			}
		}
		goto IL_1c4a;
		IL_1c4a:
		throw new NullReferenceException();
		IL_0319:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v187+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v410 @ X0_v187] (should have been resolved before IL gen)");
		object obj12 = default(object);
		bool flag10 = obj12 == null;
		object obj13 = !flag10;
		num3 = 0;
		if (obj13 != null)
		{
			goto IL_03f2;
		}
		goto IL_1b43;
		IL_24a3:
		object obj15;
		object obj17 = default(object);
		List<JackarooMove> result = default(List<JackarooMove>);
		List<System.Int32Enum>.Enumerator enumerator;
		while (true)
		{
			object obj14 = (nint)0 + (nint)2648;
			num2 = (int)obj14;
			((List<System.Int32Enum>.Enumerator*)enumerator)->Dispose();
			bool flag11 = obj15 == null;
			object obj16 = !flag11;
			if (obj16 != null)
			{
				OutOfMemoryException ex = new OutOfMemoryException();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				if (num2 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj15 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					object obj18 = obj17;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BB88");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return result;
			}
			break;
		}
		goto IL_1b43;
		IL_03f2:
		bool flag12 = _splitActions == null;
		obj3 = 0;
		list = null;
		list2 = allowedMoves;
		if (!flag12)
		{
			List<System.Int32Enum>.Enumerator enumerator2 = ((List<System.Int32Enum>)(object)_splitActions).GetEnumerator();
			List<System.Int32Enum>.Enumerator enumerator3 = (List<System.Int32Enum>.Enumerator)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
			obj3 = 0;
			list = null;
			Action<Card, JackarooMarbleMono> action2 = default(Action<Card, JackarooMarbleMono>);
			Action<Card, JackarooMarbleMono> action = action2;
			list2 = allowedMoves;
			IReadOnlyList<JackarooMarble> readOnlyList = plantedMarbles;
			List<object> list4 = default(List<object>);
			JackarooMarble jackarooMarble = default(JackarooMarble);
			object obj22 = default(object);
			object obj36 = default(object);
			JackarooMarble jackarooMarble6 = default(JackarooMarble);
			object obj29 = default(object);
			JackarooNode jackarooNode2 = default(JackarooNode);
			JackarooMarble jackarooMarble5 = default(JackarooMarble);
			(bool, object) tuple3 = default((bool, object));
			List<object> list7 = default(List<object>);
			int num11 = default(int);
			object obj27 = default(object);
			nint num13 = default(nint);
			List<object> list9 = default(List<object>);
			object obj74 = default(object);
			List<object> list6 = default(List<object>);
			object obj24 = default(object);
			JackarooMarble jackarooMarble3 = default(JackarooMarble);
			object obj88 = default(object);
			while (true)
			{
				List<System.Int32Enum>.Enumerator enumerator4 = (List<System.Int32Enum>.Enumerator)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 128));
				if (!((List<System.Int32Enum>.Enumerator*)enumerator4)->MoveNext())
				{
					goto IL_1b14;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-70]");
				(int, int) jackarooMoveFromSplit = GetJackarooMoveFromSplit(JackarooActions.NONE);
				object obj19 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3416;
				nint num9 = (nint)readOnlyList;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v26 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				array2 = (JackarooMove[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v26 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_057b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v26 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
				int num10 = (int)((nint)0 + (nint)8);
				bool flag13 = flag5;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X10_v65 (System.Int32)-8]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X10_v65 (System.Int32)-8]");
					object obj6 = 0 - obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X10_v65 (System.Int32)-8]");
					if (0 == (nint)obj19)
					{
						break;
					}
					num8 = num10 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v721 @ X8_v26 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
					array2 = (JackarooMove[])(-1);
					obj6 = array2 - 1;
					bool flag4 = obj6 == null;
					flag5 = (nint)array2 != 1;
					num10 = num8;
					flag13 = flag5;
					if (flag5)
					{
						continue;
					}
					goto IL_057b;
				}
				array2 = (JackarooMove[])((int*)num10)->m_value;
				object obj20 = num9 + ((int*)num10)->m_value;
				object obj21 = obj20 + 312;
				num8 = num10;
				flag5 = flag13;
				goto IL_1cf5;
				IL_17ca:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num3 = 0;
				goto IL_23aa;
				IL_1609:
				NullReferenceException ex2 = new NullReferenceException();
				num11 = 0;
				List<JackarooMove> list3;
				list2 = list3;
				Card card3;
				card2 = card3;
				num2 = (int)list4;
				goto IL_1b56;
				IL_15de:
				NullReferenceException ex3 = new NullReferenceException();
				list2 = null;
				card2 = (Card)rotatedPlayerIndex;
				num2 = (int)jackarooMarble;
				int num12;
				num3 = num12;
				goto IL_1b56;
				IL_0c76:
				NullReferenceException ex4 = new NullReferenceException();
				nint num14;
				num13 = num14;
				Action<Card, JackarooMarbleMono> action3;
				action = action3;
				goto IL_1b56;
				IL_057b:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num3 = 0;
				readOnlyList = plantedMarbles;
				goto IL_1cf5;
				IL_1cf5:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v792 @ X0_v35+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v792 @ X0_v35] (should have been resolved before IL gen)");
				if (obj22 == null)
				{
					goto IL_19ca;
				}
				num12 = (object)jackarooMoveFromSplit >> 32;
				int num15 = num11;
				object obj23 = obj24;
				JackarooMarble jackarooMarble2 = jackarooMarble3;
				object obj25 = obj8;
				object obj26 = obj27;
				object obj28 = obj29;
				JackarooMarble jackarooMarble4 = jackarooMarble5;
				JackarooNode jackarooNode = jackarooNode2;
				num14 = num13;
				action3 = action;
				list3 = list2;
				int num16 = num8;
				card3 = card2;
				int num17 = num3;
				object obj30 = obj22;
				List<JackarooNode> localWalkingNodes;
				object obj42;
				while (true)
				{
					object obj31 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
					object obj32 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ X8_v37+12E]");
					array2 = (JackarooMove[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ X8_v37+12E]");
					if ((nint)0 == 0)
					{
						goto IL_07f1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ X8_v37+B0]");
					int num18 = (int)((nint)0 + (nint)8);
					bool flag14 = flag5;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ X10_v60 (System.Int32)-8]");
						obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ X10_v60 (System.Int32)-8]");
						object obj6 = 0 - obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1131 @ X10_v60 (System.Int32)-8]");
						if (0 == (nint)obj31)
						{
							break;
						}
						num16 = num18 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v909 @ X8_v37+12E]");
						array2 = (JackarooMove[])(-1);
						obj6 = array2 - 1;
						bool flag4 = obj6 == null;
						flag5 = (nint)array2 != 1;
						num18 = num16;
						flag14 = flag5;
						if (flag5)
						{
							continue;
						}
						goto IL_07f1;
					}
					array2 = (JackarooMove[])((int*)num18)->m_value;
					object obj33 = obj32 + ((int*)num18)->m_value;
					object obj34 = obj33 + 312;
					num16 = num18;
					flag5 = flag14;
					goto IL_1d7c;
					IL_1d7c:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1155 @ X0_v42+8]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1155 @ X0_v42] (should have been resolved before IL gen)");
					object obj35 = obj36 & 1;
					if (obj35 == null)
					{
						break;
					}
					if (obj3 == null)
					{
						goto IL_19d8;
					}
					object obj37 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 824;
					object obj38 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ X8_v51+12E]");
					array2 = (JackarooMove[])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ X8_v51+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0954;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ X8_v51+B0]");
					int num19 = (int)((nint)0 + (nint)8);
					bool flag15 = flag5;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ X10_v55 (System.Int32)-8]");
						obj25 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ X10_v55 (System.Int32)-8]");
						object obj6 = 0 - obj37;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ X10_v55 (System.Int32)-8]");
						if (0 == (nint)obj37)
						{
							break;
						}
						num16 = num19 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ X8_v51+12E]");
						array2 = (JackarooMove[])(-1);
						obj6 = array2 - 1;
						bool flag4 = obj6 == null;
						flag5 = (nint)array2 != 1;
						num19 = num16;
						flag15 = flag5;
						if (flag5)
						{
							continue;
						}
						goto IL_0954;
					}
					array2 = (JackarooMove[])((int*)num19)->m_value;
					object obj39 = obj38 + ((int*)num19)->m_value;
					object obj40 = obj39 + 312;
					num16 = num19;
					flag5 = flag15;
					goto IL_1e11;
					IL_1e11:
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1350 @ X0_v56] (should have been resolved before IL gen)");
					bool flag16 = board.IsMarbleInLastBase(jackarooMarble6);
					bool flag17 = !flag16;
					object obj41 = !flag17;
					JackarooMarble jackarooMarble7 = jackarooMarble6;
					num17 = 0;
					if (obj41 == null)
					{
						localWalkingNodes = board.GetLocalWalkingNodes(jackarooMarble6, (int)jackarooMoveFromSplit, rotatedPlayerIndex);
						if (localWalkingNodes == null)
						{
							goto IL_1a0e;
						}
						bool item;
						if (localWalkingNodes._size != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-70]");
							bool flag18 = AreNodesWalkable(board, localWalkingNodes, rotatedPlayerIndex, jackarooMarble6, JackarooActions.NONE, card, action2);
							num14 = (nint)action2;
							action3 = (Action<Card, JackarooMarbleMono>)(object)card;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-70]");
							list3 = (List<JackarooMove>)0;
							item = flag18;
						}
						else
						{
							list3 = null;
							item = false;
						}
						_ = 0;
						_ = 0;
						obj42 = (nint)0 + (nint)3704;
						card3 = (Card)obj42;
						(bool, object) tuple = ((bool, object))System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 104));
						System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple, (ValueTuple<bool, object>)(item, localWalkingNodes));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-60]");
						num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-60]");
						array = (JackarooMove[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-68]");
						object obj43 = (nint)0 & (nint)1;
						bool flag19 = obj43 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-60]");
						jackarooMarble7 = (JackarooMarble)0;
						num17 = (int)localWalkingNodes;
						if (!flag19)
						{
							goto IL_0a42;
						}
					}
					bool flag20 = obj3 == null;
					obj30 = obj3;
					num11 = num15;
					obj24 = obj23;
					jackarooMarble3 = jackarooMarble2;
					obj8 = obj25;
					obj27 = obj26;
					obj29 = obj28;
					jackarooMarble5 = jackarooMarble4;
					jackarooNode2 = jackarooNode;
					num13 = num14;
					action = action3;
					list2 = list3;
					num8 = num16;
					card2 = card3;
					num2 = (int)jackarooMarble7;
					num3 = num17;
					if (!flag20)
					{
						continue;
					}
					goto IL_19ca;
					IL_0954:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					num17 = 0;
					goto IL_1e11;
					IL_07f1:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					num17 = 0;
					goto IL_1d7c;
				}
				object obj44 = (object)(&obj3);
				IReadOnlyList<JackarooMarble> readOnlyList2 = (IReadOnlyList<JackarooMarble>)obj44;
				bool flag21 = obj44 == null;
				JackarooMarble jackarooMarble8 = (JackarooMarble)3;
				object obj45 = 0;
				num11 = num15;
				obj24 = obj23;
				jackarooMarble3 = (JackarooMarble)3;
				obj8 = obj25;
				obj27 = obj26;
				List<object> list5 = list6;
				obj29 = obj28;
				jackarooMarble5 = jackarooMarble4;
				jackarooNode2 = jackarooNode;
				num13 = num14;
				action = action3;
				list2 = list3;
				num8 = num16;
				card2 = card3;
				bool flag22 = flag5;
				num3 = num17;
				object obj46 = 0;
				if (flag21)
				{
					goto IL_234e;
				}
				object obj47 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num20 = (nint)readOnlyList2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X8_v44 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				array2 = (JackarooMove[])0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X8_v44 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_17ca;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X8_v44 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
				int num21 = (int)((nint)0 + (nint)8);
				bool flag23 = flag5;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1324 @ X10_v19 (System.Int32)-8]");
					obj25 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1324 @ X10_v19 (System.Int32)-8]");
					if (0 == (nint)obj47)
					{
						break;
					}
					num16 = num21 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1221 @ X8_v44 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
					array2 = (JackarooMove[])(-1);
					flag5 = (nint)array2 != 1;
					num21 = num16;
					flag23 = flag5;
					if (flag5)
					{
						continue;
					}
					goto IL_17ca;
				}
				array2 = (JackarooMove[])((int*)num21)->m_value;
				object obj48 = num20 + ((int*)num21)->m_value;
				object obj49 = obj48 + 312;
				num16 = num21;
				flag5 = flag23;
				num3 = num17;
				goto IL_23aa;
				IL_15b8:
				NullReferenceException ex5 = new NullReferenceException();
				list2 = list3;
				card2 = card3;
				num3 = num17;
				goto IL_1b56;
				IL_1ae5:
				OutOfMemoryException ex6 = new OutOfMemoryException();
				jackarooMarble3 = (JackarooMarble)9;
				list2 = list3;
				card2 = card3;
				num3 = num17;
				goto IL_1b56;
				IL_0a42:
				if (jackarooMarble6 != null)
				{
					object obj50 = (nint)0 + (nint)1680;
					num2 = (int)obj50;
					object obj51 = Enumerable.Last((IEnumerable<object>)array);
					if (obj51 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1424 @ X0_v71 (System.Object)+20]");
						jackarooMarble5 = (JackarooMarble)0;
						board.SetNodeAndMarble(jackarooMarble6, (JackarooNode)obj51, jackarooMarble6.<Node>k__BackingField);
						object obj52 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
						object obj53 = obj52;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1442 @ X8_v70+B8]");
						object obj54 = 0;
						bool flag24 = JackarooAllowedRulesExtensions.HasRuleFlag((JackarooAllowedRules)obj54, JackarooAllowedRules.DISABLE_LAST_7_SHARED);
						bool flag25 = !flag24;
						object obj55 = !flag25;
						num2 = 16384;
						num3 = 0;
						IReadOnlyList<JackarooMarble> readOnlyList3 = plantedMarbles;
						if (obj55 == null)
						{
							bool flag26 = board.AreAllMarblesInBases(rotatedPlayerIndex);
							bool flag27 = !flag26;
							num2 = rotatedPlayerIndex;
							num3 = 0;
							readOnlyList3 = plantedMarbles;
							if (!flag27)
							{
								int teamMateIndex = board.GetTeamMateIndex(rotatedPlayerIndex);
								IReadOnlyList<JackarooMarble> plantedMarbles2 = board.GetPlantedMarbles(teamMateIndex);
								num2 = teamMateIndex;
								num3 = 0;
								readOnlyList3 = plantedMarbles2;
							}
						}
						if (readOnlyList3 != null)
						{
							object obj56 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3416;
							nint num22 = (nint)readOnlyList3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1466 @ X8_v74 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
							array2 = (JackarooMove[])0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1466 @ X8_v74 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_0c1c;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1466 @ X8_v74 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
							int num23 = (int)((nint)0 + (nint)8);
							bool flag28 = flag5;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1504 @ X10_v49 (System.Int32)-8]");
								obj25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1504 @ X10_v49 (System.Int32)-8]");
								if (0 == (nint)obj56)
								{
									break;
								}
								num16 = num23 + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1466 @ X8_v74 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
								array2 = (JackarooMove[])(-1);
								flag5 = (nint)array2 != 1;
								num23 = num16;
								flag28 = flag5;
								if (flag5)
								{
									continue;
								}
								goto IL_0c1c;
							}
							array2 = (JackarooMove[])((int*)num23)->m_value;
							object obj57 = num22 + ((int*)num23)->m_value;
							object obj58 = obj57 + 312;
							num16 = num23;
							flag5 = flag28;
							goto IL_2021;
						}
						NullReferenceException ex7 = new NullReferenceException();
						num13 = num14;
						action = action3;
						list2 = null;
						card2 = (Card)(object)jackarooMarble6.<Node>k__BackingField;
					}
					else
					{
						NullReferenceException ex8 = new NullReferenceException();
						num13 = num14;
						action = action3;
						list2 = list3;
						card2 = (Card)obj42;
						num3 = (int)localWalkingNodes;
					}
				}
				else
				{
					NullReferenceException ex9 = new NullReferenceException();
					num13 = num14;
					action = action3;
					list2 = list3;
					card2 = (Card)obj42;
					num3 = (int)localWalkingNodes;
				}
				goto IL_1b56;
				IL_1a0e:
				NullReferenceException ex10 = new NullReferenceException();
				num13 = num14;
				action = action3;
				list2 = null;
				card2 = (Card)rotatedPlayerIndex;
				num2 = (int)jackarooMarble6;
				num3 = (int)jackarooMoveFromSplit;
				goto IL_1b56;
				IL_19d8:
				NullReferenceException ex11 = new NullReferenceException();
				num13 = num14;
				action = action3;
				list2 = list3;
				card2 = card3;
				num3 = num17;
				goto IL_1b56;
				IL_1b56:
				object obj59 = 0;
				action2 = action;
				enumerator = enumerator3;
				object obj18 = 0;
				(bool, object) tuple2 = tuple3;
				break;
				IL_1b14:
				action2 = action;
				enumerator = enumerator3;
				obj18 = 0;
				tuple2 = tuple3;
				obj15 = 0;
				goto IL_24a3;
				IL_19ca:
				NullReferenceException ex12 = new NullReferenceException();
				goto IL_1b56;
				IL_13d3:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num17 = 0;
				goto IL_232f;
				IL_23aa:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1364 @ X0_v49+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1364 @ X0_v49] (should have been resolved before IL gen)");
				num11 = num15;
				obj24 = obj23;
				jackarooMarble3 = jackarooMarble8;
				obj8 = obj25;
				obj27 = obj26;
				list5 = list6;
				obj29 = obj28;
				jackarooMarble5 = jackarooMarble4;
				jackarooNode2 = jackarooNode;
				num13 = num14;
				action = action3;
				list2 = list3;
				num8 = num16;
				card2 = card3;
				flag22 = flag5;
				obj46 = obj45;
				goto IL_234e;
				IL_234e:
				bool flag29 = obj46 == null;
				object obj60 = !flag29;
				if (obj60 == null)
				{
					object obj6 = jackarooMarble3 - 3;
					bool flag4 = (nint)jackarooMarble3 == 3;
					obj59 = 0;
					list6 = list5;
					flag5 = flag22;
					readOnlyList = plantedMarbles;
					if (flag4)
					{
						continue;
					}
					bool flag30 = jackarooMarble3 == null;
					obj59 = 0;
					list6 = list5;
					flag5 = flag22;
					readOnlyList = plantedMarbles;
					if (flag30)
					{
						continue;
					}
					obj59 = 0;
					goto IL_1b14;
				}
				OutOfMemoryException ex13 = new OutOfMemoryException();
				goto IL_1b56;
				IL_232f:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1832 @ X0_v91+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1832 @ X0_v91] (should have been resolved before IL gen)");
				goto IL_1ae5;
				IL_0c1c:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num3 = 0;
				goto IL_2021;
				IL_2021:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1541 @ X0_v79+8]");
				num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1541 @ X0_v79] (should have been resolved before IL gen)");
				_ = 0;
				_ = ref list;
				bool flag31 = list7 == null;
				object obj61 = !flag31;
				list2 = null;
				card2 = (Card)(object)jackarooMarble6.<Node>k__BackingField;
				num11 = num15;
				obj24 = obj23;
				jackarooMarble3 = jackarooMarble2;
				obj8 = obj25;
				obj27 = obj26;
				num13 = num14;
				action = action3;
				list3 = null;
				num8 = num16;
				card3 = (Card)(object)jackarooMarble6.<Node>k__BackingField;
				num17 = num3;
				List<object> list8 = list7;
				if (obj61 != null)
				{
					while (true)
					{
						object obj62 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
						nint num24 = (nint)list8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1599 @ X8_v81 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+12E]");
						array2 = (JackarooMove[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1599 @ X8_v81 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0e44;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1599 @ X8_v81 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+B0]");
						int num25 = (int)((nint)0 + (nint)8);
						bool flag32 = flag5;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1632 @ X10_v43 (System.Int32)-8]");
							obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1632 @ X10_v43 (System.Int32)-8]");
							if (0 == (nint)obj62)
							{
								break;
							}
							num8 = num25 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1599 @ X8_v81 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+12E]");
							array2 = (JackarooMove[])(-1);
							flag5 = (nint)array2 != 1;
							num25 = num8;
							flag32 = flag5;
							if (flag5)
							{
								continue;
							}
							goto IL_0e44;
						}
						array2 = (JackarooMove[])((int*)num25)->m_value;
						object obj63 = num24 + ((int*)num25)->m_value;
						object obj64 = obj63 + 312;
						num8 = num25;
						flag5 = flag32;
						goto IL_2116;
						IL_218f:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1813 @ X0_v98+8]");
						num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1813 @ X0_v98] (should have been resolved before IL gen)");
						object obj65 = (object)jackarooMarble6 - (object)jackarooMarble;
						bool flag33 = obj65 == null;
						flag5 = !flag33;
						obj23 = !flag5;
						bool flag34;
						if (obj23 == null)
						{
							object obj66 = (object)jackarooMarble5 - (object)jackarooMarble;
							flag34 = obj66 == null;
						}
						else
						{
							flag34 = true;
						}
						if (!flag34)
						{
							List<JackarooNode> localWalkingNodes2 = board.GetLocalWalkingNodes(jackarooMarble, num12, rotatedPlayerIndex);
							if (localWalkingNodes2 == null)
							{
								goto IL_15de;
							}
							bool item2;
							if (localWalkingNodes2._size != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-70]");
								bool flag35 = AreNodesWalkable(board, localWalkingNodes2, rotatedPlayerIndex, jackarooMarble, JackarooActions.NONE, card, action2);
								num13 = (nint)action2;
								action = (Action<Card, JackarooMarbleMono>)(object)card;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-70]");
								list3 = (List<JackarooMove>)0;
								item2 = flag35;
							}
							else
							{
								list3 = null;
								item2 = false;
							}
							object obj67 = (nint)0 + (nint)3704;
							card3 = (Card)obj67;
							tuple3 = (item2, localWalkingNodes2);
							object obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj68 = tuple3 & 1;
							bool flag36 = obj68 == null;
							num11 = 0;
							num2 = 0;
							num17 = (int)localWalkingNodes2;
							if (!flag36)
							{
								object obj69 = typeof(List<AdaptivePerformanceScaler>) + 1976;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj70 = (nint)0 + (nint)2416;
								list9..ctor((IEnumerable<object>)array);
								object obj71 = typeof(List<AdaptivePerformanceScaler>) + 1976;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj72 = (nint)0 + (nint)2416;
								num3 = (int)obj72;
								list4..ctor((IEnumerable<object>)obj4);
								object obj73 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 248;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								obj74..ctor();
								object obj75 = obj74 + 16;
								obj75 = card;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj76 = obj74 + 32;
								obj76 = jackarooMarble6;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-70]");
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj77 = obj74 + 40;
								obj77 = list9;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj78 = obj74 + 48;
								obj78 = jackarooMarble;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj79 = obj74 + 56;
								obj79 = list4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								if (allowedMoves != null)
								{
									object obj80 = (nint)0 + (nint)2312;
									object obj81 = obj80;
									int version = allowedMoves._version + 1;
									allowedMoves._version = version;
									array2 = allowedMoves._items;
									if (allowedMoves._items != null)
									{
										num8 = allowedMoves._size;
										obj8 = array2.Length;
										bool flag37 = allowedMoves._size < array2.Length;
										object obj82 = !flag37;
										if (obj82 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1971 @ X8_v120+20]");
											object obj83 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1977 @ X8_v122+C0]");
											object obj84 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1876 @ X8_v123+70]");
											num17 = 0;
											((List<object>)(object)allowedMoves).AddWithResize(obj74);
											num11 = 0;
											obj27 = obj74;
											list6 = list4;
											num2 = (int)obj74;
										}
										else
										{
											int size = allowedMoves._size + 1;
											allowedMoves._size = size;
											object obj85 = allowedMoves._items + allowedMoves._size;
											object obj86 = obj85 + 32;
											obj86 = obj74;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											num11 = 0;
											obj27 = obj74;
											list6 = list4;
											num2 = (int)obj74;
											num17 = (int)obj72;
										}
										goto IL_0cf7;
									}
								}
								goto IL_1609;
							}
						}
						goto IL_0cf7;
						IL_0cf7:
						bool flag38 = list == null;
						num15 = num11;
						jackarooMarble2 = jackarooMarble;
						obj25 = obj8;
						obj26 = obj27;
						num14 = num13;
						action3 = action;
						list2 = list3;
						num16 = num8;
						card2 = card3;
						num3 = num17;
						obj24 = obj23;
						jackarooMarble3 = jackarooMarble;
						list8 = list;
						if (!flag38)
						{
							continue;
						}
						goto IL_0c76;
						IL_0f73:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						num17 = 0;
						goto IL_218f;
						IL_0e44:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						num17 = 0;
						goto IL_2116;
						IL_2116:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1656 @ X0_v83+8]");
						num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1656 @ X0_v83] (should have been resolved before IL gen)");
						object obj87 = obj88 & 1;
						if (obj87 == null)
						{
							break;
						}
						if (list == null)
						{
							goto IL_15b8;
						}
						object obj89 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 824;
						nint num26 = (nint)list;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ X8_v94 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+12E]");
						array2 = (JackarooMove[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ X8_v94 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0f73;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ X8_v94 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+B0]");
						int num27 = (int)((nint)0 + (nint)8);
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1754 @ X10_v38 (System.Int32)-8]");
							obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1754 @ X10_v38 (System.Int32)-8]");
							if (0 == (nint)obj89)
							{
								break;
							}
							num8 = num27 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1666 @ X8_v94 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+12E]");
							array2 = (JackarooMove[])(-1);
							bool flag39 = (nint)array2 != 1;
							num27 = num8;
							if (flag39)
							{
								continue;
							}
							goto IL_0f73;
						}
						array2 = (JackarooMove[])((int*)num27)->m_value;
						object obj90 = num26 + ((int*)num27)->m_value;
						object obj91 = obj90 + 312;
						num8 = num27;
						goto IL_218f;
					}
					if (list != null)
					{
						object obj92 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
						nint num28 = (nint)list;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1672 @ X8_v88 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+12E]");
						array2 = (JackarooMove[])0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1672 @ X8_v88 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+12E]");
						if ((nint)0 == 0)
						{
							goto IL_13d3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1672 @ X8_v88 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+B0]");
						int num29 = (int)((nint)0 + (nint)8);
						bool flag40 = flag5;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1775 @ X10_v30 (System.Int32)-8]");
							obj8 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1775 @ X10_v30 (System.Int32)-8]");
							if (0 == (nint)obj92)
							{
								break;
							}
							num8 = num29 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1672 @ X8_v88 (Il2CppClass<System.Collections.Generic.List`1<System.Object>>)+12E]");
							array2 = (JackarooMove[])(-1);
							flag5 = (nint)array2 != 1;
							num29 = num8;
							flag40 = flag5;
							if (flag5)
							{
								continue;
							}
							goto IL_13d3;
						}
						array2 = (JackarooMove[])((int*)num29)->m_value;
						object obj93 = num28 + ((int*)num29)->m_value;
						object obj94 = obj93 + 312;
						num8 = num29;
						flag5 = flag40;
						goto IL_232f;
					}
					goto IL_1ae5;
				}
				goto IL_0c76;
			}
		}
		goto IL_1c4a;
		IL_1b43:
		return allowedMoves;
	}

	private static IReadOnlyList<JackarooMarble> IsSharedFinal7(int rotatedPlayerIndex, JackarooBoard board, IReadOnlyList<JackarooMarble> otherMarbles)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I
		//IL_00c5: Expected I4, but got O
		//IL_00e3: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+B8]");
		object obj3 = 0;
		bool flag = JackarooAllowedRulesExtensions.HasRuleFlag((JackarooAllowedRules)obj3, JackarooAllowedRules.DISABLE_LAST_7_SHARED);
		bool flag2 = !flag;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			if (board == null)
			{
				return (IReadOnlyList<JackarooMarble>)new NullReferenceException();
			}
			if (board.AreAllMarblesInBases(rotatedPlayerIndex))
			{
				int teamMateIndex = board.GetTeamMateIndex(rotatedPlayerIndex);
				return board.GetPlantedMarbles(teamMateIndex);
			}
		}
		return otherMarbles;
	}

	private unsafe static (bool, List<JackarooNode>) GetAllowedSplitMoveAction(JackarooMarble marble, int rotatedPlayerIndex, JackarooBoard board, int move, JackarooActions jackarooAction, Card card, Action<Card, JackarooMarbleMono> onGuardedMarbleAdded)
	{
		//IL_00f9: Expected O, but got Ref
		//IL_010a: Expected native int or pointer, but got O
		//IL_00b2: Expected O, but got Ref
		if (board != null)
		{
			List<JackarooNode> localWalkingNodes = board.GetLocalWalkingNodes(marble, move, rotatedPlayerIndex);
			if (localWalkingNodes != null)
			{
				bool item;
				(bool, object) tuple;
				(bool, List<JackarooNode>) result = default((bool, List<JackarooNode>));
				if (localWalkingNodes._size != 0 && AreNodesWalkable(board, localWalkingNodes, rotatedPlayerIndex, marble, jackarooAction, card, onGuardedMarbleAdded))
				{
					item = true;
					tuple = ((bool, object))(&result);
				}
				else
				{
					item = false;
					tuple = ((bool, object))(&result);
				}
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)tuple, (ValueTuple<bool, object>)(item, localWalkingNodes));
				return result;
			}
		}
		return ((bool, List<JackarooNode>))new NullReferenceException();
	}

	public static (int, int) GetJackarooMoveFromSplit(JackarooActions jackarooAction)
	{
		//IL_0110: Expected O, but got I4
		//IL_011e: Expected O, but got I4
		//IL_038b: Expected O, but got I4
		//IL_001f: Expected O, but got I4
		//IL_002d: Expected O, but got I4
		//IL_0047: Expected O, but got I4
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		//IL_0167: Expected O, but got I4
		//IL_0175: Expected O, but got I4
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_031d: Expected O, but got I4
		//IL_032b: Expected O, but got I4
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_0262: Expected O, but got I4
		//IL_03be: Expected O, but got I4
		//IL_007c: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_041c: Expected O, but got I
		if (jackarooAction > JackarooActions.MOVE_SPLIT_4_3)
		{
			bool flag = jackarooAction < JackarooActions.SWAP;
			object obj = !flag;
			object obj2 = jackarooAction - 8192;
			bool flag2 = obj2 == null;
			object obj3 = !flag2;
			object obj4 = obj & obj3;
			if (obj4 == null)
			{
				bool flag3 = jackarooAction < JackarooActions.MOVE_SPLIT_6_1;
				object obj5 = !flag3;
				object obj6 = jackarooAction - 2048;
				bool flag4 = obj6 == null;
				object obj7 = ~obj5;
				object obj8 = obj7 | flag4;
				if (obj8 == null)
				{
					if (jackarooAction == JackarooActions.MOVE_SPLIT_7_0)
					{
						return (7, 0);
					}
				}
				else
				{
					switch (jackarooAction)
					{
					case JackarooActions.MOVE_SPLIT_6_1:
						return (6, 1);
					case JackarooActions.MOVE_SPLIT_5_2:
						return (5, 2);
					}
				}
			}
			else
			{
				bool flag5 = jackarooAction < JackarooActions.BURN_OTHER_CARD;
				object obj9 = !flag5;
				object obj10 = jackarooAction - 32768;
				bool flag6 = obj10 == null;
				object obj11 = ~obj9;
				object obj12 = obj11 | flag6;
				if (obj12 == null)
				{
					if (jackarooAction == JackarooActions.BURN_OTHER_CARD_RANDOM)
					{
					}
				}
				else
				{
					object obj13 = jackarooAction & (JackarooActions)65535;
					if ((nint)obj13 != 16384)
					{
						goto IL_03d6;
					}
				}
			}
		}
		else
		{
			bool flag7 = jackarooAction < JackarooActions.MOVE_CHOICE_11;
			object obj14 = !flag7;
			object obj15 = jackarooAction - 32;
			bool flag8 = obj15 == null;
			if (jackarooAction > JackarooActions.MOVE_CHOICE_11)
			{
				bool flag9 = jackarooAction < JackarooActions.MOVE_SPLIT_2_5;
				object obj16 = !flag9;
				object obj17 = jackarooAction - 128;
				bool flag10 = obj17 == null;
				object obj18 = ~obj16;
				object obj19 = obj18 | flag10;
				if (obj19 == null)
				{
					switch (jackarooAction)
					{
					case JackarooActions.MOVE_SPLIT_4_3:
						return (4, 3);
					case JackarooActions.MOVE_SPLIT_3_4:
						return (3, 4);
					}
				}
				else
				{
					object obj20 = jackarooAction & (JackarooActions)255;
					if ((nint)obj20 == 64)
					{
						return (1, 6);
					}
					if (jackarooAction == JackarooActions.MOVE_SPLIT_2_5)
					{
						return (2, 5);
					}
				}
			}
			else
			{
				object obj21 = !flag8;
				object obj22 = obj14 & obj21;
				if (obj22 != null)
				{
				}
			}
		}
		object obj23 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj24 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		goto IL_03d6;
		IL_03d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = "https://www.kammelna.com/Home/Terms" + 4064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj26 = (nint)0 + (nint)896;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return ((int, int))new OutOfMemoryException();
	}

	private static List<JackarooMove> GetAllowedMoveReverseAction(JackarooBoard board, int rotatedPlayerIndex, Card card, JackarooActions jackarooAction, List<JackarooMove> jackarooMoves, Action<Card, JackarooMarbleMono> onGuardedMarbleAdded)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_005e: Expected I, but got O
		//IL_006e: Expected O, but got I
		//IL_016c: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_033c: Expected I, but got O
		//IL_034c: Expected O, but got I
		//IL_01bc: Expected O, but got I4
		//IL_087c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0881: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_022d: Expected O, but got I4
		//IL_026d: Expected O, but got I4
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected O, but got Unknown
		//IL_0387: Expected O, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_0634: Expected O, but got I4
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected O, but got Unknown
		//IL_09dc: Expected O, but got I4
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_03b8: Expected O, but got I
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected O, but got Unknown
		//IL_0655: Expected I, but got O
		//IL_0665: Expected O, but got I
		//IL_047d: Expected I, but got O
		//IL_048d: Expected O, but got I
		//IL_06a0: Expected O, but got I
		//IL_09a7: Expected O, but got I4
		//IL_04c8: Expected O, but got I
		//IL_0326: Expected I4, but got O
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected O, but got Unknown
		//IL_0715: Unknown result type (might be due to invalid IL or missing references)
		//IL_071a: Expected O, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected O, but got Unknown
		//IL_05c6: Expected I, but got O
		//IL_05d6: Expected O, but got I4
		//IL_05de: Expected I4, but got O
		//IL_05ee: Expected O, but got I4
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected O, but got Unknown
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected O, but got Unknown
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b3: Expected O, but got Unknown
		//IL_06c9: Expected O, but got I
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_04f9: Expected O, but got I
		//IL_0504: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Expected O, but got Unknown
		bool flag = board == null;
		List<JackarooMove> list = jackarooMoves;
		Card card2 = card;
		object obj3;
		bool flag4 = default(bool);
		int num3;
		IReadOnlyList<JackarooMarble> readOnlyList = default(IReadOnlyList<JackarooMarble>);
		Action<Card, JackarooMarbleMono> action;
		JackarooActions jackarooActions;
		IReadOnlyList<JackarooMarble> readOnlyList2;
		Card card3;
		object obj8;
		object obj9;
		Action<Card, JackarooMarbleMono> action2 = default(Action<Card, JackarooMarbleMono>);
		JackarooActions jackarooActions2 = default(JackarooActions);
		object obj5 = default(object);
		int num = default(int);
		if (!flag)
		{
			IReadOnlyList<JackarooMarble> plantedMarbles = board.GetPlantedMarbles(num);
			bool flag2 = plantedMarbles == null;
			list = jackarooMoves;
			card2 = null;
			if (!flag2)
			{
				object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3416;
				nint num2 = (nint)plantedMarbles;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v15 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v15 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0126;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v15 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
				obj3 = (nint)0 + (nint)8;
				bool flag3 = flag4;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X10_v11-8]");
					object obj4 = 0 - obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X10_v11-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj5 = obj3 + 16;
					obj2--;
					obj4 = obj2 - 1;
					bool flag5 = obj4 == null;
					flag4 = (nint)obj2 != 1;
					flag3 = flag4;
					obj3 = obj5;
					if (flag4)
					{
						continue;
					}
					goto IL_0126;
				}
				object obj6 = num2 + obj3;
				object obj7 = obj6 + 312;
				obj8 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X8_v31+8]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v288 @ X8_v31] (should have been resolved before IL gen)");
				bool flag6 = readOnlyList == null;
				readOnlyList2 = readOnlyList;
				obj9 = 0;
				flag4 = flag3;
				obj5 = obj3;
				card3 = null;
				action = action2;
				list = jackarooMoves;
				jackarooActions = jackarooActions2;
				readOnlyList2 = readOnlyList;
				obj9 = 0;
				card2 = null;
				if (!flag6)
				{
					goto IL_0282;
				}
				goto IL_073a;
			}
		}
		goto IL_085e;
		IL_0126:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj10 = default(object);
		obj8 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v48+8]");
		num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v238 @ X0_v48] (should have been resolved before IL gen)");
		bool flag7 = readOnlyList == null;
		object obj11 = !flag7;
		readOnlyList2 = readOnlyList;
		obj9 = 0;
		card3 = null;
		if (obj11 != null)
		{
			goto IL_0282;
		}
		action = action2;
		list = jackarooMoves;
		jackarooActions = jackarooActions2;
		readOnlyList2 = readOnlyList;
		obj9 = 0;
		obj3 = obj5;
		card2 = null;
		goto IL_073a;
		IL_0282:
		object obj12 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj13 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 824;
		IntPtr intPtr = default(IntPtr);
		nint num4 = intPtr;
		Action<Card, JackarooMarbleMono> action3 = action2;
		List<JackarooMove> list2 = jackarooMoves;
		JackarooActions jackarooActions3 = jackarooActions2;
		IReadOnlyList<JackarooMarble> readOnlyList3 = readOnlyList;
		object obj18 = default(object);
		JackarooMarble jackarooMarble = default(JackarooMarble);
		while (true)
		{
			nint num5 = (nint)readOnlyList3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v20 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v20 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_040c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v20 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
			object obj14 = (nint)0 + (nint)8;
			bool flag8 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X10_v25-8]");
				object obj4 = 0 - obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X10_v25-8]");
				if (0 == (nint)obj12)
				{
					break;
				}
				obj5 = obj14 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v20 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				obj8 = -1;
				obj4 = obj8 - 1;
				bool flag5 = obj4 == null;
				flag4 = (nint)obj8 != 1;
				flag8 = flag4;
				obj14 = obj5;
				if (flag4)
				{
					continue;
				}
				goto IL_040c;
			}
			obj8 = obj14;
			object obj15 = num5 + obj14;
			object obj16 = obj15 + 312;
			flag4 = flag8;
			obj5 = obj14;
			goto IL_08eb;
			IL_08eb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X0_v30+8]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v572 @ X0_v30] (should have been resolved before IL gen)");
			object obj17 = obj18 & 1;
			if (obj17 == null)
			{
				break;
			}
			if (readOnlyList2 == null)
			{
				goto IL_0748;
			}
			nint num6 = (nint)readOnlyList2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v23 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v23 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_054d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v23 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
			object obj19 = (nint)0 + (nint)8;
			bool flag9 = flag4;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X10_v20-8]");
				object obj4 = 0 - obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X10_v20-8]");
				if (0 == (nint)obj13)
				{
					break;
				}
				obj5 = obj19 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X8_v23 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				obj8 = -1;
				obj4 = obj8 - 1;
				bool flag5 = obj4 == null;
				flag4 = (nint)obj8 != 1;
				flag9 = flag4;
				obj19 = obj5;
				if (flag4)
				{
					continue;
				}
				goto IL_054d;
			}
			obj8 = obj19;
			object obj20 = num6 + obj19;
			object obj21 = obj20 + 312;
			flag4 = flag9;
			obj5 = obj19;
			goto IL_0972;
			IL_0972:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v692 @ X0_v34] (should have been resolved before IL gen)");
			bool flag10 = board.IsMarbleAtBase(jackarooMarble);
			bool flag11 = !flag10;
			object obj22 = !flag11;
			card3 = null;
			JackarooMarble jackarooMarble2 = jackarooMarble;
			if (obj22 == null)
			{
				List<JackarooMove> allowedMoveAction = GetAllowedMoveAction(jackarooMarble, num, board, card, jackarooActions2, jackarooMoves, action2);
				num4 = (nint)action2;
				action3 = (Action<Card, JackarooMarbleMono>)(object)jackarooMoves;
				list2 = (List<JackarooMove>)jackarooActions2;
				jackarooActions3 = (JackarooActions)card;
				card3 = (Card)(object)board;
				jackarooMarble2 = (JackarooMarble)num;
			}
			bool flag12 = readOnlyList2 == null;
			readOnlyList3 = readOnlyList2;
			intPtr = num4;
			action = action3;
			list = list2;
			jackarooActions = jackarooActions3;
			obj3 = obj5;
			card2 = card3;
			num3 = (int)jackarooMarble2;
			if (!flag12)
			{
				continue;
			}
			goto IL_073a;
			IL_054d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			card3 = null;
			goto IL_0972;
			IL_040c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			card3 = null;
			goto IL_08eb;
		}
		intPtr = num4;
		action2 = action3;
		list = list2;
		jackarooActions2 = jackarooActions3;
		card2 = card3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X0_v30+8]");
		num = 0;
		object obj23 = 0;
		object obj29 = default(object);
		while (true)
		{
			if (readOnlyList2 == null)
			{
				goto IL_09c2;
			}
			object obj24 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			nint num7 = (nint)readOnlyList2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_06f1;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
			object obj25 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X10_v7-8]");
				if (0 == (nint)obj24)
				{
					break;
				}
				obj5 = obj25 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				obj8 = -1;
				bool flag13 = (nint)obj8 != 1;
				obj25 = obj5;
				if (flag13)
				{
					continue;
				}
				goto IL_06f1;
			}
			obj8 = obj25;
			object obj26 = num7 + obj25;
			object obj27 = obj26 + 312;
			obj5 = obj25;
			goto IL_0a0e;
			IL_09c2:
			bool flag14 = obj23 == null;
			object obj28 = !flag14;
			if (obj28 == null)
			{
				return jackarooMoves;
			}
			OutOfMemoryException ex = new OutOfMemoryException();
			if (num != 1)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			obj23 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj9 = obj29;
			continue;
			IL_06f1:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			card2 = null;
			goto IL_0a0e;
			IL_0a0e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X0_v5+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v634 @ X0_v5] (should have been resolved before IL gen)");
			goto IL_09c2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		List<JackarooMove> result = default(List<JackarooMove>);
		return result;
		IL_0786:
		action2 = action;
		jackarooActions2 = jackarooActions;
		obj5 = obj3;
		num = num3;
		goto IL_085e;
		IL_0748:
		NullReferenceException ex2 = new NullReferenceException();
		intPtr = num4;
		action = action3;
		list = list2;
		jackarooActions = jackarooActions3;
		obj3 = obj5;
		card2 = card3;
		goto IL_0786;
		IL_085e:
		throw new NullReferenceException();
		IL_073a:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_0786;
	}

	private static List<JackarooMove> GetAllowedMoveAction(JackarooBoard board, int rotatedPlayerIndex, Card card, JackarooActions jackarooAction, List<JackarooMove> jackarooMoves, Action<Card, JackarooMarbleMono> onGuardedMarbleAdded)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_005e: Expected I, but got O
		//IL_006e: Expected O, but got I
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_067b: Expected O, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_068f: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0548: Expected O, but got I4
		//IL_018f: Expected O, but got I
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_0734: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected O, but got Unknown
		//IL_01ca: Expected O, but got I
		//IL_03fe: Expected O, but got I4
		//IL_0417: Expected O, but got I4
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e7: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_082b: Expected O, but got I4
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_0434: Expected O, but got I
		//IL_02d0: Expected O, but got I
		//IL_046f: Expected O, but got I
		//IL_07d7: Expected O, but got I4
		//IL_07df: Expected I4, but got O
		//IL_030b: Expected O, but got I
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_0498: Expected O, but got I
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_033c: Expected O, but got I
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		bool flag = board == null;
		List<JackarooMove> list = jackarooMoves;
		Card card2 = card;
		bool flag4 = default(bool);
		object obj7;
		int num = default(int);
		if (!flag)
		{
			IReadOnlyList<JackarooMarble> plantedMarbles = board.GetPlantedMarbles(num);
			bool flag2 = plantedMarbles == null;
			list = jackarooMoves;
			card2 = null;
			if (!flag2)
			{
				object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3416;
				nint num2 = (nint)plantedMarbles;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v13 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v13 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0126;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v13 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooMarble>>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				bool flag3 = flag4;
				object obj5;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X10_v29-8]");
					object obj4 = 0 - obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X10_v29-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj5 = obj3 + 16;
					obj2--;
					obj4 = obj2 - 1;
					bool flag5 = obj4 == null;
					flag4 = (nint)obj2 != 1;
					flag3 = flag4;
					obj3 = obj5;
					if (flag4)
					{
						continue;
					}
					goto IL_0126;
				}
				object obj6 = num2 + obj3;
				obj7 = obj6 + 312;
				flag4 = flag3;
				obj5 = obj3;
				card2 = null;
				goto IL_0653;
			}
		}
		goto IL_0607;
		IL_0126:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		card2 = null;
		object obj8 = default(object);
		obj7 = obj8;
		goto IL_0653;
		IL_0653:
		object obj9 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj10 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 824;
		object obj11 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v14+8]");
		int num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v298 @ X8_v14] (should have been resolved before IL gen)");
		Action<Card, JackarooMarbleMono> action2 = default(Action<Card, JackarooMarbleMono>);
		Action<Card, JackarooMarbleMono> action = action2;
		list = jackarooMoves;
		JackarooActions jackarooActions2 = default(JackarooActions);
		JackarooActions jackarooActions = jackarooActions2;
		object obj13 = default(object);
		object obj19 = default(object);
		object obj32 = default(object);
		List<JackarooMove> result = default(List<JackarooMove>);
		JackarooMarble marble = default(JackarooMarble);
		object obj24;
		object obj25;
		while (true)
		{
			if (obj13 != null)
			{
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+12E]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+12E]");
				if ((nint)0 == 0)
				{
					goto IL_024f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+B0]");
				object obj15 = (nint)0 + (nint)8;
				bool flag6 = flag4;
				object obj5;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X10_v24-8]");
					object obj4 = 0 - obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X10_v24-8]");
					if (0 == (nint)obj9)
					{
						break;
					}
					obj5 = obj15 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X8_v18+12E]");
					obj12 = -1;
					obj4 = obj12 - 1;
					bool flag5 = obj4 == null;
					flag4 = (nint)obj12 != 1;
					flag6 = flag4;
					obj15 = obj5;
					if (flag4)
					{
						continue;
					}
					goto IL_024f;
				}
				obj12 = obj15;
				object obj16 = obj14 + obj15;
				object obj17 = obj16 + 312;
				flag4 = flag6;
				obj5 = obj15;
				goto IL_0710;
			}
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_024f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			card2 = null;
			goto IL_0710;
			IL_0710:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v30+8]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v553 @ X0_v30] (should have been resolved before IL gen)");
			object obj18 = obj19 & 1;
			if (obj18 != null)
			{
				if (obj13 != null)
				{
					object obj20 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v21+12E]");
					obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v21+12E]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v21+B0]");
						object obj21 = (nint)0 + (nint)8;
						bool flag7 = flag4;
						object obj5;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X10_v19-8]");
							object obj4 = 0 - obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X10_v19-8]");
							if (0 == (nint)obj10)
							{
								break;
							}
							obj5 = obj21 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v21+12E]");
							obj12 = -1;
							obj4 = obj12 - 1;
							bool flag5 = obj4 == null;
							flag4 = (nint)obj12 != 1;
							flag7 = flag4;
							obj21 = obj5;
							if (flag4)
							{
								continue;
							}
							goto IL_0390;
						}
						obj12 = obj21;
						object obj22 = obj20 + obj21;
						object obj23 = obj22 + 312;
						flag4 = flag7;
						obj5 = obj21;
						goto IL_0797;
					}
					goto IL_0390;
				}
				NullReferenceException ex2 = new NullReferenceException();
				break;
			}
			action2 = action;
			jackarooActions2 = jackarooActions;
			obj24 = obj13;
			obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v30+8]");
			num = 0;
			object obj26 = 0;
			while (true)
			{
				if (obj24 == null)
				{
					goto IL_0811;
				}
				object obj27 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v5+12E]");
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v5+12E]");
				if ((nint)0 == 0)
				{
					goto IL_04c0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v5+B0]");
				object obj28 = (nint)0 + (nint)8;
				object obj5;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X10_v7-8]");
					if (0 == (nint)obj11)
					{
						break;
					}
					obj5 = obj28 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X8_v5+12E]");
					obj12 = -1;
					bool flag8 = (nint)obj12 != 1;
					obj28 = obj5;
					if (flag8)
					{
						continue;
					}
					goto IL_04c0;
				}
				obj12 = obj28;
				object obj29 = obj27 + obj28;
				object obj30 = obj29 + 312;
				obj5 = obj28;
				goto IL_085d;
				IL_0811:
				bool flag9 = obj26 == null;
				object obj31 = !flag9;
				if (obj31 == null)
				{
					return jackarooMoves;
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				if (num != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj26 = obj32;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj25 = obj32;
				continue;
				IL_04c0:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				card2 = null;
				goto IL_085d;
				IL_085d:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v582 @ X0_v5+8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v582 @ X0_v5] (should have been resolved before IL gen)");
				goto IL_0811;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return result;
			IL_0390:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			card2 = null;
			goto IL_0797;
			IL_0797:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v643 @ X0_v34] (should have been resolved before IL gen)");
			List<JackarooMove> allowedMoveAction = GetAllowedMoveAction(marble, num, board, card, jackarooActions2, jackarooMoves, action2);
			action = (Action<Card, JackarooMarbleMono>)(object)jackarooMoves;
			list = (List<JackarooMove>)jackarooActions2;
			jackarooActions = (JackarooActions)card;
			card2 = (Card)(object)board;
			num3 = num;
		}
		action2 = action;
		jackarooActions2 = jackarooActions;
		obj24 = obj13;
		obj25 = 0;
		num = num3;
		goto IL_0607;
		IL_0607:
		throw new NullReferenceException();
	}

	private static List<JackarooMove> GetAllowedMoveAction(JackarooMarble marble, int rotatedPlayerIndex, JackarooBoard board, Card card, JackarooActions jackarooAction, List<JackarooMove> jackarooMoves, Action<Card, JackarooMarbleMono> onGuardedMarbleAdded)
	{
		//IL_0030: Expected O, but got I4
		//IL_00f9: Expected I4, but got I8
		//IL_0212: Expected O, but got I4
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		if (board != null)
		{
			bool flag = board.IsMarbleInLastBase(marble);
			bool flag2 = !flag;
			object obj = !flag2;
			if (obj != null)
			{
				goto IL_0290;
			}
			int count;
			if (jackarooAction != JackarooActions.MOVE_CHOICE_1)
			{
				if (jackarooAction == JackarooActions.MOVE_CHOICE_11)
				{
					count = 11;
				}
				else
				{
					if (card == null)
					{
						goto IL_0295;
					}
					int num = (int)(card.<Rank>k__BackingField + 2);
					count = (int)((card.<Rank>k__BackingField != Rank.FOUR) ? num : 4294967292L);
				}
			}
			else
			{
				count = 1;
			}
			List<JackarooNode> localWalkingNodes = board.GetLocalWalkingNodes(marble, count, rotatedPlayerIndex);
			if (localWalkingNodes != null)
			{
				if (localWalkingNodes._size == 0 || !AreNodesWalkable(board, localWalkingNodes, rotatedPlayerIndex, marble, jackarooAction, card, onGuardedMarbleAdded))
				{
					goto IL_0290;
				}
				JackarooMove move = JackarooMove.GetMove(card, jackarooAction, marble, localWalkingNodes);
				if (jackarooMoves != null)
				{
					int version = jackarooMoves._version + 1;
					jackarooMoves._version = version;
					JackarooMove[] items = jackarooMoves._items;
					if (jackarooMoves._items != null)
					{
						bool flag3 = jackarooMoves._size < items.Length;
						object obj2 = !flag3;
						if (obj2 == null)
						{
							int size = jackarooMoves._size + 1;
							jackarooMoves._size = size;
							object obj3 = jackarooMoves._items + jackarooMoves._size;
							object obj4 = obj3 + 32;
							obj4 = move;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						}
						else
						{
							((List<object>)(object)jackarooMoves).AddWithResize((object)move);
						}
						goto IL_0290;
					}
				}
			}
		}
		goto IL_0295;
		IL_0290:
		return jackarooMoves;
		IL_0295:
		return (List<JackarooMove>)(object)new NullReferenceException();
	}

	private static bool AreNodesWalkable(JackarooBoard board, List<JackarooNode> nodes, int rotatedPlayerIndex, JackarooMarble marble, JackarooActions jackarooAction, Card card, Action<Card, JackarooMarbleMono> onGuardedMarbleAdded)
	{
		//IL_0114: Expected O, but got I4
		//IL_0122: Expected O, but got I4
		//IL_01f6: Expected O, but got I4
		//IL_003a: Expected O, but got I4
		//IL_0048: Expected O, but got I4
		//IL_0062: Expected O, but got I4
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_016b: Expected O, but got I4
		//IL_0179: Expected O, but got I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_021f: Expected O, but got I4
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_024b: Expected O, but got I4
		//IL_02e4: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_00a5: Expected O, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_03e1: Expected O, but got I
		//IL_03fe: Expected I4, but got O
		if (jackarooAction > JackarooActions.MOVE_SPLIT_4_3)
		{
			bool flag = jackarooAction < JackarooActions.SWAP;
			object obj = !flag;
			object obj2 = jackarooAction - 8192;
			bool flag2 = obj2 == null;
			object obj3 = !flag2;
			object obj4 = obj & obj3;
			if (obj4 == null)
			{
				bool flag3 = jackarooAction < JackarooActions.MOVE_SPLIT_6_1;
				object obj5 = !flag3;
				object obj6 = jackarooAction - 2048;
				bool flag4 = obj6 == null;
				object obj7 = ~obj5;
				object obj8 = obj7 | flag4;
				if (obj8 == null)
				{
					if (jackarooAction == JackarooActions.MOVE_SPLIT_7_0)
					{
						goto IL_0321;
					}
				}
				else if (jackarooAction == JackarooActions.MOVE_SPLIT_5_2 || jackarooAction == JackarooActions.MOVE_SPLIT_6_1)
				{
					goto IL_0321;
				}
			}
		}
		else
		{
			bool flag5 = jackarooAction < JackarooActions.MOVE_CHOICE_11;
			object obj9 = !flag5;
			object obj10 = jackarooAction - 32;
			bool flag6 = obj10 == null;
			if (jackarooAction > JackarooActions.MOVE_CHOICE_11)
			{
				bool flag7 = jackarooAction < JackarooActions.MOVE_SPLIT_2_5;
				object obj11 = !flag7;
				object obj12 = jackarooAction - 128;
				bool flag8 = obj12 == null;
				object obj13 = ~obj11;
				object obj14 = obj13 | flag8;
				if (obj14 == null)
				{
					if (jackarooAction == JackarooActions.MOVE_SPLIT_3_4 || jackarooAction == JackarooActions.MOVE_SPLIT_4_3)
					{
						goto IL_0321;
					}
				}
				else
				{
					object obj15 = jackarooAction & (JackarooActions)255;
					if ((nint)obj15 == 64 || jackarooAction == JackarooActions.MOVE_SPLIT_2_5)
					{
						goto IL_0321;
					}
				}
			}
			else
			{
				object obj16 = !flag6;
				object obj17 = obj9 & obj16;
				if (obj17 == null)
				{
					object obj18 = 1 << (int)jackarooAction;
					object obj19 = obj18 & 0x100010016L;
					bool flag9 = obj19 == null;
					object obj20 = !flag9;
					if (obj20 != null)
					{
						goto IL_0321;
					}
					if (jackarooAction == JackarooActions.MOVE_EAT_PATH)
					{
						return AreNodesWalkableForMOVE_EAT_PATH(board, nodes, card, onGuardedMarbleAdded);
					}
				}
			}
		}
		object obj21 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj22 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = "https://www.kammelna.com/Home/Terms" + 4064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj24 = (nint)0 + (nint)888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (byte)(int)ex2 != 0;
		IL_0321:
		return AreNodesWalkableForMove(board, nodes, rotatedPlayerIndex, marble, jackarooAction, card, onGuardedMarbleAdded);
	}

	private static bool AreNodesWalkableForMove(JackarooBoard board, List<JackarooNode> nodes, int rotatedPlayerIndex, JackarooMarble marbleToMove, JackarooActions jackarooAction, Card card, Action<Card, JackarooMarbleMono> onGuardedMarbleAdded)
	{
		//IL_069c: Expected I4, but got O
		//IL_0062: Expected O, but got I4
		//IL_00c4: Expected O, but got I
		//IL_0103: Expected O, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_06d1: Expected I, but got O
		//IL_070d: Expected O, but got I4
		//IL_04a7: Expected O, but got I
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected O, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_04f4: Expected O, but got I4
		//IL_0190: Expected O, but got I4
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		//IL_074c: Expected O, but got I
		//IL_075a: Expected I4, but got O
		//IL_0778: Expected O, but got I4
		//IL_05e3: Expected O, but got I4
		//IL_03a9: Expected O, but got I4
		//IL_036e: Expected O, but got I4
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Expected O, but got Unknown
		//IL_02c1: Expected O, but got I4
		//IL_0635: Expected O, but got I4
		object obj = Enumerable.Last((IEnumerable<object>)nodes);
		if (jackarooAction == JackarooActions.MOVE_REVERSE)
		{
			if (nodes != null)
			{
				((List<object>)(object)nodes).Reverse();
				goto IL_004f;
			}
		}
		else if (nodes != null)
		{
			goto IL_004f;
		}
		goto IL_068e;
		IL_0786:
		bool flag = onGuardedMarbleAdded == null;
		bool result = false;
		object obj3;
		if (!flag)
		{
			object obj2 = obj3 & 1;
			bool flag2 = obj2 == null;
			object obj4 = !flag2;
			result = false;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [onGuardedMarbleAdded @ X6 (System.Action`2<Card, Jackaroo.JackarooMarbleMono>)+18] (should have been resolved before IL gen)");
				result = false;
			}
		}
		goto IL_071b;
		IL_071b:
		return result;
		IL_03dc:
		if (jackarooAction == JackarooActions.MOVE_REVERSE)
		{
			((List<object>)(object)nodes).Reverse();
		}
		result = true;
		goto IL_071b;
		IL_004f:
		object obj5 = nodes._size - 1;
		if (nodes._size < 1)
		{
			goto IL_03dc;
		}
		object obj6 = ((List<object>)(object)nodes).get_Item(0);
		if (obj6 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v13 (System.Object)+20]");
			JackarooMarble jackarooMarble = (JackarooMarble)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v13 (System.Object)+20]");
			if ((nint)0 != 0)
			{
				bool flag3 = obj5 == null;
				object obj7 = !flag3;
				if (nodes._size == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v213 @ X0_v13 (System.Object)+10]");
					if ((nint)0 == 3)
					{
						goto IL_021b;
					}
				}
				object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
				nint num = (nint)obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X8_v37 (Il2CppClass<System.Object>)+B8]");
				nint num2 = 0;
				bool flag4 = JackarooAllowedRulesExtensions.HasRuleFlag((JackarooAllowedRules)num2, JackarooAllowedRules.DISABLE_SAME_COLOR_MARBLE_BLOCK);
				bool flag5 = !flag4;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					if (marbleToMove == null)
					{
						goto IL_068e;
					}
					obj8 = jackarooMarble.<PlayerIndex>k__BackingField;
					if (marbleToMove.<PlayerIndex>k__BackingField == jackarooMarble.<PlayerIndex>k__BackingField && jackarooMarble.<Node>k__BackingField != obj)
					{
						goto IL_021b;
					}
				}
				if (IsBaseEntryBlocked(board, rotatedPlayerIndex, marbleToMove, (JackarooNode)obj6, (JackarooNode)obj, jackarooAction))
				{
					goto IL_021b;
				}
				if (board == null)
				{
					goto IL_068e;
				}
				if (board.IsMarbleAtHome(jackarooMarble))
				{
					JackarooActions jackarooActions = jackarooAction;
					JackarooNode jackarooNode = (JackarooNode)obj;
					obj3 = obj7;
					JackarooMarble jackarooMarble2 = jackarooMarble;
					goto IL_0786;
				}
				if (jackarooAction == JackarooActions.MOVE_REVERSE)
				{
					JackarooNode jackarooNode2 = board.PreviousLocalNode((JackarooNode)obj6);
					if (jackarooNode2 == null)
					{
						goto IL_068e;
					}
					bool flag6 = IsBlockedByTwoMarbles(jackarooMarble, jackarooNode2.<Marble>k__BackingField);
					bool flag7 = !flag6;
					object obj10 = !flag7;
					if (obj10 != null)
					{
						goto IL_021b;
					}
				}
				else
				{
					bool flag8 = IsBlockedByTwoMarbles(jackarooMarble, null);
					bool flag9 = !flag8;
					object obj11 = !flag9;
					if (obj11 != null)
					{
						goto IL_021b;
					}
				}
			}
			if (nodes._size == 1)
			{
				goto IL_03dc;
			}
			int num3 = 1;
			while (true)
			{
				object obj12 = ((List<object>)(object)nodes).get_Item(num3);
				if (obj12 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v22 (System.Object)+20]");
				JackarooMarble jackarooMarble2 = (JackarooMarble)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v22 (System.Object)+20]");
				if ((nint)0 != 0)
				{
					object obj13 = obj5 - 1;
					bool flag10 = obj13 == null;
					object obj14 = !flag10;
					if ((nint)obj5 == 1)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v22 (System.Object)+10]");
						if ((nint)0 == 3)
						{
							goto IL_021b;
						}
					}
					object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
					object obj16 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v25+B8]");
					object obj17 = 0;
					bool flag11 = JackarooAllowedRulesExtensions.HasRuleFlag((JackarooAllowedRules)obj17, JackarooAllowedRules.DISABLE_SAME_COLOR_MARBLE_BLOCK);
					bool flag12 = !flag11;
					object obj18 = !flag12;
					if (obj18 == null)
					{
						if (marbleToMove == null)
						{
							break;
						}
						if (marbleToMove.<PlayerIndex>k__BackingField == jackarooMarble2.<PlayerIndex>k__BackingField && jackarooMarble2.<Node>k__BackingField != obj)
						{
							goto IL_021b;
						}
					}
					bool flag13 = IsBaseEntryBlocked(board, rotatedPlayerIndex, marbleToMove, (JackarooNode)obj12, (JackarooNode)obj, jackarooAction);
					bool flag14 = !flag13;
					object obj19 = !flag14;
					if (obj19 == null)
					{
						if (board == null)
						{
							break;
						}
						bool flag15 = board.IsMarbleAtHome(jackarooMarble2);
						bool flag16 = !flag15;
						object obj20 = !flag16;
						JackarooActions jackarooActions = jackarooAction;
						JackarooNode jackarooNode = (JackarooNode)obj;
						obj3 = obj14;
						if (obj20 != null)
						{
							goto IL_0786;
						}
						if (!IsBlockedByTwoMarbles(jackarooMarble2, jackarooMarble))
						{
							goto IL_0427;
						}
					}
					goto IL_021b;
				}
				goto IL_0427;
				IL_0427:
				num3++;
				obj5--;
				bool flag17 = (nint)obj5 == 1;
				jackarooMarble = jackarooMarble2;
				if (!flag17)
				{
					continue;
				}
				goto IL_03dc;
			}
		}
		goto IL_068e;
		IL_068e:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_021b:
		result = false;
		goto IL_071b;
	}

	private static bool AreNodesWalkableForMOVE_EAT_PATH(JackarooBoard board, List<JackarooNode> nodes, Card card, Action<Card, JackarooMarbleMono> onGuardedMarbleAdded)
	{
		//IL_0012: Expected O, but got I
		//IL_0134: Expected O, but got I
		//IL_0048: Expected O, but got I
		//IL_0269: Expected O, but got I4
		//IL_01f8: Expected O, but got I4
		//IL_0082: Expected O, but got I
		//IL_00bc: Expected O, but got I
		//IL_00da: Expected O, but got I4
		object obj = default(object);
		Card card3 = default(Card);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		bool result;
		List<JackarooNode> list = default(List<JackarooNode>);
		Card card2;
		if (list != null)
		{
			obj = (nint)0 + (nint)2816;
			List<object>.Enumerator enumerator = ((List<object>)(object)list).GetEnumerator();
			object obj3 = default(object);
			if (board != null)
			{
				object obj2 = (nint)0 + (nint)2824;
				card2 = card3;
				bool flag;
				while (true)
				{
					list = (List<JackarooNode>)obj2;
					flag = enumerator2.MoveNext();
					if (!flag)
					{
						break;
					}
					if (obj3 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-78+20]");
						JackarooMarble jackarooMarble = (JackarooMarble)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-78+20]");
						if ((nint)0 == 0)
						{
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-78+20]");
						bool flag2 = board.IsMarbleAtHome((JackarooMarble)0);
						bool flag3 = !flag2;
						object obj4 = !flag3;
						if (obj4 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-78+10]");
							bool flag4 = (nint)0 != 3;
							card2 = null;
							if (!flag4)
							{
								break;
							}
							continue;
						}
						goto IL_01a7;
					}
					goto IL_01d8;
				}
				result = (byte)((flag ? 1u : 0u) ^ 1u) != 0;
			}
			else
			{
				object obj5 = (nint)0 + (nint)2824;
				while (true)
				{
					list = (List<JackarooNode>)obj5;
					if (!enumerator2.MoveNext())
					{
						break;
					}
					bool flag5 = obj3 == null;
					card2 = card3;
					if (!flag5)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ stack_-78+20]");
						if ((nint)0 == 0)
						{
							continue;
						}
						goto IL_0183;
					}
					goto IL_01d8;
				}
				result = true;
			}
			goto IL_02f7;
		}
		goto IL_0364;
		IL_01d8:
		NullReferenceException ex = new NullReferenceException();
		goto IL_01e6;
		IL_01e6:
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator3 = enumerator4;
		enumerator4 = (List<object>.Enumerator)0;
		goto IL_0364;
		IL_01a7:
		if (onGuardedMarbleAdded != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [onGuardedMarbleAdded @ X3 (System.Action`2<Card, Jackaroo.JackarooMarbleMono>)+18] (should have been resolved before IL gen)");
		}
		result = false;
		goto IL_02f7;
		IL_0364:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag6 = (nint)list != 1;
		NullReferenceException ex3 = ex2;
		if (!flag6)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			list = (List<JackarooNode>)obj;
			enumerator3.Dispose();
			object obj6 = default(object);
			bool flag7 = obj6 == null;
			object obj7 = !flag7;
			if (obj7 == null)
			{
				result = true;
				goto IL_01d3;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj6;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BC08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		bool result2 = default(bool);
		return result2;
		IL_01d3:
		return result;
		IL_02f7:
		enumerator2.Dispose();
		goto IL_01d3;
		IL_0183:
		NullReferenceException ex5 = new NullReferenceException();
		card2 = card3;
		goto IL_01e6;
	}

	private static bool IsBlockedInBase(JackarooNode node)
	{
		//IL_0052: Expected I4, but got O
		//IL_0030: Expected O, but got I4
		if (node != null)
		{
			object obj = node.<Type>k__BackingField - 3;
			return obj == null;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static bool IsBlockedByHome(JackarooBoard board, JackarooMarble marble)
	{
		//IL_0041: Expected I4, but got O
		if (board != null)
		{
			return board.IsMarbleAtHome(marble);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private static bool IsBlockedBySameColorMarble(JackarooMarble marble, JackarooMarble marbleToMove, JackarooNode lastNode)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00cf: Expected O, but got I
		//IL_00dd: Expected I4, but got O
		//IL_00fb: Expected O, but got I4
		//IL_00b7: Expected I4, but got O
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+B8]");
		object obj3 = 0;
		bool flag = JackarooAllowedRulesExtensions.HasRuleFlag((JackarooAllowedRules)obj3, JackarooAllowedRules.DISABLE_SAME_COLOR_MARBLE_BLOCK);
		bool flag2 = !flag;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			if (marbleToMove == null || marble == null)
			{
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			if (marbleToMove.<PlayerIndex>k__BackingField == marble.<PlayerIndex>k__BackingField && marble.<Node>k__BackingField != lastNode)
			{
				return true;
			}
		}
		return false;
	}

	private static bool IsBaseEntryBlocked(JackarooBoard board, int rotatedPlayerIndex, JackarooMarble marbleToMove, JackarooNode node, JackarooNode lastNode, JackarooActions jackarooAction)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01ea: Expected O, but got I
		//IL_01f8: Expected I4, but got O
		//IL_0033: Expected O, but got I4
		//IL_01d2: Expected I4, but got O
		//IL_00e7: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+B8]");
		object obj3 = 0;
		bool flag = JackarooAllowedRulesExtensions.HasRuleFlag((JackarooAllowedRules)obj3, JackarooAllowedRules.DISABLE_BASE_ENTRY_BLOCKING);
		bool flag2 = jackarooAction == JackarooActions.MOVE_REVERSE;
		bool result = false;
		if (!flag2)
		{
			bool flag3 = !flag;
			object obj4 = !flag3;
			result = false;
			if (obj4 == null)
			{
				if (node != null)
				{
					if (node.<Type>k__BackingField != JackarooNodeType.BaseEntry)
					{
						result = false;
						goto IL_0222;
					}
					if (marbleToMove != null)
					{
						if (marbleToMove.<PlayerIndex>k__BackingField == rotatedPlayerIndex)
						{
							bool flag4 = board == null;
							object obj5 = !flag4;
							if (obj5 != null)
							{
								goto IL_015a;
							}
						}
						else if (board != null)
						{
							int teamMateIndex = board.GetTeamMateIndex(rotatedPlayerIndex);
							if (marbleToMove.<PlayerIndex>k__BackingField == teamMateIndex)
							{
								goto IL_015a;
							}
							return false;
						}
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
		}
		goto IL_0222;
		IL_015a:
		JackarooNode baseEntryNode = board.GetBaseEntryNode(marbleToMove.<PlayerIndex>k__BackingField);
		bool flag5;
		if (baseEntryNode == node)
		{
			object obj6 = (object)node - (object)lastNode;
			flag5 = obj6 == null;
		}
		else
		{
			flag5 = true;
		}
		return !flag5;
		IL_0222:
		return result;
	}

	private static bool IsBlockedByTwoMarbles(JackarooMarble marble, JackarooMarble previousMarble)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00cf: Expected O, but got I
		//IL_00dd: Expected I4, but got O
		//IL_0033: Expected O, but got I4
		//IL_0124: Expected O, but got I
		//IL_0132: Expected I4, but got O
		//IL_00b7: Expected I4, but got O
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+B8]");
		object obj3 = 0;
		bool flag = JackarooAllowedRulesExtensions.HasRuleFlag((JackarooAllowedRules)obj3, JackarooAllowedRules.DISABLE_BLOCKED_BY_TWO_CONSECUTIVE_MARBLES);
		bool flag2 = previousMarble == null;
		bool result = false;
		if (!flag2)
		{
			bool flag3 = !flag;
			object obj4 = !flag3;
			result = false;
			if (obj4 == null)
			{
				object obj5 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v9+B8]");
				object obj6 = 0;
				if (JackarooAllowedRulesExtensions.HasRuleFlag((JackarooAllowedRules)obj6, JackarooAllowedRules.BLOCKED_BY_TWO_CONSECUTIVE_MARBLES_SAME_COLOR))
				{
					if (marble == null)
					{
						NullReferenceException ex = new NullReferenceException();
						return (byte)(int)ex != 0;
					}
					if (previousMarble.<PlayerIndex>k__BackingField != marble.<PlayerIndex>k__BackingField)
					{
						return false;
					}
				}
				result = true;
			}
		}
		return result;
	}
}
