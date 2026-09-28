using System;
using System.Data;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using Util;

public class ChallengeHistoryListStrip : ListViewItem<IListViewItemData<int>, int>
{
	private const string LockText = "friendly_challenge_history_lock";

	private AvatarInitializer avatar;

	private GameObject winIndicator;

	private GameObject loseIndicator;

	private GameObject lockIndicator;

	private TextMeshProUGUI lockText;

	private TextMeshProUGUI timeText;

	private void Populate(ChallengeEntry entry, ChallengeStateData challengeData)
	{
		//IL_06d3: Expected O, but got I4
		//IL_06e3: Expected O, but got I
		//IL_0705: Expected O, but got I4
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_0727: Expected O, but got Unknown
		//IL_0731: Unknown result type (might be due to invalid IL or missing references)
		//IL_0736: Expected O, but got Unknown
		//IL_0760: Expected O, but got I4
		//IL_007a: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_012e: Expected O, but got I4
		//IL_016a: Expected O, but got I4
		//IL_018b: Expected O, but got I4
		//IL_01c7: Expected O, but got I4
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0228: Expected O, but got I4
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0290: Expected O, but got I4
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02eb: Expected O, but got I4
		//IL_038b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_03ba: Expected O, but got I4
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_0422: Expected O, but got I4
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_04a3: Expected O, but got I4
		//IL_0841: Invalid comparison between F8 and I4
		//IL_0852: Expected O, but got I4
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a9: Expected O, but got Unknown
		//IL_08c3: Expected O, but got I4
		//IL_08ee: Invalid comparison between F8 and I4
		//IL_08ff: Expected O, but got I4
		//IL_091f: Invalid comparison between F8 and I4
		//IL_0932: Expected O, but got F8
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Expected O, but got Unknown
		//IL_0967: Expected O, but got I4
		//IL_098d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0992: Expected O, but got Unknown
		//IL_09bc: Expected O, but got I4
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_0551: Invalid comparison between F8 and I8
		//IL_057e: Expected I8, but got F8
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ef: Expected O, but got Unknown
		//IL_0a22: Expected O, but got I8
		//IL_0a30: Expected O, but got I4
		//IL_0571: Expected I8, but got I4
		//IL_059b: Expected O, but got I4
		//IL_0642: Expected O, but got I8
		//IL_05b1: Expected I, but got O
		//IL_05c1: Expected O, but got I
		//IL_05f4: Expected O, but got I8
		//IL_0609: Expected O, but got I
		//IL_0666: Unknown result type (might be due to invalid IL or missing references)
		//IL_066b: Expected O, but got Unknown
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected O, but got Unknown
		bool flag = (object)entry == null;
		ChallengeEntry challengeEntry = entry;
		PlayerInfo playerInfo;
		if (!flag)
		{
			ChallengeStateData challengeStateData = default(ChallengeStateData);
			if (entry.<Result>k__BackingField != FriendlyChallengeResult.DefenderWon)
			{
				if (entry.<Result>k__BackingField == FriendlyChallengeResult.ChallengerWon)
				{
					bool flag2 = challengeStateData == null;
					challengeEntry = entry;
					if (flag2)
					{
						goto IL_0787;
					}
					object obj = 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X2_v1 (ChallengeStateData)+v270 @ X8_v48]");
					playerInfo = (PlayerInfo)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X2_v1 (ChallengeStateData)+v270 @ X8_v48]");
					if ((nint)0 != 0)
					{
						goto IL_00af;
					}
				}
			}
			else
			{
				bool flag3 = challengeStateData == null;
				challengeEntry = entry;
				if (flag3)
				{
					goto IL_0787;
				}
				object obj2 = 24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X2_v1 (ChallengeStateData)+v269 @ X8_v11]");
				playerInfo = (PlayerInfo)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X2_v1 (ChallengeStateData)+v269 @ X8_v11]");
				bool flag4 = (nint)0 == 0;
				object obj3 = !flag4;
				if (obj3 != null)
				{
					goto IL_00af;
				}
			}
			object obj4 = typeof(DataRelation) + 856;
			object message = "Cannot populate JSON object onto type '{0}'." + 2056;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X0_v10+E4]");
			bool flag5 = (nint)0 == 0;
			object obj6 = !flag5;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Debug.LogError(message);
			return;
		}
		goto IL_0787;
		IL_0795:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_07a3;
		IL_07a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0787:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0795;
		IL_00af:
		AvatarData avatarData = playerInfo;
		bool flag6 = (object)avatar == null;
		challengeEntry = null;
		if (!flag6)
		{
			avatar.Initialize(avatarData);
			bool flag7 = (object)winIndicator == null;
			ChallengeStateData challengeStateData = null;
			challengeEntry = (ChallengeEntry)(object)avatarData;
			if (!flag7)
			{
				object obj7 = entry.<Result>k__BackingField - 1;
				bool flag8 = obj7 == null;
				winIndicator.SetActive(flag8);
				bool flag9 = (object)loseIndicator == null;
				challengeStateData = null;
				challengeEntry = (ChallengeEntry)flag8;
				if (!flag9)
				{
					object obj8 = entry.<Result>k__BackingField - 2;
					bool flag10 = obj8 == null;
					loseIndicator.SetActive(flag10);
					bool flag11 = (object)lockIndicator == null;
					challengeStateData = null;
					challengeEntry = (ChallengeEntry)flag10;
					if (!flag11)
					{
						lockIndicator.SetActive(entry.<IsLock>k__BackingField);
						object obj9 = typeof(DataRelation) + 712;
						object obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v21+E4]");
						bool flag12 = (nint)0 == 0;
						object obj11 = !flag12;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						DateTime dateTime = default(DateTime);
						TimeSpan timeOfDay = dateTime.TimeOfDay;
						object obj12 = typeof(DataRelation) + 824;
						object obj13 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X8_v21+E4]");
						bool flag13 = (nint)0 == 0;
						object obj14 = !flag13;
						if (obj14 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						string text = DateTimeUtil.AmPmTime(timeOfDay, shortWords: true);
						TextMeshProExtensions.FixArabic(timeText, text);
						if (!entry.<IsLock>k__BackingField)
						{
							return;
						}
						object obj15 = typeof(RegisteredWaitHandle) + 56;
						object obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X0_v29+E4]");
						bool flag14 = (nint)0 == 0;
						object obj17 = !flag14;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						RemoteConfigModel current = RemoteConfig.Current;
						bool flag15 = current == null;
						challengeStateData = null;
						challengeEntry = (ChallengeEntry)(object)text;
						if (!flag15)
						{
							bool flag16 = current.<FriendlyChallenge>k__BackingField == null;
							challengeStateData = null;
							challengeEntry = (ChallengeEntry)(object)text;
							if (!flag16)
							{
								TimeSpan lockDuration = current.<FriendlyChallenge>k__BackingField.LockDuration;
								object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
								object obj19 = obj18;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v35+E4]");
								bool flag17 = (nint)0 == 0;
								object obj20 = !flag17;
								if (obj20 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								TimeSpan timeSpan = default(TimeSpan);
								double totalDays = timeSpan.TotalDays;
								object obj21 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
								object obj22 = obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v38+E4]");
								bool flag18 = (nint)0 == 0;
								object obj23 = !flag18;
								if (obj23 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB18E8");
								double num = totalDays + -0.5;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTP not yet implemented.\"");
								double num3 = default(double);
								double num2 = num3 + -1.0;
								object obj24 = num3 & 1;
								bool flag19 = obj24 == null;
								object obj25 = !flag19;
								if (obj25 == null)
								{
									num2 = num3;
								}
								double num4 = totalDays - -0.5;
								bool flag20 = num4 == 0.0;
								object obj26 = !flag20;
								object obj27 = ~obj26;
								double num5 = ((obj27 != null) ? num2 : num);
								double num6 = totalDays + 0.5;
								Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FRINTM not yet implemented.\"");
								double num7 = num3 + 1.0;
								object obj28 = num3 & 1;
								bool flag21 = obj28 == null;
								object obj29 = !flag21;
								double num8 = ((obj29 != null) ? num7 : num3);
								double num9 = totalDays - 0.5;
								bool flag22 = num9 == 0.0;
								object obj30 = !flag22;
								object obj31 = ~obj30;
								double num10 = ((obj31 != null) ? num8 : num6);
								bool flag23 = totalDays < 0.0;
								object obj32 = totalDays ^ totalDays;
								object obj33 = totalDays & obj32;
								bool flag24 = (nint)obj33 < 0;
								bool flag25 = flag23 == flag24;
								object obj34 = !flag25;
								object obj35 = ~obj34;
								double num11 = ((obj35 != null) ? num10 : num5);
								object obj36 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2648;
								object obj37 = obj36;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X0_v42+E4]");
								bool flag26 = (nint)0 == 0;
								object obj38 = !flag26;
								if (obj38 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								}
								object key = "DNQUALIFIER" + 1456;
								long n = ((num11 != 9.218868437227405E+18) ? ((long)num11) : (-2147483648));
								string text2 = LocalizationText.GetText((string)key, n);
								object obj39 = typeof(TypeConverter<ushort, char>) + 3400;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
								object[] array = default(object[]);
								bool flag27 = array == null;
								double num12 = 0.5;
								object obj40 = 9218868437227405312L;
								challengeStateData = null;
								challengeEntry = (ChallengeEntry)1;
								if (!flag27)
								{
									bool flag28 = text2 == null;
									ChallengeEntry challengeEntry2 = (ChallengeEntry)1;
									if (!flag28)
									{
										nint num13 = (nint)array;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
										challengeEntry2 = (ChallengeEntry)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
										bool flag29 = ex == null;
										num12 = 0.5;
										obj40 = 9218868437227405312L;
										challengeStateData = null;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
										challengeEntry = (ChallengeEntry)0;
										if (flag29)
										{
											goto IL_07a3;
										}
									}
									bool flag30 = array.Length == 0;
									num12 = 0.5;
									obj40 = 9218868437227405312L;
									challengeStateData = null;
									challengeEntry = challengeEntry2;
									if (!flag30)
									{
										object obj41 = array + 32;
										obj41 = text2;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										object text3 = "fetch_products" + 1368;
										TextMeshProExtensions.Localize(lockText, (string)text3, array);
										return;
									}
									goto IL_0795;
								}
							}
						}
					}
				}
			}
		}
		goto IL_0787;
	}

	public override void Setup(IListViewItemData<int> datum, bool firstTime)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_002a: Expected I, but got O
		//IL_0053: Expected O, but got I4
		//IL_0087: Expected O, but got I
		//IL_00ca: Expected O, but got I
		//IL_00ca: Expected O, but got I
		bool firstTime2 = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime2);
		if (datum == null)
		{
			return;
		}
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 528;
		object obj2 = obj;
		nint num = (nint)datum;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X9_v2 (Il2CppClass<ListView.IListViewItemData`1<System.Int32>>)+130]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v6+130]");
		bool flag = num2 < 0;
		object obj3 = !flag;
		object obj4 = ~obj3;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X9_v2 (Il2CppClass<ListView.IListViewItemData`1<System.Int32>>)+C8]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v6+130]");
			object obj5 = num3 + 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X9_v4-8]");
			if (0 == (nint)obj2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [datum @ X1 (ListView.IListViewItemData`1<System.Int32>)+10]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [datum @ X1 (ListView.IListViewItemData`1<System.Int32>)+18]");
				Populate((ChallengeEntry)num4, (ChallengeStateData)0);
			}
		}
	}

	public ChallengeHistoryListStrip()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
