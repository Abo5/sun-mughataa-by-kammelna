using Cpp2ILInjected;
using Sfs2X.Entities.Data;

public abstract class CardGameRoundScore : ICardGameRoundScore
{
	public const string C_Team1Eatings = "e1";

	public const string C_Team2Eatings = "e2";

	public const string C_Winner = "w";

	public const string C_Team1Score = "s1";

	public const string C_Team2Score = "s2";

	public const string C_Bidder = "b";

	public const string C_CatchPlayerIndex = "cc";

	public const string C_LastRound = "lr";

	private int <Team1Eatings>k__BackingField;

	private int <Team2Eatings>k__BackingField;

	private int <WinnerTeamIndex>k__BackingField;

	private int <Team1Score>k__BackingField;

	private int <Team2Score>k__BackingField;

	private int <Bidder>k__BackingField;

	private int <CatchPlayerIndex>k__BackingField;

	private bool <IsLastRound>k__BackingField;

	public int Team1Eatings
	{
		get
		{
			return <Team1Eatings>k__BackingField;
		}
		private set
		{
			<Team1Eatings>k__BackingField = value;
		}
	}

	public int Team2Eatings
	{
		get
		{
			return <Team2Eatings>k__BackingField;
		}
		private set
		{
			<Team2Eatings>k__BackingField = value;
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

	public int Bidder
	{
		get
		{
			return <Bidder>k__BackingField;
		}
		private set
		{
			<Bidder>k__BackingField = value;
		}
	}

	public int CatchPlayerIndex
	{
		get
		{
			return <CatchPlayerIndex>k__BackingField;
		}
		private set
		{
			<CatchPlayerIndex>k__BackingField = value;
		}
	}

	public bool IsLastRound
	{
		get
		{
			return <IsLastRound>k__BackingField;
		}
		private set
		{
			<IsLastRound>k__BackingField = value;
		}
	}

	public CardGameRoundScore()
	{
	}

	public virtual void Record(ISFSObject data)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Expected O, but got Unknown
		object varName = "destinationTimeZone" + 1056;
		object varName2 = "destinationTimeZone" + 1064;
		object varName3 = "utf-32" + 1096;
		object varName4 = "rightCtrl" + 800;
		object varName5 = "rightCtrl" + 824;
		object varName6 = "alignContent" + 3552;
		object varName7 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2512;
		int num = SFSExtensions.Get(data, (string)varName, 0);
		<Team1Eatings>k__BackingField = num;
		int num2 = SFSExtensions.Get(data, (string)varName2, 0);
		<Team2Eatings>k__BackingField = num2;
		int num3 = SFSExtensions.Get(data, (string)varName3, 0);
		<WinnerTeamIndex>k__BackingField = num3;
		int num4 = SFSExtensions.Get(data, (string)varName4, 0);
		<Team1Score>k__BackingField = num4;
		int num5 = SFSExtensions.Get(data, (string)varName5, 0);
		<Team2Score>k__BackingField = num5;
		int num6 = SFSExtensions.Get(data, (string)varName6, 0);
		<Bidder>k__BackingField = num6;
		int num7 = SFSExtensions.Get(data, (string)varName7, 0);
		<CatchPlayerIndex>k__BackingField = num7;
		object varName8 = "java.io.FileOutputStream" + 3432;
		bool flag = SFSExtensions.Get(data, (string)varName8, defaultValue: false);
		<IsLastRound>k__BackingField = flag;
	}

	public int GetTeamScore(int teamIndex)
	{
		//IL_0037: Expected O, but got I4
		//IL_0029: Expected O, but got I4
		if (teamIndex == 1)
		{
			object obj = 28;
		}
		else
		{
			object obj = 32;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CardGameRoundScore)+v15 @ X8_v2]");
		return 0;
	}

	public int GetTeamEeatings(int teamIndex)
	{
		//IL_0037: Expected O, but got I4
		//IL_0029: Expected O, but got I4
		if (teamIndex == 1)
		{
			object obj = 16;
		}
		else
		{
			object obj = 20;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CardGameRoundScore)+v15 @ X8_v2]");
		return 0;
	}
}
