using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.Rendering;

public abstract class FriendsLeaderboardSource : BaseLeaderboardSource
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<FriendProfile, int> <>9__9_4;

		public static Func<LeaderBoardPlayer, int> <>9__9_6;

		public static Action<Action> <>9__9_8;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 3192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <PrepareLeaderboard>b__9_4(FriendProfile f)
		{
			//IL_0035: Expected I4, but got O
			if (f != null)
			{
				return f.UserID;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal int <PrepareLeaderboard>b__9_6(LeaderBoardPlayer p)
		{
			//IL_0035: Expected I4, but got O
			if (p != null)
			{
				return p.LastPoints;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void <PrepareLeaderboard>b__9_8(Action cb)
		{
			if (cb != null)
			{
				IntPtr invoke_impl = ((Delegate)cb).invoke_impl;
				IntPtr method_code = ((Delegate)cb).method_code;
				IntPtr method = ((Delegate)cb).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass10_0
	{
		public Action<LeaderboardModel> successCallback;

		public FriendsLeaderboardSource <>4__this;

		internal void <Load>b__0()
		{
			//IL_0011: Expected O, but got I
			FriendsLeaderboardSource friendsLeaderboardSource = <>4__this;
			object etag = (nint)0 + (nint)2000;
			LeaderboardModel arg = LeaderboardModel.FromList(friendsLeaderboardSource.LastList, (string)etag);
			Actions.SafeInvoke((Action<object>)successCallback, arg);
		}
	}

	private sealed class <>c__DisplayClass11_0
	{
		public Action<LeaderBoardPlayer> callback;

		public FriendsLeaderboardSource <>4__this;

		internal void <GetMyRanking>b__0()
		{
			FriendsLeaderboardSource friendsLeaderboardSource = <>4__this;
			Actions.SafeInvoke((Action<object>)callback, friendsLeaderboardSource.Me);
		}
	}

	private sealed class <>c__DisplayClass12_0
	{
		public FriendsLeaderboardSource <>4__this;

		public Action<LeaderBoardPlayer> callback;

		internal void <CreateMe>b__0(PlayerProfileModel model)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_02be: Expected O, but got I
			//IL_02fb: Expected O, but got I4
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Expected O, but got Unknown
			//IL_01f5: Expected I, but got O
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Expected O, but got Unknown
			//IL_0287: Expected O, but got I
			//IL_0297: Expected O, but got I
			//IL_02a7: Expected O, but got I
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1696;
			object obj2 = typeof(Queue<string>) + 848;
			object obj3 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = default(object);
			obj4..ctor();
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User localUser = sessionModel.LocalUser;
			string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
			int num = int.Parse(dbId);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel2 = default(SessionModel);
			User localUser2 = sessionModel2.LocalUser;
			string userName = SFSKammelnaUserExtensions.GetUserName(localUser2);
			object obj7 = obj4 + 48;
			obj7 = userName;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel3 = default(SessionModel);
			User localUser3 = sessionModel3.LocalUser;
			bool flag2 = SFSKammelnaUserExtensions.IsSubscribed(localUser3);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel4 = default(SessionModel);
			User localUser4 = sessionModel4.LocalUser;
			bool flag3 = SFSKammelnaUserExtensions.IsVerified(localUser4);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel5 = default(SessionModel);
			User localUser5 = sessionModel5.LocalUser;
			DateTime? avatarDate = SFSKammelnaUserExtensions.GetAvatarDate(localUser5);
			_ = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel6 = default(SessionModel);
			User localUser6 = sessionModel6.LocalUser;
			PlayerRank rank = SFSKammelnaUserExtensions.GetRank(localUser6);
			_ = rank.<Points>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel7 = default(SessionModel);
			User localUser7 = sessionModel7.LocalUser;
			int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(localUser7);
			FriendsLeaderboardSource friendsLeaderboardSource = <>4__this;
			nint num2 = (nint)friendsLeaderboardSource;
			int points = friendsLeaderboardSource.GetPoints(model);
			object obj8 = <>4__this + 24;
			obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Action<LeaderBoardPlayer> action = callback;
			if (callback != null)
			{
				FriendsLeaderboardSource friendsLeaderboardSource2 = <>4__this;
				LeaderBoardPlayer me = friendsLeaderboardSource2.Me;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v7 (System.Action`1<LeaderBoardPlayer>)+18]");
				object obj9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v7 (System.Action`1<LeaderBoardPlayer>)+40]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v7 (System.Action`1<LeaderBoardPlayer>)+28]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v132 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public List<FriendLeaderboardModel> friendsList;

		public bool friendsDone;

		public FriendsLeaderboardSource <>4__this;

		public bool meDone;

		internal void <PrepareLeaderboard>b__0(KammelnaResponseModel<List<FriendLeaderboardModel>> response)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_004a: Expected O, but got I
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Expected O, but got Unknown
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			//IL_0098: Expected O, but got I
			//IL_016e: Expected I4, but got O
			//IL_01ab: Expected O, but got I4
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Expected O, but got Unknown
			//IL_0278: Expected O, but got I
			//IL_0289: Expected I, but got O
			//IL_0240: Expected O, but got I4
			object obj = typeof(DebugUI.BitField) + 3232;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 16;
			obj3 = response;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = (nint)0 + (nint)696;
			if (((KammelnaResponseModel<object>)obj3).Succeeded)
			{
				object obj5 = obj3;
				object obj6 = this + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v22+30]");
				obj6 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				friendsDone = true;
				<PrepareLeaderboard>g__TrySuccessFinish|2();
				return;
			}
			FriendsLeaderboardSource friendsLeaderboardSource = <>4__this;
			object obj7 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3552;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor((IEnumerable<object>)friendsLeaderboardSource._pendingFailureCallbacks);
			FriendsLeaderboardSource friendsLeaderboardSource2 = <>4__this;
			List<Action> pendingSuccessCallbacks = friendsLeaderboardSource2._pendingSuccessCallbacks;
			int version = pendingSuccessCallbacks._version + 1;
			pendingSuccessCallbacks._size = 0;
			pendingSuccessCallbacks._version = version;
			bool flag = pendingSuccessCallbacks._size < 1;
			int num = (int)friendsLeaderboardSource._pendingFailureCallbacks;
			if (!flag)
			{
				Array.Clear(pendingSuccessCallbacks._items, 0, pendingSuccessCallbacks._size);
				friendsLeaderboardSource2 = <>4__this;
				object obj8 = 0;
				num = 0;
			}
			List<Action<string>> pendingFailureCallbacks = friendsLeaderboardSource2._pendingFailureCallbacks;
			int version2 = pendingFailureCallbacks._version + 1;
			pendingFailureCallbacks._size = 0;
			pendingFailureCallbacks._version = version2;
			if (pendingFailureCallbacks._size >= 1)
			{
				Array.Clear(pendingFailureCallbacks._items, 0, pendingFailureCallbacks._size);
				object obj8 = 0;
				num = 0;
			}
			object obj9 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)824;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj10);
			list.ForEach(action);
			FriendsLeaderboardSource friendsLeaderboardSource3 = <>4__this;
			friendsLeaderboardSource3._isPreparing = false;
		}

		internal void <PrepareLeaderboard>b__1(LeaderBoardPlayer _)
		{
			meDone = true;
			<PrepareLeaderboard>g__TrySuccessFinish|2();
		}

		internal void <PrepareLeaderboard>g__TrySuccessFinish|2()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_00b8: Expected O, but got I4
			//IL_0936: Expected O, but got I
			//IL_0945: Unknown result type (might be due to invalid IL or missing references)
			//IL_094a: Expected O, but got Unknown
			//IL_0154: Expected O, but got I
			//IL_0164: Expected O, but got I
			//IL_0186: Expected O, but got I4
			//IL_01f7: Expected O, but got I
			//IL_020a: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Expected O, but got Unknown
			//IL_00ed: Expected O, but got I
			//IL_00fd: Expected O, but got I
			//IL_011f: Expected O, but got I4
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Expected O, but got Unknown
			//IL_0250: Expected O, but got I
			//IL_0261: Expected I, but got O
			//IL_01b6: Expected O, but got I4
			//IL_0272: Expected O, but got I
			//IL_0986: Unknown result type (might be due to invalid IL or missing references)
			//IL_098b: Expected O, but got Unknown
			//IL_09a1: Expected O, but got I
			//IL_09b2: Expected I, but got O
			//IL_09d0: Expected O, but got I
			//IL_01e6: Expected O, but got I
			//IL_02bb: Expected O, but got I
			//IL_0315: Expected O, but got I4
			//IL_03eb: Expected O, but got I
			//IL_03fb: Expected O, but got I
			//IL_040b: Expected O, but got I
			//IL_0451: Expected O, but got I4
			//IL_0461: Expected O, but got I
			//IL_09ff: Expected O, but got I
			//IL_0a0f: Expected O, but got I
			//IL_0a31: Expected O, but got I4
			//IL_0a3a: Expected O, but got I4
			//IL_0350: Unknown result type (might be due to invalid IL or missing references)
			//IL_0355: Expected O, but got Unknown
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0363: Expected O, but got Unknown
			//IL_03ae: Expected O, but got I4
			//IL_0b34: Expected O, but got I
			//IL_051e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0523: Expected O, but got Unknown
			//IL_04ca: Expected O, but got I4
			//IL_0559: Unknown result type (might be due to invalid IL or missing references)
			//IL_055e: Expected O, but got Unknown
			//IL_0574: Expected O, but got I
			//IL_0585: Expected I, but got O
			//IL_0a57: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5c: Expected O, but got Unknown
			//IL_0a72: Expected O, but got I
			//IL_0a83: Expected I, but got O
			//IL_0aa1: Expected O, but got I
			//IL_0508: Expected O, but got I4
			//IL_04fa: Expected O, but got I
			//IL_05b8: Expected O, but got I
			//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f6: Expected O, but got Unknown
			//IL_0684: Expected O, but got I4
			//IL_0691: Expected I4, but got O
			//IL_06ce: Expected O, but got I4
			//IL_0832: Expected O, but got I
			//IL_0842: Expected O, but got I
			//IL_0864: Expected O, but got I4
			//IL_0763: Expected O, but got I4
			//IL_07fd: Expected O, but got I4
			//IL_07ae: Expected O, but got I
			//IL_07be: Expected O, but got I
			//IL_0894: Expected O, but got I4
			//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0acc: Expected O, but got Unknown
			//IL_0ae2: Expected O, but got I
			//IL_0af3: Expected I, but got O
			//IL_0b11: Expected O, but got I
			//IL_08c4: Expected O, but got I
			object obj = typeof(DebugUI.BitField) + 3240;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj2 + 32;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (!friendsDone || !meDone)
			{
				return;
			}
			object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj5 = obj4;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X0_v11+B8]");
			object obj7 = 0;
			object obj8 = typeof(DebugUI.BitField) + 3192;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v72+E4]");
			object obj10;
			Func<object, int> func;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v72+B8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v78+8]");
				func = (Func<object, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v78+8]");
				bool flag2 = (nint)0 == 0;
				object obj11 = !flag2;
				if (obj11 == null)
				{
					goto IL_0194;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v72+B8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v78+8]");
				func = (Func<object, int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v78+8]");
				bool flag3 = (nint)0 == 0;
				object obj12 = !flag3;
				if (obj12 == null)
				{
					goto IL_0194;
				}
			}
			goto IL_01eb;
			IL_0194:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X0_v72+E4]");
			bool flag4 = (nint)0 == 0;
			object obj13 = !flag4;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj14 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v417 @ X8_v84+B8]");
				obj10 = 0;
			}
			object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)760;
			Func<object, int> func2 = default(Func<object, int>);
			func2..ctor(obj10, (IntPtr)obj16);
			object obj17 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v83+B8]");
			object obj18 = (nint)0 + (nint)8;
			obj18 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			func = func2;
			goto IL_01eb;
			IL_0481:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj19 = obj8;
			object obj21;
			object obj20 = obj21;
			FriendsLeaderboardSource friendsLeaderboardSource2;
			FriendsLeaderboardSource friendsLeaderboardSource = friendsLeaderboardSource2;
			goto IL_09ef;
			IL_01eb:
			object obj22 = (nint)0 + (nint)1560;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2DE5C6C");
			object obj23 = obj2 + 16;
			object obj24 = default(object);
			obj23 = obj24;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj25 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1176;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj26 = (nint)0 + (nint)832;
			Func<object, object> func3 = default(Func<object, object>);
			func3..ctor(obj2, (IntPtr)obj26);
			object obj27 = (nint)0 + (nint)3248;
			obj20 = obj27;
			IEnumerable<object> source = Enumerable.Select(friendsList, func3);
			List<object> list = Enumerable.ToList(source);
			FriendsLeaderboardSource friendsLeaderboardSource3 = <>4__this;
			object obj28 = (nint)0 + (nint)3064;
			object obj29 = obj28;
			int version = list._version + 1;
			list._version = version;
			object[] items = list._items;
			bool flag5 = list._size < items.Length;
			object obj30 = !flag5;
			if (obj30 == null)
			{
				int size = list._size + 1;
				list._size = size;
				object obj31 = items + list._size;
				object obj32 = obj31 + 32;
				obj32 = friendsLeaderboardSource3.Me;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				friendsLeaderboardSource = <>4__this;
				obj19 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v24+E4]");
				bool flag6 = (nint)0 == 0;
				object obj33 = !flag6;
				if (obj33 == null)
				{
					obj21 = obj20;
					friendsLeaderboardSource2 = <>4__this;
					object obj34 = obj19;
					goto IL_0481;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v20+20]");
				object obj35 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v72+C0]");
				object obj36 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v73+70]");
				obj21 = 0;
				list.AddWithResize((object)friendsLeaderboardSource3.Me);
				friendsLeaderboardSource2 = <>4__this;
				object obj34 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v63+E4]");
				bool flag7 = (nint)0 == 0;
				object obj37 = !flag7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v73+70]");
				obj20 = 0;
				friendsLeaderboardSource = <>4__this;
				obj19 = obj34;
				if (obj37 == null)
				{
					goto IL_0481;
				}
			}
			goto IL_09ef;
			IL_08d6:
			List<object> list2 = default(List<object>);
			Action<object> action;
			list2.ForEach(action);
			FriendsLeaderboardSource friendsLeaderboardSource4 = <>4__this;
			friendsLeaderboardSource4._isPreparing = false;
			return;
			IL_09ef:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v24+B8]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v63+10]");
			Func<object, int> keySelector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v63+10]");
			bool flag8 = (nint)0 == 0;
			object obj39 = !flag8;
			object obj40 = 0;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v486 @ X0_v24+E4]");
				bool flag9 = (nint)0 == 0;
				object obj41 = !flag9;
				if (obj41 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj42 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X8_v69+B8]");
					obj38 = 0;
				}
				object obj43 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2256;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj44 = (nint)0 + (nint)768;
				Func<object, int> func4 = default(Func<object, int>);
				func4..ctor(obj38, (IntPtr)obj44);
				object obj45 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v515 @ X8_v68+B8]");
				object obj46 = (nint)0 + (nint)16;
				obj46 = func4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj40 = 0;
				keySelector = func4;
			}
			object obj47 = (nint)0 + (nint)2424;
			IOrderedEnumerable<object> source2 = Enumerable.OrderByDescending(list, keySelector);
			List<object> list3 = Enumerable.ToList(source2);
			object obj48 = friendsLeaderboardSource + 16;
			obj48 = list3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			FriendsLeaderboardSource friendsLeaderboardSource5 = <>4__this;
			object obj49 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2528;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj50 = (nint)0 + (nint)840;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj2, (IntPtr)obj50);
			((List<object>)(object)friendsLeaderboardSource5.LastList).ForEach(action2);
			FriendsLeaderboardSource friendsLeaderboardSource6 = <>4__this;
			object obj51 = (nint)0 + (nint)3088;
			bool flag10 = ((List<object>)(object)friendsLeaderboardSource6.LastList).Remove((object)friendsLeaderboardSource6.Me);
			FriendsLeaderboardSource friendsLeaderboardSource7 = <>4__this;
			object obj52 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 4072;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			list2..ctor((IEnumerable<object>)friendsLeaderboardSource7._pendingSuccessCallbacks);
			FriendsLeaderboardSource friendsLeaderboardSource8 = <>4__this;
			List<Action> pendingSuccessCallbacks = friendsLeaderboardSource8._pendingSuccessCallbacks;
			int version2 = pendingSuccessCallbacks._version + 1;
			pendingSuccessCallbacks._size = 0;
			pendingSuccessCallbacks._version = version2;
			bool flag11 = pendingSuccessCallbacks._size < 1;
			object obj53 = 0;
			int num = (int)friendsLeaderboardSource7._pendingSuccessCallbacks;
			if (!flag11)
			{
				Array.Clear(pendingSuccessCallbacks._items, 0, pendingSuccessCallbacks._size);
				friendsLeaderboardSource8 = <>4__this;
				obj53 = 0;
				num = 0;
			}
			List<Action<string>> pendingFailureCallbacks = friendsLeaderboardSource8._pendingFailureCallbacks;
			int version3 = pendingFailureCallbacks._version + 1;
			pendingFailureCallbacks._size = 0;
			pendingFailureCallbacks._version = version3;
			if (pendingFailureCallbacks._size >= 1)
			{
				Array.Clear(pendingFailureCallbacks._items, 0, pendingFailureCallbacks._size);
				obj53 = 0;
				num = 0;
			}
			object obj54 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v43+E4]");
			object obj55;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v43+B8]");
				obj55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v51+18]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v51+18]");
				if ((nint)0 != 0)
				{
					goto IL_07e3;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj54 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v43+B8]");
				obj55 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v51+18]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X8_v51+18]");
				bool flag12 = (nint)0 == 0;
				object obj56 = !flag12;
				if (obj56 != null)
				{
					goto IL_07e3;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X0_v43+E4]");
			bool flag13 = (nint)0 == 0;
			object obj57 = !flag13;
			if (obj57 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj58 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v57+B8]");
				obj55 = 0;
			}
			object obj59 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1032;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj60 = (nint)0 + (nint)776;
			Action<object> action3 = default(Action<object>);
			action3..ctor(obj55, (IntPtr)obj60);
			object obj61 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v56+B8]");
			object obj62 = (nint)0 + (nint)24;
			obj62 = action3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			action = action3;
			goto IL_08d6;
			IL_07e3:
			bool flag14 = list2 == null;
			object obj63 = !flag14;
			if (obj63 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_08d6;
		}
	}

	private sealed class <>c__DisplayClass9_1
	{
		public KammelnaResponseModel<List<FriendLeaderboardModel>> response;

		internal void <PrepareLeaderboard>b__3(Action<string> cb)
		{
			//IL_0025: Expected O, but got I
			//IL_0035: Expected O, but got I
			//IL_0045: Expected O, but got I
			if (cb != null)
			{
				string errorMessage = ((KammelnaResponseModel<object>)(object)response).ErrorMessage;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cb @ X1 (System.Action`1<System.String>)+18]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cb @ X1 (System.Action`1<System.String>)+40]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [cb @ X1 (System.Action`1<System.String>)+28]");
				object obj3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v64 @ X3_v1 (should have been resolved before IL gen)");
			}
		}
	}

	private sealed class <>c__DisplayClass9_2
	{
		public Dictionary<int, FriendProfile> friendsLookup;

		public int rank;

		public <>c__DisplayClass9_0 CS$<>8__locals1;

		internal LeaderBoardPlayer <PrepareLeaderboard>b__5(FriendLeaderboardModel f)
		{
			<>c__DisplayClass9_0 cS$<>8__locals = CS$<>8__locals1;
			if (CS$<>8__locals1 != null && cS$<>8__locals.<>4__this != null)
			{
				return cS$<>8__locals.<>4__this.FromFriendModel(f, friendsLookup);
			}
			return (LeaderBoardPlayer)(object)new NullReferenceException();
		}

		internal void <PrepareLeaderboard>b__7(LeaderBoardPlayer p)
		{
			p.LastRank = rank;
			int num = rank + 1;
			rank = num;
		}
	}

	private List<LeaderBoardPlayer> LastList;

	private LeaderBoardPlayer Me;

	private bool _isPreparing;

	private readonly List<Action> _pendingSuccessCallbacks;

	private readonly List<Action<string>> _pendingFailureCallbacks;

	public override bool IsLive => false;

	public override bool IsGameDependent => true;

	private void PrepareLeaderboard(Action successCallback, Action<string> failureCallback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0051: Expected O, but got I
		//IL_00ab: Expected O, but got I4
		//IL_0128: Expected O, but got I
		//IL_0138: Expected O, but got I
		//IL_0148: Expected O, but got I
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0175: Expected O, but got I
		//IL_01cf: Expected O, but got I4
		//IL_033a: Expected O, but got I
		//IL_034a: Expected O, but got I
		//IL_035a: Expected O, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_0287: Expected O, but got I4
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_024b: Expected O, but got I4
		//IL_02c0: Expected O, but got I
		//IL_02d1: Expected I, but got O
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_0309: Expected O, but got I
		//IL_031a: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 3224;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		List<object> pendingSuccessCallbacks = (List<object>)(object)_pendingSuccessCallbacks;
		object obj4 = (nint)0 + (nint)320;
		object obj5 = obj4;
		int version = pendingSuccessCallbacks._version + 1;
		pendingSuccessCallbacks._version = version;
		object[] items = pendingSuccessCallbacks._items;
		bool flag = pendingSuccessCallbacks._size < items.Length;
		object obj6 = !flag;
		if (obj6 == null)
		{
			int size = pendingSuccessCallbacks._size + 1;
			pendingSuccessCallbacks._size = size;
			object obj7 = items + pendingSuccessCallbacks._size;
			object obj8 = obj7 + 32;
			obj8 = successCallback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Action<string> action = failureCallback;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v6+20]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X8_v27+C0]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v28+70]");
			Action<string> action = (Action<string>)0;
			pendingSuccessCallbacks.AddWithResize((object)successCallback);
		}
		List<object> pendingFailureCallbacks = (List<object>)(object)_pendingFailureCallbacks;
		object obj11 = (nint)0 + (nint)2344;
		object obj12 = obj11;
		int version2 = pendingFailureCallbacks._version + 1;
		pendingFailureCallbacks._version = version2;
		object[] items2 = pendingFailureCallbacks._items;
		bool flag2 = pendingFailureCallbacks._size < items2.Length;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			int size2 = pendingFailureCallbacks._size + 1;
			pendingFailureCallbacks._size = size2;
			object obj14 = items2 + pendingFailureCallbacks._size;
			object obj15 = obj14 + 32;
			obj15 = failureCallback;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag3 = !_isPreparing;
			object obj16 = !flag3;
			if (obj16 != null)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v10+20]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v12+C0]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v13+70]");
			Action<string> action = (Action<string>)0;
			pendingFailureCallbacks.AddWithResize((object)failureCallback);
			if (_isPreparing)
			{
				return;
			}
		}
		_isPreparing = true;
		_ = 0;
		_ = 0;
		object obj19 = obj2 + 16;
		obj19 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj20 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = (nint)0 + (nint)808;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj2, (IntPtr)obj21);
		KammelnaRequests.GetFriendsLeaderboardList(action2);
		object obj22 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj23 = (nint)0 + (nint)816;
		Action<object> action3 = default(Action<object>);
		action3..ctor(obj2, (IntPtr)obj23);
		CreateMe(action3);
	}

	public override void Load(GameObject lifecycle, Action<LeaderboardModel> successCallback, Action useCacheCallback, Action<string> onError)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00d7: Expected O, but got I
		//IL_00e8: Expected I, but got O
		//IL_0086: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 3200;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = successCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (LastList != null)
		{
			object etag = (nint)0 + (nint)2000;
			LeaderboardModel arg = LeaderboardModel.FromList(LastList, (string)etag);
			Actions.SafeInvoke((Action<object>)obj3, arg);
		}
		else
		{
			object obj5 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj6 = (nint)0 + (nint)784;
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj6);
			PrepareLeaderboard(action, onError);
		}
	}

	public override void GetMyRanking(Action<LeaderBoardPlayer> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00d3: Expected O, but got I
		//IL_00e4: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 3208;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (Me != null)
		{
			object obj5 = obj3;
			if (obj3 == null)
			{
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v90 @ X8_v7+18] (should have been resolved before IL gen)");
		}
		object obj6 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj7 = (nint)0 + (nint)792;
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj7);
		PrepareLeaderboard(action, null);
	}

	private void CreateMe(Action<LeaderBoardPlayer> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00aa: Expected I, but got O
		//IL_00d9: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 3216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		object obj4 = (nint)0 + (nint)800;
		object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj6 = obj2 + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj2 + 24;
		obj7 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v13+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.RequestMyProfile(action);
	}

	private LeaderBoardPlayer FromFriendModel(FriendLeaderboardModel sourceModel, Dictionary<int, FriendProfile> friendsLookup)
	{
		//IL_002e: Expected O, but got I
		//IL_0044: Expected I4, but got I8
		//IL_0060: Expected O, but got I8
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0192: Expected I, but got O
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0099: Expected O, but got I4
		//IL_00d5: Expected O, but got I4
		if (sourceModel != null && friendsLookup != null)
		{
			object obj = (nint)0 + (nint)464;
			object value;
			bool flag = ((Dictionary<int, object>)(object)friendsLookup).TryGetValue((int)sourceModel.<userDbId>k__BackingField, out value);
			bool flag2 = !flag;
			Games? games = (Games?)(object)sourceModel.<userDbId>k__BackingField;
			if (flag2)
			{
				goto IL_0166;
			}
			if (value != null)
			{
				FriendGameData gameData = ((FriendProfile)value).GetGameData((Games?)(object)0);
				if (gameData != null)
				{
					sourceModel.<points>k__BackingField = gameData.Points;
					games = (Games?)(object)0;
					goto IL_0166;
				}
			}
		}
		goto IL_013b;
		IL_013b:
		return (LeaderBoardPlayer)(object)new NullReferenceException();
		IL_0166:
		object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1696;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		nint num = (nint)this;
		int points = GetPoints(sourceModel);
		if (obj3 != null)
		{
			_ = sourceModel.<userDbId>k__BackingField;
			object obj4 = obj3 + 48;
			obj4 = sourceModel.<userName>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = sourceModel.<points>k__BackingField;
			_ = sourceModel.<activeCardback>k__BackingField;
			_ = sourceModel.<isSubscribed>k__BackingField;
			_ = sourceModel.<avatar>k__BackingField;
			return (LeaderBoardPlayer)obj3;
		}
		goto IL_013b;
	}

	protected abstract int GetPoints(FriendLeaderboardModel sourcePlayer);

	protected abstract int GetPoints(PlayerProfileModel sourcePlayer);

	protected FriendsLeaderboardSource()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 4072;
		object obj2 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3552;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj3 = this + 40;
		obj3 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		object obj4 = this + 48;
		obj4 = list2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		((object)this)..ctor();
	}
}
