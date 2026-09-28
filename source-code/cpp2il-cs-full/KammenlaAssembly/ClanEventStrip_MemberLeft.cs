using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using Unity.Properties;

public class ClanEventStrip_MemberLeft : ClanEventStrip
{
	private const string LEFT_KEY = "clan_member_left";

	public override void Initialize(ClanFeedModel model)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_011f: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_0163: Expected I, but got O
		//IL_0173: Expected O, but got I
		//IL_019c: Expected O, but got I
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01ef: Expected O, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		ClanFeedModel clanFeedModel = default(ClanFeedModel);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (clanFeedModel != null)
		{
			ClanFeedData clanFeedData = clanFeedModel.Data;
			if (clanFeedModel.Data == null)
			{
				return;
			}
			object obj = typeof(MemberAchievementClanFeedData) + 72;
			object obj2 = obj;
			nint num = (nint)clanFeedData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X9_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v9+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X9_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v9+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X9_v7-8]");
			if (0 != (nint)obj2)
			{
				return;
			}
			InitializeAvatar(clanFeedModel);
			object obj6 = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object[] array = default(object[]);
			bool flag2 = array == null;
			clanFeedModel = (ClanFeedModel)1;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v5 (Kammelna.Server.Models.Clans.ClanFeedData)+30]");
				bool flag3 = (nint)0 == 0;
				ClanFeedModel clanFeedModel2 = (ClanFeedModel)1;
				if (!flag3)
				{
					nint num4 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
					clanFeedModel2 = (ClanFeedModel)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
					clanFeedModel = (ClanFeedModel)0;
					if (flag4)
					{
						goto IL_023d;
					}
				}
				bool flag5 = array.Length == 0;
				clanFeedModel = clanFeedModel2;
				if (!flag5)
				{
					object obj7 = array + 32;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X21_v5 (Kammelna.Server.Models.Clans.ClanFeedData)+30]");
					obj7 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object obj8 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3872;
					TextMeshProExtensions.Localize(text, (string)obj8, array);
					return;
				}
				goto IL_022f;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_022f;
		IL_023d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_022f:
		ex = new IndexOutOfRangeException();
		goto IL_023d;
	}

	public ClanEventStrip_MemberLeft()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
