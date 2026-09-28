using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Unity.Services.Authentication.Shared;
using UnityEngine;

public class MassTournamentManager : Singleton<MassTournamentManager>
{
	private sealed class <>c__DisplayClass10_0
	{
		public long id;

		internal bool <GetCachedMassEvent>b__0(MassEventModel model)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I8
			if (model != null)
			{
				object obj = model.<Id>k__BackingField - id;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass8_0
	{
		public Action<MassEventModel> callback;

		public long id;

		public Func<MassEventModel, bool> <>9__1;

		internal void <GetMassEvent>b__0(List<MassEventModel> list)
		{
			//IL_0009: Expected O, but got I4
			//IL_001f: Expected O, but got I
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Expected O, but got Unknown
			//IL_0108: Expected O, but got I
			//IL_0122: Expected O, but got I4
			//IL_0132: Expected O, but got I
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Expected O, but got Unknown
			//IL_0060: Expected O, but got I
			//IL_007f: Expected O, but got I
			//IL_00b4: Expected O, but got I
			//IL_00c4: Expected O, but got I
			//IL_00d4: Expected O, but got I
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Expected O, but got Unknown
			//IL_016b: Expected O, but got I
			//IL_0179: Expected I, but got O
			//IL_01c2: Expected O, but got I4
			object obj = 152985600;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E607B]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 == null)
			{
				goto IL_00de;
			}
			object obj3 = this + 32;
			Func<object, bool> predicate = (Func<object, bool>)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X22_v2-10]");
			object obj4 = 0;
			bool flag = obj3 == null;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X22_v2-10]");
			object obj5 = 0;
			if (!flag)
			{
				goto IL_008e;
			}
			goto IL_0141;
			IL_0141:
			object obj6 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2336;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj7 = (nint)0 + (nint)944;
			Func<object, bool> func = default(Func<object, bool>);
			func..ctor((object)this, (IntPtr)obj7);
			<>9__1 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = Enumerable.FirstOrDefault(list, func);
			bool flag2 = obj5 == null;
			object obj9 = !flag2;
			obj4 = obj5;
			if (obj9 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_00a4;
			IL_008e:
			obj8 = Enumerable.FirstOrDefault(list, predicate);
			goto IL_00a4;
			IL_00a4:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X23_v4+18]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X23_v4+40]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X23_v4+28]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v106 @ X3_v4 (should have been resolved before IL gen)");
			goto IL_00de;
			IL_00de:
			_ = 1;
			obj3 = this + 32;
			predicate = (Func<object, bool>)obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X22_v2-10]");
			obj4 = 0;
			bool flag3 = obj3 == null;
			object obj13 = !flag3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X22_v2-10]");
			obj5 = 0;
			if (obj13 != null)
			{
				goto IL_008e;
			}
			goto IL_0141;
		}

		internal bool <GetMassEvent>b__1(MassEventModel model)
		{
			//IL_0053: Expected I4, but got O
			//IL_0031: Expected O, but got I8
			if (model != null)
			{
				object obj = model.<Id>k__BackingField - id;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass9_0
	{
		public Action showLoading;

		public Action failureCallback;

		internal void <JoinRoom>b__0(MassEventModel massEventModel)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected O, but got Unknown
			//IL_0095: Expected O, but got I4
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Expected O, but got Unknown
			//IL_0101: Expected O, but got I
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0122: Expected O, but got Unknown
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Expected O, but got Unknown
			//IL_01fd: Expected O, but got I
			if (massEventModel != null)
			{
				object obj = (??)massEventModel.<AssignedRoomId>k__BackingField & 1;
				if (obj != null && massEventModel.<AssignedServerId>k__BackingField != null)
				{
					object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
					object obj3 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X0_v3+E4]");
					bool flag = (nint)0 == 0;
					object obj4 = !flag;
					if (obj4 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					SFSConfig currentSFS = Config.CurrentSFS;
					int? num = default(int?);
					if (currentSFS.<ID>k__BackingField.Equals(massEventModel.<AssignedServerId>k__BackingField))
					{
						object obj5 = (nint)0 + (nint)3176;
						int value = num.Value;
						object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 3808;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						MassTournamentInfo massTournamentInfo = default(MassTournamentInfo);
						massTournamentInfo..ctor(value);
						SFS.JoinMassTournamentRoom(massTournamentInfo);
						Actions.SafeInvoke(showLoading);
					}
					else
					{
						object obj7 = typeof(RegisteredWaitHandle) + 752;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj8 = default(object);
						obj8..ctor();
						int value2 = num.Value;
						object obj9 = typeof(System.Formats.Asn1.SetOfValueComparer) + 64;
						object obj10 = obj9;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v17+B8]");
						object obj11 = (nint)0 + (nint)8;
						obj11 = obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						SFS.SwitchServer(massEventModel.<AssignedServerId>k__BackingField);
					}
					return;
				}
			}
			Actions.SafeInvoke(failureCallback);
		}
	}

	private MassTournamentsListEventsChannel eventsChannel;

	private OneShotEvent<List<MassEventModel>> <ReadyState>k__BackingField;

	public OneShotEvent<List<MassEventModel>> ReadyState
	{
		get
		{
			return <ReadyState>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 40;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0164: Expected O, but got I
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0184: Expected O, but got I
		//IL_0190: Expected O, but got I
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01d8: Expected O, but got I4
		//IL_01fa: Expected O, but got I
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_022f: Expected I, but got O
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0086: Expected I, but got O
		//IL_00b0: Expected O, but got I4
		//IL_00f3: Expected I, but got O
		//IL_011d: Expected O, but got I4
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = typeof(SqlSingle[]) + 2376;
		object obj3 = (nint)0 + (nint)3392;
		object obj4 = typeof(List<Tween>) + 2912;
		object obj5 = (nint)0 + (nint)2304;
		object obj6 = (nint)0 + (nint)2328;
		object obj7 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2360;
		GameObject gameObject = base.gameObject;
		object obj8 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v3+E4]");
		bool flag = (nint)0 == 0;
		object obj9 = !flag;
		UnityEngine.Object target = gameObject;
		if (obj9 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			target = gameObject;
		}
		object obj10 = (nint)0 + (nint)3400;
		object obj11 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2856;
		UnityEngine.Object.DontDestroyOnLoad(target);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj3);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @399769C");
		object obj12 = this + 40;
		object obj13 = default(object);
		obj12 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(obj12, (IntPtr)obj6);
		object obj14 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v13+E4]");
		bool flag2 = (nint)0 == 0;
		object obj15 = !flag2;
		if (obj15 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Config.OnLastUpdatesChanged += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action3 = default(Action);
		action3..ctor(this, (IntPtr)obj10);
		object obj16 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v18+E4]");
		bool flag3 = (nint)0 == 0;
		object obj17 = !flag3;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ContentPushService.OnMassEventsApplied += action3;
	}

	private void OnMassEventsApplied()
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0068: Expected O, but got I4
		//IL_0167: Expected O, but got I4
		//IL_00ad: Expected O, but got I
		OneShotEvent<List<MassEventModel>> oneShotEvent = <ReadyState>k__BackingField;
		if (oneShotEvent.<IsReady>k__BackingField)
		{
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v14+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			CachedModel<List<MassEventModel>> massEvents = CachedModels.MassEvents;
			object model = ((CachedModel<object>)(object)massEvents).Model;
			object obj4 = (nint)0 + (nint)2336;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997724");
		}
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (!(eventsChannel != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag2 = eventsChannel != null;
			bool flag3 = !flag2;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				return;
			}
		}
		eventsChannel.TriggerTournamentsChanged();
	}

	public static void GetMassEvents(Action<List<MassEventModel>> callback)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_013f: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6073]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2088;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
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
			object obj4 = (nint)0 + (nint)2088;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v5+E4]");
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
		goto IL_0133;
		IL_0133:
		object obj8 = (nint)0 + (nint)2312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj9 = default(object);
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0133;
	}

	public static void GetMassEvent(long id, Action<MassEventModel> callback)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0088: Expected O, but got I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00d4: Expected O, but got I
		//IL_00ef: Expected I, but got O
		//IL_0100: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3096;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(Queue<string>) + 784;
		object obj4 = (nint)0 + (nint)2088;
		object obj5 = obj2 + 16;
		obj5 = callback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v8+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 824;
		object obj9 = (nint)0 + (nint)936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj9);
		object obj10 = (nint)0 + (nint)2312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39978C8");
	}

	public static void JoinRoom(long id, Action showLoading = null, Action failureCallback = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0099: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2616;
		object obj4 = (nint)0 + (nint)952;
		object obj5 = obj2 + 16;
		obj5 = showLoading;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = failureCallback;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj4);
		GetMassEvent(id, action);
	}

	public static MassEventModel GetCachedMassEvent(long id)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0068: Expected O, but got I4
		//IL_00bc: Expected O, but got I
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0101: Expected O, but got I
		//IL_011d: Expected I, but got O
		//IL_0137: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 3088;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		if (obj2 != null)
		{
			object obj3 = typeof(Queue<string>) + 784;
			object obj4 = (nint)0 + (nint)2088;
			object obj5 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj6 = !flag;
			if (obj6 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
			object obj7 = default(object);
			if (obj7 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v9+28]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v9+28]");
				if ((nint)0 != 0)
				{
					object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2336;
					object obj10 = (nint)0 + (nint)928;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor(obj2, (IntPtr)obj10);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v7+20]");
					return (MassEventModel)Enumerable.FirstOrDefault((IEnumerable<object>)0, func);
				}
			}
		}
		return (MassEventModel)(object)new NullReferenceException();
	}

	public static void Clear()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_0104: Expected O, but got I4
		//IL_00b5: Expected O, but got I4
		//IL_005c: Expected O, but got I
		//IL_013f: Expected O, but got I
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0187: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6077]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2088;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v10+E4]");
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
			object obj4 = (nint)0 + (nint)2088;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v10+E4]");
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
		goto IL_0133;
		IL_0133:
		object obj8 = (nint)0 + (nint)2320;
		object obj9 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39979B0");
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v5+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CachedModel<List<MassEventModel>> massEvents = CachedModels.MassEvents;
		((CachedModel<object>)(object)massEvents).Clear();
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
		goto IL_0133;
	}

	private void LoadMassEvents()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_007d: Expected I, but got O
		//IL_00a7: Expected O, but got I4
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj2 = (nint)0 + (nint)3384;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 2872;
		object wireKey = "m_StencilDeferredPS" + 576;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		ContentSyncService.EnsureFresh((string)wireKey, action);
	}

	public MassTournamentManager()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_00d8: Expected O, but got I4
		//IL_005c: Expected O, but got I
		object obj = 152985600;
		object obj2 = typeof(Queue<string>) + 784;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6079]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = (nint)0 + (nint)2080;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
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
			object obj4 = (nint)0 + (nint)2080;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			object obj6 = obj4;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
		return;
		IL_0091:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CECC90");
	}

	private void <LoadMassEvents>b__12_0(bool _)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00e2: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_014c: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E607A]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			int num = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		CachedModel<List<MassEventModel>> massEvents = CachedModels.MassEvents;
		CachedModel<object> cachedModel = (CachedModel<object>)(object)massEvents;
		goto IL_0115;
		IL_0115:
		object model = cachedModel.Model;
		if (model != null)
		{
			object obj5 = (nint)0 + (nint)2336;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3997724");
		}
		return;
		IL_0074:
		CachedModel<List<MassEventModel>> massEvents2 = CachedModels.MassEvents;
		bool flag2 = massEvents2 == null;
		object obj6 = !flag2;
		cachedModel = (CachedModel<object>)(object)massEvents2;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0115;
	}
}
