public abstract class TournamentAddonModel
{
	public abstract int Priority { get; }

	public abstract TournamentAddonType Type { get; }

	public abstract string SerializedData { get; }
}
