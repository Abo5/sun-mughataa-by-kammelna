using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using KammelnaOffline.Baloot.Tutorial;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class TutorialErrorPanel : MonoBehaviour
{
	private TopbarExtraButtons movingPanel;

	private TextMeshProUGUI bodyText;

	private TextMeshProUGUI titleText;

	private GameEventsChannel gameEventsChannel;

	private BalootGame game;

	public void Start()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0035: Expected O, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0055: Expected O, but got I
		//IL_007f: Expected O, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00e0: Expected I, but got O
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0105: Expected O, but got I
		//IL_012f: Expected I, but got O
		if (ScreenUtility.IsTablet)
		{
			movingPanel.Hide();
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)8;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)2288;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 64;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1368;
		object obj10 = (nint)0 + (nint)2296;
		((KGame)obj7).OnGameStateUpdated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj10);
		gameEventsChannel.OnTutorialCardPreventedToPlay += action2;
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
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
		object obj2 = (nint)0 + (nint)2280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1368;
		object obj4 = (nint)0 + (nint)2296;
		gameEventsChannel.OnDismissibleClicked -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		gameEventsChannel.OnTutorialCardPreventedToPlay -= action2;
	}

	private void OnGameStateUpdated()
	{
		CardGameLastActionInfo lastAction = game.LastAction;
		BalootPlayer myPlayer = game.MyPlayer;
		if (((LastActionInfo)lastAction).<ActionPlayer>k__BackingField == ((KPlayer)myPlayer).<Index>k__BackingField)
		{
			Hide();
		}
	}

	private void Hide(GameCard _)
	{
		Hide();
	}

	public void Hide()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_006d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
		object obj2 = (nint)0 + (nint)2280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		gameEventsChannel.OnDismissibleClicked -= action;
		gameEventsChannel.TriggerHideDismissibleBlocker();
		movingPanel.Hide();
	}

	private void ShowErrorMessage(Card selectedCard)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_008a: Expected O, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00fe: Expected O, but got I
		//IL_0126: Expected I, but got O
		//IL_0157: Expected I, but got O
		BalootPlayer myPlayer = game.MyPlayer;
		List<Card> <Cards>k__BackingField = ((CardGamePlayer)myPlayer).<Cards>k__BackingField;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2304;
		Room room = game.Room;
		TutorialType tutorialType = SFSKammelnaRoomExtensions.GetTutorialType(room);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IntPtr intPtr = default(IntPtr);
		TutorialTipsAndErrors.SetupErrorMessage(bodyText, titleText, (TutorialType)(nint)intPtr, <Cards>k__BackingField._size, selectedCard);
		movingPanel.Show();
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2064;
		object obj5 = (nint)0 + (nint)2280;
		gameEventsChannel.TriggerShowDismissibleBlocker();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj5);
		gameEventsChannel.OnDismissibleClicked -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		gameEventsChannel.OnDismissibleClicked += action2;
	}
}
