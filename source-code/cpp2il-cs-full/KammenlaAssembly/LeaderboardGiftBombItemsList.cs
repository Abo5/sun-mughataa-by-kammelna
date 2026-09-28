using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class LeaderboardGiftBombItemsList : UiListView<LeaderboardBombItemHolder, LeaderboardGiftBombItem>
{
	protected override void Start()
	{
		//IL_000c: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		object obj = (nint)0 + (nint)688;
		object obj2 = typeof(List<AdaptivePerformanceScaler>) + 2104;
		Start();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<LeaderboardBombItemHolder> list = default(List<LeaderboardBombItemHolder>);
		list..ctor();
		base.data = list;
		RequestBombers();
	}

	private void OnEnable()
	{
		RequestBombers();
	}

	private void RequestBombers()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 776;
		object obj2 = (nint)0 + (nint)544;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3464;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			RecentGiftBombsManager.GetRecentBombers(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RecentGiftBombsManager.GetRecentBombers(action);
	}

	public void SetData(List<GiftBombData> bombData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_007b: Expected I, but got O
		//IL_0039: Expected I, but got O
		//IL_0049: Expected O, but got I
		//IL_0059: Expected O, but got I
		object obj = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1400;
		object obj2 = (nint)0 + (nint)552;
		Func<object, LeaderboardBombItemHolder> func = default(Func<object, LeaderboardBombItemHolder>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor((object)this, (IntPtr)obj2);
			IEnumerable<LeaderboardBombItemHolder> source = Enumerable.Select(bombData, func);
			List<LeaderboardBombItemHolder> list = Enumerable.ToList(source);
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v3 (Il2CppClass<LeaderboardGiftBombItemsList>)+2A8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v3 (Il2CppClass<LeaderboardGiftBombItemsList>)+2B0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v82 @ X3_v2 (should have been resolved before IL gen)");
		}
	}

	public LeaderboardGiftBombItemsList()
	{
		((UiListView<LeaderboardBombItemHolder, object>)(object)this)..ctor();
	}

	private void <RequestBombers>b__2_0(List<GiftBombData> model)
	{
		if (!ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)model))
		{
			SetData(model);
		}
	}

	private unsafe LeaderboardBombItemHolder <SetData>b__3_0(GiftBombData bomb)
	{
		//IL_0010: Expected O, but got I
		//IL_0090: Expected O, but got I
		//IL_009d: Expected native int or pointer, but got O
		//IL_00a7: Expected native int or pointer, but got O
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_0100: Expected I4, but got I8
		//IL_00fb: Expected native int or pointer, but got O
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LeaderboardGiftBombItemsList)+38]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (LeaderboardGiftBombItemsList)+38]");
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
				LeaderboardBombItemHolder leaderboardBombItemHolder = default(LeaderboardBombItemHolder);
				((LeaderboardBombItemHolder*)(nint)leaderboardBombItemHolder)-><index>k__BackingField = 0;
				System.Runtime.CompilerServices.Unsafe.Write(&((LeaderboardBombItemHolder*)(nint)leaderboardBombItemHolder)-><template>k__BackingField, null);
				object obj2 = leaderboardBombItemHolder + 16;
				obj2 = bomb;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (bomb != null)
				{
					((LeaderboardBombItemHolder*)(nint)leaderboardBombItemHolder)-><index>k__BackingField = (int)bomb.<Id>k__BackingField;
					object obj3 = leaderboardBombItemHolder + 8;
					obj3 = text;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					LeaderboardBombItemHolder result = default(LeaderboardBombItemHolder);
					return result;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0133;
		IL_0133:
		return (LeaderboardBombItemHolder)new IndexOutOfRangeException();
	}
}
