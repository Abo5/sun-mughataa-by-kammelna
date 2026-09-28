using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using ListView;

public class QueueTeam : IGridViewItemData<int>, IListViewItemData<int>
{
	public QueuePlayer player1;

	public QueuePlayer player2;

	private int <index>k__BackingField;

	public bool IsTeam
	{
		get
		{
			//IL_0065: Expected O, but got I4
			//IL_0099: Expected O, but got I4
			QueuePlayer queuePlayer = player1;
			if (player1 != null)
			{
				QueuePlayer queuePlayer2 = player2;
				if (player2 != null)
				{
					object obj = queuePlayer.<team>k__BackingField + 1;
					if (obj != null)
					{
						object obj2 = queuePlayer.<team>k__BackingField - queuePlayer2.<team>k__BackingField;
						return obj2 == null;
					}
				}
			}
			return false;
		}
	}

	public bool IsSelected
	{
		get
		{
			//IL_0065: Expected O, but got I4
			//IL_00e3: Expected O, but got I4
			QueuePlayer queuePlayer = player1;
			if (player1 != null)
			{
				QueuePlayer queuePlayer2 = player2;
				if (player2 != null)
				{
					object obj = queuePlayer.<team>k__BackingField + 1;
					if (obj != null && queuePlayer.<team>k__BackingField == queuePlayer2.<team>k__BackingField && queuePlayer.<status>k__BackingField == QueuePlayer.Status.Highlight)
					{
						object obj2 = queuePlayer2.<status>k__BackingField - 1;
						return obj2 == null;
					}
				}
			}
			return false;
		}
	}

	public int index
	{
		get
		{
			return <index>k__BackingField;
		}
		set
		{
			<index>k__BackingField = value;
		}
	}

	public string template => "Unsupported map type" + 3536;

	public int columns => 1;

	public QueueTeam(QueuePlayer player1, QueuePlayer player2, int i)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		<index>k__BackingField = i;
		object obj = this + 16;
		obj = player1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 24;
		obj2 = player2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public QueueTeam(IEnumerable<QueuePlayer> players, int i)
	{
		//IL_0012: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		<index>k__BackingField = i;
		List<object> list = Enumerable.ToList((IEnumerable<object>)players);
		object obj = (nint)0 + (nint)2984;
		object obj2 = list.get_Item(0);
		object obj3 = this + 16;
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (list._size >= 2)
		{
			object obj4 = list.get_Item(1);
			object obj5 = this + 24;
			obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}
}
