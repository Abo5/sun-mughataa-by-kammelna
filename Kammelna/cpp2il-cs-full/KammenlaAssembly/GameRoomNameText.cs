using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;

public class GameRoomNameText : MonoBehaviour
{
	private TextMeshProUGUI _text;

	private KGame _game;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I
		//IL_00ed: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0074: Expected O, but got I
		//IL_00a8: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj5 = this + 40;
		object obj6 = default(object);
		obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj8 = (nint)0 + (nint)2384;
		Room room = ((KGame)obj5).Room;
		Init(room);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj8);
		SFS.OnRoomNameChanged += action;
	}

	private void Init(Room room)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_004d: Expected I, but got O
		//IL_005d: Expected O, but got I
		//IL_0098: Expected O, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0126: Expected O, but got I4
		//IL_014f: Expected O, but got I
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room);
		if (!GameTypeExtensions.IsTournament(gameType) || _game.IsReplay)
		{
			object obj = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d9;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v6 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X10_v5-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00d9;
			}
			object obj4 = obj3 + 1;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			goto IL_0278;
		}
		object obj7 = typeof(Queue<string>) + 872;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v17+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj10 = (nint)0 + (nint)2248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		TournamentMatchInfo tournamentMatchInfo = default(TournamentMatchInfo);
		TournamentData tournament = tournamentMatchInfo.Tournament;
		if (tournament != null)
		{
			TournamentData tournament2 = tournamentMatchInfo.Tournament;
			int matchRound = TournamentMath.GetMatchRound(tournamentMatchInfo.<MatchId>k__BackingField, tournament2.<Size>k__BackingField);
			int numberOfRounds = TournamentMath.GetNumberOfRounds(tournament2.<Size>k__BackingField);
			LocalizableText tournamentRoundName = TournamentUtil.GetTournamentRoundName(matchRound, numberOfRounds);
			TextMeshProExtensions.Localize(_text, tournamentRoundName);
		}
		return;
		IL_00d9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0278;
		IL_0278:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v226 @ X0_v8] (should have been resolved before IL gen)");
		string text = default(string);
		TextMeshProExtensions.FixArabic(_text, text);
	}

	private void OnRoomNameChanged(Room room)
	{
		Init(room);
	}

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 32;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
