using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace UI.Conditions;

[Serializable]
public class PremiumThemeCondition : BoolCondition
{
	protected override bool ActualValue
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0178: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_01fe: Expected O, but got I4
			//IL_01a6: Expected O, but got I
			//IL_01c0: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_0105: Expected O, but got I
			//IL_0127: Expected O, but got I4
			//IL_028d: Expected O, but got I4
			//IL_0236: Expected O, but got I
			//IL_0246: Expected O, but got I
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Expected I4, but got Unknown
			//IL_02e8: Expected I4, but got O
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7E18]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v16+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v16+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_01ce;
			IL_0135:
			object obj8;
			return (byte)(obj8 & 1) != 0;
			IL_026b:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v1+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SFSConfig currentSFS = Config.CurrentSFS;
			if (currentSFS != null)
			{
				return currentSFS.<IsRestricted>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v1+B8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v17+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v17+8]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				goto IL_0135;
			}
			goto IL_026b;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
			object obj12 = (nint)0 & (nint)1;
			if (obj12 != null)
			{
				goto IL_00b0;
			}
			goto IL_01ce;
			IL_01ce:
			_ = 1;
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v1+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			object obj15 = obj13;
			if (obj14 != null)
			{
				goto IL_00e5;
			}
			goto IL_0214;
			IL_00b0:
			obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v1+E4]");
			bool flag6 = (nint)0 == 0;
			obj15 = obj13;
			if (!flag6)
			{
				goto IL_00e5;
			}
			goto IL_0214;
			IL_0214:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v1+B8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v6+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v6+8]");
			if ((nint)0 == 0)
			{
				goto IL_0135;
			}
			goto IL_026b;
		}
	}

	public PremiumThemeCondition()
	{
		isActive = true;
		((object)this)..ctor();
	}
}
