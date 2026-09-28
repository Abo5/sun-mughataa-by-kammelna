using System;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;

public class ClanRoleSetter : AvatarComponent
{
	private TextMeshProUGUI roleTitleLabel;

	private GameObject ownerBadge;

	public override void Initialize(AvatarData avatarData)
	{
		//IL_0062: Expected O, but got I4
		string roleTitle;
		bool isOwner;
		if (avatarData != null)
		{
			roleTitle = avatarData.<ClanTitle>k__BackingField;
			isOwner = avatarData.<IsClanOwner>k__BackingField;
		}
		else
		{
			bool flag = (object)this == null;
			object obj = !flag;
			roleTitle = (string)(object)avatarData;
			isOwner = false;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		SetRole(roleTitle, isOwner);
	}

	public override void Initialize(User userData)
	{
		string roleTitle;
		bool isOwner;
		if (userData != null)
		{
			ClanUserModel clanMembership = SFSKammelnaUserExtensions.GetClanMembership(userData);
			if (clanMembership != null)
			{
				roleTitle = clanMembership.Title;
				isOwner = clanMembership.IsOwner;
			}
			else
			{
				isOwner = false;
				roleTitle = null;
			}
		}
		else
		{
			isOwner = false;
			roleTitle = (string)(object)userData;
		}
		SetRole(roleTitle, isOwner);
	}

	public override void Clear()
	{
		SetRole(null, isOwner: false);
	}

	private void SetRole(string roleTitle, bool isOwner)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0173: Expected O, but got I4
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_021c: Expected O, but got I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_00f2: Expected O, but got I4
		//IL_0103: Expected O, but got I4
		//IL_01cb: Expected O, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_03e1: Expected O, but got I4
		//IL_0134: Expected O, but got I4
		//IL_0335: Expected O, but got I4
		//IL_046b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected I4, but got Unknown
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c6: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7364]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v33+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v33+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		bool flag2 = StringsExtensions.IsNullOrEmpty(roleTitle);
		bool flag3 = !flag2;
		object obj7 = !flag3;
		string text = null;
		object obj8 = obj6;
		if (obj7 != null)
		{
			goto IL_00c8;
		}
		goto IL_01e6;
		IL_0412:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj9;
		bool flag4 = obj9;
		bool flag5 = !flag4;
		object obj11;
		object obj10 = obj11;
		if (!flag5)
		{
			goto IL_044f;
		}
		return;
		IL_0312:
		UnityEngine.Object obj12;
		bool flag6 = obj12;
		bool flag7 = !flag6;
		object obj13 = !flag7;
		if (obj13 == null)
		{
			return;
		}
		goto IL_044f;
		IL_039e:
		ownerBadge.SetActive(isOwner);
		obj12 = roleTitleLabel;
		object obj14 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v10+E4]");
		bool flag8 = (nint)0 == 0;
		object obj15 = !flag8;
		obj10 = obj11;
		bool flag9 = false;
		bool flag10 = isOwner;
		obj9 = roleTitleLabel;
		if (obj15 != null)
		{
			goto IL_0312;
		}
		goto IL_0412;
		IL_007d:
		obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		bool flag11 = StringsExtensions.IsNullOrEmpty(roleTitle);
		bool flag12 = !flag11;
		text = null;
		obj8 = obj6;
		if (!flag12)
		{
			goto IL_00c8;
		}
		goto IL_01e6;
		IL_01e6:
		object obj16 = "{0} color encoding is currently unsupported for outputting to HDR." + 2312;
		text = (string)obj16;
		bool flag13 = roleTitle != (string)obj16;
		obj10 = (flag13 ? 1 : 0) ^ 1;
		object obj17 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v17+E4]");
		bool flag14 = (nint)0 == 0;
		flag9 = false;
		obj6 = obj8;
		UnityEngine.Object obj18 = ownerBadge;
		bool flag15 = false;
		obj11 = obj10;
		UnityEngine.Object obj19 = ownerBadge;
		if (!flag14)
		{
			goto IL_027f;
		}
		goto IL_0348;
		IL_00c8:
		obj17 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v17+E4]");
		bool flag16 = (nint)0 == 0;
		object obj20 = !flag16;
		flag9 = isOwner;
		obj10 = 1;
		obj18 = ownerBadge;
		if (obj20 != null)
		{
			goto IL_027f;
		}
		flag15 = isOwner;
		obj8 = obj6;
		obj11 = 1;
		obj19 = ownerBadge;
		goto IL_0348;
		IL_027f:
		bool flag17 = obj18;
		bool flag18 = !flag17;
		object obj21 = !flag18;
		flag10 = false;
		obj8 = obj6;
		obj11 = obj10;
		if (obj21 == null)
		{
			goto IL_02c9;
		}
		goto IL_039e;
		IL_044f:
		GameObject gameObject = roleTitleLabel.gameObject;
		object obj22 = isOwner | obj10;
		bool active = (byte)(obj22 ^ 1) != 0;
		gameObject.SetActive(active);
		object obj23 = obj22 & 1;
		if (obj23 == null)
		{
			object obj24 = "&action=sign-up" + 2040;
			object obj25 = "&action=sign-up" + 2696;
			string text2 = (string)obj24 + roleTitle + (string)obj25;
			TextMeshProExtensions.FixArabic(roleTitleLabel, text2);
		}
		return;
		IL_0348:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag19 = obj19;
		bool flag20 = !flag19;
		flag9 = flag15;
		flag10 = false;
		obj6 = obj8;
		obj10 = obj11;
		if (flag20)
		{
			goto IL_02c9;
		}
		goto IL_039e;
		IL_02c9:
		obj14 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v10+E4]");
		bool flag21 = (nint)0 == 0;
		obj12 = roleTitleLabel;
		obj11 = obj10;
		obj9 = roleTitleLabel;
		if (!flag21)
		{
			goto IL_0312;
		}
		goto IL_0412;
	}
}
