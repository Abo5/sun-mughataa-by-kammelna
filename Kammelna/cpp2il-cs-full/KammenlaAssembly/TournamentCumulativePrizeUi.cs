using System.Buffers.Text;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using UnityEngine.Purchasing.Telemetry;

public class TournamentCumulativePrizeUi : TournamentPrizeUi
{
	private static readonly Regex Regex;

	protected NumberFormatter formatter;

	protected TextMeshProUGUI text;

	private TextMeshProUGUI unitText;

	public override void Initialize(TournamentData tournament)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_003d: Expected I, but got O
		//IL_020e: Expected O, but got I4
		//IL_0217: Expected O, but got I4
		//IL_00a0: Expected O, but got I4
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Expected O, but got Unknown
		//IL_00ec: Expected O, but got I4
		//IL_0121: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_01d0: Expected I, but got O
		NumberFormatter numberFormatter = formatter;
		int totalPrize = tournament.TotalPrize;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		nint num = (nint)numberFormatter;
		numberFormatter.AssignValue(this.text, totalPrize);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v8+E4]");
		object obj3;
		if ((nint)0 != 0)
		{
			bool flag = unitText;
			bool flag2 = !flag;
			obj3 = 0;
			if (!flag2)
			{
				goto IL_00ae;
			}
			return;
		}
		goto IL_01da;
		IL_01da:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = unitText;
		bool flag4 = !flag3;
		object obj4 = !flag4;
		obj3 = 0;
		if (obj4 == null)
		{
			return;
		}
		goto IL_00ae;
		IL_00ae:
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1488;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v15+E4]");
		bool flag5 = (nint)0 == 0;
		object obj7 = !flag5;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj6 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v15+B8]");
		object obj8 = 0;
		string input = this.text.text;
		object obj9 = (nint)0 + (nint)2000;
		string text = ((Regex)obj8).Replace(input, (string)obj9);
		string text2 = text.Trim();
		TextMeshProExtensions.FixArabic(unitText, text2);
		TextMeshProUGUI textMeshProUGUI = this.text;
		string text3 = this.text.text;
		string oldValue = unitText.text;
		string text4 = text3.Replace(oldValue, (string)obj9);
		nint num2 = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v148 @ X8_v10 (Il2CppClass<TMPro.TextMeshProUGUI>)+558] (should have been resolved before IL gen)");
		goto IL_01da;
	}

	static TournamentCumulativePrizeUi()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3920;
		object pattern = "WhiteSmoke" + 3888;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1488;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Regex regex = default(Regex);
		regex..ctor((string)pattern);
		object obj3 = obj2;
		object obj4 = regex;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
