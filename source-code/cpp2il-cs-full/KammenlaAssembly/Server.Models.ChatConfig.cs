namespace Server.Models;

public class ChatConfig
{
	private bool <IsPublicChatSubsLocked>k__BackingField = true;

	private bool <IsChatBotEnabled>k__BackingField;

	public bool IsPublicChatSubsLocked
	{
		get
		{
			return <IsPublicChatSubsLocked>k__BackingField;
		}
		set
		{
			<IsPublicChatSubsLocked>k__BackingField = value;
		}
	}

	public bool IsChatBotEnabled
	{
		get
		{
			return <IsChatBotEnabled>k__BackingField;
		}
		set
		{
			<IsChatBotEnabled>k__BackingField = value;
		}
	}
}
