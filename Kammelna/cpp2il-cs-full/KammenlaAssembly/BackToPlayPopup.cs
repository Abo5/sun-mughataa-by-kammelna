using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;

public class BackToPlayPopup : PopupUI
{
	private TextMeshProUGUI bodyText;

	private Timer timer;

	private KGame game;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0140: Expected O, but got I
		//IL_016a: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a4: Expected O, but got I
		//IL_00be: Expected O, but got I4
		//IL_01ab: Expected I, but got O
		//IL_00f3: Expected O, but got I
		//IL_011f: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 136;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool isFastTrackGame = ((KGame)obj5).IsFastTrackGame;
		object text = "WhiteSmoke" + 1928;
		object obj7 = "WhiteSmoke" + 1936;
		object obj8 = typeof(SqlSingle[]) + 2376;
		object obj9 = (nint)0 + (nint)2200;
		bool flag2 = !isFastTrackGame;
		object obj10 = !flag2;
		object obj11 = ~obj10;
		if (obj11 != null)
		{
			text = obj7;
		}
		bodyText.text = (string)text;
		TextMeshProExtensions.Localize(bodyText);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj9);
		object obj12 = (nint)0 + (nint)2192;
		game.OnGameStateUpdated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj12);
		timer.onTimeIsUp += action2;
	}

	private void OnGameStateUpdated()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @946017C");
	}

	public void ShowPopup()
	{
		//IL_0049: Expected F4, but got I4
		if (!base.<IsCurrentlyShown>k__BackingField)
		{
			SlideFromBottom();
			KGame kGame = game;
			timer.StartTimer(kGame.<AllowedIdleTime>k__BackingField);
		}
	}

	private void Close()
	{
		SlideToBottom();
		timer.Hide();
	}

	public void OnConfirm()
	{
		game.SendBackToGame();
		SlideToBottom();
		timer.Hide();
	}
}
