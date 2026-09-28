using Cpp2ILInjected;

public class CatchSoundAlbum : SoundAlbum<CatchSoundAlbumTrack>
{
	public CatchSoundAlbum()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF2E0");
	}
}
