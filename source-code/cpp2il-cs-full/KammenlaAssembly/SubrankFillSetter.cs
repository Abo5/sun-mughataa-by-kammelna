using System;
using UnityEngine.UI;

[Serializable]
public class SubrankFillSetter : IRankSubSetter
{
	private Image Mask;

	public string Label => "SetRoomVariables request error" + 3960;

	public void Set(PlayerRank playerRank)
	{
		float fillAmount = (float)playerRank.<SubRanksCount>k__BackingField * 0.25f;
		Mask.fillAmount = fillAmount;
	}
}
