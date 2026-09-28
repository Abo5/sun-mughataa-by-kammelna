using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class TournamentSeparateCupPrizeUi : TournamentSeparatePrizeUi
{
	private PrizeLabel verticalPrize1;

	private PrizeLabel verticalPrize2;

	private PrizeLabel verticalPrize3;

	private GameObject verticalPrizes;

	private Image trophy;

	private GameObject prizeTrophy;

	public override void Initialize(TournamentData tournament)
	{
		//IL_0a0b: Expected I4, but got O
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_060e: Expected O, but got I4
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected I4, but got Unknown
		//IL_01a2: Expected O, but got I4
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected I4, but got Unknown
		//IL_0698: Expected I, but got O
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected O, but got Unknown
		//IL_0755: Expected I4, but got O
		//IL_0280: Expected O, but got I4
		//IL_0292: Expected I4, but got O
		//IL_07cf: Expected O, but got I8
		//IL_076b: Expected I, but got O
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Expected O, but got Unknown
		//IL_0878: Expected I4, but got O
		//IL_02d7: Expected O, but got I4
		//IL_0921: Expected O, but got I4
		//IL_0931: Expected O, but got I4
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected O, but got Unknown
		//IL_0896: Expected I, but got O
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected O, but got Unknown
		//IL_03a4: Expected O, but got I4
		//IL_032c: Expected I, but got O
		//IL_035e: Expected O, but got I4
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got Unknown
		//IL_03f5: Expected I4, but got O
		//IL_03ff: Expected I4, but got O
		//IL_0487: Expected O, but got I8
		//IL_049f: Expected O, but got I4
		//IL_0415: Expected I, but got O
		//IL_0447: Expected O, but got I4
		//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_050b: Expected O, but got I4
		//IL_0514: Expected O, but got I4
		//IL_0541: Expected O, but got I4
		//IL_0563: Expected I4, but got O
		bool flag = (object)verticalPrizes == null;
		IntPtr intPtr = default(IntPtr);
		int num = (int)(nint)intPtr;
		bool flag2 = (byte)(int)tournament != 0;
		PrizeLabel prizeLabel;
		PrizeLabel[] array2;
		object obj8;
		Action<bool> action2;
		PrizeLabel prizeLabel2;
		int num6;
		bool flag24;
		PrizeLabel[] array3;
		object obj3 = default(object);
		Action<bool> action = default(Action<bool>);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			verticalPrizes.SetActive(value: false);
			bool flag3 = (object)horizontalPrizes == null;
			num = 0;
			flag2 = false;
			if (!flag3)
			{
				horizontalPrizes.SetActive(value: false);
				bool flag4 = (object)prizeTrophy == null;
				num = 0;
				flag2 = false;
				if (!flag4)
				{
					prizeTrophy.SetActive(value: false);
					bool flag5 = tournament == null;
					num = 0;
					flag2 = false;
					if (!flag5)
					{
						object obj = typeof(SqlSingle[]) + 1544;
						ChampionshipTournamentAddon tournamentAddonsChampionship = tournament.TournamentAddonsChampionship;
						if (tournamentAddonsChampionship != null)
						{
							int totalPrize = tournament.TotalPrize;
							bool flag6 = (object)verticalPrizes == null;
							num = 0;
							flag2 = false;
							if (!flag6)
							{
								bool flag7 = totalPrize < 0;
								bool flag8 = totalPrize == 0;
								int num2 = totalPrize ^ totalPrize;
								int num3 = totalPrize & num2;
								bool flag9 = num3 < 0;
								bool flag10 = flag7 == flag9;
								object obj2 = !flag8;
								bool active = (byte)((flag10 & obj2) ? 1 : 0) != 0;
								verticalPrizes.SetActive(active);
								ChampionshipTournamentAddon tournamentAddonsChampionship2 = tournament.TournamentAddonsChampionship;
								bool flag11 = tournamentAddonsChampionship2 == null;
								num = 0;
								flag2 = false;
								if (!flag11)
								{
									ChampionshipTournamentAddon tournamentAddonsChampionship3 = tournament.TournamentAddonsChampionship;
									bool flag12 = tournamentAddonsChampionship3 == null;
									num = 0;
									flag2 = false;
									if (!flag12)
									{
										num = tournamentAddonsChampionship3.<levelId>k__BackingField;
										UIExtensions.LoadAchievementImage(trophy, tournamentAddonsChampionship2.<trophyName>k__BackingField, tournamentAddonsChampionship3.<levelId>k__BackingField);
										bool flag13 = (object)prizeTrophy == null;
										obj3 = 0;
										action = null;
										flag2 = (byte)(int)tournamentAddonsChampionship2.<trophyName>k__BackingField != 0;
										if (!flag13)
										{
											prizeTrophy.SetActive(value: true);
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
											PrizeLabel[] array = default(PrizeLabel[]);
											bool flag14 = array == null;
											obj3 = 0;
											action = null;
											num = 0;
											flag2 = true;
											if (!flag14)
											{
												bool flag15 = verticalPrize1 == null;
												bool flag16 = true;
												if (!flag15)
												{
													nint num4 = (nint)array;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v20 (Il2CppClass<PrizeLabel[]>)+40]");
													flag16 = false;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
													bool flag17 = ex == null;
													obj3 = 0;
													action = null;
													num = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v20 (Il2CppClass<PrizeLabel[]>)+40]");
													flag2 = false;
													if (flag17)
													{
														goto IL_09d4;
													}
												}
												bool flag18 = array.Length == 0;
												obj3 = 0;
												action = null;
												num = 0;
												flag2 = flag16;
												if (!flag18)
												{
													object obj4 = array + 32;
													obj4 = verticalPrize1;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
													bool flag19 = (byte)(int)(~verticalPrize2) != 0;
													bool flag20 = (byte)(int)verticalPrize1 != 0;
													if (!flag19)
													{
														nint num5 = (nint)array;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v19 (Il2CppClass<PrizeLabel[]>)+40]");
														flag20 = false;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
														bool flag21 = ex == null;
														obj3 = 0;
														action = null;
														num = 0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v19 (Il2CppClass<PrizeLabel[]>)+40]");
														flag2 = false;
														if (flag21)
														{
															goto IL_09d4;
														}
													}
													object obj5 = array.Length & 0xFFFFFFFEL;
													bool flag22 = obj5 == null;
													obj3 = 0;
													action = null;
													num = 0;
													flag2 = flag20;
													if (!flag22)
													{
														object obj6 = array + 40;
														obj6 = verticalPrize2;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														prizeLabel = verticalPrize3;
														bool flag23 = verticalPrize3 == null;
														object obj7 = !flag23;
														obj3 = 0;
														action = null;
														num = 0;
														array2 = array;
														if (obj7 != null)
														{
															goto IL_088e;
														}
														obj8 = 0;
														action2 = null;
														prizeLabel2 = verticalPrize3;
														num6 = 0;
														flag24 = (byte)(int)verticalPrize2 != 0;
														array3 = array;
														goto IL_0905;
													}
												}
												goto IL_09c6;
											}
										}
									}
								}
							}
						}
						else
						{
							int totalPrize2 = tournament.TotalPrize;
							bool flag25 = (object)horizontalPrizes == null;
							num = 0;
							flag2 = false;
							if (!flag25)
							{
								bool flag26 = totalPrize2 < 0;
								bool flag27 = totalPrize2 == 0;
								int num7 = totalPrize2 ^ totalPrize2;
								int num8 = totalPrize2 & num7;
								bool flag28 = num8 < 0;
								bool flag29 = flag26 == flag28;
								object obj9 = !flag27;
								bool active2 = (byte)((flag29 & obj9) ? 1 : 0) != 0;
								horizontalPrizes.SetActive(active2);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
								PrizeLabel[] array4 = default(PrizeLabel[]);
								bool flag30 = array4 == null;
								num = 0;
								flag2 = true;
								if (!flag30)
								{
									bool flag31 = horizontalPrize1 == null;
									bool flag32 = true;
									if (!flag31)
									{
										nint num9 = (nint)array4;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v14 (Il2CppClass<PrizeLabel[]>)+40]");
										flag32 = false;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag33 = ex == null;
										num = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v14 (Il2CppClass<PrizeLabel[]>)+40]");
										flag2 = false;
										if (flag33)
										{
											goto IL_09d4;
										}
									}
									bool flag34 = array4.Length == 0;
									num = 0;
									flag2 = flag32;
									if (!flag34)
									{
										object obj10 = array4 + 32;
										obj10 = horizontalPrize1;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										bool flag35 = horizontalPrize2 == null;
										bool flag36 = (byte)(int)horizontalPrize1 != 0;
										if (!flag35)
										{
											nint num10 = (nint)array4;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v13 (Il2CppClass<PrizeLabel[]>)+40]");
											flag36 = false;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag37 = ex == null;
											num = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v13 (Il2CppClass<PrizeLabel[]>)+40]");
											flag2 = false;
											if (flag37)
											{
												goto IL_09d4;
											}
										}
										object obj11 = array4.Length & 0xFFFFFFFEL;
										bool flag38 = obj11 == null;
										num = 0;
										flag2 = flag36;
										if (!flag38)
										{
											object obj12 = array4 + 40;
											obj12 = horizontalPrize2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											prizeLabel = horizontalPrize3;
											bool flag39 = horizontalPrize3 == null;
											num = 0;
											array2 = array4;
											obj8 = obj3;
											action2 = action;
											prizeLabel2 = horizontalPrize3;
											num6 = 0;
											flag24 = (byte)(int)horizontalPrize2 != 0;
											array3 = array4;
											if (!flag39)
											{
												goto IL_088e;
											}
											goto IL_0905;
										}
									}
									goto IL_09c6;
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_09c6;
		IL_0905:
		bool flag40 = array3.Length < 2;
		object obj13 = !flag40;
		object obj14 = array3.Length - 2;
		bool flag41 = obj14 == null;
		object obj15 = ~obj13;
		object obj16 = obj15 | flag41;
		obj3 = obj8;
		action = action2;
		num = num6;
		flag2 = flag24;
		if (obj16 == null)
		{
			object obj17 = array3 + 48;
			obj17 = prizeLabel2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			InitializePrizes(array3, tournament);
			return;
		}
		goto IL_09c6;
		IL_09d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_088e:
		nint num11 = (nint)array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v8 (Il2CppClass<PrizeLabel[]>)+40]");
		flag24 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag42 = ex == null;
		obj8 = obj3;
		action2 = action;
		prizeLabel2 = prizeLabel;
		num6 = num;
		array3 = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v8 (Il2CppClass<PrizeLabel[]>)+40]");
		flag2 = false;
		if (!flag42)
		{
			goto IL_0905;
		}
		goto IL_09d4;
		IL_09c6:
		ex = new IndexOutOfRangeException();
		goto IL_09d4;
	}

	private void ResetPrizes()
	{
		verticalPrizes.SetActive(value: false);
		horizontalPrizes.SetActive(value: false);
		prizeTrophy.SetActive(value: false);
	}
}
