using System;
using System.Buffers.Text;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Sfs2X.Entities;
using UnityEngine.Purchasing.Telemetry;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class TrollingReportModel
{
	private int <RoomID>k__BackingField;

	private Games? <Game>k__BackingField;

	private DateTime? <ReportTime>k__BackingField;

	private string <ServerID>k__BackingField;

	private string <ChatRecord>k__BackingField;

	private long? <ReportedPlayerId>k__BackingField;

	private string <ReportedPlayerUserName>k__BackingField;

	public int RoomID
	{
		get
		{
			return <RoomID>k__BackingField;
		}
		set
		{
			<RoomID>k__BackingField = value;
		}
	}

	public Games? Game
	{
		get
		{
			return <Game>k__BackingField;
		}
		set
		{
			<Game>k__BackingField = value;
		}
	}

	public DateTime? ReportTime
	{
		get
		{
			return <ReportTime>k__BackingField;
		}
		set
		{
			<ReportTime>k__BackingField = value;
		}
	}

	public string ServerID
	{
		get
		{
			return <ServerID>k__BackingField;
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

	public string ChatRecord
	{
		get
		{
			return <ChatRecord>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 56;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public long? ReportedPlayerId
	{
		get
		{
			return <ReportedPlayerId>k__BackingField;
		}
		set
		{
			<ReportedPlayerId>k__BackingField = value;
		}
	}

	public string ReportedPlayerUserName
	{
		get
		{
			return <ReportedPlayerUserName>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public static TrollingReportModel MakeDefaultInstance()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0052: Expected I, but got O
		//IL_0062: Expected O, but got I
		//IL_00f8: Expected O, but got I
		//IL_009d: Expected O, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_013f: Expected O, but got I
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0182: Expected O, but got I4
		//IL_01ab: Expected O, but got I
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Expected O, but got Unknown
		//IL_02eb: Expected O, but got I
		//IL_030f: Expected O, but got I4
		//IL_0209: Expected O, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_0270: Expected O, but got I4
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		Room lastJoinedRoom = SFS.LastJoinedRoom;
		object obj8;
		if (lastJoinedRoom != null)
		{
			object obj3 = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)lastJoinedRoom;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00de;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X10_v6-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00de;
			}
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v16+8]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v135 @ X8_v16] (should have been resolved before IL gen)");
			bool flag = obj2 == null;
			object obj9 = !flag;
			if (obj9 != null)
			{
				goto IL_011f;
			}
		}
		goto IL_031d;
		IL_031d:
		return (TrollingReportModel)(object)new NullReferenceException();
		IL_011f:
		object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj11 = (nint)0 + (nint)2744;
		object obj12 = typeof(DataRelation) + 712;
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj15 = (nint)0 + (nint)2264;
		object obj16 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		Games currentGame = Preferences.CurrentGame;
		System.Int32Enum? int32Enum = (System.Int32Enum)currentGame;
		object obj17 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj18 = !flag3;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		DateTime? dateTime = now;
		object obj19 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj20 = !flag4;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string serverID = Config.ServerID;
		object obj21 = obj2 + 48;
		obj21 = serverID;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (TrollingReportModel)obj2;
		IL_00de:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v30+8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v155 @ X0_v30] (should have been resolved before IL gen)");
		if (obj2 != null)
		{
			goto IL_011f;
		}
		goto IL_031d;
	}
}
