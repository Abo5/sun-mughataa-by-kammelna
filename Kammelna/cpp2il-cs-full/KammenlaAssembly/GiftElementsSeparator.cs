using ListView;

public class GiftElementsSeparator : ListViewItem<GiftsHolder, int>
{
	public GiftElementsSeparator()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
