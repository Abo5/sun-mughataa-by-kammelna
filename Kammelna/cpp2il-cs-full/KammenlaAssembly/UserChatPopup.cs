using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Threading;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using UI.UI_Themeing;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class UserChatPopup : MonoBehaviour
{
	private PrivateChatBox chatbox;

	private AvatarInitializer[] userInitializers;

	private SlideAnimationHelper popup;

	private UserNotesEditor notesEditor;

	private UiToggler menuButtonToggler;

	private SlideAnimationHelper userMenu;

	private FriendProfile profile;

	private int userId;

	public static UserChatPopup Instance;

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)56;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 48;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_00cc: Expected I, but got O
		object obj = typeof(UsageHint) + 24;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)3920;
		object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		object obj6 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			FriendsManager.OnFriendListUpdated += action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FriendsManager.OnFriendListUpdated += action;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3920;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			FriendsManager.OnFriendListUpdated -= action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FriendsManager.OnFriendListUpdated -= action;
	}

	private void OnFriendListUpdated()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0105: Expected O, but got I4
		//IL_00b8: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61FE]");
		object obj3 = (nint)0 & (nint)1;
		int num;
		int num2;
		if (obj3 != null)
		{
			num = userId;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			num2 = userId;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			num = userId;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			num2 = userId;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FriendProfile friendProfile = FriendsManager.GetProfile(num2);
		if (friendProfile != null)
		{
			goto IL_0156;
		}
		return;
		IL_0156:
		if (friendProfile.Status != Friend.Status.Accepted)
		{
			popup.SlideOut();
		}
		return;
		IL_0091:
		friendProfile = FriendsManager.GetProfile(num);
		bool flag3 = friendProfile == null;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			return;
		}
		goto IL_0156;
	}

	public void Open(int userID)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_01a8: Expected O, but got I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_012d: Expected O, but got I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0155: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		userId = userID;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendProfile friendProfile = FriendsManager.GetProfile(userID);
		object obj4 = this + 80;
		obj4 = friendProfile;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v4+20]");
		if ((nint)0 != 2)
		{
			return;
		}
		popup.SlideIn();
		menuButtonToggler.ToggleManual(isON: false);
		userMenu.SlideOut();
		notesEditor.Initialize(userId);
		chatbox.Initialize(userId);
		AvatarInitializer[] array = userInitializers;
		if (array.Length >= 1)
		{
			object obj6 = array + 32;
			object obj7 = 0;
			do
			{
				AvatarData data = (FriendProfile)obj4;
				obj7++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X23_v4+v135 @ X22_v6*8]");
				((AvatarInitializer)0).Initialize(data);
			}
			while ((nint)obj7 < array.Length);
		}
	}

	public unsafe void OpenProfile()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected I4, but got Unknown
		//IL_00f9: Expected O, but got I4
		//IL_0102: Expected O, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected I4, but got Unknown
		//IL_0087: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6200]");
		object obj2 = (nint)0 & (nint)1;
		string text;
		string dbId;
		if (obj2 != null)
		{
			int num = this + 88;
			text = ((int*)num)->ToString();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = 0;
			dbId = text;
			if (!flag)
			{
				goto IL_009d;
			}
		}
		else
		{
			_ = 1;
			int num2 = this + 88;
			text = ((int*)num2)->ToString();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = 0;
			dbId = text;
			if (obj5 != null)
			{
				goto IL_009d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		MiniProfilePopup.Show(dbId, TrackingPlacement.PrivateChat);
		return;
		IL_009d:
		MiniProfilePopup.Show(text, TrackingPlacement.PrivateChat);
	}

	public void OpenMenu()
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004a: Expected O, but got I
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_008a: Expected I, but got O
		//IL_00b4: Expected O, but got I4
		menuButtonToggler.ToggleManual(isON: true);
		userMenu.SlideIn();
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3912;
		object obj3 = typeof(RegisteredWaitHandle) + 3136;
		GameObject contentObject = userMenu.GetContentObject();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v10+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ScreenManager.PushPopup(contentObject, action);
	}

	public void CloseMenu()
	{
		menuButtonToggler.ToggleManual(isON: false);
		userMenu.SlideOut();
	}

	public void Clear()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0090: Expected I, but got O
		//IL_00ba: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3888;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "Complete" + 256;
		object msgBody = "Added Tournament Prizes And Features" + 2208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action);
	}

	public void OpenChangeNicknamePopup()
	{
		if (profile != null)
		{
			menuButtonToggler.ToggleManual(isON: false);
			userMenu.SlideOut();
			FriendNicknameUtil.OpenChangeNicknamePopup(profile);
		}
	}

	public unsafe void BuyForFriend()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected I4, but got Unknown
		//IL_00f4: Expected O, but got I4
		//IL_00fd: Expected O, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected I4, but got Unknown
		//IL_0087: Expected O, but got I4
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 3760;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6203]");
		object obj2 = (nint)0 & (nint)1;
		string text;
		string dbId;
		if (obj2 != null)
		{
			int num = this + 88;
			text = ((int*)num)->ToString();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = 0;
			dbId = text;
			if (!flag)
			{
				goto IL_009d;
			}
		}
		else
		{
			_ = 1;
			int num2 = this + 88;
			text = ((int*)num2)->ToString();
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v2+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = 0;
			dbId = text;
			if (obj5 != null)
			{
				goto IL_009d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		BuyForFriendPopup.ShowFor(dbId);
		return;
		IL_009d:
		BuyForFriendPopup.ShowFor(text);
	}

	public void Unfriend()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0090: Expected I, but got O
		//IL_00ba: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3896;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "Complete" + 256;
		object msgBody = "Added Tournament Prizes And Features" + 2208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action);
	}

	public void GoToStore()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0063: Expected O, but got I4
		//IL_0038: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 1552;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		RoutingManager.Route(RoutingCommand.Store, null, (Games?)(object)0);
	}

	private void <Clear>b__17_0()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_010d: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6206]");
		object obj3 = (nint)0 & (nint)1;
		int num;
		int num2;
		if (obj3 != null)
		{
			num = userId;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			num2 = userId;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			num = userId;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			num2 = userId;
			if (obj5 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FriendsManager.DeleteChatHistory(num2);
		BaseToggler baseToggler = menuButtonToggler;
		goto IL_014c;
		IL_014c:
		baseToggler.ToggleManual(isON: false);
		userMenu.SlideOut();
		popup.SlideOut();
		return;
		IL_0091:
		FriendsManager.DeleteChatHistory(num);
		baseToggler = menuButtonToggler;
		bool flag3 = (object)menuButtonToggler == null;
		object obj6 = !flag3;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_014c;
	}

	private void <Unfriend>b__20_0()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0070: Expected I, but got O
		//IL_009a: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj2 = (nint)0 + (nint)3904;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.RemoveFriend(userId, action);
	}

	private void <Unfriend>b__20_1(KammelnaResponseModel<bool> response)
	{
		//IL_0106: Expected O, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_009e: Expected O, but got I4
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		if (response.Succeeded)
		{
			menuButtonToggler.ToggleManual(isON: false);
			userMenu.SlideOut();
			popup.SlideOut();
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object title = "DNQUALIFIER" + 3784;
			object body = "Read object reference Id '{0}' for {1}." + 1672;
			object buttonText = "Network Authentication Required" + 3128;
			PopupWindow.ShowInfo((string)title, (string)body, (string)buttonText);
		}
		else
		{
			object obj4 = (nint)0 + (nint)1024;
			string errorMessage = response.ErrorMessage;
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v10+E4]");
			if ((nint)0 != 0)
			{
				PopupWindow.ShowError(errorMessage);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PopupWindow.ShowError(errorMessage);
		}
	}
}
