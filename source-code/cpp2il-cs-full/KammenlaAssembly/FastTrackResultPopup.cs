using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class FastTrackResultPopup : PopupUI
{
	public FastTrackPopupManager manager;

	public Timer timer;

	public Button ExitGame;

	public Button ClaimRank;

	public Button SameTeammate;

	public Button NewTeammate;

	public Button ContinueCup;

	public Button StartNewCup;

	public Button ShowRoundboard;

	public RankUI StageRewardRank;

	public Button CancelMatching;

	public TextMeshProUGUI MatchingStatusShort;

	public TextMeshProUGUI MatchingStatusLong;

	public TextMeshProUGUI YourTeamHasLostIndicator;

	private Vector2 NewTeammateButtonOriginalSize;

	private List<FTPlayMoreStates> playMoreStates;

	private bool showPlayMoreStateIsActive;

	private bool showNewTeammateIsTheOnlyOptionStateIsActive;

	private bool timeIsUp;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_051f: Expected O, but got I4
		//IL_052d: Expected O, but got I4
		//IL_003f: Expected O, but got I4
		//IL_0048: Expected O, but got I4
		//IL_0056: Expected O, but got I4
		//IL_055e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0563: Expected O, but got Unknown
		//IL_0579: Expected O, but got I
		//IL_0587: Expected I, but got O
		//IL_0646: Expected O, but got I4
		//IL_0654: Expected O, but got I4
		//IL_00de: Expected O, but got I4
		//IL_00e7: Expected O, but got I4
		//IL_00fd: Expected O, but got I4
		//IL_05d2: Expected O, but got I4
		//IL_05db: Expected O, but got I4
		//IL_05e4: Expected O, but got I4
		//IL_05ed: Expected O, but got I4
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected O, but got Unknown
		//IL_06a0: Expected O, but got I
		//IL_06ae: Expected I, but got O
		//IL_076d: Expected O, but got I4
		//IL_077b: Expected O, but got I4
		//IL_0185: Expected O, but got I4
		//IL_018e: Expected O, but got I4
		//IL_01a4: Expected O, but got I4
		//IL_06f9: Expected O, but got I4
		//IL_0702: Expected O, but got I4
		//IL_070b: Expected O, but got I4
		//IL_0714: Expected O, but got I4
		//IL_07ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected O, but got Unknown
		//IL_07c7: Expected O, but got I
		//IL_07d5: Expected I, but got O
		//IL_0894: Expected O, but got I4
		//IL_08a2: Expected O, but got I4
		//IL_022c: Expected O, but got I4
		//IL_0235: Expected O, but got I4
		//IL_024b: Expected O, but got I4
		//IL_0820: Expected O, but got I4
		//IL_0829: Expected O, but got I4
		//IL_0832: Expected O, but got I4
		//IL_083b: Expected O, but got I4
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d8: Expected O, but got Unknown
		//IL_08ee: Expected O, but got I
		//IL_08fc: Expected I, but got O
		//IL_09bb: Expected O, but got I4
		//IL_09c9: Expected O, but got I4
		//IL_02d3: Expected O, but got I4
		//IL_02dc: Expected O, but got I4
		//IL_02f2: Expected O, but got I4
		//IL_0947: Expected O, but got I4
		//IL_0950: Expected O, but got I4
		//IL_0959: Expected O, but got I4
		//IL_0962: Expected O, but got I4
		//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ff: Expected O, but got Unknown
		//IL_0a15: Expected O, but got I
		//IL_0a23: Expected I, but got O
		//IL_0ae2: Expected O, but got I4
		//IL_0af0: Expected O, but got I4
		//IL_037a: Expected O, but got I4
		//IL_0383: Expected O, but got I4
		//IL_0399: Expected O, but got I4
		//IL_0a6e: Expected O, but got I4
		//IL_0a77: Expected O, but got I4
		//IL_0a80: Expected O, but got I4
		//IL_0a89: Expected O, but got I4
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b26: Expected O, but got Unknown
		//IL_0b3c: Expected O, but got I
		//IL_0b4a: Expected I, but got O
		//IL_0c09: Expected O, but got I4
		//IL_0c17: Expected O, but got I4
		//IL_0421: Expected O, but got I4
		//IL_042a: Expected O, but got I4
		//IL_0440: Expected O, but got I4
		//IL_0b95: Expected O, but got I4
		//IL_0b9e: Expected O, but got I4
		//IL_0ba7: Expected O, but got I4
		//IL_0bb0: Expected O, but got I4
		//IL_0c48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4d: Expected O, but got Unknown
		//IL_0c63: Expected O, but got I
		//IL_0c71: Expected I, but got O
		//IL_0d31: Expected O, but got I4
		//IL_04c8: Expected O, but got I4
		//IL_04d2: Expected O, but got I4
		//IL_0cbc: Expected O, but got I4
		//IL_0cc5: Expected O, but got I4
		//IL_0cce: Expected O, but got I4
		//IL_0cd7: Expected O, but got I4
		//IL_0d62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d67: Expected O, but got Unknown
		//IL_0d7d: Expected O, but got I
		//IL_0d8b: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		base.Awake();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		UnityEngine.Object obj5;
		object obj4;
		if ((nint)0 != 0)
		{
			bool flag = ExitGame != null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			obj4 = 0;
			obj5 = null;
			object obj6 = 0;
			UnityEngine.Object obj7 = null;
			if (obj3 == null)
			{
				goto IL_0069;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = ExitGame != null;
			bool flag4 = !flag3;
			obj4 = 0;
			obj5 = null;
			object obj6 = 0;
			UnityEngine.Object obj7 = null;
			if (flag4)
			{
				goto IL_0069;
			}
		}
		Button exitGame = ExitGame;
		object obj8 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = (nint)0 + (nint)2480;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj9);
		exitGame.m_OnClick.AddListener(unityAction);
		UnityEngine.Object claimRank = ClaimRank;
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v71+E4]");
		bool flag5 = (nint)0 == 0;
		object obj11 = !flag5;
		object obj12 = 0;
		object obj13 = 0;
		obj4 = 0;
		UnityAction unityAction2 = unityAction;
		UnityEngine.Object claimRank2 = ClaimRank;
		if (obj11 != null)
		{
			goto IL_00ba;
		}
		goto IL_060d;
		IL_04e5:
		RegisterEventListeners();
		return;
		IL_0d44:
		Button cancelMatching = CancelMatching;
		object obj14 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)2520;
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj15);
		cancelMatching.m_OnClick.AddListener(unityAction3);
		RegisterEventListeners();
		return;
		IL_04a4:
		UnityEngine.Object cancelMatching2;
		bool flag6 = cancelMatching2 != null;
		bool flag7 = !flag6;
		object obj16 = !flag7;
		object obj17 = 0;
		UnityEngine.Object obj18 = null;
		if (obj16 == null)
		{
			goto IL_04e5;
		}
		goto IL_0d44;
		IL_0069:
		obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v71+E4]");
		bool flag8 = (nint)0 == 0;
		claimRank = ClaimRank;
		obj13 = obj12;
		unityAction2 = (UnityAction)(object)obj5;
		claimRank2 = ClaimRank;
		if (!flag8)
		{
			goto IL_00ba;
		}
		goto IL_060d;
		IL_060d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag9 = claimRank2 != null;
		bool flag10 = !flag9;
		obj12 = obj13;
		object obj19 = 0;
		UnityEngine.Object obj20 = null;
		object obj21 = 0;
		UnityEngine.Object obj22 = null;
		if (flag10)
		{
			goto IL_0110;
		}
		goto IL_0667;
		IL_00ba:
		bool flag11 = claimRank != null;
		bool flag12 = !flag11;
		object obj23 = !flag12;
		obj19 = 0;
		obj20 = null;
		obj13 = obj12;
		obj21 = 0;
		obj22 = null;
		if (obj23 == null)
		{
			goto IL_0110;
		}
		goto IL_0667;
		IL_0667:
		Button claimRank3 = ClaimRank;
		object obj24 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj25 = (nint)0 + (nint)2464;
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(this, (IntPtr)obj25);
		claimRank3.m_OnClick.AddListener(unityAction4);
		UnityEngine.Object sameTeammate = SameTeammate;
		object obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v51+E4]");
		bool flag13 = (nint)0 == 0;
		object obj27 = !flag13;
		obj12 = 0;
		object obj28 = 0;
		obj19 = 0;
		UnityAction unityAction5 = unityAction4;
		UnityEngine.Object sameTeammate2 = SameTeammate;
		if (obj27 != null)
		{
			goto IL_0161;
		}
		goto IL_0734;
		IL_0110:
		sameTeammate = SameTeammate;
		obj26 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v51+E4]");
		bool flag14 = (nint)0 == 0;
		obj28 = obj12;
		unityAction5 = (UnityAction)(object)obj20;
		sameTeammate2 = SameTeammate;
		if (!flag14)
		{
			goto IL_0161;
		}
		goto IL_0734;
		IL_0734:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag15 = sameTeammate2 != null;
		bool flag16 = !flag15;
		obj12 = obj28;
		object obj29 = 0;
		UnityEngine.Object obj30 = null;
		object obj31 = 0;
		UnityEngine.Object obj32 = null;
		if (flag16)
		{
			goto IL_01b7;
		}
		goto IL_078e;
		IL_0161:
		bool flag17 = sameTeammate != null;
		bool flag18 = !flag17;
		object obj33 = !flag18;
		obj29 = 0;
		obj30 = null;
		obj28 = obj12;
		obj31 = 0;
		obj32 = null;
		if (obj33 == null)
		{
			goto IL_01b7;
		}
		goto IL_078e;
		IL_078e:
		Button sameTeammate3 = SameTeammate;
		object obj34 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj35 = (nint)0 + (nint)2496;
		UnityAction unityAction6 = default(UnityAction);
		unityAction6..ctor(this, (IntPtr)obj35);
		sameTeammate3.m_OnClick.AddListener(unityAction6);
		UnityEngine.Object newTeammate = NewTeammate;
		object obj36 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v43+E4]");
		bool flag19 = (nint)0 == 0;
		object obj37 = !flag19;
		obj12 = 0;
		object obj38 = 0;
		obj29 = 0;
		UnityAction unityAction7 = unityAction6;
		UnityEngine.Object newTeammate2 = NewTeammate;
		if (obj37 != null)
		{
			goto IL_0208;
		}
		goto IL_085b;
		IL_01b7:
		newTeammate = NewTeammate;
		obj36 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v43+E4]");
		bool flag20 = (nint)0 == 0;
		obj38 = obj12;
		unityAction7 = (UnityAction)(object)obj30;
		newTeammate2 = NewTeammate;
		if (!flag20)
		{
			goto IL_0208;
		}
		goto IL_085b;
		IL_085b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag21 = newTeammate2 != null;
		bool flag22 = !flag21;
		obj12 = obj38;
		object obj39 = 0;
		UnityEngine.Object obj40 = null;
		object obj41 = 0;
		UnityEngine.Object obj42 = null;
		if (flag22)
		{
			goto IL_025e;
		}
		goto IL_08b5;
		IL_0208:
		bool flag23 = newTeammate != null;
		bool flag24 = !flag23;
		object obj43 = !flag24;
		obj39 = 0;
		obj40 = null;
		obj38 = obj12;
		obj41 = 0;
		obj42 = null;
		if (obj43 == null)
		{
			goto IL_025e;
		}
		goto IL_08b5;
		IL_08b5:
		Button newTeammate3 = NewTeammate;
		object obj44 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj45 = (nint)0 + (nint)2488;
		UnityAction unityAction8 = default(UnityAction);
		unityAction8..ctor(this, (IntPtr)obj45);
		newTeammate3.m_OnClick.AddListener(unityAction8);
		UnityEngine.Object continueCup = ContinueCup;
		object obj46 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v35+E4]");
		bool flag25 = (nint)0 == 0;
		object obj47 = !flag25;
		obj12 = 0;
		object obj48 = 0;
		obj39 = 0;
		UnityAction unityAction9 = unityAction8;
		UnityEngine.Object continueCup2 = ContinueCup;
		if (obj47 != null)
		{
			goto IL_02af;
		}
		goto IL_0982;
		IL_025e:
		continueCup = ContinueCup;
		obj46 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X8_v35+E4]");
		bool flag26 = (nint)0 == 0;
		obj48 = obj12;
		unityAction9 = (UnityAction)(object)obj40;
		continueCup2 = ContinueCup;
		if (!flag26)
		{
			goto IL_02af;
		}
		goto IL_0982;
		IL_0982:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag27 = continueCup2 != null;
		bool flag28 = !flag27;
		obj12 = obj48;
		object obj49 = 0;
		UnityEngine.Object obj50 = null;
		object obj51 = 0;
		UnityEngine.Object obj52 = null;
		if (flag28)
		{
			goto IL_0305;
		}
		goto IL_09dc;
		IL_02af:
		bool flag29 = continueCup != null;
		bool flag30 = !flag29;
		object obj53 = !flag30;
		obj49 = 0;
		obj50 = null;
		obj48 = obj12;
		obj51 = 0;
		obj52 = null;
		if (obj53 == null)
		{
			goto IL_0305;
		}
		goto IL_09dc;
		IL_09dc:
		Button continueCup3 = ContinueCup;
		object obj54 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj55 = (nint)0 + (nint)2472;
		UnityAction unityAction10 = default(UnityAction);
		unityAction10..ctor(this, (IntPtr)obj55);
		continueCup3.m_OnClick.AddListener(unityAction10);
		UnityEngine.Object startNewCup = StartNewCup;
		object obj56 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v27+E4]");
		bool flag31 = (nint)0 == 0;
		object obj57 = !flag31;
		obj12 = 0;
		object obj58 = 0;
		obj49 = 0;
		UnityAction unityAction11 = unityAction10;
		UnityEngine.Object startNewCup2 = StartNewCup;
		if (obj57 != null)
		{
			goto IL_0356;
		}
		goto IL_0aa9;
		IL_0305:
		startNewCup = StartNewCup;
		obj56 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X8_v27+E4]");
		bool flag32 = (nint)0 == 0;
		obj58 = obj12;
		unityAction11 = (UnityAction)(object)obj50;
		startNewCup2 = StartNewCup;
		if (!flag32)
		{
			goto IL_0356;
		}
		goto IL_0aa9;
		IL_0aa9:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag33 = startNewCup2 != null;
		bool flag34 = !flag33;
		obj12 = obj58;
		object obj59 = 0;
		UnityEngine.Object obj60 = null;
		object obj61 = 0;
		UnityEngine.Object obj62 = null;
		if (flag34)
		{
			goto IL_03ac;
		}
		goto IL_0b03;
		IL_0356:
		bool flag35 = startNewCup != null;
		bool flag36 = !flag35;
		object obj63 = !flag36;
		obj59 = 0;
		obj60 = null;
		obj58 = obj12;
		obj61 = 0;
		obj62 = null;
		if (obj63 == null)
		{
			goto IL_03ac;
		}
		goto IL_0b03;
		IL_0b03:
		Button startNewCup3 = StartNewCup;
		object obj64 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj65 = (nint)0 + (nint)2512;
		UnityAction unityAction12 = default(UnityAction);
		unityAction12..ctor(this, (IntPtr)obj65);
		startNewCup3.m_OnClick.AddListener(unityAction12);
		UnityEngine.Object showRoundboard = ShowRoundboard;
		object obj66 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v19+E4]");
		bool flag37 = (nint)0 == 0;
		object obj67 = !flag37;
		obj12 = 0;
		object obj68 = 0;
		obj59 = 0;
		UnityAction unityAction13 = unityAction12;
		UnityEngine.Object showRoundboard2 = ShowRoundboard;
		if (obj67 != null)
		{
			goto IL_03fd;
		}
		goto IL_0bd0;
		IL_03ac:
		showRoundboard = ShowRoundboard;
		obj66 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v19+E4]");
		bool flag38 = (nint)0 == 0;
		obj68 = obj12;
		unityAction13 = (UnityAction)(object)obj60;
		showRoundboard2 = ShowRoundboard;
		if (!flag38)
		{
			goto IL_03fd;
		}
		goto IL_0bd0;
		IL_0bd0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag39 = showRoundboard2 != null;
		bool flag40 = !flag39;
		obj12 = obj68;
		object obj69 = 0;
		UnityEngine.Object obj70 = null;
		object obj71 = 0;
		UnityEngine.Object obj72 = null;
		if (flag40)
		{
			goto IL_0453;
		}
		goto IL_0c2a;
		IL_03fd:
		bool flag41 = showRoundboard != null;
		bool flag42 = !flag41;
		object obj73 = !flag42;
		obj69 = 0;
		obj70 = null;
		obj68 = obj12;
		obj71 = 0;
		obj72 = null;
		if (obj73 == null)
		{
			goto IL_0453;
		}
		goto IL_0c2a;
		IL_0c2a:
		Button showRoundboard3 = ShowRoundboard;
		object obj74 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj75 = (nint)0 + (nint)2504;
		UnityAction unityAction14 = default(UnityAction);
		unityAction14..ctor(this, (IntPtr)obj75);
		showRoundboard3.m_OnClick.AddListener(unityAction14);
		cancelMatching2 = CancelMatching;
		object obj76 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v11+E4]");
		bool flag43 = (nint)0 == 0;
		object obj77 = !flag43;
		obj12 = 0;
		object obj78 = 0;
		obj69 = 0;
		UnityAction unityAction15 = unityAction14;
		UnityEngine.Object cancelMatching3 = CancelMatching;
		if (obj77 != null)
		{
			goto IL_04a4;
		}
		goto IL_0cf7;
		IL_0453:
		cancelMatching2 = CancelMatching;
		obj76 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v11+E4]");
		bool flag44 = (nint)0 == 0;
		obj78 = obj12;
		unityAction15 = (UnityAction)(object)obj70;
		cancelMatching3 = CancelMatching;
		if (!flag44)
		{
			goto IL_04a4;
		}
		goto IL_0cf7;
		IL_0cf7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag45 = cancelMatching3 != null;
		bool flag46 = !flag45;
		obj12 = obj78;
		obj17 = 0;
		obj18 = null;
		if (flag46)
		{
			goto IL_04e5;
		}
		goto IL_0d44;
	}

	private void OnDestroy()
	{
		UnRegisterEventListeners();
	}

	private void RegisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_016c: Expected I, but got O
		//IL_0196: Expected O, but got I4
		//IL_0123: Expected O, but got I4
		//IL_0131: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_00c1: Expected O, but got I
		//IL_00d9: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2536;
		object obj3 = typeof(UsageHint) + 72;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UserInfo.OnFastTrackRecordUpdated += action;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = timer != null;
			bool flag3 = !flag2;
			UnityEngine.Object obj8 = null;
			object obj9 = 0;
			if (flag3)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = timer != null;
			bool flag5 = !flag4;
			object obj10 = !flag5;
			UnityEngine.Object obj8 = null;
			object obj9 = 0;
			if (obj10 == null)
			{
				return;
			}
		}
		object obj11 = (nint)0 + (nint)2528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj11);
		timer.onTimeIsUp += action2;
	}

	private void UnRegisterEventListeners()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_016c: Expected I, but got O
		//IL_0196: Expected O, but got I4
		//IL_0123: Expected O, but got I4
		//IL_0131: Expected O, but got I4
		//IL_00a7: Expected O, but got I4
		//IL_00c1: Expected O, but got I
		//IL_00d9: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2536;
		object obj3 = typeof(UsageHint) + 72;
		object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UserInfo.OnFastTrackRecordUpdated -= action;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v7+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = timer != null;
			bool flag3 = !flag2;
			UnityEngine.Object obj8 = null;
			object obj9 = 0;
			if (flag3)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = timer != null;
			bool flag5 = !flag4;
			object obj10 = !flag5;
			UnityEngine.Object obj8 = null;
			object obj9 = 0;
			if (obj10 == null)
			{
				return;
			}
		}
		object obj11 = (nint)0 + (nint)2528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj11);
		timer.onTimeIsUp -= action2;
	}

	public void SetOriginalSizes()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_019d: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_00be: Expected O, but got I4
		//IL_00cc: Expected O, but got I4
		//IL_020e: Expected O, but got I
		//IL_026d: Expected O, but got I4
		//IL_01e6: Expected O, but got I4
		//IL_01f4: Expected O, but got I4
		//IL_013f: Expected O, but got I4
		//IL_0149: Expected O, but got I4
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_02c4: Expected O, but got I4
		//IL_03f5: Expected O, but got I
		//IL_040f: Expected O, but got I4
		//IL_032e: Expected O, but got I
		//IL_0485: Expected O, but got I
		//IL_0495: Expected O, but got I
		//IL_044d: Expected O, but got I4
		//IL_04b0: Expected O, but got I
		//IL_0390: Expected O, but got I
		//IL_03a0: Expected O, but got I
		//IL_03c2: Expected O, but got I4
		//IL_057f: Expected O, but got I4
		//IL_050a: Expected O, but got I
		//IL_051a: Expected O, but got I
		//IL_053c: Expected O, but got I4
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected O, but got Unknown
		//IL_060a: Expected O, but got I4
		//IL_05b7: Expected O, but got I
		//IL_05c7: Expected O, but got I
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89BC]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object newTeammate;
		UnityEngine.Object newTeammate2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v43+E4]");
			bool flag = (nint)0 == 0;
			newTeammate = NewTeammate;
			newTeammate2 = NewTeammate;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			newTeammate = NewTeammate;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v43+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			newTeammate2 = NewTeammate;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = newTeammate2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		object obj8 = 0;
		if (flag4)
		{
			goto IL_00da;
		}
		goto IL_0202;
		IL_0642:
		throw new NullReferenceException();
		IL_049a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
		object obj9 = (nint)0 & (nint)1;
		object obj11;
		object obj12;
		if (obj9 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v21+E4]");
			bool flag5 = (nint)0 == 0;
			object obj10 = obj11;
			if (!flag5)
			{
				goto IL_04fa;
			}
		}
		else
		{
			_ = 1;
			obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v21+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			object obj10 = obj11;
			if (obj13 != null)
			{
				goto IL_04fa;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v17+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v13+8]");
		object obj16 = 0;
		goto IL_05cc;
		IL_0380:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v21+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v29+8]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v29+8]");
		bool flag7 = (nint)0 == 0;
		object obj19 = !flag7;
		if (obj19 != null)
		{
			goto IL_049a;
		}
		goto IL_0642;
		IL_0091:
		bool flag8 = newTeammate != null;
		bool flag9 = !flag8;
		object obj20 = !flag9;
		obj6 = 0;
		obj7 = null;
		obj8 = 0;
		if (obj20 == null)
		{
			goto IL_00da;
		}
		goto IL_0202;
		IL_0202:
		object obj21 = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		RectTransform rectTransform = default(RectTransform);
		Vector2 sizeDelta = rectTransform.sizeDelta;
		Vector2 newTeammateButtonOriginalSize = default(Vector2);
		NewTeammateButtonOriginalSize = newTeammateButtonOriginalSize;
		UnityEngine.Object stageRewardRank = StageRewardRank;
		object obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v34+E4]");
		bool flag10 = (nint)0 == 0;
		object obj23 = !flag10;
		obj6 = obj8;
		obj7 = null;
		UnityEngine.Object stageRewardRank2 = StageRewardRank;
		if (obj23 != null)
		{
			goto IL_011b;
		}
		goto IL_0292;
		IL_00da:
		obj22 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v34+E4]");
		bool flag11 = (nint)0 == 0;
		stageRewardRank = StageRewardRank;
		stageRewardRank2 = StageRewardRank;
		if (!flag11)
		{
			goto IL_011b;
		}
		goto IL_0292;
		IL_0292:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag12 = stageRewardRank2 != null;
		bool flag13 = !flag12;
		object obj24 = 0;
		UnityEngine.Object obj25 = null;
		if (flag13)
		{
			goto IL_015c;
		}
		goto IL_02d7;
		IL_011b:
		bool flag14 = stageRewardRank != null;
		bool flag15 = !flag14;
		object obj26 = !flag15;
		obj24 = 0;
		obj25 = null;
		if (obj26 == null)
		{
			goto IL_015c;
		}
		goto IL_02d7;
		IL_02d7:
		obj12 = typeof(UsageHint) + 72;
		object obj27 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
			object obj28 = (nint)0 & (nint)1;
			if (obj28 != null)
			{
				goto IL_034b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
			object obj29 = (nint)0 & (nint)1;
			bool flag16 = obj29 == null;
			object obj30 = !flag16;
			if (obj30 != null)
			{
				goto IL_034b;
			}
		}
		_ = 1;
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v21+E4]");
		bool flag17 = (nint)0 == 0;
		object obj31 = !flag17;
		object obj32 = obj11;
		if (obj31 != null)
		{
			goto IL_0380;
		}
		goto IL_0463;
		IL_04fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v21+B8]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v18+8]");
		obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v18+8]");
		bool flag18 = (nint)0 == 0;
		object obj34 = !flag18;
		if (obj34 != null)
		{
			goto IL_05cc;
		}
		goto IL_0642;
		IL_05cc:
		object obj35 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		object obj36 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X0_v7+E4]");
		bool flag19 = (nint)0 == 0;
		object obj37 = !flag19;
		if (obj37 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X8_v5+20]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v7+24]");
		PlayerRank playerRank = PlayerRank.FastTrackAward((int)num, 0);
		StageRewardRank.SetRank(playerRank);
		ShowNewTeammateIsTheOnlyOptionState();
		return;
		IL_015c:
		ShowNewTeammateIsTheOnlyOptionState();
		return;
		IL_034b:
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v21+E4]");
		bool flag20 = (nint)0 == 0;
		obj32 = obj11;
		if (!flag20)
		{
			goto IL_0380;
		}
		goto IL_0463;
		IL_0463:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj11 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v21+B8]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v22+8]");
		obj18 = 0;
		goto IL_049a;
	}

	public void UpdatePlayMoreState(List<FTPlayMoreStates> playMoreStates)
	{
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Expected O, but got Unknown
		//IL_0011: Expected O, but got I
		//IL_0286: Expected O, but got I4
		//IL_029c: Expected O, but got I
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_039f: Expected O, but got I4
		//IL_033a: Expected O, but got I4
		//IL_0348: Expected O, but got I4
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_03ff: Expected O, but got I4
		//IL_01b0: Expected O, but got I4
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01da: Expected O, but got I
		//IL_04df: Expected O, but got I4
		//IL_025c: Expected O, but got I4
		//IL_026a: Expected O, but got I4
		//IL_056f: Expected O, but got I4
		//IL_0537: Expected O, but got I4
		object obj = this + 240;
		obj = playMoreStates;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj2 = (nint)0 + (nint)1888;
		System.Int32Enum int32Enum = ((List<System.Int32Enum>)(object)playMoreStates).get_Item(0);
		if (int32Enum == (System.Int32Enum)1)
		{
			ShowPlayMoreState();
			return;
		}
		System.Int32Enum int32Enum2 = ((List<System.Int32Enum>)(object)playMoreStates).get_Item(0);
		if (int32Enum2 == (System.Int32Enum)2)
		{
			ShowNewTeammateIsTheOnlyOptionState();
			System.Int32Enum int32Enum3 = ((List<System.Int32Enum>)(object)playMoreStates).get_Item(1);
			if (int32Enum3 != (System.Int32Enum)2)
			{
				System.Int32Enum int32Enum4 = ((List<System.Int32Enum>)(object)playMoreStates).get_Item(1);
				if (int32Enum4 != (System.Int32Enum)1)
				{
					System.Int32Enum int32Enum5 = ((List<System.Int32Enum>)(object)playMoreStates).get_Item(1);
				}
			}
			return;
		}
		object obj3 = obj2;
		System.Int32Enum int32Enum6 = ((List<System.Int32Enum>)(object)playMoreStates).get_Item(1);
		bool flag = int32Enum6 == (System.Int32Enum)1;
		int num = 1;
		object obj5;
		UnityEngine.Object sameTeammate;
		UnityEngine.Object obj9;
		object obj10;
		if (!flag)
		{
			obj3 = obj2;
			System.Int32Enum int32Enum7 = ((List<System.Int32Enum>)(object)playMoreStates).get_Item(1);
			bool flag2 = int32Enum7 == (System.Int32Enum)0;
			num = 1;
			if (!flag2)
			{
				System.Int32Enum int32Enum8 = ((List<System.Int32Enum>)(object)playMoreStates).get_Item(1);
				if (int32Enum8 == (System.Int32Enum)2)
				{
					return;
				}
				object obj4 = 152993792;
				obj5 = typeof(MemberAchievementClanFeedData) + 2976;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F6]");
				object obj6 = (nint)0 & (nint)1;
				UnityEngine.Object sameTeammate2;
				if (obj6 != null)
				{
					object obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v45+E4]");
					bool flag3 = (nint)0 == 0;
					sameTeammate = SameTeammate;
					sameTeammate2 = SameTeammate;
					if (!flag3)
					{
						goto IL_0238;
					}
				}
				else
				{
					_ = 1;
					object obj7 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v45+E4]");
					bool flag4 = (nint)0 == 0;
					object obj8 = !flag4;
					sameTeammate = SameTeammate;
					sameTeammate2 = SameTeammate;
					if (obj8 != null)
					{
						goto IL_0238;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag5 = sameTeammate2 != null;
				bool flag6 = !flag5;
				obj9 = null;
				obj10 = 0;
				if (!flag6)
				{
					goto IL_0545;
				}
				return;
			}
		}
		object obj11 = 152993792;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F6]");
		object obj12 = (nint)0 & (nint)1;
		object obj13;
		UnityEngine.Object sameTeammate3;
		object obj15;
		UnityEngine.Object sameTeammate4;
		if (obj12 != null)
		{
			obj13 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v23+E4]");
			bool flag7 = (nint)0 == 0;
			sameTeammate3 = SameTeammate;
			obj15 = obj13;
			sameTeammate4 = SameTeammate;
			if (!flag7)
			{
				goto IL_0316;
			}
		}
		else
		{
			_ = 1;
			obj13 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v23+E4]");
			bool flag8 = (nint)0 == 0;
			object obj16 = !flag8;
			sameTeammate3 = SameTeammate;
			obj15 = obj13;
			sameTeammate4 = SameTeammate;
			if (obj16 != null)
			{
				goto IL_0316;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag9 = sameTeammate4 != null;
		bool flag10 = !flag9;
		UnityEngine.Object obj17 = null;
		object obj18 = 0;
		obj13 = obj15;
		if (!flag10)
		{
			goto IL_0415;
		}
		return;
		IL_05d6:
		ShowNewTeammateIsTheOnlyOptionState();
		return;
		IL_0415:
		object obj19 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X0_v17+E4]");
		if ((nint)0 != 0)
		{
			if (!(NewTeammate != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(NewTeammate != null))
			{
				return;
			}
		}
		goto IL_05d6;
		IL_0238:
		bool flag11 = sameTeammate != null;
		bool flag12 = !flag11;
		object obj20 = !flag12;
		obj9 = null;
		obj10 = 0;
		if (obj20 == null)
		{
			return;
		}
		goto IL_0545;
		IL_0545:
		object obj21 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v40+E4]");
		bool flag13 = (nint)0 == 0;
		object obj22 = !flag13;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (!(NewTeammate != null) || timeIsUp)
		{
			return;
		}
		goto IL_05d6;
		IL_0316:
		bool flag14 = sameTeammate3 != null;
		bool flag15 = !flag14;
		object obj23 = !flag15;
		obj17 = null;
		obj18 = 0;
		if (obj23 == null)
		{
			return;
		}
		goto IL_0415;
	}

	private void UpdatePopupValues()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0274: Expected O, but got I
		//IL_028e: Expected O, but got I4
		//IL_01ad: Expected O, but got I
		//IL_0304: Expected O, but got I
		//IL_0314: Expected O, but got I
		//IL_02cc: Expected O, but got I4
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032d: Expected O, but got Unknown
		//IL_020f: Expected O, but got I
		//IL_021f: Expected O, but got I
		//IL_0241: Expected O, but got I4
		//IL_0380: Expected O, but got I4
		//IL_089b: Expected O, but got I4
		//IL_05fe: Expected O, but got I4
		//IL_0607: Expected O, but got I4
		//IL_064b: Expected I4, but got O
		//IL_08f2: Expected O, but got I4
		//IL_08fb: Expected O, but got I4
		//IL_0687: Expected O, but got I4
		//IL_0690: Expected O, but got I4
		//IL_069e: Expected O, but got I4
		//IL_094d: Expected O, but got I4
		//IL_095b: Expected O, but got I4
		//IL_04d5: Expected O, but got I
		//IL_04ef: Expected O, but got I4
		//IL_040e: Expected O, but got I
		//IL_09a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Expected O, but got Unknown
		//IL_09bf: Expected O, but got I
		//IL_09cd: Expected I, but got O
		//IL_0565: Expected O, but got I
		//IL_0575: Expected O, but got I
		//IL_052d: Expected O, but got I4
		//IL_0aa6: Expected O, but got I4
		//IL_0719: Expected O, but got I4
		//IL_0722: Expected O, but got I4
		//IL_0470: Expected O, but got I
		//IL_0480: Expected O, but got I
		//IL_04a2: Expected O, but got I4
		//IL_0776: Expected I4, but got O
		//IL_0a35: Expected O, but got I4
		//IL_0a3e: Expected O, but got I4
		//IL_0a47: Expected O, but got I4
		//IL_0a50: Expected O, but got I4
		//IL_0b87: Expected O, but got I4
		//IL_0b98: Expected O, but got I4
		//IL_07b0: Expected O, but got I4
		//IL_07dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected O, but got Unknown
		//IL_080b: Expected O, but got I4
		//IL_083e: Expected I, but got O
		//IL_084e: Expected O, but got I
		//IL_085e: Expected O, but got I
		//IL_0bf4: Expected O, but got I4
		//IL_0c05: Expected O, but got I4
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89BD]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v101+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v101+E4]");
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
		obj3 = obj5;
		goto IL_0137;
		IL_073d:
		object obj8;
		object obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v9+E4]");
		bool flag3 = (nint)0 == 0;
		UnityEngine.Object stageRewardRank = StageRewardRank;
		object obj10 = default(object);
		object obj9 = obj10;
		UnityEngine.Object obj11;
		bool flag4 = (byte)(int)obj11 != 0;
		UnityEngine.Object stageRewardRank2 = StageRewardRank;
		if (!flag3)
		{
			goto IL_078e;
		}
		goto IL_0b54;
		IL_06f5:
		UnityEngine.Object yourTeamHasLostIndicator;
		bool flag5 = yourTeamHasLostIndicator != null;
		bool flag6 = !flag5;
		object obj12 = !flag6;
		object obj13 = 0;
		obj11 = null;
		obj9 = obj10;
		if (obj12 == null)
		{
			goto IL_073d;
		}
		goto IL_0ab9;
		IL_06ac:
		yourTeamHasLostIndicator = YourTeamHasLostIndicator;
		object obj14 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X8_v13+E4]");
		bool flag7 = (nint)0 == 0;
		obj9 = obj10;
		UnityEngine.Object yourTeamHasLostIndicator2 = YourTeamHasLostIndicator;
		if (!flag7)
		{
			goto IL_06f5;
		}
		goto IL_0a6d;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag8 = (object)sessionModel == null;
		object obj15 = !flag8;
		if (obj15 != null)
		{
			goto IL_0137;
		}
		goto IL_0bac;
		IL_0137:
		object obj16 = typeof(UsageHint) + 72;
		User localUser = sessionModel.LocalUser;
		int fTLevel = SFSKammelnaUserExtensions.GetFTLevel(localUser);
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
			object obj18 = (nint)0 & (nint)1;
			if (obj18 != null)
			{
				goto IL_01ca;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
			object obj19 = (nint)0 & (nint)1;
			bool flag9 = obj19 == null;
			object obj20 = !flag9;
			if (obj20 != null)
			{
				goto IL_01ca;
			}
		}
		_ = 1;
		object obj21 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v98+E4]");
		bool flag10 = (nint)0 == 0;
		object obj22 = !flag10;
		object obj23 = obj21;
		if (obj22 != null)
		{
			goto IL_01ff;
		}
		goto IL_02e2;
		IL_0bac:
		throw new NullReferenceException();
		IL_07c3:
		RankUI stageRewardRank3 = StageRewardRank;
		object obj24 = typeof(System.Buffers.Text.ParserHelpers) + 1064;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X0_v27+E4]");
		bool flag11 = (nint)0 == 0;
		object obj26 = !flag11;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerRank playerRank = PlayerRank.FastTrackAward();
		nint num = (nint)stageRewardRank3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v18 (Il2CppClass<RankUI>)+1A8]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v18 (Il2CppClass<RankUI>)+1B0]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v283 @ X4_v1 (should have been resolved before IL gen)");
		goto IL_0868;
		IL_078e:
		bool flag12 = stageRewardRank != null;
		bool flag13 = !flag12;
		object obj29 = 0;
		UnityEngine.Object obj30 = null;
		if (!flag13)
		{
			goto IL_07c3;
		}
		return;
		IL_01ca:
		obj21 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v98+E4]");
		bool flag14 = (nint)0 == 0;
		obj23 = obj21;
		if (!flag14)
		{
			goto IL_01ff;
		}
		goto IL_02e2;
		IL_02e2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj31 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v91+B8]");
		object obj32 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v393 @ X8_v58+8]");
		object obj33 = 0;
		goto IL_0319;
		IL_01ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X0_v98+B8]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v65+8]");
		obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v65+8]");
		bool flag15 = (nint)0 == 0;
		object obj35 = !flag15;
		if (obj35 != null)
		{
			goto IL_0319;
		}
		goto IL_0bac;
		IL_0319:
		obj8 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v388 @ X8_v5+20]");
		bool flag16 = (nint)fTLevel > (nint)0;
		UnityEngine.Object obj36 = null;
		int fTStage;
		object obj43;
		object obj45;
		if (!flag16)
		{
			object obj37 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X0_v68+E4]");
			bool flag17 = (nint)0 == 0;
			object obj38 = !flag17;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			fTStage = SFSKammelnaUserExtensions.GetFTStage(localUser2);
			object obj39 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X0_v74+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
				object obj40 = (nint)0 & (nint)1;
				if (obj40 != null)
				{
					goto IL_042b;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D2]");
				object obj41 = (nint)0 & (nint)1;
				bool flag18 = obj41 == null;
				object obj42 = !flag18;
				if (obj42 != null)
				{
					goto IL_042b;
				}
			}
			_ = 1;
			obj43 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v85+E4]");
			bool flag19 = (nint)0 == 0;
			object obj44 = !flag19;
			obj45 = obj43;
			if (obj44 != null)
			{
				goto IL_0460;
			}
			goto IL_0543;
		}
		goto IL_05ab;
		IL_0b54:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag20 = stageRewardRank2 != null;
		bool flag21 = !flag20;
		object obj46 = !flag21;
		obj10 = obj9;
		obj29 = 0;
		obj30 = null;
		if (obj46 == null)
		{
			return;
		}
		goto IL_07c3;
		IL_08ae:
		ClaimRank.interactable = false;
		UnityEngine.Object continueCup = ContinueCup;
		object obj47 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v36+E4]");
		bool flag22 = (nint)0 == 0;
		object obj48 = !flag22;
		object obj49 = 0;
		bool flag23 = false;
		UnityEngine.Object continueCup2 = ContinueCup;
		if (obj48 != null)
		{
			goto IL_0663;
		}
		goto IL_091c;
		IL_0868:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag24 = ClaimRank != null;
		bool flag25 = !flag24;
		obj49 = 0;
		UnityEngine.Object obj50 = null;
		if (flag25)
		{
			goto IL_061a;
		}
		goto IL_08ae;
		IL_0a6d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag26 = yourTeamHasLostIndicator2 != null;
		bool flag27 = !flag26;
		obj10 = obj9;
		obj13 = 0;
		obj11 = null;
		if (flag27)
		{
			goto IL_073d;
		}
		goto IL_0ab9;
		IL_0969:
		Button continueCup3 = ContinueCup;
		continueCup3.m_OnClick.RemoveAllListeners();
		Button continueCup4 = ContinueCup;
		object obj51 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj52 = (nint)0 + (nint)2512;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj52);
		continueCup4.m_OnClick.AddListener(unityAction);
		Button continueCup5 = ContinueCup;
		continueCup5.m_OnClick.Invoke();
		yourTeamHasLostIndicator = YourTeamHasLostIndicator;
		obj14 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v567 @ X8_v13+E4]");
		bool flag28 = (nint)0 == 0;
		object obj53 = !flag28;
		obj10 = 0;
		obj9 = 0;
		object obj54 = 0;
		UnityEngine.Object obj55 = null;
		yourTeamHasLostIndicator2 = YourTeamHasLostIndicator;
		if (obj53 != null)
		{
			goto IL_06f5;
		}
		goto IL_0a6d;
		IL_091c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag29 = continueCup2 != null;
		bool flag30 = !flag29;
		obj54 = 0;
		obj55 = null;
		object obj56 = 0;
		if (flag30)
		{
			goto IL_06ac;
		}
		goto IL_0969;
		IL_042b:
		obj43 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v85+E4]");
		bool flag31 = (nint)0 == 0;
		obj45 = obj43;
		if (!flag31)
		{
			goto IL_0460;
		}
		goto IL_0543;
		IL_0543:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj57 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v78+B8]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v45+8]");
		object obj59 = 0;
		goto IL_057a;
		IL_0460:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X0_v85+B8]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v52+8]");
		obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v52+8]");
		bool flag32 = (nint)0 == 0;
		object obj61 = !flag32;
		if (obj61 != null)
		{
			goto IL_057a;
		}
		goto IL_0bac;
		IL_057a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v591 @ X8_v42+24]");
		bool flag33 = (nint)fTStage <= (nint)0;
		obj36 = null;
		obj55 = null;
		if (!flag33)
		{
			goto IL_05ab;
		}
		goto IL_06ac;
		IL_05ab:
		object obj62 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v243 @ X8_v26+E4]");
		if ((nint)0 == 0)
		{
			goto IL_0868;
		}
		bool flag34 = ClaimRank != null;
		bool flag35 = !flag34;
		object obj63 = !flag35;
		obj49 = 0;
		obj50 = null;
		if (obj63 == null)
		{
			goto IL_061a;
		}
		goto IL_08ae;
		IL_0ab9:
		FastTrackPopupManager fastTrackPopupManager = manager;
		CardGameEndScores cardGameScore = fastTrackPopupManager.cardGameScore;
		int myTeamIndex = fastTrackPopupManager.game.MyTeamIndex;
		GameObject gameObject;
		if (cardGameScore.<WinnerTeamIndex>k__BackingField == myTeamIndex)
		{
			gameObject = YourTeamHasLostIndicator.gameObject;
			flag4 = false;
		}
		else
		{
			gameObject = YourTeamHasLostIndicator.gameObject;
			flag4 = true;
		}
		gameObject.SetActive(flag4);
		stageRewardRank = StageRewardRank;
		obj7 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X0_v9+E4]");
		bool flag36 = (nint)0 == 0;
		object obj64 = !flag36;
		obj10 = obj9;
		obj13 = 0;
		stageRewardRank2 = StageRewardRank;
		if (obj64 != null)
		{
			goto IL_078e;
		}
		goto IL_0b54;
		IL_061a:
		continueCup = ContinueCup;
		obj47 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X8_v36+E4]");
		bool flag37 = (nint)0 == 0;
		flag23 = (byte)(int)obj50 != 0;
		continueCup2 = ContinueCup;
		if (!flag37)
		{
			goto IL_0663;
		}
		goto IL_091c;
		IL_0663:
		bool flag38 = continueCup != null;
		bool flag39 = !flag38;
		object obj65 = !flag39;
		obj54 = 0;
		obj55 = null;
		obj56 = 0;
		if (obj65 == null)
		{
			goto IL_06ac;
		}
		goto IL_0969;
	}

	private void OnTimeIsUp()
	{
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03e1: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_003b: Expected O, but got I4
		//IL_0055: Expected O, but got I4
		//IL_0465: Expected O, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0134: Expected O, but got I4
		//IL_0146: Expected O, but got I4
		//IL_00d3: Expected O, but got I4
		//IL_00dc: Expected O, but got I4
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_0318: Expected O, but got I4
		//IL_00fc: Expected O, but got I4
		//IL_037f: Expected O, but got I4
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01e3: Expected O, but got I4
		//IL_024a: Expected O, but got I4
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		timeIsUp = true;
		bool flag = playMoreStates == null;
		IntPtr intPtr = default(IntPtr);
		int num = (int)(nint)intPtr;
		object obj2;
		object obj9;
		object obj3;
		if (!flag)
		{
			obj2 = (nint)0 + (nint)1888;
			obj3 = obj2;
			System.Int32Enum int32Enum = ((List<System.Int32Enum>)(object)playMoreStates).get_Item(0);
			object obj4 = int32Enum + 1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			num = 0;
			if (obj5 == null)
			{
				object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v31+E4]");
				if ((nint)0 != 0)
				{
					bool flag3 = SameTeammate != null;
					bool flag4 = !flag3;
					object obj8 = !flag4;
					obj9 = 0;
					if (obj8 != null)
					{
						goto IL_0154;
					}
					num = 0;
					obj3 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag5 = SameTeammate != null;
					bool flag6 = !flag5;
					obj9 = 0;
					num = 0;
					obj3 = 0;
					if (!flag6)
					{
						goto IL_0154;
					}
				}
			}
			goto IL_0276;
		}
		goto IL_03a3;
		IL_0276:
		ITrackEvent trackEvent;
		ITrackEvent trackEvent2;
		object obj13;
		int num2;
		if (playMoreStates != null)
		{
			obj3 = obj2;
			System.Int32Enum int32Enum2 = ((List<System.Int32Enum>)(object)playMoreStates).get_Item(0);
			bool flag7 = int32Enum2 != (System.Int32Enum)2;
			num = 0;
			if (!flag7)
			{
				object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X0_v24+E4]");
				bool flag8 = (nint)0 == 0;
				object obj12 = !flag8;
				if (obj12 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				SFSConfig currentSFS = Config.CurrentSFS;
				trackEvent = TrackerLibrary.FastTrackWaitTeammateApprovalTimerUp(currentSFS.<FTPlayMoreTimer>k__BackingField);
				obj13 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v5+E4]");
				bool flag9 = (nint)0 == 0;
				object obj14 = !flag9;
				if (obj14 != null)
				{
					goto IL_047b;
				}
				num2 = 0;
				trackEvent2 = trackEvent;
				goto IL_0485;
			}
		}
		goto IL_03a3;
		IL_03a3:
		object obj15 = typeof(RegisteredWaitHandle) + 56;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v11+E4]");
		bool flag10 = (nint)0 == 0;
		object obj17 = !flag10;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		int matchMakerTimerSeconds = current.<FastTrack>k__BackingField.MatchMakerTimerSeconds;
		trackEvent = TrackerLibrary.FastTrackUnmatchedAfterTimeUp(TrackingPlacement.InGame, matchMakerTimerSeconds);
		obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v5+E4]");
		bool flag11 = (nint)0 == 0;
		num2 = matchMakerTimerSeconds;
		obj3 = 0;
		trackEvent2 = trackEvent;
		if (!flag11)
		{
			goto IL_047b;
		}
		goto IL_0485;
		IL_0485:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent2);
		return;
		IL_047b:
		Tracker.DesignEvent(trackEvent);
		return;
		IL_0154:
		GameObject gameObject = SameTeammate.gameObject;
		bool activeSelf = gameObject.activeSelf;
		bool flag12 = !activeSelf;
		num = 0;
		obj3 = obj9;
		if (flag12)
		{
			goto IL_0276;
		}
		ShowNewTeammateIsTheOnlyOptionState();
		object obj18 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v37+E4]");
		bool flag13 = (nint)0 == 0;
		object obj20 = !flag13;
		if (obj20 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SFSConfig currentSFS2 = Config.CurrentSFS;
		trackEvent = TrackerLibrary.FastTrackSameTeammateTimerUp(currentSFS2.<FTPlayMoreTimer>k__BackingField);
		obj13 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v5+E4]");
		bool flag14 = (nint)0 == 0;
		object obj21 = !flag14;
		if (obj21 != null)
		{
			goto IL_047b;
		}
		num2 = 0;
		obj3 = obj9;
		trackEvent2 = trackEvent;
		goto IL_0485;
	}

	private bool IsWaitingForTeammate()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0152: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00f0: Expected O, but got I4
		//IL_01a7: Expected O, but got I4
		//IL_01b0: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89F6]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object sameTeammate;
		UnityEngine.Object sameTeammate2;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			sameTeammate = SameTeammate;
			sameTeammate2 = SameTeammate;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			sameTeammate = SameTeammate;
			sameTeammate2 = SameTeammate;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = sameTeammate2 != null;
		bool flag4 = !flag3;
		object obj6 = !flag4;
		object obj7 = 0;
		UnityEngine.Object obj8 = null;
		if (obj6 != null)
		{
			goto IL_00c6;
		}
		goto IL_01c3;
		IL_00c6:
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v11+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		return NewTeammate != null;
		IL_01c3:
		return flag3;
		IL_0091:
		flag3 = sameTeammate != null;
		bool flag6 = !flag3;
		obj7 = 0;
		obj8 = null;
		if (!flag6)
		{
			goto IL_00c6;
		}
		goto IL_01c3;
	}

	public void OnStartNewCupClick()
	{
		manager.MatchMe();
		ShowPlayMoreState();
	}

	public void OnSameTeammateButtonClick()
	{
		manager.PlayMoreWithSameTeammate();
	}

	public void OnNewTeammateButtonClick()
	{
		manager.PlayMoreWithNewTeammate();
		ShowPlayMoreState();
	}

	public void OnExitGameClick()
	{
		manager.ExitGame();
		ShrinkToParent();
	}

	public void OnContinueCupClick()
	{
		manager.NextStage();
	}

	public void OnClaimRankClick()
	{
		manager.ClaimRank(alsoExitGame: true);
		ShrinkToParent();
	}

	public void OnShowRoundboardClick()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010c: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_00c2: Expected O, but got I
		//IL_00d2: Expected O, but got I
		//IL_0144: Expected O, but got I
		//IL_0154: Expected O, but got I
		//IL_0176: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(RegisteredWaitHandle) + 1520;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89BF]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_00dc;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = obj4;
		if (!flag)
		{
			goto IL_0085;
		}
		goto IL_0122;
		IL_0122:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v5+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+40]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+40]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00aa;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v10+40]");
		obj8 = 0;
		goto IL_00aa;
		IL_00aa:
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v8+1E8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v8+1F0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v59 @ X2_v1 (should have been resolved before IL gen)");
		goto IL_00dc;
		IL_00dc:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		obj5 = obj4;
		if (obj14 != null)
		{
			goto IL_0085;
		}
		goto IL_0122;
	}

	public void OnStopMatchingClick()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_013f: Expected O, but got I4
		//IL_0148: Expected O, but got I4
		//IL_0080: Expected O, but got I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00e4: Expected O, but got I
		//IL_00f2: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		manager.StopMatching();
		ShowNewTeammateIsTheOnlyOptionState();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			bool flag = NewTeammate != null;
			bool flag2 = !flag;
			object obj3 = 0;
			if (flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = NewTeammate != null;
			bool flag4 = !flag3;
			object obj4 = !flag4;
			object obj3 = 0;
			if (obj4 == null)
			{
				return;
			}
		}
		Button newTeammate = NewTeammate;
		newTeammate.m_OnClick.RemoveAllListeners();
		Button newTeammate2 = NewTeammate;
		object obj5 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = (nint)0 + (nint)2512;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj6);
		newTeammate2.m_OnClick.AddListener(unityAction);
	}

	public void OpenPopup()
	{
		UpdatePopupValues();
		PopFromCenter();
	}

	public void ClosePopup()
	{
		ShrinkToParent();
	}

	public void ClosePopupImmediately()
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<FastTrackResultPopup>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<FastTrackResultPopup>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void ShowUndeterminedState()
	{
		ShowNewTeammateIsTheOnlyOptionState();
	}

	private void ShowPlayMoreState()
	{
		//IL_0503: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0230: Expected O, but got I4
		//IL_0072: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		//IL_032c: Expected O, but got I4
		//IL_0113: Expected O, but got I4
		//IL_011c: Expected O, but got I4
		//IL_0276: Expected O, but got I
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_02be: Expected O, but got I4
		//IL_01a0: Expected I4, but got O
		//IL_0566: Expected O, but got I4
		//IL_056f: Expected F4, but got I4
		//IL_0578: Expected F4, but got I4
		//IL_0581: Expected F4, but got I4
		//IL_0597: Expected F4, but got I4
		//IL_05a0: Expected F4, but got I4
		//IL_05a9: Expected F4, but got I4
		//IL_05bf: Expected O, but got I4
		//IL_0395: Expected O, but got I4
		//IL_03be: Expected O, but got I4
		//IL_0430: Expected O, but got I4
		//IL_01dc: Expected O, but got I4
		//IL_01e5: Expected O, but got I4
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0481: Expected O, but got I4
		//IL_04d2: Expected F4, but got I4
		bool flag = !showPlayMoreStateIsActive;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		ResetStates();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v4+E4]");
		object obj5;
		UnityEngine.Object obj6;
		if ((nint)0 != 0)
		{
			bool flag2 = MatchingStatusShort != null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			obj5 = 0;
			obj6 = null;
			if (obj4 == null)
			{
				goto IL_008e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = MatchingStatusShort != null;
			bool flag5 = !flag4;
			obj5 = 0;
			obj6 = null;
			if (flag5)
			{
				goto IL_008e;
			}
		}
		GameObject gameObject = MatchingStatusShort.gameObject;
		gameObject.SetActive(value: true);
		object obj7 = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj8 = typeof(SqlSingle[]) + 3912;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v21+E4]");
		bool flag6 = (nint)0 == 0;
		object obj10 = !flag6;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform rect = default(Transform);
		AnimationExtensions.AnimPulsing(rect);
		UnityEngine.Object cancelMatching = CancelMatching;
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v16+E4]");
		bool flag7 = (nint)0 == 0;
		object obj12 = !flag7;
		float num = 0f;
		float num2 = 0f;
		float num3 = 1.06199776E+09f;
		double num4 = 1.0;
		float num5 = 0f;
		float num6 = 0f;
		float num7 = 1.06199776E+09f;
		double num8 = 1.0;
		obj5 = 0;
		obj6 = null;
		UnityEngine.Object cancelMatching2 = CancelMatching;
		if (obj12 != null)
		{
			goto IL_00ef;
		}
		goto IL_02db;
		IL_033f:
		GameObject gameObject2 = CancelMatching.gameObject;
		gameObject2.SetActive(value: true);
		UnityEngine.Object obj13 = timer;
		object obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v13+E4]");
		bool flag8 = (nint)0 == 0;
		object obj15 = !flag8;
		num = num5;
		num2 = num6;
		num3 = num7;
		num4 = num8;
		object obj16 = 0;
		bool flag9 = true;
		UnityEngine.Object obj17 = timer;
		if (obj15 != null)
		{
			goto IL_01b8;
		}
		goto IL_03df;
		IL_01b8:
		bool flag10 = obj13 != null;
		bool flag11 = !flag10;
		object obj18 = !flag11;
		object obj19 = 0;
		UnityEngine.Object obj20 = null;
		if (obj18 != null)
		{
			goto IL_0443;
		}
		goto IL_04d7;
		IL_03df:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag12 = obj17 != null;
		bool flag13 = !flag12;
		num = num5;
		num2 = num6;
		num3 = num7;
		num4 = num8;
		obj19 = 0;
		obj20 = null;
		if (!flag13)
		{
			goto IL_0443;
		}
		goto IL_04d7;
		IL_014f:
		obj13 = timer;
		obj14 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X8_v13+E4]");
		bool flag14 = (nint)0 == 0;
		num5 = num;
		num6 = num2;
		num7 = num3;
		num8 = num4;
		UnityEngine.Object obj21;
		flag9 = (byte)(int)obj21 != 0;
		obj17 = timer;
		if (!flag14)
		{
			goto IL_01b8;
		}
		goto IL_03df;
		IL_04d7:
		showPlayMoreStateIsActive = true;
		return;
		IL_0443:
		object obj22 = typeof(RegisteredWaitHandle) + 56;
		object obj23 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v9+E4]");
		bool flag15 = (nint)0 == 0;
		object obj24 = !flag15;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfigModel current = RemoteConfig.Current;
		int matchMakerTimerSeconds = current.<FastTrack>k__BackingField.MatchMakerTimerSeconds;
		timer.StartTimer(matchMakerTimerSeconds);
		goto IL_04d7;
		IL_008e:
		cancelMatching = CancelMatching;
		obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v16+E4]");
		bool flag16 = (nint)0 == 0;
		num5 = num;
		num6 = num2;
		num7 = num3;
		num8 = num4;
		cancelMatching2 = CancelMatching;
		if (!flag16)
		{
			goto IL_00ef;
		}
		goto IL_02db;
		IL_02db:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag17 = cancelMatching2 != null;
		bool flag18 = !flag17;
		num = num5;
		num2 = num6;
		num3 = num7;
		num4 = num8;
		obj16 = 0;
		obj21 = null;
		if (flag18)
		{
			goto IL_014f;
		}
		goto IL_033f;
		IL_00ef:
		bool flag19 = cancelMatching != null;
		bool flag20 = !flag19;
		object obj25 = !flag20;
		obj16 = 0;
		obj21 = null;
		num5 = num;
		num6 = num2;
		num7 = num3;
		num8 = num4;
		if (obj25 == null)
		{
			goto IL_014f;
		}
		goto IL_033f;
	}

	private void ResetStates()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0563: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_00c9: Expected O, but got I4
		//IL_0615: Expected O, but got I4
		//IL_061e: Expected O, but got I4
		//IL_010d: Expected I4, but got O
		//IL_05ac: Expected O, but got I4
		//IL_0149: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_0670: Expected O, but got I4
		//IL_06b6: Expected O, but got I
		//IL_06d3: Expected O, but got I4
		//IL_07c8: Expected O, but got I4
		//IL_01e2: Expected O, but got I4
		//IL_01eb: Expected O, but got I4
		//IL_024f: Expected I4, but got O
		//IL_0701: Expected O, but got I
		//IL_070f: Expected O, but got I4
		//IL_0743: Expected O, but got I4
		//IL_0753: Expected O, but got I
		//IL_0766: Expected O, but got I4
		//IL_076f: Expected O, but got I4
		//IL_0831: Expected O, but got I4
		//IL_084a: Expected O, but got I4
		//IL_08ac: Expected O, but got I4
		//IL_028b: Expected O, but got I4
		//IL_0294: Expected O, but got I4
		//IL_02f8: Expected I4, but got O
		//IL_0915: Expected O, but got I4
		//IL_092e: Expected O, but got I4
		//IL_0990: Expected O, but got I4
		//IL_0334: Expected O, but got I4
		//IL_033d: Expected O, but got I4
		//IL_0a7c: Expected O, but got I4
		//IL_03d5: Expected O, but got I4
		//IL_03de: Expected O, but got I4
		//IL_09d6: Expected O, but got I
		//IL_09ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f4: Expected O, but got Unknown
		//IL_0a1e: Expected O, but got I4
		//IL_0c8a: Expected O, but got I4
		//IL_0ca3: Expected O, but got I4
		//IL_0b68: Expected O, but got I4
		//IL_0476: Expected O, but got I4
		//IL_047f: Expected O, but got I4
		//IL_0ac2: Expected O, but got I
		//IL_0adb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae0: Expected O, but got Unknown
		//IL_0b0a: Expected O, but got I4
		//IL_04d3: Expected I4, but got O
		//IL_0cfd: Expected O, but got I4
		//IL_0d16: Expected O, but got I4
		//IL_0bd1: Expected O, but got I4
		//IL_0bea: Expected O, but got I4
		//IL_0c3e: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E89C2]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object sameTeammate;
		UnityEngine.Object sameTeammate2;
		if (obj3 != null)
		{
			showPlayMoreStateIsActive = false;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v80+E4]");
			bool flag = (nint)0 == 0;
			sameTeammate = SameTeammate;
			sameTeammate2 = SameTeammate;
			if (!flag)
			{
				goto IL_009c;
			}
		}
		else
		{
			_ = 1;
			showPlayMoreStateIsActive = false;
			sameTeammate = SameTeammate;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v80+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			sameTeammate2 = SameTeammate;
			if (obj5 != null)
			{
				goto IL_009c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = sameTeammate2 != null;
		bool flag4 = !flag3;
		object obj6 = 0;
		UnityEngine.Object obj7 = null;
		if (flag4)
		{
			goto IL_00dc;
		}
		goto IL_05bf;
		IL_0b7b:
		GameObject gameObject = CancelMatching.gameObject;
		gameObject.SetActive(value: false);
		UnityEngine.Object obj8 = timer;
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v4+E4]");
		bool flag5 = (nint)0 == 0;
		object obj10 = !flag5;
		object obj12;
		object obj11 = obj12;
		Vector2 vector2;
		Vector2 vector = vector2;
		object obj13 = 0;
		bool flag6 = false;
		UnityEngine.Object obj14 = timer;
		if (obj10 != null)
		{
			goto IL_04eb;
		}
		goto IL_0c0b;
		IL_0452:
		UnityEngine.Object cancelMatching;
		bool flag7 = cancelMatching != null;
		bool flag8 = !flag7;
		object obj15 = !flag8;
		obj13 = 0;
		UnityEngine.Object obj16 = null;
		obj12 = obj11;
		vector2 = vector;
		if (obj15 == null)
		{
			goto IL_04a2;
		}
		goto IL_0b7b;
		IL_0b27:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object cancelMatching2;
		bool flag9 = cancelMatching2 != null;
		bool flag10 = !flag9;
		obj11 = obj12;
		vector = vector2;
		obj13 = 0;
		obj16 = null;
		if (flag10)
		{
			goto IL_04a2;
		}
		goto IL_0b7b;
		IL_009c:
		bool flag11 = sameTeammate != null;
		bool flag12 = !flag11;
		object obj17 = !flag12;
		obj6 = 0;
		obj7 = null;
		if (obj17 == null)
		{
			goto IL_00dc;
		}
		goto IL_05bf;
		IL_05bf:
		GameObject gameObject2 = SameTeammate.gameObject;
		gameObject2.SetActive(value: false);
		UnityEngine.Object newTeammate = NewTeammate;
		object obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v72+E4]");
		bool flag13 = (nint)0 == 0;
		object obj19 = !flag13;
		obj6 = 0;
		bool flag14 = false;
		UnityEngine.Object newTeammate2 = NewTeammate;
		if (obj19 != null)
		{
			goto IL_0125;
		}
		goto IL_063f;
		IL_00dc:
		obj18 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v112 @ X0_v72+E4]");
		bool flag15 = (nint)0 == 0;
		newTeammate = NewTeammate;
		flag14 = (byte)(int)obj7 != 0;
		newTeammate2 = NewTeammate;
		if (!flag15)
		{
			goto IL_0125;
		}
		goto IL_063f;
		IL_063f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag16 = newTeammate2 != null;
		bool flag17 = !flag16;
		object obj20 = 0;
		UnityEngine.Object obj21 = null;
		if (flag17)
		{
			goto IL_0165;
		}
		goto IL_0683;
		IL_0125:
		bool flag18 = newTeammate != null;
		bool flag19 = !flag18;
		object obj22 = !flag19;
		obj20 = 0;
		obj21 = null;
		if (obj22 == null)
		{
			goto IL_0165;
		}
		goto IL_0683;
		IL_0683:
		GameObject gameObject3 = NewTeammate.gameObject;
		gameObject3.SetActive(value: false);
		object obj23 = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		RectTransform rectTransform = default(RectTransform);
		rectTransform.pivot = (Vector2)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		vector = NewTeammateButtonOriginalSize;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FastTrackResultPopup)+EC]");
		obj11 = 0;
		RectTransform rectTransform2 = default(RectTransform);
		rectTransform2.sizeDelta = (Vector2)0;
		UnityEngine.Object startNewCup = StartNewCup;
		object obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v29+E4]");
		bool flag20 = (nint)0 == 0;
		object obj25 = !flag20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FastTrackResultPopup)+EC]");
		obj12 = 0;
		vector2 = NewTeammateButtonOriginalSize;
		obj20 = 0;
		Vector2 vector3 = (Vector2)0;
		UnityEngine.Object startNewCup2 = StartNewCup;
		if (obj25 != null)
		{
			goto IL_01be;
		}
		goto IL_0787;
		IL_0165:
		startNewCup = StartNewCup;
		obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v29+E4]");
		bool flag21 = (nint)0 == 0;
		obj12 = obj11;
		vector2 = vector;
		vector3 = (Vector2)obj21;
		startNewCup2 = StartNewCup;
		if (!flag21)
		{
			goto IL_01be;
		}
		goto IL_0787;
		IL_0787:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag22 = startNewCup2 != null;
		bool flag23 = !flag22;
		obj11 = obj12;
		vector = vector2;
		object obj26 = 0;
		UnityEngine.Object obj27 = null;
		if (flag23)
		{
			goto IL_020e;
		}
		goto IL_07db;
		IL_01be:
		bool flag24 = startNewCup != null;
		bool flag25 = !flag24;
		object obj28 = !flag25;
		obj26 = 0;
		obj27 = null;
		obj12 = obj11;
		vector2 = vector;
		if (obj28 == null)
		{
			goto IL_020e;
		}
		goto IL_07db;
		IL_07db:
		GameObject gameObject4 = StartNewCup.gameObject;
		gameObject4.SetActive(value: false);
		UnityEngine.Object continueCup = ContinueCup;
		object obj29 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v26+E4]");
		bool flag26 = (nint)0 == 0;
		object obj30 = !flag26;
		obj11 = obj12;
		vector = vector2;
		obj26 = 0;
		bool flag27 = false;
		UnityEngine.Object continueCup2 = ContinueCup;
		if (obj30 != null)
		{
			goto IL_0267;
		}
		goto IL_086b;
		IL_020e:
		continueCup = ContinueCup;
		obj29 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v26+E4]");
		bool flag28 = (nint)0 == 0;
		obj12 = obj11;
		vector2 = vector;
		flag27 = (byte)(int)obj27 != 0;
		continueCup2 = ContinueCup;
		if (!flag28)
		{
			goto IL_0267;
		}
		goto IL_086b;
		IL_086b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag29 = continueCup2 != null;
		bool flag30 = !flag29;
		obj11 = obj12;
		vector = vector2;
		object obj31 = 0;
		UnityEngine.Object obj32 = null;
		if (flag30)
		{
			goto IL_02b7;
		}
		goto IL_08bf;
		IL_0267:
		bool flag31 = continueCup != null;
		bool flag32 = !flag31;
		object obj33 = !flag32;
		obj31 = 0;
		obj32 = null;
		obj12 = obj11;
		vector2 = vector;
		if (obj33 == null)
		{
			goto IL_02b7;
		}
		goto IL_08bf;
		IL_08bf:
		GameObject gameObject5 = ContinueCup.gameObject;
		gameObject5.SetActive(value: false);
		UnityEngine.Object matchingStatusShort = MatchingStatusShort;
		object obj34 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v23+E4]");
		bool flag33 = (nint)0 == 0;
		object obj35 = !flag33;
		obj11 = obj12;
		vector = vector2;
		obj31 = 0;
		bool flag34 = false;
		UnityEngine.Object matchingStatusShort2 = MatchingStatusShort;
		if (obj35 != null)
		{
			goto IL_0310;
		}
		goto IL_094f;
		IL_02b7:
		matchingStatusShort = MatchingStatusShort;
		obj34 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v23+E4]");
		bool flag35 = (nint)0 == 0;
		obj12 = obj11;
		vector2 = vector;
		flag34 = (byte)(int)obj32 != 0;
		matchingStatusShort2 = MatchingStatusShort;
		if (!flag35)
		{
			goto IL_0310;
		}
		goto IL_094f;
		IL_094f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag36 = matchingStatusShort2 != null;
		bool flag37 = !flag36;
		obj11 = obj12;
		vector = vector2;
		object obj36 = 0;
		UnityEngine.Object obj37 = null;
		if (flag37)
		{
			goto IL_0360;
		}
		goto IL_09a3;
		IL_0310:
		bool flag38 = matchingStatusShort != null;
		bool flag39 = !flag38;
		object obj38 = !flag39;
		obj36 = 0;
		obj37 = null;
		obj12 = obj11;
		vector2 = vector;
		if (obj38 == null)
		{
			goto IL_0360;
		}
		goto IL_09a3;
		IL_09a3:
		GameObject gameObject6 = MatchingStatusShort.gameObject;
		gameObject6.SetActive(value: false);
		object obj39 = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj40 = typeof(SqlSingle[]) + 3912;
		object obj41 = obj40;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X8_v21+E4]");
		bool flag40 = (nint)0 == 0;
		object obj42 = !flag40;
		if (obj42 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform rect = default(Transform);
		AnimationExtensions.AnimEndAnimation(rect);
		UnityEngine.Object matchingStatusLong = MatchingStatusLong;
		object obj43 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v27+E4]");
		bool flag41 = (nint)0 == 0;
		object obj44 = !flag41;
		obj11 = obj12;
		vector = vector2;
		obj36 = 0;
		obj37 = null;
		UnityEngine.Object matchingStatusLong2 = MatchingStatusLong;
		if (obj44 != null)
		{
			goto IL_03b1;
		}
		goto IL_0a3b;
		IL_0c0b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag42 = obj14 != null;
		bool flag43 = !flag42;
		object obj45 = !flag43;
		if (obj45 == null)
		{
			return;
		}
		goto IL_0512;
		IL_04a2:
		obj8 = timer;
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v585 @ X8_v4+E4]");
		bool flag44 = (nint)0 == 0;
		flag6 = (byte)(int)obj16 != 0;
		obj14 = timer;
		if (!flag44)
		{
			goto IL_04eb;
		}
		goto IL_0c0b;
		IL_0360:
		obj43 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X0_v27+E4]");
		bool flag45 = (nint)0 == 0;
		matchingStatusLong = MatchingStatusLong;
		obj12 = obj11;
		vector2 = vector;
		matchingStatusLong2 = MatchingStatusLong;
		if (!flag45)
		{
			goto IL_03b1;
		}
		goto IL_0a3b;
		IL_0a3b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag46 = matchingStatusLong2 != null;
		bool flag47 = !flag46;
		obj11 = obj12;
		vector = vector2;
		object obj46 = 0;
		UnityEngine.Object obj47 = null;
		if (flag47)
		{
			goto IL_0401;
		}
		goto IL_0a8f;
		IL_03b1:
		bool flag48 = matchingStatusLong != null;
		bool flag49 = !flag48;
		object obj48 = !flag49;
		obj46 = 0;
		obj47 = null;
		obj12 = obj11;
		vector2 = vector;
		if (obj48 == null)
		{
			goto IL_0401;
		}
		goto IL_0a8f;
		IL_0a8f:
		GameObject gameObject7 = MatchingStatusLong.gameObject;
		gameObject7.SetActive(value: false);
		object obj49 = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj50 = typeof(SqlSingle[]) + 3912;
		object obj51 = obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v613 @ X8_v13+E4]");
		bool flag50 = (nint)0 == 0;
		object obj52 = !flag50;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Transform rect2 = default(Transform);
		AnimationExtensions.AnimEndAnimation(rect2);
		cancelMatching = CancelMatching;
		object obj53 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X0_v13+E4]");
		bool flag51 = (nint)0 == 0;
		object obj54 = !flag51;
		obj11 = obj12;
		vector = vector2;
		obj46 = 0;
		obj47 = null;
		cancelMatching2 = CancelMatching;
		if (obj54 != null)
		{
			goto IL_0452;
		}
		goto IL_0b27;
		IL_0512:
		timer.Hide();
		return;
		IL_04eb:
		if (obj8 != null)
		{
			goto IL_0512;
		}
		return;
		IL_0401:
		obj53 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X0_v13+E4]");
		bool flag52 = (nint)0 == 0;
		cancelMatching = CancelMatching;
		obj12 = obj11;
		vector2 = vector;
		cancelMatching2 = CancelMatching;
		if (!flag52)
		{
			goto IL_0452;
		}
		goto IL_0b27;
	}

	private void ShowPlayMoreSameTeammateState()
	{
		ShowNewTeammateIsTheOnlyOptionState();
	}

	private void UpdatePlayMoreSameTeammateState(bool teammateApproved)
	{
	}

	public void ShowNewTeammateIsTheOnlyOptionState()
	{
		//IL_0641: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0293: Expected O, but got I4
		//IL_0072: Expected O, but got I4
		//IL_007b: Expected O, but got I4
		//IL_0448: Expected O, but got I4
		//IL_010b: Expected O, but got I4
		//IL_0114: Expected O, but got I4
		//IL_02d9: Expected O, but got I
		//IL_0178: Expected I4, but got O
		//IL_02f6: Expected O, but got I4
		//IL_04b1: Expected O, but got I4
		//IL_04ca: Expected O, but got I4
		//IL_052c: Expected O, but got I4
		//IL_01b4: Expected O, but got I4
		//IL_01bd: Expected O, but got I4
		//IL_0211: Expected I4, but got O
		//IL_0595: Expected O, but got I4
		//IL_05ae: Expected O, but got I4
		//IL_033f: Expected O, but got I
		//IL_024d: Expected O, but got I4
		//IL_037d: Expected O, but got I4
		//IL_03b1: Expected O, but got I4
		//IL_03c7: Expected O, but got I4
		//IL_03dd: Expected O, but got I4
		//IL_03e6: Expected O, but got I4
		//IL_03ef: Expected O, but got I4
		bool flag = !showNewTeammateIsTheOnlyOptionStateIsActive;
		object obj = !flag;
		if (obj != null)
		{
			return;
		}
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		ResetStates();
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v4+E4]");
		UnityEngine.Object obj6;
		object obj5;
		if ((nint)0 != 0)
		{
			bool flag2 = NewTeammate != null;
			bool flag3 = !flag2;
			object obj4 = !flag3;
			obj5 = 0;
			obj6 = null;
			if (obj4 == null)
			{
				goto IL_008e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = NewTeammate != null;
			bool flag5 = !flag4;
			obj5 = 0;
			obj6 = null;
			if (flag5)
			{
				goto IL_008e;
			}
		}
		GameObject gameObject = NewTeammate.gameObject;
		gameObject.SetActive(value: true);
		object obj7 = (nint)0 + (nint)4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		RectTransform rectTransform = default(RectTransform);
		rectTransform.pivot = (Vector2)0;
		Transform transform = NewTeammate.transform;
		Transform parent = transform.parent;
		GameObject gameObject2 = parent.gameObject;
		object obj8 = (nint)0 + (nint)1360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		RectTransform rectTransform2 = default(RectTransform);
		Vector2 sizeDelta = rectTransform2.sizeDelta;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		RectTransform rectTransform3 = default(RectTransform);
		rectTransform3.sizeDelta = (Vector2)0;
		UnityEngine.Object continueCup = ContinueCup;
		object obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v16+E4]");
		bool flag6 = (nint)0 == 0;
		object obj10 = !flag6;
		double num = 0.5;
		object obj11 = 0;
		double num2 = 0.5;
		object obj12 = 0;
		obj5 = 0;
		Vector2 vector = (Vector2)0;
		UnityEngine.Object continueCup2 = ContinueCup;
		if (obj10 != null)
		{
			goto IL_00e7;
		}
		goto IL_0407;
		IL_05cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj13;
		if (obj13 != null)
		{
			goto IL_0605;
		}
		goto IL_0615;
		IL_0615:
		showNewTeammateIsTheOnlyOptionStateIsActive = true;
		return;
		IL_0605:
		timer.Hide();
		goto IL_0615;
		IL_0229:
		UnityEngine.Object obj14;
		bool flag7 = obj14 != null;
		bool flag8 = !flag7;
		object obj15 = !flag8;
		if (obj15 != null)
		{
			goto IL_0605;
		}
		goto IL_0615;
		IL_008e:
		continueCup = ContinueCup;
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v16+E4]");
		bool flag9 = (nint)0 == 0;
		num2 = num;
		obj12 = obj11;
		vector = (Vector2)obj6;
		continueCup2 = ContinueCup;
		if (!flag9)
		{
			goto IL_00e7;
		}
		goto IL_0407;
		IL_0407:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag10 = continueCup2 != null;
		bool flag11 = !flag10;
		num = num2;
		obj11 = obj12;
		object obj16 = 0;
		UnityEngine.Object obj17 = null;
		if (flag11)
		{
			goto IL_0137;
		}
		goto IL_045b;
		IL_00e7:
		bool flag12 = continueCup != null;
		bool flag13 = !flag12;
		object obj18 = !flag13;
		obj16 = 0;
		obj17 = null;
		num2 = num;
		obj12 = obj11;
		if (obj18 == null)
		{
			goto IL_0137;
		}
		goto IL_045b;
		IL_045b:
		GameObject gameObject3 = ContinueCup.gameObject;
		gameObject3.SetActive(value: true);
		UnityEngine.Object startNewCup = StartNewCup;
		object obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v13+E4]");
		bool flag14 = (nint)0 == 0;
		object obj20 = !flag14;
		num = num2;
		obj11 = obj12;
		obj16 = 0;
		bool flag15 = true;
		UnityEngine.Object startNewCup2 = StartNewCup;
		if (obj20 != null)
		{
			goto IL_0190;
		}
		goto IL_04eb;
		IL_0137:
		startNewCup = StartNewCup;
		obj19 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v13+E4]");
		bool flag16 = (nint)0 == 0;
		num2 = num;
		obj12 = obj11;
		flag15 = (byte)(int)obj17 != 0;
		startNewCup2 = StartNewCup;
		if (!flag16)
		{
			goto IL_0190;
		}
		goto IL_04eb;
		IL_04eb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag17 = startNewCup2 != null;
		bool flag18 = !flag17;
		num = num2;
		obj11 = obj12;
		object obj21 = 0;
		UnityEngine.Object obj22 = null;
		if (flag18)
		{
			goto IL_01e0;
		}
		goto IL_053f;
		IL_0190:
		bool flag19 = startNewCup != null;
		bool flag20 = !flag19;
		object obj23 = !flag20;
		obj21 = 0;
		obj22 = null;
		num2 = num;
		obj12 = obj11;
		if (obj23 == null)
		{
			goto IL_01e0;
		}
		goto IL_053f;
		IL_053f:
		GameObject gameObject4 = StartNewCup.gameObject;
		gameObject4.SetActive(value: true);
		obj14 = timer;
		object obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v10+E4]");
		bool flag21 = (nint)0 == 0;
		object obj25 = !flag21;
		num = num2;
		obj11 = obj12;
		obj21 = 0;
		bool flag22 = true;
		obj13 = timer;
		if (obj25 != null)
		{
			goto IL_0229;
		}
		goto IL_05cf;
		IL_01e0:
		obj24 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v371 @ X0_v10+E4]");
		bool flag23 = (nint)0 == 0;
		obj14 = timer;
		flag22 = (byte)(int)obj22 != 0;
		obj13 = timer;
		if (!flag23)
		{
			goto IL_0229;
		}
		goto IL_05cf;
	}
}
