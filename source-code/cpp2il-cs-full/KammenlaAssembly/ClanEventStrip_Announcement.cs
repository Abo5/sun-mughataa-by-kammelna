using System.Data.SqlTypes;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using TMPro;
using UnityEngine;

public class ClanEventStrip_Announcement : ClanEventStrip
{
	private TextMeshProUGUI TitleText;

	public override void Initialize(ClanFeedModel model)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_0100: Expected O, but got I
		//IL_011c: Expected O, but got I
		ClanFeedData clanFeedData = model.Data;
		if (model.Data == null)
		{
			return;
		}
		object obj = typeof(SqlSingle[]) + 4072;
		object obj2 = obj;
		nint num = (nint)clanFeedData;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X9_v2 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v6+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X9_v2 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v6+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X9_v4-8]");
			if (0 == (nint)obj2)
			{
				InitializeAvatar(model.UserId);
				TextMeshProUGUI titleText = TitleText;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v2 (Kammelna.Server.Models.Clans.ClanFeedData)+18]");
				TextMeshProExtensions.FixArabic(titleText, (string)0);
				TextMeshProUGUI textMesh = text;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v2 (Kammelna.Server.Models.Clans.ClanFeedData)+20]");
				TextMeshProExtensions.FixArabic(textMesh, (string)0);
			}
		}
	}

	private void InitializeAvatar(long? userId)
	{
		//IL_00b3: Expected O, but got I
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00e8: Expected O, but got I4
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0026: Expected I4, but got O
		nint num = default(nint);
		bool flag = num < 0;
		bool flag2 = num == 0;
		object obj = num ^ num;
		object obj2 = num & obj;
		bool flag3 = (nint)obj2 < 0;
		bool flag4 = flag == flag3;
		object obj3 = !flag2;
		object obj4 = flag4 & obj3;
		GameObject gameObject = avatar.gameObject;
		bool flag5 = (byte)((object?)userId & obj4) != 0;
		gameObject.SetActive(flag5);
		if (flag5)
		{
			long? num2 = default(long?);
			long value = num2.Value;
			long num3 = default(long);
			string dbId = num3.ToString();
			avatar.InitializeFriendWithDbId(dbId);
		}
		else
		{
			avatar.Clear();
		}
	}

	public ClanEventStrip_Announcement()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
