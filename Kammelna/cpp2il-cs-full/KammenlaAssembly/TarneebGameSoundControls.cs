using System;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Sfs2X.Requests.Buddylist;

public class TarneebGameSoundControls : CardGameSoundControls
{
	protected GameSoundAlbum soundAlbum;

	protected TarneebGame tarneebGame
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			TarneebGame tarneebGame = (TarneebGame)base.cardGame;
			if ((object)tarneebGame != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
				object obj2 = obj;
				nint num = (nint)tarneebGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<TarneebGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X1_v3+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<TarneebGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X1_v3+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (TarneebGame)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return tarneebGame;
		}
	}

	protected override void OnRoundEnd()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I
		//IL_00d1: Expected O, but got I4
		//IL_0088: Expected O, but got I4
		//IL_0047: Expected O, but got I
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0118: Expected I, but got O
		//IL_0141: Expected O, but got I4
		//IL_0175: Expected O, but got I
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01d2: Expected I, but got O
		//IL_01fb: Expected O, but got I4
		//IL_022f: Expected O, but got I
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_028c: Expected I, but got O
		//IL_02b5: Expected O, but got I4
		//IL_02e9: Expected O, but got I
		//IL_0330: Expected O, but got I
		//IL_034a: Expected O, but got I4
		//IL_036d: Expected I, but got O
		//IL_0396: Expected O, but got I4
		//IL_03ca: Expected O, but got I
		//IL_045a: Expected O, but got I4
		//IL_049a: Expected O, but got I
		//IL_044c: Expected O, but got I4
		object obj = typeof(SetBuddyVariablesRequest) & 1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CC6]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0064;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8CC6]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0064;
			}
		}
		_ = 1;
		CardGame cardGame = base.cardGame;
		goto IL_00f4;
		IL_046d:
		throw new NullReferenceException();
		IL_045f:
		InvalidCastException ex = new InvalidCastException();
		goto IL_046d;
		IL_00f4:
		object obj5 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
		object obj6 = obj5;
		nint num = (nint)cardGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v5 (Il2CppClass<CardGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X1_v4+130]");
		bool flag2 = num2 < 0;
		object obj7 = !flag2;
		object obj8 = ~obj7;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v5 (Il2CppClass<CardGame>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X1_v4+130]");
			object obj9 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X9_v5-8]");
			if (0 == (nint)obj6)
			{
				CardGameScores gameScores = (CardGameScores)cardGame.GameScores;
				object obj10 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3896;
				object obj11 = obj10;
				nint num4 = (nint)gameScores;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v9 (Il2CppClass<CardGameScores>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X1_v7+130]");
				bool flag3 = num5 < 0;
				object obj12 = !flag3;
				object obj13 = ~obj12;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v9 (Il2CppClass<CardGameScores>)+C8]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X1_v7+130]");
					object obj14 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v11-8]");
					if (0 == (nint)obj11)
					{
						ICardGameRoundScore lastCardGameRoundScore = gameScores.LastCardGameRoundScore;
						object obj15 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3888;
						object obj16 = obj15;
						nint num7 = (nint)lastCardGameRoundScore;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v15 (Il2CppClass<ICardGameRoundScore>)+130]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X1_v9+130]");
						bool flag4 = num8 < 0;
						object obj17 = !flag4;
						object obj18 = ~obj17;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v15 (Il2CppClass<ICardGameRoundScore>)+C8]");
							nint num9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X1_v9+130]");
							object obj19 = num9 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v17-8]");
							if (0 == (nint)obj16)
							{
								int myTeamIndex = base.MyTeamIndex;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v10 (ICardGameRoundScore)+2C]");
								object obj20 = (nint)0 & (nint)1;
								bool flag5 = obj20 == null;
								object obj21 = !flag5;
								if (obj21 != null)
								{
									return;
								}
								CardGame cardGame2 = base.cardGame;
								object obj22 = obj5;
								nint num10 = (nint)cardGame2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v23 (Il2CppClass<CardGame>)+130]");
								nint num11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X1_v13+130]");
								bool flag6 = num11 < 0;
								object obj23 = !flag6;
								object obj24 = ~obj23;
								if (obj24 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v23 (Il2CppClass<CardGame>)+C8]");
									nint num12 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X1_v13+130]");
									object obj25 = num12 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v25-8]");
									if (0 == (nint)obj22)
									{
										if (!cardGame2.IsFastTrackGame)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v10 (ICardGameRoundScore)+18]");
											if ((nint)0 == myTeamIndex)
											{
												object obj26 = 0;
											}
											else
											{
												object obj26 = 5;
											}
											object obj27 = (nint)0 + (nint)2408;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
											SingleSound singleSound = default(SingleSound);
											SoundChannel.PlaySFXSound(singleSound);
										}
										return;
									}
								}
								goto IL_045f;
							}
						}
						throw new InvalidCastException();
					}
				}
			}
		}
		goto IL_045f;
		IL_0064:
		cardGame = base.cardGame;
		bool flag7 = (object)cardGame == null;
		object obj28 = !flag7;
		if (obj28 != null)
		{
			goto IL_00f4;
		}
		goto IL_046d;
	}

	protected override void OnGameEnd(ISFSObject data)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0064: Expected O, but got I
		CardGame cardGame = base.cardGame;
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 336;
		Room room = cardGame.Room;
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CardGameEndScores cardGameEndScores = default(CardGameEndScores);
		cardGameEndScores..ctor(data, gameType);
		object obj2 = (nint)0 + (nint)2408;
		int myTeamIndex = base.MyTeamIndex;
		if (cardGameEndScores.<WinnerTeamIndex>k__BackingField == myTeamIndex || game.IsSpectator)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound singleSound = default(SingleSound);
			SoundChannel.PlaySFXSound(singleSound);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
			SingleSound singleSound2 = default(SingleSound);
			SoundChannel.PlaySFXSound(singleSound2);
		}
	}
}
