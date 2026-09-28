using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Sfs2X.Entities;
using UnityEngine;

public class GameReplayChatBox : BaseListChatBox
{
	private GameObject _emptyState;

	private PopupUI _popup;

	private GameEventsChannel _gameEventsChannel;

	private GameObject EmptyState => _emptyState;

	public void OnEnable()
	{
		//IL_007e: Expected O, but got I4
		ChatHandler.ChatActive = true;
		List<ChatMessageDataHolder> data = listView.data;
		bool active;
		if (data != null)
		{
			bool flag = data._size == 0;
			active = flag;
		}
		else
		{
			bool flag2 = (object)_emptyState == null;
			object obj = !flag2;
			active = false;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		_emptyState.SetActive(active);
	}

	public void OnDisable()
	{
		ChatHandler.ChatActive = false;
	}

	protected override void Init()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002f: Expected I, but got O
		//IL_003f: Expected O, but got I
		//IL_007a: Expected O, but got I
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		if (ChatHandler.IsChatRoom)
		{
			Room lastJoinedRoom = SFS.LastJoinedRoom;
			object obj = typeof(RegisteredWaitHandle) + 1376;
			nint num = (nint)lastJoinedRoom;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X8_v7 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
				object obj3 = (nint)0 + (nint)8;
				string activeGroup = default(string);
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X10_v4-8]");
					if (0 != (nint)obj)
					{
						obj3 += 16;
						obj2--;
						continue;
					}
					object obj4 = obj3 + 1;
					object obj5 = num + obj4;
					object obj6 = obj5 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v127 @ X8_v10] (should have been resolved before IL gen)");
					ChatHandler.ActiveGroup = activeGroup;
					return;
				}
				while ((nint)obj2 != 1);
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v149 @ X0_v8] (should have been resolved before IL gen)");
			string activeGroup2 = default(string);
			ChatHandler.ActiveGroup = activeGroup2;
		}
		else
		{
			object activeGroup3 = "{0} color encoding is currently unsupported for outputting to HDR." + 2192;
			ChatHandler.ActiveGroup = (string)activeGroup3;
		}
	}

	protected override void RegisterSFSSceneCallbacks()
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
		//IL_0072: Expected I, but got O
		//IL_00ae: Expected I, but got O
		//IL_00d9: Expected I, but got O
		//IL_01b2: Expected O, but got I4
		//IL_01bb: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		//IL_015b: Expected O, but got I
		//IL_0169: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj3 = (nint)0 + (nint)2048;
		object obj4 = typeof(SqlSingle[]) + 2376;
		object obj5 = (nint)0 + (nint)2056;
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4 (Il2CppClass<GameReplayChatBox>)+1B0]");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)0);
		ChatHandler.OnMessage += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj3);
		ChatHandler.OnGroupChange += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj5);
		ChatHandler.OnClear += action3;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			bool flag = _popup;
			bool flag2 = !flag;
			object obj8 = 0;
			if (flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = _popup;
			bool flag4 = !flag3;
			object obj9 = !flag4;
			object obj8 = 0;
			if (obj9 == null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)2064;
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj10);
		_gameEventsChannel.ShowChat += action4;
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
		//IL_0072: Expected I, but got O
		//IL_00ae: Expected I, but got O
		//IL_00d9: Expected I, but got O
		//IL_01b2: Expected O, but got I4
		//IL_01bb: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		//IL_015b: Expected O, but got I
		//IL_0169: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj3 = (nint)0 + (nint)2048;
		object obj4 = typeof(SqlSingle[]) + 2376;
		object obj5 = (nint)0 + (nint)2056;
		object obj6 = typeof(MemberAchievementClanFeedData) + 2976;
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4 (Il2CppClass<GameReplayChatBox>)+1B0]");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)0);
		ChatHandler.OnMessage -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj3);
		ChatHandler.OnGroupChange -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj5);
		ChatHandler.OnClear -= action3;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			bool flag = _popup;
			bool flag2 = !flag;
			object obj8 = 0;
			if (flag2)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = _popup;
			bool flag4 = !flag3;
			object obj9 = !flag4;
			object obj8 = 0;
			if (obj9 == null)
			{
				return;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj10 = (nint)0 + (nint)2064;
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj10);
		_gameEventsChannel.ShowChat -= action4;
	}

	private void ShowChatPopup()
	{
		_popup.Show();
		ChatHandler.ChatActive = true;
	}

	protected override void AddMessage(ChatMessageData messageData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0096: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		ChatMessageData messageData2 = default(ChatMessageData);
		base.AddMessage(messageData2);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if ((bool)_popup)
			{
				goto IL_0041;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = _popup;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_0041;
			}
		}
		bool chatActive = false;
		goto IL_00fa;
		IL_00fa:
		ChatHandler.ChatActive = chatActive;
		_emptyState.SetActive(value: false);
		return;
		IL_0041:
		PopupUI popup = _popup;
		chatActive = popup.<IsCurrentlyShown>k__BackingField;
		goto IL_00fa;
	}

	public void JoinGroup(string groupTag)
	{
		List<ChatMessageData> messages = ChatHandler.GetMessages();
		SetMessages(messages);
	}

	private void OnClear()
	{
		listView.Clear();
		_emptyState.SetActive(value: true);
	}
}
