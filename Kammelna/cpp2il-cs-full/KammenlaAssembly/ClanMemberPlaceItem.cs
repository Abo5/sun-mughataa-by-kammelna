using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using TMPro;
using UnityEngine;

public class ClanMemberPlaceItem : NormalPlaceItem
{
	private TextMeshProUGUI roleTitleLabel;

	public unsafe override void Setup(LeaderBoardPlayerHolder datum, bool firstTime)
	{
		//IL_0016: Expected O, but got Ref
		//IL_0028: Expected O, but got I
		int num = default(int);
		bool firstTime2 = default(bool);
		((ListViewItem<LeaderBoardPlayerHolder, int>)this).Setup((LeaderBoardPlayerHolder)(&num), firstTime2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (ClanMemberPlaceItem)+50]");
		Populate((LeaderBoardPlayer)0);
		UpdateRole(datum.<Player>k__BackingField);
	}

	private void UpdateRole(LeaderBoardPlayer player)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010a: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0284: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_0230: Expected I, but got O
		//IL_0240: Expected O, but got I
		//IL_0250: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6213]");
		object obj3 = (nint)0 & (nint)1;
		Object obj5;
		Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			obj5 = roleTitleLabel;
			obj6 = roleTitleLabel;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = roleTitleLabel;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = roleTitleLabel;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = 0;
		if (!flag4)
		{
			goto IL_0160;
		}
		return;
		IL_0160:
		object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		bool flag5 = player == null;
		LeaderBoardPlayer value = player;
		if (!flag5)
		{
			value = (LeaderBoardPlayer)(object)player.ClanRoleTitle;
		}
		while (true)
		{
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v3+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag7 = StringsExtensions.IsNullOrEmpty((string)(object)value);
			GameObject gameObject = roleTitleLabel.gameObject;
			bool active = (byte)((flag7 ? 1u : 0u) ^ 1u) != 0;
			gameObject.SetActive(active);
			if (flag7)
			{
				break;
			}
			TextMeshProUGUI textMeshProUGUI = roleTitleLabel;
			nint num = (nint)textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v7 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v7 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v105 @ X3_v1 (should have been resolved before IL gen)");
		}
		return;
		IL_0091:
		bool flag8 = obj5;
		bool flag9 = !flag8;
		object obj14 = !flag9;
		obj8 = 0;
		if (obj14 == null)
		{
			return;
		}
		goto IL_0160;
	}
}
