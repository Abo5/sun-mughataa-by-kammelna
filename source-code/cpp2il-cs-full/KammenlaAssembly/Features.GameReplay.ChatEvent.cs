using Cpp2ILInjected;

namespace Features.GameReplay;

public class ChatEvent : ReplayEvent
{
	private string <UserId>k__BackingField;

	private string <ChatMessage>k__BackingField;

	public string UserId
	{
		get
		{
			return <UserId>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public string ChatMessage
	{
		get
		{
			return <ChatMessage>k__BackingField;
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

	public ChatEvent()
	{
	}

	public ChatEvent(int playerIndex, string userId, string chatMessage)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		base.<PlayerIndex>k__BackingField = playerIndex;
		base.<ReplayEventType>k__BackingField = ReplayEventsTypes.Chat;
		object obj = this + 24;
		obj = userId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 32;
		obj2 = chatMessage;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
