using System;
using Cpp2ILInjected;
using KammelnaOffline.Common;
using Unity.Properties;

namespace KammelnaOffline.Tarneeb;

public class TarneebBiddingManager : BiddingManager
{
	public override int[] GetNextBidding(int bidderIndex, string bid)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		int[] result = default(int[]);
		return result;
	}

	public override int[] StartBidding()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		object obj = typeof(TypeConverter<ushort, char>) + 3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		int[] array = default(int[]);
		if (array != null)
		{
			if (array.Length != 0)
			{
				array[0] = 1;
				return array;
			}
		}
		else
		{
			NullReferenceException ex = new NullReferenceException();
		}
		return (int[])(object)new IndexOutOfRangeException();
	}
}
