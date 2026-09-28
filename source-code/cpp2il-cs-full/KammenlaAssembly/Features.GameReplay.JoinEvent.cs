using Cpp2ILInjected;

namespace Features.GameReplay;

public class JoinEvent : ReplayEvent
{
	private int <DbId>k__BackingField;

	private string <Name>k__BackingField;

	private int <RankPoints>k__BackingField;

	private bool <RankIsNew>k__BackingField;

	private bool <Subscribed>k__BackingField;

	private bool <Verified>k__BackingField;

	private int <ActiveCardsBack>k__BackingField;

	public int DbId
	{
		get
		{
			return <DbId>k__BackingField;
		}
		private set
		{
			<DbId>k__BackingField = value;
		}
	}

	public string Name
	{
		get
		{
			return <Name>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public int RankPoints
	{
		get
		{
			return <RankPoints>k__BackingField;
		}
		private set
		{
			<RankPoints>k__BackingField = value;
		}
	}

	public bool RankIsNew
	{
		get
		{
			return <RankIsNew>k__BackingField;
		}
		private set
		{
			<RankIsNew>k__BackingField = value;
		}
	}

	public bool Subscribed
	{
		get
		{
			return <Subscribed>k__BackingField;
		}
		private set
		{
			<Subscribed>k__BackingField = value;
		}
	}

	public bool Verified
	{
		get
		{
			return <Verified>k__BackingField;
		}
		private set
		{
			<Verified>k__BackingField = value;
		}
	}

	public int ActiveCardsBack
	{
		get
		{
			return <ActiveCardsBack>k__BackingField;
		}
		private set
		{
			<ActiveCardsBack>k__BackingField = value;
		}
	}

	public JoinEvent()
	{
	}

	public unsafe JoinEvent(int playerIndex, int dbId, string name, int rankPoints, bool rankIsNew, bool subscribed, bool verified, int activeCardsBack)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj2 = default(object);
		object obj = (object)(&obj2);
		((object)this)..ctor();
		object obj3 = this + 32;
		obj3 = name;
		_ = 11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		_ = 0;
	}
}
