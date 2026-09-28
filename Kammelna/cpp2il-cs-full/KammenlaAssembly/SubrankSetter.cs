using System;
using UnityEngine;

[Serializable]
public class SubrankSetter : IRankSubSetter
{
	private GameObject[] subRanks;

	public string Label => "SetRoomVariables request error" + 3968;

	public void Set(PlayerRank playerRank)
	{
		//IL_042b: Expected O, but got I4
		//IL_0445: Expected O, but got I4
		//IL_00fa: Expected O, but got I4
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected I4, but got Unknown
		//IL_0137: Expected O, but got I8
		//IL_0183: Expected O, but got I4
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected I4, but got Unknown
		//IL_01fb: Expected O, but got I4
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected I4, but got Unknown
		//IL_0240: Expected O, but got I4
		//IL_0286: Expected O, but got I4
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected I4, but got Unknown
		//IL_02fe: Expected O, but got I4
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected I4, but got Unknown
		//IL_033b: Expected O, but got I8
		//IL_0387: Expected O, but got I4
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected I4, but got Unknown
		//IL_03ff: Expected O, but got I4
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected I4, but got Unknown
		GameObject[] array = subRanks;
		if (subRanks == null || array.Length < 4)
		{
			return;
		}
		GameObject[] array2;
		if (playerRank != null)
		{
			GameObject gameObject = array[0].gameObject;
			bool flag = playerRank.<SubRanksCount>k__BackingField < 0;
			bool flag2 = playerRank.<SubRanksCount>k__BackingField == 0;
			int num = playerRank.<SubRanksCount>k__BackingField ^ playerRank.<SubRanksCount>k__BackingField;
			int num2 = playerRank.<SubRanksCount>k__BackingField & num;
			bool flag3 = num2 < 0;
			bool flag4 = flag == flag3;
			object obj = !flag2;
			bool active = (byte)((flag4 & obj) ? 1 : 0) != 0;
			gameObject.SetActive(active);
			array = subRanks;
			object obj2 = array.Length & 0xFFFFFFFEL;
			if (obj2 != null)
			{
				GameObject gameObject2 = array[1].gameObject;
				object obj3 = playerRank.<SubRanksCount>k__BackingField - 1;
				bool flag5 = (nint)obj3 < 0;
				bool flag6 = obj3 == null;
				int num3 = playerRank.<SubRanksCount>k__BackingField ^ 1;
				int num4 = playerRank.<SubRanksCount>k__BackingField ^ obj3;
				int num5 = num3 & num4;
				bool flag7 = num5 < 0;
				bool flag8 = flag5 == flag7;
				object obj4 = !flag6;
				bool active2 = (byte)((flag8 & obj4) ? 1 : 0) != 0;
				gameObject2.SetActive(active2);
				array = subRanks;
				bool flag9 = array.Length < 3;
				object obj5 = !flag9;
				object obj6 = ~obj5;
				if (obj6 == null)
				{
					GameObject gameObject3 = array[2].gameObject;
					object obj7 = playerRank.<SubRanksCount>k__BackingField - 2;
					bool flag10 = (nint)obj7 < 0;
					bool flag11 = obj7 == null;
					int num6 = playerRank.<SubRanksCount>k__BackingField ^ 2;
					int num7 = playerRank.<SubRanksCount>k__BackingField ^ obj7;
					int num8 = num6 & num7;
					bool flag12 = num8 < 0;
					bool flag13 = flag10 == flag12;
					object obj8 = !flag11;
					bool active3 = (byte)((flag13 & obj8) ? 1 : 0) != 0;
					gameObject3.SetActive(active3);
					array = subRanks;
					object obj9 = array.Length & 0xFFFFFFFCL;
					if (obj9 != null)
					{
						GameObject gameObject4 = array[3].gameObject;
						object obj10 = playerRank.<SubRanksCount>k__BackingField - 3;
						bool flag14 = (nint)obj10 < 0;
						bool flag15 = obj10 == null;
						int num9 = playerRank.<SubRanksCount>k__BackingField ^ 3;
						int num10 = playerRank.<SubRanksCount>k__BackingField ^ obj10;
						int num11 = num9 & num10;
						bool flag16 = num11 < 0;
						bool flag17 = flag14 == flag16;
						object obj11 = !flag15;
						bool active4 = (byte)((flag17 & obj11) ? 1 : 0) != 0;
						gameObject4.SetActive(active4);
						return;
					}
				}
			}
		}
		else
		{
			object obj12 = array.Length & 0x7FFFFFFF;
			bool flag18 = obj12 == null;
			object obj13 = !flag18;
			array2 = subRanks;
			if (obj13 != null)
			{
				GameObject gameObject5 = array2[0].gameObject;
				throw new NullReferenceException();
			}
		}
		array2 = array;
		throw new IndexOutOfRangeException();
	}
}
