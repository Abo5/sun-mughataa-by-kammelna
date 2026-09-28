using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class ChatMessageOptions : MonoBehaviour
{
	private sealed class <>c__DisplayClass31_0
	{
		public string userId;

		internal void <OnMuteClick>g___Unblock|0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e3: Expected O, but got I4
			//IL_00ec: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E761A]");
			object obj2 = (nint)0 & (nint)1;
			int num;
			int num2;
			if (obj2 != null)
			{
				num = int.Parse(userId);
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = 0;
				num2 = num;
				if (!flag)
				{
					goto IL_0094;
				}
			}
			else
			{
				_ = 1;
				num = int.Parse(userId);
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v2+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = 0;
				num2 = num;
				if (obj5 != null)
				{
					goto IL_0094;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			FriendsManager.UnblockUser(num2);
			return;
			IL_0094:
			FriendsManager.UnblockUser(num);
		}

		internal void <OnMuteClick>g___Block|1()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00e3: Expected O, but got I4
			//IL_00ec: Expected O, but got I4
			//IL_007e: Expected O, but got I4
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E761B]");
			object obj2 = (nint)0 & (nint)1;
			int num;
			int num2;
			if (obj2 != null)
			{
				num = int.Parse(userId);
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v2+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = 0;
				num2 = num;
				if (!flag)
				{
					goto IL_0094;
				}
			}
			else
			{
				_ = 1;
				num = int.Parse(userId);
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v2+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = 0;
				num2 = num;
				if (obj5 != null)
				{
					goto IL_0094;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			FriendsManager.BlockUser(num2);
			return;
			IL_0094:
			FriendsManager.BlockUser(num);
		}
	}

	private sealed class <>c__DisplayClass34_0
	{
		public ChatMessageOptions <>4__this;

		public ChatMessageData capturedMessageData;

		internal void <OpenModPicker>b__0()
		{
			<>4__this.OpenMassTournamentModOptions(capturedMessageData);
		}

		internal void <OpenModPicker>b__1()
		{
			<>4__this.OpenKickAndMuteOptions(capturedMessageData);
		}
	}

	private sealed class <>c__DisplayClass35_0
	{
		public ChatMessageData capturedMessageData;

		internal void <OpenMassTournamentModOptions>b__0(MassModeratorControlPopup instance)
		{
			ChatMessageData chatMessageData = capturedMessageData;
			instance.ShowForUser(chatMessageData.<UserId>k__BackingField);
		}
	}

	private sealed class <>c__DisplayClass36_0
	{
		public ChatMessageData capturedMessageData;

		internal void <OpenKickAndMuteOptions>b__0(ModeratorControl instance)
		{
			instance.ShowMessageForUser(capturedMessageData);
		}
	}

	private GameObject blocker;

	private RectTransform panel;

	private Button modOptionsButton;

	private Button reportButton;

	private Button profileButton;

	private Button muteButton;

	private Button challengeButton;

	private ChallengeEventsChannel eventsChannel;

	private ComponentReference<ModeratorControl> modControlRef;

	private ComponentReference<MassModeratorControlPopup> massModControlRef;

	private CanvasGroup canvasGroup;

	private ChatMessageDataHolder _data;

	private const int slideDistance = 50;

	private float originalScale;

	private ChatMessageData _messageData
	{
		get
		{
			ChatMessageDataHolder data = _data;
			if (_data != null)
			{
				return data.<message>k__BackingField;
			}
			return (ChatMessageData)(object)new NullReferenceException();
		}
	}

	private Room room
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00dc: Expected O, but got I
			//IL_0106: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_014f: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7609]");
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
			goto IL_015d;
			IL_00b8:
			return sessionModel.CurrentRoom;
			IL_015d:
			return (Room)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_015d;
		}
	}

	private TournamentData Tournament
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ee: Expected O, but got I
			//IL_0118: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0161: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7609]");
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
			return SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom);
			IL_016f:
			return (TournamentData)(object)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_016f;
		}
	}

	private MassTournamentInfo MassTournament
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ee: Expected O, but got I
			//IL_0118: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0161: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7609]");
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
			return SFSKammelnaRoomExtensions.GetMassTournamentInfo(currentRoom);
			IL_016f:
			return (MassTournamentInfo)(object)new NullReferenceException();
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_016f;
		}
	}

	private static bool IsModerator
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01c9: Expected O, but got I4
			//IL_0244: Expected I4, but got O
			object obj = 152989696;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E760A]");
			object obj3 = (nint)0 & (nint)1;
			object obj6;
			object obj4;
			if (obj3 != null)
			{
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
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
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			obj4 = obj6;
			if (!flag3)
			{
				goto IL_0158;
			}
			goto IL_0236;
			IL_0236:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0158:
			User localUser = sessionModel.LocalUser;
			if (SFSKammelnaUserExtensions.Can(localUser, UserPermission.KickAndMutePlayers))
			{
				return true;
			}
			object obj8 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v6+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			if ((object)sessionModel2 != null)
			{
				User localUser2 = sessionModel2.LocalUser;
				return SFSKammelnaUserExtensions.Can(localUser2, UserPermission.ManageMassTournament);
			}
			goto IL_0236;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag5 = (object)sessionModel == null;
			object obj10 = !flag5;
			if (obj10 != null)
			{
				goto IL_0158;
			}
			goto IL_0236;
		}
	}

	private bool IsBlocked
	{
		get
		{
			//IL_0123: Expected I4, but got O
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Expected O, but got Unknown
			//IL_0086: Expected O, but got I4
			//IL_0107: Expected I8, but got I4
			//IL_00eb: Expected I8, but got I4
			ChatMessageDataHolder data = _data;
			if (_data != null)
			{
				ChatMessageData <message>k__BackingField = data.<message>k__BackingField;
				if (data.<message>k__BackingField != null)
				{
					object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
					object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
					object obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v3+E4]");
					bool flag = (nint)0 == 0;
					object obj4 = !flag;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int num = Convert.ToInt32(<message>k__BackingField.<UserId>k__BackingField);
					object obj5 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v7+E4]");
					if ((nint)0 != 0)
					{
						return FriendsManager.IsBlocked(num);
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					return FriendsManager.IsBlocked(num);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private void Awake()
	{
		//IL_0056: Expected O, but got I
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		GameObject gameObject = panel.gameObject;
		gameObject.SetActive(value: true);
		Vector3 localScale = panel.localScale;
		float num = default(float);
		originalScale = num;
		object obj = (nint)0 + (nint)3664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 112;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((CanvasGroup)obj2).alpha = 0f;
		((CanvasGroup)obj2).blocksRaycasts = false;
		GameObject gameObject2 = modOptionsButton.gameObject;
		bool isModerator = IsModerator;
		gameObject2.SetActive(isModerator);
		RegisterEvents();
		ChatMessageDataHolder data = _data;
		if (_data != null && data.<message>k__BackingField != null)
		{
			UpdateButtons();
		}
	}

	private void RegisterEvents()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		//IL_00b9: Expected O, but got I
		//IL_00d1: Expected I, but got O
		//IL_0103: Expected O, but got I
		//IL_011b: Expected I, but got O
		//IL_014d: Expected O, but got I
		//IL_0165: Expected I, but got O
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_018a: Expected O, but got I
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01be: Expected O, but got I
		//IL_01ed: Expected I, but got O
		//IL_0217: Expected O, but got I4
		//IL_025a: Expected I, but got O
		Button button = modOptionsButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = reportButton;
		object obj3 = (nint)0 + (nint)344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
		Button button3 = profileButton;
		object obj4 = (nint)0 + (nint)336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj4);
		button3.m_OnClick.AddListener(unityAction3);
		Button button4 = muteButton;
		object obj5 = (nint)0 + (nint)328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction4 = default(UnityAction);
		unityAction4..ctor(this, (IntPtr)obj5);
		button4.m_OnClick.AddListener(unityAction4);
		Button button5 = challengeButton;
		object obj6 = (nint)0 + (nint)296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction5 = default(UnityAction);
		unityAction5..ctor(this, (IntPtr)obj6);
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)304;
		object obj9 = typeof(RegisteredWaitHandle) + 56;
		object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj11 = (nint)0 + (nint)312;
		button5.m_OnClick.AddListener(unityAction5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj8);
		object obj12 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v21+E4]");
		bool flag = (nint)0 == 0;
		object obj13 = !flag;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj11);
		ChatHandler.OnGroupChange += action2;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_009d: Expected O, but got I
		//IL_00b5: Expected I, but got O
		//IL_00df: Expected O, but got I4
		//IL_006e: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)304;
		object obj3 = typeof(RegisteredWaitHandle) + 56;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj5 = (nint)0 + (nint)312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj5);
		ChatHandler.OnGroupChange -= action2;
	}

	private void OnConfigChanged()
	{
		ChatMessageDataHolder data = _data;
		if (_data != null && data.<message>k__BackingField != null)
		{
			UpdateButtons();
		}
	}

	private void OnChallengeClick()
	{
		ChatMessageDataHolder data = _data;
		ChatMessageData <message>k__BackingField = data.<message>k__BackingField;
		int userID = int.Parse(<message>k__BackingField.<UserId>k__BackingField);
		eventsChannel.TriggerOnChallengeCreateStarted(userID);
	}

	private void OnMuteClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01a9: Expected I, but got O
		//IL_01b9: Expected O, but got I
		//IL_0263: Expected O, but got I4
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00b1: Expected I, but got O
		//IL_00c1: Expected O, but got I
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bb: Expected O, but got Unknown
		//IL_03d3: Expected O, but got I
		//IL_01f4: Expected O, but got I
		//IL_016b: Expected O, but got I4
		//IL_02af: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02db: Expected O, but got I
		//IL_00fc: Expected O, but got I
		//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b73: Expected O, but got Unknown
		//IL_040e: Expected O, but got I
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Expected O, but got Unknown
		//IL_0589: Expected O, but got I
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0aef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Expected O, but got Unknown
		//IL_0b0a: Expected O, but got I
		//IL_0b1b: Expected I, but got O
		//IL_0316: Expected O, but got I
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_04b2: Expected O, but got I
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_0c1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c22: Expected O, but got Unknown
		//IL_0c38: Expected O, but got I
		//IL_0c49: Expected I, but got O
		//IL_05c4: Expected O, but got I
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		//IL_0751: Expected O, but got I
		//IL_0bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc8: Expected O, but got Unknown
		//IL_04ed: Expected O, but got I
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_07e7: Expected O, but got I
		//IL_080b: Expected O, but got I4
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		//IL_064c: Expected O, but got I
		//IL_0965: Expected O, but got I
		//IL_0985: Expected O, but got I4
		//IL_078c: Expected O, but got I
		//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d7: Expected O, but got Unknown
		//IL_05e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected O, but got Unknown
		//IL_06e2: Expected O, but got I
		//IL_0706: Expected O, but got I4
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Expected O, but got Unknown
		//IL_0a06: Expected O, but got I4
		//IL_0878: Expected O, but got I
		//IL_0898: Expected O, but got I4
		//IL_0687: Expected O, but got I
		//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		//IL_050e: Expected O, but got Unknown
		//IL_09a9: Expected O, but got I
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Expected O, but got Unknown
		//IL_0936: Expected O, but got I
		//IL_0cf8: Expected O, but got I4
		//IL_079a: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Expected O, but got Unknown
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Expected O, but got Unknown
		//IL_08bc: Expected O, but got I
		//IL_0834: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Expected O, but got Unknown
		//IL_0849: Expected O, but got I
		//IL_0a1c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a21: Expected O, but got Unknown
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3c: Expected O, but got Unknown
		//IL_0ccb: Expected O, but got I4
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected O, but got Unknown
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Expected O, but got Unknown
		//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bc: Expected O, but got Unknown
		//IL_09c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ca: Expected O, but got Unknown
		//IL_09e5: Expected O, but got I4
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected O, but got Unknown
		//IL_08d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected O, but got Unknown
		//IL_0906: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		ChatMessageDataHolder data = _data;
		ChatMessageData <message>k__BackingField = data.<message>k__BackingField;
		object obj3 = obj2 + 16;
		obj3 = <message>k__BackingField.<UserId>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool isBlocked = IsBlocked;
		IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
		if (isBlocked)
		{
			object obj4 = typeof(System.IOAsyncCallback) + 392;
			object obj5 = "Complete" + 256;
			nint num = (nint)popupWindowBuilderNeedsTitle;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v48 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v48 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_013d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v48 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
			object obj7 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X10_v59-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				obj7 += 16;
				obj6--;
				if ((nint)obj6 != 1)
				{
					continue;
				}
				goto IL_013d;
			}
			object obj8 = num + obj7;
			object obj9 = obj8 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v319 @ X8_v75] (should have been resolved before IL gen)");
			goto IL_02a0;
		}
		object obj10 = typeof(System.IOAsyncCallback) + 392;
		object label = "AvailableVoices" + 2160;
		nint num2 = (nint)popupWindowBuilderNeedsTitle;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v14 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v14 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0235;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v14 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X10_v31-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_0235;
		}
		object obj13 = num2 + obj12;
		object obj14 = obj13 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v320 @ X8_v43] (should have been resolved before IL gen)");
		goto IL_0398;
		IL_0d06:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v388 @ X8_v6] (should have been resolved before IL gen)");
		Hide();
		return;
		IL_013d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v446 @ X0_v74] (should have been resolved before IL gen)");
		object obj15 = default(object);
		bool flag = obj15 == null;
		object obj16 = !flag;
		if (obj16 != null)
		{
			goto IL_02a0;
		}
		goto IL_0a41;
		IL_0858:
		object obj18;
		object obj17 = obj18;
		object obj20 = default(object);
		object obj19 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X8_v7+12E]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X8_v7+12E]");
		bool flag2 = (nint)0 == 0;
		object obj22 = 0;
		if (flag2)
		{
			goto IL_09f3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X8_v7+B0]");
		object obj23 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ X10_v3-8]");
			bool flag3 = 0 == (nint)obj17;
			obj22 = 0;
			if (flag3)
			{
				break;
			}
			obj23 += 16;
			obj21--;
			if ((nint)obj21 != 1)
			{
				continue;
			}
			goto IL_08fd;
		}
		goto IL_0a13;
		IL_0357:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj25 = default(object);
		object obj24 = obj25;
		goto IL_0ad6;
		IL_0a13:
		object obj26 = obj23 + 9;
		object obj27 = obj19 + obj26;
		object obj28 = obj27 + 312;
		goto IL_0d06;
		IL_0235:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v462 @ X0_v45] (should have been resolved before IL gen)");
		object obj29 = default(object);
		bool flag4 = obj29 == null;
		object obj30 = !flag4;
		if (obj30 != null)
		{
			goto IL_0398;
		}
		goto IL_0a41;
		IL_0398:
		object obj31 = typeof(System.IOAsyncCallback) + 384;
		object obj32 = "AvailableVoices" + 1064;
		object obj33 = obj29;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v20+12E]");
		object obj34 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v20+12E]");
		if ((nint)0 == 0)
		{
			goto IL_044f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v545 @ X8_v20+B0]");
		object obj35 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v639 @ X10_v26-8]");
			if (0 == (nint)obj31)
			{
				break;
			}
			obj35 += 16;
			obj34--;
			if ((nint)obj34 != 1)
			{
				continue;
			}
			goto IL_044f;
		}
		object obj36 = obj33 + obj35;
		object obj37 = obj36 + 312;
		goto IL_0b5a;
		IL_0ad6:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v660 @ X8_v53] (should have been resolved before IL gen)");
		object obj38 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj39 = (nint)0 + (nint)3192;
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj39);
		object label2;
		PopupButton popupButton = PopupButton.Positive((string)label2, action, dismiss: true);
		obj18 = typeof(System.IOAsyncCallback) + 368;
		object obj41 = default(object);
		object obj40 = obj41;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v58+12E]");
		object obj42 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v58+12E]");
		if ((nint)0 == 0)
		{
			goto IL_052e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v724 @ X8_v58+B0]");
		object obj43 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X10_v49-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj43 += 16;
			obj42--;
			if ((nint)obj42 != 1)
			{
				continue;
			}
			goto IL_052e;
		}
		object obj44 = obj40 + obj43;
		object obj45 = obj44 + 312;
		goto IL_0baf;
		IL_07cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v872 @ X0_v34+8]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v872 @ X0_v34] (should have been resolved before IL gen)");
		bool flag5 = obj20 == null;
		object obj47 = !flag5;
		if (obj47 != null)
		{
			goto IL_0945;
		}
		goto IL_0a41;
		IL_0945:
		object obj48;
		obj17 = obj48;
		obj19 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X8_v7+12E]");
		object obj49 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X8_v7+12E]");
		bool flag6 = (nint)0 == 0;
		obj22 = 0;
		if (flag6)
		{
			goto IL_09f3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X8_v7+B0]");
		obj23 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1063 @ X10_v3-8]");
			bool flag7 = 0 == (nint)obj17;
			obj22 = 0;
			if (flag7)
			{
				break;
			}
			obj23 += 16;
			obj49--;
			bool flag8 = (nint)obj49 != 1;
			obj22 = 0;
			if (flag8)
			{
				continue;
			}
			goto IL_09f3;
		}
		goto IL_0a13;
		IL_08fd:
		obj22 = 0;
		goto IL_09f3;
		IL_044f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj50 = default(object);
		obj37 = obj50;
		goto IL_0b5a;
		IL_0b5a:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v675 @ X8_v21] (should have been resolved before IL gen)");
		object label3 = "AvailableVoices" + 768;
		PopupButton popupButton2 = PopupButton.Neutral((string)label3, null, dismiss: true);
		obj48 = typeof(System.IOAsyncCallback) + 368;
		object obj52 = default(object);
		object obj51 = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v24+12E]");
		object obj53 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v24+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0605;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v689 @ X8_v24+B0]");
		object obj54 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v737 @ X10_v21-8]");
			if (0 == (nint)obj48)
			{
				break;
			}
			obj54 += 16;
			obj53--;
			if ((nint)obj53 != 1)
			{
				continue;
			}
			goto IL_0605;
		}
		object obj55 = obj51 + obj54;
		object obj56 = obj55 + 312;
		goto IL_0c04;
		IL_02a0:
		object obj57 = typeof(System.IOAsyncCallback) + 384;
		label2 = "UInt16" + 1312;
		object obj58 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v52+12E]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v52+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0357;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v52+B0]");
		object obj60 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v616 @ X10_v54-8]");
			if (0 == (nint)obj57)
			{
				break;
			}
			obj60 += 16;
			obj59--;
			if ((nint)obj59 != 1)
			{
				continue;
			}
			goto IL_0357;
		}
		object obj61 = obj58 + obj60;
		obj24 = obj61 + 312;
		goto IL_0ad6;
		IL_0a41:
		throw new NullReferenceException();
		IL_052e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0baf;
		IL_09f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj46 = 9;
		object obj62 = default(object);
		obj28 = obj62;
		goto IL_0d06;
		IL_0605:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0c04;
		IL_0c04:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v782 @ X0_v25] (should have been resolved before IL gen)");
		object obj63 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj64 = (nint)0 + (nint)3184;
		Action action2 = default(Action);
		action2..ctor(obj2, (IntPtr)obj64);
		PopupButton popupButton3 = PopupButton.Negative((string)label, action2, dismiss: true);
		object obj66 = default(object);
		object obj65 = obj66;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X8_v31+12E]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X8_v31+12E]");
		if ((nint)0 == 0)
		{
			goto IL_07cd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v838 @ X8_v31+B0]");
		object obj68 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X10_v16-8]");
			if (0 == (nint)obj48)
			{
				break;
			}
			obj68 += 16;
			obj67--;
			if ((nint)obj67 != 1)
			{
				continue;
			}
			goto IL_07cd;
		}
		object obj69 = obj65 + obj68;
		object obj70 = obj69 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v926 @ X0_v37+8]");
		obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v926 @ X0_v37] (should have been resolved before IL gen)");
		goto IL_0945;
		IL_0baf:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v823 @ X0_v56] (should have been resolved before IL gen)");
		object label4 = "AvailableVoices" + 768;
		PopupButton popupButton4 = PopupButton.Neutral((string)label4, null, dismiss: true);
		object obj72 = default(object);
		object obj71 = obj72;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v63+12E]");
		object obj73 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v63+12E]");
		if ((nint)0 == 0)
		{
			goto IL_06c8;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v834 @ X8_v63+B0]");
		object obj74 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v248 @ X10_v44-8]");
			if (0 == (nint)obj18)
			{
				break;
			}
			obj74 += 16;
			obj73--;
			if ((nint)obj73 != 1)
			{
				continue;
			}
			goto IL_06c8;
		}
		object obj75 = obj71 + obj74;
		object obj76 = obj75 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X0_v66+8]");
		obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v901 @ X0_v66] (should have been resolved before IL gen)");
		goto IL_0858;
		IL_06c8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X0_v63+8]");
		obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v856 @ X0_v63] (should have been resolved before IL gen)");
		bool flag9 = obj20 == null;
		object obj77 = !flag9;
		if (obj77 != null)
		{
			goto IL_0858;
		}
		goto IL_0a41;
	}

	private void OnProfileClick()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		ChatMessageDataHolder data = _data;
		ChatMessageData <message>k__BackingField = data.<message>k__BackingField;
		object obj = typeof(MemberAchievementClanFeedData) + 840;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			MiniProfilePopup.Show(<message>k__BackingField.<UserId>k__BackingField, TrackingPlacement.Chat);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		MiniProfilePopup.Show(<message>k__BackingField.<UserId>k__BackingField, TrackingPlacement.Chat);
	}

	private void OnModOptionsClicked()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_021b: Expected O, but got I4
		//IL_0224: Expected O, but got I4
		//IL_022d: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		//IL_01a4: Expected O, but got I4
		//IL_01ce: Expected O, but got I4
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7611]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v20+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v20+E4]");
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
		IL_023b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9;
		object obj8 = obj9;
		goto IL_0252;
		IL_0252:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		bool flag3 = SFSKammelnaUserExtensions.Can(localUser, UserPermission.KickAndMutePlayers);
		ChatMessageDataHolder data = _data;
		object obj10 = obj8 & flag3;
		if ((nint)obj10 == 1)
		{
			OpenModPicker(data.<message>k__BackingField);
			Hide();
		}
		else if (obj8 != null)
		{
			OpenMassTournamentModOptions(data.<message>k__BackingField);
			Hide();
		}
		else
		{
			OpenKickAndMuteOptions(data.<message>k__BackingField);
			Hide();
		}
		return;
		IL_0140:
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		bool flag4 = SFSKammelnaUserExtensions.Can(localUser2, UserPermission.ManageMassTournament);
		if (flag4)
		{
			MassTournamentInfo massTournament = ((ChatMessageOptions)flag4).MassTournament;
			bool flag5 = massTournament == null;
			object obj11 = !flag5;
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v15+E4]");
			bool flag6 = (nint)0 == 0;
			object obj13 = !flag6;
			obj8 = obj11;
			if (obj13 == null)
			{
				obj9 = obj11;
				goto IL_023b;
			}
		}
		else
		{
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v15+E4]");
			bool flag7 = (nint)0 == 0;
			object obj14 = !flag7;
			obj9 = 0;
			obj8 = 0;
			if (obj14 == null)
			{
				goto IL_023b;
			}
		}
		goto IL_0252;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag8 = (object)sessionModel2 == null;
		object obj15 = !flag8;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
	}

	private void OpenModPicker(ChatMessageData capturedMessageData)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_08df: Expected O, but got Unknown
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ec: Expected O, but got Unknown
		//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fa: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0b27: Expected O, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c1: Expected I, but got O
		//IL_00d1: Expected O, but got I
		//IL_0183: Expected O, but got I4
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_022b: Expected O, but got I
		//IL_010c: Expected O, but got I
		//IL_02c9: Expected O, but got I
		//IL_02ed: Expected O, but got I4
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_039e: Expected O, but got I
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03c5: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected I, but got Unknown
		//IL_045c: Expected O, but got I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_09c0: Expected I, but got O
		//IL_0400: Expected O, but got I
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected I, but got Unknown
		//IL_033b: Expected O, but got I
		//IL_04b7: Expected O, but got I4
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected I, but got Unknown
		//IL_04d9: Expected O, but got I
		//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_0500: Expected O, but got I
		//IL_040e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0421: Expected O, but got Unknown
		//IL_0a07: Expected I, but got O
		//IL_0a2c: Expected I, but got O
		//IL_053b: Expected O, but got I
		//IL_05d3: Expected O, but got I4
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Expected O, but got Unknown
		//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f8: Expected O, but got Unknown
		//IL_0610: Expected O, but got I
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected O, but got Unknown
		//IL_0557: Unknown result type (might be due to invalid IL or missing references)
		//IL_055c: Expected O, but got Unknown
		//IL_0a73: Expected I, but got O
		//IL_0aa8: Expected O, but got I4
		//IL_064b: Expected O, but got I
		//IL_06e3: Expected O, but got I
		//IL_06b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06be: Expected O, but got Unknown
		//IL_0779: Expected I, but got O
		//IL_079b: Expected O, but got I4
		//IL_0659: Unknown result type (might be due to invalid IL or missing references)
		//IL_065e: Expected O, but got Unknown
		//IL_0667: Unknown result type (might be due to invalid IL or missing references)
		//IL_066c: Expected O, but got Unknown
		//IL_071e: Expected O, but got I
		//IL_07b9: Expected I, but got O
		//IL_07c9: Expected O, but got I
		//IL_0858: Expected O, but got I4
		//IL_087b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Expected O, but got Unknown
		//IL_0888: Expected I, but got O
		//IL_08ac: Expected O, but got I4
		//IL_08b5: Expected O, but got I4
		//IL_0804: Expected O, but got I
		//IL_072c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0731: Expected O, but got Unknown
		//IL_073a: Unknown result type (might be due to invalid IL or missing references)
		//IL_073f: Expected O, but got Unknown
		//IL_0b01: Expected O, but got I4
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_0817: Expected O, but got Unknown
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7612]");
		nint num = 0;
		object obj = typeof(CardUtils.<>c) + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj8;
		object obj9 = default(object);
		object obj11 = default(object);
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 24;
			obj4 = capturedMessageData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.Create(PopupWindow.MessageType.Action);
			if (popupWindowBuilderNeedsTitle != null)
			{
				object obj5 = typeof(System.IOAsyncCallback) + 392;
				object obj6 = "Material with texture name \"" + 2248;
				nint num2 = (nint)popupWindowBuilderNeedsTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0155;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v10 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
				obj8 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X10_v15-8]");
					if (0 == (nint)obj5)
					{
						break;
					}
					obj9 = obj8 + 16;
					obj7--;
					bool flag = (nint)obj7 != 1;
					obj8 = obj9;
					if (flag)
					{
						continue;
					}
					goto IL_0155;
				}
				object obj10 = num2 + obj8;
				num = (nint)(obj10 + 312);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v331 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
				bool flag2 = obj11 == null;
				obj9 = obj8;
				if (!flag2)
				{
					goto IL_01f0;
				}
			}
		}
		goto IL_08c3;
		IL_07b1:
		NullReferenceException ex = default(NullReferenceException);
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0845;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj9 = (nint)0 + (nint)8;
		object obj13;
		object obj14;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X10_v40-8]");
			bool flag3 = 0 == (nint)obj13;
			obj14 = 0;
			if (flag3)
			{
				break;
			}
			obj9 += 16;
			obj12--;
			if ((nint)obj12 != 1)
			{
				continue;
			}
			goto IL_0845;
		}
		goto IL_08d1;
		IL_0584:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_09ff;
		IL_0449:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj15 = 4;
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		goto IL_099b;
		IL_099b:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v331 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		object obj16;
		action..ctor(obj2, (IntPtr)obj16);
		object label;
		PopupButton popupButton = PopupButton.Neutral((string)label, action, dismiss: true);
		object obj17 = default(object);
		bool flag4 = obj17 == null;
		obj14 = 0;
		obj9 = obj8;
		if (flag4)
		{
			goto IL_08c3;
		}
		object obj18 = (nint)0 + (nint)3208;
		object label2 = "AvailableVoices" + 2168;
		object obj19 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v18+12E]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v18+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0584;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v18+B0]");
		object obj21 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X10_v28-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			obj8 = obj21 + 16;
			obj20--;
			bool flag5 = (nint)obj20 != 1;
			obj21 = obj8;
			if (flag5)
			{
				continue;
			}
			goto IL_0584;
		}
		object obj22 = obj19 + obj21;
		object obj23 = obj22 + 312;
		obj8 = obj21;
		goto IL_09ff;
		IL_08d1:
		object obj24 = obj9 + 9;
		object obj25 = num + obj24;
		object obj26 = obj25 + 312;
		goto IL_0b0f;
		IL_0b0f:
		object obj27 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v3+8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v385 @ X2_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
		IL_0155:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v429 @ X0_v58 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag6 = obj11 == null;
		object obj29 = !flag6;
		obj8 = obj9;
		if (obj29 != null)
		{
			goto IL_01f0;
		}
		IntPtr intPtr2 = default(IntPtr);
		num = intPtr2;
		goto IL_08c3;
		IL_01f0:
		object obj30 = typeof(System.IOAsyncCallback) + 384;
		object obj31 = "Cannot populate JSON object onto type '{0}'." + 2720;
		object obj32 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v14+12E]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v14+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02af;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X8_v14+B0]");
		obj9 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X10_v40-8]");
			if (0 == (nint)obj30)
			{
				break;
			}
			obj8 = obj9 + 16;
			obj33--;
			bool flag7 = (nint)obj33 != 1;
			obj9 = obj8;
			if (flag7)
			{
				continue;
			}
			goto IL_02af;
		}
		object obj34 = obj32 + obj9;
		num = (nint)(obj34 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v4 (Il2CppClass<System.NullReferenceException>)+8]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v331 @ X8_v4 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		object obj35 = default(object);
		bool flag8 = obj35 == null;
		obj8 = obj9;
		if (!flag8)
		{
			goto IL_036a;
		}
		goto IL_08c3;
		IL_08c3:
		ex = new NullReferenceException();
		goto IL_08d1;
		IL_0694:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0a6b;
		IL_0767:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj36 = default(object);
		num = (nint)obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v767 @ X0_v40] (should have been resolved before IL gen)");
		bool flag9 = ex == null;
		obj14 = 0;
		obj9 = obj8;
		if (!flag9)
		{
			goto IL_07b1;
		}
		goto IL_08c3;
		IL_0845:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj14 = 0;
		object obj37 = default(object);
		obj26 = obj37;
		goto IL_0b0f;
		IL_02af:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v494 @ X0_v54 (Il2CppClass<System.NullReferenceException>)+8]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v494 @ X0_v54 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag10 = obj35 == null;
		object obj38 = !flag10;
		if (obj38 != null)
		{
			goto IL_036a;
		}
		obj9 = obj8;
		IntPtr intPtr3 = default(IntPtr);
		num = intPtr3;
		goto IL_08c3;
		IL_036a:
		obj13 = typeof(System.IOAsyncCallback) + 368;
		object obj39 = typeof(SqlSingle[]) + 2376;
		obj16 = (nint)0 + (nint)3200;
		label = "Material with texture name \"" + 2256;
		object obj40 = obj35;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v16+12E]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v16+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0449;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v534 @ X8_v16+B0]");
		object obj42 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v576 @ X10_v33-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			obj8 = obj42 + 16;
			obj41--;
			bool flag11 = (nint)obj41 != 1;
			obj42 = obj8;
			if (flag11)
			{
				continue;
			}
			goto IL_0449;
		}
		object obj43 = obj42 + 4;
		object obj44 = obj40 + obj43;
		num = (nint)(obj44 + 312);
		obj8 = obj42;
		goto IL_099b;
		IL_09ff:
		num = (nint)obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v668 @ X0_v24] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(obj2, (IntPtr)obj18);
		PopupButton popupButton2 = PopupButton.Neutral((string)label2, action2, dismiss: true);
		object obj45 = default(object);
		bool flag12 = obj45 == null;
		obj14 = 0;
		obj9 = obj8;
		if (flag12)
		{
			goto IL_08c3;
		}
		object label3 = "AvailableVoices" + 768;
		object obj46 = obj45;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v21+12E]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v21+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0694;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X8_v21+B0]");
		object obj48 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X10_v23-8]");
			if (0 == (nint)obj13)
			{
				break;
			}
			obj8 = obj48 + 16;
			obj47--;
			bool flag13 = (nint)obj47 != 1;
			obj48 = obj8;
			if (flag13)
			{
				continue;
			}
			goto IL_0694;
		}
		object obj49 = obj46 + obj48;
		object obj50 = obj49 + 312;
		obj8 = obj48;
		goto IL_0a6b;
		IL_0a6b:
		num = (nint)obj50;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v741 @ X0_v31] (should have been resolved before IL gen)");
		PopupButton popupButton3 = PopupButton.Neutral((string)label3, null, dismiss: true);
		object obj51 = default(object);
		bool flag14 = obj51 == null;
		obj14 = 0;
		obj9 = obj8;
		if (!flag14)
		{
			object obj52 = obj51;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v24+12E]");
			object obj53 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v24+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0767;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v749 @ X8_v24+B0]");
			obj9 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X10_v40-8]");
				if (0 == (nint)obj13)
				{
					break;
				}
				obj8 = obj9 + 16;
				obj53--;
				bool flag15 = (nint)obj53 != 1;
				obj9 = obj8;
				if (flag15)
				{
					continue;
				}
				goto IL_0767;
			}
			object obj54 = obj52 + obj9;
			object obj55 = obj54 + 312;
			num = (nint)obj55;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v782 @ X0_v43] (should have been resolved before IL gen)");
			bool flag16 = ex == null;
			object obj56 = !flag16;
			obj14 = 0;
			if (obj56 != null)
			{
				goto IL_07b1;
			}
		}
		goto IL_08c3;
	}

	private void OpenMassTournamentModOptions(ChatMessageData capturedMessageData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0099: Expected I, but got O
		//IL_00c3: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2624;
		object obj4 = (nint)0 + (nint)3216;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)2112;
		object obj7 = obj2 + 16;
		obj7 = capturedMessageData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private void OpenKickAndMuteOptions(ChatMessageData capturedMessageData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0099: Expected I, but got O
		//IL_00c3: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2776;
		object obj4 = (nint)0 + (nint)3224;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj6 = (nint)0 + (nint)2160;
		object obj7 = obj2 + 16;
		obj7 = capturedMessageData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80CF4");
	}

	private void OnReportClick()
	{
		//IL_000c: Expected O, but got I
		//IL_001d: Expected O, but got I
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_008b: Expected O, but got I4
		object obj = (nint)0 + (nint)392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
		object obj2 = (nint)0 + (nint)272;
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v7+E4]");
		UnityEngine.Object obj5 = default(UnityEngine.Object);
		if ((nint)0 != 0)
		{
			bool flag = obj5;
			bool flag2 = !flag;
			object obj6 = !flag2;
			if (obj6 == null)
			{
				goto IL_009a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!obj5)
			{
				goto IL_009a;
			}
		}
		ChatMessageDataHolder data = _data;
		((MessageReportUI)obj5).ShowForMessage(data.<message>k__BackingField);
		Hide();
		return;
		IL_009a:
		Hide();
	}

	public void Show(Vector2 pos, ChatMessageDataHolder messageData)
	{
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00be: Expected O, but got I4
		//IL_0131: Expected O, but got I4
		//IL_0161: Expected O, but got I
		//IL_0171: Expected O, but got I4
		object obj = this + 120;
		Vector2 vector = default(Vector2);
		obj = vector;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UpdateButtons();
		if ((object)blocker != null)
		{
			blocker.SetActive(value: true);
			Transform transform = base.transform;
			if ((object)transform != null)
			{
				transform.SetAsLastSibling();
				if ((object)blocker != null)
				{
					Transform transform2 = blocker.transform;
					if ((object)transform2 != null)
					{
						object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 3600;
						if (transform2 != obj2)
						{
							goto IL_01e9;
						}
						((RectTransform)transform2).anchoredPosition = (Vector2)0;
						if ((object)canvasGroup != null)
						{
							canvasGroup.blocksRaycasts = true;
							if ((object)canvasGroup != null)
							{
								canvasGroup.alpha = 0f;
								if ((object)panel != null)
								{
									panel.anchoredPosition = (Vector2)0;
									AdjustPosition();
									int num = ShortcutExtensions.DOKill(panel, complete: true);
									if ((object)panel != null)
									{
										object obj3 = (nint)0 + (nint)3088;
										panel.localScale = (Vector3)0;
										TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(canvasGroup, 1f, 0.3f);
										TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPosY(panel, 50f, 0.3f);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059474");
										TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale(panel, originalScale, 0.3f);
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_01e9;
		IL_01e9:
		throw new InvalidCastException();
	}

	private void UpdateButtons()
	{
		//IL_0011: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0062: Expected O, but got I4
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01d9: Expected O, but got I4
		//IL_01f5: Expected O, but got I4
		//IL_0207: Expected O, but got I4
		//IL_0187: Expected O, but got I4
		//IL_0190: Expected O, but got I4
		//IL_0239: Expected O, but got I4
		//IL_0253: Expected O, but got I4
		//IL_027d: Expected O, but got I4
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_010a: Expected O, but got I4
		//IL_01af: Expected O, but got I4
		//IL_012d: Expected O, but got I4
		//IL_0136: Expected O, but got I4
		//IL_013f: Expected O, but got I4
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0303: Expected I4, but got Unknown
		object obj = (nint)0 + (nint)288;
		object obj2 = "UInt16" + 1312;
		object obj3 = "AvailableVoices" + 2160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		bool isBlocked = IsBlocked;
		bool flag = !isBlocked;
		object obj4 = !flag;
		object obj5 = ~obj4;
		object text = ((obj5 != null) ? obj3 : obj2);
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, (string)text);
		ChatMessageDataHolder data = _data;
		bool hasUser = data.<message>k__BackingField.HasUser;
		bool flag2;
		object obj6;
		TournamentData tournament;
		object obj8;
		object obj10;
		bool flag4;
		if (hasUser)
		{
			ChatMessageDataHolder data2 = _data;
			bool isMyMessage = data2.<message>k__BackingField.IsMyMessage;
			flag2 = (byte)((isMyMessage ? 1u : 0u) ^ 1u) != 0;
			obj6 = typeof(RegisteredWaitHandle) + 56;
			tournament = ((ChatMessageOptions)isMyMessage).Tournament;
			bool flag3 = tournament == null;
			object obj7 = !flag3;
			obj8 = 0;
			object obj9 = 0;
			obj10 = obj6;
			flag4 = flag2;
			if (obj7 == null)
			{
				goto IL_015d;
			}
		}
		else
		{
			obj6 = typeof(RegisteredWaitHandle) + 56;
			tournament = ((ChatMessageOptions)hasUser).Tournament;
			bool flag5 = tournament == null;
			obj8 = 0;
			flag2 = false;
			object obj9 = 0;
			obj10 = obj6;
			flag4 = false;
			if (flag5)
			{
				goto IL_015d;
			}
		}
		object obj11 = tournament.<Type>k__BackingField - 1;
		bool flag6 = obj11 == null;
		object obj12 = !flag6;
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v25+E4]");
		bool flag7 = (nint)0 == 0;
		object obj14 = !flag7;
		object obj15 = obj12;
		object obj16 = obj12;
		flag2 = flag4;
		if (obj14 == null)
		{
			goto IL_02a3;
		}
		goto IL_02c2;
		IL_015d:
		obj13 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v25+E4]");
		bool flag8 = (nint)0 == 0;
		object obj17 = !flag8;
		obj16 = 1;
		if (obj17 == null)
		{
			object obj9 = obj8;
			obj15 = 1;
			flag4 = flag2;
			goto IL_02a3;
		}
		goto IL_02c2;
		IL_02c2:
		RemoteConfigModel current = RemoteConfig.Current;
		FriendlyChallengeConfig <FriendlyChallenge>k__BackingField = current.<FriendlyChallenge>k__BackingField;
		GameObject gameObject = reportButton.gameObject;
		bool active = (byte)((flag2 & obj16) ? 1 : 0) != 0;
		gameObject.SetActive(active);
		GameObject gameObject2 = profileButton.gameObject;
		gameObject2.SetActive(flag2);
		GameObject gameObject3 = muteButton.gameObject;
		bool active2;
		if (flag2)
		{
			bool isModerator = IsModerator;
			active2 = (byte)((isModerator ? 1u : 0u) ^ 1u) != 0;
		}
		else
		{
			active2 = false;
		}
		gameObject3.SetActive(active2);
		GameObject gameObject4 = challengeButton.gameObject;
		bool active3 = flag2 & <FriendlyChallenge>k__BackingField.<Enabled>k__BackingField;
		gameObject4.SetActive(active3);
		return;
		IL_02a3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj16 = obj15;
		flag2 = flag4;
		goto IL_02c2;
	}

	private void AdjustPosition()
	{
		//IL_0011: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006c: Expected O, but got I4
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00f5: Expected O, but got I4
		//IL_0139: Expected O, but got I4
		//IL_0191: Expected O, but got I4
		//IL_01d2: Expected O, but got I4
		//IL_01db: Expected O, but got I4
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Expected O, but got Unknown
		//IL_02f2: Expected O, but got I
		//IL_033d: Expected O, but got I4
		//IL_04e0: Expected O, but got I4
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Expected O, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected O, but got Unknown
		//IL_04a4: Expected O, but got I4
		//IL_0409: Expected O, but got I4
		object obj = (nint)0 + (nint)3696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1648;
		ContentSizeFitter contentSizeFitter = default(ContentSizeFitter);
		contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.PreferredSize;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		LayoutRebuilder.ForceRebuildLayoutImmediate(panel);
		RectTransform rectTransform = UIExtensions.parent(panel);
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 3512;
		Rect rect = panel.rect;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Rect rect2 = rectTransform.rect;
		object obj8 = default(object);
		bool flag3 = obj8 <= obj8;
		object obj9 = 0;
		if (!flag3)
		{
			contentSizeFitter.horizontalFit = ContentSizeFitter.FitMode.Unconstrained;
			Rect rect3 = rectTransform.rect;
			object obj10 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v356 @ X0_v65+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Vector2 sizeDelta = panel.sizeDelta;
			panel.sizeDelta = (Vector2)0;
			obj9 = 0;
		}
		Vector2 offsetMax = panel.offsetMax;
		Rect rect4 = rectTransform.rect;
		object obj12 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v22+E4]");
		object obj13;
		object obj15;
		object obj14;
		if ((nint)0 != 0)
		{
			obj13 = obj8 + obj8;
			if (obj8 > obj13)
			{
				goto IL_02b2;
			}
			obj14 = obj8;
			obj15 = obj13;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj8 + obj8;
			bool flag5 = obj8 <= obj13;
			obj14 = obj8;
			obj15 = obj13;
			if (!flag5)
			{
				goto IL_02b2;
			}
		}
		goto IL_035a;
		IL_035a:
		Vector2 offsetMin = panel.offsetMin;
		Rect rect5 = rectTransform.rect;
		object obj16 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v28+E4]");
		if ((nint)0 != 0)
		{
			if (obj15 >= obj15)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (obj15 >= obj15)
			{
				return;
			}
		}
		Vector2 anchoredPosition = panel.anchoredPosition;
		Rect rect6 = rectTransform.rect;
		object obj17 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v489 @ X0_v37+E4]");
		bool flag6 = (nint)0 == 0;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Vector2 offsetMin2 = panel.offsetMin;
		panel.anchoredPosition = (Vector2)0;
		return;
		IL_02b2:
		Vector2 anchoredPosition2 = panel.anchoredPosition;
		object obj19 = typeof(UsageHint) + 744;
		object obj20 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v428 @ X8_v22+B8]");
		object obj21 = 0;
		Vector2 offsetMax2 = panel.offsetMax;
		Rect rect7 = rectTransform.rect;
		object obj22 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v54+E4]");
		bool flag7 = (nint)0 == 0;
		object obj23 = !flag7;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj24 = obj8 + obj13;
		object obj25 = obj13 - obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v23+28]");
		object obj26 = 0 * obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X8_v23+2C]");
		obj14 = 0 * obj25;
		obj15 = obj13 - obj26;
		object obj27 = obj27 - obj14;
		panel.anchoredPosition = (Vector2)0;
		goto IL_035a;
	}

	private void OnGroupChange(string _)
	{
		Hide();
	}

	public void Hide()
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_0044: Expected O, but got I
		//IL_0014: Expected O, but got I4
		object obj = this + 120;
		if (obj != null)
		{
			_ = 0;
			obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		blocker.SetActive(value: false);
		object obj2 = (nint)0 + (nint)3088;
		canvasGroup.blocksRaycasts = false;
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(canvasGroup, 0f, 0.2f);
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore2 = DOTweenModuleUI.DOAnchorPosY(panel, -50f, 0.2f);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3059474");
		float endValue = originalScale * 0.5f;
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOScale(panel, endValue, 0.3f);
	}

	public static bool HasOptions(ChatMessageData messageData)
	{
		//IL_0071: Expected I4, but got O
		if (messageData != null)
		{
			bool flag = messageData.HasUser;
			if (flag)
			{
				bool isMyMessage = messageData.IsMyMessage;
				flag = (byte)((isMyMessage ? 1u : 0u) ^ 1u) != 0;
			}
			return flag;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
