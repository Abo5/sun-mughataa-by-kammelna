using System;
using System.Buffers.Text;
using System.Formats.Asn1;
using Cpp2ILInjected;

[Serializable]
public class PrivateMessageModel
{
	public string message;

	public int sender;

	public long timestamp;

	public bool isRead;

	public string channelId;

	public PrivateMessageModel()
	{
	}

	public PrivateMessageModel(string message, int sender, long timestamp)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = message;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected bool Equals(PrivateMessageModel other)
	{
		//IL_009f: Expected I4, but got O
		if (other != null)
		{
			if (sender == other.sender && timestamp == other.timestamp)
			{
				return string.Equals(message, other.message, StringComparison.InvariantCulture);
			}
			return false;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public override bool Equals(object obj)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0042: Expected I, but got O
		//IL_006b: Expected O, but got I4
		//IL_009f: Expected O, but got I
		//IL_0134: Expected O, but got I
		if (obj != null)
		{
			if (this == obj)
			{
				return true;
			}
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1808;
			object obj3 = obj2;
			nint num = (nint)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X9_v2 (Il2CppClass<System.Object>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v6+130]");
			bool flag = num2 < 0;
			object obj4 = !flag;
			object obj5 = ~obj4;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X9_v2 (Il2CppClass<System.Object>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v6+130]");
				object obj6 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X9_v4-8]");
				if (0 == (nint)obj3)
				{
					int num4 = sender;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+18]");
					if ((nint)num4 == 0)
					{
						long num5 = timestamp;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+20]");
						if (num5 == 0)
						{
							string a = message;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
							return string.Equals(a, (string)0, StringComparison.InvariantCulture);
						}
					}
				}
			}
		}
		return false;
	}

	public unsafe override int GetHashCode()
	{
		//IL_0111: Expected O, but got I4
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected I8, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Expected I4, but got Unknown
		//IL_0258: Expected O, but got I4
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected I4, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0136: Expected O, but got I
		//IL_0150: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01c6: Expected O, but got I
		//IL_01e8: Expected O, but got I4
		//IL_018e: Expected O, but got I4
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_00be: Expected O, but got I
		//IL_0204: Expected I4, but got O
		object obj;
		object obj6;
		object obj8;
		if (message != null)
		{
			obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2376;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4596]");
				object obj3 = (nint)0 & (nint)1;
				if (obj3 != null)
				{
					goto IL_0079;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4596]");
				object obj4 = (nint)0 & (nint)1;
				bool flag = obj4 == null;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_0079;
				}
			}
			_ = 1;
			obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v21+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj8 = obj6;
			if (obj7 != null)
			{
				goto IL_00ae;
			}
			goto IL_01a4;
		}
		object obj9 = 0;
		goto IL_0223;
		IL_00ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v21+B8]");
		object obj10 = 0;
		object obj11 = obj10;
		if (obj10 != null)
		{
			goto IL_00e3;
		}
		goto IL_01f6;
		IL_01a4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj12 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X0_v11+B8]");
		object obj13 = 0;
		obj11 = obj13;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		if (obj14 != null)
		{
			goto IL_00e3;
		}
		goto IL_01f6;
		IL_0223:
		long num = this + 32;
		int hashCode = ((long*)num)->GetHashCode();
		int num2 = sender ^ obj9;
		object obj15 = num2 * 397;
		return obj15 ^ hashCode;
		IL_00e3:
		object obj16 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v143 @ X8_v16+1F8] (should have been resolved before IL gen)");
		object obj17 = default(object);
		obj9 = obj17 * 397;
		goto IL_0223;
		IL_01f6:
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0079:
		obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v21+E4]");
		bool flag4 = (nint)0 == 0;
		obj8 = obj6;
		if (!flag4)
		{
			goto IL_00ae;
		}
		goto IL_01a4;
	}
}
