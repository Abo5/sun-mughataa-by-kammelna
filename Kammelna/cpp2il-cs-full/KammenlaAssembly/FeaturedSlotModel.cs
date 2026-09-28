using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;

[Serializable]
public record FeaturedSlotModel
{
	protected virtual Type EqualityContract
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Expected O, but got I4
			//IL_002e: Expected O, but got I
			//IL_00ce: Expected O, but got I4
			//IL_00de: Expected O, but got I
			//IL_0100: Expected O, but got I4
			//IL_0062: Expected O, but got I4
			//IL_0072: Expected O, but got I
			object obj = 152989696;
			object obj2 = 147423232 + 3272;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E723A]");
			object obj3 = (nint)0 & (nint)1;
			RuntimeTypeHandle handle;
			RuntimeTypeHandle handle2;
			if (obj3 != null)
			{
				handle = (RuntimeTypeHandle)obj2;
				object obj4 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v9+E0]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				handle2 = (RuntimeTypeHandle)obj2;
				if (!flag)
				{
					goto IL_009f;
				}
			}
			else
			{
				_ = 1;
				handle = (RuntimeTypeHandle)obj2;
				object obj6 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+E0]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				handle2 = (RuntimeTypeHandle)obj2;
				if (obj7 != null)
				{
					goto IL_009f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return Type.GetTypeFromHandle(handle2);
			IL_009f:
			return Type.GetTypeFromHandle(handle);
		}
	}

	public string id
	{
		get
		{
			return <id>k__BackingField;
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

	public int levelId
	{
		get
		{
			return <levelId>k__BackingField;
		}
		set
		{
			<levelId>k__BackingField = value;
		}
	}

	private readonly string <id>k__BackingField;

	public FeaturedSlotModel(string id, int levelId)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 16;
		obj = id;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<levelId>k__BackingField = levelId;
		base..ctor();
	}

	public FeaturedSlotModel()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		object obj = this + 16;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<levelId>k__BackingField = 0;
		base..ctor();
	}

	public override string ToString()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_00b6: Expected I, but got O
		//IL_00c6: Expected O, but got I
		//IL_00d6: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		StringBuilder stringBuilder = default(StringBuilder);
		stringBuilder..ctor();
		if (stringBuilder != null)
		{
			object value = "Error reading data from socket: " + 3688;
			object value2 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2336;
			StringBuilder stringBuilder2 = stringBuilder.Append((string)value);
			StringBuilder stringBuilder3 = stringBuilder.Append((string)value2);
			if (PrintMembers(stringBuilder))
			{
				StringBuilder stringBuilder4 = stringBuilder.Append(' ');
			}
			StringBuilder stringBuilder5 = stringBuilder.Append('}');
			nint num = (nint)stringBuilder;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6 (Il2CppClass<System.Text.StringBuilder>)+168]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6 (Il2CppClass<System.Text.StringBuilder>)+170]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v82 @ X2_v6 (should have been resolved before IL gen)");
		}
		return (string)(object)new NullReferenceException();
	}

	protected virtual bool PrintMembers(StringBuilder builder)
	{
		//IL_0095: Expected I4, but got O
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		RuntimeHelpers.EnsureSufficientExecutionStack();
		if (builder != null)
		{
			object value = "https://www.kammelna.com/Home/Terms" + 336;
			object value2 = "&action=sign-up" + 3928;
			StringBuilder stringBuilder = builder.Append((string)value);
			StringBuilder stringBuilder2 = builder.Append((object)<id>k__BackingField);
			StringBuilder stringBuilder3 = builder.Append((string)value2);
			int num = default(int);
			string value3 = num.ToString();
			StringBuilder stringBuilder4 = builder.Append(value3);
			return true;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public override int GetHashCode()
	{
		//IL_000c: Expected O, but got I
		//IL_00fe: Expected I4, but got O
		//IL_001d: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00eb: Expected I4, but got O
		object obj = (nint)0 + (nint)168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
		Type equalityContract = EqualityContract;
		object obj2 = default(object);
		if (obj2 != null)
		{
			object obj3 = (nint)0 + (nint)152;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v62 @ X8_v5+1C8] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
			object obj5 = default(object);
			if (obj5 != null)
			{
				object obj6 = (nint)0 + (nint)96;
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v86 @ X8_v6+1C8] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C102CC");
				object obj8 = default(object);
				if (obj8 != null)
				{
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v116 @ X8_v7+1C8] (should have been resolved before IL gen)");
					object obj11 = default(object);
					object obj10 = obj11 * 2773833001L;
					object obj13 = default(object);
					object obj12 = obj13 + obj10;
					object obj14 = obj12 * 2773833001L;
					object obj15 = default(object);
					return (int)(obj15 + obj14);
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public virtual bool Equals(FeaturedSlotModel other)
	{
		//IL_0034: Expected I, but got O
		//IL_0050: Expected O, but got I4
		//IL_0060: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_0132: Expected O, but got I
		//IL_020e: Expected I4, but got O
		//IL_0190: Expected O, but got I
		//IL_01e6: Expected O, but got I
		//IL_01f6: Expected O, but got I
		bool flag;
		if ((object)this != other)
		{
			if ((object)other != null)
			{
				Type equalityContract = EqualityContract;
				nint num = (nint)other;
				Type equalityContract2 = other.EqualityContract;
				object obj = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+E0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v8+E4]");
				if ((nint)0 != 0)
				{
					flag = equalityContract == equalityContract2;
					bool flag2 = !flag;
					object obj3 = !flag2;
					object obj4 = 0;
					Type type = equalityContract2;
					if (obj3 == null)
					{
						goto IL_00cb;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					flag = equalityContract == equalityContract2;
					bool flag3 = !flag;
					object obj4 = 0;
					Type type = equalityContract2;
					if (flag3)
					{
						goto IL_00cb;
					}
				}
				object obj5 = (nint)0 + (nint)152;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
				object obj6 = default(object);
				if (obj6 != null)
				{
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v153 @ X8_v11+1B8] (should have been resolved before IL gen)");
					if (!flag)
					{
						goto IL_00cb;
					}
					object obj8 = (nint)0 + (nint)96;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C102CC");
					object obj9 = default(object);
					if (obj9 != null)
					{
						int num2 = other.<levelId>k__BackingField;
						int num3 = <levelId>k__BackingField;
						object obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v14+1B8]");
						object obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v14+1C0]");
						object obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v88 @ X4_v1 (should have been resolved before IL gen)");
					}
				}
				NullReferenceException ex = new NullReferenceException();
				return (byte)(int)ex != 0;
			}
			return false;
		}
		return true;
		IL_00cb:
		return flag;
	}

	protected FeaturedSlotModel(FeaturedSlotModel original)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		object obj = this + 16;
		obj = original.<id>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = original.<levelId>k__BackingField;
	}

	public unsafe void Deconstruct(out string id, out int levelId)
	{
		ref string reference = ref *(string*)<id>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ref int reference2 = ref *(int*)<levelId>k__BackingField;
	}
}
