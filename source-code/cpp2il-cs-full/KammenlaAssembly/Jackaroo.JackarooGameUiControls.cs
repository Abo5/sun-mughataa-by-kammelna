using Cpp2ILInjected;
using Sfs2X.Entities.Data;

namespace Jackaroo;

public class JackarooGameUiControls : KGameUiControls
{
	protected override void OnGameEnd(ISFSObject _)
	{
	}

	protected override void OnGameStateUpdated()
	{
		//IL_003b: Expected O, but got I4
		//IL_008c: Expected I, but got O
		//IL_009c: Expected O, but got I
		//IL_00ac: Expected O, but got I
		//IL_00f5: Expected I, but got O
		//IL_0105: Expected O, but got I
		//IL_0115: Expected O, but got I
		KGame kGame = game;
		bool isInitializing = kGame.<GamePhase>k__BackingField.IsInitializing;
		bool flag = !isInitializing;
		object obj = !flag;
		if (obj == null)
		{
			KGame kGame2 = game;
			if (!kGame2.<GamePhase>k__BackingField.IsLookingForPlayers)
			{
				goto IL_00b6;
			}
		}
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v4 (Il2CppClass<Jackaroo.JackarooGameUiControls>)+1E8]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v4 (Il2CppClass<Jackaroo.JackarooGameUiControls>)+1F0]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v64 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_00b6;
		IL_00b6:
		KGame kGame3 = game;
		if (kGame3.<GamePhase>k__BackingField.IsGameStarted)
		{
			nint num2 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v7 (Il2CppClass<Jackaroo.JackarooGameUiControls>)+1E8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v7 (Il2CppClass<Jackaroo.JackarooGameUiControls>)+1F0]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v65 @ X3_v2 (should have been resolved before IL gen)");
		}
	}
}
