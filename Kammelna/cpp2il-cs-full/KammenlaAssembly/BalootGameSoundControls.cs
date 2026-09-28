using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Server.Models;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Unity.Services.Authentication.Shared;
using UnityEngine.Purchasing.Telemetry;

public class BalootGameSoundControls : CardGameSoundControls
{
	protected GameSoundAlbum soundAlbum;

	protected BalootGame balootGame
	{
		get
		{
			//IL_0016: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_00df: Expected O, but got I4
			//IL_008c: Expected O, but got I4
			//IL_0049: Expected O, but got I
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Expected O, but got Unknown
			//IL_014a: Expected I, but got O
			//IL_0173: Expected O, but got I4
			//IL_01a7: Expected O, but got I
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_0213: Expected O, but got I4
			//IL_0247: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AD0]");
			object obj = (nint)0 & (nint)1;
			if (obj != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE3]");
				object obj2 = (nint)0 & (nint)1;
				if (obj2 != null)
				{
					goto IL_0066;
				}
			}
			else
			{
				_ = 1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE3]");
				object obj3 = (nint)0 & (nint)1;
				bool flag = obj3 == null;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0066;
				}
			}
			_ = 1;
			BalootGame balootGame = (BalootGame)game;
			bool flag2 = (object)game == null;
			BalootGame result = (BalootGame)game;
			if (!flag2)
			{
				goto IL_0126;
			}
			goto IL_0276;
			IL_0276:
			return result;
			IL_0126:
			object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
			object obj6 = obj5;
			nint num = (nint)balootGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v2 (Il2CppClass<BalootGame>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X1_v2+130]");
			bool flag3 = num2 < 0;
			object obj7 = !flag3;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v2 (Il2CppClass<BalootGame>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X1_v2+130]");
				object obj9 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X10_v4-8]");
				if (0 == (nint)obj6)
				{
					object obj10 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1984;
					object obj11 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v2 (Il2CppClass<BalootGame>)+130]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X1_v4+130]");
					bool flag4 = num4 < 0;
					object obj12 = !flag4;
					object obj13 = ~obj12;
					if (obj13 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v2 (Il2CppClass<BalootGame>)+C8]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X1_v4+130]");
						object obj14 = num5 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v8-8]");
						bool flag5 = 0 != (nint)obj11;
						result = balootGame;
						if (!flag5)
						{
							goto IL_0276;
						}
					}
				}
			}
			return (BalootGame)(object)new InvalidCastException();
			IL_0066:
			balootGame = (BalootGame)game;
			bool flag6 = (object)game == null;
			object obj15 = !flag6;
			if (obj15 != null)
			{
				goto IL_0126;
			}
			result = (BalootGame)game;
			goto IL_0276;
		}
	}

	protected override void OnRoundEnd()
	{
		//IL_0016: Expected O, but got I
		//IL_0100: Expected O, but got I
		//IL_011a: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_0094: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_0049: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_015e: Expected O, but got I4
		//IL_0167: Expected O, but got I4
		//IL_0170: Expected O, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01bf: Expected I, but got O
		//IL_01e8: Expected O, but got I4
		//IL_00d1: Expected O, but got I4
		//IL_021c: Expected O, but got I
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0288: Expected O, but got I4
		//IL_02bc: Expected O, but got I
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_0319: Expected I, but got O
		//IL_0342: Expected O, but got I4
		//IL_0376: Expected O, but got I
		//IL_03b4: Expected O, but got I
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_03e1: Expected I, but got O
		//IL_040a: Expected O, but got I4
		//IL_043e: Expected O, but got I
		//IL_047b: Expected O, but got I
		//IL_0495: Expected O, but got I4
		//IL_04b9: Expected O, but got I
		//IL_055e: Expected O, but got I
		//IL_0578: Expected O, but got I4
		//IL_052f: Expected O, but got I4
		//IL_04ec: Expected O, but got I
		//IL_05ab: Expected I, but got O
		//IL_05d4: Expected O, but got I4
		//IL_0608: Expected O, but got I
		//IL_0660: Expected O, but got I4
		//IL_0694: Expected O, but got I
		//IL_09b2: Expected O, but got I
		//IL_09c3: Expected O, but got I4
		//IL_072a: Expected O, but got I
		//IL_0990: Expected O, but got I
		//IL_09a1: Expected O, but got I4
		//IL_07cf: Expected O, but got I
		//IL_07e9: Expected O, but got I4
		//IL_07a0: Expected O, but got I4
		//IL_075d: Expected O, but got I
		//IL_081c: Expected I, but got O
		//IL_0845: Expected O, but got I4
		//IL_0879: Expected O, but got I
		//IL_08d1: Expected O, but got I4
		//IL_0905: Expected O, but got I
		//IL_0a28: Expected O, but got I
		//IL_0a39: Expected O, but got I4
		//IL_0a06: Expected O, but got I
		//IL_0a17: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AD1]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AD0]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0066;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AD0]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0066;
			}
		}
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE3]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		object obj7 = 152993792;
		object obj8 = 152993792;
		if (obj6 != null)
		{
			goto IL_00ab;
		}
		goto IL_017e;
		IL_077a:
		KGame kGame = game;
		bool flag3 = (object)game == null;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_080c;
		}
		goto IL_0a4c;
		IL_0a3e:
		InvalidCastException ex = new InvalidCastException();
		goto IL_0a4c;
		IL_059b:
		object obj11;
		object obj10 = obj11;
		KGame kGame2;
		nint num = (nint)kGame2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X9_v11 (Il2CppClass<KGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X1_v11+130]");
		bool flag4 = num2 < 0;
		object obj12 = !flag4;
		object obj13 = ~obj12;
		object obj16;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X9_v11 (Il2CppClass<KGame>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X1_v11+130]");
			object obj14 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X10_v9-8]");
			if (0 == (nint)obj10)
			{
				object obj15 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X9_v11 (Il2CppClass<KGame>)+130]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X1_v12+130]");
				bool flag5 = num4 < 0;
				object obj17 = !flag5;
				object obj18 = ~obj17;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X9_v11 (Il2CppClass<KGame>)+C8]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X1_v12+130]");
					object obj19 = num5 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v28-8]");
					if (0 == (nint)obj15)
					{
						if (kGame2.IsFastTrackGame)
						{
							return;
						}
						int myTeamIndex = base.MyTeamIndex;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v12 (System.Object)+18]");
						if ((nint)0 != myTeamIndex)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AD0]");
							object obj20 = (nint)0 & (nint)1;
							if (obj20 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X22_v3+AE3]");
								object obj21 = (nint)0 & (nint)1;
								if (obj21 != null)
								{
									goto IL_077a;
								}
							}
							else
							{
								_ = 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X22_v3+AE3]");
								object obj22 = (nint)0 & (nint)1;
								bool flag6 = obj22 == null;
								object obj23 = !flag6;
								if (obj23 != null)
								{
									goto IL_077a;
								}
							}
							_ = 1;
							kGame = game;
							goto IL_080c;
						}
						goto IL_0952;
					}
				}
			}
		}
		goto IL_0a3e;
		IL_0066:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE3]");
		object obj24 = (nint)0 & (nint)1;
		bool flag7 = obj24 == null;
		obj7 = 152993792;
		obj8 = 152993792;
		if (!flag7)
		{
			goto IL_00ab;
		}
		goto IL_017e;
		IL_017e:
		_ = 1;
		KGame kGame3 = game;
		obj7 = obj8;
		goto IL_019b;
		IL_00ab:
		kGame3 = game;
		bool flag8 = (object)game == null;
		object obj25 = !flag8;
		if (obj25 != null)
		{
			goto IL_019b;
		}
		goto IL_0a4c;
		IL_019b:
		obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
		object obj26 = obj11;
		nint num6 = (nint)kGame3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v5 (Il2CppClass<KGame>)+130]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X1_v3+130]");
		bool flag9 = num7 < 0;
		object obj27 = !flag9;
		object obj28 = ~obj27;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v5 (Il2CppClass<KGame>)+C8]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X1_v3+130]");
			object obj29 = num8 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v284 @ X11_v5-8]");
			if (0 == (nint)obj26)
			{
				obj16 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1984;
				object obj30 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v5 (Il2CppClass<KGame>)+130]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X1_v5+130]");
				bool flag10 = num9 < 0;
				object obj31 = !flag10;
				object obj32 = ~obj31;
				if (obj32 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v5 (Il2CppClass<KGame>)+C8]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X1_v5+130]");
					object obj33 = num10 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v445 @ X9_v5-8]");
					if (0 == (nint)obj30)
					{
						IGameScores gameScores = kGame3.GameScores;
						object obj34 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2064;
						object obj35 = obj34;
						nint num11 = (nint)gameScores;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v9 (Il2CppClass<IGameScores>)+130]");
						nint num12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X1_v7+130]");
						bool flag11 = num12 < 0;
						object obj36 = !flag11;
						object obj37 = ~obj36;
						if (obj37 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v9 (Il2CppClass<IGameScores>)+C8]");
							nint num13 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X1_v7+130]");
							object obj38 = num13 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X8_v11-8]");
							if (0 == (nint)obj35)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v9 (IGameScores)+10]");
								object obj39 = Enumerable.Last((IEnumerable<object>)0);
								object obj40 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2056;
								object obj41 = obj40;
								nint num14 = (nint)obj39;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v19 (Il2CppClass<System.Object>)+130]");
								nint num15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X1_v9+130]");
								bool flag12 = num15 < 0;
								object obj42 = !flag12;
								object obj43 = ~obj42;
								if (obj43 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v19 (Il2CppClass<System.Object>)+C8]");
									nint num16 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v237 @ X1_v9+130]");
									object obj44 = num16 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v21-8]");
									if (0 == (nint)obj41)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v12 (System.Object)+2C]");
										object obj45 = (nint)0 & (nint)1;
										bool flag13 = obj45 == null;
										object obj46 = !flag13;
										if (obj46 != null)
										{
											return;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AD0]");
										object obj47 = (nint)0 & (nint)1;
										if (obj47 != null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE3]");
											object obj48 = (nint)0 & (nint)1;
											if (obj48 != null)
											{
												goto IL_0509;
											}
										}
										else
										{
											_ = 1;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE3]");
											object obj49 = (nint)0 & (nint)1;
											bool flag14 = obj49 == null;
											object obj50 = !flag14;
											if (obj50 != null)
											{
												goto IL_0509;
											}
										}
										_ = 1;
										kGame2 = game;
										goto IL_059b;
									}
								}
							}
						}
						throw new InvalidCastException();
					}
				}
			}
		}
		goto IL_0a3e;
		IL_0a5e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
		return;
		IL_0952:
		GameSoundAlbum gameSoundAlbum = soundAlbum;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v12 (System.Object)+58]");
		if ((nint)0 == 1)
		{
			object obj51 = (nint)0 + (nint)2408;
			object obj52 = obj51;
			object obj53 = 1;
		}
		else
		{
			object obj54 = (nint)0 + (nint)2408;
			object obj52 = obj54;
			object obj53 = 0;
		}
		goto IL_0a5e;
		IL_0a4c:
		throw new NullReferenceException();
		IL_080c:
		object obj55 = obj11;
		nint num17 = (nint)kGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X9_v15 (Il2CppClass<KGame>)+130]");
		nint num18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X1_v19+130]");
		bool flag15 = num18 < 0;
		object obj56 = !flag15;
		object obj57 = ~obj56;
		if (obj57 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X9_v15 (Il2CppClass<KGame>)+C8]");
			nint num19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X1_v19+130]");
			object obj58 = num19 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X10_v15-8]");
			if (0 == (nint)obj55)
			{
				object obj59 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X9_v15 (Il2CppClass<KGame>)+130]");
				nint num20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X1_v20+130]");
				bool flag16 = num20 < 0;
				object obj60 = !flag16;
				object obj61 = ~obj60;
				if (obj61 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X9_v15 (Il2CppClass<KGame>)+C8]");
					nint num21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X1_v20+130]");
					object obj62 = num21 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v40-8]");
					if (0 == (nint)obj59)
					{
						if (kGame.IsSpectator)
						{
							goto IL_0952;
						}
						gameSoundAlbum = soundAlbum;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v12 (System.Object)+58]");
						if ((nint)0 == 1)
						{
							object obj63 = (nint)0 + (nint)2408;
							object obj52 = obj63;
							object obj53 = 6;
						}
						else
						{
							object obj64 = (nint)0 + (nint)2408;
							object obj52 = obj64;
							object obj53 = 5;
						}
						goto IL_0a5e;
					}
				}
			}
		}
		goto IL_0a3e;
		IL_0509:
		kGame2 = game;
		bool flag17 = (object)game == null;
		object obj65 = !flag17;
		if (obj65 != null)
		{
			goto IL_059b;
		}
		goto IL_0a4c;
	}

	protected override void OnGameEnd(ISFSObject data)
	{
		//IL_0048: Expected O, but got I
		//IL_00ed: Expected O, but got I
		//IL_0107: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_007b: Expected O, but got I
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_014e: Expected I, but got O
		//IL_0177: Expected O, but got I4
		//IL_01ab: Expected O, but got I
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_0217: Expected O, but got I4
		//IL_024b: Expected O, but got I
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_03f8: Expected I, but got O
		//IL_0307: Expected O, but got I
		//IL_045f: Expected O, but got I
		//IL_0479: Expected O, but got I4
		//IL_0955: Expected O, but got I
		//IL_0966: Expected O, but got I4
		//IL_037d: Expected O, but got I4
		//IL_033a: Expected O, but got I
		//IL_0654: Expected O, but got I
		//IL_04ac: Expected I, but got O
		//IL_04d5: Expected O, but got I4
		//IL_06f9: Expected O, but got I
		//IL_0713: Expected O, but got I4
		//IL_06ca: Expected O, but got I4
		//IL_0687: Expected O, but got I
		//IL_0509: Expected O, but got I
		//IL_0746: Expected I, but got O
		//IL_076f: Expected O, but got I4
		//IL_0561: Expected O, but got I4
		//IL_07a3: Expected O, but got I
		//IL_0595: Expected O, but got I
		//IL_07fb: Expected O, but got I4
		//IL_082f: Expected O, but got I
		//IL_05ee: Expected O, but got I4
		//IL_09bc: Expected O, but got I
		//IL_09cd: Expected O, but got I4
		//IL_099a: Expected O, but got I
		//IL_09ab: Expected O, but got I4
		//IL_09de: Expected O, but got I
		//IL_09ef: Expected O, but got I4
		//IL_0924: Expected O, but got I
		//IL_0935: Expected O, but got I4
		if (game.IsReplay)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AD0]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE3]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_0098;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE3]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0098;
			}
		}
		_ = 1;
		KGame kGame = game;
		goto IL_012a;
		IL_0736:
		object obj6;
		object obj5 = obj6;
		KGame kGame2;
		nint num = (nint)kGame2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X9_v9 (Il2CppClass<KGame>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X1_v18+130]");
		bool flag2 = num2 < 0;
		object obj7 = !flag2;
		object obj8 = ~obj7;
		object obj11;
		bool flag4;
		bool flag5;
		bool flag6;
		TournamentEndGameReport tournamentEndGameReport;
		TournamentEndGameReport tournamentEndGameReport2;
		GameSoundAlbum gameSoundAlbum;
		object obj16;
		object obj17;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X9_v9 (Il2CppClass<KGame>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X1_v18+130]");
			object obj9 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X10_v12-8]");
			if (0 == (nint)obj5)
			{
				object obj10 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X9_v9 (Il2CppClass<KGame>)+130]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X1_v19+130]");
				bool flag3 = num4 < 0;
				object obj12 = !flag3;
				object obj13 = ~obj12;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X9_v9 (Il2CppClass<KGame>)+C8]");
					nint num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v475 @ X1_v19+130]");
					object obj14 = num5 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v24-8]");
					if (0 == (nint)obj10)
					{
						if (kGame2.IsSpectator)
						{
							if (flag4)
							{
								flag5 = flag6;
								tournamentEndGameReport = tournamentEndGameReport2;
								goto IL_08aa;
							}
							goto IL_093a;
						}
						gameSoundAlbum = soundAlbum;
						if (flag4)
						{
							object obj15 = (nint)0 + (nint)2408;
							obj16 = obj15;
							obj17 = 8;
						}
						else
						{
							object obj18 = (nint)0 + (nint)2408;
							obj16 = obj18;
							obj17 = 7;
						}
						goto IL_0a09;
					}
				}
			}
		}
		goto IL_09f4;
		IL_063e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AD0]");
		object obj19 = (nint)0 & (nint)1;
		if (obj19 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE3]");
			object obj20 = (nint)0 & (nint)1;
			if (obj20 != null)
			{
				goto IL_06a4;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE3]");
			object obj21 = (nint)0 & (nint)1;
			bool flag7 = obj21 == null;
			object obj22 = !flag7;
			if (obj22 != null)
			{
				goto IL_06a4;
			}
		}
		_ = 1;
		kGame2 = game;
		goto IL_0736;
		IL_0a02:
		throw new NullReferenceException();
		IL_09f4:
		InvalidCastException ex = new InvalidCastException();
		goto IL_0a02;
		IL_0098:
		kGame = game;
		bool flag8 = (object)game == null;
		object obj23 = !flag8;
		if (obj23 != null)
		{
			goto IL_012a;
		}
		goto IL_0a02;
		IL_012a:
		obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 328;
		object obj24 = obj6;
		nint num6 = (nint)kGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X9_v2 (Il2CppClass<KGame>)+130]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X1_v3+130]");
		bool flag9 = num7 < 0;
		object obj25 = !flag9;
		object obj26 = ~obj25;
		TournamentEndGameReport tournamentEndGameReport3 = default(TournamentEndGameReport);
		int myTeamIndex;
		KGame kGame3;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X9_v2 (Il2CppClass<KGame>)+C8]");
			nint num8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X1_v3+130]");
			object obj27 = num8 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X10_v4-8]");
			if (0 == (nint)obj24)
			{
				obj11 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1984;
				object obj28 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X9_v2 (Il2CppClass<KGame>)+130]");
				nint num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X1_v5+130]");
				bool flag10 = num9 < 0;
				object obj29 = !flag10;
				object obj30 = ~obj29;
				if (obj30 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X9_v2 (Il2CppClass<KGame>)+C8]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X1_v5+130]");
					object obj31 = num10 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X8_v8-8]");
					if (0 == (nint)obj28)
					{
						Room room = kGame.Room;
						GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
						flag4 = GameTypeExtensions.IsTournament(gameType);
						if (flag4)
						{
							object obj32 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1536;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							tournamentEndGameReport3..ctor(data);
							myTeamIndex = base.MyTeamIndex;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AD0]");
							object obj33 = (nint)0 & (nint)1;
							if (obj33 != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE3]");
								object obj34 = (nint)0 & (nint)1;
								if (obj34 != null)
								{
									goto IL_0357;
								}
							}
							else
							{
								_ = 1;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8AE3]");
								object obj35 = (nint)0 & (nint)1;
								bool flag11 = obj35 == null;
								object obj36 = !flag11;
								if (obj36 != null)
								{
									goto IL_0357;
								}
							}
							_ = 1;
							kGame3 = game;
							goto IL_049c;
						}
						Room room2 = game.Room;
						GameType gameType2 = SFSKammelnaRoomExtensions.GetGameType(room2);
						object obj37 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1976;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069DA8]");
						_ = 0;
						_ = 1;
						object obj38 = default(object);
						obj38..ctor();
						nint num11 = (nint)obj38;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v520 @ X8_v40 (Il2CppClass<System.Object>)+178] (should have been resolved before IL gen)");
						int myTeamIndex2 = base.MyTeamIndex;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v505 @ X0_v38 (System.Object)+34]");
						if ((nint)0 != myTeamIndex2)
						{
							flag6 = false;
							tournamentEndGameReport2 = null;
							goto IL_063e;
						}
						goto IL_093a;
					}
				}
			}
		}
		goto IL_09f4;
		IL_0357:
		kGame3 = game;
		bool flag12 = (object)game == null;
		object obj39 = !flag12;
		if (obj39 != null)
		{
			goto IL_049c;
		}
		goto IL_0a02;
		IL_049c:
		object obj40 = obj6;
		nint num12 = (nint)kGame3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X9_v12 (Il2CppClass<KGame>)+130]");
		nint num13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X1_v28+130]");
		bool flag13 = num13 < 0;
		object obj41 = !flag13;
		object obj42 = ~obj41;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X9_v12 (Il2CppClass<KGame>)+C8]");
			nint num14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X1_v28+130]");
			object obj43 = num14 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X10_v16-8]");
			if (0 == (nint)obj40)
			{
				object obj44 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X9_v12 (Il2CppClass<KGame>)+130]");
				nint num15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X1_v29+130]");
				bool flag14 = num15 < 0;
				object obj45 = !flag14;
				object obj46 = ~obj45;
				if (obj46 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X9_v12 (Il2CppClass<KGame>)+C8]");
					nint num16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X1_v29+130]");
					object obj47 = num16 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v612 @ X8_v46-8]");
					if (0 == (nint)obj44)
					{
						Room room3 = kGame3.Room;
						TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(room3);
						object obj48 = tournamentInfo.<PrizeType>k__BackingField - 10;
						bool flag15 = obj48 == null;
						bool flag16 = tournamentEndGameReport3.gameWinner == myTeamIndex;
						flag6 = flag15;
						tournamentEndGameReport2 = tournamentEndGameReport3;
						flag5 = flag15;
						tournamentEndGameReport = tournamentEndGameReport3;
						if (!flag16)
						{
							goto IL_063e;
						}
						goto IL_08aa;
					}
				}
			}
		}
		goto IL_09f4;
		IL_093a:
		gameSoundAlbum = soundAlbum;
		object obj49 = (nint)0 + (nint)2408;
		obj16 = obj49;
		obj17 = 2;
		goto IL_0a09;
		IL_06a4:
		kGame2 = game;
		bool flag17 = (object)game == null;
		object obj50 = !flag17;
		if (obj50 != null)
		{
			goto IL_0736;
		}
		goto IL_0a02;
		IL_08aa:
		if (!tournamentEndGameReport.isFinalMatch || !tournamentEndGameReport.IsMatchOver)
		{
			goto IL_093a;
		}
		gameSoundAlbum = soundAlbum;
		if (flag5)
		{
			object obj51 = (nint)0 + (nint)2408;
			obj16 = obj51;
			obj17 = 4;
		}
		else
		{
			object obj52 = (nint)0 + (nint)2408;
			obj16 = obj52;
			obj17 = 3;
		}
		goto IL_0a09;
		IL_0a09:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
		SingleSound singleSound = default(SingleSound);
		SoundChannel.PlaySFXSound(singleSound);
	}
}
