using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;

public class LeaderBoardPlayer
{
	private const string ID = "id";

	private const string LAST_POINTS = "lpt";

	private const string GAME_POINTS = "gpt";

	private const string LAST_RANK = "lrk";

	private const string SECOND_LAST_RANK = "srk";

	private const string RANK_TIER = "te";

	private const string MONTHLY_WIN_TIER = "mwt";

	private const string LOGIN = "l";

	private const string IS_SUBSCRIBED = "is";

	private const string IS_VERIFIED = "iv";

	private const string CARD_ID = "crd";

	private const string TITLE_ID = "ttl";

	private const string AVATAR_TIMESTAMP = "ad";

	public int LastPoints;

	public int LastRank;

	public int SecondLastRank;

	public bool IsOverall;

	public int RankTier;

	public int? MonthlyWinningTier;

	public int Id;

	public string Login;

	public int Points;

	public int CardId;

	public string TitleId;

	public bool IsSubscribed;

	public bool IsVerified;

	public DateTime? AvatarDate;

	public string ClanRoleTitle;

	public bool IsClanOwner;

	public LeaderBoardPlayer()
	{
	}

	public LeaderBoardPlayer(User user)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(user);
		Id = intDbId;
		string userName = SFSKammelnaUserExtensions.GetUserName(user);
		object obj = this + 48;
		obj = userName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PlayerRank rank = SFSKammelnaUserExtensions.GetRank(user);
		Points = rank.<Points>k__BackingField;
		int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(user);
		CardId = activeCardbackID;
		string title = SFSKammelnaUserExtensions.GetTitle(user);
		object obj2 = this + 64;
		obj2 = title;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = SFSKammelnaUserExtensions.IsSubscribed(user);
		bool flag2 = SFSKammelnaUserExtensions.IsVerified(user);
		DateTime? avatarDate = SFSKammelnaUserExtensions.GetAvatarDate(user);
		_ = 0;
	}

	public static LeaderBoardPlayer FromSfsObject(ISFSObject data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0115: Expected I, but got O
		//IL_0125: Expected O, but got I
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03ab: Expected O, but got I
		//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ba: Expected O, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c9: Expected O, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_0160: Expected O, but got I
		//IL_021d: Expected O, but got I4
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_030e: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1696;
		object varName = "java.io.FileOutputStream" + 3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		int num = SFSExtensions.Get(data, (string)varName, 0);
		object varName5;
		if (obj2 != null)
		{
			object varName2 = "java.io.FileOutputStream" + 3440;
			object varName3 = "setMimeType" + 3776;
			object varName4 = "startPosition" + 2416;
			int num2 = SFSExtensions.Get(data, (string)varName2, 0);
			int num3 = SFSExtensions.Get(data, (string)varName3, 0);
			int num4 = SFSExtensions.Get(data, (string)varName4, 0);
			if (data != null)
			{
				object obj3 = typeof(System.IOAsyncCallback) + 976;
				varName5 = "m_StencilDeferredPS" + 2832;
				nint num5 = (nint)data;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01a1;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
				object obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X10_v5-8]");
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
					goto IL_01a1;
				}
				object obj6 = obj5 + 1;
				object obj7 = num5 + obj6;
				object obj8 = obj7 + 312;
				goto IL_0381;
			}
		}
		return (LeaderBoardPlayer)(object)new NullReferenceException();
		IL_01a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0381;
		IL_0381:
		object varName6 = "https://www.kammelna.com/Home/Terms" + 328;
		object varName7 = "java.io.FileOutputStream" + 1008;
		object defaultValue = (nint)0 + (nint)2000;
		object varName8 = "getSecondRescanTask" + 1824;
		object varName9 = "https://www.kammelna.com/Home/Terms" + 2392;
		object varName10 = "https://www.kammelna.com/Home/Terms" + 4016;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v275 @ X0_v14] (should have been resolved before IL gen)");
		object obj9 = default(object);
		if (obj9 != null)
		{
			int value = SFSExtensions.Get(data, (string)varName5, 0);
			int? num6 = value;
			int? num7 = num6;
		}
		else
		{
			int? num7 = (int?)(object)0;
		}
		int num8 = SFSExtensions.Get(data, (string)varName6, 0);
		string text = SFSExtensions.Get(data, (string)varName7, (string)defaultValue);
		object obj10 = obj2 + 48;
		obj10 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int num9 = SFSExtensions.Get(data, (string)varName8, 0);
		bool flag = SFSExtensions.Get(data, (string)varName9, defaultValue: false);
		bool flag2 = SFSExtensions.Get(data, (string)varName10, defaultValue: false);
		object varName11 = "com.unity.services.authentication.profile" + 1816;
		int num10 = SFSExtensions.Get(data, (string)varName11, 0);
		object varName12 = "tournament_participate_warning_body_with_tickets_warning_daily" + 824;
		string text2 = SFSExtensions.Get(data, (string)varName12, (string)null);
		object obj11 = obj2 + 64;
		obj11 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object varName13 = "___# Content push apply failed [{0}]: {1}" + 3224;
		DateTime? dateTime = SFSExtensions.Get(data, (string)varName13, (DateTime?)(object)0);
		return (LeaderBoardPlayer)obj2;
	}
}
