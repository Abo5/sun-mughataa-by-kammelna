using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;

public class ClanBadgeLayoutSelector : AvatarComponent
{
	private List<GameObject> objectsWhenInClan;

	private List<GameObject> objectsWhenNoClan;

	public override void Initialize(AvatarData avatarData)
	{
		//IL_0013: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected I4, but got Unknown
		object obj = avatarData.<ClanId>k__BackingField - 1;
		bool flag = (nint)obj < 0;
		int num = avatarData.<ClanId>k__BackingField ^ 1;
		int num2 = avatarData.<ClanId>k__BackingField ^ obj;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		bool active = !flag3;
		bool flag4 = avatarData.<ClanId>k__BackingField < 0;
		bool flag5 = avatarData.<ClanId>k__BackingField == 0;
		int num4 = avatarData.<ClanId>k__BackingField ^ avatarData.<ClanId>k__BackingField;
		int num5 = avatarData.<ClanId>k__BackingField & num4;
		bool flag6 = num5 < 0;
		bool flag7 = flag4 == flag6;
		object obj2 = !flag5;
		bool active2 = (byte)((flag7 & obj2) ? 1 : 0) != 0;
		SetActiveAll(objectsWhenInClan, active2);
		SetActiveAll(objectsWhenNoClan, active);
	}

	public override void Initialize(User userData)
	{
		//IL_001b: Expected O, but got I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected I4, but got Unknown
		//IL_00da: Expected O, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected I4, but got Unknown
		int clanId = SFSKammelnaUserExtensions.GetClanId(userData);
		object obj = clanId - 1;
		bool flag = (nint)obj < 0;
		int num = clanId ^ 1;
		int num2 = clanId ^ obj;
		int num3 = num & num2;
		bool flag2 = num3 < 0;
		bool flag3 = flag == flag2;
		bool active = !flag3;
		bool flag4 = clanId < 0;
		bool flag5 = clanId == 0;
		int num4 = clanId ^ clanId;
		int num5 = clanId & num4;
		bool flag6 = num5 < 0;
		bool flag7 = flag4 == flag6;
		object obj2 = !flag5;
		bool active2 = (byte)((flag7 & obj2) ? 1 : 0) != 0;
		SetActiveAll(objectsWhenInClan, active2);
		SetActiveAll(objectsWhenNoClan, active);
	}

	public override void Clear()
	{
		SetActiveAll(objectsWhenInClan, active: false);
		SetActiveAll(objectsWhenNoClan, active: true);
	}

	private void ApplyLayout(bool isInClan)
	{
		SetActiveAll(objectsWhenInClan, isInClan);
		bool active = (byte)((isInClan ? 1u : 0u) ^ 1u) != 0;
		SetActiveAll(objectsWhenNoClan, active);
	}

	private static void SetActiveAll(List<GameObject> targets, bool active)
	{
		//IL_0012: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0032: Expected O, but got I
		//IL_006e: Expected O, but got I4
		//IL_00aa: Expected I, but got O
		//IL_00f8: Expected O, but got I4
		if (targets == null)
		{
			return;
		}
		object obj = (nint)0 + (nint)1048;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj3 = (nint)0 + (nint)1040;
		List<object>.Enumerator enumerator = ((List<object>)(object)targets).GetEnumerator();
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		bool flag3;
		do
		{
			if (enumerator2.MoveNext())
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				bool flag2 = (UnityEngine.Object)null != (UnityEngine.Object)null;
				flag3 = !flag2;
				nint num = unchecked((nint)null);
				continue;
			}
			enumerator2.Dispose();
			return;
		}
		while (flag3);
		NullReferenceException ex = new NullReferenceException();
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		NullReferenceException ex2 = ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @22389E8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}
}
