using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using UnityEngine;

public class StagesButtonListener : MonoBehaviour
{
	private MassTournamentEventChannel channel;

	private int tabToSwitchTo;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		channel.OnStagesButtonClicked += action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3848;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		channel.OnStagesButtonClicked -= action;
	}

	private void SwitchTab()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		TabsUI tabsUI = default(TabsUI);
		tabsUI.Activate(tabToSwitchTo);
	}
}
