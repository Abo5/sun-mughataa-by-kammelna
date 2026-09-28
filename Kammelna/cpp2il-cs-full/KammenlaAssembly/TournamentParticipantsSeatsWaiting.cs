using System.Data.SqlTypes;
using Cpp2ILInjected;
using DG.Tweening;
using TMPro;

public class TournamentParticipantsSeatsWaiting : TournamentParticipants
{
	private TextMeshProUGUI listNumberText;

	private TextMeshProUGUI listName;

	private const string NumberOfParticipants = "Number of Participants";

	private const string RemainingSeats = "Remaining Seats";

	private const string WaitingList = "Waiting List";

	private TournamentData TournamentInfo => SFSKammelnaRoomExtensions.GetTournamentInfo(_tournamentRoom);

	protected override void InitializeUi(int allowedSeats, int participantsCount, int freeSeats, int waitingList)
	{
		//IL_01b3: Expected O, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00da: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0109: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(_tournamentRoom);
		if (tournamentInfo != null && tournamentInfo.<IsCluster>k__BackingField)
		{
			object obj = (??)tournamentInfo.<ClusterCapacity>k__BackingField & 1;
			if (obj == null)
			{
				goto IL_0094;
			}
		}
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(_tournamentRoom);
		if (TournamentStatusExtensions.IsStarted(tournamentStatus))
		{
			goto IL_0094;
		}
		object obj3;
		int num;
		object text;
		int number;
		object obj2;
		if (allowedSeats > participantsCount)
		{
			obj2 = 152985600 + 3565;
			obj3 = "Read object reference Id '{0}' for {1}." + 1488;
			object obj4 = obj2 & 1;
			bool flag = obj4 == null;
			num = freeSeats;
			if (flag)
			{
				goto IL_0100;
			}
			text = obj3;
			number = freeSeats;
		}
		else
		{
			obj2 = 152985600 + 3566;
			obj3 = "Unsupported map type" + 3520;
			object obj5 = obj2 & 1;
			bool flag2 = obj5 == null;
			num = waitingList;
			if (flag2)
			{
				goto IL_0100;
			}
			text = obj3;
			number = waitingList;
		}
		goto IL_0236;
		IL_0094:
		obj2 = 152985600 + 3564;
		obj3 = "Network Authentication Required" + 2560;
		object obj6 = obj2 & 1;
		bool flag3 = obj6 == null;
		object obj7 = !flag3;
		num = participantsCount;
		text = obj3;
		number = participantsCount;
		if (obj7 == null)
		{
			goto IL_0100;
		}
		goto IL_0236;
		IL_0236:
		TextMeshProExtensions.Localize(listName, (string)text);
		int num2 = ShortcutExtensions.DOKill(listNumberText, complete: true);
		TextMeshProExtensions.SetNumber(listNumberText, number);
		return;
		IL_0100:
		obj2 = 1;
		text = obj3;
		number = num;
		goto IL_0236;
	}

	protected override void UpdateUi(int allowedSeats, int participantsCount, int freeSeats, int waitingList)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(_tournamentRoom);
		if (tournamentInfo != null && tournamentInfo.<IsCluster>k__BackingField)
		{
			object obj = (??)tournamentInfo.<ClusterCapacity>k__BackingField & 1;
			if (obj == null)
			{
				goto IL_0094;
			}
		}
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(_tournamentRoom);
		if (TournamentStatusExtensions.IsStarted(tournamentStatus))
		{
			goto IL_0094;
		}
		if (allowedSeats > participantsCount)
		{
			UpdateRemainingSeats(freeSeats);
		}
		else
		{
			UpdateWaitingNumber(waitingList);
		}
		return;
		IL_0094:
		UpdateParticipantsNumber(participantsCount);
	}

	private void SetParticipantsNumber(int participantsCount)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "Network Authentication Required" + 2560;
		TextMeshProExtensions.Localize(listName, (string)text);
		int num = ShortcutExtensions.DOKill(listNumberText, complete: true);
		TextMeshProExtensions.SetNumber(listNumberText, participantsCount);
	}

	private void UpdateParticipantsNumber(int participantsCount)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I4
		object text = "Network Authentication Required" + 2560;
		object obj = typeof(SqlSingle[]) + 3912;
		TextMeshProExtensions.Localize(listName, (string)text);
		int num = ShortcutExtensions.DOKill(listNumberText, complete: true);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tweener tweener = AnimationExtensions.DONumber(listNumberText, participantsCount, 0.5f);
	}

	private void SetRemainingSeats(int freeSeats)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "Read object reference Id '{0}' for {1}." + 1488;
		TextMeshProExtensions.Localize(listName, (string)text);
		int num = ShortcutExtensions.DOKill(listNumberText, complete: true);
		TextMeshProExtensions.SetNumber(listNumberText, freeSeats);
	}

	private void UpdateRemainingSeats(int freeSeats)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I4
		object text = "Read object reference Id '{0}' for {1}." + 1488;
		object obj = typeof(SqlSingle[]) + 3912;
		TextMeshProExtensions.Localize(listName, (string)text);
		int num = ShortcutExtensions.DOKill(listNumberText, complete: true);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tweener tweener = AnimationExtensions.DONumber(listNumberText, freeSeats, 0.5f);
	}

	private void SetWaitingNumber(int waitingList)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "Unsupported map type" + 3520;
		TextMeshProExtensions.Localize(listName, (string)text);
		int num = ShortcutExtensions.DOKill(listNumberText, complete: true);
		TextMeshProExtensions.SetNumber(listNumberText, waitingList);
	}

	private void UpdateWaitingNumber(int waitingList)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_00b0: Expected O, but got I4
		object text = "Unsupported map type" + 3520;
		object obj = typeof(SqlSingle[]) + 3912;
		TextMeshProExtensions.Localize(listName, (string)text);
		int num = ShortcutExtensions.DOKill(listNumberText, complete: true);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tweener tweener = AnimationExtensions.DONumber(listNumberText, waitingList, 0.5f);
	}
}
