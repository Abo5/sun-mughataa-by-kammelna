using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using UnityEngine.InputSystem.XR;

[Serializable]
public class PlayerInfo
{
	private int <DBID>k__BackingField;

	private string <Name>k__BackingField;

	private PlayerRank <PlayerRank>k__BackingField;

	private bool <IsModerator>k__BackingField;

	private bool <IsSubscribed>k__BackingField;

	private bool <IsVerified>k__BackingField;

	private int <ActiveCardBack>k__BackingField;

	private DateTime? <AvatarDate>k__BackingField;

	private string <ActiveGameTitle>k__BackingField;

	private int <ActiveTitleLevel>k__BackingField;

	private bool <IsLiked>k__BackingField;

	private int <ActiveProfilePattern>k__BackingField;

	private FeaturedSlotModel <NewFeaturedSlot>k__BackingField;

	public int DBID
	{
		get
		{
			return <DBID>k__BackingField;
		}
		set
		{
			<DBID>k__BackingField = value;
		}
	}

	public string Name
	{
		get
		{
			return <Name>k__BackingField;
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

	public PlayerRank PlayerRank
	{
		get
		{
			return <PlayerRank>k__BackingField;
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

	public bool IsModerator
	{
		get
		{
			return <IsModerator>k__BackingField;
		}
		set
		{
			<IsModerator>k__BackingField = value;
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

	public int ActiveCardBack
	{
		get
		{
			return <ActiveCardBack>k__BackingField;
		}
		set
		{
			<ActiveCardBack>k__BackingField = value;
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

	public string ActiveGameTitle
	{
		get
		{
			return <ActiveGameTitle>k__BackingField;
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

	public int ActiveTitleLevel
	{
		get
		{
			return <ActiveTitleLevel>k__BackingField;
		}
		set
		{
			<ActiveTitleLevel>k__BackingField = value;
		}
	}

	public bool IsLiked
	{
		get
		{
			return <IsLiked>k__BackingField;
		}
		set
		{
			<IsLiked>k__BackingField = value;
		}
	}

	public int ActiveProfilePattern
	{
		get
		{
			return <ActiveProfilePattern>k__BackingField;
		}
		set
		{
			<ActiveProfilePattern>k__BackingField = value;
		}
	}

	public FeaturedSlotModel NewFeaturedSlot
	{
		get
		{
			return <NewFeaturedSlot>k__BackingField;
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

	public bool IsMe
	{
		get
		{
			//IL_002a: Expected O, but got I4
			User mySelf = SFS.MySelf;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(mySelf);
			object obj = <DBID>k__BackingField - intDbId;
			return obj == null;
		}
	}

	public bool IsHuman
	{
		get
		{
			int num = ~<DBID>k__BackingField;
			return (byte)(num >> 31) != 0;
		}
	}

	public PlayerInfo()
	{
	}

	public PlayerInfo(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_04d4: Expected I4, but got I8
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0060: Expected I4, but got I8
		//IL_007a: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		//IL_056c: Expected O, but got I
		//IL_057c: Expected O, but got I
		//IL_0585: Expected O, but got I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01b7: Expected O, but got I4
		//IL_0100: Expected O, but got I4
		//IL_0108: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02cd: Expected I, but got O
		//IL_02dd: Expected O, but got I
		//IL_0318: Expected O, but got I
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_0468: Expected O, but got I4
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		object varName = "https://www.kammelna.com/Home/Terms" + 136;
		object varName2 = "m_StencilDeferredPS" + 2848;
		object obj = (nint)0 + (nint)2000;
		object varName3 = "https://www.kammelna.com/Home/Terms" + 616;
		object varName4 = "https://www.kammelna.com/Home/Terms" + 2392;
		object varName5 = "https://www.kammelna.com/Home/Terms" + 4016;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		base..ctor();
		int num = SFSExtensions.Get(data, (string)varName, -1);
		<DBID>k__BackingField = num;
		string text = (string)obj;
		string text2 = SFSExtensions.Get(data, (string)varName2, (string)obj);
		object obj3 = this + 24;
		obj3 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PlayerRank playerRank2;
		object defaultValue;
		if ((object)((int)(<DBID>k__BackingField & 0x80000000L) != 0) == null)
		{
			object varName6 = "placementId" + 1552;
			object varName7 = "https://www.kammelna.com/Home/Terms" + 3000;
			int points = SFSExtensions.Get(data, (string)varName6, 0);
			bool flag = SFSExtensions.Get(data, (string)varName7, defaultValue: false);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PlayerRank playerRank = default(PlayerRank);
			playerRank..ctor(points, flag);
			object obj4 = 0;
			text = (string)flag;
			playerRank2 = playerRank;
			defaultValue = obj;
		}
		else
		{
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v52+E4]");
			if ((object)((nint)0 != 0) == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X0_v52+B8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v29+18]");
			playerRank2 = (PlayerRank)0;
			object obj4 = 0;
			defaultValue = obj;
		}
		object obj7 = this + 32;
		obj7 = playerRank2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag2 = SFSExtensions.Get(data, (string)varName3, defaultValue: false);
		<IsModerator>k__BackingField = flag2;
		bool flag3 = SFSExtensions.Get(data, (string)varName4, defaultValue: false);
		<IsSubscribed>k__BackingField = flag3;
		<IsVerified>k__BackingField = SFSExtensions.Get(data, (string)varName5, defaultValue: false);
		<AvatarDate>k__BackingField = SFSExtensions.Get(data, "___# Content push apply failed [{0}]: {1}" + 3224, (DateTime?)(object)0);
		<ActiveCardBack>k__BackingField = SFSExtensions.Get(data, "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1976, 0);
		string text3 = SFSExtensions.Get(data, "___# Content push apply failed [{0}]: {1}" + 3976, (string)defaultValue);
		object obj8 = this + 64;
		obj8 = text3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num2 = SFSExtensions.Get(data, "alignContent" + 3040, 1);
		int num3 = SFSExtensions.Get(data, "placementId" + 1536, 0);
		object obj9 = typeof(System.IOAsyncCallback) + 976;
		object varName8 = "fetch_products" + 1544;
		nint num4 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0359;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj11 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X10_v6-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			obj11 += 16;
			obj10--;
			if ((nint)obj10 != 1)
			{
				continue;
			}
			goto IL_0359;
		}
		object obj12 = (object)(num4 + (object)(obj11 + 1)) + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v414 @ X0_v47] (should have been resolved before IL gen)");
		object obj13 = default(object);
		if ((object)(obj13 != null) == null)
		{
			return;
		}
		goto IL_038a;
		IL_0359:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v292 @ X0_v44] (should have been resolved before IL gen)");
		object obj14 = default(object);
		if (obj14 != null)
		{
			goto IL_038a;
		}
		return;
		IL_038a:
		string id = SFSExtensions.Get(data, (string)varName8, (string)defaultValue);
		int levelId = SFSExtensions.Get(data, "fetch_products" + 1560, 0);
		object obj15 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FeaturedSlotModel featuredSlotModel = default(FeaturedSlotModel);
		featuredSlotModel..ctor(id, levelId);
		object obj16 = this + 88;
		obj16 = featuredSlotModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public PlayerInfo(User user)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0089: Expected I, but got O
		//IL_0099: Expected O, but got I
		//IL_00d4: Expected O, but got I
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		string dbId = SFSKammelnaUserExtensions.GetDbId(user);
		int num = int.Parse(dbId);
		<DBID>k__BackingField = num;
		string userName = SFSKammelnaUserExtensions.GetUserName(user);
		object obj = this + 24;
		obj = userName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(user);
		object obj2 = this + 32;
		obj2 = rank;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = typeof(UsageHint) + 8;
		nint num2 = (nint)user;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0115;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v5 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X10_v5-8]");
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
			goto IL_0115;
		}
		object obj6 = (object)(num2 + (object)(obj5 + 14)) + 312;
		goto IL_0254;
		IL_0115:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0254;
		IL_0254:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v185 @ X0_v17] (should have been resolved before IL gen)");
		bool flag = default(bool);
		<IsModerator>k__BackingField = flag;
		bool flag2 = SFSKammelnaUserExtensions.IsSubscribed(user);
		<IsSubscribed>k__BackingField = flag2;
		bool flag3 = SFSKammelnaUserExtensions.IsVerified(user);
		<IsVerified>k__BackingField = flag3;
		int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(user);
		<ActiveCardBack>k__BackingField = activeCardbackID;
		<ActiveProfilePattern>k__BackingField = SFSKammelnaUserExtensions.GetActivePatternID(user);
		<AvatarDate>k__BackingField = SFSKammelnaUserExtensions.GetAvatarDate(user);
		_ = 0;
		string title = SFSKammelnaUserExtensions.GetTitle(user);
		object obj7 = this + 64;
		obj7 = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<ActiveTitleLevel>k__BackingField = SFSKammelnaUserExtensions.GetTitleLevel(user);
		FeaturedSlotModel featuredSlot = SFSKammelnaUserExtensions.GetFeaturedSlot(user);
		object obj8 = this + 88;
		obj8 = featuredSlot;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public PlayerInfo(FriendProfile friendProfile)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_003f: Expected O, but got I4
		//IL_0056: Expected O, but got I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		object obj = this + 24;
		obj = friendProfile.UserName;
		_ = friendProfile.UserID;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		FriendGameData gameData = friendProfile.GetGameData((Games?)(object)0);
		FriendGameData gameData2 = friendProfile.GetGameData((Games?)(object)0);
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(gameData.Points, gameData2.IsNew);
		object obj3 = this + 32;
		obj3 = playerRank;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<IsSubscribed>k__BackingField = friendProfile.IsSubscribed;
		<ActiveCardBack>k__BackingField = friendProfile.Cardback;
		<AvatarDate>k__BackingField = friendProfile.AvatarDate;
		object obj4 = this + 64;
		obj4 = friendProfile.Title;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public PlayerInfo(ChatMessageData messageData, User user = null)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0121: Expected I, but got O
		//IL_0131: Expected O, but got I
		//IL_01c0: Expected O, but got I4
		//IL_016c: Expected O, but got I
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_01f7: Expected O, but got I4
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		<ActiveCardBack>k__BackingField = messageData.<Cardback>k__BackingField;
		int result;
		bool flag = int.TryParse(messageData.<UserId>k__BackingField, out result);
		object obj = this + 24;
		obj = messageData.<UserName>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = messageData.<IsVerified>k__BackingField;
		_ = messageData.<AvatarDate>k__BackingField;
		if (user == null)
		{
			return;
		}
		object obj2 = typeof(UsageHint) + 8;
		<DBID>k__BackingField = int.Parse(SFSKammelnaUserExtensions.GetDbId(user));
		<Name>k__BackingField = SFSKammelnaUserExtensions.GetUserName(user);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(user);
		object obj3 = this + 32;
		obj3 = rank;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		nint num = (nint)user;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v7 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v7 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01ad;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v7 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X10_v6-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj5 += 16;
			obj4--;
			if ((nint)obj4 != 1)
			{
				continue;
			}
			goto IL_01ad;
		}
		object obj6 = (object)(num + (object)(obj5 + 14)) + 312;
		object obj7 = 0;
		goto IL_02b5;
		IL_02b5:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v223 @ X0_v21] (should have been resolved before IL gen)");
		bool flag2 = default(bool);
		<IsModerator>k__BackingField = flag2;
		bool flag3 = SFSKammelnaUserExtensions.IsSubscribed(user);
		<IsSubscribed>k__BackingField = flag3;
		bool flag4 = SFSKammelnaUserExtensions.IsVerified(user);
		<IsVerified>k__BackingField = flag4;
		int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(user);
		<ActiveCardBack>k__BackingField = activeCardbackID;
		<ActiveProfilePattern>k__BackingField = SFSKammelnaUserExtensions.GetActivePatternID(user);
		<AvatarDate>k__BackingField = SFSKammelnaUserExtensions.GetAvatarDate(user);
		_ = 0;
		string title = SFSKammelnaUserExtensions.GetTitle(user);
		object obj8 = this + 64;
		obj8 = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int titleLevel = SFSKammelnaUserExtensions.GetTitleLevel(user);
		return;
		IL_01ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj7 = 14;
		goto IL_02b5;
	}

	public PlayerInfo(int dbId, string name)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public PlayerInfo(int dbId, string name, PlayerRank rank)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		<DBID>k__BackingField = dbId;
		object obj = this + 24;
		obj = name;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 32;
		obj2 = rank;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public static PlayerInfo FromSfsObject(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo = default(PlayerInfo);
		playerInfo..ctor(data);
		return playerInfo;
	}

	public ISFSObject ToSfsObject()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0053: Expected I, but got O
		//IL_0063: Expected O, but got I
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bd: Expected O, but got Unknown
		//IL_09cf: Expected I, but got O
		//IL_09df: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_0132: Expected O, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0255: Expected O, but got Unknown
		//IL_0265: Expected I, but got O
		//IL_0275: Expected O, but got I
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Expected O, but got Unknown
		//IL_01dc: Expected I, but got O
		//IL_01ec: Expected O, but got I
		//IL_020e: Expected O, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_02d2: Expected O, but got I
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0418: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_042d: Expected I, but got O
		//IL_043d: Expected O, but got I
		//IL_038f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_03a4: Expected I, but got O
		//IL_03b4: Expected O, but got I
		//IL_03d6: Expected O, but got I4
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Expected O, but got Unknown
		//IL_0af7: Expected I, but got O
		//IL_0b07: Expected O, but got I
		//IL_049a: Expected O, but got I
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e5: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_0b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5f: Expected O, but got Unknown
		//IL_0b71: Expected I, but got O
		//IL_0b81: Expected O, but got I
		//IL_0556: Expected O, but got I
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Expected O, but got Unknown
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_0bd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd9: Expected O, but got Unknown
		//IL_0be3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be8: Expected O, but got Unknown
		//IL_0bfa: Expected I, but got O
		//IL_0c0a: Expected O, but got I
		//IL_05ea: Expected O, but got I
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Expected O, but got Unknown
		//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected O, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected O, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_0577: Expected O, but got Unknown
		//IL_0c5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c62: Expected O, but got Unknown
		//IL_0c85: Expected O, but got I
		//IL_0c8d: Expected I, but got O
		//IL_0c9d: Expected O, but got I
		//IL_067e: Expected O, but got I
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected O, but got Unknown
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected O, but got Unknown
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_05f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected O, but got Unknown
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_060b: Expected O, but got Unknown
		//IL_0cf0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf5: Expected O, but got Unknown
		//IL_0d07: Expected I, but got O
		//IL_0d17: Expected O, but got I
		//IL_0712: Expected O, but got I
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dc: Expected O, but got Unknown
		//IL_06e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected O, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f7: Expected O, but got Unknown
		//IL_068c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0691: Expected O, but got Unknown
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Expected O, but got Unknown
		//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d6f: Expected O, but got Unknown
		//IL_0d81: Expected I, but got O
		//IL_0d91: Expected O, but got I
		//IL_07a6: Expected O, but got I
		//IL_076b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0778: Unknown result type (might be due to invalid IL or missing references)
		//IL_077d: Expected O, but got Unknown
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_078b: Expected O, but got Unknown
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected O, but got Unknown
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Expected O, but got Unknown
		//IL_0dec: Expected I, but got O
		//IL_0dfc: Expected O, but got I
		//IL_083a: Expected O, but got I
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0804: Expected O, but got Unknown
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected O, but got Unknown
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected O, but got Unknown
		//IL_07b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b9: Expected O, but got Unknown
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected O, but got Unknown
		//IL_08ce: Expected O, but got I
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Expected O, but got Unknown
		//IL_08a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Expected O, but got Unknown
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b3: Expected O, but got Unknown
		//IL_0848: Unknown result type (might be due to invalid IL or missing references)
		//IL_084d: Expected O, but got Unknown
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_085b: Expected O, but got Unknown
		//IL_0927: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Expected O, but got Unknown
		//IL_0934: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Expected O, but got Unknown
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Expected O, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e1: Expected O, but got Unknown
		//IL_08ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ef: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		object obj2;
		if (sFSObject != null)
		{
			obj2 = typeof(System.IOAsyncCallback) + 976;
			object obj3 = "https://www.kammelna.com/Home/Terms" + 136;
			object obj4 = "m_StencilDeferredPS" + 2848;
			nint num = (nint)sFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00df;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v5 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
			object obj6 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X10_v65-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj6 += 16;
				obj5--;
				if ((nint)obj5 != 1)
				{
					continue;
				}
				goto IL_00df;
			}
			object obj7 = obj6 + 35;
			object obj8 = num + obj7;
			object obj9 = obj8 + 312;
			goto IL_09ae;
		}
		return (ISFSObject)new NullReferenceException();
		IL_0484:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v46 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		object obj11;
		object obj12;
		object obj14;
		bool flag3;
		object obj13;
		bool flag2;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X10_v50-8]");
			if (0 == (nint)obj11)
			{
				break;
			}
			obj10 += 16;
			obj12--;
			bool flag = (nint)obj12 != 1;
			obj13 = obj14;
			flag2 = flag3;
			object obj15 = obj11;
			if (flag)
			{
				continue;
			}
			goto IL_04f3;
		}
		object obj16 = obj10 + 32;
		nint num2;
		object obj17 = num2 + obj16;
		object obj18 = obj17 + 312;
		obj13 = obj14;
		flag2 = flag3;
		goto IL_0ad6;
		IL_0b50:
		object obj19 = "https://www.kammelna.com/Home/Terms" + 4016;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v634 @ X0_v17] (should have been resolved before IL gen)");
		nint num3 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_062b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v647 @ X8_v20 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj21 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X10_v40-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj21 += 16;
			obj20--;
			if ((nint)obj20 != 1)
			{
				continue;
			}
			goto IL_062b;
		}
		object obj22 = obj21 + 32;
		object obj23 = num3 + obj22;
		object obj24 = obj23 + 312;
		goto IL_0bca;
		IL_0d60:
		object obj25 = "placementId" + 1536;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v976 @ X0_v30] (should have been resolved before IL gen)");
		nint num4 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X8_v32 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X8_v32 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_087b;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v989 @ X8_v32 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj27 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1031 @ X10_v20-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj27 += 16;
			obj26--;
			if ((nint)obj26 != 1)
			{
				continue;
			}
			goto IL_087b;
		}
		object obj28 = obj27 + 35;
		object obj29 = num4 + obj28;
		object obj30 = obj29 + 312;
		goto IL_0dda;
		IL_07e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0d60;
		IL_087b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0dda;
		IL_0753:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0ce6;
		IL_00df:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_09ae;
		IL_09ae:
		object obj31 = "placementId" + 1552;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v225 @ X0_v5] (should have been resolved before IL gen)");
		nint num5 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0173;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj33 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X10_v60-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj33 += 16;
			obj32--;
			if ((nint)obj32 != 1)
			{
				continue;
			}
			goto IL_0173;
		}
		object obj34 = obj33 + 39;
		object obj35 = num5 + obj34;
		object obj36 = obj35 + 312;
		goto IL_0a28;
		IL_0ce6:
		object obj37 = "alignContent" + 3040;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v892 @ X0_v27] (should have been resolved before IL gen)");
		nint num6 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_07e7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v905 @ X8_v29 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj39 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v947 @ X10_v25-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj39 += 16;
			obj38--;
			if ((nint)obj38 != 1)
			{
				continue;
			}
			goto IL_07e7;
		}
		object obj40 = obj39 + 39;
		object obj41 = num6 + obj40;
		object obj42 = obj41 + 312;
		goto IL_0d60;
		IL_04f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0ad6;
		IL_0ad6:
		object obj43 = "https://www.kammelna.com/Home/Terms" + 2392;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v549 @ X0_v14] (should have been resolved before IL gen)");
		nint num7 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0597;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X8_v17 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj45 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X10_v45-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj45 += 16;
			obj44--;
			if ((nint)obj44 != 1)
			{
				continue;
			}
			goto IL_0597;
		}
		object obj46 = obj45 + 32;
		object obj47 = num7 + obj46;
		object obj48 = obj47 + 312;
		goto IL_0b50;
		IL_0e45:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1129 @ X0_v36] (should have been resolved before IL gen)");
		return sFSObject;
		IL_0173:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0a28;
		IL_0a28:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v318 @ X0_v8] (should have been resolved before IL gen)");
		PlayerRank playerRank = <PlayerRank>k__BackingField;
		int num8;
		object obj49;
		object obj50;
		object obj51;
		nint num10;
		object obj53;
		int <Points>k__BackingField;
		if (<PlayerRank>k__BackingField != null)
		{
			num8 = playerRank.<Points>k__BackingField;
			obj49 = "https://www.kammelna.com/Home/Terms" + 3000;
			obj50 = obj2;
			nint num9 = (nint)sFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v54 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v336 @ X8_v54 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			bool flag4 = (nint)0 == 0;
			object obj52 = !flag4;
			num10 = num9;
			if (obj52 != null)
			{
				goto IL_02bc;
			}
			obj53 = obj49;
			<Points>k__BackingField = playerRank.<Points>k__BackingField;
			object obj54 = obj2;
		}
		else
		{
			obj49 = "https://www.kammelna.com/Home/Terms" + 3000;
			obj50 = obj2;
			num10 = (nint)sFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v51 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			obj51 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v51 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			bool flag5 = (nint)0 == 0;
			num8 = 0;
			obj53 = obj49;
			<Points>k__BackingField = 0;
			object obj54 = obj2;
			if (!flag5)
			{
				goto IL_02bc;
			}
		}
		goto IL_032b;
		IL_0bca:
		object key = "___# Content push apply failed [{0}]: {1}" + 3224;
		object obj55 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1976;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v718 @ X0_v20] (should have been resolved before IL gen)");
		nint num11 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_06bf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X8_v23 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj57 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X10_v35-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj57 += 16;
			obj56--;
			if ((nint)obj56 != 1)
			{
				continue;
			}
			goto IL_06bf;
		}
		object obj58 = obj57 + 32;
		object obj59 = num11 + obj58;
		object obj60 = obj59 + 312;
		goto IL_0c53;
		IL_062b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0bca;
		IL_02bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v51 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj61 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X10_v55-8]");
			if (0 == (nint)obj50)
			{
				break;
			}
			obj61 += 16;
			obj51--;
			bool flag6 = (nint)obj51 != 1;
			obj53 = obj49;
			<Points>k__BackingField = num8;
			object obj54 = obj50;
			if (flag6)
			{
				continue;
			}
			goto IL_032b;
		}
		object obj62 = obj61 + 35;
		object obj63 = num10 + obj62;
		object obj64 = obj63 + 312;
		obj53 = obj49;
		<Points>k__BackingField = num8;
		goto IL_0a7f;
		IL_0dda:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1060 @ X0_v33] (should have been resolved before IL gen)");
		nint num12 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X8_v35 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj65 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X8_v35 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_090f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1071 @ X8_v35 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj66 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1112 @ X10_v15-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj66 += 16;
			obj65--;
			if ((nint)obj65 != 1)
			{
				continue;
			}
			goto IL_090f;
		}
		object obj67 = obj66 + 35;
		object obj68 = num12 + obj67;
		object obj69 = obj68 + 312;
		goto IL_0e45;
		IL_0597:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0b50;
		IL_090f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0e45;
		IL_06bf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0c53;
		IL_032b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0a7f;
		IL_0a7f:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v438 @ X0_v11] (should have been resolved before IL gen)");
		PlayerRank playerRank2 = <PlayerRank>k__BackingField;
		if (<PlayerRank>k__BackingField != null)
		{
			flag3 = playerRank2.<IsNew>k__BackingField;
			obj14 = "https://www.kammelna.com/Home/Terms" + 616;
			obj11 = obj2;
			nint num13 = (nint)sFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v49 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X8_v49 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			bool flag7 = (nint)0 == 0;
			object obj70 = !flag7;
			num2 = num13;
			if (obj70 != null)
			{
				goto IL_0484;
			}
			obj13 = obj14;
			flag2 = playerRank2.<IsNew>k__BackingField;
			object obj15 = obj2;
		}
		else
		{
			obj14 = "https://www.kammelna.com/Home/Terms" + 616;
			obj11 = obj2;
			num2 = (nint)sFSObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v46 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v46 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
			bool flag8 = (nint)0 == 0;
			flag3 = false;
			obj13 = obj14;
			flag2 = false;
			object obj15 = obj2;
			if (!flag8)
			{
				goto IL_0484;
			}
		}
		goto IL_04f3;
		IL_0c53:
		object obj71 = "___# Content push apply failed [{0}]: {1}" + 3976;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v804 @ X0_v23] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (PlayerInfo)+38]");
		SFSExtensions.PutDate(sFSObject, (string)key, (DateTime)0);
		nint num14 = (nint)sFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		object obj72 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0753;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v821 @ X8_v26 (Il2CppClass<Sfs2X.Entities.Data.SFSObject>)+B0]");
		object obj73 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v863 @ X10_v30-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj73 += 16;
			obj72--;
			if ((nint)obj72 != 1)
			{
				continue;
			}
			goto IL_0753;
		}
		object obj74 = obj73 + 35;
		object obj75 = num14 + obj74;
		object obj76 = obj75 + 312;
		goto IL_0ce6;
	}

	public bool HasAvatar()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected I4, but got Unknown
		return (byte)((??)<AvatarDate>k__BackingField & 1) != 0;
	}

	protected bool Equals(PlayerInfo other)
	{
		//IL_0053: Expected I4, but got O
		//IL_0031: Expected O, but got I4
		if (other != null)
		{
			object obj = <DBID>k__BackingField - other.<DBID>k__BackingField;
			return obj == null;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public override bool Equals(object obj)
	{
		//IL_0049: Expected O, but got I4
		//IL_0059: Expected O, but got I
		//IL_00f2: Expected O, but got I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0124: Expected I, but got O
		//IL_014d: Expected O, but got I4
		//IL_01e1: Expected I4, but got O
		//IL_0181: Expected O, but got I
		//IL_01bf: Expected O, but got I
		if (obj != null)
		{
			if (this != obj)
			{
				Type type = obj.GetType();
				Type type2 = GetType();
				object obj2 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X8_v5+E0]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v9+E4]");
				if ((nint)0 != 0)
				{
					if (type != type2)
					{
						goto IL_00ac;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag = type != type2;
					bool flag2 = !flag;
					object obj4 = !flag2;
					if (obj4 != null)
					{
						goto IL_00ac;
					}
				}
				object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 936;
				object obj6 = obj5;
				nint num = (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v9 (Il2CppClass<System.Object>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X1_v5+130]");
				bool flag3 = num2 < 0;
				object obj7 = !flag3;
				object obj8 = ~obj7;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v9 (Il2CppClass<System.Object>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X1_v5+130]");
					object obj9 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v12-8]");
					if (0 == (nint)obj6)
					{
						int num4 = <DBID>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [obj @ X1 (System.Object)+10]");
						object obj10 = (nint)num4 - (nint)0;
						return obj10 == null;
					}
				}
				InvalidCastException ex = new InvalidCastException();
				return (byte)(int)ex != 0;
			}
			return true;
		}
		goto IL_00ac;
		IL_00ac:
		return false;
	}

	public override int GetHashCode()
	{
		return <DBID>k__BackingField;
	}
}
