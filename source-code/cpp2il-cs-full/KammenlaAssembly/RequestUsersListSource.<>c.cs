using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Sfs2X.Entities;
using UnityEngine;
using Util;

public class RequestUsersListSource : IUsersListSource
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<FriendProfile, PlayerInfo> <>9__3_5;

		public static Func<PlayerInfo, int> <>9__3_6;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 880;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal PlayerInfo <GetUsersList>b__3_5(FriendProfile profile)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 936;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			PlayerInfo playerInfo = default(PlayerInfo);
			playerInfo..ctor(profile);
			return playerInfo;
		}

		internal int <GetUsersList>b__3_6(PlayerInfo info)
		{
			//IL_0035: Expected I4, but got O
			if (info != null)
			{
				return info.<DBID>k__BackingField;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass3_0
	{
		public RequestUsersListSource <>4__this;

		public Action<UsersListModel> callback;

		internal void <GetUsersList>b__0(UsersListModel model)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Expected O, but got Unknown
			object obj = <>4__this + 24;
			obj = model;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<GetUsersList>g__AppendFriendsThenCallback|4(model);
		}

		internal void <GetUsersList>b__1()
		{
			RequestUsersListSource requestUsersListSource = <>4__this;
			<GetUsersList>g__AppendFriendsThenCallback|4(requestUsersListSource._usersListModel);
		}

		internal void <GetUsersList>b__2(UsersListModel model)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0041: Expected O, but got I
			//IL_0051: Expected O, but got I
			//IL_0061: Expected O, but got I
			Action<UsersListModel> action = callback;
			object obj = <>4__this + 24;
			obj = model;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v2 (System.Action`1<UsersListModel>)+18]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v2 (System.Action`1<UsersListModel>)+40]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v16 @ X20_v2 (System.Action`1<UsersListModel>)+28]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v39 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void <GetUsersList>b__3()
		{
			//IL_003b: Expected O, but got I
			//IL_004b: Expected O, but got I
			//IL_005b: Expected O, but got I
			RequestUsersListSource requestUsersListSource = <>4__this;
			Action<UsersListModel> action = callback;
			UsersListModel usersListModel = requestUsersListSource._usersListModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X9_v2 (System.Action`1<UsersListModel>)+18]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X9_v2 (System.Action`1<UsersListModel>)+40]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X9_v2 (System.Action`1<UsersListModel>)+28]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v31 @ X3_v1 (should have been resolved before IL gen)");
			/*Error: End of method reached without returning.*/;
		}

		internal void <GetUsersList>g__AppendFriendsThenCallback|4(UsersListModel model)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_02f0: Expected O, but got I4
			//IL_00c3: Expected O, but got I
			//IL_00d3: Expected O, but got I
			//IL_00e3: Expected O, but got I
			//IL_0105: Expected O, but got I4
			//IL_01bb: Expected O, but got I4
			//IL_0135: Expected O, but got I4
			//IL_03c2: Expected O, but got I
			//IL_03d3: Expected O, but got I
			//IL_03e3: Expected O, but got I
			//IL_0405: Expected O, but got I4
			//IL_0344: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Expected O, but got Unknown
			//IL_035f: Expected O, but got I
			//IL_0370: Expected I, but got O
			//IL_038e: Expected O, but got I
			//IL_03a9: Expected O, but got I4
			//IL_0165: Expected O, but got I
			//IL_0202: Expected O, but got I4
			//IL_0284: Expected O, but got I
			//IL_0294: Expected O, but got I
			//IL_02a4: Expected O, but got I
			//IL_0422: Unknown result type (might be due to invalid IL or missing references)
			//IL_0427: Expected O, but got Unknown
			//IL_043d: Expected O, but got I
			//IL_044e: Expected I, but got O
			//IL_046c: Expected O, but got I
			//IL_0487: Expected O, but got I4
			//IL_0232: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj2 = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 880;
			object first = model + 32;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
			if ((nint)0 == 0)
			{
				goto IL_02ae;
			}
			IEnumerable<FriendProfile> onlineFriendsList = FriendsManager.OnlineFriendsList;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			IEnumerable<FriendProfile> source = onlineFriendsList;
			IEnumerable<FriendProfile> enumerable = onlineFriendsList;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_00b6;
			}
			goto IL_0316;
			IL_02ae:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			IEnumerable<FriendProfile> onlineFriendsList2 = FriendsManager.OnlineFriendsList;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			source = onlineFriendsList2;
			enumerable = onlineFriendsList2;
			obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_00b6;
			}
			goto IL_0316;
			IL_00b6:
			object obj7 = (nint)0 + (nint)3016;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v11+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v24+8]");
			Func<object, object> selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v24+8]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X0_v11+E4]");
				bool flag4 = (nint)0 == 0;
				object obj10 = !flag4;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj11 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v30+B8]");
					obj8 = 0;
				}
				object obj12 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1216;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj13 = (nint)0 + (nint)3976;
				Func<object, object> func = default(Func<object, object>);
				func..ctor(obj8, (IntPtr)obj13);
				object obj14 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v29+B8]");
				object obj15 = (nint)0 + (nint)8;
				obj15 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj16 = 0;
				selector = func;
			}
			IEnumerable<object> second = Enumerable.Select(source, selector);
			IEnumerable<object> enumerable2 = Enumerable.Union((IEnumerable<object>)first, second);
			object obj17 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			object obj18 = !flag5;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj17 = obj2;
			}
			object obj19 = (nint)0 + (nint)1920;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v18+B8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v16+10]");
			Func<object, int> func2 = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v16+10]");
			bool flag6 = (nint)0 == 0;
			object obj21 = !flag6;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v18+E4]");
				bool flag7 = (nint)0 == 0;
				object obj22 = !flag7;
				if (obj22 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj23 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v22+B8]");
					obj20 = 0;
				}
				object obj24 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2680;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj25 = (nint)0 + (nint)3984;
				Func<object, int> func3 = default(Func<object, int>);
				func3..ctor(obj20, (IntPtr)obj25);
				object obj26 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v21+B8]");
				object obj27 = (nint)0 + (nint)16;
				obj27 = func3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj16 = 0;
				func2 = func3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C94D6C");
			IEnumerable<object> source2 = default(IEnumerable<object>);
			List<object> list = Enumerable.ToList(source2);
			first = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Action<UsersListModel> action = callback;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v15 (System.Action`1<UsersListModel>)+18]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v15 (System.Action`1<UsersListModel>)+40]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v15 (System.Action`1<UsersListModel>)+28]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v118 @ X3_v4 (should have been resolved before IL gen)");
			goto IL_02ae;
			IL_0316:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj4 = obj2;
			source = enumerable;
			goto IL_00b6;
		}
	}

	private readonly GameObject _lifecycle;

	private UsersListModel _usersListModel;

	public RequestUsersListSource(GameObject lifecycle)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		object obj = this + 16;
		obj = lifecycle;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void GetUsersList(Action<UsersListModel> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0367: Expected O, but got I
		//IL_0391: Expected O, but got I4
		//IL_039a: Expected I8, but got I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I4
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_03b9: Expected I8, but got I4
		//IL_0111: Expected O, but got I
		//IL_013b: Expected O, but got I4
		//IL_02ac: Expected O, but got I
		//IL_02bd: Expected I, but got O
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_02ec: Expected O, but got I
		//IL_02fd: Expected I, but got O
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0311: Expected O, but got Unknown
		//IL_01f1: Expected O, but got I
		//IL_0202: Expected I, but got O
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_032c: Expected O, but got I
		//IL_033a: Expected I, but got O
		//IL_0231: Expected O, but got I
		//IL_0242: Expected I, but got O
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0271: Expected O, but got I
		//IL_027f: Expected I, but got O
		object obj = typeof(RankedPlayManager.<>c__DisplayClass36_0) + 888;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 848;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		Action<UsersListModel> action = default(Action<UsersListModel>);
		obj5 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		UsersListModel usersListModel = _usersListModel;
		object obj9;
		long num2;
		long lastUpdate;
		object obj12;
		if (_usersListModel != null)
		{
			object obj6 = typeof(DataRelation) + 824;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v34+E4]");
			bool flag = (nint)0 == 0;
			object obj8 = !flag;
			if (obj8 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			long num = DateTimeUtil.ToEpochMilli(usersListModel.<LastUpdate>k__BackingField);
			obj9 = (nint)0 + (nint)2200;
			object obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v32+E4]");
			bool flag2 = (nint)0 == 0;
			object obj11 = !flag2;
			num2 = num;
			obj12 = obj9;
			lastUpdate = num;
			if (obj11 == null)
			{
				goto IL_0161;
			}
		}
		else
		{
			obj12 = (nint)0 + (nint)2200;
			object obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v32+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			lastUpdate = -1L;
			if (obj13 == null)
			{
				obj9 = obj12;
				num2 = -1L;
				goto IL_0161;
			}
		}
		goto IL_0180;
		IL_0161:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj12 = obj9;
		lastUpdate = num2;
		goto IL_0180;
		IL_0180:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3976;
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		bool flag4 = SFSKammelnaRoomExtensions.IsLobby(currentRoom);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		if (flag4)
		{
			object obj15 = (nint)0 + (nint)3992;
			action2..ctor(obj2, (IntPtr)obj15);
			object obj16 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = (nint)0 + (nint)4000;
			Action action3 = default(Action);
			action3..ctor(obj2, (IntPtr)obj17);
			object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj19 = (nint)0 + (nint)1912;
			Action<object> action4 = default(Action<object>);
			action4..ctor((object)null, (IntPtr)obj19);
			SFS.GetMainRoomOnlineUsersList(_lifecycle, lastUpdate, action2, action3, action4);
		}
		else
		{
			object obj20 = (nint)0 + (nint)4008;
			action2..ctor(obj2, (IntPtr)obj20);
			object obj21 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj22 = (nint)0 + (nint)4016;
			Action action5 = default(Action);
			action5..ctor(obj2, (IntPtr)obj22);
			object obj23 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj24 = (nint)0 + (nint)1912;
			Action<object> action6 = default(Action<object>);
			action6..ctor((object)null, (IntPtr)obj24);
			SFS.GetCurrentRoomOnlineUsersList(_lifecycle, lastUpdate, action2, action5, action6);
		}
	}
}
