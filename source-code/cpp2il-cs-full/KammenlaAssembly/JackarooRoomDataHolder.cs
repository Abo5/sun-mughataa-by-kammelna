using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;

public class JackarooRoomDataHolder : RoomDataHolder
{
	public new JackarooGameRoomData Room
	{
		get
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0029: Expected I, but got O
			//IL_0052: Expected O, but got I4
			//IL_0086: Expected O, but got I
			JackarooGameRoomData jackarooGameRoomData = (JackarooGameRoomData)base.<Room>k__BackingField;
			if (base.<Room>k__BackingField != null)
			{
				object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 216;
				object obj2 = obj;
				nint num = (nint)jackarooGameRoomData;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<JackarooGameRoomData>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v6 (Il2CppClass<JackarooGameRoomData>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X1_v2+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v9-8]");
					if (0 == (nint)obj2)
					{
						goto IL_00ad;
					}
				}
				return (JackarooGameRoomData)(object)new InvalidCastException();
			}
			goto IL_00ad;
			IL_00ad:
			return (JackarooGameRoomData)base.<Room>k__BackingField;
		}
	}

	public JackarooRoomDataHolder(JackarooGameRoomData room, int index)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_003d: Expected O, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		object obj = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3016;
		object obj2 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3008;
		((object)this)..ctor();
		object obj3 = this + 16;
		obj3 = room;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base.<index>k__BackingField = index;
		bool isTablet = ScreenUtility.IsTablet;
		object obj4 = ((~(object)isTablet != null) ? obj2 : obj);
		object obj5 = this + 32;
		obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
