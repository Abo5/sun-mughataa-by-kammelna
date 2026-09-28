using Cpp2ILInjected;
using UnityEngine;

public class RoomThemesSprites : ScriptableObject
{
	private Sprite FastTrackLevel1;

	private Sprite FastTrackLevel2;

	private Sprite Tutorial;

	public Sprite GetRoomTheme(bool isFastTrack, int ftLevel, bool isTutorial)
	{
		//IL_0077: Expected O, but got I4
		//IL_0084: Expected O, but got I
		//IL_0050: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_0042: Expected O, but got I4
		if (isFastTrack)
		{
			if (ftLevel == 1)
			{
				object obj = 24;
			}
			else
			{
				object obj = 32;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomThemesSprites)+v23 @ X8_v3]");
			return (Sprite)0;
		}
		if (isTutorial)
		{
			object obj2 = 40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomThemesSprites)+v19 @ X8_v1]");
			return (Sprite)0;
		}
		return null;
	}
}
