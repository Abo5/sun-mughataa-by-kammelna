using Cpp2ILInjected;

namespace Server.Models;

public class EconomyConfig
{
	private int <MinCurrencySubscriptionDays>k__BackingField;

	private int <SubscriptionDayPrice>k__BackingField;

	private float <TransferCurrencyFee>k__BackingField;

	private int <CreateRoomPrice>k__BackingField;

	private int <CreateVoiceRoomPrice>k__BackingField;

	public int MinCurrencySubscriptionDays
	{
		get
		{
			return <MinCurrencySubscriptionDays>k__BackingField;
		}
		set
		{
			<MinCurrencySubscriptionDays>k__BackingField = value;
		}
	}

	public int SubscriptionDayPrice
	{
		get
		{
			return <SubscriptionDayPrice>k__BackingField;
		}
		set
		{
			<SubscriptionDayPrice>k__BackingField = value;
		}
	}

	public float TransferCurrencyFee
	{
		get
		{
			return <TransferCurrencyFee>k__BackingField;
		}
		set
		{
			<TransferCurrencyFee>k__BackingField = value;
		}
	}

	public int CreateRoomPrice
	{
		get
		{
			return <CreateRoomPrice>k__BackingField;
		}
		set
		{
			<CreateRoomPrice>k__BackingField = value;
		}
	}

	public int CreateVoiceRoomPrice
	{
		get
		{
			return <CreateVoiceRoomPrice>k__BackingField;
		}
		set
		{
			<CreateVoiceRoomPrice>k__BackingField = value;
		}
	}

	public EconomyConfig()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72531F0]");
		<MinCurrencySubscriptionDays>k__BackingField = 0;
		<TransferCurrencyFee>k__BackingField = 0.05f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72531F8]");
		<CreateRoomPrice>k__BackingField = 0;
		base..ctor();
	}
}
