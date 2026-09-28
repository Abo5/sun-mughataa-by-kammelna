using System;
using System.Buffers.Text;
using System.Collections.Generic;
using Cpp2ILInjected;

[Serializable]
public class TournamentCreationModel
{
	public Games game;

	public TournamentType type;

	public string tournamentName;

	public string password;

	public int size;

	public int bestOf;

	public int? finalBestOf;

	public TournamentPrizeType prizeType;

	public int prize;

	public int? secondaryPrize;

	public int? tertiaryPrize;

	public bool isInstant;

	public DateTime startingTime;

	public bool cheatingAllowed;

	public PlayerRank.Ranks minRank;

	public int roomTimer;

	public bool isHidden;

	public bool watchersChatEnabled;

	public bool usersSelectTeam;

	public List<TournamentAddonCreationModel> addons;

	public int? clanId;

	public unsafe TournamentCreationModel(TournamentType type, string tournamentName, string password, int size, int bestOf, int? finalBestOf, TournamentPrizeType prizeType, int prize, int? secondaryPrize, bool isInstant, DateTime startingTime, bool cheatingAllowed, PlayerRank.Ranks minRank, int roomTimer, bool isHidden, bool watchersChatEnabled, bool usersSelectTeam, List<TournamentAddonCreationModel> addons)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0155: Expected O, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0093: Expected O, but got I
		//IL_00ce: Expected O, but got I8
		//IL_010c: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		object obj2 = default(object);
		object obj = (object)(&obj2);
		base..ctor();
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		game = Preferences.CurrentGame;
		this.type = type;
		object obj6 = this + 24;
		obj6 = tournamentName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = this + 32;
		obj7 = password;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = this + 112;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+40]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+18]");
		if ((nint)(object)(0 & -4294967295L) == 1)
		{
			object obj9 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+18]");
			object obj9 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+20]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+28]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+30]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+34]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+38]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+3C]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+3D]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1+3E]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
