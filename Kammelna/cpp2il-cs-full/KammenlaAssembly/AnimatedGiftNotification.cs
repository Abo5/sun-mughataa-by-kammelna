using System.Threading;
using Cpp2ILInjected;
using Sfs2X.Entities.Data;

public class AnimatedGiftNotification
{
	private const string ItemIdParam = "item_id";

	private const string SenderParam = "sender";

	private const string TargetParam = "target";

	private int <ItemId>k__BackingField;

	private int <SenderId>k__BackingField;

	private int <TargetId>k__BackingField;

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

	public int TargetId
	{
		get
		{
			return <TargetId>k__BackingField;
		}
		private set
		{
			<TargetId>k__BackingField = value;
		}
	}

	public AnimatedGiftNotification(int itemId, int senderId, int targetId)
	{
		<ItemId>k__BackingField = itemId;
		<SenderId>k__BackingField = senderId;
		<TargetId>k__BackingField = targetId;
	}

	public AnimatedGiftNotification(ISFSObject sfsObject)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_007d: Expected I4, but got I8
		//IL_00a1: Expected I4, but got I8
		//IL_0052: Expected I4, but got I8
		object varName = "https://www.kammelna.com/Home/Terms" + 3848;
		object varName2 = "rightCtrl" + 1936;
		object varName3 = "startPosition" + 2328;
		base..ctor();
		int num = SFSExtensions.Get(sfsObject, (string)varName, -1);
		<ItemId>k__BackingField = num;
		int num2 = SFSExtensions.Get(sfsObject, (string)varName2, -1);
		<SenderId>k__BackingField = num2;
		<TargetId>k__BackingField = SFSExtensions.Get(sfsObject, (string)varName3, -1);
	}

	public ISFSObject ToSfsObject()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "https://www.kammelna.com/Home/Terms" + 3848;
		object key2 = "startPosition" + 2328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, <ItemId>k__BackingField);
		SFSExtensions.Put(sFSObject, (string)key2, <TargetId>k__BackingField);
		return sFSObject;
	}
}
