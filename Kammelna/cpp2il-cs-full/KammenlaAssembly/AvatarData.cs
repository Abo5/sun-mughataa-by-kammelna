using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using KammelnaOffline;
using Server.Models;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.TextCore;

public class AvatarData
{
	private string <Dbid>k__BackingField;

	private string <Username>k__BackingField;

	private int <CardbackId>k__BackingField;

	private bool <IsSubscribed>k__BackingField;

	private bool <IsVerified>k__BackingField;

	private PlayerRank <Rank>k__BackingField;

	private string <TitleId>k__BackingField;

	private int <TitleLevel>k__BackingField;

	private int <PatternId>k__BackingField;

	private DateTime? <AvatarDate>k__BackingField;

	private int <ClanId>k__BackingField;

	private string <ClanName>k__BackingField;

	private string <ClanTitle>k__BackingField;

	private bool <IsClanOwner>k__BackingField;

	private FeaturedSlotModel <FeaturedSlot>k__BackingField;

	private MonthlyTournamentEligibilityType <EligibilityType>k__BackingField;

	private int <Likes>k__BackingField;

	private int <AchievementsCount>k__BackingField;

	private int <TournamentPoints>k__BackingField;

	private bool <alsoAnimate>k__BackingField = true;

	private Sprite <AvatarImage>k__BackingField;

	public string Dbid
	{
		get
		{
			return <Dbid>k__BackingField;
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

	public string Username
	{
		get
		{
			return <Username>k__BackingField;
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

	public int CardbackId
	{
		get
		{
			return <CardbackId>k__BackingField;
		}
		set
		{
			<CardbackId>k__BackingField = value;
		}
	}

	public bool IsSubscribed
	{
		get
		{
			return <IsSubscribed>k__BackingField;
		}
		set
		{
			<IsSubscribed>k__BackingField = value;
		}
	}

	public bool IsVerified
	{
		get
		{
			return <IsVerified>k__BackingField;
		}
		set
		{
			<IsVerified>k__BackingField = value;
		}
	}

	public PlayerRank Rank
	{
		get
		{
			return <Rank>k__BackingField;
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

	public string TitleId
	{
		get
		{
			return <TitleId>k__BackingField;
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

	public int TitleLevel
	{
		get
		{
			return <TitleLevel>k__BackingField;
		}
		set
		{
			<TitleLevel>k__BackingField = value;
		}
	}

	public int PatternId
	{
		get
		{
			return <PatternId>k__BackingField;
		}
		set
		{
			<PatternId>k__BackingField = value;
		}
	}

	public DateTime? AvatarDate
	{
		get
		{
			return <AvatarDate>k__BackingField;
		}
		set
		{
			<AvatarDate>k__BackingField = value;
		}
	}

	public int ClanId
	{
		get
		{
			return <ClanId>k__BackingField;
		}
		set
		{
			<ClanId>k__BackingField = value;
		}
	}

	public string ClanName
	{
		get
		{
			return <ClanName>k__BackingField;
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

	public string ClanTitle
	{
		get
		{
			return <ClanTitle>k__BackingField;
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

	public bool IsClanOwner
	{
		get
		{
			return <IsClanOwner>k__BackingField;
		}
		set
		{
			<IsClanOwner>k__BackingField = value;
		}
	}

	public FeaturedSlotModel FeaturedSlot
	{
		get
		{
			return <FeaturedSlot>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 112;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public MonthlyTournamentEligibilityType EligibilityType
	{
		get
		{
			return <EligibilityType>k__BackingField;
		}
		set
		{
			<EligibilityType>k__BackingField = value;
		}
	}

	public int Likes
	{
		get
		{
			return <Likes>k__BackingField;
		}
		set
		{
			<Likes>k__BackingField = value;
		}
	}

	public int AchievementsCount
	{
		get
		{
			return <AchievementsCount>k__BackingField;
		}
		set
		{
			<AchievementsCount>k__BackingField = value;
		}
	}

	public int TournamentPoints
	{
		get
		{
			return <TournamentPoints>k__BackingField;
		}
		set
		{
			<TournamentPoints>k__BackingField = value;
		}
	}

	public bool alsoAnimate
	{
		get
		{
			return <alsoAnimate>k__BackingField;
		}
		set
		{
			<alsoAnimate>k__BackingField = value;
		}
	}

	public Sprite AvatarImage
	{
		get
		{
			return <AvatarImage>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 144;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public AvatarData()
	{
	}

	public static implicit operator AvatarData(CachedUserInfoModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_0121: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj2 = default(object);
		obj2..ctor();
		if (model != null)
		{
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			object obj4 = obj2 + 16;
			obj4 = model.DbId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 24;
			obj5 = model.UserName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj2 + 48;
			obj6 = model.TitleId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = model.TitleLevel;
			_ = model.ActiveCardback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PlayerRank playerRank = default(PlayerRank);
			playerRank..ctor(model.UserPoints, model.IsNew);
			object obj7 = obj2 + 40;
			obj7 = playerRank;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = model.AvatarDate;
			object obj8 = model.SubscriptionStatus - 2;
			bool flag = obj8 == null;
			_ = model.IsVerified;
			return (AvatarData)obj2;
		}
		return (AvatarData)(object)new NullReferenceException();
	}

	public static implicit operator AvatarData(PlayerInfo info)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj2 = default(object);
		obj2..ctor();
		if (info != null)
		{
			int num = default(int);
			string text = num.ToString();
			object obj3 = obj2 + 16;
			obj3 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = info.<Name>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 40;
			obj5 = info.<PlayerRank>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = info.<IsSubscribed>k__BackingField;
			_ = info.<ActiveCardBack>k__BackingField;
			_ = info.<AvatarDate>k__BackingField;
			object obj6 = obj2 + 48;
			obj6 = info.<ActiveGameTitle>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = info.<ActiveTitleLevel>k__BackingField;
			_ = info.<ActiveProfilePattern>k__BackingField;
			object obj7 = obj2 + 112;
			obj7 = info.<NewFeaturedSlot>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (AvatarData)obj2;
		}
		return (AvatarData)(object)new NullReferenceException();
	}

	public static AvatarData FromFeedData(IAvatarFeedData data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_0045: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0080: Expected O, but got I
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0121: Expected I, but got O
		//IL_0131: Expected O, but got I
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_01c0: Expected O, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_0382: Expected I, but got O
		//IL_0392: Expected O, but got I
		//IL_016c: Expected O, but got I
		//IL_025d: Expected O, but got I4
		//IL_0209: Expected O, but got I
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj2 = default(object);
		obj2..ctor();
		if (data == null)
		{
			goto IL_0290;
		}
		object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 1152;
		nint num = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5 (Il2CppClass<Server.Models.IAvatarFeedData>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5 (Il2CppClass<Server.Models.IAvatarFeedData>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v5 (Il2CppClass<Server.Models.IAvatarFeedData>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X10_v18-8]");
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
			goto IL_00c1;
		}
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_02f8;
		IL_0290:
		return (AvatarData)(object)new NullReferenceException();
		IL_0350:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v293 @ X0_v14] (should have been resolved before IL gen)");
		object obj8 = obj2 + 24;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num2 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v11 (Il2CppClass<Server.Models.IAvatarFeedData>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v11 (Il2CppClass<Server.Models.IAvatarFeedData>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_024a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v11 (Il2CppClass<Server.Models.IAvatarFeedData>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X10_v8-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_024a;
		}
		object obj12 = obj11 + 2;
		object obj13 = num2 + obj12;
		object obj14 = obj13 + 312;
		goto IL_03db;
		IL_024a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj15 = 2;
		goto IL_03db;
		IL_01ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj15 = 1;
		goto IL_0350;
		IL_03db:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v361 @ X0_v20] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X0_v20+8]");
		_ = 0;
		return (AvatarData)obj2;
		IL_00c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj15 = 0;
		goto IL_02f8;
		IL_02f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v211 @ X0_v6] (should have been resolved before IL gen)");
		long num3 = default(long);
		string text = num3.ToString();
		if (obj2 == null)
		{
			goto IL_0290;
		}
		object obj16 = obj2 + 16;
		obj16 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num4 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v8 (Il2CppClass<Server.Models.IAvatarFeedData>)+12E]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v8 (Il2CppClass<Server.Models.IAvatarFeedData>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v8 (Il2CppClass<Server.Models.IAvatarFeedData>)+B0]");
		object obj18 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X10_v13-8]");
			if (0 == (nint)obj3)
			{
				break;
			}
			obj18 += 16;
			obj17--;
			if ((nint)obj17 != 1)
			{
				continue;
			}
			goto IL_01ad;
		}
		object obj19 = obj18 + 1;
		object obj20 = num4 + obj19;
		object obj21 = obj20 + 312;
		goto IL_0350;
	}

	public unsafe static implicit operator AvatarData(ClanUserModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I4, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj2 = default(object);
		obj2..ctor();
		if (model != null)
		{
			object obj3 = (nint)0 + (nint)2264;
			int num = model + 20;
			string text = ((int*)num)->ToString();
			object obj4 = obj2 + 16;
			obj4 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 24;
			obj5 = model.Name;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			DateTime? dateTime = model.AvatarDate;
			_ = model.ClanId;
			object obj6 = obj2 + 88;
			obj6 = model.ClanName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj2 + 96;
			obj7 = model.Title;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = model.IsOwner;
			return (AvatarData)obj2;
		}
		return (AvatarData)(object)new NullReferenceException();
	}

	public unsafe static implicit operator AvatarData(ClanMemberViewModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I8, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_009f: Expected O, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj2 = default(object);
		obj2..ctor();
		if (model != null)
		{
			object obj3 = (nint)0 + (nint)2264;
			long num = model + 16;
			string text = ((long*)num)->ToString();
			object obj4 = obj2 + 16;
			obj4 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 24;
			obj5 = model.Name;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [model @ X0 (Kammelna.Server.Models.Clans.ClanMemberViewModel)+28]");
			DateTime? dateTime = (DateTime)0;
			object obj6 = obj2 + 96;
			obj6 = model.RoleTitle;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = model.IsOwner;
			return (AvatarData)obj2;
		}
		return (AvatarData)(object)new NullReferenceException();
	}

	public static implicit operator AvatarData(PlayerProfileModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_018d: Expected O, but got I4
		//IL_019f: Expected O, but got I4
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj2 = default(object);
		obj2..ctor();
		if (model != null)
		{
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			long num = default(long);
			string text = num.ToString();
			object obj4 = obj2 + 16;
			obj4 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 24;
			obj5 = model.<userName>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = model.<avatarDate>k__BackingField;
			_ = model.<activeCardback>k__BackingField;
			_ = model.<isSubscribed>k__BackingField;
			object obj6 = obj2 + 48;
			obj6 = model.<activeTitle>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = model.<activeTitleLevel>k__BackingField;
			_ = model.<activeProfilePattern>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PlayerRank playerRank = default(PlayerRank);
			playerRank..ctor(model.<points>k__BackingField);
			object obj7 = obj2 + 40;
			obj7 = playerRank;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = obj2 + 112;
			obj8 = model.<featuredSlot>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			TournamentRankingModel <tournamentRanking>k__BackingField = model.<tournamentRanking>k__BackingField;
			if (model.<tournamentRanking>k__BackingField != null)
			{
				<tournamentRanking>k__BackingField = (TournamentRankingModel)<tournamentRanking>k__BackingField.<currentRankTier>k__BackingField;
			}
			_ = model.<likes>k__BackingField;
			int num2 = model.AchievementsCount();
			TournamentRankingModel <tournamentRanking>k__BackingField2 = model.<tournamentRanking>k__BackingField;
			if (model.<tournamentRanking>k__BackingField != null)
			{
				<tournamentRanking>k__BackingField2 = (TournamentRankingModel)<tournamentRanking>k__BackingField2.<currentMonthPoints>k__BackingField;
			}
			ClanBadgeModel <activeClan>k__BackingField = model.<activeClan>k__BackingField;
			string text2;
			if (model.<activeClan>k__BackingField != null)
			{
				int clanId = <activeClan>k__BackingField.ClanId;
				text2 = <activeClan>k__BackingField.Name;
			}
			else
			{
				text2 = null;
				int clanId = 0;
			}
			object obj9 = obj2 + 88;
			obj9 = text2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (AvatarData)obj2;
		}
		return (AvatarData)(object)new NullReferenceException();
	}

	public unsafe static implicit operator AvatarData(FriendProfile model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I4, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I4
		//IL_0120: Expected O, but got I4
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj2 = default(object);
		obj2..ctor();
		if (model != null)
		{
			int num = model + 16;
			string text = ((int*)num)->ToString();
			object obj3 = obj2 + 16;
			obj3 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = model.UserName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			DateTime? avatarDate = model.AvatarDate;
			object obj5 = obj2 + 48;
			obj5 = model.Title;
			_ = 0;
			_ = model.Cardback;
			_ = model.IsSubscribed;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = model.Pattern;
			FriendGameData gameData = model.GetGameData((Games?)(object)0);
			if (gameData != null)
			{
				FriendGameData gameData2 = model.GetGameData((Games?)(object)0);
				if (gameData2 != null)
				{
					object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					PlayerRank playerRank = default(PlayerRank);
					playerRank..ctor(gameData.Points, gameData2.IsNew);
					object obj7 = obj2 + 40;
					obj7 = playerRank;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					return (AvatarData)obj2;
				}
			}
		}
		return (AvatarData)(object)new NullReferenceException();
	}

	public unsafe AvatarData(FriendProfile model, bool alsoAnimate)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected I4, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I4
		//IL_00eb: Expected O, but got I4
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		string text = ((int*)(model + 16))->ToString();
		object obj = this + 16;
		obj = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = model.UserName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<AvatarDate>k__BackingField = model.AvatarDate;
		object obj3 = this + 48;
		obj3 = model.Title;
		_ = 0;
		_ = model.Cardback;
		_ = model.IsSubscribed;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = model.Pattern;
		FriendGameData gameData = model.GetGameData((Games?)(object)0);
		FriendGameData gameData2 = model.GetGameData((Games?)(object)0);
		object obj4 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(gameData.Points, gameData2.IsNew);
		object obj5 = this + 40;
		obj5 = playerRank;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public unsafe static implicit operator AvatarData(LeaderBoardPlayer model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected I4, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj2 = default(object);
		obj2..ctor();
		if (model != null)
		{
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			int num = model + 44;
			string text = ((int*)num)->ToString();
			object obj4 = obj2 + 16;
			obj4 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 24;
			obj5 = model.Login;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj2 + 48;
			obj6 = model.TitleId;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PlayerRank playerRank = default(PlayerRank);
			playerRank..ctor(model.Points);
			object obj7 = obj2 + 40;
			obj7 = playerRank;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = model.CardId;
			_ = model.IsSubscribed;
			_ = model.AvatarDate;
			object obj8 = obj2 + 96;
			obj8 = model.ClanRoleTitle;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = model.IsClanOwner;
			return (AvatarData)obj2;
		}
		return (AvatarData)(object)new NullReferenceException();
	}

	public static implicit operator AvatarData(FriendLeaderboardModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj2 = default(object);
		obj2..ctor();
		if (model != null)
		{
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			long num = default(long);
			string text = num.ToString();
			object obj4 = obj2 + 16;
			obj4 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 24;
			obj5 = model.<userName>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = model.<isSubscribed>k__BackingField;
			_ = model.<activeCardback>k__BackingField;
			_ = model.<avatar>k__BackingField;
			_ = model.<tournamentPoints>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PlayerRank playerRank = default(PlayerRank);
			playerRank..ctor(model.<points>k__BackingField, model.<IsNew>k__BackingField);
			object obj6 = obj2 + 40;
			obj6 = playerRank;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (AvatarData)obj2;
		}
		return (AvatarData)(object)new NullReferenceException();
	}

	public static implicit operator AvatarData(ChatMessageData model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj2 = default(object);
		obj2..ctor();
		if (model != null)
		{
			object obj3 = obj2 + 16;
			obj3 = model.<UserId>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = model.<UserName>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = model.<AvatarDate>k__BackingField;
			_ = model.<IsVerified>k__BackingField;
			_ = model.<Cardback>k__BackingField;
			return (AvatarData)obj2;
		}
		return (AvatarData)(object)new NullReferenceException();
	}

	public static implicit operator AvatarData(ProfileGiftsSenderModel model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_00ab: Expected I4, but got I8
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		_ = 1;
		object obj2 = default(object);
		obj2..ctor();
		if (model != null)
		{
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			long num = default(long);
			string text = num.ToString();
			object obj4 = obj2 + 16;
			obj4 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2 + 24;
			obj5 = model.<UserName>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PlayerRank playerRank = default(PlayerRank);
			playerRank..ctor((int)model.<Points>k__BackingField);
			object obj6 = obj2 + 40;
			obj6 = playerRank;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = model.<AvatarTimestamp>k__BackingField;
			return (AvatarData)obj2;
		}
		return (AvatarData)(object)new NullReferenceException();
	}
}
