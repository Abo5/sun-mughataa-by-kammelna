using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities.Data;
using UnityEngine.TextCore;

namespace Jackaroo;

public class JackarooScores : CardGameScores
{
	public override void SaveRoundScore(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_0045: Expected O, but got I
		//IL_00db: Expected O, but got I
		//IL_010b: Expected O, but got I4
		//IL_0080: Expected O, but got I
		//IL_01c4: Expected O, but got I4
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0157: Expected O, but got I
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CardGameRoundScore cardGameRoundScore = default(CardGameRoundScore);
		cardGameRoundScore..ctor();
		object obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1384;
		nint num = (nint)cardGameRoundScore;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<CardGameRoundScore>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<CardGameRoundScore>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X8_v6 (Il2CppClass<CardGameRoundScore>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X10_v7-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00c1;
		}
		object obj5 = obj4 + 3;
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v15+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v227 @ X0_v15] (should have been resolved before IL gen)");
		List<object> list = (List<object>)(object)base.<RoundsScores>k__BackingField;
		goto IL_0170;
		IL_00c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v158 @ X0_v11+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v158 @ X0_v11] (should have been resolved before IL gen)");
		list = (List<object>)(object)base.<RoundsScores>k__BackingField;
		bool flag = base.<RoundsScores>k__BackingField == null;
		object obj9 = !flag;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0170;
		IL_0170:
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag2 = list._size < items.Length;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj11 = items + list._size;
			object obj12 = obj11 + 32;
			obj12 = cardGameRoundScore;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			list.AddWithResize((object)cardGameRoundScore);
		}
	}
}
