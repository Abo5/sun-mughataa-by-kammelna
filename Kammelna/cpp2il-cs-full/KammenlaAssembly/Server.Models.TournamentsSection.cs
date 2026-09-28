using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.Purchasing.Telemetry;

namespace Server.Models;

public class TournamentsSection
{
	private int <SubscribersDiscount>k__BackingField;

	private int <NonSubscribersDiscount>k__BackingField;

	private DateTime <OfficialEndTime>k__BackingField;

	private string <MassTutorialUrl>k__BackingField;

	private TournamentConfig <Public>k__BackingField;

	private TournamentConfig <Private>k__BackingField;

	private TournamentAddonConfig _addons;

	public int SubscribersDiscount
	{
		get
		{
			return <SubscribersDiscount>k__BackingField;
		}
		set
		{
			<SubscribersDiscount>k__BackingField = value;
		}
	}

	public int NonSubscribersDiscount
	{
		get
		{
			return <NonSubscribersDiscount>k__BackingField;
		}
		set
		{
			<NonSubscribersDiscount>k__BackingField = value;
		}
	}

	public DateTime OfficialEndTime
	{
		get
		{
			return <OfficialEndTime>k__BackingField;
		}
		set
		{
			<OfficialEndTime>k__BackingField = value;
		}
	}

	public string MassTutorialUrl
	{
		get
		{
			return <MassTutorialUrl>k__BackingField;
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

	public TournamentConfig Public
	{
		get
		{
			return <Public>k__BackingField;
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

	public TournamentConfig Private
	{
		get
		{
			return <Private>k__BackingField;
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

	public Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig> Addons
	{
		get
		{
			TournamentAddonConfig addons = _addons;
			if (_addons != null)
			{
				return addons.<AddonConfigs>k__BackingField;
			}
			return (Dictionary<TournamentAddonType, TournamentAddonConfig.AddonConfig>)(object)new NullReferenceException();
		}
	}

	public TournamentsSection()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1472;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1456;
		<SubscribersDiscount>k__BackingField = 140;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentConfig tournamentConfig = default(TournamentConfig);
		tournamentConfig..ctor();
		object obj3 = this + 40;
		obj3 = tournamentConfig;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentConfig tournamentConfig2 = default(TournamentConfig);
		tournamentConfig2..ctor();
		object obj4 = this + 48;
		obj4 = tournamentConfig2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentAddonConfig tournamentAddonConfig = default(TournamentAddonConfig);
		tournamentAddonConfig..ctor();
		object obj5 = this + 56;
		obj5 = tournamentAddonConfig;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
