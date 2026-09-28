using Cpp2ILInjected;

namespace Features.GameReplay;

public class GiftEvent : ReplayEvent
{
	private int <GiftId>k__BackingField;

	private long <SenderId>k__BackingField;

	private long[] <Recipients>k__BackingField;

	public int GiftId
	{
		get
		{
			return <GiftId>k__BackingField;
		}
		private set
		{
			<GiftId>k__BackingField = value;
		}
	}

	public long SenderId
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

	public long[] Recipients
	{
		get
		{
			return <Recipients>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public GiftEvent()
	{
	}

	public GiftEvent(long senderId, int giftId, long[] recipients)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 40;
		obj = recipients;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253548]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
