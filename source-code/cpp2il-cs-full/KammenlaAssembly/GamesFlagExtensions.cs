using System.Buffers.Text;
using Cpp2ILInjected;

public static class GamesFlagExtensions
{
	public static GamesFlag CurrentGameFlag
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00b8: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			GamesFlag result = ((currentGame != Games.Tarneeb) ? GamesFlag.Baloot : GamesFlag.Tarneeb);
			if (currentGame == Games.Jackaroo)
			{
				return GamesFlag.Jackaroo;
			}
			return result;
		}
	}

	public static GamesFlag ToFlag(Games game)
	{
		GamesFlag result = ((game != Games.Tarneeb) ? GamesFlag.Baloot : GamesFlag.Tarneeb);
		if (game == Games.Jackaroo)
		{
			return GamesFlag.Jackaroo;
		}
		return result;
	}

	public static bool MatchesCurrentGame(GamesFlag flags)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_00f9: Expected O, but got I4
		//IL_005c: Expected O, but got I4
		//IL_0076: Expected O, but got I4
		//IL_00b2: Expected O, but got I8
		//IL_00a0: Expected O, but got I8
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I8
		if (flags != 0)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			object obj4 = currentGame - 1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			object obj6 = ~obj5;
			object obj7 = ((obj6 != null) ? ((object)4294967293L) : ((object)(4294967293L + 1)));
			if (currentGame == Games.Jackaroo)
			{
				obj7 = 4294967291L;
			}
			object obj8 = obj7 | flags;
			object obj9 = obj8 + 1;
			return obj9 == null;
		}
		return true;
	}
}
