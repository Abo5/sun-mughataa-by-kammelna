using System;
using System.Diagnostics;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class RaterWinsCounter : MonoBehaviour
{
	private CardGame game;

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_008b: Expected O, but got I
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I
		//IL_00d5: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_006c: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)24;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1376;
		object obj4 = (nint)0 + (nint)1528;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj7 = this + 32;
		object obj8 = default(object);
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj4);
		((CardGame)obj7).OnCardGameEnd += action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1376;
		object obj2 = (nint)0 + (nint)1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		game.OnCardGameEnd -= action;
	}

	private void UpdateRaterInfo(CardGameEndScores gameEnd)
	{
		//IL_002e: Expected O, but got I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0089: Expected O, but got I4
		//IL_0126: Expected O, but got I4
		//IL_00d0: Expected O, but got I4
		bool isSpectator = game.IsSpectator;
		bool flag = !isSpectator;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		int myTeamIndex = game.MyTeamIndex;
		object obj2 = typeof(UsageHint) + 72;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj5 = gameEnd.<WinnerTeamIndex>k__BackingField - myTeamIndex;
		bool lastGameWon = obj5 == null;
		UserInfo.LastGameWon = lastGameWon;
		if (UserInfo.LastGameWon)
		{
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int rateUsWins = UserInfo.RateUsWins;
			int rateUsWins2 = rateUsWins + 1;
			UserInfo.RateUsWins = rateUsWins2;
		}
	}
}
