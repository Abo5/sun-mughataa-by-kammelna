using System;
using System.Data;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;

[Serializable]
public record ChallengeEntry(DateTime Date, FriendlyChallengeResult Result, bool IsLock)
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
			object obj2 = 147423232 + 1872;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E71E7]");
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
			object value = "Cannot populate JSON object onto type '{0}'." + 2064;
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

	protected unsafe virtual bool PrintMembers(StringBuilder builder)
	{
		//IL_01a4: Expected I4, but got O
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0083: Expected O, but got I4
		//IL_00de: Expected O, but got Ref
		//IL_011e: Expected O, but got I4
		//IL_012e: Expected O, but got I
		//IL_0150: Expected O, but got I4
		RuntimeHelpers.EnsureSufficientExecutionStack();
		if (builder != null)
		{
			object value = "DNQUALIFIER" + 1304;
			object obj = typeof(DataRelation) + 712;
			object value2 = "&action=sign-up" + 3664;
			object value3 = "&action=sign-up" + 3536;
			StringBuilder stringBuilder = builder.Append((string)value);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime dateTime = default(DateTime);
			string value4 = dateTime.ToString();
			StringBuilder stringBuilder2 = builder.Append(value4);
			StringBuilder stringBuilder3 = builder.Append((string)value2);
			object obj4 = default(object);
			string value5 = ((Enum)(&obj4)).ToString();
			StringBuilder stringBuilder4 = builder.Append(value5);
			StringBuilder stringBuilder5 = builder.Append((string)value3);
			object obj5 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v10+28]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v20+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag3 = default(bool);
			string value6 = flag3.ToString();
			StringBuilder stringBuilder6 = builder.Append(value6);
			return true;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public override int GetHashCode()
	{
		//IL_000c: Expected O, but got I
		//IL_0162: Expected I4, but got O
		//IL_001d: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_00a7: Expected O, but got I
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_014f: Expected I4, but got O
		object obj = (nint)0 + (nint)168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
		Type equalityContract = EqualityContract;
		object obj2 = default(object);
		if (obj2 != null)
		{
			object obj3 = (nint)0 + (nint)40;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v67 @ X8_v5+1C8] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C0E3DC");
			object obj5 = default(object);
			if (obj5 != null)
			{
				object obj6 = (nint)0 + (nint)64;
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v99 @ X8_v6+1C8] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C10434");
				object obj8 = default(object);
				if (obj8 != null)
				{
					object obj9 = (nint)0 + (nint)8;
					object obj10 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ X8_v7+1C8] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C0D02C");
					object obj11 = default(object);
					if (obj11 != null)
					{
						object obj12 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v139 @ X8_v8+1C8] (should have been resolved before IL gen)");
						object obj14 = default(object);
						object obj13 = obj14 * 2773833001L;
						object obj16 = default(object);
						object obj15 = obj16 + obj13;
						object obj17 = obj15 * 2773833001L;
						object obj19 = default(object);
						object obj18 = obj19 + obj17;
						object obj20 = obj18 * 2773833001L;
						object obj21 = default(object);
						return (int)(obj21 + obj20);
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public virtual bool Equals(ChallengeEntry other)
	{
		//IL_0034: Expected I, but got O
		//IL_0050: Expected O, but got I4
		//IL_0060: Expected O, but got I
		//IL_0110: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_0132: Expected O, but got I
		//IL_026c: Expected I4, but got O
		//IL_0190: Expected O, but got I
		//IL_01ee: Expected O, but got I
		//IL_0244: Expected O, but got I
		//IL_0254: Expected O, but got I
		bool flag;
		if ((object)this != other)
		{
			if ((object)other != null)
			{
				Type equalityContract = EqualityContract;
				nint num = (nint)other;
				Type equalityContract2 = other.EqualityContract;
				object obj = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6+E0]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v8+E4]");
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
				object obj5 = (nint)0 + (nint)40;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C0E3DC");
				object obj6 = default(object);
				if (obj6 != null)
				{
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v162 @ X8_v11+1B8] (should have been resolved before IL gen)");
					if (!flag)
					{
						goto IL_00cb;
					}
					object obj8 = (nint)0 + (nint)64;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C10434");
					object obj9 = default(object);
					if (obj9 != null)
					{
						object obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v163 @ X8_v14+1B8] (should have been resolved before IL gen)");
						if (!flag)
						{
							goto IL_00cb;
						}
						object obj11 = (nint)0 + (nint)8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C0D02C");
						object obj12 = default(object);
						if (obj12 != null)
						{
							bool flag4 = other.IsLock;
							bool flag5 = IsLock;
							object obj13 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v17+1B8]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v17+1C0]");
							object obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v91 @ X4_v1 (should have been resolved before IL gen)");
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

	public unsafe void Deconstruct(out DateTime Date, out FriendlyChallengeResult Result, out bool IsLock)
	{
		ref DateTime reference = ref *(DateTime*)Date;
		ref FriendlyChallengeResult reference2 = ref *(FriendlyChallengeResult*)(int)Result;
		ref bool reference3 = ref *(IsLock ? ((bool*)1) : ((bool*)null));
	}
}
