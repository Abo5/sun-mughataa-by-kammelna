using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using Unity.Properties;

public class ClanEventStrip_PrivateTournamentResult : ClanEventStrip_LiveActivityResult
{
	private const string RESULT_KEY = "clan_feed_private_tournament_result";

	protected override void Populate(LiveActivityResultClanFeedData data)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_024c: Expected O, but got I4
		//IL_0060: Expected O, but got I4
		//IL_0076: Expected I, but got O
		//IL_0086: Expected O, but got I
		//IL_00af: Expected O, but got I
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0191: Expected O, but got I8
		//IL_0136: Expected I, but got O
		//IL_0146: Expected O, but got I
		//IL_016f: Expected O, but got I
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string text3;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (data != null)
		{
			string text = ClanEventStrip_LiveActivityResult.JoinNames(data.<WinnerUserNames>k__BackingField);
			object[] array = default(object[]);
			if (array != null)
			{
				bool flag = text == null;
				string text2 = (string)2;
				if (!flag)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					text2 = (string)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag2 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v10 (Il2CppClass<System.Object[]>)+40]");
					text3 = (string)0;
					if (flag2)
					{
						goto IL_025f;
					}
				}
				bool flag3 = array.Length == 0;
				text3 = text2;
				if (!flag3)
				{
					object obj2 = array + 32;
					obj2 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag4 = data.<Title>k__BackingField == null;
					string text4 = text;
					if (!flag4)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
						text4 = (string)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag5 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
						text3 = (string)0;
						if (flag5)
						{
							goto IL_025f;
						}
					}
					object obj3 = array.Length & 0xFFFFFFFEL;
					bool flag6 = obj3 == null;
					text3 = text4;
					if (!flag6)
					{
						object obj4 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3592;
						object obj5 = array + 40;
						obj5 = data.<Title>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						TextMeshProExtensions.Localize(base.text, (string)obj4, array);
						ClanEventStrip_LiveActivityResult.BindAvatar(avatar, data.<WinnerUserIds>k__BackingField, 0);
						ClanEventStrip_LiveActivityResult.BindAvatar(base._avatarInitializer2, data.<WinnerUserIds>k__BackingField, 1);
						return;
					}
				}
				goto IL_0251;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		text3 = (string)2;
		goto IL_0251;
		IL_025f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0251:
		ex = new IndexOutOfRangeException();
		goto IL_025f;
	}

	public ClanEventStrip_PrivateTournamentResult()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
