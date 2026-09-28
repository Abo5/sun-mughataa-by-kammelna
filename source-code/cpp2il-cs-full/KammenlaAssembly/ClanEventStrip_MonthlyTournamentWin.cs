using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using TMPro;

public class ClanEventStrip_MonthlyTournamentWin : ClanEventStrip
{
	public override void Initialize(ClanFeedModel model)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_0112: Expected O, but got I
		//IL_0123: Expected I, but got O
		//IL_0133: Expected O, but got I
		//IL_0143: Expected O, but got I
		ClanFeedData clanFeedData = model.Data;
		if (model.Data == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 152;
		object obj2 = obj;
		nint num = (nint)clanFeedData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X9_v3 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v7+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X9_v3 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v7+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X9_v5-8]");
			if (0 == (nint)obj2)
			{
				InitializeAvatar(model);
				TextMeshProUGUI textMeshProUGUI = base.text;
				object obj6 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2264;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v3 (Kammelna.Server.Models.Clans.ClanFeedData)+30]");
				string text = (string)0 + (string)obj6;
				nint num4 = (nint)textMeshProUGUI;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v10 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v10 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v135 @ X3_v1 (should have been resolved before IL gen)");
				/*Error: End of method reached without returning.*/;
			}
		}
	}

	public ClanEventStrip_MonthlyTournamentWin()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
