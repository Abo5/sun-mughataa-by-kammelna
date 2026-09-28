using System;
using System.Data.SqlTypes;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

namespace Jackaroo;

public class JackarooGameEndPopup : GameEndPopup
{
	private CardGameEndScores _rankReport;

	protected override void OnGameEnd(CardGameEndScores rankReport)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 248;
		obj = rankReport;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	protected override void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01b0: Expected O, but got I
		//IL_01bc: Expected O, but got I
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01fa: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_008f: Expected I, but got O
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I
		//IL_00f4: Expected I, but got O
		//IL_0105: Expected O, but got I
		//IL_0131: Expected I, but got O
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0174: Expected O, but got I
		//IL_018c: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = (nint)0 + (nint)104;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1376;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 176;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj9 = this + 160;
		object obj10 = default(object);
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v4 (Il2CppClass<Jackaroo.JackarooGameEndPopup>)+190]");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)0);
		object obj11 = typeof(SqlSingle[]) + 2376;
		object obj12 = (nint)0 + (nint)696;
		((CardGame)obj7).OnCardGameEnd += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj12);
		object obj13 = (nint)0 + (nint)184;
		gameEventsChannel.OpenEndGamePopup += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj13);
		gameEventsChannel.CloseEndGamePopup += action3;
		Button button = saveGameButton;
		object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj15 = (nint)0 + (nint)200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj15);
		button.m_OnClick.AddListener(unityAction);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c6: Expected I, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0065: Expected I, but got O
		//IL_0076: Expected O, but got I
		//IL_00a2: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3 (Il2CppClass<Jackaroo.JackarooGameEndPopup>)+190]");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)0);
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)696;
		game.OnCardGameEnd -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		object obj4 = (nint)0 + (nint)184;
		gameEventsChannel.OpenEndGamePopup -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj4);
		gameEventsChannel.CloseEndGamePopup -= action3;
	}

	private void OpenEndGamePopup()
	{
		Popup(_rankReport);
	}
}
