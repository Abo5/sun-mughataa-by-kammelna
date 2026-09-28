using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;

public static class FloatExtensions
{
	public static bool IsNearlyEqualTo(float @this, float value, float tolerance = 0.001f)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007f: Expected O, but got I4
		//IL_004a: Invalid comparison between F4 and I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
		float num = @this - tolerance;
		return num < 0f;
	}

	public static float EnsureRange(float @this, float min, float max)
	{
		float num = default(float);
		if (!(@this < num))
		{
			bool flag = @this > max;
			num = max;
			if (!flag)
			{
				num = @this;
			}
		}
		return num;
	}

	public static int EnsureRange(int @this, int min, int max)
	{
		//IL_000d: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected I4, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00c3: Expected O, but got I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected I4, but got Unknown
		//IL_0121: Expected O, but got I4
		object obj = @this - max;
		bool flag = (nint)obj < 0;
		int num = @this ^ max;
		int num2 = @this ^ obj;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		int result = ((obj3 != null) ? max : @this);
		object obj4 = @this - min;
		bool flag4 = (nint)obj4 < 0;
		int num4 = @this ^ min;
		int num5 = @this ^ obj4;
		int num6 = num4 & num5;
		bool flag5 = num6 < 0;
		bool flag6 = flag4 == flag5;
		object obj5 = !flag6;
		object obj6 = ~obj5;
		if (obj6 == null)
		{
			return min;
		}
		return result;
	}

	public static float Map(int @this, float inputMin, float inputMax, float outputMin, float outputMax)
	{
		float num = outputMax - outputMin;
		float num2 = inputMax - inputMin;
		float num3 = num / num2;
		float num4 = inputMin * num3;
		float num5 = outputMin - num4;
		float num6 = num3 * (float)@this;
		return num6 + num5;
	}

	public static float Map(float @this, float inputMin, float inputMax, float outputMin, float outputMax)
	{
		float num = outputMax - outputMin;
		float num2 = inputMax - inputMin;
		float num3 = num / num2;
		float num4 = inputMin * num3;
		float num5 = outputMin - num4;
		float num6 = @this * num3;
		return num6 + num5;
	}
}
