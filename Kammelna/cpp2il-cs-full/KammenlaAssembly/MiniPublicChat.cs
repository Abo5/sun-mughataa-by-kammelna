using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server;
using Sfs2X.Entities;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class MiniPublicChat : BaseChatbox
{
	private Graphic blocker;

	private SlideAnimationHelper popup;

	private TextMeshProUGUI blockedMessage;

	private GameObject ignoredMessage;

	private GameEventsChannel gameEventsChannel;

	private bool _isInitialized;

	private bool ChatEnabled
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0106: Expected O, but got I
			//IL_0130: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0179: Expected O, but got I4
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Expected O, but got Unknown
			object obj = 152989696;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7686]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v5+E4]");
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
			if (obj8 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00a0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			goto IL_00a0;
			IL_00a0:
			Room currentRoom = sessionModel.CurrentRoom;
			if (currentRoom != null)
			{
				object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2544;
				return SFSExtensions.GetVariable(currentRoom, (string)varName, defaultValue: true);
			}
			return true;
		}
	}

	protected override void RegisterSFSSceneCallbacks()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_012c: Expected O, but got I
		//IL_0160: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0057: Expected O, but got I
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0072: Expected O, but got I
		//IL_009c: Expected I, but got O
		//IL_00ce: Expected I, but got O
		//IL_00df: Expected O, but got I
		//IL_010b: Expected I, but got O
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		GameObject go = base.gameObject;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj5 = typeof(SqlSingle[]) + 2376;
		object obj6 = (nint)0 + (nint)2976;
		object varName = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2544;
		object obj7 = (nint)0 + (nint)2968;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj6);
		VariableBinderExtensions.Bind(go, currentRoom, (string)varName, action);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj7);
		object obj8 = (nint)0 + (nint)2960;
		gameEventsChannel.ShowMiniChat += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj8);
		gameEventsChannel.OnPanelShow += action3;
	}

	protected override void UnregisterSFSSceneCallbacks()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_003e: Expected I, but got O
		//IL_007a: Expected I, but got O
		//IL_008b: Expected O, but got I
		//IL_00b7: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)2968;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4 (Il2CppClass<MiniPublicChat>)+1B0]");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)0);
		ChatHandler.OnMessage -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj3);
		object obj4 = (nint)0 + (nint)2960;
		gameEventsChannel.ShowMiniChat -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj4);
		gameEventsChannel.OnPanelShow -= action3;
	}

	protected override void Update()
	{
		base.Update();
		InputField inputField = chatInput;
		if (inputField.m_Keyboard != null)
		{
			TouchScreenKeyboard.Status status = inputField.m_Keyboard.status;
			if (status == TouchScreenKeyboard.Status.Canceled)
			{
				Close();
			}
			TouchScreenKeyboard.Status status2 = inputField.m_Keyboard.status;
			if (status2 == TouchScreenKeyboard.Status.LostFocus)
			{
				Close();
				gameEventsChannel.TriggerShowChat();
			}
		}
	}

	public void Open()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0070: Expected O, but got I4
		//IL_0099: Expected O, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00d6: Expected I, but got O
		//IL_00e6: Expected O, but got I
		//IL_017c: Expected O, but got I
		//IL_0121: Expected O, but got I
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01e1: Expected O, but got I4
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_0264: Expected O, but got I
		//IL_0288: Expected O, but got I4
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0340: Expected O, but got I4
		//IL_0350: Expected O, but got I
		//IL_0360: Expected O, but got I
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_041c: Expected I, but got O
		StopAllCoroutines();
		object obj11;
		if (TouchScreenKeyboard.isSupported && ChatHandler.CanSend)
		{
			gameEventsChannel.TriggerPanelShow();
			object obj = typeof(Queue<string>) + 848;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v13+E4]");
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
			object obj5 = typeof(UsageHint) + 8;
			nint num = (nint)localUser;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v11 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v11 (Il2CppClass<Sfs2X.Entities.User>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0162;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v11 (Il2CppClass<Sfs2X.Entities.User>)+B0]");
			object obj7 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X10_v8-8]");
				if (0 == (nint)obj5)
				{
					break;
				}
				obj7 += 16;
				obj6--;
				if ((nint)obj6 != 1)
				{
					continue;
				}
				goto IL_0162;
			}
			object obj8 = obj7 + 3;
			object obj9 = num + obj8;
			object obj10 = obj9 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X8_v30+8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v277 @ X8_v30] (should have been resolved before IL gen)");
			object obj12 = default(object);
			bool flag2 = obj12 == null;
			object obj13 = !flag2;
			if (obj13 != null)
			{
				goto IL_01a3;
			}
			goto IL_0296;
		}
		Close();
		gameEventsChannel.TriggerShowChat();
		return;
		IL_0162:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v46+8]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v245 @ X0_v46] (should have been resolved before IL gen)");
		object obj14 = default(object);
		if (obj14 != null)
		{
			goto IL_01a3;
		}
		goto IL_0296;
		IL_01a3:
		object obj15 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X0_v41+E4]");
		bool flag3 = (nint)0 == 0;
		object obj17 = !flag3;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool ignoreWatchersChat = Preferences.IgnoreWatchersChat;
		bool active = ignoreWatchersChat;
		goto IL_02a4;
		IL_0296:
		active = false;
		goto IL_02a4;
		IL_02a4:
		ignoredMessage.SetActive(active);
		popup.SlideIn();
		int num2 = ShortcutExtensions.DOKill(blocker);
		GameObject gameObject = blocker.gameObject;
		gameObject.SetActive(value: true);
		UIExtensions.SetAlpha(blocker, 0f);
		TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(blocker, 0.3f, 0.3f);
		object obj18 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v16+90]");
		object obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v17+B8]");
		object text = 0;
		chatInput.text = (string)text;
		if (((MiniPublicChat)(object)chatInput).ChatEnabled)
		{
			UIExtensions.ShowKeyboard(chatInput);
		}
		ChatHandler.ChatActive = true;
		List<ChatMessageData> messages = ChatHandler.GetMessages();
		SetMessages(messages);
		if (!_isInitialized)
		{
			_isInitialized = true;
			object obj20 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num3 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v197 @ X8_v22 (Il2CppClass<MiniPublicChat>)+1B0]");
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)0);
			ChatHandler.OnMessage += action;
		}
	}

	public void Close()
	{
		//IL_0085: Expected O, but got I
		SlideAnimationHelper slideAnimationHelper = popup;
		if (slideAnimationHelper.<IsShown>k__BackingField)
		{
			slideAnimationHelper.SlideOut();
			int num = ShortcutExtensions.DOKill(blocker);
			TweenerCore<Color, Color, ColorOptions> tweenerCore = DOTweenModuleUI.DOFade(blocker, 0f, 0.3f);
			TweenCallback tweenCallback = TweenHelpers.Disable(blocker);
			object obj = (nint)0 + (nint)2456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
			ChatHandler.ChatActive = false;
		}
	}

	public void GoFullScreen()
	{
		Close();
		gameEventsChannel.TriggerShowChat();
	}

	protected override void SendChatMessage(string message)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00b4: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2960;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		ChatHandler.SendChat(message);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.4f, action);
	}

	protected override void OnSubmittedEmptyMessage()
	{
		Close();
	}

	public void UpdateChatDisableState()
	{
		//IL_0053: Expected O, but got I
		//IL_0063: Expected I, but got O
		//IL_0073: Expected O, but got I
		//IL_0083: Expected O, but got I
		if (ChatEnabled)
		{
			chatInput.interactable = true;
			TextMeshProUGUI textMeshProUGUI = blockedMessage;
			object obj = (nint)0 + (nint)2000;
			object obj2 = obj;
			nint num = (nint)textMeshProUGUI;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v59 @ X3_v1 (should have been resolved before IL gen)");
		}
		DisableChatUi();
	}

	private void EnableChatUi()
	{
		//IL_0030: Expected O, but got I
		//IL_0040: Expected I, but got O
		//IL_0050: Expected O, but got I
		//IL_0060: Expected O, but got I
		chatInput.interactable = true;
		TextMeshProUGUI textMeshProUGUI = blockedMessage;
		object obj = (nint)0 + (nint)2000;
		object obj2 = obj;
		nint num = (nint)textMeshProUGUI;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+558]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v5 (Il2CppClass<TMPro.TextMeshProUGUI>)+560]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v53 @ X3_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void DisableChatUi()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Expected O, but got I4
		//IL_0048: Expected O, but got I
		//IL_0058: Expected O, but got I
		chatInput.interactable = false;
		object text = "Cannot populate JSON object onto type '{0}'." + 2320;
		object obj = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+90]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X8_v5+B8]");
		object text2 = 0;
		chatInput.text = (string)text2;
		TextMeshProExtensions.Localize(blockedMessage, (string)text);
	}
}
