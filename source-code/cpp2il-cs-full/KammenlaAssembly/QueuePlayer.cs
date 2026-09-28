using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using ListView;
using Sfs2X.Entities.Data;

public class QueuePlayer : IListViewItemData<int>
{
	public enum Status
	{
		None,
		Highlight,
		PendingRequest,
		PendingResponse,
		Accepted,
		Rejected
	}

	public static readonly QueuePlayer Dummy;

	private readonly PlayerInfo <info>k__BackingField;

	private readonly int <order>k__BackingField;

	private readonly int <team>k__BackingField;

	private Status <status>k__BackingField;

	private int <index>k__BackingField;

	public PlayerInfo info => <info>k__BackingField;

	public int order => <order>k__BackingField;

	public int team => <team>k__BackingField;

	public Status status
	{
		get
		{
			return <status>k__BackingField;
		}
		set
		{
			<status>k__BackingField = value;
		}
	}

	public int index
	{
		get
		{
			return <index>k__BackingField;
		}
		set
		{
			<index>k__BackingField = value;
		}
	}

	public string template => "Unsupported map type" + 3528;

	private QueuePlayer(PlayerInfo playerInfo, int order, int team)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = playerInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public static QueuePlayer FromSfsObject(ISFSObject data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0076: Expected I, but got O
		//IL_0086: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_0155: Expected I4, but got I8
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		object varName;
		object varName2;
		if (data != null)
		{
			object obj = typeof(System.IOAsyncCallback) + 976;
			object obj2 = "not" + 3944;
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 936;
			varName = "not" + 632;
			varName2 = "startPosition" + 2136;
			object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 2760;
			nint num = (nint)data;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0102;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
			object obj6 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj6 += 16;
				obj5--;
				if ((nint)obj5 != 1)
				{
					continue;
				}
				goto IL_0102;
			}
			object obj7 = obj6 + 29;
			object obj8 = num + obj7;
			object obj9 = obj8 + 312;
			goto IL_01f4;
		}
		return (QueuePlayer)(object)new NullReferenceException();
		IL_01f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v197 @ X0_v3] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo = default(PlayerInfo);
		ISFSObject data2 = default(ISFSObject);
		playerInfo..ctor(data2);
		int num2 = SFSExtensions.Get(data, (string)varName, 2147483647);
		int num3 = SFSExtensions.Get(data, (string)varName2, -1);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = default(object);
		obj10..ctor();
		object obj11 = obj10 + 16;
		obj11 = playerInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (QueuePlayer)obj10;
		IL_0102:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_01f4;
	}

	static QueuePlayer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0064: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 2760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = -1;
		object obj4 = obj;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
