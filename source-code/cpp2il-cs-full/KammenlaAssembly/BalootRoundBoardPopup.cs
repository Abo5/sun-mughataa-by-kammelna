using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class BalootRoundBoardPopup : RoundBoardPopup
{
	public TextMeshProUGUI Mode;

	public TextMeshProUGUI Team1Floor;

	public TextMeshProUGUI Team1Project1Name;

	public TextMeshProUGUI Team1Project1Score;

	public TextMeshProUGUI Team1Project2Name;

	public TextMeshProUGUI Team1Project2Score;

	public TextMeshProUGUI Team1Project3Name;

	public TextMeshProUGUI Team1Project3Score;

	public TextMeshProUGUI Team1Project4Name;

	public TextMeshProUGUI Team1Project4Score;

	public TextMeshProUGUI Team1Project5Name;

	public TextMeshProUGUI Team1Project5Score;

	public TextMeshProUGUI Team2Floor;

	public TextMeshProUGUI Team2Project1Name;

	public TextMeshProUGUI Team2Project1Score;

	public TextMeshProUGUI Team2Project2Name;

	public TextMeshProUGUI Team2Project2Score;

	public TextMeshProUGUI Team2Project3Name;

	public TextMeshProUGUI Team2Project3Score;

	public TextMeshProUGUI Team2Project4Name;

	public TextMeshProUGUI Team2Project4Score;

	public TextMeshProUGUI Team2Project5Name;

	public TextMeshProUGUI Team2Project5Score;

	private Animator kabootLoserAnimation;

	private Animator kabootWinnerAnimation;

	private GameObject gameAndCatchData;

	private BalootRoundScore roundScore;

	private const string AnimationShowFlag = "show";

	private const string AnimationHideFlag = "hide";

	private int MyTeamIndex
	{
		get
		{
			//IL_0092: Expected I4, but got O
			if ((object)game != null)
			{
				if (game.IsSpectator)
				{
					return 1;
				}
				if ((object)game != null)
				{
					return game.MyTeamIndex;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	protected unsafe override void ShowRoundBoard()
	{
		//IL_0008: Expected O, but got Ref
		//IL_5f97: Expected O, but got I
		//IL_0015: Expected I, but got O
		//IL_0025: Expected O, but got I
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0075: Expected I, but got O
		//IL_009e: Expected O, but got I4
		//IL_00d2: Expected O, but got I
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0147: Expected I, but got O
		//IL_0170: Expected O, but got I4
		//IL_0305: Expected O, but got Ref
		//IL_01a4: Expected O, but got I
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0376: Expected O, but got I4
		//IL_01dd: Expected I, but got O
		//IL_0206: Expected O, but got I4
		//IL_039b: Expected I, but got O
		//IL_023a: Expected O, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0292: Expected O, but got I4
		//IL_0455: Expected I, but got O
		//IL_0465: Expected O, but got I
		//IL_049c: Expected O, but got Ref
		//IL_04ce: Expected O, but got I
		//IL_0505: Expected O, but got I4
		//IL_6026: Expected I, but got O
		//IL_062b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Expected O, but got Unknown
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected O, but got Unknown
		//IL_06af: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected O, but got Unknown
		//IL_0b00: Expected O, but got I4
		//IL_0710: Expected O, but got I4
		//IL_0751: Expected O, but got I4
		//IL_07ca: Expected O, but got I4
		//IL_0843: Expected O, but got I4
		//IL_08bc: Expected O, but got I4
		//IL_0935: Expected O, but got I4
		//IL_1118: Expected O, but got I4
		//IL_0d6d: Expected O, but got I4
		//IL_1180: Expected O, but got I
		//IL_1196: Expected O, but got I
		//IL_11ac: Expected O, but got I
		//IL_11c2: Expected O, but got I
		//IL_11cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d1: Expected O, but got Unknown
		//IL_613c: Expected O, but got I
		//IL_0dcf: Expected O, but got I
		//IL_0de5: Expected O, but got I
		//IL_0dfb: Expected O, but got I
		//IL_0e11: Expected O, but got I
		//IL_0e1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e20: Expected O, but got Unknown
		//IL_1209: Expected O, but got I4
		//IL_1282: Expected O, but got I4
		//IL_60ec: Expected O, but got I4
		//IL_12e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ec: Expected O, but got Unknown
		//IL_0e66: Expected O, but got I4
		//IL_1354: Expected O, but got I4
		//IL_1366: Expected O, but got I4
		//IL_0fd3: Expected O, but got I4
		//IL_100a: Expected O, but got I4
		//IL_0edb: Expected O, but got I4
		//IL_13ab: Expected O, but got I
		//IL_1414: Expected O, but got I
		//IL_0f12: Expected O, but got I4
		//IL_1498: Unknown result type (might be due to invalid IL or missing references)
		//IL_149d: Expected O, but got Unknown
		//IL_1046: Expected O, but got I
		//IL_1056: Expected O, but got I
		//IL_1066: Expected O, but got I
		//IL_1076: Expected O, but got I
		//IL_1086: Expected O, but got I
		//IL_1093: Expected O, but got I
		//IL_10a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ac: Expected O, but got Unknown
		//IL_1583: Expected O, but got I8
		//IL_6197: Unknown result type (might be due to invalid IL or missing references)
		//IL_619c: Expected O, but got Unknown
		//IL_61c0: Expected O, but got I4
		//IL_61c9: Expected O, but got I4
		//IL_61e8: Expected O, but got I4
		//IL_0f4e: Expected O, but got I
		//IL_0f5e: Expected O, but got I
		//IL_0f6e: Expected O, but got I
		//IL_0f86: Expected O, but got I
		//IL_0f93: Expected O, but got I
		//IL_0fa7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fac: Expected O, but got Unknown
		//IL_14f2: Expected O, but got I
		//IL_155b: Expected O, but got I
		//IL_15f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f6: Expected O, but got Unknown
		//IL_10ba: Expected O, but got I4
		//IL_10f1: Expected O, but got I4
		//IL_1671: Expected O, but got I4
		//IL_1699: Expected O, but got I4
		//IL_16bf: Expected O, but got I
		//IL_1728: Expected O, but got I
		//IL_17ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b1: Expected O, but got Unknown
		//IL_1897: Expected O, but got I8
		//IL_1806: Expected O, but got I
		//IL_186f: Expected O, but got I
		//IL_190b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1910: Expected O, but got Unknown
		//IL_191c: Expected O, but got I
		//IL_1925: Unknown result type (might be due to invalid IL or missing references)
		//IL_192a: Expected O, but got Unknown
		//IL_19c7: Expected O, but got I
		//IL_1a88: Expected O, but got I4
		//IL_1b04: Expected O, but got I
		//IL_1b14: Expected O, but got I
		//IL_1ac8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1acd: Expected O, but got Unknown
		//IL_1ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1adb: Expected O, but got Unknown
		//IL_1bf9: Expected O, but got I4
		//IL_1c75: Expected O, but got I
		//IL_1c85: Expected O, but got I
		//IL_1c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c3e: Expected O, but got Unknown
		//IL_1c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c4c: Expected O, but got Unknown
		//IL_1d6a: Expected O, but got I4
		//IL_1de6: Expected O, but got I
		//IL_1df6: Expected O, but got I
		//IL_1daa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1daf: Expected O, but got Unknown
		//IL_1db8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dbd: Expected O, but got Unknown
		//IL_1edb: Expected O, but got I4
		//IL_1f57: Expected O, but got I
		//IL_1f67: Expected O, but got I
		//IL_1f1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f20: Expected O, but got Unknown
		//IL_1f29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f2e: Expected O, but got Unknown
		//IL_204c: Expected O, but got I4
		//IL_20c8: Expected O, but got I
		//IL_20d8: Expected O, but got I
		//IL_208c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2091: Expected O, but got Unknown
		//IL_209a: Unknown result type (might be due to invalid IL or missing references)
		//IL_209f: Expected O, but got Unknown
		//IL_223a: Expected O, but got I4
		//IL_22b6: Expected O, but got I
		//IL_22c6: Expected O, but got I
		//IL_227a: Unknown result type (might be due to invalid IL or missing references)
		//IL_227f: Expected O, but got Unknown
		//IL_2288: Unknown result type (might be due to invalid IL or missing references)
		//IL_228d: Expected O, but got Unknown
		//IL_23ab: Expected O, but got I4
		//IL_2427: Expected O, but got I
		//IL_2437: Expected O, but got I
		//IL_23eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_23f0: Expected O, but got Unknown
		//IL_23f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_23fe: Expected O, but got Unknown
		//IL_251c: Expected O, but got I4
		//IL_2598: Expected O, but got I
		//IL_25a8: Expected O, but got I
		//IL_255c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2561: Expected O, but got Unknown
		//IL_256a: Unknown result type (might be due to invalid IL or missing references)
		//IL_256f: Expected O, but got Unknown
		//IL_268d: Expected O, but got I4
		//IL_2709: Expected O, but got I
		//IL_2719: Expected O, but got I
		//IL_26cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_26d2: Expected O, but got Unknown
		//IL_26db: Unknown result type (might be due to invalid IL or missing references)
		//IL_26e0: Expected O, but got Unknown
		//IL_27ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f2: Expected O, but got Unknown
		//IL_27fe: Expected O, but got I
		//IL_281e: Expected O, but got I4
		//IL_289a: Expected O, but got I
		//IL_28aa: Expected O, but got I
		//IL_285e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2863: Expected O, but got Unknown
		//IL_286c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2871: Expected O, but got Unknown
		//IL_2957: Expected O, but got I
		//IL_2a0e: Expected O, but got I4
		//IL_2a90: Expected O, but got I
		//IL_2aa0: Expected O, but got I
		//IL_2a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a53: Expected O, but got Unknown
		//IL_2a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a61: Expected O, but got Unknown
		//IL_2b81: Expected O, but got I4
		//IL_2c03: Expected O, but got I
		//IL_2c13: Expected O, but got I
		//IL_2bc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bc6: Expected O, but got Unknown
		//IL_2bcf: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bd4: Expected O, but got Unknown
		//IL_2d7b: Expected O, but got I4
		//IL_2df7: Expected O, but got I
		//IL_2e07: Expected O, but got I
		//IL_2dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dc0: Expected O, but got Unknown
		//IL_2dc9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dce: Expected O, but got Unknown
		//IL_2eec: Expected O, but got I4
		//IL_2f68: Expected O, but got I
		//IL_2f78: Expected O, but got I
		//IL_2f2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f31: Expected O, but got Unknown
		//IL_2f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f3f: Expected O, but got Unknown
		//IL_305d: Expected O, but got I4
		//IL_30d9: Expected O, but got I
		//IL_30e9: Expected O, but got I
		//IL_309d: Unknown result type (might be due to invalid IL or missing references)
		//IL_30a2: Expected O, but got Unknown
		//IL_30ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_30b0: Expected O, but got Unknown
		//IL_31ce: Expected O, but got I4
		//IL_324a: Expected O, but got I
		//IL_325a: Expected O, but got I
		//IL_320e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3213: Expected O, but got Unknown
		//IL_321c: Unknown result type (might be due to invalid IL or missing references)
		//IL_3221: Expected O, but got Unknown
		//IL_333f: Expected O, but got I4
		//IL_33bb: Expected O, but got I
		//IL_33cb: Expected O, but got I
		//IL_337f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3384: Expected O, but got Unknown
		//IL_338d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3392: Expected O, but got Unknown
		//IL_352d: Expected O, but got I4
		//IL_35a9: Expected O, but got I
		//IL_35b9: Expected O, but got I
		//IL_356d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3572: Expected O, but got Unknown
		//IL_357b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3580: Expected O, but got Unknown
		//IL_369e: Expected O, but got I4
		//IL_371a: Expected O, but got I
		//IL_372a: Expected O, but got I
		//IL_36de: Unknown result type (might be due to invalid IL or missing references)
		//IL_36e3: Expected O, but got Unknown
		//IL_36ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_36f1: Expected O, but got Unknown
		//IL_380f: Expected O, but got I4
		//IL_388b: Expected O, but got I
		//IL_389b: Expected O, but got I
		//IL_384f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3854: Expected O, but got Unknown
		//IL_385d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3862: Expected O, but got Unknown
		//IL_3980: Expected O, but got I4
		//IL_39fc: Expected O, but got I
		//IL_3a0c: Expected O, but got I
		//IL_39c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_39c5: Expected O, but got Unknown
		//IL_39ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_39d3: Expected O, but got Unknown
		//IL_3af1: Expected O, but got I4
		//IL_3b6d: Expected O, but got I
		//IL_3b7d: Expected O, but got I
		//IL_3b31: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b36: Expected O, but got Unknown
		//IL_3b3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b44: Expected O, but got Unknown
		//IL_3cd5: Expected O, but got I4
		//IL_3d57: Expected O, but got I
		//IL_3d67: Expected O, but got I
		//IL_3d15: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d1a: Expected O, but got Unknown
		//IL_3d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d28: Expected O, but got Unknown
		//IL_3e48: Expected O, but got I4
		//IL_3ec2: Expected O, but got I
		//IL_3ed2: Expected O, but got I
		//IL_3f56: Expected O, but got I4
		//IL_3e88: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e8d: Expected O, but got Unknown
		//IL_3e96: Unknown result type (might be due to invalid IL or missing references)
		//IL_3e9b: Expected O, but got Unknown
		//IL_3f7e: Expected O, but got I4
		//IL_3fa4: Expected O, but got I
		//IL_400d: Expected O, but got I
		//IL_4091: Unknown result type (might be due to invalid IL or missing references)
		//IL_4096: Expected O, but got Unknown
		//IL_417c: Expected O, but got I8
		//IL_40eb: Expected O, but got I
		//IL_4154: Expected O, but got I
		//IL_41ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_41ef: Expected O, but got Unknown
		//IL_426a: Expected O, but got I4
		//IL_4292: Expected O, but got I4
		//IL_42b8: Expected O, but got I
		//IL_4321: Expected O, but got I
		//IL_43a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_43aa: Expected O, but got Unknown
		//IL_4490: Expected O, but got I8
		//IL_43ff: Expected O, but got I
		//IL_4468: Expected O, but got I
		//IL_4502: Expected O, but got I
		//IL_450e: Expected O, but got I
		//IL_4517: Unknown result type (might be due to invalid IL or missing references)
		//IL_451c: Expected O, but got Unknown
		//IL_46b1: Expected O, but got I4
		//IL_46ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_46bf: Expected O, but got Unknown
		//IL_46c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_46cd: Expected I4, but got Unknown
		//IL_471e: Expected O, but got I4
		//IL_6217: Expected O, but got I4
		//IL_47bd: Expected O, but got I
		//IL_48a1: Expected O, but got I4
		//IL_495c: Expected O, but got I
		//IL_4a40: Expected O, but got I4
		//IL_4afb: Expected O, but got I
		//IL_4c84: Expected O, but got I4
		//IL_51ce: Expected I4, but got O
		//IL_522e: Expected O, but got I4
		//IL_4cb9: Expected I4, but got O
		//IL_5244: Expected I4, but got O
		//IL_52a4: Expected O, but got I4
		//IL_4d1e: Expected O, but got I4
		//IL_4d34: Expected I4, but got O
		//IL_4d94: Expected O, but got I4
		//IL_532f: Expected I4, but got O
		//IL_4db7: Expected O, but got I
		//IL_4dbf: Expected I4, but got O
		//IL_5394: Expected O, but got I4
		//IL_4e24: Expected O, but got I4
		//IL_53aa: Expected I4, but got O
		//IL_540a: Expected O, but got I4
		//IL_4e3a: Expected I4, but got O
		//IL_4e9a: Expected O, but got I4
		//IL_4eb0: Expected I, but got O
		//IL_4ec2: Expected I4, but got O
		//IL_4f22: Expected O, but got I4
		//IL_4f38: Expected I4, but got O
		//IL_4f98: Expected O, but got I4
		//IL_5023: Expected I4, but got O
		//IL_5088: Expected O, but got I4
		//IL_5542: Unknown result type (might be due to invalid IL or missing references)
		//IL_5547: Expected O, but got Unknown
		//IL_509e: Expected I4, but got O
		//IL_50fe: Expected O, but got I4
		//IL_55f4: Expected O, but got I
		//IL_5628: Expected O, but got I
		//IL_5843: Expected O, but got I
		//IL_5873: Expected O, but got I
		//IL_58ad: Expected O, but got I4
		//IL_5662: Expected O, but got I4
		//IL_51c1: Expected O, but got I4
		//IL_5947: Expected O, but got I
		//IL_5957: Expected O, but got I
		//IL_5967: Expected O, but got I
		//IL_5977: Expected O, but got I
		//IL_5987: Expected O, but got I
		//IL_598f: Expected I, but got O
		//IL_599f: Expected O, but got I
		//IL_59aa: Expected O, but got I
		//IL_56f4: Expected O, but got I
		//IL_5704: Expected O, but got I
		//IL_5714: Expected O, but got I
		//IL_5724: Expected O, but got I
		//IL_5734: Expected O, but got I
		//IL_573c: Expected I, but got O
		//IL_574c: Expected O, but got I
		//IL_5757: Expected O, but got I
		//IL_59fc: Expected O, but got I4
		//IL_57a9: Expected O, but got I4
		//IL_629e: Expected O, but got I
		//IL_62ea: Expected O, but got I
		//IL_5a49: Expected O, but got I
		//IL_5a97: Expected O, but got I
		//IL_5be4: Expected O, but got I4
		//IL_5c1a: Expected O, but got I8
		//IL_5c52: Expected O, but got I4
		//IL_5c98: Expected O, but got I4
		//IL_6343: Expected O, but got I4
		//IL_5da5: Expected O, but got I4
		//IL_5e01: Expected O, but got I4
		//IL_5e25: Expected O, but got I
		//IL_5e3f: Expected O, but got I4
		//IL_5e47: Expected O, but got I4
		//IL_5e8f: Expected O, but got I4
		object obj2 = default(object);
		object obj = (object)(&obj2);
		_ = 0;
		CardGame cardGame = game;
		bool flag = (object)game == null;
		IntPtr intPtr = default(IntPtr);
		string text = (string)(nint)intPtr;
		object obj8;
		if (!flag)
		{
			nint num = (nint)cardGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v8 (Il2CppClass<CardGame>)+180]");
			text = (string)0;
			CardGameScores gameScores = (CardGameScores)game.GameScores;
			if (gameScores != null)
			{
				object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2064;
				object obj4 = obj3;
				nint num2 = (nint)gameScores;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v11 (Il2CppClass<CardGameScores>)+130]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1251 @ X1_v8+130]");
				bool flag2 = num3 < 0;
				object obj5 = !flag2;
				object obj6 = ~obj5;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X8_v11 (Il2CppClass<CardGameScores>)+C8]");
					nint num4 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1251 @ X1_v8+130]");
					object obj7 = num4 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1369 @ X8_v13-8]");
					if (0 == (nint)obj4)
					{
						ICardGameRoundScore lastCardGameRoundScore = gameScores.LastCardGameRoundScore;
						if (lastCardGameRoundScore == null)
						{
							obj8 = this + 520;
							roundScore = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							bool flag3 = roundScore == null;
							text = (string)(object)lastCardGameRoundScore;
							if (!flag3)
							{
								goto IL_02f0;
							}
							goto IL_5f3d;
						}
						object obj9 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 2056;
						object obj10 = obj9;
						nint num5 = (nint)lastCardGameRoundScore;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1661 @ X10_v44 (Il2CppClass<ICardGameRoundScore>)+130]");
						nint num6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1664 @ X1_v205+130]");
						bool flag4 = num6 < 0;
						object obj11 = !flag4;
						object obj12 = ~obj11;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1661 @ X10_v44 (Il2CppClass<ICardGameRoundScore>)+C8]");
							nint num7 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1664 @ X1_v205+130]");
							object obj13 = num7 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1678 @ X10_v46-8]");
							if (0 == (nint)obj10)
							{
								roundScore = (BalootRoundScore)lastCardGameRoundScore;
								nint num8 = (nint)lastCardGameRoundScore;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1663 @ X10_v48 (Il2CppClass<ICardGameRoundScore>)+130]");
								nint num9 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1664 @ X1_v205+130]");
								bool flag5 = num9 < 0;
								object obj14 = !flag5;
								object obj15 = ~obj14;
								if (obj15 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1663 @ X10_v48 (Il2CppClass<ICardGameRoundScore>)+C8]");
									nint num10 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1664 @ X1_v205+130]");
									object obj16 = num10 + 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1696 @ X9_v134-8]");
									if (0 == (nint)obj10)
									{
										obj8 = this + 520;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										bool flag6 = roundScore == null;
										object obj17 = !flag6;
										if (obj17 != null)
										{
											goto IL_02f0;
										}
										text = (string)(object)lastCardGameRoundScore;
										goto IL_5f3d;
									}
								}
							}
						}
					}
				}
				throw new InvalidCastException();
			}
		}
		goto IL_5f3d;
		IL_5f4b:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_5f59;
		IL_5fdd:
		object obj19;
		object obj22;
		KPlayer playerByIndex;
		string nickName;
		bool flag29;
		object obj38 = default(object);
		object obj39;
		string text3;
		object obj41;
		object obj42;
		object obj43;
		object obj44;
		bool flag52;
		bool flag53;
		string text5;
		bool flag31 = default(bool);
		object obj40 = default(object);
		string text4 = default(string);
		object obj35;
		object obj36;
		object obj33;
		object obj34;
		bool flag8;
		if ((object)Mode != null)
		{
			string text2 = Mode.text;
			TextMeshProExtensions.FixArabic(Mode, text2);
			object obj18 = obj19;
			bool flag7 = obj19 == null;
			flag8 = false;
			text = text2;
			if (!flag7)
			{
				bool flag9 = (object)game == null;
				flag8 = false;
				text = text2;
				if (!flag9)
				{
					int num11;
					if (game.IsSpectator)
					{
						num11 = 1;
					}
					else
					{
						bool flag10 = (object)game == null;
						flag8 = false;
						text = null;
						if (flag10)
						{
							goto IL_5f3d;
						}
						num11 = game.MyTeamIndex;
					}
					object obj20 = "WhiteSmoke" + 2136;
					object obj21 = "October" + 1288;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1160 @ X8_v24+24]");
					if ((nint)0 != num11)
					{
						obj20 = obj21;
					}
					text = (string)obj20;
					TextMeshProExtensions.Localize(Bidder, (string)obj20);
					BalootRoundScore balootRoundScore = roundScore;
					bool flag11 = roundScore == null;
					flag8 = false;
					if (!flag11)
					{
						bool flag12 = (object)game == null;
						flag8 = false;
						if (!flag12)
						{
							obj22 = typeof(RegisteredWaitHandle) + 1520;
							playerByIndex = game.GetPlayerByIndex(((CardGameRoundScore)balootRoundScore).<CatchPlayerIndex>k__BackingField);
							if (playerByIndex != null)
							{
								bool flag13 = (object)CatchResultSection == null;
								flag8 = false;
								text = (string)((CardGameRoundScore)balootRoundScore).<CatchPlayerIndex>k__BackingField;
								if (!flag13)
								{
									CatchResultSection.SetActive(value: true);
									bool flag14 = (object)Catcher == null;
									flag8 = false;
									text = (string)1;
									if (!flag14)
									{
										GameObject gameObject = Catcher.gameObject;
										bool flag15 = (object)gameObject == null;
										flag8 = false;
										text = null;
										if (!flag15)
										{
											gameObject.SetActive(value: true);
											bool flag16 = (object)CatcherLabel == null;
											flag8 = false;
											text = (string)1;
											if (!flag16)
											{
												GameObject gameObject2 = CatcherLabel.gameObject;
												bool flag17 = (object)gameObject2 == null;
												flag8 = false;
												text = null;
												if (!flag17)
												{
													gameObject2.SetActive(value: true);
													bool flag18 = (object)CatchResult == null;
													flag8 = false;
													text = (string)1;
													if (!flag18)
													{
														GameObject gameObject3 = CatchResult.gameObject;
														bool flag19 = (object)gameObject3 == null;
														flag8 = false;
														text = null;
														if (!flag19)
														{
															gameObject3.SetActive(value: true);
															bool flag20 = (object)CatchResultLabel == null;
															flag8 = false;
															text = (string)1;
															if (!flag20)
															{
																GameObject gameObject4 = CatchResultLabel.gameObject;
																bool flag21 = (object)gameObject4 == null;
																flag8 = false;
																text = null;
																if (!flag21)
																{
																	gameObject4.SetActive(value: true);
																	bool flag22 = (object)BetResultSection == null;
																	flag8 = false;
																	text = (string)1;
																	if (!flag22)
																	{
																		BetResultSection.SetActive(value: false);
																		bool flag23 = (object)BetResult == null;
																		flag8 = false;
																		text = null;
																		if (!flag23)
																		{
																			GameObject gameObject5 = BetResult.gameObject;
																			bool flag24 = (object)gameObject5 == null;
																			flag8 = false;
																			text = null;
																			if (!flag24)
																			{
																				gameObject5.SetActive(value: false);
																				bool flag25 = (object)BetResultLabel == null;
																				flag8 = false;
																				text = null;
																				if (!flag25)
																				{
																					GameObject gameObject6 = BetResultLabel.gameObject;
																					bool flag26 = (object)gameObject6 == null;
																					flag8 = false;
																					text = null;
																					if (!flag26)
																					{
																						gameObject6.SetActive(value: false);
																						nickName = playerByIndex.NickName;
																						if (playerByIndex.<User>k__BackingField != null)
																						{
																							bool flag27 = SFSKammelnaUserExtensions.IsSubscribed(playerByIndex.<User>k__BackingField);
																							bool flag28 = playerByIndex.<User>k__BackingField == null;
																							flag29 = flag27;
																							if (!flag28)
																							{
																								bool flag30 = SFSKammelnaUserExtensions.IsVerified(playerByIndex.<User>k__BackingField);
																								flag31 = flag30;
																								flag29 = flag27;
																								goto IL_60ba;
																							}
																						}
																						else
																						{
																							flag29 = false;
																						}
																						flag31 = false;
																						goto IL_60ba;
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
								bool flag32 = (object)CatchResultSection == null;
								flag8 = false;
								text = (string)((CardGameRoundScore)balootRoundScore).<CatchPlayerIndex>k__BackingField;
								if (!flag32)
								{
									CatchResultSection.SetActive(value: false);
									bool flag33 = (object)Catcher == null;
									flag8 = false;
									text = null;
									if (!flag33)
									{
										GameObject gameObject7 = Catcher.gameObject;
										bool flag34 = (object)gameObject7 == null;
										flag8 = false;
										text = null;
										if (!flag34)
										{
											gameObject7.SetActive(value: false);
											bool flag35 = (object)CatcherLabel == null;
											flag8 = false;
											text = null;
											if (!flag35)
											{
												GameObject gameObject8 = CatcherLabel.gameObject;
												bool flag36 = (object)gameObject8 == null;
												flag8 = false;
												text = null;
												if (!flag36)
												{
													gameObject8.SetActive(value: false);
													bool flag37 = (object)CatchResult == null;
													flag8 = false;
													text = null;
													if (!flag37)
													{
														GameObject gameObject9 = CatchResult.gameObject;
														bool flag38 = (object)gameObject9 == null;
														flag8 = false;
														text = null;
														if (!flag38)
														{
															gameObject9.SetActive(value: false);
															bool flag39 = (object)CatchResultLabel == null;
															flag8 = false;
															text = null;
															if (!flag39)
															{
																GameObject gameObject10 = CatchResultLabel.gameObject;
																bool flag40 = (object)gameObject10 == null;
																flag8 = false;
																text = null;
																if (!flag40)
																{
																	gameObject10.SetActive(value: false);
																	bool flag41 = obj19 == null;
																	flag8 = false;
																	text = null;
																	if (!flag41)
																	{
																		bool bidderWon = ((BalootRoundScore)obj19).BidderWon;
																		object obj23 = obj22;
																		object obj26;
																		object obj27;
																		object obj28;
																		object obj29;
																		object obj30;
																		if (bidderWon)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1815 @ X0_v330+E4]");
																			bool flag42 = (nint)0 == 0;
																			object obj24 = !flag42;
																			if (obj24 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																			}
																			bool flag43 = (object)BetResult == null;
																			flag8 = false;
																			text = null;
																			if (flag43)
																			{
																				goto IL_5f3d;
																			}
																			object obj25 = obj22;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1823 @ X8_v234+B8]");
																			obj26 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1823 @ X8_v234+B8]");
																			obj27 = (nint)0 + (nint)12;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1823 @ X8_v234+B8]");
																			obj28 = (nint)0 + (nint)8;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1823 @ X8_v234+B8]");
																			obj29 = (nint)0 + (nint)4;
																			obj30 = "WhiteSmoke" + 200;
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1815 @ X0_v330+E4]");
																			bool flag44 = (nint)0 == 0;
																			object obj31 = !flag44;
																			if (obj31 == null)
																			{
																				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																			}
																			bool flag45 = (object)BetResult == null;
																			flag8 = false;
																			text = null;
																			if (flag45)
																			{
																				goto IL_5f3d;
																			}
																			object obj32 = obj22;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1830 @ X8_v232+B8]");
																			obj27 = (nint)0 + (nint)44;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1830 @ X8_v232+B8]");
																			obj28 = (nint)0 + (nint)40;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1830 @ X8_v232+B8]");
																			obj29 = (nint)0 + (nint)36;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1830 @ X8_v232+B8]");
																			obj26 = (nint)0 + (nint)32;
																			obj30 = "LAK" + 2480;
																		}
																		obj33 = obj27;
																		obj34 = obj28;
																		obj35 = obj29;
																		obj36 = obj26;
																		BetResult.color = (Color)0;
																		text = (string)obj30;
																		TextMeshProExtensions.Localize(BetResult, (string)obj30);
																		bool flag46 = (object)BetResultSection == null;
																		flag8 = false;
																		if (!flag46)
																		{
																			BetResultSection.SetActive(value: true);
																			bool flag47 = (object)BetResult == null;
																			flag8 = false;
																			text = (string)1;
																			if (!flag47)
																			{
																				GameObject gameObject11 = BetResult.gameObject;
																				bool flag48 = (object)gameObject11 == null;
																				flag8 = false;
																				text = null;
																				if (!flag48)
																				{
																					gameObject11.SetActive(value: true);
																					bool flag49 = (object)BetResultLabel == null;
																					flag8 = false;
																					text = (string)1;
																					if (!flag49)
																					{
																						GameObject gameObject12 = BetResultLabel.gameObject;
																						bool flag50 = (object)gameObject12 == null;
																						flag8 = false;
																						text = null;
																						if (!flag50)
																						{
																							gameObject12.SetActive(value: true);
																							object obj37 = typeof(SqlSingle[]) + 216;
																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																							bool flag51 = obj38 == null;
																							obj39 = obj40;
																							text3 = text4;
																							obj41 = obj29;
																							obj42 = obj26;
																							obj43 = obj27;
																							obj44 = obj28;
																							flag52 = flag31;
																							flag53 = false;
																							text5 = (string)2;
																							flag8 = false;
																							text = (string)2;
																							if (!flag51)
																							{
																								goto IL_1374;
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
		goto IL_5f3d;
		IL_5f3d:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_5f4b;
		IL_02f0:
		TextMeshProUGUI mode = Mode;
		object obj45 = default(object);
		string text6 = ((Enum)(&obj45)).ToString();
		bool flag54 = text6 == null;
		text = null;
		if (!flag54)
		{
			object obj46 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			string input = text6.ToLower();
			object obj47 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1155 @ X8_v18+E4]");
			bool flag55 = (nint)0 == 0;
			object obj48 = !flag55;
			if (obj48 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text7 = LocalizationUtil.Localize(input);
			bool flag56 = (object)Mode == null;
			text = null;
			if (!flag56)
			{
				nint num12 = (nint)mode;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1726 @ X8_v19 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
				flag8 = false;
				Mode.text = text7;
				object obj49 = obj8;
				bool flag57 = obj8 == null;
				text = text7;
				if (!flag57)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X8_v20+40]");
					bool flag58 = (nint)0 == 0;
					obj19 = obj8;
					text = text7;
					if (flag58)
					{
						goto IL_5fdd;
					}
					TextMeshProUGUI mode2 = Mode;
					bool flag59 = (object)Mode == null;
					text = text7;
					if (!flag59)
					{
						nint num13 = (nint)mode2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1750 @ X8_v248 (Il2CppClass<TMPro.TextMeshProUGUI>)+550]");
						text = (string)0;
						string text8 = Mode.text;
						if (obj8 != null)
						{
							string text9 = ((Enum)(&obj45)).ToString();
							bool flag60 = text9 == null;
							text = null;
							if (!flag60)
							{
								object obj50 = (nint)0 + (nint)3072;
								string input2 = text9.ToLower();
								object obj51 = obj46;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1776 @ X8_v252+E4]");
								bool flag61 = (nint)0 == 0;
								object obj52 = !flag61;
								if (obj52 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								string text10 = LocalizationUtil.Localize(input2);
								string text11 = text8 + (string)obj50 + text10;
								nint num14 = (nint)mode2;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1745 @ X8_v253 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
								flag8 = false;
								Mode.text = text11;
								flag31 = false;
								obj19 = obj8;
								text = text11;
								goto IL_5fdd;
							}
						}
					}
				}
			}
		}
		goto IL_5f3d;
		IL_5f59:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_1374:
		if ((object)Team1Eatings != null)
		{
			object obj53 = obj38;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1542 @ X8_v228+40]");
			text5 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag62 = ex == null;
			obj40 = obj39;
			text4 = text3;
			obj35 = obj41;
			obj36 = obj42;
			obj33 = obj43;
			obj34 = obj44;
			flag31 = flag52;
			flag8 = flag53;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1542 @ X8_v228+40]");
			text = (string)0;
			if (flag62)
			{
				goto IL_5f59;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1886 @ X0_v35+18]");
		bool flag63 = (nint)0 == 0;
		obj40 = obj39;
		text4 = text3;
		obj35 = obj41;
		obj36 = obj42;
		obj33 = obj43;
		obj34 = obj44;
		flag31 = flag52;
		flag8 = flag53;
		text = text5;
		if (!flag63)
		{
			object obj54 = obj38 + 32;
			obj54 = Team1Eatings;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag64 = (object)Team2Eatings == null;
			string text12 = (string)(object)Team1Eatings;
			if (!flag64)
			{
				object obj55 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1543 @ X8_v227+40]");
				text12 = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag65 = ex == null;
				obj40 = obj39;
				text4 = text3;
				obj35 = obj41;
				obj36 = obj42;
				obj33 = obj43;
				obj34 = obj44;
				flag31 = flag52;
				flag8 = flag53;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1543 @ X8_v227+40]");
				text = (string)0;
				if (flag65)
				{
					goto IL_5f59;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1886 @ X0_v35+18]");
			object obj56 = 0 & 0xFFFFFFFEL;
			bool flag66 = obj56 == null;
			obj40 = obj39;
			text4 = text3;
			obj35 = obj41;
			obj36 = obj42;
			obj33 = obj43;
			obj34 = obj44;
			flag31 = flag52;
			flag8 = flag53;
			text = text12;
			if (!flag66)
			{
				object obj57 = obj38 + 40;
				obj57 = Team2Eatings;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj58 = default(object);
				bool flag67 = obj58 == null;
				obj40 = obj39;
				text4 = text3;
				obj35 = obj41;
				obj36 = obj42;
				obj33 = obj43;
				obj34 = obj44;
				flag31 = flag52;
				flag8 = flag53;
				text = (string)2;
				if (flag67)
				{
					goto IL_5f3d;
				}
				bool flag68 = (object)Team1Floor == null;
				string text13 = (string)2;
				if (!flag68)
				{
					object obj59 = obj58;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1544 @ X8_v226+40]");
					text13 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag69 = ex == null;
					obj40 = obj39;
					text4 = text3;
					obj35 = obj41;
					obj36 = obj42;
					obj33 = obj43;
					obj34 = obj44;
					flag31 = flag52;
					flag8 = flag53;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1544 @ X8_v226+40]");
					text = (string)0;
					if (flag69)
					{
						goto IL_5f59;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X0_v45+18]");
				bool flag70 = (nint)0 == 0;
				obj40 = obj39;
				text4 = text3;
				obj35 = obj41;
				obj36 = obj42;
				obj33 = obj43;
				obj34 = obj44;
				flag31 = flag52;
				flag8 = flag53;
				text = text13;
				if (!flag70)
				{
					object obj60 = obj58 + 32;
					obj60 = Team1Floor;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag71 = (object)Team2Floor == null;
					string text14 = (string)(object)Team1Floor;
					if (!flag71)
					{
						object obj61 = obj58;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1545 @ X8_v225+40]");
						text14 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag72 = ex == null;
						obj40 = obj39;
						text4 = text3;
						obj35 = obj41;
						obj36 = obj42;
						obj33 = obj43;
						obj34 = obj44;
						flag31 = flag52;
						flag8 = flag53;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1545 @ X8_v225+40]");
						text = (string)0;
						if (flag72)
						{
							goto IL_5f59;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X0_v45+18]");
					object obj62 = 0 & 0xFFFFFFFEL;
					bool flag73 = obj62 == null;
					obj40 = obj39;
					text4 = text3;
					obj35 = obj41;
					obj36 = obj42;
					obj33 = obj43;
					obj34 = obj44;
					flag31 = flag52;
					flag8 = flag53;
					text = text14;
					if (!flag73)
					{
						object obj63 = typeof(List<AdaptivePerformanceScaler>) + 3880;
						object obj64 = (nint)0 + (nint)656;
						object obj65 = obj58 + 40;
						obj65 = Team2Floor;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						text = (string)obj64;
						List<object> list = default(List<object>);
						list..ctor();
						bool flag74 = list == null;
						obj40 = obj39;
						text4 = text3;
						obj35 = obj41;
						obj36 = obj42;
						obj33 = obj43;
						obj34 = obj44;
						flag31 = flag52;
						flag8 = flag53;
						if (!flag74)
						{
							object obj66 = (nint)0 + (nint)672;
							object obj67 = obj66;
							int version = list._version + 1;
							list._version = version;
							object[] items = list._items;
							bool flag75 = list._items == null;
							obj40 = obj39;
							text4 = text3;
							obj35 = obj41;
							obj36 = obj42;
							obj33 = obj43;
							obj34 = obj44;
							flag31 = flag52;
							flag8 = flag53;
							text = (string)(object)Team1Project1Name;
							if (!flag75)
							{
								bool flag76 = list._size < items.Length;
								object obj68 = !flag76;
								if (obj68 == null)
								{
									int size = list._size + 1;
									list._size = size;
									object obj69 = list._items + list._size;
									object obj70 = obj69 + 32;
									obj70 = Team1Project1Name;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1168 @ X8_v37+20]");
									object obj71 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1972 @ X8_v222+C0]");
									object obj72 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1973 @ X8_v223+70]");
									flag53 = false;
									list.AddWithResize((object)Team1Project1Name);
								}
								object obj73 = obj66;
								int version2 = list._version + 1;
								list._version = version2;
								object[] items2 = list._items;
								bool flag77 = list._items == null;
								obj40 = obj39;
								text4 = text3;
								obj35 = obj41;
								obj36 = obj42;
								obj33 = obj43;
								obj34 = obj44;
								flag31 = flag52;
								flag8 = flag53;
								text = (string)(object)Team1Project2Name;
								if (!flag77)
								{
									bool flag78 = list._size < items2.Length;
									object obj74 = !flag78;
									if (obj74 == null)
									{
										int size2 = list._size + 1;
										list._size = size2;
										object obj75 = list._items + list._size;
										object obj76 = obj75 + 32;
										obj76 = Team1Project2Name;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									}
									else
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1169 @ X8_v40+20]");
										object obj77 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1985 @ X8_v219+C0]");
										object obj78 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1986 @ X8_v220+70]");
										flag53 = false;
										list.AddWithResize((object)Team1Project2Name);
									}
									object obj79 = obj66;
									int version3 = list._version + 1;
									list._version = version3;
									object[] items3 = list._items;
									bool flag79 = list._items == null;
									obj40 = obj39;
									text4 = text3;
									obj35 = obj41;
									obj36 = obj42;
									obj33 = obj43;
									obj34 = obj44;
									flag31 = flag52;
									flag8 = flag53;
									text = (string)(object)Team1Project3Name;
									if (!flag79)
									{
										bool flag80 = list._size < items3.Length;
										object obj80 = !flag80;
										if (obj80 == null)
										{
											int size3 = list._size + 1;
											list._size = size3;
											object obj81 = list._items + list._size;
											object obj82 = obj81 + 32;
											obj82 = Team1Project3Name;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										}
										else
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1170 @ X8_v43+20]");
											object obj83 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1998 @ X8_v216+C0]");
											object obj84 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1999 @ X8_v217+70]");
											flag53 = false;
											list.AddWithResize((object)Team1Project3Name);
										}
										object obj85 = obj66;
										int version4 = list._version + 1;
										list._version = version4;
										object[] items4 = list._items;
										bool flag81 = list._items == null;
										obj40 = obj39;
										text4 = text3;
										obj35 = obj41;
										obj36 = obj42;
										obj33 = obj43;
										obj34 = obj44;
										flag31 = flag52;
										flag8 = flag53;
										text = (string)(object)Team1Project4Name;
										if (!flag81)
										{
											bool flag82 = list._size < items4.Length;
											object obj86 = !flag82;
											if (obj86 == null)
											{
												int size4 = list._size + 1;
												list._size = size4;
												object obj87 = list._items + list._size;
												object obj88 = obj87 + 32;
												obj88 = Team1Project4Name;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											}
											else
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1171 @ X8_v46+20]");
												object obj89 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2011 @ X8_v213+C0]");
												object obj90 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2012 @ X8_v214+70]");
												flag53 = false;
												list.AddWithResize((object)Team1Project4Name);
											}
											object obj91 = obj66;
											int version5 = list._version + 1;
											list._version = version5;
											object[] items5 = list._items;
											bool flag83 = list._items == null;
											obj40 = obj39;
											text4 = text3;
											obj35 = obj41;
											obj36 = obj42;
											obj33 = obj43;
											obj34 = obj44;
											flag31 = flag52;
											flag8 = flag53;
											text = (string)(object)Team1Project5Name;
											if (!flag83)
											{
												bool flag84 = list._size < items5.Length;
												object obj92 = !flag84;
												if (obj92 == null)
												{
													int size5 = list._size + 1;
													list._size = size5;
													object obj93 = list._items + list._size;
													object obj94 = obj93 + 32;
													obj94 = Team1Project5Name;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												}
												else
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1172 @ X8_v49+20]");
													object obj95 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2024 @ X8_v210+C0]");
													object obj96 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2025 @ X8_v211+70]");
													flag53 = false;
													list.AddWithResize((object)Team1Project5Name);
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
												text = (string)obj64;
												List<object> list2 = default(List<object>);
												list2..ctor();
												bool flag85 = list2 == null;
												obj40 = obj39;
												text4 = text3;
												obj35 = obj41;
												obj36 = obj42;
												obj33 = obj43;
												obj34 = obj44;
												flag31 = flag52;
												flag8 = flag53;
												if (!flag85)
												{
													object obj97 = obj66;
													int version6 = list2._version + 1;
													list2._version = version6;
													object[] items6 = list2._items;
													bool flag86 = list2._items == null;
													obj40 = obj39;
													text4 = text3;
													obj35 = obj41;
													obj36 = obj42;
													obj33 = obj43;
													obj34 = obj44;
													flag31 = flag52;
													flag8 = flag53;
													text = (string)(object)Team2Project1Name;
													if (!flag86)
													{
														bool flag87 = list2._size < items6.Length;
														object obj98 = !flag87;
														if (obj98 == null)
														{
															int size6 = list2._size + 1;
															list2._size = size6;
															object obj99 = list2._items + list2._size;
															object obj100 = obj99 + 32;
															obj100 = Team2Project1Name;
															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														}
														else
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1174 @ X8_v52+20]");
															object obj101 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2038 @ X8_v207+C0]");
															object obj102 = 0;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2039 @ X8_v208+70]");
															flag53 = false;
															list2.AddWithResize((object)Team2Project1Name);
														}
														object obj103 = obj66;
														int version7 = list2._version + 1;
														list2._version = version7;
														object[] items7 = list2._items;
														bool flag88 = list2._items == null;
														obj40 = obj39;
														text4 = text3;
														obj35 = obj41;
														obj36 = obj42;
														obj33 = obj43;
														obj34 = obj44;
														flag31 = flag52;
														flag8 = flag53;
														text = (string)(object)Team2Project2Name;
														if (!flag88)
														{
															bool flag89 = list2._size < items7.Length;
															object obj104 = !flag89;
															if (obj104 == null)
															{
																int size7 = list2._size + 1;
																list2._size = size7;
																object obj105 = list2._items + list2._size;
																object obj106 = obj105 + 32;
																obj106 = Team2Project2Name;
																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
															}
															else
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X8_v55+20]");
																object obj107 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2051 @ X8_v204+C0]");
																object obj108 = 0;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2052 @ X8_v205+70]");
																flag53 = false;
																list2.AddWithResize((object)Team2Project2Name);
															}
															object obj109 = obj66;
															int version8 = list2._version + 1;
															list2._version = version8;
															object[] items8 = list2._items;
															bool flag90 = list2._items == null;
															obj40 = obj39;
															text4 = text3;
															obj35 = obj41;
															obj36 = obj42;
															obj33 = obj43;
															obj34 = obj44;
															flag31 = flag52;
															flag8 = flag53;
															text = (string)(object)Team2Project3Name;
															if (!flag90)
															{
																bool flag91 = list2._size < items8.Length;
																object obj110 = !flag91;
																if (obj110 == null)
																{
																	int size8 = list2._size + 1;
																	list2._size = size8;
																	object obj111 = list2._items + list2._size;
																	object obj112 = obj111 + 32;
																	obj112 = Team2Project3Name;
																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																}
																else
																{
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1176 @ X8_v58+20]");
																	object obj113 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2064 @ X8_v201+C0]");
																	object obj114 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2065 @ X8_v202+70]");
																	flag53 = false;
																	list2.AddWithResize((object)Team2Project3Name);
																}
																object obj115 = obj66;
																int version9 = list2._version + 1;
																list2._version = version9;
																object[] items9 = list2._items;
																bool flag92 = list2._items == null;
																obj40 = obj39;
																text4 = text3;
																obj35 = obj41;
																obj36 = obj42;
																obj33 = obj43;
																obj34 = obj44;
																flag31 = flag52;
																flag8 = flag53;
																text = (string)(object)Team2Project4Name;
																if (!flag92)
																{
																	bool flag93 = list2._size < items9.Length;
																	object obj116 = !flag93;
																	if (obj116 == null)
																	{
																		int size9 = list2._size + 1;
																		list2._size = size9;
																		object obj117 = list2._items + list2._size;
																		object obj118 = obj117 + 32;
																		obj118 = Team2Project4Name;
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																	}
																	else
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X8_v61+20]");
																		object obj119 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2077 @ X8_v198+C0]");
																		object obj120 = 0;
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2078 @ X8_v199+70]");
																		flag53 = false;
																		list2.AddWithResize((object)Team2Project4Name);
																	}
																	object obj121 = obj66;
																	int version10 = list2._version + 1;
																	list2._version = version10;
																	object[] items10 = list2._items;
																	bool flag94 = list2._items == null;
																	obj40 = obj39;
																	text4 = text3;
																	obj35 = obj41;
																	obj36 = obj42;
																	obj33 = obj43;
																	obj34 = obj44;
																	flag31 = flag52;
																	flag8 = flag53;
																	text = (string)(object)Team2Project5Name;
																	if (!flag94)
																	{
																		object obj122 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3776;
																		object obj123 = (nint)0 + (nint)3048;
																		bool flag95 = list2._size < items10.Length;
																		object obj124 = !flag95;
																		if (obj124 == null)
																		{
																			int size10 = list2._size + 1;
																			list2._size = size10;
																			object obj125 = list2._items + list2._size;
																			object obj126 = obj125 + 32;
																			obj126 = Team2Project5Name;
																			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																		}
																		else
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1178 @ X8_v64+20]");
																			object obj127 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2092 @ X8_v195+C0]");
																			object obj128 = 0;
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2093 @ X8_v196+70]");
																			flag53 = false;
																			list2.AddWithResize((object)Team2Project5Name);
																		}
																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																		text = (string)obj123;
																		List<object> list3 = default(List<object>);
																		list3..ctor();
																		bool flag96 = list3 == null;
																		obj40 = obj39;
																		text4 = text3;
																		obj35 = obj41;
																		obj36 = obj42;
																		obj33 = obj43;
																		obj34 = obj44;
																		flag31 = flag52;
																		flag8 = flag53;
																		if (!flag96)
																		{
																			object obj129 = (nint)0 + (nint)3056;
																			object obj130 = obj129;
																			int version11 = list3._version + 1;
																			list3._version = version11;
																			object[] items11 = list3._items;
																			bool flag97 = list3._items == null;
																			obj40 = obj39;
																			text4 = text3;
																			obj35 = obj41;
																			obj36 = obj42;
																			obj33 = obj43;
																			obj34 = obj44;
																			flag31 = flag52;
																			flag8 = flag53;
																			if (!flag97)
																			{
																				bool flag98 = list3._size < items11.Length;
																				object obj131 = !flag98;
																				if (obj131 == null)
																				{
																					int size11 = list3._size + 1;
																					list3._size = size11;
																					object obj132 = list3._items + list3._size;
																					object obj133 = obj132 + 32;
																					obj133 = list;
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																					text = (string)(object)list;
																				}
																				else
																				{
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ X8_v66+20]");
																					object obj134 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2107 @ X8_v192+C0]");
																					object obj135 = 0;
																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2108 @ X8_v193+70]");
																					flag53 = false;
																					list3.AddWithResize((object)list);
																					text = (string)(object)list;
																				}
																				object obj136 = obj129;
																				int version12 = list3._version + 1;
																				list3._version = version12;
																				object[] items12 = list3._items;
																				bool flag99 = list3._items == null;
																				obj40 = obj39;
																				text4 = text3;
																				obj35 = obj41;
																				obj36 = obj42;
																				obj33 = obj43;
																				obj34 = obj44;
																				flag31 = flag52;
																				flag8 = flag53;
																				if (!flag99)
																				{
																					bool flag100 = list3._size < items12.Length;
																					object obj137 = !flag100;
																					if (obj137 == null)
																					{
																						int size12 = list3._size + 1;
																						list3._size = size12;
																						object obj138 = list3._items + list3._size;
																						object obj139 = obj138 + 32;
																						obj139 = list2;
																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																						object obj140 = list2;
																					}
																					else
																					{
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1181 @ X8_v68+20]");
																						object obj141 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2121 @ X8_v189+C0]");
																						object obj142 = 0;
																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2122 @ X8_v190+70]");
																						flag53 = false;
																						list3.AddWithResize((object)list2);
																						object obj140 = list2;
																					}
																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																					text = (string)obj64;
																					List<object> list4 = default(List<object>);
																					list4..ctor();
																					bool flag101 = list4 == null;
																					obj40 = obj39;
																					text4 = text3;
																					obj35 = obj41;
																					obj36 = obj42;
																					obj33 = obj43;
																					obj34 = obj44;
																					flag31 = flag52;
																					flag8 = flag53;
																					if (!flag101)
																					{
																						object obj143 = obj66;
																						int version13 = list4._version + 1;
																						list4._version = version13;
																						object[] items13 = list4._items;
																						bool flag102 = list4._items == null;
																						obj40 = obj39;
																						text4 = text3;
																						obj35 = obj41;
																						obj36 = obj42;
																						obj33 = obj43;
																						obj34 = obj44;
																						flag31 = flag52;
																						flag8 = flag53;
																						text = (string)(object)Team1Project1Score;
																						if (!flag102)
																						{
																							bool flag103 = list4._size < items13.Length;
																							object obj144 = !flag103;
																							if (obj144 == null)
																							{
																								int size13 = list4._size + 1;
																								list4._size = size13;
																								object obj145 = list4._items + list4._size;
																								object obj146 = obj145 + 32;
																								obj146 = Team1Project1Score;
																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																							}
																							else
																							{
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1183 @ X8_v71+20]");
																								object obj147 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2137 @ X8_v186+C0]");
																								object obj148 = 0;
																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2138 @ X8_v187+70]");
																								flag53 = false;
																								list4.AddWithResize((object)Team1Project1Score);
																							}
																							object obj149 = obj66;
																							int version14 = list4._version + 1;
																							list4._version = version14;
																							object[] items14 = list4._items;
																							bool flag104 = list4._items == null;
																							obj40 = obj39;
																							text4 = text3;
																							obj35 = obj41;
																							obj36 = obj42;
																							obj33 = obj43;
																							obj34 = obj44;
																							flag31 = flag52;
																							flag8 = flag53;
																							text = (string)(object)Team1Project2Score;
																							if (!flag104)
																							{
																								bool flag105 = list4._size < items14.Length;
																								object obj150 = !flag105;
																								if (obj150 == null)
																								{
																									int size14 = list4._size + 1;
																									list4._size = size14;
																									object obj151 = list4._items + list4._size;
																									object obj152 = obj151 + 32;
																									obj152 = Team1Project2Score;
																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																								}
																								else
																								{
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ X8_v74+20]");
																									object obj153 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2150 @ X8_v183+C0]");
																									object obj154 = 0;
																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2151 @ X8_v184+70]");
																									flag53 = false;
																									list4.AddWithResize((object)Team1Project2Score);
																								}
																								object obj155 = obj66;
																								int version15 = list4._version + 1;
																								list4._version = version15;
																								object[] items15 = list4._items;
																								bool flag106 = list4._items == null;
																								obj40 = obj39;
																								text4 = text3;
																								obj35 = obj41;
																								obj36 = obj42;
																								obj33 = obj43;
																								obj34 = obj44;
																								flag31 = flag52;
																								flag8 = flag53;
																								text = (string)(object)Team1Project3Score;
																								if (!flag106)
																								{
																									bool flag107 = list4._size < items15.Length;
																									object obj156 = !flag107;
																									if (obj156 == null)
																									{
																										int size15 = list4._size + 1;
																										list4._size = size15;
																										object obj157 = list4._items + list4._size;
																										object obj158 = obj157 + 32;
																										obj158 = Team1Project3Score;
																										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																									}
																									else
																									{
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1185 @ X8_v77+20]");
																										object obj159 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2163 @ X8_v180+C0]");
																										object obj160 = 0;
																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2164 @ X8_v181+70]");
																										flag53 = false;
																										list4.AddWithResize((object)Team1Project3Score);
																									}
																									object obj161 = obj66;
																									int version16 = list4._version + 1;
																									list4._version = version16;
																									object[] items16 = list4._items;
																									bool flag108 = list4._items == null;
																									obj40 = obj39;
																									text4 = text3;
																									obj35 = obj41;
																									obj36 = obj42;
																									obj33 = obj43;
																									obj34 = obj44;
																									flag31 = flag52;
																									flag8 = flag53;
																									text = (string)(object)Team1Project4Score;
																									if (!flag108)
																									{
																										bool flag109 = list4._size < items16.Length;
																										object obj162 = !flag109;
																										if (obj162 == null)
																										{
																											int size16 = list4._size + 1;
																											list4._size = size16;
																											object obj163 = list4._items + list4._size;
																											object obj164 = obj163 + 32;
																											obj164 = Team1Project4Score;
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																										}
																										else
																										{
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ X8_v80+20]");
																											object obj165 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2176 @ X8_v177+C0]");
																											object obj166 = 0;
																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2177 @ X8_v178+70]");
																											flag53 = false;
																											list4.AddWithResize((object)Team1Project4Score);
																										}
																										object obj167 = obj66;
																										int version17 = list4._version + 1;
																										list4._version = version17;
																										object[] items17 = list4._items;
																										bool flag110 = list4._items == null;
																										obj40 = obj39;
																										text4 = text3;
																										obj35 = obj41;
																										obj36 = obj42;
																										obj33 = obj43;
																										obj34 = obj44;
																										flag31 = flag52;
																										flag8 = flag53;
																										text = (string)(object)Team1Project5Score;
																										if (!flag110)
																										{
																											bool flag111 = list4._size < items17.Length;
																											object obj168 = !flag111;
																											if (obj168 == null)
																											{
																												int size17 = list4._size + 1;
																												list4._size = size17;
																												object obj169 = list4._items + list4._size;
																												object obj170 = obj169 + 32;
																												obj170 = Team1Project5Score;
																												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																											}
																											else
																											{
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1187 @ X8_v83+20]");
																												object obj171 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2189 @ X8_v174+C0]");
																												object obj172 = 0;
																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2190 @ X8_v175+70]");
																												flag53 = false;
																												list4.AddWithResize((object)Team1Project5Score);
																											}
																											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																											text = (string)obj64;
																											List<object> list5 = default(List<object>);
																											list5..ctor();
																											bool flag112 = list5 == null;
																											obj40 = obj39;
																											text4 = text3;
																											obj35 = obj41;
																											obj36 = obj42;
																											obj33 = obj43;
																											obj34 = obj44;
																											flag31 = flag52;
																											flag8 = flag53;
																											if (!flag112)
																											{
																												object obj173 = obj66;
																												int version18 = list5._version + 1;
																												list5._version = version18;
																												object[] items18 = list5._items;
																												bool flag113 = list5._items == null;
																												obj40 = obj39;
																												text4 = text3;
																												obj35 = obj41;
																												obj36 = obj42;
																												obj33 = obj43;
																												obj34 = obj44;
																												flag31 = flag52;
																												flag8 = flag53;
																												text = (string)(object)Team2Project1Score;
																												if (!flag113)
																												{
																													bool flag114 = list5._size < items18.Length;
																													object obj174 = !flag114;
																													if (obj174 == null)
																													{
																														int size18 = list5._size + 1;
																														list5._size = size18;
																														object obj175 = list5._items + list5._size;
																														object obj176 = obj175 + 32;
																														obj176 = Team2Project1Score;
																														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																													}
																													else
																													{
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1189 @ X8_v85+20]");
																														object obj177 = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2202 @ X8_v171+C0]");
																														object obj178 = 0;
																														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2203 @ X8_v172+70]");
																														flag53 = false;
																														list5.AddWithResize((object)Team2Project1Score);
																													}
																													object obj179 = obj66;
																													int version19 = list5._version + 1;
																													list5._version = version19;
																													object[] items19 = list5._items;
																													bool flag115 = list5._items == null;
																													obj40 = obj39;
																													text4 = text3;
																													obj35 = obj41;
																													obj36 = obj42;
																													obj33 = obj43;
																													obj34 = obj44;
																													flag31 = flag52;
																													flag8 = flag53;
																													text = (string)(object)Team2Project2Score;
																													if (!flag115)
																													{
																														bool flag116 = list5._size < items19.Length;
																														object obj180 = !flag116;
																														if (obj180 == null)
																														{
																															int size19 = list5._size + 1;
																															list5._size = size19;
																															object obj181 = list5._items + list5._size;
																															object obj182 = obj181 + 32;
																															obj182 = Team2Project2Score;
																															Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																														}
																														else
																														{
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1190 @ X8_v87+20]");
																															object obj183 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2214 @ X8_v168+C0]");
																															object obj184 = 0;
																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2215 @ X8_v169+70]");
																															flag53 = false;
																															list5.AddWithResize((object)Team2Project2Score);
																														}
																														object obj185 = obj66;
																														int version20 = list5._version + 1;
																														list5._version = version20;
																														object[] items20 = list5._items;
																														bool flag117 = list5._items == null;
																														obj40 = obj39;
																														text4 = text3;
																														obj35 = obj41;
																														obj36 = obj42;
																														obj33 = obj43;
																														obj34 = obj44;
																														flag31 = flag52;
																														flag8 = flag53;
																														text = (string)(object)Team2Project3Score;
																														if (!flag117)
																														{
																															bool flag118 = list5._size < items20.Length;
																															object obj186 = !flag118;
																															if (obj186 == null)
																															{
																																int size20 = list5._size + 1;
																																list5._size = size20;
																																object obj187 = list5._items + list5._size;
																																object obj188 = obj187 + 32;
																																obj188 = Team2Project3Score;
																																Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																															}
																															else
																															{
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1191 @ X8_v89+20]");
																																object obj189 = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2226 @ X8_v165+C0]");
																																object obj190 = 0;
																																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2227 @ X8_v166+70]");
																																flag53 = false;
																																list5.AddWithResize((object)Team2Project3Score);
																															}
																															object obj191 = obj66;
																															int version21 = list5._version + 1;
																															list5._version = version21;
																															object[] items21 = list5._items;
																															bool flag119 = list5._items == null;
																															obj40 = obj39;
																															text4 = text3;
																															obj35 = obj41;
																															obj36 = obj42;
																															obj33 = obj43;
																															obj34 = obj44;
																															flag31 = flag52;
																															flag8 = flag53;
																															text = (string)(object)Team2Project4Score;
																															if (!flag119)
																															{
																																bool flag120 = list5._size < items21.Length;
																																object obj192 = !flag120;
																																if (obj192 == null)
																																{
																																	int size21 = list5._size + 1;
																																	list5._size = size21;
																																	object obj193 = list5._items + list5._size;
																																	object obj194 = obj193 + 32;
																																	obj194 = Team2Project4Score;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																}
																																else
																																{
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1192 @ X8_v91+20]");
																																	object obj195 = 0;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2238 @ X8_v162+C0]");
																																	object obj196 = 0;
																																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2239 @ X8_v163+70]");
																																	flag53 = false;
																																	list5.AddWithResize((object)Team2Project4Score);
																																}
																																object obj197 = obj66;
																																int version22 = list5._version + 1;
																																list5._version = version22;
																																object[] items22 = list5._items;
																																bool flag121 = list5._items == null;
																																obj40 = obj39;
																																text4 = text3;
																																obj35 = obj41;
																																obj36 = obj42;
																																obj33 = obj43;
																																obj34 = obj44;
																																flag31 = flag52;
																																flag8 = flag53;
																																text = (string)(object)Team2Project5Score;
																																if (!flag121)
																																{
																																	bool flag122 = list5._size < items22.Length;
																																	object obj198 = !flag122;
																																	if (obj198 == null)
																																	{
																																		int size22 = list5._size + 1;
																																		list5._size = size22;
																																		object obj199 = list5._items + list5._size;
																																		object obj200 = obj199 + 32;
																																		obj200 = Team2Project5Score;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																	}
																																	else
																																	{
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1193 @ X8_v93+20]");
																																		object obj201 = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2250 @ X8_v159+C0]");
																																		object obj202 = 0;
																																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2251 @ X8_v160+70]");
																																		flag53 = false;
																																		list5.AddWithResize((object)Team2Project5Score);
																																	}
																																	Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
																																	text = (string)obj123;
																																	List<object> list6 = default(List<object>);
																																	list6..ctor();
																																	bool flag123 = list6 == null;
																																	obj40 = obj39;
																																	text4 = text3;
																																	obj35 = obj41;
																																	obj36 = obj42;
																																	obj33 = obj43;
																																	obj34 = obj44;
																																	flag31 = flag52;
																																	flag8 = flag53;
																																	if (!flag123)
																																	{
																																		object obj203 = obj129;
																																		int version23 = list6._version + 1;
																																		list6._version = version23;
																																		object[] items23 = list6._items;
																																		bool flag124 = list6._items == null;
																																		obj40 = obj39;
																																		text4 = text3;
																																		obj35 = obj41;
																																		obj36 = obj42;
																																		obj33 = obj43;
																																		obj34 = obj44;
																																		flag31 = flag52;
																																		flag8 = flag53;
																																		if (!flag124)
																																		{
																																			bool flag125 = list6._size < items23.Length;
																																			object obj204 = !flag125;
																																			if (obj204 == null)
																																			{
																																				int size23 = list6._size + 1;
																																				list6._size = size23;
																																				object obj205 = list6._items + list6._size;
																																				object obj206 = obj205 + 32;
																																				obj206 = list4;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																				text = (string)(object)list4;
																																			}
																																			else
																																			{
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1195 @ X8_v95+20]");
																																				object obj207 = 0;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2264 @ X8_v156+C0]");
																																				object obj208 = 0;
																																				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2265 @ X8_v157+70]");
																																				flag53 = false;
																																				list6.AddWithResize((object)list4);
																																				text = (string)(object)list4;
																																			}
																																			object obj209 = obj129;
																																			int version24 = list6._version + 1;
																																			list6._version = version24;
																																			object[] items24 = list6._items;
																																			bool flag126 = list6._items == null;
																																			obj40 = obj39;
																																			text4 = text3;
																																			obj35 = obj41;
																																			obj36 = obj42;
																																			obj33 = obj43;
																																			obj34 = obj44;
																																			flag31 = flag52;
																																			flag8 = flag53;
																																			if (!flag126)
																																			{
																																				bool flag127 = list6._size < items24.Length;
																																				object obj210 = !flag127;
																																				if (obj210 == null)
																																				{
																																					int size24 = list6._size + 1;
																																					list6._size = size24;
																																					object obj211 = list6._items + list6._size;
																																					object obj212 = obj211 + 32;
																																					obj212 = list5;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																				}
																																				else
																																				{
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1196 @ X8_v97+20]");
																																					object obj213 = 0;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2278 @ X8_v153+C0]");
																																					object obj214 = 0;
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2279 @ X8_v154+70]");
																																					flag53 = false;
																																					list6.AddWithResize((object)list5);
																																				}
																																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																																				object obj215 = default(object);
																																				bool flag128 = obj215 == null;
																																				obj40 = obj39;
																																				text4 = text3;
																																				obj35 = obj41;
																																				obj36 = obj42;
																																				obj33 = obj43;
																																				obj34 = obj44;
																																				flag31 = flag52;
																																				flag8 = flag53;
																																				text = (string)2;
																																				if (!flag128)
																																				{
																																					bool flag129 = (object)Team1Points == null;
																																					string text15 = (string)2;
																																					if (!flag129)
																																					{
																																						object obj216 = obj215;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1546 @ X8_v152+40]");
																																						text15 = (string)0;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																																						bool flag130 = ex == null;
																																						obj40 = obj39;
																																						text4 = text3;
																																						obj35 = obj41;
																																						obj36 = obj42;
																																						obj33 = obj43;
																																						obj34 = obj44;
																																						flag31 = flag52;
																																						flag8 = flag53;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1546 @ X8_v152+40]");
																																						text = (string)0;
																																						if (flag130)
																																						{
																																							goto IL_5f59;
																																						}
																																					}
																																					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X0_v89+18]");
																																					bool flag131 = (nint)0 == 0;
																																					obj40 = obj39;
																																					text4 = text3;
																																					obj35 = obj41;
																																					obj36 = obj42;
																																					obj33 = obj43;
																																					obj34 = obj44;
																																					flag31 = flag52;
																																					flag8 = flag53;
																																					text = text15;
																																					if (!flag131)
																																					{
																																						object obj217 = obj215 + 32;
																																						obj217 = Team1Points;
																																						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																						bool flag132 = (object)Team2Points == null;
																																						string text16 = (string)(object)Team1Points;
																																						if (!flag132)
																																						{
																																							object obj218 = obj215;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1547 @ X8_v151+40]");
																																							text16 = (string)0;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																																							bool flag133 = ex == null;
																																							obj40 = obj39;
																																							text4 = text3;
																																							obj35 = obj41;
																																							obj36 = obj42;
																																							obj33 = obj43;
																																							obj34 = obj44;
																																							flag31 = flag52;
																																							flag8 = flag53;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1547 @ X8_v151+40]");
																																							text = (string)0;
																																							if (flag133)
																																							{
																																								goto IL_5f59;
																																							}
																																						}
																																						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X0_v89+18]");
																																						object obj219 = 0 & 0xFFFFFFFEL;
																																						bool flag134 = obj219 == null;
																																						obj40 = obj39;
																																						text4 = text3;
																																						obj35 = obj41;
																																						obj36 = obj42;
																																						obj33 = obj43;
																																						obj34 = obj44;
																																						flag31 = flag52;
																																						flag8 = flag53;
																																						text = text16;
																																						if (!flag134)
																																						{
																																							object obj220 = obj215 + 40;
																																							obj220 = Team2Points;
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
																																							object obj221 = default(object);
																																							bool flag135 = obj221 == null;
																																							obj40 = obj39;
																																							text4 = text3;
																																							obj35 = obj41;
																																							obj36 = obj42;
																																							obj33 = obj43;
																																							obj34 = obj44;
																																							flag31 = flag52;
																																							flag8 = flag53;
																																							text = (string)2;
																																							if (flag135)
																																							{
																																								goto IL_5f3d;
																																							}
																																							bool flag136 = (object)Team1Score == null;
																																							string text17 = (string)2;
																																							if (!flag136)
																																							{
																																								object obj222 = obj221;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1548 @ X8_v150+40]");
																																								text17 = (string)0;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																																								bool flag137 = ex == null;
																																								obj40 = obj39;
																																								text4 = text3;
																																								obj35 = obj41;
																																								obj36 = obj42;
																																								obj33 = obj43;
																																								obj34 = obj44;
																																								flag31 = flag52;
																																								flag8 = flag53;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1548 @ X8_v150+40]");
																																								text = (string)0;
																																								if (flag137)
																																								{
																																									goto IL_5f59;
																																								}
																																							}
																																							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X0_v99+18]");
																																							bool flag138 = (nint)0 == 0;
																																							obj40 = obj39;
																																							text4 = text3;
																																							obj35 = obj41;
																																							obj36 = obj42;
																																							obj33 = obj43;
																																							obj34 = obj44;
																																							flag31 = flag52;
																																							flag8 = flag53;
																																							text = text17;
																																							if (!flag138)
																																							{
																																								object obj223 = obj221 + 32;
																																								obj223 = Team1Score;
																																								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																								bool flag139 = (object)Team2Score == null;
																																								string text18 = (string)(object)Team1Score;
																																								if (!flag139)
																																								{
																																									object obj224 = obj221;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1549 @ X8_v149+40]");
																																									text18 = (string)0;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
																																									bool flag140 = ex == null;
																																									obj40 = obj39;
																																									text4 = text3;
																																									obj35 = obj41;
																																									obj36 = obj42;
																																									obj33 = obj43;
																																									obj34 = obj44;
																																									flag31 = flag52;
																																									flag8 = flag53;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1549 @ X8_v149+40]");
																																									text = (string)0;
																																									if (flag140)
																																									{
																																										goto IL_5f59;
																																									}
																																								}
																																								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X0_v99+18]");
																																								object obj225 = 0 & 0xFFFFFFFEL;
																																								bool flag141 = obj225 == null;
																																								obj40 = obj39;
																																								text4 = text3;
																																								obj35 = obj41;
																																								obj36 = obj42;
																																								obj33 = obj43;
																																								obj34 = obj44;
																																								flag31 = flag52;
																																								flag8 = flag53;
																																								text = text18;
																																								if (!flag141)
																																								{
																																									object obj226 = (nint)0 + (nint)3064;
																																									object obj227 = (nint)0 + (nint)704;
																																									object obj228 = obj221 + 40;
																																									obj228 = Team2Score;
																																									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
																																									int num15 = 1;
																																									BalootRoundBoardPopup balootRoundBoardPopup = this;
																																									text = (string)(object)Team2Score;
																																									while (true)
																																									{
																																										bool flag142 = (object)balootRoundBoardPopup.game == null;
																																										obj40 = obj39;
																																										text4 = text3;
																																										obj35 = obj41;
																																										obj36 = obj42;
																																										obj33 = obj43;
																																										obj34 = obj44;
																																										flag31 = flag52;
																																										flag8 = flag53;
																																										if (flag142)
																																										{
																																											break;
																																										}
																																										int num16;
																																										if (balootRoundBoardPopup.game.IsSpectator)
																																										{
																																											text = null;
																																											num16 = 1;
																																										}
																																										else
																																										{
																																											bool flag143 = (object)balootRoundBoardPopup.game == null;
																																											obj40 = obj39;
																																											text4 = text3;
																																											obj35 = obj41;
																																											obj36 = obj42;
																																											obj33 = obj43;
																																											obj34 = obj44;
																																											flag31 = flag52;
																																											flag8 = flag53;
																																											text = null;
																																											if (flag143)
																																											{
																																												break;
																																											}
																																											num16 = balootRoundBoardPopup.game.MyTeamIndex;
																																											text = null;
																																										}
																																										object obj229 = num15 - num16;
																																										object obj230 = obj229 + 2;
																																										int num17 = obj230 & 1;
																																										bool flag144 = (nint)obj230 < 0;
																																										object obj231 = obj230 ^ obj230;
																																										object obj232 = obj230 & obj231;
																																										bool flag145 = (nint)obj232 < 0;
																																										bool flag146 = flag144 == flag145;
																																										object obj233 = !flag146;
																																										object obj234 = ~obj233;
																																										int num18 = ((obj234 != null) ? num17 : (-num17));
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1886 @ X0_v35+18]");
																																										bool flag147 = (nint)num18 < (nint)0;
																																										object obj235 = !flag147;
																																										obj40 = obj39;
																																										text4 = text3;
																																										obj35 = obj41;
																																										obj36 = obj42;
																																										obj33 = obj43;
																																										obj34 = obj44;
																																										flag31 = flag52;
																																										flag8 = flag53;
																																										if (obj235 == null)
																																										{
																																											bool flag148 = obj8 == null;
																																											obj40 = obj39;
																																											text4 = text3;
																																											obj35 = obj41;
																																											obj36 = obj42;
																																											obj33 = obj43;
																																											obj34 = obj44;
																																											flag31 = flag52;
																																											flag8 = flag53;
																																											if (flag148)
																																											{
																																												break;
																																											}
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1925 @ X0_v38+v1200 @ X8_v110 (System.Int32)*8]");
																																											object obj236 = 0;
																																											int teamEeatings = ((CardGameRoundScore)obj8).GetTeamEeatings(num15);
																																											int num19 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 84));
																																											string text19 = ((int*)num19)->ToString();
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1925 @ X0_v38+v1200 @ X8_v110 (System.Int32)*8]");
																																											bool flag149 = (nint)0 == 0;
																																											obj40 = obj39;
																																											text4 = text3;
																																											obj35 = obj41;
																																											obj36 = obj42;
																																											obj33 = obj43;
																																											obj34 = obj44;
																																											flag31 = flag52;
																																											flag8 = false;
																																											text = null;
																																											if (flag149)
																																											{
																																												break;
																																											}
																																											object obj237 = obj236;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2352 @ X8_v112+560]");
																																											flag8 = false;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2352 @ X8_v112+558] (should have been resolved before IL gen)");
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v973 @ X0_v89+18]");
																																											bool flag150 = (nint)num18 < (nint)0;
																																											object obj238 = !flag150;
																																											obj40 = obj39;
																																											text4 = text3;
																																											obj35 = obj41;
																																											obj36 = obj42;
																																											obj33 = obj43;
																																											obj34 = obj44;
																																											flag31 = flag52;
																																											text = text19;
																																											if (obj238 == null)
																																											{
																																												bool flag151 = obj8 == null;
																																												obj40 = obj39;
																																												text4 = text3;
																																												obj35 = obj41;
																																												obj36 = obj42;
																																												obj33 = obj43;
																																												obj34 = obj44;
																																												flag31 = flag52;
																																												text = text19;
																																												if (flag151)
																																												{
																																													break;
																																												}
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2291 @ X0_v92+v1200 @ X8_v110 (System.Int32)*8]");
																																												object obj239 = 0;
																																												int teamAbnat = ((BalootRoundScore)obj8).GetTeamAbnat(num15);
																																												int num20 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 84));
																																												string text20 = ((int*)num20)->ToString();
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2291 @ X0_v92+v1200 @ X8_v110 (System.Int32)*8]");
																																												bool flag152 = (nint)0 == 0;
																																												obj40 = obj39;
																																												text4 = text3;
																																												obj35 = obj41;
																																												obj36 = obj42;
																																												obj33 = obj43;
																																												obj34 = obj44;
																																												flag31 = flag52;
																																												flag8 = false;
																																												text = null;
																																												if (flag152)
																																												{
																																													break;
																																												}
																																												object obj240 = obj239;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2359 @ X8_v116+560]");
																																												flag8 = false;
																																												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v2359 @ X8_v116+558] (should have been resolved before IL gen)");
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v974 @ X0_v99+18]");
																																												bool flag153 = (nint)num18 < (nint)0;
																																												object obj241 = !flag153;
																																												obj40 = obj39;
																																												text4 = text3;
																																												obj35 = obj41;
																																												obj36 = obj42;
																																												obj33 = obj43;
																																												obj34 = obj44;
																																												flag31 = flag52;
																																												text = text20;
																																												if (obj241 == null)
																																												{
																																													bool flag154 = obj8 == null;
																																													obj40 = obj39;
																																													text4 = text3;
																																													obj35 = obj41;
																																													obj36 = obj42;
																																													obj33 = obj43;
																																													obj34 = obj44;
																																													flag31 = flag52;
																																													text = text20;
																																													if (flag154)
																																													{
																																														break;
																																													}
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2308 @ X0_v102+v1200 @ X8_v110 (System.Int32)*8]");
																																													object obj242 = 0;
																																													int teamScore = ((CardGameRoundScore)obj8).GetTeamScore(num15);
																																													int num21 = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 84));
																																													string text21 = ((int*)num21)->ToString();
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2308 @ X0_v102+v1200 @ X8_v110 (System.Int32)*8]");
																																													bool flag155 = (nint)0 == 0;
																																													obj40 = obj39;
																																													text4 = text3;
																																													obj35 = obj41;
																																													obj36 = obj42;
																																													obj33 = obj43;
																																													obj34 = obj44;
																																													flag31 = flag52;
																																													flag8 = false;
																																													text = null;
																																													if (flag155)
																																													{
																																														break;
																																													}
																																													object obj243 = obj242;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1206 @ X8_v120+560]");
																																													flag8 = false;
																																													Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1206 @ X8_v120+558] (should have been resolved before IL gen)");
																																													bool flag156 = obj8 == null;
																																													obj40 = obj39;
																																													text4 = text3;
																																													obj35 = obj41;
																																													obj36 = obj42;
																																													obj33 = obj43;
																																													obj34 = obj44;
																																													flag31 = flag52;
																																													text = text21;
																																													if (flag156)
																																													{
																																														break;
																																													}
																																													List<BalootRoundScore.TeamProject> teamProjects = ((BalootRoundScore)obj8).GetTeamProjects(num15);
																																													bool flag157 = teamProjects == null;
																																													obj40 = obj39;
																																													text4 = text3;
																																													obj35 = obj41;
																																													obj36 = obj42;
																																													obj33 = obj43;
																																													obj34 = obj44;
																																													flag31 = flag52;
																																													flag8 = false;
																																													text = (string)num15;
																																													if (flag157)
																																													{
																																														break;
																																													}
																																													int num22 = 0;
																																													while (true)
																																													{
																																														if (num22 < teamProjects._size)
																																														{
																																															object obj244 = ((List<object>)(object)teamProjects).get_Item(num22);
																																															flag8 = (byte)(int)obj226 != 0;
																																															object obj245 = list3.get_Item(num18);
																																															bool flag158 = obj245 == null;
																																															obj40 = obj39;
																																															text4 = text3;
																																															obj35 = obj41;
																																															obj36 = obj42;
																																															obj33 = obj43;
																																															obj34 = obj44;
																																															flag31 = flag52;
																																															text = (string)num18;
																																															if (flag158)
																																															{
																																																break;
																																															}
																																															flag8 = (byte)(int)obj227 != 0;
																																															object textMesh = ((List<object>)obj245).get_Item(num22);
																																															bool flag159 = obj244 == null;
																																															obj40 = obj39;
																																															text4 = text3;
																																															obj35 = obj41;
																																															obj36 = obj42;
																																															obj33 = obj43;
																																															obj34 = obj44;
																																															flag31 = flag52;
																																															text = (string)num22;
																																															if (flag159)
																																															{
																																																break;
																																															}
																																															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2411 @ X0_v141 (System.Object)+10]");
																																															TextMeshProExtensions.Localize((TextMeshProUGUI)textMesh, (string)0);
																																															flag8 = (byte)(int)obj226 != 0;
																																															object obj246 = list6.get_Item(num18);
																																															bool flag160 = obj246 == null;
																																															obj40 = obj39;
																																															text4 = text3;
																																															obj35 = obj41;
																																															obj36 = obj42;
																																															obj33 = obj43;
																																															obj34 = obj44;
																																															flag31 = flag52;
																																															text = (string)num18;
																																															if (flag160)
																																															{
																																																break;
																																															}
																																															flag8 = (byte)(int)obj227 != 0;
																																															object obj247 = ((List<object>)obj246).get_Item(num22);
																																															bool flag161 = obj247 == null;
																																															obj40 = obj39;
																																															text4 = text3;
																																															obj35 = obj41;
																																															obj36 = obj42;
																																															obj33 = obj43;
																																															obj34 = obj44;
																																															flag31 = flag52;
																																															text = (string)num22;
																																															if (flag161)
																																															{
																																																break;
																																															}
																																															nint num23 = (nint)obj247;
																																															Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1208 @ X8_v123 (Il2CppClass<System.Object>)+558] (should have been resolved before IL gen)");
																																															flag8 = (byte)(int)obj226 != 0;
																																															object obj248 = list3.get_Item(num18);
																																															bool flag162 = obj248 == null;
																																															obj40 = obj39;
																																															text4 = text3;
																																															obj35 = obj41;
																																															obj36 = obj42;
																																															obj33 = obj43;
																																															obj34 = obj44;
																																															flag31 = flag52;
																																															text = (string)num18;
																																															if (flag162)
																																															{
																																																break;
																																															}
																																															flag8 = (byte)(int)obj227 != 0;
																																															object obj249 = ((List<object>)obj248).get_Item(num22);
																																															bool flag163 = obj249 == null;
																																															obj40 = obj39;
																																															text4 = text3;
																																															obj35 = obj41;
																																															obj36 = obj42;
																																															obj33 = obj43;
																																															obj34 = obj44;
																																															flag31 = flag52;
																																															text = (string)num22;
																																															if (flag163)
																																															{
																																																break;
																																															}
																																															GameObject gameObject13 = ((Component)obj249).gameObject;
																																															bool flag164 = (object)gameObject13 == null;
																																															obj40 = obj39;
																																															text4 = text3;
																																															obj35 = obj41;
																																															obj36 = obj42;
																																															obj33 = obj43;
																																															obj34 = obj44;
																																															flag31 = flag52;
																																															text = null;
																																															if (flag164)
																																															{
																																																break;
																																															}
																																															gameObject13.SetActive(value: true);
																																															flag8 = (byte)(int)obj226 != 0;
																																															object obj250 = list6.get_Item(num18);
																																															bool flag165 = obj250 == null;
																																															obj40 = obj39;
																																															text4 = text3;
																																															obj35 = obj41;
																																															obj36 = obj42;
																																															obj33 = obj43;
																																															obj34 = obj44;
																																															flag31 = flag52;
																																															text = (string)num18;
																																															if (flag165)
																																															{
																																																break;
																																															}
																																															flag8 = (byte)(int)obj227 != 0;
																																															object obj251 = ((List<object>)obj250).get_Item(num22);
																																															bool flag166 = obj251 == null;
																																															obj40 = obj39;
																																															text4 = text3;
																																															obj35 = obj41;
																																															obj36 = obj42;
																																															obj33 = obj43;
																																															obj34 = obj44;
																																															flag31 = flag52;
																																															text = (string)num22;
																																															if (flag166)
																																															{
																																																break;
																																															}
																																															GameObject gameObject14 = ((Component)obj251).gameObject;
																																															bool flag167 = (object)gameObject14 == null;
																																															obj40 = obj39;
																																															text4 = text3;
																																															obj35 = obj41;
																																															obj36 = obj42;
																																															obj33 = obj43;
																																															obj34 = obj44;
																																															flag31 = flag52;
																																															text = null;
																																															if (flag167)
																																															{
																																																break;
																																															}
																																															gameObject14.SetActive(value: true);
																																															num22++;
																																															if (num22 != 5)
																																															{
																																																continue;
																																															}
																																															goto IL_51af;
																																														}
																																														flag8 = (byte)(int)obj226 != 0;
																																														object obj252 = list3.get_Item(num18);
																																														bool flag168 = obj252 == null;
																																														obj40 = obj39;
																																														text4 = text3;
																																														obj35 = obj41;
																																														obj36 = obj42;
																																														obj33 = obj43;
																																														obj34 = obj44;
																																														flag31 = flag52;
																																														text = (string)num18;
																																														if (flag168)
																																														{
																																															break;
																																														}
																																														flag8 = (byte)(int)obj227 != 0;
																																														object obj253 = ((List<object>)obj252).get_Item(num22);
																																														bool flag169 = obj253 == null;
																																														obj40 = obj39;
																																														text4 = text3;
																																														obj35 = obj41;
																																														obj36 = obj42;
																																														obj33 = obj43;
																																														obj34 = obj44;
																																														flag31 = flag52;
																																														text = (string)num22;
																																														if (flag169)
																																														{
																																															break;
																																														}
																																														GameObject gameObject15 = ((Component)obj253).gameObject;
																																														bool flag170 = (object)gameObject15 == null;
																																														obj40 = obj39;
																																														text4 = text3;
																																														obj35 = obj41;
																																														obj36 = obj42;
																																														obj33 = obj43;
																																														obj34 = obj44;
																																														flag31 = flag52;
																																														text = null;
																																														if (flag170)
																																														{
																																															break;
																																														}
																																														gameObject15.SetActive(value: false);
																																														flag8 = (byte)(int)obj226 != 0;
																																														object obj254 = list6.get_Item(num18);
																																														bool flag171 = obj254 == null;
																																														obj40 = obj39;
																																														text4 = text3;
																																														obj35 = obj41;
																																														obj36 = obj42;
																																														obj33 = obj43;
																																														obj34 = obj44;
																																														flag31 = flag52;
																																														text = (string)num18;
																																														if (flag171)
																																														{
																																															break;
																																														}
																																														flag8 = (byte)(int)obj227 != 0;
																																														object obj255 = ((List<object>)obj254).get_Item(num22);
																																														bool flag172 = obj255 == null;
																																														obj40 = obj39;
																																														text4 = text3;
																																														obj35 = obj41;
																																														obj36 = obj42;
																																														obj33 = obj43;
																																														obj34 = obj44;
																																														flag31 = flag52;
																																														text = (string)num22;
																																														if (flag172)
																																														{
																																															break;
																																														}
																																														GameObject gameObject16 = ((Component)obj255).gameObject;
																																														bool flag173 = (object)gameObject16 == null;
																																														obj40 = obj39;
																																														text4 = text3;
																																														obj35 = obj41;
																																														obj36 = obj42;
																																														obj33 = obj43;
																																														obj34 = obj44;
																																														flag31 = flag52;
																																														text = null;
																																														if (flag173)
																																														{
																																															break;
																																														}
																																														gameObject16.SetActive(value: false);
																																														num22++;
																																														if (num22 != 5)
																																														{
																																															continue;
																																														}
																																														goto IL_54bb;
																																													}
																																													break;
																																												}
																																											}
																																										}
																																										goto IL_5f4b;
																																										IL_5f32:
																																										ShowPopup();
																																										return;
																																										IL_51af:
																																										flag53 = false;
																																										text = (string)1;
																																										goto IL_454d;
																																										IL_54bb:
																																										flag53 = false;
																																										text = null;
																																										goto IL_454d;
																																										IL_454d:
																																										num15++;
																																										bool flag174 = num15 == 3;
																																										balootRoundBoardPopup = this;
																																										if (!flag174)
																																										{
																																											continue;
																																										}
																																										object obj256 = obj8;
																																										bool flag175 = obj8 == null;
																																										obj40 = obj39;
																																										text4 = text3;
																																										obj35 = obj41;
																																										obj36 = obj42;
																																										obj33 = obj43;
																																										obj34 = obj44;
																																										flag31 = flag52;
																																										flag8 = flag53;
																																										if (flag175)
																																										{
																																											break;
																																										}
																																										object obj257 = typeof(RegisteredWaitHandle) + 1520;
																																										bool flag176 = (object)game == null;
																																										obj40 = obj39;
																																										text4 = text3;
																																										obj35 = obj41;
																																										obj36 = obj42;
																																										obj33 = obj43;
																																										obj34 = obj44;
																																										flag31 = flag52;
																																										flag8 = flag53;
																																										if (flag176)
																																										{
																																											break;
																																										}
																																										TextMeshProUGUI resultLabel;
																																										object obj259;
																																										string text22;
																																										object obj260;
																																										TextMeshProUGUI resultLabel2;
																																										if (game.IsSpectator)
																																										{
																																											resultLabel = ResultLabel;
																																											object obj258 = obj257;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2466 @ X0_v198+E4]");
																																											obj259 = 0;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1209 @ X8_v125+18]");
																																											bool flag177 = (nint)0 != 1;
																																											text = null;
																																											text22 = null;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2466 @ X0_v198+E4]");
																																											obj260 = 0;
																																											object obj261 = obj258;
																																											resultLabel2 = ResultLabel;
																																											if (!flag177)
																																											{
																																												goto IL_5648;
																																											}
																																										}
																																										else
																																										{
																																											bool flag178 = (object)game == null;
																																											obj40 = obj39;
																																											text4 = text3;
																																											obj35 = obj41;
																																											obj36 = obj42;
																																											obj33 = obj43;
																																											obj34 = obj44;
																																											flag31 = flag52;
																																											flag8 = flag53;
																																											text = null;
																																											if (flag178)
																																											{
																																												break;
																																											}
																																											int myTeamIndex = game.MyTeamIndex;
																																											resultLabel = ResultLabel;
																																											object obj258 = obj257;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2466 @ X0_v198+E4]");
																																											obj259 = 0;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1209 @ X8_v125+18]");
																																											bool flag179 = (nint)0 == myTeamIndex;
																																											text = null;
																																											text22 = null;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2466 @ X0_v198+E4]");
																																											obj260 = 0;
																																											object obj261 = obj258;
																																											resultLabel2 = ResultLabel;
																																											if (flag179)
																																											{
																																												goto IL_5648;
																																											}
																																										}
																																										bool flag180 = obj260 == null;
																																										object obj262 = !flag180;
																																										if (obj262 == null)
																																										{
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																																										}
																																										bool flag181 = (object)resultLabel2 == null;
																																										obj40 = obj39;
																																										text4 = text3;
																																										obj35 = obj41;
																																										obj36 = obj42;
																																										obj33 = obj43;
																																										obj34 = obj44;
																																										flag31 = flag52;
																																										flag8 = flag53;
																																										text = text22;
																																										if (flag181)
																																										{
																																											break;
																																										}
																																										object obj263 = obj257;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2486 @ X8_v136+B8]");
																																										object obj264 = 0;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2487 @ X8_v137+38]");
																																										obj34 = 0;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2487 @ X8_v137+3C]");
																																										obj33 = 0;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2487 @ X8_v137+30]");
																																										obj36 = 0;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2487 @ X8_v137+34]");
																																										obj35 = 0;
																																										nint num24 = (nint)resultLabel2;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1213 @ X8_v138 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
																																										text = (string)0;
																																										resultLabel2.color = (Color)0;
																																										Image resultBackground = ResultBackground;
																																										bool flag182 = (object)ResultBackground == null;
																																										obj40 = obj39;
																																										text4 = text3;
																																										flag31 = flag52;
																																										flag8 = flag53;
																																										if (flag182)
																																										{
																																											break;
																																										}
																																										object obj265 = 224;
																																										goto IL_6289;
																																										IL_5648:
																																										bool flag183 = obj259 == null;
																																										object obj266 = !flag183;
																																										if (obj266 == null)
																																										{
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																																										}
																																										bool flag184 = (object)resultLabel == null;
																																										obj40 = obj39;
																																										text4 = text3;
																																										obj35 = obj41;
																																										obj36 = obj42;
																																										obj33 = obj43;
																																										obj34 = obj44;
																																										flag31 = flag52;
																																										flag8 = flag53;
																																										if (flag184)
																																										{
																																											break;
																																										}
																																										object obj267 = obj257;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2482 @ X8_v142+B8]");
																																										object obj268 = 0;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2483 @ X8_v143+18]");
																																										obj34 = 0;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2483 @ X8_v143+1C]");
																																										obj33 = 0;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2483 @ X8_v143+10]");
																																										obj36 = 0;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2483 @ X8_v143+14]");
																																										obj35 = 0;
																																										nint num25 = (nint)resultLabel;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1211 @ X8_v144 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
																																										text = (string)0;
																																										resultLabel.color = (Color)0;
																																										resultBackground = ResultBackground;
																																										bool flag185 = (object)ResultBackground == null;
																																										obj40 = obj39;
																																										text4 = text3;
																																										flag31 = flag52;
																																										flag8 = flag53;
																																										if (flag185)
																																										{
																																											break;
																																										}
																																										obj265 = 216;
																																										goto IL_6289;
																																										IL_6289:
																																										Image image = resultBackground;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BalootRoundBoardPopup)+v2494 @ X8_v126]");
																																										image.sprite = (Sprite)0;
																																										BalootRoundScore balootRoundScore2 = roundScore;
																																										bool flag186 = roundScore == null;
																																										obj40 = obj39;
																																										text4 = text3;
																																										flag31 = flag52;
																																										flag8 = false;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BalootRoundBoardPopup)+v2494 @ X8_v126]");
																																										text = (string)0;
																																										if (flag186)
																																										{
																																											break;
																																										}
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X0_v45+18]");
																																										bool flag187 = (nint)0 == 0;
																																										obj40 = obj39;
																																										text4 = text3;
																																										flag31 = flag52;
																																										flag8 = false;
																																										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BalootRoundBoardPopup)+v2494 @ X8_v126]");
																																										text = (string)0;
																																										if (!flag187)
																																										{
																																											bool flag188 = obj60 == null;
																																											obj40 = obj39;
																																											text4 = text3;
																																											flag31 = flag52;
																																											flag8 = false;
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BalootRoundBoardPopup)+v2494 @ X8_v126]");
																																											text = (string)0;
																																											if (flag188)
																																											{
																																												break;
																																											}
																																											GameObject gameObject17 = ((Component)obj60).gameObject;
																																											bool flag189 = (object)game == null;
																																											obj40 = obj39;
																																											text4 = text3;
																																											flag31 = flag52;
																																											flag8 = false;
																																											text = null;
																																											if (flag189)
																																											{
																																												break;
																																											}
																																											int num26;
																																											if (game.IsSpectator)
																																											{
																																												text = null;
																																												num26 = 1;
																																											}
																																											else
																																											{
																																												bool flag190 = (object)game == null;
																																												obj40 = obj39;
																																												text4 = text3;
																																												flag31 = flag52;
																																												flag8 = false;
																																												text = null;
																																												if (flag190)
																																												{
																																													break;
																																												}
																																												num26 = game.MyTeamIndex;
																																												text = null;
																																											}
																																											bool flag191 = (object)gameObject17 == null;
																																											obj40 = obj39;
																																											text4 = text3;
																																											flag31 = flag52;
																																											flag8 = false;
																																											if (flag191)
																																											{
																																												break;
																																											}
																																											object obj269 = balootRoundScore2.<LastMoveWinner>k__BackingField - num26;
																																											bool flag192 = obj269 == null;
																																											gameObject17.SetActive(flag192);
																																											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v948 @ X0_v45+18]");
																																											object obj270 = 0 & 0xFFFFFFFEL;
																																											bool flag193 = obj270 == null;
																																											obj40 = obj39;
																																											text4 = text3;
																																											flag31 = flag52;
																																											flag8 = false;
																																											text = (string)flag192;
																																											if (!flag193)
																																											{
																																												bool flag194 = obj65 == null;
																																												obj40 = obj39;
																																												text4 = text3;
																																												flag31 = flag52;
																																												flag8 = false;
																																												text = (string)flag192;
																																												if (flag194)
																																												{
																																													break;
																																												}
																																												GameObject gameObject18 = ((Component)obj65).gameObject;
																																												bool flag195 = (object)game == null;
																																												obj40 = obj39;
																																												text4 = text3;
																																												flag31 = flag52;
																																												flag8 = false;
																																												text = null;
																																												if (flag195)
																																												{
																																													break;
																																												}
																																												int num27;
																																												if (game.IsSpectator)
																																												{
																																													num27 = 1;
																																												}
																																												else
																																												{
																																													bool flag196 = (object)game == null;
																																													obj40 = obj39;
																																													text4 = text3;
																																													flag31 = flag52;
																																													flag8 = false;
																																													text = null;
																																													if (flag196)
																																													{
																																														break;
																																													}
																																													int myTeamIndex2 = game.MyTeamIndex;
																																													num27 = myTeamIndex2;
																																												}
																																												int opponentTeam = game.GetOpponentTeam(num27);
																																												bool flag197 = (object)gameObject18 == null;
																																												obj40 = obj39;
																																												text4 = text3;
																																												flag31 = flag52;
																																												flag8 = false;
																																												text = (string)num27;
																																												if (flag197)
																																												{
																																													break;
																																												}
																																												object obj271 = balootRoundScore2.<LastMoveWinner>k__BackingField - opponentTeam;
																																												bool flag198 = obj271 == null;
																																												gameObject18.SetActive(flag198);
																																												object obj272 = obj8;
																																												bool flag199 = obj8 == null;
																																												obj40 = obj39;
																																												text4 = text3;
																																												flag31 = flag52;
																																												flag8 = false;
																																												text = (string)flag198;
																																												if (flag199)
																																												{
																																													break;
																																												}
																																												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1216 @ X8_v131+2C]");
																																												object obj273 = (nint)0 & (nint)1;
																																												bool flag200 = obj273 == null;
																																												object obj274 = !flag200;
																																												text = (string)flag198;
																																												if (obj274 == null)
																																												{
																																													bool flag201 = (object)game == null;
																																													obj40 = obj39;
																																													text4 = text3;
																																													flag31 = flag52;
																																													flag8 = false;
																																													text = (string)flag198;
																																													if (flag201)
																																													{
																																														break;
																																													}
																																													bool isFastTrackGame = game.IsFastTrackGame;
																																													bool flag202 = !isFastTrackGame;
																																													text = null;
																																													if (flag202)
																																													{
																																														goto IL_5f32;
																																													}
																																												}
																																												bool flag203 = (object)game == null;
																																												obj40 = obj39;
																																												text4 = text3;
																																												flag31 = flag52;
																																												flag8 = false;
																																												if (flag203)
																																												{
																																													break;
																																												}
																																												if (game.IsReplay)
																																												{
																																													goto IL_5f32;
																																												}
																																												return;
																																											}
																																										}
																																										goto IL_5f4b;
																																									}
																																									goto IL_5f3d;
																																								}
																																							}
																																						}
																																					}
																																					goto IL_5f4b;
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
											}
										}
									}
								}
							}
						}
						goto IL_5f3d;
					}
				}
			}
		}
		goto IL_5f4b;
		IL_60ba:
		TextMeshProExtensions.SetUsername(Catcher, nickName, flag29, flag31);
		bool flag204 = (object)game == null;
		obj40 = 0;
		text4 = null;
		flag8 = flag29;
		text = nickName;
		if (!flag204)
		{
			int playerTeam = game.GetPlayerTeam(playerByIndex);
			object obj275 = obj8;
			bool flag205 = obj8 == null;
			obj40 = 0;
			text4 = null;
			flag8 = false;
			text = (string)(object)playerByIndex;
			if (!flag205)
			{
				object obj276 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v854 @ X9_v118+18]");
				TextMeshProUGUI catchResult;
				object text23;
				if ((nint)playerTeam == 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1878 @ X0_v366+E4]");
					bool flag206 = (nint)0 == 0;
					object obj277 = !flag206;
					if (obj277 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag207 = (object)CatchResult == null;
					obj40 = 0;
					text4 = null;
					flag8 = false;
					text = (string)(object)playerByIndex;
					if (flag207)
					{
						goto IL_5f3d;
					}
					object obj278 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1896 @ X8_v243+B8]");
					object obj279 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1897 @ X8_v244+8]");
					obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1897 @ X8_v244+C]");
					obj43 = 0;
					obj42 = obj279;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1897 @ X8_v244+4]");
					obj41 = 0;
					CatchResult.color = (Color)0;
					catchResult = CatchResult;
					text23 = "Complete" + 1736;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1878 @ X0_v366+E4]");
					bool flag208 = (nint)0 == 0;
					object obj280 = !flag208;
					if (obj280 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					bool flag209 = (object)CatchResult == null;
					obj40 = 0;
					text4 = null;
					flag8 = false;
					text = (string)(object)playerByIndex;
					if (flag209)
					{
						goto IL_5f3d;
					}
					object obj281 = obj22;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1910 @ X8_v238+B8]");
					object obj282 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1911 @ X8_v239+28]");
					obj44 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1911 @ X8_v239+2C]");
					obj43 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1911 @ X8_v239+20]");
					obj42 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1911 @ X8_v239+24]");
					obj41 = 0;
					CatchResult.color = (Color)0;
					catchResult = CatchResult;
					text23 = "WhiteSmoke" + 472;
				}
				TextMeshProExtensions.Localize(catchResult, (string)text23);
				object obj37 = typeof(SqlSingle[]) + 216;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				bool flag210 = obj38 == null;
				object obj283 = !flag210;
				obj39 = 0;
				text3 = null;
				flag52 = flag31;
				flag53 = false;
				text5 = (string)2;
				if (obj283 != null)
				{
					goto IL_1374;
				}
				obj40 = 0;
				text4 = null;
				obj35 = obj41;
				obj36 = obj42;
				obj33 = obj43;
				obj34 = obj44;
				flag8 = false;
				text = (string)2;
			}
		}
		goto IL_5f3d;
	}

	public override void ShowPopup()
	{
		//IL_0098: Expected O, but got I4
		//IL_00c6: Expected O, but got I4
		//IL_00e6: Expected O, but got I
		//IL_00e6: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		ResetAnimationComponent();
		base.ShowPopup();
		BalootRoundScore balootRoundScore = roundScore;
		if (roundScore != null && balootRoundScore.<IsKabboot>k__BackingField)
		{
			gameAndCatchData.SetActive(value: false);
			bool flag = MyTeamIsWinner();
			bool flag2 = !flag;
			object obj = !flag2;
			object obj2 = ~obj;
			if (obj2 == null)
			{
				object obj3 = 504;
			}
			else
			{
				object obj3 = 496;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BalootRoundBoardPopup)+v86 @ X8_v5]");
			((BalootRoundBoardPopup)flag).ShowAnimation((Animator)0, show: true);
		}
	}

	public override void Close()
	{
		base.Close();
		ShowOutroAnimation();
	}

	private void ShowOutroAnimation()
	{
		//IL_003b: Expected O, but got I4
		//IL_00a9: Expected O, but got I4
		//IL_00d7: Expected O, but got I4
		//IL_00f7: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		GameObject gameObject = kabootLoserAnimation.gameObject;
		bool activeSelf = gameObject.activeSelf;
		bool flag = !activeSelf;
		object obj = !flag;
		if (obj == null)
		{
			GameObject gameObject2 = kabootWinnerAnimation.gameObject;
			if (!gameObject2.activeSelf)
			{
				return;
			}
		}
		bool flag2 = MyTeamIsWinner();
		bool flag3 = !flag2;
		object obj2 = !flag3;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			object obj4 = 504;
		}
		else
		{
			object obj4 = 496;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BalootRoundBoardPopup)+v61 @ X8_v2]");
		((BalootRoundBoardPopup)flag2).ShowAnimation((Animator)0, show: false);
	}

	private void ShowAnimationPanel()
	{
		//IL_0039: Expected O, but got I4
		//IL_0067: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_0086: Expected O, but got I4
		//IL_0059: Expected O, but got I4
		gameAndCatchData.SetActive(value: false);
		bool flag = MyTeamIsWinner();
		bool flag2 = !flag;
		object obj = !flag2;
		object obj2 = ~obj;
		if (obj2 == null)
		{
			object obj3 = 504;
		}
		else
		{
			object obj3 = 496;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (BalootRoundBoardPopup)+v58 @ X8_v2]");
		((BalootRoundBoardPopup)flag).ShowAnimation((Animator)0, show: true);
	}

	private void ShowAnimation(Animator animator, bool show)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_005d: Expected O, but got I4
		GameObject gameObject = animator.gameObject;
		object obj = "setMimeType" + 2192;
		object obj2 = "getSecondRescanTask" + 2792;
		gameObject.SetActive(value: true);
		bool flag = !show;
		object obj3 = !flag;
		object obj4 = ~obj3;
		object obj5 = ((obj4 != null) ? obj2 : obj);
		animator.SetBool((string)obj5, value: true);
	}

	private void ResetAnimationComponent()
	{
		gameAndCatchData.SetActive(value: true);
		GameObject gameObject = kabootLoserAnimation.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = kabootWinnerAnimation.gameObject;
		gameObject2.SetActive(value: false);
	}

	private bool MyTeamIsWinner()
	{
		//IL_012f: Expected I4, but got O
		BalootRoundScore balootRoundScore = roundScore;
		if (roundScore != null && (object)game != null)
		{
			if (game.IsSpectator)
			{
				if (((CardGameRoundScore)balootRoundScore).<WinnerTeamIndex>k__BackingField == 1)
				{
					goto IL_0099;
				}
			}
			else
			{
				if ((object)game == null)
				{
					goto IL_0121;
				}
				int myTeamIndex = game.MyTeamIndex;
				if (((CardGameRoundScore)balootRoundScore).<WinnerTeamIndex>k__BackingField == myTeamIndex)
				{
					goto IL_0099;
				}
			}
			if ((object)game != null)
			{
				return game.IsSpectator;
			}
		}
		goto IL_0121;
		IL_0121:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0099:
		return true;
	}

	public BalootRoundBoardPopup()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00b4: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(RegisteredWaitHandle) + 1520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6748]");
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
