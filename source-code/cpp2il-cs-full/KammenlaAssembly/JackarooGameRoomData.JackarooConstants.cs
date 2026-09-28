using Jackaroo;
using Sfs2X.Entities.Data;

public class JackarooGameRoomData : GameRoomData
{
	private static class JackarooConstants
	{
		public const string TEAM1_PLAYER1_SCORE = "s1p1";

		public const string TEAM1_PLAYER2_SCORE = "s1p2";

		public const string TEAM2_PLAYER1_SCORE = "s2p1";

		public const string TEAM2_PLAYER2_SCORE = "s2p2";
	}

	public int Team1Player1Score;

	public int Team1Player2Score;

	public int Team2Player1Score;

	public int Team2Player2Score;

	public JackarooAllowedRules JackarooCustomRules;

	public JackarooGameRoomData(ISFSObject data)
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
		object varName = "rightCtrl" + 808;
		object varName2 = "rightCtrl" + 816;
		object varName3 = "rightCtrl" + 832;
		object varName4 = "rightCtrl" + 840;
		object varName5 = "java.io.FileOutputStream" + 280;
		base..ctor(data);
		int team1Player1Score = SFSExtensions.Get(data, (string)varName, 0);
		Team1Player1Score = team1Player1Score;
		int team1Player2Score = SFSExtensions.Get(data, (string)varName2, 0);
		Team1Player2Score = team1Player2Score;
		Team2Player1Score = SFSExtensions.Get(data, (string)varName3, 0);
		Team2Player2Score = SFSExtensions.Get(data, (string)varName4, 0);
		JackarooCustomRules = (JackarooAllowedRules)SFSExtensions.Get(data, (string)varName5, 0);
	}
}
