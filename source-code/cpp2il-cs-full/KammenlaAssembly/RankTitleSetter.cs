using System;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine;

[Serializable]
public class RankTitleSetter : IRankSubSetter
{
	private TextMeshProUGUI rankTitle;

	private RankFonts fonts;

	public string Label
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			if ((object)rankTitle != null)
			{
				object obj = "Picking audio files is not supported on iOS" + 3920;
				object obj2 = "&action=sign-up" + 2696;
				string name = rankTitle.name;
				return (string)obj + name + (string)obj2;
			}
			return (string)(object)new NullReferenceException();
		}
	}

	public void Set(PlayerRank playerRank)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00f8: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		string rankName = playerRank.RankName;
		TextMeshProExtensions.Localize(rankTitle, rankName);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			if (!(fonts != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = fonts != null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				return;
			}
		}
		object fontMaterial = ((RanksData<object>)(object)fonts).GetFor(playerRank.<Rank>k__BackingField, isNew: false);
		rankTitle.fontMaterial = (Material)fontMaterial;
	}
}
