using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;

public class ClanEventStrip_MemberRankUp : ClanEventStrip
{
	private const string RANK_UP_KEY = "clan_member_rank_up";

	private RankSetter rankSetter;

	public override void Initialize(ClanFeedModel model)
	{
		//IL_043c: Expected I4, but got O
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0139: Expected O, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_01ab: Expected O, but got I4
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_048d: Expected O, but got I4
		//IL_0271: Expected O, but got I4
		//IL_01fe: Expected I, but got O
		//IL_0230: Expected O, but got I4
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02ae: Expected O, but got I
		//IL_035a: Expected O, but got I8
		//IL_0372: Expected O, but got I4
		//IL_02ed: Expected I, but got O
		//IL_031f: Expected O, but got I4
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		bool flag = model == null;
		IntPtr intPtr = default(IntPtr);
		bool flag2 = (byte)(nint)intPtr != 0;
		PlayerRank.Ranks ranks = (PlayerRank.Ranks)model;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			ClanFeedData clanFeedData = model.Data;
			if (model.Data == null)
			{
				return;
			}
			object obj = typeof(MemberAchievementClanFeedData) + 112;
			object obj2 = obj;
			nint num = (nint)clanFeedData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X9_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v9+130]");
			bool flag3 = num2 < 0;
			object obj3 = !flag3;
			object obj4 = ~obj3;
			if (obj4 != null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X9_v5 (Il2CppClass<Kammelna.Server.Models.Clans.ClanFeedData>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X8_v9+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X9_v7-8]");
			if (0 != (nint)obj2)
			{
				return;
			}
			InitializeAvatar(model);
			object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+38]");
			PlayerRank playerRank = default(PlayerRank);
			playerRank..ctor(PlayerRank.Ranks.AI);
			bool flag4 = playerRank == null;
			object obj7 = 0;
			flag2 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+38]");
			ranks = PlayerRank.Ranks.AI;
			if (!flag4)
			{
				string rankName = playerRank.RankName;
				object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v14+E4]");
				bool flag5 = (nint)0 == 0;
				object obj10 = !flag5;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string text = LocalizationUtil.Localize(rankName);
				object obj11 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object[] array = default(object[]);
				bool flag6 = array == null;
				obj7 = 0;
				flag2 = false;
				ranks = PlayerRank.Ranks.Intermediate;
				if (!flag6)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+30]");
					bool flag7 = (nint)0 == 0;
					PlayerRank.Ranks ranks2 = PlayerRank.Ranks.Intermediate;
					if (!flag7)
					{
						nint num4 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
						ranks2 = PlayerRank.Ranks.AI;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag8 = ex == null;
						obj7 = 0;
						flag2 = false;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
						ranks = PlayerRank.Ranks.AI;
						if (flag8)
						{
							goto IL_0407;
						}
					}
					bool flag9 = array.Length == 0;
					obj7 = 0;
					flag2 = false;
					ranks = ranks2;
					if (!flag9)
					{
						object obj12 = array + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+30]");
						obj12 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						bool flag10 = text == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+30]");
						PlayerRank.Ranks ranks3 = PlayerRank.Ranks.AI;
						if (!flag10)
						{
							nint num5 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v23 (Il2CppClass<System.Object[]>)+40]");
							ranks3 = PlayerRank.Ranks.AI;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag11 = ex == null;
							obj7 = 0;
							flag2 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v23 (Il2CppClass<System.Object[]>)+40]");
							ranks = PlayerRank.Ranks.AI;
							if (flag11)
							{
								goto IL_0407;
							}
						}
						object obj13 = array.Length & 0xFFFFFFFEL;
						bool flag12 = obj13 == null;
						obj7 = 0;
						flag2 = false;
						ranks = ranks3;
						if (!flag12)
						{
							object obj14 = array + 40;
							obj14 = text;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj15 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3880;
							TextMeshProExtensions.Localize(base.text, (string)obj15, array);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X24_v4 (Kammelna.Server.Models.Clans.ClanFeedData)+38]");
							SetRank(PlayerRank.Ranks.AI);
							return;
						}
					}
					goto IL_03f9;
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_03f9;
		IL_03f9:
		ex = new IndexOutOfRangeException();
		goto IL_0407;
		IL_0407:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private void SetRank(PlayerRank.Ranks rank)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0171: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_01bc: Expected O, but got I4
		//IL_01c5: Expected O, but got I4
		//IL_010d: Expected I, but got O
		//IL_011d: Expected O, but got I
		//IL_012d: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E85CF]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0137;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		UnityEngine.Object obj5 = this.rankSetter;
		UnityEngine.Object obj6 = this.rankSetter;
		if (!flag)
		{
			goto IL_0091;
		}
		goto IL_0189;
		IL_0189:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = obj6 != null;
		bool flag3 = !flag2;
		object obj7 = !flag3;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		if (obj7 == null)
		{
			return;
		}
		goto IL_00c6;
		IL_0091:
		bool flag4 = obj5 != null;
		bool flag5 = !flag4;
		obj8 = 0;
		obj9 = null;
		if (!flag5)
		{
			goto IL_00c6;
		}
		return;
		IL_00c6:
		object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		RankSetter rankSetter = this.rankSetter;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(rank);
		nint num = (nint)rankSetter;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v9 (Il2CppClass<RankSetter>)+1A8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v9 (Il2CppClass<RankSetter>)+1B0]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v104 @ X4_v1 (should have been resolved before IL gen)");
		goto IL_0137;
		IL_0137:
		_ = 1;
		obj5 = this.rankSetter;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag6 = (nint)0 == 0;
		object obj13 = !flag6;
		obj6 = this.rankSetter;
		if (obj13 != null)
		{
			goto IL_0091;
		}
		goto IL_0189;
	}

	public ClanEventStrip_MemberRankUp()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
