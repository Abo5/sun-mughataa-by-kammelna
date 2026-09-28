using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameStateUI : MonoBehaviour
{
	private const string ClickToEat = "Click anywhere to eat";

	private const string ClickToContinue = "Click anywhere to continue";

	private const float AcceptNextDelay = 2f;

	private bool _AcceptNextIsDelayed;

	private SlideAnimationHelper slider;

	private TextMeshProUGUI message;

	private Image clickTarget;

	private Timer timer;

	private CardGame game;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_012d: Expected O, but got I
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Expected O, but got Unknown
		//IL_014d: Expected O, but got I
		//IL_0177: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0091: Expected O, but got I
		//IL_00bb: Expected I, but got O
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I
		//IL_010c: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2472;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 72;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3368;
		object obj10 = (nint)0 + (nint)2488;
		((KGame)obj7).OnGameStateUpdated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj10);
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2512;
		object obj12 = (nint)0 + (nint)2480;
		game.OnSawa += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj12);
		game.OnKasho += action3;
	}

	private void OnGameStateUpdated()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_010a: Expected O, but got I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		CardGame cardGame = game;
		if (((KGame)cardGame).<GamePhase>k__BackingField.IsLookingForPlayers)
		{
			object text = "Unsupported map type" + 3512;
			TextMeshProExtensions.Localize(message, (string)text);
			slider.SlideIn();
			return;
		}
		if (!game.IsSpectator)
		{
			bool flag = ShouldAcceptNext();
			KGame kGame = game;
			if (flag)
			{
				ShowAcceptNext(kGame.<WatchDogTimer>k__BackingField);
				return;
			}
			bool isFastTrackGame = game.IsFastTrackGame;
			bool flag2 = !isFastTrackGame;
			object obj = !flag2;
			if (obj == null)
			{
				CardGamePlayer myPlayer = game.MyPlayer;
				switch (myPlayer.SeatStatus)
				{
				case SeatStatus.WaitingForApproval:
				{
					object stateMessage2 = "Unsupported map type" + 3488;
					ShowGameState((string)stateMessage2);
					return;
				}
				case SeatStatus.Reserved:
				{
					object stateMessage = "Unsupported map type" + 3472;
					ShowGameState((string)stateMessage);
					return;
				}
				}
				goto IL_009c;
			}
		}
		clickTarget.raycastTarget = false;
		goto IL_009c;
		IL_009c:
		slider.SlideOut();
	}

	private bool ShouldAcceptNext()
	{
		//IL_0186: Expected I4, but got O
		//IL_0166: Expected O, but got I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected I4, but got Unknown
		if ((object)game != null)
		{
			if (game.IsSpectator)
			{
				return false;
			}
			if ((object)game != null)
			{
				CardGamePlayer myPlayer = game.MyPlayer;
				if (myPlayer != null)
				{
					bool canEat = myPlayer.CanEat;
					if ((object)game != null)
					{
						CardGamePlayer myPlayer2 = game.MyPlayer;
						if (myPlayer2 != null)
						{
							bool shouldAcceptNext = myPlayer2.ShouldAcceptNext;
							if ((object)game != null)
							{
								CardGamePlayer myPlayer3 = game.MyPlayer;
								if (myPlayer3 != null)
								{
									bool isHumanSeated = myPlayer3.IsHumanSeated;
									object obj = canEat || shouldAcceptNext;
									return (byte)((isHumanSeated & obj) ? 1 : 0) != 0;
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	private void ShowAcceptNext(float duration)
	{
		//IL_002e: Expected O, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I4
		//IL_0114: Expected I, but got O
		//IL_0124: Expected O, but got I
		//IL_0134: Expected O, but got I
		bool isSpectator = game.IsSpectator;
		bool flag = !isSpectator;
		object obj = !flag;
		if (obj != null || _AcceptNextIsDelayed)
		{
			return;
		}
		timer.StartTimer(duration);
		CardGamePlayer myPlayer = game.MyPlayer;
		bool canEat = myPlayer.CanEat;
		object text = "Cannot populate JSON object onto type '{0}'." + 3160;
		object obj2 = "Cannot populate JSON object onto type '{0}'." + 3152;
		bool flag2 = !canEat;
		object obj3 = !flag2;
		object obj4 = ~obj3;
		if (obj4 != null)
		{
			text = obj2;
		}
		while (true)
		{
			TextMeshProExtensions.Localize(message, (string)text);
			slider.SlideIn();
			Image image = clickTarget;
			nint num = (nint)image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v9 (Il2CppClass<UnityEngine.UI.Image>)+2C8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v9 (Il2CppClass<UnityEngine.UI.Image>)+2D0]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v124 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	public void AcceptNext()
	{
		CardGame cardGame = game;
		if (cardGame.<Stage>k__BackingField.IsWaitingForEating)
		{
			game.SendEatCards();
		}
		else
		{
			game.SendAcceptNext();
		}
		clickTarget.raycastTarget = false;
		slider.SlideOut();
	}

	private void ShowGameState(string stateMessage)
	{
		TextMeshProExtensions.Localize(message, stateMessage);
		slider.SlideIn();
	}

	private void Hide()
	{
		clickTarget.raycastTarget = false;
		slider.SlideOut();
	}

	private void OnSawa(SawaInfo sawaInfo)
	{
		if (!game.IsSpectator || game.IsReplay)
		{
			ShowAcceptNextAfterDelay();
		}
	}

	private void OnKasho(KashoInfo kashoInfo)
	{
		if (!game.IsSpectator)
		{
			ShowAcceptNextAfterDelay();
		}
	}

	private void ShowAcceptNextAfterDelay()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0041: Expected I, but got O
		//IL_0067: Expected I, but got O
		//IL_0096: Expected O, but got I4
		_AcceptNextIsDelayed = true;
		Image image = clickTarget;
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2464;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		nint num = (nint)image;
		image.raycastTarget = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(2f, action);
	}

	private void <ShowAcceptNextAfterDelay>b__18_0()
	{
		_AcceptNextIsDelayed = false;
		if (ShouldAcceptNext())
		{
			CardGame cardGame = game;
			float duration = ((KGame)cardGame).<WatchDogTimer>k__BackingField + -2f;
			ShowAcceptNext(duration);
		}
	}
}
