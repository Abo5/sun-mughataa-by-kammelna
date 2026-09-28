using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;

public class ClanEventStrip_LeaderboardRank : ClanEventStrip
{
	public override void Initialize(ClanFeedModel model)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_00f4: Expected O, but got I4
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_012b: Expected O, but got I
		ClanFeedData clanFeedData = model.Data;
		if (model.Data == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 120;
		object obj2 = obj;
		nint num = (nint)clanFeedData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X9_v3 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v7+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X9_v3 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v7+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X9_v5-8]");
			if (0 == (nint)obj2)
			{
				InitializeAvatar(model);
				object obj6 = 153100288 + 1024;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format = "{0} color encoding is currently unsupported for outputting to HDR." + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v3 (Kammelna.Server.Models.Clans.ClanFeedData)+30]");
				object arg = default(object);
				string text = string.Format((string)format, 0, arg);
				base.text.text = text;
			}
		}
	}

	public ClanEventStrip_LeaderboardRank()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
