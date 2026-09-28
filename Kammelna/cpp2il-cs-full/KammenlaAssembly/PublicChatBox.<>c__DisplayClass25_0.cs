using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Features.Clans;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Mono.Btls;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PublicChatBox : BaseChatbox
{
	private sealed class <>c__DisplayClass22_0
	{
		public Room room;

		public bool isChatEnabled;

		internal void <MuteChatNow>g__SendMuteRequest|0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_01cc: Expected O, but got I4
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected O, but got Unknown
			//IL_00f1: Expected I, but got O
			//IL_0101: Expected O, but got I
			//IL_0224: Expected O, but got I4
			//IL_013c: Expected O, but got I
			//IL_0257: Unknown result type (might be due to invalid IL or missing references)
			//IL_025c: Expected O, but got Unknown
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_026a: Expected O, but got Unknown
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected O, but got Unknown
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			object obj = 152989696;
			object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E76A0]");
			object obj3 = (nint)0 & (nint)1;
			nint num2;
			nint num;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v8+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v8+E4]");
				num2 = 0;
				if (!flag)
				{
					goto IL_009d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v8+E4]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v8+E4]");
				num2 = 0;
				if (obj5 != null)
				{
					goto IL_009d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.DismissMessage();
			Room room = this.room;
			bool flag3 = this.room == null;
			object obj6 = !flag3;
			num = num2;
			Room room2 = this.room;
			if (obj6 != null)
			{
				goto IL_00d5;
			}
			goto IL_0244;
			IL_02a3:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ X0_v1] (should have been resolved before IL gen)");
			int roomId = default(int);
			SFS.SendControlChat(roomId, isChatEnabled);
			return;
			IL_017d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_02a3;
			IL_00d5:
			object obj7 = typeof(RegisteredWaitHandle) + 1376;
			num = (nint)room;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_017d;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X8_v4 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj9 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v139 @ X10_v2-8]");
				bool flag4 = 0 == (nint)obj7;
				room2 = room;
				if (flag4)
				{
					break;
				}
				obj9 += 16;
				obj8--;
				if ((nint)obj8 != 1)
				{
					continue;
				}
				goto IL_017d;
			}
			object obj10 = num + obj9;
			object obj11 = obj10 + 312;
			room = room2;
			goto IL_02a3;
			IL_009d:
			PopupWindow.DismissMessage();
			room = this.room;
			bool flag5 = this.room == null;
			room2 = this.room;
			if (!flag5)
			{
				goto IL_00d5;
			}
			goto IL_0244;
			IL_0244:
			throw new NullReferenceException();
		}
	}

	private sealed class <>c__DisplayClass24_0
	{
		public PublicChatBox <>4__this;

		public KGame game;

		internal void <InitializeMuteButton>g__OnGameOnPlayerSwitchSeat|0(int i = 0, string s = "")
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0100: Expected O, but got I4
			PublicChatBox publicChatBox = <>4__this;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				if (!(publicChatBox.muteVoteButton != null))
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = publicChatBox.muteVoteButton != null;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					return;
				}
			}
			PublicChatBox publicChatBox2 = <>4__this;
			GameObject gameObject = publicChatBox2.muteVoteButton.gameObject;
			bool isSpectator = game.IsSpectator;
			bool active = (byte)((isSpectator ? 1u : 0u) ^ 1u) != 0;
			gameObject.SetActive(active);
		}
	}

	private sealed class <>c__DisplayClass25_0
	{
		public PublicChatBox <>4__this;

		public KGame game;

		internal void <InitializePlayerControls>g__OnGameOnPlayerSwitchSeat|0(int i = 0, string _ = "")
		{
			PublicChatBox publicChatBox = <>4__this;
			bool active;
			if (game.IsSpectator)
			{
				active = false;
			}
			else
			{
				KGame kGame = game;
				bool isGameStarted = kGame.<GamePhase>k__BackingField.IsGameStarted;
				active = isGameStarted;
			}
			publicChatBox.ignoreWatchersSection.SetActive(active);
		}

		internal void <InitializePlayerControls>b__1()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00bf: Expected O, but got I4
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Expected O, but got Unknown
			//IL_00e5: Expected O, but got I
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool ignoreWatchersChat = Preferences.IgnoreWatchersChat;
			bool ignoreWatchersChat2 = (byte)((ignoreWatchersChat ? 1u : 0u) ^ 1u) != 0;
			Preferences.IgnoreWatchersChat = ignoreWatchersChat2;
			PublicChatBox publicChatBox = <>4__this;
			bool ignoreWatchersChat3 = Preferences.IgnoreWatchersChat;
			publicChatBox.ignoreWatchersToggler.ToggleManual(ignoreWatchersChat3);
			object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v7+B8]");
			object activeGroup = 0;
			ChatHandler.ActiveGroup = (string)activeGroup;
		}
	}

	public Button muteVoteButton;

	public Sprite muteIcon;

	public GameObject ignoreWatchersSection;

	public BaseToggler ignoreWatchersToggler;

	public Button ignoreWatchersButton;

	public PopupUI popup;

	private bool isSubChat;

	private GameEventsChannel gameEventsChannel;

	private ChallengeEventsChannel challengeEvents;

	private bool IsGameChat
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_01d0: Expected O, but got I
			//IL_01fa: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0262: Expected I4, but got O
			//IL_00dc: Expected I4, but got O
			//IL_0243: Expected O, but got I4
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Expected O, but got Unknown
			//IL_0106: Expected I, but got O
			//IL_0116: Expected O, but got I
			//IL_01b4: Expected O, but got I
			//IL_0151: Expected O, but got I
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Expected O, but got Unknown
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Expected O, but got Unknown
			//IL_0290: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Expected O, but got Unknown
			//IL_02ad: Expected O, but got I
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Expected O, but got Unknown
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Expected O, but got Unknown
			object obj = 152989696;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7694]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 == null)
			{
				goto IL_01be;
			}
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
			goto IL_0210;
			IL_0251:
			NullReferenceException ex = new NullReferenceException();
			bool result = (byte)(int)ex != 0;
			goto IL_0267;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_0251;
			IL_00b8:
			Room currentRoom = sessionModel.CurrentRoom;
			bool flag2 = currentRoom == null;
			result = (byte)(int)currentRoom != 0;
			if (!flag2)
			{
				object obj7 = typeof(RegisteredWaitHandle) + 1376;
				nint num = (nint)currentRoom;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj9 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X10_v4-8]");
						if (0 != (nint)obj7)
						{
							obj9 += 16;
							obj8--;
							if ((nint)obj8 == 1)
							{
								break;
							}
						}
						else
						{
							object obj10 = obj9 + 6;
							object obj11 = num + obj10;
							object obj12 = obj11 + 312;
							object obj13 = obj12;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v13+8]");
							object obj14 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v104 @ X2_v3 (should have been resolved before IL gen)");
						}
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				object obj16 = default(object);
				object obj15 = obj16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X0_v20+8]");
				object obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v103 @ X2_v2 (should have been resolved before IL gen)");
				goto IL_01be;
			}
			goto IL_0267;
			IL_0267:
			return result;
			IL_01be:
			_ = 1;
			obj4 = (nint)0 + (nint)2200;
			obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj18 = !flag3;
			obj6 = obj4;
			if (obj18 != null)
			{
				goto IL_0091;
			}
			goto IL_0210;
			IL_0210:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag4 = (object)sessionModel == null;
			object obj19 = !flag4;
			if (obj19 != null)
			{
				goto IL_00b8;
			}
			goto IL_0251;
		}
	}

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0127: Expected O, but got I4
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00c8: Expected O, but got I4
		//IL_01a6: Expected O, but got I
		//IL_01be: Expected I, but got O
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_01f3: Expected O, but got I
		//IL_020b: Expected I, but got O
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7695]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = popup;
			obj6 = popup;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = popup;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = popup;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = typeof(SqlSingle[]) + 2376;
		bool flag3 = obj6;
		bool flag4 = !flag3;
		Action action = null;
		Action action2 = null;
		object obj9 = obj8;
		if (!flag4)
		{
			goto IL_019a;
		}
		goto IL_01e7;
		IL_01e7:
		object obj10 = (nint)0 + (nint)600;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj10);
		gameEventsChannel.OnSeatSwitch += action3;
		return;
		IL_019a:
		object obj11 = (nint)0 + (nint)592;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj11);
		gameEventsChannel.ShowChat += action4;
		action2 = action4;
		obj9 = obj8;
		goto IL_01e7;
		IL_0091:
		obj8 = typeof(SqlSingle[]) + 2376;
		bool flag5 = obj5;
		bool flag6 = !flag5;
		object obj12 = !flag6;
		action = null;
		if (obj12 != null)
		{
			goto IL_019a;
		}
		action2 = null;
		obj9 = obj8;
		goto IL_01e7;
	}

	public void OnEnable()
	{
		if (!isSubChat)
		{
			ChatHandler.ChatActive = true;
		}
	}

	public void OnDisable()
	{
		if (!isSubChat)
		{
			ChatHandler.ChatActive = false;
		}
	}

	protected override void RegisterSFSSceneCallbacks()
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
		//IL_0157: Expected O, but got I
		//IL_0205: Expected O, but got I4
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_01b7: Expected I, but got O
		//IL_026a: Expected I, but got O
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ad: Expected O, but got Unknown
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_02ff: Expected I, but got O
		//IL_0332: Expected I, but got O
		//IL_0361: Expected O, but got I4
		//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03b6: Expected O, but got I
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Expected O, but got Unknown
		//IL_03d6: Expected O, but got I
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fe: Expected O, but got Unknown
		//IL_0403: Expected I, but got O
		//IL_043f: Expected I, but got O
		//IL_046a: Expected I, but got O
		//IL_0494: Expected O, but got I4
		//IL_05a0: Expected O, but got I4
		//IL_05a9: Expected O, but got I4
		//IL_050b: Expected O, but got I4
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_0548: Expected O, but got I
		//IL_0556: Expected I, but got O
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7696]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v59+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v59+E4]");
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
		IL_0137:
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)600;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		if (currentRoom != null)
		{
			object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2544;
			GameObject go = base.gameObject;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj8);
			VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
		}
		GameObject go2 = base.gameObject;
		object obj9 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName2 = "setMimeType" + 3808;
		SessionModel sessionModel2 = default(SessionModel);
		User localUser = sessionModel2.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj8);
		VariableBinderExtensions.Bind(go2, localUser, (string)varName2, action2);
		GameObject go3 = base.gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object varName3 = "m_StencilDeferredPS" + 2520;
		object obj11 = typeof(RegisteredWaitHandle) + 56;
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
		SessionModel sessionModel3 = default(SessionModel);
		User localUser2 = sessionModel3.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj8);
		VariableBinderExtensions.Bind(go3, localUser2, (string)varName3, action3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj8);
		object obj13 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v26+E4]");
		bool flag4 = (nint)0 == 0;
		object obj14 = !flag4;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj16 = (nint)0 + (nint)568;
		object obj17 = typeof(TypeConverter<ushort, char>) + 528;
		object obj18 = (nint)0 + (nint)584;
		object obj19 = typeof(RegisteredWaitHandle) + 2944;
		object obj20 = typeof(MemberAchievementClanFeedData) + 2976;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v6 (Il2CppClass<PublicChatBox>)+1B0]");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)0);
		ChatHandler.OnMessage += action5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj16);
		ChatHandler.OnGroupChange += action6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
		unityAction..ctor((object)this, (IntPtr)obj18);
		object obj21 = obj19;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X0_v37+E4]");
		bool flag5 = (nint)0 == 0;
		object obj22 = !flag5;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		SceneManager.sceneLoaded += (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		object obj23 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v8+E4]");
		if ((nint)0 != 0)
		{
			bool flag6 = challengeEvents != null;
			bool flag7 = !flag6;
			object obj24 = 0;
			UnityEngine.Object obj25 = null;
			if (flag7)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag8 = challengeEvents != null;
			bool flag9 = !flag8;
			object obj26 = !flag9;
			object obj24 = 0;
			UnityEngine.Object obj25 = null;
			if (obj26 == null)
			{
				return;
			}
		}
		object obj27 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj28 = (nint)0 + (nint)576;
		Action<object> action7 = default(Action<object>);
		action7..ctor((object)this, (IntPtr)obj28);
		challengeEvents.OnChallengeActivity += action7;
		return;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag10 = (object)sessionModel == null;
		object obj29 = !flag10;
		if (obj29 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0137;
	}

	private void OnChallengeActivity(FriendlyChallengeData data)
	{
		AddChallengeMessage(data);
	}

	protected override void UnregisterSFSSceneCallbacks()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_008d: Expected O, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a6: Expected I, but got O
		//IL_00e2: Expected I, but got O
		//IL_010d: Expected I, but got O
		//IL_0137: Expected O, but got I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0188: Expected I, but got O
		//IL_0196: Expected I, but got O
		//IL_01c0: Expected O, but got I4
		//IL_0295: Expected O, but got I4
		//IL_0238: Expected O, but got I4
		//IL_0317: Expected I, but got O
		//IL_02be: Expected O, but got I
		//IL_02cc: Expected I, but got O
		//IL_02e9: Expected O, but got I4
		//IL_0254: Expected O, but got I4
		//IL_0411: Expected O, but got I4
		//IL_041f: Expected O, but got I4
		//IL_0381: Expected O, but got I4
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_03b9: Expected O, but got I
		//IL_03c7: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj3 = (nint)0 + (nint)568;
		object obj4 = typeof(TypeConverter<ushort, char>) + 528;
		object obj5 = (nint)0 + (nint)584;
		object obj6 = typeof(RegisteredWaitHandle) + 2944;
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)600;
		object obj9 = typeof(RegisteredWaitHandle) + 56;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X8_v4 (Il2CppClass<PublicChatBox>)+1B0]");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)0);
		ChatHandler.OnMessage -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj3);
		ChatHandler.OnGroupChange -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Scene, System.Int32Enum> unityAction = default(UnityAction<Scene, System.Int32Enum>);
		unityAction..ctor((object)this, (IntPtr)obj5);
		object obj10 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj12 = typeof(MemberAchievementClanFeedData) + 2976;
		SceneManager.sceneLoaded -= (UnityAction<Scene, LoadSceneMode>)(object)unityAction;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = (nint)obj8;
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj8);
		object obj13 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X0_v17+E4]");
		bool flag2 = (nint)0 == 0;
		object obj14 = !flag2;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RemoteConfig.OnChanged -= action3;
		object obj15 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X0_v20+E4]");
		object obj17;
		Action action5;
		if ((nint)0 != 0)
		{
			bool flag3 = popup;
			bool flag4 = !flag3;
			object obj16 = !flag4;
			Action action4 = null;
			if (obj16 != null)
			{
				goto IL_02a8;
			}
			obj17 = 0;
			action5 = null;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag5 = popup;
			bool flag6 = !flag5;
			Action action4 = null;
			obj17 = 0;
			action5 = null;
			if (!flag6)
			{
				goto IL_02a8;
			}
		}
		goto IL_02ff;
		IL_02ff:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action6 = default(Action);
		action6..ctor(this, (IntPtr)obj8);
		gameEventsChannel.OnSeatSwitch -= action6;
		object obj18 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X8_v9+E4]");
		if ((nint)0 != 0)
		{
			bool flag7 = challengeEvents != null;
			bool flag8 = !flag7;
			UnityEngine.Object obj19 = null;
			object obj20 = 0;
			if (flag8)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = challengeEvents != null;
			bool flag10 = !flag9;
			object obj21 = !flag10;
			UnityEngine.Object obj19 = null;
			object obj20 = 0;
			if (obj21 == null)
			{
				return;
			}
		}
		object obj22 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2032;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)576;
		Action<object> action7 = default(Action<object>);
		action7..ctor((object)this, (IntPtr)obj23);
		challengeEvents.OnChallengeActivity -= action7;
		return;
		IL_02a8:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)592;
		Action action8 = default(Action);
		action8..ctor(this, (IntPtr)obj24);
		gameEventsChannel.ShowChat -= action8;
		obj17 = 0;
		action5 = action8;
		num2 = 0;
		goto IL_02ff;
	}

	protected override void Init()
	{
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0069: Expected O, but got I4
		//IL_0092: Expected O, but got I
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00cf: Expected I, but got O
		//IL_00df: Expected O, but got I
		//IL_011a: Expected O, but got I
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		base.Init();
		InitializeMuteButton();
		InitializePlayerControls();
		if (ChatHandler.IsChatRoom)
		{
			object obj = typeof(Queue<string>) + 848;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v8+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			Room currentRoom = sessionModel.CurrentRoom;
			object obj5 = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)currentRoom;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v12 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj7 = (nint)0 + (nint)8;
				string activeGroup = default(string);
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X10_v4-8]");
					if (0 != (nint)obj5)
					{
						obj7 += 16;
						obj6--;
						continue;
					}
					object obj8 = obj7 + 1;
					object obj9 = num + obj8;
					object obj10 = obj9 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v142 @ X8_v15] (should have been resolved before IL gen)");
					ChatHandler.ActiveGroup = activeGroup;
					return;
				}
				while ((nint)obj6 != 1);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v176 @ X0_v15] (should have been resolved before IL gen)");
			string activeGroup2 = default(string);
			ChatHandler.ActiveGroup = activeGroup2;
		}
		else
		{
			object activeGroup3 = "{0} color encoding is currently unsupported for outputting to HDR." + 2192;
			ChatHandler.ActiveGroup = (string)activeGroup3;
		}
	}

	protected override void SendChatMessage(string message)
	{
		ChatHandler.SendChat(message);
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_014b: Expected O, but got I4
		//IL_008a: Expected O, but got I
		//IL_01d1: Expected O, but got I4
		//IL_0179: Expected O, but got I
		//IL_0193: Expected O, but got I4
		//IL_00ec: Expected O, but got I
		//IL_0209: Expected O, but got I
		object obj = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7699]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj5 = (nint)0 & (nint)1;
		bool flag2 = obj5 == null;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a7;
		}
		goto IL_01a1;
		IL_0114:
		UpdateMutedChatBlocker();
		return;
		IL_00dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v18+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v15+18]");
		if ((nint)0 == 3)
		{
			goto IL_0114;
		}
		return;
		IL_01e7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v4+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+18]");
		if ((nint)0 != 3)
		{
			return;
		}
		goto IL_0114;
		IL_0074:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4588]");
		object obj10 = (nint)0 & (nint)1;
		if (obj10 != null)
		{
			goto IL_00a7;
		}
		goto IL_01a1;
		IL_01a1:
		_ = 1;
		object obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v18+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		object obj13 = obj11;
		if (obj12 != null)
		{
			goto IL_00dc;
		}
		goto IL_01e7;
		IL_00a7:
		obj11 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v18+E4]");
		bool flag4 = (nint)0 == 0;
		obj13 = obj11;
		if (!flag4)
		{
			goto IL_00dc;
		}
		goto IL_01e7;
	}

	private void UpdateMutedChatBlocker()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_00b7: Expected O, but got I4
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		bool canSend = ChatHandler.CanSend;
		string muteReason = ChatHandler.MuteReason;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		DateTime? mutedUntil = SFSKammelnaUserExtensions.GetMutedUntil(localUser);
		UpdateChatState(canSend, muteReason, muteIcon, mutedUntil);
	}

	private void ShowChat()
	{
		//IL_0046: Expected I, but got O
		//IL_0056: Expected O, but got I
		//IL_0066: Expected O, but got I
		PopupUI popupUI = popup;
		Transform parent = popupUI.content.parent;
		parent.SetAsLastSibling();
		PopupUI popupUI2 = popup;
		nint num = (nint)popupUI2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v2 (Il2CppClass<PopupUI>)+188]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v2 (Il2CppClass<PopupUI>)+190]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v47 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void MuteChatNow()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_06eb: Expected O, but got I
		//IL_0738: Expected O, but got I4
		//IL_06ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		//IL_06c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Expected O, but got Unknown
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06da: Expected O, but got Unknown
		//IL_084e: Expected O, but got I
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected I, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected I, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00e9: Expected O, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0138: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_0751: Expected O, but got I4
		//IL_0783: Expected I, but got O
		//IL_0794: Expected O, but got I
		//IL_01ba: Expected O, but got I4
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_01f3: Expected I, but got O
		//IL_0203: Expected O, but got I
		//IL_02b5: Expected O, but got I4
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_0360: Expected O, but got I
		//IL_023e: Expected O, but got I
		//IL_0412: Expected O, but got I4
		//IL_02d4: Expected O, but got I4
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected O, but got Unknown
		//IL_04bd: Expected O, but got I
		//IL_039b: Expected O, but got I
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected I, but got Unknown
		//IL_0326: Expected O, but got I4
		//IL_0575: Expected O, but got I4
		//IL_0431: Expected O, but got I4
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_04f8: Expected O, but got I
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected I, but got Unknown
		//IL_0483: Expected O, but got I4
		//IL_0593: Expected I, but got O
		//IL_05a3: Expected O, but got I
		//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ae: Expected O, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_0632: Expected O, but got I4
		//IL_0648: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected O, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected I, but got Unknown
		//IL_068c: Expected O, but got I4
		//IL_0695: Expected O, but got I4
		//IL_05de: Expected O, but got I
		//IL_0506: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_0514: Unknown result type (might be due to invalid IL or missing references)
		//IL_0519: Expected O, but got Unknown
		//IL_0828: Expected O, but got I4
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected O, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3712;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+E4]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		object obj22;
		object obj23 = default(object);
		object obj25 = default(object);
		object obj18;
		if ((object)sessionModel != null)
		{
			Room currentRoom = sessionModel.CurrentRoom;
			if (obj4 != null)
			{
				object obj7 = "Added Tournament Prizes And Features" + 2160;
				object obj8 = "Added Tournament Prizes And Features" + 2176;
				nint num2 = (nint)("Material with texture name \"" + 3096);
				nint num3 = (nint)("<ds.DataTable.OnColumnChanging|INFO> {0}" + 3512);
				object obj9 = typeof(SqlSingle[]) + 2376;
				object obj10 = (nint)0 + (nint)2736;
				object cancelText = "COORDINATE_TYPE_GCJ_02" + 1864;
				object obj11 = obj4 + 16;
				obj11 = currentRoom;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag2 = SFSKammelnaRoomExtensions.IsChatEnabled((Room)obj11);
				object obj12 = (flag2 ? 1 : 0) ^ 1;
				bool flag3 = !flag2;
				object obj13 = !flag3;
				object obj14 = ~obj13;
				if (obj14 == null)
				{
					object obj15 = obj7;
				}
				else
				{
					object obj15 = obj8;
				}
				object obj16 = !flag3;
				object obj17 = ~obj16;
				num = ((obj17 != null) ? num3 : num2);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Action action = default(Action);
				action..ctor(obj4, (IntPtr)obj10);
				IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreateConfirm(action, (string)num, (string)cancelText);
				bool flag4 = popupWindowBuilderNeedsTitle == null;
				obj18 = 0;
				if (!flag4)
				{
					object obj19 = typeof(System.IOAsyncCallback) + 392;
					object obj20 = "Complete" + 256;
					nint num4 = (nint)popupWindowBuilderNeedsTitle;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v14 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v14 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0287;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v433 @ X8_v14 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
					obj22 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X10_v12-8]");
						if (0 == (nint)obj19)
						{
							break;
						}
						obj23 = obj22 + 16;
						obj21--;
						bool flag5 = (nint)obj21 != 1;
						obj22 = obj23;
						if (flag5)
						{
							continue;
						}
						goto IL_0287;
					}
					object obj24 = num4 + obj22;
					num = (nint)(obj24 + 312);
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v311 @ X8_v5 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
					bool flag6 = obj25 == null;
					obj23 = obj22;
					obj18 = 0;
					if (!flag6)
					{
						goto IL_0334;
					}
				}
			}
		}
		goto IL_06a3;
		IL_03e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v506 @ X0_v30 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		object obj26 = default(object);
		bool flag7 = obj26 == null;
		object obj27 = !flag7;
		if (obj27 != null)
		{
			goto IL_0491;
		}
		obj23 = obj22;
		obj18 = 0;
		IntPtr intPtr = default(IntPtr);
		num = intPtr;
		goto IL_06a3;
		IL_06a3:
		NullReferenceException ex = new NullReferenceException();
		goto IL_06b1;
		IL_0491:
		object obj28 = typeof(System.IOAsyncCallback) + 368;
		object obj29 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v20+12E]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v20+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0541;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v20+B0]");
		obj23 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v22-8]");
			if (0 == (nint)obj28)
			{
				break;
			}
			obj22 = obj23 + 16;
			obj30--;
			bool flag8 = (nint)obj30 != 1;
			obj23 = obj22;
			if (flag8)
			{
				continue;
			}
			goto IL_0541;
		}
		object obj31 = obj23 + 3;
		object obj32 = obj29 + obj31;
		num = (nint)(obj32 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v311 @ X8_v5 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag9 = ex == null;
		object obj33 = !flag9;
		obj18 = 0;
		if (obj33 != null)
		{
			goto IL_058b;
		}
		goto IL_06a3;
		IL_061f:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj18 = 0;
		object obj35 = default(object);
		object obj34 = obj35;
		goto IL_0836;
		IL_0334:
		object obj36 = typeof(System.IOAsyncCallback) + 384;
		object obj37 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v18+12E]");
		object obj38 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v18+12E]");
		if ((nint)0 == 0)
		{
			goto IL_03e4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v488 @ X8_v18+B0]");
		obj23 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v22-8]");
			if (0 == (nint)obj36)
			{
				break;
			}
			obj22 = obj23 + 16;
			obj38--;
			bool flag10 = (nint)obj38 != 1;
			obj23 = obj22;
			if (flag10)
			{
				continue;
			}
			goto IL_03e4;
		}
		object obj39 = obj37 + obj23;
		num = (nint)(obj39 + 312);
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v311 @ X8_v5 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag11 = obj26 == null;
		obj22 = obj23;
		obj18 = 0;
		if (!flag11)
		{
			goto IL_0491;
		}
		goto IL_06a3;
		IL_0287:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v451 @ X0_v34 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag12 = obj25 == null;
		object obj40 = !flag12;
		obj22 = obj23;
		if (obj40 != null)
		{
			goto IL_0334;
		}
		obj18 = 0;
		IntPtr intPtr2 = default(IntPtr);
		num = intPtr2;
		goto IL_06a3;
		IL_058b:
		num = (nint)ex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v5 (Il2CppClass<System.NullReferenceException>)+12E]");
		object obj41 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v5 (Il2CppClass<System.NullReferenceException>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_061f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X8_v5 (Il2CppClass<System.NullReferenceException>)+B0]");
		obj23 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X10_v22-8]");
			bool flag13 = 0 == (nint)obj28;
			obj18 = 0;
			if (flag13)
			{
				break;
			}
			obj23 += 16;
			obj41--;
			if ((nint)obj41 != 1)
			{
				continue;
			}
			goto IL_061f;
		}
		goto IL_06b1;
		IL_0541:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v561 @ X0_v26 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
		bool flag14 = ex == null;
		obj23 = obj22;
		obj18 = 0;
		IntPtr intPtr3 = default(IntPtr);
		num = intPtr3;
		if (!flag14)
		{
			goto IL_058b;
		}
		goto IL_06a3;
		IL_06b1:
		object obj42 = obj23 + 9;
		object obj43 = num + obj42;
		obj34 = obj43 + 312;
		goto IL_0836;
		IL_0836:
		object obj44 = obj34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X8_v4+8]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v379 @ X2_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void DisableChatRequest()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0030: Expected O, but got I
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_05a1: Expected I, but got O
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_0554: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected O, but got Unknown
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Expected O, but got Unknown
		//IL_057f: Expected O, but got I
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_009b: Expected I, but got O
		//IL_00ab: Expected O, but got I
		//IL_015d: Expected O, but got I4
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0205: Expected O, but got I
		//IL_00e6: Expected O, but got I
		//IL_02b7: Expected O, but got I4
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_0350: Expected O, but got I
		//IL_0240: Expected O, but got I
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected I, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_038b: Expected O, but got I
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected I, but got Unknown
		//IL_041d: Expected I, but got O
		//IL_042d: Expected O, but got I
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_04cb: Expected O, but got I
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e3: Expected O, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected I, but got Unknown
		//IL_0522: Expected O, but got I4
		//IL_0468: Expected O, but got I
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Expected O, but got Unknown
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E769C]");
		nint num = 0;
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)560;
		object confirmText = "DNQUALIFIER" + 3248;
		object cancelText = "COORDINATE_TYPE_GCJ_02" + 1864;
		Action action = default(Action);
		object obj7 = default(object);
		object obj9 = default(object);
		object obj10 = default(object);
		IntPtr intPtr = default(IntPtr);
		object obj21 = default(object);
		IntPtr intPtr2 = default(IntPtr);
		NullReferenceException ex = default(NullReferenceException);
		IntPtr intPtr3 = default(IntPtr);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action..ctor(this, (IntPtr)obj2);
			IPopupWindowBuilderNeedsTitle popupWindowBuilderNeedsTitle = PopupWindowBuilder.CreateConfirm(action, (string)confirmText, (string)cancelText);
			object obj6;
			if (popupWindowBuilderNeedsTitle != null)
			{
				object obj3 = typeof(System.IOAsyncCallback) + 392;
				object obj4 = "Complete" + 256;
				nint num2 = (nint)popupWindowBuilderNeedsTitle;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_012f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v9 (Il2CppClass<IPopupWindowBuilderNeedsTitle>)+B0]");
				obj6 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X10_v11-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					obj7 = obj6 + 16;
					obj5--;
					bool flag = (nint)obj5 != 1;
					obj6 = obj7;
					if (flag)
					{
						continue;
					}
					goto IL_012f;
				}
				object obj8 = num2 + obj6;
				num = (nint)(obj8 + 312);
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
				bool flag2 = obj9 == null;
				obj7 = obj6;
				if (!flag2)
				{
					goto IL_01ca;
				}
			}
			goto IL_0530;
			IL_0289:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v411 @ X0_v18 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag3 = obj10 == null;
			object obj11 = !flag3;
			if (obj11 != null)
			{
				goto IL_0324;
			}
			obj7 = obj6;
			num = intPtr;
			goto IL_0530;
			IL_053e:
			object obj12 = obj7 + 9;
			object obj13 = num + obj12;
			object obj14 = obj13 + 312;
			object obj15 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v287 @ X8_v5+8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v288 @ X2_v4 (should have been resolved before IL gen)");
			continue;
			IL_0324:
			object obj17 = typeof(System.IOAsyncCallback) + 368;
			object obj18 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v15+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v15+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03d4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v15+B0]");
			obj7 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X10_v1-8]");
				if (0 == (nint)obj17)
				{
					break;
				}
				obj6 = obj7 + 16;
				obj19--;
				bool flag4 = (nint)obj19 != 1;
				obj7 = obj6;
				if (flag4)
				{
					continue;
				}
				goto IL_03d4;
			}
			goto IL_04d5;
			IL_04a9:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj20 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X0_v12+8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v343 @ X2_v10 (should have been resolved before IL gen)");
			goto IL_04d5;
			IL_012f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v246 @ X0_v22 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag5 = obj9 == null;
			object obj23 = !flag5;
			obj6 = obj7;
			if (obj23 != null)
			{
				goto IL_01ca;
			}
			num = intPtr2;
			goto IL_0530;
			IL_04d5:
			object obj24 = obj7 + 3;
			object obj25 = obj18 + obj24;
			num = (nint)(obj25 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag6 = ex == null;
			object obj26 = !flag6;
			if (obj26 != null)
			{
				goto IL_0415;
			}
			goto IL_0530;
			IL_01ca:
			object obj27 = typeof(System.IOAsyncCallback) + 384;
			object obj28 = "Added Tournament Prizes And Features" + 2200;
			object obj29 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v13+12E]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v13+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0289;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X8_v13+B0]");
			obj7 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X10_v1-8]");
				if (0 == (nint)obj27)
				{
					break;
				}
				obj6 = obj7 + 16;
				obj30--;
				bool flag7 = (nint)obj30 != 1;
				obj7 = obj6;
				if (flag7)
				{
					continue;
				}
				goto IL_0289;
			}
			object obj31 = obj29 + obj7;
			num = (nint)(obj31 + 312);
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v279 @ X8_v3 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag8 = obj10 == null;
			obj6 = obj7;
			if (!flag8)
			{
				goto IL_0324;
			}
			goto IL_0530;
			IL_03d4:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v466 @ X0_v14 (Il2CppClass<System.NullReferenceException>)] (should have been resolved before IL gen)");
			bool flag9 = ex == null;
			obj7 = obj6;
			num = intPtr3;
			if (!flag9)
			{
				goto IL_0415;
			}
			goto IL_0530;
			IL_0415:
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj7 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X10_v1-8]");
					if (0 == (nint)obj17)
					{
						break;
					}
					obj7 += 16;
					obj32--;
					if ((nint)obj32 != 1)
					{
						continue;
					}
					goto IL_04a9;
				}
				goto IL_053e;
			}
			goto IL_04a9;
			IL_0530:
			ex = new NullReferenceException();
			goto IL_053e;
		}
	}

	private void InitializeMuteButton()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0080: Expected O, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_01e9: Expected O, but got I4
		//IL_01f2: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0178: Expected O, but got I
		//IL_0189: Expected I, but got O
		//IL_01a3: Expected O, but got I
		//IL_01b1: Expected I4, but got O
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3720;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = (nint)0 + (nint)136;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj8 = obj2 + 24;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PublicChatBox publicChatBox = default(PublicChatBox);
		if (!publicChatBox.IsGameChat)
		{
			return;
		}
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v17+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = (UnityEngine.Object)obj8;
			bool flag3 = !flag2;
			object obj11 = 0;
			if (flag3)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = (UnityEngine.Object)obj8;
			bool flag5 = !flag4;
			object obj12 = !flag5;
			object obj11 = 0;
			if (obj12 == null)
			{
				return;
			}
		}
		object obj13 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)2744;
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(obj2, (IntPtr)obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Object)+18]");
		((KGame)0).OnPlayerSwitchSeat += playerSwitchSeatDelegate;
		((<>c__DisplayClass24_0)obj2).<InitializeMuteButton>g__OnGameOnPlayerSwitchSeat|0((int)playerSwitchSeatDelegate, (string)null);
	}

	private void InitializePlayerControls()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0080: Expected O, but got I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_02c2: Expected O, but got I4
		//IL_02cb: Expected O, but got I4
		//IL_0140: Expected O, but got I4
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0178: Expected O, but got I
		//IL_0189: Expected I, but got O
		//IL_01a3: Expected O, but got I
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01dc: Expected O, but got I
		//IL_01ed: Expected I, but got O
		//IL_0212: Expected I4, but got O
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Expected O, but got Unknown
		//IL_0255: Expected O, but got I4
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = (nint)0 + (nint)136;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj8 = obj2 + 24;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		PublicChatBox publicChatBox = default(PublicChatBox);
		if (!publicChatBox.IsGameChat)
		{
			return;
		}
		object obj10 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v17+E4]");
		if ((nint)0 != 0)
		{
			bool flag2 = (UnityEngine.Object)obj8;
			bool flag3 = !flag2;
			object obj11 = 0;
			if (flag3)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = (UnityEngine.Object)obj8;
			bool flag5 = !flag4;
			object obj12 = !flag5;
			object obj11 = 0;
			if (obj12 == null)
			{
				return;
			}
		}
		object obj13 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)2760;
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(obj2, (IntPtr)obj14);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3 (System.Object)+18]");
		((KGame)0).OnPlayerSwitchSeat += playerSwitchSeatDelegate;
		Button button = ignoreWatchersButton;
		object obj15 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)2752;
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(obj2, (IntPtr)obj16);
		button.m_OnClick.AddListener(unityAction);
		((<>c__DisplayClass25_0)obj2).<InitializePlayerControls>g__OnGameOnPlayerSwitchSeat|0((int)unityAction, (string)null);
		object obj17 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj18 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X0_v29+E4]");
		bool flag6 = (nint)0 == 0;
		object obj19 = !flag6;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool ignoreWatchersChat = Preferences.IgnoreWatchersChat;
		ignoreWatchersToggler.ToggleManual(ignoreWatchersChat);
	}

	private void ChangeGroup()
	{
		List<ChatMessageData> messages = ChatHandler.GetMessages();
		SetMessages(messages);
	}

	public void JoinGroup(string groupTag)
	{
		if (!ClanUtils.IsClanChatTag(groupTag))
		{
			List<ChatMessageData> messages = ChatHandler.GetMessages();
			SetMessages(messages);
		}
	}

	protected override void AddMessage(ChatMessageData messageData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_003d: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+B8]");
		object tag = 0;
		if (!ClanUtils.IsClanChatTag((string)tag))
		{
			base.AddMessage(messageData);
		}
	}

	private void <DisableChatRequest>g__SendVote|23_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0183: Expected O, but got I4
		//IL_008f: Expected O, but got I
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj2 = typeof(RegisteredWaitHandle) + 2040;
		object key = "destinationTimeZone" + 328;
		object command = "destinationTimeZone" + 360;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.DismissMessage();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SFSObject sFSObject = default(SFSObject);
		sFSObject..ctor();
		SFSExtensions.Put(sFSObject, (string)key, val: true);
		SFS.SendRoomExtensionRequest((string)command, sFSObject);
		muteVoteButton.interactable = false;
		object obj5 = (nint)0 + (nint)288;
		object text = "DNQUALIFIER" + 3256;
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3120C");
		TextMeshProUGUI textMesh = default(TextMeshProUGUI);
		TextMeshProExtensions.Localize(textMesh, (string)text);
		ITrackEvent trackEvent = TrackerLibrary.GameDisableChatClicked();
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v6+E4]");
		if ((nint)0 != 0)
		{
			Tracker.DesignEvent(trackEvent);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Tracker.DesignEvent(trackEvent);
	}
}
