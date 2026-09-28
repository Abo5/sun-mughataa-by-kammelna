using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InterClanLeaderboardRow : ListViewItem<InterClanLeaderboardRowHolder, int>
{
	private TextMeshProUGUI rankText;

	private TextMeshProUGUI clanNameText;

	private ClanTierIcon tierIcon;

	private TextMeshProUGUI scoreText;

	private NumberFormatter scoreFormatter;

	private ClanEmblemLoader emblemImage;

	private Graphic highlight;

	private ClansSerializedUtils clanUtils;

	private InterClanLeaderboardEntryModel _entry;

	public int ClanId
	{
		get
		{
			//IL_003d: Expected I4, but got I8
			InterClanLeaderboardEntryModel entry = _entry;
			if (_entry != null)
			{
				return entry.ClanId;
			}
			return -1;
		}
	}

	public unsafe override void Setup(InterClanLeaderboardRowHolder datum, bool firstTime)
	{
		//IL_0015: Expected O, but got Ref
		int num = default(int);
		bool firstTime2 = default(bool);
		base.Setup((InterClanLeaderboardRowHolder)(&num), firstTime2);
		Populate(datum.<Entry>k__BackingField, datum.<IsMyClan>k__BackingField);
	}

	public void Populate(InterClanLeaderboardEntryModel entry, bool isMyClan)
	{
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_0134: Expected I8, but got I4
		//IL_0120: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_01ee: Expected O, but got I4
		object obj = this + 216;
		obj = entry;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (entry == null)
		{
			return;
		}
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		TextMeshProExtensions.SetNumber(rankText, entry.Rank, useCommas: true);
		TextMeshProExtensions.FixArabic(clanNameText, entry.ClanName);
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v8+E4]");
		object obj5;
		if ((nint)0 != 0)
		{
			bool flag = tierIcon;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 != null)
			{
				goto IL_0103;
			}
			obj5 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = tierIcon;
			bool flag4 = !flag3;
			obj5 = 0;
			if (!flag4)
			{
				goto IL_0103;
			}
		}
		goto IL_0125;
		IL_0103:
		tierIcon.SetTier(entry.Tier);
		obj5 = 0;
		goto IL_0125;
		IL_0125:
		AssignScore(entry.Score);
		LoadEmblem(entry);
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			if (!highlight)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = highlight;
			bool flag6 = !flag5;
			object obj7 = !flag6;
			if (obj7 == null)
			{
				return;
			}
		}
		GameObject gameObject = highlight.gameObject;
		gameObject.SetActive(isMyClan);
	}

	public void OpenClanProfile()
	{
		//IL_0067: Expected O, but got I4
		//IL_0074: Expected I4, but got I8
		InterClanLeaderboardEntryModel entry = _entry;
		int clanId;
		if (_entry != null)
		{
			clanId = entry.ClanId;
		}
		else
		{
			bool flag = (object)clanUtils == null;
			object obj = !flag;
			clanId = -1;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		clanUtils.OpenClanCardInfoPopup(clanId);
	}

	private void LoadEmblem(InterClanLeaderboardEntryModel entry)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_0159: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E869D]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = emblemImage;
			obj6 = emblemImage;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = emblemImage;
			obj6 = emblemImage;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			return;
		}
		goto IL_00b7;
		IL_00b7:
		emblemImage.Load(entry.ClanId, entry.Emblem);
		return;
		IL_0091:
		if ((bool)obj5)
		{
			goto IL_00b7;
		}
	}

	private void AssignScore(long score)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0106: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_014e: Expected O, but got I4
		//IL_01ae: Expected O, but got I4
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_0236: Expected I, but got O
		//IL_0246: Expected O, but got I
		//IL_0256: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E869E]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			obj5 = scoreText;
			obj6 = scoreText;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = scoreText;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v17+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = scoreText;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = 0;
		if (flag4)
		{
			return;
		}
		goto IL_015c;
		IL_01f8:
		if (score <= 2147483647)
		{
			NumberFormatter numberFormatter = scoreFormatter;
			TextMeshProUGUI textMeshProUGUI = scoreText;
			nint num = (nint)numberFormatter;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v10 (Il2CppClass<NumberFormatter>)+178]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v10 (Il2CppClass<NumberFormatter>)+180]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v103 @ X4_v1 (should have been resolved before IL gen)");
		}
		goto IL_0260;
		IL_0260:
		object obj11 = "Material with texture name \"" + 3224;
		long num2 = default(long);
		string text = num2.ToString((string)obj11);
		scoreText.text = text;
		return;
		IL_015c:
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			bool flag5 = scoreFormatter;
			bool flag6 = !flag5;
			object obj13 = !flag6;
			if (obj13 != null)
			{
				goto IL_01f8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if ((bool)scoreFormatter)
			{
				goto IL_01f8;
			}
		}
		goto IL_0260;
		IL_0091:
		bool flag7 = obj5;
		bool flag8 = !flag7;
		object obj14 = !flag8;
		obj8 = 0;
		if (obj14 == null)
		{
			return;
		}
		goto IL_015c;
	}
}
