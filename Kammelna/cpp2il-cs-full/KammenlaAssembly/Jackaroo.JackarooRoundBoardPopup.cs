using System;
using System.Data.SqlTypes;
using System.Threading;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Jackaroo;

public class JackarooRoundBoardPopup : RoundBoardPopup
{
	public TextMeshProUGUI RoundBid;

	protected override void ShowRoundBoard()
	{
		//IL_1eaf: Expected O, but got I
		//IL_000d: Expected I, but got O
		//IL_001d: Expected O, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_006d: Expected I, but got O
		//IL_0096: Expected O, but got I4
		//IL_00ca: Expected O, but got I
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0144: Expected I, but got O
		//IL_016d: Expected O, but got I4
		//IL_01a1: Expected O, but got I
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_0774: Expected O, but got I
		//IL_0381: Expected O, but got I
		//IL_03c2: Expected O, but got I4
		//IL_043b: Expected O, but got I4
		//IL_04b4: Expected O, but got I4
		//IL_052d: Expected O, but got I4
		//IL_0ce2: Expected O, but got I4
		//IL_05a6: Expected O, but got I4
		//IL_09bf: Expected O, but got I4
		//IL_0d4a: Expected O, but got I
		//IL_0d60: Expected O, but got I
		//IL_0d76: Expected O, but got I
		//IL_0d8c: Expected O, but got I
		//IL_0d96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9b: Expected O, but got Unknown
		//IL_1fa3: Expected O, but got I
		//IL_0a21: Expected O, but got I
		//IL_0a37: Expected O, but got I
		//IL_0a4d: Expected O, but got I
		//IL_0a63: Expected O, but got I
		//IL_0a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a72: Expected O, but got Unknown
		//IL_0dd3: Expected O, but got I4
		//IL_0e4c: Expected O, but got I4
		//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb6: Expected O, but got Unknown
		//IL_0f1e: Expected O, but got I4
		//IL_0f30: Expected O, but got I4
		//IL_0b9e: Expected O, but got I4
		//IL_0bd5: Expected O, but got I4
		//IL_0aa7: Expected O, but got I4
		//IL_0ade: Expected O, but got I4
		//IL_0c10: Expected O, but got I
		//IL_0c20: Expected O, but got I
		//IL_0c30: Expected O, but got I
		//IL_0c40: Expected O, but got I
		//IL_0c50: Expected O, but got I
		//IL_0c5d: Expected O, but got I
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Expected O, but got Unknown
		//IL_0f75: Expected O, but got I
		//IL_0fde: Expected O, but got I
		//IL_1ffe: Unknown result type (might be due to invalid IL or missing references)
		//IL_2003: Expected O, but got Unknown
		//IL_2027: Expected O, but got I4
		//IL_2030: Expected O, but got I4
		//IL_204f: Expected O, but got I4
		//IL_0b19: Expected O, but got I
		//IL_0b29: Expected O, but got I
		//IL_0b39: Expected O, but got I
		//IL_0b51: Expected O, but got I
		//IL_0b5e: Expected O, but got I
		//IL_0b72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Expected O, but got Unknown
		//IL_1062: Unknown result type (might be due to invalid IL or missing references)
		//IL_1067: Expected O, but got Unknown
		//IL_114d: Expected O, but got I8
		//IL_0c84: Expected O, but got I4
		//IL_0cbb: Expected O, but got I4
		//IL_10bc: Expected O, but got I
		//IL_1125: Expected O, but got I
		//IL_11bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c0: Expected O, but got Unknown
		//IL_123b: Expected O, but got I4
		//IL_1263: Expected O, but got I4
		//IL_1289: Expected O, but got I
		//IL_12f2: Expected O, but got I
		//IL_1376: Unknown result type (might be due to invalid IL or missing references)
		//IL_137b: Expected O, but got Unknown
		//IL_1461: Expected O, but got I8
		//IL_13d0: Expected O, but got I
		//IL_1439: Expected O, but got I
		//IL_14cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d4: Expected O, but got Unknown
		//IL_14f6: Expected O, but got I4
		//IL_14ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1504: Expected O, but got Unknown
		//IL_1555: Expected O, but got I4
		//IL_207e: Expected O, but got I4
		//IL_1570: Unsupported input type for neg.
		//IL_1570: Unknown result type (might be due to invalid IL or missing references)
		//IL_1575: Expected O, but got Unknown
		//IL_1597: Expected O, but got I
		//IL_1669: Expected O, but got I4
		//IL_16c7: Expected O, but got I
		//IL_1786: Expected O, but got I4
		//IL_178f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1794: Expected O, but got Unknown
		//IL_17e5: Expected O, but got I4
		//IL_20f7: Expected O, but got I4
		//IL_1800: Unsupported input type for neg.
		//IL_1800: Unknown result type (might be due to invalid IL or missing references)
		//IL_1805: Expected O, but got Unknown
		//IL_1827: Expected O, but got I
		//IL_18f9: Expected O, but got I4
		//IL_1957: Expected O, but got I
		//IL_1c26: Expected O, but got I4
		//IL_1a63: Expected O, but got I4
		//IL_1cba: Expected O, but got I
		//IL_1cca: Expected O, but got I
		//IL_1cda: Expected O, but got I
		//IL_1cea: Expected O, but got I
		//IL_1cfa: Expected O, but got I
		//IL_1d02: Expected I, but got O
		//IL_1d12: Expected O, but got I
		//IL_1d1f: Expected O, but got I
		//IL_1af7: Expected O, but got I
		//IL_1b07: Expected O, but got I
		//IL_1b17: Expected O, but got I
		//IL_1b27: Expected O, but got I
		//IL_1b37: Expected O, but got I
		//IL_1b3f: Expected I, but got O
		//IL_1b4f: Expected O, but got I
		//IL_1b5c: Expected O, but got I
		//IL_1d5f: Expected O, but got I4
		//IL_1d76: Expected O, but got I
		//IL_1d8c: Expected O, but got I
		//IL_1da6: Expected O, but got I4
		//IL_1dbf: Expected O, but got I
		//IL_1b9c: Expected O, but got I4
		//IL_1bb3: Expected O, but got I
		//IL_1bc9: Expected O, but got I
		//IL_1bf1: Expected O, but got I
		//IL_1e2d: Expected O, but got I4
		CardGame cardGame = game;
		bool flag = (object)game == null;
		IntPtr intPtr = default(IntPtr);
		string text = (string)(nint)intPtr;
		ICardGameRoundScore lastCardGameRoundScore;
		if (!flag)
		{
			nint num = (nint)cardGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X8_v8 (Il2CppClass<CardGame>)+180]");
			text = (string)0;
			CardGameScores gameScores = (CardGameScores)game.GameScores;
			if (gameScores != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 312;
				object obj2 = obj;
				nint num2 = (nint)gameScores;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v11 (Il2CppClass<CardGameScores>)+130]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X1_v8+130]");
				bool flag2 = num3 < 0;
				object obj3 = !flag2;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X8_v11 (Il2CppClass<CardGameScores>)+C8]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v480 @ X1_v8+130]");
					object obj5 = num4 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X8_v13-8]");
					if (0 == (nint)obj2)
					{
						lastCardGameRoundScore = gameScores.LastCardGameRoundScore;
						bool flag3 = lastCardGameRoundScore == null;
						text = null;
						if (!flag3)
						{
							object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 296;
							text = (string)obj6;
							nint num5 = (nint)lastCardGameRoundScore;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v86 (Il2CppClass<ICardGameRoundScore>)+130]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X1_v3 (System.String)+130]");
							bool flag4 = num6 < 0;
							object obj7 = !flag4;
							object obj8 = ~obj7;
							if (obj8 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v735 @ X8_v86 (Il2CppClass<ICardGameRoundScore>)+C8]");
								nint num7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X1_v3 (System.String)+130]");
								object obj9 = num7 + 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v813 @ X8_v88-8]");
								if (0 == (nint)text)
								{
									goto IL_01c8;
								}
							}
							throw new InvalidCastException();
						}
						goto IL_01c8;
					}
				}
				goto IL_1e7a;
			}
		}
		goto IL_1e46;
		IL_1e62:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex = new OutOfMemoryException();
		goto IL_1e7a;
		IL_0f3e:
		object obj11 = default(object);
		string text2;
		object obj13;
		string text4;
		object obj15;
		object obj17;
		object obj19;
		object obj21;
		bool flag7;
		bool flag9;
		IndexOutOfRangeException ex2 = default(IndexOutOfRangeException);
		object obj18;
		object obj20;
		object obj14;
		object obj16;
		object obj12 = default(object);
		string text3 = default(string);
		bool flag6 = default(bool);
		bool flag8;
		if ((object)Team1Eatings != null)
		{
			object obj10 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v62+40]");
			text2 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag5 = ex2 == null;
			obj12 = obj13;
			text3 = text4;
			obj14 = obj15;
			obj16 = obj17;
			obj18 = obj19;
			obj20 = obj21;
			flag6 = flag7;
			flag8 = flag9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v669 @ X8_v62+40]");
			text = (string)0;
			if (flag5)
			{
				goto IL_1e62;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v28+18]");
		bool flag10 = (nint)0 == 0;
		obj12 = obj13;
		text3 = text4;
		obj14 = obj15;
		obj16 = obj17;
		obj18 = obj19;
		obj20 = obj21;
		flag6 = flag7;
		flag8 = flag9;
		text = text2;
		int num8;
		int num9 = default(int);
		object obj59;
		if (!flag10)
		{
			object obj22 = obj11 + 32;
			obj22 = Team1Eatings;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag11 = (object)Team2Eatings == null;
			string text5 = (string)(object)Team1Eatings;
			if (!flag11)
			{
				object obj23 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v61+40]");
				text5 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag12 = ex2 == null;
				obj12 = obj13;
				text3 = text4;
				obj14 = obj15;
				obj16 = obj17;
				obj18 = obj19;
				obj20 = obj21;
				flag6 = flag7;
				flag8 = flag9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v61+40]");
				text = (string)0;
				if (flag12)
				{
					goto IL_1e62;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v28+18]");
			object obj24 = 0 & 0xFFFFFFFEL;
			bool flag13 = obj24 == null;
			obj12 = obj13;
			text3 = text4;
			obj14 = obj15;
			obj16 = obj17;
			obj18 = obj19;
			obj20 = obj21;
			flag6 = flag7;
			flag8 = flag9;
			text = text5;
			if (!flag13)
			{
				object obj25 = obj11 + 40;
				obj25 = Team2Eatings;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj26 = default(object);
				bool flag14 = obj26 == null;
				obj12 = obj13;
				text3 = text4;
				obj14 = obj15;
				obj16 = obj17;
				obj18 = obj19;
				obj20 = obj21;
				flag6 = flag7;
				flag8 = flag9;
				text = (string)2;
				if (flag14)
				{
					goto IL_1e46;
				}
				bool flag15 = (object)Team1Score == null;
				string text6 = (string)2;
				if (!flag15)
				{
					object obj27 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v60+40]");
					text6 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag16 = ex2 == null;
					obj12 = obj13;
					text3 = text4;
					obj14 = obj15;
					obj16 = obj17;
					obj18 = obj19;
					obj20 = obj21;
					flag6 = flag7;
					flag8 = flag9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v60+40]");
					text = (string)0;
					if (flag16)
					{
						goto IL_1e62;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v37+18]");
				bool flag17 = (nint)0 == 0;
				obj12 = obj13;
				text3 = text4;
				obj14 = obj15;
				obj16 = obj17;
				obj18 = obj19;
				obj20 = obj21;
				flag6 = flag7;
				flag8 = flag9;
				text = text6;
				if (!flag17)
				{
					object obj28 = obj26 + 32;
					obj28 = Team1Score;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag18 = (object)Team2Score == null;
					string text7 = (string)(object)Team1Score;
					if (!flag18)
					{
						object obj29 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X8_v59+40]");
						text7 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag19 = ex2 == null;
						obj12 = obj13;
						text3 = text4;
						obj14 = obj15;
						obj16 = obj17;
						obj18 = obj19;
						obj20 = obj21;
						flag6 = flag7;
						flag8 = flag9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X8_v59+40]");
						text = (string)0;
						if (flag19)
						{
							goto IL_1e62;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v37+18]");
					object obj30 = 0 & 0xFFFFFFFEL;
					bool flag20 = obj30 == null;
					obj12 = obj13;
					text3 = text4;
					obj14 = obj15;
					obj16 = obj17;
					obj18 = obj19;
					obj20 = obj21;
					flag6 = flag7;
					flag8 = flag9;
					text = text7;
					if (!flag20)
					{
						object obj31 = obj26 + 40;
						obj31 = Team2Score;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						object obj32 = 3 - num8;
						object obj33 = obj32 & 1;
						bool flag21 = (nint)obj32 < 0;
						object obj34 = obj32 ^ obj32;
						object obj35 = obj32 & obj34;
						bool flag22 = (nint)obj35 < 0;
						bool flag23 = flag21 == flag22;
						object obj36 = !flag23;
						object obj37 = ~obj36;
						object obj38 = ((obj37 != null) ? obj33 : ((object)(0 - obj33)));
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v28+18]");
						bool flag24 = (nint)obj38 < 0;
						object obj39 = !flag24;
						obj12 = obj13;
						text3 = text4;
						obj14 = obj15;
						obj16 = obj17;
						obj18 = obj19;
						obj20 = obj21;
						flag6 = flag7;
						flag8 = flag9;
						text = (string)(object)Team2Score;
						if (obj39 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X23_v10+v464 @ X8_v31*8]");
							object obj40 = 0;
							int teamEeatings = ((CardGameRoundScore)lastCardGameRoundScore).GetTeamEeatings(1);
							string text8 = num9.ToString();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X23_v10+v464 @ X8_v31*8]");
							bool flag25 = (nint)0 == 0;
							obj12 = obj13;
							text3 = text4;
							obj14 = obj15;
							obj16 = obj17;
							obj18 = obj19;
							obj20 = obj21;
							flag6 = flag7;
							flag8 = false;
							text = null;
							if (!flag25)
							{
								object obj41 = obj40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1006 @ X8_v32+560]");
								flag8 = false;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1006 @ X8_v32+558] (should have been resolved before IL gen)");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v37+18]");
								bool flag26 = (nint)obj38 < 0;
								object obj42 = !flag26;
								obj12 = obj13;
								text3 = text4;
								obj14 = obj15;
								obj16 = obj17;
								obj18 = obj19;
								obj20 = obj21;
								flag6 = flag7;
								text = text8;
								if (obj42 != null)
								{
									goto IL_1e54;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X25_v8+v464 @ X8_v31*8]");
								object obj43 = 0;
								int teamScore = ((CardGameRoundScore)lastCardGameRoundScore).GetTeamScore(1);
								string text9 = num9.ToString();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X25_v8+v464 @ X8_v31*8]");
								bool flag27 = (nint)0 == 0;
								obj12 = obj13;
								text3 = text4;
								obj14 = obj15;
								obj16 = obj17;
								obj18 = obj19;
								obj20 = obj21;
								flag6 = flag7;
								flag8 = false;
								text = null;
								if (!flag27)
								{
									object obj44 = obj43;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1013 @ X8_v34+560]");
									flag8 = false;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1013 @ X8_v34+558] (should have been resolved before IL gen)");
									object obj45 = 4 - num8;
									object obj46 = obj45 & 1;
									bool flag28 = (nint)obj45 < 0;
									object obj47 = obj45 ^ obj45;
									object obj48 = obj45 & obj47;
									bool flag29 = (nint)obj48 < 0;
									bool flag30 = flag28 == flag29;
									object obj49 = !flag30;
									object obj50 = ~obj49;
									object obj51 = ((obj50 != null) ? obj46 : ((object)(0 - obj46)));
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v917 @ X0_v28+18]");
									bool flag31 = (nint)obj51 < 0;
									object obj52 = !flag31;
									obj12 = obj13;
									text3 = text4;
									obj14 = obj15;
									obj16 = obj17;
									obj18 = obj19;
									obj20 = obj21;
									flag6 = flag7;
									text = text9;
									if (obj52 != null)
									{
										goto IL_1e54;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X23_v10+v466 @ X8_v37*8]");
									object obj53 = 0;
									int teamEeatings2 = ((CardGameRoundScore)lastCardGameRoundScore).GetTeamEeatings(2);
									string text10 = num9.ToString();
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X23_v10+v466 @ X8_v37*8]");
									bool flag32 = (nint)0 == 0;
									obj12 = obj13;
									text3 = text4;
									obj14 = obj15;
									obj16 = obj17;
									obj18 = obj19;
									obj20 = obj21;
									flag6 = flag7;
									flag8 = false;
									text = null;
									if (!flag32)
									{
										object obj54 = obj53;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1036 @ X8_v38+560]");
										flag8 = false;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1036 @ X8_v38+558] (should have been resolved before IL gen)");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v37+18]");
										bool flag33 = (nint)obj51 < 0;
										object obj55 = !flag33;
										obj12 = obj13;
										text3 = text4;
										obj14 = obj15;
										obj16 = obj17;
										obj18 = obj19;
										obj20 = obj21;
										flag6 = flag7;
										text = text10;
										if (obj55 != null)
										{
											goto IL_1e54;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X25_v8+v466 @ X8_v37*8]");
										object obj56 = 0;
										int teamScore2 = ((CardGameRoundScore)lastCardGameRoundScore).GetTeamScore(2);
										string text11 = num9.ToString();
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X25_v8+v466 @ X8_v37*8]");
										bool flag34 = (nint)0 == 0;
										obj12 = obj13;
										text3 = text4;
										obj14 = obj15;
										obj16 = obj17;
										obj18 = obj19;
										obj20 = obj21;
										flag6 = flag7;
										flag8 = false;
										text = null;
										if (!flag34)
										{
											object obj57 = obj56;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1043 @ X8_v40+560]");
											flag8 = false;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1043 @ X8_v40+558] (should have been resolved before IL gen)");
											TextMeshProUGUI resultLabel = ResultLabel;
											object obj58 = obj59;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v16 (ICardGameRoundScore)+18]");
											if ((nint)0 == num8)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X0_v69+E4]");
												bool flag35 = (nint)0 == 0;
												object obj60 = !flag35;
												if (obj60 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												bool flag36 = (object)ResultLabel == null;
												obj12 = obj13;
												text3 = text4;
												obj14 = obj15;
												obj16 = obj17;
												obj18 = obj19;
												obj20 = obj21;
												flag6 = flag7;
												text = text11;
												if (!flag36)
												{
													object obj61 = obj59;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1055 @ X8_v50+B8]");
													object obj62 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X8_v51+18]");
													obj20 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X8_v51+1C]");
													obj18 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X8_v51+10]");
													obj16 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1056 @ X8_v51+14]");
													obj14 = 0;
													nint num10 = (nint)resultLabel;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v52 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
													text = (string)0;
													ResultLabel.color = (Color)0;
													bool flag37 = (object)ResultBackground == null;
													obj12 = obj13;
													text3 = text4;
													flag6 = flag7;
													if (!flag37)
													{
														object obj63 = 216;
														Image resultBackground = ResultBackground;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.JackarooRoundBoardPopup)+v1063 @ X8_v53]");
														resultBackground.sprite = (Sprite)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v16 (ICardGameRoundScore)+2C]");
														object obj64 = (nint)0 & (nint)1;
														bool flag38 = obj64 == null;
														flag8 = false;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.JackarooRoundBoardPopup)+v1063 @ X8_v53]");
														text = (string)0;
														if (!flag38)
														{
															return;
														}
														goto IL_1dcd;
													}
												}
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1047 @ X0_v69+E4]");
												bool flag39 = (nint)0 == 0;
												object obj65 = !flag39;
												if (obj65 == null)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
												}
												bool flag40 = (object)ResultLabel == null;
												obj12 = obj13;
												text3 = text4;
												obj14 = obj15;
												obj16 = obj17;
												obj18 = obj19;
												obj20 = obj21;
												flag6 = flag7;
												text = text11;
												if (!flag40)
												{
													object obj66 = obj59;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1059 @ X8_v45+B8]");
													object obj67 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ X8_v46+38]");
													obj20 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ X8_v46+3C]");
													obj18 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ X8_v46+30]");
													obj16 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1060 @ X8_v46+34]");
													obj14 = 0;
													nint num11 = (nint)resultLabel;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v47 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
													text = (string)0;
													ResultLabel.color = (Color)0;
													bool flag41 = (object)ResultBackground == null;
													obj12 = obj13;
													text3 = text4;
													flag6 = flag7;
													if (!flag41)
													{
														object obj68 = 224;
														Image resultBackground2 = ResultBackground;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.JackarooRoundBoardPopup)+v1066 @ X8_v48]");
														resultBackground2.sprite = (Sprite)0;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v16 (ICardGameRoundScore)+2C]");
														object obj69 = (nint)0 & (nint)1;
														bool flag42 = obj69 == null;
														object obj70 = !flag42;
														flag8 = false;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Jackaroo.JackarooRoundBoardPopup)+v1066 @ X8_v48]");
														text = (string)0;
														if (obj70 == null)
														{
															goto IL_1dcd;
														}
														return;
													}
												}
											}
										}
									}
								}
							}
							goto IL_1e46;
						}
					}
				}
			}
		}
		goto IL_1e54;
		IL_1dcd:
		bool flag43 = (object)game == null;
		obj12 = obj13;
		text3 = text4;
		flag6 = flag7;
		if (!flag43)
		{
			bool isFastTrackGame = game.IsFastTrackGame;
			bool flag44 = !isFastTrackGame;
			object obj71 = !flag44;
			if (obj71 == null)
			{
				base.ShowPopup();
			}
			return;
		}
		goto IL_1e46;
		IL_1e46:
		NullReferenceException ex3 = new NullReferenceException();
		goto IL_1e54;
		IL_1f27:
		string nickName;
		bool flag45;
		TextMeshProExtensions.SetUsername(Catcher, nickName, flag45, flag6);
		object obj72 = obj59;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v16 (ICardGameRoundScore)+18]");
		nint num12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v16 (ICardGameRoundScore)+24]");
		TextMeshProUGUI catchResult;
		object text12;
		if (num12 == 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X0_v136+E4]");
			bool flag46 = (nint)0 == 0;
			object obj73 = !flag46;
			if (obj73 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag47 = (object)CatchResult == null;
			obj12 = 0;
			text3 = null;
			flag8 = flag45;
			text = nickName;
			if (flag47)
			{
				goto IL_1e46;
			}
			object obj74 = obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X8_v77+B8]");
			object obj75 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X8_v78+8]");
			obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X8_v78+C]");
			obj19 = 0;
			obj17 = obj75;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v922 @ X8_v78+4]");
			obj15 = 0;
			CatchResult.color = (Color)0;
			catchResult = CatchResult;
			text12 = "Complete" + 1736;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X0_v136+E4]");
			bool flag48 = (nint)0 == 0;
			object obj76 = !flag48;
			if (obj76 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag49 = (object)CatchResult == null;
			obj12 = 0;
			text3 = null;
			flag8 = flag45;
			text = nickName;
			if (flag49)
			{
				goto IL_1e46;
			}
			object obj77 = obj59;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X8_v72+B8]");
			object obj78 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v73+28]");
			obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v73+2C]");
			obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v73+20]");
			obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v73+24]");
			obj15 = 0;
			CatchResult.color = (Color)0;
			catchResult = CatchResult;
			text12 = "WhiteSmoke" + 472;
		}
		TextMeshProExtensions.Localize(catchResult, (string)text12);
		object obj79 = typeof(SqlSingle[]) + 216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		bool flag50 = obj11 == null;
		object obj80 = !flag50;
		obj13 = 0;
		text4 = null;
		flag7 = flag6;
		flag9 = false;
		text2 = (string)2;
		if (obj80 != null)
		{
			goto IL_0f3e;
		}
		obj12 = 0;
		text3 = null;
		obj14 = obj15;
		obj16 = obj17;
		obj18 = obj19;
		obj20 = obj21;
		flag8 = false;
		text = (string)2;
		goto IL_1e46;
		IL_1e54:
		ex2 = new IndexOutOfRangeException();
		goto IL_1e62;
		IL_1e7a:
		throw new InvalidCastException();
		IL_01c8:
		if ((object)game != null)
		{
			if (game.IsSpectator)
			{
				num8 = 1;
				text = null;
			}
			else
			{
				bool flag51 = (object)game == null;
				text = null;
				if (flag51)
				{
					goto IL_1e46;
				}
				int myTeamIndex = game.MyTeamIndex;
				num8 = myTeamIndex;
				text = null;
			}
			if (lastCardGameRoundScore != null)
			{
				string text13 = num9.ToString();
				bool flag52 = (object)RoundBid == null;
				text = null;
				if (!flag52)
				{
					object obj81 = "WhiteSmoke" + 2136;
					object obj82 = "October" + 1288;
					RoundBid.text = text13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v16 (ICardGameRoundScore)+24]");
					object obj83 = (((nint)0 != num8) ? obj82 : obj81);
					text = (string)obj83;
					TextMeshProExtensions.Localize(Bidder, (string)obj83);
					bool flag53 = (object)game == null;
					flag8 = false;
					if (!flag53)
					{
						obj59 = typeof(RegisteredWaitHandle) + 1520;
						CardGame cardGame2 = game;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v16 (ICardGameRoundScore)+28]");
						KPlayer playerByIndex = cardGame2.GetPlayerByIndex(0);
						if (playerByIndex != null)
						{
							bool flag54 = (object)CatchResultSection == null;
							flag8 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v16 (ICardGameRoundScore)+28]");
							text = (string)0;
							if (!flag54)
							{
								CatchResultSection.SetActive(value: true);
								bool flag55 = (object)Catcher == null;
								flag8 = false;
								text = (string)1;
								if (!flag55)
								{
									GameObject gameObject = Catcher.gameObject;
									bool flag56 = (object)gameObject == null;
									flag8 = false;
									text = null;
									if (!flag56)
									{
										gameObject.SetActive(value: true);
										bool flag57 = (object)CatcherLabel == null;
										flag8 = false;
										text = (string)1;
										if (!flag57)
										{
											GameObject gameObject2 = CatcherLabel.gameObject;
											bool flag58 = (object)gameObject2 == null;
											flag8 = false;
											text = null;
											if (!flag58)
											{
												gameObject2.SetActive(value: true);
												bool flag59 = (object)CatchResult == null;
												flag8 = false;
												text = (string)1;
												if (!flag59)
												{
													GameObject gameObject3 = CatchResult.gameObject;
													bool flag60 = (object)gameObject3 == null;
													flag8 = false;
													text = null;
													if (!flag60)
													{
														gameObject3.SetActive(value: true);
														bool flag61 = (object)CatchResultLabel == null;
														flag8 = false;
														text = (string)1;
														if (!flag61)
														{
															GameObject gameObject4 = CatchResultLabel.gameObject;
															bool flag62 = (object)gameObject4 == null;
															flag8 = false;
															text = null;
															if (!flag62)
															{
																gameObject4.SetActive(value: true);
																bool flag63 = (object)BetResultSection == null;
																flag8 = false;
																text = (string)1;
																if (!flag63)
																{
																	BetResultSection.SetActive(value: false);
																	bool flag64 = (object)BetResult == null;
																	flag8 = false;
																	text = null;
																	if (!flag64)
																	{
																		GameObject gameObject5 = BetResult.gameObject;
																		bool flag65 = (object)gameObject5 == null;
																		flag8 = false;
																		text = null;
																		if (!flag65)
																		{
																			gameObject5.SetActive(value: false);
																			bool flag66 = (object)BetResultLabel == null;
																			flag8 = false;
																			text = null;
																			if (!flag66)
																			{
																				GameObject gameObject6 = BetResultLabel.gameObject;
																				bool flag67 = (object)gameObject6 == null;
																				flag8 = false;
																				text = null;
																				if (!flag67)
																				{
																					gameObject6.SetActive(value: false);
																					nickName = playerByIndex.NickName;
																					if (playerByIndex.<User>k__BackingField != null)
																					{
																						bool flag68 = SFSKammelnaUserExtensions.IsSubscribed(playerByIndex.<User>k__BackingField);
																						bool flag69 = playerByIndex.<User>k__BackingField == null;
																						flag45 = flag68;
																						if (!flag69)
																						{
																							bool flag70 = SFSKammelnaUserExtensions.IsVerified(playerByIndex.<User>k__BackingField);
																							flag6 = flag70;
																							flag45 = flag68;
																							goto IL_1f27;
																						}
																					}
																					else
																					{
																						flag45 = false;
																					}
																					flag6 = false;
																					goto IL_1f27;
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
						else
						{
							bool flag71 = (object)CatchResultSection == null;
							flag8 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v16 (ICardGameRoundScore)+28]");
							text = (string)0;
							if (!flag71)
							{
								CatchResultSection.SetActive(value: false);
								bool flag72 = (object)Catcher == null;
								flag8 = false;
								text = null;
								if (!flag72)
								{
									GameObject gameObject7 = Catcher.gameObject;
									bool flag73 = (object)gameObject7 == null;
									flag8 = false;
									text = null;
									if (!flag73)
									{
										gameObject7.SetActive(value: false);
										bool flag74 = (object)CatcherLabel == null;
										flag8 = false;
										text = null;
										if (!flag74)
										{
											GameObject gameObject8 = CatcherLabel.gameObject;
											bool flag75 = (object)gameObject8 == null;
											flag8 = false;
											text = null;
											if (!flag75)
											{
												gameObject8.SetActive(value: false);
												bool flag76 = (object)CatchResult == null;
												flag8 = false;
												text = null;
												if (!flag76)
												{
													GameObject gameObject9 = CatchResult.gameObject;
													bool flag77 = (object)gameObject9 == null;
													flag8 = false;
													text = null;
													if (!flag77)
													{
														gameObject9.SetActive(value: false);
														bool flag78 = (object)CatchResultLabel == null;
														flag8 = false;
														text = null;
														if (!flag78)
														{
															GameObject gameObject10 = CatchResultLabel.gameObject;
															bool flag79 = (object)gameObject10 == null;
															flag8 = false;
															text = null;
															if (!flag79)
															{
																gameObject10.SetActive(value: false);
																object obj84 = obj59;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v16 (ICardGameRoundScore)+18]");
																nint num13 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v16 (ICardGameRoundScore)+24]");
																object obj87;
																object obj88;
																object obj89;
																object obj90;
																object obj91;
																if (num13 == 0)
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X0_v102+E4]");
																	bool flag80 = (nint)0 == 0;
																	object obj85 = !flag80;
																	if (obj85 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	}
																	bool flag81 = (object)BetResult == null;
																	flag8 = false;
																	text = null;
																	if (flag81)
																	{
																		goto IL_1e46;
																	}
																	object obj86 = obj59;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X8_v68+B8]");
																	obj87 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X8_v68+B8]");
																	obj88 = (nint)0 + (nint)12;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X8_v68+B8]");
																	obj89 = (nint)0 + (nint)8;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v852 @ X8_v68+B8]");
																	obj90 = (nint)0 + (nint)4;
																	obj91 = "WhiteSmoke" + 200;
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v844 @ X0_v102+E4]");
																	bool flag82 = (nint)0 == 0;
																	object obj92 = !flag82;
																	if (obj92 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	}
																	bool flag83 = (object)BetResult == null;
																	flag8 = false;
																	text = null;
																	if (flag83)
																	{
																		goto IL_1e46;
																	}
																	object obj93 = obj59;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X8_v66+B8]");
																	obj88 = (nint)0 + (nint)44;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X8_v66+B8]");
																	obj89 = (nint)0 + (nint)40;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X8_v66+B8]");
																	obj90 = (nint)0 + (nint)36;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v859 @ X8_v66+B8]");
																	obj87 = (nint)0 + (nint)32;
																	obj91 = "LAK" + 2480;
																}
																obj18 = obj88;
																obj20 = obj89;
																obj14 = obj90;
																obj16 = obj87;
																BetResult.color = (Color)0;
																text = (string)obj91;
																TextMeshProExtensions.Localize(BetResult, (string)obj91);
																bool flag84 = (object)BetResultSection == null;
																flag8 = false;
																if (!flag84)
																{
																	BetResultSection.SetActive(value: true);
																	bool flag85 = (object)BetResult == null;
																	flag8 = false;
																	text = (string)1;
																	if (!flag85)
																	{
																		GameObject gameObject11 = BetResult.gameObject;
																		bool flag86 = (object)gameObject11 == null;
																		flag8 = false;
																		text = null;
																		if (!flag86)
																		{
																			gameObject11.SetActive(value: true);
																			bool flag87 = (object)BetResultLabel == null;
																			flag8 = false;
																			text = (string)1;
																			if (!flag87)
																			{
																				GameObject gameObject12 = BetResultLabel.gameObject;
																				bool flag88 = (object)gameObject12 == null;
																				flag8 = false;
																				text = null;
																				if (!flag88)
																				{
																					gameObject12.SetActive(value: true);
																					obj79 = typeof(SqlSingle[]) + 216;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																					bool flag89 = obj11 == null;
																					obj13 = obj12;
																					text4 = text3;
																					obj15 = obj90;
																					obj17 = obj87;
																					obj19 = obj88;
																					obj21 = obj89;
																					flag7 = flag6;
																					flag9 = false;
																					text2 = (string)2;
																					flag8 = false;
																					text = (string)2;
																					if (!flag89)
																					{
																						goto IL_0f3e;
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
		goto IL_1e46;
	}

	public JackarooRoundBoardPopup()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b4: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(RegisteredWaitHandle) + 1520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7FFC]");
		if ((object)((nint)0 & (nint)1) != null)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v1+E4]");
			if ((object)((nint)0 != 0) != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		base..ctor();
		return;
		IL_007d:
		base..ctor();
	}
}
