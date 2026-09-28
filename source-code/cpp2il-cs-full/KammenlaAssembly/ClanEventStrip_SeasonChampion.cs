using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using TMPro;

public class ClanEventStrip_SeasonChampion : ClanEventStrip
{
	public override void Initialize(ClanFeedModel model)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0108: Expected I, but got O
		//IL_0118: Expected O, but got I
		//IL_0128: Expected O, but got I
		ClanFeedData clanFeedData = model.Data;
		if (model.Data == null)
		{
			return;
		}
		object obj = typeof(RegisteredWaitHandle) + 3304;
		object obj2 = obj;
		nint num = (nint)clanFeedData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X9_v4 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X9_v4 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v7+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X9_v6-8]");
			if (0 == (nint)obj2)
			{
				TextMeshProUGUI textMeshProUGUI = text;
				object obj6 = "The '{0}' attribute is not declared." + 2000;
				object obj7 = obj6;
				nint num4 = (nint)textMeshProUGUI;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v10 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v10 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v129 @ X3_v1 (should have been resolved before IL gen)");
				/*Error: End of method reached without returning.*/;
			}
		}
	}

	public ClanEventStrip_SeasonChampion()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
