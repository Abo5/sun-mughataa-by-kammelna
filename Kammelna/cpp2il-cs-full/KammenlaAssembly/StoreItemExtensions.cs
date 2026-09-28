using System.Collections.Generic;

public static class StoreItemExtensions
{
	public static bool IsAnimatedRoomTheme(StoreItem item)
	{
		//IL_00ad: Expected O, but got I4
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected I4, but got Unknown
		if (item != null)
		{
			List<AnimatedRoomFileInfoGroup> <animatedRoomFileInfoGroups>k__BackingField = item.<animatedRoomFileInfoGroups>k__BackingField;
			if (item.<animatedRoomFileInfoGroups>k__BackingField != null)
			{
				bool flag = <animatedRoomFileInfoGroups>k__BackingField._size < 0;
				bool flag2 = <animatedRoomFileInfoGroups>k__BackingField._size == 0;
				int num = <animatedRoomFileInfoGroups>k__BackingField._size ^ <animatedRoomFileInfoGroups>k__BackingField._size;
				int num2 = <animatedRoomFileInfoGroups>k__BackingField._size & num;
				bool flag3 = num2 < 0;
				bool flag4 = flag == flag3;
				object obj = !flag2;
				return (byte)((flag4 & obj) ? 1 : 0) != 0;
			}
		}
		return false;
	}
}
