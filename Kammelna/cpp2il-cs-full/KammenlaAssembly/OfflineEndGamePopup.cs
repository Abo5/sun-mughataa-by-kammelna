using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class OfflineEndGamePopup : MonoBehaviour
{
	public static readonly Color BlockerColor;

	public static readonly Color BlockerColorLose;

	private PopupUI popup;

	private Image blocker;

	private Animation showAnimation;

	private TextMeshProUGUI outcomeText;

	private Image outcomeImage;

	private Sprite outcomeWin;

	private Sprite outcomeLose;

	private GameObject loseSticker;

	private CardGame _game;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0178: Expected O, but got I
		//IL_01a2: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_007b: Expected O, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I
		//IL_00fd: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 96;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool isReplay = ((KGame)obj5).IsReplay;
		bool flag2 = !isReplay;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Room room = ((KGame)obj5).Room;
			if (SFSKammelnaRoomExtensions.IsOffline(room))
			{
				object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)1736;
				Action<object> action = default(Action<object>);
				action..ctor((object)this, (IntPtr)obj9);
				_game.OnCardGameEnd += action;
				return;
			}
		}
		GameObject obj10 = base.gameObject;
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v5+E4]");
		if ((nint)0 != 0)
		{
			UnityEngine.Object.Destroy(obj10);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.Destroy(obj10);
	}

	private void OnGameEnd(CardGameEndScores report)
	{
		if (report.<WinnerTeamIndex>k__BackingField == 1)
		{
			InitWin();
		}
		else
		{
			InitLose();
		}
		popup.PopFromCenter();
		bool flag = showAnimation.Play();
	}

	private void InitWin()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0082: Expected O, but got I4
		//IL_00b7: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00d7: Expected O, but got I
		//IL_00ef: Expected O, but got I
		//IL_00f7: Expected I, but got O
		//IL_0107: Expected O, but got I
		//IL_0117: Expected O, but got I
		object text = "WhiteSmoke" + 2128;
		while (true)
		{
			TextMeshProExtensions.Localize(outcomeText, (string)text);
			outcomeImage.sprite = outcomeWin;
			object obj = typeof(MemberAchievementClanFeedData) + 3224;
			loseSticker.SetActive(value: false);
			Image image = blocker;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v5+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6+C]");
			object obj7 = 0;
			object obj8 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6+4]");
			object obj9 = 0;
			nint num = (nint)image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v85 @ X2_v5 (should have been resolved before IL gen)");
		}
	}

	private void InitLose()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0082: Expected O, but got I4
		//IL_00b7: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00d7: Expected O, but got I
		//IL_00e7: Expected O, but got I
		//IL_00f7: Expected O, but got I
		//IL_00ff: Expected I, but got O
		//IL_010f: Expected O, but got I
		//IL_011f: Expected O, but got I
		object text = "WhiteSmoke" + 2000;
		while (true)
		{
			TextMeshProExtensions.Localize(outcomeText, (string)text);
			outcomeImage.sprite = outcomeLose;
			object obj = typeof(MemberAchievementClanFeedData) + 3224;
			loseSticker.SetActive(value: true);
			Image image = blocker;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v5+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6+1C]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6+10]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v6+14]");
			object obj9 = 0;
			nint num = (nint)image;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7 (Il2CppClass<UnityEngine.UI.Image>)+2A8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v7 (Il2CppClass<UnityEngine.UI.Image>)+2B0]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v85 @ X2_v5 (should have been resolved before IL gen)");
		}
	}

	private void StartAnimation()
	{
		bool flag = showAnimation.Play();
	}

	public void PlayNewGame()
	{
		KGame.RestartGame();
		popup.ShrinkToParent();
	}

	public void Exit()
	{
		_game.ExitGame();
	}

	public void ShowRoundBoard()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e4: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00b8: Expected O, but got I
		//IL_00c8: Expected O, but got I
		//IL_0157: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E65CA]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00d2;
		}
		object obj4 = (nint)0 + (nint)16;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = obj4;
		if (!flag)
		{
			goto IL_0091;
		}
		goto IL_0124;
		IL_0124:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = default(object);
		bool flag2 = obj7 == null;
		object obj8 = !flag2;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		goto IL_00a0;
		IL_00a0:
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7+1E8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7+1F0]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v69 @ X2_v1 (should have been resolved before IL gen)");
		goto IL_00d2;
		IL_00d2:
		_ = 1;
		obj4 = (nint)0 + (nint)16;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		obj6 = obj4;
		if (obj12 != null)
		{
			goto IL_0091;
		}
		goto IL_0124;
	}

	public void TestWin()
	{
		InitWin();
		popup.PopFromCenter();
		bool flag = showAnimation.Play();
	}

	public void TestLose()
	{
		InitLose();
		popup.PopFromCenter();
		bool flag = showAnimation.Play();
	}

	static OfflineEndGamePopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		//IL_0041: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 3224;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252B70]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252B80]");
		_ = 0;
	}
}
