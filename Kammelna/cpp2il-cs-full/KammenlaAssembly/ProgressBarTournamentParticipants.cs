public class ProgressBarTournamentParticipants : TournamentParticipants
{
	private ProgressBar remainingSeats;

	protected override void InitializeUi(int allowedSeats, int participantsCount, int freeSeats, int waitingList)
	{
		remainingSeats.StaticInitialize(allowedSeats, freeSeats);
	}

	protected override void UpdateUi(int allowedSeats, int participantsCount, int freeSeats, int waitingList)
	{
		remainingSeats.Initialize(allowedSeats, freeSeats);
	}
}
