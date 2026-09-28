using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using UnityEngine;

public class LeaderBoardListView : UiListView<LeaderBoardPlayerHolder, NormalPlaceItem>
{
	public void SetData(List<LeaderBoardPlayer> players)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_007b: Expected I, but got O
		//IL_0039: Expected I, but got O
		//IL_0049: Expected O, but got I
		//IL_0059: Expected O, but got I
		object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2264;
		object obj2 = (nint)0 + (nint)504;
		Func<object, LeaderBoardPlayerHolder> func = default(Func<object, LeaderBoardPlayerHolder>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor((object)this, (IntPtr)obj2);
			IEnumerable<LeaderBoardPlayerHolder> source = Enumerable.Select(players, func);
			List<LeaderBoardPlayerHolder> list = Enumerable.ToList(source);
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v3 (Il2CppClass<LeaderBoardListView>)+2A8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v3 (Il2CppClass<LeaderBoardListView>)+2B0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v82 @ X3_v2 (should have been resolved before IL gen)");
		}
	}

	protected override float ComputeListHeight()
	{
		float num = ((UiListView<LeaderBoardPlayerHolder, object>)(object)this).ComputeListHeight();
		float bottomCutoutSize = ScreenUtility.BottomCutoutSize;
		return num + bottomCutoutSize;
	}

	public LeaderBoardListView()
	{
		((UiListView<LeaderBoardPlayerHolder, object>)(object)this)..ctor();
	}

	private unsafe LeaderBoardPlayerHolder <SetData>b__0_0(LeaderBoardPlayer player)
	{
		//IL_0010: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_009d: Expected native int or pointer, but got O
		//IL_00a7: Expected native int or pointer, but got O
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00fb: Expected native int or pointer, but got O
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LeaderBoardListView)+38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LeaderBoardListView)+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v1+18]");
			if ((nint)0 == 0)
			{
				goto IL_0133;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v1+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X8_v1+20]");
				string text = ((UnityEngine.Object)0).name;
				LeaderBoardPlayerHolder leaderBoardPlayerHolder = default(LeaderBoardPlayerHolder);
				((LeaderBoardPlayerHolder*)(nint)leaderBoardPlayerHolder)-><index>k__BackingField = 0;
				System.Runtime.CompilerServices.Unsafe.Write(&((LeaderBoardPlayerHolder*)(nint)leaderBoardPlayerHolder)-><template>k__BackingField, null);
				object obj2 = leaderBoardPlayerHolder + 16;
				obj2 = player;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (player != null)
				{
					((LeaderBoardPlayerHolder*)(nint)leaderBoardPlayerHolder)-><index>k__BackingField = player.Id;
					object obj3 = leaderBoardPlayerHolder + 8;
					obj3 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					LeaderBoardPlayerHolder result = default(LeaderBoardPlayerHolder);
					return result;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0133;
		IL_0133:
		return (LeaderBoardPlayerHolder)new IndexOutOfRangeException();
	}
}
