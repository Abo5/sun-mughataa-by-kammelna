using ListView;

public abstract class ChatMessageStrip : ListViewItem<ChatMessageDataHolder, int>
{
	public abstract float GetHeightForText(string text);

	protected ChatMessageStrip()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
