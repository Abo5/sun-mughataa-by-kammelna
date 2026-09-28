using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using Spine;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentButtons : MonoBehaviour
{
	private enum Mode
	{
		Hide,
		Disable
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Button, bool> <>9__29_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3448;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <Awake>b__29_0(Button button)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			return button != null;
		}
	}

	private Mode controlMode;

	private GameObject tournamentStatus;

	private TextMeshProUGUI tournamentStatusText;

	private Button overviewButton;

	private Button registerButton;

	private Button reserveButton;

	private Button forfeitButton;

	private Button ineligibleButton;

	private Button[] allButtons;

	private ITournamentRequests _manager;

	private TournamentData _tournament;

	private Room _tournamentRoom;

	private bool running
	{
		get
		{
			TournamentStatus status = SFSKammelnaRoomExtensions.GetTournamentStatus(_tournamentRoom);
			return TournamentStatusExtensions.IsRunning(status);
		}
	}

	private bool eligible
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ee: Expected O, but got I
			//IL_0122: Expected O, but got I4
			//IL_00c9: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01ce: Expected I4, but got O
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D49]");
			object obj3 = (nint)0 & (nint)1;
			TournamentData tournamentData;
			TournamentData tournament;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				tournamentData = _tournament;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				tournament = _tournament;
				if (!flag)
				{
					goto IL_00a5;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2200;
				tournamentData = _tournament;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v7+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				tournament = _tournament;
				if (obj7 != null)
				{
					goto IL_00a5;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			tournamentData = tournament;
			if (!flag3)
			{
				goto IL_0180;
			}
			goto IL_01c0;
			IL_01c0:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0180:
			User localUser = sessionModel.LocalUser;
			if (tournamentData != null)
			{
				return tournamentData.CanParticipate(localUser);
			}
			goto IL_01c0;
			IL_00a5:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag4 = (object)sessionModel == null;
			object obj8 = !flag4;
			if (obj8 != null)
			{
				goto IL_0180;
			}
			goto IL_01c0;
		}
	}

	private bool participant
	{
		get
		{
			//IL_0091: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			TournamentData tournament = _tournament;
			if (_tournament != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
				if ((nint)0 != 0)
				{
					return SfsTournamentConnector.IsParticipating(tournament.<RoomId>k__BackingField);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return SfsTournamentConnector.IsParticipating(tournament.<RoomId>k__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private bool seatsRemain
	{
		get
		{
			//IL_00e1: Expected I4, but got O
			//IL_004a: Expected O, but got I4
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected I4, but got Unknown
			//IL_00c1: Expected O, but got I4
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Expected I4, but got Unknown
			TournamentData tournament = _tournament;
			if (_tournament != null)
			{
				int tournamentParticipantsCount = SFSKammelnaRoomExtensions.GetTournamentParticipantsCount(_tournamentRoom);
				object obj = tournament.<MaxAllowedSize>k__BackingField - tournamentParticipantsCount;
				bool flag = (nint)obj < 0;
				bool flag2 = obj == null;
				int num = tournament.<MaxAllowedSize>k__BackingField ^ tournamentParticipantsCount;
				int num2 = tournament.<MaxAllowedSize>k__BackingField ^ obj;
				int num3 = num & num2;
				bool flag3 = num3 < 0;
				bool flag4 = flag == flag3;
				object obj2 = !flag2;
				return (byte)((flag4 & obj2) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private int round => SFSKammelnaRoomExtensions.GetTournamentCurrentRound(_tournamentRoom);

	private int totalRounds
	{
		get
		{
			//IL_004e: Expected I4, but got O
			TournamentData tournament = _tournament;
			if (_tournament != null)
			{
				return TournamentMath.GetNumberOfRounds(tournament.<Size>k__BackingField);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private int subTournamentsCount => SFSKammelnaRoomExtensions.GetActiveTournamentsCount(_tournamentRoom);

	private bool available
	{
		get
		{
			//IL_0097: Expected I4, but got O
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0043: Expected O, but got I4
			TournamentData tournament = _tournament;
			if (_tournament != null)
			{
				object obj = typeof(DataRelation) + 712;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime now = DateTime.Now;
				return tournament.<AvailabilityTime>k__BackingField <= now;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0d4f: Expected O, but got I4
		//IL_0033: Expected O, but got I4
		//IL_0049: Expected I, but got O
		//IL_0059: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0169: Expected O, but got I8
		//IL_0108: Expected I, but got O
		//IL_0118: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_024a: Expected O, but got I4
		//IL_0260: Expected O, but got I
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_01e1: Expected I, but got O
		//IL_01f1: Expected O, but got I
		//IL_021a: Expected O, but got I
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_034f: Expected O, but got I8
		//IL_02ee: Expected I, but got O
		//IL_02fe: Expected O, but got I
		//IL_0327: Expected O, but got I
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Expected O, but got Unknown
		//IL_0430: Expected O, but got I4
		//IL_0446: Expected O, but got I
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_03c7: Expected I, but got O
		//IL_03d7: Expected O, but got I
		//IL_0400: Expected O, but got I
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Expected O, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_04e1: Expected O, but got I4
		//IL_0d69: Expected O, but got I
		//IL_0d79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7e: Expected O, but got Unknown
		//IL_0d8a: Expected O, but got I
		//IL_0d9a: Expected O, but got I
		//IL_0daa: Expected O, but got I
		//IL_0dcc: Expected O, but got I4
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_0528: Expected O, but got I4
		//IL_05be: Expected I, but got O
		//IL_05cc: Expected I, but got O
		//IL_05d5: Expected O, but got I4
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_05ff: Expected O, but got I
		//IL_0de9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dee: Expected O, but got Unknown
		//IL_0e04: Expected O, but got I
		//IL_0e15: Expected I, but got O
		//IL_0e33: Expected O, but got I
		//IL_0e4e: Expected O, but got I4
		//IL_06bb: Expected O, but got I4
		//IL_0558: Expected O, but got I
		//IL_066e: Expected O, but got I4
		//IL_0724: Expected O, but got I4
		//IL_0752: Expected O, but got I4
		//IL_0797: Expected O, but got I
		//IL_07b3: Expected I, but got O
		//IL_07c1: Expected I, but got O
		//IL_07dc: Expected O, but got I
		//IL_0775: Expected O, but got I
		//IL_0898: Expected O, but got I4
		//IL_084b: Expected O, but got I4
		//IL_0901: Expected O, but got I4
		//IL_092f: Expected O, but got I4
		//IL_0984: Expected I, but got O
		//IL_0992: Expected I, but got O
		//IL_09ad: Expected O, but got I
		//IL_0952: Expected O, but got I
		//IL_0a69: Expected O, but got I4
		//IL_0a1c: Expected O, but got I4
		//IL_0ad2: Expected O, but got I4
		//IL_0b00: Expected O, but got I4
		//IL_0b45: Expected O, but got I
		//IL_0b61: Expected I, but got O
		//IL_0b6f: Expected I, but got O
		//IL_0b8a: Expected O, but got I
		//IL_0b23: Expected O, but got I
		//IL_0c9d: Expected O, but got I4
		//IL_0c1b: Expected O, but got I4
		//IL_0cdf: Expected O, but got I4
		//IL_0c49: Expected O, but got I4
		//IL_0c6c: Expected O, but got I
		object obj = typeof(TypeConverter<ushort, char>) + 1840;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		bool flag = enumerable == null;
		UnityAction unityAction = (UnityAction)5;
		UnityAction unityAction3 = default(UnityAction);
		object obj35;
		NullReferenceException ex = default(NullReferenceException);
		nint num6;
		object obj31;
		UnityAction unityAction4;
		if (!flag)
		{
			bool flag2 = (object)overviewButton == null;
			UnityAction unityAction2 = (UnityAction)5;
			if (!flag2)
			{
				nint num = (nint)enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v63 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				unityAction2 = (UnityAction)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag3 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X8_v63 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
				unityAction = (UnityAction)0;
				if (flag3)
				{
					goto IL_0d17;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
			if ((nint)0 != 0)
			{
				object obj2 = enumerable + 32;
				obj2 = overviewButton;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag4 = (object)registerButton == null;
				Button button = overviewButton;
				if (!flag4)
				{
					nint num2 = (nint)enumerable;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v62 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
					button = (Button)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag5 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v62 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
					unityAction = (UnityAction)0;
					if (flag5)
					{
						goto IL_0d17;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
				object obj3 = 0 & 0xFFFFFFFEL;
				bool flag6 = obj3 == null;
				unityAction2 = (UnityAction)(object)button;
				if (!flag6)
				{
					object obj4 = enumerable + 40;
					obj4 = registerButton;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag7 = (object)reserveButton == null;
					Button button2 = registerButton;
					if (!flag7)
					{
						nint num3 = (nint)enumerable;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v61 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
						button2 = (Button)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag8 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v61 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
						unityAction = (UnityAction)0;
						if (flag8)
						{
							goto IL_0d17;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
					bool flag9 = (nint)0 < (nint)2;
					object obj5 = !flag9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
					object obj6 = -2;
					bool flag10 = obj6 == null;
					object obj7 = ~obj5;
					object obj8 = obj7 | flag10;
					unityAction2 = (UnityAction)(object)button2;
					if (obj8 == null)
					{
						object obj9 = enumerable + 48;
						obj9 = reserveButton;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						bool flag11 = (object)forfeitButton == null;
						Button button3 = reserveButton;
						if (!flag11)
						{
							nint num4 = (nint)enumerable;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v60 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
							button3 = (Button)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag12 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X8_v60 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
							unityAction = (UnityAction)0;
							if (flag12)
							{
								goto IL_0d17;
							}
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
						object obj10 = 0 & 0xFFFFFFFCL;
						bool flag13 = obj10 == null;
						unityAction2 = (UnityAction)(object)button3;
						if (!flag13)
						{
							object obj11 = enumerable + 56;
							obj11 = forfeitButton;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							bool flag14 = (object)ineligibleButton == null;
							Button button4 = forfeitButton;
							if (!flag14)
							{
								nint num5 = (nint)enumerable;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v59 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
								button4 = (Button)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag15 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v59 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+40]");
								unityAction = (UnityAction)0;
								if (flag15)
								{
									goto IL_0d17;
								}
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
							bool flag16 = (nint)0 < (nint)4;
							object obj12 = !flag16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
							object obj13 = -4;
							bool flag17 = obj13 == null;
							object obj14 = ~obj12;
							object obj15 = obj14 | flag17;
							unityAction2 = (UnityAction)(object)button4;
							if (obj15 == null)
							{
								object obj16 = typeof(SkeletonBinary.SkeletonInput) + 3448;
								object obj17 = enumerable + 64;
								obj17 = ineligibleButton;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj18 = obj16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v32+E4]");
								bool flag18 = (nint)0 == 0;
								object obj19 = !flag18;
								if (obj19 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj18 = obj16;
								}
								object obj20 = (nint)0 + (nint)3272;
								object obj21 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
								object obj22 = (nint)0 + (nint)584;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v32+B8]");
								object obj23 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v51+8]");
								Func<object, bool> predicate = (Func<object, bool>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v51+8]");
								bool flag19 = (nint)0 == 0;
								object obj24 = !flag19;
								if (obj24 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v32+E4]");
									bool flag20 = (nint)0 == 0;
									object obj25 = !flag20;
									if (obj25 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
										object obj26 = obj16;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v57+B8]");
										obj23 = 0;
									}
									object obj27 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 344;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj28 = (nint)0 + (nint)3664;
									Func<object, bool> func = default(Func<object, bool>);
									func..ctor(obj23, (IntPtr)obj28);
									object obj29 = obj16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v56+B8]");
									object obj30 = (nint)0 + (nint)8;
									obj30 = func;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									obj31 = 0;
									predicate = func;
								}
								IEnumerable<object> source = Enumerable.Where(enumerable, predicate);
								object[] array = Enumerable.ToArray(source);
								object obj32 = this + 96;
								obj32 = array;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								UnityEngine.Object obj33 = overviewButton;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								num6 = (nint)obj22;
								unityAction3..ctor(this, (IntPtr)obj22);
								object obj34 = 152985600;
								obj35 = typeof(MemberAchievementClanFeedData) + 2976;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DE4]");
								object obj36 = (nint)0 & (nint)1;
								if (obj36 != null)
								{
									object obj37 = obj35;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v96+E4]");
									if ((nint)0 != 0)
									{
										goto IL_0649;
									}
								}
								else
								{
									_ = 1;
									object obj37 = obj35;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X0_v96+E4]");
									bool flag21 = (nint)0 == 0;
									object obj38 = !flag21;
									if (obj38 != null)
									{
										goto IL_0649;
									}
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
								bool flag22 = overviewButton;
								bool flag23 = !flag22;
								unityAction = null;
								unityAction4 = null;
								if (!flag23)
								{
									goto IL_070a;
								}
								goto IL_078b;
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
			unityAction = unityAction2;
		}
		goto IL_0d09;
		IL_0968:
		UnityEngine.Object obj39 = reserveButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj40;
		num6 = (nint)obj40;
		UnityAction unityAction5 = default(UnityAction);
		unityAction5..ctor(this, (IntPtr)obj40);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DE4]");
		object obj41 = (nint)0 & (nint)1;
		if (obj41 != null)
		{
			object obj42 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v68+E4]");
			if ((nint)0 != 0)
			{
				goto IL_09f7;
			}
		}
		else
		{
			_ = 1;
			object obj42 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v549 @ X0_v68+E4]");
			bool flag24 = (nint)0 == 0;
			object obj43 = !flag24;
			if (obj43 != null)
			{
				goto IL_09f7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag25 = reserveButton;
		bool flag26 = !flag25;
		unityAction = null;
		UnityAction unityAction6 = null;
		if (!flag26)
		{
			goto IL_0ab8;
		}
		goto IL_0b39;
		IL_0d09:
		ex = new NullReferenceException();
		goto IL_0d17;
		IL_070a:
		bool flag27 = (object)overviewButton == null;
		obj31 = 0;
		if (!flag27)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X21_v13 (UnityEngine.Object)+100]");
			bool flag28 = (nint)0 == 0;
			obj31 = 0;
			if (!flag28)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X21_v13 (UnityEngine.Object)+100]");
				((UnityEvent)0).AddListener(unityAction3);
				num6 = 0;
				unityAction4 = unityAction3;
				goto IL_078b;
			}
		}
		goto IL_0d09;
		IL_078b:
		obj40 = (nint)0 + (nint)592;
		UnityEngine.Object obj44 = registerButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		num6 = (nint)obj40;
		UnityAction unityAction7 = default(UnityAction);
		unityAction7..ctor(this, (IntPtr)obj40);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DE4]");
		object obj45 = (nint)0 & (nint)1;
		if (obj45 != null)
		{
			object obj46 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v82+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0826;
			}
		}
		else
		{
			_ = 1;
			object obj46 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X0_v82+E4]");
			bool flag29 = (nint)0 == 0;
			object obj47 = !flag29;
			if (obj47 != null)
			{
				goto IL_0826;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag30 = registerButton;
		bool flag31 = !flag30;
		unityAction = null;
		UnityAction unityAction8 = null;
		if (!flag31)
		{
			goto IL_08e7;
		}
		goto IL_0968;
		IL_0d17:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0ab8:
		bool flag32 = (object)reserveButton == null;
		obj31 = 0;
		if (!flag32)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X21_v15 (UnityEngine.Object)+100]");
			bool flag33 = (nint)0 == 0;
			obj31 = 0;
			if (!flag33)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X21_v15 (UnityEngine.Object)+100]");
				((UnityEvent)0).AddListener(unityAction5);
				num6 = 0;
				unityAction6 = unityAction5;
				goto IL_0b39;
			}
		}
		goto IL_0d09;
		IL_0826:
		bool flag34 = registerButton;
		bool flag35 = !flag34;
		object obj48 = !flag35;
		unityAction = null;
		if (obj48 != null)
		{
			goto IL_08e7;
		}
		unityAction8 = null;
		goto IL_0968;
		IL_09f7:
		bool flag36 = reserveButton;
		bool flag37 = !flag36;
		object obj49 = !flag37;
		unityAction = null;
		if (obj49 != null)
		{
			goto IL_0ab8;
		}
		unityAction6 = null;
		goto IL_0b39;
		IL_0b39:
		object obj50 = (nint)0 + (nint)576;
		UnityEngine.Object obj51 = forfeitButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		num6 = (nint)obj50;
		UnityAction unityAction9 = default(UnityAction);
		unityAction9..ctor(this, (IntPtr)obj50);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DE4]");
		object obj52 = (nint)0 & (nint)1;
		if (obj52 != null)
		{
			object obj53 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v52+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0bd4;
			}
		}
		else
		{
			_ = 1;
			object obj53 = obj35;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X0_v52+E4]");
			bool flag38 = (nint)0 == 0;
			object obj54 = !flag38;
			if (obj54 != null)
			{
				goto IL_0bd4;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag39 = forfeitButton;
		bool flag40 = !flag39;
		object obj55 = !flag40;
		unityAction = null;
		if (obj55 == null)
		{
			return;
		}
		goto IL_0c01;
		IL_0bd4:
		bool flag41 = forfeitButton;
		bool flag42 = !flag41;
		unityAction = null;
		if (!flag42)
		{
			goto IL_0c01;
		}
		return;
		IL_08e7:
		bool flag43 = (object)registerButton == null;
		obj31 = 0;
		if (!flag43)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X21_v14 (UnityEngine.Object)+100]");
			bool flag44 = (nint)0 == 0;
			obj31 = 0;
			if (!flag44)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X21_v14 (UnityEngine.Object)+100]");
				((UnityEvent)0).AddListener(unityAction7);
				num6 = 0;
				unityAction8 = unityAction7;
				goto IL_0968;
			}
		}
		goto IL_0d09;
		IL_0c01:
		bool flag45 = (object)forfeitButton == null;
		obj31 = 0;
		if (!flag45)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X21_v16 (UnityEngine.Object)+100]");
			bool flag46 = (nint)0 == 0;
			obj31 = 0;
			if (!flag46)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X21_v16 (UnityEngine.Object)+100]");
				((UnityEvent)0).AddListener(unityAction9);
				return;
			}
		}
		goto IL_0d09;
		IL_0649:
		bool flag47 = overviewButton;
		bool flag48 = !flag47;
		object obj56 = !flag48;
		unityAction = null;
		if (obj56 != null)
		{
			goto IL_070a;
		}
		unityAction4 = null;
		goto IL_078b;
	}

	private static void AddClickListener(Button button, UnityAction callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00dd: Expected O, but got I4
		//IL_011d: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DE4]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = button;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			return;
		}
		goto IL_009a;
		IL_009a:
		button.m_OnClick.AddListener(callback);
		return;
		IL_0074:
		if ((bool)button)
		{
			goto IL_009a;
		}
	}

	public void SetManager(ITournamentRequests manager)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 104;
		obj = manager;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Initialize(TournamentData tournament, Room tournamentRoom)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0086: Expected O, but got I4
		object obj = this + 112;
		obj = tournament;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = this + 120;
		obj2 = tournamentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X21_v2-58]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v35 @ X21_v2-58]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				UpdateVisibility();
			}
		}
		else
		{
			UpdateInteractivity();
		}
	}

	private void UpdateVisibility()
	{
		//IL_0016: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00e1: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_004f: Expected O, but got I
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0142: Expected O, but got I4
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_024c: Expected O, but got I4
		//IL_0296: Expected O, but got I4
		//IL_043c: Expected O, but got I
		//IL_045e: Expected O, but got I4
		//IL_0468: Expected O, but got I4
		//IL_04bb: Expected O, but got I4
		//IL_0311: Expected O, but got I4
		//IL_0327: Expected O, but got I
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_02de: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_050a: Expected O, but got I4
		//IL_03bb: Expected O, but got I4
		//IL_03d1: Expected O, but got I
		//IL_062b: Expected O, but got I4
		//IL_0641: Expected O, but got I
		//IL_056b: Expected O, but got I4
		//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ad: Expected I4, but got Unknown
		//IL_05e2: Expected O, but got I4
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_061d: Expected O, but got I4
		//IL_066e: Expected O, but got I
		//IL_060f: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DE5]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			Clear();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DE2]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				goto IL_006c;
			}
		}
		else
		{
			_ = 1;
			Clear();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DE2]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_006c;
			}
		}
		_ = 1;
		TournamentData tournament = _tournament;
		goto IL_0104;
		IL_03b2:
		object obj5 = 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentButtons)+v184 @ X8_v24]");
		SetActive((Button)0, active: true);
		return;
		IL_02f8:
		SetActive(overviewButton, active: true);
		object obj6 = 64;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentButtons)+v183 @ X8_v6]");
		SetActive((Button)0, active: false);
		return;
		IL_0263:
		object obj8;
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v14+E4]");
		bool flag2 = (nint)0 == 0;
		UnityEngine.Object obj9 = tournamentStatusText;
		object obj10 = 0;
		UnityEngine.Object obj11 = tournamentStatusText;
		if (!flag2)
		{
			goto IL_02ae;
		}
		goto IL_0489;
		IL_006c:
		tournament = _tournament;
		bool flag3 = _tournament == null;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0104;
		IL_0104:
		object obj13 = typeof(DataRelation) + 712;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v4+E4]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		if (tournament.<AvailabilityTime>k__BackingField <= now)
		{
			TournamentStatus status = SFSKammelnaRoomExtensions.GetTournamentStatus(_tournamentRoom);
			if (TournamentStatusExtensions.IsRunning(status))
			{
				PopulateTournamentStatus();
				goto IL_02f8;
			}
			SetActive(overviewButton, active: true);
			TournamentData tournament2 = _tournament;
			object obj16 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v38+E4]");
			if ((nint)0 != 0)
			{
				if (SfsTournamentConnector.IsParticipating(tournament2.<RoomId>k__BackingField))
				{
					goto IL_03b2;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag5 = SfsTournamentConnector.IsParticipating(tournament2.<RoomId>k__BackingField);
				bool flag6 = !flag5;
				object obj18 = !flag6;
				if (obj18 != null)
				{
					goto IL_03b2;
				}
			}
			if (eligible)
			{
				TournamentData tournament3 = _tournament;
				int tournamentParticipantsCount = SFSKammelnaRoomExtensions.GetTournamentParticipantsCount(_tournamentRoom);
				object obj19 = tournament3.<MaxAllowedSize>k__BackingField - tournamentParticipantsCount;
				bool flag7 = (nint)obj19 < 0;
				bool flag8 = obj19 == null;
				int num = tournament3.<MaxAllowedSize>k__BackingField ^ tournamentParticipantsCount;
				int num2 = tournament3.<MaxAllowedSize>k__BackingField ^ obj19;
				int num3 = num & num2;
				bool flag9 = num3 < 0;
				bool flag10 = flag7 == flag9;
				object obj20 = !flag8;
				object obj21 = flag10 & obj20;
				object obj22 = ~obj21;
				if (obj22 == null)
				{
					object obj23 = 64;
				}
				else
				{
					object obj23 = 72;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentButtons)+v185 @ X8_v21]");
				SetActive((Button)0, active: true);
			}
			else
			{
				object obj24 = 88;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentButtons)+v186 @ X8_v18]");
				SetActive((Button)0, active: true);
			}
			return;
		}
		obj8 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj25 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v13+E4]");
		bool flag13;
		if ((nint)0 != 0)
		{
			bool flag11 = tournamentStatus;
			bool flag12 = !flag11;
			object obj26 = !flag12;
			flag13 = false;
			if (obj26 == null)
			{
				goto IL_0263;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag14 = tournamentStatus;
			bool flag15 = !flag14;
			flag13 = false;
			if (flag15)
			{
				goto IL_0263;
			}
		}
		tournamentStatus.SetActive(value: true);
		obj9 = tournamentStatusText;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6000]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X0_v14+E4]");
		bool flag16 = (nint)0 == 0;
		object obj27 = !flag16;
		obj10 = 0;
		flag13 = true;
		obj11 = tournamentStatusText;
		if (obj27 != null)
		{
			goto IL_02ae;
		}
		goto IL_0489;
		IL_02ae:
		if ((bool)obj9)
		{
			goto IL_02d4;
		}
		goto IL_02f8;
		IL_0489:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag17 = obj11;
		bool flag18 = !flag17;
		object obj28 = !flag18;
		if (obj28 != null)
		{
			goto IL_02d4;
		}
		goto IL_02f8;
		IL_02d4:
		object text = "SetRoomVariables request error" + 1576;
		TextMeshProExtensions.Localize(tournamentStatusText, (string)text);
		goto IL_02f8;
	}

	private void UpdateInteractivity()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_016a: Expected O, but got I4
		//IL_00b2: Expected O, but got I4
		//IL_01be: Expected O, but got I4
		//IL_01c7: Expected O, but got I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_0211: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6DE6]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			obj5 = registerButton;
			obj6 = registerButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = registerButton;
			obj6 = registerButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		if (obj8 != null)
		{
			goto IL_0294;
		}
		return;
		IL_021f:
		if (!eligible)
		{
			goto IL_0276;
		}
		TournamentStatus status = SFSKammelnaRoomExtensions.GetTournamentStatus(_tournamentRoom);
		bool flag5 = TournamentStatusExtensions.IsRunning(status);
		bool interactable = (byte)((flag5 ? 1u : 0u) ^ 1u) != 0;
		goto IL_0284;
		IL_0284:
		registerButton.interactable = interactable;
		return;
		IL_0276:
		interactable = false;
		goto IL_0284;
		IL_0091:
		bool flag6 = obj5;
		bool flag7 = !flag6;
		obj9 = 0;
		if (!flag7)
		{
			goto IL_0294;
		}
		return;
		IL_0294:
		TournamentData tournament = _tournament;
		object obj10 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			if (!SfsTournamentConnector.IsParticipating(tournament.<RoomId>k__BackingField))
			{
				goto IL_021f;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag8 = SfsTournamentConnector.IsParticipating(tournament.<RoomId>k__BackingField);
			bool flag9 = !flag8;
			object obj12 = !flag9;
			if (obj12 == null)
			{
				goto IL_021f;
			}
		}
		goto IL_0276;
	}

	private static void SetActive(Button button, bool active)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ea: Expected O, but got I4
		//IL_012a: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D4A]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = button;
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 == null)
		{
			return;
		}
		goto IL_009a;
		IL_009a:
		GameObject gameObject = button.gameObject;
		gameObject.SetActive(active);
		return;
		IL_0074:
		if ((bool)button)
		{
			goto IL_009a;
		}
	}

	private void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0106: Expected I, but got O
		//IL_00df: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
		object obj2 = (nint)0 + (nint)1952;
		object obj3 = (nint)0 + (nint)2072;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)null, (IntPtr)obj2);
		ArraysExtensions.ForEach(allButtons, action);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (!tournamentStatus)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = tournamentStatus;
			bool flag2 = !flag;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				return;
			}
		}
		tournamentStatus.SetActive(value: false);
	}

	private void PopulateTournamentStatus()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01b9: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_025d: Expected O, but got I4
		//IL_02b0: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D4C]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = tournamentStatus;
			obj6 = tournamentStatus;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = tournamentStatus;
			obj6 = tournamentStatus;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		bool flag5 = false;
		if (flag4)
		{
			goto IL_00cb;
		}
		goto IL_0219;
		IL_0132:
		TournamentData tournament = _tournament;
		LocalizableText text;
		if (tournament.<IsCluster>k__BackingField)
		{
			int activeTournamentsCount = SFSKammelnaRoomExtensions.GetActiveTournamentsCount(_tournamentRoom);
			text = TournamentUtil.GetActiveClusterName(activeTournamentsCount);
		}
		else
		{
			int tournamentCurrentRound = SFSKammelnaRoomExtensions.GetTournamentCurrentRound(_tournamentRoom);
			TournamentData tournament2 = _tournament;
			int numberOfRounds = TournamentMath.GetNumberOfRounds(tournament2.<Size>k__BackingField);
			text = TournamentUtil.GetTournamentRoundName(tournamentCurrentRound, numberOfRounds);
		}
		TextMeshProExtensions.Localize(tournamentStatusText, text);
		return;
		IL_010c:
		UnityEngine.Object obj8;
		if ((bool)obj8)
		{
			goto IL_0132;
		}
		return;
		IL_027e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj9;
		bool flag6 = obj9;
		bool flag7 = !flag6;
		object obj10 = !flag7;
		if (obj10 == null)
		{
			return;
		}
		goto IL_0132;
		IL_0091:
		bool flag8 = obj5;
		bool flag9 = !flag8;
		object obj11 = !flag9;
		flag5 = false;
		if (obj11 == null)
		{
			goto IL_00cb;
		}
		goto IL_0219;
		IL_0219:
		tournamentStatus.SetActive(value: true);
		obj8 = tournamentStatusText;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v4+E4]");
		bool flag10 = (nint)0 == 0;
		object obj13 = !flag10;
		flag5 = true;
		obj9 = tournamentStatusText;
		if (obj13 != null)
		{
			goto IL_010c;
		}
		goto IL_027e;
		IL_00cb:
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v4+E4]");
		bool flag11 = (nint)0 == 0;
		obj8 = tournamentStatusText;
		obj9 = tournamentStatusText;
		if (!flag11)
		{
			goto IL_010c;
		}
		goto IL_027e;
	}

	private void JoinRoom()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00cf: Expected O, but got I
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_010c: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj3 = default(object);
		object obj5 = default(object);
		while (true)
		{
			ITournamentRequests manager = _manager;
			object obj = typeof(System.IOAsyncCallback) + 1792;
			nint num = (nint)manager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<ITournamentRequests>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<ITournamentRequests>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<ITournamentRequests>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v4-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj3 += 16;
					obj2--;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00ad;
				}
				goto IL_00d9;
			}
			goto IL_00ad;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v108 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_00d9:
			object obj7 = num + obj3;
			object obj8 = obj7 + 312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v6+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v119 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	private void Participate()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00cf: Expected O, but got I
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_011a: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj3 = default(object);
		object obj5 = default(object);
		while (true)
		{
			ITournamentRequests manager = _manager;
			object obj = typeof(System.IOAsyncCallback) + 1792;
			nint num = (nint)manager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<ITournamentRequests>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<ITournamentRequests>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<ITournamentRequests>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v4-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj3 += 16;
					obj2--;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00ad;
				}
				goto IL_00d9;
			}
			goto IL_00ad;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v108 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_00d9:
			object obj7 = obj3 + 1;
			object obj8 = num + obj7;
			object obj9 = obj8 + 312;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v6+8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v119 @ X2_v3 (should have been resolved before IL gen)");
		}
	}

	private void ForfeitTournament()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_00cf: Expected O, but got I
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_011a: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		object obj3 = default(object);
		object obj5 = default(object);
		while (true)
		{
			ITournamentRequests manager = _manager;
			object obj = typeof(System.IOAsyncCallback) + 1792;
			nint num = (nint)manager;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<ITournamentRequests>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<ITournamentRequests>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<ITournamentRequests>)+B0]");
				obj3 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X10_v4-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj3 += 16;
					obj2--;
					if ((nint)obj2 != 1)
					{
						continue;
					}
					goto IL_00ad;
				}
				goto IL_00d9;
			}
			goto IL_00ad;
			IL_00ad:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj4 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v4+8]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v108 @ X2_v2 (should have been resolved before IL gen)");
			goto IL_00d9;
			IL_00d9:
			object obj7 = obj3 + 2;
			object obj8 = num + obj7;
			object obj9 = obj8 + 312;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v6+8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v119 @ X2_v3 (should have been resolved before IL gen)");
		}
	}
}
