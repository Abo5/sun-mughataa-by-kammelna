using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using DataTracking;
using GoogleMobileAds.Api.AdManager;
using GoogleMobileAds.Ump.Api;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Coordinator.Models;
using Server.Models;
using Sfs2X.Core;
using Sfs2X.Entities;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;

public class FriendsManager : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<FriendProfile, bool> <>9__5_0;

		public static Func<FriendProfile, bool> <>9__7_0;

		public static Func<FriendProfile, bool> <>9__9_0;

		public static Func<FriendProfile, bool> <>9__11_0;

		public static Func<FriendProfile, bool> <>9__13_0;

		public static Func<FriendProfile, bool> <>9__15_0;

		public static Func<FriendProfile, int> <>9__17_0;

		public static Action<FriendProfile> <>9__37_0;

		public static Action<FriendProfile> <>9__41_1;

		public static Func<FriendProfile, bool> <>9__43_1;

		public static Func<FriendProfile, int> <>9__46_1;

		public static Action<FriendProfile> <>9__46_5;

		public static Action<int> <>9__46_6;

		public static Func<FriendProfile, bool> <>9__46_7;

		public static Func<PrivateMessageModel, string> <>9__47_2;

		public static Func<int, bool> <>9__47_4;

		public static Action<IGrouping<string, PrivateMessageModel>> <>9__47_3;

		public static Action<KammelnaResponseModel<List<PrivateMessageModel>>> <>9__47_1;

		public static Action <>9__47_0;

		public static Func<PrivateMessageModel, int> <>9__67_1;

		public static Comparison<PrivateMessageModel> <>9__67_0;

		public static Func<FriendProfile, <>f__AnonymousType5<string, string>> <>9__69_1;

		public static Action <>9__69_0;

		public static Comparison<PrivateMessageModel> <>9__70_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 3264;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_FriendsList>b__5_0(FriendProfile friend)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (friend != null)
			{
				object obj = friend.Status - 2;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_OnlineFriendsList>b__7_0(FriendProfile b)
		{
			//IL_0035: Expected I4, but got O
			if (b != null)
			{
				return b.IsOnline;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_OfflineFriendsList>b__9_0(FriendProfile f)
		{
			//IL_0044: Expected I4, but got O
			if (f != null)
			{
				return !f.IsOnline;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_ReceivedRequests>b__11_0(FriendProfile friend)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (friend != null)
			{
				object obj = friend.Status - 1;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_SentRequests>b__13_0(FriendProfile friend)
		{
			//IL_0044: Expected I4, but got O
			if (friend != null)
			{
				return friend.Status == Friend.Status.PendingAccept;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <get_BlockedList>b__15_0(FriendProfile friend)
		{
			//IL_0052: Expected I4, but got O
			//IL_0030: Expected O, but got I4
			if (friend != null)
			{
				object obj = friend.Status - 3;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <get_UnreadMessagesCount>b__17_0(FriendProfile friend)
		{
			//IL_0035: Expected I4, but got O
			if (friend != null)
			{
				return friend.UnreadMessages;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void <MarkRequestSeen>b__37_0(FriendProfile profile)
		{
			profile.RequestSeen = true;
		}

		internal void <InitializeOnlineFriends>b__41_1(FriendProfile f)
		{
			f.IsOnline = true;
		}

		internal bool <OnFriendStatusUpdate>b__43_1(FriendProfile profile)
		{
			//IL_0044: Expected I4, but got O
			if (profile != null)
			{
				return !profile.RequestSeen;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal int <UpdateFriendsList>b__46_1(FriendProfile f)
		{
			//IL_0035: Expected I4, but got O
			if (f != null)
			{
				return f.UserID;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void <UpdateFriendsList>b__46_5(FriendProfile f)
		{
			f.IsOnline = false;
		}

		internal void <UpdateFriendsList>b__46_6(int fID)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			//IL_004d: Expected O, but got I
			//IL_007d: Expected O, but got I4
			//IL_00f2: Expected O, but got I
			//IL_010d: Expected I, but got O
			object obj = typeof(DebugUI.BitField) + 3344;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			object obj5 = (nint)0 + (nint)1136;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+B8]");
			object source = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj5);
			object obj8 = Enumerable.FirstOrDefault((IEnumerable<object>)source, func);
			if (obj8 != null)
			{
				_ = 1;
			}
		}

		internal bool <UpdateFriendsList>b__46_7(FriendProfile profile)
		{
			//IL_0044: Expected I4, but got O
			if (profile != null)
			{
				return !profile.RequestSeen;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <GetUnreadMessages>b__47_0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected O, but got Unknown
			//IL_0198: Expected O, but got I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0240: Expected O, but got I
			//IL_0250: Expected O, but got I
			//IL_0272: Expected O, but got I4
			//IL_00ff: Expected O, but got I
			//IL_010f: Expected O, but got I
			//IL_0131: Expected O, but got I4
			//IL_01f0: Expected O, but got I4
			//IL_02aa: Expected O, but got I4
			//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0301: Expected O, but got Unknown
			//IL_0317: Expected O, but got I
			//IL_0328: Expected I, but got O
			//IL_0346: Expected O, but got I
			//IL_02da: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(UsageHint) + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61D0]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj6;
			if (obj3 != null)
			{
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				obj6 = obj4;
				if (!flag)
				{
					goto IL_0099;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v14+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			long chatLastUpdatedAt = UserInfo.ChatLastUpdatedAt;
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v3+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			obj4 = obj6;
			long num = chatLastUpdatedAt;
			object obj10 = obj8;
			long num2 = chatLastUpdatedAt;
			if (obj9 != null)
			{
				goto IL_00ef;
			}
			goto IL_021e;
			IL_0288:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v3+E4]");
			bool flag4 = (nint)0 == 0;
			object obj11 = !flag4;
			object obj13;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj12 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v10+B8]");
				obj13 = 0;
			}
			object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 400;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj15 = (nint)0 + (nint)888;
			Action<object> action = default(Action<object>);
			action..ctor(obj13, (IntPtr)obj15);
			object obj16 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v9+B8]");
			object obj17 = (nint)0 + (nint)144;
			obj17 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num = num2;
			Action<KammelnaResponseModel<List<PrivateMessageModel>>> callback = action;
			goto IL_02df;
			IL_02df:
			KammelnaRequests.SyncMessages(num, callback);
			return;
			IL_00ef:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v3+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v4+90]");
			callback = (Action<KammelnaResponseModel<List<PrivateMessageModel>>>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v4+90]");
			bool flag5 = (nint)0 == 0;
			object obj18 = !flag5;
			if (obj18 == null)
			{
				obj6 = obj4;
				num2 = num;
				goto IL_0288;
			}
			goto IL_02df;
			IL_0099:
			long chatLastUpdatedAt2 = UserInfo.ChatLastUpdatedAt;
			obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v3+E4]");
			bool flag6 = (nint)0 == 0;
			num = chatLastUpdatedAt2;
			obj10 = obj8;
			obj6 = obj4;
			num2 = chatLastUpdatedAt2;
			if (!flag6)
			{
				goto IL_00ef;
			}
			goto IL_021e;
			IL_021e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v3+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v4+90]");
			callback = (Action<KammelnaResponseModel<List<PrivateMessageModel>>>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X8_v4+90]");
			bool flag7 = (nint)0 == 0;
			object obj19 = !flag7;
			num = num2;
			if (obj19 == null)
			{
				goto IL_0288;
			}
			goto IL_02df;
		}

		internal void <GetUnreadMessages>b__47_1(KammelnaResponseModel<List<PrivateMessageModel>> response)
		{
			//IL_0011: Expected O, but got I
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_00ef: Expected O, but got I
			//IL_00ff: Expected O, but got I
			//IL_0121: Expected O, but got I4
			//IL_0192: Expected O, but got I
			//IL_0088: Expected O, but got I
			//IL_0098: Expected O, but got I
			//IL_00ba: Expected O, but got I4
			//IL_024c: Expected O, but got I
			//IL_025c: Expected O, but got I
			//IL_027e: Expected O, but got I4
			//IL_0151: Expected O, but got I4
			//IL_02ef: Expected O, but got I
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Expected O, but got Unknown
			//IL_033a: Expected O, but got I4
			//IL_01e5: Expected O, but got I
			//IL_01f5: Expected O, but got I
			//IL_0217: Expected O, but got I4
			//IL_0740: Unknown result type (might be due to invalid IL or missing references)
			//IL_0745: Expected O, but got Unknown
			//IL_075b: Expected O, but got I
			//IL_076c: Expected I, but got O
			//IL_078a: Expected O, but got I
			//IL_07a5: Expected O, but got I4
			//IL_02ae: Expected O, but got I4
			//IL_0181: Expected O, but got I
			//IL_07c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c6: Expected O, but got Unknown
			//IL_07dc: Expected O, but got I
			//IL_07ed: Expected I, but got O
			//IL_080b: Expected O, but got I
			//IL_0826: Expected O, but got I4
			//IL_038c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0391: Expected O, but got Unknown
			//IL_03bb: Expected O, but got I4
			//IL_02de: Expected O, but got I
			//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fb: Expected O, but got Unknown
			//IL_0425: Expected O, but got I4
			//IL_046c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0471: Expected O, but got Unknown
			//IL_05f9: Expected O, but got I4
			//IL_0602: Expected O, but got I4
			//IL_060b: Expected O, but got I4
			//IL_04cf: Expected O, but got I4
			//IL_04d8: Expected O, but got I4
			//IL_0509: Expected O, but got I
			//IL_06ab: Expected O, but got I4
			//IL_064b: Expected O, but got I
			//IL_0665: Expected O, but got I4
			//IL_0573: Expected O, but got I
			//IL_0583: Expected O, but got I
			//IL_06eb: Expected O, but got I
			//IL_06fb: Expected O, but got I
			//IL_071d: Expected O, but got I4
			object obj = (nint)0 + (nint)800;
			if (!((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				return;
			}
			object obj2 = typeof(DebugUI.BitField) + 3264;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v60+E4]");
			object obj4;
			Func<object, object> keySelector;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v60+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v54+78]");
				keySelector = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v54+78]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					goto IL_012f;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj3 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v60+B8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v54+78]");
				keySelector = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X8_v54+78]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				if (obj6 == null)
				{
					goto IL_012f;
				}
			}
			goto IL_0186;
			IL_052e:
			object obj8;
			object obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v42+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = obj7;
			if (!flag3)
			{
				goto IL_0563;
			}
			goto IL_06c9;
			IL_02e3:
			object obj10 = (nint)0 + (nint)2000;
			IEnumerable<IGrouping<object, object>> enumeration;
			Action<object> action;
			ArraysExtensions.ForEach(enumeration, action);
			obj8 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v14+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int unreadMessagesCount = UnreadMessagesCount;
			if (unreadMessagesCount < 1)
			{
				return;
			}
			object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
			object obj14 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v16+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CounterBubbleManager.UpdateCounter(CounterBubbleType.PrivateChat, unreadMessagesCount);
			object obj16 = typeof(DataRelation) + 712;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v19+E4]");
			bool flag6 = (nint)0 == 0;
			object obj18 = !flag6;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			DateTime utcNow = DateTime.UtcNow;
			DateTime dateTime = default(DateTime);
			long ticks = dateTime.Ticks;
			object obj19 = typeof(UsageHint) + 72;
			object obj20 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v23+E4]");
			object obj23;
			object obj22;
			if ((nint)0 != 0)
			{
				UserInfo.ChatLastUpdatedAt = ticks;
				object obj21 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v45+E4]");
				bool flag7 = (nint)0 == 0;
				obj22 = 0;
				obj23 = 0;
				object obj24 = obj21;
				if (!flag7)
				{
					goto IL_04ee;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				UserInfo.ChatLastUpdatedAt = ticks;
				object obj21 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X0_v45+E4]");
				bool flag8 = (nint)0 == 0;
				object obj25 = !flag8;
				obj22 = 0;
				obj23 = 0;
				object obj24 = obj21;
				if (obj25 != null)
				{
					goto IL_04ee;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			SaveProfiles();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6284]");
			object obj26 = (nint)0 & (nint)1;
			bool flag9 = obj26 == null;
			object obj27 = !flag9;
			obj22 = obj23;
			if (obj27 != null)
			{
				goto IL_052e;
			}
			goto IL_067b;
			IL_06c9:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj28 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v27+B8]");
			object obj29 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v25+10]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v25+10]");
			bool flag10 = (nint)0 == 0;
			object obj31 = !flag10;
			if (obj31 == null)
			{
				return;
			}
			goto IL_05a8;
			IL_012f:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v60+E4]");
			bool flag11 = (nint)0 == 0;
			object obj32 = !flag11;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj33 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v236 @ X8_v60+B8]");
				obj4 = 0;
			}
			object obj34 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2776;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj35 = (nint)0 + (nint)896;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj4, (IntPtr)obj35);
			object obj36 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v59+B8]");
			object obj37 = (nint)0 + (nint)120;
			obj37 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj38 = 0;
			keySelector = func;
			goto IL_0186;
			IL_067b:
			_ = 1;
			obj7 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v42+E4]");
			bool flag12 = (nint)0 == 0;
			object obj39 = !flag12;
			obj22 = obj23;
			obj9 = obj7;
			if (obj39 != null)
			{
				goto IL_0563;
			}
			goto IL_06c9;
			IL_05a8:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v126 @ X8_v33+18] (should have been resolved before IL gen)");
			return;
			IL_0186:
			object obj40 = (nint)0 + (nint)1544;
			enumeration = Enumerable.GroupBy(response.<Model>k__BackingField, keySelector);
			object obj41 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v50+E4]");
			object obj42;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v50+B8]");
				obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v43+88]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v43+88]");
				bool flag13 = (nint)0 == 0;
				object obj43 = !flag13;
				if (obj43 == null)
				{
					goto IL_028c;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj41 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v50+B8]");
				obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v43+88]");
				action = (Action<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v43+88]");
				bool flag14 = (nint)0 == 0;
				object obj44 = !flag14;
				if (obj44 == null)
				{
					goto IL_028c;
				}
			}
			goto IL_02e3;
			IL_04ee:
			SaveProfiles();
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6284]");
			object obj45 = (nint)0 & (nint)1;
			bool flag15 = obj45 == null;
			obj23 = obj22;
			if (!flag15)
			{
				goto IL_052e;
			}
			goto IL_067b;
			IL_0563:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v42+B8]");
			object obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v35+10]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X8_v35+10]");
			if ((nint)0 != 0)
			{
				goto IL_05a8;
			}
			return;
			IL_028c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v50+E4]");
			bool flag16 = (nint)0 == 0;
			object obj47 = !flag16;
			if (obj47 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj48 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X8_v49+B8]");
				obj42 = 0;
			}
			object obj49 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 280;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj50 = (nint)0 + (nint)904;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj42, (IntPtr)obj50);
			object obj51 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X8_v48+B8]");
			object obj52 = (nint)0 + (nint)136;
			obj52 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj38 = 0;
			action = action2;
			goto IL_02e3;
		}

		internal string <GetUnreadMessages>b__47_2(PrivateMessageModel m)
		{
			if (m != null)
			{
				return m.channelId;
			}
			return (string)(object)new NullReferenceException();
		}

		internal unsafe void <GetUnreadMessages>b__47_3(IGrouping<string, PrivateMessageModel> g)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_0036: Expected I, but got O
			//IL_0046: Expected O, but got I
			//IL_00f0: Expected O, but got I4
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Expected O, but got Unknown
			//IL_014d: Expected O, but got I
			//IL_0159: Expected O, but got I
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Expected O, but got Unknown
			//IL_0081: Expected O, but got I
			//IL_01a1: Expected I, but got O
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Expected O, but got Unknown
			//IL_02b2: Expected O, but got I
			//IL_02c2: Expected O, but got I
			//IL_02d2: Expected O, but got I
			//IL_02f4: Expected O, but got I4
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Expected O, but got Unknown
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Expected O, but got Unknown
			//IL_0270: Expected O, but got I4
			//IL_0279: Expected O, but got I4
			//IL_01f0: Expected O, but got I
			//IL_0200: Expected O, but got I
			//IL_0210: Expected O, but got I
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a4: Expected O, but got Unknown
			//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b8: Expected O, but got Unknown
			//IL_03c4: Expected O, but got I
			//IL_03d0: Expected O, but got I
			//IL_03ff: Expected O, but got I4
			//IL_032c: Expected O, but got I4
			//IL_0660: Expected O, but got I
			//IL_067b: Expected I, but got O
			//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f4: Expected O, but got Unknown
			//IL_060a: Expected O, but got I
			//IL_061b: Expected I, but got O
			//IL_0639: Expected O, but got I
			//IL_0383: Expected O, but got I4
			//IL_035c: Expected O, but got I
			//IL_0450: Unknown result type (might be due to invalid IL or missing references)
			//IL_0455: Expected O, but got Unknown
			//IL_0461: Expected O, but got I
			//IL_047d: Expected I, but got O
			//IL_04a8: Expected O, but got I
			//IL_04be: Expected O, but got I
			//IL_04d3: Expected O, but got I
			//IL_0507: Unknown result type (might be due to invalid IL or missing references)
			//IL_050c: Expected I4, but got Unknown
			//IL_0528: Unknown result type (might be due to invalid IL or missing references)
			//IL_052d: Expected O, but got Unknown
			//IL_0557: Expected O, but got I4
			object obj = typeof(DebugUI.BitField) + 3352;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			List<object> list = Enumerable.ToList((IEnumerable<object>)g);
			object obj3 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 1536;
			nint num = (nint)g;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6 (Il2CppClass<System.Linq.IGrouping`2<System.String, PrivateMessageModel>>)+12E]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6 (Il2CppClass<System.Linq.IGrouping`2<System.String, PrivateMessageModel>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00c2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v6 (Il2CppClass<System.Linq.IGrouping`2<System.String, PrivateMessageModel>>)+B0]");
			object obj5 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X10_v6-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj5 += 16;
				obj4--;
				if ((nint)obj4 != 1)
				{
					continue;
				}
				goto IL_00c2;
			}
			object obj6 = num + obj5;
			object obj7 = obj6 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v314 @ X0_v55] (should have been resolved before IL gen)");
			goto IL_012d;
			IL_012d:
			object obj8 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3576;
			object obj9 = (nint)0 + (nint)2696;
			object obj10 = (nint)0 + (nint)40;
			object obj11 = typeof(DebugUI.BitField) + 3264;
			string text = default(string);
			string[] source = text.Split('_');
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, int> func = default(Func<object, int>);
			func..ctor((object)null, (IntPtr)obj9);
			IEnumerable<int> source2 = Enumerable.Select(source, func);
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v36+E4]");
			object obj13;
			object obj14;
			Func<int, bool> func2;
			object obj15;
			if ((nint)0 != 0)
			{
				obj13 = (nint)0 + (nint)176;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v36+B8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v23+80]");
				func2 = (Func<int, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v23+80]");
				bool flag = (nint)0 == 0;
				obj15 = obj13;
				if (!flag)
				{
					goto IL_023d;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj11;
				obj13 = (nint)0 + (nint)176;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v36+B8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v23+80]");
				func2 = (Func<int, bool>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v390 @ X8_v23+80]");
				bool flag2 = (nint)0 == 0;
				object obj16 = !flag2;
				obj15 = obj13;
				if (obj16 != null)
				{
					goto IL_023d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v376 @ X0_v36+E4]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj18 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v420 @ X8_v29+B8]");
				obj14 = 0;
			}
			object obj19 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj20 = (nint)0 + (nint)912;
			Func<int, bool> func3 = default(Func<int, bool>);
			func3..ctor(obj14, (IntPtr)obj20);
			object obj21 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X8_v28+B8]");
			object obj22 = (nint)0 + (nint)128;
			obj22 = func3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj23 = obj15;
			int num2 = Enumerable.First(source2, func3);
			object obj24 = 0;
			Func<int, bool> func4 = func3;
			goto IL_0390;
			IL_023d:
			obj23 = obj13;
			num2 = Enumerable.First(source2, func2);
			bool flag4 = obj2 == null;
			object obj25 = !flag4;
			obj24 = 0;
			func4 = func2;
			if (obj25 != null)
			{
				goto IL_0390;
			}
			goto IL_0590;
			IL_0390:
			object obj26 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj27 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			object obj28 = (nint)0 + (nint)1144;
			object obj29 = (nint)0 + (nint)800;
			object obj30 = obj26;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v17+E4]");
			bool flag5 = (nint)0 == 0;
			object obj31 = !flag5;
			if (obj31 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj30 = obj26;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v429 @ X0_v17+B8]");
			object source3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func5 = default(Func<object, bool>);
			func5..ctor(obj2, (IntPtr)obj28);
			object obj32 = Enumerable.FirstOrDefault((IEnumerable<object>)source3, func5);
			if (obj32 == null)
			{
				return;
			}
			object obj33 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2744;
			object obj34 = (nint)0 + (nint)1152;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func6 = default(Func<object, bool>);
			func6..ctor(obj2, (IntPtr)obj34);
			int num3 = Enumerable.Count(list, func6);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X0_v21 (System.Object)+60]");
			object obj35 = (nint)num3 + (nint)0;
			object obj36 = (nint)0 + (nint)2184;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X0_v21 (System.Object)+58]");
			((List<object>)0).AddRange(list);
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X0_v21 (System.Object)+60]");
			if ((nint)0 >= (nint)1)
			{
				int num4 = obj32 + 16;
				string extra = ((int*)num4)->ToString();
				object obj37 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
				object obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X0_v30+E4]");
				bool flag6 = (nint)0 == 0;
				object obj39 = !flag6;
				if (obj39 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v452 @ X0_v21 (System.Object)+60]");
				CounterBubbleManager.UpdateCounter(CounterBubbleType.PrivateChat, 0, extra);
			}
			return;
			IL_0590:
			throw new NullReferenceException();
			IL_00c2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v214 @ X0_v52] (should have been resolved before IL gen)");
			bool flag7 = text == null;
			object obj40 = !flag7;
			if (obj40 != null)
			{
				goto IL_012d;
			}
			goto IL_0590;
		}

		internal bool <GetUnreadMessages>b__47_4(int id)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0115: Expected O, but got I
			//IL_013f: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01a4: Expected I4, but got O
			//IL_0188: Expected O, but got I4
			//IL_00e4: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61D2]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				object obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			object obj8 = !flag3;
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_0196;
			IL_00b8:
			User localUser = sessionModel.LocalUser;
			int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
			object obj9 = id - intDbId;
			bool flag4 = obj9 == null;
			return !flag4;
			IL_0196:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_0196;
		}

		internal int <SaveProfiles>b__67_1(PrivateMessageModel model)
		{
			//IL_005d: Expected I4, but got O
			//IL_0025: Expected I, but got O
			//IL_0035: Expected O, but got I
			//IL_0045: Expected O, but got I
			if (model != null)
			{
				nint num = (nint)model;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<PrivateMessageModel>)+158]");
				object obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2 @ X8_v1 (Il2CppClass<PrivateMessageModel>)+160]");
				object obj2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (should have been resolved before IL gen)");
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal unsafe int <SaveProfiles>b__67_0(PrivateMessageModel data, PrivateMessageModel other)
		{
			//IL_0071: Expected I4, but got O
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected I8, but got Unknown
			if (data != null && other != null)
			{
				long num = data + 32;
				return ((long*)num)->CompareTo(other.timestamp);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}

		internal void <CleanLocalChats>b__69_0()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_0458: Expected O, but got Unknown
			//IL_0482: Expected O, but got I4
			//IL_00b1: Expected O, but got I
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_04c2: Expected O, but got I
			//IL_04f4: Expected O, but got I4
			//IL_010a: Expected O, but got I
			//IL_0116: Expected O, but got I
			//IL_0126: Expected O, but got I
			//IL_0136: Expected O, but got I
			//IL_0158: Expected O, but got I4
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Expected O, but got Unknown
			//IL_0219: Expected O, but got I4
			//IL_0188: Expected O, but got I4
			//IL_0565: Unknown result type (might be due to invalid IL or missing references)
			//IL_056a: Expected O, but got Unknown
			//IL_0580: Expected O, but got I
			//IL_0591: Expected I, but got O
			//IL_05af: Expected O, but got I
			//IL_05ca: Expected O, but got I4
			//IL_01b8: Expected O, but got I
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ad: Expected O, but got Unknown
			//IL_02b9: Expected O, but got I
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c7: Expected O, but got Unknown
			//IL_02d3: Expected O, but got I
			//IL_02dc: Expected O, but got I4
			//IL_02e5: Expected O, but got I4
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_0336: Expected O, but got Unknown
			//IL_0369: Expected O, but got I4
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a2: Expected O, but got Unknown
			//IL_03b2: Expected O, but got I
			//IL_03dc: Expected I, but got O
			//IL_0414: Expected O, but got I4
			//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f8: Expected O, but got Unknown
			//IL_0314: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61D3]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v76+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v76+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v6+B8]");
			object obj10 = 0;
			IEnumerable<object> source = (IEnumerable<object>)obj10;
			object obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v42+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			obj4 = obj7;
			object obj13 = obj11;
			IEnumerable<object> enumerable = (IEnumerable<object>)obj10;
			if (obj12 != null)
			{
				goto IL_00fe;
			}
			goto IL_051a;
			IL_0541:
			NullReferenceException ex = new NullReferenceException();
			goto IL_054f;
			IL_054f:
			throw new IndexOutOfRangeException();
			IL_00fe:
			object obj14 = (nint)0 + (nint)3256;
			object obj15 = (nint)0 + (nint)1728;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v42+B8]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v22+B0]");
			Func<object, object> selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v22+B0]");
			bool flag4 = (nint)0 == 0;
			object obj17 = !flag4;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v42+E4]");
				bool flag5 = (nint)0 == 0;
				object obj18 = !flag5;
				if (obj18 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj19 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v28+B8]");
					obj16 = 0;
				}
				object obj20 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1184;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj21 = (nint)0 + (nint)864;
				Func<object, object> func = default(Func<object, object>);
				func..ctor(obj16, (IntPtr)obj21);
				object obj22 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X8_v27+B8]");
				object obj23 = (nint)0 + (nint)176;
				obj23 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj24 = 0;
				selector = func;
			}
			object obj25 = "&action=sign-up" + 3288;
			IEnumerable<object> source2 = Enumerable.Select(source, selector);
			List<object> source3 = Enumerable.ToList(source2);
			object obj26 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v48+E4]");
			bool flag6 = (nint)0 == 0;
			object obj27 = !flag6;
			if (obj27 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string chatsDirectory = ChatsDirectory;
			string text = (string)obj25;
			string[] files = Directory.GetFiles(chatsDirectory, (string)obj25);
			if (files == null)
			{
				goto IL_0541;
			}
			if (files.Length < 1)
			{
				return;
			}
			object obj28 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3184;
			object obj29 = (nint)0 + (nint)1272;
			object obj30 = files + 32;
			object obj31 = (nint)0 + (nint)2440;
			object obj32 = 0;
			object obj33 = 0;
			object obj35 = default(object);
			Func<object, bool> func2 = default(Func<object, bool>);
			while (true)
			{
				object obj34 = typeof(DebugUI.BitField) + 3464;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj35..ctor();
				bool flag7 = (nint)obj33 < files.Length;
				object obj36 = !flag7;
				if (obj36 != null)
				{
					break;
				}
				if (obj35 != null)
				{
					object obj37 = obj35 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X28_v5+v234 @ X24_v8*8]");
					obj37 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					func2..ctor(obj35, (IntPtr)obj29);
					obj32 = obj31;
					bool flag8 = Enumerable.Any(source3, func2);
					bool flag9 = !flag8;
					object obj38 = !flag9;
					text = (string)(object)func2;
					if (obj38 == null)
					{
						File.Delete((string)obj37);
						text = null;
					}
					obj33++;
					bool flag10 = (nint)obj33 >= files.Length;
					object obj24 = 0;
					if (!flag10)
					{
						continue;
					}
					return;
				}
				goto IL_0541;
			}
			goto IL_054f;
			IL_00a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v76+B8]");
			object obj39 = 0;
			source = (IEnumerable<object>)obj39;
			obj11 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v42+E4]");
			bool flag11 = (nint)0 == 0;
			obj13 = obj11;
			obj7 = obj4;
			enumerable = (IEnumerable<object>)obj39;
			if (!flag11)
			{
				goto IL_00fe;
			}
			goto IL_051a;
			IL_051a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj7;
			obj4 = obj7;
			source = enumerable;
			goto IL_00fe;
		}

		internal unsafe <>f__AnonymousType5<string, string> <CleanLocalChats>b__69_1(FriendProfile profile)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected O, but got Unknown
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Expected I4, but got Unknown
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected I4, but got Unknown
			if (profile != null)
			{
				object obj = ", stale={0}" + 2920;
				object obj2 = ", stale={0}" + 2488;
				object obj3 = ", stale={0}" + 2176;
				object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 112;
				object obj5 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 2656;
				int num = profile + 16;
				string text = ((int*)num)->ToString();
				string text2 = (string)obj + text + (string)obj2;
				int num2 = profile + 16;
				string text3 = ((int*)num2)->ToString();
				string text4 = (string)obj + text3 + (string)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3FDA450");
				<>f__AnonymousType5<string, string> result = default(<>f__AnonymousType5<string, string>);
				return result;
			}
			return (<>f__AnonymousType5<string, string>)(object)new NullReferenceException();
		}

		internal unsafe int <GetMessages>b__70_0(PrivateMessageModel data, PrivateMessageModel other)
		{
			//IL_0071: Expected I4, but got O
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected I8, but got Unknown
			if (data != null && other != null)
			{
				long num = data + 32;
				return ((long*)num)->CompareTo(other.timestamp);
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass35_0
	{
		public PrivateMessageModel messageData;

		internal bool <OnPrivateMessage>b__0(FriendProfile friend)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (friend != null)
			{
				PrivateMessageModel privateMessageModel = messageData;
				if (messageData != null)
				{
					object obj = friend.UserID - privateMessageModel.sender;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass40_0
	{
		public ConnectionStatusUpdate model;

		internal bool <ConnectionStatusUpdate>b__0(FriendProfile f)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (f != null)
			{
				ConnectionStatusUpdate connectionStatusUpdate = model;
				if (model != null)
				{
					object obj = f.UserID - connectionStatusUpdate.<UserId>k__BackingField;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass41_0
	{
		public List<int> friendIds;

		internal bool <InitializeOnlineFriends>b__0(FriendProfile f)
		{
			//IL_0050: Expected I4, but got O
			if (f != null && friendIds != null)
			{
				return friendIds.Contains(f.UserID);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass42_0
	{
		public int friendId;

		internal bool <OnRemoveFriend>b__0(FriendProfile f)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (f != null)
			{
				object obj = f.UserID - friendId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass43_0
	{
		public Friend friend;

		internal bool <OnFriendStatusUpdate>b__0(FriendProfile f)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (f != null)
			{
				Friend friend = this.friend;
				if (this.friend != null)
				{
					object obj = f.UserID - friend.id;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass44_0
	{
		public PlayerProfileModel profileModel;

		internal bool <OnPlayerProfileLoaded>b__0(FriendProfile profile)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I8
			if (profile != null)
			{
				PlayerProfileModel playerProfileModel = profileModel;
				if (profileModel != null)
				{
					object obj = playerProfileModel.<userDbId>k__BackingField - profile.UserID;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass45_0
	{
		public int otherPlayer;

		public Action<KammelnaResponseModel<bool>> callback;

		internal void <UpdateListAfter>b__0(KammelnaResponseModel<bool> response)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			//IL_0133: Expected O, but got I
			//IL_0143: Expected O, but got I
			//IL_0153: Expected O, but got I
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_006a: Expected O, but got I
			//IL_00a5: Expected O, but got I
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Expected O, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			if (otherPlayer != 0)
			{
				object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v7+B8]");
				object obj3 = 0;
				object obj4 = obj3;
				object obj5 = typeof(System.IOAsyncCallback) + 1216;
				object obj6 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v11+12E]");
				object obj7 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v11+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00e6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v11+B0]");
				object obj8 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X10_v6-8]");
					if (0 == (nint)obj5)
					{
						break;
					}
					obj8 += 16;
					obj7--;
					if ((nint)obj7 != 1)
					{
						continue;
					}
					goto IL_00e6;
				}
				object obj9 = obj8 + 5;
				object obj10 = obj6 + obj9;
				object obj11 = obj10 + 312;
				goto IL_01a1;
			}
			goto IL_01b0;
			IL_01a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v205 @ X0_v5] (should have been resolved before IL gen)");
			goto IL_01b0;
			IL_01b0:
			Action<KammelnaResponseModel<bool>> action = callback;
			if (callback != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v4 (System.Action`1<KammelnaResponseModel`1<System.Boolean>>)+18]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v4 (System.Action`1<KammelnaResponseModel`1<System.Boolean>>)+40]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v4 (System.Action`1<KammelnaResponseModel`1<System.Boolean>>)+28]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v109 @ X3_v1 (should have been resolved before IL gen)");
			}
			return;
			IL_00e6:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			goto IL_01a1;
		}
	}

	private sealed class <>c__DisplayClass46_0
	{
		public Action complete;

		internal void <UpdateFriendsList>b__0(KammelnaResponseModel<List<Friend>> response)
		{
			//IL_0011: Expected O, but got I
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Expected O, but got Unknown
			//IL_0289: Expected O, but got I4
			//IL_0574: Expected O, but got I
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_02c4: Expected O, but got I
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Expected O, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected O, but got Unknown
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Expected O, but got Unknown
			//IL_0135: Expected O, but got I4
			//IL_051b: Expected O, but got I
			//IL_0527: Expected O, but got I
			//IL_0556: Expected O, but got I4
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e1: Expected O, but got Unknown
			//IL_040b: Expected O, but got I4
			//IL_0445: Unknown result type (might be due to invalid IL or missing references)
			//IL_044a: Expected O, but got Unknown
			//IL_0184: Expected O, but got I4
			//IL_0465: Expected O, but got I
			//IL_0476: Expected I, but got O
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected O, but got Unknown
			//IL_0491: Expected O, but got I
			//IL_04a2: Expected I, but got O
			//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b6: Expected O, but got Unknown
			//IL_04e0: Expected O, but got I4
			//IL_02e7: Expected O, but got I
			//IL_02f7: Expected O, but got I
			//IL_0319: Expected O, but got I4
			//IL_038a: Expected O, but got I
			//IL_01fb: Expected O, but got I
			//IL_020b: Expected O, but got I
			//IL_022d: Expected O, but got I4
			//IL_0349: Expected O, but got I4
			//IL_0588: Unknown result type (might be due to invalid IL or missing references)
			//IL_058d: Expected O, but got Unknown
			//IL_05a3: Expected O, but got I
			//IL_05b4: Expected I, but got O
			//IL_05d2: Expected O, but got I
			//IL_0379: Expected O, but got I
			object obj = (nint)0 + (nint)672;
			object obj3 = default(object);
			IEnumerable<FriendProfile> onlineFriendsList;
			object obj15;
			object obj17;
			Func<object, int> selector;
			object obj7;
			List<int> list3;
			if (((KammelnaResponseModel<object>)(object)response).Succeeded)
			{
				object obj2 = typeof(DebugUI.BitField) + 3336;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj3..ctor();
				object obj4 = obj3 + 40;
				obj4 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj5 = obj3 + 16;
				obj5 = response.<Model>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj6 = typeof(List<AdaptivePerformanceScaler>) + 1800;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				List<int> list = default(List<int>);
				list..ctor();
				obj7 = obj3 + 32;
				obj7 = list;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj8 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
				object obj9 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v25+E4]");
				bool flag = (nint)0 == 0;
				object obj10 = !flag;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj8;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v25+B8]");
				object list2 = 0;
				object obj11 = (nint)0 + (nint)2568;
				list3 = (List<int>)obj11;
				bool flag2 = ArraysExtensions.IsNullOrEmpty((IEnumerable<object>)list2);
				bool flag3 = !flag2;
				object obj12 = !flag3;
				if (obj12 == null)
				{
					object obj13 = obj8;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v43+E4]");
					bool flag4 = (nint)0 == 0;
					object obj14 = !flag4;
					if (obj14 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					onlineFriendsList = OnlineFriendsList;
					obj15 = typeof(DebugUI.BitField) + 3264;
					object obj16 = obj15;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v52+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v52+B8]");
						obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v37+58]");
						selector = (Func<object, int>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v37+58]");
						bool flag5 = (nint)0 == 0;
						object obj18 = !flag5;
						if (obj18 == null)
						{
							goto IL_0327;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj16 = obj15;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v52+B8]");
						obj17 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v37+58]");
						selector = (Func<object, int>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v37+58]");
						bool flag6 = (nint)0 == 0;
						object obj19 = !flag6;
						if (obj19 == null)
						{
							goto IL_0327;
						}
					}
					goto IL_037e;
				}
				goto IL_03cd;
			}
			Actions.SafeInvoke(complete);
			object obj20 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v8+E4]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj21 = obj20;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v8+B8]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v7+8]");
			((OneShotEvent)0).IsReady = true;
			return;
			IL_0327:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v52+E4]");
			bool flag8 = (nint)0 == 0;
			object obj24 = !flag8;
			if (obj24 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj25 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X8_v43+B8]");
				obj17 = 0;
			}
			object obj26 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj27 = (nint)0 + (nint)960;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj17, (IntPtr)obj27);
			object obj28 = obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v42+B8]");
			object obj29 = (nint)0 + (nint)88;
			obj29 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
			goto IL_037e;
			IL_03cd:
			object obj30 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj31 = obj30;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v29+E4]");
			bool flag9 = (nint)0 == 0;
			object obj32 = !flag9;
			if (obj32 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Games currentGame = Preferences.CurrentGame;
			object obj33 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj34 = (nint)0 + (nint)1112;
			Action action = default(Action);
			action..ctor(obj3, (IntPtr)obj34);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj35 = (nint)0 + (nint)1120;
			Action action2 = default(Action);
			action2..ctor(obj3, (IntPtr)obj35);
			object obj36 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1168;
			object obj37 = obj36;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v37+E4]");
			bool flag10 = (nint)0 == 0;
			object obj38 = !flag10;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			KUtil.SwitchToBackground(action, action2);
			return;
			IL_037e:
			object obj39 = (nint)0 + (nint)3272;
			IEnumerable<int> source = Enumerable.Select(onlineFriendsList, selector);
			List<int> list4 = Enumerable.ToList(source);
			obj7 = list4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			list3 = list4;
			goto IL_03cd;
		}
	}

	private sealed class <>c__DisplayClass46_1
	{
		public List<Friend> friends;

		public Games currentGame;

		public List<int> onlineFriendsIDs;

		public <>c__DisplayClass46_0 CS$<>8__locals1;

		public Func<Friend, FriendProfile> <>9__4;

		internal void <UpdateFriendsList>b__2()
		{
			//IL_00e9: Expected O, but got I
			//IL_00f5: Expected O, but got I
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Expected O, but got Unknown
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected O, but got Unknown
			//IL_0136: Expected O, but got I4
			//IL_0078: Expected O, but got I
			//IL_00b8: Expected O, but got I4
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_002f: Expected O, but got I
			//IL_003d: Expected I, but got O
			object obj = (nint)0 + (nint)3232;
			object obj2 = (nint)0 + (nint)2080;
			object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj4 = this + 48;
			Func<object, object> selector = (Func<object, object>)obj4;
			bool flag = obj4 == null;
			object obj5 = !flag;
			if (obj5 == null)
			{
				object obj6 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1128;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj7 = (nint)0 + (nint)1128;
				Func<object, object> func = default(Func<object, object>);
				func..ctor((object)this, (IntPtr)obj7);
				<>9__4 = (Func<Friend, FriendProfile>)func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X22_v2-20]");
			IEnumerable<object> source = Enumerable.Select((IEnumerable<object>)0, selector);
			List<object> list = Enumerable.ToList(source);
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj9 = !flag2;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj3;
			}
			object obj10 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal FriendProfile <UpdateFriendsList>b__4(Friend f)
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00e1: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61D9]");
			object obj3 = (nint)0 & (nint)1;
			Games games;
			Games games2;
			if (obj3 != null)
			{
				games = currentGame;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				games2 = currentGame;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				games = currentGame;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v1+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				games2 = currentGame;
				if (obj5 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return LoadProfile(f, games2);
			IL_0091:
			return LoadProfile(f, games);
		}

		internal void <UpdateFriendsList>b__3()
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Expected O, but got Unknown
			//IL_01c4: Expected O, but got I4
			//IL_00b1: Expected O, but got I
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_027e: Expected O, but got I
			//IL_028e: Expected O, but got I
			//IL_02b0: Expected O, but got I4
			//IL_0204: Expected O, but got I
			//IL_0236: Expected O, but got I4
			//IL_016d: Expected O, but got I4
			//IL_010e: Expected O, but got I
			//IL_011e: Expected O, but got I
			//IL_0357: Expected O, but got I
			//IL_02f0: Expected O, but got I4
			//IL_0427: Expected O, but got I
			//IL_0437: Expected O, but got I
			//IL_0459: Expected O, but got I4
			//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0703: Expected O, but got Unknown
			//IL_0719: Expected O, but got I
			//IL_072a: Expected I, but got O
			//IL_0748: Expected O, but got I
			//IL_03f2: Expected O, but got I4
			//IL_03a1: Expected O, but got I
			//IL_03b1: Expected O, but got I
			//IL_032e: Expected O, but got I4
			//IL_0320: Expected O, but got I
			//IL_04e0: Expected O, but got I
			//IL_0519: Expected O, but got I4
			//IL_0489: Expected O, but got I4
			//IL_076e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0773: Expected O, but got Unknown
			//IL_0789: Expected O, but got I
			//IL_079a: Expected I, but got O
			//IL_07b8: Expected O, but got I
			//IL_04c7: Expected O, but got I4
			//IL_04b9: Expected O, but got I
			//IL_0582: Expected O, but got I4
			//IL_07db: Expected O, but got I
			//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ef: Expected O, but got Unknown
			//IL_07ff: Expected O, but got I
			//IL_080f: Expected O, but got I
			//IL_0831: Expected O, but got I4
			//IL_0639: Expected O, but got I4
			//IL_05c9: Expected O, but got I4
			//IL_06ac: Expected O, but got I4
			//IL_084e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0853: Expected O, but got Unknown
			//IL_0869: Expected O, but got I
			//IL_087a: Expected I, but got O
			//IL_0898: Expected O, but got I
			//IL_08b3: Expected O, but got I4
			//IL_08d0: Expected O, but got I
			//IL_05f9: Expected O, but got I
			//IL_06e7: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61DA]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v101+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v101+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v60+B8]");
			object obj10 = 0;
			List<object> list = (List<object>)obj10;
			object obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v47+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			obj4 = obj7;
			object obj13 = obj11;
			List<object> list2 = (List<object>)obj10;
			if (obj12 != null)
			{
				goto IL_00fe;
			}
			goto IL_025c;
			IL_03d6:
			bool flag4 = onlineFriendsIDs == null;
			object obj14 = !flag4;
			if (obj14 != null)
			{
				goto IL_04d4;
			}
			goto IL_06e8;
			IL_034b:
			object obj15 = (nint)0 + (nint)2312;
			Action<object> action;
			list.ForEach(action);
			object obj16 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v36+E4]");
			object obj17;
			Action<int> action2;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v36+B8]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v27+68]");
				action2 = (Action<int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v27+68]");
				if ((nint)0 != 0)
				{
					goto IL_03d6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj16 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v36+B8]");
				obj17 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v27+68]");
				action2 = (Action<int>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X8_v27+68]");
				bool flag5 = (nint)0 == 0;
				object obj18 = !flag5;
				if (obj18 != null)
				{
					goto IL_03d6;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v258 @ X0_v36+E4]");
			bool flag6 = (nint)0 == 0;
			object obj19 = !flag6;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj20 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v33+B8]");
				obj17 = 0;
			}
			object obj21 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj22 = (nint)0 + (nint)976;
			Action<int> action3 = default(Action<int>);
			action3..ctor(obj17, (IntPtr)obj22);
			object obj23 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X8_v32+B8]");
			object obj24 = (nint)0 + (nint)104;
			obj24 = action3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj25 = 0;
			action2 = action3;
			goto IL_04d4;
			IL_0153:
			bool flag7 = list == null;
			object obj26 = !flag7;
			if (obj26 != null)
			{
				goto IL_034b;
			}
			goto IL_06e8;
			IL_00a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v101+B8]");
			object obj27 = 0;
			list = (List<object>)obj27;
			obj11 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v47+E4]");
			bool flag8 = (nint)0 == 0;
			obj13 = obj11;
			obj7 = obj4;
			list2 = (List<object>)obj27;
			if (!flag8)
			{
				goto IL_00fe;
			}
			goto IL_025c;
			IL_025c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v47+B8]");
			object obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v39+60]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v39+60]");
			bool flag9 = (nint)0 == 0;
			object obj29 = !flag9;
			obj4 = obj7;
			list = list2;
			if (obj29 != null)
			{
				goto IL_0153;
			}
			goto IL_02ce;
			IL_00fe:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v47+B8]");
			obj28 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v39+60]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v39+60]");
			bool flag10 = (nint)0 == 0;
			obj7 = obj4;
			list2 = list;
			if (!flag10)
			{
				goto IL_0153;
			}
			goto IL_02ce;
			IL_02ce:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v47+E4]");
			bool flag11 = (nint)0 == 0;
			object obj30 = !flag11;
			if (obj30 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj31 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v45+B8]");
				obj28 = 0;
			}
			object obj32 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj33 = (nint)0 + (nint)968;
			Action<object> action4 = default(Action<object>);
			action4..ctor(obj28, (IntPtr)obj33);
			object obj34 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v44+B8]");
			object obj35 = (nint)0 + (nint)96;
			obj35 = action4;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj25 = 0;
			action = action4;
			obj4 = obj7;
			list = list2;
			goto IL_034b;
			IL_06e8:
			throw new NullReferenceException();
			IL_04d4:
			object obj36 = (nint)0 + (nint)1392;
			onlineFriendsIDs.ForEach(action2);
			object obj37 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v9+E4]");
			bool flag12 = (nint)0 == 0;
			object obj38 = !flag12;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CleanLocalChats();
			GetUnreadMessages();
			UpdateOnlineFriendCount();
			IEnumerable<FriendProfile> receivedRequests = ReceivedRequests;
			object obj39 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v12+E4]");
			bool flag13 = (nint)0 == 0;
			object obj40 = !flag13;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj39 = obj4;
			}
			object obj41 = (nint)0 + (nint)3536;
			object obj42 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v12+B8]");
			object obj43 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v18+70]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v353 @ X8_v18+70]");
			bool flag14 = (nint)0 == 0;
			object obj44 = !flag14;
			if (obj44 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X0_v12+E4]");
				bool flag15 = (nint)0 == 0;
				object obj45 = !flag15;
				if (obj45 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj46 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v24+B8]");
					obj43 = 0;
				}
				object obj47 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj48 = (nint)0 + (nint)984;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj43, (IntPtr)obj48);
				object obj49 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v23+B8]");
				object obj50 = (nint)0 + (nint)112;
				obj50 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				obj25 = 0;
				predicate = func;
			}
			int newCount = Enumerable.Count(receivedRequests, predicate);
			object obj51 = obj42;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v16+E4]");
			bool flag16 = (nint)0 == 0;
			object obj52 = !flag16;
			if (obj52 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CounterBubbleManager.UpdateCounter(CounterBubbleType.FriendRequest, newCount);
			<>c__DisplayClass46_0 cS$<>8__locals = CS$<>8__locals1;
			Actions.SafeInvoke(cS$<>8__locals.complete);
			object obj53 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v21+E4]");
			bool flag17 = (nint)0 == 0;
			object obj54 = !flag17;
			if (obj54 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj53 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v377 @ X0_v21+B8]");
			object obj55 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v17+8]");
			((OneShotEvent)0).IsReady = true;
		}
	}

	private sealed class <>c__DisplayClass46_2
	{
		public int fID;

		internal bool <UpdateFriendsList>b__8(FriendProfile f)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (f != null)
			{
				object obj = f.UserID - fID;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass47_0
	{
		public int friendId;

		internal bool <GetUnreadMessages>b__5(FriendProfile f)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (f != null)
			{
				object obj = f.UserID - friendId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal bool <GetUnreadMessages>b__6(PrivateMessageModel m)
		{
			//IL_007b: Expected I4, but got O
			//IL_0059: Expected O, but got I4
			if (m != null)
			{
				if (m.isRead)
				{
					return false;
				}
				object obj = m.sender - friendId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass48_0
	{
		public int userId;

		internal bool <HandleSendMessage>b__0(FriendProfile friend)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (friend != null)
			{
				object obj = friend.UserID - userId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass50_0
	{
		public int userId;

		internal void <SendAddRequest>b__0(Action<KammelnaResponseModel<bool>> updateList)
		{
			//IL_000f: Expected I8, but got I4
			KammelnaRequests.SendFriendRequest(userId, updateList);
		}
	}

	private sealed class <>c__DisplayClass51_0
	{
		public int userId;

		internal void <ForceAddFriend>b__0(Action<KammelnaResponseModel<bool>> updateList)
		{
			//IL_000f: Expected I8, but got I4
			KammelnaRequests.ForceFriendRequest(userId, updateList);
		}
	}

	private sealed class <>c__DisplayClass52_0
	{
		public int userId;

		internal void <RemoveFriend>b__0(Action<KammelnaResponseModel<bool>> updateList)
		{
			//IL_000f: Expected I8, but got I4
			KammelnaRequests.RemoveFriend(userId, updateList);
		}
	}

	private sealed class <>c__DisplayClass53_0
	{
		public int userId;

		internal void <AcceptRequest>b__0(Action<KammelnaResponseModel<bool>> updateList)
		{
			//IL_000f: Expected I8, but got I4
			KammelnaRequests.AcceptFriendRequest(userId, updateList);
		}
	}

	private sealed class <>c__DisplayClass54_0
	{
		public int userId;

		public Action<KammelnaResponseModel<bool>> callback;

		internal void <BlockUser>b__0(Action<KammelnaResponseModel<bool>> updateList)
		{
			//IL_0014: Expected I8, but got I4
			KammelnaRequests.BlockUser(userId, updateList);
		}

		internal void <BlockUser>b__1(KammelnaResponseModel<bool> response)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_005c: Expected O, but got I4
			//IL_007a: Expected O, but got I
			//IL_0091: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+18]");
			Actions.SafeInvoke((Action<int>)0, userId);
			Actions.SafeInvoke((Action<object>)callback, response);
		}
	}

	private sealed class <>c__DisplayClass55_0
	{
		public int userId;

		internal void <UnblockUser>b__0(Action<KammelnaResponseModel<bool>> updateList)
		{
			//IL_0014: Expected I8, but got I4
			KammelnaRequests.UnblockUser(userId, updateList);
		}
	}

	private sealed class <>c__DisplayClass56_0
	{
		public long userId;

		internal bool <IsFriend>b__0(FriendProfile friend)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I8
			if (friend != null)
			{
				object obj = userId - friend.UserID;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass57_0
	{
		public long userId;

		internal bool <IsRequestedFriendship>b__0(FriendProfile friend)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I8
			if (friend != null)
			{
				object obj = userId - friend.UserID;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass58_0
	{
		public long userId;

		internal bool <IsReceivedFriendship>b__0(FriendProfile friend)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I8
			if (friend != null)
			{
				object obj = userId - friend.UserID;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass59_0
	{
		public long userId;

		internal bool <IsBlocked>b__0(FriendProfile friend)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I8
			if (friend != null)
			{
				object obj = userId - friend.UserID;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass63_0
	{
		public int userId;

		internal bool <GetProfile>b__0(FriendProfile friend)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I4
			if (friend != null)
			{
				object obj = friend.UserID - userId;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass65_0
	{
		public Friend friend;

		internal bool <GetCachedProfile>b__0(FriendProfile f)
		{
			//IL_007f: Expected I4, but got O
			//IL_005d: Expected O, but got I4
			if (f != null)
			{
				Friend friend = this.friend;
				if (this.friend != null)
				{
					object obj = f.UserID - friend.id;
					return obj == null;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass69_0
	{
		public string path;

		internal bool <CleanLocalChats>b__2(<>f__AnonymousType5<string, string> chat)
		{
			//IL_00b3: Expected I4, but got O
			if (chat != null && path != null)
			{
				if (path.EndsWith(chat.<fileName>i__Field, StringComparison.Ordinal))
				{
					return true;
				}
				if (path != null)
				{
					return path.EndsWith(chat.<archiveName>i__Field, StringComparison.Ordinal);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass70_0
	{
		public FriendProfile friendProfile;

		public ChatMessageData hisMessage;

		public ChatMessageData myMessage;

		internal ChatMessageData <GetMessages>b__1(PrivateMessageModel message)
		{
			//IL_00d9: Expected O, but got I4
			ChatMessageData chatMessageData;
			if (message != null)
			{
				FriendProfile friendProfile = this.friendProfile;
				if (this.friendProfile != null)
				{
					if (message.sender == friendProfile.UserID)
					{
						chatMessageData = hisMessage;
						if (hisMessage != null)
						{
							goto IL_0098;
						}
					}
					else
					{
						chatMessageData = myMessage;
						bool flag = myMessage == null;
						object obj = !flag;
						if (obj != null)
						{
							goto IL_0098;
						}
					}
				}
			}
			return (ChatMessageData)(object)new NullReferenceException();
			IL_0098:
			return chatMessageData.Copy(message.message);
		}
	}

	private const int MaximumMessages = 200;

	public static List<FriendProfile> AllFriendsList;

	private static readonly OneShotEvent readyStatus;

	private static string currentUser;

	private static int <ActiveChatUser>k__BackingField;

	private static string ChatsDirectory
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected O, but got Unknown
			//IL_00cd: Expected O, but got I4
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			//IL_006a: Expected O, but got I4
			//IL_00eb: Expected O, but got I
			//IL_0104: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj5 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 3096;
			string cachePath = Config.CachePath;
			object obj6 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v5+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v6+20]");
			return cachePath + (string)obj5 + (string)0;
		}
	}

	public static IEnumerable<FriendProfile> FriendsList
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_01bb: Expected O, but got I4
			//IL_00b1: Expected O, but got I
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0271: Expected O, but got I
			//IL_0281: Expected O, but got I
			//IL_0291: Expected O, but got I
			//IL_02b3: Expected O, but got I4
			//IL_01fb: Expected O, but got I
			//IL_022d: Expected O, but got I4
			//IL_010a: Expected O, but got I
			//IL_011a: Expected O, but got I
			//IL_012a: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_02f3: Expected O, but got I4
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Expected O, but got Unknown
			//IL_0368: Expected O, but got I
			//IL_0379: Expected I, but got O
			//IL_0397: Expected O, but got I
			//IL_0323: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61A1]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+B8]");
			object obj10 = 0;
			IEnumerable<object> enumerable = (IEnumerable<object>)obj10;
			object obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			obj4 = obj7;
			object obj13 = obj11;
			IEnumerable<object> enumerable2 = (IEnumerable<object>)obj10;
			if (obj12 != null)
			{
				goto IL_00fe;
			}
			goto IL_0253;
			IL_02d1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			object obj16;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v10+B8]");
				obj16 = 0;
			}
			object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)1000;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj16, (IntPtr)obj18);
			object obj19 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v9+B8]");
			object obj20 = (nint)0 + (nint)8;
			obj20 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj22;
			object obj21 = obj22;
			enumerable = enumerable2;
			Func<object, bool> predicate = func;
			goto IL_0328;
			IL_0328:
			return (IEnumerable<FriendProfile>)Enumerable.Where(enumerable, predicate);
			IL_00fe:
			obj21 = (nint)0 + (nint)3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+8]");
			bool flag5 = (nint)0 == 0;
			object obj23 = !flag5;
			if (obj23 == null)
			{
				obj22 = obj21;
				obj7 = obj4;
				enumerable2 = enumerable;
				goto IL_02d1;
			}
			goto IL_0328;
			IL_00a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+B8]");
			object obj24 = 0;
			enumerable = (IEnumerable<object>)obj24;
			obj11 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag6 = (nint)0 == 0;
			obj13 = obj11;
			obj7 = obj4;
			enumerable2 = (IEnumerable<object>)obj24;
			if (!flag6)
			{
				goto IL_00fe;
			}
			goto IL_0253;
			IL_0253:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj7;
			obj22 = (nint)0 + (nint)3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+8]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+8]");
			bool flag7 = (nint)0 == 0;
			object obj25 = !flag7;
			obj21 = obj22;
			enumerable = enumerable2;
			if (obj25 == null)
			{
				goto IL_02d1;
			}
			goto IL_0328;
		}
	}

	public static IEnumerable<FriendProfile> OnlineFriendsList
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Expected O, but got Unknown
			//IL_01b4: Expected O, but got I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0260: Expected O, but got I
			//IL_0270: Expected O, but got I
			//IL_0280: Expected O, but got I
			//IL_02a2: Expected O, but got I4
			//IL_0103: Expected O, but got I
			//IL_0113: Expected O, but got I
			//IL_0123: Expected O, but got I
			//IL_0145: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_02e2: Expected O, but got I4
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Expected O, but got Unknown
			//IL_0357: Expected O, but got I
			//IL_0368: Expected I, but got O
			//IL_0386: Expected O, but got I
			//IL_0312: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61A2]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			IEnumerable<FriendProfile> friendsList = FriendsList;
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			obj4 = obj7;
			IEnumerable<FriendProfile> enumerable = friendsList;
			object obj11 = obj9;
			IEnumerable<FriendProfile> enumerable2 = friendsList;
			if (obj10 != null)
			{
				goto IL_00f7;
			}
			goto IL_0242;
			IL_02c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			object obj14;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v10+B8]");
				obj14 = 0;
			}
			object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)1016;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj14, (IntPtr)obj16);
			object obj17 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v9+B8]");
			object obj18 = (nint)0 + (nint)16;
			obj18 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj20;
			object obj19 = obj20;
			enumerable = enumerable2;
			Func<object, bool> predicate = func;
			goto IL_0317;
			IL_0317:
			return (IEnumerable<FriendProfile>)Enumerable.Where(enumerable, predicate);
			IL_00f7:
			obj19 = (nint)0 + (nint)3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+10]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			if (obj21 == null)
			{
				obj20 = obj19;
				obj7 = obj4;
				enumerable2 = enumerable;
				goto IL_02c0;
			}
			goto IL_0317;
			IL_00a1:
			IEnumerable<FriendProfile> friendsList2 = FriendsList;
			obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
			bool flag6 = (nint)0 == 0;
			enumerable = friendsList2;
			obj11 = obj9;
			obj7 = obj4;
			enumerable2 = friendsList2;
			if (!flag6)
			{
				goto IL_00f7;
			}
			goto IL_0242;
			IL_0242:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj7;
			obj20 = (nint)0 + (nint)3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+10]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+10]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			obj19 = obj20;
			enumerable = enumerable2;
			if (obj22 == null)
			{
				goto IL_02c0;
			}
			goto IL_0317;
		}
	}

	public static IEnumerable<FriendProfile> OfflineFriendsList
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Expected O, but got Unknown
			//IL_01b4: Expected O, but got I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0260: Expected O, but got I
			//IL_0270: Expected O, but got I
			//IL_0280: Expected O, but got I
			//IL_02a2: Expected O, but got I4
			//IL_0103: Expected O, but got I
			//IL_0113: Expected O, but got I
			//IL_0123: Expected O, but got I
			//IL_0145: Expected O, but got I4
			//IL_0214: Expected O, but got I4
			//IL_02e2: Expected O, but got I4
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Expected O, but got Unknown
			//IL_0357: Expected O, but got I
			//IL_0368: Expected I, but got O
			//IL_0386: Expected O, but got I
			//IL_0312: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61A3]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			IEnumerable<FriendProfile> friendsList = FriendsList;
			object obj9 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			obj4 = obj7;
			IEnumerable<FriendProfile> enumerable = friendsList;
			object obj11 = obj9;
			IEnumerable<FriendProfile> enumerable2 = friendsList;
			if (obj10 != null)
			{
				goto IL_00f7;
			}
			goto IL_0242;
			IL_02c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			object obj14;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj13 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X8_v10+B8]");
				obj14 = 0;
			}
			object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj16 = (nint)0 + (nint)1008;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj14, (IntPtr)obj16);
			object obj17 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v9+B8]");
			object obj18 = (nint)0 + (nint)24;
			obj18 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj20;
			object obj19 = obj20;
			enumerable = enumerable2;
			Func<object, bool> predicate = func;
			goto IL_0317;
			IL_0317:
			return (IEnumerable<FriendProfile>)Enumerable.Where(enumerable, predicate);
			IL_00f7:
			obj19 = (nint)0 + (nint)3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+18]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+18]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			if (obj21 == null)
			{
				obj20 = obj19;
				obj7 = obj4;
				enumerable2 = enumerable;
				goto IL_02c0;
			}
			goto IL_0317;
			IL_00a1:
			IEnumerable<FriendProfile> friendsList2 = FriendsList;
			obj9 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+E4]");
			bool flag6 = (nint)0 == 0;
			enumerable = friendsList2;
			obj11 = obj9;
			obj7 = obj4;
			enumerable2 = friendsList2;
			if (!flag6)
			{
				goto IL_00f7;
			}
			goto IL_0242;
			IL_0242:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj7;
			obj20 = (nint)0 + (nint)3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v4+B8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+18]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+18]");
			bool flag7 = (nint)0 == 0;
			object obj22 = !flag7;
			obj19 = obj20;
			enumerable = enumerable2;
			if (obj22 == null)
			{
				goto IL_02c0;
			}
			goto IL_0317;
		}
	}

	public static IEnumerable<FriendProfile> ReceivedRequests
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_01bb: Expected O, but got I4
			//IL_00b1: Expected O, but got I
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0271: Expected O, but got I
			//IL_0281: Expected O, but got I
			//IL_0291: Expected O, but got I
			//IL_02b3: Expected O, but got I4
			//IL_01fb: Expected O, but got I
			//IL_022d: Expected O, but got I4
			//IL_010a: Expected O, but got I
			//IL_011a: Expected O, but got I
			//IL_012a: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_02f3: Expected O, but got I4
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Expected O, but got Unknown
			//IL_0368: Expected O, but got I
			//IL_0379: Expected I, but got O
			//IL_0397: Expected O, but got I
			//IL_0323: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61A4]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+B8]");
			object obj10 = 0;
			IEnumerable<object> enumerable = (IEnumerable<object>)obj10;
			object obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			obj4 = obj7;
			object obj13 = obj11;
			IEnumerable<object> enumerable2 = (IEnumerable<object>)obj10;
			if (obj12 != null)
			{
				goto IL_00fe;
			}
			goto IL_0253;
			IL_02d1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			object obj16;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v10+B8]");
				obj16 = 0;
			}
			object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)1024;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj16, (IntPtr)obj18);
			object obj19 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v9+B8]");
			object obj20 = (nint)0 + (nint)32;
			obj20 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj22;
			object obj21 = obj22;
			enumerable = enumerable2;
			Func<object, bool> predicate = func;
			goto IL_0328;
			IL_0328:
			return (IEnumerable<FriendProfile>)Enumerable.Where(enumerable, predicate);
			IL_00fe:
			obj21 = (nint)0 + (nint)3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+20]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+20]");
			bool flag5 = (nint)0 == 0;
			object obj23 = !flag5;
			if (obj23 == null)
			{
				obj22 = obj21;
				obj7 = obj4;
				enumerable2 = enumerable;
				goto IL_02d1;
			}
			goto IL_0328;
			IL_00a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+B8]");
			object obj24 = 0;
			enumerable = (IEnumerable<object>)obj24;
			obj11 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag6 = (nint)0 == 0;
			obj13 = obj11;
			obj7 = obj4;
			enumerable2 = (IEnumerable<object>)obj24;
			if (!flag6)
			{
				goto IL_00fe;
			}
			goto IL_0253;
			IL_0253:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj7;
			obj22 = (nint)0 + (nint)3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+20]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+20]");
			bool flag7 = (nint)0 == 0;
			object obj25 = !flag7;
			obj21 = obj22;
			enumerable = enumerable2;
			if (obj25 == null)
			{
				goto IL_02d1;
			}
			goto IL_0328;
		}
	}

	public static IEnumerable<FriendProfile> SentRequests
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_01bb: Expected O, but got I4
			//IL_00b1: Expected O, but got I
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0271: Expected O, but got I
			//IL_0281: Expected O, but got I
			//IL_0291: Expected O, but got I
			//IL_02b3: Expected O, but got I4
			//IL_01fb: Expected O, but got I
			//IL_022d: Expected O, but got I4
			//IL_010a: Expected O, but got I
			//IL_011a: Expected O, but got I
			//IL_012a: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_02f3: Expected O, but got I4
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Expected O, but got Unknown
			//IL_0368: Expected O, but got I
			//IL_0379: Expected I, but got O
			//IL_0397: Expected O, but got I
			//IL_0323: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61A5]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+B8]");
			object obj10 = 0;
			IEnumerable<object> enumerable = (IEnumerable<object>)obj10;
			object obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			obj4 = obj7;
			object obj13 = obj11;
			IEnumerable<object> enumerable2 = (IEnumerable<object>)obj10;
			if (obj12 != null)
			{
				goto IL_00fe;
			}
			goto IL_0253;
			IL_02d1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			object obj16;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v10+B8]");
				obj16 = 0;
			}
			object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)1032;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj16, (IntPtr)obj18);
			object obj19 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v9+B8]");
			object obj20 = (nint)0 + (nint)40;
			obj20 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj22;
			object obj21 = obj22;
			enumerable = enumerable2;
			Func<object, bool> predicate = func;
			goto IL_0328;
			IL_0328:
			return (IEnumerable<FriendProfile>)Enumerable.Where(enumerable, predicate);
			IL_00fe:
			obj21 = (nint)0 + (nint)3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+28]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+28]");
			bool flag5 = (nint)0 == 0;
			object obj23 = !flag5;
			if (obj23 == null)
			{
				obj22 = obj21;
				obj7 = obj4;
				enumerable2 = enumerable;
				goto IL_02d1;
			}
			goto IL_0328;
			IL_00a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+B8]");
			object obj24 = 0;
			enumerable = (IEnumerable<object>)obj24;
			obj11 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag6 = (nint)0 == 0;
			obj13 = obj11;
			obj7 = obj4;
			enumerable2 = (IEnumerable<object>)obj24;
			if (!flag6)
			{
				goto IL_00fe;
			}
			goto IL_0253;
			IL_0253:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj7;
			obj22 = (nint)0 + (nint)3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+28]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+28]");
			bool flag7 = (nint)0 == 0;
			object obj25 = !flag7;
			obj21 = obj22;
			enumerable = enumerable2;
			if (obj25 == null)
			{
				goto IL_02d1;
			}
			goto IL_0328;
		}
	}

	public static IEnumerable<FriendProfile> BlockedList
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_01bb: Expected O, but got I4
			//IL_00b1: Expected O, but got I
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0271: Expected O, but got I
			//IL_0281: Expected O, but got I
			//IL_0291: Expected O, but got I
			//IL_02b3: Expected O, but got I4
			//IL_01fb: Expected O, but got I
			//IL_022d: Expected O, but got I4
			//IL_010a: Expected O, but got I
			//IL_011a: Expected O, but got I
			//IL_012a: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_02f3: Expected O, but got I4
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Expected O, but got Unknown
			//IL_0368: Expected O, but got I
			//IL_0379: Expected I, but got O
			//IL_0397: Expected O, but got I
			//IL_0323: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61A6]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+B8]");
			object obj10 = 0;
			IEnumerable<object> enumerable = (IEnumerable<object>)obj10;
			object obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			obj4 = obj7;
			object obj13 = obj11;
			IEnumerable<object> enumerable2 = (IEnumerable<object>)obj10;
			if (obj12 != null)
			{
				goto IL_00fe;
			}
			goto IL_0253;
			IL_02d1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			object obj16;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v10+B8]");
				obj16 = 0;
			}
			object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)992;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj16, (IntPtr)obj18);
			object obj19 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v9+B8]");
			object obj20 = (nint)0 + (nint)48;
			obj20 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj22;
			object obj21 = obj22;
			enumerable = enumerable2;
			Func<object, bool> predicate = func;
			goto IL_0328;
			IL_0328:
			return (IEnumerable<FriendProfile>)Enumerable.Where(enumerable, predicate);
			IL_00fe:
			obj21 = (nint)0 + (nint)3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+30]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+30]");
			bool flag5 = (nint)0 == 0;
			object obj23 = !flag5;
			if (obj23 == null)
			{
				obj22 = obj21;
				obj7 = obj4;
				enumerable2 = enumerable;
				goto IL_02d1;
			}
			goto IL_0328;
			IL_00a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+B8]");
			object obj24 = 0;
			enumerable = (IEnumerable<object>)obj24;
			obj11 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag6 = (nint)0 == 0;
			obj13 = obj11;
			obj7 = obj4;
			enumerable2 = (IEnumerable<object>)obj24;
			if (!flag6)
			{
				goto IL_00fe;
			}
			goto IL_0253;
			IL_0253:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj7;
			obj22 = (nint)0 + (nint)3432;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+30]");
			predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+30]");
			bool flag7 = (nint)0 == 0;
			object obj25 = !flag7;
			obj21 = obj22;
			enumerable = enumerable2;
			if (obj25 == null)
			{
				goto IL_02d1;
			}
			goto IL_0328;
		}
	}

	public static int UnreadMessagesCount
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Expected O, but got Unknown
			//IL_01bb: Expected O, but got I4
			//IL_00b1: Expected O, but got I
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0271: Expected O, but got I
			//IL_0281: Expected O, but got I
			//IL_0291: Expected O, but got I
			//IL_02b3: Expected O, but got I4
			//IL_01fb: Expected O, but got I
			//IL_022d: Expected O, but got I4
			//IL_010a: Expected O, but got I
			//IL_011a: Expected O, but got I
			//IL_012a: Expected O, but got I
			//IL_014c: Expected O, but got I4
			//IL_02f3: Expected O, but got I4
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Expected O, but got Unknown
			//IL_0368: Expected O, but got I
			//IL_0379: Expected I, but got O
			//IL_0397: Expected O, but got I
			//IL_0323: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61A7]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj7;
			if (obj3 != null)
			{
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag = (nint)0 == 0;
				object obj6 = obj5;
				obj7 = obj4;
				if (!flag)
				{
					goto IL_00a1;
				}
			}
			else
			{
				_ = 1;
				obj4 = typeof(DebugUI.BitField) + 3264;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+E4]");
				bool flag2 = (nint)0 == 0;
				object obj8 = !flag2;
				object obj6 = obj5;
				obj7 = obj4;
				if (obj8 != null)
				{
					goto IL_00a1;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+B8]");
			object obj10 = 0;
			IEnumerable<object> enumerable = (IEnumerable<object>)obj10;
			object obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj12 = !flag3;
			obj4 = obj7;
			object obj13 = obj11;
			IEnumerable<object> enumerable2 = (IEnumerable<object>)obj10;
			if (obj12 != null)
			{
				goto IL_00fe;
			}
			goto IL_0253;
			IL_02d1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag4 = (nint)0 == 0;
			object obj14 = !flag4;
			object obj16;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj7;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v10+B8]");
				obj16 = 0;
			}
			object obj17 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj18 = (nint)0 + (nint)1040;
			Func<object, int> func = default(Func<object, int>);
			func..ctor(obj16, (IntPtr)obj18);
			object obj19 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v9+B8]");
			object obj20 = (nint)0 + (nint)56;
			obj20 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj22;
			object obj21 = obj22;
			enumerable = enumerable2;
			Func<object, int> selector = func;
			goto IL_0328;
			IL_0328:
			return Enumerable.Sum(enumerable, selector);
			IL_00fe:
			obj21 = (nint)0 + (nint)712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+38]");
			selector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+38]");
			bool flag5 = (nint)0 == 0;
			object obj23 = !flag5;
			if (obj23 == null)
			{
				obj22 = obj21;
				obj7 = obj4;
				enumerable2 = enumerable;
				goto IL_02d1;
			}
			goto IL_0328;
			IL_00a1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v36+B8]");
			object obj24 = 0;
			enumerable = (IEnumerable<object>)obj24;
			obj11 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+E4]");
			bool flag6 = (nint)0 == 0;
			obj13 = obj11;
			obj7 = obj4;
			enumerable2 = (IEnumerable<object>)obj24;
			if (!flag6)
			{
				goto IL_00fe;
			}
			goto IL_0253;
			IL_0253:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj7;
			obj22 = (nint)0 + (nint)712;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v4+B8]");
			obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+38]");
			selector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v4+38]");
			bool flag7 = (nint)0 == 0;
			object obj25 = !flag7;
			obj21 = obj22;
			enumerable = enumerable2;
			if (obj25 == null)
			{
				goto IL_02d1;
			}
			goto IL_0328;
		}
	}

	public static int ActiveChatUser
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d2: Expected O, but got I4
			//IL_0095: Expected O, but got I
			//IL_010a: Expected O, but got I
			object obj = 152985600;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61AC]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = obj4;
				if (!flag)
				{
					goto IL_0085;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+E4]");
				bool flag2 = (nint)0 == 0;
				object obj6 = !flag2;
				object obj5 = obj4;
				if (obj6 != null)
				{
					goto IL_0085;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj7 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X0_v3+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v3+28]");
			return 0;
			IL_0085:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v9+B8]");
			object obj9 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v7+28]");
			return 0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00c2: Expected O, but got I4
			//IL_008c: Expected O, but got I
			//IL_00fa: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61AD]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v3+B8]");
			object obj7 = 0;
			return;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v8+B8]");
			object obj8 = 0;
		}
	}

	public static event Action OnFriendListUpdated
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0152: Expected O, but got I4
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Expected O, but got Unknown
			//IL_0184: Expected O, but got I
			//IL_0194: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			//IL_0046: Expected O, but got I
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4+10]");
			Delegate obj6 = (Delegate)0;
			Delegate obj12 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				bool flag2 = (object)obj7 == null;
				Delegate obj8 = value;
				if (!flag2)
				{
					obj8 = (Delegate)obj4;
					if (obj7 != obj4)
					{
						break;
					}
				}
				object obj9 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+E4]");
				bool flag3 = (nint)0 == 0;
				object obj10 = !flag3;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj9 = obj;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v10+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj12 == obj6;
				obj6 = obj12;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	public static event Action<int> OnUserBlocked
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Combine(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0211: Expected O, but got I4
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Expected O, but got Unknown
			//IL_0243: Expected O, but got I
			//IL_0253: Expected O, but got I
			//IL_0170: Expected O, but got I4
			//IL_0179: Expected O, but got I4
			//IL_0182: Expected O, but got I4
			//IL_0046: Expected O, but got I
			//IL_00fb: Expected O, but got I4
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v3+B8]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v4+18]");
			Delegate obj6 = (Delegate)0;
			Delegate obj8 = default(Delegate);
			object obj9 = default(object);
			Delegate obj13 = default(Delegate);
			Delegate obj21 = default(Delegate);
			while (true)
			{
				Delegate obj7 = Delegate.Remove(obj6, value);
				object obj14;
				Delegate obj15;
				Delegate obj16;
				object obj10;
				object obj12;
				if ((object)obj7 != null)
				{
					obj8 = (Delegate)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj9 == null)
					{
						break;
					}
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag2 = (nint)0 == 0;
					object obj11 = !flag2;
					obj12 = obj9;
					obj13 = obj7;
					if (obj11 != null)
					{
						goto IL_0030;
					}
					obj14 = obj9;
					obj15 = obj7;
					obj16 = (Delegate)obj4;
					Delegate obj17 = (Delegate)obj4;
					object obj18 = obj10;
				}
				else
				{
					obj10 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+E4]");
					bool flag3 = (nint)0 == 0;
					object obj19 = !flag3;
					obj12 = 0;
					obj14 = 0;
					obj15 = obj13;
					obj16 = obj8;
					Delegate obj17 = value;
					object obj18 = obj10;
					if (obj19 != null)
					{
						goto IL_0030;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj10 = obj;
				obj12 = obj14;
				obj13 = obj15;
				obj8 = obj16;
				goto IL_0030;
				IL_0030:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v136 @ X0_v15+B8]");
				object obj20 = (nint)0 + (nint)24;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag4 = (object)obj21 == obj6;
				obj6 = obj21;
				if (!flag4)
				{
					continue;
				}
				return;
			}
			throw new InvalidCastException();
		}
	}

	private void Awake()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02db: Expected O, but got I
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_02fb: Expected O, but got I
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_031b: Expected O, but got I
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_033b: Expected O, but got I
		//IL_036f: Expected O, but got I4
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_03ba: Expected I, but got O
		//IL_0056: Expected I, but got O
		//IL_007c: Expected I, but got O
		//IL_00a7: Expected I, but got O
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00df: Expected O, but got I
		//IL_00ed: Expected I, but got O
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_012a: Expected O, but got I
		//IL_0138: Expected I, but got O
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0170: Expected O, but got I
		//IL_017e: Expected I, but got O
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01bb: Expected O, but got I
		//IL_01c9: Expected I, but got O
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_0207: Expected O, but got I4
		//IL_0248: Expected O, but got I
		//IL_0256: Expected I, but got O
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0294: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1264;
		object obj3 = (nint)0 + (nint)2816;
		object obj4 = typeof(SqlSingle[]) + 2376;
		object obj5 = (nint)0 + (nint)2824;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3104;
		object obj7 = (nint)0 + (nint)2840;
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1704;
		object obj9 = (nint)0 + (nint)2792;
		GameObject gameObject = base.gameObject;
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj11 = !flag;
		UnityEngine.Object target = gameObject;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		object obj12 = typeof(AdManagerInterstitialAd.<Load>c__AnonStorey0) + 1848;
		UnityEngine.Object.DontDestroyOnLoad(target);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj3);
		SFS.OnLogin += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj5);
		SFS.OnLogout += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj7);
		CoordinatorService.OnPrivateMessage += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj9);
		CoordinatorService.OnConnectionStatusUpdate += action4;
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)2800;
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj14);
		CoordinatorService.OnOnlineFriendsUpdate += action5;
		object obj15 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)2808;
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj16);
		CoordinatorService.OnFriendStatusUpdate += action6;
		object obj17 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)2848;
		Action<int> action7 = default(Action<int>);
		action7..ctor((object)this, (IntPtr)obj18);
		CoordinatorService.OnRemoveFriend += action7;
		object obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)2832;
		Action<object> action8 = default(Action<object>);
		action8..ctor((object)this, (IntPtr)obj20);
		object obj21 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
		object obj22 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v28+E4]");
		bool flag2 = (nint)0 == 0;
		object obj23 = !flag2;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PlayerProfilesHandler.OnPlayerProfileLoaded += action8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj24 = (nint)0 + (nint)2856;
		Application.LowMemoryCallback lowMemoryCallback = default(Application.LowMemoryCallback);
		lowMemoryCallback..ctor(null, (IntPtr)obj24);
		object obj25 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 520;
		object obj26 = obj25;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v33+E4]");
		bool flag3 = (nint)0 == 0;
		object obj27 = !flag3;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Application.lowMemory += lowMemoryCallback;
	}

	private void OnApplicationPause(bool pauseStatus)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		if (pauseStatus)
		{
			object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X0_v2+E4]");
			if ((nint)0 != 0)
			{
				SaveProfiles();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			SaveProfiles();
		}
	}

	public static void CallWhenLoaded(Action action)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00df: Expected O, but got I4
		//IL_008c: Expected O, but got I
		//IL_009c: Expected O, but got I
		//IL_0117: Expected O, but got I
		//IL_0127: Expected O, but got I
		//IL_0149: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61B0]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v5+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+8]");
		OneShotEvent oneShotEvent = (OneShotEvent)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a1;
		IL_007c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v12+B8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v9+8]");
		oneShotEvent = (OneShotEvent)0;
		goto IL_00a1;
		IL_00a1:
		oneShotEvent.CallWhenReady(action);
	}

	private void OnLogin(BaseEvent _)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_03f0: Expected O, but got I
		//IL_0400: Expected O, but got I
		//IL_0415: Expected O, but got I
		//IL_0434: Expected O, but got I4
		//IL_043d: Expected O, but got I4
		//IL_0446: Expected O, but got I4
		//IL_0456: Expected O, but got I
		//IL_01a7: Expected O, but got I
		//IL_01b7: Expected O, but got I
		//IL_01cc: Expected O, but got I
		//IL_01e4: Expected O, but got I4
		//IL_01ed: Expected O, but got I4
		//IL_01fd: Expected O, but got I
		//IL_0235: Expected O, but got I4
		//IL_048e: Expected O, but got I4
		//IL_0585: Expected O, but got I
		//IL_04c9: Expected O, but got I
		//IL_02aa: Expected O, but got I4
		//IL_0548: Expected O, but got I
		//IL_02e7: Expected O, but got I
		//IL_031a: Expected O, but got I
		//IL_03b3: Expected O, but got I4
		//IL_0375: Expected O, but got I
		object obj = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61B1]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v42+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			int num3 = 1;
			obj3 = (nint)0 + (nint)2200;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v42+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			obj5 = obj3;
			if (obj6 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj3 = obj5;
		goto IL_0137;
		IL_0510:
		SaveProfiles();
		return;
		IL_020b:
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v21+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		object obj10;
		object obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v28+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v262 @ X0_v28+B8]");
		object obj12 = (nint)0 + (nint)32;
		obj12 = dbId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string chatsDirectory = ChatsDirectory;
		DirectoryInfo directoryInfo = Directory.CreateDirectory(chatsDirectory);
		object obj13 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v16+B8]");
		object obj14 = 0;
		object obj15 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v18+18]");
		int num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v18+1C]");
		object obj16 = (nint)0 + (nint)1;
		int num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v18+18]");
		bool flag5 = (nint)0 < (nint)1;
		bool flag6 = false;
		if (!flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v18+10]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X8_v18+18]");
			Array.Clear((Array)num2, 0, 0);
			flag6 = false;
		}
		UpdateFriendsList();
		object obj17 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v8+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		if (obj18 != null)
		{
			goto IL_0510;
		}
		object obj19 = obj17;
		goto IL_0516;
		IL_0516:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SaveProfiles();
		return;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		bool flag8 = (object)sessionModel2 == null;
		object obj20 = !flag8;
		if (obj20 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0137;
		IL_0137:
		obj10 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		User localUser2 = sessionModel2.LocalUser;
		string dbId2 = SFSKammelnaUserExtensions.GetDbId(localUser2);
		object obj21 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v4+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v4+B8]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v20+20]");
			string text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v20+20]");
			bool flag9 = dbId2 != (string)0;
			bool flag10 = !flag9;
			object obj23 = 0;
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v20+20]");
			string text2 = (string)0;
			if (!flag10)
			{
				goto IL_020b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj25 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v11+B8]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v12+20]");
			string text = (string)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v12+20]");
			bool flag11 = dbId2 != (string)0;
			bool flag12 = !flag11;
			object obj27 = !flag12;
			object obj23 = 0;
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v12+20]");
			string text2 = (string)0;
			if (obj27 != null)
			{
				goto IL_020b;
			}
		}
		object obj28 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v11+E4]");
		bool flag13 = (nint)0 == 0;
		object obj29 = !flag13;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj28 = obj10;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v11+B8]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v9+8]");
		((OneShotEvent)0).IsReady = true;
		obj17 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X0_v8+E4]");
		bool flag14 = (nint)0 == 0;
		num = 0;
		flag6 = true;
		obj19 = obj17;
		if (!flag14)
		{
			goto IL_0510;
		}
		goto IL_0516;
	}

	private void OnLogout()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e4: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_011c: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_014e: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61B2]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v5+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+8]");
		OneShotEvent oneShotEvent = (OneShotEvent)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4+8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		if (obj9 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00aa;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v12+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v9+8]");
		oneShotEvent = (OneShotEvent)0;
		goto IL_00aa;
		IL_00aa:
		oneShotEvent.Clear();
	}

	private unsafe void OnPrivateMessage(PrivateMessageModel messageData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		//IL_092f: Expected O, but got I
		//IL_094a: Expected I, but got O
		//IL_00fb: Expected O, but got I
		//IL_010c: Expected O, but got I
		//IL_016e: Expected O, but got I4
		//IL_0253: Expected O, but got I
		//IL_0263: Expected O, but got I
		//IL_0273: Expected O, but got I
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected I4, but got Unknown
		//IL_02c5: Expected O, but got I4
		//IL_02d5: Expected O, but got I
		//IL_0328: Expected O, but got I4
		//IL_033e: Expected O, but got I
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected I4, but got Unknown
		//IL_0213: Expected O, but got I4
		//IL_0585: Expected O, but got I4
		//IL_03a0: Expected O, but got I
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected O, but got Unknown
		//IL_0647: Expected O, but got I4
		//IL_05bd: Expected O, but got I
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected O, but got Unknown
		//IL_06b4: Expected O, but got I4
		//IL_03e9: Expected O, but got I4
		//IL_0439: Expected O, but got I4
		//IL_0442: Expected O, but got I4
		//IL_044b: Expected O, but got I4
		//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0700: Expected O, but got Unknown
		//IL_072a: Expected O, but got I4
		//IL_0499: Expected O, but got I4
		//IL_04af: Expected O, but got I
		//IL_0981: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Expected O, but got Unknown
		//IL_099e: Expected O, but got I
		//IL_082e: Expected O, but got I4
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Expected O, but got Unknown
		//IL_0773: Expected O, but got I
		//IL_0511: Expected O, but got I
		//IL_0521: Expected O, but got I
		//IL_0866: Expected O, but got I
		//IL_0876: Expected O, but got I
		//IL_0898: Expected O, but got I4
		//IL_09df: Expected O, but got I
		//IL_0a13: Expected O, but got I4
		//IL_0a1c: Expected O, but got I4
		//IL_0a2c: Expected O, but got I
		//IL_07ae: Expected O, but got I
		//IL_08e2: Expected O, but got I4
		//IL_08f2: Expected O, but got I
		//IL_0902: Expected O, but got I
		//IL_08b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected O, but got Unknown
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Expected O, but got Unknown
		//IL_07bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c1: Expected O, but got Unknown
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected O, but got Unknown
		object obj = typeof(DebugUI.BitField) + 3272;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
		object obj5 = (nint)0 + (nint)1048;
		object obj6 = (nint)0 + (nint)800;
		object obj7 = obj2 + 16;
		obj7 = messageData;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v9+B8]");
		object source = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj5);
		object obj10 = obj6;
		object obj11 = Enumerable.FirstOrDefault((IEnumerable<object>)source, func);
		if (obj11 == null)
		{
			return;
		}
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v13 (System.Object)+58]");
		List<object> list = (List<object>)0;
		object obj12 = (nint)0 + (nint)2176;
		object obj13 = obj7;
		object obj14 = obj12;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag2 = list._size < items.Length;
		object obj15 = !flag2;
		int num;
		int num2;
		object obj20;
		int value;
		int num3;
		if (obj15 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj16 = items + list._size;
			object obj17 = obj16 + 32;
			obj17 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			num = obj11 + 16;
			num2 = ((int*)num)->m_value;
			object obj18 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v71+E4]");
			bool flag3 = (nint)0 == 0;
			object obj19 = !flag3;
			if (obj19 == null)
			{
				obj20 = obj10;
				value = ((int*)num)->m_value;
				num3 = num;
				goto IL_02f8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v10+20]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v300 @ X8_v61+C0]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v62+70]");
			obj20 = 0;
			list.AddWithResize(obj7);
			num3 = obj11 + 16;
			value = ((int*)num3)->m_value;
			object obj18 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X0_v71+E4]");
			bool flag4 = (nint)0 == 0;
			object obj23 = !flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v62+70]");
			obj10 = 0;
			num2 = ((int*)num3)->m_value;
			num = num3;
			if (obj23 == null)
			{
				goto IL_02f8;
			}
		}
		goto IL_031f;
		IL_05e1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X0_v13 (System.Object)+60]");
		int newCount = (int)((nint)0 + (nint)1);
		string extra = ((int*)num)->ToString();
		object obj24 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v20+E4]");
		bool flag5 = (nint)0 == 0;
		object obj26 = !flag5;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.PrivateChat, newCount, extra);
		object obj27 = typeof(DataRelation) + 712;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X0_v23+E4]");
		bool flag6 = (nint)0 == 0;
		object obj29 = !flag6;
		if (obj29 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime utcNow = DateTime.UtcNow;
		DateTime dateTime = default(DateTime);
		long ticks = dateTime.Ticks;
		object obj30 = typeof(UsageHint) + 72;
		object obj31 = obj30;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X8_v23+E4]");
		bool flag7 = (nint)0 == 0;
		object obj32 = !flag7;
		if (obj32 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UserInfo.ChatLastUpdatedAt = ticks;
		object obj33 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
		object obj34 = obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v26+B8]");
		object obj35 = 0;
		object obj36 = obj35;
		object obj37 = typeof(System.IOAsyncCallback) + 1216;
		object obj38 = obj36;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v30+12E]");
		object obj39 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v30+12E]");
		if ((nint)0 == 0)
		{
			goto IL_07ef;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v513 @ X8_v30+B0]");
		object obj40 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X10_v8-8]");
			if (0 == (nint)obj37)
			{
				break;
			}
			obj40 += 16;
			obj39--;
			if ((nint)obj39 != 1)
			{
				continue;
			}
			goto IL_07ef;
		}
		object obj41 = obj40 + 2;
		object obj42 = obj38 + obj41;
		object obj43 = obj42 + 312;
		goto IL_09cf;
		IL_0390:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v64+B8]");
		object obj44 = 0;
		int num4 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v344 @ X8_v57+28]");
		if ((nint)num4 == 0)
		{
			goto IL_03c7;
		}
		goto IL_05e1;
		IL_07ef:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_09cf;
		IL_0501:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v60+B8]");
		object obj45 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v49+10]");
		object obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v49+10]");
		if ((nint)0 != 0)
		{
			goto IL_0546;
		}
		return;
		IL_0546:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v274 @ X8_v47+18] (should have been resolved before IL gen)");
		return;
		IL_09cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X0_v30+8]");
		object obj47 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v572 @ X0_v30] (should have been resolved before IL gen)");
		object obj48 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v62+E4]");
		bool flag8 = (nint)0 == 0;
		object obj49 = !flag8;
		object obj50 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6000]");
		object obj51 = 0;
		object obj52;
		if (obj49 == null)
		{
			obj52 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X0_v30+8]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6000]");
			obj13 = 0;
			goto IL_0469;
		}
		goto IL_0490;
		IL_02f8:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj10 = obj20;
		num2 = value;
		num = num3;
		goto IL_031f;
		IL_031f:
		object obj53 = 146685952;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE4597]");
		object obj54 = (nint)0 & (nint)1;
		object obj55;
		if (obj54 != null)
		{
			obj55 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v64+E4]");
			bool flag9 = (nint)0 == 0;
			object obj56 = obj55;
			if (!flag9)
			{
				goto IL_0390;
			}
		}
		else
		{
			_ = 1;
			obj55 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v64+E4]");
			bool flag10 = (nint)0 == 0;
			object obj57 = !flag10;
			object obj56 = obj55;
			if (obj57 != null)
			{
				goto IL_0390;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj55 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v64+B8]");
		object obj58 = 0;
		int num5 = num2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v36+28]");
		if ((nint)num5 == 0)
		{
			goto IL_03c7;
		}
		goto IL_05e1;
		IL_0469:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj50 = obj52;
		obj47 = obj10;
		obj51 = obj13;
		goto IL_0490;
		IL_03c7:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X0_v64+E4]");
		bool flag11 = (nint)0 == 0;
		object obj59 = !flag11;
		if (obj59 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		MarkMessagesAsRead((FriendProfile)obj11);
		obj48 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X0_v62+E4]");
		bool flag12 = (nint)0 == 0;
		object obj60 = !flag12;
		obj52 = 0;
		obj50 = 0;
		obj47 = obj10;
		obj51 = obj13;
		if (obj60 == null)
		{
			goto IL_0469;
		}
		goto IL_0490;
		IL_0490:
		object obj61 = 152985600;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6284]");
		object obj62 = (nint)0 & (nint)1;
		if (obj62 != null)
		{
			object obj63 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v60+E4]");
			bool flag13 = (nint)0 == 0;
			object obj64 = obj63;
			if (!flag13)
			{
				goto IL_0501;
			}
		}
		else
		{
			_ = 1;
			object obj63 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X0_v60+E4]");
			bool flag14 = (nint)0 == 0;
			object obj65 = !flag14;
			object obj64 = obj63;
			if (obj65 != null)
			{
				goto IL_0501;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj66 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X0_v52+B8]");
		object obj67 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v43+10]");
		obj46 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v495 @ X8_v43+10]");
		bool flag15 = (nint)0 == 0;
		object obj68 = !flag15;
		if (obj68 == null)
		{
			return;
		}
		goto IL_0546;
	}

	public unsafe static void MarkMessagesAsRead(FriendProfile profile)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0126: Expected O, but got I4
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected I4, but got Unknown
		//IL_00aa: Expected O, but got I4
		//IL_019c: Expected O, but got I4
		//IL_02bf: Expected O, but got I
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01e5: Expected O, but got I
		//IL_0220: Expected O, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		object obj = typeof(DataRelation) + 712;
		bool flag = profile.UnreadMessages < 1;
		IntPtr intPtr = default(IntPtr);
		int num = (int)(nint)intPtr;
		if (!flag)
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
			profile.UnreadMessages = 0;
			int num2 = profile + 16;
			string extra = ((int*)num2)->ToString();
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v24+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CounterBubbleManager.UpdateCounter(CounterBubbleType.PrivateChat, 0, extra);
			num = 0;
		}
		object obj5 = typeof(UsageHint) + 72;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
		DateTime utcNow = DateTime.UtcNow;
		DateTime dateTime = default(DateTime);
		long ticks = dateTime.Ticks;
		object obj9 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X8_v7+E4]");
		bool flag4 = (nint)0 == 0;
		object obj10 = !flag4;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		UserInfo.ChatLastUpdatedAt = ticks;
		object obj11 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v8+B8]");
		object obj12 = 0;
		object obj13 = obj12;
		object obj14 = typeof(System.IOAsyncCallback) + 1216;
		object obj15 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v12+12E]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v12+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0261;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v12+B0]");
		object obj17 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X10_v5-8]");
			if (0 == (nint)obj14)
			{
				break;
			}
			obj17 += 16;
			obj16--;
			if ((nint)obj16 != 1)
			{
				continue;
			}
			goto IL_0261;
		}
		object obj18 = obj17 + 2;
		object obj19 = obj15 + obj18;
		object obj20 = obj19 + 312;
		goto IL_02f0;
		IL_0261:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_02f0;
		IL_02f0:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v268 @ X0_v12] (should have been resolved before IL gen)");
	}

	public static void MarkRequestSeen()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0267: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0103: Expected O, but got I
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0127: Expected O, but got I
		//IL_0137: Expected O, but got I
		//IL_0159: Expected O, but got I4
		//IL_02c7: Expected O, but got I4
		//IL_01f5: Expected O, but got I4
		//IL_0189: Expected O, but got I4
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_0346: Expected O, but got I
		//IL_0357: Expected I, but got O
		//IL_0375: Expected O, but got I
		//IL_01b9: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61B4]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		object obj7;
		if (obj3 != null)
		{
			obj4 = typeof(DebugUI.BitField) + 3264;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v41+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj5;
			obj7 = obj4;
			if (!flag)
			{
				goto IL_00a1;
			}
		}
		else
		{
			_ = 1;
			obj4 = typeof(DebugUI.BitField) + 3264;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v41+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj6 = obj5;
			obj7 = obj4;
			if (obj8 != null)
			{
				goto IL_00a1;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		IEnumerable<FriendProfile> receivedRequests = ReceivedRequests;
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v27+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		obj4 = obj7;
		IEnumerable<FriendProfile> enumeration = receivedRequests;
		object obj11 = obj9;
		IEnumerable<FriendProfile> enumerable = receivedRequests;
		if (obj10 != null)
		{
			goto IL_00f7;
		}
		goto IL_02f5;
		IL_00f7:
		object obj12 = (nint)0 + (nint)2136;
		object obj13 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v27+B8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v11+40]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X8_v11+40]");
		bool flag4 = (nint)0 == 0;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v27+E4]");
			bool flag5 = (nint)0 == 0;
			object obj16 = !flag5;
			if (obj16 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj17 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v17+B8]");
				obj14 = 0;
			}
			object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj19 = (nint)0 + (nint)928;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj14, (IntPtr)obj19);
			object obj20 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v16+B8]");
			object obj21 = (nint)0 + (nint)64;
			obj21 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			action = action2;
		}
		ArraysExtensions.ForEach(enumeration, action);
		object obj22 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X0_v30+E4]");
		bool flag6 = (nint)0 == 0;
		object obj23 = !flag6;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.FriendRequest, 0);
		return;
		IL_02f5:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj9 = obj7;
		obj4 = obj7;
		enumeration = enumerable;
		goto IL_00f7;
		IL_00a1:
		IEnumerable<FriendProfile> receivedRequests2 = ReceivedRequests;
		obj9 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v27+E4]");
		bool flag7 = (nint)0 == 0;
		enumeration = receivedRequests2;
		obj11 = obj9;
		obj7 = obj4;
		enumerable = receivedRequests2;
		if (!flag7)
		{
			goto IL_00f7;
		}
		goto IL_02f5;
	}

	private static void UpdateOnlineFriendCount()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0425: Expected O, but got I
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_0463: Expected O, but got I4
		//IL_0270: Expected O, but got I4
		//IL_0320: Expected O, but got I
		//IL_033a: Expected O, but got I4
		//IL_02c6: Expected O, but got I4
		//IL_02cf: Expected O, but got I4
		//IL_02e5: Expected O, but got I4
		//IL_010a: Expected O, but got I
		//IL_03d8: Expected O, but got I
		//IL_03e8: Expected O, but got I
		//IL_040a: Expected O, but got I4
		//IL_0390: Expected O, but got I4
		//IL_01d1: Expected O, but got I
		//IL_01e1: Expected O, but got I
		//IL_01f1: Expected O, but got I
		//IL_018c: Expected O, but got I
		//IL_019c: Expected O, but got I
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj2 = (nint)0 + (nint)3360;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		IEnumerable<FriendProfile> onlineFriendsList = OnlineFriendsList;
		int num = Enumerable.Count((IEnumerable<object>)onlineFriendsList);
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v6+E4]");
		if ((nint)0 == 0)
		{
			goto IL_01fb;
		}
		int count = CounterBubbleManager.GetCount(CounterBubbleType.OnlineFriends);
		bool flag2 = num != count;
		int num2 = 0;
		int num3 = 0;
		if (!flag2)
		{
			goto IL_00af;
		}
		goto IL_0246;
		IL_0360:
		_ = 1;
		object obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v29+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		string text2;
		string text = text2;
		int num4;
		num2 = num4;
		object obj9 = obj7;
		if (obj8 != null)
		{
			goto IL_017c;
		}
		goto IL_03b6;
		IL_03b6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X0_v10+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v7+10]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v7+10]");
		bool flag4 = (nint)0 == 0;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			return;
		}
		goto IL_01c1;
		IL_0300:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6284]");
		object obj14 = (nint)0 & (nint)1;
		bool flag5 = obj14 == null;
		object obj15 = !flag5;
		object obj17;
		object obj16 = obj17;
		text = text2;
		num2 = num4;
		if (obj15 != null)
		{
			goto IL_013f;
		}
		goto IL_0360;
		IL_00af:
		object obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v16+E4]");
		bool flag6 = (nint)0 == 0;
		obj17 = obj16;
		text2 = text;
		num4 = num2;
		if (!flag6)
		{
			goto IL_00f4;
		}
		goto IL_0300;
		IL_00f4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6284]");
		object obj19 = (nint)0 & (nint)1;
		bool flag7 = obj19 == null;
		obj17 = obj16;
		text2 = text;
		num4 = num2;
		if (!flag7)
		{
			goto IL_013f;
		}
		goto IL_0360;
		IL_013f:
		obj7 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v29+E4]");
		bool flag8 = (nint)0 == 0;
		obj17 = obj16;
		obj9 = obj7;
		if (!flag8)
		{
			goto IL_017c;
		}
		goto IL_03b6;
		IL_017c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v29+B8]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v18+10]");
		obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v18+10]");
		if ((nint)0 != 0)
		{
			goto IL_01c1;
		}
		return;
		IL_01c1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v16+18]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v16+40]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X8_v16+28]");
		object obj23 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v270 @ X2_v7 (should have been resolved before IL gen)");
		goto IL_01fb;
		IL_01fb:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		int count2 = CounterBubbleManager.GetCount(CounterBubbleType.OnlineFriends);
		bool flag9 = num == count2;
		num2 = 0;
		num3 = 0;
		if (flag9)
		{
			goto IL_00af;
		}
		goto IL_0246;
		IL_0246:
		object obj24 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v19+E4]");
		bool flag10 = (nint)0 == 0;
		object obj25 = !flag10;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.OnlineFriends, num);
		obj18 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v16+E4]");
		bool flag11 = (nint)0 == 0;
		object obj26 = !flag11;
		obj16 = 0;
		text = null;
		num2 = num;
		obj17 = 0;
		text2 = null;
		num4 = num;
		if (obj26 != null)
		{
			goto IL_00f4;
		}
		goto IL_0300;
	}

	public static void NotifyUiUpdate()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_016c: Expected O, but got I
		//IL_017c: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_00da: Expected O, but got I
		//IL_00ea: Expected O, but got I
		//IL_00fa: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6284]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 == null)
		{
			goto IL_0104;
		}
		object obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = obj4;
		if (!flag)
		{
			goto IL_0085;
		}
		goto IL_014a;
		IL_014a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v4+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+10]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v4+10]");
		bool flag2 = (nint)0 == 0;
		object obj9 = !flag2;
		if (obj9 == null)
		{
			return;
		}
		goto IL_00ca;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+B8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v10+10]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v10+10]");
		if ((nint)0 != 0)
		{
			goto IL_00ca;
		}
		return;
		IL_00ca:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+18]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+40]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v8+28]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X2_v1 (should have been resolved before IL gen)");
		goto IL_0104;
		IL_0104:
		_ = 1;
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v11+E4]");
		bool flag3 = (nint)0 == 0;
		object obj14 = !flag3;
		obj5 = obj4;
		if (obj14 != null)
		{
			goto IL_0085;
		}
		goto IL_014a;
	}

	private void ConnectionStatusUpdate(ConnectionStatusUpdate model)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		//IL_0147: Expected O, but got I
		//IL_0162: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 3280;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
		object obj5 = (nint)0 + (nint)1056;
		object obj6 = (nint)0 + (nint)800;
		object obj7 = obj2 + 16;
		obj7 = model;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v9+B8]");
		object source = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj5);
		object obj10 = Enumerable.FirstOrDefault((IEnumerable<object>)source, func);
		if (obj10 != null)
		{
			object obj11 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v8+14]");
			_ = 0;
		}
		object obj12 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v14+E4]");
		if ((nint)0 != 0)
		{
			UpdateOnlineFriendCount();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UpdateOnlineFriendCount();
	}

	private void InitializeOnlineFriends(List<int> friendIds)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_00b7: Expected O, but got I4
		//IL_02ce: Expected O, but got I
		//IL_02e9: Expected I, but got O
		//IL_0199: Expected O, but got I
		//IL_01a9: Expected O, but got I
		//IL_01b9: Expected O, but got I
		//IL_01db: Expected O, but got I4
		//IL_01e4: Expected O, but got I4
		//IL_0115: Expected O, but got I
		//IL_0125: Expected O, but got I
		//IL_0135: Expected O, but got I
		//IL_0157: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		//IL_021c: Expected O, but got I4
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_0329: Expected O, but got I
		//IL_033a: Expected I, but got O
		//IL_0358: Expected O, but got I
		//IL_0373: Expected O, but got I4
		//IL_024c: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 3288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
		object obj5 = (nint)0 + (nint)1064;
		object obj6 = (nint)0 + (nint)3432;
		object obj7 = typeof(DebugUI.BitField) + 3264;
		object obj8 = obj2 + 16;
		obj8 = friendIds;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj9 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v9+B8]");
		object source = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj5);
		IEnumerable<object> enumeration = Enumerable.Where((IEnumerable<object>)source, func);
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v19+E4]");
		object obj13;
		Action<object> action;
		object obj16;
		object obj15;
		object obj12;
		if ((nint)0 != 0)
		{
			obj12 = (nint)0 + (nint)2136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v19+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v9+48]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v9+48]");
			bool flag2 = (nint)0 == 0;
			object obj14 = !flag2;
			obj15 = 0;
			if (obj14 == null)
			{
				obj16 = obj12;
				goto IL_01fa;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj11 = obj7;
			obj16 = (nint)0 + (nint)2136;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v19+B8]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v9+48]");
			action = (Action<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v9+48]");
			bool flag3 = (nint)0 == 0;
			object obj17 = !flag3;
			obj15 = 0;
			obj12 = obj16;
			if (obj17 == null)
			{
				goto IL_01fa;
			}
		}
		goto IL_0251;
		IL_0251:
		ArraysExtensions.ForEach(enumeration, action);
		object obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v17+E4]");
		if ((nint)0 != 0)
		{
			UpdateOnlineFriendCount();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UpdateOnlineFriendCount();
		return;
		IL_01fa:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v19+E4]");
		bool flag4 = (nint)0 == 0;
		object obj19 = !flag4;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj20 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v15+B8]");
			obj13 = 0;
		}
		object obj21 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj22 = (nint)0 + (nint)920;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj13, (IntPtr)obj22);
		object obj23 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v14+B8]");
		object obj24 = (nint)0 + (nint)72;
		obj24 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj15 = 0;
		obj12 = obj16;
		action = action2;
		goto IL_0251;
	}

	private void OnRemoveFriend(int friendId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0088: Expected O, but got I4
		//IL_01c3: Expected O, but got I
		//IL_01de: Expected I, but got O
		//IL_00fc: Expected O, but got I4
		//IL_020c: Expected O, but got I
		//IL_012d: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
		object obj5 = (nint)0 + (nint)1072;
		object obj6 = (nint)0 + (nint)800;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v7+B8]");
		object source = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj5);
		object obj9 = obj6;
		object obj10 = Enumerable.FirstOrDefault((IEnumerable<object>)source, func);
		bool flag2 = obj10 == null;
		object obj11 = func;
		if (!flag2)
		{
			object obj12 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v16+E4]");
			bool flag3 = (nint)0 == 0;
			object obj13 = !flag3;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj12 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v16+B8]");
			object obj14 = 0;
			object obj15 = (nint)0 + (nint)2328;
			obj9 = obj15;
			bool flag4 = ((List<object>)obj14).Remove(obj10);
			obj11 = obj10;
		}
		object obj16 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X0_v13+E4]");
		if ((nint)0 != 0)
		{
			UpdateOnlineFriendCount();
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UpdateOnlineFriendCount();
	}

	private void OnFriendStatusUpdate(Friend friend)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		//IL_06ba: Expected O, but got I
		//IL_06d5: Expected I, but got O
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_01ac: Expected O, but got I4
		//IL_0718: Expected O, but got I
		//IL_0117: Expected O, but got I4
		//IL_0703: Expected O, but got I
		//IL_01f0: Expected O, but got I
		//IL_0148: Expected O, but got I
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_025e: Expected O, but got I4
		//IL_0341: Expected O, but got I
		//IL_0351: Expected O, but got I
		//IL_0361: Expected O, but got I
		//IL_03a6: Expected O, but got I4
		//IL_03ce: Expected O, but got I
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_0748: Expected O, but got I
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected O, but got Unknown
		//IL_076c: Expected O, but got I
		//IL_077c: Expected O, but got I
		//IL_079e: Expected O, but got I4
		//IL_02f6: Expected O, but got I4
		//IL_0843: Expected O, but got I4
		//IL_042d: Expected O, but got I4
		//IL_05c1: Expected O, but got I
		//IL_05db: Expected O, but got I4
		//IL_07c2: Expected O, but got I
		//IL_07d3: Expected I, but got O
		//IL_07f1: Expected O, but got I
		//IL_04d0: Expected O, but got I
		//IL_045d: Expected O, but got I
		//IL_0651: Expected O, but got I
		//IL_0661: Expected O, but got I
		//IL_0683: Expected O, but got I4
		//IL_0619: Expected O, but got I4
		//IL_0577: Expected O, but got I
		//IL_0587: Expected O, but got I
		//IL_0597: Expected O, but got I
		//IL_0532: Expected O, but got I
		//IL_0542: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 3304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
		object obj5 = (nint)0 + (nint)1080;
		object obj6 = (nint)0 + (nint)800;
		object obj7 = obj2 + 16;
		obj7 = friend;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v9+B8]");
		object source = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj5);
		object obj10 = obj6;
		object obj11 = Enumerable.FirstOrDefault((IEnumerable<object>)source, func);
		bool flag2 = obj11 == null;
		object obj12 = func;
		if (!flag2)
		{
			object obj13 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v64+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X0_v64+B8]");
			object obj15 = 0;
			object obj16 = (nint)0 + (nint)2328;
			obj10 = obj16;
			bool flag4 = ((List<object>)obj15).Remove(obj11);
			obj12 = obj11;
		}
		object obj17 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1416;
		object obj18 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v16+E4]");
		bool flag5 = (nint)0 == 0;
		object obj19 = !flag5;
		if (obj19 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj18 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X0_v16+B8]");
		object obj20 = 0;
		List<object> list = (List<object>)obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FriendProfile friendProfile = default(FriendProfile);
		friendProfile..ctor((Friend)obj7);
		friendProfile.IsOnline = true;
		object obj21 = (nint)0 + (nint)2296;
		object obj22 = obj21;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		object obj23 = typeof(DebugUI.BitField) + 3264;
		bool flag6 = list._size < items.Length;
		object obj24 = !flag6;
		IEnumerable<FriendProfile> source2;
		IEnumerable<FriendProfile> enumerable;
		object obj29;
		object obj27;
		if (obj24 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj25 = items + list._size;
			object obj26 = obj25 + 32;
			obj26 = friendProfile;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			IEnumerable<FriendProfile> receivedRequests = ReceivedRequests;
			obj27 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v19+E4]");
			bool flag7 = (nint)0 == 0;
			object obj28 = !flag7;
			source2 = receivedRequests;
			if (obj28 == null)
			{
				enumerable = receivedRequests;
				obj29 = obj10;
				object obj30 = friendProfile;
				object obj31 = obj27;
				goto IL_03e4;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v12+20]");
			object obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v275 @ X8_v40+C0]");
			object obj33 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v41+70]");
			obj29 = 0;
			list.AddWithResize((object)friendProfile);
			IEnumerable<FriendProfile> receivedRequests2 = ReceivedRequests;
			object obj31 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X0_v50+E4]");
			bool flag8 = (nint)0 == 0;
			object obj34 = !flag8;
			enumerable = receivedRequests2;
			object obj30 = friendProfile;
			source2 = receivedRequests2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v41+70]");
			obj10 = 0;
			obj27 = obj31;
			if (obj34 == null)
			{
				goto IL_03e4;
			}
		}
		goto IL_073c;
		IL_062f:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj35 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X0_v30+B8]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v20+10]");
		object obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v20+10]");
		bool flag9 = (nint)0 == 0;
		object obj38 = !flag9;
		if (obj38 == null)
		{
			return;
		}
		goto IL_0567;
		IL_05e9:
		_ = 1;
		object obj39 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v39+E4]");
		bool flag10 = (nint)0 == 0;
		object obj40 = !flag10;
		object obj41 = obj39;
		if (obj40 != null)
		{
			goto IL_0522;
		}
		goto IL_062f;
		IL_03e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj27 = obj23;
		source2 = enumerable;
		obj10 = obj29;
		goto IL_073c;
		IL_04ed:
		obj39 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v39+E4]");
		bool flag11 = (nint)0 == 0;
		obj41 = obj39;
		if (!flag11)
		{
			goto IL_0522;
		}
		goto IL_062f;
		IL_073c:
		object obj42 = (nint)0 + (nint)3536;
		object obj43 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v19+B8]");
		object obj44 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v33+50]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v33+50]");
		bool flag12 = (nint)0 == 0;
		object obj45 = !flag12;
		if (obj45 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v19+E4]");
			bool flag13 = (nint)0 == 0;
			object obj46 = !flag13;
			if (obj46 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj47 = obj23;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X8_v37+B8]");
				obj44 = 0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj48 = (nint)0 + (nint)936;
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj44, (IntPtr)obj48);
			object obj49 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v36+B8]");
			object obj50 = (nint)0 + (nint)80;
			obj50 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func2;
		}
		int newCount = Enumerable.Count(source2, predicate);
		object obj51 = obj43;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X0_v23+E4]");
		bool flag14 = (nint)0 == 0;
		object obj52 = !flag14;
		if (obj52 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.UpdateCounter(CounterBubbleType.FriendRequest, newCount);
		object obj53 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v26+E4]");
		if ((nint)0 == 0)
		{
			goto IL_05a1;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6284]");
		object obj54 = (nint)0 & (nint)1;
		if (obj54 != null)
		{
			goto IL_04ed;
		}
		goto IL_05e9;
		IL_05a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6284]");
		object obj55 = (nint)0 & (nint)1;
		bool flag15 = obj55 == null;
		object obj56 = !flag15;
		if (obj56 != null)
		{
			goto IL_04ed;
		}
		goto IL_05e9;
		IL_0522:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v39+B8]");
		object obj57 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v28+10]");
		obj37 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v28+10]");
		if ((nint)0 != 0)
		{
			goto IL_0567;
		}
		return;
		IL_0567:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v26+18]");
		object obj58 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v26+40]");
		object obj59 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v26+28]");
		object obj60 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v174 @ X2_v9 (should have been resolved before IL gen)");
		goto IL_05a1;
	}

	private void OnPlayerProfileLoaded(PlayerProfileModel profileModel)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0098: Expected O, but got I4
		//IL_0319: Expected O, but got I
		//IL_0334: Expected I, but got O
		//IL_00ec: Expected O, but got I4
		//IL_0220: Expected O, but got I
		//IL_023a: Expected O, but got I4
		//IL_012f: Expected O, but got I
		//IL_02b0: Expected O, but got I
		//IL_02c0: Expected O, but got I
		//IL_02e2: Expected O, but got I4
		//IL_0278: Expected O, but got I4
		//IL_01d6: Expected O, but got I
		//IL_01e6: Expected O, but got I
		//IL_01f6: Expected O, but got I
		//IL_0191: Expected O, but got I
		//IL_01a1: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
		object obj5 = (nint)0 + (nint)1088;
		object obj6 = obj2 + 16;
		obj6 = profileModel;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v8+B8]");
		object source = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj5);
		object obj9 = Enumerable.FirstOrDefault((IEnumerable<object>)source, func);
		if (obj9 != null)
		{
			((FriendProfile)obj9).UpdateInfo((PlayerProfileModel)obj6, (Games?)(object)0);
			object obj10 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v14+E4]");
			if ((nint)0 == 0)
			{
				goto IL_0200;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6284]");
			object obj11 = (nint)0 & (nint)1;
			if (obj11 != null)
			{
				goto IL_014c;
			}
			goto IL_0248;
		}
		return;
		IL_0200:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6284]");
		object obj12 = (nint)0 & (nint)1;
		bool flag2 = obj12 == null;
		object obj13 = !flag2;
		if (obj13 != null)
		{
			goto IL_014c;
		}
		goto IL_0248;
		IL_01c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v14+18]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v14+40]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v14+28]");
		object obj16 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v103 @ X2_v5 (should have been resolved before IL gen)");
		goto IL_0200;
		IL_0248:
		_ = 1;
		object obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v26+E4]");
		bool flag3 = (nint)0 == 0;
		object obj18 = !flag3;
		object obj19 = obj17;
		if (obj18 != null)
		{
			goto IL_0181;
		}
		goto IL_028e;
		IL_028e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj20 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v17+B8]");
		object obj21 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v8+10]");
		object obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X8_v8+10]");
		bool flag4 = (nint)0 == 0;
		object obj23 = !flag4;
		if (obj23 == null)
		{
			return;
		}
		goto IL_01c6;
		IL_014c:
		obj17 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v26+E4]");
		bool flag5 = (nint)0 == 0;
		obj19 = obj17;
		if (!flag5)
		{
			goto IL_0181;
		}
		goto IL_028e;
		IL_0181:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v26+B8]");
		object obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v16+10]");
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X8_v16+10]");
		if ((nint)0 != 0)
		{
			goto IL_01c6;
		}
	}

	private static void UpdateListAfter(Action<Action<KammelnaResponseModel<bool>>> action, Action<KammelnaResponseModel<bool>> callback, int otherPlayer = 0)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_007b: Expected O, but got I
		//IL_0096: Expected I, but got O
		//IL_00ab: Expected O, but got I
		//IL_00bb: Expected O, but got I
		//IL_00cb: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 3320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 24;
		obj3 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (action != null)
		{
			object obj4 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
			object obj5 = (nint)0 + (nint)1096;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj2, (IntPtr)obj5);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [action @ X0 (System.Action`1<System.Action`1<KammelnaResponseModel`1<System.Boolean>>>)+18]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [action @ X0 (System.Action`1<System.Action`1<KammelnaResponseModel`1<System.Boolean>>>)+40]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [action @ X0 (System.Action`1<System.Action`1<KammelnaResponseModel`1<System.Boolean>>>)+28]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v86 @ X3_v2 (should have been resolved before IL gen)");
		}
	}

	public static void UpdateFriendsList(Action complete = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0079: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 3328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 352;
		object obj4 = (nint)0 + (nint)1104;
		object obj5 = obj2 + 16;
		obj5 = complete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		KammelnaRequests.GetFriendsList(action);
	}

	private static void GetUnreadMessages()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_015a: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_0210: Expected O, but got I4
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01a6: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_01d8: Expected O, but got I4
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		//IL_02ce: Expected O, but got I
		//IL_02df: Expected I, but got O
		//IL_02fd: Expected O, but got I
		//IL_026f: Expected O, but got I4
		//IL_0240: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(DebugUI.BitField) + 3264;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61BA]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v4+98]");
		Action action = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v4+98]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00e6;
		}
		goto IL_01ee;
		IL_00e6:
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		Action action2 = action;
		if (!flag4)
		{
			goto IL_011b;
		}
		goto IL_028d;
		IL_028d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		action = action2;
		goto IL_011b;
		IL_011b:
		ScreenManager.WaitForScene(Scenes.Menu, action);
		return;
		IL_0085:
		obj7 = typeof(RegisteredWaitHandle) + 3136;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v4+98]");
		action = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v4+98]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		if (!flag5)
		{
			goto IL_00e6;
		}
		goto IL_01ee;
		IL_01ee:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v3+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj14 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)880;
		Action action3 = default(Action);
		action3..ctor(obj8, (IntPtr)obj15);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X8_v9+B8]");
		object obj17 = (nint)0 + (nint)152;
		obj17 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		action = action3;
		action2 = action3;
		if (obj18 != null)
		{
			goto IL_011b;
		}
		goto IL_028d;
	}

	public static void HandleSendMessage(string message, int userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0088: Expected O, but got I4
		//IL_0581: Expected O, but got I
		//IL_059c: Expected I, but got O
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0122: Expected O, but got I4
		//IL_014b: Expected O, but got I
		//IL_0190: Expected O, but got I4
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_025d: Expected O, but got I
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_0296: Expected O, but got I
		//IL_05f0: Expected O, but got I
		//IL_02d1: Expected O, but got I
		//IL_035b: Expected O, but got I
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_03c9: Expected O, but got I4
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_04b1: Expected O, but got I
		//IL_04c1: Expected O, but got I
		//IL_04d1: Expected O, but got I
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_0522: Expected O, but got I4
		//IL_052b: Expected O, but got I4
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_0409: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_046d: Expected O, but got I4
		//IL_048b: Expected O, but got I
		//IL_0494: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 3360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
		object obj5 = (nint)0 + (nint)1160;
		object obj6 = (nint)0 + (nint)800;
		object obj7 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj8 = !flag;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v7+B8]");
		object source = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj5);
		object obj9 = Enumerable.FirstOrDefault((IEnumerable<object>)source, func);
		if (obj9 == null)
		{
			return;
		}
		object obj10 = typeof(DataRelation) + 712;
		object obj11 = typeof(Queue<string>) + 848;
		_ = 1;
		object obj12 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj13 = !flag2;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj14 = (nint)0 + (nint)2200;
		DateTime utcNow = DateTime.UtcNow;
		DateTime dateTime = default(DateTime);
		long ticks = dateTime.Ticks;
		object obj15 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v19+E4]");
		bool flag3 = (nint)0 == 0;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj17 = typeof(System.Buffers.Text.ParserHelpers) + 1808;
		object obj18 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3168;
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		int intDbId = SFSKammelnaUserExtensions.GetIntDbId(localUser);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = default(object);
		obj19..ctor();
		object obj20 = obj19 + 16;
		obj20 = message;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj21 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X8_v11+B8]");
		object obj22 = 0;
		object obj23 = obj22;
		object obj24 = typeof(System.IOAsyncCallback) + 1216;
		object obj25 = obj23;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v15+12E]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v15+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0312;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v320 @ X8_v15+B0]");
		object obj27 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X10_v8-8]");
			if (0 == (nint)obj24)
			{
				break;
			}
			obj27 += 16;
			obj26--;
			if ((nint)obj26 != 1)
			{
				continue;
			}
			goto IL_0312;
		}
		object obj28 = obj27 + 1;
		object obj29 = obj25 + obj28;
		object obj30 = obj29 + 312;
		goto IL_05d6;
		IL_05f5:
		ITrackEvent trackEvent;
		Tracker.DesignEvent(trackEvent);
		return;
		IL_0312:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_05d6;
		IL_0541:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		ITrackEvent trackEvent2;
		trackEvent = trackEvent2;
		goto IL_05f5;
		IL_05d6:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v379 @ X0_v30] (should have been resolved before IL gen)");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v11 (System.Object)+58]");
		List<object> list = (List<object>)0;
		object obj31 = (nint)0 + (nint)2176;
		object obj32 = obj31;
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		object obj33 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1768;
		bool flag4 = list._size < items.Length;
		object obj34 = !flag4;
		if (obj34 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj35 = items + list._size;
			object obj36 = obj35 + 32;
			obj36 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v11 (System.Object)+42]");
			trackEvent = TrackerLibrary.PrivateMessageSent(isFriendOnline: false);
			object obj37 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v22+E4]");
			bool flag5 = (nint)0 == 0;
			object obj38 = !flag5;
			if (obj38 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+10]");
				object obj39 = 0;
				object obj40 = 0;
				trackEvent2 = trackEvent;
				goto IL_0541;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v20+20]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v23+C0]");
			object obj42 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v396 @ X8_v24+70]");
			object obj39 = 0;
			list.AddWithResize(obj19);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X0_v11 (System.Object)+42]");
			trackEvent2 = TrackerLibrary.PrivateMessageSent(isFriendOnline: false);
			object obj37 = obj33;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X8_v22+E4]");
			bool flag6 = (nint)0 == 0;
			object obj43 = !flag6;
			object obj40 = 0;
			trackEvent = trackEvent2;
			if (obj43 == null)
			{
				goto IL_0541;
			}
		}
		goto IL_05f5;
	}

	public static void AddFriend(int userId, Action<KammelnaResponseModel<bool>> callback = null)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_0189: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_01d2: Expected O, but got I4
		//IL_02cc: Expected I8, but got I4
		//IL_010c: Expected O, but got I4
		//IL_02ed: Expected O, but got I
		//IL_0303: Expected O, but got I4
		//IL_0313: Expected O, but got I
		//IL_0224: Expected I8, but got I4
		//IL_0240: Expected O, but got I
		//IL_025b: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61BC]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 != null)
		{
			goto IL_00b8;
		}
		goto IL_01e0;
		IL_0271:
		object obj9;
		if (obj9 != null)
		{
			AcceptRequest(userId, callback);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		AcceptRequest(userId, callback);
		return;
		IL_01f6:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v1 (System.NullReferenceException)+E4]");
		object obj11;
		if ((nint)0 != 0)
		{
			bool flag4 = IsReceivedFriendship(userId);
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v10+E4]");
			obj9 = 0;
			bool flag5 = !flag4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v10+E4]");
			obj11 = 0;
			object obj12 = obj10;
			if (!flag5)
			{
				goto IL_0271;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag6 = IsReceivedFriendship(userId);
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v10+E4]");
			obj9 = 0;
			bool flag7 = !flag6;
			object obj13 = !flag7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v10+E4]");
			obj11 = 0;
			object obj12 = obj10;
			if (obj13 != null)
			{
				goto IL_0271;
			}
		}
		if (obj11 != null)
		{
			SendAddRequest(userId, callback);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SendAddRequest(userId, callback);
		return;
		IL_00b8:
		obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		User localUser = sessionModel.LocalUser;
		bool flag8 = SFSKammelnaUserExtensions.Can(localUser, UserPermission.ForceFriend);
		NullReferenceException ex = (NullReferenceException)obj2;
		bool flag9 = !flag8;
		Action<KammelnaResponseModel<bool>> action = (Action<KammelnaResponseModel<bool>>)16384;
		if (!flag9)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v1 (System.NullReferenceException)+E4]");
			if ((nint)0 != 0)
			{
				ForceAddFriend(userId, callback);
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			ForceAddFriend(userId, callback);
			return;
		}
		goto IL_01f6;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		if ((object)sessionModel != null)
		{
			goto IL_00b8;
		}
		goto IL_01e0;
		IL_01e0:
		ex = new NullReferenceException();
		action = callback;
		goto IL_01f6;
	}

	private static void SendAddRequest(int userId, Action<KammelnaResponseModel<bool>> callback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_006d: Expected I, but got O
		//IL_009c: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 3368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 144;
		object obj4 = (nint)0 + (nint)1168;
		object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
		UpdateListAfter(action, callback);
	}

	private static void ForceAddFriend(int userId, Action<KammelnaResponseModel<bool>> callback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_006d: Expected I, but got O
		//IL_009c: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 3376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 144;
		object obj4 = (nint)0 + (nint)1176;
		object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
		UpdateListAfter(action, callback);
	}

	public static void RemoveFriend(int userId, Action<KammelnaResponseModel<bool>> callback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_006d: Expected I, but got O
		//IL_009c: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 3384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 144;
		object obj4 = (nint)0 + (nint)1184;
		object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
		UpdateListAfter(action, callback);
	}

	private static void AcceptRequest(int userId, Action<KammelnaResponseModel<bool>> callback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_006d: Expected I, but got O
		//IL_009c: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 3392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 144;
		object obj4 = (nint)0 + (nint)1192;
		object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
		UpdateListAfter(action, callback);
	}

	public static void BlockUser(int userId, Action<KammelnaResponseModel<bool>> callback = null)
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
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00b2: Expected I, but got O
		//IL_00d2: Expected I, but got O
		//IL_00fc: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 144;
		object obj4 = (nint)0 + (nint)1200;
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj6 = (nint)0 + (nint)1208;
		object obj7 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj8 = obj2 + 24;
		obj8 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj2, (IntPtr)obj6);
		object obj9 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X0_v12+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3 (System.Object)+10]");
		UpdateListAfter(action, action2);
	}

	public static void UnblockUser(int userId, Action<KammelnaResponseModel<bool>> callback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_006d: Expected I, but got O
		//IL_009c: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 144;
		object obj4 = (nint)0 + (nint)1216;
		object obj5 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v7+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+10]");
		UpdateListAfter(action, callback);
	}

	public static bool IsFriend(long userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ec: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_007d: Expected O, but got I4
		//IL_00c3: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 3416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			object obj5 = (nint)0 + (nint)1224;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IEnumerable<FriendProfile> friendsList = FriendsList;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj5);
			return Enumerable.Any(friendsList, func);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool IsRequestedFriendship(long userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ec: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_007d: Expected O, but got I4
		//IL_00c3: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 3424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			object obj5 = (nint)0 + (nint)1232;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IEnumerable<FriendProfile> sentRequests = SentRequests;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj5);
			return Enumerable.Any(sentRequests, func);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool IsReceivedFriendship(long userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ec: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_007d: Expected O, but got I4
		//IL_00c3: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 3432;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			object obj5 = (nint)0 + (nint)1240;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IEnumerable<FriendProfile> receivedRequests = ReceivedRequests;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj5);
			return Enumerable.Any(receivedRequests, func);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool IsBlocked(long userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00ec: Expected I4, but got O
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_007d: Expected O, but got I4
		//IL_00c3: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			object obj5 = (nint)0 + (nint)1248;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			IEnumerable<FriendProfile> blockedList = BlockedList;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj5);
			return Enumerable.Any(blockedList, func);
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public static bool IsCompleteStranger(long userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0118: Expected O, but got I4
		//IL_01b9: Expected O, but got I4
		//IL_025a: Expected O, but got I4
		//IL_0292: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61C7]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v26+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v26+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag2 = IsFriend(userId);
		bool flag3 = !flag2;
		object obj5 = !flag3;
		if (obj5 != null)
		{
			goto IL_009e;
		}
		goto IL_0126;
		IL_021e:
		return false;
		IL_017d:
		return false;
		IL_009e:
		return false;
		IL_0074:
		if (IsFriend(userId))
		{
			goto IL_009e;
		}
		goto IL_0126;
		IL_0126:
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v2+E4]");
		if ((nint)0 != 0)
		{
			if (IsRequestedFriendship(userId))
			{
				goto IL_017d;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = IsRequestedFriendship(userId);
			bool flag5 = !flag4;
			object obj7 = !flag5;
			if (obj7 != null)
			{
				goto IL_017d;
			}
		}
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			if (IsReceivedFriendship(userId))
			{
				goto IL_021e;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag6 = IsReceivedFriendship(userId);
			bool flag7 = !flag6;
			object obj9 = !flag7;
			if (obj9 != null)
			{
				goto IL_021e;
			}
		}
		object obj10 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X0_v6+E4]");
		bool flag8 = (nint)0 == 0;
		object obj11 = !flag8;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool flag9 = IsBlocked(userId);
		return (byte)((flag9 ? 1u : 0u) ^ 1u) != 0;
	}

	private static string GetChatsPath(int userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 768;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string chatsDirectory = ChatsDirectory;
		object obj4 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, chatsDirectory, arg);
	}

	private static string GetChatsArchivePath(int userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00a2: Expected O, but got I4
		//IL_0040: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 760;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string chatsDirectory = ChatsDirectory;
		object obj4 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		return string.Format((string)format, chatsDirectory, arg);
	}

	public static FriendProfile GetProfile(int userId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_007d: Expected O, but got I4
		//IL_00f5: Expected O, but got I
		//IL_0110: Expected I, but got O
		object obj = typeof(DebugUI.BitField) + 3448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			object obj5 = (nint)0 + (nint)1256;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj6 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v6+B8]");
			object source = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj5);
			return (FriendProfile)Enumerable.FirstOrDefault((IEnumerable<object>)source, func);
		}
		return (FriendProfile)(object)new NullReferenceException();
	}

	private unsafe static FriendProfile LoadProfile(Friend friend, Games currentGame)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00de: Expected O, but got I4
		//IL_009b: Expected O, but got I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected I4, but got Unknown
		//IL_01d2: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61C9]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FriendProfile cachedProfile = GetCachedProfile(friend);
		if (cachedProfile != null)
		{
			goto IL_0125;
		}
		goto IL_0247;
		IL_0247:
		return (FriendProfile)(object)new NullReferenceException();
		IL_01e0:
		return cachedProfile;
		IL_0125:
		cachedProfile.UpdateInfo(friend);
		if (friend != null)
		{
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			int num = friend + 16;
			string userId = ((int*)num)->ToString();
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v120 @ X8_v4+E4]");
			PlayerProfileModel playerProfileModel;
			if ((nint)0 != 0)
			{
				bool flag2 = PlayerProfilesHandler.TryGetCached(userId, out playerProfileModel);
				bool flag3 = !flag2;
				object obj7 = !flag3;
				if (obj7 == null)
				{
					goto IL_01e0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if (!PlayerProfilesHandler.TryGetCached(userId, out playerProfileModel))
				{
					goto IL_01e0;
				}
			}
			cachedProfile.UpdateInfo(currentGame: (Games?)new System.Int32Enum?((System.Int32Enum)currentGame), profile: playerProfileModel);
			return cachedProfile;
		}
		goto IL_0247;
		IL_0074:
		cachedProfile = GetCachedProfile(friend);
		bool flag4 = cachedProfile == null;
		object obj8 = !flag4;
		if (obj8 != null)
		{
			goto IL_0125;
		}
		goto IL_0247;
	}

	private static FriendProfile GetCachedProfile(Friend friend)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Expected O, but got I
		//IL_0059: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		//IL_057f: Expected O, but got I
		//IL_059a: Expected I, but got O
		//IL_00e2: Expected O, but got I4
		//IL_00eb: Expected O, but got I4
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_03f8: Expected O, but got I
		//IL_0412: Expected O, but got I4
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_0163: Expected O, but got I
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_045f: Expected O, but got I4
		//IL_01e4: Expected O, but got I4
		//IL_022e: Expected O, but got I4
		//IL_04b4: Expected O, but got I
		//IL_04ce: Expected O, but got I4
		//IL_02ab: Expected O, but got I
		//IL_050c: Expected O, but got I4
		//IL_0348: Expected O, but got I
		//IL_0374: Expected O, but got I4
		//IL_037d: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 3456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3;
		object obj7;
		object obj18;
		object obj22;
		Func<object, bool> func2;
		object obj13;
		object obj10;
		object obj19;
		object obj21;
		if (obj2 != null)
		{
			obj3 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			object obj4 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1192;
			object obj5 = (nint)0 + (nint)1264;
			object obj6 = (nint)0 + (nint)800;
			obj7 = obj2 + 16;
			obj7 = friend;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v9+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj8 = obj3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v9+B8]");
			object source = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj2, (IntPtr)obj5);
			obj10 = obj6;
			object obj11 = Enumerable.FirstOrDefault((IEnumerable<object>)source, func);
			bool flag2 = obj11 == null;
			object obj12 = !flag2;
			obj13 = 0;
			func2 = func;
			if (obj12 != null)
			{
				goto IL_039b;
			}
			if (obj7 != null)
			{
				object obj14 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v19+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6287]");
					object obj15 = (nint)0 & (nint)1;
					if (obj15 != null)
					{
						goto IL_0180;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6287]");
					object obj16 = (nint)0 & (nint)1;
					bool flag3 = obj16 == null;
					object obj17 = !flag3;
					if (obj17 != null)
					{
						goto IL_0180;
					}
				}
				_ = 1;
				obj18 = "{0} color encoding is currently unsupported for outputting to HDR." + 768;
				obj19 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v31+E4]");
				bool flag4 = (nint)0 == 0;
				object obj20 = !flag4;
				obj21 = obj19;
				obj22 = obj18;
				if (obj20 != null)
				{
					goto IL_01cc;
				}
				goto IL_047d;
			}
		}
		goto IL_0531;
		IL_047d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj18 = obj22;
		goto IL_01cc;
		IL_02c8:
		object obj23 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v50+E4]");
		bool flag5 = (nint)0 == 0;
		object obj24 = obj23;
		if (!flag5)
		{
			goto IL_02fd;
		}
		goto IL_0522;
		IL_01cc:
		string chatsDirectory = ChatsDirectory;
		object obj25 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj26 = default(object);
		string path = string.Format((string)obj18, chatsDirectory, obj26);
		bool flag6 = File.Exists(path);
		bool flag7 = !flag6;
		obj13 = 0;
		obj10 = obj26;
		func2 = null;
		if (flag7)
		{
			goto IL_039b;
		}
		if (obj7 != null)
		{
			object obj27 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v38+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6287]");
				object obj28 = (nint)0 & (nint)1;
				if (obj28 != null)
				{
					goto IL_02c8;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6287]");
				object obj29 = (nint)0 & (nint)1;
				bool flag8 = obj29 == null;
				object obj30 = !flag8;
				if (obj30 != null)
				{
					goto IL_02c8;
				}
			}
			_ = 1;
			obj23 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v292 @ X0_v50+E4]");
			bool flag9 = (nint)0 == 0;
			object obj31 = !flag9;
			obj24 = obj23;
			if (obj31 != null)
			{
				goto IL_02fd;
			}
			goto IL_0522;
		}
		goto IL_0531;
		IL_0531:
		return (FriendProfile)(object)new NullReferenceException();
		IL_0522:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_02fd;
		IL_02fd:
		string chatsDirectory2 = ChatsDirectory;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj32 = default(object);
		string path2 = string.Format((string)obj18, chatsDirectory2, obj32);
		string text = File.ReadAllText(path2);
		object obj33 = (nint)0 + (nint)2704;
		func2 = (Func<object, bool>)obj33;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9D69C");
		FriendProfile friendProfile = default(FriendProfile);
		bool flag10 = friendProfile == null;
		object obj34 = !flag10;
		obj13 = 0;
		obj10 = obj32;
		FriendProfile result = friendProfile;
		if (obj34 == null)
		{
			goto IL_039b;
		}
		goto IL_03d3;
		IL_039b:
		object obj35 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		FriendProfile friendProfile2 = default(FriendProfile);
		friendProfile2..ctor((Friend)obj7);
		result = friendProfile2;
		goto IL_03d3;
		IL_03d3:
		return result;
		IL_0180:
		obj18 = "{0} color encoding is currently unsupported for outputting to HDR." + 768;
		obj19 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X0_v31+E4]");
		bool flag11 = (nint)0 == 0;
		obj21 = obj19;
		obj22 = obj18;
		if (!flag11)
		{
			goto IL_01cc;
		}
		goto IL_047d;
	}

	public static void Logout()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00b2: Expected O, but got I4
		object obj = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61CA]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = obj3;
			if (!flag)
			{
				goto IL_007c;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			object obj4 = obj3;
			if (obj5 != null)
			{
				goto IL_007c;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		SaveProfiles();
		return;
		IL_007c:
		SaveProfiles();
	}

	public static void SaveProfiles()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0c0f: Expected O, but got I4
		//IL_0c1a: Expected O, but got I4
		//IL_0c2d: Expected O, but got I4
		//IL_00ab: Expected O, but got I
		//IL_007a: Expected O, but got I4
		//IL_008d: Expected O, but got I4
		//IL_0c5d: Expected O, but got I
		//IL_0c7f: Expected O, but got I4
		//IL_00dd: Expected O, but got I
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_010d: Expected O, but got I4
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0bc7: Expected O, but got I4
		//IL_0bd0: Expected O, but got I4
		//IL_0bd9: Expected O, but got I4
		//IL_0f98: Expected O, but got I
		//IL_0fc3: Expected O, but got I4
		//IL_0144: Expected O, but got I4
		//IL_014d: Expected O, but got I4
		//IL_0171: Expected O, but got I
		//IL_018b: Expected O, but got I4
		//IL_0331: Expected O, but got I4
		//IL_01f1: Expected O, but got I
		//IL_0de8: Expected O, but got I4
		//IL_0218: Expected O, but got I4
		//IL_022e: Expected O, but got I
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected I4, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_03c8: Expected O, but got I4
		//IL_05fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0601: Expected O, but got Unknown
		//IL_06ad: Expected O, but got I
		//IL_06bd: Expected O, but got I
		//IL_06df: Expected O, but got I4
		//IL_06e7: Expected I, but got O
		//IL_03fc: Expected O, but got I
		//IL_063e: Expected O, but got I
		//IL_064e: Expected O, but got I
		//IL_0670: Expected O, but got I4
		//IL_0678: Expected I, but got O
		//IL_042b: Expected O, but got I4
		//IL_0705: Expected O, but got I
		//IL_0727: Expected O, but got I4
		//IL_07a0: Expected O, but got I
		//IL_0edd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee2: Expected O, but got Unknown
		//IL_0ef8: Expected O, but got I
		//IL_0f00: Expected I, but got O
		//IL_0f11: Expected I, but got O
		//IL_0f2f: Expected O, but got I
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected O, but got Unknown
		//IL_045b: Expected O, but got I
		//IL_0470: Expected O, but got I
		//IL_0768: Expected O, but got I
		//IL_0779: Expected O, but got I4
		//IL_0757: Expected O, but got I
		//IL_0521: Expected O, but got I
		//IL_0531: Expected O, but got I
		//IL_0553: Expected O, but got I4
		//IL_055c: Expected O, but got I4
		//IL_0e02: Expected O, but got I
		//IL_04b1: Expected O, but got I
		//IL_04c1: Expected O, but got I
		//IL_04e3: Expected O, but got I4
		//IL_04ec: Expected O, but got I4
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Expected O, but got Unknown
		//IL_057a: Expected O, but got I
		//IL_059c: Expected O, but got I4
		//IL_0846: Expected O, but got I
		//IL_0e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e55: Expected O, but got Unknown
		//IL_0e6b: Expected O, but got I
		//IL_0e7c: Expected I, but got O
		//IL_0e9a: Expected O, but got I
		//IL_05dd: Expected O, but got I
		//IL_05ee: Expected O, but got I4
		//IL_05cc: Expected O, but got I
		//IL_0aa7: Expected O, but got I
		//IL_0ad1: Expected O, but got I4
		//IL_0f70: Expected O, but got I4
		//IL_08cd: Expected O, but got I
		//IL_0b57: Expected O, but got I4
		//IL_0944: Expected O, but got I4
		//IL_0958: Expected O, but got I4
		//IL_0997: Unknown result type (might be due to invalid IL or missing references)
		//IL_099c: Expected I4, but got Unknown
		//IL_0a50: Expected O, but got I
		//IL_0a60: Expected O, but got I
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fd: Expected O, but got Unknown
		//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E628A]");
		object obj3 = (nint)0 & (nint)1;
		List<object>.Enumerator enumerator;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v191+E4]");
			bool flag = (nint)0 == 0;
			enumerator = (List<object>.Enumerator)0;
			object obj5 = obj4;
			enumerator = (List<object>.Enumerator)0;
			if (!flag)
			{
				goto IL_009b;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v191+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			enumerator = (List<object>.Enumerator)0;
			object obj5 = obj4;
			enumerator = (List<object>.Enumerator)0;
			if (obj6 != null)
			{
				goto IL_009b;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v20+B8]");
		object obj8 = 0;
		List<object> list = (List<object>)obj8;
		bool flag3 = obj8 == null;
		object obj9 = !flag3;
		if (obj9 != null)
		{
			goto IL_00d0;
		}
		goto IL_0c8e;
		IL_0c9d:
		throw new NullReferenceException();
		IL_00d0:
		object obj10 = (nint)0 + (nint)928;
		object obj11 = typeof(DebugUI.BitField) + 3264;
		List<object>.Enumerator enumerator2 = list.GetEnumerator();
		object obj12 = 153100288 + 1024;
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 768;
		object obj14 = default(object);
		bool flag7 = default(bool);
		bool flag9 = default(bool);
		int num2 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		bool flag11 = default(bool);
		bool flag13 = default(bool);
		object obj18 = default(object);
		object obj20 = default(object);
		object obj26 = default(object);
		object obj30 = default(object);
		object obj39 = default(object);
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		object[] array = default(object[]);
		Comparison<object> comparison = default(Comparison<object>);
		IEnumerable<object> source = default(IEnumerable<object>);
		object arg = default(object);
		Func<object, int> func2 = default(Func<object, int>);
		List<object> list6 = default(List<object>);
		while (true)
		{
			object obj13 = obj10;
			bool flag6;
			bool flag8;
			int num;
			int num3;
			int num5;
			bool flag10;
			bool flag12;
			object obj17;
			object obj19;
			string path;
			object obj28;
			object obj33;
			List<object>.Enumerator enumerator3;
			object second;
			Func<object, int> func;
			object obj27;
			if (enumerator.MoveNext())
			{
				bool flag4 = obj14 == null;
				enumerator3 = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				enumerator = (List<object>.Enumerator)0;
				if (flag4)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ stack_-88 (System.Object)+70]");
				object obj15 = (nint)0 & (nint)1;
				bool flag5 = obj15 == null;
				object obj16 = !flag5;
				flag6 = flag7;
				flag8 = flag9;
				num = num2;
				num3 = num4;
				num5 = num6;
				flag10 = flag11;
				flag12 = flag13;
				obj17 = obj18;
				obj19 = obj20;
				if (obj16 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ stack_-88 (System.Object)+58]");
					object obj21 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v93+18]");
					bool flag14 = (nint)0 < (nint)2;
					obj19 = !flag14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v93+18]");
					obj17 = -2;
					flag12 = (nint)obj17 < 0;
					flag10 = obj17 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v93+18]");
					num5 = (int)((nint)0 ^ (nint)2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v93+18]");
					num3 = 0 ^ obj17;
					num = num5 & num3;
					flag8 = num < 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v93+18]");
					flag6 = (nint)0 < (nint)2;
					flag7 = flag6;
					flag9 = flag8;
					num2 = num;
					num4 = num3;
					num6 = num5;
					flag11 = flag10;
					flag13 = flag12;
					obj18 = obj17;
					obj20 = obj19;
					if (flag6)
					{
						continue;
					}
				}
				_ = 0;
				object obj22 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v94+E4]");
				bool flag15 = (nint)0 == 0;
				object obj23 = !flag15;
				if (obj23 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj24 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v98+E4]");
				bool flag16 = (nint)0 == 0;
				object obj25 = !flag16;
				if (obj25 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				string chatsDirectory = ChatsDirectory;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format2 = "{0} color encoding is currently unsupported for outputting to HDR." + 760;
				path = string.Format((string)format2, chatsDirectory, obj26);
				bool flag17 = File.Exists(path);
				bool flag18 = !flag17;
				obj27 = 0;
				obj28 = obj26;
				obj13 = null;
				if (!flag18)
				{
					string text = File.ReadAllText(path);
					object obj29 = (nint)0 + (nint)2704;
					obj13 = obj29;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9D69C");
					bool flag19 = obj30 == null;
					obj27 = 0;
					obj28 = obj26;
					if (!flag19)
					{
						second = obj14 + 88;
						object obj31 = (nint)0 + (nint)3024;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X0_v163+58]");
						IEnumerable<object> enumerable = Enumerable.Union((IEnumerable<object>)0, (IEnumerable<object>)second);
						object obj32 = obj11;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v173+E4]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v173+B8]");
							obj33 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v82+A0]");
							func = (Func<object, int>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v82+A0]");
							bool flag20 = (nint)0 == 0;
							object obj34 = !flag20;
							obj27 = 0;
							if (obj34 == null)
							{
								goto IL_056a;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							obj32 = obj11;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v173+B8]");
							obj33 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v82+A0]");
							func = (Func<object, int>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v708 @ X8_v82+A0]");
							bool flag21 = (nint)0 == 0;
							object obj35 = !flag21;
							obj27 = 0;
							if (obj35 == null)
							{
								goto IL_056a;
							}
						}
						goto IL_0df6;
					}
				}
				goto IL_05f3;
			}
			enumerator3 = enumerator4;
			enumerator4 = (List<object>.Enumerator)0;
			List<object>.Enumerator enumerator5 = (List<object>.Enumerator)0;
			object obj36 = 0;
			while (true)
			{
				object obj37 = (nint)0 + (nint)920;
				obj13 = obj37;
				enumerator5.Dispose();
				bool flag22 = obj36 == null;
				object obj38 = !flag22;
				if (obj38 == null)
				{
					return;
				}
				OutOfMemoryException ex = new OutOfMemoryException();
				if ((nint)obj13 != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj36 = obj39;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				enumerator4 = (List<object>.Enumerator)obj39;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2237800");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_06f5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v151+E4]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v151+E4]");
			bool flag23 = (nint)0 == 0;
			object obj40 = !flag23;
			object obj42;
			if (obj40 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj41 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v67+B8]");
				obj42 = 0;
			}
			object obj43 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3424;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj44 = (nint)0 + (nint)944;
			nint num7 = (nint)obj44;
			comparison..ctor(obj42, (IntPtr)obj44);
			object obj45 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v66+B8]");
			object obj46 = (nint)0 + (nint)168;
			obj46 = comparison;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = (nint)0 + (nint)928;
			Comparison<object> comparison2 = comparison;
			obj27 = 0;
			obj13 = comparison;
			goto IL_0eb1;
			IL_0df6:
			object obj47 = (nint)0 + (nint)1928;
			obj28 = obj47;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C94D6C");
			List<object> list2 = Enumerable.ToList(source);
			second = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj13 = list2;
			goto IL_05f3;
			IL_0a97:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ stack_-88 (System.Object)+10]");
			List<object> list3 = (List<object>)0;
			object obj48 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X0_v125+E4]");
			bool flag24 = (nint)0 == 0;
			object obj49 = !flag24;
			if (obj49 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj50 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v800 @ X0_v129+E4]");
			bool flag25 = (nint)0 == 0;
			object obj51 = !flag25;
			if (obj51 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			string chatsDirectory2 = ChatsDirectory;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			string path2 = string.Format((string)format, chatsDirectory2, arg);
			string contents = JsonUtility.ToJson(obj14);
			File.WriteAllText(path2, contents);
			obj27 = 0;
			num7 = 0;
			List<object> list4 = list3;
			flag7 = flag6;
			flag9 = flag8;
			num2 = num;
			num4 = num3;
			num6 = num5;
			flag11 = flag10;
			flag13 = flag12;
			obj18 = obj17;
			obj20 = obj19;
			continue;
			IL_05f3:
			list3 = (List<object>)(obj14 + 88);
			object obj52 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v151+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v151+B8]");
				obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v61+A8]");
				comparison2 = (Comparison<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v61+A8]");
				bool flag26 = (nint)0 == 0;
				object obj53 = !flag26;
				num7 = (nint)obj28;
				if (obj53 == null)
				{
					goto IL_06f5;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj52 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v615 @ X0_v151+B8]");
				obj42 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v61+A8]");
				comparison2 = (Comparison<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v632 @ X8_v61+A8]");
				bool flag27 = (nint)0 == 0;
				object obj54 = !flag27;
				num7 = (nint)obj28;
				if (obj54 == null)
				{
					goto IL_06f5;
				}
			}
			goto IL_0eb1;
			IL_056a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v173+E4]");
			array = (object[])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v695 @ X0_v173+E4]");
			bool flag28 = (nint)0 == 0;
			object obj55 = !flag28;
			if (obj55 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj56 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v88+B8]");
				obj33 = 0;
			}
			object obj57 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj58 = (nint)0 + (nint)952;
			func2..ctor(obj33, (IntPtr)obj58);
			object obj59 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v679 @ X8_v87+B8]");
			object obj60 = (nint)0 + (nint)160;
			obj60 = func2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = (nint)0 + (nint)928;
			func = func2;
			obj27 = 0;
			goto IL_0df6;
			IL_0eb1:
			if (list3 != null)
			{
				list3.Sort(comparison2);
				object obj61 = (nint)0 + (nint)3032;
				IEnumerable<object> source2 = ArraysExtensions.TakeLast(list3, 200);
				List<object> list5 = Enumerable.ToList(source2);
				list3 = list5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				string contents2 = JsonUtility.ToJson(obj14);
				File.WriteAllText(path, contents2);
				object obj62 = typeof(List<AdaptivePerformanceScaler>) + 2728;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				list6..ctor();
				list3 = list6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj63 = (nint)0 + (nint)2320;
				object obj64 = obj63;
				bool flag29 = Enumerable.Any(list3);
				bool flag30 = !flag29;
				nint num8 = 0;
				if (!flag30)
				{
					List<object> list7 = list3;
					object obj65 = Enumerable.Last(list3);
					bool flag31 = list3 == null;
					object[] array2 = array;
					if (!flag31)
					{
						object obj66 = (nint)0 + (nint)2176;
						object obj67 = obj66;
						int version = list7._version + 1;
						list7._version = version;
						array2 = list7._items;
						if (list7._items != null)
						{
							bool flag32 = list7._size < array2.Length;
							obj19 = !flag32;
							obj17 = list7._size - array2.Length;
							flag12 = (nint)obj17 < 0;
							flag10 = obj17 == null;
							num5 = list7._size ^ array2.Length;
							num3 = list7._size ^ obj17;
							num = num5 & num3;
							flag8 = num < 0;
							if (obj19 == null)
							{
								int size = list7._size + 1;
								list7._size = size;
								object obj68 = list7._items + list7._size;
								object obj69 = obj68 + 32;
								obj69 = obj65;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								num8 = 0;
								array = list7._items;
								obj64 = obj65;
							}
							else
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v785 @ X8_v56+20]");
								object obj70 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v804 @ X8_v57+C0]");
								object obj71 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X8_v58+70]");
								num8 = 0;
								list3.AddWithResize(obj65);
								array = list7._items;
								obj64 = obj65;
							}
							goto IL_0a97;
						}
					}
					throw new NullReferenceException();
				}
				goto IL_0a97;
			}
			throw new NullReferenceException();
		}
		goto IL_0c9d;
		IL_0c8e:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0c9d;
		IL_009b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v191+B8]");
		object obj72 = 0;
		list = (List<object>)obj72;
		if (obj72 != null)
		{
			goto IL_00d0;
		}
		goto IL_0c8e;
	}

	public static void DeleteChatHistory(int userId)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e3: Expected O, but got I4
		//IL_00a4: Expected O, but got I4
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0301: Expected O, but got I
		//IL_031b: Expected O, but got I4
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_01bb: Expected O, but got I
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Expected O, but got Unknown
		//IL_0368: Expected O, but got I4
		//IL_023c: Expected O, but got I4
		//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ac: Expected O, but got Unknown
		//IL_03d6: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E628B]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v47+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v47+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		FriendProfile profile = GetProfile(userId);
		if (profile == null)
		{
			return;
		}
		goto IL_012a;
		IL_01d8:
		object obj6 = "{0} color encoding is currently unsupported for outputting to HDR." + 760;
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v18+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = obj6;
		object obj9 = obj7;
		if (!flag2)
		{
			goto IL_0224;
		}
		goto IL_0386;
		IL_0386:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj6 = obj8;
		goto IL_0224;
		IL_0224:
		string chatsDirectory = ChatsDirectory;
		object obj10 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg = default(object);
		string path = string.Format((string)obj6, chatsDirectory, arg);
		string contents = JsonUtility.ToJson(profile);
		File.WriteAllText(path, contents);
		object format = "{0} color encoding is currently unsupported for outputting to HDR." + 768;
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v224 @ X0_v29+E4]");
		bool flag3 = (nint)0 == 0;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string chatsDirectory2 = ChatsDirectory;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object arg2 = default(object);
		string path2 = string.Format((string)format, chatsDirectory2, arg2);
		string contents2 = JsonUtility.ToJson(profile);
		File.WriteAllText(path2, contents2);
		return;
		IL_007d:
		profile = GetProfile(userId);
		bool flag4 = profile == null;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			return;
		}
		goto IL_012a;
		IL_012a:
		object obj14 = typeof(List<AdaptivePerformanceScaler>) + 2728;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj15 = profile + 88;
		obj15 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6288]");
			object obj17 = (nint)0 & (nint)1;
			if (obj17 != null)
			{
				goto IL_01d8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6288]");
			object obj18 = (nint)0 & (nint)1;
			bool flag5 = obj18 == null;
			object obj19 = !flag5;
			if (obj19 != null)
			{
				goto IL_01d8;
			}
		}
		_ = 1;
		obj6 = "{0} color encoding is currently unsupported for outputting to HDR." + 760;
		obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v18+E4]");
		bool flag6 = (nint)0 == 0;
		object obj20 = !flag6;
		obj8 = obj6;
		obj9 = obj7;
		if (obj20 != null)
		{
			goto IL_0224;
		}
		goto IL_0386;
	}

	private static void CleanLocalChats()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0159: Expected O, but got I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a9: Expected O, but got I
		//IL_00b9: Expected O, but got I
		//IL_020f: Expected O, but got I4
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_01a5: Expected O, but got I
		//IL_01b5: Expected O, but got I
		//IL_01d7: Expected O, but got I4
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bd: Expected O, but got Unknown
		//IL_02d3: Expected O, but got I
		//IL_02e4: Expected I, but got O
		//IL_0302: Expected O, but got I
		//IL_026e: Expected O, but got I4
		//IL_023f: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(DebugUI.BitField) + 3264;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61CB]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v4+B8]");
		Action action = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v4+B8]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		object obj10 = obj7;
		if (obj9 != null)
		{
			goto IL_00e6;
		}
		goto IL_01ed;
		IL_00e6:
		object obj11 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v1+E4]");
		bool flag4 = (nint)0 == 0;
		Action action2 = action;
		if (!flag4)
		{
			goto IL_011b;
		}
		goto IL_028c;
		IL_028c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Task task = Task.Run(action2);
		return;
		IL_011b:
		Task task2 = Task.Run(action);
		return;
		IL_0085:
		obj7 = typeof(System.Formats.Asn1.SetOfValueComparer) + 3912;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v4+B8]");
		action = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v4+B8]");
		bool flag5 = (nint)0 == 0;
		obj10 = obj7;
		if (!flag5)
		{
			goto IL_00e6;
		}
		goto IL_01ed;
		IL_01ed:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v5+E4]");
		bool flag6 = (nint)0 == 0;
		object obj12 = !flag6;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj13 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v11+B8]");
			obj8 = 0;
		}
		object obj14 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj15 = (nint)0 + (nint)856;
		Action action3 = default(Action);
		action3..ctor(obj8, (IntPtr)obj15);
		object obj16 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v9+B8]");
		object obj17 = (nint)0 + (nint)184;
		obj17 = action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v1+E4]");
		bool flag7 = (nint)0 == 0;
		object obj18 = !flag7;
		action = action3;
		action2 = action3;
		if (obj18 != null)
		{
			goto IL_011b;
		}
		goto IL_028c;
	}

	public unsafe static List<ChatMessageData> GetMessages(FriendProfile friendProfile)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0487: Expected O, but got I
		//IL_04a1: Expected O, but got I4
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00af: Expected O, but got I
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_04ee: Expected O, but got I4
		//IL_0124: Expected O, but got I
		//IL_013c: Expected O, but got I4
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0286: Expected O, but got I
		//IL_02b0: Expected O, but got I4
		//IL_01b1: Expected O, but got I
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_0314: Expected O, but got I
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_0214: Expected O, but got I
		//IL_0231: Expected O, but got I
		//IL_0884: Expected I8, but got I
		//IL_0543: Expected O, but got I4
		//IL_03ea: Expected O, but got I
		//IL_03ff: Expected I8, but got I
		//IL_05a3: Expected O, but got I
		//IL_043b: Expected O, but got I4
		//IL_0454: Expected I8, but got O
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected O, but got Unknown
		//IL_05d8: Expected O, but got I
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected O, but got Unknown
		//IL_0622: Expected O, but got I
		//IL_076a: Expected O, but got I
		//IL_077a: Expected O, but got I
		//IL_079c: Expected O, but got I4
		//IL_06b7: Expected O, but got I
		//IL_0663: Expected O, but got I
		//IL_0673: Expected O, but got I
		//IL_07cc: Expected O, but got I4
		//IL_06d1: Expected O, but got I
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected O, but got Unknown
		//IL_06f1: Expected O, but got I
		//IL_08b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Expected O, but got Unknown
		//IL_08d3: Expected O, but got I
		//IL_08e4: Expected I, but got O
		//IL_0902: Expected O, but got I
		//IL_0720: Expected I, but got O
		//IL_081b: Expected O, but got I4
		//IL_07fc: Expected O, but got I
		object obj = typeof(DebugUI.BitField) + 3472;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3;
		object obj4;
		object obj9;
		object obj12;
		object obj10;
		object obj13;
		if (obj2 != null)
		{
			obj3 = obj2 + 16;
			obj3 = friendProfile;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			if (obj3 != null)
			{
				obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
				object obj5 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v208 @ X0_v8+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6288]");
					object obj6 = (nint)0 & (nint)1;
					if (obj6 != null)
					{
						goto IL_00cc;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6288]");
					object obj7 = (nint)0 & (nint)1;
					bool flag = obj7 == null;
					object obj8 = !flag;
					if (obj8 != null)
					{
						goto IL_00cc;
					}
				}
				_ = 1;
				obj9 = "{0} color encoding is currently unsupported for outputting to HDR." + 760;
				obj10 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v20+E4]");
				bool flag2 = (nint)0 == 0;
				object obj11 = !flag2;
				obj12 = obj9;
				obj13 = obj10;
				if (obj11 != null)
				{
					goto IL_0118;
				}
				goto IL_050c;
			}
		}
		goto IL_0836;
		IL_0118:
		object obj14 = (nint)0 + (nint)2512;
		string chatsDirectory = ChatsDirectory;
		object obj15 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object obj16 = default(object);
		string path = string.Format((string)obj9, chatsDirectory, obj16);
		bool flag3 = File.Exists(path);
		bool flag4 = !flag3;
		object obj17 = obj16;
		List<object> list = null;
		if (!flag4)
		{
			string text = File.ReadAllText(path);
			object obj18 = (nint)0 + (nint)2704;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E9D69C");
			object obj19 = default(object);
			if (obj3 == null || obj19 == null)
			{
				goto IL_0836;
			}
			object obj20 = obj3 + 88;
			object obj21 = (nint)0 + (nint)3024;
			obj17 = obj21;
			object first = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v74+58]");
			IEnumerable<object> source = Enumerable.Union((IEnumerable<object>)first, (IEnumerable<object>)0);
			List<object> list2 = Enumerable.ToList(source);
			obj20 = list2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			list = list2;
		}
		object obj22 = typeof(Queue<string>) + 848;
		object obj23 = (nint)0 + (nint)2200;
		object obj24 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X0_v28+E4]");
		bool flag5 = (nint)0 == 0;
		object obj25 = !flag5;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		object message;
		string userId;
		DateTime? dateTime3;
		ChatInk chatInk;
		if ((object)sessionModel != null)
		{
			object obj26 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 888;
			message = (nint)0 + (nint)2000;
			User localUser = sessionModel.LocalUser;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			ChatMessageData chatMessageData = default(ChatMessageData);
			chatMessageData..ctor((string)message, localUser);
			object obj27 = obj2 + 32;
			obj27 = chatMessageData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X21_v12-10]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X21_v12-10]");
				int num = (int)((nint)0 + (nint)16);
				userId = ((int*)num)->ToString();
				object obj28 = obj3;
				if (obj3 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X23_v8+50]");
					long num2 = 0L;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X23_v8+50]");
					if ((nint)0 != 0)
					{
						object obj29 = (nint)0 + (nint)2264;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X23_v8+50]");
						DateTime dateTime = new DateTime(0L);
						User user = (User)obj29;
						DateTime? dateTime2 = dateTime;
						object obj30 = obj3;
						bool flag6 = obj3 == null;
						object obj31 = !flag6;
						dateTime3 = dateTime2;
						chatInk = ChatInk.Clean;
						num2 = (long)dateTime;
						if (obj31 != null)
						{
							goto IL_0562;
						}
					}
					else
					{
						object obj30 = obj3;
						bool flag7 = obj3 == null;
						dateTime3 = (DateTime?)(object)0;
						User user = localUser;
						chatInk = ChatInk.Clean;
						if (!flag7)
						{
							goto IL_0562;
						}
					}
				}
			}
		}
		goto IL_0836;
		IL_0836:
		return (List<ChatMessageData>)(object)new NullReferenceException();
		IL_06c5:
		object obj32 = (nint)0 + (nint)2192;
		object obj33 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2752;
		object obj34 = (nint)0 + (nint)1280;
		List<object> list3;
		Comparison<object> comparison;
		list3.Sort(comparison);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj2, (IntPtr)obj34);
		IEnumerable<object> source2 = Enumerable.Select(list3, func);
		return (List<ChatMessageData>)(object)Enumerable.ToList(source2);
		IL_0562:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X23_v8+18]");
		nint num3 = 0;
		DateTime? avatarDate = dateTime3;
		ChatInk inkId = chatInk;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v21+41]");
		ChatMessageData chatMessageData2 = default(ChatMessageData);
		chatMessageData2..ctor((string)message, userId, (string)num3, avatarDate, inkId);
		object obj35 = obj2 + 24;
		obj35 = chatMessageData2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X20_v8-8]");
		object obj36 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X20_v8-8]");
		string text2;
		if ((nint)0 != 0)
		{
			object obj37 = typeof(DebugUI.BitField) + 3264;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v22+58]");
			list3 = Enumerable.ToList((IEnumerable<object>)0);
			object obj38 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v48+E4]");
			object obj39;
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v48+B8]");
				obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v25+C0]");
				comparison = (Comparison<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v25+C0]");
				if ((nint)0 != 0)
				{
					goto IL_0698;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj38 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v48+B8]");
				obj39 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v25+C0]");
				comparison = (Comparison<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v25+C0]");
				bool flag8 = (nint)0 == 0;
				object obj40 = !flag8;
				if (obj40 != null)
				{
					goto IL_0698;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X0_v48+E4]");
			bool flag9 = (nint)0 == 0;
			object obj41 = !flag9;
			if (obj41 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj42 = obj37;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X8_v31+B8]");
				obj39 = 0;
			}
			object obj43 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3424;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj44 = (nint)0 + (nint)872;
			Comparison<object> comparison2 = default(Comparison<object>);
			comparison2..ctor(obj39, (IntPtr)obj44);
			object obj45 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v30+B8]");
			object obj46 = (nint)0 + (nint)192;
			obj46 = comparison2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag10 = list3 == null;
			object obj47 = !flag10;
			text2 = null;
			comparison = comparison2;
			if (obj47 != null)
			{
				goto IL_06c5;
			}
		}
		goto IL_0836;
		IL_0698:
		bool flag11 = list3 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X23_v8+18]");
		text2 = (string)0;
		if (!flag11)
		{
			goto IL_06c5;
		}
		goto IL_0836;
		IL_00cc:
		obj9 = "{0} color encoding is currently unsupported for outputting to HDR." + 760;
		obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X0_v20+E4]");
		bool flag12 = (nint)0 == 0;
		obj12 = obj9;
		obj13 = obj10;
		if (!flag12)
		{
			goto IL_0118;
		}
		goto IL_050c;
		IL_050c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj9 = obj12;
		goto IL_0118;
	}

	public static void ResetModels()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_013b: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00b8: Expected O, but got I
		//IL_0173: Expected O, but got I
		//IL_0195: Expected O, but got I4
		//IL_010a: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E61CC]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v16+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v16+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj7 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v6+B8]");
		object obj8 = 0;
		object obj9 = obj8;
		bool flag3 = obj8 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a2;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X0_v16+B8]");
		object obj11 = 0;
		obj9 = obj11;
		goto IL_00a2;
		IL_00a2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v9+1C]");
		object obj12 = (nint)0 + (nint)1;
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v9+18]");
		if ((nint)0 >= (nint)1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v9+10]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v9+18]");
			Array.Clear((Array)num, 0, 0);
		}
	}

	static FriendsManager()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0078: Expected O, but got I
		object obj = typeof(List<AdaptivePerformanceScaler>) + 1120;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj3 = typeof(MemberAchievementClanFeedData) + 3440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list = default(List<object>);
		list..ctor();
		object obj4 = obj2;
		object obj5 = list;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		OneShotEvent oneShotEvent = default(OneShotEvent);
		oneShotEvent..ctor();
		object obj6 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+B8]");
		object obj7 = (nint)0 + (nint)8;
		obj7 = oneShotEvent;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
