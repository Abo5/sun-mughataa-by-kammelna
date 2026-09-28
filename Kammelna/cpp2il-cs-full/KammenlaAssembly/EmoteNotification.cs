using Sfs2X.Entities.Data;
using Util;

public class EmoteNotification
{
	private const string ItemIdParam = "item_id";

	private const string SenderParam = "sender";

	private const string IsFromServerParam = "ifs";

	private int <ItemId>k__BackingField;

	private int <SenderId>k__BackingField;

	private bool <IsFromServer>k__BackingField;

	public int ItemId
	{
		get
		{
			return <ItemId>k__BackingField;
		}
		private set
		{
			<ItemId>k__BackingField = value;
		}
	}

	public int SenderId
	{
		get
		{
			return <SenderId>k__BackingField;
		}
		private set
		{
			<SenderId>k__BackingField = value;
		}
	}

	public bool IsFromServer
	{
		get
		{
			return <IsFromServer>k__BackingField;
		}
		private set
		{
			<IsFromServer>k__BackingField = value;
		}
	}

	public EmoteNotification(int itemId, int senderId)
	{
		<ItemId>k__BackingField = itemId;
		<SenderId>k__BackingField = senderId;
	}

	public EmoteNotification(ISFSObject sfsObject)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0079: Expected I4, but got I8
		//IL_009d: Expected I4, but got I8
		object varName = "https://www.kammelna.com/Home/Terms" + 3848;
		object varName2 = "rightCtrl" + 1936;
		object varName3 = "https://www.kammelna.com/Home/Terms" + 536;
		base..ctor();
		int num = SFSExtensions.Get(sfsObject, (string)varName, -1);
		<ItemId>k__BackingField = num;
		int num2 = SFSExtensions.Get(sfsObject, (string)varName2, -1);
		<SenderId>k__BackingField = num2;
		<IsFromServer>k__BackingField = SFSExtensions.Get(sfsObject, (string)varName3, defaultValue: false);
	}

	public ISFSObject ToSfsObject()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object key = "https://www.kammelna.com/Home/Terms" + 3848;
		return SfsObjectUtil.FromOneValue((string)key, <ItemId>k__BackingField);
	}
}
