using System;
using Cpp2ILInjected;
using ListView;

public class ChatMessageDataHolder : IListViewItemData<int>
{
	private readonly int <index>k__BackingField;

	private readonly ChatMessageData <message>k__BackingField;

	private readonly ChatMessagesListView <listView>k__BackingField;

	private bool <IsFirst>k__BackingField;

	private bool <IsLast>k__BackingField;

	private bool <IsHighlighted>k__BackingField;

	public int index => <index>k__BackingField;

	public ChatMessageData message => <message>k__BackingField;

	public ChatMessagesListView listView => <listView>k__BackingField;

	public bool IsFirst
	{
		get
		{
			return <IsFirst>k__BackingField;
		}
		set
		{
			<IsFirst>k__BackingField = value;
		}
	}

	public bool IsLast
	{
		get
		{
			return <IsLast>k__BackingField;
		}
		set
		{
			<IsLast>k__BackingField = value;
		}
	}

	public bool IsHighlighted
	{
		get
		{
			return <IsHighlighted>k__BackingField;
		}
		set
		{
			<IsHighlighted>k__BackingField = value;
		}
	}

	public string ChallengeTemplate => "Cannot populate JSON object onto type '{0}'." + 2040;

	public string RoomTemplate => "Read object reference Id '{0}' for {1}." + 3360;

	public string TournamentTemplate => "ThisIsFakeReceiptData" + 1240;

	public string template => GetMatchingTemplate();

	public ChatMessageDataHolder(int index, ChatMessageData message, ChatMessagesListView listView)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		<index>k__BackingField = index;
		object obj = this + 24;
		obj = message;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 32;
		obj2 = listView;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private string GetMatchingTemplate()
	{
		//IL_0030: Expected O, but got I4
		//IL_0046: Expected O, but got I
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01d8: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_00b8: Expected O, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02e3: Expected O, but got I4
		//IL_012e: Expected O, but got I4
		//IL_0144: Expected O, but got I
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_0362: Expected O, but got I4
		//IL_0384: Expected O, but got I4
		ChatMessageData chatMessageData = <message>k__BackingField;
		if (<message>k__BackingField != null)
		{
			if (chatMessageData.<TournamentRoom>k__BackingField != null)
			{
				object obj = 152989696;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7623]");
				object obj2 = (nint)0 & (nint)1;
				if (obj2 != null)
				{
					return "ThisIsFakeReceiptData" + 1240;
				}
				object result = "ThisIsFakeReceiptData" + 1240;
				_ = 1;
				return (string)result;
			}
			if (chatMessageData.<RoomData>k__BackingField != null)
			{
				object obj3 = 152989696;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7622]");
				object obj4 = (nint)0 & (nint)1;
				if (obj4 != null)
				{
					return "Read object reference Id '{0}' for {1}." + 3360;
				}
				object result2 = "Read object reference Id '{0}' for {1}." + 3360;
				_ = 1;
				return (string)result2;
			}
			if (chatMessageData.<ChallengeData>k__BackingField != null)
			{
				object obj5 = 152989696;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7621]");
				object obj6 = (nint)0 & (nint)1;
				if (obj6 != null)
				{
					return "Cannot populate JSON object onto type '{0}'." + 2040;
				}
				object result3 = "Cannot populate JSON object onto type '{0}'." + 2040;
				_ = 1;
				return (string)result3;
			}
			bool isMyMessage = <message>k__BackingField.IsMyMessage;
			object result4 = "October" + 1480;
			object obj7 = "October" + 1472;
			bool flag = !<IsLast>k__BackingField;
			object obj8 = !flag;
			object obj9 = ~obj8;
			if (obj9 == null)
			{
				result4 = obj7;
			}
			object obj10 = "October" + 1496;
			object obj11 = "October" + 1488;
			object obj12 = !flag;
			object obj13 = ~obj12;
			if (obj13 == null)
			{
				obj10 = obj11;
			}
			object obj14 = "Material with texture name \"" + 3168;
			object obj15 = "Material with texture name \"" + 3160;
			if (<IsFirst>k__BackingField)
			{
				result4 = obj10;
			}
			bool flag2 = !<IsLast>k__BackingField;
			object obj16 = "Material with texture name \"" + 3184;
			object obj17 = "Material with texture name \"" + 3176;
			object obj18 = !flag2;
			object obj19 = ~obj18;
			if (obj19 == null)
			{
				obj14 = obj15;
			}
			object obj20 = !flag2;
			object obj21 = ~obj20;
			if (obj21 == null)
			{
				obj16 = obj17;
			}
			object result5 = (<IsFirst>k__BackingField ? obj16 : obj14);
			if (!isMyMessage)
			{
				return (string)result4;
			}
			return (string)result5;
		}
		return (string)(object)new NullReferenceException();
	}
}
