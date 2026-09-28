using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;

namespace Jackaroo;

public class JackarooGameSoundControls : CardGameSoundControls
{
	private GameEventsChannel _gameEventsChannel;

	protected GameSoundAlbum soundAlbum;

	private ISFSObject _data;

	protected JackarooGame jackarooGame
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			JackarooGame jackarooGame = (JackarooGame)base.cardGame;
			if ((object)jackarooGame != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
				object obj2 = obj;
				nint num = (nint)jackarooGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<Jackaroo.JackarooGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X1_v3+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v6 (Il2CppClass<Jackaroo.JackarooGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X1_v3+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (JackarooGame)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return jackarooGame;
		}
	}

	protected override void Init()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0127: Expected O, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0165: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0063: Expected I, but got O
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00b3: Expected I, but got O
		//IL_00da: Expected O, but got I
		//IL_0106: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj6 = this + 32;
		object obj7 = default(object);
		obj6 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v4 (Il2CppClass<Jackaroo.JackarooGameSoundControls>)+190]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		((KGame)obj6).OnRoundEnd += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v6 (Il2CppClass<Jackaroo.JackarooGameSoundControls>)+1A0]");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)0);
		object obj9 = (nint)0 + (nint)704;
		game.OnGameEnd += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj9);
		_gameEventsChannel.OpenEndGamePopup += action3;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c7: Expected I, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0050: Expected I, but got O
		//IL_0077: Expected O, but got I
		//IL_00a3: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3 (Il2CppClass<Jackaroo.JackarooGameSoundControls>)+190]");
		Action action = default(Action);
		action..ctor(this, (IntPtr)0);
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		game.OnRoundEnd -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X8_v5 (Il2CppClass<Jackaroo.JackarooGameSoundControls>)+1A0]");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)0);
		object obj3 = (nint)0 + (nint)704;
		game.OnGameEnd -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj3);
		_gameEventsChannel.OpenEndGamePopup -= action3;
	}

	protected override void OnRoundEnd()
	{
		//IL_0016: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_011a: Expected I, but got O
		//IL_0143: Expected O, but got I4
		//IL_0177: Expected O, but got I
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01d4: Expected I, but got O
		//IL_01fd: Expected O, but got I4
		//IL_0231: Expected O, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_028e: Expected I, but got O
		//IL_02b7: Expected O, but got I4
		//IL_02eb: Expected O, but got I
		//IL_0332: Expected O, but got I
		//IL_034c: Expected O, but got I4
		//IL_036f: Expected I, but got O
		//IL_0398: Expected O, but got I4
		//IL_03cc: Expected O, but got I
		//IL_045c: Expected O, but got I4
		//IL_049c: Expected O, but got I
		//IL_044e: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8063]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8062]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8062]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		CardGame cardGame = base.cardGame;
		goto IL_00f6;
		IL_046f:
		throw new NullReferenceException();
		IL_0461:
		InvalidCastException ex = new InvalidCastException();
		goto IL_046f;
		IL_00f6:
		object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X9_v5-8]");
			if (0 == (nint)obj6)
			{
				CardGameScores gameScores = (CardGameScores)cardGame.GameScores;
				object obj10 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 312;
				object obj11 = obj10;
				nint num4 = (nint)gameScores;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v9 (Il2CppClass<CardGameScores>)+130]");
				nint num5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X1_v7+130]");
				bool flag3 = num5 < 0;
				object obj12 = !flag3;
				object obj13 = ~obj12;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v9 (Il2CppClass<CardGameScores>)+C8]");
					nint num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X1_v7+130]");
					object obj14 = num6 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v11-8]");
					if (0 == (nint)obj11)
					{
						ICardGameRoundScore lastCardGameRoundScore = gameScores.LastCardGameRoundScore;
						object obj15 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 296;
						object obj16 = obj15;
						nint num7 = (nint)lastCardGameRoundScore;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v15 (Il2CppClass<ICardGameRoundScore>)+130]");
						nint num8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X1_v9+130]");
						bool flag4 = num8 < 0;
						object obj17 = !flag4;
						object obj18 = ~obj17;
						if (obj18 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v15 (Il2CppClass<ICardGameRoundScore>)+C8]");
							nint num9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X1_v9+130]");
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
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v23 (Il2CppClass<CardGame>)+130]");
								nint num11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X1_v13+130]");
								bool flag6 = num11 < 0;
								object obj23 = !flag6;
								object obj24 = ~obj23;
								if (obj24 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v23 (Il2CppClass<CardGame>)+C8]");
									nint num12 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X1_v13+130]");
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
								goto IL_0461;
							}
						}
						throw new InvalidCastException();
					}
				}
			}
		}
		goto IL_0461;
		IL_0066:
		cardGame = base.cardGame;
		bool flag7 = (object)cardGame == null;
		object obj28 = !flag7;
		if (obj28 != null)
		{
			goto IL_00f6;
		}
		goto IL_046f;
	}

	protected override void OnGameEnd(ISFSObject data)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 56;
		obj = data;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void PlayEndGameSound()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00bf: Expected O, but got I4
		//IL_00ed: Expected O, but got I4
		//IL_0091: Expected O, but got I4
		//IL_00fe: Expected O, but got I
		//IL_00df: Expected O, but got I4
		CardGame cardGame = base.cardGame;
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 336;
		Room room = cardGame.Room;
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CardGameEndScores cardGameEndScores = default(CardGameEndScores);
		cardGameEndScores..ctor(_data, gameType);
		int myTeamIndex = base.MyTeamIndex;
		if (cardGameEndScores.<WinnerTeamIndex>k__BackingField == myTeamIndex)
		{
			object obj2 = 2;
		}
		else
		{
			bool isSpectator = game.IsSpectator;
			bool flag = !isSpectator;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				object obj2 = 2;
			}
			else
			{
				object obj2 = 7;
			}
		}
		object obj5 = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}
}
