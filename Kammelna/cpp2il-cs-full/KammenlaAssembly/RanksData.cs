using System;
using UnityEngine;

public class RanksData<T> : ScriptableObject
{
	private T rankNew;

	private T rank0;

	private T rank1;

	private T rank2;

	private T rank3;

	private T rank4;

	private T rank5;

	private T rank6;

	public T GetFor(PlayerRank rank)
	{
		//IL_0063: Expected O, but got I4
		//IL_0076: Expected O, but got I4
		//IL_0090: Expected O, but got I4
		if (rank != null)
		{
			if (!rank.<IsNew>k__BackingField)
			{
				bool flag = rank.<Rank>k__BackingField < PlayerRank.Ranks.Master;
				object obj = !flag;
				object obj2 = rank.<Rank>k__BackingField - 6;
				bool flag2 = obj2 == null;
				object obj3 = !flag2;
				object obj4 = obj & obj3;
				if (obj4 == null)
				{
					goto IL_00a6;
				}
			}
			return (T)this;
		}
		goto IL_00a6;
		IL_00a6:
		return (T)new NullReferenceException();
	}

	public T GetFor(PlayerRank.Ranks rank, bool isNew = false)
	{
		//IL_003c: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0064: Expected O, but got I4
		if (!isNew)
		{
			bool flag = rank < PlayerRank.Ranks.Master;
			object obj = !flag;
			object obj2 = rank - 6;
			bool flag2 = obj2 == null;
			object obj3 = !flag2;
			object obj4 = obj & obj3;
			if (obj4 != null)
			{
			}
		}
		return (T)this;
	}

	private T GetAsset(PlayerRank.Ranks rank, bool isNew)
	{
		//IL_003c: Expected O, but got I4
		//IL_004a: Expected O, but got I4
		//IL_0064: Expected O, but got I4
		if (!isNew)
		{
			bool flag = rank < PlayerRank.Ranks.Master;
			object obj = !flag;
			object obj2 = rank - 6;
			bool flag2 = obj2 == null;
			object obj3 = !flag2;
			object obj4 = obj & obj3;
			if (obj4 != null)
			{
			}
		}
		return (T)this;
	}
}
