using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using UnityEngine;

public class ActiveClansWidget : MonoBehaviour, IClanLandingWidget
{
	private RectTransform entriesContainer;

	private ActiveClanEntry entryPrefab;

	public void Populate(ClanLandingResponseModel landing)
	{
		//IL_0034: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0054: Expected O, but got I
		//IL_0060: Expected O, but got I
		//IL_00a1: Expected O, but got I4
		//IL_0116: Expected O, but got I4
		ClearEntries();
		object obj4 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		ClanLandingResponseModel clanLandingResponseModel = default(ClanLandingResponseModel);
		if (clanLandingResponseModel != null && clanLandingResponseModel.MostActive != null)
		{
			object obj = (nint)0 + (nint)4088;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = (nint)0 + (nint)464;
			obj4 = (nint)0 + (nint)4080;
			List<object>.Enumerator enumerator = ((List<object>)(object)clanLandingResponseModel.MostActive).GetEnumerator();
			ActiveClanEntry activeClanEntry = default(ActiveClanEntry);
			while (true)
			{
				if (enumerator2.MoveNext())
				{
					object obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v23+E4]");
					bool flag = (nint)0 == 0;
					object obj6 = !flag;
					if (obj6 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
					if ((object)activeClanEntry == null)
					{
						break;
					}
					activeClanEntry.Populate(null);
					continue;
				}
				enumerator2.Dispose();
				return;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj7 = 0;
			clanLandingResponseModel = (ClanLandingResponseModel)(object)entriesContainer;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = (nint)clanLandingResponseModel != 1;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			clanLandingResponseModel = (ClanLandingResponseModel)obj4;
			enumerator2.Dispose();
			object obj8 = default(object);
			if (obj8 == null)
			{
				return;
			}
			ex3 = new OutOfMemoryException();
			object obj7 = obj8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223DA48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void ClearEntries()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_00d8: Expected O, but got I4
		int childCount = entriesContainer.childCount;
		if (childCount < 1)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		int num = childCount;
		do
		{
			num--;
			Transform child = entriesContainer.GetChild(num);
			GameObject gameObject = child.gameObject;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			UnityEngine.Object obj4 = gameObject;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj4 = gameObject;
			}
			UnityEngine.Object.Destroy(obj4);
		}
		while (num > 0);
	}
}
