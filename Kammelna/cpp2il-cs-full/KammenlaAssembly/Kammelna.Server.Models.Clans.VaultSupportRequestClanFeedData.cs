using System;

namespace Kammelna.Server.Models.Clans;

[Serializable]
public class VaultSupportRequestClanFeedData : ClanFeedData
{
	private int <TargetAmount>k__BackingField;

	private DateTime <Deadline>k__BackingField;

	private int <CurrentAmount>k__BackingField;

	private bool <IsEscrow>k__BackingField;

	public int TargetAmount
	{
		get
		{
			return <TargetAmount>k__BackingField;
		}
		set
		{
			<TargetAmount>k__BackingField = value;
		}
	}

	public DateTime Deadline
	{
		get
		{
			return <Deadline>k__BackingField;
		}
		set
		{
			<Deadline>k__BackingField = value;
		}
	}

	public int CurrentAmount
	{
		get
		{
			return <CurrentAmount>k__BackingField;
		}
		set
		{
			<CurrentAmount>k__BackingField = value;
		}
	}

	public bool IsEscrow
	{
		get
		{
			return <IsEscrow>k__BackingField;
		}
		set
		{
			<IsEscrow>k__BackingField = value;
		}
	}
}
