using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq.JsonPath;

public static class JackarooCustomRulesExtensions
{
	public static string Serialize(JackarooCustomRulesSave jackarooCustomRulesSave, JsonSerializerSettings serializerSettings)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0068: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 520;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return JsonConvert.SerializeObject(jackarooCustomRulesSave, serializerSettings);
	}

	public static int ToInt(JackarooCustomRulesSave jackarooCustomRulesSave)
	{
		//IL_003c: Expected O, but got I
		//IL_0048: Expected O, but got I
		//IL_0100: Expected I, but got O
		//IL_0184: Expected I, but got O
		//IL_009f: Expected I4, but got O
		//IL_006d: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		bool flag = jackarooCustomRulesSave == null;
		JackarooCustomRulesSave jackarooCustomRulesSave2 = jackarooCustomRulesSave;
		object obj2 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			bool flag2 = jackarooCustomRulesSave.<IndicesAndRules>k__BackingField == null;
			jackarooCustomRulesSave2 = jackarooCustomRulesSave;
			if (!flag2)
			{
				object obj = (nint)0 + (nint)2680;
				obj2 = (nint)0 + (nint)2672;
				List<object>.Enumerator enumerator = ((List<object>)(object)jackarooCustomRulesSave.<IndicesAndRules>k__BackingField).GetEnumerator();
				jackarooCustomRulesSave2 = null;
				num = (nint)obj;
				if (!enumerator2.MoveNext())
				{
					enumerator2.Dispose();
					goto IL_009a;
				}
				object obj3 = 0;
				NullReferenceException ex = new NullReferenceException();
				object obj4 = 0;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag3 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj2;
			enumerator2.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				goto IL_009a;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj4 = obj5;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223A240");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		int result = default(int);
		return result;
		IL_009a:
		return (int)jackarooCustomRulesSave2;
	}
}
