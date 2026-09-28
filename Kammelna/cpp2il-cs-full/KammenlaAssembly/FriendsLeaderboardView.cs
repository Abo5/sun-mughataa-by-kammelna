using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ListView;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class FriendsLeaderboardView : UiListView<IListViewItemData<int>, ListViewItem<IListViewItemData<int>, int>>
{
	private int lastItemIndex;

	public void SetData(IEnumerable<FriendLeaderboardModel> friends, bool isTournamentPointView)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		object listItemTemplateName = "LAK" + 848;
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		base.data = (List<IListViewItemData<int>>)(object)list;
		lastItemIndex = 0;
		AddFriendsListData((string)listItemTemplateName, friends, isTournamentPointView);
	}

	private void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		base.data = (List<IListViewItemData<int>>)(object)list;
		lastItemIndex = 0;
	}

	private unsafe void AddFriendsListData(string listItemTemplateName, IEnumerable<FriendLeaderboardModel> friendsList, bool isTournamentPointView)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0876: Expected O, but got I
		//IL_007c: Expected O, but got I
		//IL_0796: Expected O, but got I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0179: Expected O, but got I
		//IL_00f9: Expected I4, but got O
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_027c: Expected I, but got O
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_08d3: Expected I4, but got O
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Expected O, but got Unknown
		//IL_02c7: Expected O, but got I
		//IL_05b7: Expected O, but got I4
		//IL_05e0: Expected O, but got I
		//IL_05e9: Expected O, but got I4
		//IL_0344: Expected I4, but got O
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_035a: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_09b4: Expected O, but got I4
		//IL_077e: Expected O, but got I
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Expected O, but got Unknown
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected O, but got Unknown
		//IL_060a: Expected I, but got O
		//IL_0399: Expected I, but got O
		//IL_03a9: Expected O, but got I
		//IL_09f6: Expected O, but got I
		//IL_0655: Expected O, but got I
		//IL_0969: Expected O, but got Ref
		//IL_0981: Expected O, but got Ref
		//IL_03e4: Expected O, but got I
		//IL_06c2: Expected I4, but got O
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cf: Expected O, but got Unknown
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected O, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_045e: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		//IL_04b0: Expected I4, but got O
		//IL_04c6: Expected O, but got I
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_0510: Expected O, but got I
		//IL_053a: Expected O, but got I4
		//IL_01b8: Expected O, but got I
		//IL_01d8: Expected O, but got I
		//IL_0580: Expected O, but got I
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6181]");
		int num = 0;
		bool flag2 = default(bool);
		IEnumerable<FriendLeaderboardModel> enumerable2;
		IEnumerable<FriendLeaderboardModel> enumerable = default(IEnumerable<FriendLeaderboardModel>);
		object obj3 = default(object);
		if (enumerable != null)
		{
			object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3176;
			nint num2 = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>>)+12E]");
			int num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00dd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>>)+B0]");
			object obj2 = (nint)0 + (nint)8;
			bool flag = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X10_v31-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 = obj2 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>>)+12E]");
				num3 = (int)(-1);
				flag2 = num3 != 1;
				flag = flag2;
				obj2 = obj3;
				if (flag2)
				{
					continue;
				}
				goto IL_00dd;
			}
			num3 = (int)obj2;
			object obj4 = num2 + obj2;
			object obj5 = obj4 + 312;
			enumerable2 = enumerable;
			flag2 = flag;
			obj3 = obj2;
			goto IL_0866;
		}
		goto IL_0a22;
		IL_0866:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X0_v22+8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v312 @ X0_v22] (should have been resolved before IL gen)");
		IEnumerable<FriendLeaderboardModel> enumerable3 = default(IEnumerable<FriendLeaderboardModel>);
		bool flag3 = enumerable3 == null;
		IEnumerable<FriendLeaderboardModel> enumerable4 = default(IEnumerable<FriendLeaderboardModel>);
		num = (int)(&enumerable4);
		if (flag3)
		{
			goto IL_072e;
		}
		object obj7 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj8 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 552;
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1728;
		object obj10 = (nint)0 + (nint)2512;
		object obj12 = default(object);
		object obj11 = obj12;
		int num5 = default(int);
		int num4 = num5;
		enumerable = enumerable2;
		object obj13 = obj3;
		IEnumerable<FriendLeaderboardModel> enumerable5 = enumerable3;
		object obj16 = default(object);
		object obj18 = default(object);
		object obj30 = default(object);
		int num9 = default(int);
		object obj36 = default(object);
		object obj39 = default(object);
		object obj23;
		string text;
		while (true)
		{
			nint num6 = (nint)enumerable5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>>)+12E]");
			int num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0328;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>>)+B0]");
			object obj14 = (nint)0 + (nint)8;
			bool flag4 = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v516 @ X10_v26-8]");
				if (0 == (nint)obj7)
				{
					break;
				}
				obj13 = obj14 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>>)+12E]");
				num3 = (int)(-1);
				flag2 = num3 != 1;
				flag4 = flag2;
				obj14 = obj13;
				if (flag2)
				{
					continue;
				}
				goto IL_0328;
			}
			num3 = (int)obj14;
			object obj15 = num6 + obj14;
			obj16 = obj15 + 312;
			flag2 = flag4;
			obj13 = obj14;
			goto IL_08cb;
			IL_08cb:
			num = (int)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v553 @ X0_v29] (should have been resolved before IL gen)");
			object obj17 = obj18 & 1;
			if (obj17 != null)
			{
				if (enumerable3 == null)
				{
					break;
				}
				nint num7 = (nint)enumerable3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>>)+12E]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_043d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>>)+B0]");
				object obj20 = (nint)0 + (nint)8;
				bool flag5 = flag2;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v733 @ X10_v21-8]");
					if (0 == (nint)obj8)
					{
						break;
					}
					obj13 = obj20 + 16;
					obj19--;
					flag2 = (nint)obj19 != 1;
					flag5 = flag2;
					obj20 = obj13;
					if (flag2)
					{
						continue;
					}
					goto IL_043d;
				}
				object obj21 = num7 + obj20;
				object obj22 = obj21 + 312;
				flag2 = flag5;
				obj13 = obj20;
				goto IL_092d;
			}
			enumerable4 = enumerable3;
			obj23 = 0;
			obj12 = obj11;
			num5 = num4;
			obj3 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v29+8]");
			text = (string)0;
			object obj24 = 0;
			while (true)
			{
				if (enumerable4 == null)
				{
					goto IL_099a;
				}
				object obj25 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num8 = (nint)enumerable4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>>)+12E]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_06a6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>>)+B0]");
				object obj26 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v676 @ X10_v8-8]");
					if (0 == (nint)obj25)
					{
						break;
					}
					obj3 = obj26 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>>)+12E]");
					num3 = (int)(-1);
					bool flag6 = num3 != 1;
					obj26 = obj3;
					if (flag6)
					{
						continue;
					}
					goto IL_06a6;
				}
				num3 = (int)obj26;
				object obj27 = num8 + obj26;
				object obj28 = obj27 + 312;
				obj3 = obj26;
				goto IL_09e6;
				IL_099a:
				bool flag7 = obj24 == null;
				object obj29 = !flag7;
				if (obj29 == null)
				{
					return;
				}
				OutOfMemoryException ex = new OutOfMemoryException();
				if ((nint)text != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj24 = obj30;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj23 = obj30;
				continue;
				IL_06a6:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				enumerable = null;
				goto IL_09e6;
				IL_09e6:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X0_v6+8]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v720 @ X0_v6] (should have been resolved before IL gen)");
				goto IL_099a;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_043d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			enumerable = null;
			goto IL_092d;
			IL_092d:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v749 @ X0_v33] (should have been resolved before IL gen)");
			IEnumerable<FriendLeaderboardModel> enumerable6 = (IEnumerable<FriendLeaderboardModel>)base.data;
			num3 = lastItemIndex + 1;
			lastItemIndex = num3;
			object obj31 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num9, 2));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj32 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num9, 4));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			bool flag8 = enumerable6 == null;
			num = lastItemIndex;
			if (!flag8)
			{
				num = (int)obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>)+1C]");
				object obj33 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>)+10]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>)+18]");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>)+18]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X9_v3 (System.Int32)+18]");
					bool flag9 = num10 < 0;
					object obj34 = !flag9;
					if (obj34 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v5 (System.Int32)+20]");
						object obj35 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v784 @ X8_v34+C0]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v5 (System.Int32)+70]");
						enumerable = (IEnumerable<FriendLeaderboardModel>)0;
						((List<object>)enumerable6).AddWithResize(obj36);
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>)+18]");
						num = (int)((nint)0 + (nint)1);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>)+10]");
						nint num11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v759 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendLeaderboardModel>)+18]");
						object obj37 = num11 + 0;
						object obj38 = obj37 + 32;
						obj38 = obj36;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					bool flag10 = enumerable3 == null;
					num9 = lastItemIndex;
					int num12 = lastItemIndex;
					obj11 = obj39;
					num4 = lastItemIndex;
					enumerable5 = enumerable3;
					num9 = lastItemIndex;
					num12 = lastItemIndex;
					obj12 = obj39;
					num5 = lastItemIndex;
					enumerable2 = enumerable;
					obj3 = obj13;
					obj6 = obj36;
					if (!flag10)
					{
						continue;
					}
					goto IL_072e;
				}
			}
			goto IL_06eb;
			IL_0328:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			enumerable = null;
			goto IL_08cb;
		}
		NullReferenceException ex2 = new NullReferenceException();
		obj12 = obj11;
		num5 = num4;
		enumerable2 = enumerable;
		obj3 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v29+8]");
		text = (string)0;
		goto IL_0783;
		IL_0a22:
		throw new NullReferenceException();
		IL_0783:
		enumerable4 = enumerable3;
		obj23 = 0;
		enumerable = enumerable2;
		goto IL_0a22;
		IL_06eb:
		NullReferenceException ex3 = new NullReferenceException();
		num9 = lastItemIndex;
		obj12 = obj39;
		num5 = lastItemIndex;
		enumerable2 = enumerable;
		obj3 = obj13;
		text = (string)obj36;
		goto IL_0783;
		IL_072e:
		NullReferenceException ex4 = new NullReferenceException();
		text = (string)obj6;
		goto IL_0783;
		IL_00dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		enumerable2 = null;
		goto IL_0866;
	}

	public FriendsLeaderboardView()
	{
		((UiListView<object, object>)(object)this)..ctor();
	}
}
