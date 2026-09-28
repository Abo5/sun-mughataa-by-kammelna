using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Sfs2X.Entities;
using Spine;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentLists : MonoBehaviour
{
	public record OfficialTournamentSubWallData(DateTime DateTime, int NonSubBuys, int ShownCount)
	{
		protected virtual Type EqualityContract
		{
			get
			{
				//IL_0009: Expected O, but got I4
				//IL_0018: Unknown result type (might be due to invalid IL or missing references)
				//IL_001d: Expected O, but got Unknown
				//IL_0033: Expected O, but got I
				//IL_00d3: Expected O, but got I4
				//IL_00e3: Expected O, but got I
				//IL_0105: Expected O, but got I4
				//IL_0067: Expected O, but got I4
				//IL_0077: Expected O, but got I
				object obj = 152985600;
				object obj2 = typeof(SqlDouble) + 3760;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E42]");
				object obj3 = (nint)0 & (nint)1;
				RuntimeTypeHandle handle;
				RuntimeTypeHandle handle2;
				if (obj3 != null)
				{
					handle = (RuntimeTypeHandle)obj2;
					object obj4 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X8_v9+E0]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v1+E4]");
					bool flag = (nint)0 == 0;
					handle2 = (RuntimeTypeHandle)obj2;
					if (!flag)
					{
						goto IL_00a4;
					}
				}
				else
				{
					_ = 1;
					handle = (RuntimeTypeHandle)obj2;
					object obj6 = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v5+E0]");
					object obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v1+E4]");
					bool flag2 = (nint)0 == 0;
					object obj7 = !flag2;
					handle2 = (RuntimeTypeHandle)obj2;
					if (obj7 != null)
					{
						goto IL_00a4;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return Type.GetTypeFromHandle(handle2);
				IL_00a4:
				return Type.GetTypeFromHandle(handle);
			}
		}

		public override string ToString()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_00b6: Expected I, but got O
			//IL_00c6: Expected O, but got I
			//IL_00d6: Expected O, but got I
			object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			StringBuilder stringBuilder = default(StringBuilder);
			stringBuilder..ctor();
			if (stringBuilder != null)
			{
				object value = "October" + 56;
				object value2 = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 2336;
				StringBuilder stringBuilder2 = stringBuilder.Append((string)value);
				StringBuilder stringBuilder3 = stringBuilder.Append((string)value2);
				if (PrintMembers(stringBuilder))
				{
					StringBuilder stringBuilder4 = stringBuilder.Append(' ');
				}
				StringBuilder stringBuilder5 = stringBuilder.Append('}');
				nint num = (nint)stringBuilder;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6 (Il2CppClass<System.Text.StringBuilder>)+168]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v6 (Il2CppClass<System.Text.StringBuilder>)+170]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v82 @ X2_v6 (should have been resolved before IL gen)");
			}
			return (string)(object)new NullReferenceException();
		}

		protected virtual bool PrintMembers(StringBuilder builder)
		{
			//IL_0145: Expected I4, but got O
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_0082: Expected O, but got I4
			RuntimeHelpers.EnsureSufficientExecutionStack();
			if (builder != null)
			{
				object value = "DNQUALIFIER" + 1352;
				object obj = typeof(DataRelation) + 712;
				object value2 = "&action=sign-up" + 3576;
				object value3 = "&action=sign-up" + 3736;
				StringBuilder stringBuilder = builder.Append((string)value);
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
				bool flag = (nint)0 == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				DateTime dateTime = default(DateTime);
				string value4 = dateTime.ToString();
				StringBuilder stringBuilder2 = builder.Append(value4);
				StringBuilder stringBuilder3 = builder.Append((string)value2);
				int num = default(int);
				string value5 = num.ToString();
				StringBuilder stringBuilder4 = builder.Append(value5);
				StringBuilder stringBuilder5 = builder.Append((string)value3);
				string value6 = num.ToString();
				StringBuilder stringBuilder6 = builder.Append(value6);
				return true;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		public override int GetHashCode()
		{
			//IL_000c: Expected O, but got I
			//IL_0156: Expected I4, but got O
			//IL_001d: Expected O, but got I
			//IL_0062: Expected O, but got I
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected O, but got Unknown
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected O, but got Unknown
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected O, but got Unknown
			//IL_0143: Expected I4, but got O
			object obj = (nint)0 + (nint)168;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C12B94");
			Type equalityContract = EqualityContract;
			object obj2 = default(object);
			if (obj2 != null)
			{
				object obj3 = (nint)0 + (nint)40;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v66 @ X8_v5+1C8] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C0E3DC");
				object obj5 = default(object);
				if (obj5 != null)
				{
					object obj6 = (nint)0 + (nint)96;
					object obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v97 @ X8_v6+1C8] (should have been resolved before IL gen)");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C102CC");
					object obj8 = default(object);
					if (obj8 != null)
					{
						object obj9 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v98 @ X8_v7+1C8] (should have been resolved before IL gen)");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C102CC");
						object obj10 = default(object);
						if (obj10 != null)
						{
							object obj11 = obj10;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v134 @ X8_v8+1C8] (should have been resolved before IL gen)");
							object obj13 = default(object);
							object obj12 = obj13 * 2773833001L;
							object obj15 = default(object);
							object obj14 = obj15 + obj12;
							object obj16 = obj14 * 2773833001L;
							object obj18 = default(object);
							object obj17 = obj18 + obj16;
							object obj19 = obj17 * 2773833001L;
							object obj20 = default(object);
							return (int)(obj20 + obj19);
						}
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		public virtual bool Equals(OfficialTournamentSubWallData other)
		{
			//IL_0034: Expected I, but got O
			//IL_0050: Expected O, but got I4
			//IL_0060: Expected O, but got I
			//IL_0110: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_0132: Expected O, but got I
			//IL_0260: Expected I4, but got O
			//IL_0190: Expected O, but got I
			//IL_0238: Expected O, but got I
			//IL_0248: Expected O, but got I
			bool flag;
			if ((object)this != other)
			{
				if ((object)other != null)
				{
					Type equalityContract = EqualityContract;
					nint num = (nint)other;
					Type equalityContract2 = other.EqualityContract;
					object obj = 153100288 + 1024;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v6+E0]");
					object obj2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v8+E4]");
					if ((nint)0 != 0)
					{
						flag = equalityContract == equalityContract2;
						bool flag2 = !flag;
						object obj3 = !flag2;
						object obj4 = 0;
						Type type = equalityContract2;
						if (obj3 == null)
						{
							goto IL_00cb;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						flag = equalityContract == equalityContract2;
						bool flag3 = !flag;
						object obj4 = 0;
						Type type = equalityContract2;
						if (flag3)
						{
							goto IL_00cb;
						}
					}
					object obj5 = (nint)0 + (nint)40;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C0E3DC");
					object obj6 = default(object);
					if (obj6 != null)
					{
						object obj7 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v160 @ X8_v11+1B8] (should have been resolved before IL gen)");
						if (!flag)
						{
							goto IL_00cb;
						}
						object obj8 = (nint)0 + (nint)96;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C102CC");
						object obj9 = default(object);
						if (obj9 != null)
						{
							object obj10 = obj9;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v161 @ X8_v12+1B8] (should have been resolved before IL gen)");
							if (!flag)
							{
								goto IL_00cb;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C102CC");
							object obj11 = default(object);
							if (obj11 != null)
							{
								int num2 = other.ShownCount;
								int num3 = ShownCount;
								object obj12 = obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v13+1B8]");
								object obj13 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v13+1C0]");
								object obj14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v88 @ X4_v1 (should have been resolved before IL gen)");
							}
						}
					}
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				return false;
			}
			return true;
			IL_00cb:
			return flag;
		}

		protected OfficialTournamentSubWallData(OfficialTournamentSubWallData original)
		{
			<DateTime>k__BackingField = original.<DateTime>k__BackingField;
			<NonSubBuys>k__BackingField = original.<NonSubBuys>k__BackingField;
		}

		public unsafe void Deconstruct(out DateTime DateTime, out int NonSubBuys, out int ShownCount)
		{
			ref DateTime reference = ref *(DateTime*)DateTime;
			ref int reference2 = ref *(int*)NonSubBuys;
			ref int reference3 = ref *(int*)ShownCount;
		}
	}

	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Room, TournamentData> <>9__20_0;

		public static Func<TournamentData, bool> <>9__20_1;

		public static Action<TournamentCreationPopup> <>9__26_0;

		public static Action<TournamentCreationPopup> <>9__26_1;

		public static Action<TournamentCreationPopup> <>9__27_0;

		public static Action<TournamentCreationPopup> <>9__28_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3696;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal TournamentData <ShowOnlySubscribersPopupForDiscountOfficial>b__20_0(Room tour)
		{
			return SFSKammelnaRoomExtensions.GetTournamentInfo(tour);
		}

		internal bool <ShowOnlySubscribersPopupForDiscountOfficial>b__20_1(TournamentData t)
		{
			//IL_0030: Expected O, but got I4
			if (t != null)
			{
				object obj = t.<Type>k__BackingField - 3;
				return obj == null;
			}
			return false;
		}

		internal void <OnCreateTournamentClicked>b__26_0(TournamentCreationPopup popup)
		{
			popup.clanId = 0;
			popup.popup.SlideIn();
			TournamentsCreationPopupEventsChannel eventsChannel = popup.eventsChannel;
			eventsChannel.<TournamentType>k__BackingField = TournamentType.Public;
			popup.tournamentTypeInput.SetIsOnWithoutNotify(0);
			popup.ClearInput();
		}

		internal void <OnCreateTournamentClicked>b__26_1(TournamentCreationPopup popup)
		{
			popup.clanId = 0;
			popup.popup.SlideIn();
			TournamentsCreationPopupEventsChannel eventsChannel = popup.eventsChannel;
			eventsChannel.<TournamentType>k__BackingField = TournamentType.Private;
			popup.tournamentTypeInput.SetIsOnWithoutNotify(1);
			popup.ClearInput();
		}

		internal void <OnCreatePublicTournamentClicked>b__27_0(TournamentCreationPopup popup)
		{
			popup.clanId = 0;
			popup.popup.SlideIn();
			TournamentsCreationPopupEventsChannel eventsChannel = popup.eventsChannel;
			eventsChannel.<TournamentType>k__BackingField = TournamentType.Public;
			popup.tournamentTypeInput.SetIsOnWithoutNotify(0);
			popup.ClearInput();
		}

		internal void <OnCreatePrivateTournamentClicked>b__28_0(TournamentCreationPopup popup)
		{
			popup.clanId = 0;
			popup.popup.SlideIn();
			TournamentsCreationPopupEventsChannel eventsChannel = popup.eventsChannel;
			eventsChannel.<TournamentType>k__BackingField = TournamentType.Private;
			popup.tournamentTypeInput.SetIsOnWithoutNotify(1);
			popup.ClearInput();
		}
	}

	private sealed class <>c__DisplayClass29_0
	{
		public TournamentType tournamentType;

		internal void <OnHelpButtonClicked>b__0(TournamentHelpPopup popup)
		{
			popup.Show(tournamentType);
		}
	}

	private TournamentsEventsChannel eventsChannel;

	private CustomButton creationButton;

	private Button helpButton;

	private ComponentReference<TournamentCreationPopup> tournamentCreationPopup;

	private ComponentReference<TournamentHelpPopup> tournamentHelpPopup;

	private Button createPublicTournamentButton;

	private Button createPrivateTournamentButton;

	private GameObject createPublicTournamentUnavailable;

	private GameObject createPrivateTournamentUnavailable;

	private CanvasGroup tournamentTypesButtons;

	private TabsUI tournamentTabsUI;

	private Sprite officialTournamentIcon;

	private GameObject officialTournamentPrices;

	public static OfficialTournamentSubWallData OffiTourSubWallData
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0064: Expected O, but got I
			//IL_008e: Expected O, but got I4
			//IL_00ac: Expected O, but got I
			object obj = typeof(DataRelation) + 712;
			object obj2 = typeof(SkeletonBinary.SkeletonInput) + 3712;
			object obj3 = "October" + 56;
			object obj4 = (nint)0 + (nint)2472;
			object obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+B8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+10]");
			_ = 0;
			_ = 0;
			object obj8 = default(object);
			obj8..ctor();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81144");
			OfficialTournamentSubWallData result = default(OfficialTournamentSubWallData);
			return result;
		}
		set
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_001b: Expected O, but got I
			object obj = "October" + 56;
			object obj2 = (nint)0 + (nint)2520;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81418");
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_045c: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0060: Expected O, but got I4
		//IL_0191: Expected O, but got I4
		//IL_019f: Expected O, but got I4
		//IL_012f: Expected O, but got I4
		//IL_0138: Expected O, but got I4
		//IL_0098: Expected O, but got I
		//IL_00a6: Expected I, but got O
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_023b: Expected O, but got I
		//IL_0253: Expected I, but got O
		//IL_00c6: Expected O, but got I4
		//IL_00cf: Expected O, but got I4
		//IL_01d7: Expected O, but got I
		//IL_01e5: Expected I, but got O
		//IL_0154: Expected O, but got I4
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_0296: Expected O, but got I
		//IL_02ae: Expected I, but got O
		//IL_0205: Expected O, but got I4
		//IL_020e: Expected O, but got I4
		//IL_02bf: Expected O, but got I
		//IL_02cb: Expected O, but got I
		//IL_02fa: Expected I, but got O
		//IL_030b: Expected O, but got I
		//IL_031a: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_035f: Expected I, but got O
		//IL_0389: Expected O, but got I4
		//IL_03d9: Expected O, but got I4
		//IL_0402: Expected O, but got I
		//IL_041a: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		bool flag2 = createPublicTournamentButton != null;
		bool flag3 = !flag2;
		object obj5 = 0;
		UnityAction unityAction = null;
		object obj7;
		if (!flag3)
		{
			Button button = createPublicTournamentButton;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)936;
			UnityAction unityAction2 = default(UnityAction);
			unityAction2..ctor(this, (IntPtr)obj6);
			button.m_OnClick.AddListener(unityAction2);
			obj7 = 0;
			obj5 = 0;
			unityAction = unityAction2;
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v9+E4]");
		object obj12;
		UnityAction unityAction3;
		if ((nint)0 != 0)
		{
			bool flag4 = createPrivateTournamentButton != null;
			bool flag5 = !flag4;
			object obj9 = !flag5;
			object obj10 = 0;
			UnityEngine.Object obj11 = null;
			if (obj9 != null)
			{
				goto IL_01b2;
			}
			obj12 = 0;
			unityAction3 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag6 = createPrivateTournamentButton != null;
			bool flag7 = !flag6;
			object obj10 = 0;
			UnityEngine.Object obj11 = null;
			obj12 = 0;
			unityAction3 = null;
			if (!flag7)
			{
				goto IL_01b2;
			}
		}
		goto IL_021b;
		IL_021b:
		object obj13 = typeof(SqlSingle[]) + 2376;
		object obj14 = (nint)0 + (nint)944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj14);
		creationButton.onClick += action;
		TabsUI tabsUI = tournamentTabsUI;
		object obj15 = typeof(TypeConverter<ushort, char>) + 408;
		object obj16 = (nint)0 + (nint)968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<int> unityAction4 = default(UnityAction<int>);
		unityAction4..ctor((object)this, (IntPtr)obj16);
		object obj17 = (nint)0 + (nint)968;
		object obj18 = (nint)0 + (nint)960;
		tabsUI.OnTabChanged.AddListener(unityAction4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj18);
		object obj19 = (nint)0 + (nint)920;
		object obj20 = typeof(RegisteredWaitHandle) + 56;
		object obj21 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		eventsChannel.OnTournamentsChanged += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj19);
		object obj22 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v22+E4]");
		bool flag8 = (nint)0 == 0;
		object obj23 = !flag8;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action3;
		object obj24 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v12+E4]");
		bool flag9 = (nint)0 == 0;
		object obj25 = !flag9;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PrefabInitializer.InitializePrefab(tournamentHelpPopup, CanvasLayer.SecondaryCanvas);
		Button button2 = helpButton;
		object obj26 = (nint)0 + (nint)952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction5 = default(UnityAction);
		unityAction5..ctor(this, (IntPtr)obj26);
		button2.m_OnClick.AddListener(unityAction5);
		return;
		IL_01b2:
		Button button3 = createPrivateTournamentButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)928;
		UnityAction unityAction6 = default(UnityAction);
		unityAction6..ctor(this, (IntPtr)obj27);
		button3.m_OnClick.AddListener(unityAction6);
		obj7 = 0;
		obj12 = 0;
		unityAction3 = unityAction6;
		goto IL_021b;
	}

	private void Start()
	{
		SFS.JoinRoomGroup(RoomGroup.Tournaments);
		UpdateCreationButton();
		ShowOnlySubscribersPopupForDiscountOfficial();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0144: Expected I, but got O
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0063: Expected O, but got I
		//IL_007b: Expected I, but got O
		//IL_008c: Expected O, but got I
		//IL_0098: Expected O, but got I
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00db: Expected I, but got O
		//IL_0105: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		eventsChannel.OnTournamentsChanged -= action;
		TabsUI tabsUI = tournamentTabsUI;
		object obj3 = typeof(TypeConverter<ushort, char>) + 408;
		object obj4 = (nint)0 + (nint)968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<int> unityAction = default(UnityAction<int>);
		unityAction..ctor((object)this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)984;
		object obj6 = (nint)0 + (nint)920;
		object obj7 = typeof(RegisteredWaitHandle) + 56;
		tabsUI.OnTabChanged.RemoveListener(unityAction);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj6);
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action2;
	}

	private void OnConfigChanged()
	{
		UpdateCreationButton();
	}

	private void OnEnable()
	{
		Refresh();
	}

	private void TournamentTabsUI_OnOnActiveTabIndexChanged(int index)
	{
		UpdateCreationButton();
	}

	private void UpdateCreationButton()
	{
		//IL_0026: Expected I4, but got I8
		//IL_0040: Expected O, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_008c: Expected O, but got I4
		//IL_011b: Expected O, but got I4
		//IL_0149: Expected O, but got I4
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_0251: Expected O, but got I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_01db: Expected O, but got I
		int activeTabIndex = tournamentTabsUI.ActiveTabIndex;
		int num = (int)(activeTabIndex & 0xFFFFFFFDL);
		bool flag = num == 0;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(RegisteredWaitHandle) + 56;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		TournamentsSection <Tournaments>k__BackingField = current.<Tournaments>k__BackingField;
		bool canCreateTournament = <Tournaments>k__BackingField.<Public>k__BackingField.CanCreateTournament;
		RemoteConfigModel current2 = RemoteConfig.Current;
		TournamentsSection <Tournaments>k__BackingField2 = current2.<Tournaments>k__BackingField;
		bool canCreateTournament2 = <Tournaments>k__BackingField2.<Private>k__BackingField.CanCreateTournament;
		object obj5 = (canCreateTournament ? 1 : 0) ^ 1;
		if (activeTabIndex != 0)
		{
			obj5 = 1;
		}
		object obj6 = obj5 & 1;
		bool flag3 = obj6 == null;
		object obj7 = !flag3;
		string text;
		bool interactable;
		if (obj7 == null)
		{
			object obj8 = "Complete" + 2928;
			text = (string)obj8;
			interactable = true;
		}
		else
		{
			bool flag4 = activeTabIndex != 0 && canCreateTournament2;
			object obj9 = "Complete" + 2928;
			object obj10 = "Complete" + 2912;
			if (activeTabIndex != 0)
			{
				obj9 = obj10;
			}
			text = (string)obj9;
			if (flag4)
			{
				interactable = true;
			}
			else
			{
				object obj11 = (nint)0 + (nint)3368;
				string text2 = (string)obj9 + (string)obj11;
				text = text2;
				interactable = false;
			}
		}
		CustomButton customButton = creationButton;
		TextMeshProExtensions.Localize(customButton.<textInput>k__BackingField, text);
		creationButton.interactable = interactable;
	}

	private void ShowOnlySubscribersPopupForDiscountOfficial()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0065: Expected O, but got I4
		//IL_008e: Expected O, but got I
		//IL_00db: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_00ed: Expected O, but got I4
		//IL_034e: Expected O, but got I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_03b2: Expected O, but got I4
		//IL_02bb: Expected O, but got I
		//IL_02cb: Expected O, but got I
		//IL_02e5: Expected O, but got I
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected O, but got Unknown
		//IL_0304: Expected O, but got I4
		//IL_030d: Expected O, but got I4
		//IL_0316: Expected O, but got I4
		//IL_015a: Expected O, but got I
		//IL_016a: Expected O, but got I
		//IL_0184: Expected O, but got I
		//IL_019c: Expected O, but got I4
		//IL_01a5: Expected O, but got I4
		//IL_056f: Expected O, but got I
		//IL_057f: Expected O, but got I
		//IL_05a1: Expected O, but got I4
		//IL_05b1: Expected O, but got I
		//IL_10c6: Expected O, but got I
		//IL_04f0: Expected O, but got I
		//IL_0500: Expected O, but got I
		//IL_0522: Expected O, but got I4
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_0415: Expected O, but got I4
		//IL_01c9: Expected I, but got O
		//IL_0200: Expected O, but got I4
		//IL_06ca: Expected O, but got I
		//IL_06da: Expected O, but got I
		//IL_06fc: Expected O, but got I4
		//IL_071c: Expected O, but got I
		//IL_05e9: Expected O, but got I4
		//IL_0fe5: Expected O, but got I
		//IL_0fff: Expected O, but got I
		//IL_1017: Expected O, but got I4
		//IL_1180: Expected O, but got I
		//IL_0643: Expected O, but got I
		//IL_0653: Expected O, but got I
		//IL_0675: Expected O, but got I4
		//IL_1113: Unknown result type (might be due to invalid IL or missing references)
		//IL_1118: Expected O, but got Unknown
		//IL_112e: Expected O, but got I
		//IL_113f: Expected I, but got O
		//IL_115d: Expected O, but got I
		//IL_0548: Expected O, but got I
		//IL_024e: Expected O, but got I
		//IL_0268: Expected O, but got I4
		//IL_0278: Expected I4, but got O
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07aa: Expected O, but got Unknown
		//IL_074c: Expected O, but got I4
		//IL_0619: Expected O, but got I
		//IL_0464: Expected O, but got I4
		//IL_0fa5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0faa: Expected O, but got Unknown
		//IL_0fb6: Expected O, but got I
		//IL_0877: Expected O, but got I
		//IL_0887: Expected O, but got I
		//IL_08a1: Expected O, but got I
		//IL_11ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b3: Expected O, but got Unknown
		//IL_11c9: Expected O, but got I
		//IL_11da: Expected I, but got O
		//IL_11f8: Expected O, but got I
		//IL_06a3: Expected O, but got I
		//IL_1045: Expected O, but got I
		//IL_1054: Unknown result type (might be due to invalid IL or missing references)
		//IL_1059: Expected O, but got Unknown
		//IL_1095: Expected O, but got I
		//IL_0294: Expected I4, but got O
		//IL_08be: Expected O, but got I4
		//IL_08c7: Expected O, but got I4
		//IL_08d7: Expected O, but got I
		//IL_07e7: Expected O, but got I
		//IL_07f7: Expected O, but got I
		//IL_0811: Expected O, but got I
		//IL_0829: Expected O, but got I4
		//IL_077c: Expected O, but got I
		//IL_0491: Expected I4, but got O
		//IL_1239: Expected O, but got I4
		//IL_0840: Expected O, but got I4
		//IL_0850: Expected O, but got I
		//IL_091e: Expected O, but got I4
		//IL_0d68: Expected O, but got I4
		//IL_0d71: Expected O, but got I4
		//IL_0983: Expected O, but got I4
		//IL_124f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1254: Expected O, but got Unknown
		//IL_0d99: Expected O, but got I4
		//IL_0da1: Expected O, but got I4
		//IL_0daa: Expected O, but got I4
		//IL_0a18: Expected O, but got I4
		//IL_09c9: Expected O, but got I4
		//IL_0a7d: Expected O, but got I4
		//IL_0dd9: Expected O, but got I4
		//IL_0e17: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1c: Expected I4, but got Unknown
		//IL_0e51: Expected O, but got I4
		//IL_0e59: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e5e: Expected O, but got Unknown
		//IL_127b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1280: Expected O, but got Unknown
		//IL_128c: Expected O, but got I
		//IL_12a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_12aa: Expected O, but got Unknown
		//IL_0b12: Expected O, but got I4
		//IL_0ac3: Expected O, but got I4
		//IL_0edf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee4: Expected O, but got Unknown
		//IL_0f0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f12: Expected O, but got Unknown
		//IL_0f3c: Expected O, but got I4
		//IL_0f63: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f68: Expected O, but got Unknown
		//IL_0c1d: Expected O, but got I4
		//IL_0bb8: Expected O, but got I4
		//IL_0bc8: Expected I4, but got O
		//IL_0c87: Expected F8, but got I8
		//IL_0c90: Expected O, but got I4
		//IL_0cc7: Expected O, but got I4
		//IL_0ce3: Expected F8, but got I8
		//IL_0cf4: Expected O, but got I4
		OfficialTournamentSubWallData offiTourSubWallData = OffiTourSubWallData;
		if (offiTourSubWallData.ShownCount > 3)
		{
			return;
		}
		object obj = typeof(Queue<string>) + 848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj4 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		bool flag2 = SFSKammelnaUserExtensions.IsSubscribed(localUser);
		bool flag3 = !flag2;
		object obj5 = !flag3;
		object obj6 = 0;
		DateTime dateTime = (DateTime)1;
		object obj7;
		if (obj5 == null)
		{
			OfficialTournamentSubWallData offiTourSubWallData2 = OffiTourSubWallData;
			obj7 = typeof(DataRelation) + 712;
			object obj8 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v165+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v165+B8]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v112+10]");
				dateTime = (DateTime)0;
				DateTime <DateTime>k__BackingField = offiTourSubWallData2.DateTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v112+10]");
				bool flag4 = <DateTime>k__BackingField == (DateTime)0;
				bool flag5 = !flag4;
				object obj10 = 0;
				obj6 = 0;
				if (!flag5)
				{
					goto IL_01b3;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v167+B8]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v106+10]");
				dateTime = (DateTime)0;
				DateTime <DateTime>k__BackingField2 = offiTourSubWallData2.DateTime;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v106+10]");
				bool flag4 = <DateTime>k__BackingField2 == (DateTime)0;
				bool flag6 = !flag4;
				object obj13 = !flag6;
				object obj10 = 0;
				obj6 = 0;
				if (obj13 != null)
				{
					goto IL_01b3;
				}
			}
		}
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v137+E4]");
		bool flag7 = (nint)0 == 0;
		object obj15 = !flag7;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		bool flag8 = SFSKammelnaUserExtensions.IsSubscribed(localUser2);
		bool flag9 = !flag8;
		object obj16 = 0;
		bool flag10 = true;
		OfficialTournamentSubWallData officialTournamentSubWallData;
		bool flag16;
		if (!flag9)
		{
			OfficialTournamentSubWallData offiTourSubWallData3 = OffiTourSubWallData;
			object obj17 = typeof(DataRelation) + 712;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v94+E4]");
			bool flag11 = (nint)0 == 0;
			object obj19 = !flag11;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj18 = obj17;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X8_v94+B8]");
			object obj20 = 0;
			DateTime <DateTime>k__BackingField3 = offiTourSubWallData3.DateTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v95+10]");
			bool flag12 = <DateTime>k__BackingField3 != (DateTime)0;
			bool flag13 = !flag12;
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v95+10]");
			flag10 = false;
			if (!flag13)
			{
				object obj21 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v148+E4]");
				bool flag14 = (nint)0 == 0;
				object obj22 = !flag14;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj21 = obj17;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v605 @ X0_v148+B8]");
				object obj23 = 0;
				object obj24 = typeof(SkeletonBinary.SkeletonInput) + 3712;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v97+10]");
				_ = 0;
				_ = 0;
				object obj25 = default(object);
				obj25..ctor();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EBA]");
				object obj26 = (nint)0 & (nint)1;
				bool flag15 = obj26 == null;
				officialTournamentSubWallData = (OfficialTournamentSubWallData)obj25;
				if (flag15)
				{
					goto IL_0286;
				}
				flag16 = (byte)(int)obj25 != 0;
				goto IL_0f9b;
			}
		}
		goto IL_0496;
		IL_0d01:
		bool flag17 = false;
		goto IL_120f;
		IL_08e5:
		OfficialTournamentSubWallData offiTourSubWallData4 = OffiTourSubWallData;
		object obj28;
		object obj27 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X0_v61+E4]");
		bool flag18 = (nint)0 == 0;
		object obj29 = !flag18;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime3 = default(DateTime);
		DateTime dateTime2 = dateTime3.AddDays(1.0);
		DateTime now = DateTime.Now;
		bool flag19 = dateTime2 < now;
		bool flag20 = !flag19;
		OfficialTournamentSubWallData officialTournamentSubWallData2 = (OfficialTournamentSubWallData)flag19;
		double num;
		object obj30;
		DateTime dateTime4;
		if (!flag20)
		{
			officialTournamentSubWallData2 = OffiTourSubWallData;
			bool flag21 = officialTournamentSubWallData2.ShownCount == 0;
			num = 1.0;
			obj30 = 0;
			dateTime4 = now;
			if (flag21)
			{
				goto IL_0bd6;
			}
		}
		OfficialTournamentSubWallData offiTourSubWallData5 = OffiTourSubWallData;
		object obj31 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v786 @ X0_v72+E4]");
		bool flag22 = (nint)0 == 0;
		object obj32 = !flag22;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime5 = dateTime3.AddDays(4.000000000465661);
		DateTime now2 = DateTime.Now;
		bool flag23 = dateTime5 < now2;
		bool flag24 = !flag23;
		OfficialTournamentSubWallData officialTournamentSubWallData3 = (OfficialTournamentSubWallData)flag23;
		if (!flag24)
		{
			officialTournamentSubWallData3 = OffiTourSubWallData;
			bool flag25 = officialTournamentSubWallData3.ShownCount == 1;
			num = 4.000000000465661;
			obj30 = 0;
			dateTime4 = now2;
			if (flag25)
			{
				goto IL_0bd6;
			}
		}
		OfficialTournamentSubWallData offiTourSubWallData6 = OffiTourSubWallData;
		object obj33 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v855 @ X0_v82+E4]");
		bool flag26 = (nint)0 == 0;
		object obj34 = !flag26;
		if (obj34 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime6 = dateTime3.AddDays(16.000000001164153);
		DateTime now3 = DateTime.Now;
		if (dateTime6 < now3)
		{
			OfficialTournamentSubWallData offiTourSubWallData7 = OffiTourSubWallData;
			bool flag27 = offiTourSubWallData7.ShownCount != 2;
			num = 16.000000001164153;
			obj30 = 0;
			dateTime4 = now3;
			bool flag28 = (byte)(int)offiTourSubWallData7 != 0;
			if (!flag27)
			{
				goto IL_0bd6;
			}
		}
		OfficialTournamentSubWallData offiTourSubWallData8 = OffiTourSubWallData;
		object obj35 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v891 @ X0_v92+E4]");
		bool flag29 = (nint)0 == 0;
		object obj36 = !flag29;
		if (obj36 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime dateTime7 = dateTime3.AddDays(42.0);
		DateTime now4 = DateTime.Now;
		bool flag30 = dateTime7 < now4;
		bool flag31 = !flag30;
		num = 4.631107791820423E+18;
		obj30 = 0;
		dateTime4 = now4;
		if (flag31)
		{
			goto IL_0d01;
		}
		OfficialTournamentSubWallData offiTourSubWallData9 = OffiTourSubWallData;
		object obj37 = offiTourSubWallData9.ShownCount - 3;
		bool flag32 = obj37 == null;
		num = 4.631107791820423E+18;
		flag17 = flag32;
		obj30 = 0;
		dateTime4 = now4;
		goto IL_120f;
		IL_10ba:
		object obj38 = (nint)0 + (nint)3984;
		IEnumerable<object> source;
		Func<object, object> selector;
		IEnumerable<object> enumerable = Enumerable.Select(source, selector);
		object obj40;
		object obj39 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X0_v113+E4]");
		object obj41;
		Func<object, bool> predicate;
		IEnumerable<object> source2;
		IEnumerable<object> enumerable2;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X0_v113+B8]");
			obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v72+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v72+10]");
			bool flag33 = (nint)0 == 0;
			object obj42 = !flag33;
			source2 = enumerable;
			if (obj42 == null)
			{
				enumerable2 = enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v72+10]");
				Func<object, bool> func = (Func<object, bool>)0;
				goto IL_072a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj39 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X0_v113+B8]");
			obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v72+10]");
			Func<object, bool> func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v72+10]");
			bool flag34 = (nint)0 == 0;
			object obj43 = !flag34;
			enumerable2 = enumerable;
			source2 = enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v72+10]");
			predicate = (Func<object, bool>)0;
			if (obj43 == null)
			{
				goto IL_072a;
			}
		}
		goto IL_1174;
		IL_01b3:
		OfficialTournamentSubWallData offiTourSubWallData10 = OffiTourSubWallData;
		nint num2 = (nint)offiTourSubWallData10;
		OfficialTournamentSubWallData officialTournamentSubWallData4 = offiTourSubWallData10.<Clone>$();
		object obj44 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v173+E4]");
		bool flag35 = (nint)0 == 0;
		object obj45 = !flag35;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now5 = DateTime.Now;
		officialTournamentSubWallData4.DateTime = now5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EBA]");
		object obj46 = (nint)0 & (nint)1;
		bool flag36 = obj46 == null;
		object obj47 = !flag36;
		officialTournamentSubWallData = officialTournamentSubWallData4;
		flag16 = (byte)(int)officialTournamentSubWallData4 != 0;
		if (obj47 == null)
		{
			goto IL_0286;
		}
		goto IL_0f9b;
		IL_0286:
		_ = 1;
		flag16 = (byte)(int)officialTournamentSubWallData != 0;
		goto IL_0f9b;
		IL_0f9b:
		object obj48 = "October" + 56;
		object obj49 = (nint)0 + (nint)2520;
		obj16 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81418");
		flag10 = flag16;
		goto IL_0496;
		IL_120f:
		object obj50 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v738 @ X0_v26+E4]");
		bool flag37 = (nint)0 == 0;
		object obj51 = !flag37;
		if (obj51 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		User localUser3 = sessionModel3.LocalUser;
		bool flag38 = SFSKammelnaUserExtensions.IsSubscribed(localUser3);
		object obj52;
		bool flag39 = obj52 == null;
		OfficialTournamentSubWallData officialTournamentSubWallData5 = (OfficialTournamentSubWallData)flag38;
		object obj53 = 0;
		if (!flag39)
		{
			bool flag40 = !flag38;
			object obj54 = !flag40;
			officialTournamentSubWallData5 = (OfficialTournamentSubWallData)flag38;
			obj53 = 0;
			if (obj54 == null)
			{
				officialTournamentSubWallData5 = OffiTourSubWallData;
				object obj55 = officialTournamentSubWallData5.NonSubBuys - 4;
				bool flag41 = (nint)obj55 < 0;
				bool flag42 = obj55 == null;
				int num3 = officialTournamentSubWallData5.NonSubBuys ^ 4;
				int num4 = officialTournamentSubWallData5.NonSubBuys ^ obj55;
				int num5 = num3 & num4;
				bool flag43 = num5 < 0;
				bool flag44 = flag41 == flag43;
				object obj56 = !flag42;
				object obj57 = flag44 & obj56;
				obj53 = obj57;
			}
		}
		object obj58 = obj53 & flag17;
		if (obj58 != null)
		{
			OfficialTournamentSubWallData offiTourSubWallData11 = OffiTourSubWallData;
			OfficialTournamentSubWallData officialTournamentSubWallData6 = offiTourSubWallData11.<Clone>$();
			OfficialTournamentSubWallData offiTourSubWallData12 = OffiTourSubWallData;
			int <ShownCount>k__BackingField = offiTourSubWallData12.ShownCount + 1;
			officialTournamentSubWallData6.ShownCount = <ShownCount>k__BackingField;
			object obj59 = "October" + 56;
			object obj60 = (nint)0 + (nint)2520;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F81418");
			object obj61 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1608;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Enum enumeration = default(Enum);
			string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
			OfficialTournamentSubWallData offiTourSubWallData13 = OffiTourSubWallData;
			int num6 = default(int);
			string text = num6.ToString();
			object obj62 = "Read object reference Id '{0}' for {1}." + 1512;
			string context = friendlyName + (string)obj62 + text;
			object obj63 = typeof(MemberAchievementClanFeedData) + 3448;
			object obj64 = obj63;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v881 @ X0_v46+E4]");
			bool flag45 = (nint)0 == 0;
			object obj65 = !flag45;
			if (obj65 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object text2 = "SetRoomVariables request error" + 4072;
			OnlyForSubscribersPopup.Show(TrackingFeature.Tournament, officialTournamentIcon, (string)text2, officialTournamentPrices, null, context);
		}
		return;
		IL_0bd6:
		flag17 = true;
		goto IL_120f;
		IL_0496:
		IEnumerable<Room> tournamentRooms = SFS.TournamentRooms;
		obj40 = typeof(SkeletonBinary.SkeletonInput) + 3696;
		object obj66 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v82+E4]");
		object obj67;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v82+B8]");
			obj67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X9_v12+8]");
			selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X9_v12+8]");
			bool flag46 = (nint)0 == 0;
			object obj68 = !flag46;
			source = tournamentRooms;
			if (obj68 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X9_v12+8]");
				Func<object, object> func2 = (Func<object, object>)0;
				goto IL_05c7;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj66 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v82+B8]");
			obj67 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X9_v12+8]");
			Func<object, object> func2 = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X9_v12+8]");
			bool flag47 = (nint)0 == 0;
			object obj69 = !flag47;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X9_v12+8]");
			selector = (Func<object, object>)0;
			source = tournamentRooms;
			if (obj69 == null)
			{
				goto IL_05c7;
			}
		}
		goto IL_10ba;
		IL_1174:
		object obj70 = (nint)0 + (nint)1328;
		obj52 = Enumerable.FirstOrDefault(source2, predicate);
		OfficialTournamentSubWallData offiTourSubWallData14 = OffiTourSubWallData;
		obj28 = typeof(DataRelation) + 712;
		object obj71 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v21+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v666 @ X8_v21+B8]");
			object obj72 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v70+10]");
			dateTime4 = (DateTime)0;
			DateTime <DateTime>k__BackingField4 = offiTourSubWallData14.DateTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v70+10]");
			bool flag48 = <DateTime>k__BackingField4 != (DateTime)0;
			bool flag49 = !flag48;
			obj30 = 0;
			if (!flag49)
			{
				object obj73 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v70+10]");
				DateTime dateTime8 = (DateTime)0;
				goto IL_08e5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj74 = obj28;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X8_v68+B8]");
			object obj75 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v69+10]");
			DateTime dateTime8 = (DateTime)0;
			DateTime <DateTime>k__BackingField5 = offiTourSubWallData14.DateTime;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v69+10]");
			bool flag48 = <DateTime>k__BackingField5 != (DateTime)0;
			bool flag50 = !flag48;
			object obj73 = 0;
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v69+10]");
			dateTime4 = (DateTime)0;
			if (!flag50)
			{
				goto IL_08e5;
			}
		}
		goto IL_0d01;
		IL_05c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v82+E4]");
		bool flag51 = (nint)0 == 0;
		object obj76 = !flag51;
		if (obj76 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj77 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v89+B8]");
			obj67 = 0;
		}
		object obj78 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj79 = (nint)0 + (nint)80;
		Func<object, object> func3 = default(Func<object, object>);
		func3..ctor(obj67, (IntPtr)obj79);
		object obj80 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X8_v88+B8]");
		object obj81 = (nint)0 + (nint)8;
		obj81 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector = func3;
		source = tournamentRooms;
		goto IL_10ba;
		IL_072a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X0_v113+E4]");
		bool flag52 = (nint)0 == 0;
		object obj82 = !flag52;
		if (obj82 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj83 = obj40;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v659 @ X8_v78+B8]");
			obj41 = 0;
		}
		object obj84 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj85 = (nint)0 + (nint)88;
		Func<object, bool> func4 = default(Func<object, bool>);
		func4..ctor(obj41, (IntPtr)obj85);
		object obj86 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v77+B8]");
		object obj87 = (nint)0 + (nint)16;
		obj87 = func4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		source2 = enumerable2;
		predicate = func4;
		goto IL_1174;
	}

	public void Refresh()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00c7: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_013a: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 832;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E3D]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2168;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
			object obj4 = (nint)0 + (nint)2168;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
		SFSRefreshStatusMonitor sFSRefreshStatusMonitor = default(SFSRefreshStatusMonitor);
		bool flag3 = (object)sFSRefreshStatusMonitor == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		sFSRefreshStatusMonitor.CheckTicketsAndRefresh();
		UpdateCreationButton();
	}

	public void OnCreateTournamentClicked()
	{
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_0201: Expected O, but got I4
		//IL_004b: Expected O, but got I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0097: Expected O, but got I4
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_02b1: Expected O, but got I4
		//IL_049b: Expected O, but got I
		//IL_04ab: Expected O, but got I
		//IL_04cd: Expected O, but got I4
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Expected O, but got Unknown
		//IL_036b: Expected O, but got I4
		//IL_0394: Expected O, but got I
		//IL_02f8: Expected O, but got I4
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0147: Expected O, but got I4
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_050a: Expected O, but got I
		//IL_0512: Expected I, but got O
		//IL_0523: Expected I, but got O
		//IL_0541: Expected O, but got I
		//IL_0552: Expected O, but got I4
		//IL_03b0: Expected O, but got I
		//IL_03c0: Expected O, but got I
		//IL_03e2: Expected O, but got I4
		//IL_0328: Expected O, but got I
		//IL_018e: Expected O, but got I4
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_041f: Expected O, but got I
		//IL_0427: Expected I, but got O
		//IL_0438: Expected I, but got O
		//IL_0456: Expected O, but got I
		//IL_0467: Expected O, but got I4
		//IL_01be: Expected O, but got I
		int activeTabIndex = tournamentTabsUI.ActiveTabIndex;
		Action<object> action;
		Action<object> action2;
		if (activeTabIndex != 2)
		{
			bool flag = activeTabIndex == 0;
			object obj = !flag;
			if (obj != null)
			{
				return;
			}
			object obj2 = typeof(RegisteredWaitHandle) + 56;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v31+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RemoteConfigModel current = RemoteConfig.Current;
			TournamentsSection <Tournaments>k__BackingField = current.<Tournaments>k__BackingField;
			if (!<Tournaments>k__BackingField.<Public>k__BackingField.CanCreateTournament)
			{
				return;
			}
			ComponentReference<TournamentCreationPopup> componentReference = tournamentCreationPopup;
			object obj5 = typeof(SkeletonBinary.SkeletonInput) + 3696;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v38+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj5;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v38+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v32+18]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v32+18]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			action2 = null;
			if (obj9 != null)
			{
				goto IL_032d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v199 @ X0_v38+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = !flag5;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj11 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v38+B8]");
				obj8 = 0;
			}
			object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3768;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj13 = (nint)0 + (nint)64;
			nint num = (nint)obj13;
			Action<object> action3 = default(Action<object>);
			action3..ctor(obj8, (IntPtr)obj13);
			object obj14 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v37+B8]");
			object obj15 = (nint)0 + (nint)24;
			obj15 = action3;
			object obj16 = 0;
			action = action3;
		}
		else
		{
			object obj17 = typeof(RegisteredWaitHandle) + 56;
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v14+E4]");
			bool flag6 = (nint)0 == 0;
			object obj19 = !flag6;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RemoteConfigModel current2 = RemoteConfig.Current;
			TournamentsSection <Tournaments>k__BackingField2 = current2.<Tournaments>k__BackingField;
			if (!<Tournaments>k__BackingField2.<Private>k__BackingField.CanCreateTournament)
			{
				return;
			}
			ComponentReference<TournamentCreationPopup> componentReference = tournamentCreationPopup;
			object obj20 = typeof(SkeletonBinary.SkeletonInput) + 3696;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v21+E4]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v21+B8]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v18+20]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v18+20]");
			bool flag8 = (nint)0 == 0;
			object obj24 = !flag8;
			action2 = null;
			if (obj24 != null)
			{
				goto IL_032d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v21+E4]");
			bool flag9 = (nint)0 == 0;
			object obj25 = !flag9;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj26 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X8_v24+B8]");
				obj23 = 0;
			}
			object obj27 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3768;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj28 = (nint)0 + (nint)72;
			nint num = (nint)obj28;
			Action<object> action4 = default(Action<object>);
			action4..ctor(obj23, (IntPtr)obj28);
			object obj29 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v23+B8]");
			object obj15 = (nint)0 + (nint)32;
			obj15 = action4;
			object obj16 = 0;
			action = action4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action2 = action;
		goto IL_032d;
		IL_032d:
		object obj30 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v10+E4]");
		bool flag10 = (nint)0 == 0;
		object obj32 = !flag10;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj33 = (nint)0 + (nint)2400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	public void OnCreatePublicTournamentClicked()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_0260: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_034a: Expected O, but got I
		//IL_035b: Expected I, but got O
		//IL_0379: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_02cb: Expected O, but got I4
		//IL_0290: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E3F]");
		object obj3 = (nint)0 & (nint)1;
		ComponentReference<TournamentCreationPopup> componentReference2;
		object obj4;
		ComponentReference<TournamentCreationPopup> componentReference;
		if (obj3 != null)
		{
			componentReference = tournamentCreationPopup;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			componentReference2 = tournamentCreationPopup;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			componentReference = tournamentCreationPopup;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			componentReference2 = tournamentCreationPopup;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+28]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+28]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_0102:
		object obj11 = (nint)0 + (nint)2400;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = obj11;
		Action<object> action2 = action;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0153;
		}
		goto IL_02f9;
		IL_02f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj13;
		action = action2;
		componentReference = componentReference2;
		goto IL_0153;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0099:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+28]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+28]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_023e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)56;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+B8]");
		object obj19 = (nint)0 + (nint)40;
		obj19 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)2400;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action = action3;
		componentReference = componentReference2;
		obj13 = obj11;
		action2 = action3;
		if (obj20 != null)
		{
			goto IL_0153;
		}
		goto IL_02f9;
	}

	public void OnCreatePrivateTournamentClicked()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0198: Expected O, but got I4
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00cd: Expected O, but got I
		//IL_0260: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_034a: Expected O, but got I
		//IL_035b: Expected I, but got O
		//IL_0379: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_02a1: Expected O, but got I
		//IL_02cb: Expected O, but got I4
		//IL_0290: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(SkeletonBinary.SkeletonInput) + 3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E40]");
		object obj3 = (nint)0 & (nint)1;
		ComponentReference<TournamentCreationPopup> componentReference2;
		object obj4;
		ComponentReference<TournamentCreationPopup> componentReference;
		if (obj3 != null)
		{
			componentReference = tournamentCreationPopup;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			componentReference2 = tournamentCreationPopup;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			componentReference = tournamentCreationPopup;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			componentReference2 = tournamentCreationPopup;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+30]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+30]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		componentReference = componentReference2;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_0102:
		object obj11 = (nint)0 + (nint)2400;
		object obj12 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		object obj13 = obj11;
		Action<object> action2 = action;
		componentReference2 = componentReference;
		if (!flag4)
		{
			goto IL_0153;
		}
		goto IL_02f9;
		IL_02f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj13;
		action = action2;
		componentReference = componentReference2;
		goto IL_0153;
		IL_0153:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
		return;
		IL_0099:
		obj7 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+30]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v4+30]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		componentReference2 = componentReference;
		if (!flag5)
		{
			goto IL_0102;
		}
		goto IL_023e;
		IL_023e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj14 = !flag6;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj15 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj17 = (nint)0 + (nint)48;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj8, (IntPtr)obj17);
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v9+B8]");
		object obj19 = (nint)0 + (nint)48;
		obj19 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = (nint)0 + (nint)2400;
		obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj20 = !flag7;
		action = action3;
		componentReference = componentReference2;
		obj13 = obj11;
		action2 = action3;
		if (obj20 != null)
		{
			goto IL_0153;
		}
		goto IL_02f9;
	}

	public void OnHelpButtonClicked()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01c1: Expected O, but got I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0086: Expected O, but got I4
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_022e: Expected O, but got I
		//IL_023f: Expected I, but got O
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_027d: Expected O, but got I4
		//IL_01e1: Expected O, but got I
		//IL_013f: Expected O, but got I4
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0182: Expected O, but got I4
		//IL_01b7: Expected O, but got I4
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3704;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		int activeTabIndex = tournamentTabsUI.ActiveTabIndex;
		if (activeTabIndex == 3)
		{
			object obj3 = typeof(RegisteredWaitHandle) + 56;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			RemoteConfigModel current = RemoteConfig.Current;
			TournamentsSection <Tournaments>k__BackingField = current.<Tournaments>k__BackingField;
			if (!string.IsNullOrEmpty(<Tournaments>k__BackingField.<MassTutorialUrl>k__BackingField))
			{
				object obj6 = typeof(RegisteredWaitHandle) + 1552;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v20+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				RoutingManager.Route(RoutingCommand.OpenCustomURL, <Tournaments>k__BackingField.<MassTutorialUrl>k__BackingField, (Games?)(object)0);
			}
			return;
		}
		_ = 0;
		switch (activeTabIndex)
		{
		case 2:
		{
			object obj9 = 1;
			break;
		}
		case 1:
		{
			object obj9 = 3;
			break;
		}
		}
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj11 = (nint)0 + (nint)96;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj11);
		object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v10+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj15 = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}
}
