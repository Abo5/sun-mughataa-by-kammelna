using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Sfs2X.Entities;
using Spine;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentMatchStatePopup : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<MatchData, bool> <>9__25_0;

		public static Func<PlayerInfo, bool> <>9__25_1;

		public static Action<AvatarInitializer, PlayerInfo> <>9__25_2;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(SkeletonBinary.SkeletonInput) + 3720;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <ShowMatchStatus>b__25_0(MatchData m)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01e5: Expected I4, but got O
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E81]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v10+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v10+E4]");
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
			if ((object)sessionModel != null)
			{
				goto IL_0150;
			}
			goto IL_01d7;
			IL_01d7:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0150:
			User localUser = sessionModel.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			if (m != null)
			{
				bool flag3 = m.HasPlayer(intDbId);
				if (flag3)
				{
					bool flag4 = m.<State>k__BackingField == MatchData.Status.Waiting;
					flag3 = flag4;
				}
				return flag3;
			}
			goto IL_01d7;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag5 = (object)sessionModel == null;
			object obj8 = !flag5;
			if (obj8 != null)
			{
				goto IL_0150;
			}
			goto IL_01d7;
		}

		internal bool <ShowMatchStatus>b__25_1(PlayerInfo info)
		{
			//IL_004b: Expected I4, but got O
			if (info != null)
			{
				bool isHuman = info.IsHuman;
				return (byte)((isHuman ? 1u : 0u) ^ 1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <ShowMatchStatus>b__25_2(AvatarInitializer avatar, PlayerInfo player)
		{
			AvatarData data = player;
			avatar.Initialize(data);
		}
	}

	private sealed class <>c__DisplayClass28_0
	{
		public PlayerInfo player;

		internal bool <GetStateSprite>b__0(User user)
		{
			//IL_006a: Expected I4, but got O
			//IL_0048: Expected O, but got I4
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(user);
			PlayerInfo playerInfo = player;
			if (player != null)
			{
				object obj = intDbId - playerInfo.<DBID>k__BackingField;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private PopupUI popup;

	private TextMeshProUGUI description;

	private TextMeshProUGUI warningText;

	private Timer[] timers;

	private Sprite onlineSprite;

	private Sprite offlineSprite;

	private float offlineSpriteAlpha;

	private Image[] onlineIndicators;

	private Image[] smallOnlineIndicators;

	private AvatarInitializer[] avatars;

	private RectTransform scaleBody;

	private CanvasGroup mainGroup;

	private CanvasGroup smallGroup;

	private MatchData _match;

	private Room TournamentRoom
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
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC9]");
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

	private TournamentViewConnector Connector
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			return (TournamentViewConnector)0;
		}
	}

	private void Start()
	{
		//IL_0016: Expected O, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00ff: Expected O, but got I
		//IL_0119: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00bc: Expected O, but got I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_017a: Expected O, but got I
		//IL_0192: Expected I, but got O
		//IL_014d: Expected O, but got I
		//IL_01ac: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6E78]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B8]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45B8]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v6+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		goto IL_015a;
		IL_015a:
		object obj10 = typeof(SqlSingle[]) + 2376;
		object obj11 = (nint)0 + (nint)1056;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj11);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v3+20]");
		((OneShotEvent)0).CallWhenReady(action);
		return;
		IL_0082:
		object obj12 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X8_v12+B8]");
		object obj13 = 0;
		obj9 = obj13;
		bool flag3 = obj13 == null;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_015a;
	}

	private void Init()
	{
		//IL_0016: Expected O, but got I
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_013c: Expected O, but got I
		//IL_0156: Expected O, but got I4
		//IL_015f: Expected O, but got I4
		//IL_0098: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0075: Expected O, but got I4
		//IL_0188: Expected O, but got I
		//IL_01b2: Expected O, but got I4
		//IL_00f9: Expected O, but got I4
		//IL_027d: Expected O, but got I
		//IL_0431: Expected O, but got I4
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ea: Expected O, but got Unknown
		//IL_02f6: Expected O, but got I
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected O, but got Unknown
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_0325: Expected O, but got I
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_0345: Expected O, but got I
		//IL_036f: Expected I, but got O
		//IL_0472: Expected O, but got I4
		//IL_03a1: Expected I, but got O
		//IL_03cc: Expected I, but got O
		//IL_03f2: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ECA]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj5;
		if (obj != null)
		{
			obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC9]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			object obj4 = 152985600;
			obj5 = obj2;
			if (!flag)
			{
				goto IL_008c;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC9]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			object obj4 = 152985600;
			obj5 = obj2;
			if (obj7 != null)
			{
				goto IL_008c;
			}
		}
		_ = 1;
		object obj8 = (nint)0 + (nint)2200;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v37+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		obj2 = obj5;
		object obj11 = obj8;
		if (obj10 != null)
		{
			goto IL_00d5;
		}
		goto IL_01d0;
		IL_0480:
		throw new NullReferenceException();
		IL_02d6:
		object obj12 = typeof(SqlSingle[]) + 2376;
		object obj13 = (nint)0 + (nint)1072;
		object varName = "rightCtrl" + 640;
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj15 = (nint)0 + (nint)1064;
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
		object obj17 = (nint)0 + (nint)1088;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj13);
		GameObject go;
		VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj15);
		SFS.OnJoinGameRoom += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj17);
		SFS.OnUserJoinRoom += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj17);
		SFS.OnUserLeaveRoom += action4;
		return;
		IL_02c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_02d6;
		IL_008c:
		obj8 = (nint)0 + (nint)2200;
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v37+E4]");
		bool flag4 = (nint)0 == 0;
		obj11 = obj8;
		obj5 = obj2;
		if (!flag4)
		{
			goto IL_00d5;
		}
		goto IL_01d0;
		IL_01d0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj8 = obj11;
		obj2 = obj5;
		goto IL_01fe;
		IL_00d5:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		bool flag5 = (object)sessionModel2 == null;
		object obj18 = !flag5;
		if (obj18 != null)
		{
			goto IL_01fe;
		}
		goto IL_0480;
		IL_01fe:
		Room currentRoom2 = sessionModel2.CurrentRoom;
		TournamentData tournamentInfo = SFSKammelnaRoomExtensions.GetTournamentInfo(currentRoom2);
		if (tournamentInfo != null && tournamentInfo.<IsCluster>k__BackingField)
		{
			return;
		}
		go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC9]");
		object obj19 = (nint)0 & (nint)1;
		if (obj19 != null)
		{
			object obj20 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v8+E4]");
			if ((nint)0 != 0)
			{
				goto IL_02c7;
			}
		}
		else
		{
			_ = 1;
			object obj20 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X0_v8+E4]");
			bool flag6 = (nint)0 == 0;
			object obj21 = !flag6;
			if (obj21 != null)
			{
				goto IL_02c7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag7 = (object)sessionModel == null;
		object obj22 = !flag7;
		if (obj22 != null)
		{
			goto IL_02d6;
		}
		goto IL_0480;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_00af: Expected I, but got O
		//IL_005d: Expected I, but got O
		//IL_0088: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		object obj2 = (nint)0 + (nint)1064;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
		object obj4 = (nint)0 + (nint)1088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnJoinGameRoom -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		SFS.OnUserJoinRoom -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj4);
		SFS.OnUserLeaveRoom -= action3;
	}

	public void Minimize()
	{
		int num = ShortcutExtensions.DOKill(scaleBody, complete: true);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(scaleBody, 0.2f, 0.3f);
		HideBlocker();
		int num2 = ShortcutExtensions.DOKill(mainGroup, complete: true);
		TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTweenModuleUI.DOFade(mainGroup, 0f, 0.3f);
		mainGroup.interactable = false;
		int num3 = ShortcutExtensions.DOKill(smallGroup, complete: true);
		TweenerCore<float, float, FloatOptions> tweenerCore3 = DOTweenModuleUI.DOFade(smallGroup, 1f, 0.3f);
		smallGroup.interactable = true;
	}

	public void Restore()
	{
		int num = ShortcutExtensions.DOKill(scaleBody, complete: true);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(scaleBody, 1f, 0.3f);
		ShowBlocker();
		int num2 = ShortcutExtensions.DOKill(smallGroup, complete: true);
		TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTweenModuleUI.DOFade(smallGroup, 0f, 0.3f);
		smallGroup.interactable = false;
		int num3 = ShortcutExtensions.DOKill(mainGroup, complete: true);
		TweenerCore<float, float, FloatOptions> tweenerCore3 = DOTweenModuleUI.DOFade(mainGroup, 1f, 0.3f);
		mainGroup.interactable = true;
	}

	private void OnJoinGameRoom(Room obj)
	{
		HideBlocker();
		popup.ShrinkToParent();
	}

	private void OnRoundStateUpdate()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00ab: Expected O, but got I4
		//IL_00cd: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1080;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj4 = this + 136;
		obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj5 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(5f, action);
	}

	private void ShowMatchStatus()
	{
		//IL_0016: Expected O, but got I
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0132: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_008e: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_00ef: Expected O, but got I4
		//IL_023f: Expected O, but got I
		//IL_02f0: Expected O, but got I4
		//IL_02ad: Expected O, but got I4
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		//IL_07a8: Expected O, but got I
		//IL_07b8: Expected O, but got I
		//IL_07da: Expected O, but got I4
		//IL_039f: Expected O, but got I4
		//IL_03a8: Expected O, but got I4
		//IL_03f9: Expected O, but got I
		//IL_0409: Expected O, but got I
		//IL_042b: Expected O, but got I4
		//IL_043b: Expected O, but got I
		//IL_0499: Expected O, but got I4
		//IL_07f8: Expected O, but got I
		//IL_03bf: Expected O, but got I4
		//IL_04d1: Expected O, but got I4
		//IL_051c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Expected O, but got Unknown
		//IL_054b: Expected O, but got I4
		//IL_059d: Expected O, but got I
		//IL_064e: Expected O, but got I4
		//IL_060b: Expected O, but got I4
		//IL_0806: Expected O, but got I4
		//IL_080f: Expected O, but got I4
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected O, but got Unknown
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected O, but got Unknown
		//IL_06ef: Expected O, but got I4
		//IL_0d39: Expected O, but got I
		//IL_0d49: Expected O, but got I
		//IL_0d6b: Expected O, but got I4
		//IL_085d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0862: Expected O, but got Unknown
		//IL_088c: Expected O, but got I4
		//IL_0ff1: Expected O, but got I
		//IL_101a: Expected O, but got I4
		//IL_0736: Expected O, but got I4
		//IL_08ca: Invalid comparison between F8 and I8
		//IL_0d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8d: Expected O, but got Unknown
		//IL_0da3: Expected O, but got I
		//IL_0db4: Expected I, but got O
		//IL_0dd2: Expected O, but got I
		//IL_0774: Expected O, but got I4
		//IL_0766: Expected O, but got I
		//IL_08ea: Expected F8, but got I4
		//IL_09a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a8: Expected O, but got Unknown
		//IL_09d2: Expected O, but got I4
		//IL_0905: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Expected O, but got Unknown
		//IL_0913: Expected O, but got I4
		//IL_0e20: Expected O, but got I
		//IL_0e30: Expected O, but got I
		//IL_0e52: Expected O, but got I4
		//IL_0921: Unknown result type (might be due to invalid IL or missing references)
		//IL_0926: Expected O, but got Unknown
		//IL_093c: Expected O, but got I
		//IL_0951: Expected O, but got I
		//IL_1051: Unknown result type (might be due to invalid IL or missing references)
		//IL_1056: Expected O, but got Unknown
		//IL_1060: Unknown result type (might be due to invalid IL or missing references)
		//IL_1065: Expected O, but got Unknown
		//IL_107f: Expected O, but got I4
		//IL_0977: Expected O, but got I4
		//IL_0a19: Expected O, but got I4
		//IL_0eee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef3: Expected O, but got Unknown
		//IL_0e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e74: Expected O, but got Unknown
		//IL_0e8a: Expected O, but got I
		//IL_0e9b: Expected I, but got O
		//IL_0eb9: Expected O, but got I
		//IL_0f10: Expected O, but got I
		//IL_0a57: Expected O, but got I4
		//IL_0a49: Expected O, but got I
		//IL_0b07: Expected O, but got I4
		//IL_0f2d: Expected O, but got I
		//IL_0f3d: Expected O, but got I
		//IL_0f5f: Expected O, but got I4
		//IL_0b8f: Expected O, but got I
		//IL_0b4e: Expected O, but got I4
		//IL_0bc4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc9: Expected O, but got Unknown
		//IL_0bdf: Expected O, but got I
		//IL_0bed: Expected I, but got O
		//IL_0f7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f81: Expected O, but got Unknown
		//IL_0f97: Expected O, but got I
		//IL_0fa8: Expected I, but got O
		//IL_0fc6: Expected O, but got I
		//IL_0c01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Expected O, but got Unknown
		//IL_0c30: Expected O, but got I4
		//IL_0b7e: Expected O, but got I
		//IL_0c7e: Expected O, but got I
		//IL_0c8c: Expected I, but got O
		//IL_0cbd: Expected O, but got I
		//IL_0ccb: Expected I, but got O
		//IL_0cfd: Expected O, but got I
		//IL_0d0b: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6ECB]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC9]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC9]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = (nint)0 + (nint)2200;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v149+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		obj2 = obj4;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00cb;
		}
		goto IL_01bc;
		IL_0449:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		DateTime dateTime2;
		DateTime dateTime = dateTime2;
		goto IL_0460;
		IL_0317:
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		DateTime? tournamentRoundTimer = SFSKammelnaRoomExtensions.GetTournamentRoundTimer(currentRoom);
		object obj11 = typeof(DataRelation) + 712;
		object obj12 = obj11;
		object obj13 = (??)tournamentRoundTimer & 1;
		if (obj13 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v130+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			dateTime = (DateTime)0;
			if (obj14 == null)
			{
				dateTime2 = (DateTime)0;
				goto IL_0449;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v130+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v130+B8]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v99+10]");
				dateTime2 = (DateTime)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v130+E4]");
				bool flag5 = (nint)0 == 0;
				object obj16 = !flag5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v99+10]");
				dateTime = (DateTime)0;
				if (obj16 == null)
				{
					goto IL_0449;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v130+B8]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v97+10]");
				dateTime = (DateTime)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v130+E4]");
				bool flag6 = (nint)0 == 0;
				object obj18 = !flag6;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v503 @ X8_v97+10]");
					dateTime2 = (DateTime)0;
					goto IL_0449;
				}
			}
		}
		goto IL_0460;
		IL_0289:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag7 = (object)sessionModel == null;
		object obj19 = !flag7;
		if (obj19 != null)
		{
			goto IL_0317;
		}
		goto IL_0d22;
		IL_0082:
		obj7 = (nint)0 + (nint)2200;
		obj8 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v149+E4]");
		bool flag8 = (nint)0 == 0;
		obj10 = obj7;
		obj4 = obj2;
		if (!flag8)
		{
			goto IL_00cb;
		}
		goto IL_01bc;
		IL_01bc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj7 = obj10;
		obj2 = obj4;
		goto IL_01ea;
		IL_00cb:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		bool flag9 = (object)sessionModel2 == null;
		object obj20 = !flag9;
		if (obj20 != null)
		{
			goto IL_01ea;
		}
		goto IL_0d22;
		IL_01ea:
		Room currentRoom2 = sessionModel2.CurrentRoom;
		TournamentStatus tournamentStatus = SFSKammelnaRoomExtensions.GetTournamentStatus(currentRoom2);
		if (tournamentStatus != TournamentStatus.Running)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC9]");
		object obj21 = (nint)0 & (nint)1;
		if (obj21 != null)
		{
			object obj22 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v134+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0289;
			}
		}
		else
		{
			_ = 1;
			object obj22 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X0_v134+E4]");
			bool flag10 = (nint)0 == 0;
			object obj23 = !flag10;
			if (obj23 != null)
			{
				goto IL_0289;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0317;
		IL_0d22:
		throw new NullReferenceException();
		IL_0460:
		DateTime now = DateTime.Now;
		bool flag11 = dateTime < now;
		bool flag12 = !flag11;
		object obj24 = !flag12;
		if (obj24 != null)
		{
			return;
		}
		object obj25 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X0_v16+E4]");
		bool flag13 = (nint)0 == 0;
		object obj26 = !flag13;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now2 = DateTime.Now;
		TimeSpan timeSpan = dateTime - now2;
		object obj27 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v536 @ X0_v22+E4]");
		bool flag14 = (nint)0 == 0;
		object obj29 = !flag14;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		TimeSpan timeSpan3 = default(TimeSpan);
		TimeSpan timeSpan2 = timeSpan3.Duration();
		double totalSeconds = timeSpan3.TotalSeconds;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC9]");
		object obj30 = (nint)0 & (nint)1;
		if (obj30 != null)
		{
			object obj31 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X0_v113+E4]");
			if ((nint)0 != 0)
			{
				goto IL_05e7;
			}
		}
		else
		{
			_ = 1;
			object obj31 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v570 @ X0_v113+E4]");
			bool flag15 = (nint)0 == 0;
			object obj32 = !flag15;
			if (obj32 != null)
			{
				goto IL_05e7;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_0675;
		IL_05e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		bool flag16 = (object)sessionModel3 == null;
		object obj33 = !flag16;
		if (obj33 != null)
		{
			goto IL_0675;
		}
		goto IL_0d22;
		IL_0675:
		Room currentRoom3 = sessionModel3.CurrentRoom;
		List<MatchData> tournamentMatches = SFSKammelnaRoomExtensions.GetTournamentMatches(currentRoom3);
		object obj49;
		if (tournamentMatches != null)
		{
			object obj34 = typeof(SkeletonBinary.SkeletonInput) + 3720;
			object obj35 = obj34;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v78+E4]");
			bool flag17 = (nint)0 == 0;
			object obj36 = !flag17;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj35 = obj34;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v78+B8]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X9_v14+8]");
			Func<object, bool> func = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v614 @ X9_v14+8]");
			bool flag18 = (nint)0 == 0;
			object obj38 = !flag18;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X8_v78+E4]");
				bool flag19 = (nint)0 == 0;
				object obj39 = !flag19;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj40 = obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v88+B8]");
					obj37 = 0;
				}
				object obj41 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2384;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj42 = (nint)0 + (nint)104;
				Func<object, bool> func2 = default(Func<object, bool>);
				func2..ctor(obj37, (IntPtr)obj42);
				object obj43 = obj34;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X8_v87+B8]");
				object obj44 = (nint)0 + (nint)8;
				obj44 = func2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj45 = 0;
				func = func2;
			}
			object obj46 = (nint)0 + (nint)1816;
			object obj47 = obj46;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DC96CC");
			bool flag20 = (object)this == null;
			object obj48 = !flag20;
			object obj50 = default(object);
			obj49 = obj50;
			if (obj48 == null)
			{
				goto IL_0d22;
			}
		}
		else
		{
			object obj47 = 0;
			obj49 = 0;
		}
		object obj51 = this + 136;
		obj51 = obj49;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj51 == null)
		{
			return;
		}
		object obj52 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj53 = obj52;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v640 @ X0_v33+E4]");
		bool flag21 = (nint)0 == 0;
		object obj54 = !flag21;
		if (obj54 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.DismissMessage();
		Timer[] array = timers;
		double num = ((totalSeconds != 9.218868437227405E+18) ? totalSeconds : 207.0);
		bool flag22 = array.Length < 1;
		float num2 = (float)totalSeconds;
		if (!flag22)
		{
			object obj55 = array + 32;
			object obj56 = 0;
			bool flag23;
			do
			{
				obj56++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X23_v9+v269 @ X22_v12*8]");
				((Timer)0).StartTimer(60f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X23_v9+v269 @ X22_v12*8]");
				((Timer)0).StartTimer((float)num);
				flag23 = (nint)obj56 < array.Length;
				num2 = (float)num;
				obj49 = 0;
			}
			while (flag23);
		}
		MatchData match = _match;
		object obj57 = typeof(SkeletonBinary.SkeletonInput) + 3720;
		object obj58 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v38+E4]");
		bool flag24 = (nint)0 == 0;
		object obj59 = !flag24;
		if (obj59 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj58 = obj57;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v38+B8]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X8_v67+10]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v740 @ X8_v67+10]");
		bool flag25 = (nint)0 == 0;
		object obj61 = !flag25;
		if (obj61 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v709 @ X0_v38+E4]");
			bool flag26 = (nint)0 == 0;
			object obj62 = !flag26;
			if (obj62 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj63 = obj57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X8_v73+B8]");
				obj60 = 0;
			}
			object obj64 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj65 = (nint)0 + (nint)112;
			Func<object, bool> func3 = default(Func<object, bool>);
			func3..ctor(obj60, (IntPtr)obj65);
			object obj66 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v72+B8]");
			object obj67 = (nint)0 + (nint)16;
			obj67 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj45 = 0;
			predicate = func3;
		}
		bool flag27 = Enumerable.Any(match.<Players>k__BackingField, predicate);
		object text = "fetch_products" + 1728;
		object obj68 = "not" + 3496;
		bool flag28 = !flag27;
		object obj69 = !flag28;
		object obj70 = ~obj69;
		if (obj70 != null)
		{
			text = obj68;
		}
		TextMeshProExtensions.Localize(description, (string)text);
		object obj71 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1616;
		object obj72 = obj71;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v35+B8]");
		object obj73 = 0;
		object obj74 = obj73;
		object obj75 = obj74;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v304 @ X8_v37+188] (should have been resolved before IL gen)");
		object obj76 = default(object);
		if (obj76 == null)
		{
			return;
		}
		GameObject gameObject = warningText.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v45+60]");
		bool active = (nint)0 == 0;
		gameObject.SetActive(active);
		object obj77 = obj57;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v49+E4]");
		bool flag29 = (nint)0 == 0;
		object obj78 = !flag29;
		if (obj78 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj77 = obj57;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v49+B8]");
		object obj79 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v56+18]");
		Action<object, object> action = (Action<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v808 @ X8_v56+18]");
		bool flag30 = (nint)0 == 0;
		object obj80 = !flag30;
		if (obj80 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X0_v49+E4]");
			bool flag31 = (nint)0 == 0;
			object obj81 = !flag31;
			if (obj81 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj82 = obj57;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v62+B8]");
				obj79 = 0;
			}
			object obj83 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 240;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj84 = (nint)0 + (nint)120;
			Action<object, object> action2 = default(Action<object, object>);
			action2..ctor(obj79, (IntPtr)obj84);
			object obj85 = obj57;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X8_v61+B8]");
			object obj86 = (nint)0 + (nint)24;
			obj86 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			action = action2;
		}
		object obj87 = (nint)0 + (nint)992;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304E80C");
		popup.PopFromCenter();
		UpdateOnlineIndicators();
		object obj88 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj89 = (nint)0 + (nint)1008;
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj89);
		object obj90 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj91 = obj90;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X0_v56+E4]");
		bool flag32 = (nint)0 == 0;
		object obj92 = !flag32;
		if (obj92 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(5f, action3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj93 = (nint)0 + (nint)1016;
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj93);
		Coroutine coroutine2 = CoroutineDummy.WaitForSeconds(10f, action4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj94 = (nint)0 + (nint)1024;
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj94);
		Coroutine coroutine3 = CoroutineDummy.WaitForSeconds(50f, action5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj95 = (nint)0 + (nint)1048;
		Action action6 = default(Action);
		action6..ctor(this, (IntPtr)obj95);
		Coroutine coroutine4 = CoroutineDummy.WaitForSeconds((float)num, action6);
	}

	private void UpdateOnlineIndicators(User _ = null)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_004f: Expected O, but got I4
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_013c: Expected O, but got I
		//IL_014a: Expected I, but got O
		//IL_015b: Expected O, but got I
		//IL_0180: Expected O, but got I
		//IL_018e: Expected I, but got O
		if (_match == null)
		{
			return;
		}
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		if (_match.HasPlayer(intDbId))
		{
			PopupUI popupUI = popup;
			GameObject gameObject = popupUI.content.gameObject;
			if (gameObject.activeSelf)
			{
				object obj5 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 408;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj6 = (nint)0 + (nint)1032;
				Action<object, object> action = default(Action<object, object>);
				action..ctor((object)this, (IntPtr)obj6);
				object obj7 = (nint)0 + (nint)1000;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304E80C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj8 = (nint)0 + (nint)1040;
				Action<object, object> action2 = default(Action<object, object>);
				action2..ctor((object)this, (IntPtr)obj8);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @304E80C");
			}
		}
	}

	private void HidePopup()
	{
		HideBlocker();
		popup.ShrinkToParent();
	}

	private Sprite GetStateSprite(PlayerInfo player)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_014d: Expected O, but got I4
		//IL_015a: Expected O, but got I
		//IL_0085: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00af: Expected O, but got I
		//IL_016c: Expected O, but got I
		//IL_0196: Expected O, but got I4
		//IL_0131: Expected O, but got I4
		//IL_00d8: Expected O, but got I
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0228: Expected I, but got O
		//IL_0238: Expected O, but got I
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_03dc: Expected O, but got I
		//IL_03ed: Expected I, but got O
		//IL_0273: Expected O, but got I
		//IL_0313: Expected O, but got I4
		//IL_0341: Expected O, but got I4
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Expected O, but got Unknown
		//IL_0411: Expected O, but got I
		//IL_0333: Expected O, but got I4
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 3728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		SessionModel sessionModel = default(SessionModel);
		if (obj2 != null)
		{
			object obj3 = obj2 + 16;
			obj3 = player;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj3 != null)
			{
				if (!((PlayerInfo)obj3).IsHuman)
				{
					object obj4 = 72;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentMatchStatePopup)+v150 @ X8_v4]");
					return (Sprite)0;
				}
				object obj5 = 152985600;
				object obj6 = typeof(Queue<string>) + 848;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6EC9]");
				object obj7 = (nint)0 & (nint)1;
				if (obj7 != null)
				{
					object obj8 = (nint)0 + (nint)2200;
					object obj9 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v22+E4]");
					bool flag = (nint)0 == 0;
					object obj10 = obj8;
					if (!flag)
					{
						goto IL_010d;
					}
				}
				else
				{
					_ = 1;
					object obj8 = (nint)0 + (nint)2200;
					object obj9 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v22+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					object obj10 = obj8;
					if (obj11 != null)
					{
						goto IL_010d;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				if ((object)sessionModel != null)
				{
					goto IL_01e2;
				}
			}
		}
		goto IL_0346;
		IL_0346:
		return (Sprite)(object)new NullReferenceException();
		IL_03a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v271 @ X8_v10] (should have been resolved before IL gen)");
		object obj12 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj13 = (nint)0 + (nint)128;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj13);
		IEnumerable<object> source = default(IEnumerable<object>);
		bool flag3 = Enumerable.Any(source, func);
		bool flag4 = !flag3;
		object obj14 = !flag4;
		object obj15 = ~obj14;
		if (obj15 == null)
		{
			object obj16 = 64;
		}
		else
		{
			object obj16 = 72;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (TournamentMatchStatePopup)+v151 @ X8_v18]");
		return (Sprite)0;
		IL_01e2:
		Room currentRoom = sessionModel.CurrentRoom;
		if (currentRoom == null)
		{
			goto IL_0346;
		}
		object obj17 = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)currentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj18 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02b4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj19 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X10_v5-8]");
			if (0 == (nint)obj17)
			{
				break;
			}
			obj19 += 16;
			obj18--;
			if ((nint)obj18 != 1)
			{
				continue;
			}
			goto IL_02b4;
		}
		object obj20 = obj19 + 28;
		object obj21 = num + obj20;
		object obj22 = obj21 + 312;
		goto IL_03a8;
		IL_010d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag5 = (object)sessionModel == null;
		object obj23 = !flag5;
		if (obj23 != null)
		{
			goto IL_01e2;
		}
		goto IL_0346;
		IL_02b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj24 = default(object);
		obj22 = obj24;
		goto IL_03a8;
	}

	private void ApplyForTeams<T>(IReadOnlyList<T> playerObjects, Action<T, PlayerInfo> action)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0052: Expected O, but got I4
		//IL_01d7: Expected O, but got I
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01ff: Expected O, but got I4
		//IL_07f2: Expected I, but got O
		//IL_0802: Expected O, but got I
		//IL_029b: Expected I, but got O
		//IL_02bf: Expected O, but got I4
		//IL_0240: Expected O, but got I
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0305: Expected I, but got O
		//IL_038e: Expected O, but got I
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_03b6: Expected O, but got I4
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0853: Expected I, but got O
		//IL_0863: Expected O, but got I
		//IL_03f7: Expected O, but got I
		//IL_049d: Expected O, but got I
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Expected O, but got Unknown
		//IL_04c5: Expected O, but got I4
		//IL_08c3: Expected I, but got O
		//IL_08d3: Expected O, but got I
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected O, but got Unknown
		//IL_0561: Expected I, but got O
		//IL_0405: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_0418: Expected O, but got Unknown
		//IL_0506: Expected O, but got I
		//IL_05be: Expected O, but got I
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_05e6: Expected O, but got I4
		//IL_0924: Expected I, but got O
		//IL_0934: Expected O, but got I
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected O, but got Unknown
		//IL_0695: Unknown result type (might be due to invalid IL or missing references)
		//IL_069a: Expected O, but got Unknown
		//IL_06a2: Expected I, but got O
		//IL_06c6: Expected O, but got I4
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected O, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Expected O, but got Unknown
		//IL_0627: Expected O, but got I
		//IL_0724: Expected O, but got I
		//IL_0734: Expected O, but got I
		//IL_0744: Expected O, but got I
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected O, but got Unknown
		//IL_07a0: Expected O, but got I4
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f4: Expected O, but got Unknown
		//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0702: Expected O, but got Unknown
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected O, but got Unknown
		MatchData match = _match;
		object obj = typeof(Queue<string>) + 848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v65+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		MatchData matchData = _match;
		if (obj3 == null)
		{
			goto IL_006a;
		}
		goto IL_0081;
		IL_006a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		matchData = match;
		goto IL_0081;
		IL_0081:
		SessionModel sessionModel = default(SessionModel);
		IntPtr intPtr = default(IntPtr);
		object obj12 = default(object);
		object obj13 = default(object);
		object obj19;
		object obj9 = default(object);
		IntPtr intPtr2 = default(IntPtr);
		IntPtr intPtr3 = default(IntPtr);
		IntPtr intPtr4 = default(IntPtr);
		do
		{
			nint num = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag2 = (object)sessionModel == null;
			TournamentMatchStatePopup tournamentMatchStatePopup = this;
			PlayerInfo[] teamPlayers;
			PlayerInfo[] teamPlayers2;
			object obj8;
			if (!flag2)
			{
				User localUser = sessionModel.LocalUser;
				int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
				bool flag3 = matchData == null;
				tournamentMatchStatePopup = this;
				if (!flag3)
				{
					int teamId = matchData.GetTeamId(intDbId);
					int team = ((teamId != 1) ? 1 : (1 + 1));
					bool flag4 = _match == null;
					num = 1;
					tournamentMatchStatePopup = this;
					if (!flag4)
					{
						teamPlayers = _match.GetTeamPlayers(teamId);
						bool flag5 = _match == null;
						num = 1;
						tournamentMatchStatePopup = this;
						if (!flag5)
						{
							teamPlayers2 = _match.GetTeamPlayers(team);
							bool flag6 = playerObjects == null;
							num = 1;
							tournamentMatchStatePopup = this;
							if (!flag6)
							{
								object obj4 = (nint)0 + (nint)309;
								object obj5 = obj4 & 1;
								bool flag7 = obj5 == null;
								object obj6 = !flag7;
								nint num2 = 0;
								if (obj6 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
									num2 = intPtr;
								}
								nint num3 = (nint)playerObjects;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v16 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+12E]");
								object obj7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v16 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_0289;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v16 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+B0]");
								obj8 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X10_v13-8]");
									if (0 == num2)
									{
										break;
									}
									obj9 = obj8 + 16;
									obj7--;
									bool flag8 = (nint)obj7 != 1;
									obj8 = obj9;
									if (flag8)
									{
										continue;
									}
									goto IL_0289;
								}
								object obj10 = num3 + obj8;
								object obj11 = obj10 + 312;
								num = (nint)obj11;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v476 @ X0_v59] (should have been resolved before IL gen)");
								bool flag9 = teamPlayers == null;
								obj9 = obj8;
								tournamentMatchStatePopup = (TournamentMatchStatePopup)(object)teamPlayers2;
								if (!flag9)
								{
									goto IL_033c;
								}
							}
						}
					}
				}
			}
			goto IL_06dc;
			IL_054f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v598 @ X0_v42] (should have been resolved before IL gen)");
			bool flag10 = teamPlayers2 == null;
			obj9 = obj8;
			tournamentMatchStatePopup = (TournamentMatchStatePopup)(object)teamPlayers2;
			if (!flag10)
			{
				goto IL_0598;
			}
			goto IL_06dc;
			IL_06dc:
			throw new NullReferenceException();
			IL_0668:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			tournamentMatchStatePopup = (TournamentMatchStatePopup)(object)teamPlayers2;
			goto IL_0985;
			IL_0289:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v460 @ X0_v56] (should have been resolved before IL gen)");
			bool flag11 = teamPlayers == null;
			object obj14 = !flag11;
			obj8 = obj9;
			if (obj14 != null)
			{
				goto IL_033c;
			}
			tournamentMatchStatePopup = (TournamentMatchStatePopup)(object)teamPlayers2;
			goto IL_06dc;
			IL_0985:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v307 @ X0_v4] (should have been resolved before IL gen)");
			TextMeshProUGUI textMeshProUGUI = tournamentMatchStatePopup.description;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [action @ X2 (System.Action`2<T, PlayerInfo>)+18]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [action @ X2 (System.Action`2<T, PlayerInfo>)+40]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [action @ X2 (System.Action`2<T, PlayerInfo>)+28]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v328 @ X4_v1 (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CD24");
			matchData = _match;
			object obj18 = typeof(Queue<string>) + 848;
			obj2 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v65+E4]");
			bool flag12 = (nint)0 == 0;
			obj19 = !flag12;
			continue;
			IL_0440:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_08ac;
			IL_033c:
			num = teamPlayers.Length;
			bool flag13 = action == null;
			obj9 = obj8;
			tournamentMatchStatePopup = (TournamentMatchStatePopup)(object)teamPlayers2;
			if (flag13)
			{
				goto IL_06dc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [action @ X2 (System.Action`2<T, PlayerInfo>)+18] (should have been resolved before IL gen)");
			object obj20 = (nint)0 + (nint)309;
			object obj21 = obj20 & 1;
			bool flag14 = obj21 == null;
			object obj22 = !flag14;
			nint num4 = 0;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				num4 = intPtr2;
			}
			nint num5 = (nint)playerObjects;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v23 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+12E]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v23 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0440;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v497 @ X8_v23 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+B0]");
			object obj24 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X10_v21-8]");
				if (0 == num4)
				{
					break;
				}
				obj8 = obj24 + 16;
				obj23--;
				bool flag15 = (nint)obj23 != 1;
				obj24 = obj8;
				if (flag15)
				{
					continue;
				}
				goto IL_0440;
			}
			object obj25 = num5 + obj24;
			object obj26 = obj25 + 312;
			obj8 = obj24;
			goto IL_08ac;
			IL_08ac:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v559 @ X0_v27] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [action @ X2 (System.Action`2<T, PlayerInfo>)+28]");
			nint num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [action @ X2 (System.Action`2<T, PlayerInfo>)+18] (should have been resolved before IL gen)");
			object obj27 = (nint)0 + (nint)309;
			object obj28 = obj27 & 1;
			bool flag16 = obj28 == null;
			object obj29 = !flag16;
			nint num7 = 0;
			if (obj29 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				num7 = intPtr3;
			}
			nint num8 = (nint)playerObjects;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v31 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+12E]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v31 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_054f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v580 @ X8_v31 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+B0]");
			obj9 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X10_v23-8]");
				if (0 == num7)
				{
					break;
				}
				obj8 = obj9 + 16;
				obj30--;
				bool flag17 = (nint)obj30 != 1;
				obj9 = obj8;
				if (flag17)
				{
					continue;
				}
				goto IL_054f;
			}
			object obj31 = num8 + obj9;
			object obj32 = obj31 + 312;
			num = (nint)obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v613 @ X0_v45] (should have been resolved before IL gen)");
			bool flag18 = teamPlayers2 == null;
			object obj33 = !flag18;
			tournamentMatchStatePopup = (TournamentMatchStatePopup)(object)teamPlayers2;
			if (obj33 != null)
			{
				goto IL_0598;
			}
			goto IL_06dc;
			IL_0598:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [action @ X2 (System.Action`2<T, PlayerInfo>)+28]");
			num6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [action @ X2 (System.Action`2<T, PlayerInfo>)+18] (should have been resolved before IL gen)");
			object obj34 = (nint)0 + (nint)309;
			object obj35 = obj34 & 1;
			bool flag19 = obj35 == null;
			object obj36 = !flag19;
			nint num9 = 0;
			if (obj36 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
				num9 = intPtr4;
			}
			num = (nint)playerObjects;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v9 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+12E]");
			object obj37 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v9 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0668;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v9 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<T>>)+B0]");
			obj9 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X10_v23-8]");
				bool flag20 = 0 == num9;
				tournamentMatchStatePopup = (TournamentMatchStatePopup)(object)teamPlayers2;
				if (flag20)
				{
					break;
				}
				obj9 += 16;
				obj37--;
				if ((nint)obj37 != 1)
				{
					continue;
				}
				goto IL_0668;
			}
			object obj38 = num + obj9;
			object obj39 = obj38 + 312;
			goto IL_0985;
		}
		while (obj19 != null);
		match = _match;
		goto IL_006a;
	}

	private static void ShowGroup(CanvasGroup canvasGroup)
	{
		int num = ShortcutExtensions.DOKill(canvasGroup, complete: true);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(canvasGroup, 1f, 0.3f);
		canvasGroup.interactable = true;
	}

	private static void HideGroup(CanvasGroup canvasGroup)
	{
		int num = ShortcutExtensions.DOKill(canvasGroup, complete: true);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(canvasGroup, 0f, 0.3f);
		canvasGroup.interactable = false;
	}

	private void ShowBlocker()
	{
		//IL_002b: Expected O, but got I
		popup.ShowBlurOnly();
		PopupUI popupUI = popup;
		object obj = (nint)0 + (nint)3816;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Component component = default(Component);
		int num = ShortcutExtensions.DOKill(component, complete: true);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade((Graphic)component, 0.3f, 0.3f);
		GameObject gameObject = component.gameObject;
		gameObject.SetActive(value: true);
	}

	private void HideBlocker()
	{
		//IL_002b: Expected O, but got I
		//IL_0037: Expected O, but got I
		popup.HideBlurOnly();
		PopupUI popupUI = popup;
		object obj = (nint)0 + (nint)3816;
		object obj2 = (nint)0 + (nint)2456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		Component component = default(Component);
		int num = ShortcutExtensions.DOKill(component, complete: true);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade((Graphic)component, 0f, 0.3f);
		TweenCallback tweenCallback = TweenHelpers.Disable(component);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	private void <ShowMatchStatus>b__25_3()
	{
		//IL_000a: Expected O, but got I
		IntPtr intPtr = default(IntPtr);
		UpdateOnlineIndicators((User)(nint)intPtr);
	}

	private void <ShowMatchStatus>b__25_4()
	{
		//IL_000a: Expected O, but got I
		IntPtr intPtr = default(IntPtr);
		UpdateOnlineIndicators((User)(nint)intPtr);
	}

	private void <ShowMatchStatus>b__25_5()
	{
		//IL_000a: Expected O, but got I
		IntPtr intPtr = default(IntPtr);
		UpdateOnlineIndicators((User)(nint)intPtr);
	}

	private void <UpdateOnlineIndicators>b__26_0(Image indicator, PlayerInfo player)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0085: Expected O, but got I4
		Sprite stateSprite = GetStateSprite(player);
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		indicator.sprite = stateSprite;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+E4]");
		float alpha;
		if ((nint)0 != 0)
		{
			bool flag = indicator.m_Sprite == onlineSprite;
			bool flag2 = !flag;
			object obj3 = !flag2;
			alpha = 1f;
			if (obj3 == null)
			{
				goto IL_00a0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(indicator.m_Sprite == onlineSprite))
			{
				goto IL_00a0;
			}
			alpha = 1f;
		}
		goto IL_0118;
		IL_00a0:
		alpha = offlineSpriteAlpha;
		goto IL_0118;
		IL_0118:
		UIExtensions.SetAlpha(indicator, alpha);
	}

	private void <UpdateOnlineIndicators>b__26_1(Image indicator, PlayerInfo player)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0085: Expected O, but got I4
		Sprite stateSprite = GetStateSprite(player);
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		indicator.sprite = stateSprite;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+E4]");
		float alpha;
		if ((nint)0 != 0)
		{
			bool flag = indicator.m_Sprite == onlineSprite;
			bool flag2 = !flag;
			object obj3 = !flag2;
			alpha = 1f;
			if (obj3 == null)
			{
				goto IL_00a0;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			if (!(indicator.m_Sprite == onlineSprite))
			{
				goto IL_00a0;
			}
			alpha = 1f;
		}
		goto IL_0118;
		IL_00a0:
		alpha = offlineSpriteAlpha;
		goto IL_0118;
		IL_0118:
		UIExtensions.SetAlpha(indicator, alpha);
	}
}
