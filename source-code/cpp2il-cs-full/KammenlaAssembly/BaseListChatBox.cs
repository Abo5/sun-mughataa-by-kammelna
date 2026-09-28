using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;

public abstract class BaseListChatBox : MonoBehaviour
{
	protected ChatMessagesListView listView;

	private void Start()
	{
		//IL_000b: Expected I, but got O
		//IL_001b: Expected O, but got I
		//IL_002b: Expected O, but got I
		RegisterSFSSceneCallbacks();
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v2 (Il2CppClass<BaseListChatBox>)+178]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X8_v2 (Il2CppClass<BaseListChatBox>)+180]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v31 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void OnDestroy()
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<BaseListChatBox>)+198]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<BaseListChatBox>)+1A0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	protected virtual void Init()
	{
	}

	protected abstract void RegisterSFSSceneCallbacks();

	protected abstract void UnregisterSFSSceneCallbacks();

	protected virtual void AddMessage(ChatMessageData messageData)
	{
		listView.AddMessage(messageData);
	}

	protected void AddChallengeMessage(FriendlyChallengeData challenge)
	{
		listView.AddChallengeMessage(challenge);
	}

	protected void SetMessages(List<ChatMessageData> messages)
	{
		listView.SetData(messages);
	}
}
