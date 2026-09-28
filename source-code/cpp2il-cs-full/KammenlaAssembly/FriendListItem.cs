using System;
using System.Buffers.Text;
using System.ComponentModel;
using System.Data.SqlTypes;
using Cpp2ILInjected;
using DataTracking;
using Kammelna.Server.Models.Clans;
using ListView;
using Unity.Services.Authentication.Shared;
using UnityEngine.InputSystem.XR;

public class FriendListItem : ListViewItem<IListViewItemData<int>, int>
{
	private AvatarInitializer profileInitializer;

	private FriendProfileHolder dataHolder;

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 128;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override void Setup(IListViewItemData<int> datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_0086: Expected O, but got I
		//IL_00f5: Expected O, but got I
		//IL_01d0: Expected O, but got I4
		//IL_01d9: Expected O, but got I4
		//IL_01e2: Expected O, but got I4
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00e0: Expected O, but got I4
		//IL_0184: Expected O, but got I
		//IL_018c: Expected I4, but got O
		//IL_0126: Expected O, but got I
		//IL_012e: Expected I4, but got O
		//IL_0215: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02d7: Expected O, but got I4
		//IL_01f9: Expected O, but got I4
		//IL_0309: Expected O, but got I
		object obj = (nint)0 + (nint)1472;
		bool flag = default(bool);
		((ListViewItem<object, int>)(object)this).Setup((object)datum, flag);
		if (datum == null)
		{
			goto IL_0234;
		}
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1424;
		object obj3 = obj2;
		nint num = (nint)datum;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v7 (Il2CppClass<ListView.IListViewItemData`1<System.Int32>>)+40]");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X1_v4+40]");
		if (num2 != 0)
		{
			goto IL_0242;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
		object obj4 = default(object);
		FriendProfileHolder friendProfileHolder = (FriendProfileHolder)obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+10]");
		object obj5 = 0;
		object obj7;
		if (flag)
		{
			friendProfileHolder = (FriendProfileHolder)obj4;
			dataHolder = (FriendProfileHolder)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+10]");
			_ = 0;
			object obj6 = this + 144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj7 = 0;
			goto IL_0206;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendListItem)+98]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendListItem)+98]");
		int? num3;
		int? num4;
		int? num5;
		if ((nint)0 != 0)
		{
			object obj9 = (nint)0 + (nint)3136;
			flag = (byte)(int)obj9 != 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v14+10]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+10]");
			bool flag2 = (nint)0 == 0;
			num4 = num3;
			num5 = num3;
			if (!flag2)
			{
				goto IL_0178;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+10]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			num4 = (int?)(object)0;
			num5 = (int?)(object)0;
			if (obj10 != null)
			{
				goto IL_0178;
			}
		}
		int? num6 = (int?)(object)0;
		num4 = num5;
		goto IL_0274;
		IL_0206:
		object obj11 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendListItem)+98]");
		AvatarData avatarData = default(AvatarData);
		avatarData..ctor((FriendProfile)0, alsoAnimate: false);
		if ((object)profileInitializer != null)
		{
			profileInitializer.Initialize(avatarData);
			return;
		}
		goto IL_0234;
		IL_0178:
		object obj12 = (nint)0 + (nint)3136;
		flag = (byte)(int)obj12 != 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X21_v4+10]");
		num3 = 0;
		num6 = num3;
		goto IL_0274;
		IL_0274:
		object obj13 = (object?)num6 ^ (object?)num4;
		object obj14 = obj13 & -4294967295L;
		dataHolder = friendProfileHolder;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v8+10]");
		_ = 0;
		object obj15 = this + 144;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag4 = obj14 == null;
		obj7 = 0;
		if (flag4)
		{
			return;
		}
		goto IL_0206;
		IL_0242:
		throw new InvalidCastException();
		IL_0234:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0242;
	}

	public void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendListItem)+98]");
		AvatarData avatarData = default(AvatarData);
		avatarData..ctor((FriendProfile)0, alsoAnimate: false);
		profileInitializer.Initialize(avatarData);
	}

	public unsafe void OpenProfile()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		object obj = typeof(MemberAchievementClanFeedData) + 840;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendListItem)+98]");
		int num = (int)((nint)0 + (nint)16);
		string dbId = ((int*)num)->ToString();
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			MiniProfilePopup.Show(dbId, TrackingPlacement.FriendsCenter);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		MiniProfilePopup.Show(dbId, TrackingPlacement.FriendsCenter);
	}

	public void OpenChat()
	{
		//IL_005c: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendListItem)+98]");
		object obj = 0;
		object obj2 = typeof(UsageHint) + 24;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X9_v4+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
		((UserChatPopup)obj4).Open(0);
	}

	public void Selected()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_0076: Expected O, but got I
		//IL_0086: Expected O, but got I
		object obj = (nint)0 + (nint)440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+20]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v3+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendListItem)+98]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+18]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+40]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3+28]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v52 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	public void AcceptRequest()
	{
		//IL_008b: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendListItem)+98]");
		object obj = 0;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
			FriendsManager.AddFriend(0);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
			FriendsManager.AddFriend(0);
		}
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
		object obj2 = (nint)0 + (nint)2568;
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

	public void RejectRequest()
	{
		Unfriend();
	}

	public void CancelPending()
	{
		Unfriend();
	}

	public void BlockUser()
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
		object obj2 = (nint)0 + (nint)2560;
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

	public void UnblockUser()
	{
		//IL_008b: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendListItem)+98]");
		object obj = 0;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
			FriendsManager.UnblockUser(0);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
			FriendsManager.UnblockUser(0);
		}
	}

	public FriendListItem()
	{
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	private void <Unfriend>b__9_0()
	{
		//IL_008b: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendListItem)+98]");
		object obj = 0;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
			FriendsManager.RemoveFriend(0);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
			FriendsManager.RemoveFriend(0);
		}
	}

	private void <BlockUser>b__12_0()
	{
		//IL_008b: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendListItem)+98]");
		object obj = 0;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
			FriendsManager.BlockUser(0);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
			FriendsManager.BlockUser(0);
		}
	}
}
