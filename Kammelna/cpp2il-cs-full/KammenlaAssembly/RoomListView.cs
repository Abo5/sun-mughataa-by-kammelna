using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Cpp2ILInjected;
using Unity.Properties;

public class RoomListView : UiListView<RoomDataHolder, RoomCard>
{
	public void SetRooms(List<GameRoomData> rooms, bool forceUpdate = false)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_0052: Expected O, but got I4
		//IL_02c4: Expected O, but got I4
		//IL_0260: Expected O, but got I
		//IL_0287: Expected O, but got I4
		//IL_029c: Expected O, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_0207: Expected I, but got O
		//IL_0217: Expected O, but got I
		//IL_0227: Expected O, but got I
		//IL_00d6: Expected O, but got I
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031a: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_0366: Expected O, but got I4
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_0147: Expected O, but got I4
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Expected O, but got Unknown
		//IL_03f3: Expected I, but got O
		//IL_0403: Expected O, but got I
		//IL_0199: Expected O, but got I4
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7A5D]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 == null)
		{
			goto IL_0231;
		}
		bool flag2 = default(bool);
		bool flag = !flag2;
		object obj3 = !flag;
		if (obj3 == null)
		{
			goto IL_0060;
		}
		goto IL_0250;
		IL_0250:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomListView)+E8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomListView)+E8]");
		_ = 0;
		bool flag3 = rooms == null;
		object obj5 = !flag3;
		RoomListView roomListView = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (RoomListView)+E8]");
		object obj6 = 0;
		if (obj5 != null)
		{
			goto IL_008a;
		}
		goto IL_02aa;
		IL_0060:
		bool flag4 = rooms == null;
		roomListView = this;
		obj6 = obj4;
		if (!flag4)
		{
			goto IL_008a;
		}
		goto IL_02aa;
		IL_008a:
		object obj7 = typeof(TypeConverter<ushort, char>) + 3752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		if (rooms._size < 1)
		{
			goto IL_01f1;
		}
		object obj8 = (nint)0 + (nint)2720;
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		NullReferenceException ex = default(NullReferenceException);
		List<GameRoomData> list;
		if (enumerable != null)
		{
			object obj9 = enumerable + 32;
			object obj10 = "Read object reference Id '{0}' for {1}." + 3352;
			object obj11 = "Read object reference Id '{0}' for {1}." + 3344;
			int num = 0;
			object obj14 = default(object);
			while (true)
			{
				object obj12 = ((List<object>)(object)rooms).get_Item(num);
				object obj13 = typeof(RegisteredWaitHandle) + 1384;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj14..ctor();
				object obj15 = obj14 + 16;
				obj15 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool isTablet = ScreenUtility.IsTablet;
				bool flag5 = !isTablet;
				object obj16 = !flag5;
				object obj17 = ~obj16;
				object obj18 = ((obj17 != null) ? obj11 : obj10);
				object obj19 = obj14 + 32;
				obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				nint num2 = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v32 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				list = (List<GameRoomData>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag6 = ex == null;
				obj6 = obj4;
				if (flag6)
				{
					break;
				}
				int num3 = num;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v47 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
				bool flag7 = (nint)num3 < (nint)0;
				object obj20 = !flag7;
				obj6 = obj4;
				if (obj20 == null)
				{
					obj9 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num++;
					if (num < rooms._size)
					{
						continue;
					}
					goto IL_01f1;
				}
				goto IL_02e1;
			}
			goto IL_02c9;
		}
		object obj21 = ((List<object>)(object)rooms).get_Item(0);
		object obj22 = typeof(RegisteredWaitHandle) + 1384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = default(object);
		obj23..ctor();
		object obj24 = obj23 + 16;
		obj24 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_ = 0;
		bool isTablet2 = ScreenUtility.IsTablet;
		object obj25 = "Read object reference Id '{0}' for {1}." + 3352;
		object obj26 = "Read object reference Id '{0}' for {1}." + 3344;
		bool flag8 = !isTablet2;
		object obj27 = !flag8;
		object obj28 = ~obj27;
		if (obj28 != null)
		{
			obj25 = obj26;
		}
		object obj29 = obj23 + 32;
		obj29 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		throw new NullReferenceException();
		IL_02c9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		goto IL_02e1;
		IL_02aa:
		ex = new NullReferenceException();
		list = rooms;
		obj8 = 152989696;
		goto IL_02c9;
		IL_01f1:
		List<object> list2 = Enumerable.ToList(enumerable);
		nint num4 = (nint)roomListView;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v25 (Il2CppClass<RoomListView>)+2A8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v25 (Il2CppClass<RoomListView>)+2B0]");
		object obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v279 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_0231;
		IL_0231:
		_ = 1;
		if (!flag2)
		{
			goto IL_0060;
		}
		goto IL_0250;
		IL_02e1:
		obj4 = obj6;
		throw new IndexOutOfRangeException();
	}

	public RoomListView()
	{
		((UiListView<object, object>)(object)this)..ctor();
	}
}
