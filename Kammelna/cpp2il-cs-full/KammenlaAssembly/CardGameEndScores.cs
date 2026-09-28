using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Server.Models;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Purchasing.Telemetry;

public class CardGameEndScores
{
	private static class Constants
	{
		public const string CustomGameResult = "cgr";
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<string, GameAchievementViewModel> <>9__88_0;

		public static Func<GameAchievementViewModel, bool> <>9__88_1;

		public static Func<GameAchievementViewModel, string> <>9__104_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3952;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal GameAchievementViewModel <get_Achievements>b__88_0(string id)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_0077: Expected O, but got I4
			//IL_00c6: Expected O, but got I
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			//IL_00e6: Expected O, but got I
			//IL_0114: Expected I, but got O
			object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3960;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			if (obj2 != null)
			{
				object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
				object obj4 = obj2 + 16;
				obj4 = id;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj5 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = !flag;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CachedModel<List<GameAchievementViewModel>> achievements = CachedModels.Achievements;
				if (achievements != null)
				{
					object obj7 = (nint)0 + (nint)400;
					object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1248;
					object obj9 = (nint)0 + (nint)2440;
					object model = ((CachedModel<object>)(object)achievements).Model;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor(obj2, (IntPtr)obj9);
					return (GameAchievementViewModel)Enumerable.FirstOrDefault((IEnumerable<object>)model, func);
				}
			}
			return (GameAchievementViewModel)(object)new NullReferenceException();
		}

		internal bool <get_Achievements>b__88_1(GameAchievementViewModel model)
		{
			bool flag = model == null;
			return !flag;
		}

		internal string <TestPopulate>b__104_0(GameAchievementViewModel a)
		{
			if (a != null)
			{
				return a.<id>k__BackingField;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass88_0
	{
		public string id;

		internal bool <get_Achievements>b__2(GameAchievementViewModel model)
		{
			//IL_0048: Expected I4, but got O
			if (model != null)
			{
				return model.<id>k__BackingField == id;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public const string C_Team1Score = "ts1";

	public const string C_Team2Score = "ts2";

	public const string C_PreviousPoints = "pp";

	public const string C_CurrentPoints = "cp";

	public const string C_GamePoints = "gp";

	public const string C_WinnerTeamIndex = "winner";

	public const string GainedAchievements = "aa";

	public const string C_BonusPercentage = "sp";

	public const string C_TeammatePoints = "tm_pts";

	public const string C_Opponent1Points = "opo1_pts";

	public const string C_Opponent2Points = "opo2_pts";

	public const string C_BalancedGame = "bg";

	public const string PlayStyle = "ps";

	public const string CheatingLevel = "cl";

	public const string Overall = "oa";

	private const string MatchWinnerIndex = "mw";

	private bool <BalancedGame>k__BackingField;

	private int <Team1Score>k__BackingField;

	private int <Team2Score>k__BackingField;

	private int <TeammatePoints>k__BackingField;

	private int <Opponent1Points>k__BackingField;

	private int <Opponent2Points>k__BackingField;

	private int <PreviousPoints>k__BackingField;

	private int <CurrentPoints>k__BackingField;

	private int <GamePoints>k__BackingField;

	private int <WinnerTeamIndex>k__BackingField;

	private int <BonusPercentage>k__BackingField;

	private PlayerPerformance <PlayStylePerformance>k__BackingField;

	private CheatingPerformance <CheatingPerformance>k__BackingField;

	private PlayerPerformance <OverallPerformance>k__BackingField;

	private CardGameStatistics <CGStatistics>k__BackingField;

	private CardGameHighlights <CGHighlights>k__BackingField;

	private List<string> <AchievementIDs>k__BackingField;

	private TournamentEndGameReport <tournamentReport>k__BackingField;

	private TournamentExtraGameResult <TournamentGameResult>k__BackingField;

	private FriendlyChallengeExtraGameResult <FriendlyChallengeGameResult>k__BackingField;

	public bool BalancedGame
	{
		get
		{
			return <BalancedGame>k__BackingField;
		}
		private set
		{
			<BalancedGame>k__BackingField = value;
		}
	}

	public int Team1Score
	{
		get
		{
			return <Team1Score>k__BackingField;
		}
		private set
		{
			<Team1Score>k__BackingField = value;
		}
	}

	public int Team2Score
	{
		get
		{
			return <Team2Score>k__BackingField;
		}
		private set
		{
			<Team2Score>k__BackingField = value;
		}
	}

	public int TeammatePoints
	{
		get
		{
			return <TeammatePoints>k__BackingField;
		}
		private set
		{
			<TeammatePoints>k__BackingField = value;
		}
	}

	public int Opponent1Points
	{
		get
		{
			return <Opponent1Points>k__BackingField;
		}
		private set
		{
			<Opponent1Points>k__BackingField = value;
		}
	}

	public int Opponent2Points
	{
		get
		{
			return <Opponent2Points>k__BackingField;
		}
		private set
		{
			<Opponent2Points>k__BackingField = value;
		}
	}

	public int PreviousPoints
	{
		get
		{
			return <PreviousPoints>k__BackingField;
		}
		private set
		{
			<PreviousPoints>k__BackingField = value;
		}
	}

	public int CurrentPoints
	{
		get
		{
			return <CurrentPoints>k__BackingField;
		}
		private set
		{
			<CurrentPoints>k__BackingField = value;
		}
	}

	public int GamePoints
	{
		get
		{
			return <GamePoints>k__BackingField;
		}
		private set
		{
			<GamePoints>k__BackingField = value;
		}
	}

	public int WinnerTeamIndex
	{
		get
		{
			return <WinnerTeamIndex>k__BackingField;
		}
		private set
		{
			<WinnerTeamIndex>k__BackingField = value;
		}
	}

	public int BonusPercentage
	{
		get
		{
			return <BonusPercentage>k__BackingField;
		}
		private set
		{
			<BonusPercentage>k__BackingField = value;
		}
	}

	public int BonusPoints
	{
		get
		{
			//IL_004d: Invalid comparison between F8 and I4
			//IL_007e: Expected I4, but got F8
			//IL_0071: Expected I4, but got I8
			int num = <BonusPercentage>k__BackingField / 1120403456;
			double num2 = (double)num + 1.0;
			double num3 = (double)num / num2;
			double num4 = num3 * (double)<GamePoints>k__BackingField;
			if (num4 == 2139095040.0)
			{
				return -2147483648;
			}
			return (int)num4;
		}
	}

	public PlayerPerformance PlayStylePerformance
	{
		get
		{
			return <PlayStylePerformance>k__BackingField;
		}
		private set
		{
			<PlayStylePerformance>k__BackingField = value;
		}
	}

	public CheatingPerformance CheatingPerformance
	{
		get
		{
			return <CheatingPerformance>k__BackingField;
		}
		private set
		{
			<CheatingPerformance>k__BackingField = value;
		}
	}

	public PlayerPerformance OverallPerformance
	{
		get
		{
			return <OverallPerformance>k__BackingField;
		}
		private set
		{
			<OverallPerformance>k__BackingField = value;
		}
	}

	public CardGameStatistics CGStatistics
	{
		get
		{
			return <CGStatistics>k__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 72;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public CardGameHighlights CGHighlights
	{
		get
		{
			return <CGHighlights>k__BackingField;
		}
		internal set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<string> AchievementIDs
	{
		get
		{
			return <AchievementIDs>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 88;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<GameAchievementViewModel> Achievements
	{
		get
		{
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Expected O, but got Unknown
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00cd: Expected O, but got I
			//IL_00dd: Expected O, but got I
			//IL_00ed: Expected O, but got I
			//IL_010f: Expected O, but got I4
			//IL_01b9: Expected O, but got I4
			//IL_0052: Expected O, but got I
			//IL_0062: Expected O, but got I
			//IL_0072: Expected O, but got I
			//IL_0094: Expected O, but got I4
			//IL_0360: Expected O, but got I
			//IL_036c: Expected O, but got I
			//IL_037c: Expected O, but got I
			//IL_038c: Expected O, but got I
			//IL_03ae: Expected O, but got I4
			//IL_0147: Expected O, but got I4
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_02df: Expected O, but got Unknown
			//IL_02f5: Expected O, but got I
			//IL_0306: Expected I, but got O
			//IL_0324: Expected O, but got I
			//IL_033f: Expected O, but got I4
			//IL_0200: Expected O, but got I4
			//IL_0177: Expected O, but got I
			//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d0: Expected O, but got Unknown
			//IL_03e6: Expected O, but got I
			//IL_03f7: Expected I, but got O
			//IL_0415: Expected O, but got I
			//IL_0430: Expected O, but got I4
			//IL_0230: Expected O, but got I
			object obj;
			object obj4;
			Func<object, object> selector;
			object obj6;
			object obj3;
			if (<AchievementIDs>k__BackingField != null)
			{
				obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3952;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v25+E4]");
				if ((nint)0 != 0)
				{
					obj3 = (nint)0 + (nint)32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v25+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v20+8]");
					selector = (Func<object, object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v20+8]");
					bool flag = (nint)0 == 0;
					object obj5 = !flag;
					if (obj5 == null)
					{
						obj6 = obj3;
						goto IL_0125;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj2 = obj;
					obj6 = (nint)0 + (nint)32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v25+B8]");
					obj4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v20+8]");
					selector = (Func<object, object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v20+8]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					obj3 = obj6;
					if (obj7 == null)
					{
						goto IL_0125;
					}
				}
				goto IL_017c;
			}
			goto IL_027a;
			IL_017c:
			IEnumerable<object> source = Enumerable.Select(<AchievementIDs>k__BackingField, selector);
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj;
			}
			object obj10 = (nint)0 + (nint)3440;
			object obj11 = (nint)0 + (nint)2088;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v11+B8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v11+10]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v11+10]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			object obj20;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v11+E4]");
				bool flag5 = (nint)0 == 0;
				object obj14 = !flag5;
				if (obj14 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj15 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v17+B8]");
					obj12 = 0;
				}
				object obj16 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1248;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj17 = (nint)0 + (nint)2432;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj12, (IntPtr)obj17);
				object obj18 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v218 @ X8_v16+B8]");
				object obj19 = (nint)0 + (nint)16;
				obj19 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj20 = 0;
				predicate = func;
			}
			IEnumerable<object> source2 = Enumerable.Where(source, predicate);
			List<GameAchievementViewModel> list = (List<GameAchievementViewModel>)(object)Enumerable.ToList(source2);
			if (list != null)
			{
				return list;
			}
			goto IL_027a;
			IL_027a:
			object obj21 = typeof(List<AdaptivePerformanceScaler>) + 1152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list2 = default(List<object>);
			list2..ctor();
			return (List<GameAchievementViewModel>)(object)list2;
			IL_0125:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v25+E4]");
			bool flag6 = (nint)0 == 0;
			object obj22 = !flag6;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj23 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v26+B8]");
				obj4 = 0;
			}
			object obj24 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj25 = (nint)0 + (nint)2424;
			Func<object, object> func2 = default(Func<object, object>);
			func2..ctor(obj4, (IntPtr)obj25);
			object obj26 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v25+B8]");
			object obj27 = (nint)0 + (nint)8;
			obj27 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj20 = 0;
			obj3 = obj6;
			selector = func2;
			goto IL_017c;
		}
	}

	public TournamentEndGameReport tournamentReport
	{
		get
		{
			return <tournamentReport>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 96;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public TournamentExtraGameResult TournamentGameResult
	{
		get
		{
			return <TournamentGameResult>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 104;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public FriendlyChallengeExtraGameResult FriendlyChallengeGameResult
	{
		get
		{
			return <FriendlyChallengeGameResult>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 112;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	protected virtual void SetCardGameEndScores(ISFSObject data, GameType gameType)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_007c: Expected O, but got I
		//IL_0126: Expected O, but got I4
		//IL_01a3: Expected I, but got O
		//IL_01b3: Expected O, but got I
		//IL_00b7: Expected O, but got I
		//IL_013d: Expected O, but got I4
		//IL_0c68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c6d: Expected O, but got Unknown
		//IL_0c97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c9c: Expected O, but got Unknown
		//IL_0cc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccb: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected O, but got Unknown
		//IL_062c: Expected I, but got O
		//IL_063c: Expected O, but got I
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_018d: Expected O, but got I4
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_06d2: Expected O, but got I
		//IL_0703: Expected O, but got I
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Expected O, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		//IL_0677: Expected O, but got I
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034b: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_0386: Expected O, but got I
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d3d: Expected O, but got Unknown
		//IL_0d45: Expected I, but got O
		//IL_0d55: Expected O, but got I
		//IL_0720: Unknown result type (might be due to invalid IL or missing references)
		//IL_0725: Expected O, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_03ba: Expected O, but got I
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		//IL_08fd: Expected O, but got I4
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected O, but got Unknown
		//IL_07d0: Expected O, but got I4
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected O, but got Unknown
		//IL_0767: Expected O, but got I4
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Expected O, but got Unknown
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected O, but got Unknown
		//IL_0934: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Expected O, but got Unknown
		//IL_0949: Expected O, but got I
		//IL_096d: Expected O, but got I4
		//IL_09f0: Expected I, but got O
		//IL_0a00: Expected O, but got I
		//IL_088e: Expected O, but got I
		//IL_07f9: Expected O, but got I
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected O, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected O, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_041a: Expected I, but got O
		//IL_042a: Expected O, but got I
		//IL_0993: Expected O, but got I
		//IL_04c0: Expected O, but got I
		//IL_04e4: Expected O, but got I4
		//IL_0a3b: Expected O, but got I
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a6: Expected O, but got Unknown
		//IL_09ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b3: Expected O, but got Unknown
		//IL_09bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Expected O, but got Unknown
		//IL_0465: Expected O, but got I
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3d: Expected O, but got Unknown
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a1: Expected O, but got Unknown
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected O, but got Unknown
		//IL_0b8f: Expected O, but got I4
		//IL_0503: Expected O, but got I
		//IL_0b62: Expected O, but got I4
		//IL_0b6b: Expected O, but got I4
		//IL_0a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a99: Expected O, but got Unknown
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa6: Expected O, but got Unknown
		//IL_0aaf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Expected O, but got Unknown
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected O, but got Unknown
		//IL_05b9: Expected O, but got I
		//IL_0516: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_0523: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected O, but got Unknown
		//IL_0546: Expected O, but got I
		//IL_0570: Expected O, but got I
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4e: Expected O, but got Unknown
		//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5c: Expected O, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Expected O, but got Unknown
		//IL_0b12: Expected O, but got I4
		//IL_0b1b: Expected O, but got I4
		object varName = "utf-32" + 1520;
		object varName2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 736;
		object varName3 = "tournament_participate_warning_body_with_tickets_warning_daily" + 760;
		int num = SFSExtensions.Get(data, (string)varName, 0);
		<WinnerTeamIndex>k__BackingField = num;
		int num2 = SFSExtensions.Get(data, (string)varName2, 0);
		<Team1Score>k__BackingField = num2;
		int num3 = SFSExtensions.Get(data, (string)varName3, 0);
		<Team2Score>k__BackingField = num3;
		object obj = typeof(System.IOAsyncCallback) + 976;
		object obj2 = "placementId" + 2224;
		nint num4 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00f8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X10_v41-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 += 16;
			obj3--;
			if ((nint)obj3 != 1)
			{
				continue;
			}
			goto IL_00f8;
		}
		object obj5 = obj4 + 1;
		object obj6 = num4 + obj5;
		object obj7 = obj6 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v366 @ X0_v109] (should have been resolved before IL gen)");
		object obj8 = default(object);
		bool flag = obj8 == null;
		object obj9 = 0;
		if (!flag)
		{
			goto IL_019b;
		}
		goto IL_0615;
		IL_0dc2:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v898 @ X0_v17] (should have been resolved before IL gen)");
		ISFSObject gameResultData = default(ISFSObject);
		object obj12;
		switch (gameType)
		{
		case GameType.Tournament:
		{
			object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1544;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			TournamentExtraGameResult tournamentExtraGameResult = default(TournamentExtraGameResult);
			tournamentExtraGameResult..ctor(gameResultData);
			object obj11 = 0;
			obj12 = 104;
			FriendlyChallengeExtraGameResult friendlyChallengeExtraGameResult2 = (FriendlyChallengeExtraGameResult)(object)tournamentExtraGameResult;
			break;
		}
		default:
			return;
		case GameType.Challenge:
		{
			object obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			FriendlyChallengeExtraGameResult friendlyChallengeExtraGameResult = default(FriendlyChallengeExtraGameResult);
			friendlyChallengeExtraGameResult..ctor(gameResultData);
			object obj11 = 0;
			obj12 = 112;
			FriendlyChallengeExtraGameResult friendlyChallengeExtraGameResult2 = friendlyChallengeExtraGameResult;
			break;
		}
		}
		object obj14 = (object)this + obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_04a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ X0_v96+8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v990 @ X0_v96] (should have been resolved before IL gen)");
		ISFSArray iSFSArray = default(ISFSArray);
		bool flag2 = iSFSArray == null;
		object obj16 = !flag2;
		if (obj16 != null)
		{
			goto IL_0583;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v990 @ X0_v96+8]");
		object obj17 = 0;
		List<object> list = null;
		goto IL_05f3;
		IL_0583:
		List<string> list2 = SFSExtensions.ToStringList(iSFSArray);
		if (list2 != null)
		{
			object obj18 = (nint)0 + (nint)912;
			obj17 = obj18;
			IEnumerable<object> source = Enumerable.Take((IEnumerable<object>)list2, 4);
			List<object> list3 = Enumerable.ToList(source);
			list = list3;
		}
		else
		{
			bool flag3 = this == null;
			object obj19 = !flag3;
			obj17 = obj15;
			list = null;
			if (obj19 == null)
			{
				throw new NullReferenceException();
			}
		}
		goto IL_05f3;
		IL_08cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v702 @ X0_v31] (should have been resolved before IL gen)");
		object obj20 = default(object);
		bool flag4 = obj20 == null;
		object obj21 = !flag4;
		if (obj21 == null)
		{
			return;
		}
		goto IL_09e8;
		IL_00f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v245 @ X0_v106] (should have been resolved before IL gen)");
		object obj22 = default(object);
		bool flag5 = obj22 == null;
		object obj23 = !flag5;
		if (obj23 != null)
		{
			goto IL_019b;
		}
		obj9 = 0;
		goto IL_0615;
		IL_019b:
		nint num5 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v40 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v40 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_022f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v40 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X10_v36-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj25 += 16;
			obj24--;
			if ((nint)obj24 != 1)
			{
				continue;
			}
			goto IL_022f;
		}
		object obj26 = obj25 + 29;
		object obj27 = num5 + obj26;
		object obj28 = obj27 + 312;
		goto IL_0c54;
		IL_076c:
		if (GameTypeExtensions.IsFriendly(gameType))
		{
			object obj29 = typeof(Queue<string>) + 848;
			object obj30 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X0_v37+E4]");
			bool flag6 = (nint)0 == 0;
			object obj31 = !flag6;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj32 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser);
			<PreviousPoints>k__BackingField = rank.<Points>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			PlayerRank rank2 = SFSKammelnaUserExtensions.GetRank(localUser2);
			<CurrentPoints>k__BackingField = rank2.<Points>k__BackingField;
		}
		object obj33 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2704;
		nint num6 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_08cf;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v11 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj35 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v723 @ X10_v15-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj35 += 16;
			obj34--;
			if ((nint)obj34 != 1)
			{
				continue;
			}
			goto IL_08cf;
		}
		object obj36 = obj35 + 1;
		object obj37 = num6 + obj36;
		object obj38 = obj37 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v757 @ X0_v34] (should have been resolved before IL gen)");
		object obj39 = default(object);
		if (obj39 != null)
		{
			goto IL_09e8;
		}
		return;
		IL_06b8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v55+8]");
		object obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v500 @ X0_v55] (should have been resolved before IL gen)");
		object obj41 = default(object);
		bool flag7 = obj41 == null;
		object obj43;
		object obj42 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v55+8]");
		object obj44 = 0;
		if (!flag7)
		{
			goto IL_0711;
		}
		goto IL_076c;
		IL_0a7c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0dc2;
		IL_09e8:
		nint num7 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0a7c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v783 @ X8_v14 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj46 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v860 @ X10_v10-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj46 += 16;
			obj45--;
			if ((nint)obj45 != 1)
			{
				continue;
			}
			goto IL_0a7c;
		}
		object obj47 = obj46 + 29;
		object obj48 = num7 + obj47;
		object obj49 = obj48 + 312;
		goto IL_0dc2;
		IL_022f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0c54;
		IL_0c54:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v558 @ X0_v62] (should have been resolved before IL gen)");
		object varName4 = "placementId" + 512;
		ISFSObject iSFSObject = default(ISFSObject);
		int num8 = SFSExtensions.Get(iSFSObject, (string)varName4, 0);
		<PreviousPoints>k__BackingField = num8;
		object varName5 = "com.unity.services.authentication.profile" + 1504;
		int num9 = SFSExtensions.Get(iSFSObject, (string)varName5, 0);
		<CurrentPoints>k__BackingField = num9;
		object varName6 = "getSecondRescanTask" + 1808;
		int num10 = SFSExtensions.Get(iSFSObject, (string)varName6, 0);
		<GamePoints>k__BackingField = num10;
		object varName7 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 152;
		bool flag8 = SFSExtensions.Get(iSFSObject, (string)varName7, defaultValue: true);
		<BalancedGame>k__BackingField = flag8;
		object varName8 = "startPosition" + 3400;
		int num11 = SFSExtensions.Get(iSFSObject, (string)varName8, 0);
		<TeammatePoints>k__BackingField = num11;
		object varName9 = "not" + 1952;
		int num12 = SFSExtensions.Get(iSFSObject, (string)varName9, 0);
		<Opponent1Points>k__BackingField = num12;
		object varName10 = "not" + 1960;
		int num13 = SFSExtensions.Get(iSFSObject, (string)varName10, 0);
		<Opponent2Points>k__BackingField = num13;
		object varName11 = "setMimeType" + 3432;
		int num14 = SFSExtensions.Get(iSFSObject, (string)varName11, 0);
		<BonusPercentage>k__BackingField = num14;
		object obj50 = "placementId" + 1472;
		object obj51 = (nint)0 + (nint)144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		PlayerPerformance playerPerformance = default(PlayerPerformance);
		<PlayStylePerformance>k__BackingField = playerPerformance;
		object obj52 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3384;
		object obj53 = (nint)0 + (nint)72;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		CheatingPerformance cheatingPerformance = default(CheatingPerformance);
		<CheatingPerformance>k__BackingField = cheatingPerformance;
		object obj54 = "not" + 640;
		obj9 = obj51;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @301ECBC");
		PlayerPerformance playerPerformance2 = default(PlayerPerformance);
		<OverallPerformance>k__BackingField = playerPerformance2;
		object obj55 = "___# Content push apply failed [{0}]: {1}" + 2720;
		nint num15 = (nint)iSFSObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v69 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj56 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v69 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_04a6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v951 @ X8_v69 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj57 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X10_v31-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj57 += 16;
			obj56--;
			if ((nint)obj56 != 1)
			{
				continue;
			}
			goto IL_04a6;
		}
		object obj58 = obj57 + 28;
		object obj59 = num15 + obj58;
		object obj60 = obj59 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X0_v99+8]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1030 @ X0_v99] (should have been resolved before IL gen)");
		bool flag9 = iSFSArray == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X0_v99+8]");
		obj17 = 0;
		list = null;
		if (!flag9)
		{
			goto IL_0583;
		}
		goto IL_05f3;
		IL_05f3:
		object obj61 = this + 88;
		obj61 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_0615;
		IL_0711:
		object obj62 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1536;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentEndGameReport tournamentEndGameReport = default(TournamentEndGameReport);
		tournamentEndGameReport..ctor(data);
		object obj63 = this + 96;
		obj63 = tournamentEndGameReport;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj44 = 0;
		goto IL_076c;
		IL_0615:
		obj43 = "m_StencilDeferredPS" + 2816;
		nint num16 = (nint)data;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		object obj64 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_06b8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Data.ISFSObject>)+B0]");
		object obj65 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X10_v21-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj65 += 16;
			obj64--;
			if ((nint)obj64 != 1)
			{
				continue;
			}
			goto IL_06b8;
		}
		object obj66 = obj65 + 1;
		object obj67 = num16 + obj66;
		object obj68 = obj67 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X0_v58+8]");
		obj40 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v578 @ X0_v58] (should have been resolved before IL gen)");
		object obj69 = default(object);
		bool flag10 = obj69 == null;
		object obj70 = !flag10;
		obj42 = obj43;
		if (obj70 != null)
		{
			goto IL_0711;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X0_v58+8]");
		obj44 = 0;
		goto IL_076c;
	}

	public CardGameEndScores()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069DA8]");
		<PlayStylePerformance>k__BackingField = PlayerPerformance.Weak;
		<OverallPerformance>k__BackingField = PlayerPerformance.Good;
		base..ctor();
	}

	public CardGameEndScores(ISFSObject data, GameType gameType)
	{
		//IL_0028: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069DA8]");
		<PlayStylePerformance>k__BackingField = PlayerPerformance.Weak;
		<OverallPerformance>k__BackingField = PlayerPerformance.Good;
		base..ctor();
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v24 @ X8_v3 (Il2CppClass<CardGameEndScores>)+178] (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public unsafe virtual void TestPopulate(int team1Score, int team2Score, int previousPoints, int currentPoints, int highlightsCount, int testAchievementsCount, int streakPercentage, PlayerPerformance pPerf, CheatingPerformance cPerf, PlayerPerformance oPerf, TournamentEndGameReport tReport = null)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0688: Expected O, but got I4
		//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c0: Expected I4, but got Unknown
		//IL_06f5: Expected O, but got I4
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected O, but got Unknown
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Expected O, but got Unknown
		//IL_0785: Unknown result type (might be due to invalid IL or missing references)
		//IL_078a: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_00ce: Expected O, but got I
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_0461: Expected O, but got I
		//IL_046d: Expected O, but got I
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		//IL_04e9: Expected O, but got I4
		//IL_07ad: Expected O, but got I
		//IL_07be: Expected O, but got I
		//IL_07ce: Expected O, but got I
		//IL_07f0: Expected O, but got I4
		//IL_01b4: Expected O, but got I
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected I4, but got Unknown
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected O, but got Unknown
		//IL_060b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0610: Expected O, but got Unknown
		//IL_0620: Expected O, but got I
		//IL_05ba: Expected O, but got I4
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected O, but got Unknown
		//IL_0828: Expected O, but got I
		//IL_0839: Expected I, but got O
		//IL_0857: Expected O, but got I
		//IL_020f: Expected O, but got I
		//IL_0217: Expected I4, but got O
		//IL_0230: Expected O, but got I
		//IL_05ea: Expected O, but got I
		//IL_029e: Expected O, but got I4
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected I4, but got Unknown
		//IL_030c: Expected I4, but got O
		//IL_0325: Expected O, but got I
		//IL_038b: Expected O, but got I8
		//IL_03a5: Expected O, but got I4
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected I4, but got Unknown
		//IL_0413: Expected I4, but got O
		//IL_042c: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2000;
		object obj4 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2504;
		<Team1Score>k__BackingField = team1Score;
		<Team2Score>k__BackingField = team2Score;
		object obj5 = team1Score - team2Score;
		bool flag = (nint)obj5 < 0;
		bool flag2 = obj5 == null;
		int num = team1Score ^ team2Score;
		int num2 = team1Score ^ obj5;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj6 = !flag4;
		object obj7 = obj6 | flag2;
		object obj8 = ~obj7;
		int num4 = ((obj8 != null) ? 1 : (1 + 1));
		int num5 = default(int);
		<PreviousPoints>k__BackingField = num5;
		<CurrentPoints>k__BackingField = currentPoints;
		int num6 = currentPoints - num5;
		<GamePoints>k__BackingField = num6;
		<WinnerTeamIndex>k__BackingField = num4;
		<BonusPercentage>k__BackingField = streakPercentage;
		object obj9 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = default(object);
		obj10..ctor();
		object obj11 = this + 72;
		obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = default(object);
		obj12..ctor();
		object obj13 = this + 80;
		obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, int> dictionary = default(Dictionary<object, int>);
		dictionary..ctor();
		if (obj13 != null)
		{
			object obj14 = (nint)0 + (nint)1320;
			object obj15 = obj13 + 16;
			obj15 = dictionary;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			IEnumerable<int> source = Enumerable.Range(1, 4);
			int[] array = Enumerable.ToArray(source);
			IEnumerable<int> source2 = Enumerable.Range(0, 10);
			object obj16 = obj14;
			int[] array2 = Enumerable.ToArray(source2);
			bool flag5 = highlightsCount < 1;
			int num7 = 0;
			if (flag5)
			{
				goto IL_0441;
			}
			object obj17 = obj13;
			if (array2 != null && obj13 != null)
			{
				object obj18 = (nint)0 + (nint)2904;
				int num8 = array2 + 44;
				string text = ((int*)num8)->ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C990C8");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v26+10]");
				if ((nint)0 != 0)
				{
					object obj19 = (nint)0 + (nint)3280;
					num5 = (int)obj19;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X8_v26+10]");
					int num9 = default(int);
					((Dictionary<object, int>)0).Add(text, num9);
					bool flag6 = highlightsCount == 1;
					num7 = num9;
					obj16 = text;
					if (flag6)
					{
						goto IL_0441;
					}
					object obj20 = obj13;
					if (obj13 != null)
					{
						bool flag7 = array2.Length < 5;
						object obj21 = !flag7;
						object obj22 = ~obj21;
						if (obj22 != null)
						{
							goto IL_0660;
						}
						int num10 = array2 + 48;
						string text2 = ((int*)num10)->ToString();
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C990C8");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v27+10]");
						if ((nint)0 != 0)
						{
							num5 = (int)obj19;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X8_v27+10]");
							int num11 = default(int);
							((Dictionary<object, int>)0).Add(text2, num11);
							bool flag8 = highlightsCount == 2;
							num7 = num11;
							obj16 = text2;
							if (flag8)
							{
								goto IL_0441;
							}
							object obj23 = obj13;
							if (obj13 != null)
							{
								object obj24 = array2.Length & 0xFFFFFFFEL;
								bool flag9 = (nint)obj24 < 6;
								object obj25 = !flag9;
								object obj26 = ~obj25;
								if (obj26 != null)
								{
									goto IL_0660;
								}
								int num12 = array2 + 52;
								string text3 = ((int*)num12)->ToString();
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C990C8");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v28+10]");
								if ((nint)0 != 0)
								{
									num5 = (int)obj19;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v28+10]");
									int num13 = default(int);
									((Dictionary<object, int>)0).Add(text3, num13);
									num7 = num13;
									obj16 = text3;
									goto IL_0441;
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0660;
		IL_0660:
		throw new IndexOutOfRangeException();
		IL_0441:
		object obj27 = typeof(SqlSingle[]) + 2360;
		object obj28 = (nint)0 + (nint)3008;
		object obj29 = (nint)0 + (nint)816;
		object obj30 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 3952;
		object obj31 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2080;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj32 = default(object);
		obj32..ctor();
		obj11 = obj32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj33 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v29+E4]");
		bool flag10 = (nint)0 == 0;
		object obj34 = !flag10;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<GameAchievementViewModel> achievements = AchievementsManager.Achievements;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9AC98");
		IEnumerable<object> source3 = default(IEnumerable<object>);
		IEnumerable<object> enumerable = Enumerable.Take(source3, testAchievementsCount);
		object obj35 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v36+E4]");
		IEnumerable<object> source4;
		object obj36;
		if ((nint)0 != 0)
		{
			source4 = enumerable;
			obj36 = obj30;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj35 = obj30;
			source4 = enumerable;
			obj36 = obj30;
		}
		object obj37 = (nint)0 + (nint)3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v36+B8]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v18+18]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v18+18]");
		bool flag11 = (nint)0 == 0;
		object obj39 = !flag11;
		if (obj39 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v431 @ X0_v36+E4]");
			bool flag12 = (nint)0 == 0;
			object obj40 = !flag12;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj41 = obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v24+B8]");
				obj38 = 0;
			}
			object obj42 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj43 = (nint)0 + (nint)2416;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj38, (IntPtr)obj43);
			object obj44 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v23+B8]");
			object obj45 = (nint)0 + (nint)24;
			obj45 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num5 = 0;
			selector = func;
		}
		IEnumerable<object> source5 = Enumerable.Select(source4, selector);
		List<object> list = Enumerable.ToList(source5);
		object obj46 = this + 88;
		obj46 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj47 = this + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+20]");
		obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+14]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+18]");
		_ = 0;
	}
}
