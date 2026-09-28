using Cpp2ILInjected;
using UnityEngine;

public class SpritesStore : ScriptableObject
{
	public Sprite Spades;

	public Sprite Hearts;

	public Sprite Clubs;

	public Sprite Diamonds;

	public Sprite SoundEnabled;

	public Sprite SoundDisabled;

	public Sprite MusicDisabled;

	public Sprite ChatEnabled;

	public Sprite ChatDisabled;

	public Sprite[] AiAvatars;

	public Sprite GetSuitSprite(Suit suit)
	{
		//IL_001a: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0042: Expected O, but got I4
		//IL_006b: Expected O, but got I4
		//IL_0082: Expected O, but got I
		bool flag = suit < Suit.DIAMONDS;
		object obj = !flag;
		object obj2 = suit - 3;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 == null)
		{
			object obj5 = (int)suit << 3;
			object obj6 = (object)this + obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v2+18]");
			return (Sprite)0;
		}
		return null;
	}

	public Sprite GetGameSoundSprite(Preferences.GameSoundState soundState)
	{
		//IL_001a: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0042: Expected O, but got I4
		//IL_006c: Expected O, but got I4
		//IL_007c: Expected O, but got I
		//IL_0089: Expected O, but got I
		bool flag = soundState < Preferences.GameSoundState.AllOff;
		object obj = !flag;
		object obj2 = soundState - 2;
		bool flag2 = obj2 == null;
		object obj3 = !flag2;
		object obj4 = obj & obj3;
		if (obj4 == null)
		{
			object obj5 = 119873536 + 3480;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X8_v2+soundState @ X1 (Preferences+GameSoundState)*8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpritesStore)+v14 @ X8_v3]");
			return (Sprite)0;
		}
		return null;
	}
}
