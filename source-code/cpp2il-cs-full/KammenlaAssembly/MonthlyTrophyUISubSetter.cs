using System;

[Serializable]
public abstract class MonthlyTrophyUISubSetter<TAsset> : IMonthlyTrophyUISubSetter
{
	private const string RankerId = "monthly_ranker";

	protected TAsset platinum;

	protected TAsset gold;

	protected TAsset silver;

	protected TAsset bronze;

	protected TAsset ranker;

	public abstract void Populate(UserAchievementModel trophy);

	protected TAsset GetTrophyAsset(UserAchievementModel trophy)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I4
		if (trophy != null)
		{
			object obj = "m_StencilDeferredPS" + 2344;
			TAsset val = (TAsset)(trophy.<gameAchievementId>k__BackingField == (string)obj);
			if (val == null)
			{
				if (trophy.<levelId>k__BackingField <= 2)
				{
					if (trophy.<levelId>k__BackingField != 1 && trophy.<levelId>k__BackingField != 2)
					{
					}
				}
				else if (trophy.<levelId>k__BackingField != 3 && trophy.<levelId>k__BackingField != 4)
				{
				}
			}
			return val;
		}
		return (TAsset)new NullReferenceException();
	}
}
