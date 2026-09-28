using System.Buffers.Text;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TournamentName : MonoBehaviour
{
	private TournamentSprites tournamentSprites;

	private TextMeshProUGUI text;

	private Image typeLogo;

	private Image monthlyTypeLogo;

	private Image championsLogo;

	private Material officialTournamentMaterial;

	public void Initialize(TournamentData data)
	{
		//IL_005b: Expected O, but got I4
		//IL_006b: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00b9: Expected O, but got I4
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_026a: Expected I, but got O
		//IL_027a: Expected O, but got I
		//IL_028a: Expected O, but got I
		//IL_0175: Expected O, but got I4
		GameObject gameObject4;
		bool active;
		if (data.<Type>k__BackingField != TournamentType.OfficialMonthly)
		{
			if (data.<Type>k__BackingField != TournamentType.Official)
			{
				goto IL_0294;
			}
			object obj = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v9+90]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v10+B8]");
			object replacement = 0;
			object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 3920;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X8_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object pattern = "WhiteSmoke" + 3904;
			string text = Regex.Replace(data.<Name>k__BackingField, (string)pattern, (string)replacement);
			TextMeshProExtensions.FixArabic(this.text, text);
			GameObject gameObject = this.text.gameObject;
			gameObject.SetActive(value: true);
			GameObject gameObject2 = monthlyTypeLogo.gameObject;
			gameObject2.SetActive(value: false);
			GameObject gameObject3 = typeLogo.gameObject;
			gameObject3.SetActive(value: true);
			gameObject4 = championsLogo.gameObject;
			active = data.<IsChampions>k__BackingField;
			object obj6 = 0;
		}
		else
		{
			GameObject gameObject5 = this.text.gameObject;
			gameObject5.SetActive(value: false);
			GameObject gameObject6 = typeLogo.gameObject;
			gameObject6.SetActive(value: false);
			GameObject gameObject7 = championsLogo.gameObject;
			gameObject7.SetActive(value: false);
			Sprite monthlyTournamentTypeTitle = tournamentSprites.GetMonthlyTournamentTypeTitle(data.<SubType>k__BackingField);
			monthlyTypeLogo.sprite = monthlyTournamentTypeTitle;
			gameObject4 = monthlyTypeLogo.gameObject;
			active = true;
		}
		gameObject4.SetActive(active);
		this.text.fontSharedMaterial = officialTournamentMaterial;
		TextMeshProUGUI textMeshProUGUI = this.text;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v7 (Il2CppClass<TMPro.TextMeshProUGUI>)+2A8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v271 @ X8_v7 (Il2CppClass<TMPro.TextMeshProUGUI>)+2B0]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v257 @ X2_v5 (should have been resolved before IL gen)");
		goto IL_0294;
		IL_0294:
		GameObject gameObject8 = this.text.gameObject;
		gameObject8.SetActive(value: true);
		TextMeshProExtensions.FixArabic(this.text, data.<Name>k__BackingField);
		GameObject gameObject9 = typeLogo.gameObject;
		gameObject9.SetActive(value: false);
		GameObject gameObject10 = championsLogo.gameObject;
		gameObject10.SetActive(value: false);
		GameObject gameObject11 = monthlyTypeLogo.gameObject;
		gameObject11.SetActive(value: false);
	}
}
