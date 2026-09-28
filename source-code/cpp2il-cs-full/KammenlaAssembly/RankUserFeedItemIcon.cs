using System;
using Cpp2ILInjected;
using Server.Models;

public class RankUserFeedItemIcon : UserFeedItemIcon
{
	private RankUIModular rank;

	public override void Populate(UserFeedItem feedItem, Action onReady)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0058: Expected O, but got I
		//IL_0093: Expected O, but got I
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0156: Expected O, but got I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		object obj = typeof(System.IOAsyncCallback) + 616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
		object obj2 = default(object);
		if (obj2 != null)
		{
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v5+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v5+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00d4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v5+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X10_v7-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00d4;
			}
			object obj6 = obj3 + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v110 @ X8_v9] (should have been resolved before IL gen)");
			bool flag = (object)rank == null;
			object obj8 = !flag;
			if (obj8 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00ed;
		}
		goto IL_010b;
		IL_00d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v211 @ X0_v10] (should have been resolved before IL gen)");
		goto IL_00ed;
		IL_00ed:
		PlayerRank.Ranks ranks = default(PlayerRank.Ranks);
		rank.SetRank(ranks);
		goto IL_010b;
		IL_010b:
		Actions.SafeInvoke(onReady);
	}
}
