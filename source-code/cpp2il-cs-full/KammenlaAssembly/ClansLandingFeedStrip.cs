using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;

public abstract class ClansLandingFeedStrip : ListViewItem<ClansLandingFeedDataHolder, int>
{
	public ClanFeedModel Model
	{
		get
		{
			//IL_0024: Expected O, but got I
			//IL_0012: Expected O, but got I
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClansLandingFeedStrip)+40]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClansLandingFeedStrip)+40]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+18]");
				return (ClanFeedModel)0;
			}
			return null;
		}
	}

	public override void Setup(ClansLandingFeedDataHolder datum, bool firstTime)
	{
		//IL_0018: Expected I, but got O
		//IL_0028: Expected O, but got I
		//IL_0038: Expected O, but got I
		bool firstTime2 = default(bool);
		while (true)
		{
			((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
			ClanFeedModel <Model>k__BackingField = datum.<Model>k__BackingField;
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<ClansLandingFeedStrip>)+318]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v3 (Il2CppClass<ClansLandingFeedStrip>)+320]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v59 @ X3_v2 (should have been resolved before IL gen)");
		}
	}

	public virtual void Initialize(ClanFeedModel model)
	{
	}

	protected ClansLandingFeedStrip()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
