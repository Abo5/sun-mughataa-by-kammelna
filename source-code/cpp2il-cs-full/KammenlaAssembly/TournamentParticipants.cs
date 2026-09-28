using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;

public abstract class TournamentParticipants : MonoBehaviour
{
	protected Room _tournamentRoom;

	private bool _firstTime;

	public void Bind(Room tournamentRoom)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_005b: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1176;
		object varName = "placementId" + 296;
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		_firstTime = true;
		object obj3 = this + 32;
		obj3 = tournamentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		VariableBinderExtensions.Bind(go2, (Room)obj3, (string)varName, action);
	}

	public void SetFromModel(int participantsCount, int maxAllowedSize)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002c: Expected O, but got I4
		//IL_0043: Expected O, but got I4
		//IL_0066: Expected O, but got I4
		//IL_0081: Expected I, but got O
		//IL_0091: Expected O, but got I
		//IL_00a1: Expected O, but got I
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		object obj = this + 32;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = maxAllowedSize - participantsCount;
		object obj3 = ~obj2;
		object obj4 = obj2 & obj3;
		object obj5 = participantsCount - maxAllowedSize;
		object obj6 = ~obj5;
		object obj7 = obj5 & obj6;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3 (Il2CppClass<TournamentParticipants>)+178]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v3 (Il2CppClass<TournamentParticipants>)+180]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v47 @ X6_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void UpdateCounts()
	{
		//IL_0061: Expected O, but got I4
		//IL_0089: Expected O, but got I4
		//IL_00a4: Expected I, but got O
		//IL_00c0: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_011b: Expected O, but got I4
		//IL_00e0: Expected O, but got I4
		//IL_010a: Expected O, but got I4
		//IL_00fc: Expected O, but got I4
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(_tournamentRoom);
		if (tournamentInfo != null)
		{
			TournamentData tournamentInfo2 = SFSKammelnaRoomExtensions.GetTournamentInfo(_tournamentRoom);
			int tournamentParticipantsCount = SFSKammelnaRoomExtensions.GetTournamentParticipantsCount(_tournamentRoom);
			object obj = tournamentInfo2.<MaxAllowedSize>k__BackingField - tournamentParticipantsCount;
			object obj2 = ~obj;
			object obj3 = obj & obj2;
			object obj4 = tournamentParticipantsCount - tournamentInfo2.<MaxAllowedSize>k__BackingField;
			object obj5 = ~obj4;
			object obj6 = obj4 & obj5;
			nint num = (nint)this;
			bool flag = !_firstTime;
			object obj7 = !flag;
			object obj8 = ~obj7;
			if (obj8 == null)
			{
				object obj9 = 376;
			}
			else
			{
				object obj9 = 392;
			}
			object obj10 = !flag;
			object obj11 = ~obj10;
			if (obj11 == null)
			{
				object obj12 = 384;
			}
			else
			{
				object obj12 = 400;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v59 @ X9_v2 (Il2CppClass<TournamentParticipants>)+v136 @ X8_v6] (should have been resolved before IL gen)");
			_firstTime = false;
		}
	}

	protected abstract void InitializeUi(int allowedSeats, int participantsCount, int freeSeats, int waitingList);

	protected abstract void UpdateUi(int allowedSeats, int participantsCount, int freeSeats, int waitingList);
}
