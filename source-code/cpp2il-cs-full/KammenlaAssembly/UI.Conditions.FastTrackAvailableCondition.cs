using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

namespace UI.Conditions;

[Serializable]
public class FastTrackAvailableCondition : BoolCondition
{
	protected override bool ActualValue
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_01b1: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_0237: Expected O, but got I4
			//IL_01df: Expected O, but got I
			//IL_01f9: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_026f: Expected O, but got I
			//IL_0291: Expected O, but got I4
			//IL_013c: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7DEC]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
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
			goto IL_0207;
			IL_011a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SFSConfig fTServerForCurrentGame = Config.FTServerForCurrentGame;
			bool flag4 = fTServerForCurrentGame == null;
			return !flag4;
			IL_029f:
			return false;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v16+8]");
			if ((nint)0 != 0)
			{
				goto IL_011a;
			}
			goto IL_029f;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C7]");
			object obj10 = (nint)0 & (nint)1;
			if (obj10 != null)
			{
				goto IL_00b0;
			}
			goto IL_0207;
			IL_0207:
			_ = 1;
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+E4]");
			bool flag5 = (nint)0 == 0;
			object obj12 = !flag5;
			object obj13 = obj11;
			if (obj12 != null)
			{
				goto IL_00e5;
			}
			goto IL_024d;
			IL_00b0:
			obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+E4]");
			bool flag6 = (nint)0 == 0;
			obj13 = obj11;
			if (!flag6)
			{
				goto IL_00e5;
			}
			goto IL_024d;
			IL_024d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+B8]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v4+8]");
			bool flag7 = (nint)0 == 0;
			object obj15 = !flag7;
			if (obj15 != null)
			{
				goto IL_011a;
			}
			goto IL_029f;
		}
	}

	public FastTrackAvailableCondition()
	{
		isActive = true;
		((object)this)..ctor();
	}
}
