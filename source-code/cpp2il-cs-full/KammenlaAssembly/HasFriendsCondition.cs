using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using Features.GameReplay;
using UI.Conditions;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class HasFriendsCondition : BoolCondition
{
	private enum FriendType
	{
		All,
		Friend,
		Online,
		SentRequest,
		ReceivedRequest,
		Blocked,
		Offline,
		OnlineAvailability
	}

	private FriendType type;

	protected override bool ActualValue
	{
		get
		{
			IEnumerable<FriendProfile> friendsList = GetFriendsList();
			return Enumerable.Any((IEnumerable<object>)friendsList);
		}
	}

	private IEnumerable<FriendProfile> GetFriendsList()
	{
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0280: Expected O, but got I4
		//IL_0522: Expected O, but got I
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b9: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0476: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_049e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a3: Expected O, but got Unknown
		//IL_04d3: Expected O, but got I
		if (type > FriendType.Online)
		{
			if (type <= FriendType.ReceivedRequest)
			{
				if (type == FriendType.SentRequest)
				{
					object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
					object obj2 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v54+E4]");
					if ((nint)0 != 0)
					{
						return FriendsManager.SentRequests;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					return FriendsManager.SentRequests;
				}
				if (type == FriendType.ReceivedRequest)
				{
					object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
					object obj4 = obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v60+E4]");
					if ((nint)0 != 0)
					{
						return FriendsManager.ReceivedRequests;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					return FriendsManager.ReceivedRequests;
				}
			}
			else
			{
				if (type == FriendType.Blocked)
				{
					object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
					object obj6 = obj5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v42+E4]");
					if ((nint)0 != 0)
					{
						return FriendsManager.BlockedList;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					return FriendsManager.BlockedList;
				}
				if (type == FriendType.Offline)
				{
					object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X0_v48+E4]");
					if ((nint)0 != 0)
					{
						return FriendsManager.OfflineFriendsList;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					return FriendsManager.OfflineFriendsList;
				}
			}
		}
		else
		{
			if (type == FriendType.All)
			{
				object obj9 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
				object obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v26+E4]");
				bool flag = (nint)0 == 0;
				object obj11 = !flag;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj10 = obj9;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v26+B8]");
				return (IEnumerable<FriendProfile>)0;
			}
			if (type == FriendType.Friend)
			{
				object obj12 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v30+E4]");
				if ((nint)0 != 0)
				{
					return FriendsManager.FriendsList;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return FriendsManager.FriendsList;
			}
			if (type == FriendType.Online)
			{
				object obj14 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
				object obj15 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X0_v36+E4]");
				if ((nint)0 != 0)
				{
					return FriendsManager.OnlineFriendsList;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return FriendsManager.OnlineFriendsList;
			}
		}
		object obj16 = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 1296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj17 = "{0} color encoding is currently unsupported for outputting to HDR." + 160;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		string format = default(string);
		object arg = default(object);
		string message = string.Format(format, arg);
		object obj18 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = "tournament_participate_warning_body_with_tickets_warning_daily" + 968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		string paramName = default(string);
		object actualValue = default(object);
		ex..ctor(paramName, actualValue, message);
		object obj20 = (nint)0 + (nint)632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		return (IEnumerable<FriendProfile>)new OutOfMemoryException();
	}

	public override void Setup(GameObject gm)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00ac: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)560;
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		GameObject gm2 = default(GameObject);
		base.Setup(gm2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		FriendsManager.OnFriendListUpdated += action;
	}

	public override void Teardown()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)560;
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
}
