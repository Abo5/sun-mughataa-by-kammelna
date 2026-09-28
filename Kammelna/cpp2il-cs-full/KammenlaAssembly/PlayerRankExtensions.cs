using System;
using System.Buffers.Text;
using System.Collections.Generic;
using Cpp2ILInjected;

public static class PlayerRankExtensions
{
	public static PlayerRank.Ranks PreviousRank(PlayerRank.Ranks rank)
	{
		return rank - 1;
	}

	public static int MinPointsToRank(PlayerRank.Ranks rank, Games game)
	{
		//IL_00eb: Expected O, but got I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		//IL_00d1: Expected I4, but got O
		bool flag = rank < PlayerRank.Ranks.Intermediate;
		object obj = !flag;
		if (obj == null)
		{
			return 0;
		}
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v2+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Dictionary<PlayerRank.Ranks, int> ranksLimit = PlayerRank.GetRanksLimit(game);
		if (ranksLimit != null)
		{
			System.Int32Enum key = (System.Int32Enum)(rank - 1);
			int num = ((Dictionary<System.Int32Enum, int>)(object)ranksLimit).get_Item(key);
			return num + 1;
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public static int MaxPointsToRank(PlayerRank.Ranks rank, Games game)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_00b5: Expected I4, but got O
		if (rank != PlayerRank.Ranks.AI)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Dictionary<PlayerRank.Ranks, int> ranksLimit = PlayerRank.GetRanksLimit(game);
			if (ranksLimit != null)
			{
				return ((Dictionary<System.Int32Enum, int>)(object)ranksLimit).get_Item((System.Int32Enum)rank);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
		return 0;
	}
}
