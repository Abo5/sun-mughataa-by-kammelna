using System;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using Features.GameReplay;
using UnityEngine;

public class ChatTabButton : MonoBehaviour
{
	private GameObject chatShine;

	private Transform giftPendingTransform;

	private GameObject giftPendingIcon;

	private GameObject chatIcon;

	private GiftBombEventsChannel giftBombEvents;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_00c7: Expected I, but got O
		//IL_005d: Expected I, but got O
		//IL_006e: Expected O, but got I
		//IL_009a: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)440;
		object obj3 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 296;
		object obj4 = (nint)0 + (nint)424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		ChatHandler.OnChatActivated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftBombEventsChannel.BombEventDel bombEventDel = default(GiftBombEventsChannel.BombEventDel);
		bombEventDel..ctor(this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)432;
		giftBombEvents.OnBombDrop += bombEventDel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftBombEventsChannel.BombEventDel bombEventDel2 = default(GiftBombEventsChannel.BombEventDel);
		bombEventDel2..ctor(this, (IntPtr)obj5);
		giftBombEvents.OnBombCleared += bombEventDel2;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0040: Expected O, but got I
		//IL_00c7: Expected I, but got O
		//IL_005d: Expected I, but got O
		//IL_006e: Expected O, but got I
		//IL_009a: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)440;
		object obj3 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 296;
		object obj4 = (nint)0 + (nint)424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		ChatHandler.OnChatActivated -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftBombEventsChannel.BombEventDel bombEventDel = default(GiftBombEventsChannel.BombEventDel);
		bombEventDel..ctor(this, (IntPtr)obj4);
		object obj5 = (nint)0 + (nint)432;
		giftBombEvents.OnBombDrop -= bombEventDel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		GiftBombEventsChannel.BombEventDel bombEventDel2 = default(GiftBombEventsChannel.BombEventDel);
		bombEventDel2..ctor(this, (IntPtr)obj5);
		giftBombEvents.OnBombCleared -= bombEventDel2;
	}

	private void GiftBombDrop(GiftBombData data)
	{
		if (data != null && !ChatHandler.ChatActive)
		{
			ShowChatShine();
		}
	}

	private void Hide(GiftBombData d)
	{
		HideIcon();
	}

	private void HideIcon()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		GameObject gameObject = chatShine.gameObject;
		gameObject.SetActive(value: false);
		chatIcon.SetActive(value: true);
		GameObject gameObject2 = giftPendingIcon.gameObject;
		object obj = typeof(SqlSingle[]) + 3912;
		gameObject2.SetActive(value: false);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X8_v3+E4]");
		if ((nint)0 != 0)
		{
			AnimationExtensions.AnimEndAnimation(giftPendingTransform);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		AnimationExtensions.AnimEndAnimation(giftPendingTransform);
	}

	private void ShowChatShine()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_00a1: Expected O, but got I4
		GameObject gameObject = chatShine.gameObject;
		gameObject.SetActive(value: true);
		chatIcon.SetActive(value: false);
		GameObject gameObject2 = giftPendingIcon.gameObject;
		object obj = typeof(SqlSingle[]) + 3912;
		gameObject2.SetActive(value: true);
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AnimationExtensions.AnimPulsing(giftPendingTransform, 1.6f, 1.2f, 0.4f);
	}
}
