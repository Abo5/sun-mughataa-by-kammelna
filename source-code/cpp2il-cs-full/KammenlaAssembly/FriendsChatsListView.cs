using System;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using ListView;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine.Rendering;

public class FriendsChatsListView : UiListView<IListViewItemData<int>, ListViewItem<IListViewItemData<int>, int>>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<FriendProfile, int, FriendProfileHolder> <>9__0_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 3184;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal unsafe FriendProfileHolder <SetData>b__0_0(FriendProfile friend, int i)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001d: Expected native int or pointer, but got O
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			//IL_0039: Expected O, but got I4
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Expected O, but got Unknown
			//IL_0061: Expected native int or pointer, but got O
			object obj = "LAK" + 1816;
			FriendProfileHolder friendProfileHolder = default(FriendProfileHolder);
			((FriendProfileHolder*)(nint)friendProfileHolder)-><index>k__BackingField = 0;
			object obj2 = friendProfileHolder + 8;
			obj2 = 0;
			object obj3 = friendProfileHolder + 16;
			FriendProfile friendProfile = default(FriendProfile);
			obj3 = friendProfile;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			((FriendProfileHolder*)(nint)friendProfileHolder)-><index>k__BackingField = i;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			FriendProfileHolder result = default(FriendProfileHolder);
			return result;
		}
	}

	public void SetData(IEnumerable<FriendProfile> friends)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0115: Expected O, but got I4
		//IL_01ae: Expected O, but got I
		//IL_01be: Expected O, but got I
		//IL_01e0: Expected O, but got I4
		//IL_0052: Expected O, but got I4
		//IL_00c1: Expected I, but got O
		//IL_00d1: Expected O, but got I
		//IL_00e1: Expected O, but got I
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_014d: Expected O, but got I
		//IL_015e: Expected I, but got O
		//IL_017c: Expected O, but got I
		//IL_0082: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 3184;
		Func<object, int, FriendProfileHolder> func = default(Func<object, int, FriendProfileHolder>);
		while (true)
		{
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v8+8]");
			Func<object, int, FriendProfileHolder> selector = (Func<object, int, FriendProfileHolder>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v8+8]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v14+B8]");
					obj4 = 0;
				}
				object obj8 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 744;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)752;
				func..ctor(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X8_v13+B8]");
				object obj11 = (nint)0 + (nint)8;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			IEnumerable<FriendProfileHolder> source = Enumerable.Select(friends, selector);
			IEnumerable<object> source2 = Enumerable.Cast<object>(source);
			List<object> list = Enumerable.ToList(source2);
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v6 (Il2CppClass<FriendsChatsListView>)+2A8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X8_v6 (Il2CppClass<FriendsChatsListView>)+2B0]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v130 @ X3_v2 (should have been resolved before IL gen)");
		}
	}

	public FriendsChatsListView()
	{
		((UiListView<object, object>)(object)this)..ctor();
	}
}
