using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.Common;
using Sfs2X.Entities.Data;
using Unity.Properties;

namespace KammelnaOffline.Tarneeb;

public class TarneebGameController : OfflineGameController
{
	protected override OfflinePlayer CreatePlayer(int index)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OfflinePlayer offlinePlayer = default(OfflinePlayer);
		offlinePlayer..ctor(index);
		return offlinePlayer;
	}

	protected override AbstractAiLogic CreateAiLogic()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3824;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		return (AbstractAiLogic)obj2;
	}

	protected override PlayingManager CreatePlayingManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayingManager playingManager = default(PlayingManager);
		playingManager..ctor();
		object obj2 = playingManager + 16;
		obj2 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return playingManager;
	}

	protected override BiddingManager CreateBiddingManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3832;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		return (BiddingManager)obj2;
	}

	protected override int CardValue(Card card)
	{
		//IL_0035: Expected I4, but got O
		if (card != null)
		{
			return (int)card.<Suit>k__BackingField;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	protected override void OnStartRound()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_079f: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_00d0: Expected O, but got I
		//IL_0122: Expected O, but got I
		//IL_015d: Expected O, but got I
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01f2: Expected O, but got I
		//IL_020a: Expected I, but got O
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_039c: Expected I, but got O
		//IL_041a: Expected O, but got I4
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_052b: Expected O, but got I4
		//IL_0593: Expected I, but got O
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		//IL_0724: Expected I, but got O
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 3840;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<Card> allTarneebCards = TarneebCardUtils.AllTarneebCards;
		List<object> array = Enumerable.ToList((IEnumerable<object>)allTarneebCards);
		List<object> list = ArraysExtensions.Shuffle(array);
		object obj4 = this + 104;
		obj4 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X20_v4+10]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X20_v4+10]");
		if ((nint)0 != 0 && obj4 != null)
		{
			object obj6 = (nint)0 + (nint)2696;
			List<object> range = ((List<object>)obj4).GetRange(0, 13);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v4+20]");
				object obj7 = (nint)0 + (nint)24;
				obj7 = range;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (obj4 != null)
				{
					object obj8 = (nint)0 + (nint)2720;
					((List<object>)obj4).RemoveRange(0, 13);
					OfflinePlayer[] players = Players;
					if (Players != null)
					{
						OfflinePlayer offlinePlayer = players[0];
						if (players[0] != null)
						{
							object obj9 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3280;
							object obj10 = (nint)0 + (nint)1752;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							Comparison<object> comparison = default(Comparison<object>);
							comparison..ctor((object)this, (IntPtr)obj10);
							if (offlinePlayer.<Cards>k__BackingField != null)
							{
								((List<object>)(object)offlinePlayer.<Cards>k__BackingField).Sort(comparison);
								OfflinePlayer[] players2 = Players;
								if (Players != null && obj4 != null)
								{
									List<object> range2 = ((List<object>)obj4).GetRange(0, 13);
									if (players2[1] != null)
									{
										object obj11 = players2[1] + 24;
										obj11 = range2;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										if (obj4 != null)
										{
											((List<object>)obj4).RemoveRange(0, 13);
											OfflinePlayer[] players3 = Players;
											if (Players != null)
											{
												OfflinePlayer offlinePlayer2 = players3[1];
												if (players3[1] != null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													Comparison<object> comparison2 = default(Comparison<object>);
													comparison2..ctor((object)this, (IntPtr)obj10);
													if (offlinePlayer2.<Cards>k__BackingField != null)
													{
														((List<object>)(object)offlinePlayer2.<Cards>k__BackingField).Sort(comparison2);
														OfflinePlayer[] players4 = Players;
														if (Players != null)
														{
															bool flag2 = players4.Length < 3;
															object obj12 = !flag2;
															object obj13 = ~obj12;
															if (obj13 != null)
															{
																goto IL_076c;
															}
															if (obj4 != null)
															{
																List<object> range3 = ((List<object>)obj4).GetRange(0, 13);
																if (players4[2] != null)
																{
																	object obj14 = players4[2] + 24;
																	obj14 = range3;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																	if (obj4 != null)
																	{
																		((List<object>)obj4).RemoveRange(0, 13);
																		OfflinePlayer[] players5 = Players;
																		if (Players != null)
																		{
																			bool flag3 = players5.Length < 3;
																			object obj15 = !flag3;
																			object obj16 = ~obj15;
																			if (obj16 != null)
																			{
																				goto IL_076c;
																			}
																			OfflinePlayer offlinePlayer3 = players5[2];
																			if (players5[2] != null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																				Comparison<object> comparison3 = default(Comparison<object>);
																				comparison3..ctor((object)this, (IntPtr)obj10);
																				if (offlinePlayer3.<Cards>k__BackingField != null)
																				{
																					((List<object>)(object)offlinePlayer3.<Cards>k__BackingField).Sort(comparison3);
																					OfflinePlayer[] players6 = Players;
																					if (Players != null && obj4 != null)
																					{
																						List<object> range4 = ((List<object>)obj4).GetRange(0, 13);
																						if (players6[3] != null)
																						{
																							object obj17 = players6[3] + 24;
																							obj17 = range4;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																							if (obj4 != null)
																							{
																								((List<object>)obj4).RemoveRange(0, 13);
																								OfflinePlayer[] players7 = Players;
																								if (Players != null)
																								{
																									OfflinePlayer offlinePlayer4 = players7[3];
																									if (players7[3] != null)
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																										Comparison<object> comparison4 = default(Comparison<object>);
																										comparison4..ctor((object)this, (IntPtr)obj10);
																										if (offlinePlayer4.<Cards>k__BackingField != null)
																										{
																											((List<object>)(object)offlinePlayer4.<Cards>k__BackingField).Sort(comparison4);
																											return;
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_076c;
		IL_076c:
		throw new IndexOutOfRangeException();
	}

	public override int GetOfflineValue(Card card)
	{
		//IL_0035: Expected I4, but got O
		if (card != null)
		{
			return (int)card.<Suit>k__BackingField;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	protected override bool IsGameOver()
	{
		//IL_0038: Expected O, but got I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected I4, but got Unknown
		//IL_00aa: Expected O, but got I4
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected I4, but got Unknown
		if (Team1TotalScore > 30)
		{
			return true;
		}
		object obj = Team2TotalScore - 30;
		bool flag = (nint)obj < 0;
		bool flag2 = obj == null;
		int num = Team2TotalScore ^ 0x1E;
		int num2 = Team2TotalScore ^ obj;
		int num3 = num & num2;
		bool flag3 = num3 < 0;
		bool flag4 = flag == flag3;
		object obj2 = !flag2;
		return (byte)((flag4 & obj2) ? 1 : 0) != 0;
	}

	protected override void OnEndRound()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		throw new OutOfMemoryException();
	}

	protected override int GetEatingPlayer()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		//IL_005f: Expected I4, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (int)ex2;
	}

	protected override List<Card> GetPlayableCards(bool firstMove)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (List<Card>)(object)new OutOfMemoryException();
	}

	protected override string GetBiddingFromSfsParam(ISFSObject param)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0042: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		NotImplementedException ex = default(NotImplementedException);
		ex..ctor();
		object obj2 = (nint)0 + (nint)360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (string)(object)new OutOfMemoryException();
	}

	public TarneebGameController()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 1944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = this + 64;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((object)this)..ctor();
	}
}
