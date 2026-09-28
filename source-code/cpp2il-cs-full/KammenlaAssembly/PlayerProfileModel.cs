using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using GoogleMobileAds.Ump.Api;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Mono.Btls;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class PlayerProfileModel
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<UserAchievementModel, bool> <>9__95_0;

		public static Func<UserAchievementModel, string> <>9__95_1;

		public static Func<GameAchievementViewModel, string> <>9__95_2;

		public static Func<UserAchievementModel, GameAchievementViewModel, <>f__AnonymousType8<UserAchievementModel, GameAchievementViewModel>> <>9__95_3;

		public static Func<<>f__AnonymousType8<UserAchievementModel, GameAchievementViewModel>, bool> <>9__95_4;

		public static Func<<>f__AnonymousType8<UserAchievementModel, GameAchievementViewModel>, string> <>9__95_5;

		public static Func<UserAchievementModel, bool> <>9__96_0;

		public static Func<UserAchievementModel, bool> <>9__97_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <GetOwnedTitlesList>b__95_0(UserAchievementModel achievement)
		{
			//IL_00b6: Expected I4, but got O
			//IL_0096: Expected O, but got I4
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected I4, but got Unknown
			if (achievement != null)
			{
				bool flag = achievement.<levelId>k__BackingField < 0;
				bool flag2 = achievement.<levelId>k__BackingField == 0;
				int num = achievement.<levelId>k__BackingField ^ achievement.<levelId>k__BackingField;
				int num2 = achievement.<levelId>k__BackingField & num;
				bool flag3 = num2 < 0;
				bool flag4 = flag == flag3;
				object obj = !flag2;
				return (byte)((flag4 & obj) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal string <GetOwnedTitlesList>b__95_1(UserAchievementModel achievement)
		{
			if (achievement != null)
			{
				return achievement.<gameAchievementId>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}

		internal string <GetOwnedTitlesList>b__95_2(GameAchievementViewModel model)
		{
			if (model != null)
			{
				return model.<id>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}

		internal <>f__AnonymousType8<UserAchievementModel, GameAchievementViewModel> <GetOwnedTitlesList>b__95_3(UserAchievementModel achievement, GameAchievementViewModel model)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 128;
			object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 2696;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FDBF28");
			<>f__AnonymousType8<UserAchievementModel, GameAchievementViewModel> result = default(<>f__AnonymousType8<UserAchievementModel, GameAchievementViewModel>);
			return result;
		}

		internal bool <GetOwnedTitlesList>b__95_4(<>f__AnonymousType8<UserAchievementModel, GameAchievementViewModel> <>h__TransparentIdentifier0)
		{
			//IL_0069: Expected I4, but got O
			//IL_0047: Expected O, but got I4
			if (<>h__TransparentIdentifier0 != null)
			{
				GameAchievementViewModel <model>i__Field = <>h__TransparentIdentifier0.<model>i__Field;
				if (<>h__TransparentIdentifier0.<model>i__Field != null)
				{
					object obj = <model>i__Field.<type>k__BackingField - 1;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal string <GetOwnedTitlesList>b__95_5(<>f__AnonymousType8<UserAchievementModel, GameAchievementViewModel> <>h__TransparentIdentifier0)
		{
			if (<>h__TransparentIdentifier0 != null)
			{
				GameAchievementViewModel <model>i__Field = <>h__TransparentIdentifier0.<model>i__Field;
				if (<>h__TransparentIdentifier0.<model>i__Field != null)
				{
					return <model>i__Field.<id>k__BackingField;
				}
			}
			return (string)(object)new NullReferenceException();
		}

		internal bool <GetCelebrationTrophy>b__96_0(UserAchievementModel t)
		{
			//IL_00b1: Expected I4, but got O
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_00e1: Expected O, but got I4
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			if (t != null)
			{
				object obj = "m_StencilDeferredPS" + 2376;
				bool flag = t.<gameAchievementId>k__BackingField == (string)obj;
				bool flag2 = !flag;
				object obj2 = !flag2;
				if (obj2 == null)
				{
					object obj3 = "m_StencilDeferredPS" + 2352;
					if (!(t.<gameAchievementId>k__BackingField == (string)obj3))
					{
						object obj4 = "m_StencilDeferredPS" + 2344;
						return t.<gameAchievementId>k__BackingField == (string)obj4;
					}
				}
				return true;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetMonthlyTrophy>b__97_0(UserAchievementModel t)
		{
			//IL_00b1: Expected I4, but got O
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			//IL_00e1: Expected O, but got I4
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Expected O, but got Unknown
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			if (t != null)
			{
				object obj = "m_StencilDeferredPS" + 2376;
				bool flag = t.<gameAchievementId>k__BackingField == (string)obj;
				bool flag2 = !flag;
				object obj2 = !flag2;
				if (obj2 == null)
				{
					object obj3 = "m_StencilDeferredPS" + 2352;
					if (!(t.<gameAchievementId>k__BackingField == (string)obj3))
					{
						object obj4 = "m_StencilDeferredPS" + 2344;
						return t.<gameAchievementId>k__BackingField == (string)obj4;
					}
				}
				return true;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private string <userName>k__BackingField;

	private string <activeTitle>k__BackingField;

	private int <activeTitleLevel>k__BackingField;

	private int <activeCardback>k__BackingField;

	private int <activeProfilePattern>k__BackingField;

	private FeaturedSlotModel <featuredSlot>k__BackingField;

	private int <points>k__BackingField;

	private bool <isNew>k__BackingField;

	private int <likes>k__BackingField;

	private string <bio>k__BackingField;

	private bool <isLiked>k__BackingField;

	private bool <isSubscribed>k__BackingField;

	private bool <isVerified>k__BackingField;

	private DateTime? <avatarDate>k__BackingField;

	private long <userDbId>k__BackingField;

	private PlayerRankingModel <ranking>k__BackingField;

	private TournamentRankingModel <tournamentRanking>k__BackingField;

	private List<UserAchievementModel> <gameAchievements>k__BackingField;

	private int <achievementPoints>k__BackingField;

	private List<ProfileGiftQuantityPair> <profileGifts>k__BackingField;

	private PrivateUserInfo <PrivateInfo>k__BackingField;

	private ClanBadgeModel <activeClan>k__BackingField;

	public string userName
	{
		get
		{
			return <userName>k__BackingField;
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

	public string activeTitle
	{
		get
		{
			return <activeTitle>k__BackingField;
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

	public int activeTitleLevel
	{
		get
		{
			return <activeTitleLevel>k__BackingField;
		}
		set
		{
			<activeTitleLevel>k__BackingField = value;
		}
	}

	public int activeCardback
	{
		get
		{
			return <activeCardback>k__BackingField;
		}
		set
		{
			<activeCardback>k__BackingField = value;
		}
	}

	public int activeProfilePattern
	{
		get
		{
			return <activeProfilePattern>k__BackingField;
		}
		set
		{
			<activeProfilePattern>k__BackingField = value;
		}
	}

	public FeaturedSlotModel featuredSlot
	{
		get
		{
			return <featuredSlot>k__BackingField;
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

	public int points
	{
		get
		{
			return <points>k__BackingField;
		}
		set
		{
			<points>k__BackingField = value;
		}
	}

	public bool isNew
	{
		get
		{
			return <isNew>k__BackingField;
		}
		set
		{
			<isNew>k__BackingField = value;
		}
	}

	public int likes
	{
		get
		{
			return <likes>k__BackingField;
		}
		set
		{
			<likes>k__BackingField = value;
		}
	}

	public string bio
	{
		get
		{
			return <bio>k__BackingField;
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

	public bool isLiked
	{
		get
		{
			return <isLiked>k__BackingField;
		}
		set
		{
			<isLiked>k__BackingField = value;
		}
	}

	public bool isSubscribed
	{
		get
		{
			return <isSubscribed>k__BackingField;
		}
		set
		{
			<isSubscribed>k__BackingField = value;
		}
	}

	public bool isVerified
	{
		get
		{
			return <isVerified>k__BackingField;
		}
		set
		{
			<isVerified>k__BackingField = value;
		}
	}

	public DateTime? avatarDate
	{
		get
		{
			return <avatarDate>k__BackingField;
		}
		set
		{
			<avatarDate>k__BackingField = value;
		}
	}

	public long userDbId
	{
		get
		{
			return <userDbId>k__BackingField;
		}
		set
		{
			<userDbId>k__BackingField = value;
		}
	}

	public PlayerRankingModel ranking
	{
		get
		{
			return <ranking>k__BackingField;
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

	public TournamentRankingModel tournamentRanking
	{
		get
		{
			return <tournamentRanking>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 120;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<UserAchievementModel> gameAchievements
	{
		get
		{
			return <gameAchievements>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 128;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int achievementPoints
	{
		get
		{
			return <achievementPoints>k__BackingField;
		}
		set
		{
			<achievementPoints>k__BackingField = value;
		}
	}

	public List<ProfileGiftQuantityPair> profileGifts
	{
		get
		{
			return <profileGifts>k__BackingField;
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

	public PrivateUserInfo PrivateInfo
	{
		get
		{
			return <PrivateInfo>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 152;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public ClanBadgeModel activeClan
	{
		get
		{
			return <activeClan>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 160;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public PlayerProfileModel()
	{
	}

	public PlayerProfileModel(PlayerInfo playerInfo)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_00d4: Expected I8, but got I4
		object obj = this + 16;
		obj = playerInfo.<Name>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = playerInfo.<ActiveGameTitle>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = playerInfo.<ActiveCardBack>k__BackingField;
		_ = playerInfo.<ActiveProfilePattern>k__BackingField;
		PlayerRank <PlayerRank>k__BackingField = playerInfo.<PlayerRank>k__BackingField;
		<points>k__BackingField = <PlayerRank>k__BackingField.<Points>k__BackingField;
		<isNew>k__BackingField = <PlayerRank>k__BackingField.<IsNew>k__BackingField;
		<isLiked>k__BackingField = playerInfo.<IsLiked>k__BackingField;
		<isSubscribed>k__BackingField = playerInfo.<IsSubscribed>k__BackingField;
		<avatarDate>k__BackingField = playerInfo.<AvatarDate>k__BackingField;
		<userDbId>k__BackingField = playerInfo.<DBID>k__BackingField;
	}

	public PlayerProfileModel(User user, bool isLiked)
	{
		<isLiked>k__BackingField = isLiked;
		Update(user);
	}

	public override string ToString()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0074: Expected O, but got I4
		object obj = "___# Content push apply failed [{0}]: {1}" + 1168;
		object obj2 = "&action=sign-up" + 3416;
		object format = "___# Content push apply failed [{0}]: {1}" + 1184;
		object obj3 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		string text = string.Format((string)format, <userName>k__BackingField, arg, arg2);
		string text2 = DetailsString();
		return (string)obj + text + (string)obj2 + text2;
	}

	private string SummaryString()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0029: Expected O, but got I4
		object format = "___# Content push apply failed [{0}]: {1}" + 1184;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		object arg2 = default(object);
		return string.Format((string)format, <userName>k__BackingField, arg, arg2);
	}

	private string DetailsString()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		object format = "___# Content push apply failed [{0}]: {1}" + 1160;
		object obj = typeof(List<Tween>) + 2432;
		int? num = (int?)<gameAchievements>k__BackingField;
		if (<gameAchievements>k__BackingField != null)
		{
			object obj2 = (nint)0 + (nint)3136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v4 (System.Nullable`1<System.Int32>)+18]");
			int? num2 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, <ranking>k__BackingField, arg);
	}

	public int AchievementsCount()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Expected I, but got O
		//IL_0052: Expected O, but got I
		//IL_01e8: Expected I, but got O
		//IL_008d: Expected O, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		Room lastJoinedRoom = SFS.LastJoinedRoom;
		if (lastJoinedRoom == null)
		{
			goto IL_0175;
		}
		object obj = typeof(RegisteredWaitHandle) + 1376;
		object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 56;
		object obj3 = (nint)0 + (nint)1248;
		nint num = (nint)lastJoinedRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00ce;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v6-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj5 += 16;
			obj4--;
			if ((nint)obj4 != 1)
			{
				continue;
			}
			goto IL_00ce;
		}
		object obj6 = obj5 + 28;
		object obj7 = num + obj6;
		object obj8 = obj7 + 312;
		goto IL_01c6;
		IL_01c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v134 @ X8_v7] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor((object)this, (IntPtr)obj3);
		IEnumerable<object> source = default(IEnumerable<object>);
		object obj9 = Enumerable.FirstOrDefault(source, func);
		if (obj9 != null)
		{
			int achievementCount = SFSKammelnaUserExtensions.GetAchievementCount((User)obj9);
			int? num2 = achievementCount;
			int num3 = default(int);
			if (num3 > 0)
			{
				return num3;
			}
		}
		goto IL_0175;
		IL_0175:
		return <achievementPoints>k__BackingField;
		IL_00ce:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj10 = default(object);
		obj8 = obj10;
		goto IL_01c6;
	}

	public List<string> GetOwnedTitlesList()
	{
		//IL_000c: Expected O, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0051: Expected O, but got I4
		//IL_0a1f: Expected O, but got I
		//IL_0a2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Expected O, but got Unknown
		//IL_0a43: Expected O, but got I
		//IL_0a53: Expected O, but got I
		//IL_0a75: Expected O, but got I4
		//IL_00d5: Expected I, but got O
		//IL_0098: Expected O, but got I4
		//IL_03c2: Expected O, but got I4
		//IL_0a92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Expected O, but got Unknown
		//IL_0aad: Expected O, but got I
		//IL_0abe: Expected I, but got O
		//IL_0adc: Expected O, but got I
		//IL_0af7: Expected O, but got I4
		//IL_0173: Expected O, but got I
		//IL_0183: Expected O, but got I
		//IL_040a: Expected O, but got I
		//IL_041a: Expected O, but got I
		//IL_043c: Expected O, but got I4
		//IL_00c8: Expected O, but got I
		//IL_047c: Expected O, but got I4
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected O, but got Unknown
		//IL_0b2e: Expected O, but got I
		//IL_0b36: Expected I, but got O
		//IL_0b47: Expected I, but got O
		//IL_0b65: Expected O, but got I
		//IL_0555: Expected O, but got I
		//IL_0565: Expected O, but got I
		//IL_0587: Expected O, but got I4
		//IL_04db: Expected O, but got I4
		//IL_04e4: Expected O, but got I4
		//IL_0505: Expected O, but got I4
		//IL_0515: Expected I, but got O
		//IL_04ac: Expected O, but got I
		//IL_0225: Expected O, but got I
		//IL_0235: Expected O, but got I
		//IL_06c4: Expected O, but got I
		//IL_06d4: Expected O, but got I
		//IL_06e4: Expected O, but got I
		//IL_0706: Expected O, but got I4
		//IL_05e7: Expected O, but got I4
		//IL_02f3: Expected O, but got I
		//IL_0303: Expected O, but got I
		//IL_0313: Expected O, but got I
		//IL_0335: Expected O, but got I4
		//IL_0b8b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b90: Expected O, but got Unknown
		//IL_0ba6: Expected O, but got I
		//IL_0bae: Expected I, but got O
		//IL_0bbf: Expected I, but got O
		//IL_0bdd: Expected O, but got I
		//IL_0851: Expected O, but got I
		//IL_0861: Expected O, but got I
		//IL_0871: Expected O, but got I
		//IL_0893: Expected O, but got I4
		//IL_0756: Expected O, but got I4
		//IL_0646: Expected O, but got I4
		//IL_064f: Expected O, but got I4
		//IL_0678: Expected O, but got I4
		//IL_0688: Expected I, but got O
		//IL_0617: Expected O, but got I
		//IL_0943: Expected O, but got I4
		//IL_07ce: Expected O, but got I
		//IL_07de: Expected O, but got I
		//IL_07ee: Expected O, but got I
		//IL_0810: Expected O, but got I4
		//IL_0c03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Expected O, but got Unknown
		//IL_0c1e: Expected O, but got I
		//IL_0c2f: Expected I, but got O
		//IL_0c4d: Expected O, but got I
		//IL_0d23: Expected O, but got I
		//IL_0d33: Expected O, but got I
		//IL_0d55: Expected O, but got I4
		//IL_08d3: Expected O, but got I4
		//IL_0786: Expected O, but got I
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected O, but got Unknown
		//IL_0cb6: Expected O, but got I
		//IL_0cc7: Expected I, but got O
		//IL_0ce5: Expected O, but got I
		//IL_098a: Expected O, but got I4
		//IL_0903: Expected O, but got I
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d77: Expected O, but got Unknown
		//IL_0d8d: Expected O, but got I
		//IL_0d9e: Expected I, but got O
		//IL_0dbc: Expected O, but got I
		//IL_09ba: Expected O, but got I
		object obj = (nint)0 + (nint)2832;
		if (ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)<gameAchievements>k__BackingField))
		{
			return null;
		}
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2568;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		object obj5 = (nint)0 + (nint)3848;
		object obj6 = typeof(SqlSingle[]) + 2360;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v5+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v79+8]");
		Func<object, bool> func = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v79+8]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		object obj15 = default(object);
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v85+B8]");
				obj7 = 0;
			}
			object obj11 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj12 = (nint)0 + (nint)944;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj7, (IntPtr)obj12);
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v84+B8]");
			object obj14 = (nint)0 + (nint)8;
			obj14 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj15 = 0;
			func = func2;
		}
		nint num = (nint)obj5;
		IEnumerable<object> enumerable = Enumerable.Where(<gameAchievements>k__BackingField, func);
		object obj16 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v9+E4]");
		IEnumerable<GameAchievementViewModel> enumerable3;
		object obj17;
		IEnumerable<GameAchievementViewModel> enumerable2;
		if ((nint)0 != 0)
		{
			IEnumerable<GameAchievementViewModel> titles = AchievementsManager.Titles;
			obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v42+E4]");
			bool flag4 = (nint)0 == 0;
			enumerable2 = titles;
			object obj18 = obj17;
			enumerable3 = titles;
			if (!flag4)
			{
				goto IL_0163;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			IEnumerable<GameAchievementViewModel> titles2 = AchievementsManager.Titles;
			obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v42+E4]");
			bool flag5 = (nint)0 == 0;
			object obj19 = !flag5;
			enumerable2 = titles2;
			object obj18 = obj17;
			enumerable3 = titles2;
			if (obj19 != null)
			{
				goto IL_0163;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v42+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v56+10]");
		Func<object, object> func3 = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v56+10]");
		bool flag6 = (nint)0 == 0;
		object obj21 = !flag6;
		enumerable2 = enumerable3;
		object obj22 = obj17;
		if (obj21 != null)
		{
			goto IL_01b8;
		}
		goto IL_045a;
		IL_01b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v42+E4]");
		bool flag7 = (nint)0 == 0;
		Func<object, bool> func4 = func;
		object obj23 = obj15;
		Func<object, bool> func5 = func;
		nint num2 = num;
		object obj24 = obj17;
		enumerable3 = enumerable2;
		Func<object, object> func6 = func3;
		if (!flag7)
		{
			goto IL_0215;
		}
		goto IL_0533;
		IL_0215:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v42+B8]");
		object obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v44+18]");
		Func<object, object> func7 = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v44+18]");
		bool flag8 = (nint)0 == 0;
		obj23 = obj15;
		func5 = func4;
		num2 = num;
		object obj26 = obj17;
		enumerable3 = enumerable2;
		func6 = func3;
		if (!flag8)
		{
			goto IL_028a;
		}
		goto IL_05c5;
		IL_0533:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v42+B8]");
		obj25 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v44+18]");
		func7 = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v44+18]");
		bool flag9 = (nint)0 == 0;
		object obj27 = !flag9;
		obj15 = obj23;
		func4 = func5;
		num = num2;
		enumerable2 = enumerable3;
		func3 = func6;
		obj26 = obj17;
		if (obj27 != null)
		{
			goto IL_028a;
		}
		goto IL_05c5;
		IL_078b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC6B00");
		object obj28 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v32+E4]");
		object obj30;
		Func<object, bool> predicate;
		object obj32;
		Func<object, object> func8;
		object obj29;
		if ((nint)0 != 0)
		{
			obj29 = (nint)0 + (nint)3096;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v32+B8]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v22+28]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v22+28]");
			bool flag10 = (nint)0 == 0;
			object obj31 = !flag10;
			func8 = func7;
			if (obj31 == null)
			{
				obj32 = obj29;
				goto IL_08b1;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = obj2;
			obj32 = (nint)0 + (nint)3096;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v32+B8]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v22+28]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v22+28]");
			bool flag11 = (nint)0 == 0;
			object obj33 = !flag11;
			func8 = func7;
			obj29 = obj32;
			if (obj33 == null)
			{
				goto IL_08b1;
			}
		}
		goto IL_0908;
		IL_028a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v42+E4]");
		bool flag12 = (nint)0 == 0;
		object obj34 = obj15;
		Func<object, bool> func9 = func4;
		nint num3 = num;
		Func<object, object> func10 = func7;
		object obj35 = obj17;
		enumerable3 = enumerable2;
		func6 = func3;
		if (!flag12)
		{
			goto IL_02e7;
		}
		goto IL_06a6;
		IL_08b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v32+E4]");
		bool flag13 = (nint)0 == 0;
		object obj36 = !flag13;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj37 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v28+B8]");
			obj30 = 0;
		}
		object obj38 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj39 = (nint)0 + (nint)976;
		Func<object, bool> func11 = default(Func<object, bool>);
		func11..ctor(obj30, (IntPtr)obj39);
		object obj40 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v27+B8]");
		object obj41 = (nint)0 + (nint)40;
		obj41 = func11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		func8 = null;
		obj29 = obj32;
		predicate = func11;
		goto IL_0908;
		IL_05c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v53+E4]");
		bool flag14 = (nint)0 == 0;
		object obj42 = !flag14;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj43 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v51+B8]");
			obj25 = 0;
		}
		object obj44 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj45 = (nint)0 + (nint)960;
		num = (nint)obj45;
		Func<object, object> func12 = default(Func<object, object>);
		func12..ctor(obj25, (IntPtr)obj45);
		object obj46 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v49+B8]");
		object obj47 = (nint)0 + (nint)24;
		obj47 = func12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v42+E4]");
		bool flag15 = (nint)0 == 0;
		object obj48 = !flag15;
		obj15 = 0;
		func4 = (Func<object, bool>)(object)func12;
		func7 = func12;
		enumerable2 = enumerable3;
		func3 = func6;
		obj34 = 0;
		func9 = (Func<object, bool>)(object)func12;
		num3 = (nint)obj45;
		func10 = func12;
		obj35 = obj17;
		if (obj48 != null)
		{
			goto IL_02e7;
		}
		goto IL_06a6;
		IL_0734:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v42+E4]");
		bool flag16 = (nint)0 == 0;
		object obj49 = !flag16;
		object obj51;
		if (obj49 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj50 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v39+B8]");
			obj51 = 0;
		}
		object obj52 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 1104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj53 = (nint)0 + (nint)968;
		Func<object, object, object> func13 = default(Func<object, object, object>);
		func13..ctor(obj51, (IntPtr)obj53);
		object obj54 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v38+B8]");
		object obj55 = (nint)0 + (nint)32;
		obj55 = func13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj57;
		object obj56 = obj57;
		Func<object, object, object> func14 = func13;
		func7 = func10;
		enumerable2 = enumerable3;
		func3 = func6;
		goto IL_078b;
		IL_02e7:
		obj56 = (nint)0 + (nint)1608;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v42+B8]");
		obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v33+20]");
		func14 = (Func<object, object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v33+20]");
		bool flag17 = (nint)0 == 0;
		object obj58 = !flag17;
		if (obj58 == null)
		{
			obj34 = obj15;
			func9 = func4;
			num3 = num;
			obj57 = obj56;
			func10 = func7;
			enumerable3 = enumerable2;
			func6 = func3;
			goto IL_0734;
		}
		goto IL_078b;
		IL_06a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj17 = obj2;
		obj57 = (nint)0 + (nint)1608;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v42+B8]");
		obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v33+20]");
		func14 = (Func<object, object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v443 @ X8_v33+20]");
		bool flag18 = (nint)0 == 0;
		object obj59 = !flag18;
		obj56 = obj57;
		func7 = func10;
		enumerable2 = enumerable3;
		func3 = func6;
		if (obj59 == null)
		{
			goto IL_0734;
		}
		goto IL_078b;
		IL_0163:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v42+B8]");
		obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v56+10]");
		func3 = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v56+10]");
		bool flag19 = (nint)0 == 0;
		obj22 = obj17;
		enumerable3 = enumerable2;
		if (!flag19)
		{
			goto IL_01b8;
		}
		goto IL_045a;
		IL_045a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v65+E4]");
		bool flag20 = (nint)0 == 0;
		object obj60 = !flag20;
		if (obj60 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj61 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v63+B8]");
			obj20 = 0;
		}
		object obj62 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj63 = (nint)0 + (nint)952;
		num = (nint)obj63;
		Func<object, object> func15 = default(Func<object, object>);
		func15..ctor(obj20, (IntPtr)obj63);
		object obj64 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v61+B8]");
		object obj65 = (nint)0 + (nint)16;
		obj65 = func15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj17 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v42+E4]");
		bool flag21 = (nint)0 == 0;
		object obj66 = !flag21;
		obj15 = 0;
		func4 = (Func<object, bool>)(object)func15;
		enumerable2 = enumerable3;
		func3 = func15;
		obj23 = 0;
		func5 = (Func<object, bool>)(object)func15;
		num2 = (nint)obj63;
		obj24 = obj17;
		func6 = func15;
		if (obj66 != null)
		{
			goto IL_0215;
		}
		goto IL_0533;
		IL_0908:
		IEnumerable<object> source2 = default(IEnumerable<object>);
		IEnumerable<object> source = Enumerable.Where(source2, predicate);
		object obj67 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v18+E4]");
		bool flag22 = (nint)0 == 0;
		object obj68 = !flag22;
		if (obj68 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj67 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v18+B8]");
		object obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v13+30]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v13+30]");
		bool flag23 = (nint)0 == 0;
		object obj70 = !flag23;
		if (obj70 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X0_v18+E4]");
			bool flag24 = (nint)0 == 0;
			object obj71 = !flag24;
			if (obj71 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj72 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v566 @ X8_v19+B8]");
				obj69 = 0;
			}
			object obj73 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj74 = (nint)0 + (nint)984;
			Func<object, object> func16 = default(Func<object, object>);
			func16..ctor(obj69, (IntPtr)obj74);
			object obj75 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X8_v18+B8]");
			object obj76 = (nint)0 + (nint)48;
			obj76 = func16;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func16;
		}
		IEnumerable<object> source3 = Enumerable.Select(source, selector);
		return (List<string>)(object)Enumerable.ToList(source3);
	}

	public UserAchievementModel GetCelebrationTrophy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0104: Expected O, but got I
		//IL_0114: Expected O, but got I
		//IL_0124: Expected O, but got I
		//IL_0146: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_0072: Expected O, but got I
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_017e: Expected O, but got I4
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03bf: Expected O, but got I
		//IL_03d0: Expected I, but got O
		//IL_03ee: Expected O, but got I
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0261: Expected O, but got I4
		//IL_01ae: Expected O, but got I
		//IL_0343: Expected O, but got I
		//IL_0366: Expected O, but got I4
		//IL_02fe: Expected O, but got I
		object obj3;
		Func<object, bool> func;
		UserAchievementModel userAchievementModel = default(UserAchievementModel);
		object obj13;
		Func<object, bool> func3;
		if (<gameAchievements>k__BackingField != null)
		{
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2568;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v21+E4]");
			object obj4;
			object obj5;
			if ((nint)0 != 0)
			{
				obj3 = (nint)0 + (nint)1848;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v21+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v12+38]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v12+38]");
				bool flag = (nint)0 == 0;
				obj5 = obj3;
				if (!flag)
				{
					goto IL_009f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				obj3 = (nint)0 + (nint)1848;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v21+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v12+38]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v12+38]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				obj5 = obj3;
				if (obj6 != null)
				{
					goto IL_009f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v21+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v18+B8]");
				obj4 = 0;
			}
			object obj9 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)928;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj4, (IntPtr)obj10);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v17+B8]");
			object obj12 = (nint)0 + (nint)56;
			obj12 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj13 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC96CC");
			bool flag4 = userAchievementModel == null;
			func3 = func2;
			if (!flag4)
			{
				goto IL_01ea;
			}
		}
		goto IL_0374;
		IL_0374:
		return null;
		IL_031f:
		return userAchievementModel;
		IL_01ea:
		object obj14 = typeof(DataRelation) + 712;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v6+E4]");
		DateTime now;
		if ((nint)0 != 0)
		{
			now = DateTime.Now;
			object obj16 = (??)userAchievementModel.<celebrationUntil>k__BackingField & 1;
			bool flag5 = obj16 == null;
			object obj17 = !flag5;
			if (obj17 != null)
			{
				goto IL_02bc;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			now = DateTime.Now;
			object obj18 = (??)userAchievementModel.<celebrationUntil>k__BackingField & 1;
			if (obj18 != null)
			{
				goto IL_02bc;
			}
		}
		goto IL_0374;
		IL_009f:
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC96CC");
		bool flag6 = userAchievementModel == null;
		object obj19 = !flag6;
		func3 = func;
		if (obj19 != null)
		{
			goto IL_01ea;
		}
		goto IL_0374;
		IL_02bc:
		object obj20 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			DateTime dateTime = now;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v13 (UserAchievementModel)+50]");
			if (dateTime < (DateTime)0)
			{
				goto IL_031f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			DateTime dateTime2 = now;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal2 @ X0_v13 (UserAchievementModel)+50]");
			bool flag7 = dateTime2 < (DateTime)0;
			bool flag8 = !flag7;
			object obj21 = !flag8;
			if (obj21 != null)
			{
				goto IL_031f;
			}
		}
		goto IL_0374;
	}

	public UserAchievementModel GetMonthlyTrophy()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0104: Expected O, but got I
		//IL_0114: Expected O, but got I
		//IL_0124: Expected O, but got I
		//IL_0146: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_0072: Expected O, but got I
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0228: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_04d1: Expected O, but got I
		//IL_04e2: Expected I, but got O
		//IL_0500: Expected O, but got I
		//IL_01ae: Expected O, but got I
		//IL_031d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Expected O, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02ce: Expected O, but got I4
		//IL_0376: Expected O, but got I4
		//IL_03a8: Expected O, but got I
		//IL_03b8: Expected O, but got I
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_041f: Expected O, but got I4
		//IL_044a: Expected O, but got I4
		//IL_0468: Expected O, but got I4
		object obj3;
		Func<object, bool> func;
		UserAchievementModel userAchievementModel = default(UserAchievementModel);
		object obj13;
		Func<object, bool> func3;
		if (<gameAchievements>k__BackingField != null)
		{
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2568;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v30+E4]");
			object obj4;
			object obj5;
			if ((nint)0 != 0)
			{
				obj3 = (nint)0 + (nint)1848;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v30+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v17+40]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v17+40]");
				bool flag = (nint)0 == 0;
				obj5 = obj3;
				if (!flag)
				{
					goto IL_009f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
				obj3 = (nint)0 + (nint)1848;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v30+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v17+40]");
				func = (Func<object, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v17+40]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				obj5 = obj3;
				if (obj6 != null)
				{
					goto IL_009f;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X0_v30+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v23+B8]");
				obj4 = 0;
			}
			object obj9 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 80;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)936;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj4, (IntPtr)obj10);
			object obj11 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v22+B8]");
			object obj12 = (nint)0 + (nint)64;
			obj12 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj13 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC96CC");
			bool flag4 = userAchievementModel == null;
			func3 = func2;
			if (!flag4)
			{
				goto IL_01ea;
			}
		}
		goto IL_047e;
		IL_0517:
		UserAchievementModel result;
		return result;
		IL_034c:
		object obj15;
		object obj14 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X0_v13+E4]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X0_v6 (UserAchievementModel)+40]");
		TimeSpan timeSpan;
		DateTime value = (DateTime)0 + timeSpan;
		object obj17 = (nint)0 + (nint)2264;
		DateTime? dateTime = value;
		object obj18 = (??)dateTime & 1;
		DateTime now;
		if (obj18 != null)
		{
			object obj19 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v18+E4]");
			bool flag6 = (nint)0 == 0;
			object obj20 = !flag6;
			if (obj20 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = now < (DateTime)0;
			bool flag8 = !flag7;
			object obj21 = !flag8;
			result = userAchievementModel;
			if (obj21 != null)
			{
				goto IL_0517;
			}
		}
		goto IL_047e;
		IL_01ea:
		obj15 = typeof(DataRelation) + 712;
		object obj22 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v7+E4]");
		bool flag9 = (nint)0 == 0;
		object obj23 = !flag9;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		now = DateTime.Now;
		object obj24 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			timeSpan = TimeSpan.FromDays(16.00000000325963);
			object obj26 = (??)userAchievementModel.<lastUpdate>k__BackingField & 1;
			bool flag10 = obj26 == null;
			object obj27 = !flag10;
			double num = 16.00000000325963;
			if (obj27 != null)
			{
				goto IL_034c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			timeSpan = TimeSpan.FromDays(16.00000000325963);
			object obj28 = (??)userAchievementModel.<lastUpdate>k__BackingField & 1;
			bool flag11 = obj28 == null;
			double num = 16.00000000325963;
			if (!flag11)
			{
				goto IL_034c;
			}
		}
		goto IL_047e;
		IL_009f:
		obj13 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC96CC");
		bool flag12 = userAchievementModel == null;
		object obj29 = !flag12;
		func3 = func;
		if (obj29 != null)
		{
			goto IL_01ea;
		}
		goto IL_047e;
		IL_047e:
		result = null;
		goto IL_0517;
	}

	public void Update(User user)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_01b0: Expected I8, but got I4
		string text = SFSKammelnaUserExtensions.GetUserName(user);
		object obj = this + 16;
		obj = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string title = SFSKammelnaUserExtensions.GetTitle(user);
		object obj2 = this + 24;
		obj2 = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(user);
		int activePatternID = SFSKammelnaUserExtensions.GetActivePatternID(user);
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(user);
		<points>k__BackingField = rank.<Points>k__BackingField;
		TournamentRankingModel tournamentRankingModel = <tournamentRanking>k__BackingField;
		if (<tournamentRanking>k__BackingField != null)
		{
			int tournamentPoints = SFSKammelnaUserExtensions.GetTournamentPoints(user);
			tournamentRankingModel.<currentMonthPoints>k__BackingField = tournamentPoints;
			TournamentRankingModel tournamentRankingModel2 = <tournamentRanking>k__BackingField;
			MonthlyTournamentEligibilityType monthlyTournamentEligibility = SFSKammelnaUserExtensions.GetMonthlyTournamentEligibility(user);
			tournamentRankingModel2.<currentRankTier>k__BackingField = monthlyTournamentEligibility;
		}
		PlayerRank rank2 = SFSKammelnaUserExtensions.GetRank(user);
		<isNew>k__BackingField = rank2.<IsNew>k__BackingField;
		bool flag = SFSKammelnaUserExtensions.IsSubscribed(user);
		<isSubscribed>k__BackingField = flag;
		bool flag2 = SFSKammelnaUserExtensions.IsVerified(user);
		<isVerified>k__BackingField = flag2;
		DateTime? dateTime = SFSKammelnaUserExtensions.GetAvatarDate(user);
		<avatarDate>k__BackingField = dateTime;
		_ = 0;
		int num = SFSKammelnaUserExtensions.GetLikes(user);
		<likes>k__BackingField = num;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(user);
		<userDbId>k__BackingField = intDbId;
	}

	private bool <AchievementsCount>b__94_0(User u)
	{
		//IL_001c: Expected O, but got I8
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(u);
		object obj = <userDbId>k__BackingField - intDbId;
		return obj == null;
	}
}
