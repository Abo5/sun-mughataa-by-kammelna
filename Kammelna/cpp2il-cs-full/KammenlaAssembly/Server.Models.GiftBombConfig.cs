using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Unity.Properties;

namespace Server.Models;

public class GiftBombConfig
{
	private bool <CurrencyBombEnabled>k__BackingField;

	private bool <SubscriptionBombEnabled>k__BackingField;

	private int <MinShardPrice>k__BackingField;

	private int <MaxShardPrice>k__BackingField;

	private int[] <SubShardDays>k__BackingField;

	private int <MinShardCount>k__BackingField;

	private int <MaxShardCount>k__BackingField;

	private int <MinSubShardCount>k__BackingField;

	private int <MaxSubShardCount>k__BackingField;

	private int <SubBombOneDayAceToSub>k__BackingField;

	private int <MinBombActiveSeconds>k__BackingField;

	public bool CurrencyBombEnabled
	{
		get
		{
			return <CurrencyBombEnabled>k__BackingField;
		}
		set
		{
			<CurrencyBombEnabled>k__BackingField = value;
		}
	}

	public bool SubscriptionBombEnabled
	{
		get
		{
			return <SubscriptionBombEnabled>k__BackingField;
		}
		set
		{
			<SubscriptionBombEnabled>k__BackingField = value;
		}
	}

	public int MinShardPrice
	{
		get
		{
			return <MinShardPrice>k__BackingField;
		}
		set
		{
			<MinShardPrice>k__BackingField = value;
		}
	}

	public int MaxShardPrice
	{
		get
		{
			return <MaxShardPrice>k__BackingField;
		}
		set
		{
			<MaxShardPrice>k__BackingField = value;
		}
	}

	public int[] SubShardDays
	{
		get
		{
			return <SubShardDays>k__BackingField;
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

	public int MinShardCount
	{
		get
		{
			return <MinShardCount>k__BackingField;
		}
		set
		{
			<MinShardCount>k__BackingField = value;
		}
	}

	public int MaxShardCount
	{
		get
		{
			return <MaxShardCount>k__BackingField;
		}
		set
		{
			<MaxShardCount>k__BackingField = value;
		}
	}

	public int MinSubShardCount
	{
		get
		{
			return <MinSubShardCount>k__BackingField;
		}
		set
		{
			<MinSubShardCount>k__BackingField = value;
		}
	}

	public int MaxSubShardCount
	{
		get
		{
			return <MaxSubShardCount>k__BackingField;
		}
		set
		{
			<MaxSubShardCount>k__BackingField = value;
		}
	}

	public int SubBombOneDayAceToSub
	{
		get
		{
			return <SubBombOneDayAceToSub>k__BackingField;
		}
		set
		{
			<SubBombOneDayAceToSub>k__BackingField = value;
		}
	}

	public int MinBombActiveSeconds
	{
		get
		{
			return <MinBombActiveSeconds>k__BackingField;
		}
		set
		{
			<MinBombActiveSeconds>k__BackingField = value;
		}
	}

	public GiftBombConfig()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3048;
		object fldHandle = (nint)0 + (nint)1736;
		<CurrencyBombEnabled>k__BackingField = true;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72531E0]");
		<MinShardPrice>k__BackingField = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Array array = default(Array);
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)fldHandle);
		object obj2 = this + 32;
		obj2 = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253220]");
		<MinShardCount>k__BackingField = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72531E8]");
		<SubBombOneDayAceToSub>k__BackingField = 0;
		base..ctor();
	}
}
