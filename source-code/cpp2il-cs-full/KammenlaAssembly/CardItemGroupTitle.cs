using Cpp2ILInjected;
using ListView;
using TMPro;

public class CardItemGroupTitle : ListViewItem<StoreDataHolder, int>
{
	private TextMeshProUGUI title;

	public override void Setup(StoreDataHolder datum, bool firstTime)
	{
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		TextMeshProExtensions.FixArabic(title, datum.<titleText>k__BackingField);
	}

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1184;
		object obj2 = this + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
	}

	public CardItemGroupTitle()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
