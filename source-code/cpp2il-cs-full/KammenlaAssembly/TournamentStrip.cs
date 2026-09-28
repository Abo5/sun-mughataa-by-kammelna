using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using ListView;
using Server.Models;
using Sfs2X.Entities;
using Spine;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class TournamentStrip : ListViewItem<TournamentDataHolder, int>, ITournamentRequests
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<bool> <>9__37_0;

		public static Action <>9__37_1;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3920;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <JoinRoom>b__37_0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ee: Expected O, but got I
			//IL_0118: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_017d: Expected I4, but got O
			//IL_0161: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D76]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			goto IL_016f;
			IL_00b8:
			Room currentRoom = sessionModel.CurrentRoom;
			return SFSKammelnaRoomExtensions.IsTournamentHub(currentRoom);
			IL_016f:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_016f;
		}

		internal void <JoinRoom>b__37_1()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Expected O, but got Unknown
			//IL_00d1: Expected O, but got I4
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			object obj = typeof(RegisteredWaitHandle) + 3136;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "Index = {0} position = {1}" + 1736;
			ScreenManager.AnimateTransitionIn();
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				PopupWindow.ShowError((string)message);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.ShowError((string)message);
		}
	}

	private sealed class <>c__DisplayClass38_0
	{
		public List<Vector2> captchaSolution;

		public TournamentStrip <>4__this;

		public TournamentData tournament;

		internal void <Participate>b__1(List<Vector2> solution)
		{
			//IL_0011: Expected O, but got I
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			object obj = (nint)0 + (nint)3312;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			captchaSolution.AddRange(solution);
			<Participate>g__AcceptCallback|0(null);
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				PopupWindow.DismissMessage();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.DismissMessage();
		}

		internal void <Participate>g__AcceptCallback|0(string password)
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0043: Expected O, but got I
			//IL_005b: Expected I, but got O
			GameObject gameObject = <>4__this.gameObject;
			TournamentStrip tournamentStrip = <>4__this;
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2424;
			object obj2 = (nint)0 + (nint)400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			SFS.TournamentParticipateSuccess tournamentParticipateSuccess = default(SFS.TournamentParticipateSuccess);
			tournamentParticipateSuccess..ctor(this, (IntPtr)obj2);
			TournamentParticipationUtil.Participate(gameObject, tournamentStrip.eventsChannel, tournament, password, captchaSolution, tournamentParticipateSuccess);
		}

		internal void <Participate>b__2(int _)
		{
			TournamentStrip tournamentStrip = <>4__this;
			tournamentStrip.eventsChannel.TriggerTournamentsChanged();
		}
	}

	private sealed class <>c__DisplayClass39_0
	{
		public TournamentData tournamentInfo;

		public TournamentStrip <>4__this;

		internal void <Forfeit>g__ForfeitAction|0()
		{
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_0043: Expected O, but got I
			//IL_005b: Expected I, but got O
			GameObject gameObject = <>4__this.gameObject;
			TournamentStrip tournamentStrip = <>4__this;
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 2424;
			object obj2 = (nint)0 + (nint)416;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			SFS.TournamentParticipateSuccess tournamentParticipateSuccess = default(SFS.TournamentParticipateSuccess);
			tournamentParticipateSuccess..ctor(this, (IntPtr)obj2);
			TournamentParticipationUtil.Forfeit(tournamentInfo, gameObject, tournamentStrip.eventsChannel, tournamentParticipateSuccess);
		}

		internal void <Forfeit>b__1(int _)
		{
			TournamentStrip tournamentStrip = <>4__this;
			tournamentStrip.eventsChannel.TriggerTournamentsChanged();
		}
	}

	private sealed class <>c__DisplayClass41_0
	{
		public TournamentData tournament;

		public TournamentStrip <>4__this;

		internal void <PopulateVisualData>b__0()
		{
			SportTeamsCelebrationTournamentAddon tournamentAddonsSportTeamsCelebration = tournament.TournamentAddonsSportTeamsCelebration;
			tournamentAddonsSportTeamsCelebration.Refresh();
			TournamentStrip tournamentStrip = <>4__this;
			SportTeamsCelebrationTournamentAddon tournamentAddonsSportTeamsCelebration2 = tournament.TournamentAddonsSportTeamsCelebration;
			tournamentStrip.sportTeamColorizer.Initialize(tournamentAddonsSportTeamsCelebration2.<sportTeam>k__BackingField);
		}
	}

	private TournamentsEventsChannel eventsChannel;

	private ThemeProvider themeProvider;

	private TournamentGraphic graphic;

	private TournamentName nameText;

	private GameObject engraving;

	private RankSetter rank;

	private RankSetter requiredRank;

	private TitleSetter title;

	private TournamentParticipants participants;

	private TournamentTime dateTime;

	private TournamentInfoIcons infoIcons;

	private TournamentButtons buttons;

	private TournamentEligibilityIndicator eligibilityIndicator;

	private TournamentPrizeUi prizeUi;

	private TournamentSprites tournamentSprites;

	private TournamentJoinCostUi feeText;

	private TournamentJoinCostUi joinCostUi;

	private TextMeshProUGUI currentStageText;

	private Sprite passwordIcon;

	private GameObject visibilityIndicator;

	private GameObject tournamentMessageButton;

	private TournamentMessage tournamentMessage;

	private Image messageIcon;

	private TournamentRequirementInfo requirementInfo;

	private SportTeamColorizer sportTeamColorizer;

	private TournamentCardRoomThemeSetter cardRoomThemeSetter;

	private GameObject clusterSize;

	private TextMeshProUGUI clusterSizeText;

	private SwipeCaptcha captchaPrefab;

	private Room tournamentRoom;

	private TournamentRoomModel roomModel;

	private TournamentStatus _oldStatus;

	public override void Setup(TournamentDataHolder datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_00f5: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_01af: Expected O, but got I
		//IL_0131: Expected O, but got I
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0077: Expected O, but got I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0197: Expected O, but got I
		object obj = (nint)0 + (nint)2032;
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime);
		if (firstTime)
		{
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v15+E4]");
			if ((nint)0 != 0)
			{
				bool flag = buttons;
				bool flag2 = !flag;
				object obj4 = !flag2;
				if (obj4 != null)
				{
					goto IL_00c1;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if ((bool)buttons)
				{
					goto IL_00c1;
				}
			}
		}
		goto IL_00e5;
		IL_00c1:
		object obj5 = buttons + 104;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		goto IL_00e5;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentStrip)+40]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+30]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+30]");
			roomModel = (TournamentRoomModel)0;
			object obj7 = this + 368;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			tournamentRoom = null;
			object obj8 = this + 360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			ResetUI();
			GameObject go = base.gameObject;
			VariableBinderExtensions.Unbind(go);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+30]");
			PopulateSyncedData((TournamentRoomModel)0);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v5+28]");
			Initialize((Room)0);
		}
	}

	public void InitializeFromData(TournamentRoomModel syncedRoom)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		roomModel = syncedRoom;
		object obj = this + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		tournamentRoom = null;
		object obj2 = this + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ResetUI();
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		PopulateSyncedData(syncedRoom);
	}

	private void PopulateSyncedData(TournamentRoomModel syncedRoom)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_009a: Expected O, but got I4
		//IL_0409: Expected I, but got O
		//IL_045f: Expected O, but got I4
		//IL_0119: Expected O, but got I4
		//IL_051e: Expected O, but got I4
		//IL_01a0: Expected O, but got I4
		//IL_05f0: Expected O, but got I4
		//IL_05f9: Expected O, but got I4
		//IL_0607: Expected I, but got O
		//IL_0610: Expected O, but got I4
		//IL_0233: Expected O, but got I4
		//IL_06d4: Expected O, but got I4
		//IL_02da: Expected O, but got I4
		//IL_077a: Expected I, but got O
		//IL_07d0: Expected O, but got I4
		//IL_0379: Expected O, but got I4
		//IL_0895: Unknown result type (might be due to invalid IL or missing references)
		//IL_089a: Expected O, but got Unknown
		//IL_08c4: Expected O, but got I4
		//IL_08ed: Expected O, but got I
		//IL_0a25: Expected O, but got I4
		//IL_0c88: Expected O, but got I4
		//IL_0982: Expected O, but got I4
		//IL_0d42: Expected I, but got O
		//IL_0d93: Expected O, but got I4
		//IL_0ac4: Expected O, but got I4
		//IL_0e9c: Expected O, but got I4
		//IL_0ea4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea9: Expected O, but got Unknown
		//IL_0ebb: Expected I4, but got O
		//IL_0efe: Expected O, but got I4
		//IL_0b67: Expected O, but got I4
		//IL_0fc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fca: Expected O, but got Unknown
		//IL_0fd3: Expected O, but got I4
		//IL_0ff4: Expected O, but got I4
		//IL_100a: Expected I4, but got O
		//IL_1021: Expected O, but got I4
		//IL_103f: Expected I, but got O
		//IL_107d: Expected O, but got I4
		//IL_0bfa: Expected O, but got I4
		//IL_0c2e: Expected O, but got I4
		if (syncedRoom == null)
		{
			return;
		}
		TournamentData <Info>k__BackingField = syncedRoom.<Info>k__BackingField;
		if (syncedRoom.<Info>k__BackingField == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v3+E4]");
		TournamentData tournamentData;
		if ((nint)0 != 0)
		{
			bool flag = graphic;
			bool flag2 = !flag;
			object obj3 = !flag2;
			tournamentData = null;
			if (obj3 == null)
			{
				goto IL_00ad;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = graphic;
			bool flag4 = !flag3;
			tournamentData = null;
			if (flag4)
			{
				goto IL_00ad;
			}
		}
		TournamentGraphic tournamentGraphic = graphic;
		nint num = (nint)tournamentGraphic;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v58 (Il2CppClass<TournamentGraphic>)+180]");
		nint num2 = 0;
		tournamentGraphic.Initialize(syncedRoom.<Info>k__BackingField);
		UnityEngine.Object obj4 = nameText;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v114+E4]");
		bool flag5 = (nint)0 == 0;
		object obj6 = !flag5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X8_v58 (Il2CppClass<TournamentGraphic>)+180]");
		nint num3 = 0;
		tournamentData = syncedRoom.<Info>k__BackingField;
		UnityEngine.Object obj7 = nameText;
		if (obj6 != null)
		{
			goto IL_00f6;
		}
		goto IL_0494;
		IL_0aeb:
		UnityEngine.Object obj8 = participants;
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v14+E4]");
		bool flag6 = (nint)0 == 0;
		object obj11;
		object obj10 = obj11;
		bool flag8;
		bool flag7 = flag8;
		bool flag10;
		bool flag9 = flag10;
		UnityEngine.Object obj12 = participants;
		if (!flag6)
		{
			goto IL_0b44;
		}
		goto IL_0f38;
		IL_0f38:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag11 = obj12;
		bool flag12 = !flag11;
		obj11 = obj10;
		flag8 = flag7;
		flag10 = flag9;
		int num4 = 0;
		if (flag12)
		{
			goto IL_0b96;
		}
		goto IL_0f8e;
		IL_0b96:
		UnityEngine.Object obj13 = currentStageText;
		object obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1006 @ X8_v8+E4]");
		bool flag13 = (nint)0 == 0;
		UnityEngine.Object obj15 = currentStageText;
		if (!flag13)
		{
			goto IL_0bd7;
		}
		goto IL_10af;
		IL_0f8e:
		UnityEngine.Component component = participants;
		GameObject go = participants.gameObject;
		VariableBinderExtensions.Unbind(go);
		object obj16 = participants + 32;
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj17 = <Info>k__BackingField.<MaxAllowedSize>k__BackingField - syncedRoom.<Participants>k__BackingField;
		object obj18 = ~obj17;
		flag8 = (byte)(obj17 & obj18) != 0;
		object obj19 = syncedRoom.<Participants>k__BackingField - <Info>k__BackingField.<MaxAllowedSize>k__BackingField;
		object obj20 = ~obj19;
		obj11 = obj19 & obj20;
		nint num5 = (nint)component;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1047 @ X8_v12 (Il2CppClass<UnityEngine.Component>)+178] (should have been resolved before IL gen)");
		obj13 = currentStageText;
		obj14 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1006 @ X8_v8+E4]");
		bool flag14 = (nint)0 == 0;
		object obj21 = !flag14;
		flag10 = (byte)syncedRoom.<Participants>k__BackingField != 0;
		num4 = <Info>k__BackingField.<MaxAllowedSize>k__BackingField;
		obj15 = currentStageText;
		if (obj21 != null)
		{
			goto IL_0bd7;
		}
		goto IL_10af;
		IL_0b44:
		bool flag15 = obj8;
		bool flag16 = !flag15;
		object obj22 = !flag16;
		num4 = 0;
		obj10 = obj11;
		flag7 = flag8;
		flag9 = flag10;
		if (obj22 == null)
		{
			goto IL_0b96;
		}
		goto IL_0f8e;
		IL_00ad:
		obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v114+E4]");
		bool flag17 = (nint)0 == 0;
		obj4 = nameText;
		num3 = num2;
		obj7 = nameText;
		if (!flag17)
		{
			goto IL_00f6;
		}
		goto IL_0494;
		IL_0494:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag18 = obj7;
		bool flag19 = !flag18;
		num2 = num3;
		TournamentData tournamentData2 = null;
		if (flag19)
		{
			goto IL_0134;
		}
		goto IL_04d6;
		IL_00f6:
		bool flag20 = obj4;
		bool flag21 = !flag20;
		object obj23 = !flag21;
		tournamentData2 = null;
		num3 = num2;
		if (obj23 == null)
		{
			goto IL_0134;
		}
		goto IL_04d6;
		IL_04d6:
		nameText.Initialize(syncedRoom.<Info>k__BackingField);
		UnityEngine.Object obj24 = rank;
		object obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v107+E4]");
		bool flag22 = (nint)0 == 0;
		object obj26 = !flag22;
		num2 = num3;
		tournamentData2 = syncedRoom.<Info>k__BackingField;
		UnityEngine.Object obj27 = rank;
		if (obj26 != null)
		{
			goto IL_017d;
		}
		goto IL_054b;
		IL_0134:
		obj25 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v459 @ X0_v107+E4]");
		bool flag23 = (nint)0 == 0;
		obj24 = rank;
		num3 = num2;
		obj27 = rank;
		if (!flag23)
		{
			goto IL_017d;
		}
		goto IL_054b;
		IL_054b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag24 = obj27;
		bool flag25 = !flag24;
		num2 = num3;
		PlayerRank.Ranks ranks = PlayerRank.Ranks.AI;
		if (flag25)
		{
			goto IL_01b7;
		}
		goto IL_0591;
		IL_017d:
		bool flag26 = obj24;
		bool flag27 = !flag26;
		object obj28 = !flag27;
		ranks = PlayerRank.Ranks.AI;
		if (obj28 == null)
		{
			goto IL_01b7;
		}
		goto IL_0591;
		IL_0591:
		ranks = <Info>k__BackingField.<RankLimit>k__BackingField;
		rank.SetRank(<Info>k__BackingField.<RankLimit>k__BackingField);
		UnityEngine.Object obj29 = infoIcons;
		object obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v100+E4]");
		bool flag28 = (nint)0 == 0;
		object obj31 = !flag28;
		obj10 = 0;
		flag7 = false;
		num2 = unchecked((nint)null);
		obj11 = 0;
		flag8 = false;
		bool flag29 = false;
		UnityEngine.Object obj32 = infoIcons;
		if (obj31 != null)
		{
			goto IL_0210;
		}
		goto IL_063a;
		IL_01b7:
		obj30 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X0_v100+E4]");
		bool flag30 = (nint)0 == 0;
		obj29 = infoIcons;
		obj11 = obj10;
		flag8 = flag7;
		flag29 = (byte)num2 != 0;
		obj32 = infoIcons;
		if (!flag30)
		{
			goto IL_0210;
		}
		goto IL_063a;
		IL_063a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag31 = obj32;
		bool flag32 = !flag31;
		obj10 = obj11;
		flag7 = flag8;
		num2 = (flag29 ? 1 : 0);
		TournamentData tournamentData3 = null;
		if (flag32)
		{
			goto IL_025e;
		}
		goto IL_068c;
		IL_0210:
		bool flag33 = obj29;
		bool flag34 = !flag33;
		object obj33 = !flag34;
		tournamentData3 = null;
		obj11 = obj10;
		flag8 = flag7;
		flag29 = (byte)num2 != 0;
		if (obj33 == null)
		{
			goto IL_025e;
		}
		goto IL_068c;
		IL_068c:
		infoIcons.Initialize(syncedRoom.<Info>k__BackingField);
		UnityEngine.Object obj34 = prizeUi;
		object obj35 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v48+E4]");
		bool flag35 = (nint)0 == 0;
		object obj36 = !flag35;
		obj10 = obj11;
		flag7 = flag8;
		num2 = (flag29 ? 1 : 0);
		tournamentData3 = syncedRoom.<Info>k__BackingField;
		UnityEngine.Object obj37 = prizeUi;
		if (obj36 != null)
		{
			goto IL_02b7;
		}
		goto IL_0711;
		IL_025e:
		obj34 = prizeUi;
		obj35 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v48+E4]");
		bool flag36 = (nint)0 == 0;
		obj11 = obj10;
		flag8 = flag7;
		flag29 = (byte)num2 != 0;
		obj37 = prizeUi;
		if (!flag36)
		{
			goto IL_02b7;
		}
		goto IL_0711;
		IL_0711:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag37 = obj37;
		bool flag38 = !flag37;
		obj10 = obj11;
		flag7 = flag8;
		num2 = (flag29 ? 1 : 0);
		TournamentData tournamentData4 = null;
		if (flag38)
		{
			goto IL_02fd;
		}
		goto IL_0763;
		IL_02b7:
		bool flag39 = obj34;
		bool flag40 = !flag39;
		object obj38 = !flag40;
		tournamentData4 = null;
		obj11 = obj10;
		flag8 = flag7;
		if (obj38 == null)
		{
			goto IL_02fd;
		}
		goto IL_0763;
		IL_0763:
		TournamentPrizeUi tournamentPrizeUi = prizeUi;
		nint num6 = (nint)tournamentPrizeUi;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v46 (Il2CppClass<TournamentPrizeUi>)+180]");
		num2 = 0;
		tournamentPrizeUi.Initialize(syncedRoom.<Info>k__BackingField);
		UnityEngine.Object obj39 = feeText;
		object obj40 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v44+E4]");
		bool flag41 = (nint)0 == 0;
		object obj41 = !flag41;
		obj10 = obj11;
		flag7 = flag8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X8_v46 (Il2CppClass<TournamentPrizeUi>)+180]");
		nint num7 = 0;
		tournamentData4 = syncedRoom.<Info>k__BackingField;
		UnityEngine.Object obj42 = feeText;
		if (obj41 != null)
		{
			goto IL_0356;
		}
		goto IL_0815;
		IL_02fd:
		obj39 = feeText;
		obj40 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v44+E4]");
		bool flag42 = (nint)0 == 0;
		obj11 = obj10;
		flag8 = flag7;
		num7 = num2;
		obj42 = feeText;
		if (!flag42)
		{
			goto IL_0356;
		}
		goto IL_0815;
		IL_0815:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag43 = obj42;
		bool flag44 = !flag43;
		obj10 = obj11;
		flag7 = flag8;
		num2 = num7;
		int num8 = 0;
		flag10 = (byte)num7 != 0;
		int num9 = 0;
		if (!flag44)
		{
			goto IL_087c;
		}
		goto IL_09a1;
		IL_0356:
		bool flag45 = obj39;
		bool flag46 = !flag45;
		object obj43 = !flag46;
		num8 = 0;
		if (obj43 != null)
		{
			goto IL_087c;
		}
		obj11 = obj10;
		flag8 = flag7;
		flag10 = (byte)num2 != 0;
		num9 = 0;
		goto IL_09a1;
		IL_087c:
		TournamentJoinCostUi tournamentJoinCostUi = feeText;
		object obj44 = typeof(Queue<string>) + 848;
		object obj45 = obj44;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X0_v73+E4]");
		bool flag47 = (nint)0 == 0;
		object obj46 = !flag47;
		if (obj46 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj47 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int tournamentJoiningDiscount = SFSKammelnaUserExtensions.GetTournamentJoiningDiscount(localUser);
		int num10 = <Info>k__BackingField.<JoiningPrice>k__BackingField - tournamentJoiningDiscount;
		if (num10 >= 1)
		{
			tournamentJoinCostUi.acesObject.SetActive(value: true);
			TextMeshProExtensions.SetPriceText(tournamentJoinCostUi.text, num10, useCommas: true);
			obj11 = 0;
			flag8 = false;
			flag10 = true;
			num9 = num10;
			goto IL_09a1;
		}
		tournamentJoinCostUi.acesObject.SetActive(value: false);
		UnityEngine.Object obj48 = clusterSizeText;
		object obj49 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X8_v23+E4]");
		bool flag48 = (nint)0 == 0;
		object obj50 = !flag48;
		obj11 = obj10;
		flag8 = flag7;
		flag10 = false;
		bool flag49 = false;
		bool flag50 = false;
		UnityEngine.Object obj51 = clusterSizeText;
		if (obj50 != null)
		{
			goto IL_0a02;
		}
		goto IL_0ccb;
		IL_10e4:
		int numberOfRounds = TournamentMath.GetNumberOfRounds(<Info>k__BackingField.<Size>k__BackingField);
		LocalizableText tournamentRoundName = TournamentUtil.GetTournamentRoundName(syncedRoom.<CurrentRound>k__BackingField, numberOfRounds);
		TextMeshProExtensions.Localize(currentStageText, tournamentRoundName);
		TournamentSprites tournamentSprites = this.tournamentSprites;
		goto IL_112f;
		IL_0bd7:
		bool flag51 = obj13;
		bool flag52 = !flag51;
		object obj52 = !flag52;
		if (obj52 == null)
		{
			goto IL_0c08;
		}
		goto IL_10e4;
		IL_112f:
		IThemeColorProfile theme = tournamentSprites.GetTheme(syncedRoom.<Info>k__BackingField);
		themeProvider.UpdateTheme(theme);
		return;
		IL_0c08:
		tournamentSprites = this.tournamentSprites;
		bool flag53 = (object)this.tournamentSprites == null;
		object obj53 = !flag53;
		if (obj53 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_112f;
		IL_10af:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!obj15)
		{
			goto IL_0c08;
		}
		goto IL_10e4;
		IL_09a1:
		obj48 = clusterSizeText;
		obj49 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X8_v23+E4]");
		bool flag54 = (nint)0 == 0;
		obj10 = obj11;
		flag7 = flag8;
		flag49 = flag10;
		flag50 = (byte)num9 != 0;
		obj51 = clusterSizeText;
		if (!flag54)
		{
			goto IL_0a02;
		}
		goto IL_0ccb;
		IL_0ccb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag55 = obj51;
		bool flag56 = !flag55;
		obj11 = obj10;
		flag8 = flag7;
		flag10 = flag49;
		string text = null;
		if (flag56)
		{
			goto IL_0a48;
		}
		goto IL_0d1d;
		IL_0a02:
		bool flag57 = obj48;
		bool flag58 = !flag57;
		object obj54 = !flag58;
		text = null;
		obj10 = obj11;
		flag7 = flag8;
		if (obj54 == null)
		{
			goto IL_0a48;
		}
		goto IL_0d1d;
		IL_0d1d:
		TextMeshProUGUI textMeshProUGUI = clusterSizeText;
		int num11 = default(int);
		string text2 = num11.ToString();
		nint num12 = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v21 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		flag10 = false;
		textMeshProUGUI.text = text2;
		UnityEngine.Object obj55 = clusterSize;
		object obj56 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X8_v18+E4]");
		bool flag59 = (nint)0 == 0;
		object obj57 = !flag59;
		obj11 = obj10;
		flag8 = flag7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v21 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		bool flag60 = false;
		text = text2;
		UnityEngine.Object obj58 = clusterSize;
		if (obj57 != null)
		{
			goto IL_0aa1;
		}
		goto IL_0dd3;
		IL_0a48:
		obj55 = clusterSize;
		obj56 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v799 @ X8_v18+E4]");
		bool flag61 = (nint)0 == 0;
		obj10 = obj11;
		flag7 = flag8;
		flag60 = flag10;
		obj58 = clusterSize;
		if (!flag61)
		{
			goto IL_0aa1;
		}
		goto IL_0dd3;
		IL_0dd3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag62 = obj58;
		bool flag63 = !flag62;
		obj11 = obj10;
		flag8 = flag7;
		flag10 = flag60;
		bool flag64 = false;
		if (flag63)
		{
			goto IL_0aeb;
		}
		goto IL_0e29;
		IL_0aa1:
		bool flag65 = obj55;
		bool flag66 = !flag65;
		object obj59 = !flag66;
		flag64 = false;
		obj10 = obj11;
		flag7 = flag8;
		if (obj59 == null)
		{
			goto IL_0aeb;
		}
		goto IL_0e29;
		IL_0e29:
		object obj60 = (object?)<Info>k__BackingField.<ClusterCapacity>k__BackingField >> 32;
		bool flag67 = (nint)obj60 < 0;
		bool flag68 = obj60 == null;
		object obj61 = obj60 ^ obj60;
		object obj62 = obj60 & obj61;
		bool flag69 = (nint)obj62 < 0;
		bool flag70 = flag67 == flag69;
		object obj63 = !flag68;
		object obj64 = flag70 & obj63;
		flag64 = (byte)(obj64 & (object?)<Info>k__BackingField.<ClusterCapacity>k__BackingField) != 0;
		clusterSize.SetActive(flag64);
		obj8 = participants;
		obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v903 @ X8_v14+E4]");
		bool flag71 = (nint)0 == 0;
		object obj65 = !flag71;
		obj11 = obj10;
		flag8 = flag7;
		flag10 = false;
		flag9 = false;
		obj12 = participants;
		if (obj65 != null)
		{
			goto IL_0b44;
		}
		goto IL_0f38;
	}

	public void Initialize(Room room)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003b: Expected O, but got I
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_009d: Expected I, but got O
		//IL_00e0: Expected I, but got O
		//IL_0123: Expected I, but got O
		//IL_0166: Expected I, but got O
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_0240: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1488;
		object varName = "https://www.kammelna.com/Home/Terms" + 136;
		object obj3 = (nint)0 + (nint)1480;
		object varName2 = "startPosition" + 104;
		object varName3 = "com.unity.services.authentication.profile" + 1816;
		tournamentRoom = room;
		object obj4 = this + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(room);
		_oldStatus = tournamentStatus;
		ResetUI();
		GameObject go = base.gameObject;
		VariableBinderExtensions.Unbind(go);
		GameObject go2 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		VariableBinderExtensions.Bind(go2, tournamentRoom, (string)varName, action);
		GameObject go3 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		VariableBinderExtensions.Bind(go3, tournamentRoom, (string)varName2, action2);
		GameObject go4 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj2);
		VariableBinderExtensions.Bind(go4, tournamentRoom, (string)varName3, action3);
		GameObject go5 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj2);
		object varName4 = "alignContent" + 3024;
		VariableBinderExtensions.Bind(go5, tournamentRoom, (string)varName4, action4);
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v29+E4]");
		if ((nint)0 != 0)
		{
			if (!participants)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = participants;
			bool flag2 = !flag;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				return;
			}
		}
		participants.Bind(tournamentRoom);
	}

	private void ResetUI()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0413: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_04c9: Expected O, but got I4
		//IL_04d2: Expected O, but got I4
		//IL_04db: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		//IL_0598: Expected O, but got I4
		//IL_05a1: Expected O, but got I4
		//IL_05aa: Expected O, but got I4
		//IL_01ba: Expected O, but got I4
		//IL_0655: Expected O, but got I4
		//IL_065e: Expected O, but got I4
		//IL_0667: Expected O, but got I4
		//IL_023d: Expected O, but got I4
		//IL_0724: Expected O, but got I4
		//IL_072d: Expected O, but got I4
		//IL_0736: Expected O, but got I4
		//IL_02c0: Expected O, but got I4
		//IL_07f3: Expected O, but got I4
		//IL_07fc: Expected O, but got I4
		//IL_0805: Expected O, but got I4
		//IL_0343: Expected O, but got I4
		//IL_034c: Expected O, but got I4
		//IL_035d: Expected O, but got I4
		//IL_08b4: Expected O, but got I4
		//IL_085e: Expected O, but got I4
		//IL_0867: Expected O, but got I4
		//IL_03cf: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D6D]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v58+E4]");
			bool flag = (nint)0 == 0;
			obj5 = rank;
			obj6 = rank;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v58+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = rank;
			obj6 = rank;
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
		goto IL_0473;
		IL_0922:
		TournamentSprites tournamentSprites = this.tournamentSprites;
		themeProvider.UpdateTheme(tournamentSprites.kammelnaColors);
		return;
		IL_0912:
		sportTeamColorizer.resetUI();
		goto IL_0922;
		IL_03ac:
		UnityEngine.Object obj8;
		bool flag6 = obj8;
		bool flag7 = !flag6;
		object obj9 = !flag7;
		if (obj9 != null)
		{
			goto IL_0912;
		}
		goto IL_0922;
		IL_0091:
		bool flag8 = obj5;
		bool flag9 = !flag8;
		object obj10 = !flag9;
		flag5 = false;
		if (obj10 == null)
		{
			goto IL_00cb;
		}
		goto IL_0473;
		IL_0473:
		GameObject gameObject = rank.gameObject;
		gameObject.SetActive(value: true);
		UnityEngine.Object obj11 = title;
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v50+E4]");
		bool flag10 = (nint)0 == 0;
		object obj13 = !flag10;
		object obj14 = 0;
		object obj15 = 0;
		flag5 = true;
		UnityEngine.Object obj16 = title;
		if (obj13 != null)
		{
			goto IL_0114;
		}
		goto IL_04fc;
		IL_00cb:
		obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X0_v50+E4]");
		bool flag11 = (nint)0 == 0;
		obj11 = title;
		obj15 = obj14;
		obj16 = title;
		if (!flag11)
		{
			goto IL_0114;
		}
		goto IL_04fc;
		IL_04fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag12 = obj16;
		bool flag13 = !flag12;
		obj14 = obj15;
		bool flag14 = false;
		if (flag13)
		{
			goto IL_014e;
		}
		goto IL_0542;
		IL_0114:
		bool flag15 = obj11;
		bool flag16 = !flag15;
		object obj17 = !flag16;
		flag14 = false;
		if (obj17 == null)
		{
			goto IL_014e;
		}
		goto IL_0542;
		IL_0542:
		GameObject gameObject2 = title.gameObject;
		gameObject2.SetActive(value: false);
		UnityEngine.Object obj18 = tournamentMessageButton;
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v18+E4]");
		bool flag17 = (nint)0 == 0;
		object obj20 = !flag17;
		obj14 = 0;
		object obj21 = 0;
		flag14 = false;
		UnityEngine.Object obj22 = tournamentMessageButton;
		if (obj20 != null)
		{
			goto IL_0197;
		}
		goto IL_05cb;
		IL_014e:
		obj18 = tournamentMessageButton;
		obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v18+E4]");
		bool flag18 = (nint)0 == 0;
		obj21 = obj14;
		obj22 = tournamentMessageButton;
		if (!flag18)
		{
			goto IL_0197;
		}
		goto IL_05cb;
		IL_05cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag19 = obj22;
		bool flag20 = !flag19;
		obj14 = obj21;
		bool flag21 = false;
		if (flag20)
		{
			goto IL_01d1;
		}
		goto IL_0611;
		IL_0197:
		bool flag22 = obj18;
		bool flag23 = !flag22;
		object obj23 = !flag23;
		flag21 = false;
		if (obj23 == null)
		{
			goto IL_01d1;
		}
		goto IL_0611;
		IL_0611:
		tournamentMessageButton.SetActive(value: false);
		UnityEngine.Object obj24 = tournamentMessage;
		object obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v15+E4]");
		bool flag24 = (nint)0 == 0;
		object obj26 = !flag24;
		obj14 = 0;
		object obj27 = 0;
		flag21 = false;
		UnityEngine.Object obj28 = tournamentMessage;
		if (obj26 != null)
		{
			goto IL_021a;
		}
		goto IL_0688;
		IL_01d1:
		obj24 = tournamentMessage;
		obj25 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v280 @ X8_v15+E4]");
		bool flag25 = (nint)0 == 0;
		obj27 = obj14;
		obj28 = tournamentMessage;
		if (!flag25)
		{
			goto IL_021a;
		}
		goto IL_0688;
		IL_0688:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag26 = obj28;
		bool flag27 = !flag26;
		obj14 = obj27;
		bool flag28 = false;
		if (flag27)
		{
			goto IL_0254;
		}
		goto IL_06ce;
		IL_021a:
		bool flag29 = obj24;
		bool flag30 = !flag29;
		object obj29 = !flag30;
		flag28 = false;
		if (obj29 == null)
		{
			goto IL_0254;
		}
		goto IL_06ce;
		IL_06ce:
		GameObject gameObject3 = tournamentMessage.gameObject;
		gameObject3.SetActive(value: false);
		UnityEngine.Object obj30 = requirementInfo;
		object obj31 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v12+E4]");
		bool flag31 = (nint)0 == 0;
		object obj32 = !flag31;
		obj14 = 0;
		object obj33 = 0;
		flag28 = false;
		UnityEngine.Object obj34 = requirementInfo;
		if (obj32 != null)
		{
			goto IL_029d;
		}
		goto IL_0757;
		IL_0254:
		obj30 = requirementInfo;
		obj31 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v12+E4]");
		bool flag32 = (nint)0 == 0;
		obj33 = obj14;
		obj34 = requirementInfo;
		if (!flag32)
		{
			goto IL_029d;
		}
		goto IL_0757;
		IL_0757:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag33 = obj34;
		bool flag34 = !flag33;
		obj14 = obj33;
		bool flag35 = false;
		if (flag34)
		{
			goto IL_02d7;
		}
		goto IL_079d;
		IL_029d:
		bool flag36 = obj30;
		bool flag37 = !flag36;
		object obj35 = !flag37;
		flag35 = false;
		if (obj35 == null)
		{
			goto IL_02d7;
		}
		goto IL_079d;
		IL_079d:
		GameObject gameObject4 = requirementInfo.gameObject;
		gameObject4.SetActive(value: false);
		UnityEngine.Object obj36 = cardRoomThemeSetter;
		object obj37 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v9+E4]");
		bool flag38 = (nint)0 == 0;
		object obj38 = !flag38;
		obj14 = 0;
		object obj39 = 0;
		flag35 = false;
		UnityEngine.Object obj40 = cardRoomThemeSetter;
		if (obj38 != null)
		{
			goto IL_0320;
		}
		goto IL_0826;
		IL_02d7:
		obj36 = cardRoomThemeSetter;
		obj37 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v370 @ X8_v9+E4]");
		bool flag39 = (nint)0 == 0;
		obj39 = obj14;
		obj40 = cardRoomThemeSetter;
		if (!flag39)
		{
			goto IL_0320;
		}
		goto IL_0826;
		IL_0826:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag40 = obj40;
		bool flag41 = !flag40;
		obj14 = obj39;
		object obj41 = 0;
		object obj42 = 0;
		if (flag41)
		{
			goto IL_036b;
		}
		goto IL_0875;
		IL_0320:
		bool flag42 = obj36;
		bool flag43 = !flag42;
		object obj43 = !flag43;
		obj41 = 0;
		obj39 = obj14;
		obj42 = 0;
		if (obj43 == null)
		{
			goto IL_036b;
		}
		goto IL_0875;
		IL_0875:
		cardRoomThemeSetter.resetUI();
		obj8 = sportTeamColorizer;
		object obj44 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v6+E4]");
		bool flag44 = (nint)0 == 0;
		object obj45 = !flag44;
		obj14 = obj39;
		obj41 = obj42;
		UnityEngine.Object obj46 = sportTeamColorizer;
		if (obj45 != null)
		{
			goto IL_03ac;
		}
		goto IL_08dc;
		IL_036b:
		obj8 = sportTeamColorizer;
		obj44 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v6+E4]");
		bool flag45 = (nint)0 == 0;
		obj46 = sportTeamColorizer;
		if (!flag45)
		{
			goto IL_03ac;
		}
		goto IL_08dc;
		IL_08dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj46)
		{
			goto IL_0912;
		}
		goto IL_0922;
	}

	public void JoinRoom()
	{
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_029a: Expected O, but got I4
		//IL_002e: Expected O, but got I4
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_0310: Expected O, but got I4
		//IL_014c: Expected O, but got I
		//IL_015c: Expected O, but got I
		//IL_0352: Expected O, but got I
		//IL_0362: Expected O, but got I
		//IL_0384: Expected O, but got I4
		//IL_03c4: Expected O, but got I4
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Expected O, but got Unknown
		//IL_0598: Expected O, but got I
		//IL_05a9: Expected I, but got O
		//IL_05c7: Expected O, but got I
		//IL_048c: Expected O, but got I
		//IL_049c: Expected O, but got I
		//IL_04be: Expected O, but got I4
		//IL_0423: Expected O, but got I4
		//IL_043c: Expected O, but got I4
		//IL_0444: Expected I, but got O
		//IL_03f4: Expected O, but got I
		//IL_01ee: Expected O, but got I
		//IL_01fe: Expected O, but got I
		//IL_0220: Expected O, but got I4
		//IL_04fe: Expected O, but got I4
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected O, but got Unknown
		//IL_0608: Expected O, but got I
		//IL_0619: Expected I, but got O
		//IL_0637: Expected O, but got I
		//IL_023f: Expected O, but got I4
		//IL_0247: Expected I, but got O
		//IL_052e: Expected O, but got I
		TournamentData tournamentData;
		if (tournamentRoom != null)
		{
			tournamentData = SFSKammelnaRoomExtensions.GetTournamentInfo(tournamentRoom);
			bool flag = tournamentData == null;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_0099;
			}
		}
		else
		{
			TournamentRoomModel tournamentRoomModel = roomModel;
			if (roomModel != null)
			{
				tournamentData = tournamentRoomModel.<Info>k__BackingField;
				if (tournamentRoomModel.<Info>k__BackingField != null)
				{
					goto IL_0099;
				}
			}
		}
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag2 = (nint)0 == 0;
		object obj4 = !flag2;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "Index = {0} position = {1}" + 1736;
		PopupWindow.ShowError((string)message);
		return;
		IL_04dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj5 = !flag3;
		object obj7;
		object obj8;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v19+B8]");
			obj8 = 0;
		}
		object obj9 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)384;
		Action action = default(Action);
		action..ctor(obj8, (IntPtr)obj10);
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v18+B8]");
		object obj12 = (nint)0 + (nint)16;
		obj12 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Action fallback = action;
		Func<bool> func;
		Func<bool> cancelCondition = func;
		goto IL_0533;
		IL_0191:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v13+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = default(object);
		object obj13 = obj14;
		IntPtr intPtr = default(IntPtr);
		nint num = intPtr;
		Func<bool> func3;
		Func<bool> func2 = func3;
		object obj16;
		object obj15 = obj16;
		Func<bool> func5;
		Func<bool> func4 = func5;
		if (!flag4)
		{
			goto IL_01de;
		}
		goto IL_046a;
		IL_03a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X0_v24+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		object obj19;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj18 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v31+B8]");
			obj19 = 0;
		}
		object obj20 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 2128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = (nint)0 + (nint)376;
		Func<bool> func6 = default(Func<bool>);
		func6..ctor(obj19, (IntPtr)obj21);
		object obj22 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v29+B8]");
		object obj23 = (nint)0 + (nint)8;
		obj23 = func6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj16 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v13+E4]");
		bool flag6 = (nint)0 == 0;
		object obj24 = !flag6;
		func3 = func6;
		func5 = func6;
		obj13 = 0;
		num = (nint)obj21;
		func2 = func6;
		obj15 = obj16;
		func4 = func6;
		if (obj24 != null)
		{
			goto IL_01de;
		}
		goto IL_046a;
		IL_0099:
		object obj25 = typeof(RegisteredWaitHandle) + 3136;
		obj7 = typeof(SkeletonBinary.SkeletonInput) + 3920;
		SFS.JoinTournamentRoom(tournamentData);
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v9+E4]");
		Func<bool> func7;
		if ((nint)0 != 0)
		{
			ScreenManager.AnimateTransitionOut();
			obj16 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v13+E4]");
			bool flag7 = (nint)0 == 0;
			func3 = null;
			func7 = null;
			object obj27 = obj16;
			if (!flag7)
			{
				goto IL_013c;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ScreenManager.AnimateTransitionOut();
			obj16 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v13+E4]");
			bool flag8 = (nint)0 == 0;
			object obj28 = !flag8;
			func3 = null;
			func7 = null;
			object obj27 = obj16;
			if (obj28 != null)
			{
				goto IL_013c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj16 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v13+B8]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v24+8]");
		func5 = (Func<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v24+8]");
		bool flag9 = (nint)0 == 0;
		object obj29 = !flag9;
		func3 = func7;
		object obj30 = obj16;
		if (obj29 != null)
		{
			goto IL_0191;
		}
		goto IL_03a2;
		IL_0533:
		Coroutine coroutine = UIExtensions.SetTimeout(this, 5f, cancelCondition, fallback);
		return;
		IL_01de:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v13+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v13+10]");
		fallback = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v13+10]");
		bool flag10 = (nint)0 == 0;
		object obj31 = !flag10;
		cancelCondition = func5;
		if (obj31 == null)
		{
			obj13 = 0;
			num = (nint)obj21;
			func2 = func3;
			func = func5;
			goto IL_04dc;
		}
		goto IL_0533;
		IL_046a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj16 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v13+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v13+10]");
		fallback = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v13+10]");
		bool flag11 = (nint)0 == 0;
		object obj32 = !flag11;
		func = func4;
		cancelCondition = func4;
		if (obj32 == null)
		{
			goto IL_04dc;
		}
		goto IL_0533;
		IL_013c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v13+B8]");
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v24+8]");
		func5 = (Func<bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X8_v24+8]");
		bool flag12 = (nint)0 == 0;
		func7 = func3;
		obj30 = obj16;
		if (!flag12)
		{
			goto IL_0191;
		}
		goto IL_03a2;
	}

	public void Participate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01d2: Expected O, but got I4
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_0984: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected O, but got Unknown
		//IL_0995: Expected O, but got I
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_011e: Expected O, but got I
		//IL_0244: Expected O, but got I4
		//IL_0629: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected O, but got Unknown
		//IL_02cc: Expected O, but got I4
		//IL_0168: Expected O, but got I4
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected O, but got Unknown
		//IL_02f5: Expected O, but got I
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_034a: Expected O, but got I4
		//IL_0373: Expected O, but got I
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fd: Expected O, but got Unknown
		//IL_0a09: Expected O, but got I
		//IL_0a24: Expected I, but got O
		//IL_0a4b: Expected O, but got I
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected O, but got Unknown
		//IL_06d7: Expected O, but got I4
		//IL_0700: Expected O, but got I
		//IL_046f: Expected O, but got I
		//IL_03e9: Expected O, but got I
		//IL_0408: Expected O, but got I
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0783: Expected O, but got Unknown
		//IL_049d: Expected O, but got I4
		//IL_0434: Expected O, but got I4
		//IL_0a68: Expected O, but got I
		//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a86: Expected O, but got Unknown
		//IL_04bb: Expected O, but got I
		//IL_0afc: Expected O, but got I
		//IL_0b26: Expected O, but got I4
		//IL_0515: Expected O, but got I4
		//IL_0a97: Expected O, but got I
		//IL_05b9: Expected O, but got I
		//IL_05c9: Expected O, but got I
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected O, but got Unknown
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0555: Expected O, but got Unknown
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected O, but got Unknown
		//IL_07d3: Expected O, but got I
		//IL_07e4: Expected I, but got O
		//IL_07f5: Expected O, but got I
		//IL_07fd: Expected I4, but got O
		//IL_082d: Expected O, but got I
		//IL_0887: Expected O, but got I4
		//IL_08fc: Expected O, but got I
		//IL_090c: Expected O, but got I
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c7: Expected O, but got Unknown
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d5: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(tournamentRoom);
		object obj4 = obj2 + 32;
		obj4 = tournamentInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj4;
		bool isLocked;
		object obj13;
		List<object> list = default(List<object>);
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X8_v4+BD]");
			if ((nint)0 == 1)
			{
				object obj6 = typeof(Queue<string>) + 848;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X0_v100+E4]");
				bool flag = (nint)0 == 0;
				object obj8 = !flag;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj9 = (nint)0 + (nint)2200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel = default(SessionModel);
				User localUser = sessionModel.LocalUser;
				int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
				int originalOwnerId = SFSKammelnaRoomExtensions.GetOriginalOwnerId(tournamentRoom);
				object obj10 = intDbId - originalOwnerId;
				bool flag2 = obj10 == null;
				bool flag3 = !flag2;
				TournamentData tournamentData = null;
				isLocked = flag3;
			}
			else
			{
				TournamentData tournamentData = tournamentInfo;
				isLocked = false;
			}
			object obj11 = typeof(List<AdaptivePerformanceScaler>) + 1168;
			object obj12 = (nint)0 + (nint)2536;
			obj13 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			list..ctor();
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				bool flag4 = joinCostUi;
				bool flag5 = !flag4;
				object obj15 = !flag5;
				object obj16 = null;
				if (obj15 != null)
				{
					goto IL_02a2;
				}
				object obj17 = null;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag6 = joinCostUi;
				bool flag7 = !flag6;
				object obj16 = null;
				object obj17 = null;
				if (!flag7)
				{
					goto IL_02a2;
				}
			}
			goto IL_061a;
		}
		object obj18 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X0_v13+E4]");
		bool flag8 = (nint)0 == 0;
		object obj20 = !flag8;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message = "Index = {0} position = {1}" + 1736;
		PopupWindow.ShowError((string)message);
		return;
		IL_02a2:
		object obj21 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X0_v70+E4]");
		bool flag9 = (nint)0 == 0;
		object obj22 = !flag9;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj23 = (nint)0 + (nint)400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9A80");
		object obj24 = obj4;
		object obj25 = typeof(Queue<string>) + 848;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v74+E4]");
		bool flag10 = (nint)0 == 0;
		object obj27 = !flag10;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj28 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		int tournamentJoiningDiscount = SFSKammelnaUserExtensions.GetTournamentJoiningDiscount(localUser2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v56+94]");
		int num = (int)(-tournamentJoiningDiscount);
		Transform transform;
		UnityEngine.Component component = default(UnityEngine.Component);
		if (num >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v73 (UnityEngine.Component)+20]");
			((GameObject)0).SetActive(value: true);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v73 (UnityEngine.Component)+28]");
			TextMeshProExtensions.SetPriceText((TextMeshProUGUI)0, num, useCommas: true);
			transform = component.transform;
			bool flag11 = (object)transform == null;
			object obj29 = !flag11;
			bool flag12 = false;
			bool flag13 = true;
			if (obj29 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v73 (UnityEngine.Component)+20]");
			((GameObject)0).SetActive(value: false);
			transform = component.transform;
			bool flag13 = false;
		}
		transform.localScale = (Vector3)0;
		GameObject gameObject = component.gameObject;
		object obj30 = (nint)0 + (nint)2544;
		object obj31 = obj30;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag14 = list._size < items.Length;
		object obj32 = !flag14;
		if (obj32 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj33 = items + list._size;
			object obj34 = obj33 + 32;
			obj34 = gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			double num2 = 1.0;
			double num3 = 1.5;
			double num4 = 1.5;
			object obj17 = gameObject;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v64+20]");
			object obj35 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v65+C0]");
			object obj36 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v527 @ X8_v66+70]");
			bool flag13 = false;
			list.AddWithResize((object)gameObject);
			double num2 = 1.0;
			double num3 = 1.5;
			double num4 = 1.5;
			object obj17 = gameObject;
		}
		goto IL_061a;
		IL_09e9:
		object obj37 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj38 = (nint)0 + (nint)408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj38);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v3 (System.Object)+20]");
		bool confirmButton;
		TournamentPopupUtil.ShowParticipationPopup((TournamentData)0, action, (List<GameObject>)(object)list, confirmButton, isLocked, passwordIcon);
		return;
		IL_061a:
		object obj39 = typeof(List<Tween>) + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<Vector2> list2 = default(List<Vector2>);
		list2..ctor();
		object obj40 = obj2 + 16;
		obj40 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag15 = SFSKammelnaRoomExtensions.HasCaptcha(tournamentRoom);
		bool flag16 = !flag15;
		object obj41 = null;
		if (!flag16)
		{
			object obj42 = typeof(Queue<string>) + 848;
			object obj43 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X0_v34+E4]");
			bool flag17 = (nint)0 == 0;
			object obj44 = !flag17;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj45 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel3 = default(SessionModel);
			User localUser3 = sessionModel3.LocalUser;
			int intDbId2 = SFSKammelnaUserExtensions.GetIntDbId(localUser3);
			int originalOwnerId2 = SFSKammelnaRoomExtensions.GetOriginalOwnerId(tournamentRoom);
			bool flag18 = intDbId2 != originalOwnerId2;
			obj41 = null;
			if (flag18)
			{
				object obj46 = typeof(UsageHint) + 816;
				object obj47 = obj46;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v660 @ X8_v29+B8]");
				object obj48 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				object obj49 = typeof(System.Buffers.Text.ParserHelpers) + 2696;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v30+18]");
				object obj50 = default(object);
				double num4 = 0.0 * (double)obj50;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X8_v30+20]");
				double num2 = 0.0 * 1176256512.0;
				object obj51 = obj49;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v684 @ X8_v33+B8]");
				object obj52 = 0;
				object obj53 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v690 @ X0_v44+E4]");
				bool flag19 = (nint)0 == 0;
				object obj54 = !flag19;
				if (obj54 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj55 = (nint)0 + (nint)1032;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9ED4");
				List<Vector2> captchaPath = SFSKammelnaRoomExtensions.GetCaptchaPath(tournamentRoom);
				SwipeCaptcha swipeCaptcha = default(SwipeCaptcha);
				swipeCaptcha.InitPath(captchaPath);
				object obj56 = typeof(TypeConverter<ushort, char>) + 336;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj57 = (nint)0 + (nint)392;
				UnityAction<object> unityAction = default(UnityAction<object>);
				unityAction..ctor(obj2, (IntPtr)obj57);
				object obj58 = (nint)0 + (nint)768;
				bool flag13 = (byte)(int)obj58 != 0;
				((UnityEvent<object>)(object)swipeCaptcha.OnSwipeFinish).AddListener(unityAction);
				GameObject gameObject2 = swipeCaptcha.gameObject;
				object obj59 = (nint)0 + (nint)2544;
				object obj60 = obj59;
				int version2 = list._version + 1;
				list._version = version2;
				object[] items2 = list._items;
				bool flag20 = list._size < items2.Length;
				object obj61 = !flag20;
				if (obj61 == null)
				{
					int size2 = list._size + 1;
					list._size = size2;
					object obj62 = items2 + list._size;
					object obj63 = obj62 + 32;
					obj63 = gameObject2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v46+20]");
					object obj64 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v743 @ X8_v48+C0]");
					object obj65 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v744 @ X8_v49+70]");
					flag13 = false;
					list.AddWithResize((object)gameObject2);
				}
				double num5 = default(double);
				double num3 = num5;
				bool flag12 = false;
				confirmButton = false;
				obj41 = gameObject2;
				goto IL_09e9;
			}
		}
		confirmButton = true;
		goto IL_09e9;
	}

	public void Forfeit()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01d5: Expected O, but got I4
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a7: Expected O, but got I
		//IL_00d1: Expected O, but got I4
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0137: Expected O, but got I
		//IL_0170: Expected I, but got O
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_024a: Expected O, but got I4
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_0280: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(tournamentRoom);
		object obj4 = obj2 + 16;
		obj4 = tournamentInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj4 != null)
		{
			object obj5 = typeof(Queue<string>) + 848;
			object obj6 = (nint)0 + (nint)2200;
			object obj7 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			object obj9 = obj4;
			object obj10 = typeof(SqlSingle[]) + 2376;
			object obj11 = (nint)0 + (nint)424;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v13+60]");
			TicketRecord tournamentTickets = SFSKammelnaUserExtensions.GetTournamentTickets(localUser, TournamentType.Public);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj11);
			if (tournamentTickets != null)
			{
				TournamentPopupUtil.ShowTicketsForfeitWarning(action);
				return;
			}
			object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v25+E4]");
			bool flag2 = (nint)0 == 0;
			object obj14 = !flag2;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object msgTitle = "Complete" + 256;
			object msgBody = "Added Tournament Prizes And Features" + 2208;
			PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action);
		}
		else
		{
			object obj15 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj16 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object message = "Index = {0} position = {1}" + 1736;
			PopupWindow.ShowError((string)message);
		}
	}

	private void OnStatusChanged()
	{
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(tournamentRoom);
		if (tournamentStatus != _oldStatus)
		{
			eventsChannel.TriggerTournamentsChanged();
		}
		_oldStatus = tournamentStatus;
		PopulateVisualData();
	}

	private void PopulateVisualData()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_011a: Expected O, but got I4
		//IL_020f: Expected I, but got O
		//IL_0260: Expected O, but got I4
		//IL_0199: Expected O, but got I4
		//IL_0675: Expected O, but got I4
		//IL_073b: Expected O, but got I4
		//IL_035e: Expected O, but got I4
		//IL_0b30: Expected O, but got I4
		//IL_0b39: Expected O, but got I4
		//IL_0b54: Expected O, but got I4
		//IL_07ce: Expected O, but got I4
		//IL_0429: Expected O, but got I4
		//IL_0c46: Expected O, but got I4
		//IL_0c4f: Expected O, but got I4
		//IL_0c6a: Expected O, but got I4
		//IL_054d: Expected O, but got I4
		//IL_0861: Expected O, but got I4
		//IL_04a4: Expected O, but got I4
		//IL_0900: Expected O, but got I4
		//IL_0d58: Expected O, but got I4
		//IL_05fa: Expected I, but got O
		//IL_0964: Expected O, but got I4
		//IL_0e3f: Expected O, but got I4
		//IL_0e59: Expected I4, but got O
		//IL_099f: Expected O, but got I4
		//IL_09bc: Expected O, but got I4
		//IL_0eb0: Expected I4, but got O
		//IL_0f0e: Expected O, but got I4
		//IL_0f26: Expected I4, but got O
		//IL_0a0b: Expected O, but got I4
		//IL_0a46: Expected O, but got I4
		//IL_0a4e: Expected O, but got I4
		//IL_0f9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa0: Expected O, but got Unknown
		//IL_0fbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc2: Expected O, but got Unknown
		//IL_0a74: Expected O, but got I4
		//IL_1201: Expected O, but got I4
		//IL_1100: Expected O, but got I4
		//IL_1022: Expected O, but got I4
		//IL_12d8: Expected O, but got I4
		//IL_119f: Expected O, but got I4
		//IL_1491: Expected O, but got I4
		//IL_1431: Expected O, but got I4
		//IL_14cd: Expected O, but got I4
		//IL_1451: Expected O, but got I4
		//IL_15f0: Expected O, but got I4
		//IL_14ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ef: Expected O, but got Unknown
		//IL_1505: Expected O, but got I
		//IL_150d: Expected I, but got O
		//IL_151e: Expected I, but got O
		//IL_1532: Unknown result type (might be due to invalid IL or missing references)
		//IL_1537: Expected O, but got Unknown
		//IL_1561: Expected O, but got I4
		//IL_1599: Expected O, but got I4
		//IL_1709: Expected O, but got I4
		//IL_17ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b2: Expected O, but got Unknown
		//IL_17dc: Expected O, but got I4
		//IL_1940: Expected O, but got I4
		//IL_1805: Expected O, but got I
		//IL_1ccf: Expected I, but got O
		//IL_1d20: Expected O, but got I4
		//IL_1d89: Expected O, but got I4
		//IL_1d97: Expected O, but got I4
		//IL_19d8: Expected O, but got I4
		//IL_19e1: Expected O, but got I4
		//IL_19ff: Expected O, but got I4
		//IL_1c1b: Expected O, but got I4
		//IL_1a4e: Expected I4, but got O
		//IL_189d: Expected O, but got I4
		//IL_1dfe: Expected O, but got I4
		//IL_1e17: Expected O, but got I4
		//IL_1e78: Expected O, but got I4
		//IL_1a8a: Expected O, but got I4
		//IL_1a93: Expected O, but got I4
		//IL_1aff: Expected I4, but got O
		//IL_1b3a: Expected O, but got I4
		//IL_1f0a: Expected O, but got I
		//IL_1ed1: Expected O, but got I4
		//IL_1eda: Expected O, but got I4
		//IL_1f18: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f1d: Expected I4, but got Unknown
		//IL_1f60: Expected O, but got I4
		//IL_1f79: Expected O, but got I4
		//IL_1f82: Expected O, but got I4
		//IL_1bc1: Expected O, but got I4
		//IL_2017: Expected I, but got O
		//IL_2027: Expected O, but got I
		//IL_2068: Expected O, but got I4
		//IL_20f0: Expected O, but got I
		//IL_2150: Expected O, but got I4
		//IL_2158: Unknown result type (might be due to invalid IL or missing references)
		//IL_215d: Expected O, but got Unknown
		//IL_216d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2172: Expected I4, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (!SFSKammelnaRoomExtensions.IsTournamentHub(tournamentRoom))
		{
			return;
		}
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(tournamentRoom);
		object obj4 = obj2 + 16;
		obj4 = tournamentInfo;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj4 == null)
		{
			return;
		}
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v599 @ X0_v16+E4]");
		TournamentData tournamentData;
		if ((nint)0 != 0)
		{
			bool flag = graphic;
			bool flag2 = !flag;
			object obj7 = !flag2;
			tournamentData = null;
			if (obj7 == null)
			{
				goto IL_012d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = graphic;
			bool flag4 = !flag3;
			tournamentData = null;
			if (flag4)
			{
				goto IL_012d;
			}
		}
		TournamentGraphic tournamentGraphic = graphic;
		tournamentData = (TournamentData)obj4;
		nint num = (nint)tournamentGraphic;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v126 (Il2CppClass<TournamentGraphic>)+180]");
		bool flag5 = false;
		tournamentGraphic.Initialize((TournamentData)obj4);
		UnityEngine.Object obj8 = nameText;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X0_v287+E4]");
		bool flag6 = (nint)0 == 0;
		object obj10 = !flag6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X8_v126 (Il2CppClass<TournamentGraphic>)+180]");
		bool flag7 = false;
		UnityEngine.Object obj11 = nameText;
		if (obj10 != null)
		{
			goto IL_0176;
		}
		goto IL_0288;
		IL_13b8:
		IThemeColorProfile theme = tournamentSprites.GetTheme((TournamentData)obj4);
		themeProvider.UpdateTheme(theme);
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1241 @ X0_v29+E4]");
		nint num2;
		object obj14;
		if ((nint)0 != 0)
		{
			bool flag8 = sportTeamColorizer;
			bool flag9 = !flag8;
			object obj13 = !flag9;
			if (obj13 != null)
			{
				goto IL_149f;
			}
			num2 = 0;
			obj14 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag10 = sportTeamColorizer;
			bool flag11 = !flag10;
			num2 = 0;
			obj14 = 0;
			if (!flag11)
			{
				goto IL_149f;
			}
		}
		goto IL_159e;
		IL_1963:
		object obj15 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ X0_v63+E4]");
		bool flag12 = (nint)0 == 0;
		UnityEngine.Object obj16 = visibilityIndicator;
		object obj18 = default(object);
		object obj17 = obj18;
		bool flag14 = default(bool);
		bool flag13 = flag14;
		UnityEngine.Object obj19 = visibilityIndicator;
		if (!flag12)
		{
			goto IL_19b4;
		}
		goto IL_1d48;
		IL_19b4:
		bool flag15 = obj16 != null;
		bool flag16 = !flag15;
		object obj20 = !flag16;
		object obj21 = 0;
		UnityEngine.Object obj22 = null;
		obj17 = obj18;
		flag13 = flag14;
		TournamentStrip tournamentStrip = (TournamentStrip)flag15;
		if (obj20 == null)
		{
			goto IL_1a0d;
		}
		goto IL_1da5;
		IL_149f:
		SportTeamsCelebrationTournamentAddon tournamentAddonsSportTeamsCelebration = ((TournamentData)obj4).TournamentAddonsSportTeamsCelebration;
		bool flag17 = tournamentAddonsSportTeamsCelebration == null;
		num2 = 0;
		obj14 = 0;
		if (!flag17)
		{
			object obj23 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj24 = (nint)0 + (nint)432;
			num2 = (nint)obj24;
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj24);
			object obj25 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1176;
			object obj26 = obj25;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1303 @ X0_v132+E4]");
			bool flag18 = (nint)0 == 0;
			object obj27 = !flag18;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			SportTeamsUtil.CallWhenReady(action);
			flag14 = false;
			obj14 = 0;
		}
		goto IL_159e;
		IL_1cb0:
		TournamentPrizeUi tournamentPrizeUi = prizeUi;
		TournamentData tournamentData2 = (TournamentData)obj4;
		nint num3 = (nint)tournamentPrizeUi;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1483 @ X8_v37 (Il2CppClass<TournamentPrizeUi>)+180]");
		bool flag19 = false;
		tournamentPrizeUi.Initialize((TournamentData)obj4);
		obj16 = visibilityIndicator;
		obj15 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1478 @ X0_v63+E4]");
		bool flag20 = (nint)0 == 0;
		object obj28 = !flag20;
		obj18 = obj17;
		flag14 = flag13;
		obj19 = visibilityIndicator;
		if (obj28 != null)
		{
			goto IL_19b4;
		}
		goto IL_1d48;
		IL_012d:
		obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X0_v287+E4]");
		bool flag21 = (nint)0 == 0;
		obj8 = nameText;
		flag7 = flag5;
		obj11 = nameText;
		if (!flag21)
		{
			goto IL_0176;
		}
		goto IL_0288;
		IL_0288:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag22 = obj11;
		bool flag23 = !flag22;
		flag5 = flag7;
		if (!flag23)
		{
			goto IL_02c5;
		}
		goto IL_02e1;
		IL_0176:
		bool flag24 = obj8;
		bool flag25 = !flag24;
		object obj29 = !flag25;
		if (obj29 != null)
		{
			goto IL_02c5;
		}
		flag7 = flag5;
		goto IL_02e1;
		IL_02c5:
		nameText.Initialize((TournamentData)obj4);
		flag7 = flag5;
		goto IL_02e1;
		IL_1a0d:
		object obj30 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1566 @ X0_v55+E4]");
		bool flag26 = (nint)0 == 0;
		UnityEngine.Object obj31 = engraving;
		obj17 = obj18;
		flag13 = flag14;
		bool flag27 = (byte)(int)obj22 != 0;
		UnityEngine.Object obj32 = engraving;
		if (!flag26)
		{
			goto IL_1a66;
		}
		goto IL_1e37;
		IL_02e1:
		MessageTournamentAddon tournamentAddonsMessage = ((TournamentData)obj4).TournamentAddonsMessage;
		bool flag30;
		if (tournamentAddonsMessage != null)
		{
			object obj33 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X8_v115+E4]");
			if ((nint)0 != 0)
			{
				bool flag28 = this.tournamentMessage != null;
				bool flag29 = !flag28;
				object obj34 = !flag29;
				flag30 = false;
				UnityEngine.Object obj35 = null;
				if (obj34 != null)
				{
					goto IL_03d7;
				}
				flag7 = false;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag31 = this.tournamentMessage != null;
				bool flag32 = !flag31;
				flag30 = false;
				UnityEngine.Object obj35 = null;
				flag7 = false;
				if (!flag32)
				{
					goto IL_03d7;
				}
			}
		}
		goto IL_061c;
		IL_1da5:
		bool flag33 = tournamentStrip.IsTournamentHidden((TournamentData)obj4);
		visibilityIndicator.SetActive(flag33);
		obj31 = engraving;
		obj30 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1566 @ X0_v55+E4]");
		bool flag34 = (nint)0 == 0;
		object obj36 = !flag34;
		obj18 = obj17;
		flag14 = flag13;
		obj21 = 0;
		flag27 = flag33;
		obj32 = engraving;
		if (obj36 != null)
		{
			goto IL_1a66;
		}
		goto IL_1e37;
		IL_159e:
		object obj37 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1269 @ X0_v31+E4]");
		int num4;
		if ((nint)0 != 0)
		{
			bool flag35 = cardRoomThemeSetter;
			bool flag36 = !flag35;
			object obj38 = !flag36;
			if (obj38 != null)
			{
				goto IL_164c;
			}
			num4 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag37 = cardRoomThemeSetter;
			bool flag38 = !flag37;
			num4 = 0;
			if (!flag38)
			{
				goto IL_164c;
			}
		}
		goto IL_16b7;
		IL_1d48:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag39 = obj19 != null;
		bool flag40 = !flag39;
		obj18 = obj17;
		flag14 = flag13;
		obj21 = 0;
		obj22 = null;
		tournamentStrip = (TournamentStrip)flag39;
		if (flag40)
		{
			goto IL_1a0d;
		}
		goto IL_1da5;
		IL_03d7:
		object obj39 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v116+E4]");
		bool flag43;
		if ((nint)0 != 0)
		{
			bool flag41 = messageIcon;
			bool flag42 = !flag41;
			object obj40 = !flag42;
			flag43 = false;
			if (obj40 == null)
			{
				goto IL_0440;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag44 = messageIcon;
			bool flag45 = !flag44;
			flag43 = false;
			if (flag45)
			{
				goto IL_0440;
			}
		}
		GameObject gameObject = messageIcon.gameObject;
		gameObject.SetActive(value: true);
		UnityEngine.Object obj41 = tournamentMessageButton;
		object obj42 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v120+E4]");
		bool flag46 = (nint)0 == 0;
		object obj43 = !flag46;
		flag30 = false;
		flag43 = true;
		UnityEngine.Object obj44 = tournamentMessageButton;
		if (obj43 != null)
		{
			goto IL_0481;
		}
		goto IL_0577;
		IL_1b9e:
		UnityEngine.Object obj45;
		bool flag47 = obj45;
		bool flag48 = !flag47;
		object obj46 = !flag48;
		if (obj46 == null)
		{
			return;
		}
		goto IL_20cd;
		IL_164c:
		RoomThemeTournamentAddon tournamentAddonsRoomTheme = ((TournamentData)obj4).TournamentAddonsRoomTheme;
		bool flag49 = tournamentAddonsRoomTheme == null;
		num4 = 0;
		if (!flag49)
		{
			RoomThemeTournamentAddon tournamentAddonsRoomTheme2 = ((TournamentData)obj4).TournamentAddonsRoomTheme;
			num4 = tournamentAddonsRoomTheme2.<RoomThemeId>k__BackingField;
			cardRoomThemeSetter.Initialize(tournamentAddonsRoomTheme2.<RoomThemeId>k__BackingField);
		}
		goto IL_16b7;
		IL_1e37:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag50 = obj32 != null;
		bool flag51 = !flag50;
		obj18 = obj17;
		flag14 = flag13;
		object obj47 = 0;
		UnityEngine.Object obj48 = null;
		if (flag51)
		{
			goto IL_1ab6;
		}
		goto IL_1e8b;
		IL_0440:
		obj41 = tournamentMessageButton;
		obj42 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X8_v120+E4]");
		bool flag52 = (nint)0 == 0;
		obj44 = tournamentMessageButton;
		if (!flag52)
		{
			goto IL_0481;
		}
		goto IL_0577;
		IL_0577:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj44)
		{
			goto IL_05ac;
		}
		goto IL_05c1;
		IL_0481:
		bool flag53 = obj41;
		bool flag54 = !flag53;
		object obj49 = !flag54;
		if (obj49 != null)
		{
			goto IL_05ac;
		}
		goto IL_05c1;
		IL_05ac:
		tournamentMessageButton.SetActive(value: true);
		goto IL_05c1;
		IL_05c1:
		GameObject gameObject2 = this.tournamentMessage.gameObject;
		gameObject2.SetActive(value: true);
		TournamentMessage tournamentMessage = this.tournamentMessage;
		nint num5 = (nint)tournamentMessage;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v681 @ X8_v118 (Il2CppClass<TournamentMessage>)+180]");
		flag7 = false;
		tournamentMessage.Initialize((TournamentData)obj4);
		goto IL_061c;
		IL_1a66:
		bool flag55 = obj31 != null;
		bool flag56 = !flag55;
		object obj50 = !flag56;
		obj47 = 0;
		obj48 = null;
		obj17 = obj18;
		flag13 = flag14;
		if (obj50 == null)
		{
			goto IL_1ab6;
		}
		goto IL_1e8b;
		IL_061c:
		TitleRestrictionTournamentAddon tournamentAddonsTitleRestriction = ((TournamentData)obj4).TournamentAddonsTitleRestriction;
		bool flag57 = tournamentAddonsTitleRestriction == null;
		TournamentData tournamentData3 = null;
		if (!flag57)
		{
			object obj51 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X0_v246+E4]");
			bool flag58 = (nint)0 == 0;
			object obj52 = !flag58;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool flag59 = title != null;
			bool flag60 = !flag59;
			flag7 = false;
			tournamentData3 = null;
			if (!flag60)
			{
				tournamentData3 = (TournamentData)obj4;
				UpdateTitleRestriction((TournamentData)obj4);
				flag7 = false;
			}
		}
		object obj53 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v10+E4]");
		PlayerRank.Ranks ranks;
		if ((nint)0 != 0)
		{
			bool flag61 = rank;
			bool flag62 = !flag61;
			object obj54 = !flag62;
			ranks = PlayerRank.Ranks.AI;
			if (obj54 == null)
			{
				goto IL_0752;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag63 = rank;
			bool flag64 = !flag63;
			ranks = PlayerRank.Ranks.AI;
			if (flag64)
			{
				goto IL_0752;
			}
		}
		object obj55 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v98+B4]");
		ranks = PlayerRank.Ranks.AI;
		RankSetter rankSetter = rank;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v415 @ X8_v98+B4]");
		rankSetter.SetRank(PlayerRank.Ranks.AI);
		UnityEngine.Object obj56 = requiredRank;
		object obj57 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ X8_v97+E4]");
		bool flag65 = (nint)0 == 0;
		object obj58 = !flag65;
		obj18 = 0;
		flag14 = false;
		flag7 = false;
		object obj59 = 0;
		bool flag66 = false;
		bool flag67 = false;
		UnityEngine.Object obj60 = requiredRank;
		if (obj58 != null)
		{
			goto IL_07ab;
		}
		goto IL_0b7e;
		IL_16b7:
		object obj61 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1298 @ X0_v33+E4]");
		int num7;
		if ((nint)0 != 0)
		{
			bool flag68 = feeText;
			bool flag69 = !flag68;
			object obj62 = !flag69;
			int num6 = 0;
			if (obj62 != null)
			{
				goto IL_1787;
			}
			flag19 = (byte)num2 != 0;
			num7 = 0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag70 = feeText;
			bool flag71 = !flag70;
			int num6 = 0;
			flag19 = (byte)num2 != 0;
			num7 = 0;
			if (!flag71)
			{
				goto IL_1787;
			}
		}
		goto IL_18bc;
		IL_2098:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj63;
		if ((bool)obj63)
		{
			goto IL_20cd;
		}
		return;
		IL_1b5d:
		object obj64 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1701 @ X0_v36+E4]");
		bool flag72 = (nint)0 == 0;
		obj45 = clusterSize;
		obj63 = clusterSize;
		if (!flag72)
		{
			goto IL_1b9e;
		}
		goto IL_2098;
		IL_1787:
		object obj65 = obj4;
		TournamentJoinCostUi tournamentJoinCostUi = feeText;
		object obj66 = typeof(Queue<string>) + 848;
		object obj67 = obj66;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1347 @ X0_v101+E4]");
		bool flag73 = (nint)0 == 0;
		object obj68 = !flag73;
		if (obj68 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj69 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int tournamentJoiningDiscount = SFSKammelnaUserExtensions.GetTournamentJoiningDiscount(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v55+94]");
		int num8 = (int)(-tournamentJoiningDiscount);
		if (num8 >= 1)
		{
			tournamentJoinCostUi.acesObject.SetActive(value: true);
			TextMeshProExtensions.SetPriceText(tournamentJoinCostUi.text, num8, useCommas: true);
			obj18 = 0;
			flag14 = false;
			flag19 = true;
			num7 = num8;
			goto IL_18bc;
		}
		tournamentJoinCostUi.acesObject.SetActive(value: false);
		UnityEngine.Object obj70 = prizeUi;
		object obj71 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1392 @ X0_v71+E4]");
		bool flag74 = (nint)0 == 0;
		object obj72 = !flag74;
		flag19 = false;
		obj17 = obj18;
		flag13 = flag14;
		bool flag75 = false;
		bool flag76 = false;
		UnityEngine.Object obj73 = prizeUi;
		if (obj72 != null)
		{
			goto IL_191d;
		}
		goto IL_1c5e;
		IL_1e8b:
		ChampionshipTournamentAddon tournamentAddonsChampionship = ((TournamentData)obj4).TournamentAddonsChampionship;
		object obj75;
		if (tournamentAddonsChampionship != null)
		{
			bool flag77 = (object)engraving == null;
			object obj74 = !flag77;
			obj75 = 1;
			if (obj74 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			object obj76 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v29+BE]");
			obj75 = 0;
		}
		bool active = (byte)(obj75 & 1) != 0;
		engraving.SetActive(active);
		UnityEngine.Object obj77 = clusterSizeText;
		object obj78 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1651 @ X0_v46+E4]");
		bool flag78 = (nint)0 == 0;
		object obj79 = !flag78;
		obj18 = obj17;
		flag14 = flag13;
		obj47 = 0;
		object obj80 = 0;
		UnityEngine.Object obj81 = clusterSizeText;
		if (obj79 != null)
		{
			goto IL_1b17;
		}
		goto IL_1f9a;
		IL_1ff2:
		TextMeshProUGUI textMeshProUGUI = clusterSizeText;
		int num9 = default(int);
		string text = num9.ToString();
		nint num10 = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1713 @ X8_v23 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		obj47 = 0;
		textMeshProUGUI.text = text;
		obj45 = clusterSize;
		obj64 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1701 @ X0_v36+E4]");
		bool flag79 = (nint)0 == 0;
		object obj82 = !flag79;
		obj18 = obj17;
		flag14 = flag13;
		string text2 = text;
		obj63 = clusterSize;
		if (obj82 != null)
		{
			goto IL_1b9e;
		}
		goto IL_2098;
		IL_1ab6:
		obj78 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1651 @ X0_v46+E4]");
		bool flag80 = (nint)0 == 0;
		obj77 = clusterSizeText;
		obj17 = obj18;
		flag13 = flag14;
		obj80 = obj47;
		active = (byte)(int)obj48 != 0;
		obj81 = clusterSizeText;
		if (!flag80)
		{
			goto IL_1b17;
		}
		goto IL_1f9a;
		IL_1f9a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag81 = obj81;
		bool flag82 = !flag81;
		obj18 = obj17;
		flag14 = flag13;
		obj47 = obj80;
		text2 = null;
		if (flag82)
		{
			goto IL_1b5d;
		}
		goto IL_1ff2;
		IL_0752:
		obj56 = requiredRank;
		obj57 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v810 @ X8_v97+E4]");
		bool flag83 = (nint)0 == 0;
		obj59 = obj18;
		flag66 = flag14;
		flag67 = flag7;
		obj60 = requiredRank;
		if (!flag83)
		{
			goto IL_07ab;
		}
		goto IL_0b7e;
		IL_0b7e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag84 = obj60;
		bool flag85 = !flag84;
		obj18 = obj59;
		flag14 = flag66;
		flag7 = flag67;
		PlayerRank.Ranks ranks2 = PlayerRank.Ranks.AI;
		if (flag85)
		{
			goto IL_07e5;
		}
		goto IL_0bd4;
		IL_07ab:
		bool flag86 = obj56;
		bool flag87 = !flag86;
		object obj83 = !flag87;
		ranks2 = PlayerRank.Ranks.AI;
		if (obj83 == null)
		{
			goto IL_07e5;
		}
		goto IL_0bd4;
		IL_0bd4:
		object obj84 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v95+B4]");
		ranks2 = PlayerRank.Ranks.AI;
		RankSetter rankSetter2 = requiredRank;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v95+B4]");
		rankSetter2.SetRank(PlayerRank.Ranks.AI);
		UnityEngine.Object obj85 = requirementInfo;
		object obj86 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ X8_v93+E4]");
		bool flag88 = (nint)0 == 0;
		object obj87 = !flag88;
		obj18 = 0;
		flag14 = false;
		flag7 = false;
		object obj88 = 0;
		bool flag89 = false;
		bool flag90 = false;
		UnityEngine.Object obj89 = requirementInfo;
		if (obj87 != null)
		{
			goto IL_083e;
		}
		goto IL_0c94;
		IL_07e5:
		obj85 = requirementInfo;
		obj86 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v876 @ X8_v93+E4]");
		bool flag91 = (nint)0 == 0;
		obj88 = obj18;
		flag89 = flag14;
		flag90 = flag7;
		obj89 = requirementInfo;
		if (!flag91)
		{
			goto IL_083e;
		}
		goto IL_0c94;
		IL_0c94:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag92 = obj89;
		bool flag93 = !flag92;
		obj18 = obj88;
		flag14 = flag89;
		flag7 = flag90;
		TournamentData tournamentData4 = null;
		if (flag93)
		{
			goto IL_0884;
		}
		goto IL_0ce6;
		IL_083e:
		bool flag94 = obj85;
		bool flag95 = !flag94;
		object obj90 = !flag95;
		tournamentData4 = null;
		obj88 = obj18;
		flag89 = flag14;
		if (obj90 == null)
		{
			goto IL_0884;
		}
		goto IL_0ce6;
		IL_0ce6:
		GameObject gameObject3 = requirementInfo.gameObject;
		gameObject3.SetActive(value: true);
		tournamentData4 = (TournamentData)obj4;
		requirementInfo.Initialize((TournamentData)obj4);
		UnityEngine.Object obj91 = dateTime;
		object obj92 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X8_v90+E4]");
		bool flag96 = (nint)0 == 0;
		object obj93 = !flag96;
		obj18 = obj88;
		flag14 = flag89;
		flag7 = false;
		bool flag97 = false;
		UnityEngine.Object obj94 = dateTime;
		if (obj93 != null)
		{
			goto IL_08dd;
		}
		goto IL_0d92;
		IL_0884:
		obj91 = dateTime;
		obj92 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X8_v90+E4]");
		bool flag98 = (nint)0 == 0;
		obj88 = obj18;
		flag89 = flag14;
		flag97 = flag7;
		obj94 = dateTime;
		if (!flag98)
		{
			goto IL_08dd;
		}
		goto IL_0d92;
		IL_0d92:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag99 = obj94;
		bool flag100 = !flag99;
		obj18 = obj88;
		flag14 = flag89;
		flag7 = flag97;
		TournamentData tournamentData5 = null;
		if (flag100)
		{
			goto IL_0923;
		}
		goto IL_0de4;
		IL_08dd:
		bool flag101 = obj91;
		bool flag102 = !flag101;
		object obj95 = !flag102;
		tournamentData5 = null;
		obj88 = obj18;
		flag89 = flag14;
		if (obj95 == null)
		{
			goto IL_0923;
		}
		goto IL_0de4;
		IL_0de4:
		Room room = tournamentRoom;
		tournamentData5 = (TournamentData)obj4;
		dateTime.Initialize((TournamentData)obj4, tournamentRoom);
		UnityEngine.Object obj96 = infoIcons;
		object obj97 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X8_v87+E4]");
		bool flag103 = (nint)0 == 0;
		object obj98 = !flag103;
		obj18 = obj88;
		flag14 = flag89;
		flag7 = (byte)(int)tournamentRoom != 0;
		UnityEngine.Object obj99 = infoIcons;
		if (obj98 != null)
		{
			goto IL_097c;
		}
		goto IL_0e71;
		IL_0923:
		obj96 = infoIcons;
		obj97 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v976 @ X8_v87+E4]");
		bool flag104 = (nint)0 == 0;
		obj88 = obj18;
		flag89 = flag14;
		room = (Room)flag7;
		obj99 = infoIcons;
		if (!flag104)
		{
			goto IL_097c;
		}
		goto IL_0e71;
		IL_0e71:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag105 = obj99;
		bool flag106 = !flag105;
		obj18 = obj88;
		flag14 = flag89;
		flag7 = (byte)(int)room != 0;
		TournamentData tournamentData6 = null;
		if (flag106)
		{
			goto IL_09ca;
		}
		goto IL_0ec3;
		IL_097c:
		bool flag107 = obj96;
		bool flag108 = !flag107;
		object obj100 = !flag108;
		tournamentData6 = null;
		obj88 = obj18;
		flag89 = flag14;
		room = (Room)flag7;
		if (obj100 == null)
		{
			goto IL_09ca;
		}
		goto IL_0ec3;
		IL_0ec3:
		tournamentData6 = (TournamentData)obj4;
		infoIcons.Initialize((TournamentData)obj4);
		UnityEngine.Object obj101 = buttons;
		object obj102 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1027 @ X8_v84+E4]");
		bool flag109 = (nint)0 == 0;
		object obj103 = !flag109;
		obj18 = obj88;
		flag14 = flag89;
		flag7 = (byte)(int)room != 0;
		UnityEngine.Object obj104 = buttons;
		if (obj103 != null)
		{
			goto IL_0a23;
		}
		goto IL_0f3e;
		IL_09ca:
		obj101 = buttons;
		obj102 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1027 @ X8_v84+E4]");
		bool flag110 = (nint)0 == 0;
		obj88 = obj18;
		flag89 = flag14;
		room = (Room)flag7;
		obj104 = buttons;
		if (!flag110)
		{
			goto IL_0a23;
		}
		goto IL_0f3e;
		IL_0f3e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag111 = obj104;
		bool flag112 = !flag111;
		obj18 = obj88;
		flag14 = flag89;
		Room room2 = room;
		Room room3 = null;
		if (!flag112)
		{
			goto IL_0f90;
		}
		goto IL_1084;
		IL_0a23:
		bool flag113 = obj101;
		bool flag114 = !flag113;
		object obj105 = !flag114;
		room = (Room)flag7;
		if (obj105 != null)
		{
			goto IL_0f90;
		}
		obj88 = obj18;
		flag89 = flag14;
		room2 = (Room)flag7;
		room3 = null;
		goto IL_1084;
		IL_0f90:
		object obj106 = buttons + 112;
		obj106 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj107 = buttons + 120;
		obj107 = tournamentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1057 @ X24_v14-58]");
		if ((nint)0 != 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1057 @ X24_v14-58]");
			bool flag115 = (nint)0 == 0;
			object obj108 = !flag115;
			obj88 = obj18;
			flag89 = flag14;
			room2 = room;
			room3 = tournamentRoom;
			if (obj108 == null)
			{
				buttons.UpdateVisibility();
				obj88 = obj18;
				flag89 = flag14;
				room2 = room;
				room3 = tournamentRoom;
			}
			goto IL_1084;
		}
		buttons.UpdateInteractivity();
		UnityEngine.Object obj109 = eligibilityIndicator;
		object obj110 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ X8_v74+E4]");
		bool flag116 = (nint)0 == 0;
		object obj111 = !flag116;
		obj88 = obj18;
		flag89 = flag14;
		room2 = room;
		room3 = tournamentRoom;
		UnityEngine.Object obj112 = eligibilityIndicator;
		if (obj111 != null)
		{
			goto IL_10dd;
		}
		goto IL_123b;
		IL_18bc:
		obj71 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1392 @ X0_v71+E4]");
		bool flag117 = (nint)0 == 0;
		obj70 = prizeUi;
		obj17 = obj18;
		flag13 = flag14;
		flag75 = flag19;
		flag76 = (byte)num7 != 0;
		obj73 = prizeUi;
		if (!flag117)
		{
			goto IL_191d;
		}
		goto IL_1c5e;
		IL_20cd:
		object obj113 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v17+CC]");
		object obj114 = (nint)0 >> 32;
		bool flag118 = (nint)obj114 < 0;
		bool flag119 = obj114 == null;
		object obj115 = obj114 ^ obj114;
		object obj116 = obj114 & obj115;
		bool flag120 = (nint)obj116 < 0;
		bool flag121 = flag118 == flag120;
		object obj117 = !flag119;
		object obj118 = flag121 & obj117;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X8_v17+CC]");
		bool active2 = (byte)(obj118 & 0) != 0;
		clusterSize.SetActive(active2);
		return;
		IL_1c5e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag122 = obj73;
		bool flag123 = !flag122;
		obj18 = obj17;
		flag14 = flag13;
		flag19 = flag75;
		tournamentData2 = null;
		if (flag123)
		{
			goto IL_1963;
		}
		goto IL_1cb0;
		IL_1b17:
		bool flag124 = obj77;
		bool flag125 = !flag124;
		object obj119 = !flag125;
		text2 = null;
		obj17 = obj18;
		flag13 = flag14;
		if (obj119 == null)
		{
			goto IL_1b5d;
		}
		goto IL_1ff2;
		IL_1084:
		obj109 = eligibilityIndicator;
		obj110 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1125 @ X8_v74+E4]");
		bool flag126 = (nint)0 == 0;
		obj18 = obj88;
		flag14 = flag89;
		room = room2;
		obj112 = eligibilityIndicator;
		if (!flag126)
		{
			goto IL_10dd;
		}
		goto IL_123b;
		IL_123b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag127 = obj112;
		bool flag128 = !flag127;
		obj88 = obj18;
		flag89 = flag14;
		room2 = room;
		TournamentData tournamentData7 = null;
		if (flag128)
		{
			goto IL_112b;
		}
		goto IL_128d;
		IL_10dd:
		bool flag129 = obj109;
		bool flag130 = !flag129;
		object obj120 = !flag130;
		tournamentData7 = null;
		obj18 = obj88;
		flag14 = flag89;
		room = room2;
		if (obj120 == null)
		{
			goto IL_112b;
		}
		goto IL_128d;
		IL_128d:
		tournamentData7 = (TournamentData)obj4;
		eligibilityIndicator.Initialize((TournamentData)obj4);
		UnityEngine.Object obj121 = currentStageText;
		object obj122 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1208 @ X0_v149+E4]");
		bool flag131 = (nint)0 == 0;
		object obj123 = !flag131;
		obj88 = obj18;
		flag89 = flag14;
		room2 = room;
		UnityEngine.Object obj124 = currentStageText;
		if (obj123 != null)
		{
			goto IL_117c;
		}
		goto IL_1308;
		IL_112b:
		obj122 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1208 @ X0_v149+E4]");
		bool flag132 = (nint)0 == 0;
		obj121 = currentStageText;
		obj18 = obj88;
		flag14 = flag89;
		obj124 = currentStageText;
		if (!flag132)
		{
			goto IL_117c;
		}
		goto IL_1308;
		IL_1308:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag133 = obj124;
		bool flag134 = !flag133;
		obj88 = obj18;
		flag89 = flag14;
		if (!flag134)
		{
			goto IL_134d;
		}
		goto IL_13b8;
		IL_117c:
		bool flag135 = obj121;
		bool flag136 = !flag135;
		object obj125 = !flag136;
		if (obj125 != null)
		{
			goto IL_134d;
		}
		obj18 = obj88;
		flag14 = flag89;
		goto IL_13b8;
		IL_134d:
		int tournamentCurrentRound = SFSKammelnaRoomExtensions.GetTournamentCurrentRound(tournamentRoom);
		object obj126 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v70+6C]");
		int numberOfRounds = TournamentMath.GetNumberOfRounds(0);
		LocalizableText tournamentRoundName = TournamentUtil.GetTournamentRoundName(tournamentCurrentRound, numberOfRounds);
		TextMeshProExtensions.Localize(currentStageText, tournamentRoundName);
		obj18 = obj88;
		flag14 = flag89;
		goto IL_13b8;
		IL_191d:
		bool flag137 = obj70;
		bool flag138 = !flag137;
		object obj127 = !flag138;
		tournamentData2 = null;
		obj17 = obj18;
		flag13 = flag14;
		if (obj127 == null)
		{
			goto IL_1963;
		}
		goto IL_1cb0;
	}

	private void UpdateTitleRestriction(TournamentData tournament)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01e3: Expected O, but got I4
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0398: Expected O, but got I4
		//IL_02a2: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D72]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v44+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v44+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_0140;
		IL_0140:
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		PlayerRank playerRank = SFSKammelnaUserExtensions.GetRank(localUser);
		TitleRestrictionTournamentAddon tournamentAddonsTitleRestriction = tournament.TournamentAddonsTitleRestriction;
		bool flag3 = tournamentAddonsTitleRestriction.IsEligible();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		bool flag4 = tournament.CanParticipate(localUser2);
		if (flag3)
		{
			bool flag5 = !flag4;
			object obj8 = !flag5;
			if (obj8 == null && playerRank.<Rank>k__BackingField < tournament.<RankLimit>k__BackingField)
			{
				GameObject gameObject = title.gameObject;
				gameObject.SetActive(value: false);
				object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v35+E4]");
				if ((nint)0 != 0)
				{
					bool flag6 = rank;
					bool flag7 = !flag6;
					object obj11 = !flag7;
					if (obj11 == null)
					{
						return;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					if (!rank)
					{
						return;
					}
				}
				GameObject gameObject2 = rank.gameObject;
				gameObject2.SetActive(value: true);
				return;
			}
		}
		TitleRestrictionTournamentAddon tournamentAddonsTitleRestriction2 = tournament.TournamentAddonsTitleRestriction;
		string achievementID = tournamentAddonsTitleRestriction2.RestrictionTitleId();
		TitleRestrictionTournamentAddon tournamentAddonsTitleRestriction3 = tournament.TournamentAddonsTitleRestriction;
		int titleLevelId = tournamentAddonsTitleRestriction3.RestrictionTitleLevel();
		title.AssignTitle(achievementID, titleLevelId);
		GameObject gameObject3 = title.gameObject;
		gameObject3.SetActive(value: true);
		object obj12 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj13 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X0_v24+E4]");
		if ((nint)0 != 0)
		{
			bool flag8 = rank;
			bool flag9 = !flag8;
			object obj14 = !flag9;
			if (obj14 == null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!rank)
			{
				return;
			}
		}
		GameObject gameObject4 = rank.gameObject;
		gameObject4.SetActive(value: false);
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag10 = (object)sessionModel == null;
		object obj15 = !flag10;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
	}

	private bool IsTournamentHidden(TournamentData tournament)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_0591: Expected I4, but got O
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Expected O, but got Unknown
		//IL_0287: Expected O, but got I4
		//IL_04e0: Expected O, but got I4
		//IL_04e9: Expected O, but got I4
		//IL_04f2: Expected O, but got I4
		//IL_02dd: Expected O, but got I
		//IL_0321: Expected O, but got I4
		//IL_0509: Expected O, but got I4
		//IL_051b: Expected O, but got I4
		//IL_052f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_055e: Expected O, but got I4
		//IL_0567: Expected I8, but got I4
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e7: Expected O, but got Unknown
		//IL_0446: Expected I8, but got I4
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected O, but got Unknown
		//IL_0484: Expected O, but got I4
		//IL_0491: Expected I8, but got I4
		//IL_057e: Expected I8, but got I4
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D73]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v37+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v37+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		obj3 = obj5;
		if (!flag3)
		{
			goto IL_014f;
		}
		goto IL_0583;
		IL_023e:
		bool flag4 = false;
		goto IL_0591;
		IL_0583:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_049f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		long num;
		long userId = num;
		goto IL_0596;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj7 = !flag5;
		if (obj7 != null)
		{
			goto IL_014f;
		}
		goto IL_0583;
		IL_014f:
		User localUser = sessionModel.LocalUser;
		flag4 = SFSKammelnaUserExtensions.Can(localUser, UserPermission.AccessHiddenTournaments);
		object obj12;
		int? num3;
		int? num4;
		object obj15;
		if (flag4)
		{
			if (tournament != null)
			{
				if (tournament.<IsHidden>k__BackingField)
				{
					object obj8 = typeof(System.Formats.Asn1.SetOfValueComparer) + 80;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v9+E4]");
					if ((nint)0 != 0)
					{
						if (SfsTournamentConnector.IsParticipating(tournament.<RoomId>k__BackingField))
						{
							goto IL_023e;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						bool flag6 = SfsTournamentConnector.IsParticipating(tournament.<RoomId>k__BackingField);
						bool flag7 = !flag6;
						object obj10 = !flag7;
						if (obj10 != null)
						{
							goto IL_023e;
						}
					}
					PlayerInfo <Creator>k__BackingField = tournament.<Creator>k__BackingField;
					if (tournament.<Creator>k__BackingField != null)
					{
						int <DBID>k__BackingField = <Creator>k__BackingField.<DBID>k__BackingField;
						object obj11 = (nint)0 + (nint)3136;
						obj12 = obj11;
						int? num2 = <Creator>k__BackingField.<DBID>k__BackingField;
						object obj13 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v26+E4]");
						bool flag8 = (nint)0 == 0;
						object obj14 = !flag8;
						num3 = num2;
						obj15 = obj11;
						num4 = num2;
						if (obj14 == null)
						{
							goto IL_0347;
						}
					}
					else
					{
						object obj13 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X0_v26+E4]");
						bool flag9 = (nint)0 == 0;
						object obj16 = !flag9;
						obj15 = 0;
						num4 = (int?)(object)0;
						if (obj16 == null)
						{
							obj12 = 0;
							int <DBID>k__BackingField = 512;
							num3 = (int?)(object)0;
							goto IL_0347;
						}
					}
					goto IL_0366;
				}
				goto IL_0404;
			}
			goto IL_0583;
		}
		goto IL_0591;
		IL_0591:
		return flag4;
		IL_0347:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj15 = obj12;
		num4 = num3;
		goto IL_0366;
		IL_0366:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		if ((object)sessionModel2 == null)
		{
			goto IL_0583;
		}
		object obj17 = (object?)num4 >> 32;
		User localUser2 = sessionModel2.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser2);
		if (intDbId == (nint)obj17)
		{
			object obj18 = (??)num4 & 1;
			if (obj18 != null)
			{
				goto IL_0404;
			}
		}
		PlayerInfo <Creator>k__BackingField2 = tournament.<Creator>k__BackingField;
		if (tournament.<Creator>k__BackingField != null)
		{
			num = <Creator>k__BackingField2.<DBID>k__BackingField;
			object obj19 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v18+E4]");
			bool flag10 = (nint)0 == 0;
			object obj21 = !flag10;
			userId = <Creator>k__BackingField2.<DBID>k__BackingField;
			if (obj21 == null)
			{
				goto IL_049f;
			}
		}
		else
		{
			object obj22 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj20 = obj22;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X8_v18+E4]");
			bool flag11 = (nint)0 == 0;
			object obj23 = !flag11;
			userId = 0L;
			if (obj23 == null)
			{
				num = 0L;
				goto IL_049f;
			}
		}
		goto IL_0596;
		IL_0596:
		bool flag12 = FriendsManager.IsFriend(userId);
		return (byte)((flag12 ? 1u : 0u) ^ 1u) != 0;
		IL_0404:
		return false;
	}

	public TournamentStrip()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
