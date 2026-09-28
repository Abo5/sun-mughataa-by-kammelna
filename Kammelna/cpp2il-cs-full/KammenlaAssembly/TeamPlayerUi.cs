using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using ListView;
using Mono.Btls;
using Sfs2X.Entities;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TeamPlayerUi : ListViewItem<QueuePlayer, int>
{
	private AvatarInitializer avatar;

	private Graphic[] statusIndicator;

	private GameObject[] placeholder;

	private Button selectButton;

	private Button kickButton;

	private GameObject placeholderAdd;

	private TextMeshProUGUI userNameText;

	private Color highlightColor;

	private Color requestColor;

	private Color responseColor;

	private Color rejectColor;

	private TournamentSceneEventsChannel tournamentEventsChannel;

	private bool isOwner;

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_019a: Expected O, but got I4
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_01ff: Expected O, but got I
		//IL_0217: Expected I, but got O
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0294: Expected O, but got I4
		//IL_02de: Expected O, but got I4
		//IL_02e7: Expected O, but got I4
		//IL_02f0: Expected O, but got I4
		//IL_02f9: Expected O, but got I4
		//IL_04a6: Expected O, but got I
		//IL_04b4: Expected I, but got O
		//IL_0575: Expected O, but got I4
		//IL_058e: Expected O, but got I4
		//IL_0332: Expected O, but got I4
		//IL_04ff: Expected O, but got I4
		//IL_0508: Expected O, but got I4
		//IL_0511: Expected O, but got I4
		//IL_051a: Expected O, but got I4
		//IL_0523: Expected O, but got I4
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_036a: Expected O, but got I
		//IL_0378: Expected I, but got O
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_03bb: Expected O, but got I
		//IL_03c9: Expected I, but got O
		//IL_03fa: Expected I, but got O
		//IL_042b: Expected I, but got O
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6D99]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v47+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v47+E4]");
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
		IL_02ac:
		UnityEngine.Object obj8 = placeholderAdd;
		object obj10;
		object obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v9+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = 0;
		object obj12 = 0;
		object obj13 = 0;
		object obj14 = 0;
		UnityEngine.Object obj15 = placeholderAdd;
		if (!flag3)
		{
			goto IL_0311;
		}
		goto IL_0543;
		IL_0311:
		bool flag4 = obj8;
		bool flag5 = !flag4;
		object obj16 = 0;
		if (!flag5)
		{
			goto IL_0340;
		}
		return;
		IL_0340:
		object obj17 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)1320;
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj18);
		tournamentEventsChannel.OnPlayersSelected += action;
		object obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)1304;
		Action<int> action2 = default(Action<int>);
		action2..ctor((object)this, (IntPtr)obj20);
		tournamentEventsChannel.OnSeatSelected += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action3 = default(Action<int>);
		action3..ctor((object)this, (IntPtr)obj20);
		tournamentEventsChannel.OnTeamSelected += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action4 = default(Action<int>);
		action4..ctor((object)this, (IntPtr)obj20);
		tournamentEventsChannel.OnKickPlayer += action4;
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag6 = (object)sessionModel == null;
		object obj21 = !flag6;
		if (obj21 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
		IL_0140:
		Room currentRoom = sessionModel.CurrentRoom;
		int originalOwnerId = SFSKammelnaRoomExtensions.GetOriginalOwnerId(currentRoom);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		User localUser = sessionModel2.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		object obj22 = originalOwnerId - intDbId;
		bool flag7 = obj22 == null;
		isOwner = flag7;
		AvatarInitializer avatarInitializer = avatar;
		avatarInitializer.<TrackingPlacement>k__BackingField = TrackingPlacement.TournamentTeams;
		Button button = selectButton;
		object obj23 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj24 = (nint)0 + (nint)1328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj24);
		obj10 = typeof(MemberAchievementClanFeedData) + 2976;
		button.m_OnClick.AddListener(unityAction);
		object obj25 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v7+E4]");
		UnityAction unityAction2;
		if ((nint)0 != 0)
		{
			bool flag8 = kickButton;
			bool flag9 = !flag8;
			object obj26 = !flag9;
			unityAction2 = null;
			UnityAction unityAction3 = null;
			if (obj26 == null)
			{
				goto IL_02ac;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag10 = kickButton;
			bool flag11 = !flag10;
			unityAction2 = null;
			UnityAction unityAction3 = null;
			if (flag11)
			{
				goto IL_02ac;
			}
		}
		Button button2 = kickButton;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)1312;
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(this, (IntPtr)obj27);
		button2.m_OnClick.AddListener(unityAction4);
		obj8 = placeholderAdd;
		obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v9+E4]");
		bool flag12 = (nint)0 == 0;
		object obj28 = !flag12;
		obj11 = 0;
		obj12 = 0;
		obj13 = 0;
		obj14 = 0;
		unityAction2 = unityAction4;
		obj15 = placeholderAdd;
		if (obj28 != null)
		{
			goto IL_0311;
		}
		goto IL_0543;
		IL_0543:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag13 = obj15;
		bool flag14 = !flag13;
		object obj29 = !flag14;
		obj11 = obj13;
		obj12 = obj14;
		obj16 = 0;
		if (obj29 == null)
		{
			return;
		}
		goto IL_0340;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0100: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_00a2: Expected I, but got O
		//IL_00d3: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 272;
		object obj2 = (nint)0 + (nint)1320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj4 = (nint)0 + (nint)1304;
		tournamentEventsChannel.OnPlayersSelected -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action2 = default(Action<int>);
		action2..ctor((object)this, (IntPtr)obj4);
		tournamentEventsChannel.OnSeatSelected -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action3 = default(Action<int>);
		action3..ctor((object)this, (IntPtr)obj4);
		tournamentEventsChannel.OnTeamSelected -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action4 = default(Action<int>);
		action4..ctor((object)this, (IntPtr)obj4);
		tournamentEventsChannel.OnKickPlayer -= action4;
	}

	private void Select()
	{
		//IL_001c: Expected O, but got I
		TournamentSceneEventsChannel tournamentSceneEventsChannel = tournamentEventsChannel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamPlayerUi)+40]");
		tournamentSceneEventsChannel.TriggerSelectingPlayer((QueuePlayer)0);
	}

	private void Kick()
	{
		//IL_0042: Expected O, but got I
		//IL_0015: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamPlayerUi)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
		object obj2 = 0;
		TournamentSceneEventsChannel tournamentSceneEventsChannel = tournamentEventsChannel;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v5+10]");
		tournamentSceneEventsChannel.TriggerKickPlayer(0);
	}

	public override void Setup(QueuePlayer datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_074d: Expected O, but got I
		//IL_0047: Expected O, but got I
		//IL_0256: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_0118: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_015d: Expected O, but got I
		//IL_0171: Expected O, but got I
		//IL_02c1: Expected F8, but got I4
		//IL_01b5: Expected O, but got I
		//IL_075a: Expected I, but got O
		//IL_0765: Expected O, but got I
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0478: Expected O, but got I4
		//IL_01fe: Expected O, but got I
		//IL_0310: Expected O, but got I
		//IL_022b: Expected O, but got I4
		//IL_022b: Expected O, but got I
		//IL_0238: Expected O, but got I4
		//IL_0325: Expected O, but got I
		//IL_057c: Expected O, but got I
		//IL_0711: Expected O, but got I4
		//IL_05a8: Expected O, but got I
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected O, but got Unknown
		//IL_05be: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Expected O, but got Unknown
		//IL_05dd: Expected O, but got I4
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		//IL_0388: Expected O, but got I4
		//IL_0526: Expected O, but got I
		//IL_03b1: Expected O, but got I
		//IL_0685: Expected O, but got I
		//IL_06af: Expected O, but got I4
		//IL_06d1: Expected O, but got I
		//IL_05fb: Expected O, but got I
		//IL_03f4: Expected O, but got I
		//IL_0429: Expected O, but got I4
		//IL_056b: Expected O, but got I4
		//IL_063e: Expected O, but got I
		object obj = (nint)0 + (nint)1920;
		bool flag = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, flag);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamPlayerUi)+40]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v3+10]");
			if (((PlayerInfo)0).IsHuman)
			{
				TogglePlaceholder(active: false);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamPlayerUi)+40]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v57+10]");
				AvatarData avatarData = (PlayerInfo)0;
				avatar.Initialize(avatarData);
				flag = false;
				goto IL_00cb;
			}
		}
		TogglePlaceholder(active: true);
		goto IL_00cb;
		IL_0507:
		Transform transform = placeholderAdd.transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamPlayerUi)+40]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v15+20]");
		if ((nint)0 == 1)
		{
		}
		transform.localScale = (Vector3)0;
		return;
		IL_06df:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj5;
		bool flag2 = obj5;
		bool flag3 = !flag2;
		object obj6 = !flag3;
		bool flag4;
		flag = flag4;
		if (obj6 == null)
		{
			return;
		}
		goto IL_0507;
		IL_0300:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamPlayerUi)+40]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v36+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v36+10]");
		Component component;
		bool flag8;
		if ((nint)0 != 0)
		{
			object obj9 = typeof(Queue<string>) + 848;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X0_v42+E4]");
			bool flag5 = (nint)0 == 0;
			object obj11 = !flag5;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj12 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v37+10]");
			object obj13 = -intDbId;
			bool flag6 = obj13 == null;
			component = kickButton;
			bool flag7 = (object)kickButton == null;
			object obj14 = !flag7;
			flag8 = flag6;
			if (obj14 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0A0]");
			component = (Component)0;
			flag8 = false;
		}
		GameObject gameObject = component.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF100]");
		object obj15 = ~(nint)0;
		object obj16 = flag8 | obj15;
		object obj17 = obj16 & 1;
		bool flag9 = obj17 == null;
		object obj18 = !flag9;
		bool active;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF040]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v44+20]");
			if ((nint)0 == 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v44+1C]");
				object obj20 = (nint)0 + (nint)1;
				bool flag10 = obj20 == null;
				active = flag10;
				goto IL_0668;
			}
		}
		active = false;
		goto IL_0668;
		IL_00cb:
		Graphic[] array = statusIndicator;
		if (array.Length >= 1)
		{
			object obj21 = array + 32;
			object obj23 = default(object);
			object obj22 = obj23;
			object obj24 = 0;
			float duration = default(float);
			do
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X23_v6+v215 @ X22_v7*8]");
				GameObject gameObject2 = ((Component)0).gameObject;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamPlayerUi)+40]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X8_v52+20]");
				bool flag11 = (nint)0 == 0;
				bool active2 = !flag11;
				gameObject2.SetActive(active2);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamPlayerUi)+40]");
				object obj26 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v54+20]");
				bool flag12 = (nint)0 == 0;
				flag = false;
				if (!flag12)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X23_v6+v215 @ X22_v7*8]");
					int num = ShortcutExtensions.DOKill((Component)0);
					Color statusColor = GetStatusColor();
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X23_v6+v215 @ X22_v7*8]");
					TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOColor((Graphic)0, (Color)0, duration);
					obj22 = 1050253722;
					flag = false;
				}
				obj24++;
			}
			while ((nint)obj24 < array.Length);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamPlayerUi)+40]");
		object obj27 = 0;
		TextMeshProUGUI textMeshProUGUI = userNameText;
		object obj28 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X8_v8+20]");
		if ((nint)0 == 5)
		{
			double num2 = 1.0;
		}
		else
		{
			double num2 = 0.0;
		}
		nint num3 = (nint)textMeshProUGUI;
		textMeshProUGUI.color = (Color)0;
		object obj29 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X8_v11+E4]");
		if ((nint)0 != 0)
		{
			bool flag13 = kickButton;
			bool flag14 = !flag13;
			bool flag15 = false;
			active = false;
			if (!flag14)
			{
				goto IL_0300;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag16 = kickButton;
			bool flag17 = !flag16;
			object obj30 = !flag17;
			bool flag15 = false;
			active = false;
			if (obj30 != null)
			{
				goto IL_0300;
			}
		}
		object obj31 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v12+E4]");
		bool flag18 = (nint)0 == 0;
		UnityEngine.Object obj32 = placeholderAdd;
		flag4 = flag;
		obj5 = placeholderAdd;
		if (!flag18)
		{
			goto IL_04e1;
		}
		goto IL_06df;
		IL_0668:
		gameObject.SetActive(active);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0A8]");
		obj32 = (UnityEngine.Object)0;
		obj31 = obj28;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v12+E4]");
		bool flag19 = (nint)0 == 0;
		object obj33 = !flag19;
		flag = false;
		flag4 = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0A8]");
		obj5 = (UnityEngine.Object)0;
		if (obj33 != null)
		{
			goto IL_04e1;
		}
		goto IL_06df;
		IL_04e1:
		if ((bool)obj32)
		{
			goto IL_0507;
		}
	}

	private Color GetStatusColor()
	{
		//IL_023e: Expected O, but got I
		//IL_012e: Expected O, but got I
		//IL_0160: Expected O, but got I
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_0211: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TeamPlayerUi)+40]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X9_v1+20]");
		if ((nint)0 <= (nint)2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X9_v1+20]");
			if ((nint)0 == 0)
			{
				return (Color)this;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X9_v1+20]");
			if ((nint)0 != 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X9_v1+20]");
				if ((nint)0 != 2)
				{
					goto IL_0154;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X9_v1+1C]");
				object obj2 = (nint)0 + (nint)1;
				if (obj2 != null)
				{
					goto IL_014b;
				}
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X9_v1+20]");
			if ((nint)0 != 3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X9_v1+20]");
				if ((nint)0 == 4)
				{
					goto IL_014b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X9_v1+20]");
				if ((nint)0 != 5)
				{
					goto IL_0154;
				}
			}
		}
		return (Color)this;
		IL_014b:
		return (Color)this;
		IL_0154:
		object obj3 = (nint)0 + (nint)1928;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		object obj4 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3944;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj5 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj6 = "com.unity.services.authentication.profile" + 3040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, null);
		object obj7 = (nint)0 + (nint)1296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (Color)new OutOfMemoryException();
	}

	private void TogglePlaceholder(bool active)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0074: Expected O, but got I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_009c: Expected O, but got I
		GameObject gameObject = avatar.gameObject;
		bool active2 = (byte)((active ? 1u : 0u) ^ 1u) != 0;
		gameObject.SetActive(active2);
		GameObject[] array = placeholder;
		if (array.Length >= 1)
		{
			object obj = array + 32;
			object obj2 = 0;
			do
			{
				obj2++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X22_v4+v25 @ X21_v5*8]");
				((GameObject)0).SetActive(active);
			}
			while ((nint)obj2 < array.Length);
		}
	}

	private void OnPlayersSelected(IEnumerable<QueuePlayer> players)
	{
		bool active = Enumerable.Any((IEnumerable<object>)players);
		placeholderAdd.SetActive(active);
	}

	private void HidePlaceholder(int seat)
	{
		placeholderAdd.SetActive(value: false);
	}

	public TeamPlayerUi()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}
}
