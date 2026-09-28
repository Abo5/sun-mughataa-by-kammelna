public class VoiceChatTournamentAddon : TournamentAddonModel
{
	private readonly string <SerializedData>k__BackingField;

	public override int Priority => 0;

	public override TournamentAddonType Type => TournamentAddonType.VoiceChat;

	public override string SerializedData => <SerializedData>k__BackingField;
}
