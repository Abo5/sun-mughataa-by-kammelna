using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using TMPro;
using UnityEngine;

public class LobbyShareButton : MonoBehaviour
{
	private GameObject friendsCountArea;

	private TextMeshProUGUI textNumber;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00a8: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1600;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Refresh();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.OnFriendListUpdated += action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)1600;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
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
		FriendsManager.OnFriendListUpdated -= action;
	}

	private void Refresh()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_010c: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected I4, but got Unknown
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<FriendProfile> onlineFriendsList = FriendsManager.OnlineFriendsList;
		int num = Enumerable.Count((IEnumerable<object>)onlineFriendsList);
		bool flag2 = num < 0;
		bool flag3 = num == 0;
		int num2 = num ^ num;
		int num3 = num & num2;
		bool flag4 = num3 < 0;
		bool flag5 = flag2 == flag4;
		object obj4 = !flag3;
		bool active = (byte)((flag5 & obj4) ? 1 : 0) != 0;
		friendsCountArea.SetActive(active);
		int num4 = default(int);
		string text = num4.ToString();
		textNumber.text = text;
	}

	private void UpdateOnlineNumber(int number)
	{
		//IL_0060: Expected O, but got I4
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected I4, but got Unknown
		bool flag = number < 0;
		bool flag2 = number == 0;
		int num = number ^ number;
		int num2 = number & num;
		bool flag3 = num2 < 0;
		bool flag4 = flag == flag3;
		object obj = !flag2;
		bool active = (byte)((flag4 & obj) ? 1 : 0) != 0;
		friendsCountArea.SetActive(active);
		int num3 = default(int);
		string text = num3.ToString();
		textNumber.text = text;
	}

	private void ShowFriendsCount()
	{
		friendsCountArea.SetActive(value: true);
	}

	private void HideFriendsCount()
	{
		friendsCountArea.SetActive(value: false);
	}
}
