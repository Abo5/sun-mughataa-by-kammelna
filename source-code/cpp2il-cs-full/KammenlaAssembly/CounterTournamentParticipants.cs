using System.Data.SqlTypes;
using Cpp2ILInjected;
using DG.Tweening;
using TMPro;

public class CounterTournamentParticipants : TournamentParticipants
{
	private TextMeshProUGUI participantsText;

	protected override void InitializeUi(int allowedSeats, int participantsCount, int freeSeats, int waitingList)
	{
		int num = ShortcutExtensions.DOKill(participantsText, complete: true);
		TextMeshProExtensions.SetNumber(participantsText, participantsCount);
	}

	protected override void UpdateUi(int allowedSeats, int participantsCount, int freeSeats, int waitingList)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0092: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 3912;
		int num = ShortcutExtensions.DOKill(participantsText, complete: true);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Tweener tweener = AnimationExtensions.DONumber(participantsText, participantsCount, 0.5f);
	}
}
