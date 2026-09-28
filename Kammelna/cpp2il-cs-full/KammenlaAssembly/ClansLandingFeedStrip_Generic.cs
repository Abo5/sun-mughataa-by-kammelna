using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Properties;

public class ClansLandingFeedStrip_Generic : ClansLandingFeedStrip
{
	private const string CLAN_CREATED_KEY = "clan_feed_clan_created";

	private const string MEMBERS_MILESTONE_KEY = "clan_feed_members_milestone";

	private const string CLAN_UPGRADED_KEY = "clan_feed_clan_upgraded";

	private const string EMBLEM_UPGRADED_KEY = "clan_feed_emblem_upgraded";

	private const string SEASON_CHAMPION_KEY = "clan_feed_season_champion";

	private const string MONTHLY_TOURNAMENT_WIN_KEY = "clan_feed_monthly_tournament_win";

	private const string TOP_LEADERBOARD_KEY = "clan_feed_top_leaderboard";

	private const string LEVEL_ORDINAL_KEY = "ORDINAL_LEVELS";

	private ClanEmblemLoader emblemLoader;

	private TextMeshProUGUI summary;

	private DateTimeText timeAgo;

	public override void Initialize(ClanFeedModel model)
	{
		emblemLoader.Load(model.ClanId, model.Emblem);
		LocalizableText text = BuildSummary(model);
		TextMeshProExtensions.Localize(summary, text);
		timeAgo.SetDate(model.DateCreated);
	}

	private unsafe static LocalizableText BuildSummary(ClanFeedModel model)
	{
		//IL_0492: Expected O, but got Ref
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_011e: Expected O, but got I4
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01bb: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0258: Expected O, but got I4
		//IL_0152: Expected O, but got I
		//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c1: Expected O, but got Unknown
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Expected O, but got Unknown
		//IL_02f5: Expected O, but got I4
		//IL_01ef: Expected O, but got I
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected O, but got Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_0392: Expected O, but got I4
		//IL_028c: Expected O, but got I
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_042f: Expected O, but got I4
		//IL_0329: Expected O, but got I
		//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae5: Expected O, but got Unknown
		//IL_03c6: Expected O, but got I
		//IL_0d29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2e: Expected O, but got Unknown
		//IL_0527: Expected I, but got O
		//IL_0463: Expected O, but got I
		//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da7: Expected O, but got Unknown
		//IL_072f: Expected I, but got O
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got Unknown
		//IL_05b3: Expected O, but got I
		//IL_0fe4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe9: Expected O, but got Unknown
		//IL_0932: Expected I, but got O
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Expected O, but got Unknown
		//IL_0652: Expected O, but got I8
		//IL_0d81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d86: Expected O, but got Unknown
		//IL_0b48: Expected I, but got O
		//IL_09a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ae: Expected O, but got Unknown
		//IL_09ce: Expected O, but got I4
		//IL_09dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Expected O, but got Unknown
		//IL_09f8: Expected O, but got I
		//IL_07e9: Expected I, but got O
		//IL_05f7: Expected I, but got O
		//IL_0bbf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc4: Expected O, but got Unknown
		//IL_0e35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3a: Expected O, but got Unknown
		//IL_0e4a: Expected O, but got I
		//IL_0e6c: Expected O, but got I4
		//IL_085a: Expected O, but got I8
		//IL_0680: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected O, but got Unknown
		//IL_0e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e18: Expected O, but got Unknown
		//IL_111f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1124: Expected O, but got Unknown
		//IL_114e: Expected O, but got I4
		//IL_0a8c: Expected O, but got I4
		//IL_0a95: Expected O, but got I4
		//IL_0a1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Expected O, but got Unknown
		//IL_07ff: Expected I, but got O
		//IL_0bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfe: Expected O, but got Unknown
		//IL_0f01: Expected I, but got O
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Expected O, but got Unknown
		//IL_08a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Expected O, but got Unknown
		//IL_107c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1081: Expected O, but got Unknown
		//IL_0cb0: Expected O, but got I8
		//IL_0cc8: Expected O, but got I4
		//IL_0ab4: Expected O, but got I4
		//IL_0ec2: Expected O, but got I4
		//IL_0ed3: Expected O, but got I4
		//IL_0c4c: Expected I, but got O
		//IL_0c7e: Expected O, but got I4
		//IL_0f6c: Expected O, but got I8
		//IL_0ce7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cec: Expected O, but got Unknown
		//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d0d: Expected O, but got Unknown
		//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa7: Expected O, but got Unknown
		//IL_0fc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Expected O, but got Unknown
		object text;
		object[] arguments;
		object text3;
		object[] arguments2;
		object[] array3 = default(object[]);
		object obj29;
		string text5;
		object obj34;
		nint num20;
		string text6;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		object obj33;
		nint num4;
		if (model != null)
		{
			ClanFeedData clanFeedData = model.Data;
			if (model.Data != null)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1160;
				object obj2 = obj;
				nint num = (nint)clanFeedData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v13 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X10_v5+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v13 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X10_v5+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X11_v30-8]");
					if (0 == (nint)obj2)
					{
						object obj6 = typeof(TypeConverter<ushort, char>) + 3400;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						object[] array = default(object[]);
						bool flag2 = array == null;
						num4 = 2;
						if (flag2)
						{
							goto IL_108e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+20]");
						bool flag3 = (nint)0 == 0;
						nint num5 = 2;
						if (!flag3)
						{
							nint num6 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v87 (Il2CppClass<System.Object[]>)+40]");
							num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag4 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v87 (Il2CppClass<System.Object[]>)+40]");
							num4 = 0;
							if (flag4)
							{
								goto IL_10aa;
							}
						}
						bool flag5 = array.Length == 0;
						num4 = num5;
						if (!flag5)
						{
							object obj7 = array + 32;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+20]");
							obj7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							bool flag6 = model.ClanName == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+20]");
							nint num7 = 0;
							if (!flag6)
							{
								nint num8 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v86 (Il2CppClass<System.Object[]>)+40]");
								num7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag7 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v86 (Il2CppClass<System.Object[]>)+40]");
								num4 = 0;
								if (flag7)
								{
									goto IL_10aa;
								}
							}
							object obj8 = array.Length & 0xFFFFFFFEL;
							bool flag8 = obj8 == null;
							num4 = num7;
							if (!flag8)
							{
								object obj9 = array + 40;
								obj9 = model.ClanName;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3544;
								arguments = array;
								goto IL_10e4;
							}
						}
						goto IL_109c;
					}
				}
				object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1344;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v13 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X10_v9+130]");
				bool flag9 = num9 < 0;
				object obj12 = !flag9;
				object obj13 = ~obj12;
				int num13 = default(int);
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v13 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X10_v9+130]");
					object obj14 = num10 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v427 @ X11_v28-8]");
					if (0 == (nint)obj11)
					{
						object obj15 = typeof(TypeConverter<ushort, char>) + 3400;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						object[] array2 = default(object[]);
						bool flag10 = array2 == null;
						num4 = 2;
						if (flag10)
						{
							goto IL_108e;
						}
						bool flag11 = model.ClanName == null;
						nint num11 = 2;
						if (!flag11)
						{
							nint num12 = (nint)array2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v77 (Il2CppClass<System.Object[]>)+40]");
							num11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag12 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v77 (Il2CppClass<System.Object[]>)+40]");
							num4 = 0;
							if (flag12)
							{
								goto IL_10aa;
							}
						}
						bool flag13 = array2.Length == 0;
						num4 = num11;
						if (!flag13)
						{
							object obj16 = array2 + 32;
							obj16 = model.ClanName;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							string text2 = num13.ToString();
							bool flag14 = text2 == null;
							nint num14 = unchecked((nint)null);
							if (!flag14)
							{
								nint num15 = (nint)array2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v76 (Il2CppClass<System.Object[]>)+40]");
								num14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag15 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v76 (Il2CppClass<System.Object[]>)+40]");
								num4 = 0;
								if (flag15)
								{
									goto IL_10aa;
								}
							}
							object obj17 = array2.Length & 0xFFFFFFFEL;
							bool flag16 = obj17 == null;
							num4 = num14;
							if (!flag16)
							{
								object obj18 = array2 + 40;
								obj18 = text2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								text3 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3576;
								arguments2 = array2;
								goto IL_10fa;
							}
						}
						goto IL_109c;
					}
				}
				object obj19 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1384;
				object obj20 = obj19;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v13 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
				nint num16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X10_v13+130]");
				bool flag17 = num16 < 0;
				object obj21 = !flag17;
				object obj22 = ~obj21;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v13 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
					nint num17 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X10_v13+130]");
					object obj23 = num17 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X11_v26-8]");
					if (0 == (nint)obj20)
					{
						object obj24 = typeof(TypeConverter<ushort, char>) + 3400;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						bool flag18 = array3 == null;
						num4 = 2;
						if (flag18)
						{
							goto IL_108e;
						}
						bool flag19 = model.ClanName == null;
						nint num18 = 2;
						if (!flag19)
						{
							nint num19 = (nint)array3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v66 (Il2CppClass<System.Object[]>)+40]");
							num18 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag20 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v66 (Il2CppClass<System.Object[]>)+40]");
							num4 = 0;
							if (flag20)
							{
								goto IL_10aa;
							}
						}
						bool flag21 = array3.Length == 0;
						num4 = num18;
						if (!flag21)
						{
							object obj25 = array3 + 32;
							obj25 = model.ClanName;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj26 = 152993792;
							object obj27 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E86E9]");
							object obj28 = (nint)0 & (nint)1;
							object obj31;
							if (obj28 != null)
							{
								obj29 = "Network Authentication Required" + 3280;
								object obj30 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X0_v86+E4]");
								bool flag22 = (nint)0 == 0;
								obj31 = obj29;
								if (!flag22)
								{
									goto IL_0a59;
								}
							}
							else
							{
								_ = 1;
								obj29 = "Network Authentication Required" + 3280;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8000]");
								object obj30 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X0_v86+E4]");
								bool flag23 = (nint)0 == 0;
								object obj32 = !flag23;
								obj31 = obj29;
								if (obj32 != null)
								{
									goto IL_0a59;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							object input = obj31;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
							string text4 = LocalizationUtil.LocalizeOrdinal((string)input, 0);
							bool flag24 = text4 == null;
							obj33 = 0;
							text5 = text4;
							obj34 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
							num20 = 0;
							text6 = text4;
							if (!flag24)
							{
								goto IL_0ef9;
							}
							goto IL_0f58;
						}
						goto IL_109c;
					}
				}
				object obj35 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1392;
				object obj36 = obj35;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v13 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
				nint num21 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X10_v16+130]");
				bool flag25 = num21 < 0;
				object obj37 = !flag25;
				object obj38 = ~obj37;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v13 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
					nint num22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X10_v16+130]");
					object obj39 = num22 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X11_v24-8]");
					if (0 == (nint)obj36)
					{
						object obj40 = typeof(TypeConverter<ushort, char>) + 3400;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						object[] array4 = default(object[]);
						bool flag26 = array4 == null;
						num4 = 2;
						if (flag26)
						{
							goto IL_108e;
						}
						bool flag27 = model.ClanName == null;
						nint num23 = 2;
						if (!flag27)
						{
							nint num24 = (nint)array4;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v49 (Il2CppClass<System.Object[]>)+40]");
							num23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag28 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v49 (Il2CppClass<System.Object[]>)+40]");
							num4 = 0;
							if (flag28)
							{
								goto IL_10aa;
							}
						}
						bool flag29 = array4.Length == 0;
						num4 = num23;
						if (!flag29)
						{
							object obj41 = array4 + 32;
							obj41 = model.ClanName;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj42 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
							object obj43 = obj42;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v805 @ X0_v54+E4]");
							bool flag30 = (nint)0 == 0;
							object obj44 = !flag30;
							if (obj44 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object input2 = "Network Authentication Required" + 3280;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
							string text7 = LocalizationUtil.LocalizeOrdinal((string)input2, 0);
							bool flag31 = text7 == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
							nint num25 = 0;
							if (!flag31)
							{
								nint num26 = (nint)array4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
								num25 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag32 = ex == null;
								obj33 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
								num4 = 0;
								if (flag32)
								{
									goto IL_10aa;
								}
							}
							object obj45 = array4.Length & 0xFFFFFFFEL;
							bool flag33 = obj45 == null;
							obj33 = 0;
							num4 = num25;
							if (!flag33)
							{
								object obj46 = array4 + 40;
								obj46 = text7;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3560;
								arguments = array4;
								goto IL_10e4;
							}
						}
						goto IL_109c;
					}
				}
				object obj47 = typeof(RegisteredWaitHandle) + 3304;
				object obj48 = obj47;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v13 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
				nint num27 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X10_v19+130]");
				bool flag34 = num27 < 0;
				object obj49 = !flag34;
				object obj50 = ~obj49;
				if (obj50 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v13 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
					nint num28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X10_v19+130]");
					object obj51 = num28 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X11_v22-8]");
					if (0 == (nint)obj48)
					{
						object obj52 = typeof(TypeConverter<ushort, char>) + 3400;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						object[] array5 = default(object[]);
						bool flag35 = array5 == null;
						num4 = 1;
						if (flag35)
						{
							goto IL_108e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9ABFC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
						text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3600;
						arguments = array5;
						goto IL_10e4;
					}
				}
				object obj53 = typeof(MemberAchievementClanFeedData) + 152;
				object obj54 = obj53;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v13 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
				nint num29 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v22+130]");
				bool flag36 = num29 < 0;
				object obj55 = !flag36;
				object obj56 = ~obj55;
				if (obj56 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v13 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
					nint num30 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X10_v22+130]");
					object obj57 = num30 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X11_v20-8]");
					if (0 == (nint)obj54)
					{
						object obj58 = typeof(TypeConverter<ushort, char>) + 3400;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						object[] array6 = default(object[]);
						bool flag37 = array6 == null;
						num4 = 2;
						if (flag37)
						{
							goto IL_108e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9ABFC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9ABFC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
						text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3584;
						arguments = array6;
						goto IL_10e4;
					}
				}
				object obj59 = typeof(MemberAchievementClanFeedData) + 120;
				object obj60 = obj59;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v13 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
				nint num31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X10_v25+130]");
				bool flag38 = num31 < 0;
				object obj61 = !flag38;
				object obj62 = ~obj61;
				if (obj62 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v13 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
					nint num32 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X10_v25+130]");
					object obj63 = num32 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v17-8]");
					if (0 == (nint)obj60)
					{
						object obj64 = typeof(TypeConverter<ushort, char>) + 3400;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						object[] array7 = default(object[]);
						bool flag39 = array7 == null;
						num4 = 3;
						if (flag39)
						{
							goto IL_108e;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9ABFC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9ABFC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
						string text8 = num13.ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9ABFC");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9AC34");
						text3 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3616;
						arguments2 = array7;
						goto IL_10fa;
					}
				}
			}
			object obj65 = default(object);
			string text9 = ((Enum)(&obj65)).ToString();
			return TextMeshProExtensions.FixOnly(text9);
		}
		goto IL_108e;
		IL_10aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (LocalizableText)(object)new OutOfMemoryException();
		IL_108e:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_109c;
		IL_0ef9:
		nint num33 = (nint)array3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v60 (Il2CppClass<System.Object[]>)+40]");
		num20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag40 = ex == null;
		obj34 = obj33;
		text6 = text5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v60 (Il2CppClass<System.Object[]>)+40]");
		num4 = 0;
		if (!flag40)
		{
			goto IL_0f58;
		}
		goto IL_10aa;
		IL_109c:
		ex = new IndexOutOfRangeException();
		goto IL_10aa;
		IL_0f58:
		object obj66 = array3.Length & 0xFFFFFFFEL;
		bool flag41 = obj66 == null;
		obj33 = obj34;
		num4 = num20;
		if (flag41)
		{
			goto IL_109c;
		}
		object obj67 = array3 + 40;
		obj67 = text6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		text = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3552;
		arguments = array3;
		goto IL_10e4;
		IL_0a59:
		object input3 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
		string text10 = LocalizationUtil.LocalizeOrdinal((string)input3, 0);
		bool flag42 = text10 == null;
		object obj68 = !flag42;
		obj33 = 0;
		text5 = text10;
		if (obj68 != null)
		{
			goto IL_0ef9;
		}
		obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+14]");
		num20 = 0;
		text6 = text10;
		goto IL_0f58;
		IL_10e4:
		return TextMeshProExtensions.LocalizeWith((string)text, arguments);
		IL_10fa:
		return TextMeshProExtensions.LocalizeWith((string)text3, arguments2);
	}

	private static string Level(int tier)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		object input = "Network Authentication Required" + 3280;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return LocalizationUtil.LocalizeOrdinal((string)input, tier);
	}

	public ClansLandingFeedStrip_Generic()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
