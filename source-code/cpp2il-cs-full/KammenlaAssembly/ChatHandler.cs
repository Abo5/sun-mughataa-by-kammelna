using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Features.Clans;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Server.Models;
using Sfs2X.Entities;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Rendering;
using UnityEngine.TextCore;

public class ChatHandler : Singleton<ChatHandler>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<ChatMessageData, bool> <>9__47_0;

		public static Func<string, int> <>9__50_0;

		public static Func<KeyValuePair<string, string>, string> <>9__52_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(CardUtils.<>c) + 328;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <GetMessages>b__47_0(ChatMessageData m)
		{
			//IL_0179: Expected I4, but got O
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			//IL_007c: Expected O, but got I
			//IL_012f: Expected O, but got I4
			string <UserId>k__BackingField;
			if (m != null)
			{
				if (PlayerUtilities.IsPlayer(m.<UserId>k__BackingField))
				{
					return true;
				}
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FC6]");
				object obj2 = (nint)0 & (nint)1;
				string <UserId>k__BackingField2;
				if (obj2 != null)
				{
					<UserId>k__BackingField = m.<UserId>k__BackingField;
					object obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v4+E4]");
					bool flag = (nint)0 == 0;
					<UserId>k__BackingField2 = m.<UserId>k__BackingField;
					if (!flag)
					{
						goto IL_00e0;
					}
				}
				else
				{
					_ = 1;
					<UserId>k__BackingField = m.<UserId>k__BackingField;
					object obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v4+E4]");
					bool flag2 = (nint)0 == 0;
					object obj4 = !flag2;
					<UserId>k__BackingField2 = m.<UserId>k__BackingField;
					if (obj4 != null)
					{
						goto IL_00e0;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				return StringsExtensions.IsNullOrEmpty(<UserId>k__BackingField2);
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_00e0:
			return StringsExtensions.IsNullOrEmpty(<UserId>k__BackingField);
		}

		internal int <GetChatText>b__50_0(string g)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3+B8]");
			object obj3 = 0;
			bool flag = g == (string)obj3;
			return (flag ? 1 : 0) ^ 1;
		}

		internal string <GetChatUsersInfoString>b__52_0(KeyValuePair<string, string> usersInfoIterator)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Expected O, but got Unknown
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_0038: Expected O, but got I
			object obj = "com.unity.services.authentication.profile" + 3288;
			object obj2 = ", stale={0}" + 32;
			IntPtr intPtr = default(IntPtr);
			return (string)obj + (string)usersInfoIterator + (string)obj2 + (string)(nint)intPtr;
		}
	}

	private sealed class <>c__DisplayClass64_0
	{
		public string userId;

		internal bool <OnUserBlocked>b__0(ChatMessageData data)
		{
			//IL_0048: Expected I4, but got O
			if (data != null)
			{
				return data.<UserId>k__BackingField == userId;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public const string PublicChatGroupTag = "الدردشة_العامة";

	public const string OnlyForSubscribers = "Only for Subscribers";

	public const int MaxMessagesPerChannel = 200;

	private readonly Dictionary<string, List<ChatMessageData>> _allMessagesList;

	private int _unreadCounter;

	private bool _chatActive;

	private int _clanUnreadCounter;

	private bool _clanChatActive;

	private static string _activeGroup;

	private static bool IsChatDisabled
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_017c: Expected I4, but got O
			//IL_01b4: Expected O, but got I4
			//IL_0238: Expected I4, but got O
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6F9F]");
			object obj3 = (nint)0 & (nint)1;
			object obj6;
			object obj4;
			if (obj3 != null)
			{
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			obj4 = obj6;
			if (!flag3)
			{
				goto IL_0158;
			}
			goto IL_022a;
			IL_022a:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0158:
			Room currentRoom = sessionModel.CurrentRoom;
			bool flag4 = currentRoom == null;
			bool result = (byte)(int)currentRoom != 0;
			if (!flag4)
			{
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				if ((object)sessionModel2 == null)
				{
					goto IL_022a;
				}
				Room currentRoom2 = sessionModel2.CurrentRoom;
				bool flag6 = SFSKammelnaRoomExtensions.IsChatEnabled(currentRoom2);
				result = (byte)((flag6 ? 1u : 0u) ^ 1u) != 0;
			}
			return result;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag7 = (object)sessionModel == null;
			object obj10 = !flag7;
			if (obj10 != null)
			{
				goto IL_0158;
			}
			goto IL_022a;
		}
	}

	public static bool IsChatRoom
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00da: Expected O, but got I
			//IL_0104: Expected O, but got I4
			//IL_00b5: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_017c: Expected I4, but got O
			//IL_01b4: Expected O, but got I4
			//IL_0238: Expected I4, but got O
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FA0]");
			object obj3 = (nint)0 & (nint)1;
			object obj6;
			object obj4;
			if (obj3 != null)
			{
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
				bool flag = (nint)0 == 0;
				obj6 = obj4;
				if (!flag)
				{
					goto IL_0091;
				}
			}
			else
			{
				_ = 1;
				obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v14+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0091;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			obj4 = obj6;
			if (!flag3)
			{
				goto IL_0158;
			}
			goto IL_022a;
			IL_022a:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0158:
			Room currentRoom = sessionModel.CurrentRoom;
			bool flag4 = currentRoom == null;
			bool result = (byte)(int)currentRoom != 0;
			if (!flag4)
			{
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v6+E4]");
				bool flag5 = (nint)0 == 0;
				object obj9 = !flag5;
				if (obj9 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				if ((object)sessionModel2 == null)
				{
					goto IL_022a;
				}
				Room currentRoom2 = sessionModel2.CurrentRoom;
				bool flag6 = SFSKammelnaRoomExtensions.IsLobby(currentRoom2);
				result = (byte)((flag6 ? 1u : 0u) ^ 1u) != 0;
			}
			return result;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag7 = (object)sessionModel == null;
			object obj10 = !flag7;
			if (obj10 != null)
			{
				goto IL_0158;
			}
			goto IL_022a;
		}
	}

	private static bool IsModerator
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00f3: Expected O, but got I
			//IL_011d: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0182: Expected I4, but got O
			//IL_0166: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 848;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FA1]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)2200;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			goto IL_0174;
			IL_00b8:
			User localUser = sessionModel.LocalUser;
			return SFSKammelnaUserExtensions.Can(localUser, UserPermission.KickAndMutePlayers);
			IL_0174:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if ((object)sessionModel != null)
			{
				goto IL_00b8;
			}
			goto IL_0174;
		}
	}

	private static bool IsPublicChatSubsLocked
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			//IL_0164: Expected I4, but got O
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FA2]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v5+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			if (current != null)
			{
				goto IL_011d;
			}
			goto IL_0156;
			IL_0156:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_011d:
			ChatConfig <Chat>k__BackingField = current.<Chat>k__BackingField;
			if (current.<Chat>k__BackingField != null)
			{
				return <Chat>k__BackingField.<IsPublicChatSubsLocked>k__BackingField;
			}
			goto IL_0156;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag2 = current == null;
			object obj5 = !flag2;
			if (obj5 != null)
			{
				goto IL_011d;
			}
			goto IL_0156;
		}
	}

	public static bool CanSend
	{
		get
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Expected O, but got Unknown
			//IL_007d: Expected O, but got I4
			//IL_00a6: Expected O, but got I
			//IL_08e8: Expected I4, but got O
			//IL_01db: Expected O, but got I4
			//IL_0134: Expected O, but got I4
			//IL_0243: Expected I4, but got O
			//IL_027b: Expected O, but got I4
			//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fd: Expected O, but got Unknown
			//IL_0305: Expected I, but got O
			//IL_0315: Expected O, but got I
			//IL_03cf: Expected O, but got I4
			//IL_03d8: Expected O, but got I4
			//IL_04a8: Expected O, but got I4
			//IL_0350: Expected O, but got I
			//IL_03ef: Expected O, but got I4
			//IL_0667: Expected O, but got I4
			//IL_040d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0412: Expected O, but got Unknown
			//IL_041a: Unknown result type (might be due to invalid IL or missing references)
			//IL_041f: Expected O, but got Unknown
			//IL_0428: Unknown result type (might be due to invalid IL or missing references)
			//IL_042d: Expected O, but got Unknown
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0363: Expected O, but got Unknown
			//IL_036c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0371: Expected O, but got Unknown
			//IL_0525: Expected O, but got I4
			//IL_07e4: Expected O, but got I4
			//IL_0566: Expected O, but got I4
			//IL_06e4: Expected O, but got I4
			//IL_072d: Expected O, but got I4
			//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e8: Expected O, but got Unknown
			//IL_05f0: Expected I4, but got O
			//IL_0603: Unknown result type (might be due to invalid IL or missing references)
			//IL_0608: Expected O, but got Unknown
			//IL_062f: Expected I4, but got O
			//IL_0821: Expected O, but got I4
			bool flag;
			if (IsModerator)
			{
				flag = true;
				goto IL_090e;
			}
			if (IsChatDisabled)
			{
				return false;
			}
			object obj = typeof(Queue<string>) + 848;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			User user2;
			object obj5;
			bool flag9;
			User user;
			bool flag11;
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				bool flag3 = SFSKammelnaUserExtensions.IsSubscribed(localUser);
				obj5 = obj;
				if (flag3)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v77+E4]");
					bool flag4 = (nint)0 == 0;
					object obj6 = !flag4;
					user = null;
					bool flag5 = true;
					if (obj6 == null)
					{
						goto IL_0150;
					}
					goto IL_015f;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v77+E4]");
				bool flag6 = (nint)0 == 0;
				object obj7 = !flag6;
				if (obj7 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel2 = default(SessionModel);
				if ((object)sessionModel2 != null)
				{
					Room currentRoom = sessionModel2.CurrentRoom;
					bool flag7 = currentRoom == null;
					flag = (byte)(int)currentRoom != 0;
					if (flag7)
					{
						goto IL_090e;
					}
					object obj8 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X0_v18+E4]");
					bool flag8 = (nint)0 == 0;
					object obj9 = !flag8;
					if (obj9 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel3 = default(SessionModel);
					if ((object)sessionModel3 != null)
					{
						Room currentRoom2 = sessionModel3.CurrentRoom;
						if (currentRoom2 != null)
						{
							object obj10 = typeof(RegisteredWaitHandle) + 1376;
							nint num = (nint)currentRoom2;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
							object obj11 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_0391;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v10 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
							object obj12 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X10_v9-8]");
								if (0 == (nint)obj10)
								{
									break;
								}
								obj12 += 16;
								obj11--;
								if ((nint)obj11 != 1)
								{
									continue;
								}
								goto IL_0391;
							}
							object obj13 = obj12 + 6;
							object obj14 = num + obj13;
							object obj15 = obj14 + 312;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v24+8]");
							flag9 = false;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v397 @ X8_v24] (should have been resolved before IL gen)");
							object obj16 = default(object);
							bool flag10 = obj16 == null;
							user = null;
							user2 = null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v24+8]");
							flag11 = false;
							if (!flag10)
							{
								goto IL_047e;
							}
							goto IL_063d;
						}
					}
				}
			}
			goto IL_08da;
			IL_015f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel4 = default(SessionModel);
			if ((object)sessionModel4 != null)
			{
				User localUser2 = sessionModel4.LocalUser;
				MuteStatus muteStatus = SFSKammelnaUserExtensions.GetMuteStatus(localUser2);
				return muteStatus == MuteStatus.None;
			}
			goto IL_08da;
			IL_063d:
			object obj17 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v416 @ X0_v26+E4]");
			bool flag12 = (nint)0 == 0;
			object obj18 = !flag12;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel5 = default(SessionModel);
			if ((object)sessionModel5 != null)
			{
				Room currentRoom3 = sessionModel5.CurrentRoom;
				bool flag13 = SFSKammelnaRoomExtensions.IsTournamentHub(currentRoom3);
				bool flag14 = !flag13;
				object obj19 = !flag14;
				user = user2;
				bool flag5 = false;
				if (obj19 == null)
				{
					object obj20 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v447 @ X0_v32+E4]");
					bool flag15 = (nint)0 == 0;
					object obj21 = !flag15;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel6 = default(SessionModel);
					if ((object)sessionModel6 == null)
					{
						goto IL_08da;
					}
					Room currentRoom4 = sessionModel6.CurrentRoom;
					bool flag16 = SFSKammelnaRoomExtensions.IsMassTournament(currentRoom4);
					bool flag17 = !flag16;
					user = user2;
					flag5 = false;
					if (flag17)
					{
						object obj22 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X0_v38+E4]");
						bool flag18 = (nint)0 == 0;
						object obj23 = !flag18;
						if (obj23 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
						SessionModel sessionModel7 = default(SessionModel);
						if ((object)sessionModel7 == null)
						{
							goto IL_08da;
						}
						Room currentRoom5 = sessionModel7.CurrentRoom;
						flag = SFSKammelnaRoomExtensions.IsLobby(currentRoom5);
						if (!flag)
						{
							goto IL_090e;
						}
						bool isPublicChatSubsLocked = IsPublicChatSubsLocked;
						bool flag19 = !isPublicChatSubsLocked;
						user = user2;
						flag5 = false;
						if (!flag19)
						{
							return false;
						}
					}
				}
				goto IL_07ba;
			}
			goto IL_08da;
			IL_047e:
			object obj24 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v405 @ X0_v50+E4]");
			bool flag20 = (nint)0 == 0;
			object obj25 = !flag20;
			if (obj25 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel8 = default(SessionModel);
			if ((object)sessionModel8 != null)
			{
				Room currentRoom6 = sessionModel8.CurrentRoom;
				bool flag21 = SFSKammelnaRoomExtensions.IsPrivate(currentRoom6);
				bool flag22 = !flag21;
				object obj26 = !flag22;
				bool flag5 = false;
				if (obj26 != null)
				{
					goto IL_07ba;
				}
				object obj27 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v437 @ X0_v56+E4]");
				bool flag23 = (nint)0 == 0;
				object obj28 = !flag23;
				if (obj28 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				SessionModel sessionModel9 = default(SessionModel);
				if ((object)sessionModel9 != null)
				{
					User localUser3 = sessionModel9.LocalUser;
					if (localUser3 != null)
					{
						object obj29 = typeof(UsageHint) + 8;
						flag11 = (byte)(int)obj29 != 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9DB58");
						object obj31 = default(object);
						object obj30 = obj31 & 1;
						bool flag24 = obj30 == null;
						user2 = localUser3;
						user = localUser3;
						flag5 = (byte)(int)obj29 != 0;
						if (!flag24)
						{
							goto IL_063d;
						}
						goto IL_07ba;
					}
				}
			}
			goto IL_08da;
			IL_0150:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			goto IL_015f;
			IL_08da:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_07ba:
			obj5 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X0_v77+E4]");
			bool flag25 = (nint)0 == 0;
			object obj32 = !flag25;
			if (obj32 == null)
			{
				goto IL_0150;
			}
			goto IL_015f;
			IL_0391:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v65+8]");
			flag9 = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v364 @ X0_v65] (should have been resolved before IL gen)");
			object obj33 = default(object);
			bool flag26 = obj33 == null;
			object obj34 = !flag26;
			user = (User)6;
			if (obj34 != null)
			{
				goto IL_047e;
			}
			user2 = (User)6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X0_v65+8]");
			flag11 = false;
			goto IL_063d;
			IL_090e:
			return flag;
		}
	}

	public unsafe static string MuteReason
	{
		get
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			//IL_0063: Expected O, but got I4
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0139: Expected O, but got I4
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Expected O, but got Unknown
			//IL_010a: Expected O, but got Ref
			//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f6: Expected O, but got Unknown
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Expected O, but got Unknown
			//IL_01e2: Expected O, but got Ref
			if (IsChatDisabled)
			{
				return "Cannot populate JSON object onto type '{0}'." + 2320;
			}
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				MuteStatus muteStatus = SFSKammelnaUserExtensions.GetMuteStatus(localUser);
				if (muteStatus == MuteStatus.MutedByAdmin)
				{
					object obj5 = typeof(MemberAchievementClanFeedData) + 1872;
					object obj6 = obj5;
					object obj8 = default(object);
					object obj7 = (object)(&obj8);
				}
				else
				{
					object obj9 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v14+E4]");
					bool flag2 = (nint)0 == 0;
					object obj10 = !flag2;
					if (obj10 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
					SessionModel sessionModel2 = default(SessionModel);
					if ((object)sessionModel2 == null)
					{
						goto IL_01fb;
					}
					User localUser2 = sessionModel2.LocalUser;
					if (!SFSKammelnaUserExtensions.IsSubscribed(localUser2))
					{
						return "October" + 880;
					}
					object obj11 = typeof(MemberAchievementClanFeedData) + 1872;
					object obj6 = obj11;
					MuteStatus muteStatus2 = default(MuteStatus);
					object obj7 = (object)(&muteStatus2);
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				Enum enumeration = default(Enum);
				return EnumExtensions.GetFriendlyName(enumeration);
			}
			goto IL_01fb;
			IL_01fb:
			return (string)(object)new NullReferenceException();
		}
	}

	public static bool ChatActive
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0101: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0166: Expected I4, but got O
			//IL_014a: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 720;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FAD]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)1960;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
				object obj4 = (nint)0 + (nint)1960;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			object obj8 = default(object);
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_00b8;
			}
			goto IL_0158;
			IL_00b8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v14+2C]");
			return false;
			IL_0158:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_0158;
		}
		set
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_0171: Expected O, but got I
			//IL_019b: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_01e4: Expected O, but got I4
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			//IL_00ef: Expected O, but got I
			//IL_00ff: Expected O, but got I
			//IL_0134: Expected O, but got I
			//IL_0144: Expected O, but got I
			//IL_0154: Expected O, but got I
			object obj = 152989696;
			object obj2 = typeof(Queue<string>) + 720;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E704B]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)1960;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
				object obj4 = (nint)0 + (nint)1960;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
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
			object obj8 = default(object);
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00a0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			goto IL_00a0;
			IL_00a0:
			if (value)
			{
				ClearChatCounter();
				object obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
				object obj11 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v10+B8]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v11+18]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X8_v11+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v12+18]");
					object obj14 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v12+40]");
					object obj15 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v12+28]");
					object obj16 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v105 @ X2_v1 (should have been resolved before IL gen)");
				}
			}
		}
	}

	public static bool ClanChatActive
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0101: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0166: Expected I4, but got O
			//IL_014a: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 720;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FAE]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)1960;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
				object obj4 = (nint)0 + (nint)1960;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v3+E4]");
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
			object obj8 = default(object);
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 != null)
			{
				goto IL_00b8;
			}
			goto IL_0158;
			IL_00b8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v14+34]");
			return false;
			IL_0158:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			if (obj8 != null)
			{
				goto IL_00b8;
			}
			goto IL_0158;
		}
		set
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00d6: Expected O, but got I
			//IL_0100: Expected O, but got I4
			//IL_005c: Expected O, but got I
			//IL_0149: Expected O, but got I4
			object obj = 152985600;
			object obj2 = typeof(Queue<string>) + 720;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FAF]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = (nint)0 + (nint)1960;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
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
				object obj4 = (nint)0 + (nint)1960;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v4+E4]");
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
			object obj8 = default(object);
			bool flag3 = obj8 == null;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00a0;
			IL_0091:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			goto IL_00a0;
			IL_00a0:
			if (value)
			{
				ClearClanChatCounter();
			}
		}
	}

	public static string ActiveGroup
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0031: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
			return (string)0;
		}
		set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_0206: Expected O, but got I
			//IL_024a: Expected O, but got I4
			//IL_0057: Expected O, but got I
			//IL_006f: Expected O, but got I
			//IL_0084: Expected O, but got I
			//IL_00a2: Expected O, but got I4
			//IL_0182: Expected O, but got I
			//IL_0192: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_01cf: Expected O, but got I
			//IL_01df: Expected O, but got I
			//IL_01ef: Expected O, but got I
			//IL_011e: Expected O, but got I
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Expected O, but got Unknown
			//IL_0165: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
			object obj2 = typeof(Queue<string>) + 720;
			object obj3 = (nint)0 + (nint)1960;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v4+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj7 = (nint)0 + (nint)1448;
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X9_v2+B8]");
			object key = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X0_v7+20]");
			bool flag2 = ((Dictionary<object, object>)0).ContainsKey(key);
			bool flag3 = !flag2;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				object obj10 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X0_v14+E4]");
				bool flag4 = (nint)0 == 0;
				object obj11 = !flag4;
				if (obj11 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
				object obj12 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v12+B8]");
				object key2 = 0;
				object obj13 = typeof(List<AdaptivePerformanceScaler>) + 472;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				List<object> list = default(List<object>);
				list..ctor();
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X0_v17+20]");
				((Dictionary<object, object>)0).set_Item(key2, (object)list);
			}
			object obj14 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X8_v9+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X9_v4+10]");
			object obj16 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v125 @ X9_v4+10]");
			if ((nint)0 != 0)
			{
				object obj17 = obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v10+18]");
				object obj18 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v10+40]");
				object obj19 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X8_v10+28]");
				object obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v116 @ X3_v2 (should have been resolved before IL gen)");
			}
		}
	}

	public static event Action<ChatMessageData> OnMessage
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+8]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)8;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action<string> OnGroupChange
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_00d7: Expected O, but got I
			//IL_0022: Expected O, but got I4
			//IL_00fa: Expected O, but got I
			//IL_0079: Expected O, but got I4
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
			object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X8_v4+10]");
			Delegate obj5 = (Delegate)0;
			object obj8 = default(object);
			bool flag2;
			Delegate obj12 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null)
				{
					object obj7 = 0;
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag = obj8 == null;
					object obj9 = !flag;
					object obj7 = obj8;
					if (obj9 == null)
					{
						throw new InvalidCastException();
					}
				}
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v6+B8]");
				object obj11 = (nint)0 + (nint)16;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				flag2 = (object)obj12 == obj5;
				obj5 = obj12;
			}
			while (!flag2);
		}
	}

	public static event Action OnChatActivated
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+18]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+18]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)24;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static event Action OnClear
	{
		add
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Combine(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Expected O, but got Unknown
			//IL_00e7: Expected O, but got I
			//IL_00f7: Expected O, but got I
			//IL_0037: Expected O, but got I
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
			object obj2 = typeof(SqlSingle[]) + 2376;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4+20]");
			Delegate obj5 = (Delegate)0;
			bool flag;
			Delegate obj9 = default(Delegate);
			do
			{
				Delegate obj6 = Delegate.Remove(obj5, value);
				if ((object)obj6 == null || obj6 == obj2)
				{
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v5+B8]");
					object obj8 = (nint)0 + (nint)32;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj9 == obj5;
					obj5 = obj9;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	public static void SendChat(string message)
	{
		//IL_0394: Unknown result type (might be due to invalid IL or missing references)
		//IL_0399: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_03be: Expected O, but got I
		//IL_03d6: Expected O, but got I
		//IL_040d: Expected O, but got I4
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0107: Expected O, but got I4
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_014a: Expected O, but got I4
		//IL_0173: Expected O, but got I
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01a7: Expected O, but got I
		//IL_01bf: Expected O, but got I
		//IL_01d4: Expected O, but got I
		//IL_01f5: Expected O, but got I
		//IL_020a: Expected O, but got I
		//IL_0238: Expected O, but got I4
		//IL_0344: Expected O, but got I
		//IL_0354: Expected O, but got I
		//IL_0376: Expected O, but got I4
		//IL_02f3: Expected O, but got I
		//IL_0303: Expected O, but got I
		//IL_0313: Expected O, but got I
		//IL_025c: Expected O, but got I
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_02ae: Expected O, but got I
		//IL_02be: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
		object obj2 = typeof(Queue<string>) + 848;
		object obj3 = (nint)0 + (nint)2200;
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5+B8]");
		object messageTag = 0;
		SFS.SendChatMessage(message, (string)messageTag);
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		User localUser = sessionModel.LocalUser;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 888;
		SessionModel sessionModel2 = default(SessionModel);
		User localUser2 = sessionModel2.LocalUser;
		ChatInk chatInk = SFSKammelnaUserExtensions.GetChatInk(localUser2);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
		string userName = SFSKammelnaUserExtensions.GetUserName(localUser);
		DateTime? avatarDate = SFSKammelnaUserExtensions.GetAvatarDate(localUser);
		ChatInk ink = ChatMessageData.GetInk(localUser, chatInk);
		bool cardback = SFSKammelnaUserExtensions.IsVerified(localUser);
		int activeCardbackID = SFSKammelnaUserExtensions.GetActiveCardbackID(localUser);
		ChatMessageData chatMessageData = default(ChatMessageData);
		chatMessageData..ctor(message, dbId, userName, avatarDate, ChatInk.Clean, (byte)ink != 0, cardback ? 1 : 0, (string)activeCardbackID);
		object obj8 = typeof(Queue<string>) + 720;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v291 @ X0_v30+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj11 = (nint)0 + (nint)1960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
		object obj13 = (nint)0 + (nint)1456;
		object obj14 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X9_v2+B8]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X0_v33+20]");
		object obj15 = ((Dictionary<object, object>)0).get_Item(key);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v36 (System.Object)+1C]");
		object obj16 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v36 (System.Object)+10]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v36 (System.Object)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X9_v6+18]");
		bool flag3 = num < 0;
		object obj18 = !flag3;
		object obj24;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v36 (System.Object)+18]");
			object obj19 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v36 (System.Object)+18]");
			object obj20 = obj17 + 0;
			object obj21 = obj20 + 32;
			obj21 = chatMessageData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj22 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X8_v29+B8]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v30+8]");
			obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X8_v30+8]");
			if ((nint)0 != 0)
			{
				goto IL_02e3;
			}
			return;
		}
		goto IL_031d;
		IL_031d:
		((List<object>)obj15).AddWithResize((object)chatMessageData);
		object obj25 = obj12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v329 @ X8_v24+B8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v25+8]");
		obj24 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v330 @ X8_v25+8]");
		bool flag4 = (nint)0 == 0;
		object obj27 = !flag4;
		if (obj27 == null)
		{
			return;
		}
		goto IL_02e3;
		IL_02e3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v27+18]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v27+40]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v27+28]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v213 @ X3_v3 (should have been resolved before IL gen)");
		goto IL_031d;
	}

	public static void SendMessageInOfflineGame(ChatMessageData messageData)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_0158: Expected O, but got I
		//IL_0170: Expected O, but got I
		//IL_0185: Expected O, but got I
		//IL_01a6: Expected O, but got I
		//IL_01bb: Expected O, but got I
		//IL_01e9: Expected O, but got I4
		//IL_02cb: Expected O, but got I
		//IL_02db: Expected O, but got I
		//IL_020d: Expected O, but got I
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_025f: Expected O, but got I
		//IL_026f: Expected O, but got I
		//IL_0291: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 720;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FB3]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)1960;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v17+E4]");
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
			object obj4 = (nint)0 + (nint)1960;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v17+E4]");
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
		goto IL_0138;
		IL_0316:
		UpdateChatCounter();
		return;
		IL_0300:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v202 @ X8_v12+18] (should have been resolved before IL gen)");
		goto IL_0316;
		IL_0138:
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
		object obj9 = (nint)0 + (nint)1456;
		object obj10 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X9_v2+B8]");
		object key = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3+20]");
		object obj11 = ((Dictionary<object, object>)0).get_Item(key);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v7 (System.Object)+1C]");
		object obj12 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v7 (System.Object)+10]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v7 (System.Object)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X9_v6+18]");
		bool flag3 = num < 0;
		object obj14 = !flag3;
		if (obj14 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v7 (System.Object)+18]");
			object obj15 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v162 @ X0_v7 (System.Object)+18]");
			object obj16 = obj13 + 0;
			object obj17 = obj16 + 32;
			obj17 = messageData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj18 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X8_v19+B8]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v20+8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v20+8]");
			bool flag4 = (nint)0 == 0;
			object obj21 = !flag4;
			if (obj21 != null)
			{
				goto IL_0300;
			}
		}
		else
		{
			((List<object>)obj11).AddWithResize((object)messageData);
			object obj22 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v15+B8]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v16+8]");
			object obj20 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ X8_v16+8]");
			if ((nint)0 != 0)
			{
				goto IL_0300;
			}
		}
		goto IL_0316;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj24 = default(object);
		bool flag5 = obj24 == null;
		object obj25 = !flag5;
		if (obj25 != null)
		{
			goto IL_0138;
		}
		throw new NullReferenceException();
	}

	public static void InjectMessage(string group, ChatMessageData messageData)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00d1: Expected O, but got I
		//IL_00fb: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_0160: Expected O, but got I
		//IL_017e: Expected O, but got I4
		//IL_027b: Expected O, but got I4
		//IL_01be: Expected O, but got I4
		//IL_02b3: Expected O, but got I
		//IL_02c8: Expected O, but got I
		//IL_02e9: Expected O, but got I
		//IL_02fe: Expected O, but got I
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_032c: Expected O, but got I4
		//IL_0223: Expected O, but got I
		//IL_023c: Expected O, but got I
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_0405: Expected O, but got Unknown
		//IL_0350: Expected O, but got I
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_04e4: Expected O, but got I
		//IL_0422: Expected O, but got I
		//IL_0432: Expected O, but got I
		//IL_0467: Expected O, but got I
		//IL_0477: Expected O, but got I
		//IL_0487: Expected O, but got I
		object obj = typeof(Queue<string>) + 720;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FB4]");
		object obj2 = (nint)0 & (nint)1;
		object obj5;
		object obj3;
		if (obj2 != null)
		{
			obj3 = (nint)0 + (nint)1960;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v37+E4]");
			bool flag = (nint)0 == 0;
			obj5 = obj3;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			obj3 = (nint)0 + (nint)1960;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v37+E4]");
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
		IL_03f1:
		object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v16+B8]");
		object obj9 = 0;
		if (group == (string)obj9)
		{
			object obj10 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v19+B8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v20+8]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v20+8]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v21+18]");
				object obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v21+40]");
				object obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X8_v21+28]");
				object obj15 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v180 @ X3_v3 (should have been resolved before IL gen)");
			}
		}
		return;
		IL_0137:
		object obj16 = (nint)0 + (nint)1448;
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v3+20]");
		bool flag3 = ((Dictionary<object, object>)0).ContainsKey(group);
		bool flag4 = !flag3;
		object obj18 = !flag4;
		object obj19 = group;
		if (obj18 == null)
		{
			object obj20 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X0_v29+E4]");
			bool flag5 = (nint)0 == 0;
			object obj21 = !flag5;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj22 = typeof(List<AdaptivePerformanceScaler>) + 472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			object obj23 = (nint)0 + (nint)1480;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v32+20]");
			((Dictionary<object, object>)0).set_Item((object)group, (object)list);
			obj19 = group;
			obj17 = list;
		}
		object obj24 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v7+E4]");
		bool flag6 = (nint)0 == 0;
		object obj25 = !flag6;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj26 = (nint)0 + (nint)1456;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X0_v10+20]");
		object obj27 = ((Dictionary<object, object>)0).get_Item((object)group);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12 (System.Object)+1C]");
		object obj28 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12 (System.Object)+10]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12 (System.Object)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v4+18]");
		bool flag7 = num < 0;
		object obj30 = !flag7;
		if (obj30 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12 (System.Object)+18]");
			object obj31 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12 (System.Object)+18]");
			object obj32 = obj29 + 0;
			object obj33 = obj32 + 32;
			obj33 = messageData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12 (System.Object)+18]");
			if ((nint)0 < (nint)201)
			{
				goto IL_03f1;
			}
		}
		else
		{
			((List<object>)obj27).AddWithResize((object)messageData);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12 (System.Object)+18]");
			if ((nint)0 < (nint)201)
			{
				goto IL_03f1;
			}
		}
		do
		{
			((List<object>)obj27).RemoveAt(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X0_v12 (System.Object)+18]");
		}
		while ((nint)0 > (nint)200);
		goto IL_03f1;
		IL_0088:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj34 = default(object);
		bool flag8 = obj34 == null;
		object obj35 = !flag8;
		if (obj35 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0137;
	}

	public static void RemoveMessages(string group, Predicate<ChatMessageData> predicate)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_014c: Expected O, but got I
		//IL_0161: Expected O, but got I
		//IL_01a8: Expected O, but got I4
		//IL_01ea: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 720;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FB5]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)1960;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)1960;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v14+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_0140;
		IL_0140:
		object obj8 = (nint)0 + (nint)1448;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+20]");
		if (((Dictionary<object, object>)0).ContainsKey(group))
		{
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X0_v6+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v9+20]");
			object obj11 = ((Dictionary<object, object>)0).get_Item((object)group);
			int num = ((List<object>)obj11).RemoveAll((Predicate<object>)predicate);
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj12 = default(object);
		bool flag4 = obj12 == null;
		object obj13 = !flag4;
		if (obj13 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
	}

	public static List<ChatMessageData> GetMessages()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0031: Expected O, but got I
		object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj3 = 0;
		return GetMessages((string)obj3);
	}

	public static List<ChatMessageData> GetMessages(string group, bool dontFilter = false)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0189: Expected O, but got I
		//IL_01a6: Expected O, but got I
		//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Expected O, but got Unknown
		//IL_02f3: Expected O, but got I
		//IL_0323: Expected O, but got I4
		//IL_01f1: Expected O, but got I4
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_0266: Expected O, but got I
		//IL_0283: Expected O, but got I
		//IL_04cb: Expected O, but got I4
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ea: Expected O, but got Unknown
		//IL_0414: Expected O, but got I4
		//IL_0504: Expected O, but got I
		//IL_0514: Expected O, but got I
		//IL_0536: Expected O, but got I4
		//IL_045b: Expected O, but got I4
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		//IL_056e: Expected O, but got I
		//IL_057f: Expected I, but got O
		//IL_059d: Expected O, but got I
		//IL_048b: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 720;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FB6]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)1960;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v41+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)1960;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v41+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = default(object);
		bool flag3 = obj8 == null;
		obj4 = obj6;
		if (!flag3)
		{
			goto IL_0158;
		}
		goto IL_04e6;
		IL_04e1:
		List<object> result;
		return (List<ChatMessageData>)(object)result;
		IL_03d6:
		object obj9 = typeof(CardUtils.<>c) + 328;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v16+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj10 = obj9;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v16+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v18+8]");
		Func<object, bool> predicate = (Func<object, bool>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X8_v18+8]");
		bool flag5 = (nint)0 == 0;
		object obj13 = !flag5;
		if (obj13 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X0_v16+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj15 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v257 @ X8_v24+B8]");
				obj12 = 0;
			}
			object obj16 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 568;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = (nint)0 + (nint)3160;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor(obj12, (IntPtr)obj17);
			object obj18 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v23+B8]");
			object obj19 = (nint)0 + (nint)8;
			obj19 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			predicate = func;
		}
		List<object> list;
		IEnumerable<object> source = Enumerable.Where(list, predicate);
		return (List<ChatMessageData>)(object)Enumerable.ToList(source);
		IL_04e6:
		return (List<ChatMessageData>)(object)new NullReferenceException();
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag7 = obj8 == null;
		object obj20 = !flag7;
		if (obj20 != null)
		{
			goto IL_0158;
		}
		goto IL_04e6;
		IL_0158:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+20]");
		if ((nint)0 != 0)
		{
			object obj21 = (nint)0 + (nint)1448;
			object obj22 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+20]");
			if (!((Dictionary<object, object>)0).ContainsKey(group))
			{
				object obj23 = typeof(List<AdaptivePerformanceScaler>) + 472;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj24 = (nint)0 + (nint)2992;
				object obj25 = obj24;
				List<object> list2 = default(List<object>);
				list2..ctor();
				bool flag8 = !dontFilter;
				object obj26 = !flag8;
				list = list2;
				result = list2;
				if (obj26 == null)
				{
					goto IL_0341;
				}
				goto IL_04e1;
			}
			object obj27 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v34+E4]");
			bool flag9 = (nint)0 == 0;
			object obj28 = !flag9;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj29 = default(object);
			if (obj29 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v37+20]");
				if ((nint)0 != 0)
				{
					object obj30 = (nint)0 + (nint)1456;
					obj22 = obj30;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X0_v37+20]");
					object obj31 = ((Dictionary<object, object>)0).get_Item((object)group);
					bool flag10 = !dontFilter;
					object obj25 = group;
					List<object> list2 = (List<object>)obj31;
					list = (List<object>)obj31;
					if (flag10)
					{
						goto IL_0341;
					}
					result = (List<object>)obj31;
					goto IL_04e1;
				}
			}
		}
		goto IL_04e6;
		IL_0341:
		bool flag11 = PlayerUtilities.IsPlayer();
		bool flag12 = !flag11;
		result = list;
		if (!flag12)
		{
			object obj32 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj33 = obj32;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v201 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				bool ignoreWatchersChat = Preferences.IgnoreWatchersChat;
				bool flag13 = !ignoreWatchersChat;
				result = list;
				if (!flag13)
				{
					goto IL_03d6;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool ignoreWatchersChat2 = Preferences.IgnoreWatchersChat;
				bool flag14 = !ignoreWatchersChat2;
				object obj34 = !flag14;
				result = list;
				if (obj34 != null)
				{
					goto IL_03d6;
				}
			}
		}
		goto IL_04e1;
	}

	public static string SanitizeGroupTag(string groupTag)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I
		//IL_00f4: Expected O, but got I4
		//IL_0066: Expected O, but got I
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 3920;
		object pattern = "1.2.840.113549.1.12.1.5" + 3272;
		object replacement = (nint)0 + (nint)2000;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj3 = !flag;
		if (obj3 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		string text = Regex.Replace(groupTag, (string)pattern, (string)replacement);
		if (text != null)
		{
			object pattern2 = (nint)0 + (nint)3072;
			object replacement2 = "[{0}]:{1}" + 912;
			string input = text.Trim();
			return Regex.Replace(input, (string)pattern2, (string)replacement2);
		}
		return (string)(object)new NullReferenceException();
	}

	public static string GetReportText()
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)0 + (nint)2512;
		string chatUsersInfoString = GetChatUsersInfoString();
		string chatText = GetChatText();
		return chatUsersInfoString + (string)obj + chatText;
	}

	public static string GetChatText()
	{
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_01ba: Expected O, but got I4
		//IL_01e3: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_006c: Expected O, but got I
		//IL_023b: Expected O, but got I
		//IL_024c: Expected O, but got I
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_033c: Expected O, but got I
		//IL_034c: Expected O, but got I
		//IL_0358: Expected O, but got I
		//IL_0382: Expected O, but got I4
		//IL_0392: Expected O, but got I
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d9: Expected I, but got O
		//IL_00e9: Expected O, but got I
		//IL_04ff: Expected O, but got I
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		//IL_053a: Expected O, but got I
		//IL_0548: Expected I, but got O
		//IL_02a1: Expected O, but got I
		//IL_02b1: Expected O, but got I
		//IL_02bd: Expected O, but got I
		//IL_02e7: Expected O, but got I4
		//IL_03d2: Expected O, but got I4
		//IL_0124: Expected O, but got I
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0561: Expected O, but got Unknown
		//IL_0577: Expected O, but got I
		//IL_0588: Expected I, but got O
		//IL_05a6: Expected O, but got I
		//IL_030d: Expected O, but got I
		//IL_0402: Expected O, but got I
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045f: Expected O, but got Unknown
		//IL_0467: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		Dictionary<object, object>.KeyCollection keys;
		object obj17;
		object obj19;
		Func<object, int> keySelector;
		string separator;
		IEnumerable<object> source;
		string text;
		object obj10;
		if (IsChatRoom)
		{
			object obj = typeof(Queue<string>) + 848;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v33+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj4 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				Room currentRoom = sessionModel.CurrentRoom;
				if (currentRoom != null)
				{
					object obj5 = typeof(RegisteredWaitHandle) + 1376;
					nint num = (nint)currentRoom;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v37 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v37 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0165;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v37 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj7 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X10_v12-8]");
						if (0 == (nint)obj5)
						{
							break;
						}
						obj7 += 16;
						obj6--;
						if ((nint)obj6 != 1)
						{
							continue;
						}
						goto IL_0165;
					}
					object obj8 = obj7 + 1;
					object obj9 = num + obj8;
					obj10 = obj9 + 312;
					goto IL_04d7;
				}
			}
		}
		else
		{
			object obj11 = typeof(Queue<string>) + 720;
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj13 = !flag2;
			if (obj13 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object obj14 = (nint)0 + (nint)1960;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj15 = default(object);
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v8+20]");
				if ((nint)0 != 0)
				{
					object obj16 = (nint)0 + (nint)1464;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v8+20]");
					keys = ((Dictionary<object, object>)0).Keys;
					obj17 = typeof(CardUtils.<>c) + 328;
					object obj18 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v21+E4]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v21+B8]");
						obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X9_v4+10]");
						keySelector = (Func<object, int>)0;
						object obj20 = (nint)0 + (nint)2336;
						separator = (string)obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X9_v4+10]");
						bool flag3 = (nint)0 == 0;
						object obj21 = !flag3;
						source = keys;
						if (obj21 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X9_v4+10]");
							Func<object, int> func = (Func<object, int>)0;
							text = (string)obj20;
							goto IL_03b0;
						}
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						obj18 = obj17;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v21+B8]");
						obj19 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X9_v4+10]");
						Func<object, int> func = (Func<object, int>)0;
						object obj22 = (nint)0 + (nint)2336;
						text = (string)obj22;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X9_v4+10]");
						bool flag4 = (nint)0 == 0;
						object obj23 = !flag4;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X9_v4+10]");
						keySelector = (Func<object, int>)0;
						source = keys;
						separator = (string)obj22;
						if (obj23 == null)
						{
							goto IL_03b0;
						}
					}
					goto IL_04f3;
				}
			}
		}
		return (string)(object)new NullReferenceException();
		IL_04f3:
		object obj24 = (nint)0 + (nint)2240;
		IOrderedEnumerable<object> source2 = Enumerable.OrderBy(source, keySelector);
		object obj25 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj26 = (nint)0 + (nint)232;
		Func<object, object> func2 = default(Func<object, object>);
		func2..ctor((object)null, (IntPtr)obj26);
		IEnumerable<object> values = Enumerable.Select(source2, func2);
		return string.Join(separator, (IEnumerable<string>)values);
		IL_0165:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj27 = default(object);
		obj10 = obj27;
		goto IL_04d7;
		IL_03b0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v21+E4]");
		bool flag5 = (nint)0 == 0;
		object obj28 = !flag5;
		if (obj28 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj29 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X8_v28+B8]");
			obj19 = 0;
		}
		object obj30 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 3576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj31 = (nint)0 + (nint)3144;
		Func<object, int> func3 = default(Func<object, int>);
		func3..ctor(obj19, (IntPtr)obj31);
		object obj32 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X8_v27+B8]");
		object obj33 = (nint)0 + (nint)16;
		obj33 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		keySelector = func3;
		source = keys;
		separator = text;
		goto IL_04f3;
		IL_04d7:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v187 @ X8_v38] (should have been resolved before IL gen)");
		string channelName = default(string);
		return GetChannelText(channelName);
	}

	private static string GetChannelText(string channelName)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		//IL_07a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00b5: Expected O, but got I
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_013e: Expected O, but got I8
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_019d: Expected O, but got I4
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01d2: Expected O, but got I
		//IL_01f6: Expected O, but got I8
		//IL_021f: Expected O, but got I
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_024b: Expected O, but got I
		//IL_0268: Expected O, but got I4
		//IL_0838: Expected O, but got I4
		//IL_0363: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_02f9: Expected O, but got I
		//IL_02f9: Expected O, but got I
		//IL_0317: Expected O, but got I4
		//IL_034d: Expected O, but got I4
		//IL_0337: Expected O, but got I4
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_03f0: Expected O, but got I
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected O, but got Unknown
		//IL_04f1: Expected O, but got I
		//IL_04f1: Expected O, but got I
		//IL_0509: Expected O, but got I8
		//IL_0540: Expected O, but got I4
		//IL_0858: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected O, but got Unknown
		//IL_0891: Expected O, but got I4
		//IL_08a7: Expected O, but got I
		//IL_08c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected O, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057f: Expected O, but got Unknown
		//IL_058f: Expected O, but got I
		//IL_05b3: Expected O, but got I8
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_0603: Expected O, but got I4
		//IL_061a: Expected O, but got I4
		//IL_08f6: Expected O, but got I4
		//IL_0906: Expected O, but got I4
		//IL_0926: Unknown result type (might be due to invalid IL or missing references)
		//IL_092b: Expected O, but got Unknown
		//IL_0721: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected O, but got Unknown
		//IL_0758: Expected O, but got I4
		//IL_06b7: Expected O, but got I
		//IL_06b7: Expected O, but got I
		//IL_06d5: Expected O, but got I4
		//IL_070b: Expected O, but got I4
		//IL_06f5: Expected O, but got I4
		object obj = "{0} color encoding is currently unsupported for outputting to HDR." + 2800;
		object obj2 = "&action=sign-up" + 2952;
		List<ChatMessageData> messages = GetMessages(channelName, dontFilter: true);
		string text = (string)obj + channelName + (string)obj2;
		string text2;
		string[] array = default(string[]);
		object obj13;
		object obj15;
		object obj17;
		if (messages != null)
		{
			bool flag = messages._size < 1;
			text2 = text;
			if (flag)
			{
				goto IL_0797;
			}
			object obj3 = ((List<object>)(object)messages).get_Item(0);
			if (obj3 != null)
			{
				object obj4 = "1.2.840.113549.1.12.1.5" + 1496;
				object obj5 = typeof(SqlSingle[]) + 32;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v12 (System.Object)+18]");
				string text3 = (string)0 + (string)obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				if (array != null)
				{
					if (array.Length != 0)
					{
						object obj6 = array + 32;
						obj6 = text;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X24_v6-8]");
						object obj7 = 0 & 0xFFFFFFFEL;
						if (obj7 != null)
						{
							object obj8 = array + 40;
							obj8 = text3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X22_v9-10]");
							bool flag2 = (nint)0 < (nint)3;
							object obj9 = !flag2;
							object obj10 = ~obj9;
							if (obj10 == null)
							{
								object obj11 = array + 48;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v203 @ X0_v12 (System.Object)+20]");
								obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X21_v9-18]");
								object obj12 = 0 & 0xFFFFFFFCL;
								if (obj12 != null)
								{
									obj13 = (nint)0 + (nint)2336;
									object obj14 = array + 56;
									obj14 = obj13;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									obj15 = (nint)0 + (nint)2000;
									bool flag3 = messages._size == 1;
									object obj16 = 0;
									obj17 = obj15;
									if (!flag3)
									{
										object obj18 = ((List<object>)(object)messages).get_Item(0);
										if (obj18 != null)
										{
											object obj19 = ((List<object>)(object)messages).get_Item(1);
											if (obj19 != null)
											{
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X0_v70 (System.Object)+18]");
												nint num = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X0_v72 (System.Object)+18]");
												bool flag4 = (string)num != (string)0;
												bool flag5 = !flag4;
												object obj20 = !flag5;
												object obj21 = ~obj20;
												if (obj21 == null)
												{
													obj16 = 0;
													obj17 = obj13;
												}
												else
												{
													obj16 = 0;
													obj17 = obj15;
												}
												goto IL_081c;
											}
										}
										goto IL_07ca;
									}
									goto IL_081c;
								}
							}
						}
					}
					goto IL_07bc;
				}
			}
		}
		goto IL_07ca;
		IL_07bc:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_07ca;
		IL_081c:
		bool flag6 = array.Length < 5;
		object obj22 = !flag6;
		object obj23 = ~obj22;
		if (obj23 != null)
		{
			goto IL_07bc;
		}
		object obj24 = array + 64;
		obj24 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		string text4 = string.Concat(array);
		bool flag7 = messages._size < 2;
		text2 = text4;
		if (flag7)
		{
			goto IL_0797;
		}
		string text5 = text4;
		int num2 = 0;
		string[] array2 = default(string[]);
		while (true)
		{
			int num3 = num2 + 1;
			object obj25 = ((List<object>)(object)messages).get_Item(num3);
			if (obj25 == null)
			{
				break;
			}
			object obj26 = "1.2.840.113549.1.12.1.5" + 1496;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v36 (System.Object)+18]");
			string text6 = (string)0 + (string)obj26;
			object obj27 = typeof(SqlSingle[]) + 32;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			if (array2 == null)
			{
				break;
			}
			if (array2.Length != 0)
			{
				object obj28 = array2 + 32;
				obj28 = text5;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				object obj29 = ((List<object>)(object)messages).get_Item(num2);
				if (obj29 == null)
				{
					break;
				}
				object obj30 = ((List<object>)(object)messages).get_Item(num3);
				if (obj30 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v45 (System.Object)+10]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v47 (System.Object)+10]");
				bool flag8 = (string)num4 != (string)0;
				object obj31 = array2.Length & 0xFFFFFFFEL;
				if (obj31 != null)
				{
					bool flag9 = !flag8;
					object obj32 = !flag9;
					object obj33 = ~obj32;
					string text7 = (string)((obj33 != null) ? obj15 : text6);
					object obj34 = array2 + 40;
					obj34 = text7;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X22_v14-10]");
					bool flag10 = (nint)0 < (nint)2;
					object obj35 = !flag10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X22_v14-10]");
					object obj36 = -2;
					bool flag11 = obj36 == null;
					object obj37 = ~obj35;
					object obj38 = obj37 | flag11;
					if (obj38 == null)
					{
						object obj39 = array2 + 48;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v36 (System.Object)+20]");
						obj39 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X22_v16-18]");
						object obj40 = 0 & 0xFFFFFFFCL;
						if (obj40 != null)
						{
							object obj41 = array2 + 56;
							obj41 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							object obj42 = messages._size - 1;
							bool flag12 = num3 == (nint)obj42;
							object obj43 = 0;
							object obj44 = obj15;
							if (!flag12)
							{
								object obj45 = ((List<object>)(object)messages).get_Item(num3);
								if (obj45 == null)
								{
									break;
								}
								int index = num2 + 2;
								object obj46 = ((List<object>)(object)messages).get_Item(index);
								if (obj46 == null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X0_v64 (System.Object)+18]");
								nint num5 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X0_v66 (System.Object)+18]");
								bool flag13 = (string)num5 != (string)0;
								bool flag14 = !flag13;
								object obj47 = !flag14;
								object obj48 = ~obj47;
								if (obj48 == null)
								{
									obj43 = 0;
									obj44 = obj13;
								}
								else
								{
									obj43 = 0;
									obj44 = obj15;
								}
							}
							bool flag15 = array2.Length < 4;
							object obj49 = !flag15;
							object obj50 = array2.Length - 4;
							bool flag16 = obj50 == null;
							object obj51 = ~obj49;
							object obj52 = obj51 | flag16;
							if (obj52 == null)
							{
								object obj53 = array2 + 64;
								obj53 = obj44;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								string text8 = string.Concat(array2);
								object obj54 = num2 + 2;
								num2++;
								bool flag17 = (nint)obj54 < messages._size;
								text2 = text8;
								text5 = text8;
								if (flag17)
								{
									continue;
								}
								goto IL_0797;
							}
						}
					}
				}
			}
			goto IL_07bc;
		}
		goto IL_07ca;
		IL_0797:
		object obj55 = "___# Content push apply failed [{0}]: {1}" + 1288;
		return text2 + (string)obj55;
		IL_07ca:
		return (string)(object)new NullReferenceException();
	}

	public unsafe static string GetChatUsersInfoString()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_0f11: Expected I4, but got O
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_0257: Expected O, but got I4
		//IL_0280: Expected O, but got I
		//IL_02a2: Expected O, but got I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0080: Expected O, but got I4
		//IL_00a9: Expected O, but got I
		//IL_00cb: Expected O, but got I4
		//IL_02d0: Expected O, but got I4
		//IL_00fe: Expected O, but got I4
		//IL_02ea: Expected O, but got I
		//IL_02fb: Expected O, but got I
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0313: Expected O, but got Unknown
		//IL_032e: Expected O, but got I
		//IL_033c: Expected I, but got O
		//IL_0348: Expected O, but got I
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0131: Expected I, but got O
		//IL_0141: Expected O, but got I
		//IL_036f: Expected O, but got I4
		//IL_0377: Expected I4, but got O
		//IL_020c: Expected O, but got I4
		//IL_03da: Expected O, but got I4
		//IL_017c: Expected O, but got I
		//IL_0f43: Expected O, but got I
		//IL_0f55: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5a: Expected O, but got Unknown
		//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Expected O, but got Unknown
		//IL_0404: Expected I, but got O
		//IL_0414: Expected O, but got I
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0392: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_04ee: Expected O, but got I
		//IL_0512: Expected O, but got I4
		//IL_0522: Expected O, but got Ref
		//IL_052b: Expected O, but got I4
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_0658: Unknown result type (might be due to invalid IL or missing references)
		//IL_065d: Expected O, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0671: Expected O, but got Unknown
		//IL_067d: Expected O, but got I
		//IL_044f: Expected O, but got I
		//IL_06f7: Expected O, but got I
		//IL_0556: Expected O, but got Ref
		//IL_055f: Expected O, but got I4
		//IL_0574: Expected O, but got Ref
		//IL_0fc5: Expected O, but got I
		//IL_0fd7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fdc: Expected O, but got Unknown
		//IL_0d1b: Expected I4, but got O
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected O, but got Unknown
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_05ac: Expected O, but got I
		//IL_05d5: Expected O, but got Ref
		//IL_05de: Expected O, but got I4
		//IL_05fe: Expected O, but got I
		//IL_060e: Expected O, but got Ref
		//IL_0617: Expected O, but got I4
		//IL_0627: Expected O, but got Ref
		//IL_1080: Unknown result type (might be due to invalid IL or missing references)
		//IL_1085: Expected O, but got Unknown
		//IL_0732: Expected O, but got I
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Expected O, but got Unknown
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_0a4c: Expected O, but got I4
		//IL_0a65: Expected O, but got I4
		//IL_0a96: Expected O, but got I4
		//IL_0aaf: Expected O, but got I4
		//IL_1015: Expected O, but got I
		//IL_1027: Unknown result type (might be due to invalid IL or missing references)
		//IL_102c: Expected O, but got Unknown
		//IL_114b: Expected O, but got I4
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ee: Expected O, but got Unknown
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Expected O, but got Unknown
		//IL_0ae9: Expected O, but got I
		//IL_0748: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Expected O, but got Unknown
		//IL_0763: Expected O, but got I
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected O, but got Unknown
		//IL_0838: Expected O, but got I
		//IL_0c15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1a: Expected O, but got Unknown
		//IL_0c26: Expected O, but got I
		//IL_0c50: Expected O, but got I4
		//IL_0b24: Expected O, but got I
		//IL_1246: Expected O, but got I
		//IL_1256: Expected O, but got I
		//IL_1278: Expected O, but got I4
		//IL_0bf8: Expected O, but got I4
		//IL_11a9: Expected O, but got I
		//IL_0873: Expected O, but got I
		//IL_0e52: Expected O, but got I4
		//IL_0e5b: Expected O, but got I4
		//IL_0ba7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bac: Expected O, but got Unknown
		//IL_10b2: Expected O, but got I
		//IL_10c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c9: Expected O, but got Unknown
		//IL_0c97: Expected O, but got I4
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected O, but got Unknown
		//IL_0b4d: Expected O, but got I
		//IL_096e: Expected O, but got I4
		//IL_092a: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected O, but got Unknown
		//IL_0ea2: Expected O, but got I4
		//IL_1295: Unknown result type (might be due to invalid IL or missing references)
		//IL_129a: Expected O, but got Unknown
		//IL_12b0: Expected O, but got I
		//IL_12c1: Expected I, but got O
		//IL_12df: Expected O, but got I
		//IL_099c: Expected O, but got I
		//IL_09b6: Expected O, but got I4
		//IL_0889: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Expected O, but got Unknown
		//IL_08a4: Expected O, but got I
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected O, but got Unknown
		//IL_0cc7: Expected O, but got I
		//IL_09f6: Expected O, but got I
		//IL_0a06: Expected O, but got I
		//IL_0a2f: Expected O, but got I
		//IL_0a2f: Expected O, but got I
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2808;
		object obj2 = (nint)0 + (nint)688;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		bool flag = (byte)(int)obj2 != 0;
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj7;
		bool flag6 = default(bool);
		List<ChatMessageData> list;
		object obj11 = default(object);
		object obj23 = default(object);
		object obj13 = default(object);
		object obj6;
		object obj24 = default(object);
		if (IsChatRoom)
		{
			object obj3 = typeof(Queue<string>) + 848;
			object obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v86+E4]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			obj6 = (nint)0 + (nint)2200;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			bool flag3 = (object)sessionModel == null;
			obj7 = 0;
			if (!flag3)
			{
				Room currentRoom = sessionModel.CurrentRoom;
				bool flag4 = currentRoom == null;
				obj7 = 0;
				flag = false;
				if (!flag4)
				{
					object obj8 = typeof(RegisteredWaitHandle) + 1376;
					nint num = (nint)currentRoom;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v67 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v67 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_01f9;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v67 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
					object obj10 = (nint)0 + (nint)8;
					bool flag5 = flag6;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X10_v37-8]");
						obj11 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X10_v37-8]");
						object obj12 = 0 - obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X10_v37-8]");
						if (0 == (nint)obj8)
						{
							break;
						}
						obj13 = obj10 + 16;
						obj9--;
						obj12 = obj9 - 1;
						bool flag7 = obj12 == null;
						flag6 = (nint)obj9 != 1;
						flag5 = flag6;
						obj10 = obj13;
						if (flag6)
						{
							continue;
						}
						goto IL_01f9;
					}
					object obj14 = obj10 + 1;
					object obj15 = num + obj14;
					obj6 = obj15 + 312;
					flag6 = flag5;
					obj13 = obj10;
					goto IL_0f83;
				}
			}
		}
		else
		{
			object obj16 = typeof(Queue<string>) + 720;
			object obj17 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v75+E4]");
			bool flag8 = (nint)0 == 0;
			object obj18 = !flag8;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			obj6 = (nint)0 + (nint)1960;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj19 = default(object);
			bool flag9 = obj19 == null;
			obj7 = 0;
			if (!flag9)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v78+20]");
				bool flag10 = (nint)0 == 0;
				obj7 = 0;
				if (!flag10)
				{
					object obj20 = (nint)0 + (nint)1472;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v78+20]");
					Dictionary<object, object>.ValueCollection values = ((Dictionary<object, object>)0).Values;
					object obj21 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3760;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj22 = (nint)0 + (nint)3232;
					Func<object, object> func = default(Func<object, object>);
					func..ctor((object)null, (IntPtr)obj22);
					obj6 = (nint)0 + (nint)272;
					obj23 = obj6;
					IEnumerable<object> enumerable = Enumerable.SelectMany(values, (Func<object, IEnumerable<object>>)func);
					obj24 = 0;
					flag = (byte)(int)func != 0;
					list = (List<ChatMessageData>)enumerable;
					goto IL_03c2;
				}
			}
		}
		goto IL_0f28;
		IL_03c2:
		bool flag11 = list == null;
		obj7 = 0;
		object obj27;
		object obj31;
		object obj32 = default(object);
		object obj33;
		object obj35;
		object obj37;
		object obj34;
		object obj30;
		object obj36;
		if (!flag11)
		{
			object obj25 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3024;
			nint num2 = (nint)list;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v28 (Il2CppClass<System.Collections.Generic.List`1<ChatMessageData>>)+12E]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v28 (Il2CppClass<System.Collections.Generic.List`1<ChatMessageData>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04cc;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v413 @ X8_v28 (Il2CppClass<System.Collections.Generic.List`1<ChatMessageData>>)+B0]");
			obj27 = (nint)0 + (nint)8;
			bool flag12 = flag6;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X10_v12-8]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X10_v12-8]");
				object obj12 = 0 - obj25;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X10_v12-8]");
				if (0 == (nint)obj25)
				{
					break;
				}
				obj13 = obj27 + 16;
				obj26--;
				obj12 = obj26 - 1;
				bool flag7 = obj12 == null;
				flag6 = (nint)obj26 != 1;
				flag12 = flag6;
				obj27 = obj13;
				if (flag6)
				{
					continue;
				}
				goto IL_04cc;
			}
			object obj28 = num2 + obj27;
			object obj29 = obj28 + 312;
			obj30 = obj29;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X8_v45+8]");
			obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v674 @ X8_v45] (should have been resolved before IL gen)");
			bool flag13 = obj32 == null;
			obj7 = obj32;
			obj33 = (object)(&obj7);
			obj34 = 0;
			flag6 = flag12;
			obj13 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X10_v12-8]");
			obj35 = 0;
			obj7 = obj32;
			obj36 = (object)(&obj7);
			obj34 = 0;
			obj37 = obj23;
			obj6 = (object)(&obj7);
			if (!flag13)
			{
				goto IL_0635;
			}
			goto IL_0d0a;
		}
		goto IL_0f28;
		IL_0d8c:
		NullReferenceException ex = new NullReferenceException();
		obj35 = obj11;
		obj36 = obj33;
		object obj38;
		obj24 = obj38;
		obj37 = obj23;
		obj27 = obj13;
		flag = false;
		goto IL_0dcb;
		IL_0b75:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj39 = null;
		goto IL_11cd;
		IL_0dcb:
		obj11 = obj35;
		obj23 = obj37;
		obj13 = obj27;
		goto IL_0f28;
		IL_0d56:
		NullReferenceException ex2 = new NullReferenceException();
		obj35 = obj11;
		obj36 = obj33;
		obj24 = obj38;
		obj37 = obj23;
		obj27 = obj13;
		goto IL_0dcb;
		IL_0f83:
		obj30 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v257 @ X8_v3] (should have been resolved before IL gen)");
		string text = default(string);
		list = GetMessages(text, dontFilter: true);
		flag = true;
		goto IL_03c2;
		IL_0d0a:
		NullReferenceException ex3 = new NullReferenceException();
		flag = (byte)(int)obj31 != 0;
		goto IL_0dcb;
		IL_0d20:
		NullReferenceException ex4 = new NullReferenceException();
		obj35 = obj11;
		obj36 = obj33;
		obj24 = obj38;
		obj37 = obj23;
		obj27 = obj13;
		goto IL_0dcb;
		IL_0abd:
		object obj40 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj42;
		object obj41 = obj42;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v21+12E]");
		obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v21+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0b75;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v21+B0]");
		object obj43 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X10_v9-8]");
			obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X10_v9-8]");
			if (0 == (nint)obj40)
			{
				break;
			}
			obj13 = obj43 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v21+12E]");
			obj30 = -1;
			bool flag14 = (nint)obj30 != 1;
			obj43 = obj13;
			if (flag14)
			{
				continue;
			}
			goto IL_0b75;
		}
		obj30 = obj43;
		object obj44 = obj41 + obj43;
		object obj45 = obj44 + 312;
		obj39 = obj23;
		obj13 = obj43;
		goto IL_11cd;
		IL_0f28:
		throw new NullReferenceException();
		IL_1131:
		object obj46;
		object obj48;
		object obj49;
		object obj50;
		object obj51;
		object obj52;
		object obj53;
		object obj54;
		object obj55;
		object obj56;
		string text2 = default(string);
		Func<KeyValuePair<object, object>, object> func2 = default(Func<KeyValuePair<object, object>, object>);
		object obj69;
		object obj70 = default(object);
		object obj72;
		string result = default(string);
		while (true)
		{
			bool flag15 = obj46 == null;
			object obj47 = !flag15;
			obj11 = obj48;
			obj49 = obj50;
			obj51 = obj52;
			obj53 = obj54;
			obj36 = obj33;
			obj24 = obj38;
			obj23 = obj39;
			obj13 = obj55;
			if (obj47 == null)
			{
				if ((nint)obj56 != 6)
				{
					bool flag16 = obj56 == null;
					object obj57 = !flag16;
					if (obj57 != null)
					{
						return text2;
					}
				}
				object obj58 = typeof(CardUtils.<>c) + 328;
				object separator = (nint)0 + (nint)2336;
				object obj59 = obj58;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v8+E4]");
				bool flag17 = (nint)0 == 0;
				object obj60 = !flag17;
				if (obj60 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					obj59 = obj58;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v8+B8]");
				object obj61 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X8_v8+18]");
				Func<KeyValuePair<object, object>, object> selector = (Func<KeyValuePair<object, object>, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v913 @ X8_v8+18]");
				bool flag18 = (nint)0 == 0;
				object obj62 = !flag18;
				if (obj62 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v818 @ X0_v8+E4]");
					bool flag19 = (nint)0 == 0;
					object obj63 = !flag19;
					if (obj63 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						object obj64 = obj58;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v933 @ X8_v14+B8]");
						obj61 = 0;
					}
					object obj65 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 3680;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj66 = (nint)0 + (nint)3152;
					func2..ctor(obj61, (IntPtr)obj66);
					object obj67 = obj58;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v869 @ X8_v13+B8]");
					object obj68 = (nint)0 + (nint)24;
					obj68 = func2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					selector = func2;
				}
				IEnumerable<object> source = Enumerable.Select(dictionary, selector);
				object[] value = Enumerable.ToArray(source);
				return string.Join((string)separator, (string[])value);
			}
			OutOfMemoryException ex5 = new OutOfMemoryException();
			if (flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj69 = obj70;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				bool flag20 = obj7 == null;
				object obj71 = !flag20;
				obj72 = 0;
				obj34 = obj70;
				obj42 = obj7;
				if (obj71 != null)
				{
					break;
				}
				obj48 = obj11;
				obj50 = obj49;
				obj52 = obj51;
				obj54 = obj53;
				obj56 = 0;
				obj33 = obj36;
				obj34 = obj70;
				obj38 = obj24;
				obj39 = obj23;
				obj55 = obj13;
				obj46 = obj70;
				continue;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return result;
		}
		goto IL_0abd;
		IL_04cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		object obj73 = default(object);
		obj30 = obj73;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X0_v71+8]");
		obj31 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v507 @ X0_v71] (should have been resolved before IL gen)");
		bool flag21 = obj32 == null;
		object obj74 = !flag21;
		obj7 = obj32;
		obj33 = (object)(&obj7);
		obj34 = 0;
		obj23 = null;
		if (obj74 != null)
		{
			goto IL_0635;
		}
		obj35 = obj11;
		obj7 = obj32;
		obj36 = (object)(&obj7);
		obj34 = 0;
		obj37 = null;
		obj27 = obj13;
		obj6 = (object)(&obj7);
		goto IL_0d0a;
		IL_0635:
		object obj75 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		obj53 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 400;
		obj51 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		obj49 = (nint)0 + (nint)800;
		obj38 = obj24;
		object obj76 = obj32;
		object obj80 = default(object);
		object obj85 = default(object);
		object obj86 = default(object);
		while (true)
		{
			object obj77 = obj76;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v33+12E]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v33+12E]");
			if ((nint)0 == 0)
			{
				goto IL_07b7;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v33+B0]");
			object obj78 = (nint)0 + (nint)8;
			bool flag22 = flag6;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X10_v26-8]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X10_v26-8]");
				object obj12 = 0 - obj75;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v900 @ X10_v26-8]");
				if (0 == (nint)obj75)
				{
					break;
				}
				obj13 = obj78 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v33+12E]");
				obj30 = -1;
				obj12 = obj30 - 1;
				bool flag7 = obj12 == null;
				flag6 = (nint)obj30 != 1;
				flag22 = flag6;
				obj78 = obj13;
				if (flag6)
				{
					continue;
				}
				goto IL_07b7;
			}
			obj30 = obj78;
			object obj79 = obj77 + obj78;
			obj80 = obj79 + 312;
			flag6 = flag22;
			obj13 = obj78;
			goto IL_1055;
			IL_1055:
			obj6 = obj80;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v928 @ X0_v49+8]");
			flag = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v928 @ X0_v49] (should have been resolved before IL gen)");
			object obj81 = text2 & 1;
			if (obj81 == null)
			{
				break;
			}
			if (obj7 == null)
			{
				goto IL_0d56;
			}
			object obj82 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X8_v36+12E]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X8_v36+12E]");
			if ((nint)0 == 0)
			{
				goto IL_08f8;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X8_v36+B0]");
			object obj83 = (nint)0 + (nint)8;
			bool flag23 = flag6;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X10_v21-8]");
				obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X10_v21-8]");
				object obj12 = 0 - obj53;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v985 @ X10_v21-8]");
				if (0 == (nint)obj53)
				{
					break;
				}
				obj13 = obj83 + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v943 @ X8_v36+12E]");
				obj30 = -1;
				obj12 = obj30 - 1;
				bool flag7 = obj12 == null;
				flag6 = (nint)obj30 != 1;
				flag23 = flag6;
				obj83 = obj13;
				if (flag6)
				{
					continue;
				}
				goto IL_08f8;
			}
			obj30 = obj83;
			object obj84 = obj82 + obj83;
			obj85 = obj84 + 312;
			flag6 = flag23;
			obj13 = obj83;
			goto IL_10f2;
			IL_10f2:
			obj6 = obj85;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1000 @ X0_v53+8]");
			flag = false;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1000 @ X0_v53] (should have been resolved before IL gen)");
			if (obj86 != null)
			{
				object obj87 = obj51;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X0_v57+E4]");
				bool flag24 = (nint)0 == 0;
				object obj88 = !flag24;
				if (obj88 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X0_v55+10]");
				bool flag25 = StringsExtensions.IsNullOrEmpty((string)0);
				bool flag26 = !flag25;
				object obj89 = !flag26;
				obj31 = null;
				if (obj89 == null)
				{
					if (dictionary == null)
					{
						goto IL_0d8c;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X0_v55+10]");
					obj31 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X0_v55+18]");
					obj23 = 0;
					obj38 = obj49;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X0_v55+10]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1003 @ X0_v55+18]");
					dictionary.set_Item((object)num3, (object)0);
				}
				bool flag27 = obj7 == null;
				obj76 = obj7;
				obj35 = obj11;
				obj36 = obj33;
				obj24 = obj38;
				obj37 = obj23;
				obj27 = obj13;
				if (!flag27)
				{
					continue;
				}
				goto IL_0d0a;
			}
			goto IL_0d20;
			IL_08f8:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj23 = null;
			goto IL_10f2;
			IL_07b7:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj23 = null;
			goto IL_1055;
		}
		bool flag28 = obj7 == null;
		obj72 = 6;
		obj36 = obj33;
		obj24 = obj38;
		obj69 = 0;
		obj42 = obj7;
		obj48 = obj11;
		obj50 = obj49;
		obj52 = obj51;
		obj54 = obj53;
		obj56 = 6;
		obj39 = obj23;
		obj55 = obj13;
		obj46 = 0;
		if (!flag28)
		{
			goto IL_0abd;
		}
		goto IL_1131;
		IL_11cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v722 @ X0_v37+8]");
		flag = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v722 @ X0_v37] (should have been resolved before IL gen)");
		obj48 = obj11;
		obj50 = obj49;
		obj52 = obj51;
		obj54 = obj53;
		obj56 = obj72;
		obj33 = obj36;
		obj38 = obj24;
		obj55 = obj13;
		obj46 = obj69;
		goto IL_1131;
		IL_01f9:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj23 = 1;
		object obj90 = default(object);
		obj6 = obj90;
		goto IL_0f83;
	}

	public static void ClearChatCounter()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0193: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 720;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FBC]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)1960;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)1960;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_0140;
		IL_0140:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5+28]");
		CounterBubbleManager.UpdateCounter(CounterBubbleType.PublicChat, 0);
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj11 = default(object);
		bool flag4 = obj11 == null;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
	}

	public static void UpdateChatCounter()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0156: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_01e0: Expected O, but got I
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 720;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FBD]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)1960;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v15+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)1960;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v15+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_0140;
		IL_0140:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3+2C]");
		object obj8 = (nint)0 & (nint)1;
		if (obj8 == null)
		{
			object obj9 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v4+E4]");
			bool flag3 = (nint)0 == 0;
			object obj10 = !flag3;
			if (obj10 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v7+28]");
			object obj11 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj12 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X0_v10+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v9+28]");
				CounterBubbleManager.UpdateCounter(CounterBubbleType.PublicChat, 0);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v9+28]");
				CounterBubbleManager.UpdateCounter(CounterBubbleType.PublicChat, 0);
			}
		}
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj14 = default(object);
		bool flag4 = obj14 == null;
		object obj15 = !flag4;
		if (obj15 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
	}

	public static void ClearClanChatCounter()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0193: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 720;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FBE]");
		object obj3 = (nint)0 & (nint)1;
		object obj6;
		object obj4;
		if (obj3 != null)
		{
			obj4 = (nint)0 + (nint)1960;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v10+E4]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)1960;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v10+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		obj4 = obj6;
		goto IL_0140;
		IL_0140:
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v6+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5+30]");
		CounterBubbleManager.UpdateCounter(CounterBubbleType.ClanChat, 0);
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj11 = default(object);
		bool flag4 = obj11 == null;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0140;
	}

	private void CountClanUnread(ChatMessageData messageData)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00a8: Expected O, but got I4
		if (ClanUtils.IsClanChatTag(messageData.<Tag>k__BackingField) && !_clanChatActive)
		{
			int newCount = ++_clanUnreadCounter;
			object obj = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CounterBubbleManager.UpdateCounter(CounterBubbleType.ClanChat, newCount);
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_021c: Expected O, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0264: Expected O, but got I4
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_029a: Expected O, but got I
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02cf: Expected I, but got O
		//IL_005a: Expected O, but got I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0097: Expected O, but got I
		//IL_00a3: Expected O, but got I
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c3: Expected O, but got I
		//IL_00e9: Expected I, but got O
		//IL_0113: Expected O, but got I4
		//IL_0156: Expected I, but got O
		//IL_017c: Expected I, but got O
		//IL_01a7: Expected I, but got O
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01df: Expected O, but got I
		//IL_01ed: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2416;
		object obj3 = (nint)0 + (nint)280;
		object obj4 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		GameObject gameObject = base.gameObject;
		object obj5 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj6 = !flag;
		UnityEngine.Object target = gameObject;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		object obj7 = typeof(SqlSingle[]) + 2376;
		object obj8 = (nint)0 + (nint)248;
		object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		UnityEngine.Object.DontDestroyOnLoad(target);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<int> action = default(Action<int>);
		action..ctor((object)this, (IntPtr)obj3);
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v7+E4]");
		bool flag2 = (nint)0 == 0;
		object obj11 = !flag2;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj12 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1392;
		object obj13 = (nint)0 + (nint)264;
		object obj14 = (nint)0 + (nint)240;
		object obj15 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3576;
		object obj16 = (nint)0 + (nint)272;
		FriendsManager.OnUserBlocked += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj8);
		object obj17 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X0_v12+E4]");
		bool flag3 = (nint)0 == 0;
		object obj18 = !flag3;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Preferences.OnGameChanged += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action3 = default(Action<object>);
		action3..ctor((object)this, (IntPtr)obj13);
		SFS.OnPublicMessage += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action4 = default(Action<object>);
		action4..ctor((object)this, (IntPtr)obj14);
		SFS.OnAdminMessage += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action5 = default(Action<object>);
		action5..ctor((object)this, (IntPtr)obj16);
		SFS.OnServerSwitch += action5;
		object obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)256;
		Action<object> action6 = default(Action<object>);
		action6..ctor((object)this, (IntPtr)obj20);
		SFS.OnJoinRoom += action6;
	}

	private void OnPublicMessage(ChatMessageData messageData)
	{
		//IL_09f7: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_005c: Expected O, but got I4
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0160: Expected O, but got I4
		//IL_0207: Expected I8, but got I4
		//IL_022a: Expected O, but got I4
		//IL_0233: Expected O, but got I4
		//IL_01c5: Expected I8, but got I4
		//IL_01e1: Expected O, but got I4
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_0347: Expected O, but got I4
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c5: Expected O, but got Unknown
		//IL_02fd: Expected O, but got I4
		//IL_0375: Expected I, but got O
		//IL_038f: Expected O, but got I
		//IL_0397: Expected I, but got O
		//IL_03c2: Expected O, but got I4
		//IL_0310: Expected I, but got O
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Expected O, but got Unknown
		//IL_047b: Expected O, but got I
		//IL_0483: Expected I, but got O
		//IL_04bf: Expected O, but got I
		//IL_04dd: Expected O, but got I
		//IL_04f2: Expected O, but got I
		//IL_0428: Expected O, but got I
		//IL_044b: Expected I, but got O
		//IL_0540: Expected O, but got I4
		//IL_05bb: Expected O, but got I
		//IL_05cb: Expected O, but got I
		//IL_0564: Expected O, but got I
		//IL_0586: Expected O, but got I
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_0622: Expected O, but got I
		//IL_0a0d: Expected I, but got O
		//IL_0a5b: Expected O, but got I
		//IL_090f: Expected I, but got O
		//IL_0925: Expected O, but got I
		//IL_093f: Expected O, but got I4
		//IL_071c: Expected O, but got I4
		//IL_0724: Expected O, but got I
		//IL_0676: Expected I, but got O
		//IL_0a82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected O, but got Unknown
		//IL_0a9f: Expected O, but got I
		//IL_0abd: Expected O, but got I4
		//IL_080d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected O, but got Unknown
		//IL_0975: Expected O, but got I
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected O, but got Unknown
		//IL_0794: Expected O, but got I4
		//IL_06ae: Expected I, but got O
		//IL_06e2: Expected O, but got I4
		//IL_099a: Expected O, but got I
		//IL_09aa: Expected O, but got I
		//IL_08f9: Expected O, but got I4
		//IL_07c9: Expected O, but got I4
		//IL_087b: Expected I, but got O
		//IL_0891: Expected O, but got I
		bool flag = messageData == null;
		string text = (string)152989696;
		Dictionary<object, object> allMessagesList;
		nint num2;
		if (!flag)
		{
			object obj = typeof(Queue<string>) + 848;
			object obj2 = (nint)0 + (nint)2200;
			text = messageData.<UserId>k__BackingField;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v38+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			SessionModel sessionModel = default(SessionModel);
			if ((object)sessionModel != null)
			{
				User localUser = sessionModel.LocalUser;
				string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
				if (text == dbId && !messageData.<IsGenerated>k__BackingField)
				{
					return;
				}
				object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3016;
				object obj6 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
				object obj7 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X0_v46+E4]");
				bool flag3 = (nint)0 == 0;
				object obj8 = !flag3;
				if (obj8 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int num = Convert.ToInt32(messageData.<UserId>k__BackingField);
				object obj9 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X0_v50+E4]");
				if ((nint)0 != 0)
				{
					bool flag4 = FriendsManager.IsBlocked(num);
					bool flag5 = !flag4;
					object obj10 = 0;
					if (!flag5)
					{
						return;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag6 = FriendsManager.IsBlocked(num);
					bool flag7 = !flag6;
					object obj11 = !flag7;
					object obj10 = 0;
					if (obj11 != null)
					{
						return;
					}
				}
				text = (string)(messageData + 64);
				object obj12 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				object obj13 = obj12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v496 @ X0_v52+E4]");
				if ((nint)0 != 0)
				{
					if (StringsExtensions.IsNullOrEmpty(text))
					{
						goto IL_02b6;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					bool flag8 = StringsExtensions.IsNullOrEmpty(text);
					bool flag9 = !flag8;
					object obj14 = !flag9;
					if (obj14 != null)
					{
						goto IL_02b6;
					}
				}
				allMessagesList = (Dictionary<object, object>)(object)_allMessagesList;
				bool flag10 = _allMessagesList == null;
				num2 = unchecked((nint)null);
				if (!flag10)
				{
					goto IL_0383;
				}
			}
		}
		goto IL_06f0;
		IL_06f0:
		throw new NullReferenceException();
		IL_0383:
		object obj15 = (nint)0 + (nint)1448;
		num2 = (nint)obj15;
		bool flag11 = allMessagesList.ContainsKey(text);
		bool flag12 = !flag11;
		object obj16 = !flag12;
		if (obj16 == null)
		{
			object obj17 = typeof(List<AdaptivePerformanceScaler>) + 472;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			if (_allMessagesList == null)
			{
				goto IL_06f0;
			}
			object obj18 = (nint)0 + (nint)1480;
			object obj19 = obj18;
			((Dictionary<object, object>)(object)_allMessagesList).set_Item((object)text, (object)list);
			num2 = (nint)list;
		}
		if (_allMessagesList != null)
		{
			object obj20 = (nint)0 + (nint)1456;
			num2 = (nint)obj20;
			object obj21 = ((Dictionary<object, object>)(object)_allMessagesList).get_Item((object)text);
			if (obj21 != null)
			{
				object obj22 = (nint)0 + (nint)3000;
				object obj23 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v57 (System.Object)+1C]");
				object obj24 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v57 (System.Object)+10]");
				object obj25 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v57 (System.Object)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v57 (System.Object)+18]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X9_v8+18]");
					bool flag13 = num3 < 0;
					object obj26 = !flag13;
					if (obj26 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v57 (System.Object)+18]");
						object obj27 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v57 (System.Object)+10]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v57 (System.Object)+18]");
						object obj28 = num4 + 0;
						object obj29 = obj28 + 32;
						obj29 = messageData;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					}
					else
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v47+20]");
						object obj30 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v558 @ X8_v51+C0]");
						object obj31 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X8_v52+70]");
						num2 = 0;
						((List<object>)obj21).AddWithResize((object)messageData);
					}
					Dictionary<object, object> allMessagesList2 = (Dictionary<object, object>)(object)_allMessagesList;
					if (_allMessagesList != null)
					{
						object obj32 = (nint)0 + (nint)3024;
						while (true)
						{
							num2 = (nint)obj20;
							object obj33 = allMessagesList2.get_Item((object)text);
							if (obj33 == null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X0_v61 (System.Object)+18]");
							if ((nint)0 > (nint)200)
							{
								if (_allMessagesList == null)
								{
									break;
								}
								num2 = (nint)obj20;
								object obj34 = ((Dictionary<object, object>)(object)_allMessagesList).get_Item((object)text);
								if (obj34 == null)
								{
									break;
								}
								num2 = (nint)obj32;
								((List<object>)obj34).RemoveAt(0);
								allMessagesList2 = (Dictionary<object, object>)(object)_allMessagesList;
								bool flag14 = _allMessagesList == null;
								object obj35 = !flag14;
								if (obj35 == null)
								{
									break;
								}
								continue;
							}
							bool flag15 = ClanUtils.IsClanChatTag(text);
							bool flag16 = !flag15;
							string text2 = (string)num2;
							int num5 = 0;
							if (!flag16)
							{
								bool flag17 = !_clanChatActive;
								object obj36 = !flag17;
								text2 = (string)num2;
								num5 = 0;
								if (obj36 == null)
								{
									int num6 = ++_clanUnreadCounter;
									object obj37 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
									object obj38 = obj37;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v29+E4]");
									bool flag18 = (nint)0 == 0;
									object obj39 = !flag18;
									if (obj39 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									CounterBubbleManager.UpdateCounter(CounterBubbleType.ClanChat, num6);
									object obj19 = 0;
									text2 = null;
									num5 = num6;
								}
							}
							if (PlayerUtilities.IsPlayer())
							{
								object obj40 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
								object obj41 = obj40;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v288 @ X0_v20+E4]");
								if ((nint)0 != 0)
								{
									if (Preferences.IgnoreWatchersChat)
									{
										goto IL_0861;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									bool ignoreWatchersChat = Preferences.IgnoreWatchersChat;
									bool flag19 = !ignoreWatchersChat;
									object obj42 = !flag19;
									if (obj42 != null)
									{
										goto IL_0861;
									}
								}
							}
							nint num7 = (nint)text;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C0]");
							object obj43 = (nint)0 & (nint)1;
							bool flag20 = obj43 == null;
							object obj44 = !flag20;
							bool flag21 = true;
							string text3 = text;
							bool flag22 = true;
							if (obj44 == null)
							{
								goto IL_0967;
							}
							goto IL_0a73;
							IL_0967:
							_ = 1;
							text3 = (string)num7;
							flag22 = flag21;
							goto IL_0a73;
							IL_0861:
							bool flag23 = PlayerUtilities.IsPlayer(messageData.<UserId>k__BackingField);
							num7 = (nint)text;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C0]");
							object obj45 = (nint)0 & (nint)1;
							bool flag24 = obj45 == null;
							flag21 = flag23;
							if (flag24)
							{
								goto IL_0967;
							}
							text3 = text;
							flag22 = flag23;
							goto IL_0a73;
							IL_0a73:
							object obj46 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
							object obj47 = obj46;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v9+B8]");
							object obj48 = 0;
							bool flag25 = text3 == (string)obj48;
							object obj49 = flag25 && flag22;
							if ((nint)obj49 == 1)
							{
								object obj50 = obj46;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v12+B8]");
								object obj51 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v13+8]");
								object obj52 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v13+8]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v454 @ X8_v14+18] (should have been resolved before IL gen)");
								}
								UpdateChatCounter();
							}
							return;
						}
					}
				}
			}
		}
		goto IL_06f0;
		IL_02b6:
		object obj53 = "{0} color encoding is currently unsupported for outputting to HDR." + 2192;
		text = (string)obj53;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		allMessagesList = (Dictionary<object, object>)(object)_allMessagesList;
		bool flag26 = _allMessagesList == null;
		object obj54 = !flag26;
		if (obj54 != null)
		{
			goto IL_0383;
		}
		num2 = unchecked((nint)null);
		goto IL_06f0;
	}

	private void OnAdminMessage(ChatMessageData messageData)
	{
		//IL_0016: Expected O, but got I
		//IL_00d5: Expected O, but got I
		//IL_00ef: Expected O, but got I4
		//IL_0094: Expected O, but got I4
		//IL_0053: Expected O, but got I
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_013a: Expected O, but got I
		//IL_0152: Expected O, but got I
		//IL_0180: Expected O, but got I
		//IL_0195: Expected O, but got I
		//IL_01c3: Expected O, but got I4
		//IL_02e3: Expected O, but got I
		//IL_02f3: Expected O, but got I
		//IL_0315: Expected O, but got I4
		//IL_01e7: Expected O, but got I
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0288: Expected O, but got I
		//IL_0298: Expected O, but got I
		//IL_02a8: Expected O, but got I
		//IL_0243: Expected O, but got I
		//IL_0253: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6FC0]");
		object obj = (nint)0 & (nint)1;
		Dictionary<string, List<ChatMessageData>> allMessagesList;
		Dictionary<string, List<ChatMessageData>> allMessagesList2;
		if (obj != null)
		{
			allMessagesList = _allMessagesList;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C0]");
			object obj2 = (nint)0 & (nint)1;
			bool flag = obj2 == null;
			allMessagesList2 = _allMessagesList;
			if (!flag)
			{
				goto IL_007a;
			}
		}
		else
		{
			_ = 1;
			allMessagesList = _allMessagesList;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45C0]");
			object obj3 = (nint)0 & (nint)1;
			bool flag2 = obj3 == null;
			object obj4 = !flag2;
			allMessagesList2 = _allMessagesList;
			if (obj4 != null)
			{
				goto IL_007a;
			}
		}
		_ = 1;
		Dictionary<object, object> dictionary = (Dictionary<object, object>)(object)allMessagesList2;
		goto IL_011a;
		IL_0278:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v15+18]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v15+40]");
		object obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X8_v15+28]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v114 @ X3_v1 (should have been resolved before IL gen)");
		goto IL_02b2;
		IL_02b2:
		object obj8;
		((List<object>)obj8).AddWithResize((object)messageData);
		UpdateChatCounter();
		object obj10;
		object obj9 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X8_v12+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v13+8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v13+8]");
		bool flag3 = (nint)0 == 0;
		object obj13 = !flag3;
		if (obj13 == null)
		{
			return;
		}
		goto IL_0278;
		IL_011a:
		obj10 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
		object obj14 = (nint)0 + (nint)1456;
		object obj15 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X9_v2+B8]");
		object key = 0;
		obj8 = dictionary.get_Item(key);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v5 (System.Object)+1C]");
		object obj16 = (nint)0 + (nint)1;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v5 (System.Object)+10]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v5 (System.Object)+18]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X9_v6+18]");
		bool flag4 = num < 0;
		object obj18 = !flag4;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v5 (System.Object)+18]");
			object obj19 = (nint)0 + (nint)1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v5 (System.Object)+18]");
			object obj20 = obj17 + 0;
			object obj21 = obj20 + 32;
			obj21 = messageData;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			UpdateChatCounter();
			object obj22 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v17+B8]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v18+8]");
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v18+8]");
			if ((nint)0 != 0)
			{
				goto IL_0278;
			}
			return;
		}
		goto IL_02b2;
		IL_007a:
		bool flag5 = allMessagesList == null;
		object obj24 = !flag5;
		dictionary = (Dictionary<object, object>)(object)allMessagesList;
		if (obj24 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_011a;
	}

	private void OnServerSwitch(string newServer)
	{
		//IL_0011: Expected O, but got I
		//IL_0025: Expected O, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_004f: Expected O, but got I
		//IL_00e4: Expected O, but got I
		//IL_010e: Expected O, but got I4
		//IL_0078: Expected O, but got I
		//IL_0157: Expected O, but got I4
		object obj = (nint)0 + (nint)1440;
		((Dictionary<object, object>)(object)_allMessagesList).Clear();
		object obj2 = 152989696;
		object obj3 = typeof(Queue<string>) + 720;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E704B]");
		object obj4 = (nint)0 & (nint)1;
		if (obj4 != null)
		{
			object obj5 = (nint)0 + (nint)1960;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = obj5;
			if (!flag)
			{
				goto IL_00ad;
			}
		}
		else
		{
			_ = 1;
			object obj5 = (nint)0 + (nint)1960;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj7 = obj5;
			if (obj8 != null)
			{
				goto IL_00ad;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj9 = default(object);
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00bc;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00bc;
		IL_00bc:
		_ = 0;
		ClearChatCounter();
		ClearClanChatCounter();
	}

	private void OnGameChanged()
	{
		//IL_0011: Expected O, but got I
		//IL_0025: Expected O, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_004f: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_0078: Expected O, but got I
		//IL_014d: Expected O, but got I4
		object obj = (nint)0 + (nint)1440;
		((Dictionary<object, object>)(object)_allMessagesList).Clear();
		object obj2 = 152989696;
		object obj3 = typeof(Queue<string>) + 720;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E704B]");
		object obj4 = (nint)0 & (nint)1;
		if (obj4 != null)
		{
			object obj5 = (nint)0 + (nint)1960;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = obj5;
			if (!flag)
			{
				goto IL_00ad;
			}
		}
		else
		{
			_ = 1;
			object obj5 = (nint)0 + (nint)1960;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			object obj7 = obj5;
			if (obj8 != null)
			{
				goto IL_00ad;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj9 = default(object);
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00bc;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00bc;
		IL_00bc:
		_ = 0;
		ClearChatCounter();
	}

	public void Clear()
	{
		//IL_0011: Expected O, but got I
		//IL_0025: Expected O, but got I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_004f: Expected O, but got I
		//IL_0174: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_0078: Expected O, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00f3: Expected O, but got I
		//IL_0103: Expected O, but got I
		//IL_01e7: Expected O, but got I4
		//IL_0138: Expected O, but got I
		//IL_0148: Expected O, but got I
		//IL_0158: Expected O, but got I
		object obj = (nint)0 + (nint)1440;
		((Dictionary<object, object>)(object)_allMessagesList).Clear();
		object obj2 = 152989696;
		object obj3 = typeof(Queue<string>) + 720;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E704B]");
		object obj4 = (nint)0 & (nint)1;
		if (obj4 == null)
		{
			goto IL_0162;
		}
		object obj5 = (nint)0 + (nint)1960;
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v6+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = obj5;
		if (!flag)
		{
			goto IL_00ad;
		}
		goto IL_01b4;
		IL_0162:
		_ = 1;
		obj5 = (nint)0 + (nint)1960;
		obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v6+E4]");
		bool flag2 = (nint)0 == 0;
		object obj8 = !flag2;
		obj7 = obj5;
		if (obj8 != null)
		{
			goto IL_00ad;
		}
		goto IL_01b4;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00bc;
		IL_00bc:
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
		_ = 0;
		ClearChatCounter();
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X8_v12+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v13+20]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v13+20]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v14+18]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v14+40]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v14+28]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v93 @ X2_v1 (should have been resolved before IL gen)");
			goto IL_0162;
		}
		return;
		IL_01b4:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj16 = default(object);
		bool flag3 = obj16 == null;
		object obj17 = !flag3;
		if (obj17 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00bc;
	}

	private void OnJoinRoom(Room room)
	{
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01d9: Expected O, but got I
		//IL_01f3: Expected O, but got I4
		//IL_0641: Expected O, but got I
		//IL_0649: Expected I, but got O
		//IL_02e7: Expected O, but got I
		//IL_03ba: Expected O, but got I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0056: Expected I, but got O
		//IL_0066: Expected O, but got I
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0602: Expected O, but got Unknown
		//IL_0618: Expected O, but got I
		//IL_00a1: Expected O, but got I
		//IL_0514: Expected O, but got I
		//IL_0535: Expected O, but got I4
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected O, but got Unknown
		//IL_0594: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Expected O, but got Unknown
		//IL_04d1: Expected O, but got I
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0449: Unknown result type (might be due to invalid IL or missing references)
		//IL_044e: Expected O, but got Unknown
		//IL_0457: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00e4: Expected O, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7051]");
		nint num = 0;
		Room room2 = default(Room);
		Room room3;
		object obj4 = default(object);
		bool flag3 = default(bool);
		bool flag7 = default(bool);
		object obj9 = default(object);
		object obj8 = default(object);
		object obj7 = default(object);
		bool flag6 = default(bool);
		bool flag5 = default(bool);
		object obj6 = default(object);
		object obj5 = default(object);
		object obj10 = default(object);
		if (IsChatRoom)
		{
			bool flag = room2 == null;
			room3 = room2;
			if (flag)
			{
				goto IL_0428;
			}
			object obj = typeof(RegisteredWaitHandle) + 1376;
			num = (nint)room2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0177;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v8 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			bool flag2 = flag3;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X10_v9-8]");
				obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X10_v9-8]");
				bool flag4 = 0 < (nint)obj;
				obj5 = !flag4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X10_v9-8]");
				obj6 = 0 - obj;
				flag5 = (nint)obj6 < 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X10_v9-8]");
				flag6 = 0 == (nint)obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X10_v9-8]");
				obj7 = 0 ^ obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X10_v9-8]");
				obj8 = 0 ^ obj6;
				obj9 = obj7 & obj8;
				flag7 = (nint)obj9 < 0;
				flag3 = flag2;
				obj10 = obj3;
				room3 = room2;
				if (flag6)
				{
					break;
				}
				obj10 = obj3 + 16;
				obj2--;
				bool flag8 = (nint)obj2 < 1;
				obj5 = !flag8;
				obj6 = obj2 - 1;
				flag5 = (nint)obj6 < 0;
				flag6 = obj6 == null;
				obj7 = obj2 ^ 1;
				obj8 = obj2 ^ obj6;
				obj9 = obj7 & obj8;
				flag7 = (nint)obj9 < 0;
				flag3 = (nint)obj2 != 1;
				flag2 = flag3;
				obj3 = obj10;
				if (flag3)
				{
					continue;
				}
				goto IL_0177;
			}
			object obj11 = obj10 + 1;
			object obj12 = num + obj11;
			object obj13 = obj12 + 312;
			goto IL_05db;
		}
		object activeGroup = "{0} color encoding is currently unsupported for outputting to HDR." + 2192;
		ActiveGroup = (string)activeGroup;
		Room room4 = (Room)(typeof(Queue<string>) + 720);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E704B]");
		object obj14 = (nint)0 & (nint)1;
		bool flag9 = obj14 == null;
		object obj15 = !flag9;
		object obj16 = obj4;
		nint num2 = default(nint);
		IntPtr intPtr = num2;
		bool flag10 = flag3;
		bool flag11 = flag7;
		object obj17 = obj9;
		object obj18 = obj8;
		object obj19 = obj7;
		bool flag12 = flag6;
		bool flag13 = flag5;
		object obj20 = obj6;
		object obj21 = obj5;
		object obj22 = obj10;
		Room room5 = room2;
		room3 = room4;
		if (obj15 == null)
		{
			goto IL_0271;
		}
		goto IL_0635;
		IL_0177:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num2 = 1;
		room3 = room2;
		goto IL_05db;
		IL_037b:
		_ = 0;
		ClearChatCounter();
		return;
		IL_05db:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v238 @ X0_v11] (should have been resolved before IL gen)");
		string activeGroup2 = default(string);
		ActiveGroup = activeGroup2;
		room4 = (Room)(typeof(Queue<string>) + 720);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E704B]");
		object obj23 = (nint)0 & (nint)1;
		if (obj23 == null)
		{
			goto IL_0271;
		}
		obj16 = obj4;
		intPtr = num2;
		flag10 = flag3;
		flag11 = flag7;
		obj17 = obj9;
		obj18 = obj8;
		obj19 = obj7;
		flag12 = flag6;
		flag13 = flag5;
		obj20 = obj6;
		obj21 = obj5;
		obj22 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v11+8]");
		room5 = (Room)0;
		room3 = room4;
		goto IL_0635;
		IL_0271:
		_ = 1;
		obj16 = obj4;
		intPtr = num2;
		flag10 = flag3;
		flag11 = flag7;
		obj17 = obj9;
		obj18 = obj8;
		obj19 = obj7;
		flag12 = flag6;
		flag13 = flag5;
		obj20 = obj6;
		obj21 = obj5;
		obj22 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v11+8]");
		room5 = (Room)0;
		room3 = room4;
		goto IL_0635;
		IL_0428:
		throw new NullReferenceException();
		IL_0635:
		object obj24 = (nint)0 + (nint)1960;
		nint num3 = (nint)room3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v4 (Il2CppClass<Sfs2X.Entities.Room>)+E4]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X0_v4 (Il2CppClass<Sfs2X.Entities.Room>)+E4]");
		object obj25 = default(object);
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag14 = obj25 == null;
			obj4 = obj16;
			num2 = intPtr;
			flag3 = flag10;
			flag7 = flag11;
			obj9 = obj17;
			obj8 = obj18;
			obj7 = obj19;
			flag6 = flag12;
			flag5 = flag13;
			obj6 = obj20;
			obj5 = obj21;
			obj10 = obj22;
			if (!flag14)
			{
				goto IL_037b;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			bool flag15 = obj25 == null;
			object obj26 = !flag15;
			obj4 = obj16;
			num2 = intPtr;
			flag3 = flag10;
			flag7 = flag11;
			obj9 = obj17;
			obj8 = obj18;
			obj7 = obj19;
			flag6 = flag12;
			flag5 = flag13;
			obj6 = obj20;
			obj5 = obj21;
			obj10 = obj22;
			if (obj26 != null)
			{
				goto IL_037b;
			}
		}
		goto IL_0428;
	}

	private void OnUserBlocked(int dbId)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_005e: Expected O, but got I
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_007e: Expected O, but got I
		//IL_0096: Expected O, but got I
		//IL_00c9: Expected I, but got O
		//IL_00f8: Expected O, but got I
		//IL_0108: Expected O, but got I
		object obj = typeof(CardUtils.<>c) + 336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		int num = default(int);
		string text = num.ToString();
		object obj3 = obj2 + 16;
		obj3 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 856;
		object obj5 = (nint)0 + (nint)1456;
		object obj6 = typeof(List<Tween>) + 3128;
		object obj7 = (nint)0 + (nint)3168;
		object obj8 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X9_v2+B8]");
		object key = 0;
		object obj9 = ((Dictionary<object, object>)(object)_allMessagesList).get_Item(key);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Predicate<object> predicate = default(Predicate<object>);
		predicate..ctor(obj2, (IntPtr)obj7);
		int num2 = ((List<object>)obj9).RemoveAll(predicate);
		object obj10 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X8_v10+B8]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v13+10]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v13+10]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v171 @ X20_v3+18] (should have been resolved before IL gen)");
		}
	}

	public ChatHandler()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_008c: Expected O, but got I
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_0058: Expected O, but got I4
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 2104;
		object obj2 = typeof(Queue<string>) + 720;
		object obj3 = (nint)0 + (nint)1952;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		object obj4 = this + 32;
		obj4 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v7+E4]");
		if ((object)((nint)0 != 0) == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}
}
