using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HuaweiMobileServices.Location.Location;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class StatisticStrip : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<PlayerStatisticUI> <>9__25_0;

		public static Action<TextMeshProUGUI> <>9__25_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1184;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <ResetStatStrip>b__25_0(PlayerStatisticUI p)
		{
			//IL_0010: Expected O, but got I
			p.playerScore.color = (Color)0;
			p.playerScore.enabled = false;
			p.playerAvatar.Clear();
		}

		internal void <ResetStatStrip>b__25_1(TextMeshProUGUI ts)
		{
			ts.enabled = false;
		}
	}

	private sealed class <>c__DisplayClass22_0
	{
		public double stat;

		internal bool <SetHighestStatColor>b__0(double s)
		{
			//IL_001a: Invalid comparison between F8 and I4
			double num = s - stat;
			return num == 0.0;
		}

		internal unsafe bool <SetHighestStatColor>b__1(PlayerStatisticUI p)
		{
			//IL_0094: Expected I4, but got O
			//IL_0067: Expected Ref, but got F8
			if ((object)p != null && (object)p.playerScore != null)
			{
				string text = p.playerScore.text;
				double num = (double)this + 16.0;
				string text2 = ((double*)num)->ToString();
				return text == text2;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public TextMeshProUGUI nameLabel;

	public PlayerStatisticUI[] players;

	public TextMeshProUGUI[] teamsScores;

	public Image arrowIcon;

	public Button openDetailsButton;

	public RectTransform details;

	public TextMeshProUGUI info;

	public PopupUI infoPopup;

	private CardGame _game;

	private CardGameEndScores _endGame;

	private Statistic _statistic;

	private int MyTeamIndex
	{
		get
		{
			//IL_0092: Expected I4, but got O
			if ((object)_game != null)
			{
				if (_game.IsSpectator)
				{
					return 1;
				}
				if ((object)_game != null)
				{
					return _game.MyTeamIndex;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private int MyOpponentIndex
	{
		get
		{
			//IL_00be: Expected I4, but got O
			//IL_0048: Expected O, but got I4
			if ((object)_game != null)
			{
				bool isSpectator = _game.IsSpectator;
				bool flag = !isSpectator;
				object obj = !flag;
				if (obj == null)
				{
					if ((object)_game == null)
					{
						goto IL_00b0;
					}
					int myTeamIndex = _game.MyTeamIndex;
					if (myTeamIndex != 1)
					{
						return 1;
					}
				}
				return 2;
			}
			goto IL_00b0;
			IL_00b0:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public void Awake()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0056: Expected O, but got I
		//IL_006e: Expected I, but got O
		GameObject gameObject = details.gameObject;
		gameObject.SetActive(value: false);
		Button button = openDetailsButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)3880;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
	}

	public void SetUp(CardGame game, CardGameEndScores endGame, Statistic statistic, string statisticInfo, StatType statType)
	{
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0022: Expected O, but got I
		//IL_004e: Expected O, but got I
		object obj = this + 96;
		CardGame cardGame = default(CardGame);
		obj = cardGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 104;
		obj2 = endGame;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = statistic.PlayersStatistic;
		_ = statistic.Index;
		object obj3 = obj2 + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+48]");
		object obj5 = 0;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v130 @ X8_v7+188] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X23_v3-48]");
		string text = default(string);
		TextMeshProExtensions.Localize((TextMeshProUGUI)0, text);
		nameLabel.enabled = true;
		SetUpTeamsScore();
		List<double> playersStatistic = statistic.PlayersStatistic;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v8 (System.Collections.Generic.List`1<System.Double>)+18]");
		if ((nint)0 >= (nint)1)
		{
			SetUpPlayers();
			SetHighestStatColor(statType);
		}
		TextMeshProExtensions.Localize(info, statisticInfo);
		info.enabled = true;
	}

	private void SetUpInfo(string statisticInfo)
	{
		TextMeshProExtensions.Localize(info, statisticInfo);
		info.enabled = true;
	}

	private unsafe void SetUpName()
	{
		//IL_0022: Expected O, but got Ref
		CardGameEndScores endGame = _endGame;
		Statistic statistic = default(Statistic);
		string statisticName = endGame.<CGStatistics>k__BackingField.GetStatisticName((Statistic)(&statistic));
		TextMeshProExtensions.Localize(nameLabel, statisticName);
		nameLabel.enabled = true;
	}

	private void SetUpTeamsScore()
	{
		//IL_0085: Expected O, but got I4
		int teamIndex;
		if (_game.IsSpectator)
		{
			teamIndex = 0;
		}
		else
		{
			int myTeamIndex = _game.MyTeamIndex;
			teamIndex = myTeamIndex - 1;
		}
		SetUpTeamScore(0, teamIndex);
		bool isSpectator = _game.IsSpectator;
		bool flag = !isSpectator;
		object obj = !flag;
		if (obj == null)
		{
			int myTeamIndex2 = _game.MyTeamIndex;
			if (myTeamIndex2 != 1)
			{
				SetUpTeamScore(1, 0);
				return;
			}
		}
		SetUpTeamScore(1, 1);
	}

	private void SetUpTeamScore(int i, int teamIndex)
	{
		//IL_0016: Expected O, but got I
		//IL_00a6: Expected O, but got I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_00e9: Expected O, but got I
		//IL_017a: Expected O, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01d2: Expected O, but got I
		int num = Enumerable.Count((IEnumerable<object>)teamsScores);
		if (i >= num)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (StatisticStrip)+78]");
		List<double> list = (List<double>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (StatisticStrip)+78]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5 (System.Collections.Generic.List`1<System.Double>)+18]");
			if ((nint)teamIndex >= (nint)0)
			{
				return;
			}
			TextMeshProUGUI[] array = teamsScores;
			if (teamsScores != null)
			{
				bool flag = i < array.Length;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_01e6;
				}
				object obj2 = teamsScores + i;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v8+20]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (StatisticStrip)+78]");
				double num2 = ((List<double>)0).get_Item(teamIndex);
				double num3 = default(double);
				string text = num3.ToString();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v8+20]");
				if ((nint)0 != 0)
				{
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v221 @ X8_v11+558] (should have been resolved before IL gen)");
					TextMeshProUGUI[] array2 = teamsScores;
					if (teamsScores != null)
					{
						bool flag2 = i < array2.Length;
						object obj5 = !flag2;
						if (obj5 != null)
						{
							goto IL_01e6;
						}
						object obj6 = teamsScores + i;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v13+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v13+20]");
							((Behaviour)0).enabled = true;
							return;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01e6;
		IL_01e6:
		throw new IndexOutOfRangeException();
	}

	private void SetUpPlayers()
	{
		//IL_008e: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I
		//IL_0129: Expected O, but got I4
		KGame game = _game;
		int num = 0;
		while (true)
		{
			List<KPlayer> list = game.Players;
			if (num < list._size)
			{
				List<KPlayer> list2 = _game.Players;
				object player = ((List<object>)(object)list2).get_Item(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v10 (System.Object)+10]");
				int index = (int)(-1);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (StatisticStrip)+80]");
				double score = ((List<double>)0).get_Item(index);
				PlayerStatisticUI[] array = players;
				bool flag = num < array.Length;
				object obj = !flag;
				if (obj != null)
				{
					break;
				}
				object obj2 = array + num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v9+20]");
				((PlayerStatisticUI)0).SetUp((KPlayer)player, score);
				game = _game;
				num++;
				bool flag2 = (object)_game == null;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					throw new NullReferenceException();
				}
				continue;
			}
			return;
		}
		throw new IndexOutOfRangeException();
	}

	private void SetHighestStatColor(StatType statType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_024f: Expected O, but got I8
		//IL_0269: Expected O, but got I4
		//IL_0075: Expected O, but got I
		//IL_0082: Expected O, but got I4
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I
		//IL_00b3: Expected O, but got I
		//IL_00d3: Expected I, but got O
		//IL_002a: Expected O, but got I
		//IL_0048: Expected O, but got I4
		//IL_0051: Expected O, but got I4
		//IL_00ed: Expected O, but got I
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0138: Expected O, but got I
		//IL_0149: Expected I, but got O
		//IL_018f: Expected O, but got I
		//IL_01ae: Expected O, but got I4
		//IL_01e5: Expected O, but got I4
		//IL_01d7: Expected O, but got I4
		//IL_0201: Expected O, but got I4
		//IL_01f3: Expected O, but got I4
		//IL_021d: Expected O, but got I4
		//IL_02cf: Expected O, but got I
		//IL_02df: Expected O, but got I
		//IL_020f: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = (long)statType & 0xFFFFFFFDL;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (StatisticStrip)+80]");
			double num = Enumerable.Max((IEnumerable<double>)0);
			bool flag2 = obj2 == null;
			object obj5 = !flag2;
			object obj6 = 0;
			if (obj5 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (StatisticStrip)+80]");
			double num = Enumerable.Min((IEnumerable<double>)0);
			object obj6 = 0;
		}
		object obj7 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 952;
		object obj8 = (nint)0 + (nint)1120;
		object obj9 = (nint)0 + (nint)3528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<double, bool> func = default(Func<double, bool>);
		func..ctor(obj2, (IntPtr)obj8);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (StatisticStrip)+80]");
		int num2 = Enumerable.Count((IEnumerable<double>)0, func);
		if (num2 > 1)
		{
			return;
		}
		object obj10 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)1128;
		Func<object, bool> func2 = default(Func<object, bool>);
		func2..ctor(obj2, (IntPtr)obj11);
		object obj12 = Enumerable.First(players, func2);
		if (obj12 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X0_v15 (System.Object)+28]");
			object obj13 = 0;
			bool flag3 = statType < StatType.NegativeHighest;
			object obj14 = !flag3;
			object obj15 = ~obj14;
			object obj16 = ~obj15;
			if (obj16 == null)
			{
				object obj17 = 0;
			}
			else
			{
				object obj17 = 1061734601;
			}
			object obj18 = ~obj14;
			object obj19 = ~obj18;
			if (obj19 == null)
			{
				object obj20 = 1057787021;
			}
			else
			{
				object obj20 = 1033937057;
			}
			object obj21 = ~obj14;
			object obj22 = ~obj21;
			if (obj22 == null)
			{
				object obj23 = 1042325665;
			}
			else
			{
				object obj23 = 0;
			}
			object obj24 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v21+2A8]");
			object obj25 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v21+2B0]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v186 @ X2_v7 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	public void OpenDetails()
	{
		//IL_008f: Expected O, but got I4
		GameObject gameObject = details.gameObject;
		if (gameObject.activeSelf)
		{
			CloseDetails();
			return;
		}
		GameObject gameObject2 = details.gameObject;
		gameObject2.SetActive(value: true);
		RectTransform rectTransform = arrowIcon.rectTransform;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DORotate(rectTransform, (Vector3)0, 180f);
	}

	public void CloseDetails()
	{
		//IL_004e: Expected O, but got I4
		GameObject gameObject = details.gameObject;
		gameObject.SetActive(value: false);
		RectTransform rectTransform = arrowIcon.rectTransform;
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore = ShortcutExtensions.DORotate(rectTransform, (Vector3)0, 0f);
	}

	public void ResetStatStrip()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00b5: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_018a: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_0335: Expected O, but got I
		//IL_0345: Expected O, but got I
		//IL_0367: Expected O, but got I4
		//IL_02ff: Expected O, but got I4
		//IL_0294: Expected O, but got I
		//IL_02a4: Expected O, but got I
		//IL_0214: Expected O, but got I4
		//IL_0398: Expected O, but got I4
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_0440: Expected O, but got I
		//IL_0451: Expected I, but got O
		//IL_046f: Expected O, but got I
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_04c8: Expected O, but got I
		//IL_04d9: Expected I, but got O
		//IL_04f7: Expected O, but got I
		//IL_0244: Expected O, but got I
		//IL_03c8: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 1184;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E67E9]");
		object obj3 = (nint)0 & (nint)1;
		PlayerStatisticUI[] array;
		PlayerStatisticUI[] array2;
		object obj4;
		if (obj3 != null)
		{
			array = players;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v24+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			array2 = players;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			array = players;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			array2 = players;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)2248;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v24+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v20+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v20+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		IEnumerable<object> enumerable = array2;
		object obj10 = obj7;
		IEnumerable<object> enumeration = array2;
		if (obj9 == null)
		{
			goto IL_01f2;
		}
		goto IL_0249;
		IL_02ca:
		Action<object> action2;
		ArraysExtensions.ForEach(teamsScores, action2);
		Behaviour behaviour = info;
		bool flag4 = (object)info == null;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_03eb;
		IL_03eb:
		behaviour.enabled = false;
		nameLabel.enabled = false;
		return;
		IL_01f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v24+E4]");
		bool flag5 = (nint)0 == 0;
		object obj12 = !flag5;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v26+B8]");
			obj8 = 0;
		}
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)1104;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj15);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v25+B8]");
		object obj17 = (nint)0 + (nint)8;
		obj17 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action = action3;
		obj10 = obj7;
		enumeration = enumerable;
		goto IL_0249;
		IL_0099:
		obj10 = (nint)0 + (nint)2248;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v24+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v20+8]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v20+8]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		enumeration = array;
		if (obj18 == null)
		{
			obj7 = obj10;
			enumerable = array;
			goto IL_01f2;
		}
		goto IL_0249;
		IL_0249:
		ArraysExtensions.ForEach(enumeration, action);
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v8+E4]");
		object obj20;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v8+B8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v7+10]");
			action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v7+10]");
			if ((nint)0 != 0)
			{
				goto IL_02ca;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj19 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v8+B8]");
			obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v7+10]");
			action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v7+10]");
			bool flag7 = (nint)0 == 0;
			object obj21 = !flag7;
			if (obj21 != null)
			{
				goto IL_02ca;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v8+E4]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj23 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v13+B8]");
			obj20 = 0;
		}
		object obj24 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3680;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)1112;
		Action<object> action4 = default(Action<object>);
		action4..ctor(obj20, (IntPtr)obj25);
		object obj26 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v12+B8]");
		object obj27 = (nint)0 + (nint)16;
		obj27 = action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ArraysExtensions.ForEach(teamsScores, action4);
		behaviour = info;
		goto IL_03eb;
	}
}
