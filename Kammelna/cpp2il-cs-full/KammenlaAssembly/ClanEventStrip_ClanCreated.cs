using System;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using TMPro;
using Unity.Properties;

public class ClanEventStrip_ClanCreated : ClanEventStrip
{
	private const string CLAN_CREATED_KEY = "clan_feed_clan_created";

	private ClanEmblemLoader clanLogo;

	private TextMeshProUGUI summary;

	private DateTimeText timeAgo;

	public override void Initialize(ClanFeedModel model)
	{
		//IL_0532: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_0141: Expected O, but got I4
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0225: Expected O, but got I4
		//IL_0253: Expected O, but got I4
		//IL_0269: Expected I, but got O
		//IL_0279: Expected O, but got I
		//IL_02aa: Expected O, but got I
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_0305: Expected O, but got I
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_034a: Expected O, but got I4
		//IL_03cc: Expected I, but got O
		//IL_03dc: Expected O, but got I
		//IL_0415: Expected O, but got I
		//IL_0367: Expected O, but got I4
		//IL_0377: Expected O, but got I
		//IL_0387: Expected O, but got I
		//IL_03ae: Expected O, but got I
		//IL_0437: Expected O, but got I8
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		bool flag = model == null;
		IntPtr intPtr = default(IntPtr);
		object[] array = (object[])(nint)intPtr;
		string text = (string)(object)model;
		object[] array2;
		if (!flag)
		{
			ClanFeedData clanFeedData = model.Data;
			if (model.Data == null)
			{
				return;
			}
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 1160;
			object obj2 = obj;
			nint num = (nint)clanFeedData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X9_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v9+130]");
			bool flag2 = num2 < 0;
			object obj3 = !flag2;
			object obj4 = ~obj3;
			if (obj4 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X9_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v9+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X9_v7-8]");
			if (0 != (nint)obj2)
			{
				return;
			}
			object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				bool flag3 = timeAgo != null;
				bool flag4 = !flag3;
				object obj8 = !flag4;
				array = null;
				text = null;
				if (obj8 != null)
				{
					goto IL_01aa;
				}
				array2 = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag5 = timeAgo != null;
				bool flag6 = !flag5;
				array = null;
				text = null;
				array2 = null;
				if (!flag6)
				{
					goto IL_01aa;
				}
			}
			goto IL_01e7;
		}
		goto IL_04e9;
		IL_01aa:
		if ((object)timeAgo != null)
		{
			timeAgo.SetDate(model.DateCreated);
			array2 = null;
			goto IL_01e7;
		}
		goto IL_04e9;
		IL_0505:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_04e9:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04f7;
		IL_01e7:
		object obj9 = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array3 = default(object[]);
		bool flag7 = array3 == null;
		array = array2;
		text = (string)2;
		if (flag7)
		{
			goto IL_04e9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X23_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+20]");
		bool flag8 = (nint)0 == 0;
		string text2 = (string)2;
		IndexOutOfRangeException ex2 = default(IndexOutOfRangeException);
		if (!flag8)
		{
			nint num4 = (nint)array3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
			text2 = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag9 = ex2 == null;
			array = array2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
			text = (string)0;
			if (flag9)
			{
				goto IL_0505;
			}
		}
		bool flag10 = array3.Length == 0;
		array = array2;
		text = text2;
		if (flag10)
		{
			goto IL_04f7;
		}
		object obj10 = array3 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X23_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+20]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text3 = model.ClanName;
		object obj11 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3544;
		bool flag11 = model.ClanName == null;
		object obj12 = !flag11;
		string text4;
		string text5;
		if (obj12 == null)
		{
			object obj13 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v24+90]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X8_v25+B8]");
			object obj15 = 0;
			text3 = (string)obj15;
			bool flag12 = obj15 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X23_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+20]");
			text4 = (string)0;
			text5 = (string)obj15;
			if (flag12)
			{
				goto IL_0423;
			}
		}
		nint num5 = (nint)array3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
		text4 = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		bool flag13 = ex2 == null;
		text5 = text3;
		array = array2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v22 (Il2CppClass<System.Object[]>)+40]");
		text = (string)0;
		if (!flag13)
		{
			goto IL_0423;
		}
		goto IL_0505;
		IL_0423:
		object obj16 = array3.Length & 0xFFFFFFFEL;
		bool flag14 = obj16 == null;
		array = array2;
		text = text4;
		if (!flag14)
		{
			object obj17 = array3 + 40;
			obj17 = text5;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			TextMeshProExtensions.Localize(summary, (string)obj11, array3);
			bool flag15 = (object)clanLogo == null;
			array = array3;
			text = (string)obj11;
			if (!flag15)
			{
				clanLogo.Load(model.ClanId, model.Emblem);
				return;
			}
			goto IL_04e9;
		}
		goto IL_04f7;
		IL_04f7:
		ex2 = new IndexOutOfRangeException();
		goto IL_0505;
	}

	public ClanEventStrip_ClanCreated()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
