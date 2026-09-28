using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Features.GameReplay;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class InterClanLeaderboardListView : UiListView<InterClanLeaderboardRowHolder, InterClanLeaderboardRow>
{
	private sealed class <>c__DisplayClass0_0
	{
		public int myClanId;

		public InterClanLeaderboardListView <>4__this;

		internal unsafe InterClanLeaderboardRowHolder <SetData>b__0(InterClanLeaderboardEntryModel entry)
		{
			//IL_0056: Expected O, but got I
			//IL_00d6: Expected O, but got I
			//IL_00e3: Expected native int or pointer, but got O
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Expected O, but got Unknown
			//IL_00ff: Expected O, but got I4
			//IL_0113: Expected O, but got I4
			//IL_0141: Expected native int or pointer, but got O
			//IL_0153: Expected native int or pointer, but got O
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Expected O, but got Unknown
			if (entry != null)
			{
				InterClanLeaderboardListView interClanLeaderboardListView = <>4__this;
				if ((object)<>4__this != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v3 (InterClanLeaderboardListView)+38]");
					object obj = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X8_v3 (InterClanLeaderboardListView)+38]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v4+18]");
						if ((nint)0 == 0)
						{
							goto IL_018b;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v4+20]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X8_v4+20]");
							string name = ((UnityEngine.Object)0).name;
							InterClanLeaderboardRowHolder interClanLeaderboardRowHolder = default(InterClanLeaderboardRowHolder);
							((InterClanLeaderboardRowHolder*)(nint)interClanLeaderboardRowHolder)-><index>k__BackingField = 0;
							object obj2 = interClanLeaderboardRowHolder + 16;
							obj2 = 0;
							object obj3 = entry.ClanId - myClanId;
							bool <IsMyClan>k__BackingField = obj3 == null;
							obj2 = entry;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							((InterClanLeaderboardRowHolder*)(nint)interClanLeaderboardRowHolder)-><IsMyClan>k__BackingField = <IsMyClan>k__BackingField;
							((InterClanLeaderboardRowHolder*)(nint)interClanLeaderboardRowHolder)-><index>k__BackingField = entry.ClanId;
							object obj4 = interClanLeaderboardRowHolder + 8;
							obj4 = name;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							InterClanLeaderboardRowHolder result = default(InterClanLeaderboardRowHolder);
							return result;
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_018b;
			IL_018b:
			return (InterClanLeaderboardRowHolder)new IndexOutOfRangeException();
		}
	}

	public void SetData(List<InterClanLeaderboardEntryModel> entries, int myClanId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		//IL_00f5: Expected I, but got O
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00bc: Expected O, but got I
		//IL_0122: Expected I, but got O
		//IL_0132: Expected O, but got I
		//IL_0142: Expected O, but got I
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3912;
		object obj2 = default(object);
		List<object> list = default(List<object>);
		Func<object, InterClanLeaderboardRowHolder> func = default(Func<object, InterClanLeaderboardRowHolder>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj2..ctor();
			object obj3 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1976;
			object obj4 = (nint)0 + (nint)976;
			object obj5 = obj2 + 24;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag = entries == null;
			object obj6 = !flag;
			InterClanLeaderboardListView interClanLeaderboardListView = this;
			List<object> source = (List<object>)(object)entries;
			if (obj6 == null)
			{
				object obj7 = typeof(List<AdaptivePerformanceScaler>) + 1840;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj8 = (nint)0 + (nint)1688;
				interClanLeaderboardListView = (InterClanLeaderboardListView)obj8;
				list..ctor();
				source = list;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor(obj2, (IntPtr)obj4);
			IEnumerable<InterClanLeaderboardRowHolder> source2 = Enumerable.Select(source, func);
			List<InterClanLeaderboardRowHolder> list2 = Enumerable.ToList(source2);
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4 (Il2CppClass<InterClanLeaderboardListView>)+2A8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v4 (Il2CppClass<InterClanLeaderboardListView>)+2B0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v106 @ X3_v2 (should have been resolved before IL gen)");
		}
	}

	protected override float ComputeListHeight()
	{
		float num = ((UiListView<InterClanLeaderboardRowHolder, object>)(object)this).ComputeListHeight();
		float bottomCutoutSize = ScreenUtility.BottomCutoutSize;
		return num + bottomCutoutSize;
	}

	public InterClanLeaderboardListView()
	{
		((UiListView<InterClanLeaderboardRowHolder, object>)(object)this)..ctor();
	}
}
