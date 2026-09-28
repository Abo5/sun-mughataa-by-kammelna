using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class MonthlyTrophySpriteSetter : MonthlyTrophyUISubSetter<Sprite>
{
	private Image image;

	public override void Populate(UserAchievementModel trophy)
	{
		//IL_001b: Expected O, but got I
		UserAchievementModel trophy2 = default(UserAchievementModel);
		object trophyAsset = GetTrophyAsset(trophy2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (MonthlyTrophySpriteSetter)+38]");
		((Image)0).sprite = (Sprite)trophyAsset;
	}

	public MonthlyTrophySpriteSetter()
	{
		((MonthlyTrophyUISubSetter<object>)(object)this)..ctor();
	}
}
