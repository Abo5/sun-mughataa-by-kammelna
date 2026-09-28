using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Xml.Schema;
using Cpp2ILInjected;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.TextCore;

public class ActiveOnlinePlayers : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<FriendProfile, int> <>9__8_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(XmlSchemaInclude) + 3896;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal int <get__blockedIds>b__8_0(FriendProfile profile)
		{
			//IL_0035: Expected I4, but got O
			if (profile != null)
			{
				return profile.UserID;
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private TextMeshProUGUI onlinePlayers;

	private TextMeshProUGUI activePlayersCounter;

	private TextMeshProUGUI watcherPlayersCounter;

	private OffSetGridLayout GridLayout;

	private AvatarPool avatarPool;

	private float updateDelay = 30f;

	private IUsersListSource _listSource;

	private Transform gridLayoutTransform;

	private int _onlineUsersCount;

	private List<int> _blockedIds
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Expected O, but got Unknown
			//IL_0204: Expected O, but got I4
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_0101: Expected O, but got I
			//IL_0111: Expected O, but got I
			//IL_0133: Expected O, but got I4
			//IL_025c: Expected O, but got I4
			//IL_0163: Expected O, but got I4
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c5: Expected O, but got Unknown
			//IL_02db: Expected O, but got I
			//IL_02ec: Expected I, but got O
			//IL_030a: Expected O, but got I
			//IL_0193: Expected O, but got I
			object obj = 152993792;
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C60]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			object obj6;
			if (obj3 != null)
			{
				obj4 = typeof(XmlSchemaInclude) + 3896;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4+E4]");
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
				obj4 = typeof(XmlSchemaInclude) + 3896;
				object obj5 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v4+E4]");
				bool flag2 = (nint)0 == 0;
				object obj7 = !flag2;
				obj6 = obj4;
				if (obj7 != null)
				{
					goto IL_0099;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			IEnumerable<FriendProfile> blockedList = FriendsManager.BlockedList;
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v28+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			obj4 = obj6;
			IEnumerable<FriendProfile> source = blockedList;
			object obj10 = obj8;
			IEnumerable<FriendProfile> enumerable = blockedList;
			if (obj9 != null)
			{
				goto IL_00ef;
			}
			goto IL_028a;
			IL_00ef:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v28+B8]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v10+8]");
			Func<object, int> selector = (Func<object, int>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X8_v10+8]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			if (obj12 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v28+E4]");
				bool flag5 = (nint)0 == 0;
				object obj13 = !flag5;
				if (obj13 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj14 = obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X8_v16+B8]");
					obj11 = 0;
				}
				object obj15 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1200;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj16 = (nint)0 + (nint)2336;
				Func<object, int> func = default(Func<object, int>);
				func..ctor(obj11, (IntPtr)obj16);
				object obj17 = obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X8_v15+B8]");
				object obj18 = (nint)0 + (nint)8;
				obj18 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			IEnumerable<int> source2 = Enumerable.Select(source, selector);
			return Enumerable.ToList(source2);
			IL_028a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj8 = obj6;
			obj4 = obj6;
			source = enumerable;
			goto IL_00ef;
			IL_0099:
			IEnumerable<FriendProfile> blockedList2 = FriendsManager.BlockedList;
			obj8 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v28+E4]");
			bool flag6 = (nint)0 == 0;
			source = blockedList2;
			obj10 = obj8;
			obj6 = obj4;
			enumerable = blockedList2;
			if (!flag6)
			{
				goto IL_00ef;
			}
			goto IL_028a;
		}
	}

	private void Awake()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0034: Expected O, but got I
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_008f: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0178: Expected I, but got O
		//IL_0188: Expected O, but got I
		//IL_021e: Expected O, but got I
		//IL_01c3: Expected O, but got I
		//IL_0279: Expected O, but got I4
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0343: Expected O, but got I
		//IL_0367: Expected O, but got I4
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_02e1: Expected O, but got I
		//IL_02ef: Expected I, but got O
		object methodName = "Unsupported map type" + 224;
		InitDataSource();
		InvokeRepeating((string)methodName, 0f, updateDelay);
		object obj = typeof(Queue<string>) + 848;
		object obj2 = (nint)0 + (nint)2200;
		Transform transform = GridLayout.transform;
		object obj3 = this + 88;
		obj3 = transform;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v11+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		Room currentRoom = sessionModel.CurrentRoom;
		if (currentRoom == null)
		{
			return;
		}
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X0_v17+E4]");
		bool flag2 = (nint)0 == 0;
		object obj7 = !flag2;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel2 = default(SessionModel);
		Room currentRoom2 = sessionModel2.CurrentRoom;
		object obj8 = typeof(RegisteredWaitHandle) + 1376;
		object varName = "not" + 2704;
		nint num = (nint)currentRoom2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0204;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X8_v9 (Il2CppClass<Sfs2X.Entities.Room>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X10_v7-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			obj10 += 16;
			obj9--;
			if ((nint)obj9 != 1)
			{
				continue;
			}
			goto IL_0204;
		}
		object obj11 = obj10 + 35;
		object obj12 = num + obj11;
		object obj13 = obj12 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v261 @ X8_v18+8]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v261 @ X8_v18] (should have been resolved before IL gen)");
		object obj15 = default(object);
		bool flag3 = obj15 == null;
		object obj16 = !flag3;
		if (obj16 == null)
		{
			return;
		}
		goto IL_0245;
		IL_0245:
		GameObject go = base.gameObject;
		object obj17 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X0_v25+E4]");
		bool flag4 = (nint)0 == 0;
		object obj18 = !flag4;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel3 = default(SessionModel);
		Room currentRoom3 = sessionModel3.CurrentRoom;
		object obj19 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj20 = (nint)0 + (nint)2680;
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj20);
		VariableBinderExtensions.Bind(go, currentRoom3, (string)varName, action);
		return;
		IL_0204:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v290 @ X0_v34+8]");
		obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v290 @ X0_v34] (should have been resolved before IL gen)");
		object obj21 = default(object);
		if (obj21 != null)
		{
			goto IL_0245;
		}
	}

	private void InitDataSource()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0131: Expected O, but got I
		//IL_015b: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_01a4: Expected O, but got I4
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C62]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v9+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v9+E4]");
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
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		Room currentRoom = sessionModel.CurrentRoom;
		RoomUsersListSource roomUsersListSource;
		if (SFSKammelnaRoomExtensions.IsSuppressUserList(currentRoom))
		{
			GameObject lifecycle = base.gameObject;
			object obj9 = typeof(RegisteredWaitHandle) + 784;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			RequestUsersListSource requestUsersListSource = default(RequestUsersListSource);
			requestUsersListSource..ctor(lifecycle);
			roomUsersListSource = (RoomUsersListSource)(object)requestUsersListSource;
		}
		else
		{
			object obj10 = typeof(RegisteredWaitHandle) + 1440;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			RoomUsersListSource roomUsersListSource2 = default(RoomUsersListSource);
			roomUsersListSource2..ctor();
			roomUsersListSource = roomUsersListSource2;
		}
		object obj11 = this + 80;
		obj11 = roomUsersListSource;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void UpdateTimer()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_010d: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_0156: Expected O, but got I4
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C63]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
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
			object obj4 = (nint)0 + (nint)2200;
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
		SessionModel sessionModel = default(SessionModel);
		bool flag3 = (object)sessionModel == null;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00a0;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		goto IL_00a0;
		IL_00a0:
		Room currentRoom = sessionModel.CurrentRoom;
		if (currentRoom != null)
		{
			RequestList();
		}
	}

	private void RequestList()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_011e: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0041: Expected I, but got O
		//IL_0051: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_008c: Expected O, but got I
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3976;
		object obj2 = (nint)0 + (nint)2688;
		IUsersListSource listSource = _listSource;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj3 = typeof(System.IOAsyncCallback) + 1992;
		nint num = (nint)listSource;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5 (Il2CppClass<IUsersListSource>)+12E]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5 (Il2CppClass<IUsersListSource>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00cd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X8_v5 (Il2CppClass<IUsersListSource>)+B0]");
		object obj5 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X10_v5-8]");
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
			goto IL_00cd;
		}
		object obj6 = num + obj5;
		object obj7 = obj6 + 312;
		goto IL_0147;
		IL_00cd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		goto IL_0147;
		IL_0147:
		object obj8 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v5+8]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v156 @ X3_v2 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void UpdateData(UsersListModel usersListModel)
	{
		GameObject gameObject = base.gameObject;
		if (gameObject.activeInHierarchy)
		{
			_onlineUsersCount = usersListModel.<UsersCount>k__BackingField;
			GetNumberOfOnlinePlayers();
			int num = default(int);
			string text = num.ToString();
			TextMeshProExtensions.FixArabic(activePlayersCounter, text);
			int watchersCount = usersListModel.WatchersCount;
			string text2 = num.ToString();
			TextMeshProExtensions.FixArabic(watcherPlayersCounter, text2);
			if (Enumerable.Any((IEnumerable<object>)usersListModel.<UsersList>k__BackingField))
			{
				UpdateView(usersListModel);
			}
		}
	}

	private unsafe void UpdateView(UsersListModel usersListModel)
	{
		//IL_0010: Expected O, but got I
		//IL_09b5: Expected O, but got I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0049: Expected O, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_007d: Expected O, but got I
		//IL_0089: Expected O, but got I
		//IL_00a5: Expected O, but got Ref
		//IL_0778: Expected O, but got I4
		//IL_0780: Expected O, but got Ref
		//IL_078a: Expected O, but got I4
		//IL_015d: Expected I, but got O
		//IL_0a08: Expected O, but got I
		//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a20: Expected O, but got Unknown
		//IL_00fd: Expected O, but got I
		//IL_03b9: Expected O, but got I4
		//IL_03c1: Expected O, but got Ref
		//IL_03cb: Expected O, but got I4
		//IL_03d4: Expected O, but got I4
		//IL_016a: Expected I, but got O
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_0ad8: Expected O, but got I4
		//IL_087c: Expected O, but got I4
		//IL_0884: Expected O, but got Ref
		//IL_088e: Expected O, but got I4
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_03f9: Expected O, but got I
		//IL_048c: Expected I, but got O
		//IL_0b1a: Expected O, but got I
		//IL_0434: Expected O, but got I
		//IL_0a7a: Expected O, but got I
		//IL_0202: Expected O, but got I
		//IL_04fe: Expected I, but got O
		//IL_08e8: Expected O, but got I4
		//IL_08f0: Expected O, but got Ref
		//IL_08fa: Expected O, but got I4
		//IL_050f: Expected O, but got I
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected O, but got Unknown
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bc: Expected O, but got Unknown
		//IL_02c1: Expected O, but got I
		//IL_02fa: Expected O, but got I4
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected I, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0554: Expected O, but got I
		//IL_0562: Expected I, but got O
		//IL_056e: Expected O, but got I
		//IL_0576: Expected I, but got O
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0447: Expected O, but got Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Expected O, but got Unknown
		//IL_0746: Expected O, but got I4
		//IL_074e: Expected O, but got Ref
		//IL_0758: Expected O, but got I4
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_0598: Expected O, but got I
		//IL_05c5: Expected O, but got I4
		//IL_032e: Expected O, but got I
		//IL_033e: Expected O, but got I
		//IL_05f2: Expected O, but got I4
		//IL_08ae: Expected O, but got I4
		//IL_08b6: Expected O, but got Ref
		//IL_08c0: Expected O, but got I4
		//IL_06d4: Expected O, but got I
		//IL_0710: Expected O, but got I4
		//IL_0719: Expected O, but got I4
		//IL_03a2: Expected I, but got O
		//IL_080d: Expected O, but got I4
		//IL_0816: Expected O, but got I4
		//IL_081e: Expected O, but got Ref
		//IL_0846: Expected O, but got I4
		//IL_0854: Expected O, but got I4
		//IL_085c: Expected O, but got Ref
		//IL_07bd: Expected I, but got O
		//IL_07c7: Expected O, but got I4
		//IL_07d5: Expected O, but got I4
		//IL_07dd: Expected O, but got Ref
		//IL_06b6: Expected O, but got I4
		//IL_06bb: Expected I, but got O
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C66]");
		PlayerInfo playerInfo = (PlayerInfo)0;
		bool flag = (object)gridLayoutTransform == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		UsersListModel usersListModel3 = default(UsersListModel);
		UsersListModel usersListModel2 = usersListModel3;
		if (!flag)
		{
			object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1952;
			object obj3 = (nint)0 + (nint)3616;
			object obj4 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj5 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2672;
			object obj6 = (nint)0 + (nint)2672;
			object obj7 = (nint)0 + (nint)48;
			IEnumerator enumerator2 = gridLayoutTransform.GetEnumerator();
			AvatarInitializer avatarInitializer = null;
			object obj8 = default(object);
			playerInfo = (PlayerInfo)(&obj8);
			object obj9 = default(object);
			object obj14 = default(object);
			object obj15 = default(object);
			object obj16 = default(object);
			AvatarInitializer avatarInitializer2 = default(AvatarInitializer);
			object obj21 = default(object);
			object obj26 = default(object);
			object obj32 = default(object);
			PlayerInfo playerInfo3 = default(PlayerInfo);
			Func<object, bool> func = default(Func<object, bool>);
			Func<object, float> func2 = default(Func<object, float>);
			while (true)
			{
				if (obj9 != null)
				{
					object obj10 = obj9;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v33+12E]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v33+12E]");
					if ((nint)0 == 0)
					{
						goto IL_014e;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v33+B0]");
					object obj11 = (nint)0 + (nint)8;
					object obj12;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X10_v24-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj12 = obj11 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v318 @ X8_v33+12E]");
						num = -1;
						bool flag2 = num != 1;
						obj11 = obj12;
						if (flag2)
						{
							continue;
						}
						goto IL_014e;
					}
					num = (nint)obj11;
					object obj13 = obj10 + obj11;
					obj14 = obj13 + 312;
					obj12 = obj11;
					goto IL_09f0;
				}
				NullReferenceException ex = new NullReferenceException();
				enumerator = (List<object>.Enumerator)0;
				PlayerInfo playerInfo2 = (PlayerInfo)(&obj8);
				List<object>.Enumerator enumerator3 = (List<object>.Enumerator)0;
				UsersListModel usersListModel4 = (UsersListModel)(object)avatarInitializer;
				usersListModel2 = usersListModel3;
				goto IL_0907;
				IL_0907:
				usersListModel3 = usersListModel4;
				break;
				IL_0823:
				NullReferenceException ex2 = new NullReferenceException();
				enumerator = enumerator3;
				List<object>.Enumerator enumerator4 = enumerator3;
				enumerator3 = (List<object>.Enumerator)0;
				usersListModel4 = null;
				obj4 = 44;
				playerInfo = (PlayerInfo)(&enumerator);
				AvatarInitializer fromPool;
				usersListModel2 = (UsersListModel)(object)fromPool;
				goto IL_0907;
				IL_0253:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				nint num2 = 1;
				goto IL_0a62;
				IL_0a62:
				playerInfo = (PlayerInfo)obj15;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v672 @ X0_v56+8]");
				usersListModel4 = (UsersListModel)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v672 @ X0_v56] (should have been resolved before IL gen)");
				if (obj16 != null)
				{
					usersListModel4 = (UsersListModel)obj2;
					playerInfo = (PlayerInfo)obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v4 (PlayerInfo)+130]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X1_v23 (UsersListModel)+130]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v4 (PlayerInfo)+130]");
					nint num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X1_v23 (UsersListModel)+130]");
					bool flag3 = num3 < 0;
					object obj17 = !flag3;
					object obj18 = ~obj17;
					if (obj18 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v4 (PlayerInfo)+C8]");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X1_v23 (UsersListModel)+130]");
						object obj19 = num4 + 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v42-8]");
						playerInfo = (PlayerInfo)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v729 @ X8_v42-8]");
						if (0 == (nint)usersListModel4)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
							if ((object)avatarPool != null)
							{
								avatarPool.ReturnToPool(avatarInitializer2);
								num2 = unchecked((nint)null);
								avatarInitializer = avatarInitializer2;
								continue;
							}
							NullReferenceException ex3 = new NullReferenceException();
							enumerator = (List<object>.Enumerator)0;
							playerInfo2 = (PlayerInfo)(&obj8);
							enumerator3 = (List<object>.Enumerator)0;
							usersListModel4 = (UsersListModel)(object)avatarInitializer2;
							usersListModel2 = usersListModel3;
							goto IL_0907;
						}
					}
					InvalidCastException ex4 = new InvalidCastException();
					enumerator = (List<object>.Enumerator)0;
					playerInfo2 = (PlayerInfo)(&obj8);
					enumerator3 = (List<object>.Enumerator)0;
					usersListModel2 = usersListModel3;
				}
				else
				{
					NullReferenceException ex5 = new NullReferenceException();
					enumerator = (List<object>.Enumerator)0;
					playerInfo2 = (PlayerInfo)(&obj8);
					enumerator3 = (List<object>.Enumerator)0;
					usersListModel2 = usersListModel3;
				}
				goto IL_0907;
				IL_014e:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num2 = unchecked((nint)null);
				goto IL_09f0;
				IL_09f0:
				playerInfo = (PlayerInfo)obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X0_v52+8]");
				usersListModel4 = (UsersListModel)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v462 @ X0_v52] (should have been resolved before IL gen)");
				object obj20 = obj21 & 1;
				if (obj20 != null)
				{
					if (obj9 != null)
					{
						object obj22 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v36+12E]");
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v36+12E]");
						if ((nint)0 == 0)
						{
							goto IL_0253;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v36+B0]");
						object obj23 = (nint)0 + (nint)8;
						object obj12;
						while (true)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v624 @ X10_v19-8]");
							if (0 == (nint)obj)
							{
								break;
							}
							obj12 = obj23 + 16;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v36+12E]");
							num = -1;
							bool flag4 = num != 1;
							obj23 = obj12;
							if (flag4)
							{
								continue;
							}
							goto IL_0253;
						}
						num = (nint)(obj23 + 1);
						object obj24 = obj22 + num;
						obj15 = obj24 + 312;
						obj12 = obj23;
						goto IL_0a62;
					}
					NullReferenceException ex6 = new NullReferenceException();
					enumerator = (List<object>.Enumerator)0;
					playerInfo2 = (PlayerInfo)(&obj8);
					enumerator3 = (List<object>.Enumerator)0;
					usersListModel2 = usersListModel3;
					goto IL_0907;
				}
				enumerator = (List<object>.Enumerator)0;
				playerInfo2 = (PlayerInfo)(&obj8);
				enumerator3 = (List<object>.Enumerator)0;
				object obj25 = 0;
				usersListModel2 = usersListModel3;
				while (true)
				{
					usersListModel3 = (UsersListModel)obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					if (obj26 == null)
					{
						goto IL_0abe;
					}
					object obj27 = obj26;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v22+12E]");
					object obj28 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v22+12E]");
					if ((nint)0 == 0)
					{
						goto IL_047d;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v22+B0]");
					object obj29 = (nint)0 + (nint)8;
					object obj12;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X10_v7-8]");
						if (0 == (nint)obj4)
						{
							break;
						}
						obj12 = obj29 + 16;
						obj28--;
						bool flag5 = (nint)obj28 != 1;
						obj29 = obj12;
						if (flag5)
						{
							continue;
						}
						goto IL_047d;
					}
					object obj30 = obj27 + obj29;
					playerInfo = (PlayerInfo)(obj30 + 312);
					obj12 = obj29;
					goto IL_0b0a;
					IL_0abe:
					bool flag6 = obj25 == null;
					object obj31 = !flag6;
					if (obj31 != null)
					{
						OutOfMemoryException ex7 = new OutOfMemoryException();
						if ((nint)usersListModel3 == 1)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
							obj25 = obj32;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
							enumerator3 = (List<object>.Enumerator)obj32;
							continue;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99B68");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
						return;
					}
					break;
					IL_047d:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					num2 = unchecked((nint)null);
					obj4 = obj26;
					playerInfo = playerInfo3;
					goto IL_0b0a;
					IL_0b0a:
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v4 (PlayerInfo)+8]");
					usersListModel3 = (UsersListModel)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v211 @ X8_v4 (PlayerInfo)] (should have been resolved before IL gen)");
					goto IL_0abe;
				}
				if (usersListModel2 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				func..ctor((object)this, (IntPtr)obj6);
				object obj33 = (nint)0 + (nint)3656;
				IEnumerable<object> enumerable = Enumerable.Where(usersListModel2.<UsersList>k__BackingField, func);
				object obj34 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2696;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj35 = (nint)0 + (nint)296;
				func2..ctor((object)null, (IntPtr)obj35);
				object obj36 = (nint)0 + (nint)2448;
				num2 = (nint)obj36;
				IOrderedEnumerable<object> source = Enumerable.OrderByDescending(enumerable, func2);
				playerInfo = (PlayerInfo)((nint)0 + (nint)2496);
				usersListModel3 = (UsersListModel)(object)playerInfo;
				List<object> list = Enumerable.ToList(source);
				bool flag7 = list == null;
				object obj37 = 0;
				usersListModel2 = (UsersListModel)enumerable;
				if (flag7)
				{
					break;
				}
				List<object>.Enumerator enumerator5 = list.GetEnumerator();
				obj37 = 0;
				usersListModel2 = (UsersListModel)enumerable;
				while (true)
				{
					usersListModel4 = (UsersListModel)obj7;
					if (!enumerator.MoveNext())
					{
						break;
					}
					if ((object)avatarPool == null)
					{
						goto IL_07ea;
					}
					fromPool = avatarPool.GetFromPool();
					if ((object)fromPool != null)
					{
						_ = 44;
						AvatarData data = playerInfo2;
						fromPool.Initialize(data);
						Transform transform = fromPool.transform;
						if ((object)transform != null)
						{
							transform.SetParent(gridLayoutTransform, worldPositionStays: false);
							obj37 = 0;
							num2 = unchecked((nint)null);
							usersListModel2 = (UsersListModel)(object)fromPool;
							continue;
						}
						goto IL_079f;
					}
					goto IL_0823;
				}
				playerInfo = (PlayerInfo)((nint)0 + (nint)40);
				usersListModel3 = (UsersListModel)(object)playerInfo;
				enumerator.Dispose();
				bool flag8 = (object)GridLayout == null;
				enumerator = enumerator3;
				enumerator4 = enumerator3;
				enumerator3 = (List<object>.Enumerator)0;
				obj4 = 44;
				if (flag8)
				{
					break;
				}
				GridLayout.ApplyLayout();
				return;
				IL_079f:
				NullReferenceException ex8 = new NullReferenceException();
				enumerator = enumerator3;
				enumerator4 = enumerator3;
				num2 = unchecked((nint)null);
				enumerator3 = (List<object>.Enumerator)0;
				usersListModel4 = null;
				obj4 = 44;
				playerInfo = (PlayerInfo)(&enumerator);
				usersListModel2 = (UsersListModel)(object)fromPool;
				goto IL_0907;
				IL_07ea:
				NullReferenceException ex9 = new NullReferenceException();
				enumerator = enumerator3;
				enumerator4 = enumerator3;
				enumerator3 = (List<object>.Enumerator)0;
				obj4 = 44;
				playerInfo = (PlayerInfo)(&enumerator);
				goto IL_0907;
			}
		}
		throw new NullReferenceException();
	}

	private void GetNumberOfOnlinePlayers()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_026a: Expected O, but got I4
		//IL_0274: Expected I8, but got I4
		//IL_0286: Expected I8, but got I4
		//IL_01cb: Expected I8, but got O
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_0209: Expected O, but got I4
		//IL_02eb: Expected O, but got I4
		//IL_039a: Expected O, but got I4
		//IL_0330: Expected I, but got O
		//IL_0362: Expected O, but got I4
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		object obj = 152993792;
		object obj2 = typeof(Queue<string>) + 848;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8C67]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2200;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v29+E4]");
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
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v29+E4]");
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
		if ((object)sessionModel != null)
		{
			goto IL_0150;
		}
		goto IL_0405;
		IL_02b3:
		object input;
		long num;
		string text = LocalizationUtil.Localize((string)input, num);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object[] array = default(object[]);
		bool flag3 = array == null;
		object obj8 = 0;
		nint num2 = 1;
		if (flag3)
		{
			goto IL_0405;
		}
		bool flag4 = text == null;
		nint num3 = 1;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag4)
		{
			nint num4 = (nint)array;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
			bool flag5 = ex == null;
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v9 (Il2CppClass<System.Object[]>)+40]");
			num2 = 0;
			if (flag5)
			{
				goto IL_0421;
			}
		}
		bool flag6 = array.Length == 0;
		obj8 = 0;
		num2 = num3;
		if (!flag6)
		{
			object text2 = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3584;
			object obj9 = array + 32;
			obj9 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			LocalizableText text3 = TextMeshProExtensions.LocalizeWith((string)text2, array);
			TextMeshProExtensions.Localize(onlinePlayers, text3);
			return;
		}
		goto IL_0413;
		IL_0294:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj11;
		object obj10 = obj11;
		long num5;
		num = num5;
		goto IL_02b3;
		IL_0405:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0413;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		bool flag7 = (object)sessionModel == null;
		object obj12 = !flag7;
		if (obj12 != null)
		{
			goto IL_0150;
		}
		goto IL_0405;
		IL_0150:
		input = "October" + 2056;
		object obj13 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		Room currentRoom = sessionModel.CurrentRoom;
		int? onlineUsersCount = SFSKammelnaRoomExtensions.GetOnlineUsersCount(currentRoom);
		object obj14 = (??)onlineUsersCount & 1;
		if (obj14 != null)
		{
			num = (object?)onlineUsersCount >> 32;
			obj10 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj15 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v25+E4]");
			bool flag8 = (nint)0 == 0;
			object obj16 = !flag8;
			if (obj16 == null)
			{
				obj11 = obj10;
				num5 = num;
				goto IL_0294;
			}
		}
		else
		{
			obj11 = typeof(TypeConverter<ushort, char>) + 3400;
			object obj15 = obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X0_v25+E4]");
			bool flag9 = (nint)0 == 0;
			object obj17 = !flag9;
			num5 = _onlineUsersCount;
			obj10 = obj11;
			num = _onlineUsersCount;
			if (obj17 == null)
			{
				goto IL_0294;
			}
		}
		goto IL_02b3;
		IL_0413:
		ex = new IndexOutOfRangeException();
		goto IL_0421;
		IL_0421:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private bool <UpdateView>b__16_0(PlayerInfo user)
	{
		//IL_005a: Expected I4, but got O
		List<int> blockedIds = _blockedIds;
		if (user != null && blockedIds != null)
		{
			bool flag = blockedIds.Contains(user.<DBID>k__BackingField);
			return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
		}
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
