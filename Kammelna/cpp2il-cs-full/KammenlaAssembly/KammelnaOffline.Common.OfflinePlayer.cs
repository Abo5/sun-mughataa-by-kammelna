using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine.AdaptivePerformance;

namespace KammelnaOffline.Common;

public class OfflinePlayer
{
	public int PlayerIndex;

	private List<Card> <Cards>k__BackingField;

	private List<Card> <AllCards>k__BackingField;

	private List<Card> <PlayedCards>k__BackingField;

	public List<Card> Cards
	{
		get
		{
			return <Cards>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<Card> AllCards
	{
		get
		{
			return <AllCards>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public List<Card> PlayedCards
	{
		get
		{
			return <PlayedCards>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public OfflinePlayer(int index)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		object obj = typeof(List<AdaptivePerformanceScaler>) + 416;
		base..ctor();
		PlayerIndex = index;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj2 = this + 40;
		obj2 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj3 = this + 32;
		obj3 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
