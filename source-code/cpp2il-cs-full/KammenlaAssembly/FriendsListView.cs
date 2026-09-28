using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using ListView;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Unity.Properties;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class FriendsListView : UiListView<IListViewItemData<int>, ListViewItem<IListViewItemData<int>, int>>
{
	private string listItemTemplateName = "LAK" + 1816;

	private int lastItemIndex;

	private bool ShouldUpdateView
	{
		get
		{
			//IL_00fd: Expected I4, but got O
			//IL_00f3: Expected I4, but got O
			//IL_0061: Expected O, but got I
			//IL_00c5: Expected O, but got I4
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected I4, but got Unknown
			bool flag = (byte)(int)base.data != 0;
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [returnVal1 @ X0_v4 (System.Boolean)+18]");
				if ((nint)0 < (nint)1)
				{
					return false;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendsListView)+A8]");
				if ((nint)0 == 0)
				{
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendsListView)+A8]");
				int count = ((Dictionary<object, object>)0).Count;
				bool flag2 = count < 0;
				bool flag3 = count == 0;
				int num = count ^ count;
				int num2 = count & num;
				bool flag4 = num2 < 0;
				bool flag5 = flag2 == flag4;
				object obj = !flag3;
				bool flag6 = (byte)((flag5 & obj) ? 1 : 0) != 0;
				flag = flag6;
			}
			return flag;
		}
	}

	public void SetData(IEnumerable<FriendProfile> friends)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0053: Expected O, but got I
		//IL_0079: Expected I, but got O
		//IL_0089: Expected O, but got I
		//IL_0099: Expected O, but got I
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		base.data = (List<IListViewItemData<int>>)(object)list;
		lastItemIndex = 0;
		AddFriendsListData(listItemTemplateName, friends);
		List<IListViewItemData<int>> list2 = base.data;
		if (list2 != null && list2._size >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendsListView)+A8]");
			int count = ((Dictionary<object, object>)0).Count;
			if (count >= 1)
			{
				nint num = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v11 (Il2CppClass<FriendsListView>)+1B8]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v11 (Il2CppClass<FriendsListView>)+1C0]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v157 @ X2_v3 (should have been resolved before IL gen)");
			}
		}
	}

	public unsafe void SetData(IEnumerable<FriendListSection> sections)
	{
		//IL_0653: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected O, but got Unknown
		//IL_0664: Expected O, but got I
		//IL_092f: Expected I, but got O
		//IL_093f: Expected O, but got I
		//IL_094f: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c9: Expected O, but got Unknown
		//IL_06d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06dd: Expected O, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f1: Expected O, but got Unknown
		//IL_0701: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_05bf: Expected O, but got I4
		//IL_0155: Expected O, but got I
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_009d: Expected O, but got I
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_0761: Expected I, but got O
		//IL_0771: Expected O, but got I
		//IL_0784: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Expected O, but got Unknown
		//IL_0190: Expected O, but got I
		//IL_03f7: Expected O, but got I4
		//IL_0400: Expected O, but got I4
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0730: Expected O, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0854: Expected O, but got I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_041d: Expected O, but got I
		//IL_0296: Expected O, but got I
		//IL_08b2: Expected I, but got O
		//IL_08c2: Expected O, but got I
		//IL_08d2: Expected O, but got I
		//IL_088e: Expected I, but got O
		//IL_089e: Expected O, but got I
		//IL_0458: Expected O, but got I
		//IL_07f6: Expected O, but got I
		//IL_02d1: Expected O, but got I
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bd: Expected O, but got Unknown
		//IL_04db: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e0: Expected O, but got Unknown
		//IL_03b2: Expected O, but got I
		//IL_03c2: Expected O, but got I
		//IL_03e0: Expected O, but got I
		//IL_03e0: Expected O, but got I
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_0481: Expected O, but got I
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_0302: Expected O, but got I
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		//IL_054b: Expected O, but got I
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3616;
		object obj2 = (nint)0 + (nint)2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v7 (Il2CppClass<FriendsListView>)+2A8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v7 (Il2CppClass<FriendsListView>)+2B0]");
		IEnumerable<FriendProfile> enumerable = (IEnumerable<FriendProfile>)0;
		base.data = (List<IListViewItemData<int>>)(object)list;
		lastItemIndex = 0;
		bool flag = sections == null;
		List<object> list2 = list;
		if (flag)
		{
			goto IL_0669;
		}
		object obj4 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3184;
		nint num2 = (nint)sections;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendListSection>>)+12E]");
		obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendListSection>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00f1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendListSection>>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		bool flag3 = default(bool);
		bool flag2 = flag3;
		object obj7;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X10_v29-8]");
			object obj6 = 0 - obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X10_v29-8]");
			if (0 == (nint)obj4)
			{
				break;
			}
			obj7 = obj5 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendListSection>>)+12E]");
			obj3 = -1;
			obj6 = obj3 - 1;
			bool flag4 = obj6 == null;
			flag3 = (nint)obj3 != 1;
			flag2 = flag3;
			obj5 = obj7;
			if (flag3)
			{
				continue;
			}
			goto IL_00f1;
		}
		obj3 = obj5;
		object obj8 = num2 + obj5;
		object obj9 = obj8 + 312;
		flag3 = flag2;
		obj7 = obj5;
		goto IL_06b5;
		IL_06b5:
		object obj10 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 560;
		obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X0_v41+8]");
		string text = (string)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v286 @ X0_v41] (should have been resolved before IL gen)");
		object obj11 = default(object);
		num = (nint)(&obj11);
		object obj12 = default(object);
		object obj16 = default(object);
		object obj18 = default(object);
		object obj28 = default(object);
		object obj30 = default(object);
		object obj31 = default(object);
		while (true)
		{
			if (obj12 != null)
			{
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v31+12E]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v31+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0215;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v31+B0]");
				object obj14 = (nint)0 + (nint)8;
				bool flag5 = flag3;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X10_v24-8]");
					object obj6 = 0 - obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X10_v24-8]");
					if (0 == (nint)obj10)
					{
						break;
					}
					obj7 = obj14 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v31+12E]");
					obj3 = -1;
					obj6 = obj3 - 1;
					bool flag4 = obj6 == null;
					flag3 = (nint)obj3 != 1;
					flag5 = flag3;
					obj14 = obj7;
					if (flag3)
					{
						continue;
					}
					goto IL_0215;
				}
				obj3 = obj14;
				object obj15 = obj13 + obj14;
				obj16 = obj15 + 312;
				flag3 = flag5;
				obj7 = obj14;
				goto IL_0759;
			}
			NullReferenceException ex = new NullReferenceException();
			list2 = (List<object>)(object)text;
			goto IL_05ac;
			IL_0759:
			num = (nint)obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X0_v47+8]");
			list2 = (List<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v455 @ X0_v47] (should have been resolved before IL gen)");
			object obj17 = obj18 & 1;
			if (obj17 != null)
			{
				if (obj12 != null)
				{
					object obj19 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v34+12E]");
					obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v34+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0356;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v34+B0]");
					object obj20 = (nint)0 + (nint)8;
					bool flag6 = flag3;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X10_v19-8]");
						object obj6 = 0 - obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X10_v19-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj7 = obj20 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v34+12E]");
						obj3 = -1;
						obj6 = obj3 - 1;
						bool flag4 = obj6 == null;
						flag3 = (nint)obj3 != 1;
						flag6 = flag3;
						obj20 = obj7;
						if (flag3)
						{
							continue;
						}
						goto IL_0356;
					}
					obj3 = obj20;
					object obj21 = obj19 + obj20;
					object obj22 = obj21 + 312;
					flag3 = flag6;
					obj7 = obj20;
					goto IL_07e6;
				}
				NullReferenceException ex2 = new NullReferenceException();
				goto IL_05ac;
			}
			obj11 = obj12;
			object obj23 = 0;
			object obj24 = 0;
			while (true)
			{
				if (obj11 == null)
				{
					goto IL_083a;
				}
				object obj25 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v17+12E]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v17+12E]");
				if ((nint)0 == 0)
				{
					goto IL_04a9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v17+B0]");
				object obj26 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X10_v7-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj7 = obj26 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v17+12E]");
					obj3 = -1;
					bool flag7 = (nint)obj3 != 1;
					obj26 = obj7;
					if (flag7)
					{
						continue;
					}
					goto IL_04a9;
				}
				obj3 = obj26;
				object obj27 = obj25 + obj26;
				obj28 = obj27 + 312;
				obj7 = obj26;
				goto IL_0886;
				IL_083a:
				bool flag8 = obj24 == null;
				object obj29 = !flag8;
				if (obj29 == null)
				{
					break;
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				if ((nint)list2 == 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
					obj24 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
					obj23 = obj30;
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
				return;
				IL_04a9:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				enumerable = null;
				goto IL_0886;
				IL_0886:
				num = (nint)obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X0_v23+8]");
				list2 = (List<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v633 @ X0_v23] (should have been resolved before IL gen)");
				goto IL_083a;
			}
			nint num3 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v10 (Il2CppClass<FriendsListView>)+298]");
			obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v10 (Il2CppClass<FriendsListView>)+2A0]");
			list2 = (List<object>)0;
			List<IListViewItemData<int>> list3 = base.data;
			if (list3 != null && list3._size >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendsListView)+A8]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendsListView)+A8]");
				int count = ((Dictionary<object, object>)0).Count;
				if (count > 0)
				{
					base.UpdateView();
				}
			}
			return;
			IL_07e6:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X0_v51+8]");
			list2 = (List<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v681 @ X0_v51] (should have been resolved before IL gen)");
			if (obj31 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X0_v53+10]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X0_v53+18]");
				enumerable = (IEnumerable<FriendProfile>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X0_v53+10]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X0_v53+18]");
				CreateSublist((string)num4, (IEnumerable<FriendProfile>)0);
				continue;
			}
			NullReferenceException ex4 = new NullReferenceException();
			goto IL_05ac;
			IL_05ac:
			obj11 = obj12;
			obj23 = 0;
			break;
			IL_0356:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			enumerable = null;
			goto IL_07e6;
			IL_0215:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			enumerable = null;
			goto IL_0759;
		}
		goto IL_0669;
		IL_0669:
		throw new NullReferenceException();
		IL_00f1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		enumerable = null;
		goto IL_06b5;
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

	private void CreateSublist(string listHeaderTemplateName, IEnumerable<FriendProfile> friendsList)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_00d9: Expected O, but got I
		//IL_0118: Expected O, but got I4
		//IL_007d: Expected O, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 2488;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object[] array = default(object[]);
		object[] array2;
		object[] array3;
		if (array != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			array2 = array;
			array3 = array;
			if (!flag)
			{
				goto IL_0056;
			}
		}
		else
		{
			object obj5 = (nint)0 + (nint)1272;
			obj3 = obj5;
			object[] array4 = Enumerable.ToArray((IEnumerable<object>)friendsList);
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v4+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			array2 = array4;
			array3 = array4;
			if (obj6 != null)
			{
				goto IL_0056;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = StringsExtensions.IsNullOrEmpty(listHeaderTemplateName);
		bool flag4 = !flag3;
		array2 = array3;
		if (flag4)
		{
			goto IL_0093;
		}
		goto IL_00bc;
		IL_00bc:
		AddFriendsListData(listItemTemplateName, (IEnumerable<FriendProfile>)array3);
		return;
		IL_0093:
		int headerCount = Enumerable.Count(array2);
		AddHeaderData(listHeaderTemplateName, headerCount);
		array3 = array2;
		goto IL_00bc;
		IL_0056:
		bool flag5 = StringsExtensions.IsNullOrEmpty(listHeaderTemplateName);
		bool flag6 = !flag5;
		object obj7 = !flag6;
		array3 = array2;
		if (obj7 == null)
		{
			goto IL_0093;
		}
		goto IL_00bc;
	}

	private unsafe void AddHeaderData(string listHeaderTemplateNam, int headerCount)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0110: Expected O, but got Ref
		//IL_006d: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1408;
		List<IListViewItemData<int>> list = base.data;
		int num = lastItemIndex + 1;
		lastItemIndex = num;
		object obj3 = default(object);
		object obj2 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref obj3, 8));
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		int version = ((List<object>)(object)list)._version + 1;
		((List<object>)(object)list)._version = version;
		object[] items = ((List<object>)(object)list)._items;
		bool flag = ((List<object>)(object)list)._size < items.Length;
		object obj4 = !flag;
		object obj7 = default(object);
		if (obj4 == null)
		{
			int num2 = ((List<object>)(object)list)._size + 1;
			((List<object>)(object)list)._size = num2;
			object obj5 = items + ((List<object>)(object)list)._size;
			object obj6 = obj5 + 32;
			obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			((List<object>)(object)list).AddWithResize(obj7);
		}
	}

	private unsafe void AddFriendsListData(string listItemTemplateName, IEnumerable<FriendProfile> friendsList)
	{
		//IL_0010: Expected O, but got I
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0031: Expected I, but got O
		//IL_0041: Expected O, but got I
		//IL_0844: Expected O, but got I
		//IL_0865: Expected O, but got Ref
		//IL_007c: Expected O, but got I
		//IL_0764: Expected O, but got I4
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_0179: Expected O, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0264: Expected I, but got O
		//IL_0274: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00ad: Expected O, but got I
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected O, but got Unknown
		//IL_02af: Expected O, but got I
		//IL_059d: Expected O, but got I4
		//IL_05be: Expected O, but got I
		//IL_05c7: Expected O, but got I4
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0997: Expected O, but got I4
		//IL_074c: Expected O, but got I
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_02e0: Expected O, but got I
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected O, but got Unknown
		//IL_05e8: Expected I, but got O
		//IL_05f8: Expected O, but got I
		//IL_0381: Expected I, but got O
		//IL_0391: Expected O, but got I
		//IL_09d9: Expected O, but got I
		//IL_0633: Expected O, but got I
		//IL_090a: Expected I, but got O
		//IL_091a: Expected O, but got I
		//IL_094c: Expected O, but got Ref
		//IL_0964: Expected O, but got Ref
		//IL_03cc: Expected O, but got I
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected O, but got Unknown
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected O, but got Unknown
		//IL_0441: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0454: Expected O, but got Unknown
		//IL_0641: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected O, but got Unknown
		//IL_065c: Expected O, but got I
		//IL_04ac: Expected O, but got I
		//IL_04c1: Expected O, but got I
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f5: Expected O, but got Unknown
		//IL_04f6: Expected O, but got I
		//IL_0520: Expected O, but got I4
		//IL_01b0: Expected O, but got I
		//IL_01c0: Expected O, but got I
		//IL_01d0: Expected O, but got I
		//IL_0544: Expected O, but got I
		//IL_0566: Expected O, but got I
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E619C]");
		object obj = 0;
		bool flag2 = default(bool);
		IEnumerable<FriendProfile> enumerable2;
		IEnumerable<FriendProfile> enumerable = default(IEnumerable<FriendProfile>);
		object obj5 = default(object);
		if (enumerable != null)
		{
			object obj2 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3192;
			nint num = (nint)enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendProfile>>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendProfile>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00dd;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendProfile>>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			bool flag = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X10_v31-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj5 = obj4 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v15 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendProfile>>)+12E]");
				obj3 = -1;
				flag2 = (nint)obj3 != 1;
				flag = flag2;
				obj4 = obj5;
				if (flag2)
				{
					continue;
				}
				goto IL_00dd;
			}
			obj3 = obj4;
			object obj6 = num + obj4;
			object obj7 = obj6 + 312;
			enumerable2 = enumerable;
			flag2 = flag;
			obj5 = obj4;
			goto IL_0834;
		}
		goto IL_0a05;
		IL_0834:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v22+8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v306 @ X0_v22] (should have been resolved before IL gen)");
		IEnumerable<FriendProfile> enumerable3 = default(IEnumerable<FriendProfile>);
		bool flag3 = enumerable3 == null;
		IEnumerable<FriendProfile> enumerable4 = default(IEnumerable<FriendProfile>);
		obj = (object)(&enumerable4);
		if (flag3)
		{
			goto IL_0704;
		}
		object obj9 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj10 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 568;
		object obj11 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1424;
		object obj12 = (nint)0 + (nint)2512;
		int num3 = default(int);
		int num2 = num3;
		enumerable = enumerable2;
		object obj13 = obj5;
		IEnumerable<FriendProfile> enumerable5 = enumerable3;
		object obj16 = default(object);
		object obj18 = default(object);
		object obj30 = default(object);
		int num9 = default(int);
		object obj33 = default(object);
		object obj37 = default(object);
		object obj23;
		string text;
		while (true)
		{
			nint num4 = (nint)enumerable5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendProfile>>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendProfile>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0310;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendProfile>>)+B0]");
			object obj14 = (nint)0 + (nint)8;
			bool flag4 = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X10_v26-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				obj13 = obj14 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X8_v22 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendProfile>>)+12E]");
				obj3 = -1;
				flag2 = (nint)obj3 != 1;
				flag4 = flag2;
				obj14 = obj13;
				if (flag2)
				{
					continue;
				}
				goto IL_0310;
			}
			obj3 = obj14;
			object obj15 = num4 + obj14;
			obj16 = obj15 + 312;
			flag2 = flag4;
			obj13 = obj14;
			goto IL_0899;
			IL_0899:
			obj = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v544 @ X0_v29] (should have been resolved before IL gen)");
			object obj17 = obj18 & 1;
			if (obj17 != null)
			{
				if (enumerable3 == null)
				{
					break;
				}
				nint num5 = (nint)enumerable3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendProfile>>)+12E]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendProfile>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0425;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendProfile>>)+B0]");
				object obj20 = (nint)0 + (nint)8;
				bool flag5 = flag2;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X10_v21-8]");
					if (0 == (nint)obj10)
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
					goto IL_0425;
				}
				object obj21 = num5 + obj20;
				object obj22 = obj21 + 312;
				flag2 = flag5;
				obj13 = obj20;
				goto IL_08fb;
			}
			enumerable4 = enumerable3;
			obj23 = 0;
			num3 = num2;
			obj5 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v29+8]");
			text = (string)0;
			object obj24 = 0;
			while (true)
			{
				if (enumerable4 == null)
				{
					goto IL_097d;
				}
				object obj25 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				nint num6 = (nint)enumerable4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendProfile>>)+12E]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendProfile>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0684;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendProfile>>)+B0]");
				object obj26 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X10_v8-8]");
					if (0 == (nint)obj25)
					{
						break;
					}
					obj5 = obj26 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X8_v8 (Il2CppClass<System.Collections.Generic.IEnumerable`1<FriendProfile>>)+12E]");
					obj3 = -1;
					bool flag6 = (nint)obj3 != 1;
					obj26 = obj5;
					if (flag6)
					{
						continue;
					}
					goto IL_0684;
				}
				obj3 = obj26;
				object obj27 = num6 + obj26;
				object obj28 = obj27 + 312;
				obj5 = obj26;
				goto IL_09c9;
				IL_097d:
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
				IL_0684:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				enumerable = null;
				goto IL_09c9;
				IL_09c9:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v6+8]");
				text = (string)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v709 @ X0_v6] (should have been resolved before IL gen)");
				goto IL_097d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_0425:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			enumerable = null;
			goto IL_08fb;
			IL_08fb:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v738 @ X0_v33] (should have been resolved before IL gen)");
			nint num7 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X8_v28 (Il2CppClass<FriendsListView>)+298]");
			obj3 = 0;
			IEnumerable<FriendProfile> enumerable6 = (IEnumerable<FriendProfile>)base.data;
			int num8 = lastItemIndex + 1;
			lastItemIndex = num8;
			object obj31 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num9, 4));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj32 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.Add(ref num9, 2));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			bool flag8 = enumerable6 == null;
			obj = obj33;
			if (!flag8)
			{
				obj = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendProfile>)+1C]");
				object obj34 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendProfile>)+10]");
				obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendProfile>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendProfile>)+18]");
					obj13 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendProfile>)+18]");
					nint num10 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X9_v3+18]");
					bool flag9 = num10 < 0;
					object obj35 = !flag9;
					if (obj35 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v5+20]");
						object obj36 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v35+C0]");
						obj = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v5+70]");
						enumerable = (IEnumerable<FriendProfile>)0;
						((List<object>)enumerable6).AddWithResize(obj37);
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendProfile>)+18]");
						obj = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendProfile>)+10]");
						nint num11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v748 @ X0_v37 (System.Collections.Generic.IEnumerable`1<FriendProfile>)+18]");
						object obj38 = num11 + 0;
						object obj39 = obj38 + 32;
						obj39 = obj37;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					bool flag10 = enumerable3 == null;
					int num12 = lastItemIndex;
					num2 = lastItemIndex;
					num9 = lastItemIndex;
					enumerable5 = enumerable3;
					num12 = lastItemIndex;
					num3 = lastItemIndex;
					num9 = lastItemIndex;
					enumerable2 = enumerable;
					obj5 = obj13;
					obj8 = obj37;
					if (!flag10)
					{
						continue;
					}
					goto IL_0704;
				}
			}
			goto IL_06c9;
			IL_0310:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			enumerable = null;
			goto IL_0899;
		}
		NullReferenceException ex2 = new NullReferenceException();
		num3 = num2;
		enumerable2 = enumerable;
		obj5 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v29+8]");
		text = (string)0;
		goto IL_0751;
		IL_0a05:
		throw new NullReferenceException();
		IL_0751:
		enumerable4 = enumerable3;
		obj23 = 0;
		enumerable = enumerable2;
		goto IL_0a05;
		IL_06c9:
		NullReferenceException ex3 = new NullReferenceException();
		num3 = lastItemIndex;
		num9 = lastItemIndex;
		enumerable2 = enumerable;
		obj5 = obj13;
		text = (string)obj37;
		goto IL_0751;
		IL_0704:
		NullReferenceException ex4 = new NullReferenceException();
		text = (string)obj8;
		goto IL_0751;
		IL_00dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		enumerable2 = null;
		goto IL_0834;
	}

	public FriendsListView()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		object obj = this + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((UiListView<object, object>)(object)this)..ctor();
	}
}
