using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.AdaptivePerformance;

[Serializable]
public class DisplayPreset
{
	public string Name;

	public int LevelCount;

	private List<TierEntry> _tiers;

	public IReadOnlyList<TierEntry> Tiers => _tiers;

	public TierEntry GetTier(int activeLevel)
	{
		int num = activeLevel - 1;
		if (activeLevel >= 1)
		{
			List<object> tiers = (List<object>)(object)_tiers;
			if (_tiers != null && num < tiers._size)
			{
				return (TierEntry)((List<object>)(object)_tiers).get_Item(num);
			}
		}
		return null;
	}

	public DisplayPreset()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 3928;
		LevelCount = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 32;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}
}
