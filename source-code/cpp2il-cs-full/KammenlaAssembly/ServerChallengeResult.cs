using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;

[Serializable]
public record ServerChallengeResult
{
	protected virtual Type EqualityContract
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d3: Expected O, but got I4
			//IL_00e3: Expected O, but got I
			//IL_0105: Expected O, but got I4
			//IL_0067: Expected O, but got I4
			//IL_0077: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(IAsyncEnumerable<>) + 3784;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E71A8]");
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
					goto IL_00a4;
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
					goto IL_00a4;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return Type.GetTypeFromHandle(handle2);
			IL_00a4:
			return Type.GetTypeFromHandle(handle);
		}
	}

	public string UserKey
	{
		get
		{
			return <UserKey>k__BackingField;
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

	public string ServerChallenge
	{
		get
		{
			return <ServerChallenge>k__BackingField;
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

	public bool AttestationRequested
	{
		get
		{
			return <AttestationRequested>k__BackingField;
		}
		set
		{
			<AttestationRequested>k__BackingField = value;
		}
	}

	private readonly string <UserKey>k__BackingField;

	private readonly string <ServerChallenge>k__BackingField;

	public ServerChallengeResult(string UserKey, string ServerChallenge, bool AttestationRequested = true)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		object obj = this + 16;
		obj = UserKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = ServerChallenge;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<AttestationRequested>k__BackingField = AttestationRequested;
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
			object value = "SERVICE_DISABLED" + 3456;
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
		//IL_012b: Expected I4, but got O
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_00a5: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_00d7: Expected O, but got I4
		RuntimeHelpers.EnsureSufficientExecutionStack();
		if (builder != null)
		{
			object value = "Unsupported map type" + 840;
			object value2 = "&action=sign-up" + 3728;
			object value3 = "&action=sign-up" + 3448;
			StringBuilder stringBuilder = builder.Append((string)value);
			StringBuilder stringBuilder2 = builder.Append((object)<UserKey>k__BackingField);
			StringBuilder stringBuilder3 = builder.Append((string)value2);
			StringBuilder stringBuilder4 = builder.Append((object)<ServerChallenge>k__BackingField);
			StringBuilder stringBuilder5 = builder.Append((string)value3);
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v7+28]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag2 = default(bool);
			string value4 = flag2.ToString();
			StringBuilder stringBuilder6 = builder.Append(value4);
			return true;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public override int GetHashCode()
	{
		//IL_000c: Expected O, but got I
		//IL_0156: Expected I4, but got O
		//IL_001d: Expected O, but got I
		//IL_009b: Expected O, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0143: Expected I4, but got O
		object obj = (nint)0 + (nint)168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
		Type equalityContract = EqualityContract;
		object obj2 = default(object);
		if (obj2 != null)
		{
			object obj3 = (nint)0 + (nint)152;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ X8_v5+1C8] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
			object obj5 = default(object);
			if (obj5 != null)
			{
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v97 @ X8_v6+1C8] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
				object obj7 = default(object);
				if (obj7 != null)
				{
					object obj8 = (nint)0 + (nint)8;
					object obj9 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ X8_v7+1C8] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C0D02C");
					object obj10 = default(object);
					if (obj10 != null)
					{
						object obj11 = obj10;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v134 @ X8_v8+1C8] (should have been resolved before IL gen)");
						object obj13 = default(object);
						object obj12 = obj13 * 2773833001L;
						object obj15 = default(object);
						object obj14 = obj15 + obj12;
						object obj16 = obj14 * 2773833001L;
						object obj18 = default(object);
						object obj17 = obj18 + obj16;
						object obj19 = obj17 * 2773833001L;
						object obj20 = default(object);
						return (int)(obj20 + obj19);
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public virtual bool Equals(ServerChallengeResult other)
	{
		//IL_0034: Expected I, but got O
		//IL_0050: Expected O, but got I4
		//IL_0060: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_0132: Expected O, but got I
		//IL_0260: Expected I4, but got O
		//IL_01e2: Expected O, but got I
		//IL_0238: Expected O, but got I
		//IL_0248: Expected O, but got I
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
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ X8_v9+1B8] (should have been resolved before IL gen)");
					if (!flag)
					{
						goto IL_00cb;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
					object obj8 = default(object);
					if (obj8 != null)
					{
						object obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v161 @ X8_v10+1B8] (should have been resolved before IL gen)");
						if (!flag)
						{
							goto IL_00cb;
						}
						object obj10 = (nint)0 + (nint)8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C0D02C");
						object obj11 = default(object);
						if (obj11 != null)
						{
							bool flag4 = other.<AttestationRequested>k__BackingField;
							bool flag5 = <AttestationRequested>k__BackingField;
							object obj12 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v13+1B8]");
							object obj13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v13+1C0]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v88 @ X4_v1 (should have been resolved before IL gen)");
						}
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

	protected ServerChallengeResult(ServerChallengeResult original)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		object obj = this + 16;
		obj = original.<UserKey>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = original.<ServerChallenge>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = original.<AttestationRequested>k__BackingField;
	}

	public unsafe void Deconstruct(out string UserKey, out string ServerChallenge, out bool AttestationRequested)
	{
		ref string reference = ref *(string*)<UserKey>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ref string reference2 = ref *(string*)<ServerChallenge>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ref bool reference3 = ref *(<AttestationRequested>k__BackingField ? ((bool*)1) : ((bool*)null));
	}
}
