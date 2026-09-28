using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using DataTracking;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Kammelna.Server.WebRequests;
using Mono.Btls;
using ReportEnums;
using Server.Models;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;
using Util;

public class PlayerControl : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Action <>9__26_0;

		public static Action<Button> <>9__40_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2352;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal void <Start>b__26_0()
		{
		}

		internal void <AnimatedSwitchGroup>b__40_0(Button c)
		{
			//IL_0011: Expected O, but got I
			//IL_001d: Expected O, but got I
			object obj = (nint)0 + (nint)2440;
			object obj2 = (nint)0 + (nint)2904;
			Transform transform = c.transform;
			int num = ShortcutExtensions.DOKill(transform, complete: true);
			Transform transform2 = c.transform;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(transform2, 0.8f, 0.5f);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @305835C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		}
	}

	private PlayerProfileControls profile;

	private RectTransform container;

	private GameObject allControls;

	private GameObject confirmSection;

	private CanvasGroup userControls;

	private CanvasGroup managementsControls;

	private GameObject roomSection;

	private GameObject adminSection;

	private GameObject manageButton;

	private GameObject blocker;

	private TextMeshProUGUI confirmTitle;

	private GameObject feedback;

	private Sprite successBackground;

	private Sprite errorBackground;

	private CardBacksSprites cardsSprites;

	private ComponentReference<ModeratorControl> modControlRef;

	private GameEventsChannel gameEventsChannel;

	private KGame game;

	private KPlayer player;

	private VivoxManager voiceChatManager;

	private Action confirmCallback;

	private string playerDbId;

	private string playerNickName;

	private bool forceClose;

	private bool hasReportedAlready;

	private bool IsModerator
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f3: Expected O, but got I
			//IL_011d: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0182: Expected I4, but got O
			//IL_0166: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E65DB]");
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
			goto IL_0174;
			IL_00b8:
			User localUser = sessionModel.LocalUser;
			return SFSKammelnaUserExtensions.Can(localUser, UserPermission.KickAndMutePlayers);
			IL_0174:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_0174;
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_03d6: Expected O, but got I
		//IL_03e2: Expected O, but got I
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_0402: Expected O, but got I
		//IL_042c: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0098: Expected I, but got O
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00e9: Expected I, but got O
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_010e: Expected O, but got I
		//IL_013a: Expected I, but got O
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0173: Expected O, but got I
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_019f: Expected O, but got I
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01ce: Expected O, but got I4
		//IL_01eb: Expected I, but got O
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_02fe: Expected O, but got I
		//IL_030e: Expected O, but got I
		//IL_0338: Expected O, but got I4
		//IL_0348: Expected O, but got I
		//IL_0277: Expected O, but got I
		//IL_0287: Expected O, but got I
		//IL_02b1: Expected O, but got I4
		//IL_0380: Expected O, but got I4
		//IL_0466: Expected O, but got I
		//IL_0477: Expected I, but got O
		//IL_0495: Expected O, but got I
		//IL_02cf: Expected O, but got I
		//IL_03b0: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)136;
		object obj3 = (nint)0 + (nint)248;
		object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2496;
		object obj5 = (nint)0 + (nint)544;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj8 = this + 168;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj10 = this + 184;
		object obj11 = default(object);
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj5);
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj13 = (nint)0 + (nint)552;
		gameEventsChannel.OnPlayerClicked += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj13);
		object obj14 = typeof(SqlSingle[]) + 2376;
		object obj15 = (nint)0 + (nint)496;
		gameEventsChannel.OnWatcherClicked += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj15);
		gameEventsChannel.OnPanelShow += action3;
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
		object obj17 = (nint)0 + (nint)512;
		object obj18 = typeof(UsageHint) + 744;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X8_v9+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v10+10]");
		object obj22 = default(object);
		object obj21 = 0 * obj22;
		container.anchoredPosition = (Vector2)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj17);
		SFS.OnUserLeaveRoom += action4;
		GameObject go = base.gameObject;
		object obj23 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2352;
		object obj24 = "utf-32" + 344;
		Room room = game.Room;
		object obj25 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v37+E4]");
		object obj26;
		Action action5;
		string varName;
		string text;
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v37+B8]");
			obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v15+8]");
			action5 = (Action)0;
			varName = (string)obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v15+8]");
			bool flag2 = (nint)0 == 0;
			object obj27 = !flag2;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v15+8]");
				Action action6 = (Action)0;
				text = (string)obj24;
				goto IL_035e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v37+B8]");
			obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v15+8]");
			Action action6 = (Action)0;
			text = (string)obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v15+8]");
			bool flag3 = (nint)0 == 0;
			object obj28 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v15+8]");
			action5 = (Action)0;
			varName = (string)obj24;
			if (obj28 == null)
			{
				goto IL_035e;
			}
		}
		goto IL_043a;
		IL_043a:
		VariableBinderExtensions.Bind(go, room, varName, action5);
		return;
		IL_035e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v37+E4]");
		bool flag4 = (nint)0 == 0;
		object obj29 = !flag4;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj30 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v19+B8]");
			obj26 = 0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj31 = (nint)0 + (nint)704;
		Action action7 = default(Action);
		action7..ctor(obj26, (IntPtr)obj31);
		object obj32 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v18+B8]");
		object obj33 = (nint)0 + (nint)8;
		obj33 = action7;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		action5 = action7;
		varName = text;
		goto IL_043a;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_012c: Expected I, but got O
		//IL_005d: Expected I, but got O
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0082: Expected O, but got I
		//IL_00ae: Expected I, but got O
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_00ff: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3936;
		object obj2 = (nint)0 + (nint)512;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2496;
		object obj4 = (nint)0 + (nint)544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		SFS.OnUserLeaveRoom -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj6 = (nint)0 + (nint)552;
		gameEventsChannel.OnPlayerClicked -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj6);
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)496;
		gameEventsChannel.OnWatcherClicked -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj8);
		gameEventsChannel.OnPanelShow -= action4;
	}

	private void ShowControls(KPlayer targetPlayer)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e5: Expected O, but got I
		//IL_0133: Expected I, but got O
		GameObject gameObject = base.gameObject;
		bool activeInHierarchy = gameObject.activeInHierarchy;
		if (targetPlayer != null && activeInHierarchy)
		{
			object obj = this + 176;
			obj = targetPlayer;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (((KPlayer)obj).IsHuman && !((KPlayer)obj).IsMe)
			{
				object obj2 = typeof(SqlSingle[]) + 2376;
				object obj3 = (nint)0 + (nint)496;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Action action = default(Action);
				action..ctor(this, (IntPtr)obj3);
				player.OnUserChanged += action;
				string dBId = ((KPlayer)obj).DBId;
				ShowControls(dBId);
			}
		}
	}

	public void ShowControls(string userDbId)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0069: Expected O, but got I4
		//IL_0092: Expected O, but got I
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_0122: Expected O, but got I
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0147: Expected I, but got O
		//IL_0157: Expected O, but got I
		//IL_01ed: Expected O, but got I
		//IL_0216: Expected O, but got I
		//IL_0252: Expected O, but got I
		//IL_0192: Expected O, but got I
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053d: Expected O, but got Unknown
		//IL_0546: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Expected O, but got Unknown
		//IL_055b: Expected O, but got I
		//IL_057f: Expected O, but got I4
		//IL_029d: Expected O, but got I
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_059d: Expected O, but got I
		//IL_0333: Expected O, but got I4
		//IL_0368: Expected O, but got I4
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d2: Expected O, but got Unknown
		//IL_042a: Expected O, but got I4
		//IL_0458: Expected O, but got I4
		GameObject gameObject = base.gameObject;
		if (!gameObject.activeInHierarchy)
		{
			return;
		}
		object obj = typeof(Queue<string>) + 848;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X0_v8+E4]");
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
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		if (userDbId == dbId)
		{
			return;
		}
		object obj5 = this + 200;
		obj5 = userDbId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X21_v5-20]");
		Room room = ((KGame)0).Room;
		object obj6 = typeof(RegisteredWaitHandle) + 1376;
		nint num = (nint)room;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01d3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X10_v7-8]");
			if (0 == (nint)obj6)
			{
				break;
			}
			obj8 += 16;
			obj7--;
			if ((nint)obj7 != 1)
			{
				continue;
			}
			goto IL_01d3;
		}
		object obj9 = obj8 + 26;
		object obj10 = num + obj9;
		object obj11 = obj10 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v25+8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v328 @ X8_v25] (should have been resolved before IL gen)");
		User user = default(User);
		bool flag2 = user == null;
		object obj13 = !flag2;
		if (obj13 != null)
		{
			goto IL_022c;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v25+8]");
		object obj14 = 0;
		string text = (string)(object)user;
		goto IL_0246;
		IL_022c:
		text = SFSKammelnaUserExtensions.GetUserName(user);
		obj14 = obj12;
		goto IL_0246;
		IL_039e:
		bool active;
		manageButton.SetActive(active);
		Room room2 = game.Room;
		GameType gameType = SFSKammelnaRoomExtensions.GetGameType(room2);
		bool active2;
		if (GameTypeExtensions.IsFriendly(gameType))
		{
			bool isRoomOwner = game.IsRoomOwner;
			if (isRoomOwner)
			{
				bool isModerator = ((PlayerControl)isRoomOwner).IsModerator;
				active2 = (byte)((isModerator ? 1u : 0u) ^ 1u) != 0;
				bool flag3 = (object)roomSection == null;
				object obj15 = !flag3;
				if (obj15 == null)
				{
					throw new NullReferenceException();
				}
				goto IL_0479;
			}
		}
		active2 = false;
		goto IL_0479;
		IL_0246:
		object obj16 = (nint)0 + (nint)2000;
		string text2 = (string)((text != null) ? text : obj16);
		object obj17 = this + 208;
		obj17 = text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X20_v5-30]");
		((GameEventsChannel)0).TriggerPanelShow();
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(container, 0f, 0.2f);
		blocker.SetActive(value: true);
		profile.PopulateFromSFS(playerDbId);
		ShowDefaultView();
		Room room3 = game.Room;
		GameType gameType2 = SFSKammelnaRoomExtensions.GetGameType(room3);
		bool flag4 = GameTypeExtensions.IsFriendly(gameType2);
		bool flag5 = !flag4;
		PlayerControl playerControl = (PlayerControl)flag4;
		if (!flag5)
		{
			bool isRoomOwner2 = game.IsRoomOwner;
			bool flag6 = !isRoomOwner2;
			playerControl = (PlayerControl)isRoomOwner2;
			if (!flag6)
			{
				active = true;
				goto IL_039e;
			}
		}
		bool isModerator2 = playerControl.IsModerator;
		active = isModerator2;
		goto IL_039e;
		IL_0479:
		roomSection.SetActive(active2);
		bool isModerator3 = ((PlayerControl)(object)roomSection).IsModerator;
		adminSection.SetActive(isModerator3);
		ITrackEvent trackEvent = TrackerLibrary.ProfileMiniProfileViewed(TrackingPlacement.InGame);
		object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		object obj19 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v21+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
		return;
		IL_01d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v58+8]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v295 @ X0_v58] (should have been resolved before IL gen)");
		bool flag7 = user == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X0_v58+8]");
		obj14 = 0;
		text = (string)(object)user;
		if (!flag7)
		{
			goto IL_022c;
		}
		goto IL_0246;
	}

	public void HideControls()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_007a: Expected O, but got I
		//IL_0088: Expected I, but got O
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I4
		//IL_011b: Expected O, but got I
		//IL_0133: Expected I, but got O
		if (blocker.activeSelf)
		{
			TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPosY(container, 500f, 0.2f);
			object obj = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = (nint)0 + (nint)488;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.2f, action);
			blocker.SetActive(value: false);
			if (player != null)
			{
				object obj6 = (nint)0 + (nint)496;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Action action2 = default(Action);
				action2..ctor(this, (IntPtr)obj6);
				player.OnUserChanged -= action2;
			}
		}
	}

	private void RegisterUserEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_004d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		player.OnUserChanged += action;
	}

	private void UnregisterUserEvents()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		if (player != null)
		{
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)496;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj2);
			player.OnUserChanged -= action;
		}
	}

	private void OnUserLeaveRoom(User user)
	{
		string dbId = SFSKammelnaUserExtensions.GetDbId(user);
		if (dbId == playerDbId)
		{
			HideControls();
		}
	}

	private void ShowConfirmation(string cTitle, Action callback)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0038: Expected O, but got I
		object obj = this + 192;
		obj = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X21_v2-90]");
		((GameObject)0).SetActive(value: false);
		confirmSection.SetActive(value: true);
		TextMeshProExtensions.Localize(confirmTitle, cTitle);
	}

	private void HideConfirmation()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0039: Expected O, but got I
		object obj = this + 192;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v13 @ X20_v2-90]");
		((GameObject)0).SetActive(value: true);
		confirmSection.SetActive(value: false);
		feedback.SetActive(value: false);
		forceClose = false;
	}

	private void ShowSuccess(string text)
	{
		//IL_0026: Expected O, but got I
		//IL_0055: Expected O, but got I
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0075: Expected O, but got I
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00bd: Expected I, but got O
		//IL_00ec: Expected O, but got I4
		feedback.SetActive(value: true);
		object obj = (nint)0 + (nint)1312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		Image image = default(Image);
		image.sprite = successBackground;
		object obj2 = (nint)0 + (nint)1560;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)496;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E331E4");
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, text);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
	}

	private void ShowError(string text)
	{
		//IL_0026: Expected O, but got I
		//IL_0055: Expected O, but got I
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0075: Expected O, but got I
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00bd: Expected I, but got O
		//IL_00ec: Expected O, but got I4
		feedback.SetActive(value: true);
		object obj = (nint)0 + (nint)1312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
		Image image = default(Image);
		image.sprite = errorBackground;
		object obj2 = (nint)0 + (nint)1560;
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)496;
		object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E331E4");
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, text);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(1f, action);
	}

	private void ShowGroup(CanvasGroup group)
	{
		GameObject gameObject = group.gameObject;
		gameObject.SetActive(value: true);
	}

	private void HideGroup(CanvasGroup group)
	{
		GameObject gameObject = group.gameObject;
		gameObject.SetActive(value: false);
	}

	private void AnimatedSwitchGroup(CanvasGroup showGroup, CanvasGroup hideGroup)
	{
		//IL_0048: Expected O, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_014d: Expected O, but got I
		//IL_015d: Expected O, but got I
		//IL_016d: Expected O, but got I
		//IL_018f: Expected O, but got I4
		//IL_01b7: Expected O, but got I
		//IL_00b2: Expected O, but got I
		//IL_00c2: Expected O, but got I
		//IL_00d2: Expected O, but got I
		//IL_00f4: Expected O, but got I4
		//IL_01e7: Expected O, but got I4
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_0271: Expected O, but got I
		//IL_0282: Expected I, but got O
		//IL_02a0: Expected O, but got I
		//IL_012a: Expected O, but got I
		//IL_0217: Expected O, but got I
		GameObject gameObject = showGroup.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = hideGroup.gameObject;
		object obj = (nint)0 + (nint)672;
		object obj2 = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 2352;
		gameObject2.SetActive(value: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v13+E4]");
		object obj5;
		Action<object> action;
		IEnumerable<object> enumeration;
		IEnumerable<object> enumerable = default(IEnumerable<object>);
		object obj7;
		IEnumerable<object> enumerable2;
		object obj4;
		if ((nint)0 != 0)
		{
			obj4 = (nint)0 + (nint)2072;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v13+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v6+10]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v6+10]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			enumeration = enumerable;
			if (obj6 == null)
			{
				obj7 = obj4;
				enumerable2 = enumerable;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v6+10]");
				Action<object> action2 = (Action<object>)0;
				goto IL_01c5;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
			obj7 = (nint)0 + (nint)2072;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v13+B8]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v6+10]");
			Action<object> action2 = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v6+10]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			enumerable2 = enumerable;
			obj4 = obj7;
			enumeration = enumerable;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X8_v6+10]");
			action = (Action<object>)0;
			if (obj8 == null)
			{
				goto IL_01c5;
			}
		}
		goto IL_0239;
		IL_01c5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v13+E4]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X8_v12+B8]");
			obj5 = 0;
		}
		object obj11 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)696;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj5, (IntPtr)obj12);
		object obj13 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v11+B8]");
		object obj14 = (nint)0 + (nint)16;
		obj14 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4 = obj7;
		enumeration = enumerable2;
		action = action3;
		goto IL_0239;
		IL_0239:
		ArraysExtensions.ForEach(enumeration, action);
	}

	public void ShowDefaultView()
	{
		GameObject gameObject = userControls.gameObject;
		gameObject.SetActive(value: true);
		GameObject gameObject2 = managementsControls.gameObject;
		gameObject2.SetActive(value: false);
	}

	public void ShowManagement()
	{
		AnimatedSwitchGroup(managementsControls, userControls);
	}

	public void ShowUserControls()
	{
		AnimatedSwitchGroup(userControls, managementsControls);
	}

	public void ShowFullProfile()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0064: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1040;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfile.ShowDetailProfile(playerDbId, TrackingPlacement.InGame);
	}

	public void BlockerClicked()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0079: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		if (confirmCallback == null || forceClose)
		{
			HideControls();
			return;
		}
		object obj = typeof(UsageHint) + 816;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v6+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v7+C]");
		object obj4 = default(object);
		float duration = 0f * (float)obj4;
		float elasticity = default(float);
		Tweener tweener = ShortcutExtensions.DOPunchScale(container, (Vector3)7, duration, 0, elasticity);
		forceClose = true;
	}

	public void Confirm()
	{
		Action action = confirmCallback;
		if (confirmCallback != null)
		{
			IntPtr invoke_impl = ((Delegate)action).invoke_impl;
			IntPtr method_code = ((Delegate)action).method_code;
			IntPtr method = ((Delegate)action).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void Cancel()
	{
		HideConfirmation();
	}

	public void OnReportPhotoClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_008c: Expected I, but got O
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_004a: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)520;
		object text = "Read object reference Id '{0}' for {1}." + 2320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = this + 192;
		obj3 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X22_v4-90]");
		((GameObject)0).SetActive(value: false);
		confirmSection.SetActive(value: true);
		TextMeshProExtensions.Localize(confirmTitle, (string)text);
	}

	public void OnOffendingPlayerClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_008c: Expected I, but got O
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_004a: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)504;
		object text = "October" + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = this + 192;
		obj3 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X22_v4-90]");
		((GameObject)0).SetActive(value: false);
		confirmSection.SetActive(value: true);
		TextMeshProExtensions.Localize(confirmTitle, (string)text);
	}

	public void OnRoomMuteClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_008c: Expected I, but got O
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_004a: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)536;
		object text = "Material with texture name \"" + 3096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = this + 192;
		obj3 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X22_v4-90]");
		((GameObject)0).SetActive(value: false);
		confirmSection.SetActive(value: true);
		TextMeshProExtensions.Localize(confirmTitle, (string)text);
	}

	public void OnRoomKickClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_008c: Expected I, but got O
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_004a: Expected O, but got I
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)528;
		object text = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 3960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = this + 192;
		obj3 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X22_v4-90]");
		((GameObject)0).SetActive(value: false);
		confirmSection.SetActive(value: true);
		TextMeshProExtensions.Localize(confirmTitle, (string)text);
	}

	public void OnMuteClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2776;
		object obj2 = (nint)0 + (nint)456;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)2160;
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

	public void OnKickClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2776;
		object obj2 = (nint)0 + (nint)448;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)2160;
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

	public void OnUnmuteClick()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_005f: Expected O, but got I
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2776;
		object obj2 = (nint)0 + (nint)464;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj4 = (nint)0 + (nint)2160;
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

	private void ReportPhotoRequest()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Expected O, but got I
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		//IL_00a3: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 2040;
		object key = "https://www.kammelna.com/Home/Terms" + 328;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)496;
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, playerDbId);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.5f, action);
	}

	private void OffendingPlayerRequest()
	{
		//IL_04d6: Expected O, but got I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0044: Expected O, but got I
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0070: Expected I, but got O
		//IL_009f: Expected O, but got I4
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_015e: Expected O, but got I8
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_01bf: Expected O, but got I4
		//IL_01d5: Expected O, but got I
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_0251: Expected O, but got I8
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_02b2: Expected O, but got I4
		//IL_02c8: Expected O, but got I
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_0307: Expected O, but got I
		//IL_0310: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_0357: Expected O, but got I4
		//IL_036d: Expected O, but got I
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0401: Expected O, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_0470: Expected O, but got I
		//IL_047e: Expected I, but got O
		string chatText = ChatHandler.GetChatText();
		bool flag = string.IsNullOrWhiteSpace(chatText);
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj != null || hasReportedAlready)
		{
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = (nint)0 + (nint)496;
			object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj3);
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v7+E4]");
			bool flag3 = (nint)0 == 0;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.5f, action);
			return;
		}
		object obj7 = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array.Length != 0)
		{
			object obj8 = "{0} color encoding is currently unsupported for outputting to HDR." + 2232;
			object obj9 = array + 32;
			obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X21_v7-8]");
			object obj10 = 0 & 0xFFFFFFFEL;
			if (obj10 != null)
			{
				object obj11 = array + 40;
				obj11 = playerNickName;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X21_v9-10]");
				bool flag4 = (nint)0 < (nint)2;
				object obj12 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X21_v9-10]");
				object obj13 = -2;
				bool flag5 = obj13 == null;
				object obj14 = ~obj12;
				object obj15 = obj14 | flag5;
				if (obj15 == null)
				{
					object obj16 = "&action=sign-up" + 3520;
					object obj17 = array + 48;
					obj17 = obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X21_v11-18]");
					object obj18 = 0 & 0xFFFFFFFCL;
					if (obj18 != null)
					{
						object obj19 = array + 56;
						obj19 = playerDbId;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X21_v13-20]");
						bool flag6 = (nint)0 < (nint)4;
						object obj20 = !flag6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X21_v13-20]");
						object obj21 = -4;
						bool flag7 = obj21 == null;
						object obj22 = ~obj20;
						object obj23 = obj22 | flag7;
						if (obj23 == null)
						{
							object obj24 = (nint)0 + (nint)2544;
							object obj25 = array + 64;
							obj25 = obj24;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							string chatText2 = ChatHandler.GetChatText();
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X21_v15-28]");
							bool flag8 = (nint)0 < (nint)5;
							object obj26 = !flag8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X21_v15-28]");
							object obj27 = -5;
							bool flag9 = obj27 == null;
							object obj28 = ~obj26;
							object obj29 = obj28 | flag9;
							if (obj29 == null)
							{
								object obj30 = array + 72;
								obj30 = chatText2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								string text = string.Concat(array);
								SupportTicketRequestModel supportTicketRequestModel = SupportTicketRequestModel.MakeDefaultInstance(ProblemCategory.PlayerReport);
								supportTicketRequestModel.<PlayerReportType>k__BackingField = PlayerReportType.Cheating;
								object obj31 = supportTicketRequestModel + 48;
								obj31 = text;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								string chatUsersInfoString = ChatHandler.GetChatUsersInfoString();
								object obj32 = supportTicketRequestModel + 56;
								obj32 = chatUsersInfoString;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj33 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj34 = (nint)0 + (nint)440;
								Action<object> action2 = default(Action<object>);
								action2..ctor((object)this, (IntPtr)obj34);
								KammelnaRequests.SendReport(supportTicketRequestModel, action2);
								return;
							}
						}
					}
				}
			}
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
	}

	private void RoomMuteRequest()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_0056: Expected I, but got O
		//IL_0080: Expected O, but got I4
		object key = "m_StencilDeferredPS" + 2792;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj2 = (nint)0 + (nint)480;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "m_StencilDeferredPS" + 2800;
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, playerDbId);
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendRoomRequest(go, (string)command, param, keepListening: false, action);
	}

	private void RoomBanRequest()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002f: Expected O, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_0056: Expected I, but got O
		//IL_0080: Expected O, but got I4
		object key = "alignContent" + 3832;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2360;
		object obj2 = (nint)0 + (nint)472;
		object obj3 = typeof(System.Formats.Asn1.SetOfValueComparer) + 72;
		object command = "alignContent" + 3824;
		ISFSObject param = SfsObjectUtil.FromOneValue((string)key, playerDbId);
		GameObject go = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SfsRequestListener.SendRoomRequest(go, (string)command, param, keepListening: false, action);
	}

	private void <OnMuteClick>b__52_0(ModeratorControl instance)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0040: Expected O, but got I4
		int userId = int.Parse(playerDbId);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069538]");
		instance._type = ModeratorControl.ModeratorAction.Kick;
		object obj = instance + 104;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		instance._userId = userId;
		ToggleGroupExtensions.SetSelectedIndex(instance.toggles, 1);
		instance.ShowPopup();
	}

	private void <OnKickClick>b__53_0(ModeratorControl instance)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0040: Expected O, but got I4
		int userId = int.Parse(playerDbId);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069538]");
		instance._type = ModeratorControl.ModeratorAction.Kick;
		object obj = instance + 104;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		instance._userId = userId;
		ToggleGroupExtensions.SetSelectedIndex(instance.toggles, 0);
		instance.ShowPopup();
	}

	private void <OnUnmuteClick>b__54_0(ModeratorControl instance)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0040: Expected O, but got I4
		int userId = int.Parse(playerDbId);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7069538]");
		instance._type = ModeratorControl.ModeratorAction.Kick;
		object obj = instance + 104;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		instance._userId = userId;
		ToggleGroupExtensions.SetSelectedIndex(instance.toggles, 2);
		instance.ShowPopup();
	}

	private void <OffendingPlayerRequest>b__57_0(KammelnaResponseModel<bool> response)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0093: Expected O, but got I4
		//IL_00d1: Expected O, but got I4
		//IL_00f7: Expected O, but got I4
		//IL_010d: Expected I, but got O
		//IL_011d: Expected O, but got I
		//IL_0146: Expected O, but got I
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01fe: Expected O, but got I4
		//IL_02a1: Expected O, but got I4
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		KammelnaResponseModel<bool> kammelnaResponseModel = default(KammelnaResponseModel<bool>);
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (kammelnaResponseModel != null)
		{
			if (!kammelnaResponseModel.Succeeded)
			{
				string errorMessage = kammelnaResponseModel.ErrorMessage;
				ShowError(errorMessage);
				HideControls();
				return;
			}
			hasReportedAlready = true;
			object obj = typeof(TypeConverter<ushort, char>) + 3400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			object obj2 = typeof(UsageHint) + 72;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string email = UserInfo.Email;
			object[] array = default(object[]);
			bool flag2 = array == null;
			kammelnaResponseModel = (KammelnaResponseModel<bool>)1;
			if (!flag2)
			{
				bool flag3 = email == null;
				KammelnaResponseModel<bool> kammelnaResponseModel2 = (KammelnaResponseModel<bool>)1;
				if (!flag3)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
					kammelnaResponseModel2 = (KammelnaResponseModel<bool>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v25 (Il2CppClass<System.Object[]>)+40]");
					kammelnaResponseModel = (KammelnaResponseModel<bool>)0;
					if (flag4)
					{
						goto IL_025b;
					}
				}
				bool flag5 = array.Length == 0;
				kammelnaResponseModel = kammelnaResponseModel2;
				if (!flag5)
				{
					object obj5 = array + 32;
					obj5 = email;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					object text = "Read object reference Id '{0}' for {1}." + 2328;
					LocalizableText text2 = TextMeshProExtensions.LocalizeWith((string)text, array);
					object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1240;
					object obj7 = obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v22+E4]");
					bool flag6 = (nint)0 == 0;
					object obj8 = !flag6;
					if (obj8 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Toast.Show(text2, (Vector2)0, 0f);
					object text3 = "Read object reference Id '{0}' for {1}." + 2312;
					ShowSuccess((string)text3);
					return;
				}
				goto IL_024d;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_024d;
		IL_025b:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_024d:
		ex = new IndexOutOfRangeException();
		goto IL_025b;
	}

	private void <RoomMuteRequest>b__58_0(ISFSObject _)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "Material with texture name \"" + 3112;
		ShowSuccess((string)text);
	}

	private void <RoomBanRequest>b__59_0(ISFSObject _)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		object text = "AvailableVoices" + 1040;
		ShowSuccess((string)text);
	}
}
