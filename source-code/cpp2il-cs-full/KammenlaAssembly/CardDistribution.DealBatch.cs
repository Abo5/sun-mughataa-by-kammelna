using System;
using Cpp2ILInjected;
using Unity.Properties;

namespace CardDistribution;

public struct DealBatch
{
	private readonly int <CardsPerPlayer>k__BackingField;

	private readonly int <BatchIndex>k__BackingField;

	public int CardsPerPlayer => <CardsPerPlayer>k__BackingField;

	public bool IsFirstBatch => <BatchIndex>k__BackingField == 0;

	public int BatchIndex => <BatchIndex>k__BackingField;

	private DealBatch(int cardsPerPlayer, int batchIndex)
	{
		<CardsPerPlayer>k__BackingField = cardsPerPlayer;
		<BatchIndex>k__BackingField = batchIndex;
	}

	public static DealBatch[] BuildFromConfig(int[] cardsPerBatch)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0084: Expected O, but got I4
		//IL_008d: Expected O, but got I4
		//IL_0143: Expected O, but got I4
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		DealBatch[] array = default(DealBatch[]);
		if (cardsPerBatch != null)
		{
			object obj = typeof(TypeConverter<ushort, char>) + 2208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			if (cardsPerBatch.Length < 1)
			{
				goto IL_00ea;
			}
			if (array != null)
			{
				object obj2 = cardsPerBatch + 32;
				object obj3 = array + 32;
				object obj4 = 0;
				object obj5 = 0;
				while (true)
				{
					bool flag = (nint)obj4 < array.Length;
					object obj6 = !flag;
					if (obj6 != null)
					{
						break;
					}
					object obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X10_v3+v57 @ X9_v4*4]");
					object obj8 = obj7 + 0;
					obj4++;
					obj5 += 4294967296L;
					if ((nint)obj4 < cardsPerBatch.Length)
					{
						continue;
					}
					goto IL_00ea;
				}
				IndexOutOfRangeException ex = new IndexOutOfRangeException();
			}
		}
		return (DealBatch[])(object)new NullReferenceException();
		IL_00ea:
		return array;
	}
}
