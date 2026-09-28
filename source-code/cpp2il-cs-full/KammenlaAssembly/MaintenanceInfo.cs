using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;

[Serializable]
public class MaintenanceInfo
{
	private DateTime <ShutdownDateTime>k__BackingField;

	private string <DownTimeMessage>k__BackingField;

	private string <ShutdownMessage>k__BackingField;

	private List<string> <Servers>k__BackingField;

	public DateTime ShutdownDateTime
	{
		get
		{
			return <ShutdownDateTime>k__BackingField;
		}
		set
		{
			<ShutdownDateTime>k__BackingField = value;
		}
	}

	public string DownTimeMessage
	{
		get
		{
			return <DownTimeMessage>k__BackingField;
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

	public string ShutdownMessage
	{
		get
		{
			return <ShutdownMessage>k__BackingField;
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

	public List<string> Servers
	{
		get
		{
			return <Servers>k__BackingField;
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

	private bool isEnabled
	{
		get
		{
			//IL_000c: Expected O, but got I
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I4, but got Unknown
			object obj = (nint)0 + (nint)1992;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3037BC8");
			object obj2 = default(object);
			return (byte)(obj2 ^ 1) != 0;
		}
	}

	public bool IsUnderMaintenance()
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00d8: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0108: Expected O, but got I4
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_0048: Expected O, but got I
		//IL_005e: Expected O, but got I
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0163: Expected O, but got I4
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01ce: Expected O, but got I4
		//IL_0243: Expected I4, but got O
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E720C]");
		object obj2 = (nint)0 & (nint)1;
		object obj3;
		object obj5;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)1992;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E720B]");
			object obj4 = (nint)0 & (nint)1;
			bool flag = obj4 == null;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0083;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)1992;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E720B]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			obj5 = obj3;
			if (obj7 != null)
			{
				goto IL_0083;
			}
		}
		_ = 1;
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3037BC8");
		object obj10 = default(object);
		object obj9 = obj10 & 1;
		bool flag3 = obj9 == null;
		object obj11 = !flag3;
		if (obj11 != null)
		{
			goto IL_00c0;
		}
		goto IL_0171;
		IL_00c0:
		return false;
		IL_0171:
		if (<Servers>k__BackingField != null)
		{
			object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SFSConfig currentSFS = Config.CurrentSFS;
			if (currentSFS != null)
			{
				return ((List<object>)(object)<Servers>k__BackingField).Contains((object)currentSFS.<ID>k__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
		return true;
		IL_0083:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3037BC8");
		object obj16 = default(object);
		object obj15 = obj16 & 1;
		if (obj15 != null)
		{
			goto IL_00c0;
		}
		goto IL_0171;
	}
}
