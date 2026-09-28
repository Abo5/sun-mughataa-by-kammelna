using System;
using Cpp2ILInjected;
using DG.Tweening;
using Jackaroo;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine;
using UnityEngine.UI;

public class JackarooScoreGameEndWidget : GameEndWidget
{
	private DiscreteProgressIndicator _team1P1Score;

	private DiscreteProgressIndicator _team1P2Score;

	private DiscreteProgressIndicator _team2P1Score;

	private DiscreteProgressIndicator _team2P2Score;

	private AvatarInitializer _team1P1Avatar;

	private AvatarInitializer _team1P2Avatar;

	private AvatarInitializer _team2P1Avatar;

	private AvatarInitializer _team2P2Avatar;

	private Image _colorableTeamSection;

	private Color winningColor;

	private Color losingColor;

	private JackarooGame _jackarooGame;

	private JackarooCardGameVisualControls _gameVisual;

	private JackarooGame JackarooGame
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected O, but got Unknown
			//IL_0130: Expected O, but got I4
			//IL_00c4: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_01a6: Expected O, but got I
			//IL_01d0: Expected O, but got I4
			//IL_0187: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6777]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			UnityEngine.Object obj5;
			UnityEngine.Object obj7;
			object obj8;
			if (obj3 != null)
			{
				obj4 = this + 144;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (!flag)
				{
					goto IL_00a0;
				}
			}
			else
			{
				_ = 1;
				obj4 = this + 144;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (obj9 != null)
				{
					goto IL_00a0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj7 == null;
			bool flag4 = !flag3;
			obj4 = obj8;
			object obj10 = 0;
			UnityEngine.Object obj11 = null;
			if (flag4)
			{
				goto IL_00e8;
			}
			goto IL_019a;
			IL_00e8:
			return (JackarooGame)obj4;
			IL_019a:
			object obj12 = (nint)0 + (nint)128;
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v2+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			object obj15 = default(object);
			obj8 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (JackarooGame)obj8;
			IL_00a0:
			bool flag6 = obj5 == null;
			bool flag7 = !flag6;
			object obj16 = !flag7;
			obj10 = 0;
			obj11 = null;
			obj8 = obj4;
			if (obj16 == null)
			{
				goto IL_00e8;
			}
			goto IL_019a;
		}
	}

	private JackarooCardGameVisualControls GameVisual
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected O, but got Unknown
			//IL_0130: Expected O, but got I4
			//IL_00c4: Expected O, but got I4
			//IL_00cd: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_01a6: Expected O, but got I
			//IL_01d0: Expected O, but got I4
			//IL_0187: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6778]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			UnityEngine.Object obj5;
			UnityEngine.Object obj7;
			object obj8;
			if (obj3 != null)
			{
				obj4 = this + 152;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (!flag)
				{
					goto IL_00a0;
				}
			}
			else
			{
				_ = 1;
				obj4 = this + 152;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (obj9 != null)
				{
					goto IL_00a0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj7 == null;
			bool flag4 = !flag3;
			obj4 = obj8;
			object obj10 = 0;
			UnityEngine.Object obj11 = null;
			if (flag4)
			{
				goto IL_00e8;
			}
			goto IL_019a;
			IL_00e8:
			return (JackarooCardGameVisualControls)obj4;
			IL_019a:
			object obj12 = (nint)0 + (nint)120;
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v2+E4]");
			bool flag5 = (nint)0 == 0;
			object obj14 = !flag5;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			object obj15 = default(object);
			obj8 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return (JackarooCardGameVisualControls)obj8;
			IL_00a0:
			bool flag6 = obj5 == null;
			bool flag7 = !flag6;
			object obj16 = !flag7;
			obj10 = 0;
			obj11 = null;
			obj8 = obj4;
			if (obj16 == null)
			{
				goto IL_00e8;
			}
			goto IL_019a;
		}
	}

	private void PopulateScore(JackarooEndScores jackarooEndScores)
	{
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_028c: Expected O, but got I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004d: Expected O, but got I4
		//IL_02bc: Expected O, but got I4
		//IL_0076: Expected O, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0122: Expected O, but got I4
		//IL_014b: Expected O, but got I
		//IL_01f7: Expected O, but got I4
		//IL_025a: Expected O, but got I4
		InitProgressIndicators(jackarooEndScores);
		object obj = this + 32;
		KGame kGame = (KGame)obj;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v35+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = kGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		DiscreteProgressIndicator team2P2Score;
		object obj12;
		if (!kGame.IsSpectator || ((CardGameEndScores)jackarooEndScores).<WinnerTeamIndex>k__BackingField != 1)
		{
			CardGame cardGame = (CardGame)obj;
			bool flag3 = obj == null;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v21+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
				obj = cardGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			int myTeamIndex = cardGame.MyTeamIndex;
			if (myTeamIndex != 1)
			{
				_team1P1Score.CurrentProgress = jackarooEndScores.<Team2Player1MarbleCount>k__BackingField;
				_team1P2Score.CurrentProgress = jackarooEndScores.<Team2Player2MarbleCount>k__BackingField;
				_team2P1Score.CurrentProgress = jackarooEndScores.<Team1Player1MarbleCount>k__BackingField;
				team2P2Score = _team2P2Score;
				obj12 = 124;
				goto IL_02ca;
			}
		}
		_team1P1Score.CurrentProgress = jackarooEndScores.<Team1Player1MarbleCount>k__BackingField;
		_team1P2Score.CurrentProgress = jackarooEndScores.<Team1Player2MarbleCount>k__BackingField;
		_team2P1Score.CurrentProgress = jackarooEndScores.<Team2Player1MarbleCount>k__BackingField;
		team2P2Score = _team2P2Score;
		obj12 = 132;
		goto IL_02ca;
		IL_02ca:
		DiscreteProgressIndicator discreteProgressIndicator = team2P2Score;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [jackarooEndScores @ X1 (JackarooEndScores)+v249 @ X8_v5]");
		discreteProgressIndicator.CurrentProgress = 0;
	}

	public override void PrepareAnimation(CardGameEndScores rankReport)
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<JackarooScoreGameEndWidget>)+188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<JackarooScoreGameEndWidget>)+190]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public override void Populate(CardGameEndScores rankReport)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_0086: Expected O, but got I
		PopulateAvatars(rankReport);
		if (rankReport != null)
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 200;
			object obj2 = obj;
			nint num = (nint)rankReport;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v7 (Il2CppClass<CardGameEndScores>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X1_v8+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v7 (Il2CppClass<CardGameEndScores>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X1_v8+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v10-8]");
				if (0 == (nint)obj2)
				{
					goto IL_00ad;
				}
			}
			InvalidCastException ex = new InvalidCastException();
			throw new NullReferenceException();
		}
		goto IL_00ad;
		IL_00ad:
		PopulateScore((JackarooEndScores)rankReport);
		SetResultColors(rankReport);
		GameObject gameObject = base.gameObject;
		gameObject.SetActive(value: true);
	}

	private void SetResultColors(CardGameEndScores rankReport)
	{
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_029f: Expected O, but got I4
		//IL_0181: Expected O, but got I4
		//IL_018a: Expected O, but got I4
		//IL_0193: Expected O, but got I4
		//IL_019c: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_01b1: Expected O, but got I
		//IL_01c1: Expected O, but got I
		//IL_01d1: Expected O, but got I
		//IL_01e1: Expected O, but got I
		//IL_01e9: Expected I, but got O
		//IL_01f9: Expected O, but got I
		//IL_0209: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_0239: Expected O, but got I4
		//IL_0242: Expected O, but got I4
		//IL_024b: Expected O, but got I4
		//IL_0254: Expected O, but got I4
		//IL_025d: Expected O, but got I4
		//IL_02cf: Expected O, but got I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I4
		//IL_0127: Expected O, but got I
		object obj = this + 32;
		CardGame cardGame = (CardGame)obj;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X0_v29+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj6 = (nint)0 + (nint)24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			obj = cardGame;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		int myTeamIndex = cardGame.MyTeamIndex;
		if (rankReport.<WinnerTeamIndex>k__BackingField != myTeamIndex)
		{
			KGame kGame = (KGame)obj;
			bool flag3 = obj == null;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				object obj8 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v15+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj11 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
				obj = kGame;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			if (!kGame.IsSpectator)
			{
				goto IL_0213;
			}
		}
		Image colorableTeamSection = _colorableTeamSection;
		object obj12 = 112;
		object obj13 = 116;
		object obj14 = 120;
		object obj15 = 124;
		goto IL_01a1;
		IL_01a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooScoreGameEndWidget)+v214 @ X8_v5]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooScoreGameEndWidget)+v157 @ X9_v2]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooScoreGameEndWidget)+v155 @ X10_v2]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooScoreGameEndWidget)+v153 @ X11_v2]");
		object obj19 = 0;
		nint num = (nint)colorableTeamSection;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v6 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v6 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v143 @ X2_v1 (should have been resolved before IL gen)");
		goto IL_0213;
		IL_0213:
		colorableTeamSection = _colorableTeamSection;
		bool flag5 = (object)_colorableTeamSection == null;
		object obj22 = !flag5;
		obj12 = 128;
		obj13 = 132;
		obj14 = 136;
		obj15 = 140;
		if (obj22 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_01a1;
	}

	public override Sequence AnimatedPopulate(CardGameEndScores rankReport)
	{
		return null;
	}

	public override bool ShouldShow(CardGameEndScores rankReport)
	{
		return true;
	}

	private void PopulateAvatars(CardGameEndScores rankReport)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_008f: Expected I4, but got O
		//IL_00bf: Expected I4, but got O
		//IL_0114: Expected I4, but got O
		//IL_0169: Expected I4, but got O
		JackarooGame jackarooGame = JackarooGame;
		object obj;
		if (jackarooGame.IsSpectator)
		{
			obj = rankReport + 52;
		}
		else
		{
			JackarooGame jackarooGame2 = JackarooGame;
			CardGamePlayer myPlayer = jackarooGame2.MyPlayer;
			obj = myPlayer + 16;
		}
		JackarooGame jackarooGame3 = JackarooGame;
		KPlayer playerByIndex = jackarooGame3.GetPlayerByIndex((int)obj);
		_team1P1Avatar.Initialize(playerByIndex);
		int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex((int)obj, 2, 1, 5);
		JackarooGame jackarooGame4 = JackarooGame;
		KPlayer playerByIndex2 = jackarooGame4.GetPlayerByIndex(rotatedNextIndex);
		_team1P2Avatar.Initialize(playerByIndex2);
		int rotatedNextIndex2 = IntegerExtensions.GetRotatedNextIndex((int)obj, 1, 1, 5);
		JackarooGame jackarooGame5 = JackarooGame;
		KPlayer playerByIndex3 = jackarooGame5.GetPlayerByIndex(rotatedNextIndex2);
		_team2P1Avatar.Initialize(playerByIndex3);
		int rotatedNextIndex3 = IntegerExtensions.GetRotatedNextIndex((int)obj, 3, 1, 5);
		JackarooGame jackarooGame6 = JackarooGame;
		KPlayer playerByIndex4 = jackarooGame6.GetPlayerByIndex(rotatedNextIndex3);
		_team2P2Avatar.Initialize(playerByIndex4);
	}

	private void InitProgressIndicators(CardGameEndScores rankReport)
	{
		//IL_0036: Expected O, but got I4
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0113: Expected I4, but got O
		//IL_0153: Expected I4, but got O
		//IL_01bd: Expected I4, but got O
		//IL_0227: Expected I4, but got O
		JackarooGame jackarooGame = JackarooGame;
		bool isSpectator = jackarooGame.IsSpectator;
		bool flag = !isSpectator;
		object obj = !flag;
		if (obj == null)
		{
			JackarooGame jackarooGame2 = JackarooGame;
			CardGamePlayer myPlayer = jackarooGame2.MyPlayer;
			if (myPlayer == null)
			{
				return;
			}
		}
		JackarooGame jackarooGame3 = JackarooGame;
		object obj2;
		if (jackarooGame3.IsSpectator)
		{
			obj2 = rankReport + 52;
		}
		else
		{
			JackarooGame jackarooGame4 = JackarooGame;
			CardGamePlayer myPlayer2 = jackarooGame4.MyPlayer;
			obj2 = myPlayer2 + 16;
		}
		JackarooCardGameVisualControls gameVisual = GameVisual;
		Sprite playerMarbleSprite = gameVisual.<Board>k__BackingField.GetPlayerMarbleSprite((int)obj2);
		_team1P1Score.SetSprite(playerMarbleSprite);
		_team1P1Score.ManualInit();
		int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex((int)obj2, 2, 1, 5);
		JackarooCardGameVisualControls gameVisual2 = GameVisual;
		Sprite playerMarbleSprite2 = gameVisual2.<Board>k__BackingField.GetPlayerMarbleSprite(rotatedNextIndex);
		_team1P2Score.SetSprite(playerMarbleSprite2);
		_team1P2Score.ManualInit();
		int rotatedNextIndex2 = IntegerExtensions.GetRotatedNextIndex((int)obj2, 1, 1, 5);
		JackarooCardGameVisualControls gameVisual3 = GameVisual;
		Sprite playerMarbleSprite3 = gameVisual3.<Board>k__BackingField.GetPlayerMarbleSprite(rotatedNextIndex2);
		_team2P1Score.SetSprite(playerMarbleSprite3);
		_team2P1Score.ManualInit();
		int rotatedNextIndex3 = IntegerExtensions.GetRotatedNextIndex((int)obj2, 3, 1, 5);
		JackarooCardGameVisualControls gameVisual4 = GameVisual;
		Sprite playerMarbleSprite4 = gameVisual4.<Board>k__BackingField.GetPlayerMarbleSprite(rotatedNextIndex3);
		_team2P2Score.SetSprite(playerMarbleSprite4);
		_team2P2Score.ManualInit();
	}

	public JackarooScoreGameEndWidget()
	{
		//IL_0012: Expected O, but got I
		//IL_0024: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252CD0]");
		winningColor = (Color)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252CE0]");
		losingColor = (Color)0;
		((MonoBehaviour)this)..ctor();
	}
}
