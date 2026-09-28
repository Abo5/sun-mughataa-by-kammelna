using System;
using System.Data;
using System.Formats.Asn1;
using Cpp2ILInjected;

[Serializable]
public class TokenModel
{
	private readonly string <Token>k__BackingField;

	private readonly DateTime <ExpiresAt>k__BackingField;

	public string Token => <Token>k__BackingField;

	public DateTime ExpiresAt => <ExpiresAt>k__BackingField;

	public bool IsExpired
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0084: Expected O, but got I4
			object obj = typeof(DataRelation) + 712;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime2 = default(DateTime);
			DateTime dateTime = dateTime2.ToUniversalTime();
			DateTime utcNow = DateTime.UtcNow;
			return dateTime < utcNow;
		}
	}

	public bool IsValid
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b6: Expected O, but got I4
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Expected O, but got Unknown
			//IL_01fb: Expected O, but got I4
			//IL_0152: Expected O, but got I4
			//IL_015b: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E722E]");
			object obj3 = (nint)0 & (nint)1;
			string value;
			string value2;
			if (obj3 != null)
			{
				value = <Token>k__BackingField;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v16+E4]");
				bool flag = (nint)0 == 0;
				value2 = <Token>k__BackingField;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				value = <Token>k__BackingField;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v16+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				value2 = <Token>k__BackingField;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = StringsExtensions.IsNullOrEmpty(value2);
			bool flag4 = !flag3;
			object obj6 = !flag4;
			object obj7 = 0;
			if (obj6 != null)
			{
				goto IL_00c4;
			}
			goto IL_0169;
			IL_00c4:
			return false;
			IL_0169:
			object obj8 = typeof(DataRelation) + 712;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v3+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime2 = default(DateTime);
			DateTime dateTime = dateTime2.ToUniversalTime();
			DateTime utcNow = DateTime.UtcNow;
			bool flag6 = dateTime < utcNow;
			return (byte)((flag6 ? 1u : 0u) ^ 1u) != 0;
			IL_0091:
			bool flag7 = StringsExtensions.IsNullOrEmpty(value);
			bool flag8 = !flag7;
			obj7 = 0;
			if (!flag8)
			{
				goto IL_00c4;
			}
			goto IL_0169;
		}
	}

	public TokenModel(string token, DateTime expiresAt)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = token;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public string ToStringFormat()
	{
		//IL_007a: Expected O, but got I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I4
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj2 = typeof(DataRelation) + 712;
		object format = "WhiteSmoke" + 3632;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime2 = default(DateTime);
		DateTime dateTime = dateTime2.ToUniversalTime();
		DateTime utcNow = DateTime.UtcNow;
		bool flag2 = dateTime < utcNow;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		return string.Format((string)format, arg, arg2);
	}
}
