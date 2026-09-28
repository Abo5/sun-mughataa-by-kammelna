using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Features.GameReplay;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public abstract class BaseChatbox : BaseListChatBox
{
	protected InputField chatInput;

	private Button sendButton;

	private ChatMessageOptions messageOptions;

	private Sprite _sendButtonSprite;

	private void Start()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0058: Expected I, but got O
		//IL_0081: Expected O, but got I4
		//IL_00b5: Expected O, but got I
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00f7: Expected O, but got I
		//IL_0106: Expected I, but got O
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0155: Expected O, but got I
		//IL_016d: Expected I, but got O
		//IL_01a0: Expected O, but got I
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01fb: Expected O, but got I
		//IL_0213: Expected I, but got O
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Expected O, but got Unknown
		//IL_02c2: Expected O, but got I
		//IL_02da: Expected I, but got O
		//IL_0318: Expected I, but got O
		//IL_0328: Expected O, but got I
		//IL_0338: Expected O, but got I
		Button button = sendButton;
		if ((object)sendButton != null)
		{
			Graphic targetGraphic = ((Selectable)button).m_TargetGraphic;
			if ((object)((Selectable)button).m_TargetGraphic != null)
			{
				object obj = typeof(System.IOAsyncCallback) + 2456;
				object obj2 = obj;
				nint num = (nint)targetGraphic;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v9 (Il2CppClass<UnityEngine.UI.Graphic>)+130]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X1_v4+130]");
				bool flag = num2 < 0;
				object obj3 = !flag;
				object obj4 = ~obj3;
				if (obj4 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v9 (Il2CppClass<UnityEngine.UI.Graphic>)+C8]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X1_v4+130]");
					object obj5 = num3 + 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X8_v11-8]");
					if (0 == (nint)obj2)
					{
						object obj6 = this + 64;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v9 (UnityEngine.UI.Graphic)+D8]");
						obj6 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						nint num4 = (nint)this;
						RegisterSFSSceneCallbacks();
						InputField inputField = chatInput;
						if ((object)chatInput != null)
						{
							object obj7 = typeof(TypeConverter<ushort, char>) + 464;
							object obj8 = (nint)0 + (nint)2696;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							UnityAction<object> unityAction = default(UnityAction<object>);
							unityAction..ctor((object)this, (IntPtr)obj8);
							if (inputField.m_OnValueChanged != null)
							{
								object obj9 = (nint)0 + (nint)1208;
								((UnityEvent<object>)(object)inputField.m_OnValueChanged).AddListener(unityAction);
								InputField inputField2 = chatInput;
								if ((object)chatInput != null)
								{
									object obj10 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
									object obj11 = (nint)0 + (nint)1528;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									InputField.OnValidateInput onValidateInput = default(InputField.OnValidateInput);
									onValidateInput..ctor(null, (IntPtr)obj11);
									Delegate obj12 = Delegate.Combine(inputField2.m_OnValidateInput, onValidateInput);
									if ((object)obj12 != null && obj12 != obj10)
									{
										throw new InvalidCastException();
									}
									chatInput.onValidateInput = (InputField.OnValidateInput)obj12;
									Button button2 = sendButton;
									if ((object)sendButton != null)
									{
										object obj13 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
										object obj14 = (nint)0 + (nint)2688;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
										UnityAction unityAction2 = default(UnityAction);
										unityAction2..ctor(this, (IntPtr)obj14);
										if (button2.m_OnClick != null)
										{
											button2.m_OnClick.AddListener(unityAction2);
											nint num5 = (nint)this;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v19 (Il2CppClass<BaseChatbox>)+178]");
											object obj15 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v19 (Il2CppClass<BaseChatbox>)+180]");
											object obj16 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v254 @ X2_v11 (should have been resolved before IL gen)");
										}
									}
								}
							}
						}
						goto IL_0342;
					}
				}
				goto IL_0350;
			}
		}
		goto IL_0342;
		IL_0350:
		throw new InvalidCastException();
		IL_0342:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0350;
	}

	private void OnDestroy()
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<BaseChatbox>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<BaseChatbox>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void Update()
	{
		if (UIExtensions.IsSubmitted(chatInput))
		{
			SendChat();
			UIExtensions.ShowKeyboard(chatInput);
		}
	}

	public void FocusInputField()
	{
		UIExtensions.ShowKeyboard(chatInput);
	}

	private void ChatInputChanged(string newVal)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_014f: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E75F7]");
		object obj3 = (nint)0 & (nint)1;
		Button button;
		Button button2;
		if (obj3 != null)
		{
			button = sendButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			button2 = sendButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			button = sendButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			button2 = sendButton;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = StringsExtensions.IsNullOrEmpty(newVal);
		bool flag4 = (object)button2 == null;
		object obj6 = !flag4;
		Selectable selectable = button2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00ab;
		IL_0091:
		flag3 = StringsExtensions.IsNullOrEmpty(newVal);
		selectable = button;
		goto IL_00ab;
		IL_00ab:
		bool interactable = (byte)((flag3 ? 1u : 0u) ^ 1u) != 0;
		selectable.interactable = interactable;
	}

	public void SendChat(string msg = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0253: Expected O, but got I4
		//IL_00d9: Expected O, but got I4
		//IL_0085: Expected O, but got I4
		//IL_008e: Expected O, but got I4
		//IL_017b: Expected I, but got O
		//IL_01fb: Expected O, but got I
		//IL_020b: Expected O, but got I
		//IL_0128: Expected O, but got I4
		//IL_01bb: Expected O, but got I4
		//IL_01cb: Expected O, but got I
		//IL_01db: Expected O, but got I
		object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
		string text2;
		while (true)
		{
			object obj2 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text = StringUtil.SanitizeChatMessage(msg);
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				bool flag2 = StringsExtensions.IsNullOrEmpty(text);
				bool flag3 = !flag2;
				object obj6 = !flag3;
				object obj7 = 0;
				if (obj6 != null)
				{
					goto IL_00ef;
				}
				text2 = text;
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag4 = StringsExtensions.IsNullOrEmpty(text);
				bool flag5 = !flag4;
				object obj7 = 0;
				text2 = text;
				if (!flag5)
				{
					goto IL_00ef;
				}
			}
			goto IL_0176;
			IL_0176:
			nint num = (nint)this;
			if (text2._stringLength != 0)
			{
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v6 (Il2CppClass<BaseChatbox>)+1D8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v6 (Il2CppClass<BaseChatbox>)+1E0]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v117 @ X2_v1 (should have been resolved before IL gen)");
			continue;
			IL_00ef:
			InputField inputField = chatInput;
			object obj10 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v15+E4]");
			bool flag6 = (nint)0 == 0;
			object obj11 = !flag6;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string text3 = StringUtil.SanitizeChatMessage(inputField.m_Text);
			string text4 = text3.Trim();
			text2 = text4;
			goto IL_0176;
		}
		SendChatMessage(text2);
		object obj12 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v8+90]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v9+B8]");
		object text5 = 0;
		chatInput.text = (string)text5;
	}

	protected void ProcessSentMessage(string message)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_0152: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00ec: Expected I, but got O
		//IL_00fc: Expected O, but got I
		//IL_010c: Expected O, but got I
		//IL_019b: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E75F9]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0116;
		}
		object obj4 = (nint)0 + (nint)2200;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = obj4;
		if (!flag)
		{
			goto IL_0091;
		}
		goto IL_0168;
		IL_0168:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag2 = (object)sessionModel == null;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 888;
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ChatMessageData chatMessageData = default(ChatMessageData);
		chatMessageData..ctor(message, localUser);
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v7 (Il2CppClass<BaseChatbox>)+1A8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v7 (Il2CppClass<BaseChatbox>)+1B0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v102 @ X3_v2 (should have been resolved before IL gen)");
		goto IL_0116;
		IL_0116:
		_ = 1;
		obj4 = (nint)0 + (nint)2200;
		obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		obj6 = obj4;
		if (obj11 != null)
		{
			goto IL_0091;
		}
		goto IL_0168;
	}

	protected abstract void SendChatMessage(string message);

	protected virtual void OnSubmittedEmptyMessage()
	{
	}

	protected void ProcessMessage(ChatMessageData messageData)
	{
		//IL_0027: Expected O, but got I4
		//IL_006f: Expected I, but got O
		//IL_007f: Expected O, but got I
		//IL_008f: Expected O, but got I
		bool isMyMessage = messageData.IsMyMessage;
		bool flag = !isMyMessage;
		object obj = !flag;
		if (obj == null)
		{
			GameObject gameObject = base.gameObject;
			if (gameObject.activeInHierarchy)
			{
				nint num = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v1 (Il2CppClass<BaseChatbox>)+1A8]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v1 (Il2CppClass<BaseChatbox>)+1B0]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v60 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	protected void UpdateChatState(bool enable, string disabledMessage, Sprite disabledIcon = null, DateTime? muteUntil = null)
	{
		//IL_0125: Expected O, but got I4
		//IL_0136: Expected O, but got I4
		//IL_0027: Expected O, but got I4
		//IL_0038: Expected O, but got I4
		//IL_07fb: Expected O, but got I4
		//IL_0800: Expected I, but got O
		//IL_0160: Expected O, but got I
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected O, but got Unknown
		//IL_0419: Expected O, but got I
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01bb: Expected O, but got I4
		//IL_0062: Expected O, but got I
		//IL_008c: Expected O, but got I4
		//IL_009d: Expected O, but got I4
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_020f: Expected O, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I4
		//IL_00ee: Expected O, but got I4
		//IL_03fe: Expected I, but got O
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0273: Expected O, but got I4
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_0350: Expected I, but got O
		//IL_0374: Expected O, but got I4
		//IL_0389: Expected I, but got O
		//IL_061b: Expected O, but got I4
		//IL_07ac: Expected O, but got I4
		//IL_055f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_056c: Expected I4, but got O
		//IL_0574: Expected I, but got O
		//IL_059d: Expected O, but got I4
		//IL_06ed: Expected O, but got I4
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063d: Expected O, but got Unknown
		//IL_071f: Expected F8, but got I4
		//IL_05d1: Expected O, but got I
		//IL_0869: Expected O, but got I4
		//IL_077a: Expected O, but got I4
		//IL_073f: Expected F8, but got I4
		//IL_088b: Expected O, but got I
		//IL_0897: Expected I, but got O
		Sprite sprite;
		Sprite sprite2 = default(Sprite);
		InputFieldTMProUGUI inputFieldTMProUGUI;
		string text2;
		Sprite sprite3;
		object[] array = default(object[]);
		object[] array2 = default(object[]);
		InputFieldTMProUGUI inputFieldTMProUGUI3 = default(InputFieldTMProUGUI);
		nint num2;
		string text;
		if (enable)
		{
			bool flag = (object)chatInput == null;
			sprite = sprite2;
			DateTime dateTime = (DateTime)0;
			text = disabledMessage;
			inputFieldTMProUGUI = (InputFieldTMProUGUI)152989696;
			text2 = disabledMessage;
			sprite3 = sprite2;
			if (!flag)
			{
				object obj = (nint)0 + (nint)3880;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				InputFieldTMProUGUI inputFieldTMProUGUI2 = default(InputFieldTMProUGUI);
				bool flag2 = (object)inputFieldTMProUGUI2 == null;
				sprite = sprite2;
				dateTime = (DateTime)0;
				text = disabledMessage;
				inputFieldTMProUGUI = (InputFieldTMProUGUI)152989696;
				text2 = disabledMessage;
				sprite3 = sprite2;
				if (!flag2)
				{
					object placeholder = "WhiteSmoke" + 2184;
					inputFieldTMProUGUI2.SetPlaceholder((string)placeholder);
					dateTime = (DateTime)0;
					text = null;
					inputFieldTMProUGUI = (InputFieldTMProUGUI)152989696;
					text2 = disabledMessage;
					sprite3 = sprite2;
					goto IL_0472;
				}
			}
		}
		else
		{
			bool flag3 = (object)chatInput == null;
			sprite = sprite2;
			DateTime dateTime = (DateTime)0;
			text = disabledMessage;
			inputFieldTMProUGUI = (InputFieldTMProUGUI)152989696;
			text2 = disabledMessage;
			sprite3 = sprite2;
			if (!flag3)
			{
				object obj2 = (nint)0 + (nint)3880;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
				object obj3 = typeof(TypeConverter<ushort, char>) + 3400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				object obj4 = (??)muteUntil & 1;
				bool flag4 = obj4 == null;
				sprite = sprite2;
				dateTime = (DateTime)0;
				text = disabledMessage;
				if (!flag4)
				{
					object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3632;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X0_v40+E4]");
					bool flag5 = (nint)0 == 0;
					object obj7 = !flag5;
					if (obj7 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					CultureInfo invariantCulture = CultureInfo.InvariantCulture;
					object obj8 = typeof(DataRelation) + 712;
					object obj9 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v44+E4]");
					bool flag6 = (nint)0 == 0;
					object obj10 = !flag6;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					object obj11 = "utf-32" + 3032;
					string text3 = dateTime.ToString((string)obj11, invariantCulture);
					bool flag7 = array == null;
					sprite = null;
					array2 = array;
					text = (string)(object)invariantCulture;
					inputFieldTMProUGUI = inputFieldTMProUGUI3;
					text2 = disabledMessage;
					sprite3 = sprite2;
					if (flag7)
					{
						goto IL_07d1;
					}
					bool flag8 = text3 == null;
					sprite = null;
					array2 = array;
					text = (string)(object)invariantCulture;
					inputFieldTMProUGUI = inputFieldTMProUGUI3;
					text2 = disabledMessage;
					sprite3 = sprite2;
					if (flag8)
					{
						goto IL_07df;
					}
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					object obj12 = default(object);
					bool flag9 = obj12 == null;
					object obj13 = !flag9;
					sprite = null;
					text = (string)(object)invariantCulture;
					num2 = (nint)text3;
					if (obj13 != null)
					{
						goto IL_0839;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
					OutOfMemoryException ex = new OutOfMemoryException();
					sprite = null;
					text = (string)(object)invariantCulture;
				}
				bool flag10 = array == null;
				array2 = array;
				inputFieldTMProUGUI = inputFieldTMProUGUI3;
				text2 = disabledMessage;
				sprite3 = sprite2;
				if (!flag10)
				{
					num2 = unchecked((nint)null);
					goto IL_0839;
				}
			}
		}
		goto IL_07d1;
		IL_07df:
		bool flag11 = array2.Length == 0;
		object obj14 = !flag11;
		num2 = unchecked((nint)null);
		if (obj14 == null)
		{
			throw new IndexOutOfRangeException();
		}
		goto IL_0403;
		IL_0839:
		array2 = array;
		inputFieldTMProUGUI = inputFieldTMProUGUI3;
		text2 = disabledMessage;
		sprite3 = sprite2;
		goto IL_0403;
		IL_0694:
		bool flag12 = text2 == null;
		Sprite sprite4 = sprite3;
		sprite = sprite;
		text = null;
		if (!flag12)
		{
			goto IL_06c6;
		}
		goto IL_07d1;
		IL_0472:
		bool flag13 = (object)chatInput == null;
		sprite = sprite;
		if (!flag13)
		{
			chatInput.interactable = enable;
			bool flag14 = (object)sendButton == null;
			sprite = sprite;
			text = null;
			if (!flag14)
			{
				sendButton.enabled = enable;
				Button button = sendButton;
				bool flag15 = (object)sendButton == null;
				sprite = sprite;
				text = null;
				if (!flag15)
				{
					text2 = (string)(object)((Selectable)button).m_TargetGraphic;
					bool flag16 = (object)((Selectable)button).m_TargetGraphic == null;
					bool flag17 = enable;
					if (!flag16)
					{
						object obj15 = typeof(System.IOAsyncCallback) + 2456;
						flag17 = (byte)(int)obj15 != 0;
						nint num3 = (nint)text2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v24 (Il2CppClass<System.String>)+130]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X1_v9 (System.Boolean)+130]");
						bool flag18 = num4 < 0;
						object obj16 = !flag18;
						object obj17 = ~obj16;
						if (obj17 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v24 (Il2CppClass<System.String>)+C8]");
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X1_v9 (System.Boolean)+130]");
							object obj18 = num5 + 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v26-8]");
							if ((nint)0 == (flag17 ? 1 : 0))
							{
								goto IL_0601;
							}
						}
						throw new InvalidCastException();
					}
					goto IL_0601;
				}
			}
		}
		goto IL_07d1;
		IL_07d1:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_07df;
		IL_0601:
		bool flag19 = !enable;
		object obj19 = !flag19;
		if (obj19 == null)
		{
			object obj20 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v467 @ X0_v21+E4]");
			if ((nint)0 != 0)
			{
				if ((bool)sprite3)
				{
					goto IL_0694;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag20 = sprite3;
				bool flag21 = !flag20;
				object obj22 = !flag21;
				if (obj22 != null)
				{
					goto IL_0694;
				}
			}
		}
		sprite4 = _sendButtonSprite;
		bool flag22 = text2 == null;
		object obj23 = !flag22;
		sprite = sprite;
		text = null;
		sprite3 = _sendButtonSprite;
		if (obj23 != null)
		{
			goto IL_06c6;
		}
		goto IL_07d1;
		IL_06c6:
		((Image)(object)text2).sprite = sprite4;
		bool flag23 = !enable;
		object obj24 = !flag23;
		object obj25 = ~obj24;
		if (obj25 == null)
		{
			double num6 = 1.0;
		}
		else
		{
			double num6 = 1058642330.0;
		}
		object obj26 = !flag23;
		object obj27 = ~obj26;
		if (obj27 == null)
		{
			double num7 = 1.0;
		}
		else
		{
			double num7 = 1061494456.0;
		}
		DateTime dateTime2 = ((IConvertible)text2).ToDateTime((IFormatProvider)0);
		nint num8 = (nint)text2;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v416 @ X8_v18 (Il2CppClass<System.String>)+408] (should have been resolved before IL gen)");
		return;
		IL_0403:
		object obj28 = array2 + 32;
		obj28 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		LocalizableText placeholder2 = TextMeshProExtensions.LocalizeWith(text2, array2);
		bool flag24 = (object)inputFieldTMProUGUI == null;
		text = null;
		if (!flag24)
		{
			inputFieldTMProUGUI.SetPlaceholder(placeholder2);
			text = null;
			goto IL_0472;
		}
		goto IL_07d1;
	}

	public void ShowMessageOptions(Vector2 pos, ChatMessageDataHolder message)
	{
		Vector2 pos2 = default(Vector2);
		messageOptions.Show(pos2, message);
	}

	public void HideMessageOptions()
	{
		messageOptions.Hide();
	}

	private void <Start>b__4_0()
	{
		SendChat();
	}
}
