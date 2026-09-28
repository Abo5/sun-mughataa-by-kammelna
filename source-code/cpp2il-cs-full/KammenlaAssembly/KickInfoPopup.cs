using System;
using System.Data;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class KickInfoPopup : MonoBehaviour
{
	private PopupUI popup;

	private TextMeshProUGUI reason;

	private DateTimeText duration;

	private TextMeshProUGUI permaban;

	private TextMeshProUGUI banneduntil;

	private bool trackingEndTime;

	private DateTime endTime;

	public void ShowErrorPopup(string errorMessage, DateTime errorDuration)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00e6: Expected O, but got I4
		//IL_014c: Expected O, but got I4
		//IL_0183: Invalid comparison between F8 and I8
		popup.PopFromCenter();
		TextMeshProExtensions.FixArabic(reason, errorMessage);
		GameObject gameObject = banneduntil.gameObject;
		gameObject.SetActive(value: false);
		GameObject gameObject2 = permaban.gameObject;
		gameObject2.SetActive(value: false);
		GameObject gameObject3 = duration.gameObject;
		object obj = typeof(DataRelation) + 712;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		gameObject3.SetActive(value: false);
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = errorDuration - now;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X0_v18+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan2 = default(TimeSpan);
		double totalDays = timeSpan2.TotalDays;
		if (totalDays < 4.658815484840378E+18)
		{
			GameObject gameObject4 = banneduntil.gameObject;
			gameObject4.SetActive(value: true);
			GameObject gameObject5 = duration.gameObject;
			gameObject5.SetActive(value: true);
			duration.SetDate(errorDuration);
			endTime = errorDuration;
			trackingEndTime = true;
		}
		else
		{
			GameObject gameObject6 = permaban.gameObject;
			gameObject6.SetActive(value: true);
			trackingEndTime = false;
		}
	}

	private void Update()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_010d: Expected O, but got I4
		//IL_00a2: Expected I, but got O
		//IL_00b2: Expected O, but got I
		//IL_00c2: Expected O, but got I
		if (!trackingEndTime)
		{
			return;
		}
		object obj = typeof(DataRelation) + 712;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			DateTime now = DateTime.Now;
			if (now >= endTime)
			{
				goto IL_0080;
			}
			return;
		}
		goto IL_00cc;
		IL_0080:
		trackingEndTime = false;
		PopupUI popupUI = popup;
		nint num = (nint)popupUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v8 (Il2CppClass<PopupUI>)+198]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v8 (Il2CppClass<PopupUI>)+1A0]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v77 @ X2_v4 (should have been resolved before IL gen)");
		goto IL_00cc;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime now2 = DateTime.Now;
		bool flag = now2 >= endTime;
		bool flag2 = !flag;
		object obj5 = !flag2;
		if (obj5 == null)
		{
			return;
		}
		goto IL_0080;
	}
}
