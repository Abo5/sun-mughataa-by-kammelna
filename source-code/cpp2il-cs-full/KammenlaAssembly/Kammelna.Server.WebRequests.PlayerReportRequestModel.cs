using System;
using Cpp2ILInjected;
using ReportEnums;

namespace Kammelna.Server.WebRequests;

[Serializable]
public class PlayerReportRequestModel
{
	private PlayerReportType <PlayerReportType>k__BackingField;

	private long <ReportedPlayerId>k__BackingField;

	private Games <Game>k__BackingField;

	private string <ReportedPlayerUserName>k__BackingField;

	private string <ReportedMessage>k__BackingField;

	private string <UsersInfo>k__BackingField;

	private string <Description>k__BackingField;

	private DateTime? <ProblemTime>k__BackingField;

	public PlayerReportType PlayerReportType
	{
		get
		{
			return <PlayerReportType>k__BackingField;
		}
		set
		{
			<PlayerReportType>k__BackingField = value;
		}
	}

	public long ReportedPlayerId
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

	public Games Game
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
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string ReportedMessage
	{
		get
		{
			return <ReportedMessage>k__BackingField;
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

	public string UsersInfo
	{
		get
		{
			return <UsersInfo>k__BackingField;
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

	public string Description
	{
		get
		{
			return <Description>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 64;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public DateTime? ProblemTime
	{
		get
		{
			return <ProblemTime>k__BackingField;
		}
		set
		{
			<ProblemTime>k__BackingField = value;
		}
	}
}
