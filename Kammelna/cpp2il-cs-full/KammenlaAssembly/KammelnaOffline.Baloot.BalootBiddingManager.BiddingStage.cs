using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using GoogleMobileAds.Api.AdManager;
using HuaweiMobileServices.Location.Location;
using KammelnaOffline.Common;
using Sfs2X.Entities.Data;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;

namespace KammelnaOffline.Baloot;

public class BalootBiddingManager : BiddingManager
{
	public enum BiddingStage
	{
		Awal,
		Thany,
		Doubling,
		Waraq
	}

	private enum BiddingState
	{
		Pass,
		AnySun,
		BeforeSun,
		Hokom2
	}

	private enum BiddingCase
	{
		NextBidder,
		BeforeSun,
		AnySun,
		AnyDouble,
		Double,
		Triple,
		Hokom2
	}

	private sealed class <>c__DisplayClass17_0
	{
		public int bidderIndex;

		internal bool <GetNextBidding>b__0(int val)
		{
			//IL_000f: Expected O, but got I4
			object obj = val - bidderIndex;
			bool flag = obj == null;
			return !flag;
		}

		internal bool <GetNextBidding>b__1(int val)
		{
			//IL_000f: Expected O, but got I4
			object obj = val - bidderIndex;
			bool flag = obj == null;
			return !flag;
		}

		internal bool <GetNextBidding>b__2(int val)
		{
			//IL_000f: Expected O, but got I4
			object obj = val - bidderIndex;
			bool flag = obj == null;
			return !flag;
		}

		internal bool <GetNextBidding>b__3(int val)
		{
			//IL_000f: Expected O, but got I4
			object obj = val - bidderIndex;
			bool flag = obj == null;
			return !flag;
		}

		internal bool <GetNextBidding>b__4(int val)
		{
			//IL_000f: Expected O, but got I4
			object obj = val - bidderIndex;
			bool flag = obj == null;
			return !flag;
		}

		internal bool <GetNextBidding>b__5(int val)
		{
			//IL_000f: Expected O, but got I4
			object obj = val - bidderIndex;
			bool flag = obj == null;
			return !flag;
		}

		internal bool <GetNextBidding>b__6(int val)
		{
			//IL_000f: Expected O, but got I4
			object obj = val - bidderIndex;
			bool flag = obj == null;
			return !flag;
		}

		internal bool <GetNextBidding>b__7(int val)
		{
			//IL_000f: Expected O, but got I4
			object obj = val - bidderIndex;
			bool flag = obj == null;
			return !flag;
		}
	}

	private BalootGameController _gameController;

	public BiddingStage biddingStage;

	private BiddingState biddingState;

	private Suit floorCardSuit;

	private readonly int dealer;

	public Suit HokomSuit;

	public BalootGame.BalootGameMode BiddingResult;

	public bool IsHokomClose;

	public BalootGame.BalootExtraGameMode DoubleType;

	public int FloorCardPlayer
	{
		get
		{
			//IL_003c: Expected O, but got I4
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Expected O, but got Unknown
			//IL_008d: Unsupported input type for neg.
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected I4, but got Unknown
			//IL_00aa: Expected O, but got I4
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Expected O, but got Unknown
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Expected I4, but got Unknown
			int result = base.<Bidder>k__BackingField;
			if (BiddingResult == BalootGame.BalootGameMode.Ashkal)
			{
				object obj = -base.<Bidder>k__BackingField;
				object obj2 = obj & 3;
				int num = base.<Bidder>k__BackingField & 3;
				int num2 = ((0 >= base.<Bidder>k__BackingField) ? (0 - obj2) : num);
				object obj3 = num2 + 1;
				object obj4 = obj3 >> 13;
				object obj5 = obj4 & 3;
				object obj6 = obj3 + obj5;
				object obj7 = obj6 & 0xFC;
				object obj8 = obj3 - obj7;
				int num3 = obj8 + 1;
				result = num3;
			}
			return result;
		}
	}

	private int FloorCardFactor
	{
		get
		{
			//IL_0026: Expected O, but got I4
			//IL_0036: Expected O, but got I4
			//IL_0050: Expected O, but got I4
			//IL_007a: Expected O, but got I4
			Suit suit = floorCardSuit;
			bool flag = floorCardSuit < Suit.DIAMONDS;
			object obj = !flag;
			object obj2 = floorCardSuit - 3;
			bool flag2 = obj2 == null;
			object obj3 = !flag2;
			object obj4 = obj & obj3;
			if (obj4 == null)
			{
				object obj5 = 117170176 + 944;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X9_v2+v0 @ X8_v1 (Suit)*4]");
				return 0;
			}
			return 0;
		}
	}

	public BalootBiddingManager(BalootGameController gameController)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 24;
		obj = gameController;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v1+10]");
		dealer = 0;
	}

	public override int[] GetNextBidding(int bidderIndex, string bidName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_00ad: Expected O, but got I
		//IL_07f9: Expected O, but got I4
		//IL_064a: Expected O, but got I4
		//IL_0664: Expected O, but got I4
		//IL_0119: Expected O, but got I4
		//IL_0827: Unknown result type (might be due to invalid IL or missing references)
		//IL_082c: Expected O, but got Unknown
		//IL_0842: Expected O, but got I
		//IL_2074: Expected O, but got I4
		//IL_0689: Expected O, but got I4
		//IL_098f: Expected O, but got I4
		//IL_17c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ce: Expected O, but got Unknown
		//IL_17d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_17dd: Expected O, but got Unknown
		//IL_2014: Expected I, but got O
		//IL_0b0d: Expected O, but got I4
		//IL_14fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1501: Expected O, but got Unknown
		//IL_1517: Expected O, but got I
		//IL_1528: Expected I, but got O
		//IL_088e: Expected O, but got I4
		//IL_089c: Expected O, but got I4
		//IL_0873: Expected O, but got I4
		//IL_05d5: Expected O, but got I8
		//IL_20a0: Expected O, but got I
		//IL_0b3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b40: Expected O, but got Unknown
		//IL_0b56: Expected O, but got I
		//IL_0b67: Expected I, but got O
		//IL_050b: Expected O, but got I4
		//IL_156d: Expected O, but got I4
		//IL_0d32: Expected O, but got I4
		//IL_0d4c: Expected O, but got I4
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Expected O, but got Unknown
		//IL_08ee: Expected O, but got I4
		//IL_1842: Unknown result type (might be due to invalid IL or missing references)
		//IL_1847: Expected O, but got Unknown
		//IL_1851: Unknown result type (might be due to invalid IL or missing references)
		//IL_1856: Expected O, but got Unknown
		//IL_11ec: Expected O, but got I4
		//IL_0fa5: Expected O, but got I4
		//IL_0192: Expected O, but got I4
		//IL_1583: Unknown result type (might be due to invalid IL or missing references)
		//IL_1588: Expected O, but got Unknown
		//IL_0bac: Expected O, but got I4
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_0554: Expected O, but got I
		//IL_0d63: Expected O, but got I4
		//IL_0eed: Expected O, but got I4
		//IL_02bd: Expected O, but got I4
		//IL_02d7: Expected O, but got I4
		//IL_0720: Expected O, but got I4
		//IL_073a: Expected O, but got I4
		//IL_189f: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a4: Expected O, but got Unknown
		//IL_1196: Expected O, but got I4
		//IL_1222: Unknown result type (might be due to invalid IL or missing references)
		//IL_1227: Expected O, but got Unknown
		//IL_123d: Expected O, but got I
		//IL_124e: Expected I, but got O
		//IL_0fd3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd8: Expected O, but got Unknown
		//IL_0fee: Expected O, but got I
		//IL_0fff: Expected I, but got O
		//IL_136b: Expected O, but got I4
		//IL_0308: Expected O, but got I4
		//IL_1283: Expected O, but got I
		//IL_12a7: Expected O, but got I4
		//IL_12b0: Expected O, but got I4
		//IL_1049: Expected O, but got I
		//IL_224b: Expected O, but got I8
		//IL_1a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a20: Expected O, but got Unknown
		//IL_1a36: Expected O, but got I
		//IL_1a47: Expected I, but got O
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_0377: Expected O, but got I
		//IL_0388: Expected I, but got O
		//IL_107e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1083: Expected O, but got Unknown
		//IL_1a91: Expected O, but got I
		//IL_22a0: Expected O, but got I4
		//IL_03d2: Expected O, but got I
		//IL_1ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1acb: Expected O, but got Unknown
		//IL_1ad4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad9: Expected O, but got Unknown
		//IL_21b4: Expected O, but got I8
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Expected O, but got Unknown
		//IL_22d7: Expected I4, but got O
		//IL_22f5: Expected O, but got I8
		//IL_1b4a: Expected O, but got I4
		//IL_2416: Expected I4, but got O
		//IL_2434: Expected O, but got I8
		//IL_1d21: Expected O, but got I4
		//IL_2388: Expected O, but got I4
		//IL_1fc8: Expected I4, but got O
		//IL_1fe6: Expected O, but got I8
		//IL_1ba9: Expected O, but got I4
		//IL_2463: Expected I4, but got O
		//IL_2489: Expected O, but got I4
		//IL_1b7e: Expected O, but got I4
		//IL_1d80: Expected O, but got I4
		//IL_23bf: Expected I4, but got O
		//IL_23dd: Expected O, but got I8
		//IL_253c: Expected I4, but got O
		//IL_2562: Expected O, but got I4
		//IL_1d55: Expected O, but got I4
		//IL_1bfc: Expected O, but got I4
		//IL_19f6: Expected O, but got I4
		//IL_24b8: Expected I4, but got O
		//IL_24c0: Expected I4, but got O
		//IL_24de: Expected O, but got I8
		//IL_1bd7: Expected O, but got I4
		//IL_1dd3: Expected O, but got I4
		//IL_19c3: Expected O, but got I4
		//IL_2591: Expected I4, but got O
		//IL_2599: Expected I4, but got O
		//IL_25b7: Expected O, but got I8
		//IL_1dae: Expected O, but got I4
		//IL_1c5b: Expected O, but got I4
		//IL_250d: Expected I4, but got O
		//IL_1c30: Expected O, but got I4
		//IL_1e32: Expected O, but got I4
		//IL_25e6: Expected I4, but got O
		//IL_1e07: Expected O, but got I4
		//IL_1c7c: Expected O, but got I4
		//IL_1c85: Expected O, but got I4
		//IL_1e51: Expected O, but got I4
		//IL_1cab: Expected O, but got I4
		//IL_1cc6: Expected O, but got I4
		//IL_1e9b: Expected O, but got I4
		//IL_1eab: Expected O, but got I4
		//IL_1ec5: Expected O, but got I4
		//IL_1f0d: Expected O, but got I4
		//IL_1ce3: Expected O, but got I4
		//IL_2613: Expected O, but got I4
		//IL_262e: Expected O, but got I4
		//IL_1eef: Expected O, but got I4
		//IL_1eff: Expected O, but got I
		//IL_1f2b: Expected O, but got I4
		object obj = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 2568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object fldHandle;
		Array array = default(Array);
		Array result;
		int lastBidderIndex;
		bool doubleType;
		bool isHokomClose;
		object obj91;
		int[] array14;
		int lastBidderIndex3;
		BiddingCase bCase;
		BalootGame.BalootExtraGameMode doubleType2;
		object obj98;
		Func<int, bool> predicate;
		Func<int, bool> func6 = default(Func<int, bool>);
		int[] source6;
		object obj5;
		int[] array13;
		Suit suit;
		BiddingCase biddingCase;
		BiddingState biddingState2;
		if (obj2 != null)
		{
			object obj3 = (nint)0 + (nint)1688;
			object obj4 = typeof(TypeConverter<ushort, char>) + 3048;
			fldHandle = (nint)0 + (nint)1696;
			obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D71ADC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)fldHandle);
			BalootGameController gameController = _gameController;
			if (_gameController != null)
			{
				object obj6 = (nint)0 + (nint)1320;
				int[] array2 = Enumerable.ToArray(gameController.Bidders);
				BiddingState biddingState = default(BiddingState);
				if (biddingStage != BiddingStage.Doubling)
				{
					if (biddingStage != BiddingStage.Thany)
					{
						bool flag = biddingStage == BiddingStage.Awal;
						object obj7 = !flag;
						biddingCase = BiddingCase.NextBidder;
						result = array;
						if (obj7 == null)
						{
							if (this.biddingState != BiddingState.BeforeSun)
							{
								if (this.biddingState != BiddingState.AnySun)
								{
									bool flag2 = this.biddingState == BiddingState.Pass;
									object obj8 = !flag2;
									biddingCase = BiddingCase.NextBidder;
									result = array;
									if (obj8 == null)
									{
										if (biddingState > BiddingState.BeforeSun)
										{
											if (biddingState == (BiddingState)7)
											{
												this.biddingState = BiddingState.AnySun;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
												lastBidderIndex = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
												base.<Bidder>k__BackingField = 0;
												HokomSuit = floorCardSuit;
												BiddingResult = BalootGame.BalootGameMode.Hokom;
												biddingCase = BiddingCase.AnySun;
												goto IL_21fc;
											}
											if (biddingState == (BiddingState)12)
											{
												goto IL_0f09;
											}
											biddingCase = BiddingCase.NextBidder;
											result = array;
										}
										else
										{
											if (biddingState == BiddingState.Pass)
											{
												BalootGameController gameController2 = _gameController;
												if (_gameController == null)
												{
													goto IL_1f41;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
												lastBidderIndex = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
												if ((nint)0 == gameController2.Dealer)
												{
													biddingStage = BiddingStage.Thany;
													biddingState2 = (BiddingState)19;
												}
												else
												{
													biddingState2 = BiddingState.Pass;
												}
												goto IL_21ee;
											}
											bool flag3 = biddingState != BiddingState.BeforeSun;
											biddingCase = BiddingCase.NextBidder;
											result = array;
											if (!flag3)
											{
												this.biddingState = biddingState;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
												lastBidderIndex = 0;
												goto IL_20cf;
											}
										}
									}
								}
								else if (biddingState <= (BiddingState)7)
								{
									object obj9 = biddingState - 2;
									bool flag4 = (nint)obj9 < 3;
									object obj10 = !flag4;
									if (obj10 == null)
									{
										goto IL_0748;
									}
									bool flag5 = biddingState == BiddingState.Pass;
									object obj11 = !flag5;
									biddingCase = BiddingCase.NextBidder;
									result = array;
									if (obj11 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
										if ((nint)0 == base.<Bidder>k__BackingField)
										{
											goto IL_13b3;
										}
										object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										object obj13 = (nint)0 + (nint)664;
										Func<int, bool> func = default(Func<int, bool>);
										func..ctor(obj2, (IntPtr)obj13);
										IEnumerable<int> source = Enumerable.Where(array2, func);
										int[] array3 = Enumerable.ToArray(source);
										int[] array4 = BiddingStates(base.<Bidder>k__BackingField, BiddingCase.AnySun);
										object obj14 = (nint)0 + (nint)3232;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
										if (array4 != null)
										{
											object obj15 = array4 + 32;
											object obj17 = default(object);
											object obj16 = obj17 & 1;
											object obj18;
											if (obj16 != null)
											{
												if (array4.Length == 0)
												{
													goto IL_1f4f;
												}
												obj18 = obj15;
											}
											else
											{
												if (array4.Length == 0)
												{
													goto IL_1f4f;
												}
												obj18 = 3;
											}
											array4[0] = (int)obj18;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
											object obj19 = array4.Length & 0xFFFFFFFEL;
											object obj20 = default(object);
											object obj21;
											if (obj20 != null)
											{
												if (obj19 == null)
												{
													goto IL_1f4f;
												}
												obj21 = array4[1];
											}
											else
											{
												if (obj19 == null)
												{
													goto IL_1f4f;
												}
												obj21 = 3;
											}
											array4[1] = (int)obj21;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
											bool flag6 = array4.Length < 3;
											object obj22 = !flag6;
											object obj23 = default(object);
											object obj25;
											if (obj23 != null)
											{
												object obj24 = ~obj22;
												if (obj24 != null)
												{
													goto IL_1f4f;
												}
												obj25 = array4[2];
											}
											else
											{
												object obj26 = ~obj22;
												if (obj26 != null)
												{
													goto IL_1f4f;
												}
												obj25 = 3;
											}
											array4[2] = (int)obj25;
											biddingCase = (BiddingCase)obj14;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
											object obj27 = array4.Length & 0xFFFFFFFCL;
											object obj28 = default(object);
											object obj29;
											if (obj28 != null)
											{
												if (obj27 == null)
												{
													goto IL_1f4f;
												}
												obj29 = array4[3];
											}
											else
											{
												if (obj27 == null)
												{
													goto IL_1f4f;
												}
												obj29 = 3;
											}
											array4[3] = (int)obj29;
											if (array3 != null)
											{
												bool flag7 = array3.Length == 0;
												object obj30 = !flag7;
												obj5 = 0;
												result = array4;
												if (obj30 != null)
												{
													goto IL_1e67;
												}
												object obj31 = base.<Bidder>k__BackingField - 1;
												bool flag8 = (nint)obj31 < array4.Length;
												object obj32 = !flag8;
												if (obj32 != null)
												{
													goto IL_1f4f;
												}
												_ = 7;
												obj5 = 0;
												biddingState2 = BiddingState.Pass;
												result = array4;
												goto IL_1f8d;
											}
										}
										goto IL_1f41;
									}
								}
								else
								{
									if (biddingState == (BiddingState)8)
									{
										biddingStage = BiddingStage.Doubling;
										IsHokomClose = true;
										doubleType = true;
										goto IL_2328;
									}
									if (biddingState == (BiddingState)12)
									{
										goto IL_0f09;
									}
									bool flag9 = biddingState != (BiddingState)14;
									biddingCase = BiddingCase.NextBidder;
									result = array;
									if (!flag9)
									{
										biddingStage = BiddingStage.Doubling;
										IsHokomClose = false;
										goto IL_20ee;
									}
								}
							}
							else
							{
								object obj33 = (int)biddingState >> 1;
								object obj34 = (int)biddingState << 31;
								object obj35 = obj33 | obj34;
								if ((nint)obj35 <= 4)
								{
									object obj36 = obj35 - 1;
									bool flag10 = (nint)obj36 < 2;
									object obj37 = !flag10;
									if (obj37 == null)
									{
										this.biddingState = BiddingState.BeforeSun;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
										base.<Bidder>k__BackingField = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DD520]");
										suit = Suit.SPADES;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DD520]");
										HokomSuit = Suit.SPADES;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
										int[] array5 = BiddingStates(0, BiddingCase.BeforeSun);
										biddingCase = BiddingCase.BeforeSun;
										biddingState2 = (BiddingState)4;
										result = array5;
									}
									else
									{
										bool flag11 = obj35 == null;
										object obj38 = !flag11;
										biddingCase = BiddingCase.NextBidder;
										result = array;
										if (obj38 == null)
										{
											object obj39 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											object obj40 = (nint)0 + (nint)672;
											Func<int, bool> func2 = default(Func<int, bool>);
											func2..ctor(obj2, (IntPtr)obj40);
											IEnumerable<int> source2 = Enumerable.Where(array2, func2);
											int[] array6 = Enumerable.ToArray(source2);
											int[] array7 = BiddingStates(base.<Bidder>k__BackingField, BiddingCase.BeforeSun);
											object obj41 = (nint)0 + (nint)3232;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
											if (array7 == null)
											{
												goto IL_1f41;
											}
											object obj43 = default(object);
											object obj42 = obj43 & 1;
											int num;
											if (obj42 != null)
											{
												if (array7.Length == 0)
												{
													goto IL_1f4f;
												}
												num = array7[0];
											}
											else
											{
												if (array7.Length == 0)
												{
													goto IL_1f4f;
												}
												num = 3;
											}
											array7[0] = num;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
											object obj44 = array7.Length & 0xFFFFFFFEL;
											object obj45 = default(object);
											int num2;
											if (obj45 != null)
											{
												if (obj44 == null)
												{
													goto IL_1f4f;
												}
												num2 = array7[1];
											}
											else
											{
												if (obj44 == null)
												{
													goto IL_1f4f;
												}
												num2 = 3;
											}
											array7[1] = num2;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
											bool flag12 = array7.Length < 3;
											object obj46 = !flag12;
											object obj47 = default(object);
											int num3;
											if (obj47 != null)
											{
												object obj48 = ~obj46;
												if (obj48 != null)
												{
													goto IL_1f4f;
												}
												num3 = array7[2];
											}
											else
											{
												object obj49 = ~obj46;
												if (obj49 != null)
												{
													goto IL_1f4f;
												}
												num3 = 3;
											}
											array7[2] = num3;
											biddingCase = (BiddingCase)obj41;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
											object obj50 = array7.Length & 0xFFFFFFFCL;
											object obj51 = default(object);
											if (obj51 != null)
											{
												if (obj50 == null)
												{
													goto IL_1f4f;
												}
												int num4 = array7[3];
												obj5 = 0;
												result = array7;
											}
											else
											{
												if (obj50 == null)
												{
													goto IL_1f4f;
												}
												obj5 = 0;
												int num4 = 3;
												result = array7;
											}
										}
									}
								}
								else if ((nint)obj35 != 5)
								{
									bool flag13 = (nint)obj35 != 6;
									biddingCase = BiddingCase.NextBidder;
									result = array;
									if (!flag13)
									{
										this.biddingState = BiddingState.BeforeSun;
										biddingCase = BiddingCase.NextBidder;
										biddingState2 = (BiddingState)12;
										result = array;
									}
								}
								else
								{
									DoubleType = BalootGame.BalootExtraGameMode.Double;
									biddingCase = BiddingCase.NextBidder;
									biddingState2 = (BiddingState)10;
									result = array;
								}
							}
						}
					}
					else if (this.biddingState <= BiddingState.AnySun)
					{
						if (this.biddingState != BiddingState.Pass)
						{
							bool flag14 = this.biddingState != BiddingState.AnySun;
							biddingCase = BiddingCase.NextBidder;
							result = array;
							if (!flag14)
							{
								if (biddingState > (BiddingState)7)
								{
									if (biddingState != (BiddingState)8)
									{
										if (biddingState == (BiddingState)12)
										{
											goto IL_0f09;
										}
										bool flag15 = biddingState != (BiddingState)14;
										biddingCase = BiddingCase.NextBidder;
										result = array;
										if (flag15)
										{
											goto IL_1f8d;
										}
									}
									biddingStage = BiddingStage.Doubling;
									object obj52 = biddingState - 8;
									bool flag16 = obj52 == null;
									isHokomClose = flag16;
									goto IL_213b;
								}
								object obj53 = biddingState - 2;
								bool flag17 = (nint)obj53 < 3;
								object obj54 = !flag17;
								object obj55 = ~obj54;
								if (obj55 != null)
								{
									goto IL_0748;
								}
								bool flag18 = biddingState == BiddingState.Pass;
								object obj56 = !flag18;
								biddingCase = BiddingCase.NextBidder;
								result = array;
								if (obj56 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
									if ((nint)0 == base.<Bidder>k__BackingField)
									{
										goto IL_13b3;
									}
									object obj57 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj58 = (nint)0 + (nint)680;
									Func<int, bool> func3 = default(Func<int, bool>);
									func3..ctor(obj2, (IntPtr)obj58);
									IEnumerable<int> source3 = Enumerable.Where(array2, func3);
									int[] array8 = Enumerable.ToArray(source3);
									int[] array9 = BiddingStates(base.<Bidder>k__BackingField, BiddingCase.AnySun);
									object obj59 = (nint)0 + (nint)3232;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
									if (array9 != null)
									{
										object obj60 = array9 + 32;
										object obj62 = default(object);
										object obj61 = obj62 & 1;
										object obj63;
										if (obj61 != null)
										{
											if (array9.Length == 0)
											{
												goto IL_1f4f;
											}
											obj63 = obj60;
										}
										else
										{
											if (array9.Length == 0)
											{
												goto IL_1f4f;
											}
											obj63 = 3;
										}
										array9[0] = (int)obj63;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
										object obj64 = array9.Length & 0xFFFFFFFEL;
										object obj65 = default(object);
										object obj66;
										if (obj65 != null)
										{
											if (obj64 == null)
											{
												goto IL_1f4f;
											}
											obj66 = array9[1];
										}
										else
										{
											if (obj64 == null)
											{
												goto IL_1f4f;
											}
											obj66 = 3;
										}
										array9[1] = (int)obj66;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
										bool flag19 = array9.Length < 3;
										object obj67 = !flag19;
										object obj68 = default(object);
										object obj70;
										if (obj68 != null)
										{
											object obj69 = ~obj67;
											if (obj69 != null)
											{
												goto IL_1f4f;
											}
											obj70 = array9[2];
										}
										else
										{
											object obj71 = ~obj67;
											if (obj71 != null)
											{
												goto IL_1f4f;
											}
											obj70 = 3;
										}
										array9[2] = (int)obj70;
										biddingCase = (BiddingCase)obj59;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
										object obj72 = array9.Length & 0xFFFFFFFCL;
										object obj73 = default(object);
										object obj74;
										if (obj73 != null)
										{
											if (obj72 == null)
											{
												goto IL_1f4f;
											}
											obj74 = array9[3];
										}
										else
										{
											if (obj72 == null)
											{
												goto IL_1f4f;
											}
											obj74 = 3;
										}
										array9[3] = (int)obj74;
										if (array8 != null)
										{
											bool flag20 = array8.Length == 0;
											obj5 = 0;
											result = array9;
											if (!flag20)
											{
												goto IL_1e67;
											}
											Suit suit2 = floorCardSuit;
											bool flag21 = floorCardSuit < Suit.DIAMONDS;
											object obj75 = !flag21;
											object obj76 = floorCardSuit - 3;
											bool flag22 = obj76 == null;
											object obj77 = !flag22;
											object obj78 = obj75 & obj77;
											if (obj78 == null)
											{
												object obj79 = 119877632 + 1232;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1846 @ X10_v10+v1834 @ X9_v26 (Suit)*4]");
												object obj80 = 0;
											}
											else
											{
												object obj80 = 20;
											}
											object obj81 = base.<Bidder>k__BackingField - 1;
											bool flag23 = (nint)obj81 < array9.Length;
											object obj82 = !flag23;
											if (obj82 != null)
											{
												goto IL_1f4f;
											}
											this.biddingState = BiddingState.Hokom2;
											obj5 = 0;
											biddingState2 = BiddingState.Pass;
											result = array9;
											goto IL_1f8d;
										}
									}
									goto IL_1f41;
								}
							}
						}
						else
						{
							bool flag24 = biddingState < BiddingState.BeforeSun;
							object obj83 = !flag24;
							if (biddingState > BiddingState.BeforeSun)
							{
								if (biddingState != (BiddingState)7 && biddingState != (BiddingState)9)
								{
									bool flag25 = biddingState != (BiddingState)12;
									biddingCase = BiddingCase.NextBidder;
									result = array;
									if (!flag25)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
										base.<Bidder>k__BackingField = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [713A330]");
										suit = Suit.SPADES;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [713A330]");
										HokomSuit = Suit.SPADES;
										biddingCase = BiddingCase.NextBidder;
										result = array;
									}
								}
								else
								{
									this.biddingState = BiddingState.Hokom2;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
									int[] array10 = BiddingStates(0, BiddingCase.Hokom2);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
									base.<Bidder>k__BackingField = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DF8B0]");
									suit = Suit.SPADES;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DF8B0]");
									HokomSuit = Suit.SPADES;
									biddingCase = BiddingCase.Hokom2;
									biddingState2 = (BiddingState)9;
									result = array10;
								}
							}
							else
							{
								object obj84 = ~obj83;
								if (obj84 != null)
								{
									BalootGameController gameController3 = _gameController;
									if (_gameController == null)
									{
										goto IL_1f41;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
									lastBidderIndex = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
									if ((nint)0 == gameController3.Dealer)
									{
										biddingStage = BiddingStage.Waraq;
										biddingState2 = (BiddingState)20;
									}
									else
									{
										biddingState2 = BiddingState.AnySun;
									}
									goto IL_21ee;
								}
								bool flag26 = biddingState != BiddingState.BeforeSun;
								biddingCase = BiddingCase.NextBidder;
								result = array;
								if (!flag26)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
									base.<Bidder>k__BackingField = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DD520]");
									suit = Suit.SPADES;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DD520]");
									HokomSuit = Suit.SPADES;
									biddingCase = BiddingCase.NextBidder;
									result = array;
								}
							}
						}
					}
					else if (this.biddingState != BiddingState.BeforeSun)
					{
						bool flag27 = this.biddingState != BiddingState.Hokom2;
						biddingCase = BiddingCase.NextBidder;
						biddingState2 = biddingState;
						result = array;
						if (!flag27)
						{
							object obj85 = (long)biddingState & 0xFFFFFFFEL;
							int lastBidderIndex2;
							if ((nint)obj85 == 2)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
								lastBidderIndex2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
								if ((nint)0 == base.<Bidder>k__BackingField)
								{
									biddingState2 = BiddingState.Hokom2;
								}
								else
								{
									this.biddingState = BiddingState.BeforeSun;
									biddingState2 = BiddingState.BeforeSun;
								}
								base.<Bidder>k__BackingField = lastBidderIndex2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DD520]");
								suit = Suit.SPADES;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DD520]");
								HokomSuit = Suit.SPADES;
							}
							else
							{
								object obj86 = biddingState - 15;
								bool flag28 = (nint)obj86 < 4;
								object obj87 = !flag28;
								if (obj87 != null)
								{
									int[] array11 = BiddingStates(base.<Bidder>k__BackingField, BiddingCase.AnyDouble);
									bool flag29 = biddingState == BiddingState.Pass;
									object obj88 = !flag29;
									biddingCase = BiddingCase.AnyDouble;
									biddingState2 = biddingState;
									result = array11;
									if (obj88 == null)
									{
										object obj89 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										object obj90 = (nint)0 + (nint)688;
										Func<int, bool> func4 = default(Func<int, bool>);
										func4..ctor(obj2, (IntPtr)obj90);
										IEnumerable<int> source4 = Enumerable.Where(array2, func4);
										int[] array12 = Enumerable.ToArray(source4);
										obj91 = (nint)0 + (nint)3232;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
										bool flag30 = array11 == null;
										object obj92 = !flag30;
										obj5 = 0;
										array13 = array12;
										array14 = array11;
										if (obj92 != null)
										{
											goto IL_157a;
										}
										goto IL_1f41;
									}
									goto IL_21d1;
								}
								object obj93 = 117170176;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1376 @ X9_v21+v1257 @ X8_v93*4]");
								HokomSuit = Suit.SPADES;
								lastBidderIndex2 = base.<Bidder>k__BackingField;
								biddingState2 = biddingState;
							}
							int[] array15 = BiddingStates(lastBidderIndex2, BiddingCase.AnyDouble);
							biddingCase = BiddingCase.AnyDouble;
							result = array15;
							goto IL_21d1;
						}
					}
					else if (biddingState > BiddingState.BeforeSun)
					{
						if (biddingState != (BiddingState)10)
						{
							bool flag31 = biddingState != (BiddingState)12;
							biddingCase = BiddingCase.NextBidder;
							result = array;
							if (!flag31)
							{
								this.biddingState = BiddingState.BeforeSun;
								biddingCase = BiddingCase.NextBidder;
								result = array;
							}
						}
						else
						{
							DoubleType = BalootGame.BalootExtraGameMode.Double;
							biddingCase = BiddingCase.NextBidder;
							result = array;
						}
					}
					else
					{
						if (biddingState == BiddingState.Pass)
						{
							object obj94 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj95 = (nint)0 + (nint)696;
							Func<int, bool> func5 = default(Func<int, bool>);
							func5..ctor(obj2, (IntPtr)obj95);
							IEnumerable<int> source5 = Enumerable.Where(array2, func5);
							int[] array16 = Enumerable.ToArray(source5);
							lastBidderIndex3 = base.<Bidder>k__BackingField;
							bCase = BiddingCase.BeforeSun;
							obj5 = 0;
							array13 = array16;
							goto IL_2082;
						}
						if (biddingState == BiddingState.BeforeSun)
						{
							biddingState2 = (BiddingState)4;
						}
						biddingCase = BiddingCase.NextBidder;
						result = array;
					}
				}
				else if (DoubleType != BalootGame.BalootExtraGameMode.Four)
				{
					if (DoubleType != BalootGame.BalootExtraGameMode.Triple)
					{
						bool flag32 = DoubleType != BalootGame.BalootExtraGameMode.Double;
						biddingCase = BiddingCase.NextBidder;
						result = array;
						if (!flag32)
						{
							if (biddingState == (BiddingState)5)
							{
								doubleType2 = BalootGame.BalootExtraGameMode.Triple;
								goto IL_2162;
							}
							bool flag33 = biddingState == BiddingState.Pass;
							object obj96 = !flag33;
							biddingCase = BiddingCase.NextBidder;
							result = array;
							if (obj96 == null)
							{
								object obj97 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								obj98 = (nint)0 + (nint)704;
								predicate = func6;
								source6 = array2;
								goto IL_2003;
							}
						}
					}
					else
					{
						object obj99 = biddingState - 14;
						bool flag34 = obj99 == null;
						object obj100 = !flag34;
						object obj101 = ~obj100;
						bool flag35;
						if (obj101 == null)
						{
							object obj102 = biddingState - 8;
							flag35 = obj102 == null;
						}
						else
						{
							flag35 = true;
						}
						object obj103 = !flag35;
						if (obj103 == null)
						{
							DoubleType = BalootGame.BalootExtraGameMode.Four;
							IsHokomClose = false;
							int[] array17 = BiddingStates(base.<Bidder>k__BackingField, BiddingCase.Double);
							biddingCase = BiddingCase.Double;
							biddingState2 = (BiddingState)11;
							result = array17;
						}
						else
						{
							bool flag36 = biddingState == BiddingState.Pass;
							object obj104 = !flag36;
							biddingCase = BiddingCase.NextBidder;
							result = array;
							if (obj104 == null)
							{
								object obj105 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj106 = (nint)0 + (nint)712;
								Func<int, bool> func7 = default(Func<int, bool>);
								func7..ctor(obj2, (IntPtr)obj106);
								IEnumerable<int> source7 = Enumerable.Where(array2, func7);
								int[] array18 = Enumerable.ToArray(source7);
								lastBidderIndex3 = base.<Bidder>k__BackingField;
								bCase = BiddingCase.Triple;
								obj5 = 0;
								array13 = array18;
								goto IL_2082;
							}
						}
					}
				}
				else
				{
					if (biddingState == (BiddingState)6)
					{
						IsHokomClose = true;
						doubleType2 = BalootGame.BalootExtraGameMode.Qahwa;
						goto IL_2162;
					}
					bool flag37 = biddingState == BiddingState.Pass;
					object obj107 = !flag37;
					biddingCase = BiddingCase.NextBidder;
					result = array;
					if (obj107 == null)
					{
						object obj108 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						obj98 = (nint)0 + (nint)720;
						predicate = func6;
						source6 = array2;
						goto IL_2003;
					}
				}
				goto IL_1f8d;
			}
		}
		goto IL_1f41;
		IL_157a:
		object obj110 = default(object);
		object obj109 = obj110 & 1;
		int num5;
		if (obj109 != null)
		{
			if (array14.Length == 0)
			{
				goto IL_1f4f;
			}
			num5 = array14[0];
		}
		else
		{
			if (array14.Length == 0)
			{
				goto IL_1f4f;
			}
			num5 = 3;
		}
		array14[0] = num5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
		object obj111 = array14.Length & 0xFFFFFFFEL;
		object obj112 = default(object);
		int num6;
		if (obj112 != null)
		{
			if (obj111 == null)
			{
				goto IL_1f4f;
			}
			num6 = array14[1];
		}
		else
		{
			if (obj111 == null)
			{
				goto IL_1f4f;
			}
			num6 = 3;
		}
		array14[1] = num6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
		bool flag38 = array14.Length < 3;
		object obj113 = !flag38;
		object obj114 = default(object);
		int num7;
		if (obj114 != null)
		{
			object obj115 = ~obj113;
			if (obj115 != null)
			{
				goto IL_1f4f;
			}
			num7 = array14[2];
		}
		else
		{
			object obj116 = ~obj113;
			if (obj116 != null)
			{
				goto IL_1f4f;
			}
			num7 = 3;
		}
		array14[2] = num7;
		biddingCase = (BiddingCase)obj91;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
		object obj117 = array14.Length & 0xFFFFFFFCL;
		object obj118 = default(object);
		if (obj118 != null)
		{
			if (obj117 == null)
			{
				goto IL_1f4f;
			}
			int num4 = array14[3];
		}
		else
		{
			if (obj117 == null)
			{
				goto IL_1f4f;
			}
			int num4 = 3;
		}
		biddingState2 = BiddingState.Pass;
		result = array14;
		goto IL_1f8d;
		IL_214a:
		HokomSuit = suit;
		biddingCase = BiddingCase.BeforeSun;
		goto IL_21fc;
		IL_2003:
		func6..ctor(obj2, (IntPtr)obj98);
		IEnumerable<int> source8 = Enumerable.Where(source6, predicate);
		int[] array19 = Enumerable.ToArray(source8);
		lastBidderIndex3 = base.<Bidder>k__BackingField;
		bCase = BiddingCase.Double;
		obj5 = 0;
		array13 = array19;
		goto IL_2082;
		IL_21fc:
		int[] array20 = BiddingStates(lastBidderIndex, biddingCase);
		result = array20;
		goto IL_1f8d;
		IL_1f41:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1f4f;
		IL_20cf:
		base.<Bidder>k__BackingField = lastBidderIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DD520]");
		suit = Suit.SPADES;
		goto IL_214a;
		IL_2082:
		int[] array21 = BiddingStates(lastBidderIndex3, bCase);
		obj91 = (nint)0 + (nint)3232;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D96058");
		bool flag39 = array21 == null;
		array14 = array21;
		if (!flag39)
		{
			goto IL_157a;
		}
		goto IL_1f41;
		IL_0f09:
		this.biddingState = BiddingState.BeforeSun;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
		lastBidderIndex = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
		base.<Bidder>k__BackingField = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [713A330]");
		suit = Suit.SPADES;
		goto IL_214a;
		IL_2328:
		DoubleType = (doubleType ? BalootGame.BalootExtraGameMode.Double : BalootGame.BalootExtraGameMode.NotDetermined);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
		lastBidderIndex = 0;
		biddingCase = BiddingCase.Double;
		goto IL_21fc;
		IL_21ee:
		biddingCase = BiddingCase.NextBidder;
		goto IL_21fc;
		IL_1e67:
		biddingState2 = BiddingState.Pass;
		goto IL_1f8d;
		IL_21d1:
		if (biddingState2 != (BiddingState)8 && biddingState2 != (BiddingState)14)
		{
			goto IL_1f8d;
		}
		object obj119 = biddingState2 - 8;
		bool flag40 = obj119 == null;
		biddingStage = BiddingStage.Doubling;
		isHokomClose = flag40;
		goto IL_213b;
		IL_13b3:
		biddingCase = BiddingCase.NextBidder;
		biddingState2 = (BiddingState)13;
		result = array;
		goto IL_1f8d;
		IL_0748:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
		lastBidderIndex = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
		if ((nint)0 == base.<Bidder>k__BackingField)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DD520]");
			suit = Suit.SPADES;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [70DD520]");
			HokomSuit = Suit.SPADES;
			biddingCase = BiddingCase.NextBidder;
			biddingState2 = BiddingState.Hokom2;
			result = array;
			goto IL_1f8d;
		}
		this.biddingState = BiddingState.BeforeSun;
		biddingState2 = BiddingState.BeforeSun;
		goto IL_20cf;
		IL_1f8d:
		BalootGameController gameController4 = _gameController;
		if (_gameController != null)
		{
			object obj120 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1960;
			object key = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 1488;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			SFSExtensions.Put(gameController4.LastAction, (string)key, friendlyName);
			BalootGameController gameController5 = _gameController;
			if (_gameController != null)
			{
				object key2 = "___# Content push apply failed [{0}]: {1}" + 3152;
				object val = "___# Content push apply failed [{0}]: {1}" + 2656;
				SFSExtensions.Put(gameController5.LastAction, (string)key2, (string)val);
				BalootGameController gameController6 = _gameController;
				if (_gameController != null)
				{
					object key3 = "alignContent" + 680;
					ISFSObject lastAction = gameController6.LastAction;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3 (System.Object)+10]");
					SFSExtensions.Put(lastAction, (string)key3, 0);
					if (biddingStage == BiddingStage.Waraq)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						Array array22 = default(Array);
						RuntimeHelpers.InitializeArray(array22, (RuntimeFieldHandle)fldHandle);
						result = array22;
					}
					return (int[])result;
				}
			}
		}
		goto IL_1f41;
		IL_1f4f:
		return (int[])(object)new IndexOutOfRangeException();
		IL_213b:
		IsHokomClose = isHokomClose;
		goto IL_20ee;
		IL_20ee:
		doubleType = true;
		goto IL_2328;
		IL_2162:
		DoubleType = doubleType2;
		lastBidderIndex = base.<Bidder>k__BackingField;
		biddingCase = BiddingCase.Triple;
		goto IL_21fc;
	}

	private int[] BiddingStates(int LastBidderIndex, BiddingCase bCase)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0030: Expected O, but got I
		//IL_0709: Expected O, but got I4
		//IL_0b9a: Expected O, but got I4
		//IL_0baa: Expected O, but got I4
		//IL_0a6b: Expected I4, but got I8
		//IL_2685: Expected I4, but got I8
		//IL_269f: Expected O, but got I4
		//IL_26a8: Expected O, but got I4
		//IL_074a: Expected O, but got I4
		//IL_0753: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected O, but got Unknown
		//IL_0c25: Expected O, but got I4
		//IL_1849: Expected I4, but got I8
		//IL_0797: Unsupported input type for neg.
		//IL_0797: Unknown result type (might be due to invalid IL or missing references)
		//IL_079c: Expected I4, but got Unknown
		//IL_2bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc8: Expected O, but got Unknown
		//IL_022f: Expected O, but got I4
		//IL_0ca5: Expected O, but got I4
		//IL_0cb2: Expected O, but got I4
		//IL_0cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Expected O, but got Unknown
		//IL_0d11: Expected O, but got I4
		//IL_0eb2: Expected O, but got I4
		//IL_19f4: Expected O, but got I4
		//IL_026b: Expected O, but got I4
		//IL_32cb: Expected O, but got I4
		//IL_0ea4: Expected O, but got I4
		//IL_0923: Expected I4, but got I8
		//IL_2fa0: Expected O, but got I4
		//IL_2fae: Expected O, but got I4
		//IL_2fce: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fd3: Expected O, but got Unknown
		//IL_19e6: Expected O, but got I4
		//IL_1b5f: Expected O, but got I4
		//IL_07b1: Expected O, but got I4
		//IL_07db: Expected O, but got I4
		//IL_2be3: Expected O, but got I4
		//IL_2bec: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bf1: Expected O, but got Unknown
		//IL_2bfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bff: Expected O, but got Unknown
		//IL_2c08: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c0d: Expected O, but got Unknown
		//IL_0d2c: Unsupported input type for neg.
		//IL_0d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Expected O, but got Unknown
		//IL_025d: Expected O, but got I4
		//IL_337a: Expected O, but got I4
		//IL_0d4c: Unsupported input type for neg.
		//IL_0d4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d51: Expected O, but got Unknown
		//IL_0287: Expected O, but got I4
		//IL_11fe: Expected O, but got I4
		//IL_1a3c: Expected O, but got I4
		//IL_2abd: Expected O, but got I4
		//IL_0800: Expected O, but got I4
		//IL_2c54: Expected O, but got I4
		//IL_0279: Expected O, but got I4
		//IL_182b: Expected O, but got I4
		//IL_0b17: Expected O, but got I4
		//IL_0b27: Expected O, but got I4
		//IL_0b41: Expected O, but got I4
		//IL_0619: Expected O, but got I4
		//IL_010d: Expected O, but got I4
		//IL_011d: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		//IL_1f97: Expected I4, but got I8
		//IL_204e: Expected I4, but got I8
		//IL_0d6d: Expected O, but got I4
		//IL_2f61: Expected I4, but got I8
		//IL_181d: Expected O, but got I4
		//IL_1340: Expected I4, but got I8
		//IL_2660: Expected O, but got I4
		//IL_060b: Expected O, but got I4
		//IL_0989: Expected O, but got I4
		//IL_1b7b: Expected O, but got I4
		//IL_1ef3: Expected O, but got I4
		//IL_1f01: Expected O, but got I4
		//IL_1f21: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f26: Expected O, but got Unknown
		//IL_0d5f: Expected O, but got I4
		//IL_2823: Expected O, but got I4
		//IL_029a: Expected O, but got I4
		//IL_2bac: Expected O, but got I4
		//IL_0b6b: Expected O, but got I4
		//IL_0b7b: Expected O, but got I
		//IL_13c7: Expected O, but got I4
		//IL_0161: Expected O, but got I4
		//IL_0171: Expected O, but got I
		//IL_18f5: Expected O, but got I4
		//IL_1905: Expected O, but got I4
		//IL_191f: Expected O, but got I4
		//IL_2c98: Expected O, but got I4
		//IL_2ca1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca6: Expected O, but got Unknown
		//IL_02d3: Expected O, but got I4
		//IL_1366: Expected O, but got I4
		//IL_13b9: Expected O, but got I4
		//IL_26d5: Expected O, but got I4
		//IL_26e3: Expected O, but got I4
		//IL_26fd: Expected O, but got I4
		//IL_2713: Expected O, but got I4
		//IL_0d91: Unsupported input type for neg.
		//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d96: Expected I4, but got Unknown
		//IL_0d7b: Expected O, but got I4
		//IL_02c5: Expected O, but got I4
		//IL_15d9: Expected O, but got I4
		//IL_144b: Expected O, but got I4
		//IL_145b: Expected O, but got I4
		//IL_1475: Expected O, but got I4
		//IL_1c05: Expected I4, but got I8
		//IL_1949: Expected O, but got I4
		//IL_1959: Expected O, but got I
		//IL_1973: Expected O, but got I4
		//IL_1981: Expected O, but got I4
		//IL_199b: Expected O, but got I4
		//IL_08ba: Expected O, but got I4
		//IL_2cdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ce2: Expected O, but got Unknown
		//IL_2d33: Expected O, but got I4
		//IL_20cc: Expected O, but got I4
		//IL_09c7: Expected I4, but got I8
		//IL_2ef6: Expected I4, but got I8
		//IL_2f10: Expected O, but got I4
		//IL_15cb: Expected O, but got I4
		//IL_1d33: Expected O, but got I4
		//IL_1adc: Expected O, but got I4
		//IL_1aec: Expected O, but got I4
		//IL_1b06: Expected O, but got I4
		//IL_14ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ef: Expected I4, but got Unknown
		//IL_0865: Expected O, but got I4
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected O, but got Unknown
		//IL_128b: Expected O, but got I4
		//IL_129b: Expected O, but got I4
		//IL_12b5: Expected O, but got I4
		//IL_20be: Expected O, but got I4
		//IL_2ea3: Expected I4, but got I8
		//IL_149f: Expected O, but got I4
		//IL_14af: Expected O, but got I
		//IL_1c2b: Expected O, but got I4
		//IL_272f: Expected O, but got I4
		//IL_14d4: Expected O, but got I4
		//IL_0d9f: Unsupported input type for neg.
		//IL_0d9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da4: Expected O, but got Unknown
		//IL_02ee: Expected O, but got I4
		//IL_1d90: Expected O, but got I4
		//IL_1bee: Expected O, but got I4
		//IL_2ff3: Expected I4, but got I8
		//IL_1b30: Expected O, but got I4
		//IL_1b40: Expected O, but got I
		//IL_0c58: Expected O, but got I4
		//IL_0c66: Expected O, but got I4
		//IL_12df: Expected O, but got I4
		//IL_12ef: Expected O, but got I
		//IL_1301: Expected I4, but got I8
		//IL_131b: Expected O, but got I4
		//IL_2090: Expected O, but got I4
		//IL_1be0: Expected O, but got I4
		//IL_1587: Expected O, but got I4
		//IL_0dc5: Expected O, but got I4
		//IL_0dce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd3: Expected O, but got Unknown
		//IL_0a2d: Expected O, but got I4
		//IL_1db0: Expected O, but got I4
		//IL_1d71: Expected O, but got I4
		//IL_1619: Unknown result type (might be due to invalid IL or missing references)
		//IL_161e: Expected I4, but got Unknown
		//IL_1532: Expected O, but got I4
		//IL_153f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1544: Expected O, but got Unknown
		//IL_22cc: Expected O, but got I4
		//IL_2082: Expected O, but got I4
		//IL_1d20: Expected O, but got I4
		//IL_1c78: Expected O, but got I4
		//IL_1c88: Expected O, but got I4
		//IL_1ca2: Expected O, but got I4
		//IL_1d63: Expected O, but got I4
		//IL_1603: Expected O, but got I4
		//IL_037f: Expected O, but got I4
		//IL_22be: Expected O, but got I4
		//IL_3094: Expected O, but got I4
		//IL_30a2: Expected O, but got I4
		//IL_30bc: Expected O, but got I4
		//IL_1d12: Expected O, but got I4
		//IL_1ff9: Expected O, but got I4
		//IL_28bc: Expected O, but got I4
		//IL_28c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ce: Expected O, but got Unknown
		//IL_0371: Expected O, but got I4
		//IL_3063: Expected O, but got I4
		//IL_1ccc: Expected O, but got I4
		//IL_1cdc: Expected O, but got I
		//IL_16b6: Expected O, but got I4
		//IL_0e30: Expected O, but got I4
		//IL_039b: Expected O, but got I4
		//IL_226a: Expected I4, but got I8
		//IL_06e8: Expected O, but got I4
		//IL_1e78: Expected I4, but got I8
		//IL_16ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1704: Expected I4, but got Unknown
		//IL_1661: Expected O, but got I4
		//IL_166e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1673: Expected O, but got Unknown
		//IL_038d: Expected O, but got I4
		//IL_1dfd: Expected O, but got I4
		//IL_1e0d: Expected O, but got I4
		//IL_1e27: Expected O, but got I4
		//IL_16e9: Expected O, but got I4
		//IL_24da: Expected O, but got I4
		//IL_2290: Expected O, but got I4
		//IL_222d: Expected I4, but got I8
		//IL_21d8: Expected O, but got I4
		//IL_2037: Expected O, but got I4
		//IL_2919: Expected O, but got I4
		//IL_24cc: Expected O, but got I4
		//IL_312a: Expected I4, but got I8
		//IL_1e51: Expected O, but got I4
		//IL_1e61: Expected O, but got I
		//IL_2029: Expected O, but got I4
		//IL_03d9: Expected O, but got I4
		//IL_2253: Expected O, but got I4
		//IL_03cb: Expected O, but got I4
		//IL_247e: Expected O, but got I4
		//IL_21a4: Expected I4, but got I8
		//IL_2216: Expected O, but got I4
		//IL_249e: Expected O, but got I4
		//IL_2415: Expected O, but got I4
		//IL_2423: Expected O, but got I4
		//IL_2443: Unknown result type (might be due to invalid IL or missing references)
		//IL_2448: Expected O, but got Unknown
		//IL_21ca: Expected O, but got I4
		//IL_31e3: Expected I4, but got O
		//IL_2208: Expected O, but got I4
		//IL_03f4: Expected O, but got I4
		//IL_245f: Expected O, but got I4
		//IL_262c: Expected I4, but got I8
		//IL_23ac: Expected O, but got I4
		//IL_23ba: Expected O, but got I4
		//IL_23da: Unknown result type (might be due to invalid IL or missing references)
		//IL_23df: Expected O, but got Unknown
		//IL_0f56: Expected O, but got I4
		//IL_0f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f68: Expected O, but got Unknown
		//IL_25ef: Expected I4, but got I8
		//IL_23f6: Expected O, but got I4
		//IL_0f9f: Expected O, but got I4
		//IL_0f91: Expected O, but got I4
		//IL_04b7: Expected O, but got I4
		//IL_044f: Expected O, but got I8
		//IL_04a9: Expected O, but got I4
		//IL_25b2: Expected I4, but got I8
		//IL_2d91: Expected O, but got I4
		//IL_0fb2: Expected O, but got I4
		//IL_04d2: Expected O, but got I4
		//IL_0feb: Expected O, but got I4
		//IL_0fdd: Expected O, but got I4
		//IL_103c: Expected O, but got I4
		//IL_108f: Expected O, but got I4
		//IL_109c: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a1: Expected O, but got Unknown
		//IL_2e07: Expected O, but got I4
		//IL_116c: Expected O, but got I8
		//IL_1186: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8091]");
		int num = 0;
		object obj = typeof(TypeConverter<ushort, char>) + 3048;
		object fldHandle = (nint)0 + (nint)1696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Array array = default(Array);
		RuntimeHelpers.InitializeArray(array, (RuntimeFieldHandle)fldHandle);
		int num2;
		int num11;
		BalootGame.BalootExtraGameMode doubleType;
		BalootGame.BalootExtraGameMode doubleType2;
		int num13;
		int num16;
		int num26;
		object obj92;
		if (bCase > BiddingCase.AnySun)
		{
			if (bCase <= BiddingCase.Double)
			{
				if (bCase != BiddingCase.AnyDouble)
				{
					if (bCase != BiddingCase.Double)
					{
						goto IL_054e;
					}
					num = base.<Bidder>k__BackingField;
					if (base.<Bidder>k__BackingField == 1)
					{
						num = (int)biddingStage;
						if (biddingStage == BiddingStage.Thany)
						{
							num = (int)floorCardSuit;
							bool flag = floorCardSuit < Suit.DIAMONDS;
							object obj2 = !flag;
							object obj3 = floorCardSuit - 3;
							bool flag2 = obj3 == null;
							object obj4 = !flag2;
							object obj5 = obj2 & obj4;
							object obj7;
							if (obj5 == null)
							{
								object obj6 = 117170176 + 944;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1348 @ X10_v113+v670 @ X8_v3 (System.Int32)*4]");
								obj7 = 0;
							}
							else
							{
								obj7 = 0;
							}
							if (array == null)
							{
								goto IL_2665;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
							num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
							if ((nint)0 != 0)
							{
								object obj8 = ((DoubleType != BalootGame.BalootExtraGameMode.Four) ? ((object)30) : ((object)40));
								object obj9 = obj7 + obj8;
								bool flag3 = base.<Bidder>k__BackingField == 2;
								num = num2;
								if (flag3)
								{
									goto IL_1403;
								}
								goto IL_1bf3;
							}
						}
						else
						{
							if (array == null)
							{
								goto IL_2665;
							}
							if (DoubleType == BalootGame.BalootExtraGameMode.Four)
							{
								object obj10 = 5 + 1;
							}
							else
							{
								object obj10 = 5;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
							num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
							if ((nint)0 != 0)
							{
								bool flag4 = base.<Bidder>k__BackingField != 2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
								num = 0;
								if (!flag4)
								{
									goto IL_1403;
								}
								goto IL_1bf3;
							}
						}
					}
					else
					{
						if (array == null)
						{
							goto IL_2665;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
						num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
						if ((nint)0 != 0)
						{
							_ = 3;
							if (base.<Bidder>k__BackingField == 2)
							{
								goto IL_1403;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
							num = 0;
							goto IL_1bf3;
						}
					}
				}
				else
				{
					if (array == null)
					{
						goto IL_2665;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
					if ((nint)0 != 0)
					{
						int num3 = (int)(base.<Bidder>k__BackingField & 0x80000001L);
						if (num3 == 1)
						{
							int num4 = 3;
						}
						else
						{
							int num4 = 25;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
						if ((nint)0 != 1)
						{
							int num5 = base.<Bidder>k__BackingField & 1;
							bool flag5 = num5 == 0;
							object obj11 = !flag5;
							if (obj11 == null)
							{
								int num6 = 3;
							}
							else
							{
								int num6 = 25;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
							if ((nint)0 != 2)
							{
								int num7 = (int)(base.<Bidder>k__BackingField & 0x80000001L);
								if (num7 == 1)
								{
									int num8 = 3;
								}
								else
								{
									int num8 = 25;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
								if ((nint)0 != 3)
								{
									int num9 = base.<Bidder>k__BackingField & 1;
									bool flag6 = num9 == 0;
									object obj12 = !flag6;
									if (obj12 == null)
									{
										num = 3;
									}
									else
									{
										num = 25;
									}
									goto IL_2e52;
								}
							}
						}
					}
				}
				goto IL_273e;
			}
			if (bCase != BiddingCase.Triple)
			{
				if (bCase != BiddingCase.Hokom2)
				{
					goto IL_054e;
				}
				if (array != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
					if ((nint)0 == 0)
					{
						goto IL_273e;
					}
					if (LastBidderIndex == 1)
					{
						object obj13 = 21;
					}
					else
					{
						object obj13 = 3;
					}
					if (LastBidderIndex != 1)
					{
						goto IL_2a49;
					}
					BalootGameController gameController = _gameController;
					if (_gameController != null)
					{
						Card floorCard = gameController.FloorCard;
						if (gameController.FloorCard != null)
						{
							if (floorCard.<Suit>k__BackingField != Suit.SPADES)
							{
								if (floorCard.<Suit>k__BackingField != Suit.HEARTS)
								{
									if (floorCard.<Suit>k__BackingField == Suit.DIAMONDS)
									{
										object obj14 = 22;
									}
								}
								else
								{
									object obj14 = 23;
								}
							}
							else
							{
								object obj14 = 24;
							}
							goto IL_2a49;
						}
					}
				}
			}
			else
			{
				int num10 = (int)(base.<Bidder>k__BackingField & 0x80000001L);
				if (num10 == 1)
				{
					if (base.<Bidder>k__BackingField == 1 && biddingStage == BiddingStage.Thany)
					{
						if (DoubleType == BalootGame.BalootExtraGameMode.Qahwa)
						{
							num = (int)floorCardSuit;
							bool flag7 = floorCardSuit < Suit.DIAMONDS;
							object obj15 = !flag7;
							object obj16 = floorCardSuit - 3;
							bool flag8 = obj16 == null;
							object obj17 = !flag8;
							object obj18 = obj15 & obj17;
							if (obj18 == null)
							{
								object obj19 = 119877632 + 1248;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1498 @ X9_v84+v670 @ X8_v3 (System.Int32)*4]");
								object obj20 = 0;
							}
							else
							{
								object obj20 = 50;
							}
							bool flag9 = array == null;
							object obj21 = !flag9;
							if (obj21 != null)
							{
								goto IL_3299;
							}
						}
						else
						{
							bool flag10 = array == null;
							num = (int)DoubleType;
							if (!flag10)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
								if ((nint)0 != 0)
								{
									_ = 3;
									num11 = base.<Bidder>k__BackingField;
									doubleType = DoubleType;
									int num12 = base.<Bidder>k__BackingField & 1;
									bool flag11 = num12 == 0;
									doubleType2 = DoubleType;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
									num13 = 0;
									if (flag11)
									{
										goto IL_1203;
									}
									goto IL_17f4;
								}
								goto IL_273e;
							}
						}
					}
					else
					{
						bool flag12 = array == null;
						num = (int)DoubleType;
						if (!flag12)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
							num = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
							if ((nint)0 == 0)
							{
								goto IL_273e;
							}
							object obj20 = 3;
							goto IL_3337;
						}
					}
				}
				else
				{
					bool flag13 = array == null;
					num = (int)DoubleType;
					if (!flag13)
					{
						if (DoubleType == BalootGame.BalootExtraGameMode.Qahwa)
						{
							object obj20 = 3;
						}
						else
						{
							object obj20 = 14;
						}
						goto IL_3299;
					}
				}
			}
		}
		else if (bCase != BiddingCase.NextBidder)
		{
			if (bCase != BiddingCase.BeforeSun)
			{
				if (bCase != BiddingCase.AnySun)
				{
					goto IL_054e;
				}
				num = LastBidderIndex & 1;
				bool flag14 = LastBidderIndex < 0;
				int num14 = LastBidderIndex ^ LastBidderIndex;
				int num15 = LastBidderIndex & num14;
				bool flag15 = num15 < 0;
				bool flag16 = flag14 == flag15;
				object obj22 = !flag16;
				object obj23 = ~obj22;
				if (obj23 == null)
				{
					num = -num;
				}
				num16 = dealer;
				object obj24 = ((num != 1) ? ((object)8) : ((object)17));
				int num17 = num16 & 3;
				object obj25 = ((num17 != 2) ? ((object)9) : ((object)15));
				bool flag17;
				if (num17 == 2)
				{
					object obj26 = num - 1;
					flag17 = obj26 == null;
				}
				else
				{
					flag17 = false;
				}
				object obj27 = !flag17;
				if (obj27 == null)
				{
					object obj28 = 17;
				}
				else
				{
					object obj28 = 8;
				}
				if (num16 == 1)
				{
					object obj28 = obj24;
				}
				object obj29 = ((num16 != 1) ? obj25 : ((object)15));
				if (num != 1)
				{
					object obj28 = obj29;
				}
				if (LastBidderIndex != 1)
				{
					if (array == null)
					{
						goto IL_2665;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
					if ((nint)0 == 0)
					{
						goto IL_273e;
					}
					num16 = dealer;
				}
				object obj30 = ((num != 0) ? ((object)8) : ((object)17));
				object obj31 = num16 + 2;
				object obj32 = obj31 & 0x80000003L;
				object obj33 = (((nint)obj32 != 1) ? ((object)9) : ((object)15));
				bool flag18 = (nint)obj32 == 1 && num == 0;
				object obj34 = !flag18;
				if (obj34 == null)
				{
					object obj35 = 17;
				}
				else
				{
					object obj35 = 8;
				}
				if (num16 == 2)
				{
					object obj35 = obj30;
				}
				object obj36 = ((num16 != 2) ? obj33 : ((object)15));
				if (num != 0)
				{
					object obj35 = obj36;
				}
				if (LastBidderIndex != 2)
				{
					if (array == null)
					{
						goto IL_2665;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
					object obj37 = 0 & 0xFFFFFFFEL;
					if (obj37 == null)
					{
						goto IL_273e;
					}
					num16 = dealer;
				}
				if (num16 == 3)
				{
					object obj38 = ((num != 1) ? ((object)8) : ((object)17));
					if (num == 1)
					{
						object obj39 = obj38;
					}
					else
					{
						object obj39 = 15;
					}
					if (LastBidderIndex == 3)
					{
						goto IL_04d7;
					}
				}
				else
				{
					object obj40 = num16 + 2;
					object obj41 = obj40 & 0x80000003L;
					if ((nint)obj41 == 2)
					{
						object obj39 = 15;
					}
					else
					{
						object obj39 = 9;
					}
					bool flag19;
					if ((nint)obj41 == 2)
					{
						object obj42 = num - 1;
						flag19 = obj42 == null;
					}
					else
					{
						flag19 = false;
					}
					object obj43 = !flag19;
					object obj44 = ((obj43 != null) ? ((object)8) : ((object)17));
					if (num == 1)
					{
						object obj39 = obj44;
					}
					if (LastBidderIndex == 3)
					{
						goto IL_04d7;
					}
				}
				if (array != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
					bool flag20 = (nint)0 < (nint)3;
					object obj45 = !flag20;
					object obj46 = ~obj45;
					if (obj46 == null)
					{
						num16 = dealer;
						if (dealer == 4)
						{
							goto IL_04f7;
						}
						goto IL_1081;
					}
					goto IL_273e;
				}
			}
			else
			{
				num = dealer;
				object obj47 = dealer + 1;
				object obj48 = dealer + 4;
				if (obj47 > obj48)
				{
					goto IL_054e;
				}
				int num18 = LastBidderIndex & 1;
				bool flag21 = LastBidderIndex < 0;
				int num19 = LastBidderIndex ^ LastBidderIndex;
				int num20 = LastBidderIndex & num19;
				bool flag22 = num20 < 0;
				bool flag23 = flag21 == flag22;
				object obj49 = !flag23;
				object obj50 = ~obj49;
				if (obj50 == null)
				{
					num18 = -num18;
				}
				object obj51 = array + 32;
				int num21 = num;
				while (true)
				{
					int num22 = num + 1;
					object obj52 = num22 - num21;
					object obj53 = num - num21;
					object obj54 = obj53 & 1;
					bool flag24 = (nint)obj53 < 0;
					object obj55 = obj53 ^ obj53;
					object obj56 = obj53 & obj55;
					bool flag25 = (nint)obj56 < 0;
					bool flag26 = flag24 == flag25;
					object obj57 = !flag26;
					object obj58 = ~obj57;
					object obj59 = ((obj58 != null) ? obj54 : ((object)(0 - obj54)));
					object obj60 = num21 + 2;
					object obj61 = 0 - obj60;
					object obj62 = obj61 & 3;
					object obj63 = obj60 & 3;
					if (0 >= (nint)obj60)
					{
						obj63 = 0 - obj62;
					}
					object obj64 = obj59 - obj63;
					bool flag27 = obj64 == null;
					object obj65 = !flag27;
					object obj66 = ~obj65;
					if (obj66 == null)
					{
						object obj67 = 10;
					}
					else
					{
						object obj67 = 19;
					}
					if ((nint)obj52 == num21)
					{
						object obj67 = 19;
					}
					object obj68 = -num;
					object obj69 = obj68 & 3;
					int num23 = num & 3;
					int num24 = ((0 >= num) ? (0 - obj69) : num23);
					object obj70 = obj52 & 1;
					bool flag28 = (nint)obj52 < 0;
					object obj71 = obj52 ^ obj52;
					object obj72 = obj52 & obj71;
					bool flag29 = (nint)obj72 < 0;
					bool flag30 = flag28 == flag29;
					object obj73 = !flag30;
					object obj74 = ~obj73;
					object obj75 = ((obj74 != null) ? obj70 : ((object)(0 - obj70)));
					if ((nint)obj75 != num18)
					{
						object obj76 = num21 + base.<Bidder>k__BackingField;
						object obj77 = obj76 - 1;
						if (num22 < (nint)obj77)
						{
							if (array == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
							bool flag31 = (nint)num24 < (nint)0;
							object obj78 = !flag31;
							if (obj78 != null)
							{
								goto IL_273e;
							}
							num21 = dealer;
						}
					}
					object obj79 = num21 + 4;
					object obj80 = num + 2;
					bool flag32 = obj80 > obj79;
					num = num22;
					if (!flag32)
					{
						continue;
					}
					goto IL_054e;
				}
			}
		}
		else
		{
			bool flag33 = biddingStage == BiddingStage.Awal;
			object obj81 = !flag33;
			object obj82 = ~obj81;
			num = ((obj82 != null) ? 1 : 12);
			if (array != null)
			{
				object obj83 = -LastBidderIndex;
				object obj84 = obj83 & 3;
				int num25 = LastBidderIndex & 3;
				num26 = ((0 >= LastBidderIndex) ? (0 - obj84) : num25);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
				if ((nint)0 != 0)
				{
					object obj85 = dealer - 1;
					bool flag34 = obj85 == null;
					int num27 = dealer & 3;
					object obj86 = !flag34;
					object obj87 = ~obj86;
					bool flag35;
					if (obj87 == null)
					{
						object obj88 = num27 - 2;
						flag35 = obj88 == null;
					}
					else
					{
						flag35 = true;
					}
					object obj89 = !flag35;
					if (obj89 == null)
					{
						int num28 = num + 1;
					}
					else
					{
						int num28 = num;
					}
					if (num26 != 0)
					{
						int num28 = 3;
					}
					if (dealer != 2)
					{
						object obj90 = dealer + 2;
						object obj91 = obj90 & 0x80000003L;
						if ((nint)obj91 != 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
							bool flag36 = (nint)0 == 1;
							obj92 = 0;
							if (!flag36)
							{
								goto IL_14e2;
							}
							goto IL_273e;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
					bool flag37 = (nint)0 != 1;
					obj92 = 1;
					if (flag37)
					{
						goto IL_14e2;
					}
				}
				goto IL_273e;
			}
		}
		goto IL_2665;
		IL_16f7:
		object obj93;
		num = obj93 + num;
		if (num26 != 3)
		{
			num = 3;
		}
		goto IL_2e52;
		IL_32d9:
		bool flag38 = base.<Bidder>k__BackingField != 3;
		num2 = num;
		if (!flag38)
		{
			goto IL_1c30;
		}
		goto IL_1d76;
		IL_1081:
		object obj94 = num16 + 2;
		object obj95 = obj94 & 0x80000003L;
		int num29 = (((nint)obj95 != 3) ? 9 : 15);
		bool flag39 = (nint)obj95 == 3 && num == 0;
		object obj96 = !flag39;
		int num30 = ((obj96 != null) ? 8 : 17);
		num = ((num != 0) ? num29 : num30);
		if (LastBidderIndex == 4)
		{
			goto IL_054e;
		}
		goto IL_1135;
		IL_2a49:
		if (num == 1)
		{
			goto IL_273e;
		}
		if (LastBidderIndex == 2)
		{
			object obj97 = 21;
		}
		else
		{
			object obj97 = 3;
		}
		if (LastBidderIndex == 2)
		{
			BalootGameController gameController2 = _gameController;
			if (_gameController != null)
			{
				Card floorCard2 = gameController2.FloorCard;
				if (gameController2.FloorCard != null)
				{
					if (floorCard2.<Suit>k__BackingField != Suit.SPADES)
					{
						if (floorCard2.<Suit>k__BackingField != Suit.HEARTS)
						{
							if (floorCard2.<Suit>k__BackingField == Suit.DIAMONDS)
							{
								if ((int)(num & 0xFFFFFFFEL) == 0)
								{
									goto IL_273e;
								}
								object obj98 = 22;
							}
						}
						else
						{
							if ((int)(num & 0xFFFFFFFEL) == 0)
							{
								goto IL_273e;
							}
							object obj98 = 23;
						}
					}
					else
					{
						if ((int)(num & 0xFFFFFFFEL) == 0)
						{
							goto IL_273e;
						}
						object obj98 = 24;
					}
					goto IL_31af;
				}
			}
			goto IL_2665;
		}
		goto IL_31af;
		IL_3299:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
		bool flag40 = (nint)0 == 0;
		object obj99 = !flag40;
		if (obj99 == null)
		{
			goto IL_273e;
		}
		goto IL_3337;
		IL_1f34:
		_ = 3;
		int num31 = base.<Bidder>k__BackingField;
		BalootGame.BalootExtraGameMode doubleType3 = DoubleType;
		int num32 = base.<Bidder>k__BackingField & 1;
		bool flag41 = num32 == 0;
		BalootGame.BalootExtraGameMode doubleType4 = DoubleType;
		if (flag41)
		{
			goto IL_1a54;
		}
		goto IL_1f85;
		IL_1d76:
		bool flag42 = num2 < 3;
		object obj100 = !flag42;
		object obj101 = ~obj100;
		if (obj101 != null)
		{
			goto IL_273e;
		}
		object obj102 = 3;
		goto IL_3308;
		IL_1bf3:
		if ((int)(num & 0xFFFFFFFEL) == 0)
		{
			goto IL_273e;
		}
		object obj103 = 3;
		goto IL_32d9;
		IL_2673:
		int num33 = (int)(num & 0xFFFFFFFEL);
		bool flag43 = num33 == 0;
		object obj104 = !flag43;
		object obj105 = 50;
		if (obj104 != null)
		{
			goto IL_1830;
		}
		goto IL_273e;
		IL_19f9:
		num31 = base.<Bidder>k__BackingField;
		doubleType3 = DoubleType;
		int num34 = base.<Bidder>k__BackingField & 1;
		bool flag44 = num34 == 0;
		object obj106 = !flag44;
		doubleType4 = DoubleType;
		if (obj106 == null)
		{
			goto IL_1a54;
		}
		goto IL_1f85;
		IL_3337:
		num11 = base.<Bidder>k__BackingField;
		doubleType = DoubleType;
		int num35 = base.<Bidder>k__BackingField & 1;
		bool flag45 = num35 == 0;
		object obj107 = !flag45;
		doubleType2 = DoubleType;
		num13 = num;
		if (obj107 == null)
		{
			goto IL_1203;
		}
		goto IL_17f4;
		IL_17f4:
		if (doubleType2 == BalootGame.BalootExtraGameMode.Qahwa)
		{
			obj105 = 3;
		}
		else
		{
			obj105 = 14;
		}
		int num36 = (int)(num13 & 0xFFFFFFFEL);
		bool flag46 = num36 == 0;
		num = num13;
		if (!flag46)
		{
			goto IL_1830;
		}
		goto IL_273e;
		IL_1f85:
		if ((int)(num & 0xFFFFFFFCL) == 0)
		{
			goto IL_273e;
		}
		if (doubleType4 == BalootGame.BalootExtraGameMode.Qahwa)
		{
			num = 3;
		}
		else
		{
			num = 14;
		}
		goto IL_2e52;
		IL_1830:
		int num37 = (int)(base.<Bidder>k__BackingField & 0x80000001L);
		if (num37 == 1)
		{
			if (base.<Bidder>k__BackingField == 3 && biddingStage == BiddingStage.Thany)
			{
				if (DoubleType == BalootGame.BalootExtraGameMode.Qahwa)
				{
					Suit suit = floorCardSuit;
					bool flag47 = floorCardSuit < Suit.DIAMONDS;
					object obj108 = !flag47;
					object obj109 = floorCardSuit - 3;
					bool flag48 = obj109 == null;
					object obj110 = !flag48;
					object obj111 = obj108 & obj110;
					if (obj111 == null)
					{
						object obj112 = 119877632 + 1248;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v761 @ X10_v22+v1716 @ X9_v24 (Suit)*4]");
						object obj113 = 0;
						bool flag49 = num < 2;
						object obj114 = !flag49;
						object obj115 = num - 2;
						bool flag50 = obj115 == null;
						object obj116 = !flag50;
						object obj117 = obj114 & obj116;
						if (obj117 != null)
						{
							goto IL_19f9;
						}
					}
					else
					{
						bool flag51 = num < 2;
						object obj118 = !flag51;
						object obj119 = num - 2;
						bool flag52 = obj119 == null;
						object obj120 = !flag52;
						object obj121 = obj118 & obj120;
						object obj113 = 50;
						if (obj121 != null)
						{
							goto IL_19f9;
						}
					}
				}
				else
				{
					bool flag53 = num < 2;
					object obj122 = !flag53;
					object obj123 = num - 2;
					bool flag54 = obj123 == null;
					object obj124 = ~obj122;
					object obj125 = obj124 | flag54;
					if (obj125 == null)
					{
						goto IL_1f34;
					}
				}
			}
			else
			{
				bool flag55 = num < 3;
				object obj126 = !flag55;
				if (obj126 != null)
				{
					goto IL_1f34;
				}
			}
		}
		else
		{
			if (DoubleType == BalootGame.BalootExtraGameMode.Qahwa)
			{
				object obj113 = 3;
			}
			else
			{
				object obj113 = 14;
			}
			bool flag56 = num < 2;
			object obj127 = !flag56;
			object obj128 = num - 2;
			bool flag57 = obj128 == null;
			object obj129 = ~obj127;
			object obj130 = obj129 | flag57;
			if (obj130 == null)
			{
				goto IL_19f9;
			}
		}
		goto IL_273e;
		IL_1a54:
		if (num31 != 4 || biddingStage != BiddingStage.Thany || doubleType3 != BalootGame.BalootExtraGameMode.Qahwa)
		{
			goto IL_203c;
		}
		Suit suit2 = floorCardSuit;
		bool flag58 = floorCardSuit < Suit.DIAMONDS;
		object obj131 = !flag58;
		object obj132 = floorCardSuit - 3;
		bool flag59 = obj132 == null;
		object obj133 = !flag59;
		object obj134 = obj131 & obj133;
		if (obj134 == null)
		{
			object obj135 = 119877632 + 1248;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2190 @ X10_v13+v2072 @ X9_v12 (Suit)*4]");
			object obj136 = 0;
		}
		else
		{
			object obj136 = 50;
		}
		if ((int)(num & 0xFFFFFFFCL) != 0)
		{
			return (int[])array;
		}
		goto IL_273e;
		IL_2665:
		NullReferenceException ex = new NullReferenceException();
		goto IL_2673;
		IL_273e:
		return (int[])(object)new IndexOutOfRangeException();
		IL_1c30:
		if (biddingStage == BiddingStage.Thany)
		{
			Suit suit3 = floorCardSuit;
			bool flag60 = floorCardSuit < Suit.DIAMONDS;
			object obj137 = !flag60;
			object obj138 = floorCardSuit - 3;
			bool flag61 = obj138 == null;
			object obj139 = !flag61;
			object obj140 = obj137 & obj139;
			object obj142;
			if (obj140 == null)
			{
				object obj141 = 117170176 + 944;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2169 @ X11_v88+v2045 @ X10_v99 (Suit)*4]");
				obj142 = 0;
			}
			else
			{
				obj142 = 0;
			}
			bool flag62 = num < 3;
			object obj143 = !flag62;
			object obj144 = ~obj143;
			if (obj144 == null)
			{
				object obj145 = ((DoubleType != BalootGame.BalootExtraGameMode.Four) ? ((object)30) : ((object)40));
				object obj146 = obj142 + obj145;
				bool flag63 = base.<Bidder>k__BackingField == 4;
				num2 = num;
				if (flag63)
				{
					goto IL_1db5;
				}
				goto IL_203c;
			}
		}
		else
		{
			if (DoubleType == BalootGame.BalootExtraGameMode.Four)
			{
				obj102 = 5 + 1;
			}
			else
			{
				obj102 = 5;
			}
			bool flag64 = num < 2;
			object obj147 = !flag64;
			object obj148 = num - 2;
			bool flag65 = obj148 == null;
			object obj149 = !flag65;
			object obj150 = obj147 & obj149;
			num2 = num;
			if (obj150 != null)
			{
				goto IL_3308;
			}
		}
		goto IL_273e;
		IL_31af:
		if (num == 2)
		{
			goto IL_273e;
		}
		if (LastBidderIndex == 3)
		{
			object obj151 = 21;
		}
		else
		{
			object obj151 = 3;
		}
		if (LastBidderIndex == 3)
		{
			BalootGameController gameController3 = _gameController;
			if (_gameController != null)
			{
				Card floorCard3 = gameController3.FloorCard;
				if (gameController3.FloorCard != null)
				{
					if (floorCard3.<Suit>k__BackingField != Suit.SPADES)
					{
						if (floorCard3.<Suit>k__BackingField != Suit.HEARTS)
						{
							if (floorCard3.<Suit>k__BackingField == Suit.DIAMONDS)
							{
								bool flag66 = num < 2;
								object obj152 = !flag66;
								object obj153 = num - 2;
								bool flag67 = obj153 == null;
								object obj154 = ~obj152;
								object obj155 = obj154 | flag67;
								if (obj155 != null)
								{
									goto IL_273e;
								}
								object obj156 = 22;
							}
						}
						else
						{
							bool flag68 = num < 2;
							object obj157 = !flag68;
							object obj158 = num - 2;
							bool flag69 = obj158 == null;
							object obj159 = ~obj157;
							object obj160 = obj159 | flag69;
							if (obj160 != null)
							{
								goto IL_273e;
							}
							object obj156 = 23;
						}
					}
					else
					{
						bool flag70 = num < 3;
						object obj161 = !flag70;
						object obj162 = ~obj161;
						if (obj162 != null)
						{
							goto IL_273e;
						}
						object obj156 = 24;
					}
					goto IL_320d;
				}
			}
			goto IL_2665;
		}
		goto IL_320d;
		IL_1203:
		if (num11 == 2 && biddingStage == BiddingStage.Thany && doubleType == BalootGame.BalootExtraGameMode.Qahwa)
		{
			Suit suit4 = floorCardSuit;
			bool flag71 = floorCardSuit < Suit.DIAMONDS;
			object obj163 = !flag71;
			object obj164 = floorCardSuit - 3;
			bool flag72 = obj164 == null;
			object obj165 = !flag72;
			object obj166 = obj163 & obj165;
			if (obj166 != null)
			{
				goto IL_2673;
			}
			object obj167 = 119877632 + 1248;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X10_v84+v1256 @ X9_v71 (Suit)*4]");
			obj105 = 0;
			int num38 = (int)(num & 0xFFFFFFFEL);
			bool flag73 = num38 == 0;
			object obj168 = !flag73;
			if (obj168 != null)
			{
				goto IL_1830;
			}
		}
		else if ((int)(num & 0xFFFFFFFEL) != 0)
		{
			obj105 = 3;
			goto IL_1830;
		}
		goto IL_273e;
		IL_203c:
		if ((int)(num & 0xFFFFFFFCL) == 0)
		{
			goto IL_273e;
		}
		num = 3;
		goto IL_2e52;
		IL_14e2:
		int num39 = obj92 + num;
		if (num26 != 1)
		{
			num39 = 3;
		}
		object obj171;
		if (dealer != 3)
		{
			object obj169 = dealer + 2;
			object obj170 = obj169 & 0x80000003L;
			if ((nint)obj170 != 2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
				bool flag74 = (nint)0 == 2;
				obj171 = 0;
				if (!flag74)
				{
					goto IL_1611;
				}
				goto IL_273e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
		bool flag75 = (nint)0 != 2;
		obj171 = 1;
		if (flag75)
		{
			goto IL_1611;
		}
		goto IL_273e;
		IL_2e52:
		return (int[])array;
		IL_3308:
		bool flag76 = base.<Bidder>k__BackingField != 4;
		num = num2;
		if (!flag76)
		{
			goto IL_1db5;
		}
		goto IL_203c;
		IL_04f7:
		int num40 = ((num != 0) ? 8 : 17);
		num = ((num != 0) ? 15 : num40);
		if (LastBidderIndex == 4)
		{
			goto IL_054e;
		}
		goto IL_1135;
		IL_320d:
		if (num != 3)
		{
			if (LastBidderIndex == 4)
			{
				object obj172 = 21;
			}
			else
			{
				object obj172 = 3;
			}
			if (LastBidderIndex != 4)
			{
				goto IL_054e;
			}
			BalootGameController gameController4 = _gameController;
			if (_gameController != null)
			{
				Card floorCard4 = gameController4.FloorCard;
				if (gameController4.FloorCard != null)
				{
					if (floorCard4.<Suit>k__BackingField != Suit.SPADES)
					{
						if (floorCard4.<Suit>k__BackingField != Suit.HEARTS)
						{
							if (floorCard4.<Suit>k__BackingField != Suit.DIAMONDS)
							{
								goto IL_054e;
							}
							if ((int)(num & 0xFFFFFFFCL) == 0)
							{
								goto IL_273e;
							}
							num = 22;
						}
						else
						{
							if ((int)(num & 0xFFFFFFFCL) == 0)
							{
								goto IL_273e;
							}
							num = 23;
						}
					}
					else
					{
						if ((int)(num & 0xFFFFFFFCL) == 0)
						{
							goto IL_273e;
						}
						num = 24;
					}
					goto IL_2e52;
				}
			}
			goto IL_2665;
		}
		goto IL_273e;
		IL_1135:
		if (array == null)
		{
			goto IL_2665;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
		object obj173 = 0 & 0xFFFFFFFCL;
		bool flag77 = obj173 == null;
		object obj174 = !flag77;
		if (obj174 == null)
		{
			goto IL_273e;
		}
		goto IL_2e52;
		IL_1611:
		int num41 = obj171 + num;
		if (num26 != 2)
		{
			num41 = 3;
		}
		if (dealer != 4)
		{
			object obj175 = dealer + 2;
			object obj176 = obj175 & 0x80000003L;
			if ((nint)obj176 != 3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
				bool flag78 = (nint)0 == 3;
				obj93 = 0;
				if (!flag78)
				{
					goto IL_16f7;
				}
				goto IL_273e;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Array)+18]");
		bool flag79 = (nint)0 != 3;
		obj93 = 1;
		if (flag79)
		{
			goto IL_16f7;
		}
		goto IL_273e;
		IL_1403:
		if (biddingStage == BiddingStage.Thany)
		{
			Suit suit5 = floorCardSuit;
			bool flag80 = floorCardSuit < Suit.DIAMONDS;
			object obj177 = !flag80;
			object obj178 = floorCardSuit - 3;
			bool flag81 = obj178 == null;
			object obj179 = !flag81;
			object obj180 = obj177 & obj179;
			object obj182;
			if (obj180 == null)
			{
				object obj181 = 117170176 + 944;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1710 @ X11_v94+v1551 @ X10_v106 (Suit)*4]");
				obj182 = 0;
			}
			else
			{
				obj182 = 0;
			}
			if ((int)(num2 & 0xFFFFFFFEL) != 0)
			{
				object obj183 = ((DoubleType != BalootGame.BalootExtraGameMode.Four) ? ((object)30) : ((object)40));
				object obj184 = obj182 + obj183;
				bool flag82 = base.<Bidder>k__BackingField == 3;
				num = num2;
				if (flag82)
				{
					goto IL_1c30;
				}
				goto IL_1d76;
			}
		}
		else
		{
			if (DoubleType == BalootGame.BalootExtraGameMode.Four)
			{
				obj103 = 5 + 1;
			}
			else
			{
				obj103 = 5;
			}
			int num42 = (int)(num2 & 0xFFFFFFFEL);
			bool flag83 = num42 == 0;
			object obj185 = !flag83;
			num = num2;
			if (obj185 != null)
			{
				goto IL_32d9;
			}
		}
		goto IL_273e;
		IL_1db5:
		if (biddingStage == BiddingStage.Thany)
		{
			Suit suit6 = floorCardSuit;
			bool flag84 = floorCardSuit < Suit.DIAMONDS;
			object obj186 = !flag84;
			object obj187 = floorCardSuit - 3;
			bool flag85 = obj187 == null;
			object obj188 = !flag85;
			object obj189 = obj186 & obj188;
			object obj191;
			if (obj189 == null)
			{
				object obj190 = 117170176 + 944;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2331 @ X11_v82+v2290 @ X10_v92 (Suit)*4]");
				obj191 = 0;
			}
			else
			{
				obj191 = 0;
			}
			if ((int)(num2 & 0xFFFFFFFCL) == 0)
			{
				goto IL_273e;
			}
			object obj192 = ((DoubleType != BalootGame.BalootExtraGameMode.Four) ? ((object)30) : ((object)40));
			num = (int)(obj191 + obj192);
		}
		else
		{
			if ((int)(num2 & 0xFFFFFFFCL) == 0)
			{
				goto IL_273e;
			}
			if (DoubleType == BalootGame.BalootExtraGameMode.Four)
			{
				num = 5 + 1;
			}
			else
			{
				num = 5;
			}
		}
		goto IL_2e52;
		IL_054e:
		return (int[])array;
		IL_04d7:
		if (num16 == 4)
		{
			goto IL_04f7;
		}
		goto IL_1081;
	}

	private void SetBiddingResult(BalootGame.BalootGameMode res, int bidder, Suit hokomSuit = Suit.NONE)
	{
		base.<Bidder>k__BackingField = bidder;
		HokomSuit = hokomSuit;
		BiddingResult = res;
	}

	public override int[] StartBidding()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I4
		//IL_00f5: Expected O, but got I4
		//IL_02bf: Expected I4, but got O
		//IL_00e7: Expected O, but got I4
		//IL_010e: Expected I4, but got I8
		//IL_011c: Expected O, but got I4
		//IL_0136: Expected O, but got I4
		//IL_0164: Expected O, but got I4
		//IL_02f0: Expected I4, but got O
		//IL_0156: Expected O, but got I4
		//IL_017d: Expected I4, but got I8
		//IL_018b: Expected O, but got I4
		//IL_01a5: Expected O, but got I4
		//IL_01d3: Expected O, but got I4
		//IL_0321: Expected I4, but got O
		//IL_01c5: Expected O, but got I4
		//IL_01ec: Expected I4, but got I8
		//IL_01fa: Expected O, but got I4
		//IL_0214: Expected O, but got I4
		//IL_0242: Expected O, but got I4
		//IL_0352: Expected I4, but got O
		//IL_0234: Expected O, but got I4
		biddingStage = BiddingStage.Awal;
		IsHokomClose = false;
		DoubleType = BalootGame.BalootExtraGameMode.NotDetermined;
		BalootGameController gameController = _gameController;
		if (_gameController != null)
		{
			Card floorCard = gameController.FloorCard;
			if (gameController.FloorCard != null)
			{
				object obj = typeof(TypeConverter<ushort, char>) + 3048;
				floorCardSuit = floorCard.<Suit>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				int[] array = default(int[]);
				if (array != null)
				{
					if (array.Length != 0)
					{
						int num = dealer & 3;
						bool flag = num == 0;
						object obj2 = !flag;
						object obj3 = ~obj2;
						object obj4 = ((obj3 != null) ? ((object)1) : ((object)3));
						array[0] = (int)obj4;
						if (array.Length != 1)
						{
							int num2 = (int)(dealer & 0x80000003L);
							object obj5 = num2 - 1;
							bool flag2 = obj5 == null;
							object obj6 = !flag2;
							object obj7 = ~obj6;
							object obj8 = ((obj7 != null) ? ((object)1) : ((object)3));
							array[1] = (int)obj8;
							if (array.Length != 2)
							{
								int num3 = (int)(dealer & 0x80000003L);
								object obj9 = num3 - 2;
								bool flag3 = obj9 == null;
								object obj10 = !flag3;
								object obj11 = ~obj10;
								object obj12 = ((obj11 != null) ? ((object)1) : ((object)3));
								array[2] = (int)obj12;
								if (array.Length != 3)
								{
									int num4 = (int)(dealer & 0x80000003L);
									object obj13 = num4 - 3;
									bool flag4 = obj13 == null;
									object obj14 = !flag4;
									object obj15 = ~obj14;
									object obj16 = ((obj15 != null) ? ((object)1) : ((object)3));
									array[3] = (int)obj16;
									return array;
								}
							}
						}
					}
					IndexOutOfRangeException ex = new IndexOutOfRangeException();
				}
			}
		}
		return (int[])(object)new NullReferenceException();
	}

	private void Reset()
	{
		biddingStage = BiddingStage.Awal;
		IsHokomClose = false;
		DoubleType = BalootGame.BalootExtraGameMode.NotDetermined;
	}
}
