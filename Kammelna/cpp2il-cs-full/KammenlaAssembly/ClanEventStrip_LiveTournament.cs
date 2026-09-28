using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using ListView;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class ClanEventStrip_LiveTournament : ClanEventStrip
{
	private TournamentStrip tournamentStrip;

	public override void Setup(ClanFeedEventDataHolder datum, bool firstTime)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_014a: Expected O, but got I4
		//IL_0153: Expected O, but got I4
		//IL_008c: Expected O, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00eb: Expected I, but got O
		//IL_00fb: Expected O, but got I
		//IL_010b: Expected O, but got I
		base.Setup(datum, firstTime);
		if (datum == null || datum.<TournamentRoom>k__BackingField == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v4+E4]");
		object obj3;
		Object obj4;
		if ((nint)0 != 0)
		{
			bool flag = this.tournamentStrip != null;
			bool flag2 = !flag;
			obj3 = 0;
			obj4 = null;
			if (!flag2)
			{
				goto IL_009f;
			}
			return;
		}
		goto IL_0115;
		IL_0115:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = this.tournamentStrip != null;
		bool flag4 = !flag3;
		object obj5 = !flag4;
		obj3 = 0;
		obj4 = null;
		if (obj5 == null)
		{
			return;
		}
		goto IL_009f;
		IL_009f:
		TournamentStrip tournamentStrip = this.tournamentStrip;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TournamentDataHolder tournamentDataHolder = default(TournamentDataHolder);
		tournamentDataHolder..ctor(datum.<TournamentRoom>k__BackingField, 0);
		nint num = (nint)tournamentStrip;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v10 (Il2CppClass<TournamentStrip>)+308]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v10 (Il2CppClass<TournamentStrip>)+310]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v82 @ X4_v1 (should have been resolved before IL gen)");
		goto IL_0115;
	}

	public ClanEventStrip_LiveTournament()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
