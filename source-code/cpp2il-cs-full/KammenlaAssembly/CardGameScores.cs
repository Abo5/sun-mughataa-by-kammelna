using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;
using UnityEngine.AdaptivePerformance;

public abstract class CardGameScores : ICardGameScores, IGameScores
{
	private readonly List<ICardGameRoundScore> <RoundsScores>k__BackingField;

	public ICardGameRoundScore LastCardGameRoundScore
	{
		get
		{
			if (<RoundsScores>k__BackingField != null)
			{
				return (ICardGameRoundScore)Enumerable.Last((IEnumerable<object>)<RoundsScores>k__BackingField);
			}
			return (ICardGameRoundScore)<RoundsScores>k__BackingField;
		}
	}

	public List<ICardGameRoundScore> RoundsScores => <RoundsScores>k__BackingField;

	protected CardGameScores()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1416;
		base..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 16;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public virtual void Reset()
	{
		List<ICardGameRoundScore> list = <RoundsScores>k__BackingField;
		int version = list._version + 1;
		list._size = 0;
		list._version = version;
		if (list._size >= 1)
		{
			Array.Clear(list._items, 0, list._size);
		}
	}

	public abstract void SaveRoundScore(ISFSObject data);
}
