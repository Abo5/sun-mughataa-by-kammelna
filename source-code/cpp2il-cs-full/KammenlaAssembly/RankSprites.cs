using UnityEngine;

public class RankSprites : RanksData<Sprite>
{
	public bool HasSubRanks;

	public bool CardStyle;

	public RankSprites()
	{
		((RanksData<object>)(object)this)..ctor();
	}
}
