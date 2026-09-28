using System;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

[Serializable]
public class TimerComponentsUi
{
	public GameObject days;

	public GameObject separator1;

	public GameObject hours;

	public GameObject separator2;

	public GameObject minutes;

	public GameObject seconds;

	public TextMeshProUGUI daysLabel;

	public TextMeshProUGUI hoursLabel;

	public TextMeshProUGUI minutesLabel;

	public DateTimeText secondsLabel;

	public void SetTime(TimeSpan time, DateTime dateTime)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00b0: Expected O, but got I4
		//IL_01ae: Expected O, but got I4
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected I4, but got Unknown
		//IL_0241: Expected O, but got I4
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected I4, but got Unknown
		//IL_02d4: Expected O, but got I4
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected I4, but got Unknown
		//IL_0367: Expected O, but got I4
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected I4, but got Unknown
		//IL_03fa: Expected O, but got I4
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected I4, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_043c: Expected O, but got Unknown
		//IL_044a: Expected O, but got I4
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected I4, but got Unknown
		//IL_04d5: Invalid comparison between F8 and I8
		//IL_0506: Expected I4, but got F8
		//IL_04f9: Expected I4, but got I8
		object obj = 152985600;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E60CC]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v28+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v28+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		TimeSpan timeSpan = default(TimeSpan);
		int num = timeSpan.Minutes;
		GameObject gameObject = days;
		int num2 = num;
		goto IL_013c;
		IL_013c:
		GameObject gameObject2 = gameObject.gameObject;
		bool flag2 = num2 < 0;
		bool flag3 = num2 == 0;
		int num3 = num2 ^ num2;
		int num4 = num2 & num3;
		bool flag4 = num4 < 0;
		bool flag5 = flag2 == flag4;
		object obj6 = !flag3;
		bool active = (byte)((flag5 & obj6) ? 1 : 0) != 0;
		gameObject2.SetActive(active);
		GameObject gameObject3 = separator1.gameObject;
		bool flag6 = num2 < 0;
		bool flag7 = num2 == 0;
		int num5 = num2 ^ num2;
		int num6 = num2 & num5;
		bool flag8 = num6 < 0;
		bool flag9 = flag6 == flag8;
		object obj7 = !flag7;
		bool active2 = (byte)((flag9 & obj7) ? 1 : 0) != 0;
		gameObject3.SetActive(active2);
		GameObject gameObject4 = hours.gameObject;
		bool flag10 = num2 < 0;
		bool flag11 = num2 == 0;
		int num7 = num2 ^ num2;
		int num8 = num2 & num7;
		bool flag12 = num8 < 0;
		bool flag13 = flag10 == flag12;
		object obj8 = !flag11;
		bool active3 = (byte)((flag13 & obj8) ? 1 : 0) != 0;
		gameObject4.SetActive(active3);
		GameObject gameObject5 = separator2.gameObject;
		bool flag14 = num2 < 0;
		bool flag15 = num2 == 0;
		int num9 = num2 ^ num2;
		int num10 = num2 & num9;
		bool flag16 = num10 < 0;
		bool flag17 = flag14 == flag16;
		object obj9 = !flag15;
		bool active4 = (byte)((flag17 & obj9) ? 1 : 0) != 0;
		gameObject5.SetActive(active4);
		GameObject gameObject6 = minutes.gameObject;
		bool flag18 = num2 < 0;
		bool flag19 = num2 == 0;
		int num11 = num2 ^ num2;
		int num12 = num2 & num11;
		bool flag20 = num12 < 0;
		bool flag21 = flag18 == flag20;
		object obj10 = !flag19;
		bool active5 = (byte)((flag21 & obj10) ? 1 : 0) != 0;
		gameObject6.SetActive(active5);
		GameObject gameObject7 = seconds.gameObject;
		object obj11 = ", stale={0}" + 3536;
		object obj12 = num2 - 1;
		bool flag22 = (nint)obj12 < 0;
		int num13 = num2 ^ 1;
		int num14 = num2 ^ obj12;
		int num15 = num13 & num14;
		bool flag23 = num15 < 0;
		bool flag24 = flag22 == flag23;
		bool active6 = !flag24;
		gameObject7.SetActive(active6);
		double totalDays = timeSpan.TotalDays;
		int number = (int)((totalDays != 9.218868437227405E+18) ? ((int)totalDays) : 2147483648L);
		TextMeshProExtensions.SetNumber(daysLabel, number);
		int num16 = timeSpan.Hours;
		int num17 = default(int);
		string text = num17.ToString((string)obj11);
		hoursLabel.SetText(text);
		int num18 = timeSpan.Minutes;
		string text2 = num17.ToString((string)obj11);
		minutesLabel.SetText(text2);
		secondsLabel.SetDate(dateTime);
		return;
		IL_007d:
		int num19 = timeSpan.Minutes;
		gameObject = days;
		bool flag25 = (object)days == null;
		object obj13 = !flag25;
		num2 = num19;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_013c;
	}
}
