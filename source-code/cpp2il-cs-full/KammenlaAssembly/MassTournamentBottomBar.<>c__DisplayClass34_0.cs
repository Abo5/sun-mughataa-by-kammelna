using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using Util;

public class MassTournamentBottomBar : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action<GameObject> <>9__33_0;

		public static Action<MassTournamentRegistrationSheet> <>9__36_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3040;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <PopulateMainButton>b__33_0(GameObject b)
		{
			b.SetActive(value: false);
		}

		internal void <MainButtonOnClick>b__36_1(MassTournamentRegistrationSheet sheet)
		{
			sheet.popup.SlideFromBottom();
			sheet.ResetForm();
		}
	}

	private sealed class <>c__DisplayClass34_0
	{
		public Action<GameObject> acceptCallback;

		public MassTournamentBottomBar <>4__this;

		internal void <ShowMassParticipationPopup>b__0()
		{
			//IL_002e: Expected O, but got I
			//IL_003e: Expected O, but got I
			//IL_004e: Expected O, but got I
			Action<GameObject> action = acceptCallback;
			GameObject gameObject = <>4__this.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X19_v2 (System.Action`1<UnityEngine.GameObject>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X19_v2 (System.Action`1<UnityEngine.GameObject>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X19_v2 (System.Action`1<UnityEngine.GameObject>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v39 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}
	}

	private MassTournamentEventChannel eventChannel;

	private ComponentReference<MassTournamentRegistrationSheet> registrationSheet;

	private TextMeshProUGUI playPeriodTitle;

	private TextMeshProUGUI playPeriodField;

	private TextMeshProUGUI stageDurationTitle;

	private TextMeshProUGUI stageDurationField;

	private DateTimeText startDelayText;

	private GameObject Button_RegisterState;

	private GameObject Button_StageEndedState;

	private GameObject Button_PlayStartsInState;

	private GameObject Button_WatcherState;

	private GameObject Button_PlayNowState;

	private GameObject Button_ReserveState;

	private GameObject Button_OutOfTriesState;

	private GameObject Button_TournamentEndedState;

	private DateTimeText leftTimer;

	private MassPlayPeriodsInfoPopup playPeriodsInfo;

	private ComponentReference<MassActiveTournamentsPopup> activeTournamentsPopup;

	private GameObject eligibleToNextStageObject;

	private TicketsConsumptionConfirmation indicator;

	private MassTournamentServerConnector connector;

	private MassTournamentPlayerState _player;

	private GameObject[] _buttons;

	private static TimeSpan _maxDelay;

	private static TimeSpan _userDelay;

	private MassEventModel TournamentData
	{
		get
		{
			if ((object)connector != null)
			{
				MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)this).GetTournamentLiveData();
				if (tournamentLiveData != null)
				{
					return MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
				}
			}
			return (MassEventModel)(object)new NullReferenceException();
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_007a: Expected O, but got I8
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00db: Expected O, but got I4
		//IL_00f1: Expected O, but got I
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0160: Expected O, but got I8
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I4
		//IL_01d7: Expected O, but got I
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_024e: Expected O, but got I4
		//IL_0264: Expected O, but got I
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_02db: Expected O, but got I4
		//IL_02f1: Expected O, but got I
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_0360: Expected O, but got I8
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_03d5: Expected O, but got I4
		//IL_03eb: Expected O, but got I
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Expected O, but got Unknown
		//IL_0444: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_0470: Expected O, but got I
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		//IL_0495: Expected O, but got I
		//IL_04ad: Expected I, but got O
		//IL_04be: Expected O, but got I
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_04de: Expected O, but got I
		//IL_0505: Expected I, but got O
		object obj = typeof(TypeConverter<ushort, char>) + 2568;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+18]");
		if ((nint)0 != 0)
		{
			object obj3 = default(object);
			object obj2 = obj3 + 32;
			obj2 = Button_RegisterState;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X21_v6-8]");
			object obj4 = 0 & 0xFFFFFFFEL;
			if (obj4 != null)
			{
				object obj5 = obj3 + 40;
				obj5 = Button_PlayNowState;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X21_v8-10]");
				bool flag = (nint)0 < (nint)2;
				object obj6 = !flag;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X21_v8-10]");
				object obj7 = -2;
				bool flag2 = obj7 == null;
				object obj8 = ~obj6;
				object obj9 = obj8 | flag2;
				if (obj9 == null)
				{
					object obj10 = obj3 + 48;
					obj10 = Button_ReserveState;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X21_v10-18]");
					object obj11 = 0 & 0xFFFFFFFCL;
					if (obj11 != null)
					{
						object obj12 = obj3 + 56;
						obj12 = Button_StageEndedState;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X21_v12-20]");
						bool flag3 = (nint)0 < (nint)4;
						object obj13 = !flag3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X21_v12-20]");
						object obj14 = -4;
						bool flag4 = obj14 == null;
						object obj15 = ~obj13;
						object obj16 = obj15 | flag4;
						if (obj16 == null)
						{
							object obj17 = obj3 + 64;
							obj17 = Button_WatcherState;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X21_v14-28]");
							bool flag5 = (nint)0 < (nint)5;
							object obj18 = !flag5;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X21_v14-28]");
							object obj19 = -5;
							bool flag6 = obj19 == null;
							object obj20 = ~obj18;
							object obj21 = obj20 | flag6;
							if (obj21 == null)
							{
								object obj22 = obj3 + 72;
								obj22 = Button_PlayStartsInState;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X21_v16-30]");
								bool flag7 = (nint)0 < (nint)6;
								object obj23 = !flag7;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X21_v16-30]");
								object obj24 = -6;
								bool flag8 = obj24 == null;
								object obj25 = ~obj23;
								object obj26 = obj25 | flag8;
								if (obj26 == null)
								{
									object obj27 = obj3 + 80;
									obj27 = Button_OutOfTriesState;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X21_v18-38]");
									object obj28 = 0 & 0xFFFFFFF8L;
									if (obj28 != null)
									{
										object obj29 = obj3 + 88;
										obj29 = Button_TournamentEndedState;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										GameObject gameObject = startDelayText.gameObject;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+18]");
										bool flag9 = (nint)0 < (nint)8;
										object obj30 = !flag9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+18]");
										object obj31 = -8;
										bool flag10 = obj31 == null;
										object obj32 = ~obj30;
										object obj33 = obj32 | flag10;
										if (obj33 == null)
										{
											object obj34 = obj3 + 96;
											obj34 = gameObject;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj35 = this + 208;
											obj35 = obj3;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X21_v20-B0]");
											object obj36 = 0;
											object obj37 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2664;
											object obj38 = (nint)0 + (nint)3328;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											Action<object> action = default(Action<object>);
											action..ctor((object)this, (IntPtr)obj38);
											object obj39 = (nint)0 + (nint)2416;
											object obj40 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
											object obj41 = (nint)0 + (nint)3336;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											Action<object> action2 = default(Action<object>);
											action2..ctor((object)this, (IntPtr)obj41);
											eventChannel.OnMassPlayerStateChanged += action2;
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
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
		object obj2 = (nint)0 + (nint)3336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		eventChannel.OnMassPlayerStateChanged -= action;
	}

	private void Initialize(MassTournamentServerConnector serverConnector)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_007e: Expected I, but got O
		//IL_0036: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
		object obj2 = (nint)0 + (nint)3336;
		object obj3 = this + 192;
		MassTournamentServerConnector massTournamentServerConnector = default(MassTournamentServerConnector);
		obj3 = massTournamentServerConnector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj5 = (nint)0 + (nint)2368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
	}

	private void Reload(MassTournamentPlayerState p)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 200;
		obj = p;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PopulateCurrentStatusTimeDisplay((MassTournamentPlayerState)obj);
		PopulateTimePeriods();
		PopulateMainButton((MassTournamentPlayerState)obj);
	}

	private void PopulateCurrentStatusTimeDisplay(MassTournamentPlayerState player)
	{
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0254: Expected O, but got I
		if (player == null)
		{
			return;
		}
		GameObject gameObject = leftTimer.gameObject;
		gameObject.SetActive(value: true);
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)(object)gameObject).GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		if (!cachedMassEvent.IsRegistrationOpen || player.<IsRegistered>k__BackingField)
		{
			MassEventStageViewModel activeStage = connector.GetActiveStage();
			MassEventPlayWindowViewModel activePlayWindow = connector.GetActivePlayWindow();
			if (activePlayWindow != null)
			{
				object text = "Picking audio files is not supported on iOS" + 312;
				TextMeshProExtensions.Localize(stageDurationTitle, (string)text);
				leftTimer.SetDate(activePlayWindow.<FinishTime>k__BackingField);
				return;
			}
			MassEventPlayWindowViewModel massEventPlayWindowViewModel = activeStage.NextPlayWindow();
			if (massEventPlayWindowViewModel != null)
			{
				object text2 = "Picking audio files is not supported on iOS" + 328;
				TextMeshProExtensions.Localize(stageDurationTitle, (string)text2);
				leftTimer.SetDate(massEventPlayWindowViewModel.<StartingTime>k__BackingField);
				return;
			}
			MassEventStageViewModel upcomingStage = connector.GetUpcomingStage();
			if (upcomingStage != null)
			{
				object text3 = "Network Authentication Required" + 224;
				TextMeshProExtensions.Localize(stageDurationTitle, (string)text3);
				object obj = Enumerable.First((IEnumerable<object>)upcomingStage.<PlayWindows>k__BackingField);
				DateTimeText dateTimeText = leftTimer;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v22 (System.Object)+10]");
				dateTimeText.SetDate((DateTime)0);
			}
			else
			{
				object text4 = "ThisIsFakeReceiptData" + 1272;
				TextMeshProExtensions.Localize(stageDurationTitle, (string)text4);
				GameObject gameObject2 = leftTimer.gameObject;
				gameObject2.SetActive(value: false);
			}
		}
		else
		{
			object text5 = "Read object reference Id '{0}' for {1}." + 1280;
			TextMeshProExtensions.Localize(stageDurationTitle, (string)text5);
			MassTournamentInfo tournamentLiveData2 = ((MassTournamentServerConnector)(object)stageDurationTitle).GetTournamentLiveData();
			MassEventModel cachedMassEvent2 = MassTournamentManager.GetCachedMassEvent(tournamentLiveData2.<Id>k__BackingField);
			leftTimer.SetDate(cachedMassEvent2.<RegistrationDeadline>k__BackingField);
		}
	}

	private unsafe void PopulateTimePeriods()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		//IL_00f5: Expected I, but got O
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if ((object)connector != null)
		{
			object obj = typeof(TypeConverter<ushort, char>) + 3400;
			MassEventStageViewModel activeStage = connector.GetActiveStage();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			bool flag = activeStage == null;
			nint num = 1;
			if (!flag)
			{
				bool flag2 = activeStage.<PlayWindows>k__BackingField == null;
				num = 1;
				if (!flag2)
				{
					object obj2 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object[] array = default(object[]);
					bool flag3 = array == null;
					int num2 = default(int);
					num = (nint)(&num2);
					if (!flag3)
					{
						object obj3 = default(object);
						bool flag4 = obj3 == null;
						nint num3 = (nint)(&num2);
						if (!flag4)
						{
							nint num4 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
							num3 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag5 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v12 (Il2CppClass<System.Object[]>)+40]");
							num = 0;
							if (flag5)
							{
								goto IL_01c7;
							}
						}
						bool flag6 = array.Length == 0;
						num = num3;
						if (!flag6)
						{
							object text = "October" + 2072;
							object obj4 = array + 32;
							obj4 = obj3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							TextMeshProExtensions.Localize(playPeriodField, (string)text, array);
							return;
						}
						goto IL_01b9;
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_01b9;
		IL_01c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_01b9:
		ex = new IndexOutOfRangeException();
		goto IL_01c7;
	}

	private void PopulateMainButton(MassTournamentPlayerState player)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_08a2: Expected O, but got I
		//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected O, but got Unknown
		//IL_08c6: Expected O, but got I
		//IL_08d6: Expected O, but got I
		//IL_08f8: Expected O, but got I4
		//IL_00cb: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_008a: Expected O, but got I4
		//IL_0915: Unknown result type (might be due to invalid IL or missing references)
		//IL_091a: Expected O, but got Unknown
		//IL_0930: Expected O, but got I
		//IL_0941: Expected I, but got O
		//IL_095f: Expected O, but got I
		//IL_00ba: Expected O, but got I
		//IL_019c: Expected O, but got I4
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected O, but got Unknown
		//IL_05ea: Expected O, but got I4
		//IL_06a2: Expected O, but got I4
		//IL_0286: Expected O, but got I4
		//IL_0669: Expected O, but got I4
		//IL_082b: Expected O, but got I4
		//IL_06fd: Expected O, but got I4
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_035b: Expected O, but got I4
		//IL_07a4: Expected O, but got I4
		//IL_02d1: Expected O, but got I
		//IL_03cb: Expected O, but got I4
		//IL_03f9: Expected O, but got I4
		//IL_0864: Expected O, but got I4
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_0484: Expected O, but got I4
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected O, but got Unknown
		//IL_052d: Expected O, but got I
		//IL_053b: Expected I, but got O
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_0579: Expected O, but got I4
		if (player == null)
		{
			return;
		}
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3040;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj2 = obj;
		}
		object obj4 = (nint)0 + (nint)2160;
		object obj5 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v4+B8]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v43+8]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v43+8]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v49+B8]");
				obj6 = 0;
			}
			object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)864;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj6, (IntPtr)obj11);
			object obj12 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v48+B8]");
			object obj13 = (nint)0 + (nint)8;
			obj13 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			action = action2;
		}
		object obj14 = (nint)0 + (nint)2200;
		ArraysExtensions.ForEach(_buttons, action);
		object obj15 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X0_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj16 = !flag4;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom);
		bool flag5 = TournamentStatusExtensions.IsFinished(tournamentStatus);
		if (flag5)
		{
			goto IL_0175;
		}
		MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)flag5).GetTournamentLiveData();
		MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
		GameObject gameObject;
		if (!cachedMassEvent.IsRegistrationOpen || player.<IsRegistered>k__BackingField)
		{
			MassEventStageViewModel activeStage = connector.GetActiveStage();
			MassEventPlayWindowViewModel activePlayWindow = connector.GetActivePlayWindow();
			if (activePlayWindow != null)
			{
				if (player.<TriesLeft>k__BackingField >= 1)
				{
					bool flag6 = player.<NextStageEligibility>k__BackingField != MassEventNextStageEligibility.EligibleToReserve;
					object obj17 = 0;
					MassTournamentBottomBar massTournamentBottomBar = (MassTournamentBottomBar)(object)activePlayWindow;
					if (!flag6)
					{
						MassTournamentInfo tournamentLiveData2 = ((MassTournamentServerConnector)(object)activePlayWindow).GetTournamentLiveData();
						MassEventModel cachedMassEvent2 = MassTournamentManager.GetCachedMassEvent(tournamentLiveData2.<Id>k__BackingField);
						object obj18 = (nint)0 + (nint)1712;
						obj17 = obj18;
						object obj19 = Enumerable.Last((IEnumerable<object>)cachedMassEvent2.<Stages>k__BackingField);
						bool flag7 = obj19 == activeStage;
						massTournamentBottomBar = (MassTournamentBottomBar)obj19;
						if (flag7)
						{
							gameObject = Button_ReserveState;
							bool flag8 = (object)Button_ReserveState == null;
							object obj20 = !flag8;
							if (obj20 != null)
							{
								goto IL_0184;
							}
							goto IL_0872;
						}
					}
					TimeSpan userInitialDelay = massTournamentBottomBar.GetUserInitialDelay();
					object obj21 = typeof(DataRelation) + 712;
					object obj22 = obj21;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X0_v42+E4]");
					bool flag9 = (nint)0 == 0;
					object obj23 = !flag9;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					DateTime dateTime2 = default(DateTime);
					DateTime dateTime = dateTime2.Add(userInitialDelay);
					DateTime now = DateTime.Now;
					bool flag10 = dateTime > now;
					if (flag10)
					{
						TimeSpan userInitialDelay2 = ((MassTournamentBottomBar)flag10).GetUserInitialDelay();
						object obj24 = obj21;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X0_v52+E4]");
						bool flag11 = (nint)0 == 0;
						object obj25 = !flag11;
						if (obj25 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						DateTime dateTime3 = dateTime2.Add(userInitialDelay2);
						DateTime now2 = DateTime.Now;
						TimeSpan timeSpan = dateTime3 - now2;
						object obj26 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
						object obj27 = obj26;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v60+E4]");
						bool flag12 = (nint)0 == 0;
						object obj28 = !flag12;
						if (obj28 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						TimeSpan timeSpan2 = default(TimeSpan);
						double totalSeconds = timeSpan2.TotalSeconds;
						Button_PlayStartsInState.SetActive(value: true);
						GameObject gameObject2 = startDelayText.gameObject;
						gameObject2.SetActive(value: true);
						startDelayText.SetDate(dateTime3);
						object obj29 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj30 = (nint)0 + (nint)3312;
						Action action3 = default(Action);
						action3..ctor(this, (IntPtr)obj30);
						object obj31 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
						object obj32 = obj31;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v69+E4]");
						bool flag13 = (nint)0 == 0;
						object obj33 = !flag13;
						if (obj33 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Coroutine coroutine = CoroutineDummy.WaitForSeconds((float)totalSeconds, action3);
					}
					else
					{
						Button_PlayNowState.SetActive(value: true);
					}
					return;
				}
				if (player.<NextStageEligibility>k__BackingField != MassEventNextStageEligibility.NotEligible || (player.<IsRegistered>k__BackingField && player.<LastStageReached>k__BackingField >= activeStage.<Id>k__BackingField))
				{
					gameObject = Button_OutOfTriesState;
					bool flag14 = (object)Button_OutOfTriesState == null;
					object obj34 = !flag14;
					if (obj34 != null)
					{
						goto IL_0184;
					}
				}
				else
				{
					gameObject = Button_WatcherState;
					bool flag15 = (object)Button_WatcherState == null;
					object obj35 = !flag15;
					if (obj35 != null)
					{
						goto IL_0184;
					}
				}
			}
			else
			{
				object obj36 = typeof(DataRelation) + 712;
				object obj37 = obj36;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v24+E4]");
				bool flag16 = (nint)0 == 0;
				object obj38 = !flag16;
				if (obj38 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now3 = DateTime.Now;
				MassEventPlayWindowViewModel massEventPlayWindowViewModel = activeStage.NextPlayWindow(now3);
				if (massEventPlayWindowViewModel != null)
				{
					gameObject = Button_PlayStartsInState;
					bool flag17 = (object)Button_PlayStartsInState == null;
					object obj39 = !flag17;
					if (obj39 != null)
					{
						goto IL_0184;
					}
				}
				else
				{
					MassTournamentInfo tournamentLiveData3 = ((MassTournamentServerConnector)(object)massEventPlayWindowViewModel).GetTournamentLiveData();
					MassEventModel cachedMassEvent3 = MassTournamentManager.GetCachedMassEvent(tournamentLiveData3.<Id>k__BackingField);
					object obj40 = Enumerable.Last((IEnumerable<object>)cachedMassEvent3.<Stages>k__BackingField);
					if (obj40 == activeStage)
					{
						goto IL_0175;
					}
					gameObject = Button_StageEndedState;
					bool flag18 = (object)Button_StageEndedState == null;
					object obj41 = !flag18;
					if (obj41 != null)
					{
						goto IL_0184;
					}
				}
			}
		}
		else
		{
			gameObject = Button_RegisterState;
			bool flag19 = (object)Button_RegisterState == null;
			object obj42 = !flag19;
			if (obj42 != null)
			{
				goto IL_0184;
			}
		}
		goto IL_0872;
		IL_0175:
		gameObject = Button_TournamentEndedState;
		goto IL_0184;
		IL_0872:
		throw new NullReferenceException();
		IL_0184:
		gameObject.SetActive(value: true);
	}

	private void ShowMassParticipationPopup(MassTournamentPlayerState player, Action<GameObject> acceptCallback, bool confirmButton)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		//IL_0153: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01f7: Expected O, but got I4
		//IL_0220: Expected O, but got I
		//IL_105c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1061: Expected O, but got Unknown
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_0359: Expected O, but got I4
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_10ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b0: Expected O, but got Unknown
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected O, but got Unknown
		//IL_06e4: Expected O, but got I4
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_03d8: Expected O, but got I4
		//IL_02ac: Expected O, but got I4
		//IL_1102: Unknown result type (might be due to invalid IL or missing references)
		//IL_1107: Expected O, but got Unknown
		//IL_1111: Unknown result type (might be due to invalid IL or missing references)
		//IL_1116: Expected O, but got Unknown
		//IL_111e: Expected I, but got O
		//IL_112e: Expected O, but got I
		//IL_16cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d1: Expected O, but got Unknown
		//IL_11c4: Expected O, but got I
		//IL_11e8: Expected O, but got I4
		//IL_13f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_13fc: Expected O, but got Unknown
		//IL_141c: Expected O, but got I
		//IL_1169: Expected O, but got I
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_045e: Expected O, but got I4
		//IL_1a1a: Expected O, but got I
		//IL_1457: Expected O, but got I
		//IL_138e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1393: Expected O, but got Unknown
		//IL_139c: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a1: Expected O, but got Unknown
		//IL_13b1: Expected O, but got I
		//IL_077a: Unknown result type (might be due to invalid IL or missing references)
		//IL_077f: Expected O, but got Unknown
		//IL_07a9: Expected O, but got I4
		//IL_1177: Unknown result type (might be due to invalid IL or missing references)
		//IL_117c: Expected O, but got Unknown
		//IL_1185: Unknown result type (might be due to invalid IL or missing references)
		//IL_118a: Expected O, but got Unknown
		//IL_0484: Expected O, but got I4
		//IL_07d2: Expected O, but got I
		//IL_07da: Expected I4, but got O
		//IL_15f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f5: Expected O, but got Unknown
		//IL_160b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1610: Expected O, but got Unknown
		//IL_1465: Unknown result type (might be due to invalid IL or missing references)
		//IL_146a: Expected O, but got Unknown
		//IL_1473: Unknown result type (might be due to invalid IL or missing references)
		//IL_1478: Expected O, but got Unknown
		//IL_049a: Expected I, but got O
		//IL_04aa: Expected O, but got I
		//IL_04e1: Expected O, but got I
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0553: Expected O, but got Unknown
		//IL_0853: Expected I, but got O
		//IL_0860: Expected O, but got I4
		//IL_0868: Expected I4, but got O
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected O, but got Unknown
		//IL_05b8: Expected I, but got O
		//IL_05c8: Expected O, but got I
		//IL_08b0: Expected I, but got O
		//IL_08bd: Expected I4, but got O
		//IL_065e: Expected O, but got I
		//IL_0682: Expected O, but got I4
		//IL_151d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1522: Expected O, but got Unknown
		//IL_1542: Expected O, but got I
		//IL_0603: Expected O, but got I
		//IL_08df: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Expected O, but got Unknown
		//IL_08ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Expected O, but got Unknown
		//IL_08fb: Expected I, but got O
		//IL_090b: Expected O, but got I
		//IL_09a1: Expected O, but got I
		//IL_09c5: Expected O, but got I4
		//IL_1586: Expected O, but got I
		//IL_14a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ab: Expected O, but got Unknown
		//IL_14b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b8: Expected O, but got Unknown
		//IL_14c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c6: Expected O, but got Unknown
		//IL_14d6: Expected O, but got I
		//IL_0a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a68: Expected O, but got Unknown
		//IL_0a74: Expected O, but got I
		//IL_0a8c: Expected O, but got I
		//IL_0946: Expected O, but got I
		//IL_0611: Unknown result type (might be due to invalid IL or missing references)
		//IL_0616: Expected O, but got Unknown
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected O, but got Unknown
		//IL_09d8: Expected I, but got O
		//IL_09e0: Expected I4, but got O
		//IL_178e: Expected O, but got I
		//IL_17b9: Expected I, but got O
		//IL_17c1: Expected I4, but got O
		//IL_0ac7: Expected O, but got I
		//IL_09f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fa: Expected O, but got Unknown
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a08: Expected O, but got Unknown
		//IL_0a18: Expected O, but got I
		//IL_0a36: Expected I, but got O
		//IL_0a3e: Expected I4, but got O
		//IL_1594: Unknown result type (might be due to invalid IL or missing references)
		//IL_1599: Expected O, but got Unknown
		//IL_15a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a7: Expected O, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_0959: Expected O, but got Unknown
		//IL_0962: Unknown result type (might be due to invalid IL or missing references)
		//IL_0967: Expected O, but got Unknown
		//IL_0b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b53: Expected O, but got Unknown
		//IL_0b6b: Expected O, but got I
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected O, but got Unknown
		//IL_0c01: Expected O, but got I
		//IL_0c25: Expected O, but got I4
		//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ada: Expected O, but got Unknown
		//IL_0ae3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Expected O, but got Unknown
		//IL_0cda: Expected O, but got I
		//IL_0ba6: Expected O, but got I
		//IL_0d70: Expected O, but got I
		//IL_0d8e: Expected O, but got I4
		//IL_0c38: Expected I, but got O
		//IL_0c40: Expected I4, but got O
		//IL_0f7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f7f: Expected O, but got Unknown
		//IL_0fa6: Expected I, but got O
		//IL_0faf: Expected O, but got I4
		//IL_0d15: Expected O, but got I
		//IL_0c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5b: Expected O, but got Unknown
		//IL_0c71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c76: Expected O, but got Unknown
		//IL_0c86: Expected O, but got I
		//IL_0ca4: Expected I, but got O
		//IL_0cac: Expected I4, but got O
		//IL_0dbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc0: Expected O, but got Unknown
		//IL_0dd6: Expected O, but got I
		//IL_0de7: Expected I, but got O
		//IL_0bb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb9: Expected O, but got Unknown
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc7: Expected O, but got Unknown
		//IL_0feb: Expected O, but got I
		//IL_100d: Expected O, but got I4
		//IL_0df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dfb: Expected O, but got Unknown
		//IL_0e25: Expected I, but got O
		//IL_0e2e: Expected O, but got I4
		//IL_0ef9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efe: Expected O, but got Unknown
		//IL_0f14: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f19: Expected O, but got Unknown
		//IL_0f29: Expected O, but got I
		//IL_0f49: Expected O, but got I4
		//IL_0f52: Expected O, but got I4
		//IL_1241: Expected O, but got I
		//IL_0d23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d28: Expected O, but got Unknown
		//IL_0d31: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d36: Expected O, but got Unknown
		//IL_0e65: Expected O, but got I
		//IL_12c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12cc: Expected O, but got Unknown
		//IL_193b: Expected O, but got I
		//IL_195d: Expected O, but got I
		//IL_124f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1254: Expected O, but got Unknown
		//IL_125d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1262: Expected O, but got Unknown
		//IL_1854: Unknown result type (might be due to invalid IL or missing references)
		//IL_1859: Expected O, but got Unknown
		//IL_188c: Expected O, but got I
		//IL_0ea0: Expected O, but got I
		//IL_1353: Expected O, but got I4
		//IL_12ff: Expected O, but got I
		//IL_1221: Unknown result type (might be due to invalid IL or missing references)
		//IL_1226: Expected O, but got Unknown
		//IL_0eae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb3: Expected O, but got Unknown
		//IL_0ebc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec1: Expected O, but got Unknown
		//IL_1361: Unknown result type (might be due to invalid IL or missing references)
		//IL_1366: Expected O, but got Unknown
		//IL_137c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1381: Expected O, but got Unknown
		//IL_130d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1312: Expected O, but got Unknown
		//IL_131b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1320: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3048;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		bool flag3 = default(bool);
		bool flag2 = flag3;
		MassTournamentBottomBar massTournamentBottomBar = null;
		DateTime dateTime;
		TicketsConsumptionConfirmation ticketsConsumptionConfirmation = default(TicketsConsumptionConfirmation);
		object obj23;
		object obj28 = default(object);
		LocalizableText localizableText;
		object obj44 = default(object);
		object obj48;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		Action<GameObject> action = default(Action<GameObject>);
		nint num;
		if (!flag)
		{
			object obj3 = obj2 + 16;
			obj3 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag4 = (object)connector == null;
			flag2 = flag3;
			massTournamentBottomBar = this;
			if (!flag4)
			{
				MassEventStageViewModel activeStage = connector.GetActiveStage();
				bool flag5 = activeStage == null;
				flag2 = flag3;
				massTournamentBottomBar = this;
				if (!flag5)
				{
					object obj5 = (??)activeStage.<MaxTrails>k__BackingField & -4294967295L;
					if ((nint)obj5 == 1)
					{
						object obj6 = obj3;
						GameObject gameObject = base.gameObject;
						bool flag6 = obj3 == null;
						flag2 = flag3;
						massTournamentBottomBar = null;
						if (flag6)
						{
							goto IL_1615;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X19_v23+18]");
						object obj7 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X19_v23+40]");
						object obj8 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X19_v23+28]");
						object obj9 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v506 @ X3_v17 (should have been resolved before IL gen)");
					}
					bool flag7 = player == null;
					flag2 = flag3;
					massTournamentBottomBar = this;
					if (!flag7)
					{
						if (player.<TriesLeft>k__BackingField != 0)
						{
							object obj10 = typeof(Queue<string>) + 848;
							object obj11 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v68+E4]");
							bool flag8 = (nint)0 == 0;
							object obj12 = !flag8;
							if (obj12 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							object obj13 = (nint)0 + (nint)2200;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
							SessionModel sessionModel = default(SessionModel);
							bool flag9 = (object)sessionModel == null;
							flag2 = flag3;
							massTournamentBottomBar = this;
							if (!flag9)
							{
								Room currentRoom = sessionModel.CurrentRoom;
								DateTime? massActiveClusterStartTime = SFSKammelnaRoomExtensions.GetMassActiveClusterStartTime(currentRoom);
								object obj14 = (??)massActiveClusterStartTime & 1;
								if (obj14 != null)
								{
									massTournamentBottomBar = null;
									dateTime = (DateTime)0;
								}
								else
								{
									object obj15 = typeof(DataRelation) + 712;
									object obj16 = obj15;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X0_v139+E4]");
									bool flag10 = (nint)0 == 0;
									object obj17 = !flag10;
									if (obj17 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									DateTime now = DateTime.Now;
									DateTime dateTime3 = default(DateTime);
									DateTime dateTime2 = dateTime3.AddMinutes(1.0);
									massTournamentBottomBar = null;
									dateTime = dateTime2;
								}
								bool flag11 = (object)connector == null;
								flag2 = flag3;
								if (!flag11)
								{
									MassEventStageViewModel activeStage2 = connector.GetActiveStage();
									bool flag12 = activeStage2 == null;
									flag2 = flag3;
									if (!flag12)
									{
										object obj18 = typeof(MemberAchievementClanFeedData) + 2976;
										object obj19 = obj18;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v717 @ X0_v77+E4]");
										bool flag13 = (nint)0 == 0;
										object obj20 = !flag13;
										if (obj20 == null)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										}
										object obj21 = (nint)0 + (nint)1048;
										flag2 = (byte)(int)obj21 != 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
										bool flag14 = (object)ticketsConsumptionConfirmation == null;
										action = null;
										massTournamentBottomBar = null;
										if (!flag14)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v76 (Server.Models.MassEventStageViewModel)+24]");
											ticketsConsumptionConfirmation.Initialize(0, player.<TriesLeft>k__BackingField, dateTime);
											GameObject gameObject2 = ticketsConsumptionConfirmation.gameObject;
											bool flag15 = (object)gameObject2 == null;
											num = unchecked((nint)null);
											action = (Action<GameObject>)player.<TriesLeft>k__BackingField;
											flag2 = (byte)(int)dateTime != 0;
											massTournamentBottomBar = null;
											if (!flag15)
											{
												gameObject2.SetActive(value: true);
												IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
												bool flag16 = popupWindowBuilderNeedsTitle == null;
												num = unchecked((nint)null);
												action = null;
												flag2 = (byte)(int)dateTime != 0;
												massTournamentBottomBar = null;
												if (!flag16)
												{
													object obj22 = typeof(System.IOAsyncCallback) + 392;
													obj23 = "tournament_participate_warning_body_with_tickets_warning_daily" + 16;
													nint num2 = (nint)popupWindowBuilderNeedsTitle;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X8_v72 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
													object obj24 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X8_v72 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
													if ((nint)0 == 0)
													{
														goto IL_0987;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v930 @ X8_v72 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
													object obj25 = (nint)0 + (nint)8;
													while (true)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X10_v69-8]");
														if (0 == (nint)obj22)
														{
															break;
														}
														obj25 += 16;
														obj24--;
														if ((nint)obj24 != 1)
														{
															continue;
														}
														goto IL_0987;
													}
													object obj26 = num2 + obj25;
													object obj27 = obj26 + 312;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X8_v121+8]");
													action = (Action<GameObject>)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v362 @ X8_v121] (should have been resolved before IL gen)");
													bool flag17 = obj28 == null;
													num = unchecked((nint)null);
													flag2 = (byte)(int)dateTime != 0;
													massTournamentBottomBar = (MassTournamentBottomBar)obj23;
													if (!flag17)
													{
														goto IL_0a54;
													}
												}
											}
										}
									}
								}
							}
						}
						else
						{
							bool flag18 = (object)connector == null;
							flag2 = flag3;
							massTournamentBottomBar = this;
							if (!flag18)
							{
								MassEventStageViewModel activeStage3 = connector.GetActiveStage();
								if (player.ShouldRefreshTickets(activeStage3))
								{
									object obj29 = typeof(DataRelation) + 712;
									object obj30 = obj29;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v622 @ X0_v35+E4]");
									bool flag19 = (nint)0 == 0;
									object obj31 = !flag19;
									if (obj31 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									DateTime now2 = DateTime.Now;
									TimeSpan timeSpan = player.<NextTicketTime>k__BackingField - now2;
									object obj32 = typeof(DataRelation) + 824;
									object obj33 = obj32;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v35+E4]");
									bool flag20 = (nint)0 == 0;
									object obj34 = !flag20;
									if (obj34 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									string durationText = DateTimeUtil.GetDurationText(timeSpan);
									object obj35 = "Network Authentication Required" + 3128;
									PopupWindowBuilder popupWindowBuilder = PopupWindowBuilder.CreateError(null, (string)obj35);
									bool flag21 = popupWindowBuilder == null;
									action = null;
									flag2 = false;
									massTournamentBottomBar = (MassTournamentBottomBar)obj35;
									if (!flag21)
									{
										object title = "Drop Menu Toggle" + 3600;
										IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody = popupWindowBuilder.Titled((string)title);
										object obj36 = typeof(TypeConverter<ushort, char>) + 3400;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
										object[] array = default(object[]);
										bool flag22 = array == null;
										action = null;
										flag2 = false;
										massTournamentBottomBar = (MassTournamentBottomBar)1;
										if (!flag22)
										{
											bool flag23 = durationText == null;
											MassTournamentBottomBar massTournamentBottomBar2 = (MassTournamentBottomBar)1;
											if (!flag23)
											{
												nint num3 = (nint)array;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v56 (Il2CppClass<System.Object[]>)+40]");
												massTournamentBottomBar2 = (MassTournamentBottomBar)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
												bool flag24 = ex == null;
												action = null;
												flag2 = false;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X8_v56 (Il2CppClass<System.Object[]>)+40]");
												massTournamentBottomBar = (MassTournamentBottomBar)0;
												if (flag24)
												{
													goto IL_1631;
												}
											}
											bool flag25 = array.Length == 0;
											action = null;
											flag2 = false;
											massTournamentBottomBar = massTournamentBottomBar2;
											if (flag25)
											{
												goto IL_1623;
											}
											object obj37 = array + 32;
											obj37 = durationText;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object text = "startPosition" + 4064;
											localizableText = TextMeshProExtensions.LocalizeWith((string)text, array);
											bool flag26 = popupWindowBuilderNeedsBody == null;
											action = null;
											flag2 = false;
											massTournamentBottomBar = (MassTournamentBottomBar)(object)array;
											if (!flag26)
											{
												object obj38 = typeof(System.IOAsyncCallback) + 384;
												nint num4 = (nint)popupWindowBuilderNeedsBody;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v48 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
												object obj39 = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v48 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
												if ((nint)0 == 0)
												{
													goto IL_0644;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v936 @ X8_v48 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
												object obj40 = (nint)0 + (nint)8;
												while (true)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X10_v25-8]");
													if (0 == (nint)obj38)
													{
														break;
													}
													obj40 += 16;
													obj39--;
													if ((nint)obj39 != 1)
													{
														continue;
													}
													goto IL_0644;
												}
												object obj41 = obj40 + 1;
												object obj42 = num4 + obj41;
												object obj43 = obj42 + 312;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1030 @ X0_v59+8]");
												action = (Action<GameObject>)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1030 @ X0_v59] (should have been resolved before IL gen)");
												bool flag27 = obj44 == null;
												flag2 = false;
												massTournamentBottomBar = (MassTournamentBottomBar)(object)localizableText;
												if (!flag27)
												{
													goto IL_150e;
												}
											}
										}
									}
								}
								else
								{
									object obj45 = "Network Authentication Required" + 3128;
									PopupWindowBuilder popupWindowBuilder2 = PopupWindowBuilder.CreateError(null, (string)obj45);
									bool flag28 = popupWindowBuilder2 == null;
									action = null;
									flag2 = flag3;
									massTournamentBottomBar = (MassTournamentBottomBar)obj45;
									if (!flag28)
									{
										object obj46 = "Drop Menu Toggle" + 3600;
										IPopupWindowBuilderNeedsBody popupWindowBuilderNeedsBody2 = popupWindowBuilder2.Titled((string)obj46);
										bool flag29 = popupWindowBuilderNeedsBody2 == null;
										action = null;
										flag2 = flag3;
										massTournamentBottomBar = (MassTournamentBottomBar)obj46;
										if (!flag29)
										{
											object obj47 = typeof(System.IOAsyncCallback) + 384;
											obj48 = "Network Authentication Required" + 920;
											nint num5 = (nint)popupWindowBuilderNeedsBody2;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v22 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
											object obj49 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v22 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+12E]");
											if ((nint)0 == 0)
											{
												goto IL_11aa;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X8_v22 (Il2CppClass<IPopupWindowBuilderNeedsBody>)+B0]");
											object obj50 = (nint)0 + (nint)8;
											while (true)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X10_v15-8]");
												if (0 == (nint)obj47)
												{
													break;
												}
												obj50 += 16;
												obj49--;
												if ((nint)obj49 != 1)
												{
													continue;
												}
												goto IL_11aa;
											}
											object obj51 = num5 + obj50;
											object obj52 = obj51 + 312;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X8_v29+8]");
											action = (Action<GameObject>)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v371 @ X8_v29] (should have been resolved before IL gen)");
											bool flag30 = obj44 == null;
											flag2 = flag3;
											massTournamentBottomBar = (MassTournamentBottomBar)obj48;
											if (!flag30)
											{
												goto IL_13e8;
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
		goto IL_1615;
		IL_1340:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj53 = 9;
		goto IL_19a6;
		IL_15e7:
		object obj55;
		object obj54 = obj55 + 9;
		object obj57;
		object obj56 = obj57 + obj54;
		object obj58 = obj56 + 312;
		goto IL_1a02;
		IL_0644:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v970 @ X0_v56+8]");
		action = (Action<GameObject>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v970 @ X0_v56] (should have been resolved before IL gen)");
		bool flag31 = obj44 == null;
		object obj59 = !flag31;
		if (obj59 != null)
		{
			goto IL_150e;
		}
		flag2 = false;
		massTournamentBottomBar = (MassTournamentBottomBar)(object)localizableText;
		goto IL_1615;
		IL_0d56:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1201 @ X0_v121+8]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1201 @ X0_v121] (should have been resolved before IL gen)");
		bool flag32 = !flag3;
		object obj61 = 1;
		object obj63 = default(object);
		object obj62 = obj63;
		object obj64 = obj63;
		if (!flag32)
		{
			goto IL_0dac;
		}
		goto IL_0f70;
		IL_15d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj65 = default(object);
		obj58 = obj65;
		goto IL_1a02;
		IL_0f70:
		object label = "COORDINATE_TYPE_GCJ_02" + 1864;
		PopupButton popupButton = PopupButton.Neutral((string)label, null, dismiss: true);
		bool flag33 = obj64 == null;
		num = unchecked((nint)null);
		action = (Action<GameObject>)1;
		flag2 = false;
		massTournamentBottomBar = null;
		object obj66;
		object obj67;
		object obj68;
		object obj69;
		bool flag35;
		PopupButton popupButton2;
		object obj71;
		bool flag36;
		PopupButton popupButton3;
		if (!flag33)
		{
			obj66 = obj67;
			obj68 = obj64;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1306 @ X8_v90+12E]");
			obj69 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1306 @ X8_v90+12E]");
			bool flag34 = (nint)0 == 0;
			object obj70 = !flag34;
			flag35 = false;
			popupButton2 = popupButton;
			if (obj70 != null)
			{
				goto IL_122b;
			}
			flag36 = false;
			obj71 = obj67;
			obj62 = obj64;
			popupButton3 = popupButton;
			goto IL_12a2;
		}
		goto IL_1615;
		IL_1a02:
		object obj72 = obj58;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v8+8]");
		object obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v504 @ X2_v5 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_177e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v79+8]");
		action = (Action<GameObject>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v363 @ X8_v79] (should have been resolved before IL gen)");
		GameObject gameObject3 = ticketsConsumptionConfirmation.gameObject;
		object obj74 = default(object);
		bool flag37 = obj74 == null;
		num = unchecked((nint)null);
		flag2 = (byte)(int)dateTime != 0;
		massTournamentBottomBar = null;
		object obj81 = default(object);
		if (!flag37)
		{
			obj67 = typeof(System.IOAsyncCallback) + 368;
			object obj75 = obj74;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1115 @ X8_v80+12E]");
			object obj76 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1115 @ X8_v80+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0be7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1115 @ X8_v80+B0]");
			object obj77 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X10_v59-8]");
				if (0 == (nint)obj67)
				{
					break;
				}
				obj77 += 16;
				obj76--;
				if ((nint)obj76 != 1)
				{
					continue;
				}
				goto IL_0be7;
			}
			object obj78 = obj77 + 1;
			object obj79 = obj75 + obj78;
			object obj80 = obj79 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1150 @ X0_v129+8]");
			action = (Action<GameObject>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1150 @ X0_v129] (should have been resolved before IL gen)");
			bool flag38 = obj81 == null;
			num = unchecked((nint)null);
			flag2 = (byte)(int)dateTime != 0;
			massTournamentBottomBar = (MassTournamentBottomBar)(object)gameObject3;
			if (!flag38)
			{
				goto IL_0cc2;
			}
		}
		goto IL_1615;
		IL_150e:
		object obj82 = typeof(System.IOAsyncCallback) + 368;
		object obj83 = obj82;
		obj57 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v9+12E]");
		object obj84 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v9+12E]");
		bool flag39 = (nint)0 == 0;
		flag3 = false;
		if (flag39)
		{
			goto IL_15d0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v9+B0]");
		obj55 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X10_v5-8]");
			bool flag40 = 0 == (nint)obj83;
			flag3 = false;
			if (flag40)
			{
				break;
			}
			obj55 += 16;
			obj84--;
			bool flag41 = (nint)obj84 != 1;
			flag3 = false;
			if (flag41)
			{
				continue;
			}
			goto IL_15d0;
		}
		goto IL_15e7;
		IL_0a54:
		object obj85 = typeof(System.IOAsyncCallback) + 384;
		object obj86 = (nint)0 + (nint)2000;
		object obj87 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X8_v78+12E]");
		object obj88 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X8_v78+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0b08;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1024 @ X8_v78+B0]");
		object obj89 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1070 @ X10_v64-8]");
			if (0 == (nint)obj85)
			{
				break;
			}
			obj89 += 16;
			obj88--;
			if ((nint)obj88 != 1)
			{
				continue;
			}
			goto IL_0b08;
		}
		object obj90 = obj87 + obj89;
		object obj91 = obj90 + 312;
		goto IL_177e;
		IL_0ee1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_1840;
		IL_1840:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1461 @ X0_v113] (should have been resolved before IL gen)");
		object label2 = "COORDINATE_TYPE_GCJ_02" + 1864;
		PopupButton popupButton4 = PopupButton.Neutral((string)label2, null, dismiss: true);
		obj66 = obj67;
		obj68 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1306 @ X8_v90+12E]");
		obj69 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1306 @ X8_v90+12E]");
		bool flag42 = (nint)0 == 0;
		flag35 = false;
		obj64 = obj62;
		popupButton2 = popupButton4;
		flag36 = false;
		obj71 = obj67;
		popupButton3 = popupButton4;
		if (!flag42)
		{
			goto IL_122b;
		}
		goto IL_12a2;
		IL_122b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1306 @ X8_v90+B0]");
		object obj92 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1354 @ X10_v41-8]");
			if (0 == (nint)obj66)
			{
				break;
			}
			obj92 += 16;
			obj69--;
			bool flag43 = (nint)obj69 != 1;
			flag36 = flag35;
			obj71 = obj66;
			obj62 = obj64;
			popupButton3 = popupButton2;
			if (flag43)
			{
				continue;
			}
			goto IL_12a2;
		}
		object obj93 = obj68 + obj92;
		object obj94 = obj93 + 312;
		flag36 = flag35;
		obj62 = obj64;
		popupButton3 = popupButton2;
		goto IL_192b;
		IL_0dac:
		object obj95 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj96 = (nint)0 + (nint)872;
		Action action2 = default(Action);
		action2..ctor(obj2, (IntPtr)obj96);
		object label3 = "Complete" + 256;
		PopupButton popupButton5 = PopupButton.Positive((string)label3, action2, dismiss: true);
		bool flag44 = obj62 == null;
		num = unchecked((nint)null);
		action = (Action<GameObject>)1;
		flag2 = false;
		massTournamentBottomBar = (MassTournamentBottomBar)(object)action2;
		if (flag44)
		{
			goto IL_1615;
		}
		object obj97 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1315 @ X8_v103+12E]");
		object obj98 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1315 @ X8_v103+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0ee1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1315 @ X8_v103+B0]");
		object obj99 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1408 @ X10_v49-8]");
			if (0 == (nint)obj67)
			{
				break;
			}
			obj99 += 16;
			obj98--;
			if ((nint)obj98 != 1)
			{
				continue;
			}
			goto IL_0ee1;
		}
		object obj100 = obj97 + obj99;
		object obj101 = obj100 + 312;
		goto IL_1840;
		IL_0b08:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj102 = default(object);
		obj91 = obj102;
		goto IL_177e;
		IL_1623:
		ex = new IndexOutOfRangeException();
		goto IL_1631;
		IL_11aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v31+8]");
		action = (Action<GameObject>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v711 @ X0_v31] (should have been resolved before IL gen)");
		bool flag45 = obj44 == null;
		object obj103 = !flag45;
		if (obj103 != null)
		{
			goto IL_13e8;
		}
		flag2 = flag3;
		massTournamentBottomBar = (MassTournamentBottomBar)obj48;
		goto IL_1615;
		IL_13e8:
		object obj104 = typeof(System.IOAsyncCallback) + 368;
		obj83 = obj104;
		obj57 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v9+12E]");
		object obj105 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v9+12E]");
		if ((nint)0 == 0)
		{
			goto IL_15d0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X8_v9+B0]");
		obj55 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v874 @ X10_v5-8]");
			if (0 == (nint)obj83)
			{
				break;
			}
			obj55 += 16;
			obj105--;
			if ((nint)obj105 != 1)
			{
				continue;
			}
			goto IL_15d0;
		}
		goto IL_15e7;
		IL_12a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_192b;
		IL_192b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1442 @ X0_v91+8]");
		obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1442 @ X0_v91] (should have been resolved before IL gen)");
		object obj106 = obj62;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1453 @ X8_v85+12E]");
		object obj107 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1453 @ X8_v85+12E]");
		if ((nint)0 == 0)
		{
			goto IL_1340;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1453 @ X8_v85+B0]");
		object obj108 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1502 @ X10_v35-8]");
			if (0 == (nint)obj67)
			{
				break;
			}
			obj108 += 16;
			obj107--;
			if ((nint)obj107 != 1)
			{
				continue;
			}
			goto IL_1340;
		}
		object obj109 = obj108 + 9;
		object obj110 = obj106 + obj109;
		object obj111 = obj110 + 312;
		goto IL_19a6;
		IL_1631:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_19a6:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1527 @ X0_v94] (should have been resolved before IL gen)");
		return;
		IL_0987:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v954 @ X0_v134+8]");
		action = (Action<GameObject>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v954 @ X0_v134] (should have been resolved before IL gen)");
		bool flag46 = obj28 == null;
		object obj112 = !flag46;
		if (obj112 != null)
		{
			goto IL_0a54;
		}
		num = unchecked((nint)null);
		flag2 = (byte)(int)dateTime != 0;
		massTournamentBottomBar = (MassTournamentBottomBar)obj23;
		goto IL_1615;
		IL_0cc2:
		object obj113 = obj81;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1170 @ X8_v82+12E]");
		object obj114 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1170 @ X8_v82+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0d56;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1170 @ X8_v82+B0]");
		object obj115 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1203 @ X10_v54-8]");
			if (0 == (nint)obj67)
			{
				break;
			}
			obj115 += 16;
			obj114--;
			if ((nint)obj114 != 1)
			{
				continue;
			}
			goto IL_0d56;
		}
		object obj116 = obj115 + 3;
		object obj117 = obj113 + obj116;
		object obj118 = obj117 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1235 @ X8_v112+8]");
		obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1235 @ X8_v112] (should have been resolved before IL gen)");
		bool flag47 = !flag3;
		object obj119 = !flag47;
		obj61 = 1;
		object obj120 = default(object);
		obj62 = obj120;
		obj64 = obj120;
		if (obj119 != null)
		{
			goto IL_0dac;
		}
		goto IL_0f70;
		IL_0be7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1133 @ X0_v126+8]");
		action = (Action<GameObject>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1133 @ X0_v126] (should have been resolved before IL gen)");
		bool flag48 = obj81 == null;
		object obj121 = !flag48;
		if (obj121 != null)
		{
			goto IL_0cc2;
		}
		num = unchecked((nint)null);
		flag2 = (byte)(int)dateTime != 0;
		massTournamentBottomBar = (MassTournamentBottomBar)(object)gameObject3;
		goto IL_1615;
		IL_1615:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_1623;
	}

	public void ShowPlayPeriodsInfoPopup()
	{
		MassPlayPeriodsInfoPopup massPlayPeriodsInfoPopup = playPeriodsInfo;
		massPlayPeriodsInfoPopup.popup.PopFromCenter();
	}

	public void MainButtonOnClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0063: Expected I, but got O
		//IL_0036: Expected O, but got I
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2640;
		object obj2 = (nint)0 + (nint)3304;
		MassTournamentServerConnector massTournamentServerConnector = connector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)2368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
	}

	private unsafe TimeSpan GetUserInitialDelay()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0247: Expected O, but got I
		//IL_0271: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_02e3: Expected O, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_02ba: Expected O, but got I4
		//IL_0117: Expected O, but got I
		//IL_0141: Expected O, but got I4
		//IL_0187: Expected O, but got I
		//IL_01d6: Expected O, but got I4
		//IL_022b: Expected O, but got I
		//IL_020e: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E606D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_02c8;
		IL_02d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X0_v1 (System.NullReferenceException)+8]");
		return (TimeSpan)0;
		IL_00b8:
		object obj9 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3792;
		object obj10 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		Room currentRoom = sessionModel.CurrentRoom;
		TimeSpan massMaxStageDelay = SFSKammelnaRoomExtensions.GetMassMaxStageDelay(currentRoom);
		object obj11 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v8+B8]");
		object obj12 = 0;
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v25+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag5 = massMaxStageDelay != (TimeSpan)obj12;
		object obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X9_v2+B8]");
		NullReferenceException ex = (NullReferenceException)0;
		if (flag5)
		{
			ex = (NullReferenceException)massMaxStageDelay;
			object obj16 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X8_v12+E4]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			TimeSpan timeSpan = (TimeSpan)ex;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj18 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X8_v16+B8]");
				timeSpan = (TimeSpan)0;
			}
			double totalSeconds = ((TimeSpan*)timeSpan)->TotalSeconds;
			float value = UnityEngine.Random.value;
			double value2 = totalSeconds * (double)value;
			TimeSpan result = TimeSpan.FromSeconds(value2);
			object obj19 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X8_v14+B8]");
			object obj20 = 0;
			return result;
		}
		goto IL_02d6;
		IL_02c8:
		ex = new NullReferenceException();
		goto IL_02d6;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_02c8;
	}

	private void ShowFullList()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2608;
		object obj2 = (nint)0 + (nint)3320;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)2104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private void <PopulateMainButton>b__33_1()
	{
		PopulateMainButton(_player);
	}

	private void <MainButtonOnClick>b__36_0(MassTournamentPlayerState player)
	{
		//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e2: Expected O, but got Unknown
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fd: Expected O, but got Unknown
		//IL_0915: Expected O, but got I
		//IL_0941: Expected O, but got I
		//IL_0951: Expected O, but got I
		//IL_0973: Expected O, but got I4
		//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		//IL_09a3: Expected O, but got I4
		//IL_0504: Expected O, but got I
		//IL_0b28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Expected O, but got Unknown
		//IL_0b43: Expected O, but got I
		//IL_0b4b: Expected I, but got O
		//IL_0b5c: Expected I, but got O
		//IL_0b7a: Expected O, but got I
		//IL_09e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Expected O, but got Unknown
		//IL_0a16: Expected O, but got I4
		//IL_0a23: Expected I, but got O
		//IL_09d3: Expected O, but got I
		//IL_00ab: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_042b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_046d: Expected O, but got I
		//IL_047d: Expected O, but got I
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_01aa: Expected O, but got I4
		//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Expected O, but got Unknown
		//IL_03f0: Expected O, but got I
		//IL_0403: Expected I, but got O
		//IL_01d3: Expected O, but got I
		//IL_01db: Expected I, but got O
		//IL_021c: Expected O, but got I
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02bf: Expected I, but got O
		//IL_02cf: Expected O, but got I
		//IL_0381: Expected O, but got I4
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0574: Expected O, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0583: Expected O, but got Unknown
		//IL_059b: Expected O, but got I
		//IL_030a: Expected O, but got I
		//IL_064d: Expected O, but got I4
		//IL_06c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ce: Expected O, but got Unknown
		//IL_06e6: Expected O, but got I
		//IL_05d6: Expected O, but got I
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0523: Expected O, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected O, but got Unknown
		//IL_0318: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_0721: Expected O, but got I
		//IL_0686: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Expected O, but got Unknown
		//IL_07b3: Expected I, but got O
		//IL_07c3: Expected O, but got I
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected O, but got Unknown
		//IL_0861: Expected O, but got I
		//IL_0874: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected O, but got Unknown
		//IL_088f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0894: Expected O, but got Unknown
		//IL_08b8: Expected O, but got I4
		//IL_07fe: Expected O, but got I
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected O, but got Unknown
		//IL_0b0b: Expected O, but got I
		//IL_080c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected O, but got Unknown
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected O, but got Unknown
		MassTournamentServerConnector massTournamentServerConnector = connector;
		object obj2 = default(object);
		object obj4;
		object obj13;
		object obj14 = default(object);
		object obj16 = default(object);
		Action<object> action;
		nint num;
		object obj3;
		if ((object)connector != null)
		{
			MassTournamentInfo tournamentLiveData = ((MassTournamentServerConnector)this).GetTournamentLiveData();
			if (tournamentLiveData != null)
			{
				MassEventModel cachedMassEvent = MassTournamentManager.GetCachedMassEvent(tournamentLiveData.<Id>k__BackingField);
				if (cachedMassEvent != null)
				{
					if (cachedMassEvent.IsRegistrationOpen)
					{
						if (player == null)
						{
							goto IL_08c6;
						}
						massTournamentServerConnector = (MassTournamentServerConnector)player.<IsRegistered>k__BackingField;
						object obj = (player.<IsRegistered>k__BackingField ? 1 : 0) & 1;
						if (obj == null)
						{
							obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3040;
							obj3 = obj2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v44+E4]");
							if ((nint)0 == 0)
							{
								goto IL_091f;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v44+B8]");
							obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v53+10]");
							action = (Action<object>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v53+10]");
							if ((nint)0 != 0)
							{
								goto IL_04a2;
							}
							goto IL_0981;
						}
					}
					if ((object)connector != null)
					{
						MassEventStageViewModel activeStage = connector.GetActiveStage();
						if (player != null && activeStage != null)
						{
							if (player.<LastStageReached>k__BackingField <= activeStage.<Id>k__BackingField)
							{
								if (player.<TriesLeft>k__BackingField >= 1)
								{
									object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2096;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj6 = (nint)0 + (nint)3544;
									Action<object> action2 = default(Action<object>);
									action2..ctor((object)connector, (IntPtr)obj6);
									ShowMassParticipationPopup(player, action2, confirmButton: true);
								}
								else
								{
									ShowFullList();
								}
								return;
							}
							object obj7 = typeof(MemberAchievementClanFeedData) + 2976;
							object obj8 = obj7;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X0_v15+E4]");
							bool flag = (nint)0 == 0;
							object obj9 = !flag;
							if (obj9 == null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							}
							massTournamentServerConnector = (MassTournamentServerConnector)((nint)0 + (nint)920);
							num = (nint)massTournamentServerConnector;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9DE4");
							GameObject gameObject = default(GameObject);
							if ((object)gameObject != null)
							{
								gameObject.SetActive(value: true);
								massTournamentServerConnector = (MassTournamentServerConnector)((nint)0 + (nint)1568);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E331E4");
								TournamentEligibilityIndicator tournamentEligibilityIndicator = default(TournamentEligibilityIndicator);
								if ((object)tournamentEligibilityIndicator != null)
								{
									tournamentEligibilityIndicator.Initialize(player);
									massTournamentServerConnector = (MassTournamentServerConnector)(object)("Network Authentication Required" + 3128);
									IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreateInfo(null, (string)(object)massTournamentServerConnector);
									if (popupWindowBuilderNeedsTitle != null)
									{
										object obj10 = typeof(System.IOAsyncCallback) + 392;
										object obj11 = "Complete" + 352;
										nint num2 = (nint)popupWindowBuilderNeedsTitle;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v28 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
										object obj12 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v28 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
										if ((nint)0 == 0)
										{
											goto IL_0353;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v28 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
										obj13 = (nint)0 + (nint)8;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X10_v11-8]");
											if (0 == (nint)obj10)
											{
												break;
											}
											obj14 = obj13 + 16;
											obj12--;
											bool flag2 = (nint)obj12 != 1;
											obj13 = obj14;
											if (flag2)
											{
												continue;
											}
											goto IL_0353;
										}
										object obj15 = num2 + obj13;
										massTournamentServerConnector = (MassTournamentServerConnector)(obj15 + 312);
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v211 @ X8_v8 (MassTournamentServerConnector)] (should have been resolved before IL gen)");
										bool flag3 = obj16 == null;
										obj14 = obj13;
										if (!flag3)
										{
											goto IL_0560;
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_08c6;
		IL_04a2:
		object obj17 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v42+E4]");
		bool flag4 = (nint)0 == 0;
		IntPtr intPtr = default(IntPtr);
		nint num3 = intPtr;
		Action<object> action3 = null;
		Action<object> action4 = action;
		if (!flag4)
		{
			goto IL_04f8;
		}
		goto IL_0a41;
		IL_04f8:
		object obj19 = (nint)0 + (nint)2136;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_061f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v607 @ X0_v32 (MassTournamentServerConnector)] (should have been resolved before IL gen)");
		object obj20 = default(object);
		bool flag5 = obj20 == null;
		object obj21 = !flag5;
		if (obj21 != null)
		{
			goto IL_06ba;
		}
		obj14 = obj13;
		MassTournamentServerConnector massTournamentServerConnector2 = default(MassTournamentServerConnector);
		massTournamentServerConnector = massTournamentServerConnector2;
		goto IL_08c6;
		IL_086b:
		object obj22 = obj14 + 1;
		object obj24;
		object obj23 = obj24 + obj22;
		massTournamentServerConnector = (MassTournamentServerConnector)(obj23 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v211 @ X8_v8 (MassTournamentServerConnector)] (should have been resolved before IL gen)");
		NullReferenceException ex = default(NullReferenceException);
		bool flag6 = ex == null;
		object obj25 = !flag6;
		if (obj25 != null)
		{
			goto IL_07ab;
		}
		goto IL_08c6;
		IL_083f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj27 = default(object);
		object obj26 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X0_v26+8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v308 @ X2_v14 (should have been resolved before IL gen)");
		goto IL_086b;
		IL_0a41:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action = action4;
		goto IL_04f8;
		IL_076a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v662 @ X0_v28 (MassTournamentServerConnector)] (should have been resolved before IL gen)");
		bool flag7 = ex == null;
		obj14 = obj13;
		MassTournamentServerConnector massTournamentServerConnector3 = default(MassTournamentServerConnector);
		massTournamentServerConnector = massTournamentServerConnector3;
		if (!flag7)
		{
			goto IL_07ab;
		}
		goto IL_08c6;
		IL_06ba:
		object obj29 = typeof(System.IOAsyncCallback) + 368;
		obj24 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v36+12E]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v36+12E]");
		if ((nint)0 == 0)
		{
			goto IL_076a;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X8_v36+B0]");
		obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X10_v21-8]");
			if (0 == (nint)obj29)
			{
				break;
			}
			obj13 = obj14 + 16;
			obj30--;
			bool flag8 = (nint)obj30 != 1;
			obj14 = obj13;
			if (flag8)
			{
				continue;
			}
			goto IL_076a;
		}
		goto IL_086b;
		IL_0981:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v44+E4]");
		bool flag9 = (nint)0 == 0;
		object obj31 = !flag9;
		if (obj31 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj32 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v490 @ X8_v62+B8]");
			obj4 = 0;
		}
		object obj33 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj34 = (nint)0 + (nint)856;
		num3 = (nint)obj34;
		Action<object> action5 = default(Action<object>);
		action5..ctor(obj4, (IntPtr)obj34);
		object obj35 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v58+B8]");
		object obj36 = (nint)0 + (nint)16;
		obj36 = action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj37 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		obj18 = obj37;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v42+E4]");
		bool flag10 = (nint)0 == 0;
		object obj38 = !flag10;
		action = action5;
		num = unchecked((nint)null);
		action3 = action5;
		action4 = action5;
		if (obj38 != null)
		{
			goto IL_04f8;
		}
		goto IL_0a41;
		IL_0353:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v550 @ X0_v36 (MassTournamentServerConnector)] (should have been resolved before IL gen)");
		bool flag11 = obj16 == null;
		object obj39 = !flag11;
		obj13 = obj14;
		if (obj39 != null)
		{
			goto IL_0560;
		}
		MassTournamentServerConnector massTournamentServerConnector4 = default(MassTournamentServerConnector);
		massTournamentServerConnector = massTournamentServerConnector4;
		goto IL_08c6;
		IL_0560:
		object obj40 = typeof(System.IOAsyncCallback) + 384;
		object obj41 = "m_StencilDeferredPS" + 584;
		object obj42 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v34+12E]");
		object obj43 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v34+12E]");
		if ((nint)0 == 0)
		{
			goto IL_061f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X8_v34+B0]");
		obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X10_v21-8]");
			if (0 == (nint)obj40)
			{
				break;
			}
			obj13 = obj14 + 16;
			obj43--;
			bool flag12 = (nint)obj43 != 1;
			obj14 = obj13;
			if (flag12)
			{
				continue;
			}
			goto IL_061f;
		}
		object obj44 = obj42 + obj14;
		massTournamentServerConnector = (MassTournamentServerConnector)(obj44 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v211 @ X8_v8 (MassTournamentServerConnector)] (should have been resolved before IL gen)");
		bool flag13 = obj20 == null;
		obj13 = obj14;
		if (!flag13)
		{
			goto IL_06ba;
		}
		goto IL_08c6;
		IL_08c6:
		ex = new NullReferenceException();
		goto IL_08d4;
		IL_091f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X0_v44+B8]");
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v53+10]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v53+10]");
		bool flag14 = (nint)0 == 0;
		object obj45 = !flag14;
		if (obj45 != null)
		{
			goto IL_04a2;
		}
		goto IL_0981;
		IL_08d4:
		object obj46 = obj14 + 9;
		object obj47 = (object)massTournamentServerConnector + obj46;
		object obj48 = obj47 + 312;
		object obj49 = obj48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X8_v6+8]");
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v279 @ X2_v2 (should have been resolved before IL gen)");
		goto IL_091f;
		IL_07ab:
		nint num4 = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v38 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj51 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v38 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_083f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v38 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj14 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X10_v21-8]");
			bool flag15 = 0 == (nint)obj29;
			massTournamentServerConnector = (MassTournamentServerConnector)num4;
			if (flag15)
			{
				break;
			}
			obj14 += 16;
			obj51--;
			if ((nint)obj51 != 1)
			{
				continue;
			}
			goto IL_083f;
		}
		goto IL_08d4;
	}

	private void <ShowFullList>b__38_0(MassActiveTournamentsPopup popup)
	{
		popup.Show(connector);
	}
}
