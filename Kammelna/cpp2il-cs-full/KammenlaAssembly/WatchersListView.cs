using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DataTracking;
using ListView;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using UnityEngine;

public class WatchersListView : UiListView<UserWrapper, WatcherUI>
{
	private WatchersListManager _manager;

	public void SetManager(WatchersListManager manager)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		_manager = manager;
		object obj = this + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SetData(List<User> players)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_007b: Expected I, but got O
		//IL_0039: Expected I, but got O
		//IL_0049: Expected O, but got I
		//IL_0059: Expected O, but got I
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 72;
		object obj2 = (nint)0 + (nint)3856;
		Func<object, UserWrapper> func = default(Func<object, UserWrapper>);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			func..ctor((object)this, (IntPtr)obj2);
			IEnumerable<UserWrapper> source = Enumerable.Select(players, func);
			List<UserWrapper> list = Enumerable.ToList(source);
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v3 (Il2CppClass<WatchersListView>)+2A8]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v3 (Il2CppClass<WatchersListView>)+2B0]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v82 @ X3_v2 (should have been resolved before IL gen)");
		}
	}

	protected unsafe override bool GetNewItem(UserWrapper datum, out WatcherUI item)
	{
		//IL_000c: Expected O, but got I
		//IL_0055: Expected O, but got Ref
		//IL_0047: Expected I4, but got O
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1456;
		string text = default(string);
		bool newItem = ((ListViewController<UserWrapper, object, int>)(object)this).GetNewItem((UserWrapper)(&text), out System.Runtime.CompilerServices.Unsafe.As<WatcherUI, object>(ref item));
		if ((object)item != null)
		{
			object obj2 = item + 176;
			obj2 = _manager;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return newItem;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public WatchersListView()
	{
		((UiListView<UserWrapper, object>)(object)this)..ctor();
	}

	private unsafe UserWrapper <SetData>b__2_0(User player)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ef: Expected O, but got I
		//IL_0074: Expected O, but got I
		//IL_007d: Expected native int or pointer, but got O
		//IL_0087: Expected native int or pointer, but got O
		//IL_009d: Expected native int or pointer, but got O
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerInfo playerInfo = default(PlayerInfo);
		playerInfo..ctor(player);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (WatchersListView)+38]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (WatchersListView)+38]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+18]");
			if ((nint)0 == 0)
			{
				goto IL_00ba;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v3+20]");
				string templateName = ((UnityEngine.Object)0).name;
				UserWrapper userWrapper = default(UserWrapper);
				System.Runtime.CompilerServices.Unsafe.Write(&((UserWrapper*)(nint)userWrapper)-><template>k__BackingField, null);
				System.Runtime.CompilerServices.Unsafe.Write(&((UserWrapper*)(nint)userWrapper)-><User>k__BackingField, null);
				System.Runtime.CompilerServices.Unsafe.Write((void*)(nint)userWrapper, new UserWrapper(playerInfo, templateName, TrackingPlacement.WatchersList));
				return userWrapper;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_00ba;
		IL_00ba:
		return (UserWrapper)new IndexOutOfRangeException();
	}
}
