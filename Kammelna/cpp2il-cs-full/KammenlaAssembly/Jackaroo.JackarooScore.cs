using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.UI;

namespace Jackaroo;

public class JackarooScore : MonoBehaviour
{
	private DiscreteProgressIndicator _team1P1Score;

	private DiscreteProgressIndicator _team1P2Score;

	private DiscreteProgressIndicator _team2P1Score;

	private DiscreteProgressIndicator _team2P2Score;

	private Image _team1P1MarbleImage;

	private Image _team1P2MarbleImage;

	private Image _team2P1MarbleImage;

	private Image _team2P2MarbleImage;

	private AvatarInitializer _team1P1Avatar;

	private AvatarInitializer _team1P2Avatar;

	private AvatarInitializer _team2P1Avatar;

	private AvatarInitializer _team2P2Avatar;

	private JackarooGame _game;

	private JackarooCardGameVisualControls _gameVisual;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0108: Expected O, but got I
		//IL_0114: Expected O, but got I
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0134: Expected O, but got I
		//IL_015e: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0098: Expected I, but got O
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00e7: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)120;
		object obj3 = (nint)0 + (nint)128;
		object obj4 = typeof(SqlSingle[]) + 2376;
		object obj5 = (nint)0 + (nint)904;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj8 = this + 136;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj10 = this + 128;
		object obj11 = default(object);
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj5);
		object obj12 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj13 = (nint)0 + (nint)912;
		((KGame)obj10).OnGameInitialized += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)obj13);
		_game.OnPlayerSwitchSeat += playerSwitchSeatDelegate;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_009e: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj4 = (nint)0 + (nint)912;
		_game.OnGameInitialized -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)obj4);
		_game.OnPlayerSwitchSeat -= playerSwitchSeatDelegate;
	}

	private void OnGameInitialized()
	{
		Init();
	}

	private void OnPlayerSwitchSeat(int userid, string error)
	{
		Init();
	}

	private void Init()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0060: Expected I, but got O
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00c4: Expected I, but got O
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0128: Expected I, but got O
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_018c: Expected I, but got O
		GameObject go = base.gameObject;
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)920;
		object varName = "tournament_participate_warning_body_with_tickets_warning_daily" + 744;
		Room room = _game.Room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		VariableBinderExtensions.Bind(go, room, (string)varName, action);
		GameObject go2 = base.gameObject;
		object varName2 = "tournament_participate_warning_body_with_tickets_warning_daily" + 752;
		Room room2 = _game.Room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj2);
		VariableBinderExtensions.Bind(go2, room2, (string)varName2, action2);
		GameObject go3 = base.gameObject;
		object varName3 = "tournament_participate_warning_body_with_tickets_warning_daily" + 768;
		Room room3 = _game.Room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj2);
		VariableBinderExtensions.Bind(go3, room3, (string)varName3, action3);
		GameObject go4 = base.gameObject;
		object varName4 = "tournament_participate_warning_body_with_tickets_warning_daily" + 776;
		Room room4 = _game.Room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj2);
		VariableBinderExtensions.Bind(go4, room4, (string)varName4, action4);
		GetSprites();
		PopulateAvatars();
	}

	private void PopulateAvatars()
	{
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0158: Expected O, but got I4
		//IL_0169: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0088: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		//IL_027d: Expected O, but got I4
		//IL_0361: Expected O, but got I4
		//IL_04a4: Expected O, but got I4
		object obj;
		UnityEngine.Object team1P1Avatar;
		int num;
		object obj3;
		UnityEngine.Object team1P1Avatar2;
		int num2;
		if (_game.IsSpectator)
		{
			obj = typeof(MemberAchievementClanFeedData) + 2976;
			team1P1Avatar = _team1P1Avatar;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v9+E4]");
			bool flag = (nint)0 == 0;
			num = 1;
			obj3 = obj;
			object obj4 = 0;
			team1P1Avatar2 = _team1P1Avatar;
			num2 = 1;
			if (!flag)
			{
				goto IL_00a9;
			}
		}
		else
		{
			CardGamePlayer myPlayer = _game.MyPlayer;
			num = ((KPlayer)myPlayer).<Index>k__BackingField;
			obj = typeof(MemberAchievementClanFeedData) + 2976;
			team1P1Avatar = _team1P1Avatar;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v9+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			obj3 = obj;
			object obj4 = 0;
			team1P1Avatar2 = _team1P1Avatar;
			num2 = ((KPlayer)myPlayer).<Index>k__BackingField;
			if (obj5 != null)
			{
				goto IL_00a9;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = team1P1Avatar2;
		bool flag4 = !flag3;
		obj = obj3;
		num = num2;
		if (!flag4)
		{
			goto IL_01d3;
		}
		goto IL_020f;
		IL_02c7:
		int rotatedNextIndex;
		KPlayer playerByIndex = _game.GetPlayerByIndex(rotatedNextIndex);
		_team1P2Avatar.Initialize(playerByIndex);
		goto IL_02f3;
		IL_03d7:
		int rotatedNextIndex2 = IntegerExtensions.GetRotatedNextIndex(num2, 3, 1, 5);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v7+E4]");
		if ((nint)0 != 0)
		{
			if (!_team2P2Avatar)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = _team2P2Avatar;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				return;
			}
		}
		KPlayer playerByIndex2 = _game.GetPlayerByIndex(rotatedNextIndex2);
		_team2P2Avatar.Initialize(playerByIndex2);
		return;
		IL_03ab:
		int rotatedNextIndex3;
		KPlayer playerByIndex3 = _game.GetPlayerByIndex(rotatedNextIndex3);
		_team2P1Avatar.Initialize(playerByIndex3);
		goto IL_03d7;
		IL_00a9:
		bool flag7 = team1P1Avatar;
		bool flag8 = !flag7;
		object obj8 = !flag8;
		if (obj8 != null)
		{
			goto IL_01d3;
		}
		obj3 = obj;
		num2 = num;
		goto IL_020f;
		IL_01d3:
		KPlayer playerByIndex4 = _game.GetPlayerByIndex(num);
		_team1P1Avatar.Initialize(playerByIndex4);
		obj3 = obj;
		num2 = num;
		goto IL_020f;
		IL_02f3:
		rotatedNextIndex3 = IntegerExtensions.GetRotatedNextIndex(num2, 1, 1, 5);
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag9 = _team2P1Avatar;
			bool flag10 = !flag9;
			object obj10 = !flag10;
			if (obj10 != null)
			{
				goto IL_03ab;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)_team2P1Avatar)
			{
				goto IL_03ab;
			}
		}
		goto IL_03d7;
		IL_020f:
		rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(num2, 2, 1, 5);
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			bool flag11 = _team1P2Avatar;
			bool flag12 = !flag11;
			object obj12 = !flag12;
			if (obj12 != null)
			{
				goto IL_02c7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)_team1P2Avatar)
			{
				goto IL_02c7;
			}
		}
		goto IL_02f3;
	}

	private void GetSprites()
	{
		//IL_002e: Expected O, but got I4
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_046a: Expected O, but got I4
		//IL_0289: Expected O, but got I4
		//IL_0292: Expected O, but got I4
		//IL_04c0: Expected O, but got I4
		//IL_04c9: Expected O, but got I4
		//IL_0312: Expected O, but got I4
		//IL_031b: Expected O, but got I4
		//IL_051a: Expected O, but got I4
		//IL_0570: Expected O, but got I4
		//IL_0579: Expected O, but got I4
		//IL_039b: Expected O, but got I4
		//IL_03a4: Expected O, but got I4
		//IL_0620: Expected O, but got I4
		//IL_0629: Expected O, but got I4
		//IL_05ca: Expected O, but got I4
		//IL_067c: Expected O, but got I4
		bool isSpectator = _game.IsSpectator;
		bool flag = !isSpectator;
		object obj = !flag;
		if (obj == null)
		{
			CardGamePlayer myPlayer = _game.MyPlayer;
			if (myPlayer == null)
			{
				return;
			}
		}
		JackarooCardGameVisualControls gameVisual = _gameVisual;
		int num;
		if (_game.IsSpectator)
		{
			num = 1;
		}
		else
		{
			CardGamePlayer myPlayer2 = _game.MyPlayer;
			num = ((KPlayer)myPlayer2).<Index>k__BackingField;
		}
		Sprite playerMarbleSprite = gameVisual.<Board>k__BackingField.GetPlayerMarbleSprite(num);
		_team1P1Score.SetSprite(playerMarbleSprite);
		_team1P1Score.ManualInit();
		int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(num, 2, 1, 5);
		Sprite playerMarbleSprite2 = gameVisual.<Board>k__BackingField.GetPlayerMarbleSprite(rotatedNextIndex);
		_team1P2Score.SetSprite(playerMarbleSprite2);
		_team1P2Score.ManualInit();
		int rotatedNextIndex2 = IntegerExtensions.GetRotatedNextIndex(num, 1, 1, 5);
		Sprite playerMarbleSprite3 = gameVisual.<Board>k__BackingField.GetPlayerMarbleSprite(rotatedNextIndex2);
		_team2P1Score.SetSprite(playerMarbleSprite3);
		_team2P1Score.ManualInit();
		int rotatedNextIndex3 = IntegerExtensions.GetRotatedNextIndex(num, 3, 1, 5);
		Sprite playerMarbleSprite4 = gameVisual.<Board>k__BackingField.GetPlayerMarbleSprite(rotatedNextIndex3);
		_team2P2Score.SetSprite(playerMarbleSprite4);
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		_team2P2Score.ManualInit();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X0_v33+E4]");
		UnityEngine.Object obj6;
		object obj5;
		if ((nint)0 != 0)
		{
			bool flag2 = _team1P1MarbleImage != null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			obj5 = 0;
			obj6 = null;
			if (obj4 == null)
			{
				goto IL_02a5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = _team1P1MarbleImage != null;
			bool flag5 = !flag4;
			obj5 = 0;
			obj6 = null;
			if (flag5)
			{
				goto IL_02a5;
			}
		}
		_team1P1MarbleImage.sprite = playerMarbleSprite;
		UnityEngine.Object team1P2MarbleImage = _team1P2MarbleImage;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v49+E4]");
		bool flag6 = (nint)0 == 0;
		object obj8 = !flag6;
		obj5 = 0;
		Sprite sprite = playerMarbleSprite;
		UnityEngine.Object team1P2MarbleImage2 = _team1P2MarbleImage;
		if (obj8 != null)
		{
			goto IL_02ee;
		}
		goto IL_04e9;
		IL_0599:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object team2P1MarbleImage;
		bool flag7 = team2P1MarbleImage != null;
		bool flag8 = !flag7;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (flag8)
		{
			goto IL_03b7;
		}
		goto IL_05dd;
		IL_032e:
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v42+E4]");
		bool flag9 = (nint)0 == 0;
		UnityEngine.Object team2P1MarbleImage2 = _team2P1MarbleImage;
		UnityEngine.Object obj12;
		Sprite sprite2 = (Sprite)obj12;
		team2P1MarbleImage = _team2P1MarbleImage;
		if (!flag9)
		{
			goto IL_0377;
		}
		goto IL_0599;
		IL_03b7:
		UnityEngine.Object team2P2MarbleImage = _team2P2MarbleImage;
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v7+E4]");
		bool flag10 = (nint)0 == 0;
		Sprite sprite3 = (Sprite)obj10;
		UnityEngine.Object team2P2MarbleImage2 = _team2P2MarbleImage;
		if (!flag10)
		{
			goto IL_0400;
		}
		goto IL_0649;
		IL_05dd:
		_team2P1MarbleImage.sprite = playerMarbleSprite3;
		team2P2MarbleImage = _team2P2MarbleImage;
		obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v7+E4]");
		bool flag11 = (nint)0 == 0;
		object obj14 = !flag11;
		obj9 = 0;
		sprite3 = playerMarbleSprite3;
		team2P2MarbleImage2 = _team2P2MarbleImage;
		if (obj14 != null)
		{
			goto IL_0400;
		}
		goto IL_0649;
		IL_0377:
		bool flag12 = team2P1MarbleImage2 != null;
		bool flag13 = !flag12;
		object obj15 = !flag13;
		obj9 = 0;
		obj10 = null;
		if (obj15 == null)
		{
			goto IL_03b7;
		}
		goto IL_05dd;
		IL_0427:
		_team2P2MarbleImage.sprite = playerMarbleSprite4;
		return;
		IL_0400:
		if (team2P2MarbleImage != null)
		{
			goto IL_0427;
		}
		return;
		IL_0649:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag14 = team2P2MarbleImage2 != null;
		bool flag15 = !flag14;
		object obj16 = !flag15;
		if (obj16 == null)
		{
			return;
		}
		goto IL_0427;
		IL_02a5:
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v49+E4]");
		bool flag16 = (nint)0 == 0;
		team1P2MarbleImage = _team1P2MarbleImage;
		sprite = (Sprite)obj6;
		team1P2MarbleImage2 = _team1P2MarbleImage;
		if (!flag16)
		{
			goto IL_02ee;
		}
		goto IL_04e9;
		IL_04e9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag17 = team1P2MarbleImage2 != null;
		bool flag18 = !flag17;
		object obj17 = 0;
		obj12 = null;
		if (flag18)
		{
			goto IL_032e;
		}
		goto IL_052d;
		IL_02ee:
		bool flag19 = team1P2MarbleImage != null;
		bool flag20 = !flag19;
		object obj18 = !flag20;
		obj17 = 0;
		obj12 = null;
		if (obj18 == null)
		{
			goto IL_032e;
		}
		goto IL_052d;
		IL_052d:
		_team1P2MarbleImage.sprite = playerMarbleSprite2;
		team2P1MarbleImage2 = _team2P1MarbleImage;
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X0_v42+E4]");
		bool flag21 = (nint)0 == 0;
		object obj19 = !flag21;
		obj17 = 0;
		sprite2 = playerMarbleSprite2;
		team2P1MarbleImage = _team2P1MarbleImage;
		if (obj19 != null)
		{
			goto IL_0377;
		}
		goto IL_0599;
	}

	private void UpdateScores()
	{
		//IL_0074: Expected O, but got I4
		//IL_013a: Expected O, but got I4
		//IL_0308: Expected O, but got I4
		//IL_020f: Expected O, but got I4
		CardGamePlayer myPlayer = _game.MyPlayer;
		int playerScore;
		if (myPlayer != null)
		{
			CardGamePlayer myPlayer2 = _game.MyPlayer;
			playerScore = _game.GetPlayerScore(((KPlayer)myPlayer2).<Index>k__BackingField);
			bool flag = (object)_team1P1Score == null;
			object obj = !flag;
			if (obj == null)
			{
				goto IL_0316;
			}
		}
		else
		{
			playerScore = _game.GetPlayerScore(1);
		}
		_team1P1Score.CurrentProgress = playerScore;
		CardGamePlayer myPlayer3 = _game.MyPlayer;
		int playerScore2;
		if (myPlayer3 != null)
		{
			CardGamePlayer myPlayer4 = _game.MyPlayer;
			CardGamePlayer teammate = myPlayer4.Teammate;
			playerScore2 = _game.GetPlayerScore(((KPlayer)teammate).<Index>k__BackingField);
			bool flag2 = (object)_team1P2Score == null;
			object obj2 = !flag2;
			if (obj2 == null)
			{
				goto IL_0316;
			}
		}
		else
		{
			playerScore2 = _game.GetPlayerScore(3);
		}
		_team1P2Score.CurrentProgress = playerScore2;
		CardGamePlayer myPlayer5 = _game.MyPlayer;
		int playerScore3;
		if (myPlayer5 != null)
		{
			CardGamePlayer myPlayer6 = _game.MyPlayer;
			int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(((KPlayer)myPlayer6).<Index>k__BackingField, 1, 1, 5);
			playerScore3 = _game.GetPlayerScore(rotatedNextIndex);
			bool flag3 = (object)_team2P1Score == null;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				goto IL_0316;
			}
		}
		else
		{
			playerScore3 = _game.GetPlayerScore(2);
		}
		_team2P1Score.CurrentProgress = playerScore3;
		CardGamePlayer myPlayer7 = _game.MyPlayer;
		int playerScore4;
		if (myPlayer7 != null)
		{
			CardGamePlayer myPlayer8 = _game.MyPlayer;
			int rotatedNextIndex2 = IntegerExtensions.GetRotatedNextIndex(((KPlayer)myPlayer8).<Index>k__BackingField, 3, 1, 5);
			playerScore4 = _game.GetPlayerScore(rotatedNextIndex2);
		}
		else
		{
			playerScore4 = _game.GetPlayerScore(4);
			bool flag4 = (object)_team2P2Score == null;
			object obj4 = !flag4;
			if (obj4 == null)
			{
				goto IL_0316;
			}
		}
		_team2P2Score.CurrentProgress = playerScore4;
		return;
		IL_0316:
		throw new NullReferenceException();
	}
}
