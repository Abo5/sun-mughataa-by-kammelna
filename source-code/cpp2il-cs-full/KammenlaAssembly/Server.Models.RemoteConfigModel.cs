using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Services.Authentication.Shared;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;

namespace Server.Models;

public class RemoteConfigModel
{
	private EconomyConfig <Economy>k__BackingField;

	private TournamentsSection <Tournaments>k__BackingField;

	private PredictionsConfig <Predictions>k__BackingField;

	private VisualsConfig <Visuals>k__BackingField;

	private ChatConfig <Chat>k__BackingField;

	private AutoClickersConfig <AutoClickers>k__BackingField;

	private GiftBombConfig <GiftBomb>k__BackingField;

	private FriendlyChallengeConfig <FriendlyChallenge>k__BackingField;

	private JackarooConfig <Jackaroo>k__BackingField;

	private FastTrackConfig <FastTrack>k__BackingField;

	private ClanConfigsResponse <Clans>k__BackingField;

	private Dictionary<ItemCategory, int> <SubscriberCategoryDiscounts>k__BackingField;

	public EconomyConfig Economy
	{
		get
		{
			return <Economy>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 16;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public TournamentsSection Tournaments
	{
		get
		{
			return <Tournaments>k__BackingField;
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

	public PredictionsConfig Predictions
	{
		get
		{
			return <Predictions>k__BackingField;
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

	public VisualsConfig Visuals
	{
		get
		{
			return <Visuals>k__BackingField;
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

	public ChatConfig Chat
	{
		get
		{
			return <Chat>k__BackingField;
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

	public AutoClickersConfig AutoClickers
	{
		get
		{
			return <AutoClickers>k__BackingField;
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

	public GiftBombConfig GiftBomb
	{
		get
		{
			return <GiftBomb>k__BackingField;
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

	public FriendlyChallengeConfig FriendlyChallenge
	{
		get
		{
			return <FriendlyChallenge>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public JackarooConfig Jackaroo
	{
		get
		{
			return <Jackaroo>k__BackingField;
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

	public FastTrackConfig FastTrack
	{
		get
		{
			return <FastTrack>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 88;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public ClanConfigsResponse Clans
	{
		get
		{
			return <Clans>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 96;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Dictionary<ItemCategory, int> SubscriberCategoryDiscounts
	{
		get
		{
			return <SubscriberCategoryDiscounts>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 104;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public RemoteConfigModel()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00da: Expected O, but got I
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0214: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 2896;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1624;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1608;
		object obj4 = typeof(UsageHint) + 1320;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 840;
		object obj6 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1696;
		object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2832;
		object obj8 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1440;
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 168;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72531F0]");
		_ = 0;
		_ = 1028443341;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [72531F8]");
		_ = 0;
		object obj10 = default(object);
		obj10..ctor();
		object obj11 = this + 16;
		obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentsSection tournamentsSection = default(TournamentsSection);
		tournamentsSection..ctor();
		object obj12 = this + 24;
		obj12 = tournamentsSection;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PredictionsConfig predictionsConfig = default(PredictionsConfig);
		predictionsConfig..ctor();
		object obj13 = this + 32;
		obj13 = predictionsConfig;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)2000;
		object obj16 = default(object);
		object obj15 = obj16 + 24;
		obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj16..ctor();
		object obj17 = this + 40;
		obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj18 = default(object);
		obj18..ctor();
		object obj19 = this + 48;
		obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = default(object);
		obj20..ctor();
		object obj21 = this + 56;
		obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftBombConfig giftBombConfig = default(GiftBombConfig);
		giftBombConfig..ctor();
		object obj22 = this + 64;
		obj22 = giftBombConfig;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FriendlyChallengeConfig friendlyChallengeConfig = default(FriendlyChallengeConfig);
		friendlyChallengeConfig..ctor();
		object obj23 = this + 72;
		obj23 = friendlyChallengeConfig;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253200]");
		_ = 0;
		object obj24 = default(object);
		obj24..ctor();
		object obj25 = this + 80;
		obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj26 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FastTrackConfig fastTrackConfig = default(FastTrackConfig);
		fastTrackConfig..ctor();
		object obj27 = this + 88;
		obj27 = fastTrackConfig;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj28 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1712;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<System.Int32Enum, int> dictionary = default(Dictionary<System.Int32Enum, int>);
		dictionary..ctor();
		object obj29 = this + 104;
		obj29 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
