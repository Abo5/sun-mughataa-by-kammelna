using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;

public class ProgressTournamentMatchScores : BaseTournamentMatchScores
{
	private DiscreteProgressIndicator ourScoreIndicator;

	private DiscreteProgressIndicator theirScoreTextIndicator;

	private int WiningValue
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00de: Expected O, but got I
			//IL_0108: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_016d: Expected I4, but got O
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Expected O, but got Unknown
			//IL_0151: Expected O, but got I4
			//IL_0187: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 872;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CF8]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2248;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2248;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj8 = default(object);
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_00b8;
			}
			goto IL_015f;
			IL_00b8:
			object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 680;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v14+20]");
			return SFSExtensions.GetVariable((Room)0, (string)varName, 0);
			IL_015f:
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_015f;
		}
	}

	protected override void Init()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0060: Expected I, but got O
		GameObject go = base.gameObject;
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3600;
		object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 680;
		Room room = game.Room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		VariableBinderExtensions.Bind(go, room, (string)varName, action);
	}

	protected override void InitNotTournament()
	{
		GameObject gameObject = ourScoreIndicator.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = theirScoreTextIndicator.gameObject;
		gameObject2.SetActive(value: false);
	}

	private void SetWiningValue()
	{
		int winingValue = WiningValue;
		ourScoreIndicator.MaxProgress = winingValue;
		int winingValue2 = ((ProgressTournamentMatchScores)(object)ourScoreIndicator).WiningValue;
		theirScoreTextIndicator.MaxProgress = winingValue2;
	}

	protected override void OnScoresUpdated()
	{
		int ourScore = base.OurScore;
		ourScoreIndicator.CurrentProgress = ourScore;
		int theirScore = base.TheirScore;
		theirScoreTextIndicator.CurrentProgress = theirScore;
	}
}
