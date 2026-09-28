using System.Runtime.CompilerServices;

public class RoomThemeTournamentAddon : TournamentAddonModel, IRoomThemeAddon
{
	private readonly int <RoomThemeId>k__BackingField;

	public override int Priority => 20;

	public override TournamentAddonType Type => TournamentAddonType.RoomTheme;

	public unsafe override string SerializedData
	{
		get
		{
			//IL_0008: Expected O, but got Ref
			object obj2 = default(object);
			object obj = (object)(&obj2);
			_ = <RoomThemeId>k__BackingField;
			int num = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 4));
			return ((int*)num)->ToString();
		}
	}

	public int RoomThemeId => <RoomThemeId>k__BackingField;

	public RoomThemeTournamentAddon(string roomThemeId)
	{
		int num = int.Parse(roomThemeId);
		<RoomThemeId>k__BackingField = num;
	}
}
