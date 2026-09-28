using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CommunityPageCounters : MonoBehaviour
{
	private TextMeshProUGUI privateChats;

	private TextMeshProUGUI onlineFriends;

	private TextMeshProUGUI totalFriends;

	private Image onlineIndicatorImage;

	private SpriteToggler unreadChatToggler;

	private LegacyTextToggler unreadChatTextToggler;

	private LegacyTextToggler onlineFriendsTextToggler;

	private int onlineCount;

	private int chatCount;

	private int friendsCount;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00ea: Expected O, but got I
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0116: Expected I, but got O
		//IL_0140: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0098: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3296;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj4 = typeof(CardUtils.<>c) + 2776;
		object obj5 = (nint)0 + (nint)3288;
		object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.OnFriendListUpdated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CounterBubbleManager.CounterUpdated counterUpdated = default(CounterBubbleManager.CounterUpdated);
		counterUpdated..ctor(this, (IntPtr)obj5);
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.OnCounterUpdated += counterUpdated;
		UpdateUi();
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_010b: Expected I, but got O
		//IL_0135: Expected O, but got I4
		//IL_006e: Expected I, but got O
		//IL_0098: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 2776;
		object obj2 = (nint)0 + (nint)3288;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object obj4 = typeof(SqlSingle[]) + 2376;
		object obj5 = (nint)0 + (nint)3296;
		object obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CounterBubbleManager.CounterUpdated counterUpdated = default(CounterBubbleManager.CounterUpdated);
		counterUpdated..ctor(this, (IntPtr)obj2);
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.OnCounterUpdated -= counterUpdated;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj5);
		object obj9 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.OnFriendListUpdated -= action;
	}

	private unsafe void UpdateUi()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0376: Expected O, but got I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected I4, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected I4, but got Unknown
		//IL_009e: Expected O, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected I4, but got Unknown
		//IL_0192: Expected O, but got I4
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected I4, but got Unknown
		//IL_01c1: Expected O, but got I4
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected I4, but got Unknown
		//IL_0248: Expected O, but got I4
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected I4, but got Unknown
		//IL_02d2: Expected O, but got I4
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected I4, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<FriendProfile> friendsList = FriendsManager.FriendsList;
		int value = Enumerable.Count((IEnumerable<object>)friendsList);
		int num = this + 96;
		((int*)num)->m_value = value;
		IEnumerable<FriendProfile> onlineFriendsList = FriendsManager.OnlineFriendsList;
		int value2 = Enumerable.Count((IEnumerable<object>)onlineFriendsList);
		int num2 = this + 88;
		((int*)num2)->m_value = value2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X20_v5 (System.Int32)-28]");
		object obj4 = 0;
		string text = ((int*)num)->ToString();
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v71 @ X8_v5+558] (should have been resolved before IL gen)");
		string text2 = ((int*)num2)->ToString();
		onlineFriends.text = text2;
		int num3 = this + 92;
		string text3 = ((int*)num3)->ToString();
		privateChats.text = text3;
		GameObject gameObject = onlineIndicatorImage.gameObject;
		bool flag2 = onlineCount < 0;
		bool flag3 = onlineCount == 0;
		int num4 = onlineCount ^ onlineCount;
		int num5 = onlineCount & num4;
		bool flag4 = num5 < 0;
		bool flag5 = flag2 == flag4;
		object obj6 = !flag3;
		bool active = (byte)((flag5 & obj6) ? 1 : 0) != 0;
		gameObject.SetActive(active);
		object obj7 = chatCount - 1;
		bool flag6 = (nint)obj7 < 0;
		int num6 = chatCount ^ 1;
		int num7 = chatCount ^ obj7;
		int num8 = num6 & num7;
		bool flag7 = num8 < 0;
		bool flag8 = flag6 == flag7;
		bool isON = !flag8;
		unreadChatToggler.ToggleManual(isON);
		object obj8 = chatCount - 1;
		bool flag9 = (nint)obj8 < 0;
		int num9 = chatCount ^ 1;
		int num10 = chatCount ^ obj8;
		int num11 = num9 & num10;
		bool flag10 = num11 < 0;
		bool flag11 = flag9 == flag10;
		bool isON2 = !flag11;
		unreadChatTextToggler.ToggleManual(isON2);
		object obj9 = ((int*)num2)->m_value - 1;
		bool flag12 = (nint)obj9 < 0;
		int num12 = ((int*)num2)->m_value ^ 1;
		int num13 = ((int*)num2)->m_value ^ obj9;
		int num14 = num12 & num13;
		bool flag13 = num14 < 0;
		bool flag14 = flag12 == flag13;
		bool isON3 = !flag14;
		onlineFriendsTextToggler.ToggleManual(isON3);
	}

	private void OnCounterUpdated(CounterBubbleType type, int newCount, string extra)
	{
		//IL_0016: Expected O, but got I
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00bb: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E613B]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			if (type != CounterBubbleType.PrivateChat)
			{
				goto IL_0050;
			}
		}
		else
		{
			_ = 1;
			if (type != CounterBubbleType.PrivateChat)
			{
				goto IL_0050;
			}
		}
		object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		int count = CounterBubbleManager.GetCount(CounterBubbleType.PrivateChat);
		chatCount = count;
		UpdateUi();
		return;
		IL_0050:
		UpdateUi();
	}

	private void OnFriendListUpdated()
	{
		UpdateUi();
	}
}
