using System;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;
using UnityEngine.Purchasing.Telemetry;

namespace Server.Models;

public class TicketRecord
{
	private TicketType <Type>k__BackingField;

	private int <RemainingCount>k__BackingField;

	private int <MaxCount>k__BackingField;

	private DateTime? <NextTicketTime>k__BackingField;

	public TicketType Type
	{
		get
		{
			return <Type>k__BackingField;
		}
		set
		{
			<Type>k__BackingField = value;
		}
	}

	public int RemainingCount
	{
		get
		{
			return <RemainingCount>k__BackingField;
		}
		set
		{
			<RemainingCount>k__BackingField = value;
		}
	}

	public int MaxCount
	{
		get
		{
			return <MaxCount>k__BackingField;
		}
		set
		{
			<MaxCount>k__BackingField = value;
		}
	}

	public DateTime? NextTicketTime
	{
		get
		{
			return <NextTicketTime>k__BackingField;
		}
		set
		{
			<NextTicketTime>k__BackingField = value;
		}
	}

	public static TicketRecord FromSfsObject(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 976;
		object obj2 = "startPosition" + 2136;
		object obj3 = (nint)0 + (nint)184;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		if (obj4 != null)
		{
			object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1976;
			object varName2 = "java.io.FileOutputStream" + 3672;
			object varName3 = "m_StencilDeferredPS" + 2848;
			int num = SFSExtensions.Get(data, (string)varName, 0);
			int num2 = SFSExtensions.Get(data, (string)varName2, 0);
			DateTime? dateTime = SFSExtensions.Get(data, (string)varName3, (DateTime?)(object)0);
			return (TicketRecord)obj4;
		}
		return (TicketRecord)(object)new NullReferenceException();
	}
}
