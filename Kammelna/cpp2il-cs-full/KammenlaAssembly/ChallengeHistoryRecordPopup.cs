using System;
using System.Threading;
using Cpp2ILInjected;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;

public class ChallengeHistoryRecordPopup : MonoBehaviour
{
	private const string Description = "friendly_challenge_history_popup_description";

	private const string ListTitle = "friendly_challenge_history_popup_list_title";

	private const string ListTitleLocked = "friendly_challenge_history_popup_list_title_locked";

	private PopupUI popup;

	private ChallengeHistoryStrip strip;

	private TextMeshProUGUI descriptionLabel;

	private TextMeshProUGUI listTitleLabel;

	private ChallengeHistoryListView listView;

	public void ShowFor(ChallengeStateData challengeData)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0057: Expected O, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0142: Expected O, but got I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_01aa: Expected O, but got I4
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Expected O, but got Unknown
		//IL_024e: Expected O, but got I4
		//IL_096f: Invalid comparison between F8 and I4
		//IL_0980: Expected O, but got I4
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected O, but got Unknown
		//IL_09f1: Expected O, but got I4
		//IL_0a1c: Invalid comparison between F8 and I4
		//IL_0a2d: Expected O, but got I4
		//IL_0a4d: Invalid comparison between F8 and I4
		//IL_0a60: Expected O, but got F8
		//IL_0a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6d: Expected O, but got Unknown
		//IL_0a95: Expected O, but got I4
		//IL_0ad6: Expected O, but got I4
		//IL_02ed: Invalid comparison between F8 and I8
		//IL_031a: Expected I8, but got F8
		//IL_0b28: Expected F8, but got I8
		//IL_0b3a: Expected O, but got I4
		//IL_030d: Expected I8, but got I4
		//IL_0337: Expected O, but got I4
		//IL_03e2: Expected F8, but got I8
		//IL_034d: Expected I, but got O
		//IL_035d: Expected O, but got I
		//IL_0390: Expected F8, but got I8
		//IL_03a9: Expected O, but got I
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		//IL_0469: Expected O, but got I4
		//IL_0483: Expected F8, but got I8
		//IL_048b: Expected I4, but got O
		//IL_04be: Expected O, but got I4
		//IL_04d8: Expected F8, but got I8
		//IL_04e0: Expected I4, but got O
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_057e: Expected O, but got I4
		//IL_0b65: Invalid comparison between F8 and I4
		//IL_0b76: Expected O, but got I4
		//IL_0bc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcd: Expected O, but got Unknown
		//IL_0be7: Expected O, but got I4
		//IL_0c12: Invalid comparison between F8 and I4
		//IL_0c23: Expected O, but got I4
		//IL_0c43: Invalid comparison between F8 and I4
		//IL_0c56: Expected O, but got F8
		//IL_0c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c63: Expected O, but got Unknown
		//IL_0c8b: Expected O, but got I4
		//IL_0caf: Invalid comparison between F8 and I8
		//IL_060a: Expected I8, but got F8
		//IL_0cef: Expected O, but got I4
		//IL_0d09: Expected F8, but got I8
		//IL_0d1a: Expected O, but got I8
		//IL_05fd: Expected I8, but got I4
		//IL_0619: Unknown result type (might be due to invalid IL or missing references)
		//IL_061e: Expected O, but got Unknown
		//IL_0628: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected O, but got Unknown
		//IL_064c: Expected O, but got I4
		//IL_0d4a: Expected O, but got I4
		//IL_0d64: Expected F8, but got I8
		//IL_0d76: Expected O, but got I4
		//IL_068d: Expected O, but got I4
		//IL_0730: Expected O, but got I4
		//IL_074a: Expected F8, but got I8
		//IL_06a3: Expected I, but got O
		//IL_06b3: Expected O, but got I
		//IL_06d5: Expected O, but got I4
		//IL_06ef: Expected F8, but got I8
		//IL_0708: Expected O, but got I
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected O, but got Unknown
		//IL_07bb: Expected O, but got I4
		//IL_07d5: Expected F8, but got I8
		//IL_07dd: Expected I4, but got O
		//IL_0826: Expected O, but got I4
		//IL_0840: Expected F8, but got I8
		//IL_0848: Expected I4, but got O
		//IL_08b2: Expected O, but got I4
		//IL_08cc: Expected F8, but got I8
		//IL_08d4: Expected I4, but got O
		bool flag = (object)strip == null;
		IntPtr intPtr = default(IntPtr);
		bool flag2 = (byte)(nint)intPtr != 0;
		ChallengeStateData challengeStateData = challengeData;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag)
		{
			object obj = typeof(RegisteredWaitHandle) + 56;
			strip.Populate(challengeData, interactable: false);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v10+E4]");
			bool flag3 = (nint)0 == 0;
			object obj3 = !flag3;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RemoteConfigModel current = RemoteConfig.Current;
			bool flag4 = current == null;
			flag2 = false;
			challengeStateData = challengeData;
			if (!flag4)
			{
				bool flag5 = current.<FriendlyChallenge>k__BackingField == null;
				flag2 = false;
				challengeStateData = challengeData;
				if (!flag5)
				{
					object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
					object obj5 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
					TimeSpan scoreLifetime = current.<FriendlyChallenge>k__BackingField.ScoreLifetime;
					object obj6 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X0_v16+E4]");
					bool flag6 = (nint)0 == 0;
					object obj7 = !flag6;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
					TimeSpan timeSpan = default(TimeSpan);
					double totalDays = timeSpan.TotalDays;
					object obj9 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v19+E4]");
					bool flag7 = (nint)0 == 0;
					object obj10 = !flag7;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object key = "DNQUALIFIER" + 1456;
					object obj11 = typeof(TypeConverter<ushort, char>) + 3400;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
					double num = totalDays + -0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
					double num3 = default(double);
					double num2 = num3 + -1.0;
					object obj12 = num3 & 1;
					bool flag8 = obj12 == null;
					object obj13 = !flag8;
					if (obj13 == null)
					{
						num2 = num3;
					}
					double num4 = totalDays - -0.5;
					bool flag9 = num4 == 0.0;
					object obj14 = !flag9;
					object obj15 = ~obj14;
					double num5 = ((obj15 != null) ? num2 : num);
					double num6 = totalDays + 0.5;
					Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
					double num7 = num3 + 1.0;
					object obj16 = num3 & 1;
					bool flag10 = obj16 == null;
					object obj17 = !flag10;
					double num8 = ((obj17 != null) ? num7 : num3);
					double num9 = totalDays - 0.5;
					bool flag11 = num9 == 0.0;
					object obj18 = !flag11;
					object obj19 = ~obj18;
					double num10 = ((obj19 != null) ? num8 : num6);
					bool flag12 = totalDays < 0.0;
					object obj20 = totalDays ^ totalDays;
					object obj21 = totalDays & obj20;
					bool flag13 = (nint)obj21 < 0;
					bool flag14 = flag12 == flag13;
					object obj22 = !flag14;
					object obj23 = ~obj22;
					double num11 = ((obj23 != null) ? num10 : num5);
					object obj24 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v485 @ X0_v23+E4]");
					bool flag15 = (nint)0 == 0;
					object obj25 = !flag15;
					if (obj25 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					long n = ((num11 != 9.218868437227405E+18) ? ((long)num11) : (-2147483648));
					string text = LocalizationText.GetText((string)key, n);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					object[] array = default(object[]);
					bool flag16 = array == null;
					double num12 = 0.5;
					double num13 = 9.218868437227405E+18;
					flag2 = false;
					challengeStateData = (ChallengeStateData)1;
					if (!flag16)
					{
						bool flag17 = text == null;
						ChallengeStateData challengeStateData2 = (ChallengeStateData)1;
						if (!flag17)
						{
							nint num14 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
							challengeStateData2 = (ChallengeStateData)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag18 = ex == null;
							num12 = 0.5;
							num13 = 9.218868437227405E+18;
							flag2 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v27 (Il2CppClass<System.Object[]>)+40]");
							challengeStateData = (ChallengeStateData)0;
							if (flag18)
							{
								goto IL_090d;
							}
						}
						bool flag19 = array.Length == 0;
						num12 = 0.5;
						num13 = 9.218868437227405E+18;
						flag2 = false;
						challengeStateData = challengeStateData2;
						if (flag19)
						{
							goto IL_08ff;
						}
						object obj26 = "fetch_products" + 1376;
						object obj27 = array + 32;
						obj27 = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						TextMeshProExtensions.Localize(descriptionLabel, (string)obj26, array);
						RemoteConfigModel current2 = RemoteConfig.Current;
						bool flag20 = current2 == null;
						object obj28 = 0;
						num12 = 0.5;
						num13 = 9.218868437227405E+18;
						flag2 = (byte)(int)array != 0;
						challengeStateData = (ChallengeStateData)obj26;
						if (!flag20)
						{
							bool flag21 = current2.<FriendlyChallenge>k__BackingField == null;
							obj28 = 0;
							num12 = 0.5;
							num13 = 9.218868437227405E+18;
							flag2 = (byte)(int)array != 0;
							challengeStateData = (ChallengeStateData)obj26;
							if (!flag21)
							{
								TimeSpan lockDuration = current2.<FriendlyChallenge>k__BackingField.LockDuration;
								double totalDays2 = timeSpan.TotalDays;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
								double num15 = totalDays2 + -0.5;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
								double num17 = default(double);
								double num16 = num17 + -1.0;
								object obj29 = num17 & 1;
								bool flag22 = obj29 == null;
								object obj30 = !flag22;
								if (obj30 == null)
								{
									num16 = num17;
								}
								double num18 = totalDays2 - -0.5;
								bool flag23 = num18 == 0.0;
								object obj31 = !flag23;
								object obj32 = ~obj31;
								num5 = ((obj32 != null) ? num16 : num15);
								num6 = totalDays2 + 0.5;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
								num7 = num17 + 1.0;
								object obj33 = num17 & 1;
								bool flag24 = obj33 == null;
								object obj34 = !flag24;
								double num19 = ((obj34 != null) ? num7 : num17);
								double num20 = totalDays2 - 0.5;
								bool flag25 = num20 == 0.0;
								object obj35 = !flag25;
								object obj36 = ~obj35;
								num13 = ((obj36 != null) ? num19 : num6);
								bool flag26 = totalDays2 < 0.0;
								object obj37 = totalDays2 ^ totalDays2;
								object obj38 = totalDays2 & obj37;
								bool flag27 = (nint)obj38 < 0;
								bool flag28 = flag26 == flag27;
								object obj39 = !flag28;
								object obj40 = ~obj39;
								if (obj40 == null)
								{
									num13 = num5;
								}
								long num21 = ((num13 != 9.218868437227405E+18) ? ((long)num13) : (-2147483648));
								string text2 = LocalizationText.GetText((string)key, num21);
								bool flag29 = challengeData == null;
								obj28 = 0;
								num12 = 0.5;
								num8 = 9.218868437227405E+18;
								flag2 = false;
								challengeStateData = (ChallengeStateData)num21;
								if (!flag29)
								{
									object obj41 = "fetch_products" + 1392;
									object obj42 = "fetch_products" + 1384;
									bool flag30 = !challengeData.IsLocked;
									object obj43 = !flag30;
									object obj44 = ~obj43;
									if (obj44 != null)
									{
										obj41 = obj42;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
									object[] array2 = default(object[]);
									bool flag31 = array2 == null;
									obj28 = 0;
									num12 = 0.5;
									num8 = 9.218868437227405E+18;
									flag2 = false;
									challengeStateData = (ChallengeStateData)1;
									if (!flag31)
									{
										bool flag32 = text2 == null;
										ChallengeStateData challengeStateData3 = (ChallengeStateData)1;
										if (!flag32)
										{
											nint num22 = (nint)array2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
											challengeStateData3 = (ChallengeStateData)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag33 = ex == null;
											obj28 = 0;
											num12 = 0.5;
											num8 = 9.218868437227405E+18;
											flag2 = false;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X8_v24 (Il2CppClass<System.Object[]>)+40]");
											challengeStateData = (ChallengeStateData)0;
											if (flag33)
											{
												goto IL_090d;
											}
										}
										bool flag34 = array2.Length == 0;
										obj28 = 0;
										num12 = 0.5;
										num8 = 9.218868437227405E+18;
										flag2 = false;
										challengeStateData = challengeStateData3;
										if (flag34)
										{
											goto IL_08ff;
										}
										object obj45 = array2 + 32;
										obj45 = text2;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										TextMeshProExtensions.Localize(listTitleLabel, (string)obj41, array2);
										bool flag35 = (object)listView == null;
										obj28 = 0;
										num12 = 0.5;
										num8 = 9.218868437227405E+18;
										flag2 = (byte)(int)array2 != 0;
										challengeStateData = (ChallengeStateData)obj41;
										if (!flag35)
										{
											listView.SetData(challengeData);
											PopupUI popupUI = popup;
											bool flag36 = (object)popup == null;
											obj28 = 0;
											num12 = 0.5;
											num8 = 9.218868437227405E+18;
											flag2 = (byte)(int)array2 != 0;
											challengeStateData = challengeData;
											if (!flag36)
											{
												if (popupUI.<IsCurrentlyShown>k__BackingField)
												{
													popup.SlideToBottom();
													popupUI = popup;
													bool flag37 = (object)popup == null;
													obj28 = 0;
													num12 = 0.5;
													num8 = 9.218868437227405E+18;
													flag2 = (byte)(int)array2 != 0;
													challengeStateData = null;
													if (flag37)
													{
														goto IL_08f1;
													}
												}
												popupUI.SlideFromBottom();
												return;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_08f1;
		IL_08ff:
		ex = new IndexOutOfRangeException();
		goto IL_090d;
		IL_08f1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_08ff;
		IL_090d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}
}
