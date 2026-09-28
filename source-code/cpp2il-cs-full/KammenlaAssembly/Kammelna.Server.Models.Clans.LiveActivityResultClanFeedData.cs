using System;
using System.Collections.Generic;
using Cpp2ILInjected;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class LiveActivityResultClanFeedData : ClanFeedData
{
	private ClanLiveActivityType <ActivityType>k__BackingField;

	private string <Title>k__BackingField;

	private List<long> <WinnerUserIds>k__BackingField;

	private List<long> <LoserUserIds>k__BackingField;

	private List<string> <WinnerUserNames>k__BackingField;

	private List<string> <LoserUserNames>k__BackingField;

	public ClanLiveActivityType ActivityType
	{
		get
		{
			return <ActivityType>k__BackingField;
		}
		set
		{
			<ActivityType>k__BackingField = value;
		}
	}

	public string Title
	{
		get
		{
			return <Title>k__BackingField;
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

	public List<long> WinnerUserIds
	{
		get
		{
			return <WinnerUserIds>k__BackingField;
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

	public List<long> LoserUserIds
	{
		get
		{
			return <LoserUserIds>k__BackingField;
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

	public List<string> WinnerUserNames
	{
		get
		{
			return <WinnerUserNames>k__BackingField;
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

	public List<string> LoserUserNames
	{
		get
		{
			return <LoserUserNames>k__BackingField;
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
}
