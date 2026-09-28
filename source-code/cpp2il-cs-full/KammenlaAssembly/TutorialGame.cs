using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.Baloot;
using KammelnaOffline.Baloot.Tutorial;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.UI;
using UnityEngine.Rendering;

public class TutorialGame : ScriptableObject
{
	private sealed class <>c__DisplayClass27_0
	{
		public int round;

		public int playerIndex;

		internal bool <GetAiOptions>b__0(GameAiCheatOption option)
		{
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			if (round == (nint)option)
			{
				object obj = (object)option >> 32;
				object obj2 = playerIndex - obj;
				return obj2 == null;
			}
			return false;
		}
	}

	private Games _gameType;

	private TutorialType _tutorialType;

	private RoutingCommand _routingCommand;

	private int _dealer;

	private CardData _floorCard;

	private BalootBidingButtonEnum _balootBidingButtons;

	private bool _isCheating;

	private int _catchMove;

	private GameAiCheatOption[] _gameAiCheatOption;

	private BalootCatchButtonEnum _balootCatchButtons;

	private AiBidding[] _aiBiddings;

	private List<CardData> _cardsAi2;

	private List<CardData> _cardsAi3;

	private List<CardData> _cardsAi4;

	private List<CardData> _firstPhase;

	private List<CardData> _secondPhase;

	private List<ListWrapper<CardData>> _cardsWantedToPlay;

	private List<CardData> _firstPhaseAi2;

	private List<CardData> _firstPhaseAi3;

	private List<CardData> _firstPhaseAi4;

	private List<CardData> _secondPhaseAi2;

	private List<CardData> _secondPhaseAi3;

	private List<CardData> _secondPhaseAi4;

	private List<CardData> _hand1;

	private List<CardData> _hand2;

	private List<CardData> _hand3;

	private List<CardData> _hand4;

	private List<CardData> _cheatingCases;

	private string[] _bodyTextTips;

	private TutorialError[] _tutorialErrors;

	private OnEndRoundScriptableMethod _scriptableMethod;

	public Games GameType => _gameType;

	public TutorialType TutorialType => _tutorialType;

	public RoutingCommand RoutingCommand => _routingCommand;

	public int Dealer => _dealer;

	public CardData FloorCard => _floorCard;

	public BalootBidingButtonEnum BalootBidingButtons => _balootBidingButtons;

	public bool IsCheating => _isCheating;

	public int CatchMove => _catchMove;

	public GameAiCheatOption[] GameAiCheatOption => _gameAiCheatOption;

	public BalootCatchButtonEnum BalootCatchButtons => _balootCatchButtons;

	public AiBidding[] Bid => _aiBiddings;

	public List<CardData> CardsAi2 => _cardsAi2;

	public List<CardData> CardsAi3 => _cardsAi3;

	public List<CardData> CardsAi4 => _cardsAi4;

	public List<CardData> FirstPhase => _firstPhase;

	public List<CardData> FirstPhaseAi2 => _firstPhaseAi2;

	public List<CardData> FirstPhaseAi3 => _firstPhaseAi3;

	public List<CardData> FirstPhaseAi4 => _firstPhaseAi4;

	public List<CardData> SecondPhase => _secondPhase;

	public List<CardData> SecondPhaseAi2 => _secondPhaseAi2;

	public List<CardData> SecondPhaseAi3 => _secondPhaseAi3;

	public List<CardData> SecondPhaseAi4 => _secondPhaseAi4;

	public List<CardData> Hand1 => _hand1;

	public List<CardData> Hand2 => _hand2;

	public List<CardData> Hand3 => _hand3;

	public List<CardData> Hand4 => _hand4;

	public List<ListWrapper<CardData>> CardsWantedToPlayList => _cardsWantedToPlay;

	public List<CardData> CheatingCases => _cheatingCases;

	public string[] BodyTextTips => _bodyTextTips;

	public TutorialError[] TutorialErrors => _tutorialErrors;

	public OnEndRoundScriptableMethod ScriptableMethod => _scriptableMethod;

	public AiCheatOption GetAiOptions(int playerIndex, int round)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00de: Expected I4, but got O
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		//IL_00ad: Expected I, but got O
		//IL_00ca: Expected I4, but got O
		object obj = typeof(TrackedDeviceRaycaster.<>c) + 240;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			IEnumerable<GameAiCheatOption> gameAiCheatOption = _gameAiCheatOption;
			if (_gameAiCheatOption != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X19_v3 (System.Collections.Generic.IEnumerable`1<GameAiCheatOption>)+18]");
				if ((nint)0 >= (nint)1)
				{
					object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1280;
					object obj4 = (nint)0 + (nint)856;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<GameAiCheatOption, bool> func = default(Func<GameAiCheatOption, bool>);
					func..ctor(obj2, (IntPtr)obj4);
					GameAiCheatOption gameAiCheatOption2 = Enumerable.FirstOrDefault(_gameAiCheatOption, func);
					return (AiCheatOption)func;
				}
				return AiCheatOption.None;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (AiCheatOption)ex;
	}

	public BalootBiddingOption GetBalootBiddingOption(BalootBiddingOption[] balootBiddingOptions, int playerIndex, int biddingState)
	{
		//IL_021c: Expected I4, but got O
		//IL_000f: Expected O, but got I4
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0065: Expected O, but got I4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_0250: Expected O, but got I4
		//IL_00ba: Expected O, but got I
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0172: Expected I4, but got O
		//IL_0143: Expected I4, but got O
		//IL_0079: Expected O, but got I4
		AiBidding[] aiBiddings = _aiBiddings;
		if (_aiBiddings != null)
		{
			object obj = aiBiddings.Length;
			if (balootBiddingOptions != null)
			{
				if (aiBiddings.Length >= 1)
				{
					object obj2 = _aiBiddings + 40;
					object obj3 = 0;
					TutorialGame tutorialGame = this;
					do
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X25_v4-8]");
						bool flag;
						if ((nint)playerIndex == 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X25_v4-4]");
							object obj4 = (nint)biddingState - (nint)0;
							flag = obj4 == null;
						}
						else
						{
							flag = false;
						}
						object obj5 = !flag;
						if (obj5 == null)
						{
							tutorialGame = (TutorialGame)obj2;
							bool flag2;
							if (balootBiddingOptions.Length == 0)
							{
								object obj6 = obj2 - 21;
								flag2 = obj6 == null;
							}
							else
							{
								flag2 = false;
							}
							if (flag2 || Enumerable.Contains((IEnumerable<System.Int32Enum>)(object)balootBiddingOptions, (System.Int32Enum)tutorialGame))
							{
								return (BalootBiddingOption)((object)tutorialGame >> 32);
							}
							obj = aiBiddings.Length;
						}
						obj2 += 16;
						obj3++;
					}
					while (obj3 < obj);
				}
			}
			else if (aiBiddings.Length >= 1)
			{
				object obj7 = _aiBiddings + 32;
				while (true)
				{
					obj7 += 16;
					object obj8 = obj7 >> 32;
					bool flag3;
					if (playerIndex == (nint)obj7)
					{
						object obj9 = biddingState - obj8;
						flag3 = obj9 == null;
					}
					else
					{
						flag3 = false;
					}
					if (flag3)
					{
						break;
					}
					obj--;
					if ((nint)obj != 1)
					{
						continue;
					}
					goto IL_0208;
				}
				goto IL_020e;
			}
			goto IL_0208;
		}
		goto IL_020e;
		IL_020e:
		NullReferenceException ex = new NullReferenceException();
		return (BalootBiddingOption)ex;
		IL_0208:
		return BalootBiddingOption.EmptyBid;
	}

	public string GetErrorMessage(int numberOfCards, Card card)
	{
		//IL_0044: Expected O, but got I4
		//IL_0060: Expected O, but got I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0093: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_01c4: Expected O, but got I4
		//IL_0263: Expected O, but got I
		//IL_027d: Expected O, but got I4
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_030c: Expected O, but got I4
		TutorialError[] tutorialErrors = _tutorialErrors;
		if (_tutorialErrors == null)
		{
			goto IL_029b;
		}
		bool flag = numberOfCards < tutorialErrors.Length;
		object obj = !flag;
		if (obj != null)
		{
			goto IL_02a9;
		}
		object obj2 = numberOfCards * 40;
		object obj3 = (object)_tutorialErrors + obj2;
		object obj4 = obj3 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v6+8]");
		object obj5 = (nint)0 & (nint)1;
		if (obj5 == null)
		{
			goto IL_01ae;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v6+10]");
		string result = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v6+1C]");
		object obj6 = (nint)0 >> 32;
		if ((nint)obj6 == 4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v6+1C]");
			if ((nint)0 != 13)
			{
				goto IL_01ae;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v6+1C]");
			if ((nint)0 != 13)
			{
				object obj7 = 152993792;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v6+18]");
				if ((nint)0 != 0)
				{
					object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj9 = default(object);
					obj9..ctor();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v6+1C]");
					_ = 0;
					bool flag2 = obj9.Equals(card);
					bool flag3 = !flag2;
					object obj10 = !flag3;
					if (obj10 != null)
					{
						goto IL_01ae;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A54]");
					object obj11 = (nint)0 & (nint)1;
					bool flag4 = obj11 == null;
					object obj12 = !flag4;
					if (obj12 == null)
					{
						_ = 1;
					}
					object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 304;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj14 = default(object);
					obj14..ctor();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v6+1C]");
					_ = 0;
					if (!obj14.Equals(card))
					{
						goto IL_01ae;
					}
				}
				goto IL_02b7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X9_v6+18]");
		if ((nint)0 != 0)
		{
			if (card == null)
			{
				goto IL_029b;
			}
			if ((nint)card.<Suit>k__BackingField == (nint)obj6)
			{
				goto IL_01ae;
			}
		}
		else
		{
			if (card == null)
			{
				goto IL_029b;
			}
			if ((nint)card.<Suit>k__BackingField != (nint)obj6)
			{
				goto IL_01ae;
			}
		}
		goto IL_02b7;
		IL_02a9:
		return (string)(object)new IndexOutOfRangeException();
		IL_02b7:
		return result;
		IL_029b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_02a9;
		IL_01ae:
		result = (string)obj4;
		goto IL_02b7;
	}

	public void OnEndRound()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0129: Expected O, but got I4
		//IL_017e: Expected O, but got I4
		//IL_00cf: Expected I, but got O
		//IL_00df: Expected O, but got I
		//IL_00ef: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A5B]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00f9;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		UnityEngine.Object scriptableMethod = _scriptableMethod;
		UnityEngine.Object scriptableMethod2 = _scriptableMethod;
		if (!flag)
		{
			goto IL_0091;
		}
		goto IL_014b;
		IL_014b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = scriptableMethod2 != null;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			return;
		}
		goto IL_00b8;
		IL_0091:
		if (scriptableMethod != null)
		{
			goto IL_00b8;
		}
		return;
		IL_00b8:
		OnEndRoundScriptableMethod scriptableMethod3 = _scriptableMethod;
		nint num = (nint)scriptableMethod3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7 (Il2CppClass<OnEndRoundScriptableMethod>)+178]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7 (Il2CppClass<OnEndRoundScriptableMethod>)+180]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v91 @ X2_v4 (should have been resolved before IL gen)");
		goto IL_00f9;
		IL_00f9:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj8 = !flag4;
		scriptableMethod = _scriptableMethod;
		scriptableMethod2 = _scriptableMethod;
		if (obj8 != null)
		{
			goto IL_0091;
		}
		goto IL_014b;
	}

	public TutorialGame()
	{
		//IL_0009: Expected O, but got I4
		//IL_0015: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_05e2: Expected O, but got I
		//IL_0604: Expected O, but got I4
		//IL_00a8: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I
		//IL_006b: Expected O, but got I
		//IL_06d4: Expected O, but got I4
		//IL_0634: Expected O, but got I
		//IL_0644: Expected O, but got I
		//IL_065a: Expected O, but got I
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		//IL_0682: Expected O, but got I4
		//IL_069a: Expected O, but got I
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0168: Expected O, but got I
		//IL_0178: Expected O, but got I
		//IL_018e: Expected O, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01b6: Expected O, but got I4
		//IL_01e3: Expected O, but got I
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0292: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected O, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bd: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected O, but got Unknown
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_0596: Unknown result type (might be due to invalid IL or missing references)
		//IL_059b: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = (nint)0 + (nint)3112;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8A5C]");
		object obj5;
		object obj3;
		if ((object)((nint)0 & (nint)1) != null)
		{
			_dealer = 3;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X20_v7+38]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X20_v7+38]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0098;
			}
		}
		else
		{
			_ = 1;
			_dealer = 3;
			obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X20_v7+38]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X20_v7+38]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0098;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X20_v3+38]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+10]");
		object obj9 = (nint)0 + (nint)309;
		object obj10 = obj9 & 1;
		bool flag3 = obj10 == null;
		object obj11 = !flag3;
		obj3 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+10]");
		object obj12 = 0;
		if (obj11 != null)
		{
			goto IL_0101;
		}
		goto IL_06a8;
		IL_012e:
		object obj13 = typeof(List<AdaptivePerformanceScaler>) + 424;
		object obj14 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X20_v7+38]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v13+10]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X8_v13+10]");
		if ((object)((object)((object)((nint)0 + (nint)309) & 1) != null) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v26+B8]");
		object obj17 = 0;
		object obj18 = this + 64;
		obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list = default(List<CardData>);
		list..ctor();
		object obj19 = this + 88;
		obj19 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list2 = default(List<CardData>);
		list2..ctor();
		object obj20 = this + 96;
		obj20 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list3 = default(List<CardData>);
		list3..ctor();
		object obj21 = this + 104;
		obj21 = list3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list4 = default(List<CardData>);
		list4..ctor();
		object obj22 = this + 112;
		obj22 = list4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list5 = default(List<CardData>);
		list5..ctor();
		object obj23 = this + 120;
		obj23 = list5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list6 = default(List<object>);
		list6..ctor();
		object obj24 = this + 128;
		obj24 = list6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list7 = default(List<CardData>);
		list7..ctor();
		object obj25 = this + 136;
		obj25 = list7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list8 = default(List<CardData>);
		list8..ctor();
		object obj26 = this + 144;
		obj26 = list8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list9 = default(List<CardData>);
		list9..ctor();
		object obj27 = this + 152;
		obj27 = list9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list10 = default(List<CardData>);
		list10..ctor();
		object obj28 = this + 160;
		obj28 = list10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list11 = default(List<CardData>);
		list11..ctor();
		object obj29 = this + 168;
		obj29 = list11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list12 = default(List<CardData>);
		list12..ctor();
		object obj30 = this + 176;
		obj30 = list12;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list13 = default(List<CardData>);
		list13..ctor();
		object obj31 = this + 184;
		obj31 = list13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list14 = default(List<CardData>);
		list14..ctor();
		object obj32 = this + 192;
		obj32 = list14;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list15 = default(List<CardData>);
		list15..ctor();
		object obj33 = this + 200;
		obj33 = list15;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list16 = default(List<CardData>);
		list16..ctor();
		object obj34 = this + 208;
		obj34 = list16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<CardData> list17 = default(List<CardData>);
		list17..ctor();
		object obj35 = this + 216;
		obj35 = list17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
		return;
		IL_06ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj5;
		goto IL_012e;
		IL_0101:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		obj5 = obj3;
		if (!flag4)
		{
			goto IL_012e;
		}
		goto IL_06ea;
		IL_0098:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v19+10]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v19+10]");
		bool flag5 = (object)((object)((nint)0 + (nint)309) & 1) == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v19+10]");
		obj12 = 0;
		obj5 = obj3;
		if (!flag5)
		{
			goto IL_0101;
		}
		goto IL_06a8;
		IL_06a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v1+E4]");
		bool flag6 = (nint)0 == 0;
		object obj36 = !flag6;
		obj3 = obj5;
		if (obj36 != null)
		{
			goto IL_012e;
		}
		goto IL_06ea;
	}
}
