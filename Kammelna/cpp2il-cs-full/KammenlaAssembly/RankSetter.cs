using System.Buffers.Text;
using Cpp2ILInjected;

public abstract class RankSetter : AvatarComponent
{
	public abstract void SetRank(PlayerRank playerRank, bool alsoAnimate = false);

	public abstract void SetAlpha(float alphaValue);

	public void SetRank(int points, bool isNew, bool alsoAnimate = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Expected I, but got O
		//IL_0049: Expected O, but got I
		//IL_0059: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(points, isNew);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3 (Il2CppClass<RankSetter>)+1A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3 (Il2CppClass<RankSetter>)+1B0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void SetRank(PlayerRank.Ranks rank, bool isNew = false, bool alsoAnimate = false)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0039: Expected I, but got O
		//IL_0049: Expected O, but got I
		//IL_0059: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerRank playerRank = default(PlayerRank);
		playerRank..ctor(rank, isNew);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3 (Il2CppClass<RankSetter>)+1A8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3 (Il2CppClass<RankSetter>)+1B0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}
}
