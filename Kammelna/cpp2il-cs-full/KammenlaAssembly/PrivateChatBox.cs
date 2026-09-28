using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Mono.Btls;
using UnityEngine;

public class PrivateChatBox : BaseChatbox
{
	private sealed class <>c__DisplayClass7_0
	{
		public PrivateMessageModel messageData;

		internal bool <OnPrivateMessage>b__0(FriendProfile f)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (f != null)
			{
				PrivateMessageModel privateMessageModel = messageData;
				if (messageData != null)
				{
					object obj = f.UserID - privateMessageModel.sender;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private int userId;

	private FriendProfile _friendProfile;

	protected override void RegisterSFSSceneCallbacks()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_0084: Expected I, but got O
		//IL_005d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3104;
		object obj2 = (nint)0 + (nint)2688;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
		object obj4 = (nint)0 + (nint)2696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		CoordinatorService.OnPrivateMessage += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		SFS.OnAdminMessage += action2;
	}

	protected override void UnregisterSFSSceneCallbacks()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_0084: Expected I, but got O
		//IL_005d: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3104;
		object obj2 = (nint)0 + (nint)2688;
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
		object obj4 = (nint)0 + (nint)2696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		CoordinatorService.OnPrivateMessage -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj4);
		SFS.OnAdminMessage -= action2;
	}

	private void OnDisable()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_013b: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_01c1: Expected O, but got I4
		//IL_0169: Expected O, but got I
		//IL_0183: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7690]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D9]");
		object obj6 = (nint)0 & (nint)1;
		bool flag2 = obj6 == null;
		object obj7 = !flag2;
		if (obj7 != null)
		{
			goto IL_00b0;
		}
		goto IL_0191;
		IL_00e5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+B8]");
		object obj8 = 0;
		_ = 0;
		FriendsManager.NotifyUiUpdate();
		FriendsManager.SaveProfiles();
		return;
		IL_01d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj9 = obj2;
		goto IL_00e5;
		IL_00b0:
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = obj9;
		if (!flag3)
		{
			goto IL_00e5;
		}
		goto IL_01d7;
		IL_007d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45D9]");
		object obj11 = (nint)0 & (nint)1;
		if (obj11 != null)
		{
			goto IL_00b0;
		}
		goto IL_0191;
		IL_0191:
		_ = 1;
		obj9 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		obj10 = obj9;
		if (obj12 != null)
		{
			goto IL_00e5;
		}
		goto IL_01d7;
	}

	public void Initialize(int userID)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I4
		//IL_00fe: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		userId = userID;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendProfile profile = FriendsManager.GetProfile(userID);
		object obj4 = this + 80;
		obj4 = profile;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v10+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj5 = obj;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v10+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X20_v3-8]");
		_ = 0;
		List<ChatMessageData> messages = FriendsManager.GetMessages(_friendProfile);
		SetMessages(messages);
		FriendsManager.MarkMessagesAsRead(_friendProfile);
	}

	protected override void SendChatMessage(string message)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_006c: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		ProcessSentMessage(message);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.HandleSendMessage(message, userId);
	}

	private unsafe void OnPrivateMessage(PrivateMessageModel messageData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0059: Expected O, but got I
		//IL_0065: Expected O, but got I
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I4
		//IL_029a: Expected O, but got I
		//IL_02b5: Expected I, but got O
		//IL_0176: Expected O, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected I4, but got Unknown
		//IL_0109: Expected O, but got I
		//IL_0138: Expected O, but got I4
		//IL_01e9: Expected O, but got I
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected I4, but got Unknown
		object obj = typeof(Mono.Btls.MonoBtlsBioMono.BioControlFunc) + 3160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = (nint)0 + (nint)2000;
		object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
		object obj6 = (nint)0 + (nint)1768;
		object obj7 = (nint)0 + (nint)800;
		object obj8 = obj2 + 16;
		obj8 = messageData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string userName = (string)obj3;
		object obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v9+B8]");
		object source = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj6);
		object obj11 = Enumerable.FirstOrDefault((IEnumerable<object>)source, func);
		object obj12;
		ChatInk inkId;
		DateTime? avatarDate2;
		if (obj11 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v13 (System.Object)+18]");
			userName = (string)0;
			DateTime? avatarDate = ((FriendProfile)obj11).AvatarDate;
			obj12 = obj8;
			bool flag2 = obj8 == null;
			object obj13 = !flag2;
			inkId = ChatInk.Clean;
			avatarDate2 = avatarDate;
			if (obj13 == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			obj12 = obj8;
			inkId = ChatInk.Clean;
			avatarDate2 = (DateTime?)(object)0;
		}
		object obj14 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 888;
		int num = obj12 + 24;
		string text = ((int*)num)->ToString();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v6+10]");
		ChatMessageData chatMessageData = default(ChatMessageData);
		chatMessageData..ctor((string)0, text, userName, avatarDate2, inkId);
		int num2 = this + 72;
		string text2 = ((int*)num2)->ToString();
		if (!(chatMessageData.<UserId>k__BackingField != text2) || chatMessageData.<IsGenerated>k__BackingField)
		{
			ProcessMessage(chatMessageData);
		}
	}

	private void SfsOnAdminMessage(ChatMessageData messageData)
	{
		ProcessMessage(messageData);
	}
}
