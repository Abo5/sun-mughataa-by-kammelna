using System;
using System.Buffers.Text;
using System.Diagnostics;
using Cpp2ILInjected;
using GoogleMobileAds.Ump.Api;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentHubHelpSectionPopup : MonoBehaviour
{
	private sealed class <>c__DisplayClass10_0
	{
		public TournamentData tournamentData;

		internal void <Show>b__0(TournamentHubHelpSectionPopup popup)
		{
			popup.Populate(tournamentData);
		}
	}

	private static readonly AddressReference<TournamentHubHelpSectionPopup> Address;

	private PopupUI popup;

	private TournamentSprites tournamentSprites;

	private Image tournamentTitle;

	private Image tournamentTrophy;

	private Image tournamentFirstPrize;

	private Image tournamentSecondPrize;

	private Image tournamentParticipantsPrize;

	private Image tournamentChampionPrize;

	private TextMeshProUGUI tournamentDescription;

	public static void Show(TournamentData tournamentData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_010e: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_0139: Expected I, but got O
		//IL_0163: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3584;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1560;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3792;
		object obj5 = (nint)0 + (nint)3896;
		object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj7 = obj2 + 16;
		obj7 = tournamentData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj3;
		}
		object obj10 = (nint)0 + (nint)2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v9+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj5);
		object obj12 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v12+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	private void Populate(TournamentData tournamentData)
	{
		Sprite monthlyTournamentFirstCup = tournamentSprites.GetMonthlyTournamentFirstCup(tournamentData.<SubType>k__BackingField);
		Sprite monthlyTournamentTypeTitle = tournamentSprites.GetMonthlyTournamentTypeTitle(tournamentData.<SubType>k__BackingField);
		tournamentTitle.sprite = monthlyTournamentTypeTitle;
		tournamentTrophy.sprite = monthlyTournamentFirstCup;
		tournamentFirstPrize.sprite = monthlyTournamentFirstCup;
		Sprite monthlyTournamentChampionTitle = tournamentSprites.GetMonthlyTournamentChampionTitle(tournamentData.<SubType>k__BackingField);
		tournamentChampionPrize.sprite = monthlyTournamentChampionTitle;
		Sprite monthlyTournamentSecondCup = tournamentSprites.GetMonthlyTournamentSecondCup(tournamentData.<SubType>k__BackingField);
		tournamentSecondPrize.sprite = monthlyTournamentSecondCup;
		Sprite monthlyTournamentCertificate = tournamentSprites.GetMonthlyTournamentCertificate(tournamentData.<SubType>k__BackingField);
		tournamentParticipantsPrize.sprite = monthlyTournamentCertificate;
		string monthlyTournamentDescription = tournamentSprites.GetMonthlyTournamentDescription(tournamentData.<SubType>k__BackingField);
		TextMeshProExtensions.Localize(tournamentDescription, monthlyTournamentDescription);
		popup.PopFromCenter();
	}

	static TournamentHubHelpSectionPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "ThisIsFakeReceiptData" + 1280;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 3216;
		object obj3 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1560;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
