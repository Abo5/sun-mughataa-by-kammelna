using Cpp2ILInjected;
using UnityEngine;

public class CardBacksSprites : ScriptableObject
{
	public Sprite DefaultCardback;

	public Sprite FastTrackLevel1;

	public Sprite FastTrackLevel2;

	public Sprite GetCardback(bool isFastTrack, int ftLevel)
	{
		//IL_0037: Expected O, but got I4
		//IL_0069: Expected O, but got I4
		//IL_0029: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_008d: Expected O, but got I
		if (ftLevel == 1)
		{
			object obj = 32;
		}
		else
		{
			object obj = 40;
		}
		bool flag = !isFastTrack;
		object obj2 = !flag;
		object obj3 = ~obj2;
		if (obj3 != null)
		{
			object obj = 24;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (CardBacksSprites)+v31 @ X8_v3]");
		return (Sprite)0;
	}

	public CardBacksSprites()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @94603C8");
	}
}
