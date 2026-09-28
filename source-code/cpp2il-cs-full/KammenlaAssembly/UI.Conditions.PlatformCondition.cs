using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;

namespace UI.Conditions;

[Serializable]
public class PlatformCondition : EqualityCondition<Platform>
{
	protected override Platform ActualValue
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00b2: Expected O, but got I4
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E16]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return KUtil.GetPlatform();
			IL_0074:
			return KUtil.GetPlatform();
		}
	}

	public PlatformCondition()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4A14E18");
	}
}
