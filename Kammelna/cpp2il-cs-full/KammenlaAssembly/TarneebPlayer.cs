using System;
using System.Formats.Asn1;
using Cpp2ILInjected;

public class TarneebPlayer : CardGamePlayer
{
	private new TarneebGame Game
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			TarneebGame game = (TarneebGame)base.Game;
			if ((object)game != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
				object obj2 = obj;
				nint num = (nint)game;
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
			return game;
		}
	}

	public int EatingsCount
	{
		get
		{
			//IL_016d: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			//IL_00bd: Expected O, but got I
			//IL_00f2: Expected O, but got I4
			//IL_0113: Expected O, but got I4
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected O, but got Unknown
			CardGame game = base.Game;
			if ((object)game != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
				object obj2 = obj;
				nint num = (nint)game;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v7 (Il2CppClass<CardGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X1_v4+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v7 (Il2CppClass<CardGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X1_v4+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v10-8]");
					if (0 == (nint)obj2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3 (CardGame)+178]");
						object obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3 (CardGame)+178]");
						if ((nint)0 == 0)
						{
							goto IL_0151;
						}
						object obj7 = ((KPlayer)this).<Index>k__BackingField - 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v12+18]");
						bool flag2 = (nint)obj7 < 0;
						object obj8 = !flag2;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v3 (CardGame)+178]");
							object obj9 = 0 + obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v13+20]");
							return 0;
						}
						goto IL_015f;
					}
				}
				InvalidCastException ex = new InvalidCastException();
			}
			goto IL_0151;
			IL_015f:
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			return (int)ex2;
			IL_0151:
			NullReferenceException ex3 = new NullReferenceException();
			goto IL_015f;
		}
	}

	public int TeamEatingsCount
	{
		get
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_0033: Expected I, but got O
			//IL_005c: Expected O, but got I4
			//IL_01ae: Expected I4, but got O
			//IL_0090: Expected O, but got I
			//IL_00c7: Expected O, but got I
			//IL_0126: Expected O, but got I4
			//IL_0147: Expected O, but got I4
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Expected O, but got Unknown
			int eatingsCount = EatingsCount;
			CardGame game = base.Game;
			if ((object)game == null)
			{
				goto IL_0184;
			}
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
			object obj2 = obj;
			nint num = (nint)game;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8 (Il2CppClass<CardGame>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X1_v5+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v8 (Il2CppClass<CardGame>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X1_v5+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v10-8]");
				if (0 == (nint)obj2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v4 (CardGame)+178]");
					object obj6 = 0;
					CardGamePlayer teammate = base.Teammate;
					if (teammate != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v4 (CardGame)+178]");
						if ((nint)0 != 0)
						{
							object obj7 = ((KPlayer)teammate).<Index>k__BackingField - 1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X21_v5+18]");
							bool flag2 = (nint)obj7 < 0;
							object obj8 = !flag2;
							if (obj8 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v4 (CardGame)+178]");
								object obj9 = 0 + obj7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v14+20]");
								return (int)((nint)0 + (nint)eatingsCount);
							}
							goto IL_01a0;
						}
					}
					goto IL_0184;
				}
			}
			goto IL_0192;
			IL_01a0:
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
			return (int)ex;
			IL_0184:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_0192;
			IL_0192:
			InvalidCastException ex3 = new InvalidCastException();
			goto IL_01a0;
		}
	}

	public int OpponentTeamEatingsCount
	{
		get
		{
			//IL_0402: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			//IL_00bd: Expected O, but got I
			//IL_00d2: Expected I, but got O
			//IL_00fb: Expected O, but got I4
			//IL_012f: Expected O, but got I
			//IL_01a1: Expected O, but got I4
			//IL_01c2: Expected O, but got I4
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected O, but got Unknown
			//IL_01fa: Expected I, but got O
			//IL_0223: Expected O, but got I4
			//IL_0257: Expected O, but got I
			//IL_028e: Expected O, but got I
			//IL_02a3: Expected I, but got O
			//IL_02cc: Expected O, but got I4
			//IL_0300: Expected O, but got I
			//IL_0372: Expected O, but got I4
			//IL_0393: Expected O, but got I4
			//IL_03b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b6: Expected O, but got Unknown
			CardGame game = base.Game;
			if ((object)game != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3848;
				object obj2 = obj;
				nint num = (nint)game;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<CardGame>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X1_v4+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5 (Il2CppClass<CardGame>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X1_v4+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v8-8]");
					if (0 == (nint)obj2)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3 (CardGame)+178]");
						object obj6 = 0;
						CardGame game2 = base.Game;
						if ((object)game2 == null)
						{
							goto IL_03e6;
						}
						object obj7 = obj;
						nint num4 = (nint)game2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v12 (Il2CppClass<CardGame>)+130]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X1_v7+130]");
						bool flag2 = num5 < 0;
						object obj8 = !flag2;
						object obj9 = ~obj8;
						if (obj9 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v12 (Il2CppClass<CardGame>)+C8]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X1_v7+130]");
							object obj10 = num6 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v14-8]");
							if (0 == (nint)obj7)
							{
								int nextPlayerIndex = game2.GetNextPlayerIndex(((KPlayer)this).<Index>k__BackingField);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3 (CardGame)+178]");
								if ((nint)0 != 0)
								{
									object obj11 = nextPlayerIndex - 1;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X22_v4+18]");
									bool flag3 = (nint)obj11 < 0;
									object obj12 = !flag3;
									if (obj12 != null)
									{
										goto IL_03f4;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3 (CardGame)+178]");
									object obj13 = 0 + obj11;
									CardGame game3 = base.Game;
									if ((object)game3 != null)
									{
										object obj14 = obj;
										nint num7 = (nint)game3;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v20 (Il2CppClass<CardGame>)+130]");
										nint num8 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X1_v10+130]");
										bool flag4 = num8 < 0;
										object obj15 = !flag4;
										object obj16 = ~obj15;
										if (obj16 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v20 (Il2CppClass<CardGame>)+C8]");
											nint num9 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X1_v10+130]");
											object obj17 = num9 + 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v22-8]");
											if (0 == (nint)obj14)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v16 (CardGame)+178]");
												object obj18 = 0;
												CardGame game4 = base.Game;
												if ((object)game4 == null)
												{
													goto IL_03e6;
												}
												object obj19 = obj;
												nint num10 = (nint)game4;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v26 (Il2CppClass<CardGame>)+130]");
												nint num11 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X1_v12+130]");
												bool flag5 = num11 < 0;
												object obj20 = !flag5;
												object obj21 = ~obj20;
												if (obj21 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v26 (Il2CppClass<CardGame>)+C8]");
													nint num12 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X1_v12+130]");
													object obj22 = num12 + 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v28-8]");
													if (0 == (nint)obj19)
													{
														int nextPlayerIndex2 = game4.GetNextPlayerIndex(((KPlayer)this).<Index>k__BackingField, 3);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v16 (CardGame)+178]");
														if ((nint)0 == 0)
														{
															goto IL_03e6;
														}
														object obj23 = nextPlayerIndex2 - 1;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X23_v4+18]");
														bool flag6 = (nint)obj23 < 0;
														object obj24 = !flag6;
														if (obj24 == null)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X0_v16 (CardGame)+178]");
															object obj25 = 0 + obj23;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v31+20]");
															nint num13 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v17+20]");
															return (int)(num13 + 0);
														}
														goto IL_03f4;
													}
												}
											}
										}
										goto IL_03d8;
									}
								}
								goto IL_03e6;
							}
						}
					}
				}
				goto IL_03d8;
			}
			goto IL_03e6;
			IL_03e6:
			NullReferenceException ex = new NullReferenceException();
			goto IL_03f4;
			IL_03d8:
			InvalidCastException ex2 = new InvalidCastException();
			goto IL_03e6;
			IL_03f4:
			IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
			return (int)ex3;
		}
	}

	public bool IsTeamBidder
	{
		get
		{
			//IL_0074: Expected I4, but got O
			if (base.IsRoundBidder)
			{
				return true;
			}
			CardGamePlayer teammate = base.Teammate;
			if (teammate != null)
			{
				return teammate.IsRoundBidder;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public TarneebPlayer(TarneebGame game)
		: base(game)
	{
	}
}
