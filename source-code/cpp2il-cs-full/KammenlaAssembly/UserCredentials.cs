using System;
using System.Formats.Asn1;
using Cpp2ILInjected;

[Serializable]
public class UserCredentials
{
	private string <Email>k__BackingField;

	private string <Password>k__BackingField;

	private string <SocialToken>k__BackingField;

	private string <DeviceId>k__BackingField;

	private AppIntegrityRequestModel <IntegrityModel>k__BackingField;

	public string Email
	{
		get
		{
			return <Email>k__BackingField;
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

	public string Password
	{
		get
		{
			return <Password>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string SocialToken
	{
		get
		{
			return <SocialToken>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string DeviceId
	{
		get
		{
			return <DeviceId>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public AppIntegrityRequestModel IntegrityModel
	{
		get
		{
			return <IntegrityModel>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 48;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool IsValid()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010c: Expected O, but got I4
		//IL_00b6: Expected O, but got I4
		//IL_00cd: Expected O, but got I4
		//IL_015a: Expected O, but got I4
		//IL_0163: Expected O, but got I4
		//IL_016c: Expected O, but got I4
		//IL_0223: Expected O, but got I4
		//IL_022c: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_01d5: Expected O, but got I4
		//IL_031b: Expected O, but got I4
		//IL_01ec: Expected O, but got I4
		//IL_02da: Expected O, but got I4
		//IL_02e3: Expected O, but got I4
		//IL_028e: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E71B6]");
		object obj3 = (nint)0 & (nint)1;
		string value;
		string value2;
		if (obj3 != null)
		{
			value = <Email>k__BackingField;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v24+E4]");
			bool flag = (nint)0 == 0;
			value2 = <Email>k__BackingField;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			value = <Email>k__BackingField;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			value2 = <Email>k__BackingField;
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
		object obj8 = 0;
		if (obj6 == null)
		{
			goto IL_017a;
		}
		goto IL_023a;
		IL_02f1:
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v2+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag6 = StringsExtensions.IsNullOrEmpty(<DeviceId>k__BackingField);
		return (byte)((flag6 ? 1u : 0u) ^ 1u) != 0;
		IL_023a:
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v9+E4]");
		if ((nint)0 != 0)
		{
			bool flag7 = StringsExtensions.IsNullOrEmpty(<SocialToken>k__BackingField);
			bool flag8 = !flag7;
			object obj12 = 0;
			if (!flag8)
			{
				goto IL_029c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = StringsExtensions.IsNullOrEmpty(<SocialToken>k__BackingField);
			bool flag10 = !flag9;
			object obj13 = !flag10;
			object obj12 = 0;
			if (obj13 != null)
			{
				goto IL_029c;
			}
		}
		goto IL_02f1;
		IL_029c:
		return false;
		IL_0091:
		bool flag11 = StringsExtensions.IsNullOrEmpty(value);
		bool flag12 = !flag11;
		obj7 = 0;
		if (flag12)
		{
			goto IL_017a;
		}
		obj8 = 0;
		goto IL_023a;
		IL_017a:
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v18+E4]");
		if ((nint)0 != 0)
		{
			bool flag13 = StringsExtensions.IsNullOrEmpty(<Password>k__BackingField);
			bool flag14 = !flag13;
			object obj15 = !flag14;
			obj8 = 0;
			if (obj15 != null)
			{
				goto IL_023a;
			}
			object obj12 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag15 = StringsExtensions.IsNullOrEmpty(<Password>k__BackingField);
			bool flag16 = !flag15;
			obj8 = 0;
			object obj12 = 0;
			if (!flag16)
			{
				goto IL_023a;
			}
		}
		goto IL_02f1;
	}
}
