using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;

public class JackarooRoomListView : UiListView<RoomDataHolder, JackarooRoomCard>
{
	public void SetRooms<T>(List<T> rooms, bool forceUpdate = false) where T : JackarooGameRoomData
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_01f9: Expected I, but got O
		//IL_0223: Expected O, but got I4
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_015f: Expected O, but got I4
		//IL_00f7: Expected I, but got O
		//IL_0107: Expected O, but got I
		//IL_0130: Expected O, but got I
		//IL_0264: Expected I, but got O
		//IL_01a6: Expected I, but got O
		//IL_01ab: Expected I, but got O
		if (forceUpdate)
		{
			goto IL_0023;
		}
		goto IL_02c7;
		IL_0023:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (JackarooRoomListView)+E8]");
		_ = 0;
		goto IL_02c7;
		IL_02c7:
		IEnumerable enumerable = default(IEnumerable);
		JackarooRoomDataHolder jackarooRoomDataHolder = default(JackarooRoomDataHolder);
		JackarooRoomDataHolder jackarooRoomDataHolder2 = default(JackarooRoomDataHolder);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		nint num2 = default(nint);
		while (true)
		{
			if (rooms != null)
			{
				object obj = typeof(TypeConverter<ushort, char>) + 3136;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				if (rooms._size >= 1)
				{
					if (enumerable == null)
					{
						object room = ((List<object>)(object)rooms).get_Item(0);
						object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 280;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						jackarooRoomDataHolder..ctor((JackarooGameRoomData)room, 0);
						throw new NullReferenceException();
					}
					object obj3 = enumerable + 32;
					object obj4 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 280;
					nint num = num2;
					int num3 = 0;
					while (true)
					{
						object obj5 = ((List<object>)(object)rooms).get_Item(num3);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						jackarooRoomDataHolder2..ctor((JackarooGameRoomData)obj5, num3);
						bool flag = jackarooRoomDataHolder2 == null;
						JackarooGameRoomData jackarooGameRoomData = (JackarooGameRoomData)obj5;
						JackarooGameRoomData jackarooGameRoomData2;
						if (!flag)
						{
							nint num4 = (nint)enumerable;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v23 (Il2CppClass<System.Collections.IEnumerable>)+40]");
							jackarooGameRoomData = (JackarooGameRoomData)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag2 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v23 (Il2CppClass<System.Collections.IEnumerable>)+40]");
							jackarooGameRoomData2 = (JackarooGameRoomData)0;
							if (flag2)
							{
								goto IL_024c;
							}
						}
						int num5 = num3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v11 (System.Collections.IEnumerable)+18]");
						bool flag3 = (nint)num5 < (nint)0;
						object obj6 = !flag3;
						if (obj6 == null)
						{
							obj3 = jackarooRoomDataHolder2;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							num3++;
							bool flag4 = num3 < rooms._size;
							num2 = unchecked((nint)null);
							num = unchecked((nint)null);
							if (!flag4)
							{
								break;
							}
							continue;
						}
						ex = new IndexOutOfRangeException();
						jackarooGameRoomData2 = jackarooGameRoomData;
						goto IL_024c;
						IL_024c:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
						OutOfMemoryException ex2 = new OutOfMemoryException();
						num2 = unchecked((nint)null);
						goto IL_0269;
					}
				}
				IEnumerable<object> source = Enumerable.Cast<object>(enumerable);
				List<object> list = Enumerable.ToList(source);
				if ((object)this != null)
				{
					nint num6 = (nint)this;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v258 @ X8_v16 (Il2CppClass<JackarooRoomListView>)+2A8] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
					bool flag5 = !forceUpdate;
					object obj7 = !flag5;
					if (obj7 != null)
					{
						break;
					}
					continue;
				}
			}
			goto IL_0269;
			IL_0269:
			throw new NullReferenceException();
		}
		goto IL_0023;
	}

	public JackarooRoomListView()
	{
		((UiListView<object, object>)(object)this)..ctor();
	}
}
