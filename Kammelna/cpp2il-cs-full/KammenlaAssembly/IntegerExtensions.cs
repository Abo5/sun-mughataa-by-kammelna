using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;

public static class IntegerExtensions
{
	public static string ToCommaSeparatedNumber(int value)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object obj = "Material with texture name \"" + 3224;
		int num = default(int);
		return num.ToString((string)obj);
	}

	public static int CeilingTo(int i, int step)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		//IL_006c: Expected I4, but got I8
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int num = i / step;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
		int num2 = (int)((step != 2139095040) ? num : 2147483648L);
		return num2 * step;
	}

	public static int FloorTo(int i, int step)
	{
		int num = i / step;
		return num * step;
	}

	public static bool IsEven(int i)
	{
		int num = i & 1;
		return num == 0;
	}

	public static bool IsOdd(int i)
	{
		return (byte)(i & 1) != 0;
	}

	public static int GetRotatedNextIndex(int index, int step, int min, int max)
	{
		//IL_000d: Expected O, but got I4
		//IL_001f: Expected I4, but got I8
		//IL_0039: Expected O, but got I4
		//IL_00a8: Expected O, but got I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected I4, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected I4, but got Unknown
		object obj = max - min;
		int num = (int)(step & 0x80000000L);
		bool flag = num == 0;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = index - min;
			object obj4 = obj3 + step;
			object obj5 = obj4 / obj;
			object obj6 = obj5 * obj;
			object obj7 = obj4 - obj6;
			return obj7 + min;
		}
		object obj8 = -step;
		object obj9 = obj8 / obj;
		object obj10 = obj9 * obj;
		object obj11 = step + obj10;
		object obj12 = obj + obj11;
		object obj13 = index - min;
		object obj14 = obj13 + obj12;
		object obj15 = obj14 / obj;
		object obj16 = obj15 * obj;
		object obj17 = obj14 - obj16;
		return obj17 + min;
	}
}
