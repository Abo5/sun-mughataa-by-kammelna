using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;

public static class TournamentMath
{
	public static int GetFirstParentId(int matchId, int size)
	{
		int num = matchId << 1;
		return num - size;
	}

	public static int GetSecondParentId(int matchId, int size)
	{
		int num = ~size;
		return num + matchId;
	}

	public static int GetNextMatchId(int matchId, int size)
	{
		//IL_0012: Expected O, but got I8
		//IL_0033: Expected O, but got I8
		//IL_004e: Expected I4, but got O
		//IL_0059: Expected O, but got I4
		//IL_007d: Expected I4, but got I8
		object obj = matchId - 2147483648L;
		bool flag = obj == null;
		object obj2 = size + 2147483649L;
		object obj3 = obj2 + obj2;
		int result = obj3 >> 1;
		object obj4 = !flag;
		object obj5 = ~obj4;
		if (obj5 == null)
		{
			return -1;
		}
		return result;
	}

	public static int GetNumberOfRounds(int size)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I4
		//IL_003a: Expected F8, but got I4
		//IL_0102: Expected O, but got I4
		//IL_006a: Invalid comparison between F8 and I4
		//IL_009b: Expected I4, but got F8
		//IL_008e: Expected I4, but got I8
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num = Math.Log(size, 2.0);
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		if (2.0 == 2139095040.0)
		{
			return -2147483648;
		}
		return (int)num;
	}

	public static int GetMatchRound(int matchId, int size)
	{
		//IL_000d: Expected O, but got I4
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected I4, but got Unknown
		//IL_00e4: Expected O, but got I4
		//IL_0047: Expected F8, but got I4
		//IL_011c: Expected O, but got I4
		//IL_0077: Invalid comparison between F8 and I4
		//IL_00a8: Expected I4, but got F8
		//IL_009b: Expected I4, but got I8
		object obj = size - matchId;
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj3 = obj2;
		int num = size / obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		double num2 = Math.Log(num, 2.0);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		if (2.0 == 2139095040.0)
		{
			return -2147483648;
		}
		return (int)num2;
	}
}
