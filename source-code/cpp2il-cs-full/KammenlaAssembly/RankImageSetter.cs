using System;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Serializable]
public class RankImageSetter : IRankSubSetter
{
	private Image image;

	private RankSprites sprites;

	public string Label
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			if ((object)image != null)
			{
				object obj = "Picking audio files is not supported on iOS" + 3920;
				object obj2 = "&action=sign-up" + 2696;
				string name = image.name;
				return (string)obj + name + (string)obj2;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public void Set(PlayerRank playerRank)
	{
		RanksData<object> ranksData = (RanksData<object>)(object)sprites;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2 (RanksData`1<System.Object>)+59]");
		PlayerRank playerRank2 = default(PlayerRank);
		if ((nint)0 == 1)
		{
			playerRank2.<IsNew>k__BackingField = false;
		}
		object sprite = ranksData.GetFor(playerRank2);
		image.sprite = (Sprite)sprite;
	}
}
