using Cpp2ILInjected;

public class GenericSoundAlbum : SoundAlbum<GenericSoundAlbumTrack>
{
	public GenericSoundAlbum()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF2E0");
	}
}
