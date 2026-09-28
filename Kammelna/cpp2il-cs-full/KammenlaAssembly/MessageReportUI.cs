using System;
using System.Buffers.Text;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.WebRequests;
using ReportEnums;
using UnityEngine;

public class MessageReportUI : MonoBehaviour
{
	private PopupUI _popupUi;

	private GameObject loading;

	private GameObject reportView;

	private GameObject resultView;

	private GameObject errorView;

	private ChatMessageData _messageData;

	private bool alreadyReported;

	public void ReportCheating()
	{
		ReportPlayer(PlayerReportType.Cheating);
	}

	public void ReportBadChat()
	{
		ReportPlayer(PlayerReportType.Profanity);
	}

	public void ShowForMessage(ChatMessageData messageData)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		object obj = this + 72;
		obj = messageData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Show();
	}

	private void Show()
	{
		reportView.SetActive(value: true);
		resultView.SetActive(value: false);
		errorView.SetActive(value: false);
		_popupUi.PopFromCenter();
	}

	private void Initialize()
	{
		reportView.SetActive(value: true);
		resultView.SetActive(value: false);
		errorView.SetActive(value: false);
	}

	public void Hide()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Expected O, but got I4
		//IL_0034: Expected O, but got I
		object obj = this + 72;
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X19_v2-28]");
		((PopupUI)0).ShrinkToParent();
	}

	private void ReportPlayer(PlayerReportType playerReportType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0087: Expected O, but got I4
		//IL_00ed: Expected O, but got I4
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0183: Expected O, but got I
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01a3: Expected O, but got I
		//IL_01af: Expected O, but got I
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01fe: Expected O, but got I4
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_02bc: Expected I, but got O
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1072;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PlayerReportRequestModel playerReportRequestModel = default(PlayerReportRequestModel);
		playerReportRequestModel..ctor();
		playerReportRequestModel.<PlayerReportType>k__BackingField = playerReportType;
		ChatMessageData messageData = _messageData;
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		long <ReportedPlayerId>k__BackingField = Convert.ToInt64(messageData.<UserId>k__BackingField);
		playerReportRequestModel.<ReportedPlayerId>k__BackingField = <ReportedPlayerId>k__BackingField;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Games currentGame = Preferences.CurrentGame;
		playerReportRequestModel.<Game>k__BackingField = currentGame;
		ChatMessageData messageData2 = _messageData;
		object obj8 = playerReportRequestModel + 40;
		obj8 = messageData2.<UserName>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		ChatMessageData messageData3 = _messageData;
		object obj9 = typeof(DataRelation) + 712;
		object obj10 = (nint)0 + (nint)2264;
		object obj11 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 600;
		object obj12 = (nint)0 + (nint)3968;
		object obj13 = (nint)0 + (nint)2056;
		object obj14 = playerReportRequestModel + 48;
		obj14 = messageData3.<Message>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj15 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X0_v20+E4]");
		bool flag3 = (nint)0 == 0;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime now = DateTime.Now;
		DateTime? <ProblemTime>k__BackingField = now;
		playerReportRequestModel.<ProblemTime>k__BackingField = <ProblemTime>k__BackingField;
		string reportDescription = GetReportDescription(playerReportType);
		object obj17 = playerReportRequestModel + 64;
		obj17 = reportDescription;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string chatUsersInfoString = ChatHandler.GetChatUsersInfoString();
		object obj18 = playerReportRequestModel + 56;
		obj18 = chatUsersInfoString;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		action..ctor((object)null, (IntPtr)obj12);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2ECB5AC");
	}

	private unsafe void ProcessReport<T>(T reportModel, Action<T, Action<KammelnaResponseModel<bool>>> sendReportAction)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00d5: Expected O, but got I
		reportView.SetActive(value: false);
		loading.SetActive(value: true);
		if (alreadyReported)
		{
			FakeReported();
			return;
		}
		alreadyReported = true;
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)(nint)__ldftn(MessageReportUI.<ProcessReport>b__14_0<T>));
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendReportAction @ X2 (System.Action`2<T, System.Action`1<KammelnaResponseModel`1<System.Boolean>>>)+18]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendReportAction @ X2 (System.Action`2<T, System.Action`1<KammelnaResponseModel`1<System.Boolean>>>)+40]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [sendReportAction @ X2 (System.Action`2<T, System.Action`1<KammelnaResponseModel`1<System.Boolean>>>)+28]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v104 @ X4_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private string GetReportDescription(PlayerReportType playerReportType)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00eb: Expected O, but got I8
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_014f: Expected O, but got I4
		//IL_0165: Expected O, but got I
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_0204: Expected O, but got I8
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0268: Expected O, but got I4
		//IL_027e: Expected O, but got I
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02bd: Expected O, but got I
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_030d: Expected O, but got I4
		//IL_0323: Expected O, but got I
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_0362: Expected O, but got I
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1080;
		object obj2 = (nint)0 + (nint)3496;
		object obj3 = typeof(SqlSingle[]) + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Enum enumeration = default(Enum);
		string friendlyName = EnumExtensions.GetFriendlyName(enumeration);
		string text = friendlyName + (string)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		string[] array = default(string[]);
		if (array != null)
		{
			if (array.Length != 0)
			{
				object obj4 = "{0} color encoding is currently unsupported for outputting to HDR." + 2200;
				object obj5 = array + 32;
				obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				ChatMessageData messageData = _messageData;
				if (_messageData == null)
				{
					goto IL_03bc;
				}
				object obj6 = array.Length & 0xFFFFFFFEL;
				if (obj6 != null)
				{
					object obj7 = array + 40;
					obj7 = messageData.<UserName>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X22_v6-10]");
					bool flag = (nint)0 < (nint)2;
					object obj8 = !flag;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X22_v6-10]");
					object obj9 = -2;
					bool flag2 = obj9 == null;
					object obj10 = ~obj8;
					object obj11 = obj10 | flag2;
					if (obj11 == null)
					{
						object obj12 = "1.2.840.113549.1.12.1.5" + 1496;
						object obj13 = array + 48;
						obj13 = obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						ChatMessageData messageData2 = _messageData;
						if (_messageData == null)
						{
							goto IL_03bc;
						}
						object obj14 = array.Length & 0xFFFFFFFCL;
						if (obj14 != null)
						{
							object obj15 = array + 56;
							obj15 = messageData2.<Message>k__BackingField;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X19_v5-20]");
							bool flag3 = (nint)0 < (nint)4;
							object obj16 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X19_v5-20]");
							object obj17 = -4;
							bool flag4 = obj17 == null;
							object obj18 = ~obj16;
							object obj19 = obj18 | flag4;
							if (obj19 == null)
							{
								object obj20 = (nint)0 + (nint)2360;
								object obj21 = array + 64;
								obj21 = obj20;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								string chatText = ChatHandler.GetChatText();
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X19_v7-28]");
								bool flag5 = (nint)0 < (nint)5;
								object obj22 = !flag5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X19_v7-28]");
								object obj23 = -5;
								bool flag6 = obj23 == null;
								object obj24 = ~obj22;
								object obj25 = obj24 | flag6;
								if (obj25 == null)
								{
									object obj26 = (nint)0 + (nint)2336;
									object obj27 = array + 72;
									obj27 = chatText;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									string text2 = string.Concat(array);
									return text + (string)obj26 + text2;
								}
							}
						}
					}
				}
			}
			IndexOutOfRangeException ex = new IndexOutOfRangeException();
		}
		goto IL_03bc;
		IL_03bc:
		return (string)(object)new NullReferenceException();
	}

	private void FakeReported()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0077: Expected I, but got O
		//IL_00a1: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2064;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(5f, action);
	}

	private void <ProcessReport>b__14_0<T>(KammelnaResponseModel<bool> response)
	{
		//IL_0026: Expected O, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00e5: Expected O, but got I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_008b: Expected O, but got I
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0182: Expected I, but got O
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01c0: Expected O, but got I4
		//IL_0141: Expected O, but got I
		loading.SetActive(value: false);
		object obj = (nint)0 + (nint)1048;
		object obj3;
		Action callback;
		Action action = default(Action);
		if (response.Succeeded)
		{
			resultView.SetActive(value: true);
			object obj2 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj3 = (nint)0 + (nint)2072;
			callback = action;
		}
		else
		{
			PopupUI popupUi = _popupUi;
			object obj4 = typeof(SqlSingle[]) + 3912;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v13+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			AnimationExtensions.ErrorFeedback(popupUi.content);
			errorView.SetActive(value: true);
			object obj7 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj3 = (nint)0 + (nint)2080;
			callback = action;
		}
		action..ctor(this, (IntPtr)obj3);
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X0_v8+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(2f, callback);
	}

	private void <FakeReported>b__16_0()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_003a: Expected O, but got I
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_007b: Expected I, but got O
		//IL_00a5: Expected O, but got I4
		loading.SetActive(value: false);
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2072;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		resultView.SetActive(value: true);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(2f, action);
	}
}
