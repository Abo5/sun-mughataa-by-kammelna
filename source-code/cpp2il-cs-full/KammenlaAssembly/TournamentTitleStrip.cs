using Cpp2ILInjected;
using ListView;
using TMPro;

public class TournamentTitleStrip : ListViewItem<TournamentDataHolder, int>
{
	private TextMeshProUGUI title;

	private TextMeshProUGUI counter;

	public override void Setup(TournamentDataHolder datum, bool firstTime)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0021: Expected O, but got I
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		object obj = "&action=sign-up" + 2048;
		object obj2 = (nint)0 + (nint)3456;
		TextMeshProExtensions.Localize(title, datum.<titleText>k__BackingField);
		int num = default(int);
		string text = num.ToString();
		string text2 = (string)obj + text + (string)obj2;
		counter.SetText(text2);
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

	public TournamentTitleStrip()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
