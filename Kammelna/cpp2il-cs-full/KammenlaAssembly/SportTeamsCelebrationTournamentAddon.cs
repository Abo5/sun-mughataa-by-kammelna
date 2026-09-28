using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;

public class SportTeamsCelebrationTournamentAddon : TournamentAddonModel, ICardbackAddon, IRoomThemeAddon
{
	private readonly int <RoomThemeId>k__BackingField;

	private int <SportTeamId>k__BackingField;

	private SportTeam <sportTeam>k__BackingField;

	public override int Priority => 15;

	public override TournamentAddonType Type => TournamentAddonType.SportCelebration;

	public unsafe override string SerializedData
	{
		get
		{
			//IL_0008: Expected O, but got Ref
			object obj2 = default(object);
			object obj = (object)(&obj2);
			_ = <SportTeamId>k__BackingField;
			int num = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 4));
			return ((int*)num)->ToString();
		}
	}

	public int CardbackId
	{
		get
		{
			//IL_0020: Expected I4, but got O
			SportTeam sportTeam = <sportTeam>k__BackingField;
			if (<sportTeam>k__BackingField != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3 (SportTeam)+24]");
				return 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int RoomThemeId => <RoomThemeId>k__BackingField;

	public int SportTeamId
	{
		get
		{
			return <SportTeamId>k__BackingField;
		}
		set
		{
			<SportTeamId>k__BackingField = value;
		}
	}

	public SportTeam sportTeam
	{
		get
		{
			return <sportTeam>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 24;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public SportTeamsCelebrationTournamentAddon(string sportTeamId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006f: Expected O, but got I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1176;
		((object)this)..ctor();
		int teamId = (<SportTeamId>k__BackingField = int.Parse(sportTeamId));
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SportTeam sportTeamById = SportTeamsUtil.GetSportTeamById(teamId);
		object obj4 = this + 24;
		obj4 = sportTeamById;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Refresh()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0084: Expected O, but got I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 1176;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SportTeam sportTeamById = SportTeamsUtil.GetSportTeamById(<SportTeamId>k__BackingField);
		object obj4 = this + 24;
		obj4 = sportTeamById;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
