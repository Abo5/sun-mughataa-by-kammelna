using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

public abstract class CardGameHighlights
{
	public const string highlights = "hls";

	public const string highlightsName = "i";

	public const string playerSeat = "s";

	private Dictionary<string, int> <Highlights>k__BackingField;

	public Dictionary<string, int> Highlights
	{
		get
		{
			return <Highlights>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public CardGameHighlights()
	{
	}

	public virtual void SetHighlights(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0488: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0045: Expected I, but got O
		//IL_0055: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_013f: Expected O, but got I
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		//IL_015a: Expected O, but got I
		//IL_0163: Expected O, but got I4
		//IL_04b4: Expected O, but got I
		//IL_0524: Expected I, but got O
		//IL_0534: Expected O, but got I
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_0281: Expected I, but got O
		//IL_0291: Expected O, but got I
		//IL_01a1: Expected O, but got I
		//IL_035b: Expected O, but got I4
		//IL_0569: Expected O, but got I
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_02cc: Expected O, but got I
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_059d: Expected O, but got I
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03e8: Expected O, but got I
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		ISFSObject iSFSObject = (ISFSObject)(typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2504);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, int> dictionary = default(Dictionary<object, int>);
		dictionary..ctor();
		object obj = this + 16;
		obj = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = typeof(System.IOAsyncCallback) + 976;
		object obj3 = "getSecondRescanTask" + 2992;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00d9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		object obj6 = default(object);
		object obj7 = default(object);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X10_v21-8]");
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X10_v21-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj7 = obj5 + 16;
			obj4--;
			bool flag = (nint)obj4 != 1;
			obj5 = obj7;
			if (flag)
			{
				continue;
			}
			goto IL_00d9;
		}
		object obj8 = obj5 + 28;
		object obj9 = num + obj8;
		object obj10 = obj9 + 312;
		obj7 = obj5;
		goto IL_04d8;
		IL_00d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_04d8;
		IL_04d8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X0_v8+8]");
		int num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v265 @ X0_v8] (should have been resolved before IL gen)");
		ISFSArray iSFSArray = default(ISFSArray);
		if (SFSExtensions.IsNullOrEmpty(iSFSArray))
		{
			return;
		}
		object obj11 = typeof(System.IOAsyncCallback) + 960;
		object defaultValue = (nint)0 + (nint)2000;
		object varName = "rightCtrl" + 768;
		object obj12 = (nint)0 + (nint)3312;
		object obj13 = 0;
		object obj19 = default(object);
		ISFSObject obj23 = default(ISFSObject);
		object obj24 = default(object);
		while (true)
		{
			nint num3 = (nint)iSFSArray;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01ea;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
			object obj15 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X10_v15-8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X10_v15-8]");
				if (0 == (nint)obj11)
				{
					break;
				}
				obj7 = obj15 + 16;
				obj14--;
				bool flag2 = (nint)obj14 != 1;
				obj15 = obj7;
				if (flag2)
				{
					continue;
				}
				goto IL_01ea;
			}
			object obj16 = obj15 + 4;
			object obj17 = num3 + obj16;
			object obj18 = obj17 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v420 @ X0_v32] (should have been resolved before IL gen)");
			bool flag3 = obj13 >= obj19;
			obj7 = obj15;
			if (flag3)
			{
				break;
			}
			goto IL_0279;
			IL_0315:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v21+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v471 @ X0_v21] (should have been resolved before IL gen)");
			Dictionary<object, int> dictionary2 = (Dictionary<object, int>)obj;
			bool flag4 = obj == null;
			object obj20 = !flag4;
			object obj21;
			object obj22;
			if (obj20 == null)
			{
				obj21 = obj6;
				obj22 = obj7;
				goto IL_0168;
			}
			goto IL_03fe;
			IL_0168:
			obj13++;
			obj6 = obj21;
			obj7 = obj22;
			continue;
			IL_03fe:
			object varName2 = "https://www.kammelna.com/Home/Terms" + 136;
			string key = SFSExtensions.Get(obj23, (string)varName2, (string)defaultValue);
			int num4 = SFSExtensions.Get(obj23, (string)varName, 0);
			bool flag5 = dictionary2.TryAdd(key, num4);
			obj21 = obj6;
			num2 = num4;
			obj22 = obj7;
			goto IL_0168;
			IL_01ea:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v393 @ X0_v29] (should have been resolved before IL gen)");
			if (obj13 >= obj24)
			{
				break;
			}
			goto IL_0279;
			IL_0279:
			nint num5 = (nint)iSFSArray;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0315;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Data.ISFSArray>)+B0]");
			obj22 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X10_v11-8]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X10_v11-8]");
				if (0 == (nint)obj11)
				{
					break;
				}
				obj7 = obj22 + 16;
				obj25--;
				bool flag6 = (nint)obj25 != 1;
				obj22 = obj7;
				if (flag6)
				{
					continue;
				}
				goto IL_0315;
			}
			object obj26 = obj22 + 51;
			object obj27 = num5 + obj26;
			object obj28 = obj27 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v24+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v505 @ X0_v24] (should have been resolved before IL gen)");
			dictionary2 = (Dictionary<object, int>)obj;
			bool flag7 = obj == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X10_v11-8]");
			obj21 = 0;
			obj7 = obj22;
			if (flag7)
			{
				goto IL_0168;
			}
			goto IL_03fe;
		}
	}

	public virtual string GetHighlightsName(string key)
	{
		//IL_000f: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_002f: Expected O, but got I
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1 @ X8_v2+90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v3+B8]");
		return (string)0;
	}

	public virtual void Reset()
	{
		((Dictionary<object, int>)(object)<Highlights>k__BackingField).Clear();
	}
}
